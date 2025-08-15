
// --------------------------------------------------------------
// GENERATED FILE ----> DO NOT EDIT <---- CHANGES WILL BE LOST !!
// --------------------------------------------------------------

#if UNITY_6000_1_OR_NEWER && !(UNITY_6000_2_OR_NEWER)
#pragma warning disable 0109, 0162, 0168, 0219
using Luny;

namespace Luny.UnityEditor
{
    public sealed class LuaPlayerSettingsSplashScreen : global::Luny.ILuaObject<global::UnityEditor.PlayerSettings.SplashScreen>
    {
        public new static global::Lua.LuaValue Bind(global::UnityEditor.PlayerSettings.SplashScreen instance) => new LuaPlayerSettingsSplashScreen(instance);
        public new static global::Lua.LuaValue Bind(global::System.Object instance) => Bind((global::UnityEditor.PlayerSettings.SplashScreen)instance);
        public new static global::Lua.LuaValue Bind(global::System.Collections.Generic.IList<global::UnityEditor.PlayerSettings.SplashScreen> instances) =>
            new global::Luny.LuaList<global::UnityEditor.PlayerSettings.SplashScreen>(instances);
        public new static global::Lua.LuaValue Bind(global::System.Collections.Generic.IList<global::System.Object> instances) =>
            new global::Luny.LuaList<global::UnityEditor.PlayerSettings.SplashScreen>(instances);
        private LuaPlayerSettingsSplashScreen(global::UnityEditor.PlayerSettings.SplashScreen instance) => m_Instance = instance;
        public static implicit operator global::Lua.LuaValue(LuaPlayerSettingsSplashScreen value) => new(value);
        private global::UnityEditor.PlayerSettings.SplashScreen m_Instance;
        public global::UnityEditor.PlayerSettings.SplashScreen Instance => m_Instance;
        public new global::System.Type BindType => typeof(global::UnityEditor.PlayerSettings.SplashScreen);
        private static global::Lua.LuaTable s_Metatable;
        public global::Lua.LuaTable Metatable
        {
            get => s_Metatable ??= CreateMetatable();
            set => throw new global::System.NotSupportedException("LuaObject metatables cannot be modified");
        }
        global::System.Span<global::Lua.LuaValue> global::Lua.ILuaUserData.UserValues => default;
        private static global::Lua.LuaTable CreateMetatable()
        {
            var metatable = new global::Lua.LuaTable(0, 5);
            metatable[global::Lua.Runtime.Metamethods.Index] = __index;
            metatable[global::Lua.Runtime.Metamethods.NewIndex] = __newindex;
            metatable[global::Lua.Runtime.Metamethods.Concat] = global::Luny.LuaMetatable.ConcatMetamethod;
            metatable[global::Lua.Runtime.Metamethods.ToString] = global::Luny.LuaMetatable.ToStringMetamethod;
            return metatable;
        }
        public override global::System.String ToString() => m_Instance != null ? Instance.ToString() : "{GetType().Name}(null)";
#if UNITY_EDITOR
        [global::UnityEngine.RuntimeInitializeOnLoadMethod(global::UnityEngine.RuntimeInitializeLoadType.SubsystemRegistration)]
        private static void ResetStaticFields() => s_Metatable = null;
#endif

        private static readonly global::Lua.LuaFunction __index = new(global::Lua.Runtime.Metamethods.Index, (_context, _) =>
        {
            var _this = _context.GetArgument<LuaPlayerSettingsSplashScreen>(0);
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
            var _this = _context.GetArgument<LuaPlayerSettingsSplashScreen>(0);
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
    public sealed class LuaPlayerSettingsSplashScreenType : global::Luny.ILuaStatic
    {
        public static global::Lua.LuaValue Bind() => new LuaPlayerSettingsSplashScreenType();
        private LuaPlayerSettingsSplashScreenType() {}
        public static implicit operator global::Lua.LuaValue(LuaPlayerSettingsSplashScreenType value) => new(value);
        public global::System.Type BindType => typeof(global::UnityEditor.PlayerSettings.SplashScreen);
        private static global::Lua.LuaTable s_Metatable;
        public global::Lua.LuaTable Metatable
        {
            get => s_Metatable ??= CreateMetatable();
            set => throw new global::System.NotSupportedException("LuaObject metatables cannot be modified");
        }
        global::System.Span<global::Lua.LuaValue> global::Lua.ILuaUserData.UserValues => default;
        private static global::Lua.LuaTable CreateMetatable()
        {
            var metatable = new global::Lua.LuaTable(0, 5);
            metatable[global::Lua.Runtime.Metamethods.Index] = __index;
            metatable[global::Lua.Runtime.Metamethods.NewIndex] = __newindex;
            metatable[global::Lua.Runtime.Metamethods.Concat] = global::Luny.LuaMetatable.ConcatMetamethod;
            metatable[global::Lua.Runtime.Metamethods.ToString] = global::Luny.LuaMetatable.ToStringMetamethod;
            metatable[global::Lua.Runtime.Metamethods.Call] = _LuaPlayerSettingsSplashScreen_new;
            return metatable;
        }
        public override global::System.String ToString() => BindType.FullName;
#if UNITY_EDITOR
        [global::UnityEngine.RuntimeInitializeOnLoadMethod(global::UnityEngine.RuntimeInitializeLoadType.SubsystemRegistration)]
        private static void ResetStaticFields() => s_Metatable = null;
#endif

        private static readonly global::Lua.LuaFunction _LuaPlayerSettingsSplashScreen_new = new global::Lua.LuaFunction(".ctor", (_context, _) =>
        {
            global::Lua.LuaValue _lastArg = default;
            global::System.Int32 _lastArgPos = default;
            global::System.Type _expectedType = default;
            var _argCount = _context.ArgumentCount;
            if (_argCount == 1)
            {
                var _ret0 = new global::UnityEditor.PlayerSettings.SplashScreen();
                var _factory = _context.GetObjectFactory();
                var _lret0 = _factory.Bind(_ret0);
                var _retCount = _context.Return(_lret0);
                return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
            }
            throw new global::Lua.LuaRuntimeException(_context.Thread, $"{".ctor"}: invalid argument #{_lastArgPos}: {_lastArg} ({_lastArg.Type}), expected: {_expectedType.FullName}", 2);
        });
        private static readonly global::Lua.LuaFunction __index = new(global::Lua.Runtime.Metamethods.Index, (_context, _) =>
        {
            var _this = _context.GetArgument<LuaPlayerSettingsSplashScreenType>(0);
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
            var _this = _context.GetArgument<LuaPlayerSettingsSplashScreenType>(0);
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
                case "animationBackgroundZoom": _value = new global::Lua.LuaValue(global::UnityEditor.PlayerSettings.SplashScreen.animationBackgroundZoom); return true;
                case "animationLogoZoom": _value = new global::Lua.LuaValue(global::UnityEditor.PlayerSettings.SplashScreen.animationLogoZoom); return true;
                case "animationMode": _value = new global::Lua.LuaValue((global::System.Int64)global::UnityEditor.PlayerSettings.SplashScreen.animationMode); return true;
                case "background": _value = _factory.Bind(global::UnityEditor.PlayerSettings.SplashScreen.background); return true;
                case "backgroundColor": _value = _factory.Bind(global::UnityEditor.PlayerSettings.SplashScreen.backgroundColor); return true;
                case "backgroundPortrait": _value = _factory.Bind(global::UnityEditor.PlayerSettings.SplashScreen.backgroundPortrait); return true;
                case "blurBackgroundImage": _value = new global::Lua.LuaValue(global::UnityEditor.PlayerSettings.SplashScreen.blurBackgroundImage); return true;
                case "drawMode": _value = new global::Lua.LuaValue((global::System.Int64)global::UnityEditor.PlayerSettings.SplashScreen.drawMode); return true;
                case "logos": _value = _factory.Bind(global::UnityEditor.PlayerSettings.SplashScreen.logos); return true;
                case "overlayOpacity": _value = new global::Lua.LuaValue(global::UnityEditor.PlayerSettings.SplashScreen.overlayOpacity); return true;
                case "show": _value = new global::Lua.LuaValue(global::UnityEditor.PlayerSettings.SplashScreen.show); return true;
                case "showUnityLogo": _value = new global::Lua.LuaValue(global::UnityEditor.PlayerSettings.SplashScreen.showUnityLogo); return true;
                case "unityLogoStyle": _value = new global::Lua.LuaValue((global::System.Int64)global::UnityEditor.PlayerSettings.SplashScreen.unityLogoStyle); return true;
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
                case "animationBackgroundZoom": global::UnityEditor.PlayerSettings.SplashScreen.animationBackgroundZoom = _value.Read<global::System.Single>();  return true;
                case "animationLogoZoom": global::UnityEditor.PlayerSettings.SplashScreen.animationLogoZoom = _value.Read<global::System.Single>();  return true;
                case "animationMode": global::UnityEditor.PlayerSettings.SplashScreen.animationMode = _value.Read<global::UnityEditor.PlayerSettings.SplashScreen.AnimationMode>();  return true;
                case "background": global::UnityEditor.PlayerSettings.SplashScreen.background = _value.Read<global::UnityEngine.Sprite>();  return true;
                case "backgroundColor": global::UnityEditor.PlayerSettings.SplashScreen.backgroundColor = _value.Read<global::UnityEngine.Color>();  return true;
                case "backgroundPortrait": global::UnityEditor.PlayerSettings.SplashScreen.backgroundPortrait = _value.Read<global::UnityEngine.Sprite>();  return true;
                case "blurBackgroundImage": global::UnityEditor.PlayerSettings.SplashScreen.blurBackgroundImage = _value.Read<global::System.Boolean>();  return true;
                case "drawMode": global::UnityEditor.PlayerSettings.SplashScreen.drawMode = _value.Read<global::UnityEditor.PlayerSettings.SplashScreen.DrawMode>();  return true;
                case "logos": global::UnityEditor.PlayerSettings.SplashScreen.logos = _value.Read<global::UnityEditor.PlayerSettings.SplashScreenLogo[]>();  return true;
                case "overlayOpacity": global::UnityEditor.PlayerSettings.SplashScreen.overlayOpacity = _value.Read<global::System.Single>();  return true;
                case "show": global::UnityEditor.PlayerSettings.SplashScreen.show = _value.Read<global::System.Boolean>();  return true;
                case "showUnityLogo": global::UnityEditor.PlayerSettings.SplashScreen.showUnityLogo = _value.Read<global::System.Boolean>();  return true;
                case "unityLogoStyle": global::UnityEditor.PlayerSettings.SplashScreen.unityLogoStyle = _value.Read<global::UnityEditor.PlayerSettings.SplashScreen.UnityLogoStyle>();  return true;
                default: return false;
            }
        }
    }
}
#pragma warning restore 0109, 0162, 0168, 0219
#endif
