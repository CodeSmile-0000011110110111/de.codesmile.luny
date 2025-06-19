// Copyright (C) 2021-2025 Steffen Itterheim
// Refer to included LICENSE file for terms and conditions.

using Lua;
using Lua.Platforms;
using Lua.Standard;
using Lua.Unity;
using System;
using System.Collections.Generic;
using System.Threading;
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
		ValueTask AddAndRunScripts(IEnumerable<LunyLuaScript> scripts);
		void Dispose();
	}

	public sealed class LunyLua : ILunyLua
	{
		private readonly LunyLuaScriptCollection m_Scripts;
		private LuaState m_LuaState;
		private LunyLuaFileWatcher m_FileWatcher;

		public LuaState State => m_LuaState;
		public IReadOnlyCollection<LunyLuaScript> Scripts => m_Scripts.Scripts;

		public LunyLua(LunyLuaContext luaContext, ILunyLuaFileSystem fileSystemHook)
		{
			m_Scripts = new LunyLuaScriptCollection();
			InitLuaEnvironment(luaContext, fileSystemHook);
		}

		public void Dispose()
		{
			ClearScripts();
			m_FileWatcher?.Dispose();
			m_FileWatcher = null;
			m_LuaState.Environment.Clear();
			m_LuaState = null;
		}

		private void InitLuaEnvironment(LunyLuaContext luaContext, ILunyLuaFileSystem fileSystemHook)
		{
			m_FileWatcher = new LunyLuaFileWatcher(luaContext);

			var fileSystem = new LunyLuaFileSystem(luaContext, fileSystemHook);
			var osEnv = new LunyLuaOsEnvironment(luaContext);
			var standardIO = new LunyLuaStandardIO(luaContext);
			m_LuaState = LuaState.Create(new LuaPlatform(fileSystem, osEnv, standardIO, TimeProvider.System));
			m_LuaState.Environment["LuaContext"] = luaContext.CreateContextTable();

			var libraries = luaContext.Libraries;
			if ((libraries & LuaLibraryFlags.Basic) != 0)
			{
				m_LuaState.OpenBasicLibrary();
				InstallBasicLibraryOverrides();
			}
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

		private void InstallBasicLibraryOverrides()
		{
			m_LuaState.Environment["dofile"] = new LuaFunction("dofile", DoFile);
			m_LuaState.Environment["loadfile"] = new LuaFunction("loadfile", LoadFile);
			async ValueTask<int> DoFile(LuaFunctionExecutionContext context, CancellationToken cancellationToken)
			{
				var arg0 = context.GetArgument<string>(0);
				context.Thread.Stack.PopUntil(context.ReturnFrameBase);
				var closure = await context.State.LunyLoadFileAsync(arg0, null, cancellationToken);
				return await context.Access.RunAsync(closure, cancellationToken);
			}
			async ValueTask<int> LoadFile(LuaFunctionExecutionContext context, CancellationToken cancellationToken)
			{
				var arg0 = context.GetArgument<string>(0);
				// var mode = context.HasArgument(1)
				// 	? context.GetArgument<string>(1)
				// 	: "bt";
				var arg2 = context.HasArgument(2)
					? context.GetArgument<LuaTable>(2)
					: null;

				// do not use LuaState.DoFileAsync as it uses the newExecutionContext
				try
				{
					return context.Return(await context.State.LunyLoadFileAsync(arg0, arg2, cancellationToken));
				}
				catch (Exception ex)
				{
					return context.Return(LuaValue.Nil, ex.Message);
				}
			}
		}

		public async ValueTask AddAndRunScript(LunyLuaScript script)
		{
			if (script == null)
				throw new ArgumentNullException(nameof(script));

			RemoveScript(script);
			m_Scripts.Add(script); // FIXME: LunyLua should not keep references to scripts but needs it for filewatcher
			m_FileWatcher.WatchScript(script);

			await script.DoScriptAsync(m_LuaState);
		}

		public async ValueTask AddAndRunScripts(IEnumerable<LunyLuaScript> scripts)
		{
			foreach (var script in scripts)
			{
				if (script != null)
					await AddAndRunScript(script);
			}
		}

		internal void RemoveScript(LunyLuaAsset luaAsset)
		{
			if (luaAsset != null)
			{
				for (var i = m_Scripts.Count - 1; i >= 0; i--)
				{
					var script = m_Scripts[i];
					if (script is LunyLuaAssetScript assetScript && luaAsset == assetScript.LuaAsset)
					{
						m_Scripts.RemoveAt(i);
						m_FileWatcher.UnwatchScript(script);
						script.Dispose();
						break;
					}
				}
			}
		}

		private void RemoveScript(LunyLuaScript script)
		{
			if (m_Scripts != null && m_Scripts.Remove(script))
			{
				m_FileWatcher.UnwatchScript(script);
				script.Dispose();
			}
		}

		private void RemoveScripts(IList<LunyLuaScript> scripts)
		{
			var count = scripts.Count;
			for (var i = count - 1; i >= 0; i--)
				RemoveScript(scripts[i]);
		}

		private void ClearScripts()
		{
			RemoveScripts(m_Scripts);
			m_Scripts.Clear();
		}

		private void RemovePotentiallyHarmfulFunctions()
		{
			var env = m_LuaState.Environment;
			env.SetNil("load"); // disallow compiling and executing arbitrary strings
		}

		private void OverridePrintAndLog()
		{
			var env = m_LuaState.Environment;
			env["print"] = LunyLogger.LuaLogInfo;
			env["warn"] = LunyLogger.LuaLogWarn;
			env["error"] = LunyLogger.LuaLogError;
		}

		public void Update()
		{
			m_FileWatcher.NotifyChangedScripts();
		}
	}
}
