// Copyright (C) 2021-2025 Steffen Itterheim
// Refer to included LICENSE file for terms and conditions.

using CodeSmile.Luny;
using System;
using System.Linq;
using UnityEditor;
using UnityEditorInternal;
using UnityEngine;

[FilePath("ProjectSettings/LunySettings.asset", FilePathAttribute.Location.ProjectFolder)]
internal sealed partial class LunyProjectSettings : ScriptableSingleton<LunyProjectSettings>
{
	[SerializeField] private LunyLuaContext m_DefaultEditorContext;
	[SerializeField] private LunyLuaContext m_DefaultRuntimeContext;
	public LunyLuaContext DefaultEditorContext => m_DefaultEditorContext;
	public LunyLuaContext DefaultRuntimeContext => m_DefaultRuntimeContext;
	private static SerializedObject GetSerializedSettings() => new(instance);

	private void Save()
	{
		Save(true);
	}

	private void Awake() => AssignDefaultContextsIfNull();

	private void AssignDefaultContextsIfNull()
	{
		var shouldFindDefaults = DefaultRuntimeContext == null || DefaultEditorContext == null;
		if (shouldFindDefaults)
		{
			var filter = $"t:{nameof(LunyLuaContext)} l:{LunyAssetLabel.DefaultLuaContext}";
			var contextGuids = AssetDatabase.FindAssets(filter, new[] { "Packages/de.codesmile.luny" });

			// in case package was localized or modified try finding defaults in /Assets
			if (contextGuids.Length == 0)
				contextGuids = AssetDatabase.FindAssets(filter);

			foreach (var contextGuid in contextGuids)
			{
				var contextPath = AssetDatabase.GUIDToAssetPath(contextGuid);
				var context = AssetDatabase.LoadAssetAtPath<LunyLuaContext>(contextPath);
				if (context != null)
				{
					var labels = AssetDatabase.GetLabels(context);
					if (DefaultEditorContext == null && labels.Contains(LunyAssetLabel.EditorLuaContext))
						m_DefaultEditorContext = context;
					if (DefaultRuntimeContext == null && labels.Contains(LunyAssetLabel.RuntimeLuaContext))
						m_DefaultRuntimeContext = context;
				}
			}
		}
	}
}
