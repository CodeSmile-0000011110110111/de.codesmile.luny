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
	internal static class LuaBindingsGenerator
	{
		public static void Generate(LunyLuaModule module, AssemblyDefinitionAssets asmdefAssets, IEnumerable<Type> types)
		{
			Debug.Assert(module != null, "missing module");

			if (types != null && types.Count() > 0)
			{
				var typeHierarchy = new TypeHierarchy(types);
				var contentFolderPath = GenUtil.GetOrCreateContentFolderPath(module);

				AssemblyDefinitionGenerator.Generate(module, contentFolderPath, typeHierarchy, asmdefAssets);
				var boundTypes = TypeGenerator.Generate(module, contentFolderPath, typeHierarchy);
				ModuleLoaderGenerator.Generate(module, contentFolderPath, typeHierarchy, boundTypes);
			}
		}
	}
}
