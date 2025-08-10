
// --------------------------------------------------------------
// GENERATED FILE ----> DO NOT EDIT <---- CHANGES WILL BE LOST !!
// --------------------------------------------------------------

#if UNITY_6000_1_OR_NEWER && !(UNITY_6000_2_OR_NEWER)
#pragma warning disable 0109, 0162, 0168, 0219
using Luny;

namespace Luny.UnityEditor.Rendering
{
    public sealed class LuaTierSettings : global::Luny.ILuaValueType<global::UnityEditor.Rendering.TierSettings>
    {
        public new static global::Lua.LuaValue Bind(in global::UnityEditor.Rendering.TierSettings instance) => new LuaTierSettings(instance);
        public new static global::Lua.LuaValue Bind(global::System.Object instance) => Bind((global::UnityEditor.Rendering.TierSettings)instance);
        public new static global::Lua.LuaValue Bind(global::System.Collections.Generic.IList<global::UnityEditor.Rendering.TierSettings> instances) =>
            new global::Luny.LuaList<global::UnityEditor.Rendering.TierSettings>(instances);
        public new static global::Lua.LuaValue Bind(global::System.Collections.Generic.IList<global::System.Object> instances) =>
            new global::Luny.LuaList<global::UnityEditor.Rendering.TierSettings>(instances);
        private LuaTierSettings(in global::UnityEditor.Rendering.TierSettings value) => m_Value = value;
        public static implicit operator global::Lua.LuaValue(LuaTierSettings value) => new(value);
        private global::UnityEditor.Rendering.TierSettings m_Value;
        public global::UnityEditor.Rendering.TierSettings Value { get => m_Value; set => m_Value = value; }
        public ref global::UnityEditor.Rendering.TierSettings ValueRef => ref m_Value;
        public global::System.Type BindType => typeof(global::UnityEditor.Rendering.TierSettings);
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
            var _this = _context.GetArgument<LuaTierSettings>(0);
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
            var _this = _context.GetArgument<LuaTierSettings>(0);
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
                case "cascadedShadowMaps": _value = new global::Lua.LuaValue(m_Value.cascadedShadowMaps); return true;
                case "detailNormalMap": _value = new global::Lua.LuaValue(m_Value.detailNormalMap); return true;
                case "enableLPPV": _value = new global::Lua.LuaValue(m_Value.enableLPPV); return true;
                case "hdr": _value = new global::Lua.LuaValue(m_Value.hdr); return true;
                case "hdrMode": _value = new global::Lua.LuaValue((global::System.Int64)m_Value.hdrMode); return true;
                case "prefer32BitShadowMaps": _value = new global::Lua.LuaValue(m_Value.prefer32BitShadowMaps); return true;
                case "realtimeGICPUUsage": _value = new global::Lua.LuaValue((global::System.Int64)m_Value.realtimeGICPUUsage); return true;
                case "reflectionProbeBlending": _value = new global::Lua.LuaValue(m_Value.reflectionProbeBlending); return true;
                case "reflectionProbeBoxProjection": _value = new global::Lua.LuaValue(m_Value.reflectionProbeBoxProjection); return true;
                case "renderingPath": _value = new global::Lua.LuaValue((global::System.Int64)m_Value.renderingPath); return true;
                case "semitransparentShadows": _value = new global::Lua.LuaValue(m_Value.semitransparentShadows); return true;
                case "standardShaderQuality": _value = new global::Lua.LuaValue((global::System.Int64)m_Value.standardShaderQuality); return true;
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
                case "cascadedShadowMaps": { var _temp = m_Value; _temp.cascadedShadowMaps = _value.Read<global::System.Boolean>(); m_Value = _temp; } return true;
                case "detailNormalMap": { var _temp = m_Value; _temp.detailNormalMap = _value.Read<global::System.Boolean>(); m_Value = _temp; } return true;
                case "enableLPPV": { var _temp = m_Value; _temp.enableLPPV = _value.Read<global::System.Boolean>(); m_Value = _temp; } return true;
                case "hdr": { var _temp = m_Value; _temp.hdr = _value.Read<global::System.Boolean>(); m_Value = _temp; } return true;
                case "hdrMode": { var _temp = m_Value; _temp.hdrMode = _value.Read<global::UnityEngine.Rendering.CameraHDRMode>(); m_Value = _temp; } return true;
                case "prefer32BitShadowMaps": { var _temp = m_Value; _temp.prefer32BitShadowMaps = _value.Read<global::System.Boolean>(); m_Value = _temp; } return true;
                case "realtimeGICPUUsage": { var _temp = m_Value; _temp.realtimeGICPUUsage = _value.Read<global::UnityEngine.Rendering.RealtimeGICPUUsage>(); m_Value = _temp; } return true;
                case "reflectionProbeBlending": { var _temp = m_Value; _temp.reflectionProbeBlending = _value.Read<global::System.Boolean>(); m_Value = _temp; } return true;
                case "reflectionProbeBoxProjection": { var _temp = m_Value; _temp.reflectionProbeBoxProjection = _value.Read<global::System.Boolean>(); m_Value = _temp; } return true;
                case "renderingPath": { var _temp = m_Value; _temp.renderingPath = _value.Read<global::UnityEngine.RenderingPath>(); m_Value = _temp; } return true;
                case "semitransparentShadows": { var _temp = m_Value; _temp.semitransparentShadows = _value.Read<global::System.Boolean>(); m_Value = _temp; } return true;
                case "standardShaderQuality": { var _temp = m_Value; _temp.standardShaderQuality = _value.Read<global::UnityEditor.Rendering.ShaderQuality>(); m_Value = _temp; } return true;
                default: return false;
            }
        }
    }
    public sealed class LuaTierSettingsType : global::Luny.ILuaStatic
    {
        public static global::Lua.LuaValue Bind() => new LuaTierSettingsType();
        private LuaTierSettingsType() {}
        public static implicit operator global::Lua.LuaValue(LuaTierSettingsType value) => new(value);
        public global::System.Type BindType => typeof(global::UnityEditor.Rendering.TierSettings);
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
            var _this = _context.GetArgument<LuaTierSettingsType>(0);
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
            var _this = _context.GetArgument<LuaTierSettingsType>(0);
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
