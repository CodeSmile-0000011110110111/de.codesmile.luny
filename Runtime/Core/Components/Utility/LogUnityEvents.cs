// Copyright (C) 2021-2025 Steffen Itterheim
// Refer to included LICENSE file for terms and conditions.

using System;
using UnityEditor;
using UnityEngine;

namespace Luny.Core.Components
{
	[DisallowMultipleComponent]
	public sealed class LogUnityEvents : MonoBehaviour
	{
		[SerializeField] private Boolean m_LogRepeatingEvents;

		private void Awake() => LogMethod("Awake");
		private void Reset() => LogMethod("Reset");
		private void Start() => LogMethod("Start");

		private void Update()
		{
			if (m_LogRepeatingEvents)
				LogMethod("Update");
		}

		private void FixedUpdate()
		{
			if (m_LogRepeatingEvents)
				LogMethod("FixedUpdate");
		}

		private void LateUpdate()
		{
			if (m_LogRepeatingEvents)
				LogMethod("LateUpdate");
		}

		private void OnEnable() => LogMethod("OnEnable");
		private void OnDisable() => LogMethod("OnDisable");
		private void OnDestroy() => LogMethod("OnDestroy");

		private void OnGUI()
		{
			if (m_LogRepeatingEvents)
				LogMethod($"OnGUI ({Event.current.type})");
		}

		private void OnAnimatorIK(Int32 layerIndex)
		{
			if (m_LogRepeatingEvents)
				LogMethod("OnAnimatorIK");
		}

		private void OnAnimatorMove()
		{
			if (m_LogRepeatingEvents)
				LogMethod("OnAnimatorMove");
		}

		private void OnApplicationFocus(Boolean hasFocus) => LogMethod($"OnApplicationFocus: {hasFocus}");
		private void OnApplicationPause(Boolean pauseStatus) => LogMethod("OnApplicationPause: {pauseStatus}");
		private void OnApplicationQuit() => LogMethod("OnApplicationQuit");

		private void OnAudioFilterRead(Single[] data, Int32 channels) =>
			LogMethod($"OnAudioFilterRead: {data} ({data?.Length}), channels: {channels})");

		private void OnBecameInvisible() => LogMethod("OnBecameInvisible");
		private void OnBecameVisible() => LogMethod("OnBecameVisible");
		private void OnBeforeTransformParentChanged() => LogMethod("OnBeforeTransformParentChanged");
		private void OnCanvasGroupChanged() => LogMethod("OnCanvasGroupChanged");
		private void OnCanvasHierarchyChanged() => LogMethod("OnCanvasHierarchyChanged");
		private void OnCollisionEnter(Collision other) => LogMethod($"OnCollisionEnter: {other}");
		private void OnCollisionEnter2D(Collision2D other) => LogMethod($"OnCollisionEnter2D: {other}");
		private void OnCollisionExit(Collision other) => LogMethod($"OnCollisionExit: {other}");
		private void OnCollisionExit2D(Collision2D other) => LogMethod($"OnCollisionExit2D: {other}");
		private void OnCollisionStay(Collision other) => LogMethod($"OnCollisionStay: {other}");
		private void OnCollisionStay2D(Collision2D other) => LogMethod($"OnCollisionStay2D: {other}");
		private void OnConnectedToServer() => LogMethod("OnConnectedToServer");
		private void OnControllerColliderHit(ControllerColliderHit hit) => LogMethod($"OnControllerColliderHit: {hit}");
		private void OnDidApplyAnimationProperties() => LogMethod("OnDidApplyAnimationProperties");

		private void OnDrawGizmos()
		{
			if (m_LogRepeatingEvents)
				LogMethod("OnDrawGizmos");
		}

		private void OnDrawGizmosSelected()
		{
			if (m_LogRepeatingEvents)
				LogMethod("OnDrawGizmosSelected");
		}

		private void OnJointBreak(Single breakForce) => LogMethod($"OnJointBreak: {breakForce}");
		private void OnJointBreak2D(Joint2D brokenJoint) => LogMethod($"OnJointBreak2D: {brokenJoint}");
		private void OnMouseDown() => LogMethod("OnMouseDown");
		private void OnMouseDrag() => LogMethod("OnMouseDrag");
		private void OnMouseEnter() => LogMethod("OnMouseEnter");
		private void OnMouseExit() => LogMethod("OnMouseExit");
		private void OnMouseOver() => LogMethod("OnMouseOver");
		private void OnMouseUp() => LogMethod("OnMouseUp");
		private void OnMouseUpAsButton() => LogMethod("OnMouseUpAsButton");
		private void OnParticleCollision(GameObject other) => LogMethod($"OnParticleCollision: {other}");
		private void OnParticleSystemStopped() => LogMethod("OnParticleSystemStopped");
		private void OnParticleTrigger() => LogMethod("OnParticleTrigger");
		private void OnParticleUpdateJobScheduled() => LogMethod("OnParticleUpdateJobScheduled");

		private void OnPostRender()
		{
			if (m_LogRepeatingEvents)
				LogMethod("OnPostRender");
		}

		private void OnPreCull()
		{
			if (m_LogRepeatingEvents)
				LogMethod("OnPreCull");
		}

		private void OnPreRender()
		{
			if (m_LogRepeatingEvents)
				LogMethod("OnPreRender");
		}

		private void OnRectTransformDimensionsChange() => LogMethod("OnRectTransformDimensionsChange");

		private void OnRenderImage(RenderTexture source, RenderTexture destination) => LogMethod($"OnRenderImage: {source}, {destination}");

		private void OnRenderObject() => LogMethod("OnRenderObject");
		private void OnServerInitialized() => LogMethod("OnServerInitialized");
		private void OnTransformChildrenChanged() => LogMethod("OnTransformChildrenChanged");
		private void OnTransformParentChanged() => LogMethod("OnTransformParentChanged");
		private void OnTriggerEnter(Collider other) => LogMethod($"OnTriggerEnter: {other}");
		private void OnTriggerEnter2D(Collider2D other) => LogMethod($"OnTriggerEnter2D: {other}");
		private void OnTriggerExit(Collider other) => LogMethod($"OnTriggerExit: {other}");
		private void OnTriggerExit2D(Collider2D other) => LogMethod($"OnTriggerExit2D: {other}");
		private void OnTriggerStay(Collider other) => LogMethod($"OnTriggerStay: {other}");
		private void OnTriggerStay2D(Collider2D other) => LogMethod($"OnTriggerStay2D: {other}");
		private void OnValidate() => LogMethod("OnValidate");

		private void OnWillRenderObject()
		{
			if (m_LogRepeatingEvents)
				LogMethod("OnWillRenderObject");
		}

		private String GetLog(GameObject go, Boolean logParent = false) => go == null ? "(null)" :
			logParent ? GetLog(go.transform.parent?.gameObject) : $"{go.name} ({go.GetInstanceID()})";

		private void LogMethod(String methodName) =>
			Debug.Log($"Frame [{Time.frameCount}]: {methodName} on {GetLog(gameObject)}, parent = {GetLog(gameObject, true)}");
	}
}
