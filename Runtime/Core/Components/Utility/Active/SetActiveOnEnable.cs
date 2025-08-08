// Copyright (C) 2021-2025 Steffen Itterheim
// Refer to included LICENSE file for terms and conditions.

using UnityEditor;
using UnityEngine;

namespace Luny.Core.Utility.Active
{
	/// <summary>
	///     Always destroys this object. Use for information-only objects, eg dividers or notes.
	/// </summary>
	[DisallowMultipleComponent]
	internal sealed class SetActiveOnEnable : MonoBehaviour
	{
		[SerializeField] private GameObject[] m_GameObjectsToSetActive = new GameObject[0];

		private void OnEnable()
		{
			foreach (var go in m_GameObjectsToSetActive)
				go.SetActive(true);
		}
	}
}
