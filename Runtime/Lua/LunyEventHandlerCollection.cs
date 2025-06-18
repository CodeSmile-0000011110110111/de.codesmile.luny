// Copyright (C) 2021-2025 Steffen Itterheim
// Refer to included LICENSE file for terms and conditions.

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using Object = System.Object;

namespace CodeSmile.Luny
{
	public sealed class LunyEventHandlerCollection : ICollection<LunyEventHandlerBase>
	{
		private readonly HashSet<LunyEventHandlerBase> m_EventHandlers = new();

		public Int32 Count => m_EventHandlers.Count;
		public Boolean IsReadOnly => false;

		public IEnumerator<LunyEventHandlerBase> GetEnumerator() => m_EventHandlers.GetEnumerator();

		IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();

		public void Add(LunyEventHandlerBase item) => m_EventHandlers.Add(item);

		public void Clear() => m_EventHandlers.Clear();

		public Boolean Contains(LunyEventHandlerBase item) => m_EventHandlers.Contains(item);

		public void CopyTo(LunyEventHandlerBase[] array, Int32 arrayIndex) => m_EventHandlers.CopyTo(array, arrayIndex);

		public Boolean Remove(LunyEventHandlerBase item) => m_EventHandlers.Remove(item);

		public LunyEventHandler<T> TryGet<T>() where T : Enum
		{
			var enumType = typeof(T);
			foreach (var eventHandler in m_EventHandlers)
			{
				if (eventHandler != null && eventHandler.GetType().IsAssignableFrom(enumType))
					return (LunyEventHandler<T>)eventHandler;
			}
			return null;
		}
	}
}
