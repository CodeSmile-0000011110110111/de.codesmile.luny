
// --------------------------------------------------------------
// GENERATED FILE ----> DO NOT EDIT <---- CHANGES WILL BE LOST !!
// --------------------------------------------------------------

#if UNITY_6000_2_OR_NEWER && !(UNITY_6000_3_OR_NEWER)
#pragma warning disable 0109, 0162, 0168, 0219
using Luny;

namespace Luny.UnityEditor
{
    public sealed class LuaPlayerSettings : global::Luny.ILuaObject<global::UnityEditor.PlayerSettings>
    {
        public new static global::Lua.LuaValue Bind(global::UnityEditor.PlayerSettings instance) => new LuaPlayerSettings(instance);
        public new static global::Lua.LuaValue Bind(global::System.Object instance) => Bind((global::UnityEditor.PlayerSettings)instance);
        public new static global::Lua.LuaValue Bind(global::System.Collections.Generic.IList<global::UnityEditor.PlayerSettings> instances) =>
            new global::Luny.LuaList<global::UnityEditor.PlayerSettings>(instances);
        public new static global::Lua.LuaValue Bind(global::System.Collections.Generic.IList<global::System.Object> instances) =>
            new global::Luny.LuaList<global::UnityEditor.PlayerSettings>(instances);
        private LuaPlayerSettings(global::UnityEditor.PlayerSettings instance) => m_Instance = instance;
        public static implicit operator global::Lua.LuaValue(LuaPlayerSettings value) => new(value);
        private global::UnityEditor.PlayerSettings m_Instance;
        public global::UnityEditor.PlayerSettings Instance => m_Instance;
        public new global::System.Type BindType => typeof(global::UnityEditor.PlayerSettings);
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

        private static readonly global::Lua.LuaFunction __index = new(global::Lua.Runtime.Metamethods.Index, (_context, _) =>
        {
            var _this = _context.GetArgument<LuaPlayerSettings>(0);
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
            var _this = _context.GetArgument<LuaPlayerSettings>(0);
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
    public sealed class LuaPlayerSettingsType : global::Luny.ILuaStatic
    {
        public static global::Lua.LuaValue Bind() => new LuaPlayerSettingsType();
        private LuaPlayerSettingsType() {}
        public static implicit operator global::Lua.LuaValue(LuaPlayerSettingsType value) => new(value);
        public global::System.Type BindType => typeof(global::UnityEditor.PlayerSettings);
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

        private static readonly global::Lua.LuaFunction _LuaPlayerSettings_GetAdditionalCompilerArguments = new global::Lua.LuaFunction("GetAdditionalCompilerArguments", (_context, _) =>
        {
            global::Lua.LuaValue _lastArg = default;
            global::System.Int32 _lastArgPos = default;
            global::System.Type _expectedType = default;
            var _argCount = _context.ArgumentCount;
            var _arg0 = _lastArg = _argCount > 0 ? _context.GetArgument(0) : global::Lua.LuaValue.Nil;
            _lastArgPos = 0; _expectedType = typeof(global::Luny.UnityEditor.Build.LuaNamedBuildTarget);
            if (_arg0.TryRead<global::Luny.UnityEditor.Build.LuaNamedBuildTarget>(out var _p0_UnityEditor_Build_NamedBuildTarget))
            {
                if (_argCount == 1)
                {
                    var buildTarget = _p0_UnityEditor_Build_NamedBuildTarget.Value;
                    var _ret0 = global::UnityEditor.PlayerSettings.GetAdditionalCompilerArguments(buildTarget);
                    var _factory = _context.GetObjectFactory();
                    var _lret0 = _factory.Bind(_ret0);
                    var _retCount = _context.Return(_lret0);
                    return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                }
            }
            throw new global::Lua.LuaRuntimeException(_context.Thread, $"{"GetAdditionalCompilerArguments"}: invalid argument #{_lastArgPos}: {_lastArg} ({_lastArg.Type}), expected: {_expectedType.FullName}", 2);
        });
        private static readonly global::Lua.LuaFunction _LuaPlayerSettings_GetAdditionalIl2CppArgs = new global::Lua.LuaFunction("GetAdditionalIl2CppArgs", (_context, _) =>
        {
            global::Lua.LuaValue _lastArg = default;
            global::System.Int32 _lastArgPos = default;
            global::System.Type _expectedType = default;
            var _argCount = _context.ArgumentCount;
            if (_argCount == 0)
            {
                var _ret0 = global::UnityEditor.PlayerSettings.GetAdditionalIl2CppArgs();
                var _lret0 = new global::Lua.LuaValue(_ret0);
                var _retCount = _context.Return(_lret0);
                return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
            }
            throw new global::Lua.LuaRuntimeException(_context.Thread, $"{"GetAdditionalIl2CppArgs"}: invalid argument #{_lastArgPos}: {_lastArg} ({_lastArg.Type}), expected: {_expectedType.FullName}", 2);
        });
        private static readonly global::Lua.LuaFunction _LuaPlayerSettings_GetApiCompatibilityLevel = new global::Lua.LuaFunction("GetApiCompatibilityLevel", (_context, _) =>
        {
            global::Lua.LuaValue _lastArg = default;
            global::System.Int32 _lastArgPos = default;
            global::System.Type _expectedType = default;
            var _argCount = _context.ArgumentCount;
            var _arg0 = _lastArg = _argCount > 0 ? _context.GetArgument(0) : global::Lua.LuaValue.Nil;
            _lastArgPos = 0; _expectedType = typeof(global::Luny.UnityEditor.Build.LuaNamedBuildTarget);
            if (_arg0.TryRead<global::Luny.UnityEditor.Build.LuaNamedBuildTarget>(out var _p0_UnityEditor_Build_NamedBuildTarget))
            {
                if (_argCount == 1)
                {
                    var buildTarget = _p0_UnityEditor_Build_NamedBuildTarget.Value;
                    var _ret0 = global::UnityEditor.PlayerSettings.GetApiCompatibilityLevel(buildTarget);
                    var _lret0 = new global::Lua.LuaValue((global::System.Int64)_ret0);
                    var _retCount = _context.Return(_lret0);
                    return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                }
            }
            throw new global::Lua.LuaRuntimeException(_context.Thread, $"{"GetApiCompatibilityLevel"}: invalid argument #{_lastArgPos}: {_lastArg} ({_lastArg.Type}), expected: {_expectedType.FullName}", 2);
        });
        private static readonly global::Lua.LuaFunction _LuaPlayerSettings_GetApplicationIdentifier = new global::Lua.LuaFunction("GetApplicationIdentifier", (_context, _) =>
        {
            global::Lua.LuaValue _lastArg = default;
            global::System.Int32 _lastArgPos = default;
            global::System.Type _expectedType = default;
            var _argCount = _context.ArgumentCount;
            var _arg0 = _lastArg = _argCount > 0 ? _context.GetArgument(0) : global::Lua.LuaValue.Nil;
            _lastArgPos = 0; _expectedType = typeof(global::Luny.UnityEditor.Build.LuaNamedBuildTarget);
            if (_arg0.TryRead<global::Luny.UnityEditor.Build.LuaNamedBuildTarget>(out var _p0_UnityEditor_Build_NamedBuildTarget))
            {
                if (_argCount == 1)
                {
                    var buildTarget = _p0_UnityEditor_Build_NamedBuildTarget.Value;
                    var _ret0 = global::UnityEditor.PlayerSettings.GetApplicationIdentifier(buildTarget);
                    var _lret0 = new global::Lua.LuaValue(_ret0);
                    var _retCount = _context.Return(_lret0);
                    return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                }
            }
            throw new global::Lua.LuaRuntimeException(_context.Thread, $"{"GetApplicationIdentifier"}: invalid argument #{_lastArgPos}: {_lastArg} ({_lastArg.Type}), expected: {_expectedType.FullName}", 2);
        });
        private static readonly global::Lua.LuaFunction _LuaPlayerSettings_GetArchitecture = new global::Lua.LuaFunction("GetArchitecture", (_context, _) =>
        {
            global::Lua.LuaValue _lastArg = default;
            global::System.Int32 _lastArgPos = default;
            global::System.Type _expectedType = default;
            var _argCount = _context.ArgumentCount;
            var _arg0 = _lastArg = _argCount > 0 ? _context.GetArgument(0) : global::Lua.LuaValue.Nil;
            _lastArgPos = 0; _expectedType = typeof(global::Luny.UnityEditor.Build.LuaNamedBuildTarget);
            if (_arg0.TryRead<global::Luny.UnityEditor.Build.LuaNamedBuildTarget>(out var _p0_UnityEditor_Build_NamedBuildTarget))
            {
                if (_argCount == 1)
                {
                    var buildTarget = _p0_UnityEditor_Build_NamedBuildTarget.Value;
                    var _ret0 = global::UnityEditor.PlayerSettings.GetArchitecture(buildTarget);
                    var _lret0 = new global::Lua.LuaValue(_ret0);
                    var _retCount = _context.Return(_lret0);
                    return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                }
            }
            throw new global::Lua.LuaRuntimeException(_context.Thread, $"{"GetArchitecture"}: invalid argument #{_lastArgPos}: {_lastArg} ({_lastArg.Type}), expected: {_expectedType.FullName}", 2);
        });
        private static readonly global::Lua.LuaFunction _LuaPlayerSettings_GetCaptureStartupLogs = new global::Lua.LuaFunction("GetCaptureStartupLogs", (_context, _) =>
        {
            global::Lua.LuaValue _lastArg = default;
            global::System.Int32 _lastArgPos = default;
            global::System.Type _expectedType = default;
            var _argCount = _context.ArgumentCount;
            var _arg0 = _lastArg = _argCount > 0 ? _context.GetArgument(0) : global::Lua.LuaValue.Nil;
            _lastArgPos = 0; _expectedType = typeof(global::Luny.UnityEditor.Build.LuaNamedBuildTarget);
            if (_arg0.TryRead<global::Luny.UnityEditor.Build.LuaNamedBuildTarget>(out var _p0_UnityEditor_Build_NamedBuildTarget))
            {
                if (_argCount == 1)
                {
                    var buildTarget = _p0_UnityEditor_Build_NamedBuildTarget.Value;
                    var _ret0 = global::UnityEditor.PlayerSettings.GetCaptureStartupLogs(buildTarget);
                    var _lret0 = new global::Lua.LuaValue(_ret0);
                    var _retCount = _context.Return(_lret0);
                    return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                }
            }
            throw new global::Lua.LuaRuntimeException(_context.Thread, $"{"GetCaptureStartupLogs"}: invalid argument #{_lastArgPos}: {_lastArg} ({_lastArg.Type}), expected: {_expectedType.FullName}", 2);
        });
        private static readonly global::Lua.LuaFunction _LuaPlayerSettings_GetDefaultScriptingBackend = new global::Lua.LuaFunction("GetDefaultScriptingBackend", (_context, _) =>
        {
            global::Lua.LuaValue _lastArg = default;
            global::System.Int32 _lastArgPos = default;
            global::System.Type _expectedType = default;
            var _argCount = _context.ArgumentCount;
            var _arg0 = _lastArg = _argCount > 0 ? _context.GetArgument(0) : global::Lua.LuaValue.Nil;
            _lastArgPos = 0; _expectedType = typeof(global::Luny.UnityEditor.Build.LuaNamedBuildTarget);
            if (_arg0.TryRead<global::Luny.UnityEditor.Build.LuaNamedBuildTarget>(out var _p0_UnityEditor_Build_NamedBuildTarget))
            {
                if (_argCount == 1)
                {
                    var buildTarget = _p0_UnityEditor_Build_NamedBuildTarget.Value;
                    var _ret0 = global::UnityEditor.PlayerSettings.GetDefaultScriptingBackend(buildTarget);
                    var _lret0 = new global::Lua.LuaValue((global::System.Int64)_ret0);
                    var _retCount = _context.Return(_lret0);
                    return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                }
            }
            throw new global::Lua.LuaRuntimeException(_context.Thread, $"{"GetDefaultScriptingBackend"}: invalid argument #{_lastArgPos}: {_lastArg} ({_lastArg.Type}), expected: {_expectedType.FullName}", 2);
        });
        private static readonly global::Lua.LuaFunction _LuaPlayerSettings_GetDefaultShaderChunkCount = new global::Lua.LuaFunction("GetDefaultShaderChunkCount", (_context, _) =>
        {
            global::Lua.LuaValue _lastArg = default;
            global::System.Int32 _lastArgPos = default;
            global::System.Type _expectedType = default;
            var _argCount = _context.ArgumentCount;
            if (_argCount == 0)
            {
                var _ret0 = global::UnityEditor.PlayerSettings.GetDefaultShaderChunkCount();
                var _lret0 = new global::Lua.LuaValue(_ret0);
                var _retCount = _context.Return(_lret0);
                return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
            }
            throw new global::Lua.LuaRuntimeException(_context.Thread, $"{"GetDefaultShaderChunkCount"}: invalid argument #{_lastArgPos}: {_lastArg} ({_lastArg.Type}), expected: {_expectedType.FullName}", 2);
        });
        private static readonly global::Lua.LuaFunction _LuaPlayerSettings_GetDefaultShaderChunkSizeInMB = new global::Lua.LuaFunction("GetDefaultShaderChunkSizeInMB", (_context, _) =>
        {
            global::Lua.LuaValue _lastArg = default;
            global::System.Int32 _lastArgPos = default;
            global::System.Type _expectedType = default;
            var _argCount = _context.ArgumentCount;
            if (_argCount == 0)
            {
                var _ret0 = global::UnityEditor.PlayerSettings.GetDefaultShaderChunkSizeInMB();
                var _lret0 = new global::Lua.LuaValue(_ret0);
                var _retCount = _context.Return(_lret0);
                return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
            }
            throw new global::Lua.LuaRuntimeException(_context.Thread, $"{"GetDefaultShaderChunkSizeInMB"}: invalid argument #{_lastArgPos}: {_lastArg} ({_lastArg.Type}), expected: {_expectedType.FullName}", 2);
        });
        private static readonly global::Lua.LuaFunction _LuaPlayerSettings_GetDynamicBatchingForPlatform = new global::Lua.LuaFunction("GetDynamicBatchingForPlatform", (_context, _) =>
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
                    var platform = _p0_UnityEditor_BuildTarget;
                    var _ret0 = global::UnityEditor.PlayerSettings.GetDynamicBatchingForPlatform(platform);
                    var _lret0 = new global::Lua.LuaValue(_ret0);
                    var _retCount = _context.Return(_lret0);
                    return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                }
            }
            throw new global::Lua.LuaRuntimeException(_context.Thread, $"{"GetDynamicBatchingForPlatform"}: invalid argument #{_lastArgPos}: {_lastArg} ({_lastArg.Type}), expected: {_expectedType.FullName}", 2);
        });
        private static readonly global::Lua.LuaFunction _LuaPlayerSettings_GetEditorAssembliesCompatibilityLevel = new global::Lua.LuaFunction("GetEditorAssembliesCompatibilityLevel", (_context, _) =>
        {
            global::Lua.LuaValue _lastArg = default;
            global::System.Int32 _lastArgPos = default;
            global::System.Type _expectedType = default;
            var _argCount = _context.ArgumentCount;
            if (_argCount == 0)
            {
                var _ret0 = global::UnityEditor.PlayerSettings.GetEditorAssembliesCompatibilityLevel();
                var _lret0 = new global::Lua.LuaValue((global::System.Int64)_ret0);
                var _retCount = _context.Return(_lret0);
                return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
            }
            throw new global::Lua.LuaRuntimeException(_context.Thread, $"{"GetEditorAssembliesCompatibilityLevel"}: invalid argument #{_lastArgPos}: {_lastArg} ({_lastArg.Type}), expected: {_expectedType.FullName}", 2);
        });
        private static readonly global::Lua.LuaFunction _LuaPlayerSettings_GetGraphicsAPIs = new global::Lua.LuaFunction("GetGraphicsAPIs", (_context, _) =>
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
                    var platform = _p0_UnityEditor_BuildTarget;
                    var _ret0 = global::UnityEditor.PlayerSettings.GetGraphicsAPIs(platform);
                    var _factory = _context.GetObjectFactory();
                    var _lret0 = _factory.Bind(_ret0);
                    var _retCount = _context.Return(_lret0);
                    return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                }
            }
            throw new global::Lua.LuaRuntimeException(_context.Thread, $"{"GetGraphicsAPIs"}: invalid argument #{_lastArgPos}: {_lastArg} ({_lastArg.Type}), expected: {_expectedType.FullName}", 2);
        });
        private static readonly global::Lua.LuaFunction _LuaPlayerSettings_GetIcons = new global::Lua.LuaFunction("GetIcons", (_context, _) =>
        {
            global::Lua.LuaValue _lastArg = default;
            global::System.Int32 _lastArgPos = default;
            global::System.Type _expectedType = default;
            var _argCount = _context.ArgumentCount;
            var _arg0 = _lastArg = _argCount > 0 ? _context.GetArgument(0) : global::Lua.LuaValue.Nil;
            _lastArgPos = 0; _expectedType = typeof(global::Luny.UnityEditor.Build.LuaNamedBuildTarget);
            if (_arg0.TryRead<global::Luny.UnityEditor.Build.LuaNamedBuildTarget>(out var _p0_UnityEditor_Build_NamedBuildTarget))
            {
                var _arg1 = _lastArg = _argCount > 1 ? _context.GetArgument(1) : global::Lua.LuaValue.Nil;
                _lastArgPos = 1; _expectedType = typeof(global::UnityEditor.IconKind);
                if (_arg1.TryRead<global::UnityEditor.IconKind>(out var _p1_UnityEditor_IconKind))
                {
                    if (_argCount == 2)
                    {
                        var buildTarget = _p0_UnityEditor_Build_NamedBuildTarget.Value;
                        var kind = _p1_UnityEditor_IconKind;
                        var _ret0 = global::UnityEditor.PlayerSettings.GetIcons(buildTarget, kind);
                        var _factory = _context.GetObjectFactory();
                        var _lret0 = _factory.Bind(_ret0);
                        var _retCount = _context.Return(_lret0);
                        return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                    }
                }
            }
            throw new global::Lua.LuaRuntimeException(_context.Thread, $"{"GetIcons"}: invalid argument #{_lastArgPos}: {_lastArg} ({_lastArg.Type}), expected: {_expectedType.FullName}", 2);
        });
        private static readonly global::Lua.LuaFunction _LuaPlayerSettings_GetIconSizes = new global::Lua.LuaFunction("GetIconSizes", (_context, _) =>
        {
            global::Lua.LuaValue _lastArg = default;
            global::System.Int32 _lastArgPos = default;
            global::System.Type _expectedType = default;
            var _argCount = _context.ArgumentCount;
            var _arg0 = _lastArg = _argCount > 0 ? _context.GetArgument(0) : global::Lua.LuaValue.Nil;
            _lastArgPos = 0; _expectedType = typeof(global::Luny.UnityEditor.Build.LuaNamedBuildTarget);
            if (_arg0.TryRead<global::Luny.UnityEditor.Build.LuaNamedBuildTarget>(out var _p0_UnityEditor_Build_NamedBuildTarget))
            {
                var _arg1 = _lastArg = _argCount > 1 ? _context.GetArgument(1) : global::Lua.LuaValue.Nil;
                _lastArgPos = 1; _expectedType = typeof(global::UnityEditor.IconKind);
                if (_arg1.TryRead<global::UnityEditor.IconKind>(out var _p1_UnityEditor_IconKind))
                {
                    if (_argCount == 2)
                    {
                        var buildTarget = _p0_UnityEditor_Build_NamedBuildTarget.Value;
                        var kind = _p1_UnityEditor_IconKind;
                        var _ret0 = global::UnityEditor.PlayerSettings.GetIconSizes(buildTarget, kind);
                        var _factory = _context.GetObjectFactory();
                        var _lret0 = _factory.Bind(_ret0);
                        var _retCount = _context.Return(_lret0);
                        return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                    }
                }
            }
            throw new global::Lua.LuaRuntimeException(_context.Thread, $"{"GetIconSizes"}: invalid argument #{_lastArgPos}: {_lastArg} ({_lastArg.Type}), expected: {_expectedType.FullName}", 2);
        });
        private static readonly global::Lua.LuaFunction _LuaPlayerSettings_GetIl2CppCodeGeneration = new global::Lua.LuaFunction("GetIl2CppCodeGeneration", (_context, _) =>
        {
            global::Lua.LuaValue _lastArg = default;
            global::System.Int32 _lastArgPos = default;
            global::System.Type _expectedType = default;
            var _argCount = _context.ArgumentCount;
            var _arg0 = _lastArg = _argCount > 0 ? _context.GetArgument(0) : global::Lua.LuaValue.Nil;
            _lastArgPos = 0; _expectedType = typeof(global::Luny.UnityEditor.Build.LuaNamedBuildTarget);
            if (_arg0.TryRead<global::Luny.UnityEditor.Build.LuaNamedBuildTarget>(out var _p0_UnityEditor_Build_NamedBuildTarget))
            {
                if (_argCount == 1)
                {
                    var buildTarget = _p0_UnityEditor_Build_NamedBuildTarget.Value;
                    var _ret0 = global::UnityEditor.PlayerSettings.GetIl2CppCodeGeneration(buildTarget);
                    var _lret0 = new global::Lua.LuaValue((global::System.Int64)_ret0);
                    var _retCount = _context.Return(_lret0);
                    return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                }
            }
            throw new global::Lua.LuaRuntimeException(_context.Thread, $"{"GetIl2CppCodeGeneration"}: invalid argument #{_lastArgPos}: {_lastArg} ({_lastArg.Type}), expected: {_expectedType.FullName}", 2);
        });
        private static readonly global::Lua.LuaFunction _LuaPlayerSettings_GetIl2CppCompilerConfiguration = new global::Lua.LuaFunction("GetIl2CppCompilerConfiguration", (_context, _) =>
        {
            global::Lua.LuaValue _lastArg = default;
            global::System.Int32 _lastArgPos = default;
            global::System.Type _expectedType = default;
            var _argCount = _context.ArgumentCount;
            var _arg0 = _lastArg = _argCount > 0 ? _context.GetArgument(0) : global::Lua.LuaValue.Nil;
            _lastArgPos = 0; _expectedType = typeof(global::Luny.UnityEditor.Build.LuaNamedBuildTarget);
            if (_arg0.TryRead<global::Luny.UnityEditor.Build.LuaNamedBuildTarget>(out var _p0_UnityEditor_Build_NamedBuildTarget))
            {
                if (_argCount == 1)
                {
                    var buildTarget = _p0_UnityEditor_Build_NamedBuildTarget.Value;
                    var _ret0 = global::UnityEditor.PlayerSettings.GetIl2CppCompilerConfiguration(buildTarget);
                    var _lret0 = new global::Lua.LuaValue((global::System.Int64)_ret0);
                    var _retCount = _context.Return(_lret0);
                    return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                }
            }
            throw new global::Lua.LuaRuntimeException(_context.Thread, $"{"GetIl2CppCompilerConfiguration"}: invalid argument #{_lastArgPos}: {_lastArg} ({_lastArg.Type}), expected: {_expectedType.FullName}", 2);
        });
        private static readonly global::Lua.LuaFunction _LuaPlayerSettings_GetIl2CppStacktraceInformation = new global::Lua.LuaFunction("GetIl2CppStacktraceInformation", (_context, _) =>
        {
            global::Lua.LuaValue _lastArg = default;
            global::System.Int32 _lastArgPos = default;
            global::System.Type _expectedType = default;
            var _argCount = _context.ArgumentCount;
            var _arg0 = _lastArg = _argCount > 0 ? _context.GetArgument(0) : global::Lua.LuaValue.Nil;
            _lastArgPos = 0; _expectedType = typeof(global::Luny.UnityEditor.Build.LuaNamedBuildTarget);
            if (_arg0.TryRead<global::Luny.UnityEditor.Build.LuaNamedBuildTarget>(out var _p0_UnityEditor_Build_NamedBuildTarget))
            {
                if (_argCount == 1)
                {
                    var buildTarget = _p0_UnityEditor_Build_NamedBuildTarget.Value;
                    var _ret0 = global::UnityEditor.PlayerSettings.GetIl2CppStacktraceInformation(buildTarget);
                    var _lret0 = new global::Lua.LuaValue((global::System.Int64)_ret0);
                    var _retCount = _context.Return(_lret0);
                    return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                }
            }
            throw new global::Lua.LuaRuntimeException(_context.Thread, $"{"GetIl2CppStacktraceInformation"}: invalid argument #{_lastArgPos}: {_lastArg} ({_lastArg.Type}), expected: {_expectedType.FullName}", 2);
        });
        private static readonly global::Lua.LuaFunction _LuaPlayerSettings_GetManagedStrippingLevel = new global::Lua.LuaFunction("GetManagedStrippingLevel", (_context, _) =>
        {
            global::Lua.LuaValue _lastArg = default;
            global::System.Int32 _lastArgPos = default;
            global::System.Type _expectedType = default;
            var _argCount = _context.ArgumentCount;
            var _arg0 = _lastArg = _argCount > 0 ? _context.GetArgument(0) : global::Lua.LuaValue.Nil;
            _lastArgPos = 0; _expectedType = typeof(global::Luny.UnityEditor.Build.LuaNamedBuildTarget);
            if (_arg0.TryRead<global::Luny.UnityEditor.Build.LuaNamedBuildTarget>(out var _p0_UnityEditor_Build_NamedBuildTarget))
            {
                if (_argCount == 1)
                {
                    var buildTarget = _p0_UnityEditor_Build_NamedBuildTarget.Value;
                    var _ret0 = global::UnityEditor.PlayerSettings.GetManagedStrippingLevel(buildTarget);
                    var _lret0 = new global::Lua.LuaValue((global::System.Int64)_ret0);
                    var _retCount = _context.Return(_lret0);
                    return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                }
            }
            throw new global::Lua.LuaRuntimeException(_context.Thread, $"{"GetManagedStrippingLevel"}: invalid argument #{_lastArgPos}: {_lastArg} ({_lastArg.Type}), expected: {_expectedType.FullName}", 2);
        });
        private static readonly global::Lua.LuaFunction _LuaPlayerSettings_GetMobileMTRendering = new global::Lua.LuaFunction("GetMobileMTRendering", (_context, _) =>
        {
            global::Lua.LuaValue _lastArg = default;
            global::System.Int32 _lastArgPos = default;
            global::System.Type _expectedType = default;
            var _argCount = _context.ArgumentCount;
            var _arg0 = _lastArg = _argCount > 0 ? _context.GetArgument(0) : global::Lua.LuaValue.Nil;
            _lastArgPos = 0; _expectedType = typeof(global::Luny.UnityEditor.Build.LuaNamedBuildTarget);
            if (_arg0.TryRead<global::Luny.UnityEditor.Build.LuaNamedBuildTarget>(out var _p0_UnityEditor_Build_NamedBuildTarget))
            {
                if (_argCount == 1)
                {
                    var buildTarget = _p0_UnityEditor_Build_NamedBuildTarget.Value;
                    var _ret0 = global::UnityEditor.PlayerSettings.GetMobileMTRendering(buildTarget);
                    var _lret0 = new global::Lua.LuaValue(_ret0);
                    var _retCount = _context.Return(_lret0);
                    return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                }
            }
            throw new global::Lua.LuaRuntimeException(_context.Thread, $"{"GetMobileMTRendering"}: invalid argument #{_lastArgPos}: {_lastArg} ({_lastArg.Type}), expected: {_expectedType.FullName}", 2);
        });
        private static readonly global::Lua.LuaFunction _LuaPlayerSettings_GetNormalMapEncoding = new global::Lua.LuaFunction("GetNormalMapEncoding", (_context, _) =>
        {
            global::Lua.LuaValue _lastArg = default;
            global::System.Int32 _lastArgPos = default;
            global::System.Type _expectedType = default;
            var _argCount = _context.ArgumentCount;
            var _arg0 = _lastArg = _argCount > 0 ? _context.GetArgument(0) : global::Lua.LuaValue.Nil;
            _lastArgPos = 0; _expectedType = typeof(global::Luny.UnityEditor.Build.LuaNamedBuildTarget);
            if (_arg0.TryRead<global::Luny.UnityEditor.Build.LuaNamedBuildTarget>(out var _p0_UnityEditor_Build_NamedBuildTarget))
            {
                if (_argCount == 1)
                {
                    var buildTarget = _p0_UnityEditor_Build_NamedBuildTarget.Value;
                    var _ret0 = global::UnityEditor.PlayerSettings.GetNormalMapEncoding(buildTarget);
                    var _lret0 = new global::Lua.LuaValue((global::System.Int64)_ret0);
                    var _retCount = _context.Return(_lret0);
                    return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                }
            }
            throw new global::Lua.LuaRuntimeException(_context.Thread, $"{"GetNormalMapEncoding"}: invalid argument #{_lastArgPos}: {_lastArg} ({_lastArg.Type}), expected: {_expectedType.FullName}", 2);
        });
        private static readonly global::Lua.LuaFunction _LuaPlayerSettings_GetOverrideShaderChunkSettingsForPlatform = new global::Lua.LuaFunction("GetOverrideShaderChunkSettingsForPlatform", (_context, _) =>
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
                    var buildTarget = _p0_UnityEditor_BuildTarget;
                    var _ret0 = global::UnityEditor.PlayerSettings.GetOverrideShaderChunkSettingsForPlatform(buildTarget);
                    var _lret0 = new global::Lua.LuaValue(_ret0);
                    var _retCount = _context.Return(_lret0);
                    return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                }
            }
            throw new global::Lua.LuaRuntimeException(_context.Thread, $"{"GetOverrideShaderChunkSettingsForPlatform"}: invalid argument #{_lastArgPos}: {_lastArg} ({_lastArg.Type}), expected: {_expectedType.FullName}", 2);
        });
        private static readonly global::Lua.LuaFunction _LuaPlayerSettings_GetPlatformIcons = new global::Lua.LuaFunction("GetPlatformIcons", (_context, _) =>
        {
            global::Lua.LuaValue _lastArg = default;
            global::System.Int32 _lastArgPos = default;
            global::System.Type _expectedType = default;
            var _argCount = _context.ArgumentCount;
            var _arg0 = _lastArg = _argCount > 0 ? _context.GetArgument(0) : global::Lua.LuaValue.Nil;
            _lastArgPos = 0; _expectedType = typeof(global::Luny.UnityEditor.Build.LuaNamedBuildTarget);
            if (_arg0.TryRead<global::Luny.UnityEditor.Build.LuaNamedBuildTarget>(out var _p0_UnityEditor_Build_NamedBuildTarget))
            {
                var _arg1 = _lastArg = _argCount > 1 ? _context.GetArgument(1) : global::Lua.LuaValue.Nil;
                _lastArgPos = 1; _expectedType = typeof(global::Luny.UnityEditor.LuaPlatformIconKind);
                if (_arg1.TryRead<global::Luny.UnityEditor.LuaPlatformIconKind>(out var _p1_UnityEditor_PlatformIconKind))
                {
                    if (_argCount == 2)
                    {
                        var buildTarget = _p0_UnityEditor_Build_NamedBuildTarget.Value;
                        var kind = _p1_UnityEditor_PlatformIconKind.Instance;
                        var _ret0 = global::UnityEditor.PlayerSettings.GetPlatformIcons(buildTarget, kind);
                        var _factory = _context.GetObjectFactory();
                        var _lret0 = _factory.Bind(_ret0);
                        var _retCount = _context.Return(_lret0);
                        return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                    }
                }
            }
            throw new global::Lua.LuaRuntimeException(_context.Thread, $"{"GetPlatformIcons"}: invalid argument #{_lastArgPos}: {_lastArg} ({_lastArg.Type}), expected: {_expectedType.FullName}", 2);
        });
        private static readonly global::Lua.LuaFunction _LuaPlayerSettings_GetPreloadedAssets = new global::Lua.LuaFunction("GetPreloadedAssets", (_context, _) =>
        {
            global::Lua.LuaValue _lastArg = default;
            global::System.Int32 _lastArgPos = default;
            global::System.Type _expectedType = default;
            var _argCount = _context.ArgumentCount;
            if (_argCount == 0)
            {
                var _ret0 = global::UnityEditor.PlayerSettings.GetPreloadedAssets();
                var _factory = _context.GetObjectFactory();
                var _lret0 = _factory.Bind(_ret0);
                var _retCount = _context.Return(_lret0);
                return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
            }
            throw new global::Lua.LuaRuntimeException(_context.Thread, $"{"GetPreloadedAssets"}: invalid argument #{_lastArgPos}: {_lastArg} ({_lastArg.Type}), expected: {_expectedType.FullName}", 2);
        });
        private static readonly global::Lua.LuaFunction _LuaPlayerSettings_GetScriptingBackend = new global::Lua.LuaFunction("GetScriptingBackend", (_context, _) =>
        {
            global::Lua.LuaValue _lastArg = default;
            global::System.Int32 _lastArgPos = default;
            global::System.Type _expectedType = default;
            var _argCount = _context.ArgumentCount;
            var _arg0 = _lastArg = _argCount > 0 ? _context.GetArgument(0) : global::Lua.LuaValue.Nil;
            _lastArgPos = 0; _expectedType = typeof(global::Luny.UnityEditor.Build.LuaNamedBuildTarget);
            if (_arg0.TryRead<global::Luny.UnityEditor.Build.LuaNamedBuildTarget>(out var _p0_UnityEditor_Build_NamedBuildTarget))
            {
                if (_argCount == 1)
                {
                    var buildTarget = _p0_UnityEditor_Build_NamedBuildTarget.Value;
                    var _ret0 = global::UnityEditor.PlayerSettings.GetScriptingBackend(buildTarget);
                    var _lret0 = new global::Lua.LuaValue((global::System.Int64)_ret0);
                    var _retCount = _context.Return(_lret0);
                    return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                }
            }
            throw new global::Lua.LuaRuntimeException(_context.Thread, $"{"GetScriptingBackend"}: invalid argument #{_lastArgPos}: {_lastArg} ({_lastArg.Type}), expected: {_expectedType.FullName}", 2);
        });
        private static readonly global::Lua.LuaFunction _LuaPlayerSettings_GetScriptingDefineSymbols = new global::Lua.LuaFunction("GetScriptingDefineSymbols", (_context, _) =>
        {
            global::Lua.LuaValue _lastArg = default;
            global::System.Int32 _lastArgPos = default;
            global::System.Type _expectedType = default;
            var _argCount = _context.ArgumentCount;
            var _arg0 = _lastArg = _argCount > 0 ? _context.GetArgument(0) : global::Lua.LuaValue.Nil;
            _lastArgPos = 0; _expectedType = typeof(global::Luny.UnityEditor.Build.LuaNamedBuildTarget);
            if (_arg0.TryRead<global::Luny.UnityEditor.Build.LuaNamedBuildTarget>(out var _p0_UnityEditor_Build_NamedBuildTarget))
            {
                if (_argCount == 1)
                {
                    var buildTarget = _p0_UnityEditor_Build_NamedBuildTarget.Value;
                    var _ret0 = global::UnityEditor.PlayerSettings.GetScriptingDefineSymbols(buildTarget);
                    var _lret0 = new global::Lua.LuaValue(_ret0);
                    var _retCount = _context.Return(_lret0);
                    return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                }
            }
            throw new global::Lua.LuaRuntimeException(_context.Thread, $"{"GetScriptingDefineSymbols"}: invalid argument #{_lastArgPos}: {_lastArg} ({_lastArg.Type}), expected: {_expectedType.FullName}", 2);
        });
        private static readonly global::Lua.LuaFunction _LuaPlayerSettings_GetShaderChunkCountForPlatform = new global::Lua.LuaFunction("GetShaderChunkCountForPlatform", (_context, _) =>
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
                    var buildTarget = _p0_UnityEditor_BuildTarget;
                    var _ret0 = global::UnityEditor.PlayerSettings.GetShaderChunkCountForPlatform(buildTarget);
                    var _lret0 = new global::Lua.LuaValue(_ret0);
                    var _retCount = _context.Return(_lret0);
                    return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                }
            }
            throw new global::Lua.LuaRuntimeException(_context.Thread, $"{"GetShaderChunkCountForPlatform"}: invalid argument #{_lastArgPos}: {_lastArg} ({_lastArg.Type}), expected: {_expectedType.FullName}", 2);
        });
        private static readonly global::Lua.LuaFunction _LuaPlayerSettings_GetShaderChunkSizeInMBForPlatform = new global::Lua.LuaFunction("GetShaderChunkSizeInMBForPlatform", (_context, _) =>
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
                    var buildTarget = _p0_UnityEditor_BuildTarget;
                    var _ret0 = global::UnityEditor.PlayerSettings.GetShaderChunkSizeInMBForPlatform(buildTarget);
                    var _lret0 = new global::Lua.LuaValue(_ret0);
                    var _retCount = _context.Return(_lret0);
                    return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                }
            }
            throw new global::Lua.LuaRuntimeException(_context.Thread, $"{"GetShaderChunkSizeInMBForPlatform"}: invalid argument #{_lastArgPos}: {_lastArg} ({_lastArg.Type}), expected: {_expectedType.FullName}", 2);
        });
        private static readonly global::Lua.LuaFunction _LuaPlayerSettings_GetShaderPrecisionModel = new global::Lua.LuaFunction("GetShaderPrecisionModel", (_context, _) =>
        {
            global::Lua.LuaValue _lastArg = default;
            global::System.Int32 _lastArgPos = default;
            global::System.Type _expectedType = default;
            var _argCount = _context.ArgumentCount;
            if (_argCount == 0)
            {
                var _ret0 = global::UnityEditor.PlayerSettings.GetShaderPrecisionModel();
                var _lret0 = new global::Lua.LuaValue((global::System.Int64)_ret0);
                var _retCount = _context.Return(_lret0);
                return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
            }
            throw new global::Lua.LuaRuntimeException(_context.Thread, $"{"GetShaderPrecisionModel"}: invalid argument #{_lastArgPos}: {_lastArg} ({_lastArg.Type}), expected: {_expectedType.FullName}", 2);
        });
        private static readonly global::Lua.LuaFunction _LuaPlayerSettings_GetStackTraceLogType = new global::Lua.LuaFunction("GetStackTraceLogType", (_context, _) =>
        {
            global::Lua.LuaValue _lastArg = default;
            global::System.Int32 _lastArgPos = default;
            global::System.Type _expectedType = default;
            var _argCount = _context.ArgumentCount;
            var _arg0 = _lastArg = _argCount > 0 ? _context.GetArgument(0) : global::Lua.LuaValue.Nil;
            _lastArgPos = 0; _expectedType = typeof(global::UnityEngine.LogType);
            if (_arg0.TryRead<global::UnityEngine.LogType>(out var _p0_UnityEngine_LogType))
            {
                if (_argCount == 1)
                {
                    var logType = _p0_UnityEngine_LogType;
                    var _ret0 = global::UnityEditor.PlayerSettings.GetStackTraceLogType(logType);
                    var _lret0 = new global::Lua.LuaValue((global::System.Int64)_ret0);
                    var _retCount = _context.Return(_lret0);
                    return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                }
            }
            throw new global::Lua.LuaRuntimeException(_context.Thread, $"{"GetStackTraceLogType"}: invalid argument #{_lastArgPos}: {_lastArg} ({_lastArg.Type}), expected: {_expectedType.FullName}", 2);
        });
        private static readonly global::Lua.LuaFunction _LuaPlayerSettings_GetStaticBatchingForPlatform = new global::Lua.LuaFunction("GetStaticBatchingForPlatform", (_context, _) =>
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
                    var platform = _p0_UnityEditor_BuildTarget;
                    var _ret0 = global::UnityEditor.PlayerSettings.GetStaticBatchingForPlatform(platform);
                    var _lret0 = new global::Lua.LuaValue(_ret0);
                    var _retCount = _context.Return(_lret0);
                    return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                }
            }
            throw new global::Lua.LuaRuntimeException(_context.Thread, $"{"GetStaticBatchingForPlatform"}: invalid argument #{_lastArgPos}: {_lastArg} ({_lastArg.Type}), expected: {_expectedType.FullName}", 2);
        });
        private static readonly global::Lua.LuaFunction _LuaPlayerSettings_GetSupportedIconKinds = new global::Lua.LuaFunction("GetSupportedIconKinds", (_context, _) =>
        {
            global::Lua.LuaValue _lastArg = default;
            global::System.Int32 _lastArgPos = default;
            global::System.Type _expectedType = default;
            var _argCount = _context.ArgumentCount;
            var _arg0 = _lastArg = _argCount > 0 ? _context.GetArgument(0) : global::Lua.LuaValue.Nil;
            _lastArgPos = 0; _expectedType = typeof(global::Luny.UnityEditor.Build.LuaNamedBuildTarget);
            if (_arg0.TryRead<global::Luny.UnityEditor.Build.LuaNamedBuildTarget>(out var _p0_UnityEditor_Build_NamedBuildTarget))
            {
                if (_argCount == 1)
                {
                    var buildTarget = _p0_UnityEditor_Build_NamedBuildTarget.Value;
                    var _ret0 = global::UnityEditor.PlayerSettings.GetSupportedIconKinds(buildTarget);
                    var _factory = _context.GetObjectFactory();
                    var _lret0 = _factory.Bind(_ret0);
                    var _retCount = _context.Return(_lret0);
                    return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                }
            }
            throw new global::Lua.LuaRuntimeException(_context.Thread, $"{"GetSupportedIconKinds"}: invalid argument #{_lastArgPos}: {_lastArg} ({_lastArg.Type}), expected: {_expectedType.FullName}", 2);
        });
        private static readonly global::Lua.LuaFunction _LuaPlayerSettings_GetTemplateCustomValue = new global::Lua.LuaFunction("GetTemplateCustomValue", (_context, _) =>
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
                    var _ret0 = global::UnityEditor.PlayerSettings.GetTemplateCustomValue(name);
                    var _lret0 = new global::Lua.LuaValue(_ret0);
                    var _retCount = _context.Return(_lret0);
                    return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                }
            }
            throw new global::Lua.LuaRuntimeException(_context.Thread, $"{"GetTemplateCustomValue"}: invalid argument #{_lastArgPos}: {_lastArg} ({_lastArg.Type}), expected: {_expectedType.FullName}", 2);
        });
        private static readonly global::Lua.LuaFunction _LuaPlayerSettings_GetUseDefaultGraphicsAPIs = new global::Lua.LuaFunction("GetUseDefaultGraphicsAPIs", (_context, _) =>
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
                    var platform = _p0_UnityEditor_BuildTarget;
                    var _ret0 = global::UnityEditor.PlayerSettings.GetUseDefaultGraphicsAPIs(platform);
                    var _lret0 = new global::Lua.LuaValue(_ret0);
                    var _retCount = _context.Return(_lret0);
                    return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                }
            }
            throw new global::Lua.LuaRuntimeException(_context.Thread, $"{"GetUseDefaultGraphicsAPIs"}: invalid argument #{_lastArgPos}: {_lastArg} ({_lastArg.Type}), expected: {_expectedType.FullName}", 2);
        });
        private static readonly global::Lua.LuaFunction _LuaPlayerSettings_GetVirtualTexturingSupportEnabled = new global::Lua.LuaFunction("GetVirtualTexturingSupportEnabled", (_context, _) =>
        {
            global::Lua.LuaValue _lastArg = default;
            global::System.Int32 _lastArgPos = default;
            global::System.Type _expectedType = default;
            var _argCount = _context.ArgumentCount;
            if (_argCount == 0)
            {
                var _ret0 = global::UnityEditor.PlayerSettings.GetVirtualTexturingSupportEnabled();
                var _lret0 = new global::Lua.LuaValue(_ret0);
                var _retCount = _context.Return(_lret0);
                return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
            }
            throw new global::Lua.LuaRuntimeException(_context.Thread, $"{"GetVirtualTexturingSupportEnabled"}: invalid argument #{_lastArgPos}: {_lastArg} ({_lastArg.Type}), expected: {_expectedType.FullName}", 2);
        });
        private static readonly global::Lua.LuaFunction _LuaPlayerSettings_GetWsaHolographicRemotingEnabled = new global::Lua.LuaFunction("GetWsaHolographicRemotingEnabled", (_context, _) =>
        {
            global::Lua.LuaValue _lastArg = default;
            global::System.Int32 _lastArgPos = default;
            global::System.Type _expectedType = default;
            var _argCount = _context.ArgumentCount;
            if (_argCount == 0)
            {
                var _ret0 = global::UnityEditor.PlayerSettings.GetWsaHolographicRemotingEnabled();
                var _lret0 = new global::Lua.LuaValue(_ret0);
                var _retCount = _context.Return(_lret0);
                return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
            }
            throw new global::Lua.LuaRuntimeException(_context.Thread, $"{"GetWsaHolographicRemotingEnabled"}: invalid argument #{_lastArgPos}: {_lastArg} ({_lastArg.Type}), expected: {_expectedType.FullName}", 2);
        });
        private static readonly global::Lua.LuaFunction _LuaPlayerSettings_SetAdditionalCompilerArguments = new global::Lua.LuaFunction("SetAdditionalCompilerArguments", (_context, _) =>
        {
            global::Lua.LuaValue _lastArg = default;
            global::System.Int32 _lastArgPos = default;
            global::System.Type _expectedType = default;
            var _argCount = _context.ArgumentCount;
            var _arg0 = _lastArg = _argCount > 0 ? _context.GetArgument(0) : global::Lua.LuaValue.Nil;
            _lastArgPos = 0; _expectedType = typeof(global::Luny.UnityEditor.Build.LuaNamedBuildTarget);
            if (_arg0.TryRead<global::Luny.UnityEditor.Build.LuaNamedBuildTarget>(out var _p0_UnityEditor_Build_NamedBuildTarget))
            {
                var _arg1 = _lastArg = _argCount > 1 ? _context.GetArgument(1) : global::Lua.LuaValue.Nil;
                _lastArgPos = 1; _expectedType = typeof(global::System.String[]);
                if (_arg1.TryReadArray<global::System.String>(out var _p1_System_StringArray))
                {
                    if (_argCount == 2)
                    {
                        var buildTarget = _p0_UnityEditor_Build_NamedBuildTarget.Value;
                        var additionalCompilerArguments = _p1_System_StringArray;
                        global::UnityEditor.PlayerSettings.SetAdditionalCompilerArguments(buildTarget, additionalCompilerArguments);
                        var _retCount = _context.Return();
                        return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                    }
                }
            }
            throw new global::Lua.LuaRuntimeException(_context.Thread, $"{"SetAdditionalCompilerArguments"}: invalid argument #{_lastArgPos}: {_lastArg} ({_lastArg.Type}), expected: {_expectedType.FullName}", 2);
        });
        private static readonly global::Lua.LuaFunction _LuaPlayerSettings_SetAdditionalIl2CppArgs = new global::Lua.LuaFunction("SetAdditionalIl2CppArgs", (_context, _) =>
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
                    var additionalArgs = _p0_System_String;
                    global::UnityEditor.PlayerSettings.SetAdditionalIl2CppArgs(additionalArgs);
                    var _retCount = _context.Return();
                    return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                }
            }
            throw new global::Lua.LuaRuntimeException(_context.Thread, $"{"SetAdditionalIl2CppArgs"}: invalid argument #{_lastArgPos}: {_lastArg} ({_lastArg.Type}), expected: {_expectedType.FullName}", 2);
        });
        private static readonly global::Lua.LuaFunction _LuaPlayerSettings_SetApiCompatibilityLevel = new global::Lua.LuaFunction("SetApiCompatibilityLevel", (_context, _) =>
        {
            global::Lua.LuaValue _lastArg = default;
            global::System.Int32 _lastArgPos = default;
            global::System.Type _expectedType = default;
            var _argCount = _context.ArgumentCount;
            var _arg0 = _lastArg = _argCount > 0 ? _context.GetArgument(0) : global::Lua.LuaValue.Nil;
            _lastArgPos = 0; _expectedType = typeof(global::Luny.UnityEditor.Build.LuaNamedBuildTarget);
            if (_arg0.TryRead<global::Luny.UnityEditor.Build.LuaNamedBuildTarget>(out var _p0_UnityEditor_Build_NamedBuildTarget))
            {
                var _arg1 = _lastArg = _argCount > 1 ? _context.GetArgument(1) : global::Lua.LuaValue.Nil;
                _lastArgPos = 1; _expectedType = typeof(global::UnityEditor.ApiCompatibilityLevel);
                if (_arg1.TryRead<global::UnityEditor.ApiCompatibilityLevel>(out var _p1_UnityEditor_ApiCompatibilityLevel))
                {
                    if (_argCount == 2)
                    {
                        var buildTarget = _p0_UnityEditor_Build_NamedBuildTarget.Value;
                        var value = _p1_UnityEditor_ApiCompatibilityLevel;
                        global::UnityEditor.PlayerSettings.SetApiCompatibilityLevel(buildTarget, value);
                        var _retCount = _context.Return();
                        return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                    }
                }
            }
            throw new global::Lua.LuaRuntimeException(_context.Thread, $"{"SetApiCompatibilityLevel"}: invalid argument #{_lastArgPos}: {_lastArg} ({_lastArg.Type}), expected: {_expectedType.FullName}", 2);
        });
        private static readonly global::Lua.LuaFunction _LuaPlayerSettings_SetApplicationIdentifier = new global::Lua.LuaFunction("SetApplicationIdentifier", (_context, _) =>
        {
            global::Lua.LuaValue _lastArg = default;
            global::System.Int32 _lastArgPos = default;
            global::System.Type _expectedType = default;
            var _argCount = _context.ArgumentCount;
            var _arg0 = _lastArg = _argCount > 0 ? _context.GetArgument(0) : global::Lua.LuaValue.Nil;
            _lastArgPos = 0; _expectedType = typeof(global::Luny.UnityEditor.Build.LuaNamedBuildTarget);
            if (_arg0.TryRead<global::Luny.UnityEditor.Build.LuaNamedBuildTarget>(out var _p0_UnityEditor_Build_NamedBuildTarget))
            {
                var _arg1 = _lastArg = _argCount > 1 ? _context.GetArgument(1) : global::Lua.LuaValue.Nil;
                _lastArgPos = 1; _expectedType = typeof(global::System.String);
                if (_arg1.TryRead<global::System.String>(out var _p1_System_String))
                {
                    if (_argCount == 2)
                    {
                        var buildTarget = _p0_UnityEditor_Build_NamedBuildTarget.Value;
                        var identifier = _p1_System_String;
                        global::UnityEditor.PlayerSettings.SetApplicationIdentifier(buildTarget, identifier);
                        var _retCount = _context.Return();
                        return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                    }
                }
            }
            throw new global::Lua.LuaRuntimeException(_context.Thread, $"{"SetApplicationIdentifier"}: invalid argument #{_lastArgPos}: {_lastArg} ({_lastArg.Type}), expected: {_expectedType.FullName}", 2);
        });
        private static readonly global::Lua.LuaFunction _LuaPlayerSettings_SetArchitecture = new global::Lua.LuaFunction("SetArchitecture", (_context, _) =>
        {
            global::Lua.LuaValue _lastArg = default;
            global::System.Int32 _lastArgPos = default;
            global::System.Type _expectedType = default;
            var _argCount = _context.ArgumentCount;
            var _arg0 = _lastArg = _argCount > 0 ? _context.GetArgument(0) : global::Lua.LuaValue.Nil;
            _lastArgPos = 0; _expectedType = typeof(global::Luny.UnityEditor.Build.LuaNamedBuildTarget);
            if (_arg0.TryRead<global::Luny.UnityEditor.Build.LuaNamedBuildTarget>(out var _p0_UnityEditor_Build_NamedBuildTarget))
            {
                var _arg1 = _lastArg = _argCount > 1 ? _context.GetArgument(1) : global::Lua.LuaValue.Nil;
                _lastArgPos = 1; _expectedType = typeof(global::System.Int32);
                if (_arg1.TryRead<global::System.Int32>(out var _p1_System_Int32))
                {
                    if (_argCount == 2)
                    {
                        var buildTarget = _p0_UnityEditor_Build_NamedBuildTarget.Value;
                        var architecture = _p1_System_Int32;
                        global::UnityEditor.PlayerSettings.SetArchitecture(buildTarget, architecture);
                        var _retCount = _context.Return();
                        return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                    }
                }
            }
            throw new global::Lua.LuaRuntimeException(_context.Thread, $"{"SetArchitecture"}: invalid argument #{_lastArgPos}: {_lastArg} ({_lastArg.Type}), expected: {_expectedType.FullName}", 2);
        });
        private static readonly global::Lua.LuaFunction _LuaPlayerSettings_SetCaptureStartupLogs = new global::Lua.LuaFunction("SetCaptureStartupLogs", (_context, _) =>
        {
            global::Lua.LuaValue _lastArg = default;
            global::System.Int32 _lastArgPos = default;
            global::System.Type _expectedType = default;
            var _argCount = _context.ArgumentCount;
            var _arg0 = _lastArg = _argCount > 0 ? _context.GetArgument(0) : global::Lua.LuaValue.Nil;
            _lastArgPos = 0; _expectedType = typeof(global::Luny.UnityEditor.Build.LuaNamedBuildTarget);
            if (_arg0.TryRead<global::Luny.UnityEditor.Build.LuaNamedBuildTarget>(out var _p0_UnityEditor_Build_NamedBuildTarget))
            {
                var _arg1 = _lastArg = _argCount > 1 ? _context.GetArgument(1) : global::Lua.LuaValue.Nil;
                _lastArgPos = 1; _expectedType = typeof(global::System.Boolean);
                if (_arg1.TryRead<global::System.Boolean>(out var _p1_System_Boolean))
                {
                    if (_argCount == 2)
                    {
                        var buildTarget = _p0_UnityEditor_Build_NamedBuildTarget.Value;
                        var enable = _p1_System_Boolean;
                        global::UnityEditor.PlayerSettings.SetCaptureStartupLogs(buildTarget, enable);
                        var _retCount = _context.Return();
                        return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                    }
                }
            }
            throw new global::Lua.LuaRuntimeException(_context.Thread, $"{"SetCaptureStartupLogs"}: invalid argument #{_lastArgPos}: {_lastArg} ({_lastArg.Type}), expected: {_expectedType.FullName}", 2);
        });
        private static readonly global::Lua.LuaFunction _LuaPlayerSettings_SetDefaultShaderChunkCount = new global::Lua.LuaFunction("SetDefaultShaderChunkCount", (_context, _) =>
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
                    var chunkCount = _p0_System_Int32;
                    global::UnityEditor.PlayerSettings.SetDefaultShaderChunkCount(chunkCount);
                    var _retCount = _context.Return();
                    return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                }
            }
            throw new global::Lua.LuaRuntimeException(_context.Thread, $"{"SetDefaultShaderChunkCount"}: invalid argument #{_lastArgPos}: {_lastArg} ({_lastArg.Type}), expected: {_expectedType.FullName}", 2);
        });
        private static readonly global::Lua.LuaFunction _LuaPlayerSettings_SetDefaultShaderChunkSizeInMB = new global::Lua.LuaFunction("SetDefaultShaderChunkSizeInMB", (_context, _) =>
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
                    var sizeInMegabytes = _p0_System_Int32;
                    global::UnityEditor.PlayerSettings.SetDefaultShaderChunkSizeInMB(sizeInMegabytes);
                    var _retCount = _context.Return();
                    return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                }
            }
            throw new global::Lua.LuaRuntimeException(_context.Thread, $"{"SetDefaultShaderChunkSizeInMB"}: invalid argument #{_lastArgPos}: {_lastArg} ({_lastArg.Type}), expected: {_expectedType.FullName}", 2);
        });
        private static readonly global::Lua.LuaFunction _LuaPlayerSettings_SetDynamicBatchingForPlatform = new global::Lua.LuaFunction("SetDynamicBatchingForPlatform", (_context, _) =>
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
                _lastArgPos = 1; _expectedType = typeof(global::System.Boolean);
                if (_arg1.TryRead<global::System.Boolean>(out var _p1_System_Boolean))
                {
                    if (_argCount == 2)
                    {
                        var platform = _p0_UnityEditor_BuildTarget;
                        var enable = _p1_System_Boolean;
                        global::UnityEditor.PlayerSettings.SetDynamicBatchingForPlatform(platform, enable);
                        var _retCount = _context.Return();
                        return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                    }
                }
            }
            throw new global::Lua.LuaRuntimeException(_context.Thread, $"{"SetDynamicBatchingForPlatform"}: invalid argument #{_lastArgPos}: {_lastArg} ({_lastArg.Type}), expected: {_expectedType.FullName}", 2);
        });
        private static readonly global::Lua.LuaFunction _LuaPlayerSettings_SetEditorAssembliesCompatibilityLevel = new global::Lua.LuaFunction("SetEditorAssembliesCompatibilityLevel", (_context, _) =>
        {
            global::Lua.LuaValue _lastArg = default;
            global::System.Int32 _lastArgPos = default;
            global::System.Type _expectedType = default;
            var _argCount = _context.ArgumentCount;
            var _arg0 = _lastArg = _argCount > 0 ? _context.GetArgument(0) : global::Lua.LuaValue.Nil;
            _lastArgPos = 0; _expectedType = typeof(global::UnityEditor.EditorAssembliesCompatibilityLevel);
            if (_arg0.TryRead<global::UnityEditor.EditorAssembliesCompatibilityLevel>(out var _p0_UnityEditor_EditorAssembliesCompatibilityLevel))
            {
                if (_argCount == 1)
                {
                    var value = _p0_UnityEditor_EditorAssembliesCompatibilityLevel;
                    global::UnityEditor.PlayerSettings.SetEditorAssembliesCompatibilityLevel(value);
                    var _retCount = _context.Return();
                    return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                }
            }
            throw new global::Lua.LuaRuntimeException(_context.Thread, $"{"SetEditorAssembliesCompatibilityLevel"}: invalid argument #{_lastArgPos}: {_lastArg} ({_lastArg.Type}), expected: {_expectedType.FullName}", 2);
        });
        private static readonly global::Lua.LuaFunction _LuaPlayerSettings_SetGraphicsAPIs = new global::Lua.LuaFunction("SetGraphicsAPIs", (_context, _) =>
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
                _lastArgPos = 1; _expectedType = typeof(global::UnityEngine.Rendering.GraphicsDeviceType[]);
                if (_arg1.TryReadArray<global::UnityEngine.Rendering.GraphicsDeviceType>(out var _p1_UnityEngine_Rendering_GraphicsDeviceTypeArray))
                {
                    if (_argCount == 2)
                    {
                        var platform = _p0_UnityEditor_BuildTarget;
                        var apis = _p1_UnityEngine_Rendering_GraphicsDeviceTypeArray;
                        global::UnityEditor.PlayerSettings.SetGraphicsAPIs(platform, apis);
                        var _retCount = _context.Return();
                        return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                    }
                }
            }
            throw new global::Lua.LuaRuntimeException(_context.Thread, $"{"SetGraphicsAPIs"}: invalid argument #{_lastArgPos}: {_lastArg} ({_lastArg.Type}), expected: {_expectedType.FullName}", 2);
        });
        private static readonly global::Lua.LuaFunction _LuaPlayerSettings_SetIcons = new global::Lua.LuaFunction("SetIcons", (_context, _) =>
        {
            global::Lua.LuaValue _lastArg = default;
            global::System.Int32 _lastArgPos = default;
            global::System.Type _expectedType = default;
            var _argCount = _context.ArgumentCount;
            var _arg0 = _lastArg = _argCount > 0 ? _context.GetArgument(0) : global::Lua.LuaValue.Nil;
            _lastArgPos = 0; _expectedType = typeof(global::Luny.UnityEditor.Build.LuaNamedBuildTarget);
            if (_arg0.TryRead<global::Luny.UnityEditor.Build.LuaNamedBuildTarget>(out var _p0_UnityEditor_Build_NamedBuildTarget))
            {
                var _arg1 = _lastArg = _argCount > 1 ? _context.GetArgument(1) : global::Lua.LuaValue.Nil;
                _lastArgPos = 1; _expectedType = typeof(global::UnityEngine.Texture2D[]);
                if (_arg1.TryReadArray<global::UnityEngine.Texture2D>(out var _p1_UnityEngine_Texture2DArray))
                {
                    var _arg2 = _lastArg = _argCount > 2 ? _context.GetArgument(2) : global::Lua.LuaValue.Nil;
                    _lastArgPos = 2; _expectedType = typeof(global::UnityEditor.IconKind);
                    if (_arg2.TryRead<global::UnityEditor.IconKind>(out var _p2_UnityEditor_IconKind))
                    {
                        if (_argCount == 3)
                        {
                            var buildTarget = _p0_UnityEditor_Build_NamedBuildTarget.Value;
                            var icons = _p1_UnityEngine_Texture2DArray;
                            var kind = _p2_UnityEditor_IconKind;
                            global::UnityEditor.PlayerSettings.SetIcons(buildTarget, icons, kind);
                            var _retCount = _context.Return();
                            return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                        }
                    }
                }
            }
            throw new global::Lua.LuaRuntimeException(_context.Thread, $"{"SetIcons"}: invalid argument #{_lastArgPos}: {_lastArg} ({_lastArg.Type}), expected: {_expectedType.FullName}", 2);
        });
        private static readonly global::Lua.LuaFunction _LuaPlayerSettings_SetIl2CppCodeGeneration = new global::Lua.LuaFunction("SetIl2CppCodeGeneration", (_context, _) =>
        {
            global::Lua.LuaValue _lastArg = default;
            global::System.Int32 _lastArgPos = default;
            global::System.Type _expectedType = default;
            var _argCount = _context.ArgumentCount;
            var _arg0 = _lastArg = _argCount > 0 ? _context.GetArgument(0) : global::Lua.LuaValue.Nil;
            _lastArgPos = 0; _expectedType = typeof(global::Luny.UnityEditor.Build.LuaNamedBuildTarget);
            if (_arg0.TryRead<global::Luny.UnityEditor.Build.LuaNamedBuildTarget>(out var _p0_UnityEditor_Build_NamedBuildTarget))
            {
                var _arg1 = _lastArg = _argCount > 1 ? _context.GetArgument(1) : global::Lua.LuaValue.Nil;
                _lastArgPos = 1; _expectedType = typeof(global::UnityEditor.Build.Il2CppCodeGeneration);
                if (_arg1.TryRead<global::UnityEditor.Build.Il2CppCodeGeneration>(out var _p1_UnityEditor_Build_Il2CppCodeGeneration))
                {
                    if (_argCount == 2)
                    {
                        var buildTarget = _p0_UnityEditor_Build_NamedBuildTarget.Value;
                        var value = _p1_UnityEditor_Build_Il2CppCodeGeneration;
                        global::UnityEditor.PlayerSettings.SetIl2CppCodeGeneration(buildTarget, value);
                        var _retCount = _context.Return();
                        return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                    }
                }
            }
            throw new global::Lua.LuaRuntimeException(_context.Thread, $"{"SetIl2CppCodeGeneration"}: invalid argument #{_lastArgPos}: {_lastArg} ({_lastArg.Type}), expected: {_expectedType.FullName}", 2);
        });
        private static readonly global::Lua.LuaFunction _LuaPlayerSettings_SetIl2CppCompilerConfiguration = new global::Lua.LuaFunction("SetIl2CppCompilerConfiguration", (_context, _) =>
        {
            global::Lua.LuaValue _lastArg = default;
            global::System.Int32 _lastArgPos = default;
            global::System.Type _expectedType = default;
            var _argCount = _context.ArgumentCount;
            var _arg0 = _lastArg = _argCount > 0 ? _context.GetArgument(0) : global::Lua.LuaValue.Nil;
            _lastArgPos = 0; _expectedType = typeof(global::Luny.UnityEditor.Build.LuaNamedBuildTarget);
            if (_arg0.TryRead<global::Luny.UnityEditor.Build.LuaNamedBuildTarget>(out var _p0_UnityEditor_Build_NamedBuildTarget))
            {
                var _arg1 = _lastArg = _argCount > 1 ? _context.GetArgument(1) : global::Lua.LuaValue.Nil;
                _lastArgPos = 1; _expectedType = typeof(global::UnityEditor.Il2CppCompilerConfiguration);
                if (_arg1.TryRead<global::UnityEditor.Il2CppCompilerConfiguration>(out var _p1_UnityEditor_Il2CppCompilerConfiguration))
                {
                    if (_argCount == 2)
                    {
                        var buildTarget = _p0_UnityEditor_Build_NamedBuildTarget.Value;
                        var configuration = _p1_UnityEditor_Il2CppCompilerConfiguration;
                        global::UnityEditor.PlayerSettings.SetIl2CppCompilerConfiguration(buildTarget, configuration);
                        var _retCount = _context.Return();
                        return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                    }
                }
            }
            throw new global::Lua.LuaRuntimeException(_context.Thread, $"{"SetIl2CppCompilerConfiguration"}: invalid argument #{_lastArgPos}: {_lastArg} ({_lastArg.Type}), expected: {_expectedType.FullName}", 2);
        });
        private static readonly global::Lua.LuaFunction _LuaPlayerSettings_SetIl2CppStacktraceInformation = new global::Lua.LuaFunction("SetIl2CppStacktraceInformation", (_context, _) =>
        {
            global::Lua.LuaValue _lastArg = default;
            global::System.Int32 _lastArgPos = default;
            global::System.Type _expectedType = default;
            var _argCount = _context.ArgumentCount;
            var _arg0 = _lastArg = _argCount > 0 ? _context.GetArgument(0) : global::Lua.LuaValue.Nil;
            _lastArgPos = 0; _expectedType = typeof(global::Luny.UnityEditor.Build.LuaNamedBuildTarget);
            if (_arg0.TryRead<global::Luny.UnityEditor.Build.LuaNamedBuildTarget>(out var _p0_UnityEditor_Build_NamedBuildTarget))
            {
                var _arg1 = _lastArg = _argCount > 1 ? _context.GetArgument(1) : global::Lua.LuaValue.Nil;
                _lastArgPos = 1; _expectedType = typeof(global::UnityEditor.Il2CppStacktraceInformation);
                if (_arg1.TryRead<global::UnityEditor.Il2CppStacktraceInformation>(out var _p1_UnityEditor_Il2CppStacktraceInformation))
                {
                    if (_argCount == 2)
                    {
                        var buildTarget = _p0_UnityEditor_Build_NamedBuildTarget.Value;
                        var option = _p1_UnityEditor_Il2CppStacktraceInformation;
                        global::UnityEditor.PlayerSettings.SetIl2CppStacktraceInformation(buildTarget, option);
                        var _retCount = _context.Return();
                        return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                    }
                }
            }
            throw new global::Lua.LuaRuntimeException(_context.Thread, $"{"SetIl2CppStacktraceInformation"}: invalid argument #{_lastArgPos}: {_lastArg} ({_lastArg.Type}), expected: {_expectedType.FullName}", 2);
        });
        private static readonly global::Lua.LuaFunction _LuaPlayerSettings_SetManagedStrippingLevel = new global::Lua.LuaFunction("SetManagedStrippingLevel", (_context, _) =>
        {
            global::Lua.LuaValue _lastArg = default;
            global::System.Int32 _lastArgPos = default;
            global::System.Type _expectedType = default;
            var _argCount = _context.ArgumentCount;
            var _arg0 = _lastArg = _argCount > 0 ? _context.GetArgument(0) : global::Lua.LuaValue.Nil;
            _lastArgPos = 0; _expectedType = typeof(global::Luny.UnityEditor.Build.LuaNamedBuildTarget);
            if (_arg0.TryRead<global::Luny.UnityEditor.Build.LuaNamedBuildTarget>(out var _p0_UnityEditor_Build_NamedBuildTarget))
            {
                var _arg1 = _lastArg = _argCount > 1 ? _context.GetArgument(1) : global::Lua.LuaValue.Nil;
                _lastArgPos = 1; _expectedType = typeof(global::UnityEditor.ManagedStrippingLevel);
                if (_arg1.TryRead<global::UnityEditor.ManagedStrippingLevel>(out var _p1_UnityEditor_ManagedStrippingLevel))
                {
                    if (_argCount == 2)
                    {
                        var buildTarget = _p0_UnityEditor_Build_NamedBuildTarget.Value;
                        var level = _p1_UnityEditor_ManagedStrippingLevel;
                        global::UnityEditor.PlayerSettings.SetManagedStrippingLevel(buildTarget, level);
                        var _retCount = _context.Return();
                        return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                    }
                }
            }
            throw new global::Lua.LuaRuntimeException(_context.Thread, $"{"SetManagedStrippingLevel"}: invalid argument #{_lastArgPos}: {_lastArg} ({_lastArg.Type}), expected: {_expectedType.FullName}", 2);
        });
        private static readonly global::Lua.LuaFunction _LuaPlayerSettings_SetMobileMTRendering = new global::Lua.LuaFunction("SetMobileMTRendering", (_context, _) =>
        {
            global::Lua.LuaValue _lastArg = default;
            global::System.Int32 _lastArgPos = default;
            global::System.Type _expectedType = default;
            var _argCount = _context.ArgumentCount;
            var _arg0 = _lastArg = _argCount > 0 ? _context.GetArgument(0) : global::Lua.LuaValue.Nil;
            _lastArgPos = 0; _expectedType = typeof(global::Luny.UnityEditor.Build.LuaNamedBuildTarget);
            if (_arg0.TryRead<global::Luny.UnityEditor.Build.LuaNamedBuildTarget>(out var _p0_UnityEditor_Build_NamedBuildTarget))
            {
                var _arg1 = _lastArg = _argCount > 1 ? _context.GetArgument(1) : global::Lua.LuaValue.Nil;
                _lastArgPos = 1; _expectedType = typeof(global::System.Boolean);
                if (_arg1.TryRead<global::System.Boolean>(out var _p1_System_Boolean))
                {
                    if (_argCount == 2)
                    {
                        var buildTarget = _p0_UnityEditor_Build_NamedBuildTarget.Value;
                        var enable = _p1_System_Boolean;
                        global::UnityEditor.PlayerSettings.SetMobileMTRendering(buildTarget, enable);
                        var _retCount = _context.Return();
                        return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                    }
                }
            }
            throw new global::Lua.LuaRuntimeException(_context.Thread, $"{"SetMobileMTRendering"}: invalid argument #{_lastArgPos}: {_lastArg} ({_lastArg.Type}), expected: {_expectedType.FullName}", 2);
        });
        private static readonly global::Lua.LuaFunction _LuaPlayerSettings_SetNormalMapEncoding = new global::Lua.LuaFunction("SetNormalMapEncoding", (_context, _) =>
        {
            global::Lua.LuaValue _lastArg = default;
            global::System.Int32 _lastArgPos = default;
            global::System.Type _expectedType = default;
            var _argCount = _context.ArgumentCount;
            var _arg0 = _lastArg = _argCount > 0 ? _context.GetArgument(0) : global::Lua.LuaValue.Nil;
            _lastArgPos = 0; _expectedType = typeof(global::Luny.UnityEditor.Build.LuaNamedBuildTarget);
            if (_arg0.TryRead<global::Luny.UnityEditor.Build.LuaNamedBuildTarget>(out var _p0_UnityEditor_Build_NamedBuildTarget))
            {
                var _arg1 = _lastArg = _argCount > 1 ? _context.GetArgument(1) : global::Lua.LuaValue.Nil;
                _lastArgPos = 1; _expectedType = typeof(global::UnityEditor.NormalMapEncoding);
                if (_arg1.TryRead<global::UnityEditor.NormalMapEncoding>(out var _p1_UnityEditor_NormalMapEncoding))
                {
                    if (_argCount == 2)
                    {
                        var buildTarget = _p0_UnityEditor_Build_NamedBuildTarget.Value;
                        var encoding = _p1_UnityEditor_NormalMapEncoding;
                        global::UnityEditor.PlayerSettings.SetNormalMapEncoding(buildTarget, encoding);
                        var _retCount = _context.Return();
                        return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                    }
                }
            }
            throw new global::Lua.LuaRuntimeException(_context.Thread, $"{"SetNormalMapEncoding"}: invalid argument #{_lastArgPos}: {_lastArg} ({_lastArg.Type}), expected: {_expectedType.FullName}", 2);
        });
        private static readonly global::Lua.LuaFunction _LuaPlayerSettings_SetOverrideShaderChunkSettingsForPlatform = new global::Lua.LuaFunction("SetOverrideShaderChunkSettingsForPlatform", (_context, _) =>
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
                _lastArgPos = 1; _expectedType = typeof(global::System.Boolean);
                if (_arg1.TryRead<global::System.Boolean>(out var _p1_System_Boolean))
                {
                    if (_argCount == 2)
                    {
                        var buildTarget = _p0_UnityEditor_BuildTarget;
                        var value = _p1_System_Boolean;
                        global::UnityEditor.PlayerSettings.SetOverrideShaderChunkSettingsForPlatform(buildTarget, value);
                        var _retCount = _context.Return();
                        return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                    }
                }
            }
            throw new global::Lua.LuaRuntimeException(_context.Thread, $"{"SetOverrideShaderChunkSettingsForPlatform"}: invalid argument #{_lastArgPos}: {_lastArg} ({_lastArg.Type}), expected: {_expectedType.FullName}", 2);
        });
        private static readonly global::Lua.LuaFunction _LuaPlayerSettings_SetPlatformIcons = new global::Lua.LuaFunction("SetPlatformIcons", (_context, _) =>
        {
            global::Lua.LuaValue _lastArg = default;
            global::System.Int32 _lastArgPos = default;
            global::System.Type _expectedType = default;
            var _argCount = _context.ArgumentCount;
            var _arg0 = _lastArg = _argCount > 0 ? _context.GetArgument(0) : global::Lua.LuaValue.Nil;
            _lastArgPos = 0; _expectedType = typeof(global::Luny.UnityEditor.Build.LuaNamedBuildTarget);
            if (_arg0.TryRead<global::Luny.UnityEditor.Build.LuaNamedBuildTarget>(out var _p0_UnityEditor_Build_NamedBuildTarget))
            {
                var _arg1 = _lastArg = _argCount > 1 ? _context.GetArgument(1) : global::Lua.LuaValue.Nil;
                _lastArgPos = 1; _expectedType = typeof(global::Luny.UnityEditor.LuaPlatformIconKind);
                if (_arg1.TryRead<global::Luny.UnityEditor.LuaPlatformIconKind>(out var _p1_UnityEditor_PlatformIconKind))
                {
                    var _arg2 = _lastArg = _argCount > 2 ? _context.GetArgument(2) : global::Lua.LuaValue.Nil;
                    _lastArgPos = 2; _expectedType = typeof(global::UnityEditor.PlatformIcon[]);
                    if (_arg2.TryReadArray<global::UnityEditor.PlatformIcon>(out var _p2_UnityEditor_PlatformIconArray))
                    {
                        if (_argCount == 3)
                        {
                            var buildTarget = _p0_UnityEditor_Build_NamedBuildTarget.Value;
                            var kind = _p1_UnityEditor_PlatformIconKind.Instance;
                            var icons = _p2_UnityEditor_PlatformIconArray;
                            global::UnityEditor.PlayerSettings.SetPlatformIcons(buildTarget, kind, icons);
                            var _retCount = _context.Return();
                            return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                        }
                    }
                }
            }
            throw new global::Lua.LuaRuntimeException(_context.Thread, $"{"SetPlatformIcons"}: invalid argument #{_lastArgPos}: {_lastArg} ({_lastArg.Type}), expected: {_expectedType.FullName}", 2);
        });
        private static readonly global::Lua.LuaFunction _LuaPlayerSettings_SetPreloadedAssets = new global::Lua.LuaFunction("SetPreloadedAssets", (_context, _) =>
        {
            global::Lua.LuaValue _lastArg = default;
            global::System.Int32 _lastArgPos = default;
            global::System.Type _expectedType = default;
            var _argCount = _context.ArgumentCount;
            var _arg0 = _lastArg = _argCount > 0 ? _context.GetArgument(0) : global::Lua.LuaValue.Nil;
            _lastArgPos = 0; _expectedType = typeof(global::UnityEngine.Object[]);
            if (_arg0.TryReadArray<global::UnityEngine.Object>(out var _p0_UnityEngine_ObjectArray))
            {
                if (_argCount == 1)
                {
                    var assets = _p0_UnityEngine_ObjectArray;
                    global::UnityEditor.PlayerSettings.SetPreloadedAssets(assets);
                    var _retCount = _context.Return();
                    return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                }
            }
            throw new global::Lua.LuaRuntimeException(_context.Thread, $"{"SetPreloadedAssets"}: invalid argument #{_lastArgPos}: {_lastArg} ({_lastArg.Type}), expected: {_expectedType.FullName}", 2);
        });
        private static readonly global::Lua.LuaFunction _LuaPlayerSettings_SetScriptingBackend = new global::Lua.LuaFunction("SetScriptingBackend", (_context, _) =>
        {
            global::Lua.LuaValue _lastArg = default;
            global::System.Int32 _lastArgPos = default;
            global::System.Type _expectedType = default;
            var _argCount = _context.ArgumentCount;
            var _arg0 = _lastArg = _argCount > 0 ? _context.GetArgument(0) : global::Lua.LuaValue.Nil;
            _lastArgPos = 0; _expectedType = typeof(global::Luny.UnityEditor.Build.LuaNamedBuildTarget);
            if (_arg0.TryRead<global::Luny.UnityEditor.Build.LuaNamedBuildTarget>(out var _p0_UnityEditor_Build_NamedBuildTarget))
            {
                var _arg1 = _lastArg = _argCount > 1 ? _context.GetArgument(1) : global::Lua.LuaValue.Nil;
                _lastArgPos = 1; _expectedType = typeof(global::UnityEditor.ScriptingImplementation);
                if (_arg1.TryRead<global::UnityEditor.ScriptingImplementation>(out var _p1_UnityEditor_ScriptingImplementation))
                {
                    if (_argCount == 2)
                    {
                        var buildTarget = _p0_UnityEditor_Build_NamedBuildTarget.Value;
                        var backend = _p1_UnityEditor_ScriptingImplementation;
                        global::UnityEditor.PlayerSettings.SetScriptingBackend(buildTarget, backend);
                        var _retCount = _context.Return();
                        return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                    }
                }
            }
            throw new global::Lua.LuaRuntimeException(_context.Thread, $"{"SetScriptingBackend"}: invalid argument #{_lastArgPos}: {_lastArg} ({_lastArg.Type}), expected: {_expectedType.FullName}", 2);
        });
        private static readonly global::Lua.LuaFunction _LuaPlayerSettings_SetScriptingDefineSymbols = new global::Lua.LuaFunction("SetScriptingDefineSymbols", (_context, _) =>
        {
            global::Lua.LuaValue _lastArg = default;
            global::System.Int32 _lastArgPos = default;
            global::System.Type _expectedType = default;
            var _argCount = _context.ArgumentCount;
            var _arg0 = _lastArg = _argCount > 0 ? _context.GetArgument(0) : global::Lua.LuaValue.Nil;
            _lastArgPos = 0; _expectedType = typeof(global::Luny.UnityEditor.Build.LuaNamedBuildTarget);
            if (_arg0.TryRead<global::Luny.UnityEditor.Build.LuaNamedBuildTarget>(out var _p0_UnityEditor_Build_NamedBuildTarget))
            {
                var _arg1 = _lastArg = _argCount > 1 ? _context.GetArgument(1) : global::Lua.LuaValue.Nil;
                _lastArgPos = 1; _expectedType = typeof(global::System.String);
                if (_arg1.TryRead<global::System.String>(out var _p1_System_String))
                {
                    if (_argCount == 2)
                    {
                        var buildTarget = _p0_UnityEditor_Build_NamedBuildTarget.Value;
                        var defines = _p1_System_String;
                        global::UnityEditor.PlayerSettings.SetScriptingDefineSymbols(buildTarget, defines);
                        var _retCount = _context.Return();
                        return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                    }
                }
                _lastArgPos = 1; _expectedType = typeof(global::System.String[]);
                if (_arg1.TryReadArray<global::System.String>(out var _p1_System_StringArray))
                {
                    if (_argCount == 2)
                    {
                        var buildTarget = _p0_UnityEditor_Build_NamedBuildTarget.Value;
                        var defines = _p1_System_StringArray;
                        global::UnityEditor.PlayerSettings.SetScriptingDefineSymbols(buildTarget, defines);
                        var _retCount = _context.Return();
                        return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                    }
                }
            }
            throw new global::Lua.LuaRuntimeException(_context.Thread, $"{"SetScriptingDefineSymbols"}: invalid argument #{_lastArgPos}: {_lastArg} ({_lastArg.Type}), expected: {_expectedType.FullName}", 2);
        });
        private static readonly global::Lua.LuaFunction _LuaPlayerSettings_SetShaderChunkCountForPlatform = new global::Lua.LuaFunction("SetShaderChunkCountForPlatform", (_context, _) =>
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
                _lastArgPos = 1; _expectedType = typeof(global::System.Int32);
                if (_arg1.TryRead<global::System.Int32>(out var _p1_System_Int32))
                {
                    if (_argCount == 2)
                    {
                        var buildTarget = _p0_UnityEditor_BuildTarget;
                        var chunkCount = _p1_System_Int32;
                        global::UnityEditor.PlayerSettings.SetShaderChunkCountForPlatform(buildTarget, chunkCount);
                        var _retCount = _context.Return();
                        return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                    }
                }
            }
            throw new global::Lua.LuaRuntimeException(_context.Thread, $"{"SetShaderChunkCountForPlatform"}: invalid argument #{_lastArgPos}: {_lastArg} ({_lastArg.Type}), expected: {_expectedType.FullName}", 2);
        });
        private static readonly global::Lua.LuaFunction _LuaPlayerSettings_SetShaderChunkSizeInMBForPlatform = new global::Lua.LuaFunction("SetShaderChunkSizeInMBForPlatform", (_context, _) =>
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
                _lastArgPos = 1; _expectedType = typeof(global::System.Int32);
                if (_arg1.TryRead<global::System.Int32>(out var _p1_System_Int32))
                {
                    if (_argCount == 2)
                    {
                        var buildTarget = _p0_UnityEditor_BuildTarget;
                        var sizeInMegabytes = _p1_System_Int32;
                        global::UnityEditor.PlayerSettings.SetShaderChunkSizeInMBForPlatform(buildTarget, sizeInMegabytes);
                        var _retCount = _context.Return();
                        return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                    }
                }
            }
            throw new global::Lua.LuaRuntimeException(_context.Thread, $"{"SetShaderChunkSizeInMBForPlatform"}: invalid argument #{_lastArgPos}: {_lastArg} ({_lastArg.Type}), expected: {_expectedType.FullName}", 2);
        });
        private static readonly global::Lua.LuaFunction _LuaPlayerSettings_SetShaderPrecisionModel = new global::Lua.LuaFunction("SetShaderPrecisionModel", (_context, _) =>
        {
            global::Lua.LuaValue _lastArg = default;
            global::System.Int32 _lastArgPos = default;
            global::System.Type _expectedType = default;
            var _argCount = _context.ArgumentCount;
            var _arg0 = _lastArg = _argCount > 0 ? _context.GetArgument(0) : global::Lua.LuaValue.Nil;
            _lastArgPos = 0; _expectedType = typeof(global::UnityEditor.ShaderPrecisionModel);
            if (_arg0.TryRead<global::UnityEditor.ShaderPrecisionModel>(out var _p0_UnityEditor_ShaderPrecisionModel))
            {
                if (_argCount == 1)
                {
                    var model = _p0_UnityEditor_ShaderPrecisionModel;
                    global::UnityEditor.PlayerSettings.SetShaderPrecisionModel(model);
                    var _retCount = _context.Return();
                    return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                }
            }
            throw new global::Lua.LuaRuntimeException(_context.Thread, $"{"SetShaderPrecisionModel"}: invalid argument #{_lastArgPos}: {_lastArg} ({_lastArg.Type}), expected: {_expectedType.FullName}", 2);
        });
        private static readonly global::Lua.LuaFunction _LuaPlayerSettings_SetStackTraceLogType = new global::Lua.LuaFunction("SetStackTraceLogType", (_context, _) =>
        {
            global::Lua.LuaValue _lastArg = default;
            global::System.Int32 _lastArgPos = default;
            global::System.Type _expectedType = default;
            var _argCount = _context.ArgumentCount;
            var _arg0 = _lastArg = _argCount > 0 ? _context.GetArgument(0) : global::Lua.LuaValue.Nil;
            _lastArgPos = 0; _expectedType = typeof(global::UnityEngine.LogType);
            if (_arg0.TryRead<global::UnityEngine.LogType>(out var _p0_UnityEngine_LogType))
            {
                var _arg1 = _lastArg = _argCount > 1 ? _context.GetArgument(1) : global::Lua.LuaValue.Nil;
                _lastArgPos = 1; _expectedType = typeof(global::UnityEngine.StackTraceLogType);
                if (_arg1.TryRead<global::UnityEngine.StackTraceLogType>(out var _p1_UnityEngine_StackTraceLogType))
                {
                    if (_argCount == 2)
                    {
                        var logType = _p0_UnityEngine_LogType;
                        var stackTraceType = _p1_UnityEngine_StackTraceLogType;
                        global::UnityEditor.PlayerSettings.SetStackTraceLogType(logType, stackTraceType);
                        var _retCount = _context.Return();
                        return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                    }
                }
            }
            throw new global::Lua.LuaRuntimeException(_context.Thread, $"{"SetStackTraceLogType"}: invalid argument #{_lastArgPos}: {_lastArg} ({_lastArg.Type}), expected: {_expectedType.FullName}", 2);
        });
        private static readonly global::Lua.LuaFunction _LuaPlayerSettings_SetStaticBatchingForPlatform = new global::Lua.LuaFunction("SetStaticBatchingForPlatform", (_context, _) =>
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
                _lastArgPos = 1; _expectedType = typeof(global::System.Boolean);
                if (_arg1.TryRead<global::System.Boolean>(out var _p1_System_Boolean))
                {
                    if (_argCount == 2)
                    {
                        var platform = _p0_UnityEditor_BuildTarget;
                        var enable = _p1_System_Boolean;
                        global::UnityEditor.PlayerSettings.SetStaticBatchingForPlatform(platform, enable);
                        var _retCount = _context.Return();
                        return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                    }
                }
            }
            throw new global::Lua.LuaRuntimeException(_context.Thread, $"{"SetStaticBatchingForPlatform"}: invalid argument #{_lastArgPos}: {_lastArg} ({_lastArg.Type}), expected: {_expectedType.FullName}", 2);
        });
        private static readonly global::Lua.LuaFunction _LuaPlayerSettings_SetTemplateCustomValue = new global::Lua.LuaFunction("SetTemplateCustomValue", (_context, _) =>
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
                        var name = _p0_System_String;
                        var value = _p1_System_String;
                        global::UnityEditor.PlayerSettings.SetTemplateCustomValue(name, value);
                        var _retCount = _context.Return();
                        return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                    }
                }
            }
            throw new global::Lua.LuaRuntimeException(_context.Thread, $"{"SetTemplateCustomValue"}: invalid argument #{_lastArgPos}: {_lastArg} ({_lastArg.Type}), expected: {_expectedType.FullName}", 2);
        });
        private static readonly global::Lua.LuaFunction _LuaPlayerSettings_SetUseDefaultGraphicsAPIs = new global::Lua.LuaFunction("SetUseDefaultGraphicsAPIs", (_context, _) =>
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
                _lastArgPos = 1; _expectedType = typeof(global::System.Boolean);
                if (_arg1.TryRead<global::System.Boolean>(out var _p1_System_Boolean))
                {
                    if (_argCount == 2)
                    {
                        var platform = _p0_UnityEditor_BuildTarget;
                        var automatic = _p1_System_Boolean;
                        global::UnityEditor.PlayerSettings.SetUseDefaultGraphicsAPIs(platform, automatic);
                        var _retCount = _context.Return();
                        return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                    }
                }
            }
            throw new global::Lua.LuaRuntimeException(_context.Thread, $"{"SetUseDefaultGraphicsAPIs"}: invalid argument #{_lastArgPos}: {_lastArg} ({_lastArg.Type}), expected: {_expectedType.FullName}", 2);
        });
        private static readonly global::Lua.LuaFunction _LuaPlayerSettings_SetVirtualTexturingSupportEnabled = new global::Lua.LuaFunction("SetVirtualTexturingSupportEnabled", (_context, _) =>
        {
            global::Lua.LuaValue _lastArg = default;
            global::System.Int32 _lastArgPos = default;
            global::System.Type _expectedType = default;
            var _argCount = _context.ArgumentCount;
            var _arg0 = _lastArg = _argCount > 0 ? _context.GetArgument(0) : global::Lua.LuaValue.Nil;
            _lastArgPos = 0; _expectedType = typeof(global::System.Boolean);
            if (_arg0.TryRead<global::System.Boolean>(out var _p0_System_Boolean))
            {
                if (_argCount == 1)
                {
                    var enabled = _p0_System_Boolean;
                    global::UnityEditor.PlayerSettings.SetVirtualTexturingSupportEnabled(enabled);
                    var _retCount = _context.Return();
                    return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                }
            }
            throw new global::Lua.LuaRuntimeException(_context.Thread, $"{"SetVirtualTexturingSupportEnabled"}: invalid argument #{_lastArgPos}: {_lastArg} ({_lastArg.Type}), expected: {_expectedType.FullName}", 2);
        });
        private static readonly global::Lua.LuaFunction _LuaPlayerSettings_SetWsaHolographicRemotingEnabled = new global::Lua.LuaFunction("SetWsaHolographicRemotingEnabled", (_context, _) =>
        {
            global::Lua.LuaValue _lastArg = default;
            global::System.Int32 _lastArgPos = default;
            global::System.Type _expectedType = default;
            var _argCount = _context.ArgumentCount;
            var _arg0 = _lastArg = _argCount > 0 ? _context.GetArgument(0) : global::Lua.LuaValue.Nil;
            _lastArgPos = 0; _expectedType = typeof(global::System.Boolean);
            if (_arg0.TryRead<global::System.Boolean>(out var _p0_System_Boolean))
            {
                if (_argCount == 1)
                {
                    var enabled = _p0_System_Boolean;
                    global::UnityEditor.PlayerSettings.SetWsaHolographicRemotingEnabled(enabled);
                    var _retCount = _context.Return();
                    return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                }
            }
            throw new global::Lua.LuaRuntimeException(_context.Thread, $"{"SetWsaHolographicRemotingEnabled"}: invalid argument #{_lastArgPos}: {_lastArg} ({_lastArg.Type}), expected: {_expectedType.FullName}", 2);
        });
        private static readonly global::Lua.LuaFunction __index = new(global::Lua.Runtime.Metamethods.Index, (_context, _) =>
        {
            var _this = _context.GetArgument<LuaPlayerSettingsType>(0);
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
            var _this = _context.GetArgument<LuaPlayerSettingsType>(0);
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
                case "GetAdditionalCompilerArguments": _value = _LuaPlayerSettings_GetAdditionalCompilerArguments; return true;
                case "GetAdditionalIl2CppArgs": _value = _LuaPlayerSettings_GetAdditionalIl2CppArgs; return true;
                case "GetApiCompatibilityLevel": _value = _LuaPlayerSettings_GetApiCompatibilityLevel; return true;
                case "GetApplicationIdentifier": _value = _LuaPlayerSettings_GetApplicationIdentifier; return true;
                case "GetArchitecture": _value = _LuaPlayerSettings_GetArchitecture; return true;
                case "GetCaptureStartupLogs": _value = _LuaPlayerSettings_GetCaptureStartupLogs; return true;
                case "GetDefaultScriptingBackend": _value = _LuaPlayerSettings_GetDefaultScriptingBackend; return true;
                case "GetDefaultShaderChunkCount": _value = _LuaPlayerSettings_GetDefaultShaderChunkCount; return true;
                case "GetDefaultShaderChunkSizeInMB": _value = _LuaPlayerSettings_GetDefaultShaderChunkSizeInMB; return true;
                case "GetDynamicBatchingForPlatform": _value = _LuaPlayerSettings_GetDynamicBatchingForPlatform; return true;
                case "GetEditorAssembliesCompatibilityLevel": _value = _LuaPlayerSettings_GetEditorAssembliesCompatibilityLevel; return true;
                case "GetGraphicsAPIs": _value = _LuaPlayerSettings_GetGraphicsAPIs; return true;
                case "GetIcons": _value = _LuaPlayerSettings_GetIcons; return true;
                case "GetIconSizes": _value = _LuaPlayerSettings_GetIconSizes; return true;
                case "GetIl2CppCodeGeneration": _value = _LuaPlayerSettings_GetIl2CppCodeGeneration; return true;
                case "GetIl2CppCompilerConfiguration": _value = _LuaPlayerSettings_GetIl2CppCompilerConfiguration; return true;
                case "GetIl2CppStacktraceInformation": _value = _LuaPlayerSettings_GetIl2CppStacktraceInformation; return true;
                case "GetManagedStrippingLevel": _value = _LuaPlayerSettings_GetManagedStrippingLevel; return true;
                case "GetMobileMTRendering": _value = _LuaPlayerSettings_GetMobileMTRendering; return true;
                case "GetNormalMapEncoding": _value = _LuaPlayerSettings_GetNormalMapEncoding; return true;
                case "GetOverrideShaderChunkSettingsForPlatform": _value = _LuaPlayerSettings_GetOverrideShaderChunkSettingsForPlatform; return true;
                case "GetPlatformIcons": _value = _LuaPlayerSettings_GetPlatformIcons; return true;
                case "GetPreloadedAssets": _value = _LuaPlayerSettings_GetPreloadedAssets; return true;
                case "GetScriptingBackend": _value = _LuaPlayerSettings_GetScriptingBackend; return true;
                case "GetScriptingDefineSymbols": _value = _LuaPlayerSettings_GetScriptingDefineSymbols; return true;
                case "GetShaderChunkCountForPlatform": _value = _LuaPlayerSettings_GetShaderChunkCountForPlatform; return true;
                case "GetShaderChunkSizeInMBForPlatform": _value = _LuaPlayerSettings_GetShaderChunkSizeInMBForPlatform; return true;
                case "GetShaderPrecisionModel": _value = _LuaPlayerSettings_GetShaderPrecisionModel; return true;
                case "GetStackTraceLogType": _value = _LuaPlayerSettings_GetStackTraceLogType; return true;
                case "GetStaticBatchingForPlatform": _value = _LuaPlayerSettings_GetStaticBatchingForPlatform; return true;
                case "GetSupportedIconKinds": _value = _LuaPlayerSettings_GetSupportedIconKinds; return true;
                case "GetTemplateCustomValue": _value = _LuaPlayerSettings_GetTemplateCustomValue; return true;
                case "GetUseDefaultGraphicsAPIs": _value = _LuaPlayerSettings_GetUseDefaultGraphicsAPIs; return true;
                case "GetVirtualTexturingSupportEnabled": _value = _LuaPlayerSettings_GetVirtualTexturingSupportEnabled; return true;
                case "GetWsaHolographicRemotingEnabled": _value = _LuaPlayerSettings_GetWsaHolographicRemotingEnabled; return true;
                case "SetAdditionalCompilerArguments": _value = _LuaPlayerSettings_SetAdditionalCompilerArguments; return true;
                case "SetAdditionalIl2CppArgs": _value = _LuaPlayerSettings_SetAdditionalIl2CppArgs; return true;
                case "SetApiCompatibilityLevel": _value = _LuaPlayerSettings_SetApiCompatibilityLevel; return true;
                case "SetApplicationIdentifier": _value = _LuaPlayerSettings_SetApplicationIdentifier; return true;
                case "SetArchitecture": _value = _LuaPlayerSettings_SetArchitecture; return true;
                case "SetCaptureStartupLogs": _value = _LuaPlayerSettings_SetCaptureStartupLogs; return true;
                case "SetDefaultShaderChunkCount": _value = _LuaPlayerSettings_SetDefaultShaderChunkCount; return true;
                case "SetDefaultShaderChunkSizeInMB": _value = _LuaPlayerSettings_SetDefaultShaderChunkSizeInMB; return true;
                case "SetDynamicBatchingForPlatform": _value = _LuaPlayerSettings_SetDynamicBatchingForPlatform; return true;
                case "SetEditorAssembliesCompatibilityLevel": _value = _LuaPlayerSettings_SetEditorAssembliesCompatibilityLevel; return true;
                case "SetGraphicsAPIs": _value = _LuaPlayerSettings_SetGraphicsAPIs; return true;
                case "SetIcons": _value = _LuaPlayerSettings_SetIcons; return true;
                case "SetIl2CppCodeGeneration": _value = _LuaPlayerSettings_SetIl2CppCodeGeneration; return true;
                case "SetIl2CppCompilerConfiguration": _value = _LuaPlayerSettings_SetIl2CppCompilerConfiguration; return true;
                case "SetIl2CppStacktraceInformation": _value = _LuaPlayerSettings_SetIl2CppStacktraceInformation; return true;
                case "SetManagedStrippingLevel": _value = _LuaPlayerSettings_SetManagedStrippingLevel; return true;
                case "SetMobileMTRendering": _value = _LuaPlayerSettings_SetMobileMTRendering; return true;
                case "SetNormalMapEncoding": _value = _LuaPlayerSettings_SetNormalMapEncoding; return true;
                case "SetOverrideShaderChunkSettingsForPlatform": _value = _LuaPlayerSettings_SetOverrideShaderChunkSettingsForPlatform; return true;
                case "SetPlatformIcons": _value = _LuaPlayerSettings_SetPlatformIcons; return true;
                case "SetPreloadedAssets": _value = _LuaPlayerSettings_SetPreloadedAssets; return true;
                case "SetScriptingBackend": _value = _LuaPlayerSettings_SetScriptingBackend; return true;
                case "SetScriptingDefineSymbols": _value = _LuaPlayerSettings_SetScriptingDefineSymbols; return true;
                case "SetShaderChunkCountForPlatform": _value = _LuaPlayerSettings_SetShaderChunkCountForPlatform; return true;
                case "SetShaderChunkSizeInMBForPlatform": _value = _LuaPlayerSettings_SetShaderChunkSizeInMBForPlatform; return true;
                case "SetShaderPrecisionModel": _value = _LuaPlayerSettings_SetShaderPrecisionModel; return true;
                case "SetStackTraceLogType": _value = _LuaPlayerSettings_SetStackTraceLogType; return true;
                case "SetStaticBatchingForPlatform": _value = _LuaPlayerSettings_SetStaticBatchingForPlatform; return true;
                case "SetTemplateCustomValue": _value = _LuaPlayerSettings_SetTemplateCustomValue; return true;
                case "SetUseDefaultGraphicsAPIs": _value = _LuaPlayerSettings_SetUseDefaultGraphicsAPIs; return true;
                case "SetVirtualTexturingSupportEnabled": _value = _LuaPlayerSettings_SetVirtualTexturingSupportEnabled; return true;
                case "SetWsaHolographicRemotingEnabled": _value = _LuaPlayerSettings_SetWsaHolographicRemotingEnabled; return true;
                case "accelerometerFrequency": _value = new global::Lua.LuaValue(global::UnityEditor.PlayerSettings.accelerometerFrequency); return true;
                case "advancedLicense": _value = new global::Lua.LuaValue(global::UnityEditor.PlayerSettings.advancedLicense); return true;
                case "allowedAutorotateToLandscapeLeft": _value = new global::Lua.LuaValue(global::UnityEditor.PlayerSettings.allowedAutorotateToLandscapeLeft); return true;
                case "allowedAutorotateToLandscapeRight": _value = new global::Lua.LuaValue(global::UnityEditor.PlayerSettings.allowedAutorotateToLandscapeRight); return true;
                case "allowedAutorotateToPortrait": _value = new global::Lua.LuaValue(global::UnityEditor.PlayerSettings.allowedAutorotateToPortrait); return true;
                case "allowedAutorotateToPortraitUpsideDown": _value = new global::Lua.LuaValue(global::UnityEditor.PlayerSettings.allowedAutorotateToPortraitUpsideDown); return true;
                case "allowFullscreenSwitch": _value = new global::Lua.LuaValue(global::UnityEditor.PlayerSettings.allowFullscreenSwitch); return true;
                case "allowHDRDisplaySupport": _value = new global::Lua.LuaValue(global::UnityEditor.PlayerSettings.allowHDRDisplaySupport); return true;
                case "allowUnsafeCode": _value = new global::Lua.LuaValue(global::UnityEditor.PlayerSettings.allowUnsafeCode); return true;
                case "applicationIdentifier": _value = new global::Lua.LuaValue(global::UnityEditor.PlayerSettings.applicationIdentifier); return true;
                case "bakeCollisionMeshes": _value = new global::Lua.LuaValue(global::UnityEditor.PlayerSettings.bakeCollisionMeshes); return true;
                case "bundleVersion": _value = new global::Lua.LuaValue(global::UnityEditor.PlayerSettings.bundleVersion); return true;
                case "colorSpace": _value = new global::Lua.LuaValue((global::System.Int64)global::UnityEditor.PlayerSettings.colorSpace); return true;
                case "companyName": _value = new global::Lua.LuaValue(global::UnityEditor.PlayerSettings.companyName); return true;
                case "cursorHotspot": _value = _factory.Bind(global::UnityEditor.PlayerSettings.cursorHotspot); return true;
                case "dedicatedServerOptimizations": _value = new global::Lua.LuaValue(global::UnityEditor.PlayerSettings.dedicatedServerOptimizations); return true;
                case "defaultCursor": _value = _factory.Bind(global::UnityEditor.PlayerSettings.defaultCursor); return true;
                case "defaultInterfaceOrientation": _value = new global::Lua.LuaValue((global::System.Int64)global::UnityEditor.PlayerSettings.defaultInterfaceOrientation); return true;
                case "defaultIsNativeResolution": _value = new global::Lua.LuaValue(global::UnityEditor.PlayerSettings.defaultIsNativeResolution); return true;
                case "defaultScreenHeight": _value = new global::Lua.LuaValue(global::UnityEditor.PlayerSettings.defaultScreenHeight); return true;
                case "defaultScreenWidth": _value = new global::Lua.LuaValue(global::UnityEditor.PlayerSettings.defaultScreenWidth); return true;
                case "defaultWebScreenHeight": _value = new global::Lua.LuaValue(global::UnityEditor.PlayerSettings.defaultWebScreenHeight); return true;
                case "defaultWebScreenWidth": _value = new global::Lua.LuaValue(global::UnityEditor.PlayerSettings.defaultWebScreenWidth); return true;
                case "enable360StereoCapture": _value = new global::Lua.LuaValue(global::UnityEditor.PlayerSettings.enable360StereoCapture); return true;
                case "enableCrashReportAPI": _value = new global::Lua.LuaValue(global::UnityEditor.PlayerSettings.enableCrashReportAPI); return true;
                case "enableFrameTimingStats": _value = new global::Lua.LuaValue(global::UnityEditor.PlayerSettings.enableFrameTimingStats); return true;
                case "enableInternalProfiler": _value = new global::Lua.LuaValue(global::UnityEditor.PlayerSettings.enableInternalProfiler); return true;
                case "enableMetalAPIValidation": _value = new global::Lua.LuaValue(global::UnityEditor.PlayerSettings.enableMetalAPIValidation); return true;
                case "enableOpenGLProfilerGPURecorders": _value = new global::Lua.LuaValue(global::UnityEditor.PlayerSettings.enableOpenGLProfilerGPURecorders); return true;
                case "forceSingleInstance": _value = new global::Lua.LuaValue(global::UnityEditor.PlayerSettings.forceSingleInstance); return true;
                case "fullScreenMode": _value = new global::Lua.LuaValue((global::System.Int64)global::UnityEditor.PlayerSettings.fullScreenMode); return true;
                case "gcIncremental": _value = new global::Lua.LuaValue(global::UnityEditor.PlayerSettings.gcIncremental); return true;
                case "gpuSkinning": _value = new global::Lua.LuaValue(global::UnityEditor.PlayerSettings.gpuSkinning); return true;
                case "graphicsJobMode": _value = new global::Lua.LuaValue((global::System.Int64)global::UnityEditor.PlayerSettings.graphicsJobMode); return true;
                case "graphicsJobs": _value = new global::Lua.LuaValue(global::UnityEditor.PlayerSettings.graphicsJobs); return true;
                case "hdrBitDepth": _value = new global::Lua.LuaValue((global::System.Int64)global::UnityEditor.PlayerSettings.hdrBitDepth); return true;
                case "insecureHttpOption": _value = new global::Lua.LuaValue((global::System.Int64)global::UnityEditor.PlayerSettings.insecureHttpOption); return true;
                case "legacyClampBlendShapeWeights": _value = new global::Lua.LuaValue(global::UnityEditor.PlayerSettings.legacyClampBlendShapeWeights); return true;
                case "logObjCUncaughtExceptions": _value = new global::Lua.LuaValue(global::UnityEditor.PlayerSettings.logObjCUncaughtExceptions); return true;
                case "macRetinaSupport": _value = new global::Lua.LuaValue(global::UnityEditor.PlayerSettings.macRetinaSupport); return true;
                case "meshDeformation": _value = new global::Lua.LuaValue((global::System.Int64)global::UnityEditor.PlayerSettings.meshDeformation); return true;
                case "mipStripping": _value = new global::Lua.LuaValue(global::UnityEditor.PlayerSettings.mipStripping); return true;
                case "MTRendering": _value = new global::Lua.LuaValue(global::UnityEditor.PlayerSettings.MTRendering); return true;
                case "muteOtherAudioSources": _value = new global::Lua.LuaValue(global::UnityEditor.PlayerSettings.muteOtherAudioSources); return true;
                case "openGLRequireES31": _value = new global::Lua.LuaValue(global::UnityEditor.PlayerSettings.openGLRequireES31); return true;
                case "openGLRequireES31AEP": _value = new global::Lua.LuaValue(global::UnityEditor.PlayerSettings.openGLRequireES31AEP); return true;
                case "openGLRequireES32": _value = new global::Lua.LuaValue(global::UnityEditor.PlayerSettings.openGLRequireES32); return true;
                case "preserveFramebufferAlpha": _value = new global::Lua.LuaValue(global::UnityEditor.PlayerSettings.preserveFramebufferAlpha); return true;
                case "productGUID": _value = _factory.Bind(global::UnityEditor.PlayerSettings.productGUID); return true;
                case "productName": _value = new global::Lua.LuaValue(global::UnityEditor.PlayerSettings.productName); return true;
                case "resetResolutionOnWindowResize": _value = new global::Lua.LuaValue(global::UnityEditor.PlayerSettings.resetResolutionOnWindowResize); return true;
                case "resizableWindow": _value = new global::Lua.LuaValue(global::UnityEditor.PlayerSettings.resizableWindow); return true;
                case "runInBackground": _value = new global::Lua.LuaValue(global::UnityEditor.PlayerSettings.runInBackground); return true;
                case "spriteBatchVertexThreshold": _value = new global::Lua.LuaValue(global::UnityEditor.PlayerSettings.spriteBatchVertexThreshold); return true;
                case "statusBarHidden": _value = new global::Lua.LuaValue(global::UnityEditor.PlayerSettings.statusBarHidden); return true;
                case "stereoRenderingPath": _value = new global::Lua.LuaValue((global::System.Int64)global::UnityEditor.PlayerSettings.stereoRenderingPath); return true;
                case "strictShaderVariantMatching": _value = new global::Lua.LuaValue(global::UnityEditor.PlayerSettings.strictShaderVariantMatching); return true;
                case "stripEngineCode": _value = new global::Lua.LuaValue(global::UnityEditor.PlayerSettings.stripEngineCode); return true;
                case "stripUnusedMeshComponents": _value = new global::Lua.LuaValue(global::UnityEditor.PlayerSettings.stripUnusedMeshComponents); return true;
                case "suppressCommonWarnings": _value = new global::Lua.LuaValue(global::UnityEditor.PlayerSettings.suppressCommonWarnings); return true;
                case "tvOSBundleVersion": _value = new global::Lua.LuaValue(global::UnityEditor.PlayerSettings.tvOSBundleVersion); return true;
                case "use32BitDisplayBuffer": _value = new global::Lua.LuaValue(global::UnityEditor.PlayerSettings.use32BitDisplayBuffer); return true;
                case "useAnimatedAutorotation": _value = new global::Lua.LuaValue(global::UnityEditor.PlayerSettings.useAnimatedAutorotation); return true;
                case "useFlipModelSwapchain": _value = new global::Lua.LuaValue(global::UnityEditor.PlayerSettings.useFlipModelSwapchain); return true;
                case "useHDRDisplay": _value = new global::Lua.LuaValue(global::UnityEditor.PlayerSettings.useHDRDisplay); return true;
                case "useMacAppStoreValidation": _value = new global::Lua.LuaValue(global::UnityEditor.PlayerSettings.useMacAppStoreValidation); return true;
                case "usePlayerLog": _value = new global::Lua.LuaValue(global::UnityEditor.PlayerSettings.usePlayerLog); return true;
                case "virtualRealitySplashScreen": _value = _factory.Bind(global::UnityEditor.PlayerSettings.virtualRealitySplashScreen); return true;
                case "visibleInBackground": _value = new global::Lua.LuaValue(global::UnityEditor.PlayerSettings.visibleInBackground); return true;
                case "visionOSBundleVersion": _value = new global::Lua.LuaValue(global::UnityEditor.PlayerSettings.visionOSBundleVersion); return true;
                case "vulkanEnableLateAcquireNextImage": _value = new global::Lua.LuaValue(global::UnityEditor.PlayerSettings.vulkanEnableLateAcquireNextImage); return true;
                case "vulkanEnablePreTransform": _value = new global::Lua.LuaValue(global::UnityEditor.PlayerSettings.vulkanEnablePreTransform); return true;
                case "vulkanEnableSetSRGBWrite": _value = new global::Lua.LuaValue(global::UnityEditor.PlayerSettings.vulkanEnableSetSRGBWrite); return true;
                case "vulkanNumSwapchainBuffers": _value = new global::Lua.LuaValue(global::UnityEditor.PlayerSettings.vulkanNumSwapchainBuffers); return true;
                case "windowsGamepadBackendHint": _value = new global::Lua.LuaValue((global::System.Int64)global::UnityEditor.PlayerSettings.windowsGamepadBackendHint); return true;
                case "xboxEnableAvatar": _value = new global::Lua.LuaValue(global::UnityEditor.PlayerSettings.xboxEnableAvatar); return true;
                case "xboxOneResolution": _value = new global::Lua.LuaValue(global::UnityEditor.PlayerSettings.xboxOneResolution); return true;
                case "xboxPIXTextureCapture": _value = new global::Lua.LuaValue(global::UnityEditor.PlayerSettings.xboxPIXTextureCapture); return true;
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
                case "accelerometerFrequency": global::UnityEditor.PlayerSettings.accelerometerFrequency = _value.Read<global::System.Int32>();  return true;
                case "allowedAutorotateToLandscapeLeft": global::UnityEditor.PlayerSettings.allowedAutorotateToLandscapeLeft = _value.Read<global::System.Boolean>();  return true;
                case "allowedAutorotateToLandscapeRight": global::UnityEditor.PlayerSettings.allowedAutorotateToLandscapeRight = _value.Read<global::System.Boolean>();  return true;
                case "allowedAutorotateToPortrait": global::UnityEditor.PlayerSettings.allowedAutorotateToPortrait = _value.Read<global::System.Boolean>();  return true;
                case "allowedAutorotateToPortraitUpsideDown": global::UnityEditor.PlayerSettings.allowedAutorotateToPortraitUpsideDown = _value.Read<global::System.Boolean>();  return true;
                case "allowFullscreenSwitch": global::UnityEditor.PlayerSettings.allowFullscreenSwitch = _value.Read<global::System.Boolean>();  return true;
                case "allowHDRDisplaySupport": global::UnityEditor.PlayerSettings.allowHDRDisplaySupport = _value.Read<global::System.Boolean>();  return true;
                case "allowUnsafeCode": global::UnityEditor.PlayerSettings.allowUnsafeCode = _value.Read<global::System.Boolean>();  return true;
                case "applicationIdentifier": global::UnityEditor.PlayerSettings.applicationIdentifier = _value.Read<global::System.String>();  return true;
                case "bakeCollisionMeshes": global::UnityEditor.PlayerSettings.bakeCollisionMeshes = _value.Read<global::System.Boolean>();  return true;
                case "bundleVersion": global::UnityEditor.PlayerSettings.bundleVersion = _value.Read<global::System.String>();  return true;
                case "colorSpace": global::UnityEditor.PlayerSettings.colorSpace = _value.Read<global::UnityEngine.ColorSpace>();  return true;
                case "companyName": global::UnityEditor.PlayerSettings.companyName = _value.Read<global::System.String>();  return true;
                case "cursorHotspot": global::UnityEditor.PlayerSettings.cursorHotspot = _value.Read<global::UnityEngine.Vector2>();  return true;
                case "dedicatedServerOptimizations": global::UnityEditor.PlayerSettings.dedicatedServerOptimizations = _value.Read<global::System.Boolean>();  return true;
                case "defaultCursor": global::UnityEditor.PlayerSettings.defaultCursor = _value.Read<global::UnityEngine.Texture2D>();  return true;
                case "defaultInterfaceOrientation": global::UnityEditor.PlayerSettings.defaultInterfaceOrientation = _value.Read<global::UnityEditor.UIOrientation>();  return true;
                case "defaultIsNativeResolution": global::UnityEditor.PlayerSettings.defaultIsNativeResolution = _value.Read<global::System.Boolean>();  return true;
                case "defaultScreenHeight": global::UnityEditor.PlayerSettings.defaultScreenHeight = _value.Read<global::System.Int32>();  return true;
                case "defaultScreenWidth": global::UnityEditor.PlayerSettings.defaultScreenWidth = _value.Read<global::System.Int32>();  return true;
                case "defaultWebScreenHeight": global::UnityEditor.PlayerSettings.defaultWebScreenHeight = _value.Read<global::System.Int32>();  return true;
                case "defaultWebScreenWidth": global::UnityEditor.PlayerSettings.defaultWebScreenWidth = _value.Read<global::System.Int32>();  return true;
                case "enable360StereoCapture": global::UnityEditor.PlayerSettings.enable360StereoCapture = _value.Read<global::System.Boolean>();  return true;
                case "enableCrashReportAPI": global::UnityEditor.PlayerSettings.enableCrashReportAPI = _value.Read<global::System.Boolean>();  return true;
                case "enableFrameTimingStats": global::UnityEditor.PlayerSettings.enableFrameTimingStats = _value.Read<global::System.Boolean>();  return true;
                case "enableInternalProfiler": global::UnityEditor.PlayerSettings.enableInternalProfiler = _value.Read<global::System.Boolean>();  return true;
                case "enableMetalAPIValidation": global::UnityEditor.PlayerSettings.enableMetalAPIValidation = _value.Read<global::System.Boolean>();  return true;
                case "enableOpenGLProfilerGPURecorders": global::UnityEditor.PlayerSettings.enableOpenGLProfilerGPURecorders = _value.Read<global::System.Boolean>();  return true;
                case "forceSingleInstance": global::UnityEditor.PlayerSettings.forceSingleInstance = _value.Read<global::System.Boolean>();  return true;
                case "fullScreenMode": global::UnityEditor.PlayerSettings.fullScreenMode = _value.Read<global::UnityEngine.FullScreenMode>();  return true;
                case "gcIncremental": global::UnityEditor.PlayerSettings.gcIncremental = _value.Read<global::System.Boolean>();  return true;
                case "gpuSkinning": global::UnityEditor.PlayerSettings.gpuSkinning = _value.Read<global::System.Boolean>();  return true;
                case "graphicsJobMode": global::UnityEditor.PlayerSettings.graphicsJobMode = _value.Read<global::UnityEditor.GraphicsJobMode>();  return true;
                case "graphicsJobs": global::UnityEditor.PlayerSettings.graphicsJobs = _value.Read<global::System.Boolean>();  return true;
                case "hdrBitDepth": global::UnityEditor.PlayerSettings.hdrBitDepth = _value.Read<global::UnityEngine.HDRDisplayBitDepth>();  return true;
                case "insecureHttpOption": global::UnityEditor.PlayerSettings.insecureHttpOption = _value.Read<global::UnityEditor.InsecureHttpOption>();  return true;
                case "legacyClampBlendShapeWeights": global::UnityEditor.PlayerSettings.legacyClampBlendShapeWeights = _value.Read<global::System.Boolean>();  return true;
                case "logObjCUncaughtExceptions": global::UnityEditor.PlayerSettings.logObjCUncaughtExceptions = _value.Read<global::System.Boolean>();  return true;
                case "macRetinaSupport": global::UnityEditor.PlayerSettings.macRetinaSupport = _value.Read<global::System.Boolean>();  return true;
                case "meshDeformation": global::UnityEditor.PlayerSettings.meshDeformation = _value.Read<global::UnityEditor.MeshDeformation>();  return true;
                case "mipStripping": global::UnityEditor.PlayerSettings.mipStripping = _value.Read<global::System.Boolean>();  return true;
                case "MTRendering": global::UnityEditor.PlayerSettings.MTRendering = _value.Read<global::System.Boolean>();  return true;
                case "muteOtherAudioSources": global::UnityEditor.PlayerSettings.muteOtherAudioSources = _value.Read<global::System.Boolean>();  return true;
                case "openGLRequireES31": global::UnityEditor.PlayerSettings.openGLRequireES31 = _value.Read<global::System.Boolean>();  return true;
                case "openGLRequireES31AEP": global::UnityEditor.PlayerSettings.openGLRequireES31AEP = _value.Read<global::System.Boolean>();  return true;
                case "openGLRequireES32": global::UnityEditor.PlayerSettings.openGLRequireES32 = _value.Read<global::System.Boolean>();  return true;
                case "preserveFramebufferAlpha": global::UnityEditor.PlayerSettings.preserveFramebufferAlpha = _value.Read<global::System.Boolean>();  return true;
                case "productName": global::UnityEditor.PlayerSettings.productName = _value.Read<global::System.String>();  return true;
                case "resetResolutionOnWindowResize": global::UnityEditor.PlayerSettings.resetResolutionOnWindowResize = _value.Read<global::System.Boolean>();  return true;
                case "resizableWindow": global::UnityEditor.PlayerSettings.resizableWindow = _value.Read<global::System.Boolean>();  return true;
                case "runInBackground": global::UnityEditor.PlayerSettings.runInBackground = _value.Read<global::System.Boolean>();  return true;
                case "spriteBatchVertexThreshold": global::UnityEditor.PlayerSettings.spriteBatchVertexThreshold = _value.Read<global::System.Int32>();  return true;
                case "statusBarHidden": global::UnityEditor.PlayerSettings.statusBarHidden = _value.Read<global::System.Boolean>();  return true;
                case "stereoRenderingPath": global::UnityEditor.PlayerSettings.stereoRenderingPath = _value.Read<global::UnityEditor.StereoRenderingPath>();  return true;
                case "strictShaderVariantMatching": global::UnityEditor.PlayerSettings.strictShaderVariantMatching = _value.Read<global::System.Boolean>();  return true;
                case "stripEngineCode": global::UnityEditor.PlayerSettings.stripEngineCode = _value.Read<global::System.Boolean>();  return true;
                case "stripUnusedMeshComponents": global::UnityEditor.PlayerSettings.stripUnusedMeshComponents = _value.Read<global::System.Boolean>();  return true;
                case "suppressCommonWarnings": global::UnityEditor.PlayerSettings.suppressCommonWarnings = _value.Read<global::System.Boolean>();  return true;
                case "tvOSBundleVersion": global::UnityEditor.PlayerSettings.tvOSBundleVersion = _value.Read<global::System.String>();  return true;
                case "use32BitDisplayBuffer": global::UnityEditor.PlayerSettings.use32BitDisplayBuffer = _value.Read<global::System.Boolean>();  return true;
                case "useAnimatedAutorotation": global::UnityEditor.PlayerSettings.useAnimatedAutorotation = _value.Read<global::System.Boolean>();  return true;
                case "useFlipModelSwapchain": global::UnityEditor.PlayerSettings.useFlipModelSwapchain = _value.Read<global::System.Boolean>();  return true;
                case "useHDRDisplay": global::UnityEditor.PlayerSettings.useHDRDisplay = _value.Read<global::System.Boolean>();  return true;
                case "useMacAppStoreValidation": global::UnityEditor.PlayerSettings.useMacAppStoreValidation = _value.Read<global::System.Boolean>();  return true;
                case "usePlayerLog": global::UnityEditor.PlayerSettings.usePlayerLog = _value.Read<global::System.Boolean>();  return true;
                case "virtualRealitySplashScreen": global::UnityEditor.PlayerSettings.virtualRealitySplashScreen = _value.Read<global::UnityEngine.Texture2D>();  return true;
                case "visibleInBackground": global::UnityEditor.PlayerSettings.visibleInBackground = _value.Read<global::System.Boolean>();  return true;
                case "visionOSBundleVersion": global::UnityEditor.PlayerSettings.visionOSBundleVersion = _value.Read<global::System.String>();  return true;
                case "vulkanEnableLateAcquireNextImage": global::UnityEditor.PlayerSettings.vulkanEnableLateAcquireNextImage = _value.Read<global::System.Boolean>();  return true;
                case "vulkanEnablePreTransform": global::UnityEditor.PlayerSettings.vulkanEnablePreTransform = _value.Read<global::System.Boolean>();  return true;
                case "vulkanEnableSetSRGBWrite": global::UnityEditor.PlayerSettings.vulkanEnableSetSRGBWrite = _value.Read<global::System.Boolean>();  return true;
                case "vulkanNumSwapchainBuffers": global::UnityEditor.PlayerSettings.vulkanNumSwapchainBuffers = _value.Read<global::System.UInt32>();  return true;
                case "windowsGamepadBackendHint": global::UnityEditor.PlayerSettings.windowsGamepadBackendHint = _value.Read<global::UnityEditor.WindowsGamepadBackendHint>();  return true;
                default: return false;
            }
        }
    }
}
#pragma warning restore 0109, 0162, 0168, 0219
#endif
