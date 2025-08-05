// Copyright (C) 2021-2025 Steffen Itterheim
// Refer to included LICENSE file for terms and conditions.

using Lua;
using Lua.Runtime;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace CodeSmile.Luny
{
	public sealed partial class LuaList<T>
	{
		private static readonly LuaFunction __index = new(Metamethods.Index, (context, _) =>
		{
			var self = context.GetArgument<LuaList<T>>(0);
			var key = context.GetArgument(1);

			if (!key.TryRead<Int32>(out var index))
				throw new LuaRuntimeException(context.Thread, $"index must be a number, got: {key.Type}");

			var list = self.ManagedObjects;
			if (list == null)
				throw new LuaRuntimeException(context.Thread, "managed list is null.");

			if (index < 1 || index > list.Count)
				throw new LuaRuntimeException(context.Thread, $"index {index} out of range [1, {list.Count}]");

			var managedItem = list[index - 1];
			var value = context.GetObjectFactory().Bind(managedItem);
			return new ValueTask<Int32>(context.Return(value));
		});

		private static readonly LuaFunction __len = new(Metamethods.Len, (context, _) =>
		{
			var self = context.GetArgument<LuaList<T>>(0);
			var value = self.ManagedObjects?.Count ?? 0;
			return new ValueTask<Int32>(context.Return(value));
		});

		private static readonly LuaFunction __ipairs = new(Metamethods.IPairs, (context, _) =>
		{
			// ipairs
			var self = context.GetArgument<LuaList<T>>(0);
			var luaIndex = context.GetArgument<int>(1);

			luaIndex++;
			if (luaIndex >= 0 && luaIndex <= self.Count)
			{
				var managedIndex = luaIndex - 1;
				var luaValue = self.m_LuaValues[managedIndex];
				if (luaValue.Type == LuaValueType.Nil)
				{
					var managedObject = self[managedIndex];
					luaValue = context.GetObjectFactory().Bind(managedObject);
					self.m_LuaValues[managedIndex] = luaValue;
				}
				return new(context.Return(luaIndex, luaValue));
			}

			return new(context.Return(LuaValue.Nil, LuaValue.Nil));

			// pairs
			/*
			var arg0 = context.GetArgument<LuaTable>(0);
			var arg1 = context.HasArgument(1) ? context.Arguments[1] : LuaValue.Nil;

			if (arg0.TryGetNext(arg1, out var kv))
			{
				return new(context.Return(kv.Key, kv.Value));
			}
			else
			{
				return new(context.Return(LuaValue.Nil));
			}
			*/

		});

		private static LuaTable s_Metatable = LuaMetatable.Create(new Dictionary<String, LuaFunction>
		{
			{ Metamethods.Index, __index },
			{ Metamethods.Len, __len },
			{ Metamethods.Pairs, __ipairs },
			{ Metamethods.IPairs, __ipairs },
		});

		public LuaTable Metatable
		{
			get => s_Metatable ??= LuaMetatable.Create(__index);
			set => throw new NotSupportedException("can't set Metatable of LuaArray");
		}
	}
}
