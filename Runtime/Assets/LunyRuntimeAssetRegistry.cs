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

		[Header("Fully automated, required Asset (read-only)")]
		[SerializeField] [ReadOnlyField] private LuaAssetCollection m_RuntimeLuaAssets = new();
		[SerializeField] [ReadOnlyField] private LuaAssetCollection m_ModdingLuaAssets = new();

		[SerializeField] [ReadOnlyField] private LunyLuaContext m_RuntimeContext;
		[SerializeField] [ReadOnlyField] private LunyLuaContext m_ModdingContext;
		public LuaAssetCollection RuntimeLuaAssets => m_RuntimeLuaAssets;
		public LuaAssetCollection ModdingLuaAssets => m_ModdingLuaAssets;

		public LunyLuaContext DefaultContext { get => m_RuntimeContext; set => m_RuntimeContext = value; }
		public LunyLuaContext ModdingContext { get => m_ModdingContext; set => m_ModdingContext = value; }

		public static LunyRuntimeAssetRegistry Singleton { get => s_Singleton; internal set => s_Singleton = value; }

		private void Awake() => s_Singleton = this;
		private void OnDestroy() => s_Singleton = null;

		public LunyRuntimeLuaAsset GetScript(String scriptNameOrPath)
		{
			var index = RuntimeLuaAssets.Names.IndexOf(scriptNameOrPath);
			if (index < 0)
				index = RuntimeLuaAssets.Paths.IndexOf(scriptNameOrPath);

			return index >= 0 ? (LunyRuntimeLuaAsset)RuntimeLuaAssets.Assets[index] : null;
		}

		public void Save()
		{
#if UNITY_EDITOR
			if (s_Singleton != null)
			{
				EditorUtility.SetDirty(s_Singleton);
				AssetDatabase.SaveAssetIfDirty(s_Singleton);
			}
#endif
		}
	}
}
