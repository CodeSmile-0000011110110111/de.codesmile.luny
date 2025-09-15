
// --------------------------------------------------------------
// GENERATED FILE ----> DO NOT EDIT <---- CHANGES WILL BE LOST !!
// --------------------------------------------------------------

#if UNITY_6000_2_OR_NEWER && !(UNITY_6000_3_OR_NEWER)
#pragma warning disable 0109, 0162, 0168, 0219
using Luny;

namespace Luny.UnityEngine
{
    public sealed class LuaQualitySettings : global::Luny.UnityEngine.LuaUnityObject, global::Luny.ILuaObject<global::UnityEngine.QualitySettings>
    {
        public new static global::Lua.LuaValue Bind(global::UnityEngine.QualitySettings instance) => new LuaQualitySettings(instance);
        public new static global::Lua.LuaValue Bind(global::System.Object instance) => Bind((global::UnityEngine.QualitySettings)instance);
        public new static global::Lua.LuaValue Bind(global::System.Collections.Generic.IList<global::UnityEngine.QualitySettings> instances) =>
            new global::Luny.LuaList<global::UnityEngine.QualitySettings>(instances);
        public new static global::Lua.LuaValue Bind(global::System.Collections.Generic.IList<global::System.Object> instances) =>
            new global::Luny.LuaList<global::UnityEngine.QualitySettings>(instances);
        private LuaQualitySettings(global::UnityEngine.QualitySettings instance) : base(instance) {}
        public static implicit operator global::Lua.LuaValue(LuaQualitySettings value) => new(value);
        public new global::UnityEngine.QualitySettings Instance => (global::UnityEngine.QualitySettings)m_Instance;
        public new global::System.Type BindType => typeof(global::UnityEngine.QualitySettings);
        public override global::System.String ToString() => m_Instance != null ? Instance.ToString() : "{GetType().Name}(null)";
#if UNITY_EDITOR
        [global::UnityEngine.RuntimeInitializeOnLoadMethod(global::UnityEngine.RuntimeInitializeLoadType.SubsystemRegistration)]
        private static void ResetStaticFields() => s_Metatable = null;
#endif

        private static readonly global::Lua.LuaFunction __index = new(global::Lua.Runtime.Metamethods.Index, (_context, _) =>
        {
            var _this = _context.GetArgument<LuaQualitySettings>(0);
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
            var _this = _context.GetArgument<LuaQualitySettings>(0);
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
            var metatable = new global::Lua.LuaTable(0, 4);
            metatable[global::Lua.Runtime.Metamethods.Index] = __index;
            metatable[global::Lua.Runtime.Metamethods.NewIndex] = __newindex;
            metatable[global::Lua.Runtime.Metamethods.Concat] = global::Luny.LuaMetatable.ConcatMetamethod;
            metatable[global::Lua.Runtime.Metamethods.ToString] = global::Luny.LuaMetatable.ToStringMetamethod;
            return metatable;
        }
        private static global::Lua.LuaTable s_Metatable;
        public new global::Lua.LuaTable Metatable
        {
            get => s_Metatable ??= CreateMetatable();
            set => throw new global::System.NotSupportedException("LuaObject metatables cannot be modified");
        }
        global::System.Span<global::Lua.LuaValue> global::Lua.ILuaUserData.UserValues => default;

        public override global::System.Boolean TryGetLuaValue(global::System.Int32 _key, out global::Lua.LuaValue _value, global::Luny.ILuaObjectFactory _factory)
        {
            return base.TryGetLuaValue(_key, out _value, _factory);
        }
        public override global::System.Boolean TryGetLuaValue(global::System.String _key, out global::Lua.LuaValue _value, global::Luny.ILuaObjectFactory _factory)
        {
            switch (_key)
            {
                default: return base.TryGetLuaValue(_key, out _value, _factory);
            }
        }
        public override global::System.Boolean TrySetLuaValue(global::System.Int32 _key, global::Lua.LuaValue _value)
        {
            return base.TrySetLuaValue(_key, _value);
        }
        public override global::System.Boolean TrySetLuaValue(global::System.String _key, global::Lua.LuaValue _value)
        {
            switch (_key)
            {
                default: return base.TrySetLuaValue(_key, _value);
            }
        }
    }
    public sealed class LuaQualitySettingsType : global::Luny.ILuaStatic
    {
        public static global::Lua.LuaValue Bind() => new LuaQualitySettingsType();
        private LuaQualitySettingsType() {}
        public static implicit operator global::Lua.LuaValue(LuaQualitySettingsType value) => new(value);
        public global::System.Type BindType => typeof(global::UnityEngine.QualitySettings);
        public override global::System.String ToString() => BindType.FullName;
#if UNITY_EDITOR
        [global::UnityEngine.RuntimeInitializeOnLoadMethod(global::UnityEngine.RuntimeInitializeLoadType.SubsystemRegistration)]
        private static void ResetStaticFields() => s_Metatable = null;
#endif

        private static readonly global::Lua.LuaFunction _LuaQualitySettings_DecreaseLevel = new global::Lua.LuaFunction("DecreaseLevel", (_context, _) =>
        {
            global::Lua.LuaValue _lastArg = default;
            global::System.Int32 _lastArgPos = default;
            global::System.Type _expectedType = default;
            var _argCount = _context.ArgumentCount;
            if (_argCount == 0)
            {
                global::UnityEngine.QualitySettings.DecreaseLevel();
                var _retCount = _context.Return();
                return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
            }
            var _arg0 = _lastArg = _argCount > 0 ? _context.GetArgument(0) : global::Lua.LuaValue.Nil;
            _lastArgPos = 0; _expectedType = typeof(global::System.Boolean);
            if (_arg0.TryRead<global::System.Boolean>(out var _p0_System_Boolean))
            {
                if (_argCount == 1)
                {
                    var applyExpensiveChanges = _p0_System_Boolean;
                    global::UnityEngine.QualitySettings.DecreaseLevel(applyExpensiveChanges);
                    var _retCount = _context.Return();
                    return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                }
            }
            throw new global::Lua.LuaRuntimeException(_context.Thread, $"{"DecreaseLevel"}: invalid argument #{_lastArgPos}: {_lastArg} ({_lastArg.Type}), expected: {_expectedType.FullName}", 2);
        });
        private static readonly global::Lua.LuaFunction _LuaQualitySettings_GetQualityLevel = new global::Lua.LuaFunction("GetQualityLevel", (_context, _) =>
        {
            global::Lua.LuaValue _lastArg = default;
            global::System.Int32 _lastArgPos = default;
            global::System.Type _expectedType = default;
            var _argCount = _context.ArgumentCount;
            if (_argCount == 0)
            {
                var _ret0 = global::UnityEngine.QualitySettings.GetQualityLevel();
                var _lret0 = new global::Lua.LuaValue(_ret0);
                var _retCount = _context.Return(_lret0);
                return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
            }
            throw new global::Lua.LuaRuntimeException(_context.Thread, $"{"GetQualityLevel"}: invalid argument #{_lastArgPos}: {_lastArg} ({_lastArg.Type}), expected: {_expectedType.FullName}", 2);
        });
        private static readonly global::Lua.LuaFunction _LuaQualitySettings_GetQualitySettings = new global::Lua.LuaFunction("GetQualitySettings", (_context, _) =>
        {
            global::Lua.LuaValue _lastArg = default;
            global::System.Int32 _lastArgPos = default;
            global::System.Type _expectedType = default;
            var _argCount = _context.ArgumentCount;
            if (_argCount == 0)
            {
                var _ret0 = global::UnityEngine.QualitySettings.GetQualitySettings();
                var _factory = _context.GetObjectFactory();
                var _lret0 = _factory.Bind(_ret0);
                var _retCount = _context.Return(_lret0);
                return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
            }
            throw new global::Lua.LuaRuntimeException(_context.Thread, $"{"GetQualitySettings"}: invalid argument #{_lastArgPos}: {_lastArg} ({_lastArg.Type}), expected: {_expectedType.FullName}", 2);
        });
        private static readonly global::Lua.LuaFunction _LuaQualitySettings_GetRenderPipelineAssetAt = new global::Lua.LuaFunction("GetRenderPipelineAssetAt", (_context, _) =>
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
                    var index = _p0_System_Int32;
                    var _ret0 = global::UnityEngine.QualitySettings.GetRenderPipelineAssetAt(index);
                    var _factory = _context.GetObjectFactory();
                    var _lret0 = _factory.Bind(_ret0);
                    var _retCount = _context.Return(_lret0);
                    return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                }
            }
            throw new global::Lua.LuaRuntimeException(_context.Thread, $"{"GetRenderPipelineAssetAt"}: invalid argument #{_lastArgPos}: {_lastArg} ({_lastArg.Type}), expected: {_expectedType.FullName}", 2);
        });
        private static readonly global::Lua.LuaFunction _LuaQualitySettings_GetTextureMipmapLimitSettings = new global::Lua.LuaFunction("GetTextureMipmapLimitSettings", (_context, _) =>
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
                    var groupName = _p0_System_String;
                    var _ret0 = global::UnityEngine.QualitySettings.GetTextureMipmapLimitSettings(groupName);
                    var _lret0 = global::Luny.UnityEngine.LuaTextureMipmapLimitSettings.Bind(_ret0);
                    var _retCount = _context.Return(_lret0);
                    return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                }
            }
            throw new global::Lua.LuaRuntimeException(_context.Thread, $"{"GetTextureMipmapLimitSettings"}: invalid argument #{_lastArgPos}: {_lastArg} ({_lastArg.Type}), expected: {_expectedType.FullName}", 2);
        });
        private static readonly global::Lua.LuaFunction _LuaQualitySettings_IncreaseLevel = new global::Lua.LuaFunction("IncreaseLevel", (_context, _) =>
        {
            global::Lua.LuaValue _lastArg = default;
            global::System.Int32 _lastArgPos = default;
            global::System.Type _expectedType = default;
            var _argCount = _context.ArgumentCount;
            if (_argCount == 0)
            {
                global::UnityEngine.QualitySettings.IncreaseLevel();
                var _retCount = _context.Return();
                return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
            }
            var _arg0 = _lastArg = _argCount > 0 ? _context.GetArgument(0) : global::Lua.LuaValue.Nil;
            _lastArgPos = 0; _expectedType = typeof(global::System.Boolean);
            if (_arg0.TryRead<global::System.Boolean>(out var _p0_System_Boolean))
            {
                if (_argCount == 1)
                {
                    var applyExpensiveChanges = _p0_System_Boolean;
                    global::UnityEngine.QualitySettings.IncreaseLevel(applyExpensiveChanges);
                    var _retCount = _context.Return();
                    return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                }
            }
            throw new global::Lua.LuaRuntimeException(_context.Thread, $"{"IncreaseLevel"}: invalid argument #{_lastArgPos}: {_lastArg} ({_lastArg.Type}), expected: {_expectedType.FullName}", 2);
        });
        private static readonly global::Lua.LuaFunction _LuaQualitySettings_SetLODSettings = new global::Lua.LuaFunction("SetLODSettings", (_context, _) =>
        {
            global::Lua.LuaValue _lastArg = default;
            global::System.Int32 _lastArgPos = default;
            global::System.Type _expectedType = default;
            var _argCount = _context.ArgumentCount;
            var _arg0 = _lastArg = _argCount > 0 ? _context.GetArgument(0) : global::Lua.LuaValue.Nil;
            _lastArgPos = 0; _expectedType = typeof(global::System.Single);
            if (_arg0.TryRead<global::System.Single>(out var _p0_System_Single))
            {
                var _arg1 = _lastArg = _argCount > 1 ? _context.GetArgument(1) : global::Lua.LuaValue.Nil;
                _lastArgPos = 1; _expectedType = typeof(global::System.Int32);
                if (_arg1.TryRead<global::System.Int32>(out var _p1_System_Int32))
                {
                    if (_argCount == 2)
                    {
                        var lodBias = _p0_System_Single;
                        var maximumLODLevel = _p1_System_Int32;
                        global::UnityEngine.QualitySettings.SetLODSettings(lodBias, maximumLODLevel);
                        var _retCount = _context.Return();
                        return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                    }
                    var _arg2 = _lastArg = _argCount > 2 ? _context.GetArgument(2) : global::Lua.LuaValue.Nil;
                    _lastArgPos = 2; _expectedType = typeof(global::System.Boolean);
                    var _p2_System_Boolean = _arg2.ReadValue<global::System.Boolean>((global::System.Boolean)true);
                    {
                        if (_argCount == 3)
                        {
                            var lodBias = _p0_System_Single;
                            var maximumLODLevel = _p1_System_Int32;
                            var setDirty = _p2_System_Boolean;
                            global::UnityEngine.QualitySettings.SetLODSettings(lodBias, maximumLODLevel, setDirty);
                            var _retCount = _context.Return();
                            return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                        }
                    }
                }
            }
            throw new global::Lua.LuaRuntimeException(_context.Thread, $"{"SetLODSettings"}: invalid argument #{_lastArgPos}: {_lastArg} ({_lastArg.Type}), expected: {_expectedType.FullName}", 2);
        });
        private static readonly global::Lua.LuaFunction _LuaQualitySettings_SetQualityLevel = new global::Lua.LuaFunction("SetQualityLevel", (_context, _) =>
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
                    var index = _p0_System_Int32;
                    global::UnityEngine.QualitySettings.SetQualityLevel(index);
                    var _retCount = _context.Return();
                    return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                }
                var _arg1 = _lastArg = _argCount > 1 ? _context.GetArgument(1) : global::Lua.LuaValue.Nil;
                _lastArgPos = 1; _expectedType = typeof(global::System.Boolean);
                if (_arg1.TryRead<global::System.Boolean>(out var _p1_System_Boolean))
                {
                    if (_argCount == 2)
                    {
                        var index = _p0_System_Int32;
                        var applyExpensiveChanges = _p1_System_Boolean;
                        global::UnityEngine.QualitySettings.SetQualityLevel(index, applyExpensiveChanges);
                        var _retCount = _context.Return();
                        return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                    }
                }
            }
            throw new global::Lua.LuaRuntimeException(_context.Thread, $"{"SetQualityLevel"}: invalid argument #{_lastArgPos}: {_lastArg} ({_lastArg.Type}), expected: {_expectedType.FullName}", 2);
        });
        private static readonly global::Lua.LuaFunction _LuaQualitySettings_SetTextureMipmapLimitSettings = new global::Lua.LuaFunction("SetTextureMipmapLimitSettings", (_context, _) =>
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
                _lastArgPos = 1; _expectedType = typeof(global::Luny.UnityEngine.LuaTextureMipmapLimitSettings);
                if (_arg1.TryRead<global::Luny.UnityEngine.LuaTextureMipmapLimitSettings>(out var _p1_UnityEngine_TextureMipmapLimitSettings))
                {
                    if (_argCount == 2)
                    {
                        var groupName = _p0_System_String;
                        var textureMipmapLimitSettings = _p1_UnityEngine_TextureMipmapLimitSettings.Value;
                        global::UnityEngine.QualitySettings.SetTextureMipmapLimitSettings(groupName, textureMipmapLimitSettings);
                        var _retCount = _context.Return();
                        return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                    }
                }
            }
            throw new global::Lua.LuaRuntimeException(_context.Thread, $"{"SetTextureMipmapLimitSettings"}: invalid argument #{_lastArgPos}: {_lastArg} ({_lastArg.Type}), expected: {_expectedType.FullName}", 2);
        });
        private static readonly global::Lua.LuaFunction __index = new(global::Lua.Runtime.Metamethods.Index, (_context, _) =>
        {
            var _this = _context.GetArgument<LuaQualitySettingsType>(0);
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
            var _this = _context.GetArgument<LuaQualitySettingsType>(0);
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
            var metatable = new global::Lua.LuaTable(0, 4);
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
                case "DecreaseLevel": _value = _LuaQualitySettings_DecreaseLevel; return true;
                case "GetQualityLevel": _value = _LuaQualitySettings_GetQualityLevel; return true;
                case "GetQualitySettings": _value = _LuaQualitySettings_GetQualitySettings; return true;
                case "GetRenderPipelineAssetAt": _value = _LuaQualitySettings_GetRenderPipelineAssetAt; return true;
                case "GetTextureMipmapLimitSettings": _value = _LuaQualitySettings_GetTextureMipmapLimitSettings; return true;
                case "IncreaseLevel": _value = _LuaQualitySettings_IncreaseLevel; return true;
                case "SetLODSettings": _value = _LuaQualitySettings_SetLODSettings; return true;
                case "SetQualityLevel": _value = _LuaQualitySettings_SetQualityLevel; return true;
                case "SetTextureMipmapLimitSettings": _value = _LuaQualitySettings_SetTextureMipmapLimitSettings; return true;
                case "activeColorSpace": _value = new global::Lua.LuaValue((global::System.Int64)global::UnityEngine.QualitySettings.activeColorSpace); return true;
                case "anisotropicFiltering": _value = new global::Lua.LuaValue((global::System.Int64)global::UnityEngine.QualitySettings.anisotropicFiltering); return true;
                case "antiAliasing": _value = new global::Lua.LuaValue(global::UnityEngine.QualitySettings.antiAliasing); return true;
                case "asyncUploadBufferSize": _value = new global::Lua.LuaValue(global::UnityEngine.QualitySettings.asyncUploadBufferSize); return true;
                case "asyncUploadPersistentBuffer": _value = new global::Lua.LuaValue(global::UnityEngine.QualitySettings.asyncUploadPersistentBuffer); return true;
                case "asyncUploadTimeSlice": _value = new global::Lua.LuaValue(global::UnityEngine.QualitySettings.asyncUploadTimeSlice); return true;
                case "billboardsFaceCameraPosition": _value = new global::Lua.LuaValue(global::UnityEngine.QualitySettings.billboardsFaceCameraPosition); return true;
                case "count": _value = new global::Lua.LuaValue(global::UnityEngine.QualitySettings.count); return true;
                case "desiredColorSpace": _value = new global::Lua.LuaValue((global::System.Int64)global::UnityEngine.QualitySettings.desiredColorSpace); return true;
                case "enableLODCrossFade": _value = new global::Lua.LuaValue(global::UnityEngine.QualitySettings.enableLODCrossFade); return true;
                case "globalTextureMipmapLimit": _value = new global::Lua.LuaValue(global::UnityEngine.QualitySettings.globalTextureMipmapLimit); return true;
                case "lodBias": _value = new global::Lua.LuaValue(global::UnityEngine.QualitySettings.lodBias); return true;
                case "maximumLODLevel": _value = new global::Lua.LuaValue(global::UnityEngine.QualitySettings.maximumLODLevel); return true;
                case "maxQueuedFrames": _value = new global::Lua.LuaValue(global::UnityEngine.QualitySettings.maxQueuedFrames); return true;
                case "meshLodThreshold": _value = new global::Lua.LuaValue(global::UnityEngine.QualitySettings.meshLodThreshold); return true;
                case "names": _value = _factory.Bind(global::UnityEngine.QualitySettings.names); return true;
                case "particleRaycastBudget": _value = new global::Lua.LuaValue(global::UnityEngine.QualitySettings.particleRaycastBudget); return true;
                case "pixelLightCount": _value = new global::Lua.LuaValue(global::UnityEngine.QualitySettings.pixelLightCount); return true;
                case "realtimeGICPUUsage": _value = new global::Lua.LuaValue(global::UnityEngine.QualitySettings.realtimeGICPUUsage); return true;
                case "realtimeReflectionProbes": _value = new global::Lua.LuaValue(global::UnityEngine.QualitySettings.realtimeReflectionProbes); return true;
                case "renderPipeline": _value = _factory.Bind(global::UnityEngine.QualitySettings.renderPipeline); return true;
                case "resolutionScalingFixedDPIFactor": _value = new global::Lua.LuaValue(global::UnityEngine.QualitySettings.resolutionScalingFixedDPIFactor); return true;
                case "shadowCascade2Split": _value = new global::Lua.LuaValue(global::UnityEngine.QualitySettings.shadowCascade2Split); return true;
                case "shadowCascade4Split": _value = global::Luny.UnityEngine.LuaVector3.Bind(global::UnityEngine.QualitySettings.shadowCascade4Split); return true;
                case "shadowCascades": _value = new global::Lua.LuaValue(global::UnityEngine.QualitySettings.shadowCascades); return true;
                case "shadowDistance": _value = new global::Lua.LuaValue(global::UnityEngine.QualitySettings.shadowDistance); return true;
                case "shadowmaskMode": _value = new global::Lua.LuaValue((global::System.Int64)global::UnityEngine.QualitySettings.shadowmaskMode); return true;
                case "shadowNearPlaneOffset": _value = new global::Lua.LuaValue(global::UnityEngine.QualitySettings.shadowNearPlaneOffset); return true;
                case "shadowProjection": _value = new global::Lua.LuaValue((global::System.Int64)global::UnityEngine.QualitySettings.shadowProjection); return true;
                case "shadowResolution": _value = new global::Lua.LuaValue((global::System.Int64)global::UnityEngine.QualitySettings.shadowResolution); return true;
                case "shadows": _value = new global::Lua.LuaValue((global::System.Int64)global::UnityEngine.QualitySettings.shadows); return true;
                case "skinWeights": _value = new global::Lua.LuaValue((global::System.Int64)global::UnityEngine.QualitySettings.skinWeights); return true;
                case "softParticles": _value = new global::Lua.LuaValue(global::UnityEngine.QualitySettings.softParticles); return true;
                case "softVegetation": _value = new global::Lua.LuaValue(global::UnityEngine.QualitySettings.softVegetation); return true;
                case "streamingMipmapsActive": _value = new global::Lua.LuaValue(global::UnityEngine.QualitySettings.streamingMipmapsActive); return true;
                case "streamingMipmapsAddAllCameras": _value = new global::Lua.LuaValue(global::UnityEngine.QualitySettings.streamingMipmapsAddAllCameras); return true;
                case "streamingMipmapsMaxFileIORequests": _value = new global::Lua.LuaValue(global::UnityEngine.QualitySettings.streamingMipmapsMaxFileIORequests); return true;
                case "streamingMipmapsMaxLevelReduction": _value = new global::Lua.LuaValue(global::UnityEngine.QualitySettings.streamingMipmapsMaxLevelReduction); return true;
                case "streamingMipmapsMemoryBudget": _value = new global::Lua.LuaValue(global::UnityEngine.QualitySettings.streamingMipmapsMemoryBudget); return true;
                case "streamingMipmapsRenderersPerFrame": _value = new global::Lua.LuaValue(global::UnityEngine.QualitySettings.streamingMipmapsRenderersPerFrame); return true;
                case "terrainBasemapDistance": _value = new global::Lua.LuaValue(global::UnityEngine.QualitySettings.terrainBasemapDistance); return true;
                case "terrainBillboardStart": _value = new global::Lua.LuaValue(global::UnityEngine.QualitySettings.terrainBillboardStart); return true;
                case "terrainDetailDensityScale": _value = new global::Lua.LuaValue(global::UnityEngine.QualitySettings.terrainDetailDensityScale); return true;
                case "terrainDetailDistance": _value = new global::Lua.LuaValue(global::UnityEngine.QualitySettings.terrainDetailDistance); return true;
                case "terrainFadeLength": _value = new global::Lua.LuaValue(global::UnityEngine.QualitySettings.terrainFadeLength); return true;
                case "terrainMaxTrees": _value = new global::Lua.LuaValue(global::UnityEngine.QualitySettings.terrainMaxTrees); return true;
                case "terrainPixelError": _value = new global::Lua.LuaValue(global::UnityEngine.QualitySettings.terrainPixelError); return true;
                case "terrainQualityOverrides": _value = new global::Lua.LuaValue((global::System.Int64)global::UnityEngine.QualitySettings.terrainQualityOverrides); return true;
                case "terrainTreeDistance": _value = new global::Lua.LuaValue(global::UnityEngine.QualitySettings.terrainTreeDistance); return true;
                case "useLegacyDetailDistribution": _value = new global::Lua.LuaValue(global::UnityEngine.QualitySettings.useLegacyDetailDistribution); return true;
                case "vSyncCount": _value = new global::Lua.LuaValue(global::UnityEngine.QualitySettings.vSyncCount); return true;
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
                case "anisotropicFiltering": global::UnityEngine.QualitySettings.anisotropicFiltering = _value.Read<global::UnityEngine.AnisotropicFiltering>();  return true;
                case "antiAliasing": global::UnityEngine.QualitySettings.antiAliasing = _value.Read<global::System.Int32>();  return true;
                case "asyncUploadBufferSize": global::UnityEngine.QualitySettings.asyncUploadBufferSize = _value.Read<global::System.Int32>();  return true;
                case "asyncUploadPersistentBuffer": global::UnityEngine.QualitySettings.asyncUploadPersistentBuffer = _value.Read<global::System.Boolean>();  return true;
                case "asyncUploadTimeSlice": global::UnityEngine.QualitySettings.asyncUploadTimeSlice = _value.Read<global::System.Int32>();  return true;
                case "billboardsFaceCameraPosition": global::UnityEngine.QualitySettings.billboardsFaceCameraPosition = _value.Read<global::System.Boolean>();  return true;
                case "enableLODCrossFade": global::UnityEngine.QualitySettings.enableLODCrossFade = _value.Read<global::System.Boolean>();  return true;
                case "globalTextureMipmapLimit": global::UnityEngine.QualitySettings.globalTextureMipmapLimit = _value.Read<global::System.Int32>();  return true;
                case "lodBias": global::UnityEngine.QualitySettings.lodBias = _value.Read<global::System.Single>();  return true;
                case "maximumLODLevel": global::UnityEngine.QualitySettings.maximumLODLevel = _value.Read<global::System.Int32>();  return true;
                case "maxQueuedFrames": global::UnityEngine.QualitySettings.maxQueuedFrames = _value.Read<global::System.Int32>();  return true;
                case "meshLodThreshold": global::UnityEngine.QualitySettings.meshLodThreshold = _value.Read<global::System.Single>();  return true;
                case "particleRaycastBudget": global::UnityEngine.QualitySettings.particleRaycastBudget = _value.Read<global::System.Int32>();  return true;
                case "pixelLightCount": global::UnityEngine.QualitySettings.pixelLightCount = _value.Read<global::System.Int32>();  return true;
                case "realtimeGICPUUsage": global::UnityEngine.QualitySettings.realtimeGICPUUsage = _value.Read<global::System.Int32>();  return true;
                case "realtimeReflectionProbes": global::UnityEngine.QualitySettings.realtimeReflectionProbes = _value.Read<global::System.Boolean>();  return true;
                case "renderPipeline": global::UnityEngine.QualitySettings.renderPipeline = _value.Read<global::Luny.UnityEngine.Rendering.LuaRenderPipelineAsset>().Instance;  return true;
                case "resolutionScalingFixedDPIFactor": global::UnityEngine.QualitySettings.resolutionScalingFixedDPIFactor = _value.Read<global::System.Single>();  return true;
                case "shadowCascade2Split": global::UnityEngine.QualitySettings.shadowCascade2Split = _value.Read<global::System.Single>();  return true;
                case "shadowCascade4Split": global::UnityEngine.QualitySettings.shadowCascade4Split = _value.Read<global::Luny.UnityEngine.LuaVector3>().Value;  return true;
                case "shadowCascades": global::UnityEngine.QualitySettings.shadowCascades = _value.Read<global::System.Int32>();  return true;
                case "shadowDistance": global::UnityEngine.QualitySettings.shadowDistance = _value.Read<global::System.Single>();  return true;
                case "shadowmaskMode": global::UnityEngine.QualitySettings.shadowmaskMode = _value.Read<global::UnityEngine.ShadowmaskMode>();  return true;
                case "shadowNearPlaneOffset": global::UnityEngine.QualitySettings.shadowNearPlaneOffset = _value.Read<global::System.Single>();  return true;
                case "shadowProjection": global::UnityEngine.QualitySettings.shadowProjection = _value.Read<global::UnityEngine.ShadowProjection>();  return true;
                case "shadowResolution": global::UnityEngine.QualitySettings.shadowResolution = _value.Read<global::UnityEngine.ShadowResolution>();  return true;
                case "shadows": global::UnityEngine.QualitySettings.shadows = _value.Read<global::UnityEngine.ShadowQuality>();  return true;
                case "skinWeights": global::UnityEngine.QualitySettings.skinWeights = _value.Read<global::UnityEngine.SkinWeights>();  return true;
                case "softParticles": global::UnityEngine.QualitySettings.softParticles = _value.Read<global::System.Boolean>();  return true;
                case "softVegetation": global::UnityEngine.QualitySettings.softVegetation = _value.Read<global::System.Boolean>();  return true;
                case "streamingMipmapsActive": global::UnityEngine.QualitySettings.streamingMipmapsActive = _value.Read<global::System.Boolean>();  return true;
                case "streamingMipmapsAddAllCameras": global::UnityEngine.QualitySettings.streamingMipmapsAddAllCameras = _value.Read<global::System.Boolean>();  return true;
                case "streamingMipmapsMaxFileIORequests": global::UnityEngine.QualitySettings.streamingMipmapsMaxFileIORequests = _value.Read<global::System.Int32>();  return true;
                case "streamingMipmapsMaxLevelReduction": global::UnityEngine.QualitySettings.streamingMipmapsMaxLevelReduction = _value.Read<global::System.Int32>();  return true;
                case "streamingMipmapsMemoryBudget": global::UnityEngine.QualitySettings.streamingMipmapsMemoryBudget = _value.Read<global::System.Single>();  return true;
                case "streamingMipmapsRenderersPerFrame": global::UnityEngine.QualitySettings.streamingMipmapsRenderersPerFrame = _value.Read<global::System.Int32>();  return true;
                case "terrainBasemapDistance": global::UnityEngine.QualitySettings.terrainBasemapDistance = _value.Read<global::System.Single>();  return true;
                case "terrainBillboardStart": global::UnityEngine.QualitySettings.terrainBillboardStart = _value.Read<global::System.Single>();  return true;
                case "terrainDetailDensityScale": global::UnityEngine.QualitySettings.terrainDetailDensityScale = _value.Read<global::System.Single>();  return true;
                case "terrainDetailDistance": global::UnityEngine.QualitySettings.terrainDetailDistance = _value.Read<global::System.Single>();  return true;
                case "terrainFadeLength": global::UnityEngine.QualitySettings.terrainFadeLength = _value.Read<global::System.Single>();  return true;
                case "terrainMaxTrees": global::UnityEngine.QualitySettings.terrainMaxTrees = _value.Read<global::System.Single>();  return true;
                case "terrainPixelError": global::UnityEngine.QualitySettings.terrainPixelError = _value.Read<global::System.Single>();  return true;
                case "terrainQualityOverrides": global::UnityEngine.QualitySettings.terrainQualityOverrides = _value.Read<global::UnityEngine.TerrainQualityOverrides>();  return true;
                case "terrainTreeDistance": global::UnityEngine.QualitySettings.terrainTreeDistance = _value.Read<global::System.Single>();  return true;
                case "useLegacyDetailDistribution": global::UnityEngine.QualitySettings.useLegacyDetailDistribution = _value.Read<global::System.Boolean>();  return true;
                case "vSyncCount": global::UnityEngine.QualitySettings.vSyncCount = _value.Read<global::System.Int32>();  return true;
                default: return false;
            }
        }
    }
}
#pragma warning restore 0109, 0162, 0168, 0219
#endif
