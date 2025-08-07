// Copyright (C) 2021-2025 Steffen Itterheim
// Refer to included LICENSE file for terms and conditions.

using Lua;
using Luny;
using Luny.UnityEngine;
using NUnit.Framework;
using System;
using UnityEditor;
using UnityEngine;

public sealed class LuaListTests : LuaModuleTestsBase
{
	[Test] public void LuaValue_TryReadArray_CreatesArrayFromTable()
	{
		var table = new LuaTable();
		for (var i = 1; i <= 3; i++)
			table[i] = $"Number {i}";

		//new LuaValue(table).TryReadList<String[]>(out var array);

		for (var i = 1; i <= 3; i++)
			Assert.That(table[i], Is.EqualTo($"Number {i}"));
	}

	[Test] public void LuaList_FromLuaTable_ConvertedToArray()
	{
		var retvals = DoFunction(nameof(LuaList_FromLuaTable_ConvertedToArray));

		Assert.That(retvals[1].TryRead<LuaComponent>(out var _), Is.True);
		Assert.That(retvals[2].TryRead<LuaComponent>(out var _), Is.True);
		Assert.That(retvals[3].TryRead<LuaComponent>(out var _), Is.True);
	}

	[Test] public void LuaList_GetComponents_IsLuaListWithComponents()
	{
		var retvals = DoFunction(nameof(LuaList_GetComponents_IsLuaListWithComponents));

		Assert.That(retvals[1].TryRead<LuaList<Component>>(out var _), Is.True);
		Assert.That(retvals[1].Read<LuaList<Component>>().ManagedObjects.Count, Is.EqualTo(3));
	}

	[Test] public void LuaList_GetComponentsLength_CorrectLength()
	{
		var retvals = DoFunction(nameof(LuaList_GetComponentsLength_CorrectLength));

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

	[Test] public void LuaList_Pairs_EnumeratesAllAndCorrectValues()
	{
		var retvals = DoFunction(nameof(LuaList_Pairs_EnumeratesAllAndCorrectValues));

		Assert.That(retvals[1].TryRead<LuaList<Component>>(out var _), Is.True);
		Assert.That(retvals[2].TryRead<LuaTable>(out var _), Is.True);
		Assert.That(retvals[2].Read<LuaTable>().HashMapCount, Is.EqualTo(0));
		Assert.That(retvals[2].Read<LuaTable>().ArrayLength, Is.EqualTo(3));

		var componentsList = retvals[1].Read<LuaList<Component>>();
		var enumeratedValues = retvals[2].Read<LuaTable>();
		for (var i = 1; i <= 3; i++)
		{
			var actual = enumeratedValues[i].Read<LuaComponent>().Instance;
			var expected = componentsList[i - 1];
			Assert.That(actual.GetInstanceID(), Is.EqualTo(expected.GetInstanceID()));
		}
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
		{
			var actual = enumeratedValues[i].Read<LuaComponent>().Instance;
			var expected = componentsList[i - 1];
			Assert.That(actual.GetInstanceID(), Is.EqualTo(expected.GetInstanceID()));
		}
	}
}
