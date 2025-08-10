
// --------------------------------------------------------------
// GENERATED FILE ----> DO NOT EDIT <---- CHANGES WILL BE LOST !!
// --------------------------------------------------------------

#if UNITY_6000_0_OR_NEWER && !(UNITY_6000_1_OR_NEWER)
#pragma warning disable 0109, 0162, 0168, 0219
using Luny;

namespace Luny.UnityEngine.Device
{
    public sealed class LuaApplicationType : global::Luny.ILuaStatic
    {
        public static global::Lua.LuaValue Bind() => new LuaApplicationType();
        private LuaApplicationType() {}
        public static implicit operator global::Lua.LuaValue(LuaApplicationType value) => new(value);
        public global::System.Type BindType => typeof(global::UnityEngine.Device.Application);
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

        private static readonly global::Lua.LuaFunction _LuaApplication_CanStreamedLevelBeLoaded = new global::Lua.LuaFunction("CanStreamedLevelBeLoaded", (_context, _) =>
        {
            global::Lua.LuaValue _lastArg = default;
            global::System.Int32 _lastArgPos = default;
            global::System.Type _expectedType = default;
            var _argCount = _context.ArgumentCount;
            var _arg0 = _lastArg = _argCount > 0 ? _context.GetArgument(0) : global::Lua.LuaValue.Nil;
            _lastArgPos = 0; _expectedType = typeof(global::System.Int32);
            if (_arg0.TryRead<global::System.Int32>(out var _p0_System_Int32))
            {
                if (_argCount == 1)
                {
                    var levelIndex = _p0_System_Int32;
                    var _ret0 = global::UnityEngine.Device.Application.CanStreamedLevelBeLoaded(levelIndex);
                    var _lret0 = new global::Lua.LuaValue(_ret0);
                    var _retCount = _context.Return(_lret0);
                    return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                }
            }
            _lastArgPos = 0; _expectedType = typeof(global::System.String);
            if (_arg0.TryRead<global::System.String>(out var _p0_System_String))
            {
                if (_argCount == 1)
                {
                    var levelName = _p0_System_String;
                    var _ret0 = global::UnityEngine.Device.Application.CanStreamedLevelBeLoaded(levelName);
                    var _lret0 = new global::Lua.LuaValue(_ret0);
                    var _retCount = _context.Return(_lret0);
                    return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                }
            }
            throw new global::Lua.LuaRuntimeException(_context.Thread, $"{"CanStreamedLevelBeLoaded"}: invalid argument #{_lastArgPos}: {_lastArg} ({_lastArg.Type}), expected: {_expectedType.FullName}", 2);
        });
        private static readonly global::Lua.LuaFunction _LuaApplication_GetStackTraceLogType = new global::Lua.LuaFunction("GetStackTraceLogType", (_context, _) =>
        {
            global::Lua.LuaValue _lastArg = default;
            global::System.Int32 _lastArgPos = default;
            global::System.Type _expectedType = default;
            var _argCount = _context.ArgumentCount;
            var _arg0 = _lastArg = _argCount > 0 ? _context.GetArgument(0) : global::Lua.LuaValue.Nil;
            _lastArgPos = 0; _expectedType = typeof(global::UnityEngine.LogType);
            if (_arg0.TryRead<global::UnityEngine.LogType>(out var _p0_UnityEngine_LogType))
            {
                if (_argCount == 1)
                {
                    var logType = _p0_UnityEngine_LogType;
                    var _ret0 = global::UnityEngine.Device.Application.GetStackTraceLogType(logType);
                    var _lret0 = new global::Lua.LuaValue((global::System.Int64)_ret0);
                    var _retCount = _context.Return(_lret0);
                    return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                }
            }
            throw new global::Lua.LuaRuntimeException(_context.Thread, $"{"GetStackTraceLogType"}: invalid argument #{_lastArgPos}: {_lastArg} ({_lastArg.Type}), expected: {_expectedType.FullName}", 2);
        });
        private static readonly global::Lua.LuaFunction _LuaApplication_HasProLicense = new global::Lua.LuaFunction("HasProLicense", (_context, _) =>
        {
            global::Lua.LuaValue _lastArg = default;
            global::System.Int32 _lastArgPos = default;
            global::System.Type _expectedType = default;
            var _argCount = _context.ArgumentCount;
            if (_argCount == 0)
            {
                var _ret0 = global::UnityEngine.Device.Application.HasProLicense();
                var _lret0 = new global::Lua.LuaValue(_ret0);
                var _retCount = _context.Return(_lret0);
                return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
            }
            throw new global::Lua.LuaRuntimeException(_context.Thread, $"{"HasProLicense"}: invalid argument #{_lastArgPos}: {_lastArg} ({_lastArg.Type}), expected: {_expectedType.FullName}", 2);
        });
        private static readonly global::Lua.LuaFunction _LuaApplication_HasUserAuthorization = new global::Lua.LuaFunction("HasUserAuthorization", (_context, _) =>
        {
            global::Lua.LuaValue _lastArg = default;
            global::System.Int32 _lastArgPos = default;
            global::System.Type _expectedType = default;
            var _argCount = _context.ArgumentCount;
            var _arg0 = _lastArg = _argCount > 0 ? _context.GetArgument(0) : global::Lua.LuaValue.Nil;
            _lastArgPos = 0; _expectedType = typeof(global::UnityEngine.UserAuthorization);
            if (_arg0.TryRead<global::UnityEngine.UserAuthorization>(out var _p0_UnityEngine_UserAuthorization))
            {
                if (_argCount == 1)
                {
                    var mode = _p0_UnityEngine_UserAuthorization;
                    var _ret0 = global::UnityEngine.Device.Application.HasUserAuthorization(mode);
                    var _lret0 = new global::Lua.LuaValue(_ret0);
                    var _retCount = _context.Return(_lret0);
                    return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                }
            }
            throw new global::Lua.LuaRuntimeException(_context.Thread, $"{"HasUserAuthorization"}: invalid argument #{_lastArgPos}: {_lastArg} ({_lastArg.Type}), expected: {_expectedType.FullName}", 2);
        });
        private static readonly global::Lua.LuaFunction _LuaApplication_IsPlaying = new global::Lua.LuaFunction("IsPlaying", (_context, _) =>
        {
            global::Lua.LuaValue _lastArg = default;
            global::System.Int32 _lastArgPos = default;
            global::System.Type _expectedType = default;
            var _argCount = _context.ArgumentCount;
            var _arg0 = _lastArg = _argCount > 0 ? _context.GetArgument(0) : global::Lua.LuaValue.Nil;
            _lastArgPos = 0; _expectedType = typeof(global::Luny.UnityEngine.LuaUnityObject);
            if (_arg0.TryRead<global::Luny.UnityEngine.LuaUnityObject>(out var _p0_UnityEngine_Object))
            {
                if (_argCount == 1)
                {
                    var obj = _p0_UnityEngine_Object.Instance;
                    var _ret0 = global::UnityEngine.Device.Application.IsPlaying(obj);
                    var _lret0 = new global::Lua.LuaValue(_ret0);
                    var _retCount = _context.Return(_lret0);
                    return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                }
            }
            throw new global::Lua.LuaRuntimeException(_context.Thread, $"{"IsPlaying"}: invalid argument #{_lastArgPos}: {_lastArg} ({_lastArg.Type}), expected: {_expectedType.FullName}", 2);
        });
        private static readonly global::Lua.LuaFunction _LuaApplication_OpenURL = new global::Lua.LuaFunction("OpenURL", (_context, _) =>
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
                    var url = _p0_System_String;
                    global::UnityEngine.Device.Application.OpenURL(url);
                    var _retCount = _context.Return();
                    return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                }
            }
            throw new global::Lua.LuaRuntimeException(_context.Thread, $"{"OpenURL"}: invalid argument #{_lastArgPos}: {_lastArg} ({_lastArg.Type}), expected: {_expectedType.FullName}", 2);
        });
        private static readonly global::Lua.LuaFunction _LuaApplication_Quit = new global::Lua.LuaFunction("Quit", (_context, _) =>
        {
            global::Lua.LuaValue _lastArg = default;
            global::System.Int32 _lastArgPos = default;
            global::System.Type _expectedType = default;
            var _argCount = _context.ArgumentCount;
            if (_argCount == 0)
            {
                global::UnityEngine.Device.Application.Quit();
                var _retCount = _context.Return();
                return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
            }
            var _arg0 = _lastArg = _argCount > 0 ? _context.GetArgument(0) : global::Lua.LuaValue.Nil;
            _lastArgPos = 0; _expectedType = typeof(global::System.Int32);
            if (_arg0.TryRead<global::System.Int32>(out var _p0_System_Int32))
            {
                if (_argCount == 1)
                {
                    var exitCode = _p0_System_Int32;
                    global::UnityEngine.Device.Application.Quit(exitCode);
                    var _retCount = _context.Return();
                    return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                }
            }
            throw new global::Lua.LuaRuntimeException(_context.Thread, $"{"Quit"}: invalid argument #{_lastArgPos}: {_lastArg} ({_lastArg.Type}), expected: {_expectedType.FullName}", 2);
        });
        private static readonly global::Lua.LuaFunction _LuaApplication_RequestAdvertisingIdentifierAsync = new global::Lua.LuaFunction("RequestAdvertisingIdentifierAsync", (_context, _) =>
        {
            global::Lua.LuaValue _lastArg = default;
            global::System.Int32 _lastArgPos = default;
            global::System.Type _expectedType = default;
            var _argCount = _context.ArgumentCount;
            var _arg0 = _lastArg = _argCount > 0 ? _context.GetArgument(0) : global::Lua.LuaValue.Nil;
            _lastArgPos = 0; _expectedType = typeof(global::UnityEngine.Application.AdvertisingIdentifierCallback);
            if (_arg0.TryRead<global::UnityEngine.Application.AdvertisingIdentifierCallback>(out var _p0_UnityEngine_Application_AdvertisingIdentifierCallback))
            {
                if (_argCount == 1)
                {
                    var delegateMethod = _p0_UnityEngine_Application_AdvertisingIdentifierCallback;
                    var _ret0 = global::UnityEngine.Device.Application.RequestAdvertisingIdentifierAsync(delegateMethod);
                    var _lret0 = new global::Lua.LuaValue(_ret0);
                    var _retCount = _context.Return(_lret0);
                    return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                }
            }
            throw new global::Lua.LuaRuntimeException(_context.Thread, $"{"RequestAdvertisingIdentifierAsync"}: invalid argument #{_lastArgPos}: {_lastArg} ({_lastArg.Type}), expected: {_expectedType.FullName}", 2);
        });
        private static readonly global::Lua.LuaFunction _LuaApplication_RequestUserAuthorization = new global::Lua.LuaFunction("RequestUserAuthorization", (_context, _) =>
        {
            global::Lua.LuaValue _lastArg = default;
            global::System.Int32 _lastArgPos = default;
            global::System.Type _expectedType = default;
            var _argCount = _context.ArgumentCount;
            var _arg0 = _lastArg = _argCount > 0 ? _context.GetArgument(0) : global::Lua.LuaValue.Nil;
            _lastArgPos = 0; _expectedType = typeof(global::UnityEngine.UserAuthorization);
            if (_arg0.TryRead<global::UnityEngine.UserAuthorization>(out var _p0_UnityEngine_UserAuthorization))
            {
                if (_argCount == 1)
                {
                    var mode = _p0_UnityEngine_UserAuthorization;
                    var _ret0 = global::UnityEngine.Device.Application.RequestUserAuthorization(mode);
                    var _factory = _context.GetObjectFactory();
                    var _lret0 = _factory.Bind(_ret0);
                    var _retCount = _context.Return(_lret0);
                    return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                }
            }
            throw new global::Lua.LuaRuntimeException(_context.Thread, $"{"RequestUserAuthorization"}: invalid argument #{_lastArgPos}: {_lastArg} ({_lastArg.Type}), expected: {_expectedType.FullName}", 2);
        });
        private static readonly global::Lua.LuaFunction _LuaApplication_SetStackTraceLogType = new global::Lua.LuaFunction("SetStackTraceLogType", (_context, _) =>
        {
            global::Lua.LuaValue _lastArg = default;
            global::System.Int32 _lastArgPos = default;
            global::System.Type _expectedType = default;
            var _argCount = _context.ArgumentCount;
            var _arg0 = _lastArg = _argCount > 0 ? _context.GetArgument(0) : global::Lua.LuaValue.Nil;
            _lastArgPos = 0; _expectedType = typeof(global::UnityEngine.LogType);
            if (_arg0.TryRead<global::UnityEngine.LogType>(out var _p0_UnityEngine_LogType))
            {
                var _arg1 = _lastArg = _argCount > 1 ? _context.GetArgument(1) : global::Lua.LuaValue.Nil;
                _lastArgPos = 1; _expectedType = typeof(global::UnityEngine.StackTraceLogType);
                if (_arg1.TryRead<global::UnityEngine.StackTraceLogType>(out var _p1_UnityEngine_StackTraceLogType))
                {
                    if (_argCount == 2)
                    {
                        var logType = _p0_UnityEngine_LogType;
                        var stackTraceType = _p1_UnityEngine_StackTraceLogType;
                        global::UnityEngine.Device.Application.SetStackTraceLogType(logType, stackTraceType);
                        var _retCount = _context.Return();
                        return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                    }
                }
            }
            throw new global::Lua.LuaRuntimeException(_context.Thread, $"{"SetStackTraceLogType"}: invalid argument #{_lastArgPos}: {_lastArg} ({_lastArg.Type}), expected: {_expectedType.FullName}", 2);
        });
        private static readonly global::Lua.LuaFunction _LuaApplication_Unload = new global::Lua.LuaFunction("Unload", (_context, _) =>
        {
            global::Lua.LuaValue _lastArg = default;
            global::System.Int32 _lastArgPos = default;
            global::System.Type _expectedType = default;
            var _argCount = _context.ArgumentCount;
            if (_argCount == 0)
            {
                global::UnityEngine.Device.Application.Unload();
                var _retCount = _context.Return();
                return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
            }
            throw new global::Lua.LuaRuntimeException(_context.Thread, $"{"Unload"}: invalid argument #{_lastArgPos}: {_lastArg} ({_lastArg.Type}), expected: {_expectedType.FullName}", 2);
        });
        private static readonly global::Lua.LuaFunction __index = new(global::Lua.Runtime.Metamethods.Index, (_context, _) =>
        {
            var _this = _context.GetArgument<LuaApplicationType>(0);
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
            var _this = _context.GetArgument<LuaApplicationType>(0);
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
                case "CanStreamedLevelBeLoaded": _value = _LuaApplication_CanStreamedLevelBeLoaded; return true;
                case "GetStackTraceLogType": _value = _LuaApplication_GetStackTraceLogType; return true;
                case "HasProLicense": _value = _LuaApplication_HasProLicense; return true;
                case "HasUserAuthorization": _value = _LuaApplication_HasUserAuthorization; return true;
                case "IsPlaying": _value = _LuaApplication_IsPlaying; return true;
                case "OpenURL": _value = _LuaApplication_OpenURL; return true;
                case "Quit": _value = _LuaApplication_Quit; return true;
                case "RequestAdvertisingIdentifierAsync": _value = _LuaApplication_RequestAdvertisingIdentifierAsync; return true;
                case "RequestUserAuthorization": _value = _LuaApplication_RequestUserAuthorization; return true;
                case "SetStackTraceLogType": _value = _LuaApplication_SetStackTraceLogType; return true;
                case "Unload": _value = _LuaApplication_Unload; return true;
                case "absoluteURL": _value = new global::Lua.LuaValue(global::UnityEngine.Device.Application.absoluteURL); return true;
                case "backgroundLoadingPriority": _value = new global::Lua.LuaValue((global::System.Int64)global::UnityEngine.Device.Application.backgroundLoadingPriority); return true;
                case "buildGUID": _value = new global::Lua.LuaValue(global::UnityEngine.Device.Application.buildGUID); return true;
                case "cloudProjectId": _value = new global::Lua.LuaValue(global::UnityEngine.Device.Application.cloudProjectId); return true;
                case "companyName": _value = new global::Lua.LuaValue(global::UnityEngine.Device.Application.companyName); return true;
                case "consoleLogPath": _value = new global::Lua.LuaValue(global::UnityEngine.Device.Application.consoleLogPath); return true;
                case "dataPath": _value = new global::Lua.LuaValue(global::UnityEngine.Device.Application.dataPath); return true;
                case "exitCancellationToken": _value = _factory.Bind(global::UnityEngine.Device.Application.exitCancellationToken); return true;
                case "genuine": _value = new global::Lua.LuaValue(global::UnityEngine.Device.Application.genuine); return true;
                case "genuineCheckAvailable": _value = new global::Lua.LuaValue(global::UnityEngine.Device.Application.genuineCheckAvailable); return true;
                case "identifier": _value = new global::Lua.LuaValue(global::UnityEngine.Device.Application.identifier); return true;
                case "installerName": _value = new global::Lua.LuaValue(global::UnityEngine.Device.Application.installerName); return true;
                case "installMode": _value = new global::Lua.LuaValue((global::System.Int64)global::UnityEngine.Device.Application.installMode); return true;
                case "internetReachability": _value = new global::Lua.LuaValue((global::System.Int64)global::UnityEngine.Device.Application.internetReachability); return true;
                case "isBatchMode": _value = new global::Lua.LuaValue(global::UnityEngine.Device.Application.isBatchMode); return true;
                case "isConsolePlatform": _value = new global::Lua.LuaValue(global::UnityEngine.Device.Application.isConsolePlatform); return true;
                case "isEditor": _value = new global::Lua.LuaValue(global::UnityEngine.Device.Application.isEditor); return true;
                case "isFocused": _value = new global::Lua.LuaValue(global::UnityEngine.Device.Application.isFocused); return true;
                case "isMobilePlatform": _value = new global::Lua.LuaValue(global::UnityEngine.Device.Application.isMobilePlatform); return true;
                case "isPlaying": _value = new global::Lua.LuaValue(global::UnityEngine.Device.Application.isPlaying); return true;
                case "persistentDataPath": _value = new global::Lua.LuaValue(global::UnityEngine.Device.Application.persistentDataPath); return true;
                case "platform": _value = new global::Lua.LuaValue((global::System.Int64)global::UnityEngine.Device.Application.platform); return true;
                case "productName": _value = new global::Lua.LuaValue(global::UnityEngine.Device.Application.productName); return true;
                case "runInBackground": _value = new global::Lua.LuaValue(global::UnityEngine.Device.Application.runInBackground); return true;
                case "sandboxType": _value = new global::Lua.LuaValue((global::System.Int64)global::UnityEngine.Device.Application.sandboxType); return true;
                case "streamingAssetsPath": _value = new global::Lua.LuaValue(global::UnityEngine.Device.Application.streamingAssetsPath); return true;
                case "systemLanguage": _value = new global::Lua.LuaValue((global::System.Int64)global::UnityEngine.Device.Application.systemLanguage); return true;
                case "targetFrameRate": _value = new global::Lua.LuaValue(global::UnityEngine.Device.Application.targetFrameRate); return true;
                case "temporaryCachePath": _value = new global::Lua.LuaValue(global::UnityEngine.Device.Application.temporaryCachePath); return true;
                case "unityVersion": _value = new global::Lua.LuaValue(global::UnityEngine.Device.Application.unityVersion); return true;
                case "version": _value = new global::Lua.LuaValue(global::UnityEngine.Device.Application.version); return true;
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
                case "backgroundLoadingPriority": global::UnityEngine.Device.Application.backgroundLoadingPriority = _value.Read<global::UnityEngine.ThreadPriority>();  return true;
                case "runInBackground": global::UnityEngine.Device.Application.runInBackground = _value.Read<global::System.Boolean>();  return true;
                case "targetFrameRate": global::UnityEngine.Device.Application.targetFrameRate = _value.Read<global::System.Int32>();  return true;
                default: return false;
            }
        }
    }
}
#pragma warning restore 0109, 0162, 0168, 0219
#endif
