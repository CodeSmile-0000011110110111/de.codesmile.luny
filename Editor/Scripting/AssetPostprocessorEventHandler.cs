// Copyright (C) 2021-2025 Steffen Itterheim
// Refer to included LICENSE file for terms and conditions.

using Lua;
using Luny;
using System;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

namespace LunyEditor
{
	public sealed class AssetPostprocessorEventHandler : IDisposable
	{
		private LunyScriptEventHandler<AssetPostprocessorEvent> m_EventHandler;

		public static LunyScriptEventHandler TryCreate(LuaTable scriptContext)
		{
			var eventHandler = LunyScriptEventHandler.TryCreate<AssetPostprocessorEvent>(scriptContext);
			if (eventHandler != null)
			{
				// attach to handler so it won't get deallocated
				eventHandler.UserData = new AssetPostprocessorEventHandler(eventHandler);
			}
			return eventHandler;
		}

		private AssetPostprocessorEventHandler(LunyScriptEventHandler<AssetPostprocessorEvent> eventHandler)
		{
			Debug.Assert(eventHandler != null);

			m_EventHandler = eventHandler;
			AssetPostprocessorImpl.Instance.Subscribe(this);
		}

		public void Dispose()
		{
			AssetPostprocessorImpl.Instance.Unsubscribe(this);
			m_EventHandler.UserData = null;
			m_EventHandler = null;
		}

		public void OnPostprocessAllAssets(String[] importedPaths, String[] deletedPaths, String[] movedToPaths, String[] movedFromPaths)
		{
			var eventIndex = (Int32)AssetPostprocessorEvent.OnPostprocessAllAssets;
			if (m_EventHandler.HasCallback(eventIndex))
			{
				var imported = LuaTableExt.Create(importedPaths);
				var deleted = LuaTableExt.Create(deletedPaths);
				var movedTo = LuaTableExt.Create(movedToPaths);
				var movedFrom = LuaTableExt.Create(movedFromPaths);
				m_EventHandler.TrySend(LunyEditor.Singleton.Lua.State, eventIndex, imported, deleted, movedTo, movedFrom);
			}

			eventIndex = (Int32)AssetPostprocessorEvent.OnPostprocessImportedAssets;
			if (importedPaths.Length > 0 && m_EventHandler.HasCallback(eventIndex))
			{
				var imported = LuaTableExt.Create(importedPaths);
				m_EventHandler.TrySend(LunyEditor.Singleton.Lua.State, eventIndex, imported);
			}

			eventIndex = (Int32)AssetPostprocessorEvent.OnPostprocessDeletedAssets;
			if (deletedPaths.Length > 0 && m_EventHandler.HasCallback(eventIndex))
			{
				var deleted = LuaTableExt.Create(deletedPaths);
				m_EventHandler.TrySend(LunyEditor.Singleton.Lua.State, eventIndex, deleted);
			}

			eventIndex = (Int32)AssetPostprocessorEvent.OnPostprocessMovedAssets;
			if (movedToPaths.Length > 0 && m_EventHandler.HasCallback(eventIndex))
			{
				var movedTo = LuaTableExt.Create(movedToPaths);
				var movedFrom = LuaTableExt.Create(movedFromPaths);
				m_EventHandler.TrySend(LunyEditor.Singleton.Lua.State, eventIndex, movedTo, movedFrom);
			}
		}

		private sealed class AssetPostprocessorImpl : AssetPostprocessor
		{
			private static AssetPostprocessorImpl s_Instance;

			private static readonly List<AssetPostprocessorEventHandler> m_EventHandlers = new();
			internal static AssetPostprocessorImpl Instance => s_Instance ?? new AssetPostprocessorImpl();

			private static void OnPostprocessAllAssets(String[] imported, String[] deleted, String[] movedTo, String[] movedFrom)
			{
				foreach (var eventHandler in m_EventHandlers)
					eventHandler.OnPostprocessAllAssets(imported, deleted, movedTo, movedFrom);
			}

			public void Subscribe(AssetPostprocessorEventHandler eventHandler) => m_EventHandlers.Add(eventHandler);

			public void Unsubscribe(AssetPostprocessorEventHandler eventHandler) => m_EventHandlers.Remove(eventHandler);
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
