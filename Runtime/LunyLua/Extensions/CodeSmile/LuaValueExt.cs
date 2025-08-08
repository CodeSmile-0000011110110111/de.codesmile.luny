// Copyright (C) 2021-2025 Steffen Itterheim
// Refer to included LICENSE file for terms and conditions.

using System;
using UnityEditor;
using UnityEngine;
using Object = System.Object;

namespace Lua.Unity
{
	public static class LuaValueExt
	{
		public static String ToString(this LuaValue luaValue) =>
			luaValue.TryRead(out ILuaUserData userData) ? userData.ToString() : luaValue.ToString();

		public static LuaValue ValueOrNil(ILuaUserData value) => value != null ? new LuaValue(value) : LuaValue.Nil;

		public static Boolean IsBoolean(this LuaValue value) => value.Type == LuaValueType.Boolean;
		public static Boolean IsFunction(this LuaValue value) => value.Type == LuaValueType.Function;
		public static Boolean IsNil(this LuaValue value) => value.Type == LuaValueType.Nil;
		public static Boolean IsNumber(this LuaValue value) => value.Type == LuaValueType.Number;
		public static Boolean IsString(this LuaValue value) => value.Type == LuaValueType.String;
		public static Boolean IsTable(this LuaValue value) => value.Type == LuaValueType.Table;
		public static Boolean IsThread(this LuaValue value) => value.Type == LuaValueType.Thread;
		public static Boolean IsUserData(this LuaValue value) => value.Type == LuaValueType.UserData;

		public static T ReadValue<T>(this LuaValue v, T defaultValue = default) => v.TryRead<T>(out var result) ? result : defaultValue;

		public static Boolean ReadBool(this LuaValue v, Boolean defaultValue = default) =>
			v.TryRead(out Boolean result) ? result : defaultValue;

		// Caution: boxing the int value, provided for convenience. For best efficiency read int and cast instead.
		public static T ReadEnum<T>(this LuaValue v, T defaultValue = default) where T : Enum =>
			v.TryRead(out Int32 result) ? (T)(Object)result : defaultValue;

		public static Int32 ReadInt(this LuaValue v, Int32 defaultValue = default) => v.TryRead(out Int32 result) ? result : defaultValue;
		public static Int64 ReadLong(this LuaValue v, Int64 defaultValue = default) => v.TryRead(out Int64 result) ? result : defaultValue;
		public static Single ReadFloat(this LuaValue v, Single defaultValue = default) => v.TryRead(out Single result) ? result : defaultValue;
		public static Double ReadDouble(this LuaValue v, Double defaultValue = default) => v.TryRead(out Double result) ? result : defaultValue;
		public static String ReadString(this LuaValue v, String defaultValue = default) => v.TryRead(out String result) ? result : defaultValue;

		public static LuaTable ReadTable(this LuaValue v, LuaTable defaultValue = default) =>
			v.TryRead(out LuaTable result) ? result : defaultValue;

		public static LuaFunction ReadFunction(this LuaValue value, LuaFunction defaultValue = default) =>
			value.TryRead(out LuaFunction result) ? result : defaultValue;

		public static ILuaUserData ReadUserData(this LuaValue value, ILuaUserData defaultValue = default) =>
			value.TryRead(out ILuaUserData result) ? result : defaultValue;
	}
}
