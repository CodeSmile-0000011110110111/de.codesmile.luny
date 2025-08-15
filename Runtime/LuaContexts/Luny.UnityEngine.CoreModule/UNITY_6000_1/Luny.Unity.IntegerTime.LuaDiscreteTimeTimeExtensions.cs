
// --------------------------------------------------------------
// GENERATED FILE ----> DO NOT EDIT <---- CHANGES WILL BE LOST !!
// --------------------------------------------------------------

#if UNITY_6000_1_OR_NEWER && !(UNITY_6000_2_OR_NEWER)
#pragma warning disable 0109, 0162, 0168, 0219
using Luny;

namespace Luny.Unity.IntegerTime
{
    public sealed class LuaDiscreteTimeTimeExtensionsType : global::Luny.ILuaStatic
    {
        public static global::Lua.LuaValue Bind() => new LuaDiscreteTimeTimeExtensionsType();
        private LuaDiscreteTimeTimeExtensionsType() {}
        public static implicit operator global::Lua.LuaValue(LuaDiscreteTimeTimeExtensionsType value) => new(value);
        public global::System.Type BindType => typeof(global::Unity.IntegerTime.DiscreteTimeTimeExtensions);
        private static global::Lua.LuaTable s_Metatable;
        public global::Lua.LuaTable Metatable
        {
            get => s_Metatable ??= CreateMetatable();
            set => throw new global::System.NotSupportedException("LuaObject metatables cannot be modified");
        }
        global::System.Span<global::Lua.LuaValue> global::Lua.ILuaUserData.UserValues => default;
        private static global::Lua.LuaTable CreateMetatable()
        {
            var metatable = new global::Lua.LuaTable(0, 4);
            metatable[global::Lua.Runtime.Metamethods.Index] = __index;
            metatable[global::Lua.Runtime.Metamethods.NewIndex] = __newindex;
            metatable[global::Lua.Runtime.Metamethods.Concat] = global::Luny.LuaMetatable.ConcatMetamethod;
            metatable[global::Lua.Runtime.Metamethods.ToString] = global::Luny.LuaMetatable.ToStringMetamethod;
            return metatable;
        }
        public override global::System.String ToString() => BindType.FullName;
#if UNITY_EDITOR
        [global::UnityEngine.RuntimeInitializeOnLoadMethod(global::UnityEngine.RuntimeInitializeLoadType.SubsystemRegistration)]
        private static void ResetStaticFields() => s_Metatable = null;
#endif

        private static readonly global::Lua.LuaFunction _LuaDiscreteTimeTimeExtensions_Abs = new global::Lua.LuaFunction("Abs", (_context, _) =>
        {
            global::Lua.LuaValue _lastArg = default;
            global::System.Int32 _lastArgPos = default;
            global::System.Type _expectedType = default;
            var _argCount = _context.ArgumentCount;
            var _arg0 = _lastArg = _argCount > 0 ? _context.GetArgument(0) : global::Lua.LuaValue.Nil;
            _lastArgPos = 0; _expectedType = typeof(global::Luny.Unity.IntegerTime.LuaDiscreteTime);
            if (_arg0.TryRead<global::Luny.Unity.IntegerTime.LuaDiscreteTime>(out var _p0_Unity_IntegerTime_DiscreteTime))
            {
                if (_argCount == 1)
                {
                    var lhs = _p0_Unity_IntegerTime_DiscreteTime.Value;
                    var _ret0 = global::Unity.IntegerTime.DiscreteTimeTimeExtensions.Abs(lhs);
                    var _lret0 = global::Luny.Unity.IntegerTime.LuaDiscreteTime.Bind(_ret0);
                    var _retCount = _context.Return(_lret0);
                    return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                }
            }
            throw new global::Lua.LuaRuntimeException(_context.Thread, $"{"Abs"}: invalid argument #{_lastArgPos}: {_lastArg} ({_lastArg.Type}), expected: {_expectedType.FullName}", 2);
        });
        private static readonly global::Lua.LuaFunction _LuaDiscreteTimeTimeExtensions_Clamp = new global::Lua.LuaFunction("Clamp", (_context, _) =>
        {
            global::Lua.LuaValue _lastArg = default;
            global::System.Int32 _lastArgPos = default;
            global::System.Type _expectedType = default;
            var _argCount = _context.ArgumentCount;
            var _arg0 = _lastArg = _argCount > 0 ? _context.GetArgument(0) : global::Lua.LuaValue.Nil;
            _lastArgPos = 0; _expectedType = typeof(global::Luny.Unity.IntegerTime.LuaDiscreteTime);
            if (_arg0.TryRead<global::Luny.Unity.IntegerTime.LuaDiscreteTime>(out var _p0_Unity_IntegerTime_DiscreteTime))
            {
                var _arg1 = _lastArg = _argCount > 1 ? _context.GetArgument(1) : global::Lua.LuaValue.Nil;
                _lastArgPos = 1; _expectedType = typeof(global::Luny.Unity.IntegerTime.LuaDiscreteTime);
                if (_arg1.TryRead<global::Luny.Unity.IntegerTime.LuaDiscreteTime>(out var _p1_Unity_IntegerTime_DiscreteTime))
                {
                    var _arg2 = _lastArg = _argCount > 2 ? _context.GetArgument(2) : global::Lua.LuaValue.Nil;
                    _lastArgPos = 2; _expectedType = typeof(global::Luny.Unity.IntegerTime.LuaDiscreteTime);
                    if (_arg2.TryRead<global::Luny.Unity.IntegerTime.LuaDiscreteTime>(out var _p2_Unity_IntegerTime_DiscreteTime))
                    {
                        if (_argCount == 3)
                        {
                            var x = _p0_Unity_IntegerTime_DiscreteTime.Value;
                            var a = _p1_Unity_IntegerTime_DiscreteTime.Value;
                            var b = _p2_Unity_IntegerTime_DiscreteTime.Value;
                            var _ret0 = global::Unity.IntegerTime.DiscreteTimeTimeExtensions.Clamp(x, a, b);
                            var _lret0 = global::Luny.Unity.IntegerTime.LuaDiscreteTime.Bind(_ret0);
                            var _retCount = _context.Return(_lret0);
                            return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                        }
                    }
                }
            }
            throw new global::Lua.LuaRuntimeException(_context.Thread, $"{"Clamp"}: invalid argument #{_lastArgPos}: {_lastArg} ({_lastArg.Type}), expected: {_expectedType.FullName}", 2);
        });
        private static readonly global::Lua.LuaFunction _LuaDiscreteTimeTimeExtensions_Floor = new global::Lua.LuaFunction("Floor", (_context, _) =>
        {
            global::Lua.LuaValue _lastArg = default;
            global::System.Int32 _lastArgPos = default;
            global::System.Type _expectedType = default;
            var _argCount = _context.ArgumentCount;
            var _arg0 = _lastArg = _argCount > 0 ? _context.GetArgument(0) : global::Lua.LuaValue.Nil;
            _lastArgPos = 0; _expectedType = typeof(global::Luny.Unity.IntegerTime.LuaDiscreteTime);
            if (_arg0.TryRead<global::Luny.Unity.IntegerTime.LuaDiscreteTime>(out var _p0_Unity_IntegerTime_DiscreteTime))
            {
                if (_argCount == 1)
                {
                    var x = _p0_Unity_IntegerTime_DiscreteTime.Value;
                    var _ret0 = global::Unity.IntegerTime.DiscreteTimeTimeExtensions.Floor(x);
                    var _lret0 = global::Luny.Unity.IntegerTime.LuaDiscreteTime.Bind(_ret0);
                    var _retCount = _context.Return(_lret0);
                    return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                }
            }
            throw new global::Lua.LuaRuntimeException(_context.Thread, $"{"Floor"}: invalid argument #{_lastArgPos}: {_lastArg} ({_lastArg.Type}), expected: {_expectedType.FullName}", 2);
        });
        private static readonly global::Lua.LuaFunction _LuaDiscreteTimeTimeExtensions_Max = new global::Lua.LuaFunction("Max", (_context, _) =>
        {
            global::Lua.LuaValue _lastArg = default;
            global::System.Int32 _lastArgPos = default;
            global::System.Type _expectedType = default;
            var _argCount = _context.ArgumentCount;
            var _arg0 = _lastArg = _argCount > 0 ? _context.GetArgument(0) : global::Lua.LuaValue.Nil;
            _lastArgPos = 0; _expectedType = typeof(global::Luny.Unity.IntegerTime.LuaDiscreteTime);
            if (_arg0.TryRead<global::Luny.Unity.IntegerTime.LuaDiscreteTime>(out var _p0_Unity_IntegerTime_DiscreteTime))
            {
                var _arg1 = _lastArg = _argCount > 1 ? _context.GetArgument(1) : global::Lua.LuaValue.Nil;
                _lastArgPos = 1; _expectedType = typeof(global::Luny.Unity.IntegerTime.LuaDiscreteTime);
                if (_arg1.TryRead<global::Luny.Unity.IntegerTime.LuaDiscreteTime>(out var _p1_Unity_IntegerTime_DiscreteTime))
                {
                    if (_argCount == 2)
                    {
                        var lhs = _p0_Unity_IntegerTime_DiscreteTime.Value;
                        var rhs = _p1_Unity_IntegerTime_DiscreteTime.Value;
                        var _ret0 = global::Unity.IntegerTime.DiscreteTimeTimeExtensions.Max(lhs, rhs);
                        var _lret0 = global::Luny.Unity.IntegerTime.LuaDiscreteTime.Bind(_ret0);
                        var _retCount = _context.Return(_lret0);
                        return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                    }
                }
            }
            throw new global::Lua.LuaRuntimeException(_context.Thread, $"{"Max"}: invalid argument #{_lastArgPos}: {_lastArg} ({_lastArg.Type}), expected: {_expectedType.FullName}", 2);
        });
        private static readonly global::Lua.LuaFunction _LuaDiscreteTimeTimeExtensions_Min = new global::Lua.LuaFunction("Min", (_context, _) =>
        {
            global::Lua.LuaValue _lastArg = default;
            global::System.Int32 _lastArgPos = default;
            global::System.Type _expectedType = default;
            var _argCount = _context.ArgumentCount;
            var _arg0 = _lastArg = _argCount > 0 ? _context.GetArgument(0) : global::Lua.LuaValue.Nil;
            _lastArgPos = 0; _expectedType = typeof(global::Luny.Unity.IntegerTime.LuaDiscreteTime);
            if (_arg0.TryRead<global::Luny.Unity.IntegerTime.LuaDiscreteTime>(out var _p0_Unity_IntegerTime_DiscreteTime))
            {
                var _arg1 = _lastArg = _argCount > 1 ? _context.GetArgument(1) : global::Lua.LuaValue.Nil;
                _lastArgPos = 1; _expectedType = typeof(global::Luny.Unity.IntegerTime.LuaDiscreteTime);
                if (_arg1.TryRead<global::Luny.Unity.IntegerTime.LuaDiscreteTime>(out var _p1_Unity_IntegerTime_DiscreteTime))
                {
                    if (_argCount == 2)
                    {
                        var lhs = _p0_Unity_IntegerTime_DiscreteTime.Value;
                        var rhs = _p1_Unity_IntegerTime_DiscreteTime.Value;
                        var _ret0 = global::Unity.IntegerTime.DiscreteTimeTimeExtensions.Min(lhs, rhs);
                        var _lret0 = global::Luny.Unity.IntegerTime.LuaDiscreteTime.Bind(_ret0);
                        var _retCount = _context.Return(_lret0);
                        return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                    }
                }
            }
            throw new global::Lua.LuaRuntimeException(_context.Thread, $"{"Min"}: invalid argument #{_lastArgPos}: {_lastArg} ({_lastArg.Type}), expected: {_expectedType.FullName}", 2);
        });
        private static readonly global::Lua.LuaFunction _LuaDiscreteTimeTimeExtensions_Select = new global::Lua.LuaFunction("Select", (_context, _) =>
        {
            global::Lua.LuaValue _lastArg = default;
            global::System.Int32 _lastArgPos = default;
            global::System.Type _expectedType = default;
            var _argCount = _context.ArgumentCount;
            var _arg0 = _lastArg = _argCount > 0 ? _context.GetArgument(0) : global::Lua.LuaValue.Nil;
            _lastArgPos = 0; _expectedType = typeof(global::Luny.Unity.IntegerTime.LuaDiscreteTime);
            if (_arg0.TryRead<global::Luny.Unity.IntegerTime.LuaDiscreteTime>(out var _p0_Unity_IntegerTime_DiscreteTime))
            {
                var _arg1 = _lastArg = _argCount > 1 ? _context.GetArgument(1) : global::Lua.LuaValue.Nil;
                _lastArgPos = 1; _expectedType = typeof(global::Luny.Unity.IntegerTime.LuaDiscreteTime);
                if (_arg1.TryRead<global::Luny.Unity.IntegerTime.LuaDiscreteTime>(out var _p1_Unity_IntegerTime_DiscreteTime))
                {
                    var _arg2 = _lastArg = _argCount > 2 ? _context.GetArgument(2) : global::Lua.LuaValue.Nil;
                    _lastArgPos = 2; _expectedType = typeof(global::System.Boolean);
                    if (_arg2.TryRead<global::System.Boolean>(out var _p2_System_Boolean))
                    {
                        if (_argCount == 3)
                        {
                            var a = _p0_Unity_IntegerTime_DiscreteTime.Value;
                            var b = _p1_Unity_IntegerTime_DiscreteTime.Value;
                            var c = _p2_System_Boolean;
                            var _ret0 = global::Unity.IntegerTime.DiscreteTimeTimeExtensions.Select(a, b, c);
                            var _lret0 = global::Luny.Unity.IntegerTime.LuaDiscreteTime.Bind(_ret0);
                            var _retCount = _context.Return(_lret0);
                            return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                        }
                    }
                }
            }
            throw new global::Lua.LuaRuntimeException(_context.Thread, $"{"Select"}: invalid argument #{_lastArgPos}: {_lastArg} ({_lastArg.Type}), expected: {_expectedType.FullName}", 2);
        });
        private static readonly global::Lua.LuaFunction __index = new(global::Lua.Runtime.Metamethods.Index, (_context, _) =>
        {
            var _this = _context.GetArgument<LuaDiscreteTimeTimeExtensionsType>(0);
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
            var _this = _context.GetArgument<LuaDiscreteTimeTimeExtensionsType>(0);
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
                case "Abs": _value = _LuaDiscreteTimeTimeExtensions_Abs; return true;
                case "Clamp": _value = _LuaDiscreteTimeTimeExtensions_Clamp; return true;
                case "Floor": _value = _LuaDiscreteTimeTimeExtensions_Floor; return true;
                case "Max": _value = _LuaDiscreteTimeTimeExtensions_Max; return true;
                case "Min": _value = _LuaDiscreteTimeTimeExtensions_Min; return true;
                case "Select": _value = _LuaDiscreteTimeTimeExtensions_Select; return true;
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
