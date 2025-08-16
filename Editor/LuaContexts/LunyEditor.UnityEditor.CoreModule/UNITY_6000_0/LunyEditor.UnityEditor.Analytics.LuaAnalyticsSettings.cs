
// --------------------------------------------------------------
// GENERATED FILE ----> DO NOT EDIT <---- CHANGES WILL BE LOST !!
// --------------------------------------------------------------

#if UNITY_6000_0_OR_NEWER && !(UNITY_6000_1_OR_NEWER)
#pragma warning disable 0109, 0162, 0168, 0219
using Luny;

namespace LunyEditor.UnityEditor.Analytics
{
    public sealed class LuaAnalyticsSettingsType : global::Luny.ILuaStatic
    {
        public static global::Lua.LuaValue Bind() => new LuaAnalyticsSettingsType();
        private LuaAnalyticsSettingsType() {}
        public static implicit operator global::Lua.LuaValue(LuaAnalyticsSettingsType value) => new(value);
        public global::System.Type BindType => typeof(global::UnityEditor.Analytics.AnalyticsSettings);
        public override global::System.String ToString() => BindType.FullName;
#if UNITY_EDITOR
        [global::UnityEngine.RuntimeInitializeOnLoadMethod(global::UnityEngine.RuntimeInitializeLoadType.SubsystemRegistration)]
        private static void ResetStaticFields() => s_Metatable = null;
#endif

        private static readonly global::Lua.LuaFunction __index = new(global::Lua.Runtime.Metamethods.Index, (_context, _) =>
        {
            var _this = _context.GetArgument<LuaAnalyticsSettingsType>(0);
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
            var _this = _context.GetArgument<LuaAnalyticsSettingsType>(0);
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
                case "configUrl": _value = new global::Lua.LuaValue(global::UnityEditor.Analytics.AnalyticsSettings.configUrl); return true;
                case "dashboardUrl": _value = new global::Lua.LuaValue(global::UnityEditor.Analytics.AnalyticsSettings.dashboardUrl); return true;
                case "deviceStatsEnabledInBuild": _value = new global::Lua.LuaValue(global::UnityEditor.Analytics.AnalyticsSettings.deviceStatsEnabledInBuild); return true;
                case "enabled": _value = new global::Lua.LuaValue(global::UnityEditor.Analytics.AnalyticsSettings.enabled); return true;
                case "eventUrl": _value = new global::Lua.LuaValue(global::UnityEditor.Analytics.AnalyticsSettings.eventUrl); return true;
                case "initializeOnStartup": _value = new global::Lua.LuaValue(global::UnityEditor.Analytics.AnalyticsSettings.initializeOnStartup); return true;
                case "packageRequiringCoreStatsPresent": _value = new global::Lua.LuaValue(global::UnityEditor.Analytics.AnalyticsSettings.packageRequiringCoreStatsPresent); return true;
                case "testMode": _value = new global::Lua.LuaValue(global::UnityEditor.Analytics.AnalyticsSettings.testMode); return true;
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
                case "configUrl": global::UnityEditor.Analytics.AnalyticsSettings.configUrl = _value.Read<global::System.String>();  return true;
                case "dashboardUrl": global::UnityEditor.Analytics.AnalyticsSettings.dashboardUrl = _value.Read<global::System.String>();  return true;
                case "enabled": global::UnityEditor.Analytics.AnalyticsSettings.enabled = _value.Read<global::System.Boolean>();  return true;
                case "eventUrl": global::UnityEditor.Analytics.AnalyticsSettings.eventUrl = _value.Read<global::System.String>();  return true;
                case "initializeOnStartup": global::UnityEditor.Analytics.AnalyticsSettings.initializeOnStartup = _value.Read<global::System.Boolean>();  return true;
                case "packageRequiringCoreStatsPresent": global::UnityEditor.Analytics.AnalyticsSettings.packageRequiringCoreStatsPresent = _value.Read<global::System.Boolean>();  return true;
                case "testMode": global::UnityEditor.Analytics.AnalyticsSettings.testMode = _value.Read<global::System.Boolean>();  return true;
                default: return false;
            }
        }
    }
}
#pragma warning restore 0109, 0162, 0168, 0219
#endif
