
// --------------------------------------------------------------
// GENERATED FILE ----> DO NOT EDIT <---- CHANGES WILL BE LOST !!
// --------------------------------------------------------------

#if UNITY_6000_2_OR_NEWER && !(UNITY_6000_3_OR_NEWER)
#pragma warning disable 0109, 0162, 0168, 0219
using Luny;

namespace LunyEditor.UnityEditor
{
    public sealed class LuaGlobalObjectId : global::Luny.ILuaValueType<global::UnityEditor.GlobalObjectId>
    {
        public new static global::Lua.LuaValue Bind(in global::UnityEditor.GlobalObjectId instance) => new LuaGlobalObjectId(instance);
        public new static global::Lua.LuaValue Bind(global::System.Object instance) => Bind((global::UnityEditor.GlobalObjectId)instance);
        public new static global::Lua.LuaValue Bind(global::System.Collections.Generic.IList<global::UnityEditor.GlobalObjectId> instances) =>
            new global::Luny.LuaList<global::UnityEditor.GlobalObjectId>(instances);
        public new static global::Lua.LuaValue Bind(global::System.Collections.Generic.IList<global::System.Object> instances) =>
            new global::Luny.LuaList<global::UnityEditor.GlobalObjectId>(instances);
        private LuaGlobalObjectId(in global::UnityEditor.GlobalObjectId value) => m_Value = value;
        public static implicit operator global::Lua.LuaValue(LuaGlobalObjectId value) => new(value);
        private global::UnityEditor.GlobalObjectId m_Value;
        public global::UnityEditor.GlobalObjectId Value { get => m_Value; set => m_Value = value; }
        public ref global::UnityEditor.GlobalObjectId ValueRef => ref m_Value;
        public global::System.Type BindType => typeof(global::UnityEditor.GlobalObjectId);
        public override global::System.String ToString() => m_Value.ToString();
#if UNITY_EDITOR
        [global::UnityEngine.RuntimeInitializeOnLoadMethod(global::UnityEngine.RuntimeInitializeLoadType.SubsystemRegistration)]
        private static void ResetStaticFields() => s_Metatable = null;
#endif

        private static readonly global::Lua.LuaFunction _LuaGlobalObjectId_CompareTo = new global::Lua.LuaFunction("CompareTo", (_context, _) =>
        {
            global::Lua.LuaValue _lastArg = default;
            global::System.Int32 _lastArgPos = default;
            global::System.Type _expectedType = default;
            var _argCount = _context.ArgumentCount;
            var _this = _context.GetArgument<LuaGlobalObjectId>(0);
            var _arg0 = _lastArg = _argCount > 1 ? _context.GetArgument(1) : global::Lua.LuaValue.Nil;
            _lastArgPos = 0; _expectedType = typeof(global::LunyEditor.UnityEditor.LuaGlobalObjectId);
            if (_arg0.TryRead<global::LunyEditor.UnityEditor.LuaGlobalObjectId>(out var _p0_UnityEditor_GlobalObjectId))
            {
                if (_argCount == 2)
                {
                    var other = _p0_UnityEditor_GlobalObjectId.Value;
                    var _ret0 = _this.m_Value.CompareTo(other);
                    var _lret0 = new global::Lua.LuaValue(_ret0);
                    var _retCount = _context.Return(_lret0);
                    return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                }
            }
            throw new global::Lua.LuaRuntimeException(_context.Thread, $"{"CompareTo"}: invalid argument #{_lastArgPos}: {_lastArg} ({_lastArg.Type}), expected: {_expectedType.FullName}", 2);
        });
        private static readonly global::Lua.LuaFunction _LuaGlobalObjectId_Equals = new global::Lua.LuaFunction("Equals", (_context, _) =>
        {
            global::Lua.LuaValue _lastArg = default;
            global::System.Int32 _lastArgPos = default;
            global::System.Type _expectedType = default;
            var _argCount = _context.ArgumentCount;
            var _this = _context.GetArgument<LuaGlobalObjectId>(0);
            var _arg0 = _lastArg = _argCount > 1 ? _context.GetArgument(1) : global::Lua.LuaValue.Nil;
            _lastArgPos = 0; _expectedType = typeof(global::LunyEditor.UnityEditor.LuaGlobalObjectId);
            if (_arg0.TryRead<global::LunyEditor.UnityEditor.LuaGlobalObjectId>(out var _p0_UnityEditor_GlobalObjectId))
            {
                if (_argCount == 2)
                {
                    var other = _p0_UnityEditor_GlobalObjectId.Value;
                    var _ret0 = _this.m_Value.Equals(other);
                    var _lret0 = new global::Lua.LuaValue(_ret0);
                    var _retCount = _context.Return(_lret0);
                    return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                }
            }
            throw new global::Lua.LuaRuntimeException(_context.Thread, $"{"Equals"}: invalid argument #{_lastArgPos}: {_lastArg} ({_lastArg.Type}), expected: {_expectedType.FullName}", 2);
        });
        private static readonly global::Lua.LuaFunction _LuaGlobalObjectId_ToString = new global::Lua.LuaFunction("ToString", (_context, _) =>
        {
            global::Lua.LuaValue _lastArg = default;
            global::System.Int32 _lastArgPos = default;
            global::System.Type _expectedType = default;
            var _argCount = _context.ArgumentCount;
            var _this = _context.GetArgument<LuaGlobalObjectId>(0);
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
            var _this = _context.GetArgument<LuaGlobalObjectId>(0);
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
            var _this = _context.GetArgument<LuaGlobalObjectId>(0);
            var _key = _context.GetArgument(1);
            var _value = _context.GetArgument(2);
            if (_key.Type == global::Lua.LuaValueType.Number && _key.TryRead<global::System.Int32>(out var _index) && _this.TrySetLuaValue(_index, _value))
                return new global::System.Threading.Tasks.ValueTask<global::System.Int32>(_context.Return(_value));
            if (_key.Type == global::Lua.LuaValueType.String && _this.TrySetLuaValue(_key.Read<global::System.String>(), _value))
                return new global::System.Threading.Tasks.ValueTask<global::System.Int32>(_context.Return(_value));
            throw new global::Lua.LuaRuntimeException(_context.Thread, $"attempt to assign to unknown '{_key}' on '{_this}'", 2);
        });
        private static global::Lua.LuaTable CreateMetatable()
        {
            var metatable = new global::Lua.LuaTable(0, 4);
            metatable[global::Lua.Runtime.Metamethods.Index] = __index;
            metatable[global::Lua.Runtime.Metamethods.NewIndex] = __newindex;
            metatable[global::Lua.Runtime.Metamethods.Concat] = global::Luny.LuaMetatable.ConcatMetamethod;
            metatable[global::Lua.Runtime.Metamethods.ToString] = global::Luny.LuaMetatable.ToStringMetamethod;
            return metatable;
        }
        private static global::Lua.LuaTable s_Metatable;
        public global::Lua.LuaTable Metatable
        {
            get => s_Metatable ??= CreateMetatable();
            set => throw new global::System.NotSupportedException("LuaObject metatables cannot be modified");
        }
        global::System.Span<global::Lua.LuaValue> global::Lua.ILuaUserData.UserValues => default;

        public global::System.Boolean TryGetLuaValue(global::System.Int32 _key, out global::Lua.LuaValue _value, global::Luny.ILuaObjectFactory _factory)
        {
            _value = global::Lua.LuaValue.Nil; return false;
        }
        public global::System.Boolean TryGetLuaValue(global::System.String _key, out global::Lua.LuaValue _value, global::Luny.ILuaObjectFactory _factory)
        {
            switch (_key)
            {
                case "CompareTo": _value = _LuaGlobalObjectId_CompareTo; return true;
                case "Equals": _value = _LuaGlobalObjectId_Equals; return true;
                case "ToString": _value = _LuaGlobalObjectId_ToString; return true;
                case "assetGUID": _value = global::LunyEditor.UnityEditor.LuaGUID.Bind(m_Value.assetGUID); return true;
                case "identifierType": _value = new global::Lua.LuaValue(m_Value.identifierType); return true;
                case "targetObjectId": _value = new global::Lua.LuaValue(m_Value.targetObjectId); return true;
                case "targetPrefabId": _value = new global::Lua.LuaValue(m_Value.targetPrefabId); return true;
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
    public sealed class LuaGlobalObjectIdType : global::Luny.ILuaStatic
    {
        public static global::Lua.LuaValue Bind() => new LuaGlobalObjectIdType();
        private LuaGlobalObjectIdType() {}
        public static implicit operator global::Lua.LuaValue(LuaGlobalObjectIdType value) => new(value);
        public global::System.Type BindType => typeof(global::UnityEditor.GlobalObjectId);
        public override global::System.String ToString() => BindType.FullName;
#if UNITY_EDITOR
        [global::UnityEngine.RuntimeInitializeOnLoadMethod(global::UnityEngine.RuntimeInitializeLoadType.SubsystemRegistration)]
        private static void ResetStaticFields() => s_Metatable = null;
#endif

        private static readonly global::Lua.LuaFunction _LuaGlobalObjectId_GetGlobalObjectIdSlow = new global::Lua.LuaFunction("GetGlobalObjectIdSlow", (_context, _) =>
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
                    var instanceId = _p0_System_Int32;
                    var _ret0 = global::UnityEditor.GlobalObjectId.GetGlobalObjectIdSlow(instanceId);
                    var _lret0 = global::LunyEditor.UnityEditor.LuaGlobalObjectId.Bind(_ret0);
                    var _retCount = _context.Return(_lret0);
                    return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                }
            }
            _lastArgPos = 0; _expectedType = typeof(global::Luny.UnityEngine.LuaUnityObject);
            if (_arg0.TryRead<global::Luny.UnityEngine.LuaUnityObject>(out var _p0_UnityEngine_Object))
            {
                if (_argCount == 1)
                {
                    var targetObject = _p0_UnityEngine_Object.Instance;
                    var _ret0 = global::UnityEditor.GlobalObjectId.GetGlobalObjectIdSlow(targetObject);
                    var _lret0 = global::LunyEditor.UnityEditor.LuaGlobalObjectId.Bind(_ret0);
                    var _retCount = _context.Return(_lret0);
                    return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                }
            }
            throw new global::Lua.LuaRuntimeException(_context.Thread, $"{"GetGlobalObjectIdSlow"}: invalid argument #{_lastArgPos}: {_lastArg} ({_lastArg.Type}), expected: {_expectedType.FullName}", 2);
        });
        private static readonly global::Lua.LuaFunction _LuaGlobalObjectId_GetGlobalObjectIdsSlow = new global::Lua.LuaFunction("GetGlobalObjectIdsSlow", (_context, _) =>
        {
            global::Lua.LuaValue _lastArg = default;
            global::System.Int32 _lastArgPos = default;
            global::System.Type _expectedType = default;
            var _argCount = _context.ArgumentCount;
            var _arg0 = _lastArg = _argCount > 0 ? _context.GetArgument(0) : global::Lua.LuaValue.Nil;
            _lastArgPos = 0; _expectedType = typeof(global::System.Int32[]);
            if (_arg0.TryReadArray<global::System.Int32>(out var _p0_System_Int32Array))
            {
                var _arg1 = _lastArg = _argCount > 1 ? _context.GetArgument(1) : global::Lua.LuaValue.Nil;
                _lastArgPos = 1; _expectedType = typeof(global::UnityEditor.GlobalObjectId[]);
                if (_arg1.TryReadArray<global::UnityEditor.GlobalObjectId>(out var _p1_UnityEditor_GlobalObjectIdArray))
                {
                    if (_argCount == 2)
                    {
                        var instanceIds = _p0_System_Int32Array;
                        var outputIdentifiers = _p1_UnityEditor_GlobalObjectIdArray;
                        global::UnityEditor.GlobalObjectId.GetGlobalObjectIdsSlow(instanceIds, outputIdentifiers);
                        var _retCount = _context.Return();
                        return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                    }
                }
            }
            _lastArgPos = 0; _expectedType = typeof(global::UnityEngine.Object[]);
            if (_arg0.TryReadArray<global::UnityEngine.Object>(out var _p0_UnityEngine_ObjectArray))
            {
                var _arg1 = _lastArg = _argCount > 1 ? _context.GetArgument(1) : global::Lua.LuaValue.Nil;
                _lastArgPos = 1; _expectedType = typeof(global::UnityEditor.GlobalObjectId[]);
                if (_arg1.TryReadArray<global::UnityEditor.GlobalObjectId>(out var _p1_UnityEditor_GlobalObjectIdArray))
                {
                    if (_argCount == 2)
                    {
                        var objects = _p0_UnityEngine_ObjectArray;
                        var outputIdentifiers = _p1_UnityEditor_GlobalObjectIdArray;
                        global::UnityEditor.GlobalObjectId.GetGlobalObjectIdsSlow(objects, outputIdentifiers);
                        var _retCount = _context.Return();
                        return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                    }
                }
            }
            throw new global::Lua.LuaRuntimeException(_context.Thread, $"{"GetGlobalObjectIdsSlow"}: invalid argument #{_lastArgPos}: {_lastArg} ({_lastArg.Type}), expected: {_expectedType.FullName}", 2);
        });
        private static readonly global::Lua.LuaFunction _LuaGlobalObjectId_GlobalObjectIdentifiersToInstanceIDsSlow = new global::Lua.LuaFunction("GlobalObjectIdentifiersToInstanceIDsSlow", (_context, _) =>
        {
            global::Lua.LuaValue _lastArg = default;
            global::System.Int32 _lastArgPos = default;
            global::System.Type _expectedType = default;
            var _argCount = _context.ArgumentCount;
            var _arg0 = _lastArg = _argCount > 0 ? _context.GetArgument(0) : global::Lua.LuaValue.Nil;
            _lastArgPos = 0; _expectedType = typeof(global::UnityEditor.GlobalObjectId[]);
            if (_arg0.TryReadArray<global::UnityEditor.GlobalObjectId>(out var _p0_UnityEditor_GlobalObjectIdArray))
            {
                var _arg1 = _lastArg = _argCount > 1 ? _context.GetArgument(1) : global::Lua.LuaValue.Nil;
                _lastArgPos = 1; _expectedType = typeof(global::System.Int32[]);
                if (_arg1.TryReadArray<global::System.Int32>(out var _p1_System_Int32Array))
                {
                    if (_argCount == 2)
                    {
                        var identifiers = _p0_UnityEditor_GlobalObjectIdArray;
                        var outputInstanceIDs = _p1_System_Int32Array;
                        global::UnityEditor.GlobalObjectId.GlobalObjectIdentifiersToInstanceIDsSlow(identifiers, outputInstanceIDs);
                        var _retCount = _context.Return();
                        return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                    }
                }
            }
            throw new global::Lua.LuaRuntimeException(_context.Thread, $"{"GlobalObjectIdentifiersToInstanceIDsSlow"}: invalid argument #{_lastArgPos}: {_lastArg} ({_lastArg.Type}), expected: {_expectedType.FullName}", 2);
        });
        private static readonly global::Lua.LuaFunction _LuaGlobalObjectId_GlobalObjectIdentifiersToObjectsSlow = new global::Lua.LuaFunction("GlobalObjectIdentifiersToObjectsSlow", (_context, _) =>
        {
            global::Lua.LuaValue _lastArg = default;
            global::System.Int32 _lastArgPos = default;
            global::System.Type _expectedType = default;
            var _argCount = _context.ArgumentCount;
            var _arg0 = _lastArg = _argCount > 0 ? _context.GetArgument(0) : global::Lua.LuaValue.Nil;
            _lastArgPos = 0; _expectedType = typeof(global::UnityEditor.GlobalObjectId[]);
            if (_arg0.TryReadArray<global::UnityEditor.GlobalObjectId>(out var _p0_UnityEditor_GlobalObjectIdArray))
            {
                var _arg1 = _lastArg = _argCount > 1 ? _context.GetArgument(1) : global::Lua.LuaValue.Nil;
                _lastArgPos = 1; _expectedType = typeof(global::UnityEngine.Object[]);
                if (_arg1.TryReadArray<global::UnityEngine.Object>(out var _p1_UnityEngine_ObjectArray))
                {
                    if (_argCount == 2)
                    {
                        var identifiers = _p0_UnityEditor_GlobalObjectIdArray;
                        var outputObjects = _p1_UnityEngine_ObjectArray;
                        global::UnityEditor.GlobalObjectId.GlobalObjectIdentifiersToObjectsSlow(identifiers, outputObjects);
                        var _retCount = _context.Return();
                        return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                    }
                }
            }
            throw new global::Lua.LuaRuntimeException(_context.Thread, $"{"GlobalObjectIdentifiersToObjectsSlow"}: invalid argument #{_lastArgPos}: {_lastArg} ({_lastArg.Type}), expected: {_expectedType.FullName}", 2);
        });
        private static readonly global::Lua.LuaFunction _LuaGlobalObjectId_GlobalObjectIdentifierToInstanceIDSlow = new global::Lua.LuaFunction("GlobalObjectIdentifierToInstanceIDSlow", (_context, _) =>
        {
            global::Lua.LuaValue _lastArg = default;
            global::System.Int32 _lastArgPos = default;
            global::System.Type _expectedType = default;
            var _argCount = _context.ArgumentCount;
            var _arg0 = _lastArg = _argCount > 0 ? _context.GetArgument(0) : global::Lua.LuaValue.Nil;
            _lastArgPos = 0; _expectedType = typeof(global::LunyEditor.UnityEditor.LuaGlobalObjectId);
            if (_arg0.TryRead<global::LunyEditor.UnityEditor.LuaGlobalObjectId>(out var _p0_UnityEditor_GlobalObjectId))
            {
                if (_argCount == 1)
                {
                    var id = _p0_UnityEditor_GlobalObjectId.Value;
                    var _ret0 = global::UnityEditor.GlobalObjectId.GlobalObjectIdentifierToInstanceIDSlow(id);
                    var _lret0 = new global::Lua.LuaValue(_ret0);
                    var _retCount = _context.Return(_lret0);
                    return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                }
            }
            throw new global::Lua.LuaRuntimeException(_context.Thread, $"{"GlobalObjectIdentifierToInstanceIDSlow"}: invalid argument #{_lastArgPos}: {_lastArg} ({_lastArg.Type}), expected: {_expectedType.FullName}", 2);
        });
        private static readonly global::Lua.LuaFunction _LuaGlobalObjectId_GlobalObjectIdentifierToObjectSlow = new global::Lua.LuaFunction("GlobalObjectIdentifierToObjectSlow", (_context, _) =>
        {
            global::Lua.LuaValue _lastArg = default;
            global::System.Int32 _lastArgPos = default;
            global::System.Type _expectedType = default;
            var _argCount = _context.ArgumentCount;
            var _arg0 = _lastArg = _argCount > 0 ? _context.GetArgument(0) : global::Lua.LuaValue.Nil;
            _lastArgPos = 0; _expectedType = typeof(global::LunyEditor.UnityEditor.LuaGlobalObjectId);
            if (_arg0.TryRead<global::LunyEditor.UnityEditor.LuaGlobalObjectId>(out var _p0_UnityEditor_GlobalObjectId))
            {
                if (_argCount == 1)
                {
                    var id = _p0_UnityEditor_GlobalObjectId.Value;
                    var _ret0 = global::UnityEditor.GlobalObjectId.GlobalObjectIdentifierToObjectSlow(id);
                    var _factory = _context.GetObjectFactory();
                    var _lret0 = _factory.Bind(_ret0);
                    var _retCount = _context.Return(_lret0);
                    return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                }
            }
            throw new global::Lua.LuaRuntimeException(_context.Thread, $"{"GlobalObjectIdentifierToObjectSlow"}: invalid argument #{_lastArgPos}: {_lastArg} ({_lastArg.Type}), expected: {_expectedType.FullName}", 2);
        });
        private static readonly global::Lua.LuaFunction __index = new(global::Lua.Runtime.Metamethods.Index, (_context, _) =>
        {
            var _this = _context.GetArgument<LuaGlobalObjectIdType>(0);
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
            var _this = _context.GetArgument<LuaGlobalObjectIdType>(0);
            var _key = _context.GetArgument(1);
            var _value = _context.GetArgument(2);
            if (_key.Type == global::Lua.LuaValueType.Number && _key.TryRead<global::System.Int32>(out var _index) && _this.TrySetLuaValue(_index, _value))
                return new global::System.Threading.Tasks.ValueTask<global::System.Int32>(_context.Return(_value));
            if (_key.Type == global::Lua.LuaValueType.String && _this.TrySetLuaValue(_key.Read<global::System.String>(), _value))
                return new global::System.Threading.Tasks.ValueTask<global::System.Int32>(_context.Return(_value));
            throw new global::Lua.LuaRuntimeException(_context.Thread, $"attempt to assign to unknown '{_key}' on '{_this}'", 2);
        });
        private static global::Lua.LuaTable CreateMetatable()
        {
            var metatable = new global::Lua.LuaTable(0, 4);
            metatable[global::Lua.Runtime.Metamethods.Index] = __index;
            metatable[global::Lua.Runtime.Metamethods.NewIndex] = __newindex;
            metatable[global::Lua.Runtime.Metamethods.Concat] = global::Luny.LuaMetatable.ConcatMetamethod;
            metatable[global::Lua.Runtime.Metamethods.ToString] = global::Luny.LuaMetatable.ToStringMetamethod;
            return metatable;
        }
        private static global::Lua.LuaTable s_Metatable;
        public global::Lua.LuaTable Metatable
        {
            get => s_Metatable ??= CreateMetatable();
            set => throw new global::System.NotSupportedException("LuaObject metatables cannot be modified");
        }
        global::System.Span<global::Lua.LuaValue> global::Lua.ILuaUserData.UserValues => default;

        public global::System.Boolean TryGetLuaValue(global::System.Int32 _key, out global::Lua.LuaValue _value, global::Luny.ILuaObjectFactory _factory)
        {
            _value = global::Lua.LuaValue.Nil; return false;
        }
        public global::System.Boolean TryGetLuaValue(global::System.String _key, out global::Lua.LuaValue _value, global::Luny.ILuaObjectFactory _factory)
        {
            switch (_key)
            {
                case "GetGlobalObjectIdSlow": _value = _LuaGlobalObjectId_GetGlobalObjectIdSlow; return true;
                case "GetGlobalObjectIdsSlow": _value = _LuaGlobalObjectId_GetGlobalObjectIdsSlow; return true;
                case "GlobalObjectIdentifiersToInstanceIDsSlow": _value = _LuaGlobalObjectId_GlobalObjectIdentifiersToInstanceIDsSlow; return true;
                case "GlobalObjectIdentifiersToObjectsSlow": _value = _LuaGlobalObjectId_GlobalObjectIdentifiersToObjectsSlow; return true;
                case "GlobalObjectIdentifierToInstanceIDSlow": _value = _LuaGlobalObjectId_GlobalObjectIdentifierToInstanceIDSlow; return true;
                case "GlobalObjectIdentifierToObjectSlow": _value = _LuaGlobalObjectId_GlobalObjectIdentifierToObjectSlow; return true;
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
