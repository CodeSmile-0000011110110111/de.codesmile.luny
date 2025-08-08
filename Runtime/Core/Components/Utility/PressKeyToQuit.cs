// Copyright (C) 2021-2025 Steffen Itterheim
// Refer to included LICENSE file for terms and conditions.

using UnityEditor;
using UnityEngine;

namespace CodeSmile.Components
{
	/// <summary>
	///     Hooks the given keycode to Application.Quit.
	/// </summary>
	/// <remarks>
	///     Builds do not support Alt+F4 so there is no way to quickly quit a build without a script like this one.
	/// </remarks>
	[DisallowMultipleComponent]
	internal sealed class PressKeyToQuit : MonoBehaviour
	{
		[Tooltip("The key that will quit if Ctrl+Alt / Cmd+Option are also held down.")]
		[SerializeField] private KeyCode m_QuitKey = KeyCode.Escape;

		private void Awake()
		{
#if UNITY_EDITOR || !(UNITY_STANDALONE_WIN || UNITY_STANDALONE_OSX || UNITY_STANDALONE_LINUX)
			Destroy(gameObject);
#endif
		}

		private void Update()
		{
			var alt = Input.GetKey(KeyCode.LeftAlt) || Input.GetKey(KeyCode.RightAlt);
			if (!alt)
				return;

			var cmd = Input.GetKey(KeyCode.LeftCommand) || Input.GetKey(KeyCode.RightCommand);
			var ctrl = Input.GetKey(KeyCode.LeftControl) || Input.GetKey(KeyCode.RightControl);
			if (!cmd && !ctrl)
				return;

			if (Input.GetKeyDown(m_QuitKey))
			{
				Debug.Log("Quitting...");
				Application.Quit();
			}
		}
	}
}
