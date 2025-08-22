
// --------------------------------------------------------------
// GENERATED FILE ----> DO NOT EDIT <---- CHANGES WILL BE LOST !!
// --------------------------------------------------------------

#if UNITY_6000_2_OR_NEWER && !(UNITY_6000_3_OR_NEWER)
#pragma warning disable 0109, 0162, 0168, 0219
using Luny;

namespace LunyEditor.UnityEditor
{
    public class LuaPlayerSettingsiOS : global::Luny.ILuaObject<global::UnityEditor.PlayerSettings.iOS>
    {
        public new static global::Lua.LuaValue Bind(global::UnityEditor.PlayerSettings.iOS instance) => new LuaPlayerSettingsiOS(instance);
        public new static global::Lua.LuaValue Bind(global::System.Object instance) => Bind((global::UnityEditor.PlayerSettings.iOS)instance);
        public new static global::Lua.LuaValue Bind(global::System.Collections.Generic.IList<global::UnityEditor.PlayerSettings.iOS> instances) =>
            new global::Luny.LuaList<global::UnityEditor.PlayerSettings.iOS>(instances);
        public new static global::Lua.LuaValue Bind(global::System.Collections.Generic.IList<global::System.Object> instances) =>
            new global::Luny.LuaList<global::UnityEditor.PlayerSettings.iOS>(instances);
        protected LuaPlayerSettingsiOS(global::UnityEditor.PlayerSettings.iOS instance) => m_Instance = instance;
        public static implicit operator global::Lua.LuaValue(LuaPlayerSettingsiOS value) => new(value);
        protected global::UnityEditor.PlayerSettings.iOS m_Instance;
        public global::UnityEditor.PlayerSettings.iOS Instance => m_Instance;
        public new global::System.Type BindType => typeof(global::UnityEditor.PlayerSettings.iOS);
        public override global::System.String ToString() => m_Instance != null ? Instance.ToString() : "{GetType().Name}(null)";
#if UNITY_EDITOR
        [global::UnityEngine.RuntimeInitializeOnLoadMethod(global::UnityEngine.RuntimeInitializeLoadType.SubsystemRegistration)]
        private static void ResetStaticFields() => s_Metatable = null;
#endif

        private static readonly global::Lua.LuaFunction __index = new(global::Lua.Runtime.Metamethods.Index, (_context, _) =>
        {
            var _this = _context.GetArgument<LuaPlayerSettingsiOS>(0);
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
            var _this = _context.GetArgument<LuaPlayerSettingsiOS>(0);
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

        public virtual global::System.Boolean TryGetLuaValue(global::System.Int32 _key, out global::Lua.LuaValue _value, global::Luny.ILuaObjectFactory _factory)
        {
            _value = global::Lua.LuaValue.Nil; return false;
        }
        public virtual global::System.Boolean TryGetLuaValue(global::System.String _key, out global::Lua.LuaValue _value, global::Luny.ILuaObjectFactory _factory)
        {
            switch (_key)
            {
                default: _value = global::Lua.LuaValue.Nil; return false;
            }
        }
        public virtual global::System.Boolean TrySetLuaValue(global::System.Int32 _key, global::Lua.LuaValue _value)
        {
            return false;
        }
        public virtual global::System.Boolean TrySetLuaValue(global::System.String _key, global::Lua.LuaValue _value)
        {
            switch (_key)
            {
                default: return false;
            }
        }
    }
    public sealed class LuaPlayerSettingsiOSType : global::Luny.ILuaStatic
    {
        public static global::Lua.LuaValue Bind() => new LuaPlayerSettingsiOSType();
        private LuaPlayerSettingsiOSType() {}
        public static implicit operator global::Lua.LuaValue(LuaPlayerSettingsiOSType value) => new(value);
        public global::System.Type BindType => typeof(global::UnityEditor.PlayerSettings.iOS);
        public override global::System.String ToString() => BindType.FullName;
#if UNITY_EDITOR
        [global::UnityEngine.RuntimeInitializeOnLoadMethod(global::UnityEngine.RuntimeInitializeLoadType.SubsystemRegistration)]
        private static void ResetStaticFields() => s_Metatable = null;
#endif

        private static readonly global::Lua.LuaFunction _LuaPlayerSettingsiOS_new = new global::Lua.LuaFunction(".ctor", (_context, _) =>
        {
            global::Lua.LuaValue _lastArg = default;
            global::System.Int32 _lastArgPos = default;
            global::System.Type _expectedType = default;
            var _argCount = _context.ArgumentCount;
            if (_argCount == 1)
            {
                var _ret0 = new global::UnityEditor.PlayerSettings.iOS();
                var _factory = _context.GetObjectFactory();
                var _lret0 = _factory.Bind(_ret0);
                var _retCount = _context.Return(_lret0);
                return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
            }
            throw new global::Lua.LuaRuntimeException(_context.Thread, $"{".ctor"}: invalid argument #{_lastArgPos}: {_lastArg} ({_lastArg.Type}), expected: {_expectedType.FullName}", 2);
        });
        private static readonly global::Lua.LuaFunction _LuaPlayerSettingsiOS_SetiPadLaunchScreenType = new global::Lua.LuaFunction("SetiPadLaunchScreenType", (_context, _) =>
        {
            global::Lua.LuaValue _lastArg = default;
            global::System.Int32 _lastArgPos = default;
            global::System.Type _expectedType = default;
            var _argCount = _context.ArgumentCount;
            var _arg0 = _lastArg = _argCount > 0 ? _context.GetArgument(0) : global::Lua.LuaValue.Nil;
            _lastArgPos = 0; _expectedType = typeof(global::UnityEditor.iOSLaunchScreenType);
            if (_arg0.TryRead<global::UnityEditor.iOSLaunchScreenType>(out var _p0_UnityEditor_iOSLaunchScreenType))
            {
                if (_argCount == 1)
                {
                    var type = _p0_UnityEditor_iOSLaunchScreenType;
                    global::UnityEditor.PlayerSettings.iOS.SetiPadLaunchScreenType(type);
                    var _retCount = _context.Return();
                    return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                }
            }
            throw new global::Lua.LuaRuntimeException(_context.Thread, $"{"SetiPadLaunchScreenType"}: invalid argument #{_lastArgPos}: {_lastArg} ({_lastArg.Type}), expected: {_expectedType.FullName}", 2);
        });
        private static readonly global::Lua.LuaFunction _LuaPlayerSettingsiOS_SetiPhoneLaunchScreenType = new global::Lua.LuaFunction("SetiPhoneLaunchScreenType", (_context, _) =>
        {
            global::Lua.LuaValue _lastArg = default;
            global::System.Int32 _lastArgPos = default;
            global::System.Type _expectedType = default;
            var _argCount = _context.ArgumentCount;
            var _arg0 = _lastArg = _argCount > 0 ? _context.GetArgument(0) : global::Lua.LuaValue.Nil;
            _lastArgPos = 0; _expectedType = typeof(global::UnityEditor.iOSLaunchScreenType);
            if (_arg0.TryRead<global::UnityEditor.iOSLaunchScreenType>(out var _p0_UnityEditor_iOSLaunchScreenType))
            {
                if (_argCount == 1)
                {
                    var type = _p0_UnityEditor_iOSLaunchScreenType;
                    global::UnityEditor.PlayerSettings.iOS.SetiPhoneLaunchScreenType(type);
                    var _retCount = _context.Return();
                    return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                }
            }
            throw new global::Lua.LuaRuntimeException(_context.Thread, $"{"SetiPhoneLaunchScreenType"}: invalid argument #{_lastArgPos}: {_lastArg} ({_lastArg.Type}), expected: {_expectedType.FullName}", 2);
        });
        private static readonly global::Lua.LuaFunction _LuaPlayerSettingsiOS_SetLaunchScreenImage = new global::Lua.LuaFunction("SetLaunchScreenImage", (_context, _) =>
        {
            global::Lua.LuaValue _lastArg = default;
            global::System.Int32 _lastArgPos = default;
            global::System.Type _expectedType = default;
            var _argCount = _context.ArgumentCount;
            var _arg0 = _lastArg = _argCount > 0 ? _context.GetArgument(0) : global::Lua.LuaValue.Nil;
            _lastArgPos = 0; _expectedType = typeof(global::Luny.UnityEngine.LuaTexture2D);
            if (_arg0.TryRead<global::Luny.UnityEngine.LuaTexture2D>(out var _p0_UnityEngine_Texture2D))
            {
                var _arg1 = _lastArg = _argCount > 1 ? _context.GetArgument(1) : global::Lua.LuaValue.Nil;
                _lastArgPos = 1; _expectedType = typeof(global::UnityEditor.iOSLaunchScreenImageType);
                if (_arg1.TryRead<global::UnityEditor.iOSLaunchScreenImageType>(out var _p1_UnityEditor_iOSLaunchScreenImageType))
                {
                    if (_argCount == 2)
                    {
                        var image = _p0_UnityEngine_Texture2D.Instance;
                        var type = _p1_UnityEditor_iOSLaunchScreenImageType;
                        global::UnityEditor.PlayerSettings.iOS.SetLaunchScreenImage(image, type);
                        var _retCount = _context.Return();
                        return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                    }
                }
            }
            throw new global::Lua.LuaRuntimeException(_context.Thread, $"{"SetLaunchScreenImage"}: invalid argument #{_lastArgPos}: {_lastArg} ({_lastArg.Type}), expected: {_expectedType.FullName}", 2);
        });
        private static readonly global::Lua.LuaFunction __index = new(global::Lua.Runtime.Metamethods.Index, (_context, _) =>
        {
            var _this = _context.GetArgument<LuaPlayerSettingsiOSType>(0);
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
            var _this = _context.GetArgument<LuaPlayerSettingsiOSType>(0);
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
            metatable[global::Lua.Runtime.Metamethods.Call] = _LuaPlayerSettingsiOS_new;
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
                case "SetiPadLaunchScreenType": _value = _LuaPlayerSettingsiOS_SetiPadLaunchScreenType; return true;
                case "SetiPhoneLaunchScreenType": _value = _LuaPlayerSettingsiOS_SetiPhoneLaunchScreenType; return true;
                case "SetLaunchScreenImage": _value = _LuaPlayerSettingsiOS_SetLaunchScreenImage; return true;
                case "appInBackgroundBehavior": _value = new global::Lua.LuaValue((global::System.Int64)global::UnityEditor.PlayerSettings.iOS.appInBackgroundBehavior); return true;
                case "appleDeveloperTeamID": _value = new global::Lua.LuaValue(global::UnityEditor.PlayerSettings.iOS.appleDeveloperTeamID); return true;
                case "appleEnableAutomaticSigning": _value = new global::Lua.LuaValue(global::UnityEditor.PlayerSettings.iOS.appleEnableAutomaticSigning); return true;
                case "applicationDisplayName": _value = new global::Lua.LuaValue(global::UnityEditor.PlayerSettings.iOS.applicationDisplayName); return true;
                case "backgroundModes": _value = new global::Lua.LuaValue((global::System.Int64)global::UnityEditor.PlayerSettings.iOS.backgroundModes); return true;
                case "buildNumber": _value = new global::Lua.LuaValue(global::UnityEditor.PlayerSettings.iOS.buildNumber); return true;
                case "cameraUsageDescription": _value = new global::Lua.LuaValue(global::UnityEditor.PlayerSettings.iOS.cameraUsageDescription); return true;
                case "deferSystemGesturesMode": _value = new global::Lua.LuaValue((global::System.Int64)global::UnityEditor.PlayerSettings.iOS.deferSystemGesturesMode); return true;
                case "disableDepthAndStencilBuffers": _value = new global::Lua.LuaValue(global::UnityEditor.PlayerSettings.iOS.disableDepthAndStencilBuffers); return true;
                case "forceHardShadowsOnMetal": _value = new global::Lua.LuaValue(global::UnityEditor.PlayerSettings.iOS.forceHardShadowsOnMetal); return true;
                case "hideHomeButton": _value = new global::Lua.LuaValue(global::UnityEditor.PlayerSettings.iOS.hideHomeButton); return true;
                case "iOSManualProvisioningProfileID": _value = new global::Lua.LuaValue(global::UnityEditor.PlayerSettings.iOS.iOSManualProvisioningProfileID); return true;
                case "iOSManualProvisioningProfileType": _value = new global::Lua.LuaValue((global::System.Int64)global::UnityEditor.PlayerSettings.iOS.iOSManualProvisioningProfileType); return true;
                case "iOSUrlSchemes": _value = _factory.Bind(global::UnityEditor.PlayerSettings.iOS.iOSUrlSchemes); return true;
                case "locationUsageDescription": _value = new global::Lua.LuaValue(global::UnityEditor.PlayerSettings.iOS.locationUsageDescription); return true;
                case "microphoneUsageDescription": _value = new global::Lua.LuaValue(global::UnityEditor.PlayerSettings.iOS.microphoneUsageDescription); return true;
                case "prerenderedIcon": _value = new global::Lua.LuaValue(global::UnityEditor.PlayerSettings.iOS.prerenderedIcon); return true;
                case "requiresFullScreen": _value = new global::Lua.LuaValue(global::UnityEditor.PlayerSettings.iOS.requiresFullScreen); return true;
                case "requiresPersistentWiFi": _value = new global::Lua.LuaValue(global::UnityEditor.PlayerSettings.iOS.requiresPersistentWiFi); return true;
                case "scriptCallOptimization": _value = new global::Lua.LuaValue((global::System.Int64)global::UnityEditor.PlayerSettings.iOS.scriptCallOptimization); return true;
                case "sdkVersion": _value = new global::Lua.LuaValue((global::System.Int64)global::UnityEditor.PlayerSettings.iOS.sdkVersion); return true;
                case "showActivityIndicatorOnLoading": _value = new global::Lua.LuaValue((global::System.Int64)global::UnityEditor.PlayerSettings.iOS.showActivityIndicatorOnLoading); return true;
                case "simulatorSdkArchitecture": _value = new global::Lua.LuaValue((global::System.Int64)global::UnityEditor.PlayerSettings.iOS.simulatorSdkArchitecture); return true;
                case "statusBarStyle": _value = new global::Lua.LuaValue((global::System.Int64)global::UnityEditor.PlayerSettings.iOS.statusBarStyle); return true;
                case "targetDevice": _value = new global::Lua.LuaValue((global::System.Int64)global::UnityEditor.PlayerSettings.iOS.targetDevice); return true;
                case "targetOSVersionString": _value = new global::Lua.LuaValue(global::UnityEditor.PlayerSettings.iOS.targetOSVersionString); return true;
                case "tvOSManualProvisioningProfileID": _value = new global::Lua.LuaValue(global::UnityEditor.PlayerSettings.iOS.tvOSManualProvisioningProfileID); return true;
                case "tvOSManualProvisioningProfileType": _value = new global::Lua.LuaValue((global::System.Int64)global::UnityEditor.PlayerSettings.iOS.tvOSManualProvisioningProfileType); return true;
                case "useOnDemandResources": _value = new global::Lua.LuaValue(global::UnityEditor.PlayerSettings.iOS.useOnDemandResources); return true;
                case "VisionOSManualProvisioningProfileID": _value = new global::Lua.LuaValue(global::UnityEditor.PlayerSettings.iOS.VisionOSManualProvisioningProfileID); return true;
                case "VisionOSManualProvisioningProfileType": _value = new global::Lua.LuaValue((global::System.Int64)global::UnityEditor.PlayerSettings.iOS.VisionOSManualProvisioningProfileType); return true;
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
                case "appInBackgroundBehavior": global::UnityEditor.PlayerSettings.iOS.appInBackgroundBehavior = _value.Read<global::UnityEditor.iOSAppInBackgroundBehavior>();  return true;
                case "appleDeveloperTeamID": global::UnityEditor.PlayerSettings.iOS.appleDeveloperTeamID = _value.Read<global::System.String>();  return true;
                case "appleEnableAutomaticSigning": global::UnityEditor.PlayerSettings.iOS.appleEnableAutomaticSigning = _value.Read<global::System.Boolean>();  return true;
                case "applicationDisplayName": global::UnityEditor.PlayerSettings.iOS.applicationDisplayName = _value.Read<global::System.String>();  return true;
                case "backgroundModes": global::UnityEditor.PlayerSettings.iOS.backgroundModes = _value.Read<global::UnityEditor.iOSBackgroundMode>();  return true;
                case "buildNumber": global::UnityEditor.PlayerSettings.iOS.buildNumber = _value.Read<global::System.String>();  return true;
                case "cameraUsageDescription": global::UnityEditor.PlayerSettings.iOS.cameraUsageDescription = _value.Read<global::System.String>();  return true;
                case "deferSystemGesturesMode": global::UnityEditor.PlayerSettings.iOS.deferSystemGesturesMode = _value.Read<global::UnityEngine.iOS.SystemGestureDeferMode>();  return true;
                case "disableDepthAndStencilBuffers": global::UnityEditor.PlayerSettings.iOS.disableDepthAndStencilBuffers = _value.Read<global::System.Boolean>();  return true;
                case "forceHardShadowsOnMetal": global::UnityEditor.PlayerSettings.iOS.forceHardShadowsOnMetal = _value.Read<global::System.Boolean>();  return true;
                case "hideHomeButton": global::UnityEditor.PlayerSettings.iOS.hideHomeButton = _value.Read<global::System.Boolean>();  return true;
                case "iOSManualProvisioningProfileID": global::UnityEditor.PlayerSettings.iOS.iOSManualProvisioningProfileID = _value.Read<global::System.String>();  return true;
                case "iOSManualProvisioningProfileType": global::UnityEditor.PlayerSettings.iOS.iOSManualProvisioningProfileType = _value.Read<global::UnityEditor.ProvisioningProfileType>();  return true;
                case "iOSUrlSchemes": global::UnityEditor.PlayerSettings.iOS.iOSUrlSchemes = _value.Read<global::System.String[]>();  return true;
                case "locationUsageDescription": global::UnityEditor.PlayerSettings.iOS.locationUsageDescription = _value.Read<global::System.String>();  return true;
                case "microphoneUsageDescription": global::UnityEditor.PlayerSettings.iOS.microphoneUsageDescription = _value.Read<global::System.String>();  return true;
                case "prerenderedIcon": global::UnityEditor.PlayerSettings.iOS.prerenderedIcon = _value.Read<global::System.Boolean>();  return true;
                case "requiresFullScreen": global::UnityEditor.PlayerSettings.iOS.requiresFullScreen = _value.Read<global::System.Boolean>();  return true;
                case "requiresPersistentWiFi": global::UnityEditor.PlayerSettings.iOS.requiresPersistentWiFi = _value.Read<global::System.Boolean>();  return true;
                case "scriptCallOptimization": global::UnityEditor.PlayerSettings.iOS.scriptCallOptimization = _value.Read<global::UnityEditor.ScriptCallOptimizationLevel>();  return true;
                case "sdkVersion": global::UnityEditor.PlayerSettings.iOS.sdkVersion = _value.Read<global::UnityEditor.iOSSdkVersion>();  return true;
                case "showActivityIndicatorOnLoading": global::UnityEditor.PlayerSettings.iOS.showActivityIndicatorOnLoading = _value.Read<global::UnityEditor.iOSShowActivityIndicatorOnLoading>();  return true;
                case "simulatorSdkArchitecture": global::UnityEditor.PlayerSettings.iOS.simulatorSdkArchitecture = _value.Read<global::UnityEditor.AppleMobileArchitectureSimulator>();  return true;
                case "statusBarStyle": global::UnityEditor.PlayerSettings.iOS.statusBarStyle = _value.Read<global::UnityEditor.iOSStatusBarStyle>();  return true;
                case "targetDevice": global::UnityEditor.PlayerSettings.iOS.targetDevice = _value.Read<global::UnityEditor.iOSTargetDevice>();  return true;
                case "targetOSVersionString": global::UnityEditor.PlayerSettings.iOS.targetOSVersionString = _value.Read<global::System.String>();  return true;
                case "tvOSManualProvisioningProfileID": global::UnityEditor.PlayerSettings.iOS.tvOSManualProvisioningProfileID = _value.Read<global::System.String>();  return true;
                case "tvOSManualProvisioningProfileType": global::UnityEditor.PlayerSettings.iOS.tvOSManualProvisioningProfileType = _value.Read<global::UnityEditor.ProvisioningProfileType>();  return true;
                case "useOnDemandResources": global::UnityEditor.PlayerSettings.iOS.useOnDemandResources = _value.Read<global::System.Boolean>();  return true;
                case "VisionOSManualProvisioningProfileID": global::UnityEditor.PlayerSettings.iOS.VisionOSManualProvisioningProfileID = _value.Read<global::System.String>();  return true;
                case "VisionOSManualProvisioningProfileType": global::UnityEditor.PlayerSettings.iOS.VisionOSManualProvisioningProfileType = _value.Read<global::UnityEditor.ProvisioningProfileType>();  return true;
                default: return false;
            }
        }
    }
}
#pragma warning restore 0109, 0162, 0168, 0219
#endif
