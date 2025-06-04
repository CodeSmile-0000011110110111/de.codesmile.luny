// Copyright (C) 2021-2025 Steffen Itterheim
// Refer to included LICENSE file for terms and conditions.

using CodeSmile.Luny;
using CodeSmile.Utility;
using Lua.Unity;
using System;
using System.IO;
using UnityEditor;
using UnityEngine;

namespace CodeSmileEditor.Luny
{
	public sealed class LunyAssetRegistryWorker : ScriptableSingleton<LunyAssetRegistryWorker>
	{
		[SerializeField] [ReadOnlyField] private String m_ModuleBindingsUnityVersion;

		private static LunyAssetRegistry s_Singleton;
		public static LunyAssetRegistry Singleton => s_Singleton;

		internal static LunyAssetRegistry FindOrCreate()
		{
			if (s_Singleton != null)
				return s_Singleton;

			var registryGuids = AssetDatabase.FindAssets($"t:{nameof(LunyAssetRegistry)}");

			// we got none => create it
			if (registryGuids.Length == 0)
				return s_Singleton = CreateRegistryAsset();

			// we got multiple => delete duplicates (doesn't matter which)
			if (registryGuids.Length > 1)
				TryDeleteDuplicateRegistries(registryGuids);

			// pick the remaining one from the guids that we'll use
			return s_Singleton = FindRegistryAsset(registryGuids);
		}

		// delayCall prevents "Asset import worker (4)" warning spam when selecting the registry asset
		// this is likely due to modifying the AssetDatabase 'too early' (ie same issue as with static ctor)
		[InitializeOnLoadMethod] private static void OnLoad() => EditorApplication.delayCall += () => InitRegistry();
		[InitializeOnEnterPlayMode] private static void OnPlayMode() => InitRegistry();

		private static void InitRegistry()
		{
			if (Singleton == null)
				s_Singleton = FindOrCreate();
		}

		private static LunyAssetRegistry CreateRegistryAsset()
		{
			var registry = CreateInstance<LunyAssetRegistry>();

			var path = $"Assets/{nameof(LunyAssetRegistry)}.asset";
			AssetDatabase.CreateAsset(registry, path);

			ScanForLunyAssets(registry);
			return registry;
		}

		private static void TryDeleteDuplicateRegistries(String[] registryAssetGuids)
		{
			s_Singleton = null;

			foreach (var registryGuid in registryAssetGuids)
			{
				var path = AssetDatabase.GUIDToAssetPath(registryGuid);
				var loadedRegistry = AssetDatabase.LoadAssetAtPath<LunyAssetRegistry>(path);
				if (loadedRegistry != null)
				{
					if (Singleton == null)
						s_Singleton = loadedRegistry;
					else
					{
						// delete extraneous registry assets, no matter how they came to be (they would all be the same)
						Debug.Log($"Deleting extraneous {nameof(LunyAssetRegistry)}: {path}");
						AssetDatabase.DeleteAsset(path);
					}
				}
			}
		}

		private static LunyAssetRegistry FindRegistryAsset(String[] registryAssetGuids)
		{
			foreach (var registryGuid in registryAssetGuids)
			{
				var path = AssetDatabase.GUIDToAssetPath(registryGuid);

				// could be one of the duplicates we may have just deleted ...
				if (path.Length == 0)
					continue;

				var registry = AssetDatabase.LoadAssetAtPath<LunyAssetRegistry>(path);
				if (registry != null)
				{
					ScanForLunyAssets(registry);
					return registry;
				}
			}

			return null;
		}

		private void Awake()
		{
			// Note: Awake runs when the asset is created OR when the project loads
			if (m_ModuleBindingsUnityVersion != Application.unityVersion)
				RegenerateAllModules();
		}

		private void RegenerateAllModules()
		{
			Debug.LogWarning("TODO: RegenerateAllModules");

			// Debug.Log("Unity version has changed. Regenerating all LuaModule bindings ...");
			// var moduleGuids = AssetDatabase.FindAssets($"t:{nameof(LuaModule)}");
			//
			// // use a temporary Lua context with no modules loaded
			// var luaContext = CreateInstance<LuaContext>();
			// var lua = luaContext.CreateLuaInstance(false);
			//
			// foreach (var moduleGuid in moduleGuids)
			// {
			// 	var path = AssetDatabase.GUIDToAssetPath(moduleGuid);
			// 	var module = AssetDatabase.LoadAssetAtPath<LuaModule>(path);
			// 	if (module != null)
			// 		module.GenerateBindings(lua);
			// }
			//
			// m_ModuleBindingsUnityVersion = Application.unityVersion;
			// EditorUtility.SetDirty(this);
			// AssetDatabase.SaveAssetIfDirty(this);
		}

		private static void ScanForLunyAssets(LunyAssetRegistry registry)
		{
			Debug.LogWarning("TODO: scan for assets");
			// ScanForLuaContexts();
			// ScanForLuaAssets();
			EditorUtility.SetDirty(registry);
			AssetDatabase.SaveAssetIfDirty(registry);
		}

		/*
		private void ScanForLuaContexts()
		{
			m_LuaContexts.Clear();
			m_DefaultContext = null;
			m_DefaultEditorContext = null;

			var luaContextGuids = AssetDatabase.FindAssets($"t:{nameof(LuaContext)}");
			var luaContextCount = luaContextGuids.Length;
			for (var i = 0; i < luaContextCount; i++)
			{
				var path = AssetDatabase.GUIDToAssetPath(luaContextGuids[i]);
				var luaContext = AssetDatabase.LoadAssetAtPath<LuaContext>(path);
				if (luaContext != null)
				{
					m_LuaContexts.Add(luaContext);

					if (luaContext.IsDefaultContext)
					{
						if (luaContext.IsEditorContext)
						{
							Debug.Assert(DefaultEditorContext == null, $"duplicate default editor LuaContext: {luaContext}");
							m_DefaultEditorContext = luaContext;
						}
						else
						{
							Debug.Assert(DefaultContext == null, $"duplicate default runtime LuaContext: {luaContext}");
							m_DefaultContext = luaContext;
						}
					}
				}
			}

			Debug.Assert(DefaultContext != null, "Missing default runtime LuaContext!");
			Debug.Assert(DefaultEditorContext != null, "Missing default editor LuaContext!");
		}

		private void ScanForLuaAssets()
		{
			m_LuaAssets.Clear();
			m_LuaAssetNames.Clear();
			m_LuaAssetNamesLowercase.Clear();
			m_LuaAssetPaths.Clear();

			var luaAssetGuids = AssetDatabase.FindAssets($"t:{nameof(LuaAsset)}");
			var luaAssetCount = luaAssetGuids.Length;
			for (var i = 0; i < luaAssetCount; i++)
			{
				var path = AssetDatabase.GUIDToAssetPath(luaAssetGuids[i]);
				var luaAsset = AssetDatabase.LoadAssetAtPath<LuaAsset>(path);
				if (luaAsset != null)
				{
					m_LuaAssets.Add(luaAsset);
					m_LuaAssetNames.Add(luaAsset.name);
					m_LuaAssetNamesLowercase.Add(luaAsset.name.ToLower());
					m_LuaAssetPaths.Add(path);
				}
			}
		}
		*/

		private class LuaAssetRegistryPostprocessor : AssetPostprocessor
		{
			private static void OnPostprocessAllAssets(String[] importedAssets, String[] deletedAssets, String[] movedAssets,
				String[] movedFromAssetPaths)
			{
				if (Singleton == null)
					return;

				// deleted assets aren't checked, it's okay to (temporarily) have some 'null' assets in the registry
				foreach (var importedAssetPath in importedAssets)
				{
					if (CheckForLuaAsset(importedAssetPath))
						return;
				}
				foreach (var movedAssetPath in movedAssets)
				{
					if (CheckForLuaAsset(movedAssetPath))
						return;
				}
			}

			private static Boolean CheckForLuaAsset(String assetPath)
			{
				if (IsLuaAsset(assetPath))
				{
					ScanForLunyAssets(Singleton);
					return true;
				}
				return false;
			}

			private static Boolean IsLuaAsset(String assetPath) => Path.GetExtension(assetPath) == ".lua";
		}

		// private class LuaAssetModificationProcessor : AssetModificationProcessor
		// {
		// 	private static void OnWillCreateAsset(String assetName)
		// 	{
		// 		Debug.Log($"OnWillCreateAsset {assetName}");
		// 	}
		//
		// 	private static AssetDeleteResult OnWillDeleteAsset(String assetPath, RemoveAssetOptions options)
		// 	{
		// 		Debug.Log($"OnWillDeleteAsset {assetPath}, {options}");
		// 		return AssetDeleteResult.DidNotDelete;
		// 	}
		//
		// 	private static AssetMoveResult OnWillMoveAsset(String sourcePath, String destinationPath)
		// 	{
		// 		return AssetMoveResult.DidNotMove;
		// 	}
		//
		// 	private static Boolean CheckForLuaAsset(String assetPath)
		// 	{
		// 		if (IsLuaAsset(assetPath))
		// 		{
		// 			Singleton?.ScanForLuaAssets();
		// 			return true;
		// 		}
		// 		return false;
		// 	}
		//
		// 	private static Boolean IsLuaAsset(String assetPath) => Path.GetExtension(assetPath) == ".lua";
		// }
	}
}
