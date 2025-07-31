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

	public struct CreateLuaObjectParameters
	{
		public Object Reference;
		public ILuaObjectFactory ObjectFactory;
	}

	public struct CreateLuaValueTypeParameters
	{
		//public ILuaValueType Reference;
		//public ILuaObjectFactory ObjectFactory;
	}

	public struct LuaTypeInfo
	{
		public delegate LuaValue CreateLuaTypeCallback(CreateLuaTypeParameters parameters);
		public delegate LuaValue CreateLuaObjectCallback(CreateLuaObjectParameters parameters);

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

	public interface ILuaObject : ILuaUserData, ILuaBindType {}

	public interface ILuaObjectType : ILuaObject {}

	public interface ILuaObjectFactory
	{
		delegate ILuaObject CreateLuaObjectDelegate(CreateLuaObjectParameters createParameters);

		// event Action<ILuaObject> OnLuaObjectCreated;
		// CreateLuaObjectDelegate OnCreateLuaObject { get; set; }
		//ILuaUserData CreateLuaValueType([NotNull] ILuaValueType valueType);
		ILuaUserData CreateLuaObject([NotNull] Object obj, [NotNull] CreateLuaObjectDelegate createInstance);
	}

	/*
	public struct LuaType
	{
		public LuaTypeInfo TypeInfo;
		public LuaValue TypeInstance;
		public LuaType(LuaTypeInfo typeInfo, LuaValue typeInstance)
		{
			TypeInfo = typeInfo;
			TypeInstance = typeInstance;
		}
	}
	*/

	public sealed class LuaObjectFactory : ILuaObjectFactory
	{
		private readonly Dictionary<Type, LuaTypeInfo> m_LuaTypes = new();

		public ILuaUserData CreateLuaObject(Object obj, ILuaObjectFactory.CreateLuaObjectDelegate createInstance)
		{
			var luaTypeInfo = GetLuaTypeInfo(obj);
			var instanceType = luaTypeInfo.LuaObject;

			// if (OnCreateLuaObject == null || OnCreateLuaObject(obj, instanceType, out var userData) == false)
			// {
			// 	//luaTypeInfo.CreateInstance(obj);
			// 	userData = (ILuaObject)Activator.CreateInstance(instanceType, obj);
			// }
			//
			// OnLuaObjectCreated?.Invoke(userData);
			return null;
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
				luaNamespace.Table[luaTypeInfo.Name] = typeInstance;
				AddLuaType(luaTypeInfo);
			}
		}

		private LuaTypeInfo GetLuaTypeInfo(Object obj)
		{
			var luaType = m_LuaTypes[obj.GetType()];
			return luaType;
		}
	}
}
