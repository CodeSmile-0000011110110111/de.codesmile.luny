// Copyright (C) 2021-2025 Steffen Itterheim
// Refer to included LICENSE file for terms and conditions.

using CodeSmile.Utility;
using System;
using UnityEditor;
using UnityEngine;

namespace CodeSmile.Luny
{
	/// <summary>
	/// Maintains a list of project-wide LuaAsset (*.lua) assets in support of 'load bundled script by name/path'.
	/// </summary>
	[Icon("Packages/de.codesmile.luny/Editor/Resources/LunyAssetRegistryIcon.png")]
	public sealed class LunyRuntimeAssetRegistry : ScriptableObject
	{
		private static LunyRuntimeAssetRegistry s_Singleton;

		[Header("Fully automated and required Asset (read-only)")]
		[SerializeField] [ReadOnlyField] private LuaAssetCollection m_LuaAssets = new();
		internal LuaAssetCollection LuaAssets => m_LuaAssets;

		// [SerializeField] [ReadOnlyField] private LuaContext m_DefaultContext;
		// [SerializeField] [ReadOnlyField] private List<LuaContext> m_LuaContexts = new();
		// public LuaContext DefaultContext => m_DefaultContext;
		// public LuaContext GetContext(String contextName) => m_LuaContexts.Find(context => context.name == contextName);

		public static LunyRuntimeAssetRegistry Singleton { get => s_Singleton; internal set => s_Singleton = value; }

		private void Awake() => s_Singleton = this;

		public LunyLuaAsset GetScript(String scriptNameOrPath)
		{
			var index = LuaAssets.Names.IndexOf(scriptNameOrPath);
			if (index < 0)
				index = LuaAssets.Paths.IndexOf(scriptNameOrPath);

			return index >= 0 ? (LunyLuaAsset)LuaAssets.Assets[index] : null;
		}

		public void Save()
		{
#if UNITY_EDITOR
			EditorUtility.SetDirty(this);
			AssetDatabase.SaveAssetIfDirty(this);
#endif
		}
	}
}
