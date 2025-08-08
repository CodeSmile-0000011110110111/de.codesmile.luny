// Copyright (C) 2021-2025 Steffen Itterheim
// Refer to included LICENSE file for terms and conditions.

using System;
using System.IO;
using System.Text;
using UnityEditor;
using UnityEditor.Compilation;
using UnityEngine;
using Object = System.Object;

namespace Luny.Core
{
	/// <summary>
	/// Captures all text written to standard output aka StdOut (eg Terminal/Prompt, batch/bash scripts, C# Console.Write)
	/// and prints each line with Debug.Log to the Unity Console window. Such logs are prefixed with "> " to denote logs
	/// captured from standard output.
	/// </summary>
	/// <remarks>
	/// This functionality can be toggled under Window/CodeSmile/Capture Standard Output. At runtime it can
	/// be enabled by calling CaptureStandardOutput.Activate() or Deactivate().
	/// </remarks>
	public static class CaptureStandardOutput
	{
		private const String LogPrefix = "> ";
		private static TextWriter m_StdOutWriter;

		public static void Activate()
		{
			if (m_StdOutWriter == null)
			{
				m_StdOutWriter = Console.Out;
				Console.SetOut(new UnityConsoleWriter());
				Debug.LogWarning($"StdOut capture enabled. Logs prefixed with '{LogPrefix}' are Terminal logs.");
			}
		}

		public static void Deactivate()
		{
			if (m_StdOutWriter != null)
			{
				Console.SetOut(m_StdOutWriter);
				m_StdOutWriter = null;
			}
		}

		private class UnityConsoleWriter : TextWriter
		{
			private readonly StringBuilder m_CurrentStdOutLine = new();
			public override Encoding Encoding => Encoding.Default;

			public override void Write(String text)
			{
				lock (m_CurrentStdOutLine)
					m_CurrentStdOutLine.Append(text);

				if (text != null && text.Length > 0 && text[text.Length - 1] == '\n')
					Flush();
			}

			public override void Write(Char character)
			{
				lock (m_CurrentStdOutLine)
					m_CurrentStdOutLine.Append(character);

				if (character == '\n')
					Flush();
			}

			public override void Write(Char[] value, Int32 index, Int32 count) => Write(new String(value, index, count));

			public override void Flush()
			{
				lock (m_CurrentStdOutLine)
				{
					m_CurrentStdOutLine.Insert(0, LogPrefix);
					if (m_CurrentStdOutLine.Length > 0)
						m_CurrentStdOutLine.Length--; // trim newline, Debug.Log adds a newline of its own

					var message = m_CurrentStdOutLine.ToString();
					m_CurrentStdOutLine.Clear();

					Debug.Log(message);
				}
			}
		}

#if UNITY_EDITOR
		private const String EnabledKey = "CodeSmile.SystemConsoleToDebugLog.Enabled";
		private const String MenuItemName = "Window/CodeSmile/Capture Standard Output";
		private static Boolean Enabled
		{
			get => EditorPrefs.GetBool(EnabledKey, false);
			set => EditorPrefs.SetBool(EnabledKey, value);
		}

		[MenuItem(MenuItemName)]
		private static void ToggleEnabledState()
		{
			Enabled = !Enabled;
			Init();
		}

		[MenuItem(MenuItemName, true)]
		private static Boolean IsEnabled()
		{
			Menu.SetChecked(MenuItemName, Enabled);
			return true;
		}

		[InitializeOnLoadMethod]
		private static void Init()
		{
			EditorApplication.delayCall += () =>
			{
				if (Enabled) Activate();
				else Deactivate();

				CompilationPipeline.compilationStarted -= OnCompilationStarted;
				CompilationPipeline.compilationStarted += OnCompilationStarted;
			};

			// deactivate during compilation because compilers might generate a lot of noise
			static void OnCompilationStarted(Object context) => Deactivate();
		}
#endif
	}
}
