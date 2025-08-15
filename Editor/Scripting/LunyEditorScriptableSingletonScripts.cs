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

		private void OnValidate()
		{
			var luaState = LunyEditor.Singleton.Lua.State;
			foreach (var script in m_Scripts)
				script.TrySendEvent<EditorScriptLifecycleEvent>(luaState, (Int32)EditorScriptLifecycleEvent.OnValidate);
		}

		// Awake runs every time the singleton is instantiated
		private void Awake()
		{
			Debug.Log($"{nameof(LunyEditorScriptableSingletonScripts)}: Awake");
			EditorApplication.update += EditorUpdate;
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
			var luaState = LunyEditor.Singleton.Lua.State;
			foreach (var script in m_Scripts)
				script.TrySendEvent<EditorScriptLifecycleEvent>(luaState, (Int32)EditorScriptLifecycleEvent.OnEnable);
		}

		// OnDisable runs before every domain reload
		private void OnDisable()
		{
			Debug.Log($"{nameof(LunyEditorScriptableSingletonScripts)}: OnDisable");
			// may run twice (once by Unity before domain reload, the other due to calling DestroyImmediate)
			SendOnDisable();
		}

		// OnDestroy runs before every domain reload, but only because LunyEditor actively calls DestroyImmediate!
		private void OnDestroy() => Debug.Log($"{nameof(LunyEditorScriptableSingletonScripts)}: OnDestroy");

		private void EditorUpdate()
		{
			var luaState = LunyEditor.Singleton.Lua?.State;
			foreach (var script in m_Scripts)
				script.TrySendEvent<EditorUpdateEvent>(luaState, (Int32)EditorUpdateEvent.EditorUpdate);
		}

		private void SendOnDisable()
		{
			var luaState = LunyEditor.Singleton.Lua?.State;
			foreach (var script in m_Scripts)
				script.TrySendEvent<EditorScriptLifecycleEvent>(luaState, (Int32)EditorScriptLifecycleEvent.OnDisable);
		}

		private void SendOnDestroy()
		{
			var luaState = LunyEditor.Singleton.Lua?.State;
			foreach (var script in m_Scripts)
				script.TrySendEvent<EditorScriptLifecycleEvent>(luaState, (Int32)EditorScriptLifecycleEvent.OnDestroy);

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
			var luaState = LunyEditor.Singleton.Lua.State;
			script.TrySendEvent<EditorScriptLifecycleEvent>(luaState, (Int32)EditorScriptLifecycleEvent.Reset);
			script.TrySendEvent<EditorScriptLifecycleEvent>(luaState, (Int32)EditorScriptLifecycleEvent.Awake);
			script.TrySendEvent<EditorScriptLifecycleEvent>(luaState, (Int32)EditorScriptLifecycleEvent.OnEnable);
		}

		internal void RemoveScriptForAsset(LunyLuaAsset luaAsset) => m_Scripts.RemoveScriptForAsset(luaAsset);

		private async void OnScriptChanged(LunyLuaScript script)
		{
			var luaState = LunyEditor.Singleton.Lua.State;

			// simulate hot reload events as if it had been a domain reload
			script.TrySendEvent<EditorScriptLifecycleEvent>(luaState, (Int32)EditorScriptLifecycleEvent.OnDisable);

			var task = script.ReloadScript(luaState);
			await task;
			if (task.IsFaulted)
				throw new LuaRuntimeException(luaState.MainThread, task.AsTask().Exception);

			script.TrySendEvent<EditorScriptLifecycleEvent>(luaState, (Int32)EditorScriptLifecycleEvent.OnEnable);
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
