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
	public sealed partial class LunyLuaModule : ScriptableObject
	{
		[SerializeField] internal String m_AssemblyName = "";
		[SerializeField][ReadOnlyField] internal String[] m_NamespaceWhitelist = Array.Empty<String>();
		[SerializeField] internal String[] m_NamespaceBlacklist = Array.Empty<String>();
		[SerializeField][ReadOnlyField] internal String[] m_TypeWhitelist = Array.Empty<String>();
		[SerializeField] internal String[] m_TypeBlacklist = Array.Empty<String>();

		[SerializeField] [HideInInspector] private String m_ContentFolderGuid;
		[SerializeField] [HideInInspector] internal String m_ModuleLoaderTypeName;
		[SerializeReference] [HideInInspector] private LunyLuaModuleLoader m_ModuleLoader;

		internal String AssemblyName => m_AssemblyName;
		internal String BindingsNamespace => $"Lua_{m_AssemblyName}";
		internal String[] NamespaceWhitelist => m_NamespaceWhitelist;
		internal String[] TypeWhitelist => m_TypeWhitelist;
		internal String[] NamespaceBlacklist => m_NamespaceBlacklist;
		internal String[] TypeBlacklist => m_TypeBlacklist;

		internal String ContentFolderGuid { get => m_ContentFolderGuid; set => m_ContentFolderGuid = value; }
		internal String ModuleLoaderTypeName { get => m_ModuleLoaderTypeName; set => m_ModuleLoaderTypeName = value; }
		internal LunyLuaModuleLoader ModuleLoader { get => m_ModuleLoader; set => m_ModuleLoader = value; }

		public void Load(LuaState luaState)
		{
#if UNITY_EDITOR
			UpdateModuleLoaderReference();
#endif

			if (ModuleLoader == null)
				Debug.LogError($"Missing loader for LuaModule '{name}'");

			ModuleLoader?.Load(luaState.Environment);
		}
	}
}
