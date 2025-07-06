// Copyright (C) 2021-2025 Steffen Itterheim
// Refer to included LICENSE file for terms and conditions.

using Lua;
using System;
using UnityEditor;
using UnityEngine;

namespace CodeSmile.Luny
{
	[CreateAssetMenu(fileName = "New LuaModule", menuName = "Luny/Lua Module", order = 101)]
	[Icon("Packages/de.codesmile.luny/Editor/Resources/LunyLuaModuleIcon.png")]
	public sealed class LunyLuaModule : ScriptableObject
	{
		[SerializeField] private String m_AssemblyName = "";
		[SerializeField] private String[] m_ExportedTypes = new String[0];

		[SerializeReference] [HideInInspector] private LunyLuaModuleLoader m_ModuleLoader;

		public void Load(LuaState luaState)
		{
			if (m_ModuleLoader != null)
				Debug.LogWarning($"Missing loader for LuaModule '{name}'");
			//Debug.Assert(m_ModuleLoader != null, $"Missing loader for LuaModule '{name}'");

			m_ModuleLoader?.Load(luaState.Environment);
		}
	}
}
