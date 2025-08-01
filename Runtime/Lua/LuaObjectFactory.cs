// Copyright (C) 2021-2025 Steffen Itterheim
// Refer to included LICENSE file for terms and conditions.

using Lua;
using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using UnityEditor;
using UnityEngine;
using Object = System.Object;

namespace CodeSmile.Luny
{
	public struct CreateLuaTypeParameters
	{
		public ILuaObjectFactory ObjectFactory;
	}

	public struct LuaTypeInfo
	{
		public delegate LuaValue CreateLuaTypeCallback(CreateLuaTypeParameters parameters);
		public delegate LuaValue CreateLuaObjectCallback(Object bindInstance);

		public String Name; // this may in future differ from Type.Name (eg generics)
		public Type BindType;
		public Type LuaType;
		public Type LuaObject;
		public CreateLuaTypeCallback CreateLuaType;
		public CreateLuaObjectCallback CreateLuaObject;
	}

	public interface ILuaBindType
	{
		Type LuaBindType { get; }
	}

	public interface ILuaObject : ILuaBindType {}

	public interface ILuaObjectType : ILuaObject {}

	public interface ILuaObjectFactory
	{
		LuaValue CreateLuaObjectInstance([NotNull] Object bindInstance);
	}

	public sealed class LuaObjectFactory : ILuaObjectFactory, ILuaUserData
	{
		private readonly Dictionary<Type, LuaTypeInfo> m_LuaTypes = new();

		public LuaTable Metatable { get; set; }

		public LuaValue CreateLuaObjectInstance(Object bindInstance)
		{
			if (bindInstance == null)
				return LuaValue.Nil;

			Debug.Assert(bindInstance.GetType().IsValueType == false, "should not be used with value types");

			var luaTypeInfo = GetLuaTypeInfo(bindInstance);
			var luaInstance = luaTypeInfo.CreateLuaObject(bindInstance);
			return luaInstance;
		}

		internal void Dispose()
		{
			m_LuaTypes.Clear();
			Metatable = null;
		}

		private void AddLuaType(LuaTypeInfo luaType) => m_LuaTypes[luaType.BindType] = luaType;

		internal void LoadLuaTypes(LuaNamespaces namespaces, LuaTypeInfo[] luaTypeInfos)
		{
			var createParams = new CreateLuaTypeParameters { ObjectFactory = this };

			foreach (var luaTypeInfo in luaTypeInfos)
			{
				var ns = luaTypeInfo.BindType.Namespace;
				var luaNamespace = namespaces[ns];
				if (luaNamespace == null)
					throw new Exception($"Lua namespace does not exist: {ns}");

				var typeInstance = luaTypeInfo.CreateLuaType(createParams);
				luaNamespace.Types[luaTypeInfo.Name] = typeInstance;
				namespaces.AddTypeName(luaNamespace, luaTypeInfo.Name);
				AddLuaType(luaTypeInfo);
			}
		}

		private LuaTypeInfo GetLuaTypeInfo<T>(T obj) => m_LuaTypes[obj.GetType()];
	}
}
