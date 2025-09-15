// Copyright (C) 2021-2025 Steffen Itterheim
// Refer to included LICENSE file for terms and conditions.

using Lua;
using System;
using UnityEditor;
using UnityEngine;

namespace Luny
{
	/// <summary>
	/// Bound objects can implement this to respond to value get/set operations.
	/// </summary>
	public interface ILuaIndexable
	{
		/// <summary>
		/// Get value by index. Caution: index is 1-based!
		/// </summary>
		/// <param name="luaIndex"></param>
		/// <param name="value"></param>
		/// <param name="factory"></param>
		/// <returns></returns>
		Boolean TryGetLuaValue(Int32 luaIndex, out LuaValue value, ILuaObjectFactory factory);

		/// <summary>
		/// Get value by key.
		/// </summary>
		/// <param name="key"></param>
		/// <param name="value"></param>
		/// <param name="factory"></param>
		/// <returns></returns>
		Boolean TryGetLuaValue(String key, out LuaValue value, ILuaObjectFactory factory);

		/// <summary>
		/// Set value by index. Caution: index is 1-based!
		/// </summary>
		/// <param name="luaIndex"></param>
		/// <param name="value"></param>
		/// <returns></returns>
		Boolean TrySetLuaValue(Int32 luaIndex, LuaValue value);

		/// <summary>
		/// Set value by key.
		/// </summary>
		/// <param name="key"></param>
		/// <param name="value"></param>
		/// <returns></returns>
		Boolean TrySetLuaValue(String key, LuaValue value);
	}
}
