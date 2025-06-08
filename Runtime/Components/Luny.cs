// Copyright (C) 2021-2025 Steffen Itterheim
// Refer to included LICENSE file for terms and conditions.

using System;
using System.Threading.Tasks;
using UnityEditor;
using UnityEngine;

namespace CodeSmile.Luny
{
	public interface ILuny
	{
		// ILunyLua Lua { get; }
		// ILunyLua MainLua { get; }
		// LuaContext[] LuaContexts { get; }
		// LuaAssetRegistry Registry { get; }
	}

	internal interface ILunyInternal
	{
		event Action OnDestroyLuny;
	}

	/// <summary>
	/// Main Luny component. One must exist in a scene where luny scripts are to be used. Gets created automatically if absent,
	/// using default settings. It is recommend to manually add a GameObject with a Luny component to the scene in order to
	/// configure settings and run startup scripts (eg setup.lua, YourLevelGenerator.lua).
	/// </summary>
	[DisallowMultipleComponent]
	[DefaultExecutionOrder(Int32.MinValue)] // make Luny component run its Awake before any other component
	public sealed class Luny : MonoBehaviour, ILuny, ILunyInternal
	{
		public event Action OnDestroyLuny;

		private static ILuny s_Singleton;

		[Tooltip("These scripts will run once, from top to bottom, before any LunyScript runs." +
		         "Intended for setting up global Lua environment variables and functions.")]
		[SerializeField] private LunyLuaAsset[] m_StartupScripts = new LunyLuaAsset[0];

		private ILunyLua m_Lua;
		// private ILunyFileWatcher m_FileWatcher;
		//
		// public ILunyLua MainLua => m_LuaContexts.Length > 0 ? m_LuaContexts[0].Lua : null;
		// public LuaContext[] LuaContexts => m_LuaContexts;

		public static ILuny Singleton => s_Singleton;
		public ILunyLua Lua => m_Lua;

		// Not strictly necessary since singleton is null'ed in OnDestroy
		[RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.SubsystemRegistration)]
		private static void ResetStaticFields() => s_Singleton = null;

		private async void Awake()
		{
			if (s_Singleton != null)
			{
				throw new LunyException($"Duplicate Luny component on '{gameObject.name}' ({gameObject.GetInstanceID()}) in " +
				                        $"scene {gameObject.scene.name}. Type 't:Luny' in Hierarchy search field to find them.");
			}

			s_Singleton = this;

			m_Lua = new LunyLua(LunyRuntimeAssetRegistry.Singleton.DefaultContext);

			RegisterLunyScriptComponents();
			await RunStartupScripts();
		}

		private void OnDestroy()
		{
			OnDestroyLuny?.Invoke();

			// (m_Lua as ILunyLuaInternal).Dispose();
			// m_Lua = null;

			s_Singleton = null;
		}

		private void RegisterLunyScriptComponents()
		{
			Debug.LogWarning("TODO: RegisterLunyScriptComponents");
			// var lunyScriptTypes = AppDomain.CurrentDomain.GetAssemblies()
			// 	.SelectMany(assembly => assembly.GetTypes())
			// 	.Where(type => type.IsSubclassOf(typeof(LunyScript)));
			//
			// var sb = new StringBuilder();
			// var env = m_Lua.State.Environment;
			// foreach (var lunyScriptType in lunyScriptTypes)
			// {
			// 	var factory = new LunyScriptFactory(lunyScriptType, m_LunyScriptTypesAreLowercase);
			// 	env.SetLunyComponentApi(lunyScriptType, factory);
			//
			// 	if (m_LogLunyScriptTypes)
			// 	{
			// 		sb.Append(sb.Length == 0 ? "Registered LunyScript components:\n" : "\n");
			// 		sb.Append(factory.ApiName);
			// 	}
			// }
			//
			// if (m_LogLunyScriptTypes)
			// 	LunyLogger.LogInfo(sb.ToString());
		}

		private async ValueTask RunStartupScripts()
		{
			Debug.LogWarning("TODO: RunStartupScripts");

			// foreach (var startupScript in m_StartupScripts)
			// {
			// 	if (startupScript != null)
			// 		await m_Lua.DoStringAsync(startupScript.Text, startupScript.name);
			// }
		}
	}
}
