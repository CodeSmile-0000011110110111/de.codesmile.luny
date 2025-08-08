// Copyright (C) 2021-2025 Steffen Itterheim
// Refer to included LICENSE file for terms and conditions.

using Luny.Core;
using Luny.Core.System;
using System;
using System.Collections.Generic;
using System.IO;
using UnityEditor;
using UnityEngine;

namespace Luny
{
	public sealed class LuaSearchPaths
	{
		private const String PersistentPlaceholder = "%persistentdatapath%";
		private readonly List<SearchPathInfo> m_Paths;
		public List<SearchPathInfo> Paths => m_Paths;

		private static void ThrowIfPathIsNull(String relativePath)
		{
#if DEBUG
			if (String.IsNullOrWhiteSpace(relativePath))
				throw new ArgumentException("path cannot be null or empty", nameof(relativePath));
#endif
		}

		public LuaSearchPaths(LunyLuaContext luaContext, String[] searchPaths)
		{
			var pathCount = searchPaths.Length;
			m_Paths = new List<SearchPathInfo>(pathCount);

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
				var pathInfo = new SearchPathInfo();

				var lowerPath = path.ToLower();
				if (lowerPath.StartsWith(PersistentPlaceholder))
				{
					pathInfo.IsPersistentDataPath = true;
					pathInfo.FullPath = Application.persistentDataPath + path
						.Substring(PersistentPlaceholder.Length, path.Length - PersistentPlaceholder.Length);
					// pre-create user path directories
					PathUtil.TryCreateDirectory(pathInfo.FullPath);
				}
				else if (lowerPath.StartsWith("assets/") || lowerPath.Equals("assets"))
				{
					var streamingPath = lowerPath.StartsWith("assets/streamingassets");
					pathInfo.IsAssetPath = !streamingPath;
					pathInfo.IsStreamingAssetPath = streamingPath;
					pathInfo.AssetPath = path;
					if (streamingPath)
						pathInfo.FullPath = Application.streamingAssetsPath;
				}
				else
					throw new LunyException($"invalid search path: {path}");

				Paths.Add(pathInfo);
			}
		}

		public String GetFullPath(String relativePath)
		{
			ThrowIfPathIsNull(relativePath);

			if (relativePath.StartsWith("Assets/") || relativePath.StartsWith("Packages/"))
				return relativePath;

			var pathCount = m_Paths.Count;
			for (var i = 0; i < pathCount; ++i)
			{
				var searchPath = m_Paths[i].IsAssetPath ? m_Paths[i].AssetPath : m_Paths[i].FullPath;
				var joinedPaths = Path.Join(searchPath, relativePath);
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

		public struct SearchPathInfo
		{
			public String AssetPath;
			public String FullPath;
			public Boolean IsAssetPath;
			public Boolean IsStreamingAssetPath;
			public Boolean IsPersistentDataPath;
		}
	}
}
