// Copyright (C) 2021-2025 Steffen Itterheim
// Refer to included LICENSE file for terms and conditions.

using Lua;
using System;
using UnityEditor;
using UnityEngine;

namespace Luny
{
	[Serializable]
	public struct SerializableLuaKeyValuePair
	{
		[SerializeField] private String m_Key;
		[SerializeField] private SerializableLuaValue m_Value;

		public String Key => m_Key;
		public SerializableLuaValue Value => m_Value;

		public SerializableLuaKeyValuePair(LuaValue key, LuaValue value)
		{
			m_Key = key.ToString();
			m_Value = new SerializableLuaValue(value);
		}
	}
}
