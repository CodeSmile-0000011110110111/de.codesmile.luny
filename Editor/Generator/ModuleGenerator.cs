// Copyright (C) 2021-2025 Steffen Itterheim
// Refer to included LICENSE file for terms and conditions.

using CodeSmile.Luny;
using System;
using System.Collections.Generic;
using System.Linq;
using UnityEditor;
using UnityEngine;

namespace CodeSmileEditor.Luny.Generator
{
	internal static class ModuleGenerator
	{
		private static Dictionary<Type, GenTypeInfo> s_TypeInfosByType;
		public static Dictionary<Type, GenTypeInfo> TypeInfosByType => s_TypeInfosByType;

		public static void Generate(LunyLuaModule module, AssemblyDefinitionAssets asmdefAssets, IEnumerable<Type> types,
			String onlyThisMethodName = null)
		{
			Debug.Assert(module != null);
			Debug.Assert(types != null);

			if (types.Any())
			{
				s_TypeInfosByType = new Dictionary<Type, GenTypeInfo>();

				var contentFolderPath = GenUtil.GetOrCreateContentFolderPath(module);
				var typeHierarchy = new ModuleTypeHierarchy(types);
				ModuleAssemblyDefinitionGenerator.Generate(module, contentFolderPath, typeHierarchy, asmdefAssets);
				var boundTypes = ModuleTypeGenerator.Generate(module, contentFolderPath, typeHierarchy, onlyThisMethodName);
				ModuleLoaderGenerator.Generate(module, contentFolderPath, typeHierarchy, boundTypes);
				ModuleFactoryGenerator.Generate(module, contentFolderPath);

				s_TypeInfosByType = null;
			}
		}
	}
}
