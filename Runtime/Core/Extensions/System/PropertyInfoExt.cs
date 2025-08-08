// Copyright (C) 2021-2025 Steffen Itterheim
// Refer to included LICENSE file for terms and conditions.

using System;
using System.Reflection;
using UnityEditor;
using UnityEngine;

namespace Luny.Core
{
	public static class PropertyInfoExt
	{
		public static Boolean IsIndexer(this PropertyInfo property) => property.GetIndexParameters().Length > 0;
	}
}
