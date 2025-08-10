
// --------------------------------------------------------------
// GENERATED FILE ----> DO NOT EDIT <---- CHANGES WILL BE LOST !!
// --------------------------------------------------------------

#if UNITY_6000_1_OR_NEWER && !(UNITY_6000_2_OR_NEWER)
#pragma warning disable 0109, 0162, 0168, 0219
using Luny;

namespace Luny.UnityEditor
{
    public sealed class LuaEditorCurveBinding : global::Luny.ILuaValueType<global::UnityEditor.EditorCurveBinding>
    {
        public new static global::Lua.LuaValue Bind(in global::UnityEditor.EditorCurveBinding instance) => new LuaEditorCurveBinding(instance);
        public new static global::Lua.LuaValue Bind(global::System.Object instance) => Bind((global::UnityEditor.EditorCurveBinding)instance);
        public new static global::Lua.LuaValue Bind(global::System.Collections.Generic.IList<global::UnityEditor.EditorCurveBinding> instances) =>
            new global::Luny.LuaList<global::UnityEditor.EditorCurveBinding>(instances);
        public new static global::Lua.LuaValue Bind(global::System.Collections.Generic.IList<global::System.Object> instances) =>
            new global::Luny.LuaList<global::UnityEditor.EditorCurveBinding>(instances);
        private LuaEditorCurveBinding(in global::UnityEditor.EditorCurveBinding value) => m_Value = value;
        public static implicit operator global::Lua.LuaValue(LuaEditorCurveBinding value) => new(value);
        private global::UnityEditor.EditorCurveBinding m_Value;
        public global::UnityEditor.EditorCurveBinding Value { get => m_Value; set => m_Value = value; }
        public ref global::UnityEditor.EditorCurveBinding ValueRef => ref m_Value;
        public global::System.Type BindType => typeof(global::UnityEditor.EditorCurveBinding);
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

        private static readonly global::Lua.LuaFunction _LuaEditorCurveBinding_Equals = new global::Lua.LuaFunction("Equals", (_context, _) =>
        {
            global::Lua.LuaValue _lastArg = default;
            global::System.Int32 _lastArgPos = default;
            global::System.Type _expectedType = default;
            var _argCount = _context.ArgumentCount;
            var _this = _context.GetArgument<LuaEditorCurveBinding>(0);
            var _arg0 = _lastArg = _argCount > 1 ? _context.GetArgument(1) : global::Lua.LuaValue.Nil;
            _lastArgPos = 0; _expectedType = typeof(global::Luny.UnityEditor.LuaEditorCurveBinding);
            if (_arg0.TryRead<global::Luny.UnityEditor.LuaEditorCurveBinding>(out var _p0_UnityEditor_EditorCurveBinding))
            {
                if (_argCount == 2)
                {
                    var other = _p0_UnityEditor_EditorCurveBinding.Value;
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
                    var other = _p0_System_Object;
                    var _ret0 = _this.m_Value.Equals(other);
                    var _lret0 = new global::Lua.LuaValue(_ret0);
                    var _retCount = _context.Return(_lret0);
                    return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                }
            }
            throw new global::Lua.LuaRuntimeException(_context.Thread, $"{"Equals"}: invalid argument #{_lastArgPos}: {_lastArg} ({_lastArg.Type}), expected: {_expectedType.FullName}", 2);
        });
        private static readonly global::Lua.LuaFunction _LuaEditorCurveBinding_GetHashCode = new global::Lua.LuaFunction("GetHashCode", (_context, _) =>
        {
            global::Lua.LuaValue _lastArg = default;
            global::System.Int32 _lastArgPos = default;
            global::System.Type _expectedType = default;
            var _argCount = _context.ArgumentCount;
            var _this = _context.GetArgument<LuaEditorCurveBinding>(0);
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
            var _this = _context.GetArgument<LuaEditorCurveBinding>(0);
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
            var _this = _context.GetArgument<LuaEditorCurveBinding>(0);
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
                case "Equals": _value = _LuaEditorCurveBinding_Equals; return true;
                case "GetHashCode": _value = _LuaEditorCurveBinding_GetHashCode; return true;
                case "isDiscreteCurve": _value = new global::Lua.LuaValue(m_Value.isDiscreteCurve); return true;
                case "isPPtrCurve": _value = new global::Lua.LuaValue(m_Value.isPPtrCurve); return true;
                case "isSerializeReferenceCurve": _value = new global::Lua.LuaValue(m_Value.isSerializeReferenceCurve); return true;
                case "type": _value = _factory.Bind(m_Value.type); return true;
                case "path": _value = new global::Lua.LuaValue(m_Value.path); return true;
                case "propertyName": _value = new global::Lua.LuaValue(m_Value.propertyName); return true;
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
                case "type": { var _temp = m_Value; _temp.type = _value.Read<global::System.Type>(); m_Value = _temp; } return true;
                case "path": { var _temp = m_Value; _temp.path = _value.Read<global::System.String>(); m_Value = _temp; } return true;
                case "propertyName": { var _temp = m_Value; _temp.propertyName = _value.Read<global::System.String>(); m_Value = _temp; } return true;
                default: return false;
            }
        }
    }
    public sealed class LuaEditorCurveBindingType : global::Luny.ILuaStatic
    {
        public static global::Lua.LuaValue Bind() => new LuaEditorCurveBindingType();
        private LuaEditorCurveBindingType() {}
        public static implicit operator global::Lua.LuaValue(LuaEditorCurveBindingType value) => new(value);
        public global::System.Type BindType => typeof(global::UnityEditor.EditorCurveBinding);
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

        private static readonly global::Lua.LuaFunction _LuaEditorCurveBinding_DiscreteCurve = new global::Lua.LuaFunction("DiscreteCurve", (_context, _) =>
        {
            global::Lua.LuaValue _lastArg = default;
            global::System.Int32 _lastArgPos = default;
            global::System.Type _expectedType = default;
            var _argCount = _context.ArgumentCount;
            var _arg0 = _lastArg = _argCount > 0 ? _context.GetArgument(0) : global::Lua.LuaValue.Nil;
            _lastArgPos = 0; _expectedType = typeof(global::System.String);
            if (_arg0.TryRead<global::System.String>(out var _p0_System_String))
            {
                var _arg1 = _lastArg = _argCount > 1 ? _context.GetArgument(1) : global::Lua.LuaValue.Nil;
                _lastArgPos = 1; _expectedType = typeof(global::Luny.ILuaBindType);
                if (_arg1.TryRead<global::Luny.ILuaBindType>(out var _p1_System_Type))
                {
                    var _arg2 = _lastArg = _argCount > 2 ? _context.GetArgument(2) : global::Lua.LuaValue.Nil;
                    _lastArgPos = 2; _expectedType = typeof(global::System.String);
                    if (_arg2.TryRead<global::System.String>(out var _p2_System_String))
                    {
                        if (_argCount == 3)
                        {
                            var inPath = _p0_System_String;
                            var inType = _p1_System_Type.BindType;
                            var inPropertyName = _p2_System_String;
                            var _ret0 = global::UnityEditor.EditorCurveBinding.DiscreteCurve(inPath, inType, inPropertyName);
                            var _lret0 = global::Luny.UnityEditor.LuaEditorCurveBinding.Bind(_ret0);
                            var _retCount = _context.Return(_lret0);
                            return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                        }
                    }
                }
            }
            throw new global::Lua.LuaRuntimeException(_context.Thread, $"{"DiscreteCurve"}: invalid argument #{_lastArgPos}: {_lastArg} ({_lastArg.Type}), expected: {_expectedType.FullName}", 2);
        });
        private static readonly global::Lua.LuaFunction _LuaEditorCurveBinding_FloatCurve = new global::Lua.LuaFunction("FloatCurve", (_context, _) =>
        {
            global::Lua.LuaValue _lastArg = default;
            global::System.Int32 _lastArgPos = default;
            global::System.Type _expectedType = default;
            var _argCount = _context.ArgumentCount;
            var _arg0 = _lastArg = _argCount > 0 ? _context.GetArgument(0) : global::Lua.LuaValue.Nil;
            _lastArgPos = 0; _expectedType = typeof(global::System.String);
            if (_arg0.TryRead<global::System.String>(out var _p0_System_String))
            {
                var _arg1 = _lastArg = _argCount > 1 ? _context.GetArgument(1) : global::Lua.LuaValue.Nil;
                _lastArgPos = 1; _expectedType = typeof(global::Luny.ILuaBindType);
                if (_arg1.TryRead<global::Luny.ILuaBindType>(out var _p1_System_Type))
                {
                    var _arg2 = _lastArg = _argCount > 2 ? _context.GetArgument(2) : global::Lua.LuaValue.Nil;
                    _lastArgPos = 2; _expectedType = typeof(global::System.String);
                    if (_arg2.TryRead<global::System.String>(out var _p2_System_String))
                    {
                        if (_argCount == 3)
                        {
                            var inPath = _p0_System_String;
                            var inType = _p1_System_Type.BindType;
                            var inPropertyName = _p2_System_String;
                            var _ret0 = global::UnityEditor.EditorCurveBinding.FloatCurve(inPath, inType, inPropertyName);
                            var _lret0 = global::Luny.UnityEditor.LuaEditorCurveBinding.Bind(_ret0);
                            var _retCount = _context.Return(_lret0);
                            return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                        }
                    }
                }
            }
            throw new global::Lua.LuaRuntimeException(_context.Thread, $"{"FloatCurve"}: invalid argument #{_lastArgPos}: {_lastArg} ({_lastArg.Type}), expected: {_expectedType.FullName}", 2);
        });
        private static readonly global::Lua.LuaFunction _LuaEditorCurveBinding_PPtrCurve = new global::Lua.LuaFunction("PPtrCurve", (_context, _) =>
        {
            global::Lua.LuaValue _lastArg = default;
            global::System.Int32 _lastArgPos = default;
            global::System.Type _expectedType = default;
            var _argCount = _context.ArgumentCount;
            var _arg0 = _lastArg = _argCount > 0 ? _context.GetArgument(0) : global::Lua.LuaValue.Nil;
            _lastArgPos = 0; _expectedType = typeof(global::System.String);
            if (_arg0.TryRead<global::System.String>(out var _p0_System_String))
            {
                var _arg1 = _lastArg = _argCount > 1 ? _context.GetArgument(1) : global::Lua.LuaValue.Nil;
                _lastArgPos = 1; _expectedType = typeof(global::Luny.ILuaBindType);
                if (_arg1.TryRead<global::Luny.ILuaBindType>(out var _p1_System_Type))
                {
                    var _arg2 = _lastArg = _argCount > 2 ? _context.GetArgument(2) : global::Lua.LuaValue.Nil;
                    _lastArgPos = 2; _expectedType = typeof(global::System.String);
                    if (_arg2.TryRead<global::System.String>(out var _p2_System_String))
                    {
                        if (_argCount == 3)
                        {
                            var inPath = _p0_System_String;
                            var inType = _p1_System_Type.BindType;
                            var inPropertyName = _p2_System_String;
                            var _ret0 = global::UnityEditor.EditorCurveBinding.PPtrCurve(inPath, inType, inPropertyName);
                            var _lret0 = global::Luny.UnityEditor.LuaEditorCurveBinding.Bind(_ret0);
                            var _retCount = _context.Return(_lret0);
                            return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                        }
                    }
                }
            }
            throw new global::Lua.LuaRuntimeException(_context.Thread, $"{"PPtrCurve"}: invalid argument #{_lastArgPos}: {_lastArg} ({_lastArg.Type}), expected: {_expectedType.FullName}", 2);
        });
        private static readonly global::Lua.LuaFunction _LuaEditorCurveBinding_SerializeReferenceCurve = new global::Lua.LuaFunction("SerializeReferenceCurve", (_context, _) =>
        {
            global::Lua.LuaValue _lastArg = default;
            global::System.Int32 _lastArgPos = default;
            global::System.Type _expectedType = default;
            var _argCount = _context.ArgumentCount;
            var _arg0 = _lastArg = _argCount > 0 ? _context.GetArgument(0) : global::Lua.LuaValue.Nil;
            _lastArgPos = 0; _expectedType = typeof(global::System.String);
            if (_arg0.TryRead<global::System.String>(out var _p0_System_String))
            {
                var _arg1 = _lastArg = _argCount > 1 ? _context.GetArgument(1) : global::Lua.LuaValue.Nil;
                _lastArgPos = 1; _expectedType = typeof(global::Luny.ILuaBindType);
                if (_arg1.TryRead<global::Luny.ILuaBindType>(out var _p1_System_Type))
                {
                    var _arg2 = _lastArg = _argCount > 2 ? _context.GetArgument(2) : global::Lua.LuaValue.Nil;
                    _lastArgPos = 2; _expectedType = typeof(global::System.Int64);
                    if (_arg2.TryRead<global::System.Int64>(out var _p2_System_Int64))
                    {
                        var _arg3 = _lastArg = _argCount > 3 ? _context.GetArgument(3) : global::Lua.LuaValue.Nil;
                        _lastArgPos = 3; _expectedType = typeof(global::System.String);
                        if (_arg3.TryRead<global::System.String>(out var _p3_System_String))
                        {
                            var _arg4 = _lastArg = _argCount > 4 ? _context.GetArgument(4) : global::Lua.LuaValue.Nil;
                            _lastArgPos = 4; _expectedType = typeof(global::System.Boolean);
                            if (_arg4.TryRead<global::System.Boolean>(out var _p4_System_Boolean))
                            {
                                var _arg5 = _lastArg = _argCount > 5 ? _context.GetArgument(5) : global::Lua.LuaValue.Nil;
                                _lastArgPos = 5; _expectedType = typeof(global::System.Boolean);
                                if (_arg5.TryRead<global::System.Boolean>(out var _p5_System_Boolean))
                                {
                                    if (_argCount == 6)
                                    {
                                        var inPath = _p0_System_String;
                                        var inType = _p1_System_Type.BindType;
                                        var refID = _p2_System_Int64;
                                        var inPropertyName = _p3_System_String;
                                        var isPPtr = _p4_System_Boolean;
                                        var isDiscrete = _p5_System_Boolean;
                                        var _ret0 = global::UnityEditor.EditorCurveBinding.SerializeReferenceCurve(inPath, inType, refID, inPropertyName, isPPtr, isDiscrete);
                                        var _lret0 = global::Luny.UnityEditor.LuaEditorCurveBinding.Bind(_ret0);
                                        var _retCount = _context.Return(_lret0);
                                        return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                                    }
                                }
                            }
                        }
                    }
                }
            }
            throw new global::Lua.LuaRuntimeException(_context.Thread, $"{"SerializeReferenceCurve"}: invalid argument #{_lastArgPos}: {_lastArg} ({_lastArg.Type}), expected: {_expectedType.FullName}", 2);
        });
        private static readonly global::Lua.LuaFunction __index = new(global::Lua.Runtime.Metamethods.Index, (_context, _) =>
        {
            var _this = _context.GetArgument<LuaEditorCurveBindingType>(0);
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
            var _this = _context.GetArgument<LuaEditorCurveBindingType>(0);
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
                case "DiscreteCurve": _value = _LuaEditorCurveBinding_DiscreteCurve; return true;
                case "FloatCurve": _value = _LuaEditorCurveBinding_FloatCurve; return true;
                case "PPtrCurve": _value = _LuaEditorCurveBinding_PPtrCurve; return true;
                case "SerializeReferenceCurve": _value = _LuaEditorCurveBinding_SerializeReferenceCurve; return true;
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
