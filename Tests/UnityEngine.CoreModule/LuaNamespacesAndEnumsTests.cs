// Copyright (C) 2021-2025 Steffen Itterheim
// Refer to included LICENSE file for terms and conditions.

using Lua;
using Luny;
using Luny.UnityEngine;
using NUnit.Framework;
using System.Threading.Tasks;
using UnityEditor;
using UnityEngine;
using UnityEngine.Rendering;

namespace LunyTests.UnityEngineCoreModule
{
	public sealed class LuaNamespacesAndEnumsTests : LuaModuleTestsBase
	{
		[Test] public async Task LuaNamespace_ReturnANamespace_IsLuaNamespaceType()
		{
			var script = "return UnityEngine;";
			var retvals = await DoStringAsync(script, nameof(LuaNamespace_ReturnANamespace_IsLuaNamespaceType));

			Assert.That(retvals[0].TryRead<LuaNamespace>(out var _));
			Assert.That(retvals[0].Read<LuaNamespace>().Name, Is.EqualTo(nameof(UnityEngine)));
		}

		[Test] public async Task LuaEnum_ReturnEnum_IsLuaTableType()
		{
			var script = "return ApplicationInstallMode";
			var retvals = await DoStringAsync(script, nameof(LuaEnum_ReturnEnum_IsLuaTableType));

			Assert.That(retvals[0].TryRead<LuaTable>(out var _));
		}

		[Test] public async Task LuaEnum_ReturnEnumValue_CorrectValue()
		{
			var script = "return ApplicationInstallMode.DeveloperBuild;";
			var retvals = await DoStringAsync(script, nameof(LuaEnum_ReturnEnumValue_CorrectValue));

			Assert.That(retvals[0].Read<ApplicationInstallMode>(), Is.EqualTo(ApplicationInstallMode.DeveloperBuild));
		}

		[Test] public async Task LuaEnum_AsParameter_CorrectResult()
		{
			var script = "return GameObject.CreatePrimitive(PrimitiveType.Cube), GameObject.CreatePrimitive(PrimitiveType.Sphere);";
			var retvals = await DoStringAsync(script, nameof(LuaEnum_AsParameter_CorrectResult));

			Assert.That(retvals[0].TryRead(out LuaGameObject _), Is.True);
			Assert.That(retvals[0].Read<LuaGameObject>().Instance.GetComponent<MeshFilter>().sharedMesh.name, Is.EqualTo("Cube"));
			Assert.That(retvals[1].TryRead(out LuaGameObject _), Is.True);
			Assert.That(retvals[1].Read<LuaGameObject>().Instance.GetComponent<MeshFilter>().sharedMesh.name, Is.EqualTo("Sphere"));
		}

		[Test] public async Task LuaEnum_AsReturnValue_CorrectResult()
		{
			var script = "return GraphicsSettings.GetShaderMode(BuiltinShaderType.DeferredShading);";
			var retvals = await DoStringAsync(script, nameof(LuaEnum_AsReturnValue_CorrectResult));

			Assert.That(retvals[0].Read<BuiltinShaderMode>(), Is.EqualTo(GraphicsSettings.GetShaderMode(BuiltinShaderType.DeferredShading)));
		}

	}
}
