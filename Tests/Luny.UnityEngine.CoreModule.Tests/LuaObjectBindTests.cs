// Copyright (C) 2021-2025 Steffen Itterheim
// Refer to included LICENSE file for terms and conditions.

using Lua;
using Luny;
using NUnit.Framework;
using System;
using UnityEditor;
using UnityEngine;
using UnityEngine.Scripting;

namespace LunyTests.UnityEngineCoreModule
{
	public sealed class LuaObjectBindTests : LuaModuleTestsBase
	{
		private const String CustomObjectLuaName = "MyCustomObject";
		private const String CustomStructLuaName = "MyCustomStruct";

		[Test] public void LuaObject_BindObject_AccessibleInLua()
		{
			var myCustomInstance = new MyCustomIndexableObject();
			var myCustomLuaValue = LuaObject<MyCustomIndexableObject>.Bind(myCustomInstance);
			LuaState.Environment[CustomObjectLuaName] = myCustomLuaValue;

			var retvals = DoFunction(nameof(LuaObject_BindObject_AccessibleInLua));

			Assert.That(retvals[0].TryRead<LuaObject<MyCustomIndexableObject>>(out var myCustomInstanceFromLua), Is.True);
			Assert.That(myCustomInstanceFromLua.Instance, Is.EqualTo(myCustomInstance));
			Assert.That(myCustomInstanceFromLua.Instance.SomeInteger, Is.EqualTo(12345));
		}

		[Test] public void LuaObject_Index_ReturnsCorrectValue()
		{
			var myCustomInstance = new MyCustomIndexableObject();
			var myCustomLuaValue = LuaObject<MyCustomIndexableObject>.Bind(myCustomInstance);
			LuaState.Environment[CustomObjectLuaName] = myCustomLuaValue;

			var retvals = DoFunction(nameof(LuaObject_Index_ReturnsCorrectValue));

			Assert.That(retvals[0].TryRead<LuaObject<MyCustomIndexableObject>>(out var _), Is.True);
			Assert.That(retvals[1].Read<Int32>(), Is.EqualTo(myCustomInstance.SomeInteger));
			Assert.That(retvals[2].Read<Int32>(), Is.EqualTo(myCustomInstance.SomeInteger));
		}

		[Test] public void LuaObject_IndexViaReflection_ReturnsCorrectValue()
		{
			var myCustomInstance = new MyCustomReflectionObject();
			var myCustomLuaValue = LuaObject<MyCustomReflectionObject>.Bind(myCustomInstance);
			LuaState.Environment[CustomObjectLuaName] = myCustomLuaValue;

			var retvals = DoFunction(nameof(LuaObject_IndexViaReflection_ReturnsCorrectValue));

			Assert.That(retvals[0].TryRead<LuaObject<MyCustomReflectionObject>>(out var _), Is.True);
			Assert.That(retvals[1].Read<Int32>(), Is.EqualTo(myCustomInstance.SomeInteger));
			Assert.That(retvals[2].Read<Int32>(), Is.EqualTo(myCustomInstance.SomeInteger));
		}

		[Test] public void LuaObject_WrongStringIndex_Throws()
		{
			LuaState.Environment[CustomObjectLuaName] = LuaObject<MyCustomIndexableObject>.Bind(new MyCustomIndexableObject());

			Assert.Throws<LuaRuntimeException>(() => DoFunction(nameof(LuaObject_WrongStringIndex_Throws)));
		}

		[Test] public void LuaObject_WrongIntIndex_Throws()
		{
			LuaState.Environment[CustomObjectLuaName] = LuaObject<MyCustomIndexableObject>.Bind(new MyCustomIndexableObject());

			Assert.Throws<LuaRuntimeException>(() => DoFunction(nameof(LuaObject_WrongIntIndex_Throws)));
		}

		[Test] public void LuaValueType_BindStruct_AccessibleInLua()
		{
			var myCustomStruct = new MyCustomStruct(12345);
			var myCustomLuaValue = LuaValueType<MyCustomStruct>.Bind(myCustomStruct);
			LuaState.Environment[CustomStructLuaName] = myCustomLuaValue;

			var retvals = DoFunction(nameof(LuaValueType_BindStruct_AccessibleInLua));

			Assert.That(retvals[0].TryRead<LuaValueType<MyCustomStruct>>(out var myCustomStructFromLua), Is.True);
			Assert.That(myCustomStructFromLua.Value, Is.EqualTo(myCustomStruct));
			Assert.That(myCustomStructFromLua.Value.SomeInteger, Is.EqualTo(12345));
			Assert.That(myCustomStructFromLua.ValueRef.SomeInteger, Is.EqualTo(12345));
		}

		public sealed class MyCustomIndexableObject : ILuaIndexable
		{
			public Int32 SomeInteger = 12345;

			public Boolean TryGetLuaValue(Int32 luaIndex, out LuaValue value, ILuaObjectFactory factory)
			{
				switch (luaIndex)
				{
					case 1:
						value = SomeInteger;
						return true;
					default:
						value = default;
						return false;
				}
			}

			public Boolean TryGetLuaValue(String key, out LuaValue value, ILuaObjectFactory factory)
			{
				switch (key)
				{
					case nameof(SomeInteger):
						value = SomeInteger;
						return true;
					default:
						value = default;
						return false;
				}
			}

			public Boolean TrySetLuaValue(Int32 index, LuaValue value) => throw new NotImplementedException();

			public Boolean TrySetLuaValue(String key, LuaValue value) => throw new NotImplementedException();
		}

		public sealed class MyCustomReflectionObject
		{
			public Int32 SomeInteger = 12345;

			[Preserve] // Preserve prevents members from getting stripped in builds if it's only used via reflection
			public Int32 this[Int32 index]
			{
				// reflection indexing already adjusted index to be 0-based
				get => index == 0 ? SomeInteger : -1;
				set => SomeInteger = index == 0 ? value : -1;
			}
		}

		public struct MyCustomStruct
		{
			public Int32 SomeInteger;
			public MyCustomStruct(Int32 someInteger) => SomeInteger = someInteger;
		}
	}
}
