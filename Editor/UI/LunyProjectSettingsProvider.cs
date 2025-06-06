// Copyright (C) 2021-2025 Steffen Itterheim
// Refer to included LICENSE file for terms and conditions.

using System;
using System.Collections.Generic;
using UnityEditor;
using UnityEditor.UIElements;
using UnityEngine;
using UnityEngine.UIElements;

internal sealed partial class LunyProjectSettings
{
	private sealed class LunyProjectSettingsProvider : SettingsProvider
	{
		[SettingsProvider]
		public static SettingsProvider Create() => new LunyProjectSettingsProvider("Project/Luny", SettingsScope.Project)
		{
			label = "Luny",
			keywords = new HashSet<String>(new[]
			{
				"CodeSmile",
				"Luny",
				"Lua",
				"Context",
				nameof(DefaultEditorContext),
				nameof(DefaultRuntimeContext),
			}),
			activateHandler = ActivateHandler,
			deactivateHandler = DeactivateHandler,
		};

		public static void ActivateHandler(String searchContext, VisualElement rootElement)
		{
			Debug.Log("activate Luny settings");
			var settings = GetSerializedSettings();

			var styleSheet = AssetDatabase.LoadAssetAtPath<StyleSheet>("Editor Default Resources/settings_ui.uss");
			if (styleSheet == null)
				styleSheet = EditorGUIUtility.Load("Editor Default Resources/settings_ui.uss") as StyleSheet;
			if (styleSheet != null)
			{
				Debug.Log($"using stylesheet: {styleSheet}");
				rootElement.styleSheets.Add(styleSheet);
			}

			var title = new Label { text = "Luny Settings" };
			title.AddToClassList("title");
			rootElement.Add(title);

			var properties = new VisualElement { style = { flexDirection = FlexDirection.Column } };
			properties.AddToClassList("property-list");
			rootElement.Add(properties);

			properties.Add(new PropertyField(settings.FindProperty(nameof(m_DefaultEditorContext))));
			properties.Add(new PropertyField(settings.FindProperty(nameof(m_DefaultRuntimeContext))));

			rootElement.Bind(settings);
		}

		public static void DeactivateHandler() => instance.Save();

		public LunyProjectSettingsProvider(String path, SettingsScope scopes, IEnumerable<String> keywords = null)
			: base(path, scopes, keywords) {}
	}
}
