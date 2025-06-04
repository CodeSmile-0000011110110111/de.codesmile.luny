// Copyright (C) 2021-2025 Steffen Itterheim
// Refer to included LICENSE file for terms and conditions.

using CodeSmile.Utility;
using Lua.Unity;
using System;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

namespace CodeSmile.Luny
{
	/// <summary>
	/// Maintains a list of project-wide LuaAsset (*.lua) assets in support of 'load bundled script by name/path'.
	/// </summary>
	public sealed partial class LunyAssetRegistry : ScriptableObject
	{
		private static LunyAssetRegistry s_Singleton;

		[Header("Automated Luny Support Asset (read-only)")]
		[SerializeField] [ReadOnlyField] private LuaContext m_DefaultContext;
		[SerializeField] [ReadOnlyField] private LuaContext m_DefaultEditorContext;
		[SerializeField] [ReadOnlyField] private List<LuaContext> m_LuaContexts = new();
		[SerializeField] [ReadOnlyField] private List<LuaAsset> m_LuaAssets = new();
		[SerializeField] [ReadOnlyField] private List<String> m_LuaAssetNames = new();
		[SerializeField] [ReadOnlyField] private List<String> m_LuaAssetNamesLowercase = new();
		[SerializeField] [ReadOnlyField] private List<String> m_LuaAssetPaths = new();
		public static LunyAssetRegistry Singleton => s_Singleton;
		public LuaContext DefaultContext => m_DefaultContext;
		public LuaContext DefaultEditorContext => m_DefaultEditorContext;
		public LuaContext GetContext(String contextName) => m_LuaContexts.Find(context => context.name == contextName);

		public LuaAsset GetScript(String scriptName)
		{
			var index = m_LuaAssetNamesLowercase.IndexOf(scriptName.ToLower());
			if (index < 0)
				index = m_LuaAssetNames.IndexOf(scriptName);
			if (index < 0)
				index = m_LuaAssetPaths.IndexOf(scriptName);

			return index >= 0 ? m_LuaAssets[index] : null;
		}
	}
}
