// Copyright (C) 2021-2025 Steffen Itterheim
// Refer to included LICENSE file for terms and conditions.

using Lua.IO;
using UnityEditor;
using UnityEngine;

namespace Luny
{
	public sealed class LuaUnityIO : ILuaStandardIO
	{
		private readonly ILuaStandardIO m_DefaultStandardIO;

		// will use custom overrides since Debug.Log is not a stream
		public ILuaStream Input => m_DefaultStandardIO.Input;
		public ILuaStream Output => m_DefaultStandardIO.Output;
		public ILuaStream Error => m_DefaultStandardIO.Error;

		public LuaUnityIO(LunyLuaContext luaContext) => m_DefaultStandardIO = new ConsoleStandardIO();
	}
}
