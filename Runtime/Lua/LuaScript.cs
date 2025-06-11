// Copyright (C) 2021-2025 Steffen Itterheim
// Refer to included LICENSE file for terms and conditions.

using Lua;
using System;
using System.Threading.Tasks;
using UnityEditor;
using UnityEngine;

namespace CodeSmile.Luny
{
	public sealed class LuaScript : IDisposable
	{
		private LunyLua m_Lua;
		private LunyLuaAssetBase m_LuaAsset;
		private LuaTable m_ScriptTable;
		public LunyLuaAssetBase LuaAsset => m_LuaAsset;
		public LuaTable ScriptTable => m_ScriptTable;

		public LuaScript(LunyLua lua, LunyLuaAssetBase luaAsset)
		{
			m_Lua = lua;
			m_LuaAsset = luaAsset;
			m_ScriptTable = new LuaTable();
		}

		public void Dispose()
		{
			m_Lua = null;
			m_LuaAsset = null;
			m_ScriptTable = null;
		}

		public async ValueTask Run()
		{
			var results = await m_Lua.State.DoStringAsync(LuaAsset.text, LuaAsset.name);
			if (results.Length > 0 && results[0].TryRead<LuaTable>(out var table))
				m_ScriptTable = table;
		}
	}
}
