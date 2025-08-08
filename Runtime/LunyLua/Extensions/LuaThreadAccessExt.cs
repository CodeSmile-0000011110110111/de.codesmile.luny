// Copyright (C) 2021-2025 Steffen Itterheim
// Refer to included LICENSE file for terms and conditions.

using Lua;
using Lua.Runtime;
using System;
using System.Threading;
using System.Threading.Tasks;
using UnityEditor;
using UnityEngine;

namespace Luny
{
	public static class LuaThreadAccessExt
	{
		public static ValueTask<LuaValue[]> DoStringAsync(this LuaThreadAccess access, String source, String chunkName,
			LuaTable contextTable, CancellationToken cancellationToken = default)
		{
			access.ThrowIfInvalid();
			var closure = access.State.Load(source, chunkName ?? source);
			return ExecuteAsync(access, closure, contextTable, cancellationToken);
		}

		public static ValueTask<LuaValue[]> DoBytesAsync(this LuaThreadAccess access, ReadOnlySpan<Byte> source,
			String chunkName, LuaTable contextTable, CancellationToken cancellationToken = default)
		{
			access.ThrowIfInvalid();
			var closure = access.State.Load(source, chunkName);
			return ExecuteAsync(access, closure, contextTable, cancellationToken);
		}

		public static async ValueTask<LuaValue[]> DoFileAsync(this LuaThreadAccess access, String path, LuaTable contextTable,
			CancellationToken cancellationToken = default)
		{
			access.ThrowIfInvalid();
			var closure = await access.State.LoadFileAsync(path, "bt", null, cancellationToken);
			return await ExecuteAsync(access, closure, contextTable, cancellationToken);
		}

		private static async ValueTask<LuaValue[]> ExecuteAsync(this LuaThreadAccess access, LuaClosure closure,
			LuaTable contextTable, CancellationToken cancellationToken = default)
		{
			access.ThrowIfInvalid();

			var argCount = 0;
			if (contextTable != null)
			{
				argCount++;
				access.Thread.Stack.Push(contextTable);
			}

			var count = await access.RunAsync(closure, argCount, access.Stack.Count - argCount, cancellationToken);
			using var results = access.ReadTopValues(count);
			return results.AsSpan().ToArray();
		}
	}
}
