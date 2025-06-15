// Copyright (C) 2021-2025 Steffen Itterheim
// Refer to included LICENSE file for terms and conditions.

using Lua;
using Lua.Platforms;
using Lua.Standard;
using Lua.Unity;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using UnityEditor;
using UnityEngine;

namespace CodeSmile.Luny
{
	/// <summary>
	///     <a href="https://github.com/AnnulusGames/Lua-CSharp" target="_blank">Lua-CSharp</a> wrapper and Lua environment
	///     initialization.
	/// </summary>
	public interface ILunyLua
	{
		/// <summary>
		///     The Lua state.
		/// </summary>
		LuaState State { get; }
		void Dispose();
	}

	public sealed class LunyLua : ILunyLua
	{
		private readonly LunyLuaScriptCollection m_Scripts;
		private LuaState m_LuaState;
		private LunyLuaContext m_LuaContext;

		public LuaState State => m_LuaState;

		public LunyLua(LunyLuaContext luaContext, ILunyLuaFileSystem fileSystemHook)
		{
			m_Scripts = new LunyLuaScriptCollection();
			InitLuaEnvironment(luaContext, fileSystemHook);
		}

		public void Dispose()
		{
			HaltAllScripts();
			m_LuaState.Environment.Clear();
			m_LuaState = null;
		}

		private void InitLuaEnvironment(LunyLuaContext luaContext, ILunyLuaFileSystem fileSystemHook)
		{
			m_LuaContext = luaContext;

			var fileSystem = new LunyLuaFileSystem(luaContext, fileSystemHook);
			var osEnv = new LunyLuaOsEnvironment(luaContext);
			var standardIO = new LunyLuaStandardIO(luaContext);
			m_LuaState = LuaState.Create(new LuaPlatform(fileSystem, osEnv, standardIO, TimeProvider.System));
			m_LuaState.OnBeforeLoadChunk = OnBeforeLoadChunk;
			m_LuaState.Environment["LuaContext"] = luaContext.CreateContextTable();

			var libraries = luaContext.Libraries;
			if ((libraries & LuaLibraryFlags.Basic) != 0)
				m_LuaState.OpenBasicLibrary();
			if ((libraries & LuaLibraryFlags.Bitwise) != 0)
				m_LuaState.OpenBitwiseLibrary();
			if ((libraries & LuaLibraryFlags.Coroutine) != 0)
				m_LuaState.OpenCoroutineLibrary();
			if ((libraries & LuaLibraryFlags.Debug) != 0)
				m_LuaState.OpenDebugLibrary();
			if ((libraries & LuaLibraryFlags.IO) != 0)
				m_LuaState.OpenIOLibrary();
			if ((libraries & LuaLibraryFlags.Math) != 0)
				m_LuaState.OpenMathLibrary();
			if ((libraries & LuaLibraryFlags.Module) != 0)
				m_LuaState.OpenModuleLibrary();
			if ((libraries & LuaLibraryFlags.OS) != 0)
				m_LuaState.OpenOperatingSystemLibrary();
			if ((libraries & LuaLibraryFlags.String) != 0)
				m_LuaState.OpenStringLibrary();
			if ((libraries & LuaLibraryFlags.Table) != 0)
				m_LuaState.OpenTableLibrary();

			if (luaContext.IsSandbox)
				RemovePotentiallyHarmfulFunctions();

			OverridePrintAndLog();

			foreach (var module in luaContext.Modules)
				module.Load(m_LuaState);
		}

		private void OnBeforeLoadChunk(ref String chunkName)
		{
			var fileSystem = m_LuaState.Platform.FileSystem as LunyLuaFileSystem;
			var path = fileSystem.Hook.TryGetAssetPath(chunkName);
			if (path != null)
				chunkName = path;
		}

		public async ValueTask<LunyLuaScript> RunScript(LunyLuaAsset luaAsset)
		{
			if (luaAsset == null)
				throw new ArgumentNullException(nameof(luaAsset));

			m_Scripts.TryRemove(luaAsset);

			var luaScript = new LunyLuaScript(this, luaAsset);
			await luaScript.Run();

			m_Scripts.Add(luaScript);
			return luaScript;
		}

		public async ValueTask RunScripts(IEnumerable<LunyLuaAsset> luaAssets)
		{
			foreach (var luaAsset in luaAssets)
			{
				if (luaAsset != null)
					await RunScript(luaAsset);
			}
		}

		public void HaltScript(LunyLuaAsset luaAsset)
		{
			if (m_Scripts != null && m_Scripts.TryRemove(luaAsset, out var luaScript))
				luaScript.Dispose();
		}

		public void HaltScripts(IEnumerable<LunyLuaAsset> luaAssets)
		{
			foreach (var luaAsset in luaAssets)
				HaltScript(luaAsset);
		}

		public void HaltAllScripts()
		{
			foreach (var luaScript in m_Scripts)
				luaScript.Dispose();
			m_Scripts.Clear();
		}

		private void RemovePotentiallyHarmfulFunctions()
		{
			var env = m_LuaState.Environment;
			env.SetNil("load"); // disallow compiling and executing arbitrary strings
		}

		private void OverridePrintAndLog()
		{
			var logTable = new LuaTable(0, 4);
			logTable["info"] = LunyLogger._logInfo;
			logTable["warning"] = LunyLogger._logWarn;
			logTable["error"] = LunyLogger._logError;
			logTable["warn"] = logTable["warning"]; // alias

			var env = m_LuaState.Environment;
			env["log"] = logTable;
			env["print"] = logTable["info"];
			env["warn"] = logTable["warning"];
			env["error"] = logTable["error"];
		}
	}
}
