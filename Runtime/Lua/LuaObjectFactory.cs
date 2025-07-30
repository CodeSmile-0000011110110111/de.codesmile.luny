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
		delegate Boolean CreateLuaObjectDelegate(Object obj, Type luaType, out ILuaObject luaObject);

		event Action<ILuaObject> OnLuaObjectCreated;
		CreateLuaObjectDelegate OnCreateLuaObject { get; set; }
		ILuaUserData CreateLuaObject([NotNull] Object obj);
		void RegisterType(LuaModuleLoader.LuaTypeInfo typeInfo);
	}

	// public interface ILuaGameObjectFactory
	// {
	// 	ILuaUnityGameObject CreateLuaGameObject([NotNull] GameObject gameObject);
	// }
	//
	// public interface ILuaComponentFactory
	// {
	// 	ILuaUnityComponent CreateLuaUnityComponent([NotNull] Component component);
	// }

	public sealed class LuaObjectFactory : ILuaObjectFactory //, ILuaGameObjectFactory, ILuaComponentFactory
	{
		public event Action<ILuaObject> OnLuaObjectCreated;

		private readonly Dictionary<Type, LuaModuleLoader.LuaTypeInfo> m_LuaTypes = new();
		public ILuaObjectFactory.CreateLuaObjectDelegate OnCreateLuaObject { get; set; }

		public ILuaUserData CreateLuaObject(Object obj)
		{
			var luaTypeInfo = GetLuaTypeInfo(obj);
			var instanceType = luaTypeInfo.InstanceType;

			if (OnCreateLuaObject == null || OnCreateLuaObject(obj, instanceType, out var userData) == false)
			{
				//luaTypeInfo.CreateInstance(obj);
				userData = (ILuaObject)Activator.CreateInstance(instanceType, obj);
			}

			OnLuaObjectCreated?.Invoke(userData);
			return userData;
		}

		public void RegisterType(LuaModuleLoader.LuaTypeInfo typeInfo) => m_LuaTypes[typeInfo.BindingType] = typeInfo;

		private LuaModuleLoader.LuaTypeInfo GetLuaTypeInfo(Object obj)
		{
			var luaType = m_LuaTypes[obj.GetType()];
			return luaType;
		}
	}
}
