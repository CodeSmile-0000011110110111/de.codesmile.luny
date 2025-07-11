// Copyright (C) 2021-2025 Steffen Itterheim
// Refer to included LICENSE file for terms and conditions.

using Lua;
using Lua.Runtime;
using Lua.Standard;
using System;
using System.Threading.Tasks;
using UnityEditor;
using UnityEngine;

namespace CodeSmileEditor.Luny.Generator
{
	internal static partial class GenUtil
	{
		private const String EnumValuesKey = "values";

		private static readonly LuaFunction _enumLenFunc = new("enum.__len", (context, token) =>
		{
			var table = context.GetArgument<LuaTable>(0);
			var values = table.Metatable[EnumValuesKey].Read<LuaTable>();
			return new ValueTask<Int32>(context.Return(values.HashMapCount));
		});

		private static readonly LuaFunction _enumNewIndexFunc = new("enum.__newindex", (context, token) =>
			throw new LuaRuntimeException(context.Thread, "attempt to modify an enum"));

		private static readonly LuaFunction _enumIndexFunc = new("enum.__index", (context, token) =>
		{
			var table = context.GetArgument<LuaTable>(0);
			var values = table.Metatable[EnumValuesKey].Read<LuaTable>();
			var key = context.GetArgument(1);
			return new ValueTask<Int32>(context.Return(values[key]));
		});

		private static readonly LuaFunction _enumPairsFunc = new("enum.__pairs", (context, token) =>
		{
			var table = context.GetArgument<LuaTable>(0);
			var values = table.Metatable[EnumValuesKey];
			var nextFunc = new LuaFunction("next", BasicLibrary.Instance.Next);
			return new ValueTask<Int32>(context.Return(nextFunc, values, LuaValue.Nil));
		});

		public static LuaTable CreateEnumTable(Type enumType)
		{
			Debug.Assert(enumType.IsEnum);

			var enumNames = Enum.GetNames(enumType);
			var enumValues = Enum.GetValues(enumType);
			var valueCount = enumNames.Length;
			var values = new LuaTable(0, valueCount);
			for (var i = 0; i < valueCount; i++)
				values[enumNames[i]] = (Double)enumValues.GetValue(i);

			var metatable = new LuaTable(0, 5);
			metatable[EnumValuesKey] = values;
			metatable[Metamethods.Index] = _enumIndexFunc;
			metatable[Metamethods.NewIndex] = _enumNewIndexFunc;
			metatable[Metamethods.Len] = _enumLenFunc;
			metatable[Metamethods.Pairs] = _enumPairsFunc;

			var enumTable = new LuaTable(0, 0);
			enumTable.Metatable = metatable;
			return enumTable;
		}
	}
}
