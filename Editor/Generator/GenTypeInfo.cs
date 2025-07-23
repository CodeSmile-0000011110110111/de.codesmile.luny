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
		public IEnumerable<GenMethodOverloads> CtorOverloads;
		public IEnumerable<GenMethodOverloads> MethodOverloads;
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
				if (onlyThisMethodName != null && onlyThisMethodName != method.Name)
					continue;

				Debug.Log($"{method.DeclaringType.FullName}: Add {method.Name} with {method.GetParameters().Length} parameters.");
				if (methodOverloads.TryGetValue(method.Name, out var existingOverloads))
					existingOverloads.AddOverload(method);
				else
				{
					var overload = new GenMethodOverloads { Name = method.Name, MinParamCount = Int32.MaxValue };
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
		public String Name;
		public Int32 MinParamCount;
		public Int32 MaxParamCount;
		public List<MethodBase> Methods = new();
		public List<SortedDictionary<GenParamInfo, List<GenMethodInfo>>> OLD_OverloadsByParamType;
		/* List = Position (index)
		 *	Dict = List of Methods with same parameter type at this position
		 */

		// sorted by min param count (not counting trailing optional params), then by total param count (incl. optional)
		// List => param count (NOT: position!) - Note: can have empty lists at any position
		// inner List => methods that required this number of parameters (not counting trailing optional params!)
		public List<List<GenMethodInfo>> MethodsByRequiredParamCount;
		// methods sorted by param position, keyed by param type
		// List => param position
		// inner Dictionary => key = param type, value = methods with that type at that position
		private List<Dictionary<Type, List<GenMethodInfo>>> MethodsByParamType;

		// algo:
		// TODO: solve the tree nodes coming back together
		//		fill a list of param types (signature) we're currently enumerating, only recurse if method param types match thus far
		// for every parameter position
		//		for every parameter type at that position
		//			read param with type
		//			if current method has more required params => recurse into
		//			else generate method call
		//				Note: generate multiple method calls for each trailing optional param is expected

		public static Boolean operator ==(GenMethodOverloads left, GenMethodOverloads right) => left.Equals(right);
		public static Boolean operator !=(GenMethodOverloads left, GenMethodOverloads right) => !left.Equals(right);
		public Boolean Equals(GenMethodOverloads other) => Equals(Name, other.Name);

		public void AddOverload(MethodBase method)
		{
			var parameters = method.GetParameters();
			foreach (var parameter in parameters)
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

			Methods.Add(method);
		}

		public void Postprocess()
		{
			// sort by total parameter count first (this becomes the secondary sort order)
			// Note: may be superfluous, but docs state that prior to .NET 7 there is no guaranteed method order
			Methods.Sort((m1, m2) => m1.GetParameters().Length.CompareTo(m2.GetParameters().Length));
			MethodsByRequiredParamCount = new List<List<GenMethodInfo>>();
			MethodsByParamType = new List<Dictionary<Type, List<GenMethodInfo>>>();
			MinParamCount = Int32.MaxValue;
			MaxParamCount = 0;

			foreach (var overloadInfo in Methods)
			{
				var overloadParams = overloadInfo.GetParameters();
				var overloadParamCount = overloadParams.Length;
				var overloadMinParamCount = overloadParamCount;

				// reverse enumerate parameters to find min number of required parameters
				for (var i = overloadParamCount - 1; i >= 0; i--)
				{
					if (overloadParams[i].IsOptional == false)
						break;

					overloadMinParamCount--;
				}

				// update Min/Max param counts across all overloads
				if (MinParamCount > overloadMinParamCount)
					MinParamCount = overloadMinParamCount;
				if (MaxParamCount < overloadParamCount)
					MaxParamCount = overloadParamCount;

				// grow collections depending on parameter count
				while (MethodsByRequiredParamCount.Count <= overloadParamCount)
				{
					// Caution: index 0 is for parameterless method, it's not the parameter position
					MethodsByRequiredParamCount.Add(new List<GenMethodInfo>());
				}
				while (MethodsByParamType.Count <= overloadParamCount - 1)
				{
					MethodsByParamType.Add(new Dictionary<Type, List<GenMethodInfo>>());
				}

				// generate parameter infos
				var paramInfos = new GenParamInfo[overloadParamCount];
				var methodInfo = new GenMethodInfo
					{ MethodInfo = overloadInfo, ParamInfos = paramInfos, MinParamCount = overloadMinParamCount };
				for (var pos = 0; pos < overloadParamCount; pos++)
				{
					var parameter = overloadParams[pos];
					var paramType = parameter.ParameterType;
					// remove [] from array parameters names:
					var paramName = paramType.IsArray ? paramType.Name.Substring(0, paramType.Name.Length - 2) : paramType.Name;
					var bindVarName = $"_p{pos}_{paramName}";
					var paramInfo = new GenParamInfo
					{
						Name = parameter.Name,
						ParamInfo = parameter,
						VariableName = bindVarName,
						MethodInfo = methodInfo,
					};
					paramInfos[pos] = paramInfo;

					if (MethodsByParamType[pos].ContainsKey(paramType) == false)
						MethodsByParamType[pos].Add(paramType, new List<GenMethodInfo>());
					MethodsByParamType[pos][paramType].Add(methodInfo);
				}

				MethodsByRequiredParamCount[overloadMinParamCount].Add(methodInfo);
			}

			// sort by min param count first, total param count second
			// overloads with trailing optional parameters are sorted to the front (towards index 0)
			foreach (var methods in MethodsByRequiredParamCount)
			{
				methods.Sort((m1, m2) =>
				{
					var result = m1.MinParamCount.CompareTo(m2.MinParamCount);
					if (result == 0)
						result = m1.ParamCount.CompareTo(m2.ParamCount);
					return result;
				});
			}

			{
				OLD_OverloadsByParamType = new List<SortedDictionary<GenParamInfo, List<GenMethodInfo>>>();

				//var uniqueParamsSet = new HashSet<GenParamInfo>();
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
							MethodInfo = methodInfo,
						};
						paramInfos[pos] = paramInfo;
						//uniqueParamsSet.Add(paramInfo);
					}

					if (MinParamCount > overloadMinArgCount)
						MinParamCount = overloadMinArgCount;
					if (MaxParamCount < paramCount)
						MaxParamCount = paramCount;
				}
			}

			/*var methodHierarchy = new TreeNode<GenParamInfo>(new GenParamInfo(){Name = "()", VariableName = "/* none #1#"});
			var prevNodeChildren = methodHierarchy.Children;

			for (var pos = 0; pos < methodsByParamPosition.Count; pos++)
			{
				var methodsByParamPos = methodsByParamPosition[pos];
				foreach (var method in methodsByParamPos)
				{
					var parameter = method.ParamInfos[pos];

					/*
					if (pos == 0)
					{
						methodHierarchy.AddChild(parameter);
						continue;
					}

					methodHierarchy.VisitDepthFirst((node, level) =>
					{
						Debug.Log($"Visit node at level {level} (pos {pos}): {node.Value} => {node.Value.MethodInfo}");

						// tree level starts at 0 for "parameterless"
						var nodePos = level - 1;
						if (nodePos == pos && node.Value == parameter)
						{
							var prevPos = pos - 1;
							var parent = node;
							do
							{
								parent = parent.Parent;
								Debug.Log($"prev parent: {parent.Value}, param match: {parent?.Value == method.ParamInfos[prevPos]}");
							} while (parent != null && parent.Value == method.ParamInfos[prevPos]);

							Debug.Log($"parent is: {parent} {parent?.Value}");
						}


						// var nodeParamType = node.Value.ParamInfos[level].Type;
						// var paramAtLevel = method.ParamInfos[level];
						//if (nodeParamType == paramAtLevel)
					});
					#1#





					if (OverloadsByParamType.Count <= pos)
						OverloadsByParamType.Add(new SortedDictionary<GenParamInfo, List<GenMethodInfo>>(new ParameterComparer()));

					if (pos == 0)
					{
						if (OverloadsByParamType[pos].ContainsKey(parameter) == false)
							OverloadsByParamType[pos][parameter] = new List<GenMethodInfo>();

						OverloadsByParamType[pos][parameter].Add(method);
						continue;
					}

					// check if the method exists in the previous methods list for its previous parameter type
					var prevPos = pos - 1;
					var prevParameter = method.ParamInfos[prevPos];
					var prevMethodsByParamType = OverloadsByParamType[prevPos];
					if (prevMethodsByParamType.TryGetValue(prevParameter, out var prevMethods) && prevMethods.Contains(method))
					{
						// only add method if we haven't already narrowed down that part of the hierarchy to a single one
						if (prevMethods.Count > 1)
						{
							//Debug.Log($"{pos}: {parameter.Type.Name} {parameter.Name} (prev: {prevParameter.Name}) => {method}");
							if (OverloadsByParamType[pos].ContainsKey(parameter) == false)
								OverloadsByParamType[pos][parameter] = new List<GenMethodInfo>();

							OverloadsByParamType[pos][parameter].Add(method);
						}
					}
				}
			}

			methodHierarchy.VisitDepthFirst((node, level) =>
			{
				Debug.Log($"[{level}]: {node.Value} => {node.Value.MethodInfo}");
			});*/

			Debug.Log("");
		}

		public override Int32 GetHashCode() => Name != null ? Name.GetHashCode() : 0;
		public override Boolean Equals(Object obj) => obj is GenMethodOverloads other && Equals(other);
	}

	/*
	internal sealed class OverloadsNode : TreeNode<GenParamInfo>
	{
		List<GenMethodInfo> m_Methods = new List<GenMethodInfo>();
		public IEnumerable<GenMethodInfo> Methods => m_Methods;

		public IEnumerable<GenParamInfo> GetOverloadsSortedByParamCount()
		{
			// get the children
			foreach (var child in Children)
			{
				var methods = (child as OverloadsNode).Methods;
			}
			// sort them


			return null;
		}

		public OverloadsNode(GenParamInfo value, GenMethodInfo overload)
			: base(value)
		{
			m_Methods.Add(overload);
		}
	}
	*/

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
		public Int32 MinParamCount;
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
		public Type Type => ParamInfo?.ParameterType;
		public String TypeFullName => ParamInfo.ParameterType.FullName.Replace('+', '.');
		public Int32 Position => ParamInfo.Position;
		public Boolean IsUserData => !(Type.IsPrimitive || Type == typeof(String));
		public String VariableName { get; set; }
		public GenMethodInfo MethodInfo { get; set; }

		public static Boolean operator ==(GenParamInfo left, GenParamInfo right) =>
			left is null && right is null || left is not null && left.Equals(right);

		public static Boolean operator !=(GenParamInfo left, GenParamInfo right) =>
			left is null && right is not null || left is not null && !left.Equals(right);

		public Boolean Equals(GenParamInfo other) => other is not null /*&& Name == other.Name*/ && Equals(Type, other.Type);

		public override String ToString() => $"{Type?.Name} {Name}";

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
