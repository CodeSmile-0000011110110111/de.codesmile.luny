// Copyright (C) 2021-2025 Steffen Itterheim
// Refer to included LICENSE file for terms and conditions.

using Luny.Core;
using System;
using UnityEditor;
using UnityEngine;

namespace Luny
{
	public abstract class LunyLuaAsset : ScriptableObject
	{
		[SerializeField] private String m_Path;
		[SerializeField] private String m_Text;

		public String Path { get => m_Path; internal set => m_Path = value; }
		public String FullPath => System.IO.Path.GetFullPath(m_Path).ToForwardSlashes();
		public String Text { get => m_Text; internal set => m_Text = value; }
	}
}
