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

		// Boolean TryGetLuaValue(Int32 index, out LuaValue value);
		// Boolean TryGetLuaValue(String key, out LuaValue value);
		// Boolean TrySetLuaValue(Int32 index, LuaValue value);
		// Boolean TrySetLuaValue(String key, LuaValue value);
	}

	public interface ILuaValueType<T> : ILuaBindType where T : struct
	{
		T Value { get; set; }
		ref T ValueRef { get; }
		static LuaValue Bind(T value) => throw new NotImplementedException();
	}

	public interface ILuaObject<T> : ILuaBindType where T : class
	{
		T Instance { get; }
		static LuaValue Bind(T instance) => throw new NotImplementedException();
	}

	public interface ILuaStatic : ILuaBindType {}

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
	}
}
