// Copyright (C) 2021-2025 Steffen Itterheim
// Refer to included LICENSE file for terms and conditions.

using Lua;
using Lua.Unity;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

namespace CodeSmile.Luny
{
	public abstract class LunyScriptEventHandlerBase
	{
		private LuaCallbackFunctions m_Callbacks;

		public void Send(LuaState luaState, Int32 eventIndex, params LuaValue[] args) => m_Callbacks?.TryInvoke(luaState, eventIndex, args);

		private LuaCallbackFunctions CreateCallbacks<T>(LuaTable scriptContext) where T : Enum
		{
			var functionNames = Enum.GetNames(typeof(T));
			var functionCount = functionNames.Length;
			var callbackFunctions = new LuaFunction[functionCount];

			var callbackCount = 0;
			for (var i = 0; i < functionCount; i++)
			{
				var func = scriptContext.GetFunction(functionNames[i]);
				if (func != null)
				{
					callbackFunctions[i] = func;
					callbackCount++;
				}
			}

			return callbackCount > 0 ? new LuaCallbackFunctions(callbackFunctions) : null;
		}

		internal void BindEventCallbacks<T>(LuaTable scriptContext) where T : Enum => m_Callbacks = CreateCallbacks<T>(scriptContext);
		internal abstract void BindEventCallbacks(LuaTable scriptContext);
	}

	public sealed class LunyScriptEventHandler<T> : LunyScriptEventHandlerBase where T : Enum
	{
		public LunyScriptEventHandler(LuaTable scriptContext) => BindEventCallbacks<T>(scriptContext);
		internal override void BindEventCallbacks(LuaTable scriptContext) => BindEventCallbacks<T>(scriptContext);
	}

	public sealed class LunyScriptEventHandlerCollection : IEnumerable<LunyScriptEventHandlerBase>
	{
		private readonly Dictionary<Type, LunyScriptEventHandlerBase> m_EventHandlers = new();

		public Int32 Count => m_EventHandlers.Count;
		public Boolean IsReadOnly => false;

		public IEnumerator<LunyScriptEventHandlerBase> GetEnumerator() => m_EventHandlers.Values.GetEnumerator();

		IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();

		public void Add(Type enumType, LunyScriptEventHandlerBase item) => m_EventHandlers.Add(enumType, item);

		public LunyScriptEventHandler<T> TryGet<T>() where T : Enum => m_EventHandlers.TryGetValue(typeof(T), out var handler)
			? (LunyScriptEventHandler<T>)handler
			: null;
	}

	// Unsupported events
	// OnGUI => This is for (legacy) IMGUI which should not be used anymore.
	// OnMouse* => These are outdated and should not be used anymore.
	// OnParticleUpdateJobScheduled => This makes only sense in combination with Jobs.
	// OnRenderImage => This is a legacy Built-In Render Pipeline method. It won't work with Scriptable Render Pipelines.
	// On*Server* => These are obsolete UNET messages no longer in use.

	public enum ScriptAnimatorEvent
	{
		OnAnimatorIK,
		OnAnimatorMove,
		OnDidApplyAnimationProperties,
	}

	public enum ScriptApplicationEvent
	{
		OnApplicationFocus,
		OnApplicationPause,
		OnApplicationQuit,
	}

	public enum ScriptAudioEvent
	{
		OnAudioFilterRead,
	}

	public enum ScriptEditorOnlyEvent
	{
		OnDrawGizmos,
		OnDrawGizmosSelected,
		OnValidate,
		Reset, // MonoBehaviour scripts will not receive this as Reset won't occur in Playmode
	}

	public enum ScriptLifecycleEvent
	{
		Awake,
		FixedUpdate,
		LateUpdate,
		OnDestroy,
		OnDisable,
		OnEnable,
		Start,
		Update,
	}
	// public enum ScriptUpdateEvent
	// {
	// 	FixedUpdate,
	// 	LateUpdate,
	// 	Update,
	// }

	public enum ScriptLoadEvent
	{
		OnWillReloadScript,
		OnDidLoadScript,
	}

	public enum ScriptParticleEvent
	{
		OnParticleCollision,
		OnParticleSystemStopped,
		OnParticleTrigger,
	}

	public enum ScriptPhysics2DEvent
	{
		OnCollisionEnter2D,
		OnCollisionExit2D,
		OnCollisionStay2D,
		OnJointBreak2D,
		OnTriggerEnter2D,
		OnTriggerExit2D,
		OnTriggerStay2D,
	}

	public enum ScriptPhysics3DEvent
	{
		OnCollisionEnter,
		OnCollisionExit,
		OnCollisionStay,
		OnControllerColliderHit,
		OnJointBreak,
		OnTriggerEnter,
		OnTriggerExit,
		OnTriggerStay,
	}

	public enum ScriptRenderingEvent
	{
		OnBecameInvisible,
		OnBecameVisible,
		OnPostRender,
		OnPreCull,
		OnPreRender,
		OnRenderObject,
		OnWillRenderObject,
	}

	public enum ScriptTransformEvent
	{
		OnBeforeTransformParentChanged,
		OnTransformChildrenChanged,
		OnTransformParentChanged,
	}
}
