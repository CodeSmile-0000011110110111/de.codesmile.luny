// Copyright (C) 2021-2025 Steffen Itterheim
// Refer to included LICENSE file for terms and conditions.

using Lua;
using System;
using UnityEditor;
using UnityEngine;

namespace Luny
{
	internal sealed class LuaCallbackFunctions
	{
		private readonly LuaFunction[] m_CallbackFunctions;

		internal LuaCallbackFunctions(LuaFunction[] callbackFunctions) => m_CallbackFunctions = callbackFunctions;

		public void TryInvoke(LuaState luaState, Int32 index, params LuaValue[] args)
		{
			var eventFunc = m_CallbackFunctions[index];
			if (eventFunc == null)
				return;

			var access = luaState.RootAccess;

			// push any function arguments onto stack
			var argCount = args.Length;
			if (argCount > 0)
			{
				var stack = access.Thread.Stack;
				foreach (var arg in args)
					stack.Push(arg);
			}

			try
			{
				// force synchronous execution, otherwise events like OnDestroy may run after the object has been destroyed
				access.RunAsync(eventFunc, argCount).Preserve().GetAwaiter().GetResult();
			}
			catch (LuaRuntimeException e)
			{
				LunyLogger.LogException(e);
			}
		}
	}
}
