// Copyright (C) 2021-2025 Steffen Itterheim
// Refer to included LICENSE file for terms and conditions.

using CodeSmile.Utility;
using Lua;
using Lua.Standard;
using System;
using System.IO;
using System.Linq;
using System.Text;
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
		///     True while we're within a DoStringAsync call. This is important to consider in cases where Lua calls a C# method
		///     which in turn tries to dofile/dostring - this is not allowed. The solution is to wait until the running state flag
		///     is false again which may require running a coroutine or repeatedly checking in Update.
		/// </summary>
		//Boolean IsLuaStateRunning { get; }

		/// <summary>
		///     The Lua state.
		/// </summary>
		LuaState State { get; }

		/// <summary>
		///     Parses, compiles and executes a Lua string.
		/// </summary>
		/// <remarks>Only one DoStringAsync may run at the same time.</remarks>
		/// <param name="script"></param>
		/// <param name="chunkName"></param>
		/// <returns>Array containing 0-n return values.</returns>
		LuaValue[] DoString(String script, String chunkName);

		/// <summary>
		///     Reads the file, then calls DoStringAsync with the file's contents.
		/// </summary>
		/// <param name="relativePath"></param>
		/// <returns>Array containing 0-n return values.</returns>
		LuaValue[] DoFile(String relativePath);

		ValueTask<LuaValue[]> DoStringAsync(String script, String chunkName);
		ValueTask<LuaValue[]> DoFileAsync(String relativePath);

		/// <summary>
		/// Loads the file's contents and returns the text.
		/// </summary>
		/// <param name="relativePath">Path relative to one of the specified search paths.</param>
		/// <returns>Contents of the file</returns>
		String LoadFile(String relativePath);

		String DumpEnvironment();
	}

	internal interface ILunyLuaInternal
	{
		void Dispose();
	}

	public sealed class LunyLua : ILunyLua, ILunyLuaInternal
	{
		private ILunySearchPaths m_SearchPaths;
		private LuaState m_LuaState;

		public LuaState State => m_LuaState;

		// public static Closure CompileClosure(LuaState luaState, String script, String chunkName)
		// {
		// 	var chunk = LuaCompiler.Default.Compile(script, chunkName);
		// 	return new Closure(luaState, chunk);
		// }

		private static String GetLogString(LuaFunctionExecutionContext context)
		{
			var sb = new StringBuilder();
			for (var i = 0; i < context.ArgumentCount; i++)
			{
				if (i > 0)
					sb.Append(", ");

				sb.Append(context.GetArgument(i).ToString());
			}
			return sb.ToString();
		}

		public LunyLua(LunyLuaContext luaContext)
		{
			InitLuaEnvironment(luaContext);
		}

		private void InitLuaEnvironment(LunyLuaContext luaContext)
		{
			m_SearchPaths = new LunySearchPaths(luaContext);
			m_LuaState = LuaState.Create(new LunyLuaPlatform(luaContext));

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

			OverrideDoFileAndLoadFile();
			OverridePrintAndLog();

			foreach (var module in luaContext.Modules)
				module.Load(m_LuaState);
		}

		private void RemovePotentiallyHarmfulFunctions()
		{
			var env = m_LuaState.Environment;
			env.SetNil("load"); // disallow compiling and executing arbitrary strings
		}

		private void OverrideDoFileAndLoadFile()
		{
			// TODO: use virtual filesystem?

// #pragma warning disable CS1998 // Async method lacks 'await' operators and will run synchronously
// 			m_LuaState.Environment.SetFunction("dofile", new LuaFunction("dofile", async (context, buffer, ct) =>
// 			{
// 				var relativePath = context.GetArgument<String>(0);
// 				var script = LoadFile(relativePath);
// 				var closure = CompileClosure(context.State, script, relativePath);
// 				return await closure!.InvokeAsync(context, buffer, ct);
// 			}));
//
// 			m_LuaState.Environment.SetFunction("loadfile", new LuaFunction("loadfile", async (context, buffer, ct) =>
// 			{
// 				try
// 				{
// 					var relativePath = context.GetArgument<String>(0);
// 					var script = LoadFile(relativePath);
// 					buffer.Span[0] = CompileClosure(context.State, script, relativePath);
// 					return 1;
// 				}
// 				catch (Exception ex)
// 				{
// 					buffer.Span[0] = LuaValue.Nil;
// 					buffer.Span[1] = ex.Message;
// 					return 2;
// 				}
// 			}));
// #pragma warning restore CS1998 // Async method lacks 'await' operators and will run synchronously
		}

		private void OverridePrintAndLog()
		{
			var logTable = new LuaTable(0, 4);
			logTable["info"] = new LuaFunction("info", (context, ct) =>
			{
				LunyLogger.LogInfo(GetLogString(context));
				return new ValueTask<Int32>(0);
			});
			logTable["warning"] = new LuaFunction("warning", (context, ct) =>
			{
				LunyLogger.LogWarn(GetLogString(context));
				return new ValueTask<Int32>(0);
			});
			logTable["error"] = new LuaFunction("error", (context, ct) =>
			{
				LunyLogger.LogError(GetLogString(context));
				return new ValueTask<Int32>(0);
			});

			logTable["warn"] = logTable["warning"]; // alias

			var env = m_LuaState.Environment;
			env["log"] = logTable;
			env["print"] = logTable["info"];
			env["warn"] = logTable["warning"];
			env["error"] = logTable["error"];
		}


		public String DumpEnvironment() => m_LuaState.Environment.Dump("Luny environment");

		public LuaValue[] DoString(String script, String chunkName)
		{
			Debug.Assert(m_LuaState != null);
			return m_LuaState.DoStringAsync(script, chunkName).Preserve().GetAwaiter().GetResult();
		}

		public async ValueTask<LuaValue[]> DoStringAsync(String script, String chunkName)
		{
			Debug.Assert(m_LuaState != null);
			return await m_LuaState.DoStringAsync(script, chunkName);
		}

		public LuaValue[] DoFile(String relativePath)
		{
			var script = LoadFile(relativePath);
			return DoString(script, relativePath);
		}

		public async ValueTask<LuaValue[]> DoFileAsync(String relativePath)
		{
			var script = LoadFile(relativePath);
			return await DoStringAsync(script, relativePath);
		}

		/// <summary>
		/// Loads a (script) text file taking search paths into account.
		/// </summary>
		/// <param name="relativePath"></param>
		/// <returns></returns>
		/// <exception cref="FileNotFoundException">If the file was not found in search paths.</exception>
		/// <exception cref="Exception">Logs and rethrows any exception from File.ReadAllTextAsync.</exception>
		public String LoadFile(String relativePath)
		{
			var path = m_SearchPaths.GetFullPathToFile(relativePath);
			if (path == null)
				throw new FileNotFoundException(relativePath);

			return FileUtility.TryReadAllText(path);
		}

		public void Dispose()
		{
			m_LuaState.Environment.Clear();
			m_LuaState = null;
			m_SearchPaths = null;
		}
	}
}
