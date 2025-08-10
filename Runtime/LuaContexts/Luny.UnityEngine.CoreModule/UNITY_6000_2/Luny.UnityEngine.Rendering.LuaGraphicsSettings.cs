
// --------------------------------------------------------------
// GENERATED FILE ----> DO NOT EDIT <---- CHANGES WILL BE LOST !!
// --------------------------------------------------------------

#if UNITY_6000_2_OR_NEWER && !(UNITY_6000_3_OR_NEWER)
#pragma warning disable 0109, 0162, 0168, 0219
using Luny;

namespace Luny.UnityEngine.Rendering
{
    public sealed class LuaGraphicsSettings : LuaUnityObject, global::Luny.ILuaObject<global::UnityEngine.Rendering.GraphicsSettings>
    {
        public new static global::Lua.LuaValue Bind(global::UnityEngine.Rendering.GraphicsSettings instance) => new LuaGraphicsSettings(instance);
        public new static global::Lua.LuaValue Bind(global::System.Object instance) => Bind((global::UnityEngine.Rendering.GraphicsSettings)instance);
        public new static global::Lua.LuaValue Bind(global::System.Collections.Generic.IList<global::UnityEngine.Rendering.GraphicsSettings> instances) =>
            new global::Luny.LuaList<global::UnityEngine.Rendering.GraphicsSettings>(instances);
        public new static global::Lua.LuaValue Bind(global::System.Collections.Generic.IList<global::System.Object> instances) =>
            new global::Luny.LuaList<global::UnityEngine.Rendering.GraphicsSettings>(instances);
        private LuaGraphicsSettings(global::UnityEngine.Rendering.GraphicsSettings instance) : base(instance) {}
        public static implicit operator global::Lua.LuaValue(LuaGraphicsSettings value) => new(value);
        public new global::UnityEngine.Rendering.GraphicsSettings Instance => (global::UnityEngine.Rendering.GraphicsSettings)m_Instance;
        public new global::System.Type BindType => typeof(global::UnityEngine.Rendering.GraphicsSettings);
        private static global::Lua.LuaTable s_Metatable;
        public new global::Lua.LuaTable Metatable
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
            var _this = _context.GetArgument<LuaGraphicsSettings>(0);
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
            var _this = _context.GetArgument<LuaGraphicsSettings>(0);
            var _key = _context.GetArgument(1);
            var _value = _context.GetArgument(2);
            if (_key.Type == global::Lua.LuaValueType.Number && _key.TryRead<global::System.Int32>(out var _index) && _this.TrySetLuaValue(_index, _value))
                return new global::System.Threading.Tasks.ValueTask<global::System.Int32>(_context.Return(_value));
            if (_key.Type == global::Lua.LuaValueType.String && _this.TrySetLuaValue(_key.Read<global::System.String>(), _value))
                return new global::System.Threading.Tasks.ValueTask<global::System.Int32>(_context.Return(_value));
            throw new global::Lua.LuaRuntimeException(_context.Thread, $"attempt to assign to unknown '{_key}' on '{_this}'", 2);
        });

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
    public sealed class LuaGraphicsSettingsType : global::Luny.ILuaStatic
    {
        public static global::Lua.LuaValue Bind() => new LuaGraphicsSettingsType();
        private LuaGraphicsSettingsType() {}
        public static implicit operator global::Lua.LuaValue(LuaGraphicsSettingsType value) => new(value);
        public global::System.Type BindType => typeof(global::UnityEngine.Rendering.GraphicsSettings);
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

        private static readonly global::Lua.LuaFunction _LuaGraphicsSettings_GetCustomShader = new global::Lua.LuaFunction("GetCustomShader", (_context, _) =>
        {
            global::Lua.LuaValue _lastArg = default;
            global::System.Int32 _lastArgPos = default;
            global::System.Type _expectedType = default;
            var _argCount = _context.ArgumentCount;
            var _arg0 = _lastArg = _argCount > 0 ? _context.GetArgument(0) : global::Lua.LuaValue.Nil;
            _lastArgPos = 0; _expectedType = typeof(global::UnityEngine.Rendering.BuiltinShaderType);
            if (_arg0.TryRead<global::UnityEngine.Rendering.BuiltinShaderType>(out var _p0_UnityEngine_Rendering_BuiltinShaderType))
            {
                if (_argCount == 1)
                {
                    var type = _p0_UnityEngine_Rendering_BuiltinShaderType;
                    var _ret0 = global::UnityEngine.Rendering.GraphicsSettings.GetCustomShader(type);
                    var _factory = _context.GetObjectFactory();
                    var _lret0 = _factory.Bind(_ret0);
                    var _retCount = _context.Return(_lret0);
                    return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                }
            }
            throw new global::Lua.LuaRuntimeException(_context.Thread, $"{"GetCustomShader"}: invalid argument #{_lastArgPos}: {_lastArg} ({_lastArg.Type}), expected: {_expectedType.FullName}", 2);
        });
        private static readonly global::Lua.LuaFunction _LuaGraphicsSettings_GetGraphicsSettings = new global::Lua.LuaFunction("GetGraphicsSettings", (_context, _) =>
        {
            global::Lua.LuaValue _lastArg = default;
            global::System.Int32 _lastArgPos = default;
            global::System.Type _expectedType = default;
            var _argCount = _context.ArgumentCount;
            if (_argCount == 0)
            {
                var _ret0 = global::UnityEngine.Rendering.GraphicsSettings.GetGraphicsSettings();
                var _factory = _context.GetObjectFactory();
                var _lret0 = _factory.Bind(_ret0);
                var _retCount = _context.Return(_lret0);
                return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
            }
            throw new global::Lua.LuaRuntimeException(_context.Thread, $"{"GetGraphicsSettings"}: invalid argument #{_lastArgPos}: {_lastArg} ({_lastArg.Type}), expected: {_expectedType.FullName}", 2);
        });
        private static readonly global::Lua.LuaFunction _LuaGraphicsSettings_GetSettingsForRenderPipeline = new global::Lua.LuaFunction("GetSettingsForRenderPipeline", (_context, _) =>
        {
            global::Lua.LuaValue _lastArg = default;
            global::System.Int32 _lastArgPos = default;
            global::System.Type _expectedType = default;
            var _argCount = _context.ArgumentCount;
            var _arg0 = _lastArg = _argCount > 0 ? _context.GetArgument(0) : global::Lua.LuaValue.Nil;
            _lastArgPos = 0; _expectedType = typeof(global::Luny.ILuaBindType);
            if (_arg0.TryRead<global::Luny.ILuaBindType>(out var _p0_System_Type))
            {
                if (_argCount == 1)
                {
                    var renderPipelineType = _p0_System_Type.BindType;
                    var _ret0 = global::UnityEngine.Rendering.GraphicsSettings.GetSettingsForRenderPipeline(renderPipelineType);
                    var _factory = _context.GetObjectFactory();
                    var _lret0 = _factory.Bind(_ret0);
                    var _retCount = _context.Return(_lret0);
                    return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                }
            }
            throw new global::Lua.LuaRuntimeException(_context.Thread, $"{"GetSettingsForRenderPipeline"}: invalid argument #{_lastArgPos}: {_lastArg} ({_lastArg.Type}), expected: {_expectedType.FullName}", 2);
        });
        private static readonly global::Lua.LuaFunction _LuaGraphicsSettings_GetShaderMode = new global::Lua.LuaFunction("GetShaderMode", (_context, _) =>
        {
            global::Lua.LuaValue _lastArg = default;
            global::System.Int32 _lastArgPos = default;
            global::System.Type _expectedType = default;
            var _argCount = _context.ArgumentCount;
            var _arg0 = _lastArg = _argCount > 0 ? _context.GetArgument(0) : global::Lua.LuaValue.Nil;
            _lastArgPos = 0; _expectedType = typeof(global::UnityEngine.Rendering.BuiltinShaderType);
            if (_arg0.TryRead<global::UnityEngine.Rendering.BuiltinShaderType>(out var _p0_UnityEngine_Rendering_BuiltinShaderType))
            {
                if (_argCount == 1)
                {
                    var type = _p0_UnityEngine_Rendering_BuiltinShaderType;
                    var _ret0 = global::UnityEngine.Rendering.GraphicsSettings.GetShaderMode(type);
                    var _lret0 = new global::Lua.LuaValue((global::System.Int64)_ret0);
                    var _retCount = _context.Return(_lret0);
                    return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                }
            }
            throw new global::Lua.LuaRuntimeException(_context.Thread, $"{"GetShaderMode"}: invalid argument #{_lastArgPos}: {_lastArg} ({_lastArg.Type}), expected: {_expectedType.FullName}", 2);
        });
        private static readonly global::Lua.LuaFunction _LuaGraphicsSettings_HasShaderDefine = new global::Lua.LuaFunction("HasShaderDefine", (_context, _) =>
        {
            global::Lua.LuaValue _lastArg = default;
            global::System.Int32 _lastArgPos = default;
            global::System.Type _expectedType = default;
            var _argCount = _context.ArgumentCount;
            var _arg0 = _lastArg = _argCount > 0 ? _context.GetArgument(0) : global::Lua.LuaValue.Nil;
            _lastArgPos = 0; _expectedType = typeof(global::UnityEngine.Rendering.BuiltinShaderDefine);
            if (_arg0.TryRead<global::UnityEngine.Rendering.BuiltinShaderDefine>(out var _p0_UnityEngine_Rendering_BuiltinShaderDefine))
            {
                if (_argCount == 1)
                {
                    var defineHash = _p0_UnityEngine_Rendering_BuiltinShaderDefine;
                    var _ret0 = global::UnityEngine.Rendering.GraphicsSettings.HasShaderDefine(defineHash);
                    var _lret0 = new global::Lua.LuaValue(_ret0);
                    var _retCount = _context.Return(_lret0);
                    return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                }
            }
            _lastArgPos = 0; _expectedType = typeof(global::UnityEngine.Rendering.GraphicsTier);
            if (_arg0.TryRead<global::UnityEngine.Rendering.GraphicsTier>(out var _p0_UnityEngine_Rendering_GraphicsTier))
            {
                var _arg1 = _lastArg = _argCount > 1 ? _context.GetArgument(1) : global::Lua.LuaValue.Nil;
                _lastArgPos = 1; _expectedType = typeof(global::UnityEngine.Rendering.BuiltinShaderDefine);
                if (_arg1.TryRead<global::UnityEngine.Rendering.BuiltinShaderDefine>(out var _p1_UnityEngine_Rendering_BuiltinShaderDefine))
                {
                    if (_argCount == 2)
                    {
                        var tier = _p0_UnityEngine_Rendering_GraphicsTier;
                        var defineHash = _p1_UnityEngine_Rendering_BuiltinShaderDefine;
                        var _ret0 = global::UnityEngine.Rendering.GraphicsSettings.HasShaderDefine(tier, defineHash);
                        var _lret0 = new global::Lua.LuaValue(_ret0);
                        var _retCount = _context.Return(_lret0);
                        return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                    }
                }
            }
            throw new global::Lua.LuaRuntimeException(_context.Thread, $"{"HasShaderDefine"}: invalid argument #{_lastArgPos}: {_lastArg} ({_lastArg.Type}), expected: {_expectedType.FullName}", 2);
        });
        private static readonly global::Lua.LuaFunction _LuaGraphicsSettings_SetCustomShader = new global::Lua.LuaFunction("SetCustomShader", (_context, _) =>
        {
            global::Lua.LuaValue _lastArg = default;
            global::System.Int32 _lastArgPos = default;
            global::System.Type _expectedType = default;
            var _argCount = _context.ArgumentCount;
            var _arg0 = _lastArg = _argCount > 0 ? _context.GetArgument(0) : global::Lua.LuaValue.Nil;
            _lastArgPos = 0; _expectedType = typeof(global::UnityEngine.Rendering.BuiltinShaderType);
            if (_arg0.TryRead<global::UnityEngine.Rendering.BuiltinShaderType>(out var _p0_UnityEngine_Rendering_BuiltinShaderType))
            {
                var _arg1 = _lastArg = _argCount > 1 ? _context.GetArgument(1) : global::Lua.LuaValue.Nil;
                _lastArgPos = 1; _expectedType = typeof(global::Luny.UnityEngine.LuaShader);
                if (_arg1.TryRead<global::Luny.UnityEngine.LuaShader>(out var _p1_UnityEngine_Shader))
                {
                    if (_argCount == 2)
                    {
                        var type = _p0_UnityEngine_Rendering_BuiltinShaderType;
                        var shader = _p1_UnityEngine_Shader.Instance;
                        global::UnityEngine.Rendering.GraphicsSettings.SetCustomShader(type, shader);
                        var _retCount = _context.Return();
                        return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                    }
                }
            }
            throw new global::Lua.LuaRuntimeException(_context.Thread, $"{"SetCustomShader"}: invalid argument #{_lastArgPos}: {_lastArg} ({_lastArg.Type}), expected: {_expectedType.FullName}", 2);
        });
        private static readonly global::Lua.LuaFunction _LuaGraphicsSettings_SetShaderMode = new global::Lua.LuaFunction("SetShaderMode", (_context, _) =>
        {
            global::Lua.LuaValue _lastArg = default;
            global::System.Int32 _lastArgPos = default;
            global::System.Type _expectedType = default;
            var _argCount = _context.ArgumentCount;
            var _arg0 = _lastArg = _argCount > 0 ? _context.GetArgument(0) : global::Lua.LuaValue.Nil;
            _lastArgPos = 0; _expectedType = typeof(global::UnityEngine.Rendering.BuiltinShaderType);
            if (_arg0.TryRead<global::UnityEngine.Rendering.BuiltinShaderType>(out var _p0_UnityEngine_Rendering_BuiltinShaderType))
            {
                var _arg1 = _lastArg = _argCount > 1 ? _context.GetArgument(1) : global::Lua.LuaValue.Nil;
                _lastArgPos = 1; _expectedType = typeof(global::UnityEngine.Rendering.BuiltinShaderMode);
                if (_arg1.TryRead<global::UnityEngine.Rendering.BuiltinShaderMode>(out var _p1_UnityEngine_Rendering_BuiltinShaderMode))
                {
                    if (_argCount == 2)
                    {
                        var type = _p0_UnityEngine_Rendering_BuiltinShaderType;
                        var mode = _p1_UnityEngine_Rendering_BuiltinShaderMode;
                        global::UnityEngine.Rendering.GraphicsSettings.SetShaderMode(type, mode);
                        var _retCount = _context.Return();
                        return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                    }
                }
            }
            throw new global::Lua.LuaRuntimeException(_context.Thread, $"{"SetShaderMode"}: invalid argument #{_lastArgPos}: {_lastArg} ({_lastArg.Type}), expected: {_expectedType.FullName}", 2);
        });
        private static readonly global::Lua.LuaFunction __index = new(global::Lua.Runtime.Metamethods.Index, (_context, _) =>
        {
            var _this = _context.GetArgument<LuaGraphicsSettingsType>(0);
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
            var _this = _context.GetArgument<LuaGraphicsSettingsType>(0);
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
                case "GetCustomShader": _value = _LuaGraphicsSettings_GetCustomShader; return true;
                case "GetGraphicsSettings": _value = _LuaGraphicsSettings_GetGraphicsSettings; return true;
                case "GetSettingsForRenderPipeline": _value = _LuaGraphicsSettings_GetSettingsForRenderPipeline; return true;
                case "GetShaderMode": _value = _LuaGraphicsSettings_GetShaderMode; return true;
                case "HasShaderDefine": _value = _LuaGraphicsSettings_HasShaderDefine; return true;
                case "SetCustomShader": _value = _LuaGraphicsSettings_SetCustomShader; return true;
                case "SetShaderMode": _value = _LuaGraphicsSettings_SetShaderMode; return true;
                case "allConfiguredRenderPipelines": _value = _factory.Bind(global::UnityEngine.Rendering.GraphicsSettings.allConfiguredRenderPipelines); return true;
                case "cameraRelativeLightCulling": _value = new global::Lua.LuaValue(global::UnityEngine.Rendering.GraphicsSettings.cameraRelativeLightCulling); return true;
                case "cameraRelativeShadowCulling": _value = new global::Lua.LuaValue(global::UnityEngine.Rendering.GraphicsSettings.cameraRelativeShadowCulling); return true;
                case "currentRenderPipeline": _value = _factory.Bind(global::UnityEngine.Rendering.GraphicsSettings.currentRenderPipeline); return true;
                case "currentRenderPipelineAssetType": _value = _factory.Bind(global::UnityEngine.Rendering.GraphicsSettings.currentRenderPipelineAssetType); return true;
                case "defaultGateFitMode": _value = new global::Lua.LuaValue((global::System.Int64)global::UnityEngine.Rendering.GraphicsSettings.defaultGateFitMode); return true;
                case "defaultRenderPipeline": _value = _factory.Bind(global::UnityEngine.Rendering.GraphicsSettings.defaultRenderPipeline); return true;
                case "disableBuiltinCustomRenderTextureUpdate": _value = new global::Lua.LuaValue(global::UnityEngine.Rendering.GraphicsSettings.disableBuiltinCustomRenderTextureUpdate); return true;
                case "isScriptableRenderPipelineEnabled": _value = new global::Lua.LuaValue(global::UnityEngine.Rendering.GraphicsSettings.isScriptableRenderPipelineEnabled); return true;
                case "lightProbeOutsideHullStrategy": _value = new global::Lua.LuaValue((global::System.Int64)global::UnityEngine.Rendering.GraphicsSettings.lightProbeOutsideHullStrategy); return true;
                case "lightsUseColorTemperature": _value = new global::Lua.LuaValue(global::UnityEngine.Rendering.GraphicsSettings.lightsUseColorTemperature); return true;
                case "lightsUseLinearIntensity": _value = new global::Lua.LuaValue(global::UnityEngine.Rendering.GraphicsSettings.lightsUseLinearIntensity); return true;
                case "logWhenShaderIsCompiled": _value = new global::Lua.LuaValue(global::UnityEngine.Rendering.GraphicsSettings.logWhenShaderIsCompiled); return true;
                case "realtimeDirectRectangularAreaLights": _value = new global::Lua.LuaValue(global::UnityEngine.Rendering.GraphicsSettings.realtimeDirectRectangularAreaLights); return true;
                case "transparencySortAxis": _value = global::Luny.UnityEngine.LuaVector3.Bind(global::UnityEngine.Rendering.GraphicsSettings.transparencySortAxis); return true;
                case "transparencySortMode": _value = new global::Lua.LuaValue((global::System.Int64)global::UnityEngine.Rendering.GraphicsSettings.transparencySortMode); return true;
                case "useScriptableRenderPipelineBatching": _value = new global::Lua.LuaValue(global::UnityEngine.Rendering.GraphicsSettings.useScriptableRenderPipelineBatching); return true;
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
                case "cameraRelativeLightCulling": global::UnityEngine.Rendering.GraphicsSettings.cameraRelativeLightCulling = _value.Read<global::System.Boolean>();  return true;
                case "cameraRelativeShadowCulling": global::UnityEngine.Rendering.GraphicsSettings.cameraRelativeShadowCulling = _value.Read<global::System.Boolean>();  return true;
                case "defaultGateFitMode": global::UnityEngine.Rendering.GraphicsSettings.defaultGateFitMode = _value.Read<global::UnityEngine.Camera.GateFitMode>();  return true;
                case "defaultRenderPipeline": global::UnityEngine.Rendering.GraphicsSettings.defaultRenderPipeline = _value.Read<global::Luny.UnityEngine.Rendering.LuaRenderPipelineAsset>().Instance;  return true;
                case "disableBuiltinCustomRenderTextureUpdate": global::UnityEngine.Rendering.GraphicsSettings.disableBuiltinCustomRenderTextureUpdate = _value.Read<global::System.Boolean>();  return true;
                case "lightProbeOutsideHullStrategy": global::UnityEngine.Rendering.GraphicsSettings.lightProbeOutsideHullStrategy = _value.Read<global::UnityEngine.Rendering.LightProbeOutsideHullStrategy>();  return true;
                case "lightsUseColorTemperature": global::UnityEngine.Rendering.GraphicsSettings.lightsUseColorTemperature = _value.Read<global::System.Boolean>();  return true;
                case "lightsUseLinearIntensity": global::UnityEngine.Rendering.GraphicsSettings.lightsUseLinearIntensity = _value.Read<global::System.Boolean>();  return true;
                case "logWhenShaderIsCompiled": global::UnityEngine.Rendering.GraphicsSettings.logWhenShaderIsCompiled = _value.Read<global::System.Boolean>();  return true;
                case "realtimeDirectRectangularAreaLights": global::UnityEngine.Rendering.GraphicsSettings.realtimeDirectRectangularAreaLights = _value.Read<global::System.Boolean>();  return true;
                case "transparencySortAxis": global::UnityEngine.Rendering.GraphicsSettings.transparencySortAxis = _value.Read<global::Luny.UnityEngine.LuaVector3>().Value;  return true;
                case "transparencySortMode": global::UnityEngine.Rendering.GraphicsSettings.transparencySortMode = _value.Read<global::UnityEngine.TransparencySortMode>();  return true;
                case "useScriptableRenderPipelineBatching": global::UnityEngine.Rendering.GraphicsSettings.useScriptableRenderPipelineBatching = _value.Read<global::System.Boolean>();  return true;
                default: return false;
            }
        }
    }
}
#pragma warning restore 0109, 0162, 0168, 0219
#endif
