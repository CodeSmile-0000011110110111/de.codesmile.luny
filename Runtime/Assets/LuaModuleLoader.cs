﻿// Copyright (C) 2021-2025 Steffen Itterheim
// Refer to included LICENSE file for terms and conditions.

using Lua;
using System;
using UnityEditor;
using UnityEngine;

namespace CodeSmile.Luny
{
	[Serializable]
	public abstract class LuaModuleLoader
	{
		public virtual void Load(LuaTable env) {}

		public static LuaTable GetOrCreateNamespaceTable(LuaTable env, String[] namespaceNames)
		{
			LuaTable current = env;
			if (namespaceNames != null && namespaceNames.Length > 0)
			{
				var namespaceCount = namespaceNames.Length;
				for (int i = 0; i < namespaceCount; i++)
				{
					var name = namespaceNames[i];
					if (current[name].TryRead(out LuaTable next) == false)
					{
						next = new LuaTable();
						current[name] = next;
					}

					current = next;
				}
			}

			return current;
		}
	}
}
