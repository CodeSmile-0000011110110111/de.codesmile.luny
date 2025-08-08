// Copyright (C) 2021-2025 Steffen Itterheim
// Refer to included LICENSE file for terms and conditions.

using UnityEditor;
using UnityEngine;

namespace CodeSmile.Components.Destroy
{
	/// <summary>
	///     Destroys the object if running outside the editor in a release (non-Debug, non-Development) build.
	/// </summary>
	[DisallowMultipleComponent]
	internal sealed class DestroyObjectInReleaseBuilds : MonoBehaviour
	{
#if !UNITY_EDITOR && !DEBUG && !DEVELOPMENT_BUILD
		private void Awake()
		{
			if (enabled)
				Destroy(gameObject);
		}
#endif
	}
}
