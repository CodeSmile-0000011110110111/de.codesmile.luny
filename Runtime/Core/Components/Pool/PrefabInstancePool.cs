// Copyright (C) 2021-2025 Steffen Itterheim
// Refer to included LICENSE file for terms and conditions.

using System;
using UnityEditor;
using UnityEngine;
using UnityEngine.Pool;
using Object = UnityEngine.Object;

namespace CodeSmile.Components
{
	public sealed class PrefabInstancePool
	{
		private readonly GameObject m_Prefab;
		private readonly Transform m_Container;
		private readonly ObjectPool<GameObject> m_Pool;

		public GameObject Prefab => m_Prefab;
		public Transform Container => m_Container;
		public Int32 CountActive => m_Pool.CountActive;
		public Int32 CountInactive => m_Pool.CountInactive;
		public Int32 CountAll => m_Pool.CountAll;

		public PrefabInstancePool(GameObject prefab, Transform parent, Int32 initialCapacity = 100,
			Int32 maximumCapacity = 10000)
		{
			if (prefab == null)
				throw new ArgumentNullException(nameof(prefab));

			m_Prefab = prefab;
			m_Container = new GameObject($"{prefab.name} Instances").transform;
			m_Container.parent = parent;
			m_Pool = new ObjectPool<GameObject>(OnCreate, OnGet, OnRelease, OnDestroy, true, initialCapacity,
				maximumCapacity);
		}

		public GameObject GetInstance(Boolean setActive = true)
		{
			var instance = m_Pool.Get();
			if (setActive)
				instance.SetActive(true);
			return instance;
		}

		public GameObject GetInstance(Vector3 position, Quaternion rotation, Boolean setActive = true)
		{
			var instance = m_Pool.Get();
			instance.transform.SetPositionAndRotation(position, rotation);
			if (setActive)
				instance.SetActive(true);
			return instance;
		}

		public void ReleaseInstance(GameObject go) => m_Pool.Release(go);
		public void Clear() => m_Pool.Clear();
		private GameObject OnCreate() => Object.Instantiate(m_Prefab, m_Container);
		private void OnGet(GameObject go) {}
		private void OnRelease(GameObject go) => go.SetActive(false);
		private void OnDestroy(GameObject go) {}
	}
}
