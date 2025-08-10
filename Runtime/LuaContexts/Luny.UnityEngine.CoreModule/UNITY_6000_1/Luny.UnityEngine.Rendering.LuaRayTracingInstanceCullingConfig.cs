
// --------------------------------------------------------------
// GENERATED FILE ----> DO NOT EDIT <---- CHANGES WILL BE LOST !!
// --------------------------------------------------------------

#if UNITY_6000_1_OR_NEWER && !(UNITY_6000_2_OR_NEWER)
#pragma warning disable 0109, 0162, 0168, 0219
using Luny;

namespace Luny.UnityEngine.Rendering
{
    public sealed class LuaRayTracingInstanceCullingConfig : global::Luny.ILuaValueType<global::UnityEngine.Rendering.RayTracingInstanceCullingConfig>
    {
        public new static global::Lua.LuaValue Bind(in global::UnityEngine.Rendering.RayTracingInstanceCullingConfig instance) => new LuaRayTracingInstanceCullingConfig(instance);
        public new static global::Lua.LuaValue Bind(global::System.Object instance) => Bind((global::UnityEngine.Rendering.RayTracingInstanceCullingConfig)instance);
        public new static global::Lua.LuaValue Bind(global::System.Collections.Generic.IList<global::UnityEngine.Rendering.RayTracingInstanceCullingConfig> instances) =>
            new global::Luny.LuaList<global::UnityEngine.Rendering.RayTracingInstanceCullingConfig>(instances);
        public new static global::Lua.LuaValue Bind(global::System.Collections.Generic.IList<global::System.Object> instances) =>
            new global::Luny.LuaList<global::UnityEngine.Rendering.RayTracingInstanceCullingConfig>(instances);
        private LuaRayTracingInstanceCullingConfig(in global::UnityEngine.Rendering.RayTracingInstanceCullingConfig value) => m_Value = value;
        public static implicit operator global::Lua.LuaValue(LuaRayTracingInstanceCullingConfig value) => new(value);
        private global::UnityEngine.Rendering.RayTracingInstanceCullingConfig m_Value;
        public global::UnityEngine.Rendering.RayTracingInstanceCullingConfig Value { get => m_Value; set => m_Value = value; }
        public ref global::UnityEngine.Rendering.RayTracingInstanceCullingConfig ValueRef => ref m_Value;
        public global::System.Type BindType => typeof(global::UnityEngine.Rendering.RayTracingInstanceCullingConfig);
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
            var _this = _context.GetArgument<LuaRayTracingInstanceCullingConfig>(0);
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
            var _this = _context.GetArgument<LuaRayTracingInstanceCullingConfig>(0);
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
                case "alphaTestedMaterialConfig": _value = global::Luny.UnityEngine.Rendering.LuaRayTracingInstanceMaterialConfig.Bind(m_Value.alphaTestedMaterialConfig); return true;
                case "flags": _value = new global::Lua.LuaValue((global::System.Int64)m_Value.flags); return true;
                case "instanceTests": _value = _factory.Bind(m_Value.instanceTests); return true;
                case "lodParameters": _value = global::Luny.UnityEngine.Rendering.LuaLODParameters.Bind(m_Value.lodParameters); return true;
                case "materialTest": _value = global::Luny.UnityEngine.Rendering.LuaRayTracingInstanceCullingMaterialTest.Bind(m_Value.materialTest); return true;
                case "minSolidAngle": _value = new global::Lua.LuaValue(m_Value.minSolidAngle); return true;
                case "planes": _value = _factory.Bind(m_Value.planes); return true;
                case "sphereCenter": _value = global::Luny.UnityEngine.LuaVector3.Bind(m_Value.sphereCenter); return true;
                case "sphereRadius": _value = new global::Lua.LuaValue(m_Value.sphereRadius); return true;
                case "subMeshFlagsConfig": _value = global::Luny.UnityEngine.Rendering.LuaRayTracingSubMeshFlagsConfig.Bind(m_Value.subMeshFlagsConfig); return true;
                case "transparentMaterialConfig": _value = global::Luny.UnityEngine.Rendering.LuaRayTracingInstanceMaterialConfig.Bind(m_Value.transparentMaterialConfig); return true;
                case "triangleCullingConfig": _value = global::Luny.UnityEngine.Rendering.LuaRayTracingInstanceTriangleCullingConfig.Bind(m_Value.triangleCullingConfig); return true;
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
                case "alphaTestedMaterialConfig": { var _temp = m_Value; _temp.alphaTestedMaterialConfig = _value.Read<global::Luny.UnityEngine.Rendering.LuaRayTracingInstanceMaterialConfig>().Value; m_Value = _temp; } return true;
                case "flags": { var _temp = m_Value; _temp.flags = _value.Read<global::UnityEngine.Rendering.RayTracingInstanceCullingFlags>(); m_Value = _temp; } return true;
                case "instanceTests": { var _temp = m_Value; _temp.instanceTests = _value.Read<global::UnityEngine.Rendering.RayTracingInstanceCullingTest[]>(); m_Value = _temp; } return true;
                case "lodParameters": { var _temp = m_Value; _temp.lodParameters = _value.Read<global::Luny.UnityEngine.Rendering.LuaLODParameters>().Value; m_Value = _temp; } return true;
                case "materialTest": { var _temp = m_Value; _temp.materialTest = _value.Read<global::Luny.UnityEngine.Rendering.LuaRayTracingInstanceCullingMaterialTest>().Value; m_Value = _temp; } return true;
                case "minSolidAngle": { var _temp = m_Value; _temp.minSolidAngle = _value.Read<global::System.Single>(); m_Value = _temp; } return true;
                case "planes": { var _temp = m_Value; _temp.planes = _value.Read<global::UnityEngine.Plane[]>(); m_Value = _temp; } return true;
                case "sphereCenter": { var _temp = m_Value; _temp.sphereCenter = _value.Read<global::Luny.UnityEngine.LuaVector3>().Value; m_Value = _temp; } return true;
                case "sphereRadius": { var _temp = m_Value; _temp.sphereRadius = _value.Read<global::System.Single>(); m_Value = _temp; } return true;
                case "subMeshFlagsConfig": { var _temp = m_Value; _temp.subMeshFlagsConfig = _value.Read<global::Luny.UnityEngine.Rendering.LuaRayTracingSubMeshFlagsConfig>().Value; m_Value = _temp; } return true;
                case "transparentMaterialConfig": { var _temp = m_Value; _temp.transparentMaterialConfig = _value.Read<global::Luny.UnityEngine.Rendering.LuaRayTracingInstanceMaterialConfig>().Value; m_Value = _temp; } return true;
                case "triangleCullingConfig": { var _temp = m_Value; _temp.triangleCullingConfig = _value.Read<global::Luny.UnityEngine.Rendering.LuaRayTracingInstanceTriangleCullingConfig>().Value; m_Value = _temp; } return true;
                default: return false;
            }
        }
    }
    public sealed class LuaRayTracingInstanceCullingConfigType : global::Luny.ILuaStatic
    {
        public static global::Lua.LuaValue Bind() => new LuaRayTracingInstanceCullingConfigType();
        private LuaRayTracingInstanceCullingConfigType() {}
        public static implicit operator global::Lua.LuaValue(LuaRayTracingInstanceCullingConfigType value) => new(value);
        public global::System.Type BindType => typeof(global::UnityEngine.Rendering.RayTracingInstanceCullingConfig);
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

        private static readonly global::Lua.LuaFunction __index = new(global::Lua.Runtime.Metamethods.Index, (_context, _) =>
        {
            var _this = _context.GetArgument<LuaRayTracingInstanceCullingConfigType>(0);
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
            var _this = _context.GetArgument<LuaRayTracingInstanceCullingConfigType>(0);
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
