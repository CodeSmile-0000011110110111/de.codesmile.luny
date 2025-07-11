﻿// Copyright (C) 2021-2025 Steffen Itterheim
// Refer to included LICENSE file for terms and conditions.

using Lua;
using System;
using UnityEditor;
using UnityEngine;

namespace CodeSmile.Luny
{
	[Serializable]
	public abstract class LunyLuaModuleLoader
	{
		public static LuaTable GetOrCreateNamespaceTable(LuaTable env, String[] namespaceParts)
		{
			var current = env;
			if (namespaceParts != null && namespaceParts.Length > 0)
			{
				var namespaceCount = namespaceParts.Length;
				for (var i = 0; i < namespaceCount; i++)
				{
					var name = namespaceParts[i];
					if (current[name].TryRead(out LuaTable next) == false)
					{
						next = new LuaTable(0, 1);
						current[name] = next;
					}

					current = next;
				}
			}

			return current;
		}

		public virtual void Load(LuaTable env) {}
	}
}
