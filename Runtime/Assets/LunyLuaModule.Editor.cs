// Copyright (C) 2021-2025 Steffen Itterheim
// Refer to included LICENSE file for terms and conditions.

#if UNITY_EDITOR
using Luny.Core;
using System;
using UnityEditor;
using UnityEngine;

namespace Luny
{
	public sealed partial class LunyLuaModule : ISerializationCallbackReceiver
	{
		public void OnBeforeSerialize() {}

		public void OnAfterDeserialize() =>
			// must delay because SerializationUtility & AssetDatabase cannot be used during serialization
			EditorApplication.delayCall += () => UpdateGeneratedReferences();

		public Boolean ContentFolderExists() => String.IsNullOrEmpty(m_ContentFolderGuid) == false &&
		                                        AssetDatabase.IsValidFolder(AssetDatabase.GUIDToAssetPath(m_ContentFolderGuid));

		internal void UpdateGeneratedReferences()
		{
			var needsSaving = ClearMissingSerializeReferenceTypeWarning();

			if (ContentFolderExists())
			{
				if (m_ModuleLoader == null)
				{
					var folderPath = AssetDatabase.GUIDToAssetPath(m_ContentFolderGuid);
					m_ModuleLoader = TryInstantiateType<Loader>(folderPath, m_ModuleLoaderTypeFullName);
					needsSaving = needsSaving || m_ModuleLoader != null;
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

				LuaLogger.LogWarn($"{typeName} not found in {moduleAssembly?.GetName().Name}: {folderPath}");
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
			if (ContentFolderExists() == false)
				m_ContentFolderGuid = null;
			m_ModuleLoader = null;
			m_ModuleLoaderTypeFullName = null;
		}
	}
}
#endif
