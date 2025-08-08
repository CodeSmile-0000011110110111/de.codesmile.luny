// Copyright (C) 2021-2025 Steffen Itterheim
// Refer to included LICENSE file for terms and conditions.

using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

namespace CodeSmile
{
	public static class ArrayExt
	{
		public static IEnumerator<T> GetEnumerator<T>(this T[] array) => ((IEnumerable<T>)array).GetEnumerator();
	}
}
