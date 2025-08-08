// Copyright (C) 2021-2025 Steffen Itterheim
// Refer to included LICENSE file for terms and conditions.

using Luny.Core.Registry;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

namespace Luny.Core.Pool
{
	[DisallowMultipleComponent]
	public sealed class PrefabPool : MonoBehaviour
	{
		[SerializeField] [Range(10, 10000)] private Int32 m_InitialCapacity = 100;
		[SerializeField] [Range(10, 10000)] private Int32 m_MaxCapacity = 10000;

		private readonly Dictionary<Int32, PrefabInstancePool> m_Pools = new();
		private readonly DelayedReleaseInstances m_DelayedRelease = new();

		private void Awake() => ComponentsRegistry.Set(this);

		private void FixedUpdate()
		{
			var capacity = m_DelayedRelease.Capacity;
			for (var i = 0; i < capacity; i++)
			{
				if (m_DelayedRelease[i].IsValid && m_DelayedRelease[i].IsTimeElapsed)
				{
					ReleaseInstance(m_DelayedRelease[i].Prefab, m_DelayedRelease[i].Instance);
					m_DelayedRelease.RemoveAt(i);
				}
			}
		}

		public GameObject GetInstance(GameObject prefab, Boolean setActive = true)
		{
			var pool = GetOrCreatePool(prefab);
			return pool.GetInstance(setActive);
		}

		public GameObject GetInstance(GameObject prefab, Vector3 position, Quaternion rotation, Boolean setActive = true)
		{
			var pool = GetOrCreatePool(prefab);
			return pool.GetInstance(position, rotation, setActive);
		}

		public void ReleaseInstance(GameObject prefab, GameObject instance, Single delayTime = 0f)
		{
			var pool = GetOrCreatePool(prefab);
			if (delayTime > 0f)
			{
				var delayedInstance = new DelayedInstance
					{ Prefab = prefab, Instance = instance, ReleaseTime = Time.time + delayTime };
				m_DelayedRelease.Add(ref delayedInstance);
			}
			else
				pool.ReleaseInstance(instance);
		}

		public PrefabInstancePool CreatePool(GameObject prefab, Int32 initialCapacity, Int32 maxCapacity)
		{
			if (PoolExists(prefab.GetInstanceID()))
				throw new InvalidOperationException($"Pool for {prefab.name} already exists");

			initialCapacity = initialCapacity <= 0 ? m_InitialCapacity : initialCapacity;
			maxCapacity = maxCapacity <= 0 ? m_MaxCapacity : maxCapacity;
			return CreatePoolInternal(prefab, initialCapacity, maxCapacity);
		}

		public void ClearPool(GameObject prefab)
		{
			var id = prefab.GetInstanceID();
			if (PoolExists(id))
				GetPoolInternal(id).Clear();
		}

		public void DisposePool(GameObject prefab)
		{
			var id = prefab.GetInstanceID();
			if (PoolExists(id))
			{
				var pool = GetPoolInternal(id);
				m_Pools[id] = null;

				pool.Clear();
				Destroy(pool.Container);
			}
		}

		public PrefabInstancePool GetPool(GameObject prefab) => GetPoolInternal(prefab.GetInstanceID());

		public PrefabInstancePool GetOrCreatePool(GameObject prefab)
		{
			var id = prefab.GetInstanceID();
			if (PoolExists(id))
				return GetPoolInternal(id);

			return CreatePoolInternal(prefab, m_InitialCapacity, m_MaxCapacity);
		}

		private Boolean PoolExists(Int32 prefabId) => m_Pools.ContainsKey(prefabId);
		private PrefabInstancePool GetPoolInternal(Int32 prefabId) => m_Pools[prefabId];

		private PrefabInstancePool CreatePoolInternal(GameObject prefab, Int32 initialCapacity, Int32 maxCapacity) =>
			m_Pools[prefab.GetInstanceID()] = new PrefabInstancePool(prefab, transform, initialCapacity, maxCapacity);

		private sealed class DelayedReleaseInstances : GrowingArray<DelayedInstance> {}

		private struct DelayedInstance : IValidatable
		{
			public GameObject Prefab;
			public GameObject Instance;
			public Single ReleaseTime;
			public Boolean IsTimeElapsed => Time.time >= ReleaseTime;
			private Boolean m_IsValid;
			public Boolean IsValid
			{
				readonly get => m_IsValid;
				set
				{
					m_IsValid = value;
					if (m_IsValid == false)
					{
						Prefab = null;
						Instance = null;
						ReleaseTime = 0;
					}
				}
			}
		}

#if UNITY_EDITOR
		[Header("Debug")]
		[Tooltip("Updates container names frequently with pool statistics. Editor-only.")]
		[SerializeField] private Boolean m_ShowPoolStats;
		[SerializeField] [Range(0.05f, 1f)] private Single m_StatsUpdateFrequency = 0.2f;

		private void Start() => StartCoroutine(UpdatePoolNames());

		private IEnumerator UpdatePoolNames()
		{
			while (true)
			{
				yield return new WaitForSeconds(m_StatsUpdateFrequency);

				var activeTotal = 0;
				var inactiveTotal = 0;
				var allTotal = 0;

				if (m_ShowPoolStats)
				{
					foreach (var pool in m_Pools.Values)
					{
						var active = pool.CountActive;
						var inactive = pool.CountInactive;
						var all = pool.CountAll;
						pool.Container.name = $"{pool.Prefab.name} (Active: {active}, Inactive: {inactive}, Total: {all})";

						activeTotal += active;
						inactiveTotal += inactive;
						allTotal += all;
					}

					name = $"{nameof(PrefabPool)}  (Active: {activeTotal}, Inactive: {inactiveTotal}, Total: {allTotal})";
				}
			}
		}
#endif
	}
}
