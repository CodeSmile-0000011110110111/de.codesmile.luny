// Copyright (C) 2021-2025 Steffen Itterheim
// Refer to included LICENSE file for terms and conditions.

using System;
using UnityEditor;
using UnityEngine;

namespace CodeSmile.Luny
{
	/// <summary>
	///     Provides access to Luny and LunyGameObject references.
	/// </summary>
	/// <remarks>
	///     This component is automatically added to any GameObject created or accessed by Luny scripts, and any object
	///     with a LunyScript component.
	/// </remarks>
	[AddComponentMenu("GameObject/")] // Do not list in "Add Component" menu
	[DisallowMultipleComponent]
	public sealed class LunyReference : MonoBehaviour
	{
		private ILunyRuntime m_LunyRuntime;
		private LunyGameObject m_LunyGameObject;
		private Boolean m_IsLunyRuntimeAssigned;
		public ILunyRuntime LunyRuntime => m_IsLunyRuntimeAssigned ? m_LunyRuntime : m_LunyRuntime = GetOrAddLunyRuntime();
		/// <summary>
		/// The LunyGameObject instance that wraps this GameObject for use with Luny scripts.
		/// </summary>
		public LunyGameObject LunyGameObject => m_LunyGameObject ??= new LunyGameObject(gameObject);

		private void Awake()
		{
			hideFlags = HideFlags.HideAndDontSave | HideFlags.HideInInspector;

			m_LunyRuntime = GetOrAddLunyRuntime();
			(m_LunyRuntime as ILunyRuntimeInternal).OnDestroyLunyRuntime += OnDestroyLunyRuntime;
		}

		private void OnDestroy()
		{
			UnregisterLunyOnDestroyEvent();
			InvokeAllRunnersOnBeforeDestroy();

			m_LunyGameObject?.Dispose();
			m_LunyGameObject = null;
			m_LunyRuntime = null;
		}

		private void OnDestroyLunyRuntime()
		{
			UnregisterLunyOnDestroyEvent();
			InvokeAllRunnersOnBeforeDestroy();
		}

		private void UnregisterLunyOnDestroyEvent()
		{
			if (m_LunyRuntime != null)
				(m_LunyRuntime as ILunyRuntimeInternal).OnDestroyLunyRuntime -= OnDestroyLunyRuntime;
		}

		private void InvokeAllRunnersOnBeforeDestroy()
		{
			// make all runners call OnDestroy first before invalidating the LunyGameObject instance
			if (TryGetComponent(out LunyScriptCoordinator coordinator))
				coordinator.InvokeAllRunnersOnBeforeDestroy();
		}

		private ILunyRuntime GetOrAddLunyRuntime()
		{
			m_IsLunyRuntimeAssigned = true;
			var luny = Luny.LunyRuntime.Singleton; // is valid even in Awake because of Luny's DefaultExecutionOrder attribute
			if (luny == null)
			{
				LunyLogger.LogWarn($"Missing Luny component in scene: {gameObject.scene.name}. Creating a default instance.");
				luny = Luny.LunyRuntime.CreateLunyObject().GetComponent<LunyRuntime>();
			}

			return luny;
		}
	}
}
