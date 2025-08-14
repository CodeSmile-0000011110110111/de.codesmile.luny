
// --------------------------------------------------------------
// GENERATED FILE ----> DO NOT EDIT <---- CHANGES WILL BE LOST !!
// --------------------------------------------------------------

#if UNITY_6000_0_OR_NEWER && !(UNITY_6000_1_OR_NEWER)
#pragma warning disable 0109, 0162, 0168, 0219
using Luny;

namespace Luny.UnityEditor
{
    public sealed class LuaSceneViewSceneViewState : global::Luny.ILuaObject<global::UnityEditor.SceneView.SceneViewState>
    {
        public new static global::Lua.LuaValue Bind(global::UnityEditor.SceneView.SceneViewState instance) => new LuaSceneViewSceneViewState(instance);
        public new static global::Lua.LuaValue Bind(global::System.Object instance) => Bind((global::UnityEditor.SceneView.SceneViewState)instance);
        public new static global::Lua.LuaValue Bind(global::System.Collections.Generic.IList<global::UnityEditor.SceneView.SceneViewState> instances) =>
            new global::Luny.LuaList<global::UnityEditor.SceneView.SceneViewState>(instances);
        public new static global::Lua.LuaValue Bind(global::System.Collections.Generic.IList<global::System.Object> instances) =>
            new global::Luny.LuaList<global::UnityEditor.SceneView.SceneViewState>(instances);
        private LuaSceneViewSceneViewState(global::UnityEditor.SceneView.SceneViewState instance) => m_Instance = instance;
        public static implicit operator global::Lua.LuaValue(LuaSceneViewSceneViewState value) => new(value);
        private global::UnityEditor.SceneView.SceneViewState m_Instance;
        public global::UnityEditor.SceneView.SceneViewState Instance => m_Instance;
        public new global::System.Type BindType => typeof(global::UnityEditor.SceneView.SceneViewState);
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

        private static readonly global::Lua.LuaFunction _LuaSceneViewSceneViewState_SetAllEnabled = new global::Lua.LuaFunction("SetAllEnabled", (_context, _) =>
        {
            global::Lua.LuaValue _lastArg = default;
            global::System.Int32 _lastArgPos = default;
            global::System.Type _expectedType = default;
            var _argCount = _context.ArgumentCount;
            var _this = _context.GetArgument<LuaSceneViewSceneViewState>(0);
            var _arg0 = _lastArg = _argCount > 1 ? _context.GetArgument(1) : global::Lua.LuaValue.Nil;
            _lastArgPos = 0; _expectedType = typeof(global::System.Boolean);
            if (_arg0.TryRead<global::System.Boolean>(out var _p0_System_Boolean))
            {
                if (_argCount == 2)
                {
                    var value = _p0_System_Boolean;
                    _this.Instance.SetAllEnabled(value);
                    var _retCount = _context.Return();
                    return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                }
            }
            throw new global::Lua.LuaRuntimeException(_context.Thread, $"{"SetAllEnabled"}: invalid argument #{_lastArgPos}: {_lastArg} ({_lastArg.Type}), expected: {_expectedType.FullName}", 2);
        });
        private static readonly global::Lua.LuaFunction __index = new(global::Lua.Runtime.Metamethods.Index, (_context, _) =>
        {
            var _this = _context.GetArgument<LuaSceneViewSceneViewState>(0);
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
            var _this = _context.GetArgument<LuaSceneViewSceneViewState>(0);
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
                case "SetAllEnabled": _value = _LuaSceneViewSceneViewState_SetAllEnabled; return true;
                case "allEnabled": _value = new global::Lua.LuaValue(Instance.allEnabled); return true;
                case "alwaysRefresh": _value = new global::Lua.LuaValue(Instance.alwaysRefresh); return true;
                case "alwaysRefreshEnabled": _value = new global::Lua.LuaValue(Instance.alwaysRefreshEnabled); return true;
                case "cloudsEnabled": _value = new global::Lua.LuaValue(Instance.cloudsEnabled); return true;
                case "flaresEnabled": _value = new global::Lua.LuaValue(Instance.flaresEnabled); return true;
                case "fogEnabled": _value = new global::Lua.LuaValue(Instance.fogEnabled); return true;
                case "fxEnabled": _value = new global::Lua.LuaValue(Instance.fxEnabled); return true;
                case "imageEffectsEnabled": _value = new global::Lua.LuaValue(Instance.imageEffectsEnabled); return true;
                case "particleSystemsEnabled": _value = new global::Lua.LuaValue(Instance.particleSystemsEnabled); return true;
                case "showClouds": _value = new global::Lua.LuaValue(Instance.showClouds); return true;
                case "skyboxEnabled": _value = new global::Lua.LuaValue(Instance.skyboxEnabled); return true;
                case "visualEffectGraphsEnabled": _value = new global::Lua.LuaValue(Instance.visualEffectGraphsEnabled); return true;
                case "showFlares": _value = new global::Lua.LuaValue(Instance.showFlares); return true;
                case "showFog": _value = new global::Lua.LuaValue(Instance.showFog); return true;
                case "showImageEffects": _value = new global::Lua.LuaValue(Instance.showImageEffects); return true;
                case "showParticleSystems": _value = new global::Lua.LuaValue(Instance.showParticleSystems); return true;
                case "showSkybox": _value = new global::Lua.LuaValue(Instance.showSkybox); return true;
                case "showVisualEffectGraphs": _value = new global::Lua.LuaValue(Instance.showVisualEffectGraphs); return true;
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
                case "alwaysRefresh": Instance.alwaysRefresh = _value.Read<global::System.Boolean>();  return true;
                case "fxEnabled": Instance.fxEnabled = _value.Read<global::System.Boolean>();  return true;
                case "showClouds": Instance.showClouds = _value.Read<global::System.Boolean>();  return true;
                case "showFlares": Instance.showFlares = _value.Read<global::System.Boolean>();  return true;
                case "showFog": Instance.showFog = _value.Read<global::System.Boolean>();  return true;
                case "showImageEffects": Instance.showImageEffects = _value.Read<global::System.Boolean>();  return true;
                case "showParticleSystems": Instance.showParticleSystems = _value.Read<global::System.Boolean>();  return true;
                case "showSkybox": Instance.showSkybox = _value.Read<global::System.Boolean>();  return true;
                case "showVisualEffectGraphs": Instance.showVisualEffectGraphs = _value.Read<global::System.Boolean>();  return true;
                default: return false;
            }
        }
    }
    public sealed class LuaSceneViewSceneViewStateType : global::Luny.ILuaStatic
    {
        public static global::Lua.LuaValue Bind() => new LuaSceneViewSceneViewStateType();
        private LuaSceneViewSceneViewStateType() {}
        public static implicit operator global::Lua.LuaValue(LuaSceneViewSceneViewStateType value) => new(value);
        public global::System.Type BindType => typeof(global::UnityEditor.SceneView.SceneViewState);
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
            metatable[global::Lua.Runtime.Metamethods.Call] = _LuaSceneViewSceneViewState_new;
            return metatable;
        }
        public override global::System.String ToString() => BindType.FullName;
#if UNITY_EDITOR
        [global::UnityEngine.RuntimeInitializeOnLoadMethod(global::UnityEngine.RuntimeInitializeLoadType.SubsystemRegistration)]
        private static void ResetStaticFields() => s_Metatable = null;
#endif

        private static readonly global::Lua.LuaFunction _LuaSceneViewSceneViewState_new = new global::Lua.LuaFunction(".ctor", (_context, _) =>
        {
            global::Lua.LuaValue _lastArg = default;
            global::System.Int32 _lastArgPos = default;
            global::System.Type _expectedType = default;
            var _argCount = _context.ArgumentCount;
            if (_argCount == 1)
            {
                var _ret0 = new global::UnityEditor.SceneView.SceneViewState();
                var _factory = _context.GetObjectFactory();
                var _lret0 = _factory.Bind(_ret0);
                var _retCount = _context.Return(_lret0);
                return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
            }
            var _arg0 = _lastArg = _argCount > 1 ? _context.GetArgument(1) : global::Lua.LuaValue.Nil;
            _lastArgPos = 0; _expectedType = typeof(global::Luny.UnityEditor.LuaSceneViewSceneViewState);
            if (_arg0.TryRead<global::Luny.UnityEditor.LuaSceneViewSceneViewState>(out var _p0_UnityEditor_SceneView_SceneViewState))
            {
                if (_argCount == 2)
                {
                    var other = _p0_UnityEditor_SceneView_SceneViewState.Instance;
                    var _ret0 = new global::UnityEditor.SceneView.SceneViewState(other);
                    var _factory = _context.GetObjectFactory();
                    var _lret0 = _factory.Bind(_ret0);
                    var _retCount = _context.Return(_lret0);
                    return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                }
            }
            throw new global::Lua.LuaRuntimeException(_context.Thread, $"{".ctor"}: invalid argument #{_lastArgPos}: {_lastArg} ({_lastArg.Type}), expected: {_expectedType.FullName}", 2);
        });
        private static readonly global::Lua.LuaFunction __index = new(global::Lua.Runtime.Metamethods.Index, (_context, _) =>
        {
            var _this = _context.GetArgument<LuaSceneViewSceneViewStateType>(0);
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
            var _this = _context.GetArgument<LuaSceneViewSceneViewStateType>(0);
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
