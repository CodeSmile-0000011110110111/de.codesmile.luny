// Copyright (C) 2021-2025 Steffen Itterheim
// Refer to included LICENSE file for terms and conditions.

using System;
using UnityEditor;
using UnityEngine;

namespace CodeSmile.Components
{
	[DisallowMultipleComponent]
	[RequireComponent(typeof(ParticleSystem))]
	public sealed class ParticleSystemPlayStop : MonoBehaviour
	{
		[SerializeField] private Boolean m_ApplyToChildren = true;
		[SerializeField] private ParticleSystemStopBehavior m_StopBehavior;

		private ParticleSystem m_ParticleSystem;
		private void Awake() => m_ParticleSystem = GetComponent<ParticleSystem>();
		private void OnEnable() => m_ParticleSystem.Play(m_ApplyToChildren);
		private void OnDisable() => m_ParticleSystem.Stop(m_ApplyToChildren, m_StopBehavior);
	}
}
