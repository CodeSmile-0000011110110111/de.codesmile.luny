// Copyright (C) 2021-2025 Steffen Itterheim
// Refer to included LICENSE file for terms and conditions.

using System;
using UnityEditor;
using UnityEngine;

namespace CodeSmileEditor
{
	internal static class CollectGarbageAfterPlaymode
	{
		[InitializeOnLoadMethod]
		private static void InitializeOnLoad() => EditorApplication.playModeStateChanged += OnPlaymodeStateChanged;

		private static void OnPlaymodeStateChanged(PlayModeStateChange mode)
		{
			if (mode == PlayModeStateChange.EnteredEditMode)
				EditorApplication.delayCall += () => GC.Collect();
		}
	}
}
