// Copyright (C) 2021-2025 Steffen Itterheim
// Refer to included LICENSE file for terms and conditions.

using UnityEditor;

namespace CodeSmile.Luny
{
	public static class LunyAssetPath
	{
		public static string Root => "Assets/Luny";
		public static string EditorRoot => $"{Root}/Editor";
		public static string RuntimeRoot => $"{Root}/Runtime";
	}
}
