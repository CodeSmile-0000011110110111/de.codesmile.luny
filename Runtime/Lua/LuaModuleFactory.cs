// Copyright (C) 2021-2025 Steffen Itterheim
// Refer to included LICENSE file for terms and conditions.

using System;
using Unity.Profiling;
using UnityEditor;
using UnityEngine;

namespace CodeSmile.Luny
{
	public sealed class LuaModuleFactory
	{
		public static void LoadModules(LunyLua lua, LunyLuaContext luaContext)
		{
			foreach (var module in luaContext.Modules)
				LoadModule(lua, module);
		}

		private static void LoadModule(ILunyLua lua, LunyLuaModule module)
		{
			if (module.ModuleLoader == null)
			{
				if (module.ContentFolderExists())
					throw new InvalidOperationException($"Cannot load {module.name} due to compile errors.");

				Debug.LogWarning($"Cannot load {module.name}, it has not been generated.");
				return;
			}

			var moduleLoader = module.ModuleLoader;
			var marker = new ProfilerMarker(ProfilerCategory.Scripts, moduleLoader.GetType().Name);
			marker.Begin();

			var namespaceNames = moduleLoader.GetNamespaceNames();
			var namespaceParts = moduleLoader.GetNamespaceParts();
			LoadModuleNamespaces(lua.Namespaces, namespaceNames, namespaceParts);
			LoadModuleEnums(lua.Namespaces, lua.Enums, moduleLoader.GetEnumTypes());
			(lua.ObjectFactory as LuaObjectFactory).LoadLuaTypes(lua.Namespaces, moduleLoader.GetLuaTypes());

			marker.End();
		}

		private static void LoadModuleNamespaces(LuaNamespaces namespaces, String[] namespaceNames, String[][] namespaceParts)
		{
			Debug.Assert(namespaceNames.Length == namespaceParts.Length);
			for (var i = 0; i < namespaceNames.Length; i++)
			{
				if (namespaces.ContainsKey(namespaceNames[i]) == false)
					namespaces.Add(namespaceNames[i], new LuaNamespace(namespaceNames[i]));
			}
		}

		private static void LoadModuleEnums(LuaNamespaces namespaces, LuaEnums luaEnums, Type[] enumTypes)
		{
			foreach (var enumType in enumTypes)
			{
				var luaEnum = LuaEnum.Create(enumType);
				namespaces[enumType.Namespace][enumType.Name] = luaEnum.Table;
				luaEnums.Add(enumType, luaEnum);
			}
		}
	}
}
