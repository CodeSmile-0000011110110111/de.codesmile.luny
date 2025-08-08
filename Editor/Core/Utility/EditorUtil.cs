// Copyright (C) 2021-2025 Steffen Itterheim
// Refer to included LICENSE file for terms and conditions.

using System;
using System.Reflection;
using UnityEditor;
using UnityEngine;
using Object = System.Object;

namespace CodeSmileEditor
{
	public static class EditorUtil
	{
		private static MethodInfo s_TryGetActiveFolderPath;

		public static String ProjectWindow_TryGetActiveFolderPath()
		{
			if (s_TryGetActiveFolderPath == null)
			{
				s_TryGetActiveFolderPath = typeof(ProjectWindowUtil).GetMethod("TryGetActiveFolderPath",
					BindingFlags.Static | BindingFlags.NonPublic);
			}

			var args = new Object[] { null };
			s_TryGetActiveFolderPath.Invoke(null, args);
			return (String)args[0];
		}
	}
}
