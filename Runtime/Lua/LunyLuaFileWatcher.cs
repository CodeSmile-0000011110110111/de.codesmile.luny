// Copyright (C) 2021-2025 Steffen Itterheim
// Refer to included LICENSE file for terms and conditions.

using System;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;
using UnityEditor;
using UnityEngine;
using Object = System.Object;

namespace CodeSmile.Luny
{
	internal sealed class LunyLuaFileWatcher
	{
		private LunySearchPaths m_SearchPaths;
		private Dictionary<String, FileSystemWatcher> m_Watchers = new();
		private Dictionary<String, LunyLuaScript> m_WatchedScripts = new();
		private List<LunyLuaScript> m_ChangedScripts = new();

		public LunyLuaFileWatcher(LunyLuaContext luaContext)
		{
			m_SearchPaths = luaContext.SearchPaths;
			InstallFileWatchers();
		}

		private void InstallFileWatchers()
		{
			m_Watchers.Clear();

			// always monitor "Assets" in editor
			if (Application.isEditor)
				CreateFileSystemWatcher(Application.dataPath);

			// TODO: maybe support watching package paths?

			foreach (var searchPath in m_SearchPaths.Paths)
			{
				if (searchPath.IsAssetPath)
					continue; // at runtime assets won't change, and in editor we generally watch all "Assets"

				if (String.IsNullOrEmpty(searchPath.FullPath) == false)
					CreateFileSystemWatcher(searchPath.FullPath);
			}
		}

		private void CreateFileSystemWatcher(String fullPath)
		{
			if (Directory.Exists(fullPath))
			{
				var fileWatcher = new FileSystemWatcher(fullPath, "*.lua");
				fileWatcher.NotifyFilter = NotifyFilters.LastWrite;
				fileWatcher.Changed += OnFileChanged;
				fileWatcher.IncludeSubdirectories = true;
				fileWatcher.EnableRaisingEvents = true;
				m_Watchers[fullPath] = fileWatcher;
			}
		}

		public void WatchScript(LunyLuaScript script)
		{
			var scriptFullPath = script.LuaAsset.FullPath;
			if (m_WatchedScripts.ContainsKey(scriptFullPath) == false)
				m_WatchedScripts.Add(scriptFullPath, script);
		}

		public void UnwatchScript(LunyLuaScript script)
		{
			var scriptFullPath = script.LuaAsset.FullPath;
			m_WatchedScripts.Remove(scriptFullPath);
		}

		public void Dispose()
		{
			foreach (var kvp in m_Watchers)
			{
				kvp.Value.EnableRaisingEvents = false;
				kvp.Value.Changed -= OnFileChanged;
			}

			m_SearchPaths = null;
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
		}

		public async Task Update()
		{
			if (m_ChangedScripts.Count > 0)
				await NotifyChangedScripts();
		}

		private async Task NotifyChangedScripts()
		{
			foreach (var changedScript in m_ChangedScripts)
			{
				if (changedScript != null)
				{
					// in editor, changes to LuaAsset files also need to trigger Importer in case auto-refresh is disabled
					EditorAssetUtility.Import(changedScript.LuaAsset);
					await changedScript.OnScriptChanged();
				}
			}

			m_ChangedScripts.Clear();
		}
	}
}
