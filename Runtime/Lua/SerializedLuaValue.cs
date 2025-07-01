// Copyright (C) 2021-2025 Steffen Itterheim
// Refer to included LICENSE file for terms and conditions.

using Lua;
using System;
using UnityEditor;
using UnityEngine;

namespace CodeSmile.Luny
{
	[Serializable]
	public sealed class SerializedLuaValue
	{
		[SerializeField] private LuaValueType m_ValueType;
		[SerializeField] private Boolean m_BooleanValue;
		[SerializeField] private Double m_NumberValue;
		[SerializeField] private String m_StringValue;

		[Obsolete]
		private LuaValue m_LuaValue;

		public Boolean BooleanValue
		{
			get => m_BooleanValue;
			set
			{
				m_ValueType = LuaValueType.Boolean;
				m_BooleanValue = value;
			}
		}
		public Double NumberValue
		{
			get => m_NumberValue;
			set
			{
				m_ValueType = LuaValueType.Number;
				m_NumberValue = value;
			}
		}
		public String StringValue
		{
			get => m_StringValue;
			set
			{
				m_ValueType = LuaValueType.String;
				m_StringValue = value;
			}
		}

		public LuaValue Value => m_ValueType switch
		{
			LuaValueType.Boolean => new LuaValue(m_BooleanValue),
			LuaValueType.Number => new LuaValue(m_NumberValue),
			LuaValueType.String => m_StringValue != null ? new LuaValue(m_StringValue) : LuaValue.Nil,
			var _ => LuaValue.Nil,
		};

		public override String ToString() => Value.ToString();
	}
}
