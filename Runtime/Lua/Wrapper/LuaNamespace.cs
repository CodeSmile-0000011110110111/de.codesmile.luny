using Lua;
using Lua.Runtime;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UnityEditor;
using UnityEngine;
using UnityEngine.Scripting;
using Object = System.Object;

namespace CodeSmile.Luny
{
	public interface ILuaNamespaces
	{
		IEnumerable<LuaNamespace> Values { get; }

		Boolean TryGetLuaType(String typeName, out LuaValue luaType);
		//void MoveToBack(LuaTable usings);
	}

	public sealed class LuaNamespaces : ILuaNamespaces
	{
		private readonly Dictionary<String, LuaNamespace> m_NamespacesByName = new();
		private readonly Dictionary<String, List<LuaNamespace>> m_NamespacesByTypeName = new();
		//private readonly List<LuaNamespace> m_OrderedNamespaces = new();

		public IEnumerable<LuaNamespace> Values => m_NamespacesByName.Values;
		public LuaNamespace this[String namespaceName] => m_NamespacesByName[namespaceName];

		/// <summary>
		/// Find the type by its name.
		/// </summary>
		/// <param name="typeName"></param>
		/// <param name="luaType"></param>
		/// <returns>LuaValue with a ILuaObjectType instance.</returns>
		public Boolean TryGetLuaType(String typeName, out LuaValue luaType)
		{
			if (m_NamespacesByTypeName.TryGetValue(typeName, out var namespacesWithType))
			{
				Debug.Assert(namespacesWithType.Count == 1, $"ambiguous type: {typeName} in {namespacesWithType.Count} namespaces");

				var usingNamespace = namespacesWithType.FirstOrDefault();
				if (usingNamespace != null)
				{
					luaType = usingNamespace.Types[typeName];
					return true;
				}
			}

			luaType = LuaValue.Nil;
			return false;
		}

		/*
		public void MoveToBack(LuaTable usings)
		{
			var validUsingsInReverseOrder = new List<LuaNamespace>();

				for (var i = usings.ArrayLength; i >= 0; i--) // Lua arrays are 1-based!
				{
					if (usings[i].TryRead(out LuaNamespace ns) && m_Namespaces.ContainsKey(ns.Name))
					{
						validUsingsInReverseOrder.Add(ns);
						m_OrderedNamespaces.Remove(ns);
					}
				}

				foreach (var ns in validUsingsInReverseOrder)
					m_OrderedNamespaces.Add(ns);
		}
		*/
		// [MethodImpl(MethodImplOptions.AggressiveInlining)]
		// private Boolean TryGet(LuaValue value, out LuaNamespace luaNamespace)
		// {
		// 	if (value.TryRead(out String namespaceName))
		// 		return TryGet(namespaceName, out luaNamespace);
		//
		// 	luaNamespace = null;
		// 	return false;
		// }
		//
		// [MethodImpl(MethodImplOptions.AggressiveInlining)]
		// private Boolean TryGet(String namespaceName, out LuaNamespace luaNamespace) => (luaNamespace = m_Namespaces[namespaceName]) != null;

		internal Boolean ContainsNamespace(String namespaceName) => m_NamespacesByName.ContainsKey(namespaceName);

		internal void Add(String namespaceName, LuaNamespace luaNamespace) => m_NamespacesByName.Add(namespaceName, luaNamespace);

		internal void AddTypeName(LuaNamespace luaNamespace, String typeName)
		{
			if (m_NamespacesByTypeName.TryGetValue(typeName, out var namespacesWithType))
				namespacesWithType.Add(luaNamespace);
			else
				m_NamespacesByTypeName.Add(typeName, new List<LuaNamespace> { luaNamespace });
		}
	}

	public interface ILuaNamespace {}

	public sealed class LuaNamespace : IEquatable<LuaNamespace>, ILuaNamespace, ILuaUserData
	{
		private static LuaTable s_MetaTable;
		[Preserve] internal static LuaFunction __index = new(Metamethods.Index, (context, _) =>
		{
			var ns = context.GetArgument<LuaNamespace>(0);
			var key = context.GetArgument<String>(1);
			ns.Types.TryGetValue(key, out var value);
			return new ValueTask<Int32>(context.Return(value));
		});

		public String Name { get; }
		public LuaTable Types { get; }

		public static implicit operator LuaValue(LuaNamespace ns) => new(ns);
		public static Boolean operator ==(LuaNamespace left, LuaNamespace right) => Equals(left, right);
		public static Boolean operator !=(LuaNamespace left, LuaNamespace right) => !Equals(left, right);
		public LuaValue this[String ns] { get => Types[ns]; set => Types[ns] = value; }
		public LuaTable Metatable { get => s_MetaTable ??= LuaMetatable.Create(__index); set => throw new NotImplementedException(); }

		// TODO: keeping this in case I need to revert back to hierarchical namespace tables
		/*[Obsolete] public static LuaTable GetOrCreate(LuaTable env, String namespaceName, String[] namespaceParts)
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
		}*/

		public LuaNamespace(String name)
		{
			Name = name;
			Types = new LuaTable(0, 0);
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
