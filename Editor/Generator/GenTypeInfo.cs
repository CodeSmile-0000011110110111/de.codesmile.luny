// Copyright (C) 2021-2025 Steffen Itterheim
// Refer to included LICENSE file for terms and conditions.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using UnityEditor;
using UnityEngine;
using Debug = UnityEngine.Debug;
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
		public IEnumerable<GenMethodGroup> CtorGroups;
		public IEnumerable<GenMethodGroup> MethodGroups;
		public Boolean HasMembers;
		public Boolean IsStatic;

		public GenMemberInfo(Type type, BindingFlags bindingFlags, String onlyThisMethodName)
		{
			var obsolete = typeof(ObsoleteAttribute);
			// FIXME: missing parameterless Ctor (assume always present for value types)
			Ctors = type.GetConstructors(bindingFlags)
				.Where(c => !c.GetCustomAttributes(obsolete).Any())
				.OrderBy(c => c.GetParameters().Length);
			Fields = type.GetFields(bindingFlags).Where(f => !f.GetCustomAttributes(obsolete).Any()).OrderBy(f => f.Name);
			Properties = type.GetProperties(bindingFlags).Where(p => !p.GetCustomAttributes(obsolete).Any()).OrderBy(p => p.Name);
			Methods = type.GetMethods(bindingFlags)
				.Where(m => !(m.IsSpecialName || m.GetCustomAttributes(obsolete).Any()))
				.OrderBy(m => m.Name);
			Events = type.GetEvents(bindingFlags).Where(e => !e.GetCustomAttributes(obsolete).Any()).OrderBy(e => e.Name);
			CtorGroups = GetMethodGroups(Ctors, onlyThisMethodName);
			MethodGroups = GetMethodGroups(Methods, onlyThisMethodName);
			HasMembers = Ctors.Any() || Events.Any() || Fields.Any() || Properties.Any() || Methods.Any();
			IsStatic = bindingFlags.HasFlag(BindingFlags.Static);
		}

		private IEnumerable<GenMethodGroup> GetMethodGroups(IEnumerable<MethodBase> methods, String onlyThisMethodName)
		{
			var methodGroups = new Dictionary<String, GenMethodGroup>();
			foreach (var method in methods)
			{
				if (onlyThisMethodName != null && onlyThisMethodName != method.Name)
					continue;

				Debug.Log($"{method.DeclaringType.FullName}: Add {method.Name} with {method.GetParameters().Length} parameters.");
				if (methodGroups.TryGetValue(method.Name, out var existingGroup))
					existingGroup.AddOverload(method);
				else
				{
					var group = new GenMethodGroup { Name = method.Name, MinArgCount = Int32.MaxValue };
					group.AddOverload(method);
					methodGroups.Add(method.Name, group);
				}
			}

			foreach (var group in methodGroups.Values)
				group.Postprocess();

			return methodGroups.Values.OrderBy(group => group.Name);
		}
	}

	internal sealed class GenMethodGroup : IEquatable<GenMethodGroup>
	{
		public String Name;
		public Int32 MinArgCount;
		public Int32 MaxArgCount;
		public List<MethodBase> Methods;
		public List<SortedDictionary<GenParamInfo, List<GenMethodInfo>>> OverloadsByParamType;
		/* List = Position (index)
		 *	Dict = List of Methods with same parameter type at this position
		 */

		public static Boolean operator ==(GenMethodGroup left, GenMethodGroup right) => left.Equals(right);
		public static Boolean operator !=(GenMethodGroup left, GenMethodGroup right) => !left.Equals(right);
		public Boolean Equals(GenMethodGroup other) => Equals(Name, other.Name);

		public void AddOverload(MethodBase method)
		{
			foreach (var parameter in method.GetParameters())
			{
				var paramType = parameter.ParameterType;
				if (paramType.IsPointer)
				{
					// Debug.Log($"Skip method: {method.DeclaringType.FullName}::{method.Name} due to pointer param " +
					//           $"'{parameter.ParameterType.Name} {parameter.Name}'");
					return;
				}
				if (paramType.IsGenericType)
				{
					// Debug.Log($"Skip method: {method.DeclaringType.FullName}::{method.Name} due to generic param " +
					//           $"'{parameter.ParameterType.Name} {parameter.Name}'");
					return;
				}
			}

			Methods ??= new List<MethodBase>();
			Methods.Add(method);
		}

		public void Postprocess()
		{
			if (Methods == null)
				return;

			MinArgCount = Int32.MaxValue;
			MaxArgCount = 0;
			Methods.Sort((m1, m2) => m1.GetParameters().Length.CompareTo(m2.GetParameters().Length));
			OverloadsByParamType = new List<SortedDictionary<GenParamInfo, List<GenMethodInfo>>>();

			var uniqueParamsSet = new HashSet<GenParamInfo>();
			var overloadCount = Methods.Count;

			var methodsByParamPosition = new List<List<GenMethodInfo>>();
			for (var overloadIndex = 0; overloadIndex < overloadCount; overloadIndex++)
			{
				var overloadMinArgCount = 0;
				var overload = Methods[overloadIndex];
				var parameters = overload.GetParameters();
				var paramCount = parameters.Length;

				var paramInfos = new GenParamInfo[paramCount];
				var methodInfo = new GenMethodInfo { MethodInfo = overload, ParamInfos = paramInfos };

				for (var pos = 0; pos < paramCount; pos++)
				{
					var parameter = parameters[pos];
					if (parameter.IsOptional == false)
						overloadMinArgCount++;

					if (methodsByParamPosition.Count <= pos)
						methodsByParamPosition.Add(new List<GenMethodInfo>());
					methodsByParamPosition[pos].Add(methodInfo);

					var paramType = parameter.ParameterType;
					var paramName = paramType.Name;
					var varName = $"_p{pos}_{(paramType.IsArray ? paramName.Substring(0, paramName.Length - 2) : paramName)}";
					var paramInfo = new GenParamInfo
					{
						Name = parameter.Name,
						ParamInfo = parameter,
						VariableName = varName,
					};
					paramInfos[pos] = paramInfo;
					uniqueParamsSet.Add(paramInfo);
				}

				if (MinArgCount > overloadMinArgCount)
					MinArgCount = overloadMinArgCount;
				if (MaxArgCount < paramCount)
					MaxArgCount = paramCount;
			}

			for (var pos = 0; pos < methodsByParamPosition.Count; pos++)
			{
				var methodsAtPos = methodsByParamPosition[pos];
				for (var i = 0; i < methodsAtPos.Count; i++)
				{
					var method = methodsAtPos[i];
					var parameter = method.ParamInfos[pos];

					if (OverloadsByParamType.Count <= pos)
						OverloadsByParamType.Add(new SortedDictionary<GenParamInfo, List<GenMethodInfo>>(new ParameterComparer()));
					if (OverloadsByParamType[pos].ContainsKey(parameter) == false)
						OverloadsByParamType[pos][parameter] = new List<GenMethodInfo>();

					if (pos == 0)
						OverloadsByParamType[pos][parameter].Add(method);
					else
					{
						var prevParameters = OverloadsByParamType[pos - 1];
						var prevParameter = method.ParamInfos[pos - 1];
						var methodsWithSamePrevParam = prevParameters[prevParameter];
						if (methodsWithSamePrevParam.Count > 1)
						{
							//Debug.Log($"{pos}: {parameter.Type.Name} {parameter.Name} (prev: {prevParameter.Name}) => {method}");
							OverloadsByParamType[pos][parameter].Add(method);
						}
					}
				}
			}
		}

		public override Int32 GetHashCode() => Name != null ? Name.GetHashCode() : 0;
		public override Boolean Equals(Object obj) => obj is GenMethodGroup other && Equals(other);
	}

	internal sealed class ParameterComparer : IComparer<GenParamInfo>
	{
		public Int32 Compare(GenParamInfo x, GenParamInfo y)
		{
			if (ReferenceEquals(x, y))
				return 0;
			if (y is null)
				return 1;
			if (x is null)
				return -1;

			var xParamInfo = x.ParamInfo;
			var yParamInfo = y.ParamInfo;
			var xHasDefaultValue = xParamInfo.HasDefaultValue;
			var yHasDefaultValue = yParamInfo.HasDefaultValue;

			// parameters with default values are rated less because they will never fail to "read"
			if (xHasDefaultValue && yHasDefaultValue == false)
				return 1;
			if (yHasDefaultValue && xHasDefaultValue == false)
				return -1;

			// value type parameters take precedence
			var xParamType = xParamInfo.ParameterType;
			var yParamType = yParamInfo.ParameterType;
			if (xParamType.IsValueType && yParamType.IsValueType == false)
				return 1;
			if (yParamType.IsValueType && xParamType.IsValueType == false)
				return -1;

			// string types take precedence
			if (xParamType.Equals(typeof(String)) && yParamType.Equals(typeof(String)) == false)
				return 1;
			if (yParamType.Equals(typeof(String)) && xParamType.Equals(typeof(String)) == false)
				return -1;

			// sort by type name
			return String.Compare(xParamType.FullName, yParamType.FullName, StringComparison.Ordinal);
		}
	}

	internal sealed class GenMethodInfo : IEquatable<GenMethodInfo>
	{
		public MethodBase MethodInfo;
		public GenParamInfo[] ParamInfos;

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
			var sb = new StringBuilder(MethodInfo.Name);
			if (ParamInfos != null)
			{
				foreach (var paramInfo in ParamInfos)
				{
					if (paramInfo != null)
					{
						sb.Append(paramInfo.Type);
						sb.Append(" ");
						sb.Append(paramInfo.Name);
						sb.Append(", ");
					}
				}
			}
			return sb.ToString();
		}
	}

	internal sealed class GenParamInfo : IEquatable<GenParamInfo>
	{
		public ParameterInfo ParamInfo;
		public String Name { get; set; }
		public Type Type => ParamInfo.ParameterType;
		public String TypeFullName => ParamInfo.ParameterType.FullName.Replace('+', '.');
		public Int32 Position => ParamInfo.Position;
		public Boolean IsUserData => !(Type.IsPrimitive || Type == typeof(String));
		public String VariableName { get; set; }

		public static Boolean operator ==(GenParamInfo left, GenParamInfo right) =>
			left is null && right is null || left is not null && left.Equals(right);

		public static Boolean operator !=(GenParamInfo left, GenParamInfo right) =>
			left is null && right is not null || left is not null && !left.Equals(right);

		public Boolean Equals(GenParamInfo other) => other is not null /*&& Name == other.Name*/ && Equals(Type, other.Type);

		public override String ToString() => $"{Type.Name} {Name}";

		public override Int32 GetHashCode()
		{
			unchecked
			{
				var hashCode = /*Name != null ? Name.GetHashCode() : 0;
				hashCode = hashCode * 397 ^*/ Type != null ? Type.GetHashCode() : 0;
				return hashCode;
			}
		}

		public override Boolean Equals(Object obj) => obj is GenParamInfo other && Equals(other);
	}

	[Obsolete]
	internal struct GenMemberGroup : IEquatable<GenMemberGroup>
	{
		public String Name;
		public List<MemberInfo> Overloads;

		public override Int32 GetHashCode() => Name != null ? Name.GetHashCode() : 0;
		public Boolean Equals(GenMemberGroup other) => Equals(Name, other.Name);
		public override Boolean Equals(Object obj) => obj is GenMemberGroup other && Equals(other);
		public static Boolean operator ==(GenMemberGroup left, GenMemberGroup right) => left.Equals(right);
		public static Boolean operator !=(GenMemberGroup left, GenMemberGroup right) => !left.Equals(right);
	}
}
