// Copyright (C) 2021-2025 Steffen Itterheim
// Refer to included LICENSE file for terms and conditions.

using CodeSmile.Luny;
using System;
using System.Collections.Generic;
using System.Linq;
using UnityEditor;
using UnityEngine;

namespace CodeSmileEditor.Luny.Generator
{
	internal static class TypeGenerator
	{
		private const String DisabledWarningCodes = "0162, 0168, 0219"; // Unreachable code, declared / assigned but never used

		public static IEnumerable<GenTypeInfo> Generate(LunyLuaModule module, String contentFolderPath, TypeHierarchy typeHierarchy)
		{
			var boundTypes = new List<GenTypeInfo>();

			var generatableCount = 0;
			var generatedCount = 0;
			typeHierarchy.Visit((node, level) =>
			{
				var type = node.Value;
				if (type.IsEnum)
				{
					// enums are handled by module loader
					boundTypes.Add(new GenTypeInfo(type));
					return;
				}

				// skip the inevitable System types
				if (GenUtil.IsBindableType(type) == false)
					return;

				generatableCount++;

				// TODO filter out types we currently don't support
				if (type.IsGenericType)
				{
					Debug.Log($"Skip generic type: {type}");
					return;
				}

				var typeInfo = new GenTypeInfo(type);
				if (typeInfo.InstanceMembers.HasMembers == false && typeInfo.StaticMembers.HasMembers == false)
					Debug.LogWarning($"{typeInfo.Type.FullName} has no members.");

				generatedCount++;
				boundTypes.Add(typeInfo);

				// if (typeInfo.IsStatic)
				// 	Debug.LogWarning($"Static: {typeInfo.BindTypeFullName}");
				// else if (type.IsAbstract)
				// 	Debug.LogWarning($"Abstract: {typeInfo.BindTypeFullName}");

				// var members = type.GetMembers();
				// foreach (var member in members)
				// {
				// 	Debug.Log($"\t\t{member.MemberType}: {member}");
				// }

				var sb = new ScriptBuilder(GenUtil.GeneratedFileHeader);
				AddUsingStatements(sb, typeInfo.Type.Namespace);
				AddNamespaceBlock(sb, module.BindingsNamespace);
				if (typeInfo.IsStatic == false)
					GenerateInstanceType(sb, typeInfo);
				GenerateStaticType(sb, typeInfo);
				EndNamespaceBlock(sb);

				var assetPath = $"{contentFolderPath}/{typeInfo.InstanceTypeName}.cs";
				GenUtil.WriteFile(assetPath, sb.ToString());
			});

			EditorApplication.delayCall += () => Debug.Log($"{generatedCount} of {generatableCount} " +
			                                               $"({(Int32)(generatedCount / (Single)generatableCount * 100f)}%) " +
			                                               "types generated");

			return boundTypes;
		}

		private static void AddUsingStatements(ScriptBuilder sb, String @namespace)
		{
			sb.AppendLine("using CodeSmile.Luny;");
			sb.AppendLine("using Lua;");
			sb.AppendLine("using Lua.Runtime;");
			sb.AppendLine("using System.Threading.Tasks;");
			sb.Append("using ");
			sb.Append(@namespace);
			sb.AppendLine(";\n");
		}

		private static void AddNamespaceBlock(ScriptBuilder sb, String @namespace)
		{
			sb.Append("#pragma warning disable ");
			sb.AppendLine(DisabledWarningCodes);
			sb.AppendLine();
			sb.Append("namespace ");
			sb.AppendLine(@namespace);
			sb.OpenIndentedBlock("{"); // { namespace
		}

		private static void EndNamespaceBlock(ScriptBuilder sb)
		{
			sb.CloseIndentedBlock("}"); // namespace }
			sb.Append("#pragma warning restore ");
			sb.AppendLine(DisabledWarningCodes);
		}

		private static void GenerateInstanceType(ScriptBuilder sb, GenTypeInfo typeInfo)
		{
			AddTypeDeclaration(sb, typeInfo.InstanceTypeName, false);
			AddInstanceFieldAndProperty(sb, typeInfo.InstanceFieldName, typeInfo.BindTypeFullName);
			AddToStringOverride(sb, typeInfo.InstanceFieldName);
			AddImplicitOperator(sb, typeInfo.InstanceTypeName);
			AddMetatableFieldAndProperty(sb);
			AddLuaBindings(sb, typeInfo, typeInfo.InstanceMembers, out var getters, out var setters);
			AddIndexMetamethod(sb, typeInfo.InstanceTypeName, getters);
			AddNewIndexMetamethod(sb, typeInfo.InstanceTypeName, setters);
			EndTypeDeclaration(sb);
		}

		private static void GenerateStaticType(ScriptBuilder sb, GenTypeInfo typeInfo)
		{
			AddTypeDeclaration(sb, typeInfo.StaticTypeName, true);
			AddBindType(sb, typeInfo.BindTypeFullName);
			sb.AppendIndentedLine("public override string ToString() => BindType.FullName;");
			AddImplicitOperator(sb, typeInfo.StaticTypeName);
			AddMetatableFieldAndProperty(sb);
			AddLuaBindings(sb, typeInfo, typeInfo.StaticMembers, out var getters, out var setters);
			AddIndexMetamethod(sb, typeInfo.StaticTypeName, getters);
			AddNewIndexMetamethod(sb, typeInfo.StaticTypeName, setters);
			EndTypeDeclaration(sb);
		}

		private static void AddLuaBindings(ScriptBuilder sb, GenTypeInfo typeInfo, GenMemberInfo members, out IList<String> getters,
			out IList<String> setters)
		{
			getters = new List<String>();

			// Constructor
			foreach (var ctor in members.CtorGroups)
			{
				if (ctor.Params == null || ctor.Params.Any() == false)
					continue;

				var ctorFuncName = $"_{typeInfo.InstanceTypeName}_ctor";
				getters.Add($"case \"new\": value = {ctorFuncName}; break;");
				AddLuaFunction(sb, ctorFuncName, "new");
				var usedArgNames = new HashSet<String>();
				var duplicateArgNameCount = 0;

				// Variable Declarations
				foreach (var ctorParam in ctor.Params.OrderBy(p => p.Position))
				{
					sb.AppendIndented(ctorParam.TypeFullName);
					sb.Append(" ");

					var argName = ctorParam.Name;
					if (usedArgNames.Add(argName) == false)
					{
						duplicateArgNameCount++;
						argName += duplicateArgNameCount;
						ctorParam.Name = argName;
					}

					sb.Append(argName);
					if (ctorParam.ParamInfo.HasDefaultValue)
					{
						sb.Append(" = ");
						if (ctorParam.Type.IsEnum)
						{
							sb.Append(ctorParam.Type.FullName);
							sb.Append(".");
							sb.Append(ctorParam.ParamInfo.DefaultValue.ToString());
						}
						else
							sb.Append(ctorParam.ParamInfo.RawDefaultValue.ToString());
					}
					sb.AppendLine(";");
				}

				// Get & read arguments
				sb.AppendLine();
				sb.AppendIndentedLine("var _argCount = _context.ArgumentCount;");
				sb.AppendIndentedLine("var _arg0 = _context.GetArgument(0);");
				var isStaticCtor = members.IsStatic;
				if (isStaticCtor == false)
				{
					sb.AppendIndented("var _this = _arg0.Read<");
					sb.Append(typeInfo.BindTypeFullName);
					sb.AppendLine(">();");
				}

				var argCount = ctor.Params.Count;
				for (var i = 1; i < argCount; i++)
				{
					var iStr = i.ToString();
					sb.AppendIndented("var _arg");
					sb.Append(iStr);
					sb.Append(" = _argCount > ");
					sb.Append(iStr);
					sb.Append(" ? _context.GetArgument(");
					sb.Append(iStr);
					sb.AppendLine(") : LuaValue.Nil;");
				}

				sb.AppendIndentedLine("return new ValueTask<int>(_context.Return());");
				EndLuaFunction(sb);
			}

			setters = null;
		}

		private static void AddLuaFunction(ScriptBuilder sb, String funcName, String luaFuncName)
		{
			sb.AppendIndented("private static readonly LuaFunction ");
			sb.Append(funcName);
			sb.Append(" = new(\"");
			sb.Append(luaFuncName);
			sb.AppendLine("\", (_context, _) =>");
			sb.OpenIndentedBlock("{");
		}

		private static void EndLuaFunction(ScriptBuilder sb) => sb.CloseIndentedBlock("});");

		private static void AddToStringOverride(ScriptBuilder sb, String fieldName)
		{
			sb.AppendIndented("public override string ToString() => ");
			sb.Append(fieldName);
			sb.AppendLine(".ToString();");
		}

		private static void AddTypeDeclaration(ScriptBuilder sb, String typeName, Boolean isSealed)
		{
			sb.AppendIndented("public ");
			sb.Append(isSealed ? "sealed " : "");
			sb.Append("class ");
			sb.Append(typeName);
			sb.AppendLine(" : ILuaUserData");
			sb.OpenIndentedBlock("{"); // { class
		}

		private static void EndTypeDeclaration(ScriptBuilder sb) => sb.CloseIndentedBlock("}"); // class }

		private static void AddInstanceFieldAndProperty(ScriptBuilder sb, String fieldName, String typeFullName)
		{
			sb.AppendIndented("private ");
			sb.Append(typeFullName);
			sb.Append(" ");
			sb.Append(fieldName);
			sb.AppendLine(";");

			sb.AppendIndented("public ");
			sb.Append(typeFullName);
			sb.Append(" ");
			sb.Append(fieldName.Substring(2));
			sb.Append(" { get => ");
			sb.Append(fieldName);
			sb.Append("; set => ");
			sb.Append(fieldName);
			sb.AppendLine(" = value; }");
		}

		private static void AddBindType(ScriptBuilder sb, String typeName)
		{
			sb.AppendIndented("public static System.Type BindType => typeof(");
			sb.Append(typeName);
			sb.AppendLine(");");
		}

		private static void AddImplicitOperator(ScriptBuilder sb, String typeName)
		{
			sb.AppendIndented("public static implicit operator LuaValue(");
			sb.Append(typeName);
			sb.AppendLine(" value) => new(value);");
		}

		private static void AddMetatableFieldAndProperty(ScriptBuilder sb)
		{
			sb.AppendIndentedLine("private static LuaTable s_Metatable;");
			sb.AppendIndentedLine("public LuaTable Metatable");
			sb.OpenIndentedBlock("{"); // { Metatable
			sb.AppendIndentedLine("get => s_Metatable ??= LunyUserdataMetatable.Create(__index, __newindex);");
			sb.AppendIndentedLine("set => throw new System.NotSupportedException(\"Metatable of bound types not assignable\");");
			sb.CloseIndentedBlock("}"); // Metatable }
		}

		private static void AddIndexMetamethod(ScriptBuilder sb, String typeName, IEnumerable<String> getters)
		{
			sb.AppendIndentedLine("private static readonly LuaFunction __index = new(Metamethods.Index, (context, _) =>");
			sb.OpenIndentedBlock("{");
			sb.AppendIndented("var instance = context.GetArgument<");
			sb.Append(typeName);
			sb.AppendLine(">(0);");
			sb.AppendIndentedLine("var key = context.GetArgument<string>(1);");
			sb.AppendIndentedLine("var value = LuaValue.Nil;");
			sb.AppendIndentedLine("switch (key)");
			sb.OpenIndentedBlock("{");
			foreach (var getter in getters)
				sb.AppendIndentedLine(getter);
			sb.AppendIndentedLine("default: throw new LuaRuntimeException(context.Thread, instance, 2);");
			sb.CloseIndentedBlock("}");
			sb.AppendIndentedLine("return new ValueTask<int>(context.Return(value));");
			sb.CloseIndentedBlock("});");
		}

		private static void AddNewIndexMetamethod(ScriptBuilder sb, String typeName, IEnumerable<String> setters)
		{
			sb.AppendIndentedLine("private static readonly LuaFunction __newindex = new(Metamethods.NewIndex, (context, _) =>");
			sb.OpenIndentedBlock("{");
			sb.AppendIndented("var instance = context.GetArgument<");
			sb.Append(typeName);
			sb.AppendLine(">(0);");
			sb.AppendIndentedLine("var key = context.GetArgument<string>(1);");
			sb.AppendIndentedLine("var value = context.GetArgument(2);");
			sb.AppendIndentedLine("switch (key)");
			sb.OpenIndentedBlock("{");
			if (setters != null)
			{
				foreach (var setter in setters)
					sb.AppendIndentedLine(setter);
			}
			sb.AppendIndentedLine("default: throw new LuaRuntimeException(context.Thread, instance, 2);");
			sb.CloseIndentedBlock("}");
			sb.AppendIndentedLine("return new ValueTask<int>(context.Return(0));");
			sb.CloseIndentedBlock("});");
		}
	}
}
