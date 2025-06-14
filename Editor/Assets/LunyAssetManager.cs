﻿// Copyright (C) 2021-2025 Steffen Itterheim
// Refer to included LICENSE file for terms and conditions.

using CodeSmile.Luny;
using CodeSmileEditor.Core;
using System;
using System.Linq;
using UnityEditor;
using UnityEngine;

namespace CodeSmileEditor.Luny
{
	internal sealed class LunyAssetManager : ScriptableSingleton<LunyAssetManager>
	{
		private static LunyRuntimeAssetRegistry s_RuntimeRegistry;

		public static void GetOrFindDefaultLuaContexts(out LunyLuaContext editorContext, out LunyLuaContext runtimeContext,
			out LunyLuaContext moddingContext)
		{
			var settings = LunyProjectSettings.Singleton;
			editorContext = settings.EditorContext;
			runtimeContext = settings.RuntimeContext;
			moddingContext = settings.ModdingContext;
			if (editorContext != null && runtimeContext != null && moddingContext != null)
				return;

			Debug.Log("GetOrFindDefaultLuaContexts");

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

		internal static void InitRegistries()
		{
			if (LunyRuntimeAssetRegistry.Singleton == null)
				LunyRuntimeAssetRegistry.Singleton = s_RuntimeRegistry = FindOrCreateRuntimeRegistry();

			RegisterAllLunyAssets();
		}

		// delayCall prevents "Asset import worker (4)" warning spam when selecting the registry asset
		// this is likely due to modifying the AssetDatabase 'too early' (ie same issue as with static ctor)
		[InitializeOnLoadMethod] private static void OnLoad() => EditorApplication.delayCall += () => InitRegistries();

		// Ensure we're not starting playmode without a registry (in case user deleted registry and clicked play)
		[InitializeOnEnterPlayMode] private static void OnEnterPlayMode() => InitRegistries();

		private static LunyRuntimeAssetRegistry FindOrCreateRuntimeRegistry()
		{
			if (s_RuntimeRegistry != null)
				return s_RuntimeRegistry;

			var registryGuids = AssetDatabase.FindAssets($"t:{nameof(LunyRuntimeAssetRegistry)}");

			// we got multiple => delete all and create new one
			if (registryGuids.Length > 1)
			{
				LunyRuntimeAssetRegistry.Singleton = null;
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
			var settings = LunyProjectSettings.Singleton;
			var registry = CreateInstance<LunyRuntimeAssetRegistry>();
			foreach (var startupScript in settings.RuntimeStartupScripts)
			{
				if (startupScript != null)
					registry.RuntimeStartupLuaAssets.Add(startupScript, AssetDatabase.GetAssetPath(startupScript));
			}
			foreach (var startupScript in settings.ModdingStartupScripts)
			{
				if (startupScript != null)
					registry.ModdingStartupLuaAssets.Add(startupScript, AssetDatabase.GetAssetPath(startupScript));
			}

			var path = $"Assets/{nameof(LunyRuntimeAssetRegistry)}.asset";
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
					Debug.Log($"Deleting extraneous {nameof(LunyRuntimeAssetRegistry)}: {path}");
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
			luaAssets.ClearMissingAssets();

			var luaAssetGuids = AssetDatabase.FindAssets($"t:{assetType.Name}");
			var luaAssetCount = luaAssetGuids.Length;
			for (var i = 0; i < luaAssetCount; i++)
			{
				var assetPath = AssetDatabase.GUIDToAssetPath(luaAssetGuids[i]);
				var luaAsset = AssetDatabase.LoadAssetAtPath(assetPath, assetType);
				if (luaAsset != null)
					luaAssets.Add((LunyLuaAsset)luaAsset, assetPath);
			}
		}

		private class LuaAssetModificationProcessor : AssetModificationProcessor
		{
			private static void OnWillCreateAsset(String assetPath)
			{
				if (AssetUtility.IsLuaScript(assetPath))
				{
					// NOTE: creating startup scripts is handled by LunyAssetMenuItems

					// delay because asset is not yet created and thus could not be loaded
					EditorApplication.delayCall += () =>
					{
						var luaAsset = AssetDatabase.LoadAssetAtPath<LunyLuaAsset>(assetPath);
						var isRuntimeLuaAsset = luaAsset is LunyRuntimeLuaAsset;
						var isMmoddingLuaAsset = luaAsset is LunyModdingLuaAsset;
						if (isRuntimeLuaAsset || isMmoddingLuaAsset)
						{
							var runtimeRegistry = LunyRuntimeAssetRegistry.Singleton;
							if (runtimeRegistry == null)
								InitRegistries(); // no delay here because entire block is already delayed
							else
							{
								var luaAssets = GetLuaAssets(isRuntimeLuaAsset, runtimeRegistry);
								luaAssets.Add(luaAsset, assetPath);
								runtimeRegistry.Save();
							}
						}
						else if (luaAsset is LunyEditorLuaAsset editorLuaAsset)
						{
							var editorRegistry = LunyEditorAssetRegistry.Singleton;
							editorRegistry.EditorLuaAssets.Add(editorLuaAsset, assetPath);
							editorRegistry.Save();
						}
					};
				}
			}

			private static AssetDeleteResult OnWillDeleteAsset(String assetPath, RemoveAssetOptions options)
			{
				if (AssetUtility.IsLuaScript(assetPath))
				{
					var settings = LunyProjectSettings.Singleton;
					var luaAsset = AssetDatabase.LoadAssetAtPath<LunyLuaAsset>(assetPath);
					var isRuntimeLuaAsset = luaAsset is LunyRuntimeLuaAsset;
					var isMmoddingLuaAsset = luaAsset is LunyModdingLuaAsset;
					if (isRuntimeLuaAsset || isMmoddingLuaAsset)
					{
						var runtimeRegistry = LunyRuntimeAssetRegistry.Singleton;
						if (runtimeRegistry == null)
							EditorApplication.delayCall += InitRegistries; // delay to ensure asset is already deleted
						else
						{
							var luaAssets = GetStartupLuaAssets(isRuntimeLuaAsset, runtimeRegistry);
							luaAssets.Remove(luaAsset);

							luaAssets = GetLuaAssets(isRuntimeLuaAsset, runtimeRegistry);
							luaAssets.Remove(luaAsset);
							runtimeRegistry.Save();

							if (isRuntimeLuaAsset)
								settings.RuntimeStartupScripts.Remove((LunyRuntimeLuaAsset)luaAsset);
							else
								settings.ModdingStartupScripts.Remove((LunyModdingLuaAsset)luaAsset);
						}
					}
					else if (luaAsset is LunyEditorLuaAsset editorLuaAsset)
					{
						var editorRegistry = LunyEditorAssetRegistry.Singleton;
						editorRegistry.EditorLuaAssets.Remove(editorLuaAsset);
						editorRegistry.Save();

						settings.EditorStartupScripts.Remove(editorLuaAsset);
					}
				}
				return AssetDeleteResult.DidNotDelete;
			}

			private static AssetMoveResult OnWillMoveAsset(String sourcePath, String destinationPath)
			{
				if (AssetUtility.IsLuaScript(sourcePath))
				{
					// asset instance still has the old name so use the name from path instead
					var luaAsset = AssetDatabase.LoadAssetAtPath<LunyLuaAsset>(sourcePath);
					var isRuntimeLuaAsset = luaAsset is LunyRuntimeLuaAsset;
					var isMmoddingLuaAsset = luaAsset is LunyModdingLuaAsset;
					if (isRuntimeLuaAsset || isMmoddingLuaAsset)
					{
						var runtimeRegistry = LunyRuntimeAssetRegistry.Singleton;
						if (runtimeRegistry == null)
							EditorApplication.delayCall += InitRegistries; // delay to ensure asset is already moved/renamed
						else
						{
							luaAsset.Path = destinationPath;
							EditorUtility.SetDirty(luaAsset);

							var luaAssets = GetStartupLuaAssets(isRuntimeLuaAsset, runtimeRegistry);
							if (luaAssets.Remove(luaAsset))
								luaAssets.Add(luaAsset, destinationPath);

							luaAssets = GetLuaAssets(isRuntimeLuaAsset, runtimeRegistry);
							if (luaAssets.Remove(luaAsset))
								luaAssets.Add(luaAsset, destinationPath);

							runtimeRegistry.Save();
						}
					}
					else if (luaAsset is LunyEditorLuaAsset editorLuaAsset)
					{
						var editorRegistry = LunyEditorAssetRegistry.Singleton;
						if (editorRegistry.EditorLuaAssets.Remove(editorLuaAsset))
							editorRegistry.EditorLuaAssets.Add(editorLuaAsset, destinationPath);
						editorRegistry.Save();
					}
				}
				return AssetMoveResult.DidNotMove;
			}

			private static LuaAssetCollection GetStartupLuaAssets(Boolean isRuntime, LunyRuntimeAssetRegistry registry) =>
				isRuntime ? registry.RuntimeStartupLuaAssets : registry.ModdingStartupLuaAssets;

			private static LuaAssetCollection GetLuaAssets(Boolean isRuntime, LunyRuntimeAssetRegistry registry) =>
				isRuntime ? registry.RuntimeLuaAssets : registry.ModdingLuaAssets;
		}
	}
}
