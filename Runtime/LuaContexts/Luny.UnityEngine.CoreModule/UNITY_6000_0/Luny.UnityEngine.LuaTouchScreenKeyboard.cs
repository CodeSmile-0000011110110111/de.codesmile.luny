
// --------------------------------------------------------------
// GENERATED FILE ----> DO NOT EDIT <---- CHANGES WILL BE LOST !!
// --------------------------------------------------------------

#if UNITY_6000_0_OR_NEWER && !(UNITY_6000_1_OR_NEWER)
#pragma warning disable 0109, 0162, 0168, 0219
using Luny;

namespace Luny.UnityEngine
{
    public class LuaTouchScreenKeyboard : global::Luny.ILuaObject<global::UnityEngine.TouchScreenKeyboard>
    {
        public new static global::Lua.LuaValue Bind(global::UnityEngine.TouchScreenKeyboard instance) => new LuaTouchScreenKeyboard(instance);
        public new static global::Lua.LuaValue Bind(global::System.Object instance) => Bind((global::UnityEngine.TouchScreenKeyboard)instance);
        public new static global::Lua.LuaValue Bind(global::System.Collections.Generic.IList<global::UnityEngine.TouchScreenKeyboard> instances) =>
            new global::Luny.LuaList<global::UnityEngine.TouchScreenKeyboard>(instances);
        public new static global::Lua.LuaValue Bind(global::System.Collections.Generic.IList<global::System.Object> instances) =>
            new global::Luny.LuaList<global::UnityEngine.TouchScreenKeyboard>(instances);
        protected LuaTouchScreenKeyboard(global::UnityEngine.TouchScreenKeyboard instance) => m_Instance = instance;
        public static implicit operator global::Lua.LuaValue(LuaTouchScreenKeyboard value) => new(value);
        protected global::UnityEngine.TouchScreenKeyboard m_Instance;
        public global::UnityEngine.TouchScreenKeyboard Instance => m_Instance;
        public new global::System.Type BindType => typeof(global::UnityEngine.TouchScreenKeyboard);
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
        public override global::System.String ToString() => m_Instance != null ? Instance.ToString() : "{GetType().Name}(null)";
#if UNITY_EDITOR
        [global::UnityEngine.RuntimeInitializeOnLoadMethod(global::UnityEngine.RuntimeInitializeLoadType.SubsystemRegistration)]
        private static void ResetStaticFields() => s_Metatable = null;
#endif

        private static readonly global::Lua.LuaFunction __index = new(global::Lua.Runtime.Metamethods.Index, (_context, _) =>
        {
            var _this = _context.GetArgument<LuaTouchScreenKeyboard>(0);
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
            var _this = _context.GetArgument<LuaTouchScreenKeyboard>(0);
            var _key = _context.GetArgument(1);
            var _value = _context.GetArgument(2);
            if (_key.Type == global::Lua.LuaValueType.Number && _key.TryRead<global::System.Int32>(out var _index) && _this.TrySetLuaValue(_index, _value))
                return new global::System.Threading.Tasks.ValueTask<global::System.Int32>(_context.Return(_value));
            if (_key.Type == global::Lua.LuaValueType.String && _this.TrySetLuaValue(_key.Read<global::System.String>(), _value))
                return new global::System.Threading.Tasks.ValueTask<global::System.Int32>(_context.Return(_value));
            throw new global::Lua.LuaRuntimeException(_context.Thread, $"attempt to assign to unknown '{_key}' on '{_this}'", 2);
        });

        public virtual global::System.Boolean TryGetLuaValue(global::System.Int32 _key, out global::Lua.LuaValue _value, global::Luny.ILuaObjectFactory _factory)
        {
            _value = global::Lua.LuaValue.Nil; return false;
        }
        public virtual global::System.Boolean TryGetLuaValue(global::System.String _key, out global::Lua.LuaValue _value, global::Luny.ILuaObjectFactory _factory)
        {
            switch (_key)
            {
                case "active": _value = new global::Lua.LuaValue(Instance.active); return true;
                case "canGetSelection": _value = new global::Lua.LuaValue(Instance.canGetSelection); return true;
                case "canSetSelection": _value = new global::Lua.LuaValue(Instance.canSetSelection); return true;
                case "characterLimit": _value = new global::Lua.LuaValue(Instance.characterLimit); return true;
                case "selection": _value = global::Luny.UnityEngine.LuaRangeInt.Bind(Instance.selection); return true;
                case "status": _value = new global::Lua.LuaValue((global::System.Int64)Instance.status); return true;
                case "targetDisplay": _value = new global::Lua.LuaValue(Instance.targetDisplay); return true;
                case "text": _value = new global::Lua.LuaValue(Instance.text); return true;
                case "type": _value = new global::Lua.LuaValue((global::System.Int64)Instance.type); return true;
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
                case "active": Instance.active = _value.Read<global::System.Boolean>();  return true;
                case "characterLimit": Instance.characterLimit = _value.Read<global::System.Int32>();  return true;
                case "selection": Instance.selection = _value.Read<global::Luny.UnityEngine.LuaRangeInt>().Value;  return true;
                case "targetDisplay": Instance.targetDisplay = _value.Read<global::System.Int32>();  return true;
                case "text": Instance.text = _value.Read<global::System.String>();  return true;
                default: return false;
            }
        }
    }
    public sealed class LuaTouchScreenKeyboardType : global::Luny.ILuaStatic
    {
        public static global::Lua.LuaValue Bind() => new LuaTouchScreenKeyboardType();
        private LuaTouchScreenKeyboardType() {}
        public static implicit operator global::Lua.LuaValue(LuaTouchScreenKeyboardType value) => new(value);
        public global::System.Type BindType => typeof(global::UnityEngine.TouchScreenKeyboard);
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
            metatable[global::Lua.Runtime.Metamethods.Call] = _LuaTouchScreenKeyboard_new;
            return metatable;
        }
        public override global::System.String ToString() => BindType.FullName;
#if UNITY_EDITOR
        [global::UnityEngine.RuntimeInitializeOnLoadMethod(global::UnityEngine.RuntimeInitializeLoadType.SubsystemRegistration)]
        private static void ResetStaticFields() => s_Metatable = null;
#endif

        private static readonly global::Lua.LuaFunction _LuaTouchScreenKeyboard_new = new global::Lua.LuaFunction(".ctor", (_context, _) =>
        {
            global::Lua.LuaValue _lastArg = default;
            global::System.Int32 _lastArgPos = default;
            global::System.Type _expectedType = default;
            var _argCount = _context.ArgumentCount;
            var _arg0 = _lastArg = _argCount > 1 ? _context.GetArgument(1) : global::Lua.LuaValue.Nil;
            _lastArgPos = 0; _expectedType = typeof(global::System.String);
            if (_arg0.TryRead<global::System.String>(out var _p0_System_String))
            {
                var _arg1 = _lastArg = _argCount > 2 ? _context.GetArgument(2) : global::Lua.LuaValue.Nil;
                _lastArgPos = 1; _expectedType = typeof(global::UnityEngine.TouchScreenKeyboardType);
                if (_arg1.TryRead<global::UnityEngine.TouchScreenKeyboardType>(out var _p1_UnityEngine_TouchScreenKeyboardType))
                {
                    var _arg2 = _lastArg = _argCount > 3 ? _context.GetArgument(3) : global::Lua.LuaValue.Nil;
                    _lastArgPos = 2; _expectedType = typeof(global::System.Boolean);
                    if (_arg2.TryRead<global::System.Boolean>(out var _p2_System_Boolean))
                    {
                        var _arg3 = _lastArg = _argCount > 4 ? _context.GetArgument(4) : global::Lua.LuaValue.Nil;
                        _lastArgPos = 3; _expectedType = typeof(global::System.Boolean);
                        if (_arg3.TryRead<global::System.Boolean>(out var _p3_System_Boolean))
                        {
                            var _arg4 = _lastArg = _argCount > 5 ? _context.GetArgument(5) : global::Lua.LuaValue.Nil;
                            _lastArgPos = 4; _expectedType = typeof(global::System.Boolean);
                            if (_arg4.TryRead<global::System.Boolean>(out var _p4_System_Boolean))
                            {
                                var _arg5 = _lastArg = _argCount > 6 ? _context.GetArgument(6) : global::Lua.LuaValue.Nil;
                                _lastArgPos = 5; _expectedType = typeof(global::System.Boolean);
                                if (_arg5.TryRead<global::System.Boolean>(out var _p5_System_Boolean))
                                {
                                    var _arg6 = _lastArg = _argCount > 7 ? _context.GetArgument(7) : global::Lua.LuaValue.Nil;
                                    _lastArgPos = 6; _expectedType = typeof(global::System.String);
                                    if (_arg6.TryRead<global::System.String>(out var _p6_System_String))
                                    {
                                        var _arg7 = _lastArg = _argCount > 8 ? _context.GetArgument(8) : global::Lua.LuaValue.Nil;
                                        _lastArgPos = 7; _expectedType = typeof(global::System.Int32);
                                        if (_arg7.TryRead<global::System.Int32>(out var _p7_System_Int32))
                                        {
                                            if (_argCount == 9)
                                            {
                                                var text = _p0_System_String;
                                                var keyboardType = _p1_UnityEngine_TouchScreenKeyboardType;
                                                var autocorrection = _p2_System_Boolean;
                                                var multiline = _p3_System_Boolean;
                                                var secure = _p4_System_Boolean;
                                                var alert = _p5_System_Boolean;
                                                var textPlaceholder = _p6_System_String;
                                                var characterLimit = _p7_System_Int32;
                                                var _ret0 = new global::UnityEngine.TouchScreenKeyboard(text, keyboardType, autocorrection, multiline, secure, alert, textPlaceholder, characterLimit);
                                                var _factory = _context.GetObjectFactory();
                                                var _lret0 = _factory.Bind(_ret0);
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
            throw new global::Lua.LuaRuntimeException(_context.Thread, $"{".ctor"}: invalid argument #{_lastArgPos}: {_lastArg} ({_lastArg.Type}), expected: {_expectedType.FullName}", 2);
        });
        private static readonly global::Lua.LuaFunction _LuaTouchScreenKeyboard_Open = new global::Lua.LuaFunction("Open", (_context, _) =>
        {
            global::Lua.LuaValue _lastArg = default;
            global::System.Int32 _lastArgPos = default;
            global::System.Type _expectedType = default;
            var _argCount = _context.ArgumentCount;
            var _arg0 = _lastArg = _argCount > 0 ? _context.GetArgument(0) : global::Lua.LuaValue.Nil;
            _lastArgPos = 0; _expectedType = typeof(global::System.String);
            if (_arg0.TryRead<global::System.String>(out var _p0_System_String))
            {
                if (_argCount == 1)
                {
                    var text = _p0_System_String;
                    var _ret0 = global::UnityEngine.TouchScreenKeyboard.Open(text);
                    var _factory = _context.GetObjectFactory();
                    var _lret0 = _factory.Bind(_ret0);
                    var _retCount = _context.Return(_lret0);
                    return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                }
                var _arg1 = _lastArg = _argCount > 1 ? _context.GetArgument(1) : global::Lua.LuaValue.Nil;
                _lastArgPos = 1; _expectedType = typeof(global::UnityEngine.TouchScreenKeyboardType);
                if (_arg1.TryRead<global::UnityEngine.TouchScreenKeyboardType>(out var _p1_UnityEngine_TouchScreenKeyboardType))
                {
                    if (_argCount == 2)
                    {
                        var text = _p0_System_String;
                        var keyboardType = _p1_UnityEngine_TouchScreenKeyboardType;
                        var _ret0 = global::UnityEngine.TouchScreenKeyboard.Open(text, keyboardType);
                        var _factory = _context.GetObjectFactory();
                        var _lret0 = _factory.Bind(_ret0);
                        var _retCount = _context.Return(_lret0);
                        return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                    }
                    var _arg2 = _lastArg = _argCount > 2 ? _context.GetArgument(2) : global::Lua.LuaValue.Nil;
                    _lastArgPos = 2; _expectedType = typeof(global::System.Boolean);
                    if (_arg2.TryRead<global::System.Boolean>(out var _p2_System_Boolean))
                    {
                        if (_argCount == 3)
                        {
                            var text = _p0_System_String;
                            var keyboardType = _p1_UnityEngine_TouchScreenKeyboardType;
                            var autocorrection = _p2_System_Boolean;
                            var _ret0 = global::UnityEngine.TouchScreenKeyboard.Open(text, keyboardType, autocorrection);
                            var _factory = _context.GetObjectFactory();
                            var _lret0 = _factory.Bind(_ret0);
                            var _retCount = _context.Return(_lret0);
                            return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                        }
                        var _arg3 = _lastArg = _argCount > 3 ? _context.GetArgument(3) : global::Lua.LuaValue.Nil;
                        _lastArgPos = 3; _expectedType = typeof(global::System.Boolean);
                        if (_arg3.TryRead<global::System.Boolean>(out var _p3_System_Boolean))
                        {
                            if (_argCount == 4)
                            {
                                var text = _p0_System_String;
                                var keyboardType = _p1_UnityEngine_TouchScreenKeyboardType;
                                var autocorrection = _p2_System_Boolean;
                                var multiline = _p3_System_Boolean;
                                var _ret0 = global::UnityEngine.TouchScreenKeyboard.Open(text, keyboardType, autocorrection, multiline);
                                var _factory = _context.GetObjectFactory();
                                var _lret0 = _factory.Bind(_ret0);
                                var _retCount = _context.Return(_lret0);
                                return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                            }
                            var _arg4 = _lastArg = _argCount > 4 ? _context.GetArgument(4) : global::Lua.LuaValue.Nil;
                            _lastArgPos = 4; _expectedType = typeof(global::System.Boolean);
                            if (_arg4.TryRead<global::System.Boolean>(out var _p4_System_Boolean))
                            {
                                if (_argCount == 5)
                                {
                                    var text = _p0_System_String;
                                    var keyboardType = _p1_UnityEngine_TouchScreenKeyboardType;
                                    var autocorrection = _p2_System_Boolean;
                                    var multiline = _p3_System_Boolean;
                                    var secure = _p4_System_Boolean;
                                    var _ret0 = global::UnityEngine.TouchScreenKeyboard.Open(text, keyboardType, autocorrection, multiline, secure);
                                    var _factory = _context.GetObjectFactory();
                                    var _lret0 = _factory.Bind(_ret0);
                                    var _retCount = _context.Return(_lret0);
                                    return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                                }
                                var _arg5 = _lastArg = _argCount > 5 ? _context.GetArgument(5) : global::Lua.LuaValue.Nil;
                                _lastArgPos = 5; _expectedType = typeof(global::System.Boolean);
                                if (_arg5.TryRead<global::System.Boolean>(out var _p5_System_Boolean))
                                {
                                    if (_argCount == 6)
                                    {
                                        var text = _p0_System_String;
                                        var keyboardType = _p1_UnityEngine_TouchScreenKeyboardType;
                                        var autocorrection = _p2_System_Boolean;
                                        var multiline = _p3_System_Boolean;
                                        var secure = _p4_System_Boolean;
                                        var alert = _p5_System_Boolean;
                                        var _ret0 = global::UnityEngine.TouchScreenKeyboard.Open(text, keyboardType, autocorrection, multiline, secure, alert);
                                        var _factory = _context.GetObjectFactory();
                                        var _lret0 = _factory.Bind(_ret0);
                                        var _retCount = _context.Return(_lret0);
                                        return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                                    }
                                    var _arg6 = _lastArg = _argCount > 6 ? _context.GetArgument(6) : global::Lua.LuaValue.Nil;
                                    _lastArgPos = 6; _expectedType = typeof(global::System.String);
                                    if (_arg6.TryRead<global::System.String>(out var _p6_System_String))
                                    {
                                        if (_argCount == 7)
                                        {
                                            var text = _p0_System_String;
                                            var keyboardType = _p1_UnityEngine_TouchScreenKeyboardType;
                                            var autocorrection = _p2_System_Boolean;
                                            var multiline = _p3_System_Boolean;
                                            var secure = _p4_System_Boolean;
                                            var alert = _p5_System_Boolean;
                                            var textPlaceholder = _p6_System_String;
                                            var _ret0 = global::UnityEngine.TouchScreenKeyboard.Open(text, keyboardType, autocorrection, multiline, secure, alert, textPlaceholder);
                                            var _factory = _context.GetObjectFactory();
                                            var _lret0 = _factory.Bind(_ret0);
                                            var _retCount = _context.Return(_lret0);
                                            return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                                        }
                                        var _arg7 = _lastArg = _argCount > 7 ? _context.GetArgument(7) : global::Lua.LuaValue.Nil;
                                        _lastArgPos = 7; _expectedType = typeof(global::System.Int32);
                                        if (_arg7.TryRead<global::System.Int32>(out var _p7_System_Int32))
                                        {
                                            if (_argCount == 8)
                                            {
                                                var text = _p0_System_String;
                                                var keyboardType = _p1_UnityEngine_TouchScreenKeyboardType;
                                                var autocorrection = _p2_System_Boolean;
                                                var multiline = _p3_System_Boolean;
                                                var secure = _p4_System_Boolean;
                                                var alert = _p5_System_Boolean;
                                                var textPlaceholder = _p6_System_String;
                                                var characterLimit = _p7_System_Int32;
                                                var _ret0 = global::UnityEngine.TouchScreenKeyboard.Open(text, keyboardType, autocorrection, multiline, secure, alert, textPlaceholder, characterLimit);
                                                var _factory = _context.GetObjectFactory();
                                                var _lret0 = _factory.Bind(_ret0);
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
            throw new global::Lua.LuaRuntimeException(_context.Thread, $"{"Open"}: invalid argument #{_lastArgPos}: {_lastArg} ({_lastArg.Type}), expected: {_expectedType.FullName}", 2);
        });
        private static readonly global::Lua.LuaFunction __index = new(global::Lua.Runtime.Metamethods.Index, (_context, _) =>
        {
            var _this = _context.GetArgument<LuaTouchScreenKeyboardType>(0);
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
            var _this = _context.GetArgument<LuaTouchScreenKeyboardType>(0);
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
                case "Open": _value = _LuaTouchScreenKeyboard_Open; return true;
                case "area": _value = global::Luny.UnityEngine.LuaRect.Bind(global::UnityEngine.TouchScreenKeyboard.area); return true;
                case "hideInput": _value = new global::Lua.LuaValue(global::UnityEngine.TouchScreenKeyboard.hideInput); return true;
                case "inputFieldAppearance": _value = new global::Lua.LuaValue((global::System.Int64)global::UnityEngine.TouchScreenKeyboard.inputFieldAppearance); return true;
                case "isInPlaceEditingAllowed": _value = new global::Lua.LuaValue(global::UnityEngine.TouchScreenKeyboard.isInPlaceEditingAllowed); return true;
                case "isSupported": _value = new global::Lua.LuaValue(global::UnityEngine.TouchScreenKeyboard.isSupported); return true;
                case "visible": _value = new global::Lua.LuaValue(global::UnityEngine.TouchScreenKeyboard.visible); return true;
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
                case "hideInput": global::UnityEngine.TouchScreenKeyboard.hideInput = _value.Read<global::System.Boolean>();  return true;
                default: return false;
            }
        }
    }
}
#pragma warning restore 0109, 0162, 0168, 0219
#endif
