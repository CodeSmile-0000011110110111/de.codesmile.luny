// Copyright (C) 2021-2025 Steffen Itterheim
// Refer to included LICENSE file for terms and conditions.

using CodeSmile;
using Lua;
using Lua.Unity;
using System;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;
using UnityEditor;
using UnityEngine;

namespace Luny
{
	public abstract class LunyLuaScript
	{
		public const String InstanceKey = "this";
		public const String ScriptNameKey = "ScriptName";
		public const String ScriptPathKey = "ScriptPath";
		public const String EditorTypeKey = "EditorType";
		public const String RuntimeTypeKey = "RuntimeType";

		public const String ScriptableSingletonEditorType = "ScriptableSingleton";
		private readonly LunyScriptEventHandlerCollection m_EventHandlers = new();
		public Action<LunyLuaScript> OnScriptChanged;

		private LuaTable m_ScriptContext;
		private String m_ScriptName;

		public String Name => m_ScriptName;
		public abstract String FullPath { get; }
		public LuaTable ScriptContext => m_ScriptContext;

		public String EditorType => m_ScriptContext[EditorTypeKey].TryRead(out String editorType) ? editorType : null;

		public static LunyLuaScript Load(LunyLuaAsset luaAsset) => new LunyLuaAssetScript(luaAsset);

		public static IEnumerable<LunyLuaScript> Load(IEnumerable<LunyLuaAsset> luaAssets)
		{
			var scripts = new List<LunyLuaScript>();
			if (luaAssets != null)
			{
				foreach (var luaAsset in luaAssets)
				{
					if (luaAsset != null)
						scripts.Add(Load(luaAsset));
				}
			}
			return scripts;
		}

		public static LunyLuaScript Load(String filePath) => String.IsNullOrEmpty(filePath) == false ? new LunyLuaFileScript(filePath) : null;

		public static IEnumerable<LunyLuaScript> Load(IEnumerable<String> filePaths)
		{
			var scripts = new List<LunyLuaScript>();
			if (filePaths != null)
			{
				foreach (var filePath in filePaths)
				{
					if (String.IsNullOrEmpty(filePath) == false)
						scripts.Add(Load(filePath));
				}
			}
			return scripts;
		}

		public static LunyLuaScript LoadFromStreamingAssets(String streamingAssetsPath) => String.IsNullOrEmpty(streamingAssetsPath) == false
			? new LunyLuaStreamingAssetsScript(streamingAssetsPath)
			: null;

		public static IEnumerable<LunyLuaScript> LoadFromStreamingAssets(IEnumerable<String> streamingAssetsPaths)
		{
			var scripts = new List<LunyLuaScript>();
			if (streamingAssetsPaths != null)
			{
				foreach (var streamingAssetsPath in streamingAssetsPaths)
				{
					if (String.IsNullOrEmpty(streamingAssetsPath) == false)
						scripts.Add(LoadFromStreamingAssets(streamingAssetsPath));
				}
			}
			return scripts;
		}

		public static LunyLuaScript LoadFromResources(String resourcesPath) =>
			String.IsNullOrEmpty(resourcesPath) == false ? new LunyLuaStreamingAssetsScript(resourcesPath) : null;

		public static IEnumerable<LunyLuaScript> LoadFromResources(IEnumerable<String> resourcesPaths)
		{
			var scripts = new List<LunyLuaScript>();
			if (resourcesPaths != null)
			{
				foreach (var resourcesPath in resourcesPaths)
				{
					if (String.IsNullOrEmpty(resourcesPath) == false)
						scripts.Add(LoadFromResources(resourcesPath));
				}
			}
			return scripts;
		}

		public LunyLuaScript(LuaTable scriptContext = null) => m_ScriptContext = scriptContext ?? new LuaTable(0, 4);

		internal void Dispose() => m_ScriptContext = null;

		internal void OnScriptChangedInternal() => OnScriptChanged?.Invoke(this);

		internal abstract ValueTask DoScriptAsync(LuaState luaState);

		protected void OnAfterDoScript(LuaState luaState)
		{
			if (m_ScriptContext[EditorTypeKey] == LuaValue.Nil)
				m_ScriptContext[EditorTypeKey] = ScriptableSingletonEditorType;

			// re-bind event functions
			foreach (var eventHandler in m_EventHandlers)
				eventHandler.BindEventCallbacks(m_ScriptContext);

			var loadEvent = EventHandler<ScriptLoadEvent>();
			loadEvent.Send(luaState, (Int32)ScriptLoadEvent.OnDidLoadScript);
		}

		private void AssertNotSet(String key) =>
			Debug.Assert(ScriptContext[key] == LuaValue.Nil, $"'{key}' is a reserved ScriptContext keyword");

		protected void SetDefaultContextValues(String name, String path)
		{
			m_ScriptName = name;
			AssertNotSet(RuntimeTypeKey);
			AssertNotSet(ScriptNameKey);
			AssertNotSet(ScriptPathKey);

			ScriptContext[RuntimeTypeKey] = GetType().Name;
			ScriptContext[ScriptNameKey] = name;
			ScriptContext[ScriptPathKey] = path;
		}

		internal LunyScriptEventHandler<T> EventHandler<T>() where T : Enum
		{
			var handler = m_EventHandlers.TryGet<T>();
			if (handler == null)
			{
				handler = new LunyScriptEventHandler<T>(ScriptContext);
				m_EventHandlers.Add(typeof(T), handler);
			}

			return handler;
		}

		public async ValueTask ReloadScript(LuaState luaState)
		{
			var reloadEvent = EventHandler<ScriptLoadEvent>();
			reloadEvent.Send(luaState, (Int32)ScriptLoadEvent.OnWillReloadScript);
			await DoScriptAsync(luaState);
		}

		public override String ToString() => $"{m_ScriptName} ({GetType().Name})";
	}

	internal sealed class LunyLuaAssetScript : LunyLuaScript
	{
		private readonly LunyLuaAsset m_LuaAsset;
		public LunyLuaAsset LuaAsset => m_LuaAsset;

		public override String FullPath => m_LuaAsset.FullPath;

		internal LunyLuaAssetScript(LunyLuaAsset luaAsset, LuaTable scriptContext = null)
			: base(scriptContext)
		{
			if (luaAsset == null)
				throw new ArgumentNullException(nameof(luaAsset));

			m_LuaAsset = luaAsset;
			SetDefaultContextValues(luaAsset.name, luaAsset.Path);
		}

		internal override async ValueTask DoScriptAsync(LuaState luaState)
		{
			await luaState.DoStringAsync(LuaAsset.Text, $"@{LuaAsset.Path}", ScriptContext);
			OnAfterDoScript(luaState);
		}
	}

	internal sealed class LunyLuaResourcesScript : LunyLuaScript
	{
		private readonly String m_ScriptPath;

		public override String FullPath => m_ScriptPath;

		internal LunyLuaResourcesScript(String resourcesPath, LuaTable scriptContext = null)
			: base(scriptContext)
		{
			if (String.IsNullOrEmpty(resourcesPath))
				throw new ArgumentException(nameof(resourcesPath));
			if (Path.HasExtension(resourcesPath))
				throw new ArgumentException(nameof(resourcesPath), $"{resourcesPath} has a file extension");

			m_ScriptPath = resourcesPath;
			var luaAsset = Resources.Load<LunyLuaAsset>(m_ScriptPath);
			SetDefaultContextValues(luaAsset.name, FullPath);
		}

		internal override async ValueTask DoScriptAsync(LuaState luaState)
		{
			var luaAsset = Resources.Load<LunyLuaAsset>(m_ScriptPath);
			await luaState.DoStringAsync(luaAsset.Text, "@" + luaAsset.Path, ScriptContext);
			OnAfterDoScript(luaState);
		}
	}

	internal sealed class LunyLuaStreamingAssetsScript : LunyLuaScript
	{
		private readonly String m_FullPath;
		private readonly String m_ScriptPath;

		public override String FullPath => m_FullPath;

		internal LunyLuaStreamingAssetsScript(String relativePath, LuaTable scriptContext = null)
			: base(scriptContext)
		{
			if (String.IsNullOrEmpty(relativePath))
				throw new ArgumentException(nameof(relativePath));
			if (Path.IsPathRooted(relativePath))
				throw new ArgumentException($"rooted path not allowed: {relativePath}");

			m_FullPath = m_ScriptPath = $"{Application.streamingAssetsPath}/{relativePath}";

			if (File.Exists(m_FullPath) == false)
				throw new FileNotFoundException($"StreamingAssets script does not exist: {m_FullPath}");

			SetDefaultContextValues(Path.GetFileNameWithoutExtension(m_ScriptPath), m_ScriptPath);
		}

		internal override async ValueTask DoScriptAsync(LuaState luaState)
		{
			await luaState.DoFileAsync(m_ScriptPath, ScriptContext);
			OnAfterDoScript(luaState);
		}
	}

	internal sealed class LunyLuaFileScript : LunyLuaScript
	{
		private readonly String m_FullPath;
		private readonly String m_ScriptPath;

		public override String FullPath => m_FullPath;

		internal LunyLuaFileScript(String filePath, LuaTable scriptContext = null)
			: base(scriptContext)
		{
			if (String.IsNullOrEmpty(filePath))
				throw new ArgumentException(nameof(filePath));

			m_FullPath = Path.GetFullPath(filePath).ToForwardSlashes();
			m_ScriptPath = File.Exists(filePath) ? filePath : m_FullPath;
			SetDefaultContextValues(Path.GetFileNameWithoutExtension(m_ScriptPath), m_ScriptPath);
		}

		internal override async ValueTask DoScriptAsync(LuaState luaState)
		{
			await luaState.DoFileAsync(m_ScriptPath, ScriptContext);
			OnAfterDoScript(luaState);
		}
	}
}
