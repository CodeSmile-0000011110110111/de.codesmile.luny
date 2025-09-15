// Copyright (C) 2021-2025 Steffen Itterheim
// Refer to included LICENSE file for terms and conditions.

using Lua;
using Lua.Runtime;
using System;
using System.IO;
using System.Threading.Tasks;
using UnityEditor;
using UnityEngine;
using UnityEngine.Scripting;

namespace Luny
{
	// NOTE: The name of class and methods must follow a specific scheme (class ends with "Logger", methods start with "Log")
	// see: https://www.reddit.com/r/Unity3D/comments/17eikh0/i_found_a_way_to_go_to_the_right_line_in_your/

	[Preserve]
	public static class LuaLogger
	{
		[Preserve] internal static readonly LuaFunction LuaLogInfo = new("print", (context, ct) =>
		{
			LogInfo(GetLuaMessageAndTraceback(context));
			return new ValueTask<Int32>(context.Return());
		});
		[Preserve] internal static readonly LuaFunction LuaLogWarn = new("warn", (context, ct) =>
		{
			LogWarn(GetLuaMessageAndTraceback(context));
			return new ValueTask<Int32>(context.Return());
		});
		[Preserve] internal static readonly LuaFunction LuaLogError = new("error", (context, ct) =>
		{
			LogError(GetLuaMessageAndTraceback(context));
			return new ValueTask<Int32>(context.Return());
		});

		[Preserve] [HideInCallstack] public static void LogInfo(String message) => Debug.Log(message);
		[Preserve] [HideInCallstack] public static void LogWarn(String message) => Debug.LogWarning(message);
		[Preserve] [HideInCallstack] public static void LogError(String message) => Debug.LogError(message);

		[Preserve] [HideInCallstack] public static void LogException(Exception ex, Component component = null)
		{
			var scriptName = "";
			var message = ex.Message;
			if (ex is LuaRuntimeException luaRunEx)
				message = $"{message}\n\t{luaRunEx}\n\n{luaRunEx.InnerException}";
			else if (ex is LuaParseException luaParEx)
				message = luaParEx.Message;

			var gameObjectName =
				component != null ? $" on {component.gameObject.name} ({component.gameObject.GetInstanceID()})" : null;
			Debug.LogError($"{scriptName} {message}{gameObjectName}\n{ex.GetType().Name}: " +
			               $"{ex.StackTrace}\n{ex.InnerException?.Message}\n{ex.InnerException?.StackTrace}");
		}

		[Preserve] private static String GetLuaMessageAndTraceback(LuaFunctionExecutionContext context)
		{
			var contextMsg = context.ArgumentsToString();
			var msg = Traceback.CreateTracebackMessage(context.Thread, contextMsg, 1,
				(String chunkName, Int32 line, out String openTag, out String closeTag) =>
				{
					openTag = closeTag = null;
					var relativePath = chunkName[0] == '@' ? chunkName.Substring(1) : chunkName;
					var path = Path.GetFullPath(relativePath);
					if (!File.Exists(path))
						return;

					// HTML <a ..> tag
					openTag = $"<a href=\"{relativePath}\" line=\"{line}\">";
					closeTag = "</a>";
				});
			return $"{msg}\nC# stack traceback:";
		}

		[Preserve] private static String GetTrimmedTraceback(LuaRuntimeException luaRunEx) =>
			luaRunEx.LuaTraceback.ToString().Replace("Lua stack traceback:\n", "").Trim();
	}
}
