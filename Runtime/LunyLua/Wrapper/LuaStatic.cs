// Copyright (C) 2021-2025 Steffen Itterheim
// Refer to included LICENSE file for terms and conditions.

using Lua;
using System;
using UnityEditor;
using UnityEngine;

namespace Luny
{
	// cannot be generic because static types cannot be used as generic type arguments
	public interface ILuaStatic : ILuaBindType
	{
		static LuaValue Bind(Type staticType) => throw new NotImplementedException();
	}

	// public sealed class LuaStatic : ILuaStatic
	// {
	// 	public LuaTable Metatable { get; set; }
	// 	public Type BindType { get; }
	// 	public static implicit operator LuaValue(LuaStatic obj) => new(obj);
	// 	public static LuaValue Bind(Type staticType) => new LuaStatic(staticType);
	// 	private LuaStatic(Type staticType) => BindType = staticType;
	// }
}
