
// --------------------------------------------------------------
// GENERATED FILE ----> DO NOT EDIT <---- CHANGES WILL BE LOST !!
// --------------------------------------------------------------

#if UNITY_6000_2_OR_NEWER && !(UNITY_6000_3_OR_NEWER)
#pragma warning disable 0109, 0162, 0168, 0219
using Luny;

namespace LunyEditor.UnityEditor
{
    public sealed class LuaTextureImporterSettings : global::Luny.ILuaObject<global::UnityEditor.TextureImporterSettings>
    {
        public new static global::Lua.LuaValue Bind(global::UnityEditor.TextureImporterSettings instance) => new LuaTextureImporterSettings(instance);
        public new static global::Lua.LuaValue Bind(global::System.Object instance) => Bind((global::UnityEditor.TextureImporterSettings)instance);
        public new static global::Lua.LuaValue Bind(global::System.Collections.Generic.IList<global::UnityEditor.TextureImporterSettings> instances) =>
            new global::Luny.LuaList<global::UnityEditor.TextureImporterSettings>(instances);
        public new static global::Lua.LuaValue Bind(global::System.Collections.Generic.IList<global::System.Object> instances) =>
            new global::Luny.LuaList<global::UnityEditor.TextureImporterSettings>(instances);
        private LuaTextureImporterSettings(global::UnityEditor.TextureImporterSettings instance) => m_Instance = instance;
        public static implicit operator global::Lua.LuaValue(LuaTextureImporterSettings value) => new(value);
        private global::UnityEditor.TextureImporterSettings m_Instance;
        public global::UnityEditor.TextureImporterSettings Instance => m_Instance;
        public new global::System.Type BindType => typeof(global::UnityEditor.TextureImporterSettings);
        public override global::System.String ToString() => m_Instance != null ? Instance.ToString() : "{GetType().Name}(null)";
#if UNITY_EDITOR
        [global::UnityEngine.RuntimeInitializeOnLoadMethod(global::UnityEngine.RuntimeInitializeLoadType.SubsystemRegistration)]
        private static void ResetStaticFields() => s_Metatable = null;
#endif

        private static readonly global::Lua.LuaFunction _LuaTextureImporterSettings_ApplyTextureType = new global::Lua.LuaFunction("ApplyTextureType", (_context, _) =>
        {
            global::Lua.LuaValue _lastArg = default;
            global::System.Int32 _lastArgPos = default;
            global::System.Type _expectedType = default;
            var _argCount = _context.ArgumentCount;
            var _this = _context.GetArgument<LuaTextureImporterSettings>(0);
            var _arg0 = _lastArg = _argCount > 1 ? _context.GetArgument(1) : global::Lua.LuaValue.Nil;
            _lastArgPos = 0; _expectedType = typeof(global::UnityEditor.TextureImporterType);
            if (_arg0.TryRead<global::UnityEditor.TextureImporterType>(out var _p0_UnityEditor_TextureImporterType))
            {
                if (_argCount == 2)
                {
                    var type = _p0_UnityEditor_TextureImporterType;
                    _this.Instance.ApplyTextureType(type);
                    var _retCount = _context.Return();
                    return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                }
            }
            throw new global::Lua.LuaRuntimeException(_context.Thread, $"{"ApplyTextureType"}: invalid argument #{_lastArgPos}: {_lastArg} ({_lastArg.Type}), expected: {_expectedType.FullName}", 2);
        });
        private static readonly global::Lua.LuaFunction _LuaTextureImporterSettings_CopyTo = new global::Lua.LuaFunction("CopyTo", (_context, _) =>
        {
            global::Lua.LuaValue _lastArg = default;
            global::System.Int32 _lastArgPos = default;
            global::System.Type _expectedType = default;
            var _argCount = _context.ArgumentCount;
            var _this = _context.GetArgument<LuaTextureImporterSettings>(0);
            var _arg0 = _lastArg = _argCount > 1 ? _context.GetArgument(1) : global::Lua.LuaValue.Nil;
            _lastArgPos = 0; _expectedType = typeof(global::LunyEditor.UnityEditor.LuaTextureImporterSettings);
            if (_arg0.TryRead<global::LunyEditor.UnityEditor.LuaTextureImporterSettings>(out var _p0_UnityEditor_TextureImporterSettings))
            {
                if (_argCount == 2)
                {
                    var target = _p0_UnityEditor_TextureImporterSettings.Instance;
                    _this.Instance.CopyTo(target);
                    var _retCount = _context.Return();
                    return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                }
            }
            throw new global::Lua.LuaRuntimeException(_context.Thread, $"{"CopyTo"}: invalid argument #{_lastArgPos}: {_lastArg} ({_lastArg.Type}), expected: {_expectedType.FullName}", 2);
        });
        private static readonly global::Lua.LuaFunction __index = new(global::Lua.Runtime.Metamethods.Index, (_context, _) =>
        {
            var _this = _context.GetArgument<LuaTextureImporterSettings>(0);
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
            var _this = _context.GetArgument<LuaTextureImporterSettings>(0);
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
            var metatable = new global::Lua.LuaTable(0, 5);
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
                case "ApplyTextureType": _value = _LuaTextureImporterSettings_ApplyTextureType; return true;
                case "CopyTo": _value = _LuaTextureImporterSettings_CopyTo; return true;
                case "alphaIsTransparency": _value = new global::Lua.LuaValue(Instance.alphaIsTransparency); return true;
                case "alphaSource": _value = new global::Lua.LuaValue((global::System.Int64)Instance.alphaSource); return true;
                case "alphaTestReferenceValue": _value = new global::Lua.LuaValue(Instance.alphaTestReferenceValue); return true;
                case "aniso": _value = new global::Lua.LuaValue(Instance.aniso); return true;
                case "borderMipmap": _value = new global::Lua.LuaValue(Instance.borderMipmap); return true;
                case "convertToNormalMap": _value = new global::Lua.LuaValue(Instance.convertToNormalMap); return true;
                case "cubemapConvolution": _value = new global::Lua.LuaValue((global::System.Int64)Instance.cubemapConvolution); return true;
                case "fadeOut": _value = new global::Lua.LuaValue(Instance.fadeOut); return true;
                case "filterMode": _value = new global::Lua.LuaValue((global::System.Int64)Instance.filterMode); return true;
                case "flipbookColumns": _value = new global::Lua.LuaValue(Instance.flipbookColumns); return true;
                case "flipbookRows": _value = new global::Lua.LuaValue(Instance.flipbookRows); return true;
                case "flipGreenChannel": _value = new global::Lua.LuaValue(Instance.flipGreenChannel); return true;
                case "generateCubemap": _value = new global::Lua.LuaValue((global::System.Int64)Instance.generateCubemap); return true;
                case "heightmapScale": _value = new global::Lua.LuaValue(Instance.heightmapScale); return true;
                case "ignoreMipmapLimit": _value = new global::Lua.LuaValue(Instance.ignoreMipmapLimit); return true;
                case "ignorePngGamma": _value = new global::Lua.LuaValue(Instance.ignorePngGamma); return true;
                case "mipmapBias": _value = new global::Lua.LuaValue(Instance.mipmapBias); return true;
                case "mipmapEnabled": _value = new global::Lua.LuaValue(Instance.mipmapEnabled); return true;
                case "mipmapFadeDistanceEnd": _value = new global::Lua.LuaValue(Instance.mipmapFadeDistanceEnd); return true;
                case "mipmapFadeDistanceStart": _value = new global::Lua.LuaValue(Instance.mipmapFadeDistanceStart); return true;
                case "mipmapFilter": _value = new global::Lua.LuaValue((global::System.Int64)Instance.mipmapFilter); return true;
                case "mipMapsPreserveCoverage": _value = new global::Lua.LuaValue(Instance.mipMapsPreserveCoverage); return true;
                case "normalMapFilter": _value = new global::Lua.LuaValue((global::System.Int64)Instance.normalMapFilter); return true;
                case "npotScale": _value = new global::Lua.LuaValue((global::System.Int64)Instance.npotScale); return true;
                case "readable": _value = new global::Lua.LuaValue(Instance.readable); return true;
                case "seamlessCubemap": _value = new global::Lua.LuaValue(Instance.seamlessCubemap); return true;
                case "singleChannelComponent": _value = new global::Lua.LuaValue((global::System.Int64)Instance.singleChannelComponent); return true;
                case "spriteAlignment": _value = new global::Lua.LuaValue(Instance.spriteAlignment); return true;
                case "spriteBorder": _value = global::Luny.UnityEngine.LuaVector4.Bind(Instance.spriteBorder); return true;
                case "spriteExtrude": _value = new global::Lua.LuaValue(Instance.spriteExtrude); return true;
                case "spriteGenerateFallbackPhysicsShape": _value = new global::Lua.LuaValue(Instance.spriteGenerateFallbackPhysicsShape); return true;
                case "spriteMeshType": _value = new global::Lua.LuaValue((global::System.Int64)Instance.spriteMeshType); return true;
                case "spriteMode": _value = new global::Lua.LuaValue(Instance.spriteMode); return true;
                case "spritePivot": _value = global::Luny.UnityEngine.LuaVector2.Bind(Instance.spritePivot); return true;
                case "spritePixelsPerUnit": _value = new global::Lua.LuaValue(Instance.spritePixelsPerUnit); return true;
                case "spriteTessellationDetail": _value = new global::Lua.LuaValue(Instance.spriteTessellationDetail); return true;
                case "sRGBTexture": _value = new global::Lua.LuaValue(Instance.sRGBTexture); return true;
                case "streamingMipmaps": _value = new global::Lua.LuaValue(Instance.streamingMipmaps); return true;
                case "streamingMipmapsPriority": _value = new global::Lua.LuaValue(Instance.streamingMipmapsPriority); return true;
                case "swizzleA": _value = new global::Lua.LuaValue((global::System.Int64)Instance.swizzleA); return true;
                case "swizzleB": _value = new global::Lua.LuaValue((global::System.Int64)Instance.swizzleB); return true;
                case "swizzleG": _value = new global::Lua.LuaValue((global::System.Int64)Instance.swizzleG); return true;
                case "swizzleR": _value = new global::Lua.LuaValue((global::System.Int64)Instance.swizzleR); return true;
                case "textureShape": _value = new global::Lua.LuaValue((global::System.Int64)Instance.textureShape); return true;
                case "textureType": _value = new global::Lua.LuaValue((global::System.Int64)Instance.textureType); return true;
                case "vtOnly": _value = new global::Lua.LuaValue(Instance.vtOnly); return true;
                case "wrapMode": _value = new global::Lua.LuaValue((global::System.Int64)Instance.wrapMode); return true;
                case "wrapModeU": _value = new global::Lua.LuaValue((global::System.Int64)Instance.wrapModeU); return true;
                case "wrapModeV": _value = new global::Lua.LuaValue((global::System.Int64)Instance.wrapModeV); return true;
                case "wrapModeW": _value = new global::Lua.LuaValue((global::System.Int64)Instance.wrapModeW); return true;
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
                case "alphaIsTransparency": Instance.alphaIsTransparency = _value.Read<global::System.Boolean>();  return true;
                case "alphaSource": Instance.alphaSource = _value.Read<global::UnityEditor.TextureImporterAlphaSource>();  return true;
                case "alphaTestReferenceValue": Instance.alphaTestReferenceValue = _value.Read<global::System.Single>();  return true;
                case "aniso": Instance.aniso = _value.Read<global::System.Int32>();  return true;
                case "borderMipmap": Instance.borderMipmap = _value.Read<global::System.Boolean>();  return true;
                case "convertToNormalMap": Instance.convertToNormalMap = _value.Read<global::System.Boolean>();  return true;
                case "cubemapConvolution": Instance.cubemapConvolution = _value.Read<global::UnityEditor.TextureImporterCubemapConvolution>();  return true;
                case "fadeOut": Instance.fadeOut = _value.Read<global::System.Boolean>();  return true;
                case "filterMode": Instance.filterMode = _value.Read<global::UnityEngine.FilterMode>();  return true;
                case "flipbookColumns": Instance.flipbookColumns = _value.Read<global::System.Int32>();  return true;
                case "flipbookRows": Instance.flipbookRows = _value.Read<global::System.Int32>();  return true;
                case "flipGreenChannel": Instance.flipGreenChannel = _value.Read<global::System.Boolean>();  return true;
                case "generateCubemap": Instance.generateCubemap = _value.Read<global::UnityEditor.TextureImporterGenerateCubemap>();  return true;
                case "heightmapScale": Instance.heightmapScale = _value.Read<global::System.Single>();  return true;
                case "ignoreMipmapLimit": Instance.ignoreMipmapLimit = _value.Read<global::System.Boolean>();  return true;
                case "ignorePngGamma": Instance.ignorePngGamma = _value.Read<global::System.Boolean>();  return true;
                case "mipmapBias": Instance.mipmapBias = _value.Read<global::System.Single>();  return true;
                case "mipmapEnabled": Instance.mipmapEnabled = _value.Read<global::System.Boolean>();  return true;
                case "mipmapFadeDistanceEnd": Instance.mipmapFadeDistanceEnd = _value.Read<global::System.Int32>();  return true;
                case "mipmapFadeDistanceStart": Instance.mipmapFadeDistanceStart = _value.Read<global::System.Int32>();  return true;
                case "mipmapFilter": Instance.mipmapFilter = _value.Read<global::UnityEditor.TextureImporterMipFilter>();  return true;
                case "mipMapsPreserveCoverage": Instance.mipMapsPreserveCoverage = _value.Read<global::System.Boolean>();  return true;
                case "normalMapFilter": Instance.normalMapFilter = _value.Read<global::UnityEditor.TextureImporterNormalFilter>();  return true;
                case "npotScale": Instance.npotScale = _value.Read<global::UnityEditor.TextureImporterNPOTScale>();  return true;
                case "readable": Instance.readable = _value.Read<global::System.Boolean>();  return true;
                case "seamlessCubemap": Instance.seamlessCubemap = _value.Read<global::System.Boolean>();  return true;
                case "singleChannelComponent": Instance.singleChannelComponent = _value.Read<global::UnityEditor.TextureImporterSingleChannelComponent>();  return true;
                case "spriteAlignment": Instance.spriteAlignment = _value.Read<global::System.Int32>();  return true;
                case "spriteBorder": Instance.spriteBorder = _value.Read<global::Luny.UnityEngine.LuaVector4>().Value;  return true;
                case "spriteExtrude": Instance.spriteExtrude = _value.Read<global::System.UInt32>();  return true;
                case "spriteGenerateFallbackPhysicsShape": Instance.spriteGenerateFallbackPhysicsShape = _value.Read<global::System.Boolean>();  return true;
                case "spriteMeshType": Instance.spriteMeshType = _value.Read<global::UnityEngine.SpriteMeshType>();  return true;
                case "spriteMode": Instance.spriteMode = _value.Read<global::System.Int32>();  return true;
                case "spritePivot": Instance.spritePivot = _value.Read<global::Luny.UnityEngine.LuaVector2>().Value;  return true;
                case "spritePixelsPerUnit": Instance.spritePixelsPerUnit = _value.Read<global::System.Single>();  return true;
                case "spriteTessellationDetail": Instance.spriteTessellationDetail = _value.Read<global::System.Single>();  return true;
                case "sRGBTexture": Instance.sRGBTexture = _value.Read<global::System.Boolean>();  return true;
                case "streamingMipmaps": Instance.streamingMipmaps = _value.Read<global::System.Boolean>();  return true;
                case "streamingMipmapsPriority": Instance.streamingMipmapsPriority = _value.Read<global::System.Int32>();  return true;
                case "swizzleA": Instance.swizzleA = _value.Read<global::UnityEditor.TextureImporterSwizzle>();  return true;
                case "swizzleB": Instance.swizzleB = _value.Read<global::UnityEditor.TextureImporterSwizzle>();  return true;
                case "swizzleG": Instance.swizzleG = _value.Read<global::UnityEditor.TextureImporterSwizzle>();  return true;
                case "swizzleR": Instance.swizzleR = _value.Read<global::UnityEditor.TextureImporterSwizzle>();  return true;
                case "textureShape": Instance.textureShape = _value.Read<global::UnityEditor.TextureImporterShape>();  return true;
                case "textureType": Instance.textureType = _value.Read<global::UnityEditor.TextureImporterType>();  return true;
                case "vtOnly": Instance.vtOnly = _value.Read<global::System.Boolean>();  return true;
                case "wrapMode": Instance.wrapMode = _value.Read<global::UnityEngine.TextureWrapMode>();  return true;
                case "wrapModeU": Instance.wrapModeU = _value.Read<global::UnityEngine.TextureWrapMode>();  return true;
                case "wrapModeV": Instance.wrapModeV = _value.Read<global::UnityEngine.TextureWrapMode>();  return true;
                case "wrapModeW": Instance.wrapModeW = _value.Read<global::UnityEngine.TextureWrapMode>();  return true;
                default: return false;
            }
        }
    }
    public sealed class LuaTextureImporterSettingsType : global::Luny.ILuaStatic
    {
        public static global::Lua.LuaValue Bind() => new LuaTextureImporterSettingsType();
        private LuaTextureImporterSettingsType() {}
        public static implicit operator global::Lua.LuaValue(LuaTextureImporterSettingsType value) => new(value);
        public global::System.Type BindType => typeof(global::UnityEditor.TextureImporterSettings);
        public override global::System.String ToString() => BindType.FullName;
#if UNITY_EDITOR
        [global::UnityEngine.RuntimeInitializeOnLoadMethod(global::UnityEngine.RuntimeInitializeLoadType.SubsystemRegistration)]
        private static void ResetStaticFields() => s_Metatable = null;
#endif

        private static readonly global::Lua.LuaFunction _LuaTextureImporterSettings_new = new global::Lua.LuaFunction(".ctor", (_context, _) =>
        {
            global::Lua.LuaValue _lastArg = default;
            global::System.Int32 _lastArgPos = default;
            global::System.Type _expectedType = default;
            var _argCount = _context.ArgumentCount;
            if (_argCount == 1)
            {
                var _ret0 = new global::UnityEditor.TextureImporterSettings();
                var _factory = _context.GetObjectFactory();
                var _lret0 = _factory.Bind(_ret0);
                var _retCount = _context.Return(_lret0);
                return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
            }
            throw new global::Lua.LuaRuntimeException(_context.Thread, $"{".ctor"}: invalid argument #{_lastArgPos}: {_lastArg} ({_lastArg.Type}), expected: {_expectedType.FullName}", 2);
        });
        private static readonly global::Lua.LuaFunction _LuaTextureImporterSettings_Equal = new global::Lua.LuaFunction("Equal", (_context, _) =>
        {
            global::Lua.LuaValue _lastArg = default;
            global::System.Int32 _lastArgPos = default;
            global::System.Type _expectedType = default;
            var _argCount = _context.ArgumentCount;
            var _arg0 = _lastArg = _argCount > 0 ? _context.GetArgument(0) : global::Lua.LuaValue.Nil;
            _lastArgPos = 0; _expectedType = typeof(global::LunyEditor.UnityEditor.LuaTextureImporterSettings);
            if (_arg0.TryRead<global::LunyEditor.UnityEditor.LuaTextureImporterSettings>(out var _p0_UnityEditor_TextureImporterSettings))
            {
                var _arg1 = _lastArg = _argCount > 1 ? _context.GetArgument(1) : global::Lua.LuaValue.Nil;
                _lastArgPos = 1; _expectedType = typeof(global::LunyEditor.UnityEditor.LuaTextureImporterSettings);
                if (_arg1.TryRead<global::LunyEditor.UnityEditor.LuaTextureImporterSettings>(out var _p1_UnityEditor_TextureImporterSettings))
                {
                    if (_argCount == 2)
                    {
                        var a = _p0_UnityEditor_TextureImporterSettings.Instance;
                        var b = _p1_UnityEditor_TextureImporterSettings.Instance;
                        var _ret0 = global::UnityEditor.TextureImporterSettings.Equal(a, b);
                        var _lret0 = new global::Lua.LuaValue(_ret0);
                        var _retCount = _context.Return(_lret0);
                        return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                    }
                }
            }
            throw new global::Lua.LuaRuntimeException(_context.Thread, $"{"Equal"}: invalid argument #{_lastArgPos}: {_lastArg} ({_lastArg.Type}), expected: {_expectedType.FullName}", 2);
        });
        private static readonly global::Lua.LuaFunction __index = new(global::Lua.Runtime.Metamethods.Index, (_context, _) =>
        {
            var _this = _context.GetArgument<LuaTextureImporterSettingsType>(0);
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
            var _this = _context.GetArgument<LuaTextureImporterSettingsType>(0);
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
            var metatable = new global::Lua.LuaTable(0, 5);
            metatable[global::Lua.Runtime.Metamethods.Index] = __index;
            metatable[global::Lua.Runtime.Metamethods.NewIndex] = __newindex;
            metatable[global::Lua.Runtime.Metamethods.Concat] = global::Luny.LuaMetatable.ConcatMetamethod;
            metatable[global::Lua.Runtime.Metamethods.ToString] = global::Luny.LuaMetatable.ToStringMetamethod;
            metatable[global::Lua.Runtime.Metamethods.Call] = _LuaTextureImporterSettings_new;
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
                case "Equal": _value = _LuaTextureImporterSettings_Equal; return true;
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
