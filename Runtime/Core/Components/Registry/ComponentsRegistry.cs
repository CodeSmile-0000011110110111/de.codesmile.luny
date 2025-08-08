// Copyright (C) 2021-2025 Steffen Itterheim
// Refer to included LICENSE file for terms and conditions.

using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using UnityEditor;
using UnityEngine;
using Object = System.Object;

namespace Luny.Core.Components
{
	/// <summary>
	///     Keeps references to components by type to avoid making each individual type a singleton of its own.
	///     Due to this, ComponentsRegistry does not handle multiple components of the same type.
	/// </summary>
	[DisallowMultipleComponent]
	public sealed class ComponentsRegistry : MonoBehaviour
	{
		/// <summary>
		///     Event raised when assignment occurs, including null.
		/// </summary>
		public static event Action<Type, Component> OnComponentAssigned;

		private static Dictionary<Type, Component> s_Components = new();
		private static Dictionary<Type, List<TaskCompletionSource<Object>>> s_AwaitingAssignmentSources = new();

		/// <summary>
		///     Get a component from the registry. Returns null if no such component is currently registered.
		/// </summary>
		/// <remarks>
		///     CAUTION: Do NOT call Get<T> from Awake to avoid execution order issues. Get in OnEnable or Start instead!
		/// </remarks>
		/// <typeparam name="T"></typeparam>
		/// <returns></returns>
		public static T Get<T>() where T : Component =>
			s_Components.TryGetValue(typeof(T), out var component) ? component as T : null;

		/// <summary>
		///     Gets a component from the registry, awaitable.
		/// </summary>
		/// <remarks>
		///     Caution: If the component is never assigned the awaitables will wait forever!
		/// </remarks>
		/// <typeparam name="T"></typeparam>
		/// <returns></returns>
		public static async Task<T> GetAsync<T>() where T : Component
		{
			// if already assigned, return instantly
			if (s_Components.TryGetValue(typeof(T), out var component))
				return component as T;

			// create entry for type in awaitables
			if (s_AwaitingAssignmentSources.ContainsKey(typeof(T)) == false)
				s_AwaitingAssignmentSources[typeof(T)] = new List<TaskCompletionSource<Object>>();

			// add a new completion source
			var tcs = new TaskCompletionSource<Object>();
			s_AwaitingAssignmentSources[typeof(T)].Add(tcs);

			// FIXME: add a timeout to TCS

			// await here so the result can be cast to T
			return await tcs.Task as T;
		}

		/// <summary>
		///     Registers or replaces the currently registered component of the same type.
		/// </summary>
		/// <remarks>
		///     CAUTION: Register components preferably in Awake to avoid execution order issues. Get in OnEnable or Start.
		/// </remarks>
		/// <param name="component"></param>
		/// <typeparam name="T"></typeparam>
		public static void Set(Component component)
		{
			var type = component.GetType();
			s_Components[type] = component;
			OnComponentAssigned?.Invoke(type, component);
			ProcessAssignmentAwaitables(type, component);
		}

		/// <summary>
		///     Sets the reference of a specific type to null.
		/// </summary>
		/// <param name="type"></param>
		public static void Unset(Type type)
		{
			s_Components[type] = null;
			OnComponentAssigned?.Invoke(type, null);
		}

		/// <summary>
		///     Sets the reference of a specific type to null.
		/// </summary>
		/// <param name="type"></param>
		public static void Unset<T>() where T : Component
		{
			var type = typeof(T);
			s_Components[type] = null;
			OnComponentAssigned?.Invoke(type, null);
		}

		private static void ProcessAssignmentAwaitables<T>(Type componentType, T component) where T : Component
		{
			if (s_AwaitingAssignmentSources.TryGetValue(componentType, out var awaitables))
			{
				foreach (var completionSource in awaitables)
					completionSource?.SetResult(component);

				s_AwaitingAssignmentSources.Remove(componentType);
			}
		}

#if UNITY_EDITOR
		[RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.SubsystemRegistration)]
		private static void ResetStaticFields()
		{
			s_Components = new Dictionary<Type, Component>();
			s_AwaitingAssignmentSources = new Dictionary<Type, List<TaskCompletionSource<Object>>>();
			OnComponentAssigned = null;
		}

		[SerializeField] private Boolean m_ClickToLogContents;

		private void OnValidate()
		{
			if (m_ClickToLogContents)
			{
				m_ClickToLogContents = false;
				LogComponents();
			}
		}

		private void LogComponents()
		{
			if (s_Components != null)
			{
				var sb = new StringBuilder($"{nameof(ComponentsRegistry)} contains {s_Components.Count} components:\n");
				foreach (var kvp in s_Components)
				{
					var type = kvp.Key;
					var component = kvp.Value;
					sb.AppendLine($"<b>{type.Name}</b> (GO: '{component?.name}', ID: {component?.GetInstanceID()})");
				}

				Debug.Log(sb.ToString());
			}
			else
				Debug.Log("not initialized");
		}
#endif
	}
}
