// Copyright (C) 2021-2025 Steffen Itterheim
// Refer to included LICENSE file for terms and conditions.

using System;
using System.Threading;
using System.Threading.Tasks;
using UnityEditor;
using UnityEngine;

namespace Lua.Unity
{
	public static class LuaStateExt
	{
		public static ValueTask<LuaValue[]> DoStringAsync(this LuaState state, String source, String chunkName,
			LuaTable contextTable, CancellationToken cancellationToken = default) =>
			state.RootAccess.DoStringAsync(source, chunkName, contextTable, cancellationToken);

		public static ValueTask<LuaValue[]> DoBytesAsync(this LuaState state, ReadOnlySpan<Byte> source, String chunkName,
			LuaTable contextTable, CancellationToken cancellationToken = default) =>
			state.RootAccess.DoBytesAsync(source, chunkName, contextTable, cancellationToken);

		public static ValueTask<LuaValue[]> DoFileAsync(this LuaState state, String path, LuaTable contextTable,
			CancellationToken cancellationToken = default) => state.RootAccess.DoFileAsync(path, contextTable, cancellationToken);
	}
}
