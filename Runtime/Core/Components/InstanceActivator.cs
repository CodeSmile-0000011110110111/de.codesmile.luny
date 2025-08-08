// Copyright (C) 2021-2025 Steffen Itterheim
// Refer to included LICENSE file for terms and conditions.

using Luny.Core.UnityEngine;
using System;
using UnityEditor;
using UnityEngine;
using Object = UnityEngine.Object;

namespace Luny.Core.Components
{
	/// <summary>
	///     Takes care of instantiating child objects and ensures at most one of them is active at any given time.
	/// </summary>
	/// <remarks>Do not add or destroy children of the parent object.</remarks>
	public sealed class InstanceActivator
	{
		private readonly Transform m_Parent;
		private GameObject[] m_Instances;
		private Int32 m_ActiveInstanceIndex = -1;

		public GameObject[] Instances => m_Instances;

		/// <summary>
		///     Index of currently active index. Negative values makes all children inactive.
		/// </summary>
		public Int32 ActiveInstanceIndex
		{
			get => m_ActiveInstanceIndex;
			set
			{
				// disable currently active
				if (m_ActiveInstanceIndex >= 0)
					SetActive(m_ActiveInstanceIndex, false);

				m_ActiveInstanceIndex = Mathf.Clamp(value, -1, m_Parent.childCount - 1);

				// activate new selection
				if (m_ActiveInstanceIndex >= 0)
					SetActive(m_ActiveInstanceIndex, true);
			}
		}

		/// <summary>
		///     Currently active instance or null.
		/// </summary>
		public GameObject ActiveInstance => m_ActiveInstanceIndex >= 0 ? m_Parent.GetChild(m_ActiveInstanceIndex).gameObject : null;

		public InstanceActivator(Transform parent, Int32 activeIndex = -1)
			: this(parent, null, activeIndex) {}

		public InstanceActivator(Transform parent, GameObject[] prefabs, Int32 activeIndex = -1)
		{
			if (parent == null)
				throw new ArgumentNullException(nameof(parent));

			m_Parent = parent;
			if (m_Parent.childCount > 0)
			{
				Debug.LogWarning($"{nameof(InstanceActivator)} parent {m_Parent.name} ({m_Parent.GetInstanceID()}) " +
				                 $"already has {m_Parent.childCount} children => destroying children");
				m_Parent.DestroyAllChildren();
			}

			if (prefabs != null)
				InstantiatePrefabs(prefabs);

			ActiveInstanceIndex = activeIndex >= 0 ? activeIndex : -1;
		}

		public void DestroyAllInstances()
		{
			foreach (var instance in Instances)
				instance.DestroyInAnyMode();
			m_Instances = null;
			m_ActiveInstanceIndex = -1;
		}

		private void InstantiatePrefabs(GameObject[] prefabs)
		{
			// deactivate parent to ensure children don't "awake" unless specifically set active later
			var parentObject = m_Parent.gameObject;
			var isParentActive = parentObject.activeSelf;
			parentObject.SetActive(false);

			var prefabCount = prefabs.Length;
			m_Instances = new GameObject[prefabCount];
			for (var i = 0; i < prefabCount; i++)
			{
				Instances[i] = Object.Instantiate(prefabs[i], m_Parent);
				// ensure Awake, Start, OnEnable don't run on children during instantiation
				Instances[i].SetActive(false);

				// Debug.Log($"Instantiated {Instances[i].name} ({Instances[i].GetInstanceID()}) from prefab {prefabs[i].name} " +
				//           $"({prefabs[i].GetInstanceID()}), parent: {m_Parent.name} ({m_Parent.GetInstanceID()})");
			}

			// reactivate parent, if it was active (children will remain inactive)
			if (isParentActive)
				parentObject.SetActive(true);
		}

		private void SetActive(Int32 index, Boolean active) => m_Parent.GetChild(index).gameObject.SetActive(active);

		private void SetAllActive(Boolean active)
		{
			foreach (Transform child in m_Parent)
				child.gameObject.SetActive(active);
		}
	}
}
