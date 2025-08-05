// Copyright (C) 2021-2025 Steffen Itterheim
// Refer to included LICENSE file for terms and conditions.

using CodeSmile.Luny;
using Lua;
using NUnit.Framework;
using System.Threading.Tasks;
using UnityEditor;
using UnityEngine;

public sealed class LuaCustomTypesTests : LuaModuleTestsBase
{
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

		Assert.That(retvals[0].TryRead<LuaTable>(out var _));
		Assert.That(retvals[0].TryRead<LuaEnum>(out var _)); // TODO
	}

	[Test] public async Task Lua_Enum_ReturnCorrectValue()
	{
		var script = "return ApplicationInstallMode.DeveloperBuild;";
		var retvals = await DoStringAsync(script, nameof(Lua_Enum_ReturnCorrectValue));

		Assert.That(retvals[0].Read<ApplicationInstallMode>(), Is.EqualTo(ApplicationInstallMode.DeveloperBuild));
	}
}
