
// --------------------------------------------------------------
// GENERATED FILE ----> DO NOT EDIT <---- CHANGES WILL BE LOST !!
// --------------------------------------------------------------

#if UNITY_6000_0_OR_NEWER && !(UNITY_6000_1_OR_NEWER)
#pragma warning disable 0109, 0162, 0168, 0219
using Luny;

namespace Luny.UnityEngine
{
    public sealed class LuaScreen : global::Luny.ILuaObject<global::UnityEngine.Screen>
    {
        public new static global::Lua.LuaValue Bind(global::UnityEngine.Screen instance) => new LuaScreen(instance);
        public new static global::Lua.LuaValue Bind(global::System.Object instance) => Bind((global::UnityEngine.Screen)instance);
        public new static global::Lua.LuaValue Bind(global::System.Collections.Generic.IList<global::UnityEngine.Screen> instances) =>
            new global::Luny.LuaList<global::UnityEngine.Screen>(instances);
        public new static global::Lua.LuaValue Bind(global::System.Collections.Generic.IList<global::System.Object> instances) =>
            new global::Luny.LuaList<global::UnityEngine.Screen>(instances);
        private LuaScreen(global::UnityEngine.Screen instance) => m_Instance = instance;
        public static implicit operator global::Lua.LuaValue(LuaScreen value) => new(value);
        private global::UnityEngine.Screen m_Instance;
        public global::UnityEngine.Screen Instance => m_Instance;
        public new global::System.Type BindType => typeof(global::UnityEngine.Screen);
        public override global::System.String ToString() => m_Instance != null ? Instance.ToString() : "{GetType().Name}(null)";
#if UNITY_EDITOR
        [global::UnityEngine.RuntimeInitializeOnLoadMethod(global::UnityEngine.RuntimeInitializeLoadType.SubsystemRegistration)]
        private static void ResetStaticFields() => s_Metatable = null;
#endif

        private static readonly global::Lua.LuaFunction __index = new(global::Lua.Runtime.Metamethods.Index, (_context, _) =>
        {
            var _this = _context.GetArgument<LuaScreen>(0);
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
            var _this = _context.GetArgument<LuaScreen>(0);
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
    public sealed class LuaScreenType : global::Luny.ILuaStatic
    {
        public static global::Lua.LuaValue Bind() => new LuaScreenType();
        private LuaScreenType() {}
        public static implicit operator global::Lua.LuaValue(LuaScreenType value) => new(value);
        public global::System.Type BindType => typeof(global::UnityEngine.Screen);
        public override global::System.String ToString() => BindType.FullName;
#if UNITY_EDITOR
        [global::UnityEngine.RuntimeInitializeOnLoadMethod(global::UnityEngine.RuntimeInitializeLoadType.SubsystemRegistration)]
        private static void ResetStaticFields() => s_Metatable = null;
#endif

        private static readonly global::Lua.LuaFunction _LuaScreen_new = new global::Lua.LuaFunction(".ctor", (_context, _) =>
        {
            global::Lua.LuaValue _lastArg = default;
            global::System.Int32 _lastArgPos = default;
            global::System.Type _expectedType = default;
            var _argCount = _context.ArgumentCount;
            if (_argCount == 1)
            {
                var _ret0 = new global::UnityEngine.Screen();
                var _factory = _context.GetObjectFactory();
                var _lret0 = _factory.Bind(_ret0);
                var _retCount = _context.Return(_lret0);
                return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
            }
            throw new global::Lua.LuaRuntimeException(_context.Thread, $"{".ctor"}: invalid argument #{_lastArgPos}: {_lastArg} ({_lastArg.Type}), expected: {_expectedType.FullName}", 2);
        });
        private static readonly global::Lua.LuaFunction _LuaScreen_SetMSAASamples = new global::Lua.LuaFunction("SetMSAASamples", (_context, _) =>
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
                    var numSamples = _p0_System_Int32;
                    global::UnityEngine.Screen.SetMSAASamples(numSamples);
                    var _retCount = _context.Return();
                    return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                }
            }
            throw new global::Lua.LuaRuntimeException(_context.Thread, $"{"SetMSAASamples"}: invalid argument #{_lastArgPos}: {_lastArg} ({_lastArg.Type}), expected: {_expectedType.FullName}", 2);
        });
        private static readonly global::Lua.LuaFunction _LuaScreen_SetResolution = new global::Lua.LuaFunction("SetResolution", (_context, _) =>
        {
            global::Lua.LuaValue _lastArg = default;
            global::System.Int32 _lastArgPos = default;
            global::System.Type _expectedType = default;
            var _argCount = _context.ArgumentCount;
            var _arg0 = _lastArg = _argCount > 0 ? _context.GetArgument(0) : global::Lua.LuaValue.Nil;
            _lastArgPos = 0; _expectedType = typeof(global::System.Int32);
            if (_arg0.TryRead<global::System.Int32>(out var _p0_System_Int32))
            {
                var _arg1 = _lastArg = _argCount > 1 ? _context.GetArgument(1) : global::Lua.LuaValue.Nil;
                _lastArgPos = 1; _expectedType = typeof(global::System.Int32);
                if (_arg1.TryRead<global::System.Int32>(out var _p1_System_Int32))
                {
                    var _arg2 = _lastArg = _argCount > 2 ? _context.GetArgument(2) : global::Lua.LuaValue.Nil;
                    _lastArgPos = 2; _expectedType = typeof(global::System.Boolean);
                    if (_arg2.TryRead<global::System.Boolean>(out var _p2_System_Boolean))
                    {
                        if (_argCount == 3)
                        {
                            var width = _p0_System_Int32;
                            var height = _p1_System_Int32;
                            var fullscreen = _p2_System_Boolean;
                            global::UnityEngine.Screen.SetResolution(width, height, fullscreen);
                            var _retCount = _context.Return();
                            return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                        }
                    }
                    _lastArgPos = 2; _expectedType = typeof(global::UnityEngine.FullScreenMode);
                    if (_arg2.TryRead<global::UnityEngine.FullScreenMode>(out var _p2_UnityEngine_FullScreenMode))
                    {
                        if (_argCount == 3)
                        {
                            var width = _p0_System_Int32;
                            var height = _p1_System_Int32;
                            var fullscreenMode = _p2_UnityEngine_FullScreenMode;
                            global::UnityEngine.Screen.SetResolution(width, height, fullscreenMode);
                            var _retCount = _context.Return();
                            return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                        }
                        var _arg3 = _lastArg = _argCount > 3 ? _context.GetArgument(3) : global::Lua.LuaValue.Nil;
                        _lastArgPos = 3; _expectedType = typeof(global::Luny.UnityEngine.LuaRefreshRate);
                        if (_arg3.TryRead<global::Luny.UnityEngine.LuaRefreshRate>(out var _p3_UnityEngine_RefreshRate))
                        {
                            if (_argCount == 4)
                            {
                                var width = _p0_System_Int32;
                                var height = _p1_System_Int32;
                                var fullscreenMode = _p2_UnityEngine_FullScreenMode;
                                var preferredRefreshRate = _p3_UnityEngine_RefreshRate.Value;
                                global::UnityEngine.Screen.SetResolution(width, height, fullscreenMode, preferredRefreshRate);
                                var _retCount = _context.Return();
                                return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                            }
                        }
                    }
                }
            }
            throw new global::Lua.LuaRuntimeException(_context.Thread, $"{"SetResolution"}: invalid argument #{_lastArgPos}: {_lastArg} ({_lastArg.Type}), expected: {_expectedType.FullName}", 2);
        });
        private static readonly global::Lua.LuaFunction __index = new(global::Lua.Runtime.Metamethods.Index, (_context, _) =>
        {
            var _this = _context.GetArgument<LuaScreenType>(0);
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
            var _this = _context.GetArgument<LuaScreenType>(0);
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
            metatable[global::Lua.Runtime.Metamethods.Call] = _LuaScreen_new;
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
                case "SetMSAASamples": _value = _LuaScreen_SetMSAASamples; return true;
                case "SetResolution": _value = _LuaScreen_SetResolution; return true;
                case "autorotateToLandscapeLeft": _value = new global::Lua.LuaValue(global::UnityEngine.Screen.autorotateToLandscapeLeft); return true;
                case "autorotateToLandscapeRight": _value = new global::Lua.LuaValue(global::UnityEngine.Screen.autorotateToLandscapeRight); return true;
                case "autorotateToPortrait": _value = new global::Lua.LuaValue(global::UnityEngine.Screen.autorotateToPortrait); return true;
                case "autorotateToPortraitUpsideDown": _value = new global::Lua.LuaValue(global::UnityEngine.Screen.autorotateToPortraitUpsideDown); return true;
                case "brightness": _value = new global::Lua.LuaValue(global::UnityEngine.Screen.brightness); return true;
                case "currentResolution": _value = global::Luny.UnityEngine.LuaResolution.Bind(global::UnityEngine.Screen.currentResolution); return true;
                case "cutouts": _value = _factory.Bind(global::UnityEngine.Screen.cutouts); return true;
                case "dpi": _value = new global::Lua.LuaValue(global::UnityEngine.Screen.dpi); return true;
                case "fullScreen": _value = new global::Lua.LuaValue(global::UnityEngine.Screen.fullScreen); return true;
                case "fullScreenMode": _value = new global::Lua.LuaValue((global::System.Int64)global::UnityEngine.Screen.fullScreenMode); return true;
                case "height": _value = new global::Lua.LuaValue(global::UnityEngine.Screen.height); return true;
                case "mainWindowDisplayInfo": _value = global::Luny.UnityEngine.LuaDisplayInfo.Bind(global::UnityEngine.Screen.mainWindowDisplayInfo); return true;
                case "mainWindowPosition": _value = global::Luny.UnityEngine.LuaVector2Int.Bind(global::UnityEngine.Screen.mainWindowPosition); return true;
                case "msaaSamples": _value = new global::Lua.LuaValue(global::UnityEngine.Screen.msaaSamples); return true;
                case "orientation": _value = new global::Lua.LuaValue((global::System.Int64)global::UnityEngine.Screen.orientation); return true;
                case "resolutions": _value = _factory.Bind(global::UnityEngine.Screen.resolutions); return true;
                case "safeArea": _value = global::Luny.UnityEngine.LuaRect.Bind(global::UnityEngine.Screen.safeArea); return true;
                case "sleepTimeout": _value = new global::Lua.LuaValue(global::UnityEngine.Screen.sleepTimeout); return true;
                case "width": _value = new global::Lua.LuaValue(global::UnityEngine.Screen.width); return true;
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
                case "autorotateToLandscapeLeft": global::UnityEngine.Screen.autorotateToLandscapeLeft = _value.Read<global::System.Boolean>();  return true;
                case "autorotateToLandscapeRight": global::UnityEngine.Screen.autorotateToLandscapeRight = _value.Read<global::System.Boolean>();  return true;
                case "autorotateToPortrait": global::UnityEngine.Screen.autorotateToPortrait = _value.Read<global::System.Boolean>();  return true;
                case "autorotateToPortraitUpsideDown": global::UnityEngine.Screen.autorotateToPortraitUpsideDown = _value.Read<global::System.Boolean>();  return true;
                case "brightness": global::UnityEngine.Screen.brightness = _value.Read<global::System.Single>();  return true;
                case "fullScreen": global::UnityEngine.Screen.fullScreen = _value.Read<global::System.Boolean>();  return true;
                case "fullScreenMode": global::UnityEngine.Screen.fullScreenMode = _value.Read<global::UnityEngine.FullScreenMode>();  return true;
                case "orientation": global::UnityEngine.Screen.orientation = _value.Read<global::UnityEngine.ScreenOrientation>();  return true;
                case "sleepTimeout": global::UnityEngine.Screen.sleepTimeout = _value.Read<global::System.Int32>();  return true;
                default: return false;
            }
        }
    }
}
#pragma warning restore 0109, 0162, 0168, 0219
#endif
