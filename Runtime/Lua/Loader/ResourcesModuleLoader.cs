/*
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using UnityEditor;
using UnityEngine;

namespace Lua.Unity
{
	public sealed class ResourcesModuleLoader : ILuaModuleLoader
	{
		private readonly Dictionary<String, LuaAsset> cache = new();

		public Boolean Exists(String moduleName)
		{
			if (cache.TryGetValue(moduleName, out var _)) return true;

			var asset = Resources.Load<LuaAsset>(moduleName);
			if (asset == null) return false;

			cache.Add(moduleName, asset);
			return true;
		}

		public async ValueTask<LuaModule> LoadAsync(String moduleName, CancellationToken cancellationToken = default)
		{
			if (cache.TryGetValue(moduleName, out var asset))
				return new LuaModule(moduleName, asset.text);

			var request = Resources.LoadAsync<LuaAsset>(moduleName);
			await request;

			if (request.asset == null)
				throw new LuaModuleNotFoundException(moduleName);

			asset = (LuaAsset)request.asset;
			cache.Add(moduleName, asset);
			return new LuaModule(moduleName, asset.text);
		}
	}

#if !UNITY_2023_1_OR_NEWER
    internal static class ResourceRequestExtensions
    {
        public static ResourceRequestAwaiter GetAwaiter(this ResourceRequest request)
        {
            return new ResourceRequestAwaiter(request);
        }

        public readonly struct ResourceRequestAwaiter : ICriticalNotifyCompletion
        {
            public ResourceRequestAwaiter(ResourceRequest request)
            {
                this.request = request;
            }

            readonly ResourceRequest request;

            public bool IsCompleted => request.isDone;

            public void OnCompleted(Action continuation)
            {
                request.completed += x => continuation.Invoke();
            }

            public void UnsafeOnCompleted(Action continuation)
            {
                request.completed += x => continuation.Invoke();
            }

            public void GetResult()
            {
            }

            public ResourceRequestAwaiter GetAwaiter()
            {
                return this;
            }
        }
    }
#endif
}
*/

using UnityEditor;
using UnityEngine;
