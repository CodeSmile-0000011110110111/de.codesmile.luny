// Copyright (C) 2021-2025 Steffen Itterheim
// Refer to included LICENSE file for terms and conditions.

using Lua;
using System.Runtime.CompilerServices;
using UnityEditor;
using UnityEngine;

namespace CodeSmile.Luny
{
	public static class LuaFunctionExecutionContextExt
	{
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static ILuaObjectFactory GetObjectFactory(this LuaFunctionExecutionContext context) =>
			((LunyLuaStateData)context.State.UserData).LunyLua.ObjectFactory;

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static ILuaNamespaces GetNamespaces(this LuaFunctionExecutionContext context) =>
			((LunyLuaStateData)context.State.UserData).LunyLua.Namespaces;

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static ILuaEnums GetEnums(this LuaFunctionExecutionContext context) =>
			((LunyLuaStateData)context.State.UserData).LunyLua.Enums;
	}
}
