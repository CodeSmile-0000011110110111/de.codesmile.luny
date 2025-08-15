
// --------------------------------------------------------------
// GENERATED FILE ----> DO NOT EDIT <---- CHANGES WILL BE LOST !!
// --------------------------------------------------------------

#if UNITY_6000_0_OR_NEWER && !(UNITY_6000_1_OR_NEWER)
#pragma warning disable 0109, 0162, 0168, 0219
using Luny;

namespace Luny.UnityEditor
{
    public sealed class LuaTextureImporter : global::Luny.UnityEditor.LuaAssetImporter, global::Luny.ILuaObject<global::UnityEditor.TextureImporter>
    {
        public new static global::Lua.LuaValue Bind(global::UnityEditor.TextureImporter instance) => new LuaTextureImporter(instance);
        public new static global::Lua.LuaValue Bind(global::System.Object instance) => Bind((global::UnityEditor.TextureImporter)instance);
        public new static global::Lua.LuaValue Bind(global::System.Collections.Generic.IList<global::UnityEditor.TextureImporter> instances) =>
            new global::Luny.LuaList<global::UnityEditor.TextureImporter>(instances);
        public new static global::Lua.LuaValue Bind(global::System.Collections.Generic.IList<global::System.Object> instances) =>
            new global::Luny.LuaList<global::UnityEditor.TextureImporter>(instances);
        private LuaTextureImporter(global::UnityEditor.TextureImporter instance) : base(instance) {}
        public static implicit operator global::Lua.LuaValue(LuaTextureImporter value) => new(value);
        public new global::UnityEditor.TextureImporter Instance => (global::UnityEditor.TextureImporter)m_Instance;
        public new global::System.Type BindType => typeof(global::UnityEditor.TextureImporter);
        private static global::Lua.LuaTable s_Metatable;
        public new global::Lua.LuaTable Metatable
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

        private static readonly global::Lua.LuaFunction _LuaTextureImporter_ClearPlatformTextureSettings = new global::Lua.LuaFunction("ClearPlatformTextureSettings", (_context, _) =>
        {
            global::Lua.LuaValue _lastArg = default;
            global::System.Int32 _lastArgPos = default;
            global::System.Type _expectedType = default;
            var _argCount = _context.ArgumentCount;
            var _this = _context.GetArgument<LuaTextureImporter>(0);
            var _arg0 = _lastArg = _argCount > 1 ? _context.GetArgument(1) : global::Lua.LuaValue.Nil;
            _lastArgPos = 0; _expectedType = typeof(global::System.String);
            if (_arg0.TryRead<global::System.String>(out var _p0_System_String))
            {
                if (_argCount == 2)
                {
                    var platform = _p0_System_String;
                    _this.Instance.ClearPlatformTextureSettings(platform);
                    var _retCount = _context.Return();
                    return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                }
            }
            throw new global::Lua.LuaRuntimeException(_context.Thread, $"{"ClearPlatformTextureSettings"}: invalid argument #{_lastArgPos}: {_lastArg} ({_lastArg.Type}), expected: {_expectedType.FullName}", 2);
        });
        private static readonly global::Lua.LuaFunction _LuaTextureImporter_DoesSourceTextureHaveAlpha = new global::Lua.LuaFunction("DoesSourceTextureHaveAlpha", (_context, _) =>
        {
            global::Lua.LuaValue _lastArg = default;
            global::System.Int32 _lastArgPos = default;
            global::System.Type _expectedType = default;
            var _argCount = _context.ArgumentCount;
            var _this = _context.GetArgument<LuaTextureImporter>(0);
            if (_argCount == 1)
            {
                var _ret0 = _this.Instance.DoesSourceTextureHaveAlpha();
                var _lret0 = new global::Lua.LuaValue(_ret0);
                var _retCount = _context.Return(_lret0);
                return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
            }
            throw new global::Lua.LuaRuntimeException(_context.Thread, $"{"DoesSourceTextureHaveAlpha"}: invalid argument #{_lastArgPos}: {_lastArg} ({_lastArg.Type}), expected: {_expectedType.FullName}", 2);
        });
        private static readonly global::Lua.LuaFunction _LuaTextureImporter_GetAutomaticFormat = new global::Lua.LuaFunction("GetAutomaticFormat", (_context, _) =>
        {
            global::Lua.LuaValue _lastArg = default;
            global::System.Int32 _lastArgPos = default;
            global::System.Type _expectedType = default;
            var _argCount = _context.ArgumentCount;
            var _this = _context.GetArgument<LuaTextureImporter>(0);
            var _arg0 = _lastArg = _argCount > 1 ? _context.GetArgument(1) : global::Lua.LuaValue.Nil;
            _lastArgPos = 0; _expectedType = typeof(global::System.String);
            if (_arg0.TryRead<global::System.String>(out var _p0_System_String))
            {
                if (_argCount == 2)
                {
                    var platform = _p0_System_String;
                    var _ret0 = _this.Instance.GetAutomaticFormat(platform);
                    var _lret0 = new global::Lua.LuaValue((global::System.Int64)_ret0);
                    var _retCount = _context.Return(_lret0);
                    return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                }
            }
            throw new global::Lua.LuaRuntimeException(_context.Thread, $"{"GetAutomaticFormat"}: invalid argument #{_lastArgPos}: {_lastArg} ({_lastArg.Type}), expected: {_expectedType.FullName}", 2);
        });
        private static readonly global::Lua.LuaFunction _LuaTextureImporter_GetDefaultPlatformTextureSettings = new global::Lua.LuaFunction("GetDefaultPlatformTextureSettings", (_context, _) =>
        {
            global::Lua.LuaValue _lastArg = default;
            global::System.Int32 _lastArgPos = default;
            global::System.Type _expectedType = default;
            var _argCount = _context.ArgumentCount;
            var _this = _context.GetArgument<LuaTextureImporter>(0);
            if (_argCount == 1)
            {
                var _ret0 = _this.Instance.GetDefaultPlatformTextureSettings();
                var _factory = _context.GetObjectFactory();
                var _lret0 = _factory.Bind(_ret0);
                var _retCount = _context.Return(_lret0);
                return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
            }
            throw new global::Lua.LuaRuntimeException(_context.Thread, $"{"GetDefaultPlatformTextureSettings"}: invalid argument #{_lastArgPos}: {_lastArg} ({_lastArg.Type}), expected: {_expectedType.FullName}", 2);
        });
        private static readonly global::Lua.LuaFunction _LuaTextureImporter_GetPlatformTextureSettings = new global::Lua.LuaFunction("GetPlatformTextureSettings", (_context, _) =>
        {
            global::Lua.LuaValue _lastArg = default;
            global::System.Int32 _lastArgPos = default;
            global::System.Type _expectedType = default;
            var _argCount = _context.ArgumentCount;
            var _this = _context.GetArgument<LuaTextureImporter>(0);
            var _arg0 = _lastArg = _argCount > 1 ? _context.GetArgument(1) : global::Lua.LuaValue.Nil;
            _lastArgPos = 0; _expectedType = typeof(global::System.String);
            if (_arg0.TryRead<global::System.String>(out var _p0_System_String))
            {
                if (_argCount == 2)
                {
                    var platform = _p0_System_String;
                    var _ret0 = _this.Instance.GetPlatformTextureSettings(platform);
                    var _factory = _context.GetObjectFactory();
                    var _lret0 = _factory.Bind(_ret0);
                    var _retCount = _context.Return(_lret0);
                    return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                }
            }
            throw new global::Lua.LuaRuntimeException(_context.Thread, $"{"GetPlatformTextureSettings"}: invalid argument #{_lastArgPos}: {_lastArg} ({_lastArg.Type}), expected: {_expectedType.FullName}", 2);
        });
        private static readonly global::Lua.LuaFunction _LuaTextureImporter_ReadTextureSettings = new global::Lua.LuaFunction("ReadTextureSettings", (_context, _) =>
        {
            global::Lua.LuaValue _lastArg = default;
            global::System.Int32 _lastArgPos = default;
            global::System.Type _expectedType = default;
            var _argCount = _context.ArgumentCount;
            var _this = _context.GetArgument<LuaTextureImporter>(0);
            var _arg0 = _lastArg = _argCount > 1 ? _context.GetArgument(1) : global::Lua.LuaValue.Nil;
            _lastArgPos = 0; _expectedType = typeof(global::Luny.UnityEditor.LuaTextureImporterSettings);
            if (_arg0.TryRead<global::Luny.UnityEditor.LuaTextureImporterSettings>(out var _p0_UnityEditor_TextureImporterSettings))
            {
                if (_argCount == 2)
                {
                    var dest = _p0_UnityEditor_TextureImporterSettings.Instance;
                    _this.Instance.ReadTextureSettings(dest);
                    var _retCount = _context.Return();
                    return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                }
            }
            throw new global::Lua.LuaRuntimeException(_context.Thread, $"{"ReadTextureSettings"}: invalid argument #{_lastArgPos}: {_lastArg} ({_lastArg.Type}), expected: {_expectedType.FullName}", 2);
        });
        private static readonly global::Lua.LuaFunction _LuaTextureImporter_SetPlatformTextureSettings = new global::Lua.LuaFunction("SetPlatformTextureSettings", (_context, _) =>
        {
            global::Lua.LuaValue _lastArg = default;
            global::System.Int32 _lastArgPos = default;
            global::System.Type _expectedType = default;
            var _argCount = _context.ArgumentCount;
            var _this = _context.GetArgument<LuaTextureImporter>(0);
            var _arg0 = _lastArg = _argCount > 1 ? _context.GetArgument(1) : global::Lua.LuaValue.Nil;
            _lastArgPos = 0; _expectedType = typeof(global::Luny.UnityEditor.LuaTextureImporterPlatformSettings);
            if (_arg0.TryRead<global::Luny.UnityEditor.LuaTextureImporterPlatformSettings>(out var _p0_UnityEditor_TextureImporterPlatformSettings))
            {
                if (_argCount == 2)
                {
                    var platformSettings = _p0_UnityEditor_TextureImporterPlatformSettings.Instance;
                    _this.Instance.SetPlatformTextureSettings(platformSettings);
                    var _retCount = _context.Return();
                    return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                }
            }
            throw new global::Lua.LuaRuntimeException(_context.Thread, $"{"SetPlatformTextureSettings"}: invalid argument #{_lastArgPos}: {_lastArg} ({_lastArg.Type}), expected: {_expectedType.FullName}", 2);
        });
        private static readonly global::Lua.LuaFunction _LuaTextureImporter_SetTextureSettings = new global::Lua.LuaFunction("SetTextureSettings", (_context, _) =>
        {
            global::Lua.LuaValue _lastArg = default;
            global::System.Int32 _lastArgPos = default;
            global::System.Type _expectedType = default;
            var _argCount = _context.ArgumentCount;
            var _this = _context.GetArgument<LuaTextureImporter>(0);
            var _arg0 = _lastArg = _argCount > 1 ? _context.GetArgument(1) : global::Lua.LuaValue.Nil;
            _lastArgPos = 0; _expectedType = typeof(global::Luny.UnityEditor.LuaTextureImporterSettings);
            if (_arg0.TryRead<global::Luny.UnityEditor.LuaTextureImporterSettings>(out var _p0_UnityEditor_TextureImporterSettings))
            {
                if (_argCount == 2)
                {
                    var src = _p0_UnityEditor_TextureImporterSettings.Instance;
                    _this.Instance.SetTextureSettings(src);
                    var _retCount = _context.Return();
                    return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                }
            }
            throw new global::Lua.LuaRuntimeException(_context.Thread, $"{"SetTextureSettings"}: invalid argument #{_lastArgPos}: {_lastArg} ({_lastArg.Type}), expected: {_expectedType.FullName}", 2);
        });
        private static readonly global::Lua.LuaFunction __index = new(global::Lua.Runtime.Metamethods.Index, (_context, _) =>
        {
            var _this = _context.GetArgument<LuaTextureImporter>(0);
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
            var _this = _context.GetArgument<LuaTextureImporter>(0);
            var _key = _context.GetArgument(1);
            var _value = _context.GetArgument(2);
            if (_key.Type == global::Lua.LuaValueType.Number && _key.TryRead<global::System.Int32>(out var _index) && _this.TrySetLuaValue(_index, _value))
                return new global::System.Threading.Tasks.ValueTask<global::System.Int32>(_context.Return(_value));
            if (_key.Type == global::Lua.LuaValueType.String && _this.TrySetLuaValue(_key.Read<global::System.String>(), _value))
                return new global::System.Threading.Tasks.ValueTask<global::System.Int32>(_context.Return(_value));
            throw new global::Lua.LuaRuntimeException(_context.Thread, $"attempt to assign to unknown '{_key}' on '{_this}'", 2);
        });

        public override global::System.Boolean TryGetLuaValue(global::System.Int32 _key, out global::Lua.LuaValue _value, global::Luny.ILuaObjectFactory _factory)
        {
            return base.TryGetLuaValue(_key, out _value, _factory);
        }
        public override global::System.Boolean TryGetLuaValue(global::System.String _key, out global::Lua.LuaValue _value, global::Luny.ILuaObjectFactory _factory)
        {
            switch (_key)
            {
                case "ClearPlatformTextureSettings": _value = _LuaTextureImporter_ClearPlatformTextureSettings; return true;
                case "DoesSourceTextureHaveAlpha": _value = _LuaTextureImporter_DoesSourceTextureHaveAlpha; return true;
                case "GetAutomaticFormat": _value = _LuaTextureImporter_GetAutomaticFormat; return true;
                case "GetDefaultPlatformTextureSettings": _value = _LuaTextureImporter_GetDefaultPlatformTextureSettings; return true;
                case "GetPlatformTextureSettings": _value = _LuaTextureImporter_GetPlatformTextureSettings; return true;
                case "ReadTextureSettings": _value = _LuaTextureImporter_ReadTextureSettings; return true;
                case "SetPlatformTextureSettings": _value = _LuaTextureImporter_SetPlatformTextureSettings; return true;
                case "SetTextureSettings": _value = _LuaTextureImporter_SetTextureSettings; return true;
                case "allowAlphaSplitting": _value = new global::Lua.LuaValue(Instance.allowAlphaSplitting); return true;
                case "alphaIsTransparency": _value = new global::Lua.LuaValue(Instance.alphaIsTransparency); return true;
                case "alphaSource": _value = new global::Lua.LuaValue((global::System.Int64)Instance.alphaSource); return true;
                case "alphaTestReferenceValue": _value = new global::Lua.LuaValue(Instance.alphaTestReferenceValue); return true;
                case "androidETC2FallbackOverride": _value = new global::Lua.LuaValue((global::System.Int64)Instance.androidETC2FallbackOverride); return true;
                case "anisoLevel": _value = new global::Lua.LuaValue(Instance.anisoLevel); return true;
                case "borderMipmap": _value = new global::Lua.LuaValue(Instance.borderMipmap); return true;
                case "compressionQuality": _value = new global::Lua.LuaValue(Instance.compressionQuality); return true;
                case "convertToNormalmap": _value = new global::Lua.LuaValue(Instance.convertToNormalmap); return true;
                case "crunchedCompression": _value = new global::Lua.LuaValue(Instance.crunchedCompression); return true;
                case "fadeout": _value = new global::Lua.LuaValue(Instance.fadeout); return true;
                case "filterMode": _value = new global::Lua.LuaValue((global::System.Int64)Instance.filterMode); return true;
                case "flipGreenChannel": _value = new global::Lua.LuaValue(Instance.flipGreenChannel); return true;
                case "generateCubemap": _value = new global::Lua.LuaValue((global::System.Int64)Instance.generateCubemap); return true;
                case "heightmapScale": _value = new global::Lua.LuaValue(Instance.heightmapScale); return true;
                case "ignoreMipmapLimit": _value = new global::Lua.LuaValue(Instance.ignoreMipmapLimit); return true;
                case "ignorePngGamma": _value = new global::Lua.LuaValue(Instance.ignorePngGamma); return true;
                case "isReadable": _value = new global::Lua.LuaValue(Instance.isReadable); return true;
                case "maxTextureSize": _value = new global::Lua.LuaValue(Instance.maxTextureSize); return true;
                case "mipMapBias": _value = new global::Lua.LuaValue(Instance.mipMapBias); return true;
                case "mipmapEnabled": _value = new global::Lua.LuaValue(Instance.mipmapEnabled); return true;
                case "mipmapFadeDistanceEnd": _value = new global::Lua.LuaValue(Instance.mipmapFadeDistanceEnd); return true;
                case "mipmapFadeDistanceStart": _value = new global::Lua.LuaValue(Instance.mipmapFadeDistanceStart); return true;
                case "mipmapFilter": _value = new global::Lua.LuaValue((global::System.Int64)Instance.mipmapFilter); return true;
                case "mipmapLimitGroupName": _value = new global::Lua.LuaValue(Instance.mipmapLimitGroupName); return true;
                case "mipMapsPreserveCoverage": _value = new global::Lua.LuaValue(Instance.mipMapsPreserveCoverage); return true;
                case "normalmapFilter": _value = new global::Lua.LuaValue((global::System.Int64)Instance.normalmapFilter); return true;
                case "npotScale": _value = new global::Lua.LuaValue((global::System.Int64)Instance.npotScale); return true;
                case "qualifiesForSpritePacking": _value = new global::Lua.LuaValue(Instance.qualifiesForSpritePacking); return true;
                case "secondarySpriteTextures": _value = _factory.Bind(Instance.secondarySpriteTextures); return true;
                case "spriteBorder": _value = global::Luny.UnityEngine.LuaVector4.Bind(Instance.spriteBorder); return true;
                case "spriteImportMode": _value = new global::Lua.LuaValue((global::System.Int64)Instance.spriteImportMode); return true;
                case "spritePivot": _value = global::Luny.UnityEngine.LuaVector2.Bind(Instance.spritePivot); return true;
                case "spritePixelsPerUnit": _value = new global::Lua.LuaValue(Instance.spritePixelsPerUnit); return true;
                case "sRGBTexture": _value = new global::Lua.LuaValue(Instance.sRGBTexture); return true;
                case "streamingMipmaps": _value = new global::Lua.LuaValue(Instance.streamingMipmaps); return true;
                case "streamingMipmapsPriority": _value = new global::Lua.LuaValue(Instance.streamingMipmapsPriority); return true;
                case "swizzleA": _value = new global::Lua.LuaValue((global::System.Int64)Instance.swizzleA); return true;
                case "swizzleB": _value = new global::Lua.LuaValue((global::System.Int64)Instance.swizzleB); return true;
                case "swizzleG": _value = new global::Lua.LuaValue((global::System.Int64)Instance.swizzleG); return true;
                case "swizzleR": _value = new global::Lua.LuaValue((global::System.Int64)Instance.swizzleR); return true;
                case "textureCompression": _value = new global::Lua.LuaValue((global::System.Int64)Instance.textureCompression); return true;
                case "textureShape": _value = new global::Lua.LuaValue((global::System.Int64)Instance.textureShape); return true;
                case "textureType": _value = new global::Lua.LuaValue((global::System.Int64)Instance.textureType); return true;
                case "vtOnly": _value = new global::Lua.LuaValue(Instance.vtOnly); return true;
                case "wrapMode": _value = new global::Lua.LuaValue((global::System.Int64)Instance.wrapMode); return true;
                case "wrapModeU": _value = new global::Lua.LuaValue((global::System.Int64)Instance.wrapModeU); return true;
                case "wrapModeV": _value = new global::Lua.LuaValue((global::System.Int64)Instance.wrapModeV); return true;
                case "wrapModeW": _value = new global::Lua.LuaValue((global::System.Int64)Instance.wrapModeW); return true;
                default: return base.TryGetLuaValue(_key, out _value, _factory);
            }
        }
        public override global::System.Boolean TrySetLuaValue(global::System.Int32 _key, global::Lua.LuaValue _value)
        {
            return base.TrySetLuaValue(_key, _value);
        }
        public override global::System.Boolean TrySetLuaValue(global::System.String _key, global::Lua.LuaValue _value)
        {
            switch (_key)
            {
                case "allowAlphaSplitting": Instance.allowAlphaSplitting = _value.Read<global::System.Boolean>();  return true;
                case "alphaIsTransparency": Instance.alphaIsTransparency = _value.Read<global::System.Boolean>();  return true;
                case "alphaSource": Instance.alphaSource = _value.Read<global::UnityEditor.TextureImporterAlphaSource>();  return true;
                case "alphaTestReferenceValue": Instance.alphaTestReferenceValue = _value.Read<global::System.Single>();  return true;
                case "androidETC2FallbackOverride": Instance.androidETC2FallbackOverride = _value.Read<global::UnityEditor.AndroidETC2FallbackOverride>();  return true;
                case "anisoLevel": Instance.anisoLevel = _value.Read<global::System.Int32>();  return true;
                case "borderMipmap": Instance.borderMipmap = _value.Read<global::System.Boolean>();  return true;
                case "compressionQuality": Instance.compressionQuality = _value.Read<global::System.Int32>();  return true;
                case "convertToNormalmap": Instance.convertToNormalmap = _value.Read<global::System.Boolean>();  return true;
                case "crunchedCompression": Instance.crunchedCompression = _value.Read<global::System.Boolean>();  return true;
                case "fadeout": Instance.fadeout = _value.Read<global::System.Boolean>();  return true;
                case "filterMode": Instance.filterMode = _value.Read<global::UnityEngine.FilterMode>();  return true;
                case "flipGreenChannel": Instance.flipGreenChannel = _value.Read<global::System.Boolean>();  return true;
                case "generateCubemap": Instance.generateCubemap = _value.Read<global::UnityEditor.TextureImporterGenerateCubemap>();  return true;
                case "heightmapScale": Instance.heightmapScale = _value.Read<global::System.Single>();  return true;
                case "ignoreMipmapLimit": Instance.ignoreMipmapLimit = _value.Read<global::System.Boolean>();  return true;
                case "ignorePngGamma": Instance.ignorePngGamma = _value.Read<global::System.Boolean>();  return true;
                case "isReadable": Instance.isReadable = _value.Read<global::System.Boolean>();  return true;
                case "maxTextureSize": Instance.maxTextureSize = _value.Read<global::System.Int32>();  return true;
                case "mipMapBias": Instance.mipMapBias = _value.Read<global::System.Single>();  return true;
                case "mipmapEnabled": Instance.mipmapEnabled = _value.Read<global::System.Boolean>();  return true;
                case "mipmapFadeDistanceEnd": Instance.mipmapFadeDistanceEnd = _value.Read<global::System.Int32>();  return true;
                case "mipmapFadeDistanceStart": Instance.mipmapFadeDistanceStart = _value.Read<global::System.Int32>();  return true;
                case "mipmapFilter": Instance.mipmapFilter = _value.Read<global::UnityEditor.TextureImporterMipFilter>();  return true;
                case "mipmapLimitGroupName": Instance.mipmapLimitGroupName = _value.Read<global::System.String>();  return true;
                case "mipMapsPreserveCoverage": Instance.mipMapsPreserveCoverage = _value.Read<global::System.Boolean>();  return true;
                case "normalmapFilter": Instance.normalmapFilter = _value.Read<global::UnityEditor.TextureImporterNormalFilter>();  return true;
                case "npotScale": Instance.npotScale = _value.Read<global::UnityEditor.TextureImporterNPOTScale>();  return true;
                case "secondarySpriteTextures": Instance.secondarySpriteTextures = _value.Read<global::UnityEngine.SecondarySpriteTexture[]>();  return true;
                case "spriteBorder": Instance.spriteBorder = _value.Read<global::Luny.UnityEngine.LuaVector4>().Value;  return true;
                case "spriteImportMode": Instance.spriteImportMode = _value.Read<global::UnityEditor.SpriteImportMode>();  return true;
                case "spritePivot": Instance.spritePivot = _value.Read<global::Luny.UnityEngine.LuaVector2>().Value;  return true;
                case "spritePixelsPerUnit": Instance.spritePixelsPerUnit = _value.Read<global::System.Single>();  return true;
                case "sRGBTexture": Instance.sRGBTexture = _value.Read<global::System.Boolean>();  return true;
                case "streamingMipmaps": Instance.streamingMipmaps = _value.Read<global::System.Boolean>();  return true;
                case "streamingMipmapsPriority": Instance.streamingMipmapsPriority = _value.Read<global::System.Int32>();  return true;
                case "swizzleA": Instance.swizzleA = _value.Read<global::UnityEditor.TextureImporterSwizzle>();  return true;
                case "swizzleB": Instance.swizzleB = _value.Read<global::UnityEditor.TextureImporterSwizzle>();  return true;
                case "swizzleG": Instance.swizzleG = _value.Read<global::UnityEditor.TextureImporterSwizzle>();  return true;
                case "swizzleR": Instance.swizzleR = _value.Read<global::UnityEditor.TextureImporterSwizzle>();  return true;
                case "textureCompression": Instance.textureCompression = _value.Read<global::UnityEditor.TextureImporterCompression>();  return true;
                case "textureShape": Instance.textureShape = _value.Read<global::UnityEditor.TextureImporterShape>();  return true;
                case "textureType": Instance.textureType = _value.Read<global::UnityEditor.TextureImporterType>();  return true;
                case "vtOnly": Instance.vtOnly = _value.Read<global::System.Boolean>();  return true;
                case "wrapMode": Instance.wrapMode = _value.Read<global::UnityEngine.TextureWrapMode>();  return true;
                case "wrapModeU": Instance.wrapModeU = _value.Read<global::UnityEngine.TextureWrapMode>();  return true;
                case "wrapModeV": Instance.wrapModeV = _value.Read<global::UnityEngine.TextureWrapMode>();  return true;
                case "wrapModeW": Instance.wrapModeW = _value.Read<global::UnityEngine.TextureWrapMode>();  return true;
                default: return base.TrySetLuaValue(_key, _value);
            }
        }
    }
    public sealed class LuaTextureImporterType : global::Luny.ILuaStatic
    {
        public static global::Lua.LuaValue Bind() => new LuaTextureImporterType();
        private LuaTextureImporterType() {}
        public static implicit operator global::Lua.LuaValue(LuaTextureImporterType value) => new(value);
        public global::System.Type BindType => typeof(global::UnityEditor.TextureImporter);
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
            metatable[global::Lua.Runtime.Metamethods.Call] = _LuaTextureImporter_new;
            return metatable;
        }
        public override global::System.String ToString() => BindType.FullName;
#if UNITY_EDITOR
        [global::UnityEngine.RuntimeInitializeOnLoadMethod(global::UnityEngine.RuntimeInitializeLoadType.SubsystemRegistration)]
        private static void ResetStaticFields() => s_Metatable = null;
#endif

        private static readonly global::Lua.LuaFunction _LuaTextureImporter_new = new global::Lua.LuaFunction(".ctor", (_context, _) =>
        {
            global::Lua.LuaValue _lastArg = default;
            global::System.Int32 _lastArgPos = default;
            global::System.Type _expectedType = default;
            var _argCount = _context.ArgumentCount;
            if (_argCount == 1)
            {
                var _ret0 = new global::UnityEditor.TextureImporter();
                var _factory = _context.GetObjectFactory();
                var _lret0 = _factory.Bind(_ret0);
                var _retCount = _context.Return(_lret0);
                return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
            }
            throw new global::Lua.LuaRuntimeException(_context.Thread, $"{".ctor"}: invalid argument #{_lastArgPos}: {_lastArg} ({_lastArg.Type}), expected: {_expectedType.FullName}", 2);
        });
        private static readonly global::Lua.LuaFunction _LuaTextureImporter_IsDefaultPlatformTextureFormatValid = new global::Lua.LuaFunction("IsDefaultPlatformTextureFormatValid", (_context, _) =>
        {
            global::Lua.LuaValue _lastArg = default;
            global::System.Int32 _lastArgPos = default;
            global::System.Type _expectedType = default;
            var _argCount = _context.ArgumentCount;
            var _arg0 = _lastArg = _argCount > 0 ? _context.GetArgument(0) : global::Lua.LuaValue.Nil;
            _lastArgPos = 0; _expectedType = typeof(global::UnityEditor.TextureImporterType);
            if (_arg0.TryRead<global::UnityEditor.TextureImporterType>(out var _p0_UnityEditor_TextureImporterType))
            {
                var _arg1 = _lastArg = _argCount > 1 ? _context.GetArgument(1) : global::Lua.LuaValue.Nil;
                _lastArgPos = 1; _expectedType = typeof(global::UnityEditor.TextureImporterFormat);
                if (_arg1.TryRead<global::UnityEditor.TextureImporterFormat>(out var _p1_UnityEditor_TextureImporterFormat))
                {
                    if (_argCount == 2)
                    {
                        var textureType = _p0_UnityEditor_TextureImporterType;
                        var currentFormat = _p1_UnityEditor_TextureImporterFormat;
                        var _ret0 = global::UnityEditor.TextureImporter.IsDefaultPlatformTextureFormatValid(textureType, currentFormat);
                        var _lret0 = new global::Lua.LuaValue(_ret0);
                        var _retCount = _context.Return(_lret0);
                        return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                    }
                }
            }
            throw new global::Lua.LuaRuntimeException(_context.Thread, $"{"IsDefaultPlatformTextureFormatValid"}: invalid argument #{_lastArgPos}: {_lastArg} ({_lastArg.Type}), expected: {_expectedType.FullName}", 2);
        });
        private static readonly global::Lua.LuaFunction _LuaTextureImporter_IsPlatformTextureFormatValid = new global::Lua.LuaFunction("IsPlatformTextureFormatValid", (_context, _) =>
        {
            global::Lua.LuaValue _lastArg = default;
            global::System.Int32 _lastArgPos = default;
            global::System.Type _expectedType = default;
            var _argCount = _context.ArgumentCount;
            var _arg0 = _lastArg = _argCount > 0 ? _context.GetArgument(0) : global::Lua.LuaValue.Nil;
            _lastArgPos = 0; _expectedType = typeof(global::UnityEditor.TextureImporterType);
            if (_arg0.TryRead<global::UnityEditor.TextureImporterType>(out var _p0_UnityEditor_TextureImporterType))
            {
                var _arg1 = _lastArg = _argCount > 1 ? _context.GetArgument(1) : global::Lua.LuaValue.Nil;
                _lastArgPos = 1; _expectedType = typeof(global::UnityEditor.BuildTarget);
                if (_arg1.TryRead<global::UnityEditor.BuildTarget>(out var _p1_UnityEditor_BuildTarget))
                {
                    var _arg2 = _lastArg = _argCount > 2 ? _context.GetArgument(2) : global::Lua.LuaValue.Nil;
                    _lastArgPos = 2; _expectedType = typeof(global::UnityEditor.TextureImporterFormat);
                    if (_arg2.TryRead<global::UnityEditor.TextureImporterFormat>(out var _p2_UnityEditor_TextureImporterFormat))
                    {
                        if (_argCount == 3)
                        {
                            var textureType = _p0_UnityEditor_TextureImporterType;
                            var target = _p1_UnityEditor_BuildTarget;
                            var currentFormat = _p2_UnityEditor_TextureImporterFormat;
                            var _ret0 = global::UnityEditor.TextureImporter.IsPlatformTextureFormatValid(textureType, target, currentFormat);
                            var _lret0 = new global::Lua.LuaValue(_ret0);
                            var _retCount = _context.Return(_lret0);
                            return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                        }
                    }
                }
            }
            throw new global::Lua.LuaRuntimeException(_context.Thread, $"{"IsPlatformTextureFormatValid"}: invalid argument #{_lastArgPos}: {_lastArg} ({_lastArg.Type}), expected: {_expectedType.FullName}", 2);
        });
        private static readonly global::Lua.LuaFunction __index = new(global::Lua.Runtime.Metamethods.Index, (_context, _) =>
        {
            var _this = _context.GetArgument<LuaTextureImporterType>(0);
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
            var _this = _context.GetArgument<LuaTextureImporterType>(0);
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
                case "IsDefaultPlatformTextureFormatValid": _value = _LuaTextureImporter_IsDefaultPlatformTextureFormatValid; return true;
                case "IsPlatformTextureFormatValid": _value = _LuaTextureImporter_IsPlatformTextureFormatValid; return true;
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
