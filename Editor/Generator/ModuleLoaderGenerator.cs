// Copyright (C) 2021-2025 Steffen Itterheim
// Refer to included LICENSE file for terms and conditions.

using CodeSmile;
using CodeSmile.Luny;
using System;
using System.IO;
using UnityEditor;
using UnityEngine;

namespace CodeSmileEditor.Luny.Generator
{
	internal sealed class ModuleLoaderGenerator
	{
		public static void Generate(LunyLuaModule module, String contentFolderPath)
		{
			var @namespace = module.BindingsAssemblyNamespace;
			var typeName = module.name.SanitizeIdentifier();
			var loaderClassName = typeName + "_Loader";
			module.ModuleLoaderTypeName = $"{@namespace}.{loaderClassName}";

			var sb = new ScriptBuilder(GenUtil.GeneratedFileHeader);
			sb.AppendLine("using CodeSmile.Luny;");
			sb.AppendLine("using Lua;");
			sb.AppendLine("using System;");
			sb.AppendLine();
			sb.AppendLine($"namespace {@namespace}");
			sb.OpenIndentedBlock("{");
			sb.AppendIndentedLine("[Serializable]");
			sb.AppendIndentedLine($"public sealed class {loaderClassName} : {nameof(LunyLuaModuleLoader)}");
			sb.OpenIndentedBlock("{");
			sb.AppendIndentedLine("public override void Load(LuaTable env)");
			sb.OpenIndentedBlock("{");
			sb.AppendIndentedLine("base.Load(env);");
			sb.CloseIndentedBlock("}");
			sb.CloseIndentedBlock("}");
			sb.CloseIndentedBlock("}");

			var assetPath = $"{contentFolderPath}/{loaderClassName}.cs";
			var fullPath = Path.GetFullPath(assetPath);
			File.WriteAllText(fullPath, sb.ToString());
		}
	}
}
