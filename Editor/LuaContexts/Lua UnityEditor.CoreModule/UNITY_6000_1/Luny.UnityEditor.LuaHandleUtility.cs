
// --------------------------------------------------------------
// GENERATED FILE ----> DO NOT EDIT <---- CHANGES WILL BE LOST !!
// --------------------------------------------------------------

#if UNITY_6000_1_OR_NEWER && !(UNITY_6000_2_OR_NEWER)
#pragma warning disable 0109, 0162, 0168, 0219
using Luny;

namespace Luny.UnityEditor
{
    public sealed class LuaHandleUtility : global::Luny.ILuaObject<global::UnityEditor.HandleUtility>
    {
        public new static global::Lua.LuaValue Bind(global::UnityEditor.HandleUtility instance) => new LuaHandleUtility(instance);
        public new static global::Lua.LuaValue Bind(global::System.Object instance) => Bind((global::UnityEditor.HandleUtility)instance);
        public new static global::Lua.LuaValue Bind(global::System.Collections.Generic.IList<global::UnityEditor.HandleUtility> instances) =>
            new global::Luny.LuaList<global::UnityEditor.HandleUtility>(instances);
        public new static global::Lua.LuaValue Bind(global::System.Collections.Generic.IList<global::System.Object> instances) =>
            new global::Luny.LuaList<global::UnityEditor.HandleUtility>(instances);
        private LuaHandleUtility(global::UnityEditor.HandleUtility instance) => m_Instance = instance;
        public static implicit operator global::Lua.LuaValue(LuaHandleUtility value) => new(value);
        private global::UnityEditor.HandleUtility m_Instance;
        public global::UnityEditor.HandleUtility Instance => m_Instance;
        public new global::System.Type BindType => typeof(global::UnityEditor.HandleUtility);
        private static global::Lua.LuaTable s_Metatable;
        public global::Lua.LuaTable Metatable
        {
            get => s_Metatable ??= global::Luny.LuaMetatable.Create(__index, __newindex);
            set => throw new global::System.NotSupportedException("LuaObject metatables cannot be modified");
        }
        global::System.Span<global::Lua.LuaValue> global::Lua.ILuaUserData.UserValues => default;
        public override global::System.String ToString() => m_Instance != null ? Instance.ToString() : "{GetType().Name}(null)";
#if UNITY_EDITOR
        [global::UnityEngine.RuntimeInitializeOnLoadMethod(global::UnityEngine.RuntimeInitializeLoadType.SubsystemRegistration)]
        private static void ResetStaticFields() => s_Metatable = null;
#endif

        private static readonly global::Lua.LuaFunction __index = new(global::Lua.Runtime.Metamethods.Index, (_context, _) =>
        {
            var _this = _context.GetArgument<LuaHandleUtility>(0);
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
            var _this = _context.GetArgument<LuaHandleUtility>(0);
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
    public sealed class LuaHandleUtilityType : global::Luny.ILuaStatic
    {
        public static global::Lua.LuaValue Bind() => new LuaHandleUtilityType();
        private LuaHandleUtilityType() {}
        public static implicit operator global::Lua.LuaValue(LuaHandleUtilityType value) => new(value);
        public global::System.Type BindType => typeof(global::UnityEditor.HandleUtility);
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

        private static readonly global::Lua.LuaFunction _LuaHandleUtility_new = new global::Lua.LuaFunction(".ctor", (_context, _) =>
        {
            global::Lua.LuaValue _lastArg = default;
            global::System.Int32 _lastArgPos = default;
            global::System.Type _expectedType = default;
            var _argCount = _context.ArgumentCount;
            if (_argCount == 0)
            {
                var _ret0 = new global::UnityEditor.HandleUtility();
                var _factory = _context.GetObjectFactory();
                var _lret0 = _factory.Bind(_ret0);
                var _retCount = _context.Return(_lret0);
                return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
            }
            throw new global::Lua.LuaRuntimeException(_context.Thread, $"{".ctor"}: invalid argument #{_lastArgPos}: {_lastArg} ({_lastArg.Type}), expected: {_expectedType.FullName}", 2);
        });
        private static readonly global::Lua.LuaFunction _LuaHandleUtility_AddControl = new global::Lua.LuaFunction("AddControl", (_context, _) =>
        {
            global::Lua.LuaValue _lastArg = default;
            global::System.Int32 _lastArgPos = default;
            global::System.Type _expectedType = default;
            var _argCount = _context.ArgumentCount;
            var _arg0 = _lastArg = _argCount > 0 ? _context.GetArgument(0) : global::Lua.LuaValue.Nil;
            _lastArgPos = 0; _expectedType = typeof(global::System.Int32);
            if (_arg0.TryRead<global::System.Int32>(out var _p0_System_Int32))
            {
                var _arg1 = _lastArg = _argCount > 1 ? _context.GetArgument(1) : global::Lua.LuaValue.Nil;
                _lastArgPos = 1; _expectedType = typeof(global::System.Single);
                if (_arg1.TryRead<global::System.Single>(out var _p1_System_Single))
                {
                    if (_argCount == 2)
                    {
                        var controlId = _p0_System_Int32;
                        var distance = _p1_System_Single;
                        global::UnityEditor.HandleUtility.AddControl(controlId, distance);
                        var _retCount = _context.Return();
                        return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                    }
                }
            }
            throw new global::Lua.LuaRuntimeException(_context.Thread, $"{"AddControl"}: invalid argument #{_lastArgPos}: {_lastArg} ({_lastArg.Type}), expected: {_expectedType.FullName}", 2);
        });
        private static readonly global::Lua.LuaFunction _LuaHandleUtility_AddDefaultControl = new global::Lua.LuaFunction("AddDefaultControl", (_context, _) =>
        {
            global::Lua.LuaValue _lastArg = default;
            global::System.Int32 _lastArgPos = default;
            global::System.Type _expectedType = default;
            var _argCount = _context.ArgumentCount;
            var _arg0 = _lastArg = _argCount > 0 ? _context.GetArgument(0) : global::Lua.LuaValue.Nil;
            _lastArgPos = 0; _expectedType = typeof(global::System.Int32);
            if (_arg0.TryRead<global::System.Int32>(out var _p0_System_Int32))
            {
                if (_argCount == 1)
                {
                    var controlId = _p0_System_Int32;
                    global::UnityEditor.HandleUtility.AddDefaultControl(controlId);
                    var _retCount = _context.Return();
                    return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                }
            }
            throw new global::Lua.LuaRuntimeException(_context.Thread, $"{"AddDefaultControl"}: invalid argument #{_lastArgPos}: {_lastArg} ({_lastArg.Type}), expected: {_expectedType.FullName}", 2);
        });
        private static readonly global::Lua.LuaFunction _LuaHandleUtility_CalcLineTranslation = new global::Lua.LuaFunction("CalcLineTranslation", (_context, _) =>
        {
            global::Lua.LuaValue _lastArg = default;
            global::System.Int32 _lastArgPos = default;
            global::System.Type _expectedType = default;
            var _argCount = _context.ArgumentCount;
            var _arg0 = _lastArg = _argCount > 0 ? _context.GetArgument(0) : global::Lua.LuaValue.Nil;
            _lastArgPos = 0; _expectedType = typeof(global::UnityEngine.Vector2);
            if (_arg0.TryRead<global::UnityEngine.Vector2>(out var _p0_UnityEngine_Vector2))
            {
                var _arg1 = _lastArg = _argCount > 1 ? _context.GetArgument(1) : global::Lua.LuaValue.Nil;
                _lastArgPos = 1; _expectedType = typeof(global::UnityEngine.Vector2);
                if (_arg1.TryRead<global::UnityEngine.Vector2>(out var _p1_UnityEngine_Vector2))
                {
                    var _arg2 = _lastArg = _argCount > 2 ? _context.GetArgument(2) : global::Lua.LuaValue.Nil;
                    _lastArgPos = 2; _expectedType = typeof(global::UnityEngine.Vector3);
                    if (_arg2.TryRead<global::UnityEngine.Vector3>(out var _p2_UnityEngine_Vector3))
                    {
                        var _arg3 = _lastArg = _argCount > 3 ? _context.GetArgument(3) : global::Lua.LuaValue.Nil;
                        _lastArgPos = 3; _expectedType = typeof(global::UnityEngine.Vector3);
                        if (_arg3.TryRead<global::UnityEngine.Vector3>(out var _p3_UnityEngine_Vector3))
                        {
                            if (_argCount == 4)
                            {
                                var src = _p0_UnityEngine_Vector2;
                                var dest = _p1_UnityEngine_Vector2;
                                var srcPosition = _p2_UnityEngine_Vector3;
                                var constraintDir = _p3_UnityEngine_Vector3;
                                var _ret0 = global::UnityEditor.HandleUtility.CalcLineTranslation(src, dest, srcPosition, constraintDir);
                                var _lret0 = new global::Lua.LuaValue(_ret0);
                                var _retCount = _context.Return(_lret0);
                                return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                            }
                        }
                    }
                }
            }
            throw new global::Lua.LuaRuntimeException(_context.Thread, $"{"CalcLineTranslation"}: invalid argument #{_lastArgPos}: {_lastArg} ({_lastArg.Type}), expected: {_expectedType.FullName}", 2);
        });
        private static readonly global::Lua.LuaFunction _LuaHandleUtility_ClosestPointToArc = new global::Lua.LuaFunction("ClosestPointToArc", (_context, _) =>
        {
            global::Lua.LuaValue _lastArg = default;
            global::System.Int32 _lastArgPos = default;
            global::System.Type _expectedType = default;
            var _argCount = _context.ArgumentCount;
            var _arg0 = _lastArg = _argCount > 0 ? _context.GetArgument(0) : global::Lua.LuaValue.Nil;
            _lastArgPos = 0; _expectedType = typeof(global::UnityEngine.Vector3);
            if (_arg0.TryRead<global::UnityEngine.Vector3>(out var _p0_UnityEngine_Vector3))
            {
                var _arg1 = _lastArg = _argCount > 1 ? _context.GetArgument(1) : global::Lua.LuaValue.Nil;
                _lastArgPos = 1; _expectedType = typeof(global::UnityEngine.Vector3);
                if (_arg1.TryRead<global::UnityEngine.Vector3>(out var _p1_UnityEngine_Vector3))
                {
                    var _arg2 = _lastArg = _argCount > 2 ? _context.GetArgument(2) : global::Lua.LuaValue.Nil;
                    _lastArgPos = 2; _expectedType = typeof(global::UnityEngine.Vector3);
                    if (_arg2.TryRead<global::UnityEngine.Vector3>(out var _p2_UnityEngine_Vector3))
                    {
                        var _arg3 = _lastArg = _argCount > 3 ? _context.GetArgument(3) : global::Lua.LuaValue.Nil;
                        _lastArgPos = 3; _expectedType = typeof(global::System.Single);
                        if (_arg3.TryRead<global::System.Single>(out var _p3_System_Single))
                        {
                            var _arg4 = _lastArg = _argCount > 4 ? _context.GetArgument(4) : global::Lua.LuaValue.Nil;
                            _lastArgPos = 4; _expectedType = typeof(global::System.Single);
                            if (_arg4.TryRead<global::System.Single>(out var _p4_System_Single))
                            {
                                if (_argCount == 5)
                                {
                                    var center = _p0_UnityEngine_Vector3;
                                    var normal = _p1_UnityEngine_Vector3;
                                    var from = _p2_UnityEngine_Vector3;
                                    var angle = _p3_System_Single;
                                    var radius = _p4_System_Single;
                                    var _ret0 = global::UnityEditor.HandleUtility.ClosestPointToArc(center, normal, from, angle, radius);
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
            throw new global::Lua.LuaRuntimeException(_context.Thread, $"{"ClosestPointToArc"}: invalid argument #{_lastArgPos}: {_lastArg} ({_lastArg.Type}), expected: {_expectedType.FullName}", 2);
        });
        private static readonly global::Lua.LuaFunction _LuaHandleUtility_ClosestPointToDisc = new global::Lua.LuaFunction("ClosestPointToDisc", (_context, _) =>
        {
            global::Lua.LuaValue _lastArg = default;
            global::System.Int32 _lastArgPos = default;
            global::System.Type _expectedType = default;
            var _argCount = _context.ArgumentCount;
            var _arg0 = _lastArg = _argCount > 0 ? _context.GetArgument(0) : global::Lua.LuaValue.Nil;
            _lastArgPos = 0; _expectedType = typeof(global::UnityEngine.Vector3);
            if (_arg0.TryRead<global::UnityEngine.Vector3>(out var _p0_UnityEngine_Vector3))
            {
                var _arg1 = _lastArg = _argCount > 1 ? _context.GetArgument(1) : global::Lua.LuaValue.Nil;
                _lastArgPos = 1; _expectedType = typeof(global::UnityEngine.Vector3);
                if (_arg1.TryRead<global::UnityEngine.Vector3>(out var _p1_UnityEngine_Vector3))
                {
                    var _arg2 = _lastArg = _argCount > 2 ? _context.GetArgument(2) : global::Lua.LuaValue.Nil;
                    _lastArgPos = 2; _expectedType = typeof(global::System.Single);
                    if (_arg2.TryRead<global::System.Single>(out var _p2_System_Single))
                    {
                        if (_argCount == 3)
                        {
                            var center = _p0_UnityEngine_Vector3;
                            var normal = _p1_UnityEngine_Vector3;
                            var radius = _p2_System_Single;
                            var _ret0 = global::UnityEditor.HandleUtility.ClosestPointToDisc(center, normal, radius);
                            var _factory = _context.GetObjectFactory();
                            var _lret0 = _factory.Bind(_ret0);
                            var _retCount = _context.Return(_lret0);
                            return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                        }
                    }
                }
            }
            throw new global::Lua.LuaRuntimeException(_context.Thread, $"{"ClosestPointToDisc"}: invalid argument #{_lastArgPos}: {_lastArg} ({_lastArg.Type}), expected: {_expectedType.FullName}", 2);
        });
        private static readonly global::Lua.LuaFunction _LuaHandleUtility_ClosestPointToPolyLine = new global::Lua.LuaFunction("ClosestPointToPolyLine", (_context, _) =>
        {
            global::Lua.LuaValue _lastArg = default;
            global::System.Int32 _lastArgPos = default;
            global::System.Type _expectedType = default;
            var _argCount = _context.ArgumentCount;
            var _arg0 = _lastArg = _argCount > 0 ? _context.GetArgument(0) : global::Lua.LuaValue.Nil;
            _lastArgPos = 0; _expectedType = typeof(global::UnityEngine.Vector3[]);
            if (_arg0.TryReadArray<global::UnityEngine.Vector3>(out var _p0_UnityEngine_Vector3Array))
            {
                if (_argCount == 1)
                {
                    var vertices = _p0_UnityEngine_Vector3Array;
                    var _ret0 = global::UnityEditor.HandleUtility.ClosestPointToPolyLine(vertices);
                    var _factory = _context.GetObjectFactory();
                    var _lret0 = _factory.Bind(_ret0);
                    var _retCount = _context.Return(_lret0);
                    return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                }
            }
            throw new global::Lua.LuaRuntimeException(_context.Thread, $"{"ClosestPointToPolyLine"}: invalid argument #{_lastArgPos}: {_lastArg} ({_lastArg.Type}), expected: {_expectedType.FullName}", 2);
        });
        private static readonly global::Lua.LuaFunction _LuaHandleUtility_DecodeSelectionId = new global::Lua.LuaFunction("DecodeSelectionId", (_context, _) =>
        {
            global::Lua.LuaValue _lastArg = default;
            global::System.Int32 _lastArgPos = default;
            global::System.Type _expectedType = default;
            var _argCount = _context.ArgumentCount;
            var _arg0 = _lastArg = _argCount > 0 ? _context.GetArgument(0) : global::Lua.LuaValue.Nil;
            _lastArgPos = 0; _expectedType = typeof(global::UnityEngine.Vector4);
            if (_arg0.TryRead<global::UnityEngine.Vector4>(out var _p0_UnityEngine_Vector4))
            {
                if (_argCount == 1)
                {
                    var selectionId = _p0_UnityEngine_Vector4;
                    var _ret0 = global::UnityEditor.HandleUtility.DecodeSelectionId(selectionId);
                    var _lret0 = new global::Lua.LuaValue(_ret0);
                    var _retCount = _context.Return(_lret0);
                    return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                }
            }
            throw new global::Lua.LuaRuntimeException(_context.Thread, $"{"DecodeSelectionId"}: invalid argument #{_lastArgPos}: {_lastArg} ({_lastArg.Type}), expected: {_expectedType.FullName}", 2);
        });
        private static readonly global::Lua.LuaFunction _LuaHandleUtility_DistancePointBezier = new global::Lua.LuaFunction("DistancePointBezier", (_context, _) =>
        {
            global::Lua.LuaValue _lastArg = default;
            global::System.Int32 _lastArgPos = default;
            global::System.Type _expectedType = default;
            var _argCount = _context.ArgumentCount;
            var _arg0 = _lastArg = _argCount > 0 ? _context.GetArgument(0) : global::Lua.LuaValue.Nil;
            _lastArgPos = 0; _expectedType = typeof(global::UnityEngine.Vector3);
            if (_arg0.TryRead<global::UnityEngine.Vector3>(out var _p0_UnityEngine_Vector3))
            {
                var _arg1 = _lastArg = _argCount > 1 ? _context.GetArgument(1) : global::Lua.LuaValue.Nil;
                _lastArgPos = 1; _expectedType = typeof(global::UnityEngine.Vector3);
                if (_arg1.TryRead<global::UnityEngine.Vector3>(out var _p1_UnityEngine_Vector3))
                {
                    var _arg2 = _lastArg = _argCount > 2 ? _context.GetArgument(2) : global::Lua.LuaValue.Nil;
                    _lastArgPos = 2; _expectedType = typeof(global::UnityEngine.Vector3);
                    if (_arg2.TryRead<global::UnityEngine.Vector3>(out var _p2_UnityEngine_Vector3))
                    {
                        var _arg3 = _lastArg = _argCount > 3 ? _context.GetArgument(3) : global::Lua.LuaValue.Nil;
                        _lastArgPos = 3; _expectedType = typeof(global::UnityEngine.Vector3);
                        if (_arg3.TryRead<global::UnityEngine.Vector3>(out var _p3_UnityEngine_Vector3))
                        {
                            var _arg4 = _lastArg = _argCount > 4 ? _context.GetArgument(4) : global::Lua.LuaValue.Nil;
                            _lastArgPos = 4; _expectedType = typeof(global::UnityEngine.Vector3);
                            if (_arg4.TryRead<global::UnityEngine.Vector3>(out var _p4_UnityEngine_Vector3))
                            {
                                if (_argCount == 5)
                                {
                                    var point = _p0_UnityEngine_Vector3;
                                    var startPosition = _p1_UnityEngine_Vector3;
                                    var endPosition = _p2_UnityEngine_Vector3;
                                    var startTangent = _p3_UnityEngine_Vector3;
                                    var endTangent = _p4_UnityEngine_Vector3;
                                    var _ret0 = global::UnityEditor.HandleUtility.DistancePointBezier(point, startPosition, endPosition, startTangent, endTangent);
                                    var _lret0 = new global::Lua.LuaValue(_ret0);
                                    var _retCount = _context.Return(_lret0);
                                    return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                                }
                            }
                        }
                    }
                }
            }
            throw new global::Lua.LuaRuntimeException(_context.Thread, $"{"DistancePointBezier"}: invalid argument #{_lastArgPos}: {_lastArg} ({_lastArg.Type}), expected: {_expectedType.FullName}", 2);
        });
        private static readonly global::Lua.LuaFunction _LuaHandleUtility_DistancePointLine = new global::Lua.LuaFunction("DistancePointLine", (_context, _) =>
        {
            global::Lua.LuaValue _lastArg = default;
            global::System.Int32 _lastArgPos = default;
            global::System.Type _expectedType = default;
            var _argCount = _context.ArgumentCount;
            var _arg0 = _lastArg = _argCount > 0 ? _context.GetArgument(0) : global::Lua.LuaValue.Nil;
            _lastArgPos = 0; _expectedType = typeof(global::UnityEngine.Vector3);
            if (_arg0.TryRead<global::UnityEngine.Vector3>(out var _p0_UnityEngine_Vector3))
            {
                var _arg1 = _lastArg = _argCount > 1 ? _context.GetArgument(1) : global::Lua.LuaValue.Nil;
                _lastArgPos = 1; _expectedType = typeof(global::UnityEngine.Vector3);
                if (_arg1.TryRead<global::UnityEngine.Vector3>(out var _p1_UnityEngine_Vector3))
                {
                    var _arg2 = _lastArg = _argCount > 2 ? _context.GetArgument(2) : global::Lua.LuaValue.Nil;
                    _lastArgPos = 2; _expectedType = typeof(global::UnityEngine.Vector3);
                    if (_arg2.TryRead<global::UnityEngine.Vector3>(out var _p2_UnityEngine_Vector3))
                    {
                        if (_argCount == 3)
                        {
                            var point = _p0_UnityEngine_Vector3;
                            var lineStart = _p1_UnityEngine_Vector3;
                            var lineEnd = _p2_UnityEngine_Vector3;
                            var _ret0 = global::UnityEditor.HandleUtility.DistancePointLine(point, lineStart, lineEnd);
                            var _lret0 = new global::Lua.LuaValue(_ret0);
                            var _retCount = _context.Return(_lret0);
                            return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                        }
                    }
                }
            }
            throw new global::Lua.LuaRuntimeException(_context.Thread, $"{"DistancePointLine"}: invalid argument #{_lastArgPos}: {_lastArg} ({_lastArg.Type}), expected: {_expectedType.FullName}", 2);
        });
        private static readonly global::Lua.LuaFunction _LuaHandleUtility_DistancePointToLine = new global::Lua.LuaFunction("DistancePointToLine", (_context, _) =>
        {
            global::Lua.LuaValue _lastArg = default;
            global::System.Int32 _lastArgPos = default;
            global::System.Type _expectedType = default;
            var _argCount = _context.ArgumentCount;
            var _arg0 = _lastArg = _argCount > 0 ? _context.GetArgument(0) : global::Lua.LuaValue.Nil;
            _lastArgPos = 0; _expectedType = typeof(global::UnityEngine.Vector2);
            if (_arg0.TryRead<global::UnityEngine.Vector2>(out var _p0_UnityEngine_Vector2))
            {
                var _arg1 = _lastArg = _argCount > 1 ? _context.GetArgument(1) : global::Lua.LuaValue.Nil;
                _lastArgPos = 1; _expectedType = typeof(global::UnityEngine.Vector2);
                if (_arg1.TryRead<global::UnityEngine.Vector2>(out var _p1_UnityEngine_Vector2))
                {
                    var _arg2 = _lastArg = _argCount > 2 ? _context.GetArgument(2) : global::Lua.LuaValue.Nil;
                    _lastArgPos = 2; _expectedType = typeof(global::UnityEngine.Vector2);
                    if (_arg2.TryRead<global::UnityEngine.Vector2>(out var _p2_UnityEngine_Vector2))
                    {
                        if (_argCount == 3)
                        {
                            var p = _p0_UnityEngine_Vector2;
                            var a = _p1_UnityEngine_Vector2;
                            var b = _p2_UnityEngine_Vector2;
                            var _ret0 = global::UnityEditor.HandleUtility.DistancePointToLine(p, a, b);
                            var _lret0 = new global::Lua.LuaValue(_ret0);
                            var _retCount = _context.Return(_lret0);
                            return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                        }
                    }
                }
            }
            throw new global::Lua.LuaRuntimeException(_context.Thread, $"{"DistancePointToLine"}: invalid argument #{_lastArgPos}: {_lastArg} ({_lastArg.Type}), expected: {_expectedType.FullName}", 2);
        });
        private static readonly global::Lua.LuaFunction _LuaHandleUtility_DistancePointToLineSegment = new global::Lua.LuaFunction("DistancePointToLineSegment", (_context, _) =>
        {
            global::Lua.LuaValue _lastArg = default;
            global::System.Int32 _lastArgPos = default;
            global::System.Type _expectedType = default;
            var _argCount = _context.ArgumentCount;
            var _arg0 = _lastArg = _argCount > 0 ? _context.GetArgument(0) : global::Lua.LuaValue.Nil;
            _lastArgPos = 0; _expectedType = typeof(global::UnityEngine.Vector2);
            if (_arg0.TryRead<global::UnityEngine.Vector2>(out var _p0_UnityEngine_Vector2))
            {
                var _arg1 = _lastArg = _argCount > 1 ? _context.GetArgument(1) : global::Lua.LuaValue.Nil;
                _lastArgPos = 1; _expectedType = typeof(global::UnityEngine.Vector2);
                if (_arg1.TryRead<global::UnityEngine.Vector2>(out var _p1_UnityEngine_Vector2))
                {
                    var _arg2 = _lastArg = _argCount > 2 ? _context.GetArgument(2) : global::Lua.LuaValue.Nil;
                    _lastArgPos = 2; _expectedType = typeof(global::UnityEngine.Vector2);
                    if (_arg2.TryRead<global::UnityEngine.Vector2>(out var _p2_UnityEngine_Vector2))
                    {
                        if (_argCount == 3)
                        {
                            var p = _p0_UnityEngine_Vector2;
                            var a = _p1_UnityEngine_Vector2;
                            var b = _p2_UnityEngine_Vector2;
                            var _ret0 = global::UnityEditor.HandleUtility.DistancePointToLineSegment(p, a, b);
                            var _lret0 = new global::Lua.LuaValue(_ret0);
                            var _retCount = _context.Return(_lret0);
                            return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                        }
                    }
                }
            }
            throw new global::Lua.LuaRuntimeException(_context.Thread, $"{"DistancePointToLineSegment"}: invalid argument #{_lastArgPos}: {_lastArg} ({_lastArg.Type}), expected: {_expectedType.FullName}", 2);
        });
        private static readonly global::Lua.LuaFunction _LuaHandleUtility_DistanceToArc = new global::Lua.LuaFunction("DistanceToArc", (_context, _) =>
        {
            global::Lua.LuaValue _lastArg = default;
            global::System.Int32 _lastArgPos = default;
            global::System.Type _expectedType = default;
            var _argCount = _context.ArgumentCount;
            var _arg0 = _lastArg = _argCount > 0 ? _context.GetArgument(0) : global::Lua.LuaValue.Nil;
            _lastArgPos = 0; _expectedType = typeof(global::UnityEngine.Vector3);
            if (_arg0.TryRead<global::UnityEngine.Vector3>(out var _p0_UnityEngine_Vector3))
            {
                var _arg1 = _lastArg = _argCount > 1 ? _context.GetArgument(1) : global::Lua.LuaValue.Nil;
                _lastArgPos = 1; _expectedType = typeof(global::UnityEngine.Vector3);
                if (_arg1.TryRead<global::UnityEngine.Vector3>(out var _p1_UnityEngine_Vector3))
                {
                    var _arg2 = _lastArg = _argCount > 2 ? _context.GetArgument(2) : global::Lua.LuaValue.Nil;
                    _lastArgPos = 2; _expectedType = typeof(global::UnityEngine.Vector3);
                    if (_arg2.TryRead<global::UnityEngine.Vector3>(out var _p2_UnityEngine_Vector3))
                    {
                        var _arg3 = _lastArg = _argCount > 3 ? _context.GetArgument(3) : global::Lua.LuaValue.Nil;
                        _lastArgPos = 3; _expectedType = typeof(global::System.Single);
                        if (_arg3.TryRead<global::System.Single>(out var _p3_System_Single))
                        {
                            var _arg4 = _lastArg = _argCount > 4 ? _context.GetArgument(4) : global::Lua.LuaValue.Nil;
                            _lastArgPos = 4; _expectedType = typeof(global::System.Single);
                            if (_arg4.TryRead<global::System.Single>(out var _p4_System_Single))
                            {
                                if (_argCount == 5)
                                {
                                    var center = _p0_UnityEngine_Vector3;
                                    var normal = _p1_UnityEngine_Vector3;
                                    var from = _p2_UnityEngine_Vector3;
                                    var angle = _p3_System_Single;
                                    var radius = _p4_System_Single;
                                    var _ret0 = global::UnityEditor.HandleUtility.DistanceToArc(center, normal, from, angle, radius);
                                    var _lret0 = new global::Lua.LuaValue(_ret0);
                                    var _retCount = _context.Return(_lret0);
                                    return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                                }
                            }
                        }
                    }
                }
            }
            throw new global::Lua.LuaRuntimeException(_context.Thread, $"{"DistanceToArc"}: invalid argument #{_lastArgPos}: {_lastArg} ({_lastArg.Type}), expected: {_expectedType.FullName}", 2);
        });
        private static readonly global::Lua.LuaFunction _LuaHandleUtility_DistanceToCircle = new global::Lua.LuaFunction("DistanceToCircle", (_context, _) =>
        {
            global::Lua.LuaValue _lastArg = default;
            global::System.Int32 _lastArgPos = default;
            global::System.Type _expectedType = default;
            var _argCount = _context.ArgumentCount;
            var _arg0 = _lastArg = _argCount > 0 ? _context.GetArgument(0) : global::Lua.LuaValue.Nil;
            _lastArgPos = 0; _expectedType = typeof(global::UnityEngine.Vector3);
            if (_arg0.TryRead<global::UnityEngine.Vector3>(out var _p0_UnityEngine_Vector3))
            {
                var _arg1 = _lastArg = _argCount > 1 ? _context.GetArgument(1) : global::Lua.LuaValue.Nil;
                _lastArgPos = 1; _expectedType = typeof(global::System.Single);
                if (_arg1.TryRead<global::System.Single>(out var _p1_System_Single))
                {
                    if (_argCount == 2)
                    {
                        var position = _p0_UnityEngine_Vector3;
                        var radius = _p1_System_Single;
                        var _ret0 = global::UnityEditor.HandleUtility.DistanceToCircle(position, radius);
                        var _lret0 = new global::Lua.LuaValue(_ret0);
                        var _retCount = _context.Return(_lret0);
                        return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                    }
                }
            }
            _lastArgPos = 0; _expectedType = typeof(global::Luny.UnityEditor.LuaCameraProjectionCache);
            if (_arg0.TryRead<global::Luny.UnityEditor.LuaCameraProjectionCache>(out var _p0_UnityEditor_CameraProjectionCache))
            {
                var _arg1 = _lastArg = _argCount > 1 ? _context.GetArgument(1) : global::Lua.LuaValue.Nil;
                _lastArgPos = 1; _expectedType = typeof(global::UnityEngine.Vector3);
                if (_arg1.TryRead<global::UnityEngine.Vector3>(out var _p1_UnityEngine_Vector3))
                {
                    var _arg2 = _lastArg = _argCount > 2 ? _context.GetArgument(2) : global::Lua.LuaValue.Nil;
                    _lastArgPos = 2; _expectedType = typeof(global::System.Single);
                    if (_arg2.TryRead<global::System.Single>(out var _p2_System_Single))
                    {
                        if (_argCount == 3)
                        {
                            var projection = _p0_UnityEditor_CameraProjectionCache.Value;
                            var position = _p1_UnityEngine_Vector3;
                            var radius = _p2_System_Single;
                            var _ret0 = global::UnityEditor.HandleUtility.DistanceToCircle(projection, position, radius);
                            var _lret0 = new global::Lua.LuaValue(_ret0);
                            var _retCount = _context.Return(_lret0);
                            return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                        }
                    }
                }
            }
            throw new global::Lua.LuaRuntimeException(_context.Thread, $"{"DistanceToCircle"}: invalid argument #{_lastArgPos}: {_lastArg} ({_lastArg.Type}), expected: {_expectedType.FullName}", 2);
        });
        private static readonly global::Lua.LuaFunction _LuaHandleUtility_DistanceToCone = new global::Lua.LuaFunction("DistanceToCone", (_context, _) =>
        {
            global::Lua.LuaValue _lastArg = default;
            global::System.Int32 _lastArgPos = default;
            global::System.Type _expectedType = default;
            var _argCount = _context.ArgumentCount;
            var _arg0 = _lastArg = _argCount > 0 ? _context.GetArgument(0) : global::Lua.LuaValue.Nil;
            _lastArgPos = 0; _expectedType = typeof(global::UnityEngine.Vector3);
            if (_arg0.TryRead<global::UnityEngine.Vector3>(out var _p0_UnityEngine_Vector3))
            {
                var _arg1 = _lastArg = _argCount > 1 ? _context.GetArgument(1) : global::Lua.LuaValue.Nil;
                _lastArgPos = 1; _expectedType = typeof(global::UnityEngine.Quaternion);
                if (_arg1.TryRead<global::UnityEngine.Quaternion>(out var _p1_UnityEngine_Quaternion))
                {
                    var _arg2 = _lastArg = _argCount > 2 ? _context.GetArgument(2) : global::Lua.LuaValue.Nil;
                    _lastArgPos = 2; _expectedType = typeof(global::System.Single);
                    if (_arg2.TryRead<global::System.Single>(out var _p2_System_Single))
                    {
                        if (_argCount == 3)
                        {
                            var position = _p0_UnityEngine_Vector3;
                            var rotation = _p1_UnityEngine_Quaternion;
                            var size = _p2_System_Single;
                            var _ret0 = global::UnityEditor.HandleUtility.DistanceToCone(position, rotation, size);
                            var _lret0 = new global::Lua.LuaValue(_ret0);
                            var _retCount = _context.Return(_lret0);
                            return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                        }
                    }
                }
            }
            throw new global::Lua.LuaRuntimeException(_context.Thread, $"{"DistanceToCone"}: invalid argument #{_lastArgPos}: {_lastArg} ({_lastArg.Type}), expected: {_expectedType.FullName}", 2);
        });
        private static readonly global::Lua.LuaFunction _LuaHandleUtility_DistanceToCube = new global::Lua.LuaFunction("DistanceToCube", (_context, _) =>
        {
            global::Lua.LuaValue _lastArg = default;
            global::System.Int32 _lastArgPos = default;
            global::System.Type _expectedType = default;
            var _argCount = _context.ArgumentCount;
            var _arg0 = _lastArg = _argCount > 0 ? _context.GetArgument(0) : global::Lua.LuaValue.Nil;
            _lastArgPos = 0; _expectedType = typeof(global::UnityEngine.Vector3);
            if (_arg0.TryRead<global::UnityEngine.Vector3>(out var _p0_UnityEngine_Vector3))
            {
                var _arg1 = _lastArg = _argCount > 1 ? _context.GetArgument(1) : global::Lua.LuaValue.Nil;
                _lastArgPos = 1; _expectedType = typeof(global::UnityEngine.Quaternion);
                if (_arg1.TryRead<global::UnityEngine.Quaternion>(out var _p1_UnityEngine_Quaternion))
                {
                    var _arg2 = _lastArg = _argCount > 2 ? _context.GetArgument(2) : global::Lua.LuaValue.Nil;
                    _lastArgPos = 2; _expectedType = typeof(global::System.Single);
                    if (_arg2.TryRead<global::System.Single>(out var _p2_System_Single))
                    {
                        if (_argCount == 3)
                        {
                            var position = _p0_UnityEngine_Vector3;
                            var rotation = _p1_UnityEngine_Quaternion;
                            var size = _p2_System_Single;
                            var _ret0 = global::UnityEditor.HandleUtility.DistanceToCube(position, rotation, size);
                            var _lret0 = new global::Lua.LuaValue(_ret0);
                            var _retCount = _context.Return(_lret0);
                            return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                        }
                    }
                }
            }
            throw new global::Lua.LuaRuntimeException(_context.Thread, $"{"DistanceToCube"}: invalid argument #{_lastArgPos}: {_lastArg} ({_lastArg.Type}), expected: {_expectedType.FullName}", 2);
        });
        private static readonly global::Lua.LuaFunction _LuaHandleUtility_DistanceToDisc = new global::Lua.LuaFunction("DistanceToDisc", (_context, _) =>
        {
            global::Lua.LuaValue _lastArg = default;
            global::System.Int32 _lastArgPos = default;
            global::System.Type _expectedType = default;
            var _argCount = _context.ArgumentCount;
            var _arg0 = _lastArg = _argCount > 0 ? _context.GetArgument(0) : global::Lua.LuaValue.Nil;
            _lastArgPos = 0; _expectedType = typeof(global::UnityEngine.Vector3);
            if (_arg0.TryRead<global::UnityEngine.Vector3>(out var _p0_UnityEngine_Vector3))
            {
                var _arg1 = _lastArg = _argCount > 1 ? _context.GetArgument(1) : global::Lua.LuaValue.Nil;
                _lastArgPos = 1; _expectedType = typeof(global::UnityEngine.Vector3);
                if (_arg1.TryRead<global::UnityEngine.Vector3>(out var _p1_UnityEngine_Vector3))
                {
                    var _arg2 = _lastArg = _argCount > 2 ? _context.GetArgument(2) : global::Lua.LuaValue.Nil;
                    _lastArgPos = 2; _expectedType = typeof(global::System.Single);
                    if (_arg2.TryRead<global::System.Single>(out var _p2_System_Single))
                    {
                        if (_argCount == 3)
                        {
                            var center = _p0_UnityEngine_Vector3;
                            var normal = _p1_UnityEngine_Vector3;
                            var radius = _p2_System_Single;
                            var _ret0 = global::UnityEditor.HandleUtility.DistanceToDisc(center, normal, radius);
                            var _lret0 = new global::Lua.LuaValue(_ret0);
                            var _retCount = _context.Return(_lret0);
                            return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                        }
                    }
                }
            }
            throw new global::Lua.LuaRuntimeException(_context.Thread, $"{"DistanceToDisc"}: invalid argument #{_lastArgPos}: {_lastArg} ({_lastArg.Type}), expected: {_expectedType.FullName}", 2);
        });
        private static readonly global::Lua.LuaFunction _LuaHandleUtility_DistanceToLine = new global::Lua.LuaFunction("DistanceToLine", (_context, _) =>
        {
            global::Lua.LuaValue _lastArg = default;
            global::System.Int32 _lastArgPos = default;
            global::System.Type _expectedType = default;
            var _argCount = _context.ArgumentCount;
            var _arg0 = _lastArg = _argCount > 0 ? _context.GetArgument(0) : global::Lua.LuaValue.Nil;
            _lastArgPos = 0; _expectedType = typeof(global::UnityEngine.Vector3);
            if (_arg0.TryRead<global::UnityEngine.Vector3>(out var _p0_UnityEngine_Vector3))
            {
                var _arg1 = _lastArg = _argCount > 1 ? _context.GetArgument(1) : global::Lua.LuaValue.Nil;
                _lastArgPos = 1; _expectedType = typeof(global::UnityEngine.Vector3);
                if (_arg1.TryRead<global::UnityEngine.Vector3>(out var _p1_UnityEngine_Vector3))
                {
                    if (_argCount == 2)
                    {
                        var p1 = _p0_UnityEngine_Vector3;
                        var p2 = _p1_UnityEngine_Vector3;
                        var _ret0 = global::UnityEditor.HandleUtility.DistanceToLine(p1, p2);
                        var _lret0 = new global::Lua.LuaValue(_ret0);
                        var _retCount = _context.Return(_lret0);
                        return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                    }
                }
            }
            throw new global::Lua.LuaRuntimeException(_context.Thread, $"{"DistanceToLine"}: invalid argument #{_lastArgPos}: {_lastArg} ({_lastArg.Type}), expected: {_expectedType.FullName}", 2);
        });
        private static readonly global::Lua.LuaFunction _LuaHandleUtility_DistanceToPolyLine = new global::Lua.LuaFunction("DistanceToPolyLine", (_context, _) =>
        {
            global::Lua.LuaValue _lastArg = default;
            global::System.Int32 _lastArgPos = default;
            global::System.Type _expectedType = default;
            var _argCount = _context.ArgumentCount;
            var _arg0 = _lastArg = _argCount > 0 ? _context.GetArgument(0) : global::Lua.LuaValue.Nil;
            _lastArgPos = 0; _expectedType = typeof(global::UnityEngine.Vector3[]);
            if (_arg0.TryReadArray<global::UnityEngine.Vector3>(out var _p0_UnityEngine_Vector3Array))
            {
                if (_argCount == 1)
                {
                    var points = _p0_UnityEngine_Vector3Array;
                    var _ret0 = global::UnityEditor.HandleUtility.DistanceToPolyLine(points);
                    var _lret0 = new global::Lua.LuaValue(_ret0);
                    var _retCount = _context.Return(_lret0);
                    return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                }
            }
            throw new global::Lua.LuaRuntimeException(_context.Thread, $"{"DistanceToPolyLine"}: invalid argument #{_lastArgPos}: {_lastArg} ({_lastArg.Type}), expected: {_expectedType.FullName}", 2);
        });
        private static readonly global::Lua.LuaFunction _LuaHandleUtility_DistanceToRectangle = new global::Lua.LuaFunction("DistanceToRectangle", (_context, _) =>
        {
            global::Lua.LuaValue _lastArg = default;
            global::System.Int32 _lastArgPos = default;
            global::System.Type _expectedType = default;
            var _argCount = _context.ArgumentCount;
            var _arg0 = _lastArg = _argCount > 0 ? _context.GetArgument(0) : global::Lua.LuaValue.Nil;
            _lastArgPos = 0; _expectedType = typeof(global::UnityEngine.Vector3);
            if (_arg0.TryRead<global::UnityEngine.Vector3>(out var _p0_UnityEngine_Vector3))
            {
                var _arg1 = _lastArg = _argCount > 1 ? _context.GetArgument(1) : global::Lua.LuaValue.Nil;
                _lastArgPos = 1; _expectedType = typeof(global::UnityEngine.Quaternion);
                if (_arg1.TryRead<global::UnityEngine.Quaternion>(out var _p1_UnityEngine_Quaternion))
                {
                    var _arg2 = _lastArg = _argCount > 2 ? _context.GetArgument(2) : global::Lua.LuaValue.Nil;
                    _lastArgPos = 2; _expectedType = typeof(global::System.Single);
                    if (_arg2.TryRead<global::System.Single>(out var _p2_System_Single))
                    {
                        if (_argCount == 3)
                        {
                            var position = _p0_UnityEngine_Vector3;
                            var rotation = _p1_UnityEngine_Quaternion;
                            var size = _p2_System_Single;
                            var _ret0 = global::UnityEditor.HandleUtility.DistanceToRectangle(position, rotation, size);
                            var _lret0 = new global::Lua.LuaValue(_ret0);
                            var _retCount = _context.Return(_lret0);
                            return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                        }
                    }
                }
            }
            throw new global::Lua.LuaRuntimeException(_context.Thread, $"{"DistanceToRectangle"}: invalid argument #{_lastArgPos}: {_lastArg} ({_lastArg.Type}), expected: {_expectedType.FullName}", 2);
        });
        private static readonly global::Lua.LuaFunction _LuaHandleUtility_EncodeSelectionId = new global::Lua.LuaFunction("EncodeSelectionId", (_context, _) =>
        {
            global::Lua.LuaValue _lastArg = default;
            global::System.Int32 _lastArgPos = default;
            global::System.Type _expectedType = default;
            var _argCount = _context.ArgumentCount;
            var _arg0 = _lastArg = _argCount > 0 ? _context.GetArgument(0) : global::Lua.LuaValue.Nil;
            _lastArgPos = 0; _expectedType = typeof(global::System.Int32);
            if (_arg0.TryRead<global::System.Int32>(out var _p0_System_Int32))
            {
                if (_argCount == 1)
                {
                    var pickingIndex = _p0_System_Int32;
                    var _ret0 = global::UnityEditor.HandleUtility.EncodeSelectionId(pickingIndex);
                    var _factory = _context.GetObjectFactory();
                    var _lret0 = _factory.Bind(_ret0);
                    var _retCount = _context.Return(_lret0);
                    return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                }
            }
            throw new global::Lua.LuaRuntimeException(_context.Thread, $"{"EncodeSelectionId"}: invalid argument #{_lastArgPos}: {_lastArg} ({_lastArg.Type}), expected: {_expectedType.FullName}", 2);
        });
        private static readonly global::Lua.LuaFunction _LuaHandleUtility_GetHandleSize = new global::Lua.LuaFunction("GetHandleSize", (_context, _) =>
        {
            global::Lua.LuaValue _lastArg = default;
            global::System.Int32 _lastArgPos = default;
            global::System.Type _expectedType = default;
            var _argCount = _context.ArgumentCount;
            var _arg0 = _lastArg = _argCount > 0 ? _context.GetArgument(0) : global::Lua.LuaValue.Nil;
            _lastArgPos = 0; _expectedType = typeof(global::UnityEngine.Vector3);
            if (_arg0.TryRead<global::UnityEngine.Vector3>(out var _p0_UnityEngine_Vector3))
            {
                if (_argCount == 1)
                {
                    var position = _p0_UnityEngine_Vector3;
                    var _ret0 = global::UnityEditor.HandleUtility.GetHandleSize(position);
                    var _lret0 = new global::Lua.LuaValue(_ret0);
                    var _retCount = _context.Return(_lret0);
                    return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                }
            }
            throw new global::Lua.LuaRuntimeException(_context.Thread, $"{"GetHandleSize"}: invalid argument #{_lastArgPos}: {_lastArg} ({_lastArg.Type}), expected: {_expectedType.FullName}", 2);
        });
        private static readonly global::Lua.LuaFunction _LuaHandleUtility_GetPickingIncludeExcludeList = new global::Lua.LuaFunction("GetPickingIncludeExcludeList", (_context, _) =>
        {
            global::Lua.LuaValue _lastArg = default;
            global::System.Int32 _lastArgPos = default;
            global::System.Type _expectedType = default;
            var _argCount = _context.ArgumentCount;
            if (_argCount == 0)
            {
                var _ret0 = global::UnityEditor.HandleUtility.GetPickingIncludeExcludeList();
                var _lret0 = global::Luny.UnityEditor.LuaPickingIncludeExcludeList.Bind(_ret0);
                var _retCount = _context.Return(_lret0);
                return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
            }
            var _arg0 = _lastArg = _argCount > 0 ? _context.GetArgument(0) : global::Lua.LuaValue.Nil;
            _lastArgPos = 0; _expectedType = typeof(global::Unity.Collections.Allocator);
            var _p0_Unity_Collections_Allocator = _arg0.ReadValue<global::Unity.Collections.Allocator>(global::Unity.Collections.Allocator.@Persistent);
            {
                if (_argCount == 1)
                {
                    var allocator = _p0_Unity_Collections_Allocator;
                    var _ret0 = global::UnityEditor.HandleUtility.GetPickingIncludeExcludeList(allocator);
                    var _lret0 = global::Luny.UnityEditor.LuaPickingIncludeExcludeList.Bind(_ret0);
                    var _retCount = _context.Return(_lret0);
                    return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                }
            }
            throw new global::Lua.LuaRuntimeException(_context.Thread, $"{"GetPickingIncludeExcludeList"}: invalid argument #{_lastArgPos}: {_lastArg} ({_lastArg.Type}), expected: {_expectedType.FullName}", 2);
        });
        private static readonly global::Lua.LuaFunction _LuaHandleUtility_GetSelectionOutlineIncludeExcludeList = new global::Lua.LuaFunction("GetSelectionOutlineIncludeExcludeList", (_context, _) =>
        {
            global::Lua.LuaValue _lastArg = default;
            global::System.Int32 _lastArgPos = default;
            global::System.Type _expectedType = default;
            var _argCount = _context.ArgumentCount;
            if (_argCount == 0)
            {
                var _ret0 = global::UnityEditor.HandleUtility.GetSelectionOutlineIncludeExcludeList();
                var _lret0 = global::Luny.UnityEditor.LuaPickingIncludeExcludeList.Bind(_ret0);
                var _retCount = _context.Return(_lret0);
                return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
            }
            var _arg0 = _lastArg = _argCount > 0 ? _context.GetArgument(0) : global::Lua.LuaValue.Nil;
            _lastArgPos = 0; _expectedType = typeof(global::Unity.Collections.Allocator);
            var _p0_Unity_Collections_Allocator = _arg0.ReadValue<global::Unity.Collections.Allocator>(global::Unity.Collections.Allocator.@Persistent);
            {
                if (_argCount == 1)
                {
                    var allocator = _p0_Unity_Collections_Allocator;
                    var _ret0 = global::UnityEditor.HandleUtility.GetSelectionOutlineIncludeExcludeList(allocator);
                    var _lret0 = global::Luny.UnityEditor.LuaPickingIncludeExcludeList.Bind(_ret0);
                    var _retCount = _context.Return(_lret0);
                    return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                }
            }
            throw new global::Lua.LuaRuntimeException(_context.Thread, $"{"GetSelectionOutlineIncludeExcludeList"}: invalid argument #{_lastArgPos}: {_lastArg} ({_lastArg.Type}), expected: {_expectedType.FullName}", 2);
        });
        private static readonly global::Lua.LuaFunction _LuaHandleUtility_GUIPointToScreenPixelCoordinate = new global::Lua.LuaFunction("GUIPointToScreenPixelCoordinate", (_context, _) =>
        {
            global::Lua.LuaValue _lastArg = default;
            global::System.Int32 _lastArgPos = default;
            global::System.Type _expectedType = default;
            var _argCount = _context.ArgumentCount;
            var _arg0 = _lastArg = _argCount > 0 ? _context.GetArgument(0) : global::Lua.LuaValue.Nil;
            _lastArgPos = 0; _expectedType = typeof(global::UnityEngine.Vector2);
            if (_arg0.TryRead<global::UnityEngine.Vector2>(out var _p0_UnityEngine_Vector2))
            {
                if (_argCount == 1)
                {
                    var guiPoint = _p0_UnityEngine_Vector2;
                    var _ret0 = global::UnityEditor.HandleUtility.GUIPointToScreenPixelCoordinate(guiPoint);
                    var _factory = _context.GetObjectFactory();
                    var _lret0 = _factory.Bind(_ret0);
                    var _retCount = _context.Return(_lret0);
                    return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                }
            }
            throw new global::Lua.LuaRuntimeException(_context.Thread, $"{"GUIPointToScreenPixelCoordinate"}: invalid argument #{_lastArgPos}: {_lastArg} ({_lastArg.Type}), expected: {_expectedType.FullName}", 2);
        });
        private static readonly global::Lua.LuaFunction _LuaHandleUtility_GUIPointToWorldRay = new global::Lua.LuaFunction("GUIPointToWorldRay", (_context, _) =>
        {
            global::Lua.LuaValue _lastArg = default;
            global::System.Int32 _lastArgPos = default;
            global::System.Type _expectedType = default;
            var _argCount = _context.ArgumentCount;
            var _arg0 = _lastArg = _argCount > 0 ? _context.GetArgument(0) : global::Lua.LuaValue.Nil;
            _lastArgPos = 0; _expectedType = typeof(global::UnityEngine.Vector2);
            if (_arg0.TryRead<global::UnityEngine.Vector2>(out var _p0_UnityEngine_Vector2))
            {
                if (_argCount == 1)
                {
                    var position = _p0_UnityEngine_Vector2;
                    var _ret0 = global::UnityEditor.HandleUtility.GUIPointToWorldRay(position);
                    var _factory = _context.GetObjectFactory();
                    var _lret0 = _factory.Bind(_ret0);
                    var _retCount = _context.Return(_lret0);
                    return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                }
            }
            throw new global::Lua.LuaRuntimeException(_context.Thread, $"{"GUIPointToWorldRay"}: invalid argument #{_lastArgPos}: {_lastArg} ({_lastArg.Type}), expected: {_expectedType.FullName}", 2);
        });
        private static readonly global::Lua.LuaFunction _LuaHandleUtility_PickGameObject = new global::Lua.LuaFunction("PickGameObject", (_context, _) =>
        {
            global::Lua.LuaValue _lastArg = default;
            global::System.Int32 _lastArgPos = default;
            global::System.Type _expectedType = default;
            var _argCount = _context.ArgumentCount;
            var _arg0 = _lastArg = _argCount > 0 ? _context.GetArgument(0) : global::Lua.LuaValue.Nil;
            _lastArgPos = 0; _expectedType = typeof(global::UnityEngine.Vector2);
            if (_arg0.TryRead<global::UnityEngine.Vector2>(out var _p0_UnityEngine_Vector2))
            {
                var _arg1 = _lastArg = _argCount > 1 ? _context.GetArgument(1) : global::Lua.LuaValue.Nil;
                _lastArgPos = 1; _expectedType = typeof(global::System.Boolean);
                if (_arg1.TryRead<global::System.Boolean>(out var _p1_System_Boolean))
                {
                    if (_argCount == 2)
                    {
                        var position = _p0_UnityEngine_Vector2;
                        var selectPrefabRoot = _p1_System_Boolean;
                        var _ret0 = global::UnityEditor.HandleUtility.PickGameObject(position, selectPrefabRoot);
                        var _factory = _context.GetObjectFactory();
                        var _lret0 = _factory.Bind(_ret0);
                        var _retCount = _context.Return(_lret0);
                        return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                    }
                    var _arg2 = _lastArg = _argCount > 2 ? _context.GetArgument(2) : global::Lua.LuaValue.Nil;
                    _lastArgPos = 2; _expectedType = typeof(global::UnityEngine.GameObject[]);
                    if (_arg2.TryReadArray<global::UnityEngine.GameObject>(out var _p2_UnityEngine_GameObjectArray))
                    {
                        if (_argCount == 3)
                        {
                            var position = _p0_UnityEngine_Vector2;
                            var selectPrefabRoot = _p1_System_Boolean;
                            var ignore = _p2_UnityEngine_GameObjectArray;
                            var _ret0 = global::UnityEditor.HandleUtility.PickGameObject(position, selectPrefabRoot, ignore);
                            var _factory = _context.GetObjectFactory();
                            var _lret0 = _factory.Bind(_ret0);
                            var _retCount = _context.Return(_lret0);
                            return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                        }
                        var _arg3 = _lastArg = _argCount > 3 ? _context.GetArgument(3) : global::Lua.LuaValue.Nil;
                        _lastArgPos = 3; _expectedType = typeof(global::UnityEngine.GameObject[]);
                        if (_arg3.TryReadArray<global::UnityEngine.GameObject>(out var _p3_UnityEngine_GameObjectArray))
                        {
                            if (_argCount == 4)
                            {
                                var position = _p0_UnityEngine_Vector2;
                                var selectPrefabRoot = _p1_System_Boolean;
                                var ignore = _p2_UnityEngine_GameObjectArray;
                                var filter = _p3_UnityEngine_GameObjectArray;
                                var _ret0 = global::UnityEditor.HandleUtility.PickGameObject(position, selectPrefabRoot, ignore, filter);
                                var _factory = _context.GetObjectFactory();
                                var _lret0 = _factory.Bind(_ret0);
                                var _retCount = _context.Return(_lret0);
                                return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                            }
                        }
                    }
                }
            }
            throw new global::Lua.LuaRuntimeException(_context.Thread, $"{"PickGameObject"}: invalid argument #{_lastArgPos}: {_lastArg} ({_lastArg.Type}), expected: {_expectedType.FullName}", 2);
        });
        private static readonly global::Lua.LuaFunction _LuaHandleUtility_PickRectObjects = new global::Lua.LuaFunction("PickRectObjects", (_context, _) =>
        {
            global::Lua.LuaValue _lastArg = default;
            global::System.Int32 _lastArgPos = default;
            global::System.Type _expectedType = default;
            var _argCount = _context.ArgumentCount;
            var _arg0 = _lastArg = _argCount > 0 ? _context.GetArgument(0) : global::Lua.LuaValue.Nil;
            _lastArgPos = 0; _expectedType = typeof(global::UnityEngine.Rect);
            if (_arg0.TryRead<global::UnityEngine.Rect>(out var _p0_UnityEngine_Rect))
            {
                if (_argCount == 1)
                {
                    var rect = _p0_UnityEngine_Rect;
                    var _ret0 = global::UnityEditor.HandleUtility.PickRectObjects(rect);
                    var _factory = _context.GetObjectFactory();
                    var _lret0 = _factory.Bind(_ret0);
                    var _retCount = _context.Return(_lret0);
                    return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                }
                var _arg1 = _lastArg = _argCount > 1 ? _context.GetArgument(1) : global::Lua.LuaValue.Nil;
                _lastArgPos = 1; _expectedType = typeof(global::System.Boolean);
                if (_arg1.TryRead<global::System.Boolean>(out var _p1_System_Boolean))
                {
                    if (_argCount == 2)
                    {
                        var rect = _p0_UnityEngine_Rect;
                        var selectPrefabRootsOnly = _p1_System_Boolean;
                        var _ret0 = global::UnityEditor.HandleUtility.PickRectObjects(rect, selectPrefabRootsOnly);
                        var _factory = _context.GetObjectFactory();
                        var _lret0 = _factory.Bind(_ret0);
                        var _retCount = _context.Return(_lret0);
                        return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                    }
                }
            }
            throw new global::Lua.LuaRuntimeException(_context.Thread, $"{"PickRectObjects"}: invalid argument #{_lastArgPos}: {_lastArg} ({_lastArg.Type}), expected: {_expectedType.FullName}", 2);
        });
        private static readonly global::Lua.LuaFunction _LuaHandleUtility_PointOnLineParameter = new global::Lua.LuaFunction("PointOnLineParameter", (_context, _) =>
        {
            global::Lua.LuaValue _lastArg = default;
            global::System.Int32 _lastArgPos = default;
            global::System.Type _expectedType = default;
            var _argCount = _context.ArgumentCount;
            var _arg0 = _lastArg = _argCount > 0 ? _context.GetArgument(0) : global::Lua.LuaValue.Nil;
            _lastArgPos = 0; _expectedType = typeof(global::UnityEngine.Vector3);
            if (_arg0.TryRead<global::UnityEngine.Vector3>(out var _p0_UnityEngine_Vector3))
            {
                var _arg1 = _lastArg = _argCount > 1 ? _context.GetArgument(1) : global::Lua.LuaValue.Nil;
                _lastArgPos = 1; _expectedType = typeof(global::UnityEngine.Vector3);
                if (_arg1.TryRead<global::UnityEngine.Vector3>(out var _p1_UnityEngine_Vector3))
                {
                    var _arg2 = _lastArg = _argCount > 2 ? _context.GetArgument(2) : global::Lua.LuaValue.Nil;
                    _lastArgPos = 2; _expectedType = typeof(global::UnityEngine.Vector3);
                    if (_arg2.TryRead<global::UnityEngine.Vector3>(out var _p2_UnityEngine_Vector3))
                    {
                        if (_argCount == 3)
                        {
                            var point = _p0_UnityEngine_Vector3;
                            var linePoint = _p1_UnityEngine_Vector3;
                            var lineDirection = _p2_UnityEngine_Vector3;
                            var _ret0 = global::UnityEditor.HandleUtility.PointOnLineParameter(point, linePoint, lineDirection);
                            var _lret0 = new global::Lua.LuaValue(_ret0);
                            var _retCount = _context.Return(_lret0);
                            return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                        }
                    }
                }
            }
            throw new global::Lua.LuaRuntimeException(_context.Thread, $"{"PointOnLineParameter"}: invalid argument #{_lastArgPos}: {_lastArg} ({_lastArg.Type}), expected: {_expectedType.FullName}", 2);
        });
        private static readonly global::Lua.LuaFunction _LuaHandleUtility_PopCamera = new global::Lua.LuaFunction("PopCamera", (_context, _) =>
        {
            global::Lua.LuaValue _lastArg = default;
            global::System.Int32 _lastArgPos = default;
            global::System.Type _expectedType = default;
            var _argCount = _context.ArgumentCount;
            var _arg0 = _lastArg = _argCount > 0 ? _context.GetArgument(0) : global::Lua.LuaValue.Nil;
            _lastArgPos = 0; _expectedType = typeof(global::UnityEngine.Camera);
            if (_arg0.TryRead<global::UnityEngine.Camera>(out var _p0_UnityEngine_Camera))
            {
                if (_argCount == 1)
                {
                    var camera = _p0_UnityEngine_Camera;
                    global::UnityEditor.HandleUtility.PopCamera(camera);
                    var _retCount = _context.Return();
                    return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                }
            }
            throw new global::Lua.LuaRuntimeException(_context.Thread, $"{"PopCamera"}: invalid argument #{_lastArgPos}: {_lastArg} ({_lastArg.Type}), expected: {_expectedType.FullName}", 2);
        });
        private static readonly global::Lua.LuaFunction _LuaHandleUtility_ProjectPointLine = new global::Lua.LuaFunction("ProjectPointLine", (_context, _) =>
        {
            global::Lua.LuaValue _lastArg = default;
            global::System.Int32 _lastArgPos = default;
            global::System.Type _expectedType = default;
            var _argCount = _context.ArgumentCount;
            var _arg0 = _lastArg = _argCount > 0 ? _context.GetArgument(0) : global::Lua.LuaValue.Nil;
            _lastArgPos = 0; _expectedType = typeof(global::UnityEngine.Vector3);
            if (_arg0.TryRead<global::UnityEngine.Vector3>(out var _p0_UnityEngine_Vector3))
            {
                var _arg1 = _lastArg = _argCount > 1 ? _context.GetArgument(1) : global::Lua.LuaValue.Nil;
                _lastArgPos = 1; _expectedType = typeof(global::UnityEngine.Vector3);
                if (_arg1.TryRead<global::UnityEngine.Vector3>(out var _p1_UnityEngine_Vector3))
                {
                    var _arg2 = _lastArg = _argCount > 2 ? _context.GetArgument(2) : global::Lua.LuaValue.Nil;
                    _lastArgPos = 2; _expectedType = typeof(global::UnityEngine.Vector3);
                    if (_arg2.TryRead<global::UnityEngine.Vector3>(out var _p2_UnityEngine_Vector3))
                    {
                        if (_argCount == 3)
                        {
                            var point = _p0_UnityEngine_Vector3;
                            var lineStart = _p1_UnityEngine_Vector3;
                            var lineEnd = _p2_UnityEngine_Vector3;
                            var _ret0 = global::UnityEditor.HandleUtility.ProjectPointLine(point, lineStart, lineEnd);
                            var _factory = _context.GetObjectFactory();
                            var _lret0 = _factory.Bind(_ret0);
                            var _retCount = _context.Return(_lret0);
                            return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                        }
                    }
                }
            }
            throw new global::Lua.LuaRuntimeException(_context.Thread, $"{"ProjectPointLine"}: invalid argument #{_lastArgPos}: {_lastArg} ({_lastArg.Type}), expected: {_expectedType.FullName}", 2);
        });
        private static readonly global::Lua.LuaFunction _LuaHandleUtility_PushCamera = new global::Lua.LuaFunction("PushCamera", (_context, _) =>
        {
            global::Lua.LuaValue _lastArg = default;
            global::System.Int32 _lastArgPos = default;
            global::System.Type _expectedType = default;
            var _argCount = _context.ArgumentCount;
            var _arg0 = _lastArg = _argCount > 0 ? _context.GetArgument(0) : global::Lua.LuaValue.Nil;
            _lastArgPos = 0; _expectedType = typeof(global::UnityEngine.Camera);
            if (_arg0.TryRead<global::UnityEngine.Camera>(out var _p0_UnityEngine_Camera))
            {
                if (_argCount == 1)
                {
                    var camera = _p0_UnityEngine_Camera;
                    global::UnityEditor.HandleUtility.PushCamera(camera);
                    var _retCount = _context.Return();
                    return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                }
            }
            throw new global::Lua.LuaRuntimeException(_context.Thread, $"{"PushCamera"}: invalid argument #{_lastArgPos}: {_lastArg} ({_lastArg.Type}), expected: {_expectedType.FullName}", 2);
        });
        private static readonly global::Lua.LuaFunction _LuaHandleUtility_RaySnap = new global::Lua.LuaFunction("RaySnap", (_context, _) =>
        {
            global::Lua.LuaValue _lastArg = default;
            global::System.Int32 _lastArgPos = default;
            global::System.Type _expectedType = default;
            var _argCount = _context.ArgumentCount;
            var _arg0 = _lastArg = _argCount > 0 ? _context.GetArgument(0) : global::Lua.LuaValue.Nil;
            _lastArgPos = 0; _expectedType = typeof(global::UnityEngine.Ray);
            if (_arg0.TryRead<global::UnityEngine.Ray>(out var _p0_UnityEngine_Ray))
            {
                if (_argCount == 1)
                {
                    var ray = _p0_UnityEngine_Ray;
                    var _ret0 = global::UnityEditor.HandleUtility.RaySnap(ray);
                    var _factory = _context.GetObjectFactory();
                    var _lret0 = _factory.Bind(_ret0);
                    var _retCount = _context.Return(_lret0);
                    return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                }
            }
            throw new global::Lua.LuaRuntimeException(_context.Thread, $"{"RaySnap"}: invalid argument #{_lastArgPos}: {_lastArg} ({_lastArg.Type}), expected: {_expectedType.FullName}", 2);
        });
        private static readonly global::Lua.LuaFunction _LuaHandleUtility_RegisterRenderPickingCallback = new global::Lua.LuaFunction("RegisterRenderPickingCallback", (_context, _) =>
        {
            global::Lua.LuaValue _lastArg = default;
            global::System.Int32 _lastArgPos = default;
            global::System.Type _expectedType = default;
            var _argCount = _context.ArgumentCount;
            var _arg0 = _lastArg = _argCount > 0 ? _context.GetArgument(0) : global::Lua.LuaValue.Nil;
            _lastArgPos = 0; _expectedType = typeof(global::UnityEditor.HandleUtility.RenderPickingCallback);
            if (_arg0.TryRead<global::UnityEditor.HandleUtility.RenderPickingCallback>(out var _p0_UnityEditor_HandleUtility_RenderPickingCallback))
            {
                if (_argCount == 1)
                {
                    var renderPickingCallback = _p0_UnityEditor_HandleUtility_RenderPickingCallback;
                    var _ret0 = global::UnityEditor.HandleUtility.RegisterRenderPickingCallback(renderPickingCallback);
                    var _lret0 = new global::Lua.LuaValue(_ret0);
                    var _retCount = _context.Return(_lret0);
                    return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                }
            }
            throw new global::Lua.LuaRuntimeException(_context.Thread, $"{"RegisterRenderPickingCallback"}: invalid argument #{_lastArgPos}: {_lastArg} ({_lastArg.Type}), expected: {_expectedType.FullName}", 2);
        });
        private static readonly global::Lua.LuaFunction _LuaHandleUtility_Repaint = new global::Lua.LuaFunction("Repaint", (_context, _) =>
        {
            global::Lua.LuaValue _lastArg = default;
            global::System.Int32 _lastArgPos = default;
            global::System.Type _expectedType = default;
            var _argCount = _context.ArgumentCount;
            if (_argCount == 0)
            {
                global::UnityEditor.HandleUtility.Repaint();
                var _retCount = _context.Return();
                return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
            }
            throw new global::Lua.LuaRuntimeException(_context.Thread, $"{"Repaint"}: invalid argument #{_lastArgPos}: {_lastArg} ({_lastArg.Type}), expected: {_expectedType.FullName}", 2);
        });
        private static readonly global::Lua.LuaFunction _LuaHandleUtility_UnregisterRenderPickingCallback = new global::Lua.LuaFunction("UnregisterRenderPickingCallback", (_context, _) =>
        {
            global::Lua.LuaValue _lastArg = default;
            global::System.Int32 _lastArgPos = default;
            global::System.Type _expectedType = default;
            var _argCount = _context.ArgumentCount;
            var _arg0 = _lastArg = _argCount > 0 ? _context.GetArgument(0) : global::Lua.LuaValue.Nil;
            _lastArgPos = 0; _expectedType = typeof(global::UnityEditor.HandleUtility.RenderPickingCallback);
            if (_arg0.TryRead<global::UnityEditor.HandleUtility.RenderPickingCallback>(out var _p0_UnityEditor_HandleUtility_RenderPickingCallback))
            {
                if (_argCount == 1)
                {
                    var renderPickingCallback = _p0_UnityEditor_HandleUtility_RenderPickingCallback;
                    var _ret0 = global::UnityEditor.HandleUtility.UnregisterRenderPickingCallback(renderPickingCallback);
                    var _lret0 = new global::Lua.LuaValue(_ret0);
                    var _retCount = _context.Return(_lret0);
                    return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                }
            }
            throw new global::Lua.LuaRuntimeException(_context.Thread, $"{"UnregisterRenderPickingCallback"}: invalid argument #{_lastArgPos}: {_lastArg} ({_lastArg.Type}), expected: {_expectedType.FullName}", 2);
        });
        private static readonly global::Lua.LuaFunction _LuaHandleUtility_WorldPointToSizedRect = new global::Lua.LuaFunction("WorldPointToSizedRect", (_context, _) =>
        {
            global::Lua.LuaValue _lastArg = default;
            global::System.Int32 _lastArgPos = default;
            global::System.Type _expectedType = default;
            var _argCount = _context.ArgumentCount;
            var _arg0 = _lastArg = _argCount > 0 ? _context.GetArgument(0) : global::Lua.LuaValue.Nil;
            _lastArgPos = 0; _expectedType = typeof(global::UnityEngine.Vector3);
            if (_arg0.TryRead<global::UnityEngine.Vector3>(out var _p0_UnityEngine_Vector3))
            {
                var _arg1 = _lastArg = _argCount > 1 ? _context.GetArgument(1) : global::Lua.LuaValue.Nil;
                _lastArgPos = 1; _expectedType = typeof(global::UnityEngine.GUIContent);
                if (_arg1.TryRead<global::UnityEngine.GUIContent>(out var _p1_UnityEngine_GUIContent))
                {
                    var _arg2 = _lastArg = _argCount > 2 ? _context.GetArgument(2) : global::Lua.LuaValue.Nil;
                    _lastArgPos = 2; _expectedType = typeof(global::UnityEngine.GUIStyle);
                    if (_arg2.TryRead<global::UnityEngine.GUIStyle>(out var _p2_UnityEngine_GUIStyle))
                    {
                        if (_argCount == 3)
                        {
                            var position = _p0_UnityEngine_Vector3;
                            var content = _p1_UnityEngine_GUIContent;
                            var style = _p2_UnityEngine_GUIStyle;
                            var _ret0 = global::UnityEditor.HandleUtility.WorldPointToSizedRect(position, content, style);
                            var _factory = _context.GetObjectFactory();
                            var _lret0 = _factory.Bind(_ret0);
                            var _retCount = _context.Return(_lret0);
                            return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                        }
                    }
                }
            }
            throw new global::Lua.LuaRuntimeException(_context.Thread, $"{"WorldPointToSizedRect"}: invalid argument #{_lastArgPos}: {_lastArg} ({_lastArg.Type}), expected: {_expectedType.FullName}", 2);
        });
        private static readonly global::Lua.LuaFunction _LuaHandleUtility_WorldToGUIPoint = new global::Lua.LuaFunction("WorldToGUIPoint", (_context, _) =>
        {
            global::Lua.LuaValue _lastArg = default;
            global::System.Int32 _lastArgPos = default;
            global::System.Type _expectedType = default;
            var _argCount = _context.ArgumentCount;
            var _arg0 = _lastArg = _argCount > 0 ? _context.GetArgument(0) : global::Lua.LuaValue.Nil;
            _lastArgPos = 0; _expectedType = typeof(global::UnityEngine.Vector3);
            if (_arg0.TryRead<global::UnityEngine.Vector3>(out var _p0_UnityEngine_Vector3))
            {
                if (_argCount == 1)
                {
                    var world = _p0_UnityEngine_Vector3;
                    var _ret0 = global::UnityEditor.HandleUtility.WorldToGUIPoint(world);
                    var _factory = _context.GetObjectFactory();
                    var _lret0 = _factory.Bind(_ret0);
                    var _retCount = _context.Return(_lret0);
                    return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                }
            }
            throw new global::Lua.LuaRuntimeException(_context.Thread, $"{"WorldToGUIPoint"}: invalid argument #{_lastArgPos}: {_lastArg} ({_lastArg.Type}), expected: {_expectedType.FullName}", 2);
        });
        private static readonly global::Lua.LuaFunction _LuaHandleUtility_WorldToGUIPointWithDepth = new global::Lua.LuaFunction("WorldToGUIPointWithDepth", (_context, _) =>
        {
            global::Lua.LuaValue _lastArg = default;
            global::System.Int32 _lastArgPos = default;
            global::System.Type _expectedType = default;
            var _argCount = _context.ArgumentCount;
            var _arg0 = _lastArg = _argCount > 0 ? _context.GetArgument(0) : global::Lua.LuaValue.Nil;
            _lastArgPos = 0; _expectedType = typeof(global::UnityEngine.Vector3);
            if (_arg0.TryRead<global::UnityEngine.Vector3>(out var _p0_UnityEngine_Vector3))
            {
                if (_argCount == 1)
                {
                    var world = _p0_UnityEngine_Vector3;
                    var _ret0 = global::UnityEditor.HandleUtility.WorldToGUIPointWithDepth(world);
                    var _factory = _context.GetObjectFactory();
                    var _lret0 = _factory.Bind(_ret0);
                    var _retCount = _context.Return(_lret0);
                    return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                }
            }
            _lastArgPos = 0; _expectedType = typeof(global::UnityEngine.Camera);
            if (_arg0.TryRead<global::UnityEngine.Camera>(out var _p0_UnityEngine_Camera))
            {
                var _arg1 = _lastArg = _argCount > 1 ? _context.GetArgument(1) : global::Lua.LuaValue.Nil;
                _lastArgPos = 1; _expectedType = typeof(global::UnityEngine.Vector3);
                if (_arg1.TryRead<global::UnityEngine.Vector3>(out var _p1_UnityEngine_Vector3))
                {
                    if (_argCount == 2)
                    {
                        var camera = _p0_UnityEngine_Camera;
                        var world = _p1_UnityEngine_Vector3;
                        var _ret0 = global::UnityEditor.HandleUtility.WorldToGUIPointWithDepth(camera, world);
                        var _factory = _context.GetObjectFactory();
                        var _lret0 = _factory.Bind(_ret0);
                        var _retCount = _context.Return(_lret0);
                        return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                    }
                }
            }
            throw new global::Lua.LuaRuntimeException(_context.Thread, $"{"WorldToGUIPointWithDepth"}: invalid argument #{_lastArgPos}: {_lastArg} ({_lastArg.Type}), expected: {_expectedType.FullName}", 2);
        });
        private static readonly global::Lua.LuaFunction __index = new(global::Lua.Runtime.Metamethods.Index, (_context, _) =>
        {
            var _this = _context.GetArgument<LuaHandleUtilityType>(0);
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
            var _this = _context.GetArgument<LuaHandleUtilityType>(0);
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
                case "new": _value = _LuaHandleUtility_new; return true;
                case "AddControl": _value = _LuaHandleUtility_AddControl; return true;
                case "AddDefaultControl": _value = _LuaHandleUtility_AddDefaultControl; return true;
                case "CalcLineTranslation": _value = _LuaHandleUtility_CalcLineTranslation; return true;
                case "ClosestPointToArc": _value = _LuaHandleUtility_ClosestPointToArc; return true;
                case "ClosestPointToDisc": _value = _LuaHandleUtility_ClosestPointToDisc; return true;
                case "ClosestPointToPolyLine": _value = _LuaHandleUtility_ClosestPointToPolyLine; return true;
                case "DecodeSelectionId": _value = _LuaHandleUtility_DecodeSelectionId; return true;
                case "DistancePointBezier": _value = _LuaHandleUtility_DistancePointBezier; return true;
                case "DistancePointLine": _value = _LuaHandleUtility_DistancePointLine; return true;
                case "DistancePointToLine": _value = _LuaHandleUtility_DistancePointToLine; return true;
                case "DistancePointToLineSegment": _value = _LuaHandleUtility_DistancePointToLineSegment; return true;
                case "DistanceToArc": _value = _LuaHandleUtility_DistanceToArc; return true;
                case "DistanceToCircle": _value = _LuaHandleUtility_DistanceToCircle; return true;
                case "DistanceToCone": _value = _LuaHandleUtility_DistanceToCone; return true;
                case "DistanceToCube": _value = _LuaHandleUtility_DistanceToCube; return true;
                case "DistanceToDisc": _value = _LuaHandleUtility_DistanceToDisc; return true;
                case "DistanceToLine": _value = _LuaHandleUtility_DistanceToLine; return true;
                case "DistanceToPolyLine": _value = _LuaHandleUtility_DistanceToPolyLine; return true;
                case "DistanceToRectangle": _value = _LuaHandleUtility_DistanceToRectangle; return true;
                case "EncodeSelectionId": _value = _LuaHandleUtility_EncodeSelectionId; return true;
                case "GetHandleSize": _value = _LuaHandleUtility_GetHandleSize; return true;
                case "GetPickingIncludeExcludeList": _value = _LuaHandleUtility_GetPickingIncludeExcludeList; return true;
                case "GetSelectionOutlineIncludeExcludeList": _value = _LuaHandleUtility_GetSelectionOutlineIncludeExcludeList; return true;
                case "GUIPointToScreenPixelCoordinate": _value = _LuaHandleUtility_GUIPointToScreenPixelCoordinate; return true;
                case "GUIPointToWorldRay": _value = _LuaHandleUtility_GUIPointToWorldRay; return true;
                case "PickGameObject": _value = _LuaHandleUtility_PickGameObject; return true;
                case "PickRectObjects": _value = _LuaHandleUtility_PickRectObjects; return true;
                case "PointOnLineParameter": _value = _LuaHandleUtility_PointOnLineParameter; return true;
                case "PopCamera": _value = _LuaHandleUtility_PopCamera; return true;
                case "ProjectPointLine": _value = _LuaHandleUtility_ProjectPointLine; return true;
                case "PushCamera": _value = _LuaHandleUtility_PushCamera; return true;
                case "RaySnap": _value = _LuaHandleUtility_RaySnap; return true;
                case "RegisterRenderPickingCallback": _value = _LuaHandleUtility_RegisterRenderPickingCallback; return true;
                case "Repaint": _value = _LuaHandleUtility_Repaint; return true;
                case "UnregisterRenderPickingCallback": _value = _LuaHandleUtility_UnregisterRenderPickingCallback; return true;
                case "WorldPointToSizedRect": _value = _LuaHandleUtility_WorldPointToSizedRect; return true;
                case "WorldToGUIPoint": _value = _LuaHandleUtility_WorldToGUIPoint; return true;
                case "WorldToGUIPointWithDepth": _value = _LuaHandleUtility_WorldToGUIPointWithDepth; return true;
                case "acceleration": _value = new global::Lua.LuaValue(global::UnityEditor.HandleUtility.acceleration); return true;
                case "handleMaterial": _value = _factory.Bind(global::UnityEditor.HandleUtility.handleMaterial); return true;
                case "nearestControl": _value = new global::Lua.LuaValue(global::UnityEditor.HandleUtility.nearestControl); return true;
                case "niceMouseDelta": _value = new global::Lua.LuaValue(global::UnityEditor.HandleUtility.niceMouseDelta); return true;
                case "niceMouseDeltaZoom": _value = new global::Lua.LuaValue(global::UnityEditor.HandleUtility.niceMouseDeltaZoom); return true;
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
                case "nearestControl": global::UnityEditor.HandleUtility.nearestControl = _value.Read<global::System.Int32>();  return true;
                default: return false;
            }
        }
    }
}
#pragma warning restore 0109, 0162, 0168, 0219
#endif
