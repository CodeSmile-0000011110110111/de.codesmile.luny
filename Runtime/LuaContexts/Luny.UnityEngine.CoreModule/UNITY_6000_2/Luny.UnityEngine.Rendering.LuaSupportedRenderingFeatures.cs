
// --------------------------------------------------------------
// GENERATED FILE ----> DO NOT EDIT <---- CHANGES WILL BE LOST !!
// --------------------------------------------------------------

#if UNITY_6000_2_OR_NEWER && !(UNITY_6000_3_OR_NEWER)
#pragma warning disable 0109, 0162, 0168, 0219
using Luny;

namespace Luny.UnityEngine.Rendering
{
    public class LuaSupportedRenderingFeatures : global::Luny.ILuaObject<global::UnityEngine.Rendering.SupportedRenderingFeatures>
    {
        public new static global::Lua.LuaValue Bind(global::UnityEngine.Rendering.SupportedRenderingFeatures instance) => new LuaSupportedRenderingFeatures(instance);
        public new static global::Lua.LuaValue Bind(global::System.Object instance) => Bind((global::UnityEngine.Rendering.SupportedRenderingFeatures)instance);
        public new static global::Lua.LuaValue Bind(global::System.Collections.Generic.IList<global::UnityEngine.Rendering.SupportedRenderingFeatures> instances) =>
            new global::Luny.LuaList<global::UnityEngine.Rendering.SupportedRenderingFeatures>(instances);
        public new static global::Lua.LuaValue Bind(global::System.Collections.Generic.IList<global::System.Object> instances) =>
            new global::Luny.LuaList<global::UnityEngine.Rendering.SupportedRenderingFeatures>(instances);
        protected LuaSupportedRenderingFeatures(global::UnityEngine.Rendering.SupportedRenderingFeatures instance) => m_Instance = instance;
        public static implicit operator global::Lua.LuaValue(LuaSupportedRenderingFeatures value) => new(value);
        protected global::UnityEngine.Rendering.SupportedRenderingFeatures m_Instance;
        public global::UnityEngine.Rendering.SupportedRenderingFeatures Instance => m_Instance;
        public new global::System.Type BindType => typeof(global::UnityEngine.Rendering.SupportedRenderingFeatures);
        public override global::System.String ToString() => m_Instance != null ? Instance.ToString() : "{GetType().Name}(null)";
#if UNITY_EDITOR
        [global::UnityEngine.RuntimeInitializeOnLoadMethod(global::UnityEngine.RuntimeInitializeLoadType.SubsystemRegistration)]
        private static void ResetStaticFields() => s_Metatable = null;
#endif

        private static readonly global::Lua.LuaFunction __index = new(global::Lua.Runtime.Metamethods.Index, (_context, _) =>
        {
            var _this = _context.GetArgument<LuaSupportedRenderingFeatures>(0);
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
            var _this = _context.GetArgument<LuaSupportedRenderingFeatures>(0);
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
                case "ambientProbeBaking": _value = new global::Lua.LuaValue(Instance.ambientProbeBaking); return true;
                case "defaultMixedLightingModes": _value = new global::Lua.LuaValue((global::System.Int64)Instance.defaultMixedLightingModes); return true;
                case "defaultReflectionProbeBaking": _value = new global::Lua.LuaValue(Instance.defaultReflectionProbeBaking); return true;
                case "editableMaterialRenderQueue": _value = new global::Lua.LuaValue(Instance.editableMaterialRenderQueue); return true;
                case "enlighten": _value = new global::Lua.LuaValue(Instance.enlighten); return true;
                case "lightmapBakeTypes": _value = new global::Lua.LuaValue((global::System.Int64)Instance.lightmapBakeTypes); return true;
                case "lightmapsModes": _value = new global::Lua.LuaValue((global::System.Int64)Instance.lightmapsModes); return true;
                case "lightProbeProxyVolumes": _value = new global::Lua.LuaValue(Instance.lightProbeProxyVolumes); return true;
                case "mixedLightingModes": _value = new global::Lua.LuaValue((global::System.Int64)Instance.mixedLightingModes); return true;
                case "motionVectors": _value = new global::Lua.LuaValue(Instance.motionVectors); return true;
                case "overridesEnableLODCrossFade": _value = new global::Lua.LuaValue(Instance.overridesEnableLODCrossFade); return true;
                case "overridesEnvironmentLighting": _value = new global::Lua.LuaValue(Instance.overridesEnvironmentLighting); return true;
                case "overridesFog": _value = new global::Lua.LuaValue(Instance.overridesFog); return true;
                case "overridesLightProbeSystem": _value = new global::Lua.LuaValue(Instance.overridesLightProbeSystem); return true;
                case "overridesLightProbeSystemWarningMessage": _value = new global::Lua.LuaValue(Instance.overridesLightProbeSystemWarningMessage); return true;
                case "overridesLODBias": _value = new global::Lua.LuaValue(Instance.overridesLODBias); return true;
                case "overridesMaximumLODLevel": _value = new global::Lua.LuaValue(Instance.overridesMaximumLODLevel); return true;
                case "overridesOtherLightingSettings": _value = new global::Lua.LuaValue(Instance.overridesOtherLightingSettings); return true;
                case "overridesRealtimeReflectionProbes": _value = new global::Lua.LuaValue(Instance.overridesRealtimeReflectionProbes); return true;
                case "overridesShadowmask": _value = new global::Lua.LuaValue(Instance.overridesShadowmask); return true;
                case "particleSystemInstancing": _value = new global::Lua.LuaValue(Instance.particleSystemInstancing); return true;
                case "receiveShadows": _value = new global::Lua.LuaValue(Instance.receiveShadows); return true;
                case "reflectionProbeModes": _value = new global::Lua.LuaValue((global::System.Int64)Instance.reflectionProbeModes); return true;
                case "reflectionProbes": _value = new global::Lua.LuaValue(Instance.reflectionProbes); return true;
                case "reflectionProbesBlendDistance": _value = new global::Lua.LuaValue(Instance.reflectionProbesBlendDistance); return true;
                case "rendererPriority": _value = new global::Lua.LuaValue(Instance.rendererPriority); return true;
                case "rendererProbes": _value = new global::Lua.LuaValue(Instance.rendererProbes); return true;
                case "rendersUIOverlay": _value = new global::Lua.LuaValue(Instance.rendersUIOverlay); return true;
                case "skyOcclusion": _value = new global::Lua.LuaValue(Instance.skyOcclusion); return true;
                case "supportsClouds": _value = new global::Lua.LuaValue(Instance.supportsClouds); return true;
                case "supportsHDR": _value = new global::Lua.LuaValue(Instance.supportsHDR); return true;
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
                case "ambientProbeBaking": Instance.ambientProbeBaking = _value.Read<global::System.Boolean>();  return true;
                case "defaultMixedLightingModes": Instance.defaultMixedLightingModes = _value.Read<global::UnityEngine.Rendering.SupportedRenderingFeatures.LightmapMixedBakeModes>();  return true;
                case "defaultReflectionProbeBaking": Instance.defaultReflectionProbeBaking = _value.Read<global::System.Boolean>();  return true;
                case "editableMaterialRenderQueue": Instance.editableMaterialRenderQueue = _value.Read<global::System.Boolean>();  return true;
                case "enlighten": Instance.enlighten = _value.Read<global::System.Boolean>();  return true;
                case "lightmapBakeTypes": Instance.lightmapBakeTypes = _value.Read<global::UnityEngine.LightmapBakeType>();  return true;
                case "lightmapsModes": Instance.lightmapsModes = _value.Read<global::UnityEngine.LightmapsMode>();  return true;
                case "lightProbeProxyVolumes": Instance.lightProbeProxyVolumes = _value.Read<global::System.Boolean>();  return true;
                case "mixedLightingModes": Instance.mixedLightingModes = _value.Read<global::UnityEngine.Rendering.SupportedRenderingFeatures.LightmapMixedBakeModes>();  return true;
                case "motionVectors": Instance.motionVectors = _value.Read<global::System.Boolean>();  return true;
                case "overridesEnableLODCrossFade": Instance.overridesEnableLODCrossFade = _value.Read<global::System.Boolean>();  return true;
                case "overridesEnvironmentLighting": Instance.overridesEnvironmentLighting = _value.Read<global::System.Boolean>();  return true;
                case "overridesFog": Instance.overridesFog = _value.Read<global::System.Boolean>();  return true;
                case "overridesLightProbeSystem": Instance.overridesLightProbeSystem = _value.Read<global::System.Boolean>();  return true;
                case "overridesLightProbeSystemWarningMessage": Instance.overridesLightProbeSystemWarningMessage = _value.Read<global::System.String>();  return true;
                case "overridesLODBias": Instance.overridesLODBias = _value.Read<global::System.Boolean>();  return true;
                case "overridesMaximumLODLevel": Instance.overridesMaximumLODLevel = _value.Read<global::System.Boolean>();  return true;
                case "overridesOtherLightingSettings": Instance.overridesOtherLightingSettings = _value.Read<global::System.Boolean>();  return true;
                case "overridesRealtimeReflectionProbes": Instance.overridesRealtimeReflectionProbes = _value.Read<global::System.Boolean>();  return true;
                case "overridesShadowmask": Instance.overridesShadowmask = _value.Read<global::System.Boolean>();  return true;
                case "particleSystemInstancing": Instance.particleSystemInstancing = _value.Read<global::System.Boolean>();  return true;
                case "receiveShadows": Instance.receiveShadows = _value.Read<global::System.Boolean>();  return true;
                case "reflectionProbeModes": Instance.reflectionProbeModes = _value.Read<global::UnityEngine.Rendering.SupportedRenderingFeatures.ReflectionProbeModes>();  return true;
                case "reflectionProbes": Instance.reflectionProbes = _value.Read<global::System.Boolean>();  return true;
                case "reflectionProbesBlendDistance": Instance.reflectionProbesBlendDistance = _value.Read<global::System.Boolean>();  return true;
                case "rendererPriority": Instance.rendererPriority = _value.Read<global::System.Boolean>();  return true;
                case "rendererProbes": Instance.rendererProbes = _value.Read<global::System.Boolean>();  return true;
                case "rendersUIOverlay": Instance.rendersUIOverlay = _value.Read<global::System.Boolean>();  return true;
                case "skyOcclusion": Instance.skyOcclusion = _value.Read<global::System.Boolean>();  return true;
                case "supportsClouds": Instance.supportsClouds = _value.Read<global::System.Boolean>();  return true;
                case "supportsHDR": Instance.supportsHDR = _value.Read<global::System.Boolean>();  return true;
                default: return false;
            }
        }
    }
    public sealed class LuaSupportedRenderingFeaturesType : global::Luny.ILuaStatic
    {
        public static global::Lua.LuaValue Bind() => new LuaSupportedRenderingFeaturesType();
        private LuaSupportedRenderingFeaturesType() {}
        public static implicit operator global::Lua.LuaValue(LuaSupportedRenderingFeaturesType value) => new(value);
        public global::System.Type BindType => typeof(global::UnityEngine.Rendering.SupportedRenderingFeatures);
        public override global::System.String ToString() => BindType.FullName;
#if UNITY_EDITOR
        [global::UnityEngine.RuntimeInitializeOnLoadMethod(global::UnityEngine.RuntimeInitializeLoadType.SubsystemRegistration)]
        private static void ResetStaticFields() => s_Metatable = null;
#endif

        private static readonly global::Lua.LuaFunction _LuaSupportedRenderingFeatures_new = new global::Lua.LuaFunction(".ctor", (_context, _) =>
        {
            global::Lua.LuaValue _lastArg = default;
            global::System.Int32 _lastArgPos = default;
            global::System.Type _expectedType = default;
            var _argCount = _context.ArgumentCount;
            if (_argCount == 1)
            {
                var _ret0 = new global::UnityEngine.Rendering.SupportedRenderingFeatures();
                var _factory = _context.GetObjectFactory();
                var _lret0 = _factory.Bind(_ret0);
                var _retCount = _context.Return(_lret0);
                return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
            }
            throw new global::Lua.LuaRuntimeException(_context.Thread, $"{".ctor"}: invalid argument #{_lastArgPos}: {_lastArg} ({_lastArg.Type}), expected: {_expectedType.FullName}", 2);
        });
        private static readonly global::Lua.LuaFunction __index = new(global::Lua.Runtime.Metamethods.Index, (_context, _) =>
        {
            var _this = _context.GetArgument<LuaSupportedRenderingFeaturesType>(0);
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
            var _this = _context.GetArgument<LuaSupportedRenderingFeaturesType>(0);
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
            metatable[global::Lua.Runtime.Metamethods.Call] = _LuaSupportedRenderingFeatures_new;
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
                case "active": _value = _factory.Bind(global::UnityEngine.Rendering.SupportedRenderingFeatures.active); return true;
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
                case "active": global::UnityEngine.Rendering.SupportedRenderingFeatures.active = _value.Read<global::Luny.UnityEngine.Rendering.LuaSupportedRenderingFeatures>().Instance;  return true;
                default: return false;
            }
        }
    }
}
#pragma warning restore 0109, 0162, 0168, 0219
#endif
