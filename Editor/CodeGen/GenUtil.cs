using Luny;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using UnityEditor;
using UnityEngine;
using Object = System.Object;

namespace CodeSmileEditor.Luny.CodeGen
{
	internal static class GenUtil
	{
		public static readonly String GeneratedFileHeader = @"
// --------------------------------------------------------------
// GENERATED FILE ----> DO NOT EDIT <---- CHANGES WILL BE LOST !!
// --------------------------------------------------------------

";

		private static readonly Type Obsolete = typeof(ObsoleteAttribute);
		//private static readonly Type[] AttributeBlacklist = { typeof(ObsoleteAttribute) };

		public static Boolean IsBindableType(Type type) => !(type == typeof(Object) || type == typeof(ValueType) || type == typeof(Enum)
		                                                     || type == typeof(Delegate) || type == typeof(MulticastDelegate) ||
		                                                     type == typeof(Event));

		public static Boolean IsSupportedType(Type type) => (type.IsClass || type.IsValueType) &&
		                                                    !(type.IsPrimitive || type.IsInterface || type.IsGenericType ||
		                                                      type.IsNested && type.FullName.Contains("e__FixedBuffer") ||
		                                                      type.BaseType != null && type.BaseType.IsGenericType ||
		                                                      type.IsSubclassOf(typeof(Attribute)) ||
		                                                      type.IsSubclassOf(typeof(Delegate)) ||
		                                                      type.IsSubclassOf(typeof(Exception)) ||
		                                                      IsObsolete(type));

		public static Boolean IsSupportedMember(MemberInfo member) =>
			!(member is MethodInfo mi && mi.IsStatic && mi.MemberType == MemberTypes.Constructor || // exclude static constructors
			  IsObsolete(member));

		public static IEnumerable<Assembly> GetBindableAssemblies() => AppDomain.CurrentDomain.GetAssemblies()
			.Where(assembly => !assembly.IsDynamic && assembly.IsFullyTrusted)
			.OrderBy(assembly => assembly.FullName);

		public static Assembly FindMatchingAssembly(IEnumerable<Assembly> assemblies, String assemblyName) => assemblies
			.Where(assembly => assembly.GetName().Name == assemblyName)
			.FirstOrDefault();

		public static Assembly FindAssembly(String assemblyName) => AppDomain.CurrentDomain.GetAssemblies()
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
				.OrderBy(type => type.Namespace).ThenBy(type => type.FullName);
		}

		public static IEnumerable<Type> GetBindableTypes(Assembly assembly) => assembly != null
			? assembly.ExportedTypes.Where(type => IsSupportedType(type))
				.OrderBy(type => type.Namespace).ThenBy(type => type.FullName)
			: Array.Empty<Type>();

		public static IEnumerable<String> GetNamespacesFromTypes(IEnumerable<Type> types) =>
			types.Select(type => type.Namespace).Distinct().OrderBy(s => s);

		public static Boolean ContentFolderPathExists(LunyLuaModule module) =>
			AssetDatabase.AssetPathExists(AssetDatabase.GUIDToAssetPath(module.ContentFolderGuid));

		public static void TryDeleteContentFolderPath(LunyLuaModule module)
		{
			var contentFolderPath = AssetDatabase.GUIDToAssetPath(module.ContentFolderGuid);
			if (AssetDatabase.AssetPathExists(contentFolderPath))
				AssetDatabase.DeleteAsset(contentFolderPath);
		}

		public static IEnumerable<String> GetNamespacesExcept(IEnumerable<String> namespaces, IEnumerable<String> blacklist)
		{
			var startsWith = blacklist.Where(s => s.EndsWith('*')).Select(s => s.Substring(0, s.Length - 1)).ToList();
			// exclude sub-namespaces too
			startsWith.AddRange(blacklist.Where(s => !s.EndsWith('*')).Select(s => $"{s}."));

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
			var startsWith = blacklist.Where(s => s.EndsWith('*')).Select(s => s.Substring(0, s.Length - 1)).ToList();
			// exclude nested types too
			startsWith.AddRange(blacklist.Where(s => !s.EndsWith('*')).Select(s => $"{s}+"));

			var filtered = new List<Type>();
			foreach (var type in types.Where(type => blacklist.Contains(type.FullName) == false))
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

		public static Boolean IsObsolete(MemberInfo member) => member.GetCustomAttributes(Obsolete, true).Length > 0;

		public static void WriteFile(String assetPath, String contents)
		{
			try
			{
				var fullPath = Path.GetFullPath(assetPath);
				File.WriteAllText(fullPath, contents);
			}
			catch (Exception e)
			{
				Debug.LogError($"Failed to write file: {assetPath}\n{e}");
			}
		}

		public static String ToString(ParameterInfo[] parameters)
		{
			var sb = new StringBuilder();
			for (var i = 0; i < parameters.Length; i++)
			{
				var parameter = parameters[i];
				if (i > 0)
					sb.Append(", ");
				sb.Append(parameter.ParameterType.Name);
				sb.Append(" ");
				sb.Append(parameter.Name);
			}
			return sb.ToString();
		}

		// delay logs to make them appear after the compilation process
		internal static void Log(String message) => EditorApplication.delayCall += () => Debug.Log(message);
		internal static void LogWarn(String message) => EditorApplication.delayCall += () => Debug.LogWarning(message);
		internal static void LogError(String message) => EditorApplication.delayCall += () => Debug.LogError(message);
		internal static void LogException(Exception e) => EditorApplication.delayCall += () => Debug.LogException(e);

		private static Boolean HasAttribute(this Type type, Type[] attributes)
		{
			foreach (var attribute in attributes)
			{
				if (type.GetCustomAttributes(attribute, true).Length > 0)
					return true;
			}

			if (type.IsNested)
				return HasAttribute(type.DeclaringType, attributes);

			return false;
		}

		private static Boolean HasAttribute(this MemberInfo member, Type[] attributes)
		{
			foreach (var attribute in attributes)
			{
				if (member.GetCustomAttributes(attribute, true).Length > 0)
					return true;
			}
			return false;
		}
	}
}
