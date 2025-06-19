// Copyright (C) 2021-2025 Steffen Itterheim
// Refer to included LICENSE file for terms and conditions.

using CodeSmile;
using CodeSmile.Luny;
using System;
using System.IO;
using System.Threading.Tasks;
using UnityEditor;
using UnityEngine;

namespace CodeSmileEditor.Luny
{
	public interface ILunyEditor
	{
		ILunyLua Lua { get; }
	}

	[FilePath("ProjectSettings/LunyEditorState.asset", FilePathAttribute.Location.ProjectFolder)]
	public sealed class LunyEditor : ScriptableSingleton<LunyEditor>, ILunyEditor
	{
		// TODO: consider having a serialized, persistent LuaTable that survives domain reload
		// TODO: how to interact with this editor? not needed? eg could use settings, context, etc

		// TODO: script state that survives session reload => project close and re-open
		//private LuaTable m_PersistentState;
		// TODO: script state that survives domain reload but not project close
		//private LuaTable m_SessionData;

		private LunyLua m_Lua;

		public ILunyLua Lua => m_Lua;
		public static ILunyEditor Singleton => instance; // for consistency

		[InitializeOnLoadMethod] private static LunyEditor OnLoad() => instance; // auto-create the singleton

		// Reset runs when project is loaded AND the FilePath asset does not exist
		private void Reset() {}

		// Awake runs every time the project is loaded
		private void Awake() {}

		// OnEnable runs after every domain reload (including project load)
		private async Task OnEnable()
		{
			EditorApplication.focusChanged += OnFocusChanged;

			var registry = LunyEditorAssetRegistry.Singleton;
			registry.OnEditorContextChanged += OnLuaContextChanged;
			registry.EditorLuaAssets.OnAdd += OnAddLuaAsset;
			registry.EditorLuaAssets.OnRemove += OnRemoveLuaAsset;
			EditorApplication.update += OnEditorUpdate;

			if (registry.EditorContext != null)
			{
				CreateLuaState(registry.EditorContext);

				var startupScripts = LunyProjectSettings.Singleton.EditorStartupScripts;
				var scripts = LunyLuaAssetScript.Create(startupScripts);
				await m_Lua.AddAndRunScripts(scripts);

				foreach (var script in scripts)
				{
					if (script == null)
						continue;

					Debug.Log($"script is of type: {script.EditorType}");
					switch (script.EditorType)
					{
						case LunyLuaScript.ScriptableSingletonEditorType:
							var instance = LunyScriptableSingleton.Singleton;
							instance.AddScript(script);
							break;
					}
				}
			}
		}

		// OnDisable runs before every domain reload
		private void OnDisable()
		{
			// ensure OnDisable/OnDestroy run in LSS scripts before we destroy the Lua state
			DestroyImmediate(LunyScriptableSingleton.Singleton);

			Save(true);
			DestroyLuaState();
		}

		// OnDestroy only runs when manually calling DestroyImmediate(instance), never otherwise (not even on project close!)
		private void OnDestroy() {}

		private async void OnEditorUpdate()
		{
			if (m_Lua != null)
				await m_Lua.Update();
		}

		private void OnLuaContextChanged(LunyLuaContext luaContext) =>
			CreateLuaState(luaContext ?? LunyEditorAssetRegistry.Singleton.EditorContext);

		private void OnFocusChanged(Boolean hasFocus) {}

		private void CreateLuaState(LunyLuaContext editorContext)
		{
			DestroyLuaState();
			m_Lua = new LunyLua(editorContext, new FileSystem(editorContext));
		}

		private void DestroyLuaState()
		{
			m_Lua?.Dispose();
			m_Lua = null;
		}

		private async void OnAddLuaAsset(LunyLuaAsset luaAsset)
		{
			var settings = LunyProjectSettings.Singleton;
			if (settings.EditorStartupScripts.Contains(luaAsset as LunyEditorLuaAsset))
				await m_Lua.AddAndRunScript(new LunyLuaAssetScript(luaAsset));
		}

		private void OnRemoveLuaAsset(LunyLuaAsset luaAsset)
		{
			var settings = LunyProjectSettings.Singleton;
			if (settings.EditorStartupScripts.Contains(luaAsset as LunyEditorLuaAsset))
				m_Lua.RemoveScript(luaAsset);
		}

		private sealed class FileSystem : ILunyLuaFileSystem
		{
			private readonly LunySearchPaths m_SearchPaths;
			private readonly Boolean m_IsSandbox;

			public FileSystem(LunyLuaContext luaContext)
			{
				m_SearchPaths = luaContext.SearchPaths;
				m_IsSandbox = luaContext.IsSandbox;
			}

			public Boolean ReadText(String path, out String content)
			{
				content = String.Empty;

				// try read absolute paths directly
				if (Path.IsPathRooted(path))
				{
					if (!m_IsSandbox)
						content = FileUtility.TryReadAllText(path, true);
					return true;
				}

				// Try read relative paths by looking through search paths
				var fullOrAssetPath = m_SearchPaths.GetFullPath(path);
				if (fullOrAssetPath == null)
					return true;

				// the asset should be in the registry
				var luaAsset = LunyEditorAssetRegistry.Singleton.GetLuaAsset(fullOrAssetPath);
				if (luaAsset != null)
				{
					AssetDatabase.ImportAsset(fullOrAssetPath); // pick up any changes to file if Auto-Refresh is disabled
					content = luaAsset.Text;
					return true;
				}

				// try read from file system instead (ie could be relative to project working directory)
				if (!m_IsSandbox)
					content = FileUtility.TryReadAllText(fullOrAssetPath, true);
				return true;
			}

			public Boolean ReadBytes(String path, out Byte[] bytes) => throw new NotImplementedException("ReadBytes");

			public String TryGetAssetPath(String pathOrChunkName) =>
				$"@{m_SearchPaths.GetFullPath(pathOrChunkName[0] == '@' ? pathOrChunkName.Substring(1) : pathOrChunkName)}";
		}
	}
}
