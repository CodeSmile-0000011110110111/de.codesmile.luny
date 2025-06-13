// Copyright (C) 2021-2025 Steffen Itterheim
// Refer to included LICENSE file for terms and conditions.

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

namespace CodeSmile.Luny
{
	public sealed class LuaScriptCollection : IList<LunyLuaScript>
	{
		private readonly List<LunyLuaScript> m_Scripts = new();

		public Int32 Count => m_Scripts.Count;
		public Boolean IsReadOnly => false;

		public LunyLuaScript this[Int32 index] { get => m_Scripts[index]; set => m_Scripts[index] = value; }

		public IEnumerator<LunyLuaScript> GetEnumerator() => m_Scripts.GetEnumerator();

		IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();

		public void Add(LunyLuaScript item) => m_Scripts.Add(item);

		public Boolean Remove(LunyLuaScript item) => m_Scripts.Remove(item);
		public void Clear() => m_Scripts.Clear();

		public Boolean Contains(LunyLuaScript item) => m_Scripts.Contains(item);

		public void CopyTo(LunyLuaScript[] array, Int32 arrayIndex) => m_Scripts.CopyTo(array, arrayIndex);
		public Int32 IndexOf(LunyLuaScript item) => m_Scripts.IndexOf(item);

		public void Insert(Int32 index, LunyLuaScript item) => m_Scripts.Insert(index, item);

		public void RemoveAt(Int32 index) => m_Scripts.RemoveAt(index);

		public Int32 IndexOf(LunyLuaAssetBase item)
		{
			for (var i = 0; i < m_Scripts.Count; i++)
			{
				if (item == m_Scripts[i].LuaAsset)
					return i;
			}
			return -1;
		}
	}
}
