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
		public event Action<LunyLuaAssetBase> OnAdd;
		public event Action<LunyLuaAssetBase> OnRemove;

		[SerializeField] [ReadOnlyField] private List<LunyLuaAssetBase> m_LuaAssets = new();
		[SerializeField] [ReadOnlyField] private List<String> m_LuaAssetPaths = new();

		public List<LunyLuaAssetBase> Assets => m_LuaAssets;
		public List<String> Paths => m_LuaAssetPaths;

		public LuaAssetCollection(IEnumerable<LunyLuaAssetBase> luaAssets = null)
		{
			if (luaAssets != null)
			{
				foreach (var luaAsset in luaAssets)
				{
					if (luaAsset != null)
						Add(luaAsset, AssetDatabase.GetAssetPath(luaAsset));
				}
			}
		}

		internal void Add(LunyLuaAssetBase luaAsset, String assetPath)
		{
			Debug.Assert(luaAsset != null);
			Debug.Assert(String.IsNullOrEmpty(assetPath) == false);

			if (m_LuaAssets.Contains(luaAsset) == false)
			{
				m_LuaAssets.Add(luaAsset);
				m_LuaAssetPaths.Add(assetPath);

				OnAdd?.Invoke(luaAsset);
			}
		}

		internal bool Remove(LunyLuaAssetBase luaAsset)
		{
			Debug.Assert(luaAsset != null);

			var index = m_LuaAssets.IndexOf(luaAsset);
			if (index >= 0)
			{
				OnRemove?.Invoke(luaAsset);

				m_LuaAssets.RemoveAt(index);
				m_LuaAssetPaths.RemoveAt(index);
				return true;
			}

			return false;
		}

		internal void ClearMissingAssets()
		{
			for (int i = m_LuaAssets.Count - 1; i >= 0; i--)
			{
				if (m_LuaAssets[i] == null)
				{
					m_LuaAssets.RemoveAt(i);
				}
			}
		}
	}
}
