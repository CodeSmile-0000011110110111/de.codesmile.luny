// Copyright (C) 2021-2025 Steffen Itterheim
// Refer to included LICENSE file for terms and conditions.

using CodeSmile.Luny;
using Lua;
using Lua.Unity;
using System;
using System.Threading.Tasks;
using UnityEditor;
using UnityEngine;

public abstract class LuaModuleTestsBase
{
	// [SetUp] public void SetUp() => m_LuaState = LunyRuntime.Singleton.RuntimeLua.State;
	// [TearDown] public void TearDown() => m_LuaState = null;

	protected async ValueTask<LuaValue[]> DoStringAsync(String script, String chunkName) =>
		await LunyRuntime.Singleton.RuntimeLua.State.DoStringAsync(script, chunkName, null);
}
