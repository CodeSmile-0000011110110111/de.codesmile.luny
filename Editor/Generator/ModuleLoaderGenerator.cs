// Copyright (C) 2021-2025 Steffen Itterheim
// Refer to included LICENSE file for terms and conditions.

using CodeSmile;
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
		public static void Generate(LunyLuaModule module, String contentFolderPath, TypeHierarchy typeHierarchy)
		{
			var @namespace = module.BindingsAssemblyNamespace;
			var typeName = module.name.SanitizeIdentifier();
			var loaderClassName = typeName + "_Loader";
			module.ModuleLoaderTypeName = $"{@namespace}.{loaderClassName}";

			var sb = new ScriptBuilder(GenUtil.GeneratedFileHeader);
			sb.AppendLine("using CodeSmile.Luny;");
			foreach (var ns in typeHierarchy.Namespaces)
			{
				sb.Append("using ");
				sb.Append(ns);
				sb.AppendLine(";");
			}
			sb.AppendLine();

			sb.AppendLine($"namespace {@namespace}");
			sb.OpenIndentedBlock("{"); // namespace
			sb.AppendIndentedLine("[Serializable]");
			sb.AppendIndentedLine($"public sealed class {loaderClassName} : {nameof(LunyLuaModuleLoader)}");
			sb.OpenIndentedBlock("{"); // class
			sb.AppendIndentedLine("public override void Load(LuaTable env)");
			sb.OpenIndentedBlock("{"); // Load(..)
			sb.AppendIndentedLine("base.Load(env);");
			GenerateTypes(sb, module, typeHierarchy);
			sb.CloseIndentedBlock("}"); // Load(..)
			sb.CloseIndentedBlock("}"); // class
			sb.CloseIndentedBlock("}"); // namespace

			var assetPath = $"{contentFolderPath}/{loaderClassName}.cs";
			var fullPath = Path.GetFullPath(assetPath);
			File.WriteAllText(fullPath, sb.ToString());
		}

		private static void GenerateTypes(ScriptBuilder sb, LunyLuaModule module, TypeHierarchy typeHierarchy)
		{
			var namespaceTables = new Dictionary<String, String>();

			foreach (var @namespace in typeHierarchy.Namespaces)
			{
				var namespaceTableName = $"{@namespace.Replace(".", "")}Table";
				namespaceTables.Add(@namespace, namespaceTableName);

				var namespaceParts = @namespace.Split('.');

				sb.AppendIndented("var ");
				sb.Append(namespaceTableName);
				sb.Append(" = GetOrCreateNamespaceTable(env, new[] { ");
				var firstPart = true;
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

			var systemObjectType = typeof(object);
			typeHierarchy.Visit((node, level) =>
			{
				var type = node.Value;
				if (type.IsAbstract == false && type != systemObjectType)
				{
					if (type.IsEnum)
					{
						sb.AppendIndented($"LuaUtil.CreateEnumTable(typeof(");
						if (type.IsNested)
						{
							sb.Append(type.DeclaringType.Name);
							sb.Append(".");
						}
						sb.Append(type.Name);
						sb.AppendLine("));");
					}
					else
					{
						var namespaceTableName = namespaceTables[type.Namespace];
						sb.Append("//");
						sb.AppendIndented(namespaceTableName);
						sb.Append(" = new Lua_");
						sb.Append(type.FullName.Replace('.', '_'));
						sb.AppendLine("_API();");
					}

					var indent = new String('\t', level);
					Debug.Log($"[{level}] {indent}{type}");
				}
			});
		}
	}
}
