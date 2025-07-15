// Copyright (C) 2021-2025 Steffen Itterheim
// Refer to included LICENSE file for terms and conditions.

using CodeSmile.Luny;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using UnityEditor;
using UnityEngine;

namespace CodeSmileEditor.Luny.Generator
{
	internal static class TypeGenerator
	{
		public static IEnumerable<TypeInfo> Generate(LunyLuaModule module, String contentFolderPath, TypeHierarchy typeHierarchy)
		{
			var boundTypes = new List<TypeInfo>();

			var generatableCount = 0;
			var generatedCount = 0;
			typeHierarchy.Visit((node, level) =>
			{
				var type = node.Value;
				if (type.IsEnum)
				{
					// enums are handled by module loader
					boundTypes.Add(new TypeInfo(type));
					return;
				}
				if (type.IsEnum || GenUtil.IsBindableType(type) == false)
					return;

				generatableCount++;

				// TODO filter out types we currently don't support
				if (type.IsValueType == false)
					return;

				generatedCount++;

				var typeInfo = new TypeInfo(type);
				boundTypes.Add(typeInfo);

				if (typeInfo.IsStatic)
					Debug.LogWarning($"Static: {typeInfo.BindTypeFullName}");
				else if (type.IsAbstract)
					Debug.LogWarning($"Abstract: {typeInfo.BindTypeFullName}");

				if (type.IsNested)
					Debug.Log($"{type.FullName} nested in {type.DeclaringType?.FullName}");

				// var members = type.GetMembers();
				// foreach (var member in members)
				// {
				// 	Debug.Log($"\t\t{member.MemberType}: {member}");
				// }

				var sb = new ScriptBuilder(GenUtil.GeneratedFileHeader);
				AddUsingStatements(sb, typeInfo.Type.Namespace);
				AddNamespaceBlock(sb, module.BindingsAssemblyNamespace);
				if (typeInfo.IsStatic == false)
					GenerateInstanceType(sb, typeInfo);
				GenerateStaticType(sb, typeInfo);
				EndNamespaceBlock(sb);

				WriteFile(sb, contentFolderPath, typeInfo.InstanceTypeName);
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
			sb.AppendLine("#pragma warning disable CS0162 // Unreachable code detected");
			sb.Append("namespace ");
			sb.AppendLine(@namespace);
			sb.OpenIndentedBlock("{"); // { namespace
		}

		private static void EndNamespaceBlock(ScriptBuilder sb)
		{
			sb.CloseIndentedBlock("}"); // namespace }
			sb.AppendLine("#pragma warning restore CS0162 // Unreachable code detected");
		}

		private static void GenerateInstanceType(ScriptBuilder sb, TypeInfo typeInfo)
		{
			var instanceFieldName = typeInfo.Type.IsValueType ? "m_Value" : "m_Instance";
			AddTypeDeclaration(sb, typeInfo.InstanceTypeName, false);
			AddInstanceFieldAndProperty(sb, instanceFieldName, typeInfo.BindTypeFullName);
			AddToStringOverride(sb, instanceFieldName);
			AddImplicitOperator(sb, typeInfo.InstanceTypeName);
			AddMetatableFieldAndProperty(sb);
			AddIndexMetamethod(sb, typeInfo.InstanceTypeName);
			AddNewIndexMetamethod(sb, typeInfo.InstanceTypeName);
			EndTypeDeclaration(sb);
		}

		private static void AddToStringOverride(ScriptBuilder sb, String fieldName)
		{
			sb.AppendIndented("public override string ToString() => ");
			sb.Append(fieldName);
			sb.AppendLine(".ToString();");
		}

		private static void GenerateStaticType(ScriptBuilder sb, TypeInfo typeInfo)
		{
			AddTypeDeclaration(sb, typeInfo.StaticTypeName, true);
			AddBindType(sb, typeInfo.BindTypeFullName);
			sb.AppendIndentedLine("public override string ToString() => BindType.FullName;");
			AddImplicitOperator(sb, typeInfo.StaticTypeName);
			AddMetatableFieldAndProperty(sb);
			AddIndexMetamethod(sb, typeInfo.StaticTypeName);
			AddNewIndexMetamethod(sb, typeInfo.StaticTypeName);
			EndTypeDeclaration(sb);
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
			sb.AppendIndentedLine(
				"set => throw new System.NotSupportedException(\"Metatable of bound types not assignable\");");
			sb.CloseIndentedBlock("}"); // Metatable }
		}

		private static void AddIndexMetamethod(ScriptBuilder sb, String typeName)
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
			// TODO insert cases here ...
			sb.AppendIndentedLine("default: throw new LuaRuntimeException(context.Thread, instance, 2);");
			sb.CloseIndentedBlock("}");

			// internal static LuaValue TryGetValue(Lua_UnityEngine_Component instance, String key,
			// 	LuaFunctionExecutionContext context) => key switch
			// {
			// 	"BroadcastMessage" => _BroadcastMessage,
			// 	"CompareTag" => _CompareTag,
			// 	"GetComponent" => _GetComponent,
			// 	"GetComponentIndex" => _GetComponentIndex,
			// 	"GetHashCode" => _GetHashCode,
			// 	"GetInstanceID" => _GetInstanceID,
			// 	"SendMessage" => _SendMessage,
			// 	"SendMessageUpwards" => _SendMessageUpwards,
			// 	"ToString" => _ToString,
			// 	var _ => throw new LunyBindingException(instance, key, context, BindingType.Getter),
			// };

			// internal static LuaValue TryGetValue(Lua_UnityEngine_GameObject instance, String key, LuaFunctionExecutionContext context)
			// {
			// 	switch (key)
			// 	{
			// 		case "BroadcastMessage": return _BroadcastMessage;
			// 		case "CompareTag": return _CompareTag;
			// 		case "GetComponentCount": return _GetComponentCount;
			// 		case "GetHashCode": return _GetHashCode;
			// 		case "GetInstanceID": return _GetInstanceID;
			// 		case "SendMessage": return _SendMessage;
			// 		case "SendMessageUpwards": return _SendMessageUpwards;
			// 		case "SetActive": return _SetActive;
			// 		case "ToString": return _ToString;
			// 		default: throw new LunyBindingException(instance, key, context, BindingType.Getter);
			// 	}
			// }

			sb.AppendIndentedLine("return new ValueTask<int>(context.Return(value));");
			sb.CloseIndentedBlock("});");
		}

		private static void AddNewIndexMetamethod(ScriptBuilder sb, String typeName)
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
			// TODO insert cases here ...
			sb.AppendIndentedLine("default: throw new LuaRuntimeException(context.Thread, instance, 2);");
			sb.CloseIndentedBlock("}");
			sb.AppendIndentedLine("return new ValueTask<int>(context.Return(0));");
			sb.CloseIndentedBlock("});");
		}

		private static void WriteFile(ScriptBuilder sb, String contentFolderPath, String typeName)
		{
			var assetPath = $"{contentFolderPath}/{typeName}.cs";
			try
			{
				var fullPath = Path.GetFullPath(assetPath);
				File.WriteAllText(fullPath, sb.ToString());
			}
			catch (Exception e)
			{
				Debug.LogError($"Failed to write file: {assetPath}\n{e}");
			}
		}

		internal class MemberInfo
		{
			public ConstructorInfo[] Ctors;
			public EventInfo[] Events;
			public FieldInfo[] Fields;
			public PropertyInfo[] Properties;
			public MethodInfo[] Methods;

			public MemberInfo(Type type, BindingFlags bindingFlags)
			{
				Ctors = type.GetConstructors(bindingFlags);
				Events = type.GetEvents(bindingFlags);
				Fields = type.GetFields(bindingFlags);
				Properties = type.GetProperties(bindingFlags);
				Methods = type.GetMethods(bindingFlags);
			}
		}

		internal class TypeInfo
		{
			public readonly Type Type;
			public readonly String InstanceTypeName;
			public readonly String StaticTypeName;
			public readonly String BindTypeFullName;
			public String InstanceFieldName;
			public readonly Boolean IsStatic;
			public MemberInfo InstanceMembers;
			public MemberInfo StaticMembers;

			public TypeInfo(Type type)
			{
				Type = type;
				var typeFullNameNoPlus = type.FullName.Replace('+', '.');
				var typeFullNameNoDots = typeFullNameNoPlus.Replace('.', '_');
				InstanceTypeName = $"Lua_{typeFullNameNoDots}";
				StaticTypeName = $"{InstanceTypeName}_static";
				BindTypeFullName = typeFullNameNoPlus;

				if (type.IsEnum == false)
				{
					IsStatic = type.IsAbstract && type.IsSealed;
					InstanceFieldName = type.IsValueType ? "m_Value" : "m_Instance";
					InstanceMembers = new MemberInfo(type, BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly);
					StaticMembers = new MemberInfo(type, BindingFlags.Public | BindingFlags.Static | BindingFlags.DeclaredOnly);
				}
			}
		}
	}
}
