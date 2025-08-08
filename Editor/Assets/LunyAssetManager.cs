// Copyright (C) 2021-2025 Steffen Itterheim
// Refer to included LICENSE file for terms and conditions.

using Luny;
using LunyEditor.Core;
using LunyEditor.Settings;
using System;
using System.Linq;
using UnityEditor;
using UnityEngine;

namespace LunyEditor.Assets
{
	internal sealed class LunyAssetManager : ScriptableSingleton<LunyAssetManager>
	{
		public static void GetOrFindDefaultLuaContexts(out LunyLuaContext editorContext, out LunyLuaContext runtimeContext,
			out LunyLuaContext moddingContext)
		{
			var settings = LunyProjectSettings.Singleton;
			editorContext = settings.EditorContext;
			runtimeContext = settings.RuntimeContext;
			moddingContext = settings.ModdingContext;
			if (editorContext != null && runtimeContext != null && moddingContext != null)
				return;

			var filter = $"t:{nameof(LunyLuaContext)} l:{LunyAssetLabel.DefaultLuaContext}";
			var contextGuids = AssetDatabase.FindAssets(filter, new[] { "Packages/de.codesmile.luny" });

			// fallback, in case package was localized or modified try finding defaults in /Assets
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
						settings.EditorContext = editorContext = context;
					if (runtimeContext == null && labels.Contains(LunyAssetLabel.RuntimeLuaContext))
						settings.RuntimeContext = runtimeContext = context;
					if (moddingContext == null && labels.Contains(LunyAssetLabel.ModdingLuaContext))
						settings.ModdingContext = moddingContext = context;
				}
			}

			settings.Save();
		}

		internal static void InitRuntimeRegistry()
		{
			var registryGuids = AssetDatabase.FindAssets($"t:{nameof(LunyRuntimeAssetRegistry)}");
			if (registryGuids.Length == 0 || registryGuids.Length > 1 || LunyRuntimeAssetRegistry.LoadFromResources() == null)
				LunyRuntimeAssetRegistry.Singleton = FindOrCreateRuntimeRegistry(registryGuids);

			RegisterAllLunyAssets();
		}

		// delayCall prevents "Asset import worker (4)" warning spam when selecting the registry asset
		// this is likely due to modifying the AssetDatabase 'too early' (ie same issue as with static ctor)
		[InitializeOnLoadMethod] private static void OnLoad() => EditorApplication.delayCall += () => InitRuntimeRegistry();

		// Ensure we're not starting playmode without a registry (in case user deleted registry and clicked play)
		[InitializeOnEnterPlayMode] private static void OnEnterPlayMode() => InitRuntimeRegistry();

		private static LunyRuntimeAssetRegistry FindOrCreateRuntimeRegistry(String[] registryGuids)
		{
			// we found none => create it
			if (registryGuids.Length == 0)
				return CreateRuntimeRegistry();

			// we got multiple => delete all and create new one
			var notInResources = LunyRuntimeAssetRegistry.LoadFromResources() == null;
			if (registryGuids.Length > 1 || notInResources)
			{
				LunyRuntimeAssetRegistry.Singleton = null;
				TryDeleteAllRuntimeRegistries(registryGuids);
				return CreateRuntimeRegistry();
			}

			return LunyRuntimeAssetRegistry.LoadFromResources();
		}

		private static LunyRuntimeAssetRegistry CreateRuntimeRegistry()
		{
			var settings = LunyProjectSettings.Singleton;
			var registry = CreateInstance<LunyRuntimeAssetRegistry>();
			foreach (var autorunScript in settings.RuntimeAutoRunLuaAssets)
			{
				if (autorunScript != null)
					registry.RuntimeAutoRunLuaAssets.AddOrUpdate(autorunScript, AssetDatabase.GetAssetPath(autorunScript));
			}
			foreach (var autorunScript in settings.ModdingAutoRunLuaAssets)
			{
				if (autorunScript != null)
					registry.ModdingAutoRunLuaAssets.AddOrUpdate(autorunScript, AssetDatabase.GetAssetPath(autorunScript));
			}

			var pathRoot = "Assets/Luny/Resources";
			EditorAssetUtil.TryCreateAndImportPath(pathRoot);
			var path = $"{pathRoot}/{nameof(LunyRuntimeAssetRegistry)}.asset";
			AssetDatabase.CreateAsset(registry, path);
			return registry;
		}

		private static void TryDeleteAllRuntimeRegistries(String[] registryAssetGuids)
		{
			foreach (var registryGuid in registryAssetGuids)
			{
				var path = AssetDatabase.GUIDToAssetPath(registryGuid);
				var loadedRegistry = AssetDatabase.LoadAssetAtPath<LunyRuntimeAssetRegistry>(path);
				if (loadedRegistry != null)
				{
					// delete extraneous registry assets, no matter how they came to be (they would all be the same)
					//Debug.Log($"Deleting extraneous {nameof(LunyRuntimeAssetRegistry)}: {path}");
					AssetDatabase.DeleteAsset(path);
				}
			}
		}

		private static void RegisterAllLunyAssets()
		{
			GetOrFindDefaultLuaContexts(out var editorContext, out var runtimeContext, out var moddingContext);

			{
				var editorRegistry = LunyEditorAssetRegistry.Singleton;
				editorRegistry.EditorContext = editorContext;
				FindAndRegisterAllLuaAssets(editorRegistry.EditorLuaAssets, typeof(LunyEditorLuaAsset));
				editorRegistry.Save();
			}
			{
				var runtimeRegistry = LunyRuntimeAssetRegistry.Singleton;
				runtimeRegistry.RuntimeContext = runtimeContext;
				runtimeRegistry.ModdingContext = moddingContext;
				FindAndRegisterAllLuaAssets(runtimeRegistry.RuntimeLuaAssets, typeof(LunyRuntimeLuaAsset));
				FindAndRegisterAllLuaAssets(runtimeRegistry.ModdingLuaAssets, typeof(LunyModdingLuaAsset));
				runtimeRegistry.Save();
			}
		}

		private static void FindAndRegisterAllLuaAssets(LuaAssetCollection luaAssets, Type assetType)
		{
			luaAssets.RemoveNullReferences();

			var luaAssetGuids = AssetDatabase.FindAssets($"t:{assetType.Name}");
			var luaAssetCount = luaAssetGuids.Length;
			for (var i = 0; i < luaAssetCount; i++)
			{
				var assetPath = AssetDatabase.GUIDToAssetPath(luaAssetGuids[i]);
				var luaAsset = AssetDatabase.LoadAssetAtPath(assetPath, assetType);
				if (luaAsset != null)
					luaAssets.AddOrUpdate((LunyLuaAsset)luaAsset, assetPath);
			}
		}

		private class LuaAssetModificationProcessor : AssetModificationProcessor
		{
			private static void OnWillCreateAsset(String assetPath)
			{
				if (EditorAssetUtil.IsLuaScript(assetPath))
				{
					// NOTE: creating auto-run scripts is handled by LunyAssetMenuItems

					// delay because asset is not yet created and thus could not be loaded
					EditorApplication.delayCall += () =>
					{
						var luaAsset = AssetDatabase.LoadAssetAtPath<LunyLuaAsset>(assetPath);
						var isRuntimeLuaAsset = luaAsset is LunyRuntimeLuaAsset;
						var isMmoddingLuaAsset = luaAsset is LunyModdingLuaAsset;
						if (isRuntimeLuaAsset)
						{
							var runtimeRegistry = LunyRuntimeAssetRegistry.Singleton;
							if (runtimeRegistry == null)
								InitRuntimeRegistry(); // no delay here because entire block is already delayed
							else
							{
								var luaAssets = GetLuaAssets(isMmoddingLuaAsset, runtimeRegistry);
								luaAssets.AddOrUpdate(luaAsset, assetPath);
								runtimeRegistry.Save();
							}
						}
						else if (luaAsset is LunyEditorLuaAsset editorLuaAsset)
						{
							var editorRegistry = LunyEditorAssetRegistry.Singleton;
							editorRegistry.EditorLuaAssets.AddOrUpdate(editorLuaAsset, assetPath);
							editorRegistry.Save();
						}
					};
				}
			}

			private static AssetDeleteResult OnWillDeleteAsset(String assetPath, RemoveAssetOptions options)
			{
				if (EditorAssetUtil.IsLuaScript(assetPath))
				{
					var settings = LunyProjectSettings.Singleton;
					var luaAsset = AssetDatabase.LoadAssetAtPath<LunyLuaAsset>(assetPath);
					var isRuntimeLuaAsset = luaAsset is LunyRuntimeLuaAsset;
					var isModdingLuaAsset = luaAsset is LunyModdingLuaAsset;
					if (isRuntimeLuaAsset)
					{
						var runtimeRegistry = LunyRuntimeAssetRegistry.Singleton;
						if (runtimeRegistry == null)
							EditorApplication.delayCall += InitRuntimeRegistry; // delay to ensure asset is already deleted
						else
						{
							var luaAssets = GetLuaAssets(isModdingLuaAsset, runtimeRegistry);
							if (luaAssets.Remove(luaAsset))
							{
								GetAutoRunLuaAssets(isModdingLuaAsset, runtimeRegistry).Remove(luaAsset);
								runtimeRegistry.Save();
							}
						}
					}
					else if (luaAsset is LunyEditorLuaAsset editorLuaAsset)
					{
						var editorRegistry = LunyEditorAssetRegistry.Singleton;
						if (editorRegistry.EditorLuaAssets.Remove(editorLuaAsset))
							settings.EditorAutoRunLuaAssets.Remove(editorLuaAsset);
						editorRegistry.Save();
					}
				}
				return AssetDeleteResult.DidNotDelete;
			}

			private static AssetMoveResult OnWillMoveAsset(String sourcePath, String destinationPath)
			{
				// delay to ensure asset is already moved/renamed
				EditorApplication.delayCall += () =>
				{
					// moving does not cause a re-import, thus import manually to update the asset's path and type
					AssetDatabase.ImportAsset(destinationPath);

					if (EditorAssetUtil.IsFolder(destinationPath))
					{
						var runtimeRegistry = LunyRuntimeAssetRegistry.Singleton;
						if (runtimeRegistry == null)
							InitRuntimeRegistry();
						else
							RegisterAllLunyAssets(); // full update, moved folder hierarchy may contain Lua scripts
					}
					else if (EditorAssetUtil.IsLuaScript(destinationPath))
					{
						var luaAsset = AssetDatabase.LoadAssetAtPath<LunyLuaAsset>(destinationPath);
						var isRuntimeLuaAsset = luaAsset is LunyRuntimeLuaAsset;
						var isModdingLuaAsset = luaAsset is LunyModdingLuaAsset;
						if (isRuntimeLuaAsset)
						{
							var runtimeRegistry = LunyRuntimeAssetRegistry.Singleton;
							if (runtimeRegistry == null)
								InitRuntimeRegistry();
							else
							{
								var luaAssets = GetLuaAssets(isModdingLuaAsset, runtimeRegistry);
								if (luaAssets.Remove(luaAsset))
								{
									luaAssets.AddOrUpdate(luaAsset, destinationPath);

									var autorunLuaAssets = GetAutoRunLuaAssets(isModdingLuaAsset, runtimeRegistry);
									if (autorunLuaAssets.Remove(luaAsset))
										autorunLuaAssets.AddOrUpdate(luaAsset, destinationPath);

									runtimeRegistry.Save();
								}
							}
						}
						else if (luaAsset is LunyEditorLuaAsset editorLuaAsset)
						{
							var editorRegistry = LunyEditorAssetRegistry.Singleton;
							if (editorRegistry.EditorLuaAssets.Remove(editorLuaAsset))
								editorRegistry.EditorLuaAssets.AddOrUpdate(editorLuaAsset, destinationPath);
							editorRegistry.Save();
						}
					}
				};
				return AssetMoveResult.DidNotMove;
			}

			private static LuaAssetCollection GetAutoRunLuaAssets(Boolean isModdingLua, LunyRuntimeAssetRegistry registry) =>
				isModdingLua ? registry.ModdingAutoRunLuaAssets : registry.RuntimeAutoRunLuaAssets;

			private static LuaAssetCollection GetLuaAssets(Boolean isModdingLua, LunyRuntimeAssetRegistry registry) =>
				isModdingLua ? registry.ModdingLuaAssets : registry.RuntimeLuaAssets;
		}
	}
}
