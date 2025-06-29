// Copyright (C) 2021-2025 Steffen Itterheim
// Refer to included LICENSE file for terms and conditions.

using Lua;
using System;
using System.Globalization;
using UnityEditor;
using UnityEngine;

namespace CodeSmile.Luny
{
	[Serializable]
	public struct SerializableLuaValue : ISerializationCallbackReceiver
	{
		[SerializeField] private LuaValueType m_SerializedLuaValueType;
		[SerializeField] private String m_SerializedLuaValueString;

		private LuaValue m_LuaValue;

		public LuaValue Value { get => m_LuaValue; set => m_LuaValue = value; }

		public void OnBeforeSerialize()
		{
			m_SerializedLuaValueString = null;

			switch (m_SerializedLuaValueType)
			{
				case LuaValueType.Boolean:
					m_SerializedLuaValueString = m_LuaValue.TryRead(out Boolean b) ? b ? "1" : "0" : "0";
					//Debug.Log($"Serialized bool: {m_SerializedLuaValueString}");
					break;
				case LuaValueType.Number:
					var number = m_LuaValue.TryRead(out Double n) ? n : 0.0;
					m_SerializedLuaValueString = Convert.ToString(number, CultureInfo.InvariantCulture);
					//Debug.Log($"Serialized number: {m_SerializedLuaValueString}");
					break;
				case LuaValueType.String:
					m_SerializedLuaValueString = m_LuaValue.ToString();
					//Debug.Log($"Serialized string: {m_SerializedLuaValueString}");
					break;
				case LuaValueType.Table:
					m_SerializedLuaValueString = "{}";
					//Debug.Log("Serialized table: (not really)");
					break;
				case LuaValueType.Nil:
				case LuaValueType.Function:
				case LuaValueType.Thread:
				case LuaValueType.LightUserData:
				case LuaValueType.UserData:
					m_SerializedLuaValueType = LuaValueType.Nil;
					break;
				default:
					throw new ArgumentOutOfRangeException(nameof(m_SerializedLuaValueType), m_SerializedLuaValueType,
						"unhandled type");
			}
		}

		public void OnAfterDeserialize()
		{
			m_LuaValue = LuaValue.Nil;

			switch (m_SerializedLuaValueType)
			{
				case LuaValueType.Boolean:
				{
					if (Double.TryParse(m_SerializedLuaValueString, NumberStyles.Any, CultureInfo.InvariantCulture,
						    out var doubleValue))
						m_LuaValue = new LuaValue(doubleValue != 0);
					else
						m_LuaValue = Boolean.TryParse(m_SerializedLuaValueString, out var boolValue) && boolValue;
					Debug.Log($"De-Serialized bool: {m_LuaValue} from {m_SerializedLuaValueString}");
					break;
				}
				case LuaValueType.Number:
				{
					m_LuaValue = Double.TryParse(m_SerializedLuaValueString, NumberStyles.Any, CultureInfo.InvariantCulture,
						out var doubleValue)
						? doubleValue
						: 0.0;
					Debug.Log($"De-Serialized number: {m_LuaValue} from '{m_SerializedLuaValueString}'");
					break;
				}
				case LuaValueType.String:
				{
					m_LuaValue = m_SerializedLuaValueString != null ? m_SerializedLuaValueString : String.Empty;
					Debug.Log($"De-Serialized string: {m_LuaValue} from {m_SerializedLuaValueString}");
					break;
				}
				case LuaValueType.Table:
				{
					m_LuaValue = new LuaTable();
					Debug.Log($"De-Serialized table: {m_LuaValue} from (not really)");
					break;
				}
				case LuaValueType.Nil:
				case LuaValueType.Function:
				case LuaValueType.Thread:
				case LuaValueType.LightUserData:
				case LuaValueType.UserData:
					Debug.Log($"De-Serialized: nothing ({m_SerializedLuaValueType})");
					m_LuaValue = LuaValue.Nil;
					break;
				default:
					throw new ArgumentOutOfRangeException(nameof(m_SerializedLuaValueType), m_SerializedLuaValueType,
						"unhandled type");
			}
		}

		public override String ToString() => m_LuaValue.ToString();
	}
}
