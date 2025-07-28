// Copyright (C) 2021-2025 Steffen Itterheim
// Refer to included LICENSE file for terms and conditions.

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

		[Header("Fully automated registry (read-only)")]
		[SerializeField] [ReadOnlyField] private LunyLuaContext m_RuntimeContext;
		[SerializeField] [ReadOnlyField] private LunyLuaContext m_ModdingContext;

		[SerializeField] [ReadOnlyField] private LuaAssetCollection m_RuntimeAutoRunLuaAssets = new();
		[SerializeField] [ReadOnlyField] private LuaAssetCollection m_RuntimeLuaAssets = new();
		[SerializeField] [ReadOnlyField] private LuaAssetCollection m_ModdingAutoRunLuaAssets = new();
		[SerializeField] [ReadOnlyField] private LuaAssetCollection m_ModdingLuaAssets = new();

		public LunyLuaContext RuntimeContext { get => m_RuntimeContext; set => m_RuntimeContext = value; }
		public LunyLuaContext ModdingContext { get => m_ModdingContext; set => m_ModdingContext = value; }

		public LuaAssetCollection RuntimeAutoRunLuaAssets
		{
			get => m_RuntimeAutoRunLuaAssets;
			internal set => m_RuntimeAutoRunLuaAssets = value;
		}
		public LuaAssetCollection ModdingAutoRunLuaAssets
		{
			get => m_ModdingAutoRunLuaAssets;
			internal set => m_ModdingAutoRunLuaAssets = value;
		}
		public LuaAssetCollection RuntimeLuaAssets => m_RuntimeLuaAssets;
		public LuaAssetCollection ModdingLuaAssets => m_ModdingLuaAssets;

		public static LunyRuntimeAssetRegistry Singleton
		{
			get => s_Singleton != null ? s_Singleton : Resources.Load<LunyRuntimeAssetRegistry>(nameof(LunyRuntimeAssetRegistry));
			internal set => s_Singleton = value;
		}

		private void Awake() => s_Singleton = this;

		private void OnDestroy()
		{
			if (s_Singleton == this)
				s_Singleton = null;
		}

		public LunyLuaAsset GetRuntimeLuaAsset(String assetNameOrPath)
		{
			var index = m_RuntimeLuaAssets.Paths.IndexOf(assetNameOrPath);
			return index >= 0 ? m_RuntimeLuaAssets.Assets[index] : null;
		}

		public LunyLuaAsset GetModdingLuaAsset(String assetNameOrPath)
		{
			var index = m_ModdingLuaAssets.Paths.IndexOf(assetNameOrPath);
			return index >= 0 ? m_ModdingLuaAssets.Assets[index] : null;
		}

		public void Save()
		{
#if UNITY_EDITOR
			if (s_Singleton != null)
			{
				// delay to avoid "worker: import error code (4)" when called from ctor/InitOnLoad
				EditorApplication.delayCall += () =>
				{
					EditorUtility.SetDirty(s_Singleton);
					AssetDatabase.SaveAssetIfDirty(s_Singleton);
				};
			}
#endif
		}
	}
}
