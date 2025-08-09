// Copyright (C) 2021-2025 Steffen Itterheim
// Refer to included LICENSE file for terms and conditions.

using Lua;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using Object = System.Object;

namespace Luny
{
	public class LunyScriptEventHandler<T> : LunyScriptEventHandler where T : Enum
	{
		internal LunyScriptEventHandler(LuaCallbackFunctions callbackFunctions)
			: base(callbackFunctions) {}

		internal override void RebindCallbackFunctions(LuaTable scriptContext) => RebindCallbackFunctions<T>(scriptContext);
		public virtual void OnCreate()
		{
		}
	}

	public abstract class LunyScriptEventHandler
	{
		private LuaCallbackFunctions m_CallbackFunctions;

		public bool HasCallbacks => m_CallbackFunctions != null;

		public bool HasCallback(int eventIndex) => HasCallbacks && m_CallbackFunctions.HasCallback(eventIndex);

		public static LunyScriptEventHandler<T> TryCreate<T>(LuaTable scriptContext) where T : Enum
		{
			var hasCallbacks = TryGetCallbackFunctions<T>(scriptContext, out var callbackFunctions);
			if (hasCallbacks)
			{
				var eventHandler = new LunyScriptEventHandler<T>(new LuaCallbackFunctions(callbackFunctions));
				eventHandler.OnCreate();
				return eventHandler;
			}
			return null;
		}

		protected static Boolean TryGetCallbackFunctions<T>(LuaTable scriptContext, out LuaFunction[] callbackFunctions) where T : Enum
		{
			var functionNames = Enum.GetNames(typeof(T));
			var functionCount = functionNames.Length;
			callbackFunctions = null;

			// Try find Lua functions of the same name as the event
			var callbackFunctionCount = 0;
			for (var i = 0; i < functionCount; i++)
			{
				var func = scriptContext.GetFunction(functionNames[i]);
				if (func != null)
				{
					if (callbackFunctions == null)
						callbackFunctions = new LuaFunction[functionCount];

					callbackFunctions[i] = func;
					callbackFunctionCount++;
				}
			}
			return callbackFunctionCount > 0;
		}

		protected LunyScriptEventHandler(LuaCallbackFunctions callbackFunctions) => m_CallbackFunctions = callbackFunctions;

		public void TrySend(LuaState luaState, Int32 eventIndex, params LuaValue[] args) =>
			m_CallbackFunctions?.TryInvokeLuaFunction(luaState, eventIndex, args);

		protected void RebindCallbackFunctions<T>(LuaTable scriptContext) where T : Enum
		{
			var hasCallbacks = TryGetCallbackFunctions<T>(scriptContext, out var callbackFunctions);
			m_CallbackFunctions = hasCallbacks ? new LuaCallbackFunctions(callbackFunctions) : null;
		}

		internal abstract void RebindCallbackFunctions(LuaTable scriptContext);
	}

	public sealed class LunyScriptEventHandlerCollection : IEnumerable<LunyScriptEventHandler>
	{
		private readonly Dictionary<Type, LunyScriptEventHandler> m_EventHandlers = new();

		public Int32 Count => m_EventHandlers.Count;
		public Boolean IsReadOnly => false;

		public IEnumerator<LunyScriptEventHandler> GetEnumerator() => m_EventHandlers.Values.GetEnumerator();

		IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();

		public void Add(Type enumType, LunyScriptEventHandler item) => m_EventHandlers.Add(enumType, item);

		public LunyScriptEventHandler<T> TryGet<T>() where T : Enum => m_EventHandlers.TryGetValue(typeof(T), out var handler)
			? (LunyScriptEventHandler<T>)handler
			: null;
	}
}
