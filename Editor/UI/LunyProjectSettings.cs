// Copyright (C) 2021-2025 Steffen Itterheim
// Refer to included LICENSE file for terms and conditions.

using CodeSmile.Luny;
using System;
using System.Collections.Generic;
using System.Linq;
using UnityEditor;
using UnityEditor.UIElements;
using UnityEngine;
using UnityEngine.UIElements;

[FilePath("ProjectSettings/LunySettings.asset", FilePathAttribute.Location.ProjectFolder)]
internal sealed class LunyProjectSettings : ScriptableSingleton<LunyProjectSettings>
{
	[SerializeField] private LunyLuaContext m_DefaultEditorContext;
	[SerializeField] private LunyLuaContext m_DefaultRuntimeContext;
	public LunyLuaContext DefaultEditorContext => m_DefaultEditorContext;
	public LunyLuaContext DefaultRuntimeContext => m_DefaultRuntimeContext;
	private static SerializedObject GetSerializedSettings() => new(instance);
	private void Awake() => AssignDefaultContextsIfNull();

	private void Save() => Save(true);

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
			var settings = GetSerializedSettings();

			var title = new Label { text = "Luny Settings" };
			title.AddToClassList("title");
			rootElement.Add(title);

			var note = new Label { text = "(settings look horrible, will be fixed eventually)" };
			rootElement.Add(note);

			var group = new GroupBox();
			rootElement.Add(group);

			var properties = new VisualElement { style = { flexDirection = FlexDirection.Column } };
			properties.AddToClassList("property-list");
			group.Add(properties);

			properties.Add(new PropertyField(settings.FindProperty(nameof(m_DefaultEditorContext))));
			properties.Add(new PropertyField(settings.FindProperty(nameof(m_DefaultRuntimeContext))));

			rootElement.Bind(settings);
		}

		public static void DeactivateHandler() => instance.Save();

		public LunyProjectSettingsProvider(String path, SettingsScope scopes, IEnumerable<String> keywords = null)
			: base(path, scopes, keywords) {}
	}
}
