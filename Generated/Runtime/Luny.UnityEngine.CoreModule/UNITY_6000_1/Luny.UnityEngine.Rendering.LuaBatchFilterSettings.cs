
// --------------------------------------------------------------
// GENERATED FILE ----> DO NOT EDIT <---- CHANGES WILL BE LOST !!
// --------------------------------------------------------------

#if UNITY_6000_1_OR_NEWER && !(UNITY_6000_2_OR_NEWER)
#pragma warning disable 0109, 0162, 0168, 0219
using Luny;

namespace Luny.UnityEngine.Rendering
{
    public sealed class LuaBatchFilterSettings : global::Luny.ILuaValueType<global::UnityEngine.Rendering.BatchFilterSettings>
    {
        public new static global::Lua.LuaValue Bind(in global::UnityEngine.Rendering.BatchFilterSettings instance) => new LuaBatchFilterSettings(instance);
        public new static global::Lua.LuaValue Bind(global::System.Object instance) => Bind((global::UnityEngine.Rendering.BatchFilterSettings)instance);
        public new static global::Lua.LuaValue Bind(global::System.Collections.Generic.IList<global::UnityEngine.Rendering.BatchFilterSettings> instances) =>
            new global::Luny.LuaList<global::UnityEngine.Rendering.BatchFilterSettings>(instances);
        public new static global::Lua.LuaValue Bind(global::System.Collections.Generic.IList<global::System.Object> instances) =>
            new global::Luny.LuaList<global::UnityEngine.Rendering.BatchFilterSettings>(instances);
        private LuaBatchFilterSettings(in global::UnityEngine.Rendering.BatchFilterSettings value) => m_Value = value;
        public static implicit operator global::Lua.LuaValue(LuaBatchFilterSettings value) => new(value);
        private global::UnityEngine.Rendering.BatchFilterSettings m_Value;
        public global::UnityEngine.Rendering.BatchFilterSettings Value { get => m_Value; set => m_Value = value; }
        public ref global::UnityEngine.Rendering.BatchFilterSettings ValueRef => ref m_Value;
        public global::System.Type BindType => typeof(global::UnityEngine.Rendering.BatchFilterSettings);
        public override global::System.String ToString() => m_Value.ToString();
#if UNITY_EDITOR
        [global::UnityEngine.RuntimeInitializeOnLoadMethod(global::UnityEngine.RuntimeInitializeLoadType.SubsystemRegistration)]
        private static void ResetStaticFields() => s_Metatable = null;
#endif

        private static readonly global::Lua.LuaFunction __index = new(global::Lua.Runtime.Metamethods.Index, (_context, _) =>
        {
            var _this = _context.GetArgument<LuaBatchFilterSettings>(0);
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
            var _this = _context.GetArgument<LuaBatchFilterSettings>(0);
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
                case "allDepthSorted": _value = new global::Lua.LuaValue(m_Value.allDepthSorted); return true;
                case "batchLayer": _value = new global::Lua.LuaValue(m_Value.batchLayer); return true;
                case "motionMode": _value = new global::Lua.LuaValue((global::System.Int64)m_Value.motionMode); return true;
                case "receiveShadows": _value = new global::Lua.LuaValue(m_Value.receiveShadows); return true;
                case "sceneCullingMask": _value = new global::Lua.LuaValue(m_Value.sceneCullingMask); return true;
                case "shadowCastingMode": _value = new global::Lua.LuaValue((global::System.Int64)m_Value.shadowCastingMode); return true;
                case "staticShadowCaster": _value = new global::Lua.LuaValue(m_Value.staticShadowCaster); return true;
                case "layer": _value = new global::Lua.LuaValue(m_Value.layer); return true;
                case "rendererPriority": _value = new global::Lua.LuaValue(m_Value.rendererPriority); return true;
                case "renderingLayerMask": _value = new global::Lua.LuaValue(m_Value.renderingLayerMask); return true;
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
                case "allDepthSorted": { var _temp = m_Value; _temp.allDepthSorted = _value.Read<global::System.Boolean>(); m_Value = _temp; } return true;
                case "batchLayer": { var _temp = m_Value; _temp.batchLayer = _value.Read<global::System.Byte>(); m_Value = _temp; } return true;
                case "motionMode": { var _temp = m_Value; _temp.motionMode = _value.Read<global::UnityEngine.MotionVectorGenerationMode>(); m_Value = _temp; } return true;
                case "receiveShadows": { var _temp = m_Value; _temp.receiveShadows = _value.Read<global::System.Boolean>(); m_Value = _temp; } return true;
                case "sceneCullingMask": { var _temp = m_Value; _temp.sceneCullingMask = _value.Read<global::System.UInt64>(); m_Value = _temp; } return true;
                case "shadowCastingMode": { var _temp = m_Value; _temp.shadowCastingMode = _value.Read<global::UnityEngine.Rendering.ShadowCastingMode>(); m_Value = _temp; } return true;
                case "staticShadowCaster": { var _temp = m_Value; _temp.staticShadowCaster = _value.Read<global::System.Boolean>(); m_Value = _temp; } return true;
                case "layer": { var _temp = m_Value; _temp.layer = _value.Read<global::System.Byte>(); m_Value = _temp; } return true;
                case "rendererPriority": { var _temp = m_Value; _temp.rendererPriority = _value.Read<global::System.Int32>(); m_Value = _temp; } return true;
                case "renderingLayerMask": { var _temp = m_Value; _temp.renderingLayerMask = _value.Read<global::System.UInt32>(); m_Value = _temp; } return true;
                default: return false;
            }
        }
    }
    public sealed class LuaBatchFilterSettingsType : global::Luny.ILuaStatic
    {
        public static global::Lua.LuaValue Bind() => new LuaBatchFilterSettingsType();
        private LuaBatchFilterSettingsType() {}
        public static implicit operator global::Lua.LuaValue(LuaBatchFilterSettingsType value) => new(value);
        public global::System.Type BindType => typeof(global::UnityEngine.Rendering.BatchFilterSettings);
        public override global::System.String ToString() => BindType.FullName;
#if UNITY_EDITOR
        [global::UnityEngine.RuntimeInitializeOnLoadMethod(global::UnityEngine.RuntimeInitializeLoadType.SubsystemRegistration)]
        private static void ResetStaticFields() => s_Metatable = null;
#endif

        private static readonly global::Lua.LuaFunction __index = new(global::Lua.Runtime.Metamethods.Index, (_context, _) =>
        {
            var _this = _context.GetArgument<LuaBatchFilterSettingsType>(0);
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
            var _this = _context.GetArgument<LuaBatchFilterSettingsType>(0);
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
