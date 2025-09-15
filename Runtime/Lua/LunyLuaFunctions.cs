// Copyright (C) 2021-2025 Steffen Itterheim
// Refer to included LICENSE file for terms and conditions.

using Lua;
using Lua.Runtime;
using System;
using System.Threading.Tasks;
using UnityEditor;
using UnityEngine;
using UnityEngine.Scripting;
using Object = System.Object;

namespace Luny
{
	internal static class LunyLuaFunctions
	{
		[Preserve] internal static readonly LuaFunction LuaNameOf = new("nameof", (context, _) =>
		{
			String typeName;
			var arg0 = context.GetArgument(0);
			switch (arg0.Type)
			{
				case LuaValueType.Nil: typeName = nameof(LuaValueType.Nil); break;
				case LuaValueType.Boolean: typeName = nameof(Boolean); break;
				case LuaValueType.String: typeName = nameof(String); break;
				case LuaValueType.Number: typeName = nameof(Double); break;
				case LuaValueType.Function: typeName = nameof(LuaFunction); break;
				case LuaValueType.Thread: typeName = nameof(LuaThread); break;
				case LuaValueType.UserData or LuaValueType.LightUserData:
					if (arg0.TryRead(out Object userValue) && userValue != null)
						typeName = userValue is ILuaBindType bt ? bt.BindType?.FullName : userValue.GetType().FullName;
					else
						typeName = "(null)";
					break;
				case LuaValueType.Table: typeName = nameof(LuaTable); break;
				case var _: throw new NotImplementedException();
			}
			return new ValueTask<Int32>(context.Return(typeName));
		});

		// [Preserve] internal static readonly LuaFunction LuaUsing = new("using", (context, _) =>
		// {
		// 	var arg0 = context.GetArgument(0);
		// 	if (arg0.TryRead(out LuaTable usings))
		// 	{
		// 		var namespaces = context.GetNamespaces();
		// 		namespaces.MoveToBack(usings);
		// 	}
		//
		// 	return new ValueTask<Int32>(context.Return());
		// });

		[Preserve] internal static LuaFunction LunyEnvironmentIndex = new(Metamethods.Index, (context, _) =>
		{
			var env = context.GetArgument<LuaTable>(0);
			var key = context.GetArgument<String>(1);

			// try reading from env table first
			if (env.TryGetValue(key, out var value))
				return new ValueTask<Int32>(context.Return(value));

			// lookup key in namespaces, try find its type
			var lunyLua = context.State.GetLunyLua();
			if (lunyLua.Namespaces.TryGetLuaType(key, out var luaType))
				return new ValueTask<Int32>(context.Return(luaType));

			return new ValueTask<Int32>(context.Return(LuaValue.Nil));
		});

		[Preserve] internal static readonly LuaFunction LunyDoFile = new("dofile", async (context, token) =>
		{
			var arg0 = context.GetArgument<String>(0);
			context.Thread.Stack.PopUntil(context.ReturnFrameBase);
			var closure = await context.State.LunyLoadFileAsync(arg0, null, token);
			return await context.Access.RunAsync(closure, token);
		});

		[Preserve] internal static readonly LuaFunction LunyLoadFile = new("loadfile", async (context, token) =>
		{
			var arg0 = context.GetArgument<String>(0);
			var arg2 = context.HasArgument(2) ? context.GetArgument<LuaTable>(2) : null;
			try
			{
				// do not use LuaState.DoFileAsync as it uses the newExecutionContext
				return context.Return(await context.State.LunyLoadFileAsync(arg0, arg2, token));
			}
			catch (Exception ex)
			{
				return context.Return(LuaValue.Nil, ex.Message);
			}
		});
	}
}
