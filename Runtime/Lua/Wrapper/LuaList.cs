// Copyright (C) 2021-2025 Steffen Itterheim
// Refer to included LICENSE file for terms and conditions.

using Lua;
using System;
using System.Collections.Generic;
using System.Linq;
using UnityEditor;
using UnityEngine;
using Object = System.Object;

namespace Luny
{
	public interface ILuaList : ILuaUserData, ILuaEnumerable {}

	// System.Collections.Generic.IList<T>, System.Collections.Generic.ICollection<T>, and System.Collections.Generic.IEnumerable<T>
	// System.Collections.Generic.IReadOnlyList`1, System.Collections.Generic.IReadOnlyCollection`1
	// ICloneable, IList, ICollection, IEnumerable, IStructuralComparable, IStructuralEquatable
	public sealed partial class LuaList<T> : ILuaList
	{
		private readonly IList<T> m_ManagedObjects;
		private readonly IList<LuaValue> m_LuaValues;

		public static implicit operator LuaValue(LuaList<T> list) => new(list);

		public IList<T> ManagedObjects => m_ManagedObjects;
		public Int32 Count => m_ManagedObjects?.Count ?? 0;
		public T this[Int32 i] => ManagedObjects[i];

		public LuaList(in IList<Object> managedObjects)
			: this(managedObjects.Cast<T>().ToList()) {}

		public LuaList(in IList<T> managedObjects)
		{
			m_ManagedObjects = managedObjects;
			m_LuaValues = new LuaValue[m_ManagedObjects.Count];
		}

		public Boolean TryGetNext(LuaValue key, out KeyValuePair<LuaValue, LuaValue> pair) => throw new NotImplementedException();

		private LuaValue GetLuaValue(Int32 luaIndex, ILuaObjectFactory factory)
		{
			var luaValue = LuaValue.Nil;
			var managedIndex = luaIndex - 1;
			if (m_ManagedObjects != null && managedIndex >= 0 && managedIndex < m_ManagedObjects.Count)
			{
				var instance = m_ManagedObjects[managedIndex];
				if (instance != null)
				{
					luaValue = m_LuaValues[managedIndex];
					if (luaValue.Type == LuaValueType.Nil)
						luaValue = m_LuaValues[managedIndex] = factory.Bind(instance);
				}
			}

			return luaValue;
		}

		public override String ToString()
		{
			if (m_ManagedObjects == null)
				return "LuaList(null)";

			return $"LuaList({m_ManagedObjects.GetType().GetElementType().FullName}[{m_ManagedObjects.Count}])";
		}
	}
}
