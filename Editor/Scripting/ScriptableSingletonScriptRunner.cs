// Copyright (C) 2021-2025 Steffen Itterheim
// Refer to included LICENSE file for terms and conditions.

using Lua;
using Lua.Runtime;
using Luny;
using System;
using System.Linq;
using System.Threading.Tasks;
using UnityEditor;
using UnityEngine;

namespace LunyEditor
{
	// TODO: refactor to generic LunyEditorScripts collection (based on ScriptableSingleton) that supports multiple types of editor scripts
	// TODO: does this need ILuaUserData?

	//[FilePath("ProjectSettings/LunyScriptableSingletonState.asset", FilePathAttribute.Location.ProjectFolder)]
	internal sealed partial class ScriptableSingletonScriptRunner : ScriptableSingleton<ScriptableSingletonScriptRunner>, ILuaUserData
	{
		private readonly LunyLuaScriptCollection m_Scripts = new();

		private Boolean m_IsAlreadyDisabled;
		internal static ScriptableSingletonScriptRunner Singleton => instance; // for consistency

		private LunyScriptEventHandler m_AScriptEventHandler;

		// Awake runs every time the singleton is instantiated
		private void Awake()
		{
			Debug.Log("ScriptableSingletonScriptRunner: Awake");
			Metatable = LuaMetatable.Create(__index);

			var functions = new LuaTable(0, 1);
			functions[nameof(Save)] = _Save;
			Metatable["functions"] = functions;
		}

		// OnEnable runs after every domain reload (including project load)
		private void OnEnable()
		{
			Debug.Log("ScriptableSingletonScriptRunner: OnEnable");
			var luaState = LunyEditor.Singleton.Lua.State;
			foreach (var script in m_Scripts)
				script.TrySendEvent<EditorScriptLifecycleEvent>(luaState, (Int32)EditorScriptLifecycleEvent.OnEnable);
		}

		// OnDisable runs before every domain reload
		private void OnDisable()
		{
			Debug.Log("ScriptableSingletonScriptRunner: OnDisable");
			// may run twice (once by Unity before domain reload, the other due to calling DestroyImmediate)
			if (!m_IsAlreadyDisabled)
			{
				m_IsAlreadyDisabled = true;

				var luaState = LunyEditor.Singleton.Lua?.State;
				foreach (var script in m_Scripts)
					script.TrySendEvent<EditorScriptLifecycleEvent>(luaState, (Int32)EditorScriptLifecycleEvent.OnDisable);
			}
		}

		// OnDestroy runs before every domain reload, but only because LunyEditor actively calls DestroyImmediate!
		private void OnDestroy()
		{
			Debug.Log("ScriptableSingletonScriptRunner: OnDestroy");
			var luaState = LunyEditor.Singleton.Lua.State;
			foreach (var script in m_Scripts)
				script.TrySendEvent<EditorScriptLifecycleEvent>(luaState, (Int32)EditorScriptLifecycleEvent.OnDestroy);

			m_Scripts.Clear();
		}

		internal void Save(LuaTable scriptContext)
		{
			var instance = scriptContext[LunyLuaScript.InstanceKey].Read<ScriptableSingletonScriptRunner>();
			Debug.Log($"Save called: {scriptContext[LunyLuaScript.ScriptNameKey]}, {instance}");
			//Save(true);
		}

		internal void DestroyScripts()
		{
			foreach (var script in m_Scripts)
			{
				script?.Dispose();
			}

			m_Scripts.Clear();
			DestroyImmediate(this);
		}

		internal void AddScript(LunyLuaScript script)
		{
			if (m_Scripts.Contains(script))
				throw new ArgumentException($"Script {script} already added");

			m_Scripts.Add(script);

			var context = script.ScriptContext;
			context[LunyLuaScript.InstanceKey] = new LuaValue((ILuaUserData)this);

			script.OnScriptChanged -= OnScriptChanged;
			script.OnScriptChanged += OnScriptChanged;

			// simulate the instantiation events (Reset, Awake, OnEnable)
			var luaState = LunyEditor.Singleton.Lua.State;
			script.TrySendEvent<EditorScriptLifecycleEvent>(luaState, (Int32)EditorScriptLifecycleEvent.Reset);
			script.TrySendEvent<EditorScriptLifecycleEvent>(luaState, (Int32)EditorScriptLifecycleEvent.Awake);
			script.TrySendEvent<EditorScriptLifecycleEvent>(luaState, (Int32)EditorScriptLifecycleEvent.OnEnable);

			m_AScriptEventHandler = AssetPostprocessorScriptEventHandler.TryCreate(context);
		}

		internal void RemoveScriptByAsset(LunyLuaAsset luaAsset) => m_Scripts.Remove(luaAsset);

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

	internal sealed partial class ScriptableSingletonScriptRunner
	{
		private static readonly LuaFunction __index = new(Metamethods.Index, (context, _) =>
		{
			var userdata = context.GetArgument<ILuaUserData>(0);
			var key = context.GetArgument<String>(1);

			var functions = userdata.Metatable["functions"].Read<LuaTable>();
			Debug.Log($"functions = {functions}");
			foreach (var kvp in functions)
				Debug.Log($"\t{kvp.Key}: {kvp.Value}");

			Debug.Log($"__index({userdata}, \"{key}\") {functions.Count()} => {functions[key]}");
			return new ValueTask<Int32>(context.Return(functions[key]));
		});

		private static readonly LuaFunction _Save = new(nameof(Save), (context, _) =>
		{
			var scriptContext = context.GetArgument<LuaTable>(0);
			Singleton.Save(scriptContext);
			return new ValueTask<Int32>(context.Return());
		});
		public LuaTable Metatable { get; set; }
	}
}
