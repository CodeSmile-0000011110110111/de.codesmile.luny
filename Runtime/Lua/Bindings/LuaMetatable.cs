// Copyright (C) 2021-2025 Steffen Itterheim
// Refer to included LICENSE file for terms and conditions.

using Lua;
using Lua.Runtime;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using UnityEditor;
using UnityEngine;
using UnityEngine.Scripting;
using Object = System.Object;

namespace Luny
{
	public static class LuaMetatable
	{
		[Preserve] public static readonly LuaFunction ToStringMetamethod = new(Metamethods.ToString,
			(context, _) => new ValueTask<Int32>(context.Return(context.GetArgument<ILuaUserData>(0).ToString())));

		[Preserve] public static readonly LuaFunction ConcatMetamethod = new(Metamethods.Concat, (context, _) =>
		{
			var a = context.GetArgument(0);
			var b = context.GetArgument(1);

			String astr = default;
			String bstr = default;
			if (a.Type == LuaValueType.UserData)
				astr = a.Read<ILuaUserData>()?.ToString();
			else if (a.Type == LuaValueType.LightUserData)
				astr = a.Read<Object>()?.ToString();
			else
				astr = a.ToString();

			if (b.Type == LuaValueType.UserData)
				bstr = b.Read<ILuaUserData>()?.ToString();
			else if (b.Type == LuaValueType.LightUserData)
				bstr = b.Read<Object>()?.ToString();
			else
				bstr = b.ToString();

			return new ValueTask<Int32>(context.Return($"{astr}{bstr}"));
		});

		public static LuaTable Create(LuaFunction indexFunc, LuaFunction newIndexFunc = null)
		{
			var metatable = new LuaTable(0, newIndexFunc == null ? 3 : 4);
			if (newIndexFunc != null) metatable[Metamethods.NewIndex] = newIndexFunc;
			metatable[Metamethods.Index] = indexFunc;
			metatable[Metamethods.ToString] = ToStringMetamethod;
			metatable[Metamethods.Concat] = ConcatMetamethod;
			return metatable;
		}

		public static LuaTable Create(Dictionary<String, LuaFunction> metaFunctions)
		{
			var metatable = new LuaTable(0, metaFunctions.Count);
			foreach (var nameAndFunction in metaFunctions)
				metatable[nameAndFunction.Key] = nameAndFunction.Value;

			if (metatable.ContainsKey(Metamethods.ToString) == false)
				metatable[Metamethods.ToString] = ToStringMetamethod;
			if (metatable.ContainsKey(Metamethods.Concat) == false)
				metatable[Metamethods.Concat] = ConcatMetamethod;

			return metatable;
		}
	}
}
