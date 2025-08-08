// Copyright (C) 2021-2025 Steffen Itterheim
// Refer to included LICENSE file for terms and conditions.

using System;
using UnityEditor;
using UnityEngine;

namespace LunyEditor.Core
{
	/// <summary>
	///     If Preferences => Asset Pipeline => Auto Refresh is disabled, will call AssetDatabase.Refresh() before
	///     entering Playmode to ensure Playmode always uses the up-to-date versions of assets and scripts.
	/// </summary>
	/// <remarks>If no assets have changed this script will not slow down entering playmode.</remarks>
	internal static class RefreshAssetsOnEnterPlaymode
	{
		private const String AutoRefreshKey = "kAutoRefreshMode";
		private static Boolean IsAutoRefreshDisabled => EditorPrefs.GetInt(AutoRefreshKey, -1) == 0;

		[InitializeOnLoadMethod]
		private static void InitOnLoad()
		{
			EditorApplication.playModeStateChanged -= OnPlayModeStateChanged;
			EditorApplication.playModeStateChanged += OnPlayModeStateChanged;
		}

		private static void OnPlayModeStateChanged(PlayModeStateChange state)
		{
			if (state == PlayModeStateChange.ExitingEditMode && IsAutoRefreshDisabled)
				AssetDatabase.Refresh();
		}
	}
}
