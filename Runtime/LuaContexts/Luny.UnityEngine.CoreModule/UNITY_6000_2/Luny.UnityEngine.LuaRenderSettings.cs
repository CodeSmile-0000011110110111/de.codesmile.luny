
// --------------------------------------------------------------
// GENERATED FILE ----> DO NOT EDIT <---- CHANGES WILL BE LOST !!
// --------------------------------------------------------------

#if UNITY_6000_2_OR_NEWER && !(UNITY_6000_3_OR_NEWER)
#pragma warning disable 0109, 0162, 0168, 0219
using Luny;

namespace Luny.UnityEngine
{
    public sealed class LuaRenderSettings : LuaUnityObject, global::Luny.ILuaObject<global::UnityEngine.RenderSettings>
    {
        public new static global::Lua.LuaValue Bind(global::UnityEngine.RenderSettings instance) => new LuaRenderSettings(instance);
        public new static global::Lua.LuaValue Bind(global::System.Object instance) => Bind((global::UnityEngine.RenderSettings)instance);
        public new static global::Lua.LuaValue Bind(global::System.Collections.Generic.IList<global::UnityEngine.RenderSettings> instances) =>
            new global::Luny.LuaList<global::UnityEngine.RenderSettings>(instances);
        public new static global::Lua.LuaValue Bind(global::System.Collections.Generic.IList<global::System.Object> instances) =>
            new global::Luny.LuaList<global::UnityEngine.RenderSettings>(instances);
        private LuaRenderSettings(global::UnityEngine.RenderSettings instance) : base(instance) {}
        public static implicit operator global::Lua.LuaValue(LuaRenderSettings value) => new(value);
        public new global::UnityEngine.RenderSettings Instance => (global::UnityEngine.RenderSettings)m_Instance;
        public new global::System.Type BindType => typeof(global::UnityEngine.RenderSettings);
        private static global::Lua.LuaTable s_Metatable;
        public new global::Lua.LuaTable Metatable
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
        public override global::System.String ToString() => m_Instance != null ? Instance.ToString() : "{GetType().Name}(null)";
#if UNITY_EDITOR
        [global::UnityEngine.RuntimeInitializeOnLoadMethod(global::UnityEngine.RuntimeInitializeLoadType.SubsystemRegistration)]
        private static void ResetStaticFields() => s_Metatable = null;
#endif

        private static readonly global::Lua.LuaFunction __index = new(global::Lua.Runtime.Metamethods.Index, (_context, _) =>
        {
            var _this = _context.GetArgument<LuaRenderSettings>(0);
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
            var _this = _context.GetArgument<LuaRenderSettings>(0);
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
                default: return base.TrySetLuaValue(_key, _value);
            }
        }
    }
    public sealed class LuaRenderSettingsType : global::Luny.ILuaStatic
    {
        public static global::Lua.LuaValue Bind() => new LuaRenderSettingsType();
        private LuaRenderSettingsType() {}
        public static implicit operator global::Lua.LuaValue(LuaRenderSettingsType value) => new(value);
        public global::System.Type BindType => typeof(global::UnityEngine.RenderSettings);
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
            var _this = _context.GetArgument<LuaRenderSettingsType>(0);
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
            var _this = _context.GetArgument<LuaRenderSettingsType>(0);
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
                case "ambientEquatorColor": _value = global::Luny.UnityEngine.LuaColor.Bind(global::UnityEngine.RenderSettings.ambientEquatorColor); return true;
                case "ambientGroundColor": _value = global::Luny.UnityEngine.LuaColor.Bind(global::UnityEngine.RenderSettings.ambientGroundColor); return true;
                case "ambientIntensity": _value = new global::Lua.LuaValue(global::UnityEngine.RenderSettings.ambientIntensity); return true;
                case "ambientLight": _value = global::Luny.UnityEngine.LuaColor.Bind(global::UnityEngine.RenderSettings.ambientLight); return true;
                case "ambientMode": _value = new global::Lua.LuaValue((global::System.Int64)global::UnityEngine.RenderSettings.ambientMode); return true;
                case "ambientProbe": _value = global::Luny.UnityEngine.Rendering.LuaSphericalHarmonicsL2.Bind(global::UnityEngine.RenderSettings.ambientProbe); return true;
                case "ambientSkyColor": _value = global::Luny.UnityEngine.LuaColor.Bind(global::UnityEngine.RenderSettings.ambientSkyColor); return true;
                case "customReflectionTexture": _value = _factory.Bind(global::UnityEngine.RenderSettings.customReflectionTexture); return true;
                case "defaultReflectionMode": _value = new global::Lua.LuaValue((global::System.Int64)global::UnityEngine.RenderSettings.defaultReflectionMode); return true;
                case "defaultReflectionResolution": _value = new global::Lua.LuaValue(global::UnityEngine.RenderSettings.defaultReflectionResolution); return true;
                case "flareFadeSpeed": _value = new global::Lua.LuaValue(global::UnityEngine.RenderSettings.flareFadeSpeed); return true;
                case "flareStrength": _value = new global::Lua.LuaValue(global::UnityEngine.RenderSettings.flareStrength); return true;
                case "fog": _value = new global::Lua.LuaValue(global::UnityEngine.RenderSettings.fog); return true;
                case "fogColor": _value = global::Luny.UnityEngine.LuaColor.Bind(global::UnityEngine.RenderSettings.fogColor); return true;
                case "fogDensity": _value = new global::Lua.LuaValue(global::UnityEngine.RenderSettings.fogDensity); return true;
                case "fogEndDistance": _value = new global::Lua.LuaValue(global::UnityEngine.RenderSettings.fogEndDistance); return true;
                case "fogMode": _value = new global::Lua.LuaValue((global::System.Int64)global::UnityEngine.RenderSettings.fogMode); return true;
                case "fogStartDistance": _value = new global::Lua.LuaValue(global::UnityEngine.RenderSettings.fogStartDistance); return true;
                case "haloStrength": _value = new global::Lua.LuaValue(global::UnityEngine.RenderSettings.haloStrength); return true;
                case "reflectionBounces": _value = new global::Lua.LuaValue(global::UnityEngine.RenderSettings.reflectionBounces); return true;
                case "reflectionIntensity": _value = new global::Lua.LuaValue(global::UnityEngine.RenderSettings.reflectionIntensity); return true;
                case "skybox": _value = _factory.Bind(global::UnityEngine.RenderSettings.skybox); return true;
                case "subtractiveShadowColor": _value = global::Luny.UnityEngine.LuaColor.Bind(global::UnityEngine.RenderSettings.subtractiveShadowColor); return true;
                case "sun": _value = _factory.Bind(global::UnityEngine.RenderSettings.sun); return true;
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
                case "ambientEquatorColor": global::UnityEngine.RenderSettings.ambientEquatorColor = _value.Read<global::Luny.UnityEngine.LuaColor>().Value;  return true;
                case "ambientGroundColor": global::UnityEngine.RenderSettings.ambientGroundColor = _value.Read<global::Luny.UnityEngine.LuaColor>().Value;  return true;
                case "ambientIntensity": global::UnityEngine.RenderSettings.ambientIntensity = _value.Read<global::System.Single>();  return true;
                case "ambientLight": global::UnityEngine.RenderSettings.ambientLight = _value.Read<global::Luny.UnityEngine.LuaColor>().Value;  return true;
                case "ambientMode": global::UnityEngine.RenderSettings.ambientMode = _value.Read<global::UnityEngine.Rendering.AmbientMode>();  return true;
                case "ambientProbe": global::UnityEngine.RenderSettings.ambientProbe = _value.Read<global::Luny.UnityEngine.Rendering.LuaSphericalHarmonicsL2>().Value;  return true;
                case "ambientSkyColor": global::UnityEngine.RenderSettings.ambientSkyColor = _value.Read<global::Luny.UnityEngine.LuaColor>().Value;  return true;
                case "customReflectionTexture": global::UnityEngine.RenderSettings.customReflectionTexture = _value.Read<global::Luny.UnityEngine.LuaTexture>().Instance;  return true;
                case "defaultReflectionMode": global::UnityEngine.RenderSettings.defaultReflectionMode = _value.Read<global::UnityEngine.Rendering.DefaultReflectionMode>();  return true;
                case "defaultReflectionResolution": global::UnityEngine.RenderSettings.defaultReflectionResolution = _value.Read<global::System.Int32>();  return true;
                case "flareFadeSpeed": global::UnityEngine.RenderSettings.flareFadeSpeed = _value.Read<global::System.Single>();  return true;
                case "flareStrength": global::UnityEngine.RenderSettings.flareStrength = _value.Read<global::System.Single>();  return true;
                case "fog": global::UnityEngine.RenderSettings.fog = _value.Read<global::System.Boolean>();  return true;
                case "fogColor": global::UnityEngine.RenderSettings.fogColor = _value.Read<global::Luny.UnityEngine.LuaColor>().Value;  return true;
                case "fogDensity": global::UnityEngine.RenderSettings.fogDensity = _value.Read<global::System.Single>();  return true;
                case "fogEndDistance": global::UnityEngine.RenderSettings.fogEndDistance = _value.Read<global::System.Single>();  return true;
                case "fogMode": global::UnityEngine.RenderSettings.fogMode = _value.Read<global::UnityEngine.FogMode>();  return true;
                case "fogStartDistance": global::UnityEngine.RenderSettings.fogStartDistance = _value.Read<global::System.Single>();  return true;
                case "haloStrength": global::UnityEngine.RenderSettings.haloStrength = _value.Read<global::System.Single>();  return true;
                case "reflectionBounces": global::UnityEngine.RenderSettings.reflectionBounces = _value.Read<global::System.Int32>();  return true;
                case "reflectionIntensity": global::UnityEngine.RenderSettings.reflectionIntensity = _value.Read<global::System.Single>();  return true;
                case "skybox": global::UnityEngine.RenderSettings.skybox = _value.Read<global::Luny.UnityEngine.LuaMaterial>().Instance;  return true;
                case "subtractiveShadowColor": global::UnityEngine.RenderSettings.subtractiveShadowColor = _value.Read<global::Luny.UnityEngine.LuaColor>().Value;  return true;
                case "sun": global::UnityEngine.RenderSettings.sun = _value.Read<global::Luny.UnityEngine.LuaLight>().Instance;  return true;
                default: return false;
            }
        }
    }
}
#pragma warning restore 0109, 0162, 0168, 0219
#endif
