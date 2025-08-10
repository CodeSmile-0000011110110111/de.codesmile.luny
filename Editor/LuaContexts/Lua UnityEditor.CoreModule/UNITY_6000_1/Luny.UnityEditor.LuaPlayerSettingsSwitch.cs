
// --------------------------------------------------------------
// GENERATED FILE ----> DO NOT EDIT <---- CHANGES WILL BE LOST !!
// --------------------------------------------------------------

#if UNITY_6000_1_OR_NEWER && !(UNITY_6000_2_OR_NEWER)
#pragma warning disable 0109, 0162, 0168, 0219
using Luny;

namespace Luny.UnityEditor
{
    public sealed class LuaPlayerSettingsSwitch : global::Luny.ILuaObject<global::UnityEditor.PlayerSettings.Switch>
    {
        public new static global::Lua.LuaValue Bind(global::UnityEditor.PlayerSettings.Switch instance) => new LuaPlayerSettingsSwitch(instance);
        public new static global::Lua.LuaValue Bind(global::System.Object instance) => Bind((global::UnityEditor.PlayerSettings.Switch)instance);
        public new static global::Lua.LuaValue Bind(global::System.Collections.Generic.IList<global::UnityEditor.PlayerSettings.Switch> instances) =>
            new global::Luny.LuaList<global::UnityEditor.PlayerSettings.Switch>(instances);
        public new static global::Lua.LuaValue Bind(global::System.Collections.Generic.IList<global::System.Object> instances) =>
            new global::Luny.LuaList<global::UnityEditor.PlayerSettings.Switch>(instances);
        private LuaPlayerSettingsSwitch(global::UnityEditor.PlayerSettings.Switch instance) => m_Instance = instance;
        public static implicit operator global::Lua.LuaValue(LuaPlayerSettingsSwitch value) => new(value);
        private global::UnityEditor.PlayerSettings.Switch m_Instance;
        public global::UnityEditor.PlayerSettings.Switch Instance => m_Instance;
        public new global::System.Type BindType => typeof(global::UnityEditor.PlayerSettings.Switch);
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

        private static readonly global::Lua.LuaFunction __index = new(global::Lua.Runtime.Metamethods.Index, (_context, _) =>
        {
            var _this = _context.GetArgument<LuaPlayerSettingsSwitch>(0);
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
            var _this = _context.GetArgument<LuaPlayerSettingsSwitch>(0);
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
    public sealed class LuaPlayerSettingsSwitchType : global::Luny.ILuaStatic
    {
        public static global::Lua.LuaValue Bind() => new LuaPlayerSettingsSwitchType();
        private LuaPlayerSettingsSwitchType() {}
        public static implicit operator global::Lua.LuaValue(LuaPlayerSettingsSwitchType value) => new(value);
        public global::System.Type BindType => typeof(global::UnityEditor.PlayerSettings.Switch);
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

        private static readonly global::Lua.LuaFunction _LuaPlayerSettingsSwitch_new = new global::Lua.LuaFunction(".ctor", (_context, _) =>
        {
            global::Lua.LuaValue _lastArg = default;
            global::System.Int32 _lastArgPos = default;
            global::System.Type _expectedType = default;
            var _argCount = _context.ArgumentCount;
            if (_argCount == 0)
            {
                var _ret0 = new global::UnityEditor.PlayerSettings.Switch();
                var _factory = _context.GetObjectFactory();
                var _lret0 = _factory.Bind(_ret0);
                var _retCount = _context.Return(_lret0);
                return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
            }
            throw new global::Lua.LuaRuntimeException(_context.Thread, $"{".ctor"}: invalid argument #{_lastArgPos}: {_lastArg} ({_lastArg.Type}), expected: {_expectedType.FullName}", 2);
        });
        private static readonly global::Lua.LuaFunction __index = new(global::Lua.Runtime.Metamethods.Index, (_context, _) =>
        {
            var _this = _context.GetArgument<LuaPlayerSettingsSwitchType>(0);
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
            var _this = _context.GetArgument<LuaPlayerSettingsSwitchType>(0);
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
                case "new": _value = _LuaPlayerSettingsSwitch_new; return true;
                case "AllowGpuScratchShrinking": _value = new global::Lua.LuaValue(global::UnityEditor.PlayerSettings.Switch.AllowGpuScratchShrinking); return true;
                case "compilerFlags": _value = _factory.Bind(global::UnityEditor.PlayerSettings.Switch.compilerFlags); return true;
                case "defaultSwitchNVNGraphicsFirmwareMemory": _value = new global::Lua.LuaValue(global::UnityEditor.PlayerSettings.Switch.defaultSwitchNVNGraphicsFirmwareMemory); return true;
                case "defaultSwitchQueueCommandMemory": _value = new global::Lua.LuaValue(global::UnityEditor.PlayerSettings.Switch.defaultSwitchQueueCommandMemory); return true;
                case "defaultSwitchQueueComputeMemory": _value = new global::Lua.LuaValue(global::UnityEditor.PlayerSettings.Switch.defaultSwitchQueueComputeMemory); return true;
                case "defaultSwitchQueueControlMemory": _value = new global::Lua.LuaValue(global::UnityEditor.PlayerSettings.Switch.defaultSwitchQueueControlMemory); return true;
                case "disableHTCSPlayerConnection": _value = new global::Lua.LuaValue(global::UnityEditor.PlayerSettings.Switch.disableHTCSPlayerConnection); return true;
                case "enableFileSystemTrace": _value = new global::Lua.LuaValue(global::UnityEditor.PlayerSettings.Switch.enableFileSystemTrace); return true;
                case "enableTouchScreen": _value = new global::Lua.LuaValue(global::UnityEditor.PlayerSettings.Switch.enableTouchScreen); return true;
                case "GpuScratchPoolGranularity": _value = new global::Lua.LuaValue(global::UnityEditor.PlayerSettings.Switch.GpuScratchPoolGranularity); return true;
                case "isHoldTypeHorizontal": _value = new global::Lua.LuaValue(global::UnityEditor.PlayerSettings.Switch.isHoldTypeHorizontal); return true;
                case "maximumSwitchNVNGraphicsFirmwareMemory": _value = new global::Lua.LuaValue(global::UnityEditor.PlayerSettings.Switch.maximumSwitchNVNGraphicsFirmwareMemory); return true;
                case "minimumSwitchNVNGraphicsFirmwareMemory": _value = new global::Lua.LuaValue(global::UnityEditor.PlayerSettings.Switch.minimumSwitchNVNGraphicsFirmwareMemory); return true;
                case "minimumSwitchQueueCommandMemory": _value = new global::Lua.LuaValue(global::UnityEditor.PlayerSettings.Switch.minimumSwitchQueueCommandMemory); return true;
                case "minimumSwitchQueueControlMemory": _value = new global::Lua.LuaValue(global::UnityEditor.PlayerSettings.Switch.minimumSwitchQueueControlMemory); return true;
                case "nativeFsCacheSize": _value = new global::Lua.LuaValue(global::UnityEditor.PlayerSettings.Switch.nativeFsCacheSize); return true;
                case "networkInterfaceManagerInitializeEnabled": _value = new global::Lua.LuaValue(global::UnityEditor.PlayerSettings.Switch.networkInterfaceManagerInitializeEnabled); return true;
                case "NMETAOverride": _value = new global::Lua.LuaValue(global::UnityEditor.PlayerSettings.Switch.NMETAOverride); return true;
                case "NMETAOverrideFullPath": _value = new global::Lua.LuaValue(global::UnityEditor.PlayerSettings.Switch.NMETAOverrideFullPath); return true;
                case "nsoDependencies": _value = new global::Lua.LuaValue(global::UnityEditor.PlayerSettings.Switch.nsoDependencies); return true;
                case "NVNDefaultPoolsGranularity": _value = new global::Lua.LuaValue(global::UnityEditor.PlayerSettings.Switch.NVNDefaultPoolsGranularity); return true;
                case "NVNGraphicsFirmwareMemory": _value = new global::Lua.LuaValue(global::UnityEditor.PlayerSettings.Switch.NVNGraphicsFirmwareMemory); return true;
                case "NVNMaxPublicSamplerIDCount": _value = new global::Lua.LuaValue(global::UnityEditor.PlayerSettings.Switch.NVNMaxPublicSamplerIDCount); return true;
                case "NVNMaxPublicTextureIDCount": _value = new global::Lua.LuaValue(global::UnityEditor.PlayerSettings.Switch.NVNMaxPublicTextureIDCount); return true;
                case "NVNOtherPoolsGranularity": _value = new global::Lua.LuaValue(global::UnityEditor.PlayerSettings.Switch.NVNOtherPoolsGranularity); return true;
                case "NVNShaderPoolsGranularity": _value = new global::Lua.LuaValue(global::UnityEditor.PlayerSettings.Switch.NVNShaderPoolsGranularity); return true;
                case "queueCommandMemory": _value = new global::Lua.LuaValue(global::UnityEditor.PlayerSettings.Switch.queueCommandMemory); return true;
                case "queueComputeMemory": _value = new global::Lua.LuaValue(global::UnityEditor.PlayerSettings.Switch.queueComputeMemory); return true;
                case "queueControlMemory": _value = new global::Lua.LuaValue(global::UnityEditor.PlayerSettings.Switch.queueControlMemory); return true;
                case "screenResolutionBehavior": _value = new global::Lua.LuaValue((global::System.Int64)global::UnityEditor.PlayerSettings.Switch.screenResolutionBehavior); return true;
                case "socketAllocatorPoolSize": _value = new global::Lua.LuaValue(global::UnityEditor.PlayerSettings.Switch.socketAllocatorPoolSize); return true;
                case "socketBufferEfficiency": _value = new global::Lua.LuaValue(global::UnityEditor.PlayerSettings.Switch.socketBufferEfficiency); return true;
                case "socketConcurrencyLimit": _value = new global::Lua.LuaValue(global::UnityEditor.PlayerSettings.Switch.socketConcurrencyLimit); return true;
                case "socketConfigEnabled": _value = new global::Lua.LuaValue(global::UnityEditor.PlayerSettings.Switch.socketConfigEnabled); return true;
                case "socketInitializeEnabled": _value = new global::Lua.LuaValue(global::UnityEditor.PlayerSettings.Switch.socketInitializeEnabled); return true;
                case "socketMemoryPoolSize": _value = new global::Lua.LuaValue(global::UnityEditor.PlayerSettings.Switch.socketMemoryPoolSize); return true;
                case "supportedNpadCount": _value = new global::Lua.LuaValue(global::UnityEditor.PlayerSettings.Switch.supportedNpadCount); return true;
                case "supportedNpadStyles": _value = new global::Lua.LuaValue((global::System.Int64)global::UnityEditor.PlayerSettings.Switch.supportedNpadStyles); return true;
                case "switchEnableRamDiskSupport": _value = new global::Lua.LuaValue(global::UnityEditor.PlayerSettings.Switch.switchEnableRamDiskSupport); return true;
                case "switchLTOSetting": _value = new global::Lua.LuaValue(global::UnityEditor.PlayerSettings.Switch.switchLTOSetting); return true;
                case "switchMaxWorkerMultiple": _value = new global::Lua.LuaValue(global::UnityEditor.PlayerSettings.Switch.switchMaxWorkerMultiple); return true;
                case "switchMicroSleepForYieldTime": _value = new global::Lua.LuaValue(global::UnityEditor.PlayerSettings.Switch.switchMicroSleepForYieldTime); return true;
                case "switchRamDiskSpaceSize": _value = new global::Lua.LuaValue(global::UnityEditor.PlayerSettings.Switch.switchRamDiskSpaceSize); return true;
                case "switchUseLegacyFmodPriorities": _value = new global::Lua.LuaValue(global::UnityEditor.PlayerSettings.Switch.switchUseLegacyFmodPriorities); return true;
                case "switchUseMicroSleepForYield": _value = new global::Lua.LuaValue(global::UnityEditor.PlayerSettings.Switch.switchUseMicroSleepForYield); return true;
                case "tcpAutoReceiveBufferSizeMax": _value = new global::Lua.LuaValue(global::UnityEditor.PlayerSettings.Switch.tcpAutoReceiveBufferSizeMax); return true;
                case "tcpAutoSendBufferSizeMax": _value = new global::Lua.LuaValue(global::UnityEditor.PlayerSettings.Switch.tcpAutoSendBufferSizeMax); return true;
                case "tcpInitialReceiveBufferSize": _value = new global::Lua.LuaValue(global::UnityEditor.PlayerSettings.Switch.tcpInitialReceiveBufferSize); return true;
                case "tcpInitialSendBufferSize": _value = new global::Lua.LuaValue(global::UnityEditor.PlayerSettings.Switch.tcpInitialSendBufferSize); return true;
                case "udpReceiveBufferSize": _value = new global::Lua.LuaValue(global::UnityEditor.PlayerSettings.Switch.udpReceiveBufferSize); return true;
                case "udpSendBufferSize": _value = new global::Lua.LuaValue(global::UnityEditor.PlayerSettings.Switch.udpSendBufferSize); return true;
                case "useSwitchCPUProfiler": _value = new global::Lua.LuaValue(global::UnityEditor.PlayerSettings.Switch.useSwitchCPUProfiler); return true;
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
                case "AllowGpuScratchShrinking": global::UnityEditor.PlayerSettings.Switch.AllowGpuScratchShrinking = _value.Read<global::System.Boolean>();  return true;
                case "compilerFlags": global::UnityEditor.PlayerSettings.Switch.compilerFlags = _value.Read<global::System.String[]>();  return true;
                case "disableHTCSPlayerConnection": global::UnityEditor.PlayerSettings.Switch.disableHTCSPlayerConnection = _value.Read<global::System.Boolean>();  return true;
                case "enableFileSystemTrace": global::UnityEditor.PlayerSettings.Switch.enableFileSystemTrace = _value.Read<global::System.Boolean>();  return true;
                case "enableTouchScreen": global::UnityEditor.PlayerSettings.Switch.enableTouchScreen = _value.Read<global::System.Boolean>();  return true;
                case "GpuScratchPoolGranularity": global::UnityEditor.PlayerSettings.Switch.GpuScratchPoolGranularity = _value.Read<global::System.Int32>();  return true;
                case "isHoldTypeHorizontal": global::UnityEditor.PlayerSettings.Switch.isHoldTypeHorizontal = _value.Read<global::System.Boolean>();  return true;
                case "nativeFsCacheSize": global::UnityEditor.PlayerSettings.Switch.nativeFsCacheSize = _value.Read<global::System.Int32>();  return true;
                case "networkInterfaceManagerInitializeEnabled": global::UnityEditor.PlayerSettings.Switch.networkInterfaceManagerInitializeEnabled = _value.Read<global::System.Boolean>();  return true;
                case "NMETAOverride": global::UnityEditor.PlayerSettings.Switch.NMETAOverride = _value.Read<global::System.String>();  return true;
                case "nsoDependencies": global::UnityEditor.PlayerSettings.Switch.nsoDependencies = _value.Read<global::System.String>();  return true;
                case "NVNDefaultPoolsGranularity": global::UnityEditor.PlayerSettings.Switch.NVNDefaultPoolsGranularity = _value.Read<global::System.Int32>();  return true;
                case "NVNGraphicsFirmwareMemory": global::UnityEditor.PlayerSettings.Switch.NVNGraphicsFirmwareMemory = _value.Read<global::System.Int32>();  return true;
                case "NVNMaxPublicSamplerIDCount": global::UnityEditor.PlayerSettings.Switch.NVNMaxPublicSamplerIDCount = _value.Read<global::System.Int32>();  return true;
                case "NVNMaxPublicTextureIDCount": global::UnityEditor.PlayerSettings.Switch.NVNMaxPublicTextureIDCount = _value.Read<global::System.Int32>();  return true;
                case "NVNOtherPoolsGranularity": global::UnityEditor.PlayerSettings.Switch.NVNOtherPoolsGranularity = _value.Read<global::System.Int32>();  return true;
                case "NVNShaderPoolsGranularity": global::UnityEditor.PlayerSettings.Switch.NVNShaderPoolsGranularity = _value.Read<global::System.Int32>();  return true;
                case "queueCommandMemory": global::UnityEditor.PlayerSettings.Switch.queueCommandMemory = _value.Read<global::System.Int32>();  return true;
                case "queueComputeMemory": global::UnityEditor.PlayerSettings.Switch.queueComputeMemory = _value.Read<global::System.Int32>();  return true;
                case "queueControlMemory": global::UnityEditor.PlayerSettings.Switch.queueControlMemory = _value.Read<global::System.Int32>();  return true;
                case "screenResolutionBehavior": global::UnityEditor.PlayerSettings.Switch.screenResolutionBehavior = _value.Read<global::UnityEditor.PlayerSettings.Switch.ScreenResolutionBehavior>();  return true;
                case "socketAllocatorPoolSize": global::UnityEditor.PlayerSettings.Switch.socketAllocatorPoolSize = _value.Read<global::System.Int32>();  return true;
                case "socketBufferEfficiency": global::UnityEditor.PlayerSettings.Switch.socketBufferEfficiency = _value.Read<global::System.Int32>();  return true;
                case "socketConcurrencyLimit": global::UnityEditor.PlayerSettings.Switch.socketConcurrencyLimit = _value.Read<global::System.Int32>();  return true;
                case "socketConfigEnabled": global::UnityEditor.PlayerSettings.Switch.socketConfigEnabled = _value.Read<global::System.Boolean>();  return true;
                case "socketInitializeEnabled": global::UnityEditor.PlayerSettings.Switch.socketInitializeEnabled = _value.Read<global::System.Boolean>();  return true;
                case "socketMemoryPoolSize": global::UnityEditor.PlayerSettings.Switch.socketMemoryPoolSize = _value.Read<global::System.Int32>();  return true;
                case "supportedNpadCount": global::UnityEditor.PlayerSettings.Switch.supportedNpadCount = _value.Read<global::System.Int32>();  return true;
                case "supportedNpadStyles": global::UnityEditor.PlayerSettings.Switch.supportedNpadStyles = _value.Read<global::UnityEditor.PlayerSettings.Switch.SupportedNpadStyle>();  return true;
                case "switchEnableRamDiskSupport": global::UnityEditor.PlayerSettings.Switch.switchEnableRamDiskSupport = _value.Read<global::System.Boolean>();  return true;
                case "switchLTOSetting": global::UnityEditor.PlayerSettings.Switch.switchLTOSetting = _value.Read<global::System.Int32>();  return true;
                case "switchMaxWorkerMultiple": global::UnityEditor.PlayerSettings.Switch.switchMaxWorkerMultiple = _value.Read<global::System.Int32>();  return true;
                case "switchMicroSleepForYieldTime": global::UnityEditor.PlayerSettings.Switch.switchMicroSleepForYieldTime = _value.Read<global::System.Int32>();  return true;
                case "switchRamDiskSpaceSize": global::UnityEditor.PlayerSettings.Switch.switchRamDiskSpaceSize = _value.Read<global::System.Int32>();  return true;
                case "switchUseLegacyFmodPriorities": global::UnityEditor.PlayerSettings.Switch.switchUseLegacyFmodPriorities = _value.Read<global::System.Boolean>();  return true;
                case "switchUseMicroSleepForYield": global::UnityEditor.PlayerSettings.Switch.switchUseMicroSleepForYield = _value.Read<global::System.Boolean>();  return true;
                case "tcpAutoReceiveBufferSizeMax": global::UnityEditor.PlayerSettings.Switch.tcpAutoReceiveBufferSizeMax = _value.Read<global::System.Int32>();  return true;
                case "tcpAutoSendBufferSizeMax": global::UnityEditor.PlayerSettings.Switch.tcpAutoSendBufferSizeMax = _value.Read<global::System.Int32>();  return true;
                case "tcpInitialReceiveBufferSize": global::UnityEditor.PlayerSettings.Switch.tcpInitialReceiveBufferSize = _value.Read<global::System.Int32>();  return true;
                case "tcpInitialSendBufferSize": global::UnityEditor.PlayerSettings.Switch.tcpInitialSendBufferSize = _value.Read<global::System.Int32>();  return true;
                case "udpReceiveBufferSize": global::UnityEditor.PlayerSettings.Switch.udpReceiveBufferSize = _value.Read<global::System.Int32>();  return true;
                case "udpSendBufferSize": global::UnityEditor.PlayerSettings.Switch.udpSendBufferSize = _value.Read<global::System.Int32>();  return true;
                case "useSwitchCPUProfiler": global::UnityEditor.PlayerSettings.Switch.useSwitchCPUProfiler = _value.Read<global::System.Boolean>();  return true;
                default: return false;
            }
        }
    }
}
#pragma warning restore 0109, 0162, 0168, 0219
#endif
