// Copyright (C) 2021-2025 Steffen Itterheim
// Refer to included LICENSE file for terms and conditions.

using UnityEngine;

namespace CodeSmile.Luny
{
	public sealed class LunyGameObject
	{
		public LunyGameObject(GameObject gameObject)
		{
			m_UnityGameObject = gameObject;
		}

		private GameObject m_UnityGameObject;
		public GameObject GameObject
		{
			get => m_UnityGameObject;
			set => m_UnityGameObject = value;
		}

		internal void Dispose()
		{
			m_UnityGameObject = null;
		}
	}
}
