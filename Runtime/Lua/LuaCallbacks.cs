// Copyright (C) 2021-2025 Steffen Itterheim
// Refer to included LICENSE file for terms and conditions.

using Lua;
using Lua.Runtime;
using System;
using UnityEditor;
using UnityEngine;

namespace CodeSmile.Luny
{
	internal sealed class LuaCallbacks
	{
		private readonly LuaFunction[] m_CallbackFunctions;

		internal LuaCallbacks(LuaFunction[] callbackFunctions) => m_CallbackFunctions = callbackFunctions;

		public LuaValue[] TryInvoke(LuaState luaState, Int32 index, params LuaValue[] args)
		{
			var func = m_CallbackFunctions[index];
			if (func == null)
				return null;

			var access = luaState.RootAccess;
			var argCount = args.Length;
			if (argCount > 0)
			{
				var stack = access.Thread.Stack;
				foreach (var arg in args)
					stack.Push(arg);
			}

			LuaValue[] returnValues = null;
			try
			{
				// force synchronous execution, otherwise events like OnDestroy may try to run after the object has been destroyed
				var returnCount = access.RunAsync(func, argCount).Preserve().GetAwaiter().GetResult();
				using var results = access.ReadReturnValues(returnCount);
				returnValues = results.AsSpan().ToArray();
			}
			catch (LuaRuntimeException e)
			{
				LunyLogger.LogException(e);
			}

			return returnValues;
		}
	}
}
