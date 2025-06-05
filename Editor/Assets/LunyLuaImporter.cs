using CodeSmile.Luny;
using System;
using System.IO;
using UnityEditor;
using UnityEditor.AssetImporters;
using UnityEditor.Compilation;
using UnityEngine;

namespace CodeSmileEditor.Luny
{
	[ScriptedImporter(1, "lua")]
	public sealed class LunyLuaImporter : ScriptedImporter
	{
		private static Assembly[] s_Assemblies;

		[InitializeOnLoadMethod]
		private static void OnLoad() => s_Assemblies = CompilationPipeline.GetAssemblies(AssembliesType.Editor);

		public override void OnImportAsset(AssetImportContext ctx)
		{
			var assetType = GetAssetType(ctx.assetPath);
			var asset = ScriptableObject.CreateInstance(assetType);
			(asset as LunyLuaAssetBase).text = File.ReadAllText(ctx.assetPath);
			ctx.AddObjectToAsset("Main", asset);
			ctx.SetMainObject(asset);
		}

		private Type GetAssetType(String assetPath)
		{
			// Lua scripts created in "Editor" folder are considered editor scripts
			if (assetPath.ToLower().Contains("/editor/"))
				return typeof(LunyEditorLuaAsset);

			// Check if the script is in an editor assembly, that also makes it an editor script
			var assemblyName = CompilationPipeline.GetAssemblyNameFromScriptPath(assetPath);
			foreach (var assembly in s_Assemblies)
			{
				if ((assembly.flags & AssemblyFlags.EditorAssembly) != 0 && assemblyName.StartsWith(assembly.name))
					return typeof(LunyEditorLuaAsset);
			}

			return typeof(LunyLuaAsset);
		}
	}
}
