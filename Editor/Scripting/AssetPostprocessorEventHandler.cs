// Copyright (C) 2021-2025 Steffen Itterheim
// Refer to included LICENSE file for terms and conditions.

using Lua;
using Luny;
using System;
using System.Collections.Generic;
using UnityEditor;

namespace LunyEditor
{
	public sealed class LunyScriptAssetPostprocessorEventHandler : LunyScriptEventHandler<EditorAssetPostprocessorEvent>
	{
		private LunyScriptAssetPostprocessorEventHandler(LuaCallbackFunctions callbackFunctions)
			: base(callbackFunctions)
		{
		}

		public override void OnCreate()
		{
			if (HasCallbacks)
			{
				AssetPostprocessorEventDispatcher.Instance.Subscribe(this);
			}
		}


		public void OnPostprocessAllAssets(String[] importedPaths, String[] deletedPaths, String[] movedToPaths, String[] movedFromPaths)
		{
			var eventIndex = (int)EditorAssetPostprocessorEvent.OnPostprocessAllAssets;
			if (HasCallback(eventIndex))
			{
				// TODO: create tables from arrays

				var luaState = LunyEditor.Singleton.Lua.State;
				//TrySend(m_LuaState, eventIndex, importedPaths, deletedPaths, movedToPaths, movedFromPaths);
			}
		}
	}

	internal sealed class AssetPostprocessorEventDispatcher : AssetPostprocessor
	{
		private static AssetPostprocessorEventDispatcher s_Instance;
		internal static AssetPostprocessorEventDispatcher Instance => s_Instance ?? new AssetPostprocessorEventDispatcher();

		private static List<LunyScriptAssetPostprocessorEventHandler> m_EventHandlers = new();

		private static void OnPostprocessAllAssets(String[] importedPaths, String[] deletedPaths, String[] movedToPaths, String[] movedFromPaths)
		{
			foreach (var eventHandler in m_EventHandlers)
			{
				eventHandler.OnPostprocessAllAssets(importedPaths, deletedPaths, movedToPaths, movedFromPaths);
			}
		}

		public void Subscribe(LunyScriptAssetPostprocessorEventHandler eventHandler)
		{
			m_EventHandlers.Add(eventHandler);
		}
	}




	public enum EditorAssetPostprocessorEvent
	{
		OnAssignMaterialModel,
		OnPostprocessAllAssets,
		OnPostprocessAnimation,
		OnPostprocessAssetbundleNameChanged,
		OnPostprocessAudio,
		OnPostprocessCubemap,
		OnPostprocessGameObjectWithAnimatedUserProperties,
		OnPostprocessGameObjectWithUserProperties,
		OnPostprocessMaterial,
		OnPostprocessMeshHierarchy,
		OnPostprocessModel,
		OnPostprocessPrefab,
		OnPostprocessSpeedTree,
		OnPostprocessSprites,
		OnPostprocessTexture,
		OnPostprocessTexture2DArray,
		OnPostprocessTexture3D,
		OnPreprocessAnimation,
		OnPreprocessAsset,
		OnPreprocessAudio,
		OnPreprocessCameraDescription,
		OnPreprocessLightDescription,
		OnPreprocessMaterialDescription,
		OnPreprocessModel,
		OnPreprocessSpeedTree,
		OnPreprocessTexture,
	}
}
