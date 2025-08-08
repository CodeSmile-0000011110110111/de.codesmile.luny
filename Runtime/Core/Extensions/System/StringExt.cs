// Copyright (C) 2021-2025 Steffen Itterheim
// Refer to included LICENSE file for terms and conditions.

using System;
using System.Collections.Generic;
using System.Text;
using UnityEditor;
using UnityEngine;

namespace CodeSmile
{
	public static class StringExt
	{
		private static readonly HashSet<String> CSharpKeywords = new()
		{
			"var", "bool", "byte", "sbyte", "short", "ushort", "int", "uint", "long", "ulong", "double", "float", "decimal",
			"string", "char", "void", "object", "typeof", "sizeof", "null", "true", "false", "if", "else", "while", "for",
			"foreach", "do", "switch", "case", "default", "lock", "try", "throw", "catch", "finally", "goto", "break",
			"continue", "return", "public", "private", "internal", "protected", "static", "readonly", "sealed", "const",
			"fixed", "stackalloc", "volatile", "new", "override", "abstract", "virtual", "event", "extern", "ref", "out", "in",
			"is", "as", "params", "__arglist", "__makeref", "__reftype", "__refvalue", "this", "base", "namespace", "using",
			"class", "struct", "interface", "enum", "delegate", "checked", "unchecked", "unsafe", "operator", "implicit",
			"explicit",
		};
		public static String ToForwardSlashes(this String str) => str.Replace('\\', '/');

		/// <summary>
		///     Correctness check of a C# identifier (ie variable, method name) that works across platforms and doesn't use Regex.
		///     It may not catch all edge cases, but 99% of them.
		/// </summary>
		/// <param name="str"></param>
		/// <param name="allowNamespaces">Allows '.' as character as well</param>
		/// <returns></returns>
		public static Boolean IsValidCSharpIdentifier(this String str, Boolean allowNamespaces = false,
			Boolean allowGenerics = false)
		{
			if (str.Length == 0)
				return false;

			var c = ' ';
			for (var i = 0; i < str.Length; i++)
			{
				c = str[i];
				if (allowNamespaces && c == '.' ||
				    allowGenerics && c == '<' ||
				    c == '>' || c == '_' ||
				    c >= 'a' && c <= 'z' ||
				    c >= 'A' && c <= 'Z' ||
				    i != 0 && c >= '0' && c <= '9' ||
				    i == 0 && c == '@') // @ can be a prefix to avoid clashing with C# keywords (ie "@namespace")
					continue;

				return false;
			}

			// it's technically valid but is it in the reserved keywords list?
			return CSharpKeywords.Contains(str) == false;
		}

		/// <summary>
		///     Replaces any illegal C# identifier character in the string with the given replacement character.
		///     If the string matches a known C# keyword, it gets prefixed with '@' to make it a legal identifier.
		/// </summary>
		/// <param name="str"></param>
		/// <param name="replacement"></param>
		/// <returns></returns>
		public static String ReplaceIllegalCSharpIdentifierChars(this String str, Char replacement = '_')
		{
			var sb = new StringBuilder();
			var c = ' ';
			for (var i = 0; i < str.Length; i++)
			{
				c = str[i];
				if ((c == '_' || c >= 'a' && c <= 'z' || c >= 'A' && c <= 'Z' || i != 0 && c >= '0' && c <= '9') == false)
					c = replacement;

				sb.Append(c);
			}

			// if it's a C# keyword, prefix it:
			var result = sb.ToString().Trim(replacement);
			if (CSharpKeywords.Contains(result))
				result = $"@{result}";

			return result;
		}

		/// <summary>
		///     Trims string and replaces illegal C# identifier characters and prints a Debug.LogWarning if it had to be altered.
		/// </summary>
		/// <param name="identifier"></param>
		/// <param name="noWarnings"></param>
		/// <returns></returns>
		public static String SanitizeIdentifier(this String identifier)
		{
			if (String.IsNullOrWhiteSpace(identifier))
				return null;

			identifier = identifier.Trim();
			return identifier.IsValidCSharpIdentifier() ? identifier : identifier.ReplaceIllegalCSharpIdentifierChars();
		}
	}
}
