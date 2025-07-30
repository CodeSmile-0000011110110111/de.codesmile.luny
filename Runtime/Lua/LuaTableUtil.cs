using Lua;
using System;

namespace CodeSmile.Luny
{
	public static class LuaTableUtil
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
	}
}