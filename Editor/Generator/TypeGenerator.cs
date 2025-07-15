// Copyright (C) 2021-2025 Steffen Itterheim
// Refer to included LICENSE file for terms and conditions.

using CodeSmile.Luny;
using System;
using System.IO;
using System.Reflection;
using System.Threading.Tasks;
using UnityEditor;
using UnityEngine;

namespace CodeSmileEditor.Luny.Generator
{
	internal static class TypeGenerator
	{
		public static void Generate(LunyLuaModule module, String contentFolderPath, TypeHierarchy typeHierarchy)
		{
			var generatableCount = 0;
			var generatedCount = 0;
			typeHierarchy.Visit(async (node, level) =>
			{
				var type = node.Value;
				if (GenUtil.IsBindableType(type) == false)
					return;

				generatableCount++;

				// TODO filter out types we currently don't support

				generatedCount++;

				var instanceTypeName = $"Lua_{type.Name}";
				var staticTypeName = $"{instanceTypeName}_static";
				var typeFullName = type.FullName.Replace('+', '.');
				var isStatic = type.IsAbstract && type.IsSealed;
				if (isStatic)
					Debug.LogWarning($"Static: {typeFullName}");
				else if (type.IsAbstract)
					Debug.Log($"Abstract: {typeFullName}");

				var publicInstanceFlags = BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly;
				var instanceCtors = type.GetConstructors(publicInstanceFlags);
				var instanceEvents = type.GetEvents(publicInstanceFlags);
				var instanceFields = type.GetFields(publicInstanceFlags);
				var instanceProperties = type.GetProperties(publicInstanceFlags);
				var instanceMethods = type.GetMethods(publicInstanceFlags);
				if (instanceEvents.Length > 0 || instanceFields.Length > 0 || instanceProperties.Length > 0 || instanceMethods.Length > 0)
					Debug.Log($"{typeFullName}: ctors={instanceCtors.Length}, events={instanceEvents.Length}, fields={instanceFields.Length}, properties={instanceProperties.Length}, methods={instanceMethods.Length}");
				else
				{
					Debug.LogWarning($"{typeFullName} has no public members!");
				}

				var publicStaticFlags = BindingFlags.Public | BindingFlags.Static;

				// var members = type.GetMembers();
				// foreach (var member in members)
				// {
				// 	Debug.Log($"\t\t{member.MemberType}: {member}");
				// }

				var sb = new ScriptBuilder(GenUtil.GeneratedFileHeader);
				sb.AppendLine("using CodeSmile.Luny;");
				sb.AppendLine("using Lua;");
				sb.AppendLine("using Lua.Runtime;");
				sb.AppendLine("using System.Threading.Tasks;");
				sb.Append("using ");
				sb.Append(type.Namespace);
				sb.AppendLine(";\n");

				sb.Append("namespace ");
				sb.AppendLine(module.BindingsAssemblyNamespace);
				sb.OpenIndentedBlock("{"); // { namespace

				if (isStatic == false)
					GenerateInstanceType(sb, type, instanceTypeName, typeFullName);
				GenerateStaticType(sb, type, staticTypeName, typeFullName);

				sb.CloseIndentedBlock("}"); // namespace }

				await WriteFile(sb, contentFolderPath, instanceTypeName);
			});

			EditorApplication.delayCall += () => Debug.Log($"{generatedCount} of {generatableCount} " +
			                                               $"({(Int32)(generatedCount / (Single)generatableCount * 100f)}%) " +
			                                               "types generated");
		}

		private static async Task WriteFile(ScriptBuilder sb, String contentFolderPath, String typeName)
		{
			var assetPath = $"{contentFolderPath}/{typeName}.cs";
			try
			{
				var fullPath = Path.GetFullPath(assetPath);
				await File.WriteAllTextAsync(fullPath, sb.ToString()).ConfigureAwait(false);
			}
			catch (Exception e)
			{
				Debug.LogError($"Failed to write file: {assetPath}\n{e}");
			}
		}

		private static void GenerateInstanceType(ScriptBuilder sb, Type type, String typeName, String typeFullName)
		{
			var instanceFieldName = type.IsValueType ? "m_Value" : "m_Instance";
			AddTypeDeclaration(sb, typeName, false);
			AddInstanceFieldAndProperty(sb, instanceFieldName, typeFullName);
			AddToStringOverride(sb, instanceFieldName);
			AddImplicitOperator(sb, typeName);
			AddMetatableFieldAndProperty(sb);
			AddIndexMetamethod(sb, typeName);
			AddNewIndexMetamethod(sb, typeName);
			EndTypeDeclaration(sb);
		}

		private static void AddToStringOverride(ScriptBuilder sb, String fieldName)
		{
			sb.AppendIndented("public override string ToString() => ");
			sb.Append(fieldName);
			sb.AppendLine(".ToString();");
		}

		private static void GenerateStaticType(ScriptBuilder sb, Type type, String typeName, String typeFullName)
		{
			AddTypeDeclaration(sb, typeName, true);
			AddBindType(sb, typeFullName);
			sb.AppendIndentedLine("public override string ToString() => BindType.FullName;");
			AddImplicitOperator(sb, typeName);
			AddMetatableFieldAndProperty(sb);
			AddIndexMetamethod(sb, typeName);
			AddNewIndexMetamethod(sb, typeName);
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
			sb.AppendLine("#pragma warning disable CS0162 // Unreachable code detected");
		}

		private static void EndTypeDeclaration(ScriptBuilder sb)
		{
			sb.AppendLine("#pragma warning restore CS0162 // Unreachable code detected");
			sb.CloseIndentedBlock("}"); // class }
		}

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
	}
}
