// Copyright (C) 2021-2025 Steffen Itterheim
// Refer to included LICENSE file for terms and conditions.

using System;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

namespace CodeSmileEditor.Luny
{
	public sealed class LunyLuaModuleEditorData : ScriptableObject
	{
		[SerializeField] private String m_Label = "Hey ho!";
		public String Label
		{
			get => m_Label;
			set => m_Label = value;
		}

		public List<string> m_AssemblyNames = new();
		public List<String> AssemblyNames
		{
			get => m_AssemblyNames;
			set => m_AssemblyNames = value;
		}
		//public List<AssemblyItem> m_AssemblyNames = new();

		[Serializable] public struct AssemblyItem
		{
			[SerializeField] private String m_Name;
			public String Name
			{
				get => m_Name;
				set => m_Name = value;
			}

			public AssemblyItem(String name) => m_Name = name;
		}
	}
}
