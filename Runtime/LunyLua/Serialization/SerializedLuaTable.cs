// Copyright (C) 2021-2025 Steffen Itterheim
// Refer to included LICENSE file for terms and conditions.

using Lua;
using System;
using System.Collections.Generic;
using Unity.Profiling;
using UnityEditor;
using UnityEngine;

namespace Luny
{
	[Serializable]
	public sealed class SerializedLuaTable : ISerializationCallbackReceiver
	{
		[SerializeField] private SerializedLuaValue[] m_ArrayValues = Array.Empty<SerializedLuaValue>();
		[SerializeField] private SerializedLuaKeyValue[] m_DictionaryValues = Array.Empty<SerializedLuaKeyValue>();

		private LuaTable m_Table;
		public LuaTable Table => m_Table ?? (m_Table = new LuaTable(0, 0));

		public void OnBeforeSerialize() => ToSerializedData(m_Table);

		public void OnAfterDeserialize() => m_Table = FromSerializedData();

		private void ToSerializedData(LuaTable table)
		{
#if UNITY_EDITOR || DEVELOPMENT_BUILD
			using (m_SerializeMarker.Auto())
#endif
			{
				if (table == null)
				{
					Array.Clear(m_ArrayValues, 0, m_ArrayValues.Length);
					Array.Clear(m_DictionaryValues, 0, m_DictionaryValues.Length);
				}
				else
				{
					var array = table.GetArraySpan();
					var arrayCount = array.Length;
					Array.Resize(ref m_ArrayValues, arrayCount);
					for (var i = 0; i < arrayCount; i++)
					{
						if (array[i].Type == LuaValueType.Nil)
						{
							Array.Resize(ref m_ArrayValues, i);
							break;
						}

						m_ArrayValues[i].Value = array[i];
					}

					// sort dictionary values by keys (find duplicates)
					var duplicateKeys = new Dictionary<String, List<SerializedLuaKeyValue>>();
					foreach (var dictValuePair in m_DictionaryValues)
					{
						var key = dictValuePair.Key;
						if (duplicateKeys.ContainsKey(key))
							duplicateKeys[key].Add(dictValuePair);
						else
							duplicateKeys.Add(key, new List<SerializedLuaKeyValue> { dictValuePair });
					}

					var dictValue = new List<SerializedLuaKeyValue>(table.HashMapCount);
					foreach (var pair in table)
					{
						var key = pair.Key;
						if (key.Type == LuaValueType.Number)
							continue;

						var value = pair.Value;
						if (key.Type == LuaValueType.String &&
						    duplicateKeys.TryGetValue(key.Read<String>(), out var duplicates) &&
						    duplicates.Count > 1)
						{
							// re-add any duplicates or else Inspector UI will behave unexpectedly
							var dupeCount = duplicates.Count;
							for (var i = 0; i < dupeCount; i++)
							{
								var duplicateKeyValue = duplicates[i];
								dictValue.Add(duplicateKeyValue);
							}

							continue;
						}

						dictValue.Add(new SerializedLuaKeyValue(key, value));
					}

					m_DictionaryValues = dictValue.ToArray();
				}
			}
		}

		private LuaTable FromSerializedData()
		{
#if UNITY_EDITOR || DEVELOPMENT_BUILD
			using (m_DeserializeMarker.Auto())
#endif
			{
				var arrayCount = m_ArrayValues.Length;
				var dictCount = m_DictionaryValues.Length;

				if (m_Table == null)
					m_Table = new LuaTable(arrayCount, dictCount);

#if UNITY_EDITOR
				// keep any non-editable values
				var keptValues = new Dictionary<LuaValue, LuaValue>();
				foreach (var pair in m_Table)
				{
					var keyType = pair.Key.Type;
					if (keyType == LuaValueType.Number)
						continue;

					var valueType = pair.Value.Type;
					if (valueType != LuaValueType.Boolean && valueType != LuaValueType.Number && valueType != LuaValueType.String ||
					    keyType != LuaValueType.String)
						keptValues.Add(pair.Key, pair.Value);
				}

				var keys = new HashSet<String>();
#endif

				// must clear, otherwise removing items through PropertyDrawer won't work
				m_Table.Clear();

				for (var i = 0; i < arrayCount; i++)
				{
					var luaValue = m_ArrayValues[i].Value;

#if UNITY_EDITOR
					// allows adding new items in PropertyDrawer
					if (luaValue.Type == LuaValueType.Nil)
						luaValue = String.Empty;
#endif

					m_Table[i + 1] = luaValue;
				}

				for (var i = 0; i < dictCount; i++)
				{
					var item = m_DictionaryValues[i];
					var key = item.Key;
					var luaValue = item.Value.Value;

#if UNITY_EDITOR
					//Debug.Log($"Deserialize: [{key}] = {luaValue} ({luaValue.Type})");

					// allows adding the first item in PropertyDrawer
					if (luaValue.Type == LuaValueType.Nil)
					{
						key = "new";
						luaValue = String.Empty;
					}

					// when adding more items through PropertyDrawer (+) it uses the same key as the previous item
					// but it must be a unique key
					// if (keys.Contains(key))
					// 	key += "1";

					keys.Add(key);
#endif

					m_Table[key] = luaValue;
				}

#if UNITY_EDITOR
				// put the non-editable values back into the table
				foreach (var pair in keptValues)
					m_Table[pair.Key] = pair.Value;
#endif

				return m_Table;
			}
		}

#if UNITY_EDITOR || DEVELOPMENT_BUILD
		private ProfilerMarker m_SerializeMarker = new($"{nameof(SerializedLuaTable)}.{nameof(ToSerializedData)}");
		private ProfilerMarker m_DeserializeMarker = new($"{nameof(SerializedLuaTable)}.{nameof(FromSerializedData)}");
#endif
	}
}
