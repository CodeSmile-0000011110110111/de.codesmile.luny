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
	internal struct MemberGroup : IEquatable<MemberGroup>
	{
		public String Name;
		public List<MemberInfo> Overloads;

		public Boolean Equals(MemberGroup other) => Equals(Name, other.Name);

		public override Boolean Equals(Object obj) => obj is MemberGroup other && Equals(other);

		public override Int32 GetHashCode() => Name != null ? Name.GetHashCode() : 0;

		public static Boolean operator ==(MemberGroup left, MemberGroup right) => left.Equals(right);
		public static Boolean operator !=(MemberGroup left, MemberGroup right) => !left.Equals(right);
	}
}
