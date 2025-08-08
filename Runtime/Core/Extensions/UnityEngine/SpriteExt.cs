// Copyright (C) 2021-2025 Steffen Itterheim
// Refer to included LICENSE file for terms and conditions.

using System;
using UnityEditor;
using UnityEngine;

namespace Luny.Core
{
	public static class SpriteExt
	{
		public static Sprite Create(Texture2D texture, Vector2 pivot, Single maxSize)
		{
			var texRect = new Rect(0, 0, texture.width, texture.height);
			var largerDimension = texture.width >= texture.height ? texture.width : texture.height;
			var pixelsPerUnit = Mathf.Max(100 / maxSize * largerDimension, 100);

			var sprite = Sprite.Create(texture, texRect, pivot, pixelsPerUnit, 0, SpriteMeshType.FullRect);
			sprite.name = texture.name;
			return sprite;
		}
	}
}
