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
		private const String DisabledWarningCodes = "0109, 0162, 0168, 0219";
		// 0109 new keyword not required
		// 0162 unreachable code
		// 0168 declared but never used
		// 0219 assigned but never used
		private static readonly Type SystemType = typeof(Type);
		private static readonly String[] Digits =
			{ "0", "1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12", "13", "14", "15", "16", "17", "18", "19" };

		public static void Generate(LunyLuaModule module, String contentFolderPath, IEnumerable<GenTypeInfo> typeInfos)
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
				if (typeInfo.HasInstanceType)
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
			sb.AppendLine("using UnityEngine;");
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
			if (isLuaStaticType)
			{
				AddCreateLuaTypeMethod(sb, typeInfo);
				AddStaticTypeConstructor(sb, typeInfo);
				AddImplicitLuaValueConversionOperator(sb, luaTypeName);
			}
			else
			{
				AddCreateLuaObjectMethod(sb, typeInfo);
				AddInstanceTypeConstructors(sb, typeInfo, baseType);
				AddImplicitLuaValueConversionOperator(sb, luaTypeName);
				AddInstanceOrValueFieldAndProperty(sb, typeInfo, baseType);
			}
			AddBindType(sb, typeInfo, isLuaStaticType);
			AddILuaUserDataImplementations(sb, baseType != null);
			AddToStringOverride(sb, typeInfo, isLuaStaticType);
			AddResetStaticFields(sb);
			sb.AppendLine();
			AddMemberBindings(sb, typeInfo, members, out var getters, out var setters);
			AddIndexMetamethod(sb, luaTypeName);
			AddNewIndexMetamethod(sb, luaTypeName, setters.Count > 0);
			sb.AppendLine();
			AddGetValueMethod(sb, typeInfo, baseType, members, isLuaStaticType, getters);
			AddGetValueMethod(sb, typeInfo, baseType, members, isLuaStaticType, getters, true);
			AddSetValueMethod(sb, typeInfo, baseType, members, isLuaStaticType, setters);
			AddSetValueMethod(sb, typeInfo, baseType, members, isLuaStaticType, setters, true);
			AddCloseTypeDeclaration(sb);
		}

		private static void AddOpenTypeDeclaration(ScriptBuilder sb, GenTypeInfo typeInfo, GenTypeInfo baseType, Boolean isLuaStaticType)
		{
			var isValueType = typeInfo.Type.IsValueType;
			sb.AppendIndent("public ");
			sb.Append(isLuaStaticType || typeInfo.IsSealed ? "sealed class " : isValueType ? "struct " : "class ");
			sb.Append(isLuaStaticType ? typeInfo.StaticLuaTypeName : typeInfo.InstanceLuaTypeName);
			sb.Append(" : ");
			if (baseType != null)
			{
				sb.Append(baseType.InstanceLuaTypeName);
				sb.Append(", ");
			}

			sb.Append(isLuaStaticType ? nameof(ILuaObjectType) : nameof(ILuaObject));
			sb.Append(", ");
			sb.Append(nameof(ILuaUserData));

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

		private static void AddCreateLuaTypeMethod(ScriptBuilder sb, GenTypeInfo typeInfo)
		{
			sb.AppendIndent("public static LuaValue ");
			sb.Append(nameof(LuaTypeInfo.CreateLuaType));
			sb.Append("(");
			sb.Append(nameof(CreateLuaTypeParameters));
			sb.Append(" parameters) => new ");
			sb.Append(typeInfo.StaticLuaTypeName);
			sb.AppendLine("(parameters);");
		}

		private static void AddCreateLuaObjectMethod(ScriptBuilder sb, GenTypeInfo typeInfo)
		{
			if (typeInfo.Type.IsValueType)
				return;

			sb.AppendIndent("public new static LuaValue ");
			sb.Append(nameof(LuaTypeInfo.CreateLuaObject));
			sb.Append("(System.Object instance) => new ");
			sb.Append(typeInfo.InstanceLuaTypeName);
			sb.Append("((");
			sb.Append(typeInfo.BindTypeFullName);
			sb.AppendLine(")instance);");
		}

		private static void AddBindType(ScriptBuilder sb, GenTypeInfo typeInfo, Boolean isLuaStaticType)
		{
			sb.AppendIndent(isLuaStaticType || typeInfo.Type.IsValueType ? "public " : "public new ");
			sb.Append("System.Type ");
			sb.Append(nameof(ILuaBindType.LuaBindType));
			sb.Append(" => typeof(");
			sb.Append(typeInfo.BindTypeFullName);
			sb.AppendLine(");");
		}

		private static void AddStaticTypeConstructor(ScriptBuilder sb, GenTypeInfo typeInfo)
		{
			sb.AppendIndent("public ");
			sb.Append(typeInfo.StaticLuaTypeName);
			sb.Append("(");
			sb.Append(nameof(CreateLuaTypeParameters));
			sb.AppendLine(" parameters) {}");
		}

		private static void AddInstanceTypeConstructors(ScriptBuilder sb, GenTypeInfo typeInfo, GenTypeInfo baseType)
		{
			// Ctor with instance
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
				sb.AppendIndent(typeInfo.IsSealed || typeInfo.Type.IsValueType ? "private " : "protected ");
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
			{
				sb.Append(nameof(ILuaBindType.LuaBindType));
				sb.AppendLine(".FullName;");
			}
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

		private static void AddResetStaticFields(ScriptBuilder sb)
		{
			sb.AppendLine("#if UNITY_EDITOR");
			sb.AppendIndentLine("[RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.SubsystemRegistration)]");
			sb.AppendIndentLine("private static void ResetStaticFields() => s_Metatable = null;");
			sb.AppendLine("#endif");
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
			sb.AppendIndent("get => s_Metatable ??= ");
			sb.Append(nameof(LuaMetatable));
			sb.Append(".");
			sb.Append(nameof(LuaMetatable.Create));
			sb.AppendLine("(__index, __newindex);");
			sb.AppendIndentLine("set => throw new System.NotSupportedException(\"LuaObject metatables cannot be modified\");");
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

				var luaFuncName = overloads.IsConstructor ? "new" : overloads.Name;
				var bindFuncName = CreateLuaBindFuncName(typeInfo, luaFuncName);
				CreateMethodGetterCase(getters, luaFuncName, bindFuncName);

				AddMethodOpenLuaBindFunction(sb, bindFuncName, overloads.IsConstructor ? ".ctor" : overloads.Name);
				AddMethodReadArgumentCountAndErrorValues(sb);
				if (overloads.IsConstructor && typeInfo.Type.IsValueType)
					AddMethodParameterlessCtorCase(sb, typeInfo);
				if (overloads.IsInstanceMethod)
					AddMethodGetInstanceFromLuaArguments(sb, typeInfo);
				AddMethodReadArgumentsAndSelectOverloadAndMakeCallRecursive(sb, typeInfo, overloads, 0, 0, null);
				AddMethodCloseLuaBindFunction(sb);
			}
		}

		private static String CreateLuaBindFuncName(GenTypeInfo typeInfo, String luaName) => $"_{typeInfo.InstanceLuaTypeName}_{luaName}";

		private static void AddMethodOpenLuaBindFunction(ScriptBuilder sb, String funcName, String debugName)
		{
			sb.AppendIndent("private static readonly LuaFunction ");
			sb.Append(funcName);
			sb.Append(" = new(\"");
			sb.Append(debugName);
			sb.AppendLine("\", (_context, _) =>");
			sb.OpenIndentBlock("{");
		}

		private static void AddMethodCloseLuaBindFunction(ScriptBuilder sb) => sb.CloseIndentBlock("});");

		private static void AddMethodReadArgumentCountAndErrorValues(ScriptBuilder sb)
		{
			sb.AppendIndentLine("LuaValue _lastArg = default;");
			sb.AppendIndentLine("System.Int32 _lastArgPos = default;");
			sb.AppendIndentLine("System.Type _expectedType = default;");
			sb.AppendIndentLine("var _argCount = _context.ArgumentCount;");
		}

		private static void AddMethodParameterlessCtorCase(ScriptBuilder sb, GenTypeInfo typeInfo)
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

		private static void AddMethodGetInstanceFromLuaArguments(ScriptBuilder sb, GenTypeInfo typeInfo)
		{
			sb.AppendIndent("var _this = _context.GetArgument<");
			sb.Append(typeInfo.InstanceLuaTypeName);
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
					AddMethodGetArgumentFromLuaContext(sb, Digits[argNum], Digits[argNum + luaArgOffset]);
				AddMethodReadValueConditional(sb, parameter, Digits[argNum]);
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
			sb.AppendIndent("throw new LuaRuntimeException(_context.Thread, $\"");
			sb.Append("{\""); // enclosing name in brackets intended to avoid making every message string unique
			sb.Append(overloads.Name);
			sb.AppendLine("\"}: invalid argument #{_lastArgPos}: {_lastArg} ({_lastArg.Type}), expected: {_expectedType.FullName}\", 2);");
		}

		private static void AddMethodGetArgumentFromLuaContext(ScriptBuilder sb, String argPosStr, String luaArgPosStr)
		{
			sb.AppendIndent("var _arg");
			sb.Append(argPosStr);
			sb.Append(" = _lastArg = _argCount > ");
			sb.Append(luaArgPosStr);
			sb.Append(" ? _context.GetArgument(");
			sb.Append(luaArgPosStr);
			sb.AppendLine(") : LuaValue.Nil;");
		}

		private static void AddMethodReadValueConditional(ScriptBuilder sb, GenParamInfo parameter, String argPosStr)
		{
			sb.AppendIndent("_lastArgPos = ");
			sb.Append(argPosStr);
			sb.Append("; ");
			sb.Append("_expectedType = typeof(");
			sb.Append(parameter.Type == typeof(Type) ? typeof(ILuaBindType).FullName : parameter.TypeFullName);
			sb.AppendLine(");");

			var hasDefaultValue = parameter.ParamInfo.HasDefaultValue;
			sb.AppendIndent(hasDefaultValue ? "var " : "if (");
			AddMethodReadLuaValueStatement(sb, parameter, argPosStr);
			sb.AppendLine(hasDefaultValue ? ";" : ")");
			sb.OpenIndentBlock("{");
		}

		private static void AddMethodReadLuaValueStatement(ScriptBuilder sb, GenParamInfo parameter, String argPosStr,
			Boolean useSignatureName = false)
		{
			var paramTypeName = parameter.Type == typeof(Type) ? typeof(ILuaBindType).FullName : parameter.TypeFullName;
			if (parameter.ParamInfo.HasDefaultValue)
			{
				sb.Append(useSignatureName ? parameter.Name : parameter.VariableName);
				sb.Append(" = ");
				sb.Append("_arg");
				sb.Append(argPosStr);
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
				sb.Append("_arg");
				sb.Append(argPosStr);
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
				AddMethodGetArgumentFromLuaContext(sb, Digits[paramIndex], Digits[paramIndex + luaArgOffset]);

			// re-assign variables for readability in method call
			for (var paramIndex = 0; paramIndex < parameters.Length; paramIndex++)
			{
				if (paramIndex <= pos)
				{
					sb.AppendIndent("var ");
					sb.Append(parameters[paramIndex].Name);
					sb.Append(" = ");
					sb.Append(parameters[paramIndex].VariableName);
					if (parameters[paramIndex].Type == typeof(Type))
					{
						sb.Append(".");
						sb.Append(nameof(ILuaBindType.LuaBindType));
					}
					sb.AppendLine(";");
				}
				else
				{
					sb.AppendIndent(parameters[paramIndex].ParamInfo.HasDefaultValue ? "var " : "");
					AddMethodReadLuaValueStatement(sb, parameters[paramIndex], Digits[paramIndex], true);
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
				AddConversionToLuaValue(sb, typeInfo, returnType, $"_ret{Digits[i]}");
				sb.AppendLine(";");
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

		private static void AddConversionToLuaValue(ScriptBuilder sb, GenTypeInfo typeInfo, Type bindType, String varName)
		{
			if (bindType.IsPrimitive || bindType.IsEnum || bindType == typeof(String))
			{
				sb.Append("new LuaValue(");
				if (bindType.IsEnum)
					sb.Append("(System.Double)");
			}
			else if (ModuleGenerator.TypeInfosByType.TryGetValue(bindType, out var generatedType))
			{
				if (bindType.IsValueType)
				{
					sb.Append("new ");
					sb.Append(generatedType.InstanceLuaTypeName);
					sb.Append("(");
				}
				else
				{
					sb.Append("_context.");
					sb.Append(nameof(LuaFunctionExecutionContextExt.GetObjectFactory));
					sb.Append("().");
					sb.Append(nameof(ILuaObjectFactory.CreateLuaObjectInstance));
					sb.Append("(");
				}
			}
			else
			{
				Debug.LogWarning($"Using LuaValue.FromObject({typeInfo.BindTypeFullName}) in {typeInfo.InstanceLuaTypeName}");
				sb.Append("LuaValue.FromObject((System.Object)");
			}

			sb.Append(varName);
			sb.Append(")");
		}

		private static void AddMethodCloseRemainingBlocks(ScriptBuilder sb, Int32 paramPos)
		{
			for (; paramPos > 0; paramPos--)
				sb.CloseIndentBlock("}");
		}
		private static void CreateMethodGetterCase(IList<String> getters, String luaName, String bindFuncName) =>
			getters.Add($"case \"{luaName}\": _value = {bindFuncName}; return true;");

		private static void AddIndexMetamethod(ScriptBuilder sb, String typeName)
		{
			sb.AppendIndentLine("private static readonly LuaFunction __index = new(Metamethods.Index, (_context, _) =>");
			sb.OpenIndentBlock("{");
			sb.AppendIndent("var _this = _context.GetArgument<");
			sb.Append(typeName);
			sb.AppendLine(">(0);");
			sb.AppendIndentLine("var _key = _context.GetArgument(1);");
			sb.AppendIndentLine("LuaValue _value = LuaValue.Nil;");
			sb.AppendIndentLine("if (_key.TryRead<System.String>(out var _name) && !_this.GetLuaValue(_context, _name, out _value))");
			sb.IncrementIndent();
			sb.AppendIndentLine("throw new LuaRuntimeException(_context.Thread, _this, 2);");
			sb.DecrementIndent();
			sb.AppendIndentLine("else if (_key.TryRead<System.Int32>(out var _index) && !_this.GetLuaValue(_context, _index, out _value))");
			sb.IncrementIndent();
			sb.AppendIndentLine("throw new LuaRuntimeException(_context.Thread, _this, 2);");
			sb.DecrementIndent();
			sb.AppendIndentLine("return new ValueTask<System.Int32>(_context.Return(_value));");
			sb.CloseIndentBlock("});");
		}

		private static void AddNewIndexMetamethod(ScriptBuilder sb, String typeName, Boolean hasSetters)
		{
			sb.AppendIndentLine("private static readonly LuaFunction __newindex = new(Metamethods.NewIndex, (_context, _) =>");
			sb.OpenIndentBlock("{");
			sb.AppendIndent("var _this = _context.GetArgument<");
			sb.Append(typeName);
			sb.AppendLine(">(0);");
			if (hasSetters)
			{
				sb.AppendIndentLine("var _key = _context.GetArgument(1);");
				sb.AppendIndentLine("var _value = _context.GetArgument(2);");
				sb.AppendIndentLine("if (!_this.SetLuaValue(_context, _key, _value))");
				sb.IncrementIndent();
				sb.AppendIndentLine("throw new LuaRuntimeException(_context.Thread, _this, 2);");
				sb.DecrementIndent();
				sb.AppendIndentLine("return new ValueTask<System.Int32>(_context.Return(0));");
			}
			else
				sb.AppendIndentLine("throw new LuaRuntimeException(_context.Thread, _this, 2);");
			sb.CloseIndentBlock("});");
		}

		private static void AddGetValueMethod(ScriptBuilder sb, GenTypeInfo typeInfo, GenTypeInfo baseType, GenMemberInfo members,
			Boolean isLuaStaticType, IList<String> getters, Boolean isIndexer = false)
		{
			AddGetSetValueMethodClassifiers(sb, typeInfo, baseType, isLuaStaticType);
			sb.Append("System.Boolean GetLuaValue(");
			sb.Append(nameof(LuaFunctionExecutionContext));
			sb.Append(" _context, ");
			sb.Append(isIndexer ? "System.Int32" : "System.String");
			sb.AppendLine(" _key, out LuaValue _value)");
			sb.OpenIndentBlock("{");
			if (isIndexer)
				AddGetValueForIndexer(sb, typeInfo, baseType, members, isLuaStaticType);
			else
			{
				sb.AppendIndentLine("switch (_key)");
				sb.OpenIndentBlock("{");
				foreach (var getter in getters)
					sb.AppendIndentLine(getter);
				AddGetValueCasesForPropertiesAndFields(sb, typeInfo, members, isLuaStaticType);

				if (isLuaStaticType == false && baseType != null)
					sb.AppendIndentLine("default: return base.GetLuaValue(_context, _key, out _value);");
				else
					sb.AppendIndentLine("default: _value = LuaValue.Nil; return false;");
				sb.CloseIndentBlock("}");
			}
			sb.CloseIndentBlock("}");
		}


		private static void AddGetValueCasesForPropertiesAndFields(ScriptBuilder sb, GenTypeInfo typeInfo, GenMemberInfo members,
			Boolean isLuaStaticType)
		{
			foreach (var property in members.Properties)
			{
				if (property.CanRead && property.GetMethod.IsPublic && property.IsIndexer() == false)
				{
					AddCaseStatement(sb, property.Name);
					AddGetValueAndReturn(sb, typeInfo, property.PropertyType, property.Name, isLuaStaticType);
				}
			}

			foreach (var field in members.Fields)
			{
				AddCaseStatement(sb, field.Name);
				AddGetValueAndReturn(sb, typeInfo, field.FieldType, field.Name, isLuaStaticType);
			}
		}
		private static void AddGetValueForIndexer(ScriptBuilder sb, GenTypeInfo typeInfo, GenTypeInfo baseType, GenMemberInfo members,
			Boolean isLuaStaticType)
		{
			var hasIndexer = false;
			foreach (var property in members.Properties)
			{
				if (property.CanRead == false || property.GetMethod.IsPublic == false)
					continue;

				var indexParamCount = property.GetIndexParameters().Length;
				if (indexParamCount == 1)
				{
					hasIndexer = true;
					sb.AppendIndent();
					AddGetValueAndReturn(sb, typeInfo, property.PropertyType, property.Name, isLuaStaticType, true);
				}
			}

			if (hasIndexer == false)
			{
				if (isLuaStaticType == false && baseType != null)
					sb.AppendIndentLine("return base.GetLuaValue(_context, _key, out _value);");
				else
					sb.AppendIndentLine("_value = LuaValue.Nil; return false;");
			}
		}

		private static void AddCaseStatement(ScriptBuilder sb, String memberName)
		{
			sb.AppendIndent("case \"");
			sb.Append(memberName);
			sb.Append("\": ");
		}

		private static void AddGetValueAndReturn(ScriptBuilder sb, GenTypeInfo typeInfo, Type memberType, String memberName,
			Boolean isLuaStaticType, bool isIndexer = false)
		{
			sb.Append("_value = ");
			var accessor = isLuaStaticType ? typeInfo.BindTypeFullName : typeInfo.InstancePropertyName;
			AddConversionToLuaValue(sb, typeInfo, memberType, isIndexer?$"{accessor}[_key]":$"{accessor}.{memberName}");
			sb.AppendLine("; return true;");
		}

		private static void AddSetValueMethod(ScriptBuilder sb, GenTypeInfo typeInfo, GenTypeInfo baseType, GenMemberInfo members,
			Boolean isLuaStaticType, IList<String> setters, Boolean isIndexer = false)
		{
			AddGetSetValueMethodClassifiers(sb, typeInfo, baseType, isLuaStaticType);
			sb.Append("System.Boolean SetLuaValue(");
			sb.Append(nameof(LuaFunctionExecutionContext));
			sb.Append(" _context, ");
			sb.Append(isIndexer ? "System.Int32" : "System.String");
			sb.AppendLine(" _key, LuaValue _value)");
			sb.OpenIndentBlock("{");
			if (isIndexer)
				AddSetValueForIndexer(sb, typeInfo, baseType, members, isLuaStaticType);
			else
			{
				sb.AppendIndentLine("switch (_key)");
				sb.OpenIndentBlock("{");
				foreach (var setter in setters)
					sb.AppendIndentLine(setter);
				AddSetValueCasesForPropertiesAndFields(sb, typeInfo, members, isLuaStaticType);

				if (isLuaStaticType == false && baseType != null && typeInfo.Type.IsValueType == false)
					sb.AppendIndentLine("default: return base.SetLuaValue(_context, _key, _value);");
				else
					sb.AppendIndentLine("default: return false;");
				sb.CloseIndentBlock("}");
			}
			sb.CloseIndentBlock("}");
		}

		private static void AddGetSetValueMethodClassifiers(ScriptBuilder sb, GenTypeInfo typeInfo, GenTypeInfo baseType,
			Boolean isLuaStaticType)
		{
			sb.AppendIndent(typeInfo.IsStatic || typeInfo.Type.IsValueType ? "private " : "public ");
			if (isLuaStaticType == false && typeInfo.Type.IsValueType == false)
				sb.Append(baseType != null ? "override " : typeInfo.IsSealed == false ? "virtual " : "");
		}

		private static void AddSetValueCasesForPropertiesAndFields(ScriptBuilder sb, GenTypeInfo typeInfo, GenMemberInfo members,
			Boolean isLuaStaticType)
		{
			foreach (var property in members.Properties)
			{
				if (property.CanWrite && property.SetMethod.IsPublic && property.IsIndexer() == false)
				{
					AddCaseStatement(sb, property.Name);
					AddSetValueAndReturn(sb, typeInfo, property.PropertyType, property.Name, isLuaStaticType);
				}
			}

			foreach (var field in members.Fields)
			{
				if (field.IsLiteral || field.IsInitOnly)
					continue;

				AddCaseStatement(sb, field.Name);
				AddSetValueAndReturn(sb, typeInfo, field.FieldType, field.Name, isLuaStaticType);
			}
		}
		private static void AddSetValueForIndexer(ScriptBuilder sb, GenTypeInfo typeInfo, GenTypeInfo baseType, GenMemberInfo members,
			Boolean isLuaStaticType)
		{
			var hasIndexer = false;
			foreach (var property in members.Properties)
			{
				if (property.CanWrite == false || property.SetMethod.IsPublic == false)
					continue;

				var indexParamCount = property.GetIndexParameters().Length;
				if (indexParamCount == 1)
				{
					hasIndexer = true;
					sb.AppendIndent();
					AddSetValueAndReturn(sb, typeInfo, property.PropertyType, property.Name, isLuaStaticType, true);
				}
			}

			if (hasIndexer == false)
			{
				if (isLuaStaticType == false && baseType != null)
					sb.AppendIndentLine("return base.SetLuaValue(_context, _key, _value);");
				else
					sb.AppendIndentLine("return false;");
			}
		}

		private static void AddSetValueAndReturn(ScriptBuilder sb, GenTypeInfo typeInfo, Type memberType, String memberName,
			Boolean isLuaStaticType, bool isIndexer = false)
		{
			var accessor = isLuaStaticType ? typeInfo.BindTypeFullName : typeInfo.InstancePropertyName;
			if (typeInfo.Type.IsValueType && isLuaStaticType == false)
			{
				sb.Append("{var _temp = ");
				sb.Append(typeInfo.InstancePropertyName);
				sb.Append(";");
				accessor = "_temp";
			}

			sb.Append(accessor);
			if (isIndexer)
				sb.Append("[_key]");
			else
			{
				sb.Append(".");
				sb.Append(memberName);
			}
			sb.Append(" = _value.Read<");

			GenTypeInfo generatedType = null;
			if (memberType.IsEnum)
			{
				sb.Append(memberType.FullName.Replace('+', '.'));
			}
			else if (ModuleGenerator.TypeInfosByType.TryGetValue(memberType, out generatedType))
			{
				sb.Append(generatedType.InstanceLuaTypeName);
			}
			else
			{
				sb.Append(memberType.FullName.Replace('+', '.'));
			}
			sb.Append(">()");
			if (generatedType != null)
			{
				sb.Append(".");
				sb.Append(generatedType.InstancePropertyName);
			}
			sb.Append(";");

			if (typeInfo.Type.IsValueType && isLuaStaticType == false)
			{
				sb.Append(typeInfo.InstanceFieldName);
				sb.Append(" = _temp;}");
			}

			sb.AppendLine(" return true;");
		}

	}
}
