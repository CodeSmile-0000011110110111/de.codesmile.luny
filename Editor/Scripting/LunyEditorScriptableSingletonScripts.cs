// Copyright (C) 2021-2025 Steffen Itterheim
// Refer to included LICENSE file for terms and conditions.

using Lua;
using Luny;
using System;
using UnityEditor;
using UnityEngine;

namespace LunyEditor
{
	// TODO: refactor to generic LunyEditorScripts collection (based on ScriptableSingleton) that supports multiple types of editor scripts

	//[FilePath("ProjectSettings/LunyScriptableSingletonState.asset", FilePathAttribute.Location.ProjectFolder)]
	internal sealed partial class LunyEditorScriptableSingletonScripts : ScriptableSingleton<LunyEditorScriptableSingletonScripts>, ILuaUserData
	{
		private readonly LunyLuaScriptCollection m_Scripts = new();

		internal static LunyEditorScriptableSingletonScripts Singleton => instance; // for consistency

		// It's safe to cache the state since this script is created and destroyed by LunyEditor
		LuaState m_LuaState;

		// Awake runs every time the singleton is instantiated
		private void Awake()
		{
			Debug.Log($"{nameof(LunyEditorScriptableSingletonScripts)}: Awake");
			m_LuaState = LunyEditor.Singleton.Lua.State;
		}

		// Metatable = LuaMetatable.Create(__index);
		//
		// var functions = new LuaTable(0, 1);
		// functions[nameof(Save)] = _Save;
		// Metatable["functions"] = functions;
		// OnEnable runs after every domain reload (including project load)
		private void OnEnable()
		{
			Debug.Log($"{nameof(LunyEditorScriptableSingletonScripts)}: OnEnable");

			foreach (var script in m_Scripts)
				script.TrySendEvent<EditorScriptLifecycleEvent>(m_LuaState, (Int32)EditorScriptLifecycleEvent.OnEnable);

			EditorApplication.update += EditorUpdate;
		}

		// OnDisable runs before every domain reload
		private void OnDisable()
		{
			Debug.Log($"{nameof(LunyEditorScriptableSingletonScripts)}: OnDisable");

			EditorApplication.update -= EditorUpdate;
			SendOnDisable();
		}

		// OnDestroy runs before every domain reload, but only because LunyEditor actively calls DestroyImmediate!
		private void OnDestroy()
		{
			Debug.Log($"{nameof(LunyEditorScriptableSingletonScripts)}: OnDestroy");
			m_LuaState = null;
		}
		private void OnValidate()
		{
			foreach (var script in m_Scripts)
				script.TrySendEvent<EditorScriptLifecycleEvent>(m_LuaState, (Int32)EditorScriptLifecycleEvent.OnValidate);
		}

		private void EditorUpdate()
		{
			foreach (var script in m_Scripts)
				script.TrySendEvent<EditorUpdateEvent>(m_LuaState, (Int32)EditorUpdateEvent.EditorUpdate);
		}

		private void SendOnDisable()
		{
			foreach (var script in m_Scripts)
				script.TrySendEvent<EditorScriptLifecycleEvent>(m_LuaState, (Int32)EditorScriptLifecycleEvent.OnDisable);
		}

		private void SendOnDestroy()
		{
			foreach (var script in m_Scripts)
				script.TrySendEvent<EditorScriptLifecycleEvent>(m_LuaState, (Int32)EditorScriptLifecycleEvent.OnDestroy);

			m_Scripts.Clear();
		}

		internal void Save(LuaTable scriptContext)
		{
			var instance = scriptContext[LunyLuaScript.InstanceKey].Read<LunyEditorScriptableSingletonScripts>();
			Debug.Log($"Save called: {scriptContext[LunyLuaScript.ScriptNameKey]}, {instance}");
			//Save(true);
		}

		internal void DestroyScripts()
		{
			Debug.Log($"{nameof(LunyEditorScriptableSingletonScripts)}: DestroyScripts");
			SendOnDisable();
			SendOnDestroy();

			foreach (var script in m_Scripts)
				script?.Dispose();

			m_Scripts.Clear();
			DestroyImmediate(this);
		}

		internal void AddScript(LunyLuaScript script)
		{
			Debug.Assert(!m_Scripts.Contains(script), $"{nameof(LunyEditorScriptableSingletonScripts)}: Script {script} already added");

			m_Scripts.Add(script);

			var scriptContext = script.ScriptContext;
			scriptContext[LunyLuaScript.InstanceKey] = new LuaValue((ILuaUserData)this);

			// listen to script modification
			script.OnScriptChanged -= OnScriptChanged;
			script.OnScriptChanged += OnScriptChanged;

			// create event handlers
			script.TryCreateEventHandler<EditorScriptLifecycleEvent>();
			script.TryCreateEventHandler<EditorUpdateEvent>();

			var postprocessorEventHandler = script.TryCreateEventHandler<AssetPostprocessorEvent>();
			if (postprocessorEventHandler != null)
				postprocessorEventHandler.EventDispatcher = new AssetPostprocessorScriptEventDispatcher(postprocessorEventHandler);

			// simulate the instantiation events (Reset, Awake, OnEnable)
			script.TrySendEvent<EditorScriptLifecycleEvent>(m_LuaState, (Int32)EditorScriptLifecycleEvent.Reset);
			script.TrySendEvent<EditorScriptLifecycleEvent>(m_LuaState, (Int32)EditorScriptLifecycleEvent.Awake);
			script.TrySendEvent<EditorScriptLifecycleEvent>(m_LuaState, (Int32)EditorScriptLifecycleEvent.OnEnable);
		}

		internal void RemoveScriptForAsset(LunyLuaAsset luaAsset) => m_Scripts.RemoveScriptsForAsset(luaAsset);

		private async void OnScriptChanged(LunyLuaScript script)
		{
			// simulate hot reload events as if it had been a domain reload
			script.TrySendEvent<EditorScriptLifecycleEvent>(m_LuaState, (Int32)EditorScriptLifecycleEvent.OnDisable);

			var task = script.ReloadScript(m_LuaState);
			await task;
			if (task.IsFaulted)
				throw new LuaRuntimeException(m_LuaState.MainThread, task.AsTask().Exception);

			script.TrySendEvent<EditorScriptLifecycleEvent>(m_LuaState, (Int32)EditorScriptLifecycleEvent.OnEnable);
		}

		public override String ToString() => $"{GetType().Name}";
	}

	internal sealed partial class LunyEditorScriptableSingletonScripts
	{
		// private static readonly LuaFunction __index = new(Metamethods.Index, (context, _) =>
		// {
		// 	var userdata = context.GetArgument<ILuaUserData>(0);
		// 	var key = context.GetArgument<String>(1);
		//
		// 	var functions = userdata.Metatable["functions"].Read<LuaTable>();
		// 	Debug.Log($"functions = {functions}");
		// 	foreach (var kvp in functions)
		// 		Debug.Log($"\t{kvp.Key}: {kvp.Value}");
		//
		// 	Debug.Log($"__index({userdata}, \"{key}\") {functions.Count()} => {functions[key]}");
		// 	return new ValueTask<Int32>(context.Return(functions[key]));
		// });

		// private static readonly LuaFunction _Save = new(nameof(Save), (context, _) =>
		// {
		// 	var scriptContext = context.GetArgument<LuaTable>(0);
		// 	Singleton.Save(scriptContext);
		// 	return new ValueTask<Int32>(context.Return());
		// });
		public LuaTable Metatable { get; set; }
	}
}
