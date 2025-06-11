// Copyright (C) 2021-2025 Steffen Itterheim
// Refer to included LICENSE file for terms and conditions.

using System;
using UnityEditor;
using UnityEngine;

namespace CodeSmile.Luny
{
	public interface ILunyLuaFileSystem
	{
		Boolean ReadText(String path, out String content);
		Boolean ReadBytes(String path, out Byte[] bytes);
	}
}
