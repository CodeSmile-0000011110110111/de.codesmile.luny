
// --------------------------------------------------------------
// GENERATED FILE ----> DO NOT EDIT <---- CHANGES WILL BE LOST !!
// --------------------------------------------------------------

#if UNITY_6000_0_OR_NEWER && !(UNITY_6000_1_OR_NEWER)
#pragma warning disable 0109, 0162, 0168, 0219
using Luny;

namespace Luny.UnityEngine
{
    public sealed class LuaRenderParams : global::Luny.ILuaValueType<global::UnityEngine.RenderParams>
    {
        public new static global::Lua.LuaValue Bind(in global::UnityEngine.RenderParams instance) => new LuaRenderParams(instance);
        public new static global::Lua.LuaValue Bind(global::System.Object instance) => Bind((global::UnityEngine.RenderParams)instance);
        public new static global::Lua.LuaValue Bind(global::System.Collections.Generic.IList<global::UnityEngine.RenderParams> instances) =>
            new global::Luny.LuaList<global::UnityEngine.RenderParams>(instances);
        public new static global::Lua.LuaValue Bind(global::System.Collections.Generic.IList<global::System.Object> instances) =>
            new global::Luny.LuaList<global::UnityEngine.RenderParams>(instances);
        private LuaRenderParams(in global::UnityEngine.RenderParams value) => m_Value = value;
        public static implicit operator global::Lua.LuaValue(LuaRenderParams value) => new(value);
        private global::UnityEngine.RenderParams m_Value;
        public global::UnityEngine.RenderParams Value { get => m_Value; set => m_Value = value; }
        public ref global::UnityEngine.RenderParams ValueRef => ref m_Value;
        public global::System.Type BindType => typeof(global::UnityEngine.RenderParams);
        public override global::System.String ToString() => m_Value.ToString();
#if UNITY_EDITOR
        [global::UnityEngine.RuntimeInitializeOnLoadMethod(global::UnityEngine.RuntimeInitializeLoadType.SubsystemRegistration)]
        private static void ResetStaticFields() => s_Metatable = null;
#endif

        private static readonly global::Lua.LuaFunction __index = new(global::Lua.Runtime.Metamethods.Index, (_context, _) =>
        {
            var _this = _context.GetArgument<LuaRenderParams>(0);
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
            var _this = _context.GetArgument<LuaRenderParams>(0);
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

        public global::System.Boolean TryGetLuaValue(global::System.Int32 _key, out global::Lua.LuaValue _value, global::Luny.ILuaObjectFactory _factory)
        {
            _value = global::Lua.LuaValue.Nil; return false;
        }
        public global::System.Boolean TryGetLuaValue(global::System.String _key, out global::Lua.LuaValue _value, global::Luny.ILuaObjectFactory _factory)
        {
            switch (_key)
            {
                case "camera": _value = _factory.Bind(m_Value.camera); return true;
                case "instanceID": _value = new global::Lua.LuaValue(m_Value.instanceID); return true;
                case "layer": _value = new global::Lua.LuaValue(m_Value.layer); return true;
                case "lightProbeProxyVolume": _value = _factory.Bind(m_Value.lightProbeProxyVolume); return true;
                case "lightProbeUsage": _value = new global::Lua.LuaValue((global::System.Int64)m_Value.lightProbeUsage); return true;
                case "material": _value = _factory.Bind(m_Value.material); return true;
                case "matProps": _value = _factory.Bind(m_Value.matProps); return true;
                case "motionVectorMode": _value = new global::Lua.LuaValue((global::System.Int64)m_Value.motionVectorMode); return true;
                case "overrideSceneCullingMask": _value = new global::Lua.LuaValue(m_Value.overrideSceneCullingMask); return true;
                case "receiveShadows": _value = new global::Lua.LuaValue(m_Value.receiveShadows); return true;
                case "reflectionProbeUsage": _value = new global::Lua.LuaValue((global::System.Int64)m_Value.reflectionProbeUsage); return true;
                case "rendererPriority": _value = new global::Lua.LuaValue(m_Value.rendererPriority); return true;
                case "renderingLayerMask": _value = new global::Lua.LuaValue(m_Value.renderingLayerMask); return true;
                case "sceneCullingMask": _value = new global::Lua.LuaValue(m_Value.sceneCullingMask); return true;
                case "shadowCastingMode": _value = new global::Lua.LuaValue((global::System.Int64)m_Value.shadowCastingMode); return true;
                case "worldBounds": _value = global::Luny.UnityEngine.LuaBounds.Bind(m_Value.worldBounds); return true;
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
                case "camera": { var _temp = m_Value; _temp.camera = _value.Read<global::Luny.UnityEngine.LuaCamera>().Instance; m_Value = _temp; } return true;
                case "instanceID": { var _temp = m_Value; _temp.instanceID = _value.Read<global::System.Int32>(); m_Value = _temp; } return true;
                case "layer": { var _temp = m_Value; _temp.layer = _value.Read<global::System.Int32>(); m_Value = _temp; } return true;
                case "lightProbeProxyVolume": { var _temp = m_Value; _temp.lightProbeProxyVolume = _value.Read<global::Luny.UnityEngine.LuaLightProbeProxyVolume>().Instance; m_Value = _temp; } return true;
                case "lightProbeUsage": { var _temp = m_Value; _temp.lightProbeUsage = _value.Read<global::UnityEngine.Rendering.LightProbeUsage>(); m_Value = _temp; } return true;
                case "material": { var _temp = m_Value; _temp.material = _value.Read<global::Luny.UnityEngine.LuaMaterial>().Instance; m_Value = _temp; } return true;
                case "matProps": { var _temp = m_Value; _temp.matProps = _value.Read<global::Luny.UnityEngine.LuaMaterialPropertyBlock>().Instance; m_Value = _temp; } return true;
                case "motionVectorMode": { var _temp = m_Value; _temp.motionVectorMode = _value.Read<global::UnityEngine.MotionVectorGenerationMode>(); m_Value = _temp; } return true;
                case "overrideSceneCullingMask": { var _temp = m_Value; _temp.overrideSceneCullingMask = _value.Read<global::System.Boolean>(); m_Value = _temp; } return true;
                case "receiveShadows": { var _temp = m_Value; _temp.receiveShadows = _value.Read<global::System.Boolean>(); m_Value = _temp; } return true;
                case "reflectionProbeUsage": { var _temp = m_Value; _temp.reflectionProbeUsage = _value.Read<global::UnityEngine.Rendering.ReflectionProbeUsage>(); m_Value = _temp; } return true;
                case "rendererPriority": { var _temp = m_Value; _temp.rendererPriority = _value.Read<global::System.Int32>(); m_Value = _temp; } return true;
                case "renderingLayerMask": { var _temp = m_Value; _temp.renderingLayerMask = _value.Read<global::System.UInt32>(); m_Value = _temp; } return true;
                case "sceneCullingMask": { var _temp = m_Value; _temp.sceneCullingMask = _value.Read<global::System.UInt64>(); m_Value = _temp; } return true;
                case "shadowCastingMode": { var _temp = m_Value; _temp.shadowCastingMode = _value.Read<global::UnityEngine.Rendering.ShadowCastingMode>(); m_Value = _temp; } return true;
                case "worldBounds": { var _temp = m_Value; _temp.worldBounds = _value.Read<global::Luny.UnityEngine.LuaBounds>().Value; m_Value = _temp; } return true;
                default: return false;
            }
        }
    }
    public sealed class LuaRenderParamsType : global::Luny.ILuaStatic
    {
        public static global::Lua.LuaValue Bind() => new LuaRenderParamsType();
        private LuaRenderParamsType() {}
        public static implicit operator global::Lua.LuaValue(LuaRenderParamsType value) => new(value);
        public global::System.Type BindType => typeof(global::UnityEngine.RenderParams);
        public override global::System.String ToString() => BindType.FullName;
#if UNITY_EDITOR
        [global::UnityEngine.RuntimeInitializeOnLoadMethod(global::UnityEngine.RuntimeInitializeLoadType.SubsystemRegistration)]
        private static void ResetStaticFields() => s_Metatable = null;
#endif

        private static readonly global::Lua.LuaFunction _LuaRenderParams_new = new global::Lua.LuaFunction(".ctor", (_context, _) =>
        {
            global::Lua.LuaValue _lastArg = default;
            global::System.Int32 _lastArgPos = default;
            global::System.Type _expectedType = default;
            var _argCount = _context.ArgumentCount;
            // ctor parameterless case
            if (_argCount == 1)
            {
                var _ret0 = new global::UnityEngine.RenderParams();
                var _lret0 = global::Luny.UnityEngine.LuaRenderParams.Bind(_ret0);
                var _retCount = _context.Return(_lret0);
                return new global::System.Threading.Tasks.ValueTask<global::System.Int32>(_retCount);
            }
            var _arg0 = _lastArg = _argCount > 1 ? _context.GetArgument(1) : global::Lua.LuaValue.Nil;
            _lastArgPos = 0; _expectedType = typeof(global::Luny.UnityEngine.LuaMaterial);
            if (_arg0.TryRead<global::Luny.UnityEngine.LuaMaterial>(out var _p0_UnityEngine_Material))
            {
                if (_argCount == 2)
                {
                    var mat = _p0_UnityEngine_Material.Instance;
                    var _ret0 = new global::UnityEngine.RenderParams(mat);
                    var _lret0 = global::Luny.UnityEngine.LuaRenderParams.Bind(_ret0);
                    var _retCount = _context.Return(_lret0);
                    return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                }
            }
            throw new global::Lua.LuaRuntimeException(_context.Thread, $"{".ctor"}: invalid argument #{_lastArgPos}: {_lastArg} ({_lastArg.Type}), expected: {_expectedType.FullName}", 2);
        });
        private static readonly global::Lua.LuaFunction __index = new(global::Lua.Runtime.Metamethods.Index, (_context, _) =>
        {
            var _this = _context.GetArgument<LuaRenderParamsType>(0);
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
            var _this = _context.GetArgument<LuaRenderParamsType>(0);
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
            metatable[global::Lua.Runtime.Metamethods.Call] = _LuaRenderParams_new;
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
