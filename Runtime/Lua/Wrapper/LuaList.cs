// Copyright (C) 2021-2025 Steffen Itterheim
// Refer to included LICENSE file for terms and conditions.

using Lua;
using Lua.Runtime;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using UnityEditor;
using UnityEngine;

namespace CodeSmile.Luny
{
	public interface ILuaList {}

	// System.Collections.Generic.IList<T>, System.Collections.Generic.ICollection<T>, and System.Collections.Generic.IEnumerable<T>
	// System.Collections.Generic.IReadOnlyList`1, System.Collections.Generic.IReadOnlyCollection`1
	// ICloneable, IList, ICollection, IEnumerable, IStructuralComparable, IStructuralEquatable
	public sealed class LuaList<T> : ILuaList, ILuaUserData
	{
		private static readonly LuaFunction __indexList = new(Metamethods.Index, (context, _) =>
		{
			var self = context.GetArgument<LuaList<T>>(0);
			var key = context.GetArgument(1);

			if (!key.TryRead<Int32>(out var index))
				throw new LuaRuntimeException(context.Thread, $"index must be a number, got: {key.Type}");

			var list = self.ManagedList;
			if (list == null)
				throw new LuaRuntimeException(context.Thread, "managed list is null.");

			if (index < 1 || index > list.Count)
				throw new LuaRuntimeException(context.Thread, $"index {index} out of range [1, {list.Count}]");

			var managedItem = list[index - 1];
			var value = context.GetObjectFactory().CreateLuaInstance(managedItem);
			return new ValueTask<Int32>(context.Return(value));
		});
		private static readonly LuaFunction __lenList = new(Metamethods.Len, (context, _) =>
		{
			var self = context.GetArgument<LuaList<T>>(0);
			var value = self.ManagedList?.Count ?? 0;
			return new ValueTask<Int32>(context.Return(value));
		});

		private static LuaTable s_Metatable = LuaMetatable.Create(new Dictionary<String, LuaFunction>
		{
			{ Metamethods.Index, __indexList },
			{ Metamethods.Len, __lenList },
		});
		private readonly IList<T> m_ManagedList;

		public static implicit operator LuaValue(LuaList<T> list) => new(list);
		public IList<T> ManagedList => m_ManagedList;
		public LuaTable Metatable
		{
			get => s_Metatable ??= LuaMetatable.Create(__indexList);
			set => throw new NotSupportedException("can't set Metatable of LuaArray");
		}

		public LuaList(in IList<T> managedList) => m_ManagedList = managedList;

		public override String ToString()
		{
			if (m_ManagedList == null)
				return "LuaList(null)";

			return $"LuaList({m_ManagedList.GetType().GetElementType().FullName}[{m_ManagedList.Count}])";
		}
	}
}
