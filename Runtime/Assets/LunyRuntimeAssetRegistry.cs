// Copyright (C) 2021-2025 Steffen Itterheim
// Refer to included LICENSE file for terms and conditions.

using Luny.Core;
using System;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

namespace Luny
{
	public interface ILunyRuntimeAssetRegistry
	{
		LunyLuaAssetCollection RuntimeLuaAssets { get; }
		LunyLuaAssetCollection ModdingLuaAssets { get; }
		LunyLuaAsset GetRuntimeLuaAsset(String assetPath);
		LunyLuaAsset GetModdingLuaAsset(String assetPath);
	}

	/// <summary>
	/// Maintains a list of project-wide LuaAsset (*.lua) assets in support of 'load bundled script by name/path'.
	/// </summary>
	[Icon("Packages/de.codesmile.luny/Editor/Resources/LunyAssetRegistryIcon.png")]
	public sealed class LunyRuntimeAssetRegistry : ScriptableObject, ILunyRuntimeAssetRegistry
	{
		private static LunyRuntimeAssetRegistry s_Singleton;
		private static Boolean s_SingletonAssigned;

		[Header("Fully automated registry (read-only)")]
		[SerializeField] [ReadOnlyField] private LunyLuaContext m_RuntimeContext;
		[SerializeField] [ReadOnlyField] private LunyLuaContext m_ModdingContext;
		[SerializeField] [ReadOnlyField] private List<LuaModuleLoaderInfo> m_RuntimeModuleLoaders = new();

		[SerializeField] [ReadOnlyField] private LunyLuaAssetCollection m_RuntimeAutoRunLuaAssets = new();
		[SerializeField] [ReadOnlyField] private LunyLuaAssetCollection m_RuntimeLuaAssets = new();
		[SerializeField] [ReadOnlyField] private LunyLuaAssetCollection m_ModdingAutoRunLuaAssets = new();
		[SerializeField] [ReadOnlyField] private LunyLuaAssetCollection m_ModdingLuaAssets = new();

		public LunyLuaContext RuntimeContext { get => m_RuntimeContext; set => m_RuntimeContext = value; }
		public LunyLuaContext ModdingContext { get => m_ModdingContext; set => m_ModdingContext = value; }

		public LunyLuaAssetCollection RuntimeAutoRunLuaAssets
		{
			get => m_RuntimeAutoRunLuaAssets;
			internal set => m_RuntimeAutoRunLuaAssets = value;
		}
		public LunyLuaAssetCollection ModdingAutoRunLuaAssets
		{
			get => m_ModdingAutoRunLuaAssets;
			internal set => m_ModdingAutoRunLuaAssets = value;
		}
		public LunyLuaAssetCollection RuntimeLuaAssets => m_RuntimeLuaAssets;
		public LunyLuaAssetCollection ModdingLuaAssets => m_ModdingLuaAssets;

		public static LunyRuntimeAssetRegistry Singleton
		{
			get => s_SingletonAssigned ? s_Singleton : LoadFromResources();
			internal set
			{
				s_Singleton = value;
				s_SingletonAssigned = s_Singleton != null;
			}
		}

		internal static LunyRuntimeAssetRegistry LoadFromResources() =>
			Singleton = Resources.Load<LunyRuntimeAssetRegistry>(nameof(LunyRuntimeAssetRegistry));

		[RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.SubsystemRegistration)]
		private static void ResetSingletonFields()
		{
			s_Singleton = null;
			s_SingletonAssigned = false;
		}

		public LunyLuaAsset GetRuntimeLuaAsset(String assetPath)
		{
			var index = m_RuntimeLuaAssets.Paths.IndexOf(assetPath);
			return index >= 0 ? m_RuntimeLuaAssets.Assets[index] : null;
		}

		public LunyLuaAsset GetModdingLuaAsset(String assetPath)
		{
			var index = m_ModdingLuaAssets.Paths.IndexOf(assetPath);
			return index >= 0 ? m_ModdingLuaAssets.Assets[index] : null;
		}

		private void OnDestroy()
		{
			if (s_Singleton == this)
				ResetSingletonFields();
		}

		internal LuaModuleLoaderInfo GetRuntimeModuleLoader(String moduleAssemblyName)
		{
			foreach (var moduleLoader in m_RuntimeModuleLoaders)
			{
				if (moduleLoader.AssemblyName == moduleAssemblyName && moduleLoader.Loader != null)
					return moduleLoader;
			}
			return null;
		}

		internal void SetRuntimeModuleLoader(LuaModuleLoaderInfo luaModuleLoaderInfo)
		{
			// try replace existing first
			for (var i = 0; i < m_RuntimeModuleLoaders.Count; i++)
			{
				if (m_RuntimeModuleLoaders[i].AssemblyName == luaModuleLoaderInfo.AssemblyName)
				{
					m_RuntimeModuleLoaders[i] = luaModuleLoaderInfo;
					return;
				}
			}

			// otherwise add it
			m_RuntimeModuleLoaders.Add(luaModuleLoaderInfo);
		}

		internal void Save()
		{
#if UNITY_EDITOR
			// delay to avoid "worker: import error code (4)" when called from ctor/InitOnLoad
			EditorApplication.delayCall += () =>
			{
				if (Singleton != null)
				{
					EditorUtility.SetDirty(Singleton);
					AssetDatabase.SaveAssetIfDirty(Singleton);
				}
			};
#endif
		}
	}
}
