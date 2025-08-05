// Copyright (C) 2021-2025 Steffen Itterheim
// Refer to included LICENSE file for terms and conditions.

using Luny;
using LunyEditor.Generator.CSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using UnityEditor;
using UnityEngine;

namespace LunyEditor.Generator
{
	internal sealed class ModuleLoaderGenerator
	{
		private const String CommaAndSpace = ", ";

		public static void Generate(LunyLuaModule module, String contentFolderPath, IEnumerable<GenTypeInfo> typeInfos,
			IEnumerable<String> namespaces)
		{
			var loaderClassName = "LuaModuleLoader";// $"Lua{module.AssemblyName.Replace(".", "")}Loader";
			var namespaceName = $"{module.BindingsAssemblyName}.Internal";
			module.ModuleLoaderTypeFullName = $"{namespaceName}.{loaderClassName}";

			var sb = new ScriptBuilder(GenUtil.GeneratedFileHeader);
			AddNamespaceBlock(sb, namespaceName);
			AddClassBlock(sb, loaderClassName);
			AddGetNamespaces(sb, namespaces);
			AddGetEnumTypes(sb, typeInfos);
			AddGetObjectTypes(sb, typeInfos);
			EndClassBlock(sb);
			EndNamespaceBlock(sb);

			var assetPath = $"{contentFolderPath}/{loaderClassName}.cs";
			GenUtil.WriteFile(assetPath, sb.ToString());
		}

		private static void AddNamespaceBlock(ScriptBuilder sb, String namespaceName)
		{
			sb.AppendIndent("namespace ");
			sb.AppendLine(namespaceName);
			sb.OpenIndentBlock("{");
		}

		private static void EndNamespaceBlock(ScriptBuilder sb) => sb.CloseIndentBlock("}");

		private static void AddClassBlock(ScriptBuilder sb, String loaderClassName)
		{
			sb.AppendIndentLine("[global::System.Serializable]");
			sb.AppendIndent("internal sealed class ");
			sb.Append(loaderClassName);
			sb.Append(" : global::");
			sb.Append(typeof(LunyLuaModule).FullName);
			sb.Append(".");
			sb.AppendLine(nameof(LunyLuaModule.Loader));
			sb.OpenIndentBlock("{");
		}

		private static void EndClassBlock(ScriptBuilder sb) => sb.CloseIndentBlock("}");

		private static void AddGetNamespaces(ScriptBuilder sb, IEnumerable<String> namespaces)
		{
			sb.AppendIndent("public override global::System.String[] ");
			sb.Append(nameof(LunyLuaModule.Loader.GetNamespaceNames));
			sb.AppendLine("() => new global::System.String[]");
			sb.OpenIndentBlock("{");
			foreach (var ns in namespaces)
			{
				sb.AppendIndent("\"");
				sb.Append(ns);
				sb.AppendLine("\",");
			}
			sb.CloseIndentBlock("};");

			sb.AppendIndent("public override global::System.String[][] ");
			sb.Append(nameof(LunyLuaModule.Loader.GetNamespaceParts));
			sb.AppendLine("() => new global::System.String[][]");
			sb.OpenIndentBlock("{");
			foreach (var ns in namespaces)
			{
				sb.AppendIndent("new global::System.String[] { ");

				var namespaceParts = ns.Split('.');
				for (var i = 0; i < namespaceParts.Length; i++)
				{
					var part = namespaceParts[i];
					if (i > 0)
						sb.Append(CommaAndSpace);
					sb.Append("\"");
					sb.Append(part);
					sb.Append("\"");
				}

				sb.AppendLine(" },");
			}
			sb.CloseIndentBlock("};");
		}

		private static void AddGetObjectTypes(ScriptBuilder sb, IEnumerable<GenTypeInfo> typeInfos)
		{
			sb.AppendIndent("public override global::");
			sb.Append(typeof(LuaTypeInfo).FullName);
			sb.Append("[] ");
			sb.Append(nameof(LunyLuaModule.Loader.GetBindTypeInfos));
			sb.Append("() => new global::");
			sb.Append(typeof(LuaTypeInfo).FullName);
			sb.AppendLine("[]");
			sb.OpenIndentBlock("{");
			foreach (var typeInfo in typeInfos.Where(t => t.Type.IsEnum == false))
			{
				sb.AppendIndent("new global::");
				sb.Append(typeof(LuaTypeInfo).FullName);
				sb.Append(" { ");

				sb.Append(nameof(LuaTypeInfo.Name));
				sb.Append(" = \"");
				sb.Append(typeInfo.Type.Name);
				sb.Append("\"");

				sb.Append(CommaAndSpace);
				sb.Append(nameof(LuaTypeInfo.BindType));
				sb.Append(" = typeof(");
				sb.Append(typeInfo.BindTypeFullName);
				sb.Append(")");

				sb.Append(CommaAndSpace);
				sb.Append(nameof(LuaTypeInfo.LuaType));
				sb.Append(" = typeof(");
				sb.Append(typeInfo.LuaStaticTypeFullName);
				sb.Append(")");

				if (typeInfo.HasInstanceType)
				{
					sb.Append(CommaAndSpace);
					sb.Append(nameof(LuaTypeInfo.LuaInstanceType));
					sb.Append(" = typeof(");
					sb.Append(typeInfo.LuaInstanceTypeFullName);
					sb.Append(")");
				}

				sb.Append(CommaAndSpace);
				sb.Append(nameof(LuaTypeInfo.TypeToLua));
				sb.Append(" = ");
				sb.Append(typeInfo.LuaStaticTypeFullName);
				sb.Append(".");
				sb.Append(nameof(ILuaObjectFactory.Bind));

				if (typeInfo.HasInstanceType)
				{
					sb.Append(CommaAndSpace);
					sb.Append(nameof(LuaTypeInfo.InstanceToLua));
					sb.Append(" = ");
					sb.Append(typeInfo.LuaInstanceTypeFullName);
					sb.Append(".");
					sb.Append(nameof(ILuaObjectFactory.Bind));

					sb.Append(CommaAndSpace);
					sb.Append(nameof(LuaTypeInfo.InstanceListToLua));
					sb.Append(" = ");
					sb.Append(typeInfo.LuaInstanceTypeFullName);
					sb.Append(".");
					sb.Append(nameof(ILuaObjectFactory.Bind));
				}

				sb.AppendLine(" },");
			}
			sb.CloseIndentBlock("};");
		}

		private static void AddGetEnumTypes(ScriptBuilder sb, IEnumerable<GenTypeInfo> typeInfos)
		{
			sb.AppendIndent("public override global::System.Type[] ");
			sb.Append(nameof(LunyLuaModule.Loader.GetEnumTypes));
			sb.AppendLine("() => new global::System.Type[]");
			sb.OpenIndentBlock("{");
			foreach (var enumTypeInfo in typeInfos.Where(t => t.Type.IsEnum))
			{
				sb.AppendIndent("typeof(");
				sb.Append(enumTypeInfo.BindTypeFullName);
				sb.AppendLine("),");
			}
			sb.CloseIndentBlock("};");
		}
	}
}
