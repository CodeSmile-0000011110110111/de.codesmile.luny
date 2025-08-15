
// --------------------------------------------------------------
// GENERATED FILE ----> DO NOT EDIT <---- CHANGES WILL BE LOST !!
// --------------------------------------------------------------

#if UNITY_6000_0_OR_NEWER && !(UNITY_6000_1_OR_NEWER)
#pragma warning disable 0109, 0162, 0168, 0219
using Luny;

namespace Luny.UnityEditor
{
    public class LuaBuildPipeline : global::Luny.ILuaObject<global::UnityEditor.BuildPipeline>
    {
        public new static global::Lua.LuaValue Bind(global::UnityEditor.BuildPipeline instance) => new LuaBuildPipeline(instance);
        public new static global::Lua.LuaValue Bind(global::System.Object instance) => Bind((global::UnityEditor.BuildPipeline)instance);
        public new static global::Lua.LuaValue Bind(global::System.Collections.Generic.IList<global::UnityEditor.BuildPipeline> instances) =>
            new global::Luny.LuaList<global::UnityEditor.BuildPipeline>(instances);
        public new static global::Lua.LuaValue Bind(global::System.Collections.Generic.IList<global::System.Object> instances) =>
            new global::Luny.LuaList<global::UnityEditor.BuildPipeline>(instances);
        protected LuaBuildPipeline(global::UnityEditor.BuildPipeline instance) => m_Instance = instance;
        public static implicit operator global::Lua.LuaValue(LuaBuildPipeline value) => new(value);
        protected global::UnityEditor.BuildPipeline m_Instance;
        public global::UnityEditor.BuildPipeline Instance => m_Instance;
        public new global::System.Type BindType => typeof(global::UnityEditor.BuildPipeline);
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
            var _this = _context.GetArgument<LuaBuildPipeline>(0);
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
            var _this = _context.GetArgument<LuaBuildPipeline>(0);
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
    public sealed class LuaBuildPipelineType : global::Luny.ILuaStatic
    {
        public static global::Lua.LuaValue Bind() => new LuaBuildPipelineType();
        private LuaBuildPipelineType() {}
        public static implicit operator global::Lua.LuaValue(LuaBuildPipelineType value) => new(value);
        public global::System.Type BindType => typeof(global::UnityEditor.BuildPipeline);
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
            metatable[global::Lua.Runtime.Metamethods.Call] = _LuaBuildPipeline_new;
            return metatable;
        }
        public override global::System.String ToString() => BindType.FullName;
#if UNITY_EDITOR
        [global::UnityEngine.RuntimeInitializeOnLoadMethod(global::UnityEngine.RuntimeInitializeLoadType.SubsystemRegistration)]
        private static void ResetStaticFields() => s_Metatable = null;
#endif

        private static readonly global::Lua.LuaFunction _LuaBuildPipeline_new = new global::Lua.LuaFunction(".ctor", (_context, _) =>
        {
            global::Lua.LuaValue _lastArg = default;
            global::System.Int32 _lastArgPos = default;
            global::System.Type _expectedType = default;
            var _argCount = _context.ArgumentCount;
            if (_argCount == 1)
            {
                var _ret0 = new global::UnityEditor.BuildPipeline();
                var _factory = _context.GetObjectFactory();
                var _lret0 = _factory.Bind(_ret0);
                var _retCount = _context.Return(_lret0);
                return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
            }
            throw new global::Lua.LuaRuntimeException(_context.Thread, $"{".ctor"}: invalid argument #{_lastArgPos}: {_lastArg} ({_lastArg.Type}), expected: {_expectedType.FullName}", 2);
        });
        private static readonly global::Lua.LuaFunction _LuaBuildPipeline_BuildAssetBundles = new global::Lua.LuaFunction("BuildAssetBundles", (_context, _) =>
        {
            global::Lua.LuaValue _lastArg = default;
            global::System.Int32 _lastArgPos = default;
            global::System.Type _expectedType = default;
            var _argCount = _context.ArgumentCount;
            var _arg0 = _lastArg = _argCount > 0 ? _context.GetArgument(0) : global::Lua.LuaValue.Nil;
            _lastArgPos = 0; _expectedType = typeof(global::Luny.UnityEditor.LuaBuildAssetBundlesParameters);
            if (_arg0.TryRead<global::Luny.UnityEditor.LuaBuildAssetBundlesParameters>(out var _p0_UnityEditor_BuildAssetBundlesParameters))
            {
                if (_argCount == 1)
                {
                    var buildParameters = _p0_UnityEditor_BuildAssetBundlesParameters.Value;
                    var _ret0 = global::UnityEditor.BuildPipeline.BuildAssetBundles(buildParameters);
                    var _factory = _context.GetObjectFactory();
                    var _lret0 = _factory.Bind(_ret0);
                    var _retCount = _context.Return(_lret0);
                    return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                }
            }
            _lastArgPos = 0; _expectedType = typeof(global::System.String);
            if (_arg0.TryRead<global::System.String>(out var _p0_System_String))
            {
                var _arg1 = _lastArg = _argCount > 1 ? _context.GetArgument(1) : global::Lua.LuaValue.Nil;
                _lastArgPos = 1; _expectedType = typeof(global::UnityEditor.BuildAssetBundleOptions);
                if (_arg1.TryRead<global::UnityEditor.BuildAssetBundleOptions>(out var _p1_UnityEditor_BuildAssetBundleOptions))
                {
                    var _arg2 = _lastArg = _argCount > 2 ? _context.GetArgument(2) : global::Lua.LuaValue.Nil;
                    _lastArgPos = 2; _expectedType = typeof(global::UnityEditor.BuildTarget);
                    if (_arg2.TryRead<global::UnityEditor.BuildTarget>(out var _p2_UnityEditor_BuildTarget))
                    {
                        if (_argCount == 3)
                        {
                            var outputPath = _p0_System_String;
                            var assetBundleOptions = _p1_UnityEditor_BuildAssetBundleOptions;
                            var targetPlatform = _p2_UnityEditor_BuildTarget;
                            var _ret0 = global::UnityEditor.BuildPipeline.BuildAssetBundles(outputPath, assetBundleOptions, targetPlatform);
                            var _factory = _context.GetObjectFactory();
                            var _lret0 = _factory.Bind(_ret0);
                            var _retCount = _context.Return(_lret0);
                            return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                        }
                    }
                }
                _lastArgPos = 1; _expectedType = typeof(global::UnityEditor.AssetBundleBuild[]);
                if (_arg1.TryReadArray<global::UnityEditor.AssetBundleBuild>(out var _p1_UnityEditor_AssetBundleBuildArray))
                {
                    var _arg2 = _lastArg = _argCount > 2 ? _context.GetArgument(2) : global::Lua.LuaValue.Nil;
                    _lastArgPos = 2; _expectedType = typeof(global::UnityEditor.BuildAssetBundleOptions);
                    if (_arg2.TryRead<global::UnityEditor.BuildAssetBundleOptions>(out var _p2_UnityEditor_BuildAssetBundleOptions))
                    {
                        var _arg3 = _lastArg = _argCount > 3 ? _context.GetArgument(3) : global::Lua.LuaValue.Nil;
                        _lastArgPos = 3; _expectedType = typeof(global::UnityEditor.BuildTarget);
                        if (_arg3.TryRead<global::UnityEditor.BuildTarget>(out var _p3_UnityEditor_BuildTarget))
                        {
                            if (_argCount == 4)
                            {
                                var outputPath = _p0_System_String;
                                var builds = _p1_UnityEditor_AssetBundleBuildArray;
                                var assetBundleOptions = _p2_UnityEditor_BuildAssetBundleOptions;
                                var targetPlatform = _p3_UnityEditor_BuildTarget;
                                var _ret0 = global::UnityEditor.BuildPipeline.BuildAssetBundles(outputPath, builds, assetBundleOptions, targetPlatform);
                                var _factory = _context.GetObjectFactory();
                                var _lret0 = _factory.Bind(_ret0);
                                var _retCount = _context.Return(_lret0);
                                return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                            }
                        }
                    }
                }
            }
            throw new global::Lua.LuaRuntimeException(_context.Thread, $"{"BuildAssetBundles"}: invalid argument #{_lastArgPos}: {_lastArg} ({_lastArg.Type}), expected: {_expectedType.FullName}", 2);
        });
        private static readonly global::Lua.LuaFunction _LuaBuildPipeline_BuildCanBeAppended = new global::Lua.LuaFunction("BuildCanBeAppended", (_context, _) =>
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
                        var _ret0 = global::UnityEditor.BuildPipeline.BuildCanBeAppended(target, location);
                        var _lret0 = new global::Lua.LuaValue((global::System.Int64)_ret0);
                        var _retCount = _context.Return(_lret0);
                        return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                    }
                }
            }
            throw new global::Lua.LuaRuntimeException(_context.Thread, $"{"BuildCanBeAppended"}: invalid argument #{_lastArgPos}: {_lastArg} ({_lastArg.Type}), expected: {_expectedType.FullName}", 2);
        });
        private static readonly global::Lua.LuaFunction _LuaBuildPipeline_BuildPlayer = new global::Lua.LuaFunction("BuildPlayer", (_context, _) =>
        {
            global::Lua.LuaValue _lastArg = default;
            global::System.Int32 _lastArgPos = default;
            global::System.Type _expectedType = default;
            var _argCount = _context.ArgumentCount;
            var _arg0 = _lastArg = _argCount > 0 ? _context.GetArgument(0) : global::Lua.LuaValue.Nil;
            _lastArgPos = 0; _expectedType = typeof(global::Luny.UnityEditor.LuaBuildPlayerOptions);
            if (_arg0.TryRead<global::Luny.UnityEditor.LuaBuildPlayerOptions>(out var _p0_UnityEditor_BuildPlayerOptions))
            {
                if (_argCount == 1)
                {
                    var buildPlayerOptions = _p0_UnityEditor_BuildPlayerOptions.Value;
                    var _ret0 = global::UnityEditor.BuildPipeline.BuildPlayer(buildPlayerOptions);
                    var _factory = _context.GetObjectFactory();
                    var _lret0 = _factory.Bind(_ret0);
                    var _retCount = _context.Return(_lret0);
                    return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                }
            }
            _lastArgPos = 0; _expectedType = typeof(global::Luny.UnityEditor.LuaBuildPlayerWithProfileOptions);
            if (_arg0.TryRead<global::Luny.UnityEditor.LuaBuildPlayerWithProfileOptions>(out var _p0_UnityEditor_BuildPlayerWithProfileOptions))
            {
                if (_argCount == 1)
                {
                    var buildPlayerWithProfileOptions = _p0_UnityEditor_BuildPlayerWithProfileOptions.Value;
                    var _ret0 = global::UnityEditor.BuildPipeline.BuildPlayer(buildPlayerWithProfileOptions);
                    var _factory = _context.GetObjectFactory();
                    var _lret0 = _factory.Bind(_ret0);
                    var _retCount = _context.Return(_lret0);
                    return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                }
            }
            _lastArgPos = 0; _expectedType = typeof(global::System.String[]);
            if (_arg0.TryReadArray<global::System.String>(out var _p0_System_StringArray))
            {
                var _arg1 = _lastArg = _argCount > 1 ? _context.GetArgument(1) : global::Lua.LuaValue.Nil;
                _lastArgPos = 1; _expectedType = typeof(global::System.String);
                if (_arg1.TryRead<global::System.String>(out var _p1_System_String))
                {
                    var _arg2 = _lastArg = _argCount > 2 ? _context.GetArgument(2) : global::Lua.LuaValue.Nil;
                    _lastArgPos = 2; _expectedType = typeof(global::UnityEditor.BuildTarget);
                    if (_arg2.TryRead<global::UnityEditor.BuildTarget>(out var _p2_UnityEditor_BuildTarget))
                    {
                        var _arg3 = _lastArg = _argCount > 3 ? _context.GetArgument(3) : global::Lua.LuaValue.Nil;
                        _lastArgPos = 3; _expectedType = typeof(global::UnityEditor.BuildOptions);
                        if (_arg3.TryRead<global::UnityEditor.BuildOptions>(out var _p3_UnityEditor_BuildOptions))
                        {
                            if (_argCount == 4)
                            {
                                var levels = _p0_System_StringArray;
                                var locationPathName = _p1_System_String;
                                var target = _p2_UnityEditor_BuildTarget;
                                var options = _p3_UnityEditor_BuildOptions;
                                var _ret0 = global::UnityEditor.BuildPipeline.BuildPlayer(levels, locationPathName, target, options);
                                var _factory = _context.GetObjectFactory();
                                var _lret0 = _factory.Bind(_ret0);
                                var _retCount = _context.Return(_lret0);
                                return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                            }
                        }
                    }
                }
            }
            _lastArgPos = 0; _expectedType = typeof(global::UnityEditor.EditorBuildSettingsScene[]);
            if (_arg0.TryReadArray<global::UnityEditor.EditorBuildSettingsScene>(out var _p0_UnityEditor_EditorBuildSettingsSceneArray))
            {
                var _arg1 = _lastArg = _argCount > 1 ? _context.GetArgument(1) : global::Lua.LuaValue.Nil;
                _lastArgPos = 1; _expectedType = typeof(global::System.String);
                if (_arg1.TryRead<global::System.String>(out var _p1_System_String))
                {
                    var _arg2 = _lastArg = _argCount > 2 ? _context.GetArgument(2) : global::Lua.LuaValue.Nil;
                    _lastArgPos = 2; _expectedType = typeof(global::UnityEditor.BuildTarget);
                    if (_arg2.TryRead<global::UnityEditor.BuildTarget>(out var _p2_UnityEditor_BuildTarget))
                    {
                        var _arg3 = _lastArg = _argCount > 3 ? _context.GetArgument(3) : global::Lua.LuaValue.Nil;
                        _lastArgPos = 3; _expectedType = typeof(global::UnityEditor.BuildOptions);
                        if (_arg3.TryRead<global::UnityEditor.BuildOptions>(out var _p3_UnityEditor_BuildOptions))
                        {
                            if (_argCount == 4)
                            {
                                var levels = _p0_UnityEditor_EditorBuildSettingsSceneArray;
                                var locationPathName = _p1_System_String;
                                var target = _p2_UnityEditor_BuildTarget;
                                var options = _p3_UnityEditor_BuildOptions;
                                var _ret0 = global::UnityEditor.BuildPipeline.BuildPlayer(levels, locationPathName, target, options);
                                var _factory = _context.GetObjectFactory();
                                var _lret0 = _factory.Bind(_ret0);
                                var _retCount = _context.Return(_lret0);
                                return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                            }
                        }
                    }
                }
            }
            throw new global::Lua.LuaRuntimeException(_context.Thread, $"{"BuildPlayer"}: invalid argument #{_lastArgPos}: {_lastArg} ({_lastArg.Type}), expected: {_expectedType.FullName}", 2);
        });
        private static readonly global::Lua.LuaFunction _LuaBuildPipeline_GetBuildTargetGroup = new global::Lua.LuaFunction("GetBuildTargetGroup", (_context, _) =>
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
                    var _ret0 = global::UnityEditor.BuildPipeline.GetBuildTargetGroup(platform);
                    var _lret0 = new global::Lua.LuaValue((global::System.Int64)_ret0);
                    var _retCount = _context.Return(_lret0);
                    return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                }
            }
            throw new global::Lua.LuaRuntimeException(_context.Thread, $"{"GetBuildTargetGroup"}: invalid argument #{_lastArgPos}: {_lastArg} ({_lastArg.Type}), expected: {_expectedType.FullName}", 2);
        });
        private static readonly global::Lua.LuaFunction _LuaBuildPipeline_GetBuildTargetName = new global::Lua.LuaFunction("GetBuildTargetName", (_context, _) =>
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
                    var targetPlatform = _p0_UnityEditor_BuildTarget;
                    var _ret0 = global::UnityEditor.BuildPipeline.GetBuildTargetName(targetPlatform);
                    var _lret0 = new global::Lua.LuaValue(_ret0);
                    var _retCount = _context.Return(_lret0);
                    return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                }
            }
            throw new global::Lua.LuaRuntimeException(_context.Thread, $"{"GetBuildTargetName"}: invalid argument #{_lastArgPos}: {_lastArg} ({_lastArg.Type}), expected: {_expectedType.FullName}", 2);
        });
        private static readonly global::Lua.LuaFunction _LuaBuildPipeline_GetPlaybackEngineDirectory = new global::Lua.LuaFunction("GetPlaybackEngineDirectory", (_context, _) =>
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
                _lastArgPos = 1; _expectedType = typeof(global::UnityEditor.BuildOptions);
                if (_arg1.TryRead<global::UnityEditor.BuildOptions>(out var _p1_UnityEditor_BuildOptions))
                {
                    if (_argCount == 2)
                    {
                        var target = _p0_UnityEditor_BuildTarget;
                        var options = _p1_UnityEditor_BuildOptions;
                        var _ret0 = global::UnityEditor.BuildPipeline.GetPlaybackEngineDirectory(target, options);
                        var _lret0 = new global::Lua.LuaValue(_ret0);
                        var _retCount = _context.Return(_lret0);
                        return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                    }
                    var _arg2 = _lastArg = _argCount > 2 ? _context.GetArgument(2) : global::Lua.LuaValue.Nil;
                    _lastArgPos = 2; _expectedType = typeof(global::System.Boolean);
                    if (_arg2.TryRead<global::System.Boolean>(out var _p2_System_Boolean))
                    {
                        if (_argCount == 3)
                        {
                            var target = _p0_UnityEditor_BuildTarget;
                            var options = _p1_UnityEditor_BuildOptions;
                            var assertUnsupportedPlatforms = _p2_System_Boolean;
                            var _ret0 = global::UnityEditor.BuildPipeline.GetPlaybackEngineDirectory(target, options, assertUnsupportedPlatforms);
                            var _lret0 = new global::Lua.LuaValue(_ret0);
                            var _retCount = _context.Return(_lret0);
                            return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                        }
                    }
                }
            }
            _lastArgPos = 0; _expectedType = typeof(global::UnityEditor.BuildTargetGroup);
            if (_arg0.TryRead<global::UnityEditor.BuildTargetGroup>(out var _p0_UnityEditor_BuildTargetGroup))
            {
                var _arg1 = _lastArg = _argCount > 1 ? _context.GetArgument(1) : global::Lua.LuaValue.Nil;
                _lastArgPos = 1; _expectedType = typeof(global::UnityEditor.BuildTarget);
                if (_arg1.TryRead<global::UnityEditor.BuildTarget>(out var _p1_UnityEditor_BuildTarget))
                {
                    var _arg2 = _lastArg = _argCount > 2 ? _context.GetArgument(2) : global::Lua.LuaValue.Nil;
                    _lastArgPos = 2; _expectedType = typeof(global::UnityEditor.BuildOptions);
                    if (_arg2.TryRead<global::UnityEditor.BuildOptions>(out var _p2_UnityEditor_BuildOptions))
                    {
                        if (_argCount == 3)
                        {
                            var buildTargetGroup = _p0_UnityEditor_BuildTargetGroup;
                            var target = _p1_UnityEditor_BuildTarget;
                            var options = _p2_UnityEditor_BuildOptions;
                            var _ret0 = global::UnityEditor.BuildPipeline.GetPlaybackEngineDirectory(buildTargetGroup, target, options);
                            var _lret0 = new global::Lua.LuaValue(_ret0);
                            var _retCount = _context.Return(_lret0);
                            return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                        }
                        var _arg3 = _lastArg = _argCount > 3 ? _context.GetArgument(3) : global::Lua.LuaValue.Nil;
                        _lastArgPos = 3; _expectedType = typeof(global::System.Boolean);
                        if (_arg3.TryRead<global::System.Boolean>(out var _p3_System_Boolean))
                        {
                            if (_argCount == 4)
                            {
                                var buildTargetGroup = _p0_UnityEditor_BuildTargetGroup;
                                var target = _p1_UnityEditor_BuildTarget;
                                var options = _p2_UnityEditor_BuildOptions;
                                var assertUnsupportedPlatforms = _p3_System_Boolean;
                                var _ret0 = global::UnityEditor.BuildPipeline.GetPlaybackEngineDirectory(buildTargetGroup, target, options, assertUnsupportedPlatforms);
                                var _lret0 = new global::Lua.LuaValue(_ret0);
                                var _retCount = _context.Return(_lret0);
                                return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                            }
                        }
                    }
                }
            }
            throw new global::Lua.LuaRuntimeException(_context.Thread, $"{"GetPlaybackEngineDirectory"}: invalid argument #{_lastArgPos}: {_lastArg} ({_lastArg.Type}), expected: {_expectedType.FullName}", 2);
        });
        private static readonly global::Lua.LuaFunction _LuaBuildPipeline_GetPlayerConnectionInitiateMode = new global::Lua.LuaFunction("GetPlayerConnectionInitiateMode", (_context, _) =>
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
                _lastArgPos = 1; _expectedType = typeof(global::UnityEditor.BuildOptions);
                if (_arg1.TryRead<global::UnityEditor.BuildOptions>(out var _p1_UnityEditor_BuildOptions))
                {
                    if (_argCount == 2)
                    {
                        var targetPlatform = _p0_UnityEditor_BuildTarget;
                        var buildOptions = _p1_UnityEditor_BuildOptions;
                        var _ret0 = global::UnityEditor.BuildPipeline.GetPlayerConnectionInitiateMode(targetPlatform, buildOptions);
                        var _lret0 = new global::Lua.LuaValue((global::System.Int64)_ret0);
                        var _retCount = _context.Return(_lret0);
                        return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                    }
                }
            }
            throw new global::Lua.LuaRuntimeException(_context.Thread, $"{"GetPlayerConnectionInitiateMode"}: invalid argument #{_lastArgPos}: {_lastArg} ({_lastArg.Type}), expected: {_expectedType.FullName}", 2);
        });
        private static readonly global::Lua.LuaFunction _LuaBuildPipeline_IsBuildTargetSupported = new global::Lua.LuaFunction("IsBuildTargetSupported", (_context, _) =>
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
                        var buildTargetGroup = _p0_UnityEditor_BuildTargetGroup;
                        var target = _p1_UnityEditor_BuildTarget;
                        var _ret0 = global::UnityEditor.BuildPipeline.IsBuildTargetSupported(buildTargetGroup, target);
                        var _lret0 = new global::Lua.LuaValue(_ret0);
                        var _retCount = _context.Return(_lret0);
                        return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                    }
                }
            }
            throw new global::Lua.LuaRuntimeException(_context.Thread, $"{"IsBuildTargetSupported"}: invalid argument #{_lastArgPos}: {_lastArg} ({_lastArg.Type}), expected: {_expectedType.FullName}", 2);
        });
        private static readonly global::Lua.LuaFunction _LuaBuildPipeline_WriteBootConfig = new global::Lua.LuaFunction("WriteBootConfig", (_context, _) =>
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
                _lastArgPos = 1; _expectedType = typeof(global::UnityEditor.BuildTarget);
                if (_arg1.TryRead<global::UnityEditor.BuildTarget>(out var _p1_UnityEditor_BuildTarget))
                {
                    var _arg2 = _lastArg = _argCount > 2 ? _context.GetArgument(2) : global::Lua.LuaValue.Nil;
                    _lastArgPos = 2; _expectedType = typeof(global::UnityEditor.BuildOptions);
                    if (_arg2.TryRead<global::UnityEditor.BuildOptions>(out var _p2_UnityEditor_BuildOptions))
                    {
                        if (_argCount == 3)
                        {
                            var outputFile = _p0_System_String;
                            var target = _p1_UnityEditor_BuildTarget;
                            var options = _p2_UnityEditor_BuildOptions;
                            global::UnityEditor.BuildPipeline.WriteBootConfig(outputFile, target, options);
                            var _retCount = _context.Return();
                            return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                        }
                    }
                }
            }
            throw new global::Lua.LuaRuntimeException(_context.Thread, $"{"WriteBootConfig"}: invalid argument #{_lastArgPos}: {_lastArg} ({_lastArg.Type}), expected: {_expectedType.FullName}", 2);
        });
        private static readonly global::Lua.LuaFunction __index = new(global::Lua.Runtime.Metamethods.Index, (_context, _) =>
        {
            var _this = _context.GetArgument<LuaBuildPipelineType>(0);
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
            var _this = _context.GetArgument<LuaBuildPipelineType>(0);
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
                case "BuildAssetBundles": _value = _LuaBuildPipeline_BuildAssetBundles; return true;
                case "BuildCanBeAppended": _value = _LuaBuildPipeline_BuildCanBeAppended; return true;
                case "BuildPlayer": _value = _LuaBuildPipeline_BuildPlayer; return true;
                case "GetBuildTargetGroup": _value = _LuaBuildPipeline_GetBuildTargetGroup; return true;
                case "GetBuildTargetName": _value = _LuaBuildPipeline_GetBuildTargetName; return true;
                case "GetPlaybackEngineDirectory": _value = _LuaBuildPipeline_GetPlaybackEngineDirectory; return true;
                case "GetPlayerConnectionInitiateMode": _value = _LuaBuildPipeline_GetPlayerConnectionInitiateMode; return true;
                case "IsBuildTargetSupported": _value = _LuaBuildPipeline_IsBuildTargetSupported; return true;
                case "WriteBootConfig": _value = _LuaBuildPipeline_WriteBootConfig; return true;
                case "isBuildingPlayer": _value = new global::Lua.LuaValue(global::UnityEditor.BuildPipeline.isBuildingPlayer); return true;
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
