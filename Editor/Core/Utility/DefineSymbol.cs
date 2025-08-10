// Copyright (C) 2021-2025 Steffen Itterheim
// Refer to included LICENSE file for terms and conditions.

using System;
using System.Linq;
using UnityEditor;
using UnityEngine;

namespace LunyEditor.Core
{
	public static class DefineSymbol
	{
		public static String NextMinorUnityVersion
		{
			get
			{
				var version = Application.unityVersion;
				var parts = version.Split('.');
				var nextMinor = (Convert.ToInt32(parts[1]) + 1).ToString();
				return $"UNITY_{parts[0]}_{nextMinor}";
			}
		}
		public static String NextMinorUnityVersionOrNewer
		{
			get
			{
				var version = Application.unityVersion;
				var parts = version.Split('.');
				var nextMinor = (Convert.ToInt32(parts[1]) + 1).ToString();
				return $"UNITY_{parts[0]}_{nextMinor}_OR_NEWER";
			}
		}

		public static String MajorMinorUnityVersion
		{
			get
			{
				var version = Application.unityVersion;
				var parts = version.Split('.');
				return $"UNITY_{parts[0]}_{parts[1]}";
			}
		}

		public static String MajorMinorUnityVersionOrNewer
		{
			get
			{
				var version = Application.unityVersion;
				var parts = version.Split('.');
				return $"UNITY_{parts[0]}_{parts[1]}_OR_NEWER";
			}
		}

		public static String MajorMinorReleaseUnityVersion
		{
			get
			{
				var version = Application.unityVersion;
				var parts = version.Split('.');
				var release = new String(parts[2].TakeWhile(c => !Char.IsLetter(c)).ToArray());
				return $"UNITY_{parts[0]}_{parts[1]}_{release}";
			}
		}

		public static String MajorMinorReleaseUnityVersionOrNewer
		{
			get
			{
				var version = Application.unityVersion;
				var parts = version.Split('.');
				var release = new String(parts[2].TakeWhile(c => !Char.IsLetter(c)).ToArray());
				return $"UNITY_{parts[0]}_{parts[1]}_{release}_OR_NEWER";
			}
		}
	}
}
