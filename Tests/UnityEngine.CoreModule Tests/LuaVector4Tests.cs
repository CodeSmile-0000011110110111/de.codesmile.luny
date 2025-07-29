using CodeSmile.Luny;
using Lua_UnityEngine.CoreModule;
using Lua.Unity;
using NUnit.Framework;
using System.Threading.Tasks;
using UnityEditor;
using UnityEngine;

public class LuaVector4Tests
{
	//[SetUp] public void SetUp() => Debug.Log("MINIMAL Test SetUp runs ...");
	//[TearDown] public void TearDown() => Debug.Log("MINIMAL Test TearDown runs ...");

	[Test] public async Task Lua_newVector4_0Params()
	{
		var script = "return UnityEngine.Vector4.new()";
		var retvals = await LunyRuntime.Singleton.RuntimeLua.State.DoStringAsync(script, nameof(Lua_newVector4_0Params), null);
		Assert.That(retvals[0].Read<Lua_UnityEngine_Vector4>().Value, Is.EqualTo(new Vector4()));
	}

	[Test] public async Task Lua_newVector4_2Params()
	{
		var script = "return UnityEngine.Vector4.new(1,2)";
		var retvals = await LunyRuntime.Singleton.RuntimeLua.State.DoStringAsync(script, nameof(Lua_newVector4_2Params), null);
		Assert.That(retvals[0].Read<Lua_UnityEngine_Vector4>().Value, Is.EqualTo(new Vector4(1, 2)));
	}

	[Test] public async Task Lua_newVector4_3Params()
	{
		var script = "return UnityEngine.Vector4.new(1,2,3)";
		var retvals = await LunyRuntime.Singleton.RuntimeLua.State.DoStringAsync(script, nameof(Lua_newVector4_3Params), null);
		Assert.That(retvals[0].Read<Lua_UnityEngine_Vector4>().Value, Is.EqualTo(new Vector4(1, 2, 3)));
	}

	[Test] public async Task Lua_newVector4_4Params()
	{
		var script = "return UnityEngine.Vector4.new(1,2,3,4)";
		var retvals = await LunyRuntime.Singleton.RuntimeLua.State.DoStringAsync(script, nameof(Lua_newVector4_4Params), null);
		Assert.That(retvals[0].Read<Lua_UnityEngine_Vector4>().Value, Is.EqualTo(new Vector4(1, 2, 3, 4)));
	}
}
