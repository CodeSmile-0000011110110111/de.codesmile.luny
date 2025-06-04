/*
// Copyright (C) 2021-2025 Steffen Itterheim
// Refer to included LICENSE file for terms and conditions.

using Lua;
using Lua.CodeAnalysis.Compilation;
using Lua.Runtime;
using Lua.Standard;
using Lua.Unity;
using System;
using System.IO;
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
		String DumpTable(String name, LuaValue table);
	}

	internal interface ILunyLuaInternal
	{
		void Dispose();
		void LoadApiCompatibility();
	}

	public sealed class LunyLua : ILunyLua, ILunyLuaInternal
	{
		private ILunySearchPaths m_SearchPaths;
		private LuaState m_LuaState;

		public LuaState State => m_LuaState;

		public static Closure CompileClosure(LuaState luaState, String script, String chunkName)
		{
			var chunk = LuaCompiler.Default.Compile(script, chunkName);
			return new Closure(luaState, chunk);
		}

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

		public LunyLua(ILunySearchPaths searchPaths)
		{
			LunyLogger.LogHeap(GetType(), GetHashCode(), null, "ctor");

			m_SearchPaths = searchPaths;
			m_LuaState = LuaState.Create();
			InitLuaEnvironment();
		}

		public String DumpEnvironment() => DumpTable("Luny environment", m_LuaState.Environment);

		public String DumpTable(String name, LuaValue value)
		{
			var sb = new StringBuilder($"{name} = ");
			if (value.Type != LuaValueType.Table)
			{
				if (value.Type == LuaValueType.UserData)
					sb.Append($"({value.Read<ILuaUserData>()})");
				else
					sb.Append($"({value.ToString()})");
				return sb.ToString();
			}

			sb.Append("{{\n");

			var table = value.Read<LuaTable>();
			var arrayLength = table.ArrayLength;
			for (var i = 0; i < arrayLength; i++)
				sb.AppendLine($"\t[{i}] = {table[i]}");

			var hashCount = table.HashMapCount;
			if (hashCount > 0)
			{
				var nextKey = LuaValue.Nil;
				for (var i = 0; i < hashCount; i++)
				{
					table.TryGetNext(nextKey, out var kvp);
					nextKey = kvp.Key;
					if (kvp.Value.Type == LuaValueType.Table)
					{
						var t = kvp.Value.Read<LuaTable>();
						sb.AppendLine($"\t[\"{kvp.Key}\"] = {kvp.Value}  [{t.ArrayLength}]  {{{t.HashMapCount}}}");
					}
					else
						sb.AppendLine($"\t[\"{kvp.Key}\"] = {kvp.Value}");
				}
			}
			sb.AppendLine("}");
			return sb.ToString();
		}

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

			return LunyFile.TryReadAllText(path);
		}

		public void LoadApiCompatibility()
		{
			var alternativeApi = Resources.Load<LuaAsset>(ApiCompatibilityScriptPath);
			if (alternativeApi == null)
				throw new FileNotFoundException(ApiCompatibilityScriptPath + ".lua");

			DoString(alternativeApi.Text, ApiCompatibilityScriptPath);
		}

		public void Dispose()
		{
			m_LuaState.Environment.Clear();
			m_LuaState = null;
			m_SearchPaths = null;
		}

		~LunyLua() => LunyLogger.LogHeap(GetType(), GetHashCode(), null, "finalizer");

		private void InitLuaEnvironment()
		{
			m_LuaState.OpenBasicLibrary();
			m_LuaState.OpenBitwiseLibrary();
			m_LuaState.OpenCoroutineLibrary();
			m_LuaState.OpenDebugLibrary();
			m_LuaState.OpenMathLibrary();
			m_LuaState.OpenStringLibrary();
			m_LuaState.OpenTableLibrary();
			m_LuaState.OpenModuleLibrary();
			//m_LuaState.OpenOperatingSystemLibrary(); // NOTE: os.time et al will fail in IL2CPP builds

#if UNITY_EDITOR
			m_LuaState.OpenIOLibrary();
#endif

			RemovePotentiallyHarmfulMethods();
			RegisterFunctionOverrides();

			OverrideLogging();
		}

		private void RemovePotentiallyHarmfulMethods()
		{
			var env = m_LuaState.Environment;
			env.SetNil("dofile");
			env.SetNil("load");
			env.SetNil("loadfile");
			env.SetNil("pcall");
			env.SetNil("xpcall");

			if (env["os"].TryRead(out LuaTable os))
			{
				os.SetNil("execute");
				os.SetNil("exit");
				os.SetNil("remove");
				os.SetNil("rename");
				os.SetNil("tmpname");
			}
		}

		private void RegisterFunctionOverrides()
		{
#pragma warning disable CS1998 // Async method lacks 'await' operators and will run synchronously
			m_LuaState.Environment.SetFunction("dofile", new LuaFunction("dofile", async (context, buffer, ct) =>
			{
				var relativePath = context.GetArgument<String>(0);
				var script = LoadFile(relativePath);
				var closure = CompileClosure(context.State, script, relativePath);
				return await closure!.InvokeAsync(context, buffer, ct);
			}));

			m_LuaState.Environment.SetFunction("loadfile", new LuaFunction("loadfile", async (context, buffer, ct) =>
			{
				try
				{
					var relativePath = context.GetArgument<String>(0);
					var script = LoadFile(relativePath);
					buffer.Span[0] = CompileClosure(context.State, script, relativePath);
					return 1;
				}
				catch (Exception ex)
				{
					buffer.Span[0] = LuaValue.Nil;
					buffer.Span[1] = ex.Message;
					return 2;
				}
			}));
#pragma warning restore CS1998 // Async method lacks 'await' operators and will run synchronously
		}

		private void OverrideLogging()
		{
			var logTable = new LuaTable(0, 3);
			logTable["info"] = new LuaFunction("info", (context, buffer, ct) =>
			{
				LunyLogger.LogInfo(GetLogString(context));
				return new ValueTask<Int32>(0);
			});
			logTable["warning"] = new LuaFunction("warning", (context, buffer, ct) =>
			{
				LunyLogger.LogWarn(GetLogString(context));
				return new ValueTask<Int32>(0);
			});
			logTable["error"] = new LuaFunction("error", (context, buffer, ct) =>
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
	}
}
*/
