// Copyright (C) 2021-2025 Steffen Itterheim
// Refer to included LICENSE file for terms and conditions.

using System;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

namespace Luny.Core
{
	public class TreeNode<T>
	{
		private readonly T m_Value;
		private readonly Dictionary<T, TreeNode<T>> m_Children = new();

		public TreeNode<T> this[T t] => m_Children[t];
		public TreeNode<T> Parent { get; private set; }
		public IEnumerable<TreeNode<T>> Children => m_Children.Values;
		public Int32 ChildCount => m_Children.Count;
		public T Value => m_Value;
		public TreeNode(T value) => m_Value = value;

		public bool AddChild(T value)
		{
			if (m_Children.TryGetValue(value, out var node))
				return false;

			node = new TreeNode<T>(value) { Parent = this };
			m_Children.Add(value, node);
			return true;
		}

		public TreeNode<T> GetOrAddChild(T value)
		{
			// Returns 'this' to avoid adding T to itself.
			if (value.Equals(m_Value))
				return this;

			if (m_Children.TryGetValue(value, out var node))
				return node;

			node = new TreeNode<T>(value) { Parent = this };
			m_Children.Add(value, node);
			return node;
		}

		public void VisitDepthFirst(Action<TreeNode<T>, Int32> callback, Int32 level = 0)
		{
			callback(this, level++);
			foreach (var child in m_Children.Values)
				child.VisitDepthFirst(callback, level);
		}
	}
}
