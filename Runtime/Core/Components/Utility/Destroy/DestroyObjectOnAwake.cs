// Copyright (C) 2021-2025 Steffen Itterheim
// Refer to included LICENSE file for terms and conditions.

using UnityEditor;
using UnityEngine;

namespace Luny.Core.Components
{
	/// <summary>
	///     Always destroys this object. Use for information-only objects, eg dividers or notes.
	/// </summary>
	[DisallowMultipleComponent]
	internal sealed class DestroyObjectOnAwake : MonoBehaviour
	{
		private void Awake() => Destroy(gameObject);
	}
}
