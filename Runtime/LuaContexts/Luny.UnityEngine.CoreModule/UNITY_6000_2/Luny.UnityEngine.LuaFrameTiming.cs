
// --------------------------------------------------------------
// GENERATED FILE ----> DO NOT EDIT <---- CHANGES WILL BE LOST !!
// --------------------------------------------------------------

#if UNITY_6000_2_OR_NEWER && !(UNITY_6000_3_OR_NEWER)
#pragma warning disable 0109, 0162, 0168, 0219
using Luny;

namespace Luny.UnityEngine
{
    public sealed class LuaFrameTiming : global::Luny.ILuaValueType<global::UnityEngine.FrameTiming>
    {
        public new static global::Lua.LuaValue Bind(in global::UnityEngine.FrameTiming instance) => new LuaFrameTiming(instance);
        public new static global::Lua.LuaValue Bind(global::System.Object instance) => Bind((global::UnityEngine.FrameTiming)instance);
        public new static global::Lua.LuaValue Bind(global::System.Collections.Generic.IList<global::UnityEngine.FrameTiming> instances) =>
            new global::Luny.LuaList<global::UnityEngine.FrameTiming>(instances);
        public new static global::Lua.LuaValue Bind(global::System.Collections.Generic.IList<global::System.Object> instances) =>
            new global::Luny.LuaList<global::UnityEngine.FrameTiming>(instances);
        private LuaFrameTiming(in global::UnityEngine.FrameTiming value) => m_Value = value;
        public static implicit operator global::Lua.LuaValue(LuaFrameTiming value) => new(value);
        private global::UnityEngine.FrameTiming m_Value;
        public global::UnityEngine.FrameTiming Value { get => m_Value; set => m_Value = value; }
        public ref global::UnityEngine.FrameTiming ValueRef => ref m_Value;
        public global::System.Type BindType => typeof(global::UnityEngine.FrameTiming);
        private static global::Lua.LuaTable s_Metatable;
        public global::Lua.LuaTable Metatable
        {
            get => s_Metatable ??= CreateMetatable();
            set => throw new global::System.NotSupportedException("LuaObject metatables cannot be modified");
        }
        global::System.Span<global::Lua.LuaValue> global::Lua.ILuaUserData.UserValues => default;
        private static global::Lua.LuaTable CreateMetatable()
        {
            var metatable = new global::Lua.LuaTable(0, 4);
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
            var _this = _context.GetArgument<LuaFrameTiming>(0);
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
            var _this = _context.GetArgument<LuaFrameTiming>(0);
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
                case "cpuFrameTime": _value = new global::Lua.LuaValue(m_Value.cpuFrameTime); return true;
                case "cpuMainThreadFrameTime": _value = new global::Lua.LuaValue(m_Value.cpuMainThreadFrameTime); return true;
                case "cpuMainThreadPresentWaitTime": _value = new global::Lua.LuaValue(m_Value.cpuMainThreadPresentWaitTime); return true;
                case "cpuRenderThreadFrameTime": _value = new global::Lua.LuaValue(m_Value.cpuRenderThreadFrameTime); return true;
                case "cpuTimeFrameComplete": _value = new global::Lua.LuaValue(m_Value.cpuTimeFrameComplete); return true;
                case "cpuTimePresentCalled": _value = new global::Lua.LuaValue(m_Value.cpuTimePresentCalled); return true;
                case "firstSubmitTimestamp": _value = new global::Lua.LuaValue(m_Value.firstSubmitTimestamp); return true;
                case "frameStartTimestamp": _value = new global::Lua.LuaValue(m_Value.frameStartTimestamp); return true;
                case "gpuFrameTime": _value = new global::Lua.LuaValue(m_Value.gpuFrameTime); return true;
                case "heightScale": _value = new global::Lua.LuaValue(m_Value.heightScale); return true;
                case "syncInterval": _value = new global::Lua.LuaValue(m_Value.syncInterval); return true;
                case "widthScale": _value = new global::Lua.LuaValue(m_Value.widthScale); return true;
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
                case "cpuFrameTime": { var _temp = m_Value; _temp.cpuFrameTime = _value.Read<global::System.Double>(); m_Value = _temp; } return true;
                case "cpuMainThreadFrameTime": { var _temp = m_Value; _temp.cpuMainThreadFrameTime = _value.Read<global::System.Double>(); m_Value = _temp; } return true;
                case "cpuMainThreadPresentWaitTime": { var _temp = m_Value; _temp.cpuMainThreadPresentWaitTime = _value.Read<global::System.Double>(); m_Value = _temp; } return true;
                case "cpuRenderThreadFrameTime": { var _temp = m_Value; _temp.cpuRenderThreadFrameTime = _value.Read<global::System.Double>(); m_Value = _temp; } return true;
                case "cpuTimeFrameComplete": { var _temp = m_Value; _temp.cpuTimeFrameComplete = _value.Read<global::System.UInt64>(); m_Value = _temp; } return true;
                case "cpuTimePresentCalled": { var _temp = m_Value; _temp.cpuTimePresentCalled = _value.Read<global::System.UInt64>(); m_Value = _temp; } return true;
                case "firstSubmitTimestamp": { var _temp = m_Value; _temp.firstSubmitTimestamp = _value.Read<global::System.UInt64>(); m_Value = _temp; } return true;
                case "frameStartTimestamp": { var _temp = m_Value; _temp.frameStartTimestamp = _value.Read<global::System.UInt64>(); m_Value = _temp; } return true;
                case "gpuFrameTime": { var _temp = m_Value; _temp.gpuFrameTime = _value.Read<global::System.Double>(); m_Value = _temp; } return true;
                case "heightScale": { var _temp = m_Value; _temp.heightScale = _value.Read<global::System.Single>(); m_Value = _temp; } return true;
                case "syncInterval": { var _temp = m_Value; _temp.syncInterval = _value.Read<global::System.UInt32>(); m_Value = _temp; } return true;
                case "widthScale": { var _temp = m_Value; _temp.widthScale = _value.Read<global::System.Single>(); m_Value = _temp; } return true;
                default: return false;
            }
        }
    }
    public sealed class LuaFrameTimingType : global::Luny.ILuaStatic
    {
        public static global::Lua.LuaValue Bind() => new LuaFrameTimingType();
        private LuaFrameTimingType() {}
        public static implicit operator global::Lua.LuaValue(LuaFrameTimingType value) => new(value);
        public global::System.Type BindType => typeof(global::UnityEngine.FrameTiming);
        private static global::Lua.LuaTable s_Metatable;
        public global::Lua.LuaTable Metatable
        {
            get => s_Metatable ??= CreateMetatable();
            set => throw new global::System.NotSupportedException("LuaObject metatables cannot be modified");
        }
        global::System.Span<global::Lua.LuaValue> global::Lua.ILuaUserData.UserValues => default;
        private static global::Lua.LuaTable CreateMetatable()
        {
            var metatable = new global::Lua.LuaTable(0, 4);
            metatable[global::Lua.Runtime.Metamethods.Index] = __index;
            metatable[global::Lua.Runtime.Metamethods.NewIndex] = __newindex;
            metatable[global::Lua.Runtime.Metamethods.Concat] = global::Luny.LuaMetatable.ConcatMetamethod;
            metatable[global::Lua.Runtime.Metamethods.ToString] = global::Luny.LuaMetatable.ToStringMetamethod;
            return metatable;
        }
        public override global::System.String ToString() => BindType.FullName;
#if UNITY_EDITOR
        [global::UnityEngine.RuntimeInitializeOnLoadMethod(global::UnityEngine.RuntimeInitializeLoadType.SubsystemRegistration)]
        private static void ResetStaticFields() => s_Metatable = null;
#endif

        private static readonly global::Lua.LuaFunction __index = new(global::Lua.Runtime.Metamethods.Index, (_context, _) =>
        {
            var _this = _context.GetArgument<LuaFrameTimingType>(0);
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
            var _this = _context.GetArgument<LuaFrameTimingType>(0);
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
