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
		private LunyLua m_Lua;
		private LuaTable m_ScriptContext;

		protected LunyLua Lua => m_Lua;
		public abstract String FullPath { get; }
		public LuaTable ScriptContext => m_ScriptContext;

		public LunyLuaScript(LunyLua lua, LuaTable context = null)
		{
			m_Lua = lua;
			m_ScriptContext = context ?? new LuaTable(0, 3);
		}

		public void Dispose()
		{
			m_Lua = null;
			m_ScriptContext = null;
		}

		internal abstract Task OnScriptChanged();
		internal abstract ValueTask DoScriptAsync();

		protected void SetScriptContext(String name, String path)
		{
			ScriptContext["scriptType"] = GetType().Name;
			ScriptContext["scriptName"] = name;
			ScriptContext["scriptPath"] = path;
		}
	}

	public sealed class LunyLuaAssetScript : LunyLuaScript
	{
		private readonly LunyLuaAsset m_LuaAsset;

		public LunyLuaAsset LuaAsset => m_LuaAsset;

		public override String FullPath => m_LuaAsset.FullPath;

		public static IEnumerable<LunyLuaAssetScript> Create(LunyLua lua, IEnumerable<LunyLuaAsset> luaAssets)
		{
			var scripts = new List<LunyLuaAssetScript>();
			if (luaAssets != null)
			{
				foreach (var luaAsset in luaAssets)
				{
					if (luaAsset != null)
						scripts.Add(new LunyLuaAssetScript(lua, luaAsset));
				}
			}
			return scripts;
		}

		public LunyLuaAssetScript(LunyLua lua, LunyLuaAsset luaAsset, LuaTable context = null)
			: base(lua, context)
		{
			m_LuaAsset = luaAsset;
			SetScriptContext(luaAsset.name, luaAsset.Path);
		}

		internal override async Task OnScriptChanged() => await DoScriptAsync();

		internal override async ValueTask DoScriptAsync() =>
			await Lua.State.DoStringAsync(LuaAsset.Text, LuaAsset.Path, ScriptContext);
	}

	public sealed class LunyLuaFileScript : LunyLuaScript
	{
		private readonly String m_FullPath;
		string m_ScriptPath;

		public override String FullPath => m_FullPath;

		public static IEnumerable<LunyLuaFileScript> Create(LunyLua lua, IEnumerable<String> paths)
		{
			var scripts = new List<LunyLuaFileScript>();
			if (paths != null)
			{
				foreach (var path in paths)
				{
					if (String.IsNullOrEmpty(path) == false)
						scripts.Add(new LunyLuaFileScript(lua, path));
				}
			}
			return scripts;
		}

		public LunyLuaFileScript(LunyLua lua, String filePath, LuaTable context = null)
			: base(lua, context)
		{
			m_FullPath = Path.GetFullPath(filePath).ToForwardSlashes();
			m_ScriptPath = File.Exists(filePath) ? filePath : m_FullPath;
			SetScriptContext(Path.GetFileNameWithoutExtension(m_ScriptPath), m_ScriptPath);
		}

		internal override async Task OnScriptChanged() => await DoScriptAsync();

		internal override async ValueTask DoScriptAsync() => await Lua.State.DoFileAsync(m_ScriptPath, ScriptContext);
	}
}
