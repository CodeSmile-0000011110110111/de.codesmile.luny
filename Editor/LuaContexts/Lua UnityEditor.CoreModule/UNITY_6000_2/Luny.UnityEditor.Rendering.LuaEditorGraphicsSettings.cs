
// --------------------------------------------------------------
// GENERATED FILE ----> DO NOT EDIT <---- CHANGES WILL BE LOST !!
// --------------------------------------------------------------

#if UNITY_6000_2_OR_NEWER && !(UNITY_6000_3_OR_NEWER)
#pragma warning disable 0109, 0162, 0168, 0219
using Luny;

namespace Luny.UnityEditor.Rendering
{
    public sealed class LuaEditorGraphicsSettings : global::Luny.ILuaObject<global::UnityEditor.Rendering.EditorGraphicsSettings>
    {
        public new static global::Lua.LuaValue Bind(global::UnityEditor.Rendering.EditorGraphicsSettings instance) => new LuaEditorGraphicsSettings(instance);
        public new static global::Lua.LuaValue Bind(global::System.Object instance) => Bind((global::UnityEditor.Rendering.EditorGraphicsSettings)instance);
        public new static global::Lua.LuaValue Bind(global::System.Collections.Generic.IList<global::UnityEditor.Rendering.EditorGraphicsSettings> instances) =>
            new global::Luny.LuaList<global::UnityEditor.Rendering.EditorGraphicsSettings>(instances);
        public new static global::Lua.LuaValue Bind(global::System.Collections.Generic.IList<global::System.Object> instances) =>
            new global::Luny.LuaList<global::UnityEditor.Rendering.EditorGraphicsSettings>(instances);
        private LuaEditorGraphicsSettings(global::UnityEditor.Rendering.EditorGraphicsSettings instance) => m_Instance = instance;
        public static implicit operator global::Lua.LuaValue(LuaEditorGraphicsSettings value) => new(value);
        private global::UnityEditor.Rendering.EditorGraphicsSettings m_Instance;
        public global::UnityEditor.Rendering.EditorGraphicsSettings Instance => m_Instance;
        public new global::System.Type BindType => typeof(global::UnityEditor.Rendering.EditorGraphicsSettings);
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
            var _this = _context.GetArgument<LuaEditorGraphicsSettings>(0);
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
            var _this = _context.GetArgument<LuaEditorGraphicsSettings>(0);
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
    public sealed class LuaEditorGraphicsSettingsType : global::Luny.ILuaStatic
    {
        public static global::Lua.LuaValue Bind() => new LuaEditorGraphicsSettingsType();
        private LuaEditorGraphicsSettingsType() {}
        public static implicit operator global::Lua.LuaValue(LuaEditorGraphicsSettingsType value) => new(value);
        public global::System.Type BindType => typeof(global::UnityEditor.Rendering.EditorGraphicsSettings);
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

        private static readonly global::Lua.LuaFunction _LuaEditorGraphicsSettings_new = new global::Lua.LuaFunction(".ctor", (_context, _) =>
        {
            global::Lua.LuaValue _lastArg = default;
            global::System.Int32 _lastArgPos = default;
            global::System.Type _expectedType = default;
            var _argCount = _context.ArgumentCount;
            if (_argCount == 0)
            {
                var _ret0 = new global::UnityEditor.Rendering.EditorGraphicsSettings();
                var _factory = _context.GetObjectFactory();
                var _lret0 = _factory.Bind(_ret0);
                var _retCount = _context.Return(_lret0);
                return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
            }
            throw new global::Lua.LuaRuntimeException(_context.Thread, $"{".ctor"}: invalid argument #{_lastArgPos}: {_lastArg} ({_lastArg.Type}), expected: {_expectedType.FullName}", 2);
        });
        private static readonly global::Lua.LuaFunction _LuaEditorGraphicsSettings_GetRenderPipelineGlobalSettingsAsset = new global::Lua.LuaFunction("GetRenderPipelineGlobalSettingsAsset", (_context, _) =>
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
                    var _ret0 = global::UnityEditor.Rendering.EditorGraphicsSettings.GetRenderPipelineGlobalSettingsAsset(renderPipelineType);
                    var _factory = _context.GetObjectFactory();
                    var _lret0 = _factory.Bind(_ret0);
                    var _retCount = _context.Return(_lret0);
                    return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                }
            }
            throw new global::Lua.LuaRuntimeException(_context.Thread, $"{"GetRenderPipelineGlobalSettingsAsset"}: invalid argument #{_lastArgPos}: {_lastArg} ({_lastArg.Type}), expected: {_expectedType.FullName}", 2);
        });
        private static readonly global::Lua.LuaFunction _LuaEditorGraphicsSettings_GetTierSettings = new global::Lua.LuaFunction("GetTierSettings", (_context, _) =>
        {
            global::Lua.LuaValue _lastArg = default;
            global::System.Int32 _lastArgPos = default;
            global::System.Type _expectedType = default;
            var _argCount = _context.ArgumentCount;
            var _arg0 = _lastArg = _argCount > 0 ? _context.GetArgument(0) : global::Lua.LuaValue.Nil;
            _lastArgPos = 0; _expectedType = typeof(global::UnityEditor.BuildTargetGroup);
            if (_arg0.TryRead<global::UnityEditor.BuildTargetGroup>(out var _p0_UnityEditor_BuildTargetGroup))
            {
                var _arg1 = _lastArg = _argCount > 1 ? _context.GetArgument(1) : global::Lua.LuaValue.Nil;
                _lastArgPos = 1; _expectedType = typeof(global::UnityEngine.Rendering.GraphicsTier);
                if (_arg1.TryRead<global::UnityEngine.Rendering.GraphicsTier>(out var _p1_UnityEngine_Rendering_GraphicsTier))
                {
                    if (_argCount == 2)
                    {
                        var target = _p0_UnityEditor_BuildTargetGroup;
                        var tier = _p1_UnityEngine_Rendering_GraphicsTier;
                        var _ret0 = global::UnityEditor.Rendering.EditorGraphicsSettings.GetTierSettings(target, tier);
                        var _lret0 = global::Luny.UnityEditor.Rendering.LuaTierSettings.Bind(_ret0);
                        var _retCount = _context.Return(_lret0);
                        return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                    }
                }
            }
            _lastArgPos = 0; _expectedType = typeof(global::Luny.UnityEditor.Build.LuaNamedBuildTarget);
            if (_arg0.TryRead<global::Luny.UnityEditor.Build.LuaNamedBuildTarget>(out var _p0_UnityEditor_Build_NamedBuildTarget))
            {
                var _arg1 = _lastArg = _argCount > 1 ? _context.GetArgument(1) : global::Lua.LuaValue.Nil;
                _lastArgPos = 1; _expectedType = typeof(global::UnityEngine.Rendering.GraphicsTier);
                if (_arg1.TryRead<global::UnityEngine.Rendering.GraphicsTier>(out var _p1_UnityEngine_Rendering_GraphicsTier))
                {
                    if (_argCount == 2)
                    {
                        var target = _p0_UnityEditor_Build_NamedBuildTarget.Value;
                        var tier = _p1_UnityEngine_Rendering_GraphicsTier;
                        var _ret0 = global::UnityEditor.Rendering.EditorGraphicsSettings.GetTierSettings(target, tier);
                        var _lret0 = global::Luny.UnityEditor.Rendering.LuaTierSettings.Bind(_ret0);
                        var _retCount = _context.Return(_lret0);
                        return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                    }
                }
            }
            throw new global::Lua.LuaRuntimeException(_context.Thread, $"{"GetTierSettings"}: invalid argument #{_lastArgPos}: {_lastArg} ({_lastArg.Type}), expected: {_expectedType.FullName}", 2);
        });
        private static readonly global::Lua.LuaFunction _LuaEditorGraphicsSettings_PopulateRenderPipelineGraphicsSettings = new global::Lua.LuaFunction("PopulateRenderPipelineGraphicsSettings", (_context, _) =>
        {
            global::Lua.LuaValue _lastArg = default;
            global::System.Int32 _lastArgPos = default;
            global::System.Type _expectedType = default;
            var _argCount = _context.ArgumentCount;
            var _arg0 = _lastArg = _argCount > 0 ? _context.GetArgument(0) : global::Lua.LuaValue.Nil;
            _lastArgPos = 0; _expectedType = typeof(global::UnityEngine.Rendering.RenderPipelineGlobalSettings);
            if (_arg0.TryRead<global::UnityEngine.Rendering.RenderPipelineGlobalSettings>(out var _p0_UnityEngine_Rendering_RenderPipelineGlobalSettings))
            {
                if (_argCount == 1)
                {
                    var settings = _p0_UnityEngine_Rendering_RenderPipelineGlobalSettings;
                    global::UnityEditor.Rendering.EditorGraphicsSettings.PopulateRenderPipelineGraphicsSettings(settings);
                    var _retCount = _context.Return();
                    return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                }
            }
            throw new global::Lua.LuaRuntimeException(_context.Thread, $"{"PopulateRenderPipelineGraphicsSettings"}: invalid argument #{_lastArgPos}: {_lastArg} ({_lastArg.Type}), expected: {_expectedType.FullName}", 2);
        });
        private static readonly global::Lua.LuaFunction _LuaEditorGraphicsSettings_SetRenderPipelineGlobalSettingsAsset = new global::Lua.LuaFunction("SetRenderPipelineGlobalSettingsAsset", (_context, _) =>
        {
            global::Lua.LuaValue _lastArg = default;
            global::System.Int32 _lastArgPos = default;
            global::System.Type _expectedType = default;
            var _argCount = _context.ArgumentCount;
            var _arg0 = _lastArg = _argCount > 0 ? _context.GetArgument(0) : global::Lua.LuaValue.Nil;
            _lastArgPos = 0; _expectedType = typeof(global::Luny.ILuaBindType);
            if (_arg0.TryRead<global::Luny.ILuaBindType>(out var _p0_System_Type))
            {
                var _arg1 = _lastArg = _argCount > 1 ? _context.GetArgument(1) : global::Lua.LuaValue.Nil;
                _lastArgPos = 1; _expectedType = typeof(global::UnityEngine.Rendering.RenderPipelineGlobalSettings);
                if (_arg1.TryRead<global::UnityEngine.Rendering.RenderPipelineGlobalSettings>(out var _p1_UnityEngine_Rendering_RenderPipelineGlobalSettings))
                {
                    if (_argCount == 2)
                    {
                        var renderPipelineType = _p0_System_Type.BindType;
                        var newSettings = _p1_UnityEngine_Rendering_RenderPipelineGlobalSettings;
                        global::UnityEditor.Rendering.EditorGraphicsSettings.SetRenderPipelineGlobalSettingsAsset(renderPipelineType, newSettings);
                        var _retCount = _context.Return();
                        return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                    }
                }
            }
            throw new global::Lua.LuaRuntimeException(_context.Thread, $"{"SetRenderPipelineGlobalSettingsAsset"}: invalid argument #{_lastArgPos}: {_lastArg} ({_lastArg.Type}), expected: {_expectedType.FullName}", 2);
        });
        private static readonly global::Lua.LuaFunction _LuaEditorGraphicsSettings_SetTierSettings = new global::Lua.LuaFunction("SetTierSettings", (_context, _) =>
        {
            global::Lua.LuaValue _lastArg = default;
            global::System.Int32 _lastArgPos = default;
            global::System.Type _expectedType = default;
            var _argCount = _context.ArgumentCount;
            var _arg0 = _lastArg = _argCount > 0 ? _context.GetArgument(0) : global::Lua.LuaValue.Nil;
            _lastArgPos = 0; _expectedType = typeof(global::UnityEditor.BuildTargetGroup);
            if (_arg0.TryRead<global::UnityEditor.BuildTargetGroup>(out var _p0_UnityEditor_BuildTargetGroup))
            {
                var _arg1 = _lastArg = _argCount > 1 ? _context.GetArgument(1) : global::Lua.LuaValue.Nil;
                _lastArgPos = 1; _expectedType = typeof(global::UnityEngine.Rendering.GraphicsTier);
                if (_arg1.TryRead<global::UnityEngine.Rendering.GraphicsTier>(out var _p1_UnityEngine_Rendering_GraphicsTier))
                {
                    var _arg2 = _lastArg = _argCount > 2 ? _context.GetArgument(2) : global::Lua.LuaValue.Nil;
                    _lastArgPos = 2; _expectedType = typeof(global::Luny.UnityEditor.Rendering.LuaTierSettings);
                    if (_arg2.TryRead<global::Luny.UnityEditor.Rendering.LuaTierSettings>(out var _p2_UnityEditor_Rendering_TierSettings))
                    {
                        if (_argCount == 3)
                        {
                            var target = _p0_UnityEditor_BuildTargetGroup;
                            var tier = _p1_UnityEngine_Rendering_GraphicsTier;
                            var settings = _p2_UnityEditor_Rendering_TierSettings.Value;
                            global::UnityEditor.Rendering.EditorGraphicsSettings.SetTierSettings(target, tier, settings);
                            var _retCount = _context.Return();
                            return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                        }
                    }
                }
            }
            _lastArgPos = 0; _expectedType = typeof(global::Luny.UnityEditor.Build.LuaNamedBuildTarget);
            if (_arg0.TryRead<global::Luny.UnityEditor.Build.LuaNamedBuildTarget>(out var _p0_UnityEditor_Build_NamedBuildTarget))
            {
                var _arg1 = _lastArg = _argCount > 1 ? _context.GetArgument(1) : global::Lua.LuaValue.Nil;
                _lastArgPos = 1; _expectedType = typeof(global::UnityEngine.Rendering.GraphicsTier);
                if (_arg1.TryRead<global::UnityEngine.Rendering.GraphicsTier>(out var _p1_UnityEngine_Rendering_GraphicsTier))
                {
                    var _arg2 = _lastArg = _argCount > 2 ? _context.GetArgument(2) : global::Lua.LuaValue.Nil;
                    _lastArgPos = 2; _expectedType = typeof(global::Luny.UnityEditor.Rendering.LuaTierSettings);
                    if (_arg2.TryRead<global::Luny.UnityEditor.Rendering.LuaTierSettings>(out var _p2_UnityEditor_Rendering_TierSettings))
                    {
                        if (_argCount == 3)
                        {
                            var target = _p0_UnityEditor_Build_NamedBuildTarget.Value;
                            var tier = _p1_UnityEngine_Rendering_GraphicsTier;
                            var settings = _p2_UnityEditor_Rendering_TierSettings.Value;
                            global::UnityEditor.Rendering.EditorGraphicsSettings.SetTierSettings(target, tier, settings);
                            var _retCount = _context.Return();
                            return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                        }
                    }
                }
            }
            throw new global::Lua.LuaRuntimeException(_context.Thread, $"{"SetTierSettings"}: invalid argument #{_lastArgPos}: {_lastArg} ({_lastArg.Type}), expected: {_expectedType.FullName}", 2);
        });
        private static readonly global::Lua.LuaFunction __index = new(global::Lua.Runtime.Metamethods.Index, (_context, _) =>
        {
            var _this = _context.GetArgument<LuaEditorGraphicsSettingsType>(0);
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
            var _this = _context.GetArgument<LuaEditorGraphicsSettingsType>(0);
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
                case "new": _value = _LuaEditorGraphicsSettings_new; return true;
                case "GetRenderPipelineGlobalSettingsAsset": _value = _LuaEditorGraphicsSettings_GetRenderPipelineGlobalSettingsAsset; return true;
                case "GetTierSettings": _value = _LuaEditorGraphicsSettings_GetTierSettings; return true;
                case "PopulateRenderPipelineGraphicsSettings": _value = _LuaEditorGraphicsSettings_PopulateRenderPipelineGraphicsSettings; return true;
                case "SetRenderPipelineGlobalSettingsAsset": _value = _LuaEditorGraphicsSettings_SetRenderPipelineGlobalSettingsAsset; return true;
                case "SetTierSettings": _value = _LuaEditorGraphicsSettings_SetTierSettings; return true;
                case "albedoSwatches": _value = _factory.Bind(global::UnityEditor.Rendering.EditorGraphicsSettings.albedoSwatches); return true;
                case "batchRendererGroupShaderStrippingMode": _value = new global::Lua.LuaValue((global::System.Int64)global::UnityEditor.Rendering.EditorGraphicsSettings.batchRendererGroupShaderStrippingMode); return true;
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
                case "albedoSwatches": global::UnityEditor.Rendering.EditorGraphicsSettings.albedoSwatches = _value.Read<global::UnityEditor.Rendering.AlbedoSwatchInfo[]>();  return true;
                default: return false;
            }
        }
    }
}
#pragma warning restore 0109, 0162, 0168, 0219
#endif
