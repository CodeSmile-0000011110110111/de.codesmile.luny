// Copyright (C) 2021-2025 Steffen Itterheim
// Refer to included LICENSE file for terms and conditions.

using Lua;
using System;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using Object = System.Object;

namespace Luny
{
	public sealed class LuaTypeInfo
	{
		public delegate LuaValue TypeToLuaCallback();
		public delegate LuaValue InstanceToLuaCallback(Object bindInstance);
		public delegate LuaValue InstanceListToLuaCallback(IList<Object> bindInstances);

		public String Name; // this may in future differ from Type.Name (eg generics)
		public Type BindType;
		public Type LuaType;
		public Type LuaInstanceType;
		public TypeToLuaCallback TypeToLua;
		public InstanceToLuaCallback InstanceToLua;
		public InstanceListToLuaCallback InstanceListToLua;
	}

	public interface ILuaBindType : ILuaUserData
	{
		Type LuaBindType { get; }
	}

	public interface ILuaObject : ILuaBindType {}

	public interface ILuaObjectType : ILuaObject {}

	public interface ILuaObjectFactory
	{
		LuaValue Bind(Object instance);
		LuaValue Bind<T>(IList<T> instances);
	}

	public sealed class LuaObjectFactory : ILuaObjectFactory, ILuaUserData
	{
		private readonly Dictionary<Type, LuaTypeInfo> m_LuaTypes = new();

		public LuaTable Metatable { get; set; }

		public LuaValue Bind(Object instance)
		{
			if (instance == null)
				return LuaValue.Nil;

			var bindType = instance.GetType();
			var luaTypeInfo = TryGetLuaTypeInfo(bindType);
			return luaTypeInfo != null && luaTypeInfo.InstanceToLua != null
				? luaTypeInfo.InstanceToLua(instance)
				: LuaValue.FromObject(instance);
		}

		public LuaValue Bind<T>(IList<T> instances)
		{
			if (instances == null)
				return LuaValue.Nil;

			var bindType = instances.GetType().GetElementType();
			var luaTypeInfo = TryGetLuaTypeInfo(bindType);
			return luaTypeInfo != null && luaTypeInfo.InstanceListToLua != null
				? new LuaList<T>(instances)
				: LuaValue.FromObject(instances);
		}

		internal void Dispose()
		{
			m_LuaTypes.Clear();
			Metatable = null;
		}

		private void AddLuaType(LuaTypeInfo luaType) => m_LuaTypes[luaType.BindType] = luaType;

		internal void LoadLuaTypes(LuaNamespaces namespaces, LuaTypeInfo[] luaTypeInfos)
		{
			foreach (var luaTypeInfo in luaTypeInfos)
			{
				var ns = luaTypeInfo.BindType.Namespace;
				var luaNamespace = namespaces[ns];
				if (luaNamespace == null)
					throw new Exception($"Lua namespace does not exist: {ns}");

				var typeInstance = luaTypeInfo.TypeToLua();
				luaNamespace.Types[luaTypeInfo.Name] = typeInstance;
				namespaces.AddTypeName(luaNamespace, luaTypeInfo.Name);
				AddLuaType(luaTypeInfo);
			}
		}

		private LuaTypeInfo TryGetLuaTypeInfo(Type bindType) => m_LuaTypes.TryGetValue(bindType, out var luaTypeInfo) ? luaTypeInfo : null;
	}
}
