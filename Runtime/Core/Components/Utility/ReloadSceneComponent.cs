// Copyright (C) 2021-2025 Steffen Itterheim
// Refer to included LICENSE file for terms and conditions.

using System;
using System.Collections;
using UnityEditor;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace Luny.Core.Utility
{
	[DisallowMultipleComponent]
	public sealed class ReloadSceneComponent : MonoBehaviour
	{
		public Boolean m_ClickToReloadScene;

		private void OnValidate()
		{
			if (m_ClickToReloadScene)
			{
				m_ClickToReloadScene = false;
				StartCoroutine(Reload());
			}
		}

		private IEnumerator Reload()
		{
			yield return null;

			SceneManager.LoadScene(SceneManager.GetActiveScene().name);
		}
	}
}
