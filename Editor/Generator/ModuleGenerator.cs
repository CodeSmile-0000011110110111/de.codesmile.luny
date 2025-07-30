// Copyright (C) 2021-2025 Steffen Itterheim
// Refer to included LICENSE file for terms and conditions.

using CodeSmile.Luny;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using UnityEditor;
using UnityEngine;

namespace CodeSmileEditor.Luny.Generator
{
	internal static class ModuleGenerator
	{
		private static Dictionary<Type, GenTypeInfo> s_TypeInfosByType;
		public static Dictionary<Type, GenTypeInfo> TypeInfosByType => s_TypeInfosByType;

		public static void Generate(LunyLuaModule module, AssemblyDefinitionAssets asmdefAssets, Type[] types, String onlyThisMethodName = null)
		{
			Debug.Assert(module != null);
			Debug.Assert(types != null);

			if (types.Length > 0)
			{
				var assembly = GenUtil.FindAssembly(module.AssemblyName);
				s_TypeInfosByType = CreateTypeInfos(assembly, types, out var namespaces, onlyThisMethodName, out var typeInfos);
				var contentFolderPath = GenUtil.GetOrCreateContentFolderPath(module);

				ModuleAssemblyDefinitionGenerator.Generate(module, contentFolderPath, namespaces, asmdefAssets);
				ModuleTypeGenerator.Generate(module, contentFolderPath, typeInfos);
				ModuleLoaderGenerator.Generate(module, contentFolderPath, typeInfos, namespaces);

				s_TypeInfosByType = null;
			}
		}

		private static Dictionary<Type, GenTypeInfo> CreateTypeInfos(Assembly moduleAssembly, IEnumerable<Type> types, out String[] namespaces,
			String onlyThisMethodName, out List<GenTypeInfo> typeInfos)
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
					if (type.IsGenericType)
					{
						GenUtil.LogWarn($"Skip generic type: {type.FullName}");
						return;
					}

					var typeInfo = new GenTypeInfo(type, onlyThisMethodName);
					generatableTypeInfos.Add(typeInfo);
					typeInfosByType.Add(type, typeInfo);
				}
			});

			namespaces = typeHierarchy.Namespaces.ToArray();

			typeInfos = generatableTypeInfos;
			return typeInfosByType;
		}
	}
}
