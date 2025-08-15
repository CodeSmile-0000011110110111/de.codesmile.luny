
// --------------------------------------------------------------
// GENERATED FILE ----> DO NOT EDIT <---- CHANGES WILL BE LOST !!
// --------------------------------------------------------------

#if UNITY_6000_2_OR_NEWER && !(UNITY_6000_3_OR_NEWER)
#pragma warning disable 0109, 0162, 0168, 0219
using Luny;

namespace Luny.UnityEngine
{
    public sealed class LuaLight : LuaBehaviour, global::Luny.ILuaObject<global::UnityEngine.Light>
    {
        public new static global::Lua.LuaValue Bind(global::UnityEngine.Light instance) => new LuaLight(instance);
        public new static global::Lua.LuaValue Bind(global::System.Object instance) => Bind((global::UnityEngine.Light)instance);
        public new static global::Lua.LuaValue Bind(global::System.Collections.Generic.IList<global::UnityEngine.Light> instances) =>
            new global::Luny.LuaList<global::UnityEngine.Light>(instances);
        public new static global::Lua.LuaValue Bind(global::System.Collections.Generic.IList<global::System.Object> instances) =>
            new global::Luny.LuaList<global::UnityEngine.Light>(instances);
        private LuaLight(global::UnityEngine.Light instance) : base(instance) {}
        public static implicit operator global::Lua.LuaValue(LuaLight value) => new(value);
        public new global::UnityEngine.Light Instance => (global::UnityEngine.Light)m_Instance;
        public new global::System.Type BindType => typeof(global::UnityEngine.Light);
        private static global::Lua.LuaTable s_Metatable;
        public new global::Lua.LuaTable Metatable
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

        private static readonly global::Lua.LuaFunction _LuaLight_AddCommandBuffer = new global::Lua.LuaFunction("AddCommandBuffer", (_context, _) =>
        {
            global::Lua.LuaValue _lastArg = default;
            global::System.Int32 _lastArgPos = default;
            global::System.Type _expectedType = default;
            var _argCount = _context.ArgumentCount;
            var _this = _context.GetArgument<LuaLight>(0);
            var _arg0 = _lastArg = _argCount > 1 ? _context.GetArgument(1) : global::Lua.LuaValue.Nil;
            _lastArgPos = 0; _expectedType = typeof(global::UnityEngine.Rendering.LightEvent);
            if (_arg0.TryRead<global::UnityEngine.Rendering.LightEvent>(out var _p0_UnityEngine_Rendering_LightEvent))
            {
                var _arg1 = _lastArg = _argCount > 2 ? _context.GetArgument(2) : global::Lua.LuaValue.Nil;
                _lastArgPos = 1; _expectedType = typeof(global::Luny.UnityEngine.Rendering.LuaCommandBuffer);
                if (_arg1.TryRead<global::Luny.UnityEngine.Rendering.LuaCommandBuffer>(out var _p1_UnityEngine_Rendering_CommandBuffer))
                {
                    if (_argCount == 3)
                    {
                        var evt = _p0_UnityEngine_Rendering_LightEvent;
                        var buffer = _p1_UnityEngine_Rendering_CommandBuffer.Instance;
                        _this.Instance.AddCommandBuffer(evt, buffer);
                        var _retCount = _context.Return();
                        return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                    }
                    var _arg2 = _lastArg = _argCount > 3 ? _context.GetArgument(3) : global::Lua.LuaValue.Nil;
                    _lastArgPos = 2; _expectedType = typeof(global::UnityEngine.Rendering.ShadowMapPass);
                    if (_arg2.TryRead<global::UnityEngine.Rendering.ShadowMapPass>(out var _p2_UnityEngine_Rendering_ShadowMapPass))
                    {
                        if (_argCount == 4)
                        {
                            var evt = _p0_UnityEngine_Rendering_LightEvent;
                            var buffer = _p1_UnityEngine_Rendering_CommandBuffer.Instance;
                            var shadowPassMask = _p2_UnityEngine_Rendering_ShadowMapPass;
                            _this.Instance.AddCommandBuffer(evt, buffer, shadowPassMask);
                            var _retCount = _context.Return();
                            return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                        }
                    }
                }
            }
            throw new global::Lua.LuaRuntimeException(_context.Thread, $"{"AddCommandBuffer"}: invalid argument #{_lastArgPos}: {_lastArg} ({_lastArg.Type}), expected: {_expectedType.FullName}", 2);
        });
        private static readonly global::Lua.LuaFunction _LuaLight_AddCommandBufferAsync = new global::Lua.LuaFunction("AddCommandBufferAsync", (_context, _) =>
        {
            global::Lua.LuaValue _lastArg = default;
            global::System.Int32 _lastArgPos = default;
            global::System.Type _expectedType = default;
            var _argCount = _context.ArgumentCount;
            var _this = _context.GetArgument<LuaLight>(0);
            var _arg0 = _lastArg = _argCount > 1 ? _context.GetArgument(1) : global::Lua.LuaValue.Nil;
            _lastArgPos = 0; _expectedType = typeof(global::UnityEngine.Rendering.LightEvent);
            if (_arg0.TryRead<global::UnityEngine.Rendering.LightEvent>(out var _p0_UnityEngine_Rendering_LightEvent))
            {
                var _arg1 = _lastArg = _argCount > 2 ? _context.GetArgument(2) : global::Lua.LuaValue.Nil;
                _lastArgPos = 1; _expectedType = typeof(global::Luny.UnityEngine.Rendering.LuaCommandBuffer);
                if (_arg1.TryRead<global::Luny.UnityEngine.Rendering.LuaCommandBuffer>(out var _p1_UnityEngine_Rendering_CommandBuffer))
                {
                    var _arg2 = _lastArg = _argCount > 3 ? _context.GetArgument(3) : global::Lua.LuaValue.Nil;
                    _lastArgPos = 2; _expectedType = typeof(global::UnityEngine.Rendering.ComputeQueueType);
                    if (_arg2.TryRead<global::UnityEngine.Rendering.ComputeQueueType>(out var _p2_UnityEngine_Rendering_ComputeQueueType))
                    {
                        if (_argCount == 4)
                        {
                            var evt = _p0_UnityEngine_Rendering_LightEvent;
                            var buffer = _p1_UnityEngine_Rendering_CommandBuffer.Instance;
                            var queueType = _p2_UnityEngine_Rendering_ComputeQueueType;
                            _this.Instance.AddCommandBufferAsync(evt, buffer, queueType);
                            var _retCount = _context.Return();
                            return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                        }
                    }
                    _lastArgPos = 2; _expectedType = typeof(global::UnityEngine.Rendering.ShadowMapPass);
                    if (_arg2.TryRead<global::UnityEngine.Rendering.ShadowMapPass>(out var _p2_UnityEngine_Rendering_ShadowMapPass))
                    {
                        var _arg3 = _lastArg = _argCount > 4 ? _context.GetArgument(4) : global::Lua.LuaValue.Nil;
                        _lastArgPos = 3; _expectedType = typeof(global::UnityEngine.Rendering.ComputeQueueType);
                        if (_arg3.TryRead<global::UnityEngine.Rendering.ComputeQueueType>(out var _p3_UnityEngine_Rendering_ComputeQueueType))
                        {
                            if (_argCount == 5)
                            {
                                var evt = _p0_UnityEngine_Rendering_LightEvent;
                                var buffer = _p1_UnityEngine_Rendering_CommandBuffer.Instance;
                                var shadowPassMask = _p2_UnityEngine_Rendering_ShadowMapPass;
                                var queueType = _p3_UnityEngine_Rendering_ComputeQueueType;
                                _this.Instance.AddCommandBufferAsync(evt, buffer, shadowPassMask, queueType);
                                var _retCount = _context.Return();
                                return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                            }
                        }
                    }
                }
            }
            throw new global::Lua.LuaRuntimeException(_context.Thread, $"{"AddCommandBufferAsync"}: invalid argument #{_lastArgPos}: {_lastArg} ({_lastArg.Type}), expected: {_expectedType.FullName}", 2);
        });
        private static readonly global::Lua.LuaFunction _LuaLight_GetCommandBuffers = new global::Lua.LuaFunction("GetCommandBuffers", (_context, _) =>
        {
            global::Lua.LuaValue _lastArg = default;
            global::System.Int32 _lastArgPos = default;
            global::System.Type _expectedType = default;
            var _argCount = _context.ArgumentCount;
            var _this = _context.GetArgument<LuaLight>(0);
            var _arg0 = _lastArg = _argCount > 1 ? _context.GetArgument(1) : global::Lua.LuaValue.Nil;
            _lastArgPos = 0; _expectedType = typeof(global::UnityEngine.Rendering.LightEvent);
            if (_arg0.TryRead<global::UnityEngine.Rendering.LightEvent>(out var _p0_UnityEngine_Rendering_LightEvent))
            {
                if (_argCount == 2)
                {
                    var evt = _p0_UnityEngine_Rendering_LightEvent;
                    var _ret0 = _this.Instance.GetCommandBuffers(evt);
                    var _factory = _context.GetObjectFactory();
                    var _lret0 = _factory.Bind(_ret0);
                    var _retCount = _context.Return(_lret0);
                    return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                }
            }
            throw new global::Lua.LuaRuntimeException(_context.Thread, $"{"GetCommandBuffers"}: invalid argument #{_lastArgPos}: {_lastArg} ({_lastArg.Type}), expected: {_expectedType.FullName}", 2);
        });
        private static readonly global::Lua.LuaFunction _LuaLight_RemoveAllCommandBuffers = new global::Lua.LuaFunction("RemoveAllCommandBuffers", (_context, _) =>
        {
            global::Lua.LuaValue _lastArg = default;
            global::System.Int32 _lastArgPos = default;
            global::System.Type _expectedType = default;
            var _argCount = _context.ArgumentCount;
            var _this = _context.GetArgument<LuaLight>(0);
            if (_argCount == 1)
            {
                _this.Instance.RemoveAllCommandBuffers();
                var _retCount = _context.Return();
                return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
            }
            throw new global::Lua.LuaRuntimeException(_context.Thread, $"{"RemoveAllCommandBuffers"}: invalid argument #{_lastArgPos}: {_lastArg} ({_lastArg.Type}), expected: {_expectedType.FullName}", 2);
        });
        private static readonly global::Lua.LuaFunction _LuaLight_RemoveCommandBuffer = new global::Lua.LuaFunction("RemoveCommandBuffer", (_context, _) =>
        {
            global::Lua.LuaValue _lastArg = default;
            global::System.Int32 _lastArgPos = default;
            global::System.Type _expectedType = default;
            var _argCount = _context.ArgumentCount;
            var _this = _context.GetArgument<LuaLight>(0);
            var _arg0 = _lastArg = _argCount > 1 ? _context.GetArgument(1) : global::Lua.LuaValue.Nil;
            _lastArgPos = 0; _expectedType = typeof(global::UnityEngine.Rendering.LightEvent);
            if (_arg0.TryRead<global::UnityEngine.Rendering.LightEvent>(out var _p0_UnityEngine_Rendering_LightEvent))
            {
                var _arg1 = _lastArg = _argCount > 2 ? _context.GetArgument(2) : global::Lua.LuaValue.Nil;
                _lastArgPos = 1; _expectedType = typeof(global::Luny.UnityEngine.Rendering.LuaCommandBuffer);
                if (_arg1.TryRead<global::Luny.UnityEngine.Rendering.LuaCommandBuffer>(out var _p1_UnityEngine_Rendering_CommandBuffer))
                {
                    if (_argCount == 3)
                    {
                        var evt = _p0_UnityEngine_Rendering_LightEvent;
                        var buffer = _p1_UnityEngine_Rendering_CommandBuffer.Instance;
                        _this.Instance.RemoveCommandBuffer(evt, buffer);
                        var _retCount = _context.Return();
                        return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                    }
                }
            }
            throw new global::Lua.LuaRuntimeException(_context.Thread, $"{"RemoveCommandBuffer"}: invalid argument #{_lastArgPos}: {_lastArg} ({_lastArg.Type}), expected: {_expectedType.FullName}", 2);
        });
        private static readonly global::Lua.LuaFunction _LuaLight_RemoveCommandBuffers = new global::Lua.LuaFunction("RemoveCommandBuffers", (_context, _) =>
        {
            global::Lua.LuaValue _lastArg = default;
            global::System.Int32 _lastArgPos = default;
            global::System.Type _expectedType = default;
            var _argCount = _context.ArgumentCount;
            var _this = _context.GetArgument<LuaLight>(0);
            var _arg0 = _lastArg = _argCount > 1 ? _context.GetArgument(1) : global::Lua.LuaValue.Nil;
            _lastArgPos = 0; _expectedType = typeof(global::UnityEngine.Rendering.LightEvent);
            if (_arg0.TryRead<global::UnityEngine.Rendering.LightEvent>(out var _p0_UnityEngine_Rendering_LightEvent))
            {
                if (_argCount == 2)
                {
                    var evt = _p0_UnityEngine_Rendering_LightEvent;
                    _this.Instance.RemoveCommandBuffers(evt);
                    var _retCount = _context.Return();
                    return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                }
            }
            throw new global::Lua.LuaRuntimeException(_context.Thread, $"{"RemoveCommandBuffers"}: invalid argument #{_lastArgPos}: {_lastArg} ({_lastArg.Type}), expected: {_expectedType.FullName}", 2);
        });
        private static readonly global::Lua.LuaFunction _LuaLight_Reset = new global::Lua.LuaFunction("Reset", (_context, _) =>
        {
            global::Lua.LuaValue _lastArg = default;
            global::System.Int32 _lastArgPos = default;
            global::System.Type _expectedType = default;
            var _argCount = _context.ArgumentCount;
            var _this = _context.GetArgument<LuaLight>(0);
            if (_argCount == 1)
            {
                _this.Instance.Reset();
                var _retCount = _context.Return();
                return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
            }
            throw new global::Lua.LuaRuntimeException(_context.Thread, $"{"Reset"}: invalid argument #{_lastArgPos}: {_lastArg} ({_lastArg.Type}), expected: {_expectedType.FullName}", 2);
        });
        private static readonly global::Lua.LuaFunction __index = new(global::Lua.Runtime.Metamethods.Index, (_context, _) =>
        {
            var _this = _context.GetArgument<LuaLight>(0);
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
            var _this = _context.GetArgument<LuaLight>(0);
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
                case "AddCommandBuffer": _value = _LuaLight_AddCommandBuffer; return true;
                case "AddCommandBufferAsync": _value = _LuaLight_AddCommandBufferAsync; return true;
                case "GetCommandBuffers": _value = _LuaLight_GetCommandBuffers; return true;
                case "RemoveAllCommandBuffers": _value = _LuaLight_RemoveAllCommandBuffers; return true;
                case "RemoveCommandBuffer": _value = _LuaLight_RemoveCommandBuffer; return true;
                case "RemoveCommandBuffers": _value = _LuaLight_RemoveCommandBuffers; return true;
                case "Reset": _value = _LuaLight_Reset; return true;
                case "areaSize": _value = global::Luny.UnityEngine.LuaVector2.Bind(Instance.areaSize); return true;
                case "bakingOutput": _value = global::Luny.UnityEngine.LuaLightBakingOutput.Bind(Instance.bakingOutput); return true;
                case "bounceIntensity": _value = new global::Lua.LuaValue(Instance.bounceIntensity); return true;
                case "boundingSphereOverride": _value = global::Luny.UnityEngine.LuaVector4.Bind(Instance.boundingSphereOverride); return true;
                case "color": _value = global::Luny.UnityEngine.LuaColor.Bind(Instance.color); return true;
                case "colorTemperature": _value = new global::Lua.LuaValue(Instance.colorTemperature); return true;
                case "commandBufferCount": _value = new global::Lua.LuaValue(Instance.commandBufferCount); return true;
                case "cookie": _value = _factory.Bind(Instance.cookie); return true;
                case "cookieSize": _value = new global::Lua.LuaValue(Instance.cookieSize); return true;
                case "cullingMask": _value = new global::Lua.LuaValue(Instance.cullingMask); return true;
                case "dilatedRange": _value = new global::Lua.LuaValue(Instance.dilatedRange); return true;
                case "enableSpotReflector": _value = new global::Lua.LuaValue(Instance.enableSpotReflector); return true;
                case "flare": _value = _factory.Bind(Instance.flare); return true;
                case "forceVisible": _value = new global::Lua.LuaValue(Instance.forceVisible); return true;
                case "innerSpotAngle": _value = new global::Lua.LuaValue(Instance.innerSpotAngle); return true;
                case "intensity": _value = new global::Lua.LuaValue(Instance.intensity); return true;
                case "layerShadowCullDistances": _value = _factory.Bind(Instance.layerShadowCullDistances); return true;
                case "lightShadowCasterMode": _value = new global::Lua.LuaValue((global::System.Int64)Instance.lightShadowCasterMode); return true;
                case "lightUnit": _value = new global::Lua.LuaValue((global::System.Int64)Instance.lightUnit); return true;
                case "luxAtDistance": _value = new global::Lua.LuaValue(Instance.luxAtDistance); return true;
                case "range": _value = new global::Lua.LuaValue(Instance.range); return true;
                case "renderingLayerMask": _value = new global::Lua.LuaValue(Instance.renderingLayerMask); return true;
                case "renderMode": _value = new global::Lua.LuaValue((global::System.Int64)Instance.renderMode); return true;
                case "shadowBias": _value = new global::Lua.LuaValue(Instance.shadowBias); return true;
                case "shadowCustomResolution": _value = new global::Lua.LuaValue(Instance.shadowCustomResolution); return true;
                case "shadowMatrixOverride": _value = global::Luny.UnityEngine.LuaMatrix4x4.Bind(Instance.shadowMatrixOverride); return true;
                case "shadowNearPlane": _value = new global::Lua.LuaValue(Instance.shadowNearPlane); return true;
                case "shadowNormalBias": _value = new global::Lua.LuaValue(Instance.shadowNormalBias); return true;
                case "shadowResolution": _value = new global::Lua.LuaValue((global::System.Int64)Instance.shadowResolution); return true;
                case "shadows": _value = new global::Lua.LuaValue((global::System.Int64)Instance.shadows); return true;
                case "shadowStrength": _value = new global::Lua.LuaValue(Instance.shadowStrength); return true;
                case "spotAngle": _value = new global::Lua.LuaValue(Instance.spotAngle); return true;
                case "type": _value = new global::Lua.LuaValue((global::System.Int64)Instance.type); return true;
                case "useBoundingSphereOverride": _value = new global::Lua.LuaValue(Instance.useBoundingSphereOverride); return true;
                case "useColorTemperature": _value = new global::Lua.LuaValue(Instance.useColorTemperature); return true;
                case "useShadowMatrixOverride": _value = new global::Lua.LuaValue(Instance.useShadowMatrixOverride); return true;
                case "useViewFrustumForShadowCasterCull": _value = new global::Lua.LuaValue(Instance.useViewFrustumForShadowCasterCull); return true;
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
                case "areaSize": Instance.areaSize = _value.Read<global::Luny.UnityEngine.LuaVector2>().Value;  return true;
                case "bakingOutput": Instance.bakingOutput = _value.Read<global::Luny.UnityEngine.LuaLightBakingOutput>().Value;  return true;
                case "bounceIntensity": Instance.bounceIntensity = _value.Read<global::System.Single>();  return true;
                case "boundingSphereOverride": Instance.boundingSphereOverride = _value.Read<global::Luny.UnityEngine.LuaVector4>().Value;  return true;
                case "color": Instance.color = _value.Read<global::Luny.UnityEngine.LuaColor>().Value;  return true;
                case "colorTemperature": Instance.colorTemperature = _value.Read<global::System.Single>();  return true;
                case "cookie": Instance.cookie = _value.Read<global::Luny.UnityEngine.LuaTexture>().Instance;  return true;
                case "cookieSize": Instance.cookieSize = _value.Read<global::System.Single>();  return true;
                case "cullingMask": Instance.cullingMask = _value.Read<global::System.Int32>();  return true;
                case "enableSpotReflector": Instance.enableSpotReflector = _value.Read<global::System.Boolean>();  return true;
                case "flare": Instance.flare = _value.Read<global::Luny.UnityEngine.LuaFlare>().Instance;  return true;
                case "forceVisible": Instance.forceVisible = _value.Read<global::System.Boolean>();  return true;
                case "innerSpotAngle": Instance.innerSpotAngle = _value.Read<global::System.Single>();  return true;
                case "intensity": Instance.intensity = _value.Read<global::System.Single>();  return true;
                case "layerShadowCullDistances": Instance.layerShadowCullDistances = _value.Read<global::System.Single[]>();  return true;
                case "lightShadowCasterMode": Instance.lightShadowCasterMode = _value.Read<global::UnityEngine.LightShadowCasterMode>();  return true;
                case "lightUnit": Instance.lightUnit = _value.Read<global::UnityEngine.Rendering.LightUnit>();  return true;
                case "luxAtDistance": Instance.luxAtDistance = _value.Read<global::System.Single>();  return true;
                case "range": Instance.range = _value.Read<global::System.Single>();  return true;
                case "renderingLayerMask": Instance.renderingLayerMask = _value.Read<global::System.Int32>();  return true;
                case "renderMode": Instance.renderMode = _value.Read<global::UnityEngine.LightRenderMode>();  return true;
                case "shadowBias": Instance.shadowBias = _value.Read<global::System.Single>();  return true;
                case "shadowCustomResolution": Instance.shadowCustomResolution = _value.Read<global::System.Int32>();  return true;
                case "shadowMatrixOverride": Instance.shadowMatrixOverride = _value.Read<global::Luny.UnityEngine.LuaMatrix4x4>().Value;  return true;
                case "shadowNearPlane": Instance.shadowNearPlane = _value.Read<global::System.Single>();  return true;
                case "shadowNormalBias": Instance.shadowNormalBias = _value.Read<global::System.Single>();  return true;
                case "shadowResolution": Instance.shadowResolution = _value.Read<global::UnityEngine.Rendering.LightShadowResolution>();  return true;
                case "shadows": Instance.shadows = _value.Read<global::UnityEngine.LightShadows>();  return true;
                case "shadowStrength": Instance.shadowStrength = _value.Read<global::System.Single>();  return true;
                case "spotAngle": Instance.spotAngle = _value.Read<global::System.Single>();  return true;
                case "type": Instance.type = _value.Read<global::UnityEngine.LightType>();  return true;
                case "useBoundingSphereOverride": Instance.useBoundingSphereOverride = _value.Read<global::System.Boolean>();  return true;
                case "useColorTemperature": Instance.useColorTemperature = _value.Read<global::System.Boolean>();  return true;
                case "useShadowMatrixOverride": Instance.useShadowMatrixOverride = _value.Read<global::System.Boolean>();  return true;
                case "useViewFrustumForShadowCasterCull": Instance.useViewFrustumForShadowCasterCull = _value.Read<global::System.Boolean>();  return true;
                default: return base.TrySetLuaValue(_key, _value);
            }
        }
    }
    public sealed class LuaLightType : global::Luny.ILuaStatic
    {
        public static global::Lua.LuaValue Bind() => new LuaLightType();
        private LuaLightType() {}
        public static implicit operator global::Lua.LuaValue(LuaLightType value) => new(value);
        public global::System.Type BindType => typeof(global::UnityEngine.Light);
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
            metatable[global::Lua.Runtime.Metamethods.Call] = _LuaLight_new;
            return metatable;
        }
        public override global::System.String ToString() => BindType.FullName;
#if UNITY_EDITOR
        [global::UnityEngine.RuntimeInitializeOnLoadMethod(global::UnityEngine.RuntimeInitializeLoadType.SubsystemRegistration)]
        private static void ResetStaticFields() => s_Metatable = null;
#endif

        private static readonly global::Lua.LuaFunction _LuaLight_new = new global::Lua.LuaFunction(".ctor", (_context, _) =>
        {
            global::Lua.LuaValue _lastArg = default;
            global::System.Int32 _lastArgPos = default;
            global::System.Type _expectedType = default;
            var _argCount = _context.ArgumentCount;
            if (_argCount == 1)
            {
                var _ret0 = new global::UnityEngine.Light();
                var _factory = _context.GetObjectFactory();
                var _lret0 = _factory.Bind(_ret0);
                var _retCount = _context.Return(_lret0);
                return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
            }
            throw new global::Lua.LuaRuntimeException(_context.Thread, $"{".ctor"}: invalid argument #{_lastArgPos}: {_lastArg} ({_lastArg.Type}), expected: {_expectedType.FullName}", 2);
        });
        private static readonly global::Lua.LuaFunction __index = new(global::Lua.Runtime.Metamethods.Index, (_context, _) =>
        {
            var _this = _context.GetArgument<LuaLightType>(0);
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
            var _this = _context.GetArgument<LuaLightType>(0);
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
}
#pragma warning restore 0109, 0162, 0168, 0219
#endif
