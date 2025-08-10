
// --------------------------------------------------------------
// GENERATED FILE ----> DO NOT EDIT <---- CHANGES WILL BE LOST !!
// --------------------------------------------------------------

#if UNITY_6000_2_OR_NEWER && !(UNITY_6000_3_OR_NEWER)
#pragma warning disable 0109, 0162, 0168, 0219
using Luny;

namespace Luny.UnityEditor.Sprites
{
    public sealed class LuaAtlasSettings : global::Luny.ILuaValueType<global::UnityEditor.Sprites.AtlasSettings>
    {
        public new static global::Lua.LuaValue Bind(in global::UnityEditor.Sprites.AtlasSettings instance) => new LuaAtlasSettings(instance);
        public new static global::Lua.LuaValue Bind(global::System.Object instance) => Bind((global::UnityEditor.Sprites.AtlasSettings)instance);
        public new static global::Lua.LuaValue Bind(global::System.Collections.Generic.IList<global::UnityEditor.Sprites.AtlasSettings> instances) =>
            new global::Luny.LuaList<global::UnityEditor.Sprites.AtlasSettings>(instances);
        public new static global::Lua.LuaValue Bind(global::System.Collections.Generic.IList<global::System.Object> instances) =>
            new global::Luny.LuaList<global::UnityEditor.Sprites.AtlasSettings>(instances);
        private LuaAtlasSettings(in global::UnityEditor.Sprites.AtlasSettings value) => m_Value = value;
        public static implicit operator global::Lua.LuaValue(LuaAtlasSettings value) => new(value);
        private global::UnityEditor.Sprites.AtlasSettings m_Value;
        public global::UnityEditor.Sprites.AtlasSettings Value { get => m_Value; set => m_Value = value; }
        public ref global::UnityEditor.Sprites.AtlasSettings ValueRef => ref m_Value;
        public global::System.Type BindType => typeof(global::UnityEditor.Sprites.AtlasSettings);
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
            var _this = _context.GetArgument<LuaAtlasSettings>(0);
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
            var _this = _context.GetArgument<LuaAtlasSettings>(0);
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
                case "allowsAlphaSplitting": _value = new global::Lua.LuaValue(m_Value.allowsAlphaSplitting); return true;
                case "anisoLevel": _value = new global::Lua.LuaValue(m_Value.anisoLevel); return true;
                case "colorSpace": _value = new global::Lua.LuaValue((global::System.Int64)m_Value.colorSpace); return true;
                case "compressionQuality": _value = new global::Lua.LuaValue(m_Value.compressionQuality); return true;
                case "enableRotation": _value = new global::Lua.LuaValue(m_Value.enableRotation); return true;
                case "filterMode": _value = new global::Lua.LuaValue((global::System.Int64)m_Value.filterMode); return true;
                case "format": _value = new global::Lua.LuaValue((global::System.Int64)m_Value.format); return true;
                case "generateMipMaps": _value = new global::Lua.LuaValue(m_Value.generateMipMaps); return true;
                case "maxHeight": _value = new global::Lua.LuaValue(m_Value.maxHeight); return true;
                case "maxWidth": _value = new global::Lua.LuaValue(m_Value.maxWidth); return true;
                case "paddingPower": _value = new global::Lua.LuaValue(m_Value.paddingPower); return true;
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
                case "allowsAlphaSplitting": { var _temp = m_Value; _temp.allowsAlphaSplitting = _value.Read<global::System.Boolean>(); m_Value = _temp; } return true;
                case "anisoLevel": { var _temp = m_Value; _temp.anisoLevel = _value.Read<global::System.Int32>(); m_Value = _temp; } return true;
                case "colorSpace": { var _temp = m_Value; _temp.colorSpace = _value.Read<global::UnityEngine.ColorSpace>(); m_Value = _temp; } return true;
                case "compressionQuality": { var _temp = m_Value; _temp.compressionQuality = _value.Read<global::System.Int32>(); m_Value = _temp; } return true;
                case "enableRotation": { var _temp = m_Value; _temp.enableRotation = _value.Read<global::System.Boolean>(); m_Value = _temp; } return true;
                case "filterMode": { var _temp = m_Value; _temp.filterMode = _value.Read<global::UnityEngine.FilterMode>(); m_Value = _temp; } return true;
                case "format": { var _temp = m_Value; _temp.format = _value.Read<global::UnityEngine.TextureFormat>(); m_Value = _temp; } return true;
                case "generateMipMaps": { var _temp = m_Value; _temp.generateMipMaps = _value.Read<global::System.Boolean>(); m_Value = _temp; } return true;
                case "maxHeight": { var _temp = m_Value; _temp.maxHeight = _value.Read<global::System.Int32>(); m_Value = _temp; } return true;
                case "maxWidth": { var _temp = m_Value; _temp.maxWidth = _value.Read<global::System.Int32>(); m_Value = _temp; } return true;
                case "paddingPower": { var _temp = m_Value; _temp.paddingPower = _value.Read<global::System.UInt32>(); m_Value = _temp; } return true;
                default: return false;
            }
        }
    }
    public sealed class LuaAtlasSettingsType : global::Luny.ILuaStatic
    {
        public static global::Lua.LuaValue Bind() => new LuaAtlasSettingsType();
        private LuaAtlasSettingsType() {}
        public static implicit operator global::Lua.LuaValue(LuaAtlasSettingsType value) => new(value);
        public global::System.Type BindType => typeof(global::UnityEditor.Sprites.AtlasSettings);
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
            var _this = _context.GetArgument<LuaAtlasSettingsType>(0);
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
            var _this = _context.GetArgument<LuaAtlasSettingsType>(0);
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
