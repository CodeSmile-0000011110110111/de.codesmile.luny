// Copyright (C) 2021-2025 Steffen Itterheim
// Refer to included LICENSE file for terms and conditions.

using Lua;
using System;
using System.Threading.Tasks;
using UnityEditor;
using UnityEngine;

namespace CodeSmile.Luny
{
	public sealed class LunyLuaScript : IDisposable
	{
		private LunyLua m_Lua;
		private LunyLuaAssetBase m_LuaAsset;
		private LuaTable m_Arguments;
		public LunyLuaAssetBase LuaAsset => m_LuaAsset;
		public LuaTable Arguments => m_Arguments;

		public LunyLuaScript(LunyLua lua, LunyLuaAssetBase luaAsset, LuaTable arguments = null)
		{
			m_Lua = lua;
			m_LuaAsset = luaAsset;
			m_Arguments = arguments ?? new LuaTable();
			m_Arguments["TestEnv"] = "environment variable is set";
		}

		public void Dispose()
		{
			m_Lua = null;
			m_LuaAsset = null;
			m_Arguments = null;
		}

		public async ValueTask Run() => await m_Lua.State.DoStringAsync(LuaAsset.text, LuaAsset.name, m_Arguments);
	}
}
