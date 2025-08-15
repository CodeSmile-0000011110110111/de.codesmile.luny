
// --------------------------------------------------------------
// GENERATED FILE ----> DO NOT EDIT <---- CHANGES WILL BE LOST !!
// --------------------------------------------------------------

#if UNITY_6000_2_OR_NEWER && !(UNITY_6000_3_OR_NEWER)
#pragma warning disable 0109, 0162, 0168, 0219
using Luny;

namespace Luny.UnityEngine.Rendering
{
    public sealed class LuaRayTracingAccelerationStructureSettings : global::Luny.ILuaValueType<global::UnityEngine.Rendering.RayTracingAccelerationStructure.Settings>
    {
        public new static global::Lua.LuaValue Bind(in global::UnityEngine.Rendering.RayTracingAccelerationStructure.Settings instance) => new LuaRayTracingAccelerationStructureSettings(instance);
        public new static global::Lua.LuaValue Bind(global::System.Object instance) => Bind((global::UnityEngine.Rendering.RayTracingAccelerationStructure.Settings)instance);
        public new static global::Lua.LuaValue Bind(global::System.Collections.Generic.IList<global::UnityEngine.Rendering.RayTracingAccelerationStructure.Settings> instances) =>
            new global::Luny.LuaList<global::UnityEngine.Rendering.RayTracingAccelerationStructure.Settings>(instances);
        public new static global::Lua.LuaValue Bind(global::System.Collections.Generic.IList<global::System.Object> instances) =>
            new global::Luny.LuaList<global::UnityEngine.Rendering.RayTracingAccelerationStructure.Settings>(instances);
        private LuaRayTracingAccelerationStructureSettings(in global::UnityEngine.Rendering.RayTracingAccelerationStructure.Settings value) => m_Value = value;
        public static implicit operator global::Lua.LuaValue(LuaRayTracingAccelerationStructureSettings value) => new(value);
        private global::UnityEngine.Rendering.RayTracingAccelerationStructure.Settings m_Value;
        public global::UnityEngine.Rendering.RayTracingAccelerationStructure.Settings Value { get => m_Value; set => m_Value = value; }
        public ref global::UnityEngine.Rendering.RayTracingAccelerationStructure.Settings ValueRef => ref m_Value;
        public global::System.Type BindType => typeof(global::UnityEngine.Rendering.RayTracingAccelerationStructure.Settings);
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
            return metatable;
        }
        public override global::System.String ToString() => m_Value.ToString();
#if UNITY_EDITOR
        [global::UnityEngine.RuntimeInitializeOnLoadMethod(global::UnityEngine.RuntimeInitializeLoadType.SubsystemRegistration)]
        private static void ResetStaticFields() => s_Metatable = null;
#endif

        private static readonly global::Lua.LuaFunction __index = new(global::Lua.Runtime.Metamethods.Index, (_context, _) =>
        {
            var _this = _context.GetArgument<LuaRayTracingAccelerationStructureSettings>(0);
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
            var _this = _context.GetArgument<LuaRayTracingAccelerationStructureSettings>(0);
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
                case "buildFlagsDynamicGeometries": _value = new global::Lua.LuaValue((global::System.Int64)m_Value.buildFlagsDynamicGeometries); return true;
                case "buildFlagsStaticGeometries": _value = new global::Lua.LuaValue((global::System.Int64)m_Value.buildFlagsStaticGeometries); return true;
                case "enableCompaction": _value = new global::Lua.LuaValue(m_Value.enableCompaction); return true;
                case "layerMask": _value = new global::Lua.LuaValue(m_Value.layerMask); return true;
                case "managementMode": _value = new global::Lua.LuaValue((global::System.Int64)m_Value.managementMode); return true;
                case "rayTracingModeMask": _value = new global::Lua.LuaValue((global::System.Int64)m_Value.rayTracingModeMask); return true;
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
                case "buildFlagsDynamicGeometries": { var _temp = m_Value; _temp.buildFlagsDynamicGeometries = _value.Read<global::UnityEngine.Rendering.RayTracingAccelerationStructureBuildFlags>(); m_Value = _temp; } return true;
                case "buildFlagsStaticGeometries": { var _temp = m_Value; _temp.buildFlagsStaticGeometries = _value.Read<global::UnityEngine.Rendering.RayTracingAccelerationStructureBuildFlags>(); m_Value = _temp; } return true;
                case "enableCompaction": { var _temp = m_Value; _temp.enableCompaction = _value.Read<global::System.Boolean>(); m_Value = _temp; } return true;
                case "layerMask": { var _temp = m_Value; _temp.layerMask = _value.Read<global::System.Int32>(); m_Value = _temp; } return true;
                case "managementMode": { var _temp = m_Value; _temp.managementMode = _value.Read<global::UnityEngine.Rendering.RayTracingAccelerationStructure.ManagementMode>(); m_Value = _temp; } return true;
                case "rayTracingModeMask": { var _temp = m_Value; _temp.rayTracingModeMask = _value.Read<global::UnityEngine.Rendering.RayTracingAccelerationStructure.RayTracingModeMask>(); m_Value = _temp; } return true;
                default: return false;
            }
        }
    }
    public sealed class LuaRayTracingAccelerationStructureSettingsType : global::Luny.ILuaStatic
    {
        public static global::Lua.LuaValue Bind() => new LuaRayTracingAccelerationStructureSettingsType();
        private LuaRayTracingAccelerationStructureSettingsType() {}
        public static implicit operator global::Lua.LuaValue(LuaRayTracingAccelerationStructureSettingsType value) => new(value);
        public global::System.Type BindType => typeof(global::UnityEngine.Rendering.RayTracingAccelerationStructure.Settings);
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
            metatable[global::Lua.Runtime.Metamethods.Call] = _LuaRayTracingAccelerationStructureSettings_new;
            return metatable;
        }
        public override global::System.String ToString() => BindType.FullName;
#if UNITY_EDITOR
        [global::UnityEngine.RuntimeInitializeOnLoadMethod(global::UnityEngine.RuntimeInitializeLoadType.SubsystemRegistration)]
        private static void ResetStaticFields() => s_Metatable = null;
#endif

        private static readonly global::Lua.LuaFunction _LuaRayTracingAccelerationStructureSettings_new = new global::Lua.LuaFunction(".ctor", (_context, _) =>
        {
            global::Lua.LuaValue _lastArg = default;
            global::System.Int32 _lastArgPos = default;
            global::System.Type _expectedType = default;
            var _argCount = _context.ArgumentCount;
            // ctor parameterless case
            if (_argCount == 1)
            {
                var _ret0 = new global::UnityEngine.Rendering.RayTracingAccelerationStructure.Settings();
                var _lret0 = global::Luny.UnityEngine.Rendering.LuaRayTracingAccelerationStructureSettings.Bind(_ret0);
                var _retCount = _context.Return(_lret0);
                return new global::System.Threading.Tasks.ValueTask<global::System.Int32>(_retCount);
            }
            if (_argCount == 1)
            {
                var _ret0 = new global::UnityEngine.Rendering.RayTracingAccelerationStructure.Settings();
                var _lret0 = global::Luny.UnityEngine.Rendering.LuaRayTracingAccelerationStructureSettings.Bind(_ret0);
                var _retCount = _context.Return(_lret0);
                return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
            }
            var _arg0 = _lastArg = _argCount > 1 ? _context.GetArgument(1) : global::Lua.LuaValue.Nil;
            _lastArgPos = 0; _expectedType = typeof(global::UnityEngine.Rendering.RayTracingAccelerationStructure.ManagementMode);
            if (_arg0.TryRead<global::UnityEngine.Rendering.RayTracingAccelerationStructure.ManagementMode>(out var _p0_UnityEngine_Rendering_RayTracingAccelerationStructure_ManagementMode))
            {
                var _arg1 = _lastArg = _argCount > 2 ? _context.GetArgument(2) : global::Lua.LuaValue.Nil;
                _lastArgPos = 1; _expectedType = typeof(global::UnityEngine.Rendering.RayTracingAccelerationStructure.RayTracingModeMask);
                if (_arg1.TryRead<global::UnityEngine.Rendering.RayTracingAccelerationStructure.RayTracingModeMask>(out var _p1_UnityEngine_Rendering_RayTracingAccelerationStructure_RayTracingModeMask))
                {
                    var _arg2 = _lastArg = _argCount > 3 ? _context.GetArgument(3) : global::Lua.LuaValue.Nil;
                    _lastArgPos = 2; _expectedType = typeof(global::System.Int32);
                    if (_arg2.TryRead<global::System.Int32>(out var _p2_System_Int32))
                    {
                        if (_argCount == 4)
                        {
                            var sceneManagementMode = _p0_UnityEngine_Rendering_RayTracingAccelerationStructure_ManagementMode;
                            var rayTracingModeMask = _p1_UnityEngine_Rendering_RayTracingAccelerationStructure_RayTracingModeMask;
                            var layerMask = _p2_System_Int32;
                            var _ret0 = new global::UnityEngine.Rendering.RayTracingAccelerationStructure.Settings(sceneManagementMode, rayTracingModeMask, layerMask);
                            var _lret0 = global::Luny.UnityEngine.Rendering.LuaRayTracingAccelerationStructureSettings.Bind(_ret0);
                            var _retCount = _context.Return(_lret0);
                            return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                        }
                        var _arg3 = _lastArg = _argCount > 4 ? _context.GetArgument(4) : global::Lua.LuaValue.Nil;
                        _lastArgPos = 3; _expectedType = typeof(global::UnityEngine.Rendering.RayTracingAccelerationStructureBuildFlags);
                        if (_arg3.TryRead<global::UnityEngine.Rendering.RayTracingAccelerationStructureBuildFlags>(out var _p3_UnityEngine_Rendering_RayTracingAccelerationStructureBuildFlags))
                        {
                            var _arg4 = _lastArg = _argCount > 5 ? _context.GetArgument(5) : global::Lua.LuaValue.Nil;
                            _lastArgPos = 4; _expectedType = typeof(global::UnityEngine.Rendering.RayTracingAccelerationStructureBuildFlags);
                            if (_arg4.TryRead<global::UnityEngine.Rendering.RayTracingAccelerationStructureBuildFlags>(out var _p4_UnityEngine_Rendering_RayTracingAccelerationStructureBuildFlags))
                            {
                                if (_argCount == 6)
                                {
                                    var sceneManagementMode = _p0_UnityEngine_Rendering_RayTracingAccelerationStructure_ManagementMode;
                                    var rayTracingModeMask = _p1_UnityEngine_Rendering_RayTracingAccelerationStructure_RayTracingModeMask;
                                    var layerMask = _p2_System_Int32;
                                    var buildFlagsStaticGeometries = _p3_UnityEngine_Rendering_RayTracingAccelerationStructureBuildFlags;
                                    var buildFlagsDynamicGeometries = _p4_UnityEngine_Rendering_RayTracingAccelerationStructureBuildFlags;
                                    var _ret0 = new global::UnityEngine.Rendering.RayTracingAccelerationStructure.Settings(sceneManagementMode, rayTracingModeMask, layerMask, buildFlagsStaticGeometries, buildFlagsDynamicGeometries);
                                    var _lret0 = global::Luny.UnityEngine.Rendering.LuaRayTracingAccelerationStructureSettings.Bind(_ret0);
                                    var _retCount = _context.Return(_lret0);
                                    return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                                }
                            }
                        }
                    }
                }
            }
            throw new global::Lua.LuaRuntimeException(_context.Thread, $"{".ctor"}: invalid argument #{_lastArgPos}: {_lastArg} ({_lastArg.Type}), expected: {_expectedType.FullName}", 2);
        });
        private static readonly global::Lua.LuaFunction __index = new(global::Lua.Runtime.Metamethods.Index, (_context, _) =>
        {
            var _this = _context.GetArgument<LuaRayTracingAccelerationStructureSettingsType>(0);
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
            var _this = _context.GetArgument<LuaRayTracingAccelerationStructureSettingsType>(0);
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
