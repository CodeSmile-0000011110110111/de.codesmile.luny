
// --------------------------------------------------------------
// GENERATED FILE ----> DO NOT EDIT <---- CHANGES WILL BE LOST !!
// --------------------------------------------------------------

#if UNITY_6000_0_OR_NEWER && !(UNITY_6000_1_OR_NEWER)
#pragma warning disable 0109, 0162, 0168, 0219
using Luny;

namespace Luny.UnityEngine
{
    public class LuaTime : global::Luny.ILuaObject<global::UnityEngine.Time>
    {
        public new static global::Lua.LuaValue Bind(global::UnityEngine.Time instance) => new LuaTime(instance);
        public new static global::Lua.LuaValue Bind(global::System.Object instance) => Bind((global::UnityEngine.Time)instance);
        public new static global::Lua.LuaValue Bind(global::System.Collections.Generic.IList<global::UnityEngine.Time> instances) =>
            new global::Luny.LuaList<global::UnityEngine.Time>(instances);
        public new static global::Lua.LuaValue Bind(global::System.Collections.Generic.IList<global::System.Object> instances) =>
            new global::Luny.LuaList<global::UnityEngine.Time>(instances);
        protected LuaTime(global::UnityEngine.Time instance) => m_Instance = instance;
        public static implicit operator global::Lua.LuaValue(LuaTime value) => new(value);
        protected global::UnityEngine.Time m_Instance;
        public global::UnityEngine.Time Instance => m_Instance;
        public new global::System.Type BindType => typeof(global::UnityEngine.Time);
        public override global::System.String ToString() => m_Instance != null ? Instance.ToString() : "{GetType().Name}(null)";
#if UNITY_EDITOR
        [global::UnityEngine.RuntimeInitializeOnLoadMethod(global::UnityEngine.RuntimeInitializeLoadType.SubsystemRegistration)]
        private static void ResetStaticFields() => s_Metatable = null;
#endif

        private static readonly global::Lua.LuaFunction __index = new(global::Lua.Runtime.Metamethods.Index, (_context, _) =>
        {
            var _this = _context.GetArgument<LuaTime>(0);
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
            var _this = _context.GetArgument<LuaTime>(0);
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

        public virtual global::System.Boolean TryGetLuaValue(global::System.Int32 _key, out global::Lua.LuaValue _value, global::Luny.ILuaObjectFactory _factory)
        {
            _value = global::Lua.LuaValue.Nil; return false;
        }
        public virtual global::System.Boolean TryGetLuaValue(global::System.String _key, out global::Lua.LuaValue _value, global::Luny.ILuaObjectFactory _factory)
        {
            switch (_key)
            {
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
    public sealed class LuaTimeType : global::Luny.ILuaStatic
    {
        public static global::Lua.LuaValue Bind() => new LuaTimeType();
        private LuaTimeType() {}
        public static implicit operator global::Lua.LuaValue(LuaTimeType value) => new(value);
        public global::System.Type BindType => typeof(global::UnityEngine.Time);
        public override global::System.String ToString() => BindType.FullName;
#if UNITY_EDITOR
        [global::UnityEngine.RuntimeInitializeOnLoadMethod(global::UnityEngine.RuntimeInitializeLoadType.SubsystemRegistration)]
        private static void ResetStaticFields() => s_Metatable = null;
#endif

        private static readonly global::Lua.LuaFunction _LuaTime_new = new global::Lua.LuaFunction(".ctor", (_context, _) =>
        {
            global::Lua.LuaValue _lastArg = default;
            global::System.Int32 _lastArgPos = default;
            global::System.Type _expectedType = default;
            var _argCount = _context.ArgumentCount;
            if (_argCount == 1)
            {
                var _ret0 = new global::UnityEngine.Time();
                var _factory = _context.GetObjectFactory();
                var _lret0 = _factory.Bind(_ret0);
                var _retCount = _context.Return(_lret0);
                return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
            }
            throw new global::Lua.LuaRuntimeException(_context.Thread, $"{".ctor"}: invalid argument #{_lastArgPos}: {_lastArg} ({_lastArg.Type}), expected: {_expectedType.FullName}", 2);
        });
        private static readonly global::Lua.LuaFunction __index = new(global::Lua.Runtime.Metamethods.Index, (_context, _) =>
        {
            var _this = _context.GetArgument<LuaTimeType>(0);
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
            var _this = _context.GetArgument<LuaTimeType>(0);
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
            metatable[global::Lua.Runtime.Metamethods.Call] = _LuaTime_new;
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
                case "captureDeltaTime": _value = new global::Lua.LuaValue(global::UnityEngine.Time.captureDeltaTime); return true;
                case "captureDeltaTimeRational": _value = global::Luny.Unity.IntegerTime.LuaRationalTime.Bind(global::UnityEngine.Time.captureDeltaTimeRational); return true;
                case "captureFramerate": _value = new global::Lua.LuaValue(global::UnityEngine.Time.captureFramerate); return true;
                case "deltaTime": _value = new global::Lua.LuaValue(global::UnityEngine.Time.deltaTime); return true;
                case "fixedDeltaTime": _value = new global::Lua.LuaValue(global::UnityEngine.Time.fixedDeltaTime); return true;
                case "fixedTime": _value = new global::Lua.LuaValue(global::UnityEngine.Time.fixedTime); return true;
                case "fixedTimeAsDouble": _value = new global::Lua.LuaValue(global::UnityEngine.Time.fixedTimeAsDouble); return true;
                case "fixedUnscaledDeltaTime": _value = new global::Lua.LuaValue(global::UnityEngine.Time.fixedUnscaledDeltaTime); return true;
                case "fixedUnscaledTime": _value = new global::Lua.LuaValue(global::UnityEngine.Time.fixedUnscaledTime); return true;
                case "fixedUnscaledTimeAsDouble": _value = new global::Lua.LuaValue(global::UnityEngine.Time.fixedUnscaledTimeAsDouble); return true;
                case "frameCount": _value = new global::Lua.LuaValue(global::UnityEngine.Time.frameCount); return true;
                case "inFixedTimeStep": _value = new global::Lua.LuaValue(global::UnityEngine.Time.inFixedTimeStep); return true;
                case "maximumDeltaTime": _value = new global::Lua.LuaValue(global::UnityEngine.Time.maximumDeltaTime); return true;
                case "maximumParticleDeltaTime": _value = new global::Lua.LuaValue(global::UnityEngine.Time.maximumParticleDeltaTime); return true;
                case "realtimeSinceStartup": _value = new global::Lua.LuaValue(global::UnityEngine.Time.realtimeSinceStartup); return true;
                case "realtimeSinceStartupAsDouble": _value = new global::Lua.LuaValue(global::UnityEngine.Time.realtimeSinceStartupAsDouble); return true;
                case "renderedFrameCount": _value = new global::Lua.LuaValue(global::UnityEngine.Time.renderedFrameCount); return true;
                case "smoothDeltaTime": _value = new global::Lua.LuaValue(global::UnityEngine.Time.smoothDeltaTime); return true;
                case "time": _value = new global::Lua.LuaValue(global::UnityEngine.Time.time); return true;
                case "timeAsDouble": _value = new global::Lua.LuaValue(global::UnityEngine.Time.timeAsDouble); return true;
                case "timeAsRational": _value = global::Luny.Unity.IntegerTime.LuaRationalTime.Bind(global::UnityEngine.Time.timeAsRational); return true;
                case "timeScale": _value = new global::Lua.LuaValue(global::UnityEngine.Time.timeScale); return true;
                case "timeSinceLevelLoad": _value = new global::Lua.LuaValue(global::UnityEngine.Time.timeSinceLevelLoad); return true;
                case "timeSinceLevelLoadAsDouble": _value = new global::Lua.LuaValue(global::UnityEngine.Time.timeSinceLevelLoadAsDouble); return true;
                case "unscaledDeltaTime": _value = new global::Lua.LuaValue(global::UnityEngine.Time.unscaledDeltaTime); return true;
                case "unscaledTime": _value = new global::Lua.LuaValue(global::UnityEngine.Time.unscaledTime); return true;
                case "unscaledTimeAsDouble": _value = new global::Lua.LuaValue(global::UnityEngine.Time.unscaledTimeAsDouble); return true;
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
                case "captureDeltaTime": global::UnityEngine.Time.captureDeltaTime = _value.Read<global::System.Single>();  return true;
                case "captureDeltaTimeRational": global::UnityEngine.Time.captureDeltaTimeRational = _value.Read<global::Luny.Unity.IntegerTime.LuaRationalTime>().Value;  return true;
                case "captureFramerate": global::UnityEngine.Time.captureFramerate = _value.Read<global::System.Int32>();  return true;
                case "fixedDeltaTime": global::UnityEngine.Time.fixedDeltaTime = _value.Read<global::System.Single>();  return true;
                case "maximumDeltaTime": global::UnityEngine.Time.maximumDeltaTime = _value.Read<global::System.Single>();  return true;
                case "maximumParticleDeltaTime": global::UnityEngine.Time.maximumParticleDeltaTime = _value.Read<global::System.Single>();  return true;
                case "timeScale": global::UnityEngine.Time.timeScale = _value.Read<global::System.Single>();  return true;
                default: return false;
            }
        }
    }
}
#pragma warning restore 0109, 0162, 0168, 0219
#endif
