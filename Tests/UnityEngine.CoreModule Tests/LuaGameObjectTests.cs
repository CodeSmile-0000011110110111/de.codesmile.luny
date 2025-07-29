// Copyright (C) 2021-2025 Steffen Itterheim
// Refer to included LICENSE file for terms and conditions.

#if UNITYENGINE_COREMODULE_LOADER_TESTS
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
		Assert.That(retvals[0].Read<Lua_UnityEngine_GameObject>().Instance.name, Is.EqualTo("new go"));
	}
	[Test] public async Task Lua_AddComponent_MeshFilter()
	{
		var script = "local go = UnityEngine.GameObject.new('go with MeshFilter');" +
		             "return go, go:AddComponent(UnityEngine.MeshFilter);";
		var retvals = await LunyRuntime.Singleton.RuntimeLua.State.DoStringAsync(script, nameof(Lua_AddComponent_MeshFilter), null);
		Assert.That(retvals[1].Read<Lua_UnityEngine_MeshFilter>().Instance is MeshFilter);
		Assert.That(retvals[1].Read<Lua_UnityEngine_MeshFilter>().Instance.gameObject, Is.EqualTo(retvals[0].Read<Lua_UnityEngine_GameObject>().Instance));
	}
}
#endif
