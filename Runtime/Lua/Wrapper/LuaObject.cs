// Copyright (C) 2021-2025 Steffen Itterheim
// Refer to included LICENSE file for terms and conditions.

using Lua;
using Lua.Runtime;
using System;
using System.Diagnostics.CodeAnalysis;
using System.Threading.Tasks;
using UnityEditor;
using UnityEngine;

namespace Luny
{
	public interface ILuaBindType : ILuaUserData
	{
		Type BindType { get; }
	}

	public interface ILuaIndexable
	{
		Boolean TryGetLuaValue(Int32 luaIndex, out LuaValue value, ILuaObjectFactory factory);
		Boolean TryGetLuaValue(String key, out LuaValue value, ILuaObjectFactory factory);
		Boolean TrySetLuaValue(Int32 index, LuaValue value);
		Boolean TrySetLuaValue(String key, LuaValue value);
	}

	public interface ILuaValueType<T> : ILuaBindType where T : struct
	{
		T Value { get; set; }
		ref T ValueRef { get; }
		static LuaValue Bind(T value) => throw new NotImplementedException();
	}

	public sealed class LuaValueType<T> : ILuaValueType<T> where T : struct
	{
		private T m_Value;
		public LuaTable Metatable { get; set; }
		public Type BindType => typeof(T);
		public T Value { get => m_Value; set => m_Value = value; }
		public ref T ValueRef => ref m_Value;
		public static implicit operator LuaValue(LuaValueType<T> val) => new(val);
		public static LuaValue Bind(T val) => new LuaValueType<T>(val);

		private LuaValueType(T val) => m_Value = val;
	}

	public interface ILuaObject<T> : ILuaBindType where T : class
	{
		T Instance { get; }
		static LuaValue Bind([NotNull] T instance) => throw new NotImplementedException();
	}

	public sealed class LuaObject<T> : ILuaObject<T> where T : class
	{
		private static readonly LuaFunction __index = new(Metamethods.Index, (context, _) =>
		{
			LuaValue value;
			var luaObject = context.GetArgument<LuaObject<T>>(0);
			var key = context.GetArgument(1);

			if (luaObject.Instance is ILuaIndexable indexable)
			{
				if (key.Type == LuaValueType.Number)
				{
					if (key.TryRead<Int32>(out var luaIndex) && indexable.TryGetLuaValue(luaIndex, out value, context.GetObjectFactory()))
						return new ValueTask<Int32>(context.Return(value));
				}
				else if (key.Type == LuaValueType.String)
				{
					if (indexable.TryGetLuaValue(key.Read<String>(), out value, context.GetObjectFactory()))
						return new ValueTask<Int32>(context.Return(value));
				}
			}

			// TODO: reflection access

			throw new LuaRuntimeException(context.Thread, $"{luaObject} failed to index: {key}");
		});
		private static readonly LuaFunction __newindex = new(Metamethods.NewIndex, (context, _) =>
		{
			var luaObject = context.GetArgument<LuaObject<T>>(0);
			var key = context.GetArgument(1);
			var value = context.GetArgument(2);

			if (luaObject.Instance is ILuaIndexable indexable)
			{
				if (key.Type == LuaValueType.Number)
				{
					if (key.TryRead<Int32>(out var luaIndex) && indexable.TrySetLuaValue(luaIndex, value))
						return new ValueTask<Int32>(context.Return(0));
				}
				else if (key.Type == LuaValueType.String)
				{
					if (indexable.TrySetLuaValue(key.Read<String>(), value))
						return new ValueTask<Int32>(context.Return(0));
				}
			}

			// TODO: reflection access

			throw new LuaRuntimeException(context.Thread, $"{luaObject} failed to assign: {key} = {value}");
		});

		private static LuaTable s_Metatable = LuaMetatable.Create(__index, __newindex);
		public T Instance { get; }
		public Type BindType => typeof(T);
		public static implicit operator LuaValue(LuaObject<T> obj) => new(obj);

		public LuaTable Metatable
		{
			get => s_Metatable ??= LuaMetatable.Create(__index, __newindex);
			set => throw new NotSupportedException($"can't set Metatable of {nameof(LuaObject<T>)}");
		}
		public static LuaValue Bind([NotNull] T instance) => new LuaObject<T>(instance);

		private LuaObject(T instance)
		{
			if (instance == null)
				throw new ArgumentNullException(nameof(instance), "cannot bind null reference");

			Instance = instance;
		}

		public override String ToString() => Instance != null ? Instance.ToString() : $"LuaObject<{BindType.FullName}>(null)";
	}

	// cannot be generic because static types cannot be used as generic type arguments
	public interface ILuaStatic : ILuaBindType
	{
		static LuaValue Bind(Type staticType) => throw new NotImplementedException();
	}

	// public sealed class LuaStatic : ILuaStatic
	// {
	// 	public LuaTable Metatable { get; set; }
	// 	public Type BindType { get; }
	// 	public static implicit operator LuaValue(LuaStatic obj) => new(obj);
	// 	public static LuaValue Bind(Type staticType) => new LuaStatic(staticType);
	// 	private LuaStatic(Type staticType) => BindType = staticType;
	// }
}
