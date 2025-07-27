// Copyright (C) 2021-2025 Steffen Itterheim
// Refer to included LICENSE file for terms and conditions.

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
		private LunyGameObject m_LunyGameObject;
		public ILunyRuntime Luny => LunyRuntime.Singleton;
		private ILunyRuntimeInternal LunyInternal => (ILunyRuntimeInternal)LunyRuntime.Singleton;
		/// <summary>
		/// The LunyGameObject instance that wraps this GameObject for use with Luny scripts.
		/// </summary>
		public ILunyGameObject LunyGameObject => m_LunyGameObject ??= new LunyGameObject(Luny.RuntimeLua, gameObject);

		private void Awake()
		{
			hideFlags = HideFlags.HideAndDontSave | HideFlags.HideInInspector;

			LunyInternal.OnDestroyLunyRuntime += OnDestroyLunyRuntime;
		}

		private void OnDestroy()
		{
			UnregisterLunyOnDestroyEvent();
			InvokeAllRunnersOnBeforeDestroy();

			m_LunyGameObject?.Dispose();
			m_LunyGameObject = null;
		}

		private void OnDestroyLunyRuntime()
		{
			UnregisterLunyOnDestroyEvent();
			InvokeAllRunnersOnBeforeDestroy();
		}

		private void UnregisterLunyOnDestroyEvent()
		{
			if (LunyInternal != null)
				LunyInternal.OnDestroyLunyRuntime -= OnDestroyLunyRuntime;
		}

		private void InvokeAllRunnersOnBeforeDestroy()
		{
			// make all runners call OnDestroy first before invalidating the LunyGameObject instance
			if (TryGetComponent(out LunyScriptCoordinator coordinator))
				coordinator.InvokeAllRunnersOnBeforeDestroy();
		}
	}
}
