// Copyright (C) 2021-2025 Steffen Itterheim
// Refer to included LICENSE file for terms and conditions.

using UnityEditor;
using UnityEngine;

namespace Luny.Core.Components
{
	/// <summary>
	///     Marks the GameObject this script is on as "Don't Destroy On Load".
	/// </summary>
	/// <remarks>
	///     DDoL is applied in Start(), not Awake(), to allow Multiplayer Roles to strip components during Awake().
	///     This script will also move the GameObject to the root since DDoL only works on root game objects.
	/// </remarks>
	[DisallowMultipleComponent]
	internal sealed class DontDestroyOnLoad : MonoBehaviour
	{
		private void Start()
		{
			if (enabled)
			{
				// DDoL only works on root game objects
				transform.parent = null;
				DontDestroyOnLoad(gameObject);

				Destroy(this);
			}
		}
	}
}
