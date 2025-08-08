// Copyright (C) 2021-2025 Steffen Itterheim
// Refer to included LICENSE file for terms and conditions.

using UnityEditor;
using UnityEngine;

namespace CodeSmile.Components
{
	/// <summary>
	///     Will add the listed ScriptableObjects to the ScriptableObjectsRegistry. CAUTION: ScriptableObject types must be
	///     unique!
	/// </summary>
	[DisallowMultipleComponent]
	internal sealed class ScriptableObjectReferences : MonoBehaviour
	{
		[SerializeField] private ScriptableObject[] m_ScriptableObjects;

		private void Awake()
		{
			foreach (var scriptableObject in m_ScriptableObjects)
			{
				if (scriptableObject != null)
					ScriptableObjectsRegistry.Set(scriptableObject);
			}

			Destroy(this);
		}
	}
}
