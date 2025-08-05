// Copyright (C) 2021-2025 Steffen Itterheim
// Refer to included LICENSE file for terms and conditions.

using Lua;
using System;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

namespace CodeSmile.Luny
{
	public interface ILuaList {}

	// System.Collections.Generic.IList<T>, System.Collections.Generic.ICollection<T>, and System.Collections.Generic.IEnumerable<T>
	// System.Collections.Generic.IReadOnlyList`1, System.Collections.Generic.IReadOnlyCollection`1
	// ICloneable, IList, ICollection, IEnumerable, IStructuralComparable, IStructuralEquatable
	public sealed partial class LuaList<T> : ILuaList, ILuaUserData
	{
		private readonly IList<T> m_ManagedObjects;
		private readonly IList<LuaValue> m_LuaValues;

		public static implicit operator LuaValue(LuaList<T> list) => new(list);
		public IList<T> ManagedObjects => m_ManagedObjects;
		public Int32 Count => m_ManagedObjects?.Count ?? 0;
		public T this[Int32 i] => ManagedObjects[i];

		public LuaList(in IList<T> managedObjects)
		{
			m_ManagedObjects = managedObjects;
			m_LuaValues = new LuaValue[m_ManagedObjects.Count];
		}

		public override String ToString()
		{
			if (m_ManagedObjects == null)
				return "LuaList(null)";

			return $"LuaList({m_ManagedObjects.GetType().GetElementType().FullName}[{m_ManagedObjects.Count}])";
		}
	}
}
