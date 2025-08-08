// Copyright (C) 2021-2025 Steffen Itterheim
// Refer to included LICENSE file for terms and conditions.

using System;
using UnityEditor;
using UnityEngine;

namespace Luny.Core.Utility.Destroy
{
	[DisallowMultipleComponent]
	internal sealed class DestroyOnTimeout : MonoBehaviour
	{
		[SerializeField] private Single m_TimeToLive = 1f;

		private void OnEnable() => Destroy(gameObject, m_TimeToLive);
	}
}
