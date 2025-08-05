// Copyright (C) 2021-2025 Steffen Itterheim
// Refer to included LICENSE file for terms and conditions.

using CodeSmileEditor.Luny.Generator.CSharp;
using Luny;
using System;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

namespace CodeSmileEditor.Luny.Generator
{
	internal static class ModuleAssemblyDefinitionGenerator
	{
		public static void Generate(LunyLuaModule module, String contentFolderPath, IEnumerable<String> namespaces,
			AssemblyDefinitionAssets asmdefAssets)
		{
			var modulePath = AssetDatabase.GetAssetPath(module);
			var isEditorModule = EditorAssetUtility.IsEditorPath(modulePath) || EditorAssetUtility.IsEditorAssembly(modulePath);
			var asmDefName = module.BindingsAssemblyName;

			var sb = new ScriptBuilder();
			sb.OpenIndentBlock("{");
			AddName(sb, asmDefName);
			AddReferences(sb, namespaces, asmdefAssets, isEditorModule);
			AddIncludedPlatforms(sb, modulePath);
			AddDefaultSettings(sb);
			sb.CloseIndentBlock("}");

			/* TODO: consider adding version defines for current editor version
    "versionDefines": [
        {
            "name": "Unity",
            "expression": "[6000.0,6000.1)",
            "define": "LUA_MODULE_VERSION_6_0"
        }
    ],
			 */

			var assetPath = $"{contentFolderPath}/{asmDefName}.asmdef";
			GenUtil.WriteFile(assetPath, sb.ToString());
		}

		private static void AddName(ScriptBuilder sb, String asmDefName)
		{
			sb.AppendIndent("\"name\": \"");
			sb.Append(asmDefName);
			sb.AppendLine("\",");
		}

		private static void AddReferences(ScriptBuilder sb, IEnumerable<String> namespaces, AssemblyDefinitionAssets asmdefAssets,
			Boolean isEditorModule)
		{
			sb.AppendIndentLine("\"references\": [");
			sb.IncrementIndent();

			sb.AppendIndent("\"GUID:");
			sb.Append(GetGuidForReference(asmdefAssets, "CodeSmile.Luny"));
			sb.AppendLine("\",");
			sb.AppendIndent("\"GUID:");
			sb.Append(GetGuidForReference(asmdefAssets, "Lua.Unity"));
			sb.Append("\"");
			if (isEditorModule)
			{
				sb.AppendLine(",");
				sb.AppendIndent("\"GUID:");
				sb.Append(GetGuidForReference(asmdefAssets, "CodeSmileEditor.Luny"));
				sb.Append("\"");
			}

			foreach (var ns in namespaces)
			{
				var asmdefGuid = GetGuidForReference(asmdefAssets, ns);
				if (String.IsNullOrEmpty(asmdefGuid) == false)
				{
					sb.AppendLine(",");
					sb.AppendIndent("\"GUID:");
					sb.Append(asmdefGuid);
					sb.Append("\"");
				}
			}

			sb.AppendLine();
			sb.CloseIndentBlock("],");
		}

		private static void AddIncludedPlatforms(ScriptBuilder sb, String modulePath)
		{
			sb.AppendIndentLine("\"includePlatforms\": [");
			sb.IncrementIndent();
			if (EditorAssetUtility.IsEditorPath(modulePath) || EditorAssetUtility.IsEditorAssembly(modulePath))
				sb.AppendIndentLine("\"Editor\"");
			sb.CloseIndentBlock("],");
		}

		private static void AddDefaultSettings(ScriptBuilder sb)
		{
			sb.AppendIndentLine("\"excludePlatforms\": [],");
			sb.AppendIndentLine("\"allowUnsafeCode\": false,");
			sb.AppendIndentLine("\"overrideReferences\": false,");
			sb.AppendIndentLine("\"precompiledReferences\": [],");
			sb.AppendIndentLine("\"autoReferenced\": true,");
			sb.AppendIndentLine("\"defineConstraints\": [],");
			sb.AppendIndentLine("\"versionDefines\": [],");
			sb.AppendIndentLine("\"noEngineReferences\": false");
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
