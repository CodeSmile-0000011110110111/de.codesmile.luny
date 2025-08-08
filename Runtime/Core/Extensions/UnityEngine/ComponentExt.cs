// Copyright (C) 2021-2025 Steffen Itterheim
// Refer to included LICENSE file for terms and conditions.

using UnityEditor;
using UnityEngine;

namespace Luny.Core.UnityEngine
{
	public static class ComponentExt
	{
		public static T GetOrAddComponent<T>(this Component component) where T : Component =>
			component.gameObject.GetOrAddComponent<T>();

		public static void DestroyAllChildren(this Component component) => component.gameObject.DestroyAllChildren();
	}
}
