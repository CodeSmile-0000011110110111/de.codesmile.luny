// Copyright (C) 2021-2025 Steffen Itterheim
// Refer to included LICENSE file for terms and conditions.

using CodeSmile.Luny;
using System;
using UnityEditor;
using UnityEngine;

namespace CodeSmileEditor.Luny.Generator
{
	internal static class AssemblyDefinitionGenerator
	{
		public static void Generate(LunyLuaModule module, String contentFolderPath, TypeHierarchy typeHierarchy,
			AssemblyDefinitionAssets asmdefAssets)
		{
			var modulePath = AssetDatabase.GetAssetPath(module);
			var isEditorModule = EditorAssetUtility.IsEditorPath(modulePath) || EditorAssetUtility.IsEditorAssembly(modulePath);
			var asmDefName = module.BindingsNamespace;

			var sb = new ScriptBuilder();
			sb.OpenIndentedBlock("{");
			AddNameAndNamespace(sb, asmDefName);
			AddReferences(sb, typeHierarchy, asmdefAssets, isEditorModule);
			AddIncludedPlatforms(sb, modulePath);
			AddDefaultSettings(sb);
			sb.CloseIndentedBlock("}");

			var assetPath = $"{contentFolderPath}/{asmDefName}.asmdef";
			GenUtil.WriteFile(assetPath, sb.ToString());
		}

		private static void AddNameAndNamespace(ScriptBuilder sb, String asmDefName)
		{
			sb.AppendIndented("\"name\": \"");
			sb.Append(asmDefName);
			sb.AppendLine("\",");

			sb.AppendIndented("\"rootNamespace\": \"");
			sb.Append(asmDefName);
			sb.AppendLine("\",");
		}

		private static void AddReferences(ScriptBuilder sb, TypeHierarchy typeHierarchy,
			AssemblyDefinitionAssets asmdefAssets,
			Boolean isEditorModule)
		{
			sb.AppendIndentedLine("\"references\": [");
			sb.IncrementIndent();

			sb.AppendIndented("\"GUID:");
			sb.Append(GetGuidForReference(asmdefAssets, "CodeSmile.Luny"));
			sb.Append("\"");
			if (isEditorModule)
			{
				sb.AppendLine(",");
				sb.AppendIndented("\"GUID:");
				sb.Append(GetGuidForReference(asmdefAssets, "CodeSmileEditor.Luny"));
				sb.Append("\"");
			}

			foreach (var ns in typeHierarchy.Namespaces)
			{
				var asmdefGuid = GetGuidForReference(asmdefAssets, ns);
				if (String.IsNullOrEmpty(asmdefGuid) == false)
				{
					sb.AppendLine(",");
					sb.AppendIndented("\"GUID:");
					sb.Append(asmdefGuid);
					sb.Append("\"");
				}
			}

			sb.AppendLine();
			sb.CloseIndentedBlock("],");
		}

		private static void AddIncludedPlatforms(ScriptBuilder sb, String modulePath)
		{
			sb.AppendIndentedLine("\"includePlatforms\": [");
			sb.IncrementIndent();
			if (EditorAssetUtility.IsEditorPath(modulePath) || EditorAssetUtility.IsEditorAssembly(modulePath))
				sb.AppendIndentedLine("\"Editor\"");
			sb.CloseIndentedBlock("],");
		}

		private static void AddDefaultSettings(ScriptBuilder sb)
		{
			sb.AppendIndentedLine("\"excludePlatforms\": [],");
			sb.AppendIndentedLine("\"allowUnsafeCode\": false,");
			sb.AppendIndentedLine("\"overrideReferences\": false,");
			sb.AppendIndentedLine("\"precompiledReferences\": [],");
			sb.AppendIndentedLine("\"autoReferenced\": true,");
			sb.AppendIndentedLine("\"defineConstraints\": [],");
			sb.AppendIndentedLine("\"versionDefines\": [],");
			sb.AppendIndentedLine("\"noEngineReferences\": false");
		}

		private static String GetGuidForReference(AssemblyDefinitionAssets asmdefAssets, String ns)
		{
			var guid = String.Empty;
			var asmdef = asmdefAssets[ns];
			if (asmdef != null)
				AssetDatabase.TryGetGUIDAndLocalFileIdentifier(asmdef, out guid, out var _);
			return guid;
		}
	}
}
