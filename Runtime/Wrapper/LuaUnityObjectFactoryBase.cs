// Copyright (C) 2021-2025 Steffen Itterheim
// Refer to included LICENSE file for terms and conditions.

using Lua;
using UnityEditor;
using UnityEngine;

namespace CodeSmile.Luny
{
	public abstract class LuaUnityObjectFactoryBase
	{
		public abstract ILuaUnityGameObject CreateLuaGameObject(GameObject gameObject);

		public abstract ILuaUnityObject CreateLuaObject(Object instance);

		public static ILuaUserData CreateLuaInstance(Object instance)
		{
			return null;
		}
	}
}
