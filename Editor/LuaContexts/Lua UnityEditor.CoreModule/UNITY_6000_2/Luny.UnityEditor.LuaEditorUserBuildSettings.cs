
// --------------------------------------------------------------
// GENERATED FILE ----> DO NOT EDIT <---- CHANGES WILL BE LOST !!
// --------------------------------------------------------------

#if UNITY_6000_2_OR_NEWER && !(UNITY_6000_3_OR_NEWER)
#pragma warning disable 0109, 0162, 0168, 0219
using Luny;

namespace Luny.UnityEditor
{
    public sealed class LuaEditorUserBuildSettings : global::Luny.ILuaObject<global::UnityEditor.EditorUserBuildSettings>
    {
        public new static global::Lua.LuaValue Bind(global::UnityEditor.EditorUserBuildSettings instance) => new LuaEditorUserBuildSettings(instance);
        public new static global::Lua.LuaValue Bind(global::System.Object instance) => Bind((global::UnityEditor.EditorUserBuildSettings)instance);
        public new static global::Lua.LuaValue Bind(global::System.Collections.Generic.IList<global::UnityEditor.EditorUserBuildSettings> instances) =>
            new global::Luny.LuaList<global::UnityEditor.EditorUserBuildSettings>(instances);
        public new static global::Lua.LuaValue Bind(global::System.Collections.Generic.IList<global::System.Object> instances) =>
            new global::Luny.LuaList<global::UnityEditor.EditorUserBuildSettings>(instances);
        private LuaEditorUserBuildSettings(global::UnityEditor.EditorUserBuildSettings instance) => m_Instance = instance;
        public static implicit operator global::Lua.LuaValue(LuaEditorUserBuildSettings value) => new(value);
        private global::UnityEditor.EditorUserBuildSettings m_Instance;
        public global::UnityEditor.EditorUserBuildSettings Instance => m_Instance;
        public new global::System.Type BindType => typeof(global::UnityEditor.EditorUserBuildSettings);
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

        private static readonly global::Lua.LuaFunction __index = new(global::Lua.Runtime.Metamethods.Index, (_context, _) =>
        {
            var _this = _context.GetArgument<LuaEditorUserBuildSettings>(0);
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
            var _this = _context.GetArgument<LuaEditorUserBuildSettings>(0);
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
    public sealed class LuaEditorUserBuildSettingsType : global::Luny.ILuaStatic
    {
        public static global::Lua.LuaValue Bind() => new LuaEditorUserBuildSettingsType();
        private LuaEditorUserBuildSettingsType() {}
        public static implicit operator global::Lua.LuaValue(LuaEditorUserBuildSettingsType value) => new(value);
        public global::System.Type BindType => typeof(global::UnityEditor.EditorUserBuildSettings);
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

        private static readonly global::Lua.LuaFunction _LuaEditorUserBuildSettings_GetBuildLocation = new global::Lua.LuaFunction("GetBuildLocation", (_context, _) =>
        {
            global::Lua.LuaValue _lastArg = default;
            global::System.Int32 _lastArgPos = default;
            global::System.Type _expectedType = default;
            var _argCount = _context.ArgumentCount;
            var _arg0 = _lastArg = _argCount > 0 ? _context.GetArgument(0) : global::Lua.LuaValue.Nil;
            _lastArgPos = 0; _expectedType = typeof(global::UnityEditor.BuildTarget);
            if (_arg0.TryRead<global::UnityEditor.BuildTarget>(out var _p0_UnityEditor_BuildTarget))
            {
                if (_argCount == 1)
                {
                    var target = _p0_UnityEditor_BuildTarget;
                    var _ret0 = global::UnityEditor.EditorUserBuildSettings.GetBuildLocation(target);
                    var _lret0 = new global::Lua.LuaValue(_ret0);
                    var _retCount = _context.Return(_lret0);
                    return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                }
            }
            throw new global::Lua.LuaRuntimeException(_context.Thread, $"{"GetBuildLocation"}: invalid argument #{_lastArgPos}: {_lastArg} ({_lastArg.Type}), expected: {_expectedType.FullName}", 2);
        });
        private static readonly global::Lua.LuaFunction _LuaEditorUserBuildSettings_GetPlatformSettings = new global::Lua.LuaFunction("GetPlatformSettings", (_context, _) =>
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
                _lastArgPos = 1; _expectedType = typeof(global::System.String);
                if (_arg1.TryRead<global::System.String>(out var _p1_System_String))
                {
                    if (_argCount == 2)
                    {
                        var platformName = _p0_System_String;
                        var name = _p1_System_String;
                        var _ret0 = global::UnityEditor.EditorUserBuildSettings.GetPlatformSettings(platformName, name);
                        var _lret0 = new global::Lua.LuaValue(_ret0);
                        var _retCount = _context.Return(_lret0);
                        return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                    }
                    var _arg2 = _lastArg = _argCount > 2 ? _context.GetArgument(2) : global::Lua.LuaValue.Nil;
                    _lastArgPos = 2; _expectedType = typeof(global::System.String);
                    if (_arg2.TryRead<global::System.String>(out var _p2_System_String))
                    {
                        if (_argCount == 3)
                        {
                            var buildTargetGroup = _p0_System_String;
                            var platformName = _p1_System_String;
                            var name = _p2_System_String;
                            var _ret0 = global::UnityEditor.EditorUserBuildSettings.GetPlatformSettings(buildTargetGroup, platformName, name);
                            var _lret0 = new global::Lua.LuaValue(_ret0);
                            var _retCount = _context.Return(_lret0);
                            return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                        }
                    }
                }
            }
            throw new global::Lua.LuaRuntimeException(_context.Thread, $"{"GetPlatformSettings"}: invalid argument #{_lastArgPos}: {_lastArg} ({_lastArg.Type}), expected: {_expectedType.FullName}", 2);
        });
        private static readonly global::Lua.LuaFunction _LuaEditorUserBuildSettings_SetBuildLocation = new global::Lua.LuaFunction("SetBuildLocation", (_context, _) =>
        {
            global::Lua.LuaValue _lastArg = default;
            global::System.Int32 _lastArgPos = default;
            global::System.Type _expectedType = default;
            var _argCount = _context.ArgumentCount;
            var _arg0 = _lastArg = _argCount > 0 ? _context.GetArgument(0) : global::Lua.LuaValue.Nil;
            _lastArgPos = 0; _expectedType = typeof(global::UnityEditor.BuildTarget);
            if (_arg0.TryRead<global::UnityEditor.BuildTarget>(out var _p0_UnityEditor_BuildTarget))
            {
                var _arg1 = _lastArg = _argCount > 1 ? _context.GetArgument(1) : global::Lua.LuaValue.Nil;
                _lastArgPos = 1; _expectedType = typeof(global::System.String);
                if (_arg1.TryRead<global::System.String>(out var _p1_System_String))
                {
                    if (_argCount == 2)
                    {
                        var target = _p0_UnityEditor_BuildTarget;
                        var location = _p1_System_String;
                        global::UnityEditor.EditorUserBuildSettings.SetBuildLocation(target, location);
                        var _retCount = _context.Return();
                        return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                    }
                }
            }
            throw new global::Lua.LuaRuntimeException(_context.Thread, $"{"SetBuildLocation"}: invalid argument #{_lastArgPos}: {_lastArg} ({_lastArg.Type}), expected: {_expectedType.FullName}", 2);
        });
        private static readonly global::Lua.LuaFunction _LuaEditorUserBuildSettings_SetPlatformSettings = new global::Lua.LuaFunction("SetPlatformSettings", (_context, _) =>
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
                _lastArgPos = 1; _expectedType = typeof(global::System.String);
                if (_arg1.TryRead<global::System.String>(out var _p1_System_String))
                {
                    var _arg2 = _lastArg = _argCount > 2 ? _context.GetArgument(2) : global::Lua.LuaValue.Nil;
                    _lastArgPos = 2; _expectedType = typeof(global::System.String);
                    if (_arg2.TryRead<global::System.String>(out var _p2_System_String))
                    {
                        if (_argCount == 3)
                        {
                            var platformName = _p0_System_String;
                            var name = _p1_System_String;
                            var value = _p2_System_String;
                            global::UnityEditor.EditorUserBuildSettings.SetPlatformSettings(platformName, name, value);
                            var _retCount = _context.Return();
                            return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                        }
                        var _arg3 = _lastArg = _argCount > 3 ? _context.GetArgument(3) : global::Lua.LuaValue.Nil;
                        _lastArgPos = 3; _expectedType = typeof(global::System.String);
                        if (_arg3.TryRead<global::System.String>(out var _p3_System_String))
                        {
                            if (_argCount == 4)
                            {
                                var buildTargetGroup = _p0_System_String;
                                var buildTarget = _p1_System_String;
                                var name = _p2_System_String;
                                var value = _p3_System_String;
                                global::UnityEditor.EditorUserBuildSettings.SetPlatformSettings(buildTargetGroup, buildTarget, name, value);
                                var _retCount = _context.Return();
                                return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                            }
                        }
                    }
                }
            }
            throw new global::Lua.LuaRuntimeException(_context.Thread, $"{"SetPlatformSettings"}: invalid argument #{_lastArgPos}: {_lastArg} ({_lastArg.Type}), expected: {_expectedType.FullName}", 2);
        });
        private static readonly global::Lua.LuaFunction _LuaEditorUserBuildSettings_SwitchActiveBuildTarget = new global::Lua.LuaFunction("SwitchActiveBuildTarget", (_context, _) =>
        {
            global::Lua.LuaValue _lastArg = default;
            global::System.Int32 _lastArgPos = default;
            global::System.Type _expectedType = default;
            var _argCount = _context.ArgumentCount;
            var _arg0 = _lastArg = _argCount > 0 ? _context.GetArgument(0) : global::Lua.LuaValue.Nil;
            _lastArgPos = 0; _expectedType = typeof(global::UnityEditor.BuildTargetGroup);
            if (_arg0.TryRead<global::UnityEditor.BuildTargetGroup>(out var _p0_UnityEditor_BuildTargetGroup))
            {
                var _arg1 = _lastArg = _argCount > 1 ? _context.GetArgument(1) : global::Lua.LuaValue.Nil;
                _lastArgPos = 1; _expectedType = typeof(global::UnityEditor.BuildTarget);
                if (_arg1.TryRead<global::UnityEditor.BuildTarget>(out var _p1_UnityEditor_BuildTarget))
                {
                    if (_argCount == 2)
                    {
                        var targetGroup = _p0_UnityEditor_BuildTargetGroup;
                        var target = _p1_UnityEditor_BuildTarget;
                        var _ret0 = global::UnityEditor.EditorUserBuildSettings.SwitchActiveBuildTarget(targetGroup, target);
                        var _lret0 = new global::Lua.LuaValue(_ret0);
                        var _retCount = _context.Return(_lret0);
                        return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                    }
                }
            }
            _lastArgPos = 0; _expectedType = typeof(global::Luny.UnityEditor.Build.LuaNamedBuildTarget);
            if (_arg0.TryRead<global::Luny.UnityEditor.Build.LuaNamedBuildTarget>(out var _p0_UnityEditor_Build_NamedBuildTarget))
            {
                var _arg1 = _lastArg = _argCount > 1 ? _context.GetArgument(1) : global::Lua.LuaValue.Nil;
                _lastArgPos = 1; _expectedType = typeof(global::UnityEditor.BuildTarget);
                if (_arg1.TryRead<global::UnityEditor.BuildTarget>(out var _p1_UnityEditor_BuildTarget))
                {
                    if (_argCount == 2)
                    {
                        var namedBuildTarget = _p0_UnityEditor_Build_NamedBuildTarget.Value;
                        var target = _p1_UnityEditor_BuildTarget;
                        var _ret0 = global::UnityEditor.EditorUserBuildSettings.SwitchActiveBuildTarget(namedBuildTarget, target);
                        var _lret0 = new global::Lua.LuaValue(_ret0);
                        var _retCount = _context.Return(_lret0);
                        return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                    }
                }
            }
            throw new global::Lua.LuaRuntimeException(_context.Thread, $"{"SwitchActiveBuildTarget"}: invalid argument #{_lastArgPos}: {_lastArg} ({_lastArg.Type}), expected: {_expectedType.FullName}", 2);
        });
        private static readonly global::Lua.LuaFunction _LuaEditorUserBuildSettings_SwitchActiveBuildTargetAsync = new global::Lua.LuaFunction("SwitchActiveBuildTargetAsync", (_context, _) =>
        {
            global::Lua.LuaValue _lastArg = default;
            global::System.Int32 _lastArgPos = default;
            global::System.Type _expectedType = default;
            var _argCount = _context.ArgumentCount;
            var _arg0 = _lastArg = _argCount > 0 ? _context.GetArgument(0) : global::Lua.LuaValue.Nil;
            _lastArgPos = 0; _expectedType = typeof(global::UnityEditor.BuildTargetGroup);
            if (_arg0.TryRead<global::UnityEditor.BuildTargetGroup>(out var _p0_UnityEditor_BuildTargetGroup))
            {
                var _arg1 = _lastArg = _argCount > 1 ? _context.GetArgument(1) : global::Lua.LuaValue.Nil;
                _lastArgPos = 1; _expectedType = typeof(global::UnityEditor.BuildTarget);
                if (_arg1.TryRead<global::UnityEditor.BuildTarget>(out var _p1_UnityEditor_BuildTarget))
                {
                    if (_argCount == 2)
                    {
                        var targetGroup = _p0_UnityEditor_BuildTargetGroup;
                        var target = _p1_UnityEditor_BuildTarget;
                        var _ret0 = global::UnityEditor.EditorUserBuildSettings.SwitchActiveBuildTargetAsync(targetGroup, target);
                        var _lret0 = new global::Lua.LuaValue(_ret0);
                        var _retCount = _context.Return(_lret0);
                        return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                    }
                }
            }
            throw new global::Lua.LuaRuntimeException(_context.Thread, $"{"SwitchActiveBuildTargetAsync"}: invalid argument #{_lastArgPos}: {_lastArg} ({_lastArg.Type}), expected: {_expectedType.FullName}", 2);
        });
        private static readonly global::Lua.LuaFunction __index = new(global::Lua.Runtime.Metamethods.Index, (_context, _) =>
        {
            var _this = _context.GetArgument<LuaEditorUserBuildSettingsType>(0);
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
            var _this = _context.GetArgument<LuaEditorUserBuildSettingsType>(0);
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
                case "GetBuildLocation": _value = _LuaEditorUserBuildSettings_GetBuildLocation; return true;
                case "GetPlatformSettings": _value = _LuaEditorUserBuildSettings_GetPlatformSettings; return true;
                case "SetBuildLocation": _value = _LuaEditorUserBuildSettings_SetBuildLocation; return true;
                case "SetPlatformSettings": _value = _LuaEditorUserBuildSettings_SetPlatformSettings; return true;
                case "SwitchActiveBuildTarget": _value = _LuaEditorUserBuildSettings_SwitchActiveBuildTarget; return true;
                case "SwitchActiveBuildTargetAsync": _value = _LuaEditorUserBuildSettings_SwitchActiveBuildTargetAsync; return true;
                case "activeBuildTarget": _value = new global::Lua.LuaValue((global::System.Int64)global::UnityEditor.EditorUserBuildSettings.activeBuildTarget); return true;
                case "activeScriptCompilationDefines": _value = _factory.Bind(global::UnityEditor.EditorUserBuildSettings.activeScriptCompilationDefines); return true;
                case "allowDebugging": _value = new global::Lua.LuaValue(global::UnityEditor.EditorUserBuildSettings.allowDebugging); return true;
                case "androidBuildSubtarget": _value = new global::Lua.LuaValue((global::System.Int64)global::UnityEditor.EditorUserBuildSettings.androidBuildSubtarget); return true;
                case "androidBuildSystem": _value = new global::Lua.LuaValue((global::System.Int64)global::UnityEditor.EditorUserBuildSettings.androidBuildSystem); return true;
                case "androidBuildType": _value = new global::Lua.LuaValue((global::System.Int64)global::UnityEditor.EditorUserBuildSettings.androidBuildType); return true;
                case "buildAppBundle": _value = new global::Lua.LuaValue(global::UnityEditor.EditorUserBuildSettings.buildAppBundle); return true;
                case "buildScriptsOnly": _value = new global::Lua.LuaValue(global::UnityEditor.EditorUserBuildSettings.buildScriptsOnly); return true;
                case "buildWithDeepProfilingSupport": _value = new global::Lua.LuaValue(global::UnityEditor.EditorUserBuildSettings.buildWithDeepProfilingSupport); return true;
                case "compressFilesInPackage": _value = new global::Lua.LuaValue(global::UnityEditor.EditorUserBuildSettings.compressFilesInPackage); return true;
                case "connectProfiler": _value = new global::Lua.LuaValue(global::UnityEditor.EditorUserBuildSettings.connectProfiler); return true;
                case "development": _value = new global::Lua.LuaValue(global::UnityEditor.EditorUserBuildSettings.development); return true;
                case "explicitArrayBoundsChecks": _value = new global::Lua.LuaValue(global::UnityEditor.EditorUserBuildSettings.explicitArrayBoundsChecks); return true;
                case "explicitDivideByZeroChecks": _value = new global::Lua.LuaValue(global::UnityEditor.EditorUserBuildSettings.explicitDivideByZeroChecks); return true;
                case "explicitNullChecks": _value = new global::Lua.LuaValue(global::UnityEditor.EditorUserBuildSettings.explicitNullChecks); return true;
                case "exportAsGoogleAndroidProject": _value = new global::Lua.LuaValue(global::UnityEditor.EditorUserBuildSettings.exportAsGoogleAndroidProject); return true;
                case "forceInstallation": _value = new global::Lua.LuaValue(global::UnityEditor.EditorUserBuildSettings.forceInstallation); return true;
                case "generateNintendoSwitchShaderInfo": _value = new global::Lua.LuaValue(global::UnityEditor.EditorUserBuildSettings.generateNintendoSwitchShaderInfo); return true;
                case "installInBuildFolder": _value = new global::Lua.LuaValue(global::UnityEditor.EditorUserBuildSettings.installInBuildFolder); return true;
                case "iOSXcodeBuildConfig": _value = new global::Lua.LuaValue((global::System.Int64)global::UnityEditor.EditorUserBuildSettings.iOSXcodeBuildConfig); return true;
                case "macOSXcodeBuildConfig": _value = new global::Lua.LuaValue((global::System.Int64)global::UnityEditor.EditorUserBuildSettings.macOSXcodeBuildConfig); return true;
                case "managedDebuggerFixedPort": _value = new global::Lua.LuaValue(global::UnityEditor.EditorUserBuildSettings.managedDebuggerFixedPort); return true;
                case "movePackageToDiscOuterEdge": _value = new global::Lua.LuaValue(global::UnityEditor.EditorUserBuildSettings.movePackageToDiscOuterEdge); return true;
                case "needSubmissionMaterials": _value = new global::Lua.LuaValue(global::UnityEditor.EditorUserBuildSettings.needSubmissionMaterials); return true;
                case "overrideMaxTextureSize": _value = new global::Lua.LuaValue(global::UnityEditor.EditorUserBuildSettings.overrideMaxTextureSize); return true;
                case "overrideTextureCompression": _value = new global::Lua.LuaValue((global::System.Int64)global::UnityEditor.EditorUserBuildSettings.overrideTextureCompression); return true;
                case "pathOnRemoteDevice": _value = new global::Lua.LuaValue(global::UnityEditor.EditorUserBuildSettings.pathOnRemoteDevice); return true;
                case "ps4BuildSubtarget": _value = new global::Lua.LuaValue((global::System.Int64)global::UnityEditor.EditorUserBuildSettings.ps4BuildSubtarget); return true;
                case "ps4HardwareTarget": _value = new global::Lua.LuaValue((global::System.Int64)global::UnityEditor.EditorUserBuildSettings.ps4HardwareTarget); return true;
                case "remoteDeviceAddress": _value = new global::Lua.LuaValue(global::UnityEditor.EditorUserBuildSettings.remoteDeviceAddress); return true;
                case "remoteDeviceExports": _value = new global::Lua.LuaValue(global::UnityEditor.EditorUserBuildSettings.remoteDeviceExports); return true;
                case "remoteDeviceInfo": _value = new global::Lua.LuaValue(global::UnityEditor.EditorUserBuildSettings.remoteDeviceInfo); return true;
                case "remoteDeviceUsername": _value = new global::Lua.LuaValue(global::UnityEditor.EditorUserBuildSettings.remoteDeviceUsername); return true;
                case "selectedBuildTargetGroup": _value = new global::Lua.LuaValue((global::System.Int64)global::UnityEditor.EditorUserBuildSettings.selectedBuildTargetGroup); return true;
                case "selectedStandaloneTarget": _value = new global::Lua.LuaValue((global::System.Int64)global::UnityEditor.EditorUserBuildSettings.selectedStandaloneTarget); return true;
                case "standaloneBuildSubtarget": _value = new global::Lua.LuaValue((global::System.Int64)global::UnityEditor.EditorUserBuildSettings.standaloneBuildSubtarget); return true;
                case "switchCreateRomFile": _value = new global::Lua.LuaValue(global::UnityEditor.EditorUserBuildSettings.switchCreateRomFile); return true;
                case "switchEnableDebugPad": _value = new global::Lua.LuaValue(global::UnityEditor.EditorUserBuildSettings.switchEnableDebugPad); return true;
                case "switchEnableHostIO": _value = new global::Lua.LuaValue(global::UnityEditor.EditorUserBuildSettings.switchEnableHostIO); return true;
                case "switchEnableMemoryTracker": _value = new global::Lua.LuaValue(global::UnityEditor.EditorUserBuildSettings.switchEnableMemoryTracker); return true;
                case "switchEnableRomCompression": _value = new global::Lua.LuaValue(global::UnityEditor.EditorUserBuildSettings.switchEnableRomCompression); return true;
                case "switchEnableUnpublishableErrors": _value = new global::Lua.LuaValue(global::UnityEditor.EditorUserBuildSettings.switchEnableUnpublishableErrors); return true;
                case "switchHTCSScriptDebugging": _value = new global::Lua.LuaValue(global::UnityEditor.EditorUserBuildSettings.switchHTCSScriptDebugging); return true;
                case "switchNVNAftermath": _value = new global::Lua.LuaValue(global::UnityEditor.EditorUserBuildSettings.switchNVNAftermath); return true;
                case "switchNVNDrawValidation_Heavy": _value = new global::Lua.LuaValue(global::UnityEditor.EditorUserBuildSettings.switchNVNDrawValidation_Heavy); return true;
                case "switchNVNDrawValidation_Light": _value = new global::Lua.LuaValue(global::UnityEditor.EditorUserBuildSettings.switchNVNDrawValidation_Light); return true;
                case "switchNVNGraphicsDebugger": _value = new global::Lua.LuaValue(global::UnityEditor.EditorUserBuildSettings.switchNVNGraphicsDebugger); return true;
                case "switchNVNShaderDebugging": _value = new global::Lua.LuaValue(global::UnityEditor.EditorUserBuildSettings.switchNVNShaderDebugging); return true;
                case "switchRomCompressionConfig": _value = new global::Lua.LuaValue(global::UnityEditor.EditorUserBuildSettings.switchRomCompressionConfig); return true;
                case "switchRomCompressionLevel": _value = new global::Lua.LuaValue(global::UnityEditor.EditorUserBuildSettings.switchRomCompressionLevel); return true;
                case "switchRomCompressionType": _value = new global::Lua.LuaValue((global::System.Int64)global::UnityEditor.EditorUserBuildSettings.switchRomCompressionType); return true;
                case "switchSaveADF": _value = new global::Lua.LuaValue(global::UnityEditor.EditorUserBuildSettings.switchSaveADF); return true;
                case "switchUseLegacyNvnPoolAllocator": _value = new global::Lua.LuaValue(global::UnityEditor.EditorUserBuildSettings.switchUseLegacyNvnPoolAllocator); return true;
                case "switchWaitForMemoryTrackerOnStartup": _value = new global::Lua.LuaValue(global::UnityEditor.EditorUserBuildSettings.switchWaitForMemoryTrackerOnStartup); return true;
                case "symlinkSources": _value = new global::Lua.LuaValue(global::UnityEditor.EditorUserBuildSettings.symlinkSources); return true;
                case "waitForManagedDebugger": _value = new global::Lua.LuaValue(global::UnityEditor.EditorUserBuildSettings.waitForManagedDebugger); return true;
                case "waitForPlayerConnection": _value = new global::Lua.LuaValue(global::UnityEditor.EditorUserBuildSettings.waitForPlayerConnection); return true;
                case "webGLBuildSubtarget": _value = new global::Lua.LuaValue((global::System.Int64)global::UnityEditor.EditorUserBuildSettings.webGLBuildSubtarget); return true;
                case "webGLClientBrowserPath": _value = new global::Lua.LuaValue(global::UnityEditor.EditorUserBuildSettings.webGLClientBrowserPath); return true;
                case "webGLClientBrowserType": _value = new global::Lua.LuaValue((global::System.Int64)global::UnityEditor.EditorUserBuildSettings.webGLClientBrowserType); return true;
                case "windowsBuildAndRunDeployTarget": _value = new global::Lua.LuaValue((global::System.Int64)global::UnityEditor.EditorUserBuildSettings.windowsBuildAndRunDeployTarget); return true;
                case "windowsDevicePortalAddress": _value = new global::Lua.LuaValue(global::UnityEditor.EditorUserBuildSettings.windowsDevicePortalAddress); return true;
                case "windowsDevicePortalPassword": _value = new global::Lua.LuaValue(global::UnityEditor.EditorUserBuildSettings.windowsDevicePortalPassword); return true;
                case "windowsDevicePortalUsername": _value = new global::Lua.LuaValue(global::UnityEditor.EditorUserBuildSettings.windowsDevicePortalUsername); return true;
                case "wsaArchitecture": _value = new global::Lua.LuaValue(global::UnityEditor.EditorUserBuildSettings.wsaArchitecture); return true;
                case "wsaBuildAndRunDeployTarget": _value = new global::Lua.LuaValue((global::System.Int64)global::UnityEditor.EditorUserBuildSettings.wsaBuildAndRunDeployTarget); return true;
                case "wsaMinUWPSDK": _value = new global::Lua.LuaValue(global::UnityEditor.EditorUserBuildSettings.wsaMinUWPSDK); return true;
                case "wsaUWPBuildType": _value = new global::Lua.LuaValue((global::System.Int64)global::UnityEditor.EditorUserBuildSettings.wsaUWPBuildType); return true;
                case "wsaUWPSDK": _value = new global::Lua.LuaValue(global::UnityEditor.EditorUserBuildSettings.wsaUWPSDK); return true;
                case "wsaUWPVisualStudioVersion": _value = new global::Lua.LuaValue(global::UnityEditor.EditorUserBuildSettings.wsaUWPVisualStudioVersion); return true;
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
                case "allowDebugging": global::UnityEditor.EditorUserBuildSettings.allowDebugging = _value.Read<global::System.Boolean>();  return true;
                case "androidBuildSubtarget": global::UnityEditor.EditorUserBuildSettings.androidBuildSubtarget = _value.Read<global::UnityEditor.MobileTextureSubtarget>();  return true;
                case "androidBuildSystem": global::UnityEditor.EditorUserBuildSettings.androidBuildSystem = _value.Read<global::UnityEditor.AndroidBuildSystem>();  return true;
                case "androidBuildType": global::UnityEditor.EditorUserBuildSettings.androidBuildType = _value.Read<global::UnityEditor.AndroidBuildType>();  return true;
                case "buildAppBundle": global::UnityEditor.EditorUserBuildSettings.buildAppBundle = _value.Read<global::System.Boolean>();  return true;
                case "buildScriptsOnly": global::UnityEditor.EditorUserBuildSettings.buildScriptsOnly = _value.Read<global::System.Boolean>();  return true;
                case "buildWithDeepProfilingSupport": global::UnityEditor.EditorUserBuildSettings.buildWithDeepProfilingSupport = _value.Read<global::System.Boolean>();  return true;
                case "compressFilesInPackage": global::UnityEditor.EditorUserBuildSettings.compressFilesInPackage = _value.Read<global::System.Boolean>();  return true;
                case "connectProfiler": global::UnityEditor.EditorUserBuildSettings.connectProfiler = _value.Read<global::System.Boolean>();  return true;
                case "development": global::UnityEditor.EditorUserBuildSettings.development = _value.Read<global::System.Boolean>();  return true;
                case "explicitArrayBoundsChecks": global::UnityEditor.EditorUserBuildSettings.explicitArrayBoundsChecks = _value.Read<global::System.Boolean>();  return true;
                case "explicitDivideByZeroChecks": global::UnityEditor.EditorUserBuildSettings.explicitDivideByZeroChecks = _value.Read<global::System.Boolean>();  return true;
                case "explicitNullChecks": global::UnityEditor.EditorUserBuildSettings.explicitNullChecks = _value.Read<global::System.Boolean>();  return true;
                case "exportAsGoogleAndroidProject": global::UnityEditor.EditorUserBuildSettings.exportAsGoogleAndroidProject = _value.Read<global::System.Boolean>();  return true;
                case "forceInstallation": global::UnityEditor.EditorUserBuildSettings.forceInstallation = _value.Read<global::System.Boolean>();  return true;
                case "generateNintendoSwitchShaderInfo": global::UnityEditor.EditorUserBuildSettings.generateNintendoSwitchShaderInfo = _value.Read<global::System.Boolean>();  return true;
                case "installInBuildFolder": global::UnityEditor.EditorUserBuildSettings.installInBuildFolder = _value.Read<global::System.Boolean>();  return true;
                case "iOSXcodeBuildConfig": global::UnityEditor.EditorUserBuildSettings.iOSXcodeBuildConfig = _value.Read<global::UnityEditor.XcodeBuildConfig>();  return true;
                case "macOSXcodeBuildConfig": global::UnityEditor.EditorUserBuildSettings.macOSXcodeBuildConfig = _value.Read<global::UnityEditor.XcodeBuildConfig>();  return true;
                case "managedDebuggerFixedPort": global::UnityEditor.EditorUserBuildSettings.managedDebuggerFixedPort = _value.Read<global::System.Int32>();  return true;
                case "movePackageToDiscOuterEdge": global::UnityEditor.EditorUserBuildSettings.movePackageToDiscOuterEdge = _value.Read<global::System.Boolean>();  return true;
                case "needSubmissionMaterials": global::UnityEditor.EditorUserBuildSettings.needSubmissionMaterials = _value.Read<global::System.Boolean>();  return true;
                case "overrideMaxTextureSize": global::UnityEditor.EditorUserBuildSettings.overrideMaxTextureSize = _value.Read<global::System.Int32>();  return true;
                case "overrideTextureCompression": global::UnityEditor.EditorUserBuildSettings.overrideTextureCompression = _value.Read<global::UnityEditor.Build.OverrideTextureCompression>();  return true;
                case "pathOnRemoteDevice": global::UnityEditor.EditorUserBuildSettings.pathOnRemoteDevice = _value.Read<global::System.String>();  return true;
                case "ps4BuildSubtarget": global::UnityEditor.EditorUserBuildSettings.ps4BuildSubtarget = _value.Read<global::UnityEditor.PS4BuildSubtarget>();  return true;
                case "ps4HardwareTarget": global::UnityEditor.EditorUserBuildSettings.ps4HardwareTarget = _value.Read<global::UnityEditor.PS4HardwareTarget>();  return true;
                case "remoteDeviceAddress": global::UnityEditor.EditorUserBuildSettings.remoteDeviceAddress = _value.Read<global::System.String>();  return true;
                case "remoteDeviceExports": global::UnityEditor.EditorUserBuildSettings.remoteDeviceExports = _value.Read<global::System.String>();  return true;
                case "remoteDeviceInfo": global::UnityEditor.EditorUserBuildSettings.remoteDeviceInfo = _value.Read<global::System.Boolean>();  return true;
                case "remoteDeviceUsername": global::UnityEditor.EditorUserBuildSettings.remoteDeviceUsername = _value.Read<global::System.String>();  return true;
                case "selectedBuildTargetGroup": global::UnityEditor.EditorUserBuildSettings.selectedBuildTargetGroup = _value.Read<global::UnityEditor.BuildTargetGroup>();  return true;
                case "selectedStandaloneTarget": global::UnityEditor.EditorUserBuildSettings.selectedStandaloneTarget = _value.Read<global::UnityEditor.BuildTarget>();  return true;
                case "standaloneBuildSubtarget": global::UnityEditor.EditorUserBuildSettings.standaloneBuildSubtarget = _value.Read<global::UnityEditor.StandaloneBuildSubtarget>();  return true;
                case "switchCreateRomFile": global::UnityEditor.EditorUserBuildSettings.switchCreateRomFile = _value.Read<global::System.Boolean>();  return true;
                case "switchEnableDebugPad": global::UnityEditor.EditorUserBuildSettings.switchEnableDebugPad = _value.Read<global::System.Boolean>();  return true;
                case "switchEnableHostIO": global::UnityEditor.EditorUserBuildSettings.switchEnableHostIO = _value.Read<global::System.Boolean>();  return true;
                case "switchEnableMemoryTracker": global::UnityEditor.EditorUserBuildSettings.switchEnableMemoryTracker = _value.Read<global::System.Boolean>();  return true;
                case "switchEnableRomCompression": global::UnityEditor.EditorUserBuildSettings.switchEnableRomCompression = _value.Read<global::System.Boolean>();  return true;
                case "switchEnableUnpublishableErrors": global::UnityEditor.EditorUserBuildSettings.switchEnableUnpublishableErrors = _value.Read<global::System.Boolean>();  return true;
                case "switchHTCSScriptDebugging": global::UnityEditor.EditorUserBuildSettings.switchHTCSScriptDebugging = _value.Read<global::System.Boolean>();  return true;
                case "switchNVNAftermath": global::UnityEditor.EditorUserBuildSettings.switchNVNAftermath = _value.Read<global::System.Boolean>();  return true;
                case "switchNVNDrawValidation_Heavy": global::UnityEditor.EditorUserBuildSettings.switchNVNDrawValidation_Heavy = _value.Read<global::System.Boolean>();  return true;
                case "switchNVNDrawValidation_Light": global::UnityEditor.EditorUserBuildSettings.switchNVNDrawValidation_Light = _value.Read<global::System.Boolean>();  return true;
                case "switchNVNGraphicsDebugger": global::UnityEditor.EditorUserBuildSettings.switchNVNGraphicsDebugger = _value.Read<global::System.Boolean>();  return true;
                case "switchNVNShaderDebugging": global::UnityEditor.EditorUserBuildSettings.switchNVNShaderDebugging = _value.Read<global::System.Boolean>();  return true;
                case "switchRomCompressionConfig": global::UnityEditor.EditorUserBuildSettings.switchRomCompressionConfig = _value.Read<global::System.String>();  return true;
                case "switchRomCompressionLevel": global::UnityEditor.EditorUserBuildSettings.switchRomCompressionLevel = _value.Read<global::System.Int32>();  return true;
                case "switchRomCompressionType": global::UnityEditor.EditorUserBuildSettings.switchRomCompressionType = _value.Read<global::UnityEditor.SwitchRomCompressionType>();  return true;
                case "switchSaveADF": global::UnityEditor.EditorUserBuildSettings.switchSaveADF = _value.Read<global::System.Boolean>();  return true;
                case "switchUseLegacyNvnPoolAllocator": global::UnityEditor.EditorUserBuildSettings.switchUseLegacyNvnPoolAllocator = _value.Read<global::System.Boolean>();  return true;
                case "switchWaitForMemoryTrackerOnStartup": global::UnityEditor.EditorUserBuildSettings.switchWaitForMemoryTrackerOnStartup = _value.Read<global::System.Boolean>();  return true;
                case "symlinkSources": global::UnityEditor.EditorUserBuildSettings.symlinkSources = _value.Read<global::System.Boolean>();  return true;
                case "waitForManagedDebugger": global::UnityEditor.EditorUserBuildSettings.waitForManagedDebugger = _value.Read<global::System.Boolean>();  return true;
                case "waitForPlayerConnection": global::UnityEditor.EditorUserBuildSettings.waitForPlayerConnection = _value.Read<global::System.Boolean>();  return true;
                case "webGLBuildSubtarget": global::UnityEditor.EditorUserBuildSettings.webGLBuildSubtarget = _value.Read<global::UnityEditor.WebGLTextureSubtarget>();  return true;
                case "webGLClientBrowserPath": global::UnityEditor.EditorUserBuildSettings.webGLClientBrowserPath = _value.Read<global::System.String>();  return true;
                case "webGLClientBrowserType": global::UnityEditor.EditorUserBuildSettings.webGLClientBrowserType = _value.Read<global::UnityEditor.WebGLClientBrowserType>();  return true;
                case "windowsBuildAndRunDeployTarget": global::UnityEditor.EditorUserBuildSettings.windowsBuildAndRunDeployTarget = _value.Read<global::UnityEditor.WindowsBuildAndRunDeployTarget>();  return true;
                case "windowsDevicePortalAddress": global::UnityEditor.EditorUserBuildSettings.windowsDevicePortalAddress = _value.Read<global::System.String>();  return true;
                case "windowsDevicePortalPassword": global::UnityEditor.EditorUserBuildSettings.windowsDevicePortalPassword = _value.Read<global::System.String>();  return true;
                case "windowsDevicePortalUsername": global::UnityEditor.EditorUserBuildSettings.windowsDevicePortalUsername = _value.Read<global::System.String>();  return true;
                case "wsaArchitecture": global::UnityEditor.EditorUserBuildSettings.wsaArchitecture = _value.Read<global::System.String>();  return true;
                case "wsaBuildAndRunDeployTarget": global::UnityEditor.EditorUserBuildSettings.wsaBuildAndRunDeployTarget = _value.Read<global::UnityEditor.WSABuildAndRunDeployTarget>();  return true;
                case "wsaMinUWPSDK": global::UnityEditor.EditorUserBuildSettings.wsaMinUWPSDK = _value.Read<global::System.String>();  return true;
                case "wsaUWPBuildType": global::UnityEditor.EditorUserBuildSettings.wsaUWPBuildType = _value.Read<global::UnityEditor.WSAUWPBuildType>();  return true;
                case "wsaUWPSDK": global::UnityEditor.EditorUserBuildSettings.wsaUWPSDK = _value.Read<global::System.String>();  return true;
                case "wsaUWPVisualStudioVersion": global::UnityEditor.EditorUserBuildSettings.wsaUWPVisualStudioVersion = _value.Read<global::System.String>();  return true;
                default: return false;
            }
        }
    }
}
#pragma warning restore 0109, 0162, 0168, 0219
#endif
