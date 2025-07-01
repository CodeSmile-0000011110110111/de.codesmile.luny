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

		public LuaTable Table
		{
			get
			{
				var arrayCount = m_ArrayValues.Count;
				var dictCount = m_DictionaryValues.Count;
				var table = new LuaTable(arrayCount, dictCount);

				for (var i = 0; i < arrayCount; i++)
					table[i + 1] = m_ArrayValues[i].Value;

				for (var i = 0; i < dictCount; i++)
				{
					var item = m_DictionaryValues[i];
					table[item.Key] = item.Value.Value;
				}

				return table;
			}
		}
	}
}
