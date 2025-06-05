// Copyright (C) 2021-2025 Steffen Itterheim
// Refer to included LICENSE file for terms and conditions.

using Lua;
using UnityEditor;
using UnityEngine.UIElements;

namespace CodeSmileEditor.Luny
{
	[CustomEditor(typeof(LuaModule))]
	internal class LuaModuleEditor : Editor
	{
		public override VisualElement CreateInspectorGUI()
		{

			return base.CreateInspectorGUI();
		}
	}
}
/*
// Copyright (C) 2021-2025 Steffen Itterheim
// Refer to included LICENSE file for terms and conditions.

#if UNITY_EDITOR
using CodeSmile.CSharp;
using CodeSmile.Extensions.System;
using CodeSmile.Utility;
using CodeSmileEditor.Core;
using Lua;
using Lua.Unity;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using Unity.Profiling;
using UnityEditor;
using UnityEditor.Compilation;
using UnityEngine;
using UnityEngine.UIElements;
using Assembly = System.Reflection.Assembly;

namespace CodeSmile.Luny
{
	public partial class LuaModule : ISerializationCallbackReceiver // for post-compilation updates
	{
		private const String ConfigLua = "LuaBindingsConfig";
		private const String AuxiliaryLua = "LuaBindingsAuxiliary";
		private const String GeneratorLua = "LuaBindingsGenerator";

		[Header("Binding Choice")]
		[SerializeField] private Boolean m_BindAll;
		[SerializeField] private String m_BindThisTypeOnly;
		[SerializeField] private List<String> m_BindByTypeNames = new();
		[SerializeField] private List<BindTypeInfo> m_BoundTypes = new();

		[Header("For Reference")]
		[SerializeField] private List<String> m_NamespaceStaticClasses = new();
		[SerializeField] private List<String> m_NamespaceClasses = new();
		[SerializeField] private List<String> m_NamespaceStructs = new();
		[SerializeField] private List<String> m_NamespaceEnums = new();
		[SerializeField] private List<String> m_NamespaceUnsupportedTypes = new();

		[Header("Debug")]
		[SerializeField] [ReadOnlyField] private Boolean m_HasModuleLoader;
		[SerializeField] [ReadOnlyField] private String m_ModuleLoaderTypeFullName;
		[SerializeField] [ReadOnlyField] private String m_GeneratedScriptsPathGuid;

		private static LuaAsset GetScript(String scriptName) => LuaAssetRegistry.FindOrCreate().GetScript(scriptName);

		private static async Task<LuaValue[]> RunLuaGenerator(ILunyLua lua, String infoKey, LuaTable info)
		{
			lua.State.Environment[infoKey] = info;

			var configScript = GetScript(ConfigLua);
			await lua.DoStringAsync(configScript.Text, configScript.name);

			var auxScript = GetScript(AuxiliaryLua);
			await lua.DoStringAsync(auxScript.Text, auxScript.name);

			var generatorScript = GetScript(GeneratorLua);
			var results = await lua.DoStringAsync(generatorScript.Text, generatorScript.name);

			lua.State.Environment[infoKey] = LuaValue.Nil;
			return results;
		}

		public void OnBeforeSerialize() {}

		public void OnAfterDeserialize() => EditorApplication.delayCall += () =>
		{
			ClearMissingSerializeReferenceTypeWarning();
			TryAssignModuleLoader();
		};

		private void OnValidate()
		{
			m_ModuleName = name.SanitizeIdentifier();

			UpdateBindTypes();
			UpdateNamespaceTypesForReference();
		}

		private void TryAssignModuleLoader()
		{
			if (!String.IsNullOrEmpty(m_GeneratedScriptsPathGuid) && !String.IsNullOrEmpty(m_ModuleLoaderTypeFullName))
				m_ModuleLoader = TryInstantiateModuleLoader(m_GeneratedScriptsPathGuid, m_ModuleLoaderTypeFullName);

			m_HasModuleLoader = m_ModuleLoader != null;
		}

		private void UpdateBindTypes()
		{
			m_BoundTypes.Clear();

			var assemblies = AppDomain.CurrentDomain.GetAssemblies();

			HashSet<String> typesToBind;
			if (String.IsNullOrWhiteSpace(m_BindThisTypeOnly) == false)
				typesToBind = new HashSet<String> { m_BindThisTypeOnly };
			else if (m_BindAll)
				typesToBind = new HashSet<String>(GetTypeNamesInNamespace(m_Namespace));
			else
				typesToBind = new HashSet<String>(m_BindByTypeNames);

			foreach (var typeName in typesToBind)
			{
				var typeFullName = $"{m_Namespace}.{typeName}";

				foreach (var assembly in assemblies.Reverse())
				{
					var type = assembly.GetType(typeFullName);
					if (type != null && type.IsInterface == false &&
					    type.BaseType != typeof(Attribute) && type.BaseType != typeof(Exception))
					{
						var typeInfo = new BindTypeInfo
						{
							AssemblyQualifiedName = type.AssemblyQualifiedName,
							Type = type,
						};
						m_BoundTypes.Add(typeInfo);
						break;
					}
				}
			}

			m_BoundTypes.Sort((a, b) => a.AssemblyQualifiedName.CompareTo(b.AssemblyQualifiedName));
		}

		private IEnumerable<String> GetTypeNamesInNamespace(String ns)
		{
			var typeNames = new List<String>();
			var assemblies = AppDomain.CurrentDomain.GetAssemblies();
			foreach (var assembly in assemblies)
			{
				try
				{
					var types = assembly.GetExportedTypes();
					foreach (var type in types)
					{
						if (type.Namespace == m_Namespace)
							typeNames.Add(type.Name);
					}
				}
				catch (Exception e) {}
			}
			return typeNames;
		}

		private void UpdateNamespaceTypesForReference()
		{
			m_NamespaceStaticClasses.Clear();
			m_NamespaceClasses.Clear();
			m_NamespaceStructs.Clear();
			m_NamespaceEnums.Clear();
			m_NamespaceUnsupportedTypes.Clear();

			var assemblies = AppDomain.CurrentDomain.GetAssemblies();
			foreach (var assembly in assemblies)
			{
				try
				{
					var types = assembly.GetExportedTypes();
					foreach (var type in types)
					{
						if (type.Namespace == m_Namespace)
						{
							if (type.IsEnum)
								m_NamespaceEnums.Add(type.Name);
							else if (type.IsClass && !type.Name.EndsWith("Exception") && !type.Name.EndsWith("Attribute"))
							{
								if (type.IsAbstract && type.IsSealed)
									m_NamespaceStaticClasses.Add(type.Name);
								else
									m_NamespaceClasses.Add(type.Name);
							}
							else if (type.IsValueType)
								m_NamespaceStructs.Add(type.Name);
							else
								m_NamespaceUnsupportedTypes.Add(type.Name);
						}
					}
				}
				catch (Exception e) {}
			}

			m_NamespaceStaticClasses.Sort();
			m_NamespaceClasses.Sort();
			m_NamespaceStructs.Sort();
			m_NamespaceEnums.Sort();
			m_NamespaceUnsupportedTypes.Sort();
		}

		private void ClearMissingSerializeReferenceTypeWarning()
		{
			// this may occur if the user manually deletes the generated scripts
			if (SerializationUtility.HasManagedReferencesWithMissingTypes(this))
			{
				SerializationUtility.ClearAllManagedReferencesWithMissingTypes(this);
				m_ModuleLoader = null;
			}
		}

		public void DeleteBindingsFolder()
		{
			var generatePath = AssetDatabase.GUIDToAssetPath(m_GeneratedScriptsPathGuid);
			if (AssetDatabase.IsValidFolder(generatePath))
				AssetDatabase.DeleteAsset(generatePath);
		}

		internal async Task GenerateBindings(ILunyLua lua)
		{
			try
			{
				var marker = new ProfilerMarker("Lua Binding Generator");
				marker.Begin(this);

				AssetDatabase.StartAssetEditing();

				var (generatePath, pathGuid) = GetOrCreatePathForGeneratedScripts(m_GeneratedScriptsPathGuid);
				m_GeneratedScriptsPathGuid = pathGuid;

				var moduleInfo = CreateModuleInfo(generatePath);
				var results = await RunLuaGenerator(lua, "ModuleInfo", moduleInfo);

				var returnInfo = results[0].Read<LuaTable>();
				m_ModuleLoaderTypeFullName = returnInfo["ModuleLoaderTypeName"].Read<String>();
				m_ModuleLoaderTypeFullName = $"{GetAssemblyRootNamespace(generatePath)}.{m_ModuleLoaderTypeFullName}";

				TryAssignModuleLoader();

				marker.End();
			}
			finally
			{
				// ensure the generated path's GUID is serialized before compiling because we will need that path right after
				EditorUtility.SetDirty(this);
				AssetDatabase.SaveAssetIfDirty(this);

				AssetDatabase.StopAssetEditing();

				// faster than calling ImportAsset() on each file when creating many files in Start/Stop 'batch' manner
				// just pointing this out because I keep telling people to NOT use Refresh indiscriminately. ;)
				AssetDatabase.Refresh();
			}
		}

		private LuaTable CreateModuleInfo(String generatePath)
		{
			var moduleInfo = new LuaTable();
			moduleInfo["Path"] = generatePath;
			moduleInfo["FullPath"] = EditorIO.GetFullPathFromAssetPath(generatePath);
			moduleInfo["ModuleName"] = m_ModuleName;
			moduleInfo["ModuleNamespace"] = m_Namespace;
			var asmdefNamespace = CompilationPipeline.GetAssemblyRootNamespaceFromScriptPath(generatePath);
			Debug.Assert(!String.IsNullOrEmpty(asmdefNamespace),
				$"Module {name} has no RootNamespace defined in Assembly Definition!");
			moduleInfo["Namespace"] = asmdefNamespace;

			var names = m_Namespace.Split('.');
			var namespaceNames = new LuaTable();
			for (var i = 0; i < names.Length; i++)
				namespaceNames[i + 1] = names[i];
			moduleInfo["NamespaceNames"] = namespaceNames;

			var typesTable = new LuaTable();
			moduleInfo["Types"] = typesTable;

			var typeIndex = 0;
			foreach (var boundType in m_BoundTypes)
			{
				var memberTable = boundType.Type.ToLuaTable();
				typesTable[++typeIndex] = memberTable;
			}

			return moduleInfo;
		}

		private (String path, String guid) GetOrCreatePathForGeneratedScripts(String folderGuid)
		{
			var generatePath = AssetDatabase.GUIDToAssetPath(folderGuid);
			if (AssetDatabase.AssetPathExists(generatePath))
				return (generatePath, folderGuid);

			var modulePath = AssetDatabase.GetAssetPath(this);
			generatePath = $"{Path.GetDirectoryName(modulePath)}/GENERATED {name}".ToForwardSlashes();

			EditorIO.TryCreateDirectory(generatePath);

			return (generatePath, AssetDatabase.AssetPathToGUID(generatePath));
		}

		private Assembly GetAssemblyForAssetPath(String assetPath)
		{
			Assembly assembly = null;
			try
			{
				var assemblyName = CompilationPipeline.GetAssemblyNameFromScriptPath(assetPath);
				if (assemblyName != null)
					assembly = Assembly.Load(Path.GetFileNameWithoutExtension(assemblyName));
			}
			catch (Exception e) {}

			return assembly;
		}

		private String GetAssemblyRootNamespace(String assetPath) =>
			CompilationPipeline.GetAssemblyRootNamespaceFromScriptPath(assetPath);

		private LuaModuleLoader TryInstantiateModuleLoader(String folderGuid, String loaderTypeName)
		{
			var folder = AssetDatabase.GUIDToAssetPath(folderGuid);
			if (AssetDatabase.IsValidFolder(folder) == false)
				return null;

			LuaModuleLoader loader = null;
			var bindingsAssembly = GetAssemblyForAssetPath(folder);
			if (bindingsAssembly != null)
			{
				var bindingsType = bindingsAssembly?.GetType(loaderTypeName);
				if (bindingsType != null)
				{
					var instance = Activator.CreateInstance(bindingsType);
					loader = instance as LuaModuleLoader;
				}
				else
					LunyLogger.LogError($"Module loader not found for name: {loaderTypeName} ({bindingsAssembly.FullName})");
			}
			else
				LunyLogger.LogError($"Assembly not found for path: {folder}");

			return loader;
		}

		[Serializable]
		private sealed class BindTypeInfo
		{
			[SerializeField] private String m_AssemblyQualifiedName;
			private Type m_Type;
			public String AssemblyQualifiedName
			{
				get => m_AssemblyQualifiedName;
				set => m_AssemblyQualifiedName = value;
			}
			public Type Type
			{
				get => m_Type != null ? m_Type : m_Type = Type.GetType(AssemblyQualifiedName);
				set => m_Type = value;
			}

			public MethodInfo[] GetPublicStaticMethods() => Type?.GetMethods(BindingFlags.Public | BindingFlags.Static);
		}

		[CustomPropertyDrawer(typeof(BindTypeInfo))]
		public sealed class BindTypeInfoDrawer : PropertyDrawer
		{
			public override VisualElement CreatePropertyGUI(SerializedProperty property) => new Label(property.displayName);
		}
	}
}
#endif
*/
