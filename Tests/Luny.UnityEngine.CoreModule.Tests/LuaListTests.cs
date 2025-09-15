// Copyright (C) 2021-2025 Steffen Itterheim
// Refer to included LICENSE file for terms and conditions.

using Lua;
using Luny;
using Luny.UnityEngine;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

namespace LunyTests
{
	public sealed class LuaListTests : LuaModuleTestsBase
	{
		[Test] public void LuaTable_TryReadArray_ReturnsConvertedArray()
		{
			var table = new LuaTable(0, 0);
			for (var i = 1; i <= 3; i++)
				table[i] = $"Number {i}";

			Assert.That(new LuaValue(table).TryReadArray<String>(out var array));
			Assert.That(array.Length, Is.EqualTo(3));

			for (var i = 0; i < 3; i++)
			{
				var expected = $"Number {i + 1}";
				Assert.That(table[i + 1], Is.EqualTo(new LuaValue(expected)));
				Assert.That(array[i], Is.EqualTo(expected));
			}
		}

		[Test] public void LuaList_TryReadArray_ReturnsConvertedArray()
		{
			var input = new String[3];
			for (var i = 0; i < 3; i++)
				input[i] = $"Number {i + 1}";

			var list = new LuaList<String>((IList<String>)input);

			Assert.That(new LuaValue(list).TryReadArray<String>(out var array));
			Assert.That(array, Is.Not.Null);
			Assert.That(array.Length, Is.EqualTo(3));

			for (var i = 0; i < 3; i++)
			{
				var expected = $"Number {i + 1}";
				Assert.That(list[i], Is.EqualTo(expected));
				Assert.That(array[i], Is.EqualTo(expected));
			}

			Assert.That(list.ManagedObjects, Is.EqualTo(array));
		}

		[Test] public void LuaTable_AsArrayParameter_ConvertedToArray()
		{
			var retvals = DoFunction(nameof(LuaTable_AsArrayParameter_ConvertedToArray));

			Assert.That(retvals[0].TryRead<Int32>(out var _), Is.True);
			Assert.That(retvals[0].Read<Int32>(), Is.EqualTo(LayerMask.GetMask("Default", "Water", "UI")));
		}

		[Test] public void LuaList_AsReturnValue_IsLuaList()
		{
			var retvals = DoFunction(nameof(LuaList_AsReturnValue_IsLuaList));

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
}
