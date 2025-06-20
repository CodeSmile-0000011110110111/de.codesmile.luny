// Copyright (C) 2021-2025 Steffen Itterheim
// Refer to included LICENSE file for terms and conditions.

using Lua;
using System;
using System.Threading.Tasks;
using UnityEditor;
using UnityEngine;

namespace CodeSmile.Luny
{
	public class LunyScript : MonoBehaviour
	{
		[SerializeField] private LunyRuntimeLuaAsset m_LuaAsset;
		[SerializeField] private Boolean m_UseModdingContext;

		private ILunyLua m_Lua;
		private LunyLuaScript m_LuaScript;
		private LunyEventHandler<ScriptLifecycleEvent> m_ScriptLifecycleEvent;
		private LunyReference m_LunyRef;
		private Boolean m_IsLunyRefAssigned;

		private LunyReference LunyRef => m_IsLunyRefAssigned ? m_LunyRef : m_LunyRef = GetOrAddLunyReference();

		public static GameObject CreateLunyScriptObject() => new(nameof(LunyScript), typeof(LunyScript));

		private void Reset()
		{
			// TryAssignMatchingScriptAsset();
			// OnReset();
		}

		private async ValueTask Awake()
		{
			m_LunyRef = GetOrAddLunyReference();

			// for user override in subclass, to avoid having user call base.Awake (or forgetting to do so)
			OnAwake();

			m_Lua = m_UseModdingContext ? LunyRef.LunyRuntime.ModdingLua : LunyRef.LunyRuntime.RuntimeLua;
			m_LuaScript = new LunyLuaAssetScript(m_LuaAsset);
			m_LuaScript.OnScriptChanged -= OnScriptChanged;
			m_LuaScript.OnScriptChanged += OnScriptChanged;
			m_ScriptLifecycleEvent = m_LuaScript.EventHandler<ScriptLifecycleEvent>();

			await DoScriptAsync();
			OnBeforeScriptLoad(m_LuaScript.ScriptContext);
			m_ScriptLifecycleEvent.Send(m_Lua.State, (Int32)ScriptLifecycleEvent.Awake);
		}

		/// <summary>
		/// Must call base.OnEnable when overridden!
		/// </summary>
		protected virtual void OnEnable()
		{
			m_ScriptLifecycleEvent.Send(m_Lua.State, (Int32)ScriptLifecycleEvent.OnEnable);
			UpdateScriptRunnerEnabledState();
		}

		/// <summary>
		/// Must call base.OnDisable when overridden!
		/// </summary>
		protected virtual void OnDisable() => UpdateScriptRunnerEnabledState();

		/// <summary>
		/// Must call base.OnDestroy when overridden!
		/// </summary>
		protected virtual void OnDestroy() {}

		private void OnScriptChanged(LunyLuaScript script) => script.Reload(m_Lua.State);

		private async Task DoScriptAsync()
		{
			try
			{
				m_Lua.RemoveScript(m_LuaScript);
				await m_Lua.AddAndRunScript(m_LuaScript);
			}
			catch (Exception e)
			{
				LunyLogger.LogException(e);
				throw;
			}

			var runnerRegistry = gameObject.GetOrAddComponent<LunyScriptRunnerRegistry>();
			// if (runnerRegistry.DestroyScriptRunner(this))
			// 	await Awaitable.EndOfFrameAsync(); // must wait for actual destroy of LunyScriptRunner component
		}

		private LunyReference GetOrAddLunyReference()
		{
			m_IsLunyRefAssigned = true;
			return gameObject.GetOrAddComponent<LunyReference>();
		}

		/// <summary>
		/// Override this instead of Reset().
		/// </summary>
		protected virtual void OnReset() {}

		/// <summary>
		/// Override this instead of Awake().
		/// </summary>
		protected virtual void OnAwake() {}

		/// <summary>
		/// Override this to modify the script context table before the script gets loaded.
		/// </summary>
		/// <param name="scriptContext"></param>
		protected virtual void OnBeforeScriptLoad(LuaTable scriptContext) {}

		/// <summary>
		/// This gets called when there was any error loading and running the script.
		/// </summary>
		/// <remarks>Is not called when the supplied script was null or empty. In that case a warning log appears in the console.</remarks>
		protected virtual void OnRunScriptError() {}

		private void UpdateScriptRunnerEnabledState()
		{
			// if (TryGetScriptRunner(out var runner))
			// 	runner.enabled = enabled;
		}
	}
}
