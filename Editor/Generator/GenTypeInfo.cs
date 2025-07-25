// Copyright (C) 2021-2025 Steffen Itterheim
// Refer to included LICENSE file for terms and conditions.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using UnityEditor;
using UnityEngine;
using Object = System.Object;

namespace CodeSmileEditor.Luny.Generator
{
	internal sealed class GenTypeInfo
	{
		public readonly Type Type;
		public readonly String InstanceTypeName;
		public readonly String StaticTypeName;
		public readonly String BindTypeFullName;
		public readonly Boolean IsStatic;
		public String InstanceFieldName;
		public GenMemberInfo InstanceMembers;
		public GenMemberInfo StaticMembers;

		public GenTypeInfo(Type type, String onlyThisMethodName = null)
		{
			Type = type;
			var typeFullName = type.FullName ?? type.Name;
			var typeFullNameNoPlus = typeFullName.Replace('+', '.');
			BindTypeFullName = typeFullNameNoPlus;

			var typeFullNameNoDots = typeFullNameNoPlus.Replace('.', '_');
			InstanceTypeName = $"Lua_{typeFullNameNoDots}";
			StaticTypeName = $"{InstanceTypeName}_static";

			if (type.IsEnum == false)
			{
				IsStatic = type.IsAbstract && type.IsSealed;
				InstanceFieldName = type.IsValueType ? "m_Value" : "m_Instance";
				var flags = BindingFlags.Public | BindingFlags.DeclaredOnly;
				InstanceMembers = new GenMemberInfo(type, flags | BindingFlags.Instance, onlyThisMethodName);
				StaticMembers = new GenMemberInfo(type, flags | BindingFlags.Static, onlyThisMethodName);
			}
		}
	}

	internal sealed class GenMemberInfo
	{
		public IEnumerable<ConstructorInfo> Ctors;
		public IEnumerable<FieldInfo> Fields;
		public IEnumerable<PropertyInfo> Properties;
		public IEnumerable<MethodInfo> Methods;
		public IEnumerable<EventInfo> Events;
		public IEnumerable<GenMethodOverloads> CtorOverloads;
		public IEnumerable<GenMethodOverloads> MethodOverloads;
		public Boolean HasMembers;
		public Boolean IsStatic;

		public GenMemberInfo(Type type, BindingFlags bindingFlags, String onlyThisMethodName)
		{
			var obsolete = typeof(ObsoleteAttribute);
			// FIXME: missing parameterless Ctor (assume always present for value types)
			Ctors = type.GetConstructors(bindingFlags)
				.Where(c => !(type.IsAbstract || c.GetCustomAttributes(obsolete).Any()))
				.OrderBy(c => c.GetParameters().Length);
			Fields = type.GetFields(bindingFlags).Where(f => !f.GetCustomAttributes(obsolete).Any()).OrderBy(f => f.Name);
			Properties = type.GetProperties(bindingFlags).Where(p => !p.GetCustomAttributes(obsolete).Any()).OrderBy(p => p.Name);
			Methods = type.GetMethods(bindingFlags)
				.Where(m => !(m.IsSpecialName || m.GetCustomAttributes(obsolete).Any()))
				.OrderBy(m => m.Name);
			Events = type.GetEvents(bindingFlags).Where(e => !e.GetCustomAttributes(obsolete).Any()).OrderBy(e => e.Name);
			CtorOverloads = GetMethodOverloads(Ctors, onlyThisMethodName);
			MethodOverloads = GetMethodOverloads(Methods, onlyThisMethodName);
			HasMembers = Ctors.Any() || Events.Any() || Fields.Any() || Properties.Any() || Methods.Any();
			IsStatic = bindingFlags.HasFlag(BindingFlags.Static);
		}

		private IEnumerable<GenMethodOverloads> GetMethodOverloads(IEnumerable<MethodBase> methods, String onlyThisMethodName)
		{
			var methodOverloads = new Dictionary<String, GenMethodOverloads>();
			foreach (var method in methods)
			{
				if (String.IsNullOrWhiteSpace(onlyThisMethodName) == false && onlyThisMethodName != method.Name)
					continue;

				//Debug.Log($"{method.DeclaringType.FullName}: Add {method.Name} with {method.GetParameters().Length} parameters.");
				if (methodOverloads.TryGetValue(method.Name, out var existingOverloads))
					existingOverloads.AddOverload(method);
				else
				{
					var overload = new GenMethodOverloads { Name = method.Name };
					overload.AddOverload(method);
					methodOverloads.Add(method.Name, overload);
				}
			}

			foreach (var overload in methodOverloads.Values)
				overload.Postprocess();

			return methodOverloads.Values.OrderBy(overload => overload.Name);
		}
	}

	internal sealed class GenMethodOverloads : IEquatable<GenMethodOverloads>
	{
		private List<MethodBase> m_Methods = new();

		public String Name;
		public Int32 MaxParamCount;
		public Boolean IsConstructor;
		public Boolean IsStaticMethod;
		public Boolean IsInstanceMethod => !(IsStaticMethod || IsConstructor);
		public Int32 LuaArgCount => MaxParamCount + (IsInstanceMethod ? 1 : 0);
		public List<GenMethodInfo> SortedMethods { get; } = new();
		public Int32 Count => SortedMethods.Count;

		public static Boolean operator ==(GenMethodOverloads left, GenMethodOverloads right) => left.Equals(right);
		public static Boolean operator !=(GenMethodOverloads left, GenMethodOverloads right) => !left.Equals(right);

		private static Boolean IsUnsupported(MethodBase method, ParameterInfo parameter)
		{
			if (method.IsGenericMethod)
			{
				TypeGenerator.Log($"Skip: {method.DeclaringType.FullName}::{method.Name}" +
				                  $"({GenUtil.ToString(method.GetParameters())}) - is a generic method");
				return true;
			}

			var paramType = parameter.ParameterType;
			if (paramType.IsPointer || paramType == typeof(IntPtr) || paramType == typeof(UIntPtr))
			{
				TypeGenerator.Log($"Skip: {method.DeclaringType.FullName}::{method.Name}" +
				                  $"({GenUtil.ToString(method.GetParameters())}) - unsupported: " +
				                  $"'{parameter.ParameterType.Name} {parameter.Name}' (pointer)");
				return true;
			}
			if (paramType.IsGenericType || paramType.IsGenericParameter)
			{
				TypeGenerator.Log($"Skip: {method.DeclaringType.FullName}::{method.Name}" +
				                  $"({GenUtil.ToString(method.GetParameters())}) - unsupported: " +
				                  $"'{parameter.ParameterType.Name} {parameter.Name}' (generic)");
				return true;
			}
			if (paramType.IsByRef)
			{
				TypeGenerator.Log($"Skip: {method.DeclaringType.FullName}::{method.Name}" +
				                  $"({GenUtil.ToString(method.GetParameters())}) - unsupported: " +
				                  $"'{parameter.ParameterType.Name} {parameter.Name}' (by ref)");
				return true;
			}
			if (paramType.IsArray)
			{
				TypeGenerator.Log($"Skip: {method.DeclaringType.FullName}::{method.Name}" +
				                  $"({GenUtil.ToString(method.GetParameters())}) - unsupported: " +
				                  $"'{parameter.ParameterType.Name} {parameter.Name}' (array)");
				return true;
			}
			if (paramType.IsEnum)
			{
				TypeGenerator.Log($"Skip: {method.DeclaringType.FullName}::{method.Name}" +
				                  $"({GenUtil.ToString(method.GetParameters())}) - unsupported: " +
				                  $"'{parameter.ParameterType.Name} {parameter.Name}' (enum)");
				return true;
			}
			if (paramType.IsInterface)
			{
				TypeGenerator.Log($"Skip: {method.DeclaringType.FullName}::{method.Name}" +
				                  $"({GenUtil.ToString(method.GetParameters())}) - unsupported: " +
				                  $"'{parameter.ParameterType.Name} {parameter.Name}' (interface)");
				return true;
			}
			return false;
		}

		public Boolean Equals(GenMethodOverloads other) => Equals(Name, other.Name);

		public override String ToString() => $"{Name}: {Count} overloads";

		public void AddOverload(MethodBase method)
		{
			if (method is MethodInfo methodInfo && IsUnsupported(method, methodInfo.ReturnParameter))
				return;

			foreach (var parameter in method.GetParameters())
			{
				if (IsUnsupported(method, parameter))
					return;
			}

			m_Methods.Add(method);

			IsConstructor = method.IsConstructor;
			IsStaticMethod = method.IsStatic;
		}

		public void Postprocess()
		{
			// sort by total parameter count first (this becomes the secondary sort order)
			// Note: may be superfluous, but docs state that prior to .NET 7 there is no guaranteed method order
			m_Methods.Sort((m1, m2) => m1.GetParameters().Length.CompareTo(m2.GetParameters().Length));

			var paramsByPosition = new List<HashSet<GenParamInfo>>();
			var allMethods = new List<GenMethodInfo>();
			MaxParamCount = 0;

			foreach (var overload in m_Methods)
			{
				var overloadParams = overload.GetParameters();
				var overloadParamCount = overloadParams.Length;
				var overloadMinParamCount = overloadParamCount;

				// reverse enumerate parameters to find min number of required parameters
				var trailingOptionalParameterCount = 0;
				for (var i = overloadParamCount - 1; i >= 0; i--)
				{
					if (overloadParams[i].IsOptional == false)
						break;

					trailingOptionalParameterCount++;
					overloadMinParamCount--;
				}

				// update Max param count of all overloads
				if (MaxParamCount < overloadParamCount)
					MaxParamCount = overloadParamCount;

				// generate parameter infos
				var paramInfos = new GenParamInfo[overloadParamCount];
				var overloadInfo = new GenMethodInfo
				{
					MethodInfo = overload,
					ParamInfos = paramInfos,
				};

				for (var pos = 0; pos < overloadParamCount; pos++)
				{
					var parameter = overloadParams[pos];
					var paramType = parameter.ParameterType;
					var paramTypeName = paramType.FullName.Replace('+', '_').Replace('.', '_');
					if (paramType.IsArray)
						paramTypeName = paramTypeName.Replace("[]", "Array");
					var bindVarName = $"_p{pos}_{paramTypeName}";

					var paramInfo = new GenParamInfo
					{
						Name = parameter.Name,
						ParamInfo = parameter,
						VariableName = bindVarName,
						MethodInfo = overloadInfo,
					};
					paramInfos[pos] = paramInfo;

					if (paramsByPosition.Count <= pos)
						paramsByPosition.Add(new HashSet<GenParamInfo>());
					paramsByPosition[pos].Add(paramInfo);
				}

				// treat methods with trailing optional parameters as overloads
				for (var i = trailingOptionalParameterCount; i > 0; i--)
				{
					var optionalParamInfos = overloadInfo.ParamInfos.Clone() as GenParamInfo[];
					Array.Resize(ref optionalParamInfos, overloadParamCount - i);
					var optionalParamMethod = new GenMethodInfo
					{
						MethodInfo = overload,
						ParamInfos = optionalParamInfos,
					};
					allMethods.Add(optionalParamMethod);
				}

				allMethods.Add(overloadInfo);
			}

			var signature = new List<GenParamInfo>();
			FindOverloadsByTypeRecursive(allMethods, 0, paramsByPosition, signature);

			// if (SortedMethods.Count > 0)
			// {
			// 	Debug.Log("Methods to generate, in this order:");
			// 	for (var i = 0; i < SortedMethods.Count; i++)
			// 		Debug.Log($"\t[{i}] {SortedMethods[i]}");
			// }

			m_Methods = null;
		}

		private void FindOverloadsByTypeRecursive(List<GenMethodInfo> methods, Int32 paramPos, List<HashSet<GenParamInfo>> paramsByPosition,
			List<GenParamInfo> signature)
		{
			//Debug.Log($"[{pos}] {signature.Count}/{MaxParamCount} {paramsByPosition.Count} => ({DebugSignatureToString(signature)})");
			for (var i = 0; i < methods.Count; i++)
			{
				var method = methods[i];
				if (paramPos >= method.ParamCount && method.HasMatchingSignature(signature))
					SortedMethods.Add(method);
			}

			if (paramPos < paramsByPosition.Count)
			{
				var parameters = paramsByPosition[paramPos];
				foreach (var parameter in parameters)
				{
					var nextSignature = new List<GenParamInfo>(signature);
					nextSignature.Add(parameter);
					FindOverloadsByTypeRecursive(methods, paramPos + 1, paramsByPosition, nextSignature);
				}
			}
		}

		private String DebugSignatureToString(List<GenParamInfo> signature)
		{
			var sb = new StringBuilder();
			for (var i = 0; i < signature.Count; i++)
			{
				if (i > 0)
					sb.Append(", ");
				sb.Append(signature[i].Type.Name);
			}
			return sb.ToString();
		}

		public override Int32 GetHashCode() => Name != null ? Name.GetHashCode() : 0;
		public override Boolean Equals(Object obj) => obj is GenMethodOverloads other && Equals(other);
	}

	internal sealed class GenMethodInfo : IEquatable<GenMethodInfo>
	{
		public MethodBase MethodInfo;
		public GenParamInfo[] ParamInfos;
		public Int32 ParamCount => ParamInfos?.Length ?? 0;

		public static Boolean operator ==(GenMethodInfo left, GenMethodInfo right) => Equals(left, right);
		public static Boolean operator !=(GenMethodInfo left, GenMethodInfo right) => !Equals(left, right);

		public Boolean Equals(GenMethodInfo other)
		{
			if (other is null)
				return false;
			if (ReferenceEquals(this, other))
				return true;

			return Equals(MethodInfo, other.MethodInfo) && Equals(ParamInfos, other.ParamInfos);
		}

		public override Boolean Equals(Object obj) => ReferenceEquals(this, obj) || obj is GenMethodInfo other && Equals(other);

		public override Int32 GetHashCode()
		{
			unchecked
			{
				return (MethodInfo != null ? MethodInfo.GetHashCode() : 0) * 397 ^ (ParamInfos != null ? ParamInfos.GetHashCode() : 0);
			}
		}

		public override String ToString()
		{
			var sb = new StringBuilder();
			sb.Append(MethodInfo.Name);
			sb.Append(" (");

			for (var i = 0; i < ParamInfos.Length; i++)
			{
				var paramInfo = ParamInfos[i];
				if (i > 0)
					sb.Append(", ");
				sb.Append(paramInfo.Type.FullName);
				sb.Append(" ");
				sb.Append(paramInfo.Name);
			}

			sb.Append(")  ");
			sb.Append(ParamCount);
			sb.Append(" params");

			return sb.ToString();
		}

		public Boolean HasMatchingSignature(List<GenParamInfo> signature)
		{
			if (signature == null || signature.Count > ParamInfos.Length)
				return false;

			if (signature.Count == 0 && ParamInfos.Length == 0)
				return true;

			for (var i = 0; i < signature.Count; i++)
			{
				if (ParamInfos[i].Type != signature[i].Type)
					return false;
			}

			return true;
		}
	}

	internal sealed class GenParamInfo : IEquatable<GenParamInfo>
	{
		private string m_TypeFullName;

		public ParameterInfo ParamInfo;
		public String Name { get; set; }
		public Type Type => ParamInfo?.ParameterType;
		public String TypeFullName => m_TypeFullName ??= ParamInfo.ParameterType.FullName?.Replace('+', '.');
		public Int32 Position => ParamInfo.Position;
		public Boolean IsUserData => !(Type.IsPrimitive || Type == typeof(String));
		public String VariableName { get; set; }
		public GenMethodInfo MethodInfo { get; set; }

		public static Boolean operator ==(GenParamInfo left, GenParamInfo right) =>
			left is null && right is null || left is not null && left.Equals(right);

		public static Boolean operator !=(GenParamInfo left, GenParamInfo right) =>
			left is null && right is not null || left is not null && !left.Equals(right);

		public Boolean Equals(GenParamInfo other) => other is not null && Equals(Type, other.Type);

		public override String ToString() => $"{Type?.Name} {Name}";

		public override Int32 GetHashCode() => Type != null ? Type.GetHashCode() : 0;

		public override Boolean Equals(Object obj) => obj is GenParamInfo other && Equals(other);
	}

	[Obsolete]
	internal struct OBSOLETE_GenMemberGroup : IEquatable<OBSOLETE_GenMemberGroup>
	{
		public String Name;
		public List<MemberInfo> Overloads;

		public override Int32 GetHashCode() => Name != null ? Name.GetHashCode() : 0;
		public Boolean Equals(OBSOLETE_GenMemberGroup other) => Equals(Name, other.Name);
		public override Boolean Equals(Object obj) => obj is OBSOLETE_GenMemberGroup other && Equals(other);
		public static Boolean operator ==(OBSOLETE_GenMemberGroup left, OBSOLETE_GenMemberGroup right) => left.Equals(right);
		public static Boolean operator !=(OBSOLETE_GenMemberGroup left, OBSOLETE_GenMemberGroup right) => !left.Equals(right);
	}
}
