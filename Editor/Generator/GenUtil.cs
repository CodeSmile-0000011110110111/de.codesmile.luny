using CodeSmile.Luny;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using UnityEditor;
using UnityEngine;

namespace CodeSmileEditor.Luny.Generator
{
	internal static class GenUtil
	{
		public static readonly String GeneratedFileHeader = @"
// --------------------------------------------------------------
// GENERATED FILE ----> DO NOT EDIT <---- CHANGES WILL BE LOST !!
// --------------------------------------------------------------

";

		private static readonly Type Obsolete = typeof(ObsoleteAttribute);

		public static IEnumerable<Assembly> GetBindableAssemblies() => AppDomain.CurrentDomain.GetAssemblies()
			.Where(assembly => !assembly.IsDynamic && assembly.IsFullyTrusted)
			.OrderBy(assembly => assembly.FullName);

		public static Assembly FindMatchingAssembly(IEnumerable<Assembly> assemblies, String assemblyName) => assemblies
			.Where(assembly => assembly.GetName().Name == assemblyName)
			.FirstOrDefault();

		public static IEnumerable<Type> GetNamespaceFilteredTypes(IEnumerable<Type> types, IEnumerable<String> namespaces,
			IEnumerable<String> typeNames = null)
		{
			// using HashSets is significantly faster
			var nsHash = new HashSet<String>(namespaces);
			var typeHash = new HashSet<String>(typeNames ?? new String[] {});
			return types
				.Where(type => nsHash.Contains(type.Namespace) && (typeNames == null || typeHash.Contains(type.FullName)))
				.OrderBy(type => type.FullName);
		}

		public static IEnumerable<Type> GetBindableTypes(Assembly assembly) => assembly != null
			? assembly.ExportedTypes.Where(type => IsSupportedType(type))
				.OrderBy(type => $"{type.Namespace} {type.Name}")
			: Array.Empty<Type>();

		public static IEnumerable<String> GetNamespacesFromTypes(IEnumerable<Type> types) =>
			types.Select(type => type.Namespace).Distinct().OrderBy(s => s);

		public static IEnumerable<MethodGroup> GetBindableMethods(Type type)
		{
			var methods = type
				.GetMethods(BindingFlags.Public | BindingFlags.DeclaredOnly | BindingFlags.Instance | BindingFlags.Static)
				.Where(method => IsSupportedMethod(method))
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

			return groups.OrderBy(group => group.Name);
		}

		public static String GetOrCreateContentFolderPath(LunyLuaModule module)
		{
			var contentFolderPath = AssetDatabase.GUIDToAssetPath(module.ContentFolderGuid);
			if (AssetDatabase.AssetPathExists(contentFolderPath) == false)
			{
				contentFolderPath = AssetDatabase.GetAssetPath(module).Replace(".asset", " GENERATED");
				EditorIO.TryCreateAndImportPath(contentFolderPath);
				module.ContentFolderGuid = AssetDatabase.AssetPathToGUID(contentFolderPath);
				EditorUtility.SetDirty(module);
			}

			return contentFolderPath;
		}

		public static Boolean IsSupportedType(Type type) => (type.IsClass || type.IsValueType) &&
		                                                    false == (type.IsAbstract || type.IsGenericType ||
		                                                              type.IsInterface ||
		                                                              type.IsPrimitive ||
		                                                              type.IsSubclassOf(typeof(Attribute)) ||
		                                                              type.IsSubclassOf(typeof(Delegate)) ||
		                                                              type.IsSubclassOf(typeof(Exception)) ||
		                                                              IsObsolete(type));

		public static Boolean IsSupportedMethod(MethodInfo method) =>
			!(method.IsAbstract || method.IsSpecialName || IsObsolete(method));

		public static IEnumerable<String> GetNamespacesExcept(IEnumerable<String> namespaces, IEnumerable<String> blacklist)
		{
			var startsWith = blacklist.Where(s => s.EndsWith('*')).Select(s =>
				s.Substring(0, s.Length - 1));

			var filtered = new List<String>();
			foreach (var ns in namespaces.Except(blacklist))
			{
				var shouldAdd = true;
				foreach (var str in startsWith)
				{
					if (ns.StartsWith(str))
					{
						shouldAdd = false;
						break;
					}
				}

				if (shouldAdd)
					filtered.Add(ns);
			}

			return filtered;
		}

		public static IEnumerable<Type> GetTypesExcept(IEnumerable<Type> types, IEnumerable<String> blacklist)
		{
			var startsWith = blacklist.Where(s => s.EndsWith('*')).Select(s =>
				s.Substring(0, s.Length - 1));

			var filtered = new List<Type>();
			foreach (var type in types)
			{
				var shouldAdd = true;
				foreach (var str in startsWith)
				{
					if (type.FullName.StartsWith(str))
					{
						shouldAdd = false;
						break;
					}
				}

				if (shouldAdd)
					filtered.Add(type);
			}

			return filtered;
		}

		public static Boolean IsObsolete(Type type) => type.GetCustomAttributes(Obsolete, true).Length > 0 ||
		                                               type.IsNested && IsObsolete(type.DeclaringType);

		public static Boolean IsObsolete(MethodInfo method) => method.GetCustomAttributes(Obsolete, true).Length > 0;
	}
}
