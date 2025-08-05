// Copyright (C) 2021-2025 Steffen Itterheim
// Refer to included LICENSE file for terms and conditions.

using CodeSmileEditor.Luny.Generator;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using UnityEditor;
using UnityEngine;
using Object = System.Object;

namespace LunyEditor.Generator
{
	internal sealed class ModuleTypeHierarchy
	{
		private readonly TreeNode<Type> m_Hierarchy = new(typeof(Object));
		private readonly List<Type> m_Enums = new();
		private readonly IEnumerable<Assembly> m_Assemblies;
		private readonly IEnumerable<String> m_Namespaces;
		private readonly IEnumerable<Type> m_Types;

		public IEnumerable<Assembly> Assemblies => m_Assemblies;
		public IEnumerable<String> Namespaces => m_Namespaces;
		public IEnumerable<Type> Types => m_Types;
		public IEnumerable<Type> Enums => m_Enums;

		public ModuleTypeHierarchy(IEnumerable<Type> types)
		{
			Debug.Assert(types != null);
			m_Types = types;

			var assemblies = new HashSet<Assembly>();
			var namespaces = new HashSet<String>();

			foreach (var type in m_Types)
			{
				AddTypeAndBaseTypes(type, assemblies, namespaces);

				var nestedTypes = type.GetNestedTypes(BindingFlags.Public);
				foreach (var nestedType in nestedTypes)
				{
					if (GenUtil.IsSupportedType(nestedType) == false)
						continue;

					AddTypeAndBaseTypes(nestedType, assemblies, namespaces);
				}
			}

			m_Assemblies = assemblies.OrderBy(assembly => assembly.FullName);
			m_Namespaces = namespaces.OrderBy(ns => ns);
			m_Enums.Sort((t1, t2) => t1.FullName.CompareTo(t2.FullName));
			//Debug.Log($"Counts: Assemblies={m_Assemblies.Length}, Namespaces={m_Namespaces.Length}, Enums={m_Enums.Count}");
		}

		private void AddTypeAndBaseTypes(Type type, HashSet<Assembly> assemblies, HashSet<String> namespaces)
		{
			List<Type> hierarchyTypes = new();
			hierarchyTypes.Add(type);

			var maxRecursionCount = 50;
			while (type != null)
			{
				if (--maxRecursionCount <= 0)
					throw new OverflowException("type hierarchy recursion too deep");

				hierarchyTypes.Add(type);
				type = type.BaseType;
			}

			AddTypes(hierarchyTypes, assemblies, namespaces);
		}

		private void AddTypes(IEnumerable<Type> hierarchyTypes, HashSet<Assembly> assemblies, HashSet<String> namespaces)
		{
			var node = m_Hierarchy;
			foreach (var type in hierarchyTypes.Reverse())
			{
				assemblies.Add(type.Assembly);
				namespaces.Add(type.Namespace);
				if (type.IsEnum)
					m_Enums.Add(type);
				node = node.GetOrAddChild(type);
			}
		}

		public void Visit(Action<TreeNode<Type>, Int32> callback) => m_Hierarchy?.VisitDepthFirst(callback);
	}
}
