
// --------------------------------------------------------------
// GENERATED FILE ----> DO NOT EDIT <---- CHANGES WILL BE LOST !!
// --------------------------------------------------------------

#if UNITY_6000_0_OR_NEWER && !(UNITY_6000_1_OR_NEWER)
#pragma warning disable 0109, 0162, 0168, 0219
using Luny;

namespace LunyEditor.UnityEditor
{
    public sealed class LuaPlayerSettingsWSA : global::Luny.ILuaObject<global::UnityEditor.PlayerSettings.WSA>
    {
        public new static global::Lua.LuaValue Bind(global::UnityEditor.PlayerSettings.WSA instance) => new LuaPlayerSettingsWSA(instance);
        public new static global::Lua.LuaValue Bind(global::System.Object instance) => Bind((global::UnityEditor.PlayerSettings.WSA)instance);
        public new static global::Lua.LuaValue Bind(global::System.Collections.Generic.IList<global::UnityEditor.PlayerSettings.WSA> instances) =>
            new global::Luny.LuaList<global::UnityEditor.PlayerSettings.WSA>(instances);
        public new static global::Lua.LuaValue Bind(global::System.Collections.Generic.IList<global::System.Object> instances) =>
            new global::Luny.LuaList<global::UnityEditor.PlayerSettings.WSA>(instances);
        private LuaPlayerSettingsWSA(global::UnityEditor.PlayerSettings.WSA instance) => m_Instance = instance;
        public static implicit operator global::Lua.LuaValue(LuaPlayerSettingsWSA value) => new(value);
        private global::UnityEditor.PlayerSettings.WSA m_Instance;
        public global::UnityEditor.PlayerSettings.WSA Instance => m_Instance;
        public new global::System.Type BindType => typeof(global::UnityEditor.PlayerSettings.WSA);
        public override global::System.String ToString() => m_Instance != null ? Instance.ToString() : "{GetType().Name}(null)";
#if UNITY_EDITOR
        [global::UnityEngine.RuntimeInitializeOnLoadMethod(global::UnityEngine.RuntimeInitializeLoadType.SubsystemRegistration)]
        private static void ResetStaticFields() => s_Metatable = null;
#endif

        private static readonly global::Lua.LuaFunction __index = new(global::Lua.Runtime.Metamethods.Index, (_context, _) =>
        {
            var _this = _context.GetArgument<LuaPlayerSettingsWSA>(0);
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
            var _this = _context.GetArgument<LuaPlayerSettingsWSA>(0);
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
    public sealed class LuaPlayerSettingsWSAType : global::Luny.ILuaStatic
    {
        public static global::Lua.LuaValue Bind() => new LuaPlayerSettingsWSAType();
        private LuaPlayerSettingsWSAType() {}
        public static implicit operator global::Lua.LuaValue(LuaPlayerSettingsWSAType value) => new(value);
        public global::System.Type BindType => typeof(global::UnityEditor.PlayerSettings.WSA);
        public override global::System.String ToString() => BindType.FullName;
#if UNITY_EDITOR
        [global::UnityEngine.RuntimeInitializeOnLoadMethod(global::UnityEngine.RuntimeInitializeLoadType.SubsystemRegistration)]
        private static void ResetStaticFields() => s_Metatable = null;
#endif

        private static readonly global::Lua.LuaFunction _LuaPlayerSettingsWSA_new = new global::Lua.LuaFunction(".ctor", (_context, _) =>
        {
            global::Lua.LuaValue _lastArg = default;
            global::System.Int32 _lastArgPos = default;
            global::System.Type _expectedType = default;
            var _argCount = _context.ArgumentCount;
            if (_argCount == 1)
            {
                var _ret0 = new global::UnityEditor.PlayerSettings.WSA();
                var _factory = _context.GetObjectFactory();
                var _lret0 = _factory.Bind(_ret0);
                var _retCount = _context.Return(_lret0);
                return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
            }
            throw new global::Lua.LuaRuntimeException(_context.Thread, $"{".ctor"}: invalid argument #{_lastArgPos}: {_lastArg} ({_lastArg.Type}), expected: {_expectedType.FullName}", 2);
        });
        private static readonly global::Lua.LuaFunction _LuaPlayerSettingsWSA_GetCapability = new global::Lua.LuaFunction("GetCapability", (_context, _) =>
        {
            global::Lua.LuaValue _lastArg = default;
            global::System.Int32 _lastArgPos = default;
            global::System.Type _expectedType = default;
            var _argCount = _context.ArgumentCount;
            var _arg0 = _lastArg = _argCount > 0 ? _context.GetArgument(0) : global::Lua.LuaValue.Nil;
            _lastArgPos = 0; _expectedType = typeof(global::UnityEditor.PlayerSettings.WSACapability);
            if (_arg0.TryRead<global::UnityEditor.PlayerSettings.WSACapability>(out var _p0_UnityEditor_PlayerSettings_WSACapability))
            {
                if (_argCount == 1)
                {
                    var capability = _p0_UnityEditor_PlayerSettings_WSACapability;
                    var _ret0 = global::UnityEditor.PlayerSettings.WSA.GetCapability(capability);
                    var _lret0 = new global::Lua.LuaValue(_ret0);
                    var _retCount = _context.Return(_lret0);
                    return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                }
            }
            throw new global::Lua.LuaRuntimeException(_context.Thread, $"{"GetCapability"}: invalid argument #{_lastArgPos}: {_lastArg} ({_lastArg.Type}), expected: {_expectedType.FullName}", 2);
        });
        private static readonly global::Lua.LuaFunction _LuaPlayerSettingsWSA_GetTargetDeviceFamily = new global::Lua.LuaFunction("GetTargetDeviceFamily", (_context, _) =>
        {
            global::Lua.LuaValue _lastArg = default;
            global::System.Int32 _lastArgPos = default;
            global::System.Type _expectedType = default;
            var _argCount = _context.ArgumentCount;
            var _arg0 = _lastArg = _argCount > 0 ? _context.GetArgument(0) : global::Lua.LuaValue.Nil;
            _lastArgPos = 0; _expectedType = typeof(global::UnityEditor.PlayerSettings.WSATargetFamily);
            if (_arg0.TryRead<global::UnityEditor.PlayerSettings.WSATargetFamily>(out var _p0_UnityEditor_PlayerSettings_WSATargetFamily))
            {
                if (_argCount == 1)
                {
                    var family = _p0_UnityEditor_PlayerSettings_WSATargetFamily;
                    var _ret0 = global::UnityEditor.PlayerSettings.WSA.GetTargetDeviceFamily(family);
                    var _lret0 = new global::Lua.LuaValue(_ret0);
                    var _retCount = _context.Return(_lret0);
                    return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                }
            }
            throw new global::Lua.LuaRuntimeException(_context.Thread, $"{"GetTargetDeviceFamily"}: invalid argument #{_lastArgPos}: {_lastArg} ({_lastArg.Type}), expected: {_expectedType.FullName}", 2);
        });
        private static readonly global::Lua.LuaFunction _LuaPlayerSettingsWSA_GetVisualAssetsImage = new global::Lua.LuaFunction("GetVisualAssetsImage", (_context, _) =>
        {
            global::Lua.LuaValue _lastArg = default;
            global::System.Int32 _lastArgPos = default;
            global::System.Type _expectedType = default;
            var _argCount = _context.ArgumentCount;
            var _arg0 = _lastArg = _argCount > 0 ? _context.GetArgument(0) : global::Lua.LuaValue.Nil;
            _lastArgPos = 0; _expectedType = typeof(global::UnityEditor.PlayerSettings.WSAImageType);
            if (_arg0.TryRead<global::UnityEditor.PlayerSettings.WSAImageType>(out var _p0_UnityEditor_PlayerSettings_WSAImageType))
            {
                var _arg1 = _lastArg = _argCount > 1 ? _context.GetArgument(1) : global::Lua.LuaValue.Nil;
                _lastArgPos = 1; _expectedType = typeof(global::UnityEditor.PlayerSettings.WSAImageScale);
                if (_arg1.TryRead<global::UnityEditor.PlayerSettings.WSAImageScale>(out var _p1_UnityEditor_PlayerSettings_WSAImageScale))
                {
                    if (_argCount == 2)
                    {
                        var type = _p0_UnityEditor_PlayerSettings_WSAImageType;
                        var scale = _p1_UnityEditor_PlayerSettings_WSAImageScale;
                        var _ret0 = global::UnityEditor.PlayerSettings.WSA.GetVisualAssetsImage(type, scale);
                        var _lret0 = new global::Lua.LuaValue(_ret0);
                        var _retCount = _context.Return(_lret0);
                        return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                    }
                }
            }
            throw new global::Lua.LuaRuntimeException(_context.Thread, $"{"GetVisualAssetsImage"}: invalid argument #{_lastArgPos}: {_lastArg} ({_lastArg.Type}), expected: {_expectedType.FullName}", 2);
        });
        private static readonly global::Lua.LuaFunction _LuaPlayerSettingsWSA_SetCapability = new global::Lua.LuaFunction("SetCapability", (_context, _) =>
        {
            global::Lua.LuaValue _lastArg = default;
            global::System.Int32 _lastArgPos = default;
            global::System.Type _expectedType = default;
            var _argCount = _context.ArgumentCount;
            var _arg0 = _lastArg = _argCount > 0 ? _context.GetArgument(0) : global::Lua.LuaValue.Nil;
            _lastArgPos = 0; _expectedType = typeof(global::UnityEditor.PlayerSettings.WSACapability);
            if (_arg0.TryRead<global::UnityEditor.PlayerSettings.WSACapability>(out var _p0_UnityEditor_PlayerSettings_WSACapability))
            {
                var _arg1 = _lastArg = _argCount > 1 ? _context.GetArgument(1) : global::Lua.LuaValue.Nil;
                _lastArgPos = 1; _expectedType = typeof(global::System.Boolean);
                if (_arg1.TryRead<global::System.Boolean>(out var _p1_System_Boolean))
                {
                    if (_argCount == 2)
                    {
                        var capability = _p0_UnityEditor_PlayerSettings_WSACapability;
                        var value = _p1_System_Boolean;
                        global::UnityEditor.PlayerSettings.WSA.SetCapability(capability, value);
                        var _retCount = _context.Return();
                        return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                    }
                }
            }
            throw new global::Lua.LuaRuntimeException(_context.Thread, $"{"SetCapability"}: invalid argument #{_lastArgPos}: {_lastArg} ({_lastArg.Type}), expected: {_expectedType.FullName}", 2);
        });
        private static readonly global::Lua.LuaFunction _LuaPlayerSettingsWSA_SetCertificate = new global::Lua.LuaFunction("SetCertificate", (_context, _) =>
        {
            global::Lua.LuaValue _lastArg = default;
            global::System.Int32 _lastArgPos = default;
            global::System.Type _expectedType = default;
            var _argCount = _context.ArgumentCount;
            var _arg0 = _lastArg = _argCount > 0 ? _context.GetArgument(0) : global::Lua.LuaValue.Nil;
            _lastArgPos = 0; _expectedType = typeof(global::System.String);
            if (_arg0.TryRead<global::System.String>(out var _p0_System_String))
            {
                var _arg1 = _lastArg = _argCount > 1 ? _context.GetArgument(1) : global::Lua.LuaValue.Nil;
                _lastArgPos = 1; _expectedType = typeof(global::System.String);
                if (_arg1.TryRead<global::System.String>(out var _p1_System_String))
                {
                    if (_argCount == 2)
                    {
                        var path = _p0_System_String;
                        var password = _p1_System_String;
                        var _ret0 = global::UnityEditor.PlayerSettings.WSA.SetCertificate(path, password);
                        var _lret0 = new global::Lua.LuaValue(_ret0);
                        var _retCount = _context.Return(_lret0);
                        return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                    }
                }
            }
            throw new global::Lua.LuaRuntimeException(_context.Thread, $"{"SetCertificate"}: invalid argument #{_lastArgPos}: {_lastArg} ({_lastArg.Type}), expected: {_expectedType.FullName}", 2);
        });
        private static readonly global::Lua.LuaFunction _LuaPlayerSettingsWSA_SetTargetDeviceFamily = new global::Lua.LuaFunction("SetTargetDeviceFamily", (_context, _) =>
        {
            global::Lua.LuaValue _lastArg = default;
            global::System.Int32 _lastArgPos = default;
            global::System.Type _expectedType = default;
            var _argCount = _context.ArgumentCount;
            var _arg0 = _lastArg = _argCount > 0 ? _context.GetArgument(0) : global::Lua.LuaValue.Nil;
            _lastArgPos = 0; _expectedType = typeof(global::UnityEditor.PlayerSettings.WSATargetFamily);
            if (_arg0.TryRead<global::UnityEditor.PlayerSettings.WSATargetFamily>(out var _p0_UnityEditor_PlayerSettings_WSATargetFamily))
            {
                var _arg1 = _lastArg = _argCount > 1 ? _context.GetArgument(1) : global::Lua.LuaValue.Nil;
                _lastArgPos = 1; _expectedType = typeof(global::System.Boolean);
                if (_arg1.TryRead<global::System.Boolean>(out var _p1_System_Boolean))
                {
                    if (_argCount == 2)
                    {
                        var family = _p0_UnityEditor_PlayerSettings_WSATargetFamily;
                        var value = _p1_System_Boolean;
                        global::UnityEditor.PlayerSettings.WSA.SetTargetDeviceFamily(family, value);
                        var _retCount = _context.Return();
                        return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                    }
                }
            }
            throw new global::Lua.LuaRuntimeException(_context.Thread, $"{"SetTargetDeviceFamily"}: invalid argument #{_lastArgPos}: {_lastArg} ({_lastArg.Type}), expected: {_expectedType.FullName}", 2);
        });
        private static readonly global::Lua.LuaFunction _LuaPlayerSettingsWSA_SetVisualAssetsImage = new global::Lua.LuaFunction("SetVisualAssetsImage", (_context, _) =>
        {
            global::Lua.LuaValue _lastArg = default;
            global::System.Int32 _lastArgPos = default;
            global::System.Type _expectedType = default;
            var _argCount = _context.ArgumentCount;
            var _arg0 = _lastArg = _argCount > 0 ? _context.GetArgument(0) : global::Lua.LuaValue.Nil;
            _lastArgPos = 0; _expectedType = typeof(global::System.String);
            if (_arg0.TryRead<global::System.String>(out var _p0_System_String))
            {
                var _arg1 = _lastArg = _argCount > 1 ? _context.GetArgument(1) : global::Lua.LuaValue.Nil;
                _lastArgPos = 1; _expectedType = typeof(global::UnityEditor.PlayerSettings.WSAImageType);
                if (_arg1.TryRead<global::UnityEditor.PlayerSettings.WSAImageType>(out var _p1_UnityEditor_PlayerSettings_WSAImageType))
                {
                    var _arg2 = _lastArg = _argCount > 2 ? _context.GetArgument(2) : global::Lua.LuaValue.Nil;
                    _lastArgPos = 2; _expectedType = typeof(global::UnityEditor.PlayerSettings.WSAImageScale);
                    if (_arg2.TryRead<global::UnityEditor.PlayerSettings.WSAImageScale>(out var _p2_UnityEditor_PlayerSettings_WSAImageScale))
                    {
                        if (_argCount == 3)
                        {
                            var image = _p0_System_String;
                            var type = _p1_UnityEditor_PlayerSettings_WSAImageType;
                            var scale = _p2_UnityEditor_PlayerSettings_WSAImageScale;
                            global::UnityEditor.PlayerSettings.WSA.SetVisualAssetsImage(image, type, scale);
                            var _retCount = _context.Return();
                            return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                        }
                    }
                }
            }
            throw new global::Lua.LuaRuntimeException(_context.Thread, $"{"SetVisualAssetsImage"}: invalid argument #{_lastArgPos}: {_lastArg} ({_lastArg.Type}), expected: {_expectedType.FullName}", 2);
        });
        private static readonly global::Lua.LuaFunction __index = new(global::Lua.Runtime.Metamethods.Index, (_context, _) =>
        {
            var _this = _context.GetArgument<LuaPlayerSettingsWSAType>(0);
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
            var _this = _context.GetArgument<LuaPlayerSettingsWSAType>(0);
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
            metatable[global::Lua.Runtime.Metamethods.Call] = _LuaPlayerSettingsWSA_new;
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
                case "GetCapability": _value = _LuaPlayerSettingsWSA_GetCapability; return true;
                case "GetTargetDeviceFamily": _value = _LuaPlayerSettingsWSA_GetTargetDeviceFamily; return true;
                case "GetVisualAssetsImage": _value = _LuaPlayerSettingsWSA_GetVisualAssetsImage; return true;
                case "SetCapability": _value = _LuaPlayerSettingsWSA_SetCapability; return true;
                case "SetCertificate": _value = _LuaPlayerSettingsWSA_SetCertificate; return true;
                case "SetTargetDeviceFamily": _value = _LuaPlayerSettingsWSA_SetTargetDeviceFamily; return true;
                case "SetVisualAssetsImage": _value = _LuaPlayerSettingsWSA_SetVisualAssetsImage; return true;
                case "applicationDescription": _value = new global::Lua.LuaValue(global::UnityEditor.PlayerSettings.WSA.applicationDescription); return true;
                case "certificateIssuer": _value = new global::Lua.LuaValue(global::UnityEditor.PlayerSettings.WSA.certificateIssuer); return true;
                case "certificatePath": _value = new global::Lua.LuaValue(global::UnityEditor.PlayerSettings.WSA.certificatePath); return true;
                case "certificateSubject": _value = new global::Lua.LuaValue(global::UnityEditor.PlayerSettings.WSA.certificateSubject); return true;
                case "defaultTileSize": _value = new global::Lua.LuaValue((global::System.Int64)global::UnityEditor.PlayerSettings.WSA.defaultTileSize); return true;
                case "inputSource": _value = new global::Lua.LuaValue((global::System.Int64)global::UnityEditor.PlayerSettings.WSA.inputSource); return true;
                case "largeTileShowName": _value = new global::Lua.LuaValue(global::UnityEditor.PlayerSettings.WSA.largeTileShowName); return true;
                case "lastRequiredScene": _value = new global::Lua.LuaValue(global::UnityEditor.PlayerSettings.WSA.lastRequiredScene); return true;
                case "mediumTileShowName": _value = new global::Lua.LuaValue(global::UnityEditor.PlayerSettings.WSA.mediumTileShowName); return true;
                case "packageName": _value = new global::Lua.LuaValue(global::UnityEditor.PlayerSettings.WSA.packageName); return true;
                case "packageVersion": _value = _factory.Bind(global::UnityEditor.PlayerSettings.WSA.packageVersion); return true;
                case "supportStreamingInstall": _value = new global::Lua.LuaValue(global::UnityEditor.PlayerSettings.WSA.supportStreamingInstall); return true;
                case "syncCapabilities": _value = new global::Lua.LuaValue(global::UnityEditor.PlayerSettings.WSA.syncCapabilities); return true;
                case "tileBackgroundColor": _value = global::Luny.UnityEngine.LuaColor.Bind(global::UnityEditor.PlayerSettings.WSA.tileBackgroundColor); return true;
                case "tileForegroundText": _value = new global::Lua.LuaValue((global::System.Int64)global::UnityEditor.PlayerSettings.WSA.tileForegroundText); return true;
                case "tileShortName": _value = new global::Lua.LuaValue(global::UnityEditor.PlayerSettings.WSA.tileShortName); return true;
                case "tileShowName": _value = new global::Lua.LuaValue((global::System.Int64)global::UnityEditor.PlayerSettings.WSA.tileShowName); return true;
                case "transparentSwapchain": _value = new global::Lua.LuaValue(global::UnityEditor.PlayerSettings.WSA.transparentSwapchain); return true;
                case "vcxProjDefaultLanguage": _value = new global::Lua.LuaValue(global::UnityEditor.PlayerSettings.WSA.vcxProjDefaultLanguage); return true;
                case "wideTileShowName": _value = new global::Lua.LuaValue(global::UnityEditor.PlayerSettings.WSA.wideTileShowName); return true;
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
                case "applicationDescription": global::UnityEditor.PlayerSettings.WSA.applicationDescription = _value.Read<global::System.String>();  return true;
                case "defaultTileSize": global::UnityEditor.PlayerSettings.WSA.defaultTileSize = _value.Read<global::UnityEditor.PlayerSettings.WSADefaultTileSize>();  return true;
                case "inputSource": global::UnityEditor.PlayerSettings.WSA.inputSource = _value.Read<global::UnityEditor.PlayerSettings.WSAInputSource>();  return true;
                case "largeTileShowName": global::UnityEditor.PlayerSettings.WSA.largeTileShowName = _value.Read<global::System.Boolean>();  return true;
                case "lastRequiredScene": global::UnityEditor.PlayerSettings.WSA.lastRequiredScene = _value.Read<global::System.Int32>();  return true;
                case "mediumTileShowName": global::UnityEditor.PlayerSettings.WSA.mediumTileShowName = _value.Read<global::System.Boolean>();  return true;
                case "packageName": global::UnityEditor.PlayerSettings.WSA.packageName = _value.Read<global::System.String>();  return true;
                case "packageVersion": global::UnityEditor.PlayerSettings.WSA.packageVersion = _value.Read<global::System.Version>();  return true;
                case "supportStreamingInstall": global::UnityEditor.PlayerSettings.WSA.supportStreamingInstall = _value.Read<global::System.Boolean>();  return true;
                case "syncCapabilities": global::UnityEditor.PlayerSettings.WSA.syncCapabilities = _value.Read<global::System.Boolean>();  return true;
                case "tileBackgroundColor": global::UnityEditor.PlayerSettings.WSA.tileBackgroundColor = _value.Read<global::Luny.UnityEngine.LuaColor>().Value;  return true;
                case "tileForegroundText": global::UnityEditor.PlayerSettings.WSA.tileForegroundText = _value.Read<global::UnityEditor.PlayerSettings.WSAApplicationForegroundText>();  return true;
                case "tileShortName": global::UnityEditor.PlayerSettings.WSA.tileShortName = _value.Read<global::System.String>();  return true;
                case "tileShowName": global::UnityEditor.PlayerSettings.WSA.tileShowName = _value.Read<global::UnityEditor.PlayerSettings.WSAApplicationShowName>();  return true;
                case "transparentSwapchain": global::UnityEditor.PlayerSettings.WSA.transparentSwapchain = _value.Read<global::System.Boolean>();  return true;
                case "vcxProjDefaultLanguage": global::UnityEditor.PlayerSettings.WSA.vcxProjDefaultLanguage = _value.Read<global::System.String>();  return true;
                case "wideTileShowName": global::UnityEditor.PlayerSettings.WSA.wideTileShowName = _value.Read<global::System.Boolean>();  return true;
                default: return false;
            }
        }
    }
}
#pragma warning restore 0109, 0162, 0168, 0219
#endif
