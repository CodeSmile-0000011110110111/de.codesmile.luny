// Copyright (C) 2021-2025 Steffen Itterheim
// Refer to included LICENSE file for terms and conditions.

using UnityEditor;
using UnityEngine;

namespace Luny.Core
{
	public static class ColliderExt
	{
		public static T GetOrAddComponent<T>(this Collider collider) where T : Component => collider.gameObject.GetOrAddComponent<T>();

		public static T AddComponent<T>(this Collider collider) where T : Component => collider.gameObject.AddComponent<T>();
	}
}
