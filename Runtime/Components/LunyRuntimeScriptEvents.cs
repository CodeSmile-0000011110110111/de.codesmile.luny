// Copyright (C) 2021-2025 Steffen Itterheim
// Refer to included LICENSE file for terms and conditions.

using UnityEditor;
using UnityEngine;

namespace Luny
{
	// Unsupported MonoBehaviour events
	// OnGUI => This is for (legacy) IMGUI which should not be used anymore.
	// OnMouse* => These are outdated and should not be used anymore.
	// OnParticleUpdateJobScheduled => This makes only sense in combination with Jobs.
	// OnRenderImage => This is a legacy Built-In Render Pipeline method. It won't work with Scriptable Render Pipelines.
	// On*Server* => These are obsolete UNET messages no longer in use.

	public enum LunyScriptLoadEvent
	{
		OnWillReloadScript,
		OnDidLoadScript,
	}

	public enum MonoBehaviourAnimatorEvent
	{
		OnAnimatorIK,
		OnAnimatorMove,
		OnDidApplyAnimationProperties,
	}

	public enum MonoBehaviourApplicationEvent
	{
		OnApplicationFocus,
		OnApplicationPause,
		OnApplicationQuit,
	}

	public enum MonoBehaviourAudioEvent
	{
		OnAudioFilterRead,
	}

	public enum MonoBehaviourEditorEvent
	{
		OnDrawGizmos,
		OnDrawGizmosSelected,
		OnValidate,
		Reset, // MonoBehaviour scripts will not receive this as Reset won't occur in Playmode
	}

	public enum MonoBehaviourLifecycleEvent
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

	public enum MonoBehaviourParticleEvent
	{
		OnParticleCollision,
		OnParticleSystemStopped,
		OnParticleTrigger,
	}

	public enum MonoBehaviourPhysics2DEvent
	{
		OnCollisionEnter2D,
		OnCollisionExit2D,
		OnCollisionStay2D,
		OnJointBreak2D,
		OnTriggerEnter2D,
		OnTriggerExit2D,
		OnTriggerStay2D,
	}

	public enum MonoBehaviourPhysicsEvent
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

	public enum MonoBehaviourRenderEvent
	{
		OnBecameInvisible,
		OnBecameVisible,
		OnPostRender,
		OnPreCull,
		OnPreRender,
		OnRenderObject,
		OnWillRenderObject,
	}

	public enum MonoBehaviourTransformEvent
	{
		OnBeforeTransformParentChanged,
		OnTransformChildrenChanged,
		OnTransformParentChanged,
	}
}
