﻿// Copyright (C) 2021-2025 Steffen Itterheim
// Refer to included LICENSE file for terms and conditions.

using Lua;
using Lua.Unity;
using System;
using UnityEditor;
using UnityEngine;

namespace CodeSmile.Luny
{
	public abstract class LunyLuaScriptEventHandlerBase
	{
		private LuaCallbackFunctions m_Callbacks;

		public void Send(LuaState luaState, Int32 eventIndex, params LuaValue[] args) =>
			m_Callbacks?.TryInvoke(luaState, eventIndex, args);

		private LuaCallbackFunctions CreateCallbacks<T>(LuaTable context) where T : Enum
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

			return callbackCount > 0 ? new LuaCallbackFunctions(callbackFunctions) : null;
		}

		internal void BindEventCallbacks<T>(LuaTable context) where T : Enum => m_Callbacks = CreateCallbacks<T>(context);
		internal abstract void BindEventCallbacks(LuaTable context);
	}

	public sealed class LunyLuaScriptEventHandler<T> : LunyLuaScriptEventHandlerBase where T : Enum
	{
		public LunyLuaScriptEventHandler(LuaTable context) => BindEventCallbacks<T>(context);
		internal override void BindEventCallbacks(LuaTable context) => BindEventCallbacks<T>(context);
	}
}
