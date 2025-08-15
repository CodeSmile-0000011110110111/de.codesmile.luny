
// --------------------------------------------------------------
// GENERATED FILE ----> DO NOT EDIT <---- CHANGES WILL BE LOST !!
// --------------------------------------------------------------

#if UNITY_6000_2_OR_NEWER && !(UNITY_6000_3_OR_NEWER)
#pragma warning disable 0109, 0162, 0168, 0219
using Luny;

namespace Luny.UnityEditor
{
    public sealed class LuaSpeedTreeImporter : LuaAssetImporter, global::Luny.ILuaObject<global::UnityEditor.SpeedTreeImporter>
    {
        public new static global::Lua.LuaValue Bind(global::UnityEditor.SpeedTreeImporter instance) => new LuaSpeedTreeImporter(instance);
        public new static global::Lua.LuaValue Bind(global::System.Object instance) => Bind((global::UnityEditor.SpeedTreeImporter)instance);
        public new static global::Lua.LuaValue Bind(global::System.Collections.Generic.IList<global::UnityEditor.SpeedTreeImporter> instances) =>
            new global::Luny.LuaList<global::UnityEditor.SpeedTreeImporter>(instances);
        public new static global::Lua.LuaValue Bind(global::System.Collections.Generic.IList<global::System.Object> instances) =>
            new global::Luny.LuaList<global::UnityEditor.SpeedTreeImporter>(instances);
        private LuaSpeedTreeImporter(global::UnityEditor.SpeedTreeImporter instance) : base(instance) {}
        public static implicit operator global::Lua.LuaValue(LuaSpeedTreeImporter value) => new(value);
        public new global::UnityEditor.SpeedTreeImporter Instance => (global::UnityEditor.SpeedTreeImporter)m_Instance;
        public new global::System.Type BindType => typeof(global::UnityEditor.SpeedTreeImporter);
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

        private static readonly global::Lua.LuaFunction _LuaSpeedTreeImporter_GenerateMaterials = new global::Lua.LuaFunction("GenerateMaterials", (_context, _) =>
        {
            global::Lua.LuaValue _lastArg = default;
            global::System.Int32 _lastArgPos = default;
            global::System.Type _expectedType = default;
            var _argCount = _context.ArgumentCount;
            var _this = _context.GetArgument<LuaSpeedTreeImporter>(0);
            if (_argCount == 1)
            {
                _this.Instance.GenerateMaterials();
                var _retCount = _context.Return();
                return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
            }
            throw new global::Lua.LuaRuntimeException(_context.Thread, $"{"GenerateMaterials"}: invalid argument #{_lastArgPos}: {_lastArg} ({_lastArg.Type}), expected: {_expectedType.FullName}", 2);
        });
        private static readonly global::Lua.LuaFunction _LuaSpeedTreeImporter_SearchAndRemapMaterials = new global::Lua.LuaFunction("SearchAndRemapMaterials", (_context, _) =>
        {
            global::Lua.LuaValue _lastArg = default;
            global::System.Int32 _lastArgPos = default;
            global::System.Type _expectedType = default;
            var _argCount = _context.ArgumentCount;
            var _this = _context.GetArgument<LuaSpeedTreeImporter>(0);
            var _arg0 = _lastArg = _argCount > 1 ? _context.GetArgument(1) : global::Lua.LuaValue.Nil;
            _lastArgPos = 0; _expectedType = typeof(global::System.String);
            if (_arg0.TryRead<global::System.String>(out var _p0_System_String))
            {
                if (_argCount == 2)
                {
                    var materialFolderPath = _p0_System_String;
                    var _ret0 = _this.Instance.SearchAndRemapMaterials(materialFolderPath);
                    var _lret0 = new global::Lua.LuaValue(_ret0);
                    var _retCount = _context.Return(_lret0);
                    return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                }
            }
            throw new global::Lua.LuaRuntimeException(_context.Thread, $"{"SearchAndRemapMaterials"}: invalid argument #{_lastArgPos}: {_lastArg} ({_lastArg.Type}), expected: {_expectedType.FullName}", 2);
        });
        private static readonly global::Lua.LuaFunction __index = new(global::Lua.Runtime.Metamethods.Index, (_context, _) =>
        {
            var _this = _context.GetArgument<LuaSpeedTreeImporter>(0);
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
            var _this = _context.GetArgument<LuaSpeedTreeImporter>(0);
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
                case "GenerateMaterials": _value = _LuaSpeedTreeImporter_GenerateMaterials; return true;
                case "SearchAndRemapMaterials": _value = _LuaSpeedTreeImporter_SearchAndRemapMaterials; return true;
                case "alphaTestRef": _value = new global::Lua.LuaValue(Instance.alphaTestRef); return true;
                case "animateCrossFading": _value = new global::Lua.LuaValue(Instance.animateCrossFading); return true;
                case "bestWindQuality": _value = new global::Lua.LuaValue(Instance.bestWindQuality); return true;
                case "billboardTransitionCrossFadeWidth": _value = new global::Lua.LuaValue(Instance.billboardTransitionCrossFadeWidth); return true;
                case "castShadows": _value = _factory.Bind(Instance.castShadows); return true;
                case "castShadowsByDefault": _value = new global::Lua.LuaValue(Instance.castShadowsByDefault); return true;
                case "defaultBillboardShader": _value = _factory.Bind(Instance.defaultBillboardShader); return true;
                case "defaultShader": _value = _factory.Bind(Instance.defaultShader); return true;
                case "enableBump": _value = _factory.Bind(Instance.enableBump); return true;
                case "enableBumpByDefault": _value = new global::Lua.LuaValue(Instance.enableBumpByDefault); return true;
                case "enableHue": _value = _factory.Bind(Instance.enableHue); return true;
                case "enableHueByDefault": _value = new global::Lua.LuaValue(Instance.enableHueByDefault); return true;
                case "enableSettingOverride": _value = _factory.Bind(Instance.enableSettingOverride); return true;
                case "enableSmoothLODTransition": _value = new global::Lua.LuaValue(Instance.enableSmoothLODTransition); return true;
                case "enableSubsurface": _value = _factory.Bind(Instance.enableSubsurface); return true;
                case "enableSubsurfaceByDefault": _value = new global::Lua.LuaValue(Instance.enableSubsurfaceByDefault); return true;
                case "fadeOutWidth": _value = new global::Lua.LuaValue(Instance.fadeOutWidth); return true;
                case "generateColliders": _value = new global::Lua.LuaValue(Instance.generateColliders); return true;
                case "generateRigidbody": _value = new global::Lua.LuaValue(Instance.generateRigidbody); return true;
                case "hasBillboard": _value = new global::Lua.LuaValue(Instance.hasBillboard); return true;
                case "hasImported": _value = new global::Lua.LuaValue(Instance.hasImported); return true;
                case "hueVariation": _value = _factory.Bind(Instance.hueVariation); return true;
                case "isV8": _value = new global::Lua.LuaValue(Instance.isV8); return true;
                case "LODHeights": _value = _factory.Bind(Instance.LODHeights); return true;
                case "mainColor": _value = _factory.Bind(Instance.mainColor); return true;
                case "materialFolderPath": _value = new global::Lua.LuaValue(Instance.materialFolderPath); return true;
                case "materialLocation": _value = new global::Lua.LuaValue((global::System.Int64)Instance.materialLocation); return true;
                case "receiveShadows": _value = _factory.Bind(Instance.receiveShadows); return true;
                case "receiveShadowsByDefault": _value = new global::Lua.LuaValue(Instance.receiveShadowsByDefault); return true;
                case "reflectionProbeUsages": _value = _factory.Bind(Instance.reflectionProbeUsages); return true;
                case "reflectionProbeUsagesByDefault": _value = new global::Lua.LuaValue(Instance.reflectionProbeUsagesByDefault); return true;
                case "scaleFactor": _value = new global::Lua.LuaValue(Instance.scaleFactor); return true;
                case "selectedWindQuality": _value = new global::Lua.LuaValue(Instance.selectedWindQuality); return true;
                case "useLightProbes": _value = _factory.Bind(Instance.useLightProbes); return true;
                case "useLightProbesByDefault": _value = new global::Lua.LuaValue(Instance.useLightProbesByDefault); return true;
                case "windQualities": _value = _factory.Bind(Instance.windQualities); return true;
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
                case "alphaTestRef": Instance.alphaTestRef = _value.Read<global::System.Single>();  return true;
                case "animateCrossFading": Instance.animateCrossFading = _value.Read<global::System.Boolean>();  return true;
                case "billboardTransitionCrossFadeWidth": Instance.billboardTransitionCrossFadeWidth = _value.Read<global::System.Single>();  return true;
                case "castShadows": Instance.castShadows = _value.Read<global::System.Boolean[]>();  return true;
                case "castShadowsByDefault": Instance.castShadowsByDefault = _value.Read<global::System.Boolean>();  return true;
                case "enableBump": Instance.enableBump = _value.Read<global::System.Boolean[]>();  return true;
                case "enableBumpByDefault": Instance.enableBumpByDefault = _value.Read<global::System.Boolean>();  return true;
                case "enableHue": Instance.enableHue = _value.Read<global::System.Boolean[]>();  return true;
                case "enableHueByDefault": Instance.enableHueByDefault = _value.Read<global::System.Boolean>();  return true;
                case "enableSettingOverride": Instance.enableSettingOverride = _value.Read<global::System.Boolean[]>();  return true;
                case "enableSmoothLODTransition": Instance.enableSmoothLODTransition = _value.Read<global::System.Boolean>();  return true;
                case "enableSubsurface": Instance.enableSubsurface = _value.Read<global::System.Boolean[]>();  return true;
                case "enableSubsurfaceByDefault": Instance.enableSubsurfaceByDefault = _value.Read<global::System.Boolean>();  return true;
                case "fadeOutWidth": Instance.fadeOutWidth = _value.Read<global::System.Single>();  return true;
                case "generateColliders": Instance.generateColliders = _value.Read<global::System.Boolean>();  return true;
                case "generateRigidbody": Instance.generateRigidbody = _value.Read<global::System.Boolean>();  return true;
                case "hueVariation": Instance.hueVariation = _value.Read<global::UnityEngine.Color>();  return true;
                case "LODHeights": Instance.LODHeights = _value.Read<global::System.Single[]>();  return true;
                case "mainColor": Instance.mainColor = _value.Read<global::UnityEngine.Color>();  return true;
                case "materialLocation": Instance.materialLocation = _value.Read<global::UnityEditor.SpeedTreeImporter.MaterialLocation>();  return true;
                case "receiveShadows": Instance.receiveShadows = _value.Read<global::System.Boolean[]>();  return true;
                case "receiveShadowsByDefault": Instance.receiveShadowsByDefault = _value.Read<global::System.Boolean>();  return true;
                case "reflectionProbeUsages": Instance.reflectionProbeUsages = _value.Read<global::UnityEngine.Rendering.ReflectionProbeUsage[]>();  return true;
                case "reflectionProbeUsagesByDefault": Instance.reflectionProbeUsagesByDefault = _value.Read<global::System.Int32>();  return true;
                case "scaleFactor": Instance.scaleFactor = _value.Read<global::System.Single>();  return true;
                case "selectedWindQuality": Instance.selectedWindQuality = _value.Read<global::System.Int32>();  return true;
                case "useLightProbes": Instance.useLightProbes = _value.Read<global::System.Boolean[]>();  return true;
                case "useLightProbesByDefault": Instance.useLightProbesByDefault = _value.Read<global::System.Boolean>();  return true;
                case "windQualities": Instance.windQualities = _value.Read<global::System.Int32[]>();  return true;
                default: return base.TrySetLuaValue(_key, _value);
            }
        }
    }
    public sealed class LuaSpeedTreeImporterType : global::Luny.ILuaStatic
    {
        public static global::Lua.LuaValue Bind() => new LuaSpeedTreeImporterType();
        private LuaSpeedTreeImporterType() {}
        public static implicit operator global::Lua.LuaValue(LuaSpeedTreeImporterType value) => new(value);
        public global::System.Type BindType => typeof(global::UnityEditor.SpeedTreeImporter);
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
            metatable[global::Lua.Runtime.Metamethods.Call] = _LuaSpeedTreeImporter_new;
            return metatable;
        }
        public override global::System.String ToString() => BindType.FullName;
#if UNITY_EDITOR
        [global::UnityEngine.RuntimeInitializeOnLoadMethod(global::UnityEngine.RuntimeInitializeLoadType.SubsystemRegistration)]
        private static void ResetStaticFields() => s_Metatable = null;
#endif

        private static readonly global::Lua.LuaFunction _LuaSpeedTreeImporter_new = new global::Lua.LuaFunction(".ctor", (_context, _) =>
        {
            global::Lua.LuaValue _lastArg = default;
            global::System.Int32 _lastArgPos = default;
            global::System.Type _expectedType = default;
            var _argCount = _context.ArgumentCount;
            if (_argCount == 1)
            {
                var _ret0 = new global::UnityEditor.SpeedTreeImporter();
                var _factory = _context.GetObjectFactory();
                var _lret0 = _factory.Bind(_ret0);
                var _retCount = _context.Return(_lret0);
                return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
            }
            throw new global::Lua.LuaRuntimeException(_context.Thread, $"{".ctor"}: invalid argument #{_lastArgPos}: {_lastArg} ({_lastArg.Type}), expected: {_expectedType.FullName}", 2);
        });
        private static readonly global::Lua.LuaFunction __index = new(global::Lua.Runtime.Metamethods.Index, (_context, _) =>
        {
            var _this = _context.GetArgument<LuaSpeedTreeImporterType>(0);
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
            var _this = _context.GetArgument<LuaSpeedTreeImporterType>(0);
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
                case "windQualityNames": _value = _factory.Bind(global::UnityEditor.SpeedTreeImporter.windQualityNames); return true;
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
