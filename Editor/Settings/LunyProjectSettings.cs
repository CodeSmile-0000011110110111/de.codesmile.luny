// Copyright (C) 2021-2025 Steffen Itterheim
// Refer to included LICENSE file for terms and conditions.

using CodeSmile.Luny;
using CodeSmileEditor.Core;
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
	private const String DefaultScriptsRootFolder = "Assets/Scripts/Luny";

	[Header("Lua Scripts")]
	[SerializeField] private DefaultAsset m_GlobalLunyScriptsFolder;

	[Header("Lua Contexts")]
	[SerializeField] private LunyLuaContext m_EditorContext;
	[SerializeField] private LunyLuaContext m_RuntimeContext;
	[SerializeField] private LunyLuaContext m_ModdingContext;

	public DefaultAsset GlobalLunyScriptsFolder => m_GlobalLunyScriptsFolder;
	public LunyLuaContext EditorContext
	{
		get => m_EditorContext;
		internal set => m_EditorContext = value;
	}
	public LunyLuaContext RuntimeContext
	{
		get => m_RuntimeContext;
		internal set => m_RuntimeContext = value;
	}
	public LunyLuaContext ModdingContext
	{
		get => m_ModdingContext;
		internal set => m_ModdingContext = value;
	}
	private static SerializedObject GetSerializedSettings() => new(instance);

	private void OnEnable() => TryAssignDefaultsOfNullValues();

	private void Reset()
	{
		m_GlobalLunyScriptsFolder = null;
		m_EditorContext = m_RuntimeContext = m_ModdingContext = null;
		TryAssignDefaultsOfNullValues();
	}

	internal void Save()
	{
		TryAssignDefaultsOfNullValues();

		LunyEditorAssetRegistry.Singleton.LuaContext = m_EditorContext;
		LunyEditorAssetRegistry.Singleton.Save();
		LunyRuntimeAssetRegistry.Singleton.DefaultContext = m_RuntimeContext;
		LunyRuntimeAssetRegistry.Singleton.ModdingContext = m_ModdingContext;
		LunyRuntimeAssetRegistry.Singleton.Save();
		LunyAssetManager.TryCreateScriptRootFolders(m_GlobalLunyScriptsFolder);

		Save(true);
	}

	private void TryAssignDefaultsOfNullValues()
	{
		if (LunyRuntimeAssetRegistry.Singleton == null)
			LunyAssetManager.InitRegistries();

		var shouldSave = m_EditorContext == null || m_RuntimeContext == null || m_ModdingContext == null;
		if (m_EditorContext == null)
			m_EditorContext = LunyEditorAssetRegistry.Singleton.LuaContext;
		if (m_RuntimeContext == null)
			m_RuntimeContext = LunyRuntimeAssetRegistry.Singleton.DefaultContext;
		if (m_ModdingContext == null)
			m_ModdingContext = LunyRuntimeAssetRegistry.Singleton.ModdingContext;

		if (GlobalLunyScriptsFolder == null)
		{
			shouldSave = true;
			EditorIO.TryCreateDirectory(DefaultScriptsRootFolder);
			var folderAsset = AssetDatabase.LoadAssetAtPath<DefaultAsset>(DefaultScriptsRootFolder);
			Debug.Log($"created: {folderAsset} {folderAsset?.name}");
			m_GlobalLunyScriptsFolder = folderAsset;
			LunyAssetManager.TryCreateScriptRootFolders(m_GlobalLunyScriptsFolder);
		}

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
