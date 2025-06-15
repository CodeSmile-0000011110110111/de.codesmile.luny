// Copyright (C) 2021-2025 Steffen Itterheim
// Refer to included LICENSE file for terms and conditions.

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
	public interface ILunyLuaFileSystem
	{
		Boolean ReadText(String path, out String content);
		Boolean ReadBytes(String path, out Byte[] bytes);
		string TryGetAssetPath(string pathOrChunkName);
	}

	internal sealed class LunyLuaFileSystem : ILuaFileSystem
	{
		private readonly ILuaFileSystem m_DefaultFileSystem = new FileSystem();
		private readonly ILunyLuaFileSystem m_FileSystemHook;
		private readonly Boolean m_IsSandbox;
		public ILunyLuaFileSystem Hook => m_FileSystemHook;

		public String DirectorySeparator => "/";

		public LunyLuaFileSystem(LunyLuaContext luaContext, ILunyLuaFileSystem fileSystemHook)
		{
			m_FileSystemHook = fileSystemHook;
			m_IsSandbox = luaContext.IsSandbox;
		}

		public Boolean IsReadable(String path) => m_IsSandbox ? !Path.IsPathRooted(path) : m_DefaultFileSystem.IsReadable(path);

		public ValueTask<ILuaStream> Open(String path, LuaFileOpenMode mode, CancellationToken cancellationToken)
		{
			if (Hook != null)
			{
				if (mode == LuaFileOpenMode.Read)
				{
					if (Hook.ReadText(path, out var content))
						return new ValueTask<ILuaStream>(content != null ? new StringStream(content) : null);
				}
				else
				{
					throw new NotImplementedException("file writes");
					// if (m_FileSystemHook.ReadBytes(path, out var bytes))
					// 	return new ValueTask<ILuaStream>(bytes != null ? new ByteMemoryStream(bytes) : null);
				}
			}

			return m_DefaultFileSystem.Open(path, mode, cancellationToken);
		}

		ValueTask<ILuaStream> ILuaFileSystem.OpenTempFileStream(CancellationToken cancellationToken) =>
			m_DefaultFileSystem.OpenTempFileStream(cancellationToken);

		public ValueTask Rename(String oldName, String newName, CancellationToken cancellationToken)
		{
			if (m_IsSandbox)
				throw new NotSupportedException("File system rename not allowed");

			return m_DefaultFileSystem.Rename(oldName, newName, cancellationToken);
		}

		public ValueTask Remove(String path, CancellationToken cancellationToken)
		{
			if (m_IsSandbox)
				throw new NotSupportedException("File system remove not allowed");

			return m_DefaultFileSystem.Remove(path, cancellationToken);
		}

		public String GetTempFileName() => m_DefaultFileSystem.GetTempFileName();
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
	}

	public sealed class LunyLuaStandardIO : ILuaStandardIO
	{
		private readonly ILuaStandardIO m_DefaultStandardIO;

		// will use custom overrides since Debug.Log is not a stream
		public ILuaStream Input => m_DefaultStandardIO.Input;
		public ILuaStream Output => m_DefaultStandardIO.Output;
		public ILuaStream Error => m_DefaultStandardIO.Error;

		public LunyLuaStandardIO(LunyLuaContext luaContext) =>
			m_DefaultStandardIO = new ConsoleStandardIO();
	}
}
