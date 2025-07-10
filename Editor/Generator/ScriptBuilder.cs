// Copyright (C) 2021-2024 Steffen Itterheim
// Refer to included LICENSE file for terms and conditions.

using System;
using System.Collections.Generic;
using System.Text;
using UnityEditor;
using UnityEngine;

namespace CodeSmileEditor.Luny.Generator
{
	/// <summary>
	///     Wrapper for StringBuilder that makes it easy to create indent formatted text files, like scripts.
	///     Has methods for appending IEnumerable<string> so it gets more comfortable to add many smaller strings, example:
	///     builder.AppendIndented(new [] {$"{this}", " appends ", "several", " strings", " at ", "once", dot});
	///     OpenBlock and CloseBlock add lines with curly brackets and increment/decrement indentation.
	///     You can also use the original StringBuilder methods without indentation through this wrapper.
	/// </summary>
	public sealed class ScriptBuilder
	{
		private readonly StringBuilder m_StringBuilder;
		private readonly List<String> m_Indent = new();
		private readonly Char m_IndentChar;
		private readonly Int32 m_IndentCharRepeat;

		public Int32 IndentLevel { get; private set; }

		/// <summary>
		///     Create a new StringBuilder with indentation support.
		/// </summary>
		public ScriptBuilder(string value = null, Char indentChar = ' ', Int32 indentCharRepeat = 4)
		{
			m_StringBuilder = new StringBuilder(value);
			m_IndentChar = indentChar;
			m_IndentCharRepeat = Mathf.Max(1, indentCharRepeat);
			m_Indent.Add(string.Empty); // level 0: no indentation
		}

		/// <summary>
		///     get the resulting string
		/// </summary>
		/// <returns></returns>
		public override String ToString() => m_StringBuilder.ToString();

		/// <summary>
		///     is true as long as nothing has been appended yet
		/// </summary>
		/// <returns></returns>
		public Boolean IsEmpty() => m_StringBuilder.Length == 0;

		/// <summary>
		///     regular StringBuilder Append
		/// </summary>
		/// <param name="text"></param>
		public void Append(String text) => m_StringBuilder.Append(text);

		/// <summary>
		///     Appends each string in the array
		/// </summary>
		/// <param name="texts"></param>
		public void Append(IEnumerable<String> texts)
		{
			foreach (var text in texts)
				m_StringBuilder.Append(text);
		}

		/// <summary>
		///     appends text with leading indentation based on current indent level
		/// </summary>
		/// <param name="text"></param>
		public void AppendIndented(String text)
		{
			AppendIndentation();
			Append(text);
		}

		/// <summary>
		///     adds and indent, then appends each string in the array
		/// </summary>
		/// <param name="texts"></param>
		public void AppendIndented(IEnumerable<String> texts)
		{
			AppendIndentation();
			Append(texts);
		}

		/// <summary>
		///     regular StringBuilder AppendLine()
		/// </summary>
		public void AppendLine() => m_StringBuilder.AppendLine();

		/// <summary>
		///     appends 'count' number of empty lines
		/// </summary>
		/// <param name="count"></param>
		public void AppendEmptyLines(Int32 count)
		{
			for (var i = 0; i < count; i++)
				AppendLine();
		}

		/// <summary>
		///     regular StringBuilder AppendLine("")
		/// </summary>
		/// <param name="text"></param>
		public void AppendLine(String text) => m_StringBuilder.AppendLine(text);

		/// <summary>
		///     appends the texts, then adds a newline
		/// </summary>
		/// <param name="texts"></param>
		public void AppendLine(IEnumerable<String> texts)
		{
			foreach (var text in texts)
				AppendLine(text);
		}

		/// <summary>
		///     appends text with leading indentation based on current Indentation value, ends with newline
		/// </summary>
		/// <param name="text"></param>
		public void AppendIndentedLine(String text)
		{
			AppendIndentation();
			AppendLine(text);
		}

		/// <summary>
		///     Appends indentation, then appends each text and at the end appends a newline
		/// </summary>
		/// <param name="texts"></param>
		public void AppendIndentedLine(IEnumerable<String> texts)
		{
			AppendIndentation();
			AppendLine(texts);
		}

		public void IncrementIndent() => ++IndentLevel;

		public void DecrementIndent()
		{
			--IndentLevel;
			if (IndentLevel < 0)
				throw new ArgumentOutOfRangeException("indent level must not be negative");
		}

		/// <summary>
		///     appends an opening character with the current Indentation, then increments Indentation
		/// </summary>
		public void OpenIndentedBlock(String openCharacters)
		{
			AppendIndentation();
			AppendLine(openCharacters);
			IncrementIndent();
		}

		/// <summary>
		///     decrements Indentation, then appends a closing character
		/// </summary>
		public void CloseIndentedBlock(String closeCharacters)
		{
			DecrementIndent();
			AppendIndentation();
			AppendLine(closeCharacters);
		}

		private void AppendIndentation() => m_StringBuilder.Append(GetIndentString());

		private String GetIndentString()
		{
			while (IndentLevel >= m_Indent.Count)
			{
				m_Indent.Add(new String(m_IndentChar, m_Indent.Count * m_IndentCharRepeat));
			}

			return m_Indent[IndentLevel];
		}
	}
}
