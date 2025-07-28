using CodeSmile.Luny;
using Lua_UnityEngine.CoreModule;
using Lua.Unity;
using System.Collections;
using NUnit.Framework;
using System.Threading.Tasks;
using UnityEngine;
using UnityEngine.Scripting;
using UnityEngine.TestTools;

public class MinimalTestScript
{
    //[Preserve]
    [SetUp] public void SetUp()
    {
        Debug.Log("MINIMAL Test SetUp runs ...");
    }
    //[Preserve]
    [TearDown] public void TearDown()
    {
        Debug.Log("MINIMAL Test TearDown runs ...");
    }
    [Test] public async Task RuntimeLua_ReturnsValue()
    {
        var lua = LunyRuntime.Singleton.RuntimeLua;
        var result = await lua.State.DoStringAsync("return -1", nameof(RuntimeLua_ReturnsValue), null);

        Assert.That(result, Is.Not.Null);
        Assert.That(result.Length, Is.GreaterThan(0));
        Assert.That(result[0].ReadInt(), Is.EqualTo(-1));
    }

    [Test] public async Task RuntimeLua_newVector4()
    {
        var testName = nameof(RuntimeLua_ReturnsValue);
        var state = LunyRuntime.Singleton.RuntimeLua.State;
        var retvals = await state.DoStringAsync("return UnityEngine.Vector4.new(1,2,3,4)", testName, null);

        Assert.That(retvals, Is.Not.Null);
        Assert.That(retvals.Length, Is.GreaterThan(0));
        Assert.That(retvals[0].ReadUserData() is Lua_UnityEngine_Vector4);
        Assert.That(retvals[0].Read<Lua_UnityEngine_Vector4>().Value, Is.EqualTo(new Vector4(1, 2, 3, 4)));

        Debug.Log(retvals[0].Read<Lua_UnityEngine_Vector4>());
    }

    [UnityTest] public IEnumerator NewTestScriptWithEnumeratorPasses()
    {
        yield return null;
    }
}
