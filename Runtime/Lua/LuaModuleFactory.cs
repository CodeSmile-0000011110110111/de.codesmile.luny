// Copyright (C) 2021-2025 Steffen Itterheim
// Refer to included LICENSE file for terms and conditions.

using System;
using Unity.Profiling;
using UnityEditor;
using UnityEngine;

namespace Luny
{
	public sealed class LuaModuleFactory
	{
		public static void LoadModules(ILunyLua lua, LunyLuaContext luaContext, out LuaNamespaces luaNamespaces, out LuaEnums luaEnums)
		{
			luaNamespaces = new LuaNamespaces();
			luaEnums = new LuaEnums();

			foreach (var module in luaContext.Modules)
				LoadModule(module, (LuaObjectFactory)lua.ObjectFactory, luaNamespaces, luaEnums);

			// assign loaded namespaces to global env
			var env = lua.State.Environment;
			foreach (var ns in luaNamespaces.Values)
				env[ns.Name] = ns;
		}

		private static void LoadModule(LunyLuaModule module, LuaObjectFactory objectFactory, LuaNamespaces luaNamespaces, LuaEnums luaEnums)
		{
			if (module.ModuleLoader == null)
			{
				if (module.ContentFolderExists())
					throw new ArgumentNullException($"Cannot load {module.name}, module loader reference is null.");

				Debug.LogWarning($"Cannot load {module.name}, it has not been generated.");
				return;
			}

			var moduleLoader = module.ModuleLoader;
			var marker = new ProfilerMarker(ProfilerCategory.Scripts, moduleLoader.GetType().Name);
			marker.Begin();

			var namespaceNames = moduleLoader.GetNamespaceNames();
			var namespaceParts = moduleLoader.GetNamespaceParts();
			LoadModuleNamespaces(luaNamespaces, namespaceNames, namespaceParts);
			LoadModuleEnums(luaNamespaces, luaEnums, moduleLoader.GetEnumTypes());
			objectFactory.LoadLuaTypes(luaNamespaces, moduleLoader.GetBindTypeInfos());

			marker.End();
		}

		private static void LoadModuleNamespaces(LuaNamespaces namespaces, String[] namespaceNames, String[][] namespaceParts)
		{
			Debug.Assert(namespaceNames.Length == namespaceParts.Length);
			for (var i = 0; i < namespaceNames.Length; i++)
			{
				if (namespaces.ContainsNamespace(namespaceNames[i]) == false)
					namespaces.Add(namespaceNames[i], new LuaNamespace(namespaceNames[i]));
			}
		}

		private static void LoadModuleEnums(LuaNamespaces namespaces, LuaEnums luaEnums, Type[] enumTypes)
		{
			foreach (var enumType in enumTypes)
			{
				var luaEnum = LuaEnum.Create(enumType);
				var enumNamespace = namespaces[enumType.Namespace];
				enumNamespace[enumType.Name] = luaEnum.Table;
				namespaces.AddTypeName(enumNamespace, enumType.Name);
				luaEnums.Add(enumType, luaEnum);
			}
		}

	}
}
