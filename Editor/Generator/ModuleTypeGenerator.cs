// Copyright (C) 2021-2025 Steffen Itterheim
// Refer to included LICENSE file for terms and conditions.

using CodeSmile.Luny;
using CodeSmileEditor.Luny.Generator.CSharp;
using Lua;
using System;
using System.Collections.Generic;
using System.Reflection;
using UnityEditor;
using UnityEngine;
using Object = System.Object;
using Space = CodeSmileEditor.Luny.Generator.CSharp.Space;

namespace CodeSmileEditor.Luny.Generator
{
	internal static class ModuleTypeGenerator
	{
		// 0109 new keyword not required
		// 0162 unreachable code
		// 0168 declared but never used
		// 0219 assigned but never used
		private const String DisabledWarningCodes = "0109, 0162, 0168, 0219";

		private const Int32 MaxArgumentCount = 16;
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
		private static readonly String VarCreateMethodParamName = "parameters";
		private static readonly String VarMethodInstanceParameter = "instance";
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
			sb.AppendNewLine("using CodeSmile.Luny;");
			sb.AppendNewLine("using Lua;");
			sb.AppendNewLine("using Lua.Runtime;");
			sb.AppendNewLine("using Lua.Unity;");
			sb.AppendNewLine("using System.Threading.Tasks;");
			sb.AppendNewLine("using UnityEngine;");
		}

		private static void AddNamespaceBlock(ScriptBuilder sb, String @namespace)
		{
			sb.Append("#pragma warning disable ");
			sb.AppendNewLine(DisabledWarningCodes);
			sb.AppendNewLine();
			sb.Append("namespace ");
			sb.AppendNewLine(@namespace);
			sb.OpenIndentBlock("{"); // { namespace
		}

		private static void EndNamespaceBlock(ScriptBuilder sb)
		{
			sb.CloseIndentBlock("}"); // namespace }
			sb.Append("#pragma warning restore ");
			sb.AppendNewLine(DisabledWarningCodes);
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
			sb.AppendNewLine();
			AddMemberBindings(sb, typeInfo, members, out var getters, out var setters);
			AddIndexMetamethod(sb, luaTypeName);
			AddNewIndexMetamethod(sb, luaTypeName, setters.Count > 0);
			sb.AppendNewLine();
			AddGetValueMethod(sb, typeInfo, baseType, members, isLuaStaticType, getters);
			AddGetValueMethod(sb, typeInfo, baseType, members, isLuaStaticType, getters, true);
			AddSetValueMethod(sb, typeInfo, baseType, members, isLuaStaticType, setters);
			AddSetValueMethod(sb, typeInfo, baseType, members, isLuaStaticType, setters, true);
			AddCloseTypeDeclaration(sb);
		}

		private static void AddOpenTypeDeclaration(ScriptBuilder sb, GenTypeInfo typeInfo, GenTypeInfo baseType, Boolean isLuaStaticType)
		{
			var isValueType = typeInfo.IsValueType;
			sb.AppendIndent("public ");
			sb.Append(isLuaStaticType || typeInfo.IsSealed ? "sealed class " : isValueType ? "struct " : "class ");
			sb.Append(isLuaStaticType ? typeInfo.StaticLuaTypeName : typeInfo.InstanceLuaTypeName);
			sb.Append(" : ");
			if (baseType != null)
			{
				sb.Append(baseType.InstanceLuaTypeName);
				sb.Append(CommaAndSpace);
			}

			sb.Append(isLuaStaticType ? nameof(ILuaObjectType) : nameof(ILuaObject));
			sb.Append(CommaAndSpace);
			sb.Append(nameof(ILuaUserData));

			if (isLuaStaticType == false)
			{
				if (typeInfo.IsUnityObjectType)
				{
					sb.Append(CommaAndSpace);
					sb.Append(nameof(ILuaUnityObject));
				}
				else if (typeInfo.IsUnityGameObjectType)
				{
					sb.Append(CommaAndSpace);
					sb.Append(nameof(ILuaUnityGameObject));
				}
			}

			sb.AppendNewLine();
			sb.OpenIndentBlock("{");
		}

		private static void AddCloseTypeDeclaration(ScriptBuilder sb) => sb.CloseIndentBlock("}");

		private static void AddCreateLuaTypeMethod(ScriptBuilder sb, GenTypeInfo typeInfo)
		{
			sb.AppendIndent("public static LuaValue ");
			sb.Append(nameof(LuaTypeInfo.CreateLuaType));
			sb.Append("(");
			sb.Append(nameof(CreateLuaTypeParameters), Space.After);
			sb.Append(VarCreateMethodParamName);
			sb.Append(") => new ");
			sb.Append(typeInfo.StaticLuaTypeName);
			sb.Append("(");
			sb.Append(VarCreateMethodParamName);
			sb.AppendNewLine(");");
		}

		private static void AddCreateLuaObjectMethod(ScriptBuilder sb, GenTypeInfo typeInfo)
		{
			if (typeInfo.IsValueType)
				return;

			sb.AppendIndent("public new static LuaValue ");
			sb.Append(nameof(LuaTypeInfo.CreateLuaObject));
			sb.Append("(System.Object ");
			sb.Append(VarMethodInstanceParameter);
			sb.Append(") => new ");
			sb.Append(typeInfo.InstanceLuaTypeName);
			sb.Append("((");
			sb.Append(typeInfo.BindTypeFullName);
			sb.Append(")");
			sb.Append(VarMethodInstanceParameter);
			sb.AppendNewLine(");");
		}

		private static void AddBindType(ScriptBuilder sb, GenTypeInfo typeInfo, Boolean isLuaStaticType)
		{
			sb.AppendIndent(isLuaStaticType || typeInfo.IsValueType ? "public " : "public new ");
			sb.Append("System.Type ");
			sb.Append(nameof(ILuaBindType.LuaBindType));
			sb.Append(" => typeof(");
			sb.Append(typeInfo.BindTypeFullName);
			sb.AppendNewLine(");");
		}

		private static void AddStaticTypeConstructor(ScriptBuilder sb, GenTypeInfo typeInfo)
		{
			sb.AppendIndent("public ");
			sb.Append(typeInfo.StaticLuaTypeName);
			sb.Append("(");
			sb.Append(nameof(CreateLuaTypeParameters));
			sb.AppendNewLine(" parameters) {}");
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
				sb.AppendNewLine(") {}");
			}
			else
			{
				sb.Append(" => ");
				sb.Append(typeInfo.InstanceFieldName);
				sb.Append(" = ");
				sb.Append(paramName);
				sb.AppendNewLine(";");
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
				sb.AppendNewLine(";");
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
			sb.AppendNewLine(";");
		}

		private static void AddToStringOverride(ScriptBuilder sb, GenTypeInfo typeInfo, Boolean isLuaStaticType)
		{
			sb.AppendIndent("public override System.String ToString() => ");
			if (isLuaStaticType)
			{
				sb.Append(nameof(ILuaBindType.LuaBindType));
				sb.AppendNewLine(".FullName;");
			}
			else
			{
				if (typeInfo.IsValueType)
				{
					sb.Append(typeInfo.InstancePropertyName);
					sb.AppendNewLine(".ToString();");
				}
				else
				{
					sb.Append(typeInfo.InstanceFieldName);
					sb.Append(" != null ? ");
					sb.Append(typeInfo.InstancePropertyName);
					sb.AppendNewLine(".ToString() : \"(null)\";");
				}
			}
		}

		private static void AddResetStaticFields(ScriptBuilder sb)
		{
			sb.AppendNewLine("#if UNITY_EDITOR");
			sb.AppendIndentLine("[RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.SubsystemRegistration)]");
			sb.AppendIndentLine("private static void ResetStaticFields() => s_Metatable = null;");
			sb.AppendNewLine("#endif");
		}

		private static void AddImplicitLuaValueConversionOperator(ScriptBuilder sb, String typeName)
		{
			sb.AppendIndent("public static implicit operator LuaValue(");
			sb.Append(typeName);
			sb.AppendNewLine(" value) => new(value);");
		}

		private static void AddILuaUserDataImplementations(ScriptBuilder sb, Boolean hasBaseClass)
		{
			sb.AppendIndentLine("private static LuaTable s_Metatable;");
			sb.AppendIndent("public ");
			if (hasBaseClass)
				sb.Append("new ");
			sb.AppendNewLine("LuaTable Metatable");
			sb.OpenIndentBlock("{");
			sb.AppendIndent("get => s_Metatable ??= ");
			sb.Append(nameof(LuaMetatable));
			sb.Append(".");
			sb.Append(nameof(LuaMetatable.Create));
			sb.AppendNewLine("(__index, __newindex);");
			sb.AppendIndentLine("set => throw new System.NotSupportedException(\"LuaObject metatables cannot be modified\");");
			sb.CloseIndentBlock("}");
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
				if (overloads.IsConstructor && typeInfo.IsValueType)
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
			sb.AppendNewLine("\", (_context, _) =>");
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
			sb.AppendNewLine("();");
			sb.AppendIndent("var _lret0 = new LuaValue(new ");
			sb.Append(typeInfo.InstanceLuaTypeName);
			sb.AppendNewLine("(_ret0));");
			sb.AppendIndentLine("var _retCount = _context.Return(_lret0);");
			sb.AppendIndentLine("return new ValueTask<System.Int32>(_retCount);");
			sb.CloseIndentBlock("}");
		}

		private static void AddMethodGetInstanceFromLuaArguments(ScriptBuilder sb, GenTypeInfo typeInfo)
		{
			sb.AppendIndent("var _this = _context.GetArgument<");
			sb.Append(typeInfo.InstanceLuaTypeName);
			sb.AppendNewLine(">(0);");
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
			sb.AppendIndent("throw new LuaRuntimeException(_context.Thread, $\"");
			sb.Append("{\""); // enclosing name in brackets intended to avoid making every message string unique
			sb.Append(overloads.Name);
			sb.AppendNewLine("\"}: invalid argument #{_lastArgPos}: {_lastArg} ({_lastArg.Type}), expected: {_expectedType.FullName}\", 2);");
		}

		private static void AddMethodGetArgumentFromLuaContext(ScriptBuilder sb, Int32 argNum, Int32 luaArgIndex)
		{
			sb.AppendIndent("var ");
			sb.Append(Args[argNum]);
			sb.Append(" = _lastArg = _argCount > ");
			sb.Append(Digits[luaArgIndex]);
			sb.Append(" ? _context.GetArgument(");
			sb.Append(Digits[luaArgIndex]);
			sb.AppendNewLine(") : LuaValue.Nil;");
		}

		private static void AddMethodReadValueConditional(ScriptBuilder sb, GenParamInfo parameter, Int32 argNum)
		{
			sb.AppendIndent("_lastArgPos = ");
			sb.Append(Digits[argNum]);
			sb.Append("; ");
			sb.Append("_expectedType = typeof(");
			sb.Append(parameter.Type == typeof(Type) ? typeof(ILuaBindType).FullName : parameter.TypeFullName);
			sb.AppendNewLine(");");

			var hasDefaultValue = parameter.ParamInfo.HasDefaultValue;
			sb.AppendIndent(hasDefaultValue ? "var " : "if (");
			AddMethodReadLuaValueStatement(sb, parameter, argNum);
			sb.AppendNewLine(hasDefaultValue ? ";" : ")");
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
			sb.AppendNewLine(")");
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
					sb.AppendNewLine(";");
				}
				else
				{
					sb.AppendIndent(parameters[paramIndex].ParamInfo.HasDefaultValue ? "var " : "");
					AddMethodReadLuaValueStatement(sb, parameters[paramIndex], paramIndex, true);
					sb.AppendNewLine(";");
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
			sb.AppendNewLine(");");

			// convert method return values to LuaValue
			for (var i = 0; i < returnCount; i++)
			{
				sb.AppendIndent("var ");
				sb.Append(LuaRetVals[i]);
				sb.Append(" = ");
				AddConversionToLuaValue(sb, typeInfo, returnType, RetVals[i]);
				sb.AppendNewLine(";");
			}

			// return values
			sb.AppendIndent("var _retCount = _context.Return(");
			for (var i = 0; i < returnCount; i++)
			{
				if (i > 0)
					sb.Append(CommaAndSpace);
				sb.Append(LuaRetVals[i]);
			}
			sb.AppendNewLine(");");
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
				if (typeInfo.IsValueType)
				{
					Debug.LogWarning(
						$"Using 'LuaValue.FromObject' for value-type '{typeInfo.BindTypeFullName}' in '{typeInfo.InstanceLuaTypeName}' (boxing allocation)");
				}
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
			sb.AppendNewLine(">(0);");
			sb.AppendIndentLine("var _key = _context.GetArgument(1);");
			sb.AppendIndentLine("LuaValue _value = LuaValue.Nil;");
			sb.AppendIndentLine("if (_key.TryRead<System.String>(out var _name) && _this.GetLuaValue(_context, _name, out _value))");
			sb.IncrementIndent();
			sb.AppendIndentLine("return new ValueTask<System.Int32>(_context.Return(_value));");
			sb.DecrementIndent();
			sb.AppendIndentLine("if (_key.TryRead<System.Int32>(out var _index) && !_this.GetLuaValue(_context, _index, out _value))");
			sb.IncrementIndent();
			sb.AppendIndentLine("return new ValueTask<System.Int32>(_context.Return(_value));");
			sb.DecrementIndent();
			sb.AppendIndentLine("throw new LuaRuntimeException(_context.Thread, $\"attempt to index nil value '{_key}' on '{_this}'\", 2);");
			sb.CloseIndentBlock("});");
		}

		private static void AddNewIndexMetamethod(ScriptBuilder sb, String typeName, Boolean hasSetters)
		{
			sb.AppendIndentLine("private static readonly LuaFunction __newindex = new(Metamethods.NewIndex, (_context, _) =>");
			sb.OpenIndentBlock("{");
			sb.AppendIndent("var _this = _context.GetArgument<");
			sb.Append(typeName);
			sb.AppendNewLine(">(0);");
			sb.AppendIndentLine("var _key = _context.GetArgument(1);");
			if (hasSetters)
			{
				sb.AppendIndentLine("var _value = _context.GetArgument(2);");
				sb.AppendIndentLine("if (_this.SetLuaValue(_context, _key, _value))");
				sb.IncrementIndent();
				sb.AppendIndentLine("return new ValueTask<System.Int32>(_context.Return(0));");
				sb.DecrementIndent();
			}
			sb.AppendIndentLine("throw new LuaRuntimeException(_context.Thread, $\"attempt to assign to unknown '{_key}' on '{_this}'\", 2);");
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
			sb.AppendNewLine(" _key, out LuaValue _value)");
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
			Boolean isLuaStaticType, Boolean isIndexer = false)
		{
			sb.Append("_value = ");
			var accessor = isLuaStaticType ? typeInfo.BindTypeFullName : typeInfo.InstancePropertyName;
			AddConversionToLuaValue(sb, typeInfo, memberType, isIndexer ? $"{accessor}[_key]" : $"{accessor}.{memberName}");
			sb.AppendNewLine("; return true;");
		}

		private static void AddSetValueMethod(ScriptBuilder sb, GenTypeInfo typeInfo, GenTypeInfo baseType, GenMemberInfo members,
			Boolean isLuaStaticType, IList<String> setters, Boolean isIndexer = false)
		{
			AddGetSetValueMethodClassifiers(sb, typeInfo, baseType, isLuaStaticType);
			sb.Append("System.Boolean SetLuaValue(");
			sb.Append(nameof(LuaFunctionExecutionContext));
			sb.Append(" _context, ");
			sb.Append(isIndexer ? "System.Int32" : "System.String");
			sb.AppendNewLine(" _key, LuaValue _value)");
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

				if (isLuaStaticType == false && baseType != null && typeInfo.IsValueType == false)
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
			sb.AppendIndent(typeInfo.IsStatic || typeInfo.IsValueType ? "private " : "public ");
			if (isLuaStaticType == false && typeInfo.IsValueType == false)
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
			Boolean isLuaStaticType, Boolean isIndexer = false)
		{
			var accessor = isLuaStaticType ? typeInfo.BindTypeFullName : typeInfo.InstancePropertyName;
			if (typeInfo.IsValueType && isLuaStaticType == false)
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
				sb.Append(memberType.FullName.Replace('+', '.'));
			else if (ModuleGenerator.TypeInfosByType.TryGetValue(memberType, out generatedType))
				sb.Append(generatedType.InstanceLuaTypeName);
			else
				sb.Append(memberType.FullName.Replace('+', '.'));
			sb.Append(">()");
			if (generatedType != null)
			{
				sb.Append(".");
				sb.Append(generatedType.InstancePropertyName);
			}
			sb.Append(";");

			if (typeInfo.IsValueType && isLuaStaticType == false)
			{
				sb.Append(typeInfo.InstanceFieldName);
				sb.Append(" = _temp;}");
			}

			sb.AppendNewLine(" return true;");
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
