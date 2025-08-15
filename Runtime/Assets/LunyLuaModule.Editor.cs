// Copyright (C) 2021-2025 Steffen Itterheim
// Refer to included LICENSE file for terms and conditions.

#if UNITY_EDITOR
using Luny.Core;
using LunyEditor.Core;
using System;
using UnityEditor;
using UnityEngine;

namespace Luny
{
	public sealed partial class LunyLuaModule
	{
		internal const String ModuleLoaderClassName = "ModuleLoader";
		private static readonly String s_UnityMajorMinorVersion = Application.unityVersion.Substring(0, "6000.0".Length);

		[Header("Debug")]
		[Tooltip("Useful to exercise code generation on just a specific type because it may be causing troubles with the generator.")]
		[SerializeField] internal String m_GenerateOnlyThisType;
		[Tooltip("If OnlyThisType is set will only generate bindings for this method (including overloads).")]
		[SerializeField] internal String m_GenerateOnlyThisMethod;
		[SerializeField] [ReadOnlyField] private String m_ModuleLoaderVersion;

		internal String NamespaceName => $"{BindingsAssemblyName}.Internal";
		internal String ModuleLoaderTypeFullName => $"{NamespaceName}.{ModuleLoaderClassName}";

		private void Awake()
		{
			Debug.Log($"{name}: {nameof(Awake)}");
			ClearMissingSerializeReferenceTypeWarning();
			TryInstantiateModuleLoaderEditorOnly();
		}

		private void OnEnable() => m_ModuleLoaderVersion = m_ModuleLoader != null ? m_ModuleLoader.Version : "(null)";

		internal String GetContentRootFolderPath() => AssetDatabase.GUIDToAssetPath(m_ContentRootFolderGuid);
		internal String GetContentVersionFolderPath(String rootPath) => $"{rootPath}/{DefineSymbol.MajorMinorUnityVersion}";
		internal Boolean ContentVersionFolderExists() => AssetDatabase.IsValidFolder(GetContentVersionFolderPath(GetContentRootFolderPath()));

		internal Loader TryInstantiateModuleLoaderEditorOnly()
		{
			if (ContentVersionFolderExists())
			{
				var folderPath = GetContentVersionFolderPath(GetContentRootFolderPath());
				m_ModuleLoader = TryInstantiateType<Loader>(folderPath, ModuleLoaderTypeFullName);

				if (m_ModuleLoader != null)
				{
					m_ModuleLoaderVersion = m_ModuleLoader.Version;
					Debug.Log($"{name}: Instantiated {m_ModuleLoader}, version {m_ModuleLoaderVersion}, hash: {m_ModuleLoader.GetHashCode()}");
				}

				SaveAsset();
			}

			return m_ModuleLoader;
		}

		internal void SaveAsset()
		{
			try
			{
				EditorUtility.SetDirty(this);
				AssetDatabase.SaveAssetIfDirty(this);
			}
			catch (MissingReferenceException e)
			{
				Debug.LogWarning($"{nameof(LunyLuaModule)} 'missing ref' ignored, probably caused by switching editor versions: {e}");
			}
		}

		private T TryInstantiateType<T>(String folderPath, String typeName) where T : class
		{
			if (String.IsNullOrEmpty(typeName) == false)
			{
				var moduleAssembly = AssetUtil.IfEditorGetAssemblyForPath(folderPath);
				if (moduleAssembly != null)
				{
					var type = moduleAssembly.GetType(typeName);
					if (type != null)
						return Activator.CreateInstance(type) as T;
				}

				//LuaLogger.LogWarn($"{typeName} not found in {moduleAssembly?.GetName().Name}: {folderPath}");
			}

			return default;
		}

		private void ClearMissingSerializeReferenceTypeWarning()
		{
			// this may occur if the user manually deletes the generated scripts
			if (SerializationUtility.HasManagedReferencesWithMissingTypes(this) == false)
				return;

			Debug.LogWarning($"{name}: Clearing missing serialization references ..");
			SerializationUtility.ClearAllManagedReferencesWithMissingTypes(this);
			ClearGeneratedTypeReferences();
			SaveAsset();
		}

		internal void ClearGeneratedTypeReferences()
		{
			Debug.Log($"{name}: clearing generated type references, they might be outdated ..");

			if (ContentVersionFolderExists() == false)
				m_ContentRootFolderGuid = null;
			m_ModuleLoader = null;
			m_ModuleLoaderVersion = null;
		}
	}
}
#endif
