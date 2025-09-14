// Copyright (C) 2021-2025 Steffen Itterheim
// Refer to included LICENSE file for terms and conditions.

using Lua;
using Luny.Core;
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

	public class LunyRuntimeScript : MonoBehaviour
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

		[SerializeField] private SerializedLuaTable m_ScriptContext = new();

		private ILunyLua m_Lua;
		private LuaGameObjectReferences m_LuaGoRefs;
		private LunyLuaScript m_LuaScript;
		private Boolean m_IsLuaGoRefsAssigned;
		private Boolean m_IsHotReloading;

		public LuaScriptEvents ForwardedEventTypes => m_ForwardedEventTypes;

		private LuaGameObjectReferences LuaGoRefs =>
			m_IsLuaGoRefsAssigned ? m_LuaGoRefs : m_LuaGoRefs = GetOrAddLuaGameObjectReferencesComponent();
		public ILunyLua Lua => m_Lua;

		public static GameObject CreateLunyScriptObject() => new(nameof(LunyRuntimeScript), typeof(LunyRuntimeScript));

		/// <summary>
		/// Must call base.OnValidate() when overridden!
		/// </summary>
		protected virtual void OnValidate()
		{
			// Debug.Log("--------- Serialized Script Context dump ---------");
			// foreach (var pair in m_ScriptContext.Table)
			// 	Debug.Log($"{pair.Key}: {pair.Value}");

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
		protected virtual void OnDestroy()
		{
			// Lua may already be null when changing scenes / exiting playmode because LunyRuntime gets destroyed first
			m_Lua?.RemoveScript(m_LuaScript);

			m_IsLuaGoRefsAssigned = false;
			m_LuaGoRefs = null;
			m_LuaScript = null;
			m_Lua = null;
		}

		private async void AssignReferencesAndLoadScript()
		{
			m_Lua = GetModdingOrRuntimeLuaInstance();
			m_LuaGoRefs = GetOrAddLuaGameObjectReferencesComponent();

			m_LuaScript = CreateLuaScriptInstance();
			gameObject.GetOrAddComponent<LunyRuntimeScriptCoordinator>();

			OnBeforeInitialScriptLoad(m_LuaScript.ScriptContext);
			await DoScriptAsync();
		}

		private ILunyLua GetModdingOrRuntimeLuaInstance() => m_LuaAsset is LunyModdingLuaAsset
			? LunyRuntime.Singleton.ModdingLua
			: LunyRuntime.Singleton.Lua;

		private LuaGameObjectReferences GetOrAddLuaGameObjectReferencesComponent()
		{
			if (!m_IsLuaGoRefsAssigned)
			{
				m_IsLuaGoRefsAssigned = true;
				m_LuaGoRefs = gameObject.GetOrAddComponent<LuaGameObjectReferences>();
			}
			return m_LuaGoRefs;
		}

		private LunyLuaScript CreateLuaScriptInstance()
		{
			LunyLuaScript luaScript;

			// Debug.Log($"Create script with context: {m_ScriptContext.Table.GetHashCode()}");
			// foreach (var context in m_ScriptContext.Table)
			// 	Debug.Log($"\t{context.Key} = {context.Value}");

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
			{
				throw new MissingReferenceException(
					$"{nameof(LunyRuntimeScript)}: neither {nameof(m_LuaAsset)} nor {nameof(m_LuaFilePath)} is assigned");
			}

			m_Lua.AddScript(luaScript);
			luaScript.OnScriptChanged -= OnScriptChanged;
			luaScript.OnScriptChanged += OnScriptChanged;

			return luaScript;
		}

		private void OnScriptChanged(LunyLuaScript luaScript)
		{
			Debug.Assert(luaScript == m_LuaScript);
			Debug.Log($"{name} script changed: {luaScript} (active: {isActiveAndEnabled})");

			if (isActiveAndEnabled)
				StartCoroutine(DeferredScriptReload());
		}

		private IEnumerator DeferredScriptReload()
		{
			// don't interrupt the currently running frame
			yield return new WaitForEndOfFrame();

			// avoid hot reloading again in parallel just to be perfectly safe
			if (m_IsHotReloading)
				yield return new WaitUntil(() => !m_IsHotReloading);

			m_IsHotReloading = true;
			m_LuaScript.TrySendEvent<MonoBehaviourLifecycleEvent>(m_Lua.State, (Int32)MonoBehaviourLifecycleEvent.OnDisable);

			var task = DoScriptAsync().Preserve();
			yield return new WaitUntil(() => task.IsCompleted);

			m_LuaScript.TrySendEvent<MonoBehaviourLifecycleEvent>(m_Lua.State, (Int32)MonoBehaviourLifecycleEvent.OnEnable);
			m_IsHotReloading = false;
		}

		private async ValueTask DoScriptAsync()
		{
			try
			{
				var isReloading = TryGetAssociatedScriptRunner(out var runner);
				if (isReloading)
					runner.OnWillReload();

				m_LuaScript.SetRuntimeContextVariables(LuaGoRefs);

				await m_LuaScript.ReloadScript(m_Lua.State);

				if (!isReloading)
					GetComponent<LunyRuntimeScriptCoordinator>().AddScriptRunner(this, m_LuaScript);
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
		protected virtual void OnBeforeInitialScriptLoad(LuaTable scriptContext) {}

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

		internal Boolean TryGetAssociatedScriptRunner(out LunyRuntimeScriptRunner runner)
		{
			runner = null;
			return gameObject.TryGetComponent(out LunyRuntimeScriptCoordinator coordinator) &&
			       coordinator.TryGetScriptRunner(this, out runner);
		}

		private static class Helper
		{
			internal static void TryAssignMatchingScriptAsset(LunyRuntimeScript instance)
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
