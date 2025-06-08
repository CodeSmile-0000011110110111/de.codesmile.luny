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
	const string DefaultScriptsRootFolder = "Assets/LunyScripts";

	[Header("Global Scripts")]
	[SerializeField] private DefaultAsset m_LunyScriptsRootFolder;

	[Header("Lua Contexts")]
	[SerializeField] private LunyLuaContext m_DefaultEditorContext;
	[SerializeField] private LunyLuaContext m_DefaultRuntimeContext;
	[SerializeField] private LunyLuaContext m_DefaultModdingContext;

	public DefaultAsset LunyScriptsRootFolder => m_LunyScriptsRootFolder;
	public LunyLuaContext DefaultEditorContext
	{
		get => m_DefaultEditorContext;
		internal set => m_DefaultEditorContext = value;
	}
	public LunyLuaContext DefaultRuntimeContext
	{
		get => m_DefaultRuntimeContext;
		internal set => m_DefaultRuntimeContext = value;
	}
	public LunyLuaContext DefaultModdingContext
	{
		get => m_DefaultModdingContext;
		internal set => m_DefaultModdingContext = value;
	}
	private static SerializedObject GetSerializedSettings() => new(instance);
	private void OnEnable()
	{
		Debug.LogWarning("Settings OnEnable");
		TryAssignDefaults();
	}

	internal void Save()
	{
		LunyEditorAssetRegistry.Singleton.DefaultContext = m_DefaultEditorContext;
		LunyEditorAssetRegistry.Singleton.Save();
		LunyRuntimeAssetRegistry.Singleton.DefaultContext = m_DefaultRuntimeContext;
		LunyRuntimeAssetRegistry.Singleton.ModdingContext = m_DefaultModdingContext;
		LunyRuntimeAssetRegistry.Singleton.Save();
		LunyAssetManager.TryCreateScriptRootFolders(m_LunyScriptsRootFolder);

		Save(true);
	}

	private void TryAssignDefaults()
	{
		if (LunyRuntimeAssetRegistry.Singleton == null)
			LunyAssetManager.InitRegistries();

		var shouldSave = m_DefaultEditorContext == null || m_DefaultRuntimeContext == null || m_DefaultModdingContext == null;
		if (m_DefaultEditorContext == null)
			m_DefaultEditorContext = LunyEditorAssetRegistry.Singleton.DefaultContext;
		if (m_DefaultRuntimeContext == null)
			m_DefaultRuntimeContext = LunyRuntimeAssetRegistry.Singleton.DefaultContext;
		if (m_DefaultModdingContext == null)
			m_DefaultModdingContext = LunyRuntimeAssetRegistry.Singleton.ModdingContext;

		if (LunyScriptsRootFolder == null)
		{
			shouldSave = true;
			EditorIO.TryCreateDirectory(DefaultScriptsRootFolder);
			var folderAsset = AssetDatabase.LoadAssetAtPath<DefaultAsset>(DefaultScriptsRootFolder);
			m_LunyScriptsRootFolder = folderAsset;
			LunyAssetManager.TryCreateScriptRootFolders(m_LunyScriptsRootFolder);
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
