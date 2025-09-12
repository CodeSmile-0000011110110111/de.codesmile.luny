// Copyright (C) 2021-2025 Steffen Itterheim
// Refer to included LICENSE file for terms and conditions.

#if UNITY_EDITOR
using UnityEditor.Compilation;
#endif
using System;
using System.IO;
using UnityEditor;
using UnityEngine;
using Assembly = System.Reflection.Assembly;
using Object = UnityEngine.Object;

namespace Luny.Core
{
	public static class AssetUtil
	{
#if UNITY_EDITOR
		private static readonly Int32 s_DllStringLength = ".dll".Length;
#endif

		/// <summary>
		/// Editor-only: Imports the asset, ie to pick up latest changes without forcing an entire Refresh().
		/// </summary>
		/// <param name="asset"></param>
		public static void IfEditor_ImportAsset(Object asset)
		{
#if UNITY_EDITOR
			if (asset != null)
				AssetDatabase.ImportAsset(AssetDatabase.GetAssetPath(asset));
#endif
		}

		public static void IfEditor_ImportAsset(String assetPath)
		{
#if UNITY_EDITOR
			if (assetPath != null)
				AssetDatabase.ImportAsset(assetPath);
#endif
		}

		public static Assembly IfEditor_GetAssemblyForPath(String assetPath)
		{
			Assembly assembly = null;

#if UNITY_EDITOR
			try
			{
				var assemblyName = CompilationPipeline.GetAssemblyNameFromScriptPath(assetPath);
				if (assemblyName != null)
					assembly = Assembly.Load(Path.GetFileNameWithoutExtension(assemblyName));
			}
			catch (Exception) {} // suppress errors
#endif

			return assembly;
		}

		public static Boolean IsEditorPath(String assetPath) => assetPath.ToLower().Contains("/editor/");

		/// <summary>
		/// Test if the current path is within an editor assembly definition. Does not check for "Editor" folders.
		/// </summary>
		/// <param name="assetPath"></param>
		/// <returns></returns>
		public static Boolean IfEditor_IsEditorAssembly(String assetPath)
		{
#if UNITY_EDITOR
			var assemblyName = CompilationPipeline.GetAssemblyNameFromScriptPath(assetPath);
			if (assemblyName != null && assemblyName.Length > s_DllStringLength)
			{
				// strip ".dll" from name
				assemblyName = assemblyName.Substring(0, assemblyName.Length - s_DllStringLength);

				var assemblies = CompilationPipeline.GetAssemblies();
				if (assemblies != null)
				{
					foreach (var assembly in assemblies)
					{
						if (assembly != null && (assembly.flags & AssemblyFlags.EditorAssembly) != 0 && assemblyName.Equals(assembly.name))
							return true;
					}
				}
			}
#endif

			return false;
		}
	}
}
