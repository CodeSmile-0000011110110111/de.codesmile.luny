// Copyright (C) 2021-2025 Steffen Itterheim
// Refer to included LICENSE file for terms and conditions.

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

namespace CodeSmile.Luny
{
	public sealed class LunyLuaScriptCollection : IList<LunyLuaScript>
	{
		private readonly List<LunyLuaScript> m_Scripts = new();

		public Int32 Count => m_Scripts.Count;
		public Boolean IsReadOnly => false;

		public LunyLuaScript this[Int32 index] { get => m_Scripts[index]; set => m_Scripts[index] = value; }

		public IEnumerator<LunyLuaScript> GetEnumerator() => m_Scripts.GetEnumerator();

		IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();

		public void Add(LunyLuaScript luaScript) => m_Scripts.Add(luaScript);

		public Boolean Remove(LunyLuaScript luaScript) => m_Scripts.Remove(luaScript);
		public void Clear() => m_Scripts.Clear();

		public Boolean Contains(LunyLuaScript luaScript) => m_Scripts.Contains(luaScript);

		public void CopyTo(LunyLuaScript[] array, Int32 arrayIndex) => m_Scripts.CopyTo(array, arrayIndex);
		public Int32 IndexOf(LunyLuaScript luaScript) => m_Scripts.IndexOf(luaScript);

		public void Insert(Int32 index, LunyLuaScript luaScript) => m_Scripts.Insert(index, luaScript);
		public void RemoveAt(Int32 index) => m_Scripts.RemoveAt(index);

		public Boolean TryRemove(LunyLuaAsset luaAsset) => TryRemove(luaAsset, out var _);

		public Boolean TryRemove(LunyLuaAsset luaAsset, out LunyLuaScript luaScript)
		{
			luaScript = null;
			if (luaAsset != null)
			{
				var index = IndexOf(luaAsset);
				if (index >= 0)
				{
					luaScript = m_Scripts[index];
					RemoveAt(index);
					return true;
				}
			}

			return false;
		}

		public Int32 IndexOf(LunyLuaAsset luaAsset)
		{
			for (var i = 0; i < m_Scripts.Count; i++)
			{
				if (luaAsset == m_Scripts[i].LuaAsset)
					return i;
			}
			return -1;
		}
	}
}
