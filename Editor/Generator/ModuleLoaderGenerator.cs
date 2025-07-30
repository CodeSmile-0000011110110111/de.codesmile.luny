// Copyright (C) 2021-2025 Steffen Itterheim
// Refer to included LICENSE file for terms and conditions.

using CodeSmile.Luny;
using System;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

namespace CodeSmileEditor.Luny.Generator
{
	internal sealed class ModuleLoaderGenerator
	{
		public static void Generate(LunyLuaModule module, String contentFolderPath, IList<GenTypeInfo> typeInfos,
			IEnumerable<String> namespaces)
		{
			var @namespace = module.BindingsNamespace;
			var className = @namespace;
			module.ModuleLoaderTypeName = $"{@namespace}.{className}";

			var sb = new ScriptBuilder(GenUtil.GeneratedFileHeader);
			AddUsingStatements(sb, namespaces);
			AddNamespaceBlock(sb, @namespace);
			AddClassBlock(sb, className);
			AddGetModuleTypes(sb, typeInfos, namespaces);
			AddLoadMethod(sb, typeInfos, namespaces, className);
			EndClassBlock(sb);
			EndNamespaceBlock(sb);

			var assetPath = $"{contentFolderPath}/_{className}.cs";
			GenUtil.WriteFile(assetPath, sb.ToString());
		}


		private static void AddUsingStatements(ScriptBuilder sb, IEnumerable<String> namespaces)
		{
			sb.AppendLine("#pragma warning disable 0105 // The using directive for '..' appeared previously in this namespace");
			sb.AppendLine("using CodeSmile.Luny;");
			sb.AppendLine("using Lua;");
			sb.AppendLine("using System.Collections.Generic;");
			foreach (var ns in namespaces)
			{
				sb.Append("using ");
				sb.Append(ns);
				sb.AppendLine(";");
			}
			sb.AppendLine("#pragma warning restore 0105");
			sb.AppendLine();
		}

		private static void AddNamespaceBlock(ScriptBuilder sb, String @namespace)
		{
			sb.AppendIndent("namespace ");
			sb.AppendLine(@namespace);
			sb.OpenIndentBlock("{");
		}

		private static void EndNamespaceBlock(ScriptBuilder sb) => sb.CloseIndentBlock("}");

		private static void AddClassBlock(ScriptBuilder sb, String loaderClassName)
		{
			sb.AppendIndentLine("[System.Serializable]");
			sb.AppendIndent("public sealed class ");
			sb.Append(loaderClassName);
			sb.Append(" : ");
			sb.AppendLine(nameof(LuaModuleLoader));
			sb.OpenIndentBlock("{");
		}

		private static void EndClassBlock(ScriptBuilder sb) => sb.CloseIndentBlock("}");

		private static void AddGetModuleTypes(ScriptBuilder sb, IList<GenTypeInfo> typeInfos, IEnumerable<string> namespaces)
		{
			sb.AppendIndent("public override IEnumerable<");
			sb.Append(nameof(LuaModuleLoader.ModuleTypes));
			sb.Append("> ");
			sb.Append(nameof(LuaModuleLoader.GetModuleTypes));
			sb.AppendLine("()");
			sb.OpenIndentBlock("{");
			sb.AppendIndent("return new List<");
			sb.Append(nameof(LuaModuleLoader.ModuleTypes));
			sb.AppendLine(">();");
			sb.CloseIndentBlock("}");
		}

		private static void AddLoadMethod(ScriptBuilder sb, IEnumerable<GenTypeInfo> typeInfos, IEnumerable<String> namespaces,
			String className)
		{
			sb.AppendIndent("public override void ");
			sb.Append(nameof(LuaModuleLoader.Load));
			sb.Append("(");
			sb.Append(nameof(LuaModuleLoader.ModuleParameters));
			sb.AppendLine(" parameters)");
			sb.OpenIndentBlock("{");
			sb.AppendIndentLine("var env = parameters.env;");
			GenerateTypeInitialization(sb, typeInfos, namespaces);
			sb.AppendLine();
			sb.CloseIndentBlock("}");
		}

		private static void GenerateTypeInitialization(ScriptBuilder sb, IEnumerable<GenTypeInfo> typeInfos, IEnumerable<String> namespaces)
		{
			var namespaceTables = new Dictionary<String, String>();

			foreach (var @namespace in namespaces)
			{
				var namespaceTableName = $"{@namespace.Replace(".", "")}Table";
				namespaceTables.Add(@namespace, namespaceTableName);

				sb.AppendIndent("var ");
				sb.Append(namespaceTableName);
				sb.Append(" = GetOrCreateNamespaceTable(env, new[] { ");

				var firstPart = true;
				var namespaceParts = @namespace.Split('.');
				foreach (var part in namespaceParts)
				{
					if (!firstPart)
						sb.Append(", ");

					sb.Append("\"");
					sb.Append(part);
					sb.Append("\"");
					firstPart = false;
				}
				sb.AppendLine(" });");
			}

			foreach (var typeInfo in typeInfos)
			{
				var type = typeInfo.Type;
				if (type.IsEnum)
				{
					sb.AppendIndent("LuaUtil.CreateEnumTable(typeof(");
					sb.Append(typeInfo.BindTypeFullName);
					sb.AppendLine("));");
				}
				else
				{
					var namespaceTableName = namespaceTables[type.Namespace];
					sb.AppendIndent(namespaceTableName);
					sb.Append("[\"");
					sb.Append(typeInfo.Type.Name);
					sb.Append("\"] = new ");
					sb.Append(typeInfo.StaticLuaTypeName);
					sb.AppendLine("(parameters);");
				}
			}
		}
	}
}
