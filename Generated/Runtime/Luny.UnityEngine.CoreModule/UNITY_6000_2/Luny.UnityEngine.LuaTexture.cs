
// --------------------------------------------------------------
// GENERATED FILE ----> DO NOT EDIT <---- CHANGES WILL BE LOST !!
// --------------------------------------------------------------

#if UNITY_6000_2_OR_NEWER && !(UNITY_6000_3_OR_NEWER)
#pragma warning disable 0109, 0162, 0168, 0219
using Luny;

namespace Luny.UnityEngine
{
    public class LuaTexture : global::Luny.UnityEngine.LuaUnityObject, global::Luny.ILuaObject<global::UnityEngine.Texture>
    {
        public new static global::Lua.LuaValue Bind(global::UnityEngine.Texture instance) => new LuaTexture(instance);
        public new static global::Lua.LuaValue Bind(global::System.Object instance) => Bind((global::UnityEngine.Texture)instance);
        public new static global::Lua.LuaValue Bind(global::System.Collections.Generic.IList<global::UnityEngine.Texture> instances) =>
            new global::Luny.LuaList<global::UnityEngine.Texture>(instances);
        public new static global::Lua.LuaValue Bind(global::System.Collections.Generic.IList<global::System.Object> instances) =>
            new global::Luny.LuaList<global::UnityEngine.Texture>(instances);
        protected LuaTexture(global::UnityEngine.Texture instance) : base(instance) {}
        public static implicit operator global::Lua.LuaValue(LuaTexture value) => new(value);
        public new global::UnityEngine.Texture Instance => (global::UnityEngine.Texture)m_Instance;
        public new global::System.Type BindType => typeof(global::UnityEngine.Texture);
        public override global::System.String ToString() => m_Instance != null ? Instance.ToString() : "{GetType().Name}(null)";
#if UNITY_EDITOR
        [global::UnityEngine.RuntimeInitializeOnLoadMethod(global::UnityEngine.RuntimeInitializeLoadType.SubsystemRegistration)]
        private static void ResetStaticFields() => s_Metatable = null;
#endif

        private static readonly global::Lua.LuaFunction _LuaTexture_IncrementUpdateCount = new global::Lua.LuaFunction("IncrementUpdateCount", (_context, _) =>
        {
            global::Lua.LuaValue _lastArg = default;
            global::System.Int32 _lastArgPos = default;
            global::System.Type _expectedType = default;
            var _argCount = _context.ArgumentCount;
            var _this = _context.GetArgument<LuaTexture>(0);
            if (_argCount == 1)
            {
                _this.Instance.IncrementUpdateCount();
                var _retCount = _context.Return();
                return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
            }
            throw new global::Lua.LuaRuntimeException(_context.Thread, $"{"IncrementUpdateCount"}: invalid argument #{_lastArgPos}: {_lastArg} ({_lastArg.Type}), expected: {_expectedType.FullName}", 2);
        });
        private static readonly global::Lua.LuaFunction __index = new(global::Lua.Runtime.Metamethods.Index, (_context, _) =>
        {
            var _this = _context.GetArgument<LuaTexture>(0);
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
            var _this = _context.GetArgument<LuaTexture>(0);
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
        public new global::Lua.LuaTable Metatable
        {
            get => s_Metatable ??= CreateMetatable();
            set => throw new global::System.NotSupportedException("LuaObject metatables cannot be modified");
        }
        global::System.Span<global::Lua.LuaValue> global::Lua.ILuaUserData.UserValues => default;

        public override global::System.Boolean TryGetLuaValue(global::System.Int32 _key, out global::Lua.LuaValue _value, global::Luny.ILuaObjectFactory _factory)
        {
            return base.TryGetLuaValue(_key, out _value, _factory);
        }
        public override global::System.Boolean TryGetLuaValue(global::System.String _key, out global::Lua.LuaValue _value, global::Luny.ILuaObjectFactory _factory)
        {
            switch (_key)
            {
                case "IncrementUpdateCount": _value = _LuaTexture_IncrementUpdateCount; return true;
                case "anisoLevel": _value = new global::Lua.LuaValue(Instance.anisoLevel); return true;
                case "dimension": _value = new global::Lua.LuaValue((global::System.Int64)Instance.dimension); return true;
                case "filterMode": _value = new global::Lua.LuaValue((global::System.Int64)Instance.filterMode); return true;
                case "graphicsFormat": _value = new global::Lua.LuaValue((global::System.Int64)Instance.graphicsFormat); return true;
                case "graphicsTexture": _value = _factory.Bind(Instance.graphicsTexture); return true;
                case "height": _value = new global::Lua.LuaValue(Instance.height); return true;
                case "isDataSRGB": _value = new global::Lua.LuaValue(Instance.isDataSRGB); return true;
                case "isReadable": _value = new global::Lua.LuaValue(Instance.isReadable); return true;
                case "mipMapBias": _value = new global::Lua.LuaValue(Instance.mipMapBias); return true;
                case "mipmapCount": _value = new global::Lua.LuaValue(Instance.mipmapCount); return true;
                case "texelSize": _value = global::Luny.UnityEngine.LuaVector2.Bind(Instance.texelSize); return true;
                case "updateCount": _value = new global::Lua.LuaValue(Instance.updateCount); return true;
                case "width": _value = new global::Lua.LuaValue(Instance.width); return true;
                case "wrapMode": _value = new global::Lua.LuaValue((global::System.Int64)Instance.wrapMode); return true;
                case "wrapModeU": _value = new global::Lua.LuaValue((global::System.Int64)Instance.wrapModeU); return true;
                case "wrapModeV": _value = new global::Lua.LuaValue((global::System.Int64)Instance.wrapModeV); return true;
                case "wrapModeW": _value = new global::Lua.LuaValue((global::System.Int64)Instance.wrapModeW); return true;
                default: return base.TryGetLuaValue(_key, out _value, _factory);
            }
        }
        public override global::System.Boolean TrySetLuaValue(global::System.Int32 _key, global::Lua.LuaValue _value)
        {
            return base.TrySetLuaValue(_key, _value);
        }
        public override global::System.Boolean TrySetLuaValue(global::System.String _key, global::Lua.LuaValue _value)
        {
            switch (_key)
            {
                case "anisoLevel": Instance.anisoLevel = _value.Read<global::System.Int32>();  return true;
                case "dimension": Instance.dimension = _value.Read<global::UnityEngine.Rendering.TextureDimension>();  return true;
                case "filterMode": Instance.filterMode = _value.Read<global::UnityEngine.FilterMode>();  return true;
                case "height": Instance.height = _value.Read<global::System.Int32>();  return true;
                case "mipMapBias": Instance.mipMapBias = _value.Read<global::System.Single>();  return true;
                case "width": Instance.width = _value.Read<global::System.Int32>();  return true;
                case "wrapMode": Instance.wrapMode = _value.Read<global::UnityEngine.TextureWrapMode>();  return true;
                case "wrapModeU": Instance.wrapModeU = _value.Read<global::UnityEngine.TextureWrapMode>();  return true;
                case "wrapModeV": Instance.wrapModeV = _value.Read<global::UnityEngine.TextureWrapMode>();  return true;
                case "wrapModeW": Instance.wrapModeW = _value.Read<global::UnityEngine.TextureWrapMode>();  return true;
                default: return base.TrySetLuaValue(_key, _value);
            }
        }
    }
    public sealed class LuaTextureType : global::Luny.ILuaStatic
    {
        public static global::Lua.LuaValue Bind() => new LuaTextureType();
        private LuaTextureType() {}
        public static implicit operator global::Lua.LuaValue(LuaTextureType value) => new(value);
        public global::System.Type BindType => typeof(global::UnityEngine.Texture);
        public override global::System.String ToString() => BindType.FullName;
#if UNITY_EDITOR
        [global::UnityEngine.RuntimeInitializeOnLoadMethod(global::UnityEngine.RuntimeInitializeLoadType.SubsystemRegistration)]
        private static void ResetStaticFields() => s_Metatable = null;
#endif

        private static readonly global::Lua.LuaFunction _LuaTexture_SetGlobalAnisotropicFilteringLimits = new global::Lua.LuaFunction("SetGlobalAnisotropicFilteringLimits", (_context, _) =>
        {
            global::Lua.LuaValue _lastArg = default;
            global::System.Int32 _lastArgPos = default;
            global::System.Type _expectedType = default;
            var _argCount = _context.ArgumentCount;
            var _arg0 = _lastArg = _argCount > 0 ? _context.GetArgument(0) : global::Lua.LuaValue.Nil;
            _lastArgPos = 0; _expectedType = typeof(global::System.Int32);
            if (_arg0.TryRead<global::System.Int32>(out var _p0_System_Int32))
            {
                var _arg1 = _lastArg = _argCount > 1 ? _context.GetArgument(1) : global::Lua.LuaValue.Nil;
                _lastArgPos = 1; _expectedType = typeof(global::System.Int32);
                if (_arg1.TryRead<global::System.Int32>(out var _p1_System_Int32))
                {
                    if (_argCount == 2)
                    {
                        var forcedMin = _p0_System_Int32;
                        var globalMax = _p1_System_Int32;
                        global::UnityEngine.Texture.SetGlobalAnisotropicFilteringLimits(forcedMin, globalMax);
                        var _retCount = _context.Return();
                        return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                    }
                }
            }
            throw new global::Lua.LuaRuntimeException(_context.Thread, $"{"SetGlobalAnisotropicFilteringLimits"}: invalid argument #{_lastArgPos}: {_lastArg} ({_lastArg.Type}), expected: {_expectedType.FullName}", 2);
        });
        private static readonly global::Lua.LuaFunction _LuaTexture_SetStreamingTextureMaterialDebugProperties = new global::Lua.LuaFunction("SetStreamingTextureMaterialDebugProperties", (_context, _) =>
        {
            global::Lua.LuaValue _lastArg = default;
            global::System.Int32 _lastArgPos = default;
            global::System.Type _expectedType = default;
            var _argCount = _context.ArgumentCount;
            if (_argCount == 0)
            {
                global::UnityEngine.Texture.SetStreamingTextureMaterialDebugProperties();
                var _retCount = _context.Return();
                return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
            }
            var _arg0 = _lastArg = _argCount > 0 ? _context.GetArgument(0) : global::Lua.LuaValue.Nil;
            _lastArgPos = 0; _expectedType = typeof(global::System.Int32);
            if (_arg0.TryRead<global::System.Int32>(out var _p0_System_Int32))
            {
                if (_argCount == 1)
                {
                    var materialTextureSlot = _p0_System_Int32;
                    global::UnityEngine.Texture.SetStreamingTextureMaterialDebugProperties(materialTextureSlot);
                    var _retCount = _context.Return();
                    return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                }
            }
            throw new global::Lua.LuaRuntimeException(_context.Thread, $"{"SetStreamingTextureMaterialDebugProperties"}: invalid argument #{_lastArgPos}: {_lastArg} ({_lastArg.Type}), expected: {_expectedType.FullName}", 2);
        });
        private static readonly global::Lua.LuaFunction __index = new(global::Lua.Runtime.Metamethods.Index, (_context, _) =>
        {
            var _this = _context.GetArgument<LuaTextureType>(0);
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
            var _this = _context.GetArgument<LuaTextureType>(0);
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
                case "SetGlobalAnisotropicFilteringLimits": _value = _LuaTexture_SetGlobalAnisotropicFilteringLimits; return true;
                case "SetStreamingTextureMaterialDebugProperties": _value = _LuaTexture_SetStreamingTextureMaterialDebugProperties; return true;
                case "allowThreadedTextureCreation": _value = new global::Lua.LuaValue(global::UnityEngine.Texture.allowThreadedTextureCreation); return true;
                case "anisotropicFiltering": _value = new global::Lua.LuaValue((global::System.Int64)global::UnityEngine.Texture.anisotropicFiltering); return true;
                case "currentTextureMemory": _value = new global::Lua.LuaValue(global::UnityEngine.Texture.currentTextureMemory); return true;
                case "desiredTextureMemory": _value = new global::Lua.LuaValue(global::UnityEngine.Texture.desiredTextureMemory); return true;
                case "nonStreamingTextureCount": _value = new global::Lua.LuaValue(global::UnityEngine.Texture.nonStreamingTextureCount); return true;
                case "nonStreamingTextureMemory": _value = new global::Lua.LuaValue(global::UnityEngine.Texture.nonStreamingTextureMemory); return true;
                case "streamingMipmapUploadCount": _value = new global::Lua.LuaValue(global::UnityEngine.Texture.streamingMipmapUploadCount); return true;
                case "streamingRendererCount": _value = new global::Lua.LuaValue(global::UnityEngine.Texture.streamingRendererCount); return true;
                case "streamingTextureCount": _value = new global::Lua.LuaValue(global::UnityEngine.Texture.streamingTextureCount); return true;
                case "streamingTextureDiscardUnusedMips": _value = new global::Lua.LuaValue(global::UnityEngine.Texture.streamingTextureDiscardUnusedMips); return true;
                case "streamingTextureForceLoadAll": _value = new global::Lua.LuaValue(global::UnityEngine.Texture.streamingTextureForceLoadAll); return true;
                case "streamingTextureLoadingCount": _value = new global::Lua.LuaValue(global::UnityEngine.Texture.streamingTextureLoadingCount); return true;
                case "streamingTexturePendingLoadCount": _value = new global::Lua.LuaValue(global::UnityEngine.Texture.streamingTexturePendingLoadCount); return true;
                case "targetTextureMemory": _value = new global::Lua.LuaValue(global::UnityEngine.Texture.targetTextureMemory); return true;
                case "totalTextureMemory": _value = new global::Lua.LuaValue(global::UnityEngine.Texture.totalTextureMemory); return true;
                case "GenerateAllMips": _value = new global::Lua.LuaValue(global::UnityEngine.Texture.GenerateAllMips); return true;
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
                case "allowThreadedTextureCreation": global::UnityEngine.Texture.allowThreadedTextureCreation = _value.Read<global::System.Boolean>();  return true;
                case "anisotropicFiltering": global::UnityEngine.Texture.anisotropicFiltering = _value.Read<global::UnityEngine.AnisotropicFiltering>();  return true;
                case "streamingTextureDiscardUnusedMips": global::UnityEngine.Texture.streamingTextureDiscardUnusedMips = _value.Read<global::System.Boolean>();  return true;
                case "streamingTextureForceLoadAll": global::UnityEngine.Texture.streamingTextureForceLoadAll = _value.Read<global::System.Boolean>();  return true;
                default: return false;
            }
        }
    }
}
#pragma warning restore 0109, 0162, 0168, 0219
#endif
