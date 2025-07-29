// Copyright (C) 2021-2025 Steffen Itterheim
// Refer to included LICENSE file for terms and conditions.

using CodeSmile.Luny;
using Lua;
using System;
using System.Collections.Generic;
using System.Reflection;
using UnityEditor;
using UnityEngine;

namespace CodeSmileEditor.Luny.Generator
{
	internal static class ModuleTypeGenerator
	{
		// 0109 new keyword not required
		// 0162 unreachable code
		// 0168 declared but never used
		// 0219 assigned but never used
		private static readonly Type SystemType = typeof(Type);
		private const String DisabledWarningCodes = "0109, 0162, 0168, 0219";
		private static readonly String[] Digits =
			{ "0", "1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12", "13", "14", "15", "16", "17", "18", "19" };

		public static void Generate(LunyLuaModule module, String contentFolderPath, IList<GenTypeInfo> typeInfos)
		{
			foreach (var typeInfo in typeInfos)
			{
				// enums are handled by module loader
				if (typeInfo.Type.IsEnum)
					continue;

				//GenUtil.Log($"Generating type: {typeInfo.BindTypeFullName}");

				var sb = new ScriptBuilder(GenUtil.GeneratedFileHeader);
				AddUsingStatements(sb, typeInfo.Type.Namespace);
				AddNamespaceBlock(sb, module.BindingsNamespace);
				if (typeInfo.IsStatic == false)
					GenerateLuaType(sb, typeInfo, false);
				GenerateLuaType(sb, typeInfo, true);
				EndNamespaceBlock(sb);

				var assetPath = $"{contentFolderPath}/{typeInfo.InstanceLuaTypeName}.cs";
				GenUtil.WriteFile(assetPath, sb.ToString());
			}
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

		private static void GenerateLuaType(ScriptBuilder sb, GenTypeInfo typeInfo, Boolean isLuaStaticType)
		{
			var luaTypeName = isLuaStaticType ? typeInfo.StaticLuaTypeName : typeInfo.InstanceLuaTypeName;
			var members = isLuaStaticType ? typeInfo.StaticMembers : typeInfo.InstanceMembers;
			GenTypeInfo baseType = default;
			if (isLuaStaticType == false)
				ModuleGenerator.TypeInfosByType.TryGetValue(typeInfo.Type.BaseType, out baseType);

			AddOpenTypeDeclaration(sb, typeInfo, baseType, isLuaStaticType);
			AddBindType(sb, typeInfo, isLuaStaticType);
			if (isLuaStaticType == false)
			{
				AddInstanceOrValueFieldAndProperty(sb, typeInfo, baseType);
				AddConstructor(sb, typeInfo, baseType);
			}
			AddToStringOverride(sb, typeInfo, isLuaStaticType);
			AddImplicitLuaValueConversionOperator(sb, luaTypeName);
			AddILuaUserDataImplementations(sb, baseType != null);
			AddMemberBindings(sb, typeInfo, members, out var getters, out var setters);
			AddIndexMetamethod(sb, luaTypeName);
			AddNewIndexMetamethod(sb, luaTypeName, setters.Count > 0);
			AddGetValueMethod(sb, typeInfo, baseType, isLuaStaticType, getters);
			AddSetValueMethod(sb, typeInfo, baseType, isLuaStaticType, setters);
			AddCloseTypeDeclaration(sb);
		}

		private static void AddOpenTypeDeclaration(ScriptBuilder sb, GenTypeInfo typeInfo, GenTypeInfo baseType, Boolean isLuaStaticType)
		{
			var isValueType = typeInfo.Type.IsValueType;
			sb.AppendIndent("public ");
			sb.Append(isLuaStaticType ? "sealed class " : isValueType ? "struct " : "class ");
			sb.Append(isLuaStaticType ? typeInfo.StaticLuaTypeName : typeInfo.InstanceLuaTypeName);
			sb.Append(" : ");
			if (baseType != null)
			{
				sb.Append(baseType.InstanceLuaTypeName);
				sb.Append(", ");
			}

			sb.Append(nameof(ILuaUserData));
			sb.Append(", ");
			sb.Append(nameof(ILuaBindType));

			if (isLuaStaticType == false)
			{
				if (typeInfo.IsUnityObjectType)
				{
					sb.Append(", ");
					sb.Append(nameof(ILuaUnityObject));
				}
				else if (typeInfo.IsUnityGameObjectType)
				{
					sb.Append(", ");
					sb.Append(nameof(ILuaUnityGameObject));
				}
			}

			sb.AppendLine();
			sb.OpenIndentBlock("{");
		}

		private static void AddCloseTypeDeclaration(ScriptBuilder sb) => sb.CloseIndentBlock("}");

		private static void AddBindType(ScriptBuilder sb, GenTypeInfo typeInfo, Boolean isLuaStaticType)
		{
			sb.AppendIndent(isLuaStaticType || typeInfo.Type.IsValueType ? "public static " : "public static new ");
			sb.Append("System.Type BindType => typeof(");
			sb.Append(typeInfo.BindTypeFullName);
			sb.AppendLine(");");
		}

		private static void AddConstructor(ScriptBuilder sb, GenTypeInfo typeInfo, GenTypeInfo baseType)
		{
			sb.AppendIndent("public ");
			sb.Append(typeInfo.InstanceLuaTypeName);
			sb.Append("(");
			sb.Append(typeInfo.BindTypeFullName);
			sb.Append(" ");
			var paramName = typeInfo.InstancePropertyName.ToLower();
			sb.Append(paramName);
			sb.Append(")");
			if (baseType != null)
			{
				sb.Append(" : base(");
				sb.Append(paramName);
				sb.AppendLine(") {}");
			}
			else
			{
				sb.Append(" => ");
				sb.Append(typeInfo.InstanceFieldName);
				sb.Append(" = ");
				sb.Append(paramName);
				sb.AppendLine(";");
			}
		}

		private static void AddInstanceOrValueFieldAndProperty(ScriptBuilder sb, GenTypeInfo typeInfo, GenTypeInfo baseType)
		{
			var fieldName = typeInfo.InstanceFieldName;
			var bindTypeName = typeInfo.BindTypeFullName;

			// field
			if (baseType == null)
			{
				sb.AppendIndent(typeInfo.Type.IsValueType ? "private " : "protected ");
				sb.Append(bindTypeName);
				sb.Append(" ");
				sb.Append(fieldName);
				sb.AppendLine(";");
			}

			// property
			sb.AppendIndent("public ");
			if (baseType != null)
				sb.Append("new ");
			sb.Append(bindTypeName);
			sb.Append(" ");
			sb.Append(typeInfo.InstancePropertyName);
			sb.Append(" => ");
			if (baseType != null)
			{
				// cast
				sb.Append("(");
				sb.Append(bindTypeName);
				sb.Append(")");
			}
			sb.Append(fieldName);
			sb.AppendLine(";");
		}

		private static void AddToStringOverride(ScriptBuilder sb, GenTypeInfo typeInfo, Boolean isLuaStaticType)
		{
			sb.AppendIndent("public override System.String ToString() => ");
			if (isLuaStaticType)
				sb.AppendLine("BindType.FullName;");
			else
			{
				if (typeInfo.Type.IsValueType)
				{
					sb.Append(typeInfo.InstancePropertyName);
					sb.AppendLine(".ToString();");
				}
				else
				{
					sb.Append(typeInfo.InstanceFieldName);
					sb.Append(" != null ? ");
					sb.Append(typeInfo.InstancePropertyName);
					sb.AppendLine(".ToString() : \"(null)\";");
				}
			}
		}

		private static void AddImplicitLuaValueConversionOperator(ScriptBuilder sb, String typeName)
		{
			sb.AppendIndent("public static implicit operator LuaValue(");
			sb.Append(typeName);
			sb.AppendLine(" value) => new(value);");
		}

		private static void AddILuaUserDataImplementations(ScriptBuilder sb, Boolean hasBaseClass)
		{
			sb.AppendIndentLine("private static LuaTable s_Metatable;");
			sb.AppendIndent("public ");
			if (hasBaseClass)
				sb.Append("new ");
			sb.AppendLine("LuaTable Metatable");
			sb.OpenIndentBlock("{"); // { Metatable
			sb.AppendIndentLine("get => s_Metatable ??= LunyUserdataMetatable.Create(__index, __newindex);");
			sb.AppendIndentLine("set => throw new System.NotSupportedException(\"Metatable of bound types not assignable\");");
			sb.CloseIndentBlock("}"); // Metatable }
			sb.AppendIndentLine("System.Span<LuaValue> ILuaUserData.UserValues => default;");
		}

		private static void AddMemberBindings(ScriptBuilder sb, GenTypeInfo typeInfo, GenMemberInfo members, out IList<String> getters,
			out IList<String> setters)
		{
			getters = new List<String>();
			setters = new List<String>();
			AddMethodBindings(sb, typeInfo, members.CtorOverloads, getters);
			AddMethodBindings(sb, typeInfo, members.MethodOverloads, getters);
		}

		private static void AddMethodBindings(ScriptBuilder sb, GenTypeInfo typeInfo, IEnumerable<GenMethodOverloads> methodOverloads,
			IList<String> getters)
		{
			foreach (var overloads in methodOverloads)
			{
				if (overloads.Count == 0)
					continue;

				var bindFuncName = GenerateGetterCase(typeInfo, getters, overloads);
				AddOpenLuaBindFunction(sb, bindFuncName, overloads.IsConstructor ? ".ctor" : overloads.Name);
				AddReadArgumentCountAndErrorValues(sb);
				if (overloads.IsConstructor && typeInfo.Type.IsValueType)
					AddValueTypeParameterlessCtor(sb, typeInfo);
				if (overloads.IsInstanceMethod)
					AddGetInstanceFromLuaArguments(sb, typeInfo);
				AddReadArgumentsAndSelectOverloadAndMakeCallRecursive(sb, typeInfo, bindFuncName, overloads, 0, 0, null);
				AddCloseLuaBindFunction(sb, typeInfo, bindFuncName);
			}
		}

		private static void AddOpenLuaBindFunction(ScriptBuilder sb, String funcName, String debugName)
		{
			sb.AppendIndent("private static readonly LuaFunction ");
			sb.Append(funcName);
			sb.Append(" = new(\"");
			sb.Append(debugName);
			sb.AppendLine("\", (_context, _) =>");
			sb.OpenIndentBlock("{");
		}

		private static void AddCloseLuaBindFunction(ScriptBuilder sb, GenTypeInfo typeInfo, String bindFuncName)
		{
			sb.CloseIndentBlock("});");
		}

		private static void AddReadArgumentCountAndErrorValues(ScriptBuilder sb)
		{
			sb.AppendIndentLine("LuaValue _lastArg = default;");
			sb.AppendIndentLine("System.Int32 _lastArgPos = 0;");
			sb.AppendIndentLine("var _argCount = _context.ArgumentCount;");
		}

		private static void AddValueTypeParameterlessCtor(ScriptBuilder sb, GenTypeInfo typeInfo)
		{
			sb.AppendIndentLine("if (_argCount == 0)");
			sb.OpenIndentBlock("{");
			sb.AppendIndent("var _ret0 = new ");
			sb.Append(typeInfo.BindTypeFullName);
			sb.AppendLine("();");
			sb.AppendIndent("var _lret0 = new LuaValue(new ");
			sb.Append(typeInfo.InstanceLuaTypeName);
			sb.AppendLine("(_ret0));");
			sb.AppendIndentLine("var _retCount = _context.Return(_lret0);");
			sb.AppendIndentLine("return new ValueTask<System.Int32>(_retCount);");
			sb.CloseIndentBlock("}");
		}

		private static void AddGetInstanceFromLuaArguments(ScriptBuilder sb, GenTypeInfo typeInfo)
		{
			sb.AppendIndent("var _this = _context.GetArgument<");
			sb.Append(typeInfo.InstanceLuaTypeName);
			sb.AppendLine(">(0);");
		}

		private static void AddReadArgumentsAndSelectOverloadAndMakeCallRecursive(ScriptBuilder sb, GenTypeInfo typeInfo, String bindFuncName,
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

				AddGetAndReadArguments(sb, argNum, luaArgOffset, needsGetArguments, parameter);
			}

			if (paramPos == paramCount)
			{
				AddRemainingParamsAndMethodCallAndReturn(sb, typeInfo, paramPos, hasParameters, overload, luaArgOffset);
				methodIndex++;
			}

			var overloadCount = overloads.SortedMethods.Count;
			if (methodIndex < overloadCount)
				AddReadArgumentsAndSelectOverloadAndMakeCallRecursive(sb, typeInfo, bindFuncName, overloads, methodIndex, paramPos, signature);
			else
			{
				AddCloseRemainingMethodBlocks(sb, paramPos);
				AddThrowRuntimeArgumentException(sb, overloads, overload);
			}
		}

		private static void AddThrowRuntimeArgumentException(ScriptBuilder sb, GenMethodOverloads overloads, GenMethodInfo overload)
		{
			sb.AppendIndent("throw new LuaRuntimeException(_context.Thread, $\"");
			sb.Append($"{overloads.Name}: invalid argument {{_lastArgPos}} ({{_lastArg}})");
			if (overloads.IsInstanceMethod)
				sb.Append(", target: '{_this}'");
			sb.Append("\\nExpected signature: ");
			sb.Append(overload.ToString());
			sb.AppendLine("\", 2);");
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

		private static void AddGetArgumentFromLuaContext(ScriptBuilder sb, String argPosStr, String luaArgPosStr)
		{
			sb.AppendIndent("_lastArgPos = ");
			sb.Append(argPosStr);
			sb.AppendLine(";");

			sb.AppendIndent("var _arg");
			sb.Append(argPosStr);
			sb.Append(" = _lastArg = _argCount > ");
			sb.Append(luaArgPosStr);
			sb.Append(" ? _context.GetArgument(");
			sb.Append(luaArgPosStr);
			sb.AppendLine(") : LuaValue.Nil;");
		}

		private static void AddReadValueConditional(ScriptBuilder sb, GenParamInfo parameter, String posStr)
		{
			var hasDefaultValue = parameter.ParamInfo.HasDefaultValue;
			sb.AppendIndent(hasDefaultValue ? "var " : "if (");
			AddReadLuaValueStatement(sb, posStr, parameter);
			sb.AppendLine(hasDefaultValue ? ";" : ")");
			sb.OpenIndentBlock("{");
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
				sb.Append(parameter.TypeFullName);
				sb.Append(">(");
				if (parameter.Type.IsEnum)
				{
					sb.Append(parameter.TypeFullName);
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
						sb.Append(parameter.TypeFullName);
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
				sb.Append("_arg");
				sb.Append(argPosStr);
				sb.Append(".TryRead<");
				sb.Append(parameter.TypeFullName);
				sb.Append(">(out var ");
				sb.Append(useSignatureName ? parameter.Name : parameter.VariableName);
				sb.Append(")");
			}
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
			sb.Append(isStatic || isCtor ? typeInfo.BindTypeFullName : typeInfo.InstancePropertyName);
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
				sb.AppendIndent("var _lret");
				sb.Append(Digits[i]);
				sb.Append(" = ");
				var needsExtraClosingBrace = false;
				if (returnType.IsPrimitive || returnType.IsEnum || returnType == typeof(String))
				{
					sb.Append("new LuaValue(");
					if (returnType.IsEnum)
						sb.Append("(System.Double)");
				}
				else if (ModuleGenerator.TypeInfosByType.TryGetValue(returnType, out var returnTypeInfo))
				{
					needsExtraClosingBrace = true;
					sb.Append("new LuaValue(");
					sb.Append("new ");
					sb.Append(returnTypeInfo.InstanceLuaTypeName);
					sb.Append("(");
				}
				else
					sb.Append("LuaValue.FromObject((System.Object)");
				sb.Append("_ret");
				sb.Append(Digits[i]);
				sb.AppendLine(needsExtraClosingBrace ? "));" : ");");
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
			for (; paramPos > 0; paramPos--)
			{
				sb.CloseIndentBlock("}");
			}
		}

		private static void AddIndexMetamethod(ScriptBuilder sb, String typeName)
		{
			sb.AppendIndentLine("private static readonly LuaFunction __index = new(Metamethods.Index, (context, _) =>");
			sb.OpenIndentBlock("{");
			sb.AppendIndent("var _this = context.GetArgument<");
			sb.Append(typeName);
			sb.AppendLine(">(0);");
			sb.AppendIndentLine("var _key = context.GetArgument<System.String>(1);");
			sb.AppendIndentLine("if (_this.GetLuaValue(_key, out LuaValue _value) == false)");
			sb.IncrementIndent();
			sb.AppendIndentLine("throw new LuaRuntimeException(context.Thread, _this, 2);");
			sb.DecrementIndent();
			sb.AppendIndentLine("return new ValueTask<System.Int32>(context.Return(_value));");
			sb.CloseIndentBlock("});");
		}

		private static void AddNewIndexMetamethod(ScriptBuilder sb, String typeName, Boolean hasSetters)
		{
			sb.AppendIndentLine("private static readonly LuaFunction __newindex = new(Metamethods.NewIndex, (context, _) =>");
			sb.OpenIndentBlock("{");
			sb.AppendIndent("var _this = context.GetArgument<");
			sb.Append(typeName);
			sb.AppendLine(">(0);");
			if (hasSetters)
			{
				sb.AppendIndentLine("var _key = context.GetArgument<System.String>(1);");
				sb.AppendIndentLine("var _value = context.GetArgument(2);");
				sb.AppendIndentLine("if (_this.SetLuaValue(_key, _value) == false)");
				sb.IncrementIndent();
				sb.AppendIndentLine("throw new LuaRuntimeException(context.Thread, _this, 2);");
				sb.DecrementIndent();
				sb.AppendIndentLine("return new ValueTask<System.Int32>(context.Return(0));");
			}
			else
				sb.AppendIndentLine("throw new LuaRuntimeException(context.Thread, _this, 2);");
			sb.CloseIndentBlock("});");
		}

		private static void AddGetValueMethod(ScriptBuilder sb, GenTypeInfo typeInfo, GenTypeInfo baseType, Boolean isLuaStaticType,
			IList<String> getters)
		{
			sb.AppendIndent(typeInfo.IsStatic || typeInfo.Type.IsValueType ? "private " : "public ");
			if (isLuaStaticType == false && typeInfo.Type.IsValueType == false)
				sb.Append(baseType != null ? "override " : "virtual ");
			sb.AppendLine("System.Boolean GetLuaValue(System.String key, out LuaValue value)");
			sb.OpenIndentBlock("{");
			sb.AppendIndentLine("switch (key)");
			sb.OpenIndentBlock("{");
			foreach (var getter in getters)
				sb.AppendIndentLine(getter);
			if (isLuaStaticType == false && baseType != null)
				sb.AppendIndentLine("default: return base.GetLuaValue(key, out value);");
			else
				sb.AppendIndentLine("default: value = LuaValue.Nil; return false;");
			sb.CloseIndentBlock("}");
			sb.CloseIndentBlock("}");
		}

		private static void AddSetValueMethod(ScriptBuilder sb, GenTypeInfo typeInfo, GenTypeInfo baseType, Boolean isLuaStaticType,
			IList<String> setters)
		{
			sb.AppendIndent(typeInfo.IsStatic || typeInfo.Type.IsValueType ? "private " : "public ");
			if (isLuaStaticType == false && typeInfo.Type.IsValueType == false)
				sb.Append(baseType != null ? "override " : "virtual ");
			sb.Append("System.Boolean SetLuaValue(System.String key, LuaValue value)");
			if (setters.Count > 0)
			{
				sb.AppendLine();
				sb.OpenIndentBlock("{");
				sb.AppendIndentLine("switch (key)");
				sb.OpenIndentBlock("{");
				foreach (var setter in setters)
					sb.AppendIndentLine(setter);
				if (isLuaStaticType == false && baseType != null && typeInfo.Type.IsValueType == false)
					sb.AppendIndentLine("default: return base.SetLuaValue(key, value);");
				else
					sb.AppendIndentLine("default: return false;");
				sb.CloseIndentBlock("}");
				sb.CloseIndentBlock("}");
			}
			else
				sb.AppendLine(" => false;");
		}

		private static String GenerateGetterCase(GenTypeInfo typeInfo, IList<String> getters, GenMethodOverloads overloads)
		{
			var isCtor = overloads.IsConstructor;
			var bindFuncNameSuffix = isCtor ? "ctor" : overloads.Name;
			var bindFuncName = $"_{typeInfo.InstanceLuaTypeName}_{bindFuncNameSuffix}";
			var indexCaseName = isCtor ? "new" : overloads.Name;
			getters.Add($"case \"{indexCaseName}\": value = {bindFuncName}; return true;");
			return bindFuncName;
		}

		private static String GenerateSetterCase(GenTypeInfo typeInfo, IList<String> setters, GenMethodOverloads overloads)
		{
			throw new NotImplementedException();

			var isCtor = overloads.IsConstructor;
			var bindFuncNameSuffix = isCtor ? "ctor" : overloads.Name;
			var bindFuncName = $"_{typeInfo.InstanceLuaTypeName}_{bindFuncNameSuffix}";
			var indexCaseName = isCtor ? "new" : overloads.Name;
			setters.Add($"case \"{indexCaseName}\": value = {bindFuncName}; return true;");
			return bindFuncName;
		}
	}
}
