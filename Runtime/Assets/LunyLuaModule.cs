// Copyright (C) 2021-2025 Steffen Itterheim
// Refer to included LICENSE file for terms and conditions.

using Lua;
using System;
using System.Collections.Generic;
using Unity.Profiling;
using UnityEditor;
using UnityEngine;

namespace CodeSmile.Luny
{
	[CreateAssetMenu(fileName = "New LuaModule", menuName = "Luny/Lua Module", order = 101)]
	[Icon("Packages/de.codesmile.luny/Editor/Resources/LunyLuaModuleIcon.png")]
	public sealed partial class LunyLuaModule : ScriptableObject
	{
		[SerializeField] internal String m_AssemblyName = "";
		[SerializeField] [ReadOnlyField] internal String[] m_NamespaceWhitelist = Array.Empty<String>();
		[SerializeField] internal String[] m_NamespaceBlacklist = Array.Empty<String>();
		[SerializeField] [ReadOnlyField] internal String[] m_TypeWhitelist = Array.Empty<String>();
		[SerializeField] internal String[] m_TypeBlacklist = Array.Empty<String>();

		// serialized for runtime, but hidden in Inspector because these are automated
		[SerializeField] [HideInInspector] private String m_ContentFolderGuid;
		[SerializeField] [ReadOnlyField] internal String m_ModuleLoaderTypeName;
		[SerializeReference] [HideInInspector] private Loader m_ModuleLoader;

		internal String AssemblyName => m_AssemblyName;
		internal String BindingsNamespace => $"Lua_{m_AssemblyName.Replace('.', '_')}";
		internal String ScriptingDefineSymbol => BindingsNamespace.ToUpper();
		internal String[] NamespaceWhitelist => m_NamespaceWhitelist;
		internal String[] TypeWhitelist => m_TypeWhitelist;
		internal String[] NamespaceBlacklist => m_NamespaceBlacklist;
		internal String[] TypeBlacklist => m_TypeBlacklist;

		internal String ContentFolderGuid { get => m_ContentFolderGuid; set => m_ContentFolderGuid = value; }
		internal String ModuleLoaderTypeName { get => m_ModuleLoaderTypeName; set => m_ModuleLoaderTypeName = value; }
		internal Loader ModuleLoader { get => m_ModuleLoader; set => m_ModuleLoader = value; }

		public void Load(ILunyLua lua)
		{
#if UNITY_EDITOR
			UpdateGeneratedReferences();
#endif

			if (ModuleLoader != null)
			{
				var marker = new ProfilerMarker(ProfilerCategory.Scripts, m_ModuleLoader.GetType().Name);
				marker.Begin();

				//var loadParams = new LuaModuleLoader.Parameters { ObjectFactory = lua.ObjectFactory, env = lua.State.Environment };
				//ModuleLoader.Load(loadParams);

				var namespaces = ModuleLoader.GetNamespaces();
				var namespaceParts = ModuleLoader.GetNamespaceParts();
				var namespaceTables = CreateNamespaceTables(lua.State.Environment, namespaces, namespaceParts);

				var objectTypes = ModuleLoader.GetBindingTypes();
				RegisterObjectTypes(lua, namespaceTables, objectTypes);
				var enumTypes = ModuleLoader.GetEnumTypes();
				RegisterEnumTypes(namespaceTables, enumTypes);

				marker.End();
			}
			else
				Debug.LogWarning($"{name} is missing the {nameof(Loader)} reference. Try generating this {nameof(LuaModule)} again.");
		}

		private void RegisterObjectTypes(ILunyLua lua, Dictionary<String, LuaTable> namespaceTables, LuaTypeInfo[] typeInfos)
		{
			var objectFactory = lua.ObjectFactory;
			var createParams = new CreateLuaTypeParameters { ObjectFactory = objectFactory };

			LuaTable nsTable = null;
			String lastNamespace = null;
			foreach (var typeInfo in typeInfos)
			{
				var bindType = typeInfo.BindingType;
				if (lastNamespace != bindType.Namespace)
				{
					lastNamespace = bindType.Namespace;
					nsTable = namespaceTables[bindType.Namespace];
				}

				nsTable[bindType.Name] = typeInfo.CreateLuaType(createParams);
				objectFactory.RegisterType(typeInfo);
			}
		}

		private void RegisterEnumTypes(Dictionary<String, LuaTable> namespaceTables, Type[] enumTypes)
		{
			LuaTable nsTable = null;
			String lastNamespace = null;
			foreach (var typeInfo in enumTypes)
			{
				if (lastNamespace != typeInfo.Namespace)
				{
					lastNamespace = typeInfo.Namespace;
					nsTable = namespaceTables[typeInfo.Namespace];
				}

				nsTable[typeInfo.Name] = LuaEnum.Create(typeInfo);
			}
		}

		private Dictionary<String, LuaTable> CreateNamespaceTables(LuaTable env, String[] namespaces, String[][] namespaceParts)
		{
			Debug.Assert(namespaces.Length == namespaceParts.Length);

			var tables = new Dictionary<String, LuaTable>();
			for (var i = 0; i < namespaces.Length; i++)
			{
				var table = LuaNamespace.GetOrCreate(env, namespaceParts[i]);
				tables.Add(namespaces[i], table);
			}

			return tables;
		}

		// Is abstract instead of interface for serialization in LunyLuaModule asset
		[Serializable]
		public abstract class Loader
		{
			public abstract String[] GetNamespaces();
			public abstract String[][] GetNamespaceParts();
			public abstract LuaTypeInfo[] GetBindingTypes();
			public abstract Type[] GetEnumTypes();
		}

#if UNITY_EDITOR
		[Header("Debug")]
		[Tooltip("Useful to exercise code generation on just a specific type because it may be causing troubles with the generator.")]
		[SerializeField] internal String m_GenerateOnlyThisType;
		[Tooltip("If OnlyThisType is set will only generate bindings for this method (including overloads).")]
		[SerializeField] internal String m_GenerateOnlyThisMethod;
#endif
	}
}
