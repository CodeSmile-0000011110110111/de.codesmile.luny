// Copyright (C) 2021-2025 Steffen Itterheim
// Refer to included LICENSE file for terms and conditions.

using CodeSmile.Utility;
using System;
using System.Linq;
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
		[Tooltip("When enabled, access to potentially harmful methods and libraries is restricted or disallowed. " +
		         "All paths are relative to the search paths below, absolute paths will not work. " +
		         "Contexts that may run user scripts (eg modding, even if unintential) should enable this!")]
		[SerializeField] private Boolean m_IsSandbox;

		/// <summary>
		/// Directories where functions like dofile('') will search for files.
		/// </summary>
		[Tooltip("Scripts with relative paths will be searched for in these folders, from top to bottom. Search stops for " +
		         "the first script found.")]
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

		public Boolean IsRuntimeContext()
		{
#if UNITY_EDITOR
			return AssetDatabase.GetLabels(this).Contains(LunyAssetLabel.RuntimeLuaContext);
#else
			return true;
#endif
		}
	}
}
