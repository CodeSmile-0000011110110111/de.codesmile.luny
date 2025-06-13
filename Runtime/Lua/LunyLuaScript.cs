// Copyright (C) 2021-2025 Steffen Itterheim
// Refer to included LICENSE file for terms and conditions.

using CodeSmile.Utility;
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
		private LuaTable m_Context;
		public LunyLuaAssetBase LuaAsset => m_LuaAsset;
		public LuaTable Context => m_Context;

		public LunyLuaScript(LunyLua lua, LunyLuaAssetBase luaAsset, LuaTable arguments = null)
		{
			m_Lua = lua;
			m_LuaAsset = luaAsset;
			m_Context = arguments ?? new LuaTable();
		}

		public void Dispose()
		{
			m_Lua = null;
			m_LuaAsset = null;
			m_Context = null;
		}

		public async ValueTask Run()
		{
			// in editor, pick up any changes to file if Auto-Refresh is disabled
			RuntimeAssetUtility.Import(m_LuaAsset);

			await m_Lua.State.DoStringAsync(m_LuaAsset.text, m_LuaAsset.name, m_Context);
		}
	}
}
