using Luny;
using LunyEditor.Core;
using System;
using System.IO;
using UnityEditor;
using UnityEditor.AssetImporters;
using UnityEngine;

namespace LunyEditor.Assets
{
	[ScriptedImporter(1, "lua")]
	public sealed class LunyLuaImporter : ScriptedImporter
	{
		public override void OnImportAsset(AssetImportContext ctx)
		{
			var scriptType = GetLuaScriptType(ctx.assetPath);
			var asset = ScriptableObject.CreateInstance(scriptType);
			var text = File.ReadAllText(ctx.assetPath);

			var luaAsset = (LunyLuaAsset)asset;
			luaAsset.Text = text;
			luaAsset.Path = ctx.assetPath;

			ctx.AddObjectToAsset("Main", asset); // must use asset, not luaAsset, to preserve correct type!
			ctx.SetMainObject(asset);
		}

		private Type GetLuaScriptType(String assetPath) =>
			// Lua scripts created in "Editor" folders or assemblies are considered editor-only Lua scripts
			EditorAssetUtil.IsEditorPath(assetPath) || EditorAssetUtil.IsEditorAssembly(assetPath)
				? typeof(LunyEditorLuaAsset)
				: EditorAssetUtil.IsModdingPath(assetPath)
					? typeof(LunyModdingLuaAsset)
					: typeof(LunyRuntimeLuaAsset);
	}
}
