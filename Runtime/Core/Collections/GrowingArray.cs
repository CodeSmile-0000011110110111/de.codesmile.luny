// Copyright (C) 2021-2025 Steffen Itterheim
// Refer to included LICENSE file for terms and conditions.

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

namespace CodeSmile.Collections
{
	public abstract class GrowingArray<T> : IEnumerable<T> where T : struct, IValidatable
	{
		private readonly Int32 m_InitialCapacity;
		private T[] m_Items;
		private Int32 m_ItemValidCount;
		private Int32 m_NextFreeIndex;
		private Int32 m_MaxSizeIncrement;

		public Int32 MaxSizeIncrement { get => m_MaxSizeIncrement; set => m_MaxSizeIncrement = value; }
		public Int32 NextIndex => m_NextFreeIndex;
		public Int32 ValidCount => m_ItemValidCount;
		public Int32 Capacity => m_Items.Length;
		public ref T this[Int32 index] => ref m_Items[index];

		public GrowingArray()
			: this(0) {}

		public GrowingArray(Int32 initialCapacity, Int32 maxSizeIncrement = 16)
		{
			m_InitialCapacity = Mathf.Max(0, initialCapacity);
			m_Items = new T[m_InitialCapacity];
			m_MaxSizeIncrement = maxSizeIncrement;
		}

		public IEnumerator<T> GetEnumerator() => m_Items.GetEnumerator() as IEnumerator<T>;
		IEnumerator IEnumerable.GetEnumerator() => m_Items.GetEnumerator();

		public ref T GetItem(Int32 index) => ref m_Items[index];

		public Int32 Add(ref T item)
		{
			var newIndex = NextIndex;
			CheckResizeArray(newIndex);

			item.IsValid = true;
			m_Items[newIndex] = item;
			m_ItemValidCount++;

			m_NextFreeIndex = FindNextFreeIndex(newIndex + 1);

			return newIndex;
		}

		public void Set(Int32 index, ref T item)
		{
			CheckResizeArray(index);

			if (index < 0 || index >= m_Items.Length)
				throw new IndexOutOfRangeException($"actor index {index} is out of range ({m_Items.Length}).");
			if (m_Items[index].IsValid)
				throw new InvalidOperationException($"Item at index {index} is valid, cannot replace with {item}");

			item.IsValid = true;
			m_Items[index] = item;
			m_ItemValidCount++;

			if (index == m_NextFreeIndex)
				m_NextFreeIndex = FindNextFreeIndex(index + 1);
		}

		public void RemoveAt(Int32 index)
		{
			m_Items[index].IsValid = false;
			m_ItemValidCount--;

			if (index < m_NextFreeIndex)
				m_NextFreeIndex = index;
		}

		public void Clear()
		{
			Array.Clear(m_Items, 0, m_Items.Length);
			m_ItemValidCount = 0;
			m_NextFreeIndex = 0;
		}

		public void ClearAndResize(Int32 resizedCapacity = -1)
		{
			Clear();

			var size = resizedCapacity >= 0 ? resizedCapacity : m_InitialCapacity;
			Array.Resize(ref m_Items, size);
		}

		private void CheckResizeArray(Int32 index)
		{
			var itemCount = m_Items.Length;
			if (index >= itemCount)
			{
				var sizeIncrement = Mathf.Clamp(itemCount * 2 - itemCount, 1, m_MaxSizeIncrement);
				Array.Resize(ref m_Items, itemCount + sizeIncrement);
				//Debug.Log($"Array {GetType().Name} grew by {sizeIncrement} to {m_Items.Length} items");

				for (var i = itemCount; i < m_Items.Length; i++)
				{
					if (m_Items[i].IsValid)
						Debug.LogError($"new item at {i} is valid: {m_Items[i].IsValid}");
				}
			}
		}

		private Int32 FindNextFreeIndex(Int32 searchStartIndex)
		{
			var freeIndex = m_ItemValidCount;
			for (var i = searchStartIndex; i < m_ItemValidCount; i++)
			{
				if (m_Items[i].IsValid == false)
				{
					freeIndex = i;
					break;
				}
			}

			return freeIndex;
		}
	}
}
