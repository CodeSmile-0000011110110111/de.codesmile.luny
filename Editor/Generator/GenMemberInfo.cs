// Copyright (C) 2021-2025 Steffen Itterheim
// Refer to included LICENSE file for terms and conditions.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using UnityEditor;
using UnityEngine;

namespace CodeSmileEditor.Luny.Generator
{
	internal class GenMemberInfo
	{
		public IEnumerable<ConstructorInfo> Ctors;
		public IEnumerable<FieldInfo> Fields;
		public IEnumerable<PropertyInfo> Properties;
		public IEnumerable<MethodInfo> Methods;
		public IEnumerable<EventInfo> Events;
		public Boolean HasMembers;

		public GenMemberInfo(Type type, BindingFlags bindingFlags)
		{
			var obsolete = typeof(ObsoleteAttribute);
			Ctors = type.GetConstructors(bindingFlags).Where(ctor => !CustomAttributeExtensions.GetCustomAttributes((MemberInfo)ctor, obsolete).Any());
			Fields = type.GetFields(bindingFlags).Where(ctor => !ctor.GetCustomAttributes(obsolete).Any());
			Properties = type.GetProperties(bindingFlags).Where(ctor => !ctor.GetCustomAttributes(obsolete).Any());
			Methods = type.GetMethods(bindingFlags).Where(ctor => !ctor.GetCustomAttributes(obsolete).Any());
			Events = type.GetEvents(bindingFlags).Where(ctor => !ctor.GetCustomAttributes(obsolete).Any());
			HasMembers = Ctors.Any() || Events.Any() || Fields.Any() || Properties.Any() || Methods.Any();
		}
	}
}
