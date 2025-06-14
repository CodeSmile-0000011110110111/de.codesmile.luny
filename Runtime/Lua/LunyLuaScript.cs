// Copyright (C) 2021-2025 Steffen Itterheim
// Refer to included LICENSE file for terms and conditions.

using CodeSmile.Utility;
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
		private LunyLua m_Lua;
		private LunyLuaAsset m_LuaAsset;
		private LuaTable m_Context;
		public LunyLuaAsset LuaAsset => m_LuaAsset;
		public LuaTable Context => m_Context;

#if UNITY_EDITOR
		private static String GetScriptPath(LunyLuaAsset luaAsset) => AssetDatabase.GetAssetPath(luaAsset);
#else
		private static String GetScriptPath(LunyLuaAsset luaAsset) => luaAsset.name;
#endif

		public LunyLuaScript(LunyLua lua, LunyLuaAsset luaAsset, LuaTable arguments = null)
		{
			m_Lua = lua;
			m_LuaAsset = luaAsset;
			m_Context = arguments ?? new LuaTable();
			m_Context["scriptName"] = luaAsset.name;
			m_Context["scriptPath"] = GetScriptPath(luaAsset);
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
