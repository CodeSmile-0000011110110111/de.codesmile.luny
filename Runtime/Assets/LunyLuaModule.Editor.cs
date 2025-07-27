// Copyright (C) 2021-2025 Steffen Itterheim
// Refer to included LICENSE file for terms and conditions.

using System;
using UnityEditor;
using UnityEngine;

namespace CodeSmile.Luny
{
	public sealed partial class LunyLuaModule
#if UNITY_EDITOR
		: ISerializationCallbackReceiver
#endif
	{
#if UNITY_EDITOR
		public void OnBeforeSerialize() {}

		public void OnAfterDeserialize() =>
			// must delay because SerializationUtility & AssetDatabase cannot be used during serialization
			EditorApplication.delayCall += () => UpdateGeneratedReferences();

		private void UpdateGeneratedReferences()
		{
			var needsSaving = ClearMissingSerializeReferenceTypeWarning();

			var folderPath = AssetDatabase.GUIDToAssetPath(m_ContentFolderGuid);
			if (AssetDatabase.IsValidFolder(folderPath))
			{
				if (m_ModuleLoader == null)
				{
					m_ModuleLoader = TryInstantiateType<LunyLuaModuleLoader>(folderPath, m_ModuleLoaderTypeName);
					needsSaving = needsSaving || m_ModuleLoader != null;
				}
				if (m_UnityUnityObjectFactory == null)
				{
					m_UnityUnityObjectFactory = TryInstantiateType<LuaUnityObjectFactoryBase>(folderPath, m_UnityObjectFactoryTypeName);
					needsSaving = needsSaving || m_UnityUnityObjectFactory != null;
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
				var moduleAssembly = EditorAssetUtility.GetAssemblyForAssetPath(folderPath);
				if (moduleAssembly != null)
				{
					var type = moduleAssembly.GetType(typeName);
					if (type != null)
						return Activator.CreateInstance(type) as T;
				}
			}

			LunyLogger.LogWarn($"Generated type '{typeName}' not found in: {folderPath}");
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
			m_ModuleLoader = null;
			m_ModuleLoaderTypeName = null;
			m_UnityUnityObjectFactory = null;
			m_UnityObjectFactoryTypeName = null;
		}
#endif
	}
}
