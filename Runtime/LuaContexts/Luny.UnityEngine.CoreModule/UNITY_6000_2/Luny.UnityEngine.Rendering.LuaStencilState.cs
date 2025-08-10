
// --------------------------------------------------------------
// GENERATED FILE ----> DO NOT EDIT <---- CHANGES WILL BE LOST !!
// --------------------------------------------------------------

#if UNITY_6000_2_OR_NEWER && !(UNITY_6000_3_OR_NEWER)
#pragma warning disable 0109, 0162, 0168, 0219
using Luny;

namespace Luny.UnityEngine.Rendering
{
    public sealed class LuaStencilState : global::Luny.ILuaValueType<global::UnityEngine.Rendering.StencilState>
    {
        public new static global::Lua.LuaValue Bind(in global::UnityEngine.Rendering.StencilState instance) => new LuaStencilState(instance);
        public new static global::Lua.LuaValue Bind(global::System.Object instance) => Bind((global::UnityEngine.Rendering.StencilState)instance);
        public new static global::Lua.LuaValue Bind(global::System.Collections.Generic.IList<global::UnityEngine.Rendering.StencilState> instances) =>
            new global::Luny.LuaList<global::UnityEngine.Rendering.StencilState>(instances);
        public new static global::Lua.LuaValue Bind(global::System.Collections.Generic.IList<global::System.Object> instances) =>
            new global::Luny.LuaList<global::UnityEngine.Rendering.StencilState>(instances);
        private LuaStencilState(in global::UnityEngine.Rendering.StencilState value) => m_Value = value;
        public static implicit operator global::Lua.LuaValue(LuaStencilState value) => new(value);
        private global::UnityEngine.Rendering.StencilState m_Value;
        public global::UnityEngine.Rendering.StencilState Value { get => m_Value; set => m_Value = value; }
        public ref global::UnityEngine.Rendering.StencilState ValueRef => ref m_Value;
        public global::System.Type BindType => typeof(global::UnityEngine.Rendering.StencilState);
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

        private static readonly global::Lua.LuaFunction _LuaStencilState_Equals = new global::Lua.LuaFunction("Equals", (_context, _) =>
        {
            global::Lua.LuaValue _lastArg = default;
            global::System.Int32 _lastArgPos = default;
            global::System.Type _expectedType = default;
            var _argCount = _context.ArgumentCount;
            var _this = _context.GetArgument<LuaStencilState>(0);
            var _arg0 = _lastArg = _argCount > 1 ? _context.GetArgument(1) : global::Lua.LuaValue.Nil;
            _lastArgPos = 0; _expectedType = typeof(global::Luny.UnityEngine.Rendering.LuaStencilState);
            if (_arg0.TryRead<global::Luny.UnityEngine.Rendering.LuaStencilState>(out var _p0_UnityEngine_Rendering_StencilState))
            {
                if (_argCount == 2)
                {
                    var other = _p0_UnityEngine_Rendering_StencilState.Value;
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
        private static readonly global::Lua.LuaFunction _LuaStencilState_GetHashCode = new global::Lua.LuaFunction("GetHashCode", (_context, _) =>
        {
            global::Lua.LuaValue _lastArg = default;
            global::System.Int32 _lastArgPos = default;
            global::System.Type _expectedType = default;
            var _argCount = _context.ArgumentCount;
            var _this = _context.GetArgument<LuaStencilState>(0);
            if (_argCount == 1)
            {
                var _ret0 = _this.m_Value.GetHashCode();
                var _lret0 = new global::Lua.LuaValue(_ret0);
                var _retCount = _context.Return(_lret0);
                return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
            }
            throw new global::Lua.LuaRuntimeException(_context.Thread, $"{"GetHashCode"}: invalid argument #{_lastArgPos}: {_lastArg} ({_lastArg.Type}), expected: {_expectedType.FullName}", 2);
        });
        private static readonly global::Lua.LuaFunction _LuaStencilState_SetCompareFunction = new global::Lua.LuaFunction("SetCompareFunction", (_context, _) =>
        {
            global::Lua.LuaValue _lastArg = default;
            global::System.Int32 _lastArgPos = default;
            global::System.Type _expectedType = default;
            var _argCount = _context.ArgumentCount;
            var _this = _context.GetArgument<LuaStencilState>(0);
            var _arg0 = _lastArg = _argCount > 1 ? _context.GetArgument(1) : global::Lua.LuaValue.Nil;
            _lastArgPos = 0; _expectedType = typeof(global::UnityEngine.Rendering.CompareFunction);
            if (_arg0.TryRead<global::UnityEngine.Rendering.CompareFunction>(out var _p0_UnityEngine_Rendering_CompareFunction))
            {
                if (_argCount == 2)
                {
                    var value = _p0_UnityEngine_Rendering_CompareFunction;
                    _this.m_Value.SetCompareFunction(value);
                    var _retCount = _context.Return();
                    return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                }
            }
            throw new global::Lua.LuaRuntimeException(_context.Thread, $"{"SetCompareFunction"}: invalid argument #{_lastArgPos}: {_lastArg} ({_lastArg.Type}), expected: {_expectedType.FullName}", 2);
        });
        private static readonly global::Lua.LuaFunction _LuaStencilState_SetFailOperation = new global::Lua.LuaFunction("SetFailOperation", (_context, _) =>
        {
            global::Lua.LuaValue _lastArg = default;
            global::System.Int32 _lastArgPos = default;
            global::System.Type _expectedType = default;
            var _argCount = _context.ArgumentCount;
            var _this = _context.GetArgument<LuaStencilState>(0);
            var _arg0 = _lastArg = _argCount > 1 ? _context.GetArgument(1) : global::Lua.LuaValue.Nil;
            _lastArgPos = 0; _expectedType = typeof(global::UnityEngine.Rendering.StencilOp);
            if (_arg0.TryRead<global::UnityEngine.Rendering.StencilOp>(out var _p0_UnityEngine_Rendering_StencilOp))
            {
                if (_argCount == 2)
                {
                    var value = _p0_UnityEngine_Rendering_StencilOp;
                    _this.m_Value.SetFailOperation(value);
                    var _retCount = _context.Return();
                    return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                }
            }
            throw new global::Lua.LuaRuntimeException(_context.Thread, $"{"SetFailOperation"}: invalid argument #{_lastArgPos}: {_lastArg} ({_lastArg.Type}), expected: {_expectedType.FullName}", 2);
        });
        private static readonly global::Lua.LuaFunction _LuaStencilState_SetPassOperation = new global::Lua.LuaFunction("SetPassOperation", (_context, _) =>
        {
            global::Lua.LuaValue _lastArg = default;
            global::System.Int32 _lastArgPos = default;
            global::System.Type _expectedType = default;
            var _argCount = _context.ArgumentCount;
            var _this = _context.GetArgument<LuaStencilState>(0);
            var _arg0 = _lastArg = _argCount > 1 ? _context.GetArgument(1) : global::Lua.LuaValue.Nil;
            _lastArgPos = 0; _expectedType = typeof(global::UnityEngine.Rendering.StencilOp);
            if (_arg0.TryRead<global::UnityEngine.Rendering.StencilOp>(out var _p0_UnityEngine_Rendering_StencilOp))
            {
                if (_argCount == 2)
                {
                    var value = _p0_UnityEngine_Rendering_StencilOp;
                    _this.m_Value.SetPassOperation(value);
                    var _retCount = _context.Return();
                    return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                }
            }
            throw new global::Lua.LuaRuntimeException(_context.Thread, $"{"SetPassOperation"}: invalid argument #{_lastArgPos}: {_lastArg} ({_lastArg.Type}), expected: {_expectedType.FullName}", 2);
        });
        private static readonly global::Lua.LuaFunction _LuaStencilState_SetZFailOperation = new global::Lua.LuaFunction("SetZFailOperation", (_context, _) =>
        {
            global::Lua.LuaValue _lastArg = default;
            global::System.Int32 _lastArgPos = default;
            global::System.Type _expectedType = default;
            var _argCount = _context.ArgumentCount;
            var _this = _context.GetArgument<LuaStencilState>(0);
            var _arg0 = _lastArg = _argCount > 1 ? _context.GetArgument(1) : global::Lua.LuaValue.Nil;
            _lastArgPos = 0; _expectedType = typeof(global::UnityEngine.Rendering.StencilOp);
            if (_arg0.TryRead<global::UnityEngine.Rendering.StencilOp>(out var _p0_UnityEngine_Rendering_StencilOp))
            {
                if (_argCount == 2)
                {
                    var value = _p0_UnityEngine_Rendering_StencilOp;
                    _this.m_Value.SetZFailOperation(value);
                    var _retCount = _context.Return();
                    return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                }
            }
            throw new global::Lua.LuaRuntimeException(_context.Thread, $"{"SetZFailOperation"}: invalid argument #{_lastArgPos}: {_lastArg} ({_lastArg.Type}), expected: {_expectedType.FullName}", 2);
        });
        private static readonly global::Lua.LuaFunction __index = new(global::Lua.Runtime.Metamethods.Index, (_context, _) =>
        {
            var _this = _context.GetArgument<LuaStencilState>(0);
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
            var _this = _context.GetArgument<LuaStencilState>(0);
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
                case "Equals": _value = _LuaStencilState_Equals; return true;
                case "GetHashCode": _value = _LuaStencilState_GetHashCode; return true;
                case "SetCompareFunction": _value = _LuaStencilState_SetCompareFunction; return true;
                case "SetFailOperation": _value = _LuaStencilState_SetFailOperation; return true;
                case "SetPassOperation": _value = _LuaStencilState_SetPassOperation; return true;
                case "SetZFailOperation": _value = _LuaStencilState_SetZFailOperation; return true;
                case "compareFunctionBack": _value = new global::Lua.LuaValue((global::System.Int64)m_Value.compareFunctionBack); return true;
                case "compareFunctionFront": _value = new global::Lua.LuaValue((global::System.Int64)m_Value.compareFunctionFront); return true;
                case "enabled": _value = new global::Lua.LuaValue(m_Value.enabled); return true;
                case "failOperationBack": _value = new global::Lua.LuaValue((global::System.Int64)m_Value.failOperationBack); return true;
                case "failOperationFront": _value = new global::Lua.LuaValue((global::System.Int64)m_Value.failOperationFront); return true;
                case "passOperationBack": _value = new global::Lua.LuaValue((global::System.Int64)m_Value.passOperationBack); return true;
                case "passOperationFront": _value = new global::Lua.LuaValue((global::System.Int64)m_Value.passOperationFront); return true;
                case "readMask": _value = new global::Lua.LuaValue(m_Value.readMask); return true;
                case "writeMask": _value = new global::Lua.LuaValue(m_Value.writeMask); return true;
                case "zFailOperationBack": _value = new global::Lua.LuaValue((global::System.Int64)m_Value.zFailOperationBack); return true;
                case "zFailOperationFront": _value = new global::Lua.LuaValue((global::System.Int64)m_Value.zFailOperationFront); return true;
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
                case "compareFunctionBack": { var _temp = m_Value; _temp.compareFunctionBack = _value.Read<global::UnityEngine.Rendering.CompareFunction>(); m_Value = _temp; } return true;
                case "compareFunctionFront": { var _temp = m_Value; _temp.compareFunctionFront = _value.Read<global::UnityEngine.Rendering.CompareFunction>(); m_Value = _temp; } return true;
                case "enabled": { var _temp = m_Value; _temp.enabled = _value.Read<global::System.Boolean>(); m_Value = _temp; } return true;
                case "failOperationBack": { var _temp = m_Value; _temp.failOperationBack = _value.Read<global::UnityEngine.Rendering.StencilOp>(); m_Value = _temp; } return true;
                case "failOperationFront": { var _temp = m_Value; _temp.failOperationFront = _value.Read<global::UnityEngine.Rendering.StencilOp>(); m_Value = _temp; } return true;
                case "passOperationBack": { var _temp = m_Value; _temp.passOperationBack = _value.Read<global::UnityEngine.Rendering.StencilOp>(); m_Value = _temp; } return true;
                case "passOperationFront": { var _temp = m_Value; _temp.passOperationFront = _value.Read<global::UnityEngine.Rendering.StencilOp>(); m_Value = _temp; } return true;
                case "readMask": { var _temp = m_Value; _temp.readMask = _value.Read<global::System.Byte>(); m_Value = _temp; } return true;
                case "writeMask": { var _temp = m_Value; _temp.writeMask = _value.Read<global::System.Byte>(); m_Value = _temp; } return true;
                case "zFailOperationBack": { var _temp = m_Value; _temp.zFailOperationBack = _value.Read<global::UnityEngine.Rendering.StencilOp>(); m_Value = _temp; } return true;
                case "zFailOperationFront": { var _temp = m_Value; _temp.zFailOperationFront = _value.Read<global::UnityEngine.Rendering.StencilOp>(); m_Value = _temp; } return true;
                default: return false;
            }
        }
    }
    public sealed class LuaStencilStateType : global::Luny.ILuaStatic
    {
        public static global::Lua.LuaValue Bind() => new LuaStencilStateType();
        private LuaStencilStateType() {}
        public static implicit operator global::Lua.LuaValue(LuaStencilStateType value) => new(value);
        public global::System.Type BindType => typeof(global::UnityEngine.Rendering.StencilState);
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

        private static readonly global::Lua.LuaFunction _LuaStencilState_new = new global::Lua.LuaFunction(".ctor", (_context, _) =>
        {
            global::Lua.LuaValue _lastArg = default;
            global::System.Int32 _lastArgPos = default;
            global::System.Type _expectedType = default;
            var _argCount = _context.ArgumentCount;
            if (_argCount == 0)
            {
                var _ret0 = new global::UnityEngine.Rendering.StencilState();
                var _lret0 = global::Luny.UnityEngine.Rendering.LuaStencilState.Bind(_ret0);
                var _retCount = _context.Return(_lret0);
                return new global::System.Threading.Tasks.ValueTask<global::System.Int32>(_retCount);
            }
            if (_argCount == 0)
            {
                var _ret0 = new global::UnityEngine.Rendering.StencilState();
                var _lret0 = global::Luny.UnityEngine.Rendering.LuaStencilState.Bind(_ret0);
                var _retCount = _context.Return(_lret0);
                return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
            }
            var _arg0 = _lastArg = _argCount > 0 ? _context.GetArgument(0) : global::Lua.LuaValue.Nil;
            _lastArgPos = 0; _expectedType = typeof(global::System.Boolean);
            var _p0_System_Boolean = _arg0.ReadValue<global::System.Boolean>((global::System.Boolean)true);
            {
                if (_argCount == 1)
                {
                    var enabled = _p0_System_Boolean;
                    var _ret0 = new global::UnityEngine.Rendering.StencilState(enabled);
                    var _lret0 = global::Luny.UnityEngine.Rendering.LuaStencilState.Bind(_ret0);
                    var _retCount = _context.Return(_lret0);
                    return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                }
                var _arg1 = _lastArg = _argCount > 1 ? _context.GetArgument(1) : global::Lua.LuaValue.Nil;
                _lastArgPos = 1; _expectedType = typeof(global::System.Byte);
                var _p1_System_Byte = _arg1.ReadValue<global::System.Byte>((global::System.Byte)(255));
                {
                    if (_argCount == 2)
                    {
                        var enabled = _p0_System_Boolean;
                        var readMask = _p1_System_Byte;
                        var _ret0 = new global::UnityEngine.Rendering.StencilState(enabled, readMask);
                        var _lret0 = global::Luny.UnityEngine.Rendering.LuaStencilState.Bind(_ret0);
                        var _retCount = _context.Return(_lret0);
                        return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                    }
                    var _arg2 = _lastArg = _argCount > 2 ? _context.GetArgument(2) : global::Lua.LuaValue.Nil;
                    _lastArgPos = 2; _expectedType = typeof(global::System.Byte);
                    var _p2_System_Byte = _arg2.ReadValue<global::System.Byte>((global::System.Byte)(255));
                    {
                        if (_argCount == 3)
                        {
                            var enabled = _p0_System_Boolean;
                            var readMask = _p1_System_Byte;
                            var writeMask = _p2_System_Byte;
                            var _ret0 = new global::UnityEngine.Rendering.StencilState(enabled, readMask, writeMask);
                            var _lret0 = global::Luny.UnityEngine.Rendering.LuaStencilState.Bind(_ret0);
                            var _retCount = _context.Return(_lret0);
                            return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                        }
                        var _arg3 = _lastArg = _argCount > 3 ? _context.GetArgument(3) : global::Lua.LuaValue.Nil;
                        _lastArgPos = 3; _expectedType = typeof(global::UnityEngine.Rendering.CompareFunction);
                        var _p3_UnityEngine_Rendering_CompareFunction = _arg3.ReadValue<global::UnityEngine.Rendering.CompareFunction>(global::UnityEngine.Rendering.CompareFunction.@Always);
                        {
                            if (_argCount == 4)
                            {
                                var enabled = _p0_System_Boolean;
                                var readMask = _p1_System_Byte;
                                var writeMask = _p2_System_Byte;
                                var compareFunction = _p3_UnityEngine_Rendering_CompareFunction;
                                var _ret0 = new global::UnityEngine.Rendering.StencilState(enabled, readMask, writeMask, compareFunction);
                                var _lret0 = global::Luny.UnityEngine.Rendering.LuaStencilState.Bind(_ret0);
                                var _retCount = _context.Return(_lret0);
                                return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                            }
                            var _arg4 = _lastArg = _argCount > 4 ? _context.GetArgument(4) : global::Lua.LuaValue.Nil;
                            _lastArgPos = 4; _expectedType = typeof(global::UnityEngine.Rendering.StencilOp);
                            var _p4_UnityEngine_Rendering_StencilOp = _arg4.ReadValue<global::UnityEngine.Rendering.StencilOp>(global::UnityEngine.Rendering.StencilOp.@Keep);
                            {
                                if (_argCount == 5)
                                {
                                    var enabled = _p0_System_Boolean;
                                    var readMask = _p1_System_Byte;
                                    var writeMask = _p2_System_Byte;
                                    var compareFunction = _p3_UnityEngine_Rendering_CompareFunction;
                                    var passOperation = _p4_UnityEngine_Rendering_StencilOp;
                                    var _ret0 = new global::UnityEngine.Rendering.StencilState(enabled, readMask, writeMask, compareFunction, passOperation);
                                    var _lret0 = global::Luny.UnityEngine.Rendering.LuaStencilState.Bind(_ret0);
                                    var _retCount = _context.Return(_lret0);
                                    return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                                }
                                var _arg5 = _lastArg = _argCount > 5 ? _context.GetArgument(5) : global::Lua.LuaValue.Nil;
                                _lastArgPos = 5; _expectedType = typeof(global::UnityEngine.Rendering.StencilOp);
                                var _p5_UnityEngine_Rendering_StencilOp = _arg5.ReadValue<global::UnityEngine.Rendering.StencilOp>(global::UnityEngine.Rendering.StencilOp.@Keep);
                                {
                                    if (_argCount == 6)
                                    {
                                        var enabled = _p0_System_Boolean;
                                        var readMask = _p1_System_Byte;
                                        var writeMask = _p2_System_Byte;
                                        var compareFunction = _p3_UnityEngine_Rendering_CompareFunction;
                                        var passOperation = _p4_UnityEngine_Rendering_StencilOp;
                                        var failOperation = _p5_UnityEngine_Rendering_StencilOp;
                                        var _ret0 = new global::UnityEngine.Rendering.StencilState(enabled, readMask, writeMask, compareFunction, passOperation, failOperation);
                                        var _lret0 = global::Luny.UnityEngine.Rendering.LuaStencilState.Bind(_ret0);
                                        var _retCount = _context.Return(_lret0);
                                        return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                                    }
                                    var _arg6 = _lastArg = _argCount > 6 ? _context.GetArgument(6) : global::Lua.LuaValue.Nil;
                                    _lastArgPos = 6; _expectedType = typeof(global::UnityEngine.Rendering.StencilOp);
                                    var _p6_UnityEngine_Rendering_StencilOp = _arg6.ReadValue<global::UnityEngine.Rendering.StencilOp>(global::UnityEngine.Rendering.StencilOp.@Keep);
                                    {
                                        if (_argCount == 7)
                                        {
                                            var enabled = _p0_System_Boolean;
                                            var readMask = _p1_System_Byte;
                                            var writeMask = _p2_System_Byte;
                                            var compareFunction = _p3_UnityEngine_Rendering_CompareFunction;
                                            var passOperation = _p4_UnityEngine_Rendering_StencilOp;
                                            var failOperation = _p5_UnityEngine_Rendering_StencilOp;
                                            var zFailOperation = _p6_UnityEngine_Rendering_StencilOp;
                                            var _ret0 = new global::UnityEngine.Rendering.StencilState(enabled, readMask, writeMask, compareFunction, passOperation, failOperation, zFailOperation);
                                            var _lret0 = global::Luny.UnityEngine.Rendering.LuaStencilState.Bind(_ret0);
                                            var _retCount = _context.Return(_lret0);
                                            return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                                        }
                                        var _arg7 = _lastArg = _argCount > 7 ? _context.GetArgument(7) : global::Lua.LuaValue.Nil;
                                        _lastArgPos = 7; _expectedType = typeof(global::UnityEngine.Rendering.CompareFunction);
                                        if (_arg7.TryRead<global::UnityEngine.Rendering.CompareFunction>(out var _p7_UnityEngine_Rendering_CompareFunction))
                                        {
                                            var _arg8 = _lastArg = _argCount > 8 ? _context.GetArgument(8) : global::Lua.LuaValue.Nil;
                                            _lastArgPos = 8; _expectedType = typeof(global::UnityEngine.Rendering.StencilOp);
                                            if (_arg8.TryRead<global::UnityEngine.Rendering.StencilOp>(out var _p8_UnityEngine_Rendering_StencilOp))
                                            {
                                                var _arg9 = _lastArg = _argCount > 9 ? _context.GetArgument(9) : global::Lua.LuaValue.Nil;
                                                _lastArgPos = 9; _expectedType = typeof(global::UnityEngine.Rendering.StencilOp);
                                                if (_arg9.TryRead<global::UnityEngine.Rendering.StencilOp>(out var _p9_UnityEngine_Rendering_StencilOp))
                                                {
                                                    var _arg10 = _lastArg = _argCount > 10 ? _context.GetArgument(10) : global::Lua.LuaValue.Nil;
                                                    _lastArgPos = 10; _expectedType = typeof(global::UnityEngine.Rendering.StencilOp);
                                                    if (_arg10.TryRead<global::UnityEngine.Rendering.StencilOp>(out var _p10_UnityEngine_Rendering_StencilOp))
                                                    {
                                                        if (_argCount == 11)
                                                        {
                                                            var enabled = _p0_System_Boolean;
                                                            var readMask = _p1_System_Byte;
                                                            var writeMask = _p2_System_Byte;
                                                            var compareFunctionFront = _p3_UnityEngine_Rendering_CompareFunction;
                                                            var passOperationFront = _p4_UnityEngine_Rendering_StencilOp;
                                                            var failOperationFront = _p5_UnityEngine_Rendering_StencilOp;
                                                            var zFailOperationFront = _p6_UnityEngine_Rendering_StencilOp;
                                                            var compareFunctionBack = _p7_UnityEngine_Rendering_CompareFunction;
                                                            var passOperationBack = _p8_UnityEngine_Rendering_StencilOp;
                                                            var failOperationBack = _p9_UnityEngine_Rendering_StencilOp;
                                                            var zFailOperationBack = _p10_UnityEngine_Rendering_StencilOp;
                                                            var _ret0 = new global::UnityEngine.Rendering.StencilState(enabled, readMask, writeMask, compareFunctionFront, passOperationFront, failOperationFront, zFailOperationFront, compareFunctionBack, passOperationBack, failOperationBack, zFailOperationBack);
                                                            var _lret0 = global::Luny.UnityEngine.Rendering.LuaStencilState.Bind(_ret0);
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
                        }
                    }
                }
            }
            throw new global::Lua.LuaRuntimeException(_context.Thread, $"{".ctor"}: invalid argument #{_lastArgPos}: {_lastArg} ({_lastArg.Type}), expected: {_expectedType.FullName}", 2);
        });
        private static readonly global::Lua.LuaFunction __index = new(global::Lua.Runtime.Metamethods.Index, (_context, _) =>
        {
            var _this = _context.GetArgument<LuaStencilStateType>(0);
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
            var _this = _context.GetArgument<LuaStencilStateType>(0);
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
                case "new": _value = _LuaStencilState_new; return true;
                case "defaultValue": _value = global::Luny.UnityEngine.Rendering.LuaStencilState.Bind(global::UnityEngine.Rendering.StencilState.defaultValue); return true;
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
