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
		bool IsDefaultContext { get; }
		bool IsEditorContext { get; }
	}

	/// <summary>
	/// Contains settings for a Lua context and instantiates an instance of Lua.
	/// </summary>
	[CreateAssetMenu(fileName = "New LuaContext", menuName = "Luny/LuaContext", order = 100)]
	[Icon("Packages/de.codesmile.luny/Editor/Resources/LunyLuaContextIcon.png")]
	public sealed class LuaContext : ScriptableObject, ILuaContext
	{
		[SerializeField] bool m_IsDefaultContext = false;
		[SerializeField] bool m_IsEditorContext = false;

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
		[SerializeField] private LuaModule[] m_Modules = new LuaModule[0];

		// private ILunyLua m_Lua;
		//
		// public ILunyLua Lua => m_Lua != null ? m_Lua : m_Lua = CreateLuaInstance();
		public Boolean IsDefaultContext => m_IsDefaultContext;
		public Boolean IsEditorContext => m_IsEditorContext;

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
