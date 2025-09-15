
// --------------------------------------------------------------
// GENERATED FILE ----> DO NOT EDIT <---- CHANGES WILL BE LOST !!
// --------------------------------------------------------------

#if UNITY_6000_2_OR_NEWER && !(UNITY_6000_3_OR_NEWER)
#pragma warning disable 0109, 0162, 0168, 0219
using Luny;

namespace Luny.UnityEngine.Rendering
{
    public sealed class LuaRayTracingAABBsInstanceConfig : global::Luny.ILuaValueType<global::UnityEngine.Rendering.RayTracingAABBsInstanceConfig>
    {
        public new static global::Lua.LuaValue Bind(in global::UnityEngine.Rendering.RayTracingAABBsInstanceConfig instance) => new LuaRayTracingAABBsInstanceConfig(instance);
        public new static global::Lua.LuaValue Bind(global::System.Object instance) => Bind((global::UnityEngine.Rendering.RayTracingAABBsInstanceConfig)instance);
        public new static global::Lua.LuaValue Bind(global::System.Collections.Generic.IList<global::UnityEngine.Rendering.RayTracingAABBsInstanceConfig> instances) =>
            new global::Luny.LuaList<global::UnityEngine.Rendering.RayTracingAABBsInstanceConfig>(instances);
        public new static global::Lua.LuaValue Bind(global::System.Collections.Generic.IList<global::System.Object> instances) =>
            new global::Luny.LuaList<global::UnityEngine.Rendering.RayTracingAABBsInstanceConfig>(instances);
        private LuaRayTracingAABBsInstanceConfig(in global::UnityEngine.Rendering.RayTracingAABBsInstanceConfig value) => m_Value = value;
        public static implicit operator global::Lua.LuaValue(LuaRayTracingAABBsInstanceConfig value) => new(value);
        private global::UnityEngine.Rendering.RayTracingAABBsInstanceConfig m_Value;
        public global::UnityEngine.Rendering.RayTracingAABBsInstanceConfig Value { get => m_Value; set => m_Value = value; }
        public ref global::UnityEngine.Rendering.RayTracingAABBsInstanceConfig ValueRef => ref m_Value;
        public global::System.Type BindType => typeof(global::UnityEngine.Rendering.RayTracingAABBsInstanceConfig);
        public override global::System.String ToString() => m_Value.ToString();
#if UNITY_EDITOR
        [global::UnityEngine.RuntimeInitializeOnLoadMethod(global::UnityEngine.RuntimeInitializeLoadType.SubsystemRegistration)]
        private static void ResetStaticFields() => s_Metatable = null;
#endif

        private static readonly global::Lua.LuaFunction __index = new(global::Lua.Runtime.Metamethods.Index, (_context, _) =>
        {
            var _this = _context.GetArgument<LuaRayTracingAABBsInstanceConfig>(0);
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
            var _this = _context.GetArgument<LuaRayTracingAABBsInstanceConfig>(0);
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
                case "aabbBuffer": _value = _factory.Bind(m_Value.aabbBuffer); return true;
                case "aabbCount": _value = new global::Lua.LuaValue(m_Value.aabbCount); return true;
                case "aabbOffset": _value = new global::Lua.LuaValue(m_Value.aabbOffset); return true;
                case "accelerationStructureBuildFlags": _value = new global::Lua.LuaValue((global::System.Int64)m_Value.accelerationStructureBuildFlags); return true;
                case "accelerationStructureBuildFlagsOverride": _value = new global::Lua.LuaValue(m_Value.accelerationStructureBuildFlagsOverride); return true;
                case "dynamicGeometry": _value = new global::Lua.LuaValue(m_Value.dynamicGeometry); return true;
                case "layer": _value = new global::Lua.LuaValue(m_Value.layer); return true;
                case "mask": _value = new global::Lua.LuaValue(m_Value.mask); return true;
                case "material": _value = _factory.Bind(m_Value.material); return true;
                case "materialProperties": _value = _factory.Bind(m_Value.materialProperties); return true;
                case "opaqueMaterial": _value = new global::Lua.LuaValue(m_Value.opaqueMaterial); return true;
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
                case "aabbBuffer": { var _temp = m_Value; _temp.aabbBuffer = _value.Read<global::Luny.UnityEngine.LuaGraphicsBuffer>().Instance; m_Value = _temp; } return true;
                case "aabbCount": { var _temp = m_Value; _temp.aabbCount = _value.Read<global::System.Int32>(); m_Value = _temp; } return true;
                case "aabbOffset": { var _temp = m_Value; _temp.aabbOffset = _value.Read<global::System.UInt32>(); m_Value = _temp; } return true;
                case "accelerationStructureBuildFlags": { var _temp = m_Value; _temp.accelerationStructureBuildFlags = _value.Read<global::UnityEngine.Rendering.RayTracingAccelerationStructureBuildFlags>(); m_Value = _temp; } return true;
                case "accelerationStructureBuildFlagsOverride": { var _temp = m_Value; _temp.accelerationStructureBuildFlagsOverride = _value.Read<global::System.Boolean>(); m_Value = _temp; } return true;
                case "dynamicGeometry": { var _temp = m_Value; _temp.dynamicGeometry = _value.Read<global::System.Boolean>(); m_Value = _temp; } return true;
                case "layer": { var _temp = m_Value; _temp.layer = _value.Read<global::System.Int32>(); m_Value = _temp; } return true;
                case "mask": { var _temp = m_Value; _temp.mask = _value.Read<global::System.UInt32>(); m_Value = _temp; } return true;
                case "material": { var _temp = m_Value; _temp.material = _value.Read<global::Luny.UnityEngine.LuaMaterial>().Instance; m_Value = _temp; } return true;
                case "materialProperties": { var _temp = m_Value; _temp.materialProperties = _value.Read<global::Luny.UnityEngine.LuaMaterialPropertyBlock>().Instance; m_Value = _temp; } return true;
                case "opaqueMaterial": { var _temp = m_Value; _temp.opaqueMaterial = _value.Read<global::System.Boolean>(); m_Value = _temp; } return true;
                default: return false;
            }
        }
    }
    public sealed class LuaRayTracingAABBsInstanceConfigType : global::Luny.ILuaStatic
    {
        public static global::Lua.LuaValue Bind() => new LuaRayTracingAABBsInstanceConfigType();
        private LuaRayTracingAABBsInstanceConfigType() {}
        public static implicit operator global::Lua.LuaValue(LuaRayTracingAABBsInstanceConfigType value) => new(value);
        public global::System.Type BindType => typeof(global::UnityEngine.Rendering.RayTracingAABBsInstanceConfig);
        public override global::System.String ToString() => BindType.FullName;
#if UNITY_EDITOR
        [global::UnityEngine.RuntimeInitializeOnLoadMethod(global::UnityEngine.RuntimeInitializeLoadType.SubsystemRegistration)]
        private static void ResetStaticFields() => s_Metatable = null;
#endif

        private static readonly global::Lua.LuaFunction _LuaRayTracingAABBsInstanceConfig_new = new global::Lua.LuaFunction(".ctor", (_context, _) =>
        {
            global::Lua.LuaValue _lastArg = default;
            global::System.Int32 _lastArgPos = default;
            global::System.Type _expectedType = default;
            var _argCount = _context.ArgumentCount;
            // ctor parameterless case
            if (_argCount == 1)
            {
                var _ret0 = new global::UnityEngine.Rendering.RayTracingAABBsInstanceConfig();
                var _lret0 = global::Luny.UnityEngine.Rendering.LuaRayTracingAABBsInstanceConfig.Bind(_ret0);
                var _retCount = _context.Return(_lret0);
                return new global::System.Threading.Tasks.ValueTask<global::System.Int32>(_retCount);
            }
            if (_argCount == 1)
            {
                var _ret0 = new global::UnityEngine.Rendering.RayTracingAABBsInstanceConfig();
                var _lret0 = global::Luny.UnityEngine.Rendering.LuaRayTracingAABBsInstanceConfig.Bind(_ret0);
                var _retCount = _context.Return(_lret0);
                return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
            }
            var _arg0 = _lastArg = _argCount > 1 ? _context.GetArgument(1) : global::Lua.LuaValue.Nil;
            _lastArgPos = 0; _expectedType = typeof(global::Luny.UnityEngine.LuaGraphicsBuffer);
            if (_arg0.TryRead<global::Luny.UnityEngine.LuaGraphicsBuffer>(out var _p0_UnityEngine_GraphicsBuffer))
            {
                var _arg1 = _lastArg = _argCount > 2 ? _context.GetArgument(2) : global::Lua.LuaValue.Nil;
                _lastArgPos = 1; _expectedType = typeof(global::System.Int32);
                if (_arg1.TryRead<global::System.Int32>(out var _p1_System_Int32))
                {
                    var _arg2 = _lastArg = _argCount > 3 ? _context.GetArgument(3) : global::Lua.LuaValue.Nil;
                    _lastArgPos = 2; _expectedType = typeof(global::System.Boolean);
                    if (_arg2.TryRead<global::System.Boolean>(out var _p2_System_Boolean))
                    {
                        var _arg3 = _lastArg = _argCount > 4 ? _context.GetArgument(4) : global::Lua.LuaValue.Nil;
                        _lastArgPos = 3; _expectedType = typeof(global::Luny.UnityEngine.LuaMaterial);
                        if (_arg3.TryRead<global::Luny.UnityEngine.LuaMaterial>(out var _p3_UnityEngine_Material))
                        {
                            if (_argCount == 5)
                            {
                                var aabbBuffer = _p0_UnityEngine_GraphicsBuffer.Instance;
                                var aabbCount = _p1_System_Int32;
                                var dynamicGeometry = _p2_System_Boolean;
                                var material = _p3_UnityEngine_Material.Instance;
                                var _ret0 = new global::UnityEngine.Rendering.RayTracingAABBsInstanceConfig(aabbBuffer, aabbCount, dynamicGeometry, material);
                                var _lret0 = global::Luny.UnityEngine.Rendering.LuaRayTracingAABBsInstanceConfig.Bind(_ret0);
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
            var _this = _context.GetArgument<LuaRayTracingAABBsInstanceConfigType>(0);
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
            var _this = _context.GetArgument<LuaRayTracingAABBsInstanceConfigType>(0);
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
            metatable[global::Lua.Runtime.Metamethods.Call] = _LuaRayTracingAABBsInstanceConfig_new;
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
