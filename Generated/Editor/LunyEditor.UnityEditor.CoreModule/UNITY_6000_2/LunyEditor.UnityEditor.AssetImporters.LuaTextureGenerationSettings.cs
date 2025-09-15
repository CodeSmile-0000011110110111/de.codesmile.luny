
// --------------------------------------------------------------
// GENERATED FILE ----> DO NOT EDIT <---- CHANGES WILL BE LOST !!
// --------------------------------------------------------------

#if UNITY_6000_2_OR_NEWER && !(UNITY_6000_3_OR_NEWER)
#pragma warning disable 0109, 0162, 0168, 0219
using Luny;

namespace LunyEditor.UnityEditor.AssetImporters
{
    public sealed class LuaTextureGenerationSettings : global::Luny.ILuaValueType<global::UnityEditor.AssetImporters.TextureGenerationSettings>
    {
        public new static global::Lua.LuaValue Bind(in global::UnityEditor.AssetImporters.TextureGenerationSettings instance) => new LuaTextureGenerationSettings(instance);
        public new static global::Lua.LuaValue Bind(global::System.Object instance) => Bind((global::UnityEditor.AssetImporters.TextureGenerationSettings)instance);
        public new static global::Lua.LuaValue Bind(global::System.Collections.Generic.IList<global::UnityEditor.AssetImporters.TextureGenerationSettings> instances) =>
            new global::Luny.LuaList<global::UnityEditor.AssetImporters.TextureGenerationSettings>(instances);
        public new static global::Lua.LuaValue Bind(global::System.Collections.Generic.IList<global::System.Object> instances) =>
            new global::Luny.LuaList<global::UnityEditor.AssetImporters.TextureGenerationSettings>(instances);
        private LuaTextureGenerationSettings(in global::UnityEditor.AssetImporters.TextureGenerationSettings value) => m_Value = value;
        public static implicit operator global::Lua.LuaValue(LuaTextureGenerationSettings value) => new(value);
        private global::UnityEditor.AssetImporters.TextureGenerationSettings m_Value;
        public global::UnityEditor.AssetImporters.TextureGenerationSettings Value { get => m_Value; set => m_Value = value; }
        public ref global::UnityEditor.AssetImporters.TextureGenerationSettings ValueRef => ref m_Value;
        public global::System.Type BindType => typeof(global::UnityEditor.AssetImporters.TextureGenerationSettings);
        public override global::System.String ToString() => m_Value.ToString();
#if UNITY_EDITOR
        [global::UnityEngine.RuntimeInitializeOnLoadMethod(global::UnityEngine.RuntimeInitializeLoadType.SubsystemRegistration)]
        private static void ResetStaticFields() => s_Metatable = null;
#endif

        private static readonly global::Lua.LuaFunction __index = new(global::Lua.Runtime.Metamethods.Index, (_context, _) =>
        {
            var _this = _context.GetArgument<LuaTextureGenerationSettings>(0);
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
            var _this = _context.GetArgument<LuaTextureGenerationSettings>(0);
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
                case "assetPath": _value = new global::Lua.LuaValue(m_Value.assetPath); return true;
                case "enablePostProcessor": _value = new global::Lua.LuaValue(m_Value.enablePostProcessor); return true;
                case "platformSettings": _value = _factory.Bind(m_Value.platformSettings); return true;
                case "qualifyForSpritePacking": _value = new global::Lua.LuaValue(m_Value.qualifyForSpritePacking); return true;
                case "secondarySpriteTextures": _value = _factory.Bind(m_Value.secondarySpriteTextures); return true;
                case "sourceTextureInformation": _value = _factory.Bind(m_Value.sourceTextureInformation); return true;
                case "spriteImportData": _value = _factory.Bind(m_Value.spriteImportData); return true;
                case "spritePackingTag": _value = new global::Lua.LuaValue(m_Value.spritePackingTag); return true;
                case "textureImporterSettings": _value = _factory.Bind(m_Value.textureImporterSettings); return true;
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
                case "assetPath": { var _temp = m_Value; _temp.assetPath = _value.Read<global::System.String>(); m_Value = _temp; } return true;
                case "enablePostProcessor": { var _temp = m_Value; _temp.enablePostProcessor = _value.Read<global::System.Boolean>(); m_Value = _temp; } return true;
                case "platformSettings": { var _temp = m_Value; _temp.platformSettings = _value.Read<global::LunyEditor.UnityEditor.LuaTextureImporterPlatformSettings>().Instance; m_Value = _temp; } return true;
                case "qualifyForSpritePacking": { var _temp = m_Value; _temp.qualifyForSpritePacking = _value.Read<global::System.Boolean>(); m_Value = _temp; } return true;
                case "secondarySpriteTextures": { var _temp = m_Value; _temp.secondarySpriteTextures = _value.Read<global::UnityEngine.SecondarySpriteTexture[]>(); m_Value = _temp; } return true;
                case "sourceTextureInformation": { var _temp = m_Value; _temp.sourceTextureInformation = _value.Read<global::LunyEditor.UnityEditor.AssetImporters.LuaSourceTextureInformation>().Instance; m_Value = _temp; } return true;
                case "spriteImportData": { var _temp = m_Value; _temp.spriteImportData = _value.Read<global::UnityEditor.AssetImporters.SpriteImportData[]>(); m_Value = _temp; } return true;
                case "spritePackingTag": { var _temp = m_Value; _temp.spritePackingTag = _value.Read<global::System.String>(); m_Value = _temp; } return true;
                case "textureImporterSettings": { var _temp = m_Value; _temp.textureImporterSettings = _value.Read<global::LunyEditor.UnityEditor.LuaTextureImporterSettings>().Instance; m_Value = _temp; } return true;
                default: return false;
            }
        }
    }
    public sealed class LuaTextureGenerationSettingsType : global::Luny.ILuaStatic
    {
        public static global::Lua.LuaValue Bind() => new LuaTextureGenerationSettingsType();
        private LuaTextureGenerationSettingsType() {}
        public static implicit operator global::Lua.LuaValue(LuaTextureGenerationSettingsType value) => new(value);
        public global::System.Type BindType => typeof(global::UnityEditor.AssetImporters.TextureGenerationSettings);
        public override global::System.String ToString() => BindType.FullName;
#if UNITY_EDITOR
        [global::UnityEngine.RuntimeInitializeOnLoadMethod(global::UnityEngine.RuntimeInitializeLoadType.SubsystemRegistration)]
        private static void ResetStaticFields() => s_Metatable = null;
#endif

        private static readonly global::Lua.LuaFunction _LuaTextureGenerationSettings_new = new global::Lua.LuaFunction(".ctor", (_context, _) =>
        {
            global::Lua.LuaValue _lastArg = default;
            global::System.Int32 _lastArgPos = default;
            global::System.Type _expectedType = default;
            var _argCount = _context.ArgumentCount;
            // ctor parameterless case
            if (_argCount == 1)
            {
                var _ret0 = new global::UnityEditor.AssetImporters.TextureGenerationSettings();
                var _lret0 = global::LunyEditor.UnityEditor.AssetImporters.LuaTextureGenerationSettings.Bind(_ret0);
                var _retCount = _context.Return(_lret0);
                return new global::System.Threading.Tasks.ValueTask<global::System.Int32>(_retCount);
            }
            var _arg0 = _lastArg = _argCount > 1 ? _context.GetArgument(1) : global::Lua.LuaValue.Nil;
            _lastArgPos = 0; _expectedType = typeof(global::UnityEditor.TextureImporterType);
            if (_arg0.TryRead<global::UnityEditor.TextureImporterType>(out var _p0_UnityEditor_TextureImporterType))
            {
                if (_argCount == 2)
                {
                    var type = _p0_UnityEditor_TextureImporterType;
                    var _ret0 = new global::UnityEditor.AssetImporters.TextureGenerationSettings(type);
                    var _lret0 = global::LunyEditor.UnityEditor.AssetImporters.LuaTextureGenerationSettings.Bind(_ret0);
                    var _retCount = _context.Return(_lret0);
                    return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                }
            }
            throw new global::Lua.LuaRuntimeException(_context.Thread, $"{".ctor"}: invalid argument #{_lastArgPos}: {_lastArg} ({_lastArg.Type}), expected: {_expectedType.FullName}", 2);
        });
        private static readonly global::Lua.LuaFunction __index = new(global::Lua.Runtime.Metamethods.Index, (_context, _) =>
        {
            var _this = _context.GetArgument<LuaTextureGenerationSettingsType>(0);
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
            var _this = _context.GetArgument<LuaTextureGenerationSettingsType>(0);
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
            metatable[global::Lua.Runtime.Metamethods.Call] = _LuaTextureGenerationSettings_new;
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
