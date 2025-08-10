
// --------------------------------------------------------------
// GENERATED FILE ----> DO NOT EDIT <---- CHANGES WILL BE LOST !!
// --------------------------------------------------------------

#if UNITY_6000_1_OR_NEWER && !(UNITY_6000_2_OR_NEWER)
#pragma warning disable 0109, 0162, 0168, 0219
using Luny;

namespace Luny.UnityEditor
{
    public sealed class LuaSerializedProperty : global::Luny.ILuaObject<global::UnityEditor.SerializedProperty>
    {
        public new static global::Lua.LuaValue Bind(global::UnityEditor.SerializedProperty instance) => new LuaSerializedProperty(instance);
        public new static global::Lua.LuaValue Bind(global::System.Object instance) => Bind((global::UnityEditor.SerializedProperty)instance);
        public new static global::Lua.LuaValue Bind(global::System.Collections.Generic.IList<global::UnityEditor.SerializedProperty> instances) =>
            new global::Luny.LuaList<global::UnityEditor.SerializedProperty>(instances);
        public new static global::Lua.LuaValue Bind(global::System.Collections.Generic.IList<global::System.Object> instances) =>
            new global::Luny.LuaList<global::UnityEditor.SerializedProperty>(instances);
        private LuaSerializedProperty(global::UnityEditor.SerializedProperty instance) => m_Instance = instance;
        public static implicit operator global::Lua.LuaValue(LuaSerializedProperty value) => new(value);
        private global::UnityEditor.SerializedProperty m_Instance;
        public global::UnityEditor.SerializedProperty Instance => m_Instance;
        public new global::System.Type BindType => typeof(global::UnityEditor.SerializedProperty);
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

        private static readonly global::Lua.LuaFunction _LuaSerializedProperty_ClearArray = new global::Lua.LuaFunction("ClearArray", (_context, _) =>
        {
            global::Lua.LuaValue _lastArg = default;
            global::System.Int32 _lastArgPos = default;
            global::System.Type _expectedType = default;
            var _argCount = _context.ArgumentCount;
            var _this = _context.GetArgument<LuaSerializedProperty>(0);
            if (_argCount == 1)
            {
                _this.Instance.ClearArray();
                var _retCount = _context.Return();
                return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
            }
            throw new global::Lua.LuaRuntimeException(_context.Thread, $"{"ClearArray"}: invalid argument #{_lastArgPos}: {_lastArg} ({_lastArg.Type}), expected: {_expectedType.FullName}", 2);
        });
        private static readonly global::Lua.LuaFunction _LuaSerializedProperty_Copy = new global::Lua.LuaFunction("Copy", (_context, _) =>
        {
            global::Lua.LuaValue _lastArg = default;
            global::System.Int32 _lastArgPos = default;
            global::System.Type _expectedType = default;
            var _argCount = _context.ArgumentCount;
            var _this = _context.GetArgument<LuaSerializedProperty>(0);
            if (_argCount == 1)
            {
                var _ret0 = _this.Instance.Copy();
                var _factory = _context.GetObjectFactory();
                var _lret0 = _factory.Bind(_ret0);
                var _retCount = _context.Return(_lret0);
                return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
            }
            throw new global::Lua.LuaRuntimeException(_context.Thread, $"{"Copy"}: invalid argument #{_lastArgPos}: {_lastArg} ({_lastArg.Type}), expected: {_expectedType.FullName}", 2);
        });
        private static readonly global::Lua.LuaFunction _LuaSerializedProperty_CountInProperty = new global::Lua.LuaFunction("CountInProperty", (_context, _) =>
        {
            global::Lua.LuaValue _lastArg = default;
            global::System.Int32 _lastArgPos = default;
            global::System.Type _expectedType = default;
            var _argCount = _context.ArgumentCount;
            var _this = _context.GetArgument<LuaSerializedProperty>(0);
            if (_argCount == 1)
            {
                var _ret0 = _this.Instance.CountInProperty();
                var _lret0 = new global::Lua.LuaValue(_ret0);
                var _retCount = _context.Return(_lret0);
                return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
            }
            throw new global::Lua.LuaRuntimeException(_context.Thread, $"{"CountInProperty"}: invalid argument #{_lastArgPos}: {_lastArg} ({_lastArg.Type}), expected: {_expectedType.FullName}", 2);
        });
        private static readonly global::Lua.LuaFunction _LuaSerializedProperty_CountRemaining = new global::Lua.LuaFunction("CountRemaining", (_context, _) =>
        {
            global::Lua.LuaValue _lastArg = default;
            global::System.Int32 _lastArgPos = default;
            global::System.Type _expectedType = default;
            var _argCount = _context.ArgumentCount;
            var _this = _context.GetArgument<LuaSerializedProperty>(0);
            if (_argCount == 1)
            {
                var _ret0 = _this.Instance.CountRemaining();
                var _lret0 = new global::Lua.LuaValue(_ret0);
                var _retCount = _context.Return(_lret0);
                return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
            }
            throw new global::Lua.LuaRuntimeException(_context.Thread, $"{"CountRemaining"}: invalid argument #{_lastArgPos}: {_lastArg} ({_lastArg.Type}), expected: {_expectedType.FullName}", 2);
        });
        private static readonly global::Lua.LuaFunction _LuaSerializedProperty_DeleteArrayElementAtIndex = new global::Lua.LuaFunction("DeleteArrayElementAtIndex", (_context, _) =>
        {
            global::Lua.LuaValue _lastArg = default;
            global::System.Int32 _lastArgPos = default;
            global::System.Type _expectedType = default;
            var _argCount = _context.ArgumentCount;
            var _this = _context.GetArgument<LuaSerializedProperty>(0);
            var _arg0 = _lastArg = _argCount > 1 ? _context.GetArgument(1) : global::Lua.LuaValue.Nil;
            _lastArgPos = 0; _expectedType = typeof(global::System.Int32);
            if (_arg0.TryRead<global::System.Int32>(out var _p0_System_Int32))
            {
                if (_argCount == 2)
                {
                    var index = _p0_System_Int32;
                    _this.Instance.DeleteArrayElementAtIndex(index);
                    var _retCount = _context.Return();
                    return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                }
            }
            throw new global::Lua.LuaRuntimeException(_context.Thread, $"{"DeleteArrayElementAtIndex"}: invalid argument #{_lastArgPos}: {_lastArg} ({_lastArg.Type}), expected: {_expectedType.FullName}", 2);
        });
        private static readonly global::Lua.LuaFunction _LuaSerializedProperty_DeleteCommand = new global::Lua.LuaFunction("DeleteCommand", (_context, _) =>
        {
            global::Lua.LuaValue _lastArg = default;
            global::System.Int32 _lastArgPos = default;
            global::System.Type _expectedType = default;
            var _argCount = _context.ArgumentCount;
            var _this = _context.GetArgument<LuaSerializedProperty>(0);
            if (_argCount == 1)
            {
                var _ret0 = _this.Instance.DeleteCommand();
                var _lret0 = new global::Lua.LuaValue(_ret0);
                var _retCount = _context.Return(_lret0);
                return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
            }
            throw new global::Lua.LuaRuntimeException(_context.Thread, $"{"DeleteCommand"}: invalid argument #{_lastArgPos}: {_lastArg} ({_lastArg.Type}), expected: {_expectedType.FullName}", 2);
        });
        private static readonly global::Lua.LuaFunction _LuaSerializedProperty_Dispose = new global::Lua.LuaFunction("Dispose", (_context, _) =>
        {
            global::Lua.LuaValue _lastArg = default;
            global::System.Int32 _lastArgPos = default;
            global::System.Type _expectedType = default;
            var _argCount = _context.ArgumentCount;
            var _this = _context.GetArgument<LuaSerializedProperty>(0);
            if (_argCount == 1)
            {
                _this.Instance.Dispose();
                var _retCount = _context.Return();
                return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
            }
            throw new global::Lua.LuaRuntimeException(_context.Thread, $"{"Dispose"}: invalid argument #{_lastArgPos}: {_lastArg} ({_lastArg.Type}), expected: {_expectedType.FullName}", 2);
        });
        private static readonly global::Lua.LuaFunction _LuaSerializedProperty_DuplicateCommand = new global::Lua.LuaFunction("DuplicateCommand", (_context, _) =>
        {
            global::Lua.LuaValue _lastArg = default;
            global::System.Int32 _lastArgPos = default;
            global::System.Type _expectedType = default;
            var _argCount = _context.ArgumentCount;
            var _this = _context.GetArgument<LuaSerializedProperty>(0);
            if (_argCount == 1)
            {
                var _ret0 = _this.Instance.DuplicateCommand();
                var _lret0 = new global::Lua.LuaValue(_ret0);
                var _retCount = _context.Return(_lret0);
                return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
            }
            throw new global::Lua.LuaRuntimeException(_context.Thread, $"{"DuplicateCommand"}: invalid argument #{_lastArgPos}: {_lastArg} ({_lastArg.Type}), expected: {_expectedType.FullName}", 2);
        });
        private static readonly global::Lua.LuaFunction _LuaSerializedProperty_FindPropertyRelative = new global::Lua.LuaFunction("FindPropertyRelative", (_context, _) =>
        {
            global::Lua.LuaValue _lastArg = default;
            global::System.Int32 _lastArgPos = default;
            global::System.Type _expectedType = default;
            var _argCount = _context.ArgumentCount;
            var _this = _context.GetArgument<LuaSerializedProperty>(0);
            var _arg0 = _lastArg = _argCount > 1 ? _context.GetArgument(1) : global::Lua.LuaValue.Nil;
            _lastArgPos = 0; _expectedType = typeof(global::System.String);
            if (_arg0.TryRead<global::System.String>(out var _p0_System_String))
            {
                if (_argCount == 2)
                {
                    var relativePropertyPath = _p0_System_String;
                    var _ret0 = _this.Instance.FindPropertyRelative(relativePropertyPath);
                    var _factory = _context.GetObjectFactory();
                    var _lret0 = _factory.Bind(_ret0);
                    var _retCount = _context.Return(_lret0);
                    return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                }
            }
            throw new global::Lua.LuaRuntimeException(_context.Thread, $"{"FindPropertyRelative"}: invalid argument #{_lastArgPos}: {_lastArg} ({_lastArg.Type}), expected: {_expectedType.FullName}", 2);
        });
        private static readonly global::Lua.LuaFunction _LuaSerializedProperty_GetArrayElementAtIndex = new global::Lua.LuaFunction("GetArrayElementAtIndex", (_context, _) =>
        {
            global::Lua.LuaValue _lastArg = default;
            global::System.Int32 _lastArgPos = default;
            global::System.Type _expectedType = default;
            var _argCount = _context.ArgumentCount;
            var _this = _context.GetArgument<LuaSerializedProperty>(0);
            var _arg0 = _lastArg = _argCount > 1 ? _context.GetArgument(1) : global::Lua.LuaValue.Nil;
            _lastArgPos = 0; _expectedType = typeof(global::System.Int32);
            if (_arg0.TryRead<global::System.Int32>(out var _p0_System_Int32))
            {
                if (_argCount == 2)
                {
                    var index = _p0_System_Int32;
                    var _ret0 = _this.Instance.GetArrayElementAtIndex(index);
                    var _factory = _context.GetObjectFactory();
                    var _lret0 = _factory.Bind(_ret0);
                    var _retCount = _context.Return(_lret0);
                    return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                }
            }
            throw new global::Lua.LuaRuntimeException(_context.Thread, $"{"GetArrayElementAtIndex"}: invalid argument #{_lastArgPos}: {_lastArg} ({_lastArg.Type}), expected: {_expectedType.FullName}", 2);
        });
        private static readonly global::Lua.LuaFunction _LuaSerializedProperty_GetEndProperty = new global::Lua.LuaFunction("GetEndProperty", (_context, _) =>
        {
            global::Lua.LuaValue _lastArg = default;
            global::System.Int32 _lastArgPos = default;
            global::System.Type _expectedType = default;
            var _argCount = _context.ArgumentCount;
            var _this = _context.GetArgument<LuaSerializedProperty>(0);
            if (_argCount == 1)
            {
                var _ret0 = _this.Instance.GetEndProperty();
                var _factory = _context.GetObjectFactory();
                var _lret0 = _factory.Bind(_ret0);
                var _retCount = _context.Return(_lret0);
                return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
            }
            var _arg0 = _lastArg = _argCount > 1 ? _context.GetArgument(1) : global::Lua.LuaValue.Nil;
            _lastArgPos = 0; _expectedType = typeof(global::System.Boolean);
            if (_arg0.TryRead<global::System.Boolean>(out var _p0_System_Boolean))
            {
                if (_argCount == 2)
                {
                    var includeInvisible = _p0_System_Boolean;
                    var _ret0 = _this.Instance.GetEndProperty(includeInvisible);
                    var _factory = _context.GetObjectFactory();
                    var _lret0 = _factory.Bind(_ret0);
                    var _retCount = _context.Return(_lret0);
                    return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                }
            }
            throw new global::Lua.LuaRuntimeException(_context.Thread, $"{"GetEndProperty"}: invalid argument #{_lastArgPos}: {_lastArg} ({_lastArg.Type}), expected: {_expectedType.FullName}", 2);
        });
        private static readonly global::Lua.LuaFunction _LuaSerializedProperty_GetFixedBufferElementAtIndex = new global::Lua.LuaFunction("GetFixedBufferElementAtIndex", (_context, _) =>
        {
            global::Lua.LuaValue _lastArg = default;
            global::System.Int32 _lastArgPos = default;
            global::System.Type _expectedType = default;
            var _argCount = _context.ArgumentCount;
            var _this = _context.GetArgument<LuaSerializedProperty>(0);
            var _arg0 = _lastArg = _argCount > 1 ? _context.GetArgument(1) : global::Lua.LuaValue.Nil;
            _lastArgPos = 0; _expectedType = typeof(global::System.Int32);
            if (_arg0.TryRead<global::System.Int32>(out var _p0_System_Int32))
            {
                if (_argCount == 2)
                {
                    var index = _p0_System_Int32;
                    var _ret0 = _this.Instance.GetFixedBufferElementAtIndex(index);
                    var _factory = _context.GetObjectFactory();
                    var _lret0 = _factory.Bind(_ret0);
                    var _retCount = _context.Return(_lret0);
                    return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                }
            }
            throw new global::Lua.LuaRuntimeException(_context.Thread, $"{"GetFixedBufferElementAtIndex"}: invalid argument #{_lastArgPos}: {_lastArg} ({_lastArg.Type}), expected: {_expectedType.FullName}", 2);
        });
        private static readonly global::Lua.LuaFunction _LuaSerializedProperty_InsertArrayElementAtIndex = new global::Lua.LuaFunction("InsertArrayElementAtIndex", (_context, _) =>
        {
            global::Lua.LuaValue _lastArg = default;
            global::System.Int32 _lastArgPos = default;
            global::System.Type _expectedType = default;
            var _argCount = _context.ArgumentCount;
            var _this = _context.GetArgument<LuaSerializedProperty>(0);
            var _arg0 = _lastArg = _argCount > 1 ? _context.GetArgument(1) : global::Lua.LuaValue.Nil;
            _lastArgPos = 0; _expectedType = typeof(global::System.Int32);
            if (_arg0.TryRead<global::System.Int32>(out var _p0_System_Int32))
            {
                if (_argCount == 2)
                {
                    var index = _p0_System_Int32;
                    _this.Instance.InsertArrayElementAtIndex(index);
                    var _retCount = _context.Return();
                    return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                }
            }
            throw new global::Lua.LuaRuntimeException(_context.Thread, $"{"InsertArrayElementAtIndex"}: invalid argument #{_lastArgPos}: {_lastArg} ({_lastArg.Type}), expected: {_expectedType.FullName}", 2);
        });
        private static readonly global::Lua.LuaFunction _LuaSerializedProperty_MoveArrayElement = new global::Lua.LuaFunction("MoveArrayElement", (_context, _) =>
        {
            global::Lua.LuaValue _lastArg = default;
            global::System.Int32 _lastArgPos = default;
            global::System.Type _expectedType = default;
            var _argCount = _context.ArgumentCount;
            var _this = _context.GetArgument<LuaSerializedProperty>(0);
            var _arg0 = _lastArg = _argCount > 1 ? _context.GetArgument(1) : global::Lua.LuaValue.Nil;
            _lastArgPos = 0; _expectedType = typeof(global::System.Int32);
            if (_arg0.TryRead<global::System.Int32>(out var _p0_System_Int32))
            {
                var _arg1 = _lastArg = _argCount > 2 ? _context.GetArgument(2) : global::Lua.LuaValue.Nil;
                _lastArgPos = 1; _expectedType = typeof(global::System.Int32);
                if (_arg1.TryRead<global::System.Int32>(out var _p1_System_Int32))
                {
                    if (_argCount == 3)
                    {
                        var srcIndex = _p0_System_Int32;
                        var dstIndex = _p1_System_Int32;
                        var _ret0 = _this.Instance.MoveArrayElement(srcIndex, dstIndex);
                        var _lret0 = new global::Lua.LuaValue(_ret0);
                        var _retCount = _context.Return(_lret0);
                        return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                    }
                }
            }
            throw new global::Lua.LuaRuntimeException(_context.Thread, $"{"MoveArrayElement"}: invalid argument #{_lastArgPos}: {_lastArg} ({_lastArg.Type}), expected: {_expectedType.FullName}", 2);
        });
        private static readonly global::Lua.LuaFunction _LuaSerializedProperty_Next = new global::Lua.LuaFunction("Next", (_context, _) =>
        {
            global::Lua.LuaValue _lastArg = default;
            global::System.Int32 _lastArgPos = default;
            global::System.Type _expectedType = default;
            var _argCount = _context.ArgumentCount;
            var _this = _context.GetArgument<LuaSerializedProperty>(0);
            var _arg0 = _lastArg = _argCount > 1 ? _context.GetArgument(1) : global::Lua.LuaValue.Nil;
            _lastArgPos = 0; _expectedType = typeof(global::System.Boolean);
            if (_arg0.TryRead<global::System.Boolean>(out var _p0_System_Boolean))
            {
                if (_argCount == 2)
                {
                    var enterChildren = _p0_System_Boolean;
                    var _ret0 = _this.Instance.Next(enterChildren);
                    var _lret0 = new global::Lua.LuaValue(_ret0);
                    var _retCount = _context.Return(_lret0);
                    return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                }
            }
            throw new global::Lua.LuaRuntimeException(_context.Thread, $"{"Next"}: invalid argument #{_lastArgPos}: {_lastArg} ({_lastArg.Type}), expected: {_expectedType.FullName}", 2);
        });
        private static readonly global::Lua.LuaFunction _LuaSerializedProperty_NextVisible = new global::Lua.LuaFunction("NextVisible", (_context, _) =>
        {
            global::Lua.LuaValue _lastArg = default;
            global::System.Int32 _lastArgPos = default;
            global::System.Type _expectedType = default;
            var _argCount = _context.ArgumentCount;
            var _this = _context.GetArgument<LuaSerializedProperty>(0);
            var _arg0 = _lastArg = _argCount > 1 ? _context.GetArgument(1) : global::Lua.LuaValue.Nil;
            _lastArgPos = 0; _expectedType = typeof(global::System.Boolean);
            if (_arg0.TryRead<global::System.Boolean>(out var _p0_System_Boolean))
            {
                if (_argCount == 2)
                {
                    var enterChildren = _p0_System_Boolean;
                    var _ret0 = _this.Instance.NextVisible(enterChildren);
                    var _lret0 = new global::Lua.LuaValue(_ret0);
                    var _retCount = _context.Return(_lret0);
                    return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                }
            }
            throw new global::Lua.LuaRuntimeException(_context.Thread, $"{"NextVisible"}: invalid argument #{_lastArgPos}: {_lastArg} ({_lastArg.Type}), expected: {_expectedType.FullName}", 2);
        });
        private static readonly global::Lua.LuaFunction _LuaSerializedProperty_Reset = new global::Lua.LuaFunction("Reset", (_context, _) =>
        {
            global::Lua.LuaValue _lastArg = default;
            global::System.Int32 _lastArgPos = default;
            global::System.Type _expectedType = default;
            var _argCount = _context.ArgumentCount;
            var _this = _context.GetArgument<LuaSerializedProperty>(0);
            if (_argCount == 1)
            {
                _this.Instance.Reset();
                var _retCount = _context.Return();
                return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
            }
            throw new global::Lua.LuaRuntimeException(_context.Thread, $"{"Reset"}: invalid argument #{_lastArgPos}: {_lastArg} ({_lastArg.Type}), expected: {_expectedType.FullName}", 2);
        });
        private static readonly global::Lua.LuaFunction __index = new(global::Lua.Runtime.Metamethods.Index, (_context, _) =>
        {
            var _this = _context.GetArgument<LuaSerializedProperty>(0);
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
            var _this = _context.GetArgument<LuaSerializedProperty>(0);
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
                case "ClearArray": _value = _LuaSerializedProperty_ClearArray; return true;
                case "Copy": _value = _LuaSerializedProperty_Copy; return true;
                case "CountInProperty": _value = _LuaSerializedProperty_CountInProperty; return true;
                case "CountRemaining": _value = _LuaSerializedProperty_CountRemaining; return true;
                case "DeleteArrayElementAtIndex": _value = _LuaSerializedProperty_DeleteArrayElementAtIndex; return true;
                case "DeleteCommand": _value = _LuaSerializedProperty_DeleteCommand; return true;
                case "Dispose": _value = _LuaSerializedProperty_Dispose; return true;
                case "DuplicateCommand": _value = _LuaSerializedProperty_DuplicateCommand; return true;
                case "FindPropertyRelative": _value = _LuaSerializedProperty_FindPropertyRelative; return true;
                case "GetArrayElementAtIndex": _value = _LuaSerializedProperty_GetArrayElementAtIndex; return true;
                case "GetEndProperty": _value = _LuaSerializedProperty_GetEndProperty; return true;
                case "GetFixedBufferElementAtIndex": _value = _LuaSerializedProperty_GetFixedBufferElementAtIndex; return true;
                case "InsertArrayElementAtIndex": _value = _LuaSerializedProperty_InsertArrayElementAtIndex; return true;
                case "MoveArrayElement": _value = _LuaSerializedProperty_MoveArrayElement; return true;
                case "Next": _value = _LuaSerializedProperty_Next; return true;
                case "NextVisible": _value = _LuaSerializedProperty_NextVisible; return true;
                case "Reset": _value = _LuaSerializedProperty_Reset; return true;
                case "animationCurveValue": _value = _factory.Bind(Instance.animationCurveValue); return true;
                case "arrayElementType": _value = new global::Lua.LuaValue(Instance.arrayElementType); return true;
                case "arraySize": _value = new global::Lua.LuaValue(Instance.arraySize); return true;
                case "boolValue": _value = new global::Lua.LuaValue(Instance.boolValue); return true;
                case "boundsIntValue": _value = _factory.Bind(Instance.boundsIntValue); return true;
                case "boundsValue": _value = _factory.Bind(Instance.boundsValue); return true;
                case "boxedValue": _value = _factory.Bind(Instance.boxedValue); return true;
                case "colorValue": _value = _factory.Bind(Instance.colorValue); return true;
                case "contentHash": _value = new global::Lua.LuaValue(Instance.contentHash); return true;
                case "depth": _value = new global::Lua.LuaValue(Instance.depth); return true;
                case "displayName": _value = new global::Lua.LuaValue(Instance.displayName); return true;
                case "doubleValue": _value = new global::Lua.LuaValue(Instance.doubleValue); return true;
                case "editable": _value = new global::Lua.LuaValue(Instance.editable); return true;
                case "enumDisplayNames": _value = _factory.Bind(Instance.enumDisplayNames); return true;
                case "enumNames": _value = _factory.Bind(Instance.enumNames); return true;
                case "enumValueFlag": _value = new global::Lua.LuaValue(Instance.enumValueFlag); return true;
                case "enumValueIndex": _value = new global::Lua.LuaValue(Instance.enumValueIndex); return true;
                case "exposedReferenceValue": _value = _factory.Bind(Instance.exposedReferenceValue); return true;
                case "fixedBufferSize": _value = new global::Lua.LuaValue(Instance.fixedBufferSize); return true;
                case "floatValue": _value = new global::Lua.LuaValue(Instance.floatValue); return true;
                case "gradientValue": _value = _factory.Bind(Instance.gradientValue); return true;
                case "hasChildren": _value = new global::Lua.LuaValue(Instance.hasChildren); return true;
                case "hash128Value": _value = _factory.Bind(Instance.hash128Value); return true;
                case "hasMultipleDifferentValues": _value = new global::Lua.LuaValue(Instance.hasMultipleDifferentValues); return true;
                case "hasVisibleChildren": _value = new global::Lua.LuaValue(Instance.hasVisibleChildren); return true;
                case "intValue": _value = new global::Lua.LuaValue(Instance.intValue); return true;
                case "isAnimated": _value = new global::Lua.LuaValue(Instance.isAnimated); return true;
                case "isArray": _value = new global::Lua.LuaValue(Instance.isArray); return true;
                case "isDefaultOverride": _value = new global::Lua.LuaValue(Instance.isDefaultOverride); return true;
                case "isExpanded": _value = new global::Lua.LuaValue(Instance.isExpanded); return true;
                case "isFixedBuffer": _value = new global::Lua.LuaValue(Instance.isFixedBuffer); return true;
                case "isInstantiatedPrefab": _value = new global::Lua.LuaValue(Instance.isInstantiatedPrefab); return true;
                case "longValue": _value = new global::Lua.LuaValue(Instance.longValue); return true;
                case "managedReferenceFieldTypename": _value = new global::Lua.LuaValue(Instance.managedReferenceFieldTypename); return true;
                case "managedReferenceFullTypename": _value = new global::Lua.LuaValue(Instance.managedReferenceFullTypename); return true;
                case "managedReferenceId": _value = new global::Lua.LuaValue(Instance.managedReferenceId); return true;
                case "managedReferenceValue": _value = _factory.Bind(Instance.managedReferenceValue); return true;
                case "minArraySize": _value = new global::Lua.LuaValue(Instance.minArraySize); return true;
                case "name": _value = new global::Lua.LuaValue(Instance.name); return true;
                case "numericType": _value = new global::Lua.LuaValue((global::System.Int64)Instance.numericType); return true;
                case "objectReferenceInstanceIDValue": _value = new global::Lua.LuaValue(Instance.objectReferenceInstanceIDValue); return true;
                case "objectReferenceValue": _value = _factory.Bind(Instance.objectReferenceValue); return true;
                case "prefabOverride": _value = new global::Lua.LuaValue(Instance.prefabOverride); return true;
                case "propertyPath": _value = new global::Lua.LuaValue(Instance.propertyPath); return true;
                case "propertyType": _value = new global::Lua.LuaValue((global::System.Int64)Instance.propertyType); return true;
                case "quaternionValue": _value = _factory.Bind(Instance.quaternionValue); return true;
                case "rectIntValue": _value = _factory.Bind(Instance.rectIntValue); return true;
                case "rectValue": _value = _factory.Bind(Instance.rectValue); return true;
                case "serializedObject": _value = _factory.Bind(Instance.serializedObject); return true;
                case "stringValue": _value = new global::Lua.LuaValue(Instance.stringValue); return true;
                case "tooltip": _value = new global::Lua.LuaValue(Instance.tooltip); return true;
                case "type": _value = new global::Lua.LuaValue(Instance.type); return true;
                case "uintValue": _value = new global::Lua.LuaValue(Instance.uintValue); return true;
                case "ulongValue": _value = new global::Lua.LuaValue(Instance.ulongValue); return true;
                case "vector2IntValue": _value = _factory.Bind(Instance.vector2IntValue); return true;
                case "vector2Value": _value = _factory.Bind(Instance.vector2Value); return true;
                case "vector3IntValue": _value = _factory.Bind(Instance.vector3IntValue); return true;
                case "vector3Value": _value = _factory.Bind(Instance.vector3Value); return true;
                case "vector4Value": _value = _factory.Bind(Instance.vector4Value); return true;
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
                case "animationCurveValue": Instance.animationCurveValue = _value.Read<global::UnityEngine.AnimationCurve>();  return true;
                case "arraySize": Instance.arraySize = _value.Read<global::System.Int32>();  return true;
                case "boolValue": Instance.boolValue = _value.Read<global::System.Boolean>();  return true;
                case "boundsIntValue": Instance.boundsIntValue = _value.Read<global::UnityEngine.BoundsInt>();  return true;
                case "boundsValue": Instance.boundsValue = _value.Read<global::UnityEngine.Bounds>();  return true;
                case "boxedValue": Instance.boxedValue = _value.Read<global::System.Object>();  return true;
                case "colorValue": Instance.colorValue = _value.Read<global::UnityEngine.Color>();  return true;
                case "doubleValue": Instance.doubleValue = _value.Read<global::System.Double>();  return true;
                case "enumValueFlag": Instance.enumValueFlag = _value.Read<global::System.Int32>();  return true;
                case "enumValueIndex": Instance.enumValueIndex = _value.Read<global::System.Int32>();  return true;
                case "exposedReferenceValue": Instance.exposedReferenceValue = _value.Read<global::UnityEngine.Object>();  return true;
                case "floatValue": Instance.floatValue = _value.Read<global::System.Single>();  return true;
                case "gradientValue": Instance.gradientValue = _value.Read<global::UnityEngine.Gradient>();  return true;
                case "hash128Value": Instance.hash128Value = _value.Read<global::UnityEngine.Hash128>();  return true;
                case "intValue": Instance.intValue = _value.Read<global::System.Int32>();  return true;
                case "isExpanded": Instance.isExpanded = _value.Read<global::System.Boolean>();  return true;
                case "longValue": Instance.longValue = _value.Read<global::System.Int64>();  return true;
                case "managedReferenceId": Instance.managedReferenceId = _value.Read<global::System.Int64>();  return true;
                case "managedReferenceValue": Instance.managedReferenceValue = _value.Read<global::System.Object>();  return true;
                case "objectReferenceInstanceIDValue": Instance.objectReferenceInstanceIDValue = _value.Read<global::System.Int32>();  return true;
                case "objectReferenceValue": Instance.objectReferenceValue = _value.Read<global::UnityEngine.Object>();  return true;
                case "prefabOverride": Instance.prefabOverride = _value.Read<global::System.Boolean>();  return true;
                case "quaternionValue": Instance.quaternionValue = _value.Read<global::UnityEngine.Quaternion>();  return true;
                case "rectIntValue": Instance.rectIntValue = _value.Read<global::UnityEngine.RectInt>();  return true;
                case "rectValue": Instance.rectValue = _value.Read<global::UnityEngine.Rect>();  return true;
                case "stringValue": Instance.stringValue = _value.Read<global::System.String>();  return true;
                case "uintValue": Instance.uintValue = _value.Read<global::System.UInt32>();  return true;
                case "ulongValue": Instance.ulongValue = _value.Read<global::System.UInt64>();  return true;
                case "vector2IntValue": Instance.vector2IntValue = _value.Read<global::UnityEngine.Vector2Int>();  return true;
                case "vector2Value": Instance.vector2Value = _value.Read<global::UnityEngine.Vector2>();  return true;
                case "vector3IntValue": Instance.vector3IntValue = _value.Read<global::UnityEngine.Vector3Int>();  return true;
                case "vector3Value": Instance.vector3Value = _value.Read<global::UnityEngine.Vector3>();  return true;
                case "vector4Value": Instance.vector4Value = _value.Read<global::UnityEngine.Vector4>();  return true;
                default: return false;
            }
        }
    }
    public sealed class LuaSerializedPropertyType : global::Luny.ILuaStatic
    {
        public static global::Lua.LuaValue Bind() => new LuaSerializedPropertyType();
        private LuaSerializedPropertyType() {}
        public static implicit operator global::Lua.LuaValue(LuaSerializedPropertyType value) => new(value);
        public global::System.Type BindType => typeof(global::UnityEditor.SerializedProperty);
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

        private static readonly global::Lua.LuaFunction _LuaSerializedProperty_DataEquals = new global::Lua.LuaFunction("DataEquals", (_context, _) =>
        {
            global::Lua.LuaValue _lastArg = default;
            global::System.Int32 _lastArgPos = default;
            global::System.Type _expectedType = default;
            var _argCount = _context.ArgumentCount;
            var _arg0 = _lastArg = _argCount > 0 ? _context.GetArgument(0) : global::Lua.LuaValue.Nil;
            _lastArgPos = 0; _expectedType = typeof(global::Luny.UnityEditor.LuaSerializedProperty);
            if (_arg0.TryRead<global::Luny.UnityEditor.LuaSerializedProperty>(out var _p0_UnityEditor_SerializedProperty))
            {
                var _arg1 = _lastArg = _argCount > 1 ? _context.GetArgument(1) : global::Lua.LuaValue.Nil;
                _lastArgPos = 1; _expectedType = typeof(global::Luny.UnityEditor.LuaSerializedProperty);
                if (_arg1.TryRead<global::Luny.UnityEditor.LuaSerializedProperty>(out var _p1_UnityEditor_SerializedProperty))
                {
                    if (_argCount == 2)
                    {
                        var x = _p0_UnityEditor_SerializedProperty.Instance;
                        var y = _p1_UnityEditor_SerializedProperty.Instance;
                        var _ret0 = global::UnityEditor.SerializedProperty.DataEquals(x, y);
                        var _lret0 = new global::Lua.LuaValue(_ret0);
                        var _retCount = _context.Return(_lret0);
                        return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                    }
                }
            }
            throw new global::Lua.LuaRuntimeException(_context.Thread, $"{"DataEquals"}: invalid argument #{_lastArgPos}: {_lastArg} ({_lastArg.Type}), expected: {_expectedType.FullName}", 2);
        });
        private static readonly global::Lua.LuaFunction _LuaSerializedProperty_EqualContents = new global::Lua.LuaFunction("EqualContents", (_context, _) =>
        {
            global::Lua.LuaValue _lastArg = default;
            global::System.Int32 _lastArgPos = default;
            global::System.Type _expectedType = default;
            var _argCount = _context.ArgumentCount;
            var _arg0 = _lastArg = _argCount > 0 ? _context.GetArgument(0) : global::Lua.LuaValue.Nil;
            _lastArgPos = 0; _expectedType = typeof(global::Luny.UnityEditor.LuaSerializedProperty);
            if (_arg0.TryRead<global::Luny.UnityEditor.LuaSerializedProperty>(out var _p0_UnityEditor_SerializedProperty))
            {
                var _arg1 = _lastArg = _argCount > 1 ? _context.GetArgument(1) : global::Lua.LuaValue.Nil;
                _lastArgPos = 1; _expectedType = typeof(global::Luny.UnityEditor.LuaSerializedProperty);
                if (_arg1.TryRead<global::Luny.UnityEditor.LuaSerializedProperty>(out var _p1_UnityEditor_SerializedProperty))
                {
                    if (_argCount == 2)
                    {
                        var x = _p0_UnityEditor_SerializedProperty.Instance;
                        var y = _p1_UnityEditor_SerializedProperty.Instance;
                        var _ret0 = global::UnityEditor.SerializedProperty.EqualContents(x, y);
                        var _lret0 = new global::Lua.LuaValue(_ret0);
                        var _retCount = _context.Return(_lret0);
                        return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                    }
                }
            }
            throw new global::Lua.LuaRuntimeException(_context.Thread, $"{"EqualContents"}: invalid argument #{_lastArgPos}: {_lastArg} ({_lastArg.Type}), expected: {_expectedType.FullName}", 2);
        });
        private static readonly global::Lua.LuaFunction __index = new(global::Lua.Runtime.Metamethods.Index, (_context, _) =>
        {
            var _this = _context.GetArgument<LuaSerializedPropertyType>(0);
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
            var _this = _context.GetArgument<LuaSerializedPropertyType>(0);
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
                case "DataEquals": _value = _LuaSerializedProperty_DataEquals; return true;
                case "EqualContents": _value = _LuaSerializedProperty_EqualContents; return true;
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
