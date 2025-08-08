// Copyright (C) 2021-2025 Steffen Itterheim
// Refer to included LICENSE file for terms and conditions.

using System;
using UnityEditor;
using UnityEngine;

namespace Luny.Core.UnityEngine
{
	public static class Texture2DExt
	{
		public static Texture2D CreateWithImageData(Byte[] data, Boolean pointFilter = true)
		{
			var texture = new Texture2D(2, 2, TextureFormat.ARGB32, false);
			texture.filterMode = pointFilter ? FilterMode.Point : FilterMode.Bilinear;

			const Boolean DiscardMainMemoryCopy = true;
			if (false == texture.LoadImage(data, DiscardMainMemoryCopy))
				texture = null;

			return texture;
		}
	}
}
