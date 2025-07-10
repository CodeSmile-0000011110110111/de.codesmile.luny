using CodeSmile.Luny;
using CodeSmileEditor.Core;
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
		public static Assembly[] GetBindableAssemblies() => AppDomain.CurrentDomain.GetAssemblies()
			.Where(assembly => !assembly.IsDynamic && assembly.IsFullyTrusted)
			.OrderBy(assembly => assembly.FullName)
			.ToArray();

		public static Assembly FindMatchingAssembly(IEnumerable<Assembly> assemblies, String assemblyName) => assemblies
			.Where(assembly => assembly.GetName().Name == assemblyName)
			.FirstOrDefault();

		public static Boolean IsSupportedType(Type type) => (type.IsClass || type.IsValueType) &&
		                                                    !(type.IsAbstract || type.IsGenericType || type.IsInterface ||
		                                                      type.IsPrimitive ||
		                                                      type.IsSubclassOf(typeof(Attribute)) ||
		                                                      type.IsSubclassOf(typeof(Delegate)) ||
		                                                      type.IsSubclassOf(typeof(Exception)));

		public static Type[] GetNamespaceFilteredTypes(Type[] types, String[] namespaces, String[] typeNames = null) => types
			.Where(type => namespaces.Contains(type.Namespace) && (typeNames == null || typeNames.Contains(type.FullName)))
			.OrderBy(type => type.FullName)
			.ToArray();

		public static Type[] GetBindableTypes(Assembly assembly) => assembly != null
			? assembly.ExportedTypes.Where(type => IsSupportedType(type))
				.OrderBy(type => $"{type.Namespace} {type.Name}")
				.ToArray()
			: Array.Empty<Type>();

		public static String[] GetNamespacesFromTypes(Type[] types)
		{
			var ns = new HashSet<String>();
			types.Select(type => type.Namespace).ToList().ForEach(n => ns.Add(n));

			var namespaces = ns.ToArray();
			Array.Sort(namespaces);
			return namespaces;
		}

		public static MethodGroup[] GetBindableMethods(Type type)
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
	}
}
