
// --------------------------------------------------------------
// GENERATED FILE ----> DO NOT EDIT <---- CHANGES WILL BE LOST !!
// --------------------------------------------------------------

#if UNITY_6000_1_OR_NEWER && !(UNITY_6000_2_OR_NEWER)
#pragma warning disable 0109, 0162, 0168, 0219
using Luny;

namespace Luny.UnityEngine.Rendering
{
    public sealed class LuaRenderTargetBinding : global::Luny.ILuaValueType<global::UnityEngine.Rendering.RenderTargetBinding>
    {
        public new static global::Lua.LuaValue Bind(in global::UnityEngine.Rendering.RenderTargetBinding instance) => new LuaRenderTargetBinding(instance);
        public new static global::Lua.LuaValue Bind(global::System.Object instance) => Bind((global::UnityEngine.Rendering.RenderTargetBinding)instance);
        public new static global::Lua.LuaValue Bind(global::System.Collections.Generic.IList<global::UnityEngine.Rendering.RenderTargetBinding> instances) =>
            new global::Luny.LuaList<global::UnityEngine.Rendering.RenderTargetBinding>(instances);
        public new static global::Lua.LuaValue Bind(global::System.Collections.Generic.IList<global::System.Object> instances) =>
            new global::Luny.LuaList<global::UnityEngine.Rendering.RenderTargetBinding>(instances);
        private LuaRenderTargetBinding(in global::UnityEngine.Rendering.RenderTargetBinding value) => m_Value = value;
        public static implicit operator global::Lua.LuaValue(LuaRenderTargetBinding value) => new(value);
        private global::UnityEngine.Rendering.RenderTargetBinding m_Value;
        public global::UnityEngine.Rendering.RenderTargetBinding Value { get => m_Value; set => m_Value = value; }
        public ref global::UnityEngine.Rendering.RenderTargetBinding ValueRef => ref m_Value;
        public global::System.Type BindType => typeof(global::UnityEngine.Rendering.RenderTargetBinding);
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
        public override global::System.String ToString() => m_Value.ToString();
#if UNITY_EDITOR
        [global::UnityEngine.RuntimeInitializeOnLoadMethod(global::UnityEngine.RuntimeInitializeLoadType.SubsystemRegistration)]
        private static void ResetStaticFields() => s_Metatable = null;
#endif

        private static readonly global::Lua.LuaFunction __index = new(global::Lua.Runtime.Metamethods.Index, (_context, _) =>
        {
            var _this = _context.GetArgument<LuaRenderTargetBinding>(0);
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
            var _this = _context.GetArgument<LuaRenderTargetBinding>(0);
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
                case "colorLoadActions": _value = _factory.Bind(m_Value.colorLoadActions); return true;
                case "colorRenderTargets": _value = _factory.Bind(m_Value.colorRenderTargets); return true;
                case "colorStoreActions": _value = _factory.Bind(m_Value.colorStoreActions); return true;
                case "depthLoadAction": _value = new global::Lua.LuaValue((global::System.Int64)m_Value.depthLoadAction); return true;
                case "depthRenderTarget": _value = global::Luny.UnityEngine.Rendering.LuaRenderTargetIdentifier.Bind(m_Value.depthRenderTarget); return true;
                case "depthStoreAction": _value = new global::Lua.LuaValue((global::System.Int64)m_Value.depthStoreAction); return true;
                case "flags": _value = new global::Lua.LuaValue((global::System.Int64)m_Value.flags); return true;
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
                case "colorLoadActions": { var _temp = m_Value; _temp.colorLoadActions = _value.Read<global::UnityEngine.Rendering.RenderBufferLoadAction[]>(); m_Value = _temp; } return true;
                case "colorRenderTargets": { var _temp = m_Value; _temp.colorRenderTargets = _value.Read<global::UnityEngine.Rendering.RenderTargetIdentifier[]>(); m_Value = _temp; } return true;
                case "colorStoreActions": { var _temp = m_Value; _temp.colorStoreActions = _value.Read<global::UnityEngine.Rendering.RenderBufferStoreAction[]>(); m_Value = _temp; } return true;
                case "depthLoadAction": { var _temp = m_Value; _temp.depthLoadAction = _value.Read<global::UnityEngine.Rendering.RenderBufferLoadAction>(); m_Value = _temp; } return true;
                case "depthRenderTarget": { var _temp = m_Value; _temp.depthRenderTarget = _value.Read<global::Luny.UnityEngine.Rendering.LuaRenderTargetIdentifier>().Value; m_Value = _temp; } return true;
                case "depthStoreAction": { var _temp = m_Value; _temp.depthStoreAction = _value.Read<global::UnityEngine.Rendering.RenderBufferStoreAction>(); m_Value = _temp; } return true;
                case "flags": { var _temp = m_Value; _temp.flags = _value.Read<global::UnityEngine.Rendering.RenderTargetFlags>(); m_Value = _temp; } return true;
                default: return false;
            }
        }
    }
    public sealed class LuaRenderTargetBindingType : global::Luny.ILuaStatic
    {
        public static global::Lua.LuaValue Bind() => new LuaRenderTargetBindingType();
        private LuaRenderTargetBindingType() {}
        public static implicit operator global::Lua.LuaValue(LuaRenderTargetBindingType value) => new(value);
        public global::System.Type BindType => typeof(global::UnityEngine.Rendering.RenderTargetBinding);
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
            metatable[global::Lua.Runtime.Metamethods.Call] = _LuaRenderTargetBinding_new;
            return metatable;
        }
        public override global::System.String ToString() => BindType.FullName;
#if UNITY_EDITOR
        [global::UnityEngine.RuntimeInitializeOnLoadMethod(global::UnityEngine.RuntimeInitializeLoadType.SubsystemRegistration)]
        private static void ResetStaticFields() => s_Metatable = null;
#endif

        private static readonly global::Lua.LuaFunction _LuaRenderTargetBinding_new = new global::Lua.LuaFunction(".ctor", (_context, _) =>
        {
            global::Lua.LuaValue _lastArg = default;
            global::System.Int32 _lastArgPos = default;
            global::System.Type _expectedType = default;
            var _argCount = _context.ArgumentCount;
            // ctor parameterless case
            if (_argCount == 1)
            {
                var _ret0 = new global::UnityEngine.Rendering.RenderTargetBinding();
                var _lret0 = global::Luny.UnityEngine.Rendering.LuaRenderTargetBinding.Bind(_ret0);
                var _retCount = _context.Return(_lret0);
                return new global::System.Threading.Tasks.ValueTask<global::System.Int32>(_retCount);
            }
            var _arg0 = _lastArg = _argCount > 1 ? _context.GetArgument(1) : global::Lua.LuaValue.Nil;
            _lastArgPos = 0; _expectedType = typeof(global::Luny.UnityEngine.LuaRenderTargetSetup);
            if (_arg0.TryRead<global::Luny.UnityEngine.LuaRenderTargetSetup>(out var _p0_UnityEngine_RenderTargetSetup))
            {
                if (_argCount == 2)
                {
                    var setup = _p0_UnityEngine_RenderTargetSetup.Value;
                    var _ret0 = new global::UnityEngine.Rendering.RenderTargetBinding(setup);
                    var _lret0 = global::Luny.UnityEngine.Rendering.LuaRenderTargetBinding.Bind(_ret0);
                    var _retCount = _context.Return(_lret0);
                    return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                }
            }
            _lastArgPos = 0; _expectedType = typeof(global::Luny.UnityEngine.Rendering.LuaRenderTargetIdentifier);
            if (_arg0.TryRead<global::Luny.UnityEngine.Rendering.LuaRenderTargetIdentifier>(out var _p0_UnityEngine_Rendering_RenderTargetIdentifier))
            {
                var _arg1 = _lastArg = _argCount > 2 ? _context.GetArgument(2) : global::Lua.LuaValue.Nil;
                _lastArgPos = 1; _expectedType = typeof(global::UnityEngine.Rendering.RenderBufferLoadAction);
                if (_arg1.TryRead<global::UnityEngine.Rendering.RenderBufferLoadAction>(out var _p1_UnityEngine_Rendering_RenderBufferLoadAction))
                {
                    var _arg2 = _lastArg = _argCount > 3 ? _context.GetArgument(3) : global::Lua.LuaValue.Nil;
                    _lastArgPos = 2; _expectedType = typeof(global::UnityEngine.Rendering.RenderBufferStoreAction);
                    if (_arg2.TryRead<global::UnityEngine.Rendering.RenderBufferStoreAction>(out var _p2_UnityEngine_Rendering_RenderBufferStoreAction))
                    {
                        var _arg3 = _lastArg = _argCount > 4 ? _context.GetArgument(4) : global::Lua.LuaValue.Nil;
                        _lastArgPos = 3; _expectedType = typeof(global::Luny.UnityEngine.Rendering.LuaRenderTargetIdentifier);
                        if (_arg3.TryRead<global::Luny.UnityEngine.Rendering.LuaRenderTargetIdentifier>(out var _p3_UnityEngine_Rendering_RenderTargetIdentifier))
                        {
                            var _arg4 = _lastArg = _argCount > 5 ? _context.GetArgument(5) : global::Lua.LuaValue.Nil;
                            _lastArgPos = 4; _expectedType = typeof(global::UnityEngine.Rendering.RenderBufferLoadAction);
                            if (_arg4.TryRead<global::UnityEngine.Rendering.RenderBufferLoadAction>(out var _p4_UnityEngine_Rendering_RenderBufferLoadAction))
                            {
                                var _arg5 = _lastArg = _argCount > 6 ? _context.GetArgument(6) : global::Lua.LuaValue.Nil;
                                _lastArgPos = 5; _expectedType = typeof(global::UnityEngine.Rendering.RenderBufferStoreAction);
                                if (_arg5.TryRead<global::UnityEngine.Rendering.RenderBufferStoreAction>(out var _p5_UnityEngine_Rendering_RenderBufferStoreAction))
                                {
                                    if (_argCount == 7)
                                    {
                                        var colorRenderTarget = _p0_UnityEngine_Rendering_RenderTargetIdentifier.Value;
                                        var colorLoadAction = _p1_UnityEngine_Rendering_RenderBufferLoadAction;
                                        var colorStoreAction = _p2_UnityEngine_Rendering_RenderBufferStoreAction;
                                        var depthRenderTarget = _p3_UnityEngine_Rendering_RenderTargetIdentifier.Value;
                                        var depthLoadAction = _p4_UnityEngine_Rendering_RenderBufferLoadAction;
                                        var depthStoreAction = _p5_UnityEngine_Rendering_RenderBufferStoreAction;
                                        var _ret0 = new global::UnityEngine.Rendering.RenderTargetBinding(colorRenderTarget, colorLoadAction, colorStoreAction, depthRenderTarget, depthLoadAction, depthStoreAction);
                                        var _lret0 = global::Luny.UnityEngine.Rendering.LuaRenderTargetBinding.Bind(_ret0);
                                        var _retCount = _context.Return(_lret0);
                                        return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                                    }
                                }
                            }
                        }
                    }
                }
            }
            _lastArgPos = 0; _expectedType = typeof(global::UnityEngine.Rendering.RenderTargetIdentifier[]);
            if (_arg0.TryReadArray<global::UnityEngine.Rendering.RenderTargetIdentifier>(out var _p0_UnityEngine_Rendering_RenderTargetIdentifierArray))
            {
                var _arg1 = _lastArg = _argCount > 2 ? _context.GetArgument(2) : global::Lua.LuaValue.Nil;
                _lastArgPos = 1; _expectedType = typeof(global::UnityEngine.Rendering.RenderBufferLoadAction[]);
                if (_arg1.TryReadArray<global::UnityEngine.Rendering.RenderBufferLoadAction>(out var _p1_UnityEngine_Rendering_RenderBufferLoadActionArray))
                {
                    var _arg2 = _lastArg = _argCount > 3 ? _context.GetArgument(3) : global::Lua.LuaValue.Nil;
                    _lastArgPos = 2; _expectedType = typeof(global::UnityEngine.Rendering.RenderBufferStoreAction[]);
                    if (_arg2.TryReadArray<global::UnityEngine.Rendering.RenderBufferStoreAction>(out var _p2_UnityEngine_Rendering_RenderBufferStoreActionArray))
                    {
                        var _arg3 = _lastArg = _argCount > 4 ? _context.GetArgument(4) : global::Lua.LuaValue.Nil;
                        _lastArgPos = 3; _expectedType = typeof(global::Luny.UnityEngine.Rendering.LuaRenderTargetIdentifier);
                        if (_arg3.TryRead<global::Luny.UnityEngine.Rendering.LuaRenderTargetIdentifier>(out var _p3_UnityEngine_Rendering_RenderTargetIdentifier))
                        {
                            var _arg4 = _lastArg = _argCount > 5 ? _context.GetArgument(5) : global::Lua.LuaValue.Nil;
                            _lastArgPos = 4; _expectedType = typeof(global::UnityEngine.Rendering.RenderBufferLoadAction);
                            if (_arg4.TryRead<global::UnityEngine.Rendering.RenderBufferLoadAction>(out var _p4_UnityEngine_Rendering_RenderBufferLoadAction))
                            {
                                var _arg5 = _lastArg = _argCount > 6 ? _context.GetArgument(6) : global::Lua.LuaValue.Nil;
                                _lastArgPos = 5; _expectedType = typeof(global::UnityEngine.Rendering.RenderBufferStoreAction);
                                if (_arg5.TryRead<global::UnityEngine.Rendering.RenderBufferStoreAction>(out var _p5_UnityEngine_Rendering_RenderBufferStoreAction))
                                {
                                    if (_argCount == 7)
                                    {
                                        var colorRenderTargets = _p0_UnityEngine_Rendering_RenderTargetIdentifierArray;
                                        var colorLoadActions = _p1_UnityEngine_Rendering_RenderBufferLoadActionArray;
                                        var colorStoreActions = _p2_UnityEngine_Rendering_RenderBufferStoreActionArray;
                                        var depthRenderTarget = _p3_UnityEngine_Rendering_RenderTargetIdentifier.Value;
                                        var depthLoadAction = _p4_UnityEngine_Rendering_RenderBufferLoadAction;
                                        var depthStoreAction = _p5_UnityEngine_Rendering_RenderBufferStoreAction;
                                        var _ret0 = new global::UnityEngine.Rendering.RenderTargetBinding(colorRenderTargets, colorLoadActions, colorStoreActions, depthRenderTarget, depthLoadAction, depthStoreAction);
                                        var _lret0 = global::Luny.UnityEngine.Rendering.LuaRenderTargetBinding.Bind(_ret0);
                                        var _retCount = _context.Return(_lret0);
                                        return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                                    }
                                }
                            }
                        }
                    }
                }
            }
            throw new global::Lua.LuaRuntimeException(_context.Thread, $"{".ctor"}: invalid argument #{_lastArgPos}: {_lastArg} ({_lastArg.Type}), expected: {_expectedType.FullName}", 2);
        });
        private static readonly global::Lua.LuaFunction __index = new(global::Lua.Runtime.Metamethods.Index, (_context, _) =>
        {
            var _this = _context.GetArgument<LuaRenderTargetBindingType>(0);
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
            var _this = _context.GetArgument<LuaRenderTargetBindingType>(0);
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
