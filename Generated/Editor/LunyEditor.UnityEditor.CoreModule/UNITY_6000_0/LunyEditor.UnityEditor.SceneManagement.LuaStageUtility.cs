
// --------------------------------------------------------------
// GENERATED FILE ----> DO NOT EDIT <---- CHANGES WILL BE LOST !!
// --------------------------------------------------------------

#if UNITY_6000_0_OR_NEWER && !(UNITY_6000_1_OR_NEWER)
#pragma warning disable 0109, 0162, 0168, 0219
using Luny;

namespace LunyEditor.UnityEditor.SceneManagement
{
    public sealed class LuaStageUtilityType : global::Luny.ILuaStatic
    {
        public static global::Lua.LuaValue Bind() => new LuaStageUtilityType();
        private LuaStageUtilityType() {}
        public static implicit operator global::Lua.LuaValue(LuaStageUtilityType value) => new(value);
        public global::System.Type BindType => typeof(global::UnityEditor.SceneManagement.StageUtility);
        public override global::System.String ToString() => BindType.FullName;
#if UNITY_EDITOR
        [global::UnityEngine.RuntimeInitializeOnLoadMethod(global::UnityEngine.RuntimeInitializeLoadType.SubsystemRegistration)]
        private static void ResetStaticFields() => s_Metatable = null;
#endif

        private static readonly global::Lua.LuaFunction _LuaStageUtility_GetCurrentStage = new global::Lua.LuaFunction("GetCurrentStage", (_context, _) =>
        {
            global::Lua.LuaValue _lastArg = default;
            global::System.Int32 _lastArgPos = default;
            global::System.Type _expectedType = default;
            var _argCount = _context.ArgumentCount;
            if (_argCount == 0)
            {
                var _ret0 = global::UnityEditor.SceneManagement.StageUtility.GetCurrentStage();
                var _factory = _context.GetObjectFactory();
                var _lret0 = _factory.Bind(_ret0);
                var _retCount = _context.Return(_lret0);
                return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
            }
            throw new global::Lua.LuaRuntimeException(_context.Thread, $"{"GetCurrentStage"}: invalid argument #{_lastArgPos}: {_lastArg} ({_lastArg.Type}), expected: {_expectedType.FullName}", 2);
        });
        private static readonly global::Lua.LuaFunction _LuaStageUtility_GetCurrentStageHandle = new global::Lua.LuaFunction("GetCurrentStageHandle", (_context, _) =>
        {
            global::Lua.LuaValue _lastArg = default;
            global::System.Int32 _lastArgPos = default;
            global::System.Type _expectedType = default;
            var _argCount = _context.ArgumentCount;
            if (_argCount == 0)
            {
                var _ret0 = global::UnityEditor.SceneManagement.StageUtility.GetCurrentStageHandle();
                var _lret0 = global::LunyEditor.UnityEditor.SceneManagement.LuaStageHandle.Bind(_ret0);
                var _retCount = _context.Return(_lret0);
                return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
            }
            throw new global::Lua.LuaRuntimeException(_context.Thread, $"{"GetCurrentStageHandle"}: invalid argument #{_lastArgPos}: {_lastArg} ({_lastArg.Type}), expected: {_expectedType.FullName}", 2);
        });
        private static readonly global::Lua.LuaFunction _LuaStageUtility_GetMainStage = new global::Lua.LuaFunction("GetMainStage", (_context, _) =>
        {
            global::Lua.LuaValue _lastArg = default;
            global::System.Int32 _lastArgPos = default;
            global::System.Type _expectedType = default;
            var _argCount = _context.ArgumentCount;
            if (_argCount == 0)
            {
                var _ret0 = global::UnityEditor.SceneManagement.StageUtility.GetMainStage();
                var _factory = _context.GetObjectFactory();
                var _lret0 = _factory.Bind(_ret0);
                var _retCount = _context.Return(_lret0);
                return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
            }
            throw new global::Lua.LuaRuntimeException(_context.Thread, $"{"GetMainStage"}: invalid argument #{_lastArgPos}: {_lastArg} ({_lastArg.Type}), expected: {_expectedType.FullName}", 2);
        });
        private static readonly global::Lua.LuaFunction _LuaStageUtility_GetMainStageHandle = new global::Lua.LuaFunction("GetMainStageHandle", (_context, _) =>
        {
            global::Lua.LuaValue _lastArg = default;
            global::System.Int32 _lastArgPos = default;
            global::System.Type _expectedType = default;
            var _argCount = _context.ArgumentCount;
            if (_argCount == 0)
            {
                var _ret0 = global::UnityEditor.SceneManagement.StageUtility.GetMainStageHandle();
                var _lret0 = global::LunyEditor.UnityEditor.SceneManagement.LuaStageHandle.Bind(_ret0);
                var _retCount = _context.Return(_lret0);
                return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
            }
            throw new global::Lua.LuaRuntimeException(_context.Thread, $"{"GetMainStageHandle"}: invalid argument #{_lastArgPos}: {_lastArg} ({_lastArg.Type}), expected: {_expectedType.FullName}", 2);
        });
        private static readonly global::Lua.LuaFunction _LuaStageUtility_GetStage = new global::Lua.LuaFunction("GetStage", (_context, _) =>
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
                    var _ret0 = global::UnityEditor.SceneManagement.StageUtility.GetStage(scene);
                    var _factory = _context.GetObjectFactory();
                    var _lret0 = _factory.Bind(_ret0);
                    var _retCount = _context.Return(_lret0);
                    return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                }
            }
            _lastArgPos = 0; _expectedType = typeof(global::Luny.UnityEngine.LuaGameObject);
            if (_arg0.TryRead<global::Luny.UnityEngine.LuaGameObject>(out var _p0_UnityEngine_GameObject))
            {
                if (_argCount == 1)
                {
                    var gameObject = _p0_UnityEngine_GameObject.Instance;
                    var _ret0 = global::UnityEditor.SceneManagement.StageUtility.GetStage(gameObject);
                    var _factory = _context.GetObjectFactory();
                    var _lret0 = _factory.Bind(_ret0);
                    var _retCount = _context.Return(_lret0);
                    return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                }
            }
            throw new global::Lua.LuaRuntimeException(_context.Thread, $"{"GetStage"}: invalid argument #{_lastArgPos}: {_lastArg} ({_lastArg.Type}), expected: {_expectedType.FullName}", 2);
        });
        private static readonly global::Lua.LuaFunction _LuaStageUtility_GetStageHandle = new global::Lua.LuaFunction("GetStageHandle", (_context, _) =>
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
                    var _ret0 = global::UnityEditor.SceneManagement.StageUtility.GetStageHandle(scene);
                    var _lret0 = global::LunyEditor.UnityEditor.SceneManagement.LuaStageHandle.Bind(_ret0);
                    var _retCount = _context.Return(_lret0);
                    return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                }
            }
            _lastArgPos = 0; _expectedType = typeof(global::Luny.UnityEngine.LuaGameObject);
            if (_arg0.TryRead<global::Luny.UnityEngine.LuaGameObject>(out var _p0_UnityEngine_GameObject))
            {
                if (_argCount == 1)
                {
                    var gameObject = _p0_UnityEngine_GameObject.Instance;
                    var _ret0 = global::UnityEditor.SceneManagement.StageUtility.GetStageHandle(gameObject);
                    var _lret0 = global::LunyEditor.UnityEditor.SceneManagement.LuaStageHandle.Bind(_ret0);
                    var _retCount = _context.Return(_lret0);
                    return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                }
            }
            throw new global::Lua.LuaRuntimeException(_context.Thread, $"{"GetStageHandle"}: invalid argument #{_lastArgPos}: {_lastArg} ({_lastArg.Type}), expected: {_expectedType.FullName}", 2);
        });
        private static readonly global::Lua.LuaFunction _LuaStageUtility_GoBackToPreviousStage = new global::Lua.LuaFunction("GoBackToPreviousStage", (_context, _) =>
        {
            global::Lua.LuaValue _lastArg = default;
            global::System.Int32 _lastArgPos = default;
            global::System.Type _expectedType = default;
            var _argCount = _context.ArgumentCount;
            if (_argCount == 0)
            {
                global::UnityEditor.SceneManagement.StageUtility.GoBackToPreviousStage();
                var _retCount = _context.Return();
                return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
            }
            throw new global::Lua.LuaRuntimeException(_context.Thread, $"{"GoBackToPreviousStage"}: invalid argument #{_lastArgPos}: {_lastArg} ({_lastArg.Type}), expected: {_expectedType.FullName}", 2);
        });
        private static readonly global::Lua.LuaFunction _LuaStageUtility_GoToMainStage = new global::Lua.LuaFunction("GoToMainStage", (_context, _) =>
        {
            global::Lua.LuaValue _lastArg = default;
            global::System.Int32 _lastArgPos = default;
            global::System.Type _expectedType = default;
            var _argCount = _context.ArgumentCount;
            if (_argCount == 0)
            {
                global::UnityEditor.SceneManagement.StageUtility.GoToMainStage();
                var _retCount = _context.Return();
                return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
            }
            throw new global::Lua.LuaRuntimeException(_context.Thread, $"{"GoToMainStage"}: invalid argument #{_lastArgPos}: {_lastArg} ({_lastArg.Type}), expected: {_expectedType.FullName}", 2);
        });
        private static readonly global::Lua.LuaFunction _LuaStageUtility_GoToStage = new global::Lua.LuaFunction("GoToStage", (_context, _) =>
        {
            global::Lua.LuaValue _lastArg = default;
            global::System.Int32 _lastArgPos = default;
            global::System.Type _expectedType = default;
            var _argCount = _context.ArgumentCount;
            var _arg0 = _lastArg = _argCount > 0 ? _context.GetArgument(0) : global::Lua.LuaValue.Nil;
            _lastArgPos = 0; _expectedType = typeof(global::LunyEditor.UnityEditor.SceneManagement.LuaStage);
            if (_arg0.TryRead<global::LunyEditor.UnityEditor.SceneManagement.LuaStage>(out var _p0_UnityEditor_SceneManagement_Stage))
            {
                var _arg1 = _lastArg = _argCount > 1 ? _context.GetArgument(1) : global::Lua.LuaValue.Nil;
                _lastArgPos = 1; _expectedType = typeof(global::System.Boolean);
                if (_arg1.TryRead<global::System.Boolean>(out var _p1_System_Boolean))
                {
                    if (_argCount == 2)
                    {
                        var stage = _p0_UnityEditor_SceneManagement_Stage.Instance;
                        var setAsFirstItemAfterMainStage = _p1_System_Boolean;
                        global::UnityEditor.SceneManagement.StageUtility.GoToStage(stage, setAsFirstItemAfterMainStage);
                        var _retCount = _context.Return();
                        return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                    }
                }
            }
            throw new global::Lua.LuaRuntimeException(_context.Thread, $"{"GoToStage"}: invalid argument #{_lastArgPos}: {_lastArg} ({_lastArg.Type}), expected: {_expectedType.FullName}", 2);
        });
        private static readonly global::Lua.LuaFunction _LuaStageUtility_IsGameObjectRenderedByCamera = new global::Lua.LuaFunction("IsGameObjectRenderedByCamera", (_context, _) =>
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
                _lastArgPos = 1; _expectedType = typeof(global::Luny.UnityEngine.LuaCamera);
                if (_arg1.TryRead<global::Luny.UnityEngine.LuaCamera>(out var _p1_UnityEngine_Camera))
                {
                    if (_argCount == 2)
                    {
                        var gameObject = _p0_UnityEngine_GameObject.Instance;
                        var camera = _p1_UnityEngine_Camera.Instance;
                        var _ret0 = global::UnityEditor.SceneManagement.StageUtility.IsGameObjectRenderedByCamera(gameObject, camera);
                        var _lret0 = new global::Lua.LuaValue(_ret0);
                        var _retCount = _context.Return(_lret0);
                        return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                    }
                }
            }
            throw new global::Lua.LuaRuntimeException(_context.Thread, $"{"IsGameObjectRenderedByCamera"}: invalid argument #{_lastArgPos}: {_lastArg} ({_lastArg.Type}), expected: {_expectedType.FullName}", 2);
        });
        private static readonly global::Lua.LuaFunction _LuaStageUtility_IsGameObjectRenderedByCameraAndPartOfEditableScene = new global::Lua.LuaFunction("IsGameObjectRenderedByCameraAndPartOfEditableScene", (_context, _) =>
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
                _lastArgPos = 1; _expectedType = typeof(global::Luny.UnityEngine.LuaCamera);
                if (_arg1.TryRead<global::Luny.UnityEngine.LuaCamera>(out var _p1_UnityEngine_Camera))
                {
                    if (_argCount == 2)
                    {
                        var gameObject = _p0_UnityEngine_GameObject.Instance;
                        var camera = _p1_UnityEngine_Camera.Instance;
                        var _ret0 = global::UnityEditor.SceneManagement.StageUtility.IsGameObjectRenderedByCameraAndPartOfEditableScene(gameObject, camera);
                        var _lret0 = new global::Lua.LuaValue(_ret0);
                        var _retCount = _context.Return(_lret0);
                        return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                    }
                }
            }
            throw new global::Lua.LuaRuntimeException(_context.Thread, $"{"IsGameObjectRenderedByCameraAndPartOfEditableScene"}: invalid argument #{_lastArgPos}: {_lastArg} ({_lastArg.Type}), expected: {_expectedType.FullName}", 2);
        });
        private static readonly global::Lua.LuaFunction _LuaStageUtility_PlaceGameObjectInCurrentStage = new global::Lua.LuaFunction("PlaceGameObjectInCurrentStage", (_context, _) =>
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
                    global::UnityEditor.SceneManagement.StageUtility.PlaceGameObjectInCurrentStage(gameObject);
                    var _retCount = _context.Return();
                    return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                }
            }
            throw new global::Lua.LuaRuntimeException(_context.Thread, $"{"PlaceGameObjectInCurrentStage"}: invalid argument #{_lastArgPos}: {_lastArg} ({_lastArg.Type}), expected: {_expectedType.FullName}", 2);
        });
        private static readonly global::Lua.LuaFunction __index = new(global::Lua.Runtime.Metamethods.Index, (_context, _) =>
        {
            var _this = _context.GetArgument<LuaStageUtilityType>(0);
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
            var _this = _context.GetArgument<LuaStageUtilityType>(0);
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
                case "GetCurrentStage": _value = _LuaStageUtility_GetCurrentStage; return true;
                case "GetCurrentStageHandle": _value = _LuaStageUtility_GetCurrentStageHandle; return true;
                case "GetMainStage": _value = _LuaStageUtility_GetMainStage; return true;
                case "GetMainStageHandle": _value = _LuaStageUtility_GetMainStageHandle; return true;
                case "GetStage": _value = _LuaStageUtility_GetStage; return true;
                case "GetStageHandle": _value = _LuaStageUtility_GetStageHandle; return true;
                case "GoBackToPreviousStage": _value = _LuaStageUtility_GoBackToPreviousStage; return true;
                case "GoToMainStage": _value = _LuaStageUtility_GoToMainStage; return true;
                case "GoToStage": _value = _LuaStageUtility_GoToStage; return true;
                case "IsGameObjectRenderedByCamera": _value = _LuaStageUtility_IsGameObjectRenderedByCamera; return true;
                case "IsGameObjectRenderedByCameraAndPartOfEditableScene": _value = _LuaStageUtility_IsGameObjectRenderedByCameraAndPartOfEditableScene; return true;
                case "PlaceGameObjectInCurrentStage": _value = _LuaStageUtility_PlaceGameObjectInCurrentStage; return true;
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
