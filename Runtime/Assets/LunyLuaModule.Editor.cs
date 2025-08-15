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
		[SerializeField] internal String m_GenerateOnlyThisMember;
		[SerializeField] [ReadOnlyField] private String m_ModuleLoaderVersion;

		internal String NamespaceName => $"{BindingsAssemblyName}.Internal";
		internal String ModuleLoaderTypeFullName => $"{NamespaceName}.{ModuleLoaderClassName}";
		internal String BindingsAssemblyName => $"Luny{(IsEditorModule ? "Editor" : "")}.{m_AssemblyName}";
		internal String ScriptingDefineSymbol => BindingsAssemblyName.Replace('.', '_').ToUpper();

		internal Boolean IsEditorModule
		{
			get
			{
				var modulePath = AssetDatabase.GetAssetPath(this);
				return EditorAssetUtil.IsEditorPath(modulePath) || EditorAssetUtil.IsEditorAssembly(modulePath);
			}
		}

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
			var prevLoader = m_ModuleLoader;
			var needsSaving = false;

			if (ContentVersionFolderExists())
			{
				var folderPath = GetContentVersionFolderPath();
				var newInstance = TryInstantiateType<Loader>(folderPath, ModuleLoaderTypeFullName);
				if (newInstance != null && (m_ModuleLoader == null || newInstance.Version != m_ModuleLoader.Version))
				{
					m_ModuleLoader = newInstance;
					needsSaving = true;
				}
			}

			var prevVersion = m_ModuleLoaderVersion;
			m_ModuleLoaderVersion = m_ModuleLoader != null ? m_ModuleLoader.Version : "";

			// delayed to avoid "Import Error Code:(4)" warning spam
			if (needsSaving)
				EditorApplication.delayCall += () => SaveAsset();

			if (m_ModuleLoader != null && (m_ModuleLoader != prevLoader || m_ModuleLoaderVersion != prevVersion))
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
