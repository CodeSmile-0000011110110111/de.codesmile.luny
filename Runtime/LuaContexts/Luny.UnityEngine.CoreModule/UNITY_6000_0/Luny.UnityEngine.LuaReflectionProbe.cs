
// --------------------------------------------------------------
// GENERATED FILE ----> DO NOT EDIT <---- CHANGES WILL BE LOST !!
// --------------------------------------------------------------

#if UNITY_6000_0_OR_NEWER && !(UNITY_6000_1_OR_NEWER)
#pragma warning disable 0109, 0162, 0168, 0219
using Luny;

namespace Luny.UnityEngine
{
    public sealed class LuaReflectionProbe : LuaBehaviour, global::Luny.ILuaObject<global::UnityEngine.ReflectionProbe>
    {
        public new static global::Lua.LuaValue Bind(global::UnityEngine.ReflectionProbe instance) => new LuaReflectionProbe(instance);
        public new static global::Lua.LuaValue Bind(global::System.Object instance) => Bind((global::UnityEngine.ReflectionProbe)instance);
        public new static global::Lua.LuaValue Bind(global::System.Collections.Generic.IList<global::UnityEngine.ReflectionProbe> instances) =>
            new global::Luny.LuaList<global::UnityEngine.ReflectionProbe>(instances);
        public new static global::Lua.LuaValue Bind(global::System.Collections.Generic.IList<global::System.Object> instances) =>
            new global::Luny.LuaList<global::UnityEngine.ReflectionProbe>(instances);
        private LuaReflectionProbe(global::UnityEngine.ReflectionProbe instance) : base(instance) {}
        public static implicit operator global::Lua.LuaValue(LuaReflectionProbe value) => new(value);
        public new global::UnityEngine.ReflectionProbe Instance => (global::UnityEngine.ReflectionProbe)m_Instance;
        public new global::System.Type BindType => typeof(global::UnityEngine.ReflectionProbe);
        private static global::Lua.LuaTable s_Metatable;
        public new global::Lua.LuaTable Metatable
        {
            get => s_Metatable ??= global::Luny.LuaMetatable.Create(__index, __newindex);
            set => throw new global::System.NotSupportedException("LuaObject metatables cannot be modified");
        }
        global::System.Span<global::Lua.LuaValue> global::Lua.ILuaUserData.UserValues => default;
        public override global::System.String ToString() => m_Instance != null ? Instance.ToString() : "{GetType().Name}(null)";
#if UNITY_EDITOR
        [global::UnityEngine.RuntimeInitializeOnLoadMethod(global::UnityEngine.RuntimeInitializeLoadType.SubsystemRegistration)]
        private static void ResetStaticFields() => s_Metatable = null;
#endif

        private static readonly global::Lua.LuaFunction _LuaReflectionProbe_IsFinishedRendering = new global::Lua.LuaFunction("IsFinishedRendering", (_context, _) =>
        {
            global::Lua.LuaValue _lastArg = default;
            global::System.Int32 _lastArgPos = default;
            global::System.Type _expectedType = default;
            var _argCount = _context.ArgumentCount;
            var _this = _context.GetArgument<LuaReflectionProbe>(0);
            var _arg0 = _lastArg = _argCount > 1 ? _context.GetArgument(1) : global::Lua.LuaValue.Nil;
            _lastArgPos = 0; _expectedType = typeof(global::System.Int32);
            if (_arg0.TryRead<global::System.Int32>(out var _p0_System_Int32))
            {
                if (_argCount == 2)
                {
                    var renderId = _p0_System_Int32;
                    var _ret0 = _this.Instance.IsFinishedRendering(renderId);
                    var _lret0 = new global::Lua.LuaValue(_ret0);
                    var _retCount = _context.Return(_lret0);
                    return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                }
            }
            throw new global::Lua.LuaRuntimeException(_context.Thread, $"{"IsFinishedRendering"}: invalid argument #{_lastArgPos}: {_lastArg} ({_lastArg.Type}), expected: {_expectedType.FullName}", 2);
        });
        private static readonly global::Lua.LuaFunction _LuaReflectionProbe_RenderProbe = new global::Lua.LuaFunction("RenderProbe", (_context, _) =>
        {
            global::Lua.LuaValue _lastArg = default;
            global::System.Int32 _lastArgPos = default;
            global::System.Type _expectedType = default;
            var _argCount = _context.ArgumentCount;
            var _this = _context.GetArgument<LuaReflectionProbe>(0);
            if (_argCount == 1)
            {
                var _ret0 = _this.Instance.RenderProbe();
                var _lret0 = new global::Lua.LuaValue(_ret0);
                var _retCount = _context.Return(_lret0);
                return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
            }
            var _arg0 = _lastArg = _argCount > 1 ? _context.GetArgument(1) : global::Lua.LuaValue.Nil;
            _lastArgPos = 0; _expectedType = typeof(global::Luny.UnityEngine.LuaRenderTexture);
            if (_arg0.TryRead<global::Luny.UnityEngine.LuaRenderTexture>(out var _p0_UnityEngine_RenderTexture))
            {
                if (_argCount == 2)
                {
                    var targetTexture = _p0_UnityEngine_RenderTexture.Instance;
                    var _ret0 = _this.Instance.RenderProbe(targetTexture);
                    var _lret0 = new global::Lua.LuaValue(_ret0);
                    var _retCount = _context.Return(_lret0);
                    return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                }
            }
            throw new global::Lua.LuaRuntimeException(_context.Thread, $"{"RenderProbe"}: invalid argument #{_lastArgPos}: {_lastArg} ({_lastArg.Type}), expected: {_expectedType.FullName}", 2);
        });
        private static readonly global::Lua.LuaFunction _LuaReflectionProbe_Reset = new global::Lua.LuaFunction("Reset", (_context, _) =>
        {
            global::Lua.LuaValue _lastArg = default;
            global::System.Int32 _lastArgPos = default;
            global::System.Type _expectedType = default;
            var _argCount = _context.ArgumentCount;
            var _this = _context.GetArgument<LuaReflectionProbe>(0);
            if (_argCount == 1)
            {
                _this.Instance.Reset();
                var _retCount = _context.Return();
                return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
            }
            throw new global::Lua.LuaRuntimeException(_context.Thread, $"{"Reset"}: invalid argument #{_lastArgPos}: {_lastArg} ({_lastArg.Type}), expected: {_expectedType.FullName}", 2);
        });
        private static readonly global::Lua.LuaFunction __index = new(global::Lua.Runtime.Metamethods.Index, (_context, _) =>
        {
            var _this = _context.GetArgument<LuaReflectionProbe>(0);
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
            var _this = _context.GetArgument<LuaReflectionProbe>(0);
            var _key = _context.GetArgument(1);
            var _value = _context.GetArgument(2);
            if (_key.Type == global::Lua.LuaValueType.Number && _key.TryRead<global::System.Int32>(out var _index) && _this.TrySetLuaValue(_index, _value))
                return new global::System.Threading.Tasks.ValueTask<global::System.Int32>(_context.Return(_value));
            if (_key.Type == global::Lua.LuaValueType.String && _this.TrySetLuaValue(_key.Read<global::System.String>(), _value))
                return new global::System.Threading.Tasks.ValueTask<global::System.Int32>(_context.Return(_value));
            throw new global::Lua.LuaRuntimeException(_context.Thread, $"attempt to assign to unknown '{_key}' on '{_this}'", 2);
        });

        public override global::System.Boolean TryGetLuaValue(global::System.Int32 _key, out global::Lua.LuaValue _value, global::Luny.ILuaObjectFactory _factory)
        {
            return base.TryGetLuaValue(_key, out _value, _factory);
        }
        public override global::System.Boolean TryGetLuaValue(global::System.String _key, out global::Lua.LuaValue _value, global::Luny.ILuaObjectFactory _factory)
        {
            switch (_key)
            {
                case "IsFinishedRendering": _value = _LuaReflectionProbe_IsFinishedRendering; return true;
                case "RenderProbe": _value = _LuaReflectionProbe_RenderProbe; return true;
                case "Reset": _value = _LuaReflectionProbe_Reset; return true;
                case "backgroundColor": _value = global::Luny.UnityEngine.LuaColor.Bind(Instance.backgroundColor); return true;
                case "bakedTexture": _value = _factory.Bind(Instance.bakedTexture); return true;
                case "blendDistance": _value = new global::Lua.LuaValue(Instance.blendDistance); return true;
                case "bounds": _value = global::Luny.UnityEngine.LuaBounds.Bind(Instance.bounds); return true;
                case "boxProjection": _value = new global::Lua.LuaValue(Instance.boxProjection); return true;
                case "center": _value = global::Luny.UnityEngine.LuaVector3.Bind(Instance.center); return true;
                case "clearFlags": _value = new global::Lua.LuaValue((global::System.Int64)Instance.clearFlags); return true;
                case "cullingMask": _value = new global::Lua.LuaValue(Instance.cullingMask); return true;
                case "customBakedTexture": _value = _factory.Bind(Instance.customBakedTexture); return true;
                case "farClipPlane": _value = new global::Lua.LuaValue(Instance.farClipPlane); return true;
                case "hdr": _value = new global::Lua.LuaValue(Instance.hdr); return true;
                case "importance": _value = new global::Lua.LuaValue(Instance.importance); return true;
                case "intensity": _value = new global::Lua.LuaValue(Instance.intensity); return true;
                case "mode": _value = new global::Lua.LuaValue((global::System.Int64)Instance.mode); return true;
                case "nearClipPlane": _value = new global::Lua.LuaValue(Instance.nearClipPlane); return true;
                case "realtimeTexture": _value = _factory.Bind(Instance.realtimeTexture); return true;
                case "refreshMode": _value = new global::Lua.LuaValue((global::System.Int64)Instance.refreshMode); return true;
                case "renderDynamicObjects": _value = new global::Lua.LuaValue(Instance.renderDynamicObjects); return true;
                case "resolution": _value = new global::Lua.LuaValue(Instance.resolution); return true;
                case "shadowDistance": _value = new global::Lua.LuaValue(Instance.shadowDistance); return true;
                case "size": _value = global::Luny.UnityEngine.LuaVector3.Bind(Instance.size); return true;
                case "texture": _value = _factory.Bind(Instance.texture); return true;
                case "textureHDRDecodeValues": _value = global::Luny.UnityEngine.LuaVector4.Bind(Instance.textureHDRDecodeValues); return true;
                case "timeSlicingMode": _value = new global::Lua.LuaValue((global::System.Int64)Instance.timeSlicingMode); return true;
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
                case "backgroundColor": Instance.backgroundColor = _value.Read<global::Luny.UnityEngine.LuaColor>().Value;  return true;
                case "bakedTexture": Instance.bakedTexture = _value.Read<global::Luny.UnityEngine.LuaTexture>().Instance;  return true;
                case "blendDistance": Instance.blendDistance = _value.Read<global::System.Single>();  return true;
                case "boxProjection": Instance.boxProjection = _value.Read<global::System.Boolean>();  return true;
                case "center": Instance.center = _value.Read<global::Luny.UnityEngine.LuaVector3>().Value;  return true;
                case "clearFlags": Instance.clearFlags = _value.Read<global::UnityEngine.Rendering.ReflectionProbeClearFlags>();  return true;
                case "cullingMask": Instance.cullingMask = _value.Read<global::System.Int32>();  return true;
                case "customBakedTexture": Instance.customBakedTexture = _value.Read<global::Luny.UnityEngine.LuaTexture>().Instance;  return true;
                case "farClipPlane": Instance.farClipPlane = _value.Read<global::System.Single>();  return true;
                case "hdr": Instance.hdr = _value.Read<global::System.Boolean>();  return true;
                case "importance": Instance.importance = _value.Read<global::System.Int32>();  return true;
                case "intensity": Instance.intensity = _value.Read<global::System.Single>();  return true;
                case "mode": Instance.mode = _value.Read<global::UnityEngine.Rendering.ReflectionProbeMode>();  return true;
                case "nearClipPlane": Instance.nearClipPlane = _value.Read<global::System.Single>();  return true;
                case "realtimeTexture": Instance.realtimeTexture = _value.Read<global::Luny.UnityEngine.LuaRenderTexture>().Instance;  return true;
                case "refreshMode": Instance.refreshMode = _value.Read<global::UnityEngine.Rendering.ReflectionProbeRefreshMode>();  return true;
                case "renderDynamicObjects": Instance.renderDynamicObjects = _value.Read<global::System.Boolean>();  return true;
                case "resolution": Instance.resolution = _value.Read<global::System.Int32>();  return true;
                case "shadowDistance": Instance.shadowDistance = _value.Read<global::System.Single>();  return true;
                case "size": Instance.size = _value.Read<global::Luny.UnityEngine.LuaVector3>().Value;  return true;
                case "timeSlicingMode": Instance.timeSlicingMode = _value.Read<global::UnityEngine.Rendering.ReflectionProbeTimeSlicingMode>();  return true;
                default: return base.TrySetLuaValue(_key, _value);
            }
        }
    }
    public sealed class LuaReflectionProbeType : global::Luny.ILuaStatic
    {
        public static global::Lua.LuaValue Bind() => new LuaReflectionProbeType();
        private LuaReflectionProbeType() {}
        public static implicit operator global::Lua.LuaValue(LuaReflectionProbeType value) => new(value);
        public global::System.Type BindType => typeof(global::UnityEngine.ReflectionProbe);
        private static global::Lua.LuaTable s_Metatable;
        public global::Lua.LuaTable Metatable
        {
            get => s_Metatable ??= global::Luny.LuaMetatable.Create(__index, __newindex);
            set => throw new global::System.NotSupportedException("LuaObject metatables cannot be modified");
        }
        global::System.Span<global::Lua.LuaValue> global::Lua.ILuaUserData.UserValues => default;
        public override global::System.String ToString() => BindType.FullName;
#if UNITY_EDITOR
        [global::UnityEngine.RuntimeInitializeOnLoadMethod(global::UnityEngine.RuntimeInitializeLoadType.SubsystemRegistration)]
        private static void ResetStaticFields() => s_Metatable = null;
#endif

        private static readonly global::Lua.LuaFunction _LuaReflectionProbe_new = new global::Lua.LuaFunction(".ctor", (_context, _) =>
        {
            global::Lua.LuaValue _lastArg = default;
            global::System.Int32 _lastArgPos = default;
            global::System.Type _expectedType = default;
            var _argCount = _context.ArgumentCount;
            if (_argCount == 0)
            {
                var _ret0 = new global::UnityEngine.ReflectionProbe();
                var _factory = _context.GetObjectFactory();
                var _lret0 = _factory.Bind(_ret0);
                var _retCount = _context.Return(_lret0);
                return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
            }
            throw new global::Lua.LuaRuntimeException(_context.Thread, $"{".ctor"}: invalid argument #{_lastArgPos}: {_lastArg} ({_lastArg.Type}), expected: {_expectedType.FullName}", 2);
        });
        private static readonly global::Lua.LuaFunction _LuaReflectionProbe_BlendCubemap = new global::Lua.LuaFunction("BlendCubemap", (_context, _) =>
        {
            global::Lua.LuaValue _lastArg = default;
            global::System.Int32 _lastArgPos = default;
            global::System.Type _expectedType = default;
            var _argCount = _context.ArgumentCount;
            var _arg0 = _lastArg = _argCount > 0 ? _context.GetArgument(0) : global::Lua.LuaValue.Nil;
            _lastArgPos = 0; _expectedType = typeof(global::Luny.UnityEngine.LuaTexture);
            if (_arg0.TryRead<global::Luny.UnityEngine.LuaTexture>(out var _p0_UnityEngine_Texture))
            {
                var _arg1 = _lastArg = _argCount > 1 ? _context.GetArgument(1) : global::Lua.LuaValue.Nil;
                _lastArgPos = 1; _expectedType = typeof(global::Luny.UnityEngine.LuaTexture);
                if (_arg1.TryRead<global::Luny.UnityEngine.LuaTexture>(out var _p1_UnityEngine_Texture))
                {
                    var _arg2 = _lastArg = _argCount > 2 ? _context.GetArgument(2) : global::Lua.LuaValue.Nil;
                    _lastArgPos = 2; _expectedType = typeof(global::System.Single);
                    if (_arg2.TryRead<global::System.Single>(out var _p2_System_Single))
                    {
                        var _arg3 = _lastArg = _argCount > 3 ? _context.GetArgument(3) : global::Lua.LuaValue.Nil;
                        _lastArgPos = 3; _expectedType = typeof(global::Luny.UnityEngine.LuaRenderTexture);
                        if (_arg3.TryRead<global::Luny.UnityEngine.LuaRenderTexture>(out var _p3_UnityEngine_RenderTexture))
                        {
                            if (_argCount == 4)
                            {
                                var src = _p0_UnityEngine_Texture.Instance;
                                var dst = _p1_UnityEngine_Texture.Instance;
                                var blend = _p2_System_Single;
                                var target = _p3_UnityEngine_RenderTexture.Instance;
                                var _ret0 = global::UnityEngine.ReflectionProbe.BlendCubemap(src, dst, blend, target);
                                var _lret0 = new global::Lua.LuaValue(_ret0);
                                var _retCount = _context.Return(_lret0);
                                return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                            }
                        }
                    }
                }
            }
            throw new global::Lua.LuaRuntimeException(_context.Thread, $"{"BlendCubemap"}: invalid argument #{_lastArgPos}: {_lastArg} ({_lastArg.Type}), expected: {_expectedType.FullName}", 2);
        });
        private static readonly global::Lua.LuaFunction _LuaReflectionProbe_UpdateCachedState = new global::Lua.LuaFunction("UpdateCachedState", (_context, _) =>
        {
            global::Lua.LuaValue _lastArg = default;
            global::System.Int32 _lastArgPos = default;
            global::System.Type _expectedType = default;
            var _argCount = _context.ArgumentCount;
            if (_argCount == 0)
            {
                global::UnityEngine.ReflectionProbe.UpdateCachedState();
                var _retCount = _context.Return();
                return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
            }
            throw new global::Lua.LuaRuntimeException(_context.Thread, $"{"UpdateCachedState"}: invalid argument #{_lastArgPos}: {_lastArg} ({_lastArg.Type}), expected: {_expectedType.FullName}", 2);
        });
        private static readonly global::Lua.LuaFunction __index = new(global::Lua.Runtime.Metamethods.Index, (_context, _) =>
        {
            var _this = _context.GetArgument<LuaReflectionProbeType>(0);
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
            var _this = _context.GetArgument<LuaReflectionProbeType>(0);
            var _key = _context.GetArgument(1);
            var _value = _context.GetArgument(2);
            if (_key.Type == global::Lua.LuaValueType.Number && _key.TryRead<global::System.Int32>(out var _index) && _this.TrySetLuaValue(_index, _value))
                return new global::System.Threading.Tasks.ValueTask<global::System.Int32>(_context.Return(_value));
            if (_key.Type == global::Lua.LuaValueType.String && _this.TrySetLuaValue(_key.Read<global::System.String>(), _value))
                return new global::System.Threading.Tasks.ValueTask<global::System.Int32>(_context.Return(_value));
            throw new global::Lua.LuaRuntimeException(_context.Thread, $"attempt to assign to unknown '{_key}' on '{_this}'", 2);
        });

        public global::System.Boolean TryGetLuaValue(global::System.Int32 _key, out global::Lua.LuaValue _value, global::Luny.ILuaObjectFactory _factory)
        {
            _value = global::Lua.LuaValue.Nil; return false;
        }
        public global::System.Boolean TryGetLuaValue(global::System.String _key, out global::Lua.LuaValue _value, global::Luny.ILuaObjectFactory _factory)
        {
            switch (_key)
            {
                case "new": _value = _LuaReflectionProbe_new; return true;
                case "BlendCubemap": _value = _LuaReflectionProbe_BlendCubemap; return true;
                case "UpdateCachedState": _value = _LuaReflectionProbe_UpdateCachedState; return true;
                case "defaultTexture": _value = _factory.Bind(global::UnityEngine.ReflectionProbe.defaultTexture); return true;
                case "defaultTextureHDRDecodeValues": _value = global::Luny.UnityEngine.LuaVector4.Bind(global::UnityEngine.ReflectionProbe.defaultTextureHDRDecodeValues); return true;
                case "maxBakedCubemapResolution": _value = new global::Lua.LuaValue(global::UnityEngine.ReflectionProbe.maxBakedCubemapResolution); return true;
                case "minBakedCubemapResolution": _value = new global::Lua.LuaValue(global::UnityEngine.ReflectionProbe.minBakedCubemapResolution); return true;
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
