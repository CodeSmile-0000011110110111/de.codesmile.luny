// Copyright (C) 2021-2025 Steffen Itterheim
// Refer to included LICENSE file for terms and conditions.

using Luny.Core.System;
using System;
using System.IO;
using UnityEditor;
using UnityEngine;

namespace Luny.Core
{
	public static class PathUtil
	{
		public static String GetRelativePath(String path) => Path.GetRelativePath(Application.dataPath, path).ToForwardSlashes();

		public static String GetFullPath(String rootPath, String relativePath) =>
			Path.GetFullPath(Path.Join(rootPath, relativePath)).ToForwardSlashes();

		public static void TryCreateDirectory(String path)
		{
			try
			{
				path = Path.GetFullPath(path).ToForwardSlashes();
				if (Directory.Exists(path) == false)
					Directory.CreateDirectory(path);
			}
			catch (Exception e)
			{
				throw new IOException($"Failed to create directory '{path}', reason: {e}", e);
			}
		}
	}
}
