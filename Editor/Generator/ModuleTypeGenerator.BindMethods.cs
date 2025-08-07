// Copyright (C) 2021-2025 Steffen Itterheim
// Refer to included LICENSE file for terms and conditions.

using Luny;
using LunyEditor.Generator.CSharp;
using System;
using System.Collections.Generic;
using System.Reflection;
using UnityEditor;
using UnityEngine;

namespace LunyEditor.Generator
{
	internal static partial class ModuleTypeGenerator
	{
		private static void AddMethodBindings(ScriptBuilder sb, GenTypeInfo typeInfo, IEnumerable<GenMethodOverloads> methodOverloads,
			IList<String> getters)
		{
			foreach (var overloads in methodOverloads)
			{
				if (overloads.Count == 0)
					continue;

				var luaFuncName = overloads.IsConstructor ? "new" : overloads.Name;
				var bindFuncFieldName = CreateLuaBindFuncFieldName(typeInfo, luaFuncName);
				CreateMethodGetterCase(getters, bindFuncFieldName, luaFuncName);

				AddMethodOpenLuaBindFunction(sb, bindFuncFieldName, overloads.IsConstructor ? ".ctor" : overloads.Name);
				AddMethodReadArgumentCountAndErrorValues(sb);
				if (overloads.IsConstructor && typeInfo.IsValueType)
					AddMethodParameterlessCtorCase(sb, typeInfo);
				if (overloads.IsInstanceMethod)
					AddMethodGetInstanceFromLuaArguments(sb, typeInfo);
				AddMethodReadArgumentsAndSelectOverloadAndMakeCallRecursive(sb, typeInfo, overloads, 0, 0, null);
				AddMethodCloseLuaBindFunction(sb);
			}
		}

		private static String CreateLuaBindFuncFieldName(GenTypeInfo typeInfo, String luaName) => $"_{typeInfo.LuaInstanceTypeName}_{luaName}";

		private static void AddMethodOpenLuaBindFunction(ScriptBuilder sb, String fieldName, String luaFuncName)
		{
			sb.AppendIndent("private static readonly global::Lua.LuaFunction ");
			sb.Append(fieldName);
			sb.Append(" = new global::Lua.LuaFunction(\"");
			sb.Append(luaFuncName);
			sb.AppendLine("\", (_context, _) =>");
			sb.OpenIndentBlock("{");
		}

		private static void AddMethodCloseLuaBindFunction(ScriptBuilder sb) => sb.CloseIndentBlock("});");

		private static void AddMethodReadArgumentCountAndErrorValues(ScriptBuilder sb)
		{
			sb.AppendIndentLine("global::Lua.LuaValue _lastArg = default;");
			sb.AppendIndentLine("global::System.Int32 _lastArgPos = default;");
			sb.AppendIndentLine("global::System.Type _expectedType = default;");
			sb.AppendIndentLine("var _argCount = _context.ArgumentCount;");
		}

		private static void AddMethodParameterlessCtorCase(ScriptBuilder sb, GenTypeInfo typeInfo)
		{
			sb.AppendIndentLine("if (_argCount == 0)");
			sb.OpenIndentBlock("{");
			sb.AppendIndent("var _ret0 = new ");
			sb.Append(typeInfo.BindTypeFullName);
			sb.AppendLine("();");
			sb.AppendIndent("var _lret0 = ");
			sb.Append(typeInfo.LuaInstanceTypeFullName);
			sb.Append(".");
			sb.Append(nameof(ILuaObjectFactory.Bind));
			sb.AppendLine("(_ret0);");
			sb.AppendIndentLine("var _retCount = _context.Return(_lret0);");
			sb.AppendIndentLine("return new global::System.Threading.Tasks.ValueTask<global::System.Int32>(_retCount);");
			sb.CloseIndentBlock("}");
		}

		private static void AddMethodGetInstanceFromLuaArguments(ScriptBuilder sb, GenTypeInfo typeInfo)
		{
			sb.AppendIndent("var _this = _context.GetArgument<");
			sb.Append(typeInfo.LuaInstanceTypeName);
			sb.AppendLine(">(0);");
		}

		private static void AddMethodReadArgumentsAndSelectOverloadAndMakeCallRecursive(ScriptBuilder sb, GenTypeInfo typeInfo,
			GenMethodOverloads overloads, Int32 methodIndex, Int32 paramPos, List<GenParamInfo> signature)
		{
			if (signature == null)
				signature = new List<GenParamInfo>();

			// trace back to a minimally matching signature for next method
			var needsGetArguments = true;
			var overload = overloads.SortedMethods[methodIndex];
			var paramCount = overload.ParamCount;
			while (paramCount < signature.Count || overload.HasMatchingSignature(signature) == false)
			{
				needsGetArguments = false;
				signature.RemoveAt(signature.Count - 1);
				sb.CloseIndentBlock("}");
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

				if (needsGetArguments)
					AddMethodGetArgumentFromLuaContext(sb, argNum, argNum + luaArgOffset);

				var paramTypeName = GetParameterTypeFullName(parameter);
				AddMethodReadValueConditional(sb, parameter, paramTypeName, argNum);
			}

			if (paramPos == paramCount)
			{
				AddMethodReadParametersAndCallAndReturn(sb, typeInfo, paramPos, hasParameters, overload, luaArgOffset);
				methodIndex++;
			}

			var overloadCount = overloads.SortedMethods.Count;
			if (methodIndex < overloadCount)
			{
				AddMethodReadArgumentsAndSelectOverloadAndMakeCallRecursive(sb, typeInfo, overloads, methodIndex, paramPos,
					signature);
			}
			else
			{
				AddMethodCloseRemainingBlocks(sb, paramPos);
				AddMethodThrowRuntimeArgumentException(sb, overloads);
			}
		}

		private static void AddMethodThrowRuntimeArgumentException(ScriptBuilder sb, GenMethodOverloads overloads)
		{
			sb.AppendIndent("throw new global::Lua.LuaRuntimeException(_context.Thread, $\"");
			sb.Append("{\""); // enclosing name in brackets intended to avoid making every message string unique
			sb.Append(overloads.Name);
			sb.AppendLine("\"}: invalid argument #{_lastArgPos}: {_lastArg} ({_lastArg.Type}), expected: {_expectedType.FullName}\", 2);");
		}

		private static void AddMethodGetArgumentFromLuaContext(ScriptBuilder sb, Int32 argNum, Int32 luaArgIndex, GenParamInfo parameter = null)
		{
			sb.AppendIndent("var ");
			sb.Append(Args[argNum]);
			sb.Append(" = _lastArg = _argCount > ");
			sb.Append(Digits[luaArgIndex]);
			sb.Append(" ? _context.GetArgument(");
			sb.Append(Digits[luaArgIndex]);
			sb.Append(")");
			if (TryGetGeneratedType(parameter, out var _))
				sb.Append(parameter.Type.IsValueType ? ".Value" : ".Instance");
			sb.AppendLine(" : global::Lua.LuaValue.Nil;");
		}

		private static void AddMethodReadValueConditional(ScriptBuilder sb, GenParamInfo parameter, String paramTypeName, Int32 argNum)
		{
			sb.AppendIndent("_lastArgPos = ");
			sb.Append(Digits[argNum]);
			sb.Append("; ");
			sb.Append("_expectedType = typeof(");
			sb.Append(paramTypeName);
			sb.AppendLine(");");

			var hasDefaultValue = parameter.ParamInfo.HasDefaultValue;
			sb.AppendIndent(hasDefaultValue ? "var " : "if (");
			AddMethodReadLuaValueStatement(sb, parameter, paramTypeName, argNum);
			sb.AppendLine(hasDefaultValue ? ";" : ")");
			sb.OpenIndentBlock("{");
		}

		private static void AddMethodReadLuaValueStatement(ScriptBuilder sb, GenParamInfo parameter, String paramTypeName, Int32 argNum,
			Boolean useSignatureName = false)
		{
			if (parameter.ParamInfo.HasDefaultValue)
			{
				sb.Append(useSignatureName ? parameter.Name : parameter.VariableName);
				sb.Append(" = ");
				sb.Append(Args[argNum]);
				sb.Append(".ReadValue<");
				sb.Append(paramTypeName);
				sb.Append(">(");
				if (parameter.Type.IsEnum)
				{
					sb.Append(paramTypeName);
					sb.Append(".");
					sb.Append(parameter.ParamInfo.DefaultValue.ToString());
				}
				else
				{
					var defaultValue = parameter.ParamInfo.RawDefaultValue;
					if (parameter.Type.IsPrimitive)
					{
						// avoid implicit conversions from using the wrong overload, or throwing conversion errors
						sb.Append("(");
						sb.Append(paramTypeName);
						sb.Append(")");
					}

					if (parameter.Type == typeof(Boolean))
						sb.Append((Boolean)defaultValue ? "true" : "false");
					else if (defaultValue == null)
						sb.Append("default");
					else
					{
						var value = Convert.ToString(defaultValue);
						if (String.IsNullOrEmpty(value) == false)
						{
							// enclose value in brackets to avoid any ambiguities
							sb.Append("(");
							sb.Append(value);
							sb.Append(")");
						}
					}
				}
				sb.Append(")");
			}
			else
			{
				sb.Append(Args[argNum]);
				sb.Append(".TryRead<");
				sb.Append(paramTypeName);
				sb.Append(">(out var ");
				sb.Append(useSignatureName ? parameter.Name : parameter.VariableName);
				sb.Append(")");
			}
		}

		private static void AddMethodReadParametersAndCallAndReturn(ScriptBuilder sb, GenTypeInfo typeInfo, Int32 paramPos,
			Boolean hasParameters, GenMethodInfo overload, Int32 luaArgOffset)
		{
			sb.AppendIndent("if (_argCount == ");
			sb.Append(Digits[paramPos + luaArgOffset]);
			sb.AppendLine(")");
			sb.OpenIndentBlock("{");
			if (hasParameters)
				AddMethodReadRemainingAndAssignParameters(sb, overload, luaArgOffset, paramPos - 1);
			AddMethodCallAndReturn(sb, typeInfo, overload);
			sb.CloseIndentBlock("}");
		}

		private static void AddMethodReadRemainingAndAssignParameters(ScriptBuilder sb, GenMethodInfo overload, Int32 luaArgOffset, Int32 pos)
		{
			// get remaining arguments
			var parameters = overload.ParamInfos;
			for (var paramIndex = pos + 1; paramIndex < parameters.Length; paramIndex++)
				AddMethodGetArgumentFromLuaContext(sb, paramIndex, paramIndex + luaArgOffset, parameters[paramIndex]);

			// re-assign variables for readability in method call
			for (var paramIndex = 0; paramIndex < parameters.Length; paramIndex++)
			{
				var parameter = parameters[paramIndex];
				if (paramIndex <= pos)
				{
					sb.AppendIndent("var ");
					sb.Append(parameter.Name);
					sb.Append(" = ");
					sb.Append(parameter.VariableName);
					if (TryGetGeneratedType(parameter, out var _))
						sb.Append(parameter.Type.IsValueType ? ".Value" : ".Instance");
					else if (parameter.Type == typeof(Type))
					{
						sb.Append(".");
						sb.Append(nameof(ILuaBindType.BindType));
					}
					sb.AppendLine(";");
				}
				else
				{
					sb.AppendIndent(parameter.ParamInfo.HasDefaultValue ? "var " : "");
					var paramTypeName = GetParameterTypeFullName(parameter);
					AddMethodReadLuaValueStatement(sb, parameter, paramTypeName, paramIndex, true);
					sb.AppendLine(";");
				}
			}
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
				sb.Append("_this.");
			sb.Append(isStatic || isCtor ? typeInfo.BindTypeFullName : GetFieldOrPropertyName(typeInfo));
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
					sb.Append(CommaAndSpace);

				sb.Append(overload.ParamInfos[i].Name);
			}
			sb.AppendLine(");");

			// convert method return values to LuaValue
			for (var i = 0; i < returnCount; i++)
			{
				sb.AppendIndent("var ");
				sb.Append(LuaRetVals[i]);
				sb.Append(" = ");
				AddConversionToLuaValue(sb, typeInfo, returnType, RetVals[i]);
				sb.AppendLine(";");
			}

			// return values
			sb.AppendIndent("var _retCount = _context.Return(");
			for (var i = 0; i < returnCount; i++)
			{
				if (i > 0)
					sb.Append(CommaAndSpace);
				sb.Append(LuaRetVals[i]);
			}
			sb.AppendLine(");");
			sb.AppendIndentLine("return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);");
		}

		private static void AddMethodCloseRemainingBlocks(ScriptBuilder sb, Int32 paramPos)
		{
			for (; paramPos > 0; paramPos--)
				sb.CloseIndentBlock("}");
		}

		private static Boolean TryGetGeneratedType(GenParamInfo parameter, out GenTypeInfo generatedTypeInfo)
		{
			generatedTypeInfo = null;
			return parameter != null && parameter.Type.IsEnum == false &&
			       ModuleGenerator.TypeInfosByType.TryGetValue(parameter.Type, out generatedTypeInfo);
		}

		private static String GetParameterTypeFullName(GenParamInfo parameter)
		{
			if (TryGetGeneratedType(parameter, out var generatedTypeInfo))
			{
				parameter.IsGeneratedType = true;
				parameter.GeneratedTypeFullName = generatedTypeInfo.LuaInstanceTypeFullName;
			}

			var paramTypeName = parameter.IsGeneratedType ? parameter.GeneratedTypeFullName :
				parameter.Type == typeof(Type) ? ILuaBindTypeFullName : parameter.TypeFullName;
			return paramTypeName;
		}
	}
}
