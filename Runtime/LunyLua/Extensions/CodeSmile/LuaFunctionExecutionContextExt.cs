// Copyright (C) 2021-2025 Steffen Itterheim
// Refer to included LICENSE file for terms and conditions.

using System;
using System.Text;
using UnityEditor;
using UnityEngine;

namespace Lua.Unity
{
	public static class LuaFunctionExecutionContextExt
	{
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
