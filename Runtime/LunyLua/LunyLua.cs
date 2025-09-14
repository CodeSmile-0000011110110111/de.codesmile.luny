// Copyright (C) 2021-2025 Steffen Itterheim
// Refer to included LICENSE file for terms and conditions.

using Lua;
using Lua.Platforms;
using Luny.Core;
using System;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;
using UnityEditor;
using UnityEngine;

namespace Luny
{
	[Flags]
	public enum LuaLibraryFlags
	{
		// bit spacing is to maintain alphabetic sort order if libraries get added in the future
		Basic = 1 << 2,
		Bitwise = 1 << 5,
		Coroutine = 1 << 8,
		Debug = 1 << 11,
		IO = 1 << 14,
		Math = 1 << 17,
		Module = 1 << 20,
		OS = 1 << 23,
		String = 1 << 26,
		Table = 1 << 29,
	}

	public sealed class LunyLuaStateData
	{
		public ILunyLua LunyLua { get; internal set; }
	}

	/// <summary>
	///     <a href="https://github.com/AnnulusGames/Lua-CSharp" target="_blank">Lua-CSharp</a> wrapper and Lua environment
	///     initialization.
	/// </summary>
	public interface ILunyLua
	{
		/// <summary>
		///     The Lua state.
		/// </summary>
		LuaState State { get; }
		ILuaNamespaces Namespaces { get; }
		ILuaEnumCollection Enums { get; }
		ILuaObjectFactory ObjectFactory { get; }
		void AddScript(LunyLuaScript script);
		ValueTask AddAndRunScript(LunyLuaScript script);
		ValueTask AddAndRunScripts(IEnumerable<LunyLuaScript> scripts);
		ValueTask RunScript(LunyLuaScript script);
		void RemoveScript(LunyLuaScript script);
		void RemoveScript(LunyLuaAsset asset);
	}

	public sealed class LunyLua : ILunyLua
	{
		private readonly LunyLuaScriptCollection m_Scripts = new();
		private readonly LuaFileWatcher m_FileWatcher;
		private readonly LuaNamespaces m_Namespaces;
		private readonly LuaEnumCollection m_Enums;
		private readonly LuaObjectFactory m_ObjectFactory = new();
		private LuaState m_LuaState;

		public LuaState State => m_LuaState;
		public ILuaObjectFactory ObjectFactory => m_ObjectFactory;
		public ILuaNamespaces Namespaces => m_Namespaces;
		public ILuaEnumCollection Enums => m_Enums;

		//public IReadOnlyCollection<LunyLuaScript> Scripts => m_Scripts.Scripts;

		private static LuaPlatform CreateLunyPlatform(LunyLuaContext luaContext, ILunyFileSystemHook fileSystemHook)
		{
			var fileSystem = new LuaUnityFileSystem(luaContext, fileSystemHook);
			var osEnv = new LuaUnityEnvironment(luaContext);
			var standardIO = new LuaUnityIO(luaContext);
			var lunyPlatform = new LuaPlatform(fileSystem, osEnv, standardIO, TimeProvider.System);
			return lunyPlatform;
		}

		public LunyLua(LunyLuaContext luaContext, ILunyFileSystemHook fileSystemHook)
		{
			m_FileWatcher = new LuaFileWatcher(luaContext);
			m_LuaState = LuaState.Create(CreateLunyPlatform(luaContext, fileSystemHook));
			m_LuaState.UserData = new LunyLuaStateData { LunyLua = this };
			m_LuaState.Environment["LuaContext"] = luaContext.CreateContextTable();
			m_LuaState.LoadBuiltInLibraries(luaContext.Libraries);
			m_LuaState.ApplyLunyFunctionOverrides(luaContext.Libraries, luaContext.IsSandbox);
			m_LuaState.EnableNamespaceLookup();
			LuaModuleFactory.LoadModules(this, luaContext, out m_Namespaces, out m_Enums);
		}

		public async ValueTask RunScript(LunyLuaScript script) => await script.DoScriptAsync(m_LuaState);

		public async ValueTask AddAndRunScript(LunyLuaScript script)
		{
			if (script == null)
				throw new ArgumentNullException(nameof(script));

			AddScript(script);
			await RunScript(script);
		}

		public async ValueTask AddAndRunScripts(IEnumerable<LunyLuaScript> scripts)
		{
			if (scripts == null)
				throw new ArgumentNullException(nameof(scripts));

			foreach (var script in scripts)
			{
				if (script != null)
					await AddAndRunScript(script);
			}
		}

		public void AddScript(LunyLuaScript script)
		{
			m_Scripts.Add(script);
		}

		public void RemoveScript(LunyLuaScript script)
		{
			if (script == null || m_Scripts == null)
				return;

			if (m_Scripts.Remove(script))
				DisposeScript(script);
		}

		public void RemoveScript(LunyLuaAsset luaAsset)
		{
			if (luaAsset == null)
				return;

			for (var i = m_Scripts.Count - 1; i >= 0; i--)
			{
				var script = m_Scripts[i];
				if (script is LunyLuaAssetScript assetScript && luaAsset == assetScript.LuaAsset)
				{
					m_Scripts.RemoveAt(i);
					DisposeScript(script);
					break;
				}
			}
		}

		public void Dispose()
		{
			ClearScripts();

			m_LuaState.Environment.Clear();
			m_LuaState.UserData = null;
			m_LuaState = null;

			m_ObjectFactory?.Dispose();
			m_FileWatcher?.Dispose();
		}

		private void DisposeScript(LunyLuaScript script)
		{
			m_FileWatcher.RemoveChangedFile(script.FullPath); // on the rare chance that it is waiting to be reloaded ..
			script.Dispose();
		}

		private void RemoveScripts(IList<LunyLuaScript> scripts)
		{
			var count = scripts.Count;
			for (var i = count - 1; i >= 0; i--)
				RemoveScript(scripts[i]);
		}

		private void ClearScripts()
		{
			RemoveScripts(m_Scripts);
			m_Scripts.Clear();
		}

		internal void ProcessChangedScripts()
		{
			var changedFiles = m_FileWatcher.ChangedFiles;
			if (changedFiles == null || changedFiles.Length == 0)
				return;

			const String ResourcesFilter = "/resources/";

			foreach (var changedFile in changedFiles)
			{
				var scriptPath = changedFile;
				var foundScript = m_Scripts.TryGetScriptForPath(scriptPath, out var changedScript);
				var isResourcesScript = false;
				if (foundScript == false)
				{
					// not found? It could be a Resources path
					var resourcesIndex = changedFile.ToLower().LastIndexOf(ResourcesFilter);
					if (resourcesIndex > 0)
					{
						isResourcesScript = true;
						var relativePath = changedFile.Substring(resourcesIndex + ResourcesFilter.Length);
						scriptPath = Path.GetFileNameWithoutExtension(relativePath);

						foundScript = m_Scripts.TryGetScriptForPath(scriptPath, out changedScript);
					}
				}

				if (foundScript)
				{
					m_FileWatcher.RemoveChangedFile(changedFile);

					// in editor, changes to LuaAsset files also need to trigger Importer in case auto-refresh is disabled
					if (Application.isEditor)
					{
						if (changedScript is LunyLuaAssetScript assetScript)
						{
							//Debug.Log($"{DateTime.Now.Second}.{DateTime.Now.Millisecond}: Reimport {assetScript} at path: {assetScript.FullPath}");
							AssetUtil.IfEditor_ImportAsset(assetScript.LuaAsset);
						}
						else if (isResourcesScript)
						{
							// force reload of Resources script
							var resourcePath = changedFile.Replace($"{Application.dataPath}/", "Assets/");
							//Debug.Log($"Reimport Resources path: {resourcePath}");
							AssetUtil.IfEditor_ImportAsset(resourcePath);
						}
					}

					changedScript.SendScriptChangedEvent();
				}
			}
		}

		internal void ClearChangedScripts() => m_FileWatcher.ClearChangedFiles();
	}
}
