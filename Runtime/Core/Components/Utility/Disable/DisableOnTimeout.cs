// Copyright (C) 2021-2025 Steffen Itterheim
// Refer to included LICENSE file for terms and conditions.

using System;
using System.Collections;
using UnityEditor;
using UnityEngine;

namespace Luny.Core.Utility.Disable
{
	[DisallowMultipleComponent]
	internal sealed class DisableOnTimeout : MonoBehaviour
	{
		[SerializeField] private Single m_TimeToLive = 1f;

		private void OnEnable() => StartCoroutine(DisableAfterDelay(m_TimeToLive));

		private IEnumerator DisableAfterDelay(Single timeToLive)
		{
			yield return new WaitForSeconds(timeToLive);

			gameObject.SetActive(false);
		}
	}
}
