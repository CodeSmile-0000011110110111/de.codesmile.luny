// Copyright (C) 2021-2025 Steffen Itterheim
// Refer to included LICENSE file for terms and conditions.

using CodeSmile.Luny;
using System;
using System.Collections.Generic;
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
					Debug.LogWarning($"Ignoring generic type: {type}");
					return;
				}

				var typeInfo = new GenTypeInfo(type, onlyThisMethodName);
				// if (typeInfo.InstanceMembers.HasMembers == false && typeInfo.StaticMembers.HasMembers == false)
				// 	Debug.LogWarning($"{typeInfo.Type.FullName} has no members.");

				generatedCount++;
				boundTypes.Add(typeInfo);

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
			AddMethodBindings(sb, typeInfo, members.CtorOverloads, getters);
			AddMethodBindings(sb, typeInfo, members.MethodOverloads, getters);

			setters = null;
		}

		private static void AddMethodBindings(ScriptBuilder sb, GenTypeInfo typeInfo, IEnumerable<GenMethodOverloads> methodOverloads,
			IList<String> getters)
		{
			foreach (var overloads in methodOverloads)
			{
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

		private static void AddValueTypeParameterlessCtor(ScriptBuilder sb, GenTypeInfo typeInfo)
		{
			sb.AppendIndentLine("if (_argCount == 0)");
			sb.OpenIndentBlock("{");
			sb.AppendIndent("var _retval0 = new ");
			sb.Append(typeInfo.InstanceTypeName);
			sb.Append("(new ");
			sb.Append(typeInfo.BindTypeFullName);
			sb.AppendLine("());");
			sb.AppendIndentLine("return new ValueTask<System.Int32>(_context.Return(_retval0));");
			sb.CloseIndentBlock("}");
		}

		private static void AddGetInstanceFromLuaArguments(ScriptBuilder sb, GenTypeInfo typeInfo)
		{
			sb.AppendIndent("var _instance = _context.GetArgument<");
			sb.Append(typeInfo.InstanceTypeName);
			sb.AppendLine(">(0);");
		}

		private static void AddReadArgumentsAndSelectOverloadAndMakeCallRecursive(ScriptBuilder sb, GenTypeInfo typeInfo,
			GenMethodOverloads overloads, Int32 methodIndex, Int32 paramPos, List<GenParamInfo> signature)
		{
			if (methodIndex >= overloads.SortedMethods.Count)
				return;

			if (signature == null)
				signature = new List<GenParamInfo>();

			// trace back to a minimally matching signature for next method
			var needsGetArguments = true;
			var overload = overloads.SortedMethods[methodIndex];
			var paramCount = overload.ParamCount;
			var isFirstClosedBlock = true;
			while (paramCount < signature.Count || overload.HasMatchingSignature(signature) == false)
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
			var hasParameters = overload.ParamCount > 0;
			if (hasParameters)
			{
				var parameter = overload.ParamInfos[paramPos];
				signature.Add(parameter);
				paramPos++;

				AddGetAndReadArguments(sb, argNum, luaArgOffset, needsGetArguments, parameter);
			}

			if (paramPos == overload.ParamCount)
			{
				AddRemainingParamsAndMethodCallAndReturn(sb, typeInfo, paramPos, hasParameters, overload, luaArgOffset);
				methodIndex++;
			}

			if (hasParameters)
			{
				var beyondLastMethod = methodIndex >= overloads.SortedMethods.Count;
				if (beyondLastMethod)
					AddCloseRemainingMethodBlocks(sb, paramPos);
				else
					AddReadArgumentsAndSelectOverloadAndMakeCallRecursive(sb, typeInfo, overloads, methodIndex, paramPos, signature);
			}
		}

		private static void AddGetAndReadArguments(ScriptBuilder sb, Int32 argNum, Int32 luaArgOffset, Boolean needsGetArguments,
			GenParamInfo parameter)
		{
			var argPosStr = argNum.ToString();
			var luaArgPosStr = (argNum + luaArgOffset).ToString();
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
			sb.Append((paramPos + luaArgOffset).ToString());
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
			var isStatic = overload.MethodInfo.IsStatic;

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
			else
			{
				if (isStatic == false)
					sb.Append("_instance.");
				sb.Append(isStatic ? typeInfo.BindTypeFullName : typeInfo.InstanceFieldName);
				sb.Append(".");
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

			sb.AppendIndent("return new ValueTask<System.Int32>(_context.Return(");
			for (var i = 0; i < returnCount; i++)
			{
				if (i > 0)
					sb.Append(", ");
				sb.Append("_retval");
				sb.Append(i.ToString());
			}
			sb.AppendLine("));");
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
			sb.OpenIndentBlock("{"); // { class
		}

		private static void EndTypeDeclaration(ScriptBuilder sb) => sb.CloseIndentBlock("}"); // class }

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
