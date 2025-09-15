// Copyright (C) 2021-2025 Steffen Itterheim
// Refer to included LICENSE file for terms and conditions.

using Luny;
using LunyEditor.Assets;
using System;
using System.Collections.Generic;
using UnityEditor;
using UnityEditor.UIElements;
using UnityEngine;
using UnityEngine.Serialization;
using UnityEngine.UIElements;

namespace LunyEditor.Settings
{
	[FilePath("ProjectSettings/LunySettings.asset", FilePathAttribute.Location.ProjectFolder)]
	internal sealed class LunyProjectSettings : ScriptableSingleton<LunyProjectSettings>
	{
		private const String DefaultScriptsRootFolder = "Assets/Scripts/Luny";

		[Header("Lua Contexts")]
		[SerializeField] private LunyLuaContext m_EditorContext;
		[SerializeField] private LunyLuaContext m_RuntimeContext;
		[SerializeField] private LunyLuaContext m_ModdingContext;

		[FormerlySerializedAs("m_EditorAutoRunScripts")]
		[Header("Lua Scripts")]
		[Tooltip("These scripts are running (active) at all times in the EditorContext. They are run in top to bottom order.")]
		[SerializeField] private List<LunyEditorLuaAsset> m_EditorAutoRunLuaAssets = new();
		[FormerlySerializedAs("m_RuntimeAutoRunScripts")]
		[Tooltip("These scripts are executed in the RuntimeContext when the Luny component awakes, in top to bottom order.")]
		[SerializeField] private List<LunyRuntimeLuaAsset> m_RuntimeAutoRunLuaAssets = new();
		[FormerlySerializedAs("m_ModdingAutoRunScripts")]
		[Tooltip("These scripts are executed in the ModdingContext when the Luny component awakes, in top to bottom order.")]
		[SerializeField] private List<LunyModdingLuaAsset> m_ModdingAutoRunLuaAssets = new();

		public static LunyProjectSettings Singleton => instance; // for consistency

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
		public IList<LunyEditorLuaAsset> EditorAutoRunLuaAssets => m_EditorAutoRunLuaAssets;
		public IList<LunyRuntimeLuaAsset> RuntimeAutoRunLuaAssets => m_RuntimeAutoRunLuaAssets;
		public IList<LunyModdingLuaAsset> ModdingAutoRunLuaAssets => m_ModdingAutoRunLuaAssets;

		private static SerializedObject GetSerializedSettings() => new(instance);

		private void OnEnable() => TryAssignDefaultsForNullValues();

		private void Reset()
		{
			m_EditorContext = m_RuntimeContext = m_ModdingContext = null;
			TryAssignDefaultsForNullValues();
		}

		internal void Save()
		{
			TryAssignDefaultsForNullValues();

			RemoveDuplicateEntries(ref m_EditorAutoRunLuaAssets);
			RemoveDuplicateEntries(ref m_RuntimeAutoRunLuaAssets);
			RemoveDuplicateEntries(ref m_ModdingAutoRunLuaAssets);

			var editorAssetRegistry = LunyEditorAssetRegistry.Singleton;
			editorAssetRegistry.EditorContext = m_EditorContext;
			editorAssetRegistry.Save();

			var runtimeAssetRegistry = LunyRuntimeAssetRegistry.Singleton;
			runtimeAssetRegistry.RuntimeContext = m_RuntimeContext;
			runtimeAssetRegistry.RuntimeAutoRunLuaAssets = CreateAssetCollection(m_RuntimeAutoRunLuaAssets);
			runtimeAssetRegistry.ModdingContext = m_ModdingContext;
			runtimeAssetRegistry.ModdingAutoRunLuaAssets = CreateAssetCollection(m_ModdingAutoRunLuaAssets);
			runtimeAssetRegistry.Save();

			Save(true);
		}

		private LunyLuaAssetCollection CreateAssetCollection(IEnumerable<LunyLuaAsset> runtimeAutoRunScripts)
		{
			var assets = new LunyLuaAssetCollection();
			foreach (var luaAsset in runtimeAutoRunScripts)
			{
				if (luaAsset != null)
					assets.AddOrUpdate(luaAsset, AssetDatabase.GetAssetPath(luaAsset));
			}
			return assets;
		}

		private void RemoveDuplicateEntries<T>(ref List<T> scripts) where T : LunyLuaAsset
		{
			var uniqueScripts = new List<T>();
			var hashSet = new HashSet<Int32>();
			foreach (var t in scripts)
			{
				// ReferenceEquals is to keep 'missing' entries but discard 'None' null objects
				if (ReferenceEquals(t, null) == false && hashSet.Add(t.GetInstanceID()))
					uniqueScripts.Add(t);
			}
			scripts = uniqueScripts;
		}

		private void TryAssignDefaultsForNullValues()
		{
			if (LunyRuntimeAssetRegistry.Singleton == null)
				LunyAssetManager.InitRuntimeRegistry();

			var shouldSave = m_EditorContext == null || m_RuntimeContext == null || m_ModdingContext == null;
			if (m_EditorContext == null)
				m_EditorContext = LunyEditorAssetRegistry.Singleton.EditorContext;
			if (m_RuntimeContext == null)
				m_RuntimeContext = LunyRuntimeAssetRegistry.Singleton.RuntimeContext;
			if (m_ModdingContext == null)
				m_ModdingContext = LunyRuntimeAssetRegistry.Singleton.ModdingContext;

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
					"AutoRun",
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
}
