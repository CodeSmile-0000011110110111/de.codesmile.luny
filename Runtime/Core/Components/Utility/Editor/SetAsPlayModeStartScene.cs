// Copyright (C) 2021-2025 Steffen Itterheim
// Refer to included LICENSE file for terms and conditions.

using System;
using UnityEditor;
using UnityEngine;
using UnityEngine.SceneManagement;
#if UNITY_EDITOR
using EditorSceneManager = UnityEditor.SceneManagement.EditorSceneManager;
#endif

namespace Luny.Core.Components
{
	/// <summary>
	///     Sets the scene with this script in it as the PlayMode start scene. Allows to enter PlayMode with a scene other
	///     than the one currently being edited to avoid frequent scene switching for testing.
	/// </summary>
	/// <remarks>
	///     Disable either the GameObject or the component to restore default PlayMode behaviour, eg start with the
	///     currently open scene.
	/// </remarks>
	[ExecuteAlways]
	[DisallowMultipleComponent]
	internal sealed class SetAsPlayModeStartScene : MonoBehaviour
	{
#if UNITY_EDITOR
		private const String MenuItemPath = "Window/CodeSmile/Use PlayMode StartScene Override";

		[MenuItem(MenuItemPath)]
		public static void TogglePlayModeStartSceneIsActiveScene() => IsStartSceneOverridden = !IsStartSceneOverridden;

		[MenuItem(MenuItemPath + " RESET")]
		public static void ResetPlayModeStartSceneIsActiveScene()
		{
			IsStartSceneOverridden = false;
			PlayModeStartScene = null;
		}

		[MenuItem(MenuItemPath, true)]
		private static Boolean ValidatePlayModeStartSceneIsActiveScene()
		{
			Menu.SetChecked(MenuItemPath, IsStartSceneOverridden);
			return true;
		}

		private const String PlayModeScenePathKey = "CodeSmile.EnterPlayModeStartScenePath";
		private const String PlayModeSceneOverrideKey = "CodeSmile.IsEnterPlayModeStartSceneOverridden";

		private static SceneAsset PlayModeStartScene
		{
			get
			{
				var scenePath = EditorPrefs.GetString(PlayModeScenePathKey, null);
				return scenePath != null ? AssetDatabase.LoadAssetAtPath<SceneAsset>(scenePath) : null;
			}
			set
			{
				var scenePath = value != null ? AssetDatabase.GetAssetPath(value) : null;
				EditorPrefs.SetString(PlayModeScenePathKey, scenePath == null ? "" : scenePath);
				UpdatePlayModeStartScene();
			}
		}

		private static Boolean IsStartSceneOverridden
		{
			get => EditorPrefs.GetBool(PlayModeSceneOverrideKey, false);
			set
			{
				EditorPrefs.SetBool(PlayModeSceneOverrideKey, value);
				UpdatePlayModeStartScene();
			}
		}

		private static void UpdatePlayModeStartScene() =>
			EditorSceneManager.playModeStartScene = IsStartSceneOverridden ? PlayModeStartScene : null;

		private Boolean m_IsPlayModeStartSceneClosing;

		private void OnEnable()
		{
			RegisterCallbacks();
			TrySetActiveSceneAsPlayModeStartScene();
		}

		private void OnDisable() => TrySetActiveSceneAsPlayModeStartScene();

		private void TrySetActiveSceneAsPlayModeStartScene()
		{
			if (m_IsPlayModeStartSceneClosing || EditorApplication.isPlayingOrWillChangePlaymode)
				return;

			if (enabled && gameObject.activeInHierarchy)
				SetPlayModeStartSceneToActiveScene();
		}

		private static void SetPlayModeStartSceneToActiveScene()
		{
			var scenePath = SceneManager.GetActiveScene().path;
			var sceneAsset = AssetDatabase.LoadAssetAtPath<SceneAsset>(scenePath);
			if (IsStartSceneOverridden && EditorSceneManager.playModeStartScene?.name != sceneAsset.name)
				Debug.Log($"<color=cyan>PlayMode StartScene is now: {sceneAsset.name}</color>");

			PlayModeStartScene = sceneAsset;
		}

		private void RegisterCallbacks()
		{
			EditorSceneManager.sceneClosing -= OnSceneClosing;
			EditorSceneManager.sceneClosing += OnSceneClosing;
			EditorSceneManager.sceneClosed -= OnSceneClosed;
			EditorSceneManager.sceneClosed += OnSceneClosed;

			EditorApplication.playModeStateChanged -= OnPlayModeStateChanged;
			EditorApplication.playModeStateChanged += OnPlayModeStateChanged;
			AssemblyReloadEvents.afterAssemblyReload -= OnAfterAssemblyReload;
			AssemblyReloadEvents.afterAssemblyReload += OnAfterAssemblyReload;
		}

		private void UnregisterCallbacks()
		{
			EditorSceneManager.sceneClosing -= OnSceneClosing;
			EditorSceneManager.sceneClosed -= OnSceneClosed;
			EditorApplication.playModeStateChanged -= OnPlayModeStateChanged;
			AssemblyReloadEvents.afterAssemblyReload -= OnAfterAssemblyReload;
		}

		private void OnSceneClosing(Scene scene, Boolean removingscene) => m_IsPlayModeStartSceneClosing =
			m_IsPlayModeStartSceneClosing || EditorSceneManager.playModeStartScene?.name == scene.name;

		private void OnSceneClosed(Scene scene)
		{
			if (m_IsPlayModeStartSceneClosing)
				UnregisterCallbacks();
		}

		private void OnAfterAssemblyReload() => RestorePlayModeStartScene();

		private void OnPlayModeStateChanged(PlayModeStateChange state)
		{
			if (state == PlayModeStateChange.EnteredEditMode)
			{
				RegisterCallbacks();
				UpdatePlayModeStartScene();
			}
		}

		[InitializeOnLoadMethod]
		private static void RestorePlayModeStartScene() => UpdatePlayModeStartScene();
#else
		private void Awake() => Destroy(this);
#endif
	}
}
