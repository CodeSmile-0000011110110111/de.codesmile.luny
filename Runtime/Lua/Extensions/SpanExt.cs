// Copyright (C) 2021-2025 Steffen Itterheim
// Refer to included LICENSE file for terms and conditions.

using Lua;
using System;
using UnityEditor;
using UnityEngine;

namespace Luny
{
	public static class SpanExt
	{
		public static T[] Convert<T>(this Span<LuaValue> luaValueSpan)
		{
			var length = luaValueSpan.Length;
			var array = new T[length];
			var i = 0;
			for (; i < length; i++)
			{
				if (luaValueSpan[i].Type == LuaValueType.Nil)
					break;

				array[i] = luaValueSpan[i].Read<T>();
			}

			// a LuaValue span may contain padded nil elements
			if (i < length)
				Array.Resize(ref array, i);

			return array;
		}
	}
}
