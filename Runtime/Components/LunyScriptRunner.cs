// Copyright (C) 2021-2025 Steffen Itterheim
// Refer to included LICENSE file for terms and conditions.

using Lua;
using System;
using UnityEditor;
using UnityEngine;

namespace CodeSmile.Luny
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
	public sealed class LunyScriptRunner : MonoBehaviour
	{
		private static readonly LuaValue[] OneArg = new LuaValue[1];

		private ILunyLua m_Lua;
		private LunyLuaScript m_LuaScript;
		private LunyEventHandler<ScriptLifecycleEvent> m_LifecycleEvents;
		private LunyEventHandler<ScriptPhysics2DEvent> m_Physics2DEvents;
		private LunyEventHandler<ScriptPhysics3DEvent> m_Physics3DEvents;
		private LunyEventHandler<ScriptRenderingEvent> m_RenderEvents;

		private Boolean m_Physics2DEventsEnabled;
		private Boolean m_Physics3DEventsEnabled;
		private Boolean m_RenderEventsEnabled;
		private Boolean m_DestroyDidCallOnDisable;
		private Boolean m_DestroyDidCallOnDestroy;

		private LunyEventHandler<ScriptPhysics2DEvent> Physics2DEvents => m_Physics2DEventsEnabled && m_Physics2DEvents != null
			? m_Physics2DEvents
			: m_Physics2DEvents = m_LuaScript.EventHandler<ScriptPhysics2DEvent>();
		private LunyEventHandler<ScriptPhysics3DEvent> Physics3DEvents => m_Physics3DEventsEnabled && m_Physics3DEvents != null
			? m_Physics3DEvents
			: m_Physics3DEvents = m_LuaScript.EventHandler<ScriptPhysics3DEvent>();
		private LunyEventHandler<ScriptRenderingEvent> RenderEvents => m_RenderEventsEnabled && m_RenderEvents != null
			? m_RenderEvents
			: m_RenderEvents = m_LuaScript.EventHandler<ScriptRenderingEvent>();

		private void Awake()
		{
			hideFlags = HideFlags.HideAndDontSave | HideFlags.HideInInspector;

			var coordinator = GetComponent<LunyScriptCoordinator>();
			var initRefs = coordinator.RunnerInitOnlyReferences;
			m_Lua = initRefs.Lua;
			m_LuaScript = initRefs.LuaScript;
			m_LifecycleEvents = m_LuaScript.EventHandler<ScriptLifecycleEvent>();
			m_Physics2DEventsEnabled =(initRefs.LunyScript.LuaScriptEvents & LuaScriptEvents.Physics2D) != 0;
			m_Physics3DEventsEnabled =(initRefs.LunyScript.LuaScriptEvents & LuaScriptEvents.Physics3D) != 0;
			m_RenderEventsEnabled = (initRefs.LunyScript.LuaScriptEvents & LuaScriptEvents.Rendering) != 0;
		}

		private void OnEnable()
		{
			// when component is being added, the coordinator will call Awake and OnEnable on our behalf
			var coordinator = GetComponent<LunyScriptCoordinator>();
			if (coordinator.RunnerInitOnlyReferences.IsValid)
				return;

			m_LifecycleEvents.Send(m_Lua.State, (Int32)ScriptLifecycleEvent.OnEnable);
		}

		private void Start() => m_LifecycleEvents.Send(m_Lua.State, (Int32)ScriptLifecycleEvent.Start);

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

		private void FixedUpdate() => m_LifecycleEvents.Send(m_Lua.State, (Int32)ScriptLifecycleEvent.FixedUpdate);
		private void Update() => m_LifecycleEvents.Send(m_Lua.State, (Int32)ScriptLifecycleEvent.Update);
		private void LateUpdate() => m_LifecycleEvents.Send(m_Lua.State, (Int32)ScriptLifecycleEvent.LateUpdate);

		// Editor-only events
		private void Reset() => m_LuaScript.EventHandler<ScriptEditorOnlyEvent>()
			.Send(m_Lua.State, (Int32)ScriptEditorOnlyEvent.Reset);

		private void OnValidate() => m_LuaScript.EventHandler<ScriptEditorOnlyEvent>()
			.Send(m_Lua.State, (Int32)ScriptEditorOnlyEvent.OnValidate);

		private void OnDrawGizmos() => m_LuaScript.EventHandler<ScriptEditorOnlyEvent>()
			.Send(m_Lua.State, (Int32)ScriptEditorOnlyEvent.OnDrawGizmos);

		private void OnDrawGizmosSelected() => m_LuaScript.EventHandler<ScriptEditorOnlyEvent>()
			.Send(m_Lua.State, (Int32)ScriptEditorOnlyEvent.OnDrawGizmosSelected);

		// Application events
		private void OnApplicationQuit() => m_LuaScript.EventHandler<ScriptApplicationEvent>()
			.Send(m_Lua.State, (Int32)ScriptApplicationEvent.OnApplicationQuit);

		private void OnApplicationFocus(Boolean hasFocus)
		{
			OneArg[0] = hasFocus;
			m_LuaScript.EventHandler<ScriptApplicationEvent>()
				.Send(m_Lua.State, (Int32)ScriptApplicationEvent.OnApplicationFocus, OneArg);
		}

		private void OnApplicationPause(Boolean isPaused)
		{
			OneArg[0] = isPaused;
			m_LuaScript.EventHandler<ScriptApplicationEvent>()
				.Send(m_Lua.State, (Int32)ScriptApplicationEvent.OnApplicationPause, OneArg);
		}

		// Rendering events
		private void OnBecameInvisible() => RenderEvents?.Send(m_Lua.State, (Int32)ScriptRenderingEvent.OnBecameInvisible);
		private void OnBecameVisible() => RenderEvents?.Send(m_Lua.State, (Int32)ScriptRenderingEvent.OnBecameVisible);
		private void OnPreCull() => RenderEvents?.Send(m_Lua.State, (Int32)ScriptRenderingEvent.OnPreCull);
		private void OnPreRender() => RenderEvents?.Send(m_Lua.State, (Int32)ScriptRenderingEvent.OnPreRender);
		private void OnWillRenderObject() => RenderEvents?.Send(m_Lua.State, (Int32)ScriptRenderingEvent.OnWillRenderObject);
		private void OnRenderObject() => RenderEvents?.Send(m_Lua.State, (Int32)ScriptRenderingEvent.OnRenderObject);
		//private void OnRenderImage(RenderTexture source, RenderTexture destination) {}
		private void OnPostRender() => RenderEvents?.Send(m_Lua.State, (Int32)ScriptRenderingEvent.OnPostRender);

		// 2D Physics events
		private void OnJointBreak2D(Joint2D brokenJoint) => Physics2DEvents?.Send(m_Lua.State, (Int32)ScriptPhysics2DEvent.OnJointBreak2D);
		// private void OnCollisionEnter2D(Collision2D other) => m_LuaScript?.OnCollisionEnter2D(other);
		// private void OnCollisionExit2D(Collision2D other) => m_LuaScript?.OnCollisionExit2D(other);
		// private void OnCollisionStay2D(Collision2D other) => m_LuaScript?.OnCollisionStay2D(other);
		// private void OnTriggerEnter2D(Collider2D other) => m_LuaScript?.OnTriggerEnter2D(other);
		// private void OnTriggerExit2D(Collider2D other) => m_LuaScript?.OnTriggerExit2D(other);
		// private void OnTriggerStay2D(Collider2D other) => m_LuaScript?.OnTriggerStay2D(other);

		// 3D Physics events
		private void OnJointBreak(Single breakForce) => Physics3DEvents?.Send(m_Lua.State, (Int32)ScriptPhysics3DEvent.OnJointBreak);
		// private void OnCollisionEnter(Collision other) => m_LuaScript?.OnCollisionEnter(other);
		// private void OnCollisionExit(Collision other) => m_LuaScript?.OnCollisionExit(other);
		// private void OnCollisionStay(Collision other) => m_LuaScript?.OnCollisionStay(other);
		// private void OnTriggerEnter(Collider other) => m_LuaScript?.OnTriggerEnter(other);
		// private void OnTriggerExit(Collider other) => m_LuaScript?.OnTriggerExit(other);
		// private void OnTriggerStay(Collider other) => m_LuaScript?.OnTriggerStay(other);

		public void OnBeforeDestroy()
		{
			SendOnDisable();
			SendOnDestroy();
			StopAllCoroutines();
		}

		internal void SendAwakeAndOnEnable()
		{
			m_LifecycleEvents.Send(m_Lua.State, (Int32)ScriptLifecycleEvent.Awake);
			m_LifecycleEvents.Send(m_Lua.State, (Int32)ScriptLifecycleEvent.OnEnable);
		}
		private void SendOnDisable()
		{
			if (m_DestroyDidCallOnDisable)
				return;

			m_DestroyDidCallOnDisable = true;
			m_LifecycleEvents.Send(m_Lua.State, (Int32)ScriptLifecycleEvent.OnDisable);
		}

		private void SendOnDestroy()
		{
			if (m_DestroyDidCallOnDestroy)
				return;

			m_DestroyDidCallOnDestroy = true;
			m_LifecycleEvents.Send(m_Lua.State, (Int32)ScriptLifecycleEvent.OnDestroy);
		}


		// Unity Messages not yet implemented:

		// private void OnMouseDown() {}
		// private void OnMouseDrag() {}
		// private void OnMouseEnter() {}
		// private void OnMouseExit() {}
		// private void OnMouseOver() {}
		// private void OnMouseUp() {}
		// private void OnMouseUpAsButton() {}

		// private void OnBeforeTransformParentChanged() => Debug.Log("LunyScript OnBeforeTransformParentChanged");
		// private void OnTransformChildrenChanged() => Debug.Log("LunyScript OnTransformChildrenChanged");
		// private void OnTransformParentChanged() => Debug.Log("LunyScript OnTransformParentChanged");

		// private void OnGUI() => throw new NotImplementedException();
		// private void OnCanvasGroupChanged() => throw new NotImplementedException();
		// private void OnCanvasHierarchyChanged() => throw new NotImplementedException();
		// private void OnRectTransformDimensionsChange() => throw new NotImplementedException();

		// private void OnParticleCollision(GameObject other) => throw new NotImplementedException();
		// private void OnParticleSystemStopped() => throw new NotImplementedException();
		// private void OnParticleTrigger() => throw new NotImplementedException();
		// private void OnParticleUpdateJobScheduled() => throw new NotImplementedException();
	}
}
