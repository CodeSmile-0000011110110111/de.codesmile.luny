// Copyright (C) 2021-2025 Steffen Itterheim
// Refer to included LICENSE file for terms and conditions.

using Lua.IO;
using System;
using System.IO;
using System.Threading;
using System.Threading.Tasks;
using UnityEditor;
using UnityEngine;

namespace Luny
{
	internal sealed class LuaUnityFileSystem : ILuaFileSystem
	{
		private readonly ILuaFileSystem m_DefaultFileSystem = new FileSystem();
		private readonly ILuaFileSystemHook m_FileSystemHook;
		private readonly Boolean m_IsSandbox;
		public ILuaFileSystemHook Hook => m_FileSystemHook;

		public String DirectorySeparator => "/";

		public LuaUnityFileSystem(LunyLuaContext luaContext, ILuaFileSystemHook fileSystemHook)
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
}
