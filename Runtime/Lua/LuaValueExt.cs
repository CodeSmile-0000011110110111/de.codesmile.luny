// Copyright (C) 2021-2025 Steffen Itterheim
// Refer to included LICENSE file for terms and conditions.

using Lua;
using System;
using UnityEditor;
using UnityEngine;

namespace CodeSmile.Luny
{
	public static class LuaValueExt
	{
		public static T As<T>(this LuaValue value, T defaultValue = default) =>
			value.TryRead<T>(out var readValue) ? readValue : defaultValue;

		public static LuaValue ValueOrNil(ILuaUserData value) => value != null ? new LuaValue(value) : LuaValue.Nil;

		public static Boolean IsBoolean(this LuaValue value) => value.Type == LuaValueType.Boolean;
		public static Boolean IsFunction(this LuaValue value) => value.Type == LuaValueType.Function;
		public static Boolean IsNil(this LuaValue value) => value.Type == LuaValueType.Nil;
		public static Boolean IsNumber(this LuaValue value) => value.Type == LuaValueType.Number;
		public static Boolean IsString(this LuaValue value) => value.Type == LuaValueType.String;
		public static Boolean IsTable(this LuaValue value) => value.Type == LuaValueType.Table;
		public static Boolean IsThread(this LuaValue value) => value.Type == LuaValueType.Thread;
		public static Boolean IsUserData(this LuaValue value) => value.Type == LuaValueType.UserData;
		public static Boolean BoolOrDefault(this LuaValue value) => value.TryRead(out Boolean result) ? result : default;
		public static Int32 IntOrDefault(this LuaValue value) => value.TryRead(out Int32 result) ? result : default;
		public static Int64 LongOrDefault(this LuaValue value) => value.TryRead(out Int64 result) ? result : default;
		public static Single FloatOrDefault(this LuaValue value) => value.TryRead(out Single result) ? result : default;
		public static Double DoubleOrDefault(this LuaValue value) => value.TryRead(out Double result) ? result : default;
		public static String StringOrDefault(this LuaValue value) => value.TryRead(out String result) ? result : default;
		public static LuaTable TableOrDefault(this LuaValue value) => value.TryRead(out LuaTable result) ? result : default;

		public static LuaFunction FunctionOrDefault(this LuaValue value) =>
			value.TryRead(out LuaFunction result) ? result : default;

		public static ILuaUserData UserDataOrDefault(this LuaValue value) =>
			value.TryRead(out ILuaUserData result) ? result : default;
	}
}
