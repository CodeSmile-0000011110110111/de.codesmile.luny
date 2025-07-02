// Copyright (C) 2021-2025 Steffen Itterheim
// Refer to included LICENSE file for terms and conditions.

using Lua;
using System;
using System.Linq;
using UnityEditor;
using UnityEngine;

namespace CodeSmile.Luny
{
	/// <summary>
	/// Contains settings for a Lua context and instantiates an instance of Lua.
	/// </summary>
	[CreateAssetMenu(fileName = "New LuaContext", menuName = "Luny/Lua Context", order = 100)]
	[Icon("Packages/de.codesmile.luny/Editor/Resources/LunyLuaContextIcon.png")]
	public sealed class LunyLuaContext : ScriptableObject
	{
		[Tooltip("When enabled, access to potentially harmful methods and libraries is restricted or disallowed. " +
		         "All paths are relative to the search paths below, absolute paths will not work. " +
		         "Contexts that may run user scripts (eg modding, even if unintential) should enable this!")]
		[SerializeField] private Boolean m_IsSandbox;

		/// <summary>
		/// Directories where functions like dofile() will search for files.
		/// </summary>
		[Tooltip("Scripts with relative paths will be searched for in these folders, from top to bottom. Search stops for " +
		         "the first script found.")]
		[SerializeField] private String[] m_ScriptSearchPaths =
		{
			"%PersistentDataPath%",
			"Assets/StreamingAssets",
			"Assets/Scripts",
			"Assets",
		};

		[SerializeField] private LuaLibraryFlags m_Libraries = (LuaLibraryFlags)(-1); // default: Everything

		/// <summary>
		/// Which modules (C# bindings) will be available in this Lua state.
		/// </summary>
		[SerializeField] private LunyLuaModule[] m_Modules = new LunyLuaModule[0];

		[SerializeField] [HideInInspector] private String m_Path;
		[SerializeField] [HideInInspector] private Boolean m_IsModdingContext;

		public Boolean IsSandbox => m_IsSandbox;
		public LunySearchPaths SearchPaths => new(this, m_ScriptSearchPaths);
		public String Path => m_Path;
		public LuaLibraryFlags Libraries => m_Libraries;

		/// <summary>
		/// Which modules (C# bindings) will be available in this Lua state.
		/// </summary>
		public LunyLuaModule[] Modules => m_Modules;

		private void OnEnable() => m_IsModdingContext = IsModdingContext;

#if UNITY_EDITOR
		private void OnValidate() => UpdateAssetPath();

		private void UpdateAssetPath()
		{
			var path = AssetDatabase.GetAssetPath(this);
			if (path != m_Path)
			{
				m_Path = path;
				EditorUtility.SetDirty(this);
			}
		}

		public Boolean IsEditorContext => AssetDatabase.GetLabels(this).Contains(LunyAssetLabel.EditorLuaContext);
		public Boolean IsRuntimeContext => AssetDatabase.GetLabels(this).Contains(LunyAssetLabel.RuntimeLuaContext);
		public Boolean IsModdingContext =>
			m_IsModdingContext = AssetDatabase.GetLabels(this).Contains(LunyAssetLabel.ModdingLuaContext);
#else
		public Boolean IsEditorContext => false;
		public Boolean IsRuntimeContext => true;
		public Boolean IsModdingContext => m_IsModdingContext;
#endif
		public LuaValue CreateContextTable()
		{
			var context = new LuaTable(0, 6);
			context["name"] = name;
			context["path"] = Path;
			context["sandbox"] = IsSandbox;
			context["editor"] = IsEditorContext;
			context["runtime"] = IsRuntimeContext;
			context["modding"] = IsModdingContext;
			return context;
		}
	}
}
