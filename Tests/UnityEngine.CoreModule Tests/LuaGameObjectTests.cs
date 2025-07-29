// Copyright (C) 2021-2025 Steffen Itterheim
// Refer to included LICENSE file for terms and conditions.

using CodeSmile.Luny;
using Lua_UnityEngine.CoreModule;
using Lua.Unity;
using NUnit.Framework;
using System.Threading.Tasks;
using UnityEngine;

public class LuaGameObjectTests
{
	//[SetUp] public void SetUp() => Debug.Log("MINIMAL Test SetUp runs ...");
	//[TearDown] public void TearDown() => Debug.Log("MINIMAL Test TearDown runs ...");

	// Tests:
	// var go = new GameObject()
	// var com1 = go.AddComponent(BoxCollider)
	// var com2 = go.GetComponent(BoxCollider)
	// com1 == com2

	[Test] public async Task Lua_newGameObject_NoName()
	{
		var script = "return UnityEngine.GameObject.new()";
		var retvals = await LunyRuntime.Singleton.RuntimeLua.State.DoStringAsync(script, nameof(Lua_newGameObject_NoName), null);
		Assert.That(retvals[0].Read<Lua_UnityEngine_GameObject>().Instance, Is.Not.Null);
	}
	[Test] public async Task Lua_newGameObject_WithName()
	{
		var script = "return UnityEngine.GameObject.new('new go')";
		var retvals = await LunyRuntime.Singleton.RuntimeLua.State.DoStringAsync(script, nameof(Lua_newGameObject_NoName), null);
		Assert.That(retvals[0].Read<Lua_UnityEngine_GameObject>().Instance, Is.Not.Null);
		Assert.That(retvals[0].Read<Lua_UnityEngine_GameObject>().Instance.name, Is.EqualTo("new go"));
	}
}
