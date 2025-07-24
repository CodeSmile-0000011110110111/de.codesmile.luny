// Copyright (C) 2021-2025 Steffen Itterheim
// Refer to included LICENSE file for terms and conditions.

using CodeSmile.Luny;
using System;
using System.Collections.Generic;
using System.IO;
using UnityEditor;
using UnityEngine;

namespace CodeSmileEditor.Luny.Generator
{
	internal sealed class ModuleLoaderGenerator
	{
		public static void Generate(LunyLuaModule module, String contentFolderPath, TypeHierarchy typeHierarchy,
			IEnumerable<GenTypeInfo> typeInfos)
		{
			var @namespace = module.BindingsNamespace;
			var loaderClassName = $"Lua_{module.AssemblyName.Replace('.', '_')}_Loader";
			module.ModuleLoaderTypeName = $"{@namespace}.{loaderClassName}";

			var sb = new ScriptBuilder(GenUtil.GeneratedFileHeader);
			AddUsingStatements(typeHierarchy, sb);
			AddNamespaceBlock(sb, @namespace);
			AddClassBlock(sb, loaderClassName);
			AddLoadMethod(sb, typeHierarchy, typeInfos, loaderClassName);
			EndClassBlock(sb);
			EndNamespaceBlock(sb);

			var assetPath = $"{contentFolderPath}/Lua_{module.AssemblyName}_Loader.cs";
			GenUtil.WriteFile(assetPath, sb.ToString());
		}

		private static void AddUsingStatements(TypeHierarchy typeHierarchy, ScriptBuilder sb)
		{
			sb.AppendLine("using CodeSmile.Luny;");
			sb.AppendLine("using Lua;");
			sb.AppendLine("using Unity.Profiling;");
			foreach (var ns in typeHierarchy.Namespaces)
			{
				sb.Append("using ");
				sb.Append(ns);
				sb.AppendLine(";");
			}
			sb.AppendLine();
		}

		private static void AddNamespaceBlock(ScriptBuilder sb, String @namespace)
		{
			sb.AppendIndent("namespace ");
			sb.AppendLine(@namespace);
			sb.OpenIndentBlock("{"); // namespace
		}

		private static void EndNamespaceBlock(ScriptBuilder sb) => sb.CloseIndentBlock("}"); // namespace

		private static void AddClassBlock(ScriptBuilder sb, String loaderClassName)
		{
			sb.AppendIndentLine("[Serializable]");
			sb.AppendIndent("public sealed class ");
			sb.Append(loaderClassName);
			sb.Append(" : ");
			sb.AppendLine(nameof(LunyLuaModuleLoader));
			sb.OpenIndentBlock("{"); // class
		}

		private static void EndClassBlock(ScriptBuilder sb) => sb.CloseIndentBlock("}"); // class

		private static void AddLoadMethod(ScriptBuilder sb, TypeHierarchy typeHierarchy, IEnumerable<GenTypeInfo> typeInfos,
			String className)
		{
			sb.AppendIndentLine("public override void Load(LuaTable env)");
			sb.OpenIndentBlock("{"); // Load(..)
			sb.AppendIndent("var marker = new ProfilerMarker(ProfilerCategory.Scripts, nameof(");
			sb.Append(className);
			sb.AppendLine("));");
			sb.AppendIndentLine("marker.Begin();");
			sb.AppendIndentLine("base.Load(env);");
			GenerateTypeInitialization(sb, typeHierarchy, typeInfos);
			sb.AppendIndentLine("marker.End();");
			sb.CloseIndentBlock("}"); // Load(..)
		}

		private static void GenerateTypeInitialization(ScriptBuilder sb, TypeHierarchy typeHierarchy,
			IEnumerable<GenTypeInfo> typeInfos)
		{
			var namespaceTables = new Dictionary<String, String>();

			foreach (var @namespace in typeHierarchy.Namespaces)
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
					sb.Append(typeInfo.StaticTypeName);
					sb.Append("(); // ");
					sb.AppendLine(typeInfo.Type.FullName);
					// sb.Append(" in ");
					// sb.AppendLine(typeInfo.Type.Assembly.GetName().Name);
				}
			}
		}

	}
}
