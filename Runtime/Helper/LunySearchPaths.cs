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
	public interface ILunySearchPaths
	{
		List<String> Paths { get; }
		String GetFullPathToFile(String relativePath);
		String GetRelativePathToFile(String fullPath);
	}

	public sealed class LunySearchPaths : ILunySearchPaths
	{
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

		public LunySearchPaths(String[] searchPaths)
		{
			m_Paths = new List<String>(searchPaths);
			var pathCount = m_Paths.Count;
			for (var i = pathCount - 1; i >= 0; --i)
			{
				if (String.IsNullOrWhiteSpace(m_Paths[i]))
					throw new ArgumentException($"{nameof(m_Paths)}[{i}] is null or empty");

				// avoid creating an empty StreamingAssets folder - the user ought to create it manually
				if (m_Paths[i] != Application.streamingAssetsPath)
					PathUtility.TryCreateDirectory(m_Paths[i]);

				//LunyLog.Info($"Luny search path[{i}]: '{m_SearchPaths[i]}'");
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
