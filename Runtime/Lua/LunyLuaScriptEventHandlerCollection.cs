// Copyright (C) 2021-2025 Steffen Itterheim
// Refer to included LICENSE file for terms and conditions.

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

namespace CodeSmile.Luny
{
	public sealed class LunyLuaScriptEventHandlerCollection : IEnumerable<LunyLuaScriptEventHandlerBase>
	{
		private readonly Dictionary<Type, LunyLuaScriptEventHandlerBase> m_EventHandlers = new();

		public Int32 Count => m_EventHandlers.Count;
		public Boolean IsReadOnly => false;

		public IEnumerator<LunyLuaScriptEventHandlerBase> GetEnumerator() => m_EventHandlers.Values.GetEnumerator();

		IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();

		public void Add(Type enumType, LunyLuaScriptEventHandlerBase item) => m_EventHandlers.Add(enumType, item);

		public LunyLuaScriptEventHandler<T> TryGet<T>() where T : Enum => m_EventHandlers.TryGetValue(typeof(T), out var handler)
			? (LunyLuaScriptEventHandler<T>)handler
			: null;
	}
}
