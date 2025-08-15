
// --------------------------------------------------------------
// GENERATED FILE ----> DO NOT EDIT <---- CHANGES WILL BE LOST !!
// --------------------------------------------------------------

#if UNITY_6000_1_OR_NEWER && !(UNITY_6000_2_OR_NEWER)
#pragma warning disable 0109, 0162, 0168, 0219
using Luny;

namespace Luny.UnityEditor
{
    public sealed class LuaAnimationClipSettings : global::Luny.ILuaObject<global::UnityEditor.AnimationClipSettings>
    {
        public new static global::Lua.LuaValue Bind(global::UnityEditor.AnimationClipSettings instance) => new LuaAnimationClipSettings(instance);
        public new static global::Lua.LuaValue Bind(global::System.Object instance) => Bind((global::UnityEditor.AnimationClipSettings)instance);
        public new static global::Lua.LuaValue Bind(global::System.Collections.Generic.IList<global::UnityEditor.AnimationClipSettings> instances) =>
            new global::Luny.LuaList<global::UnityEditor.AnimationClipSettings>(instances);
        public new static global::Lua.LuaValue Bind(global::System.Collections.Generic.IList<global::System.Object> instances) =>
            new global::Luny.LuaList<global::UnityEditor.AnimationClipSettings>(instances);
        private LuaAnimationClipSettings(global::UnityEditor.AnimationClipSettings instance) => m_Instance = instance;
        public static implicit operator global::Lua.LuaValue(LuaAnimationClipSettings value) => new(value);
        private global::UnityEditor.AnimationClipSettings m_Instance;
        public global::UnityEditor.AnimationClipSettings Instance => m_Instance;
        public new global::System.Type BindType => typeof(global::UnityEditor.AnimationClipSettings);
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

        private static readonly global::Lua.LuaFunction __index = new(global::Lua.Runtime.Metamethods.Index, (_context, _) =>
        {
            var _this = _context.GetArgument<LuaAnimationClipSettings>(0);
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
            var _this = _context.GetArgument<LuaAnimationClipSettings>(0);
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
                case "additiveReferencePoseClip": _value = _factory.Bind(Instance.additiveReferencePoseClip); return true;
                case "additiveReferencePoseTime": _value = new global::Lua.LuaValue(Instance.additiveReferencePoseTime); return true;
                case "cycleOffset": _value = new global::Lua.LuaValue(Instance.cycleOffset); return true;
                case "hasAdditiveReferencePose": _value = new global::Lua.LuaValue(Instance.hasAdditiveReferencePose); return true;
                case "heightFromFeet": _value = new global::Lua.LuaValue(Instance.heightFromFeet); return true;
                case "keepOriginalOrientation": _value = new global::Lua.LuaValue(Instance.keepOriginalOrientation); return true;
                case "keepOriginalPositionXZ": _value = new global::Lua.LuaValue(Instance.keepOriginalPositionXZ); return true;
                case "keepOriginalPositionY": _value = new global::Lua.LuaValue(Instance.keepOriginalPositionY); return true;
                case "level": _value = new global::Lua.LuaValue(Instance.level); return true;
                case "loopBlend": _value = new global::Lua.LuaValue(Instance.loopBlend); return true;
                case "loopBlendOrientation": _value = new global::Lua.LuaValue(Instance.loopBlendOrientation); return true;
                case "loopBlendPositionXZ": _value = new global::Lua.LuaValue(Instance.loopBlendPositionXZ); return true;
                case "loopBlendPositionY": _value = new global::Lua.LuaValue(Instance.loopBlendPositionY); return true;
                case "loopTime": _value = new global::Lua.LuaValue(Instance.loopTime); return true;
                case "mirror": _value = new global::Lua.LuaValue(Instance.mirror); return true;
                case "orientationOffsetY": _value = new global::Lua.LuaValue(Instance.orientationOffsetY); return true;
                case "startTime": _value = new global::Lua.LuaValue(Instance.startTime); return true;
                case "stopTime": _value = new global::Lua.LuaValue(Instance.stopTime); return true;
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
                case "additiveReferencePoseClip": Instance.additiveReferencePoseClip = _value.Read<global::UnityEngine.AnimationClip>();  return true;
                case "additiveReferencePoseTime": Instance.additiveReferencePoseTime = _value.Read<global::System.Single>();  return true;
                case "cycleOffset": Instance.cycleOffset = _value.Read<global::System.Single>();  return true;
                case "hasAdditiveReferencePose": Instance.hasAdditiveReferencePose = _value.Read<global::System.Boolean>();  return true;
                case "heightFromFeet": Instance.heightFromFeet = _value.Read<global::System.Boolean>();  return true;
                case "keepOriginalOrientation": Instance.keepOriginalOrientation = _value.Read<global::System.Boolean>();  return true;
                case "keepOriginalPositionXZ": Instance.keepOriginalPositionXZ = _value.Read<global::System.Boolean>();  return true;
                case "keepOriginalPositionY": Instance.keepOriginalPositionY = _value.Read<global::System.Boolean>();  return true;
                case "level": Instance.level = _value.Read<global::System.Single>();  return true;
                case "loopBlend": Instance.loopBlend = _value.Read<global::System.Boolean>();  return true;
                case "loopBlendOrientation": Instance.loopBlendOrientation = _value.Read<global::System.Boolean>();  return true;
                case "loopBlendPositionXZ": Instance.loopBlendPositionXZ = _value.Read<global::System.Boolean>();  return true;
                case "loopBlendPositionY": Instance.loopBlendPositionY = _value.Read<global::System.Boolean>();  return true;
                case "loopTime": Instance.loopTime = _value.Read<global::System.Boolean>();  return true;
                case "mirror": Instance.mirror = _value.Read<global::System.Boolean>();  return true;
                case "orientationOffsetY": Instance.orientationOffsetY = _value.Read<global::System.Single>();  return true;
                case "startTime": Instance.startTime = _value.Read<global::System.Single>();  return true;
                case "stopTime": Instance.stopTime = _value.Read<global::System.Single>();  return true;
                default: return false;
            }
        }
    }
    public sealed class LuaAnimationClipSettingsType : global::Luny.ILuaStatic
    {
        public static global::Lua.LuaValue Bind() => new LuaAnimationClipSettingsType();
        private LuaAnimationClipSettingsType() {}
        public static implicit operator global::Lua.LuaValue(LuaAnimationClipSettingsType value) => new(value);
        public global::System.Type BindType => typeof(global::UnityEditor.AnimationClipSettings);
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
            metatable[global::Lua.Runtime.Metamethods.Call] = _LuaAnimationClipSettings_new;
            return metatable;
        }
        public override global::System.String ToString() => BindType.FullName;
#if UNITY_EDITOR
        [global::UnityEngine.RuntimeInitializeOnLoadMethod(global::UnityEngine.RuntimeInitializeLoadType.SubsystemRegistration)]
        private static void ResetStaticFields() => s_Metatable = null;
#endif

        private static readonly global::Lua.LuaFunction _LuaAnimationClipSettings_new = new global::Lua.LuaFunction(".ctor", (_context, _) =>
        {
            global::Lua.LuaValue _lastArg = default;
            global::System.Int32 _lastArgPos = default;
            global::System.Type _expectedType = default;
            var _argCount = _context.ArgumentCount;
            if (_argCount == 1)
            {
                var _ret0 = new global::UnityEditor.AnimationClipSettings();
                var _factory = _context.GetObjectFactory();
                var _lret0 = _factory.Bind(_ret0);
                var _retCount = _context.Return(_lret0);
                return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
            }
            throw new global::Lua.LuaRuntimeException(_context.Thread, $"{".ctor"}: invalid argument #{_lastArgPos}: {_lastArg} ({_lastArg.Type}), expected: {_expectedType.FullName}", 2);
        });
        private static readonly global::Lua.LuaFunction __index = new(global::Lua.Runtime.Metamethods.Index, (_context, _) =>
        {
            var _this = _context.GetArgument<LuaAnimationClipSettingsType>(0);
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
            var _this = _context.GetArgument<LuaAnimationClipSettingsType>(0);
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
