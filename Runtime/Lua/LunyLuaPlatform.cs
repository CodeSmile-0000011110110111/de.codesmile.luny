// Copyright (C) 2021-2025 Steffen Itterheim
// Refer to included LICENSE file for terms and conditions.

using Lua;
using Lua.IO;
using Lua.Platforms;
using System;
using System.IO;
using System.Threading;
using System.Threading.Tasks;
using UnityEditor;
using UnityEngine;

namespace CodeSmile.Luny
{
	internal sealed class LunyLuaPlatform : ILuaPlatform
	{
		public ILuaFileSystem FileSystem { get; }
		public ILuaOsEnvironment OsEnvironment { get; }
		public ILuaStandardIO StandardIO { get; }

		public LunyLuaPlatform(LunyLuaContext luaContext)
		{
			FileSystem = new LunyLuaFileSystem(luaContext);
			OsEnvironment = new LunyLuaOsEnvironment(luaContext);
			StandardIO = new LunyLuaStandardIO(luaContext);
		}
	}

	internal sealed class LunyLuaFileSystem : ILuaFileSystem
	{
		private readonly Boolean m_IsSandbox;
		private readonly LunyLuaContext m_LuaContext;
		private readonly ILuaFileSystem m_DefaultFileSystem = new FileSystem();

		public String DirectorySeparator => "/";

		public LunyLuaFileSystem(LunyLuaContext luaContext)
		{
			m_IsSandbox = luaContext.IsSandbox;
			m_LuaContext = luaContext;
		}

		public Boolean IsReadable(String path)
		{
			Debug.Log($"IsReadable: {path}");
			return m_IsSandbox ? !Path.IsPathRooted(path) : m_DefaultFileSystem.IsReadable(path);
		}

		public ILuaStream Open(String path, LuaFileMode mode)
		{
			Debug.Log($"Open: {path}, mode: {mode}");
				if (m_LuaContext.IsRuntimeContext)
				{
					var registry = LunyRuntimeAssetRegistry.Singleton;
					var script = registry.GetRuntimeScript(path);
					Debug.Log($"Returning stream with: {script}, {script?.text}");
					return new TextStream(script.text);
				}
				else if (m_LuaContext.IsEditorContext)
				{
					// var registry = LunyEditorLuaAsset.Singleton;
					// var script = registry.GetRuntimeScript(path);
					// Debug.Log($"Returning stream with: {script}, {script?.text}");
					// return new TextStream(script.text);
				}

			if (m_IsSandbox)
				return null;

			return m_DefaultFileSystem.Open(path, mode);
		}

		ILuaStream ILuaFileSystem.OpenTempFileStream() => m_DefaultFileSystem.OpenTempFileStream();

		public void Rename(String oldName, String newName)
		{
			if (!m_IsSandbox)
				m_DefaultFileSystem.Rename(oldName, newName);
			else
				LunyLogger.LogWarn($"Rename not allowed: {oldName}");
		}

		public void Remove(String path)
		{
			if (!m_IsSandbox)
				m_DefaultFileSystem.Remove(path);
			else
				LunyLogger.LogWarn($"Remove not allowed: {path}");
		}

		public String GetTempFileName() => m_DefaultFileSystem.GetTempFileName();

		public class TextStream : ILuaStream
		{
			private readonly LuaFileContent m_Text;
			public LuaFileMode Mode { get; }
			public TextStream(String text) => m_Text = new LuaFileContent(text);
			public ValueTask<LuaFileContent> ReadAllAsync(CancellationToken cancellationToken) => new(m_Text);
			public void Dispose() {}
		}
	}

	internal sealed class LunyLuaOsEnvironment : ILuaOsEnvironment
	{
		private readonly Boolean m_IsSandbox;
		private readonly ILuaOsEnvironment m_DefaultOsEnv = new SystemOsEnvironment();

		public LunyLuaOsEnvironment(LunyLuaContext luaContext) => m_IsSandbox = luaContext.IsSandbox;

		public String GetEnvironmentVariable(String name) => !m_IsSandbox ? m_DefaultOsEnv.GetEnvironmentVariable(name) : "";

		public ValueTask Exit(Int32 exitCode, CancellationToken cancellationToken)
		{
			if (!m_IsSandbox)
				Application.Quit(exitCode);

			return default;
		}

		public Double GetTotalProcessorTime() => Time.realtimeSinceStartupAsDouble;

		public DateTime GetCurrentUtcTime() => m_DefaultOsEnv.GetCurrentUtcTime();

		public TimeSpan GetLocalTimeZoneOffset() => m_DefaultOsEnv.GetLocalTimeZoneOffset();
	}

	public sealed class LunyLuaStandardIO : ILuaStandardIO
	{
		private readonly ILuaStandardIO m_DefaultStandardIO;
		private Boolean m_IsSandbox;

		// will use custom overrides since Debug.Log is not a stream
		public ILuaStream Input => m_DefaultStandardIO.Input;
		public ILuaStream Output => m_DefaultStandardIO.Output;
		public ILuaStream Error => m_DefaultStandardIO.Error;

		public LunyLuaStandardIO(LunyLuaContext luaContext)
		{
			m_IsSandbox = luaContext.IsSandbox;
			m_DefaultStandardIO = new ConsoleStandardIO();
		}
	}
}
