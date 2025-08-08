// Copyright (C) 2021-2025 Steffen Itterheim
// Refer to included LICENSE file for terms and conditions.

using System;
using System.IO;
using UnityEditor;
using UnityEngine;

namespace Luny.Core
{
	public static class FileExt
	{
		public static Boolean TryReadAllText(String path, out String text, out String error)
		{
			try
			{
				text = File.ReadAllText(path);
				error = null;
				return true;
			}
			catch (Exception e)
			{
				text = null;
				error = e.Message;
				return false;
			}
		}

		public static Boolean TryReadAllBytes(String path, out Byte[] bytes, out String error)
		{
			try
			{
				bytes = File.ReadAllBytes(path);
				error = null;
				return true;
			}
			catch (Exception e)
			{
				bytes = null;
				error = e.Message;
				return false;
			}
		}
	}
}
