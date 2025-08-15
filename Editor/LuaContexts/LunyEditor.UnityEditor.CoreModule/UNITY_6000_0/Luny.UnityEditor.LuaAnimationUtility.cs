
// --------------------------------------------------------------
// GENERATED FILE ----> DO NOT EDIT <---- CHANGES WILL BE LOST !!
// --------------------------------------------------------------

#if UNITY_6000_0_OR_NEWER && !(UNITY_6000_1_OR_NEWER)
#pragma warning disable 0109, 0162, 0168, 0219
using Luny;

namespace Luny.UnityEditor
{
    public class LuaAnimationUtility : global::Luny.ILuaObject<global::UnityEditor.AnimationUtility>
    {
        public new static global::Lua.LuaValue Bind(global::UnityEditor.AnimationUtility instance) => new LuaAnimationUtility(instance);
        public new static global::Lua.LuaValue Bind(global::System.Object instance) => Bind((global::UnityEditor.AnimationUtility)instance);
        public new static global::Lua.LuaValue Bind(global::System.Collections.Generic.IList<global::UnityEditor.AnimationUtility> instances) =>
            new global::Luny.LuaList<global::UnityEditor.AnimationUtility>(instances);
        public new static global::Lua.LuaValue Bind(global::System.Collections.Generic.IList<global::System.Object> instances) =>
            new global::Luny.LuaList<global::UnityEditor.AnimationUtility>(instances);
        protected LuaAnimationUtility(global::UnityEditor.AnimationUtility instance) => m_Instance = instance;
        public static implicit operator global::Lua.LuaValue(LuaAnimationUtility value) => new(value);
        protected global::UnityEditor.AnimationUtility m_Instance;
        public global::UnityEditor.AnimationUtility Instance => m_Instance;
        public new global::System.Type BindType => typeof(global::UnityEditor.AnimationUtility);
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
            var _this = _context.GetArgument<LuaAnimationUtility>(0);
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
            var _this = _context.GetArgument<LuaAnimationUtility>(0);
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
    public sealed class LuaAnimationUtilityType : global::Luny.ILuaStatic
    {
        public static global::Lua.LuaValue Bind() => new LuaAnimationUtilityType();
        private LuaAnimationUtilityType() {}
        public static implicit operator global::Lua.LuaValue(LuaAnimationUtilityType value) => new(value);
        public global::System.Type BindType => typeof(global::UnityEditor.AnimationUtility);
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
            metatable[global::Lua.Runtime.Metamethods.Call] = _LuaAnimationUtility_new;
            return metatable;
        }
        public override global::System.String ToString() => BindType.FullName;
#if UNITY_EDITOR
        [global::UnityEngine.RuntimeInitializeOnLoadMethod(global::UnityEngine.RuntimeInitializeLoadType.SubsystemRegistration)]
        private static void ResetStaticFields() => s_Metatable = null;
#endif

        private static readonly global::Lua.LuaFunction _LuaAnimationUtility_new = new global::Lua.LuaFunction(".ctor", (_context, _) =>
        {
            global::Lua.LuaValue _lastArg = default;
            global::System.Int32 _lastArgPos = default;
            global::System.Type _expectedType = default;
            var _argCount = _context.ArgumentCount;
            if (_argCount == 1)
            {
                var _ret0 = new global::UnityEditor.AnimationUtility();
                var _factory = _context.GetObjectFactory();
                var _lret0 = _factory.Bind(_ret0);
                var _retCount = _context.Return(_lret0);
                return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
            }
            throw new global::Lua.LuaRuntimeException(_context.Thread, $"{".ctor"}: invalid argument #{_lastArgPos}: {_lastArg} ({_lastArg.Type}), expected: {_expectedType.FullName}", 2);
        });
        private static readonly global::Lua.LuaFunction _LuaAnimationUtility_CalculateTransformPath = new global::Lua.LuaFunction("CalculateTransformPath", (_context, _) =>
        {
            global::Lua.LuaValue _lastArg = default;
            global::System.Int32 _lastArgPos = default;
            global::System.Type _expectedType = default;
            var _argCount = _context.ArgumentCount;
            var _arg0 = _lastArg = _argCount > 0 ? _context.GetArgument(0) : global::Lua.LuaValue.Nil;
            _lastArgPos = 0; _expectedType = typeof(global::Luny.UnityEngine.LuaTransform);
            if (_arg0.TryRead<global::Luny.UnityEngine.LuaTransform>(out var _p0_UnityEngine_Transform))
            {
                var _arg1 = _lastArg = _argCount > 1 ? _context.GetArgument(1) : global::Lua.LuaValue.Nil;
                _lastArgPos = 1; _expectedType = typeof(global::Luny.UnityEngine.LuaTransform);
                if (_arg1.TryRead<global::Luny.UnityEngine.LuaTransform>(out var _p1_UnityEngine_Transform))
                {
                    if (_argCount == 2)
                    {
                        var targetTransform = _p0_UnityEngine_Transform.Instance;
                        var root = _p1_UnityEngine_Transform.Instance;
                        var _ret0 = global::UnityEditor.AnimationUtility.CalculateTransformPath(targetTransform, root);
                        var _lret0 = new global::Lua.LuaValue(_ret0);
                        var _retCount = _context.Return(_lret0);
                        return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                    }
                }
            }
            throw new global::Lua.LuaRuntimeException(_context.Thread, $"{"CalculateTransformPath"}: invalid argument #{_lastArgPos}: {_lastArg} ({_lastArg.Type}), expected: {_expectedType.FullName}", 2);
        });
        private static readonly global::Lua.LuaFunction _LuaAnimationUtility_ConstrainToPolynomialCurve = new global::Lua.LuaFunction("ConstrainToPolynomialCurve", (_context, _) =>
        {
            global::Lua.LuaValue _lastArg = default;
            global::System.Int32 _lastArgPos = default;
            global::System.Type _expectedType = default;
            var _argCount = _context.ArgumentCount;
            var _arg0 = _lastArg = _argCount > 0 ? _context.GetArgument(0) : global::Lua.LuaValue.Nil;
            _lastArgPos = 0; _expectedType = typeof(global::Luny.UnityEngine.LuaAnimationCurve);
            if (_arg0.TryRead<global::Luny.UnityEngine.LuaAnimationCurve>(out var _p0_UnityEngine_AnimationCurve))
            {
                if (_argCount == 1)
                {
                    var curve = _p0_UnityEngine_AnimationCurve.Instance;
                    global::UnityEditor.AnimationUtility.ConstrainToPolynomialCurve(curve);
                    var _retCount = _context.Return();
                    return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                }
            }
            throw new global::Lua.LuaRuntimeException(_context.Thread, $"{"ConstrainToPolynomialCurve"}: invalid argument #{_lastArgPos}: {_lastArg} ({_lastArg.Type}), expected: {_expectedType.FullName}", 2);
        });
        private static readonly global::Lua.LuaFunction _LuaAnimationUtility_EditorCurveBindingsToGenericBindings = new global::Lua.LuaFunction("EditorCurveBindingsToGenericBindings", (_context, _) =>
        {
            global::Lua.LuaValue _lastArg = default;
            global::System.Int32 _lastArgPos = default;
            global::System.Type _expectedType = default;
            var _argCount = _context.ArgumentCount;
            var _arg0 = _lastArg = _argCount > 0 ? _context.GetArgument(0) : global::Lua.LuaValue.Nil;
            _lastArgPos = 0; _expectedType = typeof(global::UnityEditor.EditorCurveBinding[]);
            if (_arg0.TryReadArray<global::UnityEditor.EditorCurveBinding>(out var _p0_UnityEditor_EditorCurveBindingArray))
            {
                if (_argCount == 1)
                {
                    var editorCurveBindings = _p0_UnityEditor_EditorCurveBindingArray;
                    var _ret0 = global::UnityEditor.AnimationUtility.EditorCurveBindingsToGenericBindings(editorCurveBindings);
                    var _factory = _context.GetObjectFactory();
                    var _lret0 = _factory.Bind(_ret0);
                    var _retCount = _context.Return(_lret0);
                    return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                }
            }
            throw new global::Lua.LuaRuntimeException(_context.Thread, $"{"EditorCurveBindingsToGenericBindings"}: invalid argument #{_lastArgPos}: {_lastArg} ({_lastArg.Type}), expected: {_expectedType.FullName}", 2);
        });
        private static readonly global::Lua.LuaFunction _LuaAnimationUtility_GetAnimatableBindings = new global::Lua.LuaFunction("GetAnimatableBindings", (_context, _) =>
        {
            global::Lua.LuaValue _lastArg = default;
            global::System.Int32 _lastArgPos = default;
            global::System.Type _expectedType = default;
            var _argCount = _context.ArgumentCount;
            var _arg0 = _lastArg = _argCount > 0 ? _context.GetArgument(0) : global::Lua.LuaValue.Nil;
            _lastArgPos = 0; _expectedType = typeof(global::Luny.UnityEngine.LuaGameObject);
            if (_arg0.TryRead<global::Luny.UnityEngine.LuaGameObject>(out var _p0_UnityEngine_GameObject))
            {
                var _arg1 = _lastArg = _argCount > 1 ? _context.GetArgument(1) : global::Lua.LuaValue.Nil;
                _lastArgPos = 1; _expectedType = typeof(global::Luny.UnityEngine.LuaGameObject);
                if (_arg1.TryRead<global::Luny.UnityEngine.LuaGameObject>(out var _p1_UnityEngine_GameObject))
                {
                    if (_argCount == 2)
                    {
                        var targetObject = _p0_UnityEngine_GameObject.Instance;
                        var root = _p1_UnityEngine_GameObject.Instance;
                        var _ret0 = global::UnityEditor.AnimationUtility.GetAnimatableBindings(targetObject, root);
                        var _factory = _context.GetObjectFactory();
                        var _lret0 = _factory.Bind(_ret0);
                        var _retCount = _context.Return(_lret0);
                        return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                    }
                }
            }
            throw new global::Lua.LuaRuntimeException(_context.Thread, $"{"GetAnimatableBindings"}: invalid argument #{_lastArgPos}: {_lastArg} ({_lastArg.Type}), expected: {_expectedType.FullName}", 2);
        });
        private static readonly global::Lua.LuaFunction _LuaAnimationUtility_GetAnimatedObject = new global::Lua.LuaFunction("GetAnimatedObject", (_context, _) =>
        {
            global::Lua.LuaValue _lastArg = default;
            global::System.Int32 _lastArgPos = default;
            global::System.Type _expectedType = default;
            var _argCount = _context.ArgumentCount;
            var _arg0 = _lastArg = _argCount > 0 ? _context.GetArgument(0) : global::Lua.LuaValue.Nil;
            _lastArgPos = 0; _expectedType = typeof(global::Luny.UnityEngine.LuaGameObject);
            if (_arg0.TryRead<global::Luny.UnityEngine.LuaGameObject>(out var _p0_UnityEngine_GameObject))
            {
                var _arg1 = _lastArg = _argCount > 1 ? _context.GetArgument(1) : global::Lua.LuaValue.Nil;
                _lastArgPos = 1; _expectedType = typeof(global::Luny.UnityEditor.LuaEditorCurveBinding);
                if (_arg1.TryRead<global::Luny.UnityEditor.LuaEditorCurveBinding>(out var _p1_UnityEditor_EditorCurveBinding))
                {
                    if (_argCount == 2)
                    {
                        var root = _p0_UnityEngine_GameObject.Instance;
                        var binding = _p1_UnityEditor_EditorCurveBinding.Value;
                        var _ret0 = global::UnityEditor.AnimationUtility.GetAnimatedObject(root, binding);
                        var _factory = _context.GetObjectFactory();
                        var _lret0 = _factory.Bind(_ret0);
                        var _retCount = _context.Return(_lret0);
                        return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                    }
                }
            }
            throw new global::Lua.LuaRuntimeException(_context.Thread, $"{"GetAnimatedObject"}: invalid argument #{_lastArgPos}: {_lastArg} ({_lastArg.Type}), expected: {_expectedType.FullName}", 2);
        });
        private static readonly global::Lua.LuaFunction _LuaAnimationUtility_GetAnimationClips = new global::Lua.LuaFunction("GetAnimationClips", (_context, _) =>
        {
            global::Lua.LuaValue _lastArg = default;
            global::System.Int32 _lastArgPos = default;
            global::System.Type _expectedType = default;
            var _argCount = _context.ArgumentCount;
            var _arg0 = _lastArg = _argCount > 0 ? _context.GetArgument(0) : global::Lua.LuaValue.Nil;
            _lastArgPos = 0; _expectedType = typeof(global::Luny.UnityEngine.LuaGameObject);
            if (_arg0.TryRead<global::Luny.UnityEngine.LuaGameObject>(out var _p0_UnityEngine_GameObject))
            {
                if (_argCount == 1)
                {
                    var gameObject = _p0_UnityEngine_GameObject.Instance;
                    var _ret0 = global::UnityEditor.AnimationUtility.GetAnimationClips(gameObject);
                    var _factory = _context.GetObjectFactory();
                    var _lret0 = _factory.Bind(_ret0);
                    var _retCount = _context.Return(_lret0);
                    return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                }
            }
            throw new global::Lua.LuaRuntimeException(_context.Thread, $"{"GetAnimationClips"}: invalid argument #{_lastArgPos}: {_lastArg} ({_lastArg.Type}), expected: {_expectedType.FullName}", 2);
        });
        private static readonly global::Lua.LuaFunction _LuaAnimationUtility_GetAnimationClipSettings = new global::Lua.LuaFunction("GetAnimationClipSettings", (_context, _) =>
        {
            global::Lua.LuaValue _lastArg = default;
            global::System.Int32 _lastArgPos = default;
            global::System.Type _expectedType = default;
            var _argCount = _context.ArgumentCount;
            var _arg0 = _lastArg = _argCount > 0 ? _context.GetArgument(0) : global::Lua.LuaValue.Nil;
            _lastArgPos = 0; _expectedType = typeof(global::UnityEngine.AnimationClip);
            if (_arg0.TryRead<global::UnityEngine.AnimationClip>(out var _p0_UnityEngine_AnimationClip))
            {
                if (_argCount == 1)
                {
                    var clip = _p0_UnityEngine_AnimationClip;
                    var _ret0 = global::UnityEditor.AnimationUtility.GetAnimationClipSettings(clip);
                    var _factory = _context.GetObjectFactory();
                    var _lret0 = _factory.Bind(_ret0);
                    var _retCount = _context.Return(_lret0);
                    return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                }
            }
            throw new global::Lua.LuaRuntimeException(_context.Thread, $"{"GetAnimationClipSettings"}: invalid argument #{_lastArgPos}: {_lastArg} ({_lastArg.Type}), expected: {_expectedType.FullName}", 2);
        });
        private static readonly global::Lua.LuaFunction _LuaAnimationUtility_GetAnimationEvents = new global::Lua.LuaFunction("GetAnimationEvents", (_context, _) =>
        {
            global::Lua.LuaValue _lastArg = default;
            global::System.Int32 _lastArgPos = default;
            global::System.Type _expectedType = default;
            var _argCount = _context.ArgumentCount;
            var _arg0 = _lastArg = _argCount > 0 ? _context.GetArgument(0) : global::Lua.LuaValue.Nil;
            _lastArgPos = 0; _expectedType = typeof(global::UnityEngine.AnimationClip);
            if (_arg0.TryRead<global::UnityEngine.AnimationClip>(out var _p0_UnityEngine_AnimationClip))
            {
                if (_argCount == 1)
                {
                    var clip = _p0_UnityEngine_AnimationClip;
                    var _ret0 = global::UnityEditor.AnimationUtility.GetAnimationEvents(clip);
                    var _factory = _context.GetObjectFactory();
                    var _lret0 = _factory.Bind(_ret0);
                    var _retCount = _context.Return(_lret0);
                    return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                }
            }
            throw new global::Lua.LuaRuntimeException(_context.Thread, $"{"GetAnimationEvents"}: invalid argument #{_lastArgPos}: {_lastArg} ({_lastArg.Type}), expected: {_expectedType.FullName}", 2);
        });
        private static readonly global::Lua.LuaFunction _LuaAnimationUtility_GetCurveBindings = new global::Lua.LuaFunction("GetCurveBindings", (_context, _) =>
        {
            global::Lua.LuaValue _lastArg = default;
            global::System.Int32 _lastArgPos = default;
            global::System.Type _expectedType = default;
            var _argCount = _context.ArgumentCount;
            var _arg0 = _lastArg = _argCount > 0 ? _context.GetArgument(0) : global::Lua.LuaValue.Nil;
            _lastArgPos = 0; _expectedType = typeof(global::UnityEngine.AnimationClip);
            if (_arg0.TryRead<global::UnityEngine.AnimationClip>(out var _p0_UnityEngine_AnimationClip))
            {
                if (_argCount == 1)
                {
                    var clip = _p0_UnityEngine_AnimationClip;
                    var _ret0 = global::UnityEditor.AnimationUtility.GetCurveBindings(clip);
                    var _factory = _context.GetObjectFactory();
                    var _lret0 = _factory.Bind(_ret0);
                    var _retCount = _context.Return(_lret0);
                    return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                }
            }
            throw new global::Lua.LuaRuntimeException(_context.Thread, $"{"GetCurveBindings"}: invalid argument #{_lastArgPos}: {_lastArg} ({_lastArg.Type}), expected: {_expectedType.FullName}", 2);
        });
        private static readonly global::Lua.LuaFunction _LuaAnimationUtility_GetEditorCurve = new global::Lua.LuaFunction("GetEditorCurve", (_context, _) =>
        {
            global::Lua.LuaValue _lastArg = default;
            global::System.Int32 _lastArgPos = default;
            global::System.Type _expectedType = default;
            var _argCount = _context.ArgumentCount;
            var _arg0 = _lastArg = _argCount > 0 ? _context.GetArgument(0) : global::Lua.LuaValue.Nil;
            _lastArgPos = 0; _expectedType = typeof(global::UnityEngine.AnimationClip);
            if (_arg0.TryRead<global::UnityEngine.AnimationClip>(out var _p0_UnityEngine_AnimationClip))
            {
                var _arg1 = _lastArg = _argCount > 1 ? _context.GetArgument(1) : global::Lua.LuaValue.Nil;
                _lastArgPos = 1; _expectedType = typeof(global::Luny.UnityEditor.LuaEditorCurveBinding);
                if (_arg1.TryRead<global::Luny.UnityEditor.LuaEditorCurveBinding>(out var _p1_UnityEditor_EditorCurveBinding))
                {
                    if (_argCount == 2)
                    {
                        var clip = _p0_UnityEngine_AnimationClip;
                        var binding = _p1_UnityEditor_EditorCurveBinding.Value;
                        var _ret0 = global::UnityEditor.AnimationUtility.GetEditorCurve(clip, binding);
                        var _factory = _context.GetObjectFactory();
                        var _lret0 = _factory.Bind(_ret0);
                        var _retCount = _context.Return(_lret0);
                        return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                    }
                }
            }
            throw new global::Lua.LuaRuntimeException(_context.Thread, $"{"GetEditorCurve"}: invalid argument #{_lastArgPos}: {_lastArg} ({_lastArg.Type}), expected: {_expectedType.FullName}", 2);
        });
        private static readonly global::Lua.LuaFunction _LuaAnimationUtility_GetEditorCurveValueType = new global::Lua.LuaFunction("GetEditorCurveValueType", (_context, _) =>
        {
            global::Lua.LuaValue _lastArg = default;
            global::System.Int32 _lastArgPos = default;
            global::System.Type _expectedType = default;
            var _argCount = _context.ArgumentCount;
            var _arg0 = _lastArg = _argCount > 0 ? _context.GetArgument(0) : global::Lua.LuaValue.Nil;
            _lastArgPos = 0; _expectedType = typeof(global::Luny.UnityEngine.LuaGameObject);
            if (_arg0.TryRead<global::Luny.UnityEngine.LuaGameObject>(out var _p0_UnityEngine_GameObject))
            {
                var _arg1 = _lastArg = _argCount > 1 ? _context.GetArgument(1) : global::Lua.LuaValue.Nil;
                _lastArgPos = 1; _expectedType = typeof(global::Luny.UnityEditor.LuaEditorCurveBinding);
                if (_arg1.TryRead<global::Luny.UnityEditor.LuaEditorCurveBinding>(out var _p1_UnityEditor_EditorCurveBinding))
                {
                    if (_argCount == 2)
                    {
                        var root = _p0_UnityEngine_GameObject.Instance;
                        var binding = _p1_UnityEditor_EditorCurveBinding.Value;
                        var _ret0 = global::UnityEditor.AnimationUtility.GetEditorCurveValueType(root, binding);
                        var _factory = _context.GetObjectFactory();
                        var _lret0 = _factory.Bind(_ret0);
                        var _retCount = _context.Return(_lret0);
                        return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                    }
                }
            }
            throw new global::Lua.LuaRuntimeException(_context.Thread, $"{"GetEditorCurveValueType"}: invalid argument #{_lastArgPos}: {_lastArg} ({_lastArg.Type}), expected: {_expectedType.FullName}", 2);
        });
        private static readonly global::Lua.LuaFunction _LuaAnimationUtility_GetKeyBroken = new global::Lua.LuaFunction("GetKeyBroken", (_context, _) =>
        {
            global::Lua.LuaValue _lastArg = default;
            global::System.Int32 _lastArgPos = default;
            global::System.Type _expectedType = default;
            var _argCount = _context.ArgumentCount;
            var _arg0 = _lastArg = _argCount > 0 ? _context.GetArgument(0) : global::Lua.LuaValue.Nil;
            _lastArgPos = 0; _expectedType = typeof(global::Luny.UnityEngine.LuaAnimationCurve);
            if (_arg0.TryRead<global::Luny.UnityEngine.LuaAnimationCurve>(out var _p0_UnityEngine_AnimationCurve))
            {
                var _arg1 = _lastArg = _argCount > 1 ? _context.GetArgument(1) : global::Lua.LuaValue.Nil;
                _lastArgPos = 1; _expectedType = typeof(global::System.Int32);
                if (_arg1.TryRead<global::System.Int32>(out var _p1_System_Int32))
                {
                    if (_argCount == 2)
                    {
                        var curve = _p0_UnityEngine_AnimationCurve.Instance;
                        var index = _p1_System_Int32;
                        var _ret0 = global::UnityEditor.AnimationUtility.GetKeyBroken(curve, index);
                        var _lret0 = new global::Lua.LuaValue(_ret0);
                        var _retCount = _context.Return(_lret0);
                        return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                    }
                }
            }
            throw new global::Lua.LuaRuntimeException(_context.Thread, $"{"GetKeyBroken"}: invalid argument #{_lastArgPos}: {_lastArg} ({_lastArg.Type}), expected: {_expectedType.FullName}", 2);
        });
        private static readonly global::Lua.LuaFunction _LuaAnimationUtility_GetKeyLeftTangentMode = new global::Lua.LuaFunction("GetKeyLeftTangentMode", (_context, _) =>
        {
            global::Lua.LuaValue _lastArg = default;
            global::System.Int32 _lastArgPos = default;
            global::System.Type _expectedType = default;
            var _argCount = _context.ArgumentCount;
            var _arg0 = _lastArg = _argCount > 0 ? _context.GetArgument(0) : global::Lua.LuaValue.Nil;
            _lastArgPos = 0; _expectedType = typeof(global::Luny.UnityEngine.LuaAnimationCurve);
            if (_arg0.TryRead<global::Luny.UnityEngine.LuaAnimationCurve>(out var _p0_UnityEngine_AnimationCurve))
            {
                var _arg1 = _lastArg = _argCount > 1 ? _context.GetArgument(1) : global::Lua.LuaValue.Nil;
                _lastArgPos = 1; _expectedType = typeof(global::System.Int32);
                if (_arg1.TryRead<global::System.Int32>(out var _p1_System_Int32))
                {
                    if (_argCount == 2)
                    {
                        var curve = _p0_UnityEngine_AnimationCurve.Instance;
                        var index = _p1_System_Int32;
                        var _ret0 = global::UnityEditor.AnimationUtility.GetKeyLeftTangentMode(curve, index);
                        var _lret0 = new global::Lua.LuaValue((global::System.Int64)_ret0);
                        var _retCount = _context.Return(_lret0);
                        return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                    }
                }
            }
            throw new global::Lua.LuaRuntimeException(_context.Thread, $"{"GetKeyLeftTangentMode"}: invalid argument #{_lastArgPos}: {_lastArg} ({_lastArg.Type}), expected: {_expectedType.FullName}", 2);
        });
        private static readonly global::Lua.LuaFunction _LuaAnimationUtility_GetKeyRightTangentMode = new global::Lua.LuaFunction("GetKeyRightTangentMode", (_context, _) =>
        {
            global::Lua.LuaValue _lastArg = default;
            global::System.Int32 _lastArgPos = default;
            global::System.Type _expectedType = default;
            var _argCount = _context.ArgumentCount;
            var _arg0 = _lastArg = _argCount > 0 ? _context.GetArgument(0) : global::Lua.LuaValue.Nil;
            _lastArgPos = 0; _expectedType = typeof(global::Luny.UnityEngine.LuaAnimationCurve);
            if (_arg0.TryRead<global::Luny.UnityEngine.LuaAnimationCurve>(out var _p0_UnityEngine_AnimationCurve))
            {
                var _arg1 = _lastArg = _argCount > 1 ? _context.GetArgument(1) : global::Lua.LuaValue.Nil;
                _lastArgPos = 1; _expectedType = typeof(global::System.Int32);
                if (_arg1.TryRead<global::System.Int32>(out var _p1_System_Int32))
                {
                    if (_argCount == 2)
                    {
                        var curve = _p0_UnityEngine_AnimationCurve.Instance;
                        var index = _p1_System_Int32;
                        var _ret0 = global::UnityEditor.AnimationUtility.GetKeyRightTangentMode(curve, index);
                        var _lret0 = new global::Lua.LuaValue((global::System.Int64)_ret0);
                        var _retCount = _context.Return(_lret0);
                        return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                    }
                }
            }
            throw new global::Lua.LuaRuntimeException(_context.Thread, $"{"GetKeyRightTangentMode"}: invalid argument #{_lastArgPos}: {_lastArg} ({_lastArg.Type}), expected: {_expectedType.FullName}", 2);
        });
        private static readonly global::Lua.LuaFunction _LuaAnimationUtility_GetObjectReferenceCurve = new global::Lua.LuaFunction("GetObjectReferenceCurve", (_context, _) =>
        {
            global::Lua.LuaValue _lastArg = default;
            global::System.Int32 _lastArgPos = default;
            global::System.Type _expectedType = default;
            var _argCount = _context.ArgumentCount;
            var _arg0 = _lastArg = _argCount > 0 ? _context.GetArgument(0) : global::Lua.LuaValue.Nil;
            _lastArgPos = 0; _expectedType = typeof(global::UnityEngine.AnimationClip);
            if (_arg0.TryRead<global::UnityEngine.AnimationClip>(out var _p0_UnityEngine_AnimationClip))
            {
                var _arg1 = _lastArg = _argCount > 1 ? _context.GetArgument(1) : global::Lua.LuaValue.Nil;
                _lastArgPos = 1; _expectedType = typeof(global::Luny.UnityEditor.LuaEditorCurveBinding);
                if (_arg1.TryRead<global::Luny.UnityEditor.LuaEditorCurveBinding>(out var _p1_UnityEditor_EditorCurveBinding))
                {
                    if (_argCount == 2)
                    {
                        var clip = _p0_UnityEngine_AnimationClip;
                        var binding = _p1_UnityEditor_EditorCurveBinding.Value;
                        var _ret0 = global::UnityEditor.AnimationUtility.GetObjectReferenceCurve(clip, binding);
                        var _factory = _context.GetObjectFactory();
                        var _lret0 = _factory.Bind(_ret0);
                        var _retCount = _context.Return(_lret0);
                        return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                    }
                }
            }
            throw new global::Lua.LuaRuntimeException(_context.Thread, $"{"GetObjectReferenceCurve"}: invalid argument #{_lastArgPos}: {_lastArg} ({_lastArg.Type}), expected: {_expectedType.FullName}", 2);
        });
        private static readonly global::Lua.LuaFunction _LuaAnimationUtility_GetObjectReferenceCurveBindings = new global::Lua.LuaFunction("GetObjectReferenceCurveBindings", (_context, _) =>
        {
            global::Lua.LuaValue _lastArg = default;
            global::System.Int32 _lastArgPos = default;
            global::System.Type _expectedType = default;
            var _argCount = _context.ArgumentCount;
            var _arg0 = _lastArg = _argCount > 0 ? _context.GetArgument(0) : global::Lua.LuaValue.Nil;
            _lastArgPos = 0; _expectedType = typeof(global::UnityEngine.AnimationClip);
            if (_arg0.TryRead<global::UnityEngine.AnimationClip>(out var _p0_UnityEngine_AnimationClip))
            {
                if (_argCount == 1)
                {
                    var clip = _p0_UnityEngine_AnimationClip;
                    var _ret0 = global::UnityEditor.AnimationUtility.GetObjectReferenceCurveBindings(clip);
                    var _factory = _context.GetObjectFactory();
                    var _lret0 = _factory.Bind(_ret0);
                    var _retCount = _context.Return(_lret0);
                    return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                }
            }
            throw new global::Lua.LuaRuntimeException(_context.Thread, $"{"GetObjectReferenceCurveBindings"}: invalid argument #{_lastArgPos}: {_lastArg} ({_lastArg.Type}), expected: {_expectedType.FullName}", 2);
        });
        private static readonly global::Lua.LuaFunction _LuaAnimationUtility_SetAdditiveReferencePose = new global::Lua.LuaFunction("SetAdditiveReferencePose", (_context, _) =>
        {
            global::Lua.LuaValue _lastArg = default;
            global::System.Int32 _lastArgPos = default;
            global::System.Type _expectedType = default;
            var _argCount = _context.ArgumentCount;
            var _arg0 = _lastArg = _argCount > 0 ? _context.GetArgument(0) : global::Lua.LuaValue.Nil;
            _lastArgPos = 0; _expectedType = typeof(global::UnityEngine.AnimationClip);
            if (_arg0.TryRead<global::UnityEngine.AnimationClip>(out var _p0_UnityEngine_AnimationClip))
            {
                var _arg1 = _lastArg = _argCount > 1 ? _context.GetArgument(1) : global::Lua.LuaValue.Nil;
                _lastArgPos = 1; _expectedType = typeof(global::UnityEngine.AnimationClip);
                if (_arg1.TryRead<global::UnityEngine.AnimationClip>(out var _p1_UnityEngine_AnimationClip))
                {
                    var _arg2 = _lastArg = _argCount > 2 ? _context.GetArgument(2) : global::Lua.LuaValue.Nil;
                    _lastArgPos = 2; _expectedType = typeof(global::System.Single);
                    if (_arg2.TryRead<global::System.Single>(out var _p2_System_Single))
                    {
                        if (_argCount == 3)
                        {
                            var clip = _p0_UnityEngine_AnimationClip;
                            var referenceClip = _p1_UnityEngine_AnimationClip;
                            var time = _p2_System_Single;
                            global::UnityEditor.AnimationUtility.SetAdditiveReferencePose(clip, referenceClip, time);
                            var _retCount = _context.Return();
                            return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                        }
                    }
                }
            }
            throw new global::Lua.LuaRuntimeException(_context.Thread, $"{"SetAdditiveReferencePose"}: invalid argument #{_lastArgPos}: {_lastArg} ({_lastArg.Type}), expected: {_expectedType.FullName}", 2);
        });
        private static readonly global::Lua.LuaFunction _LuaAnimationUtility_SetAnimationClips = new global::Lua.LuaFunction("SetAnimationClips", (_context, _) =>
        {
            global::Lua.LuaValue _lastArg = default;
            global::System.Int32 _lastArgPos = default;
            global::System.Type _expectedType = default;
            var _argCount = _context.ArgumentCount;
            var _arg0 = _lastArg = _argCount > 0 ? _context.GetArgument(0) : global::Lua.LuaValue.Nil;
            _lastArgPos = 0; _expectedType = typeof(global::UnityEngine.Animation);
            if (_arg0.TryRead<global::UnityEngine.Animation>(out var _p0_UnityEngine_Animation))
            {
                var _arg1 = _lastArg = _argCount > 1 ? _context.GetArgument(1) : global::Lua.LuaValue.Nil;
                _lastArgPos = 1; _expectedType = typeof(global::UnityEngine.AnimationClip[]);
                if (_arg1.TryReadArray<global::UnityEngine.AnimationClip>(out var _p1_UnityEngine_AnimationClipArray))
                {
                    if (_argCount == 2)
                    {
                        var animation = _p0_UnityEngine_Animation;
                        var clips = _p1_UnityEngine_AnimationClipArray;
                        global::UnityEditor.AnimationUtility.SetAnimationClips(animation, clips);
                        var _retCount = _context.Return();
                        return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                    }
                }
            }
            throw new global::Lua.LuaRuntimeException(_context.Thread, $"{"SetAnimationClips"}: invalid argument #{_lastArgPos}: {_lastArg} ({_lastArg.Type}), expected: {_expectedType.FullName}", 2);
        });
        private static readonly global::Lua.LuaFunction _LuaAnimationUtility_SetAnimationClipSettings = new global::Lua.LuaFunction("SetAnimationClipSettings", (_context, _) =>
        {
            global::Lua.LuaValue _lastArg = default;
            global::System.Int32 _lastArgPos = default;
            global::System.Type _expectedType = default;
            var _argCount = _context.ArgumentCount;
            var _arg0 = _lastArg = _argCount > 0 ? _context.GetArgument(0) : global::Lua.LuaValue.Nil;
            _lastArgPos = 0; _expectedType = typeof(global::UnityEngine.AnimationClip);
            if (_arg0.TryRead<global::UnityEngine.AnimationClip>(out var _p0_UnityEngine_AnimationClip))
            {
                var _arg1 = _lastArg = _argCount > 1 ? _context.GetArgument(1) : global::Lua.LuaValue.Nil;
                _lastArgPos = 1; _expectedType = typeof(global::Luny.UnityEditor.LuaAnimationClipSettings);
                if (_arg1.TryRead<global::Luny.UnityEditor.LuaAnimationClipSettings>(out var _p1_UnityEditor_AnimationClipSettings))
                {
                    if (_argCount == 2)
                    {
                        var clip = _p0_UnityEngine_AnimationClip;
                        var srcClipInfo = _p1_UnityEditor_AnimationClipSettings.Instance;
                        global::UnityEditor.AnimationUtility.SetAnimationClipSettings(clip, srcClipInfo);
                        var _retCount = _context.Return();
                        return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                    }
                }
            }
            throw new global::Lua.LuaRuntimeException(_context.Thread, $"{"SetAnimationClipSettings"}: invalid argument #{_lastArgPos}: {_lastArg} ({_lastArg.Type}), expected: {_expectedType.FullName}", 2);
        });
        private static readonly global::Lua.LuaFunction _LuaAnimationUtility_SetAnimationEvents = new global::Lua.LuaFunction("SetAnimationEvents", (_context, _) =>
        {
            global::Lua.LuaValue _lastArg = default;
            global::System.Int32 _lastArgPos = default;
            global::System.Type _expectedType = default;
            var _argCount = _context.ArgumentCount;
            var _arg0 = _lastArg = _argCount > 0 ? _context.GetArgument(0) : global::Lua.LuaValue.Nil;
            _lastArgPos = 0; _expectedType = typeof(global::UnityEngine.AnimationClip);
            if (_arg0.TryRead<global::UnityEngine.AnimationClip>(out var _p0_UnityEngine_AnimationClip))
            {
                var _arg1 = _lastArg = _argCount > 1 ? _context.GetArgument(1) : global::Lua.LuaValue.Nil;
                _lastArgPos = 1; _expectedType = typeof(global::UnityEngine.AnimationEvent[]);
                if (_arg1.TryReadArray<global::UnityEngine.AnimationEvent>(out var _p1_UnityEngine_AnimationEventArray))
                {
                    if (_argCount == 2)
                    {
                        var clip = _p0_UnityEngine_AnimationClip;
                        var events = _p1_UnityEngine_AnimationEventArray;
                        global::UnityEditor.AnimationUtility.SetAnimationEvents(clip, events);
                        var _retCount = _context.Return();
                        return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                    }
                }
            }
            throw new global::Lua.LuaRuntimeException(_context.Thread, $"{"SetAnimationEvents"}: invalid argument #{_lastArgPos}: {_lastArg} ({_lastArg.Type}), expected: {_expectedType.FullName}", 2);
        });
        private static readonly global::Lua.LuaFunction _LuaAnimationUtility_SetEditorCurve = new global::Lua.LuaFunction("SetEditorCurve", (_context, _) =>
        {
            global::Lua.LuaValue _lastArg = default;
            global::System.Int32 _lastArgPos = default;
            global::System.Type _expectedType = default;
            var _argCount = _context.ArgumentCount;
            var _arg0 = _lastArg = _argCount > 0 ? _context.GetArgument(0) : global::Lua.LuaValue.Nil;
            _lastArgPos = 0; _expectedType = typeof(global::UnityEngine.AnimationClip);
            if (_arg0.TryRead<global::UnityEngine.AnimationClip>(out var _p0_UnityEngine_AnimationClip))
            {
                var _arg1 = _lastArg = _argCount > 1 ? _context.GetArgument(1) : global::Lua.LuaValue.Nil;
                _lastArgPos = 1; _expectedType = typeof(global::Luny.UnityEditor.LuaEditorCurveBinding);
                if (_arg1.TryRead<global::Luny.UnityEditor.LuaEditorCurveBinding>(out var _p1_UnityEditor_EditorCurveBinding))
                {
                    var _arg2 = _lastArg = _argCount > 2 ? _context.GetArgument(2) : global::Lua.LuaValue.Nil;
                    _lastArgPos = 2; _expectedType = typeof(global::Luny.UnityEngine.LuaAnimationCurve);
                    if (_arg2.TryRead<global::Luny.UnityEngine.LuaAnimationCurve>(out var _p2_UnityEngine_AnimationCurve))
                    {
                        if (_argCount == 3)
                        {
                            var clip = _p0_UnityEngine_AnimationClip;
                            var binding = _p1_UnityEditor_EditorCurveBinding.Value;
                            var curve = _p2_UnityEngine_AnimationCurve.Instance;
                            global::UnityEditor.AnimationUtility.SetEditorCurve(clip, binding, curve);
                            var _retCount = _context.Return();
                            return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                        }
                    }
                }
            }
            throw new global::Lua.LuaRuntimeException(_context.Thread, $"{"SetEditorCurve"}: invalid argument #{_lastArgPos}: {_lastArg} ({_lastArg.Type}), expected: {_expectedType.FullName}", 2);
        });
        private static readonly global::Lua.LuaFunction _LuaAnimationUtility_SetEditorCurves = new global::Lua.LuaFunction("SetEditorCurves", (_context, _) =>
        {
            global::Lua.LuaValue _lastArg = default;
            global::System.Int32 _lastArgPos = default;
            global::System.Type _expectedType = default;
            var _argCount = _context.ArgumentCount;
            var _arg0 = _lastArg = _argCount > 0 ? _context.GetArgument(0) : global::Lua.LuaValue.Nil;
            _lastArgPos = 0; _expectedType = typeof(global::UnityEngine.AnimationClip);
            if (_arg0.TryRead<global::UnityEngine.AnimationClip>(out var _p0_UnityEngine_AnimationClip))
            {
                var _arg1 = _lastArg = _argCount > 1 ? _context.GetArgument(1) : global::Lua.LuaValue.Nil;
                _lastArgPos = 1; _expectedType = typeof(global::UnityEditor.EditorCurveBinding[]);
                if (_arg1.TryReadArray<global::UnityEditor.EditorCurveBinding>(out var _p1_UnityEditor_EditorCurveBindingArray))
                {
                    var _arg2 = _lastArg = _argCount > 2 ? _context.GetArgument(2) : global::Lua.LuaValue.Nil;
                    _lastArgPos = 2; _expectedType = typeof(global::UnityEngine.AnimationCurve[]);
                    if (_arg2.TryReadArray<global::UnityEngine.AnimationCurve>(out var _p2_UnityEngine_AnimationCurveArray))
                    {
                        if (_argCount == 3)
                        {
                            var clip = _p0_UnityEngine_AnimationClip;
                            var bindings = _p1_UnityEditor_EditorCurveBindingArray;
                            var curves = _p2_UnityEngine_AnimationCurveArray;
                            global::UnityEditor.AnimationUtility.SetEditorCurves(clip, bindings, curves);
                            var _retCount = _context.Return();
                            return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                        }
                    }
                }
            }
            throw new global::Lua.LuaRuntimeException(_context.Thread, $"{"SetEditorCurves"}: invalid argument #{_lastArgPos}: {_lastArg} ({_lastArg.Type}), expected: {_expectedType.FullName}", 2);
        });
        private static readonly global::Lua.LuaFunction _LuaAnimationUtility_SetKeyBroken = new global::Lua.LuaFunction("SetKeyBroken", (_context, _) =>
        {
            global::Lua.LuaValue _lastArg = default;
            global::System.Int32 _lastArgPos = default;
            global::System.Type _expectedType = default;
            var _argCount = _context.ArgumentCount;
            var _arg0 = _lastArg = _argCount > 0 ? _context.GetArgument(0) : global::Lua.LuaValue.Nil;
            _lastArgPos = 0; _expectedType = typeof(global::Luny.UnityEngine.LuaAnimationCurve);
            if (_arg0.TryRead<global::Luny.UnityEngine.LuaAnimationCurve>(out var _p0_UnityEngine_AnimationCurve))
            {
                var _arg1 = _lastArg = _argCount > 1 ? _context.GetArgument(1) : global::Lua.LuaValue.Nil;
                _lastArgPos = 1; _expectedType = typeof(global::System.Int32);
                if (_arg1.TryRead<global::System.Int32>(out var _p1_System_Int32))
                {
                    var _arg2 = _lastArg = _argCount > 2 ? _context.GetArgument(2) : global::Lua.LuaValue.Nil;
                    _lastArgPos = 2; _expectedType = typeof(global::System.Boolean);
                    if (_arg2.TryRead<global::System.Boolean>(out var _p2_System_Boolean))
                    {
                        if (_argCount == 3)
                        {
                            var curve = _p0_UnityEngine_AnimationCurve.Instance;
                            var index = _p1_System_Int32;
                            var broken = _p2_System_Boolean;
                            global::UnityEditor.AnimationUtility.SetKeyBroken(curve, index, broken);
                            var _retCount = _context.Return();
                            return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                        }
                    }
                }
            }
            throw new global::Lua.LuaRuntimeException(_context.Thread, $"{"SetKeyBroken"}: invalid argument #{_lastArgPos}: {_lastArg} ({_lastArg.Type}), expected: {_expectedType.FullName}", 2);
        });
        private static readonly global::Lua.LuaFunction _LuaAnimationUtility_SetKeyLeftTangentMode = new global::Lua.LuaFunction("SetKeyLeftTangentMode", (_context, _) =>
        {
            global::Lua.LuaValue _lastArg = default;
            global::System.Int32 _lastArgPos = default;
            global::System.Type _expectedType = default;
            var _argCount = _context.ArgumentCount;
            var _arg0 = _lastArg = _argCount > 0 ? _context.GetArgument(0) : global::Lua.LuaValue.Nil;
            _lastArgPos = 0; _expectedType = typeof(global::Luny.UnityEngine.LuaAnimationCurve);
            if (_arg0.TryRead<global::Luny.UnityEngine.LuaAnimationCurve>(out var _p0_UnityEngine_AnimationCurve))
            {
                var _arg1 = _lastArg = _argCount > 1 ? _context.GetArgument(1) : global::Lua.LuaValue.Nil;
                _lastArgPos = 1; _expectedType = typeof(global::System.Int32);
                if (_arg1.TryRead<global::System.Int32>(out var _p1_System_Int32))
                {
                    var _arg2 = _lastArg = _argCount > 2 ? _context.GetArgument(2) : global::Lua.LuaValue.Nil;
                    _lastArgPos = 2; _expectedType = typeof(global::UnityEditor.AnimationUtility.TangentMode);
                    if (_arg2.TryRead<global::UnityEditor.AnimationUtility.TangentMode>(out var _p2_UnityEditor_AnimationUtility_TangentMode))
                    {
                        if (_argCount == 3)
                        {
                            var curve = _p0_UnityEngine_AnimationCurve.Instance;
                            var index = _p1_System_Int32;
                            var tangentMode = _p2_UnityEditor_AnimationUtility_TangentMode;
                            global::UnityEditor.AnimationUtility.SetKeyLeftTangentMode(curve, index, tangentMode);
                            var _retCount = _context.Return();
                            return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                        }
                    }
                }
            }
            throw new global::Lua.LuaRuntimeException(_context.Thread, $"{"SetKeyLeftTangentMode"}: invalid argument #{_lastArgPos}: {_lastArg} ({_lastArg.Type}), expected: {_expectedType.FullName}", 2);
        });
        private static readonly global::Lua.LuaFunction _LuaAnimationUtility_SetKeyRightTangentMode = new global::Lua.LuaFunction("SetKeyRightTangentMode", (_context, _) =>
        {
            global::Lua.LuaValue _lastArg = default;
            global::System.Int32 _lastArgPos = default;
            global::System.Type _expectedType = default;
            var _argCount = _context.ArgumentCount;
            var _arg0 = _lastArg = _argCount > 0 ? _context.GetArgument(0) : global::Lua.LuaValue.Nil;
            _lastArgPos = 0; _expectedType = typeof(global::Luny.UnityEngine.LuaAnimationCurve);
            if (_arg0.TryRead<global::Luny.UnityEngine.LuaAnimationCurve>(out var _p0_UnityEngine_AnimationCurve))
            {
                var _arg1 = _lastArg = _argCount > 1 ? _context.GetArgument(1) : global::Lua.LuaValue.Nil;
                _lastArgPos = 1; _expectedType = typeof(global::System.Int32);
                if (_arg1.TryRead<global::System.Int32>(out var _p1_System_Int32))
                {
                    var _arg2 = _lastArg = _argCount > 2 ? _context.GetArgument(2) : global::Lua.LuaValue.Nil;
                    _lastArgPos = 2; _expectedType = typeof(global::UnityEditor.AnimationUtility.TangentMode);
                    if (_arg2.TryRead<global::UnityEditor.AnimationUtility.TangentMode>(out var _p2_UnityEditor_AnimationUtility_TangentMode))
                    {
                        if (_argCount == 3)
                        {
                            var curve = _p0_UnityEngine_AnimationCurve.Instance;
                            var index = _p1_System_Int32;
                            var tangentMode = _p2_UnityEditor_AnimationUtility_TangentMode;
                            global::UnityEditor.AnimationUtility.SetKeyRightTangentMode(curve, index, tangentMode);
                            var _retCount = _context.Return();
                            return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                        }
                    }
                }
            }
            throw new global::Lua.LuaRuntimeException(_context.Thread, $"{"SetKeyRightTangentMode"}: invalid argument #{_lastArgPos}: {_lastArg} ({_lastArg.Type}), expected: {_expectedType.FullName}", 2);
        });
        private static readonly global::Lua.LuaFunction _LuaAnimationUtility_SetObjectReferenceCurve = new global::Lua.LuaFunction("SetObjectReferenceCurve", (_context, _) =>
        {
            global::Lua.LuaValue _lastArg = default;
            global::System.Int32 _lastArgPos = default;
            global::System.Type _expectedType = default;
            var _argCount = _context.ArgumentCount;
            var _arg0 = _lastArg = _argCount > 0 ? _context.GetArgument(0) : global::Lua.LuaValue.Nil;
            _lastArgPos = 0; _expectedType = typeof(global::UnityEngine.AnimationClip);
            if (_arg0.TryRead<global::UnityEngine.AnimationClip>(out var _p0_UnityEngine_AnimationClip))
            {
                var _arg1 = _lastArg = _argCount > 1 ? _context.GetArgument(1) : global::Lua.LuaValue.Nil;
                _lastArgPos = 1; _expectedType = typeof(global::Luny.UnityEditor.LuaEditorCurveBinding);
                if (_arg1.TryRead<global::Luny.UnityEditor.LuaEditorCurveBinding>(out var _p1_UnityEditor_EditorCurveBinding))
                {
                    var _arg2 = _lastArg = _argCount > 2 ? _context.GetArgument(2) : global::Lua.LuaValue.Nil;
                    _lastArgPos = 2; _expectedType = typeof(global::UnityEditor.ObjectReferenceKeyframe[]);
                    if (_arg2.TryReadArray<global::UnityEditor.ObjectReferenceKeyframe>(out var _p2_UnityEditor_ObjectReferenceKeyframeArray))
                    {
                        if (_argCount == 3)
                        {
                            var clip = _p0_UnityEngine_AnimationClip;
                            var binding = _p1_UnityEditor_EditorCurveBinding.Value;
                            var keyframes = _p2_UnityEditor_ObjectReferenceKeyframeArray;
                            global::UnityEditor.AnimationUtility.SetObjectReferenceCurve(clip, binding, keyframes);
                            var _retCount = _context.Return();
                            return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                        }
                    }
                }
            }
            throw new global::Lua.LuaRuntimeException(_context.Thread, $"{"SetObjectReferenceCurve"}: invalid argument #{_lastArgPos}: {_lastArg} ({_lastArg.Type}), expected: {_expectedType.FullName}", 2);
        });
        private static readonly global::Lua.LuaFunction _LuaAnimationUtility_SetObjectReferenceCurves = new global::Lua.LuaFunction("SetObjectReferenceCurves", (_context, _) =>
        {
            global::Lua.LuaValue _lastArg = default;
            global::System.Int32 _lastArgPos = default;
            global::System.Type _expectedType = default;
            var _argCount = _context.ArgumentCount;
            var _arg0 = _lastArg = _argCount > 0 ? _context.GetArgument(0) : global::Lua.LuaValue.Nil;
            _lastArgPos = 0; _expectedType = typeof(global::UnityEngine.AnimationClip);
            if (_arg0.TryRead<global::UnityEngine.AnimationClip>(out var _p0_UnityEngine_AnimationClip))
            {
                var _arg1 = _lastArg = _argCount > 1 ? _context.GetArgument(1) : global::Lua.LuaValue.Nil;
                _lastArgPos = 1; _expectedType = typeof(global::UnityEditor.EditorCurveBinding[]);
                if (_arg1.TryReadArray<global::UnityEditor.EditorCurveBinding>(out var _p1_UnityEditor_EditorCurveBindingArray))
                {
                    var _arg2 = _lastArg = _argCount > 2 ? _context.GetArgument(2) : global::Lua.LuaValue.Nil;
                    _lastArgPos = 2; _expectedType = typeof(global::UnityEditor.ObjectReferenceKeyframe[][]);
                    if (_arg2.TryReadArray<global::UnityEditor.ObjectReferenceKeyframe[]>(out var _p2_UnityEditor_ObjectReferenceKeyframeArrayArray))
                    {
                        if (_argCount == 3)
                        {
                            var clip = _p0_UnityEngine_AnimationClip;
                            var bindings = _p1_UnityEditor_EditorCurveBindingArray;
                            var keyframes = _p2_UnityEditor_ObjectReferenceKeyframeArrayArray;
                            global::UnityEditor.AnimationUtility.SetObjectReferenceCurves(clip, bindings, keyframes);
                            var _retCount = _context.Return();
                            return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                        }
                    }
                }
            }
            throw new global::Lua.LuaRuntimeException(_context.Thread, $"{"SetObjectReferenceCurves"}: invalid argument #{_lastArgPos}: {_lastArg} ({_lastArg.Type}), expected: {_expectedType.FullName}", 2);
        });
        private static readonly global::Lua.LuaFunction __index = new(global::Lua.Runtime.Metamethods.Index, (_context, _) =>
        {
            var _this = _context.GetArgument<LuaAnimationUtilityType>(0);
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
            var _this = _context.GetArgument<LuaAnimationUtilityType>(0);
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
                case "CalculateTransformPath": _value = _LuaAnimationUtility_CalculateTransformPath; return true;
                case "ConstrainToPolynomialCurve": _value = _LuaAnimationUtility_ConstrainToPolynomialCurve; return true;
                case "EditorCurveBindingsToGenericBindings": _value = _LuaAnimationUtility_EditorCurveBindingsToGenericBindings; return true;
                case "GetAnimatableBindings": _value = _LuaAnimationUtility_GetAnimatableBindings; return true;
                case "GetAnimatedObject": _value = _LuaAnimationUtility_GetAnimatedObject; return true;
                case "GetAnimationClips": _value = _LuaAnimationUtility_GetAnimationClips; return true;
                case "GetAnimationClipSettings": _value = _LuaAnimationUtility_GetAnimationClipSettings; return true;
                case "GetAnimationEvents": _value = _LuaAnimationUtility_GetAnimationEvents; return true;
                case "GetCurveBindings": _value = _LuaAnimationUtility_GetCurveBindings; return true;
                case "GetEditorCurve": _value = _LuaAnimationUtility_GetEditorCurve; return true;
                case "GetEditorCurveValueType": _value = _LuaAnimationUtility_GetEditorCurveValueType; return true;
                case "GetKeyBroken": _value = _LuaAnimationUtility_GetKeyBroken; return true;
                case "GetKeyLeftTangentMode": _value = _LuaAnimationUtility_GetKeyLeftTangentMode; return true;
                case "GetKeyRightTangentMode": _value = _LuaAnimationUtility_GetKeyRightTangentMode; return true;
                case "GetObjectReferenceCurve": _value = _LuaAnimationUtility_GetObjectReferenceCurve; return true;
                case "GetObjectReferenceCurveBindings": _value = _LuaAnimationUtility_GetObjectReferenceCurveBindings; return true;
                case "SetAdditiveReferencePose": _value = _LuaAnimationUtility_SetAdditiveReferencePose; return true;
                case "SetAnimationClips": _value = _LuaAnimationUtility_SetAnimationClips; return true;
                case "SetAnimationClipSettings": _value = _LuaAnimationUtility_SetAnimationClipSettings; return true;
                case "SetAnimationEvents": _value = _LuaAnimationUtility_SetAnimationEvents; return true;
                case "SetEditorCurve": _value = _LuaAnimationUtility_SetEditorCurve; return true;
                case "SetEditorCurves": _value = _LuaAnimationUtility_SetEditorCurves; return true;
                case "SetKeyBroken": _value = _LuaAnimationUtility_SetKeyBroken; return true;
                case "SetKeyLeftTangentMode": _value = _LuaAnimationUtility_SetKeyLeftTangentMode; return true;
                case "SetKeyRightTangentMode": _value = _LuaAnimationUtility_SetKeyRightTangentMode; return true;
                case "SetObjectReferenceCurve": _value = _LuaAnimationUtility_SetObjectReferenceCurve; return true;
                case "SetObjectReferenceCurves": _value = _LuaAnimationUtility_SetObjectReferenceCurves; return true;
                case "onCurveWasModified": _value = _factory.Bind(global::UnityEditor.AnimationUtility.onCurveWasModified); return true;
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
                case "onCurveWasModified": global::UnityEditor.AnimationUtility.onCurveWasModified = _value.Read<global::UnityEditor.AnimationUtility.OnCurveWasModified>();  return true;
                default: return false;
            }
        }
    }
}
#pragma warning restore 0109, 0162, 0168, 0219
#endif
