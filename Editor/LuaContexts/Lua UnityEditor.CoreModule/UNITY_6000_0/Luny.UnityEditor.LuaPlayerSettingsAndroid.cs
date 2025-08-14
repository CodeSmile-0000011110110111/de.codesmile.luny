
// --------------------------------------------------------------
// GENERATED FILE ----> DO NOT EDIT <---- CHANGES WILL BE LOST !!
// --------------------------------------------------------------

#if UNITY_6000_0_OR_NEWER && !(UNITY_6000_1_OR_NEWER)
#pragma warning disable 0109, 0162, 0168, 0219
using Luny;

namespace Luny.UnityEditor
{
    public sealed class LuaPlayerSettingsAndroid : global::Luny.ILuaObject<global::UnityEditor.PlayerSettings.Android>
    {
        public new static global::Lua.LuaValue Bind(global::UnityEditor.PlayerSettings.Android instance) => new LuaPlayerSettingsAndroid(instance);
        public new static global::Lua.LuaValue Bind(global::System.Object instance) => Bind((global::UnityEditor.PlayerSettings.Android)instance);
        public new static global::Lua.LuaValue Bind(global::System.Collections.Generic.IList<global::UnityEditor.PlayerSettings.Android> instances) =>
            new global::Luny.LuaList<global::UnityEditor.PlayerSettings.Android>(instances);
        public new static global::Lua.LuaValue Bind(global::System.Collections.Generic.IList<global::System.Object> instances) =>
            new global::Luny.LuaList<global::UnityEditor.PlayerSettings.Android>(instances);
        private LuaPlayerSettingsAndroid(global::UnityEditor.PlayerSettings.Android instance) => m_Instance = instance;
        public static implicit operator global::Lua.LuaValue(LuaPlayerSettingsAndroid value) => new(value);
        private global::UnityEditor.PlayerSettings.Android m_Instance;
        public global::UnityEditor.PlayerSettings.Android Instance => m_Instance;
        public new global::System.Type BindType => typeof(global::UnityEditor.PlayerSettings.Android);
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
            var _this = _context.GetArgument<LuaPlayerSettingsAndroid>(0);
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
            var _this = _context.GetArgument<LuaPlayerSettingsAndroid>(0);
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
    public sealed class LuaPlayerSettingsAndroidType : global::Luny.ILuaStatic
    {
        public static global::Lua.LuaValue Bind() => new LuaPlayerSettingsAndroidType();
        private LuaPlayerSettingsAndroidType() {}
        public static implicit operator global::Lua.LuaValue(LuaPlayerSettingsAndroidType value) => new(value);
        public global::System.Type BindType => typeof(global::UnityEditor.PlayerSettings.Android);
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
            metatable[global::Lua.Runtime.Metamethods.Call] = _LuaPlayerSettingsAndroid_new;
            return metatable;
        }
        public override global::System.String ToString() => BindType.FullName;
#if UNITY_EDITOR
        [global::UnityEngine.RuntimeInitializeOnLoadMethod(global::UnityEngine.RuntimeInitializeLoadType.SubsystemRegistration)]
        private static void ResetStaticFields() => s_Metatable = null;
#endif

        private static readonly global::Lua.LuaFunction _LuaPlayerSettingsAndroid_new = new global::Lua.LuaFunction(".ctor", (_context, _) =>
        {
            global::Lua.LuaValue _lastArg = default;
            global::System.Int32 _lastArgPos = default;
            global::System.Type _expectedType = default;
            var _argCount = _context.ArgumentCount;
            if (_argCount == 1)
            {
                var _ret0 = new global::UnityEditor.PlayerSettings.Android();
                var _factory = _context.GetObjectFactory();
                var _lret0 = _factory.Bind(_ret0);
                var _retCount = _context.Return(_lret0);
                return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
            }
            throw new global::Lua.LuaRuntimeException(_context.Thread, $"{".ctor"}: invalid argument #{_lastArgPos}: {_lastArg} ({_lastArg.Type}), expected: {_expectedType.FullName}", 2);
        });
        private static readonly global::Lua.LuaFunction __index = new(global::Lua.Runtime.Metamethods.Index, (_context, _) =>
        {
            var _this = _context.GetArgument<LuaPlayerSettingsAndroidType>(0);
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
            var _this = _context.GetArgument<LuaPlayerSettingsAndroidType>(0);
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
                case "androidIsGame": _value = new global::Lua.LuaValue(global::UnityEditor.PlayerSettings.Android.androidIsGame); return true;
                case "androidTVCompatibility": _value = new global::Lua.LuaValue(global::UnityEditor.PlayerSettings.Android.androidTVCompatibility); return true;
                case "androidVulkanAllowFilterList": _value = _factory.Bind(global::UnityEditor.PlayerSettings.Android.androidVulkanAllowFilterList); return true;
                case "androidVulkanDenyFilterList": _value = _factory.Bind(global::UnityEditor.PlayerSettings.Android.androidVulkanDenyFilterList); return true;
                case "applicationEntry": _value = new global::Lua.LuaValue((global::System.Int64)global::UnityEditor.PlayerSettings.Android.applicationEntry); return true;
                case "ARCoreEnabled": _value = new global::Lua.LuaValue(global::UnityEditor.PlayerSettings.Android.ARCoreEnabled); return true;
                case "autoRotationBehavior": _value = new global::Lua.LuaValue((global::System.Int64)global::UnityEditor.PlayerSettings.Android.autoRotationBehavior); return true;
                case "blitType": _value = new global::Lua.LuaValue((global::System.Int64)global::UnityEditor.PlayerSettings.Android.blitType); return true;
                case "buildApkPerCpuArchitecture": _value = new global::Lua.LuaValue(global::UnityEditor.PlayerSettings.Android.buildApkPerCpuArchitecture); return true;
                case "bundleVersionCode": _value = new global::Lua.LuaValue(global::UnityEditor.PlayerSettings.Android.bundleVersionCode); return true;
                case "defaultWindowHeight": _value = new global::Lua.LuaValue(global::UnityEditor.PlayerSettings.Android.defaultWindowHeight); return true;
                case "defaultWindowWidth": _value = new global::Lua.LuaValue(global::UnityEditor.PlayerSettings.Android.defaultWindowWidth); return true;
                case "disableDepthAndStencilBuffers": _value = new global::Lua.LuaValue(global::UnityEditor.PlayerSettings.Android.disableDepthAndStencilBuffers); return true;
                case "enableArmv9SecurityFeatures": _value = new global::Lua.LuaValue(global::UnityEditor.PlayerSettings.Android.enableArmv9SecurityFeatures); return true;
                case "forceInternetPermission": _value = new global::Lua.LuaValue(global::UnityEditor.PlayerSettings.Android.forceInternetPermission); return true;
                case "forceSDCardPermission": _value = new global::Lua.LuaValue(global::UnityEditor.PlayerSettings.Android.forceSDCardPermission); return true;
                case "fullscreenMode": _value = new global::Lua.LuaValue((global::System.Int64)global::UnityEditor.PlayerSettings.Android.fullscreenMode); return true;
                case "keyaliasName": _value = new global::Lua.LuaValue(global::UnityEditor.PlayerSettings.Android.keyaliasName); return true;
                case "keyaliasPass": _value = new global::Lua.LuaValue(global::UnityEditor.PlayerSettings.Android.keyaliasPass); return true;
                case "keystoreName": _value = new global::Lua.LuaValue(global::UnityEditor.PlayerSettings.Android.keystoreName); return true;
                case "keystorePass": _value = new global::Lua.LuaValue(global::UnityEditor.PlayerSettings.Android.keystorePass); return true;
                case "licenseVerification": _value = new global::Lua.LuaValue(global::UnityEditor.PlayerSettings.Android.licenseVerification); return true;
                case "maxAspectRatio": _value = new global::Lua.LuaValue(global::UnityEditor.PlayerSettings.Android.maxAspectRatio); return true;
                case "minAspectRatio": _value = new global::Lua.LuaValue(global::UnityEditor.PlayerSettings.Android.minAspectRatio); return true;
                case "minifyDebug": _value = new global::Lua.LuaValue(global::UnityEditor.PlayerSettings.Android.minifyDebug); return true;
                case "minifyRelease": _value = new global::Lua.LuaValue(global::UnityEditor.PlayerSettings.Android.minifyRelease); return true;
                case "minimumWindowHeight": _value = new global::Lua.LuaValue(global::UnityEditor.PlayerSettings.Android.minimumWindowHeight); return true;
                case "minimumWindowWidth": _value = new global::Lua.LuaValue(global::UnityEditor.PlayerSettings.Android.minimumWindowWidth); return true;
                case "minSdkVersion": _value = new global::Lua.LuaValue((global::System.Int64)global::UnityEditor.PlayerSettings.Android.minSdkVersion); return true;
                case "optimizedFramePacing": _value = new global::Lua.LuaValue(global::UnityEditor.PlayerSettings.Android.optimizedFramePacing); return true;
                case "predictiveBackSupport": _value = new global::Lua.LuaValue(global::UnityEditor.PlayerSettings.Android.predictiveBackSupport); return true;
                case "preferredInstallLocation": _value = new global::Lua.LuaValue((global::System.Int64)global::UnityEditor.PlayerSettings.Android.preferredInstallLocation); return true;
                case "renderOutsideSafeArea": _value = new global::Lua.LuaValue(global::UnityEditor.PlayerSettings.Android.renderOutsideSafeArea); return true;
                case "reportGooglePlayAppDependencies": _value = new global::Lua.LuaValue(global::UnityEditor.PlayerSettings.Android.reportGooglePlayAppDependencies); return true;
                case "resizeableActivity": _value = new global::Lua.LuaValue(global::UnityEditor.PlayerSettings.Android.resizeableActivity); return true;
                case "runWithoutFocus": _value = new global::Lua.LuaValue(global::UnityEditor.PlayerSettings.Android.runWithoutFocus); return true;
                case "showActivityIndicatorOnLoading": _value = new global::Lua.LuaValue((global::System.Int64)global::UnityEditor.PlayerSettings.Android.showActivityIndicatorOnLoading); return true;
                case "splashScreenScale": _value = new global::Lua.LuaValue((global::System.Int64)global::UnityEditor.PlayerSettings.Android.splashScreenScale); return true;
                case "splitApplicationBinary": _value = new global::Lua.LuaValue(global::UnityEditor.PlayerSettings.Android.splitApplicationBinary); return true;
                case "startInFullscreen": _value = new global::Lua.LuaValue(global::UnityEditor.PlayerSettings.Android.startInFullscreen); return true;
                case "targetArchitectures": _value = new global::Lua.LuaValue((global::System.Int64)global::UnityEditor.PlayerSettings.Android.targetArchitectures); return true;
                case "targetSdkVersion": _value = new global::Lua.LuaValue((global::System.Int64)global::UnityEditor.PlayerSettings.Android.targetSdkVersion); return true;
                case "textureCompressionFormats": _value = _factory.Bind(global::UnityEditor.PlayerSettings.Android.textureCompressionFormats); return true;
                case "useCustomKeystore": _value = new global::Lua.LuaValue(global::UnityEditor.PlayerSettings.Android.useCustomKeystore); return true;
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
                case "androidIsGame": global::UnityEditor.PlayerSettings.Android.androidIsGame = _value.Read<global::System.Boolean>();  return true;
                case "androidTVCompatibility": global::UnityEditor.PlayerSettings.Android.androidTVCompatibility = _value.Read<global::System.Boolean>();  return true;
                case "androidVulkanAllowFilterList": global::UnityEditor.PlayerSettings.Android.androidVulkanAllowFilterList = _value.Read<global::UnityEditor.AndroidDeviceFilterData[]>();  return true;
                case "androidVulkanDenyFilterList": global::UnityEditor.PlayerSettings.Android.androidVulkanDenyFilterList = _value.Read<global::UnityEditor.AndroidDeviceFilterData[]>();  return true;
                case "applicationEntry": global::UnityEditor.PlayerSettings.Android.applicationEntry = _value.Read<global::UnityEditor.AndroidApplicationEntry>();  return true;
                case "ARCoreEnabled": global::UnityEditor.PlayerSettings.Android.ARCoreEnabled = _value.Read<global::System.Boolean>();  return true;
                case "autoRotationBehavior": global::UnityEditor.PlayerSettings.Android.autoRotationBehavior = _value.Read<global::UnityEditor.AndroidAutoRotationBehavior>();  return true;
                case "blitType": global::UnityEditor.PlayerSettings.Android.blitType = _value.Read<global::UnityEditor.AndroidBlitType>();  return true;
                case "buildApkPerCpuArchitecture": global::UnityEditor.PlayerSettings.Android.buildApkPerCpuArchitecture = _value.Read<global::System.Boolean>();  return true;
                case "bundleVersionCode": global::UnityEditor.PlayerSettings.Android.bundleVersionCode = _value.Read<global::System.Int32>();  return true;
                case "defaultWindowHeight": global::UnityEditor.PlayerSettings.Android.defaultWindowHeight = _value.Read<global::System.Int32>();  return true;
                case "defaultWindowWidth": global::UnityEditor.PlayerSettings.Android.defaultWindowWidth = _value.Read<global::System.Int32>();  return true;
                case "disableDepthAndStencilBuffers": global::UnityEditor.PlayerSettings.Android.disableDepthAndStencilBuffers = _value.Read<global::System.Boolean>();  return true;
                case "enableArmv9SecurityFeatures": global::UnityEditor.PlayerSettings.Android.enableArmv9SecurityFeatures = _value.Read<global::System.Boolean>();  return true;
                case "forceInternetPermission": global::UnityEditor.PlayerSettings.Android.forceInternetPermission = _value.Read<global::System.Boolean>();  return true;
                case "forceSDCardPermission": global::UnityEditor.PlayerSettings.Android.forceSDCardPermission = _value.Read<global::System.Boolean>();  return true;
                case "fullscreenMode": global::UnityEditor.PlayerSettings.Android.fullscreenMode = _value.Read<global::UnityEngine.FullScreenMode>();  return true;
                case "keyaliasName": global::UnityEditor.PlayerSettings.Android.keyaliasName = _value.Read<global::System.String>();  return true;
                case "keyaliasPass": global::UnityEditor.PlayerSettings.Android.keyaliasPass = _value.Read<global::System.String>();  return true;
                case "keystoreName": global::UnityEditor.PlayerSettings.Android.keystoreName = _value.Read<global::System.String>();  return true;
                case "keystorePass": global::UnityEditor.PlayerSettings.Android.keystorePass = _value.Read<global::System.String>();  return true;
                case "maxAspectRatio": global::UnityEditor.PlayerSettings.Android.maxAspectRatio = _value.Read<global::System.Single>();  return true;
                case "minAspectRatio": global::UnityEditor.PlayerSettings.Android.minAspectRatio = _value.Read<global::System.Single>();  return true;
                case "minifyDebug": global::UnityEditor.PlayerSettings.Android.minifyDebug = _value.Read<global::System.Boolean>();  return true;
                case "minifyRelease": global::UnityEditor.PlayerSettings.Android.minifyRelease = _value.Read<global::System.Boolean>();  return true;
                case "minimumWindowHeight": global::UnityEditor.PlayerSettings.Android.minimumWindowHeight = _value.Read<global::System.Int32>();  return true;
                case "minimumWindowWidth": global::UnityEditor.PlayerSettings.Android.minimumWindowWidth = _value.Read<global::System.Int32>();  return true;
                case "minSdkVersion": global::UnityEditor.PlayerSettings.Android.minSdkVersion = _value.Read<global::UnityEditor.AndroidSdkVersions>();  return true;
                case "optimizedFramePacing": global::UnityEditor.PlayerSettings.Android.optimizedFramePacing = _value.Read<global::System.Boolean>();  return true;
                case "predictiveBackSupport": global::UnityEditor.PlayerSettings.Android.predictiveBackSupport = _value.Read<global::System.Boolean>();  return true;
                case "preferredInstallLocation": global::UnityEditor.PlayerSettings.Android.preferredInstallLocation = _value.Read<global::UnityEditor.AndroidPreferredInstallLocation>();  return true;
                case "renderOutsideSafeArea": global::UnityEditor.PlayerSettings.Android.renderOutsideSafeArea = _value.Read<global::System.Boolean>();  return true;
                case "reportGooglePlayAppDependencies": global::UnityEditor.PlayerSettings.Android.reportGooglePlayAppDependencies = _value.Read<global::System.Boolean>();  return true;
                case "resizeableActivity": global::UnityEditor.PlayerSettings.Android.resizeableActivity = _value.Read<global::System.Boolean>();  return true;
                case "runWithoutFocus": global::UnityEditor.PlayerSettings.Android.runWithoutFocus = _value.Read<global::System.Boolean>();  return true;
                case "showActivityIndicatorOnLoading": global::UnityEditor.PlayerSettings.Android.showActivityIndicatorOnLoading = _value.Read<global::UnityEditor.AndroidShowActivityIndicatorOnLoading>();  return true;
                case "splashScreenScale": global::UnityEditor.PlayerSettings.Android.splashScreenScale = _value.Read<global::UnityEditor.AndroidSplashScreenScale>();  return true;
                case "splitApplicationBinary": global::UnityEditor.PlayerSettings.Android.splitApplicationBinary = _value.Read<global::System.Boolean>();  return true;
                case "startInFullscreen": global::UnityEditor.PlayerSettings.Android.startInFullscreen = _value.Read<global::System.Boolean>();  return true;
                case "targetArchitectures": global::UnityEditor.PlayerSettings.Android.targetArchitectures = _value.Read<global::UnityEditor.AndroidArchitecture>();  return true;
                case "targetSdkVersion": global::UnityEditor.PlayerSettings.Android.targetSdkVersion = _value.Read<global::UnityEditor.AndroidSdkVersions>();  return true;
                case "textureCompressionFormats": global::UnityEditor.PlayerSettings.Android.textureCompressionFormats = _value.Read<global::UnityEditor.TextureCompressionFormat[]>();  return true;
                case "useCustomKeystore": global::UnityEditor.PlayerSettings.Android.useCustomKeystore = _value.Read<global::System.Boolean>();  return true;
                default: return false;
            }
        }
    }
}
#pragma warning restore 0109, 0162, 0168, 0219
#endif
