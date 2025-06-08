// Copyright (C) 2021-2025 Steffen Itterheim
// Refer to included LICENSE file for terms and conditions.

using System;
using UnityEditor;
using UnityEngine;

namespace CodeSmile.Luny
{
	[Flags]
	public enum LuaLibraryFlags
	{
		// bit spacing is to maintain alphabetic sort order if libraries get added in the future
		Basic = 1 << 2,
		Bitwise = 1 << 5,
		Coroutine = 1 << 8,
		Debug = 1 << 11,
		IO = 1 << 14,
		Math = 1 << 17,
		Module = 1 << 20,
		OS = 1 << 23,
		String = 1 << 26,
		Table = 1 << 29,
	}
}
