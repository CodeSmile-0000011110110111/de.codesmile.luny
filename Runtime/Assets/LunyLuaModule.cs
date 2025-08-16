// Copyright (C) 2021-2025 Steffen Itterheim
// Refer to included LICENSE file for terms and conditions.

using Luny.Core;
using System;
using System.Linq;
using System.Reflection;
using UnityEditor;
using UnityEngine;

namespace Luny
{
	internal static class GenMemberFilterExt
	{
		public static Boolean IsBlacklisted(this GenMemberFilter[] filters, MemberInfo memberInfo)
		{
			foreach (var filter in filters)
			{
				if (filter.IsBlacklisted(memberInfo))
					return true;
			}
			return false;
		}

		public static Boolean IsBlacklisted(this GenMemberFilter mf, MemberInfo memberInfo) =>
			memberInfo?.DeclaringType?.FullName == mf.TypeFullName &&
			(mf.BlacklistedMemberNames?.Contains(memberInfo?.Name) ?? false);
	}

	[Serializable] internal struct GenMemberFilter
	{
		public String TypeFullName;
		public String[] BlacklistedMemberNames;
	}

	[Serializable]
	internal sealed class LuaModuleLoaderInfo
	{
		public String AssemblyName;
		public String LoaderVersion;
		public Int32 LoaderHash;
		[SerializeReference] public LunyLuaModule.Loader Loader;
		public override String ToString() => $"LuaModuleLoader for {AssemblyName}: {Loader} ({LoaderHash}, version: {LoaderVersion})";
	}

	[CreateAssetMenu(fileName = "New LuaModule", menuName = "Luny/Lua Module", order = 101)]
	[Icon("Packages/de.codesmile.luny/Editor/Resources/LunyLuaModuleIcon.png")]
	public sealed partial class LunyLuaModule : ScriptableObject
	{
		[SerializeField] internal String m_AssemblyName = "";
		[SerializeField] internal LunyLuaModule[] m_ModuleDependencies = Array.Empty<LunyLuaModule>();
		[SerializeField] [ReadOnlyField] internal String[] m_NamespaceWhitelist = Array.Empty<String>();
		[SerializeField] internal String[] m_NamespaceBlacklist = Array.Empty<String>();
		[SerializeField] [ReadOnlyField] internal String[] m_TypeWhitelist = Array.Empty<String>();
		[SerializeField] internal String[] m_TypeBlacklist = Array.Empty<String>();
		[SerializeField] internal GenMemberFilter[] m_MemberBlacklist = Array.Empty<GenMemberFilter>();

		// serialized for runtime in RuntimeAssetRegistry
		private LuaModuleLoaderInfo m_ModuleLoaderInfo;

		internal String AssemblyName => m_AssemblyName;
		internal String[] NamespaceWhitelist => m_NamespaceWhitelist;
		internal String[] TypeWhitelist => m_TypeWhitelist;
		internal String[] NamespaceBlacklist => m_NamespaceBlacklist;
		internal String[] TypeBlacklist => m_TypeBlacklist;
		internal GenMemberFilter[] MemberBlacklist => m_MemberBlacklist;

		internal Loader ModuleLoader
		{
			get
			{
				if (m_ModuleLoaderInfo == null)
					m_ModuleLoaderInfo = LunyRuntimeAssetRegistry.Singleton.GetRuntimeModuleLoader(AssemblyName);

				if (m_ModuleLoaderInfo?.Loader == null)
					TryInstantiateModuleLoader();

				return m_ModuleLoaderInfo?.Loader;
			}
		}

		internal void TryInstantiateModuleLoader()
		{
#if UNITY_EDITOR
			TryInstantiateModuleLoaderEditorOnly();
#else
			throw new NullReferenceException($"{name}: missing module loader");
#endif
		}

		// Is abstract instead of interface for serialization in LunyLuaModule asset
		[Serializable] public abstract class Loader
		{
			public abstract String Version { get; }
			public abstract String[] GetNamespaceNames();
			public abstract String[][] GetNamespaceParts();
			public abstract Type[] GetEnumTypes();
			public abstract LuaTypeInfo[] GetBindTypeInfos();
		}
	}
}
