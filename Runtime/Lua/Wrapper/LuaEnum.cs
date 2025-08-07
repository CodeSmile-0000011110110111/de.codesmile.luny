// Copyright (C) 2021-2025 Steffen Itterheim
// Refer to included LICENSE file for terms and conditions.

using Lua;
using Lua.Runtime;
using Lua.Standard;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using UnityEditor;
using UnityEngine;

namespace Luny
{
	public interface ILuaEnumCollection {}
	public sealed class LuaEnumCollection : Dictionary<Type, LuaValue>, ILuaEnumCollection {}

	public static class LuaEnum
	{
		private const String EnumValuesKey = "values";
		private const String EnumValuesCountKey = "count";
		private const String EnumNameKey = "name";

		private static readonly LuaFunction __len = new(Metamethods.Len, (context, token) =>
		{
			var table = context.GetArgument<LuaTable>(0);
			return new ValueTask<Int32>(context.Return(table.Metatable[EnumValuesCountKey]));
		});

		private static readonly LuaFunction __newindex = new(Metamethods.NewIndex, (context, token) =>
			throw new LuaRuntimeException(context.Thread, "attempt to modify an enum"));

		private static readonly LuaFunction __index = new(Metamethods.Index, (context, token) =>
		{
			var table = context.GetArgument<LuaTable>(0);
			var key = context.GetArgument(1);
			var values = table.Metatable[EnumValuesKey].Read<LuaTable>();
			var enumValue = values[key];
			return new ValueTask<Int32>(context.Return(enumValue));
		});

		private static readonly LuaFunction __pairs = new(Metamethods.Pairs, (context, token) =>
		{
			var table = context.GetArgument<LuaTable>(0);
			var values = table.Metatable[EnumValuesKey];
			return new ValueTask<Int32>(context.Return(Next, values, LuaValue.Nil));
		});

		private static readonly LuaFunction Next = new("next", BasicLibrary.Instance.Next);

		public static LuaValue Bind(Type enumType)
		{
			var enumNames = Enum.GetNames(enumType);
			var enumValues = Enum.GetValues(enumType);
			var valueCount = enumNames.Length;
			var values = new LuaTable(0, valueCount);
			for (var i = 0; i < valueCount; i++)
				values[enumNames[i]] = Convert.ToInt64(enumValues.GetValue(i));

			var metatable = new LuaTable(0, 6);
			//metatable[EnumNameKey] = enumType.Name;
			metatable[EnumValuesKey] = values;
			metatable[EnumValuesCountKey] = valueCount;
			metatable[Metamethods.Index] = __index;
			metatable[Metamethods.NewIndex] = __newindex;
			metatable[Metamethods.Len] = __len;
			metatable[Metamethods.Pairs] = __pairs;

			var enumTable = new LuaTable(0, 0);
			enumTable.Metatable = metatable;
			return enumTable;
		}
	}
}
