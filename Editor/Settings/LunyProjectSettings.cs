// Copyright (C) 2021-2025 Steffen Itterheim
// Refer to included LICENSE file for terms and conditions.

using CodeSmile.Luny;
using CodeSmileEditor.Luny;
using System;
using System.Collections.Generic;
using UnityEditor;
using UnityEditor.UIElements;
using UnityEngine;
using UnityEngine.UIElements;

[FilePath("ProjectSettings/LunySettings.asset", FilePathAttribute.Location.ProjectFolder)]
internal sealed class LunyProjectSettings : ScriptableSingleton<LunyProjectSettings>
{
	[SerializeField] private LunyLuaContext m_DefaultEditorContext;
	[SerializeField] private LunyLuaContext m_DefaultRuntimeContext;
	[SerializeField] private LunyLuaContext m_DefaultModdingContext;

	public LunyLuaContext DefaultEditorContext
	{
		get => m_DefaultEditorContext;
		internal set
		{
			m_DefaultEditorContext = value;
			Save(true);
		}
	}
	public LunyLuaContext DefaultRuntimeContext
	{
		get => m_DefaultRuntimeContext;
		internal set
		{
			m_DefaultRuntimeContext = value;
			Save(true);
		}
	}
	public LunyLuaContext DefaultModdingContext
	{
		get => m_DefaultModdingContext;
		internal set
		{
			m_DefaultModdingContext = value;
			Save(true);
		}
	}
	private static SerializedObject GetSerializedSettings() => new(instance);
	private void OnEnable() => AssignDefaultContextsIfNull();

	private void Save()
	{

		LunyEditorAssetRegistry.Singleton.DefaultContext = m_DefaultEditorContext;
		LunyEditorAssetRegistry.Singleton.Save();
		LunyRuntimeAssetRegistry.Singleton.DefaultContext = m_DefaultRuntimeContext;
		LunyRuntimeAssetRegistry.Singleton.ModdingContext = m_DefaultModdingContext;
		LunyRuntimeAssetRegistry.Singleton.Save();

		Save(true);
	}

	private void AssignDefaultContextsIfNull()
	{
		if (LunyRuntimeAssetRegistry.Singleton == null)
			LunyAssetRegistryManager.InitRegistries();

		var shouldSave = m_DefaultEditorContext == null || m_DefaultRuntimeContext == null || m_DefaultModdingContext == null;
		if (m_DefaultEditorContext == null)
			m_DefaultEditorContext = LunyEditorAssetRegistry.Singleton.DefaultContext;
		if (m_DefaultRuntimeContext == null)
			m_DefaultRuntimeContext = LunyRuntimeAssetRegistry.Singleton.DefaultContext;
		if (m_DefaultModdingContext == null)
			m_DefaultModdingContext = LunyRuntimeAssetRegistry.Singleton.ModdingContext;

		if (shouldSave)
			Save(true);
	}

	private sealed class LunyProjectSettingsProvider : SettingsProvider
	{
		private const String UxmlPath = "Packages/de.codesmile.luny/Editor/Settings/LunyProjectSettings.uxml";

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
				"LuaContext",
				"Mod",
				"Modding",
			}),
			activateHandler = ActivateHandler,
			deactivateHandler = DeactivateHandler,
		};

		public static void ActivateHandler(String searchContext, VisualElement rootElement)
		{
			var uxml = AssetDatabase.LoadAssetAtPath<VisualTreeAsset>(UxmlPath);
			//var uss = AssetDatabase.LoadAssetAtPath<StyleSheet>("Assets/Editor/main_styles.uss");
			var ui = uxml.Instantiate();
			rootElement.Add(ui);
			rootElement.Bind(GetSerializedSettings());
		}

		public static void DeactivateHandler() => instance.Save();

		public LunyProjectSettingsProvider(String path, SettingsScope scopes, IEnumerable<String> keywords = null)
			: base(path, scopes, keywords) {}
	}
}
