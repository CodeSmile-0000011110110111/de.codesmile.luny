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
	public interface ILuaObjectFactory
	{
		delegate bool CreateLuaObjectDelegate(object obj, Type luaType, out ILuaUserData luaObject);

		CreateLuaObjectDelegate OnCreateLuaObject { get; set; }

		event Action<Object> OnLuaObjectCreated;
		ILuaUserData CreateLuaObject([NotNull] Object obj);
		//ILuaUserData CreateLuaValueType([NotNull] ValueType value);
	}

	public interface ILuaGameObjectFactory
	{
		ILuaUnityGameObject CreateLuaGameObject([NotNull] GameObject gameObject);
	}

	public interface ILuaComponentFactory
	{
		ILuaUnityComponent CreateLuaUnityComponent([NotNull] Component component);
	}

	public sealed class LuaObjectFactory : ILuaObjectFactory //, ILuaGameObjectFactory, ILuaComponentFactory
	{
		public ILuaObjectFactory.CreateLuaObjectDelegate OnCreateLuaObject { get; set; }
		public event Action<Object> OnLuaObjectCreated;

		private readonly Dictionary<Type, Type> m_LuaTypes = new();

		// public ILuaUnityComponent CreateLuaUnityComponent(Component component) => throw new NotImplementedException();
		// public ILuaUnityGameObject CreateLuaGameObject(GameObject gameObject) => throw new NotImplementedException();

		public ILuaUserData CreateLuaObject(Object obj)
		{
			var luaType = GetLuaType(obj);

			if (OnCreateLuaObject == null || OnCreateLuaObject(obj, luaType, out var luaObject) == false)
			{
				luaObject = (ILuaUserData)Activator.CreateInstance(luaType, obj);
			}

			OnLuaObjectCreated?.Invoke(luaObject);
			return luaObject;
		}

		private Type GetLuaType(Object obj)
		{
			var luaType = m_LuaTypes[obj.GetType()];
			if (luaType == null)
				throw new ArgumentNullException($"Missing Lua Type for {obj.GetType().FullName}");

			return luaType;
		}
	}
}
