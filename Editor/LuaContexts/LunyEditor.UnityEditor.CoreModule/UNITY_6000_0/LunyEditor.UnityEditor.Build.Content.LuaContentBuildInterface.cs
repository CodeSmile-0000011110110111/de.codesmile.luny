
// --------------------------------------------------------------
// GENERATED FILE ----> DO NOT EDIT <---- CHANGES WILL BE LOST !!
// --------------------------------------------------------------

#if UNITY_6000_0_OR_NEWER && !(UNITY_6000_1_OR_NEWER)
#pragma warning disable 0109, 0162, 0168, 0219
using Luny;

namespace LunyEditor.UnityEditor.Build.Content
{
    public sealed class LuaContentBuildInterfaceType : global::Luny.ILuaStatic
    {
        public static global::Lua.LuaValue Bind() => new LuaContentBuildInterfaceType();
        private LuaContentBuildInterfaceType() {}
        public static implicit operator global::Lua.LuaValue(LuaContentBuildInterfaceType value) => new(value);
        public global::System.Type BindType => typeof(global::UnityEditor.Build.Content.ContentBuildInterface);
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

        private static readonly global::Lua.LuaFunction _LuaContentBuildInterface_ArchiveAndCompress = new global::Lua.LuaFunction("ArchiveAndCompress", (_context, _) =>
        {
            global::Lua.LuaValue _lastArg = default;
            global::System.Int32 _lastArgPos = default;
            global::System.Type _expectedType = default;
            var _argCount = _context.ArgumentCount;
            var _arg0 = _lastArg = _argCount > 0 ? _context.GetArgument(0) : global::Lua.LuaValue.Nil;
            _lastArgPos = 0; _expectedType = typeof(global::UnityEditor.Build.Content.ResourceFile[]);
            if (_arg0.TryReadArray<global::UnityEditor.Build.Content.ResourceFile>(out var _p0_UnityEditor_Build_Content_ResourceFileArray))
            {
                var _arg1 = _lastArg = _argCount > 1 ? _context.GetArgument(1) : global::Lua.LuaValue.Nil;
                _lastArgPos = 1; _expectedType = typeof(global::System.String);
                if (_arg1.TryRead<global::System.String>(out var _p1_System_String))
                {
                    var _arg2 = _lastArg = _argCount > 2 ? _context.GetArgument(2) : global::Lua.LuaValue.Nil;
                    _lastArgPos = 2; _expectedType = typeof(global::Luny.UnityEngine.LuaBuildCompression);
                    if (_arg2.TryRead<global::Luny.UnityEngine.LuaBuildCompression>(out var _p2_UnityEngine_BuildCompression))
                    {
                        if (_argCount == 3)
                        {
                            var resourceFiles = _p0_UnityEditor_Build_Content_ResourceFileArray;
                            var outputBundlePath = _p1_System_String;
                            var compression = _p2_UnityEngine_BuildCompression.Value;
                            var _ret0 = global::UnityEditor.Build.Content.ContentBuildInterface.ArchiveAndCompress(resourceFiles, outputBundlePath, compression);
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
                                var resourceFiles = _p0_UnityEditor_Build_Content_ResourceFileArray;
                                var outputBundlePath = _p1_System_String;
                                var compression = _p2_UnityEngine_BuildCompression.Value;
                                var stripUnityVersion = _p3_System_Boolean;
                                var _ret0 = global::UnityEditor.Build.Content.ContentBuildInterface.ArchiveAndCompress(resourceFiles, outputBundlePath, compression, stripUnityVersion);
                                var _lret0 = new global::Lua.LuaValue(_ret0);
                                var _retCount = _context.Return(_lret0);
                                return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                            }
                        }
                    }
                }
            }
            throw new global::Lua.LuaRuntimeException(_context.Thread, $"{"ArchiveAndCompress"}: invalid argument #{_lastArgPos}: {_lastArg} ({_lastArg.Type}), expected: {_expectedType.FullName}", 2);
        });
        private static readonly global::Lua.LuaFunction _LuaContentBuildInterface_CalculateBuildUsageTags = new global::Lua.LuaFunction("CalculateBuildUsageTags", (_context, _) =>
        {
            global::Lua.LuaValue _lastArg = default;
            global::System.Int32 _lastArgPos = default;
            global::System.Type _expectedType = default;
            var _argCount = _context.ArgumentCount;
            var _arg0 = _lastArg = _argCount > 0 ? _context.GetArgument(0) : global::Lua.LuaValue.Nil;
            _lastArgPos = 0; _expectedType = typeof(global::UnityEditor.Build.Content.ObjectIdentifier[]);
            if (_arg0.TryReadArray<global::UnityEditor.Build.Content.ObjectIdentifier>(out var _p0_UnityEditor_Build_Content_ObjectIdentifierArray))
            {
                var _arg1 = _lastArg = _argCount > 1 ? _context.GetArgument(1) : global::Lua.LuaValue.Nil;
                _lastArgPos = 1; _expectedType = typeof(global::UnityEditor.Build.Content.ObjectIdentifier[]);
                if (_arg1.TryReadArray<global::UnityEditor.Build.Content.ObjectIdentifier>(out var _p1_UnityEditor_Build_Content_ObjectIdentifierArray))
                {
                    var _arg2 = _lastArg = _argCount > 2 ? _context.GetArgument(2) : global::Lua.LuaValue.Nil;
                    _lastArgPos = 2; _expectedType = typeof(global::LunyEditor.UnityEditor.Build.Content.LuaBuildUsageTagGlobal);
                    if (_arg2.TryRead<global::LunyEditor.UnityEditor.Build.Content.LuaBuildUsageTagGlobal>(out var _p2_UnityEditor_Build_Content_BuildUsageTagGlobal))
                    {
                        var _arg3 = _lastArg = _argCount > 3 ? _context.GetArgument(3) : global::Lua.LuaValue.Nil;
                        _lastArgPos = 3; _expectedType = typeof(global::LunyEditor.UnityEditor.Build.Content.LuaBuildUsageTagSet);
                        if (_arg3.TryRead<global::LunyEditor.UnityEditor.Build.Content.LuaBuildUsageTagSet>(out var _p3_UnityEditor_Build_Content_BuildUsageTagSet))
                        {
                            if (_argCount == 4)
                            {
                                var objectIDs = _p0_UnityEditor_Build_Content_ObjectIdentifierArray;
                                var dependentObjectIDs = _p1_UnityEditor_Build_Content_ObjectIdentifierArray;
                                var globalUsage = _p2_UnityEditor_Build_Content_BuildUsageTagGlobal.Value;
                                var usageSet = _p3_UnityEditor_Build_Content_BuildUsageTagSet.Instance;
                                global::UnityEditor.Build.Content.ContentBuildInterface.CalculateBuildUsageTags(objectIDs, dependentObjectIDs, globalUsage, usageSet);
                                var _retCount = _context.Return();
                                return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                            }
                            var _arg4 = _lastArg = _argCount > 4 ? _context.GetArgument(4) : global::Lua.LuaValue.Nil;
                            _lastArgPos = 4; _expectedType = typeof(global::LunyEditor.UnityEditor.Build.Content.LuaBuildUsageCache);
                            if (_arg4.TryRead<global::LunyEditor.UnityEditor.Build.Content.LuaBuildUsageCache>(out var _p4_UnityEditor_Build_Content_BuildUsageCache))
                            {
                                if (_argCount == 5)
                                {
                                    var objectIDs = _p0_UnityEditor_Build_Content_ObjectIdentifierArray;
                                    var dependentObjectIDs = _p1_UnityEditor_Build_Content_ObjectIdentifierArray;
                                    var globalUsage = _p2_UnityEditor_Build_Content_BuildUsageTagGlobal.Value;
                                    var usageSet = _p3_UnityEditor_Build_Content_BuildUsageTagSet.Instance;
                                    var usageCache = _p4_UnityEditor_Build_Content_BuildUsageCache.Instance;
                                    global::UnityEditor.Build.Content.ContentBuildInterface.CalculateBuildUsageTags(objectIDs, dependentObjectIDs, globalUsage, usageSet, usageCache);
                                    var _retCount = _context.Return();
                                    return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                                }
                            }
                        }
                    }
                }
            }
            throw new global::Lua.LuaRuntimeException(_context.Thread, $"{"CalculateBuildUsageTags"}: invalid argument #{_lastArgPos}: {_lastArg} ({_lastArg.Type}), expected: {_expectedType.FullName}", 2);
        });
        private static readonly global::Lua.LuaFunction _LuaContentBuildInterface_CalculatePlayerDependenciesForGameManagers = new global::Lua.LuaFunction("CalculatePlayerDependenciesForGameManagers", (_context, _) =>
        {
            global::Lua.LuaValue _lastArg = default;
            global::System.Int32 _lastArgPos = default;
            global::System.Type _expectedType = default;
            var _argCount = _context.ArgumentCount;
            var _arg0 = _lastArg = _argCount > 0 ? _context.GetArgument(0) : global::Lua.LuaValue.Nil;
            _lastArgPos = 0; _expectedType = typeof(global::LunyEditor.UnityEditor.Build.Content.LuaBuildSettings);
            if (_arg0.TryRead<global::LunyEditor.UnityEditor.Build.Content.LuaBuildSettings>(out var _p0_UnityEditor_Build_Content_BuildSettings))
            {
                var _arg1 = _lastArg = _argCount > 1 ? _context.GetArgument(1) : global::Lua.LuaValue.Nil;
                _lastArgPos = 1; _expectedType = typeof(global::LunyEditor.UnityEditor.Build.Content.LuaBuildUsageTagGlobal);
                if (_arg1.TryRead<global::LunyEditor.UnityEditor.Build.Content.LuaBuildUsageTagGlobal>(out var _p1_UnityEditor_Build_Content_BuildUsageTagGlobal))
                {
                    var _arg2 = _lastArg = _argCount > 2 ? _context.GetArgument(2) : global::Lua.LuaValue.Nil;
                    _lastArgPos = 2; _expectedType = typeof(global::LunyEditor.UnityEditor.Build.Content.LuaBuildUsageTagSet);
                    if (_arg2.TryRead<global::LunyEditor.UnityEditor.Build.Content.LuaBuildUsageTagSet>(out var _p2_UnityEditor_Build_Content_BuildUsageTagSet))
                    {
                        if (_argCount == 3)
                        {
                            var settings = _p0_UnityEditor_Build_Content_BuildSettings.Value;
                            var globalUsage = _p1_UnityEditor_Build_Content_BuildUsageTagGlobal.Value;
                            var usageSet = _p2_UnityEditor_Build_Content_BuildUsageTagSet.Instance;
                            var _ret0 = global::UnityEditor.Build.Content.ContentBuildInterface.CalculatePlayerDependenciesForGameManagers(settings, globalUsage, usageSet);
                            var _lret0 = global::LunyEditor.UnityEditor.Build.Content.LuaGameManagerDependencyInfo.Bind(_ret0);
                            var _retCount = _context.Return(_lret0);
                            return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                        }
                        var _arg3 = _lastArg = _argCount > 3 ? _context.GetArgument(3) : global::Lua.LuaValue.Nil;
                        _lastArgPos = 3; _expectedType = typeof(global::LunyEditor.UnityEditor.Build.Content.LuaBuildUsageCache);
                        if (_arg3.TryRead<global::LunyEditor.UnityEditor.Build.Content.LuaBuildUsageCache>(out var _p3_UnityEditor_Build_Content_BuildUsageCache))
                        {
                            if (_argCount == 4)
                            {
                                var settings = _p0_UnityEditor_Build_Content_BuildSettings.Value;
                                var globalUsage = _p1_UnityEditor_Build_Content_BuildUsageTagGlobal.Value;
                                var usageSet = _p2_UnityEditor_Build_Content_BuildUsageTagSet.Instance;
                                var usageCache = _p3_UnityEditor_Build_Content_BuildUsageCache.Instance;
                                var _ret0 = global::UnityEditor.Build.Content.ContentBuildInterface.CalculatePlayerDependenciesForGameManagers(settings, globalUsage, usageSet, usageCache);
                                var _lret0 = global::LunyEditor.UnityEditor.Build.Content.LuaGameManagerDependencyInfo.Bind(_ret0);
                                var _retCount = _context.Return(_lret0);
                                return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                            }
                            var _arg4 = _lastArg = _argCount > 4 ? _context.GetArgument(4) : global::Lua.LuaValue.Nil;
                            _lastArgPos = 4; _expectedType = typeof(global::UnityEditor.Build.Content.DependencyType);
                            if (_arg4.TryRead<global::UnityEditor.Build.Content.DependencyType>(out var _p4_UnityEditor_Build_Content_DependencyType))
                            {
                                if (_argCount == 5)
                                {
                                    var settings = _p0_UnityEditor_Build_Content_BuildSettings.Value;
                                    var globalUsage = _p1_UnityEditor_Build_Content_BuildUsageTagGlobal.Value;
                                    var usageSet = _p2_UnityEditor_Build_Content_BuildUsageTagSet.Instance;
                                    var usageCache = _p3_UnityEditor_Build_Content_BuildUsageCache.Instance;
                                    var mode = _p4_UnityEditor_Build_Content_DependencyType;
                                    var _ret0 = global::UnityEditor.Build.Content.ContentBuildInterface.CalculatePlayerDependenciesForGameManagers(settings, globalUsage, usageSet, usageCache, mode);
                                    var _lret0 = global::LunyEditor.UnityEditor.Build.Content.LuaGameManagerDependencyInfo.Bind(_ret0);
                                    var _retCount = _context.Return(_lret0);
                                    return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                                }
                            }
                        }
                    }
                }
            }
            throw new global::Lua.LuaRuntimeException(_context.Thread, $"{"CalculatePlayerDependenciesForGameManagers"}: invalid argument #{_lastArgPos}: {_lastArg} ({_lastArg.Type}), expected: {_expectedType.FullName}", 2);
        });
        private static readonly global::Lua.LuaFunction _LuaContentBuildInterface_CalculatePlayerDependenciesForScene = new global::Lua.LuaFunction("CalculatePlayerDependenciesForScene", (_context, _) =>
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
                _lastArgPos = 1; _expectedType = typeof(global::LunyEditor.UnityEditor.Build.Content.LuaBuildSettings);
                if (_arg1.TryRead<global::LunyEditor.UnityEditor.Build.Content.LuaBuildSettings>(out var _p1_UnityEditor_Build_Content_BuildSettings))
                {
                    var _arg2 = _lastArg = _argCount > 2 ? _context.GetArgument(2) : global::Lua.LuaValue.Nil;
                    _lastArgPos = 2; _expectedType = typeof(global::LunyEditor.UnityEditor.Build.Content.LuaBuildUsageTagSet);
                    if (_arg2.TryRead<global::LunyEditor.UnityEditor.Build.Content.LuaBuildUsageTagSet>(out var _p2_UnityEditor_Build_Content_BuildUsageTagSet))
                    {
                        if (_argCount == 3)
                        {
                            var scenePath = _p0_System_String;
                            var settings = _p1_UnityEditor_Build_Content_BuildSettings.Value;
                            var usageSet = _p2_UnityEditor_Build_Content_BuildUsageTagSet.Instance;
                            var _ret0 = global::UnityEditor.Build.Content.ContentBuildInterface.CalculatePlayerDependenciesForScene(scenePath, settings, usageSet);
                            var _lret0 = global::LunyEditor.UnityEditor.Build.Content.LuaSceneDependencyInfo.Bind(_ret0);
                            var _retCount = _context.Return(_lret0);
                            return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                        }
                        var _arg3 = _lastArg = _argCount > 3 ? _context.GetArgument(3) : global::Lua.LuaValue.Nil;
                        _lastArgPos = 3; _expectedType = typeof(global::LunyEditor.UnityEditor.Build.Content.LuaBuildUsageCache);
                        if (_arg3.TryRead<global::LunyEditor.UnityEditor.Build.Content.LuaBuildUsageCache>(out var _p3_UnityEditor_Build_Content_BuildUsageCache))
                        {
                            if (_argCount == 4)
                            {
                                var scenePath = _p0_System_String;
                                var settings = _p1_UnityEditor_Build_Content_BuildSettings.Value;
                                var usageSet = _p2_UnityEditor_Build_Content_BuildUsageTagSet.Instance;
                                var usageCache = _p3_UnityEditor_Build_Content_BuildUsageCache.Instance;
                                var _ret0 = global::UnityEditor.Build.Content.ContentBuildInterface.CalculatePlayerDependenciesForScene(scenePath, settings, usageSet, usageCache);
                                var _lret0 = global::LunyEditor.UnityEditor.Build.Content.LuaSceneDependencyInfo.Bind(_ret0);
                                var _retCount = _context.Return(_lret0);
                                return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                            }
                            var _arg4 = _lastArg = _argCount > 4 ? _context.GetArgument(4) : global::Lua.LuaValue.Nil;
                            _lastArgPos = 4; _expectedType = typeof(global::UnityEditor.Build.Content.DependencyType);
                            if (_arg4.TryRead<global::UnityEditor.Build.Content.DependencyType>(out var _p4_UnityEditor_Build_Content_DependencyType))
                            {
                                if (_argCount == 5)
                                {
                                    var scenePath = _p0_System_String;
                                    var settings = _p1_UnityEditor_Build_Content_BuildSettings.Value;
                                    var usageSet = _p2_UnityEditor_Build_Content_BuildUsageTagSet.Instance;
                                    var usageCache = _p3_UnityEditor_Build_Content_BuildUsageCache.Instance;
                                    var mode = _p4_UnityEditor_Build_Content_DependencyType;
                                    var _ret0 = global::UnityEditor.Build.Content.ContentBuildInterface.CalculatePlayerDependenciesForScene(scenePath, settings, usageSet, usageCache, mode);
                                    var _lret0 = global::LunyEditor.UnityEditor.Build.Content.LuaSceneDependencyInfo.Bind(_ret0);
                                    var _retCount = _context.Return(_lret0);
                                    return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                                }
                            }
                        }
                    }
                }
            }
            throw new global::Lua.LuaRuntimeException(_context.Thread, $"{"CalculatePlayerDependenciesForScene"}: invalid argument #{_lastArgPos}: {_lastArg} ({_lastArg.Type}), expected: {_expectedType.FullName}", 2);
        });
        private static readonly global::Lua.LuaFunction _LuaContentBuildInterface_CalculatePlayerSerializationHashForType = new global::Lua.LuaFunction("CalculatePlayerSerializationHashForType", (_context, _) =>
        {
            global::Lua.LuaValue _lastArg = default;
            global::System.Int32 _lastArgPos = default;
            global::System.Type _expectedType = default;
            var _argCount = _context.ArgumentCount;
            var _arg0 = _lastArg = _argCount > 0 ? _context.GetArgument(0) : global::Lua.LuaValue.Nil;
            _lastArgPos = 0; _expectedType = typeof(global::Luny.ILuaBindType);
            if (_arg0.TryRead<global::Luny.ILuaBindType>(out var _p0_System_Type))
            {
                var _arg1 = _lastArg = _argCount > 1 ? _context.GetArgument(1) : global::Lua.LuaValue.Nil;
                _lastArgPos = 1; _expectedType = typeof(global::LunyEditor.UnityEditor.Build.Player.LuaTypeDB);
                if (_arg1.TryRead<global::LunyEditor.UnityEditor.Build.Player.LuaTypeDB>(out var _p1_UnityEditor_Build_Player_TypeDB))
                {
                    if (_argCount == 2)
                    {
                        var type = _p0_System_Type.BindType;
                        var typeDB = _p1_UnityEditor_Build_Player_TypeDB.Instance;
                        var _ret0 = global::UnityEditor.Build.Content.ContentBuildInterface.CalculatePlayerSerializationHashForType(type, typeDB);
                        var _lret0 = global::Luny.UnityEngine.LuaHash128.Bind(_ret0);
                        var _retCount = _context.Return(_lret0);
                        return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                    }
                }
            }
            throw new global::Lua.LuaRuntimeException(_context.Thread, $"{"CalculatePlayerSerializationHashForType"}: invalid argument #{_lastArgPos}: {_lastArg} ({_lastArg.Type}), expected: {_expectedType.FullName}", 2);
        });
        private static readonly global::Lua.LuaFunction _LuaContentBuildInterface_GenerateAssetBundleBuilds = new global::Lua.LuaFunction("GenerateAssetBundleBuilds", (_context, _) =>
        {
            global::Lua.LuaValue _lastArg = default;
            global::System.Int32 _lastArgPos = default;
            global::System.Type _expectedType = default;
            var _argCount = _context.ArgumentCount;
            if (_argCount == 0)
            {
                var _ret0 = global::UnityEditor.Build.Content.ContentBuildInterface.GenerateAssetBundleBuilds();
                var _factory = _context.GetObjectFactory();
                var _lret0 = _factory.Bind(_ret0);
                var _retCount = _context.Return(_lret0);
                return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
            }
            throw new global::Lua.LuaRuntimeException(_context.Thread, $"{"GenerateAssetBundleBuilds"}: invalid argument #{_lastArgPos}: {_lastArg} ({_lastArg.Type}), expected: {_expectedType.FullName}", 2);
        });
        private static readonly global::Lua.LuaFunction _LuaContentBuildInterface_GetGlobalUsageFromActiveScene = new global::Lua.LuaFunction("GetGlobalUsageFromActiveScene", (_context, _) =>
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
                    var _ret0 = global::UnityEditor.Build.Content.ContentBuildInterface.GetGlobalUsageFromActiveScene(target);
                    var _lret0 = global::LunyEditor.UnityEditor.Build.Content.LuaBuildUsageTagGlobal.Bind(_ret0);
                    var _retCount = _context.Return(_lret0);
                    return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                }
            }
            throw new global::Lua.LuaRuntimeException(_context.Thread, $"{"GetGlobalUsageFromActiveScene"}: invalid argument #{_lastArgPos}: {_lastArg} ({_lastArg.Type}), expected: {_expectedType.FullName}", 2);
        });
        private static readonly global::Lua.LuaFunction _LuaContentBuildInterface_GetGlobalUsageFromGraphicsSettings = new global::Lua.LuaFunction("GetGlobalUsageFromGraphicsSettings", (_context, _) =>
        {
            global::Lua.LuaValue _lastArg = default;
            global::System.Int32 _lastArgPos = default;
            global::System.Type _expectedType = default;
            var _argCount = _context.ArgumentCount;
            if (_argCount == 0)
            {
                var _ret0 = global::UnityEditor.Build.Content.ContentBuildInterface.GetGlobalUsageFromGraphicsSettings();
                var _lret0 = global::LunyEditor.UnityEditor.Build.Content.LuaBuildUsageTagGlobal.Bind(_ret0);
                var _retCount = _context.Return(_lret0);
                return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
            }
            throw new global::Lua.LuaRuntimeException(_context.Thread, $"{"GetGlobalUsageFromGraphicsSettings"}: invalid argument #{_lastArgPos}: {_lastArg} ({_lastArg.Type}), expected: {_expectedType.FullName}", 2);
        });
        private static readonly global::Lua.LuaFunction _LuaContentBuildInterface_GetPlayerAssetRepresentations = new global::Lua.LuaFunction("GetPlayerAssetRepresentations", (_context, _) =>
        {
            global::Lua.LuaValue _lastArg = default;
            global::System.Int32 _lastArgPos = default;
            global::System.Type _expectedType = default;
            var _argCount = _context.ArgumentCount;
            var _arg0 = _lastArg = _argCount > 0 ? _context.GetArgument(0) : global::Lua.LuaValue.Nil;
            _lastArgPos = 0; _expectedType = typeof(global::LunyEditor.UnityEditor.LuaGUID);
            if (_arg0.TryRead<global::LunyEditor.UnityEditor.LuaGUID>(out var _p0_UnityEditor_GUID))
            {
                var _arg1 = _lastArg = _argCount > 1 ? _context.GetArgument(1) : global::Lua.LuaValue.Nil;
                _lastArgPos = 1; _expectedType = typeof(global::UnityEditor.BuildTarget);
                if (_arg1.TryRead<global::UnityEditor.BuildTarget>(out var _p1_UnityEditor_BuildTarget))
                {
                    if (_argCount == 2)
                    {
                        var asset = _p0_UnityEditor_GUID.Value;
                        var target = _p1_UnityEditor_BuildTarget;
                        var _ret0 = global::UnityEditor.Build.Content.ContentBuildInterface.GetPlayerAssetRepresentations(asset, target);
                        var _factory = _context.GetObjectFactory();
                        var _lret0 = _factory.Bind(_ret0);
                        var _retCount = _context.Return(_lret0);
                        return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                    }
                }
            }
            throw new global::Lua.LuaRuntimeException(_context.Thread, $"{"GetPlayerAssetRepresentations"}: invalid argument #{_lastArgPos}: {_lastArg} ({_lastArg.Type}), expected: {_expectedType.FullName}", 2);
        });
        private static readonly global::Lua.LuaFunction _LuaContentBuildInterface_GetPlayerDependenciesForObject = new global::Lua.LuaFunction("GetPlayerDependenciesForObject", (_context, _) =>
        {
            global::Lua.LuaValue _lastArg = default;
            global::System.Int32 _lastArgPos = default;
            global::System.Type _expectedType = default;
            var _argCount = _context.ArgumentCount;
            var _arg0 = _lastArg = _argCount > 0 ? _context.GetArgument(0) : global::Lua.LuaValue.Nil;
            _lastArgPos = 0; _expectedType = typeof(global::LunyEditor.UnityEditor.Build.Content.LuaObjectIdentifier);
            if (_arg0.TryRead<global::LunyEditor.UnityEditor.Build.Content.LuaObjectIdentifier>(out var _p0_UnityEditor_Build_Content_ObjectIdentifier))
            {
                var _arg1 = _lastArg = _argCount > 1 ? _context.GetArgument(1) : global::Lua.LuaValue.Nil;
                _lastArgPos = 1; _expectedType = typeof(global::UnityEditor.BuildTarget);
                if (_arg1.TryRead<global::UnityEditor.BuildTarget>(out var _p1_UnityEditor_BuildTarget))
                {
                    var _arg2 = _lastArg = _argCount > 2 ? _context.GetArgument(2) : global::Lua.LuaValue.Nil;
                    _lastArgPos = 2; _expectedType = typeof(global::LunyEditor.UnityEditor.Build.Player.LuaTypeDB);
                    if (_arg2.TryRead<global::LunyEditor.UnityEditor.Build.Player.LuaTypeDB>(out var _p2_UnityEditor_Build_Player_TypeDB))
                    {
                        if (_argCount == 3)
                        {
                            var objectID = _p0_UnityEditor_Build_Content_ObjectIdentifier.Value;
                            var target = _p1_UnityEditor_BuildTarget;
                            var typeDB = _p2_UnityEditor_Build_Player_TypeDB.Instance;
                            var _ret0 = global::UnityEditor.Build.Content.ContentBuildInterface.GetPlayerDependenciesForObject(objectID, target, typeDB);
                            var _factory = _context.GetObjectFactory();
                            var _lret0 = _factory.Bind(_ret0);
                            var _retCount = _context.Return(_lret0);
                            return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                        }
                        var _arg3 = _lastArg = _argCount > 3 ? _context.GetArgument(3) : global::Lua.LuaValue.Nil;
                        _lastArgPos = 3; _expectedType = typeof(global::UnityEditor.Build.Content.DependencyType);
                        if (_arg3.TryRead<global::UnityEditor.Build.Content.DependencyType>(out var _p3_UnityEditor_Build_Content_DependencyType))
                        {
                            if (_argCount == 4)
                            {
                                var objectID = _p0_UnityEditor_Build_Content_ObjectIdentifier.Value;
                                var target = _p1_UnityEditor_BuildTarget;
                                var typeDB = _p2_UnityEditor_Build_Player_TypeDB.Instance;
                                var mode = _p3_UnityEditor_Build_Content_DependencyType;
                                var _ret0 = global::UnityEditor.Build.Content.ContentBuildInterface.GetPlayerDependenciesForObject(objectID, target, typeDB, mode);
                                var _factory = _context.GetObjectFactory();
                                var _lret0 = _factory.Bind(_ret0);
                                var _retCount = _context.Return(_lret0);
                                return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                            }
                        }
                    }
                }
            }
            _lastArgPos = 0; _expectedType = typeof(global::Luny.UnityEngine.LuaUnityObject);
            if (_arg0.TryRead<global::Luny.UnityEngine.LuaUnityObject>(out var _p0_UnityEngine_Object))
            {
                var _arg1 = _lastArg = _argCount > 1 ? _context.GetArgument(1) : global::Lua.LuaValue.Nil;
                _lastArgPos = 1; _expectedType = typeof(global::UnityEditor.BuildTarget);
                if (_arg1.TryRead<global::UnityEditor.BuildTarget>(out var _p1_UnityEditor_BuildTarget))
                {
                    var _arg2 = _lastArg = _argCount > 2 ? _context.GetArgument(2) : global::Lua.LuaValue.Nil;
                    _lastArgPos = 2; _expectedType = typeof(global::LunyEditor.UnityEditor.Build.Player.LuaTypeDB);
                    if (_arg2.TryRead<global::LunyEditor.UnityEditor.Build.Player.LuaTypeDB>(out var _p2_UnityEditor_Build_Player_TypeDB))
                    {
                        if (_argCount == 3)
                        {
                            var targetObject = _p0_UnityEngine_Object.Instance;
                            var target = _p1_UnityEditor_BuildTarget;
                            var typeDB = _p2_UnityEditor_Build_Player_TypeDB.Instance;
                            var _ret0 = global::UnityEditor.Build.Content.ContentBuildInterface.GetPlayerDependenciesForObject(targetObject, target, typeDB);
                            var _factory = _context.GetObjectFactory();
                            var _lret0 = _factory.Bind(_ret0);
                            var _retCount = _context.Return(_lret0);
                            return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                        }
                        var _arg3 = _lastArg = _argCount > 3 ? _context.GetArgument(3) : global::Lua.LuaValue.Nil;
                        _lastArgPos = 3; _expectedType = typeof(global::UnityEditor.Build.Content.DependencyType);
                        if (_arg3.TryRead<global::UnityEditor.Build.Content.DependencyType>(out var _p3_UnityEditor_Build_Content_DependencyType))
                        {
                            if (_argCount == 4)
                            {
                                var targetObject = _p0_UnityEngine_Object.Instance;
                                var target = _p1_UnityEditor_BuildTarget;
                                var typeDB = _p2_UnityEditor_Build_Player_TypeDB.Instance;
                                var mode = _p3_UnityEditor_Build_Content_DependencyType;
                                var _ret0 = global::UnityEditor.Build.Content.ContentBuildInterface.GetPlayerDependenciesForObject(targetObject, target, typeDB, mode);
                                var _factory = _context.GetObjectFactory();
                                var _lret0 = _factory.Bind(_ret0);
                                var _retCount = _context.Return(_lret0);
                                return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                            }
                        }
                    }
                }
            }
            throw new global::Lua.LuaRuntimeException(_context.Thread, $"{"GetPlayerDependenciesForObject"}: invalid argument #{_lastArgPos}: {_lastArg} ({_lastArg.Type}), expected: {_expectedType.FullName}", 2);
        });
        private static readonly global::Lua.LuaFunction _LuaContentBuildInterface_GetPlayerDependenciesForObjects = new global::Lua.LuaFunction("GetPlayerDependenciesForObjects", (_context, _) =>
        {
            global::Lua.LuaValue _lastArg = default;
            global::System.Int32 _lastArgPos = default;
            global::System.Type _expectedType = default;
            var _argCount = _context.ArgumentCount;
            var _arg0 = _lastArg = _argCount > 0 ? _context.GetArgument(0) : global::Lua.LuaValue.Nil;
            _lastArgPos = 0; _expectedType = typeof(global::UnityEditor.Build.Content.ObjectIdentifier[]);
            if (_arg0.TryReadArray<global::UnityEditor.Build.Content.ObjectIdentifier>(out var _p0_UnityEditor_Build_Content_ObjectIdentifierArray))
            {
                var _arg1 = _lastArg = _argCount > 1 ? _context.GetArgument(1) : global::Lua.LuaValue.Nil;
                _lastArgPos = 1; _expectedType = typeof(global::UnityEditor.BuildTarget);
                if (_arg1.TryRead<global::UnityEditor.BuildTarget>(out var _p1_UnityEditor_BuildTarget))
                {
                    var _arg2 = _lastArg = _argCount > 2 ? _context.GetArgument(2) : global::Lua.LuaValue.Nil;
                    _lastArgPos = 2; _expectedType = typeof(global::LunyEditor.UnityEditor.Build.Player.LuaTypeDB);
                    if (_arg2.TryRead<global::LunyEditor.UnityEditor.Build.Player.LuaTypeDB>(out var _p2_UnityEditor_Build_Player_TypeDB))
                    {
                        if (_argCount == 3)
                        {
                            var objectIDs = _p0_UnityEditor_Build_Content_ObjectIdentifierArray;
                            var target = _p1_UnityEditor_BuildTarget;
                            var typeDB = _p2_UnityEditor_Build_Player_TypeDB.Instance;
                            var _ret0 = global::UnityEditor.Build.Content.ContentBuildInterface.GetPlayerDependenciesForObjects(objectIDs, target, typeDB);
                            var _factory = _context.GetObjectFactory();
                            var _lret0 = _factory.Bind(_ret0);
                            var _retCount = _context.Return(_lret0);
                            return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                        }
                        var _arg3 = _lastArg = _argCount > 3 ? _context.GetArgument(3) : global::Lua.LuaValue.Nil;
                        _lastArgPos = 3; _expectedType = typeof(global::UnityEditor.Build.Content.DependencyType);
                        if (_arg3.TryRead<global::UnityEditor.Build.Content.DependencyType>(out var _p3_UnityEditor_Build_Content_DependencyType))
                        {
                            if (_argCount == 4)
                            {
                                var objectIDs = _p0_UnityEditor_Build_Content_ObjectIdentifierArray;
                                var target = _p1_UnityEditor_BuildTarget;
                                var typeDB = _p2_UnityEditor_Build_Player_TypeDB.Instance;
                                var mode = _p3_UnityEditor_Build_Content_DependencyType;
                                var _ret0 = global::UnityEditor.Build.Content.ContentBuildInterface.GetPlayerDependenciesForObjects(objectIDs, target, typeDB, mode);
                                var _factory = _context.GetObjectFactory();
                                var _lret0 = _factory.Bind(_ret0);
                                var _retCount = _context.Return(_lret0);
                                return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                            }
                        }
                    }
                }
            }
            _lastArgPos = 0; _expectedType = typeof(global::UnityEngine.Object[]);
            if (_arg0.TryReadArray<global::UnityEngine.Object>(out var _p0_UnityEngine_ObjectArray))
            {
                var _arg1 = _lastArg = _argCount > 1 ? _context.GetArgument(1) : global::Lua.LuaValue.Nil;
                _lastArgPos = 1; _expectedType = typeof(global::UnityEditor.BuildTarget);
                if (_arg1.TryRead<global::UnityEditor.BuildTarget>(out var _p1_UnityEditor_BuildTarget))
                {
                    var _arg2 = _lastArg = _argCount > 2 ? _context.GetArgument(2) : global::Lua.LuaValue.Nil;
                    _lastArgPos = 2; _expectedType = typeof(global::LunyEditor.UnityEditor.Build.Player.LuaTypeDB);
                    if (_arg2.TryRead<global::LunyEditor.UnityEditor.Build.Player.LuaTypeDB>(out var _p2_UnityEditor_Build_Player_TypeDB))
                    {
                        if (_argCount == 3)
                        {
                            var objects = _p0_UnityEngine_ObjectArray;
                            var target = _p1_UnityEditor_BuildTarget;
                            var typeDB = _p2_UnityEditor_Build_Player_TypeDB.Instance;
                            var _ret0 = global::UnityEditor.Build.Content.ContentBuildInterface.GetPlayerDependenciesForObjects(objects, target, typeDB);
                            var _factory = _context.GetObjectFactory();
                            var _lret0 = _factory.Bind(_ret0);
                            var _retCount = _context.Return(_lret0);
                            return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                        }
                        var _arg3 = _lastArg = _argCount > 3 ? _context.GetArgument(3) : global::Lua.LuaValue.Nil;
                        _lastArgPos = 3; _expectedType = typeof(global::UnityEditor.Build.Content.DependencyType);
                        if (_arg3.TryRead<global::UnityEditor.Build.Content.DependencyType>(out var _p3_UnityEditor_Build_Content_DependencyType))
                        {
                            if (_argCount == 4)
                            {
                                var objects = _p0_UnityEngine_ObjectArray;
                                var target = _p1_UnityEditor_BuildTarget;
                                var typeDB = _p2_UnityEditor_Build_Player_TypeDB.Instance;
                                var mode = _p3_UnityEditor_Build_Content_DependencyType;
                                var _ret0 = global::UnityEditor.Build.Content.ContentBuildInterface.GetPlayerDependenciesForObjects(objects, target, typeDB, mode);
                                var _factory = _context.GetObjectFactory();
                                var _lret0 = _factory.Bind(_ret0);
                                var _retCount = _context.Return(_lret0);
                                return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                            }
                        }
                    }
                }
            }
            throw new global::Lua.LuaRuntimeException(_context.Thread, $"{"GetPlayerDependenciesForObjects"}: invalid argument #{_lastArgPos}: {_lastArg} ({_lastArg.Type}), expected: {_expectedType.FullName}", 2);
        });
        private static readonly global::Lua.LuaFunction _LuaContentBuildInterface_GetPlayerObjectIdentifiersInAsset = new global::Lua.LuaFunction("GetPlayerObjectIdentifiersInAsset", (_context, _) =>
        {
            global::Lua.LuaValue _lastArg = default;
            global::System.Int32 _lastArgPos = default;
            global::System.Type _expectedType = default;
            var _argCount = _context.ArgumentCount;
            var _arg0 = _lastArg = _argCount > 0 ? _context.GetArgument(0) : global::Lua.LuaValue.Nil;
            _lastArgPos = 0; _expectedType = typeof(global::LunyEditor.UnityEditor.LuaGUID);
            if (_arg0.TryRead<global::LunyEditor.UnityEditor.LuaGUID>(out var _p0_UnityEditor_GUID))
            {
                var _arg1 = _lastArg = _argCount > 1 ? _context.GetArgument(1) : global::Lua.LuaValue.Nil;
                _lastArgPos = 1; _expectedType = typeof(global::UnityEditor.BuildTarget);
                if (_arg1.TryRead<global::UnityEditor.BuildTarget>(out var _p1_UnityEditor_BuildTarget))
                {
                    if (_argCount == 2)
                    {
                        var asset = _p0_UnityEditor_GUID.Value;
                        var target = _p1_UnityEditor_BuildTarget;
                        var _ret0 = global::UnityEditor.Build.Content.ContentBuildInterface.GetPlayerObjectIdentifiersInAsset(asset, target);
                        var _factory = _context.GetObjectFactory();
                        var _lret0 = _factory.Bind(_ret0);
                        var _retCount = _context.Return(_lret0);
                        return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                    }
                }
            }
            throw new global::Lua.LuaRuntimeException(_context.Thread, $"{"GetPlayerObjectIdentifiersInAsset"}: invalid argument #{_lastArgPos}: {_lastArg} ({_lastArg.Type}), expected: {_expectedType.FullName}", 2);
        });
        private static readonly global::Lua.LuaFunction _LuaContentBuildInterface_GetPlayerObjectIdentifiersInSerializedFile = new global::Lua.LuaFunction("GetPlayerObjectIdentifiersInSerializedFile", (_context, _) =>
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
                    if (_argCount == 2)
                    {
                        var filePath = _p0_System_String;
                        var target = _p1_UnityEditor_BuildTarget;
                        var _ret0 = global::UnityEditor.Build.Content.ContentBuildInterface.GetPlayerObjectIdentifiersInSerializedFile(filePath, target);
                        var _factory = _context.GetObjectFactory();
                        var _lret0 = _factory.Bind(_ret0);
                        var _retCount = _context.Return(_lret0);
                        return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                    }
                }
            }
            throw new global::Lua.LuaRuntimeException(_context.Thread, $"{"GetPlayerObjectIdentifiersInSerializedFile"}: invalid argument #{_lastArgPos}: {_lastArg} ({_lastArg.Type}), expected: {_expectedType.FullName}", 2);
        });
        private static readonly global::Lua.LuaFunction _LuaContentBuildInterface_GetTypeForObject = new global::Lua.LuaFunction("GetTypeForObject", (_context, _) =>
        {
            global::Lua.LuaValue _lastArg = default;
            global::System.Int32 _lastArgPos = default;
            global::System.Type _expectedType = default;
            var _argCount = _context.ArgumentCount;
            var _arg0 = _lastArg = _argCount > 0 ? _context.GetArgument(0) : global::Lua.LuaValue.Nil;
            _lastArgPos = 0; _expectedType = typeof(global::LunyEditor.UnityEditor.Build.Content.LuaObjectIdentifier);
            if (_arg0.TryRead<global::LunyEditor.UnityEditor.Build.Content.LuaObjectIdentifier>(out var _p0_UnityEditor_Build_Content_ObjectIdentifier))
            {
                if (_argCount == 1)
                {
                    var objectID = _p0_UnityEditor_Build_Content_ObjectIdentifier.Value;
                    var _ret0 = global::UnityEditor.Build.Content.ContentBuildInterface.GetTypeForObject(objectID);
                    var _factory = _context.GetObjectFactory();
                    var _lret0 = _factory.Bind(_ret0);
                    var _retCount = _context.Return(_lret0);
                    return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                }
            }
            throw new global::Lua.LuaRuntimeException(_context.Thread, $"{"GetTypeForObject"}: invalid argument #{_lastArgPos}: {_lastArg} ({_lastArg.Type}), expected: {_expectedType.FullName}", 2);
        });
        private static readonly global::Lua.LuaFunction _LuaContentBuildInterface_GetTypeForObjects = new global::Lua.LuaFunction("GetTypeForObjects", (_context, _) =>
        {
            global::Lua.LuaValue _lastArg = default;
            global::System.Int32 _lastArgPos = default;
            global::System.Type _expectedType = default;
            var _argCount = _context.ArgumentCount;
            var _arg0 = _lastArg = _argCount > 0 ? _context.GetArgument(0) : global::Lua.LuaValue.Nil;
            _lastArgPos = 0; _expectedType = typeof(global::UnityEditor.Build.Content.ObjectIdentifier[]);
            if (_arg0.TryReadArray<global::UnityEditor.Build.Content.ObjectIdentifier>(out var _p0_UnityEditor_Build_Content_ObjectIdentifierArray))
            {
                if (_argCount == 1)
                {
                    var objectIDs = _p0_UnityEditor_Build_Content_ObjectIdentifierArray;
                    var _ret0 = global::UnityEditor.Build.Content.ContentBuildInterface.GetTypeForObjects(objectIDs);
                    var _factory = _context.GetObjectFactory();
                    var _lret0 = _factory.Bind(_ret0);
                    var _retCount = _context.Return(_lret0);
                    return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                }
            }
            throw new global::Lua.LuaRuntimeException(_context.Thread, $"{"GetTypeForObjects"}: invalid argument #{_lastArgPos}: {_lastArg} ({_lastArg.Type}), expected: {_expectedType.FullName}", 2);
        });
        private static readonly global::Lua.LuaFunction _LuaContentBuildInterface_GetTypesForObject = new global::Lua.LuaFunction("GetTypesForObject", (_context, _) =>
        {
            global::Lua.LuaValue _lastArg = default;
            global::System.Int32 _lastArgPos = default;
            global::System.Type _expectedType = default;
            var _argCount = _context.ArgumentCount;
            var _arg0 = _lastArg = _argCount > 0 ? _context.GetArgument(0) : global::Lua.LuaValue.Nil;
            _lastArgPos = 0; _expectedType = typeof(global::LunyEditor.UnityEditor.Build.Content.LuaObjectIdentifier);
            if (_arg0.TryRead<global::LunyEditor.UnityEditor.Build.Content.LuaObjectIdentifier>(out var _p0_UnityEditor_Build_Content_ObjectIdentifier))
            {
                if (_argCount == 1)
                {
                    var objectID = _p0_UnityEditor_Build_Content_ObjectIdentifier.Value;
                    var _ret0 = global::UnityEditor.Build.Content.ContentBuildInterface.GetTypesForObject(objectID);
                    var _factory = _context.GetObjectFactory();
                    var _lret0 = _factory.Bind(_ret0);
                    var _retCount = _context.Return(_lret0);
                    return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                }
            }
            throw new global::Lua.LuaRuntimeException(_context.Thread, $"{"GetTypesForObject"}: invalid argument #{_lastArgPos}: {_lastArg} ({_lastArg.Type}), expected: {_expectedType.FullName}", 2);
        });
        private static readonly global::Lua.LuaFunction _LuaContentBuildInterface_ObjectIsSupportedInBuild = new global::Lua.LuaFunction("ObjectIsSupportedInBuild", (_context, _) =>
        {
            global::Lua.LuaValue _lastArg = default;
            global::System.Int32 _lastArgPos = default;
            global::System.Type _expectedType = default;
            var _argCount = _context.ArgumentCount;
            var _arg0 = _lastArg = _argCount > 0 ? _context.GetArgument(0) : global::Lua.LuaValue.Nil;
            _lastArgPos = 0; _expectedType = typeof(global::Luny.UnityEngine.LuaUnityObject);
            if (_arg0.TryRead<global::Luny.UnityEngine.LuaUnityObject>(out var _p0_UnityEngine_Object))
            {
                if (_argCount == 1)
                {
                    var targetObject = _p0_UnityEngine_Object.Instance;
                    var _ret0 = global::UnityEditor.Build.Content.ContentBuildInterface.ObjectIsSupportedInBuild(targetObject);
                    var _lret0 = new global::Lua.LuaValue(_ret0);
                    var _retCount = _context.Return(_lret0);
                    return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                }
            }
            throw new global::Lua.LuaRuntimeException(_context.Thread, $"{"ObjectIsSupportedInBuild"}: invalid argument #{_lastArgPos}: {_lastArg} ({_lastArg.Type}), expected: {_expectedType.FullName}", 2);
        });
        private static readonly global::Lua.LuaFunction _LuaContentBuildInterface_StartProfileCapture = new global::Lua.LuaFunction("StartProfileCapture", (_context, _) =>
        {
            global::Lua.LuaValue _lastArg = default;
            global::System.Int32 _lastArgPos = default;
            global::System.Type _expectedType = default;
            var _argCount = _context.ArgumentCount;
            var _arg0 = _lastArg = _argCount > 0 ? _context.GetArgument(0) : global::Lua.LuaValue.Nil;
            _lastArgPos = 0; _expectedType = typeof(global::UnityEditor.Build.Content.ProfileCaptureOptions);
            if (_arg0.TryRead<global::UnityEditor.Build.Content.ProfileCaptureOptions>(out var _p0_UnityEditor_Build_Content_ProfileCaptureOptions))
            {
                if (_argCount == 1)
                {
                    var options = _p0_UnityEditor_Build_Content_ProfileCaptureOptions;
                    global::UnityEditor.Build.Content.ContentBuildInterface.StartProfileCapture(options);
                    var _retCount = _context.Return();
                    return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                }
            }
            throw new global::Lua.LuaRuntimeException(_context.Thread, $"{"StartProfileCapture"}: invalid argument #{_lastArgPos}: {_lastArg} ({_lastArg.Type}), expected: {_expectedType.FullName}", 2);
        });
        private static readonly global::Lua.LuaFunction _LuaContentBuildInterface_StopProfileCapture = new global::Lua.LuaFunction("StopProfileCapture", (_context, _) =>
        {
            global::Lua.LuaValue _lastArg = default;
            global::System.Int32 _lastArgPos = default;
            global::System.Type _expectedType = default;
            var _argCount = _context.ArgumentCount;
            if (_argCount == 0)
            {
                var _ret0 = global::UnityEditor.Build.Content.ContentBuildInterface.StopProfileCapture();
                var _factory = _context.GetObjectFactory();
                var _lret0 = _factory.Bind(_ret0);
                var _retCount = _context.Return(_lret0);
                return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
            }
            throw new global::Lua.LuaRuntimeException(_context.Thread, $"{"StopProfileCapture"}: invalid argument #{_lastArgPos}: {_lastArg} ({_lastArg.Type}), expected: {_expectedType.FullName}", 2);
        });
        private static readonly global::Lua.LuaFunction _LuaContentBuildInterface_WriteGameManagersSerializedFile = new global::Lua.LuaFunction("WriteGameManagersSerializedFile", (_context, _) =>
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
                _lastArgPos = 1; _expectedType = typeof(global::LunyEditor.UnityEditor.Build.Content.LuaWriteManagerParameters);
                if (_arg1.TryRead<global::LunyEditor.UnityEditor.Build.Content.LuaWriteManagerParameters>(out var _p1_UnityEditor_Build_Content_WriteManagerParameters))
                {
                    if (_argCount == 2)
                    {
                        var outputFolder = _p0_System_String;
                        var parameters = _p1_UnityEditor_Build_Content_WriteManagerParameters.Value;
                        var _ret0 = global::UnityEditor.Build.Content.ContentBuildInterface.WriteGameManagersSerializedFile(outputFolder, parameters);
                        var _lret0 = global::LunyEditor.UnityEditor.Build.Content.LuaWriteResult.Bind(_ret0);
                        var _retCount = _context.Return(_lret0);
                        return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                    }
                }
            }
            throw new global::Lua.LuaRuntimeException(_context.Thread, $"{"WriteGameManagersSerializedFile"}: invalid argument #{_lastArgPos}: {_lastArg} ({_lastArg.Type}), expected: {_expectedType.FullName}", 2);
        });
        private static readonly global::Lua.LuaFunction _LuaContentBuildInterface_WriteSceneSerializedFile = new global::Lua.LuaFunction("WriteSceneSerializedFile", (_context, _) =>
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
                _lastArgPos = 1; _expectedType = typeof(global::LunyEditor.UnityEditor.Build.Content.LuaWriteSceneParameters);
                if (_arg1.TryRead<global::LunyEditor.UnityEditor.Build.Content.LuaWriteSceneParameters>(out var _p1_UnityEditor_Build_Content_WriteSceneParameters))
                {
                    if (_argCount == 2)
                    {
                        var outputFolder = _p0_System_String;
                        var parameters = _p1_UnityEditor_Build_Content_WriteSceneParameters.Value;
                        var _ret0 = global::UnityEditor.Build.Content.ContentBuildInterface.WriteSceneSerializedFile(outputFolder, parameters);
                        var _lret0 = global::LunyEditor.UnityEditor.Build.Content.LuaWriteResult.Bind(_ret0);
                        var _retCount = _context.Return(_lret0);
                        return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                    }
                }
            }
            throw new global::Lua.LuaRuntimeException(_context.Thread, $"{"WriteSceneSerializedFile"}: invalid argument #{_lastArgPos}: {_lastArg} ({_lastArg.Type}), expected: {_expectedType.FullName}", 2);
        });
        private static readonly global::Lua.LuaFunction _LuaContentBuildInterface_WriteSerializedFile = new global::Lua.LuaFunction("WriteSerializedFile", (_context, _) =>
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
                _lastArgPos = 1; _expectedType = typeof(global::LunyEditor.UnityEditor.Build.Content.LuaWriteParameters);
                if (_arg1.TryRead<global::LunyEditor.UnityEditor.Build.Content.LuaWriteParameters>(out var _p1_UnityEditor_Build_Content_WriteParameters))
                {
                    if (_argCount == 2)
                    {
                        var outputFolder = _p0_System_String;
                        var parameters = _p1_UnityEditor_Build_Content_WriteParameters.Value;
                        var _ret0 = global::UnityEditor.Build.Content.ContentBuildInterface.WriteSerializedFile(outputFolder, parameters);
                        var _lret0 = global::LunyEditor.UnityEditor.Build.Content.LuaWriteResult.Bind(_ret0);
                        var _retCount = _context.Return(_lret0);
                        return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                    }
                }
            }
            throw new global::Lua.LuaRuntimeException(_context.Thread, $"{"WriteSerializedFile"}: invalid argument #{_lastArgPos}: {_lastArg} ({_lastArg.Type}), expected: {_expectedType.FullName}", 2);
        });
        private static readonly global::Lua.LuaFunction __index = new(global::Lua.Runtime.Metamethods.Index, (_context, _) =>
        {
            var _this = _context.GetArgument<LuaContentBuildInterfaceType>(0);
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
            var _this = _context.GetArgument<LuaContentBuildInterfaceType>(0);
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
                case "ArchiveAndCompress": _value = _LuaContentBuildInterface_ArchiveAndCompress; return true;
                case "CalculateBuildUsageTags": _value = _LuaContentBuildInterface_CalculateBuildUsageTags; return true;
                case "CalculatePlayerDependenciesForGameManagers": _value = _LuaContentBuildInterface_CalculatePlayerDependenciesForGameManagers; return true;
                case "CalculatePlayerDependenciesForScene": _value = _LuaContentBuildInterface_CalculatePlayerDependenciesForScene; return true;
                case "CalculatePlayerSerializationHashForType": _value = _LuaContentBuildInterface_CalculatePlayerSerializationHashForType; return true;
                case "GenerateAssetBundleBuilds": _value = _LuaContentBuildInterface_GenerateAssetBundleBuilds; return true;
                case "GetGlobalUsageFromActiveScene": _value = _LuaContentBuildInterface_GetGlobalUsageFromActiveScene; return true;
                case "GetGlobalUsageFromGraphicsSettings": _value = _LuaContentBuildInterface_GetGlobalUsageFromGraphicsSettings; return true;
                case "GetPlayerAssetRepresentations": _value = _LuaContentBuildInterface_GetPlayerAssetRepresentations; return true;
                case "GetPlayerDependenciesForObject": _value = _LuaContentBuildInterface_GetPlayerDependenciesForObject; return true;
                case "GetPlayerDependenciesForObjects": _value = _LuaContentBuildInterface_GetPlayerDependenciesForObjects; return true;
                case "GetPlayerObjectIdentifiersInAsset": _value = _LuaContentBuildInterface_GetPlayerObjectIdentifiersInAsset; return true;
                case "GetPlayerObjectIdentifiersInSerializedFile": _value = _LuaContentBuildInterface_GetPlayerObjectIdentifiersInSerializedFile; return true;
                case "GetTypeForObject": _value = _LuaContentBuildInterface_GetTypeForObject; return true;
                case "GetTypeForObjects": _value = _LuaContentBuildInterface_GetTypeForObjects; return true;
                case "GetTypesForObject": _value = _LuaContentBuildInterface_GetTypesForObject; return true;
                case "ObjectIsSupportedInBuild": _value = _LuaContentBuildInterface_ObjectIsSupportedInBuild; return true;
                case "StartProfileCapture": _value = _LuaContentBuildInterface_StartProfileCapture; return true;
                case "StopProfileCapture": _value = _LuaContentBuildInterface_StopProfileCapture; return true;
                case "WriteGameManagersSerializedFile": _value = _LuaContentBuildInterface_WriteGameManagersSerializedFile; return true;
                case "WriteSceneSerializedFile": _value = _LuaContentBuildInterface_WriteSceneSerializedFile; return true;
                case "WriteSerializedFile": _value = _LuaContentBuildInterface_WriteSerializedFile; return true;
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
