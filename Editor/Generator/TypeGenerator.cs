// Copyright (C) 2021-2025 Steffen Itterheim
// Refer to included LICENSE file for terms and conditions.

using CodeSmile.Luny;
using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
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
			foreach (var ctorGroup in members.CtorGroups)
			{
				if (ctorGroup.UniqueParams == null)
					continue;

				var ctorFuncName = $"_{typeInfo.InstanceTypeName}_ctor";
				getters.Add($"case \"new\": value = {ctorFuncName}; break;");
				AddLuaFunction(sb, ctorFuncName, "new");
				AddVariableDeclarations(sb, ctorGroup);

				// switch over argument count
				sb.AppendIndentedLine("var _argCount = _context.ArgumentCount;");
				sb.AppendIndentedLine("switch (_argCount)");
				sb.OpenIndentedBlock("{");

				var maxParamCount = ctorGroup.OverloadsBySignature.Count;
				AddSignatureTypeChecksAndMakeCall(sb, ctorGroup, 0);
				for (int pos = 0; pos < maxParamCount; pos++)
				{
				}

				/*for (int paramCount = 0; paramCount < ctorGroup.MethodsByParamCount.Count; paramCount++)
				{
					var overloads = ctorGroup.MethodsByParamCount[paramCount];
					if (overloads == null)
						continue;

					var luaArgCount = members.IsStatic ? paramCount : paramCount + 1;
					var minArgCount = ctorGroup.MinArgCountByParamCount[paramCount];

					for (int caseNum = minArgCount; caseNum <= paramCount; caseNum++)
					{
						sb.AppendIndented("case ");
						sb.Append(caseNum.ToString());
						sb.AppendLine(":");

						if (caseNum == paramCount)
						{
							sb.OpenIndentedBlock("{");

							// Get arguments
							for (var argNum = 0; argNum < luaArgCount; argNum++)
							{
								var argNumStr = argNum.ToString();
								sb.AppendIndented("var _arg");
								sb.Append(argNumStr);
								sb.Append(" = _argCount > ");
								sb.Append(argNumStr);
								sb.Append(" ? _context.GetArgument(");
								sb.Append(argNumStr);
								sb.AppendLine(") : LuaValue.Nil;");
							}
						}
					}

					sb.AppendIndentedLine($"// {minArgCount} to {paramCount}");

					// var isLastOverload = overloadIndex == overloadCount - 1;
					// if (isLastOverload || ctorGroup.Overloads[overloadIndex + 1].GetParameters().Length > paramCount)
					{
						sb.AppendIndentedLine("throw new LuaRuntimeException(_context.Thread, new LuaValue(), 2);");
						sb.CloseIndentedBlock("}");
					}
				}*/
				

				/*
				var caseIndex = ctorGroup.MinArgCount;
				var currentParamCount = ctorGroup.MinArgCount;
				var overloadCount = ctorGroup.Overloads.Count;
				for (var overloadIndex = 0; overloadIndex < overloadCount; overloadIndex--)
				{
					var overload = ctorGroup.Overloads[overloadIndex];
					var methodParams = overload.GetParameters();
					var paramCount = methodParams.Length;
					var argCount = members.IsStatic ? paramCount : paramCount + 1;

					for (; caseIndex <= paramCount; caseIndex++)
					{
						sb.AppendIndented("case ");
						sb.Append(caseIndex.ToString());
						sb.AppendLine(":");
						if (caseIndex == paramCount)
						{
							sb.OpenIndentedBlock("{");

							// Get arguments
							for (var argNum = 0; argNum < argCount; argNum++)
							{
								var argNumStr = argNum.ToString();
								sb.AppendIndented("var _arg");
								sb.Append(argNumStr);
								sb.Append(" = _argCount > ");
								sb.Append(argNumStr);
								sb.Append(" ? _context.GetArgument(");
								sb.Append(argNumStr);
								sb.AppendLine(") : LuaValue.Nil;");
							}
						}
					}

					sb.AppendIndentedLine($"// {paramCount}");

					// // Read arguments
					// for (var argNum = 0; argNum < argCount; argNum++)
					// {
					// 	var argNumStr = argNum.ToString();
					// 	var parameter = methodParams[argNum];
					//
					// 	sb.AppendIndented(argNum == 0 ? "if (_arg" : "_arg");
					// 	sb.Append(argNumStr);
					// 	sb.Append(".TryRead<");
					// 	sb.Append(parameter.ParameterType.FullName);
					// 	sb.Append(">(out ");
					// 	sb.Append(argNumStr);
					// 	sb.AppendLine(argNum < argCount - 1 ? ") &&" : "))");
					// 	sb.OpenIndentedBlock("{");
					//
					// 	sb.AppendIndentedLine("return new ValueTask<int>(_context.Return());");
					// 	sb.CloseIndentedBlock("}");
					// }


					var isLastOverload = overloadIndex == overloadCount - 1;
					if (isLastOverload || ctorGroup.Overloads[overloadIndex + 1].GetParameters().Length > paramCount)
					{
						sb.AppendIndentedLine("throw new LuaRuntimeException(_context.Thread, new LuaValue(), 2);");
						sb.CloseIndentedBlock("}");
					}
				}*/

				sb.CloseIndentedBlock("}"); // switch
				sb.AppendIndentedLine("throw new System.NotImplementedException();");

				EndLuaFunction(sb);
			}

			setters = null;
		}

		private static void AddSignatureTypeChecksAndMakeCall(ScriptBuilder sb, GenMethodGroup methodGroup, Int32 pos)
		{
			if (methodGroup.OverloadsBySignature.Count == 0)
				return;

			var indent = new String('\t', pos);
			var signatureTypesAtPos = methodGroup.OverloadsBySignature[pos];
			if (signatureTypesAtPos.Count > 1)
			{
				int typeCheckCount = 0;
				foreach (var paramTypeAtPos in signatureTypesAtPos.Keys)
				{
					if (typeCheckCount == 0)
						sb.AppendIndentedLine($"// {pos}{indent} if (type == {paramTypeAtPos.FullName})");
					else
						sb.AppendIndentedLine($"// {pos}{indent} else if (type == {paramTypeAtPos.FullName})");

					typeCheckCount++;

					var nextPos = pos + 1;
					if (methodGroup.OverloadsBySignature.Count > nextPos)
						AddSignatureTypeChecksAndMakeCall(sb, methodGroup, nextPos);
				}

				sb.AppendIndentedLine($"// {pos}{indent} else throw new Exception();");
			}
			else
			{
				// make the call
				sb.AppendIndentedLine($"// {indent} has {signatureTypesAtPos.Values.First().Count().ToString()} overloads");
				foreach (var overload in signatureTypesAtPos.Values.First())
				{
					sb.AppendIndented($"// {pos}{indent} make call to {overload.MethodInfo.Name}: ");

					foreach (var paramInfo in overload.ParamInfos)
					{
						sb.Append(paramInfo.Type.Name);
						sb.Append(" ");
						sb.Append(paramInfo.Name);
						sb.Append(", ");
					}
					sb.AppendLine();
				}
			}
		}

		private static void AddVariableDeclarations(ScriptBuilder sb, GenMethodGroup methodGroup)
		{
			var duplicateArgNameCount = 0;
			var usedArgNames = new HashSet<String>();

			foreach (var parameter in methodGroup.UniqueParams)
			{
				sb.AppendIndented(parameter.TypeFullName);
				sb.Append(" ");

				var argName = parameter.Name;
				if (usedArgNames.Add(argName) == false)
				{
					duplicateArgNameCount++;
					argName += duplicateArgNameCount;
					parameter.Name = argName;
				}

				sb.Append(argName);
				if (parameter.ParamInfo.HasDefaultValue)
				{
					sb.Append(" = ");
					if (parameter.Type.IsEnum)
					{
						sb.Append(parameter.Type.FullName);
						sb.Append(".");
						sb.Append(parameter.ParamInfo.DefaultValue.ToString());
					}
					else
						sb.Append(parameter.ParamInfo.RawDefaultValue.ToString());
				}
				sb.AppendLine(";");
			}
			sb.AppendLine();
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
