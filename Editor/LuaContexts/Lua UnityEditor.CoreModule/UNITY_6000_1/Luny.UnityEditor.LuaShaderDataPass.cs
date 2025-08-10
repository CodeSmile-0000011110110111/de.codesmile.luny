
// --------------------------------------------------------------
// GENERATED FILE ----> DO NOT EDIT <---- CHANGES WILL BE LOST !!
// --------------------------------------------------------------

#if UNITY_6000_1_OR_NEWER && !(UNITY_6000_2_OR_NEWER)
#pragma warning disable 0109, 0162, 0168, 0219
using Luny;

namespace Luny.UnityEditor
{
    public sealed class LuaShaderDataPass : global::Luny.ILuaObject<global::UnityEditor.ShaderData.Pass>
    {
        public new static global::Lua.LuaValue Bind(global::UnityEditor.ShaderData.Pass instance) => new LuaShaderDataPass(instance);
        public new static global::Lua.LuaValue Bind(global::System.Object instance) => Bind((global::UnityEditor.ShaderData.Pass)instance);
        public new static global::Lua.LuaValue Bind(global::System.Collections.Generic.IList<global::UnityEditor.ShaderData.Pass> instances) =>
            new global::Luny.LuaList<global::UnityEditor.ShaderData.Pass>(instances);
        public new static global::Lua.LuaValue Bind(global::System.Collections.Generic.IList<global::System.Object> instances) =>
            new global::Luny.LuaList<global::UnityEditor.ShaderData.Pass>(instances);
        private LuaShaderDataPass(global::UnityEditor.ShaderData.Pass instance) => m_Instance = instance;
        public static implicit operator global::Lua.LuaValue(LuaShaderDataPass value) => new(value);
        private global::UnityEditor.ShaderData.Pass m_Instance;
        public global::UnityEditor.ShaderData.Pass Instance => m_Instance;
        public new global::System.Type BindType => typeof(global::UnityEditor.ShaderData.Pass);
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

        private static readonly global::Lua.LuaFunction _LuaShaderDataPass_CompileVariant = new global::Lua.LuaFunction("CompileVariant", (_context, _) =>
        {
            global::Lua.LuaValue _lastArg = default;
            global::System.Int32 _lastArgPos = default;
            global::System.Type _expectedType = default;
            var _argCount = _context.ArgumentCount;
            var _this = _context.GetArgument<LuaShaderDataPass>(0);
            var _arg0 = _lastArg = _argCount > 1 ? _context.GetArgument(1) : global::Lua.LuaValue.Nil;
            _lastArgPos = 0; _expectedType = typeof(global::UnityEditor.Rendering.ShaderType);
            if (_arg0.TryRead<global::UnityEditor.Rendering.ShaderType>(out var _p0_UnityEditor_Rendering_ShaderType))
            {
                var _arg1 = _lastArg = _argCount > 2 ? _context.GetArgument(2) : global::Lua.LuaValue.Nil;
                _lastArgPos = 1; _expectedType = typeof(global::System.String[]);
                if (_arg1.TryReadArray<global::System.String>(out var _p1_System_StringArray))
                {
                    var _arg2 = _lastArg = _argCount > 3 ? _context.GetArgument(3) : global::Lua.LuaValue.Nil;
                    _lastArgPos = 2; _expectedType = typeof(global::UnityEditor.Rendering.ShaderCompilerPlatform);
                    if (_arg2.TryRead<global::UnityEditor.Rendering.ShaderCompilerPlatform>(out var _p2_UnityEditor_Rendering_ShaderCompilerPlatform))
                    {
                        var _arg3 = _lastArg = _argCount > 4 ? _context.GetArgument(4) : global::Lua.LuaValue.Nil;
                        _lastArgPos = 3; _expectedType = typeof(global::UnityEditor.BuildTarget);
                        if (_arg3.TryRead<global::UnityEditor.BuildTarget>(out var _p3_UnityEditor_BuildTarget))
                        {
                            if (_argCount == 5)
                            {
                                var shaderType = _p0_UnityEditor_Rendering_ShaderType;
                                var keywords = _p1_System_StringArray;
                                var shaderCompilerPlatform = _p2_UnityEditor_Rendering_ShaderCompilerPlatform;
                                var buildTarget = _p3_UnityEditor_BuildTarget;
                                var _ret0 = _this.Instance.CompileVariant(shaderType, keywords, shaderCompilerPlatform, buildTarget);
                                var _lret0 = global::Luny.UnityEditor.LuaShaderDataVariantCompileInfo.Bind(_ret0);
                                var _retCount = _context.Return(_lret0);
                                return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                            }
                            var _arg4 = _lastArg = _argCount > 5 ? _context.GetArgument(5) : global::Lua.LuaValue.Nil;
                            _lastArgPos = 4; _expectedType = typeof(global::System.Boolean);
                            if (_arg4.TryRead<global::System.Boolean>(out var _p4_System_Boolean))
                            {
                                if (_argCount == 6)
                                {
                                    var shaderType = _p0_UnityEditor_Rendering_ShaderType;
                                    var keywords = _p1_System_StringArray;
                                    var shaderCompilerPlatform = _p2_UnityEditor_Rendering_ShaderCompilerPlatform;
                                    var buildTarget = _p3_UnityEditor_BuildTarget;
                                    var forExternalTool = _p4_System_Boolean;
                                    var _ret0 = _this.Instance.CompileVariant(shaderType, keywords, shaderCompilerPlatform, buildTarget, forExternalTool);
                                    var _lret0 = global::Luny.UnityEditor.LuaShaderDataVariantCompileInfo.Bind(_ret0);
                                    var _retCount = _context.Return(_lret0);
                                    return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                                }
                            }
                            _lastArgPos = 4; _expectedType = typeof(global::UnityEngine.Rendering.GraphicsTier);
                            if (_arg4.TryRead<global::UnityEngine.Rendering.GraphicsTier>(out var _p4_UnityEngine_Rendering_GraphicsTier))
                            {
                                if (_argCount == 6)
                                {
                                    var shaderType = _p0_UnityEditor_Rendering_ShaderType;
                                    var keywords = _p1_System_StringArray;
                                    var shaderCompilerPlatform = _p2_UnityEditor_Rendering_ShaderCompilerPlatform;
                                    var buildTarget = _p3_UnityEditor_BuildTarget;
                                    var tier = _p4_UnityEngine_Rendering_GraphicsTier;
                                    var _ret0 = _this.Instance.CompileVariant(shaderType, keywords, shaderCompilerPlatform, buildTarget, tier);
                                    var _lret0 = global::Luny.UnityEditor.LuaShaderDataVariantCompileInfo.Bind(_ret0);
                                    var _retCount = _context.Return(_lret0);
                                    return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                                }
                                var _arg5 = _lastArg = _argCount > 6 ? _context.GetArgument(6) : global::Lua.LuaValue.Nil;
                                _lastArgPos = 5; _expectedType = typeof(global::System.Boolean);
                                if (_arg5.TryRead<global::System.Boolean>(out var _p5_System_Boolean))
                                {
                                    if (_argCount == 7)
                                    {
                                        var shaderType = _p0_UnityEditor_Rendering_ShaderType;
                                        var keywords = _p1_System_StringArray;
                                        var shaderCompilerPlatform = _p2_UnityEditor_Rendering_ShaderCompilerPlatform;
                                        var buildTarget = _p3_UnityEditor_BuildTarget;
                                        var tier = _p4_UnityEngine_Rendering_GraphicsTier;
                                        var forExternalTool = _p5_System_Boolean;
                                        var _ret0 = _this.Instance.CompileVariant(shaderType, keywords, shaderCompilerPlatform, buildTarget, tier, forExternalTool);
                                        var _lret0 = global::Luny.UnityEditor.LuaShaderDataVariantCompileInfo.Bind(_ret0);
                                        var _retCount = _context.Return(_lret0);
                                        return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                                    }
                                }
                            }
                            _lastArgPos = 4; _expectedType = typeof(global::UnityEngine.Rendering.BuiltinShaderDefine[]);
                            if (_arg4.TryReadArray<global::UnityEngine.Rendering.BuiltinShaderDefine>(out var _p4_UnityEngine_Rendering_BuiltinShaderDefineArray))
                            {
                                if (_argCount == 6)
                                {
                                    var shaderType = _p0_UnityEditor_Rendering_ShaderType;
                                    var keywords = _p1_System_StringArray;
                                    var shaderCompilerPlatform = _p2_UnityEditor_Rendering_ShaderCompilerPlatform;
                                    var buildTarget = _p3_UnityEditor_BuildTarget;
                                    var platformKeywords = _p4_UnityEngine_Rendering_BuiltinShaderDefineArray;
                                    var _ret0 = _this.Instance.CompileVariant(shaderType, keywords, shaderCompilerPlatform, buildTarget, platformKeywords);
                                    var _lret0 = global::Luny.UnityEditor.LuaShaderDataVariantCompileInfo.Bind(_ret0);
                                    var _retCount = _context.Return(_lret0);
                                    return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                                }
                                var _arg5 = _lastArg = _argCount > 6 ? _context.GetArgument(6) : global::Lua.LuaValue.Nil;
                                _lastArgPos = 5; _expectedType = typeof(global::System.Boolean);
                                if (_arg5.TryRead<global::System.Boolean>(out var _p5_System_Boolean))
                                {
                                    if (_argCount == 7)
                                    {
                                        var shaderType = _p0_UnityEditor_Rendering_ShaderType;
                                        var keywords = _p1_System_StringArray;
                                        var shaderCompilerPlatform = _p2_UnityEditor_Rendering_ShaderCompilerPlatform;
                                        var buildTarget = _p3_UnityEditor_BuildTarget;
                                        var platformKeywords = _p4_UnityEngine_Rendering_BuiltinShaderDefineArray;
                                        var forExternalTool = _p5_System_Boolean;
                                        var _ret0 = _this.Instance.CompileVariant(shaderType, keywords, shaderCompilerPlatform, buildTarget, platformKeywords, forExternalTool);
                                        var _lret0 = global::Luny.UnityEditor.LuaShaderDataVariantCompileInfo.Bind(_ret0);
                                        var _retCount = _context.Return(_lret0);
                                        return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                                    }
                                }
                                _lastArgPos = 5; _expectedType = typeof(global::UnityEngine.Rendering.GraphicsTier);
                                if (_arg5.TryRead<global::UnityEngine.Rendering.GraphicsTier>(out var _p5_UnityEngine_Rendering_GraphicsTier))
                                {
                                    if (_argCount == 7)
                                    {
                                        var shaderType = _p0_UnityEditor_Rendering_ShaderType;
                                        var keywords = _p1_System_StringArray;
                                        var shaderCompilerPlatform = _p2_UnityEditor_Rendering_ShaderCompilerPlatform;
                                        var buildTarget = _p3_UnityEditor_BuildTarget;
                                        var platformKeywords = _p4_UnityEngine_Rendering_BuiltinShaderDefineArray;
                                        var tier = _p5_UnityEngine_Rendering_GraphicsTier;
                                        var _ret0 = _this.Instance.CompileVariant(shaderType, keywords, shaderCompilerPlatform, buildTarget, platformKeywords, tier);
                                        var _lret0 = global::Luny.UnityEditor.LuaShaderDataVariantCompileInfo.Bind(_ret0);
                                        var _retCount = _context.Return(_lret0);
                                        return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                                    }
                                    var _arg6 = _lastArg = _argCount > 7 ? _context.GetArgument(7) : global::Lua.LuaValue.Nil;
                                    _lastArgPos = 6; _expectedType = typeof(global::System.Boolean);
                                    if (_arg6.TryRead<global::System.Boolean>(out var _p6_System_Boolean))
                                    {
                                        if (_argCount == 8)
                                        {
                                            var shaderType = _p0_UnityEditor_Rendering_ShaderType;
                                            var keywords = _p1_System_StringArray;
                                            var shaderCompilerPlatform = _p2_UnityEditor_Rendering_ShaderCompilerPlatform;
                                            var buildTarget = _p3_UnityEditor_BuildTarget;
                                            var platformKeywords = _p4_UnityEngine_Rendering_BuiltinShaderDefineArray;
                                            var tier = _p5_UnityEngine_Rendering_GraphicsTier;
                                            var forExternalTool = _p6_System_Boolean;
                                            var _ret0 = _this.Instance.CompileVariant(shaderType, keywords, shaderCompilerPlatform, buildTarget, platformKeywords, tier, forExternalTool);
                                            var _lret0 = global::Luny.UnityEditor.LuaShaderDataVariantCompileInfo.Bind(_ret0);
                                            var _retCount = _context.Return(_lret0);
                                            return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }
            throw new global::Lua.LuaRuntimeException(_context.Thread, $"{"CompileVariant"}: invalid argument #{_lastArgPos}: {_lastArg} ({_lastArg.Type}), expected: {_expectedType.FullName}", 2);
        });
        private static readonly global::Lua.LuaFunction _LuaShaderDataPass_FindTagValue = new global::Lua.LuaFunction("FindTagValue", (_context, _) =>
        {
            global::Lua.LuaValue _lastArg = default;
            global::System.Int32 _lastArgPos = default;
            global::System.Type _expectedType = default;
            var _argCount = _context.ArgumentCount;
            var _this = _context.GetArgument<LuaShaderDataPass>(0);
            var _arg0 = _lastArg = _argCount > 1 ? _context.GetArgument(1) : global::Lua.LuaValue.Nil;
            _lastArgPos = 0; _expectedType = typeof(global::UnityEngine.Rendering.ShaderTagId);
            if (_arg0.TryRead<global::UnityEngine.Rendering.ShaderTagId>(out var _p0_UnityEngine_Rendering_ShaderTagId))
            {
                if (_argCount == 2)
                {
                    var tagName = _p0_UnityEngine_Rendering_ShaderTagId;
                    var _ret0 = _this.Instance.FindTagValue(tagName);
                    var _factory = _context.GetObjectFactory();
                    var _lret0 = _factory.Bind(_ret0);
                    var _retCount = _context.Return(_lret0);
                    return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                }
            }
            throw new global::Lua.LuaRuntimeException(_context.Thread, $"{"FindTagValue"}: invalid argument #{_lastArgPos}: {_lastArg} ({_lastArg.Type}), expected: {_expectedType.FullName}", 2);
        });
        private static readonly global::Lua.LuaFunction _LuaShaderDataPass_HasShaderStage = new global::Lua.LuaFunction("HasShaderStage", (_context, _) =>
        {
            global::Lua.LuaValue _lastArg = default;
            global::System.Int32 _lastArgPos = default;
            global::System.Type _expectedType = default;
            var _argCount = _context.ArgumentCount;
            var _this = _context.GetArgument<LuaShaderDataPass>(0);
            var _arg0 = _lastArg = _argCount > 1 ? _context.GetArgument(1) : global::Lua.LuaValue.Nil;
            _lastArgPos = 0; _expectedType = typeof(global::UnityEditor.Rendering.ShaderType);
            if (_arg0.TryRead<global::UnityEditor.Rendering.ShaderType>(out var _p0_UnityEditor_Rendering_ShaderType))
            {
                if (_argCount == 2)
                {
                    var shaderType = _p0_UnityEditor_Rendering_ShaderType;
                    var _ret0 = _this.Instance.HasShaderStage(shaderType);
                    var _lret0 = new global::Lua.LuaValue(_ret0);
                    var _retCount = _context.Return(_lret0);
                    return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                }
            }
            throw new global::Lua.LuaRuntimeException(_context.Thread, $"{"HasShaderStage"}: invalid argument #{_lastArgPos}: {_lastArg} ({_lastArg.Type}), expected: {_expectedType.FullName}", 2);
        });
        private static readonly global::Lua.LuaFunction _LuaShaderDataPass_PreprocessVariant = new global::Lua.LuaFunction("PreprocessVariant", (_context, _) =>
        {
            global::Lua.LuaValue _lastArg = default;
            global::System.Int32 _lastArgPos = default;
            global::System.Type _expectedType = default;
            var _argCount = _context.ArgumentCount;
            var _this = _context.GetArgument<LuaShaderDataPass>(0);
            var _arg0 = _lastArg = _argCount > 1 ? _context.GetArgument(1) : global::Lua.LuaValue.Nil;
            _lastArgPos = 0; _expectedType = typeof(global::UnityEditor.Rendering.ShaderType);
            if (_arg0.TryRead<global::UnityEditor.Rendering.ShaderType>(out var _p0_UnityEditor_Rendering_ShaderType))
            {
                var _arg1 = _lastArg = _argCount > 2 ? _context.GetArgument(2) : global::Lua.LuaValue.Nil;
                _lastArgPos = 1; _expectedType = typeof(global::System.String[]);
                if (_arg1.TryReadArray<global::System.String>(out var _p1_System_StringArray))
                {
                    var _arg2 = _lastArg = _argCount > 3 ? _context.GetArgument(3) : global::Lua.LuaValue.Nil;
                    _lastArgPos = 2; _expectedType = typeof(global::UnityEditor.Rendering.ShaderCompilerPlatform);
                    if (_arg2.TryRead<global::UnityEditor.Rendering.ShaderCompilerPlatform>(out var _p2_UnityEditor_Rendering_ShaderCompilerPlatform))
                    {
                        var _arg3 = _lastArg = _argCount > 4 ? _context.GetArgument(4) : global::Lua.LuaValue.Nil;
                        _lastArgPos = 3; _expectedType = typeof(global::UnityEditor.BuildTarget);
                        if (_arg3.TryRead<global::UnityEditor.BuildTarget>(out var _p3_UnityEditor_BuildTarget))
                        {
                            var _arg4 = _lastArg = _argCount > 5 ? _context.GetArgument(5) : global::Lua.LuaValue.Nil;
                            _lastArgPos = 4; _expectedType = typeof(global::System.Boolean);
                            if (_arg4.TryRead<global::System.Boolean>(out var _p4_System_Boolean))
                            {
                                if (_argCount == 6)
                                {
                                    var shaderType = _p0_UnityEditor_Rendering_ShaderType;
                                    var keywords = _p1_System_StringArray;
                                    var shaderCompilerPlatform = _p2_UnityEditor_Rendering_ShaderCompilerPlatform;
                                    var buildTarget = _p3_UnityEditor_BuildTarget;
                                    var stripLineDirectives = _p4_System_Boolean;
                                    var _ret0 = _this.Instance.PreprocessVariant(shaderType, keywords, shaderCompilerPlatform, buildTarget, stripLineDirectives);
                                    var _lret0 = global::Luny.UnityEditor.LuaShaderDataPreprocessedVariant.Bind(_ret0);
                                    var _retCount = _context.Return(_lret0);
                                    return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                                }
                            }
                            _lastArgPos = 4; _expectedType = typeof(global::UnityEngine.Rendering.GraphicsTier);
                            if (_arg4.TryRead<global::UnityEngine.Rendering.GraphicsTier>(out var _p4_UnityEngine_Rendering_GraphicsTier))
                            {
                                var _arg5 = _lastArg = _argCount > 6 ? _context.GetArgument(6) : global::Lua.LuaValue.Nil;
                                _lastArgPos = 5; _expectedType = typeof(global::System.Boolean);
                                if (_arg5.TryRead<global::System.Boolean>(out var _p5_System_Boolean))
                                {
                                    if (_argCount == 7)
                                    {
                                        var shaderType = _p0_UnityEditor_Rendering_ShaderType;
                                        var keywords = _p1_System_StringArray;
                                        var shaderCompilerPlatform = _p2_UnityEditor_Rendering_ShaderCompilerPlatform;
                                        var buildTarget = _p3_UnityEditor_BuildTarget;
                                        var tier = _p4_UnityEngine_Rendering_GraphicsTier;
                                        var stripLineDirectives = _p5_System_Boolean;
                                        var _ret0 = _this.Instance.PreprocessVariant(shaderType, keywords, shaderCompilerPlatform, buildTarget, tier, stripLineDirectives);
                                        var _lret0 = global::Luny.UnityEditor.LuaShaderDataPreprocessedVariant.Bind(_ret0);
                                        var _retCount = _context.Return(_lret0);
                                        return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                                    }
                                }
                            }
                            _lastArgPos = 4; _expectedType = typeof(global::UnityEngine.Rendering.BuiltinShaderDefine[]);
                            if (_arg4.TryReadArray<global::UnityEngine.Rendering.BuiltinShaderDefine>(out var _p4_UnityEngine_Rendering_BuiltinShaderDefineArray))
                            {
                                var _arg5 = _lastArg = _argCount > 6 ? _context.GetArgument(6) : global::Lua.LuaValue.Nil;
                                _lastArgPos = 5; _expectedType = typeof(global::System.Boolean);
                                if (_arg5.TryRead<global::System.Boolean>(out var _p5_System_Boolean))
                                {
                                    if (_argCount == 7)
                                    {
                                        var shaderType = _p0_UnityEditor_Rendering_ShaderType;
                                        var keywords = _p1_System_StringArray;
                                        var shaderCompilerPlatform = _p2_UnityEditor_Rendering_ShaderCompilerPlatform;
                                        var buildTarget = _p3_UnityEditor_BuildTarget;
                                        var platformKeywords = _p4_UnityEngine_Rendering_BuiltinShaderDefineArray;
                                        var stripLineDirectives = _p5_System_Boolean;
                                        var _ret0 = _this.Instance.PreprocessVariant(shaderType, keywords, shaderCompilerPlatform, buildTarget, platformKeywords, stripLineDirectives);
                                        var _lret0 = global::Luny.UnityEditor.LuaShaderDataPreprocessedVariant.Bind(_ret0);
                                        var _retCount = _context.Return(_lret0);
                                        return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                                    }
                                }
                                _lastArgPos = 5; _expectedType = typeof(global::UnityEngine.Rendering.GraphicsTier);
                                if (_arg5.TryRead<global::UnityEngine.Rendering.GraphicsTier>(out var _p5_UnityEngine_Rendering_GraphicsTier))
                                {
                                    var _arg6 = _lastArg = _argCount > 7 ? _context.GetArgument(7) : global::Lua.LuaValue.Nil;
                                    _lastArgPos = 6; _expectedType = typeof(global::System.Boolean);
                                    if (_arg6.TryRead<global::System.Boolean>(out var _p6_System_Boolean))
                                    {
                                        if (_argCount == 8)
                                        {
                                            var shaderType = _p0_UnityEditor_Rendering_ShaderType;
                                            var keywords = _p1_System_StringArray;
                                            var shaderCompilerPlatform = _p2_UnityEditor_Rendering_ShaderCompilerPlatform;
                                            var buildTarget = _p3_UnityEditor_BuildTarget;
                                            var platformKeywords = _p4_UnityEngine_Rendering_BuiltinShaderDefineArray;
                                            var tier = _p5_UnityEngine_Rendering_GraphicsTier;
                                            var stripLineDirectives = _p6_System_Boolean;
                                            var _ret0 = _this.Instance.PreprocessVariant(shaderType, keywords, shaderCompilerPlatform, buildTarget, platformKeywords, tier, stripLineDirectives);
                                            var _lret0 = global::Luny.UnityEditor.LuaShaderDataPreprocessedVariant.Bind(_ret0);
                                            var _retCount = _context.Return(_lret0);
                                            return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }
            throw new global::Lua.LuaRuntimeException(_context.Thread, $"{"PreprocessVariant"}: invalid argument #{_lastArgPos}: {_lastArg} ({_lastArg.Type}), expected: {_expectedType.FullName}", 2);
        });
        private static readonly global::Lua.LuaFunction __index = new(global::Lua.Runtime.Metamethods.Index, (_context, _) =>
        {
            var _this = _context.GetArgument<LuaShaderDataPass>(0);
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
            var _this = _context.GetArgument<LuaShaderDataPass>(0);
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
                case "CompileVariant": _value = _LuaShaderDataPass_CompileVariant; return true;
                case "FindTagValue": _value = _LuaShaderDataPass_FindTagValue; return true;
                case "HasShaderStage": _value = _LuaShaderDataPass_HasShaderStage; return true;
                case "PreprocessVariant": _value = _LuaShaderDataPass_PreprocessVariant; return true;
                case "IsGrabPass": _value = new global::Lua.LuaValue(Instance.IsGrabPass); return true;
                case "Name": _value = new global::Lua.LuaValue(Instance.Name); return true;
                case "SourceCode": _value = new global::Lua.LuaValue(Instance.SourceCode); return true;
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
    public sealed class LuaShaderDataPassType : global::Luny.ILuaStatic
    {
        public static global::Lua.LuaValue Bind() => new LuaShaderDataPassType();
        private LuaShaderDataPassType() {}
        public static implicit operator global::Lua.LuaValue(LuaShaderDataPassType value) => new(value);
        public global::System.Type BindType => typeof(global::UnityEditor.ShaderData.Pass);
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

        private static readonly global::Lua.LuaFunction __index = new(global::Lua.Runtime.Metamethods.Index, (_context, _) =>
        {
            var _this = _context.GetArgument<LuaShaderDataPassType>(0);
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
            var _this = _context.GetArgument<LuaShaderDataPassType>(0);
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
