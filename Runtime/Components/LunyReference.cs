// Copyright (C) 2021-2025 Steffen Itterheim
// Refer to included LICENSE file for terms and conditions.

using Lua;
using UnityEditor;
using UnityEngine;

namespace Luny
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
		private LuaValue m_LuaGameObject;
		private ILunyRuntimeInternal LunyRuntime => (ILunyRuntimeInternal)Luny.LunyRuntime.Singleton;

		/// <summary>
		/// The LunyGameObject instance that wraps this GameObject for use with Luny scripts.
		/// </summary>
		public LuaValue LuaGameObject => m_LuaGameObject.Type != LuaValueType.Nil
			? m_LuaGameObject
			: m_LuaGameObject = LunyRuntime!.Lua.ObjectFactory.Bind(gameObject);

		private void Awake()
		{
			hideFlags = HideFlags.HideAndDontSave | HideFlags.HideInInspector;

			LunyRuntime.OnDestroyLunyRuntime += OnDestroyLunyRuntime;
		}

		private void OnDestroy()
		{
			UnregisterLunyOnDestroyEvent();
			InvokeAllRunnersOnBeforeDestroy();

			m_LuaGameObject = LuaValue.Nil;
		}

		private void OnDestroyLunyRuntime()
		{
			UnregisterLunyOnDestroyEvent();
			InvokeAllRunnersOnBeforeDestroy();
		}

		private void UnregisterLunyOnDestroyEvent()
		{
			if (LunyRuntime != null)
				LunyRuntime.OnDestroyLunyRuntime -= OnDestroyLunyRuntime;
		}

		private void InvokeAllRunnersOnBeforeDestroy()
		{
			// make all runners call OnDestroy first before invalidating the LunyGameObject instance
			if (TryGetComponent(out LunyRuntimeScriptCoordinator coordinator))
				coordinator.InvokeAllRunnersOnBeforeDestroy();
		}
	}
}
