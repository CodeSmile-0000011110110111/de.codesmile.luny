// Copyright (C) 2021-2025 Steffen Itterheim
// Refer to included LICENSE file for terms and conditions.

using CodeSmile.Luny;
using System;
using UnityEditor;
using UnityEngine;

namespace CodeSmileEditor.Luny.Generator
{
	internal static class ModuleFactoryGenerator
	{
		public static void Generate(LunyLuaModule module, String contentFolderPath)
		{
			var typeInfos = ModuleBindingsGenerator.TypeInfosByType;

			if (typeInfos.TryGetValue(typeof(GameObject), out var gameObjectTypeInfo))
				GenerateGameObjectFactory(module, gameObjectTypeInfo, contentFolderPath);
		}

		private static void GenerateGameObjectFactory(LunyLuaModule module, GenTypeInfo typeInfo, String contentFolderPath)
		{
			var @namespace = module.BindingsNamespace;
			var factoryClassName = $"{typeInfo.InstanceLuaTypeName}_Factory";
			module.GameObjectFactoryTypeName = $"{@namespace}.{factoryClassName}";

			var sb = new ScriptBuilder(GenUtil.GeneratedFileHeader);
			AddUsingStatements(sb, typeInfo);
			AddNamespaceBlock(sb, @namespace);
			AddClassBlock(sb, factoryClassName);
			AddCreateMethod(sb, typeInfo);
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
			sb.AppendLine(nameof(LuaGameObjectFactoryBase));
			sb.OpenIndentBlock("{");
		}

		private static void EndClassBlock(ScriptBuilder sb) => sb.CloseIndentBlock("}");

		private static void AddCreateMethod(ScriptBuilder sb, GenTypeInfo typeInfo)
		{
			sb.AppendIndent("public override ");
			sb.Append(nameof(ILuaUnityEngineGameObject));
			sb.Append(" Create(");
			sb.Append(typeInfo.Type.FullName);
			sb.Append(" gameObject) => ");
			sb.Append("new ");
			sb.Append(typeInfo.InstanceLuaTypeName);
			sb.AppendLine("(gameObject);");
		}
	}
}
