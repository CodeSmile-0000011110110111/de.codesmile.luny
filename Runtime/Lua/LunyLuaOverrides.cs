// Copyright (C) 2021-2025 Steffen Itterheim
// Refer to included LICENSE file for terms and conditions.

using Lua;
using Lua.IO;
using Lua.Runtime;
using System.Threading;
using System.Threading.Tasks;

namespace CodeSmile.Luny
{
	public static class LunyLuaOverrides
	{
		public static async ValueTask<LuaClosure> LunyLoadFileAsync(this LuaState state, string fileName, LuaTable? environment, CancellationToken cancellationToken)
		{
			using var stream = await state.FileSystem.Open(fileName, LuaFileOpenMode.Read, cancellationToken);
			var source = await stream.ReadAllAsync(cancellationToken);

			var fileSystem = state.Platform.FileSystem as LunyLuaFileSystem;
			var assetPath = fileSystem.Hook.TryGetAssetPath(fileName);
			if (assetPath != null)
				fileName = assetPath;

			//var chunkName = "@" + fileName;
			LuaClosure closure = state.Load(source, fileName, environment);
			return closure;
		}
	}
}
