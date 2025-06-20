// Copyright (C) 2021-2025 Steffen Itterheim
// Refer to included LICENSE file for terms and conditions.

using System;
using System.Collections.Generic;
using System.IO;
using UnityEditor;
using UnityEngine;
using Object = System.Object;

namespace CodeSmile.Luny
{
	internal sealed class LunyLuaFileWatcher
	{
		private Dictionary<String, FileSystemWatcher> m_Watchers = new();
		private Dictionary<String, LunyLuaScript> m_WatchedScripts = new();
		private List<LunyLuaScript> m_ChangedScripts = new();

		public LunyLuaFileWatcher(LunyLuaContext luaContext) => InstallFileWatchers(luaContext.SearchPaths);

		private void InstallFileWatchers(LunySearchPaths searchPaths)
		{
			// always monitor "Assets" in editor
			var isEditor = Application.isEditor;
			if (isEditor)
				TryCreateFileSystemWatcher(Application.dataPath);

			// TODO: maybe support watching package paths?

			foreach (var searchPath in searchPaths.Paths)
			{
				if (searchPath.IsAssetPath || isEditor && searchPath.IsStreamingAssetPath)
					continue; // at runtime assets won't change, and in editor we generally watch all "Assets/*"

				TryCreateFileSystemWatcher(searchPath.FullPath);
			}
		}

		private void TryCreateFileSystemWatcher(String fullPath)
		{
			if (String.IsNullOrEmpty(fullPath) || m_Watchers.ContainsKey(fullPath) || !Directory.Exists(fullPath))
				return;

			var fileWatcher = new FileSystemWatcher(fullPath, "*.lua");
			fileWatcher.Changed += OnFileChanged;
			fileWatcher.EnableRaisingEvents = true;
			fileWatcher.IncludeSubdirectories = true;
			fileWatcher.NotifyFilter = NotifyFilters.LastWrite;
			m_Watchers[fullPath] = fileWatcher;
		}

		public void WatchScript(LunyLuaScript script)
		{
			var scriptFullPath = script.FullPath;
			if (m_WatchedScripts.ContainsKey(scriptFullPath) == false)
				m_WatchedScripts.Add(scriptFullPath, script);
		}

		public void UnwatchScript(LunyLuaScript script) => m_WatchedScripts.Remove(script.FullPath);

		public void Dispose()
		{
			foreach (var kvp in m_Watchers)
			{
				kvp.Value.EnableRaisingEvents = false;
				kvp.Value.Changed -= OnFileChanged;
			}

			m_WatchedScripts = null;
			m_Watchers = null;
			m_ChangedScripts = null;
		}

		// CAUTION: This runs on a background thread!
		private void OnFileChanged(Object sender, FileSystemEventArgs e)
		{
			var fullPath = e.FullPath;
			if (!File.Exists(fullPath))
				return;

			fullPath = fullPath.ToForwardSlashes();
			if (m_WatchedScripts.TryGetValue(fullPath, out var script) && script != null)
				m_ChangedScripts.Add(script); // add to queue for processing on main thread

			LunyLogger.LogInfo($"File changed: {fullPath}, change queue count: {m_ChangedScripts.Count}");
		}

		public void NotifyChangedScripts()
		{
			if (m_ChangedScripts.Count == 0)
				return;

			foreach (var changedScript in m_ChangedScripts)
			{
				if (changedScript == null)
					continue;

				// in editor, changes to LuaAsset files also need to trigger Importer in case auto-refresh is disabled
				if (changedScript is LunyLuaAssetScript assetScript)
					EditorAssetUtility.Import(assetScript.LuaAsset);

				changedScript.OnScriptChangedInternal();
			}

			m_ChangedScripts.Clear();
		}
	}
}
