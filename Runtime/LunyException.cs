// Copyright (C) 2021-2025 Steffen Itterheim
// Refer to included LICENSE file for terms and conditions.

using System;
using UnityEditor;
using UnityEngine;

namespace CodeSmile.Luny
{
	public sealed class LunyException : Exception
	{
		public LunyException(String message)
			: base(message) {}

		public LunyException(String message, Exception innerException)
			: base(message, innerException) {}
	}
}
