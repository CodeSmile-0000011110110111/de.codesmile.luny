// Copyright (C) 2021-2025 Steffen Itterheim
// Refer to included LICENSE file for terms and conditions.

using Lua;
using Lua.Runtime;
using Lua.Unity;
using Luny;
using NUnit.Framework;
using System;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using UnityEditor;
using UnityEngine;

public abstract class LuaModuleTestsBase
{
	// [TearDown] public void TearDown() => m_LuaState = null;
	protected const String TestsRootPath = "Packages/de.codesmile.luny/Tests";
	private LunyLuaScript m_TestScript;

	protected LuaState LuaState => LunyRuntime.Singleton.Lua.State;
	private String BaseScriptPath => $"{TestsRootPath}/Core/{nameof(LuaModuleTestsBase)}.lua";
	private String ScriptPath => $"{TestsRootPath}/{GetType().Assembly.GetName().Name}/{GetType().Name}.lua";

	private static void DebugChunk(Prototype chunk, Int32 id)
	{
		Debug.Log($"Chunk[{id}]" + new String('=', 50));
		Debug.Log($"Parameters:{chunk.ParameterCount}");

		Debug.Log("Code " + new String('-', 50));
		var index = 0;
		foreach (var inst in chunk.Code)
		{
			Debug.Log($"[{index}]\t{chunk.LineInfo[index]}\t\t{inst}");
			index++;
		}

		Debug.Log("LocalVariables " + new String('-', 50));
		index = 0;
		foreach (var local in chunk.LocalVariables)
		{
			Debug.Log($"[{index}]\t{local.Name}\t{local.StartPc}\t{local.EndPc}");
			index++;
		}

		Debug.Log("Constants " + new String('-', 50));
		index = 0;
		foreach (var constant in chunk.Constants.ToArray())
		{
			Debug.Log($"[{index}]\t{Regex.Escape(constant.ToString())}");
			index++;
		}

		Debug.Log("UpValues " + new String('-', 50));
		index = 0;
		foreach (var upValue in chunk.UpValues.ToArray())
		{
			Debug.Log($"[{index}]\t{upValue.Name}\t{(upValue.IsLocal ? 1 : 0)}\t{upValue.Index}");
			index++;
		}

		Debug.Log("");

		var nestedChunkId = 0;
		foreach (var localChunk in chunk.ChildPrototypes)
		{
			DebugChunk(localChunk, nestedChunkId);
			nestedChunkId++;
		}
	}

	[OneTimeSetUp] public async Task OneTimeSetUp()
	{
		var baseScript = LunyLuaScript.Load(BaseScriptPath);
		Assert.That(baseScript, Is.Not.Null, $"missing tests base script: {baseScript}");
		await baseScript.DoScriptAsync(LuaState);

		var scriptPath = ScriptPath;
		m_TestScript = LunyLuaScript.Load(scriptPath);
		Assert.That(m_TestScript, Is.Not.Null, $"missing test script: {scriptPath}");
		await m_TestScript.DoScriptAsync(LuaState);
	}

	protected LuaValue[] DoFunction(String funcName, params LuaValue[] args)
	{
		var testFunction = m_TestScript.ScriptContext.GetFunction(funcName);
		Assert.That(testFunction, Is.Not.Null, $"missing test function {funcName}() in script: {ScriptPath}");

		return TryInvokeTestFunc(LuaState, testFunction, args);
	}

	public LuaValue[] TryInvokeTestFunc(LuaState luaState, LuaFunction func, params LuaValue[] args)
	{
		var access = luaState.RootAccess;

		// push any function arguments onto stack
		var argCount = args.Length;
		if (argCount > 0)
		{
			var stack = access.Thread.Stack;
			foreach (var arg in args)
				stack.Push(arg);
		}

		// force synchronous execution
		var resultCount = access.RunAsync(func, argCount).Preserve().GetAwaiter().GetResult();
		using var results = access.ReadTopValues(resultCount);
		return results.AsSpan().ToArray();
	}

	protected async ValueTask<LuaValue[]> DoStringAsync(String script, String chunkName) =>
		await LuaState.DoStringAsync(script, chunkName, null);
}
