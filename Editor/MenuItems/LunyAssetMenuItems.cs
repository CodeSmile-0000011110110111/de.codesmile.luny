// Copyright (C) 2021-2025 Steffen Itterheim
// Refer to included LICENSE file for terms and conditions.

using Luny;
using LunyEditor.Core;
using LunyEditor.Settings;
using System;
using System.IO;
using System.Text.RegularExpressions;
using UnityEditor;
using UnityEngine;

namespace LunyEditor.MenuItems
{
	internal static class CreateLunyAssetsMenu
	{
		private static readonly String s_LuaScriptContext =
			"-- assign script's context table to a local variable:\n" +
			"local script = ...\n\n";

		private static readonly String s_EmptyLuaScript = s_LuaScriptContext +
		                                                  "-- Unity event messages call Lua functions of the same name in the 'script' table:\n" +
		                                                  "script.OnEnable = function()\n" +
		                                                  "	print(\"Hello, \" .. context.Name .. \".lua\")\n" +
		                                                  "end\n";

		private static readonly String s_EmptyLunyScript = "using Lua;\n" +
		                                                   "using Luny;\n" +
		                                                   "using UnityEngine;\n\n" +
		                                                   "public sealed class $ClassName$ : LunyRuntimeScript\n{\n" +
		                                                   "\t// To get/set script variables when the script is first loaded:\n" +
		                                                   "\tprotected override void OnBeforeInitialScriptLoad(LuaTable scriptContext)\n\t{\n\t}\n\n" +
		                                                   "\t// To get/set script variables every time the script is loaded (incl. hot reload):\n" +
		                                                   "\tprotected override void OnBeforeScriptLoad(LuaTable scriptContext) \n\t{\n\t}\n\n" +
		                                                   "\t// To get/set script variables every time after the script was loaded (incl. hot reload):\n" +
		                                                   "\tprotected override void OnAfterScriptLoad(LuaTable scriptContext)\n\t{\n\t}\n" +
		                                                   "}";

		private static Boolean s_WillCreateLunyScript;
		private static Boolean s_WillCreateAutoRunScript;

		// copied verbatim from ProjectWindowUtil
		internal static String SetLineEndings(String content, LineEndingsMode lineEndingsMode)
		{
			String replacement;
			switch (lineEndingsMode)
			{
				case LineEndingsMode.OSNative:
					replacement = Application.platform != RuntimePlatform.WindowsEditor ? "\n" : "\r\n";
					break;
				case LineEndingsMode.Unix:
					replacement = "\n";
					break;
				case LineEndingsMode.Windows:
					replacement = "\r\n";
					break;
				default:
					replacement = "\n";
					break;
			}
			content = Regex.Replace(content, "\\r\\n?|\\n", replacement);
			return content;
		}

		[MenuItem("Assets/Create/Luny/LunyScript C# + Lua", false, priority = 5)]
		private static void CreateLunyScripts()
		{
			s_WillCreateLunyScript = true;
			ProjectWindowUtil.CreateAssetWithContent("New LunyScript.lua", s_EmptyLuaScript);
		}

		[MenuItem("Assets/Create/Luny/Lua Script", false, priority = 6)]
		private static void CreateLuaScript() => ProjectWindowUtil.CreateAssetWithContent("New Lua Script.lua", @"print(""Hello, Lua!"")");

		[MenuItem("Assets/Create/Luny/Editor Lua Script", false, priority = 7)]
		private static void CreateEditorAutoRunLuaScript()
		{
			s_WillCreateAutoRunScript = true;
			ProjectWindowUtil.CreateAssetWithContent("New Auto-Run Lua Script.lua", s_EmptyLuaScript);
		}

		[MenuItem("GameObject/Luny/Luny Runtime", false, priority = 10)]
		private static void CreateLunyGameObject(MenuCommand menuCommand)
		{
			var luny = new GameObject(nameof(LunyRuntime), typeof(LunyRuntime));
			var go = luny.gameObject;
			GameObjectUtility.SetParentAndAlign(go, menuCommand.context as GameObject);
			Undo.RegisterCreatedObjectUndo(go, "Create " + go.name);
			Selection.activeObject = go;
		}

		[MenuItem("GameObject/Luny/Luny Script", false, priority = 11)]
		private static void CreateLunyScriptGameObject(MenuCommand menuCommand)
		{
			var go = LunyRuntimeScript.CreateLunyScriptObject();
			GameObjectUtility.SetParentAndAlign(go, menuCommand.context as GameObject);
			Undo.RegisterCreatedObjectUndo(go, "Create " + go.name);
			Selection.activeObject = go;
		}

		private static void CreateMatchingCSharpLunyScript(String luaScriptPath)
		{
			var scriptPath = Path.ChangeExtension(luaScriptPath, ".cs");
			var className = Path.GetFileNameWithoutExtension(luaScriptPath).Replace(" ", "_");
			var contents = s_EmptyLunyScript.Replace("$ClassName$", className);
			contents = SetLineEndings(contents, EditorSettings.lineEndingsForNewScripts);
			File.WriteAllText(Path.GetFullPath(scriptPath), contents);
			AssetDatabase.ImportAsset(scriptPath);
		}

		private static void AddToAutoRunScripts(String assetPath)
		{
			var settings = LunyProjectSettings.Singleton;
			var luaAsset = AssetDatabase.LoadAssetAtPath<LunyLuaAsset>(assetPath);
			if (luaAsset is LunyEditorLuaAsset editorLuaAsset)
				settings.EditorAutoRunLuaAssets.Add(editorLuaAsset);
			else if (luaAsset is LunyModdingLuaAsset moddingLuaAsset)
				settings.ModdingAutoRunLuaAssets.Add(moddingLuaAsset);
			else if (luaAsset is LunyRuntimeLuaAsset runtimeLuaAsset)
				settings.RuntimeAutoRunLuaAssets.Add(runtimeLuaAsset);

			settings.Save();
		}

		private sealed class AssetCreateMonitor : AssetModificationProcessor
		{
			private static void OnWillCreateAsset(String assetPath)
			{
				if (s_WillCreateLunyScript && EditorAssetUtil.IsLuaScript(assetPath))
				{
					s_WillCreateLunyScript = false;
					CreateMatchingCSharpLunyScript(assetPath);
				}

				if (s_WillCreateAutoRunScript && EditorAssetUtil.IsLuaScript(assetPath))
				{
					s_WillCreateAutoRunScript = false;
					EditorApplication.delayCall += () => AddToAutoRunScripts(assetPath); // required delay
				}
			}
		}
	}
}
