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
		[SerializeField] private LuaAssetCollection m_EditorLuaAssets = new();
		[SerializeField] private LunyLuaContext m_EditorContext;
		public LuaAssetCollection EditorLuaAssets => m_EditorLuaAssets;
		public LunyLuaContext LuaContext { get => m_EditorContext; set => m_EditorContext = value; }

		public static LunyEditorAssetRegistry Singleton => instance; // alias for consistency

		public LunyEditorLuaAsset GetScript(String scriptNameOrPath)
		{
			var index = m_EditorLuaAssets.Names.IndexOf(scriptNameOrPath);
			if (index < 0)
				index = m_EditorLuaAssets.Paths.IndexOf(scriptNameOrPath);

			return index >= 0 ? (LunyEditorLuaAsset)m_EditorLuaAssets.Assets[index] : null;
		}

		public void Save() => Save(true);
	}
}
