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

		//public static readonly LuaValue[] NoArgs = new LuaValue[0];
		private static ILuny s_Singleton;

		// [Tooltip("These script assets will be run in order from top to bottom before any LunyScript component script runs." +
		//          "Used to set up global Lua values and functions. MonoBehaviour functions will NOT be called on these scripts," +
		//          "and the scripts are not expected to return anything.")]
		// [SerializeField] private LuaAsset[] m_StartupScripts;

		// private ILunyLua m_Lua;
		// private luny m_Api;
		// private ILunyFileWatcher m_FileWatcher;
		// private LunySearchPaths m_SearchPaths;
		// public LunySearchPaths SearchPaths => m_SearchPaths;
		//
		// public ILunyLua MainLua => m_LuaContexts.Length > 0 ? m_LuaContexts[0].Lua : null;
		// public LuaContext[] LuaContexts => m_LuaContexts;

		public static ILuny Singleton => s_Singleton;
		// public ILunyLua Lua => m_Lua;
		// public luny luny => m_Api;

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

			// m_SearchPaths = new LunySearchPaths(new[] { Application.streamingAssetsPath });
			// m_Lua = new LunyLua(m_SearchPaths);
			// m_Api = new LunyApi(m_Lua);

			RegisterLunyScriptComponents();
			await DofileStartupScripts();
		}

		private void OnDestroy()
		{
			OnDestroyLuny?.Invoke();

			// (m_Api as ILunyApiInternal).Dispose();
			// m_Api = null;
			// (m_Lua as ILunyLuaInternal).Dispose();
			// m_Lua = null;

			s_Singleton = null;
		}

		private void RegisterLunyScriptComponents() => throw new NotImplementedException();

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
		private async ValueTask DofileStartupScripts() => throw new NotImplementedException();
		// if (m_StartupScripts == null)
		// 	return;
		//
		// foreach (var startupScript in m_StartupScripts)
		// {
		// 	if (startupScript != null)
		// 		await m_Lua.DoStringAsync(startupScript.Text, startupScript.name);
		// }
	}
}
