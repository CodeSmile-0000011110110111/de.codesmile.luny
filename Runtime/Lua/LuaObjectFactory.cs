// Copyright (C) 2021-2025 Steffen Itterheim
// Refer to included LICENSE file for terms and conditions.

using Lua;
using System;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using Object = System.Object;

namespace CodeSmile.Luny
{
	public sealed class LuaTypeInfo
	{
		public delegate LuaValue BindTypeToLuaCallback();
		public delegate LuaValue BindInstanceToLuaCallback(Object bindInstance);
		public delegate LuaValue BindInstancesListToLuaCallback(IList<Object> bindInstances);

		public String Name; // this may in future differ from Type.Name (eg generics)
		public Type BindType;
		public Type LuaType;
		public Type LuaInstanceType;
		public BindTypeToLuaCallback BindTypeToLua;
		public BindInstanceToLuaCallback BindInstanceToLua;
		public BindInstancesListToLuaCallback BindInstancesListToLua;
	}

	public interface ILuaBindType : ILuaUserData
	{
		Type LuaBindType { get; }
	}

	public interface ILuaObject : ILuaBindType {}

	public interface ILuaObjectType : ILuaObject {}

	public interface ILuaObjectFactory
	{
		LuaValue CreateLuaInstance(Object instance);
		LuaValue CreateLuaCollection<T>(IList<T> instances);
	}

	public sealed class LuaObjectFactory : ILuaObjectFactory, ILuaUserData
	{
		private readonly Dictionary<Type, LuaTypeInfo> m_LuaTypes = new();

		public LuaTable Metatable { get; set; }

		public LuaValue CreateLuaInstance(Object instance)
		{
			if (instance == null)
				return LuaValue.Nil;

			var bindType = instance.GetType();
			var luaTypeInfo = TryGetLuaTypeInfo(bindType);
			return luaTypeInfo != null && luaTypeInfo.BindInstanceToLua != null
				? luaTypeInfo.BindInstanceToLua(instance)
				: LuaValue.FromObject(instance);
		}

		public LuaValue CreateLuaCollection<T>(IList<T> instances)
		{
			if (instances == null)
				return LuaValue.Nil;

			var bindType = instances.GetType().GetElementType();
			var luaTypeInfo = TryGetLuaTypeInfo(bindType);
			return luaTypeInfo != null && luaTypeInfo.BindInstancesListToLua != null
				? new LuaList<T>(instances) //luaTypeInfo.BindInstancesListToLua(instances)
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

				var typeInstance = luaTypeInfo.BindTypeToLua();
				luaNamespace.Types[luaTypeInfo.Name] = typeInstance;
				namespaces.AddTypeName(luaNamespace, luaTypeInfo.Name);
				AddLuaType(luaTypeInfo);
			}
		}

		private LuaTypeInfo TryGetLuaTypeInfo(Type bindType) => m_LuaTypes.TryGetValue(bindType, out var luaTypeInfo) ? luaTypeInfo : null;
	}
}
