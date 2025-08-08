// Copyright (C) 2021-2025 Steffen Itterheim
// Refer to included LICENSE file for terms and conditions.

using Lua;
using Luny.Core.UnityEngine;
using System;
using System.Collections;
using System.IO;
using System.Threading.Tasks;
using UnityEditor;
using UnityEngine;

namespace Luny
{
	[Flags]
	public enum LuaScriptEvents
	{
		// Animator? = 1 << 0,
		// Audio? = 1 << 1,
		// EditorOnly? = 1 << 2,
		Lifecycle = 1 << 3,
		// Particles? = 1 << 4,
		Physics2D = 1 << 5,
		Physics3D = 1 << 6,
		Rendering = 1 << 7,
		// TransformChange? = 1 << 8,
		// UGUI? = 1 << 9,
		// Update? = 1 << 10,
	}

	public class LunyScript : MonoBehaviour
	{
		[Tooltip("The script asset to run.")]
		[SerializeField] private LunyRuntimeLuaAsset m_LuaAsset;
		[Tooltip("Relative path to a Lua file located in StreamingAssets (with .lua extension) or Resources (no extension). " +
		         "Path must be relative to StreamingAssets/Resources ie it mustn't start with '/Assets/..'. " +
		         "Note: Resources scripts should be assigned to the LuaAsset field instead.")]
		[SerializeField] private String m_LuaFilePath;
		[Tooltip("Defines what kind of frequently raised events (Unity 'messages') the Lua script will receive. " +
		         "Disabling event categories that you do not use could improve performance.")]
		[SerializeField] private LuaScriptEvents m_ForwardedEventTypes = (LuaScriptEvents)(-1); // default to "Everything"

		[SerializeField] private SerializedLuaTable m_ScriptContext;

		private ILunyLua m_Lua;
		private LunyReference m_LunyRef;
		private LunyLuaScript m_LuaScript;
		private Boolean m_IsLunyRefAssigned;
		public LuaScriptEvents ForwardedEventTypes => m_ForwardedEventTypes;

		private LunyReference LunyRef => m_IsLunyRefAssigned ? m_LunyRef : m_LunyRef = GetOrAddLunyReference();
		public ILunyLua Lua => m_Lua;

		public static UnityEngine.GameObject CreateLunyScriptObject() => new(nameof(LunyScript), typeof(LunyScript));

		/// <summary>
		/// Must call base.OnValidate() when overridden!
		/// </summary>
		protected virtual void OnValidate()
		{
			m_ForwardedEventTypes |= LuaScriptEvents.Lifecycle;

			// LuaAsset and FilePath are mutually exclusive
			if (m_LuaFilePath?.Length > 0)
				m_LuaAsset = null;
			else if (m_LuaAsset == null)
				Helper.TryAssignMatchingScriptAsset(this);

			if (TryGetAssociatedScriptRunner(out var runner))
				runner.OnValidate();
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
			// Awake runs even if the component is disabled
			if (enabled)
				AssignReferencesAndLoadScript();
		}

		/// <summary>
		/// Must call base.OnEnable() when overridden!
		/// </summary>
		protected virtual void OnEnable()
		{
			// for cases where LunyScript component was initially disabled
			if (m_Lua == null)
				AssignReferencesAndLoadScript();

			UpdateScriptRunnerEnabledState();
		}

		/// <summary>
		/// Must call base.OnDisable() when overridden!
		/// </summary>
		protected virtual void OnDisable() => UpdateScriptRunnerEnabledState();

		/// <summary>
		/// Must call base.OnDestroy() when overridden!
		/// </summary>
		protected virtual void OnDestroy() =>
			// Lua may already be null when changing scenes / exiting playmode because LunyRuntime gets destroyed first
			m_Lua?.RemoveScript(m_LuaScript);

		private async void AssignReferencesAndLoadScript()
		{
			m_Lua = GetModdingOrRuntimeLuaInstance();
			m_LunyRef = GetOrAddLunyReference();
			m_LuaScript = CreateLuaScriptInstance();
			gameObject.GetOrAddComponent<LunyScriptCoordinator>();

			OnBeforeFirstScriptLoad(m_LuaScript.ScriptContext);
			await DoScriptAsync();
		}

		private ILunyLua GetModdingOrRuntimeLuaInstance() => m_LuaAsset is LunyModdingLuaAsset
			? LunyRuntime.Singleton.ModdingLua
			: LunyRuntime.Singleton.Lua;

		private LunyReference GetOrAddLunyReference()
		{
			m_IsLunyRefAssigned = true;
			return gameObject.GetOrAddComponent<LunyReference>();
		}

		private LunyLuaScript CreateLuaScriptInstance()
		{
			LunyLuaScript luaScript;

			Debug.Log($"Create script with context: {m_ScriptContext.Table.GetHashCode()}");
			foreach (var context in m_ScriptContext.Table)
				Debug.Log($"\t{context.Key} = {context.Value}");

			if (m_LuaAsset != null)
				luaScript = new LunyLuaAssetScript(m_LuaAsset, m_ScriptContext.Table);
			else if (m_LuaFilePath != null)
			{
				if (Path.HasExtension(m_LuaFilePath))
					luaScript = new LunyLuaStreamingAssetsScript(m_LuaFilePath, m_ScriptContext.Table);
				else
					luaScript = new LunyLuaResourcesScript(m_LuaFilePath, m_ScriptContext.Table);

				Debug.Assert(luaScript != null, nameof(luaScript) + $" failed to read: {m_LuaFilePath}");
			}
			else
				throw new MissingReferenceException($"{nameof(LunyScript)}: neither {nameof(m_LuaAsset)} nor {nameof(m_LuaFilePath)} is assigned");

			m_Lua.AddScript(luaScript);
			luaScript.OnScriptChanged -= OnScriptChanged;
			luaScript.OnScriptChanged += OnScriptChanged;
			return luaScript;
		}

		private void OnScriptChanged(LunyLuaScript script)
		{
			Debug.Assert(script == m_LuaScript);
			Debug.Log($"Script changed: {script}");
			StartCoroutine(DeferredScriptReload());
		}

		private IEnumerator DeferredScriptReload()
		{
			yield return new WaitForEndOfFrame();

			var reloadEvent = m_LuaScript.EventHandler<ScriptLoadEvent>();
			reloadEvent.Send(m_Lua.State, (Int32)ScriptLoadEvent.OnWillReloadScript);

			var task = DoScriptAsync().Preserve();
			yield return new WaitUntil(() => task.IsCompleted);
		}

		private async ValueTask DoScriptAsync()
		{
			try
			{
				OnBeforeScriptLoad(m_LuaScript.ScriptContext);

				var isReloading = TryGetAssociatedScriptRunner(out var runner);
				if (isReloading)
					runner.OnWillReload();

				await m_Lua.RunScript(m_LuaScript);

				OnAfterScriptLoad(m_LuaScript.ScriptContext);

				if (isReloading == false)
					GetComponent<LunyScriptCoordinator>().AddScriptRunner(this, m_LuaScript);
			}
			catch (Exception e)
			{
				LuaLogger.LogError($"Error in {m_LuaScript}: {e.Message}");
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
				// try to assign a Lua script of the same name in the same folder
				var monoScript = MonoScript.FromMonoBehaviour(instance);
				var scriptPath = AssetDatabase.GetAssetPath(monoScript);
				scriptPath = Path.ChangeExtension(scriptPath, ".lua");
				instance.m_LuaAsset = AssetDatabase.LoadAssetAtPath<LunyRuntimeLuaAsset>(scriptPath);
#endif
			}
		}
	}
}
