
// --------------------------------------------------------------
// GENERATED FILE ----> DO NOT EDIT <---- CHANGES WILL BE LOST !!
// --------------------------------------------------------------

#if UNITY_6000_0_OR_NEWER && !(UNITY_6000_1_OR_NEWER)
#pragma warning disable 0109, 0162, 0168, 0219
using Luny;

namespace Luny.UnityEditor.Experimental
{
    public sealed class LuaAssetDatabaseExperimentalAssetDatabaseCountersCacheServerCounters : global::Luny.ILuaValueType<global::UnityEditor.Experimental.AssetDatabaseExperimental.AssetDatabaseCounters.CacheServerCounters>
    {
        public new static global::Lua.LuaValue Bind(in global::UnityEditor.Experimental.AssetDatabaseExperimental.AssetDatabaseCounters.CacheServerCounters instance) => new LuaAssetDatabaseExperimentalAssetDatabaseCountersCacheServerCounters(instance);
        public new static global::Lua.LuaValue Bind(global::System.Object instance) => Bind((global::UnityEditor.Experimental.AssetDatabaseExperimental.AssetDatabaseCounters.CacheServerCounters)instance);
        public new static global::Lua.LuaValue Bind(global::System.Collections.Generic.IList<global::UnityEditor.Experimental.AssetDatabaseExperimental.AssetDatabaseCounters.CacheServerCounters> instances) =>
            new global::Luny.LuaList<global::UnityEditor.Experimental.AssetDatabaseExperimental.AssetDatabaseCounters.CacheServerCounters>(instances);
        public new static global::Lua.LuaValue Bind(global::System.Collections.Generic.IList<global::System.Object> instances) =>
            new global::Luny.LuaList<global::UnityEditor.Experimental.AssetDatabaseExperimental.AssetDatabaseCounters.CacheServerCounters>(instances);
        private LuaAssetDatabaseExperimentalAssetDatabaseCountersCacheServerCounters(in global::UnityEditor.Experimental.AssetDatabaseExperimental.AssetDatabaseCounters.CacheServerCounters value) => m_Value = value;
        public static implicit operator global::Lua.LuaValue(LuaAssetDatabaseExperimentalAssetDatabaseCountersCacheServerCounters value) => new(value);
        private global::UnityEditor.Experimental.AssetDatabaseExperimental.AssetDatabaseCounters.CacheServerCounters m_Value;
        public global::UnityEditor.Experimental.AssetDatabaseExperimental.AssetDatabaseCounters.CacheServerCounters Value { get => m_Value; set => m_Value = value; }
        public ref global::UnityEditor.Experimental.AssetDatabaseExperimental.AssetDatabaseCounters.CacheServerCounters ValueRef => ref m_Value;
        public global::System.Type BindType => typeof(global::UnityEditor.Experimental.AssetDatabaseExperimental.AssetDatabaseCounters.CacheServerCounters);
        private static global::Lua.LuaTable s_Metatable;
        public global::Lua.LuaTable Metatable
        {
            get => s_Metatable ??= CreateMetatable();
            set => throw new global::System.NotSupportedException("LuaObject metatables cannot be modified");
        }
        global::System.Span<global::Lua.LuaValue> global::Lua.ILuaUserData.UserValues => default;
        private static global::Lua.LuaTable CreateMetatable()
        {
            var metatable = new global::Lua.LuaTable(0, 4);
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

        private static readonly global::Lua.LuaFunction __index = new(global::Lua.Runtime.Metamethods.Index, (_context, _) =>
        {
            var _this = _context.GetArgument<LuaAssetDatabaseExperimentalAssetDatabaseCountersCacheServerCounters>(0);
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
            var _this = _context.GetArgument<LuaAssetDatabaseExperimentalAssetDatabaseCountersCacheServerCounters>(0);
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
                case "artifactFilesDownloaded": _value = global::Luny.UnityEditor.Experimental.LuaAssetDatabaseExperimentalAssetDatabaseCountersCounter.Bind(m_Value.artifactFilesDownloaded); return true;
                case "artifactFilesFailedToDownload": _value = global::Luny.UnityEditor.Experimental.LuaAssetDatabaseExperimentalAssetDatabaseCountersCounter.Bind(m_Value.artifactFilesFailedToDownload); return true;
                case "artifactFilesFailedToUpload": _value = global::Luny.UnityEditor.Experimental.LuaAssetDatabaseExperimentalAssetDatabaseCountersCounter.Bind(m_Value.artifactFilesFailedToUpload); return true;
                case "artifactFilesUploaded": _value = global::Luny.UnityEditor.Experimental.LuaAssetDatabaseExperimentalAssetDatabaseCountersCounter.Bind(m_Value.artifactFilesUploaded); return true;
                case "artifactsDownloaded": _value = global::Luny.UnityEditor.Experimental.LuaAssetDatabaseExperimentalAssetDatabaseCountersCounter.Bind(m_Value.artifactsDownloaded); return true;
                case "artifactsUploaded": _value = global::Luny.UnityEditor.Experimental.LuaAssetDatabaseExperimentalAssetDatabaseCountersCounter.Bind(m_Value.artifactsUploaded); return true;
                case "batchesUsedForDownload": _value = global::Luny.UnityEditor.Experimental.LuaAssetDatabaseExperimentalAssetDatabaseCountersCounter.Bind(m_Value.batchesUsedForDownload); return true;
                case "connects": _value = global::Luny.UnityEditor.Experimental.LuaAssetDatabaseExperimentalAssetDatabaseCountersCounter.Bind(m_Value.connects); return true;
                case "disconnects": _value = global::Luny.UnityEditor.Experimental.LuaAssetDatabaseExperimentalAssetDatabaseCountersCounter.Bind(m_Value.disconnects); return true;
                case "metadataDownloaded": _value = global::Luny.UnityEditor.Experimental.LuaAssetDatabaseExperimentalAssetDatabaseCountersCounter.Bind(m_Value.metadataDownloaded); return true;
                case "metadataFailedToDownload": _value = global::Luny.UnityEditor.Experimental.LuaAssetDatabaseExperimentalAssetDatabaseCountersCounter.Bind(m_Value.metadataFailedToDownload); return true;
                case "metadataFailedToUpload": _value = global::Luny.UnityEditor.Experimental.LuaAssetDatabaseExperimentalAssetDatabaseCountersCounter.Bind(m_Value.metadataFailedToUpload); return true;
                case "metadataMatched": _value = global::Luny.UnityEditor.Experimental.LuaAssetDatabaseExperimentalAssetDatabaseCountersCounter.Bind(m_Value.metadataMatched); return true;
                case "metadataRequested": _value = global::Luny.UnityEditor.Experimental.LuaAssetDatabaseExperimentalAssetDatabaseCountersCounter.Bind(m_Value.metadataRequested); return true;
                case "metadataUploaded": _value = global::Luny.UnityEditor.Experimental.LuaAssetDatabaseExperimentalAssetDatabaseCountersCounter.Bind(m_Value.metadataUploaded); return true;
                case "metadataVersionsDownloaded": _value = global::Luny.UnityEditor.Experimental.LuaAssetDatabaseExperimentalAssetDatabaseCountersCounter.Bind(m_Value.metadataVersionsDownloaded); return true;
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
                case "artifactFilesDownloaded": { var _temp = m_Value; _temp.artifactFilesDownloaded = _value.Read<global::Luny.UnityEditor.Experimental.LuaAssetDatabaseExperimentalAssetDatabaseCountersCounter>().Value; m_Value = _temp; } return true;
                case "artifactFilesFailedToDownload": { var _temp = m_Value; _temp.artifactFilesFailedToDownload = _value.Read<global::Luny.UnityEditor.Experimental.LuaAssetDatabaseExperimentalAssetDatabaseCountersCounter>().Value; m_Value = _temp; } return true;
                case "artifactFilesFailedToUpload": { var _temp = m_Value; _temp.artifactFilesFailedToUpload = _value.Read<global::Luny.UnityEditor.Experimental.LuaAssetDatabaseExperimentalAssetDatabaseCountersCounter>().Value; m_Value = _temp; } return true;
                case "artifactFilesUploaded": { var _temp = m_Value; _temp.artifactFilesUploaded = _value.Read<global::Luny.UnityEditor.Experimental.LuaAssetDatabaseExperimentalAssetDatabaseCountersCounter>().Value; m_Value = _temp; } return true;
                case "artifactsDownloaded": { var _temp = m_Value; _temp.artifactsDownloaded = _value.Read<global::Luny.UnityEditor.Experimental.LuaAssetDatabaseExperimentalAssetDatabaseCountersCounter>().Value; m_Value = _temp; } return true;
                case "artifactsUploaded": { var _temp = m_Value; _temp.artifactsUploaded = _value.Read<global::Luny.UnityEditor.Experimental.LuaAssetDatabaseExperimentalAssetDatabaseCountersCounter>().Value; m_Value = _temp; } return true;
                case "batchesUsedForDownload": { var _temp = m_Value; _temp.batchesUsedForDownload = _value.Read<global::Luny.UnityEditor.Experimental.LuaAssetDatabaseExperimentalAssetDatabaseCountersCounter>().Value; m_Value = _temp; } return true;
                case "connects": { var _temp = m_Value; _temp.connects = _value.Read<global::Luny.UnityEditor.Experimental.LuaAssetDatabaseExperimentalAssetDatabaseCountersCounter>().Value; m_Value = _temp; } return true;
                case "disconnects": { var _temp = m_Value; _temp.disconnects = _value.Read<global::Luny.UnityEditor.Experimental.LuaAssetDatabaseExperimentalAssetDatabaseCountersCounter>().Value; m_Value = _temp; } return true;
                case "metadataDownloaded": { var _temp = m_Value; _temp.metadataDownloaded = _value.Read<global::Luny.UnityEditor.Experimental.LuaAssetDatabaseExperimentalAssetDatabaseCountersCounter>().Value; m_Value = _temp; } return true;
                case "metadataFailedToDownload": { var _temp = m_Value; _temp.metadataFailedToDownload = _value.Read<global::Luny.UnityEditor.Experimental.LuaAssetDatabaseExperimentalAssetDatabaseCountersCounter>().Value; m_Value = _temp; } return true;
                case "metadataFailedToUpload": { var _temp = m_Value; _temp.metadataFailedToUpload = _value.Read<global::Luny.UnityEditor.Experimental.LuaAssetDatabaseExperimentalAssetDatabaseCountersCounter>().Value; m_Value = _temp; } return true;
                case "metadataMatched": { var _temp = m_Value; _temp.metadataMatched = _value.Read<global::Luny.UnityEditor.Experimental.LuaAssetDatabaseExperimentalAssetDatabaseCountersCounter>().Value; m_Value = _temp; } return true;
                case "metadataRequested": { var _temp = m_Value; _temp.metadataRequested = _value.Read<global::Luny.UnityEditor.Experimental.LuaAssetDatabaseExperimentalAssetDatabaseCountersCounter>().Value; m_Value = _temp; } return true;
                case "metadataUploaded": { var _temp = m_Value; _temp.metadataUploaded = _value.Read<global::Luny.UnityEditor.Experimental.LuaAssetDatabaseExperimentalAssetDatabaseCountersCounter>().Value; m_Value = _temp; } return true;
                case "metadataVersionsDownloaded": { var _temp = m_Value; _temp.metadataVersionsDownloaded = _value.Read<global::Luny.UnityEditor.Experimental.LuaAssetDatabaseExperimentalAssetDatabaseCountersCounter>().Value; m_Value = _temp; } return true;
                default: return false;
            }
        }
    }
    public sealed class LuaAssetDatabaseExperimentalAssetDatabaseCountersCacheServerCountersType : global::Luny.ILuaStatic
    {
        public static global::Lua.LuaValue Bind() => new LuaAssetDatabaseExperimentalAssetDatabaseCountersCacheServerCountersType();
        private LuaAssetDatabaseExperimentalAssetDatabaseCountersCacheServerCountersType() {}
        public static implicit operator global::Lua.LuaValue(LuaAssetDatabaseExperimentalAssetDatabaseCountersCacheServerCountersType value) => new(value);
        public global::System.Type BindType => typeof(global::UnityEditor.Experimental.AssetDatabaseExperimental.AssetDatabaseCounters.CacheServerCounters);
        private static global::Lua.LuaTable s_Metatable;
        public global::Lua.LuaTable Metatable
        {
            get => s_Metatable ??= CreateMetatable();
            set => throw new global::System.NotSupportedException("LuaObject metatables cannot be modified");
        }
        global::System.Span<global::Lua.LuaValue> global::Lua.ILuaUserData.UserValues => default;
        private static global::Lua.LuaTable CreateMetatable()
        {
            var metatable = new global::Lua.LuaTable(0, 4);
            metatable[global::Lua.Runtime.Metamethods.Index] = __index;
            metatable[global::Lua.Runtime.Metamethods.NewIndex] = __newindex;
            metatable[global::Lua.Runtime.Metamethods.Concat] = global::Luny.LuaMetatable.ConcatMetamethod;
            metatable[global::Lua.Runtime.Metamethods.ToString] = global::Luny.LuaMetatable.ToStringMetamethod;
            return metatable;
        }
        public override global::System.String ToString() => BindType.FullName;
#if UNITY_EDITOR
        [global::UnityEngine.RuntimeInitializeOnLoadMethod(global::UnityEngine.RuntimeInitializeLoadType.SubsystemRegistration)]
        private static void ResetStaticFields() => s_Metatable = null;
#endif

        private static readonly global::Lua.LuaFunction __index = new(global::Lua.Runtime.Metamethods.Index, (_context, _) =>
        {
            var _this = _context.GetArgument<LuaAssetDatabaseExperimentalAssetDatabaseCountersCacheServerCountersType>(0);
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
            var _this = _context.GetArgument<LuaAssetDatabaseExperimentalAssetDatabaseCountersCacheServerCountersType>(0);
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
}
#pragma warning restore 0109, 0162, 0168, 0219
#endif
