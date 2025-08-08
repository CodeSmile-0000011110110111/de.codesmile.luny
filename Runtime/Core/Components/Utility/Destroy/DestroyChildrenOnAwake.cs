// Copyright (C) 2021-2025 Steffen Itterheim
// Refer to included LICENSE file for terms and conditions.

using Luny.Core.UnityEngine;
using UnityEditor;
using UnityEngine;

namespace Luny.Core.Components
{
	[DisallowMultipleComponent]
	public sealed class DestroyChildrenOnAwake : MonoBehaviour
	{
		private void Awake()
		{
			transform.DestroyAllChildren();
			Destroy(this);
		}
	}
}
