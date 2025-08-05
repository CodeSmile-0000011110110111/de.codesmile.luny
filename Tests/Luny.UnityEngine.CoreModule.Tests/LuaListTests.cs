// Copyright (C) 2021-2025 Steffen Itterheim
// Refer to included LICENSE file for terms and conditions.

using CodeSmile.Luny;
using Lua;
using Luny.UnityEngine;
using NUnit.Framework;
using System;
using UnityEditor;
using UnityEngine;

public sealed class LuaListTests : LuaModuleTestsBase
{
	[Test] public void LuaGameObject_GetComponents_IsLuaListWithComponents()
	{
		var retvals = DoFunction(nameof(LuaGameObject_GetComponents_IsLuaListWithComponents));

		Assert.That(retvals[1].TryRead<LuaList<Component>>(out var _), Is.True);
		Assert.That(retvals[1].Read<LuaList<Component>>().ManagedObjects.Count, Is.EqualTo(3));
	}

	[Test] public void LuaGameObject_GetComponentsLength_CorrectLength()
	{
		var retvals = DoFunction(nameof(LuaGameObject_GetComponentsLength_CorrectLength));

		Assert.That(retvals[1], Is.Not.Null);
		Assert.That(retvals[1].Type, Is.Not.EqualTo(LuaValueType.Nil));
		Assert.That(retvals[1].Read<Int32>(), Is.EqualTo(3));
	}

	[Test] public void LuaList_Indexers_CorrectValues()
	{
		var retvals = DoFunction(nameof(LuaList_Indexers_CorrectValues));

		Assert.That(retvals[1].TryRead<LuaComponent>(out var _), Is.True);
		Assert.That(retvals[2].TryRead<LuaComponent>(out var _), Is.True);
		Assert.That(retvals[3].TryRead<LuaComponent>(out var _), Is.True);
	}

	[Test] public void LuaList_IPairs_EnumeratesAllAndCorrectValues()
	{
		var retvals = DoFunction(nameof(LuaList_IPairs_EnumeratesAllAndCorrectValues));

		Assert.That(retvals[1].TryRead<LuaList<Component>>(out var _), Is.True);
		Assert.That(retvals[2].TryRead<LuaTable>(out var _), Is.True);
		Assert.That(retvals[2].Read<LuaTable>().HashMapCount, Is.EqualTo(0));
		Assert.That(retvals[2].Read<LuaTable>().ArrayLength, Is.EqualTo(3));

		var componentsList = retvals[1].Read<LuaList<Component>>();
		var enumeratedValues = retvals[2].Read<LuaTable>();
		for (var i = 1; i <= 3; i++)
			Assert.That(enumeratedValues[i].Read<LuaComponent>(), Is.EqualTo(componentsList[i]));
	}
}
