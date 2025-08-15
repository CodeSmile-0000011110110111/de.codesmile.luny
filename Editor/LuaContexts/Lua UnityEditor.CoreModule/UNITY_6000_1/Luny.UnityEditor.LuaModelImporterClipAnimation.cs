
// --------------------------------------------------------------
// GENERATED FILE ----> DO NOT EDIT <---- CHANGES WILL BE LOST !!
// --------------------------------------------------------------

#if UNITY_6000_1_OR_NEWER && !(UNITY_6000_2_OR_NEWER)
#pragma warning disable 0109, 0162, 0168, 0219
using Luny;

namespace Luny.UnityEditor
{
    public sealed class LuaModelImporterClipAnimation : global::Luny.ILuaObject<global::UnityEditor.ModelImporterClipAnimation>
    {
        public new static global::Lua.LuaValue Bind(global::UnityEditor.ModelImporterClipAnimation instance) => new LuaModelImporterClipAnimation(instance);
        public new static global::Lua.LuaValue Bind(global::System.Object instance) => Bind((global::UnityEditor.ModelImporterClipAnimation)instance);
        public new static global::Lua.LuaValue Bind(global::System.Collections.Generic.IList<global::UnityEditor.ModelImporterClipAnimation> instances) =>
            new global::Luny.LuaList<global::UnityEditor.ModelImporterClipAnimation>(instances);
        public new static global::Lua.LuaValue Bind(global::System.Collections.Generic.IList<global::System.Object> instances) =>
            new global::Luny.LuaList<global::UnityEditor.ModelImporterClipAnimation>(instances);
        private LuaModelImporterClipAnimation(global::UnityEditor.ModelImporterClipAnimation instance) => m_Instance = instance;
        public static implicit operator global::Lua.LuaValue(LuaModelImporterClipAnimation value) => new(value);
        private global::UnityEditor.ModelImporterClipAnimation m_Instance;
        public global::UnityEditor.ModelImporterClipAnimation Instance => m_Instance;
        public new global::System.Type BindType => typeof(global::UnityEditor.ModelImporterClipAnimation);
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

        private static readonly global::Lua.LuaFunction _LuaModelImporterClipAnimation_ConfigureClipFromMask = new global::Lua.LuaFunction("ConfigureClipFromMask", (_context, _) =>
        {
            global::Lua.LuaValue _lastArg = default;
            global::System.Int32 _lastArgPos = default;
            global::System.Type _expectedType = default;
            var _argCount = _context.ArgumentCount;
            var _this = _context.GetArgument<LuaModelImporterClipAnimation>(0);
            var _arg0 = _lastArg = _argCount > 1 ? _context.GetArgument(1) : global::Lua.LuaValue.Nil;
            _lastArgPos = 0; _expectedType = typeof(global::UnityEngine.AvatarMask);
            if (_arg0.TryRead<global::UnityEngine.AvatarMask>(out var _p0_UnityEngine_AvatarMask))
            {
                if (_argCount == 2)
                {
                    var mask = _p0_UnityEngine_AvatarMask;
                    _this.Instance.ConfigureClipFromMask(mask);
                    var _retCount = _context.Return();
                    return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                }
            }
            throw new global::Lua.LuaRuntimeException(_context.Thread, $"{"ConfigureClipFromMask"}: invalid argument #{_lastArgPos}: {_lastArg} ({_lastArg.Type}), expected: {_expectedType.FullName}", 2);
        });
        private static readonly global::Lua.LuaFunction _LuaModelImporterClipAnimation_Equals = new global::Lua.LuaFunction("Equals", (_context, _) =>
        {
            global::Lua.LuaValue _lastArg = default;
            global::System.Int32 _lastArgPos = default;
            global::System.Type _expectedType = default;
            var _argCount = _context.ArgumentCount;
            var _this = _context.GetArgument<LuaModelImporterClipAnimation>(0);
            var _arg0 = _lastArg = _argCount > 1 ? _context.GetArgument(1) : global::Lua.LuaValue.Nil;
            _lastArgPos = 0; _expectedType = typeof(global::System.Object);
            if (_arg0.TryRead<global::System.Object>(out var _p0_System_Object))
            {
                if (_argCount == 2)
                {
                    var o = _p0_System_Object;
                    var _ret0 = _this.Instance.Equals(o);
                    var _lret0 = new global::Lua.LuaValue(_ret0);
                    var _retCount = _context.Return(_lret0);
                    return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                }
            }
            throw new global::Lua.LuaRuntimeException(_context.Thread, $"{"Equals"}: invalid argument #{_lastArgPos}: {_lastArg} ({_lastArg.Type}), expected: {_expectedType.FullName}", 2);
        });
        private static readonly global::Lua.LuaFunction _LuaModelImporterClipAnimation_GetHashCode = new global::Lua.LuaFunction("GetHashCode", (_context, _) =>
        {
            global::Lua.LuaValue _lastArg = default;
            global::System.Int32 _lastArgPos = default;
            global::System.Type _expectedType = default;
            var _argCount = _context.ArgumentCount;
            var _this = _context.GetArgument<LuaModelImporterClipAnimation>(0);
            if (_argCount == 1)
            {
                var _ret0 = _this.Instance.GetHashCode();
                var _lret0 = new global::Lua.LuaValue(_ret0);
                var _retCount = _context.Return(_lret0);
                return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
            }
            throw new global::Lua.LuaRuntimeException(_context.Thread, $"{"GetHashCode"}: invalid argument #{_lastArgPos}: {_lastArg} ({_lastArg.Type}), expected: {_expectedType.FullName}", 2);
        });
        private static readonly global::Lua.LuaFunction __index = new(global::Lua.Runtime.Metamethods.Index, (_context, _) =>
        {
            var _this = _context.GetArgument<LuaModelImporterClipAnimation>(0);
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
            var _this = _context.GetArgument<LuaModelImporterClipAnimation>(0);
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
                case "ConfigureClipFromMask": _value = _LuaModelImporterClipAnimation_ConfigureClipFromMask; return true;
                case "Equals": _value = _LuaModelImporterClipAnimation_Equals; return true;
                case "GetHashCode": _value = _LuaModelImporterClipAnimation_GetHashCode; return true;
                case "additiveReferencePoseFrame": _value = new global::Lua.LuaValue(Instance.additiveReferencePoseFrame); return true;
                case "curves": _value = _factory.Bind(Instance.curves); return true;
                case "cycleOffset": _value = new global::Lua.LuaValue(Instance.cycleOffset); return true;
                case "events": _value = _factory.Bind(Instance.events); return true;
                case "firstFrame": _value = new global::Lua.LuaValue(Instance.firstFrame); return true;
                case "hasAdditiveReferencePose": _value = new global::Lua.LuaValue(Instance.hasAdditiveReferencePose); return true;
                case "heightFromFeet": _value = new global::Lua.LuaValue(Instance.heightFromFeet); return true;
                case "heightOffset": _value = new global::Lua.LuaValue(Instance.heightOffset); return true;
                case "keepOriginalOrientation": _value = new global::Lua.LuaValue(Instance.keepOriginalOrientation); return true;
                case "keepOriginalPositionXZ": _value = new global::Lua.LuaValue(Instance.keepOriginalPositionXZ); return true;
                case "keepOriginalPositionY": _value = new global::Lua.LuaValue(Instance.keepOriginalPositionY); return true;
                case "lastFrame": _value = new global::Lua.LuaValue(Instance.lastFrame); return true;
                case "lockRootHeightY": _value = new global::Lua.LuaValue(Instance.lockRootHeightY); return true;
                case "lockRootPositionXZ": _value = new global::Lua.LuaValue(Instance.lockRootPositionXZ); return true;
                case "lockRootRotation": _value = new global::Lua.LuaValue(Instance.lockRootRotation); return true;
                case "loop": _value = new global::Lua.LuaValue(Instance.loop); return true;
                case "loopPose": _value = new global::Lua.LuaValue(Instance.loopPose); return true;
                case "loopTime": _value = new global::Lua.LuaValue(Instance.loopTime); return true;
                case "maskNeedsUpdating": _value = new global::Lua.LuaValue(Instance.maskNeedsUpdating); return true;
                case "maskSource": _value = _factory.Bind(Instance.maskSource); return true;
                case "maskType": _value = new global::Lua.LuaValue((global::System.Int64)Instance.maskType); return true;
                case "mirror": _value = new global::Lua.LuaValue(Instance.mirror); return true;
                case "name": _value = new global::Lua.LuaValue(Instance.name); return true;
                case "rotationOffset": _value = new global::Lua.LuaValue(Instance.rotationOffset); return true;
                case "takeName": _value = new global::Lua.LuaValue(Instance.takeName); return true;
                case "wrapMode": _value = new global::Lua.LuaValue((global::System.Int64)Instance.wrapMode); return true;
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
                case "additiveReferencePoseFrame": Instance.additiveReferencePoseFrame = _value.Read<global::System.Single>();  return true;
                case "curves": Instance.curves = _value.Read<global::UnityEditor.ClipAnimationInfoCurve[]>();  return true;
                case "cycleOffset": Instance.cycleOffset = _value.Read<global::System.Single>();  return true;
                case "events": Instance.events = _value.Read<global::UnityEngine.AnimationEvent[]>();  return true;
                case "firstFrame": Instance.firstFrame = _value.Read<global::System.Single>();  return true;
                case "hasAdditiveReferencePose": Instance.hasAdditiveReferencePose = _value.Read<global::System.Boolean>();  return true;
                case "heightFromFeet": Instance.heightFromFeet = _value.Read<global::System.Boolean>();  return true;
                case "heightOffset": Instance.heightOffset = _value.Read<global::System.Single>();  return true;
                case "keepOriginalOrientation": Instance.keepOriginalOrientation = _value.Read<global::System.Boolean>();  return true;
                case "keepOriginalPositionXZ": Instance.keepOriginalPositionXZ = _value.Read<global::System.Boolean>();  return true;
                case "keepOriginalPositionY": Instance.keepOriginalPositionY = _value.Read<global::System.Boolean>();  return true;
                case "lastFrame": Instance.lastFrame = _value.Read<global::System.Single>();  return true;
                case "lockRootHeightY": Instance.lockRootHeightY = _value.Read<global::System.Boolean>();  return true;
                case "lockRootPositionXZ": Instance.lockRootPositionXZ = _value.Read<global::System.Boolean>();  return true;
                case "lockRootRotation": Instance.lockRootRotation = _value.Read<global::System.Boolean>();  return true;
                case "loop": Instance.loop = _value.Read<global::System.Boolean>();  return true;
                case "loopPose": Instance.loopPose = _value.Read<global::System.Boolean>();  return true;
                case "loopTime": Instance.loopTime = _value.Read<global::System.Boolean>();  return true;
                case "maskSource": Instance.maskSource = _value.Read<global::UnityEngine.AvatarMask>();  return true;
                case "maskType": Instance.maskType = _value.Read<global::UnityEditor.ClipAnimationMaskType>();  return true;
                case "mirror": Instance.mirror = _value.Read<global::System.Boolean>();  return true;
                case "name": Instance.name = _value.Read<global::System.String>();  return true;
                case "rotationOffset": Instance.rotationOffset = _value.Read<global::System.Single>();  return true;
                case "takeName": Instance.takeName = _value.Read<global::System.String>();  return true;
                case "wrapMode": Instance.wrapMode = _value.Read<global::UnityEngine.WrapMode>();  return true;
                default: return false;
            }
        }
    }
    public sealed class LuaModelImporterClipAnimationType : global::Luny.ILuaStatic
    {
        public static global::Lua.LuaValue Bind() => new LuaModelImporterClipAnimationType();
        private LuaModelImporterClipAnimationType() {}
        public static implicit operator global::Lua.LuaValue(LuaModelImporterClipAnimationType value) => new(value);
        public global::System.Type BindType => typeof(global::UnityEditor.ModelImporterClipAnimation);
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
            metatable[global::Lua.Runtime.Metamethods.Call] = _LuaModelImporterClipAnimation_new;
            return metatable;
        }
        public override global::System.String ToString() => BindType.FullName;
#if UNITY_EDITOR
        [global::UnityEngine.RuntimeInitializeOnLoadMethod(global::UnityEngine.RuntimeInitializeLoadType.SubsystemRegistration)]
        private static void ResetStaticFields() => s_Metatable = null;
#endif

        private static readonly global::Lua.LuaFunction _LuaModelImporterClipAnimation_new = new global::Lua.LuaFunction(".ctor", (_context, _) =>
        {
            global::Lua.LuaValue _lastArg = default;
            global::System.Int32 _lastArgPos = default;
            global::System.Type _expectedType = default;
            var _argCount = _context.ArgumentCount;
            if (_argCount == 1)
            {
                var _ret0 = new global::UnityEditor.ModelImporterClipAnimation();
                var _factory = _context.GetObjectFactory();
                var _lret0 = _factory.Bind(_ret0);
                var _retCount = _context.Return(_lret0);
                return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
            }
            throw new global::Lua.LuaRuntimeException(_context.Thread, $"{".ctor"}: invalid argument #{_lastArgPos}: {_lastArg} ({_lastArg.Type}), expected: {_expectedType.FullName}", 2);
        });
        private static readonly global::Lua.LuaFunction __index = new(global::Lua.Runtime.Metamethods.Index, (_context, _) =>
        {
            var _this = _context.GetArgument<LuaModelImporterClipAnimationType>(0);
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
            var _this = _context.GetArgument<LuaModelImporterClipAnimationType>(0);
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
