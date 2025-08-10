
// --------------------------------------------------------------
// GENERATED FILE ----> DO NOT EDIT <---- CHANGES WILL BE LOST !!
// --------------------------------------------------------------

#if UNITY_6000_0_OR_NEWER && !(UNITY_6000_1_OR_NEWER)
#pragma warning disable 0109, 0162, 0168, 0219
using Luny;

namespace Luny.UnityEngine
{
    public sealed class LuaBoundsInt : global::Luny.ILuaValueType<global::UnityEngine.BoundsInt>
    {
        public new static global::Lua.LuaValue Bind(in global::UnityEngine.BoundsInt instance) => new LuaBoundsInt(instance);
        public new static global::Lua.LuaValue Bind(global::System.Object instance) => Bind((global::UnityEngine.BoundsInt)instance);
        public new static global::Lua.LuaValue Bind(global::System.Collections.Generic.IList<global::UnityEngine.BoundsInt> instances) =>
            new global::Luny.LuaList<global::UnityEngine.BoundsInt>(instances);
        public new static global::Lua.LuaValue Bind(global::System.Collections.Generic.IList<global::System.Object> instances) =>
            new global::Luny.LuaList<global::UnityEngine.BoundsInt>(instances);
        private LuaBoundsInt(in global::UnityEngine.BoundsInt value) => m_Value = value;
        public static implicit operator global::Lua.LuaValue(LuaBoundsInt value) => new(value);
        private global::UnityEngine.BoundsInt m_Value;
        public global::UnityEngine.BoundsInt Value { get => m_Value; set => m_Value = value; }
        public ref global::UnityEngine.BoundsInt ValueRef => ref m_Value;
        public global::System.Type BindType => typeof(global::UnityEngine.BoundsInt);
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

        private static readonly global::Lua.LuaFunction _LuaBoundsInt_ClampToBounds = new global::Lua.LuaFunction("ClampToBounds", (_context, _) =>
        {
            global::Lua.LuaValue _lastArg = default;
            global::System.Int32 _lastArgPos = default;
            global::System.Type _expectedType = default;
            var _argCount = _context.ArgumentCount;
            var _this = _context.GetArgument<LuaBoundsInt>(0);
            var _arg0 = _lastArg = _argCount > 1 ? _context.GetArgument(1) : global::Lua.LuaValue.Nil;
            _lastArgPos = 0; _expectedType = typeof(global::Luny.UnityEngine.LuaBoundsInt);
            if (_arg0.TryRead<global::Luny.UnityEngine.LuaBoundsInt>(out var _p0_UnityEngine_BoundsInt))
            {
                if (_argCount == 2)
                {
                    var bounds = _p0_UnityEngine_BoundsInt.Value;
                    _this.m_Value.ClampToBounds(bounds);
                    var _retCount = _context.Return();
                    return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                }
            }
            throw new global::Lua.LuaRuntimeException(_context.Thread, $"{"ClampToBounds"}: invalid argument #{_lastArgPos}: {_lastArg} ({_lastArg.Type}), expected: {_expectedType.FullName}", 2);
        });
        private static readonly global::Lua.LuaFunction _LuaBoundsInt_Contains = new global::Lua.LuaFunction("Contains", (_context, _) =>
        {
            global::Lua.LuaValue _lastArg = default;
            global::System.Int32 _lastArgPos = default;
            global::System.Type _expectedType = default;
            var _argCount = _context.ArgumentCount;
            var _this = _context.GetArgument<LuaBoundsInt>(0);
            var _arg0 = _lastArg = _argCount > 1 ? _context.GetArgument(1) : global::Lua.LuaValue.Nil;
            _lastArgPos = 0; _expectedType = typeof(global::Luny.UnityEngine.LuaVector3Int);
            if (_arg0.TryRead<global::Luny.UnityEngine.LuaVector3Int>(out var _p0_UnityEngine_Vector3Int))
            {
                if (_argCount == 2)
                {
                    var position = _p0_UnityEngine_Vector3Int.Value;
                    var _ret0 = _this.m_Value.Contains(position);
                    var _lret0 = new global::Lua.LuaValue(_ret0);
                    var _retCount = _context.Return(_lret0);
                    return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                }
            }
            throw new global::Lua.LuaRuntimeException(_context.Thread, $"{"Contains"}: invalid argument #{_lastArgPos}: {_lastArg} ({_lastArg.Type}), expected: {_expectedType.FullName}", 2);
        });
        private static readonly global::Lua.LuaFunction _LuaBoundsInt_Equals = new global::Lua.LuaFunction("Equals", (_context, _) =>
        {
            global::Lua.LuaValue _lastArg = default;
            global::System.Int32 _lastArgPos = default;
            global::System.Type _expectedType = default;
            var _argCount = _context.ArgumentCount;
            var _this = _context.GetArgument<LuaBoundsInt>(0);
            var _arg0 = _lastArg = _argCount > 1 ? _context.GetArgument(1) : global::Lua.LuaValue.Nil;
            _lastArgPos = 0; _expectedType = typeof(global::Luny.UnityEngine.LuaBoundsInt);
            if (_arg0.TryRead<global::Luny.UnityEngine.LuaBoundsInt>(out var _p0_UnityEngine_BoundsInt))
            {
                if (_argCount == 2)
                {
                    var other = _p0_UnityEngine_BoundsInt.Value;
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
        private static readonly global::Lua.LuaFunction _LuaBoundsInt_GetHashCode = new global::Lua.LuaFunction("GetHashCode", (_context, _) =>
        {
            global::Lua.LuaValue _lastArg = default;
            global::System.Int32 _lastArgPos = default;
            global::System.Type _expectedType = default;
            var _argCount = _context.ArgumentCount;
            var _this = _context.GetArgument<LuaBoundsInt>(0);
            if (_argCount == 1)
            {
                var _ret0 = _this.m_Value.GetHashCode();
                var _lret0 = new global::Lua.LuaValue(_ret0);
                var _retCount = _context.Return(_lret0);
                return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
            }
            throw new global::Lua.LuaRuntimeException(_context.Thread, $"{"GetHashCode"}: invalid argument #{_lastArgPos}: {_lastArg} ({_lastArg.Type}), expected: {_expectedType.FullName}", 2);
        });
        private static readonly global::Lua.LuaFunction _LuaBoundsInt_SetMinMax = new global::Lua.LuaFunction("SetMinMax", (_context, _) =>
        {
            global::Lua.LuaValue _lastArg = default;
            global::System.Int32 _lastArgPos = default;
            global::System.Type _expectedType = default;
            var _argCount = _context.ArgumentCount;
            var _this = _context.GetArgument<LuaBoundsInt>(0);
            var _arg0 = _lastArg = _argCount > 1 ? _context.GetArgument(1) : global::Lua.LuaValue.Nil;
            _lastArgPos = 0; _expectedType = typeof(global::Luny.UnityEngine.LuaVector3Int);
            if (_arg0.TryRead<global::Luny.UnityEngine.LuaVector3Int>(out var _p0_UnityEngine_Vector3Int))
            {
                var _arg1 = _lastArg = _argCount > 2 ? _context.GetArgument(2) : global::Lua.LuaValue.Nil;
                _lastArgPos = 1; _expectedType = typeof(global::Luny.UnityEngine.LuaVector3Int);
                if (_arg1.TryRead<global::Luny.UnityEngine.LuaVector3Int>(out var _p1_UnityEngine_Vector3Int))
                {
                    if (_argCount == 3)
                    {
                        var minPosition = _p0_UnityEngine_Vector3Int.Value;
                        var maxPosition = _p1_UnityEngine_Vector3Int.Value;
                        _this.m_Value.SetMinMax(minPosition, maxPosition);
                        var _retCount = _context.Return();
                        return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                    }
                }
            }
            throw new global::Lua.LuaRuntimeException(_context.Thread, $"{"SetMinMax"}: invalid argument #{_lastArgPos}: {_lastArg} ({_lastArg.Type}), expected: {_expectedType.FullName}", 2);
        });
        private static readonly global::Lua.LuaFunction _LuaBoundsInt_ToString = new global::Lua.LuaFunction("ToString", (_context, _) =>
        {
            global::Lua.LuaValue _lastArg = default;
            global::System.Int32 _lastArgPos = default;
            global::System.Type _expectedType = default;
            var _argCount = _context.ArgumentCount;
            var _this = _context.GetArgument<LuaBoundsInt>(0);
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
            var _this = _context.GetArgument<LuaBoundsInt>(0);
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
            var _this = _context.GetArgument<LuaBoundsInt>(0);
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
                case "ClampToBounds": _value = _LuaBoundsInt_ClampToBounds; return true;
                case "Contains": _value = _LuaBoundsInt_Contains; return true;
                case "Equals": _value = _LuaBoundsInt_Equals; return true;
                case "GetHashCode": _value = _LuaBoundsInt_GetHashCode; return true;
                case "SetMinMax": _value = _LuaBoundsInt_SetMinMax; return true;
                case "ToString": _value = _LuaBoundsInt_ToString; return true;
                case "allPositionsWithin": _value = global::Luny.UnityEngine.LuaBoundsIntPositionEnumerator.Bind(m_Value.allPositionsWithin); return true;
                case "center": _value = global::Luny.UnityEngine.LuaVector3.Bind(m_Value.center); return true;
                case "max": _value = global::Luny.UnityEngine.LuaVector3Int.Bind(m_Value.max); return true;
                case "min": _value = global::Luny.UnityEngine.LuaVector3Int.Bind(m_Value.min); return true;
                case "position": _value = global::Luny.UnityEngine.LuaVector3Int.Bind(m_Value.position); return true;
                case "size": _value = global::Luny.UnityEngine.LuaVector3Int.Bind(m_Value.size); return true;
                case "x": _value = new global::Lua.LuaValue(m_Value.x); return true;
                case "xMax": _value = new global::Lua.LuaValue(m_Value.xMax); return true;
                case "xMin": _value = new global::Lua.LuaValue(m_Value.xMin); return true;
                case "y": _value = new global::Lua.LuaValue(m_Value.y); return true;
                case "yMax": _value = new global::Lua.LuaValue(m_Value.yMax); return true;
                case "yMin": _value = new global::Lua.LuaValue(m_Value.yMin); return true;
                case "z": _value = new global::Lua.LuaValue(m_Value.z); return true;
                case "zMax": _value = new global::Lua.LuaValue(m_Value.zMax); return true;
                case "zMin": _value = new global::Lua.LuaValue(m_Value.zMin); return true;
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
                case "max": { var _temp = m_Value; _temp.max = _value.Read<global::Luny.UnityEngine.LuaVector3Int>().Value; m_Value = _temp; } return true;
                case "min": { var _temp = m_Value; _temp.min = _value.Read<global::Luny.UnityEngine.LuaVector3Int>().Value; m_Value = _temp; } return true;
                case "position": { var _temp = m_Value; _temp.position = _value.Read<global::Luny.UnityEngine.LuaVector3Int>().Value; m_Value = _temp; } return true;
                case "size": { var _temp = m_Value; _temp.size = _value.Read<global::Luny.UnityEngine.LuaVector3Int>().Value; m_Value = _temp; } return true;
                case "x": { var _temp = m_Value; _temp.x = _value.Read<global::System.Int32>(); m_Value = _temp; } return true;
                case "xMax": { var _temp = m_Value; _temp.xMax = _value.Read<global::System.Int32>(); m_Value = _temp; } return true;
                case "xMin": { var _temp = m_Value; _temp.xMin = _value.Read<global::System.Int32>(); m_Value = _temp; } return true;
                case "y": { var _temp = m_Value; _temp.y = _value.Read<global::System.Int32>(); m_Value = _temp; } return true;
                case "yMax": { var _temp = m_Value; _temp.yMax = _value.Read<global::System.Int32>(); m_Value = _temp; } return true;
                case "yMin": { var _temp = m_Value; _temp.yMin = _value.Read<global::System.Int32>(); m_Value = _temp; } return true;
                case "z": { var _temp = m_Value; _temp.z = _value.Read<global::System.Int32>(); m_Value = _temp; } return true;
                case "zMax": { var _temp = m_Value; _temp.zMax = _value.Read<global::System.Int32>(); m_Value = _temp; } return true;
                case "zMin": { var _temp = m_Value; _temp.zMin = _value.Read<global::System.Int32>(); m_Value = _temp; } return true;
                default: return false;
            }
        }
    }
    public sealed class LuaBoundsIntType : global::Luny.ILuaStatic
    {
        public static global::Lua.LuaValue Bind() => new LuaBoundsIntType();
        private LuaBoundsIntType() {}
        public static implicit operator global::Lua.LuaValue(LuaBoundsIntType value) => new(value);
        public global::System.Type BindType => typeof(global::UnityEngine.BoundsInt);
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

        private static readonly global::Lua.LuaFunction _LuaBoundsInt_new = new global::Lua.LuaFunction(".ctor", (_context, _) =>
        {
            global::Lua.LuaValue _lastArg = default;
            global::System.Int32 _lastArgPos = default;
            global::System.Type _expectedType = default;
            var _argCount = _context.ArgumentCount;
            if (_argCount == 0)
            {
                var _ret0 = new global::UnityEngine.BoundsInt();
                var _lret0 = global::Luny.UnityEngine.LuaBoundsInt.Bind(_ret0);
                var _retCount = _context.Return(_lret0);
                return new global::System.Threading.Tasks.ValueTask<global::System.Int32>(_retCount);
            }
            var _arg0 = _lastArg = _argCount > 0 ? _context.GetArgument(0) : global::Lua.LuaValue.Nil;
            _lastArgPos = 0; _expectedType = typeof(global::Luny.UnityEngine.LuaVector3Int);
            if (_arg0.TryRead<global::Luny.UnityEngine.LuaVector3Int>(out var _p0_UnityEngine_Vector3Int))
            {
                var _arg1 = _lastArg = _argCount > 1 ? _context.GetArgument(1) : global::Lua.LuaValue.Nil;
                _lastArgPos = 1; _expectedType = typeof(global::Luny.UnityEngine.LuaVector3Int);
                if (_arg1.TryRead<global::Luny.UnityEngine.LuaVector3Int>(out var _p1_UnityEngine_Vector3Int))
                {
                    if (_argCount == 2)
                    {
                        var position = _p0_UnityEngine_Vector3Int.Value;
                        var size = _p1_UnityEngine_Vector3Int.Value;
                        var _ret0 = new global::UnityEngine.BoundsInt(position, size);
                        var _lret0 = global::Luny.UnityEngine.LuaBoundsInt.Bind(_ret0);
                        var _retCount = _context.Return(_lret0);
                        return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                    }
                }
            }
            _lastArgPos = 0; _expectedType = typeof(global::System.Int32);
            if (_arg0.TryRead<global::System.Int32>(out var _p0_System_Int32))
            {
                var _arg1 = _lastArg = _argCount > 1 ? _context.GetArgument(1) : global::Lua.LuaValue.Nil;
                _lastArgPos = 1; _expectedType = typeof(global::System.Int32);
                if (_arg1.TryRead<global::System.Int32>(out var _p1_System_Int32))
                {
                    var _arg2 = _lastArg = _argCount > 2 ? _context.GetArgument(2) : global::Lua.LuaValue.Nil;
                    _lastArgPos = 2; _expectedType = typeof(global::System.Int32);
                    if (_arg2.TryRead<global::System.Int32>(out var _p2_System_Int32))
                    {
                        var _arg3 = _lastArg = _argCount > 3 ? _context.GetArgument(3) : global::Lua.LuaValue.Nil;
                        _lastArgPos = 3; _expectedType = typeof(global::System.Int32);
                        if (_arg3.TryRead<global::System.Int32>(out var _p3_System_Int32))
                        {
                            var _arg4 = _lastArg = _argCount > 4 ? _context.GetArgument(4) : global::Lua.LuaValue.Nil;
                            _lastArgPos = 4; _expectedType = typeof(global::System.Int32);
                            if (_arg4.TryRead<global::System.Int32>(out var _p4_System_Int32))
                            {
                                var _arg5 = _lastArg = _argCount > 5 ? _context.GetArgument(5) : global::Lua.LuaValue.Nil;
                                _lastArgPos = 5; _expectedType = typeof(global::System.Int32);
                                if (_arg5.TryRead<global::System.Int32>(out var _p5_System_Int32))
                                {
                                    if (_argCount == 6)
                                    {
                                        var xMin = _p0_System_Int32;
                                        var yMin = _p1_System_Int32;
                                        var zMin = _p2_System_Int32;
                                        var sizeX = _p3_System_Int32;
                                        var sizeY = _p4_System_Int32;
                                        var sizeZ = _p5_System_Int32;
                                        var _ret0 = new global::UnityEngine.BoundsInt(xMin, yMin, zMin, sizeX, sizeY, sizeZ);
                                        var _lret0 = global::Luny.UnityEngine.LuaBoundsInt.Bind(_ret0);
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
            var _this = _context.GetArgument<LuaBoundsIntType>(0);
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
            var _this = _context.GetArgument<LuaBoundsIntType>(0);
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
                case "new": _value = _LuaBoundsInt_new; return true;
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
