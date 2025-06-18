// Copyright (C) 2021-2025 Steffen Itterheim
// Refer to included LICENSE file for terms and conditions.

using UnityEditor;
using UnityEngine;

namespace CodeSmile.Luny
{
	public enum MonoBehaviourLifecycleMessage
	{
		Awake,
		FixedUpdate,
		LateUpdate,
		OnDestroy,
		OnDisable,
		OnEnable,
		OnTransformChildrenChanged,
		OnTransformParentChanged,
		Start,
		Update,
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

	public enum MonoBehaviourEditorMessage
	{
		OnDrawGizmos,
		OnDrawGizmosSelected,
		OnGUI,
		OnValidate,
		Reset,
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
