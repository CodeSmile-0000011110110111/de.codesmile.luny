// Copyright (C) 2021-2025 Steffen Itterheim
// Refer to included LICENSE file for terms and conditions.

using Lua;
using System;
using UnityEditor;
using UnityEngine;

namespace Luny
{
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
}
