// Copyright (C) 2021-2025 Steffen Itterheim
// Refer to included LICENSE file for terms and conditions.

using UnityEditor;
using UnityEngine;

namespace CodeSmile.Components.Destroy
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
