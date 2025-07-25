// Copyright (C) 2021-2025 Steffen Itterheim
// Refer to included LICENSE file for terms and conditions.

using CodeSmile.Luny;
using System;
using System.Collections.Generic;
using System.Reflection;
using Unity.Profiling;
using UnityEditor;
using UnityEngine;

namespace CodeSmileEditor.Luny.Generator
{
	internal static class TypeGenerator
	{
		private const String DisabledWarningCodes = "0162, 0168, 0219"; // Unreachable code, declared / assigned but never used
		private static readonly String[] Digits =
			{ "0", "1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12", "13", "14", "15", "16", "17", "18", "19" };

		private static Dictionary<Type, GenTypeInfo> s_TypeInfosByType;

		public static IEnumerable<GenTypeInfo> Generate(LunyLuaModule module, String contentFolderPath, TypeHierarchy typeHierarchy,
			String onlyThisMethodName = null)
		{
			var generatedTypeInfos = new List<GenTypeInfo>();
			s_TypeInfosByType = new Dictionary<Type, GenTypeInfo>();

			var generatableCount = 0;
			var generatedCount = 0;
			typeHierarchy.Visit((node, level) =>
			{
				var type = node.Value;

				// skip the inevitable System types
				if (GenUtil.IsBindableType(type) == false)
					return;

				generatableCount++;

				// TODO filter out types we currently don't support
				if (type.IsGenericType)
				{
					Debug.LogWarning($"Ignoring generic type: {type}");
					return;
				}

				var typeInfo = new GenTypeInfo(type, onlyThisMethodName);
				generatedTypeInfos.Add(typeInfo);
				s_TypeInfosByType.Add(type, typeInfo);

				generatedCount++;
			});

			foreach (var typeInfo in generatedTypeInfos)
			{
				// enums are handled by module loader
				if (typeInfo.Type.IsEnum)
					continue;

				var sb = new ScriptBuilder(GenUtil.GeneratedFileHeader);
				AddUsingStatements(sb, typeInfo.Type.Namespace);
				AddNamespaceBlock(sb, module.BindingsNamespace);
				if (typeInfo.IsStatic == false)
					GenerateInstanceType(sb, typeInfo);
				GenerateStaticType(sb, typeInfo);
				EndNamespaceBlock(sb);

				var assetPath = $"{contentFolderPath}/{typeInfo.InstanceTypeName}.cs";
				GenUtil.WriteFile(assetPath, sb.ToString());
			}

			EditorApplication.delayCall += () => Debug.Log($"{generatedCount} of {generatableCount} " +
			                                               $"({(Int32)(generatedCount / (Single)generatableCount * 100f)}%) " +
			                                               "types generated");

			s_TypeInfosByType.Clear();
			return generatedTypeInfos;
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
			sb.OpenIndentBlock("{"); // { namespace
		}

		private static void EndNamespaceBlock(ScriptBuilder sb)
		{
			sb.CloseIndentBlock("}"); // namespace }
			sb.Append("#pragma warning restore ");
			sb.AppendLine(DisabledWarningCodes);
		}

		private static void GenerateInstanceType(ScriptBuilder sb, GenTypeInfo typeInfo)
		{
			AddOpenTypeDeclaration(sb, typeInfo.InstanceTypeName, false);
			AddInstanceFieldAndProperty(sb, typeInfo.InstanceFieldName, typeInfo.BindTypeFullName);
			AddMetatableFieldAndProperty(sb);
			AddConstructor(sb, typeInfo);
			AddImplicitOperator(sb, typeInfo.InstanceTypeName);
			AddInstanceTypeToStringOverride(sb, typeInfo.InstanceFieldName);
			AddLuaBindings(sb, typeInfo, typeInfo.InstanceMembers, out var getters, out var setters);
			AddIndexMetamethod(sb, typeInfo.InstanceTypeName, getters);
			AddNewIndexMetamethod(sb, typeInfo.InstanceTypeName, setters);
			AddCloseTypeDeclaration(sb);
		}

		private static void GenerateStaticType(ScriptBuilder sb, GenTypeInfo typeInfo)
		{
			AddOpenTypeDeclaration(sb, typeInfo.StaticTypeName, true);
			AddBindType(sb, typeInfo.BindTypeFullName);
			AddStaticTypeToStringOverride(sb);
			AddImplicitOperator(sb, typeInfo.StaticTypeName);
			AddMetatableFieldAndProperty(sb);
			AddLuaBindings(sb, typeInfo, typeInfo.StaticMembers, out var getters, out var setters);
			AddIndexMetamethod(sb, typeInfo.StaticTypeName, getters);
			AddNewIndexMetamethod(sb, typeInfo.StaticTypeName, setters);
			AddCloseTypeDeclaration(sb);
		}

		private static void AddLuaBindings(ScriptBuilder sb, GenTypeInfo typeInfo, GenMemberInfo members, out IList<String> getters,
			out IList<String> setters)
		{
			getters = new List<String>();
			AddMethodBindings(sb, typeInfo, members.CtorOverloads, getters);
			AddMethodBindings(sb, typeInfo, members.MethodOverloads, getters);

			setters = null;
		}

		private static void AddMethodBindings(ScriptBuilder sb, GenTypeInfo typeInfo, IEnumerable<GenMethodOverloads> methodOverloads,
			IList<String> getters)
		{
			foreach (var overloads in methodOverloads)
			{
				if (overloads.Count == 0)
				{
					Debug.LogError($"{typeInfo.Type.Name}: empty overloads for {overloads.Name}");
					continue;
				}

				var bindFuncName = GenerateGetterCase(typeInfo, getters, overloads);
				AddOpenLuaBindFunction(sb, bindFuncName, "new");
				AddReadArgumentCount(sb);
				if (overloads.IsConstructor && typeInfo.Type.IsValueType)
					AddValueTypeParameterlessCtor(sb, typeInfo);
				if (overloads.IsInstanceMethod)
					AddGetInstanceFromLuaArguments(sb, typeInfo);
				AddReadArgumentsAndSelectOverloadAndMakeCallRecursive(sb, typeInfo, overloads, 0, 0, null);
				AddCloseLuaBindFunction(sb);
			}
		}

		private static String GenerateGetterCase(GenTypeInfo typeInfo, IList<String> getters, GenMethodOverloads overloads)
		{
			var isCtor = overloads.IsConstructor;
			var bindFuncNameSuffix = isCtor ? "ctor" : overloads.Name;
			var bindFuncName = $"_{typeInfo.InstanceTypeName}_{bindFuncNameSuffix}";
			var indexCaseName = isCtor ? "new" : overloads.Name;
			getters.Add($"case \"{indexCaseName}\": value = {bindFuncName}; break;");
			return bindFuncName;
		}

		private static void AddOpenLuaBindFunction(ScriptBuilder sb, String funcName, String luaFuncName)
		{
			sb.AppendIndent("private static readonly LuaFunction ");
			sb.Append(funcName);
			sb.Append(" = new(\"");
			sb.Append(luaFuncName);
			sb.AppendLine("\", (_context, _) =>");
			sb.OpenIndentBlock("{");
		}

		private static void AddCloseLuaBindFunction(ScriptBuilder sb)
		{
			AddThrowArgumentException(sb);
			sb.CloseIndentBlock("});");
		}

		private static void AddThrowArgumentException(ScriptBuilder sb) => sb.AppendIndentLine("throw new System.ArgumentException();");

		private static void AddReadArgumentCount(ScriptBuilder sb) => sb.AppendIndentLine("var _argCount = _context.ArgumentCount;");

		private static void AddGetInstanceFromLuaArguments(ScriptBuilder sb, GenTypeInfo typeInfo)
		{
			sb.AppendIndent("var _instance = _context.GetArgument<");
			sb.Append(typeInfo.InstanceTypeName);
			sb.AppendLine(">(0);");
		}

		private static void AddReadArgumentsAndSelectOverloadAndMakeCallRecursive(ScriptBuilder sb, GenTypeInfo typeInfo,
			GenMethodOverloads overloads, Int32 methodIndex, Int32 paramPos, List<GenParamInfo> signature)
		{
			if (signature == null)
				signature = new List<GenParamInfo>();

			// trace back to a minimally matching signature for next method
			var needsGetArguments = true;
			var overload = overloads.SortedMethods[methodIndex];
			var paramCount = overload.ParamCount;
			var isFirstClosedBlock = true;
			while (paramCount < signature.Count || overload?.HasMatchingSignature(signature) == false)
			{
				needsGetArguments = false;
				signature.RemoveAt(signature.Count - 1);
				sb.CloseIndentBlock("}");

				if (isFirstClosedBlock)
				{
					isFirstClosedBlock = false;
					AddThrowArgumentException(sb);
				}
			}
			paramPos = signature.Count;

			var luaArgOffset = overloads.LuaArgCount - overloads.MaxParamCount;
			var argNum = paramPos;
			var hasParameters = paramCount > 0;
			if (hasParameters)
			{
				var parameter = overload.ParamInfos[paramPos];
				signature.Add(parameter);
				paramPos++;

				AddGetAndReadArguments(sb, argNum, luaArgOffset, needsGetArguments, parameter);
			}

			if (paramPos == paramCount)
			{
				AddRemainingParamsAndMethodCallAndReturn(sb, typeInfo, paramPos, hasParameters, overload, luaArgOffset);
				methodIndex++;
			}

			if (hasParameters)
			{
				var beyondLastMethod = methodIndex >= overloads.SortedMethods.Count;
				if (beyondLastMethod)
					AddCloseRemainingMethodBlocks(sb, paramPos);
				else if (methodIndex < overloads.SortedMethods.Count)
					AddReadArgumentsAndSelectOverloadAndMakeCallRecursive(sb, typeInfo, overloads, methodIndex, paramPos, signature);
			}
		}

		private static void AddGetAndReadArguments(ScriptBuilder sb, Int32 argNum, Int32 luaArgOffset, Boolean needsGetArguments,
			GenParamInfo parameter)
		{
			var argPosStr = Digits[argNum];
			var luaArgPosStr = Digits[argNum + luaArgOffset];
			if (needsGetArguments)
				AddGetArgumentFromLuaContext(sb, argPosStr, luaArgPosStr);
			AddReadValueConditional(sb, parameter, argPosStr);
		}

		private static void AddReadValueConditional(ScriptBuilder sb, GenParamInfo parameter, String posStr)
		{
			var hasDefaultValue = parameter.ParamInfo.HasDefaultValue;
			sb.AppendIndent(hasDefaultValue ? "var " : "if (");
			AddReadLuaValueStatement(sb, posStr, parameter);
			sb.AppendLine(hasDefaultValue ? ";" : ")");
			sb.OpenIndentBlock("{");
		}

		private static void AddRemainingParamsAndMethodCallAndReturn(ScriptBuilder sb, GenTypeInfo typeInfo, Int32 paramPos,
			Boolean hasParameters, GenMethodInfo overload, Int32 luaArgOffset)
		{
			sb.AppendIndent("if (_argCount == ");
			sb.Append(Digits[paramPos + luaArgOffset]);
			sb.AppendLine(")");
			sb.OpenIndentBlock("{");
			if (hasParameters)
				AddRemainingParametersReadsAndAssignments(sb, overload, luaArgOffset, paramPos - 1);
			AddMethodCallAndReturn(sb, typeInfo, overload);
			sb.CloseIndentBlock("}");
		}

		private static void AddRemainingParametersReadsAndAssignments(ScriptBuilder sb, GenMethodInfo overload, Int32 luaArgOffset, Int32 pos)
		{
			// get remaining arguments
			var parameters = overload.ParamInfos;
			for (var paramIndex = pos + 1; paramIndex < parameters.Length; paramIndex++)
				AddGetArgumentFromLuaContext(sb, Digits[paramIndex], Digits[paramIndex + luaArgOffset]);

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
					AddReadLuaValueStatement(sb, Digits[paramIndex], parameters[paramIndex], true);
					sb.AppendLine(";");
				}
			}
		}

		private static void AddValueTypeParameterlessCtor(ScriptBuilder sb, GenTypeInfo typeInfo)
		{
			sb.AppendIndentLine("if (_argCount == 0)");
			sb.OpenIndentBlock("{");
			sb.AppendIndent("var _ret0 = new ");
			sb.Append(typeInfo.BindTypeFullName);
			sb.AppendLine("();");
			sb.AppendIndent("var _lret0 = new ");
			sb.Append(typeInfo.InstanceTypeName);
			sb.AppendLine("(_ret0);");
			sb.AppendIndent("var _retCount = _context.Return(_lret0);");
			sb.AppendIndentLine("return new ValueTask<System.Int32>(_retCount);");
			sb.CloseIndentBlock("}");
		}

		private static void AddMethodCallAndReturn(ScriptBuilder sb, GenTypeInfo typeInfo, GenMethodInfo overload)
		{
			var methodInfo = overload.MethodInfo as MethodInfo;
			var ctorInfo = overload.MethodInfo as ConstructorInfo;
			var isCtor = ctorInfo != null;
			var isStatic = overload.MethodInfo.IsStatic;

			var returnCount = isCtor || methodInfo.ReturnType != typeof(void) ? 1 : 0;
			var returnType = isCtor ? ctorInfo.DeclaringType : methodInfo.ReturnType;
			var methodName = isCtor ? ctorInfo.DeclaringType.FullName.Replace('+', '.') : methodInfo.Name;

			// make call and get return values
			sb.AppendIndent();
			if (returnCount == 1)
				sb.Append("var _ret0 = ");
			else if (returnCount > 1)
				throw new NotImplementedException("multiple return values");

			if (isCtor)
				sb.Append("new ");
			else if (isStatic == false)
				sb.Append("_instance.");
			sb.Append(isStatic || isCtor ? typeInfo.BindTypeFullName : typeInfo.InstanceFieldName);
			if (isCtor == false)
			{
				sb.Append(".");
				sb.Append(methodName);
			}
			sb.Append("(");

			// add call parameters
			for (var i = 0; i < overload.ParamInfos.Length; i++)
			{
				if (i > 0)
					sb.Append(", ");

				sb.Append(overload.ParamInfos[i].Name);
			}
			sb.AppendLine(");");

			// convert method return values to LuaValue
			for (var i = 0; i < returnCount; i++)
			{
				var returnTypeName = "LuaValue";
				if (s_TypeInfosByType.TryGetValue(returnType, out var returnTypeInfo))
					returnTypeName = returnTypeInfo.InstanceTypeName;

				sb.AppendIndent("var _lret");
				sb.Append(Digits[i]);
				sb.Append(" = new ");
				sb.Append(returnTypeName);
				sb.Append("(_ret");
				sb.Append(Digits[i]);
				sb.AppendLine(");");
			}

			// return values
			sb.AppendIndent("var _retCount = _context.Return(");
			for (var i = 0; i < returnCount; i++)
			{
				if (i > 0)
					sb.Append(", ");
				sb.Append("_lret");
				sb.Append(Digits[i]);
			}
			sb.AppendLine(");");
			sb.AppendIndentLine("return new ValueTask<System.Int32>(_retCount);");
		}

		private static void AddCloseRemainingMethodBlocks(ScriptBuilder sb, Int32 paramPos)
		{
			var shouldAddThrowException = true;
			for (; paramPos > 0; paramPos--)
			{
				sb.CloseIndentBlock("}");
				if (shouldAddThrowException)
				{
					shouldAddThrowException = false;
					AddThrowArgumentException(sb);
				}
			}
		}

		private static void AddGetArgumentFromLuaContext(ScriptBuilder sb, String argPosStr, String luaArgPosStr)
		{
			sb.AppendIndent("var _arg");
			sb.Append(argPosStr);
			sb.Append(" = _argCount > ");
			sb.Append(luaArgPosStr);
			sb.Append(" ? _context.GetArgument(");
			sb.Append(luaArgPosStr);
			sb.AppendLine(") : LuaValue.Nil;");
		}

		private static void AddReadLuaValueStatement(ScriptBuilder sb, String argPosStr, GenParamInfo parameter,
			Boolean useSignatureName = false)
		{
			// FIXME: optimize to read specific value types when possible
			if (parameter.ParamInfo.HasDefaultValue)
			{
				sb.Append(useSignatureName ? parameter.Name : parameter.VariableName);
				sb.Append(" = ");
				sb.Append("_arg");
				sb.Append(argPosStr);
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
				sb.Append(argPosStr);
				sb.Append(".TryRead<");
				sb.Append(parameter.TypeFullName);
				sb.Append(">(out var ");
				sb.Append(useSignatureName ? parameter.Name : parameter.VariableName);
				sb.Append(")");
			}
		}

		private static void AddInstanceTypeToStringOverride(ScriptBuilder sb, String fieldName)
		{
			sb.AppendIndent("public override string ToString() => ");
			sb.Append(fieldName);
			sb.AppendLine(".ToString();");
		}

		private static void AddStaticTypeToStringOverride(ScriptBuilder sb) =>
			sb.AppendIndentLine("public override string ToString() => BindType.FullName;");

		private static void AddOpenTypeDeclaration(ScriptBuilder sb, String typeName, Boolean isSealed)
		{
			sb.AppendIndent("public ");
			sb.Append(isSealed ? "sealed " : "");
			sb.Append("class ");
			sb.Append(typeName);
			sb.AppendLine(" : ILuaUserData");
			sb.OpenIndentBlock("{"); // { class
		}

		private static void AddCloseTypeDeclaration(ScriptBuilder sb) => sb.CloseIndentBlock("}"); // class }

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
			sb.OpenIndentBlock("{"); // { Metatable
			sb.AppendIndentLine("get => s_Metatable ??= LunyUserdataMetatable.Create(__index, __newindex);");
			sb.AppendIndentLine("set => throw new System.NotSupportedException(\"Metatable of bound types not assignable\");");
			sb.CloseIndentBlock("}"); // Metatable }
		}

		private static void AddIndexMetamethod(ScriptBuilder sb, String typeName, IEnumerable<String> getters)
		{
			sb.AppendIndentLine("private static readonly LuaFunction __index = new(Metamethods.Index, (context, _) =>");
			sb.OpenIndentBlock("{");
			sb.AppendIndent("var instance = context.GetArgument<");
			sb.Append(typeName);
			sb.AppendLine(">(0);");
			sb.AppendIndentLine("var key = context.GetArgument<string>(1);");
			sb.AppendIndentLine("var value = LuaValue.Nil;");
			sb.AppendIndentLine("switch (key)");
			sb.OpenIndentBlock("{");
			foreach (var getter in getters)
				sb.AppendIndentLine(getter);
			sb.AppendIndentLine("default: throw new LuaRuntimeException(context.Thread, instance, 2);");
			sb.CloseIndentBlock("}");
			sb.AppendIndentLine("return new ValueTask<int>(context.Return(value));");
			sb.CloseIndentBlock("});");
		}

		private static void AddNewIndexMetamethod(ScriptBuilder sb, String typeName, IEnumerable<String> setters)
		{
			sb.AppendIndentLine("private static readonly LuaFunction __newindex = new(Metamethods.NewIndex, (context, _) =>");
			sb.OpenIndentBlock("{");
			sb.AppendIndent("var instance = context.GetArgument<");
			sb.Append(typeName);
			sb.AppendLine(">(0);");
			sb.AppendIndentLine("var key = context.GetArgument<string>(1);");
			sb.AppendIndentLine("var value = context.GetArgument(2);");
			sb.AppendIndentLine("switch (key)");
			sb.OpenIndentBlock("{");
			if (setters != null)
			{
				foreach (var setter in setters)
					sb.AppendIndentLine(setter);
			}
			sb.AppendIndentLine("default: throw new LuaRuntimeException(context.Thread, instance, 2);");
			sb.CloseIndentBlock("}");
			sb.AppendIndentLine("return new ValueTask<int>(context.Return(0));");
			sb.CloseIndentBlock("});");
		}
	}
}
