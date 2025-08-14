
// --------------------------------------------------------------
// GENERATED FILE ----> DO NOT EDIT <---- CHANGES WILL BE LOST !!
// --------------------------------------------------------------

#if UNITY_6000_0_OR_NEWER && !(UNITY_6000_1_OR_NEWER)
#pragma warning disable 0109, 0162, 0168, 0219
using Luny;

namespace Luny.UnityEditor
{
    public sealed class LuaSettingsServiceType : global::Luny.ILuaStatic
    {
        public static global::Lua.LuaValue Bind() => new LuaSettingsServiceType();
        private LuaSettingsServiceType() {}
        public static implicit operator global::Lua.LuaValue(LuaSettingsServiceType value) => new(value);
        public global::System.Type BindType => typeof(global::UnityEditor.SettingsService);
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

        private static readonly global::Lua.LuaFunction _LuaSettingsService_Exists = new global::Lua.LuaFunction("Exists", (_context, _) =>
        {
            global::Lua.LuaValue _lastArg = default;
            global::System.Int32 _lastArgPos = default;
            global::System.Type _expectedType = default;
            var _argCount = _context.ArgumentCount;
            var _arg0 = _lastArg = _argCount > 0 ? _context.GetArgument(0) : global::Lua.LuaValue.Nil;
            _lastArgPos = 0; _expectedType = typeof(global::System.String);
            if (_arg0.TryRead<global::System.String>(out var _p0_System_String))
            {
                if (_argCount == 1)
                {
                    var settingsPath = _p0_System_String;
                    var _ret0 = global::UnityEditor.SettingsService.Exists(settingsPath);
                    var _lret0 = new global::Lua.LuaValue(_ret0);
                    var _retCount = _context.Return(_lret0);
                    return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                }
            }
            throw new global::Lua.LuaRuntimeException(_context.Thread, $"{"Exists"}: invalid argument #{_lastArgPos}: {_lastArg} ({_lastArg.Type}), expected: {_expectedType.FullName}", 2);
        });
        private static readonly global::Lua.LuaFunction _LuaSettingsService_NotifySettingsProviderChanged = new global::Lua.LuaFunction("NotifySettingsProviderChanged", (_context, _) =>
        {
            global::Lua.LuaValue _lastArg = default;
            global::System.Int32 _lastArgPos = default;
            global::System.Type _expectedType = default;
            var _argCount = _context.ArgumentCount;
            if (_argCount == 0)
            {
                global::UnityEditor.SettingsService.NotifySettingsProviderChanged();
                var _retCount = _context.Return();
                return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
            }
            throw new global::Lua.LuaRuntimeException(_context.Thread, $"{"NotifySettingsProviderChanged"}: invalid argument #{_lastArgPos}: {_lastArg} ({_lastArg.Type}), expected: {_expectedType.FullName}", 2);
        });
        private static readonly global::Lua.LuaFunction _LuaSettingsService_OpenProjectSettings = new global::Lua.LuaFunction("OpenProjectSettings", (_context, _) =>
        {
            global::Lua.LuaValue _lastArg = default;
            global::System.Int32 _lastArgPos = default;
            global::System.Type _expectedType = default;
            var _argCount = _context.ArgumentCount;
            if (_argCount == 0)
            {
                var _ret0 = global::UnityEditor.SettingsService.OpenProjectSettings();
                var _factory = _context.GetObjectFactory();
                var _lret0 = _factory.Bind(_ret0);
                var _retCount = _context.Return(_lret0);
                return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
            }
            var _arg0 = _lastArg = _argCount > 0 ? _context.GetArgument(0) : global::Lua.LuaValue.Nil;
            _lastArgPos = 0; _expectedType = typeof(global::System.String);
            var _p0_System_String = _arg0.ReadValue<global::System.String>(default);
            {
                if (_argCount == 1)
                {
                    var settingsPath = _p0_System_String;
                    var _ret0 = global::UnityEditor.SettingsService.OpenProjectSettings(settingsPath);
                    var _factory = _context.GetObjectFactory();
                    var _lret0 = _factory.Bind(_ret0);
                    var _retCount = _context.Return(_lret0);
                    return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                }
            }
            throw new global::Lua.LuaRuntimeException(_context.Thread, $"{"OpenProjectSettings"}: invalid argument #{_lastArgPos}: {_lastArg} ({_lastArg.Type}), expected: {_expectedType.FullName}", 2);
        });
        private static readonly global::Lua.LuaFunction _LuaSettingsService_OpenUserPreferences = new global::Lua.LuaFunction("OpenUserPreferences", (_context, _) =>
        {
            global::Lua.LuaValue _lastArg = default;
            global::System.Int32 _lastArgPos = default;
            global::System.Type _expectedType = default;
            var _argCount = _context.ArgumentCount;
            if (_argCount == 0)
            {
                var _ret0 = global::UnityEditor.SettingsService.OpenUserPreferences();
                var _factory = _context.GetObjectFactory();
                var _lret0 = _factory.Bind(_ret0);
                var _retCount = _context.Return(_lret0);
                return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
            }
            var _arg0 = _lastArg = _argCount > 0 ? _context.GetArgument(0) : global::Lua.LuaValue.Nil;
            _lastArgPos = 0; _expectedType = typeof(global::System.String);
            var _p0_System_String = _arg0.ReadValue<global::System.String>(default);
            {
                if (_argCount == 1)
                {
                    var settingsPath = _p0_System_String;
                    var _ret0 = global::UnityEditor.SettingsService.OpenUserPreferences(settingsPath);
                    var _factory = _context.GetObjectFactory();
                    var _lret0 = _factory.Bind(_ret0);
                    var _retCount = _context.Return(_lret0);
                    return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                }
            }
            throw new global::Lua.LuaRuntimeException(_context.Thread, $"{"OpenUserPreferences"}: invalid argument #{_lastArgPos}: {_lastArg} ({_lastArg.Type}), expected: {_expectedType.FullName}", 2);
        });
        private static readonly global::Lua.LuaFunction _LuaSettingsService_RepaintAllSettingsWindow = new global::Lua.LuaFunction("RepaintAllSettingsWindow", (_context, _) =>
        {
            global::Lua.LuaValue _lastArg = default;
            global::System.Int32 _lastArgPos = default;
            global::System.Type _expectedType = default;
            var _argCount = _context.ArgumentCount;
            if (_argCount == 0)
            {
                global::UnityEditor.SettingsService.RepaintAllSettingsWindow();
                var _retCount = _context.Return();
                return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
            }
            throw new global::Lua.LuaRuntimeException(_context.Thread, $"{"RepaintAllSettingsWindow"}: invalid argument #{_lastArgPos}: {_lastArg} ({_lastArg.Type}), expected: {_expectedType.FullName}", 2);
        });
        private static readonly global::Lua.LuaFunction __index = new(global::Lua.Runtime.Metamethods.Index, (_context, _) =>
        {
            var _this = _context.GetArgument<LuaSettingsServiceType>(0);
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
            var _this = _context.GetArgument<LuaSettingsServiceType>(0);
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
                case "Exists": _value = _LuaSettingsService_Exists; return true;
                case "NotifySettingsProviderChanged": _value = _LuaSettingsService_NotifySettingsProviderChanged; return true;
                case "OpenProjectSettings": _value = _LuaSettingsService_OpenProjectSettings; return true;
                case "OpenUserPreferences": _value = _LuaSettingsService_OpenUserPreferences; return true;
                case "RepaintAllSettingsWindow": _value = _LuaSettingsService_RepaintAllSettingsWindow; return true;
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
