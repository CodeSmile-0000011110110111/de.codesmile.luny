// Copyright (C) 2021-2025 Steffen Itterheim
// Refer to included LICENSE file for terms and conditions.

using System;
using System.Collections.Generic;
using System.IO;
using UnityEditor;
using UnityEditorInternal;
using UnityEngine;
using Object = UnityEngine.Object;

namespace LunyEditor.Core
{
	public class AssetCollection<T> where T : Object
	{
		private static Dictionary<String, T> m_Assets;

		public T this[String key] => m_Assets.TryGetValue(key, out var value) ? value : null;

		public AssetCollection()
		{
			if (m_Assets == null)
			{
				m_Assets = new Dictionary<String, T>();

				var assetGuids = AssetDatabase.FindAssets($"t:{typeof(T).Name}");
				foreach (var assetGuid in assetGuids)
				{
					var path = AssetDatabase.GUIDToAssetPath(assetGuid);
					var asset = AssetDatabase.LoadAssetAtPath<T>(path);
					Debug.Assert(asset != null,
						$"Asset load failed! Don't use within Start/StopAssetEditing, [InitializeOnLoad], static ctor! Path: {path}");

					m_Assets.Add(path, asset);
				}
			}
		}

		public T TryGetAssetByFilename(String filename)
		{
			foreach (var assetPath in m_Assets.Keys)
			{
				if (filename == Path.GetFileName(assetPath) || filename == Path.GetFileNameWithoutExtension(assetPath))
					return m_Assets[assetPath];
			}
			return null;
		}

		public T[] TryGetAssetsByName(String name)
		{
			var foundAssets = new List<T>();
			foreach (var asset in m_Assets.Values)
			{
				if (name == asset.name)
					foundAssets.Add(asset);
			}
			return foundAssets.ToArray();
		}
	}

	public sealed class AssemblyDefinitionAssets : AssetCollection<AssemblyDefinitionAsset> {}
}
