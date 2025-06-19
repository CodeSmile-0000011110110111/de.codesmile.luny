// Copyright (C) 2021-2025 Steffen Itterheim
// Refer to included LICENSE file for terms and conditions.

using Lua;
using Lua.Unity;
using System;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;
using UnityEditor;
using UnityEngine;

namespace CodeSmile.Luny
{
	public abstract class LunyLuaScript : IDisposable
	{
		public event Action<LunyLuaScript> OnScriptChanged;
		public const String ScriptTypeKey = "ScriptType";
		public const String ScriptNameKey = "ScriptName";
		public const String ScriptPathKey = "ScriptPath";
		public const String EditorTypeKey = "EditorType";

		public const String ScriptableSingletonEditorType = "ScriptableSingleton";
		private readonly LunyEventHandlerCollection m_EventHandlers = new();

		private LuaTable m_ScriptContext;

		public abstract String FullPath { get; }
		public LuaTable ScriptContext => m_ScriptContext;

		public String EditorType => m_ScriptContext[EditorTypeKey].TryRead(out String editorType) ? editorType : null;

		public LunyLuaScript(LuaTable scriptContext = null) => m_ScriptContext = scriptContext ?? new LuaTable(0, 3);

		public void Dispose() => m_ScriptContext = null;

		internal void OnScriptChangedInternal() => OnScriptChanged?.Invoke(this);

		internal abstract ValueTask DoScriptAsync(LuaState luaState);

		protected void OnAfterDoScript()
		{
			if (m_ScriptContext[EditorTypeKey] == LuaValue.Nil)
				m_ScriptContext[EditorTypeKey] = ScriptableSingletonEditorType;

			// re-bind event functions
			foreach (var eventHandler in m_EventHandlers)
				eventHandler.BindEventCallbacks(m_ScriptContext);
		}

		protected void SetScriptContext(String name, String path)
		{
			ScriptContext[ScriptTypeKey] = GetType().Name;
			ScriptContext[ScriptNameKey] = name;
			ScriptContext[ScriptPathKey] = path;
		}

		public LunyEventHandler<T> EventHandler<T>() where T : Enum
		{
			var handler = m_EventHandlers.TryGet<T>();
			if (handler == null)
			{
				handler = new LunyEventHandler<T>(ScriptContext);
				m_EventHandlers.Add(handler);
			}

			return handler;
		}
	}

	public sealed class LunyLuaAssetScript : LunyLuaScript
	{
		private readonly LunyLuaAsset m_LuaAsset;

		public LunyLuaAsset LuaAsset => m_LuaAsset;

		public override String FullPath => m_LuaAsset.FullPath;

		public static IEnumerable<LunyLuaAssetScript> Create(IEnumerable<LunyLuaAsset> luaAssets)
		{
			var scripts = new List<LunyLuaAssetScript>();
			if (luaAssets != null)
			{
				foreach (var luaAsset in luaAssets)
				{
					if (luaAsset != null)
						scripts.Add(new LunyLuaAssetScript(luaAsset));
				}
			}
			return scripts;
		}

		public LunyLuaAssetScript(LunyLuaAsset luaAsset, LuaTable scriptContext = null)
			: base(scriptContext)
		{
			m_LuaAsset = luaAsset;
			SetScriptContext(luaAsset.name, luaAsset.Path);
		}

		internal override async ValueTask DoScriptAsync(LuaState luaState)
		{
			await luaState.DoStringAsync(LuaAsset.Text, $"@{LuaAsset.Path}", ScriptContext);
			OnAfterDoScript();
		}
	}

	public sealed class LunyLuaFileScript : LunyLuaScript
	{
		private readonly String m_FullPath;
		private readonly String m_ScriptPath;

		public override String FullPath => m_FullPath;

		public static IEnumerable<LunyLuaFileScript> Create(IEnumerable<String> paths)
		{
			var scripts = new List<LunyLuaFileScript>();
			if (paths != null)
			{
				foreach (var path in paths)
				{
					if (String.IsNullOrEmpty(path) == false)
						scripts.Add(new LunyLuaFileScript(path));
				}
			}
			return scripts;
		}

		public LunyLuaFileScript(String filePath, LuaTable scriptContext = null)
			: base(scriptContext)
		{
			m_FullPath = Path.GetFullPath(filePath).ToForwardSlashes();
			m_ScriptPath = File.Exists(filePath) ? filePath : m_FullPath;
			SetScriptContext(Path.GetFileNameWithoutExtension(m_ScriptPath), m_ScriptPath);
		}

		internal override async ValueTask DoScriptAsync(LuaState luaState)
		{
			await luaState.DoFileAsync(m_ScriptPath, ScriptContext);
			OnAfterDoScript();
		}
	}
}
