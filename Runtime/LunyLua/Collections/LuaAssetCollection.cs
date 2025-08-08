// Copyright (C) 2021-2025 Steffen Itterheim
// Refer to included LICENSE file for terms and conditions.

using Luny.Core;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

namespace Luny
{
	[Serializable]
	public sealed class LuaAssetCollection : IEnumerable<LunyLuaAsset>
	{
		public event Action<LunyLuaAsset> OnAdd;
		public event Action<LunyLuaAsset> OnRemove;

		[SerializeField] [ReadOnlyField] private List<LunyLuaAsset> m_LuaAssets = new();
		[SerializeField] [ReadOnlyField] private List<String> m_LuaAssetPaths = new();

		public IList<LunyLuaAsset> Assets => m_LuaAssets.AsReadOnly();
		public IList<String> Paths => m_LuaAssetPaths.AsReadOnly();

		public IEnumerator<LunyLuaAsset> GetEnumerator() => m_LuaAssets.GetEnumerator();

		IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();

		internal Boolean AddOrUpdate(LunyLuaAsset luaAsset, String assetPath)
		{
			Debug.Assert(luaAsset != null);
			Debug.Assert(String.IsNullOrEmpty(assetPath) == false);

			var existingAssetIndex = m_LuaAssets.IndexOf(luaAsset);
			if (existingAssetIndex != -1)
			{
				// still update asset path, it may have changed due to a rename
				m_LuaAssetPaths[existingAssetIndex] = assetPath;
				return false;
			}

			m_LuaAssets.Add(luaAsset);
			m_LuaAssetPaths.Add(assetPath);

			OnAdd?.Invoke(luaAsset);
			return true;
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

		internal void RemoveNullReferences()
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
