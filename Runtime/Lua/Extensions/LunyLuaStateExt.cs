// Copyright (C) 2021-2025 Steffen Itterheim
// Refer to included LICENSE file for terms and conditions.

using Lua;
using Lua.IO;
using Lua.Runtime;
using Lua.Standard;
using System;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Threading.Tasks;
using UnityEditor;
using UnityEngine;

namespace Luny
{
	public static class LunyLuaStateExt
	{
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static ILunyLua GetLunyLua(this LuaState state) => ((LunyLuaStateData)state.UserData).LunyLua;

		internal static async ValueTask<LuaClosure> LunyLoadFileAsync(this LuaState state, String fileName, LuaTable environment,
			CancellationToken cancellationToken)
		{
			using var stream = await state.FileSystem.Open(fileName, LuaFileOpenMode.Read, cancellationToken);
			var source = await stream.ReadAllAsync(cancellationToken);

			// get the relative asset path, if any, and use it as the chunk name for hyperlinking
			var fileSystem = state.Platform.FileSystem as LuaUnityFileSystem;
			var assetPath = fileSystem.Hook.TryGetAssetPath(fileName);
			if (assetPath != null)
				fileName = assetPath;

			var closure = state.Load(source, fileName, environment);
			return closure;
		}

		internal static void LoadBuiltInLibraries(this LuaState luaState, LuaLibraryFlags libraryFlags)
		{
			if ((libraryFlags & LuaLibraryFlags.Basic) != 0)
				luaState.OpenBasicLibrary();
			if ((libraryFlags & LuaLibraryFlags.Bitwise) != 0)
				luaState.OpenBitwiseLibrary();
			if ((libraryFlags & LuaLibraryFlags.Coroutine) != 0)
				luaState.OpenCoroutineLibrary();
			if ((libraryFlags & LuaLibraryFlags.Debug) != 0)
				luaState.OpenDebugLibrary();
			if ((libraryFlags & LuaLibraryFlags.IO) != 0)
				luaState.OpenIOLibrary();
			if ((libraryFlags & LuaLibraryFlags.Math) != 0)
				luaState.OpenMathLibrary();
			if ((libraryFlags & LuaLibraryFlags.Module) != 0)
				luaState.OpenModuleLibrary();
			if ((libraryFlags & LuaLibraryFlags.OS) != 0)
				luaState.OpenOperatingSystemLibrary();
			if ((libraryFlags & LuaLibraryFlags.String) != 0)
			{
				luaState.OpenStringLibrary();
				luaState.OpenStringLibraryExtensions();
			}
			if ((libraryFlags & LuaLibraryFlags.Table) != 0)
				luaState.OpenTableLibrary();
		}

		internal static void ApplyLunyFunctionOverrides(this LuaState luaState, LuaLibraryFlags libraryFlags, Boolean isSandbox)
		{
			var env = luaState.Environment;

			// logging
			env["print"] = LuaLogger.LuaLogInfo;
			env["warn"] = LuaLogger.LuaLogWarn;
			env["error"] = LuaLogger.LuaLogError;

			env[LunyLuaFunctions.LuaNameOf.Name] = LunyLuaFunctions.LuaNameOf; // return System.Type.FullName for LuaValue

			if ((libraryFlags & LuaLibraryFlags.Basic) != 0)
			{
				env[LunyLuaFunctions.LunyDoFile.Name] = LunyLuaFunctions.LunyDoFile;
				env[LunyLuaFunctions.LunyLoadFile.Name] = LunyLuaFunctions.LunyLoadFile;

				if (isSandbox)
					env.SetNil("load"); // disallow compiling and executing arbitrary strings
			}
		}

		internal static void EnableNamespaceLookup(this LuaState luaState)
		{
			var envMetatable = new LuaTable(0, 1);
			envMetatable[Metamethods.Index] = LunyLuaFunctions.LunyEnvironmentIndex;
			luaState.Environment.Metatable = envMetatable;
		}
	}
}
