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
			// must delay because AssetDatabase cannot be used during serialization
			EditorApplication.delayCall += () => UpdateModuleLoaderReference();

		private void UpdateModuleLoaderReference()
		{
			ClearMissingSerializeReferenceTypeWarning();

			var loader = TryInstantiateModuleLoader(m_ContentFolderGuid, m_ModuleLoaderTypeName);
			if (m_ModuleLoader != loader)
			{
				m_ModuleLoader = loader;
				EditorUtility.SetDirty(this);
			}
		}

		private LunyLuaModuleLoader TryInstantiateModuleLoader(String folderGuid, String loaderTypeName)
		{
			var folder = AssetDatabase.GUIDToAssetPath(folderGuid);
			if (AssetDatabase.IsValidFolder(folder) == false || String.IsNullOrEmpty(loaderTypeName))
				return null;

			LunyLuaModuleLoader moduleLoader = null;
			var loaderAssembly = EditorAssetUtility.GetAssemblyForAssetPath(folder);
			if (loaderAssembly != null)
			{
				var loaderType = loaderAssembly?.GetType(loaderTypeName);
				if (loaderType != null)
					moduleLoader = Activator.CreateInstance(loaderType) as LunyLuaModuleLoader;
				else
					LunyLogger.LogWarn($"Module loader type '{loaderTypeName}' not found in {loaderAssembly.FullName}");
			}
			else
				LunyLogger.LogWarn($"Assembly not found for path: {folder}");

			return moduleLoader;
		}

		private void ClearMissingSerializeReferenceTypeWarning()
		{
			// this may occur if the user manually deletes the generated scripts
			if (SerializationUtility.HasManagedReferencesWithMissingTypes(this))
			{
				SerializationUtility.ClearAllManagedReferencesWithMissingTypes(this);
				m_ModuleLoader = null;
				m_ModuleLoaderTypeName = null;
				EditorUtility.SetDirty(this);
			}
		}
#endif
	}
}
