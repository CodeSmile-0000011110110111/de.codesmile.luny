
// --------------------------------------------------------------
// GENERATED FILE ----> DO NOT EDIT <---- CHANGES WILL BE LOST !!
// --------------------------------------------------------------

#if UNITY_6000_0_OR_NEWER && !(UNITY_6000_1_OR_NEWER)
#pragma warning disable 0109, 0162, 0168, 0219
using Luny;

namespace Luny.UnityEngine
{
    public sealed class LuaLogger : global::Luny.ILuaObject<global::UnityEngine.Logger>
    {
        public new static global::Lua.LuaValue Bind(global::UnityEngine.Logger instance) => new LuaLogger(instance);
        public new static global::Lua.LuaValue Bind(global::System.Object instance) => Bind((global::UnityEngine.Logger)instance);
        public new static global::Lua.LuaValue Bind(global::System.Collections.Generic.IList<global::UnityEngine.Logger> instances) =>
            new global::Luny.LuaList<global::UnityEngine.Logger>(instances);
        public new static global::Lua.LuaValue Bind(global::System.Collections.Generic.IList<global::System.Object> instances) =>
            new global::Luny.LuaList<global::UnityEngine.Logger>(instances);
        private LuaLogger(global::UnityEngine.Logger instance) => m_Instance = instance;
        public static implicit operator global::Lua.LuaValue(LuaLogger value) => new(value);
        private global::UnityEngine.Logger m_Instance;
        public global::UnityEngine.Logger Instance => m_Instance;
        public new global::System.Type BindType => typeof(global::UnityEngine.Logger);
        private static global::Lua.LuaTable s_Metatable;
        public global::Lua.LuaTable Metatable
        {
            get => s_Metatable ??= global::Luny.LuaMetatable.Create(__index, __newindex);
            set => throw new global::System.NotSupportedException("LuaObject metatables cannot be modified");
        }
        global::System.Span<global::Lua.LuaValue> global::Lua.ILuaUserData.UserValues => default;
        public override global::System.String ToString() => m_Instance != null ? Instance.ToString() : "{GetType().Name}(null)";
#if UNITY_EDITOR
        [global::UnityEngine.RuntimeInitializeOnLoadMethod(global::UnityEngine.RuntimeInitializeLoadType.SubsystemRegistration)]
        private static void ResetStaticFields() => s_Metatable = null;
#endif

        private static readonly global::Lua.LuaFunction _LuaLogger_IsLogTypeAllowed = new global::Lua.LuaFunction("IsLogTypeAllowed", (_context, _) =>
        {
            global::Lua.LuaValue _lastArg = default;
            global::System.Int32 _lastArgPos = default;
            global::System.Type _expectedType = default;
            var _argCount = _context.ArgumentCount;
            var _this = _context.GetArgument<LuaLogger>(0);
            var _arg0 = _lastArg = _argCount > 1 ? _context.GetArgument(1) : global::Lua.LuaValue.Nil;
            _lastArgPos = 0; _expectedType = typeof(global::UnityEngine.LogType);
            if (_arg0.TryRead<global::UnityEngine.LogType>(out var _p0_UnityEngine_LogType))
            {
                if (_argCount == 2)
                {
                    var logType = _p0_UnityEngine_LogType;
                    var _ret0 = _this.Instance.IsLogTypeAllowed(logType);
                    var _lret0 = new global::Lua.LuaValue(_ret0);
                    var _retCount = _context.Return(_lret0);
                    return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                }
            }
            throw new global::Lua.LuaRuntimeException(_context.Thread, $"{"IsLogTypeAllowed"}: invalid argument #{_lastArgPos}: {_lastArg} ({_lastArg.Type}), expected: {_expectedType.FullName}", 2);
        });
        private static readonly global::Lua.LuaFunction _LuaLogger_Log = new global::Lua.LuaFunction("Log", (_context, _) =>
        {
            global::Lua.LuaValue _lastArg = default;
            global::System.Int32 _lastArgPos = default;
            global::System.Type _expectedType = default;
            var _argCount = _context.ArgumentCount;
            var _this = _context.GetArgument<LuaLogger>(0);
            var _arg0 = _lastArg = _argCount > 1 ? _context.GetArgument(1) : global::Lua.LuaValue.Nil;
            _lastArgPos = 0; _expectedType = typeof(global::System.Object);
            if (_arg0.TryRead<global::System.Object>(out var _p0_System_Object))
            {
                if (_argCount == 2)
                {
                    var message = _p0_System_Object;
                    _this.Instance.Log(message);
                    var _retCount = _context.Return();
                    return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                }
            }
            _lastArgPos = 0; _expectedType = typeof(global::UnityEngine.LogType);
            if (_arg0.TryRead<global::UnityEngine.LogType>(out var _p0_UnityEngine_LogType))
            {
                var _arg1 = _lastArg = _argCount > 2 ? _context.GetArgument(2) : global::Lua.LuaValue.Nil;
                _lastArgPos = 1; _expectedType = typeof(global::System.Object);
                if (_arg1.TryRead<global::System.Object>(out var _p1_System_Object))
                {
                    if (_argCount == 3)
                    {
                        var logType = _p0_UnityEngine_LogType;
                        var message = _p1_System_Object;
                        _this.Instance.Log(logType, message);
                        var _retCount = _context.Return();
                        return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                    }
                    var _arg2 = _lastArg = _argCount > 3 ? _context.GetArgument(3) : global::Lua.LuaValue.Nil;
                    _lastArgPos = 2; _expectedType = typeof(global::Luny.UnityEngine.LuaUnityObject);
                    if (_arg2.TryRead<global::Luny.UnityEngine.LuaUnityObject>(out var _p2_UnityEngine_Object))
                    {
                        if (_argCount == 4)
                        {
                            var logType = _p0_UnityEngine_LogType;
                            var message = _p1_System_Object;
                            var context = _p2_UnityEngine_Object.Instance;
                            _this.Instance.Log(logType, message, context);
                            var _retCount = _context.Return();
                            return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                        }
                    }
                }
                _lastArgPos = 1; _expectedType = typeof(global::System.String);
                if (_arg1.TryRead<global::System.String>(out var _p1_System_String))
                {
                    var _arg2 = _lastArg = _argCount > 3 ? _context.GetArgument(3) : global::Lua.LuaValue.Nil;
                    _lastArgPos = 2; _expectedType = typeof(global::System.Object);
                    if (_arg2.TryRead<global::System.Object>(out var _p2_System_Object))
                    {
                        if (_argCount == 4)
                        {
                            var logType = _p0_UnityEngine_LogType;
                            var tag = _p1_System_String;
                            var message = _p2_System_Object;
                            _this.Instance.Log(logType, tag, message);
                            var _retCount = _context.Return();
                            return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                        }
                        var _arg3 = _lastArg = _argCount > 4 ? _context.GetArgument(4) : global::Lua.LuaValue.Nil;
                        _lastArgPos = 3; _expectedType = typeof(global::Luny.UnityEngine.LuaUnityObject);
                        if (_arg3.TryRead<global::Luny.UnityEngine.LuaUnityObject>(out var _p3_UnityEngine_Object))
                        {
                            if (_argCount == 5)
                            {
                                var logType = _p0_UnityEngine_LogType;
                                var tag = _p1_System_String;
                                var message = _p2_System_Object;
                                var context = _p3_UnityEngine_Object.Instance;
                                _this.Instance.Log(logType, tag, message, context);
                                var _retCount = _context.Return();
                                return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                            }
                        }
                    }
                }
            }
            _lastArgPos = 0; _expectedType = typeof(global::System.String);
            if (_arg0.TryRead<global::System.String>(out var _p0_System_String))
            {
                var _arg1 = _lastArg = _argCount > 2 ? _context.GetArgument(2) : global::Lua.LuaValue.Nil;
                _lastArgPos = 1; _expectedType = typeof(global::System.Object);
                if (_arg1.TryRead<global::System.Object>(out var _p1_System_Object))
                {
                    if (_argCount == 3)
                    {
                        var tag = _p0_System_String;
                        var message = _p1_System_Object;
                        _this.Instance.Log(tag, message);
                        var _retCount = _context.Return();
                        return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                    }
                    var _arg2 = _lastArg = _argCount > 3 ? _context.GetArgument(3) : global::Lua.LuaValue.Nil;
                    _lastArgPos = 2; _expectedType = typeof(global::Luny.UnityEngine.LuaUnityObject);
                    if (_arg2.TryRead<global::Luny.UnityEngine.LuaUnityObject>(out var _p2_UnityEngine_Object))
                    {
                        if (_argCount == 4)
                        {
                            var tag = _p0_System_String;
                            var message = _p1_System_Object;
                            var context = _p2_UnityEngine_Object.Instance;
                            _this.Instance.Log(tag, message, context);
                            var _retCount = _context.Return();
                            return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                        }
                    }
                }
            }
            throw new global::Lua.LuaRuntimeException(_context.Thread, $"{"Log"}: invalid argument #{_lastArgPos}: {_lastArg} ({_lastArg.Type}), expected: {_expectedType.FullName}", 2);
        });
        private static readonly global::Lua.LuaFunction _LuaLogger_LogError = new global::Lua.LuaFunction("LogError", (_context, _) =>
        {
            global::Lua.LuaValue _lastArg = default;
            global::System.Int32 _lastArgPos = default;
            global::System.Type _expectedType = default;
            var _argCount = _context.ArgumentCount;
            var _this = _context.GetArgument<LuaLogger>(0);
            var _arg0 = _lastArg = _argCount > 1 ? _context.GetArgument(1) : global::Lua.LuaValue.Nil;
            _lastArgPos = 0; _expectedType = typeof(global::System.String);
            if (_arg0.TryRead<global::System.String>(out var _p0_System_String))
            {
                var _arg1 = _lastArg = _argCount > 2 ? _context.GetArgument(2) : global::Lua.LuaValue.Nil;
                _lastArgPos = 1; _expectedType = typeof(global::System.Object);
                if (_arg1.TryRead<global::System.Object>(out var _p1_System_Object))
                {
                    if (_argCount == 3)
                    {
                        var tag = _p0_System_String;
                        var message = _p1_System_Object;
                        _this.Instance.LogError(tag, message);
                        var _retCount = _context.Return();
                        return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                    }
                    var _arg2 = _lastArg = _argCount > 3 ? _context.GetArgument(3) : global::Lua.LuaValue.Nil;
                    _lastArgPos = 2; _expectedType = typeof(global::Luny.UnityEngine.LuaUnityObject);
                    if (_arg2.TryRead<global::Luny.UnityEngine.LuaUnityObject>(out var _p2_UnityEngine_Object))
                    {
                        if (_argCount == 4)
                        {
                            var tag = _p0_System_String;
                            var message = _p1_System_Object;
                            var context = _p2_UnityEngine_Object.Instance;
                            _this.Instance.LogError(tag, message, context);
                            var _retCount = _context.Return();
                            return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                        }
                    }
                }
            }
            throw new global::Lua.LuaRuntimeException(_context.Thread, $"{"LogError"}: invalid argument #{_lastArgPos}: {_lastArg} ({_lastArg.Type}), expected: {_expectedType.FullName}", 2);
        });
        private static readonly global::Lua.LuaFunction _LuaLogger_LogException = new global::Lua.LuaFunction("LogException", (_context, _) =>
        {
            global::Lua.LuaValue _lastArg = default;
            global::System.Int32 _lastArgPos = default;
            global::System.Type _expectedType = default;
            var _argCount = _context.ArgumentCount;
            var _this = _context.GetArgument<LuaLogger>(0);
            var _arg0 = _lastArg = _argCount > 1 ? _context.GetArgument(1) : global::Lua.LuaValue.Nil;
            _lastArgPos = 0; _expectedType = typeof(global::System.Exception);
            if (_arg0.TryRead<global::System.Exception>(out var _p0_System_Exception))
            {
                if (_argCount == 2)
                {
                    var exception = _p0_System_Exception;
                    _this.Instance.LogException(exception);
                    var _retCount = _context.Return();
                    return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                }
                var _arg1 = _lastArg = _argCount > 2 ? _context.GetArgument(2) : global::Lua.LuaValue.Nil;
                _lastArgPos = 1; _expectedType = typeof(global::Luny.UnityEngine.LuaUnityObject);
                if (_arg1.TryRead<global::Luny.UnityEngine.LuaUnityObject>(out var _p1_UnityEngine_Object))
                {
                    if (_argCount == 3)
                    {
                        var exception = _p0_System_Exception;
                        var context = _p1_UnityEngine_Object.Instance;
                        _this.Instance.LogException(exception, context);
                        var _retCount = _context.Return();
                        return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                    }
                }
            }
            throw new global::Lua.LuaRuntimeException(_context.Thread, $"{"LogException"}: invalid argument #{_lastArgPos}: {_lastArg} ({_lastArg.Type}), expected: {_expectedType.FullName}", 2);
        });
        private static readonly global::Lua.LuaFunction _LuaLogger_LogFormat = new global::Lua.LuaFunction("LogFormat", (_context, _) =>
        {
            global::Lua.LuaValue _lastArg = default;
            global::System.Int32 _lastArgPos = default;
            global::System.Type _expectedType = default;
            var _argCount = _context.ArgumentCount;
            var _this = _context.GetArgument<LuaLogger>(0);
            var _arg0 = _lastArg = _argCount > 1 ? _context.GetArgument(1) : global::Lua.LuaValue.Nil;
            _lastArgPos = 0; _expectedType = typeof(global::UnityEngine.LogType);
            if (_arg0.TryRead<global::UnityEngine.LogType>(out var _p0_UnityEngine_LogType))
            {
                var _arg1 = _lastArg = _argCount > 2 ? _context.GetArgument(2) : global::Lua.LuaValue.Nil;
                _lastArgPos = 1; _expectedType = typeof(global::System.String);
                if (_arg1.TryRead<global::System.String>(out var _p1_System_String))
                {
                    var _arg2 = _lastArg = _argCount > 3 ? _context.GetArgument(3) : global::Lua.LuaValue.Nil;
                    _lastArgPos = 2; _expectedType = typeof(global::System.Object[]);
                    if (_arg2.TryReadArray<global::System.Object>(out var _p2_System_ObjectArray))
                    {
                        if (_argCount == 4)
                        {
                            var logType = _p0_UnityEngine_LogType;
                            var format = _p1_System_String;
                            var args = _p2_System_ObjectArray;
                            _this.Instance.LogFormat(logType, format, args);
                            var _retCount = _context.Return();
                            return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                        }
                    }
                }
                _lastArgPos = 1; _expectedType = typeof(global::Luny.UnityEngine.LuaUnityObject);
                if (_arg1.TryRead<global::Luny.UnityEngine.LuaUnityObject>(out var _p1_UnityEngine_Object))
                {
                    var _arg2 = _lastArg = _argCount > 3 ? _context.GetArgument(3) : global::Lua.LuaValue.Nil;
                    _lastArgPos = 2; _expectedType = typeof(global::System.String);
                    if (_arg2.TryRead<global::System.String>(out var _p2_System_String))
                    {
                        var _arg3 = _lastArg = _argCount > 4 ? _context.GetArgument(4) : global::Lua.LuaValue.Nil;
                        _lastArgPos = 3; _expectedType = typeof(global::System.Object[]);
                        if (_arg3.TryReadArray<global::System.Object>(out var _p3_System_ObjectArray))
                        {
                            if (_argCount == 5)
                            {
                                var logType = _p0_UnityEngine_LogType;
                                var context = _p1_UnityEngine_Object.Instance;
                                var format = _p2_System_String;
                                var args = _p3_System_ObjectArray;
                                _this.Instance.LogFormat(logType, context, format, args);
                                var _retCount = _context.Return();
                                return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                            }
                        }
                    }
                }
            }
            throw new global::Lua.LuaRuntimeException(_context.Thread, $"{"LogFormat"}: invalid argument #{_lastArgPos}: {_lastArg} ({_lastArg.Type}), expected: {_expectedType.FullName}", 2);
        });
        private static readonly global::Lua.LuaFunction _LuaLogger_LogWarning = new global::Lua.LuaFunction("LogWarning", (_context, _) =>
        {
            global::Lua.LuaValue _lastArg = default;
            global::System.Int32 _lastArgPos = default;
            global::System.Type _expectedType = default;
            var _argCount = _context.ArgumentCount;
            var _this = _context.GetArgument<LuaLogger>(0);
            var _arg0 = _lastArg = _argCount > 1 ? _context.GetArgument(1) : global::Lua.LuaValue.Nil;
            _lastArgPos = 0; _expectedType = typeof(global::System.String);
            if (_arg0.TryRead<global::System.String>(out var _p0_System_String))
            {
                var _arg1 = _lastArg = _argCount > 2 ? _context.GetArgument(2) : global::Lua.LuaValue.Nil;
                _lastArgPos = 1; _expectedType = typeof(global::System.Object);
                if (_arg1.TryRead<global::System.Object>(out var _p1_System_Object))
                {
                    if (_argCount == 3)
                    {
                        var tag = _p0_System_String;
                        var message = _p1_System_Object;
                        _this.Instance.LogWarning(tag, message);
                        var _retCount = _context.Return();
                        return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                    }
                    var _arg2 = _lastArg = _argCount > 3 ? _context.GetArgument(3) : global::Lua.LuaValue.Nil;
                    _lastArgPos = 2; _expectedType = typeof(global::Luny.UnityEngine.LuaUnityObject);
                    if (_arg2.TryRead<global::Luny.UnityEngine.LuaUnityObject>(out var _p2_UnityEngine_Object))
                    {
                        if (_argCount == 4)
                        {
                            var tag = _p0_System_String;
                            var message = _p1_System_Object;
                            var context = _p2_UnityEngine_Object.Instance;
                            _this.Instance.LogWarning(tag, message, context);
                            var _retCount = _context.Return();
                            return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                        }
                    }
                }
            }
            throw new global::Lua.LuaRuntimeException(_context.Thread, $"{"LogWarning"}: invalid argument #{_lastArgPos}: {_lastArg} ({_lastArg.Type}), expected: {_expectedType.FullName}", 2);
        });
        private static readonly global::Lua.LuaFunction __index = new(global::Lua.Runtime.Metamethods.Index, (_context, _) =>
        {
            var _this = _context.GetArgument<LuaLogger>(0);
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
            var _this = _context.GetArgument<LuaLogger>(0);
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
                case "IsLogTypeAllowed": _value = _LuaLogger_IsLogTypeAllowed; return true;
                case "Log": _value = _LuaLogger_Log; return true;
                case "LogError": _value = _LuaLogger_LogError; return true;
                case "LogException": _value = _LuaLogger_LogException; return true;
                case "LogFormat": _value = _LuaLogger_LogFormat; return true;
                case "LogWarning": _value = _LuaLogger_LogWarning; return true;
                case "filterLogType": _value = new global::Lua.LuaValue((global::System.Int64)Instance.filterLogType); return true;
                case "logEnabled": _value = new global::Lua.LuaValue(Instance.logEnabled); return true;
                case "logHandler": _value = _factory.Bind(Instance.logHandler); return true;
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
                case "filterLogType": Instance.filterLogType = _value.Read<global::UnityEngine.LogType>();  return true;
                case "logEnabled": Instance.logEnabled = _value.Read<global::System.Boolean>();  return true;
                case "logHandler": Instance.logHandler = _value.Read<global::UnityEngine.ILogHandler>();  return true;
                default: return false;
            }
        }
    }
    public sealed class LuaLoggerType : global::Luny.ILuaStatic
    {
        public static global::Lua.LuaValue Bind() => new LuaLoggerType();
        private LuaLoggerType() {}
        public static implicit operator global::Lua.LuaValue(LuaLoggerType value) => new(value);
        public global::System.Type BindType => typeof(global::UnityEngine.Logger);
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
            var _this = _context.GetArgument<LuaLoggerType>(0);
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
            var _this = _context.GetArgument<LuaLoggerType>(0);
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
