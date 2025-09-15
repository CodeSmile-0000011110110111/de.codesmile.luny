
// --------------------------------------------------------------
// GENERATED FILE ----> DO NOT EDIT <---- CHANGES WILL BE LOST !!
// --------------------------------------------------------------

#if UNITY_6000_0_OR_NEWER && !(UNITY_6000_1_OR_NEWER)
#pragma warning disable 0109, 0162, 0168, 0219
using Luny;

namespace Luny.UnityEngine.Rendering
{
    public sealed class LuaBatchCullingOutputDrawCommands : global::Luny.ILuaValueType<global::UnityEngine.Rendering.BatchCullingOutputDrawCommands>
    {
        public new static global::Lua.LuaValue Bind(in global::UnityEngine.Rendering.BatchCullingOutputDrawCommands instance) => new LuaBatchCullingOutputDrawCommands(instance);
        public new static global::Lua.LuaValue Bind(global::System.Object instance) => Bind((global::UnityEngine.Rendering.BatchCullingOutputDrawCommands)instance);
        public new static global::Lua.LuaValue Bind(global::System.Collections.Generic.IList<global::UnityEngine.Rendering.BatchCullingOutputDrawCommands> instances) =>
            new global::Luny.LuaList<global::UnityEngine.Rendering.BatchCullingOutputDrawCommands>(instances);
        public new static global::Lua.LuaValue Bind(global::System.Collections.Generic.IList<global::System.Object> instances) =>
            new global::Luny.LuaList<global::UnityEngine.Rendering.BatchCullingOutputDrawCommands>(instances);
        private LuaBatchCullingOutputDrawCommands(in global::UnityEngine.Rendering.BatchCullingOutputDrawCommands value) => m_Value = value;
        public static implicit operator global::Lua.LuaValue(LuaBatchCullingOutputDrawCommands value) => new(value);
        private global::UnityEngine.Rendering.BatchCullingOutputDrawCommands m_Value;
        public global::UnityEngine.Rendering.BatchCullingOutputDrawCommands Value { get => m_Value; set => m_Value = value; }
        public ref global::UnityEngine.Rendering.BatchCullingOutputDrawCommands ValueRef => ref m_Value;
        public global::System.Type BindType => typeof(global::UnityEngine.Rendering.BatchCullingOutputDrawCommands);
        public override global::System.String ToString() => m_Value.ToString();
#if UNITY_EDITOR
        [global::UnityEngine.RuntimeInitializeOnLoadMethod(global::UnityEngine.RuntimeInitializeLoadType.SubsystemRegistration)]
        private static void ResetStaticFields() => s_Metatable = null;
#endif

        private static readonly global::Lua.LuaFunction __index = new(global::Lua.Runtime.Metamethods.Index, (_context, _) =>
        {
            var _this = _context.GetArgument<LuaBatchCullingOutputDrawCommands>(0);
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
            var _this = _context.GetArgument<LuaBatchCullingOutputDrawCommands>(0);
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
                case "drawCommandCount": _value = new global::Lua.LuaValue(m_Value.drawCommandCount); return true;
                case "drawRangeCount": _value = new global::Lua.LuaValue(m_Value.drawRangeCount); return true;
                case "indirectDrawCommandCount": _value = new global::Lua.LuaValue(m_Value.indirectDrawCommandCount); return true;
                case "instanceSortingPositionFloatCount": _value = new global::Lua.LuaValue(m_Value.instanceSortingPositionFloatCount); return true;
                case "proceduralDrawCommandCount": _value = new global::Lua.LuaValue(m_Value.proceduralDrawCommandCount); return true;
                case "proceduralIndirectDrawCommandCount": _value = new global::Lua.LuaValue(m_Value.proceduralIndirectDrawCommandCount); return true;
                case "visibleInstanceCount": _value = new global::Lua.LuaValue(m_Value.visibleInstanceCount); return true;
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
                case "drawCommandCount": { var _temp = m_Value; _temp.drawCommandCount = _value.Read<global::System.Int32>(); m_Value = _temp; } return true;
                case "drawRangeCount": { var _temp = m_Value; _temp.drawRangeCount = _value.Read<global::System.Int32>(); m_Value = _temp; } return true;
                case "indirectDrawCommandCount": { var _temp = m_Value; _temp.indirectDrawCommandCount = _value.Read<global::System.Int32>(); m_Value = _temp; } return true;
                case "instanceSortingPositionFloatCount": { var _temp = m_Value; _temp.instanceSortingPositionFloatCount = _value.Read<global::System.Int32>(); m_Value = _temp; } return true;
                case "proceduralDrawCommandCount": { var _temp = m_Value; _temp.proceduralDrawCommandCount = _value.Read<global::System.Int32>(); m_Value = _temp; } return true;
                case "proceduralIndirectDrawCommandCount": { var _temp = m_Value; _temp.proceduralIndirectDrawCommandCount = _value.Read<global::System.Int32>(); m_Value = _temp; } return true;
                case "visibleInstanceCount": { var _temp = m_Value; _temp.visibleInstanceCount = _value.Read<global::System.Int32>(); m_Value = _temp; } return true;
                default: return false;
            }
        }
    }
    public sealed class LuaBatchCullingOutputDrawCommandsType : global::Luny.ILuaStatic
    {
        public static global::Lua.LuaValue Bind() => new LuaBatchCullingOutputDrawCommandsType();
        private LuaBatchCullingOutputDrawCommandsType() {}
        public static implicit operator global::Lua.LuaValue(LuaBatchCullingOutputDrawCommandsType value) => new(value);
        public global::System.Type BindType => typeof(global::UnityEngine.Rendering.BatchCullingOutputDrawCommands);
        public override global::System.String ToString() => BindType.FullName;
#if UNITY_EDITOR
        [global::UnityEngine.RuntimeInitializeOnLoadMethod(global::UnityEngine.RuntimeInitializeLoadType.SubsystemRegistration)]
        private static void ResetStaticFields() => s_Metatable = null;
#endif

        private static readonly global::Lua.LuaFunction __index = new(global::Lua.Runtime.Metamethods.Index, (_context, _) =>
        {
            var _this = _context.GetArgument<LuaBatchCullingOutputDrawCommandsType>(0);
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
            var _this = _context.GetArgument<LuaBatchCullingOutputDrawCommandsType>(0);
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
