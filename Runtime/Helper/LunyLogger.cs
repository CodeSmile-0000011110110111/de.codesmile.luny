// Copyright (C) 2021-2025 Steffen Itterheim
// Refer to included LICENSE file for terms and conditions.

using Lua;
using System;
using UnityEditor;
using UnityEngine;

namespace CodeSmile.Luny
{
	// NOTE: The name of class and methods must follow a specific scheme (class ends with "Logger", methods start with "Log")
	// see: https://www.reddit.com/r/Unity3D/comments/17eikh0/i_found_a_way_to_go_to_the_right_line_in_your/

	public static class LunyLogger
	{
		public static void LogInfo(String message) => Debug.Log(message);
		public static void LogWarn(String message) => Debug.LogWarning(message);
		public static void LogError(String message) => Debug.LogError(message);

		public static void LogException(Exception ex, Component component = null)
		{
			var scriptName = "";
			var message = ex.Message;
			if (ex is LuaRuntimeException luaRunEx)
				message = $"{message}\n\t{GetTrimmedTraceback(luaRunEx)}\n\n{luaRunEx.InnerException}";
			else if (ex is LuaParseException luaParEx)
				message = luaParEx.Message;

			// if (component is LunyScript lunyScript && lunyScript.Script != null)
			// 	scriptName = $"{lunyScript.Script.ScriptName}.lua";

			var gameObjectName = component != null ? $"{component.gameObject.name} ({component.gameObject.GetInstanceID()})" : null;
			Debug.LogError($"{scriptName} {message} on {gameObjectName}\n{ex.GetType().Name}: " +
			               $"{ex.StackTrace}\n{ex.InnerException?.Message}\n{ex.InnerException?.StackTrace}");
		}

		private static String GetTrimmedTraceback(LuaRuntimeException luaRunEx) =>
			luaRunEx.LuaTraceback.ToString().Replace("stack traceback:\n", "").Trim();
	}
}
