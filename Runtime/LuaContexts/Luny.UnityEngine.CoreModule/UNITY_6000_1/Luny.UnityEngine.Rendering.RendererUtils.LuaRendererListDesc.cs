
// --------------------------------------------------------------
// GENERATED FILE ----> DO NOT EDIT <---- CHANGES WILL BE LOST !!
// --------------------------------------------------------------

#if UNITY_6000_1_OR_NEWER && !(UNITY_6000_2_OR_NEWER)
#pragma warning disable 0109, 0162, 0168, 0219
using Luny;

namespace Luny.UnityEngine.Rendering.RendererUtils
{
    public sealed class LuaRendererListDesc : global::Luny.ILuaValueType<global::UnityEngine.Rendering.RendererUtils.RendererListDesc>
    {
        public new static global::Lua.LuaValue Bind(in global::UnityEngine.Rendering.RendererUtils.RendererListDesc instance) => new LuaRendererListDesc(instance);
        public new static global::Lua.LuaValue Bind(global::System.Object instance) => Bind((global::UnityEngine.Rendering.RendererUtils.RendererListDesc)instance);
        public new static global::Lua.LuaValue Bind(global::System.Collections.Generic.IList<global::UnityEngine.Rendering.RendererUtils.RendererListDesc> instances) =>
            new global::Luny.LuaList<global::UnityEngine.Rendering.RendererUtils.RendererListDesc>(instances);
        public new static global::Lua.LuaValue Bind(global::System.Collections.Generic.IList<global::System.Object> instances) =>
            new global::Luny.LuaList<global::UnityEngine.Rendering.RendererUtils.RendererListDesc>(instances);
        private LuaRendererListDesc(in global::UnityEngine.Rendering.RendererUtils.RendererListDesc value) => m_Value = value;
        public static implicit operator global::Lua.LuaValue(LuaRendererListDesc value) => new(value);
        private global::UnityEngine.Rendering.RendererUtils.RendererListDesc m_Value;
        public global::UnityEngine.Rendering.RendererUtils.RendererListDesc Value { get => m_Value; set => m_Value = value; }
        public ref global::UnityEngine.Rendering.RendererUtils.RendererListDesc ValueRef => ref m_Value;
        public global::System.Type BindType => typeof(global::UnityEngine.Rendering.RendererUtils.RendererListDesc);
        private static global::Lua.LuaTable s_Metatable;
        public global::Lua.LuaTable Metatable
        {
            get => s_Metatable ??= global::Luny.LuaMetatable.Create(__index, __newindex);
            set => throw new global::System.NotSupportedException("LuaObject metatables cannot be modified");
        }
        global::System.Span<global::Lua.LuaValue> global::Lua.ILuaUserData.UserValues => default;
        public override global::System.String ToString() => m_Value.ToString();
#if UNITY_EDITOR
        [global::UnityEngine.RuntimeInitializeOnLoadMethod(global::UnityEngine.RuntimeInitializeLoadType.SubsystemRegistration)]
        private static void ResetStaticFields() => s_Metatable = null;
#endif

        private static readonly global::Lua.LuaFunction _LuaRendererListDesc_IsValid = new global::Lua.LuaFunction("IsValid", (_context, _) =>
        {
            global::Lua.LuaValue _lastArg = default;
            global::System.Int32 _lastArgPos = default;
            global::System.Type _expectedType = default;
            var _argCount = _context.ArgumentCount;
            var _this = _context.GetArgument<LuaRendererListDesc>(0);
            if (_argCount == 1)
            {
                var _ret0 = _this.m_Value.IsValid();
                var _lret0 = new global::Lua.LuaValue(_ret0);
                var _retCount = _context.Return(_lret0);
                return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
            }
            throw new global::Lua.LuaRuntimeException(_context.Thread, $"{"IsValid"}: invalid argument #{_lastArgPos}: {_lastArg} ({_lastArg.Type}), expected: {_expectedType.FullName}", 2);
        });
        private static readonly global::Lua.LuaFunction __index = new(global::Lua.Runtime.Metamethods.Index, (_context, _) =>
        {
            var _this = _context.GetArgument<LuaRendererListDesc>(0);
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
            var _this = _context.GetArgument<LuaRendererListDesc>(0);
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
                case "IsValid": _value = _LuaRendererListDesc_IsValid; return true;
                case "batchLayerMask": _value = new global::Lua.LuaValue(m_Value.batchLayerMask); return true;
                case "excludeObjectMotionVectors": _value = new global::Lua.LuaValue(m_Value.excludeObjectMotionVectors); return true;
                case "layerMask": _value = new global::Lua.LuaValue(m_Value.layerMask); return true;
                case "overrideMaterial": _value = _factory.Bind(m_Value.overrideMaterial); return true;
                case "overrideMaterialPassIndex": _value = new global::Lua.LuaValue(m_Value.overrideMaterialPassIndex); return true;
                case "overrideShader": _value = _factory.Bind(m_Value.overrideShader); return true;
                case "overrideShaderPassIndex": _value = new global::Lua.LuaValue(m_Value.overrideShaderPassIndex); return true;
                case "rendererConfiguration": _value = new global::Lua.LuaValue((global::System.Int64)m_Value.rendererConfiguration); return true;
                case "renderingLayerMask": _value = new global::Lua.LuaValue(m_Value.renderingLayerMask); return true;
                case "renderQueueRange": _value = global::Luny.UnityEngine.Rendering.LuaRenderQueueRange.Bind(m_Value.renderQueueRange); return true;
                case "sortingCriteria": _value = new global::Lua.LuaValue((global::System.Int64)m_Value.sortingCriteria); return true;
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
                case "batchLayerMask": { var _temp = m_Value; _temp.batchLayerMask = _value.Read<global::System.UInt32>(); m_Value = _temp; } return true;
                case "excludeObjectMotionVectors": { var _temp = m_Value; _temp.excludeObjectMotionVectors = _value.Read<global::System.Boolean>(); m_Value = _temp; } return true;
                case "layerMask": { var _temp = m_Value; _temp.layerMask = _value.Read<global::System.Int32>(); m_Value = _temp; } return true;
                case "overrideMaterial": { var _temp = m_Value; _temp.overrideMaterial = _value.Read<global::Luny.UnityEngine.LuaMaterial>().Instance; m_Value = _temp; } return true;
                case "overrideMaterialPassIndex": { var _temp = m_Value; _temp.overrideMaterialPassIndex = _value.Read<global::System.Int32>(); m_Value = _temp; } return true;
                case "overrideShader": { var _temp = m_Value; _temp.overrideShader = _value.Read<global::Luny.UnityEngine.LuaShader>().Instance; m_Value = _temp; } return true;
                case "overrideShaderPassIndex": { var _temp = m_Value; _temp.overrideShaderPassIndex = _value.Read<global::System.Int32>(); m_Value = _temp; } return true;
                case "rendererConfiguration": { var _temp = m_Value; _temp.rendererConfiguration = _value.Read<global::UnityEngine.Rendering.PerObjectData>(); m_Value = _temp; } return true;
                case "renderingLayerMask": { var _temp = m_Value; _temp.renderingLayerMask = _value.Read<global::System.UInt32>(); m_Value = _temp; } return true;
                case "renderQueueRange": { var _temp = m_Value; _temp.renderQueueRange = _value.Read<global::Luny.UnityEngine.Rendering.LuaRenderQueueRange>().Value; m_Value = _temp; } return true;
                case "sortingCriteria": { var _temp = m_Value; _temp.sortingCriteria = _value.Read<global::UnityEngine.Rendering.SortingCriteria>(); m_Value = _temp; } return true;
                default: return false;
            }
        }
    }
    public sealed class LuaRendererListDescType : global::Luny.ILuaStatic
    {
        public static global::Lua.LuaValue Bind() => new LuaRendererListDescType();
        private LuaRendererListDescType() {}
        public static implicit operator global::Lua.LuaValue(LuaRendererListDescType value) => new(value);
        public global::System.Type BindType => typeof(global::UnityEngine.Rendering.RendererUtils.RendererListDesc);
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

        private static readonly global::Lua.LuaFunction _LuaRendererListDesc_new = new global::Lua.LuaFunction(".ctor", (_context, _) =>
        {
            global::Lua.LuaValue _lastArg = default;
            global::System.Int32 _lastArgPos = default;
            global::System.Type _expectedType = default;
            var _argCount = _context.ArgumentCount;
            if (_argCount == 0)
            {
                var _ret0 = new global::UnityEngine.Rendering.RendererUtils.RendererListDesc();
                var _lret0 = global::Luny.UnityEngine.Rendering.RendererUtils.LuaRendererListDesc.Bind(_ret0);
                var _retCount = _context.Return(_lret0);
                return new global::System.Threading.Tasks.ValueTask<global::System.Int32>(_retCount);
            }
            var _arg0 = _lastArg = _argCount > 0 ? _context.GetArgument(0) : global::Lua.LuaValue.Nil;
            _lastArgPos = 0; _expectedType = typeof(global::Luny.UnityEngine.Rendering.LuaShaderTagId);
            if (_arg0.TryRead<global::Luny.UnityEngine.Rendering.LuaShaderTagId>(out var _p0_UnityEngine_Rendering_ShaderTagId))
            {
                var _arg1 = _lastArg = _argCount > 1 ? _context.GetArgument(1) : global::Lua.LuaValue.Nil;
                _lastArgPos = 1; _expectedType = typeof(global::Luny.UnityEngine.Rendering.LuaCullingResults);
                if (_arg1.TryRead<global::Luny.UnityEngine.Rendering.LuaCullingResults>(out var _p1_UnityEngine_Rendering_CullingResults))
                {
                    var _arg2 = _lastArg = _argCount > 2 ? _context.GetArgument(2) : global::Lua.LuaValue.Nil;
                    _lastArgPos = 2; _expectedType = typeof(global::Luny.UnityEngine.LuaCamera);
                    if (_arg2.TryRead<global::Luny.UnityEngine.LuaCamera>(out var _p2_UnityEngine_Camera))
                    {
                        if (_argCount == 3)
                        {
                            var passName = _p0_UnityEngine_Rendering_ShaderTagId.Value;
                            var cullingResult = _p1_UnityEngine_Rendering_CullingResults.Value;
                            var camera = _p2_UnityEngine_Camera.Instance;
                            var _ret0 = new global::UnityEngine.Rendering.RendererUtils.RendererListDesc(passName, cullingResult, camera);
                            var _lret0 = global::Luny.UnityEngine.Rendering.RendererUtils.LuaRendererListDesc.Bind(_ret0);
                            var _retCount = _context.Return(_lret0);
                            return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                        }
                    }
                }
            }
            _lastArgPos = 0; _expectedType = typeof(global::UnityEngine.Rendering.ShaderTagId[]);
            if (_arg0.TryReadArray<global::UnityEngine.Rendering.ShaderTagId>(out var _p0_UnityEngine_Rendering_ShaderTagIdArray))
            {
                var _arg1 = _lastArg = _argCount > 1 ? _context.GetArgument(1) : global::Lua.LuaValue.Nil;
                _lastArgPos = 1; _expectedType = typeof(global::Luny.UnityEngine.Rendering.LuaCullingResults);
                if (_arg1.TryRead<global::Luny.UnityEngine.Rendering.LuaCullingResults>(out var _p1_UnityEngine_Rendering_CullingResults))
                {
                    var _arg2 = _lastArg = _argCount > 2 ? _context.GetArgument(2) : global::Lua.LuaValue.Nil;
                    _lastArgPos = 2; _expectedType = typeof(global::Luny.UnityEngine.LuaCamera);
                    if (_arg2.TryRead<global::Luny.UnityEngine.LuaCamera>(out var _p2_UnityEngine_Camera))
                    {
                        if (_argCount == 3)
                        {
                            var passNames = _p0_UnityEngine_Rendering_ShaderTagIdArray;
                            var cullingResult = _p1_UnityEngine_Rendering_CullingResults.Value;
                            var camera = _p2_UnityEngine_Camera.Instance;
                            var _ret0 = new global::UnityEngine.Rendering.RendererUtils.RendererListDesc(passNames, cullingResult, camera);
                            var _lret0 = global::Luny.UnityEngine.Rendering.RendererUtils.LuaRendererListDesc.Bind(_ret0);
                            var _retCount = _context.Return(_lret0);
                            return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                        }
                    }
                }
            }
            throw new global::Lua.LuaRuntimeException(_context.Thread, $"{".ctor"}: invalid argument #{_lastArgPos}: {_lastArg} ({_lastArg.Type}), expected: {_expectedType.FullName}", 2);
        });
        private static readonly global::Lua.LuaFunction __index = new(global::Lua.Runtime.Metamethods.Index, (_context, _) =>
        {
            var _this = _context.GetArgument<LuaRendererListDescType>(0);
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
            var _this = _context.GetArgument<LuaRendererListDescType>(0);
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
                case "new": _value = _LuaRendererListDesc_new; return true;
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
