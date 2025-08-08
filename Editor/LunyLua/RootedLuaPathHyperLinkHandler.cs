// Copyright (C) 2021-2025 Steffen Itterheim
// Refer to included LICENSE file for terms and conditions.

using System;
using System.Collections.Generic;
using System.IO;
using UnityEditor;
using UnityEditorInternal;
using UnityEngine;

namespace LunyEditor
{
	/// <summary>
	/// Handles opening of href links that point to a file outside the /Assets directory because Unity
	/// does not do so by default.
	/// </summary>
	internal static class RootedLuaPathHyperLinkHandler
	{
		[InitializeOnLoadMethod] private static void OnLoad() => EditorGUI.hyperLinkClicked += OnHyperLinkClicked;

		private static void OnHyperLinkClicked(EditorWindow window, HyperLinkClickedEventArgs evt)
		{
			var linkData = evt.hyperLinkData;
			if (linkData == null || linkData.TryGetValue("href", out var href) == false)
				return;

			// path must not be a relative Assets paths (Unity handles those) and must be a .lua file
			if (href.StartsWith("Assets/") || href.EndsWith(".lua") == false)
				return;

			// report any malformed or non-existing paths
			var fullPath = Path.GetFullPath(href);
			if (IsFileMissing(fullPath))
				return;

			var line = GetHyperLinkLine(linkData);
			var col = GetHyperLinkColumn(linkData);
			InternalEditorUtility.OpenFileAtLineExternal(fullPath, line, col);
		}

		private static Boolean IsFileMissing(String fullPath)
		{
			if (Directory.Exists(fullPath))
			{
				Debug.LogWarning($"Hyperlink target is a directory: {fullPath}");
				return true;
			}
			if (File.Exists(fullPath) == false)
			{
				Debug.LogWarning($"Hyperlink target does not exist: {fullPath}");
				return true;
			}
			return false;
		}

		private static Int32 GetHyperLinkLine(Dictionary<String, String> linkData) =>
			linkData.TryGetValue("line", out var lineStr) && Int32.TryParse(lineStr, out var line) ? line : 1;

		private static Int32 GetHyperLinkColumn(Dictionary<String, String> linkData) =>
			linkData.TryGetValue("column", out var colStr) && Int32.TryParse(colStr, out var col) ? col : 1;
	}
}
