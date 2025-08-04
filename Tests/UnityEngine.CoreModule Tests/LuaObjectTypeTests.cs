// Copyright (C) 2021-2025 Steffen Itterheim
// Refer to included LICENSE file for terms and conditions.

using CodeSmile.Luny;
using Lua_UnityEngine_CoreModule;
using Lua;
using NUnit.Framework;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using Task = System.Threading.Tasks.Task;

public sealed class LuaObjectTypeTests : LuaModuleTestsBase
{
	[Test] public async Task Lua_newGameObject_InstanceNotNull()
	{
		var script = "return GameObject.new()";
		var retvals = await DoStringAsync(script, nameof(Lua_newGameObject_InstanceNotNull));

		Assert.That(retvals[0].Read<Lua_UnityEngine_GameObject>().Instance, Is.Not.Null);
	}

	[Test] public async Task Lua_newGameObjectWithName_NameMatches()
	{
		var script = "return GameObject.new('new go')";
		var retvals = await DoStringAsync(script, nameof(Lua_newGameObjectWithName_NameMatches));

		Assert.That(retvals[0].Read<Lua_UnityEngine_GameObject>().Instance.name, Is.EqualTo("new go"));
	}

	[Test] public async Task Lua_AddComponent_ComponentIsOfExpectedType()
	{
		var script = "local go = GameObject.new('go with MeshFilter');" +
		             "local com = go:AddComponent(MeshFilter);" +
		             "return go, com;";
		var retvals = await DoStringAsync(script, nameof(Lua_AddComponent_ComponentIsOfExpectedType));

		Assert.That(retvals[1].Read<Lua_UnityEngine_Component>().Instance is MeshFilter);
		Assert.That(retvals[1].TryRead<Lua_UnityEngine_MeshFilter>(out var _));
		Assert.That(retvals[1].Read<Lua_UnityEngine_MeshFilter>().Instance,
			Is.EqualTo(retvals[0].Read<Lua_UnityEngine_GameObject>().Instance.GetComponent<MeshFilter>()));
	}

	[Test] public async Task Lua_AddComponent_GetComponentReturnsAddedComponent()
	{
		var script = "local go = GameObject.new('go with MeshFilter');" +
		             "local added = go:AddComponent(MeshFilter);" +
		             "local gotten = go:GetComponent(MeshFilter);" +
		             "return go, added, gotten;";
		var retvals = await DoStringAsync(script, nameof(Lua_AddComponent_GetComponentReturnsAddedComponent));

		Assert.That(retvals[1].Read<Lua_UnityEngine_Component>().Instance is MeshFilter);
		Assert.That(retvals[2].Read<Lua_UnityEngine_Component>().Instance is MeshFilter);
		var com1 = retvals[1].Read<Lua_UnityEngine_MeshFilter>();
		var com2 = retvals[2].Read<Lua_UnityEngine_MeshFilter>();
		Assert.That(com1.Instance, Is.EqualTo(com2.Instance));
		Assert.That(com1, Is.Not.EqualTo(com2)); // for as long as the component wrappers aren't being cached
	}

	[Test] public async Task Lua_AddMultipleComponents_HasMultipleComponents()
	{
		var script = "local go = GameObject.new('go');" +
		             "go:AddComponent(Skybox);" +
		             "go:AddComponent(Skybox);" +
		             "go:AddComponent(Skybox);" +
		             "return go;";
		var retvals = await DoStringAsync(script, nameof(Lua_AddMultipleComponents_HasMultipleComponents));

		var go = retvals[0].Read<Lua_UnityEngine_GameObject>();
		var components = go.Instance.GetComponents<Skybox>();
		Assert.That(components.Length, Is.EqualTo(3));
	}
}
