// Copyright (C) 2021-2025 Steffen Itterheim
// Refer to included LICENSE file for terms and conditions.

using CodeSmile.Utility;
using Lua;
using System;
using UnityEditor;
using UnityEngine;

namespace CodeSmile.Luny
{
	public interface ILuaModule
	{
		void LoadModule(LuaState luaState);
	}

	[CreateAssetMenu(fileName = "New LuaModule", menuName = "Luny/LuaModule", order = 101)]
	[Icon("Packages/de.codesmile.luny/Editor/Resources/LunyLuaModuleIcon.png")]
	public class LunyLuaModule : ScriptableObject, ILuaModule
	{
		[SerializeField] [ReadOnlyField] private String m_ModuleName = "";
		[SerializeField] private String m_Namespace = "System";
		[SerializeReference] [HideInInspector] private LuaModuleLoader m_ModuleLoader;

		public void LoadModule(LuaState luaState)
		{
			Debug.Assert(m_ModuleLoader != null, $"Missing loader for LuaModule '{name}'");
			m_ModuleLoader?.Load(luaState.Environment);
		}
	}
}
