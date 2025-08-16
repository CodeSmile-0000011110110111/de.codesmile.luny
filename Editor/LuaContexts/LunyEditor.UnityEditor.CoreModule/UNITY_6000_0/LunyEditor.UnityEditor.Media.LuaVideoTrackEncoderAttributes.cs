
// --------------------------------------------------------------
// GENERATED FILE ----> DO NOT EDIT <---- CHANGES WILL BE LOST !!
// --------------------------------------------------------------

#if UNITY_6000_0_OR_NEWER && !(UNITY_6000_1_OR_NEWER)
#pragma warning disable 0109, 0162, 0168, 0219
using Luny;

namespace LunyEditor.UnityEditor.Media
{
    public sealed class LuaVideoTrackEncoderAttributes : global::Luny.ILuaValueType<global::UnityEditor.Media.VideoTrackEncoderAttributes>
    {
        public new static global::Lua.LuaValue Bind(in global::UnityEditor.Media.VideoTrackEncoderAttributes instance) => new LuaVideoTrackEncoderAttributes(instance);
        public new static global::Lua.LuaValue Bind(global::System.Object instance) => Bind((global::UnityEditor.Media.VideoTrackEncoderAttributes)instance);
        public new static global::Lua.LuaValue Bind(global::System.Collections.Generic.IList<global::UnityEditor.Media.VideoTrackEncoderAttributes> instances) =>
            new global::Luny.LuaList<global::UnityEditor.Media.VideoTrackEncoderAttributes>(instances);
        public new static global::Lua.LuaValue Bind(global::System.Collections.Generic.IList<global::System.Object> instances) =>
            new global::Luny.LuaList<global::UnityEditor.Media.VideoTrackEncoderAttributes>(instances);
        private LuaVideoTrackEncoderAttributes(in global::UnityEditor.Media.VideoTrackEncoderAttributes value) => m_Value = value;
        public static implicit operator global::Lua.LuaValue(LuaVideoTrackEncoderAttributes value) => new(value);
        private global::UnityEditor.Media.VideoTrackEncoderAttributes m_Value;
        public global::UnityEditor.Media.VideoTrackEncoderAttributes Value { get => m_Value; set => m_Value = value; }
        public ref global::UnityEditor.Media.VideoTrackEncoderAttributes ValueRef => ref m_Value;
        public global::System.Type BindType => typeof(global::UnityEditor.Media.VideoTrackEncoderAttributes);
        public override global::System.String ToString() => m_Value.ToString();
#if UNITY_EDITOR
        [global::UnityEngine.RuntimeInitializeOnLoadMethod(global::UnityEngine.RuntimeInitializeLoadType.SubsystemRegistration)]
        private static void ResetStaticFields() => s_Metatable = null;
#endif

        private static readonly global::Lua.LuaFunction __index = new(global::Lua.Runtime.Metamethods.Index, (_context, _) =>
        {
            var _this = _context.GetArgument<LuaVideoTrackEncoderAttributes>(0);
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
            var _this = _context.GetArgument<LuaVideoTrackEncoderAttributes>(0);
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
                case "bitRateMode": _value = new global::Lua.LuaValue((global::System.Int64)m_Value.bitRateMode); return true;
                case "frameRate": _value = global::LunyEditor.UnityEditor.Media.LuaMediaRational.Bind(m_Value.frameRate); return true;
                case "height": _value = new global::Lua.LuaValue(m_Value.height); return true;
                case "includeAlpha": _value = new global::Lua.LuaValue(m_Value.includeAlpha); return true;
                case "targetBitRate": _value = new global::Lua.LuaValue(m_Value.targetBitRate); return true;
                case "width": _value = new global::Lua.LuaValue(m_Value.width); return true;
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
                case "bitRateMode": { var _temp = m_Value; _temp.bitRateMode = _value.Read<global::UnityEditor.VideoBitrateMode>(); m_Value = _temp; } return true;
                case "frameRate": { var _temp = m_Value; _temp.frameRate = _value.Read<global::LunyEditor.UnityEditor.Media.LuaMediaRational>().Value; m_Value = _temp; } return true;
                case "height": { var _temp = m_Value; _temp.height = _value.Read<global::System.UInt32>(); m_Value = _temp; } return true;
                case "includeAlpha": { var _temp = m_Value; _temp.includeAlpha = _value.Read<global::System.Boolean>(); m_Value = _temp; } return true;
                case "targetBitRate": { var _temp = m_Value; _temp.targetBitRate = _value.Read<global::System.UInt32>(); m_Value = _temp; } return true;
                case "width": { var _temp = m_Value; _temp.width = _value.Read<global::System.UInt32>(); m_Value = _temp; } return true;
                default: return false;
            }
        }
    }
    public sealed class LuaVideoTrackEncoderAttributesType : global::Luny.ILuaStatic
    {
        public static global::Lua.LuaValue Bind() => new LuaVideoTrackEncoderAttributesType();
        private LuaVideoTrackEncoderAttributesType() {}
        public static implicit operator global::Lua.LuaValue(LuaVideoTrackEncoderAttributesType value) => new(value);
        public global::System.Type BindType => typeof(global::UnityEditor.Media.VideoTrackEncoderAttributes);
        public override global::System.String ToString() => BindType.FullName;
#if UNITY_EDITOR
        [global::UnityEngine.RuntimeInitializeOnLoadMethod(global::UnityEngine.RuntimeInitializeLoadType.SubsystemRegistration)]
        private static void ResetStaticFields() => s_Metatable = null;
#endif

        private static readonly global::Lua.LuaFunction _LuaVideoTrackEncoderAttributes_new = new global::Lua.LuaFunction(".ctor", (_context, _) =>
        {
            global::Lua.LuaValue _lastArg = default;
            global::System.Int32 _lastArgPos = default;
            global::System.Type _expectedType = default;
            var _argCount = _context.ArgumentCount;
            // ctor parameterless case
            if (_argCount == 1)
            {
                var _ret0 = new global::UnityEditor.Media.VideoTrackEncoderAttributes();
                var _lret0 = global::LunyEditor.UnityEditor.Media.LuaVideoTrackEncoderAttributes.Bind(_ret0);
                var _retCount = _context.Return(_lret0);
                return new global::System.Threading.Tasks.ValueTask<global::System.Int32>(_retCount);
            }
            var _arg0 = _lastArg = _argCount > 1 ? _context.GetArgument(1) : global::Lua.LuaValue.Nil;
            _lastArgPos = 0; _expectedType = typeof(global::LunyEditor.UnityEditor.Media.LuaH264EncoderAttributes);
            if (_arg0.TryRead<global::LunyEditor.UnityEditor.Media.LuaH264EncoderAttributes>(out var _p0_UnityEditor_Media_H264EncoderAttributes))
            {
                if (_argCount == 2)
                {
                    var h264Attrs = _p0_UnityEditor_Media_H264EncoderAttributes.Value;
                    var _ret0 = new global::UnityEditor.Media.VideoTrackEncoderAttributes(h264Attrs);
                    var _lret0 = global::LunyEditor.UnityEditor.Media.LuaVideoTrackEncoderAttributes.Bind(_ret0);
                    var _retCount = _context.Return(_lret0);
                    return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                }
            }
            _lastArgPos = 0; _expectedType = typeof(global::LunyEditor.UnityEditor.Media.LuaVP8EncoderAttributes);
            if (_arg0.TryRead<global::LunyEditor.UnityEditor.Media.LuaVP8EncoderAttributes>(out var _p0_UnityEditor_Media_VP8EncoderAttributes))
            {
                if (_argCount == 2)
                {
                    var vp8Attrs = _p0_UnityEditor_Media_VP8EncoderAttributes.Value;
                    var _ret0 = new global::UnityEditor.Media.VideoTrackEncoderAttributes(vp8Attrs);
                    var _lret0 = global::LunyEditor.UnityEditor.Media.LuaVideoTrackEncoderAttributes.Bind(_ret0);
                    var _retCount = _context.Return(_lret0);
                    return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                }
            }
            throw new global::Lua.LuaRuntimeException(_context.Thread, $"{".ctor"}: invalid argument #{_lastArgPos}: {_lastArg} ({_lastArg.Type}), expected: {_expectedType.FullName}", 2);
        });
        private static readonly global::Lua.LuaFunction __index = new(global::Lua.Runtime.Metamethods.Index, (_context, _) =>
        {
            var _this = _context.GetArgument<LuaVideoTrackEncoderAttributesType>(0);
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
            var _this = _context.GetArgument<LuaVideoTrackEncoderAttributesType>(0);
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
            metatable[global::Lua.Runtime.Metamethods.Call] = _LuaVideoTrackEncoderAttributes_new;
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
