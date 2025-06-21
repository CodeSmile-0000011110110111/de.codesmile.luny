// Copyright (C) 2021-2025 Steffen Itterheim
// Refer to included LICENSE file for terms and conditions.

using System;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

namespace CodeSmile.Luny
{
	/// <summary>
	/// Internal use only: Associates each LunyScriptRunner with its LunyScript instance.
	/// </summary>
	/// <remarks>
	/// Since there can be multiple LunyScript components on a single GameObject, an association must be maintained between
	/// LunyScript and its assigned LunyScriptRunner. This class ensures this association and lookup.
	/// In addition, this component is also responsible for instantiating the runners while dealing with some quirks around
	/// the fact that calling AddComponent(LunyScriptRunner) will instantly run that component's Awake method.
	/// </remarks>
	[AddComponentMenu("GameObject/")] // Do not list in "Add Component" menu
	[DisallowMultipleComponent]
	internal sealed class LunyScriptCoordinator : MonoBehaviour
	{
		private readonly Dictionary<Int32, LunyScriptRunner> m_Runners = new();

		internal InitReferences RunnerInitOnlyReferences { get; private set; }

		private void Awake() => hideFlags = HideFlags.HideAndDontSave | HideFlags.HideInInspector;

		private void OnDestroy() => m_Runners.Clear();

		internal void AddScriptRunner(LunyScript lunyScript, LunyLuaScript luaScript)
		{
			var scriptIndex = lunyScript.GetComponentIndex();
			Debug.Assert(!m_Runners.ContainsKey(scriptIndex), $"{gameObject}: LunyScript[{scriptIndex}] runner exists!");

			// since Awake runs immediately, provide reference for grabs in runner's Awake via a short-lived property
			RunnerInitOnlyReferences = new InitReferences
				{ IsValid = true, LunyScript = lunyScript, LuaScript = luaScript, Lua = lunyScript.Lua };
			var runner = gameObject.AddComponent<LunyScriptRunner>();
			m_Runners.Add(scriptIndex, runner);
			RunnerInitOnlyReferences = default;

			// 'postcreationally' send Awake and OnEnable to the script
			runner.SendAwakeAndOnEnable();
		}

		public Boolean TryGetScriptRunner(LunyScript lunyScript, out LunyScriptRunner runner) =>
			m_Runners.TryGetValue(lunyScript.GetComponentIndex(), out runner);

		internal Boolean DestroyScriptRunner(LunyScript lunyScript)
		{
			if (TryGetScriptRunner(lunyScript, out var runner) == false)
				return false;

			runner.OnWillReload();
			runner.DestroyInAnyMode();
			return true;
		}

		public void InvokeAllRunnersOnBeforeDestroy()
		{
			foreach (var runner in m_Runners.Values)
				runner.OnBeforeDestroy();
		}

		internal struct InitReferences
		{
			public LunyScript LunyScript;
			public LunyLuaScript LuaScript;
			public ILunyLua Lua;
			public Boolean IsValid;
		}
	}
}
