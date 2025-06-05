// Copyright (C) 2021-2025 Steffen Itterheim
// Refer to included LICENSE file for terms and conditions.

using CodeSmile.Luny;
using System;
using UnityEditor;
using UnityEngine;

namespace CodeSmileEditor.Luny
{
	//[FilePath("ProjectSettings/" + nameof(LunyEditorAssetRegistry) + ".asset", FilePathAttribute.Location.ProjectFolder)]
	public sealed class LunyEditorAssetRegistry : ScriptableSingleton<LunyEditorAssetRegistry>
	{
		[SerializeField] private LuaAssetCollection m_LuaAssets = new();
		internal LuaAssetCollection LuaAssets => m_LuaAssets;

		public LunyEditorLuaAsset GetScript(String scriptNameOrPath)
		{
			var index = m_LuaAssets.Names.IndexOf(scriptNameOrPath);
			if (index < 0)
				index = m_LuaAssets.Paths.IndexOf(scriptNameOrPath);

			return index >= 0 ? (LunyEditorLuaAsset)m_LuaAssets.Assets[index] : null;
		}
	}
}
