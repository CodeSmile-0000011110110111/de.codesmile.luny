// Copyright (C) 2021-2025 Steffen Itterheim
// Refer to included LICENSE file for terms and conditions.

using Lua;
using System;
using System.IO;
using System.Threading.Tasks;
using UnityEditor;
using UnityEngine;

namespace CodeSmile.Luny.Components
{
	public interface ILunyRuntime
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
	public sealed class LunyRuntime : MonoBehaviour, ILunyRuntime
	{
		private static LunyRuntime s_Singleton;
		[SerializeField] [HideInInspector] private LunyRuntimeAssetRegistry m_AssetRegistry;

		// TODO: refactor to load all scripts with given label automatically ie "ModdingStartupScript"
		// [Tooltip("These scripts will run once, from top to bottom, before any LunyScript runs." +
		//          "Intended for setting up global Lua environment variables and functions.")]
		// [SerializeField] private LunyLuaAsset[] m_StartupScripts = new LunyLuaAsset[0];

		// TODO: consider splitting into LunyRuntimeState and LunyModdingState
		private LunyLua m_RuntimeLua;
		private LunyLua m_ModdingLua;

		public static ILunyRuntime Singleton => s_Singleton;
		public ILunyLua RuntimeLua => m_RuntimeLua;
		public ILunyLua ModdingLua => m_ModdingLua;

		private void OnValidate() => m_AssetRegistry = LunyRuntimeAssetRegistry.Singleton; // ensure it is assigned for builds

		private async void Awake()
		{
			if (m_AssetRegistry == null)
				throw new LunyException("Missing reference to asset registry.");

			if (s_Singleton != null)
			{
				throw new LunyException($"Duplicate Luny component on '{gameObject.name}' ({gameObject.GetInstanceID()}) in " +
				                        $"scene {gameObject.scene.name}. Enter 't:Luny' in Hierarchy search to find them.");
			}

			s_Singleton = this;

			await CreateLuaStates(m_AssetRegistry.RuntimeContext, m_AssetRegistry.ModdingContext);

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

		private void Update()
		{
			if (m_RuntimeLua != null)
				m_RuntimeLua.Update();
			if (m_ModdingLua != null)
				m_ModdingLua.Update();
		}

		internal event Action OnDestroyLuny;

		private async ValueTask CreateLuaStates(LunyLuaContext runtimeContext, LunyLuaContext moddingContext)
		{
			m_RuntimeLua?.Dispose();
			m_ModdingLua?.Dispose();
			m_RuntimeLua = new LunyLua(runtimeContext, new RuntimeFileSystem(runtimeContext, m_AssetRegistry));
			m_ModdingLua = new LunyLua(moddingContext, new RuntimeFileSystem(moddingContext, m_AssetRegistry));

			var runtimeStartupScripts = LunyLuaAssetScript.CreateAll(m_AssetRegistry.RuntimeStartupLuaAssets);
			await m_RuntimeLua.AddAndRunScripts(runtimeStartupScripts);
			var moddingStartupScripts = LunyLuaAssetScript.CreateAll(m_AssetRegistry.ModdingStartupLuaAssets);
			await m_ModdingLua.AddAndRunScripts(moddingStartupScripts);

			{
				var ctx = new LuaTable();
				ctx["streamingAssetsScript"] = true;
				await m_ModdingLua.AddAndRunScript(new LunyLuaFileScript(Application.streamingAssetsPath + "/StreamingLua.lua",
					ctx));
			}
			{
				var ctx = new LuaTable();
				ctx["persistentDataScript"] = true;
				await m_ModdingLua.AddAndRunScript(new LunyLuaFileScript(Application.persistentDataPath + "/PersistentLua.lua",
					ctx));
			}
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
		private readonly LunyRuntimeAssetRegistry m_AssetRegistry;

		public RuntimeFileSystem(LunyLuaContext luaContext, LunyRuntimeAssetRegistry assetRegistry)
		{
			m_SearchPaths = luaContext.SearchPaths;
			m_IsSandbox = luaContext.IsSandbox;
			m_IsModdingContext = luaContext.IsModdingContext;
			m_AssetRegistry = assetRegistry;
		}

		public Boolean ReadText(String path, out String content)
		{
			content = String.Empty;

			// try read absolute paths directly
			if (Path.IsPathRooted(path))
			{
				// do allow access to StreamingAssets and PersistentData folders
				if (path.StartsWith(Application.streamingAssetsPath) || path.StartsWith(Application.persistentDataPath))
				{
					content = FileUtility.TryReadAllText(path);
					return true;
				}

				if (m_IsSandbox)
					throw new NotSupportedException($"cannot access rooted paths in sandbox: {path}");
			}

			// Try read relative paths by looking through search paths
			var fullOrAssetPath = m_SearchPaths.GetFullPath(path);
			if (fullOrAssetPath == null)
				return true;

			// the asset should be in the registry
			var luaAsset = m_IsModdingContext
				? m_AssetRegistry.GetModdingLuaAsset(fullOrAssetPath)
				: m_AssetRegistry.GetRuntimeLuaAsset(fullOrAssetPath);

			if (luaAsset != null)
			{
				EditorAssetUtility.Import(luaAsset); // pick up any changes to file if Auto-Refresh is disabled

				content = luaAsset.Text;
				return true;
			}

			// try read from file system instead (ie could be relative to project working directory)
			content = FileUtility.TryReadAllText(fullOrAssetPath, true);
			return true;
		}

		public Boolean ReadBytes(String path, out Byte[] bytes) => throw new NotImplementedException("ReadBytes");

		public String TryGetAssetPath(String pathOrChunkName) =>
			$"@{m_SearchPaths.GetFullPath(pathOrChunkName[0] == '@' ? pathOrChunkName.Substring(1) : pathOrChunkName)}";
	}
}
