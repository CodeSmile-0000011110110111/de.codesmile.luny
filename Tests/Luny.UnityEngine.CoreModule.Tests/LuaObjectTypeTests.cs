// Copyright (C) 2021-2025 Steffen Itterheim
// Refer to included LICENSE file for terms and conditions.

using Luny.UnityEngine;
using NUnit.Framework;
using System;
using UnityEditor;
using UnityEngine;
using Task = System.Threading.Tasks.Task;

namespace LunyTests.UnityEngineCoreModule
{
	public sealed class LuaObjectTypeTests : LuaModuleTestsBase
	{
		[Test] public void UserData_Concat_CallsToString()
		{
			var retvals = DoFunction(nameof(UserData_Concat_CallsToString));

			Assert.That(retvals[0].Read<String>(), Is.EqualTo("this is a concat test (UnityEngine.GameObject)"));
		}

		[Test] public async Task LuaGameObject_new_InstanceNotNull()
		{
			var script = "return GameObject()";
			var retvals = await DoStringAsync(script, nameof(LuaGameObject_new_InstanceNotNull));

			Assert.That(retvals[0].Read<LuaGameObject>().Instance, Is.Not.Null);
		}

		[Test] public void LuaGameObject_Equality_AreEqual()
		{
			var retvals = DoFunction(nameof(LuaGameObject_Equality_AreEqual));

			Assert.That(retvals[0].Read<Boolean>(), Is.True);
			Assert.That(retvals[1].Read<Boolean>(), Is.False);
		}

		[Test] public void LuaGameObject_Equality_AreNotEqual()
		{
			var retvals = DoFunction(nameof(LuaGameObject_Equality_AreNotEqual));

			Assert.That(retvals[0].Read<Boolean>(), Is.False);
			Assert.That(retvals[1].Read<Boolean>(), Is.True);
		}

		[Test] public async Task Lua_newGameObjectWithName_NameMatches()
		{
			var script = "return GameObject('new go')";
			var retvals = await DoStringAsync(script, nameof(Lua_newGameObjectWithName_NameMatches));

			Assert.That(retvals[0].Read<LuaGameObject>().Instance.name, Is.EqualTo("new go"));
		}

		[Test] public async Task Lua_AddComponent_ComponentIsOfExpectedType()
		{
			var script = "local go = GameObject('go with MeshFilter');" +
			             "local com = go:AddComponent(MeshFilter);" +
			             "return go, com;";
			var retvals = await DoStringAsync(script, nameof(Lua_AddComponent_ComponentIsOfExpectedType));

			Assert.That(retvals[1].Read<LuaComponent>().Instance is MeshFilter);
			Assert.That(retvals[1].TryRead<LuaMeshFilter>(out var _));
			Assert.That(retvals[1].Read<LuaMeshFilter>().Instance,
				Is.EqualTo(retvals[0].Read<LuaGameObject>().Instance.GetComponent<MeshFilter>()));
		}

		[Test] public async Task Lua_AddComponent_GetComponentReturnsAddedComponent()
		{
			var script = "local go = GameObject('go with MeshFilter');" +
			             "local added = go:AddComponent(MeshFilter);" +
			             "local gotten = go:GetComponent(MeshFilter);" +
			             "return go, added, gotten;";
			var retvals = await DoStringAsync(script, nameof(Lua_AddComponent_GetComponentReturnsAddedComponent));

			Assert.That(retvals[1].Read<LuaComponent>().Instance is MeshFilter);
			Assert.That(retvals[2].Read<LuaComponent>().Instance is MeshFilter);
			var com1 = retvals[1].Read<LuaMeshFilter>();
			var com2 = retvals[2].Read<LuaMeshFilter>();
			Assert.That(com1.Instance, Is.EqualTo(com2.Instance));
			Assert.That(com1, Is.Not.EqualTo(com2)); // for as long as the component wrappers aren't being cached
		}

		[Test] public async Task Lua_AddMultipleComponents_HasMultipleComponents()
		{
			var script = "local go = GameObject('go');" +
			             "go:AddComponent(Skybox);" +
			             "go:AddComponent(Skybox);" +
			             "go:AddComponent(Skybox);" +
			             "return go;";
			var retvals = await DoStringAsync(script, nameof(Lua_AddMultipleComponents_HasMultipleComponents));

			var go = retvals[0].Read<LuaGameObject>();
			var components = go.Instance.GetComponents<Skybox>();
			Assert.That(components.Length, Is.EqualTo(3));
		}
	}
}
