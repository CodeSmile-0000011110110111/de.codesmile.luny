// Copyright (C) 2021-2025 Steffen Itterheim
// Refer to included LICENSE file for terms and conditions.

using CodeSmile.Utility;
using System;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

namespace CodeSmile.Luny
{
	[Serializable]
	public sealed class LuaAssetCollection
	{
		[SerializeField] [ReadOnlyField] private List<LunyLuaAssetBase> m_LuaAssets = new();
		[SerializeField] [ReadOnlyField] private List<String> m_LuaAssetNames = new();
		[SerializeField] [ReadOnlyField] private List<String> m_LuaAssetPaths = new();

		public List<LunyLuaAssetBase> Assets => m_LuaAssets;
		public List<String> Names => m_LuaAssetNames;
		public List<String> Paths => m_LuaAssetPaths;

		internal void Add(LunyLuaAssetBase luaAsset, string assetName, String assetPath)
		{
			m_LuaAssets.Add(luaAsset);
			m_LuaAssetNames.Add(assetName);
			m_LuaAssetPaths.Add(assetPath);
		}

		internal void Remove(LunyLuaAssetBase luaAsset, string assetName, String assetPath)
		{
			m_LuaAssets.Remove(luaAsset);
			m_LuaAssetNames.Remove(assetName);
			m_LuaAssetPaths.Remove(assetPath);
		}

		internal void Clear()
		{
			m_LuaAssets.Clear();
			m_LuaAssetNames.Clear();
			m_LuaAssetPaths.Clear();
		}
	}
}
