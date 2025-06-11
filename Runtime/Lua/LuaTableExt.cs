// Copyright (C) 2021-2025 Steffen Itterheim
// Refer to included LICENSE file for terms and conditions.

using Lua;
using System;
using System.Collections.Generic;
using System.Text;
using UnityEditor;
using UnityEngine;
using Object = System.Object;

namespace CodeSmile.Luny
{
	public static class LuaTableExt
	{
		public static void SetValues(this LuaTable table, IList<LuaValue> values)
		{
			var count = values.Count;
			var luaIndex = 1;
			for (var i = 0; i < count; i++, luaIndex++)
				table[luaIndex] = values[i];
		}

		public static void SetValues(this LuaTable table, IList<object> values)
		{
			var count = values.Count;
			var luaIndex = 1;
			for (var i = 0; i < count; i++, luaIndex++)
				table[luaIndex] = LuaValue.FromObject(values[i]);
		}

		public static void SetValues(this LuaTable table, IList<String> values)
		{
			var count = values.Count;
			var luaIndex = 1;
			for (var i = 0; i < count; i++, luaIndex++)
				table[luaIndex] = values[i];
		}

		public static void SetValues(this LuaTable table, IList<Boolean> values)
		{
			var count = values.Count;
			var luaIndex = 1;
			for (var i = 0; i < count; i++, luaIndex++)
				table[luaIndex] = values[i];
		}

		public static void SetValues(this LuaTable table, IList<Byte> values)
		{
			var count = values.Count;
			var luaIndex = 1;
			for (var i = 0; i < count; i++, luaIndex++)
				table[luaIndex] = values[i];
		}

		public static void SetValues(this LuaTable table, IList<SByte> values)
		{
			var count = values.Count;
			var luaIndex = 1;
			for (var i = 0; i < count; i++, luaIndex++)
				table[luaIndex] = values[i];
		}

		public static void SetValues(this LuaTable table, IList<Int16> values)
		{
			var count = values.Count;
			var luaIndex = 1;
			for (var i = 0; i < count; i++, luaIndex++)
				table[luaIndex] = values[i];
		}

		public static void SetValues(this LuaTable table, IList<UInt16> values)
		{
			var count = values.Count;
			var luaIndex = 1;
			for (var i = 0; i < count; i++, luaIndex++)
				table[luaIndex] = values[i];
		}

		public static void SetValues(this LuaTable table, IList<Int32> values)
		{
			var count = values.Count;
			var luaIndex = 1;
			for (var i = 0; i < count; i++, luaIndex++)
				table[luaIndex] = values[i];
		}

		public static void SetValues(this LuaTable table, IList<UInt32> values)
		{
			var count = values.Count;
			var luaIndex = 1;
			for (var i = 0; i < count; i++, luaIndex++)
				table[luaIndex] = values[i];
		}

		public static void SetValues(this LuaTable table, IList<Int64> values)
		{
			var count = values.Count;
			var luaIndex = 1;
			for (var i = 0; i < count; i++, luaIndex++)
				table[luaIndex] = values[i];
		}

		public static void SetValues(this LuaTable table, IList<UInt64> values)
		{
			var count = values.Count;
			var luaIndex = 1;
			for (var i = 0; i < count; i++, luaIndex++)
				table[luaIndex] = values[i];
		}

		public static void SetValues(this LuaTable table, IList<Single> values)
		{
			var count = values.Count;
			var luaIndex = 1;
			for (var i = 0; i < count; i++, luaIndex++)
				table[luaIndex] = values[i];
		}

		public static void SetValues(this LuaTable table, IList<Double> values)
		{
			var count = values.Count;
			var luaIndex = 1;
			for (var i = 0; i < count; i++, luaIndex++)
				table[luaIndex] = values[i];
		}

		public static void SetValues(this LuaTable table, IList<LuaValue> keys, IList<LuaValue> values)
		{
			Debug.Assert(keys != null);
			Debug.Assert(values != null);
			Debug.Assert(keys.Count == values.Count, "key-value count mismatch");

			var count = keys.Count;
			for (var i = 0; i < count; i++)
				table[keys[i]] = values[i];
		}

		public static void SetValues(this LuaTable table, IList<Object> keys, IList<Object> values)
		{
			Debug.Assert(keys != null);
			Debug.Assert(values != null);
			Debug.Assert(keys.Count == values.Count, "key-value count mismatch");

			var count = keys.Count;
			for (var i = 0; i < count; i++)
				table[LuaValue.FromObject(keys[i])] = LuaValue.FromObject(values[i]);
		}

		public static void SetValues(this LuaTable table, IEnumerable<KeyValuePair<LuaValue, LuaValue>> keyValuePairs)
		{
			foreach (var pair in keyValuePairs)
				table[pair.Key] = pair.Value;
		}

		public static void SetValues(this LuaTable table, IEnumerable<KeyValuePair<Object, Object>> keyValuePairs)
		{
			foreach (var pair in keyValuePairs)
				table[LuaValue.FromObject(pair.Key)] = LuaValue.FromObject(pair.Value);
		}

		public static Boolean IsNil(this LuaTable table, String name) => table.ContainsKey(name) == false;

		public static LuaValue GetValue(this LuaTable table, String name) =>
			table.TryGetValue(name, out var value) ? value : default;

		public static Boolean GetBool(this LuaTable table, String name) =>
			table.TryGetValue(name, out var value) ? value.BoolOrDefault() : default;

		public static Int32 GetInt(this LuaTable table, String name) =>
			table.TryGetValue(name, out var value) ? value.IntOrDefault() : default;

		public static Int64 GetLong(this LuaTable table, String name) =>
			table.TryGetValue(name, out var value) ? value.LongOrDefault() : default;

		public static Single GetFloat(this LuaTable table, String name) =>
			table.TryGetValue(name, out var value) ? value.FloatOrDefault() : default;

		public static Double GetDouble(this LuaTable table, String name) =>
			table.TryGetValue(name, out var value) ? value.DoubleOrDefault() : default;

		public static String GetString(this LuaTable table, String name) =>
			table.TryGetValue(name, out var value) ? value.StringOrDefault() : default;

		public static LuaTable GetTable(this LuaTable table, String name) =>
			table.TryGetValue(name, out var value) ? value.TableOrDefault() : default;

		public static LuaFunction GetFunction(this LuaTable table, String name) =>
			table.TryGetValue(name, out var value) ? value.FunctionOrDefault() : default;

		public static ILuaUserData GetUserData(this LuaTable table, String name) =>
			table.TryGetValue(name, out var value) ? value.UserDataOrDefault() : default;

		public static void SetNil(this LuaTable table, String name) => table[name] = LuaValue.Nil;
		public static void SetValue(this LuaTable table, String name, LuaValue value) => table[name] = value;
		public static void SetBool(this LuaTable table, String name, Boolean value) => table[name] = value;
		public static void SetInt(this LuaTable table, String name, Int32 value) => table[name] = value;
		public static void SetLong(this LuaTable table, String name, Int64 value) => table[name] = value;
		public static void SetFloat(this LuaTable table, String name, Single value) => table[name] = value;
		public static void SetDouble(this LuaTable table, String name, Double value) => table[name] = value;
		public static void SetString(this LuaTable table, String name, String value) => table[name] = value ?? LuaValue.Nil;
		public static void SetTable(this LuaTable table, String name, LuaTable value) => table[name] = value ?? LuaValue.Nil;

		public static void SetFunction(this LuaTable table, String name, LuaFunction value) =>
			table[name] = value ?? LuaValue.Nil;

		public static void SetUserData(this LuaTable table, String name, ILuaUserData value) =>
			table[name] = value != null ? new LuaValue(value) : LuaValue.Nil;

		public static String Dump(this LuaTable table, String name)
		{
			var sb = new StringBuilder($"{name} = {{\n");

			var arrayLength = table.ArrayLength;
			for (var i = 0; i < arrayLength; i++)
				sb.AppendLine($"\t[{i}] = {table[i]}");

			var hashCount = table.HashMapCount;
			if (hashCount > 0)
			{
				var nextKey = LuaValue.Nil;
				for (var i = 0; i < hashCount; i++)
				{
					table.TryGetNext(nextKey, out var kvp);
					nextKey = kvp.Key;
					if (kvp.Value.Type == LuaValueType.Table)
					{
						var t = kvp.Value.Read<LuaTable>();
						sb.AppendLine($"\t[\"{kvp.Key}\"] = {kvp.Value}  [{t.ArrayLength}]  {{{t.HashMapCount}}}");
					}
					else
						sb.AppendLine($"\t[\"{kvp.Key}\"] = {kvp.Value}");
				}
			}
			sb.AppendLine("}");

			return sb.ToString();
		}
	}
}
