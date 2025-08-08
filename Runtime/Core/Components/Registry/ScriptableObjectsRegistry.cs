// Copyright (C) 2021-2025 Steffen Itterheim
// Refer to included LICENSE file for terms and conditions.

using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using UnityEditor;
using UnityEngine;
using Object = System.Object;

namespace CodeSmile.Components
{
	/// <summary>
	///     Keeps references to ScriptableObjects by type to avoid making each individual type a singleton of its own.
	///     Due to this, ScriptableObjectsRegistry does not handle multiple ScriptableObjects of the same type.
	/// </summary>
	[DisallowMultipleComponent]
	public sealed class ScriptableObjectsRegistry : MonoBehaviour
	{
		/// <summary>
		///     Event raised when assignment occurs, including null.
		/// </summary>
		public static event Action<Type, ScriptableObject> OnScriptableObjectAssigned;

		private static Dictionary<Type, ScriptableObject> s_ScriptableObjects = new();
		private static Dictionary<Type, List<TaskCompletionSource<Object>>> s_AwaitingAssignmentSources = new();

		/// <summary>
		///     Get a ScriptableObject from the registry. Returns null if no such ScriptableObject is currently registered.
		/// </summary>
		/// <remarks>
		///     CAUTION: Do NOT call Get<T> from Awake to avoid execution order issues. Get in OnEnable or Start instead!
		/// </remarks>
		/// <typeparam name="T"></typeparam>
		/// <returns></returns>
		public static T Get<T>() where T : ScriptableObject =>
			s_ScriptableObjects.TryGetValue(typeof(T), out var scriptableObject) ? scriptableObject as T : null;

		/// <summary>
		///     Gets a ScriptableObject from the registry, awaitable.
		/// </summary>
		/// <remarks>
		///     Caution: If the ScriptableObject is never assigned the awaitables will wait forever!
		/// </remarks>
		/// <typeparam name="T"></typeparam>
		/// <returns></returns>
		public static async Task<T> GetAsync<T>() where T : ScriptableObject
		{
			// if already assigned, return instantly
			if (s_ScriptableObjects.TryGetValue(typeof(T), out var scriptableObject))
				return scriptableObject as T;

			// create entry for type in awaitables
			if (s_AwaitingAssignmentSources.ContainsKey(typeof(T)) == false)
				s_AwaitingAssignmentSources[typeof(T)] = new List<TaskCompletionSource<Object>>();

			// add a new completion source
			var tcs = new TaskCompletionSource<Object>();
			s_AwaitingAssignmentSources[typeof(T)].Add(tcs);

			// await here so the result can be cast to T
			return await tcs.Task.ConfigureAwait(false) as T;
		}

		/// <summary>
		///     Registers or replaces the currently registered ScriptableObject of the same type.
		/// </summary>
		/// <remarks>
		///     CAUTION: Register ScriptableObjects preferably in Awake to avoid execution order issues. Get in OnEnable or Start.
		/// </remarks>
		/// <param name="scriptableObject"></param>
		public static void Set(ScriptableObject scriptableObject)
		{
			var type = scriptableObject.GetType();
			s_ScriptableObjects[type] = scriptableObject;
			OnScriptableObjectAssigned?.Invoke(type, scriptableObject);
			ProcessAssignmentAwaitables(scriptableObject);
		}

		/// <summary>
		///     Sets the reference to null.
		/// </summary>
		/// <param name="type"></param>
		public static void SetNull(Type type)
		{
			s_ScriptableObjects[type] = null;
			OnScriptableObjectAssigned?.Invoke(type, null);
		}

		private static void ProcessAssignmentAwaitables<T>(T scriptableObject) where T : ScriptableObject
		{
			if (s_AwaitingAssignmentSources.TryGetValue(typeof(T), out var awaitables))
			{
				foreach (var completionSource in awaitables)
					completionSource?.SetResult(scriptableObject);

				s_AwaitingAssignmentSources.Remove(typeof(T));
			}
		}

#if UNITY_EDITOR
		[RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.SubsystemRegistration)]
		private static void ResetStaticFields()
		{
			s_ScriptableObjects = new Dictionary<Type, ScriptableObject>();
			s_AwaitingAssignmentSources = new Dictionary<Type, List<TaskCompletionSource<Object>>>();
			OnScriptableObjectAssigned = null;
		}

		[SerializeField] private Boolean m_ClickToLogContents;

		private void OnValidate()
		{
			if (m_ClickToLogContents)
			{
				m_ClickToLogContents = false;
				LogScriptableObjects();
			}
		}

		private void LogScriptableObjects()
		{
			var sb = new StringBuilder($"{nameof(ScriptableObjectsRegistry)} contains:\n");
			if (s_ScriptableObjects != null)
			{
				sb.AppendLine($"{s_ScriptableObjects.Count} ScriptableObjects:");
				foreach (var kvp in s_ScriptableObjects)
				{
					var type = kvp.Key;
					var so = kvp.Value;
					var path = AssetDatabase.GetAssetPath(so);
					sb.AppendLine($"<b>{type.Name}</b> (SO: '{so?.name}', Path: {path})");
				}
			}

			Debug.Log(sb.ToString());
		}
#endif
	}
}
