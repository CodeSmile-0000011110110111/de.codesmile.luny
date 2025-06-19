// Copyright (C) 2021-2025 Steffen Itterheim
// Refer to included LICENSE file for terms and conditions.

using CodeSmile.Luny;
using System;
using System.Threading.Tasks;
using UnityEditor;
using UnityEngine;

namespace CodeSmileEditor.Luny
{
	internal sealed class LunyScriptableSingleton : ScriptableSingleton<LunyScriptableSingleton>
	{
		private readonly LunyLuaScriptCollection m_Scripts = new();
		private Boolean m_IsAlreadyDisabled;

		internal static LunyScriptableSingleton Singleton => instance; // for consistency

		// OnEnable runs after every domain reload (including project load)
		private void OnEnable()
		{
			var luaState = LunyEditor.Singleton.Lua.State;
			foreach (var script in m_Scripts)
			{
				var lifecycleEvent = script.EventHandler<LunyLifecycleEvent>();
				lifecycleEvent.Send(luaState, (Int32)LunyLifecycleEvent.OnEnable);
			}
		}

		// OnDisable runs before every domain reload
		private void OnDisable()
		{
			// may run twice (once by Unity before domain reload, the other due to calling DestroyImmediate)
			if (!m_IsAlreadyDisabled)
			{
				m_IsAlreadyDisabled = true;

				var luaState = LunyEditor.Singleton.Lua?.State;
				foreach (var script in m_Scripts)
				{
					var lifecycleEvent = script.EventHandler<LunyLifecycleEvent>();
					lifecycleEvent.Send(luaState, (Int32)LunyLifecycleEvent.OnDisable);
				}
			}
		}

		// OnDestroy runs before every domain reload, but only because LunyEditor actively calls DestroyImmediate!
		private void OnDestroy()
		{
			var luaState = LunyEditor.Singleton.Lua.State;
			foreach (var script in m_Scripts)
			{
				var lifecycleEvent = script.EventHandler<LunyLifecycleEvent>();
				lifecycleEvent.Send(luaState, (Int32)LunyLifecycleEvent.OnDestroy);
			}

			m_Scripts.Clear();
		}

		internal async ValueTask AddScript(LunyLuaScript script)
		{
			if (m_Scripts.Contains(script))
				throw new ArgumentException($"Script {script} already added");

			m_Scripts.Add(script);

			script.OnScriptChanged -= OnScriptChanged;
			script.OnScriptChanged += OnScriptChanged;

			// simulate the instantiation events
			var luaState = LunyEditor.Singleton.Lua.State;
			var lifecycleEvent = script.EventHandler<LunyLifecycleEvent>();
			lifecycleEvent.Send(luaState, (Int32)LunyLifecycleEvent.Reset);
			lifecycleEvent.Send(luaState, (Int32)LunyLifecycleEvent.Awake);
			lifecycleEvent.Send(luaState, (Int32)LunyLifecycleEvent.OnEnable);
		}

		private void OnScriptChanged(LunyLuaScript script)
		{
			// simulate domain reload events
			var luaState = LunyEditor.Singleton.Lua.State;
			var lifecycleEvent = script.EventHandler<LunyLifecycleEvent>();
			lifecycleEvent.Send(luaState, (Int32)LunyLifecycleEvent.OnEnable);
		}
	}
}
