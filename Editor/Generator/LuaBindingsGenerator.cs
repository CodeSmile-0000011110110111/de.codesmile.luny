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
	internal sealed class LuaBindingsGenerator
	{
		private readonly Assembly m_Assembly;
		private readonly String[] m_Namespaces;
		private readonly Type[] m_Types;

		public Assembly Assembly => m_Assembly;
		public String[] Namespaces => m_Namespaces;
		public Type[] Types => m_Types;
		public String AssemblyName => m_Assembly?.GetName().Name;

		private static Boolean IsSupportedType(Type type) => (type.IsClass || type.IsValueType) &&
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
				var filteredTypes = GetNamespaceFilteredTypes(namespaces);
				var typeHierarchy = new TypeHierarchy(filteredTypes);

				// generate:
				// module loader
				// assembly definition
				// enums
				// classes and structs
			}
		}

		public Type[] GetNamespaceFilteredTypes(String[] namespaces) =>
			m_Types.Where(type => namespaces.Contains(type.Namespace)).ToArray();

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

		public Type[] GetWhitelistedTypes(Type[] filteredTypes, String[] whitelistTypeNames) =>
			filteredTypes.Where(type => whitelistTypeNames.Contains(type.FullName)).ToArray();

		public MethodGroup[] GetBindableMethods(Type type)
		{
			var methods = type
				.GetMethods(BindingFlags.Public | BindingFlags.DeclaredOnly | BindingFlags.Instance | BindingFlags.Static)
				.Where(method => !(method.IsAbstract || method.IsSpecialName))
				.OrderBy(method => method.Name);

			var groups = new HashSet<MethodGroup>();
			foreach (var method in methods)
			{
				var group = new MethodGroup { Name = method.Name };
				if (groups.TryGetValue(group, out var existingGroup) == false)
				{
					group.Overloads = new List<MethodInfo>();
					groups.Add(group);
					existingGroup = group;
				}

				existingGroup.Overloads.Add(method);
			}

			return groups.OrderBy(group => group.Name).ToArray();
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
