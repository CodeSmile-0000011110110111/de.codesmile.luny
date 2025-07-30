// Copyright (C) 2021-2025 Steffen Itterheim
// Refer to included LICENSE file for terms and conditions.

using Lua;
using System;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;


namespace CodeSmile.Luny
{
	// Is abstract instead of interface for serialization in LunyLuaModule asset
	[Serializable]
	public abstract class LuaModuleLoader
	{
		public sealed class ModuleTypes
		{
			public IEnumerable<String> Namespace { get; }
			public IEnumerable<Type> EnumTypes { get; }
			public IEnumerable<Type> ObjectTypes { get; }
			public IEnumerable<Type> ValueTypes { get; }
		}
		public struct LoadParameters
		{
			public LuaTable env;
			public ILuaObjectFactory ObjectFactory;
		}
		public static LuaTable GetOrCreateNamespaceTable(LuaTable env, String[] namespaceParts)
		{
			var current = env;
			if (namespaceParts != null && namespaceParts.Length > 0)
			{
				var namespaceCount = namespaceParts.Length;
				for (var i = 0; i < namespaceCount; i++)
				{
					var name = namespaceParts[i];
					if (current[name].TryRead(out LuaTable next) == false)
					{
						next = new LuaTable(0, 1);
						current[name] = next;
					}

					current = next;
				}
			}

			return current;
		}

		public abstract IEnumerable<ModuleTypes> GetModuleTypes();
		public abstract void Load(LoadParameters loadParameters);
	}
}
