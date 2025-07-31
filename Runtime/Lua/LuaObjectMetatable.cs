// Copyright (C) 2021-2025 Steffen Itterheim
// Refer to included LICENSE file for terms and conditions.

using Lua;
using Lua.Runtime;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using UnityEditor;
using UnityEngine;

namespace CodeSmile.Luny
{
	public static class LuaObjectMetatable
	{
		private static readonly LuaFunction __tostring = new(Metamethods.ToString, (context, _) =>
			{
				var arg = context.GetArgument<ILuaUserData>(0);
				return new ValueTask<Int32>(context.Return(arg.ToString()));
			}
		);

		public static LuaTable Create(LuaFunction indexFunc, LuaFunction newIndexFunc)
		{
			var metatable = new LuaTable(0, 3);
			metatable[Metamethods.Index] = indexFunc;
			metatable[Metamethods.NewIndex] = newIndexFunc;
			metatable[Metamethods.ToString] = __tostring;
			return metatable;
		}

		public static LuaTable Create(Dictionary<String, LuaFunction> metaFunctions)
		{
			var metatable = new LuaTable(0, metaFunctions.Count);
			foreach (var nameAndFunction in metaFunctions)
				metatable[nameAndFunction.Key] = nameAndFunction.Value;

			if (metatable.ContainsKey(Metamethods.ToString) == false)
				metatable[Metamethods.ToString] = __tostring;

			return metatable;
		}
	}
}
