// Copyright (C) 2021-2025 Steffen Itterheim
// Refer to included LICENSE file for terms and conditions.

using System;
using System.Collections.Generic;
using UnityEditor;
using UnityEditor.SceneManagement;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace CodeSmile.Components
{
	[DisallowMultipleComponent]
	public sealed class ShowHiddenGameObjectsInScene : MonoBehaviour
	{
#if UNITY_EDITOR
		[SerializeField] private Boolean m_ShowHidden;
		[SerializeField] [ReadOnlyField] private List<HiddenObject> m_HiddenObjects = new();

		private Boolean m_IsShowingHidden;

		private void OnValidate()
		{
			if (m_ShowHidden != m_IsShowingHidden)
			{
				m_IsShowingHidden = m_ShowHidden;

				var activeScene = SceneManager.GetActiveScene();
				if (m_ShowHidden)
				{
					if (activeScene.isLoaded)
					{
						EditorSceneManager.SaveScene(activeScene);
						foreach (var go in activeScene.GetRootGameObjects())
							ShowHiddenObjects(go);
					}
				}
				else
				{
					foreach (var hiddenObject in m_HiddenObjects)
						HideHiddenObject(hiddenObject);

					m_HiddenObjects.Clear();
					EditorSceneManager.SaveScene(activeScene);

					EditorApplication.delayCall += () =>
						EditorSceneManager.OpenScene(EditorSceneManager.GetActiveScene().path, OpenSceneMode.Single);
				}
			}
		}

		private void ShowHiddenObjects(GameObject go)
		{
			if (go.hideFlags != HideFlags.None)
			{
				m_HiddenObjects.Add(new HiddenObject { ObjectReference = go, OriginalHideFlags = go.hideFlags });
				Debug.Log($"Showing hidden object: {go.name} (ID:{go.GetInstanceID()}) with HideFlags: {go.hideFlags}");
				go.hideFlags = HideFlags.None;
			}

			for (var i = 0; i < go.transform.childCount; i++)
				ShowHiddenObjects(go.transform.GetChild(i).gameObject);
		}

		private void HideHiddenObject(HiddenObject hiddenObject)
		{
			var go = hiddenObject.ObjectReference;
			if (go != null && go.hideFlags != HideFlags.None)
			{
				go.hideFlags = hiddenObject.OriginalHideFlags;
				Debug.Log($"Hiding hidden object: {go.name} (ID:{go.GetInstanceID()}) with HideFlags: {go.hideFlags}");
			}
		}

		[Serializable]
		private class HiddenObject
		{
			public GameObject ObjectReference;
			public HideFlags OriginalHideFlags;
		}
#else
		private void Awake() => Destroy(gameObject);
#endif
	}
}
