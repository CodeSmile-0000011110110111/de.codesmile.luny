// Copyright (C) 2021-2025 Steffen Itterheim
// Refer to included LICENSE file for terms and conditions.

using CodeSmile.Luny;
using System;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;
using UnityEditor;
using UnityEngine;

namespace CodeSmileEditor.Luny.Generator
{
	internal sealed class ModuleLoaderGenerator
	{
		public static async Task Generate(LunyLuaModule module, String contentFolderPath, TypeHierarchy typeHierarchy,
			IEnumerable<TypeGenerator.TypeInfo> typeInfos)
		{
			var @namespace = module.BindingsAssemblyNamespace;
			var loaderClassName = $"Lua_{module.AssemblyName.Replace('.', '_')}_Loader";
			module.ModuleLoaderTypeName = $"{@namespace}.{loaderClassName}";

			var sb = new ScriptBuilder(GenUtil.GeneratedFileHeader);
			sb.AppendLine("using CodeSmile.Luny;");
			sb.AppendLine("using Lua;");
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
			GenerateTypeInitialization(sb, typeHierarchy, typeInfos);
			sb.CloseIndentedBlock("}"); // Load(..)
			sb.CloseIndentedBlock("}"); // class
			sb.CloseIndentedBlock("}"); // namespace

			var assetPath = $"{contentFolderPath}/Lua_{module.AssemblyName}_Loader.cs";
			var fullPath = Path.GetFullPath(assetPath);
			await File.WriteAllTextAsync(fullPath, sb.ToString());
		}

		private static void GenerateTypeInitialization(ScriptBuilder sb, TypeHierarchy typeHierarchy,
			IEnumerable<TypeGenerator.TypeInfo> typeInfos)
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

			foreach (var typeInfo in typeInfos)
			{
				var type = typeInfo.Type;
				if (type.IsEnum)
				{
					sb.AppendIndented("LuaUtil.CreateEnumTable(typeof(");
					sb.Append(typeInfo.BindTypeFullName);
					sb.AppendLine("));");
				}
				else
				{
					var namespaceTableName = namespaceTables[type.Namespace];
					sb.AppendIndented(namespaceTableName);
					sb.Append("[\"");
					sb.Append(typeInfo.Type.Name);
					sb.Append("\"] = new ");
					sb.Append(typeInfo.StaticTypeName);
					sb.AppendLine("();");
				}

				// Debug.Log($"[{level}] {new String('\t', level)}{type}");
			}
		}
	}
}
