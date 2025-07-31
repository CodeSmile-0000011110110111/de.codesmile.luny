using Lua;
using System;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using Object = System.Object;

namespace CodeSmile.Luny
{
	public sealed class LuaNamespaces : Dictionary<String, LuaNamespace> {}

	public sealed class LuaNamespace : IEquatable<LuaNamespace>
	{
		public String Name { get; }
		public LuaTable Table { get; }

		public static Boolean operator ==(LuaNamespace left, LuaNamespace right) => Equals(left, right);
		public static Boolean operator !=(LuaNamespace left, LuaNamespace right) => !Equals(left, right);
		public LuaValue this[String ns]
		{
			get => Table[ns];
			set => Table[ns] = value;
		}

		// TODO: refactor to return LuaNamespace type
		[Obsolete]
		public static LuaTable GetOrCreate(LuaTable env, String namespaceName, String[] namespaceParts)
		{
			var current = env;
			if (namespaceParts != null && namespaceParts.Length > 0)
			{
				var namespaceCount = namespaceParts.Length;
				for (var i = 0; i < namespaceCount; i++)
				{
					var part = namespaceParts[i];
					if (current[part].TryRead(out LuaTable next) == false)
					{
						next = new LuaTable(0, 1);
						current[part] = next;
					}

					current = next;
				}
			}

			return current;
		}

		public LuaNamespace(String name)
		{
			Name = name;
			Table = new LuaTable(0, 0);
		}

		public Boolean Equals(LuaNamespace other)
		{
			if (other is null)
				return false;
			if (ReferenceEquals(this, other))
				return true;

			return Name == other.Name;
		}

		public override Boolean Equals(Object obj) => ReferenceEquals(this, obj) || obj is LuaNamespace other && Equals(other);

		public override Int32 GetHashCode() => Name.GetHashCode();
	}
}
