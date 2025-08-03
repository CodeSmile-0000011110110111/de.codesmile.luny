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

namespace CodeSmile.Luny
{
	public interface ILuaEnums {}

	public interface ILuaEnum {}

	public sealed class LuaEnums : Dictionary<Type, LuaCustomTypes>, ILuaEnums {}

	// TODO: consider refactoring to wrap enum LuaTable to LuaEnum instance
	public sealed class LuaCustomTypes : ILuaEnum
	{
		private const String EnumValuesKey = "values";
		private const String EnumValuesCountKey = "count";
		private const String EnumNameKey = "name";

		private static readonly LuaFunction _enumLenFunc = new("enum.__len", (context, token) =>
		{
			var table = context.GetArgument<LuaTable>(0);
			return new ValueTask<Int32>(context.Return(table.Metatable[EnumValuesCountKey]));
		});

		private static readonly LuaFunction _enumNewIndexFunc = new("enum.__newindex", (context, token) =>
			throw new LuaRuntimeException(context.Thread, "attempt to modify an enum"));

		private static readonly LuaFunction _enumIndexFunc = new("enum.__index", (context, token) =>
		{
			var table = context.GetArgument<LuaTable>(0);
			var key = context.GetArgument(1);
			var values = table.Metatable[EnumValuesKey].Read<LuaTable>();
			var enumValue = values[key];
			return new ValueTask<Int32>(context.Return(enumValue));
		});

		private static readonly LuaFunction _nextFunc = new("next", BasicLibrary.Instance.Next);
		private static readonly LuaFunction _enumPairsFunc = new("enum.__pairs", (context, token) =>
		{
			var table = context.GetArgument<LuaTable>(0);
			var values = table.Metatable[EnumValuesKey];
			return new ValueTask<Int32>(context.Return(_nextFunc, values, LuaValue.Nil));
		});

		public Type Type { get; }
		public LuaTable Table { get; }

		public static LuaCustomTypes Create(Type enumType)
		{
			var enumNames = Enum.GetNames(enumType);
			var enumValues = Enum.GetValues(enumType);
			var valueCount = enumNames.Length;
			var values = new LuaTable(0, valueCount);
			for (var i = 0; i < valueCount; i++)
				values[enumNames[i]] = Convert.ToDouble(enumValues.GetValue(i));

			var metatable = new LuaTable(0, 6);
			//metatable[EnumNameKey] = enumType.Name;
			metatable[EnumValuesKey] = values;
			metatable[EnumValuesCountKey] = valueCount;
			metatable[Metamethods.Index] = _enumIndexFunc;
			metatable[Metamethods.NewIndex] = _enumNewIndexFunc;
			metatable[Metamethods.Len] = _enumLenFunc;
			metatable[Metamethods.Pairs] = _enumPairsFunc;

			var enumTable = new LuaTable(0, 0);
			enumTable.Metatable = metatable;
			return new LuaCustomTypes(enumType, enumTable);
		}

		private LuaCustomTypes(Type type, LuaTable enumTable)
		{
			Type = type;
			Table = enumTable;
		}
	}
}
