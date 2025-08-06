// Copyright (C) 2021-2025 Steffen Itterheim
// Refer to included LICENSE file for terms and conditions.

using CodeSmileEditor.Luny.Generator;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using UnityEditor;
using UnityEngine;
using UnityEngine.Experimental.Rendering;
using UnityEngine.Rendering;
using Object = System.Object;

namespace LunyEditor.Generator
{
	internal sealed class GenTypeInfo
	{
		public readonly Type Type;
		public readonly String LuaInstanceTypeNamespace;
		public readonly String LuaInstanceTypeName;
		public readonly String LuaStaticTypeName;
		public readonly String LuaInstanceTypeFullName;
		public readonly String LuaStaticTypeFullName;
		public readonly String BindTypeFullName;
		public readonly Boolean IsStatic;
		public readonly Boolean IsSealed;
		public readonly Boolean IsUnityObjectType;
		public readonly Boolean IsUnityGameObjectType;
		public readonly Boolean IsUnityComponentType;
		public String InstanceFieldName;
		public String InstancePropertyName;
		public GenMemberInfo InstanceMembers;
		public GenMemberInfo StaticMembers;
		public Boolean HasInstanceType => IsStatic == false;
		public Boolean IsValueType => Type.IsValueType;

		public GenTypeInfo(Type type, IEnumerable<TreeNode<Type>> childTypes = null, String onlyThisMethodName = null)
		{
			Type = type;
			var typeFullName = type.FullName ?? type.Name;
			var typeFullNameNoPlus = typeFullName.Replace('+', '.');

			BindTypeFullName = $"global::{typeFullNameNoPlus}";
			LuaInstanceTypeNamespace = $"Luny.{Type.Namespace}";
			LuaInstanceTypeName = type.IsNested
				? type.DeclaringType.IsNested
					? $"Lua{type.DeclaringType.DeclaringType.Name}{type.DeclaringType.Name}{type.Name}"
					: $"Lua{type.DeclaringType.Name}{type.Name}"
				: $"Lua{type.Name}";
			LuaStaticTypeName = $"{LuaInstanceTypeName}Type";
			LuaInstanceTypeFullName = $"global::{LuaInstanceTypeNamespace}.{LuaInstanceTypeName}";
			LuaStaticTypeFullName = $"global::{LuaInstanceTypeNamespace}.{LuaStaticTypeName}";

			if (type.IsNested && type.DeclaringType.IsNested && type.DeclaringType.DeclaringType.IsNested)
			{
				throw new NotSupportedException(
					$"heavily nested types not supported: {type.DeclaringType.DeclaringType.FullName}.{type.DeclaringType.Name}.{type.Name}");
			}

			if (type.IsEnum == false)
			{
				IsStatic = type.IsAbstract && type.IsSealed;
				IsSealed = type.IsValueType == false && (IsStatic || type.IsSealed || childTypes?.Count() == 0);
				IsUnityObjectType = Type == typeof(UnityEngine.Object);
				IsUnityGameObjectType = Type == typeof(GameObject);
				IsUnityComponentType = Type.IsSubclassOf(typeof(Component)) || Type == typeof(Component);
				InstanceFieldName = type.IsValueType ? "m_Value" : "m_Instance";
				InstancePropertyName = type.IsValueType ? "Value" : "Instance";

				var flags = BindingFlags.Public | BindingFlags.DeclaredOnly;
				InstanceMembers = new GenMemberInfo(type, flags | BindingFlags.Instance, onlyThisMethodName);
				StaticMembers = new GenMemberInfo(type, flags | BindingFlags.Static, onlyThisMethodName);

				// Ctor wrappers must be generated in the static class type
				StaticMembers.Ctors = InstanceMembers.Ctors;
				StaticMembers.CtorOverloads = InstanceMembers.CtorOverloads;
				InstanceMembers.Ctors = new ConstructorInfo[0];
				InstanceMembers.CtorOverloads = new GenMethodOverloads[0];
			}
		}

		public override String ToString() => Type?.ToString() ?? GetType().Name;
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

		public GenMemberInfo(Type type, BindingFlags bindingFlags, String onlyThisMethodName)
		{
			var obsolete = typeof(ObsoleteAttribute);
			Ctors = type.GetConstructors(bindingFlags)
				.Where(c => !(type.IsAbstract || c.GetCustomAttributes(obsolete).Any()))
				.OrderBy(c => c.GetParameters().Length);
			Fields = type.GetFields(bindingFlags)
				.Where(f => !(f.FieldType.IsPointer ||
				              f.FieldType == typeof(IntPtr) ||
				              f.FieldType == typeof(UIntPtr) ||
				              f.FieldType.IsGenericType ||
				              f.FieldType.IsGenericParameter ||
				              f.GetCustomAttributes(obsolete).Any()))
				.OrderBy(f => f.Name);
			Properties = type.GetProperties(bindingFlags)
				.Where(p => !(p.PropertyType.IsPointer ||
				              p.PropertyType == typeof(IntPtr) ||
				              p.PropertyType == typeof(UIntPtr) ||
				              p.PropertyType.IsGenericType ||
				              p.PropertyType.IsGenericParameter ||
				              p.GetCustomAttributes(obsolete).Any()))
				.OrderBy(p => p.Name);
			Methods = type.GetMethods(bindingFlags)
				.Where(m => !(m.IsSpecialName || m.GetCustomAttributes(obsolete).Any()))
				.OrderBy(m => m.Name);
			Events = type.GetEvents(bindingFlags).Where(e => !e.GetCustomAttributes(obsolete).Any()).OrderBy(e => e.Name);
			CtorOverloads = GetMethodOverloads(Ctors, onlyThisMethodName);
			MethodOverloads = GetMethodOverloads(Methods, onlyThisMethodName);
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

		private static Boolean IsUnsupported(MethodBase method, ParameterInfo parameter, Boolean isReturnParam = false)
		{
			var paramType = parameter.ParameterType;

			if (paramType.IsArray)
				Debug.Log($"array param: {method.DeclaringType.Name}.{method}");

			if (paramType.IsArray)
				return Unsupported(method, parameter, "array param", false);
			if (paramType.IsByRef)
				return Unsupported(method, parameter, "byref param", false);
			if (paramType.IsGenericParameter)
				return Unsupported(method, parameter, "generic param", false);
			if (paramType.IsGenericType)
				return Unsupported(method, parameter, "generic type", false);
			if (paramType.IsInterface)
				return Unsupported(method, parameter, "interface param", false);
			if (paramType == typeof(IntPtr) || paramType == typeof(UIntPtr))
				return Unsupported(method, parameter, "IntPtr param", false);
			if (paramType.IsPointer)
				return Unsupported(method, parameter, "pointer param", false);
			if (method.IsGenericMethod)
				return Unsupported(method, parameter, "generic method", false);
			if (GenUtil.IsObsolete(paramType))
				return Unsupported(method, parameter, "obsolete param");

			return false;
		}

		private static Boolean Unsupported(MethodBase method, ParameterInfo parameter, String reason, Boolean log = true)
		{
			if (log)
			{
				GenUtil.Log($"Skip {reason}: {method.DeclaringType.FullName}::{method.Name}" +
				            $"({GenUtil.ToString(method.GetParameters())}) - unsupported: " +
				            $"'{parameter.ParameterType.Name} {parameter.Name}'");
			}
			return true;
		}

		public Boolean Equals(GenMethodOverloads other) => Equals(Name, other.Name);

		public override String ToString() => $"{Name}: {Count} overloads";

		public void AddOverload(MethodBase method)
		{
			if (method is MethodInfo methodInfo && IsUnsupported(method, methodInfo.ReturnParameter, true))
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
			// Note: may be superfluous, but docs state that prior to .NET 7 there is no guaranteed MethodInfo order for overloads
			m_Methods.Sort(new MethodBaseParameterComparer());

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

					// avoid duplicate signatures
					var shouldAdd = true;
					foreach (var methodInfo in allMethods.Where(m => m.ParamInfos.Length == optionalParamInfos.Length))
					{
						var matchingParams = methodInfo.ParamInfos.Where((p, i) => p.Type == optionalParamInfos[i].Type);
						if (matchingParams.Count() == optionalParamInfos.Length)
						{
							shouldAdd = false;
							break;
						}
					}

					if (shouldAdd)
						allMethods.Add(optionalParamMethod);
				}

				allMethods.Add(overloadInfo);
			}

			var signature = new List<GenParamInfo>();
			CreateSortedMethodsListRecursive(allMethods, 0, paramsByPosition, signature);

			m_Methods = null;
		}

		private void CreateSortedMethodsListRecursive(List<GenMethodInfo> methods, Int32 paramPos, List<HashSet<GenParamInfo>> paramsByPosition,
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
					CreateSortedMethodsListRecursive(methods, paramPos + 1, paramsByPosition, nextSignature);
				}
			}
		}

		public override Int32 GetHashCode() => Name != null ? Name.GetHashCode() : 0;
		public override Boolean Equals(Object obj) => obj is GenMethodOverloads other && Equals(other);

		public sealed class MethodBaseParameterComparer : IComparer<MethodBase>
		{
			public Int32 Compare(MethodBase m1, MethodBase m2)
			{
				var m1Params = m1.GetParameters();
				var m2Params = m2.GetParameters();
				var m1ParamCount = m1Params.Length;
				var m2ParamCount = m2Params.Length;

				var result = m1ParamCount.CompareTo(m2ParamCount);
				if (result != 0 || m1ParamCount == 0)
					return result;

				// same param count, sort by prioritizing certain types
				for (var i = 0; i < m1ParamCount; i++)
				{
					var m1ParamType = m1Params[i].ParameterType;
					var m2ParamType = m2Params[i].ParameterType;

					// same type? try the next
					if (m1ParamType == m2ParamType)
						continue;

					// primitives take precedence over everything
					if (m1ParamType.IsPrimitive && m2ParamType.IsPrimitive)
					{
						// order of primitives, prefer most "wide" types
						if (m1ParamType == typeof(Single))
							return -1; // prefer float since Lua number is double & Unity fractionals are 99% float
						if (m2ParamType == typeof(Single)) return 1;
						if (m1ParamType == typeof(Double)) return -1;
						if (m2ParamType == typeof(Double)) return 1;
						if (m1ParamType == typeof(Int64)) return -1;
						if (m2ParamType == typeof(Int64)) return 1;
						if (m1ParamType == typeof(UInt64)) return -1;
						if (m2ParamType == typeof(UInt64)) return 1;
						if (m1ParamType == typeof(Int32)) return -1;
						if (m2ParamType == typeof(Int32)) return 1;
						if (m1ParamType == typeof(UInt32)) return -1;
						if (m2ParamType == typeof(UInt32)) return 1;
						if (m1ParamType == typeof(Boolean)) return -1; // Bool is a 32-bit type
						if (m2ParamType == typeof(Boolean)) return 1;
						if (m1ParamType == typeof(Char)) return -1; // Char is a 16-bit type
						if (m2ParamType == typeof(Char)) return 1;
						if (m1ParamType == typeof(Int16)) return -1;
						if (m2ParamType == typeof(Int16)) return 1;
						if (m1ParamType == typeof(UInt16)) return -1;
						if (m2ParamType == typeof(UInt16)) return 1;
						if (m1ParamType == typeof(SByte)) return -1;
						if (m2ParamType == typeof(SByte)) return 1;
						if (m1ParamType == typeof(Byte)) return -1;
						if (m2ParamType == typeof(Byte)) return 1;
						if (m1ParamType == typeof(Decimal)) return -1; // Decimal at the bottom because games don't really use these
						if (m2ParamType == typeof(Decimal)) return 1;
						if (m1ParamType == typeof(IntPtr)) return -1; // Ptr types will get sorted out anyway
						if (m2ParamType == typeof(IntPtr)) return 1;
						if (m1ParamType == typeof(UIntPtr)) return -1;
						if (m2ParamType == typeof(UIntPtr)) return 1;
					}
					else if (m1ParamType.IsPrimitive) return -1;
					else if (m2ParamType.IsPrimitive) return 1;

					// value types (incl. enums) take precedence over reference types
					if (m1ParamType.IsValueType && m2ParamType.IsValueType)
					{
						if (m1ParamType.IsEnum && !m2ParamType.IsEnum) return -1;
						if (!m1ParamType.IsEnum && m2ParamType.IsEnum) return 1;

						if (m1ParamType == typeof(Vector2)) return -1;
						if (m2ParamType == typeof(Vector2)) return 1;
						if (m1ParamType == typeof(Vector2Int)) return -1;
						if (m2ParamType == typeof(Vector2Int)) return 1;
						if (m1ParamType == typeof(Vector3)) return -1;
						if (m2ParamType == typeof(Vector3)) return 1;
						if (m1ParamType == typeof(Vector3Int)) return -1;
						if (m2ParamType == typeof(Vector3Int)) return 1;
						if (m1ParamType == typeof(Vector4)) return -1;
						if (m2ParamType == typeof(Vector4)) return 1;

						if (m1ParamType == typeof(GraphicsFormat)) return -1;
						if (m2ParamType == typeof(GraphicsFormat)) return 1;
						if (m1ParamType == typeof(TextureFormat)) return -1;
						if (m2ParamType == typeof(TextureFormat)) return 1;
						if (m1ParamType == typeof(RenderTextureFormat)) return -1;
						if (m2ParamType == typeof(RenderTextureFormat)) return 1;
						if (m1ParamType == typeof(DefaultFormat)) return -1;
						if (m2ParamType == typeof(DefaultFormat)) return 1;
						if (m1ParamType == typeof(LocalKeyword)) return -1;
						if (m2ParamType == typeof(LocalKeyword)) return 1;
						if (m1ParamType == typeof(GlobalKeyword)) return -1;
						if (m2ParamType == typeof(GlobalKeyword)) return 1;
						if (m1ParamType == typeof(ShaderKeyword)) return -1;
						if (m2ParamType == typeof(ShaderKeyword)) return 1;
						if (m1ParamType == typeof(RenderBuffer)) return -1;
						if (m2ParamType == typeof(RenderBuffer)) return 1;
						if (m1ParamType == typeof(RenderTargetIdentifier)) return -1;
						if (m2ParamType == typeof(RenderTargetIdentifier)) return 1;
						if (m1ParamType == typeof(SynchronisationStageFlags)) return -1;
						if (m2ParamType == typeof(SynchronisationStageFlags)) return 1;
						if (m1ParamType == typeof(SynchronisationStage)) return -1;
						if (m2ParamType == typeof(SynchronisationStage)) return 1;
					}
					else if (m1ParamType.IsValueType) return -1;
					else if (m2ParamType.IsValueType) return 1;

					// System.Object goes last
					if (m1ParamType == typeof(Object)) return 1;
					if (m2ParamType == typeof(Object)) return -1;

					// delegate goes 2nd to last
					if (m1ParamType == typeof(Delegate)) return 1;
					if (m2ParamType == typeof(Delegate)) return -1;

					// strings take precedence
					if (m1ParamType == typeof(String)) return -1;
					if (m2ParamType == typeof(String)) return 1;

					if (m1ParamType == typeof(Texture2D)) return -1;
					if (m2ParamType == typeof(Texture2D)) return 1;
					if (m1ParamType == typeof(Texture3D)) return -1;
					if (m2ParamType == typeof(Texture3D)) return 1;
					if (m1ParamType == typeof(Texture2DArray)) return -1;
					if (m2ParamType == typeof(Texture2DArray)) return 1;
					if (m1ParamType == typeof(RenderTexture)) return -1;
					if (m2ParamType == typeof(RenderTexture)) return 1;
					if (m1ParamType == typeof(GraphicsTexture)) return -1;
					if (m2ParamType == typeof(GraphicsTexture)) return 1;
					if (m1ParamType == typeof(Texture)) return -1;
					if (m2ParamType == typeof(Texture)) return 1;
					if (m1ParamType == typeof(Material)) return -1;
					if (m2ParamType == typeof(Material)) return 1;
					if (m1ParamType == typeof(Shader)) return -1;
					if (m2ParamType == typeof(Shader)) return 1;
					if (m1ParamType == typeof(ComputeShader)) return -1;
					if (m2ParamType == typeof(ComputeShader)) return 1;
					if (m1ParamType == typeof(ComputeBuffer)) return -1;
					if (m2ParamType == typeof(ComputeBuffer)) return 1;
					if (m1ParamType == typeof(GraphicsBuffer)) return -1;
					if (m2ParamType == typeof(GraphicsBuffer)) return 1;
					if (m1ParamType == typeof(Cubemap)) return -1;
					if (m2ParamType == typeof(Cubemap)) return 1;

					// and the remaining types prefer inherited types over their base types
					if (m1ParamType.IsAssignableFrom(m2ParamType)) return 1;
					if (m2ParamType.IsAssignableFrom(m1ParamType)) return -1;
				}

				Debug.LogWarning($"undecided sort order: {m1} <==> {m2}\n\n{m1}\n{m2}\n");
				return 0;
			}
		}
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
			sb.Append("(");

			for (var i = 0; i < ParamInfos.Length; i++)
			{
				var paramInfo = ParamInfos[i];
				if (i > 0)
					sb.Append(", ");
				sb.Append(paramInfo.Type.FullName);
				sb.Append(" ");
				sb.Append(paramInfo.Name);
			}

			sb.Append(")");

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
		private String m_TypeFullName;

		public ParameterInfo ParamInfo;
		public String Name { get; set; }
		public Type Type => ParamInfo?.ParameterType;
		public String TypeFullName => m_TypeFullName ??= $"global::{ParamInfo.ParameterType.FullName?.Replace('+', '.')}";
		public Int32 Position => ParamInfo.Position;
		public Boolean IsGeneratedType { get; set; }
		public string GeneratedTypeFullName { get; set; }
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
}
