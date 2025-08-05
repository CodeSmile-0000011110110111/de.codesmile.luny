// Copyright (C) 2021-2025 Steffen Itterheim
// Refer to included LICENSE file for terms and conditions.

using Luny;
using System;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

namespace LunyEditor
{
	[FilePath("ProjectSettings/LunyEditorAssetRegistry.asset", FilePathAttribute.Location.ProjectFolder)]
	public sealed class LunyEditorAssetRegistry : ScriptableSingleton<LunyEditorAssetRegistry>
	{
		public event Action<LunyLuaContext> OnEditorContextChanged;

		[SerializeField] private LuaAssetCollection m_EditorLuaAssets = new();
		[SerializeField] private LunyLuaContext m_EditorContext;

		public IList<LunyEditorLuaAsset> EditorAutoRunLuaAssets => LunyProjectSettings.Singleton.EditorAutoRunLuaAssets;
		public LuaAssetCollection EditorLuaAssets => m_EditorLuaAssets;
		public LunyLuaContext EditorContext
		{
			get => m_EditorContext;
			set
			{
				if (m_EditorContext != value)
				{
					m_EditorContext = value;
					OnEditorContextChanged?.Invoke(m_EditorContext);
				}
			}
		}

		public static LunyEditorAssetRegistry Singleton => instance; // alias for consistency

		public LunyLuaAsset GetLuaAsset(String assetNameOrPath)
		{
			var index = m_EditorLuaAssets.Paths.IndexOf(assetNameOrPath);
			return index >= 0 ? m_EditorLuaAssets.Assets[index] : null;
		}

		public void Save() => Save(true);
	}
}
