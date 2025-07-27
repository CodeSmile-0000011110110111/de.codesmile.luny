// Copyright (C) 2021-2025 Steffen Itterheim
// Refer to included LICENSE file for terms and conditions.

using UnityEditor;
using UnityEngine;

namespace CodeSmile.Luny
{
	public sealed class LunyGameObject
	{
		private GameObject m_UnityGameObject;
		private ILuaUnityEngineGameObject m_LuaGameObject;

		public GameObject UnityGameObject
		{
			get => m_UnityGameObject;
			set => m_UnityGameObject = value;
		}
		public ILuaUnityEngineGameObject LuaGameObject => m_LuaGameObject;

		public LunyGameObject(GameObject gameObject) => m_UnityGameObject = gameObject;

		internal void Dispose() => m_UnityGameObject = null;
	}
}
