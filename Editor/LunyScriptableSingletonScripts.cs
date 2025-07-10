// Copyright (C) 2021-2025 Steffen Itterheim
// Refer to included LICENSE file for terms and conditions.

using CodeSmile.Luny;
using Lua;
using Lua.Runtime;
using System;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using UnityEditor;
using UnityEngine;

namespace CodeSmileEditor.Luny
{
	//[FilePath("ProjectSettings/LunyScriptableSingletonState.asset", FilePathAttribute.Location.ProjectFolder)]
	internal sealed class LunyScriptableSingletonScripts : ScriptableSingleton<LunyScriptableSingletonScripts>, ILuaUserData
	{
		private readonly LunyLuaScriptCollection m_Scripts = new();
		private Boolean m_IsAlreadyDisabled;

		internal static LunyScriptableSingletonScripts Singleton => instance; // for consistency
		public LuaTable Metatable { get; set; }

		private static ValueTask<Int32> LuaTryGetValueForKey(LuaFunctionExecutionContext context,
			CancellationToken cancellationToken)
		{
			var userdata = context.GetArgument<ILuaUserData>(0);
			var key = context.GetArgument<String>(1);

			var functions = userdata.Metatable["functions"].Read<LuaTable>();
			Debug.Log($"functions = {functions}");
			foreach (var kvp in functions)
				Debug.Log($"\t{kvp.Key}: {kvp.Value}");

			Debug.Log($"LuaTryGetValueForKey({userdata}, \"{key}\") {functions.Count()} => {functions[key]}");
			return new ValueTask<Int32>(context.Return(functions[key]));
		}

		private static ValueTask<Int32> LuaToString(LuaFunctionExecutionContext context, CancellationToken cancellationToken)
		{
			var userdata = context.GetArgument<ILuaUserData>(0);
			return new ValueTask<Int32>(context.Return(userdata.ToString()));
		}

		private static ValueTask<Int32> LuaSave(LuaFunctionExecutionContext context, CancellationToken cancellationToken)
		{
			var scriptContext = context.GetArgument<LuaTable>(0);
			Singleton.Save(scriptContext);
			return new ValueTask<Int32>(context.Return());
		}

		// Awake runs every time the singleton is instantiated
		private void Awake()
		{
			Metatable = new LuaTable(0, 4);
			Metatable[Metamethods.Index] = new LuaFunction("__index", LuaTryGetValueForKey);
			Metatable[Metamethods.ToString] = new LuaFunction("__tostring", LuaToString);

			var functions = new LuaTable(0, 4);
			functions[nameof(Save)] = new LuaFunction(nameof(Save), LuaSave);
			Metatable["functions"] = functions;
		}

		// OnEnable runs after every domain reload (including project load)
		private void OnEnable()
		{
			var luaState = LunyEditor.Singleton.Lua.State;
			foreach (var script in m_Scripts)
			{
				var lifecycleEvent = script.EventHandler<ScriptLifecycleEvent>();
				lifecycleEvent.Send(luaState, (Int32)ScriptLifecycleEvent.OnEnable);
			}
		}

		// OnDisable runs before every domain reload
		private void OnDisable()
		{
			// may run twice (once by Unity before domain reload, the other due to calling DestroyImmediate)
			if (!m_IsAlreadyDisabled)
			{
				m_IsAlreadyDisabled = true;

				var luaState = LunyEditor.Singleton.Lua?.State;
				foreach (var script in m_Scripts)
				{
					var lifecycleEvent = script.EventHandler<ScriptLifecycleEvent>();
					lifecycleEvent.Send(luaState, (Int32)ScriptLifecycleEvent.OnDisable);
				}
			}
		}

		// OnDestroy runs before every domain reload, but only because LunyEditor actively calls DestroyImmediate!
		private void OnDestroy()
		{
			var luaState = LunyEditor.Singleton.Lua.State;
			foreach (var script in m_Scripts)
			{
				var lifecycleEvent = script.EventHandler<ScriptLifecycleEvent>();
				lifecycleEvent.Send(luaState, (Int32)ScriptLifecycleEvent.OnDestroy);
			}

			m_Scripts.Clear();
		}

		internal void Save(LuaTable scriptContext)
		{
			var instance = scriptContext[LunyLuaScript.InstanceKey].Read<LunyScriptableSingletonScripts>();
			Debug.Log($"Save called: {scriptContext[LunyLuaScript.ScriptNameKey]}, {instance}");
			//Save(true);
		}

		public override String ToString() => $"{GetType().Name}";

		internal void AddScript(LunyLuaScript script)
		{
			if (m_Scripts.Contains(script))
				throw new ArgumentException($"Script {script} already added");

			m_Scripts.Add(script);

			var context = script.ScriptContext;
			context[LunyLuaScript.InstanceKey] = new LuaValue((ILuaUserData)this);
			context[nameof(Save)] = new LuaFunction(nameof(Save), LuaSave);

			script.OnScriptChanged -= OnScriptChanged;
			script.OnScriptChanged += OnScriptChanged;

			// simulate the instantiation events
			var luaState = LunyEditor.Singleton.Lua.State;
			var editorOnlyEvent = script.EventHandler<ScriptEditorOnlyEvent>();
			editorOnlyEvent.Send(luaState, (Int32)ScriptEditorOnlyEvent.Reset);

			var lifecycleEvent = script.EventHandler<ScriptLifecycleEvent>();
			lifecycleEvent.Send(luaState, (Int32)ScriptLifecycleEvent.Awake);
			lifecycleEvent.Send(luaState, (Int32)ScriptLifecycleEvent.OnEnable);
		}

		private void OnScriptChanged(LunyLuaScript script)
		{
			var luaState = LunyEditor.Singleton.Lua.State;
			var lifecycleEvent = script.EventHandler<ScriptLifecycleEvent>();

			// simulate events as if file change had been a domain reload
			lifecycleEvent.Send(luaState, (Int32)ScriptLifecycleEvent.OnDisable);
			script.ReloadScript(luaState).Preserve().GetAwaiter().GetResult();
			lifecycleEvent.Send(luaState, (Int32)ScriptLifecycleEvent.OnEnable);
		}

		public void RemoveScriptByAsset(LunyLuaAsset luaAsset) => m_Scripts.Remove(luaAsset);
	}
}
