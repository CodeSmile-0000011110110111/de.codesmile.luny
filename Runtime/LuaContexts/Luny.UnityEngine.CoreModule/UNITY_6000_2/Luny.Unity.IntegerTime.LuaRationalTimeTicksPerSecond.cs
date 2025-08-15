
// --------------------------------------------------------------
// GENERATED FILE ----> DO NOT EDIT <---- CHANGES WILL BE LOST !!
// --------------------------------------------------------------

#if UNITY_6000_2_OR_NEWER && !(UNITY_6000_3_OR_NEWER)
#pragma warning disable 0109, 0162, 0168, 0219
using Luny;

namespace Luny.Unity.IntegerTime
{
    public sealed class LuaRationalTimeTicksPerSecond : global::Luny.ILuaValueType<global::Unity.IntegerTime.RationalTime.TicksPerSecond>
    {
        public new static global::Lua.LuaValue Bind(in global::Unity.IntegerTime.RationalTime.TicksPerSecond instance) => new LuaRationalTimeTicksPerSecond(instance);
        public new static global::Lua.LuaValue Bind(global::System.Object instance) => Bind((global::Unity.IntegerTime.RationalTime.TicksPerSecond)instance);
        public new static global::Lua.LuaValue Bind(global::System.Collections.Generic.IList<global::Unity.IntegerTime.RationalTime.TicksPerSecond> instances) =>
            new global::Luny.LuaList<global::Unity.IntegerTime.RationalTime.TicksPerSecond>(instances);
        public new static global::Lua.LuaValue Bind(global::System.Collections.Generic.IList<global::System.Object> instances) =>
            new global::Luny.LuaList<global::Unity.IntegerTime.RationalTime.TicksPerSecond>(instances);
        private LuaRationalTimeTicksPerSecond(in global::Unity.IntegerTime.RationalTime.TicksPerSecond value) => m_Value = value;
        public static implicit operator global::Lua.LuaValue(LuaRationalTimeTicksPerSecond value) => new(value);
        private global::Unity.IntegerTime.RationalTime.TicksPerSecond m_Value;
        public global::Unity.IntegerTime.RationalTime.TicksPerSecond Value { get => m_Value; set => m_Value = value; }
        public ref global::Unity.IntegerTime.RationalTime.TicksPerSecond ValueRef => ref m_Value;
        public global::System.Type BindType => typeof(global::Unity.IntegerTime.RationalTime.TicksPerSecond);
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

        private static readonly global::Lua.LuaFunction _LuaRationalTimeTicksPerSecond_Equals = new global::Lua.LuaFunction("Equals", (_context, _) =>
        {
            global::Lua.LuaValue _lastArg = default;
            global::System.Int32 _lastArgPos = default;
            global::System.Type _expectedType = default;
            var _argCount = _context.ArgumentCount;
            var _this = _context.GetArgument<LuaRationalTimeTicksPerSecond>(0);
            var _arg0 = _lastArg = _argCount > 1 ? _context.GetArgument(1) : global::Lua.LuaValue.Nil;
            _lastArgPos = 0; _expectedType = typeof(global::Luny.Unity.IntegerTime.LuaRationalTimeTicksPerSecond);
            if (_arg0.TryRead<global::Luny.Unity.IntegerTime.LuaRationalTimeTicksPerSecond>(out var _p0_Unity_IntegerTime_RationalTime_TicksPerSecond))
            {
                if (_argCount == 2)
                {
                    var rhs = _p0_Unity_IntegerTime_RationalTime_TicksPerSecond.Value;
                    var _ret0 = _this.m_Value.Equals(rhs);
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
                    var rhs = _p0_System_Object;
                    var _ret0 = _this.m_Value.Equals(rhs);
                    var _lret0 = new global::Lua.LuaValue(_ret0);
                    var _retCount = _context.Return(_lret0);
                    return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                }
            }
            throw new global::Lua.LuaRuntimeException(_context.Thread, $"{"Equals"}: invalid argument #{_lastArgPos}: {_lastArg} ({_lastArg.Type}), expected: {_expectedType.FullName}", 2);
        });
        private static readonly global::Lua.LuaFunction _LuaRationalTimeTicksPerSecond_GetHashCode = new global::Lua.LuaFunction("GetHashCode", (_context, _) =>
        {
            global::Lua.LuaValue _lastArg = default;
            global::System.Int32 _lastArgPos = default;
            global::System.Type _expectedType = default;
            var _argCount = _context.ArgumentCount;
            var _this = _context.GetArgument<LuaRationalTimeTicksPerSecond>(0);
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
            var _this = _context.GetArgument<LuaRationalTimeTicksPerSecond>(0);
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
            var _this = _context.GetArgument<LuaRationalTimeTicksPerSecond>(0);
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
                case "Equals": _value = _LuaRationalTimeTicksPerSecond_Equals; return true;
                case "GetHashCode": _value = _LuaRationalTimeTicksPerSecond_GetHashCode; return true;
                case "Denominator": _value = new global::Lua.LuaValue(m_Value.Denominator); return true;
                case "Numerator": _value = new global::Lua.LuaValue(m_Value.Numerator); return true;
                case "Valid": _value = new global::Lua.LuaValue(m_Value.Valid); return true;
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
    public sealed class LuaRationalTimeTicksPerSecondType : global::Luny.ILuaStatic
    {
        public static global::Lua.LuaValue Bind() => new LuaRationalTimeTicksPerSecondType();
        private LuaRationalTimeTicksPerSecondType() {}
        public static implicit operator global::Lua.LuaValue(LuaRationalTimeTicksPerSecondType value) => new(value);
        public global::System.Type BindType => typeof(global::Unity.IntegerTime.RationalTime.TicksPerSecond);
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
            metatable[global::Lua.Runtime.Metamethods.Call] = _LuaRationalTimeTicksPerSecond_new;
            return metatable;
        }
        public override global::System.String ToString() => BindType.FullName;
#if UNITY_EDITOR
        [global::UnityEngine.RuntimeInitializeOnLoadMethod(global::UnityEngine.RuntimeInitializeLoadType.SubsystemRegistration)]
        private static void ResetStaticFields() => s_Metatable = null;
#endif

        private static readonly global::Lua.LuaFunction _LuaRationalTimeTicksPerSecond_new = new global::Lua.LuaFunction(".ctor", (_context, _) =>
        {
            global::Lua.LuaValue _lastArg = default;
            global::System.Int32 _lastArgPos = default;
            global::System.Type _expectedType = default;
            var _argCount = _context.ArgumentCount;
            // ctor parameterless case
            if (_argCount == 1)
            {
                var _ret0 = new global::Unity.IntegerTime.RationalTime.TicksPerSecond();
                var _lret0 = global::Luny.Unity.IntegerTime.LuaRationalTimeTicksPerSecond.Bind(_ret0);
                var _retCount = _context.Return(_lret0);
                return new global::System.Threading.Tasks.ValueTask<global::System.Int32>(_retCount);
            }
            var _arg0 = _lastArg = _argCount > 1 ? _context.GetArgument(1) : global::Lua.LuaValue.Nil;
            _lastArgPos = 0; _expectedType = typeof(global::System.UInt32);
            if (_arg0.TryRead<global::System.UInt32>(out var _p0_System_UInt32))
            {
                if (_argCount == 2)
                {
                    var num = _p0_System_UInt32;
                    var _ret0 = new global::Unity.IntegerTime.RationalTime.TicksPerSecond(num);
                    var _lret0 = global::Luny.Unity.IntegerTime.LuaRationalTimeTicksPerSecond.Bind(_ret0);
                    var _retCount = _context.Return(_lret0);
                    return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                }
                var _arg1 = _lastArg = _argCount > 2 ? _context.GetArgument(2) : global::Lua.LuaValue.Nil;
                _lastArgPos = 1; _expectedType = typeof(global::System.UInt32);
                var _p1_System_UInt32 = _arg1.ReadValue<global::System.UInt32>((global::System.UInt32)(1));
                {
                    if (_argCount == 3)
                    {
                        var num = _p0_System_UInt32;
                        var den = _p1_System_UInt32;
                        var _ret0 = new global::Unity.IntegerTime.RationalTime.TicksPerSecond(num, den);
                        var _lret0 = global::Luny.Unity.IntegerTime.LuaRationalTimeTicksPerSecond.Bind(_ret0);
                        var _retCount = _context.Return(_lret0);
                        return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                    }
                }
            }
            throw new global::Lua.LuaRuntimeException(_context.Thread, $"{".ctor"}: invalid argument #{_lastArgPos}: {_lastArg} ({_lastArg.Type}), expected: {_expectedType.FullName}", 2);
        });
        private static readonly global::Lua.LuaFunction __index = new(global::Lua.Runtime.Metamethods.Index, (_context, _) =>
        {
            var _this = _context.GetArgument<LuaRationalTimeTicksPerSecondType>(0);
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
            var _this = _context.GetArgument<LuaRationalTimeTicksPerSecondType>(0);
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
                case "DefaultTicksPerSecond": _value = global::Luny.Unity.IntegerTime.LuaRationalTimeTicksPerSecond.Bind(global::Unity.IntegerTime.RationalTime.TicksPerSecond.DefaultTicksPerSecond); return true;
                case "TicksPerSecond11988": _value = global::Luny.Unity.IntegerTime.LuaRationalTimeTicksPerSecond.Bind(global::Unity.IntegerTime.RationalTime.TicksPerSecond.TicksPerSecond11988); return true;
                case "TicksPerSecond120": _value = global::Luny.Unity.IntegerTime.LuaRationalTimeTicksPerSecond.Bind(global::Unity.IntegerTime.RationalTime.TicksPerSecond.TicksPerSecond120); return true;
                case "TicksPerSecond2397": _value = global::Luny.Unity.IntegerTime.LuaRationalTimeTicksPerSecond.Bind(global::Unity.IntegerTime.RationalTime.TicksPerSecond.TicksPerSecond2397); return true;
                case "TicksPerSecond24": _value = global::Luny.Unity.IntegerTime.LuaRationalTimeTicksPerSecond.Bind(global::Unity.IntegerTime.RationalTime.TicksPerSecond.TicksPerSecond24); return true;
                case "TicksPerSecond2425": _value = global::Luny.Unity.IntegerTime.LuaRationalTimeTicksPerSecond.Bind(global::Unity.IntegerTime.RationalTime.TicksPerSecond.TicksPerSecond2425); return true;
                case "TicksPerSecond25": _value = global::Luny.Unity.IntegerTime.LuaRationalTimeTicksPerSecond.Bind(global::Unity.IntegerTime.RationalTime.TicksPerSecond.TicksPerSecond25); return true;
                case "TicksPerSecond2997": _value = global::Luny.Unity.IntegerTime.LuaRationalTimeTicksPerSecond.Bind(global::Unity.IntegerTime.RationalTime.TicksPerSecond.TicksPerSecond2997); return true;
                case "TicksPerSecond30": _value = global::Luny.Unity.IntegerTime.LuaRationalTimeTicksPerSecond.Bind(global::Unity.IntegerTime.RationalTime.TicksPerSecond.TicksPerSecond30); return true;
                case "TicksPerSecond50": _value = global::Luny.Unity.IntegerTime.LuaRationalTimeTicksPerSecond.Bind(global::Unity.IntegerTime.RationalTime.TicksPerSecond.TicksPerSecond50); return true;
                case "TicksPerSecond5994": _value = global::Luny.Unity.IntegerTime.LuaRationalTimeTicksPerSecond.Bind(global::Unity.IntegerTime.RationalTime.TicksPerSecond.TicksPerSecond5994); return true;
                case "TicksPerSecond60": _value = global::Luny.Unity.IntegerTime.LuaRationalTimeTicksPerSecond.Bind(global::Unity.IntegerTime.RationalTime.TicksPerSecond.TicksPerSecond60); return true;
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
