// Copyright (C) 2021-2025 Steffen Itterheim
// Refer to included LICENSE file for terms and conditions.

using UnityEditor;
using UnityEngine;

namespace CodeSmile.Components
{
	/// <summary>
	///     Will add the listed components to the ComponentsRegistry. CAUTION: Component types must be unique!
	/// </summary>
	[DisallowMultipleComponent]
	internal sealed class ComponentReferences : MonoBehaviour
	{
		[SerializeField] private Component[] m_Components;

		private void Awake()
		{
			foreach (var component in m_Components)
			{
				if (component != null)
					ComponentsRegistry.Set(component);
			}

			Destroy(this);
		}
	}
}
