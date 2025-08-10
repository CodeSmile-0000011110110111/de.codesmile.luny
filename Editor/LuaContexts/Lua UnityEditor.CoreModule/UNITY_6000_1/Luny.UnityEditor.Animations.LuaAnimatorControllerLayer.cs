
// --------------------------------------------------------------
// GENERATED FILE ----> DO NOT EDIT <---- CHANGES WILL BE LOST !!
// --------------------------------------------------------------

#if UNITY_6000_1_OR_NEWER && !(UNITY_6000_2_OR_NEWER)
#pragma warning disable 0109, 0162, 0168, 0219
using Luny;

namespace Luny.UnityEditor.Animations
{
    public sealed class LuaAnimatorControllerLayer : global::Luny.ILuaObject<global::UnityEditor.Animations.AnimatorControllerLayer>
    {
        public new static global::Lua.LuaValue Bind(global::UnityEditor.Animations.AnimatorControllerLayer instance) => new LuaAnimatorControllerLayer(instance);
        public new static global::Lua.LuaValue Bind(global::System.Object instance) => Bind((global::UnityEditor.Animations.AnimatorControllerLayer)instance);
        public new static global::Lua.LuaValue Bind(global::System.Collections.Generic.IList<global::UnityEditor.Animations.AnimatorControllerLayer> instances) =>
            new global::Luny.LuaList<global::UnityEditor.Animations.AnimatorControllerLayer>(instances);
        public new static global::Lua.LuaValue Bind(global::System.Collections.Generic.IList<global::System.Object> instances) =>
            new global::Luny.LuaList<global::UnityEditor.Animations.AnimatorControllerLayer>(instances);
        private LuaAnimatorControllerLayer(global::UnityEditor.Animations.AnimatorControllerLayer instance) => m_Instance = instance;
        public static implicit operator global::Lua.LuaValue(LuaAnimatorControllerLayer value) => new(value);
        private global::UnityEditor.Animations.AnimatorControllerLayer m_Instance;
        public global::UnityEditor.Animations.AnimatorControllerLayer Instance => m_Instance;
        public new global::System.Type BindType => typeof(global::UnityEditor.Animations.AnimatorControllerLayer);
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

        private static readonly global::Lua.LuaFunction _LuaAnimatorControllerLayer_GetOverrideBehaviours = new global::Lua.LuaFunction("GetOverrideBehaviours", (_context, _) =>
        {
            global::Lua.LuaValue _lastArg = default;
            global::System.Int32 _lastArgPos = default;
            global::System.Type _expectedType = default;
            var _argCount = _context.ArgumentCount;
            var _this = _context.GetArgument<LuaAnimatorControllerLayer>(0);
            var _arg0 = _lastArg = _argCount > 1 ? _context.GetArgument(1) : global::Lua.LuaValue.Nil;
            _lastArgPos = 0; _expectedType = typeof(global::Luny.UnityEditor.Animations.LuaAnimatorState);
            if (_arg0.TryRead<global::Luny.UnityEditor.Animations.LuaAnimatorState>(out var _p0_UnityEditor_Animations_AnimatorState))
            {
                if (_argCount == 2)
                {
                    var state = _p0_UnityEditor_Animations_AnimatorState.Instance;
                    var _ret0 = _this.Instance.GetOverrideBehaviours(state);
                    var _factory = _context.GetObjectFactory();
                    var _lret0 = _factory.Bind(_ret0);
                    var _retCount = _context.Return(_lret0);
                    return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                }
            }
            throw new global::Lua.LuaRuntimeException(_context.Thread, $"{"GetOverrideBehaviours"}: invalid argument #{_lastArgPos}: {_lastArg} ({_lastArg.Type}), expected: {_expectedType.FullName}", 2);
        });
        private static readonly global::Lua.LuaFunction _LuaAnimatorControllerLayer_GetOverrideMotion = new global::Lua.LuaFunction("GetOverrideMotion", (_context, _) =>
        {
            global::Lua.LuaValue _lastArg = default;
            global::System.Int32 _lastArgPos = default;
            global::System.Type _expectedType = default;
            var _argCount = _context.ArgumentCount;
            var _this = _context.GetArgument<LuaAnimatorControllerLayer>(0);
            var _arg0 = _lastArg = _argCount > 1 ? _context.GetArgument(1) : global::Lua.LuaValue.Nil;
            _lastArgPos = 0; _expectedType = typeof(global::Luny.UnityEditor.Animations.LuaAnimatorState);
            if (_arg0.TryRead<global::Luny.UnityEditor.Animations.LuaAnimatorState>(out var _p0_UnityEditor_Animations_AnimatorState))
            {
                if (_argCount == 2)
                {
                    var state = _p0_UnityEditor_Animations_AnimatorState.Instance;
                    var _ret0 = _this.Instance.GetOverrideMotion(state);
                    var _factory = _context.GetObjectFactory();
                    var _lret0 = _factory.Bind(_ret0);
                    var _retCount = _context.Return(_lret0);
                    return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                }
            }
            throw new global::Lua.LuaRuntimeException(_context.Thread, $"{"GetOverrideMotion"}: invalid argument #{_lastArgPos}: {_lastArg} ({_lastArg.Type}), expected: {_expectedType.FullName}", 2);
        });
        private static readonly global::Lua.LuaFunction _LuaAnimatorControllerLayer_SetOverrideBehaviours = new global::Lua.LuaFunction("SetOverrideBehaviours", (_context, _) =>
        {
            global::Lua.LuaValue _lastArg = default;
            global::System.Int32 _lastArgPos = default;
            global::System.Type _expectedType = default;
            var _argCount = _context.ArgumentCount;
            var _this = _context.GetArgument<LuaAnimatorControllerLayer>(0);
            var _arg0 = _lastArg = _argCount > 1 ? _context.GetArgument(1) : global::Lua.LuaValue.Nil;
            _lastArgPos = 0; _expectedType = typeof(global::Luny.UnityEditor.Animations.LuaAnimatorState);
            if (_arg0.TryRead<global::Luny.UnityEditor.Animations.LuaAnimatorState>(out var _p0_UnityEditor_Animations_AnimatorState))
            {
                var _arg1 = _lastArg = _argCount > 2 ? _context.GetArgument(2) : global::Lua.LuaValue.Nil;
                _lastArgPos = 1; _expectedType = typeof(global::UnityEngine.StateMachineBehaviour[]);
                if (_arg1.TryReadArray<global::UnityEngine.StateMachineBehaviour>(out var _p1_UnityEngine_StateMachineBehaviourArray))
                {
                    if (_argCount == 3)
                    {
                        var state = _p0_UnityEditor_Animations_AnimatorState.Instance;
                        var behaviours = _p1_UnityEngine_StateMachineBehaviourArray;
                        _this.Instance.SetOverrideBehaviours(state, behaviours);
                        var _retCount = _context.Return();
                        return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                    }
                }
            }
            throw new global::Lua.LuaRuntimeException(_context.Thread, $"{"SetOverrideBehaviours"}: invalid argument #{_lastArgPos}: {_lastArg} ({_lastArg.Type}), expected: {_expectedType.FullName}", 2);
        });
        private static readonly global::Lua.LuaFunction _LuaAnimatorControllerLayer_SetOverrideMotion = new global::Lua.LuaFunction("SetOverrideMotion", (_context, _) =>
        {
            global::Lua.LuaValue _lastArg = default;
            global::System.Int32 _lastArgPos = default;
            global::System.Type _expectedType = default;
            var _argCount = _context.ArgumentCount;
            var _this = _context.GetArgument<LuaAnimatorControllerLayer>(0);
            var _arg0 = _lastArg = _argCount > 1 ? _context.GetArgument(1) : global::Lua.LuaValue.Nil;
            _lastArgPos = 0; _expectedType = typeof(global::Luny.UnityEditor.Animations.LuaAnimatorState);
            if (_arg0.TryRead<global::Luny.UnityEditor.Animations.LuaAnimatorState>(out var _p0_UnityEditor_Animations_AnimatorState))
            {
                var _arg1 = _lastArg = _argCount > 2 ? _context.GetArgument(2) : global::Lua.LuaValue.Nil;
                _lastArgPos = 1; _expectedType = typeof(global::UnityEngine.Motion);
                if (_arg1.TryRead<global::UnityEngine.Motion>(out var _p1_UnityEngine_Motion))
                {
                    if (_argCount == 3)
                    {
                        var state = _p0_UnityEditor_Animations_AnimatorState.Instance;
                        var motion = _p1_UnityEngine_Motion;
                        _this.Instance.SetOverrideMotion(state, motion);
                        var _retCount = _context.Return();
                        return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                    }
                }
            }
            throw new global::Lua.LuaRuntimeException(_context.Thread, $"{"SetOverrideMotion"}: invalid argument #{_lastArgPos}: {_lastArg} ({_lastArg.Type}), expected: {_expectedType.FullName}", 2);
        });
        private static readonly global::Lua.LuaFunction __index = new(global::Lua.Runtime.Metamethods.Index, (_context, _) =>
        {
            var _this = _context.GetArgument<LuaAnimatorControllerLayer>(0);
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
            var _this = _context.GetArgument<LuaAnimatorControllerLayer>(0);
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
                case "GetOverrideBehaviours": _value = _LuaAnimatorControllerLayer_GetOverrideBehaviours; return true;
                case "GetOverrideMotion": _value = _LuaAnimatorControllerLayer_GetOverrideMotion; return true;
                case "SetOverrideBehaviours": _value = _LuaAnimatorControllerLayer_SetOverrideBehaviours; return true;
                case "SetOverrideMotion": _value = _LuaAnimatorControllerLayer_SetOverrideMotion; return true;
                case "avatarMask": _value = _factory.Bind(Instance.avatarMask); return true;
                case "blendingMode": _value = new global::Lua.LuaValue((global::System.Int64)Instance.blendingMode); return true;
                case "defaultWeight": _value = new global::Lua.LuaValue(Instance.defaultWeight); return true;
                case "iKPass": _value = new global::Lua.LuaValue(Instance.iKPass); return true;
                case "name": _value = new global::Lua.LuaValue(Instance.name); return true;
                case "stateMachine": _value = _factory.Bind(Instance.stateMachine); return true;
                case "syncedLayerAffectsTiming": _value = new global::Lua.LuaValue(Instance.syncedLayerAffectsTiming); return true;
                case "syncedLayerIndex": _value = new global::Lua.LuaValue(Instance.syncedLayerIndex); return true;
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
                case "avatarMask": Instance.avatarMask = _value.Read<global::UnityEngine.AvatarMask>();  return true;
                case "blendingMode": Instance.blendingMode = _value.Read<global::UnityEditor.Animations.AnimatorLayerBlendingMode>();  return true;
                case "defaultWeight": Instance.defaultWeight = _value.Read<global::System.Single>();  return true;
                case "iKPass": Instance.iKPass = _value.Read<global::System.Boolean>();  return true;
                case "name": Instance.name = _value.Read<global::System.String>();  return true;
                case "stateMachine": Instance.stateMachine = _value.Read<global::Luny.UnityEditor.Animations.LuaAnimatorStateMachine>().Instance;  return true;
                case "syncedLayerAffectsTiming": Instance.syncedLayerAffectsTiming = _value.Read<global::System.Boolean>();  return true;
                case "syncedLayerIndex": Instance.syncedLayerIndex = _value.Read<global::System.Int32>();  return true;
                default: return false;
            }
        }
    }
    public sealed class LuaAnimatorControllerLayerType : global::Luny.ILuaStatic
    {
        public static global::Lua.LuaValue Bind() => new LuaAnimatorControllerLayerType();
        private LuaAnimatorControllerLayerType() {}
        public static implicit operator global::Lua.LuaValue(LuaAnimatorControllerLayerType value) => new(value);
        public global::System.Type BindType => typeof(global::UnityEditor.Animations.AnimatorControllerLayer);
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

        private static readonly global::Lua.LuaFunction _LuaAnimatorControllerLayer_new = new global::Lua.LuaFunction(".ctor", (_context, _) =>
        {
            global::Lua.LuaValue _lastArg = default;
            global::System.Int32 _lastArgPos = default;
            global::System.Type _expectedType = default;
            var _argCount = _context.ArgumentCount;
            if (_argCount == 0)
            {
                var _ret0 = new global::UnityEditor.Animations.AnimatorControllerLayer();
                var _factory = _context.GetObjectFactory();
                var _lret0 = _factory.Bind(_ret0);
                var _retCount = _context.Return(_lret0);
                return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
            }
            throw new global::Lua.LuaRuntimeException(_context.Thread, $"{".ctor"}: invalid argument #{_lastArgPos}: {_lastArg} ({_lastArg.Type}), expected: {_expectedType.FullName}", 2);
        });
        private static readonly global::Lua.LuaFunction __index = new(global::Lua.Runtime.Metamethods.Index, (_context, _) =>
        {
            var _this = _context.GetArgument<LuaAnimatorControllerLayerType>(0);
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
            var _this = _context.GetArgument<LuaAnimatorControllerLayerType>(0);
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
                case "new": _value = _LuaAnimatorControllerLayer_new; return true;
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
