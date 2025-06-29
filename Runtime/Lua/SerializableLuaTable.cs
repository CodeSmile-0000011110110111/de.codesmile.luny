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
	public sealed class SerializableLuaTable<TArray, TKey, TValue> : ISerializationCallbackReceiver
	{
		[SerializeField] private List<string> m_Array = new();
		[SerializeField] private List<TKey> m_Keys = new();
		[SerializeField] private List<TValue> m_Values = new();
		private LuaTable m_Table { get; set; } = new();


		public void OnBeforeSerialize()
		{
			foreach (var pair in m_Table)
			{
				var key = pair.Key;
				var value = pair.Value;
				var keyLuaType = key.Type;
				var valueLuaType = value.Type;

				switch (keyLuaType)
				{
					case LuaValueType.Number:
						// goes into array
						break;
					case LuaValueType.String:
						// dict key
						break;
					case LuaValueType.Table:
						// recurse but avoid infinite loop trap
						break;

					case LuaValueType.Boolean:
					case LuaValueType.Function:
					case LuaValueType.Thread:
					case LuaValueType.LightUserData:
					case LuaValueType.UserData:
					case LuaValueType.Nil:
					default:
						Debug.LogWarning($"{keyLuaType} is not a serializable key/value");
						break;
				}
			}
		}

		public void OnAfterDeserialize() => m_Table = new LuaTable();
		// m_Table.SetValues(m_Array);
		// m_Table.SetValues(m_Keys, m_Values);
	}
}
