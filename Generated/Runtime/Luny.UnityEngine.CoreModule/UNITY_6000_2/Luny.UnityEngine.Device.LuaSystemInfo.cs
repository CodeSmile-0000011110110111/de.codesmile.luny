
// --------------------------------------------------------------
// GENERATED FILE ----> DO NOT EDIT <---- CHANGES WILL BE LOST !!
// --------------------------------------------------------------

#if UNITY_6000_2_OR_NEWER && !(UNITY_6000_3_OR_NEWER)
#pragma warning disable 0109, 0162, 0168, 0219
using Luny;

namespace Luny.UnityEngine.Device
{
    public sealed class LuaSystemInfoType : global::Luny.ILuaStatic
    {
        public static global::Lua.LuaValue Bind() => new LuaSystemInfoType();
        private LuaSystemInfoType() {}
        public static implicit operator global::Lua.LuaValue(LuaSystemInfoType value) => new(value);
        public global::System.Type BindType => typeof(global::UnityEngine.Device.SystemInfo);
        public override global::System.String ToString() => BindType.FullName;
#if UNITY_EDITOR
        [global::UnityEngine.RuntimeInitializeOnLoadMethod(global::UnityEngine.RuntimeInitializeLoadType.SubsystemRegistration)]
        private static void ResetStaticFields() => s_Metatable = null;
#endif

        private static readonly global::Lua.LuaFunction _LuaSystemInfo_GetCompatibleFormat = new global::Lua.LuaFunction("GetCompatibleFormat", (_context, _) =>
        {
            global::Lua.LuaValue _lastArg = default;
            global::System.Int32 _lastArgPos = default;
            global::System.Type _expectedType = default;
            var _argCount = _context.ArgumentCount;
            var _arg0 = _lastArg = _argCount > 0 ? _context.GetArgument(0) : global::Lua.LuaValue.Nil;
            _lastArgPos = 0; _expectedType = typeof(global::UnityEngine.Experimental.Rendering.GraphicsFormat);
            if (_arg0.TryRead<global::UnityEngine.Experimental.Rendering.GraphicsFormat>(out var _p0_UnityEngine_Experimental_Rendering_GraphicsFormat))
            {
                var _arg1 = _lastArg = _argCount > 1 ? _context.GetArgument(1) : global::Lua.LuaValue.Nil;
                _lastArgPos = 1; _expectedType = typeof(global::UnityEngine.Experimental.Rendering.GraphicsFormatUsage);
                if (_arg1.TryRead<global::UnityEngine.Experimental.Rendering.GraphicsFormatUsage>(out var _p1_UnityEngine_Experimental_Rendering_GraphicsFormatUsage))
                {
                    if (_argCount == 2)
                    {
                        var format = _p0_UnityEngine_Experimental_Rendering_GraphicsFormat;
                        var usage = _p1_UnityEngine_Experimental_Rendering_GraphicsFormatUsage;
                        var _ret0 = global::UnityEngine.Device.SystemInfo.GetCompatibleFormat(format, usage);
                        var _lret0 = new global::Lua.LuaValue((global::System.Int64)_ret0);
                        var _retCount = _context.Return(_lret0);
                        return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                    }
                }
            }
            throw new global::Lua.LuaRuntimeException(_context.Thread, $"{"GetCompatibleFormat"}: invalid argument #{_lastArgPos}: {_lastArg} ({_lastArg.Type}), expected: {_expectedType.FullName}", 2);
        });
        private static readonly global::Lua.LuaFunction _LuaSystemInfo_GetGraphicsFormat = new global::Lua.LuaFunction("GetGraphicsFormat", (_context, _) =>
        {
            global::Lua.LuaValue _lastArg = default;
            global::System.Int32 _lastArgPos = default;
            global::System.Type _expectedType = default;
            var _argCount = _context.ArgumentCount;
            var _arg0 = _lastArg = _argCount > 0 ? _context.GetArgument(0) : global::Lua.LuaValue.Nil;
            _lastArgPos = 0; _expectedType = typeof(global::UnityEngine.Experimental.Rendering.DefaultFormat);
            if (_arg0.TryRead<global::UnityEngine.Experimental.Rendering.DefaultFormat>(out var _p0_UnityEngine_Experimental_Rendering_DefaultFormat))
            {
                if (_argCount == 1)
                {
                    var format = _p0_UnityEngine_Experimental_Rendering_DefaultFormat;
                    var _ret0 = global::UnityEngine.Device.SystemInfo.GetGraphicsFormat(format);
                    var _lret0 = new global::Lua.LuaValue((global::System.Int64)_ret0);
                    var _retCount = _context.Return(_lret0);
                    return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                }
            }
            throw new global::Lua.LuaRuntimeException(_context.Thread, $"{"GetGraphicsFormat"}: invalid argument #{_lastArgPos}: {_lastArg} ({_lastArg.Type}), expected: {_expectedType.FullName}", 2);
        });
        private static readonly global::Lua.LuaFunction _LuaSystemInfo_GetRenderTextureSupportedMSAASampleCount = new global::Lua.LuaFunction("GetRenderTextureSupportedMSAASampleCount", (_context, _) =>
        {
            global::Lua.LuaValue _lastArg = default;
            global::System.Int32 _lastArgPos = default;
            global::System.Type _expectedType = default;
            var _argCount = _context.ArgumentCount;
            var _arg0 = _lastArg = _argCount > 0 ? _context.GetArgument(0) : global::Lua.LuaValue.Nil;
            _lastArgPos = 0; _expectedType = typeof(global::Luny.UnityEngine.LuaRenderTextureDescriptor);
            if (_arg0.TryRead<global::Luny.UnityEngine.LuaRenderTextureDescriptor>(out var _p0_UnityEngine_RenderTextureDescriptor))
            {
                if (_argCount == 1)
                {
                    var desc = _p0_UnityEngine_RenderTextureDescriptor.Value;
                    var _ret0 = global::UnityEngine.Device.SystemInfo.GetRenderTextureSupportedMSAASampleCount(desc);
                    var _lret0 = new global::Lua.LuaValue(_ret0);
                    var _retCount = _context.Return(_lret0);
                    return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                }
            }
            throw new global::Lua.LuaRuntimeException(_context.Thread, $"{"GetRenderTextureSupportedMSAASampleCount"}: invalid argument #{_lastArgPos}: {_lastArg} ({_lastArg.Type}), expected: {_expectedType.FullName}", 2);
        });
        private static readonly global::Lua.LuaFunction _LuaSystemInfo_IsFormatSupported = new global::Lua.LuaFunction("IsFormatSupported", (_context, _) =>
        {
            global::Lua.LuaValue _lastArg = default;
            global::System.Int32 _lastArgPos = default;
            global::System.Type _expectedType = default;
            var _argCount = _context.ArgumentCount;
            var _arg0 = _lastArg = _argCount > 0 ? _context.GetArgument(0) : global::Lua.LuaValue.Nil;
            _lastArgPos = 0; _expectedType = typeof(global::UnityEngine.Experimental.Rendering.GraphicsFormat);
            if (_arg0.TryRead<global::UnityEngine.Experimental.Rendering.GraphicsFormat>(out var _p0_UnityEngine_Experimental_Rendering_GraphicsFormat))
            {
                var _arg1 = _lastArg = _argCount > 1 ? _context.GetArgument(1) : global::Lua.LuaValue.Nil;
                _lastArgPos = 1; _expectedType = typeof(global::UnityEngine.Experimental.Rendering.GraphicsFormatUsage);
                if (_arg1.TryRead<global::UnityEngine.Experimental.Rendering.GraphicsFormatUsage>(out var _p1_UnityEngine_Experimental_Rendering_GraphicsFormatUsage))
                {
                    if (_argCount == 2)
                    {
                        var format = _p0_UnityEngine_Experimental_Rendering_GraphicsFormat;
                        var usage = _p1_UnityEngine_Experimental_Rendering_GraphicsFormatUsage;
                        var _ret0 = global::UnityEngine.Device.SystemInfo.IsFormatSupported(format, usage);
                        var _lret0 = new global::Lua.LuaValue(_ret0);
                        var _retCount = _context.Return(_lret0);
                        return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                    }
                }
            }
            throw new global::Lua.LuaRuntimeException(_context.Thread, $"{"IsFormatSupported"}: invalid argument #{_lastArgPos}: {_lastArg} ({_lastArg.Type}), expected: {_expectedType.FullName}", 2);
        });
        private static readonly global::Lua.LuaFunction _LuaSystemInfo_SupportsBlendingOnRenderTextureFormat = new global::Lua.LuaFunction("SupportsBlendingOnRenderTextureFormat", (_context, _) =>
        {
            global::Lua.LuaValue _lastArg = default;
            global::System.Int32 _lastArgPos = default;
            global::System.Type _expectedType = default;
            var _argCount = _context.ArgumentCount;
            var _arg0 = _lastArg = _argCount > 0 ? _context.GetArgument(0) : global::Lua.LuaValue.Nil;
            _lastArgPos = 0; _expectedType = typeof(global::UnityEngine.RenderTextureFormat);
            if (_arg0.TryRead<global::UnityEngine.RenderTextureFormat>(out var _p0_UnityEngine_RenderTextureFormat))
            {
                if (_argCount == 1)
                {
                    var format = _p0_UnityEngine_RenderTextureFormat;
                    var _ret0 = global::UnityEngine.Device.SystemInfo.SupportsBlendingOnRenderTextureFormat(format);
                    var _lret0 = new global::Lua.LuaValue(_ret0);
                    var _retCount = _context.Return(_lret0);
                    return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                }
            }
            throw new global::Lua.LuaRuntimeException(_context.Thread, $"{"SupportsBlendingOnRenderTextureFormat"}: invalid argument #{_lastArgPos}: {_lastArg} ({_lastArg.Type}), expected: {_expectedType.FullName}", 2);
        });
        private static readonly global::Lua.LuaFunction _LuaSystemInfo_SupportsRandomWriteOnRenderTextureFormat = new global::Lua.LuaFunction("SupportsRandomWriteOnRenderTextureFormat", (_context, _) =>
        {
            global::Lua.LuaValue _lastArg = default;
            global::System.Int32 _lastArgPos = default;
            global::System.Type _expectedType = default;
            var _argCount = _context.ArgumentCount;
            var _arg0 = _lastArg = _argCount > 0 ? _context.GetArgument(0) : global::Lua.LuaValue.Nil;
            _lastArgPos = 0; _expectedType = typeof(global::UnityEngine.RenderTextureFormat);
            if (_arg0.TryRead<global::UnityEngine.RenderTextureFormat>(out var _p0_UnityEngine_RenderTextureFormat))
            {
                if (_argCount == 1)
                {
                    var format = _p0_UnityEngine_RenderTextureFormat;
                    var _ret0 = global::UnityEngine.Device.SystemInfo.SupportsRandomWriteOnRenderTextureFormat(format);
                    var _lret0 = new global::Lua.LuaValue(_ret0);
                    var _retCount = _context.Return(_lret0);
                    return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                }
            }
            throw new global::Lua.LuaRuntimeException(_context.Thread, $"{"SupportsRandomWriteOnRenderTextureFormat"}: invalid argument #{_lastArgPos}: {_lastArg} ({_lastArg.Type}), expected: {_expectedType.FullName}", 2);
        });
        private static readonly global::Lua.LuaFunction _LuaSystemInfo_SupportsRenderTextureFormat = new global::Lua.LuaFunction("SupportsRenderTextureFormat", (_context, _) =>
        {
            global::Lua.LuaValue _lastArg = default;
            global::System.Int32 _lastArgPos = default;
            global::System.Type _expectedType = default;
            var _argCount = _context.ArgumentCount;
            var _arg0 = _lastArg = _argCount > 0 ? _context.GetArgument(0) : global::Lua.LuaValue.Nil;
            _lastArgPos = 0; _expectedType = typeof(global::UnityEngine.RenderTextureFormat);
            if (_arg0.TryRead<global::UnityEngine.RenderTextureFormat>(out var _p0_UnityEngine_RenderTextureFormat))
            {
                if (_argCount == 1)
                {
                    var format = _p0_UnityEngine_RenderTextureFormat;
                    var _ret0 = global::UnityEngine.Device.SystemInfo.SupportsRenderTextureFormat(format);
                    var _lret0 = new global::Lua.LuaValue(_ret0);
                    var _retCount = _context.Return(_lret0);
                    return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                }
            }
            throw new global::Lua.LuaRuntimeException(_context.Thread, $"{"SupportsRenderTextureFormat"}: invalid argument #{_lastArgPos}: {_lastArg} ({_lastArg.Type}), expected: {_expectedType.FullName}", 2);
        });
        private static readonly global::Lua.LuaFunction _LuaSystemInfo_SupportsTextureFormat = new global::Lua.LuaFunction("SupportsTextureFormat", (_context, _) =>
        {
            global::Lua.LuaValue _lastArg = default;
            global::System.Int32 _lastArgPos = default;
            global::System.Type _expectedType = default;
            var _argCount = _context.ArgumentCount;
            var _arg0 = _lastArg = _argCount > 0 ? _context.GetArgument(0) : global::Lua.LuaValue.Nil;
            _lastArgPos = 0; _expectedType = typeof(global::UnityEngine.TextureFormat);
            if (_arg0.TryRead<global::UnityEngine.TextureFormat>(out var _p0_UnityEngine_TextureFormat))
            {
                if (_argCount == 1)
                {
                    var format = _p0_UnityEngine_TextureFormat;
                    var _ret0 = global::UnityEngine.Device.SystemInfo.SupportsTextureFormat(format);
                    var _lret0 = new global::Lua.LuaValue(_ret0);
                    var _retCount = _context.Return(_lret0);
                    return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                }
            }
            throw new global::Lua.LuaRuntimeException(_context.Thread, $"{"SupportsTextureFormat"}: invalid argument #{_lastArgPos}: {_lastArg} ({_lastArg.Type}), expected: {_expectedType.FullName}", 2);
        });
        private static readonly global::Lua.LuaFunction _LuaSystemInfo_SupportsVertexAttributeFormat = new global::Lua.LuaFunction("SupportsVertexAttributeFormat", (_context, _) =>
        {
            global::Lua.LuaValue _lastArg = default;
            global::System.Int32 _lastArgPos = default;
            global::System.Type _expectedType = default;
            var _argCount = _context.ArgumentCount;
            var _arg0 = _lastArg = _argCount > 0 ? _context.GetArgument(0) : global::Lua.LuaValue.Nil;
            _lastArgPos = 0; _expectedType = typeof(global::UnityEngine.Rendering.VertexAttributeFormat);
            if (_arg0.TryRead<global::UnityEngine.Rendering.VertexAttributeFormat>(out var _p0_UnityEngine_Rendering_VertexAttributeFormat))
            {
                var _arg1 = _lastArg = _argCount > 1 ? _context.GetArgument(1) : global::Lua.LuaValue.Nil;
                _lastArgPos = 1; _expectedType = typeof(global::System.Int32);
                if (_arg1.TryRead<global::System.Int32>(out var _p1_System_Int32))
                {
                    if (_argCount == 2)
                    {
                        var format = _p0_UnityEngine_Rendering_VertexAttributeFormat;
                        var dimension = _p1_System_Int32;
                        var _ret0 = global::UnityEngine.Device.SystemInfo.SupportsVertexAttributeFormat(format, dimension);
                        var _lret0 = new global::Lua.LuaValue(_ret0);
                        var _retCount = _context.Return(_lret0);
                        return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                    }
                }
            }
            throw new global::Lua.LuaRuntimeException(_context.Thread, $"{"SupportsVertexAttributeFormat"}: invalid argument #{_lastArgPos}: {_lastArg} ({_lastArg.Type}), expected: {_expectedType.FullName}", 2);
        });
        private static readonly global::Lua.LuaFunction __index = new(global::Lua.Runtime.Metamethods.Index, (_context, _) =>
        {
            var _this = _context.GetArgument<LuaSystemInfoType>(0);
            var _key = _context.GetArgument(1);
            var _factory = _context.GetObjectFactory();
            global::Lua.LuaValue _value = global::Lua.LuaValue.Nil;
            if (_key.Type == global::Lua.LuaValueType.Number && _key.TryRead<global::System.Int32>(out var _index) && _this.TryGetLuaValue(_index, out _value, _factory))
                return new global::System.Threading.Tasks.ValueTask<global::System.Int32>(_context.Return(_value));
            if (_key.Type == global::Lua.LuaValueType.String && _this.TryGetLuaValue(_key.Read<global::System.String>(), out _value, _factory))
                return new global::System.Threading.Tasks.ValueTask<global::System.Int32>(_context.Return(_value));
            throw new global::Lua.LuaRuntimeException(_context.Thread, $"attempt to index nil value '{_key}' on '{_this}'", 2);
        });
        private static readonly global::Lua.LuaFunction __newindex = new(global::Lua.Runtime.Metamethods.NewIndex, (_context, _) =>
        {
            var _this = _context.GetArgument<LuaSystemInfoType>(0);
            var _key = _context.GetArgument(1);
            var _value = _context.GetArgument(2);
            if (_key.Type == global::Lua.LuaValueType.Number && _key.TryRead<global::System.Int32>(out var _index) && _this.TrySetLuaValue(_index, _value))
                return new global::System.Threading.Tasks.ValueTask<global::System.Int32>(_context.Return(_value));
            if (_key.Type == global::Lua.LuaValueType.String && _this.TrySetLuaValue(_key.Read<global::System.String>(), _value))
                return new global::System.Threading.Tasks.ValueTask<global::System.Int32>(_context.Return(_value));
            throw new global::Lua.LuaRuntimeException(_context.Thread, $"attempt to assign to unknown '{_key}' on '{_this}'", 2);
        });
        private static global::Lua.LuaTable CreateMetatable()
        {
            var metatable = new global::Lua.LuaTable(0, 4);
            metatable[global::Lua.Runtime.Metamethods.Index] = __index;
            metatable[global::Lua.Runtime.Metamethods.NewIndex] = __newindex;
            metatable[global::Lua.Runtime.Metamethods.Concat] = global::Luny.LuaMetatable.ConcatMetamethod;
            metatable[global::Lua.Runtime.Metamethods.ToString] = global::Luny.LuaMetatable.ToStringMetamethod;
            return metatable;
        }
        private static global::Lua.LuaTable s_Metatable;
        public global::Lua.LuaTable Metatable
        {
            get => s_Metatable ??= CreateMetatable();
            set => throw new global::System.NotSupportedException("LuaObject metatables cannot be modified");
        }
        global::System.Span<global::Lua.LuaValue> global::Lua.ILuaUserData.UserValues => default;

        public global::System.Boolean TryGetLuaValue(global::System.Int32 _key, out global::Lua.LuaValue _value, global::Luny.ILuaObjectFactory _factory)
        {
            _value = global::Lua.LuaValue.Nil; return false;
        }
        public global::System.Boolean TryGetLuaValue(global::System.String _key, out global::Lua.LuaValue _value, global::Luny.ILuaObjectFactory _factory)
        {
            switch (_key)
            {
                case "GetCompatibleFormat": _value = _LuaSystemInfo_GetCompatibleFormat; return true;
                case "GetGraphicsFormat": _value = _LuaSystemInfo_GetGraphicsFormat; return true;
                case "GetRenderTextureSupportedMSAASampleCount": _value = _LuaSystemInfo_GetRenderTextureSupportedMSAASampleCount; return true;
                case "IsFormatSupported": _value = _LuaSystemInfo_IsFormatSupported; return true;
                case "SupportsBlendingOnRenderTextureFormat": _value = _LuaSystemInfo_SupportsBlendingOnRenderTextureFormat; return true;
                case "SupportsRandomWriteOnRenderTextureFormat": _value = _LuaSystemInfo_SupportsRandomWriteOnRenderTextureFormat; return true;
                case "SupportsRenderTextureFormat": _value = _LuaSystemInfo_SupportsRenderTextureFormat; return true;
                case "SupportsTextureFormat": _value = _LuaSystemInfo_SupportsTextureFormat; return true;
                case "SupportsVertexAttributeFormat": _value = _LuaSystemInfo_SupportsVertexAttributeFormat; return true;
                case "batteryLevel": _value = new global::Lua.LuaValue(global::UnityEngine.Device.SystemInfo.batteryLevel); return true;
                case "batteryStatus": _value = new global::Lua.LuaValue((global::System.Int64)global::UnityEngine.Device.SystemInfo.batteryStatus); return true;
                case "computeSubGroupSize": _value = new global::Lua.LuaValue(global::UnityEngine.Device.SystemInfo.computeSubGroupSize); return true;
                case "constantBufferOffsetAlignment": _value = new global::Lua.LuaValue(global::UnityEngine.Device.SystemInfo.constantBufferOffsetAlignment); return true;
                case "copyTextureSupport": _value = new global::Lua.LuaValue((global::System.Int64)global::UnityEngine.Device.SystemInfo.copyTextureSupport); return true;
                case "deviceModel": _value = new global::Lua.LuaValue(global::UnityEngine.Device.SystemInfo.deviceModel); return true;
                case "deviceName": _value = new global::Lua.LuaValue(global::UnityEngine.Device.SystemInfo.deviceName); return true;
                case "deviceType": _value = new global::Lua.LuaValue((global::System.Int64)global::UnityEngine.Device.SystemInfo.deviceType); return true;
                case "deviceUniqueIdentifier": _value = new global::Lua.LuaValue(global::UnityEngine.Device.SystemInfo.deviceUniqueIdentifier); return true;
                case "foveatedRenderingCaps": _value = new global::Lua.LuaValue((global::System.Int64)global::UnityEngine.Device.SystemInfo.foveatedRenderingCaps); return true;
                case "graphicsDeviceID": _value = new global::Lua.LuaValue(global::UnityEngine.Device.SystemInfo.graphicsDeviceID); return true;
                case "graphicsDeviceName": _value = new global::Lua.LuaValue(global::UnityEngine.Device.SystemInfo.graphicsDeviceName); return true;
                case "graphicsDeviceType": _value = new global::Lua.LuaValue((global::System.Int64)global::UnityEngine.Device.SystemInfo.graphicsDeviceType); return true;
                case "graphicsDeviceVendor": _value = new global::Lua.LuaValue(global::UnityEngine.Device.SystemInfo.graphicsDeviceVendor); return true;
                case "graphicsDeviceVendorID": _value = new global::Lua.LuaValue(global::UnityEngine.Device.SystemInfo.graphicsDeviceVendorID); return true;
                case "graphicsDeviceVersion": _value = new global::Lua.LuaValue(global::UnityEngine.Device.SystemInfo.graphicsDeviceVersion); return true;
                case "graphicsMemorySize": _value = new global::Lua.LuaValue(global::UnityEngine.Device.SystemInfo.graphicsMemorySize); return true;
                case "graphicsMultiThreaded": _value = new global::Lua.LuaValue(global::UnityEngine.Device.SystemInfo.graphicsMultiThreaded); return true;
                case "graphicsShaderLevel": _value = new global::Lua.LuaValue(global::UnityEngine.Device.SystemInfo.graphicsShaderLevel); return true;
                case "graphicsUVStartsAtTop": _value = new global::Lua.LuaValue(global::UnityEngine.Device.SystemInfo.graphicsUVStartsAtTop); return true;
                case "hasDynamicUniformArrayIndexingInFragmentShaders": _value = new global::Lua.LuaValue(global::UnityEngine.Device.SystemInfo.hasDynamicUniformArrayIndexingInFragmentShaders); return true;
                case "hasHiddenSurfaceRemovalOnGPU": _value = new global::Lua.LuaValue(global::UnityEngine.Device.SystemInfo.hasHiddenSurfaceRemovalOnGPU); return true;
                case "hasMipMaxLevel": _value = new global::Lua.LuaValue(global::UnityEngine.Device.SystemInfo.hasMipMaxLevel); return true;
                case "hasTiledGPU": _value = new global::Lua.LuaValue(global::UnityEngine.Device.SystemInfo.hasTiledGPU); return true;
                case "hdrDisplaySupportFlags": _value = new global::Lua.LuaValue((global::System.Int64)global::UnityEngine.Device.SystemInfo.hdrDisplaySupportFlags); return true;
                case "maxAnisotropyLevel": _value = new global::Lua.LuaValue(global::UnityEngine.Device.SystemInfo.maxAnisotropyLevel); return true;
                case "maxComputeBufferInputsCompute": _value = new global::Lua.LuaValue(global::UnityEngine.Device.SystemInfo.maxComputeBufferInputsCompute); return true;
                case "maxComputeBufferInputsDomain": _value = new global::Lua.LuaValue(global::UnityEngine.Device.SystemInfo.maxComputeBufferInputsDomain); return true;
                case "maxComputeBufferInputsFragment": _value = new global::Lua.LuaValue(global::UnityEngine.Device.SystemInfo.maxComputeBufferInputsFragment); return true;
                case "maxComputeBufferInputsGeometry": _value = new global::Lua.LuaValue(global::UnityEngine.Device.SystemInfo.maxComputeBufferInputsGeometry); return true;
                case "maxComputeBufferInputsHull": _value = new global::Lua.LuaValue(global::UnityEngine.Device.SystemInfo.maxComputeBufferInputsHull); return true;
                case "maxComputeBufferInputsVertex": _value = new global::Lua.LuaValue(global::UnityEngine.Device.SystemInfo.maxComputeBufferInputsVertex); return true;
                case "maxComputeWorkGroupSize": _value = new global::Lua.LuaValue(global::UnityEngine.Device.SystemInfo.maxComputeWorkGroupSize); return true;
                case "maxComputeWorkGroupSizeX": _value = new global::Lua.LuaValue(global::UnityEngine.Device.SystemInfo.maxComputeWorkGroupSizeX); return true;
                case "maxComputeWorkGroupSizeY": _value = new global::Lua.LuaValue(global::UnityEngine.Device.SystemInfo.maxComputeWorkGroupSizeY); return true;
                case "maxComputeWorkGroupSizeZ": _value = new global::Lua.LuaValue(global::UnityEngine.Device.SystemInfo.maxComputeWorkGroupSizeZ); return true;
                case "maxConstantBufferSize": _value = new global::Lua.LuaValue(global::UnityEngine.Device.SystemInfo.maxConstantBufferSize); return true;
                case "maxCubemapSize": _value = new global::Lua.LuaValue(global::UnityEngine.Device.SystemInfo.maxCubemapSize); return true;
                case "maxGraphicsBufferSize": _value = new global::Lua.LuaValue(global::UnityEngine.Device.SystemInfo.maxGraphicsBufferSize); return true;
                case "maxTexture3DSize": _value = new global::Lua.LuaValue(global::UnityEngine.Device.SystemInfo.maxTexture3DSize); return true;
                case "maxTextureArraySlices": _value = new global::Lua.LuaValue(global::UnityEngine.Device.SystemInfo.maxTextureArraySlices); return true;
                case "maxTextureSize": _value = new global::Lua.LuaValue(global::UnityEngine.Device.SystemInfo.maxTextureSize); return true;
                case "npotSupport": _value = new global::Lua.LuaValue((global::System.Int64)global::UnityEngine.Device.SystemInfo.npotSupport); return true;
                case "operatingSystem": _value = new global::Lua.LuaValue(global::UnityEngine.Device.SystemInfo.operatingSystem); return true;
                case "operatingSystemFamily": _value = new global::Lua.LuaValue((global::System.Int64)global::UnityEngine.Device.SystemInfo.operatingSystemFamily); return true;
                case "processorCount": _value = new global::Lua.LuaValue(global::UnityEngine.Device.SystemInfo.processorCount); return true;
                case "processorFrequency": _value = new global::Lua.LuaValue(global::UnityEngine.Device.SystemInfo.processorFrequency); return true;
                case "processorType": _value = new global::Lua.LuaValue(global::UnityEngine.Device.SystemInfo.processorType); return true;
                case "renderingThreadingMode": _value = new global::Lua.LuaValue((global::System.Int64)global::UnityEngine.Device.SystemInfo.renderingThreadingMode); return true;
                case "supportedRandomWriteTargetCount": _value = new global::Lua.LuaValue(global::UnityEngine.Device.SystemInfo.supportedRandomWriteTargetCount); return true;
                case "supportedRenderTargetCount": _value = new global::Lua.LuaValue(global::UnityEngine.Device.SystemInfo.supportedRenderTargetCount); return true;
                case "supports2DArrayTextures": _value = new global::Lua.LuaValue(global::UnityEngine.Device.SystemInfo.supports2DArrayTextures); return true;
                case "supports32bitsIndexBuffer": _value = new global::Lua.LuaValue(global::UnityEngine.Device.SystemInfo.supports32bitsIndexBuffer); return true;
                case "supports3DRenderTextures": _value = new global::Lua.LuaValue(global::UnityEngine.Device.SystemInfo.supports3DRenderTextures); return true;
                case "supports3DTextures": _value = new global::Lua.LuaValue(global::UnityEngine.Device.SystemInfo.supports3DTextures); return true;
                case "supportsAccelerometer": _value = new global::Lua.LuaValue(global::UnityEngine.Device.SystemInfo.supportsAccelerometer); return true;
                case "supportsAnisotropicFilter": _value = new global::Lua.LuaValue(global::UnityEngine.Device.SystemInfo.supportsAnisotropicFilter); return true;
                case "supportsAsyncCompute": _value = new global::Lua.LuaValue(global::UnityEngine.Device.SystemInfo.supportsAsyncCompute); return true;
                case "supportsAsyncGPUReadback": _value = new global::Lua.LuaValue(global::UnityEngine.Device.SystemInfo.supportsAsyncGPUReadback); return true;
                case "supportsAudio": _value = new global::Lua.LuaValue(global::UnityEngine.Device.SystemInfo.supportsAudio); return true;
                case "supportsCompressed3DTextures": _value = new global::Lua.LuaValue(global::UnityEngine.Device.SystemInfo.supportsCompressed3DTextures); return true;
                case "supportsComputeShaders": _value = new global::Lua.LuaValue(global::UnityEngine.Device.SystemInfo.supportsComputeShaders); return true;
                case "supportsConservativeRaster": _value = new global::Lua.LuaValue(global::UnityEngine.Device.SystemInfo.supportsConservativeRaster); return true;
                case "supportsCubemapArrayTextures": _value = new global::Lua.LuaValue(global::UnityEngine.Device.SystemInfo.supportsCubemapArrayTextures); return true;
                case "supportsDepthFetchInRenderPass": _value = new global::Lua.LuaValue(global::UnityEngine.Device.SystemInfo.supportsDepthFetchInRenderPass); return true;
                case "supportsGeometryShaders": _value = new global::Lua.LuaValue(global::UnityEngine.Device.SystemInfo.supportsGeometryShaders); return true;
                case "supportsGpuRecorder": _value = new global::Lua.LuaValue(global::UnityEngine.Device.SystemInfo.supportsGpuRecorder); return true;
                case "supportsGraphicsFence": _value = new global::Lua.LuaValue(global::UnityEngine.Device.SystemInfo.supportsGraphicsFence); return true;
                case "supportsGyroscope": _value = new global::Lua.LuaValue(global::UnityEngine.Device.SystemInfo.supportsGyroscope); return true;
                case "supportsHardwareQuadTopology": _value = new global::Lua.LuaValue(global::UnityEngine.Device.SystemInfo.supportsHardwareQuadTopology); return true;
                case "supportsIndirectArgumentsBuffer": _value = new global::Lua.LuaValue(global::UnityEngine.Device.SystemInfo.supportsIndirectArgumentsBuffer); return true;
                case "supportsIndirectDispatchRays": _value = new global::Lua.LuaValue(global::UnityEngine.Device.SystemInfo.supportsIndirectDispatchRays); return true;
                case "supportsInlineRayTracing": _value = new global::Lua.LuaValue(global::UnityEngine.Device.SystemInfo.supportsInlineRayTracing); return true;
                case "supportsInstancing": _value = new global::Lua.LuaValue(global::UnityEngine.Device.SystemInfo.supportsInstancing); return true;
                case "supportsLocationService": _value = new global::Lua.LuaValue(global::UnityEngine.Device.SystemInfo.supportsLocationService); return true;
                case "supportsMipStreaming": _value = new global::Lua.LuaValue(global::UnityEngine.Device.SystemInfo.supportsMipStreaming); return true;
                case "supportsMotionVectors": _value = new global::Lua.LuaValue(global::UnityEngine.Device.SystemInfo.supportsMotionVectors); return true;
                case "supportsMultisampleAutoResolve": _value = new global::Lua.LuaValue(global::UnityEngine.Device.SystemInfo.supportsMultisampleAutoResolve); return true;
                case "supportsMultisampled2DArrayTextures": _value = new global::Lua.LuaValue(global::UnityEngine.Device.SystemInfo.supportsMultisampled2DArrayTextures); return true;
                case "supportsMultisampledBackBuffer": _value = new global::Lua.LuaValue(global::UnityEngine.Device.SystemInfo.supportsMultisampledBackBuffer); return true;
                case "supportsMultisampledTextures": _value = new global::Lua.LuaValue(global::UnityEngine.Device.SystemInfo.supportsMultisampledTextures); return true;
                case "supportsMultisampleResolveDepth": _value = new global::Lua.LuaValue(global::UnityEngine.Device.SystemInfo.supportsMultisampleResolveDepth); return true;
                case "supportsMultisampleResolveStencil": _value = new global::Lua.LuaValue(global::UnityEngine.Device.SystemInfo.supportsMultisampleResolveStencil); return true;
                case "supportsMultiview": _value = new global::Lua.LuaValue(global::UnityEngine.Device.SystemInfo.supportsMultiview); return true;
                case "supportsParallelPSOCreation": _value = new global::Lua.LuaValue(global::UnityEngine.Device.SystemInfo.supportsParallelPSOCreation); return true;
                case "supportsRawShadowDepthSampling": _value = new global::Lua.LuaValue(global::UnityEngine.Device.SystemInfo.supportsRawShadowDepthSampling); return true;
                case "supportsRayTracing": _value = new global::Lua.LuaValue(global::UnityEngine.Device.SystemInfo.supportsRayTracing); return true;
                case "supportsRayTracingShaders": _value = new global::Lua.LuaValue(global::UnityEngine.Device.SystemInfo.supportsRayTracingShaders); return true;
                case "supportsRenderTargetArrayIndexFromVertexShader": _value = new global::Lua.LuaValue(global::UnityEngine.Device.SystemInfo.supportsRenderTargetArrayIndexFromVertexShader); return true;
                case "supportsSeparatedRenderTargetsBlend": _value = new global::Lua.LuaValue(global::UnityEngine.Device.SystemInfo.supportsSeparatedRenderTargetsBlend); return true;
                case "supportsSetConstantBuffer": _value = new global::Lua.LuaValue(global::UnityEngine.Device.SystemInfo.supportsSetConstantBuffer); return true;
                case "supportsShadows": _value = new global::Lua.LuaValue(global::UnityEngine.Device.SystemInfo.supportsShadows); return true;
                case "supportsSparseTextures": _value = new global::Lua.LuaValue(global::UnityEngine.Device.SystemInfo.supportsSparseTextures); return true;
                case "supportsStoreAndResolveAction": _value = new global::Lua.LuaValue(global::UnityEngine.Device.SystemInfo.supportsStoreAndResolveAction); return true;
                case "supportsTessellationShaders": _value = new global::Lua.LuaValue(global::UnityEngine.Device.SystemInfo.supportsTessellationShaders); return true;
                case "supportsTextureWrapMirrorOnce": _value = new global::Lua.LuaValue(global::UnityEngine.Device.SystemInfo.supportsTextureWrapMirrorOnce); return true;
                case "supportsVariableRateShading": _value = new global::Lua.LuaValue(global::UnityEngine.Device.SystemInfo.supportsVariableRateShading); return true;
                case "supportsVibration": _value = new global::Lua.LuaValue(global::UnityEngine.Device.SystemInfo.supportsVibration); return true;
                case "systemMemorySize": _value = new global::Lua.LuaValue(global::UnityEngine.Device.SystemInfo.systemMemorySize); return true;
                case "usesLoadStoreActions": _value = new global::Lua.LuaValue(global::UnityEngine.Device.SystemInfo.usesLoadStoreActions); return true;
                case "usesReversedZBuffer": _value = new global::Lua.LuaValue(global::UnityEngine.Device.SystemInfo.usesReversedZBuffer); return true;
                case "unsupportedIdentifier": _value = new global::Lua.LuaValue(global::UnityEngine.Device.SystemInfo.unsupportedIdentifier); return true;
                default: _value = global::Lua.LuaValue.Nil; return false;
            }
        }
        public global::System.Boolean TrySetLuaValue(global::System.Int32 _key, global::Lua.LuaValue _value)
        {
            return false;
        }
        public global::System.Boolean TrySetLuaValue(global::System.String _key, global::Lua.LuaValue _value)
        {
            switch (_key)
            {
                default: return false;
            }
        }
    }
}
#pragma warning restore 0109, 0162, 0168, 0219
#endif
