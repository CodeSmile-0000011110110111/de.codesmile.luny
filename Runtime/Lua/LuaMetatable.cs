// Copyright (C) 2021-2025 Steffen Itterheim
// Refer to included LICENSE file for terms and conditions.

using Lua;
using Lua.Runtime;
using System;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

namespace Luny
{
	public static class LuaMetatable
	{
		public static LuaTable Create(LuaFunction indexFunc, LuaFunction newIndexFunc = null)
		{
			var metatable = new LuaTable(0, newIndexFunc == null ? 2 : 3);
			if (newIndexFunc != null) metatable[Metamethods.NewIndex] = newIndexFunc;
			metatable[Metamethods.Index] = indexFunc;
			metatable[Metamethods.ToString] = LuaFunctions.LuaToStringMetamethod;
			return metatable;
		}

		public static LuaTable Create(Dictionary<String, LuaFunction> metaFunctions)
		{
			var metatable = new LuaTable(0, metaFunctions.Count);
			foreach (var nameAndFunction in metaFunctions)
				metatable[nameAndFunction.Key] = nameAndFunction.Value;

			if (metatable.ContainsKey(Metamethods.ToString) == false)
				metatable[Metamethods.ToString] = LuaFunctions.LuaToStringMetamethod;

			return metatable;
		}
	}
}
