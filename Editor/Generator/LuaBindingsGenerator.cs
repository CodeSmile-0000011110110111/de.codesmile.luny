// Copyright (C) 2021-2025 Steffen Itterheim
// Refer to included LICENSE file for terms and conditions.

using CodeSmile.Luny;
using System;
using System.Collections.Generic;
using System.Reflection;
using UnityEditor;
using UnityEngine;
using Object = System.Object;

namespace CodeSmileEditor.Luny.Generator
{
	internal sealed class LuaBindingsGenerator
	{
		private readonly Assembly m_Assembly;
		private readonly String[] m_Namespaces;
		private readonly Type[] m_Types;
		private readonly LunyLuaModule m_Module;
		private readonly Assembly[] m_BindableAssemblies;

		public Assembly[] BindableAssemblies => m_BindableAssemblies;
		public String[] Namespaces => m_Namespaces;
		public Type[] Types => m_Types;
		public String AssemblyName => m_Assembly?.GetName().Name;

		public LuaBindingsGenerator(LunyLuaModule module)
		{
			m_Module = module;
			m_BindableAssemblies = GenUtil.GetBindableAssemblies();
			m_Assembly = GenUtil.FindMatchingAssembly(BindableAssemblies, m_Module.AssemblyName);
			m_Types = GenUtil.GetBindableTypes(m_Assembly);
			m_Namespaces = GenUtil.GetNamespacesFromTypes(m_Types);
		}

		public void Generate(AssemblyDefinitionAssets asmdefAssets)
		{
			Debug.Assert(m_Module != null, "missing module");
			Debug.Assert(m_Assembly != null, "missing assembly");

			if (Types != null)
			{
				var filteredTypes = GenUtil.GetNamespaceFilteredTypes(m_Types, m_Module.NamespaceWhitelist, m_Module.TypeWhitelist);
				var typeHierarchy = new TypeHierarchy(filteredTypes);

				// generate:
				var contentFolderPath = GenUtil.GetOrCreateContentFolderPath(m_Module);
				AssemblyDefinitionGenerator.Generate(m_Module, contentFolderPath, typeHierarchy, asmdefAssets);
				ModuleLoaderGenerator.Generate(m_Module, contentFolderPath);
				// enums
				// classes and structs

				EditorUtility.SetDirty(m_Module);
				AssetDatabase.SaveAssetIfDirty(m_Module);
			}
		}
	}

	internal struct MethodGroup : IEquatable<MethodGroup>
	{
		public String Name;
		public List<MethodInfo> Overloads;

		public Boolean Equals(MethodGroup other) => Equals(Name, other.Name);

		public override Boolean Equals(Object obj) => obj is MethodGroup other && Equals(other);

		public override Int32 GetHashCode() => Name != null ? Name.GetHashCode() : 0;

		public static Boolean operator ==(MethodGroup left, MethodGroup right) => left.Equals(right);
		public static Boolean operator !=(MethodGroup left, MethodGroup right) => !left.Equals(right);
	}
}
