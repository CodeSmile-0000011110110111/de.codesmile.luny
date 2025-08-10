
// --------------------------------------------------------------
// GENERATED FILE ----> DO NOT EDIT <---- CHANGES WILL BE LOST !!
// --------------------------------------------------------------

#if UNITY_6000_1_OR_NEWER && !(UNITY_6000_2_OR_NEWER)
#pragma warning disable 0109, 0162, 0168, 0219
using Luny;

namespace Luny.UnityEngine
{
    public sealed class LuaRectInt : global::Luny.ILuaValueType<global::UnityEngine.RectInt>
    {
        public new static global::Lua.LuaValue Bind(in global::UnityEngine.RectInt instance) => new LuaRectInt(instance);
        public new static global::Lua.LuaValue Bind(global::System.Object instance) => Bind((global::UnityEngine.RectInt)instance);
        public new static global::Lua.LuaValue Bind(global::System.Collections.Generic.IList<global::UnityEngine.RectInt> instances) =>
            new global::Luny.LuaList<global::UnityEngine.RectInt>(instances);
        public new static global::Lua.LuaValue Bind(global::System.Collections.Generic.IList<global::System.Object> instances) =>
            new global::Luny.LuaList<global::UnityEngine.RectInt>(instances);
        private LuaRectInt(in global::UnityEngine.RectInt value) => m_Value = value;
        public static implicit operator global::Lua.LuaValue(LuaRectInt value) => new(value);
        private global::UnityEngine.RectInt m_Value;
        public global::UnityEngine.RectInt Value { get => m_Value; set => m_Value = value; }
        public ref global::UnityEngine.RectInt ValueRef => ref m_Value;
        public global::System.Type BindType => typeof(global::UnityEngine.RectInt);
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

        private static readonly global::Lua.LuaFunction _LuaRectInt_ClampToBounds = new global::Lua.LuaFunction("ClampToBounds", (_context, _) =>
        {
            global::Lua.LuaValue _lastArg = default;
            global::System.Int32 _lastArgPos = default;
            global::System.Type _expectedType = default;
            var _argCount = _context.ArgumentCount;
            var _this = _context.GetArgument<LuaRectInt>(0);
            var _arg0 = _lastArg = _argCount > 1 ? _context.GetArgument(1) : global::Lua.LuaValue.Nil;
            _lastArgPos = 0; _expectedType = typeof(global::Luny.UnityEngine.LuaRectInt);
            if (_arg0.TryRead<global::Luny.UnityEngine.LuaRectInt>(out var _p0_UnityEngine_RectInt))
            {
                if (_argCount == 2)
                {
                    var bounds = _p0_UnityEngine_RectInt.Value;
                    _this.m_Value.ClampToBounds(bounds);
                    var _retCount = _context.Return();
                    return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                }
            }
            throw new global::Lua.LuaRuntimeException(_context.Thread, $"{"ClampToBounds"}: invalid argument #{_lastArgPos}: {_lastArg} ({_lastArg.Type}), expected: {_expectedType.FullName}", 2);
        });
        private static readonly global::Lua.LuaFunction _LuaRectInt_Contains = new global::Lua.LuaFunction("Contains", (_context, _) =>
        {
            global::Lua.LuaValue _lastArg = default;
            global::System.Int32 _lastArgPos = default;
            global::System.Type _expectedType = default;
            var _argCount = _context.ArgumentCount;
            var _this = _context.GetArgument<LuaRectInt>(0);
            var _arg0 = _lastArg = _argCount > 1 ? _context.GetArgument(1) : global::Lua.LuaValue.Nil;
            _lastArgPos = 0; _expectedType = typeof(global::Luny.UnityEngine.LuaVector2Int);
            if (_arg0.TryRead<global::Luny.UnityEngine.LuaVector2Int>(out var _p0_UnityEngine_Vector2Int))
            {
                if (_argCount == 2)
                {
                    var position = _p0_UnityEngine_Vector2Int.Value;
                    var _ret0 = _this.m_Value.Contains(position);
                    var _lret0 = new global::Lua.LuaValue(_ret0);
                    var _retCount = _context.Return(_lret0);
                    return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                }
            }
            throw new global::Lua.LuaRuntimeException(_context.Thread, $"{"Contains"}: invalid argument #{_lastArgPos}: {_lastArg} ({_lastArg.Type}), expected: {_expectedType.FullName}", 2);
        });
        private static readonly global::Lua.LuaFunction _LuaRectInt_Equals = new global::Lua.LuaFunction("Equals", (_context, _) =>
        {
            global::Lua.LuaValue _lastArg = default;
            global::System.Int32 _lastArgPos = default;
            global::System.Type _expectedType = default;
            var _argCount = _context.ArgumentCount;
            var _this = _context.GetArgument<LuaRectInt>(0);
            var _arg0 = _lastArg = _argCount > 1 ? _context.GetArgument(1) : global::Lua.LuaValue.Nil;
            _lastArgPos = 0; _expectedType = typeof(global::Luny.UnityEngine.LuaRectInt);
            if (_arg0.TryRead<global::Luny.UnityEngine.LuaRectInt>(out var _p0_UnityEngine_RectInt))
            {
                if (_argCount == 2)
                {
                    var other = _p0_UnityEngine_RectInt.Value;
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
        private static readonly global::Lua.LuaFunction _LuaRectInt_GetHashCode = new global::Lua.LuaFunction("GetHashCode", (_context, _) =>
        {
            global::Lua.LuaValue _lastArg = default;
            global::System.Int32 _lastArgPos = default;
            global::System.Type _expectedType = default;
            var _argCount = _context.ArgumentCount;
            var _this = _context.GetArgument<LuaRectInt>(0);
            if (_argCount == 1)
            {
                var _ret0 = _this.m_Value.GetHashCode();
                var _lret0 = new global::Lua.LuaValue(_ret0);
                var _retCount = _context.Return(_lret0);
                return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
            }
            throw new global::Lua.LuaRuntimeException(_context.Thread, $"{"GetHashCode"}: invalid argument #{_lastArgPos}: {_lastArg} ({_lastArg.Type}), expected: {_expectedType.FullName}", 2);
        });
        private static readonly global::Lua.LuaFunction _LuaRectInt_Overlaps = new global::Lua.LuaFunction("Overlaps", (_context, _) =>
        {
            global::Lua.LuaValue _lastArg = default;
            global::System.Int32 _lastArgPos = default;
            global::System.Type _expectedType = default;
            var _argCount = _context.ArgumentCount;
            var _this = _context.GetArgument<LuaRectInt>(0);
            var _arg0 = _lastArg = _argCount > 1 ? _context.GetArgument(1) : global::Lua.LuaValue.Nil;
            _lastArgPos = 0; _expectedType = typeof(global::Luny.UnityEngine.LuaRectInt);
            if (_arg0.TryRead<global::Luny.UnityEngine.LuaRectInt>(out var _p0_UnityEngine_RectInt))
            {
                if (_argCount == 2)
                {
                    var other = _p0_UnityEngine_RectInt.Value;
                    var _ret0 = _this.m_Value.Overlaps(other);
                    var _lret0 = new global::Lua.LuaValue(_ret0);
                    var _retCount = _context.Return(_lret0);
                    return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                }
            }
            throw new global::Lua.LuaRuntimeException(_context.Thread, $"{"Overlaps"}: invalid argument #{_lastArgPos}: {_lastArg} ({_lastArg.Type}), expected: {_expectedType.FullName}", 2);
        });
        private static readonly global::Lua.LuaFunction _LuaRectInt_SetMinMax = new global::Lua.LuaFunction("SetMinMax", (_context, _) =>
        {
            global::Lua.LuaValue _lastArg = default;
            global::System.Int32 _lastArgPos = default;
            global::System.Type _expectedType = default;
            var _argCount = _context.ArgumentCount;
            var _this = _context.GetArgument<LuaRectInt>(0);
            var _arg0 = _lastArg = _argCount > 1 ? _context.GetArgument(1) : global::Lua.LuaValue.Nil;
            _lastArgPos = 0; _expectedType = typeof(global::Luny.UnityEngine.LuaVector2Int);
            if (_arg0.TryRead<global::Luny.UnityEngine.LuaVector2Int>(out var _p0_UnityEngine_Vector2Int))
            {
                var _arg1 = _lastArg = _argCount > 2 ? _context.GetArgument(2) : global::Lua.LuaValue.Nil;
                _lastArgPos = 1; _expectedType = typeof(global::Luny.UnityEngine.LuaVector2Int);
                if (_arg1.TryRead<global::Luny.UnityEngine.LuaVector2Int>(out var _p1_UnityEngine_Vector2Int))
                {
                    if (_argCount == 3)
                    {
                        var minPosition = _p0_UnityEngine_Vector2Int.Value;
                        var maxPosition = _p1_UnityEngine_Vector2Int.Value;
                        _this.m_Value.SetMinMax(minPosition, maxPosition);
                        var _retCount = _context.Return();
                        return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                    }
                }
            }
            throw new global::Lua.LuaRuntimeException(_context.Thread, $"{"SetMinMax"}: invalid argument #{_lastArgPos}: {_lastArg} ({_lastArg.Type}), expected: {_expectedType.FullName}", 2);
        });
        private static readonly global::Lua.LuaFunction _LuaRectInt_ToString = new global::Lua.LuaFunction("ToString", (_context, _) =>
        {
            global::Lua.LuaValue _lastArg = default;
            global::System.Int32 _lastArgPos = default;
            global::System.Type _expectedType = default;
            var _argCount = _context.ArgumentCount;
            var _this = _context.GetArgument<LuaRectInt>(0);
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
            var _this = _context.GetArgument<LuaRectInt>(0);
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
            var _this = _context.GetArgument<LuaRectInt>(0);
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
                case "ClampToBounds": _value = _LuaRectInt_ClampToBounds; return true;
                case "Contains": _value = _LuaRectInt_Contains; return true;
                case "Equals": _value = _LuaRectInt_Equals; return true;
                case "GetHashCode": _value = _LuaRectInt_GetHashCode; return true;
                case "Overlaps": _value = _LuaRectInt_Overlaps; return true;
                case "SetMinMax": _value = _LuaRectInt_SetMinMax; return true;
                case "ToString": _value = _LuaRectInt_ToString; return true;
                case "allPositionsWithin": _value = global::Luny.UnityEngine.LuaRectIntPositionEnumerator.Bind(m_Value.allPositionsWithin); return true;
                case "center": _value = global::Luny.UnityEngine.LuaVector2.Bind(m_Value.center); return true;
                case "height": _value = new global::Lua.LuaValue(m_Value.height); return true;
                case "max": _value = global::Luny.UnityEngine.LuaVector2Int.Bind(m_Value.max); return true;
                case "min": _value = global::Luny.UnityEngine.LuaVector2Int.Bind(m_Value.min); return true;
                case "position": _value = global::Luny.UnityEngine.LuaVector2Int.Bind(m_Value.position); return true;
                case "size": _value = global::Luny.UnityEngine.LuaVector2Int.Bind(m_Value.size); return true;
                case "width": _value = new global::Lua.LuaValue(m_Value.width); return true;
                case "x": _value = new global::Lua.LuaValue(m_Value.x); return true;
                case "xMax": _value = new global::Lua.LuaValue(m_Value.xMax); return true;
                case "xMin": _value = new global::Lua.LuaValue(m_Value.xMin); return true;
                case "y": _value = new global::Lua.LuaValue(m_Value.y); return true;
                case "yMax": _value = new global::Lua.LuaValue(m_Value.yMax); return true;
                case "yMin": _value = new global::Lua.LuaValue(m_Value.yMin); return true;
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
                case "height": { var _temp = m_Value; _temp.height = _value.Read<global::System.Int32>(); m_Value = _temp; } return true;
                case "max": { var _temp = m_Value; _temp.max = _value.Read<global::Luny.UnityEngine.LuaVector2Int>().Value; m_Value = _temp; } return true;
                case "min": { var _temp = m_Value; _temp.min = _value.Read<global::Luny.UnityEngine.LuaVector2Int>().Value; m_Value = _temp; } return true;
                case "position": { var _temp = m_Value; _temp.position = _value.Read<global::Luny.UnityEngine.LuaVector2Int>().Value; m_Value = _temp; } return true;
                case "size": { var _temp = m_Value; _temp.size = _value.Read<global::Luny.UnityEngine.LuaVector2Int>().Value; m_Value = _temp; } return true;
                case "width": { var _temp = m_Value; _temp.width = _value.Read<global::System.Int32>(); m_Value = _temp; } return true;
                case "x": { var _temp = m_Value; _temp.x = _value.Read<global::System.Int32>(); m_Value = _temp; } return true;
                case "xMax": { var _temp = m_Value; _temp.xMax = _value.Read<global::System.Int32>(); m_Value = _temp; } return true;
                case "xMin": { var _temp = m_Value; _temp.xMin = _value.Read<global::System.Int32>(); m_Value = _temp; } return true;
                case "y": { var _temp = m_Value; _temp.y = _value.Read<global::System.Int32>(); m_Value = _temp; } return true;
                case "yMax": { var _temp = m_Value; _temp.yMax = _value.Read<global::System.Int32>(); m_Value = _temp; } return true;
                case "yMin": { var _temp = m_Value; _temp.yMin = _value.Read<global::System.Int32>(); m_Value = _temp; } return true;
                default: return false;
            }
        }
    }
    public sealed class LuaRectIntType : global::Luny.ILuaStatic
    {
        public static global::Lua.LuaValue Bind() => new LuaRectIntType();
        private LuaRectIntType() {}
        public static implicit operator global::Lua.LuaValue(LuaRectIntType value) => new(value);
        public global::System.Type BindType => typeof(global::UnityEngine.RectInt);
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

        private static readonly global::Lua.LuaFunction _LuaRectInt_new = new global::Lua.LuaFunction(".ctor", (_context, _) =>
        {
            global::Lua.LuaValue _lastArg = default;
            global::System.Int32 _lastArgPos = default;
            global::System.Type _expectedType = default;
            var _argCount = _context.ArgumentCount;
            if (_argCount == 0)
            {
                var _ret0 = new global::UnityEngine.RectInt();
                var _lret0 = global::Luny.UnityEngine.LuaRectInt.Bind(_ret0);
                var _retCount = _context.Return(_lret0);
                return new global::System.Threading.Tasks.ValueTask<global::System.Int32>(_retCount);
            }
            var _arg0 = _lastArg = _argCount > 0 ? _context.GetArgument(0) : global::Lua.LuaValue.Nil;
            _lastArgPos = 0; _expectedType = typeof(global::Luny.UnityEngine.LuaVector2Int);
            if (_arg0.TryRead<global::Luny.UnityEngine.LuaVector2Int>(out var _p0_UnityEngine_Vector2Int))
            {
                var _arg1 = _lastArg = _argCount > 1 ? _context.GetArgument(1) : global::Lua.LuaValue.Nil;
                _lastArgPos = 1; _expectedType = typeof(global::Luny.UnityEngine.LuaVector2Int);
                if (_arg1.TryRead<global::Luny.UnityEngine.LuaVector2Int>(out var _p1_UnityEngine_Vector2Int))
                {
                    if (_argCount == 2)
                    {
                        var position = _p0_UnityEngine_Vector2Int.Value;
                        var size = _p1_UnityEngine_Vector2Int.Value;
                        var _ret0 = new global::UnityEngine.RectInt(position, size);
                        var _lret0 = global::Luny.UnityEngine.LuaRectInt.Bind(_ret0);
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
                            if (_argCount == 4)
                            {
                                var xMin = _p0_System_Int32;
                                var yMin = _p1_System_Int32;
                                var width = _p2_System_Int32;
                                var height = _p3_System_Int32;
                                var _ret0 = new global::UnityEngine.RectInt(xMin, yMin, width, height);
                                var _lret0 = global::Luny.UnityEngine.LuaRectInt.Bind(_ret0);
                                var _retCount = _context.Return(_lret0);
                                return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                            }
                        }
                    }
                }
            }
            throw new global::Lua.LuaRuntimeException(_context.Thread, $"{".ctor"}: invalid argument #{_lastArgPos}: {_lastArg} ({_lastArg.Type}), expected: {_expectedType.FullName}", 2);
        });
        private static readonly global::Lua.LuaFunction __index = new(global::Lua.Runtime.Metamethods.Index, (_context, _) =>
        {
            var _this = _context.GetArgument<LuaRectIntType>(0);
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
            var _this = _context.GetArgument<LuaRectIntType>(0);
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
                case "new": _value = _LuaRectInt_new; return true;
                case "zero": _value = global::Luny.UnityEngine.LuaRectInt.Bind(global::UnityEngine.RectInt.zero); return true;
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
