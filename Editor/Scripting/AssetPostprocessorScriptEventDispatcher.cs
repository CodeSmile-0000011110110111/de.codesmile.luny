// Copyright (C) 2021-2025 Steffen Itterheim
// Refer to included LICENSE file for terms and conditions.

using Luny;
using System;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

namespace LunyEditor
{
	public sealed class AssetPostprocessorScriptEventDispatcher : IDisposable
	{
		private LunyScriptEventHandler<AssetPostprocessorEvent> m_ScriptEventHandler;

		internal AssetPostprocessorScriptEventDispatcher(LunyScriptEventHandler<AssetPostprocessorEvent> scriptEventHandler)
		{
			Debug.Assert(scriptEventHandler != null);

			m_ScriptEventHandler = scriptEventHandler;
			AssetPostprocessorImpl.Instance.Subscribe(this);
		}

		public void Dispose()
		{
			AssetPostprocessorImpl.Instance.Unsubscribe(this);
			m_ScriptEventHandler.EventDispatcher = null;
			m_ScriptEventHandler = null;
		}

		public void OnPostprocessAllAssets(String[] importedPaths, String[] deletedPaths, String[] movedToPaths, String[] movedFromPaths)
		{
			TrySendOnPostprocessAllAssets(importedPaths, deletedPaths, movedToPaths, movedFromPaths);
			if (importedPaths.Length > 0)
				TrySendOnPostprocessImportedAssets(importedPaths);
			if (deletedPaths.Length > 0)
				TrySendOnPostprocessDeletedAssets(deletedPaths);
			if (movedToPaths.Length > 0)
				TrySendOnPostprocessMovedAssets(movedToPaths, movedFromPaths);
		}

		private void TrySendOnPostprocessAllAssets(String[] importedPaths, String[] deletedPaths, String[] movedToPaths,
			String[] movedFromPaths)
		{
			var eventIndex = (Int32)AssetPostprocessorEvent.OnPostprocessAllAssets;
			if (m_ScriptEventHandler.HasCallback(eventIndex))
			{
				var imported = LuaTableExt.Create(importedPaths);
				var deleted = LuaTableExt.Create(deletedPaths);
				var movedTo = LuaTableExt.Create(movedToPaths);
				var movedFrom = LuaTableExt.Create(movedFromPaths);
				m_ScriptEventHandler.TrySend(LunyEditor.Singleton.Lua.State, eventIndex, imported, deleted, movedTo, movedFrom);
			}
		}

		private void TrySendOnPostprocessImportedAssets(String[] importedPaths)
		{
			var eventIndex = (Int32)AssetPostprocessorEvent.OnPostprocessImportedAssets;
			if (m_ScriptEventHandler.HasCallback(eventIndex))
			{
				var imported = LuaTableExt.Create(importedPaths);
				m_ScriptEventHandler.TrySend(LunyEditor.Singleton.Lua.State, eventIndex, imported);
			}
		}

		private void TrySendOnPostprocessDeletedAssets(String[] deletedPaths)
		{
			var eventIndex = (Int32)AssetPostprocessorEvent.OnPostprocessDeletedAssets;
			if (m_ScriptEventHandler.HasCallback(eventIndex))
			{
				var deleted = LuaTableExt.Create(deletedPaths);
				m_ScriptEventHandler.TrySend(LunyEditor.Singleton.Lua.State, eventIndex, deleted);
			}
		}

		private void TrySendOnPostprocessMovedAssets(String[] movedToPaths, String[] movedFromPaths)
		{
			var eventIndex = (Int32)AssetPostprocessorEvent.OnPostprocessMovedAssets;
			if (m_ScriptEventHandler.HasCallback(eventIndex))
			{
				var movedTo = LuaTableExt.Create(movedToPaths);
				var movedFrom = LuaTableExt.Create(movedFromPaths);
				m_ScriptEventHandler.TrySend(LunyEditor.Singleton.Lua.State, eventIndex, movedTo, movedFrom);
			}
		}

		private sealed class AssetPostprocessorImpl : AssetPostprocessor
		{
			private static AssetPostprocessorImpl s_Instance;

			private static readonly List<AssetPostprocessorScriptEventDispatcher> m_EventHandlers = new();
			internal static AssetPostprocessorImpl Instance => s_Instance ?? new AssetPostprocessorImpl();

			private static void OnPostprocessAllAssets(String[] imported, String[] deleted, String[] movedTo, String[] movedFrom)
			{
				foreach (var eventHandler in m_EventHandlers)
					eventHandler.OnPostprocessAllAssets(imported, deleted, movedTo, movedFrom);
			}

			public void Subscribe(AssetPostprocessorScriptEventDispatcher eventDispatcher) => m_EventHandlers.Add(eventDispatcher);

			public void Unsubscribe(AssetPostprocessorScriptEventDispatcher eventDispatcher) => m_EventHandlers.Remove(eventDispatcher);
		}
	}

	public enum AssetPostprocessorEvent
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

		// specials
		OnPostprocessImportedAssets,
		OnPostprocessDeletedAssets,
		OnPostprocessMovedAssets,
	}
}
