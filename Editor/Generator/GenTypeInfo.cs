// Copyright (C) 2021-2025 Steffen Itterheim
// Refer to included LICENSE file for terms and conditions.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using UnityEditor;
using UnityEngine;
using Object = System.Object;

namespace CodeSmileEditor.Luny.Generator
{
	internal class GenTypeInfo
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

	internal class GenMemberInfo
	{
		public IEnumerable<ConstructorInfo> Ctors;
		public IEnumerable<FieldInfo> Fields;
		public IEnumerable<PropertyInfo> Properties;
		public IEnumerable<MethodInfo> Methods;
		public IEnumerable<EventInfo> Events;
		public IEnumerable<GenMethodGroup> CtorGroups;
		public IEnumerable<GenMethodGroup> MethodGroups;
		public Boolean HasMembers;

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
		}

		private IEnumerable<GenMethodGroup> GetMethodGroups(IEnumerable<MethodBase> methods)
		{
			var methodGroups = new HashSet<GenMethodGroup>();
			foreach (var method in methods)
			{
				var group = new GenMethodGroup { Name = method.Name };
				if (methodGroups.TryGetValue(group, out var existingGroup))
				{
					existingGroup.AddOverload(method);
					continue;
				}

				group.AddOverload(method);
				methodGroups.Add(group);
			}
			return methodGroups.OrderBy(group => group.Name);
		}
	}

	internal struct GenMethodGroup : IEquatable<GenMethodGroup>
	{
		public String Name;
		public IEnumerable<MethodBase> Overloads;
		public IEnumerable<GenParamInfo> Params;

		public void AddOverload(MethodBase method)
		{
			var overloads = (List<MethodBase>)Overloads ?? new List<MethodBase>();
			overloads.Add(method);
			Overloads = overloads;

			var parameters = (HashSet<GenParamInfo>)Params ?? new HashSet<GenParamInfo>();
			foreach (var parameter in method.GetParameters())
				parameters.Add(new GenParamInfo { ParamInfo = parameter });
			Params = parameters.OrderBy(p => p.Position);
		}

		public override Int32 GetHashCode() => Name != null ? Name.GetHashCode() : 0;
		public Boolean Equals(GenMethodGroup other) => Equals(Name, other.Name);
		public override Boolean Equals(Object obj) => obj is GenMethodGroup other && Equals(other);
		public static Boolean operator ==(GenMethodGroup left, GenMethodGroup right) => left.Equals(right);
		public static Boolean operator !=(GenMethodGroup left, GenMethodGroup right) => !left.Equals(right);
	}

	internal struct GenParamInfo : IEquatable<GenParamInfo>
	{
		public ParameterInfo ParamInfo;
		public String Name => ParamInfo.Name;
		public Type Type => ParamInfo.ParameterType;
		public Int32 Position => ParamInfo.Position;

		public override Int32 GetHashCode()
		{
			unchecked
			{
				var hashCode = Name != null ? Name.GetHashCode() : 0;
				hashCode = hashCode * 397 ^ (Type != null ? Type.GetHashCode() : 0);
				hashCode = hashCode * 397 ^ Position;
				return hashCode;
			}
		}

		public Boolean Equals(GenParamInfo other) => Name == other.Name && Equals(Type, other.Type) && Position == other.Position;
		public override Boolean Equals(Object obj) => obj is GenParamInfo other && Equals(other);
		public static Boolean operator ==(GenParamInfo left, GenParamInfo right) => left.Equals(right);
		public static Boolean operator !=(GenParamInfo left, GenParamInfo right) => !left.Equals(right);
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
