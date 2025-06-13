// Copyright (C) 2021-2025 Steffen Itterheim
// Refer to included LICENSE file for terms and conditions.

using CodeSmile.Utility;
using System;
using System.IO;
using System.Threading.Tasks;
using UnityEditor;
using UnityEngine;

namespace CodeSmile.Luny.Components
{
	public interface ILuny
	{
		ILunyLua RuntimeLua { get; }
		ILunyLua ModdingLua { get; }
	}

	/// <summary>
	/// Main Luny component. One must exist in a scene where luny scripts are to be used. Gets created automatically if absent,
	/// using default settings. It is recommend to manually add a GameObject with a Luny component to the scene in order to
	/// configure settings and run startup scripts (eg setup.lua, YourLevelGenerator.lua).
	/// </summary>
	[DisallowMultipleComponent]
	[DefaultExecutionOrder(Int32.MinValue)] // make Luny component run its Awake before any other component
	public sealed class Luny : MonoBehaviour, ILuny
	{
		private static Luny s_Singleton;

		// TODO: refactor to load all scripts with given label automatically ie "ModdingStartupScript"
		// [Tooltip("These scripts will run once, from top to bottom, before any LunyScript runs." +
		//          "Intended for setting up global Lua environment variables and functions.")]
		// [SerializeField] private LunyLuaAsset[] m_StartupScripts = new LunyLuaAsset[0];

		// TODO: consider splitting into LunyRuntimeState and LunyModdingState
		private LunyLua m_RuntimeLua;
		private LunyLua m_ModdingLua;

		public static ILuny Singleton => s_Singleton;
		public ILunyLua RuntimeLua => m_RuntimeLua;
		public ILunyLua ModdingLua => m_ModdingLua;

		private async void Awake()
		{
			if (s_Singleton != null)
			{
				throw new LunyException($"Duplicate Luny component on '{gameObject.name}' ({gameObject.GetInstanceID()}) in " +
				                        $"scene {gameObject.scene.name}. Enter 't:Luny' in Hierarchy search to find them.");
			}

			s_Singleton = this;

			var registry = LunyRuntimeAssetRegistry.Singleton;
			await CreateLuaStates(registry.RuntimeContext, registry.ModdingContext);

			RegisterLunyScriptComponents();
		}

		private void OnDestroy()
		{
			OnDestroyLuny?.Invoke();

			m_RuntimeLua?.Dispose();
			m_ModdingLua?.Dispose();
			m_RuntimeLua = null;
			m_ModdingLua = null;
			s_Singleton = null;
		}

		internal event Action OnDestroyLuny;

		private async ValueTask CreateLuaStates(LunyLuaContext runtimeContext, LunyLuaContext moddingContext)
		{
			m_RuntimeLua?.Dispose();
			m_ModdingLua?.Dispose();
			m_RuntimeLua = new LunyLua(runtimeContext, new RuntimeFileSystem(runtimeContext));
			m_ModdingLua = new LunyLua(moddingContext, new RuntimeFileSystem(moddingContext));

			var registry = LunyRuntimeAssetRegistry.Singleton;
			await m_RuntimeLua.RunScripts(registry.RuntimeStartupLuaAssets);
			await m_ModdingLua.RunScripts(registry.ModdingStartupLuaAssets);
		}

		private void RegisterLunyScriptComponents() => Debug.LogWarning("TODO: RegisterLunyScriptComponents");

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

	internal class RuntimeFileSystem : ILunyLuaFileSystem
	{
		private readonly LunySearchPaths m_SearchPaths;
		private readonly Boolean m_IsSandbox;
		private readonly Boolean m_IsModdingContext;

		public RuntimeFileSystem(LunyLuaContext luaContext)
		{
			m_SearchPaths = new LunySearchPaths(luaContext);
			m_IsSandbox = luaContext.IsSandbox;
			m_IsModdingContext = luaContext.IsModdingContext;
		}

		public Boolean ReadText(String path, out String content)
		{
			content = String.Empty;

			// try read absolute paths directly
			if (m_IsSandbox && Path.IsPathRooted(path))
				throw new NotSupportedException($"cannot access rooted paths in sandbox: {path}");

			// Try read relative paths by looking through search paths
			var fullOrAssetPath = m_SearchPaths.GetFullPathOrAssetPath(path);
			if (fullOrAssetPath == null)
				return true;

			// the asset should be in the registry
			var registry = LunyRuntimeAssetRegistry.Singleton;
			var luaAsset = m_IsModdingContext
				? registry.GetModdingLuaAsset(fullOrAssetPath)
				: registry.GetRuntimeLuaAsset(fullOrAssetPath);

			if (luaAsset != null)
			{
				RuntimeAssetUtility.Import(luaAsset); // pick up any changes to file if Auto-Refresh is disabled

				content = luaAsset.text;
				return true;
			}

			// try read from file system instead (ie could be relative to project working directory)
			if (m_IsSandbox)
				throw new NotSupportedException($"cannot access arbitrary paths in sandbox: {path}");

			content = FileUtility.TryReadAllText(fullOrAssetPath, true);
			return true;
		}

		public Boolean ReadBytes(String path, out Byte[] bytes) => throw new NotImplementedException("ReadBytes");
	}
}
