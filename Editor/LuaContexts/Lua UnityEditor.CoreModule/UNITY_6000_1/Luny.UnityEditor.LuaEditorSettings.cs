
// --------------------------------------------------------------
// GENERATED FILE ----> DO NOT EDIT <---- CHANGES WILL BE LOST !!
// --------------------------------------------------------------

#if UNITY_6000_1_OR_NEWER && !(UNITY_6000_2_OR_NEWER)
#pragma warning disable 0109, 0162, 0168, 0219
using Luny;

namespace Luny.UnityEditor
{
    public sealed class LuaEditorSettings : global::Luny.ILuaObject<global::UnityEditor.EditorSettings>
    {
        public new static global::Lua.LuaValue Bind(global::UnityEditor.EditorSettings instance) => new LuaEditorSettings(instance);
        public new static global::Lua.LuaValue Bind(global::System.Object instance) => Bind((global::UnityEditor.EditorSettings)instance);
        public new static global::Lua.LuaValue Bind(global::System.Collections.Generic.IList<global::UnityEditor.EditorSettings> instances) =>
            new global::Luny.LuaList<global::UnityEditor.EditorSettings>(instances);
        public new static global::Lua.LuaValue Bind(global::System.Collections.Generic.IList<global::System.Object> instances) =>
            new global::Luny.LuaList<global::UnityEditor.EditorSettings>(instances);
        private LuaEditorSettings(global::UnityEditor.EditorSettings instance) => m_Instance = instance;
        public static implicit operator global::Lua.LuaValue(LuaEditorSettings value) => new(value);
        private global::UnityEditor.EditorSettings m_Instance;
        public global::UnityEditor.EditorSettings Instance => m_Instance;
        public new global::System.Type BindType => typeof(global::UnityEditor.EditorSettings);
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
            var _this = _context.GetArgument<LuaEditorSettings>(0);
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
            var _this = _context.GetArgument<LuaEditorSettings>(0);
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
    public sealed class LuaEditorSettingsType : global::Luny.ILuaStatic
    {
        public static global::Lua.LuaValue Bind() => new LuaEditorSettingsType();
        private LuaEditorSettingsType() {}
        public static implicit operator global::Lua.LuaValue(LuaEditorSettingsType value) => new(value);
        public global::System.Type BindType => typeof(global::UnityEditor.EditorSettings);
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

        private static readonly global::Lua.LuaFunction __index = new(global::Lua.Runtime.Metamethods.Index, (_context, _) =>
        {
            var _this = _context.GetArgument<LuaEditorSettingsType>(0);
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
            var _this = _context.GetArgument<LuaEditorSettingsType>(0);
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
                case "assetNamingUsesSpace": _value = new global::Lua.LuaValue(global::UnityEditor.EditorSettings.assetNamingUsesSpace); return true;
                case "assetPipelineMode": _value = new global::Lua.LuaValue((global::System.Int64)global::UnityEditor.EditorSettings.assetPipelineMode); return true;
                case "asyncShaderCompilation": _value = new global::Lua.LuaValue(global::UnityEditor.EditorSettings.asyncShaderCompilation); return true;
                case "cacheServerDownloadBatchSize": _value = new global::Lua.LuaValue(global::UnityEditor.EditorSettings.cacheServerDownloadBatchSize); return true;
                case "cacheServerEnableAuth": _value = new global::Lua.LuaValue(global::UnityEditor.EditorSettings.cacheServerEnableAuth); return true;
                case "cacheServerEnableDownload": _value = new global::Lua.LuaValue(global::UnityEditor.EditorSettings.cacheServerEnableDownload); return true;
                case "cacheServerEnableTls": _value = new global::Lua.LuaValue(global::UnityEditor.EditorSettings.cacheServerEnableTls); return true;
                case "cacheServerEnableUpload": _value = new global::Lua.LuaValue(global::UnityEditor.EditorSettings.cacheServerEnableUpload); return true;
                case "cacheServerEndpoint": _value = new global::Lua.LuaValue(global::UnityEditor.EditorSettings.cacheServerEndpoint); return true;
                case "cacheServerMode": _value = new global::Lua.LuaValue((global::System.Int64)global::UnityEditor.EditorSettings.cacheServerMode); return true;
                case "cacheServerNamespacePrefix": _value = new global::Lua.LuaValue(global::UnityEditor.EditorSettings.cacheServerNamespacePrefix); return true;
                case "cacheServerValidationMode": _value = new global::Lua.LuaValue((global::System.Int64)global::UnityEditor.EditorSettings.cacheServerValidationMode); return true;
                case "cachingShaderPreprocessor": _value = new global::Lua.LuaValue(global::UnityEditor.EditorSettings.cachingShaderPreprocessor); return true;
                case "defaultBehaviorMode": _value = new global::Lua.LuaValue((global::System.Int64)global::UnityEditor.EditorSettings.defaultBehaviorMode); return true;
                case "enableTextureStreamingInEditMode": _value = new global::Lua.LuaValue(global::UnityEditor.EditorSettings.enableTextureStreamingInEditMode); return true;
                case "enableTextureStreamingInPlayMode": _value = new global::Lua.LuaValue(global::UnityEditor.EditorSettings.enableTextureStreamingInPlayMode); return true;
                case "enterPlayModeOptions": _value = new global::Lua.LuaValue((global::System.Int64)global::UnityEditor.EditorSettings.enterPlayModeOptions); return true;
                case "enterPlayModeOptionsEnabled": _value = new global::Lua.LuaValue(global::UnityEditor.EditorSettings.enterPlayModeOptionsEnabled); return true;
                case "etcTextureBestCompressor": _value = new global::Lua.LuaValue(global::UnityEditor.EditorSettings.etcTextureBestCompressor); return true;
                case "etcTextureCompressorBehavior": _value = new global::Lua.LuaValue(global::UnityEditor.EditorSettings.etcTextureCompressorBehavior); return true;
                case "etcTextureFastCompressor": _value = new global::Lua.LuaValue(global::UnityEditor.EditorSettings.etcTextureFastCompressor); return true;
                case "etcTextureNormalCompressor": _value = new global::Lua.LuaValue(global::UnityEditor.EditorSettings.etcTextureNormalCompressor); return true;
                case "gameObjectNamingDigits": _value = new global::Lua.LuaValue(global::UnityEditor.EditorSettings.gameObjectNamingDigits); return true;
                case "gameObjectNamingScheme": _value = new global::Lua.LuaValue((global::System.Int64)global::UnityEditor.EditorSettings.gameObjectNamingScheme); return true;
                case "lineEndingsForNewScripts": _value = new global::Lua.LuaValue((global::System.Int64)global::UnityEditor.EditorSettings.lineEndingsForNewScripts); return true;
                case "prefabModeAllowAutoSave": _value = new global::Lua.LuaValue(global::UnityEditor.EditorSettings.prefabModeAllowAutoSave); return true;
                case "prefabRegularEnvironment": _value = _factory.Bind(global::UnityEditor.EditorSettings.prefabRegularEnvironment); return true;
                case "prefabUIEnvironment": _value = _factory.Bind(global::UnityEditor.EditorSettings.prefabUIEnvironment); return true;
                case "projectGenerationBuiltinExtensions": _value = _factory.Bind(global::UnityEditor.EditorSettings.projectGenerationBuiltinExtensions); return true;
                case "projectGenerationRootNamespace": _value = new global::Lua.LuaValue(global::UnityEditor.EditorSettings.projectGenerationRootNamespace); return true;
                case "projectGenerationUserExtensions": _value = _factory.Bind(global::UnityEditor.EditorSettings.projectGenerationUserExtensions); return true;
                case "referencedClipsExactNaming": _value = new global::Lua.LuaValue(global::UnityEditor.EditorSettings.referencedClipsExactNaming); return true;
                case "refreshImportMode": _value = new global::Lua.LuaValue((global::System.Int64)global::UnityEditor.EditorSettings.refreshImportMode); return true;
                case "serializationMode": _value = new global::Lua.LuaValue((global::System.Int64)global::UnityEditor.EditorSettings.serializationMode); return true;
                case "serializeInlineMappingsOnOneLine": _value = new global::Lua.LuaValue(global::UnityEditor.EditorSettings.serializeInlineMappingsOnOneLine); return true;
                case "shadowmaskStitching": _value = new global::Lua.LuaValue(global::UnityEditor.EditorSettings.shadowmaskStitching); return true;
                case "spritePackerMode": _value = new global::Lua.LuaValue((global::System.Int64)global::UnityEditor.EditorSettings.spritePackerMode); return true;
                case "spritePackerPaddingPower": _value = new global::Lua.LuaValue(global::UnityEditor.EditorSettings.spritePackerPaddingPower); return true;
                case "unityRemoteCompression": _value = new global::Lua.LuaValue(global::UnityEditor.EditorSettings.unityRemoteCompression); return true;
                case "unityRemoteDevice": _value = new global::Lua.LuaValue(global::UnityEditor.EditorSettings.unityRemoteDevice); return true;
                case "unityRemoteJoystickSource": _value = new global::Lua.LuaValue(global::UnityEditor.EditorSettings.unityRemoteJoystickSource); return true;
                case "unityRemoteResolution": _value = new global::Lua.LuaValue(global::UnityEditor.EditorSettings.unityRemoteResolution); return true;
                case "useLegacyProbeSampleCount": _value = new global::Lua.LuaValue(global::UnityEditor.EditorSettings.useLegacyProbeSampleCount); return true;
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
                case "assetNamingUsesSpace": global::UnityEditor.EditorSettings.assetNamingUsesSpace = _value.Read<global::System.Boolean>();  return true;
                case "asyncShaderCompilation": global::UnityEditor.EditorSettings.asyncShaderCompilation = _value.Read<global::System.Boolean>();  return true;
                case "cacheServerDownloadBatchSize": global::UnityEditor.EditorSettings.cacheServerDownloadBatchSize = _value.Read<global::System.Int32>();  return true;
                case "cacheServerEnableAuth": global::UnityEditor.EditorSettings.cacheServerEnableAuth = _value.Read<global::System.Boolean>();  return true;
                case "cacheServerEnableDownload": global::UnityEditor.EditorSettings.cacheServerEnableDownload = _value.Read<global::System.Boolean>();  return true;
                case "cacheServerEnableTls": global::UnityEditor.EditorSettings.cacheServerEnableTls = _value.Read<global::System.Boolean>();  return true;
                case "cacheServerEnableUpload": global::UnityEditor.EditorSettings.cacheServerEnableUpload = _value.Read<global::System.Boolean>();  return true;
                case "cacheServerEndpoint": global::UnityEditor.EditorSettings.cacheServerEndpoint = _value.Read<global::System.String>();  return true;
                case "cacheServerMode": global::UnityEditor.EditorSettings.cacheServerMode = _value.Read<global::UnityEditor.CacheServerMode>();  return true;
                case "cacheServerNamespacePrefix": global::UnityEditor.EditorSettings.cacheServerNamespacePrefix = _value.Read<global::System.String>();  return true;
                case "cacheServerValidationMode": global::UnityEditor.EditorSettings.cacheServerValidationMode = _value.Read<global::UnityEditor.CacheServerValidationMode>();  return true;
                case "cachingShaderPreprocessor": global::UnityEditor.EditorSettings.cachingShaderPreprocessor = _value.Read<global::System.Boolean>();  return true;
                case "defaultBehaviorMode": global::UnityEditor.EditorSettings.defaultBehaviorMode = _value.Read<global::UnityEditor.EditorBehaviorMode>();  return true;
                case "enableTextureStreamingInEditMode": global::UnityEditor.EditorSettings.enableTextureStreamingInEditMode = _value.Read<global::System.Boolean>();  return true;
                case "enableTextureStreamingInPlayMode": global::UnityEditor.EditorSettings.enableTextureStreamingInPlayMode = _value.Read<global::System.Boolean>();  return true;
                case "enterPlayModeOptions": global::UnityEditor.EditorSettings.enterPlayModeOptions = _value.Read<global::UnityEditor.EnterPlayModeOptions>();  return true;
                case "enterPlayModeOptionsEnabled": global::UnityEditor.EditorSettings.enterPlayModeOptionsEnabled = _value.Read<global::System.Boolean>();  return true;
                case "etcTextureBestCompressor": global::UnityEditor.EditorSettings.etcTextureBestCompressor = _value.Read<global::System.Int32>();  return true;
                case "etcTextureCompressorBehavior": global::UnityEditor.EditorSettings.etcTextureCompressorBehavior = _value.Read<global::System.Int32>();  return true;
                case "etcTextureFastCompressor": global::UnityEditor.EditorSettings.etcTextureFastCompressor = _value.Read<global::System.Int32>();  return true;
                case "etcTextureNormalCompressor": global::UnityEditor.EditorSettings.etcTextureNormalCompressor = _value.Read<global::System.Int32>();  return true;
                case "gameObjectNamingDigits": global::UnityEditor.EditorSettings.gameObjectNamingDigits = _value.Read<global::System.Int32>();  return true;
                case "gameObjectNamingScheme": global::UnityEditor.EditorSettings.gameObjectNamingScheme = _value.Read<global::UnityEditor.EditorSettings.NamingScheme>();  return true;
                case "lineEndingsForNewScripts": global::UnityEditor.EditorSettings.lineEndingsForNewScripts = _value.Read<global::UnityEditor.LineEndingsMode>();  return true;
                case "prefabModeAllowAutoSave": global::UnityEditor.EditorSettings.prefabModeAllowAutoSave = _value.Read<global::System.Boolean>();  return true;
                case "prefabRegularEnvironment": global::UnityEditor.EditorSettings.prefabRegularEnvironment = _value.Read<global::Luny.UnityEditor.LuaSceneAsset>().Instance;  return true;
                case "prefabUIEnvironment": global::UnityEditor.EditorSettings.prefabUIEnvironment = _value.Read<global::Luny.UnityEditor.LuaSceneAsset>().Instance;  return true;
                case "projectGenerationRootNamespace": global::UnityEditor.EditorSettings.projectGenerationRootNamespace = _value.Read<global::System.String>();  return true;
                case "projectGenerationUserExtensions": global::UnityEditor.EditorSettings.projectGenerationUserExtensions = _value.Read<global::System.String[]>();  return true;
                case "referencedClipsExactNaming": global::UnityEditor.EditorSettings.referencedClipsExactNaming = _value.Read<global::System.Boolean>();  return true;
                case "refreshImportMode": global::UnityEditor.EditorSettings.refreshImportMode = _value.Read<global::UnityEditor.AssetDatabase.RefreshImportMode>();  return true;
                case "serializationMode": global::UnityEditor.EditorSettings.serializationMode = _value.Read<global::UnityEditor.SerializationMode>();  return true;
                case "serializeInlineMappingsOnOneLine": global::UnityEditor.EditorSettings.serializeInlineMappingsOnOneLine = _value.Read<global::System.Boolean>();  return true;
                case "shadowmaskStitching": global::UnityEditor.EditorSettings.shadowmaskStitching = _value.Read<global::System.Boolean>();  return true;
                case "spritePackerMode": global::UnityEditor.EditorSettings.spritePackerMode = _value.Read<global::UnityEditor.SpritePackerMode>();  return true;
                case "spritePackerPaddingPower": global::UnityEditor.EditorSettings.spritePackerPaddingPower = _value.Read<global::System.Int32>();  return true;
                case "unityRemoteCompression": global::UnityEditor.EditorSettings.unityRemoteCompression = _value.Read<global::System.String>();  return true;
                case "unityRemoteDevice": global::UnityEditor.EditorSettings.unityRemoteDevice = _value.Read<global::System.String>();  return true;
                case "unityRemoteJoystickSource": global::UnityEditor.EditorSettings.unityRemoteJoystickSource = _value.Read<global::System.String>();  return true;
                case "unityRemoteResolution": global::UnityEditor.EditorSettings.unityRemoteResolution = _value.Read<global::System.String>();  return true;
                case "useLegacyProbeSampleCount": global::UnityEditor.EditorSettings.useLegacyProbeSampleCount = _value.Read<global::System.Boolean>();  return true;
                default: return false;
            }
        }
    }
}
#pragma warning restore 0109, 0162, 0168, 0219
#endif
