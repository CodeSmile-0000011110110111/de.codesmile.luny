// Copyright (C) 2021-2025 Steffen Itterheim
// Refer to included LICENSE file for terms and conditions.

using CodeSmile.Extensions.System;
using CodeSmile.Utility;
using System;
using System.Collections.Generic;
using System.IO;
using UnityEditor;
using UnityEngine;

namespace CodeSmile.Luny
{
	internal sealed class LunySearchPaths
	{
		private const String PersistentPlaceholder = "%persistentdatapath%";
		private const String StreamingPlaceholder = "%streamingassetspath%";
		private readonly List<PathInfo> m_Paths;

		private static void ThrowIfPathIsNull(String relativePath)
		{
#if DEBUG
			if (String.IsNullOrWhiteSpace(relativePath))
				throw new ArgumentException("path cannot be null or empty", nameof(relativePath));
#endif
		}

		public LunySearchPaths(LunyLuaContext luaContext)
		{
			var searchPaths = luaContext.ScriptSearchPaths;
			var pathCount = searchPaths.Length;
			m_Paths = new List<PathInfo>(pathCount);

			for (var i = 0; i < pathCount; ++i)
			{
				if (String.IsNullOrWhiteSpace(searchPaths[i]))
				{
					Debug.LogWarning($"search path #{i} is null or empty, ignoring");
					continue;
				}

				if (luaContext.IsRuntimeContext && Path.IsPathRooted(searchPaths[i]))
					throw new LunyException($"Rooted paths cannot be runtime search paths: {searchPaths[i]}");

				// paths must not start nor end with slash
				var path = searchPaths[i].ToForwardSlashes().Trim('/');
				var pathInfo = new PathInfo { RootPath = path };

				var lowerPath = path.ToLower();
				if (lowerPath.StartsWith(PersistentPlaceholder))
				{
					//pathInfo.IsPersistentDataPath = true;
					pathInfo.RootPath = Application.persistentDataPath + path
						.Substring(PersistentPlaceholder.Length, path.Length - PersistentPlaceholder.Length);
					// pre-create user path directories
					PathUtility.TryCreateDirectory(pathInfo.RootPath);
				}
				else if (lowerPath.StartsWith(StreamingPlaceholder))
				{
					//pathInfo.IsStreamingAssetPath = true;
					pathInfo.RootPath = Application.streamingAssetsPath + path
						.Substring(StreamingPlaceholder.Length, path.Length - StreamingPlaceholder.Length);
				}
				else if (lowerPath.StartsWith("assets/") || lowerPath.Equals("assets"))
					pathInfo.IsAssetPath = true;

				m_Paths.Add(pathInfo);
			}
		}

		public String GetFullPathOrAssetPath(String relativePath)
		{
			ThrowIfPathIsNull(relativePath);

			var pathCount = m_Paths.Count;
			for (var i = 0; i < pathCount; ++i)
			{
				var joinedPaths = Path.Join(m_Paths[i].RootPath, relativePath);
				if (m_Paths[i].IsAssetPath)
					return joinedPaths.ToForwardSlashes();

				var fullPath = Path.GetFullPath(joinedPaths);
				if (File.Exists(fullPath))
					return fullPath.ToForwardSlashes();
			}

			return null;
		}

		// public String GetRelativePathToFile(String fullPath)
		// {
		// 	if (String.IsNullOrWhiteSpace(fullPath))
		// 		return null;
		//
		// 	fullPath = fullPath.ToForwardSlashes();
		// 	var fullPathLowercase = fullPath.ToLower();
		//
		// 	var pathCount = m_Paths.Count;
		// 	for (var i = pathCount - 1; i >= 0; --i)
		// 	{
		// 		var startIndex = fullPathLowercase.IndexOf(m_Paths[i].Path.ToLower());
		// 		var searchPathLength = m_Paths[i].Path.Length;
		// 		if (startIndex == 0 && fullPath.Length > searchPathLength)
		// 			return fullPath.Substring(searchPathLength + 1, fullPath.Length - searchPathLength - 1);
		// 	}
		//
		// 	return null;
		// }

		public struct PathInfo
		{
			public String RootPath;
			public Boolean IsAssetPath;
			//public Boolean IsStreamingAssetPath;
			//public Boolean IsPersistentDataPath;
		}
	}
}
