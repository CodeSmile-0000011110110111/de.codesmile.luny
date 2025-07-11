// Copyright (C) 2021-2025 Steffen Itterheim
// Refer to included LICENSE file for terms and conditions.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using UnityEditor;
using UnityEngine;
using Object = System.Object;

namespace CodeSmileEditor.Luny.Generator
{
	internal sealed class TypeHierarchy
	{
		private readonly TreeNode<Type> m_Hierarchy = new(typeof(Object));
		private readonly List<Type> m_Enums = new();
		private Assembly[] m_Assemblies;
		private String[] m_Namespaces;

		public Assembly[] Assemblies => m_Assemblies;
		public String[] Namespaces => m_Namespaces;
		public List<Type> Enums => m_Enums;

		public TypeHierarchy(IEnumerable<Type> types)
		{
			Debug.Assert(types != null);

			var assemblies = new HashSet<Assembly>();
			var namespaces = new HashSet<String>();

			foreach (var type in types)
				AddTypeAndBaseTypes(type, assemblies, namespaces);

			m_Assemblies = assemblies.OrderBy(assembly => assembly.FullName).ToArray();
			m_Namespaces = namespaces.OrderBy(ns => ns).ToArray();
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
					throw new OverflowException("base type recursion too deep");

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

		internal class TreeNode<T>
		{
			private readonly T m_Value;
			private readonly Dictionary<T, TreeNode<T>> m_Children = new();

			public TreeNode<T> this[T t] => m_Children[t];
			public TreeNode<T> Parent { get; private set; }
			public TreeNode<T>[] Children => m_Children.Values.ToArray();
			public Int32 ChildCount => m_Children.Count;
			public T Value => m_Value;
			public TreeNode(T value) => m_Value = value;

			public TreeNode<T> GetOrAddChild(T value)
			{
				if (value.Equals(m_Value))
					return this;

				if (m_Children.TryGetValue(value, out var node))
					return node;

				node = new TreeNode<T>(value) { Parent = this };
				m_Children.Add(value, node);
				return node;
			}

			public void VisitDepthFirst(Action<TreeNode<T>, Int32> callback, Int32 level = 0)
			{
				callback(this, level++);
				foreach (var child in m_Children.Values)
					child.VisitDepthFirst(callback, level);
			}
		}
	}
}
