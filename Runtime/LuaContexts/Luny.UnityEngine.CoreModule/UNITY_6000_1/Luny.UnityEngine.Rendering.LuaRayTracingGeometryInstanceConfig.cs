
// --------------------------------------------------------------
// GENERATED FILE ----> DO NOT EDIT <---- CHANGES WILL BE LOST !!
// --------------------------------------------------------------

#if UNITY_6000_1_OR_NEWER && !(UNITY_6000_2_OR_NEWER)
#pragma warning disable 0109, 0162, 0168, 0219
using Luny;

namespace Luny.UnityEngine.Rendering
{
    public sealed class LuaRayTracingGeometryInstanceConfig : global::Luny.ILuaValueType<global::UnityEngine.Rendering.RayTracingGeometryInstanceConfig>
    {
        public new static global::Lua.LuaValue Bind(in global::UnityEngine.Rendering.RayTracingGeometryInstanceConfig instance) => new LuaRayTracingGeometryInstanceConfig(instance);
        public new static global::Lua.LuaValue Bind(global::System.Object instance) => Bind((global::UnityEngine.Rendering.RayTracingGeometryInstanceConfig)instance);
        public new static global::Lua.LuaValue Bind(global::System.Collections.Generic.IList<global::UnityEngine.Rendering.RayTracingGeometryInstanceConfig> instances) =>
            new global::Luny.LuaList<global::UnityEngine.Rendering.RayTracingGeometryInstanceConfig>(instances);
        public new static global::Lua.LuaValue Bind(global::System.Collections.Generic.IList<global::System.Object> instances) =>
            new global::Luny.LuaList<global::UnityEngine.Rendering.RayTracingGeometryInstanceConfig>(instances);
        private LuaRayTracingGeometryInstanceConfig(in global::UnityEngine.Rendering.RayTracingGeometryInstanceConfig value) => m_Value = value;
        public static implicit operator global::Lua.LuaValue(LuaRayTracingGeometryInstanceConfig value) => new(value);
        private global::UnityEngine.Rendering.RayTracingGeometryInstanceConfig m_Value;
        public global::UnityEngine.Rendering.RayTracingGeometryInstanceConfig Value { get => m_Value; set => m_Value = value; }
        public ref global::UnityEngine.Rendering.RayTracingGeometryInstanceConfig ValueRef => ref m_Value;
        public global::System.Type BindType => typeof(global::UnityEngine.Rendering.RayTracingGeometryInstanceConfig);
        public override global::System.String ToString() => m_Value.ToString();
#if UNITY_EDITOR
        [global::UnityEngine.RuntimeInitializeOnLoadMethod(global::UnityEngine.RuntimeInitializeLoadType.SubsystemRegistration)]
        private static void ResetStaticFields() => s_Metatable = null;
#endif

        private static readonly global::Lua.LuaFunction __index = new(global::Lua.Runtime.Metamethods.Index, (_context, _) =>
        {
            var _this = _context.GetArgument<LuaRayTracingGeometryInstanceConfig>(0);
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
            var _this = _context.GetArgument<LuaRayTracingGeometryInstanceConfig>(0);
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
                case "accelerationStructureBuildFlags": _value = new global::Lua.LuaValue((global::System.Int64)m_Value.accelerationStructureBuildFlags); return true;
                case "accelerationStructureBuildFlagsOverride": _value = new global::Lua.LuaValue(m_Value.accelerationStructureBuildFlagsOverride); return true;
                case "enableTriangleCulling": _value = new global::Lua.LuaValue(m_Value.enableTriangleCulling); return true;
                case "frontTriangleCounterClockwise": _value = new global::Lua.LuaValue(m_Value.frontTriangleCounterClockwise); return true;
                case "indexBuffer": _value = _factory.Bind(m_Value.indexBuffer); return true;
                case "indexCount": _value = new global::Lua.LuaValue(m_Value.indexCount); return true;
                case "indexStart": _value = new global::Lua.LuaValue(m_Value.indexStart); return true;
                case "layer": _value = new global::Lua.LuaValue(m_Value.layer); return true;
                case "lightProbeProxyVolume": _value = _factory.Bind(m_Value.lightProbeProxyVolume); return true;
                case "lightProbeUsage": _value = new global::Lua.LuaValue((global::System.Int64)m_Value.lightProbeUsage); return true;
                case "mask": _value = new global::Lua.LuaValue(m_Value.mask); return true;
                case "material": _value = _factory.Bind(m_Value.material); return true;
                case "materialProperties": _value = _factory.Bind(m_Value.materialProperties); return true;
                case "motionVectorMode": _value = new global::Lua.LuaValue((global::System.Int64)m_Value.motionVectorMode); return true;
                case "rayTracingMode": _value = new global::Lua.LuaValue((global::System.Int64)m_Value.rayTracingMode); return true;
                case "renderingLayerMask": _value = new global::Lua.LuaValue(m_Value.renderingLayerMask); return true;
                case "subMeshFlags": _value = new global::Lua.LuaValue((global::System.Int64)m_Value.subMeshFlags); return true;
                case "vertexAttributes": _value = _factory.Bind(m_Value.vertexAttributes); return true;
                case "vertexBuffer": _value = _factory.Bind(m_Value.vertexBuffer); return true;
                case "vertexCount": _value = new global::Lua.LuaValue(m_Value.vertexCount); return true;
                case "vertexStart": _value = new global::Lua.LuaValue(m_Value.vertexStart); return true;
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
                case "enableTriangleCulling": { var _temp = m_Value; _temp.enableTriangleCulling = _value.Read<global::System.Boolean>(); m_Value = _temp; } return true;
                case "frontTriangleCounterClockwise": { var _temp = m_Value; _temp.frontTriangleCounterClockwise = _value.Read<global::System.Boolean>(); m_Value = _temp; } return true;
                case "indexBuffer": { var _temp = m_Value; _temp.indexBuffer = _value.Read<global::Luny.UnityEngine.LuaGraphicsBuffer>().Instance; m_Value = _temp; } return true;
                case "indexCount": { var _temp = m_Value; _temp.indexCount = _value.Read<global::System.Int32>(); m_Value = _temp; } return true;
                case "indexStart": { var _temp = m_Value; _temp.indexStart = _value.Read<global::System.UInt32>(); m_Value = _temp; } return true;
                case "layer": { var _temp = m_Value; _temp.layer = _value.Read<global::System.Int32>(); m_Value = _temp; } return true;
                case "lightProbeProxyVolume": { var _temp = m_Value; _temp.lightProbeProxyVolume = _value.Read<global::Luny.UnityEngine.LuaLightProbeProxyVolume>().Instance; m_Value = _temp; } return true;
                case "lightProbeUsage": { var _temp = m_Value; _temp.lightProbeUsage = _value.Read<global::UnityEngine.Rendering.LightProbeUsage>(); m_Value = _temp; } return true;
                case "mask": { var _temp = m_Value; _temp.mask = _value.Read<global::System.UInt32>(); m_Value = _temp; } return true;
                case "material": { var _temp = m_Value; _temp.material = _value.Read<global::Luny.UnityEngine.LuaMaterial>().Instance; m_Value = _temp; } return true;
                case "materialProperties": { var _temp = m_Value; _temp.materialProperties = _value.Read<global::Luny.UnityEngine.LuaMaterialPropertyBlock>().Instance; m_Value = _temp; } return true;
                case "motionVectorMode": { var _temp = m_Value; _temp.motionVectorMode = _value.Read<global::UnityEngine.MotionVectorGenerationMode>(); m_Value = _temp; } return true;
                case "rayTracingMode": { var _temp = m_Value; _temp.rayTracingMode = _value.Read<global::UnityEngine.Experimental.Rendering.RayTracingMode>(); m_Value = _temp; } return true;
                case "renderingLayerMask": { var _temp = m_Value; _temp.renderingLayerMask = _value.Read<global::System.UInt32>(); m_Value = _temp; } return true;
                case "subMeshFlags": { var _temp = m_Value; _temp.subMeshFlags = _value.Read<global::UnityEngine.Rendering.RayTracingSubMeshFlags>(); m_Value = _temp; } return true;
                case "vertexAttributes": { var _temp = m_Value; _temp.vertexAttributes = _value.Read<global::UnityEngine.Rendering.VertexAttributeDescriptor[]>(); m_Value = _temp; } return true;
                case "vertexBuffer": { var _temp = m_Value; _temp.vertexBuffer = _value.Read<global::Luny.UnityEngine.LuaGraphicsBuffer>().Instance; m_Value = _temp; } return true;
                case "vertexCount": { var _temp = m_Value; _temp.vertexCount = _value.Read<global::System.Int32>(); m_Value = _temp; } return true;
                case "vertexStart": { var _temp = m_Value; _temp.vertexStart = _value.Read<global::System.UInt32>(); m_Value = _temp; } return true;
                default: return false;
            }
        }
    }
    public sealed class LuaRayTracingGeometryInstanceConfigType : global::Luny.ILuaStatic
    {
        public static global::Lua.LuaValue Bind() => new LuaRayTracingGeometryInstanceConfigType();
        private LuaRayTracingGeometryInstanceConfigType() {}
        public static implicit operator global::Lua.LuaValue(LuaRayTracingGeometryInstanceConfigType value) => new(value);
        public global::System.Type BindType => typeof(global::UnityEngine.Rendering.RayTracingGeometryInstanceConfig);
        public override global::System.String ToString() => BindType.FullName;
#if UNITY_EDITOR
        [global::UnityEngine.RuntimeInitializeOnLoadMethod(global::UnityEngine.RuntimeInitializeLoadType.SubsystemRegistration)]
        private static void ResetStaticFields() => s_Metatable = null;
#endif

        private static readonly global::Lua.LuaFunction _LuaRayTracingGeometryInstanceConfig_new = new global::Lua.LuaFunction(".ctor", (_context, _) =>
        {
            global::Lua.LuaValue _lastArg = default;
            global::System.Int32 _lastArgPos = default;
            global::System.Type _expectedType = default;
            var _argCount = _context.ArgumentCount;
            // ctor parameterless case
            if (_argCount == 1)
            {
                var _ret0 = new global::UnityEngine.Rendering.RayTracingGeometryInstanceConfig();
                var _lret0 = global::Luny.UnityEngine.Rendering.LuaRayTracingGeometryInstanceConfig.Bind(_ret0);
                var _retCount = _context.Return(_lret0);
                return new global::System.Threading.Tasks.ValueTask<global::System.Int32>(_retCount);
            }
            if (_argCount == 1)
            {
                var _ret0 = new global::UnityEngine.Rendering.RayTracingGeometryInstanceConfig();
                var _lret0 = global::Luny.UnityEngine.Rendering.LuaRayTracingGeometryInstanceConfig.Bind(_ret0);
                var _retCount = _context.Return(_lret0);
                return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
            }
            var _arg0 = _lastArg = _argCount > 1 ? _context.GetArgument(1) : global::Lua.LuaValue.Nil;
            _lastArgPos = 0; _expectedType = typeof(global::Luny.UnityEngine.LuaGraphicsBuffer);
            if (_arg0.TryRead<global::Luny.UnityEngine.LuaGraphicsBuffer>(out var _p0_UnityEngine_GraphicsBuffer))
            {
                var _arg1 = _lastArg = _argCount > 2 ? _context.GetArgument(2) : global::Lua.LuaValue.Nil;
                _lastArgPos = 1; _expectedType = typeof(global::UnityEngine.Rendering.VertexAttributeDescriptor[]);
                if (_arg1.TryReadArray<global::UnityEngine.Rendering.VertexAttributeDescriptor>(out var _p1_UnityEngine_Rendering_VertexAttributeDescriptorArray))
                {
                    var _arg2 = _lastArg = _argCount > 3 ? _context.GetArgument(3) : global::Lua.LuaValue.Nil;
                    _lastArgPos = 2; _expectedType = typeof(global::Luny.UnityEngine.LuaGraphicsBuffer);
                    if (_arg2.TryRead<global::Luny.UnityEngine.LuaGraphicsBuffer>(out var _p2_UnityEngine_GraphicsBuffer))
                    {
                        var _arg3 = _lastArg = _argCount > 4 ? _context.GetArgument(4) : global::Lua.LuaValue.Nil;
                        _lastArgPos = 3; _expectedType = typeof(global::Luny.UnityEngine.LuaMaterial);
                        if (_arg3.TryRead<global::Luny.UnityEngine.LuaMaterial>(out var _p3_UnityEngine_Material))
                        {
                            if (_argCount == 5)
                            {
                                var vertexBuffer = _p0_UnityEngine_GraphicsBuffer.Instance;
                                var vertexAttributes = _p1_UnityEngine_Rendering_VertexAttributeDescriptorArray;
                                var indexBuffer = _p2_UnityEngine_GraphicsBuffer.Instance;
                                var material = _p3_UnityEngine_Material.Instance;
                                var _ret0 = new global::UnityEngine.Rendering.RayTracingGeometryInstanceConfig(vertexBuffer, vertexAttributes, indexBuffer, material);
                                var _lret0 = global::Luny.UnityEngine.Rendering.LuaRayTracingGeometryInstanceConfig.Bind(_ret0);
                                var _retCount = _context.Return(_lret0);
                                return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                            }
                        }
                    }
                }
            }
            throw new global::Lua.LuaRuntimeException(_context.Thread, $"{".ctor"}: invalid argument #{_lastArgPos}: {_lastArg} ({_lastArg.Type}), expected: {_expectedType.FullName}", 2);
        });
        private static readonly global::Lua.LuaFunction __index = new(global::Lua.Runtime.Metamethods.Index, (_context, _) =>
        {
            var _this = _context.GetArgument<LuaRayTracingGeometryInstanceConfigType>(0);
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
            var _this = _context.GetArgument<LuaRayTracingGeometryInstanceConfigType>(0);
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
            metatable[global::Lua.Runtime.Metamethods.Call] = _LuaRayTracingGeometryInstanceConfig_new;
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
