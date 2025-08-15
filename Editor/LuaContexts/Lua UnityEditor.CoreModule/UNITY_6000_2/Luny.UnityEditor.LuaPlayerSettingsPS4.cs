
// --------------------------------------------------------------
// GENERATED FILE ----> DO NOT EDIT <---- CHANGES WILL BE LOST !!
// --------------------------------------------------------------

#if UNITY_6000_2_OR_NEWER && !(UNITY_6000_3_OR_NEWER)
#pragma warning disable 0109, 0162, 0168, 0219
using Luny;

namespace Luny.UnityEditor
{
    public sealed class LuaPlayerSettingsPS4 : global::Luny.ILuaObject<global::UnityEditor.PlayerSettings.PS4>
    {
        public new static global::Lua.LuaValue Bind(global::UnityEditor.PlayerSettings.PS4 instance) => new LuaPlayerSettingsPS4(instance);
        public new static global::Lua.LuaValue Bind(global::System.Object instance) => Bind((global::UnityEditor.PlayerSettings.PS4)instance);
        public new static global::Lua.LuaValue Bind(global::System.Collections.Generic.IList<global::UnityEditor.PlayerSettings.PS4> instances) =>
            new global::Luny.LuaList<global::UnityEditor.PlayerSettings.PS4>(instances);
        public new static global::Lua.LuaValue Bind(global::System.Collections.Generic.IList<global::System.Object> instances) =>
            new global::Luny.LuaList<global::UnityEditor.PlayerSettings.PS4>(instances);
        private LuaPlayerSettingsPS4(global::UnityEditor.PlayerSettings.PS4 instance) => m_Instance = instance;
        public static implicit operator global::Lua.LuaValue(LuaPlayerSettingsPS4 value) => new(value);
        private global::UnityEditor.PlayerSettings.PS4 m_Instance;
        public global::UnityEditor.PlayerSettings.PS4 Instance => m_Instance;
        public new global::System.Type BindType => typeof(global::UnityEditor.PlayerSettings.PS4);
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
            var _this = _context.GetArgument<LuaPlayerSettingsPS4>(0);
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
            var _this = _context.GetArgument<LuaPlayerSettingsPS4>(0);
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
    public sealed class LuaPlayerSettingsPS4Type : global::Luny.ILuaStatic
    {
        public static global::Lua.LuaValue Bind() => new LuaPlayerSettingsPS4Type();
        private LuaPlayerSettingsPS4Type() {}
        public static implicit operator global::Lua.LuaValue(LuaPlayerSettingsPS4Type value) => new(value);
        public global::System.Type BindType => typeof(global::UnityEditor.PlayerSettings.PS4);
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
            metatable[global::Lua.Runtime.Metamethods.Call] = _LuaPlayerSettingsPS4_new;
            return metatable;
        }
        public override global::System.String ToString() => BindType.FullName;
#if UNITY_EDITOR
        [global::UnityEngine.RuntimeInitializeOnLoadMethod(global::UnityEngine.RuntimeInitializeLoadType.SubsystemRegistration)]
        private static void ResetStaticFields() => s_Metatable = null;
#endif

        private static readonly global::Lua.LuaFunction _LuaPlayerSettingsPS4_new = new global::Lua.LuaFunction(".ctor", (_context, _) =>
        {
            global::Lua.LuaValue _lastArg = default;
            global::System.Int32 _lastArgPos = default;
            global::System.Type _expectedType = default;
            var _argCount = _context.ArgumentCount;
            if (_argCount == 1)
            {
                var _ret0 = new global::UnityEditor.PlayerSettings.PS4();
                var _factory = _context.GetObjectFactory();
                var _lret0 = _factory.Bind(_ret0);
                var _retCount = _context.Return(_lret0);
                return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
            }
            throw new global::Lua.LuaRuntimeException(_context.Thread, $"{".ctor"}: invalid argument #{_lastArgPos}: {_lastArg} ({_lastArg.Type}), expected: {_expectedType.FullName}", 2);
        });
        private static readonly global::Lua.LuaFunction __index = new(global::Lua.Runtime.Metamethods.Index, (_context, _) =>
        {
            var _this = _context.GetArgument<LuaPlayerSettingsPS4Type>(0);
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
            var _this = _context.GetArgument<LuaPlayerSettingsPS4Type>(0);
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
                case "allowPS5Detection": _value = new global::Lua.LuaValue(global::UnityEditor.PlayerSettings.PS4.allowPS5Detection); return true;
                case "applicationParameter1": _value = new global::Lua.LuaValue(global::UnityEditor.PlayerSettings.PS4.applicationParameter1); return true;
                case "applicationParameter2": _value = new global::Lua.LuaValue(global::UnityEditor.PlayerSettings.PS4.applicationParameter2); return true;
                case "applicationParameter3": _value = new global::Lua.LuaValue(global::UnityEditor.PlayerSettings.PS4.applicationParameter3); return true;
                case "applicationParameter4": _value = new global::Lua.LuaValue(global::UnityEditor.PlayerSettings.PS4.applicationParameter4); return true;
                case "appType": _value = new global::Lua.LuaValue(global::UnityEditor.PlayerSettings.PS4.appType); return true;
                case "appVersion": _value = new global::Lua.LuaValue(global::UnityEditor.PlayerSettings.PS4.appVersion); return true;
                case "attrib3DSupport": _value = new global::Lua.LuaValue(global::UnityEditor.PlayerSettings.PS4.attrib3DSupport); return true;
                case "attribCpuUsage": _value = new global::Lua.LuaValue(global::UnityEditor.PlayerSettings.PS4.attribCpuUsage); return true;
                case "attribExclusiveVR": _value = new global::Lua.LuaValue(global::UnityEditor.PlayerSettings.PS4.attribExclusiveVR); return true;
                case "attribEyeToEyeDistanceSettingVR": _value = new global::Lua.LuaValue((global::System.Int64)global::UnityEditor.PlayerSettings.PS4.attribEyeToEyeDistanceSettingVR); return true;
                case "attribMoveSupport": _value = new global::Lua.LuaValue(global::UnityEditor.PlayerSettings.PS4.attribMoveSupport); return true;
                case "attribShareSupport": _value = new global::Lua.LuaValue(global::UnityEditor.PlayerSettings.PS4.attribShareSupport); return true;
                case "attribUserManagement": _value = new global::Lua.LuaValue(global::UnityEditor.PlayerSettings.PS4.attribUserManagement); return true;
                case "attribVROutputEnabled": _value = new global::Lua.LuaValue(global::UnityEditor.PlayerSettings.PS4.attribVROutputEnabled); return true;
                case "audio3dVirtualSpeakerCount": _value = new global::Lua.LuaValue(global::UnityEditor.PlayerSettings.PS4.audio3dVirtualSpeakerCount); return true;
                case "BackgroundImagePath": _value = new global::Lua.LuaValue(global::UnityEditor.PlayerSettings.PS4.BackgroundImagePath); return true;
                case "BGMPath": _value = new global::Lua.LuaValue(global::UnityEditor.PlayerSettings.PS4.BGMPath); return true;
                case "category": _value = new global::Lua.LuaValue((global::System.Int64)global::UnityEditor.PlayerSettings.PS4.category); return true;
                case "compatibilityPS5": _value = new global::Lua.LuaValue(global::UnityEditor.PlayerSettings.PS4.compatibilityPS5); return true;
                case "contentID": _value = new global::Lua.LuaValue(global::UnityEditor.PlayerSettings.PS4.contentID); return true;
                case "contentSearchFeaturesUsed": _value = new global::Lua.LuaValue(global::UnityEditor.PlayerSettings.PS4.contentSearchFeaturesUsed); return true;
                case "disableAutoHideSplash": _value = new global::Lua.LuaValue(global::UnityEditor.PlayerSettings.PS4.disableAutoHideSplash); return true;
                case "downloadDataSize": _value = new global::Lua.LuaValue(global::UnityEditor.PlayerSettings.PS4.downloadDataSize); return true;
                case "enableApplicationExit": _value = new global::Lua.LuaValue(global::UnityEditor.PlayerSettings.PS4.enableApplicationExit); return true;
                case "enterButtonAssignment": _value = new global::Lua.LuaValue((global::System.Int64)global::UnityEditor.PlayerSettings.PS4.enterButtonAssignment); return true;
                case "ExtraSceSysFile": _value = new global::Lua.LuaValue(global::UnityEditor.PlayerSettings.PS4.ExtraSceSysFile); return true;
                case "garlicHeapSize": _value = new global::Lua.LuaValue(global::UnityEditor.PlayerSettings.PS4.garlicHeapSize); return true;
                case "gpu800MHz": _value = new global::Lua.LuaValue(global::UnityEditor.PlayerSettings.PS4.gpu800MHz); return true;
                case "iconImagesFolder": _value = new global::Lua.LuaValue(global::UnityEditor.PlayerSettings.PS4.iconImagesFolder); return true;
                case "includedModules": _value = _factory.Bind(global::UnityEditor.PlayerSettings.PS4.includedModules); return true;
                case "masterVersion": _value = new global::Lua.LuaValue(global::UnityEditor.PlayerSettings.PS4.masterVersion); return true;
                case "monoEnv": _value = new global::Lua.LuaValue(global::UnityEditor.PlayerSettings.PS4.monoEnv); return true;
                case "npAgeRating": _value = new global::Lua.LuaValue(global::UnityEditor.PlayerSettings.PS4.npAgeRating); return true;
                case "NPtitleDatPath": _value = new global::Lua.LuaValue(global::UnityEditor.PlayerSettings.PS4.NPtitleDatPath); return true;
                case "npTitleSecret": _value = new global::Lua.LuaValue(global::UnityEditor.PlayerSettings.PS4.npTitleSecret); return true;
                case "npTrophyPackPath": _value = new global::Lua.LuaValue(global::UnityEditor.PlayerSettings.PS4.npTrophyPackPath); return true;
                case "paramSfxPath": _value = new global::Lua.LuaValue(global::UnityEditor.PlayerSettings.PS4.paramSfxPath); return true;
                case "parentalLevel": _value = new global::Lua.LuaValue(global::UnityEditor.PlayerSettings.PS4.parentalLevel); return true;
                case "passcode": _value = new global::Lua.LuaValue(global::UnityEditor.PlayerSettings.PS4.passcode); return true;
                case "PatchChangeinfoPath": _value = new global::Lua.LuaValue(global::UnityEditor.PlayerSettings.PS4.PatchChangeinfoPath); return true;
                case "patchDayOne": _value = new global::Lua.LuaValue(global::UnityEditor.PlayerSettings.PS4.patchDayOne); return true;
                case "PatchLatestPkgPath": _value = new global::Lua.LuaValue(global::UnityEditor.PlayerSettings.PS4.PatchLatestPkgPath); return true;
                case "PatchPkgPath": _value = new global::Lua.LuaValue(global::UnityEditor.PlayerSettings.PS4.PatchPkgPath); return true;
                case "playerPrefsMaxSize": _value = new global::Lua.LuaValue(global::UnityEditor.PlayerSettings.PS4.playerPrefsMaxSize); return true;
                case "playerPrefsSupport": _value = new global::Lua.LuaValue(global::UnityEditor.PlayerSettings.PS4.playerPrefsSupport); return true;
                case "playTogetherPlayerCount": _value = new global::Lua.LuaValue(global::UnityEditor.PlayerSettings.PS4.playTogetherPlayerCount); return true;
                case "pnFriends": _value = new global::Lua.LuaValue(global::UnityEditor.PlayerSettings.PS4.pnFriends); return true;
                case "pnGameCustomData": _value = new global::Lua.LuaValue(global::UnityEditor.PlayerSettings.PS4.pnGameCustomData); return true;
                case "pnPresence": _value = new global::Lua.LuaValue(global::UnityEditor.PlayerSettings.PS4.pnPresence); return true;
                case "pnSessions": _value = new global::Lua.LuaValue(global::UnityEditor.PlayerSettings.PS4.pnSessions); return true;
                case "PrivacyGuardImagePath": _value = new global::Lua.LuaValue(global::UnityEditor.PlayerSettings.PS4.PrivacyGuardImagePath); return true;
                case "proGarlicHeapSize": _value = new global::Lua.LuaValue(global::UnityEditor.PlayerSettings.PS4.proGarlicHeapSize); return true;
                case "PronunciationSIGPath": _value = new global::Lua.LuaValue(global::UnityEditor.PlayerSettings.PS4.PronunciationSIGPath); return true;
                case "PronunciationXMLPath": _value = new global::Lua.LuaValue(global::UnityEditor.PlayerSettings.PS4.PronunciationXMLPath); return true;
                case "remotePlayKeyAssignment": _value = new global::Lua.LuaValue((global::System.Int64)global::UnityEditor.PlayerSettings.PS4.remotePlayKeyAssignment); return true;
                case "remotePlayKeyMappingDir": _value = new global::Lua.LuaValue(global::UnityEditor.PlayerSettings.PS4.remotePlayKeyMappingDir); return true;
                case "reprojectionSupport": _value = new global::Lua.LuaValue(global::UnityEditor.PlayerSettings.PS4.reprojectionSupport); return true;
                case "resetTempFolder": _value = new global::Lua.LuaValue(global::UnityEditor.PlayerSettings.PS4.resetTempFolder); return true;
                case "restrictedAudioUsageRights": _value = new global::Lua.LuaValue(global::UnityEditor.PlayerSettings.PS4.restrictedAudioUsageRights); return true;
                case "SaveDataImagePath": _value = new global::Lua.LuaValue(global::UnityEditor.PlayerSettings.PS4.SaveDataImagePath); return true;
                case "SdkOverride": _value = new global::Lua.LuaValue(global::UnityEditor.PlayerSettings.PS4.SdkOverride); return true;
                case "ShareFilePath": _value = new global::Lua.LuaValue(global::UnityEditor.PlayerSettings.PS4.ShareFilePath); return true;
                case "ShareOverlayImagePath": _value = new global::Lua.LuaValue(global::UnityEditor.PlayerSettings.PS4.ShareOverlayImagePath); return true;
                case "socialScreenEnabled": _value = new global::Lua.LuaValue(global::UnityEditor.PlayerSettings.PS4.socialScreenEnabled); return true;
                case "StartupImagePath": _value = new global::Lua.LuaValue(global::UnityEditor.PlayerSettings.PS4.StartupImagePath); return true;
                case "startupImagesFolder": _value = new global::Lua.LuaValue(global::UnityEditor.PlayerSettings.PS4.startupImagesFolder); return true;
                case "useAudio3dBackend": _value = new global::Lua.LuaValue(global::UnityEditor.PlayerSettings.PS4.useAudio3dBackend); return true;
                case "useLowGarlicFragmentationMode": _value = new global::Lua.LuaValue(global::UnityEditor.PlayerSettings.PS4.useLowGarlicFragmentationMode); return true;
                case "useResolutionFallback": _value = new global::Lua.LuaValue(global::UnityEditor.PlayerSettings.PS4.useResolutionFallback); return true;
                case "videoOutBaseModeInitialWidth": _value = new global::Lua.LuaValue(global::UnityEditor.PlayerSettings.PS4.videoOutBaseModeInitialWidth); return true;
                case "videoOutInitialWidth": _value = new global::Lua.LuaValue(global::UnityEditor.PlayerSettings.PS4.videoOutInitialWidth); return true;
                case "videoOutPixelFormat": _value = new global::Lua.LuaValue(global::UnityEditor.PlayerSettings.PS4.videoOutPixelFormat); return true;
                case "videoOutReprojectionRate": _value = new global::Lua.LuaValue(global::UnityEditor.PlayerSettings.PS4.videoOutReprojectionRate); return true;
                case "videoRecordingFeaturesUsed": _value = new global::Lua.LuaValue(global::UnityEditor.PlayerSettings.PS4.videoRecordingFeaturesUsed); return true;
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
                case "allowPS5Detection": global::UnityEditor.PlayerSettings.PS4.allowPS5Detection = _value.Read<global::System.Boolean>();  return true;
                case "applicationParameter1": global::UnityEditor.PlayerSettings.PS4.applicationParameter1 = _value.Read<global::System.Int32>();  return true;
                case "applicationParameter2": global::UnityEditor.PlayerSettings.PS4.applicationParameter2 = _value.Read<global::System.Int32>();  return true;
                case "applicationParameter3": global::UnityEditor.PlayerSettings.PS4.applicationParameter3 = _value.Read<global::System.Int32>();  return true;
                case "applicationParameter4": global::UnityEditor.PlayerSettings.PS4.applicationParameter4 = _value.Read<global::System.Int32>();  return true;
                case "appType": global::UnityEditor.PlayerSettings.PS4.appType = _value.Read<global::System.Int32>();  return true;
                case "appVersion": global::UnityEditor.PlayerSettings.PS4.appVersion = _value.Read<global::System.String>();  return true;
                case "attrib3DSupport": global::UnityEditor.PlayerSettings.PS4.attrib3DSupport = _value.Read<global::System.Boolean>();  return true;
                case "attribCpuUsage": global::UnityEditor.PlayerSettings.PS4.attribCpuUsage = _value.Read<global::System.Int32>();  return true;
                case "attribExclusiveVR": global::UnityEditor.PlayerSettings.PS4.attribExclusiveVR = _value.Read<global::System.Boolean>();  return true;
                case "attribEyeToEyeDistanceSettingVR": global::UnityEditor.PlayerSettings.PS4.attribEyeToEyeDistanceSettingVR = _value.Read<global::UnityEditor.PlayerSettings.PS4.PlayStationVREyeToEyeDistanceSettings>();  return true;
                case "attribMoveSupport": global::UnityEditor.PlayerSettings.PS4.attribMoveSupport = _value.Read<global::System.Boolean>();  return true;
                case "attribShareSupport": global::UnityEditor.PlayerSettings.PS4.attribShareSupport = _value.Read<global::System.Boolean>();  return true;
                case "attribUserManagement": global::UnityEditor.PlayerSettings.PS4.attribUserManagement = _value.Read<global::System.Boolean>();  return true;
                case "attribVROutputEnabled": global::UnityEditor.PlayerSettings.PS4.attribVROutputEnabled = _value.Read<global::System.Boolean>();  return true;
                case "audio3dVirtualSpeakerCount": global::UnityEditor.PlayerSettings.PS4.audio3dVirtualSpeakerCount = _value.Read<global::System.Int32>();  return true;
                case "BackgroundImagePath": global::UnityEditor.PlayerSettings.PS4.BackgroundImagePath = _value.Read<global::System.String>();  return true;
                case "BGMPath": global::UnityEditor.PlayerSettings.PS4.BGMPath = _value.Read<global::System.String>();  return true;
                case "category": global::UnityEditor.PlayerSettings.PS4.category = _value.Read<global::UnityEditor.PlayerSettings.PS4.PS4AppCategory>();  return true;
                case "compatibilityPS5": global::UnityEditor.PlayerSettings.PS4.compatibilityPS5 = _value.Read<global::System.Boolean>();  return true;
                case "contentID": global::UnityEditor.PlayerSettings.PS4.contentID = _value.Read<global::System.String>();  return true;
                case "contentSearchFeaturesUsed": global::UnityEditor.PlayerSettings.PS4.contentSearchFeaturesUsed = _value.Read<global::System.Boolean>();  return true;
                case "disableAutoHideSplash": global::UnityEditor.PlayerSettings.PS4.disableAutoHideSplash = _value.Read<global::System.Boolean>();  return true;
                case "downloadDataSize": global::UnityEditor.PlayerSettings.PS4.downloadDataSize = _value.Read<global::System.Int32>();  return true;
                case "enableApplicationExit": global::UnityEditor.PlayerSettings.PS4.enableApplicationExit = _value.Read<global::System.Boolean>();  return true;
                case "enterButtonAssignment": global::UnityEditor.PlayerSettings.PS4.enterButtonAssignment = _value.Read<global::UnityEditor.PlayerSettings.PS4.PS4EnterButtonAssignment>();  return true;
                case "ExtraSceSysFile": global::UnityEditor.PlayerSettings.PS4.ExtraSceSysFile = _value.Read<global::System.String>();  return true;
                case "garlicHeapSize": global::UnityEditor.PlayerSettings.PS4.garlicHeapSize = _value.Read<global::System.Int32>();  return true;
                case "gpu800MHz": global::UnityEditor.PlayerSettings.PS4.gpu800MHz = _value.Read<global::System.Boolean>();  return true;
                case "iconImagesFolder": global::UnityEditor.PlayerSettings.PS4.iconImagesFolder = _value.Read<global::System.String>();  return true;
                case "includedModules": global::UnityEditor.PlayerSettings.PS4.includedModules = _value.Read<global::System.String[]>();  return true;
                case "masterVersion": global::UnityEditor.PlayerSettings.PS4.masterVersion = _value.Read<global::System.String>();  return true;
                case "monoEnv": global::UnityEditor.PlayerSettings.PS4.monoEnv = _value.Read<global::System.String>();  return true;
                case "npAgeRating": global::UnityEditor.PlayerSettings.PS4.npAgeRating = _value.Read<global::System.Int32>();  return true;
                case "NPtitleDatPath": global::UnityEditor.PlayerSettings.PS4.NPtitleDatPath = _value.Read<global::System.String>();  return true;
                case "npTitleSecret": global::UnityEditor.PlayerSettings.PS4.npTitleSecret = _value.Read<global::System.String>();  return true;
                case "npTrophyPackPath": global::UnityEditor.PlayerSettings.PS4.npTrophyPackPath = _value.Read<global::System.String>();  return true;
                case "paramSfxPath": global::UnityEditor.PlayerSettings.PS4.paramSfxPath = _value.Read<global::System.String>();  return true;
                case "parentalLevel": global::UnityEditor.PlayerSettings.PS4.parentalLevel = _value.Read<global::System.Int32>();  return true;
                case "passcode": global::UnityEditor.PlayerSettings.PS4.passcode = _value.Read<global::System.String>();  return true;
                case "PatchChangeinfoPath": global::UnityEditor.PlayerSettings.PS4.PatchChangeinfoPath = _value.Read<global::System.String>();  return true;
                case "patchDayOne": global::UnityEditor.PlayerSettings.PS4.patchDayOne = _value.Read<global::System.Boolean>();  return true;
                case "PatchLatestPkgPath": global::UnityEditor.PlayerSettings.PS4.PatchLatestPkgPath = _value.Read<global::System.String>();  return true;
                case "PatchPkgPath": global::UnityEditor.PlayerSettings.PS4.PatchPkgPath = _value.Read<global::System.String>();  return true;
                case "playerPrefsMaxSize": global::UnityEditor.PlayerSettings.PS4.playerPrefsMaxSize = _value.Read<global::System.Int32>();  return true;
                case "playerPrefsSupport": global::UnityEditor.PlayerSettings.PS4.playerPrefsSupport = _value.Read<global::System.Boolean>();  return true;
                case "playTogetherPlayerCount": global::UnityEditor.PlayerSettings.PS4.playTogetherPlayerCount = _value.Read<global::System.Int32>();  return true;
                case "pnFriends": global::UnityEditor.PlayerSettings.PS4.pnFriends = _value.Read<global::System.Boolean>();  return true;
                case "pnGameCustomData": global::UnityEditor.PlayerSettings.PS4.pnGameCustomData = _value.Read<global::System.Boolean>();  return true;
                case "pnPresence": global::UnityEditor.PlayerSettings.PS4.pnPresence = _value.Read<global::System.Boolean>();  return true;
                case "pnSessions": global::UnityEditor.PlayerSettings.PS4.pnSessions = _value.Read<global::System.Boolean>();  return true;
                case "PrivacyGuardImagePath": global::UnityEditor.PlayerSettings.PS4.PrivacyGuardImagePath = _value.Read<global::System.String>();  return true;
                case "proGarlicHeapSize": global::UnityEditor.PlayerSettings.PS4.proGarlicHeapSize = _value.Read<global::System.Int32>();  return true;
                case "PronunciationSIGPath": global::UnityEditor.PlayerSettings.PS4.PronunciationSIGPath = _value.Read<global::System.String>();  return true;
                case "PronunciationXMLPath": global::UnityEditor.PlayerSettings.PS4.PronunciationXMLPath = _value.Read<global::System.String>();  return true;
                case "remotePlayKeyAssignment": global::UnityEditor.PlayerSettings.PS4.remotePlayKeyAssignment = _value.Read<global::UnityEditor.PlayerSettings.PS4.PS4RemotePlayKeyAssignment>();  return true;
                case "remotePlayKeyMappingDir": global::UnityEditor.PlayerSettings.PS4.remotePlayKeyMappingDir = _value.Read<global::System.String>();  return true;
                case "reprojectionSupport": global::UnityEditor.PlayerSettings.PS4.reprojectionSupport = _value.Read<global::System.Boolean>();  return true;
                case "resetTempFolder": global::UnityEditor.PlayerSettings.PS4.resetTempFolder = _value.Read<global::System.Boolean>();  return true;
                case "restrictedAudioUsageRights": global::UnityEditor.PlayerSettings.PS4.restrictedAudioUsageRights = _value.Read<global::System.Boolean>();  return true;
                case "SaveDataImagePath": global::UnityEditor.PlayerSettings.PS4.SaveDataImagePath = _value.Read<global::System.String>();  return true;
                case "SdkOverride": global::UnityEditor.PlayerSettings.PS4.SdkOverride = _value.Read<global::System.String>();  return true;
                case "ShareFilePath": global::UnityEditor.PlayerSettings.PS4.ShareFilePath = _value.Read<global::System.String>();  return true;
                case "ShareOverlayImagePath": global::UnityEditor.PlayerSettings.PS4.ShareOverlayImagePath = _value.Read<global::System.String>();  return true;
                case "socialScreenEnabled": global::UnityEditor.PlayerSettings.PS4.socialScreenEnabled = _value.Read<global::System.Int32>();  return true;
                case "StartupImagePath": global::UnityEditor.PlayerSettings.PS4.StartupImagePath = _value.Read<global::System.String>();  return true;
                case "startupImagesFolder": global::UnityEditor.PlayerSettings.PS4.startupImagesFolder = _value.Read<global::System.String>();  return true;
                case "useAudio3dBackend": global::UnityEditor.PlayerSettings.PS4.useAudio3dBackend = _value.Read<global::System.Boolean>();  return true;
                case "useLowGarlicFragmentationMode": global::UnityEditor.PlayerSettings.PS4.useLowGarlicFragmentationMode = _value.Read<global::System.Boolean>();  return true;
                case "useResolutionFallback": global::UnityEditor.PlayerSettings.PS4.useResolutionFallback = _value.Read<global::System.Boolean>();  return true;
                case "videoOutBaseModeInitialWidth": global::UnityEditor.PlayerSettings.PS4.videoOutBaseModeInitialWidth = _value.Read<global::System.Int32>();  return true;
                case "videoOutInitialWidth": global::UnityEditor.PlayerSettings.PS4.videoOutInitialWidth = _value.Read<global::System.Int32>();  return true;
                case "videoOutPixelFormat": global::UnityEditor.PlayerSettings.PS4.videoOutPixelFormat = _value.Read<global::System.Int32>();  return true;
                case "videoOutReprojectionRate": global::UnityEditor.PlayerSettings.PS4.videoOutReprojectionRate = _value.Read<global::System.Int32>();  return true;
                case "videoRecordingFeaturesUsed": global::UnityEditor.PlayerSettings.PS4.videoRecordingFeaturesUsed = _value.Read<global::System.Boolean>();  return true;
                default: return false;
            }
        }
    }
}
#pragma warning restore 0109, 0162, 0168, 0219
#endif
