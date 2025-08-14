
// --------------------------------------------------------------
// GENERATED FILE ----> DO NOT EDIT <---- CHANGES WILL BE LOST !!
// --------------------------------------------------------------

#if UNITY_6000_0_OR_NEWER && !(UNITY_6000_1_OR_NEWER)
#pragma warning disable 0109, 0162, 0168, 0219
using Luny;

namespace Luny.UnityEngine
{
    public sealed class LuaLightProbeProxyVolume : LuaBehaviour, global::Luny.ILuaObject<global::UnityEngine.LightProbeProxyVolume>
    {
        public new static global::Lua.LuaValue Bind(global::UnityEngine.LightProbeProxyVolume instance) => new LuaLightProbeProxyVolume(instance);
        public new static global::Lua.LuaValue Bind(global::System.Object instance) => Bind((global::UnityEngine.LightProbeProxyVolume)instance);
        public new static global::Lua.LuaValue Bind(global::System.Collections.Generic.IList<global::UnityEngine.LightProbeProxyVolume> instances) =>
            new global::Luny.LuaList<global::UnityEngine.LightProbeProxyVolume>(instances);
        public new static global::Lua.LuaValue Bind(global::System.Collections.Generic.IList<global::System.Object> instances) =>
            new global::Luny.LuaList<global::UnityEngine.LightProbeProxyVolume>(instances);
        private LuaLightProbeProxyVolume(global::UnityEngine.LightProbeProxyVolume instance) : base(instance) {}
        public static implicit operator global::Lua.LuaValue(LuaLightProbeProxyVolume value) => new(value);
        public new global::UnityEngine.LightProbeProxyVolume Instance => (global::UnityEngine.LightProbeProxyVolume)m_Instance;
        public new global::System.Type BindType => typeof(global::UnityEngine.LightProbeProxyVolume);
        private static global::Lua.LuaTable s_Metatable;
        public new global::Lua.LuaTable Metatable
        {
            get => s_Metatable ??= CreateMetatable();
            set => throw new global::System.NotSupportedException("LuaObject metatables cannot be modified");
        }
        global::System.Span<global::Lua.LuaValue> global::Lua.ILuaUserData.UserValues => default;
        private static global::Lua.LuaTable CreateMetatable()
        {
            var metatable = new global::Lua.LuaTable(0, 5);
            metatable[global::Lua.Runtime.Metamethods.Index] = __index;
            metatable[global::Lua.Runtime.Metamethods.NewIndex] = __newindex;
            metatable[global::Lua.Runtime.Metamethods.Concat] = global::Luny.LuaMetatable.ConcatMetamethod;
            metatable[global::Lua.Runtime.Metamethods.ToString] = global::Luny.LuaMetatable.ToStringMetamethod;
            return metatable;
        }
        public override global::System.String ToString() => m_Instance != null ? Instance.ToString() : "{GetType().Name}(null)";
#if UNITY_EDITOR
        [global::UnityEngine.RuntimeInitializeOnLoadMethod(global::UnityEngine.RuntimeInitializeLoadType.SubsystemRegistration)]
        private static void ResetStaticFields() => s_Metatable = null;
#endif

        private static readonly global::Lua.LuaFunction _LuaLightProbeProxyVolume_Update = new global::Lua.LuaFunction("Update", (_context, _) =>
        {
            global::Lua.LuaValue _lastArg = default;
            global::System.Int32 _lastArgPos = default;
            global::System.Type _expectedType = default;
            var _argCount = _context.ArgumentCount;
            var _this = _context.GetArgument<LuaLightProbeProxyVolume>(0);
            if (_argCount == 1)
            {
                _this.Instance.Update();
                var _retCount = _context.Return();
                return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
            }
            throw new global::Lua.LuaRuntimeException(_context.Thread, $"{"Update"}: invalid argument #{_lastArgPos}: {_lastArg} ({_lastArg.Type}), expected: {_expectedType.FullName}", 2);
        });
        private static readonly global::Lua.LuaFunction __index = new(global::Lua.Runtime.Metamethods.Index, (_context, _) =>
        {
            var _this = _context.GetArgument<LuaLightProbeProxyVolume>(0);
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
            var _this = _context.GetArgument<LuaLightProbeProxyVolume>(0);
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
                case "Update": _value = _LuaLightProbeProxyVolume_Update; return true;
                case "boundingBoxMode": _value = new global::Lua.LuaValue((global::System.Int64)Instance.boundingBoxMode); return true;
                case "boundsGlobal": _value = global::Luny.UnityEngine.LuaBounds.Bind(Instance.boundsGlobal); return true;
                case "dataFormat": _value = new global::Lua.LuaValue((global::System.Int64)Instance.dataFormat); return true;
                case "gridResolutionX": _value = new global::Lua.LuaValue(Instance.gridResolutionX); return true;
                case "gridResolutionY": _value = new global::Lua.LuaValue(Instance.gridResolutionY); return true;
                case "gridResolutionZ": _value = new global::Lua.LuaValue(Instance.gridResolutionZ); return true;
                case "originCustom": _value = global::Luny.UnityEngine.LuaVector3.Bind(Instance.originCustom); return true;
                case "probeDensity": _value = new global::Lua.LuaValue(Instance.probeDensity); return true;
                case "probePositionMode": _value = new global::Lua.LuaValue((global::System.Int64)Instance.probePositionMode); return true;
                case "qualityMode": _value = new global::Lua.LuaValue((global::System.Int64)Instance.qualityMode); return true;
                case "refreshMode": _value = new global::Lua.LuaValue((global::System.Int64)Instance.refreshMode); return true;
                case "resolutionMode": _value = new global::Lua.LuaValue((global::System.Int64)Instance.resolutionMode); return true;
                case "sizeCustom": _value = global::Luny.UnityEngine.LuaVector3.Bind(Instance.sizeCustom); return true;
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
                case "boundingBoxMode": Instance.boundingBoxMode = _value.Read<global::UnityEngine.LightProbeProxyVolume.BoundingBoxMode>();  return true;
                case "dataFormat": Instance.dataFormat = _value.Read<global::UnityEngine.LightProbeProxyVolume.DataFormat>();  return true;
                case "gridResolutionX": Instance.gridResolutionX = _value.Read<global::System.Int32>();  return true;
                case "gridResolutionY": Instance.gridResolutionY = _value.Read<global::System.Int32>();  return true;
                case "gridResolutionZ": Instance.gridResolutionZ = _value.Read<global::System.Int32>();  return true;
                case "originCustom": Instance.originCustom = _value.Read<global::Luny.UnityEngine.LuaVector3>().Value;  return true;
                case "probeDensity": Instance.probeDensity = _value.Read<global::System.Single>();  return true;
                case "probePositionMode": Instance.probePositionMode = _value.Read<global::UnityEngine.LightProbeProxyVolume.ProbePositionMode>();  return true;
                case "qualityMode": Instance.qualityMode = _value.Read<global::UnityEngine.LightProbeProxyVolume.QualityMode>();  return true;
                case "refreshMode": Instance.refreshMode = _value.Read<global::UnityEngine.LightProbeProxyVolume.RefreshMode>();  return true;
                case "resolutionMode": Instance.resolutionMode = _value.Read<global::UnityEngine.LightProbeProxyVolume.ResolutionMode>();  return true;
                case "sizeCustom": Instance.sizeCustom = _value.Read<global::Luny.UnityEngine.LuaVector3>().Value;  return true;
                default: return base.TrySetLuaValue(_key, _value);
            }
        }
    }
    public sealed class LuaLightProbeProxyVolumeType : global::Luny.ILuaStatic
    {
        public static global::Lua.LuaValue Bind() => new LuaLightProbeProxyVolumeType();
        private LuaLightProbeProxyVolumeType() {}
        public static implicit operator global::Lua.LuaValue(LuaLightProbeProxyVolumeType value) => new(value);
        public global::System.Type BindType => typeof(global::UnityEngine.LightProbeProxyVolume);
        private static global::Lua.LuaTable s_Metatable;
        public global::Lua.LuaTable Metatable
        {
            get => s_Metatable ??= CreateMetatable();
            set => throw new global::System.NotSupportedException("LuaObject metatables cannot be modified");
        }
        global::System.Span<global::Lua.LuaValue> global::Lua.ILuaUserData.UserValues => default;
        private static global::Lua.LuaTable CreateMetatable()
        {
            var metatable = new global::Lua.LuaTable(0, 5);
            metatable[global::Lua.Runtime.Metamethods.Index] = __index;
            metatable[global::Lua.Runtime.Metamethods.NewIndex] = __newindex;
            metatable[global::Lua.Runtime.Metamethods.Concat] = global::Luny.LuaMetatable.ConcatMetamethod;
            metatable[global::Lua.Runtime.Metamethods.ToString] = global::Luny.LuaMetatable.ToStringMetamethod;
            metatable[global::Lua.Runtime.Metamethods.Call] = _LuaLightProbeProxyVolume_new;
            return metatable;
        }
        public override global::System.String ToString() => BindType.FullName;
#if UNITY_EDITOR
        [global::UnityEngine.RuntimeInitializeOnLoadMethod(global::UnityEngine.RuntimeInitializeLoadType.SubsystemRegistration)]
        private static void ResetStaticFields() => s_Metatable = null;
#endif

        private static readonly global::Lua.LuaFunction _LuaLightProbeProxyVolume_new = new global::Lua.LuaFunction(".ctor", (_context, _) =>
        {
            global::Lua.LuaValue _lastArg = default;
            global::System.Int32 _lastArgPos = default;
            global::System.Type _expectedType = default;
            var _argCount = _context.ArgumentCount;
            if (_argCount == 1)
            {
                var _ret0 = new global::UnityEngine.LightProbeProxyVolume();
                var _factory = _context.GetObjectFactory();
                var _lret0 = _factory.Bind(_ret0);
                var _retCount = _context.Return(_lret0);
                return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
            }
            throw new global::Lua.LuaRuntimeException(_context.Thread, $"{".ctor"}: invalid argument #{_lastArgPos}: {_lastArg} ({_lastArg.Type}), expected: {_expectedType.FullName}", 2);
        });
        private static readonly global::Lua.LuaFunction __index = new(global::Lua.Runtime.Metamethods.Index, (_context, _) =>
        {
            var _this = _context.GetArgument<LuaLightProbeProxyVolumeType>(0);
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
            var _this = _context.GetArgument<LuaLightProbeProxyVolumeType>(0);
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
                case "isFeatureSupported": _value = new global::Lua.LuaValue(global::UnityEngine.LightProbeProxyVolume.isFeatureSupported); return true;
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
