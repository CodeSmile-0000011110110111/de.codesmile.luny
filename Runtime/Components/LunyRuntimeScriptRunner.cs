// Copyright (C) 2021-2025 Steffen Itterheim
// Refer to included LICENSE file for terms and conditions.

using Lua;
using System;
using UnityEditor;
using UnityEngine;

namespace Luny
{
	/// <summary>
	///     Internal use only: Forwards Unity messages (eg Awake, Update, ..) to Lua script.
	/// </summary>
	/// <remarks>
	/// The LunyScriptRunner is a separate component to ensure the same execution order of messages. To achieve that,
	/// a LunyScriptRunner is removed and added again every time a Luny script is added or has been changed at runtime.
	/// Doing so guarantees that the Awake message is not 'missed' (runs instantly when calling AddComponent) and that
	/// OnDestroy runs before dependent components have been destroyed.
	/// </remarks>
	[AddComponentMenu("GameObject/")] // Do not list in "Add Component" menu
	internal sealed class LunyRuntimeScriptRunner : MonoBehaviour
	{
		private static readonly LuaValue[] OneArg = new LuaValue[1];

		private ILunyLua m_Lua;
		private LunyLuaScript m_LuaScript;

		// using fields to avoid frequent lookups in the eventhandler collection
		private LunyScriptEventHandler<MonoBehaviourLifecycleEvent> m_LifecycleEvents;
		private LunyScriptEventHandler<MonoBehaviourPhysics2DEvent> m_Physics2DEvents;
		private LunyScriptEventHandler<MonoBehaviourPhysicsEvent> m_Physics3DEvents;
		private LunyScriptEventHandler<MonoBehaviourRenderEvent> m_RenderEvents;

		private Boolean m_Physics2DEventsEnabled;
		private Boolean m_Physics3DEventsEnabled;
		private Boolean m_RenderEventsEnabled;
		private Boolean m_DestroyDidCallOnDisable;
		private Boolean m_DestroyDidCallOnDestroy;

		private LunyScriptEventHandler<MonoBehaviourPhysics2DEvent> Physics2DEvents => m_Physics2DEventsEnabled == false
			? null
			: m_Physics2DEvents != null
				? m_Physics2DEvents
				: m_Physics2DEvents = m_LuaScript.TryGetOrCreateEventHandler<MonoBehaviourPhysics2DEvent>();
		private LunyScriptEventHandler<MonoBehaviourPhysicsEvent> Physics3DEvents => m_Physics3DEventsEnabled == false
			? null
			: m_Physics3DEvents != null
				? m_Physics3DEvents
				: m_Physics3DEvents = m_LuaScript.TryGetOrCreateEventHandler<MonoBehaviourPhysicsEvent>();
		private LunyScriptEventHandler<MonoBehaviourRenderEvent> RenderEvents => m_RenderEventsEnabled == false
			? null
			: m_RenderEvents != null
				? m_RenderEvents
				: m_RenderEvents = m_LuaScript.TryGetOrCreateEventHandler<MonoBehaviourRenderEvent>();

		private void Awake()
		{
			hideFlags = HideFlags.HideAndDontSave | HideFlags.HideInInspector;

			var coordinator = GetComponent<LunyRuntimeScriptCoordinator>();
			var initRefs = coordinator.RunnerInitOnlyReferences;
			m_Lua = initRefs.Lua;
			m_LuaScript = initRefs.LuaScript;
			m_LifecycleEvents = m_LuaScript.TryGetOrCreateEventHandler<MonoBehaviourLifecycleEvent>();
			m_Physics2DEventsEnabled = (initRefs.LunyScript.ForwardedEventTypes & LuaScriptEvents.Physics2D) != 0;
			m_Physics3DEventsEnabled = (initRefs.LunyScript.ForwardedEventTypes & LuaScriptEvents.Physics3D) != 0;
			m_RenderEventsEnabled = (initRefs.LunyScript.ForwardedEventTypes & LuaScriptEvents.Rendering) != 0;
		}

		private void OnEnable()
		{
			// when component is being added, the coordinator will call Awake and OnEnable on our behalf
			var coordinator = GetComponent<LunyRuntimeScriptCoordinator>();
			if (coordinator.RunnerInitOnlyReferences.IsValid)
				return;

			m_LifecycleEvents.TrySend(m_Lua.State, (Int32)MonoBehaviourLifecycleEvent.OnEnable);
		}

		private void Start() => m_LifecycleEvents.TrySend(m_Lua.State, (Int32)MonoBehaviourLifecycleEvent.Start);

		private void OnDisable() => SendOnDisable();

		private void OnDestroy()
		{
			SendOnDestroy();
			// StopAllLuaCoroutines();
			// StopAllCoroutines();

			m_Lua = null;
			m_LuaScript = null;
			m_LifecycleEvents = null;
		}

		// Update events
		private void FixedUpdate() => m_LifecycleEvents.TrySend(m_Lua.State, (Int32)MonoBehaviourLifecycleEvent.FixedUpdate);
		private void Update() => m_LifecycleEvents.TrySend(m_Lua.State, (Int32)MonoBehaviourLifecycleEvent.Update);
		private void LateUpdate() => m_LifecycleEvents.TrySend(m_Lua.State, (Int32)MonoBehaviourLifecycleEvent.LateUpdate);

		// Editor-only events
		internal void OnValidate() =>
			m_LuaScript.TrySendEvent<MonoBehaviourEditorEvent>(m_Lua.State, (Int32)MonoBehaviourEditorEvent.OnValidate);

		private void OnDrawGizmos() =>
			m_LuaScript.TrySendEvent<MonoBehaviourEditorEvent>(m_Lua.State, (Int32)MonoBehaviourEditorEvent.OnDrawGizmos);

		private void OnDrawGizmosSelected() =>
			m_LuaScript.TrySendEvent<MonoBehaviourEditorEvent>(m_Lua.State, (Int32)MonoBehaviourEditorEvent.OnDrawGizmosSelected);

		// Application events
		private void OnApplicationQuit() =>
			m_LuaScript.TrySendEvent<MonoBehaviourApplicationEvent>(m_Lua.State, (Int32)MonoBehaviourApplicationEvent.OnApplicationQuit);

		private void OnApplicationFocus(Boolean hasFocus)
		{
			OneArg[0] = hasFocus;
			m_LuaScript.TrySendEvent<MonoBehaviourApplicationEvent>(m_Lua.State, (Int32)MonoBehaviourApplicationEvent.OnApplicationFocus,
				OneArg);
		}

		private void OnApplicationPause(Boolean isPaused)
		{
			OneArg[0] = isPaused;
			m_LuaScript.TrySendEvent<MonoBehaviourApplicationEvent>(m_Lua.State, (Int32)MonoBehaviourApplicationEvent.OnApplicationPause,
				OneArg);
		}

		// Rendering events
		private void OnBecameInvisible() => RenderEvents?.TrySend(m_Lua.State, (Int32)MonoBehaviourRenderEvent.OnBecameInvisible);
		private void OnBecameVisible() => RenderEvents?.TrySend(m_Lua.State, (Int32)MonoBehaviourRenderEvent.OnBecameVisible);
		private void OnPreCull() => RenderEvents?.TrySend(m_Lua.State, (Int32)MonoBehaviourRenderEvent.OnPreCull);
		private void OnPreRender() => RenderEvents?.TrySend(m_Lua.State, (Int32)MonoBehaviourRenderEvent.OnPreRender);
		private void OnWillRenderObject() => RenderEvents?.TrySend(m_Lua.State, (Int32)MonoBehaviourRenderEvent.OnWillRenderObject);
		private void OnRenderObject() => RenderEvents?.TrySend(m_Lua.State, (Int32)MonoBehaviourRenderEvent.OnRenderObject);
		private void OnPostRender() => RenderEvents?.TrySend(m_Lua.State, (Int32)MonoBehaviourRenderEvent.OnPostRender);

		// 2D Physics events
		private void OnJointBreak2D(Joint2D brokenJoint)
		{
			OneArg[0] = "ArgumentNotImplemented";
			Physics2DEvents?.TrySend(m_Lua.State, (Int32)MonoBehaviourPhysics2DEvent.OnJointBreak2D, OneArg);
		}

		private void OnCollisionEnter2D(Collision2D other)
		{
			OneArg[0] = "ArgumentNotImplemented";
			Physics2DEvents?.TrySend(m_Lua.State, (Int32)MonoBehaviourPhysics2DEvent.OnCollisionEnter2D, OneArg);
		}

		private void OnCollisionExit2D(Collision2D other)
		{
			OneArg[0] = "ArgumentNotImplemented";
			Physics2DEvents?.TrySend(m_Lua.State, (Int32)MonoBehaviourPhysics2DEvent.OnCollisionExit2D, OneArg);
		}

		private void OnCollisionStay2D(Collision2D other)
		{
			OneArg[0] = "ArgumentNotImplemented";
			Physics2DEvents?.TrySend(m_Lua.State, (Int32)MonoBehaviourPhysics2DEvent.OnCollisionStay2D, OneArg);
		}

		private void OnTriggerEnter2D(Collider2D other)
		{
			OneArg[0] = "ArgumentNotImplemented";
			Physics2DEvents?.TrySend(m_Lua.State, (Int32)MonoBehaviourPhysics2DEvent.OnTriggerEnter2D, OneArg);
		}

		private void OnTriggerExit2D(Collider2D other)
		{
			OneArg[0] = "ArgumentNotImplemented";
			Physics2DEvents?.TrySend(m_Lua.State, (Int32)MonoBehaviourPhysics2DEvent.OnTriggerExit2D, OneArg);
		}

		private void OnTriggerStay2D(Collider2D other)
		{
			OneArg[0] = "ArgumentNotImplemented";
			Physics2DEvents?.TrySend(m_Lua.State, (Int32)MonoBehaviourPhysics2DEvent.OnTriggerStay2D, OneArg);
		}

		// 3D Physics events
		private void OnJointBreak(Single breakForce)
		{
			OneArg[0] = breakForce;
			Physics3DEvents?.TrySend(m_Lua.State, (Int32)MonoBehaviourPhysicsEvent.OnJointBreak, OneArg);
		}

		private void OnCollisionEnter(Collision other)
		{
			OneArg[0] = "ArgumentNotImplemented";
			Physics3DEvents?.TrySend(m_Lua.State, (Int32)MonoBehaviourPhysicsEvent.OnCollisionEnter, OneArg);
		}

		private void OnCollisionExit(Collision other)
		{
			OneArg[0] = "ArgumentNotImplemented";
			Physics3DEvents?.TrySend(m_Lua.State, (Int32)MonoBehaviourPhysicsEvent.OnCollisionExit, OneArg);
		}

		private void OnCollisionStay(Collision other)
		{
			OneArg[0] = "ArgumentNotImplemented";
			Physics3DEvents?.TrySend(m_Lua.State, (Int32)MonoBehaviourPhysicsEvent.OnCollisionStay, OneArg);
		}

		private void OnTriggerEnter(Collider other)
		{
			OneArg[0] = "ArgumentNotImplemented";
			Physics3DEvents?.TrySend(m_Lua.State, (Int32)MonoBehaviourPhysicsEvent.OnTriggerEnter, OneArg);
		}

		private void OnTriggerExit(Collider other)
		{
			OneArg[0] = "ArgumentNotImplemented";
			Physics3DEvents?.TrySend(m_Lua.State, (Int32)MonoBehaviourPhysicsEvent.OnTriggerExit, OneArg);
		}

		private void OnTriggerStay(Collider other)
		{
			OneArg[0] = "ArgumentNotImplemented";
			Physics3DEvents?.TrySend(m_Lua.State, (Int32)MonoBehaviourPhysicsEvent.OnTriggerStay, OneArg);
		}

		private void OnControllerColliderHit(ControllerColliderHit hit)
		{
			OneArg[0] = "ArgumentNotImplemented";
			Physics3DEvents?.TrySend(m_Lua.State, (Int32)MonoBehaviourPhysicsEvent.OnControllerColliderHit, OneArg);
		}

		// Transform events
		private void OnBeforeTransformParentChanged() => m_LuaScript.TrySendEvent<MonoBehaviourTransformEvent>(m_Lua.State,
			(Int32)MonoBehaviourTransformEvent.OnBeforeTransformParentChanged);

		private void OnTransformChildrenChanged() =>
			m_LuaScript.TrySendEvent<MonoBehaviourTransformEvent>(m_Lua.State, (Int32)MonoBehaviourTransformEvent.OnTransformChildrenChanged);

		private void OnTransformParentChanged() =>
			m_LuaScript.TrySendEvent<MonoBehaviourTransformEvent>(m_Lua.State, (Int32)MonoBehaviourTransformEvent.OnTransformParentChanged);

		public void OnWillReload() {}

		public void OnBeforeDestroy()
		{
			SendOnDisable();
			SendOnDestroy();
			StopAllCoroutines();
		}

		internal void SendAwakeAndOnEnable()
		{
			m_LifecycleEvents.TrySend(m_Lua.State, (Int32)MonoBehaviourLifecycleEvent.Awake);
			m_LifecycleEvents.TrySend(m_Lua.State, (Int32)MonoBehaviourLifecycleEvent.OnEnable);
		}

		private void SendOnDisable()
		{
			if (m_DestroyDidCallOnDisable)
				return;

			m_DestroyDidCallOnDisable = true;
			m_LifecycleEvents.TrySend(m_Lua.State, (Int32)MonoBehaviourLifecycleEvent.OnDisable);
		}

		private void SendOnDestroy()
		{
			if (m_DestroyDidCallOnDestroy)
				return;

			m_DestroyDidCallOnDestroy = true;
			m_LifecycleEvents.TrySend(m_Lua.State, (Int32)MonoBehaviourLifecycleEvent.OnDestroy);
		}
	}
}
