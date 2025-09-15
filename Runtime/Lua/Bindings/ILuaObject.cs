// Copyright (C) 2021-2025 Steffen Itterheim
// Refer to included LICENSE file for terms and conditions.

using Lua;
using System;
using System.Diagnostics.CodeAnalysis;
using UnityEditor;
using UnityEngine;

namespace Luny
{
	public interface ILuaObject<T> : ILuaBindType where T : class
	{
		T Instance { get; }
		static LuaValue Bind([NotNull] T instance) => throw new NotImplementedException();
	}
}
