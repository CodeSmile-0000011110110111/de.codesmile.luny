// Copyright (C) 2021-2025 Steffen Itterheim
// Refer to included LICENSE file for terms and conditions.

using UnityEngine;

namespace CodeSmile.Luny
{
	public sealed class LunyScriptRunnerRegistry : MonoBehaviour
	{
		private void Awake()
		{
			hideFlags = HideFlags.HideAndDontSave | HideFlags.HideInInspector;
		}

	}
}
