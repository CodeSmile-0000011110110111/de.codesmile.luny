// Copyright (C) 2021-2025 Steffen Itterheim
// Refer to included LICENSE file for terms and conditions.

using CodeSmile.Luny;
using CodeSmile.Utility;
using Lua;
using System;
using System.IO;
using System.Threading.Tasks;
using UnityEditor;
using UnityEngine;

namespace CodeSmileEditor.Luny
{
	[FilePath("ProjectSettings/LunyEditorState.asset", FilePathAttribute.Location.ProjectFolder)]
	public sealed class LunyEditor : ScriptableSingleton<LunyEditor>
	{
		// TODO: consider having a serialized, persistent LuaTable that survives domain reload
		// TODO: how to interact with this editor? not needed? eg could use settings, context, etc

		// TODO: script state that survives session reload => project close and re-open
		private LuaTable m_PersistentState;
		// TODO: script state that survives domain reload but not project close
		private LuaTable m_SessionState;

		private LunyLua m_Lua;
		private LuaScriptCollection m_RunningScripts;

		private Boolean m_ShouldCallReset;
		private Boolean m_ShouldCallAwake;

		[InitializeOnLoadMethod]
		private static LunyEditor OnLoad() => instance; // auto-create the singleton

		// Runs when project is loaded AND the FilePath asset does not exist
		private void Reset()
		{
			m_ShouldCallReset = true;
			m_PersistentState = new LuaTable();
			Debug.Log("LunyEditor Reset");
		}

		// Runs every time the project is loaded
		private void Awake()
		{
			m_ShouldCallAwake = true;
			Debug.Log("LunyEditor Awake");
			var registry = LunyEditorAssetRegistry.Singleton;
			if (registry.EditorContext != null)
				CreateSessionState(registry.EditorContext);
		}

		// Runs after every domain reload (including project load)
		private void OnEnable()
		{
			EditorApplication.focusChanged += OnFocusChanged;

			var registry = LunyEditorAssetRegistry.Singleton;
			var settings = LunyProjectSettings.instance;

			Debug.Log("LunyEditor OnEnable");
			registry.OnEditorContextChanged += CreateSessionState;
			registry.EditorLuaAssets.OnAdd += OnAddLuaAsset;
			registry.EditorLuaAssets.OnRemove += OnRemoveLuaAsset;

			if (m_ShouldCallReset)
			{
				// TODO
			}
			if (m_ShouldCallAwake)
			{
				// TODO
			}

			m_ShouldCallReset = m_ShouldCallAwake = false;

			EditorApplication.delayCall += () => CreateSessionState(registry.EditorContext);
		}

		// Runs before every domain reload
		private void OnDisable() => Save(true);

		private void OnFocusChanged(Boolean hasFocus)
		{
			if (hasFocus)
			{
				Debug.LogWarning("For testing only - OnFocusChanged: CreateSession");
				CreateSessionState(LunyEditorAssetRegistry.Singleton.EditorContext);
			}
		}

		private async Task StartScript(LunyLuaAssetBase luaAsset)
		{
			var luaScript = new LuaScript(m_Lua, luaAsset);
			await luaScript.Run();
			m_RunningScripts.Add(luaScript);
		}

		private void StopScript(LunyLuaAssetBase luaAsset)
		{
			var index = m_RunningScripts.IndexOf(luaAsset);
			if (index >= 0)
			{
				var script = m_RunningScripts[index];
				m_RunningScripts.RemoveAt(index);
				script.Dispose();
			}
		}

		private async void CreateSessionState(LunyLuaContext editorContext)
		{
			m_Lua = new LunyLua(editorContext, new FileSystem(editorContext));
			m_SessionState = new LuaTable();
			m_RunningScripts = new LuaScriptCollection();

			foreach (var startupLuaAsset in LunyProjectSettings.instance.EditorStartupScripts)
				await StartScript(startupLuaAsset);
		}

		private async void OnAddLuaAsset(LunyLuaAssetBase luaAsset)
		{
			var settings = LunyProjectSettings.instance;
			if (settings.EditorStartupScripts.Contains(luaAsset as LunyEditorLuaAsset))
				await StartScript(luaAsset);
		}

		private void OnRemoveLuaAsset(LunyLuaAssetBase luaAsset)
		{
			var settings = LunyProjectSettings.instance;
			if (settings.EditorStartupScripts.Contains(luaAsset as LunyEditorLuaAsset))
				StopScript(luaAsset);
		}

		// Note: OnDestroy is never called, not even on project close according to editor.log
		//private void OnDestroy() => throw new LunyException("LunyEditor OnDestroy -- this will NEVER throw!");

		private sealed class FileSystem : ILunyLuaFileSystem
		{
			private readonly LunySearchPaths m_SearchPaths;
			private readonly Boolean m_IsSandbox;

			public FileSystem(LunyLuaContext luaContext)
			{
				m_SearchPaths = new LunySearchPaths(luaContext);
				m_IsSandbox = luaContext.IsSandbox;
			}

			public Boolean ReadText(String path, out String content)
			{
				content = String.Empty;

				// try read absolute paths directly
				if (Path.IsPathRooted(path))
				{
					if (!m_IsSandbox)
						content = FileUtility.TryReadAllText(path, true);
					return true;
				}

				// Try read relative paths by looking through search paths
				var fullOrAssetPath = m_SearchPaths.GetFullPathOrAssetPath(path);
				if (fullOrAssetPath == null)
					return true;

				// the asset should be in the registry
				var luaAsset = LunyEditorAssetRegistry.Singleton.GetLuaAsset(fullOrAssetPath);
				if (luaAsset != null)
				{
					content = luaAsset.text;
					return true;
				}

				// try read from file system instead (ie could be relative to project working directory)
				if (!m_IsSandbox)
					content = FileUtility.TryReadAllText(fullOrAssetPath, true);
				return true;
			}

			public Boolean ReadBytes(String path, out Byte[] bytes) => throw new NotImplementedException("ReadBytes");
		}
	}
}
