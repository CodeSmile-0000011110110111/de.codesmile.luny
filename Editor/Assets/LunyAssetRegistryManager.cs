﻿// Copyright (C) 2021-2025 Steffen Itterheim
// Refer to included LICENSE file for terms and conditions.

using CodeSmile.Luny;
using System;
using System.IO;
using System.Linq;
using UnityEditor;
using UnityEngine;

namespace CodeSmileEditor.Luny
{
	internal sealed class LunyAssetRegistryManager : ScriptableSingleton<LunyAssetRegistryManager>
	{
		private static LunyRuntimeAssetRegistry s_RuntimeRegistry;

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

		public static void GetOrFindDefaultLuaContexts(out LunyLuaContext editorContext, out LunyLuaContext runtimeContext)
		{
			var settings = LunyProjectSettings.instance;
			editorContext = settings.DefaultEditorContext;
			runtimeContext = settings.DefaultRuntimeContext;
			if (editorContext != null && runtimeContext != null)
				return;

			var filter = $"t:{nameof(LunyLuaContext)} l:{LunyAssetLabel.DefaultLuaContext}";
			var contextGuids = AssetDatabase.FindAssets(filter, new[] { "Packages/de.codesmile.luny" });

			// in case package was localized or modified try finding defaults in /Assets
			if (contextGuids.Length == 0)
				contextGuids = AssetDatabase.FindAssets(filter);

			foreach (var contextGuid in contextGuids)
			{
				var contextPath = AssetDatabase.GUIDToAssetPath(contextGuid);
				var context = AssetDatabase.LoadAssetAtPath<LunyLuaContext>(contextPath);
				if (context != null)
				{
					var labels = AssetDatabase.GetLabels(context);
					if (editorContext == null && labels.Contains(LunyAssetLabel.EditorLuaContext))
						settings.DefaultEditorContext = editorContext = context;
					if (runtimeContext == null && labels.Contains(LunyAssetLabel.RuntimeLuaContext))
						settings.DefaultRuntimeContext = runtimeContext = context;
				}
			}
		}

		// delayCall prevents "Asset import worker (4)" warning spam when selecting the registry asset
		// this is likely due to modifying the AssetDatabase 'too early' (ie same issue as with static ctor)
		[InitializeOnLoadMethod] private static void OnLoad() => EditorApplication.delayCall += () => InitRegistries();

		// Ensure we're not starting playmode without a registry (in case user deleted registry and clicked play)
		[InitializeOnEnterPlayMode] private static void OnEnterPlayMode() => InitRegistries();

		internal static void InitRegistries()
		{
			if (LunyRuntimeAssetRegistry.Singleton == null)
				LunyRuntimeAssetRegistry.Singleton = s_RuntimeRegistry = FindOrCreateRuntimeRegistry();

			RegisterAllLunyAssets();
		}

		private static LunyRuntimeAssetRegistry FindOrCreateRuntimeRegistry()
		{
			if (s_RuntimeRegistry != null)
				return s_RuntimeRegistry;

			var registryGuids = AssetDatabase.FindAssets($"t:{nameof(LunyRuntimeAssetRegistry)}");

			// we got multiple => delete all and create new one
			if (registryGuids.Length > 1)
			{
				TryDeleteAllRuntimeRegistries(registryGuids);
				return CreateRuntimeRegistry();
			}

			// we found none => create it
			if (registryGuids.Length == 0)
				return CreateRuntimeRegistry();

			// get the one that exists
			var assetPath = AssetDatabase.GUIDToAssetPath(registryGuids[0]);
			return AssetDatabase.LoadAssetAtPath<LunyRuntimeAssetRegistry>(assetPath);
		}

		private static LunyRuntimeAssetRegistry CreateRuntimeRegistry()
		{
			var registry = CreateInstance<LunyRuntimeAssetRegistry>();
			var path = $"Assets/{nameof(LunyRuntimeAssetRegistry)}.asset";
			AssetDatabase.CreateAsset(registry, path);
			return registry;
		}

		private static void TryDeleteAllRuntimeRegistries(String[] registryAssetGuids)
		{
			LunyRuntimeAssetRegistry.Singleton = null;

			foreach (var registryGuid in registryAssetGuids)
			{
				var path = AssetDatabase.GUIDToAssetPath(registryGuid);
				var loadedRegistry = AssetDatabase.LoadAssetAtPath<LunyRuntimeAssetRegistry>(path);
				if (loadedRegistry != null)
				{
					// delete extraneous registry assets, no matter how they came to be (they would all be the same)
					Debug.Log($"Deleting extraneous {nameof(LunyRuntimeAssetRegistry)}: {path}");
					AssetDatabase.DeleteAsset(path);
				}
			}
		}

		private static void RegisterAllLunyAssets()
		{
			GetOrFindDefaultLuaContexts(out var editorContext, out var runtimeContext);

			{
				var editorRegistry = LunyEditorAssetRegistry.instance;
				editorRegistry.DefaultContext = editorContext;
				FindAndRegisterAllLuaAssets(editorRegistry.LuaAssets, typeof(LunyEditorLuaAsset));
				editorRegistry.Save();
			}
			{
				var runtimeRegistry = LunyRuntimeAssetRegistry.Singleton;
				runtimeRegistry.DefaultContext = runtimeContext;
				FindAndRegisterAllLuaAssets(runtimeRegistry.LuaAssets, typeof(LunyLuaAsset));
				runtimeRegistry.Save();
			}
		}

		private static void FindAndRegisterAllLuaAssets(LuaAssetCollection luaAssets, Type assetType)
		{
			luaAssets.Clear();

			var luaAssetGuids = AssetDatabase.FindAssets($"t:{assetType.Name}");
			var luaAssetCount = luaAssetGuids.Length;
			for (var i = 0; i < luaAssetCount; i++)
			{
				var assetPath = AssetDatabase.GUIDToAssetPath(luaAssetGuids[i]);
				var luaAsset = AssetDatabase.LoadAssetAtPath(assetPath, assetType);
				if (luaAsset != null)
					luaAssets.Add((LunyLuaAssetBase)luaAsset, luaAsset.name, assetPath);
			}
		}

		private class LuaAssetModificationProcessor : AssetModificationProcessor
		{
			private static void OnWillCreateAsset(String assetPath)
			{
				if (IsLuaAsset(assetPath))
				{
					// need to delay since asset cannot be loaded within this callback
					EditorApplication.delayCall += () =>
					{
						var luaAsset = AssetDatabase.LoadAssetAtPath<LunyLuaAssetBase>(assetPath);
						if (luaAsset is LunyLuaAsset runtimeLuaAsset)
						{
							var runtimeRegistry = LunyRuntimeAssetRegistry.Singleton;
							if (runtimeRegistry == null)
								InitRegistries();
							else
							{
								runtimeRegistry.LuaAssets.Add(runtimeLuaAsset, luaAsset.name, assetPath);
								runtimeRegistry.Save();
							}
						}
						else if (luaAsset is LunyEditorLuaAsset editorLuaAsset)
							LunyEditorAssetRegistry.instance.LuaAssets.Add(editorLuaAsset, luaAsset.name, assetPath);
					};
				}
			}

			private static AssetDeleteResult OnWillDeleteAsset(String assetPath, RemoveAssetOptions options)
			{
				if (IsLuaAsset(assetPath))
				{
					var luaAsset = AssetDatabase.LoadAssetAtPath<LunyLuaAssetBase>(assetPath);
					if (luaAsset is LunyLuaAsset runtimeLuaAsset)
					{
						var runtimeRegistry = LunyRuntimeAssetRegistry.Singleton;
						if (runtimeRegistry == null)
							EditorApplication.delayCall += InitRegistries; // delay to ensure asset is already deleted
						else
							runtimeRegistry.LuaAssets.Remove(runtimeLuaAsset, luaAsset.name, assetPath);
					}
					else if (luaAsset is LunyEditorLuaAsset editorLuaAsset)
						LunyEditorAssetRegistry.instance.LuaAssets.Remove(editorLuaAsset, luaAsset.name, assetPath);
				}
				return AssetDeleteResult.DidNotDelete;
			}

			private static AssetMoveResult OnWillMoveAsset(String sourcePath, String destinationPath)
			{
				if (IsLuaAsset(sourcePath))
				{
					// asset instance still has the old name so use the name from path instead
					var newName = Path.GetFileNameWithoutExtension(destinationPath);
					var luaAsset = AssetDatabase.LoadAssetAtPath<LunyLuaAssetBase>(sourcePath);
					if (luaAsset is LunyLuaAsset runtimeLuaAsset)
					{
						var runtimeRegistry = LunyRuntimeAssetRegistry.Singleton;
						if (runtimeRegistry == null)
							EditorApplication.delayCall += InitRegistries; // delay to ensure asset was already moved
						else
						{
							runtimeRegistry.LuaAssets.Remove(runtimeLuaAsset, luaAsset.name, sourcePath);
							runtimeRegistry.LuaAssets.Add(runtimeLuaAsset, newName, destinationPath);
						}
					}
					else if (luaAsset is LunyEditorLuaAsset editorLuaAsset)
					{
						var editorRegistry = LunyEditorAssetRegistry.instance;
						editorRegistry.LuaAssets.Remove(editorLuaAsset, luaAsset.name, sourcePath);
						editorRegistry.LuaAssets.Add(editorLuaAsset, newName, destinationPath);
					}
				}
				return AssetMoveResult.DidNotMove;
			}

			private static Boolean IsLuaAsset(String assetPath) => Path.GetExtension(assetPath) == ".lua";
		}
	}
}
