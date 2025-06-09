// Copyright (C) 2021-2025 Steffen Itterheim
// Refer to included LICENSE file for terms and conditions.

using CodeSmile.Luny;
using Lua;
using System;
using UnityEditor;
using UnityEngine;

namespace CodeSmileEditor.Luny
{
	[FilePath("ProjectSettings/LunyEditorState.asset", FilePathAttribute.Location.ProjectFolder)]
	public sealed class LunyEditor : ScriptableSingleton<LunyEditor>
	{
		[SerializeField] private Int32 enabledCount;
		[SerializeField] private Int32 disabledCount;
		// TODO: consider having a serialized, persistent LuaTable that survives domain reload
		// TODO: how to interact with this editor? not needed? eg could use settings, context, etc

		// TODO: script state that survives session reload => project close and re-open
		private LuaTable m_PersistentState;
		// TODO: script state that survives domain reload but not project close
		private LuaTable m_SessionState;

		[InitializeOnLoadMethod]
		private static LunyEditor OnLoad() => instance; // auto-create the singleton

		// Runs when project is loaded AND the FilePath asset does not exist
		private void Reset()
		{
			m_PersistentState = new LuaTable();
			Debug.Log("LunyEditor Reset");
		}

		// Runs every time the project is loaded
		private void Awake()
		{
			m_SessionState = new LuaTable();
			Debug.Log("LunyEditor Awake");
		}

		// Runs after every domain reload (including project load)
		private void OnEnable()
		{
			enabledCount++;
			Debug.Log($"LunyEditor OnEnable {enabledCount}, disabledCount: {disabledCount}");

			var settings = LunyProjectSettings.instance.EditorStartupScripts;
		}

		// Runs before every domain reload
		private void OnDisable()
		{
			disabledCount++;
			Save(true);
			Debug.Log($"LunyEditor OnDisable {disabledCount}");
		}

		// Note: OnDestroy is never called, not even on project close (according to editor.log)!
		//private void OnDestroy() => throw new LunyException("LunyEditor OnDestroy -- this should NEVER throw!");
	}
}
