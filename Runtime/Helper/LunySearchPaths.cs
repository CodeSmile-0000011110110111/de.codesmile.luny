// Copyright (C) 2021-2025 Steffen Itterheim
// Refer to included LICENSE file for terms and conditions.

using CodeSmile.Extensions.System;
using CodeSmile.Utility;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using UnityEditor;
using UnityEngine;

namespace CodeSmile.Luny
{
	public interface ILunySearchPaths
	{
		List<String> Paths { get; }
		String GetFullPathToFile(String relativePath);
		String GetRelativePathToFile(String fullPath);
	}

	public sealed class LunySearchPaths : ILunySearchPaths
	{
		private const String PersistentPlaceholder = "%persistentdatapath%";
		private const String StreamingPlaceholder = "%streamingassetspath%";
		private List<String> m_Paths;
		public List<String> Paths => m_Paths;

		private static void ThrowIfPathIsNull(String relativePath)
		{
#if DEBUG
			if (String.IsNullOrWhiteSpace(relativePath))
				throw new ArgumentException("path cannot be null or empty", nameof(relativePath));
#endif
		}

		private static void ThrowIfPathNotRooted(String relativePath)
		{
#if DEBUG
			if (Path.IsPathRooted(relativePath) || relativePath.StartsWith('.'))
				throw new FileNotFoundException($"Invalid path: '{relativePath}'");
#endif
		}


		public LunySearchPaths(LunyLuaContext luaContext)
		{
			m_Paths = new List<String>(luaContext.ScriptSearchPaths);
			var pathCount = m_Paths.Count;
			for (var i = 0; i < pathCount; ++i)
			{
				if (String.IsNullOrWhiteSpace(m_Paths[i]))
				{
					Debug.LogWarning($"{nameof(m_Paths)}[{i}] is null or empty, ignoring");
					continue;
				}

				if (luaContext.IsRuntimeContext() && Path.IsPathRooted(m_Paths[i]))
					throw new LunyException($"Rooted paths cannot be runtime search paths: {m_Paths[i]}");

				// paths must not start nor end with slash
				m_Paths[i] = m_Paths[i].ToForwardSlashes().Trim('/');

				var isPersistentPath = false;
				var lowerPath = m_Paths[i].ToLower();
				if (lowerPath.StartsWith(PersistentPlaceholder))
				{
					isPersistentPath = true;
					m_Paths[i] = Application.persistentDataPath + m_Paths[i]
						.Substring(PersistentPlaceholder.Length, m_Paths[i].Length - PersistentPlaceholder.Length);
				}
				else if (lowerPath.StartsWith(StreamingPlaceholder))
				{
					m_Paths[i] = Application.streamingAssetsPath + m_Paths[i]
						.Substring(StreamingPlaceholder.Length, m_Paths[i].Length - StreamingPlaceholder.Length);
				}

				Debug.Log(m_Paths[i]);

				// pre-create user path directory
				if (isPersistentPath)
					PathUtility.TryCreateDirectory(m_Paths[i]);
			}
		}

		public String GetFullPathToFile(String relativePath)
		{
			ThrowIfPathIsNull(relativePath);
			ThrowIfPathNotRooted(relativePath);

			var pathCount = m_Paths.Count;
			for (var i = pathCount - 1; i >= 0; --i)
			{
				var fullPath = PathUtility.GetFullPath(m_Paths[i], relativePath);
				if (File.Exists(fullPath))
					return fullPath;
			}

			return null;
		}

		public String GetRelativePathToFile(String fullPath)
		{
			if (String.IsNullOrWhiteSpace(fullPath))
				return null;

			fullPath = fullPath.ToForwardSlashes();
			var fullPathLowercase = fullPath.ToLower();

			var pathCount = m_Paths.Count;
			for (var i = pathCount - 1; i >= 0; --i)
			{
				var startIndex = fullPathLowercase.IndexOf(m_Paths[i].ToLower());
				var searchPathLength = m_Paths[i].Length;
				if (startIndex == 0 && fullPath.Length > searchPathLength)
					return fullPath.Substring(searchPathLength + 1, fullPath.Length - searchPathLength - 1);
			}

			return null;
		}
	}
}
