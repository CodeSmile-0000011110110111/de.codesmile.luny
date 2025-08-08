// Copyright (C) 2021-2025 Steffen Itterheim
// Refer to included LICENSE file for terms and conditions.

using UnityEditor;
using UnityEngine;

namespace Luny.Core
{
	public abstract class PrefabCollection : AssetCollection<GameObject>
	{
		public void ValidatePrefabsHaveComponent<T>() where T : Component
		{
#if DEBUG || DEVELOPMENT_BUILD
			foreach (var prefab in Assets)
			{
				if (prefab.TryGetComponent<T>(out var _) == false)
					Debug.LogError($"{prefab.name} is missing required {typeof(T).Name} component");
			}
#endif
		}
	}
}
