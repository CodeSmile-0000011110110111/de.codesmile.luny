// Copyright (C) 2021-2025 Steffen Itterheim
// Refer to included LICENSE file for terms and conditions.

using CodeSmile.Luny;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using UnityEditor;
using UnityEngine;

namespace CodeSmileEditor.Luny.Generator
{
	internal static class TypeGenerator
	{
		private const String DisabledWarningCodes = "0162, 0168, 0219"; // Unreachable code, declared / assigned but never used

		public static IEnumerable<GenTypeInfo> Generate(LunyLuaModule module, String contentFolderPath, TypeHierarchy typeHierarchy,
			String onlyThisMethodName = null)
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

				var typeInfo = new GenTypeInfo(type, onlyThisMethodName);
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
			sb.AppendLine("using Lua.Unity;");
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
			AddMetatableFieldAndProperty(sb);
			AddConstructor(sb, typeInfo);
			AddImplicitOperator(sb, typeInfo.InstanceTypeName);
			AddToStringOverride(sb, typeInfo.InstanceFieldName);
			AddLuaBindings(sb, typeInfo, typeInfo.InstanceMembers, out var getters, out var setters);
			AddIndexMetamethod(sb, typeInfo.InstanceTypeName, getters);
			AddNewIndexMetamethod(sb, typeInfo.InstanceTypeName, setters);
			EndTypeDeclaration(sb);
		}

		private static void GenerateStaticType(ScriptBuilder sb, GenTypeInfo typeInfo)
		{
			AddTypeDeclaration(sb, typeInfo.StaticTypeName, true);
			AddBindType(sb, typeInfo.BindTypeFullName);
			sb.AppendIndentLine("public override string ToString() => BindType.FullName;");
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

			// Constructors
			var isCtor = true;
			foreach (var methodGroup in members.CtorGroups)
			{
				var bindFuncName = $"_{typeInfo.InstanceTypeName}_ctor";
				getters.Add($"case \"new\": value = {bindFuncName}; break;");
				AddLuaFunction(sb, bindFuncName, "new");

				var isInstanceMethod = !(members.IsStatic || isCtor);
				var luaArgCount = methodGroup.MaxArgCount + (isInstanceMethod ? 1 : 0);
				AddParamTypeChecksAndMakeCall(sb, typeInfo, methodGroup, luaArgCount, 0);
				sb.AppendIndentLine("throw new System.ArgumentException();");
				EndLuaFunction(sb);
			}

			setters = null;
		}

		private static void AddParamTypeChecksAndMakeCall(ScriptBuilder sb, GenTypeInfo typeInfo, GenMethodGroup methodGroup, Int32 luaArgCount,
			Int32 pos)
		{
			var isInstanceMethod = luaArgCount > methodGroup.MaxArgCount;
			var luaArgOffset = luaArgCount - methodGroup.MaxArgCount;
			var posStr = pos.ToString();
			if (pos == 0)
			{
				sb.AppendIndentLine("var _argCount = _context.ArgumentCount;");
				if (isInstanceMethod)
					AddGetInstanceFromLuaContext(sb);
			}

			var isFirstOverload = true;
			var hasParams = methodGroup.OverloadsByParamType?.Count > pos;
			if (hasParams)
			{
				var overloadsAtPos = methodGroup.OverloadsByParamType[pos];

				foreach (var overloadsByParamType in overloadsAtPos)
				{
					var paramAtPos = overloadsByParamType.Key;
					var overloadsWithSameParamType = overloadsByParamType.Value;
					if (isFirstOverload)
					{
						isFirstOverload = false;
						AddGetArgumentFromLuaContext(sb, posStr, (pos + luaArgOffset).ToString());
					}

					AddReadValueConditional(sb, paramAtPos, posStr);
					if (overloadsWithSameParamType.Count > 1)
						AddParamTypeChecksAndMakeCall(sb, typeInfo, methodGroup, luaArgCount, pos + 1);

					foreach (var overload in overloadsWithSameParamType)
					{
						var paramCount = overload.ParamInfos.Length;
						var paramCountMatches = paramCount == pos + 1;
						var needsExtraBlock = paramCountMatches && overloadsWithSameParamType.Count > 1;

						// if we only have one left or the param count matches
						if (overloadsWithSameParamType.Count == 1 || paramCountMatches)
						{
							if (needsExtraBlock) sb.OpenIndentedBlock("{");
							AddRemainingParametersReadsAndAssignments(sb, overload, luaArgOffset, pos);
							AddMethodCallAndReturn(sb, typeInfo, overload);
							if (needsExtraBlock) sb.CloseIndentedBlock("}");
						}
					}

					sb.CloseIndentedBlock("}");
				}
			}

			if (pos == 0 && (typeInfo.Type.IsValueType || hasParams == false) && methodGroup.Methods != null)
			{
				var method = methodGroup.Methods.FirstOrDefault();
				if (method != null)
				{
					sb.OpenIndentedBlock("{");
					var methodInfo = new GenMethodInfo { MethodInfo = method, ParamInfos = new GenParamInfo[0] };
					AddMethodCallAndReturn(sb, typeInfo, methodInfo);
					sb.CloseIndentedBlock("}");
				}
			}
		}

		private static void AddReadValueConditional(ScriptBuilder sb, GenParamInfo parameter, String posStr)
		{
			var hasDefaultValue = parameter.ParamInfo.HasDefaultValue;
			sb.AppendIndent(hasDefaultValue ? "var " : "if (");
			AddReadLuaValueStatement(sb, posStr, parameter);
			sb.AppendLine(hasDefaultValue ? ";" : ")");
			sb.OpenIndentedBlock("{");
		}

		private static void AddRemainingParametersReadsAndAssignments(ScriptBuilder sb, GenMethodInfo overload, Int32 luaArgOffset, Int32 pos)
		{
			// get remaining arguments
			var parameters = overload.ParamInfos;
			for (var paramIndex = pos + 1; paramIndex < parameters.Length; paramIndex++)
				AddGetArgumentFromLuaContext(sb, paramIndex.ToString(), (paramIndex + luaArgOffset).ToString());

			// re-assign variables for readability in method call
			for (var paramIndex = 0; paramIndex < parameters.Length; paramIndex++)
			{
				if (paramIndex <= pos)
				{
					sb.AppendIndent("var ");
					sb.Append(parameters[paramIndex].Name);
					sb.Append(" = ");
					sb.Append(parameters[paramIndex].VariableName);
					sb.AppendLine(";");
				}
				else
				{
					sb.AppendIndent(parameters[paramIndex].ParamInfo.HasDefaultValue ? "var " : "");
					AddReadLuaValueStatement(sb, paramIndex.ToString(), parameters[paramIndex], true);
					sb.AppendLine(";");
				}
			}
		}

		private static void AddMethodCallAndReturn(ScriptBuilder sb, GenTypeInfo typeInfo, GenMethodInfo overload)
		{
			// make the call
			var methodInfo = overload.MethodInfo as MethodInfo;
			var ctorInfo = overload.MethodInfo as ConstructorInfo;
			var isCtor = ctorInfo != null;

			var returnCount = isCtor || methodInfo.ReturnType != typeof(void) ? 1 : 0;
			var methodName = isCtor ? ctorInfo.DeclaringType.FullName.Replace('+', '.') : methodInfo.Name;

			sb.AppendIndent();
			if (returnCount > 0)
				sb.Append("var _retval0 = ");
			if (isCtor)
			{
				sb.Append("new ");
				sb.Append(typeInfo.InstanceTypeName);
				sb.Append("(new ");
			}
			sb.Append(methodName);
			sb.Append("(");

			for (var i = 0; i < overload.ParamInfos.Length; i++)
			{
				if (i > 0)
					sb.Append(", ");

				sb.Append(overload.ParamInfos[i].Name);
			}
			sb.AppendLine(isCtor ? "));" : ");");

			sb.AppendIndent("return new ValueTask<int>(_context.Return(");
			for (var i = 0; i < returnCount; i++)
			{
				if (i > 0)
					sb.Append(", ");
				sb.Append("_retval");
				sb.Append(i.ToString());
			}
			sb.AppendLine("));");
		}

		private static void AddGetInstanceFromLuaContext(ScriptBuilder sb) =>
			sb.AppendIndentLine("var _instance = _context.GetArgument<ILuaUserData>(0);");

		private static void AddGetArgumentFromLuaContext(ScriptBuilder sb, String posStr, String luaArgPosStr)
		{
			sb.AppendIndent("var _arg");
			sb.Append(posStr);
			sb.Append(" = _argCount > ");
			sb.Append(luaArgPosStr);
			sb.Append(" ? _context.GetArgument(");
			sb.Append(luaArgPosStr);
			sb.AppendLine(") : LuaValue.Nil;");
		}

		private static void AddReadLuaValueStatement(ScriptBuilder sb, String posStr, GenParamInfo parameter, Boolean useSignatureName = false)
		{
			// FIXME: optimize to read specific value types when possible
			if (parameter.ParamInfo.HasDefaultValue)
			{
				sb.Append(useSignatureName ? parameter.Name : parameter.VariableName);
				sb.Append(" = ");
				sb.Append("_arg");
				sb.Append(posStr);
				sb.Append(".ReadValue<");
				sb.Append(parameter.Type.FullName);
				sb.Append(">(");
				if (parameter.Type.IsEnum)
				{
					sb.Append(parameter.Type.FullName);
					sb.Append(".");
					sb.Append(parameter.ParamInfo.DefaultValue.ToString());
				}
				else
					sb.Append(parameter.ParamInfo.RawDefaultValue.ToString());
				sb.Append(")");
			}
			else
			{
				sb.Append("_arg");
				sb.Append(posStr);
				sb.Append(".TryRead<");
				sb.Append(parameter.TypeFullName);
				sb.Append(">(out var ");
				sb.Append(useSignatureName ? parameter.Name : parameter.VariableName);
				sb.Append(")");
			}
		}

		private static void AddGetLuaArguments(ScriptBuilder sb, GenMemberInfo members, GenMethodGroup methodGroup)
		{
			// FIXME: move these inline with reading values to avoid always reading the max # of args
			var luaArgCount = methodGroup.MaxArgCount + (members.IsStatic ? 0 : 1);
			sb.AppendIndentLine("var _argCount = _context.ArgumentCount;");
			for (var argNum = 0; argNum < luaArgCount; argNum++)
			{
				var argNumStr = argNum.ToString();
				sb.AppendIndent("var _arg");
				sb.Append(argNumStr);
				sb.Append(" = _argCount > ");
				sb.Append(argNumStr);
				sb.Append(" ? _context.GetArgument(");
				sb.Append(argNumStr);
				sb.AppendLine(") : LuaValue.Nil;");
			}
		}

		private static void AddLuaFunction(ScriptBuilder sb, String funcName, String luaFuncName)
		{
			sb.AppendIndent("private static readonly LuaFunction ");
			sb.Append(funcName);
			sb.Append(" = new(\"");
			sb.Append(luaFuncName);
			sb.AppendLine("\", (_context, _) =>");
			sb.OpenIndentedBlock("{");
		}

		private static void EndLuaFunction(ScriptBuilder sb) => sb.CloseIndentedBlock("});");

		private static void AddToStringOverride(ScriptBuilder sb, String fieldName)
		{
			sb.AppendIndent("public override string ToString() => ");
			sb.Append(fieldName);
			sb.AppendLine(".ToString();");
		}

		private static void AddTypeDeclaration(ScriptBuilder sb, String typeName, Boolean isSealed)
		{
			sb.AppendIndent("public ");
			sb.Append(isSealed ? "sealed " : "");
			sb.Append("class ");
			sb.Append(typeName);
			sb.AppendLine(" : ILuaUserData");
			sb.OpenIndentedBlock("{"); // { class
		}

		private static void EndTypeDeclaration(ScriptBuilder sb) => sb.CloseIndentedBlock("}"); // class }

		private static void AddInstanceFieldAndProperty(ScriptBuilder sb, String fieldName, String typeFullName)
		{
			sb.AppendIndent("private ");
			sb.Append(typeFullName);
			sb.Append(" ");
			sb.Append(fieldName);
			sb.AppendLine(";");

			sb.AppendIndent("public ");
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
			sb.AppendIndent("public static System.Type BindType => typeof(");
			sb.Append(typeName);
			sb.AppendLine(");");
		}

		private static void AddConstructor(ScriptBuilder sb, GenTypeInfo typeInfo)
		{
			sb.AppendIndent("public ");
			sb.Append(typeInfo.InstanceTypeName);
			sb.Append("(");
			sb.Append(typeInfo.BindTypeFullName);
			sb.Append(" ");
			var paramName = typeInfo.InstanceFieldName.Substring(2).ToLower();
			sb.Append(paramName);
			sb.Append(") => ");
			sb.Append(typeInfo.InstanceFieldName);
			sb.Append(" = ");
			sb.Append(paramName);
			sb.AppendLine(";");
		}

		private static void AddImplicitOperator(ScriptBuilder sb, String typeName)
		{
			sb.AppendIndent("public static implicit operator LuaValue(");
			sb.Append(typeName);
			sb.AppendLine(" value) => new(value);");
		}

		private static void AddMetatableFieldAndProperty(ScriptBuilder sb)
		{
			sb.AppendIndentLine("private static LuaTable s_Metatable;");
			sb.AppendIndentLine("public LuaTable Metatable");
			sb.OpenIndentedBlock("{"); // { Metatable
			sb.AppendIndentLine("get => s_Metatable ??= LunyUserdataMetatable.Create(__index, __newindex);");
			sb.AppendIndentLine("set => throw new System.NotSupportedException(\"Metatable of bound types not assignable\");");
			sb.CloseIndentedBlock("}"); // Metatable }
		}

		private static void AddIndexMetamethod(ScriptBuilder sb, String typeName, IEnumerable<String> getters)
		{
			sb.AppendIndentLine("private static readonly LuaFunction __index = new(Metamethods.Index, (context, _) =>");
			sb.OpenIndentedBlock("{");
			sb.AppendIndent("var instance = context.GetArgument<");
			sb.Append(typeName);
			sb.AppendLine(">(0);");
			sb.AppendIndentLine("var key = context.GetArgument<string>(1);");
			sb.AppendIndentLine("var value = LuaValue.Nil;");
			sb.AppendIndentLine("switch (key)");
			sb.OpenIndentedBlock("{");
			foreach (var getter in getters)
				sb.AppendIndentLine(getter);
			sb.AppendIndentLine("default: throw new LuaRuntimeException(context.Thread, instance, 2);");
			sb.CloseIndentedBlock("}");
			sb.AppendIndentLine("return new ValueTask<int>(context.Return(value));");
			sb.CloseIndentedBlock("});");
		}

		private static void AddNewIndexMetamethod(ScriptBuilder sb, String typeName, IEnumerable<String> setters)
		{
			sb.AppendIndentLine("private static readonly LuaFunction __newindex = new(Metamethods.NewIndex, (context, _) =>");
			sb.OpenIndentedBlock("{");
			sb.AppendIndent("var instance = context.GetArgument<");
			sb.Append(typeName);
			sb.AppendLine(">(0);");
			sb.AppendIndentLine("var key = context.GetArgument<string>(1);");
			sb.AppendIndentLine("var value = context.GetArgument(2);");
			sb.AppendIndentLine("switch (key)");
			sb.OpenIndentedBlock("{");
			if (setters != null)
			{
				foreach (var setter in setters)
					sb.AppendIndentLine(setter);
			}
			sb.AppendIndentLine("default: throw new LuaRuntimeException(context.Thread, instance, 2);");
			sb.CloseIndentedBlock("}");
			sb.AppendIndentLine("return new ValueTask<int>(context.Return(0));");
			sb.CloseIndentedBlock("});");
		}
	}
}
