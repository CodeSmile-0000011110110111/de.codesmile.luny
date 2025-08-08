﻿// Copyright (C) 2021-2025 Steffen Itterheim
// Refer to included LICENSE file for terms and conditions.

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using Object = UnityEngine.Object;

namespace CodeSmile.Collections
{
	public abstract class AssetCollection<T> : ScriptableObject, IEnumerable<T> where T : Object
	{
		[SerializeField] private T[] m_Assets;
		public T this[Int32 index] => m_Assets[Mathf.Clamp(index, 0, Count)];

		public T[] Assets => m_Assets;
		public Int32 Count => m_Assets != null ? m_Assets.Length : 0;
		public IEnumerator<T> GetEnumerator() => m_Assets.GetEnumerator<T>();
		IEnumerator IEnumerable.GetEnumerator() => m_Assets.GetEnumerator();

		public Int32 IndexOf(T actorAsset) => Array.IndexOf(m_Assets, actorAsset);
	}
}
