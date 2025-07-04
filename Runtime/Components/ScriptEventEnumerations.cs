﻿// Copyright (C) 2021-2025 Steffen Itterheim
// Refer to included LICENSE file for terms and conditions.

using UnityEditor;
using UnityEngine;

namespace CodeSmile.Luny
{
	// Unsupported events
	// OnGUI => This is for (legacy) IMGUI which should not be used anymore. I don't intend to support IMGUI in any way.
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
