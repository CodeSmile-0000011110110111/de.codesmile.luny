
// --------------------------------------------------------------
// GENERATED FILE ----> DO NOT EDIT <---- CHANGES WILL BE LOST !!
// --------------------------------------------------------------

#if UNITY_6000_0_OR_NEWER && !(UNITY_6000_1_OR_NEWER)
#pragma warning disable 0109, 0162, 0168, 0219
using Luny;

namespace Luny.UnityEngine.SceneManagement
{
    public class LuaSceneManager : global::Luny.ILuaObject<global::UnityEngine.SceneManagement.SceneManager>
    {
        public new static global::Lua.LuaValue Bind(global::UnityEngine.SceneManagement.SceneManager instance) => new LuaSceneManager(instance);
        public new static global::Lua.LuaValue Bind(global::System.Object instance) => Bind((global::UnityEngine.SceneManagement.SceneManager)instance);
        public new static global::Lua.LuaValue Bind(global::System.Collections.Generic.IList<global::UnityEngine.SceneManagement.SceneManager> instances) =>
            new global::Luny.LuaList<global::UnityEngine.SceneManagement.SceneManager>(instances);
        public new static global::Lua.LuaValue Bind(global::System.Collections.Generic.IList<global::System.Object> instances) =>
            new global::Luny.LuaList<global::UnityEngine.SceneManagement.SceneManager>(instances);
        protected LuaSceneManager(global::UnityEngine.SceneManagement.SceneManager instance) => m_Instance = instance;
        public static implicit operator global::Lua.LuaValue(LuaSceneManager value) => new(value);
        protected global::UnityEngine.SceneManagement.SceneManager m_Instance;
        public global::UnityEngine.SceneManagement.SceneManager Instance => m_Instance;
        public new global::System.Type BindType => typeof(global::UnityEngine.SceneManagement.SceneManager);
        public override global::System.String ToString() => m_Instance != null ? Instance.ToString() : "{GetType().Name}(null)";
#if UNITY_EDITOR
        [global::UnityEngine.RuntimeInitializeOnLoadMethod(global::UnityEngine.RuntimeInitializeLoadType.SubsystemRegistration)]
        private static void ResetStaticFields() => s_Metatable = null;
#endif

        private static readonly global::Lua.LuaFunction __index = new(global::Lua.Runtime.Metamethods.Index, (_context, _) =>
        {
            var _this = _context.GetArgument<LuaSceneManager>(0);
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
            var _this = _context.GetArgument<LuaSceneManager>(0);
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
    public sealed class LuaSceneManagerType : global::Luny.ILuaStatic
    {
        public static global::Lua.LuaValue Bind() => new LuaSceneManagerType();
        private LuaSceneManagerType() {}
        public static implicit operator global::Lua.LuaValue(LuaSceneManagerType value) => new(value);
        public global::System.Type BindType => typeof(global::UnityEngine.SceneManagement.SceneManager);
        public override global::System.String ToString() => BindType.FullName;
#if UNITY_EDITOR
        [global::UnityEngine.RuntimeInitializeOnLoadMethod(global::UnityEngine.RuntimeInitializeLoadType.SubsystemRegistration)]
        private static void ResetStaticFields() => s_Metatable = null;
#endif

        private static readonly global::Lua.LuaFunction _LuaSceneManager_new = new global::Lua.LuaFunction(".ctor", (_context, _) =>
        {
            global::Lua.LuaValue _lastArg = default;
            global::System.Int32 _lastArgPos = default;
            global::System.Type _expectedType = default;
            var _argCount = _context.ArgumentCount;
            if (_argCount == 1)
            {
                var _ret0 = new global::UnityEngine.SceneManagement.SceneManager();
                var _factory = _context.GetObjectFactory();
                var _lret0 = _factory.Bind(_ret0);
                var _retCount = _context.Return(_lret0);
                return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
            }
            throw new global::Lua.LuaRuntimeException(_context.Thread, $"{".ctor"}: invalid argument #{_lastArgPos}: {_lastArg} ({_lastArg.Type}), expected: {_expectedType.FullName}", 2);
        });
        private static readonly global::Lua.LuaFunction _LuaSceneManager_CreateScene = new global::Lua.LuaFunction("CreateScene", (_context, _) =>
        {
            global::Lua.LuaValue _lastArg = default;
            global::System.Int32 _lastArgPos = default;
            global::System.Type _expectedType = default;
            var _argCount = _context.ArgumentCount;
            var _arg0 = _lastArg = _argCount > 0 ? _context.GetArgument(0) : global::Lua.LuaValue.Nil;
            _lastArgPos = 0; _expectedType = typeof(global::System.String);
            if (_arg0.TryRead<global::System.String>(out var _p0_System_String))
            {
                if (_argCount == 1)
                {
                    var sceneName = _p0_System_String;
                    var _ret0 = global::UnityEngine.SceneManagement.SceneManager.CreateScene(sceneName);
                    var _lret0 = global::Luny.UnityEngine.SceneManagement.LuaScene.Bind(_ret0);
                    var _retCount = _context.Return(_lret0);
                    return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                }
                var _arg1 = _lastArg = _argCount > 1 ? _context.GetArgument(1) : global::Lua.LuaValue.Nil;
                _lastArgPos = 1; _expectedType = typeof(global::Luny.UnityEngine.SceneManagement.LuaCreateSceneParameters);
                if (_arg1.TryRead<global::Luny.UnityEngine.SceneManagement.LuaCreateSceneParameters>(out var _p1_UnityEngine_SceneManagement_CreateSceneParameters))
                {
                    if (_argCount == 2)
                    {
                        var sceneName = _p0_System_String;
                        var parameters = _p1_UnityEngine_SceneManagement_CreateSceneParameters.Value;
                        var _ret0 = global::UnityEngine.SceneManagement.SceneManager.CreateScene(sceneName, parameters);
                        var _lret0 = global::Luny.UnityEngine.SceneManagement.LuaScene.Bind(_ret0);
                        var _retCount = _context.Return(_lret0);
                        return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                    }
                }
            }
            throw new global::Lua.LuaRuntimeException(_context.Thread, $"{"CreateScene"}: invalid argument #{_lastArgPos}: {_lastArg} ({_lastArg.Type}), expected: {_expectedType.FullName}", 2);
        });
        private static readonly global::Lua.LuaFunction _LuaSceneManager_GetActiveScene = new global::Lua.LuaFunction("GetActiveScene", (_context, _) =>
        {
            global::Lua.LuaValue _lastArg = default;
            global::System.Int32 _lastArgPos = default;
            global::System.Type _expectedType = default;
            var _argCount = _context.ArgumentCount;
            if (_argCount == 0)
            {
                var _ret0 = global::UnityEngine.SceneManagement.SceneManager.GetActiveScene();
                var _lret0 = global::Luny.UnityEngine.SceneManagement.LuaScene.Bind(_ret0);
                var _retCount = _context.Return(_lret0);
                return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
            }
            throw new global::Lua.LuaRuntimeException(_context.Thread, $"{"GetActiveScene"}: invalid argument #{_lastArgPos}: {_lastArg} ({_lastArg.Type}), expected: {_expectedType.FullName}", 2);
        });
        private static readonly global::Lua.LuaFunction _LuaSceneManager_GetSceneAt = new global::Lua.LuaFunction("GetSceneAt", (_context, _) =>
        {
            global::Lua.LuaValue _lastArg = default;
            global::System.Int32 _lastArgPos = default;
            global::System.Type _expectedType = default;
            var _argCount = _context.ArgumentCount;
            var _arg0 = _lastArg = _argCount > 0 ? _context.GetArgument(0) : global::Lua.LuaValue.Nil;
            _lastArgPos = 0; _expectedType = typeof(global::System.Int32);
            if (_arg0.TryRead<global::System.Int32>(out var _p0_System_Int32))
            {
                if (_argCount == 1)
                {
                    var index = _p0_System_Int32;
                    var _ret0 = global::UnityEngine.SceneManagement.SceneManager.GetSceneAt(index);
                    var _lret0 = global::Luny.UnityEngine.SceneManagement.LuaScene.Bind(_ret0);
                    var _retCount = _context.Return(_lret0);
                    return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                }
            }
            throw new global::Lua.LuaRuntimeException(_context.Thread, $"{"GetSceneAt"}: invalid argument #{_lastArgPos}: {_lastArg} ({_lastArg.Type}), expected: {_expectedType.FullName}", 2);
        });
        private static readonly global::Lua.LuaFunction _LuaSceneManager_GetSceneByBuildIndex = new global::Lua.LuaFunction("GetSceneByBuildIndex", (_context, _) =>
        {
            global::Lua.LuaValue _lastArg = default;
            global::System.Int32 _lastArgPos = default;
            global::System.Type _expectedType = default;
            var _argCount = _context.ArgumentCount;
            var _arg0 = _lastArg = _argCount > 0 ? _context.GetArgument(0) : global::Lua.LuaValue.Nil;
            _lastArgPos = 0; _expectedType = typeof(global::System.Int32);
            if (_arg0.TryRead<global::System.Int32>(out var _p0_System_Int32))
            {
                if (_argCount == 1)
                {
                    var buildIndex = _p0_System_Int32;
                    var _ret0 = global::UnityEngine.SceneManagement.SceneManager.GetSceneByBuildIndex(buildIndex);
                    var _lret0 = global::Luny.UnityEngine.SceneManagement.LuaScene.Bind(_ret0);
                    var _retCount = _context.Return(_lret0);
                    return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                }
            }
            throw new global::Lua.LuaRuntimeException(_context.Thread, $"{"GetSceneByBuildIndex"}: invalid argument #{_lastArgPos}: {_lastArg} ({_lastArg.Type}), expected: {_expectedType.FullName}", 2);
        });
        private static readonly global::Lua.LuaFunction _LuaSceneManager_GetSceneByName = new global::Lua.LuaFunction("GetSceneByName", (_context, _) =>
        {
            global::Lua.LuaValue _lastArg = default;
            global::System.Int32 _lastArgPos = default;
            global::System.Type _expectedType = default;
            var _argCount = _context.ArgumentCount;
            var _arg0 = _lastArg = _argCount > 0 ? _context.GetArgument(0) : global::Lua.LuaValue.Nil;
            _lastArgPos = 0; _expectedType = typeof(global::System.String);
            if (_arg0.TryRead<global::System.String>(out var _p0_System_String))
            {
                if (_argCount == 1)
                {
                    var name = _p0_System_String;
                    var _ret0 = global::UnityEngine.SceneManagement.SceneManager.GetSceneByName(name);
                    var _lret0 = global::Luny.UnityEngine.SceneManagement.LuaScene.Bind(_ret0);
                    var _retCount = _context.Return(_lret0);
                    return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                }
            }
            throw new global::Lua.LuaRuntimeException(_context.Thread, $"{"GetSceneByName"}: invalid argument #{_lastArgPos}: {_lastArg} ({_lastArg.Type}), expected: {_expectedType.FullName}", 2);
        });
        private static readonly global::Lua.LuaFunction _LuaSceneManager_GetSceneByPath = new global::Lua.LuaFunction("GetSceneByPath", (_context, _) =>
        {
            global::Lua.LuaValue _lastArg = default;
            global::System.Int32 _lastArgPos = default;
            global::System.Type _expectedType = default;
            var _argCount = _context.ArgumentCount;
            var _arg0 = _lastArg = _argCount > 0 ? _context.GetArgument(0) : global::Lua.LuaValue.Nil;
            _lastArgPos = 0; _expectedType = typeof(global::System.String);
            if (_arg0.TryRead<global::System.String>(out var _p0_System_String))
            {
                if (_argCount == 1)
                {
                    var scenePath = _p0_System_String;
                    var _ret0 = global::UnityEngine.SceneManagement.SceneManager.GetSceneByPath(scenePath);
                    var _lret0 = global::Luny.UnityEngine.SceneManagement.LuaScene.Bind(_ret0);
                    var _retCount = _context.Return(_lret0);
                    return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                }
            }
            throw new global::Lua.LuaRuntimeException(_context.Thread, $"{"GetSceneByPath"}: invalid argument #{_lastArgPos}: {_lastArg} ({_lastArg.Type}), expected: {_expectedType.FullName}", 2);
        });
        private static readonly global::Lua.LuaFunction _LuaSceneManager_LoadScene = new global::Lua.LuaFunction("LoadScene", (_context, _) =>
        {
            global::Lua.LuaValue _lastArg = default;
            global::System.Int32 _lastArgPos = default;
            global::System.Type _expectedType = default;
            var _argCount = _context.ArgumentCount;
            var _arg0 = _lastArg = _argCount > 0 ? _context.GetArgument(0) : global::Lua.LuaValue.Nil;
            _lastArgPos = 0; _expectedType = typeof(global::System.Int32);
            if (_arg0.TryRead<global::System.Int32>(out var _p0_System_Int32))
            {
                if (_argCount == 1)
                {
                    var sceneBuildIndex = _p0_System_Int32;
                    global::UnityEngine.SceneManagement.SceneManager.LoadScene(sceneBuildIndex);
                    var _retCount = _context.Return();
                    return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                }
                var _arg1 = _lastArg = _argCount > 1 ? _context.GetArgument(1) : global::Lua.LuaValue.Nil;
                _lastArgPos = 1; _expectedType = typeof(global::UnityEngine.SceneManagement.LoadSceneMode);
                if (_arg1.TryRead<global::UnityEngine.SceneManagement.LoadSceneMode>(out var _p1_UnityEngine_SceneManagement_LoadSceneMode))
                {
                    if (_argCount == 2)
                    {
                        var sceneBuildIndex = _p0_System_Int32;
                        var mode = _p1_UnityEngine_SceneManagement_LoadSceneMode;
                        global::UnityEngine.SceneManagement.SceneManager.LoadScene(sceneBuildIndex, mode);
                        var _retCount = _context.Return();
                        return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                    }
                }
                _lastArgPos = 1; _expectedType = typeof(global::Luny.UnityEngine.SceneManagement.LuaLoadSceneParameters);
                if (_arg1.TryRead<global::Luny.UnityEngine.SceneManagement.LuaLoadSceneParameters>(out var _p1_UnityEngine_SceneManagement_LoadSceneParameters))
                {
                    if (_argCount == 2)
                    {
                        var sceneBuildIndex = _p0_System_Int32;
                        var parameters = _p1_UnityEngine_SceneManagement_LoadSceneParameters.Value;
                        var _ret0 = global::UnityEngine.SceneManagement.SceneManager.LoadScene(sceneBuildIndex, parameters);
                        var _lret0 = global::Luny.UnityEngine.SceneManagement.LuaScene.Bind(_ret0);
                        var _retCount = _context.Return(_lret0);
                        return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                    }
                }
            }
            _lastArgPos = 0; _expectedType = typeof(global::System.String);
            if (_arg0.TryRead<global::System.String>(out var _p0_System_String))
            {
                if (_argCount == 1)
                {
                    var sceneName = _p0_System_String;
                    global::UnityEngine.SceneManagement.SceneManager.LoadScene(sceneName);
                    var _retCount = _context.Return();
                    return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                }
                var _arg1 = _lastArg = _argCount > 1 ? _context.GetArgument(1) : global::Lua.LuaValue.Nil;
                _lastArgPos = 1; _expectedType = typeof(global::UnityEngine.SceneManagement.LoadSceneMode);
                if (_arg1.TryRead<global::UnityEngine.SceneManagement.LoadSceneMode>(out var _p1_UnityEngine_SceneManagement_LoadSceneMode))
                {
                    if (_argCount == 2)
                    {
                        var sceneName = _p0_System_String;
                        var mode = _p1_UnityEngine_SceneManagement_LoadSceneMode;
                        global::UnityEngine.SceneManagement.SceneManager.LoadScene(sceneName, mode);
                        var _retCount = _context.Return();
                        return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                    }
                }
                _lastArgPos = 1; _expectedType = typeof(global::Luny.UnityEngine.SceneManagement.LuaLoadSceneParameters);
                if (_arg1.TryRead<global::Luny.UnityEngine.SceneManagement.LuaLoadSceneParameters>(out var _p1_UnityEngine_SceneManagement_LoadSceneParameters))
                {
                    if (_argCount == 2)
                    {
                        var sceneName = _p0_System_String;
                        var parameters = _p1_UnityEngine_SceneManagement_LoadSceneParameters.Value;
                        var _ret0 = global::UnityEngine.SceneManagement.SceneManager.LoadScene(sceneName, parameters);
                        var _lret0 = global::Luny.UnityEngine.SceneManagement.LuaScene.Bind(_ret0);
                        var _retCount = _context.Return(_lret0);
                        return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                    }
                }
            }
            throw new global::Lua.LuaRuntimeException(_context.Thread, $"{"LoadScene"}: invalid argument #{_lastArgPos}: {_lastArg} ({_lastArg.Type}), expected: {_expectedType.FullName}", 2);
        });
        private static readonly global::Lua.LuaFunction _LuaSceneManager_LoadSceneAsync = new global::Lua.LuaFunction("LoadSceneAsync", (_context, _) =>
        {
            global::Lua.LuaValue _lastArg = default;
            global::System.Int32 _lastArgPos = default;
            global::System.Type _expectedType = default;
            var _argCount = _context.ArgumentCount;
            var _arg0 = _lastArg = _argCount > 0 ? _context.GetArgument(0) : global::Lua.LuaValue.Nil;
            _lastArgPos = 0; _expectedType = typeof(global::System.Int32);
            if (_arg0.TryRead<global::System.Int32>(out var _p0_System_Int32))
            {
                if (_argCount == 1)
                {
                    var sceneBuildIndex = _p0_System_Int32;
                    var _ret0 = global::UnityEngine.SceneManagement.SceneManager.LoadSceneAsync(sceneBuildIndex);
                    var _factory = _context.GetObjectFactory();
                    var _lret0 = _factory.Bind(_ret0);
                    var _retCount = _context.Return(_lret0);
                    return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                }
                var _arg1 = _lastArg = _argCount > 1 ? _context.GetArgument(1) : global::Lua.LuaValue.Nil;
                _lastArgPos = 1; _expectedType = typeof(global::UnityEngine.SceneManagement.LoadSceneMode);
                if (_arg1.TryRead<global::UnityEngine.SceneManagement.LoadSceneMode>(out var _p1_UnityEngine_SceneManagement_LoadSceneMode))
                {
                    if (_argCount == 2)
                    {
                        var sceneBuildIndex = _p0_System_Int32;
                        var mode = _p1_UnityEngine_SceneManagement_LoadSceneMode;
                        var _ret0 = global::UnityEngine.SceneManagement.SceneManager.LoadSceneAsync(sceneBuildIndex, mode);
                        var _factory = _context.GetObjectFactory();
                        var _lret0 = _factory.Bind(_ret0);
                        var _retCount = _context.Return(_lret0);
                        return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                    }
                }
                _lastArgPos = 1; _expectedType = typeof(global::Luny.UnityEngine.SceneManagement.LuaLoadSceneParameters);
                if (_arg1.TryRead<global::Luny.UnityEngine.SceneManagement.LuaLoadSceneParameters>(out var _p1_UnityEngine_SceneManagement_LoadSceneParameters))
                {
                    if (_argCount == 2)
                    {
                        var sceneBuildIndex = _p0_System_Int32;
                        var parameters = _p1_UnityEngine_SceneManagement_LoadSceneParameters.Value;
                        var _ret0 = global::UnityEngine.SceneManagement.SceneManager.LoadSceneAsync(sceneBuildIndex, parameters);
                        var _factory = _context.GetObjectFactory();
                        var _lret0 = _factory.Bind(_ret0);
                        var _retCount = _context.Return(_lret0);
                        return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                    }
                }
            }
            _lastArgPos = 0; _expectedType = typeof(global::System.String);
            if (_arg0.TryRead<global::System.String>(out var _p0_System_String))
            {
                if (_argCount == 1)
                {
                    var sceneName = _p0_System_String;
                    var _ret0 = global::UnityEngine.SceneManagement.SceneManager.LoadSceneAsync(sceneName);
                    var _factory = _context.GetObjectFactory();
                    var _lret0 = _factory.Bind(_ret0);
                    var _retCount = _context.Return(_lret0);
                    return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                }
                var _arg1 = _lastArg = _argCount > 1 ? _context.GetArgument(1) : global::Lua.LuaValue.Nil;
                _lastArgPos = 1; _expectedType = typeof(global::UnityEngine.SceneManagement.LoadSceneMode);
                if (_arg1.TryRead<global::UnityEngine.SceneManagement.LoadSceneMode>(out var _p1_UnityEngine_SceneManagement_LoadSceneMode))
                {
                    if (_argCount == 2)
                    {
                        var sceneName = _p0_System_String;
                        var mode = _p1_UnityEngine_SceneManagement_LoadSceneMode;
                        var _ret0 = global::UnityEngine.SceneManagement.SceneManager.LoadSceneAsync(sceneName, mode);
                        var _factory = _context.GetObjectFactory();
                        var _lret0 = _factory.Bind(_ret0);
                        var _retCount = _context.Return(_lret0);
                        return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                    }
                }
                _lastArgPos = 1; _expectedType = typeof(global::Luny.UnityEngine.SceneManagement.LuaLoadSceneParameters);
                if (_arg1.TryRead<global::Luny.UnityEngine.SceneManagement.LuaLoadSceneParameters>(out var _p1_UnityEngine_SceneManagement_LoadSceneParameters))
                {
                    if (_argCount == 2)
                    {
                        var sceneName = _p0_System_String;
                        var parameters = _p1_UnityEngine_SceneManagement_LoadSceneParameters.Value;
                        var _ret0 = global::UnityEngine.SceneManagement.SceneManager.LoadSceneAsync(sceneName, parameters);
                        var _factory = _context.GetObjectFactory();
                        var _lret0 = _factory.Bind(_ret0);
                        var _retCount = _context.Return(_lret0);
                        return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                    }
                }
            }
            throw new global::Lua.LuaRuntimeException(_context.Thread, $"{"LoadSceneAsync"}: invalid argument #{_lastArgPos}: {_lastArg} ({_lastArg.Type}), expected: {_expectedType.FullName}", 2);
        });
        private static readonly global::Lua.LuaFunction _LuaSceneManager_MergeScenes = new global::Lua.LuaFunction("MergeScenes", (_context, _) =>
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
                _lastArgPos = 1; _expectedType = typeof(global::Luny.UnityEngine.SceneManagement.LuaScene);
                if (_arg1.TryRead<global::Luny.UnityEngine.SceneManagement.LuaScene>(out var _p1_UnityEngine_SceneManagement_Scene))
                {
                    if (_argCount == 2)
                    {
                        var sourceScene = _p0_UnityEngine_SceneManagement_Scene.Value;
                        var destinationScene = _p1_UnityEngine_SceneManagement_Scene.Value;
                        global::UnityEngine.SceneManagement.SceneManager.MergeScenes(sourceScene, destinationScene);
                        var _retCount = _context.Return();
                        return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                    }
                }
            }
            throw new global::Lua.LuaRuntimeException(_context.Thread, $"{"MergeScenes"}: invalid argument #{_lastArgPos}: {_lastArg} ({_lastArg.Type}), expected: {_expectedType.FullName}", 2);
        });
        private static readonly global::Lua.LuaFunction _LuaSceneManager_MoveGameObjectToScene = new global::Lua.LuaFunction("MoveGameObjectToScene", (_context, _) =>
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
                _lastArgPos = 1; _expectedType = typeof(global::Luny.UnityEngine.SceneManagement.LuaScene);
                if (_arg1.TryRead<global::Luny.UnityEngine.SceneManagement.LuaScene>(out var _p1_UnityEngine_SceneManagement_Scene))
                {
                    if (_argCount == 2)
                    {
                        var go = _p0_UnityEngine_GameObject.Instance;
                        var scene = _p1_UnityEngine_SceneManagement_Scene.Value;
                        global::UnityEngine.SceneManagement.SceneManager.MoveGameObjectToScene(go, scene);
                        var _retCount = _context.Return();
                        return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                    }
                }
            }
            throw new global::Lua.LuaRuntimeException(_context.Thread, $"{"MoveGameObjectToScene"}: invalid argument #{_lastArgPos}: {_lastArg} ({_lastArg.Type}), expected: {_expectedType.FullName}", 2);
        });
        private static readonly global::Lua.LuaFunction _LuaSceneManager_SetActiveScene = new global::Lua.LuaFunction("SetActiveScene", (_context, _) =>
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
                    var _ret0 = global::UnityEngine.SceneManagement.SceneManager.SetActiveScene(scene);
                    var _lret0 = new global::Lua.LuaValue(_ret0);
                    var _retCount = _context.Return(_lret0);
                    return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                }
            }
            throw new global::Lua.LuaRuntimeException(_context.Thread, $"{"SetActiveScene"}: invalid argument #{_lastArgPos}: {_lastArg} ({_lastArg.Type}), expected: {_expectedType.FullName}", 2);
        });
        private static readonly global::Lua.LuaFunction _LuaSceneManager_UnloadSceneAsync = new global::Lua.LuaFunction("UnloadSceneAsync", (_context, _) =>
        {
            global::Lua.LuaValue _lastArg = default;
            global::System.Int32 _lastArgPos = default;
            global::System.Type _expectedType = default;
            var _argCount = _context.ArgumentCount;
            var _arg0 = _lastArg = _argCount > 0 ? _context.GetArgument(0) : global::Lua.LuaValue.Nil;
            _lastArgPos = 0; _expectedType = typeof(global::System.Int32);
            if (_arg0.TryRead<global::System.Int32>(out var _p0_System_Int32))
            {
                if (_argCount == 1)
                {
                    var sceneBuildIndex = _p0_System_Int32;
                    var _ret0 = global::UnityEngine.SceneManagement.SceneManager.UnloadSceneAsync(sceneBuildIndex);
                    var _factory = _context.GetObjectFactory();
                    var _lret0 = _factory.Bind(_ret0);
                    var _retCount = _context.Return(_lret0);
                    return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                }
                var _arg1 = _lastArg = _argCount > 1 ? _context.GetArgument(1) : global::Lua.LuaValue.Nil;
                _lastArgPos = 1; _expectedType = typeof(global::UnityEngine.SceneManagement.UnloadSceneOptions);
                if (_arg1.TryRead<global::UnityEngine.SceneManagement.UnloadSceneOptions>(out var _p1_UnityEngine_SceneManagement_UnloadSceneOptions))
                {
                    if (_argCount == 2)
                    {
                        var sceneBuildIndex = _p0_System_Int32;
                        var options = _p1_UnityEngine_SceneManagement_UnloadSceneOptions;
                        var _ret0 = global::UnityEngine.SceneManagement.SceneManager.UnloadSceneAsync(sceneBuildIndex, options);
                        var _factory = _context.GetObjectFactory();
                        var _lret0 = _factory.Bind(_ret0);
                        var _retCount = _context.Return(_lret0);
                        return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                    }
                }
            }
            _lastArgPos = 0; _expectedType = typeof(global::Luny.UnityEngine.SceneManagement.LuaScene);
            if (_arg0.TryRead<global::Luny.UnityEngine.SceneManagement.LuaScene>(out var _p0_UnityEngine_SceneManagement_Scene))
            {
                if (_argCount == 1)
                {
                    var scene = _p0_UnityEngine_SceneManagement_Scene.Value;
                    var _ret0 = global::UnityEngine.SceneManagement.SceneManager.UnloadSceneAsync(scene);
                    var _factory = _context.GetObjectFactory();
                    var _lret0 = _factory.Bind(_ret0);
                    var _retCount = _context.Return(_lret0);
                    return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                }
                var _arg1 = _lastArg = _argCount > 1 ? _context.GetArgument(1) : global::Lua.LuaValue.Nil;
                _lastArgPos = 1; _expectedType = typeof(global::UnityEngine.SceneManagement.UnloadSceneOptions);
                if (_arg1.TryRead<global::UnityEngine.SceneManagement.UnloadSceneOptions>(out var _p1_UnityEngine_SceneManagement_UnloadSceneOptions))
                {
                    if (_argCount == 2)
                    {
                        var scene = _p0_UnityEngine_SceneManagement_Scene.Value;
                        var options = _p1_UnityEngine_SceneManagement_UnloadSceneOptions;
                        var _ret0 = global::UnityEngine.SceneManagement.SceneManager.UnloadSceneAsync(scene, options);
                        var _factory = _context.GetObjectFactory();
                        var _lret0 = _factory.Bind(_ret0);
                        var _retCount = _context.Return(_lret0);
                        return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                    }
                }
            }
            _lastArgPos = 0; _expectedType = typeof(global::System.String);
            if (_arg0.TryRead<global::System.String>(out var _p0_System_String))
            {
                if (_argCount == 1)
                {
                    var sceneName = _p0_System_String;
                    var _ret0 = global::UnityEngine.SceneManagement.SceneManager.UnloadSceneAsync(sceneName);
                    var _factory = _context.GetObjectFactory();
                    var _lret0 = _factory.Bind(_ret0);
                    var _retCount = _context.Return(_lret0);
                    return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                }
                var _arg1 = _lastArg = _argCount > 1 ? _context.GetArgument(1) : global::Lua.LuaValue.Nil;
                _lastArgPos = 1; _expectedType = typeof(global::UnityEngine.SceneManagement.UnloadSceneOptions);
                if (_arg1.TryRead<global::UnityEngine.SceneManagement.UnloadSceneOptions>(out var _p1_UnityEngine_SceneManagement_UnloadSceneOptions))
                {
                    if (_argCount == 2)
                    {
                        var sceneName = _p0_System_String;
                        var options = _p1_UnityEngine_SceneManagement_UnloadSceneOptions;
                        var _ret0 = global::UnityEngine.SceneManagement.SceneManager.UnloadSceneAsync(sceneName, options);
                        var _factory = _context.GetObjectFactory();
                        var _lret0 = _factory.Bind(_ret0);
                        var _retCount = _context.Return(_lret0);
                        return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                    }
                }
            }
            throw new global::Lua.LuaRuntimeException(_context.Thread, $"{"UnloadSceneAsync"}: invalid argument #{_lastArgPos}: {_lastArg} ({_lastArg.Type}), expected: {_expectedType.FullName}", 2);
        });
        private static readonly global::Lua.LuaFunction __index = new(global::Lua.Runtime.Metamethods.Index, (_context, _) =>
        {
            var _this = _context.GetArgument<LuaSceneManagerType>(0);
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
            var _this = _context.GetArgument<LuaSceneManagerType>(0);
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
            metatable[global::Lua.Runtime.Metamethods.Call] = _LuaSceneManager_new;
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
                case "CreateScene": _value = _LuaSceneManager_CreateScene; return true;
                case "GetActiveScene": _value = _LuaSceneManager_GetActiveScene; return true;
                case "GetSceneAt": _value = _LuaSceneManager_GetSceneAt; return true;
                case "GetSceneByBuildIndex": _value = _LuaSceneManager_GetSceneByBuildIndex; return true;
                case "GetSceneByName": _value = _LuaSceneManager_GetSceneByName; return true;
                case "GetSceneByPath": _value = _LuaSceneManager_GetSceneByPath; return true;
                case "LoadScene": _value = _LuaSceneManager_LoadScene; return true;
                case "LoadSceneAsync": _value = _LuaSceneManager_LoadSceneAsync; return true;
                case "MergeScenes": _value = _LuaSceneManager_MergeScenes; return true;
                case "MoveGameObjectToScene": _value = _LuaSceneManager_MoveGameObjectToScene; return true;
                case "SetActiveScene": _value = _LuaSceneManager_SetActiveScene; return true;
                case "UnloadSceneAsync": _value = _LuaSceneManager_UnloadSceneAsync; return true;
                case "loadedSceneCount": _value = new global::Lua.LuaValue(global::UnityEngine.SceneManagement.SceneManager.loadedSceneCount); return true;
                case "sceneCount": _value = new global::Lua.LuaValue(global::UnityEngine.SceneManagement.SceneManager.sceneCount); return true;
                case "sceneCountInBuildSettings": _value = new global::Lua.LuaValue(global::UnityEngine.SceneManagement.SceneManager.sceneCountInBuildSettings); return true;
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
