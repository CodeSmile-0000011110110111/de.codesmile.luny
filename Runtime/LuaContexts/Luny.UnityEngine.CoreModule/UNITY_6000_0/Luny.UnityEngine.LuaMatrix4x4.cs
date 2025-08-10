
// --------------------------------------------------------------
// GENERATED FILE ----> DO NOT EDIT <---- CHANGES WILL BE LOST !!
// --------------------------------------------------------------

#if UNITY_6000_0_OR_NEWER && !(UNITY_6000_1_OR_NEWER)
#pragma warning disable 0109, 0162, 0168, 0219
using Luny;

namespace Luny.UnityEngine
{
    public sealed class LuaMatrix4x4 : global::Luny.ILuaValueType<global::UnityEngine.Matrix4x4>
    {
        public new static global::Lua.LuaValue Bind(in global::UnityEngine.Matrix4x4 instance) => new LuaMatrix4x4(instance);
        public new static global::Lua.LuaValue Bind(global::System.Object instance) => Bind((global::UnityEngine.Matrix4x4)instance);
        public new static global::Lua.LuaValue Bind(global::System.Collections.Generic.IList<global::UnityEngine.Matrix4x4> instances) =>
            new global::Luny.LuaList<global::UnityEngine.Matrix4x4>(instances);
        public new static global::Lua.LuaValue Bind(global::System.Collections.Generic.IList<global::System.Object> instances) =>
            new global::Luny.LuaList<global::UnityEngine.Matrix4x4>(instances);
        private LuaMatrix4x4(in global::UnityEngine.Matrix4x4 value) => m_Value = value;
        public static implicit operator global::Lua.LuaValue(LuaMatrix4x4 value) => new(value);
        private global::UnityEngine.Matrix4x4 m_Value;
        public global::UnityEngine.Matrix4x4 Value { get => m_Value; set => m_Value = value; }
        public ref global::UnityEngine.Matrix4x4 ValueRef => ref m_Value;
        public global::System.Type BindType => typeof(global::UnityEngine.Matrix4x4);
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

        private static readonly global::Lua.LuaFunction _LuaMatrix4x4_Equals = new global::Lua.LuaFunction("Equals", (_context, _) =>
        {
            global::Lua.LuaValue _lastArg = default;
            global::System.Int32 _lastArgPos = default;
            global::System.Type _expectedType = default;
            var _argCount = _context.ArgumentCount;
            var _this = _context.GetArgument<LuaMatrix4x4>(0);
            var _arg0 = _lastArg = _argCount > 1 ? _context.GetArgument(1) : global::Lua.LuaValue.Nil;
            _lastArgPos = 0; _expectedType = typeof(global::Luny.UnityEngine.LuaMatrix4x4);
            if (_arg0.TryRead<global::Luny.UnityEngine.LuaMatrix4x4>(out var _p0_UnityEngine_Matrix4x4))
            {
                if (_argCount == 2)
                {
                    var other = _p0_UnityEngine_Matrix4x4.Value;
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
        private static readonly global::Lua.LuaFunction _LuaMatrix4x4_GetColumn = new global::Lua.LuaFunction("GetColumn", (_context, _) =>
        {
            global::Lua.LuaValue _lastArg = default;
            global::System.Int32 _lastArgPos = default;
            global::System.Type _expectedType = default;
            var _argCount = _context.ArgumentCount;
            var _this = _context.GetArgument<LuaMatrix4x4>(0);
            var _arg0 = _lastArg = _argCount > 1 ? _context.GetArgument(1) : global::Lua.LuaValue.Nil;
            _lastArgPos = 0; _expectedType = typeof(global::System.Int32);
            if (_arg0.TryRead<global::System.Int32>(out var _p0_System_Int32))
            {
                if (_argCount == 2)
                {
                    var index = _p0_System_Int32;
                    var _ret0 = _this.m_Value.GetColumn(index);
                    var _lret0 = global::Luny.UnityEngine.LuaVector4.Bind(_ret0);
                    var _retCount = _context.Return(_lret0);
                    return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                }
            }
            throw new global::Lua.LuaRuntimeException(_context.Thread, $"{"GetColumn"}: invalid argument #{_lastArgPos}: {_lastArg} ({_lastArg.Type}), expected: {_expectedType.FullName}", 2);
        });
        private static readonly global::Lua.LuaFunction _LuaMatrix4x4_GetHashCode = new global::Lua.LuaFunction("GetHashCode", (_context, _) =>
        {
            global::Lua.LuaValue _lastArg = default;
            global::System.Int32 _lastArgPos = default;
            global::System.Type _expectedType = default;
            var _argCount = _context.ArgumentCount;
            var _this = _context.GetArgument<LuaMatrix4x4>(0);
            if (_argCount == 1)
            {
                var _ret0 = _this.m_Value.GetHashCode();
                var _lret0 = new global::Lua.LuaValue(_ret0);
                var _retCount = _context.Return(_lret0);
                return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
            }
            throw new global::Lua.LuaRuntimeException(_context.Thread, $"{"GetHashCode"}: invalid argument #{_lastArgPos}: {_lastArg} ({_lastArg.Type}), expected: {_expectedType.FullName}", 2);
        });
        private static readonly global::Lua.LuaFunction _LuaMatrix4x4_GetPosition = new global::Lua.LuaFunction("GetPosition", (_context, _) =>
        {
            global::Lua.LuaValue _lastArg = default;
            global::System.Int32 _lastArgPos = default;
            global::System.Type _expectedType = default;
            var _argCount = _context.ArgumentCount;
            var _this = _context.GetArgument<LuaMatrix4x4>(0);
            if (_argCount == 1)
            {
                var _ret0 = _this.m_Value.GetPosition();
                var _lret0 = global::Luny.UnityEngine.LuaVector3.Bind(_ret0);
                var _retCount = _context.Return(_lret0);
                return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
            }
            throw new global::Lua.LuaRuntimeException(_context.Thread, $"{"GetPosition"}: invalid argument #{_lastArgPos}: {_lastArg} ({_lastArg.Type}), expected: {_expectedType.FullName}", 2);
        });
        private static readonly global::Lua.LuaFunction _LuaMatrix4x4_GetRow = new global::Lua.LuaFunction("GetRow", (_context, _) =>
        {
            global::Lua.LuaValue _lastArg = default;
            global::System.Int32 _lastArgPos = default;
            global::System.Type _expectedType = default;
            var _argCount = _context.ArgumentCount;
            var _this = _context.GetArgument<LuaMatrix4x4>(0);
            var _arg0 = _lastArg = _argCount > 1 ? _context.GetArgument(1) : global::Lua.LuaValue.Nil;
            _lastArgPos = 0; _expectedType = typeof(global::System.Int32);
            if (_arg0.TryRead<global::System.Int32>(out var _p0_System_Int32))
            {
                if (_argCount == 2)
                {
                    var index = _p0_System_Int32;
                    var _ret0 = _this.m_Value.GetRow(index);
                    var _lret0 = global::Luny.UnityEngine.LuaVector4.Bind(_ret0);
                    var _retCount = _context.Return(_lret0);
                    return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                }
            }
            throw new global::Lua.LuaRuntimeException(_context.Thread, $"{"GetRow"}: invalid argument #{_lastArgPos}: {_lastArg} ({_lastArg.Type}), expected: {_expectedType.FullName}", 2);
        });
        private static readonly global::Lua.LuaFunction _LuaMatrix4x4_MultiplyPoint = new global::Lua.LuaFunction("MultiplyPoint", (_context, _) =>
        {
            global::Lua.LuaValue _lastArg = default;
            global::System.Int32 _lastArgPos = default;
            global::System.Type _expectedType = default;
            var _argCount = _context.ArgumentCount;
            var _this = _context.GetArgument<LuaMatrix4x4>(0);
            var _arg0 = _lastArg = _argCount > 1 ? _context.GetArgument(1) : global::Lua.LuaValue.Nil;
            _lastArgPos = 0; _expectedType = typeof(global::Luny.UnityEngine.LuaVector3);
            if (_arg0.TryRead<global::Luny.UnityEngine.LuaVector3>(out var _p0_UnityEngine_Vector3))
            {
                if (_argCount == 2)
                {
                    var point = _p0_UnityEngine_Vector3.Value;
                    var _ret0 = _this.m_Value.MultiplyPoint(point);
                    var _lret0 = global::Luny.UnityEngine.LuaVector3.Bind(_ret0);
                    var _retCount = _context.Return(_lret0);
                    return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                }
            }
            throw new global::Lua.LuaRuntimeException(_context.Thread, $"{"MultiplyPoint"}: invalid argument #{_lastArgPos}: {_lastArg} ({_lastArg.Type}), expected: {_expectedType.FullName}", 2);
        });
        private static readonly global::Lua.LuaFunction _LuaMatrix4x4_MultiplyPoint3x4 = new global::Lua.LuaFunction("MultiplyPoint3x4", (_context, _) =>
        {
            global::Lua.LuaValue _lastArg = default;
            global::System.Int32 _lastArgPos = default;
            global::System.Type _expectedType = default;
            var _argCount = _context.ArgumentCount;
            var _this = _context.GetArgument<LuaMatrix4x4>(0);
            var _arg0 = _lastArg = _argCount > 1 ? _context.GetArgument(1) : global::Lua.LuaValue.Nil;
            _lastArgPos = 0; _expectedType = typeof(global::Luny.UnityEngine.LuaVector3);
            if (_arg0.TryRead<global::Luny.UnityEngine.LuaVector3>(out var _p0_UnityEngine_Vector3))
            {
                if (_argCount == 2)
                {
                    var point = _p0_UnityEngine_Vector3.Value;
                    var _ret0 = _this.m_Value.MultiplyPoint3x4(point);
                    var _lret0 = global::Luny.UnityEngine.LuaVector3.Bind(_ret0);
                    var _retCount = _context.Return(_lret0);
                    return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                }
            }
            throw new global::Lua.LuaRuntimeException(_context.Thread, $"{"MultiplyPoint3x4"}: invalid argument #{_lastArgPos}: {_lastArg} ({_lastArg.Type}), expected: {_expectedType.FullName}", 2);
        });
        private static readonly global::Lua.LuaFunction _LuaMatrix4x4_MultiplyVector = new global::Lua.LuaFunction("MultiplyVector", (_context, _) =>
        {
            global::Lua.LuaValue _lastArg = default;
            global::System.Int32 _lastArgPos = default;
            global::System.Type _expectedType = default;
            var _argCount = _context.ArgumentCount;
            var _this = _context.GetArgument<LuaMatrix4x4>(0);
            var _arg0 = _lastArg = _argCount > 1 ? _context.GetArgument(1) : global::Lua.LuaValue.Nil;
            _lastArgPos = 0; _expectedType = typeof(global::Luny.UnityEngine.LuaVector3);
            if (_arg0.TryRead<global::Luny.UnityEngine.LuaVector3>(out var _p0_UnityEngine_Vector3))
            {
                if (_argCount == 2)
                {
                    var vector = _p0_UnityEngine_Vector3.Value;
                    var _ret0 = _this.m_Value.MultiplyVector(vector);
                    var _lret0 = global::Luny.UnityEngine.LuaVector3.Bind(_ret0);
                    var _retCount = _context.Return(_lret0);
                    return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                }
            }
            throw new global::Lua.LuaRuntimeException(_context.Thread, $"{"MultiplyVector"}: invalid argument #{_lastArgPos}: {_lastArg} ({_lastArg.Type}), expected: {_expectedType.FullName}", 2);
        });
        private static readonly global::Lua.LuaFunction _LuaMatrix4x4_SetColumn = new global::Lua.LuaFunction("SetColumn", (_context, _) =>
        {
            global::Lua.LuaValue _lastArg = default;
            global::System.Int32 _lastArgPos = default;
            global::System.Type _expectedType = default;
            var _argCount = _context.ArgumentCount;
            var _this = _context.GetArgument<LuaMatrix4x4>(0);
            var _arg0 = _lastArg = _argCount > 1 ? _context.GetArgument(1) : global::Lua.LuaValue.Nil;
            _lastArgPos = 0; _expectedType = typeof(global::System.Int32);
            if (_arg0.TryRead<global::System.Int32>(out var _p0_System_Int32))
            {
                var _arg1 = _lastArg = _argCount > 2 ? _context.GetArgument(2) : global::Lua.LuaValue.Nil;
                _lastArgPos = 1; _expectedType = typeof(global::Luny.UnityEngine.LuaVector4);
                if (_arg1.TryRead<global::Luny.UnityEngine.LuaVector4>(out var _p1_UnityEngine_Vector4))
                {
                    if (_argCount == 3)
                    {
                        var index = _p0_System_Int32;
                        var column = _p1_UnityEngine_Vector4.Value;
                        _this.m_Value.SetColumn(index, column);
                        var _retCount = _context.Return();
                        return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                    }
                }
            }
            throw new global::Lua.LuaRuntimeException(_context.Thread, $"{"SetColumn"}: invalid argument #{_lastArgPos}: {_lastArg} ({_lastArg.Type}), expected: {_expectedType.FullName}", 2);
        });
        private static readonly global::Lua.LuaFunction _LuaMatrix4x4_SetRow = new global::Lua.LuaFunction("SetRow", (_context, _) =>
        {
            global::Lua.LuaValue _lastArg = default;
            global::System.Int32 _lastArgPos = default;
            global::System.Type _expectedType = default;
            var _argCount = _context.ArgumentCount;
            var _this = _context.GetArgument<LuaMatrix4x4>(0);
            var _arg0 = _lastArg = _argCount > 1 ? _context.GetArgument(1) : global::Lua.LuaValue.Nil;
            _lastArgPos = 0; _expectedType = typeof(global::System.Int32);
            if (_arg0.TryRead<global::System.Int32>(out var _p0_System_Int32))
            {
                var _arg1 = _lastArg = _argCount > 2 ? _context.GetArgument(2) : global::Lua.LuaValue.Nil;
                _lastArgPos = 1; _expectedType = typeof(global::Luny.UnityEngine.LuaVector4);
                if (_arg1.TryRead<global::Luny.UnityEngine.LuaVector4>(out var _p1_UnityEngine_Vector4))
                {
                    if (_argCount == 3)
                    {
                        var index = _p0_System_Int32;
                        var row = _p1_UnityEngine_Vector4.Value;
                        _this.m_Value.SetRow(index, row);
                        var _retCount = _context.Return();
                        return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                    }
                }
            }
            throw new global::Lua.LuaRuntimeException(_context.Thread, $"{"SetRow"}: invalid argument #{_lastArgPos}: {_lastArg} ({_lastArg.Type}), expected: {_expectedType.FullName}", 2);
        });
        private static readonly global::Lua.LuaFunction _LuaMatrix4x4_SetTRS = new global::Lua.LuaFunction("SetTRS", (_context, _) =>
        {
            global::Lua.LuaValue _lastArg = default;
            global::System.Int32 _lastArgPos = default;
            global::System.Type _expectedType = default;
            var _argCount = _context.ArgumentCount;
            var _this = _context.GetArgument<LuaMatrix4x4>(0);
            var _arg0 = _lastArg = _argCount > 1 ? _context.GetArgument(1) : global::Lua.LuaValue.Nil;
            _lastArgPos = 0; _expectedType = typeof(global::Luny.UnityEngine.LuaVector3);
            if (_arg0.TryRead<global::Luny.UnityEngine.LuaVector3>(out var _p0_UnityEngine_Vector3))
            {
                var _arg1 = _lastArg = _argCount > 2 ? _context.GetArgument(2) : global::Lua.LuaValue.Nil;
                _lastArgPos = 1; _expectedType = typeof(global::Luny.UnityEngine.LuaQuaternion);
                if (_arg1.TryRead<global::Luny.UnityEngine.LuaQuaternion>(out var _p1_UnityEngine_Quaternion))
                {
                    var _arg2 = _lastArg = _argCount > 3 ? _context.GetArgument(3) : global::Lua.LuaValue.Nil;
                    _lastArgPos = 2; _expectedType = typeof(global::Luny.UnityEngine.LuaVector3);
                    if (_arg2.TryRead<global::Luny.UnityEngine.LuaVector3>(out var _p2_UnityEngine_Vector3))
                    {
                        if (_argCount == 4)
                        {
                            var pos = _p0_UnityEngine_Vector3.Value;
                            var q = _p1_UnityEngine_Quaternion.Value;
                            var s = _p2_UnityEngine_Vector3.Value;
                            _this.m_Value.SetTRS(pos, q, s);
                            var _retCount = _context.Return();
                            return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                        }
                    }
                }
            }
            throw new global::Lua.LuaRuntimeException(_context.Thread, $"{"SetTRS"}: invalid argument #{_lastArgPos}: {_lastArg} ({_lastArg.Type}), expected: {_expectedType.FullName}", 2);
        });
        private static readonly global::Lua.LuaFunction _LuaMatrix4x4_ToString = new global::Lua.LuaFunction("ToString", (_context, _) =>
        {
            global::Lua.LuaValue _lastArg = default;
            global::System.Int32 _lastArgPos = default;
            global::System.Type _expectedType = default;
            var _argCount = _context.ArgumentCount;
            var _this = _context.GetArgument<LuaMatrix4x4>(0);
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
        private static readonly global::Lua.LuaFunction _LuaMatrix4x4_TransformPlane = new global::Lua.LuaFunction("TransformPlane", (_context, _) =>
        {
            global::Lua.LuaValue _lastArg = default;
            global::System.Int32 _lastArgPos = default;
            global::System.Type _expectedType = default;
            var _argCount = _context.ArgumentCount;
            var _this = _context.GetArgument<LuaMatrix4x4>(0);
            var _arg0 = _lastArg = _argCount > 1 ? _context.GetArgument(1) : global::Lua.LuaValue.Nil;
            _lastArgPos = 0; _expectedType = typeof(global::Luny.UnityEngine.LuaPlane);
            if (_arg0.TryRead<global::Luny.UnityEngine.LuaPlane>(out var _p0_UnityEngine_Plane))
            {
                if (_argCount == 2)
                {
                    var plane = _p0_UnityEngine_Plane.Value;
                    var _ret0 = _this.m_Value.TransformPlane(plane);
                    var _lret0 = global::Luny.UnityEngine.LuaPlane.Bind(_ret0);
                    var _retCount = _context.Return(_lret0);
                    return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                }
            }
            throw new global::Lua.LuaRuntimeException(_context.Thread, $"{"TransformPlane"}: invalid argument #{_lastArgPos}: {_lastArg} ({_lastArg.Type}), expected: {_expectedType.FullName}", 2);
        });
        private static readonly global::Lua.LuaFunction _LuaMatrix4x4_ValidTRS = new global::Lua.LuaFunction("ValidTRS", (_context, _) =>
        {
            global::Lua.LuaValue _lastArg = default;
            global::System.Int32 _lastArgPos = default;
            global::System.Type _expectedType = default;
            var _argCount = _context.ArgumentCount;
            var _this = _context.GetArgument<LuaMatrix4x4>(0);
            if (_argCount == 1)
            {
                var _ret0 = _this.m_Value.ValidTRS();
                var _lret0 = new global::Lua.LuaValue(_ret0);
                var _retCount = _context.Return(_lret0);
                return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
            }
            throw new global::Lua.LuaRuntimeException(_context.Thread, $"{"ValidTRS"}: invalid argument #{_lastArgPos}: {_lastArg} ({_lastArg.Type}), expected: {_expectedType.FullName}", 2);
        });
        private static readonly global::Lua.LuaFunction __index = new(global::Lua.Runtime.Metamethods.Index, (_context, _) =>
        {
            var _this = _context.GetArgument<LuaMatrix4x4>(0);
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
            var _this = _context.GetArgument<LuaMatrix4x4>(0);
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
                case "Equals": _value = _LuaMatrix4x4_Equals; return true;
                case "GetColumn": _value = _LuaMatrix4x4_GetColumn; return true;
                case "GetHashCode": _value = _LuaMatrix4x4_GetHashCode; return true;
                case "GetPosition": _value = _LuaMatrix4x4_GetPosition; return true;
                case "GetRow": _value = _LuaMatrix4x4_GetRow; return true;
                case "MultiplyPoint": _value = _LuaMatrix4x4_MultiplyPoint; return true;
                case "MultiplyPoint3x4": _value = _LuaMatrix4x4_MultiplyPoint3x4; return true;
                case "MultiplyVector": _value = _LuaMatrix4x4_MultiplyVector; return true;
                case "SetColumn": _value = _LuaMatrix4x4_SetColumn; return true;
                case "SetRow": _value = _LuaMatrix4x4_SetRow; return true;
                case "SetTRS": _value = _LuaMatrix4x4_SetTRS; return true;
                case "ToString": _value = _LuaMatrix4x4_ToString; return true;
                case "TransformPlane": _value = _LuaMatrix4x4_TransformPlane; return true;
                case "ValidTRS": _value = _LuaMatrix4x4_ValidTRS; return true;
                case "decomposeProjection": _value = global::Luny.UnityEngine.LuaFrustumPlanes.Bind(m_Value.decomposeProjection); return true;
                case "determinant": _value = new global::Lua.LuaValue(m_Value.determinant); return true;
                case "inverse": _value = global::Luny.UnityEngine.LuaMatrix4x4.Bind(m_Value.inverse); return true;
                case "isIdentity": _value = new global::Lua.LuaValue(m_Value.isIdentity); return true;
                case "lossyScale": _value = global::Luny.UnityEngine.LuaVector3.Bind(m_Value.lossyScale); return true;
                case "rotation": _value = global::Luny.UnityEngine.LuaQuaternion.Bind(m_Value.rotation); return true;
                case "transpose": _value = global::Luny.UnityEngine.LuaMatrix4x4.Bind(m_Value.transpose); return true;
                case "m00": _value = new global::Lua.LuaValue(m_Value.m00); return true;
                case "m01": _value = new global::Lua.LuaValue(m_Value.m01); return true;
                case "m02": _value = new global::Lua.LuaValue(m_Value.m02); return true;
                case "m03": _value = new global::Lua.LuaValue(m_Value.m03); return true;
                case "m10": _value = new global::Lua.LuaValue(m_Value.m10); return true;
                case "m11": _value = new global::Lua.LuaValue(m_Value.m11); return true;
                case "m12": _value = new global::Lua.LuaValue(m_Value.m12); return true;
                case "m13": _value = new global::Lua.LuaValue(m_Value.m13); return true;
                case "m20": _value = new global::Lua.LuaValue(m_Value.m20); return true;
                case "m21": _value = new global::Lua.LuaValue(m_Value.m21); return true;
                case "m22": _value = new global::Lua.LuaValue(m_Value.m22); return true;
                case "m23": _value = new global::Lua.LuaValue(m_Value.m23); return true;
                case "m30": _value = new global::Lua.LuaValue(m_Value.m30); return true;
                case "m31": _value = new global::Lua.LuaValue(m_Value.m31); return true;
                case "m32": _value = new global::Lua.LuaValue(m_Value.m32); return true;
                case "m33": _value = new global::Lua.LuaValue(m_Value.m33); return true;
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
                case "m00": { var _temp = m_Value; _temp.m00 = _value.Read<global::System.Single>(); m_Value = _temp; } return true;
                case "m01": { var _temp = m_Value; _temp.m01 = _value.Read<global::System.Single>(); m_Value = _temp; } return true;
                case "m02": { var _temp = m_Value; _temp.m02 = _value.Read<global::System.Single>(); m_Value = _temp; } return true;
                case "m03": { var _temp = m_Value; _temp.m03 = _value.Read<global::System.Single>(); m_Value = _temp; } return true;
                case "m10": { var _temp = m_Value; _temp.m10 = _value.Read<global::System.Single>(); m_Value = _temp; } return true;
                case "m11": { var _temp = m_Value; _temp.m11 = _value.Read<global::System.Single>(); m_Value = _temp; } return true;
                case "m12": { var _temp = m_Value; _temp.m12 = _value.Read<global::System.Single>(); m_Value = _temp; } return true;
                case "m13": { var _temp = m_Value; _temp.m13 = _value.Read<global::System.Single>(); m_Value = _temp; } return true;
                case "m20": { var _temp = m_Value; _temp.m20 = _value.Read<global::System.Single>(); m_Value = _temp; } return true;
                case "m21": { var _temp = m_Value; _temp.m21 = _value.Read<global::System.Single>(); m_Value = _temp; } return true;
                case "m22": { var _temp = m_Value; _temp.m22 = _value.Read<global::System.Single>(); m_Value = _temp; } return true;
                case "m23": { var _temp = m_Value; _temp.m23 = _value.Read<global::System.Single>(); m_Value = _temp; } return true;
                case "m30": { var _temp = m_Value; _temp.m30 = _value.Read<global::System.Single>(); m_Value = _temp; } return true;
                case "m31": { var _temp = m_Value; _temp.m31 = _value.Read<global::System.Single>(); m_Value = _temp; } return true;
                case "m32": { var _temp = m_Value; _temp.m32 = _value.Read<global::System.Single>(); m_Value = _temp; } return true;
                case "m33": { var _temp = m_Value; _temp.m33 = _value.Read<global::System.Single>(); m_Value = _temp; } return true;
                default: return false;
            }
        }
    }
    public sealed class LuaMatrix4x4Type : global::Luny.ILuaStatic
    {
        public static global::Lua.LuaValue Bind() => new LuaMatrix4x4Type();
        private LuaMatrix4x4Type() {}
        public static implicit operator global::Lua.LuaValue(LuaMatrix4x4Type value) => new(value);
        public global::System.Type BindType => typeof(global::UnityEngine.Matrix4x4);
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

        private static readonly global::Lua.LuaFunction _LuaMatrix4x4_new = new global::Lua.LuaFunction(".ctor", (_context, _) =>
        {
            global::Lua.LuaValue _lastArg = default;
            global::System.Int32 _lastArgPos = default;
            global::System.Type _expectedType = default;
            var _argCount = _context.ArgumentCount;
            if (_argCount == 0)
            {
                var _ret0 = new global::UnityEngine.Matrix4x4();
                var _lret0 = global::Luny.UnityEngine.LuaMatrix4x4.Bind(_ret0);
                var _retCount = _context.Return(_lret0);
                return new global::System.Threading.Tasks.ValueTask<global::System.Int32>(_retCount);
            }
            var _arg0 = _lastArg = _argCount > 0 ? _context.GetArgument(0) : global::Lua.LuaValue.Nil;
            _lastArgPos = 0; _expectedType = typeof(global::Luny.UnityEngine.LuaVector4);
            if (_arg0.TryRead<global::Luny.UnityEngine.LuaVector4>(out var _p0_UnityEngine_Vector4))
            {
                var _arg1 = _lastArg = _argCount > 1 ? _context.GetArgument(1) : global::Lua.LuaValue.Nil;
                _lastArgPos = 1; _expectedType = typeof(global::Luny.UnityEngine.LuaVector4);
                if (_arg1.TryRead<global::Luny.UnityEngine.LuaVector4>(out var _p1_UnityEngine_Vector4))
                {
                    var _arg2 = _lastArg = _argCount > 2 ? _context.GetArgument(2) : global::Lua.LuaValue.Nil;
                    _lastArgPos = 2; _expectedType = typeof(global::Luny.UnityEngine.LuaVector4);
                    if (_arg2.TryRead<global::Luny.UnityEngine.LuaVector4>(out var _p2_UnityEngine_Vector4))
                    {
                        var _arg3 = _lastArg = _argCount > 3 ? _context.GetArgument(3) : global::Lua.LuaValue.Nil;
                        _lastArgPos = 3; _expectedType = typeof(global::Luny.UnityEngine.LuaVector4);
                        if (_arg3.TryRead<global::Luny.UnityEngine.LuaVector4>(out var _p3_UnityEngine_Vector4))
                        {
                            if (_argCount == 4)
                            {
                                var column0 = _p0_UnityEngine_Vector4.Value;
                                var column1 = _p1_UnityEngine_Vector4.Value;
                                var column2 = _p2_UnityEngine_Vector4.Value;
                                var column3 = _p3_UnityEngine_Vector4.Value;
                                var _ret0 = new global::UnityEngine.Matrix4x4(column0, column1, column2, column3);
                                var _lret0 = global::Luny.UnityEngine.LuaMatrix4x4.Bind(_ret0);
                                var _retCount = _context.Return(_lret0);
                                return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                            }
                        }
                    }
                }
            }
            throw new global::Lua.LuaRuntimeException(_context.Thread, $"{".ctor"}: invalid argument #{_lastArgPos}: {_lastArg} ({_lastArg.Type}), expected: {_expectedType.FullName}", 2);
        });
        private static readonly global::Lua.LuaFunction _LuaMatrix4x4_Determinant = new global::Lua.LuaFunction("Determinant", (_context, _) =>
        {
            global::Lua.LuaValue _lastArg = default;
            global::System.Int32 _lastArgPos = default;
            global::System.Type _expectedType = default;
            var _argCount = _context.ArgumentCount;
            var _arg0 = _lastArg = _argCount > 0 ? _context.GetArgument(0) : global::Lua.LuaValue.Nil;
            _lastArgPos = 0; _expectedType = typeof(global::Luny.UnityEngine.LuaMatrix4x4);
            if (_arg0.TryRead<global::Luny.UnityEngine.LuaMatrix4x4>(out var _p0_UnityEngine_Matrix4x4))
            {
                if (_argCount == 1)
                {
                    var m = _p0_UnityEngine_Matrix4x4.Value;
                    var _ret0 = global::UnityEngine.Matrix4x4.Determinant(m);
                    var _lret0 = new global::Lua.LuaValue(_ret0);
                    var _retCount = _context.Return(_lret0);
                    return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                }
            }
            throw new global::Lua.LuaRuntimeException(_context.Thread, $"{"Determinant"}: invalid argument #{_lastArgPos}: {_lastArg} ({_lastArg.Type}), expected: {_expectedType.FullName}", 2);
        });
        private static readonly global::Lua.LuaFunction _LuaMatrix4x4_Frustum = new global::Lua.LuaFunction("Frustum", (_context, _) =>
        {
            global::Lua.LuaValue _lastArg = default;
            global::System.Int32 _lastArgPos = default;
            global::System.Type _expectedType = default;
            var _argCount = _context.ArgumentCount;
            var _arg0 = _lastArg = _argCount > 0 ? _context.GetArgument(0) : global::Lua.LuaValue.Nil;
            _lastArgPos = 0; _expectedType = typeof(global::Luny.UnityEngine.LuaFrustumPlanes);
            if (_arg0.TryRead<global::Luny.UnityEngine.LuaFrustumPlanes>(out var _p0_UnityEngine_FrustumPlanes))
            {
                if (_argCount == 1)
                {
                    var fp = _p0_UnityEngine_FrustumPlanes.Value;
                    var _ret0 = global::UnityEngine.Matrix4x4.Frustum(fp);
                    var _lret0 = global::Luny.UnityEngine.LuaMatrix4x4.Bind(_ret0);
                    var _retCount = _context.Return(_lret0);
                    return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                }
            }
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
                        var _arg3 = _lastArg = _argCount > 3 ? _context.GetArgument(3) : global::Lua.LuaValue.Nil;
                        _lastArgPos = 3; _expectedType = typeof(global::System.Single);
                        if (_arg3.TryRead<global::System.Single>(out var _p3_System_Single))
                        {
                            var _arg4 = _lastArg = _argCount > 4 ? _context.GetArgument(4) : global::Lua.LuaValue.Nil;
                            _lastArgPos = 4; _expectedType = typeof(global::System.Single);
                            if (_arg4.TryRead<global::System.Single>(out var _p4_System_Single))
                            {
                                var _arg5 = _lastArg = _argCount > 5 ? _context.GetArgument(5) : global::Lua.LuaValue.Nil;
                                _lastArgPos = 5; _expectedType = typeof(global::System.Single);
                                if (_arg5.TryRead<global::System.Single>(out var _p5_System_Single))
                                {
                                    if (_argCount == 6)
                                    {
                                        var left = _p0_System_Single;
                                        var right = _p1_System_Single;
                                        var bottom = _p2_System_Single;
                                        var top = _p3_System_Single;
                                        var zNear = _p4_System_Single;
                                        var zFar = _p5_System_Single;
                                        var _ret0 = global::UnityEngine.Matrix4x4.Frustum(left, right, bottom, top, zNear, zFar);
                                        var _lret0 = global::Luny.UnityEngine.LuaMatrix4x4.Bind(_ret0);
                                        var _retCount = _context.Return(_lret0);
                                        return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                                    }
                                }
                            }
                        }
                    }
                }
            }
            throw new global::Lua.LuaRuntimeException(_context.Thread, $"{"Frustum"}: invalid argument #{_lastArgPos}: {_lastArg} ({_lastArg.Type}), expected: {_expectedType.FullName}", 2);
        });
        private static readonly global::Lua.LuaFunction _LuaMatrix4x4_Inverse = new global::Lua.LuaFunction("Inverse", (_context, _) =>
        {
            global::Lua.LuaValue _lastArg = default;
            global::System.Int32 _lastArgPos = default;
            global::System.Type _expectedType = default;
            var _argCount = _context.ArgumentCount;
            var _arg0 = _lastArg = _argCount > 0 ? _context.GetArgument(0) : global::Lua.LuaValue.Nil;
            _lastArgPos = 0; _expectedType = typeof(global::Luny.UnityEngine.LuaMatrix4x4);
            if (_arg0.TryRead<global::Luny.UnityEngine.LuaMatrix4x4>(out var _p0_UnityEngine_Matrix4x4))
            {
                if (_argCount == 1)
                {
                    var m = _p0_UnityEngine_Matrix4x4.Value;
                    var _ret0 = global::UnityEngine.Matrix4x4.Inverse(m);
                    var _lret0 = global::Luny.UnityEngine.LuaMatrix4x4.Bind(_ret0);
                    var _retCount = _context.Return(_lret0);
                    return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                }
            }
            throw new global::Lua.LuaRuntimeException(_context.Thread, $"{"Inverse"}: invalid argument #{_lastArgPos}: {_lastArg} ({_lastArg.Type}), expected: {_expectedType.FullName}", 2);
        });
        private static readonly global::Lua.LuaFunction _LuaMatrix4x4_LookAt = new global::Lua.LuaFunction("LookAt", (_context, _) =>
        {
            global::Lua.LuaValue _lastArg = default;
            global::System.Int32 _lastArgPos = default;
            global::System.Type _expectedType = default;
            var _argCount = _context.ArgumentCount;
            var _arg0 = _lastArg = _argCount > 0 ? _context.GetArgument(0) : global::Lua.LuaValue.Nil;
            _lastArgPos = 0; _expectedType = typeof(global::Luny.UnityEngine.LuaVector3);
            if (_arg0.TryRead<global::Luny.UnityEngine.LuaVector3>(out var _p0_UnityEngine_Vector3))
            {
                var _arg1 = _lastArg = _argCount > 1 ? _context.GetArgument(1) : global::Lua.LuaValue.Nil;
                _lastArgPos = 1; _expectedType = typeof(global::Luny.UnityEngine.LuaVector3);
                if (_arg1.TryRead<global::Luny.UnityEngine.LuaVector3>(out var _p1_UnityEngine_Vector3))
                {
                    var _arg2 = _lastArg = _argCount > 2 ? _context.GetArgument(2) : global::Lua.LuaValue.Nil;
                    _lastArgPos = 2; _expectedType = typeof(global::Luny.UnityEngine.LuaVector3);
                    if (_arg2.TryRead<global::Luny.UnityEngine.LuaVector3>(out var _p2_UnityEngine_Vector3))
                    {
                        if (_argCount == 3)
                        {
                            var from = _p0_UnityEngine_Vector3.Value;
                            var to = _p1_UnityEngine_Vector3.Value;
                            var up = _p2_UnityEngine_Vector3.Value;
                            var _ret0 = global::UnityEngine.Matrix4x4.LookAt(from, to, up);
                            var _lret0 = global::Luny.UnityEngine.LuaMatrix4x4.Bind(_ret0);
                            var _retCount = _context.Return(_lret0);
                            return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                        }
                    }
                }
            }
            throw new global::Lua.LuaRuntimeException(_context.Thread, $"{"LookAt"}: invalid argument #{_lastArgPos}: {_lastArg} ({_lastArg.Type}), expected: {_expectedType.FullName}", 2);
        });
        private static readonly global::Lua.LuaFunction _LuaMatrix4x4_Ortho = new global::Lua.LuaFunction("Ortho", (_context, _) =>
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
                        var _arg3 = _lastArg = _argCount > 3 ? _context.GetArgument(3) : global::Lua.LuaValue.Nil;
                        _lastArgPos = 3; _expectedType = typeof(global::System.Single);
                        if (_arg3.TryRead<global::System.Single>(out var _p3_System_Single))
                        {
                            var _arg4 = _lastArg = _argCount > 4 ? _context.GetArgument(4) : global::Lua.LuaValue.Nil;
                            _lastArgPos = 4; _expectedType = typeof(global::System.Single);
                            if (_arg4.TryRead<global::System.Single>(out var _p4_System_Single))
                            {
                                var _arg5 = _lastArg = _argCount > 5 ? _context.GetArgument(5) : global::Lua.LuaValue.Nil;
                                _lastArgPos = 5; _expectedType = typeof(global::System.Single);
                                if (_arg5.TryRead<global::System.Single>(out var _p5_System_Single))
                                {
                                    if (_argCount == 6)
                                    {
                                        var left = _p0_System_Single;
                                        var right = _p1_System_Single;
                                        var bottom = _p2_System_Single;
                                        var top = _p3_System_Single;
                                        var zNear = _p4_System_Single;
                                        var zFar = _p5_System_Single;
                                        var _ret0 = global::UnityEngine.Matrix4x4.Ortho(left, right, bottom, top, zNear, zFar);
                                        var _lret0 = global::Luny.UnityEngine.LuaMatrix4x4.Bind(_ret0);
                                        var _retCount = _context.Return(_lret0);
                                        return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                                    }
                                }
                            }
                        }
                    }
                }
            }
            throw new global::Lua.LuaRuntimeException(_context.Thread, $"{"Ortho"}: invalid argument #{_lastArgPos}: {_lastArg} ({_lastArg.Type}), expected: {_expectedType.FullName}", 2);
        });
        private static readonly global::Lua.LuaFunction _LuaMatrix4x4_Perspective = new global::Lua.LuaFunction("Perspective", (_context, _) =>
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
                        var _arg3 = _lastArg = _argCount > 3 ? _context.GetArgument(3) : global::Lua.LuaValue.Nil;
                        _lastArgPos = 3; _expectedType = typeof(global::System.Single);
                        if (_arg3.TryRead<global::System.Single>(out var _p3_System_Single))
                        {
                            if (_argCount == 4)
                            {
                                var fov = _p0_System_Single;
                                var aspect = _p1_System_Single;
                                var zNear = _p2_System_Single;
                                var zFar = _p3_System_Single;
                                var _ret0 = global::UnityEngine.Matrix4x4.Perspective(fov, aspect, zNear, zFar);
                                var _lret0 = global::Luny.UnityEngine.LuaMatrix4x4.Bind(_ret0);
                                var _retCount = _context.Return(_lret0);
                                return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                            }
                        }
                    }
                }
            }
            throw new global::Lua.LuaRuntimeException(_context.Thread, $"{"Perspective"}: invalid argument #{_lastArgPos}: {_lastArg} ({_lastArg.Type}), expected: {_expectedType.FullName}", 2);
        });
        private static readonly global::Lua.LuaFunction _LuaMatrix4x4_Rotate = new global::Lua.LuaFunction("Rotate", (_context, _) =>
        {
            global::Lua.LuaValue _lastArg = default;
            global::System.Int32 _lastArgPos = default;
            global::System.Type _expectedType = default;
            var _argCount = _context.ArgumentCount;
            var _arg0 = _lastArg = _argCount > 0 ? _context.GetArgument(0) : global::Lua.LuaValue.Nil;
            _lastArgPos = 0; _expectedType = typeof(global::Luny.UnityEngine.LuaQuaternion);
            if (_arg0.TryRead<global::Luny.UnityEngine.LuaQuaternion>(out var _p0_UnityEngine_Quaternion))
            {
                if (_argCount == 1)
                {
                    var q = _p0_UnityEngine_Quaternion.Value;
                    var _ret0 = global::UnityEngine.Matrix4x4.Rotate(q);
                    var _lret0 = global::Luny.UnityEngine.LuaMatrix4x4.Bind(_ret0);
                    var _retCount = _context.Return(_lret0);
                    return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                }
            }
            throw new global::Lua.LuaRuntimeException(_context.Thread, $"{"Rotate"}: invalid argument #{_lastArgPos}: {_lastArg} ({_lastArg.Type}), expected: {_expectedType.FullName}", 2);
        });
        private static readonly global::Lua.LuaFunction _LuaMatrix4x4_Scale = new global::Lua.LuaFunction("Scale", (_context, _) =>
        {
            global::Lua.LuaValue _lastArg = default;
            global::System.Int32 _lastArgPos = default;
            global::System.Type _expectedType = default;
            var _argCount = _context.ArgumentCount;
            var _arg0 = _lastArg = _argCount > 0 ? _context.GetArgument(0) : global::Lua.LuaValue.Nil;
            _lastArgPos = 0; _expectedType = typeof(global::Luny.UnityEngine.LuaVector3);
            if (_arg0.TryRead<global::Luny.UnityEngine.LuaVector3>(out var _p0_UnityEngine_Vector3))
            {
                if (_argCount == 1)
                {
                    var vector = _p0_UnityEngine_Vector3.Value;
                    var _ret0 = global::UnityEngine.Matrix4x4.Scale(vector);
                    var _lret0 = global::Luny.UnityEngine.LuaMatrix4x4.Bind(_ret0);
                    var _retCount = _context.Return(_lret0);
                    return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                }
            }
            throw new global::Lua.LuaRuntimeException(_context.Thread, $"{"Scale"}: invalid argument #{_lastArgPos}: {_lastArg} ({_lastArg.Type}), expected: {_expectedType.FullName}", 2);
        });
        private static readonly global::Lua.LuaFunction _LuaMatrix4x4_Translate = new global::Lua.LuaFunction("Translate", (_context, _) =>
        {
            global::Lua.LuaValue _lastArg = default;
            global::System.Int32 _lastArgPos = default;
            global::System.Type _expectedType = default;
            var _argCount = _context.ArgumentCount;
            var _arg0 = _lastArg = _argCount > 0 ? _context.GetArgument(0) : global::Lua.LuaValue.Nil;
            _lastArgPos = 0; _expectedType = typeof(global::Luny.UnityEngine.LuaVector3);
            if (_arg0.TryRead<global::Luny.UnityEngine.LuaVector3>(out var _p0_UnityEngine_Vector3))
            {
                if (_argCount == 1)
                {
                    var vector = _p0_UnityEngine_Vector3.Value;
                    var _ret0 = global::UnityEngine.Matrix4x4.Translate(vector);
                    var _lret0 = global::Luny.UnityEngine.LuaMatrix4x4.Bind(_ret0);
                    var _retCount = _context.Return(_lret0);
                    return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                }
            }
            throw new global::Lua.LuaRuntimeException(_context.Thread, $"{"Translate"}: invalid argument #{_lastArgPos}: {_lastArg} ({_lastArg.Type}), expected: {_expectedType.FullName}", 2);
        });
        private static readonly global::Lua.LuaFunction _LuaMatrix4x4_Transpose = new global::Lua.LuaFunction("Transpose", (_context, _) =>
        {
            global::Lua.LuaValue _lastArg = default;
            global::System.Int32 _lastArgPos = default;
            global::System.Type _expectedType = default;
            var _argCount = _context.ArgumentCount;
            var _arg0 = _lastArg = _argCount > 0 ? _context.GetArgument(0) : global::Lua.LuaValue.Nil;
            _lastArgPos = 0; _expectedType = typeof(global::Luny.UnityEngine.LuaMatrix4x4);
            if (_arg0.TryRead<global::Luny.UnityEngine.LuaMatrix4x4>(out var _p0_UnityEngine_Matrix4x4))
            {
                if (_argCount == 1)
                {
                    var m = _p0_UnityEngine_Matrix4x4.Value;
                    var _ret0 = global::UnityEngine.Matrix4x4.Transpose(m);
                    var _lret0 = global::Luny.UnityEngine.LuaMatrix4x4.Bind(_ret0);
                    var _retCount = _context.Return(_lret0);
                    return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                }
            }
            throw new global::Lua.LuaRuntimeException(_context.Thread, $"{"Transpose"}: invalid argument #{_lastArgPos}: {_lastArg} ({_lastArg.Type}), expected: {_expectedType.FullName}", 2);
        });
        private static readonly global::Lua.LuaFunction _LuaMatrix4x4_TRS = new global::Lua.LuaFunction("TRS", (_context, _) =>
        {
            global::Lua.LuaValue _lastArg = default;
            global::System.Int32 _lastArgPos = default;
            global::System.Type _expectedType = default;
            var _argCount = _context.ArgumentCount;
            var _arg0 = _lastArg = _argCount > 0 ? _context.GetArgument(0) : global::Lua.LuaValue.Nil;
            _lastArgPos = 0; _expectedType = typeof(global::Luny.UnityEngine.LuaVector3);
            if (_arg0.TryRead<global::Luny.UnityEngine.LuaVector3>(out var _p0_UnityEngine_Vector3))
            {
                var _arg1 = _lastArg = _argCount > 1 ? _context.GetArgument(1) : global::Lua.LuaValue.Nil;
                _lastArgPos = 1; _expectedType = typeof(global::Luny.UnityEngine.LuaQuaternion);
                if (_arg1.TryRead<global::Luny.UnityEngine.LuaQuaternion>(out var _p1_UnityEngine_Quaternion))
                {
                    var _arg2 = _lastArg = _argCount > 2 ? _context.GetArgument(2) : global::Lua.LuaValue.Nil;
                    _lastArgPos = 2; _expectedType = typeof(global::Luny.UnityEngine.LuaVector3);
                    if (_arg2.TryRead<global::Luny.UnityEngine.LuaVector3>(out var _p2_UnityEngine_Vector3))
                    {
                        if (_argCount == 3)
                        {
                            var pos = _p0_UnityEngine_Vector3.Value;
                            var q = _p1_UnityEngine_Quaternion.Value;
                            var s = _p2_UnityEngine_Vector3.Value;
                            var _ret0 = global::UnityEngine.Matrix4x4.TRS(pos, q, s);
                            var _lret0 = global::Luny.UnityEngine.LuaMatrix4x4.Bind(_ret0);
                            var _retCount = _context.Return(_lret0);
                            return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                        }
                    }
                }
            }
            throw new global::Lua.LuaRuntimeException(_context.Thread, $"{"TRS"}: invalid argument #{_lastArgPos}: {_lastArg} ({_lastArg.Type}), expected: {_expectedType.FullName}", 2);
        });
        private static readonly global::Lua.LuaFunction __index = new(global::Lua.Runtime.Metamethods.Index, (_context, _) =>
        {
            var _this = _context.GetArgument<LuaMatrix4x4Type>(0);
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
            var _this = _context.GetArgument<LuaMatrix4x4Type>(0);
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
                case "new": _value = _LuaMatrix4x4_new; return true;
                case "Determinant": _value = _LuaMatrix4x4_Determinant; return true;
                case "Frustum": _value = _LuaMatrix4x4_Frustum; return true;
                case "Inverse": _value = _LuaMatrix4x4_Inverse; return true;
                case "LookAt": _value = _LuaMatrix4x4_LookAt; return true;
                case "Ortho": _value = _LuaMatrix4x4_Ortho; return true;
                case "Perspective": _value = _LuaMatrix4x4_Perspective; return true;
                case "Rotate": _value = _LuaMatrix4x4_Rotate; return true;
                case "Scale": _value = _LuaMatrix4x4_Scale; return true;
                case "Translate": _value = _LuaMatrix4x4_Translate; return true;
                case "Transpose": _value = _LuaMatrix4x4_Transpose; return true;
                case "TRS": _value = _LuaMatrix4x4_TRS; return true;
                case "identity": _value = global::Luny.UnityEngine.LuaMatrix4x4.Bind(global::UnityEngine.Matrix4x4.identity); return true;
                case "zero": _value = global::Luny.UnityEngine.LuaMatrix4x4.Bind(global::UnityEngine.Matrix4x4.zero); return true;
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
