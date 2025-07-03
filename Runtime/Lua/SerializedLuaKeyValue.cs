// Copyright (C) 2021-2025 Steffen Itterheim
// Refer to included LICENSE file for terms and conditions.

using Lua;
using System;
using UnityEditor;
using UnityEngine;

namespace CodeSmile.Luny
{
	[Serializable]
	public struct SerializedLuaKeyValue
	{
		[SerializeField] private String m_Key;
		[SerializeField] private SerializedLuaValue m_Value;
		public SerializedLuaKeyValue(LuaValue key, LuaValue value)
		{
			m_Key = key.ToString();
			m_Value = new SerializedLuaValue(value);
		}

		public String Key => m_Key;
		public SerializedLuaValue Value => m_Value;
	}
}
