
// --------------------------------------------------------------
// GENERATED FILE ----> DO NOT EDIT <---- CHANGES WILL BE LOST !!
// --------------------------------------------------------------

#if UNITY_6000_1_OR_NEWER && !(UNITY_6000_2_OR_NEWER)
#pragma warning disable 0109, 0162, 0168, 0219
using Luny;

namespace Luny.UnityEngine.Rendering
{
    public sealed class LuaRenderTargetBlendState : global::Luny.ILuaValueType<global::UnityEngine.Rendering.RenderTargetBlendState>
    {
        public new static global::Lua.LuaValue Bind(in global::UnityEngine.Rendering.RenderTargetBlendState instance) => new LuaRenderTargetBlendState(instance);
        public new static global::Lua.LuaValue Bind(global::System.Object instance) => Bind((global::UnityEngine.Rendering.RenderTargetBlendState)instance);
        public new static global::Lua.LuaValue Bind(global::System.Collections.Generic.IList<global::UnityEngine.Rendering.RenderTargetBlendState> instances) =>
            new global::Luny.LuaList<global::UnityEngine.Rendering.RenderTargetBlendState>(instances);
        public new static global::Lua.LuaValue Bind(global::System.Collections.Generic.IList<global::System.Object> instances) =>
            new global::Luny.LuaList<global::UnityEngine.Rendering.RenderTargetBlendState>(instances);
        private LuaRenderTargetBlendState(in global::UnityEngine.Rendering.RenderTargetBlendState value) => m_Value = value;
        public static implicit operator global::Lua.LuaValue(LuaRenderTargetBlendState value) => new(value);
        private global::UnityEngine.Rendering.RenderTargetBlendState m_Value;
        public global::UnityEngine.Rendering.RenderTargetBlendState Value { get => m_Value; set => m_Value = value; }
        public ref global::UnityEngine.Rendering.RenderTargetBlendState ValueRef => ref m_Value;
        public global::System.Type BindType => typeof(global::UnityEngine.Rendering.RenderTargetBlendState);
        public override global::System.String ToString() => m_Value.ToString();
#if UNITY_EDITOR
        [global::UnityEngine.RuntimeInitializeOnLoadMethod(global::UnityEngine.RuntimeInitializeLoadType.SubsystemRegistration)]
        private static void ResetStaticFields() => s_Metatable = null;
#endif

        private static readonly global::Lua.LuaFunction _LuaRenderTargetBlendState_Equals = new global::Lua.LuaFunction("Equals", (_context, _) =>
        {
            global::Lua.LuaValue _lastArg = default;
            global::System.Int32 _lastArgPos = default;
            global::System.Type _expectedType = default;
            var _argCount = _context.ArgumentCount;
            var _this = _context.GetArgument<LuaRenderTargetBlendState>(0);
            var _arg0 = _lastArg = _argCount > 1 ? _context.GetArgument(1) : global::Lua.LuaValue.Nil;
            _lastArgPos = 0; _expectedType = typeof(global::Luny.UnityEngine.Rendering.LuaRenderTargetBlendState);
            if (_arg0.TryRead<global::Luny.UnityEngine.Rendering.LuaRenderTargetBlendState>(out var _p0_UnityEngine_Rendering_RenderTargetBlendState))
            {
                if (_argCount == 2)
                {
                    var other = _p0_UnityEngine_Rendering_RenderTargetBlendState.Value;
                    var _ret0 = _this.m_Value.Equals(other);
                    var _lret0 = new global::Lua.LuaValue(_ret0);
                    var _retCount = _context.Return(_lret0);
                    return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                }
            }
            _lastArgPos = 0; _expectedType = typeof(global::System.Object);
            if (_arg0.TryRead<global::System.Object>(out var _p0_System_Object))
            {
                if (_argCount == 2)
                {
                    var obj = _p0_System_Object;
                    var _ret0 = _this.m_Value.Equals(obj);
                    var _lret0 = new global::Lua.LuaValue(_ret0);
                    var _retCount = _context.Return(_lret0);
                    return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                }
            }
            throw new global::Lua.LuaRuntimeException(_context.Thread, $"{"Equals"}: invalid argument #{_lastArgPos}: {_lastArg} ({_lastArg.Type}), expected: {_expectedType.FullName}", 2);
        });
        private static readonly global::Lua.LuaFunction _LuaRenderTargetBlendState_GetHashCode = new global::Lua.LuaFunction("GetHashCode", (_context, _) =>
        {
            global::Lua.LuaValue _lastArg = default;
            global::System.Int32 _lastArgPos = default;
            global::System.Type _expectedType = default;
            var _argCount = _context.ArgumentCount;
            var _this = _context.GetArgument<LuaRenderTargetBlendState>(0);
            if (_argCount == 1)
            {
                var _ret0 = _this.m_Value.GetHashCode();
                var _lret0 = new global::Lua.LuaValue(_ret0);
                var _retCount = _context.Return(_lret0);
                return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
            }
            throw new global::Lua.LuaRuntimeException(_context.Thread, $"{"GetHashCode"}: invalid argument #{_lastArgPos}: {_lastArg} ({_lastArg.Type}), expected: {_expectedType.FullName}", 2);
        });
        private static readonly global::Lua.LuaFunction __index = new(global::Lua.Runtime.Metamethods.Index, (_context, _) =>
        {
            var _this = _context.GetArgument<LuaRenderTargetBlendState>(0);
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
            var _this = _context.GetArgument<LuaRenderTargetBlendState>(0);
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
                case "Equals": _value = _LuaRenderTargetBlendState_Equals; return true;
                case "GetHashCode": _value = _LuaRenderTargetBlendState_GetHashCode; return true;
                case "alphaBlendOperation": _value = new global::Lua.LuaValue((global::System.Int64)m_Value.alphaBlendOperation); return true;
                case "colorBlendOperation": _value = new global::Lua.LuaValue((global::System.Int64)m_Value.colorBlendOperation); return true;
                case "destinationAlphaBlendMode": _value = new global::Lua.LuaValue((global::System.Int64)m_Value.destinationAlphaBlendMode); return true;
                case "destinationColorBlendMode": _value = new global::Lua.LuaValue((global::System.Int64)m_Value.destinationColorBlendMode); return true;
                case "sourceAlphaBlendMode": _value = new global::Lua.LuaValue((global::System.Int64)m_Value.sourceAlphaBlendMode); return true;
                case "sourceColorBlendMode": _value = new global::Lua.LuaValue((global::System.Int64)m_Value.sourceColorBlendMode); return true;
                case "writeMask": _value = new global::Lua.LuaValue((global::System.Int64)m_Value.writeMask); return true;
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
                case "alphaBlendOperation": { var _temp = m_Value; _temp.alphaBlendOperation = _value.Read<global::UnityEngine.Rendering.BlendOp>(); m_Value = _temp; } return true;
                case "colorBlendOperation": { var _temp = m_Value; _temp.colorBlendOperation = _value.Read<global::UnityEngine.Rendering.BlendOp>(); m_Value = _temp; } return true;
                case "destinationAlphaBlendMode": { var _temp = m_Value; _temp.destinationAlphaBlendMode = _value.Read<global::UnityEngine.Rendering.BlendMode>(); m_Value = _temp; } return true;
                case "destinationColorBlendMode": { var _temp = m_Value; _temp.destinationColorBlendMode = _value.Read<global::UnityEngine.Rendering.BlendMode>(); m_Value = _temp; } return true;
                case "sourceAlphaBlendMode": { var _temp = m_Value; _temp.sourceAlphaBlendMode = _value.Read<global::UnityEngine.Rendering.BlendMode>(); m_Value = _temp; } return true;
                case "sourceColorBlendMode": { var _temp = m_Value; _temp.sourceColorBlendMode = _value.Read<global::UnityEngine.Rendering.BlendMode>(); m_Value = _temp; } return true;
                case "writeMask": { var _temp = m_Value; _temp.writeMask = _value.Read<global::UnityEngine.Rendering.ColorWriteMask>(); m_Value = _temp; } return true;
                default: return false;
            }
        }
    }
    public sealed class LuaRenderTargetBlendStateType : global::Luny.ILuaStatic
    {
        public static global::Lua.LuaValue Bind() => new LuaRenderTargetBlendStateType();
        private LuaRenderTargetBlendStateType() {}
        public static implicit operator global::Lua.LuaValue(LuaRenderTargetBlendStateType value) => new(value);
        public global::System.Type BindType => typeof(global::UnityEngine.Rendering.RenderTargetBlendState);
        public override global::System.String ToString() => BindType.FullName;
#if UNITY_EDITOR
        [global::UnityEngine.RuntimeInitializeOnLoadMethod(global::UnityEngine.RuntimeInitializeLoadType.SubsystemRegistration)]
        private static void ResetStaticFields() => s_Metatable = null;
#endif

        private static readonly global::Lua.LuaFunction _LuaRenderTargetBlendState_new = new global::Lua.LuaFunction(".ctor", (_context, _) =>
        {
            global::Lua.LuaValue _lastArg = default;
            global::System.Int32 _lastArgPos = default;
            global::System.Type _expectedType = default;
            var _argCount = _context.ArgumentCount;
            // ctor parameterless case
            if (_argCount == 1)
            {
                var _ret0 = new global::UnityEngine.Rendering.RenderTargetBlendState();
                var _lret0 = global::Luny.UnityEngine.Rendering.LuaRenderTargetBlendState.Bind(_ret0);
                var _retCount = _context.Return(_lret0);
                return new global::System.Threading.Tasks.ValueTask<global::System.Int32>(_retCount);
            }
            if (_argCount == 1)
            {
                var _ret0 = new global::UnityEngine.Rendering.RenderTargetBlendState();
                var _lret0 = global::Luny.UnityEngine.Rendering.LuaRenderTargetBlendState.Bind(_ret0);
                var _retCount = _context.Return(_lret0);
                return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
            }
            var _arg0 = _lastArg = _argCount > 1 ? _context.GetArgument(1) : global::Lua.LuaValue.Nil;
            _lastArgPos = 0; _expectedType = typeof(global::UnityEngine.Rendering.ColorWriteMask);
            var _p0_UnityEngine_Rendering_ColorWriteMask = _arg0.ReadValue<global::UnityEngine.Rendering.ColorWriteMask>(global::UnityEngine.Rendering.ColorWriteMask.@All);
            {
                if (_argCount == 2)
                {
                    var writeMask = _p0_UnityEngine_Rendering_ColorWriteMask;
                    var _ret0 = new global::UnityEngine.Rendering.RenderTargetBlendState(writeMask);
                    var _lret0 = global::Luny.UnityEngine.Rendering.LuaRenderTargetBlendState.Bind(_ret0);
                    var _retCount = _context.Return(_lret0);
                    return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                }
                var _arg1 = _lastArg = _argCount > 2 ? _context.GetArgument(2) : global::Lua.LuaValue.Nil;
                _lastArgPos = 1; _expectedType = typeof(global::UnityEngine.Rendering.BlendMode);
                var _p1_UnityEngine_Rendering_BlendMode = _arg1.ReadValue<global::UnityEngine.Rendering.BlendMode>(global::UnityEngine.Rendering.BlendMode.@One);
                {
                    if (_argCount == 3)
                    {
                        var writeMask = _p0_UnityEngine_Rendering_ColorWriteMask;
                        var sourceColorBlendMode = _p1_UnityEngine_Rendering_BlendMode;
                        var _ret0 = new global::UnityEngine.Rendering.RenderTargetBlendState(writeMask, sourceColorBlendMode);
                        var _lret0 = global::Luny.UnityEngine.Rendering.LuaRenderTargetBlendState.Bind(_ret0);
                        var _retCount = _context.Return(_lret0);
                        return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                    }
                    var _arg2 = _lastArg = _argCount > 3 ? _context.GetArgument(3) : global::Lua.LuaValue.Nil;
                    _lastArgPos = 2; _expectedType = typeof(global::UnityEngine.Rendering.BlendMode);
                    var _p2_UnityEngine_Rendering_BlendMode = _arg2.ReadValue<global::UnityEngine.Rendering.BlendMode>(global::UnityEngine.Rendering.BlendMode.@Zero);
                    {
                        if (_argCount == 4)
                        {
                            var writeMask = _p0_UnityEngine_Rendering_ColorWriteMask;
                            var sourceColorBlendMode = _p1_UnityEngine_Rendering_BlendMode;
                            var destinationColorBlendMode = _p2_UnityEngine_Rendering_BlendMode;
                            var _ret0 = new global::UnityEngine.Rendering.RenderTargetBlendState(writeMask, sourceColorBlendMode, destinationColorBlendMode);
                            var _lret0 = global::Luny.UnityEngine.Rendering.LuaRenderTargetBlendState.Bind(_ret0);
                            var _retCount = _context.Return(_lret0);
                            return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                        }
                        var _arg3 = _lastArg = _argCount > 4 ? _context.GetArgument(4) : global::Lua.LuaValue.Nil;
                        _lastArgPos = 3; _expectedType = typeof(global::UnityEngine.Rendering.BlendMode);
                        var _p3_UnityEngine_Rendering_BlendMode = _arg3.ReadValue<global::UnityEngine.Rendering.BlendMode>(global::UnityEngine.Rendering.BlendMode.@One);
                        {
                            if (_argCount == 5)
                            {
                                var writeMask = _p0_UnityEngine_Rendering_ColorWriteMask;
                                var sourceColorBlendMode = _p1_UnityEngine_Rendering_BlendMode;
                                var destinationColorBlendMode = _p2_UnityEngine_Rendering_BlendMode;
                                var sourceAlphaBlendMode = _p3_UnityEngine_Rendering_BlendMode;
                                var _ret0 = new global::UnityEngine.Rendering.RenderTargetBlendState(writeMask, sourceColorBlendMode, destinationColorBlendMode, sourceAlphaBlendMode);
                                var _lret0 = global::Luny.UnityEngine.Rendering.LuaRenderTargetBlendState.Bind(_ret0);
                                var _retCount = _context.Return(_lret0);
                                return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                            }
                            var _arg4 = _lastArg = _argCount > 5 ? _context.GetArgument(5) : global::Lua.LuaValue.Nil;
                            _lastArgPos = 4; _expectedType = typeof(global::UnityEngine.Rendering.BlendMode);
                            var _p4_UnityEngine_Rendering_BlendMode = _arg4.ReadValue<global::UnityEngine.Rendering.BlendMode>(global::UnityEngine.Rendering.BlendMode.@Zero);
                            {
                                if (_argCount == 6)
                                {
                                    var writeMask = _p0_UnityEngine_Rendering_ColorWriteMask;
                                    var sourceColorBlendMode = _p1_UnityEngine_Rendering_BlendMode;
                                    var destinationColorBlendMode = _p2_UnityEngine_Rendering_BlendMode;
                                    var sourceAlphaBlendMode = _p3_UnityEngine_Rendering_BlendMode;
                                    var destinationAlphaBlendMode = _p4_UnityEngine_Rendering_BlendMode;
                                    var _ret0 = new global::UnityEngine.Rendering.RenderTargetBlendState(writeMask, sourceColorBlendMode, destinationColorBlendMode, sourceAlphaBlendMode, destinationAlphaBlendMode);
                                    var _lret0 = global::Luny.UnityEngine.Rendering.LuaRenderTargetBlendState.Bind(_ret0);
                                    var _retCount = _context.Return(_lret0);
                                    return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                                }
                                var _arg5 = _lastArg = _argCount > 6 ? _context.GetArgument(6) : global::Lua.LuaValue.Nil;
                                _lastArgPos = 5; _expectedType = typeof(global::UnityEngine.Rendering.BlendOp);
                                var _p5_UnityEngine_Rendering_BlendOp = _arg5.ReadValue<global::UnityEngine.Rendering.BlendOp>(global::UnityEngine.Rendering.BlendOp.@Add);
                                {
                                    if (_argCount == 7)
                                    {
                                        var writeMask = _p0_UnityEngine_Rendering_ColorWriteMask;
                                        var sourceColorBlendMode = _p1_UnityEngine_Rendering_BlendMode;
                                        var destinationColorBlendMode = _p2_UnityEngine_Rendering_BlendMode;
                                        var sourceAlphaBlendMode = _p3_UnityEngine_Rendering_BlendMode;
                                        var destinationAlphaBlendMode = _p4_UnityEngine_Rendering_BlendMode;
                                        var colorBlendOperation = _p5_UnityEngine_Rendering_BlendOp;
                                        var _ret0 = new global::UnityEngine.Rendering.RenderTargetBlendState(writeMask, sourceColorBlendMode, destinationColorBlendMode, sourceAlphaBlendMode, destinationAlphaBlendMode, colorBlendOperation);
                                        var _lret0 = global::Luny.UnityEngine.Rendering.LuaRenderTargetBlendState.Bind(_ret0);
                                        var _retCount = _context.Return(_lret0);
                                        return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                                    }
                                    var _arg6 = _lastArg = _argCount > 7 ? _context.GetArgument(7) : global::Lua.LuaValue.Nil;
                                    _lastArgPos = 6; _expectedType = typeof(global::UnityEngine.Rendering.BlendOp);
                                    var _p6_UnityEngine_Rendering_BlendOp = _arg6.ReadValue<global::UnityEngine.Rendering.BlendOp>(global::UnityEngine.Rendering.BlendOp.@Add);
                                    {
                                        if (_argCount == 8)
                                        {
                                            var writeMask = _p0_UnityEngine_Rendering_ColorWriteMask;
                                            var sourceColorBlendMode = _p1_UnityEngine_Rendering_BlendMode;
                                            var destinationColorBlendMode = _p2_UnityEngine_Rendering_BlendMode;
                                            var sourceAlphaBlendMode = _p3_UnityEngine_Rendering_BlendMode;
                                            var destinationAlphaBlendMode = _p4_UnityEngine_Rendering_BlendMode;
                                            var colorBlendOperation = _p5_UnityEngine_Rendering_BlendOp;
                                            var alphaBlendOperation = _p6_UnityEngine_Rendering_BlendOp;
                                            var _ret0 = new global::UnityEngine.Rendering.RenderTargetBlendState(writeMask, sourceColorBlendMode, destinationColorBlendMode, sourceAlphaBlendMode, destinationAlphaBlendMode, colorBlendOperation, alphaBlendOperation);
                                            var _lret0 = global::Luny.UnityEngine.Rendering.LuaRenderTargetBlendState.Bind(_ret0);
                                            var _retCount = _context.Return(_lret0);
                                            return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                                        }
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
            var _this = _context.GetArgument<LuaRenderTargetBlendStateType>(0);
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
            var _this = _context.GetArgument<LuaRenderTargetBlendStateType>(0);
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
            metatable[global::Lua.Runtime.Metamethods.Call] = _LuaRenderTargetBlendState_new;
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
                case "defaultValue": _value = global::Luny.UnityEngine.Rendering.LuaRenderTargetBlendState.Bind(global::UnityEngine.Rendering.RenderTargetBlendState.defaultValue); return true;
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
