// Copyright (C) 2021-2025 Steffen Itterheim
// Refer to included LICENSE file for terms and conditions.

using Lua;
using System;
using System.Threading.Tasks;
using UnityEditor;
using UnityEngine;
using UnityEngine.Scripting;

namespace Luny
{
	public static class LuaStringLibraryExtensions
	{
		[Preserve] private static readonly LuaFunction _startsWith = new("StartsWith", (context, token) =>
		{
			var str = context.GetArgument<String>(0);
			var suffix = context.GetArgument<String>(1);
			var result = str.EndsWith(suffix);
			return new ValueTask<Int32>(context.Return(result));
		});
		[Preserve] private static readonly LuaFunction _endsWith = new("EndsWith", (context, token) =>
		{
			var str = context.GetArgument<String>(0);
			var suffix = context.GetArgument<String>(1);
			var result = str.EndsWith(suffix);
			return new ValueTask<Int32>(context.Return(result));
		});
		[Preserve] private static readonly LuaFunction _contains = new("Contains", (context, token) =>
		{
			var str = context.GetArgument<String>(0);
			var suffix = context.GetArgument<String>(1);
			var result = str.Contains(suffix);
			return new ValueTask<Int32>(context.Return(result));
		});

		internal static void OpenStringLibraryExtensions(this LuaState luaState)
		{
			var stringTable = luaState.Environment["string"].Read<LuaTable>();
			stringTable[_startsWith.Name] = _startsWith;
			stringTable[_endsWith.Name] = _endsWith;
			stringTable[_contains.Name] = _contains;
		}
	}
}
