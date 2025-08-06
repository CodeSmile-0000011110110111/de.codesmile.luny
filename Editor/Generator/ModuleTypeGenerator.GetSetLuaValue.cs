// Copyright (C) 2021-2025 Steffen Itterheim
// Refer to included LICENSE file for terms and conditions.

using Lua;
using LunyEditor.Generator.CSharp;
using System;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

namespace LunyEditor.Generator
{
	internal static partial class ModuleTypeGenerator
	{
		private static void CreateMethodGetterCase(IList<String> getters, String fieldName, String luaFuncName) =>
			getters.Add($"case \"{luaFuncName}\": _value = {fieldName}; return true;");

		private static void AddIndexMetamethod(ScriptBuilder sb, String typeName)
		{
			sb.AppendIndentLine(
				"private static readonly global::Lua.LuaFunction __index = new(global::Lua.Runtime.Metamethods.Index, (_context, _) =>");
			sb.OpenIndentBlock("{");
			sb.AppendIndent("var _this = _context.GetArgument<");
			sb.Append(typeName);
			sb.AppendLine(">(0);");
			sb.AppendIndentLine("var _key = _context.GetArgument(1);");
			sb.AppendIndentLine("global::Lua.LuaValue _value = global::Lua.LuaValue.Nil;");

			sb.AppendIndentLine("if (_key.TryRead<global::System.Int32>(out var _index) && _this.GetLuaValue(_context, _index, out _value))");
			sb.IncrementIndent();
			sb.AppendIndentLine("return new global::System.Threading.Tasks.ValueTask<global::System.Int32>(_context.Return(_value));");
			sb.DecrementIndent();
			sb.AppendIndentLine("if (_key.TryRead<global::System.String>(out var _name) && _this.GetLuaValue(_context, _name, out _value))");
			sb.IncrementIndent();
			sb.AppendIndentLine("return new global::System.Threading.Tasks.ValueTask<global::System.Int32>(_context.Return(_value));");
			sb.DecrementIndent();

			sb.AppendIndentLine(
				"throw new global::Lua.LuaRuntimeException(_context.Thread, $\"attempt to index nil value '{_key}' on '{_this}'\", 2);");
			sb.CloseIndentBlock("});");
		}

		private static void AddNewIndexMetamethod(ScriptBuilder sb, String typeName)
		{
			sb.AppendIndentLine(
				"private static readonly global::Lua.LuaFunction __newindex = new(global::Lua.Runtime.Metamethods.NewIndex, (_context, _) =>");
			sb.OpenIndentBlock("{");
			sb.AppendIndent("var _this = _context.GetArgument<");
			sb.Append(typeName);
			sb.AppendLine(">(0);");
			sb.AppendIndentLine("var _key = _context.GetArgument(1);");
			sb.AppendIndentLine("var _value = _context.GetArgument(2);");

			sb.AppendIndentLine("if (_key.TryRead<global::System.Int32>(out var _index) && _this.SetLuaValue(_context, _index, _value))");
			sb.IncrementIndent();
			sb.AppendIndentLine("return new global::System.Threading.Tasks.ValueTask<global::System.Int32>(_context.Return(_value));");
			sb.DecrementIndent();
			sb.AppendIndentLine("if (_key.TryRead<global::System.String>(out var _name) && _this.SetLuaValue(_context, _name, _value))");
			sb.IncrementIndent();
			sb.AppendIndentLine("return new global::System.Threading.Tasks.ValueTask<global::System.Int32>(_context.Return(_value));");
			sb.DecrementIndent();

			sb.AppendIndentLine(
				"throw new global::Lua.LuaRuntimeException(_context.Thread, $\"attempt to assign to unknown '{_key}' on '{_this}'\", 2);");
			sb.CloseIndentBlock("});");
		}

		private static void AddGetValueMethod(ScriptBuilder sb, GenTypeInfo typeInfo, GenTypeInfo baseType, GenMemberInfo members,
			Boolean isLuaStaticType, IList<String> getters, Boolean isIndexer = false)
		{
			AddGetSetValueMethodClassifiers(sb, typeInfo, baseType, isLuaStaticType);
			sb.Append("global::System.Boolean GetLuaValue(global::");
			sb.Append(typeof(LuaFunctionExecutionContext).FullName);
			sb.Append(" _context, ");
			sb.Append(isIndexer ? "global::System.Int32" : "global::System.String");
			sb.AppendLine(" _key, out global::Lua.LuaValue _value)");
			sb.OpenIndentBlock("{");
			if (isIndexer)
				AddGetValueForIndexer(sb, typeInfo, baseType, members, isLuaStaticType);
			else
			{
				sb.AppendIndentLine("switch (_key)");
				sb.OpenIndentBlock("{");
				foreach (var getter in getters)
					sb.AppendIndentLine(getter);
				AddGetValueCasesForPropertiesAndFields(sb, typeInfo, members, isLuaStaticType);

				if (isLuaStaticType == false && baseType != null)
					sb.AppendIndentLine("default: return base.GetLuaValue(_context, _key, out _value);");
				else
					sb.AppendIndentLine("default: _value = global::Lua.LuaValue.Nil; return false;");
				sb.CloseIndentBlock("}");
			}
			sb.CloseIndentBlock("}");
		}

		private static void AddGetValueCasesForPropertiesAndFields(ScriptBuilder sb, GenTypeInfo typeInfo, GenMemberInfo members,
			Boolean isLuaStaticType)
		{
			foreach (var property in members.Properties)
			{
				if (property.CanRead && property.GetMethod.IsPublic && property.IsIndexer() == false)
				{
					AddCaseStatement(sb, property.Name);
					AddGetValueAndReturn(sb, typeInfo, property.PropertyType, property.Name, isLuaStaticType);
				}
			}

			foreach (var field in members.Fields)
			{
				AddCaseStatement(sb, field.Name);
				AddGetValueAndReturn(sb, typeInfo, field.FieldType, field.Name, isLuaStaticType);
			}
		}

		private static void AddGetValueForIndexer(ScriptBuilder sb, GenTypeInfo typeInfo, GenTypeInfo baseType, GenMemberInfo members,
			Boolean isLuaStaticType)
		{
			var hasIndexer = false;
			foreach (var property in members.Properties)
			{
				if (property.CanRead == false || property.GetMethod.IsPublic == false)
					continue;

				var indexParamCount = property.GetIndexParameters().Length;
				if (indexParamCount == 1)
				{
					hasIndexer = true;
					sb.AppendIndent();
					AddGetValueAndReturn(sb, typeInfo, property.PropertyType, property.Name, isLuaStaticType, true);
				}
			}

			if (hasIndexer == false)
			{
				if (isLuaStaticType == false && baseType != null)
					sb.AppendIndentLine("return base.GetLuaValue(_context, _key, out _value);");
				else
					sb.AppendIndentLine("_value = global::Lua.LuaValue.Nil; return false;");
			}
		}

		private static void AddCaseStatement(ScriptBuilder sb, String memberName)
		{
			sb.AppendIndent("case \"");
			sb.Append(memberName);
			sb.Append("\": ");
		}

		private static void AddGetValueAndReturn(ScriptBuilder sb, GenTypeInfo typeInfo, Type memberType, String memberName,
			Boolean isLuaStaticType, Boolean isIndexer = false)
		{
			sb.Append("_value = ");
			var isValueType = typeInfo.IsValueType;
			var accessor = isLuaStaticType ? typeInfo.BindTypeFullName : isValueType ? typeInfo.InstanceFieldName : typeInfo.InstancePropertyName;
			AddConversionToLuaValue(sb, typeInfo, memberType, isIndexer ? $"{accessor}[_key]" : $"{accessor}.{memberName}");
			sb.AppendLine("; return true;");
		}

		private static void AddSetValueMethod(ScriptBuilder sb, GenTypeInfo typeInfo, GenTypeInfo baseType, GenMemberInfo members,
			Boolean isLuaStaticType, Boolean isIndexer = false)
		{
			AddGetSetValueMethodClassifiers(sb, typeInfo, baseType, isLuaStaticType);
			sb.Append("global::System.Boolean SetLuaValue(global::");
			sb.Append(typeof(LuaFunctionExecutionContext).FullName);
			sb.Append(" _context, ");
			sb.Append(isIndexer ? "global::System.Int32" : "global::System.String");
			sb.AppendLine(" _key, global::Lua.LuaValue _value)");
			sb.OpenIndentBlock("{");
			if (isIndexer)
				AddSetValueForIndexer(sb, typeInfo, baseType, members, isLuaStaticType);
			else
			{
				sb.AppendIndentLine("switch (_key)");
				sb.OpenIndentBlock("{");
				AddSetValueCasesForPropertiesAndFields(sb, typeInfo, members, isLuaStaticType);

				if (isLuaStaticType == false && baseType != null && typeInfo.IsValueType == false)
					sb.AppendIndentLine("default: return base.SetLuaValue(_context, _key, _value);");
				else
					sb.AppendIndentLine("default: return false;");
				sb.CloseIndentBlock("}");
			}
			sb.CloseIndentBlock("}");
		}

		private static void AddGetSetValueMethodClassifiers(ScriptBuilder sb, GenTypeInfo typeInfo, GenTypeInfo baseType,
			Boolean isLuaStaticType)
		{
			sb.AppendIndent(typeInfo.IsStatic || typeInfo.IsValueType ? "private " : "public ");
			if (isLuaStaticType == false && typeInfo.IsValueType == false)
				sb.Append(baseType != null ? "override " : typeInfo.IsSealed == false ? "virtual " : "");
		}

		private static void AddSetValueCasesForPropertiesAndFields(ScriptBuilder sb, GenTypeInfo typeInfo, GenMemberInfo members,
			Boolean isLuaStaticType)
		{
			foreach (var property in members.Properties)
			{
				if (property.CanWrite && property.SetMethod.IsPublic && property.IsIndexer() == false)
				{
					AddCaseStatement(sb, property.Name);
					AddSetValueAndReturn(sb, typeInfo, property.PropertyType, property.Name, isLuaStaticType);
				}
			}

			foreach (var field in members.Fields)
			{
				if (field.IsLiteral || field.IsInitOnly)
					continue;

				AddCaseStatement(sb, field.Name);
				AddSetValueAndReturn(sb, typeInfo, field.FieldType, field.Name, isLuaStaticType);
			}
		}

		private static void AddSetValueForIndexer(ScriptBuilder sb, GenTypeInfo typeInfo, GenTypeInfo baseType, GenMemberInfo members,
			Boolean isLuaStaticType)
		{
			var hasIndexer = false;
			foreach (var property in members.Properties)
			{
				if (property.CanWrite == false || property.SetMethod.IsPublic == false)
					continue;

				var indexParamCount = property.GetIndexParameters().Length;
				if (indexParamCount == 1)
				{
					hasIndexer = true;
					sb.AppendIndent();
					AddSetValueAndReturn(sb, typeInfo, property.PropertyType, property.Name, isLuaStaticType, true);
				}
			}

			if (hasIndexer == false)
			{
				if (isLuaStaticType == false && baseType != null)
					sb.AppendIndentLine("return base.SetLuaValue(_context, _key, _value);");
				else
					sb.AppendIndentLine("return false;");
			}
		}

		private static void AddSetValueAndReturn(ScriptBuilder sb, GenTypeInfo typeInfo, Type memberType, String memberName,
			Boolean isLuaStaticType, Boolean isIndexer = false)
		{
			var isValueType = typeInfo.IsValueType;
			var accessor = isLuaStaticType ? typeInfo.BindTypeFullName : GetFieldOrPropertyName(typeInfo);
			if (isValueType && isLuaStaticType == false)
			{
				sb.Append("{ var _temp = ");
				sb.Append(typeInfo.InstanceFieldName);
				sb.Append("; ");
				accessor = "_temp";
			}

			sb.Append(accessor);
			if (isIndexer)
				sb.Append("[_key]");
			else
			{
				sb.Append(".");
				sb.Append(memberName);
			}

			ModuleGenerator.TypeInfosByType.TryGetValue(memberType, out var generatedType);
			sb.Append(" = _value.Read<");

			if (generatedType != null && memberType.IsEnum == false)
			{
				sb.Append(generatedType.LuaInstanceTypeFullName);
				sb.Append(">()");
				sb.Append(".");
				sb.Append(generatedType.InstancePropertyName);
				sb.Append("; ");
			}
			else
			{
				sb.Append("global::");
				sb.Append(memberType.FullName.Replace('+', '.'));
				sb.Append(">(); ");
			}

			if (typeInfo.IsValueType && isLuaStaticType == false)
			{
				sb.Append(typeInfo.InstanceFieldName);
				sb.Append(" = _temp; }");
			}

			sb.AppendLine(" return true;");
		}

		private static String GetFieldOrPropertyName(GenTypeInfo typeInfo) => typeInfo.IsValueType ? typeInfo.InstanceFieldName : typeInfo.InstancePropertyName;
	}
}
