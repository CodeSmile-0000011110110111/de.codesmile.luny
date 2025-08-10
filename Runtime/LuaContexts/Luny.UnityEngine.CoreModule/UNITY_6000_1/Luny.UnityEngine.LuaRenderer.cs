
// --------------------------------------------------------------
// GENERATED FILE ----> DO NOT EDIT <---- CHANGES WILL BE LOST !!
// --------------------------------------------------------------

#if UNITY_6000_1_OR_NEWER && !(UNITY_6000_2_OR_NEWER)
#pragma warning disable 0109, 0162, 0168, 0219
using Luny;

namespace Luny.UnityEngine
{
    public class LuaRenderer : LuaComponent, global::Luny.ILuaObject<global::UnityEngine.Renderer>
    {
        public new static global::Lua.LuaValue Bind(global::UnityEngine.Renderer instance) => new LuaRenderer(instance);
        public new static global::Lua.LuaValue Bind(global::System.Object instance) => Bind((global::UnityEngine.Renderer)instance);
        public new static global::Lua.LuaValue Bind(global::System.Collections.Generic.IList<global::UnityEngine.Renderer> instances) =>
            new global::Luny.LuaList<global::UnityEngine.Renderer>(instances);
        public new static global::Lua.LuaValue Bind(global::System.Collections.Generic.IList<global::System.Object> instances) =>
            new global::Luny.LuaList<global::UnityEngine.Renderer>(instances);
        protected LuaRenderer(global::UnityEngine.Renderer instance) : base(instance) {}
        public static implicit operator global::Lua.LuaValue(LuaRenderer value) => new(value);
        public new global::UnityEngine.Renderer Instance => (global::UnityEngine.Renderer)m_Instance;
        public new global::System.Type BindType => typeof(global::UnityEngine.Renderer);
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

        private static readonly global::Lua.LuaFunction _LuaRenderer_GetPropertyBlock = new global::Lua.LuaFunction("GetPropertyBlock", (_context, _) =>
        {
            global::Lua.LuaValue _lastArg = default;
            global::System.Int32 _lastArgPos = default;
            global::System.Type _expectedType = default;
            var _argCount = _context.ArgumentCount;
            var _this = _context.GetArgument<LuaRenderer>(0);
            var _arg0 = _lastArg = _argCount > 1 ? _context.GetArgument(1) : global::Lua.LuaValue.Nil;
            _lastArgPos = 0; _expectedType = typeof(global::Luny.UnityEngine.LuaMaterialPropertyBlock);
            if (_arg0.TryRead<global::Luny.UnityEngine.LuaMaterialPropertyBlock>(out var _p0_UnityEngine_MaterialPropertyBlock))
            {
                if (_argCount == 2)
                {
                    var properties = _p0_UnityEngine_MaterialPropertyBlock.Instance;
                    _this.Instance.GetPropertyBlock(properties);
                    var _retCount = _context.Return();
                    return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                }
                var _arg1 = _lastArg = _argCount > 2 ? _context.GetArgument(2) : global::Lua.LuaValue.Nil;
                _lastArgPos = 1; _expectedType = typeof(global::System.Int32);
                if (_arg1.TryRead<global::System.Int32>(out var _p1_System_Int32))
                {
                    if (_argCount == 3)
                    {
                        var properties = _p0_UnityEngine_MaterialPropertyBlock.Instance;
                        var materialIndex = _p1_System_Int32;
                        _this.Instance.GetPropertyBlock(properties, materialIndex);
                        var _retCount = _context.Return();
                        return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                    }
                }
            }
            throw new global::Lua.LuaRuntimeException(_context.Thread, $"{"GetPropertyBlock"}: invalid argument #{_lastArgPos}: {_lastArg} ({_lastArg.Type}), expected: {_expectedType.FullName}", 2);
        });
        private static readonly global::Lua.LuaFunction _LuaRenderer_HasPropertyBlock = new global::Lua.LuaFunction("HasPropertyBlock", (_context, _) =>
        {
            global::Lua.LuaValue _lastArg = default;
            global::System.Int32 _lastArgPos = default;
            global::System.Type _expectedType = default;
            var _argCount = _context.ArgumentCount;
            var _this = _context.GetArgument<LuaRenderer>(0);
            if (_argCount == 1)
            {
                var _ret0 = _this.Instance.HasPropertyBlock();
                var _lret0 = new global::Lua.LuaValue(_ret0);
                var _retCount = _context.Return(_lret0);
                return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
            }
            throw new global::Lua.LuaRuntimeException(_context.Thread, $"{"HasPropertyBlock"}: invalid argument #{_lastArgPos}: {_lastArg} ({_lastArg.Type}), expected: {_expectedType.FullName}", 2);
        });
        private static readonly global::Lua.LuaFunction _LuaRenderer_ResetBounds = new global::Lua.LuaFunction("ResetBounds", (_context, _) =>
        {
            global::Lua.LuaValue _lastArg = default;
            global::System.Int32 _lastArgPos = default;
            global::System.Type _expectedType = default;
            var _argCount = _context.ArgumentCount;
            var _this = _context.GetArgument<LuaRenderer>(0);
            if (_argCount == 1)
            {
                _this.Instance.ResetBounds();
                var _retCount = _context.Return();
                return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
            }
            throw new global::Lua.LuaRuntimeException(_context.Thread, $"{"ResetBounds"}: invalid argument #{_lastArgPos}: {_lastArg} ({_lastArg.Type}), expected: {_expectedType.FullName}", 2);
        });
        private static readonly global::Lua.LuaFunction _LuaRenderer_ResetLocalBounds = new global::Lua.LuaFunction("ResetLocalBounds", (_context, _) =>
        {
            global::Lua.LuaValue _lastArg = default;
            global::System.Int32 _lastArgPos = default;
            global::System.Type _expectedType = default;
            var _argCount = _context.ArgumentCount;
            var _this = _context.GetArgument<LuaRenderer>(0);
            if (_argCount == 1)
            {
                _this.Instance.ResetLocalBounds();
                var _retCount = _context.Return();
                return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
            }
            throw new global::Lua.LuaRuntimeException(_context.Thread, $"{"ResetLocalBounds"}: invalid argument #{_lastArgPos}: {_lastArg} ({_lastArg.Type}), expected: {_expectedType.FullName}", 2);
        });
        private static readonly global::Lua.LuaFunction _LuaRenderer_SetPropertyBlock = new global::Lua.LuaFunction("SetPropertyBlock", (_context, _) =>
        {
            global::Lua.LuaValue _lastArg = default;
            global::System.Int32 _lastArgPos = default;
            global::System.Type _expectedType = default;
            var _argCount = _context.ArgumentCount;
            var _this = _context.GetArgument<LuaRenderer>(0);
            var _arg0 = _lastArg = _argCount > 1 ? _context.GetArgument(1) : global::Lua.LuaValue.Nil;
            _lastArgPos = 0; _expectedType = typeof(global::Luny.UnityEngine.LuaMaterialPropertyBlock);
            if (_arg0.TryRead<global::Luny.UnityEngine.LuaMaterialPropertyBlock>(out var _p0_UnityEngine_MaterialPropertyBlock))
            {
                if (_argCount == 2)
                {
                    var properties = _p0_UnityEngine_MaterialPropertyBlock.Instance;
                    _this.Instance.SetPropertyBlock(properties);
                    var _retCount = _context.Return();
                    return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                }
                var _arg1 = _lastArg = _argCount > 2 ? _context.GetArgument(2) : global::Lua.LuaValue.Nil;
                _lastArgPos = 1; _expectedType = typeof(global::System.Int32);
                if (_arg1.TryRead<global::System.Int32>(out var _p1_System_Int32))
                {
                    if (_argCount == 3)
                    {
                        var properties = _p0_UnityEngine_MaterialPropertyBlock.Instance;
                        var materialIndex = _p1_System_Int32;
                        _this.Instance.SetPropertyBlock(properties, materialIndex);
                        var _retCount = _context.Return();
                        return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                    }
                }
            }
            throw new global::Lua.LuaRuntimeException(_context.Thread, $"{"SetPropertyBlock"}: invalid argument #{_lastArgPos}: {_lastArg} ({_lastArg.Type}), expected: {_expectedType.FullName}", 2);
        });
        private static readonly global::Lua.LuaFunction __index = new(global::Lua.Runtime.Metamethods.Index, (_context, _) =>
        {
            var _this = _context.GetArgument<LuaRenderer>(0);
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
            var _this = _context.GetArgument<LuaRenderer>(0);
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
                case "GetPropertyBlock": _value = _LuaRenderer_GetPropertyBlock; return true;
                case "HasPropertyBlock": _value = _LuaRenderer_HasPropertyBlock; return true;
                case "ResetBounds": _value = _LuaRenderer_ResetBounds; return true;
                case "ResetLocalBounds": _value = _LuaRenderer_ResetLocalBounds; return true;
                case "SetPropertyBlock": _value = _LuaRenderer_SetPropertyBlock; return true;
                case "allowOcclusionWhenDynamic": _value = new global::Lua.LuaValue(Instance.allowOcclusionWhenDynamic); return true;
                case "bounds": _value = global::Luny.UnityEngine.LuaBounds.Bind(Instance.bounds); return true;
                case "enabled": _value = new global::Lua.LuaValue(Instance.enabled); return true;
                case "forceRenderingOff": _value = new global::Lua.LuaValue(Instance.forceRenderingOff); return true;
                case "isLOD0": _value = new global::Lua.LuaValue(Instance.isLOD0); return true;
                case "isPartOfStaticBatch": _value = new global::Lua.LuaValue(Instance.isPartOfStaticBatch); return true;
                case "isVisible": _value = new global::Lua.LuaValue(Instance.isVisible); return true;
                case "lightmapIndex": _value = new global::Lua.LuaValue(Instance.lightmapIndex); return true;
                case "lightmapScaleOffset": _value = global::Luny.UnityEngine.LuaVector4.Bind(Instance.lightmapScaleOffset); return true;
                case "lightProbeProxyVolumeOverride": _value = _factory.Bind(Instance.lightProbeProxyVolumeOverride); return true;
                case "lightProbeUsage": _value = new global::Lua.LuaValue((global::System.Int64)Instance.lightProbeUsage); return true;
                case "localBounds": _value = global::Luny.UnityEngine.LuaBounds.Bind(Instance.localBounds); return true;
                case "localToWorldMatrix": _value = global::Luny.UnityEngine.LuaMatrix4x4.Bind(Instance.localToWorldMatrix); return true;
                case "LODGroup": _value = _factory.Bind(Instance.LODGroup); return true;
                case "material": _value = _factory.Bind(Instance.material); return true;
                case "materials": _value = _factory.Bind(Instance.materials); return true;
                case "motionVectorGenerationMode": _value = new global::Lua.LuaValue((global::System.Int64)Instance.motionVectorGenerationMode); return true;
                case "probeAnchor": _value = _factory.Bind(Instance.probeAnchor); return true;
                case "rayTracingAccelerationStructureBuildFlags": _value = new global::Lua.LuaValue((global::System.Int64)Instance.rayTracingAccelerationStructureBuildFlags); return true;
                case "rayTracingAccelerationStructureBuildFlagsOverride": _value = new global::Lua.LuaValue(Instance.rayTracingAccelerationStructureBuildFlagsOverride); return true;
                case "rayTracingMode": _value = new global::Lua.LuaValue((global::System.Int64)Instance.rayTracingMode); return true;
                case "realtimeLightmapIndex": _value = new global::Lua.LuaValue(Instance.realtimeLightmapIndex); return true;
                case "realtimeLightmapScaleOffset": _value = global::Luny.UnityEngine.LuaVector4.Bind(Instance.realtimeLightmapScaleOffset); return true;
                case "receiveShadows": _value = new global::Lua.LuaValue(Instance.receiveShadows); return true;
                case "reflectionProbeUsage": _value = new global::Lua.LuaValue((global::System.Int64)Instance.reflectionProbeUsage); return true;
                case "rendererPriority": _value = new global::Lua.LuaValue(Instance.rendererPriority); return true;
                case "renderingLayerMask": _value = new global::Lua.LuaValue(Instance.renderingLayerMask); return true;
                case "shadowCastingMode": _value = new global::Lua.LuaValue((global::System.Int64)Instance.shadowCastingMode); return true;
                case "sharedMaterial": _value = _factory.Bind(Instance.sharedMaterial); return true;
                case "sharedMaterials": _value = _factory.Bind(Instance.sharedMaterials); return true;
                case "sortingLayerID": _value = new global::Lua.LuaValue(Instance.sortingLayerID); return true;
                case "sortingLayerName": _value = new global::Lua.LuaValue(Instance.sortingLayerName); return true;
                case "sortingOrder": _value = new global::Lua.LuaValue(Instance.sortingOrder); return true;
                case "staticShadowCaster": _value = new global::Lua.LuaValue(Instance.staticShadowCaster); return true;
                case "worldToLocalMatrix": _value = global::Luny.UnityEngine.LuaMatrix4x4.Bind(Instance.worldToLocalMatrix); return true;
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
                case "allowOcclusionWhenDynamic": Instance.allowOcclusionWhenDynamic = _value.Read<global::System.Boolean>();  return true;
                case "bounds": Instance.bounds = _value.Read<global::Luny.UnityEngine.LuaBounds>().Value;  return true;
                case "enabled": Instance.enabled = _value.Read<global::System.Boolean>();  return true;
                case "forceRenderingOff": Instance.forceRenderingOff = _value.Read<global::System.Boolean>();  return true;
                case "lightmapIndex": Instance.lightmapIndex = _value.Read<global::System.Int32>();  return true;
                case "lightmapScaleOffset": Instance.lightmapScaleOffset = _value.Read<global::Luny.UnityEngine.LuaVector4>().Value;  return true;
                case "lightProbeProxyVolumeOverride": Instance.lightProbeProxyVolumeOverride = _value.Read<global::Luny.UnityEngine.LuaGameObject>().Instance;  return true;
                case "lightProbeUsage": Instance.lightProbeUsage = _value.Read<global::UnityEngine.Rendering.LightProbeUsage>();  return true;
                case "localBounds": Instance.localBounds = _value.Read<global::Luny.UnityEngine.LuaBounds>().Value;  return true;
                case "material": Instance.material = _value.Read<global::Luny.UnityEngine.LuaMaterial>().Instance;  return true;
                case "materials": Instance.materials = _value.Read<global::UnityEngine.Material[]>();  return true;
                case "motionVectorGenerationMode": Instance.motionVectorGenerationMode = _value.Read<global::UnityEngine.MotionVectorGenerationMode>();  return true;
                case "probeAnchor": Instance.probeAnchor = _value.Read<global::Luny.UnityEngine.LuaTransform>().Instance;  return true;
                case "rayTracingAccelerationStructureBuildFlags": Instance.rayTracingAccelerationStructureBuildFlags = _value.Read<global::UnityEngine.Rendering.RayTracingAccelerationStructureBuildFlags>();  return true;
                case "rayTracingAccelerationStructureBuildFlagsOverride": Instance.rayTracingAccelerationStructureBuildFlagsOverride = _value.Read<global::System.Boolean>();  return true;
                case "rayTracingMode": Instance.rayTracingMode = _value.Read<global::UnityEngine.Experimental.Rendering.RayTracingMode>();  return true;
                case "realtimeLightmapIndex": Instance.realtimeLightmapIndex = _value.Read<global::System.Int32>();  return true;
                case "realtimeLightmapScaleOffset": Instance.realtimeLightmapScaleOffset = _value.Read<global::Luny.UnityEngine.LuaVector4>().Value;  return true;
                case "receiveShadows": Instance.receiveShadows = _value.Read<global::System.Boolean>();  return true;
                case "reflectionProbeUsage": Instance.reflectionProbeUsage = _value.Read<global::UnityEngine.Rendering.ReflectionProbeUsage>();  return true;
                case "rendererPriority": Instance.rendererPriority = _value.Read<global::System.Int32>();  return true;
                case "renderingLayerMask": Instance.renderingLayerMask = _value.Read<global::System.UInt32>();  return true;
                case "shadowCastingMode": Instance.shadowCastingMode = _value.Read<global::UnityEngine.Rendering.ShadowCastingMode>();  return true;
                case "sharedMaterial": Instance.sharedMaterial = _value.Read<global::Luny.UnityEngine.LuaMaterial>().Instance;  return true;
                case "sharedMaterials": Instance.sharedMaterials = _value.Read<global::UnityEngine.Material[]>();  return true;
                case "sortingLayerID": Instance.sortingLayerID = _value.Read<global::System.Int32>();  return true;
                case "sortingLayerName": Instance.sortingLayerName = _value.Read<global::System.String>();  return true;
                case "sortingOrder": Instance.sortingOrder = _value.Read<global::System.Int32>();  return true;
                case "staticShadowCaster": Instance.staticShadowCaster = _value.Read<global::System.Boolean>();  return true;
                default: return base.TrySetLuaValue(_key, _value);
            }
        }
    }
    public sealed class LuaRendererType : global::Luny.ILuaStatic
    {
        public static global::Lua.LuaValue Bind() => new LuaRendererType();
        private LuaRendererType() {}
        public static implicit operator global::Lua.LuaValue(LuaRendererType value) => new(value);
        public global::System.Type BindType => typeof(global::UnityEngine.Renderer);
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

        private static readonly global::Lua.LuaFunction _LuaRenderer_new = new global::Lua.LuaFunction(".ctor", (_context, _) =>
        {
            global::Lua.LuaValue _lastArg = default;
            global::System.Int32 _lastArgPos = default;
            global::System.Type _expectedType = default;
            var _argCount = _context.ArgumentCount;
            if (_argCount == 0)
            {
                var _ret0 = new global::UnityEngine.Renderer();
                var _factory = _context.GetObjectFactory();
                var _lret0 = _factory.Bind(_ret0);
                var _retCount = _context.Return(_lret0);
                return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
            }
            throw new global::Lua.LuaRuntimeException(_context.Thread, $"{".ctor"}: invalid argument #{_lastArgPos}: {_lastArg} ({_lastArg.Type}), expected: {_expectedType.FullName}", 2);
        });
        private static readonly global::Lua.LuaFunction __index = new(global::Lua.Runtime.Metamethods.Index, (_context, _) =>
        {
            var _this = _context.GetArgument<LuaRendererType>(0);
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
            var _this = _context.GetArgument<LuaRendererType>(0);
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
                case "new": _value = _LuaRenderer_new; return true;
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
}
#pragma warning restore 0109, 0162, 0168, 0219
#endif
