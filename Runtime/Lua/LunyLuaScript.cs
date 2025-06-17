// Copyright (C) 2021-2025 Steffen Itterheim
// Refer to included LICENSE file for terms and conditions.

using Lua;
using Lua.Unity;
using System;
using System.Threading.Tasks;
using UnityEditor;
using UnityEngine;

namespace CodeSmile.Luny
{
	public sealed class LunyLuaScript : IDisposable
	{
		private readonly LunyLuaAsset m_LuaAsset;
		private LunyLua m_Lua;
		private LuaTable m_ScriptContext;

		public LunyLuaAsset LuaAsset => m_LuaAsset;
		public LuaTable ScriptContext => m_ScriptContext;

		public LunyLuaScript(LunyLua lua, LunyLuaAsset luaAsset, LuaTable arguments = null)
		{
			m_Lua = lua;
			m_LuaAsset = luaAsset;

			m_ScriptContext = arguments ?? new LuaTable(0, 2);
			m_ScriptContext["scriptName"] = luaAsset.name;
			m_ScriptContext["scriptPath"] = luaAsset.Path;
		}

		public void Dispose()
		{
			m_Lua = null;
			m_ScriptContext = null;
		}

		internal void OnScriptChanged()
		{
			DoScriptAsync();
		}

		internal async ValueTask DoScriptAsync() =>
			await m_Lua.State.DoStringAsync(LuaAsset.Text, LuaAsset.Path, m_ScriptContext);
	}
}
