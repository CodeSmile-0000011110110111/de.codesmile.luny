// Copyright (C) 2021-2025 Steffen Itterheim
// Refer to included LICENSE file for terms and conditions.

#if UNITY_EDITOR
using Luny.Core;
using LunyEditor.Core;
using System;
using System.IO;
using UnityEditor;
using UnityEngine;
using Directory = UnityEngine.Windows.Directory;

namespace Luny
{
	public sealed partial class LunyLuaModule
	{
		internal const String ModuleLoaderClassName = "ModuleLoader";

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
			Debug.Log($"{name}: Awake");
			SerializationUtility.ClearAllManagedReferencesWithMissingTypes(this);
			ClearGeneratedTypeReferences();
			TryInstantiateModuleLoaderEditorOnly();
		}

		private void OnEnable() => Debug.Log($"{name}: OnEnable");

		internal String GetContentRootFolderPath() => Path.ChangeExtension(AssetDatabase.GetAssetPath(this), null);

		internal String GetContentVersionFolderPath() => $"{GetContentRootFolderPath()}/{DefineSymbol.MajorMinorUnityVersion}";

		internal Boolean ContentVersionFolderExists() => Directory.Exists(GetContentVersionFolderPath());

		internal Loader TryInstantiateModuleLoaderEditorOnly()
		{
			var wasNull = m_ModuleLoader == null;

			if (ContentVersionFolderExists())
			{
				var folderPath = GetContentVersionFolderPath();
				m_ModuleLoader = TryInstantiateType<Loader>(folderPath, ModuleLoaderTypeFullName);

				// delayed to avoid "Import Error Code:(4)" warning spam
				EditorApplication.delayCall += () => SaveAsset();
			}

			var prevVersion = m_ModuleLoaderVersion;
			m_ModuleLoaderVersion = m_ModuleLoader != null ? m_ModuleLoader.Version : "(null)";

			if (m_ModuleLoader != null && (wasNull || prevVersion != m_ModuleLoaderVersion))
				Debug.Log($"{name}: Instantiated {m_ModuleLoader}, version {m_ModuleLoaderVersion}, hash: {m_ModuleLoader.GetHashCode()}");

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

		internal void ClearGeneratedTypeReferences()
		{
			m_ModuleLoader = null;
			m_ModuleLoaderVersion = null;
		}
	}
}
#endif
