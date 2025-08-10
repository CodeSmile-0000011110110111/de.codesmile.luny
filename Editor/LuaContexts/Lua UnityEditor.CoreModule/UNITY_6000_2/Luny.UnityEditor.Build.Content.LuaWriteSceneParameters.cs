
// --------------------------------------------------------------
// GENERATED FILE ----> DO NOT EDIT <---- CHANGES WILL BE LOST !!
// --------------------------------------------------------------

#if UNITY_6000_2_OR_NEWER && !(UNITY_6000_3_OR_NEWER)
#pragma warning disable 0109, 0162, 0168, 0219
using Luny;

namespace Luny.UnityEditor.Build.Content
{
    public sealed class LuaWriteSceneParameters : global::Luny.ILuaValueType<global::UnityEditor.Build.Content.WriteSceneParameters>
    {
        public new static global::Lua.LuaValue Bind(in global::UnityEditor.Build.Content.WriteSceneParameters instance) => new LuaWriteSceneParameters(instance);
        public new static global::Lua.LuaValue Bind(global::System.Object instance) => Bind((global::UnityEditor.Build.Content.WriteSceneParameters)instance);
        public new static global::Lua.LuaValue Bind(global::System.Collections.Generic.IList<global::UnityEditor.Build.Content.WriteSceneParameters> instances) =>
            new global::Luny.LuaList<global::UnityEditor.Build.Content.WriteSceneParameters>(instances);
        public new static global::Lua.LuaValue Bind(global::System.Collections.Generic.IList<global::System.Object> instances) =>
            new global::Luny.LuaList<global::UnityEditor.Build.Content.WriteSceneParameters>(instances);
        private LuaWriteSceneParameters(in global::UnityEditor.Build.Content.WriteSceneParameters value) => m_Value = value;
        public static implicit operator global::Lua.LuaValue(LuaWriteSceneParameters value) => new(value);
        private global::UnityEditor.Build.Content.WriteSceneParameters m_Value;
        public global::UnityEditor.Build.Content.WriteSceneParameters Value { get => m_Value; set => m_Value = value; }
        public ref global::UnityEditor.Build.Content.WriteSceneParameters ValueRef => ref m_Value;
        public global::System.Type BindType => typeof(global::UnityEditor.Build.Content.WriteSceneParameters);
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
            var _this = _context.GetArgument<LuaWriteSceneParameters>(0);
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
            var _this = _context.GetArgument<LuaWriteSceneParameters>(0);
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
                case "globalUsage": _value = global::Luny.UnityEditor.Build.Content.LuaBuildUsageTagGlobal.Bind(m_Value.globalUsage); return true;
                case "preloadInfo": _value = _factory.Bind(m_Value.preloadInfo); return true;
                case "referenceMap": _value = _factory.Bind(m_Value.referenceMap); return true;
                case "sceneBundleInfo": _value = _factory.Bind(m_Value.sceneBundleInfo); return true;
                case "scenePath": _value = new global::Lua.LuaValue(m_Value.scenePath); return true;
                case "settings": _value = global::Luny.UnityEditor.Build.Content.LuaBuildSettings.Bind(m_Value.settings); return true;
                case "usageSet": _value = _factory.Bind(m_Value.usageSet); return true;
                case "writeCommand": _value = _factory.Bind(m_Value.writeCommand); return true;
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
                case "globalUsage": { var _temp = m_Value; _temp.globalUsage = _value.Read<global::Luny.UnityEditor.Build.Content.LuaBuildUsageTagGlobal>().Value; m_Value = _temp; } return true;
                case "preloadInfo": { var _temp = m_Value; _temp.preloadInfo = _value.Read<global::Luny.UnityEditor.Build.Content.LuaPreloadInfo>().Instance; m_Value = _temp; } return true;
                case "referenceMap": { var _temp = m_Value; _temp.referenceMap = _value.Read<global::Luny.UnityEditor.Build.Content.LuaBuildReferenceMap>().Instance; m_Value = _temp; } return true;
                case "sceneBundleInfo": { var _temp = m_Value; _temp.sceneBundleInfo = _value.Read<global::Luny.UnityEditor.Build.Content.LuaSceneBundleInfo>().Instance; m_Value = _temp; } return true;
                case "scenePath": { var _temp = m_Value; _temp.scenePath = _value.Read<global::System.String>(); m_Value = _temp; } return true;
                case "settings": { var _temp = m_Value; _temp.settings = _value.Read<global::Luny.UnityEditor.Build.Content.LuaBuildSettings>().Value; m_Value = _temp; } return true;
                case "usageSet": { var _temp = m_Value; _temp.usageSet = _value.Read<global::Luny.UnityEditor.Build.Content.LuaBuildUsageTagSet>().Instance; m_Value = _temp; } return true;
                case "writeCommand": { var _temp = m_Value; _temp.writeCommand = _value.Read<global::Luny.UnityEditor.Build.Content.LuaWriteCommand>().Instance; m_Value = _temp; } return true;
                default: return false;
            }
        }
    }
    public sealed class LuaWriteSceneParametersType : global::Luny.ILuaStatic
    {
        public static global::Lua.LuaValue Bind() => new LuaWriteSceneParametersType();
        private LuaWriteSceneParametersType() {}
        public static implicit operator global::Lua.LuaValue(LuaWriteSceneParametersType value) => new(value);
        public global::System.Type BindType => typeof(global::UnityEditor.Build.Content.WriteSceneParameters);
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
            var _this = _context.GetArgument<LuaWriteSceneParametersType>(0);
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
            var _this = _context.GetArgument<LuaWriteSceneParametersType>(0);
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
