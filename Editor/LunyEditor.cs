// Copyright (C) 2021-2025 Steffen Itterheim
// Refer to included LICENSE file for terms and conditions.

using CodeSmile.Extensions.System;
using CodeSmile.Luny;
using CodeSmile.Utility;
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
		private Boolean m_ShouldCallReset;
		private Boolean m_ShouldCallAwake;

		public ILunyLua Lua => m_Lua;
		public ILunyEditor Singleton => instance; // for consistency

		[InitializeOnLoadMethod] private static LunyEditor OnLoad() => instance; // auto-create the singleton

		// Reset runs when project is loaded AND the FilePath asset does not exist
		private void Reset() => m_ShouldCallReset = true;

		// Awake runs every time the project is loaded
		private void Awake()
		{
			m_ShouldCallAwake = true;
			var registry = LunyEditorAssetRegistry.Singleton;
			if (registry.EditorContext != null)
				CreateLuaState(registry.EditorContext);
		}

		// OnEnable runs after every domain reload (including project load)
		private void OnEnable()
		{
			EditorApplication.focusChanged += OnFocusChanged;

			var registry = LunyEditorAssetRegistry.Singleton;
			registry.OnEditorContextChanged += ResetState;
			registry.EditorLuaAssets.OnAdd += OnAddLuaAsset;
			registry.EditorLuaAssets.OnRemove += OnRemoveLuaAsset;

			CreateLuaState(registry.EditorContext);

			if (m_ShouldCallReset)
			{
				// TODO
			}
			if (m_ShouldCallAwake)
			{
				// TODO
			}

			m_ShouldCallReset = m_ShouldCallAwake = false;
		}

		// OnDisable runs before every domain reload
		private void OnDisable() => Save(true);

		// Note: OnDestroy is never called, not even on project close according to editor.log
		//private void OnDestroy() => throw new LunyException("LunyEditor OnDestroy -- this will NEVER throw!");

		private void OnFocusChanged(Boolean hasFocus)
		{
			if (hasFocus)
			{
				// delay to allow IDE saving of scripts to complete
				EditorApplication.delayCall += () =>
				{
					Debug.LogWarning("For testing only - OnFocusChanged: ResetState");
					ResetState();
				};
			}
		}

		private async void ResetState(LunyLuaContext luaContext = null) =>
			await CreateLuaState(luaContext ?? LunyEditorAssetRegistry.Singleton.EditorContext);

		private async ValueTask CreateLuaState(LunyLuaContext editorContext)
		{
			m_Lua?.Dispose();
			m_Lua = new LunyLua(editorContext, new FileSystem(editorContext));
			await m_Lua.RunScripts(LunyProjectSettings.Singleton.EditorStartupScripts);
		}

		private async void OnAddLuaAsset(LunyLuaAsset luaAsset)
		{
			var settings = LunyProjectSettings.Singleton;
			if (settings.EditorStartupScripts.Contains(luaAsset as LunyEditorLuaAsset))
				await m_Lua.RunScript(luaAsset);
		}

		private void OnRemoveLuaAsset(LunyLuaAsset luaAsset)
		{
			var settings = LunyProjectSettings.Singleton;
			if (settings.EditorStartupScripts.Contains(luaAsset as LunyEditorLuaAsset))
				m_Lua.HaltScript(luaAsset);
		}

		private sealed class FileSystem : ILunyLuaFileSystem
		{
			private readonly LunySearchPaths m_SearchPaths;
			private readonly Boolean m_IsSandbox;

			public FileSystem(LunyLuaContext luaContext)
			{
				m_SearchPaths = new LunySearchPaths(luaContext);
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
				var fullOrAssetPath = m_SearchPaths.GetFullPathOrAssetPath(path);
				if (fullOrAssetPath == null)
					return true;

				// the asset should be in the registry
				var luaAsset = LunyEditorAssetRegistry.Singleton.GetLuaAsset(fullOrAssetPath);
				if (luaAsset != null)
				{
					AssetDatabase.ImportAsset(fullOrAssetPath); // pick up any changes to file if Auto-Refresh is disabled
					content = luaAsset.text;
					return true;
				}

				// try read from file system instead (ie could be relative to project working directory)
				if (!m_IsSandbox)
					content = FileUtility.TryReadAllText(fullOrAssetPath, true);
				return true;
			}

			public Boolean ReadBytes(String path, out Byte[] bytes) => throw new NotImplementedException("ReadBytes");
		}
	}
}
