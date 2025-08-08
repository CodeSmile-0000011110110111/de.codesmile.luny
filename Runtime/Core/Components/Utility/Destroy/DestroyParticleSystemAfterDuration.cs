// Copyright (C) 2021-2025 Steffen Itterheim
// Refer to included LICENSE file for terms and conditions.

using UnityEditor;
using UnityEngine;

namespace CodeSmile.Components.Destroy
{
	[RequireComponent(typeof(ParticleSystem))]
	internal sealed class DestroyParticleSystemAfterDuration : MonoBehaviour
	{
		private void OnEnable()
		{
			var psMain = GetComponent<ParticleSystem>().main;
			Destroy(gameObject, psMain.duration + psMain.startDelay.constant);
		}
	}
}
