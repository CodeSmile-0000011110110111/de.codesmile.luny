// Copyright (C) 2021-2025 Steffen Itterheim
// Refer to included LICENSE file for terms and conditions.

using System;
using UnityEditor;
using UnityEngine;

namespace CodeSmile.Luny
{
	public class LunyScript : MonoBehaviour
	{
		public LunyRuntimeLuaAsset Script;
		public Boolean UseModdingContext;
		public static GameObject CreateLunyScriptObject() => new(nameof(LunyScript), typeof(LunyScript));

		private void Reset()
		{
			// TryAssignMatchingScriptAsset();
			// OnReset();
		}

		private async void Awake()
		{
			// m_LunyRef = gameObject.GetOrAddComponent<LunyReference>();

			OnAwake(); // for user override in subclass, to avoid having user call base.Awake (or forgetting to do so)

			// script may have been run through other exec paths
			// if (m_BScript == null)
			// 	await DoScriptAndRun();
		}
		/// <summary>
		/// Override this instead of Reset().
		/// </summary>
		protected virtual void OnReset() {}

		/// <summary>
		/// Override this instead of Awake().
		/// </summary>
		protected virtual void OnAwake() {}

		/// <summary>
		/// Override this to be notified when the script was loaded and you need to make changes (ie get/set Lua variables)
		/// before the script's Awake() function runs.
		/// </summary>
		protected virtual void OnBeforeScriptAwake() {}

		/// <summary>
		/// This gets called when there was any error loading and running the script.
		/// </summary>
		/// <remarks>Is not called when the supplied script was null or empty. In that case a warning log appears in the console.</remarks>
		protected virtual void OnRunScriptError() {}

		/// <summary>
		/// Must call base.OnEnable when overridden!
		/// </summary>
		protected virtual void OnEnable() => UpdateScriptRunnerEnabledState();

		/// <summary>
		/// Must call base.OnDisable when overridden!
		/// </summary>
		protected virtual void OnDisable() => UpdateScriptRunnerEnabledState();

		/// <summary>
		/// Must call base.OnDestroy when overridden!
		/// </summary>
		protected virtual void OnDestroy() {}

		private void UpdateScriptRunnerEnabledState()
		{
			// if (TryGetScriptRunner(out var runner))
			// 	runner.enabled = enabled;
		}

	}
}
