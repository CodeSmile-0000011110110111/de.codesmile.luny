// Copyright (C) 2021-2025 Steffen Itterheim
// Refer to included LICENSE file for terms and conditions.

using CodeSmile.Luny;
using System;
using UnityEditor;
using UnityEngine;
using Object = UnityEngine.Object;

namespace CodeSmileEditor.Luny.Generator
{
	internal static class ModuleFactoryGenerator
	{
		public static void Generate(LunyLuaModule module, String contentFolderPath)
		{
			var typeInfos = ModuleGenerator.TypeInfosByType;
			if (typeInfos.TryGetValue(typeof(Object), out var gameObjectTypeInfo))
				GenerateUnityObjectFactory(module, gameObjectTypeInfo, contentFolderPath);
		}

		private static void GenerateUnityObjectFactory(LunyLuaModule module, GenTypeInfo typeInfo, String contentFolderPath)
		{
			var @namespace = module.BindingsNamespace;
			var factoryClassName = $"{typeInfo.InstanceLuaTypeName}_Factory";
			module.UnityObjectFactoryTypeName = $"{@namespace}.{factoryClassName}";

			var sb = new ScriptBuilder(GenUtil.GeneratedFileHeader);
			AddUsingStatements(sb, typeInfo);
			AddNamespaceBlock(sb, @namespace);
			AddClassBlock(sb, factoryClassName);
			AddCreateLuaObjectMethod(sb, typeInfo);
			AddCreateLuaGameObjectMethod(sb, typeInfo);
			EndClassBlock(sb);
			EndNamespaceBlock(sb);

			var assetPath = $"{contentFolderPath}/_{factoryClassName}.cs";
			GenUtil.WriteFile(assetPath, sb.ToString());
		}

		private static void AddUsingStatements(ScriptBuilder sb, GenTypeInfo typeInfo)
		{
			sb.AppendLine("using CodeSmile.Luny;");
			sb.AppendLine();
		}

		private static void AddNamespaceBlock(ScriptBuilder sb, String @namespace)
		{
			sb.AppendIndent("namespace ");
			sb.AppendLine(@namespace);
			sb.OpenIndentBlock("{");
		}

		private static void EndNamespaceBlock(ScriptBuilder sb) => sb.CloseIndentBlock("}");

		private static void AddClassBlock(ScriptBuilder sb, String loaderClassName)
		{
			sb.AppendIndentLine("[System.Serializable]");
			sb.AppendIndent("public sealed class ");
			sb.Append(loaderClassName);
			sb.Append(" : ");
			sb.AppendLine(nameof(LuaUnityObjectFactoryBase));
			sb.OpenIndentBlock("{");
		}

		private static void EndClassBlock(ScriptBuilder sb) => sb.CloseIndentBlock("}");

		private static void AddCreateLuaObjectMethod(ScriptBuilder sb, GenTypeInfo typeInfo)
		{
			sb.AppendIndent("public override ");
			sb.Append(nameof(ILuaUnityObject));
			sb.Append(" CreateLuaObject(");
			sb.Append(typeInfo.Type.FullName);
			sb.Append(" obj) => ");
			sb.Append("new ");
			sb.Append(typeInfo.InstanceLuaTypeName);
			sb.AppendLine("(obj);");
		}

		private static void AddCreateLuaGameObjectMethod(ScriptBuilder sb, GenTypeInfo typeInfo)
		{
			if (ModuleGenerator.TypeInfosByType.TryGetValue(typeof(GameObject), out var luaGameObject))
			{
				sb.AppendIndent("public override ");
				sb.Append(nameof(ILuaUnityGameObject));
				sb.Append(" CreateLuaGameObject(");
				sb.Append(luaGameObject.Type.FullName);
				sb.Append(" gameObject) => ");
				sb.Append("new ");
				sb.Append(luaGameObject.InstanceLuaTypeName);
				sb.AppendLine("(gameObject);");
			}
		}
	}
}
