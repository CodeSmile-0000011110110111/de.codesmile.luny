// Copyright (C) 2021-2025 Steffen Itterheim
// Refer to included LICENSE file for terms and conditions.

using System;
using System.IO;
using System.Linq;
using UnityEditor;
using UnityEngine;

namespace CodeSmileEditor
{
	public static class CscResponseFile
	{
		private static readonly String s_ResponseFilePath = $"{Application.dataPath}/csc.rsp";

		public static void AddScriptingDefineSymbol(String symbol)
		{
			var lines = ReadResponseFileLines();
			var symbolLine = $"-define:{symbol}";

			if (lines.Contains(symbolLine) == false)
				AppendResponseFileLine(symbolLine);
		}

		public static void RemoveScriptingDefineSymbol(String symbol)
		{
			var lines = ReadResponseFileLines().ToList();
			var symbolLine = $"-define:{symbol}";

			var modified = false;
			var index = -1;
			while ((index = lines.LastIndexOf(symbolLine)) >= 0)
			{
				lines.RemoveAt(index);
				modified = true;
			}

			if (modified)
				WriteResponseFileLines(lines.ToArray());
		}

		public static void Import() => AssetDatabase.ImportAsset(s_ResponseFilePath);

		private static String[] ReadResponseFileLines() =>
			File.Exists(s_ResponseFilePath) ? File.ReadAllLines(s_ResponseFilePath) : new String[0];

		private static void AppendResponseFileLine(String symbolLine) => File.AppendAllLines(s_ResponseFilePath, new[] { symbolLine });

		private static void WriteResponseFileLines(String[] lines) => File.WriteAllLines(s_ResponseFilePath, lines);
	}
}
