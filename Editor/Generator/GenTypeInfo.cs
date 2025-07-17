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

		public GenTypeInfo(Type type)
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
				InstanceMembers = new GenMemberInfo(type, flags | BindingFlags.Instance);
				StaticMembers = new GenMemberInfo(type, flags | BindingFlags.Static);
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

		public GenMemberInfo(Type type, BindingFlags bindingFlags)
		{
			var obsolete = typeof(ObsoleteAttribute);
			Ctors = type.GetConstructors(bindingFlags)
				.Where(ctor => !ctor.GetCustomAttributes(obsolete).Any())
				.OrderBy(ctor => ctor.GetParameters().Length);
			Fields = type.GetFields(bindingFlags).Where(field => !field.GetCustomAttributes(obsolete).Any()).OrderBy(field => field.Name);
			Properties = type.GetProperties(bindingFlags).Where(prop => !prop.GetCustomAttributes(obsolete).Any()).OrderBy(prop => prop.Name);
			Methods = type.GetMethods(bindingFlags).Where(method => !method.GetCustomAttributes(obsolete).Any()).OrderBy(method => method.Name);
			Events = type.GetEvents(bindingFlags).Where(evt => !evt.GetCustomAttributes(obsolete).Any()).OrderBy(evt => evt.Name);
			CtorGroups = GetMethodGroups(Ctors);
			MethodGroups = GetMethodGroups(Methods);
			HasMembers = Ctors.Any() || Events.Any() || Fields.Any() || Properties.Any() || Methods.Any();
			IsStatic = bindingFlags.HasFlag(BindingFlags.Static);
		}

		private IEnumerable<GenMethodGroup> GetMethodGroups(IEnumerable<MethodBase> methods)
		{
			var methodGroups = new Dictionary<String, GenMethodGroup>();
			foreach (var method in methods)
			{
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
		public IEnumerable<GenParamInfo> UniqueParams;
		public Int32 MinArgCount;
		//public Dictionary<Int32, List<GenMethodInfo>> MethodsByParamCount;
		public List<Dictionary<Type, List<GenMethodInfo>>> OverloadsBySignature;
		/* List = Position (index)
		 *	Dict = List of Methods with same parameter type at this position
		 */

		private List<MethodBase> AllOverloads;


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

			AllOverloads ??= new List<MethodBase>();
			AllOverloads.Add(method);
		}

		public void Postprocess()
		{
			if (AllOverloads == null)
				return;

			MinArgCount = Int32.MaxValue;
			AllOverloads.Sort((m1, m2) => m1.GetParameters().Length.CompareTo(m2.GetParameters().Length));
			OverloadsBySignature = new List<Dictionary<Type, List<GenMethodInfo>>>();

			//MethodsByParamCount = new Dictionary<Int32, List<GenMethodInfo>>();
			// var maxParamCount = AllOverloads.Last().GetParameters().Length;
			// for (var i = 0; i <= maxParamCount; i++)
			// 	MethodsByParamCount.Add(i, null);

			var uniqueParamsSet = new HashSet<GenParamInfo>();
			var overloadCount = AllOverloads.Count;

			for (var overloadIndex = 0; overloadIndex < overloadCount; overloadIndex++)
			{
				var overloadMinArgCount = 0;
				var overload = AllOverloads[overloadIndex];
				var parameters = overload.GetParameters();
				var paramCount = parameters.Length;

				var paramInfos = new GenParamInfo[paramCount];
				var methodInfo = new GenMethodInfo { MethodInfo = overload, ParamInfos = paramInfos };

				for (var pos = 0; pos < paramCount; pos++)
				{
					var parameter = parameters[pos];
					if (parameter.IsOptional == false)
						overloadMinArgCount++;

					var paramType = parameter.ParameterType;
					if (OverloadsBySignature.Count <= pos)
						OverloadsBySignature.Add(new Dictionary<Type, List<GenMethodInfo>>());
					if (OverloadsBySignature[pos].ContainsKey(paramType) == false)
						OverloadsBySignature[pos][paramType] = new List<GenMethodInfo>();

					if (pos == 0)
						OverloadsBySignature[pos][paramType].Add(methodInfo);
					else
					{
						var prevSignatures = OverloadsBySignature[pos - 1][parameters[pos - 1].ParameterType];
						if (prevSignatures.Count > 1 || prevSignatures[0] == methodInfo)
							OverloadsBySignature[pos][paramType].Add(methodInfo);
					}

					var paramInfo = new GenParamInfo { Name = parameter.Name, ParamInfo = parameter };
					paramInfos[pos] = paramInfo;
					uniqueParamsSet.Add(paramInfo);
				}

				//var methodInfo = new GenMethodInfo { MethodInfo = overload, ParamInfos = paramInfos };
				// MethodsByParamCount[paramCount] ??= new List<GenMethodInfo>();
				// MethodsByParamCount[paramCount].Add(methodInfo);

				if (MinArgCount > overloadMinArgCount)
					MinArgCount = overloadMinArgCount;
			}

			var maxParamCount = AllOverloads.Last().GetParameters().Length;
			for (int pos = 0; pos < maxParamCount; pos++)
			{
				var sig = OverloadsBySignature[pos];
				foreach (var kvp in sig)
				{
					foreach (var method in kvp.Value)
						Debug.Log($"[{pos}] {kvp.Key} = {method}");
				}
			}
			
			UniqueParams = uniqueParamsSet.OrderBy(p => p.Position);
			AllOverloads = null; // not needed anymore
		}

		public override Int32 GetHashCode() => Name != null ? Name.GetHashCode() : 0;
		public override Boolean Equals(Object obj) => obj is GenMethodGroup other && Equals(other);
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
			unchecked { return (MethodInfo != null ? MethodInfo.GetHashCode() : 0) * 397 ^ (ParamInfos != null ? ParamInfos.GetHashCode() : 0); }
		}

		public override String ToString()
		{
			var sb = new StringBuilder(MethodInfo.Name);
			foreach (var paramInfo in ParamInfos)
			{
				sb.Append(paramInfo.Type);
				sb.Append(" ");
				sb.Append(paramInfo.Name);
				sb.Append(", ");
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

		public static Boolean operator ==(GenParamInfo left, GenParamInfo right) => left.Equals(right);
		public static Boolean operator !=(GenParamInfo left, GenParamInfo right) => !left.Equals(right);
		public Boolean Equals(GenParamInfo other) => Name == other.Name && Equals(Type, other.Type);

		public override Int32 GetHashCode()
		{
			unchecked
			{
				var hashCode = Name != null ? Name.GetHashCode() : 0;
				hashCode = hashCode * 397 ^ (Type != null ? Type.GetHashCode() : 0);
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
