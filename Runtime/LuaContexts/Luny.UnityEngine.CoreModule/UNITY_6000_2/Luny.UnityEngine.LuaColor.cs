
// --------------------------------------------------------------
// GENERATED FILE ----> DO NOT EDIT <---- CHANGES WILL BE LOST !!
// --------------------------------------------------------------

#if UNITY_6000_2_OR_NEWER && !(UNITY_6000_3_OR_NEWER)
#pragma warning disable 0109, 0162, 0168, 0219
using Luny;

namespace Luny.UnityEngine
{
    public sealed class LuaColor : global::Luny.ILuaValueType<global::UnityEngine.Color>
    {
        public new static global::Lua.LuaValue Bind(in global::UnityEngine.Color instance) => new LuaColor(instance);
        public new static global::Lua.LuaValue Bind(global::System.Object instance) => Bind((global::UnityEngine.Color)instance);
        public new static global::Lua.LuaValue Bind(global::System.Collections.Generic.IList<global::UnityEngine.Color> instances) =>
            new global::Luny.LuaList<global::UnityEngine.Color>(instances);
        public new static global::Lua.LuaValue Bind(global::System.Collections.Generic.IList<global::System.Object> instances) =>
            new global::Luny.LuaList<global::UnityEngine.Color>(instances);
        private LuaColor(in global::UnityEngine.Color value) => m_Value = value;
        public static implicit operator global::Lua.LuaValue(LuaColor value) => new(value);
        private global::UnityEngine.Color m_Value;
        public global::UnityEngine.Color Value { get => m_Value; set => m_Value = value; }
        public ref global::UnityEngine.Color ValueRef => ref m_Value;
        public global::System.Type BindType => typeof(global::UnityEngine.Color);
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

        private static readonly global::Lua.LuaFunction _LuaColor_Equals = new global::Lua.LuaFunction("Equals", (_context, _) =>
        {
            global::Lua.LuaValue _lastArg = default;
            global::System.Int32 _lastArgPos = default;
            global::System.Type _expectedType = default;
            var _argCount = _context.ArgumentCount;
            var _this = _context.GetArgument<LuaColor>(0);
            var _arg0 = _lastArg = _argCount > 1 ? _context.GetArgument(1) : global::Lua.LuaValue.Nil;
            _lastArgPos = 0; _expectedType = typeof(global::Luny.UnityEngine.LuaColor);
            if (_arg0.TryRead<global::Luny.UnityEngine.LuaColor>(out var _p0_UnityEngine_Color))
            {
                if (_argCount == 2)
                {
                    var other = _p0_UnityEngine_Color.Value;
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
        private static readonly global::Lua.LuaFunction _LuaColor_GetHashCode = new global::Lua.LuaFunction("GetHashCode", (_context, _) =>
        {
            global::Lua.LuaValue _lastArg = default;
            global::System.Int32 _lastArgPos = default;
            global::System.Type _expectedType = default;
            var _argCount = _context.ArgumentCount;
            var _this = _context.GetArgument<LuaColor>(0);
            if (_argCount == 1)
            {
                var _ret0 = _this.m_Value.GetHashCode();
                var _lret0 = new global::Lua.LuaValue(_ret0);
                var _retCount = _context.Return(_lret0);
                return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
            }
            throw new global::Lua.LuaRuntimeException(_context.Thread, $"{"GetHashCode"}: invalid argument #{_lastArgPos}: {_lastArg} ({_lastArg.Type}), expected: {_expectedType.FullName}", 2);
        });
        private static readonly global::Lua.LuaFunction _LuaColor_ToString = new global::Lua.LuaFunction("ToString", (_context, _) =>
        {
            global::Lua.LuaValue _lastArg = default;
            global::System.Int32 _lastArgPos = default;
            global::System.Type _expectedType = default;
            var _argCount = _context.ArgumentCount;
            var _this = _context.GetArgument<LuaColor>(0);
            if (_argCount == 1)
            {
                var _ret0 = _this.m_Value.ToString();
                var _lret0 = new global::Lua.LuaValue(_ret0);
                var _retCount = _context.Return(_lret0);
                return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
            }
            var _arg0 = _lastArg = _argCount > 1 ? _context.GetArgument(1) : global::Lua.LuaValue.Nil;
            _lastArgPos = 0; _expectedType = typeof(global::System.String);
            if (_arg0.TryRead<global::System.String>(out var _p0_System_String))
            {
                if (_argCount == 2)
                {
                    var format = _p0_System_String;
                    var _ret0 = _this.m_Value.ToString(format);
                    var _lret0 = new global::Lua.LuaValue(_ret0);
                    var _retCount = _context.Return(_lret0);
                    return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                }
            }
            throw new global::Lua.LuaRuntimeException(_context.Thread, $"{"ToString"}: invalid argument #{_lastArgPos}: {_lastArg} ({_lastArg.Type}), expected: {_expectedType.FullName}", 2);
        });
        private static readonly global::Lua.LuaFunction __index = new(global::Lua.Runtime.Metamethods.Index, (_context, _) =>
        {
            var _this = _context.GetArgument<LuaColor>(0);
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
            var _this = _context.GetArgument<LuaColor>(0);
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
            _value = new global::Lua.LuaValue(m_Value[_key]); return true;
        }
        public global::System.Boolean TryGetLuaValue(global::System.String _key, out global::Lua.LuaValue _value, global::Luny.ILuaObjectFactory _factory)
        {
            switch (_key)
            {
                case "Equals": _value = _LuaColor_Equals; return true;
                case "GetHashCode": _value = _LuaColor_GetHashCode; return true;
                case "ToString": _value = _LuaColor_ToString; return true;
                case "gamma": _value = global::Luny.UnityEngine.LuaColor.Bind(m_Value.gamma); return true;
                case "grayscale": _value = new global::Lua.LuaValue(m_Value.grayscale); return true;
                case "linear": _value = global::Luny.UnityEngine.LuaColor.Bind(m_Value.linear); return true;
                case "maxColorComponent": _value = new global::Lua.LuaValue(m_Value.maxColorComponent); return true;
                case "a": _value = new global::Lua.LuaValue(m_Value.a); return true;
                case "b": _value = new global::Lua.LuaValue(m_Value.b); return true;
                case "g": _value = new global::Lua.LuaValue(m_Value.g); return true;
                case "r": _value = new global::Lua.LuaValue(m_Value.r); return true;
                default: _value = global::Lua.LuaValue.Nil; return false;
            }
        }
        public global::System.Boolean TrySetLuaValue(global::System.Int32 _key, global::Lua.LuaValue _value)
        {
            { var _temp = m_Value; _temp[_key] = _value.Read<global::System.Single>(); m_Value = _temp; } return true;
        }
        public global::System.Boolean TrySetLuaValue(global::System.String _key, global::Lua.LuaValue _value)
        {
            switch (_key)
            {
                case "a": { var _temp = m_Value; _temp.a = _value.Read<global::System.Single>(); m_Value = _temp; } return true;
                case "b": { var _temp = m_Value; _temp.b = _value.Read<global::System.Single>(); m_Value = _temp; } return true;
                case "g": { var _temp = m_Value; _temp.g = _value.Read<global::System.Single>(); m_Value = _temp; } return true;
                case "r": { var _temp = m_Value; _temp.r = _value.Read<global::System.Single>(); m_Value = _temp; } return true;
                default: return false;
            }
        }
    }
    public sealed class LuaColorType : global::Luny.ILuaStatic
    {
        public static global::Lua.LuaValue Bind() => new LuaColorType();
        private LuaColorType() {}
        public static implicit operator global::Lua.LuaValue(LuaColorType value) => new(value);
        public global::System.Type BindType => typeof(global::UnityEngine.Color);
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

        private static readonly global::Lua.LuaFunction _LuaColor_new = new global::Lua.LuaFunction(".ctor", (_context, _) =>
        {
            global::Lua.LuaValue _lastArg = default;
            global::System.Int32 _lastArgPos = default;
            global::System.Type _expectedType = default;
            var _argCount = _context.ArgumentCount;
            if (_argCount == 0)
            {
                var _ret0 = new global::UnityEngine.Color();
                var _lret0 = global::Luny.UnityEngine.LuaColor.Bind(_ret0);
                var _retCount = _context.Return(_lret0);
                return new global::System.Threading.Tasks.ValueTask<global::System.Int32>(_retCount);
            }
            var _arg0 = _lastArg = _argCount > 0 ? _context.GetArgument(0) : global::Lua.LuaValue.Nil;
            _lastArgPos = 0; _expectedType = typeof(global::System.Single);
            if (_arg0.TryRead<global::System.Single>(out var _p0_System_Single))
            {
                var _arg1 = _lastArg = _argCount > 1 ? _context.GetArgument(1) : global::Lua.LuaValue.Nil;
                _lastArgPos = 1; _expectedType = typeof(global::System.Single);
                if (_arg1.TryRead<global::System.Single>(out var _p1_System_Single))
                {
                    var _arg2 = _lastArg = _argCount > 2 ? _context.GetArgument(2) : global::Lua.LuaValue.Nil;
                    _lastArgPos = 2; _expectedType = typeof(global::System.Single);
                    if (_arg2.TryRead<global::System.Single>(out var _p2_System_Single))
                    {
                        if (_argCount == 3)
                        {
                            var r = _p0_System_Single;
                            var g = _p1_System_Single;
                            var b = _p2_System_Single;
                            var _ret0 = new global::UnityEngine.Color(r, g, b);
                            var _lret0 = global::Luny.UnityEngine.LuaColor.Bind(_ret0);
                            var _retCount = _context.Return(_lret0);
                            return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                        }
                        var _arg3 = _lastArg = _argCount > 3 ? _context.GetArgument(3) : global::Lua.LuaValue.Nil;
                        _lastArgPos = 3; _expectedType = typeof(global::System.Single);
                        if (_arg3.TryRead<global::System.Single>(out var _p3_System_Single))
                        {
                            if (_argCount == 4)
                            {
                                var r = _p0_System_Single;
                                var g = _p1_System_Single;
                                var b = _p2_System_Single;
                                var a = _p3_System_Single;
                                var _ret0 = new global::UnityEngine.Color(r, g, b, a);
                                var _lret0 = global::Luny.UnityEngine.LuaColor.Bind(_ret0);
                                var _retCount = _context.Return(_lret0);
                                return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                            }
                        }
                    }
                }
            }
            throw new global::Lua.LuaRuntimeException(_context.Thread, $"{".ctor"}: invalid argument #{_lastArgPos}: {_lastArg} ({_lastArg.Type}), expected: {_expectedType.FullName}", 2);
        });
        private static readonly global::Lua.LuaFunction _LuaColor_HSVToRGB = new global::Lua.LuaFunction("HSVToRGB", (_context, _) =>
        {
            global::Lua.LuaValue _lastArg = default;
            global::System.Int32 _lastArgPos = default;
            global::System.Type _expectedType = default;
            var _argCount = _context.ArgumentCount;
            var _arg0 = _lastArg = _argCount > 0 ? _context.GetArgument(0) : global::Lua.LuaValue.Nil;
            _lastArgPos = 0; _expectedType = typeof(global::System.Single);
            if (_arg0.TryRead<global::System.Single>(out var _p0_System_Single))
            {
                var _arg1 = _lastArg = _argCount > 1 ? _context.GetArgument(1) : global::Lua.LuaValue.Nil;
                _lastArgPos = 1; _expectedType = typeof(global::System.Single);
                if (_arg1.TryRead<global::System.Single>(out var _p1_System_Single))
                {
                    var _arg2 = _lastArg = _argCount > 2 ? _context.GetArgument(2) : global::Lua.LuaValue.Nil;
                    _lastArgPos = 2; _expectedType = typeof(global::System.Single);
                    if (_arg2.TryRead<global::System.Single>(out var _p2_System_Single))
                    {
                        if (_argCount == 3)
                        {
                            var H = _p0_System_Single;
                            var S = _p1_System_Single;
                            var V = _p2_System_Single;
                            var _ret0 = global::UnityEngine.Color.HSVToRGB(H, S, V);
                            var _lret0 = global::Luny.UnityEngine.LuaColor.Bind(_ret0);
                            var _retCount = _context.Return(_lret0);
                            return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                        }
                        var _arg3 = _lastArg = _argCount > 3 ? _context.GetArgument(3) : global::Lua.LuaValue.Nil;
                        _lastArgPos = 3; _expectedType = typeof(global::System.Boolean);
                        if (_arg3.TryRead<global::System.Boolean>(out var _p3_System_Boolean))
                        {
                            if (_argCount == 4)
                            {
                                var H = _p0_System_Single;
                                var S = _p1_System_Single;
                                var V = _p2_System_Single;
                                var hdr = _p3_System_Boolean;
                                var _ret0 = global::UnityEngine.Color.HSVToRGB(H, S, V, hdr);
                                var _lret0 = global::Luny.UnityEngine.LuaColor.Bind(_ret0);
                                var _retCount = _context.Return(_lret0);
                                return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                            }
                        }
                    }
                }
            }
            throw new global::Lua.LuaRuntimeException(_context.Thread, $"{"HSVToRGB"}: invalid argument #{_lastArgPos}: {_lastArg} ({_lastArg.Type}), expected: {_expectedType.FullName}", 2);
        });
        private static readonly global::Lua.LuaFunction _LuaColor_Lerp = new global::Lua.LuaFunction("Lerp", (_context, _) =>
        {
            global::Lua.LuaValue _lastArg = default;
            global::System.Int32 _lastArgPos = default;
            global::System.Type _expectedType = default;
            var _argCount = _context.ArgumentCount;
            var _arg0 = _lastArg = _argCount > 0 ? _context.GetArgument(0) : global::Lua.LuaValue.Nil;
            _lastArgPos = 0; _expectedType = typeof(global::Luny.UnityEngine.LuaColor);
            if (_arg0.TryRead<global::Luny.UnityEngine.LuaColor>(out var _p0_UnityEngine_Color))
            {
                var _arg1 = _lastArg = _argCount > 1 ? _context.GetArgument(1) : global::Lua.LuaValue.Nil;
                _lastArgPos = 1; _expectedType = typeof(global::Luny.UnityEngine.LuaColor);
                if (_arg1.TryRead<global::Luny.UnityEngine.LuaColor>(out var _p1_UnityEngine_Color))
                {
                    var _arg2 = _lastArg = _argCount > 2 ? _context.GetArgument(2) : global::Lua.LuaValue.Nil;
                    _lastArgPos = 2; _expectedType = typeof(global::System.Single);
                    if (_arg2.TryRead<global::System.Single>(out var _p2_System_Single))
                    {
                        if (_argCount == 3)
                        {
                            var a = _p0_UnityEngine_Color.Value;
                            var b = _p1_UnityEngine_Color.Value;
                            var t = _p2_System_Single;
                            var _ret0 = global::UnityEngine.Color.Lerp(a, b, t);
                            var _lret0 = global::Luny.UnityEngine.LuaColor.Bind(_ret0);
                            var _retCount = _context.Return(_lret0);
                            return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                        }
                    }
                }
            }
            throw new global::Lua.LuaRuntimeException(_context.Thread, $"{"Lerp"}: invalid argument #{_lastArgPos}: {_lastArg} ({_lastArg.Type}), expected: {_expectedType.FullName}", 2);
        });
        private static readonly global::Lua.LuaFunction _LuaColor_LerpUnclamped = new global::Lua.LuaFunction("LerpUnclamped", (_context, _) =>
        {
            global::Lua.LuaValue _lastArg = default;
            global::System.Int32 _lastArgPos = default;
            global::System.Type _expectedType = default;
            var _argCount = _context.ArgumentCount;
            var _arg0 = _lastArg = _argCount > 0 ? _context.GetArgument(0) : global::Lua.LuaValue.Nil;
            _lastArgPos = 0; _expectedType = typeof(global::Luny.UnityEngine.LuaColor);
            if (_arg0.TryRead<global::Luny.UnityEngine.LuaColor>(out var _p0_UnityEngine_Color))
            {
                var _arg1 = _lastArg = _argCount > 1 ? _context.GetArgument(1) : global::Lua.LuaValue.Nil;
                _lastArgPos = 1; _expectedType = typeof(global::Luny.UnityEngine.LuaColor);
                if (_arg1.TryRead<global::Luny.UnityEngine.LuaColor>(out var _p1_UnityEngine_Color))
                {
                    var _arg2 = _lastArg = _argCount > 2 ? _context.GetArgument(2) : global::Lua.LuaValue.Nil;
                    _lastArgPos = 2; _expectedType = typeof(global::System.Single);
                    if (_arg2.TryRead<global::System.Single>(out var _p2_System_Single))
                    {
                        if (_argCount == 3)
                        {
                            var a = _p0_UnityEngine_Color.Value;
                            var b = _p1_UnityEngine_Color.Value;
                            var t = _p2_System_Single;
                            var _ret0 = global::UnityEngine.Color.LerpUnclamped(a, b, t);
                            var _lret0 = global::Luny.UnityEngine.LuaColor.Bind(_ret0);
                            var _retCount = _context.Return(_lret0);
                            return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                        }
                    }
                }
            }
            throw new global::Lua.LuaRuntimeException(_context.Thread, $"{"LerpUnclamped"}: invalid argument #{_lastArgPos}: {_lastArg} ({_lastArg.Type}), expected: {_expectedType.FullName}", 2);
        });
        private static readonly global::Lua.LuaFunction __index = new(global::Lua.Runtime.Metamethods.Index, (_context, _) =>
        {
            var _this = _context.GetArgument<LuaColorType>(0);
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
            var _this = _context.GetArgument<LuaColorType>(0);
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
                case "new": _value = _LuaColor_new; return true;
                case "HSVToRGB": _value = _LuaColor_HSVToRGB; return true;
                case "Lerp": _value = _LuaColor_Lerp; return true;
                case "LerpUnclamped": _value = _LuaColor_LerpUnclamped; return true;
                case "aliceBlue": _value = global::Luny.UnityEngine.LuaColor.Bind(global::UnityEngine.Color.aliceBlue); return true;
                case "antiqueWhite": _value = global::Luny.UnityEngine.LuaColor.Bind(global::UnityEngine.Color.antiqueWhite); return true;
                case "aquamarine": _value = global::Luny.UnityEngine.LuaColor.Bind(global::UnityEngine.Color.aquamarine); return true;
                case "azure": _value = global::Luny.UnityEngine.LuaColor.Bind(global::UnityEngine.Color.azure); return true;
                case "beige": _value = global::Luny.UnityEngine.LuaColor.Bind(global::UnityEngine.Color.beige); return true;
                case "bisque": _value = global::Luny.UnityEngine.LuaColor.Bind(global::UnityEngine.Color.bisque); return true;
                case "black": _value = global::Luny.UnityEngine.LuaColor.Bind(global::UnityEngine.Color.black); return true;
                case "blanchedAlmond": _value = global::Luny.UnityEngine.LuaColor.Bind(global::UnityEngine.Color.blanchedAlmond); return true;
                case "blue": _value = global::Luny.UnityEngine.LuaColor.Bind(global::UnityEngine.Color.blue); return true;
                case "blueViolet": _value = global::Luny.UnityEngine.LuaColor.Bind(global::UnityEngine.Color.blueViolet); return true;
                case "brown": _value = global::Luny.UnityEngine.LuaColor.Bind(global::UnityEngine.Color.brown); return true;
                case "burlywood": _value = global::Luny.UnityEngine.LuaColor.Bind(global::UnityEngine.Color.burlywood); return true;
                case "cadetBlue": _value = global::Luny.UnityEngine.LuaColor.Bind(global::UnityEngine.Color.cadetBlue); return true;
                case "chartreuse": _value = global::Luny.UnityEngine.LuaColor.Bind(global::UnityEngine.Color.chartreuse); return true;
                case "chocolate": _value = global::Luny.UnityEngine.LuaColor.Bind(global::UnityEngine.Color.chocolate); return true;
                case "clear": _value = global::Luny.UnityEngine.LuaColor.Bind(global::UnityEngine.Color.clear); return true;
                case "coral": _value = global::Luny.UnityEngine.LuaColor.Bind(global::UnityEngine.Color.coral); return true;
                case "cornflowerBlue": _value = global::Luny.UnityEngine.LuaColor.Bind(global::UnityEngine.Color.cornflowerBlue); return true;
                case "cornsilk": _value = global::Luny.UnityEngine.LuaColor.Bind(global::UnityEngine.Color.cornsilk); return true;
                case "crimson": _value = global::Luny.UnityEngine.LuaColor.Bind(global::UnityEngine.Color.crimson); return true;
                case "cyan": _value = global::Luny.UnityEngine.LuaColor.Bind(global::UnityEngine.Color.cyan); return true;
                case "darkBlue": _value = global::Luny.UnityEngine.LuaColor.Bind(global::UnityEngine.Color.darkBlue); return true;
                case "darkCyan": _value = global::Luny.UnityEngine.LuaColor.Bind(global::UnityEngine.Color.darkCyan); return true;
                case "darkGoldenRod": _value = global::Luny.UnityEngine.LuaColor.Bind(global::UnityEngine.Color.darkGoldenRod); return true;
                case "darkGray": _value = global::Luny.UnityEngine.LuaColor.Bind(global::UnityEngine.Color.darkGray); return true;
                case "darkGreen": _value = global::Luny.UnityEngine.LuaColor.Bind(global::UnityEngine.Color.darkGreen); return true;
                case "darkKhaki": _value = global::Luny.UnityEngine.LuaColor.Bind(global::UnityEngine.Color.darkKhaki); return true;
                case "darkMagenta": _value = global::Luny.UnityEngine.LuaColor.Bind(global::UnityEngine.Color.darkMagenta); return true;
                case "darkOliveGreen": _value = global::Luny.UnityEngine.LuaColor.Bind(global::UnityEngine.Color.darkOliveGreen); return true;
                case "darkOrange": _value = global::Luny.UnityEngine.LuaColor.Bind(global::UnityEngine.Color.darkOrange); return true;
                case "darkOrchid": _value = global::Luny.UnityEngine.LuaColor.Bind(global::UnityEngine.Color.darkOrchid); return true;
                case "darkRed": _value = global::Luny.UnityEngine.LuaColor.Bind(global::UnityEngine.Color.darkRed); return true;
                case "darkSalmon": _value = global::Luny.UnityEngine.LuaColor.Bind(global::UnityEngine.Color.darkSalmon); return true;
                case "darkSeaGreen": _value = global::Luny.UnityEngine.LuaColor.Bind(global::UnityEngine.Color.darkSeaGreen); return true;
                case "darkSlateBlue": _value = global::Luny.UnityEngine.LuaColor.Bind(global::UnityEngine.Color.darkSlateBlue); return true;
                case "darkSlateGray": _value = global::Luny.UnityEngine.LuaColor.Bind(global::UnityEngine.Color.darkSlateGray); return true;
                case "darkTurquoise": _value = global::Luny.UnityEngine.LuaColor.Bind(global::UnityEngine.Color.darkTurquoise); return true;
                case "darkViolet": _value = global::Luny.UnityEngine.LuaColor.Bind(global::UnityEngine.Color.darkViolet); return true;
                case "deepPink": _value = global::Luny.UnityEngine.LuaColor.Bind(global::UnityEngine.Color.deepPink); return true;
                case "deepSkyBlue": _value = global::Luny.UnityEngine.LuaColor.Bind(global::UnityEngine.Color.deepSkyBlue); return true;
                case "dimGray": _value = global::Luny.UnityEngine.LuaColor.Bind(global::UnityEngine.Color.dimGray); return true;
                case "dodgerBlue": _value = global::Luny.UnityEngine.LuaColor.Bind(global::UnityEngine.Color.dodgerBlue); return true;
                case "firebrick": _value = global::Luny.UnityEngine.LuaColor.Bind(global::UnityEngine.Color.firebrick); return true;
                case "floralWhite": _value = global::Luny.UnityEngine.LuaColor.Bind(global::UnityEngine.Color.floralWhite); return true;
                case "forestGreen": _value = global::Luny.UnityEngine.LuaColor.Bind(global::UnityEngine.Color.forestGreen); return true;
                case "gainsboro": _value = global::Luny.UnityEngine.LuaColor.Bind(global::UnityEngine.Color.gainsboro); return true;
                case "ghostWhite": _value = global::Luny.UnityEngine.LuaColor.Bind(global::UnityEngine.Color.ghostWhite); return true;
                case "gold": _value = global::Luny.UnityEngine.LuaColor.Bind(global::UnityEngine.Color.gold); return true;
                case "goldenRod": _value = global::Luny.UnityEngine.LuaColor.Bind(global::UnityEngine.Color.goldenRod); return true;
                case "gray": _value = global::Luny.UnityEngine.LuaColor.Bind(global::UnityEngine.Color.gray); return true;
                case "gray1": _value = global::Luny.UnityEngine.LuaColor.Bind(global::UnityEngine.Color.gray1); return true;
                case "gray2": _value = global::Luny.UnityEngine.LuaColor.Bind(global::UnityEngine.Color.gray2); return true;
                case "gray3": _value = global::Luny.UnityEngine.LuaColor.Bind(global::UnityEngine.Color.gray3); return true;
                case "gray4": _value = global::Luny.UnityEngine.LuaColor.Bind(global::UnityEngine.Color.gray4); return true;
                case "gray5": _value = global::Luny.UnityEngine.LuaColor.Bind(global::UnityEngine.Color.gray5); return true;
                case "gray6": _value = global::Luny.UnityEngine.LuaColor.Bind(global::UnityEngine.Color.gray6); return true;
                case "gray7": _value = global::Luny.UnityEngine.LuaColor.Bind(global::UnityEngine.Color.gray7); return true;
                case "gray8": _value = global::Luny.UnityEngine.LuaColor.Bind(global::UnityEngine.Color.gray8); return true;
                case "gray9": _value = global::Luny.UnityEngine.LuaColor.Bind(global::UnityEngine.Color.gray9); return true;
                case "green": _value = global::Luny.UnityEngine.LuaColor.Bind(global::UnityEngine.Color.green); return true;
                case "greenYellow": _value = global::Luny.UnityEngine.LuaColor.Bind(global::UnityEngine.Color.greenYellow); return true;
                case "grey": _value = global::Luny.UnityEngine.LuaColor.Bind(global::UnityEngine.Color.grey); return true;
                case "honeydew": _value = global::Luny.UnityEngine.LuaColor.Bind(global::UnityEngine.Color.honeydew); return true;
                case "hotPink": _value = global::Luny.UnityEngine.LuaColor.Bind(global::UnityEngine.Color.hotPink); return true;
                case "indianRed": _value = global::Luny.UnityEngine.LuaColor.Bind(global::UnityEngine.Color.indianRed); return true;
                case "indigo": _value = global::Luny.UnityEngine.LuaColor.Bind(global::UnityEngine.Color.indigo); return true;
                case "ivory": _value = global::Luny.UnityEngine.LuaColor.Bind(global::UnityEngine.Color.ivory); return true;
                case "khaki": _value = global::Luny.UnityEngine.LuaColor.Bind(global::UnityEngine.Color.khaki); return true;
                case "lavender": _value = global::Luny.UnityEngine.LuaColor.Bind(global::UnityEngine.Color.lavender); return true;
                case "lavenderBlush": _value = global::Luny.UnityEngine.LuaColor.Bind(global::UnityEngine.Color.lavenderBlush); return true;
                case "lawnGreen": _value = global::Luny.UnityEngine.LuaColor.Bind(global::UnityEngine.Color.lawnGreen); return true;
                case "lemonChiffon": _value = global::Luny.UnityEngine.LuaColor.Bind(global::UnityEngine.Color.lemonChiffon); return true;
                case "lightBlue": _value = global::Luny.UnityEngine.LuaColor.Bind(global::UnityEngine.Color.lightBlue); return true;
                case "lightCoral": _value = global::Luny.UnityEngine.LuaColor.Bind(global::UnityEngine.Color.lightCoral); return true;
                case "lightCyan": _value = global::Luny.UnityEngine.LuaColor.Bind(global::UnityEngine.Color.lightCyan); return true;
                case "lightGoldenRod": _value = global::Luny.UnityEngine.LuaColor.Bind(global::UnityEngine.Color.lightGoldenRod); return true;
                case "lightGoldenRodYellow": _value = global::Luny.UnityEngine.LuaColor.Bind(global::UnityEngine.Color.lightGoldenRodYellow); return true;
                case "lightGray": _value = global::Luny.UnityEngine.LuaColor.Bind(global::UnityEngine.Color.lightGray); return true;
                case "lightGreen": _value = global::Luny.UnityEngine.LuaColor.Bind(global::UnityEngine.Color.lightGreen); return true;
                case "lightPink": _value = global::Luny.UnityEngine.LuaColor.Bind(global::UnityEngine.Color.lightPink); return true;
                case "lightSalmon": _value = global::Luny.UnityEngine.LuaColor.Bind(global::UnityEngine.Color.lightSalmon); return true;
                case "lightSeaGreen": _value = global::Luny.UnityEngine.LuaColor.Bind(global::UnityEngine.Color.lightSeaGreen); return true;
                case "lightSkyBlue": _value = global::Luny.UnityEngine.LuaColor.Bind(global::UnityEngine.Color.lightSkyBlue); return true;
                case "lightSlateBlue": _value = global::Luny.UnityEngine.LuaColor.Bind(global::UnityEngine.Color.lightSlateBlue); return true;
                case "lightSlateGray": _value = global::Luny.UnityEngine.LuaColor.Bind(global::UnityEngine.Color.lightSlateGray); return true;
                case "lightSteelBlue": _value = global::Luny.UnityEngine.LuaColor.Bind(global::UnityEngine.Color.lightSteelBlue); return true;
                case "lightYellow": _value = global::Luny.UnityEngine.LuaColor.Bind(global::UnityEngine.Color.lightYellow); return true;
                case "limeGreen": _value = global::Luny.UnityEngine.LuaColor.Bind(global::UnityEngine.Color.limeGreen); return true;
                case "linen": _value = global::Luny.UnityEngine.LuaColor.Bind(global::UnityEngine.Color.linen); return true;
                case "magenta": _value = global::Luny.UnityEngine.LuaColor.Bind(global::UnityEngine.Color.magenta); return true;
                case "maroon": _value = global::Luny.UnityEngine.LuaColor.Bind(global::UnityEngine.Color.maroon); return true;
                case "mediumAquamarine": _value = global::Luny.UnityEngine.LuaColor.Bind(global::UnityEngine.Color.mediumAquamarine); return true;
                case "mediumBlue": _value = global::Luny.UnityEngine.LuaColor.Bind(global::UnityEngine.Color.mediumBlue); return true;
                case "mediumOrchid": _value = global::Luny.UnityEngine.LuaColor.Bind(global::UnityEngine.Color.mediumOrchid); return true;
                case "mediumPurple": _value = global::Luny.UnityEngine.LuaColor.Bind(global::UnityEngine.Color.mediumPurple); return true;
                case "mediumSeaGreen": _value = global::Luny.UnityEngine.LuaColor.Bind(global::UnityEngine.Color.mediumSeaGreen); return true;
                case "mediumSlateBlue": _value = global::Luny.UnityEngine.LuaColor.Bind(global::UnityEngine.Color.mediumSlateBlue); return true;
                case "mediumSpringGreen": _value = global::Luny.UnityEngine.LuaColor.Bind(global::UnityEngine.Color.mediumSpringGreen); return true;
                case "mediumTurquoise": _value = global::Luny.UnityEngine.LuaColor.Bind(global::UnityEngine.Color.mediumTurquoise); return true;
                case "mediumVioletRed": _value = global::Luny.UnityEngine.LuaColor.Bind(global::UnityEngine.Color.mediumVioletRed); return true;
                case "midnightBlue": _value = global::Luny.UnityEngine.LuaColor.Bind(global::UnityEngine.Color.midnightBlue); return true;
                case "mintCream": _value = global::Luny.UnityEngine.LuaColor.Bind(global::UnityEngine.Color.mintCream); return true;
                case "mistyRose": _value = global::Luny.UnityEngine.LuaColor.Bind(global::UnityEngine.Color.mistyRose); return true;
                case "moccasin": _value = global::Luny.UnityEngine.LuaColor.Bind(global::UnityEngine.Color.moccasin); return true;
                case "navajoWhite": _value = global::Luny.UnityEngine.LuaColor.Bind(global::UnityEngine.Color.navajoWhite); return true;
                case "navyBlue": _value = global::Luny.UnityEngine.LuaColor.Bind(global::UnityEngine.Color.navyBlue); return true;
                case "oldLace": _value = global::Luny.UnityEngine.LuaColor.Bind(global::UnityEngine.Color.oldLace); return true;
                case "olive": _value = global::Luny.UnityEngine.LuaColor.Bind(global::UnityEngine.Color.olive); return true;
                case "oliveDrab": _value = global::Luny.UnityEngine.LuaColor.Bind(global::UnityEngine.Color.oliveDrab); return true;
                case "orange": _value = global::Luny.UnityEngine.LuaColor.Bind(global::UnityEngine.Color.orange); return true;
                case "orangeRed": _value = global::Luny.UnityEngine.LuaColor.Bind(global::UnityEngine.Color.orangeRed); return true;
                case "orchid": _value = global::Luny.UnityEngine.LuaColor.Bind(global::UnityEngine.Color.orchid); return true;
                case "paleGoldenRod": _value = global::Luny.UnityEngine.LuaColor.Bind(global::UnityEngine.Color.paleGoldenRod); return true;
                case "paleGreen": _value = global::Luny.UnityEngine.LuaColor.Bind(global::UnityEngine.Color.paleGreen); return true;
                case "paleTurquoise": _value = global::Luny.UnityEngine.LuaColor.Bind(global::UnityEngine.Color.paleTurquoise); return true;
                case "paleVioletRed": _value = global::Luny.UnityEngine.LuaColor.Bind(global::UnityEngine.Color.paleVioletRed); return true;
                case "papayaWhip": _value = global::Luny.UnityEngine.LuaColor.Bind(global::UnityEngine.Color.papayaWhip); return true;
                case "peachPuff": _value = global::Luny.UnityEngine.LuaColor.Bind(global::UnityEngine.Color.peachPuff); return true;
                case "peru": _value = global::Luny.UnityEngine.LuaColor.Bind(global::UnityEngine.Color.peru); return true;
                case "pink": _value = global::Luny.UnityEngine.LuaColor.Bind(global::UnityEngine.Color.pink); return true;
                case "plum": _value = global::Luny.UnityEngine.LuaColor.Bind(global::UnityEngine.Color.plum); return true;
                case "powderBlue": _value = global::Luny.UnityEngine.LuaColor.Bind(global::UnityEngine.Color.powderBlue); return true;
                case "purple": _value = global::Luny.UnityEngine.LuaColor.Bind(global::UnityEngine.Color.purple); return true;
                case "rebeccaPurple": _value = global::Luny.UnityEngine.LuaColor.Bind(global::UnityEngine.Color.rebeccaPurple); return true;
                case "red": _value = global::Luny.UnityEngine.LuaColor.Bind(global::UnityEngine.Color.red); return true;
                case "rosyBrown": _value = global::Luny.UnityEngine.LuaColor.Bind(global::UnityEngine.Color.rosyBrown); return true;
                case "royalBlue": _value = global::Luny.UnityEngine.LuaColor.Bind(global::UnityEngine.Color.royalBlue); return true;
                case "saddleBrown": _value = global::Luny.UnityEngine.LuaColor.Bind(global::UnityEngine.Color.saddleBrown); return true;
                case "salmon": _value = global::Luny.UnityEngine.LuaColor.Bind(global::UnityEngine.Color.salmon); return true;
                case "sandyBrown": _value = global::Luny.UnityEngine.LuaColor.Bind(global::UnityEngine.Color.sandyBrown); return true;
                case "seaGreen": _value = global::Luny.UnityEngine.LuaColor.Bind(global::UnityEngine.Color.seaGreen); return true;
                case "seashell": _value = global::Luny.UnityEngine.LuaColor.Bind(global::UnityEngine.Color.seashell); return true;
                case "sienna": _value = global::Luny.UnityEngine.LuaColor.Bind(global::UnityEngine.Color.sienna); return true;
                case "silver": _value = global::Luny.UnityEngine.LuaColor.Bind(global::UnityEngine.Color.silver); return true;
                case "skyBlue": _value = global::Luny.UnityEngine.LuaColor.Bind(global::UnityEngine.Color.skyBlue); return true;
                case "slateBlue": _value = global::Luny.UnityEngine.LuaColor.Bind(global::UnityEngine.Color.slateBlue); return true;
                case "slateGray": _value = global::Luny.UnityEngine.LuaColor.Bind(global::UnityEngine.Color.slateGray); return true;
                case "snow": _value = global::Luny.UnityEngine.LuaColor.Bind(global::UnityEngine.Color.snow); return true;
                case "softBlue": _value = global::Luny.UnityEngine.LuaColor.Bind(global::UnityEngine.Color.softBlue); return true;
                case "softGreen": _value = global::Luny.UnityEngine.LuaColor.Bind(global::UnityEngine.Color.softGreen); return true;
                case "softRed": _value = global::Luny.UnityEngine.LuaColor.Bind(global::UnityEngine.Color.softRed); return true;
                case "softYellow": _value = global::Luny.UnityEngine.LuaColor.Bind(global::UnityEngine.Color.softYellow); return true;
                case "springGreen": _value = global::Luny.UnityEngine.LuaColor.Bind(global::UnityEngine.Color.springGreen); return true;
                case "steelBlue": _value = global::Luny.UnityEngine.LuaColor.Bind(global::UnityEngine.Color.steelBlue); return true;
                case "tan": _value = global::Luny.UnityEngine.LuaColor.Bind(global::UnityEngine.Color.tan); return true;
                case "teal": _value = global::Luny.UnityEngine.LuaColor.Bind(global::UnityEngine.Color.teal); return true;
                case "thistle": _value = global::Luny.UnityEngine.LuaColor.Bind(global::UnityEngine.Color.thistle); return true;
                case "tomato": _value = global::Luny.UnityEngine.LuaColor.Bind(global::UnityEngine.Color.tomato); return true;
                case "turquoise": _value = global::Luny.UnityEngine.LuaColor.Bind(global::UnityEngine.Color.turquoise); return true;
                case "violet": _value = global::Luny.UnityEngine.LuaColor.Bind(global::UnityEngine.Color.violet); return true;
                case "violetRed": _value = global::Luny.UnityEngine.LuaColor.Bind(global::UnityEngine.Color.violetRed); return true;
                case "wheat": _value = global::Luny.UnityEngine.LuaColor.Bind(global::UnityEngine.Color.wheat); return true;
                case "white": _value = global::Luny.UnityEngine.LuaColor.Bind(global::UnityEngine.Color.white); return true;
                case "whiteSmoke": _value = global::Luny.UnityEngine.LuaColor.Bind(global::UnityEngine.Color.whiteSmoke); return true;
                case "yellow": _value = global::Luny.UnityEngine.LuaColor.Bind(global::UnityEngine.Color.yellow); return true;
                case "yellowGreen": _value = global::Luny.UnityEngine.LuaColor.Bind(global::UnityEngine.Color.yellowGreen); return true;
                case "yellowNice": _value = global::Luny.UnityEngine.LuaColor.Bind(global::UnityEngine.Color.yellowNice); return true;
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
