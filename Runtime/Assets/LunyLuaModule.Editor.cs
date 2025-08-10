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
	public sealed partial class LunyLuaModule : ISerializationCallbackReceiver
	{
		[Header("Debug")]
		[Tooltip("Useful to exercise code generation on just a specific type because it may be causing troubles with the generator.")]
		[SerializeField] internal String m_GenerateOnlyThisType;
		[Tooltip("If OnlyThisType is set will only generate bindings for this method (including overloads).")]
		[SerializeField] internal String m_GenerateOnlyThisMethod;

		public void OnBeforeSerialize() {}

		public void OnAfterDeserialize() =>
			// must delay because SerializationUtility & AssetDatabase cannot be used during serialization
			EditorApplication.delayCall += () => UpdateGeneratedReferences();

		internal String GetContentRootFolderPath() => AssetDatabase.GUIDToAssetPath(m_ContentRootFolderGuid);
		internal String GetContentVersionFolderPath(String rootPath) => $"{rootPath}/{DefineSymbol.MajorMinorUnityVersion}";
		internal Boolean ContentVersionFolderExists() => AssetDatabase.IsValidFolder(GetContentVersionFolderPath(GetContentRootFolderPath()));

		internal void UpdateGeneratedReferences()
		{
			var needsSaving = ClearMissingSerializeReferenceTypeWarning();

			if (ContentVersionFolderExists())
			{
				if (m_ModuleLoader == null && String.IsNullOrEmpty(m_ModuleLoaderTypeFullName) == false)
				{
					var folderPath = GetContentVersionFolderPath(GetContentRootFolderPath());
					m_ModuleLoader = TryInstantiateType<Loader>(folderPath, m_ModuleLoaderTypeFullName);
					Debug.Assert(m_ModuleLoader != null, $"{m_ModuleLoaderTypeFullName} not found in: {folderPath}");
					needsSaving = needsSaving || m_ModuleLoader != null;

					if (m_ModuleLoader != null)
						m_ModuleLoaderAssemblyName = m_ModuleLoader.GetType().Assembly.GetName().Name;
				}

				if (needsSaving)
					SaveAsset();
			}
		}

		internal void SaveAsset()
		{
			EditorUtility.SetDirty(this);
			AssetDatabase.SaveAssetIfDirty(this);
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

		private Boolean ClearMissingSerializeReferenceTypeWarning()
		{
			// this may occur if the user manually deletes the generated scripts
			if (SerializationUtility.HasManagedReferencesWithMissingTypes(this) == false)
				return false;

			SerializationUtility.ClearAllManagedReferencesWithMissingTypes(this);
			ClearGeneratedTypeReferences();
			return true;
		}

		internal void ClearGeneratedTypeReferences()
		{
			if (ContentVersionFolderExists() == false)
				m_ContentRootFolderGuid = null;
			m_ModuleLoader = null;
			m_ModuleLoaderTypeFullName = null;
			m_ModuleLoaderAssemblyName = null;
		}
	}
}
#endif
