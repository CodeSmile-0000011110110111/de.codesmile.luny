
// --------------------------------------------------------------
// GENERATED FILE ----> DO NOT EDIT <---- CHANGES WILL BE LOST !!
// --------------------------------------------------------------

#if UNITY_6000_0_OR_NEWER && !(UNITY_6000_1_OR_NEWER)
#pragma warning disable 0109, 0162, 0168, 0219
using Luny;

namespace Luny.Unity.IntegerTime
{
    public sealed class LuaRationalTimeExtensionsType : global::Luny.ILuaStatic
    {
        public static global::Lua.LuaValue Bind() => new LuaRationalTimeExtensionsType();
        private LuaRationalTimeExtensionsType() {}
        public static implicit operator global::Lua.LuaValue(LuaRationalTimeExtensionsType value) => new(value);
        public global::System.Type BindType => typeof(global::Unity.IntegerTime.RationalTimeExtensions);
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

        private static readonly global::Lua.LuaFunction _LuaRationalTimeExtensions_Add = new global::Lua.LuaFunction("Add", (_context, _) =>
        {
            global::Lua.LuaValue _lastArg = default;
            global::System.Int32 _lastArgPos = default;
            global::System.Type _expectedType = default;
            var _argCount = _context.ArgumentCount;
            var _arg0 = _lastArg = _argCount > 0 ? _context.GetArgument(0) : global::Lua.LuaValue.Nil;
            _lastArgPos = 0; _expectedType = typeof(global::Luny.Unity.IntegerTime.LuaRationalTime);
            if (_arg0.TryRead<global::Luny.Unity.IntegerTime.LuaRationalTime>(out var _p0_Unity_IntegerTime_RationalTime))
            {
                var _arg1 = _lastArg = _argCount > 1 ? _context.GetArgument(1) : global::Lua.LuaValue.Nil;
                _lastArgPos = 1; _expectedType = typeof(global::Luny.Unity.IntegerTime.LuaRationalTime);
                if (_arg1.TryRead<global::Luny.Unity.IntegerTime.LuaRationalTime>(out var _p1_Unity_IntegerTime_RationalTime))
                {
                    if (_argCount == 2)
                    {
                        var lhs = _p0_Unity_IntegerTime_RationalTime.Value;
                        var rhs = _p1_Unity_IntegerTime_RationalTime.Value;
                        var _ret0 = global::Unity.IntegerTime.RationalTimeExtensions.Add(lhs, rhs);
                        var _lret0 = global::Luny.Unity.IntegerTime.LuaRationalTime.Bind(_ret0);
                        var _retCount = _context.Return(_lret0);
                        return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                    }
                }
            }
            throw new global::Lua.LuaRuntimeException(_context.Thread, $"{"Add"}: invalid argument #{_lastArgPos}: {_lastArg} ({_lastArg.Type}), expected: {_expectedType.FullName}", 2);
        });
        private static readonly global::Lua.LuaFunction _LuaRationalTimeExtensions_Convert = new global::Lua.LuaFunction("Convert", (_context, _) =>
        {
            global::Lua.LuaValue _lastArg = default;
            global::System.Int32 _lastArgPos = default;
            global::System.Type _expectedType = default;
            var _argCount = _context.ArgumentCount;
            var _arg0 = _lastArg = _argCount > 0 ? _context.GetArgument(0) : global::Lua.LuaValue.Nil;
            _lastArgPos = 0; _expectedType = typeof(global::Luny.Unity.IntegerTime.LuaRationalTime);
            if (_arg0.TryRead<global::Luny.Unity.IntegerTime.LuaRationalTime>(out var _p0_Unity_IntegerTime_RationalTime))
            {
                var _arg1 = _lastArg = _argCount > 1 ? _context.GetArgument(1) : global::Lua.LuaValue.Nil;
                _lastArgPos = 1; _expectedType = typeof(global::Luny.Unity.IntegerTime.LuaRationalTimeTicksPerSecond);
                if (_arg1.TryRead<global::Luny.Unity.IntegerTime.LuaRationalTimeTicksPerSecond>(out var _p1_Unity_IntegerTime_RationalTime_TicksPerSecond))
                {
                    if (_argCount == 2)
                    {
                        var time = _p0_Unity_IntegerTime_RationalTime.Value;
                        var rate = _p1_Unity_IntegerTime_RationalTime_TicksPerSecond.Value;
                        var _ret0 = global::Unity.IntegerTime.RationalTimeExtensions.Convert(time, rate);
                        var _lret0 = global::Luny.Unity.IntegerTime.LuaRationalTime.Bind(_ret0);
                        var _retCount = _context.Return(_lret0);
                        return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                    }
                }
            }
            throw new global::Lua.LuaRuntimeException(_context.Thread, $"{"Convert"}: invalid argument #{_lastArgPos}: {_lastArg} ({_lastArg.Type}), expected: {_expectedType.FullName}", 2);
        });
        private static readonly global::Lua.LuaFunction _LuaRationalTimeExtensions_Divide = new global::Lua.LuaFunction("Divide", (_context, _) =>
        {
            global::Lua.LuaValue _lastArg = default;
            global::System.Int32 _lastArgPos = default;
            global::System.Type _expectedType = default;
            var _argCount = _context.ArgumentCount;
            var _arg0 = _lastArg = _argCount > 0 ? _context.GetArgument(0) : global::Lua.LuaValue.Nil;
            _lastArgPos = 0; _expectedType = typeof(global::Luny.Unity.IntegerTime.LuaRationalTime);
            if (_arg0.TryRead<global::Luny.Unity.IntegerTime.LuaRationalTime>(out var _p0_Unity_IntegerTime_RationalTime))
            {
                var _arg1 = _lastArg = _argCount > 1 ? _context.GetArgument(1) : global::Lua.LuaValue.Nil;
                _lastArgPos = 1; _expectedType = typeof(global::Luny.Unity.IntegerTime.LuaRationalTime);
                if (_arg1.TryRead<global::Luny.Unity.IntegerTime.LuaRationalTime>(out var _p1_Unity_IntegerTime_RationalTime))
                {
                    if (_argCount == 2)
                    {
                        var lhs = _p0_Unity_IntegerTime_RationalTime.Value;
                        var rhs = _p1_Unity_IntegerTime_RationalTime.Value;
                        var _ret0 = global::Unity.IntegerTime.RationalTimeExtensions.Divide(lhs, rhs);
                        var _lret0 = global::Luny.Unity.IntegerTime.LuaRationalTime.Bind(_ret0);
                        var _retCount = _context.Return(_lret0);
                        return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                    }
                }
            }
            throw new global::Lua.LuaRuntimeException(_context.Thread, $"{"Divide"}: invalid argument #{_lastArgPos}: {_lastArg} ({_lastArg.Type}), expected: {_expectedType.FullName}", 2);
        });
        private static readonly global::Lua.LuaFunction _LuaRationalTimeExtensions_IsValid = new global::Lua.LuaFunction("IsValid", (_context, _) =>
        {
            global::Lua.LuaValue _lastArg = default;
            global::System.Int32 _lastArgPos = default;
            global::System.Type _expectedType = default;
            var _argCount = _context.ArgumentCount;
            var _arg0 = _lastArg = _argCount > 0 ? _context.GetArgument(0) : global::Lua.LuaValue.Nil;
            _lastArgPos = 0; _expectedType = typeof(global::Luny.Unity.IntegerTime.LuaRationalTime);
            if (_arg0.TryRead<global::Luny.Unity.IntegerTime.LuaRationalTime>(out var _p0_Unity_IntegerTime_RationalTime))
            {
                if (_argCount == 1)
                {
                    var value = _p0_Unity_IntegerTime_RationalTime.Value;
                    var _ret0 = global::Unity.IntegerTime.RationalTimeExtensions.IsValid(value);
                    var _lret0 = new global::Lua.LuaValue(_ret0);
                    var _retCount = _context.Return(_lret0);
                    return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                }
            }
            throw new global::Lua.LuaRuntimeException(_context.Thread, $"{"IsValid"}: invalid argument #{_lastArgPos}: {_lastArg} ({_lastArg.Type}), expected: {_expectedType.FullName}", 2);
        });
        private static readonly global::Lua.LuaFunction _LuaRationalTimeExtensions_Multiply = new global::Lua.LuaFunction("Multiply", (_context, _) =>
        {
            global::Lua.LuaValue _lastArg = default;
            global::System.Int32 _lastArgPos = default;
            global::System.Type _expectedType = default;
            var _argCount = _context.ArgumentCount;
            var _arg0 = _lastArg = _argCount > 0 ? _context.GetArgument(0) : global::Lua.LuaValue.Nil;
            _lastArgPos = 0; _expectedType = typeof(global::Luny.Unity.IntegerTime.LuaRationalTime);
            if (_arg0.TryRead<global::Luny.Unity.IntegerTime.LuaRationalTime>(out var _p0_Unity_IntegerTime_RationalTime))
            {
                var _arg1 = _lastArg = _argCount > 1 ? _context.GetArgument(1) : global::Lua.LuaValue.Nil;
                _lastArgPos = 1; _expectedType = typeof(global::Luny.Unity.IntegerTime.LuaRationalTime);
                if (_arg1.TryRead<global::Luny.Unity.IntegerTime.LuaRationalTime>(out var _p1_Unity_IntegerTime_RationalTime))
                {
                    if (_argCount == 2)
                    {
                        var lhs = _p0_Unity_IntegerTime_RationalTime.Value;
                        var rhs = _p1_Unity_IntegerTime_RationalTime.Value;
                        var _ret0 = global::Unity.IntegerTime.RationalTimeExtensions.Multiply(lhs, rhs);
                        var _lret0 = global::Luny.Unity.IntegerTime.LuaRationalTime.Bind(_ret0);
                        var _retCount = _context.Return(_lret0);
                        return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                    }
                }
            }
            throw new global::Lua.LuaRuntimeException(_context.Thread, $"{"Multiply"}: invalid argument #{_lastArgPos}: {_lastArg} ({_lastArg.Type}), expected: {_expectedType.FullName}", 2);
        });
        private static readonly global::Lua.LuaFunction _LuaRationalTimeExtensions_Subtract = new global::Lua.LuaFunction("Subtract", (_context, _) =>
        {
            global::Lua.LuaValue _lastArg = default;
            global::System.Int32 _lastArgPos = default;
            global::System.Type _expectedType = default;
            var _argCount = _context.ArgumentCount;
            var _arg0 = _lastArg = _argCount > 0 ? _context.GetArgument(0) : global::Lua.LuaValue.Nil;
            _lastArgPos = 0; _expectedType = typeof(global::Luny.Unity.IntegerTime.LuaRationalTime);
            if (_arg0.TryRead<global::Luny.Unity.IntegerTime.LuaRationalTime>(out var _p0_Unity_IntegerTime_RationalTime))
            {
                var _arg1 = _lastArg = _argCount > 1 ? _context.GetArgument(1) : global::Lua.LuaValue.Nil;
                _lastArgPos = 1; _expectedType = typeof(global::Luny.Unity.IntegerTime.LuaRationalTime);
                if (_arg1.TryRead<global::Luny.Unity.IntegerTime.LuaRationalTime>(out var _p1_Unity_IntegerTime_RationalTime))
                {
                    if (_argCount == 2)
                    {
                        var lhs = _p0_Unity_IntegerTime_RationalTime.Value;
                        var rhs = _p1_Unity_IntegerTime_RationalTime.Value;
                        var _ret0 = global::Unity.IntegerTime.RationalTimeExtensions.Subtract(lhs, rhs);
                        var _lret0 = global::Luny.Unity.IntegerTime.LuaRationalTime.Bind(_ret0);
                        var _retCount = _context.Return(_lret0);
                        return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                    }
                }
            }
            throw new global::Lua.LuaRuntimeException(_context.Thread, $"{"Subtract"}: invalid argument #{_lastArgPos}: {_lastArg} ({_lastArg.Type}), expected: {_expectedType.FullName}", 2);
        });
        private static readonly global::Lua.LuaFunction _LuaRationalTimeExtensions_ToDouble = new global::Lua.LuaFunction("ToDouble", (_context, _) =>
        {
            global::Lua.LuaValue _lastArg = default;
            global::System.Int32 _lastArgPos = default;
            global::System.Type _expectedType = default;
            var _argCount = _context.ArgumentCount;
            var _arg0 = _lastArg = _argCount > 0 ? _context.GetArgument(0) : global::Lua.LuaValue.Nil;
            _lastArgPos = 0; _expectedType = typeof(global::Luny.Unity.IntegerTime.LuaRationalTime);
            if (_arg0.TryRead<global::Luny.Unity.IntegerTime.LuaRationalTime>(out var _p0_Unity_IntegerTime_RationalTime))
            {
                if (_argCount == 1)
                {
                    var value = _p0_Unity_IntegerTime_RationalTime.Value;
                    var _ret0 = global::Unity.IntegerTime.RationalTimeExtensions.ToDouble(value);
                    var _lret0 = new global::Lua.LuaValue(_ret0);
                    var _retCount = _context.Return(_lret0);
                    return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                }
            }
            throw new global::Lua.LuaRuntimeException(_context.Thread, $"{"ToDouble"}: invalid argument #{_lastArgPos}: {_lastArg} ({_lastArg.Type}), expected: {_expectedType.FullName}", 2);
        });
        private static readonly global::Lua.LuaFunction __index = new(global::Lua.Runtime.Metamethods.Index, (_context, _) =>
        {
            var _this = _context.GetArgument<LuaRationalTimeExtensionsType>(0);
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
            var _this = _context.GetArgument<LuaRationalTimeExtensionsType>(0);
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
                case "Add": _value = _LuaRationalTimeExtensions_Add; return true;
                case "Convert": _value = _LuaRationalTimeExtensions_Convert; return true;
                case "Divide": _value = _LuaRationalTimeExtensions_Divide; return true;
                case "IsValid": _value = _LuaRationalTimeExtensions_IsValid; return true;
                case "Multiply": _value = _LuaRationalTimeExtensions_Multiply; return true;
                case "Subtract": _value = _LuaRationalTimeExtensions_Subtract; return true;
                case "ToDouble": _value = _LuaRationalTimeExtensions_ToDouble; return true;
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
