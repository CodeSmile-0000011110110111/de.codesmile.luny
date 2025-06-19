// Copyright (C) 2021-2025 Steffen Itterheim
// Refer to included LICENSE file for terms and conditions.

using CodeSmile.Luny;
using CodeSmile.Luny.Components;
using CodeSmileEditor.Core;
using System;
using System.IO;
using System.Text.RegularExpressions;
using UnityEditor;
using UnityEngine;

namespace CodeSmileEditor.Luny
{
	internal static class CreateLunyAssetsMenu
	{
		private static readonly String s_EmptyLuaScript = "-- 'script' can be renamed, but it must be a table\n" +
		                                                  "-- the three dots (...) represent variable arguments passed in (reserved for future use)\n" +
		                                                  "local script = {...}\n" +
		                                                  "-- you are free to add custom variables to script, these are read/writeable in C#\n" +
		                                                  "script.OhWowThatsCoolBool = true\n" +
		                                                  "\n" +
		                                                  "-- any Unity event can be a Lua function defined in the 'script' table\n" +
		                                                  "function script.Start()\n" +
		                                                  "	print(\"Hello, \" .. script.name .. \".lua on \" .. tostring(script.gameObject))\n" +
		                                                  "end\n" +
		                                                  "\n" +
		                                                  "-- scripts must return a table containing zero or more Unity event functions\n" +
		                                                  "return script\n";

		private static readonly String s_EmptyLunyScript = "using CodeSmile.Luny;\n" +
		                                                   "using UnityEngine;\n\n" +
		                                                   "public sealed class $ClassName$ : LunyScript\n{\n" +
		                                                   "\t// Awake cannot be overridden, use OnAwake instead. " +
		                                                   "The script has not been loaded at this point!\n" +
		                                                   "\tprotected override void OnAwake()\n\t{\n\t}\n\n" +
		                                                   "\t// Script was run and returned a LuaTable. " +
		                                                   "Script's Awake() function has not been called yet.\n" +
		                                                   "\t// You may want to get/set initial script variables before script's Awake():\n" +
		                                                   "\tprotected override void OnBeforeScriptAwake()\n\t{\n" +
		                                                   "\t\t// Variables are set to the script table (commonly named 'script'):" +
		                                                   " 'print(script.ImportantMessage)'\n" +
		                                                   "\t\tSetString(\"ImportantMessage\", \"Testing One-Two-Three ..\");\n\n" +
		                                                   "\t\t// If you need the value of 'script.OhWowThatsCoolBool' assigned by" +
		                                                   " the Lua script:\n" +
		                                                   "\t\tvar datBool = GetBool(\"OhWowThatsCoolBool\");\n" +
		                                                   "\t}\n}\n";

		private static Boolean s_WillCreateLunyScript;
		private static Boolean s_WillCreateStartupScript;

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

		[MenuItem("Assets/Create/Luny/Empty LunyScript (C# + Lua)", false, priority = 5)]
		private static void CreateLunyScripts()
		{
			s_WillCreateLunyScript = true;
			ProjectWindowUtil.CreateAssetWithContent("NewLunyScript.lua", s_EmptyLuaScript);
		}

		[MenuItem("Assets/Create/Luny/Empty Lua Script", false, priority = 6)]
		private static void CreateLuaScript() =>
			ProjectWindowUtil.CreateAssetWithContent("NewLuaScript.lua", @"print(""Hello, Lua!"")");

		[MenuItem("Assets/Create/Luny/Empty Startup Lua Script", false, priority = 7)]
		private static void CreateStartupLuaScript()
		{
			s_WillCreateStartupScript = true;
			ProjectWindowUtil.CreateAssetWithContent("NewStartupLuaScript.lua", @"print(""Hello, Startup Lua!"")");
		}

		[MenuItem("GameObject/Luny/" + nameof(Luny), false, priority = 10)]
		private static void CreateLunyGameObject(MenuCommand menuCommand)
		{
			var luny = new GameObject(nameof(Luny), typeof(CodeSmile.Luny.Components.LunyRuntime));
			var go = luny.gameObject;
			GameObjectUtility.SetParentAndAlign(go, menuCommand.context as GameObject);
			Undo.RegisterCreatedObjectUndo(go, "Create " + go.name);
			Selection.activeObject = go;
		}

		[MenuItem("GameObject/Luny/" + nameof(LunyScript), false, priority = 11)]
		private static void CreateLunyScriptGameObject(MenuCommand menuCommand)
		{
			var go = LunyScript.CreateGameObject();
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

		private static void AddToStartupScripts(String assetPath)
		{
			var settings = LunyProjectSettings.Singleton;
			var luaAsset = AssetDatabase.LoadAssetAtPath<LunyLuaAsset>(assetPath);
			if (luaAsset is LunyEditorLuaAsset editorLuaAsset)
				settings.EditorStartupScripts.Add(editorLuaAsset);
			else if (luaAsset is LunyRuntimeLuaAsset runtimeLuaAsset)
				settings.RuntimeStartupScripts.Add(runtimeLuaAsset);
			else if (luaAsset is LunyModdingLuaAsset moddingLuaAsset)
				settings.ModdingStartupScripts.Add(moddingLuaAsset);

			settings.Save();
		}

		private sealed class AssetCreateMonitor : AssetModificationProcessor
		{
			private static void OnWillCreateAsset(String assetPath)
			{
				if (s_WillCreateLunyScript && AssetUtility.IsLuaScript(assetPath))
				{
					s_WillCreateLunyScript = false;
					CreateMatchingCSharpLunyScript(assetPath);
				}

				if (s_WillCreateStartupScript && AssetUtility.IsLuaScript(assetPath))
				{
					s_WillCreateStartupScript = false;
					EditorApplication.delayCall += () => AddToStartupScripts(assetPath); // required delay
				}
			}
		}
	}
}
