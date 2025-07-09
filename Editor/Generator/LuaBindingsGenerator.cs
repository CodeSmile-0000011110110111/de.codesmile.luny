// Copyright (C) 2021-2025 Steffen Itterheim
// Refer to included LICENSE file for terms and conditions.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using UnityEditor;
using UnityEngine;

namespace CodeSmileEditor.Luny.Generator
{
	internal sealed class LuaBindingsGenerator
	{
		private readonly Assembly m_Assembly;
		private readonly String[] m_Namespaces;
		private readonly Type[] m_Types;

		public Assembly Assembly => m_Assembly;
		public String[] Namespaces => m_Namespaces;
		public Type[] Types => m_Types;

		private static Boolean IsSupportedType(Type type) => (type.IsClass || type.IsEnum || type.IsValueType) &&
		                                                     !(type.IsAbstract || type.IsGenericType || type.IsInterface ||
		                                                       type.IsPrimitive ||
		                                                       type.IsSubclassOf(typeof(Attribute)) ||
		                                                       type.IsSubclassOf(typeof(Delegate)) ||
		                                                       type.IsSubclassOf(typeof(Exception)));

		public LuaBindingsGenerator(Assembly assembly)
		{
			m_Assembly = assembly;
			m_Types = GetBindableTypes();
			m_Namespaces = GetNamespacesFromTypes(m_Types);
		}

		public void Generate(String[] namespaces)
		{
			if (Types != null)
			{
				var filteredTypes = m_Types.Where(type => namespaces.Contains(type.Namespace)).ToArray();
				Debug.Log($"{filteredTypes.Length} filtered types from {m_Types.Length} total");
				var typeHierarchy = new TypeHierarchy(filteredTypes);
			}
		}

		private Type[] GetBindableTypes() => m_Assembly != null
			? m_Assembly.ExportedTypes.Where(type => IsSupportedType(type))
				.OrderBy(type => $"{type.Namespace} {type.Name}")
				.ToArray()
			: Array.Empty<Type>();

		private String[] GetNamespacesFromTypes(Type[] types)
		{
			var ns = new HashSet<String>();
			types.Select(type => type.Namespace).ToList().ForEach(n => ns.Add(n));

			var namespaces = ns.ToArray();
			Array.Sort(namespaces);
			return namespaces;
		}
	}
}
