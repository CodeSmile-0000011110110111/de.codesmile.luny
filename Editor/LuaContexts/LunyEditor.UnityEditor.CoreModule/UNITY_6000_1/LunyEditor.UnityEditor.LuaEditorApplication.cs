
// --------------------------------------------------------------
// GENERATED FILE ----> DO NOT EDIT <---- CHANGES WILL BE LOST !!
// --------------------------------------------------------------

#if UNITY_6000_1_OR_NEWER && !(UNITY_6000_2_OR_NEWER)
#pragma warning disable 0109, 0162, 0168, 0219
using Luny;

namespace LunyEditor.UnityEditor
{
    public sealed class LuaEditorApplication : global::Luny.ILuaObject<global::UnityEditor.EditorApplication>
    {
        public new static global::Lua.LuaValue Bind(global::UnityEditor.EditorApplication instance) => new LuaEditorApplication(instance);
        public new static global::Lua.LuaValue Bind(global::System.Object instance) => Bind((global::UnityEditor.EditorApplication)instance);
        public new static global::Lua.LuaValue Bind(global::System.Collections.Generic.IList<global::UnityEditor.EditorApplication> instances) =>
            new global::Luny.LuaList<global::UnityEditor.EditorApplication>(instances);
        public new static global::Lua.LuaValue Bind(global::System.Collections.Generic.IList<global::System.Object> instances) =>
            new global::Luny.LuaList<global::UnityEditor.EditorApplication>(instances);
        private LuaEditorApplication(global::UnityEditor.EditorApplication instance) => m_Instance = instance;
        public static implicit operator global::Lua.LuaValue(LuaEditorApplication value) => new(value);
        private global::UnityEditor.EditorApplication m_Instance;
        public global::UnityEditor.EditorApplication Instance => m_Instance;
        public new global::System.Type BindType => typeof(global::UnityEditor.EditorApplication);
        public override global::System.String ToString() => m_Instance != null ? Instance.ToString() : "{GetType().Name}(null)";
#if UNITY_EDITOR
        [global::UnityEngine.RuntimeInitializeOnLoadMethod(global::UnityEngine.RuntimeInitializeLoadType.SubsystemRegistration)]
        private static void ResetStaticFields() => s_Metatable = null;
#endif

        private static readonly global::Lua.LuaFunction __index = new(global::Lua.Runtime.Metamethods.Index, (_context, _) =>
        {
            var _this = _context.GetArgument<LuaEditorApplication>(0);
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
            var _this = _context.GetArgument<LuaEditorApplication>(0);
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
    public sealed class LuaEditorApplicationType : global::Luny.ILuaStatic
    {
        public static global::Lua.LuaValue Bind() => new LuaEditorApplicationType();
        private LuaEditorApplicationType() {}
        public static implicit operator global::Lua.LuaValue(LuaEditorApplicationType value) => new(value);
        public global::System.Type BindType => typeof(global::UnityEditor.EditorApplication);
        public override global::System.String ToString() => BindType.FullName;
#if UNITY_EDITOR
        [global::UnityEngine.RuntimeInitializeOnLoadMethod(global::UnityEngine.RuntimeInitializeLoadType.SubsystemRegistration)]
        private static void ResetStaticFields() => s_Metatable = null;
#endif

        private static readonly global::Lua.LuaFunction _LuaEditorApplication_new = new global::Lua.LuaFunction(".ctor", (_context, _) =>
        {
            global::Lua.LuaValue _lastArg = default;
            global::System.Int32 _lastArgPos = default;
            global::System.Type _expectedType = default;
            var _argCount = _context.ArgumentCount;
            if (_argCount == 1)
            {
                var _ret0 = new global::UnityEditor.EditorApplication();
                var _factory = _context.GetObjectFactory();
                var _lret0 = _factory.Bind(_ret0);
                var _retCount = _context.Return(_lret0);
                return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
            }
            throw new global::Lua.LuaRuntimeException(_context.Thread, $"{".ctor"}: invalid argument #{_lastArgPos}: {_lastArg} ({_lastArg.Type}), expected: {_expectedType.FullName}", 2);
        });
        private static readonly global::Lua.LuaFunction _LuaEditorApplication_Beep = new global::Lua.LuaFunction("Beep", (_context, _) =>
        {
            global::Lua.LuaValue _lastArg = default;
            global::System.Int32 _lastArgPos = default;
            global::System.Type _expectedType = default;
            var _argCount = _context.ArgumentCount;
            if (_argCount == 0)
            {
                global::UnityEditor.EditorApplication.Beep();
                var _retCount = _context.Return();
                return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
            }
            throw new global::Lua.LuaRuntimeException(_context.Thread, $"{"Beep"}: invalid argument #{_lastArgPos}: {_lastArg} ({_lastArg.Type}), expected: {_expectedType.FullName}", 2);
        });
        private static readonly global::Lua.LuaFunction _LuaEditorApplication_DirtyHierarchyWindowSorting = new global::Lua.LuaFunction("DirtyHierarchyWindowSorting", (_context, _) =>
        {
            global::Lua.LuaValue _lastArg = default;
            global::System.Int32 _lastArgPos = default;
            global::System.Type _expectedType = default;
            var _argCount = _context.ArgumentCount;
            if (_argCount == 0)
            {
                global::UnityEditor.EditorApplication.DirtyHierarchyWindowSorting();
                var _retCount = _context.Return();
                return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
            }
            throw new global::Lua.LuaRuntimeException(_context.Thread, $"{"DirtyHierarchyWindowSorting"}: invalid argument #{_lastArgPos}: {_lastArg} ({_lastArg.Type}), expected: {_expectedType.FullName}", 2);
        });
        private static readonly global::Lua.LuaFunction _LuaEditorApplication_EnterPlaymode = new global::Lua.LuaFunction("EnterPlaymode", (_context, _) =>
        {
            global::Lua.LuaValue _lastArg = default;
            global::System.Int32 _lastArgPos = default;
            global::System.Type _expectedType = default;
            var _argCount = _context.ArgumentCount;
            if (_argCount == 0)
            {
                global::UnityEditor.EditorApplication.EnterPlaymode();
                var _retCount = _context.Return();
                return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
            }
            throw new global::Lua.LuaRuntimeException(_context.Thread, $"{"EnterPlaymode"}: invalid argument #{_lastArgPos}: {_lastArg} ({_lastArg.Type}), expected: {_expectedType.FullName}", 2);
        });
        private static readonly global::Lua.LuaFunction _LuaEditorApplication_ExecuteMenuItem = new global::Lua.LuaFunction("ExecuteMenuItem", (_context, _) =>
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
                    var menuItemPath = _p0_System_String;
                    var _ret0 = global::UnityEditor.EditorApplication.ExecuteMenuItem(menuItemPath);
                    var _lret0 = new global::Lua.LuaValue(_ret0);
                    var _retCount = _context.Return(_lret0);
                    return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                }
            }
            throw new global::Lua.LuaRuntimeException(_context.Thread, $"{"ExecuteMenuItem"}: invalid argument #{_lastArgPos}: {_lastArg} ({_lastArg.Type}), expected: {_expectedType.FullName}", 2);
        });
        private static readonly global::Lua.LuaFunction _LuaEditorApplication_Exit = new global::Lua.LuaFunction("Exit", (_context, _) =>
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
                    var returnValue = _p0_System_Int32;
                    global::UnityEditor.EditorApplication.Exit(returnValue);
                    var _retCount = _context.Return();
                    return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                }
            }
            throw new global::Lua.LuaRuntimeException(_context.Thread, $"{"Exit"}: invalid argument #{_lastArgPos}: {_lastArg} ({_lastArg.Type}), expected: {_expectedType.FullName}", 2);
        });
        private static readonly global::Lua.LuaFunction _LuaEditorApplication_ExitPlaymode = new global::Lua.LuaFunction("ExitPlaymode", (_context, _) =>
        {
            global::Lua.LuaValue _lastArg = default;
            global::System.Int32 _lastArgPos = default;
            global::System.Type _expectedType = default;
            var _argCount = _context.ArgumentCount;
            if (_argCount == 0)
            {
                global::UnityEditor.EditorApplication.ExitPlaymode();
                var _retCount = _context.Return();
                return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
            }
            throw new global::Lua.LuaRuntimeException(_context.Thread, $"{"ExitPlaymode"}: invalid argument #{_lastArgPos}: {_lastArg} ({_lastArg.Type}), expected: {_expectedType.FullName}", 2);
        });
        private static readonly global::Lua.LuaFunction _LuaEditorApplication_LockReloadAssemblies = new global::Lua.LuaFunction("LockReloadAssemblies", (_context, _) =>
        {
            global::Lua.LuaValue _lastArg = default;
            global::System.Int32 _lastArgPos = default;
            global::System.Type _expectedType = default;
            var _argCount = _context.ArgumentCount;
            if (_argCount == 0)
            {
                global::UnityEditor.EditorApplication.LockReloadAssemblies();
                var _retCount = _context.Return();
                return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
            }
            throw new global::Lua.LuaRuntimeException(_context.Thread, $"{"LockReloadAssemblies"}: invalid argument #{_lastArgPos}: {_lastArg} ({_lastArg.Type}), expected: {_expectedType.FullName}", 2);
        });
        private static readonly global::Lua.LuaFunction _LuaEditorApplication_OpenProject = new global::Lua.LuaFunction("OpenProject", (_context, _) =>
        {
            global::Lua.LuaValue _lastArg = default;
            global::System.Int32 _lastArgPos = default;
            global::System.Type _expectedType = default;
            var _argCount = _context.ArgumentCount;
            var _arg0 = _lastArg = _argCount > 0 ? _context.GetArgument(0) : global::Lua.LuaValue.Nil;
            _lastArgPos = 0; _expectedType = typeof(global::System.String);
            if (_arg0.TryRead<global::System.String>(out var _p0_System_String))
            {
                var _arg1 = _lastArg = _argCount > 1 ? _context.GetArgument(1) : global::Lua.LuaValue.Nil;
                _lastArgPos = 1; _expectedType = typeof(global::System.String[]);
                if (_arg1.TryReadArray<global::System.String>(out var _p1_System_StringArray))
                {
                    if (_argCount == 2)
                    {
                        var projectPath = _p0_System_String;
                        var args = _p1_System_StringArray;
                        global::UnityEditor.EditorApplication.OpenProject(projectPath, args);
                        var _retCount = _context.Return();
                        return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                    }
                }
            }
            throw new global::Lua.LuaRuntimeException(_context.Thread, $"{"OpenProject"}: invalid argument #{_lastArgPos}: {_lastArg} ({_lastArg.Type}), expected: {_expectedType.FullName}", 2);
        });
        private static readonly global::Lua.LuaFunction _LuaEditorApplication_QueuePlayerLoopUpdate = new global::Lua.LuaFunction("QueuePlayerLoopUpdate", (_context, _) =>
        {
            global::Lua.LuaValue _lastArg = default;
            global::System.Int32 _lastArgPos = default;
            global::System.Type _expectedType = default;
            var _argCount = _context.ArgumentCount;
            if (_argCount == 0)
            {
                global::UnityEditor.EditorApplication.QueuePlayerLoopUpdate();
                var _retCount = _context.Return();
                return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
            }
            throw new global::Lua.LuaRuntimeException(_context.Thread, $"{"QueuePlayerLoopUpdate"}: invalid argument #{_lastArgPos}: {_lastArg} ({_lastArg.Type}), expected: {_expectedType.FullName}", 2);
        });
        private static readonly global::Lua.LuaFunction _LuaEditorApplication_RepaintAnimationWindow = new global::Lua.LuaFunction("RepaintAnimationWindow", (_context, _) =>
        {
            global::Lua.LuaValue _lastArg = default;
            global::System.Int32 _lastArgPos = default;
            global::System.Type _expectedType = default;
            var _argCount = _context.ArgumentCount;
            if (_argCount == 0)
            {
                global::UnityEditor.EditorApplication.RepaintAnimationWindow();
                var _retCount = _context.Return();
                return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
            }
            throw new global::Lua.LuaRuntimeException(_context.Thread, $"{"RepaintAnimationWindow"}: invalid argument #{_lastArgPos}: {_lastArg} ({_lastArg.Type}), expected: {_expectedType.FullName}", 2);
        });
        private static readonly global::Lua.LuaFunction _LuaEditorApplication_RepaintHierarchyWindow = new global::Lua.LuaFunction("RepaintHierarchyWindow", (_context, _) =>
        {
            global::Lua.LuaValue _lastArg = default;
            global::System.Int32 _lastArgPos = default;
            global::System.Type _expectedType = default;
            var _argCount = _context.ArgumentCount;
            if (_argCount == 0)
            {
                global::UnityEditor.EditorApplication.RepaintHierarchyWindow();
                var _retCount = _context.Return();
                return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
            }
            throw new global::Lua.LuaRuntimeException(_context.Thread, $"{"RepaintHierarchyWindow"}: invalid argument #{_lastArgPos}: {_lastArg} ({_lastArg.Type}), expected: {_expectedType.FullName}", 2);
        });
        private static readonly global::Lua.LuaFunction _LuaEditorApplication_RepaintProjectWindow = new global::Lua.LuaFunction("RepaintProjectWindow", (_context, _) =>
        {
            global::Lua.LuaValue _lastArg = default;
            global::System.Int32 _lastArgPos = default;
            global::System.Type _expectedType = default;
            var _argCount = _context.ArgumentCount;
            if (_argCount == 0)
            {
                global::UnityEditor.EditorApplication.RepaintProjectWindow();
                var _retCount = _context.Return();
                return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
            }
            throw new global::Lua.LuaRuntimeException(_context.Thread, $"{"RepaintProjectWindow"}: invalid argument #{_lastArgPos}: {_lastArg} ({_lastArg.Type}), expected: {_expectedType.FullName}", 2);
        });
        private static readonly global::Lua.LuaFunction _LuaEditorApplication_SetTemporaryProjectKeepPath = new global::Lua.LuaFunction("SetTemporaryProjectKeepPath", (_context, _) =>
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
                    var path = _p0_System_String;
                    global::UnityEditor.EditorApplication.SetTemporaryProjectKeepPath(path);
                    var _retCount = _context.Return();
                    return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                }
            }
            throw new global::Lua.LuaRuntimeException(_context.Thread, $"{"SetTemporaryProjectKeepPath"}: invalid argument #{_lastArgPos}: {_lastArg} ({_lastArg.Type}), expected: {_expectedType.FullName}", 2);
        });
        private static readonly global::Lua.LuaFunction _LuaEditorApplication_Step = new global::Lua.LuaFunction("Step", (_context, _) =>
        {
            global::Lua.LuaValue _lastArg = default;
            global::System.Int32 _lastArgPos = default;
            global::System.Type _expectedType = default;
            var _argCount = _context.ArgumentCount;
            if (_argCount == 0)
            {
                global::UnityEditor.EditorApplication.Step();
                var _retCount = _context.Return();
                return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
            }
            throw new global::Lua.LuaRuntimeException(_context.Thread, $"{"Step"}: invalid argument #{_lastArgPos}: {_lastArg} ({_lastArg.Type}), expected: {_expectedType.FullName}", 2);
        });
        private static readonly global::Lua.LuaFunction _LuaEditorApplication_UnlockReloadAssemblies = new global::Lua.LuaFunction("UnlockReloadAssemblies", (_context, _) =>
        {
            global::Lua.LuaValue _lastArg = default;
            global::System.Int32 _lastArgPos = default;
            global::System.Type _expectedType = default;
            var _argCount = _context.ArgumentCount;
            if (_argCount == 0)
            {
                global::UnityEditor.EditorApplication.UnlockReloadAssemblies();
                var _retCount = _context.Return();
                return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
            }
            throw new global::Lua.LuaRuntimeException(_context.Thread, $"{"UnlockReloadAssemblies"}: invalid argument #{_lastArgPos}: {_lastArg} ({_lastArg.Type}), expected: {_expectedType.FullName}", 2);
        });
        private static readonly global::Lua.LuaFunction _LuaEditorApplication_UpdateMainWindowTitle = new global::Lua.LuaFunction("UpdateMainWindowTitle", (_context, _) =>
        {
            global::Lua.LuaValue _lastArg = default;
            global::System.Int32 _lastArgPos = default;
            global::System.Type _expectedType = default;
            var _argCount = _context.ArgumentCount;
            if (_argCount == 0)
            {
                global::UnityEditor.EditorApplication.UpdateMainWindowTitle();
                var _retCount = _context.Return();
                return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
            }
            throw new global::Lua.LuaRuntimeException(_context.Thread, $"{"UpdateMainWindowTitle"}: invalid argument #{_lastArgPos}: {_lastArg} ({_lastArg.Type}), expected: {_expectedType.FullName}", 2);
        });
        private static readonly global::Lua.LuaFunction __index = new(global::Lua.Runtime.Metamethods.Index, (_context, _) =>
        {
            var _this = _context.GetArgument<LuaEditorApplicationType>(0);
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
            var _this = _context.GetArgument<LuaEditorApplicationType>(0);
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
            metatable[global::Lua.Runtime.Metamethods.Call] = _LuaEditorApplication_new;
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
                case "Beep": _value = _LuaEditorApplication_Beep; return true;
                case "DirtyHierarchyWindowSorting": _value = _LuaEditorApplication_DirtyHierarchyWindowSorting; return true;
                case "EnterPlaymode": _value = _LuaEditorApplication_EnterPlaymode; return true;
                case "ExecuteMenuItem": _value = _LuaEditorApplication_ExecuteMenuItem; return true;
                case "Exit": _value = _LuaEditorApplication_Exit; return true;
                case "ExitPlaymode": _value = _LuaEditorApplication_ExitPlaymode; return true;
                case "LockReloadAssemblies": _value = _LuaEditorApplication_LockReloadAssemblies; return true;
                case "OpenProject": _value = _LuaEditorApplication_OpenProject; return true;
                case "QueuePlayerLoopUpdate": _value = _LuaEditorApplication_QueuePlayerLoopUpdate; return true;
                case "RepaintAnimationWindow": _value = _LuaEditorApplication_RepaintAnimationWindow; return true;
                case "RepaintHierarchyWindow": _value = _LuaEditorApplication_RepaintHierarchyWindow; return true;
                case "RepaintProjectWindow": _value = _LuaEditorApplication_RepaintProjectWindow; return true;
                case "SetTemporaryProjectKeepPath": _value = _LuaEditorApplication_SetTemporaryProjectKeepPath; return true;
                case "Step": _value = _LuaEditorApplication_Step; return true;
                case "UnlockReloadAssemblies": _value = _LuaEditorApplication_UnlockReloadAssemblies; return true;
                case "UpdateMainWindowTitle": _value = _LuaEditorApplication_UpdateMainWindowTitle; return true;
                case "applicationContentsPath": _value = new global::Lua.LuaValue(global::UnityEditor.EditorApplication.applicationContentsPath); return true;
                case "applicationPath": _value = new global::Lua.LuaValue(global::UnityEditor.EditorApplication.applicationPath); return true;
                case "isCompiling": _value = new global::Lua.LuaValue(global::UnityEditor.EditorApplication.isCompiling); return true;
                case "isCreateFromTemplate": _value = new global::Lua.LuaValue(global::UnityEditor.EditorApplication.isCreateFromTemplate); return true;
                case "isFocused": _value = new global::Lua.LuaValue(global::UnityEditor.EditorApplication.isFocused); return true;
                case "isPaused": _value = new global::Lua.LuaValue(global::UnityEditor.EditorApplication.isPaused); return true;
                case "isPlaying": _value = new global::Lua.LuaValue(global::UnityEditor.EditorApplication.isPlaying); return true;
                case "isPlayingOrWillChangePlaymode": _value = new global::Lua.LuaValue(global::UnityEditor.EditorApplication.isPlayingOrWillChangePlaymode); return true;
                case "isRemoteConnected": _value = new global::Lua.LuaValue(global::UnityEditor.EditorApplication.isRemoteConnected); return true;
                case "isTemporaryProject": _value = new global::Lua.LuaValue(global::UnityEditor.EditorApplication.isTemporaryProject); return true;
                case "isUpdating": _value = new global::Lua.LuaValue(global::UnityEditor.EditorApplication.isUpdating); return true;
                case "timeSinceStartup": _value = new global::Lua.LuaValue(global::UnityEditor.EditorApplication.timeSinceStartup); return true;
                case "contextualPropertyMenu": _value = _factory.Bind(global::UnityEditor.EditorApplication.contextualPropertyMenu); return true;
                case "delayCall": _value = _factory.Bind(global::UnityEditor.EditorApplication.delayCall); return true;
                case "hierarchyWindowItemOnGUI": _value = _factory.Bind(global::UnityEditor.EditorApplication.hierarchyWindowItemOnGUI); return true;
                case "modifierKeysChanged": _value = _factory.Bind(global::UnityEditor.EditorApplication.modifierKeysChanged); return true;
                case "projectWindowItemInstanceOnGUI": _value = _factory.Bind(global::UnityEditor.EditorApplication.projectWindowItemInstanceOnGUI); return true;
                case "projectWindowItemOnGUI": _value = _factory.Bind(global::UnityEditor.EditorApplication.projectWindowItemOnGUI); return true;
                case "searchChanged": _value = _factory.Bind(global::UnityEditor.EditorApplication.searchChanged); return true;
                case "update": _value = _factory.Bind(global::UnityEditor.EditorApplication.update); return true;
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
                case "isPaused": global::UnityEditor.EditorApplication.isPaused = _value.Read<global::System.Boolean>();  return true;
                case "isPlaying": global::UnityEditor.EditorApplication.isPlaying = _value.Read<global::System.Boolean>();  return true;
                case "contextualPropertyMenu": global::UnityEditor.EditorApplication.contextualPropertyMenu = _value.Read<global::UnityEditor.EditorApplication.SerializedPropertyCallbackFunction>();  return true;
                case "delayCall": global::UnityEditor.EditorApplication.delayCall = _value.Read<global::UnityEditor.EditorApplication.CallbackFunction>();  return true;
                case "hierarchyWindowItemOnGUI": global::UnityEditor.EditorApplication.hierarchyWindowItemOnGUI = _value.Read<global::UnityEditor.EditorApplication.HierarchyWindowItemCallback>();  return true;
                case "modifierKeysChanged": global::UnityEditor.EditorApplication.modifierKeysChanged = _value.Read<global::UnityEditor.EditorApplication.CallbackFunction>();  return true;
                case "projectWindowItemInstanceOnGUI": global::UnityEditor.EditorApplication.projectWindowItemInstanceOnGUI = _value.Read<global::UnityEditor.EditorApplication.ProjectWindowItemInstanceCallback>();  return true;
                case "projectWindowItemOnGUI": global::UnityEditor.EditorApplication.projectWindowItemOnGUI = _value.Read<global::UnityEditor.EditorApplication.ProjectWindowItemCallback>();  return true;
                case "searchChanged": global::UnityEditor.EditorApplication.searchChanged = _value.Read<global::UnityEditor.EditorApplication.CallbackFunction>();  return true;
                case "update": global::UnityEditor.EditorApplication.update = _value.Read<global::UnityEditor.EditorApplication.CallbackFunction>();  return true;
                default: return false;
            }
        }
    }
}
#pragma warning restore 0109, 0162, 0168, 0219
#endif
