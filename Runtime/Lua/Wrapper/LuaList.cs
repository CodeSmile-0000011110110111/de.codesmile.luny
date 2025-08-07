// Copyright (C) 2021-2025 Steffen Itterheim
// Refer to included LICENSE file for terms and conditions.

using Lua;
using Lua.Runtime;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
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
		private readonly LuaValue[] m_LuaValues;

		public static implicit operator LuaValue(LuaList<T> list) => new(list);

		public Int32 Count => m_ManagedObjects?.Count ?? 0;
		public IList<T> ManagedObjects => m_ManagedObjects;
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

	public sealed partial class LuaList<T>
	{
		private static readonly LuaFunction __index = new(Metamethods.Index, (context, _) =>
		{
			var list = context.GetArgument<LuaList<T>>(0);
			var key = context.GetArgument(1);

			if (!key.TryRead<Int32>(out var luaIndex))
				throw new LuaRuntimeException(context.Thread, $"index must be a number, got: {key.Type}");

			var objects = list.ManagedObjects;
			if (objects == null)
				throw new LuaRuntimeException(context.Thread, "managed list is null.");

			if (luaIndex < 1 || luaIndex > objects.Count)
				throw new LuaRuntimeException(context.Thread, $"index {luaIndex} out of range [1, {objects.Count}]");

			var value = list.GetLuaValue(luaIndex, context.GetObjectFactory());
			return new ValueTask<Int32>(context.Return(value));
		});

		private static readonly LuaFunction __len = new(Metamethods.Len, (context, _) =>
		{
			var list = context.GetArgument<LuaList<T>>(0);
			var count = list.ManagedObjects?.Count ?? 0;
			return new ValueTask<Int32>(context.Return(count));
		});

		private static readonly LuaFunction __pairs = new(Metamethods.Pairs, (context, _) =>
		{
			var arg0 = context.GetArgument(0);
			return new ValueTask<Int32>(context.Return(LuaListIterator, arg0, LuaValue.Nil));
		});

		private static readonly LuaFunction __ipairs = new(Metamethods.IPairs, (context, _) =>
		{
			var arg0 = context.GetArgument(0);
			return new ValueTask<Int32>(context.Return(LuaListIterator, arg0, LuaValue.Nil));
		});

		private static readonly LuaFunction LuaListIterator = new(nameof(LuaListIterator), (context, token) =>
		{
			var list = context.GetArgument<LuaList<T>>(0);
			var key = context.HasArgument(1) ? context.Arguments[1] : LuaValue.Nil;

			var luaIndex = -1;
			if (key.Type is LuaValueType.Nil)
				luaIndex = 0;
			else if (key.TryRead(out Int32 number) && number > 0 && number < list.Count)
				luaIndex = number;

			if (luaIndex != -1)
			{
				luaIndex++;
				var value = list.GetLuaValue(luaIndex, context.GetObjectFactory());
				return new ValueTask<Int32>(context.Return(luaIndex, value));
			}

			return new ValueTask<Int32>(context.Return(LuaValue.Nil));
		});

		private static LuaTable s_Metatable = LuaMetatable.Create(new Dictionary<String, LuaFunction>
		{
			{ Metamethods.Index, __index },
			{ Metamethods.Len, __len },
			{ Metamethods.Pairs, __pairs },
			{ Metamethods.IPairs, __ipairs },
		});

		public LuaTable Metatable
		{
			get => s_Metatable ??= LuaMetatable.Create(__index);
			set => throw new NotSupportedException($"can't set Metatable of {nameof(LuaList<T>)}");
		}
	}
}
