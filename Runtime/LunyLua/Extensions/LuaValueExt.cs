// Copyright (C) 2021-2025 Steffen Itterheim
// Refer to included LICENSE file for terms and conditions.

using Lua;
using System;
using System.Linq;
using UnityEditor;
using UnityEngine;

namespace Luny
{
	public static class LuaValueExt
	{
		public static Boolean TryReadArray<T>(this LuaValue luaValue, out T[] array)
		{
			if (luaValue.TryRead<LuaTable>(out var table))
			{
				array = table.GetArraySpan().Convert<T>();
				return true;
			}
			if (luaValue.TryRead<LuaList<T>>(out var list))
			{
				array = list.ManagedObjects.ToArray();
				return true;
			}

			array = default;
			return false;
		}
	}
}
