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
	internal sealed class SetInactiveOnDisable : MonoBehaviour
	{
		[SerializeField] private GameObject[] m_GameObjectsToSetInactive = new GameObject[0];

		private void OnDisable()
		{
			foreach (var go in m_GameObjectsToSetInactive)
				go.SetActive(false);
		}
	}
}
