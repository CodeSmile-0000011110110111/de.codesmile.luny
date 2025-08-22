
// --------------------------------------------------------------
// GENERATED FILE ----> DO NOT EDIT <---- CHANGES WILL BE LOST !!
// --------------------------------------------------------------

#if UNITY_6000_2_OR_NEWER && !(UNITY_6000_3_OR_NEWER)
#pragma warning disable 0109, 0162, 0168, 0219
using Luny;

namespace Luny.UnityEngine
{
    public sealed class LuaCustomRenderTexture : global::Luny.UnityEngine.LuaRenderTexture, global::Luny.ILuaObject<global::UnityEngine.CustomRenderTexture>
    {
        public new static global::Lua.LuaValue Bind(global::UnityEngine.CustomRenderTexture instance) => new LuaCustomRenderTexture(instance);
        public new static global::Lua.LuaValue Bind(global::System.Object instance) => Bind((global::UnityEngine.CustomRenderTexture)instance);
        public new static global::Lua.LuaValue Bind(global::System.Collections.Generic.IList<global::UnityEngine.CustomRenderTexture> instances) =>
            new global::Luny.LuaList<global::UnityEngine.CustomRenderTexture>(instances);
        public new static global::Lua.LuaValue Bind(global::System.Collections.Generic.IList<global::System.Object> instances) =>
            new global::Luny.LuaList<global::UnityEngine.CustomRenderTexture>(instances);
        private LuaCustomRenderTexture(global::UnityEngine.CustomRenderTexture instance) : base(instance) {}
        public static implicit operator global::Lua.LuaValue(LuaCustomRenderTexture value) => new(value);
        public new global::UnityEngine.CustomRenderTexture Instance => (global::UnityEngine.CustomRenderTexture)m_Instance;
        public new global::System.Type BindType => typeof(global::UnityEngine.CustomRenderTexture);
        public override global::System.String ToString() => m_Instance != null ? Instance.ToString() : "{GetType().Name}(null)";
#if UNITY_EDITOR
        [global::UnityEngine.RuntimeInitializeOnLoadMethod(global::UnityEngine.RuntimeInitializeLoadType.SubsystemRegistration)]
        private static void ResetStaticFields() => s_Metatable = null;
#endif

        private static readonly global::Lua.LuaFunction _LuaCustomRenderTexture_ClearUpdateZones = new global::Lua.LuaFunction("ClearUpdateZones", (_context, _) =>
        {
            global::Lua.LuaValue _lastArg = default;
            global::System.Int32 _lastArgPos = default;
            global::System.Type _expectedType = default;
            var _argCount = _context.ArgumentCount;
            var _this = _context.GetArgument<LuaCustomRenderTexture>(0);
            if (_argCount == 1)
            {
                _this.Instance.ClearUpdateZones();
                var _retCount = _context.Return();
                return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
            }
            throw new global::Lua.LuaRuntimeException(_context.Thread, $"{"ClearUpdateZones"}: invalid argument #{_lastArgPos}: {_lastArg} ({_lastArg.Type}), expected: {_expectedType.FullName}", 2);
        });
        private static readonly global::Lua.LuaFunction _LuaCustomRenderTexture_EnsureDoubleBufferConsistency = new global::Lua.LuaFunction("EnsureDoubleBufferConsistency", (_context, _) =>
        {
            global::Lua.LuaValue _lastArg = default;
            global::System.Int32 _lastArgPos = default;
            global::System.Type _expectedType = default;
            var _argCount = _context.ArgumentCount;
            var _this = _context.GetArgument<LuaCustomRenderTexture>(0);
            if (_argCount == 1)
            {
                _this.Instance.EnsureDoubleBufferConsistency();
                var _retCount = _context.Return();
                return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
            }
            throw new global::Lua.LuaRuntimeException(_context.Thread, $"{"EnsureDoubleBufferConsistency"}: invalid argument #{_lastArgPos}: {_lastArg} ({_lastArg.Type}), expected: {_expectedType.FullName}", 2);
        });
        private static readonly global::Lua.LuaFunction _LuaCustomRenderTexture_GetDoubleBufferRenderTexture = new global::Lua.LuaFunction("GetDoubleBufferRenderTexture", (_context, _) =>
        {
            global::Lua.LuaValue _lastArg = default;
            global::System.Int32 _lastArgPos = default;
            global::System.Type _expectedType = default;
            var _argCount = _context.ArgumentCount;
            var _this = _context.GetArgument<LuaCustomRenderTexture>(0);
            if (_argCount == 1)
            {
                var _ret0 = _this.Instance.GetDoubleBufferRenderTexture();
                var _factory = _context.GetObjectFactory();
                var _lret0 = _factory.Bind(_ret0);
                var _retCount = _context.Return(_lret0);
                return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
            }
            throw new global::Lua.LuaRuntimeException(_context.Thread, $"{"GetDoubleBufferRenderTexture"}: invalid argument #{_lastArgPos}: {_lastArg} ({_lastArg.Type}), expected: {_expectedType.FullName}", 2);
        });
        private static readonly global::Lua.LuaFunction _LuaCustomRenderTexture_Initialize = new global::Lua.LuaFunction("Initialize", (_context, _) =>
        {
            global::Lua.LuaValue _lastArg = default;
            global::System.Int32 _lastArgPos = default;
            global::System.Type _expectedType = default;
            var _argCount = _context.ArgumentCount;
            var _this = _context.GetArgument<LuaCustomRenderTexture>(0);
            if (_argCount == 1)
            {
                _this.Instance.Initialize();
                var _retCount = _context.Return();
                return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
            }
            throw new global::Lua.LuaRuntimeException(_context.Thread, $"{"Initialize"}: invalid argument #{_lastArgPos}: {_lastArg} ({_lastArg.Type}), expected: {_expectedType.FullName}", 2);
        });
        private static readonly global::Lua.LuaFunction _LuaCustomRenderTexture_SetUpdateZones = new global::Lua.LuaFunction("SetUpdateZones", (_context, _) =>
        {
            global::Lua.LuaValue _lastArg = default;
            global::System.Int32 _lastArgPos = default;
            global::System.Type _expectedType = default;
            var _argCount = _context.ArgumentCount;
            var _this = _context.GetArgument<LuaCustomRenderTexture>(0);
            var _arg0 = _lastArg = _argCount > 1 ? _context.GetArgument(1) : global::Lua.LuaValue.Nil;
            _lastArgPos = 0; _expectedType = typeof(global::UnityEngine.CustomRenderTextureUpdateZone[]);
            if (_arg0.TryReadArray<global::UnityEngine.CustomRenderTextureUpdateZone>(out var _p0_UnityEngine_CustomRenderTextureUpdateZoneArray))
            {
                if (_argCount == 2)
                {
                    var updateZones = _p0_UnityEngine_CustomRenderTextureUpdateZoneArray;
                    _this.Instance.SetUpdateZones(updateZones);
                    var _retCount = _context.Return();
                    return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                }
            }
            throw new global::Lua.LuaRuntimeException(_context.Thread, $"{"SetUpdateZones"}: invalid argument #{_lastArgPos}: {_lastArg} ({_lastArg.Type}), expected: {_expectedType.FullName}", 2);
        });
        private static readonly global::Lua.LuaFunction _LuaCustomRenderTexture_Update = new global::Lua.LuaFunction("Update", (_context, _) =>
        {
            global::Lua.LuaValue _lastArg = default;
            global::System.Int32 _lastArgPos = default;
            global::System.Type _expectedType = default;
            var _argCount = _context.ArgumentCount;
            var _this = _context.GetArgument<LuaCustomRenderTexture>(0);
            if (_argCount == 1)
            {
                _this.Instance.Update();
                var _retCount = _context.Return();
                return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
            }
            var _arg0 = _lastArg = _argCount > 1 ? _context.GetArgument(1) : global::Lua.LuaValue.Nil;
            _lastArgPos = 0; _expectedType = typeof(global::System.Int32);
            if (_arg0.TryRead<global::System.Int32>(out var _p0_System_Int32))
            {
                if (_argCount == 2)
                {
                    var count = _p0_System_Int32;
                    _this.Instance.Update(count);
                    var _retCount = _context.Return();
                    return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                }
            }
            throw new global::Lua.LuaRuntimeException(_context.Thread, $"{"Update"}: invalid argument #{_lastArgPos}: {_lastArg} ({_lastArg.Type}), expected: {_expectedType.FullName}", 2);
        });
        private static readonly global::Lua.LuaFunction __index = new(global::Lua.Runtime.Metamethods.Index, (_context, _) =>
        {
            var _this = _context.GetArgument<LuaCustomRenderTexture>(0);
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
            var _this = _context.GetArgument<LuaCustomRenderTexture>(0);
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
            var metatable = new global::Lua.LuaTable(0, 5);
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
                case "ClearUpdateZones": _value = _LuaCustomRenderTexture_ClearUpdateZones; return true;
                case "EnsureDoubleBufferConsistency": _value = _LuaCustomRenderTexture_EnsureDoubleBufferConsistency; return true;
                case "GetDoubleBufferRenderTexture": _value = _LuaCustomRenderTexture_GetDoubleBufferRenderTexture; return true;
                case "Initialize": _value = _LuaCustomRenderTexture_Initialize; return true;
                case "SetUpdateZones": _value = _LuaCustomRenderTexture_SetUpdateZones; return true;
                case "Update": _value = _LuaCustomRenderTexture_Update; return true;
                case "cubemapFaceMask": _value = new global::Lua.LuaValue(Instance.cubemapFaceMask); return true;
                case "doubleBuffered": _value = new global::Lua.LuaValue(Instance.doubleBuffered); return true;
                case "initializationColor": _value = global::Luny.UnityEngine.LuaColor.Bind(Instance.initializationColor); return true;
                case "initializationMaterial": _value = _factory.Bind(Instance.initializationMaterial); return true;
                case "initializationMode": _value = new global::Lua.LuaValue((global::System.Int64)Instance.initializationMode); return true;
                case "initializationSource": _value = new global::Lua.LuaValue((global::System.Int64)Instance.initializationSource); return true;
                case "initializationTexture": _value = _factory.Bind(Instance.initializationTexture); return true;
                case "material": _value = _factory.Bind(Instance.material); return true;
                case "shaderPass": _value = new global::Lua.LuaValue(Instance.shaderPass); return true;
                case "updateMode": _value = new global::Lua.LuaValue((global::System.Int64)Instance.updateMode); return true;
                case "updatePeriod": _value = new global::Lua.LuaValue(Instance.updatePeriod); return true;
                case "updateZoneSpace": _value = new global::Lua.LuaValue((global::System.Int64)Instance.updateZoneSpace); return true;
                case "wrapUpdateZones": _value = new global::Lua.LuaValue(Instance.wrapUpdateZones); return true;
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
                case "cubemapFaceMask": Instance.cubemapFaceMask = _value.Read<global::System.UInt32>();  return true;
                case "doubleBuffered": Instance.doubleBuffered = _value.Read<global::System.Boolean>();  return true;
                case "initializationColor": Instance.initializationColor = _value.Read<global::Luny.UnityEngine.LuaColor>().Value;  return true;
                case "initializationMaterial": Instance.initializationMaterial = _value.Read<global::Luny.UnityEngine.LuaMaterial>().Instance;  return true;
                case "initializationMode": Instance.initializationMode = _value.Read<global::UnityEngine.CustomRenderTextureUpdateMode>();  return true;
                case "initializationSource": Instance.initializationSource = _value.Read<global::UnityEngine.CustomRenderTextureInitializationSource>();  return true;
                case "initializationTexture": Instance.initializationTexture = _value.Read<global::Luny.UnityEngine.LuaTexture>().Instance;  return true;
                case "material": Instance.material = _value.Read<global::Luny.UnityEngine.LuaMaterial>().Instance;  return true;
                case "shaderPass": Instance.shaderPass = _value.Read<global::System.Int32>();  return true;
                case "updateMode": Instance.updateMode = _value.Read<global::UnityEngine.CustomRenderTextureUpdateMode>();  return true;
                case "updatePeriod": Instance.updatePeriod = _value.Read<global::System.Single>();  return true;
                case "updateZoneSpace": Instance.updateZoneSpace = _value.Read<global::UnityEngine.CustomRenderTextureUpdateZoneSpace>();  return true;
                case "wrapUpdateZones": Instance.wrapUpdateZones = _value.Read<global::System.Boolean>();  return true;
                default: return base.TrySetLuaValue(_key, _value);
            }
        }
    }
    public sealed class LuaCustomRenderTextureType : global::Luny.ILuaStatic
    {
        public static global::Lua.LuaValue Bind() => new LuaCustomRenderTextureType();
        private LuaCustomRenderTextureType() {}
        public static implicit operator global::Lua.LuaValue(LuaCustomRenderTextureType value) => new(value);
        public global::System.Type BindType => typeof(global::UnityEngine.CustomRenderTexture);
        public override global::System.String ToString() => BindType.FullName;
#if UNITY_EDITOR
        [global::UnityEngine.RuntimeInitializeOnLoadMethod(global::UnityEngine.RuntimeInitializeLoadType.SubsystemRegistration)]
        private static void ResetStaticFields() => s_Metatable = null;
#endif

        private static readonly global::Lua.LuaFunction _LuaCustomRenderTexture_new = new global::Lua.LuaFunction(".ctor", (_context, _) =>
        {
            global::Lua.LuaValue _lastArg = default;
            global::System.Int32 _lastArgPos = default;
            global::System.Type _expectedType = default;
            var _argCount = _context.ArgumentCount;
            var _arg0 = _lastArg = _argCount > 1 ? _context.GetArgument(1) : global::Lua.LuaValue.Nil;
            _lastArgPos = 0; _expectedType = typeof(global::System.Int32);
            if (_arg0.TryRead<global::System.Int32>(out var _p0_System_Int32))
            {
                var _arg1 = _lastArg = _argCount > 2 ? _context.GetArgument(2) : global::Lua.LuaValue.Nil;
                _lastArgPos = 1; _expectedType = typeof(global::System.Int32);
                if (_arg1.TryRead<global::System.Int32>(out var _p1_System_Int32))
                {
                    if (_argCount == 3)
                    {
                        var width = _p0_System_Int32;
                        var height = _p1_System_Int32;
                        var _ret0 = new global::UnityEngine.CustomRenderTexture(width, height);
                        var _factory = _context.GetObjectFactory();
                        var _lret0 = _factory.Bind(_ret0);
                        var _retCount = _context.Return(_lret0);
                        return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                    }
                    var _arg2 = _lastArg = _argCount > 3 ? _context.GetArgument(3) : global::Lua.LuaValue.Nil;
                    _lastArgPos = 2; _expectedType = typeof(global::UnityEngine.Experimental.Rendering.GraphicsFormat);
                    if (_arg2.TryRead<global::UnityEngine.Experimental.Rendering.GraphicsFormat>(out var _p2_UnityEngine_Experimental_Rendering_GraphicsFormat))
                    {
                        if (_argCount == 4)
                        {
                            var width = _p0_System_Int32;
                            var height = _p1_System_Int32;
                            var format = _p2_UnityEngine_Experimental_Rendering_GraphicsFormat;
                            var _ret0 = new global::UnityEngine.CustomRenderTexture(width, height, format);
                            var _factory = _context.GetObjectFactory();
                            var _lret0 = _factory.Bind(_ret0);
                            var _retCount = _context.Return(_lret0);
                            return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                        }
                    }
                    _lastArgPos = 2; _expectedType = typeof(global::UnityEngine.RenderTextureFormat);
                    if (_arg2.TryRead<global::UnityEngine.RenderTextureFormat>(out var _p2_UnityEngine_RenderTextureFormat))
                    {
                        if (_argCount == 4)
                        {
                            var width = _p0_System_Int32;
                            var height = _p1_System_Int32;
                            var format = _p2_UnityEngine_RenderTextureFormat;
                            var _ret0 = new global::UnityEngine.CustomRenderTexture(width, height, format);
                            var _factory = _context.GetObjectFactory();
                            var _lret0 = _factory.Bind(_ret0);
                            var _retCount = _context.Return(_lret0);
                            return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                        }
                        var _arg3 = _lastArg = _argCount > 4 ? _context.GetArgument(4) : global::Lua.LuaValue.Nil;
                        _lastArgPos = 3; _expectedType = typeof(global::UnityEngine.RenderTextureReadWrite);
                        if (_arg3.TryRead<global::UnityEngine.RenderTextureReadWrite>(out var _p3_UnityEngine_RenderTextureReadWrite))
                        {
                            if (_argCount == 5)
                            {
                                var width = _p0_System_Int32;
                                var height = _p1_System_Int32;
                                var format = _p2_UnityEngine_RenderTextureFormat;
                                var readWrite = _p3_UnityEngine_RenderTextureReadWrite;
                                var _ret0 = new global::UnityEngine.CustomRenderTexture(width, height, format, readWrite);
                                var _factory = _context.GetObjectFactory();
                                var _lret0 = _factory.Bind(_ret0);
                                var _retCount = _context.Return(_lret0);
                                return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                            }
                        }
                    }
                    _lastArgPos = 2; _expectedType = typeof(global::UnityEngine.Experimental.Rendering.DefaultFormat);
                    if (_arg2.TryRead<global::UnityEngine.Experimental.Rendering.DefaultFormat>(out var _p2_UnityEngine_Experimental_Rendering_DefaultFormat))
                    {
                        if (_argCount == 4)
                        {
                            var width = _p0_System_Int32;
                            var height = _p1_System_Int32;
                            var defaultFormat = _p2_UnityEngine_Experimental_Rendering_DefaultFormat;
                            var _ret0 = new global::UnityEngine.CustomRenderTexture(width, height, defaultFormat);
                            var _factory = _context.GetObjectFactory();
                            var _lret0 = _factory.Bind(_ret0);
                            var _retCount = _context.Return(_lret0);
                            return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                        }
                    }
                }
            }
            throw new global::Lua.LuaRuntimeException(_context.Thread, $"{".ctor"}: invalid argument #{_lastArgPos}: {_lastArg} ({_lastArg.Type}), expected: {_expectedType.FullName}", 2);
        });
        private static readonly global::Lua.LuaFunction __index = new(global::Lua.Runtime.Metamethods.Index, (_context, _) =>
        {
            var _this = _context.GetArgument<LuaCustomRenderTextureType>(0);
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
            var _this = _context.GetArgument<LuaCustomRenderTextureType>(0);
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
            var metatable = new global::Lua.LuaTable(0, 5);
            metatable[global::Lua.Runtime.Metamethods.Index] = __index;
            metatable[global::Lua.Runtime.Metamethods.NewIndex] = __newindex;
            metatable[global::Lua.Runtime.Metamethods.Concat] = global::Luny.LuaMetatable.ConcatMetamethod;
            metatable[global::Lua.Runtime.Metamethods.ToString] = global::Luny.LuaMetatable.ToStringMetamethod;
            metatable[global::Lua.Runtime.Metamethods.Call] = _LuaCustomRenderTexture_new;
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
