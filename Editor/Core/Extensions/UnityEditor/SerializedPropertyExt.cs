// Copyright (C) 2021-2025 Steffen Itterheim
// Refer to included LICENSE file for terms and conditions.

using System;
using UnityEditor;
using UnityEngine;

namespace LunyEditor.Core
{
	public static class SerializedPropertyExt
	{
		public static T[] ToArray<T>(this SerializedProperty property)
		{
			if (property.isArray == false)
				return Array.Empty<T>();

			var array = new T[property.arraySize];
			for (var i = 0; i < property.arraySize; i++)
				array[i] = (T)property.GetArrayElementAtIndex(i).boxedValue;
			return array;
		}
	}
}
