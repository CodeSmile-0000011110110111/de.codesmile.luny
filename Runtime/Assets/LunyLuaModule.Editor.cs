// Copyright (C) 2021-2025 Steffen Itterheim
// Refer to included LICENSE file for terms and conditions.

#if UNITY_EDITOR
using Luny.Core;
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
		[SerializeField] internal Boolean m_IsEditorModule;

		internal String ModuleLoaderNamespace => $"{BindingsAssemblyName}.Internal";
		internal String ModuleLoaderTypeFullName => $"{ModuleLoaderNamespace}.{ModuleLoaderClassName}";
		internal String BindingsAssemblyName => $"Luny{(IsEditorModule ? "Editor" : "")}.{m_AssemblyName}";
		internal String ScriptingDefineSymbol => BindingsAssemblyName.Replace('.', '_').ToUpper();
		internal Boolean IsEditorModule => m_IsEditorModule;

		private void Awake()
		{
			var modulePath = AssetDatabase.GetAssetPath(this);
			m_IsEditorModule = AssetUtil.IsEditorPath(modulePath) || AssetUtil.IfEditor_IsEditorAssembly(modulePath);

			TryInstantiateModuleLoaderEditorOnly();
		}

		internal String GetContentRootFolderPath() => Path.ChangeExtension(AssetDatabase.GetAssetPath(this), null);

		internal String GetContentVersionFolderPath() => $"{GetContentRootFolderPath()}/{DefineSymbol.MajorMinorUnityVersion}";

		internal Boolean ContentVersionFolderExists() => Directory.Exists(GetContentVersionFolderPath());

		internal void TryInstantiateModuleLoaderEditorOnly()
		{
			m_ModuleLoaderInfo = null;

			if (ContentVersionFolderExists())
			{
				var folderPath = GetContentVersionFolderPath();
				var newInstance = TryInstantiateType<Loader>(folderPath, ModuleLoaderTypeFullName);
				if (newInstance != null)
				{
					m_ModuleLoaderInfo = new LuaModuleLoaderInfo
					{
						AssemblyName = AssemblyName,
						LoaderVersion = newInstance.Version,
						LoaderHash = newInstance.GetHashCode(),
						Loader = newInstance,
					};

					if (IsEditorModule == false)
					{
						var assetRegistry = LunyRuntimeAssetRegistry.Singleton;
						assetRegistry.SetRuntimeModuleLoader(m_ModuleLoaderInfo);
						assetRegistry.Save();
					}

					Debug.Log($"{name}: Instantiated {m_ModuleLoaderInfo}");
				}
			}
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
				var moduleAssembly = AssetUtil.IfEditor_GetAssemblyForPath(folderPath);
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

		public void InvalidateModuleLoader()
		{
			m_ModuleLoaderInfo?.Reset();
			if (IsEditorModule == false)
				LunyRuntimeAssetRegistry.Singleton.Save();
		}
	}
}
#endif
