// Copyright (C) 2021-2025 Steffen Itterheim
// Refer to included LICENSE file for terms and conditions.

using System;
using UnityEditor;
using UnityEngine;

namespace CodeSmile.Luny
{
	/// <summary>
	/// Contains settings for a Lua context and instantiates an instance of Lua.
	/// </summary>
	[CreateAssetMenu(fileName = "New LuaContext", menuName = "Luny/LuaContext", order = 100)]
	[Icon("Packages/de.codesmile.luny/Editor/Resources/LunyLuaContextIcon.png")]
	public sealed class LunyLuaContext : ScriptableObject
	{
		[Tooltip("When enabled, access to potentially harmful OS and IO libraries is restricted or disallowed. " +
		         "Contexts that run user scripts (eg modding) should enable this!")]
		[SerializeField] bool m_IsSandbox = false;

		/// <summary>
		/// Directories where functions like dofile('') will search for files.
		/// </summary>
		[SerializeField] private String[] m_ScriptSearchPaths =
		{
			"%PersistentDataPath%",
			"%StreamingAssets%",
			"Assets",
		};

		[SerializeField] private LuaLibraryFlags m_Libraries = (LuaLibraryFlags)(-1); // default: Everything

		/// <summary>
		/// Which modules (C# bindings) will be available in this Lua state.
		/// </summary>
		[SerializeField] private LunyLuaModule[] m_Modules = new LunyLuaModule[0];

		public Boolean IsSandbox => m_IsSandbox;
		public String[] ScriptSearchPaths => m_ScriptSearchPaths;
		public LuaLibraryFlags Libraries => m_Libraries;
		/// <summary>
		/// Which modules (C# bindings) will be available in this Lua state.
		/// </summary>
		public LunyLuaModule[] Modules => m_Modules;
	}
}
