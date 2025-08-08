// Copyright (C) 2021-2025 Steffen Itterheim
// Refer to included LICENSE file for terms and conditions.

using Lua;
using System;
using System.Runtime.CompilerServices;
using System.Text;
using UnityEditor;
using UnityEngine;

namespace Luny
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
		public static ILuaEnumCollection GetEnums(this LuaFunctionExecutionContext context) =>
			((LunyLuaStateData)context.State.UserData).LunyLua.Enums;

		public static String ArgumentsToString(this LuaFunctionExecutionContext context, String prefix = "",
			String postfix = "")
		{
			var sb = new StringBuilder(prefix);
			for (var i = 0; i < context.ArgumentCount; i++)
			{
				if (i > 0)
					sb.Append(", ");

				var arg = context.GetArgument(i);
				sb.Append(LuaValueExt.ToString(arg));
			}
			sb.Append(postfix);
			return sb.ToString();
		}
	}
}
