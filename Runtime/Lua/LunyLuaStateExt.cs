// Copyright (C) 2021-2025 Steffen Itterheim
// Refer to included LICENSE file for terms and conditions.

using Lua;
using Lua.IO;
using Lua.Runtime;
using System;
using System.Threading;
using System.Threading.Tasks;
using UnityEditor;
using UnityEngine;

namespace CodeSmile.Luny
{
	public static class LunyLuaStateExt
	{
		public static async ValueTask<LuaClosure> LunyLoadFileAsync(this LuaState state, String fileName, LuaTable environment,
			CancellationToken cancellationToken)
		{
			using var stream = await state.FileSystem.Open(fileName, LuaFileOpenMode.Read, cancellationToken);
			var source = await stream.ReadAllAsync(cancellationToken);

			// get the relative asset path, if any, and use it as the chunk name for hyperlinking
			var fileSystem = state.Platform.FileSystem as LunyLuaFileSystem;
			var assetPath = fileSystem.Hook.TryGetAssetPath(fileName);
			if (assetPath != null)
				fileName = assetPath;

			var closure = state.Load(source, fileName, environment);
			return closure;
		}
	}
}
