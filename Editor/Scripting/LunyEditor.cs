// Copyright (C) 2021-2025 Steffen Itterheim
// Refer to included LICENSE file for terms and conditions.

using Luny;
using LunyEditor.Assets;
using LunyEditor.Settings;
using System;
using System.IO;
using System.Threading.Tasks;
using UnityEditor;
using UnityEngine;
using FileUtil = Luny.Core.FileUtil;

namespace LunyEditor
{
	public interface ILunyEditor
	{
		ILunyLua Lua { get; }
	}

	[FilePath("ProjectSettings/LunyEditorState.asset", FilePathAttribute.Location.ProjectFolder)]
	public sealed class LunyEditor : ScriptableSingleton<LunyEditor>, ILunyEditor
	{
		// TODO: consider having a serialized, persistent LuaTable that survives domain reload
		// TODO: script state that survives session reload => project close and re-open
		//private LuaTable m_PersistentState;
		// TODO: script state that survives domain reload but not project close
		//private LuaTable m_SessionData;

		private bool m_IsReloadingDomain;

		private LunyLua m_Lua;

		public ILunyLua Lua
		{
			get
			{
				if (m_IsReloadingDomain)
					throw new InvalidOperationException("should not access Lua state during domain reload");

				return m_Lua != null ? m_Lua : m_Lua = CreateLuaState();
			}
		}
		public static ILunyEditor Singleton => instance; // for consistency

		[InitializeOnLoadMethod] private static LunyEditor OnLoad() => instance; // auto-create the singleton by accessing the instance property

		private static void RegisterEditorScriptByType(LunyLuaScript script)
		{
			switch (script.EditorType)
			{
				case LunyLuaScript.ScriptableSingletonEditorType:
					LunyEditorScriptableSingletonScripts.Singleton.AddScript(script);
					break;
				default: throw new NotImplementedException(script.EditorType);
			}
		}

		private static void UnregisterEditorScriptByAsset(LunyLuaAsset luaAsset) =>
			// FIXME: this won't work when extending to multiple script types
			LunyEditorScriptableSingletonScripts.Singleton.RemoveScriptForAsset(luaAsset);

		// Reset runs when project is loaded AND the FilePath asset does not exist
		private void Reset() => Debug.Log($"{nameof(LunyEditor)}: Reset");

		// Awake runs once, when the project is loaded (the instance is instantiated for the first time)
		private void Awake() => Debug.Log($"{nameof(LunyEditor)}: Awake");

		// OnEnable runs after every domain reload (including project load)
		private void OnEnable()
		{
			//Debug.Log("LunyEditor: OnEnable");

			m_IsReloadingDomain = false;
			var registry = LunyEditorAssetRegistry.Singleton;
			registry.OnEditorContextChanged += OnEditorContextChanged;
			registry.EditorLuaAssets.OnAdd += OnAddLuaAsset;
			registry.EditorLuaAssets.OnRemove += OnRemoveLuaAsset;
			EditorApplication.update += EditorUpdate;
			AssemblyReloadEvents.beforeAssemblyReload += OnBeforeAssemblyReload;

			// delayed, otherwise Editor may create Lua State "too early" after generating module code
			EditorApplication.delayCall += () => DoAutoRunScripts().Preserve().GetAwaiter().GetResult();
		}

		// OnDisable runs before every domain reload
		private void OnDisable()
		{
			Debug.Log($"{nameof(LunyEditor)}: OnDisable");
			Save(true);
		}

		// OnDestroy only runs when manually calling DestroyImmediate(instance), never otherwise (not even on project close!)
		private void OnDestroy() => Debug.LogError($"{nameof(LunyEditor)}: OnDestroy should never be called");

		private void OnBeforeAssemblyReload()
		{
			Debug.Log($"{nameof(LunyEditor)}: {nameof(OnBeforeAssemblyReload)}");
			DestroyLuaState();
			m_IsReloadingDomain = true;
		}

		private async ValueTask DoAutoRunScripts()
		{
			Debug.Log($"{nameof(LunyEditor)}: {nameof(DoAutoRunScripts)}");

			var autorunScripts = LunyProjectSettings.Singleton.EditorAutoRunLuaAssets;
			var scripts = LunyLuaScript.LoadFromFileSystem(autorunScripts);

			if (Lua != null)
				await Lua.AddAndRunScripts(scripts);

			foreach (var script in scripts)
			{
				if (script == null)
					continue;

				RegisterEditorScriptByType(script);
			}
		}

		private void EditorUpdate()
		{
			if (m_Lua != null)
			{
				m_Lua.ProcessChangedScripts();

				// clear any runtime-only changed scripts, these don't need hot reloading outside playmode
				if (Application.isPlaying == false)
					m_Lua.ClearChangedScripts();
			}
		}

		private void OnEditorContextChanged(LunyLuaContext luaContext)
		{
			Debug.Log($"{nameof(LunyEditor)}: {nameof(OnEditorContextChanged)}: {luaContext}");
			m_Lua = CreateLuaState();
			DoAutoRunScripts().Preserve().GetAwaiter().GetResult();
		}

		private LunyLua CreateLuaState()
		{
			Debug.Log($"{nameof(LunyEditor)}: {nameof(CreateLuaState)}");
			var editorContext = LunyEditorAssetRegistry.Singleton.EditorContext;
			return editorContext != null ? new LunyLua(editorContext, new FileSystem(editorContext)) : null;
		}

		private void DestroyLuaState()
		{
			if (m_Lua != null)
			{
				Debug.Log($"{nameof(LunyEditor)}: {nameof(DestroyLuaState)}");
				LunyEditorScriptableSingletonScripts.Singleton.DestroyScripts();
				m_Lua = null;
			}
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

		private sealed class FileSystem : ILunyFileSystemHook
		{
			private readonly LuaSearchPaths m_SearchPaths;
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
						content = FileUtil.TryReadAllText(path, true);
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
					Debug.Log($"LunyEditor.ReadText: {fullOrAssetPath}");
					AssetDatabase.ImportAsset(fullOrAssetPath); // pick up any changes to file if Auto-Refresh is disabled
					content = luaAsset.Text;
					return true;
				}

				// try read from file system instead (ie could be relative to project working directory)
				if (!m_IsSandbox)
					content = FileUtil.TryReadAllText(fullOrAssetPath, true);
				return true;
			}

			public Boolean ReadBytes(String path, out Byte[] bytes) => throw new NotImplementedException("ReadBytes");

			public String TryGetAssetPath(String pathOrChunkName) =>
				$"@{m_SearchPaths.GetFullPath(pathOrChunkName[0] == '@' ? pathOrChunkName.Substring(1) : pathOrChunkName)}";
		}
	}
}
