
// --------------------------------------------------------------
// GENERATED FILE ----> DO NOT EDIT <---- CHANGES WILL BE LOST !!
// --------------------------------------------------------------

#if UNITY_6000_1_OR_NEWER && !(UNITY_6000_2_OR_NEWER)
#pragma warning disable 0109, 0162, 0168, 0219
using Luny;

namespace Luny.UnityEditor.Animations
{
    public sealed class LuaAnimatorStateMachine : global::Luny.ILuaObject<global::UnityEditor.Animations.AnimatorStateMachine>
    {
        public new static global::Lua.LuaValue Bind(global::UnityEditor.Animations.AnimatorStateMachine instance) => new LuaAnimatorStateMachine(instance);
        public new static global::Lua.LuaValue Bind(global::System.Object instance) => Bind((global::UnityEditor.Animations.AnimatorStateMachine)instance);
        public new static global::Lua.LuaValue Bind(global::System.Collections.Generic.IList<global::UnityEditor.Animations.AnimatorStateMachine> instances) =>
            new global::Luny.LuaList<global::UnityEditor.Animations.AnimatorStateMachine>(instances);
        public new static global::Lua.LuaValue Bind(global::System.Collections.Generic.IList<global::System.Object> instances) =>
            new global::Luny.LuaList<global::UnityEditor.Animations.AnimatorStateMachine>(instances);
        private LuaAnimatorStateMachine(global::UnityEditor.Animations.AnimatorStateMachine instance) => m_Instance = instance;
        public static implicit operator global::Lua.LuaValue(LuaAnimatorStateMachine value) => new(value);
        private global::UnityEditor.Animations.AnimatorStateMachine m_Instance;
        public global::UnityEditor.Animations.AnimatorStateMachine Instance => m_Instance;
        public new global::System.Type BindType => typeof(global::UnityEditor.Animations.AnimatorStateMachine);
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

        private static readonly global::Lua.LuaFunction _LuaAnimatorStateMachine_AddAnyStateTransition = new global::Lua.LuaFunction("AddAnyStateTransition", (_context, _) =>
        {
            global::Lua.LuaValue _lastArg = default;
            global::System.Int32 _lastArgPos = default;
            global::System.Type _expectedType = default;
            var _argCount = _context.ArgumentCount;
            var _this = _context.GetArgument<LuaAnimatorStateMachine>(0);
            var _arg0 = _lastArg = _argCount > 1 ? _context.GetArgument(1) : global::Lua.LuaValue.Nil;
            _lastArgPos = 0; _expectedType = typeof(global::Luny.UnityEditor.Animations.LuaAnimatorState);
            if (_arg0.TryRead<global::Luny.UnityEditor.Animations.LuaAnimatorState>(out var _p0_UnityEditor_Animations_AnimatorState))
            {
                if (_argCount == 2)
                {
                    var destinationState = _p0_UnityEditor_Animations_AnimatorState.Instance;
                    var _ret0 = _this.Instance.AddAnyStateTransition(destinationState);
                    var _factory = _context.GetObjectFactory();
                    var _lret0 = _factory.Bind(_ret0);
                    var _retCount = _context.Return(_lret0);
                    return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                }
            }
            _lastArgPos = 0; _expectedType = typeof(global::Luny.UnityEditor.Animations.LuaAnimatorStateMachine);
            if (_arg0.TryRead<global::Luny.UnityEditor.Animations.LuaAnimatorStateMachine>(out var _p0_UnityEditor_Animations_AnimatorStateMachine))
            {
                if (_argCount == 2)
                {
                    var destinationStateMachine = _p0_UnityEditor_Animations_AnimatorStateMachine.Instance;
                    var _ret0 = _this.Instance.AddAnyStateTransition(destinationStateMachine);
                    var _factory = _context.GetObjectFactory();
                    var _lret0 = _factory.Bind(_ret0);
                    var _retCount = _context.Return(_lret0);
                    return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                }
            }
            throw new global::Lua.LuaRuntimeException(_context.Thread, $"{"AddAnyStateTransition"}: invalid argument #{_lastArgPos}: {_lastArg} ({_lastArg.Type}), expected: {_expectedType.FullName}", 2);
        });
        private static readonly global::Lua.LuaFunction _LuaAnimatorStateMachine_AddEntryTransition = new global::Lua.LuaFunction("AddEntryTransition", (_context, _) =>
        {
            global::Lua.LuaValue _lastArg = default;
            global::System.Int32 _lastArgPos = default;
            global::System.Type _expectedType = default;
            var _argCount = _context.ArgumentCount;
            var _this = _context.GetArgument<LuaAnimatorStateMachine>(0);
            var _arg0 = _lastArg = _argCount > 1 ? _context.GetArgument(1) : global::Lua.LuaValue.Nil;
            _lastArgPos = 0; _expectedType = typeof(global::Luny.UnityEditor.Animations.LuaAnimatorState);
            if (_arg0.TryRead<global::Luny.UnityEditor.Animations.LuaAnimatorState>(out var _p0_UnityEditor_Animations_AnimatorState))
            {
                if (_argCount == 2)
                {
                    var destinationState = _p0_UnityEditor_Animations_AnimatorState.Instance;
                    var _ret0 = _this.Instance.AddEntryTransition(destinationState);
                    var _factory = _context.GetObjectFactory();
                    var _lret0 = _factory.Bind(_ret0);
                    var _retCount = _context.Return(_lret0);
                    return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                }
            }
            _lastArgPos = 0; _expectedType = typeof(global::Luny.UnityEditor.Animations.LuaAnimatorStateMachine);
            if (_arg0.TryRead<global::Luny.UnityEditor.Animations.LuaAnimatorStateMachine>(out var _p0_UnityEditor_Animations_AnimatorStateMachine))
            {
                if (_argCount == 2)
                {
                    var destinationStateMachine = _p0_UnityEditor_Animations_AnimatorStateMachine.Instance;
                    var _ret0 = _this.Instance.AddEntryTransition(destinationStateMachine);
                    var _factory = _context.GetObjectFactory();
                    var _lret0 = _factory.Bind(_ret0);
                    var _retCount = _context.Return(_lret0);
                    return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                }
            }
            throw new global::Lua.LuaRuntimeException(_context.Thread, $"{"AddEntryTransition"}: invalid argument #{_lastArgPos}: {_lastArg} ({_lastArg.Type}), expected: {_expectedType.FullName}", 2);
        });
        private static readonly global::Lua.LuaFunction _LuaAnimatorStateMachine_AddState = new global::Lua.LuaFunction("AddState", (_context, _) =>
        {
            global::Lua.LuaValue _lastArg = default;
            global::System.Int32 _lastArgPos = default;
            global::System.Type _expectedType = default;
            var _argCount = _context.ArgumentCount;
            var _this = _context.GetArgument<LuaAnimatorStateMachine>(0);
            var _arg0 = _lastArg = _argCount > 1 ? _context.GetArgument(1) : global::Lua.LuaValue.Nil;
            _lastArgPos = 0; _expectedType = typeof(global::System.String);
            if (_arg0.TryRead<global::System.String>(out var _p0_System_String))
            {
                if (_argCount == 2)
                {
                    var name = _p0_System_String;
                    var _ret0 = _this.Instance.AddState(name);
                    var _factory = _context.GetObjectFactory();
                    var _lret0 = _factory.Bind(_ret0);
                    var _retCount = _context.Return(_lret0);
                    return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                }
                var _arg1 = _lastArg = _argCount > 2 ? _context.GetArgument(2) : global::Lua.LuaValue.Nil;
                _lastArgPos = 1; _expectedType = typeof(global::UnityEngine.Vector3);
                if (_arg1.TryRead<global::UnityEngine.Vector3>(out var _p1_UnityEngine_Vector3))
                {
                    if (_argCount == 3)
                    {
                        var name = _p0_System_String;
                        var position = _p1_UnityEngine_Vector3;
                        var _ret0 = _this.Instance.AddState(name, position);
                        var _factory = _context.GetObjectFactory();
                        var _lret0 = _factory.Bind(_ret0);
                        var _retCount = _context.Return(_lret0);
                        return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                    }
                }
            }
            _lastArgPos = 0; _expectedType = typeof(global::Luny.UnityEditor.Animations.LuaAnimatorState);
            if (_arg0.TryRead<global::Luny.UnityEditor.Animations.LuaAnimatorState>(out var _p0_UnityEditor_Animations_AnimatorState))
            {
                var _arg1 = _lastArg = _argCount > 2 ? _context.GetArgument(2) : global::Lua.LuaValue.Nil;
                _lastArgPos = 1; _expectedType = typeof(global::UnityEngine.Vector3);
                if (_arg1.TryRead<global::UnityEngine.Vector3>(out var _p1_UnityEngine_Vector3))
                {
                    if (_argCount == 3)
                    {
                        var state = _p0_UnityEditor_Animations_AnimatorState.Instance;
                        var position = _p1_UnityEngine_Vector3;
                        _this.Instance.AddState(state, position);
                        var _retCount = _context.Return();
                        return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                    }
                }
            }
            throw new global::Lua.LuaRuntimeException(_context.Thread, $"{"AddState"}: invalid argument #{_lastArgPos}: {_lastArg} ({_lastArg.Type}), expected: {_expectedType.FullName}", 2);
        });
        private static readonly global::Lua.LuaFunction _LuaAnimatorStateMachine_AddStateMachine = new global::Lua.LuaFunction("AddStateMachine", (_context, _) =>
        {
            global::Lua.LuaValue _lastArg = default;
            global::System.Int32 _lastArgPos = default;
            global::System.Type _expectedType = default;
            var _argCount = _context.ArgumentCount;
            var _this = _context.GetArgument<LuaAnimatorStateMachine>(0);
            var _arg0 = _lastArg = _argCount > 1 ? _context.GetArgument(1) : global::Lua.LuaValue.Nil;
            _lastArgPos = 0; _expectedType = typeof(global::System.String);
            if (_arg0.TryRead<global::System.String>(out var _p0_System_String))
            {
                if (_argCount == 2)
                {
                    var name = _p0_System_String;
                    var _ret0 = _this.Instance.AddStateMachine(name);
                    var _factory = _context.GetObjectFactory();
                    var _lret0 = _factory.Bind(_ret0);
                    var _retCount = _context.Return(_lret0);
                    return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                }
                var _arg1 = _lastArg = _argCount > 2 ? _context.GetArgument(2) : global::Lua.LuaValue.Nil;
                _lastArgPos = 1; _expectedType = typeof(global::UnityEngine.Vector3);
                if (_arg1.TryRead<global::UnityEngine.Vector3>(out var _p1_UnityEngine_Vector3))
                {
                    if (_argCount == 3)
                    {
                        var name = _p0_System_String;
                        var position = _p1_UnityEngine_Vector3;
                        var _ret0 = _this.Instance.AddStateMachine(name, position);
                        var _factory = _context.GetObjectFactory();
                        var _lret0 = _factory.Bind(_ret0);
                        var _retCount = _context.Return(_lret0);
                        return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                    }
                }
            }
            _lastArgPos = 0; _expectedType = typeof(global::Luny.UnityEditor.Animations.LuaAnimatorStateMachine);
            if (_arg0.TryRead<global::Luny.UnityEditor.Animations.LuaAnimatorStateMachine>(out var _p0_UnityEditor_Animations_AnimatorStateMachine))
            {
                var _arg1 = _lastArg = _argCount > 2 ? _context.GetArgument(2) : global::Lua.LuaValue.Nil;
                _lastArgPos = 1; _expectedType = typeof(global::UnityEngine.Vector3);
                if (_arg1.TryRead<global::UnityEngine.Vector3>(out var _p1_UnityEngine_Vector3))
                {
                    if (_argCount == 3)
                    {
                        var stateMachine = _p0_UnityEditor_Animations_AnimatorStateMachine.Instance;
                        var position = _p1_UnityEngine_Vector3;
                        _this.Instance.AddStateMachine(stateMachine, position);
                        var _retCount = _context.Return();
                        return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                    }
                }
            }
            throw new global::Lua.LuaRuntimeException(_context.Thread, $"{"AddStateMachine"}: invalid argument #{_lastArgPos}: {_lastArg} ({_lastArg.Type}), expected: {_expectedType.FullName}", 2);
        });
        private static readonly global::Lua.LuaFunction _LuaAnimatorStateMachine_AddStateMachineBehaviour = new global::Lua.LuaFunction("AddStateMachineBehaviour", (_context, _) =>
        {
            global::Lua.LuaValue _lastArg = default;
            global::System.Int32 _lastArgPos = default;
            global::System.Type _expectedType = default;
            var _argCount = _context.ArgumentCount;
            var _this = _context.GetArgument<LuaAnimatorStateMachine>(0);
            var _arg0 = _lastArg = _argCount > 1 ? _context.GetArgument(1) : global::Lua.LuaValue.Nil;
            _lastArgPos = 0; _expectedType = typeof(global::Luny.ILuaBindType);
            if (_arg0.TryRead<global::Luny.ILuaBindType>(out var _p0_System_Type))
            {
                if (_argCount == 2)
                {
                    var stateMachineBehaviourType = _p0_System_Type.BindType;
                    var _ret0 = _this.Instance.AddStateMachineBehaviour(stateMachineBehaviourType);
                    var _factory = _context.GetObjectFactory();
                    var _lret0 = _factory.Bind(_ret0);
                    var _retCount = _context.Return(_lret0);
                    return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                }
            }
            throw new global::Lua.LuaRuntimeException(_context.Thread, $"{"AddStateMachineBehaviour"}: invalid argument #{_lastArgPos}: {_lastArg} ({_lastArg.Type}), expected: {_expectedType.FullName}", 2);
        });
        private static readonly global::Lua.LuaFunction _LuaAnimatorStateMachine_AddStateMachineExitTransition = new global::Lua.LuaFunction("AddStateMachineExitTransition", (_context, _) =>
        {
            global::Lua.LuaValue _lastArg = default;
            global::System.Int32 _lastArgPos = default;
            global::System.Type _expectedType = default;
            var _argCount = _context.ArgumentCount;
            var _this = _context.GetArgument<LuaAnimatorStateMachine>(0);
            var _arg0 = _lastArg = _argCount > 1 ? _context.GetArgument(1) : global::Lua.LuaValue.Nil;
            _lastArgPos = 0; _expectedType = typeof(global::Luny.UnityEditor.Animations.LuaAnimatorStateMachine);
            if (_arg0.TryRead<global::Luny.UnityEditor.Animations.LuaAnimatorStateMachine>(out var _p0_UnityEditor_Animations_AnimatorStateMachine))
            {
                if (_argCount == 2)
                {
                    var sourceStateMachine = _p0_UnityEditor_Animations_AnimatorStateMachine.Instance;
                    var _ret0 = _this.Instance.AddStateMachineExitTransition(sourceStateMachine);
                    var _factory = _context.GetObjectFactory();
                    var _lret0 = _factory.Bind(_ret0);
                    var _retCount = _context.Return(_lret0);
                    return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                }
            }
            throw new global::Lua.LuaRuntimeException(_context.Thread, $"{"AddStateMachineExitTransition"}: invalid argument #{_lastArgPos}: {_lastArg} ({_lastArg.Type}), expected: {_expectedType.FullName}", 2);
        });
        private static readonly global::Lua.LuaFunction _LuaAnimatorStateMachine_AddStateMachineTransition = new global::Lua.LuaFunction("AddStateMachineTransition", (_context, _) =>
        {
            global::Lua.LuaValue _lastArg = default;
            global::System.Int32 _lastArgPos = default;
            global::System.Type _expectedType = default;
            var _argCount = _context.ArgumentCount;
            var _this = _context.GetArgument<LuaAnimatorStateMachine>(0);
            var _arg0 = _lastArg = _argCount > 1 ? _context.GetArgument(1) : global::Lua.LuaValue.Nil;
            _lastArgPos = 0; _expectedType = typeof(global::Luny.UnityEditor.Animations.LuaAnimatorStateMachine);
            if (_arg0.TryRead<global::Luny.UnityEditor.Animations.LuaAnimatorStateMachine>(out var _p0_UnityEditor_Animations_AnimatorStateMachine))
            {
                if (_argCount == 2)
                {
                    var sourceStateMachine = _p0_UnityEditor_Animations_AnimatorStateMachine.Instance;
                    var _ret0 = _this.Instance.AddStateMachineTransition(sourceStateMachine);
                    var _factory = _context.GetObjectFactory();
                    var _lret0 = _factory.Bind(_ret0);
                    var _retCount = _context.Return(_lret0);
                    return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                }
                var _arg1 = _lastArg = _argCount > 2 ? _context.GetArgument(2) : global::Lua.LuaValue.Nil;
                _lastArgPos = 1; _expectedType = typeof(global::Luny.UnityEditor.Animations.LuaAnimatorStateMachine);
                if (_arg1.TryRead<global::Luny.UnityEditor.Animations.LuaAnimatorStateMachine>(out var _p1_UnityEditor_Animations_AnimatorStateMachine))
                {
                    if (_argCount == 3)
                    {
                        var sourceStateMachine = _p0_UnityEditor_Animations_AnimatorStateMachine.Instance;
                        var destinationStateMachine = _p1_UnityEditor_Animations_AnimatorStateMachine.Instance;
                        var _ret0 = _this.Instance.AddStateMachineTransition(sourceStateMachine, destinationStateMachine);
                        var _factory = _context.GetObjectFactory();
                        var _lret0 = _factory.Bind(_ret0);
                        var _retCount = _context.Return(_lret0);
                        return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                    }
                }
                _lastArgPos = 1; _expectedType = typeof(global::Luny.UnityEditor.Animations.LuaAnimatorState);
                if (_arg1.TryRead<global::Luny.UnityEditor.Animations.LuaAnimatorState>(out var _p1_UnityEditor_Animations_AnimatorState))
                {
                    if (_argCount == 3)
                    {
                        var sourceStateMachine = _p0_UnityEditor_Animations_AnimatorStateMachine.Instance;
                        var destinationState = _p1_UnityEditor_Animations_AnimatorState.Instance;
                        var _ret0 = _this.Instance.AddStateMachineTransition(sourceStateMachine, destinationState);
                        var _factory = _context.GetObjectFactory();
                        var _lret0 = _factory.Bind(_ret0);
                        var _retCount = _context.Return(_lret0);
                        return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                    }
                }
            }
            throw new global::Lua.LuaRuntimeException(_context.Thread, $"{"AddStateMachineTransition"}: invalid argument #{_lastArgPos}: {_lastArg} ({_lastArg.Type}), expected: {_expectedType.FullName}", 2);
        });
        private static readonly global::Lua.LuaFunction _LuaAnimatorStateMachine_GetStateMachineTransitions = new global::Lua.LuaFunction("GetStateMachineTransitions", (_context, _) =>
        {
            global::Lua.LuaValue _lastArg = default;
            global::System.Int32 _lastArgPos = default;
            global::System.Type _expectedType = default;
            var _argCount = _context.ArgumentCount;
            var _this = _context.GetArgument<LuaAnimatorStateMachine>(0);
            var _arg0 = _lastArg = _argCount > 1 ? _context.GetArgument(1) : global::Lua.LuaValue.Nil;
            _lastArgPos = 0; _expectedType = typeof(global::Luny.UnityEditor.Animations.LuaAnimatorStateMachine);
            if (_arg0.TryRead<global::Luny.UnityEditor.Animations.LuaAnimatorStateMachine>(out var _p0_UnityEditor_Animations_AnimatorStateMachine))
            {
                if (_argCount == 2)
                {
                    var sourceStateMachine = _p0_UnityEditor_Animations_AnimatorStateMachine.Instance;
                    var _ret0 = _this.Instance.GetStateMachineTransitions(sourceStateMachine);
                    var _factory = _context.GetObjectFactory();
                    var _lret0 = _factory.Bind(_ret0);
                    var _retCount = _context.Return(_lret0);
                    return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                }
            }
            throw new global::Lua.LuaRuntimeException(_context.Thread, $"{"GetStateMachineTransitions"}: invalid argument #{_lastArgPos}: {_lastArg} ({_lastArg.Type}), expected: {_expectedType.FullName}", 2);
        });
        private static readonly global::Lua.LuaFunction _LuaAnimatorStateMachine_MakeUniqueStateMachineName = new global::Lua.LuaFunction("MakeUniqueStateMachineName", (_context, _) =>
        {
            global::Lua.LuaValue _lastArg = default;
            global::System.Int32 _lastArgPos = default;
            global::System.Type _expectedType = default;
            var _argCount = _context.ArgumentCount;
            var _this = _context.GetArgument<LuaAnimatorStateMachine>(0);
            var _arg0 = _lastArg = _argCount > 1 ? _context.GetArgument(1) : global::Lua.LuaValue.Nil;
            _lastArgPos = 0; _expectedType = typeof(global::System.String);
            if (_arg0.TryRead<global::System.String>(out var _p0_System_String))
            {
                if (_argCount == 2)
                {
                    var name = _p0_System_String;
                    var _ret0 = _this.Instance.MakeUniqueStateMachineName(name);
                    var _lret0 = new global::Lua.LuaValue(_ret0);
                    var _retCount = _context.Return(_lret0);
                    return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                }
            }
            throw new global::Lua.LuaRuntimeException(_context.Thread, $"{"MakeUniqueStateMachineName"}: invalid argument #{_lastArgPos}: {_lastArg} ({_lastArg.Type}), expected: {_expectedType.FullName}", 2);
        });
        private static readonly global::Lua.LuaFunction _LuaAnimatorStateMachine_MakeUniqueStateName = new global::Lua.LuaFunction("MakeUniqueStateName", (_context, _) =>
        {
            global::Lua.LuaValue _lastArg = default;
            global::System.Int32 _lastArgPos = default;
            global::System.Type _expectedType = default;
            var _argCount = _context.ArgumentCount;
            var _this = _context.GetArgument<LuaAnimatorStateMachine>(0);
            var _arg0 = _lastArg = _argCount > 1 ? _context.GetArgument(1) : global::Lua.LuaValue.Nil;
            _lastArgPos = 0; _expectedType = typeof(global::System.String);
            if (_arg0.TryRead<global::System.String>(out var _p0_System_String))
            {
                if (_argCount == 2)
                {
                    var name = _p0_System_String;
                    var _ret0 = _this.Instance.MakeUniqueStateName(name);
                    var _lret0 = new global::Lua.LuaValue(_ret0);
                    var _retCount = _context.Return(_lret0);
                    return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                }
            }
            throw new global::Lua.LuaRuntimeException(_context.Thread, $"{"MakeUniqueStateName"}: invalid argument #{_lastArgPos}: {_lastArg} ({_lastArg.Type}), expected: {_expectedType.FullName}", 2);
        });
        private static readonly global::Lua.LuaFunction _LuaAnimatorStateMachine_RemoveAnyStateTransition = new global::Lua.LuaFunction("RemoveAnyStateTransition", (_context, _) =>
        {
            global::Lua.LuaValue _lastArg = default;
            global::System.Int32 _lastArgPos = default;
            global::System.Type _expectedType = default;
            var _argCount = _context.ArgumentCount;
            var _this = _context.GetArgument<LuaAnimatorStateMachine>(0);
            var _arg0 = _lastArg = _argCount > 1 ? _context.GetArgument(1) : global::Lua.LuaValue.Nil;
            _lastArgPos = 0; _expectedType = typeof(global::Luny.UnityEditor.Animations.LuaAnimatorStateTransition);
            if (_arg0.TryRead<global::Luny.UnityEditor.Animations.LuaAnimatorStateTransition>(out var _p0_UnityEditor_Animations_AnimatorStateTransition))
            {
                if (_argCount == 2)
                {
                    var transition = _p0_UnityEditor_Animations_AnimatorStateTransition.Instance;
                    var _ret0 = _this.Instance.RemoveAnyStateTransition(transition);
                    var _lret0 = new global::Lua.LuaValue(_ret0);
                    var _retCount = _context.Return(_lret0);
                    return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                }
            }
            throw new global::Lua.LuaRuntimeException(_context.Thread, $"{"RemoveAnyStateTransition"}: invalid argument #{_lastArgPos}: {_lastArg} ({_lastArg.Type}), expected: {_expectedType.FullName}", 2);
        });
        private static readonly global::Lua.LuaFunction _LuaAnimatorStateMachine_RemoveEntryTransition = new global::Lua.LuaFunction("RemoveEntryTransition", (_context, _) =>
        {
            global::Lua.LuaValue _lastArg = default;
            global::System.Int32 _lastArgPos = default;
            global::System.Type _expectedType = default;
            var _argCount = _context.ArgumentCount;
            var _this = _context.GetArgument<LuaAnimatorStateMachine>(0);
            var _arg0 = _lastArg = _argCount > 1 ? _context.GetArgument(1) : global::Lua.LuaValue.Nil;
            _lastArgPos = 0; _expectedType = typeof(global::Luny.UnityEditor.Animations.LuaAnimatorTransition);
            if (_arg0.TryRead<global::Luny.UnityEditor.Animations.LuaAnimatorTransition>(out var _p0_UnityEditor_Animations_AnimatorTransition))
            {
                if (_argCount == 2)
                {
                    var transition = _p0_UnityEditor_Animations_AnimatorTransition.Instance;
                    var _ret0 = _this.Instance.RemoveEntryTransition(transition);
                    var _lret0 = new global::Lua.LuaValue(_ret0);
                    var _retCount = _context.Return(_lret0);
                    return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                }
            }
            throw new global::Lua.LuaRuntimeException(_context.Thread, $"{"RemoveEntryTransition"}: invalid argument #{_lastArgPos}: {_lastArg} ({_lastArg.Type}), expected: {_expectedType.FullName}", 2);
        });
        private static readonly global::Lua.LuaFunction _LuaAnimatorStateMachine_RemoveState = new global::Lua.LuaFunction("RemoveState", (_context, _) =>
        {
            global::Lua.LuaValue _lastArg = default;
            global::System.Int32 _lastArgPos = default;
            global::System.Type _expectedType = default;
            var _argCount = _context.ArgumentCount;
            var _this = _context.GetArgument<LuaAnimatorStateMachine>(0);
            var _arg0 = _lastArg = _argCount > 1 ? _context.GetArgument(1) : global::Lua.LuaValue.Nil;
            _lastArgPos = 0; _expectedType = typeof(global::Luny.UnityEditor.Animations.LuaAnimatorState);
            if (_arg0.TryRead<global::Luny.UnityEditor.Animations.LuaAnimatorState>(out var _p0_UnityEditor_Animations_AnimatorState))
            {
                if (_argCount == 2)
                {
                    var state = _p0_UnityEditor_Animations_AnimatorState.Instance;
                    _this.Instance.RemoveState(state);
                    var _retCount = _context.Return();
                    return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                }
            }
            throw new global::Lua.LuaRuntimeException(_context.Thread, $"{"RemoveState"}: invalid argument #{_lastArgPos}: {_lastArg} ({_lastArg.Type}), expected: {_expectedType.FullName}", 2);
        });
        private static readonly global::Lua.LuaFunction _LuaAnimatorStateMachine_RemoveStateMachine = new global::Lua.LuaFunction("RemoveStateMachine", (_context, _) =>
        {
            global::Lua.LuaValue _lastArg = default;
            global::System.Int32 _lastArgPos = default;
            global::System.Type _expectedType = default;
            var _argCount = _context.ArgumentCount;
            var _this = _context.GetArgument<LuaAnimatorStateMachine>(0);
            var _arg0 = _lastArg = _argCount > 1 ? _context.GetArgument(1) : global::Lua.LuaValue.Nil;
            _lastArgPos = 0; _expectedType = typeof(global::Luny.UnityEditor.Animations.LuaAnimatorStateMachine);
            if (_arg0.TryRead<global::Luny.UnityEditor.Animations.LuaAnimatorStateMachine>(out var _p0_UnityEditor_Animations_AnimatorStateMachine))
            {
                if (_argCount == 2)
                {
                    var stateMachine = _p0_UnityEditor_Animations_AnimatorStateMachine.Instance;
                    _this.Instance.RemoveStateMachine(stateMachine);
                    var _retCount = _context.Return();
                    return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                }
            }
            throw new global::Lua.LuaRuntimeException(_context.Thread, $"{"RemoveStateMachine"}: invalid argument #{_lastArgPos}: {_lastArg} ({_lastArg.Type}), expected: {_expectedType.FullName}", 2);
        });
        private static readonly global::Lua.LuaFunction _LuaAnimatorStateMachine_RemoveStateMachineTransition = new global::Lua.LuaFunction("RemoveStateMachineTransition", (_context, _) =>
        {
            global::Lua.LuaValue _lastArg = default;
            global::System.Int32 _lastArgPos = default;
            global::System.Type _expectedType = default;
            var _argCount = _context.ArgumentCount;
            var _this = _context.GetArgument<LuaAnimatorStateMachine>(0);
            var _arg0 = _lastArg = _argCount > 1 ? _context.GetArgument(1) : global::Lua.LuaValue.Nil;
            _lastArgPos = 0; _expectedType = typeof(global::Luny.UnityEditor.Animations.LuaAnimatorStateMachine);
            if (_arg0.TryRead<global::Luny.UnityEditor.Animations.LuaAnimatorStateMachine>(out var _p0_UnityEditor_Animations_AnimatorStateMachine))
            {
                var _arg1 = _lastArg = _argCount > 2 ? _context.GetArgument(2) : global::Lua.LuaValue.Nil;
                _lastArgPos = 1; _expectedType = typeof(global::Luny.UnityEditor.Animations.LuaAnimatorTransition);
                if (_arg1.TryRead<global::Luny.UnityEditor.Animations.LuaAnimatorTransition>(out var _p1_UnityEditor_Animations_AnimatorTransition))
                {
                    if (_argCount == 3)
                    {
                        var sourceStateMachine = _p0_UnityEditor_Animations_AnimatorStateMachine.Instance;
                        var transition = _p1_UnityEditor_Animations_AnimatorTransition.Instance;
                        var _ret0 = _this.Instance.RemoveStateMachineTransition(sourceStateMachine, transition);
                        var _lret0 = new global::Lua.LuaValue(_ret0);
                        var _retCount = _context.Return(_lret0);
                        return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                    }
                }
            }
            throw new global::Lua.LuaRuntimeException(_context.Thread, $"{"RemoveStateMachineTransition"}: invalid argument #{_lastArgPos}: {_lastArg} ({_lastArg.Type}), expected: {_expectedType.FullName}", 2);
        });
        private static readonly global::Lua.LuaFunction _LuaAnimatorStateMachine_SetStateMachineTransitions = new global::Lua.LuaFunction("SetStateMachineTransitions", (_context, _) =>
        {
            global::Lua.LuaValue _lastArg = default;
            global::System.Int32 _lastArgPos = default;
            global::System.Type _expectedType = default;
            var _argCount = _context.ArgumentCount;
            var _this = _context.GetArgument<LuaAnimatorStateMachine>(0);
            var _arg0 = _lastArg = _argCount > 1 ? _context.GetArgument(1) : global::Lua.LuaValue.Nil;
            _lastArgPos = 0; _expectedType = typeof(global::Luny.UnityEditor.Animations.LuaAnimatorStateMachine);
            if (_arg0.TryRead<global::Luny.UnityEditor.Animations.LuaAnimatorStateMachine>(out var _p0_UnityEditor_Animations_AnimatorStateMachine))
            {
                var _arg1 = _lastArg = _argCount > 2 ? _context.GetArgument(2) : global::Lua.LuaValue.Nil;
                _lastArgPos = 1; _expectedType = typeof(global::UnityEditor.Animations.AnimatorTransition[]);
                if (_arg1.TryReadArray<global::UnityEditor.Animations.AnimatorTransition>(out var _p1_UnityEditor_Animations_AnimatorTransitionArray))
                {
                    if (_argCount == 3)
                    {
                        var sourceStateMachine = _p0_UnityEditor_Animations_AnimatorStateMachine.Instance;
                        var transitions = _p1_UnityEditor_Animations_AnimatorTransitionArray;
                        _this.Instance.SetStateMachineTransitions(sourceStateMachine, transitions);
                        var _retCount = _context.Return();
                        return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                    }
                }
            }
            throw new global::Lua.LuaRuntimeException(_context.Thread, $"{"SetStateMachineTransitions"}: invalid argument #{_lastArgPos}: {_lastArg} ({_lastArg.Type}), expected: {_expectedType.FullName}", 2);
        });
        private static readonly global::Lua.LuaFunction __index = new(global::Lua.Runtime.Metamethods.Index, (_context, _) =>
        {
            var _this = _context.GetArgument<LuaAnimatorStateMachine>(0);
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
            var _this = _context.GetArgument<LuaAnimatorStateMachine>(0);
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
                case "AddAnyStateTransition": _value = _LuaAnimatorStateMachine_AddAnyStateTransition; return true;
                case "AddEntryTransition": _value = _LuaAnimatorStateMachine_AddEntryTransition; return true;
                case "AddState": _value = _LuaAnimatorStateMachine_AddState; return true;
                case "AddStateMachine": _value = _LuaAnimatorStateMachine_AddStateMachine; return true;
                case "AddStateMachineBehaviour": _value = _LuaAnimatorStateMachine_AddStateMachineBehaviour; return true;
                case "AddStateMachineExitTransition": _value = _LuaAnimatorStateMachine_AddStateMachineExitTransition; return true;
                case "AddStateMachineTransition": _value = _LuaAnimatorStateMachine_AddStateMachineTransition; return true;
                case "GetStateMachineTransitions": _value = _LuaAnimatorStateMachine_GetStateMachineTransitions; return true;
                case "MakeUniqueStateMachineName": _value = _LuaAnimatorStateMachine_MakeUniqueStateMachineName; return true;
                case "MakeUniqueStateName": _value = _LuaAnimatorStateMachine_MakeUniqueStateName; return true;
                case "RemoveAnyStateTransition": _value = _LuaAnimatorStateMachine_RemoveAnyStateTransition; return true;
                case "RemoveEntryTransition": _value = _LuaAnimatorStateMachine_RemoveEntryTransition; return true;
                case "RemoveState": _value = _LuaAnimatorStateMachine_RemoveState; return true;
                case "RemoveStateMachine": _value = _LuaAnimatorStateMachine_RemoveStateMachine; return true;
                case "RemoveStateMachineTransition": _value = _LuaAnimatorStateMachine_RemoveStateMachineTransition; return true;
                case "SetStateMachineTransitions": _value = _LuaAnimatorStateMachine_SetStateMachineTransitions; return true;
                case "anyStatePosition": _value = _factory.Bind(Instance.anyStatePosition); return true;
                case "anyStateTransitions": _value = _factory.Bind(Instance.anyStateTransitions); return true;
                case "behaviours": _value = _factory.Bind(Instance.behaviours); return true;
                case "defaultState": _value = _factory.Bind(Instance.defaultState); return true;
                case "entryPosition": _value = _factory.Bind(Instance.entryPosition); return true;
                case "entryTransitions": _value = _factory.Bind(Instance.entryTransitions); return true;
                case "exitPosition": _value = _factory.Bind(Instance.exitPosition); return true;
                case "parentStateMachinePosition": _value = _factory.Bind(Instance.parentStateMachinePosition); return true;
                case "stateMachines": _value = _factory.Bind(Instance.stateMachines); return true;
                case "states": _value = _factory.Bind(Instance.states); return true;
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
                case "anyStatePosition": Instance.anyStatePosition = _value.Read<global::UnityEngine.Vector3>();  return true;
                case "anyStateTransitions": Instance.anyStateTransitions = _value.Read<global::UnityEditor.Animations.AnimatorStateTransition[]>();  return true;
                case "behaviours": Instance.behaviours = _value.Read<global::UnityEngine.StateMachineBehaviour[]>();  return true;
                case "defaultState": Instance.defaultState = _value.Read<global::Luny.UnityEditor.Animations.LuaAnimatorState>().Instance;  return true;
                case "entryPosition": Instance.entryPosition = _value.Read<global::UnityEngine.Vector3>();  return true;
                case "entryTransitions": Instance.entryTransitions = _value.Read<global::UnityEditor.Animations.AnimatorTransition[]>();  return true;
                case "exitPosition": Instance.exitPosition = _value.Read<global::UnityEngine.Vector3>();  return true;
                case "parentStateMachinePosition": Instance.parentStateMachinePosition = _value.Read<global::UnityEngine.Vector3>();  return true;
                case "stateMachines": Instance.stateMachines = _value.Read<global::UnityEditor.Animations.ChildAnimatorStateMachine[]>();  return true;
                case "states": Instance.states = _value.Read<global::UnityEditor.Animations.ChildAnimatorState[]>();  return true;
                default: return false;
            }
        }
    }
    public sealed class LuaAnimatorStateMachineType : global::Luny.ILuaStatic
    {
        public static global::Lua.LuaValue Bind() => new LuaAnimatorStateMachineType();
        private LuaAnimatorStateMachineType() {}
        public static implicit operator global::Lua.LuaValue(LuaAnimatorStateMachineType value) => new(value);
        public global::System.Type BindType => typeof(global::UnityEditor.Animations.AnimatorStateMachine);
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

        private static readonly global::Lua.LuaFunction _LuaAnimatorStateMachine_new = new global::Lua.LuaFunction(".ctor", (_context, _) =>
        {
            global::Lua.LuaValue _lastArg = default;
            global::System.Int32 _lastArgPos = default;
            global::System.Type _expectedType = default;
            var _argCount = _context.ArgumentCount;
            if (_argCount == 0)
            {
                var _ret0 = new global::UnityEditor.Animations.AnimatorStateMachine();
                var _factory = _context.GetObjectFactory();
                var _lret0 = _factory.Bind(_ret0);
                var _retCount = _context.Return(_lret0);
                return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
            }
            throw new global::Lua.LuaRuntimeException(_context.Thread, $"{".ctor"}: invalid argument #{_lastArgPos}: {_lastArg} ({_lastArg.Type}), expected: {_expectedType.FullName}", 2);
        });
        private static readonly global::Lua.LuaFunction __index = new(global::Lua.Runtime.Metamethods.Index, (_context, _) =>
        {
            var _this = _context.GetArgument<LuaAnimatorStateMachineType>(0);
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
            var _this = _context.GetArgument<LuaAnimatorStateMachineType>(0);
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
                case "new": _value = _LuaAnimatorStateMachine_new; return true;
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
