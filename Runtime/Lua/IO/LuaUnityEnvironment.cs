// Copyright (C) 2021-2025 Steffen Itterheim
// Refer to included LICENSE file for terms and conditions.

using Lua.Platforms;
using System;
using System.Threading;
using System.Threading.Tasks;
using UnityEditor;
using UnityEngine;

namespace Luny
{
	internal sealed class LuaUnityEnvironment : ILuaOsEnvironment
	{
		private readonly Boolean m_IsSandbox;
		private readonly ILuaOsEnvironment m_DefaultOsEnv = new SystemOsEnvironment();

		public LuaUnityEnvironment(LunyLuaContext luaContext) => m_IsSandbox = luaContext.IsSandbox;

		public String GetEnvironmentVariable(String name) => !m_IsSandbox ? m_DefaultOsEnv.GetEnvironmentVariable(name) : "";

		public ValueTask Exit(Int32 exitCode, CancellationToken cancellationToken)
		{
			if (!m_IsSandbox)
				Application.Quit(exitCode);

			return default;
		}

		public Double GetTotalProcessorTime() => Time.realtimeSinceStartupAsDouble;
	}
}
