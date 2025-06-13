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
		public event Action<LunyLuaAsset> OnAdd;
		public event Action<LunyLuaAsset> OnRemove;

		[SerializeField] [ReadOnlyField] private List<LunyLuaAsset> m_LuaAssets = new();
		[SerializeField] [ReadOnlyField] private List<String> m_LuaAssetPaths = new();

		public IList<LunyLuaAsset> Assets => m_LuaAssets.AsReadOnly();
		public IList<String> Paths => m_LuaAssetPaths.AsReadOnly();

		internal void Add(LunyLuaAsset luaAsset, String assetPath)
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


		internal Boolean Remove(LunyLuaAsset luaAsset)
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
			for (var i = m_LuaAssets.Count - 1; i >= 0; i--)
			{
				if (m_LuaAssets[i] == null)
				{
					m_LuaAssets.RemoveAt(i);
					m_LuaAssetPaths.RemoveAt(i);
				}
			}
		}
	}
}
