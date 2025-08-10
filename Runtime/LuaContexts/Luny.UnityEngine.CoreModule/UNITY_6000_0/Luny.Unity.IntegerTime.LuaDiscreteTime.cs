
// --------------------------------------------------------------
// GENERATED FILE ----> DO NOT EDIT <---- CHANGES WILL BE LOST !!
// --------------------------------------------------------------

#if UNITY_6000_0_OR_NEWER && !(UNITY_6000_1_OR_NEWER)
#pragma warning disable 0109, 0162, 0168, 0219
using Luny;

namespace Luny.Unity.IntegerTime
{
    public sealed class LuaDiscreteTime : global::Luny.ILuaValueType<global::Unity.IntegerTime.DiscreteTime>
    {
        public new static global::Lua.LuaValue Bind(in global::Unity.IntegerTime.DiscreteTime instance) => new LuaDiscreteTime(instance);
        public new static global::Lua.LuaValue Bind(global::System.Object instance) => Bind((global::Unity.IntegerTime.DiscreteTime)instance);
        public new static global::Lua.LuaValue Bind(global::System.Collections.Generic.IList<global::Unity.IntegerTime.DiscreteTime> instances) =>
            new global::Luny.LuaList<global::Unity.IntegerTime.DiscreteTime>(instances);
        public new static global::Lua.LuaValue Bind(global::System.Collections.Generic.IList<global::System.Object> instances) =>
            new global::Luny.LuaList<global::Unity.IntegerTime.DiscreteTime>(instances);
        private LuaDiscreteTime(in global::Unity.IntegerTime.DiscreteTime value) => m_Value = value;
        public static implicit operator global::Lua.LuaValue(LuaDiscreteTime value) => new(value);
        private global::Unity.IntegerTime.DiscreteTime m_Value;
        public global::Unity.IntegerTime.DiscreteTime Value { get => m_Value; set => m_Value = value; }
        public ref global::Unity.IntegerTime.DiscreteTime ValueRef => ref m_Value;
        public global::System.Type BindType => typeof(global::Unity.IntegerTime.DiscreteTime);
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

        private static readonly global::Lua.LuaFunction _LuaDiscreteTime_CompareTo = new global::Lua.LuaFunction("CompareTo", (_context, _) =>
        {
            global::Lua.LuaValue _lastArg = default;
            global::System.Int32 _lastArgPos = default;
            global::System.Type _expectedType = default;
            var _argCount = _context.ArgumentCount;
            var _this = _context.GetArgument<LuaDiscreteTime>(0);
            var _arg0 = _lastArg = _argCount > 1 ? _context.GetArgument(1) : global::Lua.LuaValue.Nil;
            _lastArgPos = 0; _expectedType = typeof(global::Luny.Unity.IntegerTime.LuaDiscreteTime);
            if (_arg0.TryRead<global::Luny.Unity.IntegerTime.LuaDiscreteTime>(out var _p0_Unity_IntegerTime_DiscreteTime))
            {
                if (_argCount == 2)
                {
                    var other = _p0_Unity_IntegerTime_DiscreteTime.Value;
                    var _ret0 = _this.m_Value.CompareTo(other);
                    var _lret0 = new global::Lua.LuaValue(_ret0);
                    var _retCount = _context.Return(_lret0);
                    return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                }
            }
            throw new global::Lua.LuaRuntimeException(_context.Thread, $"{"CompareTo"}: invalid argument #{_lastArgPos}: {_lastArg} ({_lastArg.Type}), expected: {_expectedType.FullName}", 2);
        });
        private static readonly global::Lua.LuaFunction _LuaDiscreteTime_Equals = new global::Lua.LuaFunction("Equals", (_context, _) =>
        {
            global::Lua.LuaValue _lastArg = default;
            global::System.Int32 _lastArgPos = default;
            global::System.Type _expectedType = default;
            var _argCount = _context.ArgumentCount;
            var _this = _context.GetArgument<LuaDiscreteTime>(0);
            var _arg0 = _lastArg = _argCount > 1 ? _context.GetArgument(1) : global::Lua.LuaValue.Nil;
            _lastArgPos = 0; _expectedType = typeof(global::Luny.Unity.IntegerTime.LuaDiscreteTime);
            if (_arg0.TryRead<global::Luny.Unity.IntegerTime.LuaDiscreteTime>(out var _p0_Unity_IntegerTime_DiscreteTime))
            {
                if (_argCount == 2)
                {
                    var rhs = _p0_Unity_IntegerTime_DiscreteTime.Value;
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
                    var o = _p0_System_Object;
                    var _ret0 = _this.m_Value.Equals(o);
                    var _lret0 = new global::Lua.LuaValue(_ret0);
                    var _retCount = _context.Return(_lret0);
                    return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                }
            }
            throw new global::Lua.LuaRuntimeException(_context.Thread, $"{"Equals"}: invalid argument #{_lastArgPos}: {_lastArg} ({_lastArg.Type}), expected: {_expectedType.FullName}", 2);
        });
        private static readonly global::Lua.LuaFunction _LuaDiscreteTime_GetHashCode = new global::Lua.LuaFunction("GetHashCode", (_context, _) =>
        {
            global::Lua.LuaValue _lastArg = default;
            global::System.Int32 _lastArgPos = default;
            global::System.Type _expectedType = default;
            var _argCount = _context.ArgumentCount;
            var _this = _context.GetArgument<LuaDiscreteTime>(0);
            if (_argCount == 1)
            {
                var _ret0 = _this.m_Value.GetHashCode();
                var _lret0 = new global::Lua.LuaValue(_ret0);
                var _retCount = _context.Return(_lret0);
                return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
            }
            throw new global::Lua.LuaRuntimeException(_context.Thread, $"{"GetHashCode"}: invalid argument #{_lastArgPos}: {_lastArg} ({_lastArg.Type}), expected: {_expectedType.FullName}", 2);
        });
        private static readonly global::Lua.LuaFunction _LuaDiscreteTime_ToString = new global::Lua.LuaFunction("ToString", (_context, _) =>
        {
            global::Lua.LuaValue _lastArg = default;
            global::System.Int32 _lastArgPos = default;
            global::System.Type _expectedType = default;
            var _argCount = _context.ArgumentCount;
            var _this = _context.GetArgument<LuaDiscreteTime>(0);
            if (_argCount == 1)
            {
                var _ret0 = _this.m_Value.ToString();
                var _lret0 = new global::Lua.LuaValue(_ret0);
                var _retCount = _context.Return(_lret0);
                return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
            }
            throw new global::Lua.LuaRuntimeException(_context.Thread, $"{"ToString"}: invalid argument #{_lastArgPos}: {_lastArg} ({_lastArg.Type}), expected: {_expectedType.FullName}", 2);
        });
        private static readonly global::Lua.LuaFunction __index = new(global::Lua.Runtime.Metamethods.Index, (_context, _) =>
        {
            var _this = _context.GetArgument<LuaDiscreteTime>(0);
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
            var _this = _context.GetArgument<LuaDiscreteTime>(0);
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
                case "CompareTo": _value = _LuaDiscreteTime_CompareTo; return true;
                case "Equals": _value = _LuaDiscreteTime_Equals; return true;
                case "GetHashCode": _value = _LuaDiscreteTime_GetHashCode; return true;
                case "ToString": _value = _LuaDiscreteTime_ToString; return true;
                case "Value": _value = new global::Lua.LuaValue(m_Value.Value); return true;
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
                case "Value": { var _temp = m_Value; _temp.Value = _value.Read<global::System.Int64>(); m_Value = _temp; } return true;
                default: return false;
            }
        }
    }
    public sealed class LuaDiscreteTimeType : global::Luny.ILuaStatic
    {
        public static global::Lua.LuaValue Bind() => new LuaDiscreteTimeType();
        private LuaDiscreteTimeType() {}
        public static implicit operator global::Lua.LuaValue(LuaDiscreteTimeType value) => new(value);
        public global::System.Type BindType => typeof(global::Unity.IntegerTime.DiscreteTime);
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

        private static readonly global::Lua.LuaFunction _LuaDiscreteTime_new = new global::Lua.LuaFunction(".ctor", (_context, _) =>
        {
            global::Lua.LuaValue _lastArg = default;
            global::System.Int32 _lastArgPos = default;
            global::System.Type _expectedType = default;
            var _argCount = _context.ArgumentCount;
            if (_argCount == 0)
            {
                var _ret0 = new global::Unity.IntegerTime.DiscreteTime();
                var _lret0 = global::Luny.Unity.IntegerTime.LuaDiscreteTime.Bind(_ret0);
                var _retCount = _context.Return(_lret0);
                return new global::System.Threading.Tasks.ValueTask<global::System.Int32>(_retCount);
            }
            var _arg0 = _lastArg = _argCount > 0 ? _context.GetArgument(0) : global::Lua.LuaValue.Nil;
            _lastArgPos = 0; _expectedType = typeof(global::System.Double);
            if (_arg0.TryRead<global::System.Double>(out var _p0_System_Double))
            {
                if (_argCount == 1)
                {
                    var v = _p0_System_Double;
                    var _ret0 = new global::Unity.IntegerTime.DiscreteTime(v);
                    var _lret0 = global::Luny.Unity.IntegerTime.LuaDiscreteTime.Bind(_ret0);
                    var _retCount = _context.Return(_lret0);
                    return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                }
            }
            _lastArgPos = 0; _expectedType = typeof(global::System.Single);
            if (_arg0.TryRead<global::System.Single>(out var _p0_System_Single))
            {
                if (_argCount == 1)
                {
                    var v = _p0_System_Single;
                    var _ret0 = new global::Unity.IntegerTime.DiscreteTime(v);
                    var _lret0 = global::Luny.Unity.IntegerTime.LuaDiscreteTime.Bind(_ret0);
                    var _retCount = _context.Return(_lret0);
                    return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                }
            }
            _lastArgPos = 0; _expectedType = typeof(global::System.Int64);
            if (_arg0.TryRead<global::System.Int64>(out var _p0_System_Int64))
            {
                if (_argCount == 1)
                {
                    var v = _p0_System_Int64;
                    var _ret0 = new global::Unity.IntegerTime.DiscreteTime(v);
                    var _lret0 = global::Luny.Unity.IntegerTime.LuaDiscreteTime.Bind(_ret0);
                    var _retCount = _context.Return(_lret0);
                    return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                }
            }
            _lastArgPos = 0; _expectedType = typeof(global::System.Int32);
            if (_arg0.TryRead<global::System.Int32>(out var _p0_System_Int32))
            {
                if (_argCount == 1)
                {
                    var v = _p0_System_Int32;
                    var _ret0 = new global::Unity.IntegerTime.DiscreteTime(v);
                    var _lret0 = global::Luny.Unity.IntegerTime.LuaDiscreteTime.Bind(_ret0);
                    var _retCount = _context.Return(_lret0);
                    return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                }
            }
            _lastArgPos = 0; _expectedType = typeof(global::Luny.Unity.IntegerTime.LuaDiscreteTime);
            if (_arg0.TryRead<global::Luny.Unity.IntegerTime.LuaDiscreteTime>(out var _p0_Unity_IntegerTime_DiscreteTime))
            {
                if (_argCount == 1)
                {
                    var x = _p0_Unity_IntegerTime_DiscreteTime.Value;
                    var _ret0 = new global::Unity.IntegerTime.DiscreteTime(x);
                    var _lret0 = global::Luny.Unity.IntegerTime.LuaDiscreteTime.Bind(_ret0);
                    var _retCount = _context.Return(_lret0);
                    return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                }
            }
            throw new global::Lua.LuaRuntimeException(_context.Thread, $"{".ctor"}: invalid argument #{_lastArgPos}: {_lastArg} ({_lastArg.Type}), expected: {_expectedType.FullName}", 2);
        });
        private static readonly global::Lua.LuaFunction _LuaDiscreteTime_FromTicks = new global::Lua.LuaFunction("FromTicks", (_context, _) =>
        {
            global::Lua.LuaValue _lastArg = default;
            global::System.Int32 _lastArgPos = default;
            global::System.Type _expectedType = default;
            var _argCount = _context.ArgumentCount;
            var _arg0 = _lastArg = _argCount > 0 ? _context.GetArgument(0) : global::Lua.LuaValue.Nil;
            _lastArgPos = 0; _expectedType = typeof(global::System.Int64);
            if (_arg0.TryRead<global::System.Int64>(out var _p0_System_Int64))
            {
                if (_argCount == 1)
                {
                    var v = _p0_System_Int64;
                    var _ret0 = global::Unity.IntegerTime.DiscreteTime.FromTicks(v);
                    var _lret0 = global::Luny.Unity.IntegerTime.LuaDiscreteTime.Bind(_ret0);
                    var _retCount = _context.Return(_lret0);
                    return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                }
            }
            throw new global::Lua.LuaRuntimeException(_context.Thread, $"{"FromTicks"}: invalid argument #{_lastArgPos}: {_lastArg} ({_lastArg.Type}), expected: {_expectedType.FullName}", 2);
        });
        private static readonly global::Lua.LuaFunction __index = new(global::Lua.Runtime.Metamethods.Index, (_context, _) =>
        {
            var _this = _context.GetArgument<LuaDiscreteTimeType>(0);
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
            var _this = _context.GetArgument<LuaDiscreteTimeType>(0);
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
                case "new": _value = _LuaDiscreteTime_new; return true;
                case "FromTicks": _value = _LuaDiscreteTime_FromTicks; return true;
                case "MaxValue": _value = global::Luny.Unity.IntegerTime.LuaDiscreteTime.Bind(global::Unity.IntegerTime.DiscreteTime.MaxValue); return true;
                case "MaxValueSeconds": _value = new global::Lua.LuaValue(global::Unity.IntegerTime.DiscreteTime.MaxValueSeconds); return true;
                case "MinValue": _value = global::Luny.Unity.IntegerTime.LuaDiscreteTime.Bind(global::Unity.IntegerTime.DiscreteTime.MinValue); return true;
                case "MinValueSeconds": _value = new global::Lua.LuaValue(global::Unity.IntegerTime.DiscreteTime.MinValueSeconds); return true;
                case "Tick": _value = new global::Lua.LuaValue(global::Unity.IntegerTime.DiscreteTime.Tick); return true;
                case "Tick1000Fps": _value = new global::Lua.LuaValue(global::Unity.IntegerTime.DiscreteTime.Tick1000Fps); return true;
                case "Tick10Fps": _value = new global::Lua.LuaValue(global::Unity.IntegerTime.DiscreteTime.Tick10Fps); return true;
                case "Tick11988Fps": _value = new global::Lua.LuaValue(global::Unity.IntegerTime.DiscreteTime.Tick11988Fps); return true;
                case "Tick120Fps": _value = new global::Lua.LuaValue(global::Unity.IntegerTime.DiscreteTime.Tick120Fps); return true;
                case "Tick12Fps": _value = new global::Lua.LuaValue(global::Unity.IntegerTime.DiscreteTime.Tick12Fps); return true;
                case "Tick15Fps": _value = new global::Lua.LuaValue(global::Unity.IntegerTime.DiscreteTime.Tick15Fps); return true;
                case "Tick16Khz": _value = new global::Lua.LuaValue(global::Unity.IntegerTime.DiscreteTime.Tick16Khz); return true;
                case "Tick192Khz": _value = new global::Lua.LuaValue(global::Unity.IntegerTime.DiscreteTime.Tick192Khz); return true;
                case "Tick22Khz": _value = new global::Lua.LuaValue(global::Unity.IntegerTime.DiscreteTime.Tick22Khz); return true;
                case "Tick2397Fps": _value = new global::Lua.LuaValue(global::Unity.IntegerTime.DiscreteTime.Tick2397Fps); return true;
                case "Tick240Fps": _value = new global::Lua.LuaValue(global::Unity.IntegerTime.DiscreteTime.Tick240Fps); return true;
                case "Tick24Fps": _value = new global::Lua.LuaValue(global::Unity.IntegerTime.DiscreteTime.Tick24Fps); return true;
                case "Tick25Fps": _value = new global::Lua.LuaValue(global::Unity.IntegerTime.DiscreteTime.Tick25Fps); return true;
                case "Tick2997Fps": _value = new global::Lua.LuaValue(global::Unity.IntegerTime.DiscreteTime.Tick2997Fps); return true;
                case "Tick30Fps": _value = new global::Lua.LuaValue(global::Unity.IntegerTime.DiscreteTime.Tick30Fps); return true;
                case "Tick44Khz": _value = new global::Lua.LuaValue(global::Unity.IntegerTime.DiscreteTime.Tick44Khz); return true;
                case "Tick48Fps": _value = new global::Lua.LuaValue(global::Unity.IntegerTime.DiscreteTime.Tick48Fps); return true;
                case "Tick48Khz": _value = new global::Lua.LuaValue(global::Unity.IntegerTime.DiscreteTime.Tick48Khz); return true;
                case "Tick50Fps": _value = new global::Lua.LuaValue(global::Unity.IntegerTime.DiscreteTime.Tick50Fps); return true;
                case "Tick5995Fps": _value = new global::Lua.LuaValue(global::Unity.IntegerTime.DiscreteTime.Tick5995Fps); return true;
                case "Tick5Fps": _value = new global::Lua.LuaValue(global::Unity.IntegerTime.DiscreteTime.Tick5Fps); return true;
                case "Tick60Fps": _value = new global::Lua.LuaValue(global::Unity.IntegerTime.DiscreteTime.Tick60Fps); return true;
                case "Tick88Khz": _value = new global::Lua.LuaValue(global::Unity.IntegerTime.DiscreteTime.Tick88Khz); return true;
                case "Tick8Khz": _value = new global::Lua.LuaValue(global::Unity.IntegerTime.DiscreteTime.Tick8Khz); return true;
                case "Tick90Fps": _value = new global::Lua.LuaValue(global::Unity.IntegerTime.DiscreteTime.Tick90Fps); return true;
                case "Tick96Khz": _value = new global::Lua.LuaValue(global::Unity.IntegerTime.DiscreteTime.Tick96Khz); return true;
                case "TicksPerSecond": _value = new global::Lua.LuaValue(global::Unity.IntegerTime.DiscreteTime.TicksPerSecond); return true;
                case "Zero": _value = global::Luny.Unity.IntegerTime.LuaDiscreteTime.Bind(global::Unity.IntegerTime.DiscreteTime.Zero); return true;
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
