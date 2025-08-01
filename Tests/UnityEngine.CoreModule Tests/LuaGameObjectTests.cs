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
using UnityEngine.UIElements;
using Task = System.Threading.Tasks.Task;

public abstract class LuaModuleTestsBase
{
	// [SetUp] public void SetUp() => m_LuaState = LunyRuntime.Singleton.RuntimeLua.State;
	// [TearDown] public void TearDown() => m_LuaState = null;

	protected async ValueTask<LuaValue[]> DoStringAsync(String script, String chunkName) =>
		await LunyRuntime.Singleton.RuntimeLua.State.DoStringAsync(script, chunkName, null);
}

public sealed class LuaGameObjectTests : LuaModuleTestsBase
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

	[Test] public async Task Lua_AddMultipleComponentsOfSameType_HasMultipleComponentsOfSameType()
	{
		var script = "local go = GameObject.new('go');" +
		             "go:AddComponent(LunyScript);" +
		             "go:AddComponent(LunyScript);" +
		             "go:AddComponent(LunyScript);" +
		             "return go;";
		var retvals = await DoStringAsync(script, nameof(Lua_AddComponent_GetComponentReturnsAddedComponent));

		var go = retvals[0].Read<Lua_UnityEngine_GameObject>();
		var components = go.Instance.GetComponents<LunyScript>();
		Assert.That(components.Length, Is.EqualTo(3));
	}

	[Test] public async Task Lua_Namespace_IsLuaNamespaceType()
	{
		var script = "return UnityEngine;";
		var retvals = await DoStringAsync(script, nameof(Lua_Namespace_IsLuaNamespaceType));

		Assert.That(retvals[0].TryRead<LuaNamespace>(out var _));
		Assert.That(retvals[0].Read<LuaNamespace>().Name, Is.EqualTo(nameof(UnityEngine)));
	}

	[Test] public async Task Lua_Enum_IsLuaEnumType()
	{
		var script = "return ApplicationInstallMode";
		var retvals = await DoStringAsync(script, nameof(Lua_Enum_IsLuaEnumType));

		Assert.That(retvals[0].TryRead<LuaEnum>(out var _));
	}

	[Test] public async Task Lua_Enum_ReturnCorrectValue()
	{
		var script = "return ApplicationInstallMode.DeveloperBuild;";
		var retvals = await DoStringAsync(script, nameof(Lua_Enum_ReturnCorrectValue));

		Debug.Log(retvals[0]);

		Assert.That(retvals[0].Read<ApplicationInstallMode>(), Is.EqualTo(ApplicationInstallMode.DeveloperBuild));
	}

	[Test] public async Task Lua_GetSetIndexerValue_ReturnsCorrectValues()
	{
		var script = "local v3 = Vector3.new();" +
		             "v3[0] = 1; v3[1] = 2; v3[2] = 3;" +
		             "return v3[0], v3[1], v3[2];";
		var retvals = await DoStringAsync(script, nameof(Lua_GetSetIndexerValue_ReturnsCorrectValues));

		Assert.That(retvals[0].Read<float>(), Is.EqualTo(1));
		Assert.That(retvals[1].Read<float>(), Is.EqualTo(2));
		Assert.That(retvals[2].Read<float>(), Is.EqualTo(3));
	}
}
