// Copyright (C) 2021-2025 Steffen Itterheim
// Refer to included LICENSE file for terms and conditions.

using Lua;
using System;
using UnityEditor;
using UnityEngine;

namespace CodeSmile.Luny
{
	// Is abstract instead of interface for serialization in LunyLuaModule asset
	[Serializable]
	public abstract class LuaModuleLoader
	{
		public abstract String[] GetNamespaces();
		public abstract String[][] GetNamespaceParts();
		public abstract ModuleTypes GetModuleTypes();
		public abstract void Load(ModuleParameters parameters);

		public sealed class ModuleTypes
		{
			public Type[] ObjectTypes { get; set; }
			public Type[] ValueTypes { get; set; }
			public Type[] EnumTypes { get; set; }
		}

		public struct ModuleParameters
		{
			[Obsolete] public LuaTable env;

			public ILuaObjectFactory ObjectFactory;
		}
	}
}
