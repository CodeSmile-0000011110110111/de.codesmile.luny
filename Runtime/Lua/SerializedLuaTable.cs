// Copyright (C) 2021-2025 Steffen Itterheim
// Refer to included LICENSE file for terms and conditions.

using Lua;
using System;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

namespace CodeSmile.Luny
{
	[Serializable]
	public sealed class SerializedLuaTable
	{
		[SerializeField] private List<SerializedLuaValue> m_ArrayValues = new();
		[SerializeField] private List<SerializedLuaKeyValue> m_DictionaryValues = new();

		private LuaTable m_Table = new(0, 0);

		public LuaTable Table
		{
			get
			{
				var arrayCount = m_ArrayValues.Count;
				var dictCount = m_DictionaryValues.Count;

				for (var i = 0; i < arrayCount; i++)
					m_Table[i + 1] = m_ArrayValues[i].Value;

				for (var i = 0; i < dictCount; i++)
				{
					var item = m_DictionaryValues[i];
					m_Table[item.Key] = item.Value.Value;
				}

				return m_Table;
			}
		}
	}
}
