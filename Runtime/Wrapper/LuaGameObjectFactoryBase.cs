// Copyright (C) 2021-2025 Steffen Itterheim
// Refer to included LICENSE file for terms and conditions.

using UnityEditor;
using UnityEngine;

namespace CodeSmile.Luny
{
	public abstract class LuaGameObjectFactoryBase
	{
		public abstract ILuaUnityEngineGameObject Create(GameObject gameObject);
	}
}
