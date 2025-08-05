// Copyright (C) 2021-2024 Steffen Itterheim
// Refer to included LICENSE file for terms and conditions.

using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;
using UnityEditor;
using UnityEngine;

namespace LunyEditor.Generator.CSharp
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
		private static String[] s_Keywords;

		private readonly StringBuilder m_StringBuilder;
		private readonly List<String> m_Indentations = new();
		private readonly Char m_IndentChar;
		private readonly Int32 m_IndentCharRepeat;

		public Int32 IndentLevel { get; private set; }

		private static void InitSymbolsLookupTable()
		{
			if (s_Keywords == null)
			{
				var keywords = Enum.GetNames(typeof(Keyword));
				var keywordCount = keywords.Length;
				s_Keywords = new String[keywordCount];

				for (var i = 0; i < keywordCount; ++i)
					s_Keywords[i] = keywords[i].ToLower();
			}
		}

		private static String GetCharacter(Character character) => character switch
		{
			Character.ParensClose => ")",
			Character.ParensOpen => "(",
			Character.Semicolon => ";",
			Character.Space => " ",
			var _ => throw new ArgumentOutOfRangeException(nameof(character), character.ToString()),
		};

		private static String GetKeyword(Keyword keyword) => s_Keywords[(Int32)keyword];

		private static String GetOperator(Operator op) => op switch
		{
			Operator.Assign => "=",
			Operator.Equals => "==",
			Operator.LambdaExpression => "=>",
			var _ => throw new ArgumentOutOfRangeException(nameof(op), op.ToString()),
		};

		/// <summary>
		///     Create a new StringBuilder with indentation support.
		/// </summary>
		public ScriptBuilder(String value = null, Char indentChar = ' ', Int32 indentCharRepeat = 4)
		{
			InitSymbolsLookupTable();
			m_StringBuilder = new StringBuilder(value);
			m_IndentChar = indentChar;
			m_IndentCharRepeat = Mathf.Max(1, indentCharRepeat);
			m_Indentations.Add(String.Empty); // level 0: no indentation
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
		///     Appends each string in the collection
		/// </summary>
		/// <param name="texts"></param>
		public void Append(IEnumerable<String> texts)
		{
			foreach (var text in texts)
				m_StringBuilder.Append(text);
		}

		public void Append(String text, Space space = Space.None, Character paddingChar = Character.Space)
		{
			AppendPaddingBefore(space, paddingChar);
			m_StringBuilder.Append(text);
			AppendPaddingAfter(space, paddingChar);
		}

		public void Append(Character character, Space space = Space.None, Character paddingChar = Character.Space)
		{
			AppendPaddingBefore(space, paddingChar);
			m_StringBuilder.Append(GetCharacter(character));
			AppendPaddingAfter(space, paddingChar);
		}

		public void Append(Keyword keyword, Space space = Space.None, Character paddingChar = Character.Space)
		{
			AppendPaddingBefore(space, paddingChar);
			m_StringBuilder.Append(GetKeyword(keyword));
			AppendPaddingAfter(space, paddingChar);
		}

		public void Append(Operator @operator, Space space = Space.None, Character paddingChar = Character.Space)
		{
			AppendPaddingBefore(space, paddingChar);
			m_StringBuilder.Append(GetOperator(@operator));
			AppendPaddingAfter(space, paddingChar);
		}

		public void Append(params Keyword[] keywords)
		{
			foreach (var keyword in keywords)
				Append(GetKeyword(keyword), Space.After);
		}

		public void Append(params String[] texts)
		{
			foreach (var text in texts)
				Append(text, Space.After);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private void AppendPaddingBefore(Space space, Character paddingChar)
		{
			if (space == Space.Before)
				m_StringBuilder.Append(GetCharacter(paddingChar));
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private void AppendPaddingAfter(Space space, Character paddingChar)
		{
			if (space == Space.After)
				m_StringBuilder.Append(GetCharacter(paddingChar));
		}

		public void Append(Char c, Int32 count = 1) => m_StringBuilder.Append(new String(c, count));

		/// <summary>
		///     appends text with leading indentation based on current indent level
		/// </summary>
		/// <param name="text"></param>
		public void AppendIndent(String text = "")
		{
			AppendIndentation();
			Append(text);
		}

		/// <summary>
		///     adds and indent, then appends each string in the array
		/// </summary>
		/// <param name="texts"></param>
		public void AppendIndent(IEnumerable<String> texts)
		{
			AppendIndentation();
			Append(texts);
		}

		/// <summary>
		///     regular StringBuilder AppendLine()
		/// </summary>
		public void AppendLine() => m_StringBuilder.AppendLine();

		public void AppendLine(Character character) => m_StringBuilder.AppendLine(GetCharacter(character));

		/// <summary>
		///     appends 'count' number of empty lines
		/// </summary>
		/// <param name="count"></param>
		public void AppendLines(Int32 count)
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
		public void AppendIndentLine(String text)
		{
			AppendIndentation();
			AppendLine(text);
		}

		/// <summary>
		///     Appends indentation, then appends each text and at the end appends a newline
		/// </summary>
		/// <param name="texts"></param>
		public void AppendIndentLine(IEnumerable<String> texts)
		{
			AppendIndentation();
			AppendLine(texts);
		}

		public void IncrementIndent() => ++IndentLevel;

		public void DecrementIndent()
		{
			--IndentLevel;
			if (IndentLevel < 0)
			{
				IndentLevel = 0;
				Debug.LogWarning("decremented indententation too much");
			}
		}

		/// <summary>
		///     appends an opening character with the current Indentation, then increments Indentation
		/// </summary>
		public void OpenIndentBlock(String openCharacters)
		{
			AppendIndentation();
			AppendLine(openCharacters);
			IncrementIndent();
		}

		/// <summary>
		///     decrements Indentation, then appends a closing character
		/// </summary>
		public void CloseIndentBlock(String closeCharacters)
		{
			DecrementIndent();
			AppendIndentation();
			AppendLine(closeCharacters);
		}

		private void AppendIndentation() => m_StringBuilder.Append(GetIndentString());

		private String GetIndentString()
		{
			// grow the lookup table dynamically
			while (IndentLevel >= m_Indentations.Count)
			{
				m_Indentations.Add(new String(m_IndentChar, m_Indentations.Count * m_IndentCharRepeat));
			}

			return m_Indentations[IndentLevel];
		}
	}

	public enum Keyword
	{
		Abstract,
		Add,
		Alias,
		Allows,
		And,
		Args,
		As,
		Ascending,
		Async,
		Await,
		Base,
		Bool,
		Break,
		By,
		Byte,
		Case,
		Catch,
		Char,
		Checked,
		Class,
		Const,
		Continue,
		Decimal,
		Default,
		Delegate,
		Descending,
		Do,
		Double,
		Dynamic,
		Else,
		Enum,
		Equals,
		Event,
		Explicit,
		Extension,
		Extern,
		False,
		Field,
		File,
		Finally,
		Fixed,
		Float,
		For,
		Foreach,
		From,
		Get,
		Global,
		Goto,
		Group,
		If,
		Implicit,
		In,
		Init,
		Int,
		Interface,
		Internal,
		Into,
		Is,
		Join,
		Let,
		Lock,
		Long,
		Managed,
		Nameof,
		Namespace,
		New,
		Nint,
		Not,
		Notnull,
		Nuint,
		Null,
		Object,
		On,
		Operator,
		Or,
		Orderby,
		Out,
		Override,
		Params,
		Partial,
		Private,
		Protected,
		Public,
		Readonly,
		Record,
		Ref,
		Remove,
		Required,
		Return,
		SByte,
		Scoped,
		Sealed,
		Select,
		Set,
		Short,
		Sizeof,
		Stackalloc,
		Static,
		String,
		Struct,
		Switch,
		This,
		Throw,
		True,
		Try,
		Typeof,
		UInt,
		ULong,
		UShort,
		Unchecked,
		Unmanaged,
		Unsafe,
		Using,
		Value,
		Var,
		Virtual,
		Void,
		Volatile,
		When,
		Where,
		While,
		With,
		Yield,
	}

	[Flags]
	public enum Space
	{
		None = 0,
		Before = 1 << 0,
		After = 1 << 1,
		BeforeAndAfter = Before | After,
	}

	public enum Character
	{
		ParensClose,
		ParensOpen,
		Semicolon,
		Space,
	}

	public enum Operator
	{
		Assign,
		Equals,
		LambdaExpression,
	}
}
