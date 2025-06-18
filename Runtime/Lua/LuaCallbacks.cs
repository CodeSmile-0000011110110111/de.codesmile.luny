// Copyright (C) 2021-2025 Steffen Itterheim
// Refer to included LICENSE file for terms and conditions.

using Lua;
using Lua.Runtime;
using Lua.Unity;
using System;
using UnityEditor;
using UnityEngine;

namespace CodeSmile.Luny
{
	internal sealed class LuaCallbacks<T> where T : Enum
	{
		private readonly LuaFunction[] m_CallbackFunctions;

		public static LuaCallbacks<T> Create<T>(LuaTable context) where T : Enum
		{
			var functionNames = Enum.GetNames(typeof(T));
			var functionCount = functionNames.Length;
			var callbackFunctions = new LuaFunction[functionCount];

			var callbackCount = 0;
			for (var i = 0; i < functionCount; i++)
			{
				var func = context.GetFunction(functionNames[i]);
				if (func != null)
				{
					callbackFunctions[i] = func;
					callbackCount++;
				}
			}

			return callbackCount > 0 ? new LuaCallbacks<T>(callbackFunctions) : null;
		}

		private LuaCallbacks(LuaFunction[] callbackFunctions) => m_CallbackFunctions = callbackFunctions;

		public LuaValue[] TryInvoke(LuaThreadAccess access, Int32 index, params LuaValue[] args)
		{
			var func = m_CallbackFunctions[index];
			if (func == null)
				return null;

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
