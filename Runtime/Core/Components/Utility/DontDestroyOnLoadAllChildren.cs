// Copyright (C) 2021-2025 Steffen Itterheim
// Refer to included LICENSE file for terms and conditions.

using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

namespace CodeSmile.Components
{
	/// <summary>
	///     Moves all children to "Don't Destroy On Load" and then destroys the component's GameObject.
	/// </summary>
	/// <remarks>
	///     DDoL is applied in Start(), not Awake(), to allow Multiplayer Roles to strip components during Awake().
	///     This script will also move the GameObject to the root since DDoL only works on root game objects.
	/// </remarks>
	[DisallowMultipleComponent]
	internal sealed class DontDestroyOnLoadAllChildren : MonoBehaviour
	{
		private void Start()
		{
			// we need a separate list to preserve child sort order
			var children = new List<Transform>();

			for (var i = 0; i < transform.childCount; i++)
				children.Add(transform.GetChild(i));

			foreach (var child in children)
			{
				child.parent = null; // DDoL only works on root game objects
				DontDestroyOnLoad(child.gameObject);
			}

			Destroy(gameObject);
		}
	}
}
