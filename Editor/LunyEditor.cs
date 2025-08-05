// Copyright (C) 2021-2025 Steffen Itterheim
// Refer to included LICENSE file for terms and conditions.

using CodeSmile;
using Luny;
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

		public ILunyLua Lua => m_Lua != null ? m_Lua : m_Lua = CreateLuaState();
		public static ILunyEditor Singleton => instance; // for consistency

		[InitializeOnLoadMethod] private static LunyEditor OnLoad() => instance; // auto-create the singleton

		private static void RegisterEditorScriptByType(LunyLuaScript script)
		{
			switch (script.EditorType)
			{
				case LunyLuaScript.ScriptableSingletonEditorType:
					var instance = LunyScriptableSingletonScripts.Singleton;
					instance.AddScript(script);
					break;
			}
		}

		private static void UnregisterEditorScriptByAsset(LunyLuaAsset luaAsset)
		{
			var lssInstance = LunyScriptableSingletonScripts.Singleton;
			lssInstance.RemoveScriptByAsset(luaAsset);
		}

		// Reset runs when project is loaded AND the FilePath asset does not exist
		//private void Reset() {}

		// Awake runs once, when the project is loaded (the instance is instantiated for the first time)
		//private void Awake() {}

		// OnEnable runs after every domain reload (including project load)
		private void OnEnable()
		{
			var registry = LunyEditorAssetRegistry.Singleton;
			registry.OnEditorContextChanged += OnEditorContextChanged;
			registry.EditorLuaAssets.OnAdd += OnAddLuaAsset;
			registry.EditorLuaAssets.OnRemove += OnRemoveLuaAsset;
			EditorApplication.update += OnEditorUpdate;

			// delayed, otherwise Editor may create Lua State "too early" after generating module code
			EditorApplication.delayCall += () => DoAutoRunScripts().Preserve().GetAwaiter().GetResult();
		}

		// OnDisable runs before every domain reload
		private void OnDisable() => Save(true);

		// OnDestroy only runs when manually calling DestroyImmediate(instance), never otherwise (not even on project close!)
		private void OnDestroy() {}

		private async ValueTask DoAutoRunScripts()
		{
			var autorunScripts = LunyProjectSettings.Singleton.EditorAutoRunLuaAssets;
			var scripts = LunyLuaScript.Load(autorunScripts);

			if (Lua != null)
				await Lua.AddAndRunScripts(scripts);

			foreach (var script in scripts)
			{
				if (script == null)
					continue;

				RegisterEditorScriptByType(script);
			}
		}

		private void OnEditorUpdate()
		{
			if (m_Lua != null)
			{
				m_Lua.NotifyChangedScripts();

				// clear any runtime-only changed scripts, these don't need hot reloading outside playmode
				if (Application.isPlaying == false)
					m_Lua.ClearChangedScripts();
			}
		}

		private void OnEditorContextChanged(LunyLuaContext luaContext)
		{
			m_Lua = CreateLuaState();
			DoAutoRunScripts().Preserve().GetAwaiter().GetResult();
		}

		private LunyLua CreateLuaState()
		{
			var editorContext = LunyEditorAssetRegistry.Singleton.EditorContext;
			return editorContext != null ? new LunyLua(editorContext, new FileSystem(editorContext)) : null;
		}

		private async void OnAddLuaAsset(LunyLuaAsset luaAsset)
		{
			var settings = LunyProjectSettings.Singleton;
			if (settings.EditorAutoRunLuaAssets.Contains(luaAsset as LunyEditorLuaAsset))
			{
				var script = new LunyLuaAssetScript(luaAsset);
				await Lua.AddAndRunScript(script);
				RegisterEditorScriptByType(script);
			}
		}

		private void OnRemoveLuaAsset(LunyLuaAsset luaAsset)
		{
			var settings = LunyProjectSettings.Singleton;
			if (settings.EditorAutoRunLuaAssets.Contains(luaAsset as LunyEditorLuaAsset))
			{
				Lua.RemoveScript(luaAsset);
				UnregisterEditorScriptByAsset(luaAsset);
			}
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
