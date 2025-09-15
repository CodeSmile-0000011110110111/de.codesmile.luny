
// --------------------------------------------------------------
// GENERATED FILE ----> DO NOT EDIT <---- CHANGES WILL BE LOST !!
// --------------------------------------------------------------

#if UNITY_6000_2_OR_NEWER && !(UNITY_6000_3_OR_NEWER)
#pragma warning disable 0109, 0162, 0168, 0219
using Luny;

namespace LunyEditor.UnityEditor
{
    public sealed class LuaLightmappingType : global::Luny.ILuaStatic
    {
        public static global::Lua.LuaValue Bind() => new LuaLightmappingType();
        private LuaLightmappingType() {}
        public static implicit operator global::Lua.LuaValue(LuaLightmappingType value) => new(value);
        public global::System.Type BindType => typeof(global::UnityEditor.Lightmapping);
        public override global::System.String ToString() => BindType.FullName;
#if UNITY_EDITOR
        [global::UnityEngine.RuntimeInitializeOnLoadMethod(global::UnityEngine.RuntimeInitializeLoadType.SubsystemRegistration)]
        private static void ResetStaticFields() => s_Metatable = null;
#endif

        private static readonly global::Lua.LuaFunction _LuaLightmapping_Bake = new global::Lua.LuaFunction("Bake", (_context, _) =>
        {
            global::Lua.LuaValue _lastArg = default;
            global::System.Int32 _lastArgPos = default;
            global::System.Type _expectedType = default;
            var _argCount = _context.ArgumentCount;
            if (_argCount == 0)
            {
                var _ret0 = global::UnityEditor.Lightmapping.Bake();
                var _lret0 = new global::Lua.LuaValue(_ret0);
                var _retCount = _context.Return(_lret0);
                return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
            }
            throw new global::Lua.LuaRuntimeException(_context.Thread, $"{"Bake"}: invalid argument #{_lastArgPos}: {_lastArg} ({_lastArg.Type}), expected: {_expectedType.FullName}", 2);
        });
        private static readonly global::Lua.LuaFunction _LuaLightmapping_BakeAsync = new global::Lua.LuaFunction("BakeAsync", (_context, _) =>
        {
            global::Lua.LuaValue _lastArg = default;
            global::System.Int32 _lastArgPos = default;
            global::System.Type _expectedType = default;
            var _argCount = _context.ArgumentCount;
            if (_argCount == 0)
            {
                var _ret0 = global::UnityEditor.Lightmapping.BakeAsync();
                var _lret0 = new global::Lua.LuaValue(_ret0);
                var _retCount = _context.Return(_lret0);
                return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
            }
            throw new global::Lua.LuaRuntimeException(_context.Thread, $"{"BakeAsync"}: invalid argument #{_lastArgPos}: {_lastArg} ({_lastArg.Type}), expected: {_expectedType.FullName}", 2);
        });
        private static readonly global::Lua.LuaFunction _LuaLightmapping_BakeMultipleScenes = new global::Lua.LuaFunction("BakeMultipleScenes", (_context, _) =>
        {
            global::Lua.LuaValue _lastArg = default;
            global::System.Int32 _lastArgPos = default;
            global::System.Type _expectedType = default;
            var _argCount = _context.ArgumentCount;
            var _arg0 = _lastArg = _argCount > 0 ? _context.GetArgument(0) : global::Lua.LuaValue.Nil;
            _lastArgPos = 0; _expectedType = typeof(global::System.String[]);
            if (_arg0.TryReadArray<global::System.String>(out var _p0_System_StringArray))
            {
                if (_argCount == 1)
                {
                    var paths = _p0_System_StringArray;
                    global::UnityEditor.Lightmapping.BakeMultipleScenes(paths);
                    var _retCount = _context.Return();
                    return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                }
            }
            throw new global::Lua.LuaRuntimeException(_context.Thread, $"{"BakeMultipleScenes"}: invalid argument #{_lastArgPos}: {_lastArg} ({_lastArg.Type}), expected: {_expectedType.FullName}", 2);
        });
        private static readonly global::Lua.LuaFunction _LuaLightmapping_BakeReflectionProbe = new global::Lua.LuaFunction("BakeReflectionProbe", (_context, _) =>
        {
            global::Lua.LuaValue _lastArg = default;
            global::System.Int32 _lastArgPos = default;
            global::System.Type _expectedType = default;
            var _argCount = _context.ArgumentCount;
            var _arg0 = _lastArg = _argCount > 0 ? _context.GetArgument(0) : global::Lua.LuaValue.Nil;
            _lastArgPos = 0; _expectedType = typeof(global::Luny.UnityEngine.LuaReflectionProbe);
            if (_arg0.TryRead<global::Luny.UnityEngine.LuaReflectionProbe>(out var _p0_UnityEngine_ReflectionProbe))
            {
                var _arg1 = _lastArg = _argCount > 1 ? _context.GetArgument(1) : global::Lua.LuaValue.Nil;
                _lastArgPos = 1; _expectedType = typeof(global::System.String);
                if (_arg1.TryRead<global::System.String>(out var _p1_System_String))
                {
                    if (_argCount == 2)
                    {
                        var probe = _p0_UnityEngine_ReflectionProbe.Instance;
                        var path = _p1_System_String;
                        var _ret0 = global::UnityEditor.Lightmapping.BakeReflectionProbe(probe, path);
                        var _lret0 = new global::Lua.LuaValue(_ret0);
                        var _retCount = _context.Return(_lret0);
                        return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                    }
                }
            }
            throw new global::Lua.LuaRuntimeException(_context.Thread, $"{"BakeReflectionProbe"}: invalid argument #{_lastArgPos}: {_lastArg} ({_lastArg.Type}), expected: {_expectedType.FullName}", 2);
        });
        private static readonly global::Lua.LuaFunction _LuaLightmapping_Cancel = new global::Lua.LuaFunction("Cancel", (_context, _) =>
        {
            global::Lua.LuaValue _lastArg = default;
            global::System.Int32 _lastArgPos = default;
            global::System.Type _expectedType = default;
            var _argCount = _context.ArgumentCount;
            if (_argCount == 0)
            {
                global::UnityEditor.Lightmapping.Cancel();
                var _retCount = _context.Return();
                return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
            }
            throw new global::Lua.LuaRuntimeException(_context.Thread, $"{"Cancel"}: invalid argument #{_lastArgPos}: {_lastArg} ({_lastArg.Type}), expected: {_expectedType.FullName}", 2);
        });
        private static readonly global::Lua.LuaFunction _LuaLightmapping_Clear = new global::Lua.LuaFunction("Clear", (_context, _) =>
        {
            global::Lua.LuaValue _lastArg = default;
            global::System.Int32 _lastArgPos = default;
            global::System.Type _expectedType = default;
            var _argCount = _context.ArgumentCount;
            if (_argCount == 0)
            {
                global::UnityEditor.Lightmapping.Clear();
                var _retCount = _context.Return();
                return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
            }
            throw new global::Lua.LuaRuntimeException(_context.Thread, $"{"Clear"}: invalid argument #{_lastArgPos}: {_lastArg} ({_lastArg.Type}), expected: {_expectedType.FullName}", 2);
        });
        private static readonly global::Lua.LuaFunction _LuaLightmapping_ClearDiskCache = new global::Lua.LuaFunction("ClearDiskCache", (_context, _) =>
        {
            global::Lua.LuaValue _lastArg = default;
            global::System.Int32 _lastArgPos = default;
            global::System.Type _expectedType = default;
            var _argCount = _context.ArgumentCount;
            if (_argCount == 0)
            {
                global::UnityEditor.Lightmapping.ClearDiskCache();
                var _retCount = _context.Return();
                return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
            }
            throw new global::Lua.LuaRuntimeException(_context.Thread, $"{"ClearDiskCache"}: invalid argument #{_lastArgPos}: {_lastArg} ({_lastArg.Type}), expected: {_expectedType.FullName}", 2);
        });
        private static readonly global::Lua.LuaFunction _LuaLightmapping_ClearLightingDataAsset = new global::Lua.LuaFunction("ClearLightingDataAsset", (_context, _) =>
        {
            global::Lua.LuaValue _lastArg = default;
            global::System.Int32 _lastArgPos = default;
            global::System.Type _expectedType = default;
            var _argCount = _context.ArgumentCount;
            if (_argCount == 0)
            {
                global::UnityEditor.Lightmapping.ClearLightingDataAsset();
                var _retCount = _context.Return();
                return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
            }
            throw new global::Lua.LuaRuntimeException(_context.Thread, $"{"ClearLightingDataAsset"}: invalid argument #{_lastArgPos}: {_lastArg} ({_lastArg.Type}), expected: {_expectedType.FullName}", 2);
        });
        private static readonly global::Lua.LuaFunction _LuaLightmapping_GetLightingDataAssetForScene = new global::Lua.LuaFunction("GetLightingDataAssetForScene", (_context, _) =>
        {
            global::Lua.LuaValue _lastArg = default;
            global::System.Int32 _lastArgPos = default;
            global::System.Type _expectedType = default;
            var _argCount = _context.ArgumentCount;
            var _arg0 = _lastArg = _argCount > 0 ? _context.GetArgument(0) : global::Lua.LuaValue.Nil;
            _lastArgPos = 0; _expectedType = typeof(global::Luny.UnityEngine.SceneManagement.LuaScene);
            if (_arg0.TryRead<global::Luny.UnityEngine.SceneManagement.LuaScene>(out var _p0_UnityEngine_SceneManagement_Scene))
            {
                if (_argCount == 1)
                {
                    var scene = _p0_UnityEngine_SceneManagement_Scene.Value;
                    var _ret0 = global::UnityEditor.Lightmapping.GetLightingDataAssetForScene(scene);
                    var _factory = _context.GetObjectFactory();
                    var _lret0 = _factory.Bind(_ret0);
                    var _retCount = _context.Return(_lret0);
                    return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                }
            }
            throw new global::Lua.LuaRuntimeException(_context.Thread, $"{"GetLightingDataAssetForScene"}: invalid argument #{_lastArgPos}: {_lastArg} ({_lastArg.Type}), expected: {_expectedType.FullName}", 2);
        });
        private static readonly global::Lua.LuaFunction _LuaLightmapping_GetLightingSettingsForScene = new global::Lua.LuaFunction("GetLightingSettingsForScene", (_context, _) =>
        {
            global::Lua.LuaValue _lastArg = default;
            global::System.Int32 _lastArgPos = default;
            global::System.Type _expectedType = default;
            var _argCount = _context.ArgumentCount;
            var _arg0 = _lastArg = _argCount > 0 ? _context.GetArgument(0) : global::Lua.LuaValue.Nil;
            _lastArgPos = 0; _expectedType = typeof(global::Luny.UnityEngine.SceneManagement.LuaScene);
            if (_arg0.TryRead<global::Luny.UnityEngine.SceneManagement.LuaScene>(out var _p0_UnityEngine_SceneManagement_Scene))
            {
                if (_argCount == 1)
                {
                    var scene = _p0_UnityEngine_SceneManagement_Scene.Value;
                    var _ret0 = global::UnityEditor.Lightmapping.GetLightingSettingsForScene(scene);
                    var _factory = _context.GetObjectFactory();
                    var _lret0 = _factory.Bind(_ret0);
                    var _retCount = _context.Return(_lret0);
                    return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                }
            }
            throw new global::Lua.LuaRuntimeException(_context.Thread, $"{"GetLightingSettingsForScene"}: invalid argument #{_lastArgPos}: {_lastArg} ({_lastArg.Type}), expected: {_expectedType.FullName}", 2);
        });
        private static readonly global::Lua.LuaFunction _LuaLightmapping_ResetAdditionalBakeDelegate = new global::Lua.LuaFunction("ResetAdditionalBakeDelegate", (_context, _) =>
        {
            global::Lua.LuaValue _lastArg = default;
            global::System.Int32 _lastArgPos = default;
            global::System.Type _expectedType = default;
            var _argCount = _context.ArgumentCount;
            if (_argCount == 0)
            {
                global::UnityEditor.Lightmapping.ResetAdditionalBakeDelegate();
                var _retCount = _context.Return();
                return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
            }
            throw new global::Lua.LuaRuntimeException(_context.Thread, $"{"ResetAdditionalBakeDelegate"}: invalid argument #{_lastArgPos}: {_lastArg} ({_lastArg.Type}), expected: {_expectedType.FullName}", 2);
        });
        private static readonly global::Lua.LuaFunction _LuaLightmapping_SetLightingDataAssetForScene = new global::Lua.LuaFunction("SetLightingDataAssetForScene", (_context, _) =>
        {
            global::Lua.LuaValue _lastArg = default;
            global::System.Int32 _lastArgPos = default;
            global::System.Type _expectedType = default;
            var _argCount = _context.ArgumentCount;
            var _arg0 = _lastArg = _argCount > 0 ? _context.GetArgument(0) : global::Lua.LuaValue.Nil;
            _lastArgPos = 0; _expectedType = typeof(global::Luny.UnityEngine.SceneManagement.LuaScene);
            if (_arg0.TryRead<global::Luny.UnityEngine.SceneManagement.LuaScene>(out var _p0_UnityEngine_SceneManagement_Scene))
            {
                var _arg1 = _lastArg = _argCount > 1 ? _context.GetArgument(1) : global::Lua.LuaValue.Nil;
                _lastArgPos = 1; _expectedType = typeof(global::LunyEditor.UnityEditor.LuaLightingDataAsset);
                if (_arg1.TryRead<global::LunyEditor.UnityEditor.LuaLightingDataAsset>(out var _p1_UnityEditor_LightingDataAsset))
                {
                    if (_argCount == 2)
                    {
                        var scene = _p0_UnityEngine_SceneManagement_Scene.Value;
                        var lda = _p1_UnityEditor_LightingDataAsset.Instance;
                        global::UnityEditor.Lightmapping.SetLightingDataAssetForScene(scene, lda);
                        var _retCount = _context.Return();
                        return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                    }
                }
            }
            throw new global::Lua.LuaRuntimeException(_context.Thread, $"{"SetLightingDataAssetForScene"}: invalid argument #{_lastArgPos}: {_lastArg} ({_lastArg.Type}), expected: {_expectedType.FullName}", 2);
        });
        private static readonly global::Lua.LuaFunction _LuaLightmapping_SetLightingSettingsForScene = new global::Lua.LuaFunction("SetLightingSettingsForScene", (_context, _) =>
        {
            global::Lua.LuaValue _lastArg = default;
            global::System.Int32 _lastArgPos = default;
            global::System.Type _expectedType = default;
            var _argCount = _context.ArgumentCount;
            var _arg0 = _lastArg = _argCount > 0 ? _context.GetArgument(0) : global::Lua.LuaValue.Nil;
            _lastArgPos = 0; _expectedType = typeof(global::Luny.UnityEngine.SceneManagement.LuaScene);
            if (_arg0.TryRead<global::Luny.UnityEngine.SceneManagement.LuaScene>(out var _p0_UnityEngine_SceneManagement_Scene))
            {
                var _arg1 = _lastArg = _argCount > 1 ? _context.GetArgument(1) : global::Lua.LuaValue.Nil;
                _lastArgPos = 1; _expectedType = typeof(global::UnityEngine.LightingSettings);
                if (_arg1.TryRead<global::UnityEngine.LightingSettings>(out var _p1_UnityEngine_LightingSettings))
                {
                    if (_argCount == 2)
                    {
                        var scene = _p0_UnityEngine_SceneManagement_Scene.Value;
                        var lightingSettings = _p1_UnityEngine_LightingSettings;
                        global::UnityEditor.Lightmapping.SetLightingSettingsForScene(scene, lightingSettings);
                        var _retCount = _context.Return();
                        return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                    }
                }
            }
            throw new global::Lua.LuaRuntimeException(_context.Thread, $"{"SetLightingSettingsForScene"}: invalid argument #{_lastArgPos}: {_lastArg} ({_lastArg.Type}), expected: {_expectedType.FullName}", 2);
        });
        private static readonly global::Lua.LuaFunction _LuaLightmapping_SetLightingSettingsForScenes = new global::Lua.LuaFunction("SetLightingSettingsForScenes", (_context, _) =>
        {
            global::Lua.LuaValue _lastArg = default;
            global::System.Int32 _lastArgPos = default;
            global::System.Type _expectedType = default;
            var _argCount = _context.ArgumentCount;
            var _arg0 = _lastArg = _argCount > 0 ? _context.GetArgument(0) : global::Lua.LuaValue.Nil;
            _lastArgPos = 0; _expectedType = typeof(global::UnityEngine.SceneManagement.Scene[]);
            if (_arg0.TryReadArray<global::UnityEngine.SceneManagement.Scene>(out var _p0_UnityEngine_SceneManagement_SceneArray))
            {
                var _arg1 = _lastArg = _argCount > 1 ? _context.GetArgument(1) : global::Lua.LuaValue.Nil;
                _lastArgPos = 1; _expectedType = typeof(global::UnityEngine.LightingSettings);
                if (_arg1.TryRead<global::UnityEngine.LightingSettings>(out var _p1_UnityEngine_LightingSettings))
                {
                    if (_argCount == 2)
                    {
                        var scenes = _p0_UnityEngine_SceneManagement_SceneArray;
                        var lightingSettings = _p1_UnityEngine_LightingSettings;
                        global::UnityEditor.Lightmapping.SetLightingSettingsForScenes(scenes, lightingSettings);
                        var _retCount = _context.Return();
                        return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                    }
                }
            }
            throw new global::Lua.LuaRuntimeException(_context.Thread, $"{"SetLightingSettingsForScenes"}: invalid argument #{_lastArgPos}: {_lastArg} ({_lastArg.Type}), expected: {_expectedType.FullName}", 2);
        });
        private static readonly global::Lua.LuaFunction __index = new(global::Lua.Runtime.Metamethods.Index, (_context, _) =>
        {
            var _this = _context.GetArgument<LuaLightmappingType>(0);
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
            var _this = _context.GetArgument<LuaLightmappingType>(0);
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
                case "Bake": _value = _LuaLightmapping_Bake; return true;
                case "BakeAsync": _value = _LuaLightmapping_BakeAsync; return true;
                case "BakeMultipleScenes": _value = _LuaLightmapping_BakeMultipleScenes; return true;
                case "BakeReflectionProbe": _value = _LuaLightmapping_BakeReflectionProbe; return true;
                case "Cancel": _value = _LuaLightmapping_Cancel; return true;
                case "Clear": _value = _LuaLightmapping_Clear; return true;
                case "ClearDiskCache": _value = _LuaLightmapping_ClearDiskCache; return true;
                case "ClearLightingDataAsset": _value = _LuaLightmapping_ClearLightingDataAsset; return true;
                case "GetLightingDataAssetForScene": _value = _LuaLightmapping_GetLightingDataAssetForScene; return true;
                case "GetLightingSettingsForScene": _value = _LuaLightmapping_GetLightingSettingsForScene; return true;
                case "ResetAdditionalBakeDelegate": _value = _LuaLightmapping_ResetAdditionalBakeDelegate; return true;
                case "SetLightingDataAssetForScene": _value = _LuaLightmapping_SetLightingDataAssetForScene; return true;
                case "SetLightingSettingsForScene": _value = _LuaLightmapping_SetLightingSettingsForScene; return true;
                case "SetLightingSettingsForScenes": _value = _LuaLightmapping_SetLightingSettingsForScenes; return true;
                case "bakedGI": _value = new global::Lua.LuaValue(global::UnityEditor.Lightmapping.bakedGI); return true;
                case "bakeOnSceneLoad": _value = new global::Lua.LuaValue((global::System.Int64)global::UnityEditor.Lightmapping.bakeOnSceneLoad); return true;
                case "buildProgress": _value = new global::Lua.LuaValue(global::UnityEditor.Lightmapping.buildProgress); return true;
                case "isRunning": _value = new global::Lua.LuaValue(global::UnityEditor.Lightmapping.isRunning); return true;
                case "lightingDataAsset": _value = _factory.Bind(global::UnityEditor.Lightmapping.lightingDataAsset); return true;
                case "lightingSettings": _value = _factory.Bind(global::UnityEditor.Lightmapping.lightingSettings); return true;
                case "lightingSettingsDefaults": _value = _factory.Bind(global::UnityEditor.Lightmapping.lightingSettingsDefaults); return true;
                case "realtimeGI": _value = new global::Lua.LuaValue(global::UnityEditor.Lightmapping.realtimeGI); return true;
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
                case "bakedGI": global::UnityEditor.Lightmapping.bakedGI = _value.Read<global::System.Boolean>();  return true;
                case "bakeOnSceneLoad": global::UnityEditor.Lightmapping.bakeOnSceneLoad = _value.Read<global::UnityEditor.Lightmapping.BakeOnSceneLoadMode>();  return true;
                case "lightingDataAsset": global::UnityEditor.Lightmapping.lightingDataAsset = _value.Read<global::LunyEditor.UnityEditor.LuaLightingDataAsset>().Instance;  return true;
                case "lightingSettings": global::UnityEditor.Lightmapping.lightingSettings = _value.Read<global::UnityEngine.LightingSettings>();  return true;
                case "realtimeGI": global::UnityEditor.Lightmapping.realtimeGI = _value.Read<global::System.Boolean>();  return true;
                default: return false;
            }
        }
    }
}
#pragma warning restore 0109, 0162, 0168, 0219
#endif
