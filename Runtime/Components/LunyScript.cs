// Copyright (C) 2021-2025 Steffen Itterheim
// Refer to included LICENSE file for terms and conditions.

using Lua;
using System;
using System.IO;
using System.Threading.Tasks;
using UnityEditor;
using UnityEngine;

namespace CodeSmile.Luny
{
	[Flags]
	public enum LuaScriptEvents
	{
		Lifecycle = 1 << 0,
		// Update?
		Physics2D = 1 << 3,
		Physics3D = 1 << 4,
		Rendering = 1 << 8,
	}

	public class LunyScript : MonoBehaviour
	{
		[SerializeField] private LunyRuntimeLuaAsset m_LuaAsset;
		[SerializeField] private LuaScriptEvents m_LuaScriptEvents = (LuaScriptEvents)(-1); // default to "Everything"
		[SerializeField] private Boolean m_UseModdingContext;

		private ILunyLua m_Lua;
		private LunyReference m_LunyRef;
		private LunyLuaScript m_LuaScript;
		private Boolean m_IsLunyRefAssigned;
		public LuaScriptEvents LuaScriptEvents => m_LuaScriptEvents;

		private LunyReference LunyRef => m_IsLunyRefAssigned ? m_LunyRef : m_LunyRef = GetOrAddLunyReference();
		public ILunyLua Lua => m_Lua;

		public static GameObject CreateLunyScriptObject() => new(nameof(LunyScript), typeof(LunyScript));

		/// <summary>
		/// Must call base.Reset() when overridden!
		/// </summary>
		protected virtual void Reset() => Helper.TryAssignMatchingScriptAsset(this);

		/// <summary>
		/// Must call base.OnValidate() when overridden!
		/// </summary>
		protected virtual void OnValidate()
		{
			m_LuaScriptEvents |= LuaScriptEvents.Lifecycle;
		}

		/// <summary>
		/// Must call base.Awake() when overridden!
		/// </summary>
		/// <remarks>Prefer to override OnBeforeFirstScriptLoad(..) for once-only initialization!
		/// Before calling base.Awake() none of the required references are assigned, and after base.Awake() the Lua script
		/// will have already run its Awake() and OnEnable() functions.
		/// </remarks>
		protected virtual void Awake()
		{
			m_LunyRef = GetOrAddLunyReference();
			m_Lua = GetLuaReference();
			m_LuaScript = CreateLuaScriptInstance();

			OnBeforeFirstScriptLoad(m_LuaScript.ScriptContext);
			DoScriptAsync().Preserve().GetAwaiter().GetResult();
		}

		/// <summary>
		/// Must call base.OnEnable() when overridden!
		/// </summary>
		protected virtual void OnEnable() => UpdateScriptRunnerEnabledState();

		/// <summary>
		/// Must call base.OnDisable() when overridden!
		/// </summary>
		protected virtual void OnDisable() => UpdateScriptRunnerEnabledState();

		/// <summary>
		/// Must call base.OnDestroy() when overridden!
		/// </summary>
		protected virtual void OnDestroy() => m_Lua.RemoveScript(m_LuaScript);

		private LunyReference GetOrAddLunyReference()
		{
			m_IsLunyRefAssigned = true;
			return gameObject.GetOrAddComponent<LunyReference>();
		}

		private ILunyLua GetLuaReference()
		{
			var lua = m_UseModdingContext ? LunyRef.LunyRuntime.ModdingLua : LunyRef.LunyRuntime.RuntimeLua;
			return lua != null ? lua : throw new ArgumentNullException(nameof(lua));
		}

		private LunyLuaScript CreateLuaScriptInstance()
		{
			if (m_LuaAsset == null)
				throw new MissingReferenceException($"{nameof(m_LuaAsset)} is not assigned");

			var luaScript = new LunyLuaAssetScript(m_LuaAsset);
			m_Lua.AddScript(luaScript);
			luaScript.OnScriptChanged -= OnScriptChanged;
			luaScript.OnScriptChanged += OnScriptChanged;
			return luaScript;
		}

		private async ValueTask OnScriptChanged(LunyLuaScript script)
		{
			Debug.Assert(script == m_LuaScript);
			var reloadEvent = m_LuaScript.EventHandler<ScriptLoadEvent>();
			reloadEvent.Send(m_Lua.State, (Int32)ScriptLoadEvent.OnWillReloadScript);
			await DoScriptAsync();
			reloadEvent.Send(m_Lua.State, (Int32)ScriptLoadEvent.OnDidLoadScript);
		}

		private async ValueTask DoScriptAsync()
		{
			try
			{
				OnBeforeScriptLoad(m_LuaScript.ScriptContext);
				m_Lua.RunScript(m_LuaScript);
				OnAfterScriptLoad(m_LuaScript.ScriptContext);

				var coordinator = gameObject.GetOrAddComponent<LunyScriptCoordinator>();
				if (coordinator.DestroyScriptRunner(this))
					await Awaitable.EndOfFrameAsync(); // must wait for actual destroy of LunyScriptRunner component

				coordinator.AddScriptRunner(this, m_LuaScript);
			}
			catch (Exception e)
			{
				LunyLogger.LogError($"Error in {m_LuaScript}: {e.Message}");
				OnScriptLoadError();
			}
		}

		/// <summary>
		/// Override this to do once-only initialization before the first script load.
		/// </summary>
		/// <remarks>This runs during base.Awake(), after the LunyScript references have been assigned.</remarks>
		/// <param name="scriptContext"></param>
		protected virtual void OnBeforeFirstScriptLoad(LuaTable scriptContext) {}

		/// <summary>
		/// Override this to modify the script context table before the script gets (re-)loaded.
		/// </summary>
		/// <param name="scriptContext"></param>
		protected virtual void OnBeforeScriptLoad(LuaTable scriptContext) {}

		/// <summary>
		/// Override this to modify the script context table after the script was (re-)loaded.
		/// The script hasn't run its Awake() function yet at this point.
		/// </summary>
		/// <param name="scriptContext"></param>
		protected virtual void OnAfterScriptLoad(LuaTable scriptContext) {}

		/// <summary>
		/// This gets called when there was any error loading the script (eg syntax error).
		/// </summary>
		protected virtual void OnScriptLoadError() {}

		private void UpdateScriptRunnerEnabledState()
		{
			if (TryGetAssociatedScriptRunner(out var runner))
				runner.enabled = enabled;
		}

		internal Boolean TryGetAssociatedScriptRunner(out LunyScriptRunner runner)
		{
			runner = null;
			return gameObject.TryGetComponent(out LunyScriptCoordinator coordinator) &&
			       coordinator.TryGetScriptRunner(this, out runner);
		}

		private static class Helper
		{
			internal static void TryAssignMatchingScriptAsset(LunyScript instance)
			{
#if UNITY_EDITOR
				if (instance.m_LuaAsset == null)
				{
					// try to assign a Lua script of the same name in the same folder
					var monoScript = MonoScript.FromMonoBehaviour(instance);
					var scriptPath = AssetDatabase.GetAssetPath(monoScript);
					scriptPath = Path.ChangeExtension(scriptPath, ".lua");
					instance.m_LuaAsset = AssetDatabase.LoadAssetAtPath<LunyRuntimeLuaAsset>(scriptPath);
				}
#endif
			}
		}
	}
}
