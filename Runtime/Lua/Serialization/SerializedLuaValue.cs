// Copyright (C) 2021-2025 Steffen Itterheim
// Refer to included LICENSE file for terms and conditions.

using Lua;
using System;
using UnityEditor;
using UnityEngine;

namespace CodeSmile.Luny
{
	[Serializable]
	public struct SerializedLuaValue
	{
		[SerializeField] private LuaValueType m_ValueType;
		[SerializeField] private Boolean m_BooleanValue;
		[SerializeField] private Double m_NumberValue;
		[SerializeField] private String m_StringValue;

		public LuaValue Value
		{
			get => m_ValueType switch
			{
				LuaValueType.Boolean => new LuaValue(m_BooleanValue),
				LuaValueType.Number => new LuaValue(m_NumberValue),
				LuaValueType.String => m_StringValue != null ? new LuaValue(m_StringValue) : LuaValue.Nil,
				var _ => LuaValue.Nil,
			};
			set
			{
				m_ValueType = value.Type;
				switch (m_ValueType)
				{
					case LuaValueType.Boolean:
						m_BooleanValue = value.Read<Boolean>();
						break;
					case LuaValueType.Number:
						m_NumberValue = value.Read<Double>();
						break;
					case LuaValueType.String:
						m_StringValue = value.Read<String>();
						break;
					default:
						m_StringValue = value.ToString();
						break;
				}
			}
		}

		public SerializedLuaValue(LuaValue luaValue)
		{
			m_ValueType = luaValue.Type;
			m_BooleanValue = false;
			m_NumberValue = 0.0;
			m_StringValue = null;
			Value = luaValue;
		}

		public override String ToString() => Value.ToString();
	}
}
