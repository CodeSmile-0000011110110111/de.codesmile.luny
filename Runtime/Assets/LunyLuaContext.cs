// Copyright (C) 2021-2025 Steffen Itterheim
// Refer to included LICENSE file for terms and conditions.

using System;
using UnityEditor;
using UnityEngine;
using UnityEngine.Serialization;

namespace CodeSmile.Luny
{
	public interface ILuaContext
	{
		//ILunyLua Lua { get; }
	}

	/// <summary>
	/// Contains settings for a Lua context and instantiates an instance of Lua.
	/// </summary>
	[CreateAssetMenu(fileName = "New LuaContext", menuName = "Luny/LuaContext", order = 100)]
	[Icon("Packages/de.codesmile.luny/Editor/Resources/LunyLuaContextIcon.png")]
	public sealed class LunyLuaContext : ScriptableObject, ILuaContext
	{
		/// <summary>
		/// Directories where functions like dofile('') will search for files.
		/// </summary>
		[SerializeField] private String[] m_ScriptSearchPaths =
		{
			"%PersistentDataPath%",
			"%StreamingAssets%",
			"Assets",
		};

		/// <summary>
		/// Which modules (C# bindings) will be available in this Lua state.
		/// </summary>
		[SerializeField] private LunyLuaModule[] m_Modules = new LunyLuaModule[0];

		// private ILunyLua m_Lua;
		//
		// public ILunyLua Lua => m_Lua != null ? m_Lua : m_Lua = CreateLuaInstance();

		// internal ILunyLua CreateLuaInstance(Boolean loadModules = true)
		// {
		// 	var lua = new LunyLua(new LunySearchPaths(m_SearchPaths));
		// 	if (loadModules)
		// 		LoadModules(lua);
		// 	return lua;
		// }
		//
		// private void LoadModules(ILunyLua lua)
		// {
		// 	foreach (var module in m_Modules)
		// 		module.LoadModule(lua.State);
		// }
	}
}
