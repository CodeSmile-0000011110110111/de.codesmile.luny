// Copyright (C) 2021-2025 Steffen Itterheim
// Refer to included LICENSE file for terms and conditions.

using Luny;
using LunyEditor.Core;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using UnityEditor;
using UnityEngine;

namespace LunyEditor.CodeGen
{
	internal static class ModuleGenerator
	{
		private static Dictionary<Type, GenTypeInfo> s_TypeInfosByType;
		public static Dictionary<Type, GenTypeInfo> TypeInfosByType => s_TypeInfosByType;

		public static void Generate(LunyLuaModule module, AssemblyDefinitionAssets asmdefAssets,
			GenMemberFilter[] memberBlacklist, Type[] types, String onlyThisMethodName = null)
		{
			Debug.Assert(module != null);
			Debug.Assert(types != null);

			if (types.Length > 0)
			{
				Debug.Log($"Generating {module.name} assembly: {module.AssemblyName}");

				var assembly = GenUtil.FindAssembly(module.AssemblyName);
				s_TypeInfosByType =
					CreateTypeInfos(assembly, types, memberBlacklist, out var namespaces, out var typeInfos, onlyThisMethodName);
				var contentFolderPath = GetOrCreateContentFolderPath(module);

				ModuleAssemblyDefinitionGenerator.Generate(module, contentFolderPath, namespaces, asmdefAssets);
				ModuleTypeGenerator.Generate(module, contentFolderPath, typeInfos);
				ModuleLoaderGenerator.Generate(module, contentFolderPath, typeInfos, namespaces);

				s_TypeInfosByType = null;
			}
		}

		private static Dictionary<Type, GenTypeInfo> CreateTypeInfos(Assembly moduleAssembly, IEnumerable<Type> types,
			GenMemberFilter[] memberBlacklist, out String[] namespaces, out IEnumerable<GenTypeInfo> typeInfos,
			String onlyThisMethodName)
		{
			var typeInfosByType = new Dictionary<Type, GenTypeInfo>();

			var typeHierarchy = new ModuleTypeHierarchy(types);
			var generatableTypeInfos = new List<GenTypeInfo>();
			typeHierarchy.Visit((node, level) =>
			{
				var type = node.Value;

				// skip the inevitable System types
				if (GenUtil.IsBindableType(type))
				{
					if (type.Assembly != moduleAssembly)
					{
						GenUtil.LogWarn($"Skip {type.FullName}, is in foreign assembly: {type.Assembly.GetName().FullName}");
						return;
					}

					var typeInfo = new GenTypeInfo(type, memberBlacklist, node.Children, onlyThisMethodName);
					generatableTypeInfos.Add(typeInfo);
					typeInfosByType.Add(type, typeInfo);
				}
			});

			namespaces = typeHierarchy.Namespaces.ToArray();
			typeInfos = generatableTypeInfos.OrderBy(t => t.Type.Namespace).ThenBy(t => t.BindTypeFullName);
			return typeInfosByType;
		}

		private static String GetOrCreateContentFolderPath(LunyLuaModule module)
		{
			var contentFolderPath = AssetDatabase.GUIDToAssetPath(module.ContentFolderGuid);
			if (AssetDatabase.AssetPathExists(contentFolderPath) == false)
			{
				var modulePath = AssetDatabase.GetAssetPath(module);
				contentFolderPath = Path.ChangeExtension(modulePath, null);
				EditorAssetUtil.TryCreateAndImportPath(contentFolderPath);
				module.ContentFolderGuid = AssetDatabase.AssetPathToGUID(contentFolderPath);
				EditorUtility.SetDirty(module);
			}

			return contentFolderPath;
		}
	}
}
