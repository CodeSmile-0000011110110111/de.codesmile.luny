// Copyright (C) 2021-2025 Steffen Itterheim
// Refer to included LICENSE file for terms and conditions.

using Lua;
using Lua.Runtime;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using UnityEditor;
using UnityEngine;

namespace Luny
{
	public sealed partial class LuaList<T>
	{
		private static readonly LuaFunction __index = new(Metamethods.Index, (context, _) =>
		{
			var list = context.GetArgument<LuaList<T>>(0);
			var key = context.GetArgument(1);

			if (!key.TryRead<Int32>(out var luaIndex))
				throw new LuaRuntimeException(context.Thread, $"index must be a number, got: {key.Type}");

			var objects = list.ManagedObjects;
			if (objects == null)
				throw new LuaRuntimeException(context.Thread, "managed list is null.");

			if (luaIndex < 1 || luaIndex > objects.Count)
				throw new LuaRuntimeException(context.Thread, $"index {luaIndex} out of range [1, {objects.Count}]");

			var value = list.GetLuaValue(luaIndex, context.GetObjectFactory());
			return new ValueTask<Int32>(context.Return(value));
		});

		private static readonly LuaFunction __len = new(Metamethods.Len, (context, _) =>
		{
			var list = context.GetArgument<LuaList<T>>(0);
			var count = list.ManagedObjects?.Count ?? 0;
			return new ValueTask<Int32>(context.Return(count));
		});

		private static readonly LuaFunction __pairs = new(Metamethods.Pairs, (context, _) =>
		{
			var arg0 = context.GetArgument(0);
			return new ValueTask<Int32>(context.Return(LuaListIterator, arg0, LuaValue.Nil));
		});

		private static readonly LuaFunction __ipairs = new(Metamethods.IPairs, (context, _) =>
		{
			var arg0 = context.GetArgument(0);
			return new ValueTask<Int32>(context.Return(LuaListIterator, arg0, LuaValue.Nil));
		});

		private static readonly LuaFunction LuaListIterator = new(nameof(LuaListIterator), (context, token) =>
		{
			var list = context.GetArgument<LuaList<T>>(0);
			var key = context.HasArgument(1) ? context.Arguments[1] : LuaValue.Nil;

			var luaIndex = -1;
			if (key.Type is LuaValueType.Nil)
				luaIndex = 0;
			else if (key.TryRead(out Int32 number) && number > 0 && number < list.Count)
				luaIndex = number;

			if (luaIndex != -1)
			{
				luaIndex++;
				var value = list.GetLuaValue(luaIndex, context.GetObjectFactory());
				return new ValueTask<Int32>(context.Return(luaIndex, value));
			}

			return new ValueTask<Int32>(context.Return(LuaValue.Nil));
		});

		private static LuaTable s_Metatable = LuaMetatable.Create(new Dictionary<String, LuaFunction>
		{
			{ Metamethods.Index, __index },
			{ Metamethods.Len, __len },
			{ Metamethods.Pairs, __pairs },
			{ Metamethods.IPairs, __ipairs },
		});

		public LuaTable Metatable
		{
			get => s_Metatable ??= LuaMetatable.Create(__index);
			set => throw new NotSupportedException("can't set Metatable of LuaArray");
		}
	}
}
