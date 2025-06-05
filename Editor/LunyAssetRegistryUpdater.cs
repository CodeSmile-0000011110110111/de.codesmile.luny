// Copyright (C) 2021-2025 Steffen Itterheim
// Refer to included LICENSE file for terms and conditions.

using CodeSmile.Luny;
using Lua.Unity;
using System;
using System.IO;
using UnityEditor;
using UnityEngine;

namespace CodeSmileEditor.Luny
{
	internal sealed class LunyAssetRegistryUpdater : ScriptableSingleton<LunyAssetRegistryUpdater>
	{
		// delayCall prevents "Asset import worker (4)" warning spam when selecting the registry asset
		// this is likely due to modifying the AssetDatabase 'too early' (ie same issue as with static ctor)
		[InitializeOnLoadMethod] private static void OnLoad() => EditorApplication.delayCall += () => InitRegistry();
		[InitializeOnEnterPlayMode] private static void OnEnterPlayMode() => InitRegistry();

		private static void InitRegistry()
		{
			if (LunyAssetRegistry.Singleton == null)
				LunyAssetRegistry.Singleton = FindOrCreateRegistry();

			RegisterAllLunyAssets();
		}

		private static LunyAssetRegistry FindOrCreateRegistry()
		{
			var registryGuids = AssetDatabase.FindAssets($"t:{nameof(LunyAssetRegistry)}");

			// we got multiple => delete all and create new one
			if (registryGuids.Length > 1)
			{
				TryDeleteAllRegistries(registryGuids);
				registryGuids = new String[0];
			}

			// we found none => create it
			if (registryGuids.Length == 0)
				return CreateRegistry();

			var assetPath = AssetDatabase.GUIDToAssetPath(registryGuids[0]);
			return AssetDatabase.LoadAssetAtPath<LunyAssetRegistry>(assetPath);
		}

		private static LunyAssetRegistry CreateRegistry()
		{
			var registry = CreateInstance<LunyAssetRegistry>();
			var path = $"Assets/{nameof(LunyAssetRegistry)}.asset";
			AssetDatabase.CreateAsset(registry, path);
			return registry;
		}

		private static void TryDeleteAllRegistries(String[] registryAssetGuids)
		{
			LunyAssetRegistry.Singleton = null;

			foreach (var registryGuid in registryAssetGuids)
			{
				var path = AssetDatabase.GUIDToAssetPath(registryGuid);
				var loadedRegistry = AssetDatabase.LoadAssetAtPath<LunyAssetRegistry>(path);
				if (loadedRegistry != null)
				{
					// delete extraneous registry assets, no matter how they came to be (they would all be the same)
					Debug.Log($"Deleting extraneous {nameof(LunyAssetRegistry)}: {path}");
					AssetDatabase.DeleteAsset(path);
				}
			}
		}

		private static void RegisterAllLunyAssets()
		{
			Debug.LogWarning("TODO: scan for contexts");
			var registry = LunyAssetRegistry.Singleton;
			// ScanForLuaContexts();
			FindAndRegisterAllLuaAssets(registry);
			EditorUtility.SetDirty(registry);
			AssetDatabase.SaveAssetIfDirty(registry);
		}

		private static void FindAndRegisterAllLuaAssets(LunyAssetRegistry registry)
		{
			registry.ClearLuaAssets();

			var luaAssetGuids = AssetDatabase.FindAssets($"t:{nameof(LuaAsset)}");
			var luaAssetCount = luaAssetGuids.Length;
			for (var i = 0; i < luaAssetCount; i++)
			{
				var assetPath = AssetDatabase.GUIDToAssetPath(luaAssetGuids[i]);
				var luaAsset = AssetDatabase.LoadAssetAtPath<LuaAsset>(assetPath);
				if (luaAsset != null)
					registry.AddLuaAsset(luaAsset, luaAsset.name, assetPath);
			}
		}

		//[SerializeField] [ReadOnlyField] private String m_ModuleBindingsUnityVersion;
		// private void Awake()
		// {
		// 	// Note: Awake runs when the asset is created OR when the project loads
		// 	if (m_ModuleBindingsUnityVersion != Application.unityVersion)
		// 		RegenerateAllModules();
		// }
		//
		// private void RegenerateAllModules() => Debug.LogWarning("TODO: RegenerateAllModules");
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
		*/

		private class LuaAssetModificationProcessor : AssetModificationProcessor
		{
			private static void OnWillCreateAsset(String assetPath)
			{
				if (IsLuaAsset(assetPath))
				{
					// need to delay since asset cannot be loaded within this callback
					EditorApplication.delayCall += () =>
					{
						var luaAsset = AssetDatabase.LoadAssetAtPath<LuaAsset>(assetPath);
						if (luaAsset != null)
						{
							if (LunyAssetRegistry.Singleton == null)
								InitRegistry();
							else
								LunyAssetRegistry.Singleton.AddLuaAsset(luaAsset, luaAsset.name, assetPath);
						}
					};
				}
			}

			private static AssetDeleteResult OnWillDeleteAsset(String assetPath, RemoveAssetOptions options)
			{
				if (IsLuaAsset(assetPath))
				{
					var luaAsset = AssetDatabase.LoadAssetAtPath<LuaAsset>(assetPath);
					if (luaAsset != null)
					{
						if (LunyAssetRegistry.Singleton == null)
							EditorApplication.delayCall += InitRegistry; // delay to ensure asset is already deleted
						else
							LunyAssetRegistry.Singleton.RemoveLuaAsset(luaAsset, luaAsset.name, assetPath);
					}
				}
				return AssetDeleteResult.DidNotDelete;
			}

			private static AssetMoveResult OnWillMoveAsset(String sourcePath, String destinationPath)
			{
				if (IsLuaAsset(sourcePath))
				{
					var luaAsset = AssetDatabase.LoadAssetAtPath<LuaAsset>(sourcePath);
					if (luaAsset != null)
					{
						if (LunyAssetRegistry.Singleton == null)
							EditorApplication.delayCall += InitRegistry; // delay to ensure asset was already moved
						else
						{
							LunyAssetRegistry.Singleton.RemoveLuaAsset(luaAsset, luaAsset.name, sourcePath);

							// asset instance still has the old name so use the name from path instead
							var newName = Path.GetFileNameWithoutExtension(destinationPath);
							LunyAssetRegistry.Singleton.AddLuaAsset(luaAsset, newName, destinationPath);
						}
					}
				}
				return AssetMoveResult.DidNotMove;
			}

			private static Boolean IsLuaAsset(String assetPath) => Path.GetExtension(assetPath) == ".lua";
		}
	}
}
