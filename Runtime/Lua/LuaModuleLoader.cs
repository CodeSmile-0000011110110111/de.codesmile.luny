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
		public abstract LuaTypeInfo[] GetBindingTypes();
		public abstract Type[] GetEnumTypes();

		public struct LuaTypeInfo
		{
			public delegate LuaValue CreateLuaObjectTypeCallback(Parameters parameters);
			public delegate LuaValue CreateLuaObjectCallback(Parameters parameters);

			public Type BindingType;
			public Type StaticType;
			public Type InstanceType;
			public CreateLuaObjectTypeCallback CreateStatic;
			public CreateLuaObjectCallback CreateInstance;
		}

		public struct Parameters
		{
			public ILuaObjectFactory ObjectFactory;
		}
	}
}
