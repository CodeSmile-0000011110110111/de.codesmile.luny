// Copyright (C) 2021-2025 Steffen Itterheim
// Refer to included LICENSE file for terms and conditions.

using CodeSmile;
using Lua;
using System;
using System.IO;
using UnityEditor;
using UnityEngine;
using FileUtil = CodeSmile.FileUtil;

namespace Luny
{
	public interface ILunyRuntime
	{
		ILunyLua Lua { get; }
		ILunyLua ModdingLua { get; }
		ILunyRuntimeAssetRegistry AssetRegistry { get; }
	}

	internal interface ILunyRuntimeInternal
	{
		internal event Action OnDestroyLunyRuntime;
	}

	/// <summary>
	/// Main Luny component. One must exist in a scene where luny scripts are to be used. Gets created automatically if absent,
	/// using default settings. It is recommend to manually add a GameObject with a Luny component to the scene in order to
	/// configure settings and run auto-run scripts (eg setup.lua, YourLevelGenerator.lua).
	/// </summary>
	[DisallowMultipleComponent]
	[DefaultExecutionOrder(Int32.MinValue)] // make Luny component run its Awake before any other component
	public sealed class LunyRuntime : MonoBehaviour, ILunyRuntime, ILunyRuntimeInternal
	{
		private static LunyRuntime s_Singleton;
		private static Boolean s_SingletonAssigned;

#if DEBUG || UNITY_EDITOR
		// FIXME: move this into Luny settings ...
		[Tooltip("If enabled, PlayMode will continue to run while the editor is in background. Useful for editing runtime " +
		         "scripts with changes taking effect without having to focus the editor or player window. Only takes effect " +
		         "in development (debug) builds and editor.")]
		[SerializeField] private Boolean m_AlwaysRunInBackgroundInDevelopMode = true;
#endif

		private LunyRuntimeAssetRegistry m_AssetRegistry;

		// TODO: consider splitting into LunyRuntime and LunyModding, or array of states
		private LunyLua m_RuntimeLua;
		private LunyLua m_ModdingLua;
		public ILunyRuntimeAssetRegistry AssetRegistry => m_AssetRegistry;

		public static ILunyRuntime Singleton => s_SingletonAssigned ? s_Singleton : s_Singleton = CreateInstance();
		public ILunyLua Lua => m_RuntimeLua;
		public ILunyLua ModdingLua => m_ModdingLua;

		[RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.SubsystemRegistration)]
		private static void ResetStaticFields()
		{
			s_Singleton = null;
			s_SingletonAssigned = false;
		}

		private static LunyRuntime CreateInstance() => new GameObject(nameof(LunyRuntime)).AddComponent<LunyRuntime>();

		/// <summary>
		/// Can be used for last-second cleanup of anything Luny/Lua related.
		/// </summary>
		event Action ILunyRuntimeInternal.OnDestroyLunyRuntime
		{
			add => OnDestroyLunyRuntime += value;
			remove => OnDestroyLunyRuntime -= value;
		}

#if UNITY_EDITOR
		private void OnValidate() => ApplyRunInBackgroundSetting();
#endif

		private void Awake()
		{
			if (s_Singleton != null)
			{
				throw new LunyException($"Duplicate Luny component on '{gameObject.name}' ({gameObject.GetInstanceID()}) in " +
				                        $"scene {gameObject.scene.name}. Please remove all but one.");
			}

			s_Singleton = this;
			s_SingletonAssigned = true;

			m_AssetRegistry = LunyRuntimeAssetRegistry.Singleton;
			if (m_AssetRegistry == null)
				throw new LunyException($"Missing {nameof(LunyRuntimeAssetRegistry)} resource");

			ApplyRunInBackgroundSetting();

			CreateLuaStates(m_AssetRegistry.RuntimeContext, m_AssetRegistry.ModdingContext);

			//RegisterLunyScriptComponents();
		}

		private void OnDestroy()
		{
			OnDestroyLunyRuntime?.Invoke();

			m_RuntimeLua?.Dispose();
			m_ModdingLua?.Dispose();
			m_RuntimeLua = null;
			m_ModdingLua = null;
			s_Singleton = null;
		}

		private void Update()
		{
			if (m_RuntimeLua != null)
				m_RuntimeLua.NotifyChangedScripts();
			if (m_ModdingLua != null)
				m_ModdingLua.NotifyChangedScripts();
		}

		private event Action OnDestroyLunyRuntime;

		private void ApplyRunInBackgroundSetting()
		{
#if DEBUG || UNITY_EDITOR
			Application.runInBackground = m_AlwaysRunInBackgroundInDevelopMode;
#endif
		}

		private void CreateLuaStates(LunyLuaContext runtimeContext, LunyLuaContext moddingContext)
		{
			m_RuntimeLua?.Dispose();
			m_ModdingLua?.Dispose();
			m_RuntimeLua = new LunyLua(runtimeContext, new RuntimeFileSystem(runtimeContext, m_AssetRegistry));
			m_ModdingLua = new LunyLua(moddingContext, new RuntimeFileSystem(moddingContext, m_AssetRegistry));

#pragma warning disable CS4014 // Because this call is not awaited, execution of the current method continues before the call is completed
			var runtimeAutoRunScripts = LunyLuaAssetScript.Load(m_AssetRegistry.RuntimeAutoRunLuaAssets);
			m_RuntimeLua.AddAndRunScripts(runtimeAutoRunScripts);
			var moddingAutoRunScripts = LunyLuaAssetScript.Load(m_AssetRegistry.ModdingAutoRunLuaAssets);
			m_ModdingLua.AddAndRunScripts(moddingAutoRunScripts);
#pragma warning restore CS4014

			// Test running mod scripts
			// {
			// 	var ctx = new LuaTable();
			// 	ctx["streamingAssetsScript"] = true;
			// 	await m_ModdingLua.AddAndRunScript(new LunyLuaFileScript("Assets/StreamingAssets/StreamingLua.lua",
			// 		ctx));
			// }
			// {
			// 	var ctx = new LuaTable();
			// 	ctx["persistentDataScript"] = true;
			// 	await m_ModdingLua.AddAndRunScript(new LunyLuaFileScript(Application.persistentDataPath + "/PersistentLua.lua",
			// 		ctx));
			// }
		}

		//private void RegisterLunyScriptComponents() => Debug.LogWarning("TODO: RegisterLunyScriptComponents");

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

	internal class RuntimeFileSystem : ILunyFileSystemHook
	{
		private readonly LuaSearchPaths m_SearchPaths;
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
				var lowerPath = path.ToLower();
				if (lowerPath.StartsWith(Application.streamingAssetsPath.ToLower()) ||
				    lowerPath.StartsWith(Application.persistentDataPath.ToLower()))
				{
					content = FileUtil.TryReadAllText(path);
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
				AssetUtil.IfEditorImportAsset(luaAsset); // pick up any changes to file if Auto-Refresh is disabled

				content = luaAsset.Text;
				return true;
			}

			// try read from file system instead (ie could be relative to project working directory)
			content = FileUtil.TryReadAllText(fullOrAssetPath, true);
			return true;
		}

		public Boolean ReadBytes(String path, out Byte[] bytes) => throw new NotImplementedException("ReadBytes");

		public String TryGetAssetPath(String pathOrChunkName) =>
			$"@{m_SearchPaths.GetFullPath(pathOrChunkName[0] == '@' ? pathOrChunkName.Substring(1) : pathOrChunkName)}";
	}
}
