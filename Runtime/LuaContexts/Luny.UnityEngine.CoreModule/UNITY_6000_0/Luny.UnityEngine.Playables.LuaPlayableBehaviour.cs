
// --------------------------------------------------------------
// GENERATED FILE ----> DO NOT EDIT <---- CHANGES WILL BE LOST !!
// --------------------------------------------------------------

#if UNITY_6000_0_OR_NEWER && !(UNITY_6000_1_OR_NEWER)
#pragma warning disable 0109, 0162, 0168, 0219
using Luny;

namespace Luny.UnityEngine.Playables
{
    public class LuaPlayableBehaviour : global::Luny.ILuaObject<global::UnityEngine.Playables.PlayableBehaviour>
    {
        public new static global::Lua.LuaValue Bind(global::UnityEngine.Playables.PlayableBehaviour instance) => new LuaPlayableBehaviour(instance);
        public new static global::Lua.LuaValue Bind(global::System.Object instance) => Bind((global::UnityEngine.Playables.PlayableBehaviour)instance);
        public new static global::Lua.LuaValue Bind(global::System.Collections.Generic.IList<global::UnityEngine.Playables.PlayableBehaviour> instances) =>
            new global::Luny.LuaList<global::UnityEngine.Playables.PlayableBehaviour>(instances);
        public new static global::Lua.LuaValue Bind(global::System.Collections.Generic.IList<global::System.Object> instances) =>
            new global::Luny.LuaList<global::UnityEngine.Playables.PlayableBehaviour>(instances);
        protected LuaPlayableBehaviour(global::UnityEngine.Playables.PlayableBehaviour instance) => m_Instance = instance;
        public static implicit operator global::Lua.LuaValue(LuaPlayableBehaviour value) => new(value);
        protected global::UnityEngine.Playables.PlayableBehaviour m_Instance;
        public global::UnityEngine.Playables.PlayableBehaviour Instance => m_Instance;
        public new global::System.Type BindType => typeof(global::UnityEngine.Playables.PlayableBehaviour);
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
        public override global::System.String ToString() => m_Instance != null ? Instance.ToString() : "{GetType().Name}(null)";
#if UNITY_EDITOR
        [global::UnityEngine.RuntimeInitializeOnLoadMethod(global::UnityEngine.RuntimeInitializeLoadType.SubsystemRegistration)]
        private static void ResetStaticFields() => s_Metatable = null;
#endif

        private static readonly global::Lua.LuaFunction _LuaPlayableBehaviour_Clone = new global::Lua.LuaFunction("Clone", (_context, _) =>
        {
            global::Lua.LuaValue _lastArg = default;
            global::System.Int32 _lastArgPos = default;
            global::System.Type _expectedType = default;
            var _argCount = _context.ArgumentCount;
            var _this = _context.GetArgument<LuaPlayableBehaviour>(0);
            if (_argCount == 1)
            {
                var _ret0 = _this.Instance.Clone();
                var _factory = _context.GetObjectFactory();
                var _lret0 = _factory.Bind(_ret0);
                var _retCount = _context.Return(_lret0);
                return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
            }
            throw new global::Lua.LuaRuntimeException(_context.Thread, $"{"Clone"}: invalid argument #{_lastArgPos}: {_lastArg} ({_lastArg.Type}), expected: {_expectedType.FullName}", 2);
        });
        private static readonly global::Lua.LuaFunction _LuaPlayableBehaviour_OnBehaviourPause = new global::Lua.LuaFunction("OnBehaviourPause", (_context, _) =>
        {
            global::Lua.LuaValue _lastArg = default;
            global::System.Int32 _lastArgPos = default;
            global::System.Type _expectedType = default;
            var _argCount = _context.ArgumentCount;
            var _this = _context.GetArgument<LuaPlayableBehaviour>(0);
            var _arg0 = _lastArg = _argCount > 1 ? _context.GetArgument(1) : global::Lua.LuaValue.Nil;
            _lastArgPos = 0; _expectedType = typeof(global::Luny.UnityEngine.Playables.LuaPlayable);
            if (_arg0.TryRead<global::Luny.UnityEngine.Playables.LuaPlayable>(out var _p0_UnityEngine_Playables_Playable))
            {
                var _arg1 = _lastArg = _argCount > 2 ? _context.GetArgument(2) : global::Lua.LuaValue.Nil;
                _lastArgPos = 1; _expectedType = typeof(global::Luny.UnityEngine.Playables.LuaFrameData);
                if (_arg1.TryRead<global::Luny.UnityEngine.Playables.LuaFrameData>(out var _p1_UnityEngine_Playables_FrameData))
                {
                    if (_argCount == 3)
                    {
                        var playable = _p0_UnityEngine_Playables_Playable.Value;
                        var info = _p1_UnityEngine_Playables_FrameData.Value;
                        _this.Instance.OnBehaviourPause(playable, info);
                        var _retCount = _context.Return();
                        return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                    }
                }
            }
            throw new global::Lua.LuaRuntimeException(_context.Thread, $"{"OnBehaviourPause"}: invalid argument #{_lastArgPos}: {_lastArg} ({_lastArg.Type}), expected: {_expectedType.FullName}", 2);
        });
        private static readonly global::Lua.LuaFunction _LuaPlayableBehaviour_OnBehaviourPlay = new global::Lua.LuaFunction("OnBehaviourPlay", (_context, _) =>
        {
            global::Lua.LuaValue _lastArg = default;
            global::System.Int32 _lastArgPos = default;
            global::System.Type _expectedType = default;
            var _argCount = _context.ArgumentCount;
            var _this = _context.GetArgument<LuaPlayableBehaviour>(0);
            var _arg0 = _lastArg = _argCount > 1 ? _context.GetArgument(1) : global::Lua.LuaValue.Nil;
            _lastArgPos = 0; _expectedType = typeof(global::Luny.UnityEngine.Playables.LuaPlayable);
            if (_arg0.TryRead<global::Luny.UnityEngine.Playables.LuaPlayable>(out var _p0_UnityEngine_Playables_Playable))
            {
                var _arg1 = _lastArg = _argCount > 2 ? _context.GetArgument(2) : global::Lua.LuaValue.Nil;
                _lastArgPos = 1; _expectedType = typeof(global::Luny.UnityEngine.Playables.LuaFrameData);
                if (_arg1.TryRead<global::Luny.UnityEngine.Playables.LuaFrameData>(out var _p1_UnityEngine_Playables_FrameData))
                {
                    if (_argCount == 3)
                    {
                        var playable = _p0_UnityEngine_Playables_Playable.Value;
                        var info = _p1_UnityEngine_Playables_FrameData.Value;
                        _this.Instance.OnBehaviourPlay(playable, info);
                        var _retCount = _context.Return();
                        return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                    }
                }
            }
            throw new global::Lua.LuaRuntimeException(_context.Thread, $"{"OnBehaviourPlay"}: invalid argument #{_lastArgPos}: {_lastArg} ({_lastArg.Type}), expected: {_expectedType.FullName}", 2);
        });
        private static readonly global::Lua.LuaFunction _LuaPlayableBehaviour_OnGraphStart = new global::Lua.LuaFunction("OnGraphStart", (_context, _) =>
        {
            global::Lua.LuaValue _lastArg = default;
            global::System.Int32 _lastArgPos = default;
            global::System.Type _expectedType = default;
            var _argCount = _context.ArgumentCount;
            var _this = _context.GetArgument<LuaPlayableBehaviour>(0);
            var _arg0 = _lastArg = _argCount > 1 ? _context.GetArgument(1) : global::Lua.LuaValue.Nil;
            _lastArgPos = 0; _expectedType = typeof(global::Luny.UnityEngine.Playables.LuaPlayable);
            if (_arg0.TryRead<global::Luny.UnityEngine.Playables.LuaPlayable>(out var _p0_UnityEngine_Playables_Playable))
            {
                if (_argCount == 2)
                {
                    var playable = _p0_UnityEngine_Playables_Playable.Value;
                    _this.Instance.OnGraphStart(playable);
                    var _retCount = _context.Return();
                    return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                }
            }
            throw new global::Lua.LuaRuntimeException(_context.Thread, $"{"OnGraphStart"}: invalid argument #{_lastArgPos}: {_lastArg} ({_lastArg.Type}), expected: {_expectedType.FullName}", 2);
        });
        private static readonly global::Lua.LuaFunction _LuaPlayableBehaviour_OnGraphStop = new global::Lua.LuaFunction("OnGraphStop", (_context, _) =>
        {
            global::Lua.LuaValue _lastArg = default;
            global::System.Int32 _lastArgPos = default;
            global::System.Type _expectedType = default;
            var _argCount = _context.ArgumentCount;
            var _this = _context.GetArgument<LuaPlayableBehaviour>(0);
            var _arg0 = _lastArg = _argCount > 1 ? _context.GetArgument(1) : global::Lua.LuaValue.Nil;
            _lastArgPos = 0; _expectedType = typeof(global::Luny.UnityEngine.Playables.LuaPlayable);
            if (_arg0.TryRead<global::Luny.UnityEngine.Playables.LuaPlayable>(out var _p0_UnityEngine_Playables_Playable))
            {
                if (_argCount == 2)
                {
                    var playable = _p0_UnityEngine_Playables_Playable.Value;
                    _this.Instance.OnGraphStop(playable);
                    var _retCount = _context.Return();
                    return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                }
            }
            throw new global::Lua.LuaRuntimeException(_context.Thread, $"{"OnGraphStop"}: invalid argument #{_lastArgPos}: {_lastArg} ({_lastArg.Type}), expected: {_expectedType.FullName}", 2);
        });
        private static readonly global::Lua.LuaFunction _LuaPlayableBehaviour_OnPlayableCreate = new global::Lua.LuaFunction("OnPlayableCreate", (_context, _) =>
        {
            global::Lua.LuaValue _lastArg = default;
            global::System.Int32 _lastArgPos = default;
            global::System.Type _expectedType = default;
            var _argCount = _context.ArgumentCount;
            var _this = _context.GetArgument<LuaPlayableBehaviour>(0);
            var _arg0 = _lastArg = _argCount > 1 ? _context.GetArgument(1) : global::Lua.LuaValue.Nil;
            _lastArgPos = 0; _expectedType = typeof(global::Luny.UnityEngine.Playables.LuaPlayable);
            if (_arg0.TryRead<global::Luny.UnityEngine.Playables.LuaPlayable>(out var _p0_UnityEngine_Playables_Playable))
            {
                if (_argCount == 2)
                {
                    var playable = _p0_UnityEngine_Playables_Playable.Value;
                    _this.Instance.OnPlayableCreate(playable);
                    var _retCount = _context.Return();
                    return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                }
            }
            throw new global::Lua.LuaRuntimeException(_context.Thread, $"{"OnPlayableCreate"}: invalid argument #{_lastArgPos}: {_lastArg} ({_lastArg.Type}), expected: {_expectedType.FullName}", 2);
        });
        private static readonly global::Lua.LuaFunction _LuaPlayableBehaviour_OnPlayableDestroy = new global::Lua.LuaFunction("OnPlayableDestroy", (_context, _) =>
        {
            global::Lua.LuaValue _lastArg = default;
            global::System.Int32 _lastArgPos = default;
            global::System.Type _expectedType = default;
            var _argCount = _context.ArgumentCount;
            var _this = _context.GetArgument<LuaPlayableBehaviour>(0);
            var _arg0 = _lastArg = _argCount > 1 ? _context.GetArgument(1) : global::Lua.LuaValue.Nil;
            _lastArgPos = 0; _expectedType = typeof(global::Luny.UnityEngine.Playables.LuaPlayable);
            if (_arg0.TryRead<global::Luny.UnityEngine.Playables.LuaPlayable>(out var _p0_UnityEngine_Playables_Playable))
            {
                if (_argCount == 2)
                {
                    var playable = _p0_UnityEngine_Playables_Playable.Value;
                    _this.Instance.OnPlayableDestroy(playable);
                    var _retCount = _context.Return();
                    return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                }
            }
            throw new global::Lua.LuaRuntimeException(_context.Thread, $"{"OnPlayableDestroy"}: invalid argument #{_lastArgPos}: {_lastArg} ({_lastArg.Type}), expected: {_expectedType.FullName}", 2);
        });
        private static readonly global::Lua.LuaFunction _LuaPlayableBehaviour_PrepareData = new global::Lua.LuaFunction("PrepareData", (_context, _) =>
        {
            global::Lua.LuaValue _lastArg = default;
            global::System.Int32 _lastArgPos = default;
            global::System.Type _expectedType = default;
            var _argCount = _context.ArgumentCount;
            var _this = _context.GetArgument<LuaPlayableBehaviour>(0);
            var _arg0 = _lastArg = _argCount > 1 ? _context.GetArgument(1) : global::Lua.LuaValue.Nil;
            _lastArgPos = 0; _expectedType = typeof(global::Luny.UnityEngine.Playables.LuaPlayable);
            if (_arg0.TryRead<global::Luny.UnityEngine.Playables.LuaPlayable>(out var _p0_UnityEngine_Playables_Playable))
            {
                var _arg1 = _lastArg = _argCount > 2 ? _context.GetArgument(2) : global::Lua.LuaValue.Nil;
                _lastArgPos = 1; _expectedType = typeof(global::Luny.UnityEngine.Playables.LuaFrameData);
                if (_arg1.TryRead<global::Luny.UnityEngine.Playables.LuaFrameData>(out var _p1_UnityEngine_Playables_FrameData))
                {
                    if (_argCount == 3)
                    {
                        var playable = _p0_UnityEngine_Playables_Playable.Value;
                        var info = _p1_UnityEngine_Playables_FrameData.Value;
                        _this.Instance.PrepareData(playable, info);
                        var _retCount = _context.Return();
                        return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                    }
                }
            }
            throw new global::Lua.LuaRuntimeException(_context.Thread, $"{"PrepareData"}: invalid argument #{_lastArgPos}: {_lastArg} ({_lastArg.Type}), expected: {_expectedType.FullName}", 2);
        });
        private static readonly global::Lua.LuaFunction _LuaPlayableBehaviour_PrepareFrame = new global::Lua.LuaFunction("PrepareFrame", (_context, _) =>
        {
            global::Lua.LuaValue _lastArg = default;
            global::System.Int32 _lastArgPos = default;
            global::System.Type _expectedType = default;
            var _argCount = _context.ArgumentCount;
            var _this = _context.GetArgument<LuaPlayableBehaviour>(0);
            var _arg0 = _lastArg = _argCount > 1 ? _context.GetArgument(1) : global::Lua.LuaValue.Nil;
            _lastArgPos = 0; _expectedType = typeof(global::Luny.UnityEngine.Playables.LuaPlayable);
            if (_arg0.TryRead<global::Luny.UnityEngine.Playables.LuaPlayable>(out var _p0_UnityEngine_Playables_Playable))
            {
                var _arg1 = _lastArg = _argCount > 2 ? _context.GetArgument(2) : global::Lua.LuaValue.Nil;
                _lastArgPos = 1; _expectedType = typeof(global::Luny.UnityEngine.Playables.LuaFrameData);
                if (_arg1.TryRead<global::Luny.UnityEngine.Playables.LuaFrameData>(out var _p1_UnityEngine_Playables_FrameData))
                {
                    if (_argCount == 3)
                    {
                        var playable = _p0_UnityEngine_Playables_Playable.Value;
                        var info = _p1_UnityEngine_Playables_FrameData.Value;
                        _this.Instance.PrepareFrame(playable, info);
                        var _retCount = _context.Return();
                        return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                    }
                }
            }
            throw new global::Lua.LuaRuntimeException(_context.Thread, $"{"PrepareFrame"}: invalid argument #{_lastArgPos}: {_lastArg} ({_lastArg.Type}), expected: {_expectedType.FullName}", 2);
        });
        private static readonly global::Lua.LuaFunction _LuaPlayableBehaviour_ProcessFrame = new global::Lua.LuaFunction("ProcessFrame", (_context, _) =>
        {
            global::Lua.LuaValue _lastArg = default;
            global::System.Int32 _lastArgPos = default;
            global::System.Type _expectedType = default;
            var _argCount = _context.ArgumentCount;
            var _this = _context.GetArgument<LuaPlayableBehaviour>(0);
            var _arg0 = _lastArg = _argCount > 1 ? _context.GetArgument(1) : global::Lua.LuaValue.Nil;
            _lastArgPos = 0; _expectedType = typeof(global::Luny.UnityEngine.Playables.LuaPlayable);
            if (_arg0.TryRead<global::Luny.UnityEngine.Playables.LuaPlayable>(out var _p0_UnityEngine_Playables_Playable))
            {
                var _arg1 = _lastArg = _argCount > 2 ? _context.GetArgument(2) : global::Lua.LuaValue.Nil;
                _lastArgPos = 1; _expectedType = typeof(global::Luny.UnityEngine.Playables.LuaFrameData);
                if (_arg1.TryRead<global::Luny.UnityEngine.Playables.LuaFrameData>(out var _p1_UnityEngine_Playables_FrameData))
                {
                    var _arg2 = _lastArg = _argCount > 3 ? _context.GetArgument(3) : global::Lua.LuaValue.Nil;
                    _lastArgPos = 2; _expectedType = typeof(global::System.Object);
                    if (_arg2.TryRead<global::System.Object>(out var _p2_System_Object))
                    {
                        if (_argCount == 4)
                        {
                            var playable = _p0_UnityEngine_Playables_Playable.Value;
                            var info = _p1_UnityEngine_Playables_FrameData.Value;
                            var playerData = _p2_System_Object;
                            _this.Instance.ProcessFrame(playable, info, playerData);
                            var _retCount = _context.Return();
                            return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                        }
                    }
                }
            }
            throw new global::Lua.LuaRuntimeException(_context.Thread, $"{"ProcessFrame"}: invalid argument #{_lastArgPos}: {_lastArg} ({_lastArg.Type}), expected: {_expectedType.FullName}", 2);
        });
        private static readonly global::Lua.LuaFunction __index = new(global::Lua.Runtime.Metamethods.Index, (_context, _) =>
        {
            var _this = _context.GetArgument<LuaPlayableBehaviour>(0);
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
            var _this = _context.GetArgument<LuaPlayableBehaviour>(0);
            var _key = _context.GetArgument(1);
            var _value = _context.GetArgument(2);
            if (_key.Type == global::Lua.LuaValueType.Number && _key.TryRead<global::System.Int32>(out var _index) && _this.TrySetLuaValue(_index, _value))
                return new global::System.Threading.Tasks.ValueTask<global::System.Int32>(_context.Return(_value));
            if (_key.Type == global::Lua.LuaValueType.String && _this.TrySetLuaValue(_key.Read<global::System.String>(), _value))
                return new global::System.Threading.Tasks.ValueTask<global::System.Int32>(_context.Return(_value));
            throw new global::Lua.LuaRuntimeException(_context.Thread, $"attempt to assign to unknown '{_key}' on '{_this}'", 2);
        });

        public virtual global::System.Boolean TryGetLuaValue(global::System.Int32 _key, out global::Lua.LuaValue _value, global::Luny.ILuaObjectFactory _factory)
        {
            _value = global::Lua.LuaValue.Nil; return false;
        }
        public virtual global::System.Boolean TryGetLuaValue(global::System.String _key, out global::Lua.LuaValue _value, global::Luny.ILuaObjectFactory _factory)
        {
            switch (_key)
            {
                case "Clone": _value = _LuaPlayableBehaviour_Clone; return true;
                case "OnBehaviourPause": _value = _LuaPlayableBehaviour_OnBehaviourPause; return true;
                case "OnBehaviourPlay": _value = _LuaPlayableBehaviour_OnBehaviourPlay; return true;
                case "OnGraphStart": _value = _LuaPlayableBehaviour_OnGraphStart; return true;
                case "OnGraphStop": _value = _LuaPlayableBehaviour_OnGraphStop; return true;
                case "OnPlayableCreate": _value = _LuaPlayableBehaviour_OnPlayableCreate; return true;
                case "OnPlayableDestroy": _value = _LuaPlayableBehaviour_OnPlayableDestroy; return true;
                case "PrepareData": _value = _LuaPlayableBehaviour_PrepareData; return true;
                case "PrepareFrame": _value = _LuaPlayableBehaviour_PrepareFrame; return true;
                case "ProcessFrame": _value = _LuaPlayableBehaviour_ProcessFrame; return true;
                default: _value = global::Lua.LuaValue.Nil; return false;
            }
        }
        public virtual global::System.Boolean TrySetLuaValue(global::System.Int32 _key, global::Lua.LuaValue _value)
        {
            return false;
        }
        public virtual global::System.Boolean TrySetLuaValue(global::System.String _key, global::Lua.LuaValue _value)
        {
            switch (_key)
            {
                default: return false;
            }
        }
    }
    public sealed class LuaPlayableBehaviourType : global::Luny.ILuaStatic
    {
        public static global::Lua.LuaValue Bind() => new LuaPlayableBehaviourType();
        private LuaPlayableBehaviourType() {}
        public static implicit operator global::Lua.LuaValue(LuaPlayableBehaviourType value) => new(value);
        public global::System.Type BindType => typeof(global::UnityEngine.Playables.PlayableBehaviour);
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
            var _this = _context.GetArgument<LuaPlayableBehaviourType>(0);
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
            var _this = _context.GetArgument<LuaPlayableBehaviourType>(0);
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
