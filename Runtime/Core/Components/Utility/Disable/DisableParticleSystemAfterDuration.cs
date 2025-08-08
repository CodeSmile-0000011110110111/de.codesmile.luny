// Copyright (C) 2021-2025 Steffen Itterheim
// Refer to included LICENSE file for terms and conditions.

using UnityEditor;
using UnityEngine;

namespace Luny.Core.Utility.Disable
{
	[RequireComponent(typeof(ParticleSystem))]
	public sealed class DisableParticleSystemAfterDuration : MonoBehaviour
	{
		private void OnEnable()
		{
			var psMain = GetComponent<ParticleSystem>().main;
			Invoke(nameof(SetInactive), psMain.duration + psMain.startDelay.constant);
		}

		private void SetInactive() => gameObject.SetActive(false);
	}
}
