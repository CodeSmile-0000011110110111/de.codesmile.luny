// Copyright (C) 2021-2025 Steffen Itterheim
// Refer to included LICENSE file for terms and conditions.

using Lua;
using UnityEditor;
using UnityEngine;

namespace CodeSmile.Luny
{
	public sealed class LunyLuaStateData
	{
		public ILuaObjectFactory ObjectFactory { get; set; }
	}
}
