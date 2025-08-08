// Copyright (C) 2021-2025 Steffen Itterheim
// Refer to included LICENSE file for terms and conditions.

using System;
using UnityEditor;
using UnityEngine;

namespace Luny.Core.Components
{
	/// <summary>
	///     Pings (expands and highlights) the selected object.
	///     Useful mostly to ensure the hierarchy is always expanded to a specific (possibly deeply nested) object.
	/// </summary>
	[DisallowMultipleComponent]
	internal sealed class PingOnDemand : MonoBehaviour
	{
		public enum FindType
		{
			UseTarget,
			FindByName,
			FindByTag,
		}

		[Header("Target")]
		[SerializeField] private FindType m_FindType = FindType.UseTarget;
		[SerializeField] private GameObject m_Target;
		[SerializeField] private String m_FindString;

		[Header("One ping only, Vasily!")]
		[SerializeField] private Boolean m_Ping;

		private void OnValidate()
		{
			if (m_Ping)
			{
				m_Ping = false;

#if UNITY_EDITOR
				var go = FindObject();
				if (go != null)
				{
					Debug.Log($"<color=red>PING</color> {go.name}");
					EditorGUIUtility.PingObject(go);
				}
#endif
			}
		}

		private void Awake()
		{
#if !UNITY_EDITOR
			Destroy(this);
#endif
		}

		private GameObject FindObject() => m_FindType switch
		{
			FindType.UseTarget => m_Target,
			FindType.FindByName => GameObject.Find(m_FindString),
			FindType.FindByTag => GameObject.FindGameObjectWithTag(m_FindString),
			var _ => throw new ArgumentOutOfRangeException(),
		};
	}
}
