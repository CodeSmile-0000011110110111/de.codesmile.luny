// Copyright (C) 2021-2025 Steffen Itterheim
// Refer to included LICENSE file for terms and conditions.

using System;
using UnityEditor;
using UnityEngine;

namespace CodeSmile.Luny.Components
{
	public class LunyScript : MonoBehaviour
	{
		public LunyRuntimeLuaAsset Script;
		public Boolean UseModdingContext;
		public static GameObject CreateGameObject() => throw new NotImplementedException();
	}
}
