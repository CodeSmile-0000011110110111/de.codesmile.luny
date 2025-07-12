// Copyright (C) 2021-2025 Steffen Itterheim
// Refer to included LICENSE file for terms and conditions.

using System;
using System.Collections.Generic;
using System.Reflection;
using UnityEditor;
using UnityEngine;
using Object = System.Object;

namespace CodeSmileEditor.Luny.Generator
{
	internal struct MethodGroup : IEquatable<MethodGroup>
	{
		public String Name;
		public List<MethodInfo> Overloads;

		public Boolean Equals(MethodGroup other) => Equals(Name, other.Name);

		public override Boolean Equals(Object obj) => obj is MethodGroup other && Equals(other);

		public override Int32 GetHashCode() => Name != null ? Name.GetHashCode() : 0;

		public static Boolean operator ==(MethodGroup left, MethodGroup right) => left.Equals(right);
		public static Boolean operator !=(MethodGroup left, MethodGroup right) => !left.Equals(right);
	}
}
