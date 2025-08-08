// Copyright (C) 2021-2025 Steffen Itterheim
// Refer to included LICENSE file for terms and conditions.

using System;
using System.Linq;
using UnityEditor;
using UnityEngine;

namespace Lua.Unity.Editor
{
	internal sealed class AddLuaToUserFileExtensions : ScriptableSingleton<AddLuaToUserFileExtensions>
	{
		private const String LuaExtension = "lua";

		[InitializeOnLoadMethod] private static AddLuaToUserFileExtensions OnLoad() => instance; // auto-create the singleton

		private static void CheckAndAddLuaExtension()
		{
			if (EditorSettings.projectGenerationUserExtensions.Contains(LuaExtension) == false)
			{
				var extensions = EditorSettings.projectGenerationUserExtensions.ToList();
				// prevent possible duplicates, no harm just to keep it clean
				extensions.Remove("LUA");
				extensions.Remove("Lua");
				extensions.Add(LuaExtension);
				EditorSettings.projectGenerationUserExtensions = extensions.ToArray();
			}
		}

		private void Awake() => CheckAndAddLuaExtension();
	}
}
