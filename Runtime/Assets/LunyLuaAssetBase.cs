// Copyright (C) 2021-2025 Steffen Itterheim
// Refer to included LICENSE file for terms and conditions.

using System;
using UnityEditor;
using UnityEngine;

namespace CodeSmile.Luny
{
	public abstract class LunyLuaAssetBase : ScriptableObject
	{
		[SerializeField] internal String text;
		public String Text => text;
	}
}
