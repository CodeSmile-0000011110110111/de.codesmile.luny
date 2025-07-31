// Copyright (C) 2021-2025 Steffen Itterheim
// Refer to included LICENSE file for terms and conditions.

using CodeSmile.Luny;
using Lua_UnityEngine_CoreModule;
using Lua;
using Lua.Unity;
using NUnit.Framework;
using System;
using System.Threading.Tasks;
using UnityEditor;
using UnityEngine;
using Task = System.Threading.Tasks.Task;

public abstract class LuaModuleTestsBase
{
	// [SetUp] public void SetUp() => m_LuaState = LunyRuntime.Singleton.RuntimeLua.State;
	// [TearDown] public void TearDown() => m_LuaState = null;

	protected async ValueTask<LuaValue[]> DoStringAsync(string script, string chunkName)
	{
		return await LunyRuntime.Singleton.RuntimeLua.State.DoStringAsync(script, chunkName, null);
	}
}

public sealed class LuaGameObjectTests : LuaModuleTestsBase
{

	// Tests:
	// var go = new GameObject()
	// var com1 = go.AddComponent(BoxCollider)
	// var com2 = go.GetComponent(BoxCollider)
	// com1 == com2

	[Test] public async Task Lua_newGameObject_NoName()
	{
		var script = "return UnityEngine.GameObject.new()";
		var retvals = await DoStringAsync(script, nameof(Lua_newGameObject_NoName));
		Assert.That(retvals[0].Read<Lua_UnityEngine_GameObject>().Instance, Is.Not.Null);
	}

	[Test] public async Task Lua_newGameObject_WithName()
	{
		var script = "return UnityEngine.GameObject.new('new go')";
		var retvals = await DoStringAsync(script, nameof(Lua_newGameObject_NoName));
		Assert.That(retvals[0].Read<Lua_UnityEngine_GameObject>().Instance.name, Is.EqualTo("new go"));
	}

	[Test] public async Task Lua_AddComponent_ComponentIsOfExpectedLuaType()
	{
		var script = "local go = UnityEngine.GameObject.new('go with MeshFilter');" +
		             "local com = go:AddComponent(UnityEngine.MeshFilter);" +
		             "print(tostring(go));print(typeof(go));print(tostring(com));print(typeof(com));" +
		             "return go, com;";
		var retvals = await DoStringAsync(script, nameof(Lua_AddComponent_ComponentIsOfExpectedLuaType));
		Assert.That(retvals[1].Read<Lua_UnityEngine_Component>().Instance is MeshFilter);
		Assert.That(retvals[1].TryRead<Lua_UnityEngine_MeshFilter>(out var _), Is.True);
		Assert.That(retvals[1].Read<Lua_UnityEngine_MeshFilter>().Instance,
			Is.EqualTo(retvals[0].Read<Lua_UnityEngine_GameObject>().Instance.GetComponent<MeshFilter>()));
	}

	[Test] public async Task Lua_Enum_Test()
	{
		var script = "for k, v in pairs(UnityEngine.ApplicationInstallMode) do print(k, v) end;" +
		             "return UnityEngine, UnityEngine.ApplicationInstallMode, UnityEngine.ApplicationInstallMode.DeveloperBuild";
		var retvals = await DoStringAsync(script, nameof(Lua_Enum_Test));
		Assert.That(retvals[0], Is.Not.Null);
		Assert.That(retvals[1], Is.Not.Null);
		Debug.Log(retvals[0]);
		Debug.Log(retvals[1]);
		Debug.Log(retvals[2]);

		foreach (var pair in retvals[1].Read<LuaTable>())
			Debug.Log($"{pair.Key}: {pair.Value}");

		Assert.That(retvals[0].Read<LuaTable>(), Is.Not.Null);
		Assert.That(retvals[1].Read<LuaTable>(), Is.Not.Null);
		Assert.That(retvals[2].Read<Double>(), Is.EqualTo((Double)ApplicationInstallMode.DeveloperBuild));
		Assert.That(retvals[2].Read<ApplicationInstallMode>(), Is.EqualTo(ApplicationInstallMode.DeveloperBuild));
	}
}
