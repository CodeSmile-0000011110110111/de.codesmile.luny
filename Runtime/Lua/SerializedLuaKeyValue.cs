// Copyright (C) 2021-2025 Steffen Itterheim
// Refer to included LICENSE file for terms and conditions.

using System;
using UnityEditor;
using UnityEngine;

namespace CodeSmile.Luny
{
	[Serializable]
	public sealed class SerializedLuaKeyValue
	{
		[SerializeField] private String m_Key;
		[SerializeField] private SerializedLuaValue m_Value;
		[SerializeField] private Boolean m_IsDuplicateKey;

		public String Key => m_Key;
		public SerializedLuaValue Value => m_Value;
		internal Boolean IsDuplicateKey { get => m_IsDuplicateKey; set => m_IsDuplicateKey = value; }
	}
}
