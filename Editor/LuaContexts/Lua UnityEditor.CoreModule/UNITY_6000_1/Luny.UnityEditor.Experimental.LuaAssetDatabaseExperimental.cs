
// --------------------------------------------------------------
// GENERATED FILE ----> DO NOT EDIT <---- CHANGES WILL BE LOST !!
// --------------------------------------------------------------

#if UNITY_6000_1_OR_NEWER && !(UNITY_6000_2_OR_NEWER)
#pragma warning disable 0109, 0162, 0168, 0219
using Luny;

namespace Luny.UnityEditor.Experimental
{
    public sealed class LuaAssetDatabaseExperimental : global::Luny.ILuaObject<global::UnityEditor.Experimental.AssetDatabaseExperimental>
    {
        public new static global::Lua.LuaValue Bind(global::UnityEditor.Experimental.AssetDatabaseExperimental instance) => new LuaAssetDatabaseExperimental(instance);
        public new static global::Lua.LuaValue Bind(global::System.Object instance) => Bind((global::UnityEditor.Experimental.AssetDatabaseExperimental)instance);
        public new static global::Lua.LuaValue Bind(global::System.Collections.Generic.IList<global::UnityEditor.Experimental.AssetDatabaseExperimental> instances) =>
            new global::Luny.LuaList<global::UnityEditor.Experimental.AssetDatabaseExperimental>(instances);
        public new static global::Lua.LuaValue Bind(global::System.Collections.Generic.IList<global::System.Object> instances) =>
            new global::Luny.LuaList<global::UnityEditor.Experimental.AssetDatabaseExperimental>(instances);
        private LuaAssetDatabaseExperimental(global::UnityEditor.Experimental.AssetDatabaseExperimental instance) => m_Instance = instance;
        public static implicit operator global::Lua.LuaValue(LuaAssetDatabaseExperimental value) => new(value);
        private global::UnityEditor.Experimental.AssetDatabaseExperimental m_Instance;
        public global::UnityEditor.Experimental.AssetDatabaseExperimental Instance => m_Instance;
        public new global::System.Type BindType => typeof(global::UnityEditor.Experimental.AssetDatabaseExperimental);
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
        public override global::System.String ToString() => m_Instance != null ? Instance.ToString() : "{GetType().Name}(null)";
#if UNITY_EDITOR
        [global::UnityEngine.RuntimeInitializeOnLoadMethod(global::UnityEngine.RuntimeInitializeLoadType.SubsystemRegistration)]
        private static void ResetStaticFields() => s_Metatable = null;
#endif

        private static readonly global::Lua.LuaFunction __index = new(global::Lua.Runtime.Metamethods.Index, (_context, _) =>
        {
            var _this = _context.GetArgument<LuaAssetDatabaseExperimental>(0);
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
            var _this = _context.GetArgument<LuaAssetDatabaseExperimental>(0);
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
    public sealed class LuaAssetDatabaseExperimentalType : global::Luny.ILuaStatic
    {
        public static global::Lua.LuaValue Bind() => new LuaAssetDatabaseExperimentalType();
        private LuaAssetDatabaseExperimentalType() {}
        public static implicit operator global::Lua.LuaValue(LuaAssetDatabaseExperimentalType value) => new(value);
        public global::System.Type BindType => typeof(global::UnityEditor.Experimental.AssetDatabaseExperimental);
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
            metatable[global::Lua.Runtime.Metamethods.Call] = _LuaAssetDatabaseExperimental_new;
            return metatable;
        }
        public override global::System.String ToString() => BindType.FullName;
#if UNITY_EDITOR
        [global::UnityEngine.RuntimeInitializeOnLoadMethod(global::UnityEngine.RuntimeInitializeLoadType.SubsystemRegistration)]
        private static void ResetStaticFields() => s_Metatable = null;
#endif

        private static readonly global::Lua.LuaFunction _LuaAssetDatabaseExperimental_new = new global::Lua.LuaFunction(".ctor", (_context, _) =>
        {
            global::Lua.LuaValue _lastArg = default;
            global::System.Int32 _lastArgPos = default;
            global::System.Type _expectedType = default;
            var _argCount = _context.ArgumentCount;
            if (_argCount == 1)
            {
                var _ret0 = new global::UnityEditor.Experimental.AssetDatabaseExperimental();
                var _factory = _context.GetObjectFactory();
                var _lret0 = _factory.Bind(_ret0);
                var _retCount = _context.Return(_lret0);
                return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
            }
            throw new global::Lua.LuaRuntimeException(_context.Thread, $"{".ctor"}: invalid argument #{_lastArgPos}: {_lastArg} ({_lastArg.Type}), expected: {_expectedType.FullName}", 2);
        });
        private static readonly global::Lua.LuaFunction _LuaAssetDatabaseExperimental_ForceProduceArtifact = new global::Lua.LuaFunction("ForceProduceArtifact", (_context, _) =>
        {
            global::Lua.LuaValue _lastArg = default;
            global::System.Int32 _lastArgPos = default;
            global::System.Type _expectedType = default;
            var _argCount = _context.ArgumentCount;
            var _arg0 = _lastArg = _argCount > 0 ? _context.GetArgument(0) : global::Lua.LuaValue.Nil;
            _lastArgPos = 0; _expectedType = typeof(global::Luny.UnityEditor.Experimental.LuaArtifactKey);
            if (_arg0.TryRead<global::Luny.UnityEditor.Experimental.LuaArtifactKey>(out var _p0_UnityEditor_Experimental_ArtifactKey))
            {
                if (_argCount == 1)
                {
                    var artifactKey = _p0_UnityEditor_Experimental_ArtifactKey.Value;
                    var _ret0 = global::UnityEditor.Experimental.AssetDatabaseExperimental.ForceProduceArtifact(artifactKey);
                    var _lret0 = global::Luny.UnityEditor.Experimental.LuaArtifactID.Bind(_ret0);
                    var _retCount = _context.Return(_lret0);
                    return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                }
            }
            throw new global::Lua.LuaRuntimeException(_context.Thread, $"{"ForceProduceArtifact"}: invalid argument #{_lastArgPos}: {_lastArg} ({_lastArg.Type}), expected: {_expectedType.FullName}", 2);
        });
        private static readonly global::Lua.LuaFunction _LuaAssetDatabaseExperimental_GetOnDemandArtifactProgress = new global::Lua.LuaFunction("GetOnDemandArtifactProgress", (_context, _) =>
        {
            global::Lua.LuaValue _lastArg = default;
            global::System.Int32 _lastArgPos = default;
            global::System.Type _expectedType = default;
            var _argCount = _context.ArgumentCount;
            var _arg0 = _lastArg = _argCount > 0 ? _context.GetArgument(0) : global::Lua.LuaValue.Nil;
            _lastArgPos = 0; _expectedType = typeof(global::Luny.UnityEditor.Experimental.LuaArtifactKey);
            if (_arg0.TryRead<global::Luny.UnityEditor.Experimental.LuaArtifactKey>(out var _p0_UnityEditor_Experimental_ArtifactKey))
            {
                if (_argCount == 1)
                {
                    var artifactKey = _p0_UnityEditor_Experimental_ArtifactKey.Value;
                    var _ret0 = global::UnityEditor.Experimental.AssetDatabaseExperimental.GetOnDemandArtifactProgress(artifactKey);
                    var _lret0 = global::Luny.UnityEditor.Experimental.LuaOnDemandProgress.Bind(_ret0);
                    var _retCount = _context.Return(_lret0);
                    return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                }
            }
            throw new global::Lua.LuaRuntimeException(_context.Thread, $"{"GetOnDemandArtifactProgress"}: invalid argument #{_lastArgPos}: {_lastArg} ({_lastArg.Type}), expected: {_expectedType.FullName}", 2);
        });
        private static readonly global::Lua.LuaFunction _LuaAssetDatabaseExperimental_LookupArtifact = new global::Lua.LuaFunction("LookupArtifact", (_context, _) =>
        {
            global::Lua.LuaValue _lastArg = default;
            global::System.Int32 _lastArgPos = default;
            global::System.Type _expectedType = default;
            var _argCount = _context.ArgumentCount;
            var _arg0 = _lastArg = _argCount > 0 ? _context.GetArgument(0) : global::Lua.LuaValue.Nil;
            _lastArgPos = 0; _expectedType = typeof(global::Luny.UnityEditor.Experimental.LuaArtifactKey);
            if (_arg0.TryRead<global::Luny.UnityEditor.Experimental.LuaArtifactKey>(out var _p0_UnityEditor_Experimental_ArtifactKey))
            {
                if (_argCount == 1)
                {
                    var artifactKey = _p0_UnityEditor_Experimental_ArtifactKey.Value;
                    var _ret0 = global::UnityEditor.Experimental.AssetDatabaseExperimental.LookupArtifact(artifactKey);
                    var _lret0 = global::Luny.UnityEditor.Experimental.LuaArtifactID.Bind(_ret0);
                    var _retCount = _context.Return(_lret0);
                    return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                }
            }
            throw new global::Lua.LuaRuntimeException(_context.Thread, $"{"LookupArtifact"}: invalid argument #{_lastArgPos}: {_lastArg} ({_lastArg.Type}), expected: {_expectedType.FullName}", 2);
        });
        private static readonly global::Lua.LuaFunction _LuaAssetDatabaseExperimental_ProduceArtifact = new global::Lua.LuaFunction("ProduceArtifact", (_context, _) =>
        {
            global::Lua.LuaValue _lastArg = default;
            global::System.Int32 _lastArgPos = default;
            global::System.Type _expectedType = default;
            var _argCount = _context.ArgumentCount;
            var _arg0 = _lastArg = _argCount > 0 ? _context.GetArgument(0) : global::Lua.LuaValue.Nil;
            _lastArgPos = 0; _expectedType = typeof(global::Luny.UnityEditor.Experimental.LuaArtifactKey);
            if (_arg0.TryRead<global::Luny.UnityEditor.Experimental.LuaArtifactKey>(out var _p0_UnityEditor_Experimental_ArtifactKey))
            {
                if (_argCount == 1)
                {
                    var artifactKey = _p0_UnityEditor_Experimental_ArtifactKey.Value;
                    var _ret0 = global::UnityEditor.Experimental.AssetDatabaseExperimental.ProduceArtifact(artifactKey);
                    var _lret0 = global::Luny.UnityEditor.Experimental.LuaArtifactID.Bind(_ret0);
                    var _retCount = _context.Return(_lret0);
                    return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                }
            }
            throw new global::Lua.LuaRuntimeException(_context.Thread, $"{"ProduceArtifact"}: invalid argument #{_lastArgPos}: {_lastArg} ({_lastArg.Type}), expected: {_expectedType.FullName}", 2);
        });
        private static readonly global::Lua.LuaFunction _LuaAssetDatabaseExperimental_ProduceArtifactAsync = new global::Lua.LuaFunction("ProduceArtifactAsync", (_context, _) =>
        {
            global::Lua.LuaValue _lastArg = default;
            global::System.Int32 _lastArgPos = default;
            global::System.Type _expectedType = default;
            var _argCount = _context.ArgumentCount;
            var _arg0 = _lastArg = _argCount > 0 ? _context.GetArgument(0) : global::Lua.LuaValue.Nil;
            _lastArgPos = 0; _expectedType = typeof(global::Luny.UnityEditor.Experimental.LuaArtifactKey);
            if (_arg0.TryRead<global::Luny.UnityEditor.Experimental.LuaArtifactKey>(out var _p0_UnityEditor_Experimental_ArtifactKey))
            {
                if (_argCount == 1)
                {
                    var artifactKey = _p0_UnityEditor_Experimental_ArtifactKey.Value;
                    var _ret0 = global::UnityEditor.Experimental.AssetDatabaseExperimental.ProduceArtifactAsync(artifactKey);
                    var _lret0 = global::Luny.UnityEditor.Experimental.LuaArtifactID.Bind(_ret0);
                    var _retCount = _context.Return(_lret0);
                    return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                }
            }
            throw new global::Lua.LuaRuntimeException(_context.Thread, $"{"ProduceArtifactAsync"}: invalid argument #{_lastArgPos}: {_lastArg} ({_lastArg.Type}), expected: {_expectedType.FullName}", 2);
        });
        private static readonly global::Lua.LuaFunction _LuaAssetDatabaseExperimental_ProduceArtifactsAsync = new global::Lua.LuaFunction("ProduceArtifactsAsync", (_context, _) =>
        {
            global::Lua.LuaValue _lastArg = default;
            global::System.Int32 _lastArgPos = default;
            global::System.Type _expectedType = default;
            var _argCount = _context.ArgumentCount;
            var _arg0 = _lastArg = _argCount > 0 ? _context.GetArgument(0) : global::Lua.LuaValue.Nil;
            _lastArgPos = 0; _expectedType = typeof(global::UnityEditor.GUID[]);
            if (_arg0.TryReadArray<global::UnityEditor.GUID>(out var _p0_UnityEditor_GUIDArray))
            {
                if (_argCount == 1)
                {
                    var artifactKey = _p0_UnityEditor_GUIDArray;
                    var _ret0 = global::UnityEditor.Experimental.AssetDatabaseExperimental.ProduceArtifactsAsync(artifactKey);
                    var _factory = _context.GetObjectFactory();
                    var _lret0 = _factory.Bind(_ret0);
                    var _retCount = _context.Return(_lret0);
                    return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                }
                var _arg1 = _lastArg = _argCount > 1 ? _context.GetArgument(1) : global::Lua.LuaValue.Nil;
                _lastArgPos = 1; _expectedType = typeof(global::Luny.ILuaBindType);
                var _p1_System_Type = _arg1.ReadValue<global::Luny.ILuaBindType>(default);
                {
                    if (_argCount == 2)
                    {
                        var artifactKey = _p0_UnityEditor_GUIDArray;
                        var importerType = _p1_System_Type.BindType;
                        var _ret0 = global::UnityEditor.Experimental.AssetDatabaseExperimental.ProduceArtifactsAsync(artifactKey, importerType);
                        var _factory = _context.GetObjectFactory();
                        var _lret0 = _factory.Bind(_ret0);
                        var _retCount = _context.Return(_lret0);
                        return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                    }
                }
            }
            throw new global::Lua.LuaRuntimeException(_context.Thread, $"{"ProduceArtifactsAsync"}: invalid argument #{_lastArgPos}: {_lastArg} ({_lastArg.Type}), expected: {_expectedType.FullName}", 2);
        });
        private static readonly global::Lua.LuaFunction __index = new(global::Lua.Runtime.Metamethods.Index, (_context, _) =>
        {
            var _this = _context.GetArgument<LuaAssetDatabaseExperimentalType>(0);
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
            var _this = _context.GetArgument<LuaAssetDatabaseExperimentalType>(0);
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
                case "ForceProduceArtifact": _value = _LuaAssetDatabaseExperimental_ForceProduceArtifact; return true;
                case "GetOnDemandArtifactProgress": _value = _LuaAssetDatabaseExperimental_GetOnDemandArtifactProgress; return true;
                case "LookupArtifact": _value = _LuaAssetDatabaseExperimental_LookupArtifact; return true;
                case "ProduceArtifact": _value = _LuaAssetDatabaseExperimental_ProduceArtifact; return true;
                case "ProduceArtifactAsync": _value = _LuaAssetDatabaseExperimental_ProduceArtifactAsync; return true;
                case "ProduceArtifactsAsync": _value = _LuaAssetDatabaseExperimental_ProduceArtifactsAsync; return true;
                case "ActiveOnDemandMode": _value = new global::Lua.LuaValue((global::System.Int64)global::UnityEditor.Experimental.AssetDatabaseExperimental.ActiveOnDemandMode); return true;
                case "counters": _value = global::Luny.UnityEditor.Experimental.LuaAssetDatabaseExperimentalAssetDatabaseCounters.Bind(global::UnityEditor.Experimental.AssetDatabaseExperimental.counters); return true;
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
                case "ActiveOnDemandMode": global::UnityEditor.Experimental.AssetDatabaseExperimental.ActiveOnDemandMode = _value.Read<global::UnityEditor.Experimental.AssetDatabaseExperimental.OnDemandMode>();  return true;
                default: return false;
            }
        }
    }
}
#pragma warning restore 0109, 0162, 0168, 0219
#endif
