
// --------------------------------------------------------------
// GENERATED FILE ----> DO NOT EDIT <---- CHANGES WILL BE LOST !!
// --------------------------------------------------------------

#if UNITY_6000_0_OR_NEWER && !(UNITY_6000_1_OR_NEWER)
#pragma warning disable 0109, 0162, 0168, 0219
using Luny;

namespace Luny.UnityEngine.Rendering
{
    public sealed class LuaRayTracingMeshInstanceConfig : global::Luny.ILuaValueType<global::UnityEngine.Rendering.RayTracingMeshInstanceConfig>
    {
        public new static global::Lua.LuaValue Bind(in global::UnityEngine.Rendering.RayTracingMeshInstanceConfig instance) => new LuaRayTracingMeshInstanceConfig(instance);
        public new static global::Lua.LuaValue Bind(global::System.Object instance) => Bind((global::UnityEngine.Rendering.RayTracingMeshInstanceConfig)instance);
        public new static global::Lua.LuaValue Bind(global::System.Collections.Generic.IList<global::UnityEngine.Rendering.RayTracingMeshInstanceConfig> instances) =>
            new global::Luny.LuaList<global::UnityEngine.Rendering.RayTracingMeshInstanceConfig>(instances);
        public new static global::Lua.LuaValue Bind(global::System.Collections.Generic.IList<global::System.Object> instances) =>
            new global::Luny.LuaList<global::UnityEngine.Rendering.RayTracingMeshInstanceConfig>(instances);
        private LuaRayTracingMeshInstanceConfig(in global::UnityEngine.Rendering.RayTracingMeshInstanceConfig value) => m_Value = value;
        public static implicit operator global::Lua.LuaValue(LuaRayTracingMeshInstanceConfig value) => new(value);
        private global::UnityEngine.Rendering.RayTracingMeshInstanceConfig m_Value;
        public global::UnityEngine.Rendering.RayTracingMeshInstanceConfig Value { get => m_Value; set => m_Value = value; }
        public ref global::UnityEngine.Rendering.RayTracingMeshInstanceConfig ValueRef => ref m_Value;
        public global::System.Type BindType => typeof(global::UnityEngine.Rendering.RayTracingMeshInstanceConfig);
        private static global::Lua.LuaTable s_Metatable;
        public global::Lua.LuaTable Metatable
        {
            get => s_Metatable ??= global::Luny.LuaMetatable.Create(__index, __newindex);
            set => throw new global::System.NotSupportedException("LuaObject metatables cannot be modified");
        }
        global::System.Span<global::Lua.LuaValue> global::Lua.ILuaUserData.UserValues => default;
        public override global::System.String ToString() => m_Value.ToString();
#if UNITY_EDITOR
        [global::UnityEngine.RuntimeInitializeOnLoadMethod(global::UnityEngine.RuntimeInitializeLoadType.SubsystemRegistration)]
        private static void ResetStaticFields() => s_Metatable = null;
#endif

        private static readonly global::Lua.LuaFunction __index = new(global::Lua.Runtime.Metamethods.Index, (_context, _) =>
        {
            var _this = _context.GetArgument<LuaRayTracingMeshInstanceConfig>(0);
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
            var _this = _context.GetArgument<LuaRayTracingMeshInstanceConfig>(0);
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
                case "accelerationStructureBuildFlags": _value = new global::Lua.LuaValue((global::System.Int64)m_Value.accelerationStructureBuildFlags); return true;
                case "accelerationStructureBuildFlagsOverride": _value = new global::Lua.LuaValue(m_Value.accelerationStructureBuildFlagsOverride); return true;
                case "dynamicGeometry": _value = new global::Lua.LuaValue(m_Value.dynamicGeometry); return true;
                case "enableTriangleCulling": _value = new global::Lua.LuaValue(m_Value.enableTriangleCulling); return true;
                case "frontTriangleCounterClockwise": _value = new global::Lua.LuaValue(m_Value.frontTriangleCounterClockwise); return true;
                case "layer": _value = new global::Lua.LuaValue(m_Value.layer); return true;
                case "lightProbeProxyVolume": _value = _factory.Bind(m_Value.lightProbeProxyVolume); return true;
                case "lightProbeUsage": _value = new global::Lua.LuaValue((global::System.Int64)m_Value.lightProbeUsage); return true;
                case "mask": _value = new global::Lua.LuaValue(m_Value.mask); return true;
                case "material": _value = _factory.Bind(m_Value.material); return true;
                case "materialProperties": _value = _factory.Bind(m_Value.materialProperties); return true;
                case "mesh": _value = _factory.Bind(m_Value.mesh); return true;
                case "motionVectorMode": _value = new global::Lua.LuaValue((global::System.Int64)m_Value.motionVectorMode); return true;
                case "renderingLayerMask": _value = new global::Lua.LuaValue(m_Value.renderingLayerMask); return true;
                case "subMeshFlags": _value = new global::Lua.LuaValue((global::System.Int64)m_Value.subMeshFlags); return true;
                case "subMeshIndex": _value = new global::Lua.LuaValue(m_Value.subMeshIndex); return true;
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
                case "accelerationStructureBuildFlags": { var _temp = m_Value; _temp.accelerationStructureBuildFlags = _value.Read<global::UnityEngine.Rendering.RayTracingAccelerationStructureBuildFlags>(); m_Value = _temp; } return true;
                case "accelerationStructureBuildFlagsOverride": { var _temp = m_Value; _temp.accelerationStructureBuildFlagsOverride = _value.Read<global::System.Boolean>(); m_Value = _temp; } return true;
                case "dynamicGeometry": { var _temp = m_Value; _temp.dynamicGeometry = _value.Read<global::System.Boolean>(); m_Value = _temp; } return true;
                case "enableTriangleCulling": { var _temp = m_Value; _temp.enableTriangleCulling = _value.Read<global::System.Boolean>(); m_Value = _temp; } return true;
                case "frontTriangleCounterClockwise": { var _temp = m_Value; _temp.frontTriangleCounterClockwise = _value.Read<global::System.Boolean>(); m_Value = _temp; } return true;
                case "layer": { var _temp = m_Value; _temp.layer = _value.Read<global::System.Int32>(); m_Value = _temp; } return true;
                case "lightProbeProxyVolume": { var _temp = m_Value; _temp.lightProbeProxyVolume = _value.Read<global::Luny.UnityEngine.LuaLightProbeProxyVolume>().Instance; m_Value = _temp; } return true;
                case "lightProbeUsage": { var _temp = m_Value; _temp.lightProbeUsage = _value.Read<global::UnityEngine.Rendering.LightProbeUsage>(); m_Value = _temp; } return true;
                case "mask": { var _temp = m_Value; _temp.mask = _value.Read<global::System.UInt32>(); m_Value = _temp; } return true;
                case "material": { var _temp = m_Value; _temp.material = _value.Read<global::Luny.UnityEngine.LuaMaterial>().Instance; m_Value = _temp; } return true;
                case "materialProperties": { var _temp = m_Value; _temp.materialProperties = _value.Read<global::Luny.UnityEngine.LuaMaterialPropertyBlock>().Instance; m_Value = _temp; } return true;
                case "mesh": { var _temp = m_Value; _temp.mesh = _value.Read<global::Luny.UnityEngine.LuaMesh>().Instance; m_Value = _temp; } return true;
                case "motionVectorMode": { var _temp = m_Value; _temp.motionVectorMode = _value.Read<global::UnityEngine.MotionVectorGenerationMode>(); m_Value = _temp; } return true;
                case "renderingLayerMask": { var _temp = m_Value; _temp.renderingLayerMask = _value.Read<global::System.UInt32>(); m_Value = _temp; } return true;
                case "subMeshFlags": { var _temp = m_Value; _temp.subMeshFlags = _value.Read<global::UnityEngine.Rendering.RayTracingSubMeshFlags>(); m_Value = _temp; } return true;
                case "subMeshIndex": { var _temp = m_Value; _temp.subMeshIndex = _value.Read<global::System.UInt32>(); m_Value = _temp; } return true;
                default: return false;
            }
        }
    }
    public sealed class LuaRayTracingMeshInstanceConfigType : global::Luny.ILuaStatic
    {
        public static global::Lua.LuaValue Bind() => new LuaRayTracingMeshInstanceConfigType();
        private LuaRayTracingMeshInstanceConfigType() {}
        public static implicit operator global::Lua.LuaValue(LuaRayTracingMeshInstanceConfigType value) => new(value);
        public global::System.Type BindType => typeof(global::UnityEngine.Rendering.RayTracingMeshInstanceConfig);
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

        private static readonly global::Lua.LuaFunction _LuaRayTracingMeshInstanceConfig_new = new global::Lua.LuaFunction(".ctor", (_context, _) =>
        {
            global::Lua.LuaValue _lastArg = default;
            global::System.Int32 _lastArgPos = default;
            global::System.Type _expectedType = default;
            var _argCount = _context.ArgumentCount;
            if (_argCount == 0)
            {
                var _ret0 = new global::UnityEngine.Rendering.RayTracingMeshInstanceConfig();
                var _lret0 = global::Luny.UnityEngine.Rendering.LuaRayTracingMeshInstanceConfig.Bind(_ret0);
                var _retCount = _context.Return(_lret0);
                return new global::System.Threading.Tasks.ValueTask<global::System.Int32>(_retCount);
            }
            if (_argCount == 0)
            {
                var _ret0 = new global::UnityEngine.Rendering.RayTracingMeshInstanceConfig();
                var _lret0 = global::Luny.UnityEngine.Rendering.LuaRayTracingMeshInstanceConfig.Bind(_ret0);
                var _retCount = _context.Return(_lret0);
                return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
            }
            var _arg0 = _lastArg = _argCount > 0 ? _context.GetArgument(0) : global::Lua.LuaValue.Nil;
            _lastArgPos = 0; _expectedType = typeof(global::Luny.UnityEngine.LuaMesh);
            if (_arg0.TryRead<global::Luny.UnityEngine.LuaMesh>(out var _p0_UnityEngine_Mesh))
            {
                var _arg1 = _lastArg = _argCount > 1 ? _context.GetArgument(1) : global::Lua.LuaValue.Nil;
                _lastArgPos = 1; _expectedType = typeof(global::System.UInt32);
                if (_arg1.TryRead<global::System.UInt32>(out var _p1_System_UInt32))
                {
                    var _arg2 = _lastArg = _argCount > 2 ? _context.GetArgument(2) : global::Lua.LuaValue.Nil;
                    _lastArgPos = 2; _expectedType = typeof(global::Luny.UnityEngine.LuaMaterial);
                    if (_arg2.TryRead<global::Luny.UnityEngine.LuaMaterial>(out var _p2_UnityEngine_Material))
                    {
                        if (_argCount == 3)
                        {
                            var mesh = _p0_UnityEngine_Mesh.Instance;
                            var subMeshIndex = _p1_System_UInt32;
                            var material = _p2_UnityEngine_Material.Instance;
                            var _ret0 = new global::UnityEngine.Rendering.RayTracingMeshInstanceConfig(mesh, subMeshIndex, material);
                            var _lret0 = global::Luny.UnityEngine.Rendering.LuaRayTracingMeshInstanceConfig.Bind(_ret0);
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
            var _this = _context.GetArgument<LuaRayTracingMeshInstanceConfigType>(0);
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
            var _this = _context.GetArgument<LuaRayTracingMeshInstanceConfigType>(0);
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
                case "new": _value = _LuaRayTracingMeshInstanceConfig_new; return true;
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
