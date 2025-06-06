// Copyright (C) 2021-2025 Steffen Itterheim
// Refer to included LICENSE file for terms and conditions.

using CodeSmile.Luny;
using System;
using UnityEditor;
using UnityEngine;

namespace CodeSmileEditor.Luny
{
	[FilePath("ProjectSettings/LunyEditorAssetRegistry.asset", FilePathAttribute.Location.ProjectFolder)]
	public sealed class LunyEditorAssetRegistry : ScriptableSingleton<LunyEditorAssetRegistry>
	{
		[SerializeField] private LuaAssetCollection m_LuaAssets = new();
		[SerializeField] private LunyLuaContext m_DefaultContext;
		public LuaAssetCollection LuaAssets => m_LuaAssets;
		public LunyLuaContext DefaultContext { get => m_DefaultContext; set => m_DefaultContext = value; }

		public static LunyEditorAssetRegistry Singleton => instance; // alias for consistency

		public LunyEditorLuaAsset GetScript(String scriptNameOrPath)
		{
			var index = m_LuaAssets.Names.IndexOf(scriptNameOrPath);
			if (index < 0)
				index = m_LuaAssets.Paths.IndexOf(scriptNameOrPath);

			return index >= 0 ? (LunyEditorLuaAsset)m_LuaAssets.Assets[index] : null;
		}

		public void Save() => Save(true);
	}
}
