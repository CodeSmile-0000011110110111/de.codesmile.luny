// Copyright (C) 2021-2025 Steffen Itterheim
// Refer to included LICENSE file for terms and conditions.

using System;
using UnityEditor;
using UnityEngine;

namespace CodeSmile.Collections
{
	public interface IValidatable
	{
		Boolean IsValid { get; set; }
	}
}
