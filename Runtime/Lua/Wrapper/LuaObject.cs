// Copyright (C) 2021-2025 Steffen Itterheim
// Refer to included LICENSE file for terms and conditions.

using Lua;
using System;
using UnityEditor;
using UnityEngine;

namespace Luny
{
	public interface ILuaBindType : ILuaUserData
	{
		Type BindType { get; }
	}

	public interface ILuaConvertible
	{
		Boolean TryGetLuaValue(Int32 index, out LuaValue value, ILuaObjectFactory factory);
		Boolean TryGetLuaValue(String key, out LuaValue value, ILuaObjectFactory factory);
		Boolean TrySetLuaValue(Int32 index, LuaValue value);
		Boolean TrySetLuaValue(String key, LuaValue value);
	}

	public interface ILuaValueType<T> : ILuaBindType, ILuaConvertible where T : struct
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
		public Boolean TryGetLuaValue(Int32 index, out LuaValue value, ILuaObjectFactory factory) => throw new NotImplementedException();
		public Boolean TryGetLuaValue(String key, out LuaValue value, ILuaObjectFactory factory) => throw new NotImplementedException();
		public Boolean TrySetLuaValue(Int32 index, LuaValue value) => throw new NotImplementedException();
		public Boolean TrySetLuaValue(String key, LuaValue value) => throw new NotImplementedException();
	}

	public interface ILuaObject<T> : ILuaBindType, ILuaConvertible where T : class
	{
		T Instance { get; }
		static LuaValue Bind(T instance) => throw new NotImplementedException();
	}

	public sealed class LuaObject<T> : ILuaObject<T> where T : class
	{
		public T Instance { get; }
		public Type BindType => typeof(T);
		public LuaTable Metatable { get; set; }
		public static implicit operator LuaValue(LuaObject<T> obj) => new(obj);
		private static LuaValue Bind(T instance) => new LuaObject<T>(instance);

		private LuaObject(T instance)
		{
			if (instance == null)
				throw new ArgumentNullException(nameof(instance), "cannot bind null references");

			Instance = instance;
		}

		public Boolean TryGetLuaValue(Int32 index, out LuaValue value, ILuaObjectFactory factory) => throw new NotImplementedException();
		public Boolean TryGetLuaValue(String key, out LuaValue value, ILuaObjectFactory factory) => throw new NotImplementedException();
		public Boolean TrySetLuaValue(Int32 index, LuaValue value) => throw new NotImplementedException();
		public Boolean TrySetLuaValue(String key, LuaValue value) => throw new NotImplementedException();
	}

	// cannot be generic because static types cannot be used as generic type arguments
	public interface ILuaStatic : ILuaBindType
	{
		static LuaValue Bind(Type staticType) => throw new NotImplementedException();
	}

	public sealed class LuaStatic : ILuaStatic, ILuaConvertible
	{
		public LuaTable Metatable { get; set; }
		public Type BindType { get; }
		public static implicit operator LuaValue(LuaStatic obj) => new(obj);
		public static LuaValue Bind(Type staticType) => new LuaStatic(staticType);
		private LuaStatic(Type staticType) => BindType = staticType;
		public Boolean TryGetLuaValue(Int32 index, out LuaValue value, ILuaObjectFactory factory) => throw new NotImplementedException();
		public Boolean TryGetLuaValue(String key, out LuaValue value, ILuaObjectFactory factory) => throw new NotImplementedException();
		public Boolean TrySetLuaValue(Int32 index, LuaValue value) => throw new NotImplementedException();
		public Boolean TrySetLuaValue(String key, LuaValue value) => throw new NotImplementedException();
	}
}
