// Copyright (C) 2021-2025 Steffen Itterheim
// Refer to included LICENSE file for terms and conditions.

using CodeSmile.Luny;
using System;
using System.Collections.Generic;
using System.Linq;
using UnityEditor;
using UnityEngine;

namespace CodeSmileEditor.Luny.Generator
{
	internal sealed class ModuleLoaderGenerator
	{
		public static void Generate(LunyLuaModule module, String contentFolderPath, IEnumerable<GenTypeInfo> typeInfos,
			IEnumerable<String> namespaces)
		{
			var @namespace = module.BindingsNamespace;
			var className = @namespace;
			module.ModuleLoaderTypeName = $"{@namespace}.{className}";

			var sb = new ScriptBuilder(GenUtil.GeneratedFileHeader);
			AddUsingStatements(sb, namespaces);
			AddNamespaceBlock(sb, @namespace);
			AddClassBlock(sb, className);
			AddGetNamespaces(sb, namespaces);
			AddGetObjectTypes(sb, typeInfos);
			AddGetEnumTypes(sb, typeInfos);
			EndClassBlock(sb);
			EndNamespaceBlock(sb);

			var assetPath = $"{contentFolderPath}/_{className}.cs";
			GenUtil.WriteFile(assetPath, sb.ToString());
		}

		private static void AddUsingStatements(ScriptBuilder sb, IEnumerable<String> namespaces)
		{
			sb.AppendNewLine("using CodeSmile.Luny;");
			sb.AppendNewLine();
		}

		private static void AddNamespaceBlock(ScriptBuilder sb, String @namespace)
		{
			sb.AppendIndent("namespace ");
			sb.AppendNewLine(@namespace);
			sb.OpenIndentBlock("{");
		}

		private static void EndNamespaceBlock(ScriptBuilder sb) => sb.CloseIndentBlock("}");

		private static void AddClassBlock(ScriptBuilder sb, String loaderClassName)
		{
			sb.AppendIndentLine("[System.Serializable]");
			sb.AppendIndent("public sealed class ");
			sb.Append(loaderClassName);
			sb.Append(" : ");
			sb.Append(nameof(LunyLuaModule));
			sb.Append(".");
			sb.AppendNewLine(nameof(LunyLuaModule.Loader));
			sb.OpenIndentBlock("{");
		}

		private static void EndClassBlock(ScriptBuilder sb) => sb.CloseIndentBlock("}");

		private static void AddGetNamespaces(ScriptBuilder sb, IEnumerable<String> namespaces)
		{
			sb.AppendIndent("public override System.String[] ");
			sb.Append(nameof(LunyLuaModule.Loader.GetNamespaceNames));
			sb.AppendNewLine("() => new[]");
			sb.OpenIndentBlock("{");
			foreach (var ns in namespaces)
			{
				sb.AppendIndent("\"");
				sb.Append(ns);
				sb.AppendNewLine("\",");
			}
			sb.CloseIndentBlock("};");

			sb.AppendIndent("public override System.String[][] ");
			sb.Append(nameof(LunyLuaModule.Loader.GetNamespaceParts));
			sb.AppendNewLine("() => new[]");
			sb.OpenIndentBlock("{");
			foreach (var ns in namespaces)
			{
				sb.AppendIndent("new[] { ");

				var namespaceParts = ns.Split('.');
				for (var i = 0; i < namespaceParts.Length; i++)
				{
					var part = namespaceParts[i];
					if (i > 0)
						sb.Append(", ");
					sb.Append("\"");
					sb.Append(part);
					sb.Append("\"");
				}

				sb.AppendNewLine(" },");
			}
			sb.CloseIndentBlock("};");
		}

		private static void AddGetObjectTypes(ScriptBuilder sb, IEnumerable<GenTypeInfo> typeInfos)
		{
			sb.AppendIndent("public override ");
			sb.Append(nameof(LuaTypeInfo));
			sb.Append("[] ");
			sb.Append(nameof(LunyLuaModule.Loader.GetLuaTypes));
			sb.AppendNewLine("() => new[]");
			sb.OpenIndentBlock("{");
			foreach (var typeInfo in typeInfos.Where(t => t.Type.IsEnum == false))
			{
				sb.AppendIndent("new ");
				sb.Append(nameof(LuaTypeInfo));
				sb.Append(" { ");

				sb.Append(nameof(LuaTypeInfo.Name));
				sb.Append(" = \"");
				sb.Append(typeInfo.Type.Name);
				sb.Append("\", ");
				sb.Append(nameof(LuaTypeInfo.BindType));
				sb.Append(" = typeof(");
				sb.Append(typeInfo.BindTypeFullName);
				sb.Append("), ");
				sb.Append(nameof(LuaTypeInfo.LuaType));
				sb.Append(" = typeof(");
				sb.Append(typeInfo.StaticLuaTypeName);
				sb.Append("), ");
				sb.Append(nameof(LuaTypeInfo.CreateLuaType));
				sb.Append(" = ");
				sb.Append(typeInfo.StaticLuaTypeName);
				sb.Append(".");
				sb.Append(nameof(LuaTypeInfo.CreateLuaType));

				if (typeInfo.HasInstanceType)
				{
					sb.Append(", ");
					sb.Append(nameof(LuaTypeInfo.LuaObject));
					sb.Append(" = typeof(");
					sb.Append(typeInfo.InstanceLuaTypeName);
					sb.Append("), ");

					if (typeInfo.Type.IsValueType == false)
					{
						sb.Append(nameof(LuaTypeInfo.CreateLuaObject));
						sb.Append(" = ");
						sb.Append(typeInfo.InstanceLuaTypeName);
						sb.Append(".");
						sb.Append(nameof(LuaTypeInfo.CreateLuaObject));
					}
				}

				sb.AppendNewLine(" },");
			}
			sb.CloseIndentBlock("};");
		}

		private static void AddGetEnumTypes(ScriptBuilder sb, IEnumerable<GenTypeInfo> typeInfos)
		{
			sb.AppendIndent("public override System.Type[] ");
			sb.Append(nameof(LunyLuaModule.Loader.GetEnumTypes));
			sb.AppendNewLine("() => new[]");
			sb.OpenIndentBlock("{");
			foreach (var enumTypeInfo in typeInfos.Where(t => t.Type.IsEnum))
			{
				sb.AppendIndent("typeof(");
				sb.Append(enumTypeInfo.BindTypeFullName);
				sb.AppendNewLine("),");
			}
			sb.CloseIndentBlock("};");
		}
	}
}
