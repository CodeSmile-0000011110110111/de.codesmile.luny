// Copyright (C) 2021-2025 Steffen Itterheim
// Refer to included LICENSE file for terms and conditions.

using UnityEditor;
using UnityEngine;

namespace CodeSmile.Luny
{
	public enum ScriptLifecycleEvent
	{
		Awake,
		OnDestroy,
		OnDisable,
		OnEnable,
		Start,
	}

	public enum ScriptLoadEvent
	{
		OnWillReloadScript,
		OnDidLoadScript,
	}

	public enum ScriptUpdateEvent
	{
		FixedUpdate,
		LateUpdate,
		Update,
	}

	public enum ScriptGUIEvent
	{
		OnDrawGizmos,
		OnDrawGizmosSelected,
		OnGUI,
	}

	public enum ScriptEditorOnlyEvent
	{
		OnValidate,
		Reset,
	}

	public enum MonoBehaviourTransformMessage
	{
		OnTransformChildrenChanged,
		OnTransformParentChanged,
	}

	public enum MonoBehaviourApplicationMessage
	{
		OnApplicationFocus,
		OnApplicationPause,
		OnApplicationQuit,
	}

	public enum MonoBehaviourAVMessage
	{
		OnAnimatorIK,
		OnAnimatorMove,
		OnAudioFilterRead,
		OnParticleCollision,
		OnParticleSystemStopped,
		OnParticleTrigger,
		//OnParticleUpdateJobScheduled,
	}

	public enum MonoBehaviourRenderMessage
	{
		OnBecameInvisible,
		OnBecameVisible,
		OnPostRender,
		OnPreCull,
		OnPreRender,
		OnRenderImage,
		OnRenderObject,
		OnWillRenderObject,
	}

	public enum MonoBehaviourPhysicsMessage
	{
		OnCollisionEnter,
		OnCollisionEnter2D,
		OnCollisionExit,
		OnCollisionExit2D,
		OnCollisionStay,
		OnCollisionStay2D,
		OnControllerColliderHit,

		OnJointBreak,
		OnJointBreak2D,

		OnTriggerEnter,
		OnTriggerEnter2D,
		OnTriggerExit,
		OnTriggerExit2D,
		OnTriggerStay,
		OnTriggerStay2D,
	}

	public enum MonoBehaviourInputMessage
	{
		OnMouseDown,
		OnMouseDrag,
		OnMouseEnter,
		OnMouseExit,
		OnMouseOver,
		OnMouseUp,
		OnMouseUpAsButton,
	}
}
