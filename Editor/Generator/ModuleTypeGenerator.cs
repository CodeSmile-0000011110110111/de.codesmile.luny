// Copyright (C) 2021-2025 Steffen Itterheim
// Refer to included LICENSE file for terms and conditions.

using CodeSmile.Luny;
using CodeSmileEditor.Luny.Generator.CSharp;
using System;
using System.Collections.Generic;
using System.Reflection;
using UnityEditor;
using UnityEngine;

namespace CodeSmileEditor.Luny.Generator
{
	internal static partial class ModuleTypeGenerator
	{
		// 0109 new keyword not required
		// 0162 unreachable code
		// 0168 declared but never used
		// 0219 assigned but never used
		private const String DisabledWarningCodes = "0109, 0162, 0168, 0219";

		private const Int32 MaxArgumentCount = 24;
		private const String CommaAndSpace = ", ";
		private static readonly String[] Digits;
		private static readonly String[] Args;
		private static readonly String[] Params;
		private static readonly String[] RetVals;
		private static readonly String[] LuaRetVals;
		//private static readonly String VarContext = "_context";
		//private static readonly String VarArgCount = "_argCount";
		private static readonly String VarArg = "_arg";
		private static readonly String VarParam = "_p";
		private static readonly String VarRetVal = "_ret";
		private static readonly String VarLuaRetVal = "_lret";
		//private static readonly String VarTempValueType = "_temp";
		//private static readonly String VarCreateMethodParamName = "parameters";
		//private static readonly String VarMethodInstanceParameter = "instance";
		// private static readonly String ErrVarLastArg = "_lastArg";
		// private static readonly String ErrVarLastArgPos = "_lastArgPos";
		// private static readonly String ErrVarExpectedType = "_expectedType";

		public static void Generate(LunyLuaModule module, String contentFolderPath, IEnumerable<GenTypeInfo> typeInfos)
		{
			foreach (var typeInfo in typeInfos)
			{
				// enums are handled by module loader
				if (typeInfo.Type.IsEnum)
					continue;

				//GenUtil.Log($"Generating type: {typeInfo.BindTypeFullName}");

				var sb = new ScriptBuilder(GenUtil.GeneratedFileHeader);
				AddUsingStatements(sb);
				AddNamespaceBlock(sb, typeInfo);
				if (typeInfo.HasInstanceType)
					GenerateLuaType(sb, typeInfo, false);
				GenerateLuaType(sb, typeInfo, true);
				EndNamespaceBlock(sb);

				var assetPath = $"{contentFolderPath}/{typeInfo.LuaInstanceTypeNamespace}.{typeInfo.LuaInstanceTypeName}.cs";
				GenUtil.WriteFile(assetPath, sb.ToString());
			}
		}

		private static void AddUsingStatements(ScriptBuilder sb)
		{
			sb.Append("#pragma warning disable ");
			sb.AppendLine(DisabledWarningCodes);
			sb.AppendLine("using CodeSmile.Luny;");
			sb.AppendLine("using Lua.Unity;"); // for Lua extensions
		}

		private static void AddNamespaceBlock(ScriptBuilder sb, GenTypeInfo typeInfo)
		{
			sb.Append("namespace ");
			sb.AppendLine(typeInfo.LuaInstanceTypeNamespace);
			sb.OpenIndentBlock("{");
		}

		private static void EndNamespaceBlock(ScriptBuilder sb)
		{
			sb.CloseIndentBlock("}");
			sb.Append("#pragma warning restore ");
			sb.AppendLine(DisabledWarningCodes);
		}

		private static void GenerateLuaType(ScriptBuilder sb, GenTypeInfo typeInfo, Boolean isLuaStaticType)
		{
			var luaTypeName = isLuaStaticType ? typeInfo.LuaStaticTypeName : typeInfo.LuaInstanceTypeName;
			var members = isLuaStaticType ? typeInfo.StaticMembers : typeInfo.InstanceMembers;
			GenTypeInfo baseType = default;
			if (isLuaStaticType == false)
				ModuleGenerator.TypeInfosByType.TryGetValue(typeInfo.Type.BaseType, out baseType);

			AddOpenTypeDeclaration(sb, typeInfo, baseType, isLuaStaticType);
			if (isLuaStaticType)
			{
				AddBindTypeToLuaMethod(sb, typeInfo);
				AddStaticTypeConstructor(sb, typeInfo);
				AddImplicitLuaValueConversionOperator(sb, luaTypeName);
			}
			else
			{
				AddBindInstanceToLuaMethod(sb, typeInfo);
				AddBindInstancesListToLuaMethod(sb, typeInfo);
				AddInstanceTypeConstructors(sb, typeInfo, baseType);
				AddImplicitLuaValueConversionOperator(sb, luaTypeName);
				AddInstanceOrValueFieldAndProperty(sb, typeInfo, baseType);
			}
			AddBindTypeProperty(sb, typeInfo, isLuaStaticType);
			AddILuaUserDataImplementations(sb, baseType != null);
			AddToStringOverride(sb, typeInfo, isLuaStaticType);
			AddResetStaticFields(sb);
			sb.AppendLine();
			AddMemberBindings(sb, typeInfo, members, out var getters);
			AddIndexMetamethod(sb, luaTypeName);
			AddNewIndexMetamethod(sb, luaTypeName);
			sb.AppendLine();
			AddGetValueMethod(sb, typeInfo, baseType, members, isLuaStaticType, getters, true);
			AddGetValueMethod(sb, typeInfo, baseType, members, isLuaStaticType, getters);
			AddSetValueMethod(sb, typeInfo, baseType, members, isLuaStaticType, true);
			AddSetValueMethod(sb, typeInfo, baseType, members, isLuaStaticType);
			AddCloseTypeDeclaration(sb);
		}

		private static void AddOpenTypeDeclaration(ScriptBuilder sb, GenTypeInfo typeInfo, GenTypeInfo baseType, Boolean isLuaStaticType)
		{
			sb.AppendIndent("public ");
			sb.Append(isLuaStaticType || typeInfo.IsSealed ? "sealed class " : "class ");
			sb.Append(isLuaStaticType ? typeInfo.LuaStaticTypeName : typeInfo.LuaInstanceTypeName);
			sb.Append(" : ");
			if (baseType != null)
			{
				sb.Append(baseType.LuaInstanceTypeName);
				sb.Append(CommaAndSpace);
			}

			sb.Append("global::");
			sb.Append(isLuaStaticType ? typeof(ILuaObjectType).FullName : typeof(ILuaObject).FullName);

			if (isLuaStaticType == false)
			{
				if (typeInfo.IsUnityObjectType)
				{
					sb.Append(CommaAndSpace);
					sb.Append("global::");
					sb.Append(typeof(ILuaUnityObject).FullName);
				}
				else if (typeInfo.IsUnityGameObjectType)
				{
					sb.Append(CommaAndSpace);
					sb.Append("global::");
					sb.Append(typeof(ILuaUnityGameObject).FullName);
				}
			}

			sb.AppendLine();
			sb.OpenIndentBlock("{");
		}

		private static void AddCloseTypeDeclaration(ScriptBuilder sb) => sb.CloseIndentBlock("}");

		private static void AddBindTypeToLuaMethod(ScriptBuilder sb, GenTypeInfo typeInfo)
		{
			sb.AppendIndent("public static global::Lua.LuaValue ");
			sb.Append(nameof(ILuaObjectFactory.Bind));
			sb.Append("() => new ");
			sb.Append(typeInfo.LuaStaticTypeName);
			sb.AppendLine("();");
		}

		private static void AddBindInstanceToLuaMethod(ScriptBuilder sb, GenTypeInfo typeInfo)
		{
			sb.AppendIndent("public new static global::Lua.LuaValue ");
			sb.Append(nameof(ILuaObjectFactory.Bind));
			sb.Append(typeInfo.IsValueType ? "(in " : "(");
			sb.Append(typeInfo.BindTypeFullName);
			sb.Append(" instance) => new ");
			sb.Append(typeInfo.LuaInstanceTypeName);
			sb.AppendLine("(instance);");

			sb.AppendIndent("public new static global::Lua.LuaValue ");
			sb.Append(nameof(ILuaObjectFactory.Bind));
			sb.Append("(global::System.Object instance) => new ");
			sb.Append(typeInfo.LuaInstanceTypeName);
			sb.Append("((");
			sb.Append(typeInfo.BindTypeFullName);
			sb.AppendLine(")instance);");
		}

		private static void AddBindInstancesListToLuaMethod(ScriptBuilder sb, GenTypeInfo typeInfo)
		{
			sb.AppendIndent("public new static global::Lua.LuaValue ");
			sb.Append(nameof(ILuaObjectFactory.Bind));
			sb.AppendLine("(global::System.Collections.Generic.IList<global::System.Object> instances)");
			sb.OpenIndentBlock("{");
			sb.AppendIndentLine("var count = instances.Count;");
			sb.AppendIndentLine("var table = new global::Lua.LuaTable(count, 0);");
			sb.AppendIndentLine("for (int i = 1; i <= count; i++)");
			sb.IncrementIndent();
			sb.AppendIndent("table[i] = new ");
			sb.Append(typeInfo.LuaInstanceTypeName);
			sb.Append("((");
			sb.Append(typeInfo.BindTypeFullName);
			sb.AppendLine(")instances[i - 1]);");
			sb.DecrementIndent();
			sb.AppendIndentLine("return table;");
			sb.CloseIndentBlock("}");
		}

		private static void AddBindTypeProperty(ScriptBuilder sb, GenTypeInfo typeInfo, Boolean isLuaStaticType)
		{
			sb.AppendIndent(isLuaStaticType || typeInfo.IsValueType ? "public " : "public new ");
			sb.Append("global::System.Type ");
			sb.Append(nameof(ILuaBindType.LuaBindType));
			sb.Append(" => typeof(");
			sb.Append(typeInfo.BindTypeFullName);
			sb.AppendLine(");");
		}

		private static void AddStaticTypeConstructor(ScriptBuilder sb, GenTypeInfo typeInfo)
		{
			sb.AppendIndent("private ");
			sb.Append(typeInfo.LuaStaticTypeName);
			sb.AppendLine("() {}");
		}

		private static void AddInstanceTypeConstructors(ScriptBuilder sb, GenTypeInfo typeInfo, GenTypeInfo baseType)
		{
			// Ctor with instance
			sb.AppendIndent(typeInfo.IsSealed || typeInfo.IsValueType ? "private " : "protected ");
			sb.Append(typeInfo.LuaInstanceTypeName);
			sb.Append(typeInfo.IsValueType ? "(in " : "(");
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
				sb.AppendIndent(typeInfo.IsSealed || typeInfo.IsValueType ? "private " : "protected ");
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
			sb.AppendIndent("public override global::System.String ToString() => ");
			if (isLuaStaticType)
			{
				sb.Append(nameof(ILuaBindType.LuaBindType));
				sb.AppendLine(".FullName;");
			}
			else
			{
				if (typeInfo.IsValueType)
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
			sb.AppendIndentLine(
				"[global::UnityEngine.RuntimeInitializeOnLoadMethod(global::UnityEngine.RuntimeInitializeLoadType.SubsystemRegistration)]");
			sb.AppendIndentLine("private static void ResetStaticFields() => s_Metatable = null;");
			sb.AppendLine("#endif");
		}

		private static void AddImplicitLuaValueConversionOperator(ScriptBuilder sb, String typeName)
		{
			sb.AppendIndent("public static implicit operator global::Lua.LuaValue(");
			sb.Append(typeName);
			sb.AppendLine(" value) => new(value);");
		}

		private static void AddILuaUserDataImplementations(ScriptBuilder sb, Boolean hasBaseClass)
		{
			sb.AppendIndentLine("private static global::Lua.LuaTable s_Metatable;");
			sb.AppendIndent("public ");
			if (hasBaseClass)
				sb.Append("new ");
			sb.AppendLine("global::Lua.LuaTable Metatable");
			sb.OpenIndentBlock("{");
			sb.AppendIndent("get => s_Metatable ??= global::");
			sb.Append(typeof(LuaMetatable).FullName);
			sb.Append(".");
			sb.Append(nameof(LuaMetatable.Create));
			sb.AppendLine("(__index, __newindex);");
			sb.AppendIndentLine("set => throw new global::System.NotSupportedException(\"LuaObject metatables cannot be modified\");");
			sb.CloseIndentBlock("}");
			sb.AppendIndentLine("global::System.Span<global::Lua.LuaValue> global::Lua.ILuaUserData.UserValues => default;");
		}

		private static void AddMemberBindings(ScriptBuilder sb, GenTypeInfo typeInfo, GenMemberInfo members, out IList<String> getters)
		{
			getters = new List<String>();
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
			sb.Append(" = new(\"");
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
				AddMethodReadValueConditional(sb, parameter, argNum);
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

		private static void AddMethodGetArgumentFromLuaContext(ScriptBuilder sb, Int32 argNum, Int32 luaArgIndex)
		{
			sb.AppendIndent("var ");
			sb.Append(Args[argNum]);
			sb.Append(" = _lastArg = _argCount > ");
			sb.Append(Digits[luaArgIndex]);
			sb.Append(" ? _context.GetArgument(");
			sb.Append(Digits[luaArgIndex]);
			sb.AppendLine(") : global::Lua.LuaValue.Nil;");
		}

		private static void AddMethodReadValueConditional(ScriptBuilder sb, GenParamInfo parameter, Int32 argNum)
		{
			sb.AppendIndent("_lastArgPos = ");
			sb.Append(Digits[argNum]);
			sb.Append("; ");
			sb.Append("_expectedType = typeof(global::");
			sb.Append(parameter.Type == typeof(Type) ? typeof(ILuaBindType).FullName : parameter.TypeFullName);
			sb.AppendLine(");");

			var hasDefaultValue = parameter.ParamInfo.HasDefaultValue;
			sb.AppendIndent(hasDefaultValue ? "var " : "if (");
			AddMethodReadLuaValueStatement(sb, parameter, argNum);
			sb.AppendLine(hasDefaultValue ? ";" : ")");
			sb.OpenIndentBlock("{");
		}

		private static void AddMethodReadLuaValueStatement(ScriptBuilder sb, GenParamInfo parameter, Int32 argNum,
			Boolean useSignatureName = false)
		{
			var paramTypeName = parameter.Type == typeof(Type) ? typeof(ILuaBindType).FullName : parameter.TypeFullName;
			if (parameter.ParamInfo.HasDefaultValue)
			{
				sb.Append(useSignatureName ? parameter.Name : parameter.VariableName);
				sb.Append(" = ");
				sb.Append(Args[argNum]);
				sb.Append(".ReadValue<");
				sb.Append("global::");
				sb.Append(paramTypeName);
				sb.Append(">(");
				if (parameter.Type.IsEnum)
				{
					sb.Append("global::");
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
						sb.Append("global::");
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
				sb.Append(".TryRead<global::");
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
				AddMethodGetArgumentFromLuaContext(sb, paramIndex, paramIndex + luaArgOffset);

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
					AddMethodReadLuaValueStatement(sb, parameters[paramIndex], paramIndex, true);
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

		private static void AddConversionToLuaValue(ScriptBuilder sb, GenTypeInfo typeInfo, Type bindType, String varName)
		{
			if (bindType.IsPrimitive || bindType.IsEnum || bindType == typeof(String))
				sb.Append("new global::Lua.LuaValue");
			else if (bindType.IsValueType && ModuleGenerator.TypeInfosByType.TryGetValue(bindType, out var generatedType))
			{
				sb.Append(generatedType.LuaInstanceTypeFullName);
				sb.Append(".");
				sb.Append(nameof(ILuaObjectFactory.Bind));
			}
			else
			{
				sb.Append("_context.");
				sb.Append(nameof(LuaFunctionExecutionContextExt.GetObjectFactory));
				sb.Append("().");
				sb.Append(nameof(ILuaObjectFactory.Bind));
			}

			sb.Append("(");
			if (bindType.IsEnum)
				sb.Append("(global::System.Double)");
			sb.Append(varName);
			sb.Append(")");
		}

		private static void AddMethodCloseRemainingBlocks(ScriptBuilder sb, Int32 paramPos)
		{
			for (; paramPos > 0; paramPos--)
				sb.CloseIndentBlock("}");
		}

		static ModuleTypeGenerator()
		{
			Digits = new String[MaxArgumentCount];
			Args = new String[MaxArgumentCount];
			Params = new String[MaxArgumentCount];
			RetVals = new String[MaxArgumentCount];
			LuaRetVals = new String[MaxArgumentCount];

			for (var i = 0; i < MaxArgumentCount; i++)
			{
				var iStr = i.ToString();
				Digits[i] = iStr;
				Args[i] = $"{VarArg}{iStr}";
				Params[i] = $"{VarParam}{iStr}";
				RetVals[i] = $"{VarRetVal}{iStr}";
				LuaRetVals[i] = $"{VarLuaRetVal}{iStr}";
			}
		}
	}
}
