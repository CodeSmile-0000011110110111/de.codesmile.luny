// Copyright (C) 2021-2025 Steffen Itterheim
// Refer to included LICENSE file for terms and conditions.

using Luny;
using LunyEditor.Generator.CSharp;
using System;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

namespace LunyEditor.Generator
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
		private static readonly String VarArg = "_arg";
		private static readonly String VarParam = "_p";
		private static readonly String VarRetVal = "_ret";
		private static readonly String VarLuaRetVal = "_lret";
		private static readonly String ILuaBindTypeFullName = $"global::{typeof(ILuaBindType).FullName}";

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
			sb.AppendLine("using Luny;");
			sb.AppendLine("using Lua.Unity;"); // for Lua extensions
			sb.AppendLine();
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
			sb.Append(isLuaStaticType || typeInfo.IsSealed || typeInfo.IsValueType ? "sealed class " : "class ");
			sb.Append(isLuaStaticType ? typeInfo.LuaStaticTypeName : typeInfo.LuaInstanceTypeName);
			sb.Append(" : ");
			if (baseType != null)
			{
				sb.Append(baseType.LuaInstanceTypeName);
				sb.Append(CommaAndSpace);
			}

			sb.Append("global::");
			if (isLuaStaticType)
				sb.Append(typeof(ILuaStatic).FullName);
			else if (typeInfo.IsValueType)
			{
				sb.Append("Luny.ILuaValueType<");
				sb.Append(typeInfo.BindTypeFullName);
				sb.Append(">");
			}
			else
			{
				sb.Append("Luny.ILuaObject<");
				sb.Append(typeInfo.BindTypeFullName);
				sb.Append(">");
			}

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

			// still needed for LuaObjectFactory
			sb.AppendIndent("public new static global::Lua.LuaValue ");
			sb.Append(nameof(ILuaObjectFactory.Bind));
			sb.Append("(global::System.Object instance) => ");
			sb.Append(nameof(ILuaObjectFactory.Bind));
			sb.Append("((");
			sb.Append(typeInfo.BindTypeFullName);
			sb.AppendLine(")instance);");
		}

		private static void AddBindInstancesListToLuaMethod(ScriptBuilder sb, GenTypeInfo typeInfo)
		{
			for (var i = 0; i < 2; i++)
			{
				sb.AppendIndent("public new static global::Lua.LuaValue ");
				sb.Append(nameof(ILuaObjectFactory.Bind));
				sb.Append("(global::System.Collections.Generic.IList<");
				sb.Append(i == 0 ? typeInfo.BindTypeFullName : "global::System.Object");
				sb.AppendLine("> instances) =>");
				sb.IncrementIndent();
				sb.AppendIndent("new global::Luny.LuaList<");
				sb.Append(typeInfo.BindTypeFullName);
				sb.AppendLine(">(instances);");
				sb.DecrementIndent();
			}
		}

		private static void AddBindTypeProperty(ScriptBuilder sb, GenTypeInfo typeInfo, Boolean isLuaStaticType)
		{
			sb.AppendIndent(isLuaStaticType || typeInfo.IsValueType ? "public " : "public new ");
			sb.Append("global::System.Type ");
			sb.Append(nameof(ILuaBindType.BindType));
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
			if (typeInfo.IsValueType)
			{
				sb.Append(" { get => ");
				sb.Append(fieldName);
				sb.Append("; set => ");
				sb.Append(fieldName);
				sb.AppendLine(" = value; }");
			}
			else
			{
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

			if (typeInfo.IsValueType)
			{
				// add ValueRef property
				sb.AppendIndent("public ref ");
				sb.Append(bindTypeName);
				sb.Append(" ValueRef => ref ");
				sb.Append(fieldName);
				sb.AppendLine(";");
			}
		}

		private static void AddToStringOverride(ScriptBuilder sb, GenTypeInfo typeInfo, Boolean isLuaStaticType)
		{
			sb.AppendIndent("public override global::System.String ToString() => ");
			if (isLuaStaticType)
			{
				sb.Append(nameof(ILuaBindType.BindType));
				sb.AppendLine(".FullName;");
			}
			else
			{
				if (typeInfo.IsValueType)
				{
					sb.Append(typeInfo.InstanceFieldName);
					sb.AppendLine(".ToString();");
				}
				else
				{
					sb.Append(typeInfo.InstanceFieldName);
					sb.Append(" != null ? ");
					sb.Append(typeInfo.InstancePropertyName);
					sb.AppendLine(".ToString() : \"{GetType().Name}(null)\";");
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
