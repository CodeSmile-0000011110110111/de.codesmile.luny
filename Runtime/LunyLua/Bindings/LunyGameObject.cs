// Copyright (C) 2021-2025 Steffen Itterheim
// Refer to included LICENSE file for terms and conditions.

using System;
using UnityEditor;
using UnityEngine;

namespace Luny
{
	// the ILuaxxx interfaces are needed to safely reference these types in absence of generated UnityEngine code
	public interface ILuaUnityObject {}

	public interface ILuaUnityGameObject
	{
		// Instantiate
		// Add/GetComponent
		// Destroy
	}

	public interface ILuaUnityComponent {}

	public interface ILunyGameObject {}

	public sealed class LunyGameObject : ILunyGameObject
	{
		private ILuaUnityGameObject m_LuaGameObject;
		private GameObject m_UnityGameObject;

		public GameObject UnityGameObject => m_UnityGameObject;
		public ILuaUnityGameObject LuaGameObject => m_LuaGameObject;

		public LunyGameObject(ILunyLua lua, GameObject gameObject) => throw new NotImplementedException(nameof(LunyGameObject));

		//m_LuaGameObject = lua.ObjectFactory.CreateLuaObject(m_UnityGameObject) as ILuaUnityGameObject;
		//m_UnityGameObject = gameObject;
		internal void Dispose()
		{
			m_UnityGameObject = null;
			m_LuaGameObject = null;
		}
	}

	// TODO: how to best hook into the gameobject/component lifecycle?

	/*
	public delegate bool TryGetLuaComponentDelegate(Component unityComponent, out Lua_UnityEngine_Component luaComponent);
	public static TryGetLuaComponentDelegate TryGetLuaComponent;
	private static readonly LuaFunction _Lua_UnityEngine_GameObject_GetComponent = new("GetComponent", (_context, _) =>
	{
			if (_argCount == 2)
			{
				var type = _p0_System_Type;
				var _ret0 = _instance.m_Instance.GetComponent(type);
				if (TryGetLuaComponent == null || TryGetLuaComponent.Invoke(_ret0, out var _v0) == false)
					_v0 = new Lua_UnityEngine_Component(_ret0);
				var _lret0 = new LuaValue(_v0);
				var _retCount = _context.Return(_lret0);
				return new ValueTask<System.Int32>(_retCount);
			}
		}
		*/
}
