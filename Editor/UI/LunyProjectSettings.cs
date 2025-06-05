// Copyright (C) 2021-2025 Steffen Itterheim
// Refer to included LICENSE file for terms and conditions.

using System;
using System.Collections.Generic;
using UnityEditor;
using UnityEditor.UIElements;
using UnityEditorInternal;
using UnityEngine;
using UnityEngine.UIElements;

internal sealed class LunyProjectSettings : ScriptableObject
{
	private const String SettingsPath = "ProjectSettings/LunySettings.asset";
	private static LunyProjectSettings s_Instance;

	[SerializeField] private Int32 m_Version = 1;
	[SerializeField] private Int32 m_Number = 42;
	[SerializeField] private String m_SomeString = "end of universe";

	public Int32 Version { get => m_Version; set => m_Version = value; }
	public Int32 Number { get => m_Number; set => m_Number = value; }
	public String SomeString { get => m_SomeString; set => m_SomeString = value; }

	public static LunyProjectSettings Instance => s_Instance != null ? s_Instance : s_Instance = Load();
	private static SerializedObject GetSerializedSettings() => new(Instance);

	private static LunyProjectSettings Load()
	{
		var loadedObjects = InternalEditorUtility.LoadSerializedFileAndForget(SettingsPath);
		if (loadedObjects == null || loadedObjects.Length == 0 || loadedObjects[0] is not LunyProjectSettings instance)
			instance = CreateInstance<LunyProjectSettings>();

		return instance;
	}

	private static void Save()
	{
		if (s_Instance != null)
			InternalEditorUtility.SaveToSerializedFileAndForget(new[] { s_Instance }, SettingsPath, true);
	}

	private sealed class LunyProjectSettingsProvider : SettingsProvider
	{
		[SettingsProvider]
		public static SettingsProvider Create() => new LunyProjectSettingsProvider("Project/Luny", SettingsScope.Project)
		{
			label = "Luny",
			keywords = new HashSet<String>(new[]
			{
				nameof(Number),
				nameof(SomeString),
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

			var properties = new VisualElement { style = { flexDirection = FlexDirection.Column } };
			properties.AddToClassList("property-list");
			rootElement.Add(properties);

			properties.Add(new PropertyField(settings.FindProperty(nameof(m_SomeString))));
			properties.Add(new PropertyField(settings.FindProperty(nameof(m_Number))));

			rootElement.Bind(settings);
		}

		public static void DeactivateHandler() => Save();

		public LunyProjectSettingsProvider(String path, SettingsScope scopes, IEnumerable<String> keywords = null)
			: base(path, scopes, keywords) {}
	}
}
