// Copyright (C) 2021-2025 Steffen Itterheim
// Refer to included LICENSE file for terms and conditions.

using System;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

namespace CodeSmileEditor
{
	public interface IEditorEventReceiver {}

	public interface IInitializeOnLoadReceiver : IEditorEventReceiver
	{
		void OnLoad();
	}

	public interface IPlayModeStateChangeReceiver : IEditorEventReceiver
	{
		void OnPlayModeStateChanged(PlayModeStateChange state);
	}

	/// <summary>
	/// Dispatches editor events to ScriptableObject instances while automatically unregistering on asset deletion.
	/// </summary>
	/// <remarks>
	/// This Dispatcher eases static editor event handling for ScriptableObjects. Methods like OnEnable, OnDisable and
	/// OnDestroy are not called as expected on ScriptableObject instance when entering playmode, and particularly not when
	/// deleting the asset which makes it hard to unsubscribe at the right time.
	/// </remarks>
	public sealed class EditorEventDispatcher : ScriptableSingleton<EditorEventDispatcher>
	{
		[SerializeField] private List<ScriptableObject> m_OnLoadReceivers = new();
		[SerializeField] private List<ScriptableObject> m_PlayModeReceivers = new();

		/// <summary>
		/// Adds a ScriptableObject to reveice the event(s) defined by one of the IEditorEventReceiver interfaces.
		/// </summary>
		/// <remarks>The SO need not unsubscribe before asset deletion, this is done automatically.</remarks>
		/// <param name="so">ScriptableObject implementing one or more of IEditorEventReceiver interfaces.</param>
		/// <exception cref="ArgumentNullException"></exception>
		/// <exception cref="ArgumentException"></exception>
		public static void AddReceiver(ScriptableObject so)
		{
			if (so == null)
				throw new ArgumentNullException(nameof(so));
			if (so is not IEditorEventReceiver)
				throw new ArgumentException($"{so} does not implement one of the EditorEventDispatcher interfaces");

			var onLoadReceivers = instance.m_OnLoadReceivers;
			if (so is IInitializeOnLoadReceiver)
			{
				onLoadReceivers.Add(so);
				if (onLoadReceivers.Count == 1)
					EditorApplication.update += OnLoad;
			}

			var playModeReceivers = instance.m_PlayModeReceivers;
			if (so is IPlayModeStateChangeReceiver)
			{
				playModeReceivers.Add(so);
				if (playModeReceivers.Count == 1)
					EditorApplication.playModeStateChanged += OnPlayModeStateChanged;
			}
		}

		/// <summary>
		/// Stops the ScriptableObject from receiving all editor events.
		/// </summary>
		/// <param name="so"></param>
		public static void RemoveReceiver(ScriptableObject so)
		{
			var onLoadReceivers = instance.m_OnLoadReceivers;
			if (so is IInitializeOnLoadReceiver)
				onLoadReceivers.Remove(so);

			var playModeReceivers = instance.m_PlayModeReceivers;
			if (so is IPlayModeStateChangeReceiver)
				playModeReceivers.Remove(so);
		}

		[InitializeOnLoadMethod]
		private static void InitOnLoad()
		{
			// re-register events after domain reload

			if (instance.m_PlayModeReceivers.Count > 0)
				EditorApplication.playModeStateChanged += OnPlayModeStateChanged;
		}

		[InitializeOnLoadMethod]
		private static void OnLoad()
		{
			var onLoadReceivers = instance.m_OnLoadReceivers;
			for (var i = onLoadReceivers.Count - 1; i >= 0; i--)
			{
				if (onLoadReceivers[i] is IInitializeOnLoadReceiver receiver)
					receiver.OnLoad();
				else
					onLoadReceivers.RemoveAt(i);
			}
		}

		private static void OnPlayModeStateChanged(PlayModeStateChange state)
		{
			var playModeReceivers = instance.m_PlayModeReceivers;
			for (var i = playModeReceivers.Count - 1; i >= 0; i--)
			{
				if (playModeReceivers[i] is IPlayModeStateChangeReceiver playModeReceiver)
					playModeReceiver.OnPlayModeStateChanged(state);
				else
					playModeReceivers.RemoveAt(i);
			}
		}

		private class EditorEventAssetProcessor : AssetModificationProcessor
		{
			private static AssetDeleteResult OnWillDeleteAsset(String assetPath, RemoveAssetOptions options)
			{
				var asset = AssetDatabase.LoadAssetAtPath<ScriptableObject>(assetPath);
				RemoveReceiver(asset);

				return AssetDeleteResult.DidNotDelete;
			}
		}
	}
}
