// Copyright (C) 2021-2025 Steffen Itterheim
// Refer to included LICENSE file for terms and conditions.

using CodeSmile;
using System;
using UnityEditor;
using UnityEngine;

namespace Luny
{
	[CreateAssetMenu(fileName = "New LuaModule", menuName = "Luny/Lua Module", order = 101)]
	[Icon("Packages/de.codesmile.luny/Editor/Resources/LunyLuaModuleIcon.png")]
	public sealed partial class LunyLuaModule : ScriptableObject
	{
		[SerializeField] internal String m_AssemblyName = "";
		[SerializeField] [ReadOnlyField] internal String[] m_NamespaceWhitelist = Array.Empty<String>();
		[SerializeField] internal String[] m_NamespaceBlacklist = Array.Empty<String>();
		[SerializeField] [ReadOnlyField] internal String[] m_TypeWhitelist = Array.Empty<String>();
		[SerializeField] internal String[] m_TypeBlacklist = Array.Empty<String>();

		// serialized for runtime, but hidden in Inspector because these are automated
		[SerializeField] [HideInInspector] private String m_ContentFolderGuid;
		[SerializeField] [ReadOnlyField] internal String m_ModuleLoaderTypeFullName;
		[SerializeReference] [HideInInspector] private Loader m_ModuleLoader;

		internal String AssemblyName => m_AssemblyName;
		internal String BindingsAssemblyName => $"Luny.{m_AssemblyName}";
		internal String ScriptingDefineSymbol => BindingsAssemblyName.Replace('.', '_').ToUpper();
		internal String[] NamespaceWhitelist => m_NamespaceWhitelist;
		internal String[] TypeWhitelist => m_TypeWhitelist;
		internal String[] NamespaceBlacklist => m_NamespaceBlacklist;
		internal String[] TypeBlacklist => m_TypeBlacklist;

		internal String ContentFolderGuid { get => m_ContentFolderGuid; set => m_ContentFolderGuid = value; }
		internal String ModuleLoaderTypeFullName { get => m_ModuleLoaderTypeFullName; set => m_ModuleLoaderTypeFullName = value; }
		internal Loader ModuleLoader { get => m_ModuleLoader; set => m_ModuleLoader = value; }

		// Is abstract instead of interface for serialization in LunyLuaModule asset
		[Serializable]
		public abstract class Loader
		{
			public abstract String[] GetNamespaceNames();
			public abstract String[][] GetNamespaceParts();
			public abstract Type[] GetEnumTypes();
			public abstract LuaTypeInfo[] GetBindTypeInfos();
		}

#if UNITY_EDITOR
		[Header("Debug")]
		[Tooltip("Useful to exercise code generation on just a specific type because it may be causing troubles with the generator.")]
		[SerializeField] internal String m_GenerateOnlyThisType;
		[Tooltip("If OnlyThisType is set will only generate bindings for this method (including overloads).")]
		[SerializeField] internal String m_GenerateOnlyThisMethod;
#endif
	}
}
