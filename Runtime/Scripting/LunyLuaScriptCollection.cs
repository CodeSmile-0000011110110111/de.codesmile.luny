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
		private readonly Dictionary<String, List<int>> m_FullPathScriptIndexes = new();

		//public IReadOnlyCollection<LunyLuaScript> Scripts => m_Scripts.AsReadOnly();
		public Int32 Count => m_Scripts.Count;
		public Boolean IsReadOnly => false;

		public LunyLuaScript this[Int32 index] { get => m_Scripts[index]; set => m_Scripts[index] = value; }

		public IEnumerator<LunyLuaScript> GetEnumerator() => m_Scripts.GetEnumerator();

		IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();

		public void Add(LunyLuaScript luaScript)
		{
			var scriptIndex = m_Scripts.Count;
			var scriptPath = luaScript.FullPath;
			if (m_FullPathScriptIndexes.TryGetValue(scriptPath, out var indexes))
				indexes.Add(scriptIndex);
			else
				m_FullPathScriptIndexes.Add(scriptPath, new List<int> {scriptIndex});

			m_Scripts.Add(luaScript);
		}

		public Boolean Remove(LunyLuaScript luaScript)
		{
			var scriptPath = luaScript.FullPath;
			if (m_FullPathScriptIndexes.TryGetValue(scriptPath, out var indexes))
			{
				var scriptCount = m_Scripts.Count;
				for (int i = 0; i < indexes.Count; i++)
				{
					var scriptIndex = indexes[i];
					if (scriptIndex < scriptCount && m_Scripts[scriptIndex].Equals(luaScript))
					{
						m_Scripts.RemoveAt(scriptIndex);
						indexes.RemoveAt(i);
						return true;
					}
				}
			}

			return false;
		}

		public void RemoveAt(Int32 index)
		{
			var script = m_Scripts[index];
			if (m_FullPathScriptIndexes.TryGetValue(script.FullPath, out var indexes))
				indexes.Remove(index);

			m_Scripts.RemoveAt(index);
		}

		public void RemoveScriptsForAsset(LunyLuaAsset luaAsset)
		{
			var scriptPath = luaAsset.FullPath;
			if (m_FullPathScriptIndexes.TryGetValue(scriptPath, out var indexes))
			{
				var scriptCount = m_Scripts.Count;
				for (int i = 0; i < indexes.Count; i++)
				{
					var scriptIndex = indexes[i];
					if (scriptIndex < scriptCount)
					{
						Debug.Assert(scriptPath == m_Scripts[scriptIndex].FullPath);
						m_Scripts.RemoveAt(scriptIndex);
					}
				}

				m_FullPathScriptIndexes.Remove(scriptPath);
			}
		}

		public void Clear()
		{
			m_FullPathScriptIndexes.Clear();
			m_Scripts.Clear();
		}

		public Boolean Contains(LunyLuaScript luaScript) => m_Scripts.Contains(luaScript);

		public void CopyTo(LunyLuaScript[] array, Int32 arrayIndex) => m_Scripts.CopyTo(array, arrayIndex);
		public Int32 IndexOf(LunyLuaScript luaScript) => m_Scripts.IndexOf(luaScript);

		public void Insert(Int32 index, LunyLuaScript luaScript) => throw new NotImplementedException();


		public Boolean TryGetScriptsForPath(String scriptPath, out IList<LunyLuaScript> scripts)
		{
			scripts = null;

			if (m_FullPathScriptIndexes.TryGetValue(scriptPath, out var indexes))
			{
				var scriptCount = m_Scripts.Count;
				for (int i = 0; i < indexes.Count; i++)
				{
					var scriptIndex = indexes[i];
					if (scriptIndex < scriptCount)
					{
						if (scripts == null)
							scripts = new List<LunyLuaScript>();

						scripts.Add(m_Scripts[scriptIndex]);
					}
				}
			}

			return scripts != null;
		}
	}
}
