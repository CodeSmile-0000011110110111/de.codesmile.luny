// Copyright (C) 2021-2025 Steffen Itterheim
// Refer to included LICENSE file for terms and conditions.

using System;
using System.IO;
using System.Threading.Tasks;
using UnityEditor;
using UnityEngine;

namespace CodeSmile
{
	public static class FileUtil
	{
		public static async Task<String> TryReadAllTextAsync(String fullPath, Boolean logErrors = false)
		{
			String text = null;
			try { text = await File.ReadAllTextAsync(fullPath); }
			catch (Exception e)
			{
				if (logErrors)
					Debug.LogException(e);
			}
			return text;
		}

		public static String TryReadAllText(String fullPath, Boolean logErrors = false)
		{
			String text = null;
			try { text = File.ReadAllText(fullPath); }
			catch (Exception e)
			{
				if (logErrors)
					Debug.LogException(e);
			}
			return text;
		}

		public static async Task<Byte[]> TryReadAllBytesAsync(String fullPath, Boolean logErrors = false)
		{
			Byte[] bytes = null;
			try { bytes = await File.ReadAllBytesAsync(fullPath); }
			catch (Exception e)
			{
				if (logErrors)
					Debug.LogException(e);
			}
			return bytes;
		}

		public static Byte[] TryReadAllBytes(String fullPath, Boolean logErrors = false)
		{
			Byte[] bytes = null;
			try { bytes = File.ReadAllBytes(fullPath); }
			catch (Exception e)
			{
				if (logErrors)
					Debug.LogException(e);
			}
			return bytes;
		}
	}
}
