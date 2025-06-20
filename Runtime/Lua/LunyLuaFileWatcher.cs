// Copyright (C) 2021-2025 Steffen Itterheim
// Refer to included LICENSE file for terms and conditions.

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using UnityEditor;
using UnityEngine;
using Object = System.Object;

namespace CodeSmile.Luny
{
	internal sealed class LunyLuaFileWatcher
	{
		private readonly List<String> m_WatchedPaths = new();
		private Dictionary<String, LunyLuaScript> m_WatchedScripts = new();

		public LunyLuaFileWatcher(LunyLuaContext luaContext) => InstallFileWatchers(luaContext.SearchPaths);

		private void InstallFileWatchers(LunySearchPaths searchPaths)
		{
			// always monitor "Assets" in editor
			var isEditor = Application.isEditor;
			if (isEditor)
				AddFileChangedCallback(Application.dataPath);

			// TODO: maybe support watching package paths?

			foreach (var searchPath in searchPaths.Paths)
			{
				// at runtime assets won't change
				if (searchPath.IsAssetPath)
					continue;

				AddFileChangedCallback(searchPath.FullPath);
			}
		}

		private void AddFileChangedCallback(String fullPath)
		{
			if (String.IsNullOrEmpty(fullPath) || Directory.Exists(fullPath) == false)
				return;

			m_WatchedPaths.Add(fullPath);
			LuaFileWatchers.AddWatcher(fullPath);
		}

		public void WatchScript(LunyLuaScript script)
		{
			var scriptFullPath = script.FullPath;
			if (m_WatchedScripts.ContainsKey(scriptFullPath) == false)
				m_WatchedScripts.Add(scriptFullPath, script);
		}

		public void UnwatchScript(LunyLuaScript script)
		{
			m_WatchedScripts.Remove(script.FullPath);
			LuaFileWatchers.RemoveChangedFile(script.FullPath); // avoid even the rare chance ...
		}

		public void Dispose()
		{
			foreach (var path in m_WatchedPaths)
				LuaFileWatchers.RemoveWatcher(path);

			m_WatchedScripts = null;
		}

		public void NotifyChangedScripts()
		{
			var changedFiles = LuaFileWatchers.ChangedFiles;
			if (changedFiles == null)
				return;

			foreach (var path in changedFiles)
			{
				if (m_WatchedScripts.TryGetValue(path, out var changedScript))
				{
					LuaFileWatchers.RemoveChangedFile(path);

					// in editor, changes to LuaAsset files also need to trigger Importer in case auto-refresh is disabled
					if (changedScript is LunyLuaAssetScript assetScript)
						EditorAssetUtility.Import(assetScript.LuaAsset);

					changedScript.OnScriptChangedInternal();
				}
			}
		}

		private static class LuaFileWatchers
		{
			private static readonly Dictionary<String, RefCountWatcher> s_Watchers = new();
			private static readonly HashSet<String> s_ChangedFiles = new();
			public static String[] ChangedFiles => s_ChangedFiles.Count > 0 ? s_ChangedFiles.ToArray() : null;

			public static void RemoveChangedFile(String fullPath) => s_ChangedFiles.Remove(fullPath);

			public static void AddWatcher(String fullPath)
			{
				if (String.IsNullOrEmpty(fullPath))
					throw new ArgumentNullException(nameof(fullPath));

				var watcher = FindMatchingWatcher(fullPath);
				if (watcher != null)
				{
					watcher.UsageCount++;
					// LunyLogger.LogInfo($"Using existing ({watcher.UsageCount}) LuaFileWatcher: " +
					//                    $"{watcher.Watcher.Path} (requested path: {fullPath})");
					return;
				}

				CreateWatcher(fullPath);
				// LunyLogger.LogInfo($"Created LuaFileWatcher: {fullPath}");
			}

			public static void RemoveWatcher(String fullPath)
			{
				if (String.IsNullOrEmpty(fullPath))
					throw new ArgumentNullException(nameof(fullPath));

				var watcher = FindMatchingWatcher(fullPath);
				if (watcher != null)
				{
					watcher.UsageCount--;
					if (watcher.UsageCount <= 0)
					{
						watcher.Watcher.Changed -= OnFileChanged;
						watcher.Watcher.Dispose();
						s_Watchers.Remove(fullPath);
						// LunyLogger.LogInfo($"Removed LuaFileWatcher: {watcher.Watcher.Path} (requested path: {fullPath})");
					}
				}
			}

			private static RefCountWatcher FindMatchingWatcher(String fullPath)
			{
				if (s_Watchers.TryGetValue(fullPath, out var watcher) == false)
				{
					// check for partial matches, ie path already covered by a parent paths' watcher
					foreach (var pair in s_Watchers)
					{
						if (fullPath.StartsWith(pair.Key))
							watcher = pair.Value;
					}
				}
				return watcher;
			}

			private static void CreateWatcher(String fullPath)
			{
				var fileWatcher = new FileSystemWatcher(fullPath, "*.lua");
				fileWatcher.EnableRaisingEvents = true;
				fileWatcher.IncludeSubdirectories = true;
				fileWatcher.NotifyFilter = NotifyFilters.LastWrite;
				fileWatcher.Changed += OnFileChanged;
				var watcher = new RefCountWatcher { Watcher = fileWatcher, UsageCount = 1 };
				s_Watchers[fullPath] = watcher;
			}

			private static void OnFileChanged(Object sender, FileSystemEventArgs e)
			{
				// CAUTION: This runs on a background thread!

				var fullPath = e.FullPath;
				if (!File.Exists(fullPath))
					return;

				fullPath = fullPath.ToForwardSlashes();
				s_ChangedFiles.Add(fullPath);

				// LunyLogger.LogInfo($"File changed: {fullPath} ({(sender as FileSystemWatcher)?.Path.ToForwardSlashes()}), " +
				//                    $"change queue count: {s_ChangedFiles.Count}");
			}

			private class RefCountWatcher
			{
				public FileSystemWatcher Watcher;
				public Int32 UsageCount;
			}
		}
	}
}
