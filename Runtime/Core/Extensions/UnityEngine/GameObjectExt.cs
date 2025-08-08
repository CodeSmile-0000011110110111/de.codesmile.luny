// Copyright (C) 2021-2025 Steffen Itterheim
// Refer to included LICENSE file for terms and conditions.

using System;
using UnityEditor;
using UnityEngine;
using UnityEngine_GameObject = UnityEngine.GameObject;

namespace Luny.Core.UnityEngine
{
	public static class GameObjectExt
	{
		public static T GetOrAddComponent<T>(this UnityEngine_GameObject go) where T : Component
		{
			T component;
#if UNITY_EDITOR
			if (PrefabUtility.IsPartOfPrefabAsset(go))
			{
				go.TryGetComponent(out component);
				if (component == null)
					Debug.LogWarning($"won't add component {typeof(T)} because this is a prefab: {go} (Editor-only warning)");

				return component;
			}
#endif

			return go.TryGetComponent(out component) ? component : go.AddComponent<T>();
		}

		public static Component GetOrAddComponent(this UnityEngine_GameObject go, Type componentType)
		{
			Component component;
#if UNITY_EDITOR
			if (PrefabUtility.IsPartOfPrefabAsset(go))
			{
				go.TryGetComponent(componentType, out component);
				if (component == null)
					Debug.LogWarning($"can't add missing component {componentType} to prefab: {go}");

				return component;
			}
#endif

			return go.TryGetComponent(componentType, out component) ? component : go.AddComponent(componentType);
		}

		public static void DestroyAllChildren(this UnityEngine_GameObject go) => go.transform.DestroyAllChildren();
	}
}
