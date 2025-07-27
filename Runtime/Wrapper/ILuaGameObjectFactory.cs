// Copyright (C) 2021-2025 Steffen Itterheim
// Refer to included LICENSE file for terms and conditions.

using System;
using System.Collections.Generic;
using UnityEngine;
using Object = UnityEngine.Object;

namespace CodeSmile.Luny
{
	/*
	public sealed class LunyLuaObjectFactory : ILuaObjectFactory
	{
		private Dictionary<Type, Type> m_RegisteredTypes = new();

		// Types supplied by modules
		public void AddTypes(IDictionary<Type, Type> types)
		{
			foreach (var type in types)
			{
				m_RegisteredTypes.TryAdd(type.Key, type.Value);
			}
		}

		public ILuaObject Create(Object obj)
		{
			return m_RegisteredTypes.TryGetValue(obj.GetType(), out Type luaType)
				? (ILuaObject)Activator.CreateInstance(luaType, new object[] { obj })
				: null;
		}
	}

	public interface ILuaObjectFactory
	{
		ILuaObject Create(UnityEngine.Object obj);
	}
	*/

	// public sealed class LunyLuaGameObjectFactory : ILuaGameObjectFactory
	// {
	// 	public ILuaUnityEngineGameObject Create(GameObject obj) => (ILuaUnityEngineGameObject)new Lua_UnityEngine_GameObject(obj);
	// }

	public interface ILuaGameObjectFactory
	{
		ILuaUnityEngineGameObject Create(UnityEngine.GameObject obj);
	}

	public interface ILuaComponentFactory
	{
		ILuaUnityEngineComponent Create(Component component);
	}

	public interface ILuaUnityEngineObject
	{
	}


	public interface ILuaUnityEngineComponent : ILuaUnityEngineObject
	{

	}

	public interface ILuaUnityEngineGameObject : ILuaUnityEngineObject
	{
		// Instantiate
		// Add/GetComponent
		// Destroy
	}
}
