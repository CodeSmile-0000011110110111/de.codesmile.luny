// Copyright (C) 2021-2025 Steffen Itterheim
// Refer to included LICENSE file for terms and conditions.

using CodeSmile.Luny;
using Lua;
using Lua.Runtime;
using Lua.Unity;
using System;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using UnityEditor;
using UnityEngine;

public abstract class LuaModuleTestsBase
{
	// [SetUp] public void SetUp() => m_LuaState = LunyRuntime.Singleton.RuntimeLua.State;
	// [TearDown] public void TearDown() => m_LuaState = null;

	protected async ValueTask<LuaValue[]> DoStringAsync(String script, String chunkName)
	{
		var state = LunyRuntime.Singleton.RuntimeLua.State;
		return await state.DoStringAsync(script, chunkName, null);
	}
	
	static void DebugChunk(Prototype chunk, int id)
	{
		Debug.Log($"Chunk[{id}]" + new string('=', 50));
		Debug.Log($"Parameters:{chunk.ParameterCount}");

		Debug.Log("Code " + new string('-', 50));
		var index = 0;
		foreach (var inst in chunk.Code)
		{
			Debug.Log($"[{index}]\t{chunk.LineInfo[index]}\t\t{inst}");
			index++;
		}

		Debug.Log("LocalVariables " + new string('-', 50));
		index = 0;
		foreach (var local in chunk.LocalVariables)
		{
			Debug.Log($"[{index}]\t{local.Name}\t{local.StartPc}\t{local.EndPc}");
			index++;
		}

		Debug.Log("Constants " + new string('-', 50));
		index = 0;
		foreach (var constant in chunk.Constants.ToArray())
		{
			Debug.Log($"[{index}]\t{Regex.Escape(constant.ToString())}");
			index++;
		}

		Debug.Log("UpValues " + new string('-', 50));
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
}
