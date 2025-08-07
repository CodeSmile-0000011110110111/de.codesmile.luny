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
		public static Boolean TryReadArray<T>(this LuaValue luaValue, out LuaValue[] array)
		{
			var type = typeof(T);
			if (type.IsArray)
			{
				if (luaValue.TryRead<LuaTable>(out var table))
				{
					array = table.GetArraySpan().ToArray();
					return true;
				}
				if (luaValue.TryRead<LuaList<T>>(out var list))
				{
					array = list.LuaValues.ToArray();
					return true;
				}
			}

			array = default;
			return false;
		}
	}

	public static class LuaTableExt
	{
		public static T[] ToArray<T>(this LuaTable table)
		{
			var tableArray = table.GetArraySpan();
			var arrayLength = table.ArrayLength;

			var array = new T[arrayLength];
			for (var i = 1; i <= arrayLength; i++)
				array[i - 1] = tableArray[i].Read<T>();

			return array;
		}

		public static T[] ToArray<T>(this LuaTable table, ILuaObjectFactory factory) where T : class
		{
			var type = typeof(T);
			var isLuaObjectType = typeof(ILuaObject<T>).IsAssignableFrom(type);
			if (!isLuaObjectType)
				return table.ToArray<T>();

			var tableArray = table.GetArraySpan();
			var arrayLength = table.ArrayLength;

			var array = new T[arrayLength];
			for (var i = 1; i <= arrayLength; i++)
			{
				var luaObject = tableArray[i].Read<ILuaObject<T>>();
				array[i - 1] = luaObject.Instance;
			}

			return array;
		}
	}
}
