// Copyright (C) 2021-2025 Steffen Itterheim
// Refer to included LICENSE file for terms and conditions.

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

namespace Luny
{
	public sealed class LunyLuaScriptCollection : IList<LunyLuaScript>
	{
		private readonly List<LunyLuaScript> m_Scripts = new();
		private readonly Dictionary<String, LunyLuaScript> m_FullPathScripts = new();

		public IReadOnlyCollection<LunyLuaScript> Scripts => m_Scripts.AsReadOnly();
		public Int32 Count => m_Scripts.Count;
		public Boolean IsReadOnly => false;

		public LunyLuaScript this[Int32 index] { get => m_Scripts[index]; set => m_Scripts[index] = value; }

		public IEnumerator<LunyLuaScript> GetEnumerator() => m_Scripts.GetEnumerator();

		IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();

		public void Add(LunyLuaScript luaScript)
		{
			var scriptPath = luaScript.FullPath;
			if (m_FullPathScripts.ContainsKey(scriptPath))
				Remove(luaScript);

			m_FullPathScripts.Add(scriptPath, luaScript);
			m_Scripts.Add(luaScript);
		}

		public Boolean Remove(LunyLuaScript luaScript)
		{
			m_FullPathScripts.Remove(luaScript.FullPath);
			return m_Scripts.Remove(luaScript);
		}

		public void Clear()
		{
			m_FullPathScripts.Clear();
			m_Scripts.Clear();
		}

		public Boolean Contains(LunyLuaScript luaScript) => m_Scripts.Contains(luaScript);

		public void CopyTo(LunyLuaScript[] array, Int32 arrayIndex) => m_Scripts.CopyTo(array, arrayIndex);
		public Int32 IndexOf(LunyLuaScript luaScript) => m_Scripts.IndexOf(luaScript);

		public void Insert(Int32 index, LunyLuaScript luaScript) => throw new NotImplementedException();

		public void RemoveAt(Int32 index)
		{
			var script = m_Scripts[index];
			m_Scripts.RemoveAt(index);
			m_FullPathScripts.Remove(script.FullPath);
		}

		public void RemoveScriptForAsset(LunyLuaAsset luaAsset)
		{
			var assetFullPath = luaAsset.FullPath;
			m_FullPathScripts.Remove(assetFullPath);

			for (var i = m_Scripts.Count - 1; i >= 0; i--)
			{
				var script = m_Scripts[i];
				if (script.FullPath == assetFullPath)
				{
					m_Scripts.RemoveAt(i);
					break;
				}
			}
		}

		public Boolean TryGetScriptForPath(String fullPath, out LunyLuaScript script) => m_FullPathScripts.TryGetValue(fullPath, out script);
	}
}
