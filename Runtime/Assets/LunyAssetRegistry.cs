// Copyright (C) 2021-2025 Steffen Itterheim
// Refer to included LICENSE file for terms and conditions.

using CodeSmile.Utility;
using Lua.Unity;
using System;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

namespace CodeSmile.Luny
{
	/// <summary>
	/// Maintains a list of project-wide LuaAsset (*.lua) assets in support of 'load bundled script by name/path'.
	/// </summary>
	public sealed class LunyAssetRegistry : ScriptableObject
	{
		private static LunyAssetRegistry s_Singleton;

		[Header("Fully automated and required Asset (read-only)")]
		[SerializeField] [ReadOnlyField] private LuaContext m_DefaultContext;
		[SerializeField] [ReadOnlyField] private List<LuaContext> m_LuaContexts = new();
		[SerializeField] [ReadOnlyField] private List<LuaAsset> m_LuaAssets = new();
		[SerializeField] [ReadOnlyField] private List<String> m_LuaAssetNames = new();
		[SerializeField] [ReadOnlyField] private List<String> m_LuaAssetPaths = new();

		public static LunyAssetRegistry Singleton { get => s_Singleton; internal set => s_Singleton = value; }
		public LuaContext DefaultContext => m_DefaultContext;

		private void Awake() => s_Singleton = this;

		public LuaContext GetContext(String contextName) => m_LuaContexts.Find(context => context.name == contextName);

		public LuaAsset GetScript(String scriptName)
		{
			var index = m_LuaAssetNames.IndexOf(scriptName);
			if (index < 0)
				index = m_LuaAssetPaths.IndexOf(scriptName);

			return index >= 0 ? m_LuaAssets[index] : null;
		}

		internal void AddLuaAsset(LuaAsset luaAsset, string assetName, String assetPath)
		{
			m_LuaAssets.Add(luaAsset);
			m_LuaAssetNames.Add(assetName);
			m_LuaAssetPaths.Add(assetPath);
		}

		internal void RemoveLuaAsset(LuaAsset luaAsset, string assetName, String assetPath)
		{
			m_LuaAssets.Remove(luaAsset);
			m_LuaAssetNames.Remove(assetName);
			m_LuaAssetPaths.Remove(assetPath);
		}

		internal void ClearLuaAssets()
		{
			m_LuaAssets.Clear();
			m_LuaAssetNames.Clear();
			m_LuaAssetPaths.Clear();
		}
	}
}
