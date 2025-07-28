// Copyright (C) 2021-2025 Steffen Itterheim
// Refer to included LICENSE file for terms and conditions.

using System;
using UnityEditor;
using UnityEngine;
using UnityEngine.Scripting;

namespace CodeSmile.Luny
{
	[Preserve]
	public sealed class LunyException : Exception
	{
		[Preserve] public LunyException(String message)
			: base(message) {}

		[Preserve] public LunyException(String message, Exception innerException)
			: base(message, innerException) {}
	}
}
