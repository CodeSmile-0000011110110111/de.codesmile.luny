using Luny.UnityEngine;
using NUnit.Framework;
using System;
using System.Threading.Tasks;
using UnityEditor;
using UnityEngine;

namespace LunyTests.UnityEngineCoreModule
{
	public class LuaValueTypeTests : LuaModuleTestsBase
	{
		[Test] public async Task Lua_newVector4_0Params()
		{
			var script = "return UnityEngine.Vector4()";
			var retvals = await DoStringAsync(script, nameof(Lua_newVector4_0Params));
			Assert.That(retvals[0].Read<LuaVector4>().Value, Is.EqualTo(new Vector4()));
		}

		[Test] public async Task Lua_newVector4_2Params()
		{
			var script = "return UnityEngine.Vector4(1,2)";
			var retvals = await DoStringAsync(script, nameof(Lua_newVector4_2Params));
			Assert.That(retvals[0].Read<LuaVector4>().Value, Is.EqualTo(new Vector4(1, 2)));
		}

		[Test] public async Task Lua_newVector4_3Params()
		{
			var script = "return UnityEngine.Vector4(1,2,3)";
			var retvals = await DoStringAsync(script, nameof(Lua_newVector4_3Params));
			Assert.That(retvals[0].Read<LuaVector4>().Value, Is.EqualTo(new Vector4(1, 2, 3)));
		}

		[Test] public async Task Lua_newVector4_4Params()
		{
			var script = "return UnityEngine.Vector4(1,2,3,4)";
			var retvals = await DoStringAsync(script, nameof(Lua_newVector4_4Params));
			Assert.That(retvals[0].Read<LuaVector4>().Value, Is.EqualTo(new Vector4(1, 2, 3, 4)));
		}

		[Test] public async Task Lua_IndexerGet_ReturnsCorrectValues()
		{
			var script = "local v3 = Vector3(1, 2, 3); return v3[0], v3[1], v3[2];";
			var retvals = await DoStringAsync(script, nameof(Lua_IndexerGet_ReturnsCorrectValues));

			Assert.That(retvals[0].Read<Single>(), Is.EqualTo(1));
			Assert.That(retvals[1].Read<Single>(), Is.EqualTo(2));
			Assert.That(retvals[2].Read<Single>(), Is.EqualTo(3));
		}

		[Test] public async Task Lua_IndexerSet_ReturnsCorrectValues()
		{
			var script = "local v3 = Vector3(); v3[0] = 1; v3[1] = 2; v3[2] = 3; return v3;";
			var retvals = await DoStringAsync(script, nameof(Lua_IndexerSet_ReturnsCorrectValues));

			Assert.That(retvals[0].Read<LuaVector3>().Value, Is.EqualTo(new Vector3(1, 2, 3)));
		}
	}
}
