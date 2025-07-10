// Copyright (C) 2021-2025 Steffen Itterheim
// Refer to included LICENSE file for terms and conditions.

using System;
using System.Collections.Generic;
using UnityEditor;
using UnityEditorInternal;
using UnityEngine;

namespace CodeSmileEditor.Luny.Generator
{
	public sealed class AssemblyDefinitionAssets
	{
		private readonly Dictionary<String, AssemblyDefinitionAsset> m_AsmDefs = new();

		public AssemblyDefinitionAsset this[String key] => m_AsmDefs.TryGetValue(key, out var value) ? value : null;

		public AssemblyDefinitionAssets()
		{
			var asmdefGuids = AssetDatabase.FindAssets("t:AssemblyDefinitionAsset");
			foreach (var asmdefGuid in asmdefGuids)
			{
				var path = AssetDatabase.GUIDToAssetPath(asmdefGuid);
				var asmdef = AssetDatabase.LoadAssetAtPath<AssemblyDefinitionAsset>(path);
				m_AsmDefs.Add(asmdef.name, asmdef);

				Debug.Log($"Asmdef: {asmdef.name} => {asmdefGuid}");
			}
		}
	}
}
