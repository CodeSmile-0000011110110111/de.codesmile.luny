// Copyright (C) 2021-2025 Steffen Itterheim
// Refer to included LICENSE file for terms and conditions.

using System;
using System.Collections.Generic;
using System.Linq;
using UnityEditor;
using UnityEditor.Compilation;
using UnityEngine;

namespace CodeSmileEditor
{
	[InitializeOnLoad]
	public static class CompilationState
	{
		private static readonly Dictionary<String, IEnumerable<CompilerMessage>> s_ErrorMessages = new();

		public static Boolean HasErrors(String assemblyName = null)
		{
			var anyAssembly = String.IsNullOrEmpty(assemblyName);
			foreach (var pair in s_ErrorMessages)
			{
				if (anyAssembly || pair.Key.Contains(assemblyName))
				{
					if (pair.Value.Any())
						return true;
				}
			}

			return false;
		}

		private static void OnAssemblyCompilationFinished(String assemblyDllPath, CompilerMessage[] messages) =>
			s_ErrorMessages[assemblyDllPath] = messages.Where(message => message.type == CompilerMessageType.Error);

		static CompilationState()
		{
			s_ErrorMessages.Clear();
			CompilationPipeline.assemblyCompilationFinished += OnAssemblyCompilationFinished;
		}
	}
}
