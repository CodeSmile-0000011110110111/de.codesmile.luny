
// --------------------------------------------------------------
// GENERATED FILE ----> DO NOT EDIT <---- CHANGES WILL BE LOST !!
// --------------------------------------------------------------

#if UNITY_6000_1_OR_NEWER && !(UNITY_6000_2_OR_NEWER)
#pragma warning disable 0109, 0162, 0168, 0219
using Luny;

namespace Luny.UnityEditor.Events
{
    public sealed class LuaUnityEventToolsType : global::Luny.ILuaStatic
    {
        public static global::Lua.LuaValue Bind() => new LuaUnityEventToolsType();
        private LuaUnityEventToolsType() {}
        public static implicit operator global::Lua.LuaValue(LuaUnityEventToolsType value) => new(value);
        public global::System.Type BindType => typeof(global::UnityEditor.Events.UnityEventTools);
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

        private static readonly global::Lua.LuaFunction _LuaUnityEventTools_AddPersistentListener = new global::Lua.LuaFunction("AddPersistentListener", (_context, _) =>
        {
            global::Lua.LuaValue _lastArg = default;
            global::System.Int32 _lastArgPos = default;
            global::System.Type _expectedType = default;
            var _argCount = _context.ArgumentCount;
            var _arg0 = _lastArg = _argCount > 0 ? _context.GetArgument(0) : global::Lua.LuaValue.Nil;
            _lastArgPos = 0; _expectedType = typeof(global::UnityEngine.Events.UnityEventBase);
            if (_arg0.TryRead<global::UnityEngine.Events.UnityEventBase>(out var _p0_UnityEngine_Events_UnityEventBase))
            {
                if (_argCount == 1)
                {
                    var unityEvent = _p0_UnityEngine_Events_UnityEventBase;
                    global::UnityEditor.Events.UnityEventTools.AddPersistentListener(unityEvent);
                    var _retCount = _context.Return();
                    return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                }
            }
            _lastArgPos = 0; _expectedType = typeof(global::UnityEngine.Events.UnityEvent);
            if (_arg0.TryRead<global::UnityEngine.Events.UnityEvent>(out var _p0_UnityEngine_Events_UnityEvent))
            {
                var _arg1 = _lastArg = _argCount > 1 ? _context.GetArgument(1) : global::Lua.LuaValue.Nil;
                _lastArgPos = 1; _expectedType = typeof(global::UnityEngine.Events.UnityAction);
                if (_arg1.TryRead<global::UnityEngine.Events.UnityAction>(out var _p1_UnityEngine_Events_UnityAction))
                {
                    if (_argCount == 2)
                    {
                        var unityEvent = _p0_UnityEngine_Events_UnityEvent;
                        var call = _p1_UnityEngine_Events_UnityAction;
                        global::UnityEditor.Events.UnityEventTools.AddPersistentListener(unityEvent, call);
                        var _retCount = _context.Return();
                        return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                    }
                }
            }
            throw new global::Lua.LuaRuntimeException(_context.Thread, $"{"AddPersistentListener"}: invalid argument #{_lastArgPos}: {_lastArg} ({_lastArg.Type}), expected: {_expectedType.FullName}", 2);
        });
        private static readonly global::Lua.LuaFunction _LuaUnityEventTools_AddVoidPersistentListener = new global::Lua.LuaFunction("AddVoidPersistentListener", (_context, _) =>
        {
            global::Lua.LuaValue _lastArg = default;
            global::System.Int32 _lastArgPos = default;
            global::System.Type _expectedType = default;
            var _argCount = _context.ArgumentCount;
            var _arg0 = _lastArg = _argCount > 0 ? _context.GetArgument(0) : global::Lua.LuaValue.Nil;
            _lastArgPos = 0; _expectedType = typeof(global::UnityEngine.Events.UnityEventBase);
            if (_arg0.TryRead<global::UnityEngine.Events.UnityEventBase>(out var _p0_UnityEngine_Events_UnityEventBase))
            {
                var _arg1 = _lastArg = _argCount > 1 ? _context.GetArgument(1) : global::Lua.LuaValue.Nil;
                _lastArgPos = 1; _expectedType = typeof(global::UnityEngine.Events.UnityAction);
                if (_arg1.TryRead<global::UnityEngine.Events.UnityAction>(out var _p1_UnityEngine_Events_UnityAction))
                {
                    if (_argCount == 2)
                    {
                        var unityEvent = _p0_UnityEngine_Events_UnityEventBase;
                        var call = _p1_UnityEngine_Events_UnityAction;
                        global::UnityEditor.Events.UnityEventTools.AddVoidPersistentListener(unityEvent, call);
                        var _retCount = _context.Return();
                        return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                    }
                }
            }
            throw new global::Lua.LuaRuntimeException(_context.Thread, $"{"AddVoidPersistentListener"}: invalid argument #{_lastArgPos}: {_lastArg} ({_lastArg.Type}), expected: {_expectedType.FullName}", 2);
        });
        private static readonly global::Lua.LuaFunction _LuaUnityEventTools_RegisterPersistentListener = new global::Lua.LuaFunction("RegisterPersistentListener", (_context, _) =>
        {
            global::Lua.LuaValue _lastArg = default;
            global::System.Int32 _lastArgPos = default;
            global::System.Type _expectedType = default;
            var _argCount = _context.ArgumentCount;
            var _arg0 = _lastArg = _argCount > 0 ? _context.GetArgument(0) : global::Lua.LuaValue.Nil;
            _lastArgPos = 0; _expectedType = typeof(global::UnityEngine.Events.UnityEvent);
            if (_arg0.TryRead<global::UnityEngine.Events.UnityEvent>(out var _p0_UnityEngine_Events_UnityEvent))
            {
                var _arg1 = _lastArg = _argCount > 1 ? _context.GetArgument(1) : global::Lua.LuaValue.Nil;
                _lastArgPos = 1; _expectedType = typeof(global::System.Int32);
                if (_arg1.TryRead<global::System.Int32>(out var _p1_System_Int32))
                {
                    var _arg2 = _lastArg = _argCount > 2 ? _context.GetArgument(2) : global::Lua.LuaValue.Nil;
                    _lastArgPos = 2; _expectedType = typeof(global::UnityEngine.Events.UnityAction);
                    if (_arg2.TryRead<global::UnityEngine.Events.UnityAction>(out var _p2_UnityEngine_Events_UnityAction))
                    {
                        if (_argCount == 3)
                        {
                            var unityEvent = _p0_UnityEngine_Events_UnityEvent;
                            var index = _p1_System_Int32;
                            var call = _p2_UnityEngine_Events_UnityAction;
                            global::UnityEditor.Events.UnityEventTools.RegisterPersistentListener(unityEvent, index, call);
                            var _retCount = _context.Return();
                            return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                        }
                    }
                }
            }
            throw new global::Lua.LuaRuntimeException(_context.Thread, $"{"RegisterPersistentListener"}: invalid argument #{_lastArgPos}: {_lastArg} ({_lastArg.Type}), expected: {_expectedType.FullName}", 2);
        });
        private static readonly global::Lua.LuaFunction _LuaUnityEventTools_RegisterVoidPersistentListener = new global::Lua.LuaFunction("RegisterVoidPersistentListener", (_context, _) =>
        {
            global::Lua.LuaValue _lastArg = default;
            global::System.Int32 _lastArgPos = default;
            global::System.Type _expectedType = default;
            var _argCount = _context.ArgumentCount;
            var _arg0 = _lastArg = _argCount > 0 ? _context.GetArgument(0) : global::Lua.LuaValue.Nil;
            _lastArgPos = 0; _expectedType = typeof(global::UnityEngine.Events.UnityEventBase);
            if (_arg0.TryRead<global::UnityEngine.Events.UnityEventBase>(out var _p0_UnityEngine_Events_UnityEventBase))
            {
                var _arg1 = _lastArg = _argCount > 1 ? _context.GetArgument(1) : global::Lua.LuaValue.Nil;
                _lastArgPos = 1; _expectedType = typeof(global::System.Int32);
                if (_arg1.TryRead<global::System.Int32>(out var _p1_System_Int32))
                {
                    var _arg2 = _lastArg = _argCount > 2 ? _context.GetArgument(2) : global::Lua.LuaValue.Nil;
                    _lastArgPos = 2; _expectedType = typeof(global::UnityEngine.Events.UnityAction);
                    if (_arg2.TryRead<global::UnityEngine.Events.UnityAction>(out var _p2_UnityEngine_Events_UnityAction))
                    {
                        if (_argCount == 3)
                        {
                            var unityEvent = _p0_UnityEngine_Events_UnityEventBase;
                            var index = _p1_System_Int32;
                            var call = _p2_UnityEngine_Events_UnityAction;
                            global::UnityEditor.Events.UnityEventTools.RegisterVoidPersistentListener(unityEvent, index, call);
                            var _retCount = _context.Return();
                            return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                        }
                    }
                }
            }
            throw new global::Lua.LuaRuntimeException(_context.Thread, $"{"RegisterVoidPersistentListener"}: invalid argument #{_lastArgPos}: {_lastArg} ({_lastArg.Type}), expected: {_expectedType.FullName}", 2);
        });
        private static readonly global::Lua.LuaFunction _LuaUnityEventTools_RemovePersistentListener = new global::Lua.LuaFunction("RemovePersistentListener", (_context, _) =>
        {
            global::Lua.LuaValue _lastArg = default;
            global::System.Int32 _lastArgPos = default;
            global::System.Type _expectedType = default;
            var _argCount = _context.ArgumentCount;
            var _arg0 = _lastArg = _argCount > 0 ? _context.GetArgument(0) : global::Lua.LuaValue.Nil;
            _lastArgPos = 0; _expectedType = typeof(global::UnityEngine.Events.UnityEventBase);
            if (_arg0.TryRead<global::UnityEngine.Events.UnityEventBase>(out var _p0_UnityEngine_Events_UnityEventBase))
            {
                var _arg1 = _lastArg = _argCount > 1 ? _context.GetArgument(1) : global::Lua.LuaValue.Nil;
                _lastArgPos = 1; _expectedType = typeof(global::System.Int32);
                if (_arg1.TryRead<global::System.Int32>(out var _p1_System_Int32))
                {
                    if (_argCount == 2)
                    {
                        var unityEvent = _p0_UnityEngine_Events_UnityEventBase;
                        var index = _p1_System_Int32;
                        global::UnityEditor.Events.UnityEventTools.RemovePersistentListener(unityEvent, index);
                        var _retCount = _context.Return();
                        return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                    }
                }
                _lastArgPos = 1; _expectedType = typeof(global::UnityEngine.Events.UnityAction);
                if (_arg1.TryRead<global::UnityEngine.Events.UnityAction>(out var _p1_UnityEngine_Events_UnityAction))
                {
                    if (_argCount == 2)
                    {
                        var unityEvent = _p0_UnityEngine_Events_UnityEventBase;
                        var call = _p1_UnityEngine_Events_UnityAction;
                        global::UnityEditor.Events.UnityEventTools.RemovePersistentListener(unityEvent, call);
                        var _retCount = _context.Return();
                        return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                    }
                }
            }
            throw new global::Lua.LuaRuntimeException(_context.Thread, $"{"RemovePersistentListener"}: invalid argument #{_lastArgPos}: {_lastArg} ({_lastArg.Type}), expected: {_expectedType.FullName}", 2);
        });
        private static readonly global::Lua.LuaFunction _LuaUnityEventTools_UnregisterPersistentListener = new global::Lua.LuaFunction("UnregisterPersistentListener", (_context, _) =>
        {
            global::Lua.LuaValue _lastArg = default;
            global::System.Int32 _lastArgPos = default;
            global::System.Type _expectedType = default;
            var _argCount = _context.ArgumentCount;
            var _arg0 = _lastArg = _argCount > 0 ? _context.GetArgument(0) : global::Lua.LuaValue.Nil;
            _lastArgPos = 0; _expectedType = typeof(global::UnityEngine.Events.UnityEventBase);
            if (_arg0.TryRead<global::UnityEngine.Events.UnityEventBase>(out var _p0_UnityEngine_Events_UnityEventBase))
            {
                var _arg1 = _lastArg = _argCount > 1 ? _context.GetArgument(1) : global::Lua.LuaValue.Nil;
                _lastArgPos = 1; _expectedType = typeof(global::System.Int32);
                if (_arg1.TryRead<global::System.Int32>(out var _p1_System_Int32))
                {
                    if (_argCount == 2)
                    {
                        var unityEvent = _p0_UnityEngine_Events_UnityEventBase;
                        var index = _p1_System_Int32;
                        global::UnityEditor.Events.UnityEventTools.UnregisterPersistentListener(unityEvent, index);
                        var _retCount = _context.Return();
                        return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                    }
                }
            }
            throw new global::Lua.LuaRuntimeException(_context.Thread, $"{"UnregisterPersistentListener"}: invalid argument #{_lastArgPos}: {_lastArg} ({_lastArg.Type}), expected: {_expectedType.FullName}", 2);
        });
        private static readonly global::Lua.LuaFunction __index = new(global::Lua.Runtime.Metamethods.Index, (_context, _) =>
        {
            var _this = _context.GetArgument<LuaUnityEventToolsType>(0);
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
            var _this = _context.GetArgument<LuaUnityEventToolsType>(0);
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
                case "AddPersistentListener": _value = _LuaUnityEventTools_AddPersistentListener; return true;
                case "AddVoidPersistentListener": _value = _LuaUnityEventTools_AddVoidPersistentListener; return true;
                case "RegisterPersistentListener": _value = _LuaUnityEventTools_RegisterPersistentListener; return true;
                case "RegisterVoidPersistentListener": _value = _LuaUnityEventTools_RegisterVoidPersistentListener; return true;
                case "RemovePersistentListener": _value = _LuaUnityEventTools_RemovePersistentListener; return true;
                case "UnregisterPersistentListener": _value = _LuaUnityEventTools_UnregisterPersistentListener; return true;
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
