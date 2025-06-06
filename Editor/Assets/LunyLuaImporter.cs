using CodeSmile.Luny;
using CodeSmileEditor.Core;
using System;
using System.IO;
using UnityEditor;
using UnityEditor.AssetImporters;
using UnityEngine;

namespace CodeSmileEditor.Luny
{
	[ScriptedImporter(1, "lua")]
	public sealed class LunyLuaImporter : ScriptedImporter
	{
		public override void OnImportAsset(AssetImportContext ctx)
		{
			var scriptType = GetLuaScriptType(ctx.assetPath);
			var asset = ScriptableObject.CreateInstance(scriptType);
			(asset as LunyLuaAssetBase).text = File.ReadAllText(ctx.assetPath);
			ctx.AddObjectToAsset("Main", asset);
			ctx.SetMainObject(asset);
		}

		private Type GetLuaScriptType(String assetPath) =>
			// Lua scripts created in "Editor" folders or assemblies are considered editor-only Lua scripts
			AssetUtility.IsEditorPath(assetPath) || AssetUtility.IsEditorAssembly(assetPath)
				? typeof(LunyEditorLuaAsset)
				: typeof(LunyLuaAsset);
	}
}
