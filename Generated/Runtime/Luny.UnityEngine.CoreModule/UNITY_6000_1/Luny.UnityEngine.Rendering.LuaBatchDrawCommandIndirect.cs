
// --------------------------------------------------------------
// GENERATED FILE ----> DO NOT EDIT <---- CHANGES WILL BE LOST !!
// --------------------------------------------------------------

#if UNITY_6000_1_OR_NEWER && !(UNITY_6000_2_OR_NEWER)
#pragma warning disable 0109, 0162, 0168, 0219
using Luny;

namespace Luny.UnityEngine.Rendering
{
    public sealed class LuaBatchDrawCommandIndirect : global::Luny.ILuaValueType<global::UnityEngine.Rendering.BatchDrawCommandIndirect>
    {
        public new static global::Lua.LuaValue Bind(in global::UnityEngine.Rendering.BatchDrawCommandIndirect instance) => new LuaBatchDrawCommandIndirect(instance);
        public new static global::Lua.LuaValue Bind(global::System.Object instance) => Bind((global::UnityEngine.Rendering.BatchDrawCommandIndirect)instance);
        public new static global::Lua.LuaValue Bind(global::System.Collections.Generic.IList<global::UnityEngine.Rendering.BatchDrawCommandIndirect> instances) =>
            new global::Luny.LuaList<global::UnityEngine.Rendering.BatchDrawCommandIndirect>(instances);
        public new static global::Lua.LuaValue Bind(global::System.Collections.Generic.IList<global::System.Object> instances) =>
            new global::Luny.LuaList<global::UnityEngine.Rendering.BatchDrawCommandIndirect>(instances);
        private LuaBatchDrawCommandIndirect(in global::UnityEngine.Rendering.BatchDrawCommandIndirect value) => m_Value = value;
        public static implicit operator global::Lua.LuaValue(LuaBatchDrawCommandIndirect value) => new(value);
        private global::UnityEngine.Rendering.BatchDrawCommandIndirect m_Value;
        public global::UnityEngine.Rendering.BatchDrawCommandIndirect Value { get => m_Value; set => m_Value = value; }
        public ref global::UnityEngine.Rendering.BatchDrawCommandIndirect ValueRef => ref m_Value;
        public global::System.Type BindType => typeof(global::UnityEngine.Rendering.BatchDrawCommandIndirect);
        public override global::System.String ToString() => m_Value.ToString();
#if UNITY_EDITOR
        [global::UnityEngine.RuntimeInitializeOnLoadMethod(global::UnityEngine.RuntimeInitializeLoadType.SubsystemRegistration)]
        private static void ResetStaticFields() => s_Metatable = null;
#endif

        private static readonly global::Lua.LuaFunction __index = new(global::Lua.Runtime.Metamethods.Index, (_context, _) =>
        {
            var _this = _context.GetArgument<LuaBatchDrawCommandIndirect>(0);
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
            var _this = _context.GetArgument<LuaBatchDrawCommandIndirect>(0);
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
                case "batchID": _value = global::Luny.UnityEngine.Rendering.LuaBatchID.Bind(m_Value.batchID); return true;
                case "flags": _value = new global::Lua.LuaValue((global::System.Int64)m_Value.flags); return true;
                case "indirectArgsBufferHandle": _value = global::Luny.UnityEngine.LuaGraphicsBufferHandle.Bind(m_Value.indirectArgsBufferHandle); return true;
                case "indirectArgsBufferOffset": _value = new global::Lua.LuaValue(m_Value.indirectArgsBufferOffset); return true;
                case "lightmapIndex": _value = new global::Lua.LuaValue(m_Value.lightmapIndex); return true;
                case "materialID": _value = global::Luny.UnityEngine.Rendering.LuaBatchMaterialID.Bind(m_Value.materialID); return true;
                case "meshID": _value = global::Luny.UnityEngine.Rendering.LuaBatchMeshID.Bind(m_Value.meshID); return true;
                case "sortingPosition": _value = new global::Lua.LuaValue(m_Value.sortingPosition); return true;
                case "splitVisibilityMask": _value = new global::Lua.LuaValue(m_Value.splitVisibilityMask); return true;
                case "topology": _value = new global::Lua.LuaValue((global::System.Int64)m_Value.topology); return true;
                case "visibleInstancesBufferHandle": _value = global::Luny.UnityEngine.LuaGraphicsBufferHandle.Bind(m_Value.visibleInstancesBufferHandle); return true;
                case "visibleInstancesBufferWindowOffset": _value = new global::Lua.LuaValue(m_Value.visibleInstancesBufferWindowOffset); return true;
                case "visibleInstancesBufferWindowSizeBytes": _value = new global::Lua.LuaValue(m_Value.visibleInstancesBufferWindowSizeBytes); return true;
                case "visibleOffset": _value = new global::Lua.LuaValue(m_Value.visibleOffset); return true;
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
                case "batchID": { var _temp = m_Value; _temp.batchID = _value.Read<global::Luny.UnityEngine.Rendering.LuaBatchID>().Value; m_Value = _temp; } return true;
                case "flags": { var _temp = m_Value; _temp.flags = _value.Read<global::UnityEngine.Rendering.BatchDrawCommandFlags>(); m_Value = _temp; } return true;
                case "indirectArgsBufferHandle": { var _temp = m_Value; _temp.indirectArgsBufferHandle = _value.Read<global::Luny.UnityEngine.LuaGraphicsBufferHandle>().Value; m_Value = _temp; } return true;
                case "indirectArgsBufferOffset": { var _temp = m_Value; _temp.indirectArgsBufferOffset = _value.Read<global::System.UInt32>(); m_Value = _temp; } return true;
                case "lightmapIndex": { var _temp = m_Value; _temp.lightmapIndex = _value.Read<global::System.UInt16>(); m_Value = _temp; } return true;
                case "materialID": { var _temp = m_Value; _temp.materialID = _value.Read<global::Luny.UnityEngine.Rendering.LuaBatchMaterialID>().Value; m_Value = _temp; } return true;
                case "meshID": { var _temp = m_Value; _temp.meshID = _value.Read<global::Luny.UnityEngine.Rendering.LuaBatchMeshID>().Value; m_Value = _temp; } return true;
                case "sortingPosition": { var _temp = m_Value; _temp.sortingPosition = _value.Read<global::System.Int32>(); m_Value = _temp; } return true;
                case "splitVisibilityMask": { var _temp = m_Value; _temp.splitVisibilityMask = _value.Read<global::System.UInt16>(); m_Value = _temp; } return true;
                case "topology": { var _temp = m_Value; _temp.topology = _value.Read<global::UnityEngine.MeshTopology>(); m_Value = _temp; } return true;
                case "visibleInstancesBufferHandle": { var _temp = m_Value; _temp.visibleInstancesBufferHandle = _value.Read<global::Luny.UnityEngine.LuaGraphicsBufferHandle>().Value; m_Value = _temp; } return true;
                case "visibleInstancesBufferWindowOffset": { var _temp = m_Value; _temp.visibleInstancesBufferWindowOffset = _value.Read<global::System.UInt32>(); m_Value = _temp; } return true;
                case "visibleInstancesBufferWindowSizeBytes": { var _temp = m_Value; _temp.visibleInstancesBufferWindowSizeBytes = _value.Read<global::System.UInt32>(); m_Value = _temp; } return true;
                case "visibleOffset": { var _temp = m_Value; _temp.visibleOffset = _value.Read<global::System.UInt32>(); m_Value = _temp; } return true;
                default: return false;
            }
        }
    }
    public sealed class LuaBatchDrawCommandIndirectType : global::Luny.ILuaStatic
    {
        public static global::Lua.LuaValue Bind() => new LuaBatchDrawCommandIndirectType();
        private LuaBatchDrawCommandIndirectType() {}
        public static implicit operator global::Lua.LuaValue(LuaBatchDrawCommandIndirectType value) => new(value);
        public global::System.Type BindType => typeof(global::UnityEngine.Rendering.BatchDrawCommandIndirect);
        public override global::System.String ToString() => BindType.FullName;
#if UNITY_EDITOR
        [global::UnityEngine.RuntimeInitializeOnLoadMethod(global::UnityEngine.RuntimeInitializeLoadType.SubsystemRegistration)]
        private static void ResetStaticFields() => s_Metatable = null;
#endif

        private static readonly global::Lua.LuaFunction __index = new(global::Lua.Runtime.Metamethods.Index, (_context, _) =>
        {
            var _this = _context.GetArgument<LuaBatchDrawCommandIndirectType>(0);
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
            var _this = _context.GetArgument<LuaBatchDrawCommandIndirectType>(0);
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
