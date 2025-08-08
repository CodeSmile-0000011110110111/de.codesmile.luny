// Copyright (C) 2021-2025 Steffen Itterheim
// Refer to included LICENSE file for terms and conditions.

using System;
using System.Runtime.CompilerServices;
using UnityEditor;
using UnityEngine;

namespace Luny.Core
{
	public static class BuiltInTypesExt
	{
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static Byte TruncateToByte(this Single value, Single minValue = 0f, Single maxValue = 1f)
		{
			var normalizedValue = (value + minValue) / (maxValue - minValue);
			return (Byte)Mathf.Min(Byte.MaxValue, normalizedValue * Byte.MaxValue + 0.5f);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static Single ExpandToFloat(this Byte value, Single minValue = 0f, Single maxValue = 1f) =>
			value / (Single)Byte.MaxValue * (maxValue - minValue) + minValue;
	}
}
