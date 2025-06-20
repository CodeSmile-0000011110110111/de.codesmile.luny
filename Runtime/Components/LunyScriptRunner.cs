// Copyright (C) 2021-2025 Steffen Itterheim
// Refer to included LICENSE file for terms and conditions.

using System;
using UnityEngine;

namespace CodeSmile.Luny
{
	public sealed class LunyScriptRunner : MonoBehaviour
	{
		private void Awake()
		{
			hideFlags = HideFlags.HideAndDontSave| HideFlags.HideInInspector;
		}
	}
}
