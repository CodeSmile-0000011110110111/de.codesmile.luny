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
		[SerializeField] internal String m_AssemblyName = "";
		[SerializeField] internal String[] m_NamespaceWhitelist = Array.Empty<String>();
		[SerializeField] internal String[] m_TypeWhitelist = Array.Empty<String>();

		[SerializeField] [HideInInspector] private String m_ContentFolderGuid;
		[SerializeReference] [HideInInspector] private LunyLuaModuleLoader m_ModuleLoader;

		internal String AssemblyName => m_AssemblyName;
		internal String[] NamespaceWhitelist => m_NamespaceWhitelist;
		internal String[] TypeWhitelist => m_TypeWhitelist;

		internal String ContentFolderGuid { get => m_ContentFolderGuid; set => m_ContentFolderGuid = value; }
		internal LunyLuaModuleLoader ModuleLoader { get => m_ModuleLoader; set => m_ModuleLoader = value; }

		public void Load(LuaState luaState)
		{
			if (ModuleLoader != null)
				Debug.LogWarning($"Missing loader for LuaModule '{name}'");
			//Debug.Assert(m_ModuleLoader != null, $"Missing loader for LuaModule '{name}'");

			ModuleLoader?.Load(luaState.Environment);
		}
	}
}
