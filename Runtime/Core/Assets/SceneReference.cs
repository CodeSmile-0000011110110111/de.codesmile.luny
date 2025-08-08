// Copyright (C) 2021-2025 Steffen Itterheim
// Refer to included LICENSE file for terms and conditions.

using System;
using System.Collections.Generic;
using System.Linq;
using UnityEditor;
using UnityEngine;
using UnityEngine.SceneManagement;
using Object = System.Object;

namespace Luny.Core
{
	/// <summary>
	///     Represents a SceneAsset at runtime by serializing only the scene name and path at runtime, while in the editor
	///     it works with a SceneAsset reference. Allows drag & drop of scene assets in the Inspector.
	/// </summary>
	[Serializable]
	public sealed class SceneReference : IEquatable<SceneReference>
	{
		[SerializeField] [HideInInspector] private String m_SceneName;
		[SerializeField] [HideInInspector] private String m_ScenePath;

		/// <summary>
		///     The scene name of the assigned SceneAsset.
		/// </summary>
		public String SceneName => m_SceneName;
		/// <summary>
		///     The path to the scene.
		/// </summary>
		public String ScenePath => m_ScenePath;
		/// <summary>
		///     Returns the (runtime) Scene instance using the scene's path.
		/// </summary>
		public Scene RuntimeScene => SceneManager.GetSceneByPath(m_ScenePath);
		/// <summary>
		///     Is true if the scene path is valid.
		/// </summary>
		public Boolean IsValid => RuntimeScene.IsValid();

		/// <summary>
		///     equality operator
		/// </summary>
		/// <param name="left"></param>
		/// <param name="right"></param>
		/// <returns></returns>
		public static Boolean operator ==(SceneReference left, SceneReference right) => Equals(left, right);

		/// <summary>
		///     inequality operator
		/// </summary>
		/// <param name="left"></param>
		/// <param name="right"></param>
		/// <returns></returns>
		public static Boolean operator !=(SceneReference left, SceneReference right) => !Equals(left, right);

		/// <summary>
		///     Creates a new instance.
		/// </summary>
		public SceneReference()
		{
#if UNITY_EDITOR
			// no need to unsubscribe these events
			PostProcessor.OnSceneAssetChanged += OnValidate;
			EditorApplication.playModeStateChanged += OnPlayModeStateChanged;
#endif
		}

		/// <summary>
		///     Creates a new instance from a Scene struct.
		/// </summary>
		/// <param name="scene"></param>
		public SceneReference(Scene scene)
		{
			m_SceneName = scene.name;
			m_ScenePath = scene.path;
		}

		public Boolean Equals(SceneReference other)
		{
			if (ReferenceEquals(null, other))
				return false;
			if (ReferenceEquals(this, other))
				return true;

			return m_ScenePath == other.m_ScenePath;
		}

		/// <summary>
		///     Call this from the MonoBehaviour that owns the SceneReference. Call it in OnValidate to ensure
		///     the SceneName is always in sync with the SceneAsset.
		/// </summary>
		public void OnValidate()
		{
#if UNITY_EDITOR
			SceneAsset = m_SceneAsset;

			if (m_ScenePath != null)
			{
				var existsInBuildScenes = false;
				var buildScenes = EditorBuildSettings.scenes;
				foreach (var buildScene in buildScenes)
				{
					if (buildScene.enabled && buildScene.path.ToLower() == m_ScenePath.ToLower())
					{
						existsInBuildScenes = true;
						break;
					}
				}

				// TODO: auto-add to build index? should have an Inspector button for that
				if (existsInBuildScenes == false)
					Debug.LogWarning($"FYI: Scene '{m_SceneName}' is not in the build index yet or inactive.");
			}
#endif
		}

		public override String ToString() => $"{nameof(SceneReference)}({m_SceneName})";

		public override Boolean Equals(Object obj) =>
			ReferenceEquals(this, obj) || obj is SceneReference other && Equals(other);

		public override Int32 GetHashCode() => m_ScenePath != null ? m_ScenePath.GetHashCode() : 0;

#if UNITY_EDITOR
		[SerializeField] private SceneAsset m_SceneAsset;

		/// <summary>
		///     Creates a new instance from a SceneAsset (editor-only).
		/// </summary>
		/// <param name="sceneAsset"></param>
		public SceneReference(SceneAsset sceneAsset) => SceneAsset = sceneAsset;

		/// <summary>
		///     The SceneAsset reference (editor-only).
		/// </summary>
		public SceneAsset SceneAsset
		{
			get => m_SceneAsset;
			set
			{
				m_SceneAsset = value;
				m_SceneName = m_SceneAsset != null ? m_SceneAsset.name : null;
				m_ScenePath = m_SceneAsset != null ? AssetDatabase.GetAssetPath(SceneAsset) : null;
			}
		}

		private void OnPlayModeStateChanged(PlayModeStateChange state)
		{
			// resubscribe when entering playmode since somehow we lose the connection
			PostProcessor.OnSceneAssetChanged -= OnValidate;
			PostProcessor.OnSceneAssetChanged += OnValidate;

			if (state == PlayModeStateChange.ExitingEditMode || state == PlayModeStateChange.EnteredEditMode)
				OnValidate();
		}

		internal class PostProcessor : AssetPostprocessor
		{
			internal static event Action OnSceneAssetChanged;

			[RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.SubsystemRegistration)]
			private static void ResetStaticFields() => OnSceneAssetChanged = null;

			private static void OnPostprocessAllAssets(String[] importedAssets, String[] deletedAssets, String[] movedAssets,
				String[] movedFromAssetPaths)
			{
				var deleteCount = deletedAssets.Length;
				var moveCount = movedAssets.Length;
				if (deleteCount > 0 || moveCount > 0)
					CheckSceneReferenceUpdates(deletedAssets.Concat(movedAssets));
			}

			private static void CheckSceneReferenceUpdates(IEnumerable<String> assets)
			{
				foreach (var asset in assets)
				{
					if (asset.EndsWith(".unity"))
					{
						// some scene changed, thus check all
						// we don't care about directing the change, it happens rarely
						OnSceneAssetChanged?.Invoke();
						break;
					}
				}
			}
		}
#endif
	}
}
