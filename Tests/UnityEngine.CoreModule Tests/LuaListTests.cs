// Copyright (C) 2021-2025 Steffen Itterheim
// Refer to included LICENSE file for terms and conditions.

using CodeSmile.Luny;
using Lua_UnityEngine_CoreModule;
using Lua;
using NUnit.Framework;
using System.Threading.Tasks;
using UnityEngine;

public sealed class LuaListTests : LuaModuleTestsBase
{
	[Test] public async Task Lua_GetComponents_ReturnsLuaList()
	{
		var script = "local go = GameObject.new('go');" +
		             "go:AddComponent(Skybox);" +
		             "go:AddComponent(Skybox);" +
		             "go:AddComponent(Skybox);" +
		             "return go, go:GetComponents(Skybox);";
		var retvals = await DoStringAsync(script, nameof(Lua_GetComponents_ReturnsLuaList));

		Assert.That(retvals[1].TryRead<LuaList<Component>>(out var _), Is.True);
		Assert.That(retvals[1].Read<LuaList<Component>>().ManagedList.Count, Is.EqualTo(3));
	}

	[Test] public async Task Lua_GetComponents_CanGetLength()
	{
		var script = "local go = GameObject.new('go');" +
		             "go:AddComponent(Skybox);" +
		             "go:AddComponent(Skybox);" +
		             "go:AddComponent(Skybox);" +
		             "local coms = go:GetComponents(Skybox);" +
		             "return go, #go:GetComponents(Skybox);";
		var retvals = await DoStringAsync(script, nameof(Lua_GetComponents_CanGetLength));

		Debug.Log(retvals[1]);
		Assert.That(retvals[1], Is.Not.Null);
		Assert.That(retvals[1].Type, Is.Not.EqualTo(LuaValueType.Nil));
		Assert.That(retvals[1].Read<int>(), Is.EqualTo(3));
	}

	[Test] public async Task Lua_GetComponents_CanIndex()
	{
		var script = "local go = GameObject.new('go');" +
		             "go:AddComponent(Skybox);" +
		             "go:AddComponent(Skybox);" +
		             "go:AddComponent(Skybox);" +
		             "local coms = go:GetComponents(Skybox);" +
		             "return go, coms[1], coms[2], coms[3];";
		var retvals = await DoStringAsync(script, nameof(Lua_GetComponents_CanIndex));

		Assert.That(retvals[1].TryRead<Lua_UnityEngine_Component>(out var _), Is.True);
		Assert.That(retvals[2].TryRead<Lua_UnityEngine_Component>(out var _), Is.True);
		Assert.That(retvals[3].TryRead<Lua_UnityEngine_Component>(out var _), Is.True);
	}

	[Test] public async Task Lua_GetComponents_CanIterateWithPairs()
	{
		var script = "local go = GameObject.new('go');" +
		             "go:AddComponent(Skybox);" +
		             "go:AddComponent(Skybox);" +
		             "go:AddComponent(Skybox);" +
		             "local retvals = {};" +
		             "local coms = go:GetComponents(Skybox);" +
		             "for key, value in pairs(coms) do retvals[key] = value end;" +
		             "return go, coms, retvals;";
		var retvals = await DoStringAsync(script, nameof(Lua_GetComponents_CanIterateWithPairs));

		Assert.That(retvals[1].TryRead<LuaList<Component>>(out var _), Is.True);
		Assert.That(retvals[2].TryRead<LuaTable>(out var _), Is.True);
		Assert.That(retvals[2].Read<LuaTable>().ArrayLength, Is.EqualTo(3));
	}
}
