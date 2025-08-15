
// --------------------------------------------------------------
// GENERATED FILE ----> DO NOT EDIT <---- CHANGES WILL BE LOST !!
// --------------------------------------------------------------

#if UNITY_6000_0_OR_NEWER && !(UNITY_6000_1_OR_NEWER)
#pragma warning disable 0109, 0162, 0168, 0219
using Luny;

namespace LunyEditor.UnityEditor
{
    public sealed class LuaShaderUtil : global::Luny.ILuaObject<global::UnityEditor.ShaderUtil>
    {
        public new static global::Lua.LuaValue Bind(global::UnityEditor.ShaderUtil instance) => new LuaShaderUtil(instance);
        public new static global::Lua.LuaValue Bind(global::System.Object instance) => Bind((global::UnityEditor.ShaderUtil)instance);
        public new static global::Lua.LuaValue Bind(global::System.Collections.Generic.IList<global::UnityEditor.ShaderUtil> instances) =>
            new global::Luny.LuaList<global::UnityEditor.ShaderUtil>(instances);
        public new static global::Lua.LuaValue Bind(global::System.Collections.Generic.IList<global::System.Object> instances) =>
            new global::Luny.LuaList<global::UnityEditor.ShaderUtil>(instances);
        private LuaShaderUtil(global::UnityEditor.ShaderUtil instance) => m_Instance = instance;
        public static implicit operator global::Lua.LuaValue(LuaShaderUtil value) => new(value);
        private global::UnityEditor.ShaderUtil m_Instance;
        public global::UnityEditor.ShaderUtil Instance => m_Instance;
        public new global::System.Type BindType => typeof(global::UnityEditor.ShaderUtil);
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
            var _this = _context.GetArgument<LuaShaderUtil>(0);
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
            var _this = _context.GetArgument<LuaShaderUtil>(0);
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
    public sealed class LuaShaderUtilType : global::Luny.ILuaStatic
    {
        public static global::Lua.LuaValue Bind() => new LuaShaderUtilType();
        private LuaShaderUtilType() {}
        public static implicit operator global::Lua.LuaValue(LuaShaderUtilType value) => new(value);
        public global::System.Type BindType => typeof(global::UnityEditor.ShaderUtil);
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
            metatable[global::Lua.Runtime.Metamethods.Call] = _LuaShaderUtil_new;
            return metatable;
        }
        public override global::System.String ToString() => BindType.FullName;
#if UNITY_EDITOR
        [global::UnityEngine.RuntimeInitializeOnLoadMethod(global::UnityEngine.RuntimeInitializeLoadType.SubsystemRegistration)]
        private static void ResetStaticFields() => s_Metatable = null;
#endif

        private static readonly global::Lua.LuaFunction _LuaShaderUtil_new = new global::Lua.LuaFunction(".ctor", (_context, _) =>
        {
            global::Lua.LuaValue _lastArg = default;
            global::System.Int32 _lastArgPos = default;
            global::System.Type _expectedType = default;
            var _argCount = _context.ArgumentCount;
            if (_argCount == 1)
            {
                var _ret0 = new global::UnityEditor.ShaderUtil();
                var _factory = _context.GetObjectFactory();
                var _lret0 = _factory.Bind(_ret0);
                var _retCount = _context.Return(_lret0);
                return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
            }
            throw new global::Lua.LuaRuntimeException(_context.Thread, $"{".ctor"}: invalid argument #{_lastArgPos}: {_lastArg} ({_lastArg.Type}), expected: {_expectedType.FullName}", 2);
        });
        private static readonly global::Lua.LuaFunction _LuaShaderUtil_ClearCachedData = new global::Lua.LuaFunction("ClearCachedData", (_context, _) =>
        {
            global::Lua.LuaValue _lastArg = default;
            global::System.Int32 _lastArgPos = default;
            global::System.Type _expectedType = default;
            var _argCount = _context.ArgumentCount;
            var _arg0 = _lastArg = _argCount > 0 ? _context.GetArgument(0) : global::Lua.LuaValue.Nil;
            _lastArgPos = 0; _expectedType = typeof(global::Luny.UnityEngine.LuaShader);
            if (_arg0.TryRead<global::Luny.UnityEngine.LuaShader>(out var _p0_UnityEngine_Shader))
            {
                if (_argCount == 1)
                {
                    var s = _p0_UnityEngine_Shader.Instance;
                    global::UnityEditor.ShaderUtil.ClearCachedData(s);
                    var _retCount = _context.Return();
                    return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                }
            }
            throw new global::Lua.LuaRuntimeException(_context.Thread, $"{"ClearCachedData"}: invalid argument #{_lastArgPos}: {_lastArg} ({_lastArg.Type}), expected: {_expectedType.FullName}", 2);
        });
        private static readonly global::Lua.LuaFunction _LuaShaderUtil_ClearShaderMessages = new global::Lua.LuaFunction("ClearShaderMessages", (_context, _) =>
        {
            global::Lua.LuaValue _lastArg = default;
            global::System.Int32 _lastArgPos = default;
            global::System.Type _expectedType = default;
            var _argCount = _context.ArgumentCount;
            var _arg0 = _lastArg = _argCount > 0 ? _context.GetArgument(0) : global::Lua.LuaValue.Nil;
            _lastArgPos = 0; _expectedType = typeof(global::Luny.UnityEngine.LuaShader);
            if (_arg0.TryRead<global::Luny.UnityEngine.LuaShader>(out var _p0_UnityEngine_Shader))
            {
                if (_argCount == 1)
                {
                    var s = _p0_UnityEngine_Shader.Instance;
                    global::UnityEditor.ShaderUtil.ClearShaderMessages(s);
                    var _retCount = _context.Return();
                    return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                }
            }
            throw new global::Lua.LuaRuntimeException(_context.Thread, $"{"ClearShaderMessages"}: invalid argument #{_lastArgPos}: {_lastArg} ({_lastArg.Type}), expected: {_expectedType.FullName}", 2);
        });
        private static readonly global::Lua.LuaFunction _LuaShaderUtil_CompilePass = new global::Lua.LuaFunction("CompilePass", (_context, _) =>
        {
            global::Lua.LuaValue _lastArg = default;
            global::System.Int32 _lastArgPos = default;
            global::System.Type _expectedType = default;
            var _argCount = _context.ArgumentCount;
            var _arg0 = _lastArg = _argCount > 0 ? _context.GetArgument(0) : global::Lua.LuaValue.Nil;
            _lastArgPos = 0; _expectedType = typeof(global::Luny.UnityEngine.LuaMaterial);
            if (_arg0.TryRead<global::Luny.UnityEngine.LuaMaterial>(out var _p0_UnityEngine_Material))
            {
                var _arg1 = _lastArg = _argCount > 1 ? _context.GetArgument(1) : global::Lua.LuaValue.Nil;
                _lastArgPos = 1; _expectedType = typeof(global::System.Int32);
                if (_arg1.TryRead<global::System.Int32>(out var _p1_System_Int32))
                {
                    if (_argCount == 2)
                    {
                        var material = _p0_UnityEngine_Material.Instance;
                        var pass = _p1_System_Int32;
                        global::UnityEditor.ShaderUtil.CompilePass(material, pass);
                        var _retCount = _context.Return();
                        return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                    }
                    var _arg2 = _lastArg = _argCount > 2 ? _context.GetArgument(2) : global::Lua.LuaValue.Nil;
                    _lastArgPos = 2; _expectedType = typeof(global::System.Boolean);
                    var _p2_System_Boolean = _arg2.ReadValue<global::System.Boolean>((global::System.Boolean)false);
                    {
                        if (_argCount == 3)
                        {
                            var material = _p0_UnityEngine_Material.Instance;
                            var pass = _p1_System_Int32;
                            var forceSync = _p2_System_Boolean;
                            global::UnityEditor.ShaderUtil.CompilePass(material, pass, forceSync);
                            var _retCount = _context.Return();
                            return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                        }
                    }
                }
            }
            throw new global::Lua.LuaRuntimeException(_context.Thread, $"{"CompilePass"}: invalid argument #{_lastArgPos}: {_lastArg} ({_lastArg.Type}), expected: {_expectedType.FullName}", 2);
        });
        private static readonly global::Lua.LuaFunction _LuaShaderUtil_CreateComputeShaderAsset = new global::Lua.LuaFunction("CreateComputeShaderAsset", (_context, _) =>
        {
            global::Lua.LuaValue _lastArg = default;
            global::System.Int32 _lastArgPos = default;
            global::System.Type _expectedType = default;
            var _argCount = _context.ArgumentCount;
            var _arg0 = _lastArg = _argCount > 0 ? _context.GetArgument(0) : global::Lua.LuaValue.Nil;
            _lastArgPos = 0; _expectedType = typeof(global::LunyEditor.UnityEditor.AssetImporters.LuaAssetImportContext);
            if (_arg0.TryRead<global::LunyEditor.UnityEditor.AssetImporters.LuaAssetImportContext>(out var _p0_UnityEditor_AssetImporters_AssetImportContext))
            {
                var _arg1 = _lastArg = _argCount > 1 ? _context.GetArgument(1) : global::Lua.LuaValue.Nil;
                _lastArgPos = 1; _expectedType = typeof(global::System.String);
                if (_arg1.TryRead<global::System.String>(out var _p1_System_String))
                {
                    if (_argCount == 2)
                    {
                        var context = _p0_UnityEditor_AssetImporters_AssetImportContext.Instance;
                        var source = _p1_System_String;
                        var _ret0 = global::UnityEditor.ShaderUtil.CreateComputeShaderAsset(context, source);
                        var _factory = _context.GetObjectFactory();
                        var _lret0 = _factory.Bind(_ret0);
                        var _retCount = _context.Return(_lret0);
                        return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                    }
                }
            }
            throw new global::Lua.LuaRuntimeException(_context.Thread, $"{"CreateComputeShaderAsset"}: invalid argument #{_lastArgPos}: {_lastArg} ({_lastArg.Type}), expected: {_expectedType.FullName}", 2);
        });
        private static readonly global::Lua.LuaFunction _LuaShaderUtil_CreateRayTracingShaderAsset = new global::Lua.LuaFunction("CreateRayTracingShaderAsset", (_context, _) =>
        {
            global::Lua.LuaValue _lastArg = default;
            global::System.Int32 _lastArgPos = default;
            global::System.Type _expectedType = default;
            var _argCount = _context.ArgumentCount;
            var _arg0 = _lastArg = _argCount > 0 ? _context.GetArgument(0) : global::Lua.LuaValue.Nil;
            _lastArgPos = 0; _expectedType = typeof(global::LunyEditor.UnityEditor.AssetImporters.LuaAssetImportContext);
            if (_arg0.TryRead<global::LunyEditor.UnityEditor.AssetImporters.LuaAssetImportContext>(out var _p0_UnityEditor_AssetImporters_AssetImportContext))
            {
                var _arg1 = _lastArg = _argCount > 1 ? _context.GetArgument(1) : global::Lua.LuaValue.Nil;
                _lastArgPos = 1; _expectedType = typeof(global::System.String);
                if (_arg1.TryRead<global::System.String>(out var _p1_System_String))
                {
                    if (_argCount == 2)
                    {
                        var context = _p0_UnityEditor_AssetImporters_AssetImportContext.Instance;
                        var source = _p1_System_String;
                        var _ret0 = global::UnityEditor.ShaderUtil.CreateRayTracingShaderAsset(context, source);
                        var _factory = _context.GetObjectFactory();
                        var _lret0 = _factory.Bind(_ret0);
                        var _retCount = _context.Return(_lret0);
                        return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                    }
                }
            }
            throw new global::Lua.LuaRuntimeException(_context.Thread, $"{"CreateRayTracingShaderAsset"}: invalid argument #{_lastArgPos}: {_lastArg} ({_lastArg.Type}), expected: {_expectedType.FullName}", 2);
        });
        private static readonly global::Lua.LuaFunction _LuaShaderUtil_CreateShaderAsset = new global::Lua.LuaFunction("CreateShaderAsset", (_context, _) =>
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
                    var source = _p0_System_String;
                    var _ret0 = global::UnityEditor.ShaderUtil.CreateShaderAsset(source);
                    var _factory = _context.GetObjectFactory();
                    var _lret0 = _factory.Bind(_ret0);
                    var _retCount = _context.Return(_lret0);
                    return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                }
                var _arg1 = _lastArg = _argCount > 1 ? _context.GetArgument(1) : global::Lua.LuaValue.Nil;
                _lastArgPos = 1; _expectedType = typeof(global::System.Boolean);
                if (_arg1.TryRead<global::System.Boolean>(out var _p1_System_Boolean))
                {
                    if (_argCount == 2)
                    {
                        var source = _p0_System_String;
                        var compileInitialShaderVariants = _p1_System_Boolean;
                        var _ret0 = global::UnityEditor.ShaderUtil.CreateShaderAsset(source, compileInitialShaderVariants);
                        var _factory = _context.GetObjectFactory();
                        var _lret0 = _factory.Bind(_ret0);
                        var _retCount = _context.Return(_lret0);
                        return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                    }
                }
            }
            _lastArgPos = 0; _expectedType = typeof(global::LunyEditor.UnityEditor.AssetImporters.LuaAssetImportContext);
            if (_arg0.TryRead<global::LunyEditor.UnityEditor.AssetImporters.LuaAssetImportContext>(out var _p0_UnityEditor_AssetImporters_AssetImportContext))
            {
                var _arg1 = _lastArg = _argCount > 1 ? _context.GetArgument(1) : global::Lua.LuaValue.Nil;
                _lastArgPos = 1; _expectedType = typeof(global::System.String);
                if (_arg1.TryRead<global::System.String>(out var _p1_System_String))
                {
                    var _arg2 = _lastArg = _argCount > 2 ? _context.GetArgument(2) : global::Lua.LuaValue.Nil;
                    _lastArgPos = 2; _expectedType = typeof(global::System.Boolean);
                    if (_arg2.TryRead<global::System.Boolean>(out var _p2_System_Boolean))
                    {
                        if (_argCount == 3)
                        {
                            var context = _p0_UnityEditor_AssetImporters_AssetImportContext.Instance;
                            var source = _p1_System_String;
                            var compileInitialShaderVariants = _p2_System_Boolean;
                            var _ret0 = global::UnityEditor.ShaderUtil.CreateShaderAsset(context, source, compileInitialShaderVariants);
                            var _factory = _context.GetObjectFactory();
                            var _lret0 = _factory.Bind(_ret0);
                            var _retCount = _context.Return(_lret0);
                            return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                        }
                    }
                }
            }
            throw new global::Lua.LuaRuntimeException(_context.Thread, $"{"CreateShaderAsset"}: invalid argument #{_lastArgPos}: {_lastArg} ({_lastArg.Type}), expected: {_expectedType.FullName}", 2);
        });
        private static readonly global::Lua.LuaFunction _LuaShaderUtil_GetAllShaderInfo = new global::Lua.LuaFunction("GetAllShaderInfo", (_context, _) =>
        {
            global::Lua.LuaValue _lastArg = default;
            global::System.Int32 _lastArgPos = default;
            global::System.Type _expectedType = default;
            var _argCount = _context.ArgumentCount;
            if (_argCount == 0)
            {
                var _ret0 = global::UnityEditor.ShaderUtil.GetAllShaderInfo();
                var _factory = _context.GetObjectFactory();
                var _lret0 = _factory.Bind(_ret0);
                var _retCount = _context.Return(_lret0);
                return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
            }
            throw new global::Lua.LuaRuntimeException(_context.Thread, $"{"GetAllShaderInfo"}: invalid argument #{_lastArgPos}: {_lastArg} ({_lastArg.Type}), expected: {_expectedType.FullName}", 2);
        });
        private static readonly global::Lua.LuaFunction _LuaShaderUtil_GetCallableShaderCount = new global::Lua.LuaFunction("GetCallableShaderCount", (_context, _) =>
        {
            global::Lua.LuaValue _lastArg = default;
            global::System.Int32 _lastArgPos = default;
            global::System.Type _expectedType = default;
            var _argCount = _context.ArgumentCount;
            var _arg0 = _lastArg = _argCount > 0 ? _context.GetArgument(0) : global::Lua.LuaValue.Nil;
            _lastArgPos = 0; _expectedType = typeof(global::Luny.UnityEngine.Rendering.LuaRayTracingShader);
            if (_arg0.TryRead<global::Luny.UnityEngine.Rendering.LuaRayTracingShader>(out var _p0_UnityEngine_Rendering_RayTracingShader))
            {
                if (_argCount == 1)
                {
                    var s = _p0_UnityEngine_Rendering_RayTracingShader.Instance;
                    var _ret0 = global::UnityEditor.ShaderUtil.GetCallableShaderCount(s);
                    var _lret0 = new global::Lua.LuaValue(_ret0);
                    var _retCount = _context.Return(_lret0);
                    return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                }
            }
            throw new global::Lua.LuaRuntimeException(_context.Thread, $"{"GetCallableShaderCount"}: invalid argument #{_lastArgPos}: {_lastArg} ({_lastArg.Type}), expected: {_expectedType.FullName}", 2);
        });
        private static readonly global::Lua.LuaFunction _LuaShaderUtil_GetCallableShaderName = new global::Lua.LuaFunction("GetCallableShaderName", (_context, _) =>
        {
            global::Lua.LuaValue _lastArg = default;
            global::System.Int32 _lastArgPos = default;
            global::System.Type _expectedType = default;
            var _argCount = _context.ArgumentCount;
            var _arg0 = _lastArg = _argCount > 0 ? _context.GetArgument(0) : global::Lua.LuaValue.Nil;
            _lastArgPos = 0; _expectedType = typeof(global::Luny.UnityEngine.Rendering.LuaRayTracingShader);
            if (_arg0.TryRead<global::Luny.UnityEngine.Rendering.LuaRayTracingShader>(out var _p0_UnityEngine_Rendering_RayTracingShader))
            {
                var _arg1 = _lastArg = _argCount > 1 ? _context.GetArgument(1) : global::Lua.LuaValue.Nil;
                _lastArgPos = 1; _expectedType = typeof(global::System.Int32);
                if (_arg1.TryRead<global::System.Int32>(out var _p1_System_Int32))
                {
                    if (_argCount == 2)
                    {
                        var s = _p0_UnityEngine_Rendering_RayTracingShader.Instance;
                        var shaderIndex = _p1_System_Int32;
                        var _ret0 = global::UnityEditor.ShaderUtil.GetCallableShaderName(s, shaderIndex);
                        var _lret0 = new global::Lua.LuaValue(_ret0);
                        var _retCount = _context.Return(_lret0);
                        return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                    }
                }
            }
            throw new global::Lua.LuaRuntimeException(_context.Thread, $"{"GetCallableShaderName"}: invalid argument #{_lastArgPos}: {_lastArg} ({_lastArg.Type}), expected: {_expectedType.FullName}", 2);
        });
        private static readonly global::Lua.LuaFunction _LuaShaderUtil_GetCallableShaderParamSize = new global::Lua.LuaFunction("GetCallableShaderParamSize", (_context, _) =>
        {
            global::Lua.LuaValue _lastArg = default;
            global::System.Int32 _lastArgPos = default;
            global::System.Type _expectedType = default;
            var _argCount = _context.ArgumentCount;
            var _arg0 = _lastArg = _argCount > 0 ? _context.GetArgument(0) : global::Lua.LuaValue.Nil;
            _lastArgPos = 0; _expectedType = typeof(global::Luny.UnityEngine.Rendering.LuaRayTracingShader);
            if (_arg0.TryRead<global::Luny.UnityEngine.Rendering.LuaRayTracingShader>(out var _p0_UnityEngine_Rendering_RayTracingShader))
            {
                var _arg1 = _lastArg = _argCount > 1 ? _context.GetArgument(1) : global::Lua.LuaValue.Nil;
                _lastArgPos = 1; _expectedType = typeof(global::System.Int32);
                if (_arg1.TryRead<global::System.Int32>(out var _p1_System_Int32))
                {
                    if (_argCount == 2)
                    {
                        var s = _p0_UnityEngine_Rendering_RayTracingShader.Instance;
                        var shaderIndex = _p1_System_Int32;
                        var _ret0 = global::UnityEditor.ShaderUtil.GetCallableShaderParamSize(s, shaderIndex);
                        var _lret0 = new global::Lua.LuaValue(_ret0);
                        var _retCount = _context.Return(_lret0);
                        return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                    }
                }
            }
            throw new global::Lua.LuaRuntimeException(_context.Thread, $"{"GetCallableShaderParamSize"}: invalid argument #{_lastArgPos}: {_lastArg} ({_lastArg.Type}), expected: {_expectedType.FullName}", 2);
        });
        private static readonly global::Lua.LuaFunction _LuaShaderUtil_GetComputeShaderMessageCount = new global::Lua.LuaFunction("GetComputeShaderMessageCount", (_context, _) =>
        {
            global::Lua.LuaValue _lastArg = default;
            global::System.Int32 _lastArgPos = default;
            global::System.Type _expectedType = default;
            var _argCount = _context.ArgumentCount;
            var _arg0 = _lastArg = _argCount > 0 ? _context.GetArgument(0) : global::Lua.LuaValue.Nil;
            _lastArgPos = 0; _expectedType = typeof(global::Luny.UnityEngine.LuaComputeShader);
            if (_arg0.TryRead<global::Luny.UnityEngine.LuaComputeShader>(out var _p0_UnityEngine_ComputeShader))
            {
                if (_argCount == 1)
                {
                    var s = _p0_UnityEngine_ComputeShader.Instance;
                    var _ret0 = global::UnityEditor.ShaderUtil.GetComputeShaderMessageCount(s);
                    var _lret0 = new global::Lua.LuaValue(_ret0);
                    var _retCount = _context.Return(_lret0);
                    return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                }
            }
            throw new global::Lua.LuaRuntimeException(_context.Thread, $"{"GetComputeShaderMessageCount"}: invalid argument #{_lastArgPos}: {_lastArg} ({_lastArg.Type}), expected: {_expectedType.FullName}", 2);
        });
        private static readonly global::Lua.LuaFunction _LuaShaderUtil_GetComputeShaderMessages = new global::Lua.LuaFunction("GetComputeShaderMessages", (_context, _) =>
        {
            global::Lua.LuaValue _lastArg = default;
            global::System.Int32 _lastArgPos = default;
            global::System.Type _expectedType = default;
            var _argCount = _context.ArgumentCount;
            var _arg0 = _lastArg = _argCount > 0 ? _context.GetArgument(0) : global::Lua.LuaValue.Nil;
            _lastArgPos = 0; _expectedType = typeof(global::Luny.UnityEngine.LuaComputeShader);
            if (_arg0.TryRead<global::Luny.UnityEngine.LuaComputeShader>(out var _p0_UnityEngine_ComputeShader))
            {
                if (_argCount == 1)
                {
                    var s = _p0_UnityEngine_ComputeShader.Instance;
                    var _ret0 = global::UnityEditor.ShaderUtil.GetComputeShaderMessages(s);
                    var _factory = _context.GetObjectFactory();
                    var _lret0 = _factory.Bind(_ret0);
                    var _retCount = _context.Return(_lret0);
                    return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                }
            }
            throw new global::Lua.LuaRuntimeException(_context.Thread, $"{"GetComputeShaderMessages"}: invalid argument #{_lastArgPos}: {_lastArg} ({_lastArg.Type}), expected: {_expectedType.FullName}", 2);
        });
        private static readonly global::Lua.LuaFunction _LuaShaderUtil_GetCurrentCustomEditor = new global::Lua.LuaFunction("GetCurrentCustomEditor", (_context, _) =>
        {
            global::Lua.LuaValue _lastArg = default;
            global::System.Int32 _lastArgPos = default;
            global::System.Type _expectedType = default;
            var _argCount = _context.ArgumentCount;
            var _arg0 = _lastArg = _argCount > 0 ? _context.GetArgument(0) : global::Lua.LuaValue.Nil;
            _lastArgPos = 0; _expectedType = typeof(global::Luny.UnityEngine.LuaShader);
            if (_arg0.TryRead<global::Luny.UnityEngine.LuaShader>(out var _p0_UnityEngine_Shader))
            {
                if (_argCount == 1)
                {
                    var shader = _p0_UnityEngine_Shader.Instance;
                    var _ret0 = global::UnityEditor.ShaderUtil.GetCurrentCustomEditor(shader);
                    var _lret0 = new global::Lua.LuaValue(_ret0);
                    var _retCount = _context.Return(_lret0);
                    return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                }
            }
            throw new global::Lua.LuaRuntimeException(_context.Thread, $"{"GetCurrentCustomEditor"}: invalid argument #{_lastArgPos}: {_lastArg} ({_lastArg.Type}), expected: {_expectedType.FullName}", 2);
        });
        private static readonly global::Lua.LuaFunction _LuaShaderUtil_GetCustomEditorForRenderPipeline = new global::Lua.LuaFunction("GetCustomEditorForRenderPipeline", (_context, _) =>
        {
            global::Lua.LuaValue _lastArg = default;
            global::System.Int32 _lastArgPos = default;
            global::System.Type _expectedType = default;
            var _argCount = _context.ArgumentCount;
            var _arg0 = _lastArg = _argCount > 0 ? _context.GetArgument(0) : global::Lua.LuaValue.Nil;
            _lastArgPos = 0; _expectedType = typeof(global::Luny.UnityEngine.LuaShader);
            if (_arg0.TryRead<global::Luny.UnityEngine.LuaShader>(out var _p0_UnityEngine_Shader))
            {
                var _arg1 = _lastArg = _argCount > 1 ? _context.GetArgument(1) : global::Lua.LuaValue.Nil;
                _lastArgPos = 1; _expectedType = typeof(global::System.String);
                if (_arg1.TryRead<global::System.String>(out var _p1_System_String))
                {
                    if (_argCount == 2)
                    {
                        var shader = _p0_UnityEngine_Shader.Instance;
                        var renderPipelineType = _p1_System_String;
                        var _ret0 = global::UnityEditor.ShaderUtil.GetCustomEditorForRenderPipeline(shader, renderPipelineType);
                        var _lret0 = new global::Lua.LuaValue(_ret0);
                        var _retCount = _context.Return(_lret0);
                        return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                    }
                }
                _lastArgPos = 1; _expectedType = typeof(global::Luny.ILuaBindType);
                if (_arg1.TryRead<global::Luny.ILuaBindType>(out var _p1_System_Type))
                {
                    if (_argCount == 2)
                    {
                        var shader = _p0_UnityEngine_Shader.Instance;
                        var renderPipelineType = _p1_System_Type.BindType;
                        var _ret0 = global::UnityEditor.ShaderUtil.GetCustomEditorForRenderPipeline(shader, renderPipelineType);
                        var _lret0 = new global::Lua.LuaValue(_ret0);
                        var _retCount = _context.Return(_lret0);
                        return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                    }
                }
            }
            throw new global::Lua.LuaRuntimeException(_context.Thread, $"{"GetCustomEditorForRenderPipeline"}: invalid argument #{_lastArgPos}: {_lastArg} ({_lastArg.Type}), expected: {_expectedType.FullName}", 2);
        });
        private static readonly global::Lua.LuaFunction _LuaShaderUtil_GetMissShaderCount = new global::Lua.LuaFunction("GetMissShaderCount", (_context, _) =>
        {
            global::Lua.LuaValue _lastArg = default;
            global::System.Int32 _lastArgPos = default;
            global::System.Type _expectedType = default;
            var _argCount = _context.ArgumentCount;
            var _arg0 = _lastArg = _argCount > 0 ? _context.GetArgument(0) : global::Lua.LuaValue.Nil;
            _lastArgPos = 0; _expectedType = typeof(global::Luny.UnityEngine.Rendering.LuaRayTracingShader);
            if (_arg0.TryRead<global::Luny.UnityEngine.Rendering.LuaRayTracingShader>(out var _p0_UnityEngine_Rendering_RayTracingShader))
            {
                if (_argCount == 1)
                {
                    var s = _p0_UnityEngine_Rendering_RayTracingShader.Instance;
                    var _ret0 = global::UnityEditor.ShaderUtil.GetMissShaderCount(s);
                    var _lret0 = new global::Lua.LuaValue(_ret0);
                    var _retCount = _context.Return(_lret0);
                    return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                }
            }
            throw new global::Lua.LuaRuntimeException(_context.Thread, $"{"GetMissShaderCount"}: invalid argument #{_lastArgPos}: {_lastArg} ({_lastArg.Type}), expected: {_expectedType.FullName}", 2);
        });
        private static readonly global::Lua.LuaFunction _LuaShaderUtil_GetMissShaderName = new global::Lua.LuaFunction("GetMissShaderName", (_context, _) =>
        {
            global::Lua.LuaValue _lastArg = default;
            global::System.Int32 _lastArgPos = default;
            global::System.Type _expectedType = default;
            var _argCount = _context.ArgumentCount;
            var _arg0 = _lastArg = _argCount > 0 ? _context.GetArgument(0) : global::Lua.LuaValue.Nil;
            _lastArgPos = 0; _expectedType = typeof(global::Luny.UnityEngine.Rendering.LuaRayTracingShader);
            if (_arg0.TryRead<global::Luny.UnityEngine.Rendering.LuaRayTracingShader>(out var _p0_UnityEngine_Rendering_RayTracingShader))
            {
                var _arg1 = _lastArg = _argCount > 1 ? _context.GetArgument(1) : global::Lua.LuaValue.Nil;
                _lastArgPos = 1; _expectedType = typeof(global::System.Int32);
                if (_arg1.TryRead<global::System.Int32>(out var _p1_System_Int32))
                {
                    if (_argCount == 2)
                    {
                        var s = _p0_UnityEngine_Rendering_RayTracingShader.Instance;
                        var shaderIndex = _p1_System_Int32;
                        var _ret0 = global::UnityEditor.ShaderUtil.GetMissShaderName(s, shaderIndex);
                        var _lret0 = new global::Lua.LuaValue(_ret0);
                        var _retCount = _context.Return(_lret0);
                        return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                    }
                }
            }
            throw new global::Lua.LuaRuntimeException(_context.Thread, $"{"GetMissShaderName"}: invalid argument #{_lastArgPos}: {_lastArg} ({_lastArg.Type}), expected: {_expectedType.FullName}", 2);
        });
        private static readonly global::Lua.LuaFunction _LuaShaderUtil_GetMissShaderRayPayloadSize = new global::Lua.LuaFunction("GetMissShaderRayPayloadSize", (_context, _) =>
        {
            global::Lua.LuaValue _lastArg = default;
            global::System.Int32 _lastArgPos = default;
            global::System.Type _expectedType = default;
            var _argCount = _context.ArgumentCount;
            var _arg0 = _lastArg = _argCount > 0 ? _context.GetArgument(0) : global::Lua.LuaValue.Nil;
            _lastArgPos = 0; _expectedType = typeof(global::Luny.UnityEngine.Rendering.LuaRayTracingShader);
            if (_arg0.TryRead<global::Luny.UnityEngine.Rendering.LuaRayTracingShader>(out var _p0_UnityEngine_Rendering_RayTracingShader))
            {
                var _arg1 = _lastArg = _argCount > 1 ? _context.GetArgument(1) : global::Lua.LuaValue.Nil;
                _lastArgPos = 1; _expectedType = typeof(global::System.Int32);
                if (_arg1.TryRead<global::System.Int32>(out var _p1_System_Int32))
                {
                    if (_argCount == 2)
                    {
                        var s = _p0_UnityEngine_Rendering_RayTracingShader.Instance;
                        var shaderIndex = _p1_System_Int32;
                        var _ret0 = global::UnityEditor.ShaderUtil.GetMissShaderRayPayloadSize(s, shaderIndex);
                        var _lret0 = new global::Lua.LuaValue(_ret0);
                        var _retCount = _context.Return(_lret0);
                        return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                    }
                }
            }
            throw new global::Lua.LuaRuntimeException(_context.Thread, $"{"GetMissShaderRayPayloadSize"}: invalid argument #{_lastArgPos}: {_lastArg} ({_lastArg.Type}), expected: {_expectedType.FullName}", 2);
        });
        private static readonly global::Lua.LuaFunction _LuaShaderUtil_GetPropertyCount = new global::Lua.LuaFunction("GetPropertyCount", (_context, _) =>
        {
            global::Lua.LuaValue _lastArg = default;
            global::System.Int32 _lastArgPos = default;
            global::System.Type _expectedType = default;
            var _argCount = _context.ArgumentCount;
            var _arg0 = _lastArg = _argCount > 0 ? _context.GetArgument(0) : global::Lua.LuaValue.Nil;
            _lastArgPos = 0; _expectedType = typeof(global::Luny.UnityEngine.LuaShader);
            if (_arg0.TryRead<global::Luny.UnityEngine.LuaShader>(out var _p0_UnityEngine_Shader))
            {
                if (_argCount == 1)
                {
                    var s = _p0_UnityEngine_Shader.Instance;
                    var _ret0 = global::UnityEditor.ShaderUtil.GetPropertyCount(s);
                    var _lret0 = new global::Lua.LuaValue(_ret0);
                    var _retCount = _context.Return(_lret0);
                    return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                }
            }
            throw new global::Lua.LuaRuntimeException(_context.Thread, $"{"GetPropertyCount"}: invalid argument #{_lastArgPos}: {_lastArg} ({_lastArg.Type}), expected: {_expectedType.FullName}", 2);
        });
        private static readonly global::Lua.LuaFunction _LuaShaderUtil_GetPropertyDescription = new global::Lua.LuaFunction("GetPropertyDescription", (_context, _) =>
        {
            global::Lua.LuaValue _lastArg = default;
            global::System.Int32 _lastArgPos = default;
            global::System.Type _expectedType = default;
            var _argCount = _context.ArgumentCount;
            var _arg0 = _lastArg = _argCount > 0 ? _context.GetArgument(0) : global::Lua.LuaValue.Nil;
            _lastArgPos = 0; _expectedType = typeof(global::Luny.UnityEngine.LuaShader);
            if (_arg0.TryRead<global::Luny.UnityEngine.LuaShader>(out var _p0_UnityEngine_Shader))
            {
                var _arg1 = _lastArg = _argCount > 1 ? _context.GetArgument(1) : global::Lua.LuaValue.Nil;
                _lastArgPos = 1; _expectedType = typeof(global::System.Int32);
                if (_arg1.TryRead<global::System.Int32>(out var _p1_System_Int32))
                {
                    if (_argCount == 2)
                    {
                        var s = _p0_UnityEngine_Shader.Instance;
                        var propertyIdx = _p1_System_Int32;
                        var _ret0 = global::UnityEditor.ShaderUtil.GetPropertyDescription(s, propertyIdx);
                        var _lret0 = new global::Lua.LuaValue(_ret0);
                        var _retCount = _context.Return(_lret0);
                        return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                    }
                }
            }
            throw new global::Lua.LuaRuntimeException(_context.Thread, $"{"GetPropertyDescription"}: invalid argument #{_lastArgPos}: {_lastArg} ({_lastArg.Type}), expected: {_expectedType.FullName}", 2);
        });
        private static readonly global::Lua.LuaFunction _LuaShaderUtil_GetPropertyName = new global::Lua.LuaFunction("GetPropertyName", (_context, _) =>
        {
            global::Lua.LuaValue _lastArg = default;
            global::System.Int32 _lastArgPos = default;
            global::System.Type _expectedType = default;
            var _argCount = _context.ArgumentCount;
            var _arg0 = _lastArg = _argCount > 0 ? _context.GetArgument(0) : global::Lua.LuaValue.Nil;
            _lastArgPos = 0; _expectedType = typeof(global::Luny.UnityEngine.LuaShader);
            if (_arg0.TryRead<global::Luny.UnityEngine.LuaShader>(out var _p0_UnityEngine_Shader))
            {
                var _arg1 = _lastArg = _argCount > 1 ? _context.GetArgument(1) : global::Lua.LuaValue.Nil;
                _lastArgPos = 1; _expectedType = typeof(global::System.Int32);
                if (_arg1.TryRead<global::System.Int32>(out var _p1_System_Int32))
                {
                    if (_argCount == 2)
                    {
                        var s = _p0_UnityEngine_Shader.Instance;
                        var propertyIdx = _p1_System_Int32;
                        var _ret0 = global::UnityEditor.ShaderUtil.GetPropertyName(s, propertyIdx);
                        var _lret0 = new global::Lua.LuaValue(_ret0);
                        var _retCount = _context.Return(_lret0);
                        return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                    }
                }
            }
            throw new global::Lua.LuaRuntimeException(_context.Thread, $"{"GetPropertyName"}: invalid argument #{_lastArgPos}: {_lastArg} ({_lastArg.Type}), expected: {_expectedType.FullName}", 2);
        });
        private static readonly global::Lua.LuaFunction _LuaShaderUtil_GetPropertyType = new global::Lua.LuaFunction("GetPropertyType", (_context, _) =>
        {
            global::Lua.LuaValue _lastArg = default;
            global::System.Int32 _lastArgPos = default;
            global::System.Type _expectedType = default;
            var _argCount = _context.ArgumentCount;
            var _arg0 = _lastArg = _argCount > 0 ? _context.GetArgument(0) : global::Lua.LuaValue.Nil;
            _lastArgPos = 0; _expectedType = typeof(global::Luny.UnityEngine.LuaShader);
            if (_arg0.TryRead<global::Luny.UnityEngine.LuaShader>(out var _p0_UnityEngine_Shader))
            {
                var _arg1 = _lastArg = _argCount > 1 ? _context.GetArgument(1) : global::Lua.LuaValue.Nil;
                _lastArgPos = 1; _expectedType = typeof(global::System.Int32);
                if (_arg1.TryRead<global::System.Int32>(out var _p1_System_Int32))
                {
                    if (_argCount == 2)
                    {
                        var s = _p0_UnityEngine_Shader.Instance;
                        var propertyIdx = _p1_System_Int32;
                        var _ret0 = global::UnityEditor.ShaderUtil.GetPropertyType(s, propertyIdx);
                        var _lret0 = new global::Lua.LuaValue((global::System.Int64)_ret0);
                        var _retCount = _context.Return(_lret0);
                        return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                    }
                }
            }
            throw new global::Lua.LuaRuntimeException(_context.Thread, $"{"GetPropertyType"}: invalid argument #{_lastArgPos}: {_lastArg} ({_lastArg.Type}), expected: {_expectedType.FullName}", 2);
        });
        private static readonly global::Lua.LuaFunction _LuaShaderUtil_GetRangeLimits = new global::Lua.LuaFunction("GetRangeLimits", (_context, _) =>
        {
            global::Lua.LuaValue _lastArg = default;
            global::System.Int32 _lastArgPos = default;
            global::System.Type _expectedType = default;
            var _argCount = _context.ArgumentCount;
            var _arg0 = _lastArg = _argCount > 0 ? _context.GetArgument(0) : global::Lua.LuaValue.Nil;
            _lastArgPos = 0; _expectedType = typeof(global::Luny.UnityEngine.LuaShader);
            if (_arg0.TryRead<global::Luny.UnityEngine.LuaShader>(out var _p0_UnityEngine_Shader))
            {
                var _arg1 = _lastArg = _argCount > 1 ? _context.GetArgument(1) : global::Lua.LuaValue.Nil;
                _lastArgPos = 1; _expectedType = typeof(global::System.Int32);
                if (_arg1.TryRead<global::System.Int32>(out var _p1_System_Int32))
                {
                    var _arg2 = _lastArg = _argCount > 2 ? _context.GetArgument(2) : global::Lua.LuaValue.Nil;
                    _lastArgPos = 2; _expectedType = typeof(global::System.Int32);
                    if (_arg2.TryRead<global::System.Int32>(out var _p2_System_Int32))
                    {
                        if (_argCount == 3)
                        {
                            var s = _p0_UnityEngine_Shader.Instance;
                            var propertyIdx = _p1_System_Int32;
                            var defminmax = _p2_System_Int32;
                            var _ret0 = global::UnityEditor.ShaderUtil.GetRangeLimits(s, propertyIdx, defminmax);
                            var _lret0 = new global::Lua.LuaValue(_ret0);
                            var _retCount = _context.Return(_lret0);
                            return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                        }
                    }
                }
            }
            throw new global::Lua.LuaRuntimeException(_context.Thread, $"{"GetRangeLimits"}: invalid argument #{_lastArgPos}: {_lastArg} ({_lastArg.Type}), expected: {_expectedType.FullName}", 2);
        });
        private static readonly global::Lua.LuaFunction _LuaShaderUtil_GetRayGenerationShaderCount = new global::Lua.LuaFunction("GetRayGenerationShaderCount", (_context, _) =>
        {
            global::Lua.LuaValue _lastArg = default;
            global::System.Int32 _lastArgPos = default;
            global::System.Type _expectedType = default;
            var _argCount = _context.ArgumentCount;
            var _arg0 = _lastArg = _argCount > 0 ? _context.GetArgument(0) : global::Lua.LuaValue.Nil;
            _lastArgPos = 0; _expectedType = typeof(global::Luny.UnityEngine.Rendering.LuaRayTracingShader);
            if (_arg0.TryRead<global::Luny.UnityEngine.Rendering.LuaRayTracingShader>(out var _p0_UnityEngine_Rendering_RayTracingShader))
            {
                if (_argCount == 1)
                {
                    var s = _p0_UnityEngine_Rendering_RayTracingShader.Instance;
                    var _ret0 = global::UnityEditor.ShaderUtil.GetRayGenerationShaderCount(s);
                    var _lret0 = new global::Lua.LuaValue(_ret0);
                    var _retCount = _context.Return(_lret0);
                    return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                }
            }
            throw new global::Lua.LuaRuntimeException(_context.Thread, $"{"GetRayGenerationShaderCount"}: invalid argument #{_lastArgPos}: {_lastArg} ({_lastArg.Type}), expected: {_expectedType.FullName}", 2);
        });
        private static readonly global::Lua.LuaFunction _LuaShaderUtil_GetRayGenerationShaderName = new global::Lua.LuaFunction("GetRayGenerationShaderName", (_context, _) =>
        {
            global::Lua.LuaValue _lastArg = default;
            global::System.Int32 _lastArgPos = default;
            global::System.Type _expectedType = default;
            var _argCount = _context.ArgumentCount;
            var _arg0 = _lastArg = _argCount > 0 ? _context.GetArgument(0) : global::Lua.LuaValue.Nil;
            _lastArgPos = 0; _expectedType = typeof(global::Luny.UnityEngine.Rendering.LuaRayTracingShader);
            if (_arg0.TryRead<global::Luny.UnityEngine.Rendering.LuaRayTracingShader>(out var _p0_UnityEngine_Rendering_RayTracingShader))
            {
                var _arg1 = _lastArg = _argCount > 1 ? _context.GetArgument(1) : global::Lua.LuaValue.Nil;
                _lastArgPos = 1; _expectedType = typeof(global::System.Int32);
                if (_arg1.TryRead<global::System.Int32>(out var _p1_System_Int32))
                {
                    if (_argCount == 2)
                    {
                        var s = _p0_UnityEngine_Rendering_RayTracingShader.Instance;
                        var shaderIndex = _p1_System_Int32;
                        var _ret0 = global::UnityEditor.ShaderUtil.GetRayGenerationShaderName(s, shaderIndex);
                        var _lret0 = new global::Lua.LuaValue(_ret0);
                        var _retCount = _context.Return(_lret0);
                        return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                    }
                }
            }
            throw new global::Lua.LuaRuntimeException(_context.Thread, $"{"GetRayGenerationShaderName"}: invalid argument #{_lastArgPos}: {_lastArg} ({_lastArg.Type}), expected: {_expectedType.FullName}", 2);
        });
        private static readonly global::Lua.LuaFunction _LuaShaderUtil_GetRayTracingShaderMessageCount = new global::Lua.LuaFunction("GetRayTracingShaderMessageCount", (_context, _) =>
        {
            global::Lua.LuaValue _lastArg = default;
            global::System.Int32 _lastArgPos = default;
            global::System.Type _expectedType = default;
            var _argCount = _context.ArgumentCount;
            var _arg0 = _lastArg = _argCount > 0 ? _context.GetArgument(0) : global::Lua.LuaValue.Nil;
            _lastArgPos = 0; _expectedType = typeof(global::Luny.UnityEngine.Rendering.LuaRayTracingShader);
            if (_arg0.TryRead<global::Luny.UnityEngine.Rendering.LuaRayTracingShader>(out var _p0_UnityEngine_Rendering_RayTracingShader))
            {
                if (_argCount == 1)
                {
                    var s = _p0_UnityEngine_Rendering_RayTracingShader.Instance;
                    var _ret0 = global::UnityEditor.ShaderUtil.GetRayTracingShaderMessageCount(s);
                    var _lret0 = new global::Lua.LuaValue(_ret0);
                    var _retCount = _context.Return(_lret0);
                    return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                }
            }
            throw new global::Lua.LuaRuntimeException(_context.Thread, $"{"GetRayTracingShaderMessageCount"}: invalid argument #{_lastArgPos}: {_lastArg} ({_lastArg.Type}), expected: {_expectedType.FullName}", 2);
        });
        private static readonly global::Lua.LuaFunction _LuaShaderUtil_GetRayTracingShaderMessages = new global::Lua.LuaFunction("GetRayTracingShaderMessages", (_context, _) =>
        {
            global::Lua.LuaValue _lastArg = default;
            global::System.Int32 _lastArgPos = default;
            global::System.Type _expectedType = default;
            var _argCount = _context.ArgumentCount;
            var _arg0 = _lastArg = _argCount > 0 ? _context.GetArgument(0) : global::Lua.LuaValue.Nil;
            _lastArgPos = 0; _expectedType = typeof(global::Luny.UnityEngine.Rendering.LuaRayTracingShader);
            if (_arg0.TryRead<global::Luny.UnityEngine.Rendering.LuaRayTracingShader>(out var _p0_UnityEngine_Rendering_RayTracingShader))
            {
                if (_argCount == 1)
                {
                    var s = _p0_UnityEngine_Rendering_RayTracingShader.Instance;
                    var _ret0 = global::UnityEditor.ShaderUtil.GetRayTracingShaderMessages(s);
                    var _factory = _context.GetObjectFactory();
                    var _lret0 = _factory.Bind(_ret0);
                    var _retCount = _context.Return(_lret0);
                    return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                }
            }
            throw new global::Lua.LuaRuntimeException(_context.Thread, $"{"GetRayTracingShaderMessages"}: invalid argument #{_lastArgPos}: {_lastArg} ({_lastArg.Type}), expected: {_expectedType.FullName}", 2);
        });
        private static readonly global::Lua.LuaFunction _LuaShaderUtil_GetShaderData = new global::Lua.LuaFunction("GetShaderData", (_context, _) =>
        {
            global::Lua.LuaValue _lastArg = default;
            global::System.Int32 _lastArgPos = default;
            global::System.Type _expectedType = default;
            var _argCount = _context.ArgumentCount;
            var _arg0 = _lastArg = _argCount > 0 ? _context.GetArgument(0) : global::Lua.LuaValue.Nil;
            _lastArgPos = 0; _expectedType = typeof(global::Luny.UnityEngine.LuaShader);
            if (_arg0.TryRead<global::Luny.UnityEngine.LuaShader>(out var _p0_UnityEngine_Shader))
            {
                if (_argCount == 1)
                {
                    var shader = _p0_UnityEngine_Shader.Instance;
                    var _ret0 = global::UnityEditor.ShaderUtil.GetShaderData(shader);
                    var _factory = _context.GetObjectFactory();
                    var _lret0 = _factory.Bind(_ret0);
                    var _retCount = _context.Return(_lret0);
                    return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                }
            }
            throw new global::Lua.LuaRuntimeException(_context.Thread, $"{"GetShaderData"}: invalid argument #{_lastArgPos}: {_lastArg} ({_lastArg.Type}), expected: {_expectedType.FullName}", 2);
        });
        private static readonly global::Lua.LuaFunction _LuaShaderUtil_GetShaderInfo = new global::Lua.LuaFunction("GetShaderInfo", (_context, _) =>
        {
            global::Lua.LuaValue _lastArg = default;
            global::System.Int32 _lastArgPos = default;
            global::System.Type _expectedType = default;
            var _argCount = _context.ArgumentCount;
            var _arg0 = _lastArg = _argCount > 0 ? _context.GetArgument(0) : global::Lua.LuaValue.Nil;
            _lastArgPos = 0; _expectedType = typeof(global::Luny.UnityEngine.LuaShader);
            if (_arg0.TryRead<global::Luny.UnityEngine.LuaShader>(out var _p0_UnityEngine_Shader))
            {
                if (_argCount == 1)
                {
                    var shader = _p0_UnityEngine_Shader.Instance;
                    var _ret0 = global::UnityEditor.ShaderUtil.GetShaderInfo(shader);
                    var _lret0 = global::LunyEditor.UnityEditor.LuaShaderInfo.Bind(_ret0);
                    var _retCount = _context.Return(_lret0);
                    return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                }
            }
            throw new global::Lua.LuaRuntimeException(_context.Thread, $"{"GetShaderInfo"}: invalid argument #{_lastArgPos}: {_lastArg} ({_lastArg.Type}), expected: {_expectedType.FullName}", 2);
        });
        private static readonly global::Lua.LuaFunction _LuaShaderUtil_GetShaderMessageCount = new global::Lua.LuaFunction("GetShaderMessageCount", (_context, _) =>
        {
            global::Lua.LuaValue _lastArg = default;
            global::System.Int32 _lastArgPos = default;
            global::System.Type _expectedType = default;
            var _argCount = _context.ArgumentCount;
            var _arg0 = _lastArg = _argCount > 0 ? _context.GetArgument(0) : global::Lua.LuaValue.Nil;
            _lastArgPos = 0; _expectedType = typeof(global::Luny.UnityEngine.LuaShader);
            if (_arg0.TryRead<global::Luny.UnityEngine.LuaShader>(out var _p0_UnityEngine_Shader))
            {
                if (_argCount == 1)
                {
                    var s = _p0_UnityEngine_Shader.Instance;
                    var _ret0 = global::UnityEditor.ShaderUtil.GetShaderMessageCount(s);
                    var _lret0 = new global::Lua.LuaValue(_ret0);
                    var _retCount = _context.Return(_lret0);
                    return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                }
            }
            throw new global::Lua.LuaRuntimeException(_context.Thread, $"{"GetShaderMessageCount"}: invalid argument #{_lastArgPos}: {_lastArg} ({_lastArg.Type}), expected: {_expectedType.FullName}", 2);
        });
        private static readonly global::Lua.LuaFunction _LuaShaderUtil_GetShaderMessages = new global::Lua.LuaFunction("GetShaderMessages", (_context, _) =>
        {
            global::Lua.LuaValue _lastArg = default;
            global::System.Int32 _lastArgPos = default;
            global::System.Type _expectedType = default;
            var _argCount = _context.ArgumentCount;
            var _arg0 = _lastArg = _argCount > 0 ? _context.GetArgument(0) : global::Lua.LuaValue.Nil;
            _lastArgPos = 0; _expectedType = typeof(global::Luny.UnityEngine.LuaShader);
            if (_arg0.TryRead<global::Luny.UnityEngine.LuaShader>(out var _p0_UnityEngine_Shader))
            {
                if (_argCount == 1)
                {
                    var s = _p0_UnityEngine_Shader.Instance;
                    var _ret0 = global::UnityEditor.ShaderUtil.GetShaderMessages(s);
                    var _factory = _context.GetObjectFactory();
                    var _lret0 = _factory.Bind(_ret0);
                    var _retCount = _context.Return(_lret0);
                    return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                }
                var _arg1 = _lastArg = _argCount > 1 ? _context.GetArgument(1) : global::Lua.LuaValue.Nil;
                _lastArgPos = 1; _expectedType = typeof(global::UnityEditor.Rendering.ShaderCompilerPlatform);
                if (_arg1.TryRead<global::UnityEditor.Rendering.ShaderCompilerPlatform>(out var _p1_UnityEditor_Rendering_ShaderCompilerPlatform))
                {
                    if (_argCount == 2)
                    {
                        var s = _p0_UnityEngine_Shader.Instance;
                        var platform = _p1_UnityEditor_Rendering_ShaderCompilerPlatform;
                        var _ret0 = global::UnityEditor.ShaderUtil.GetShaderMessages(s, platform);
                        var _factory = _context.GetObjectFactory();
                        var _lret0 = _factory.Bind(_ret0);
                        var _retCount = _context.Return(_lret0);
                        return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                    }
                }
            }
            throw new global::Lua.LuaRuntimeException(_context.Thread, $"{"GetShaderMessages"}: invalid argument #{_lastArgPos}: {_lastArg} ({_lastArg.Type}), expected: {_expectedType.FullName}", 2);
        });
        private static readonly global::Lua.LuaFunction _LuaShaderUtil_GetShaderPlatformKeywordsForBuildTarget = new global::Lua.LuaFunction("GetShaderPlatformKeywordsForBuildTarget", (_context, _) =>
        {
            global::Lua.LuaValue _lastArg = default;
            global::System.Int32 _lastArgPos = default;
            global::System.Type _expectedType = default;
            var _argCount = _context.ArgumentCount;
            var _arg0 = _lastArg = _argCount > 0 ? _context.GetArgument(0) : global::Lua.LuaValue.Nil;
            _lastArgPos = 0; _expectedType = typeof(global::UnityEditor.Rendering.ShaderCompilerPlatform);
            if (_arg0.TryRead<global::UnityEditor.Rendering.ShaderCompilerPlatform>(out var _p0_UnityEditor_Rendering_ShaderCompilerPlatform))
            {
                var _arg1 = _lastArg = _argCount > 1 ? _context.GetArgument(1) : global::Lua.LuaValue.Nil;
                _lastArgPos = 1; _expectedType = typeof(global::UnityEditor.BuildTarget);
                if (_arg1.TryRead<global::UnityEditor.BuildTarget>(out var _p1_UnityEditor_BuildTarget))
                {
                    if (_argCount == 2)
                    {
                        var shaderCompilerPlatform = _p0_UnityEditor_Rendering_ShaderCompilerPlatform;
                        var buildTarget = _p1_UnityEditor_BuildTarget;
                        var _ret0 = global::UnityEditor.ShaderUtil.GetShaderPlatformKeywordsForBuildTarget(shaderCompilerPlatform, buildTarget);
                        var _factory = _context.GetObjectFactory();
                        var _lret0 = _factory.Bind(_ret0);
                        var _retCount = _context.Return(_lret0);
                        return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                    }
                    var _arg2 = _lastArg = _argCount > 2 ? _context.GetArgument(2) : global::Lua.LuaValue.Nil;
                    _lastArgPos = 2; _expectedType = typeof(global::UnityEngine.Rendering.GraphicsTier);
                    if (_arg2.TryRead<global::UnityEngine.Rendering.GraphicsTier>(out var _p2_UnityEngine_Rendering_GraphicsTier))
                    {
                        if (_argCount == 3)
                        {
                            var shaderCompilerPlatform = _p0_UnityEditor_Rendering_ShaderCompilerPlatform;
                            var buildTarget = _p1_UnityEditor_BuildTarget;
                            var tier = _p2_UnityEngine_Rendering_GraphicsTier;
                            var _ret0 = global::UnityEditor.ShaderUtil.GetShaderPlatformKeywordsForBuildTarget(shaderCompilerPlatform, buildTarget, tier);
                            var _factory = _context.GetObjectFactory();
                            var _lret0 = _factory.Bind(_ret0);
                            var _retCount = _context.Return(_lret0);
                            return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                        }
                    }
                }
            }
            throw new global::Lua.LuaRuntimeException(_context.Thread, $"{"GetShaderPlatformKeywordsForBuildTarget"}: invalid argument #{_lastArgPos}: {_lastArg} ({_lastArg.Type}), expected: {_expectedType.FullName}", 2);
        });
        private static readonly global::Lua.LuaFunction _LuaShaderUtil_GetTexDim = new global::Lua.LuaFunction("GetTexDim", (_context, _) =>
        {
            global::Lua.LuaValue _lastArg = default;
            global::System.Int32 _lastArgPos = default;
            global::System.Type _expectedType = default;
            var _argCount = _context.ArgumentCount;
            var _arg0 = _lastArg = _argCount > 0 ? _context.GetArgument(0) : global::Lua.LuaValue.Nil;
            _lastArgPos = 0; _expectedType = typeof(global::Luny.UnityEngine.LuaShader);
            if (_arg0.TryRead<global::Luny.UnityEngine.LuaShader>(out var _p0_UnityEngine_Shader))
            {
                var _arg1 = _lastArg = _argCount > 1 ? _context.GetArgument(1) : global::Lua.LuaValue.Nil;
                _lastArgPos = 1; _expectedType = typeof(global::System.Int32);
                if (_arg1.TryRead<global::System.Int32>(out var _p1_System_Int32))
                {
                    if (_argCount == 2)
                    {
                        var s = _p0_UnityEngine_Shader.Instance;
                        var propertyIdx = _p1_System_Int32;
                        var _ret0 = global::UnityEditor.ShaderUtil.GetTexDim(s, propertyIdx);
                        var _lret0 = new global::Lua.LuaValue((global::System.Int64)_ret0);
                        var _retCount = _context.Return(_lret0);
                        return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                    }
                }
            }
            throw new global::Lua.LuaRuntimeException(_context.Thread, $"{"GetTexDim"}: invalid argument #{_lastArgPos}: {_lastArg} ({_lastArg.Type}), expected: {_expectedType.FullName}", 2);
        });
        private static readonly global::Lua.LuaFunction _LuaShaderUtil_HasProceduralInstancing = new global::Lua.LuaFunction("HasProceduralInstancing", (_context, _) =>
        {
            global::Lua.LuaValue _lastArg = default;
            global::System.Int32 _lastArgPos = default;
            global::System.Type _expectedType = default;
            var _argCount = _context.ArgumentCount;
            var _arg0 = _lastArg = _argCount > 0 ? _context.GetArgument(0) : global::Lua.LuaValue.Nil;
            _lastArgPos = 0; _expectedType = typeof(global::Luny.UnityEngine.LuaShader);
            if (_arg0.TryRead<global::Luny.UnityEngine.LuaShader>(out var _p0_UnityEngine_Shader))
            {
                if (_argCount == 1)
                {
                    var s = _p0_UnityEngine_Shader.Instance;
                    var _ret0 = global::UnityEditor.ShaderUtil.HasProceduralInstancing(s);
                    var _lret0 = new global::Lua.LuaValue(_ret0);
                    var _retCount = _context.Return(_lret0);
                    return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                }
            }
            throw new global::Lua.LuaRuntimeException(_context.Thread, $"{"HasProceduralInstancing"}: invalid argument #{_lastArgPos}: {_lastArg} ({_lastArg.Type}), expected: {_expectedType.FullName}", 2);
        });
        private static readonly global::Lua.LuaFunction _LuaShaderUtil_IsPassCompiled = new global::Lua.LuaFunction("IsPassCompiled", (_context, _) =>
        {
            global::Lua.LuaValue _lastArg = default;
            global::System.Int32 _lastArgPos = default;
            global::System.Type _expectedType = default;
            var _argCount = _context.ArgumentCount;
            var _arg0 = _lastArg = _argCount > 0 ? _context.GetArgument(0) : global::Lua.LuaValue.Nil;
            _lastArgPos = 0; _expectedType = typeof(global::Luny.UnityEngine.LuaMaterial);
            if (_arg0.TryRead<global::Luny.UnityEngine.LuaMaterial>(out var _p0_UnityEngine_Material))
            {
                var _arg1 = _lastArg = _argCount > 1 ? _context.GetArgument(1) : global::Lua.LuaValue.Nil;
                _lastArgPos = 1; _expectedType = typeof(global::System.Int32);
                if (_arg1.TryRead<global::System.Int32>(out var _p1_System_Int32))
                {
                    if (_argCount == 2)
                    {
                        var material = _p0_UnityEngine_Material.Instance;
                        var pass = _p1_System_Int32;
                        var _ret0 = global::UnityEditor.ShaderUtil.IsPassCompiled(material, pass);
                        var _lret0 = new global::Lua.LuaValue(_ret0);
                        var _retCount = _context.Return(_lret0);
                        return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                    }
                }
            }
            throw new global::Lua.LuaRuntimeException(_context.Thread, $"{"IsPassCompiled"}: invalid argument #{_lastArgPos}: {_lastArg} ({_lastArg.Type}), expected: {_expectedType.FullName}", 2);
        });
        private static readonly global::Lua.LuaFunction _LuaShaderUtil_IsShaderPropertyHidden = new global::Lua.LuaFunction("IsShaderPropertyHidden", (_context, _) =>
        {
            global::Lua.LuaValue _lastArg = default;
            global::System.Int32 _lastArgPos = default;
            global::System.Type _expectedType = default;
            var _argCount = _context.ArgumentCount;
            var _arg0 = _lastArg = _argCount > 0 ? _context.GetArgument(0) : global::Lua.LuaValue.Nil;
            _lastArgPos = 0; _expectedType = typeof(global::Luny.UnityEngine.LuaShader);
            if (_arg0.TryRead<global::Luny.UnityEngine.LuaShader>(out var _p0_UnityEngine_Shader))
            {
                var _arg1 = _lastArg = _argCount > 1 ? _context.GetArgument(1) : global::Lua.LuaValue.Nil;
                _lastArgPos = 1; _expectedType = typeof(global::System.Int32);
                if (_arg1.TryRead<global::System.Int32>(out var _p1_System_Int32))
                {
                    if (_argCount == 2)
                    {
                        var s = _p0_UnityEngine_Shader.Instance;
                        var propertyIdx = _p1_System_Int32;
                        var _ret0 = global::UnityEditor.ShaderUtil.IsShaderPropertyHidden(s, propertyIdx);
                        var _lret0 = new global::Lua.LuaValue(_ret0);
                        var _retCount = _context.Return(_lret0);
                        return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                    }
                }
            }
            throw new global::Lua.LuaRuntimeException(_context.Thread, $"{"IsShaderPropertyHidden"}: invalid argument #{_lastArgPos}: {_lastArg} ({_lastArg.Type}), expected: {_expectedType.FullName}", 2);
        });
        private static readonly global::Lua.LuaFunction _LuaShaderUtil_IsShaderPropertyNonModifiableTexureProperty = new global::Lua.LuaFunction("IsShaderPropertyNonModifiableTexureProperty", (_context, _) =>
        {
            global::Lua.LuaValue _lastArg = default;
            global::System.Int32 _lastArgPos = default;
            global::System.Type _expectedType = default;
            var _argCount = _context.ArgumentCount;
            var _arg0 = _lastArg = _argCount > 0 ? _context.GetArgument(0) : global::Lua.LuaValue.Nil;
            _lastArgPos = 0; _expectedType = typeof(global::Luny.UnityEngine.LuaShader);
            if (_arg0.TryRead<global::Luny.UnityEngine.LuaShader>(out var _p0_UnityEngine_Shader))
            {
                var _arg1 = _lastArg = _argCount > 1 ? _context.GetArgument(1) : global::Lua.LuaValue.Nil;
                _lastArgPos = 1; _expectedType = typeof(global::System.Int32);
                if (_arg1.TryRead<global::System.Int32>(out var _p1_System_Int32))
                {
                    if (_argCount == 2)
                    {
                        var s = _p0_UnityEngine_Shader.Instance;
                        var propertyIdx = _p1_System_Int32;
                        var _ret0 = global::UnityEditor.ShaderUtil.IsShaderPropertyNonModifiableTexureProperty(s, propertyIdx);
                        var _lret0 = new global::Lua.LuaValue(_ret0);
                        var _retCount = _context.Return(_lret0);
                        return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                    }
                }
            }
            throw new global::Lua.LuaRuntimeException(_context.Thread, $"{"IsShaderPropertyNonModifiableTexureProperty"}: invalid argument #{_lastArgPos}: {_lastArg} ({_lastArg.Type}), expected: {_expectedType.FullName}", 2);
        });
        private static readonly global::Lua.LuaFunction _LuaShaderUtil_RegisterShader = new global::Lua.LuaFunction("RegisterShader", (_context, _) =>
        {
            global::Lua.LuaValue _lastArg = default;
            global::System.Int32 _lastArgPos = default;
            global::System.Type _expectedType = default;
            var _argCount = _context.ArgumentCount;
            var _arg0 = _lastArg = _argCount > 0 ? _context.GetArgument(0) : global::Lua.LuaValue.Nil;
            _lastArgPos = 0; _expectedType = typeof(global::Luny.UnityEngine.LuaShader);
            if (_arg0.TryRead<global::Luny.UnityEngine.LuaShader>(out var _p0_UnityEngine_Shader))
            {
                if (_argCount == 1)
                {
                    var shader = _p0_UnityEngine_Shader.Instance;
                    global::UnityEditor.ShaderUtil.RegisterShader(shader);
                    var _retCount = _context.Return();
                    return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                }
            }
            throw new global::Lua.LuaRuntimeException(_context.Thread, $"{"RegisterShader"}: invalid argument #{_lastArgPos}: {_lastArg} ({_lastArg.Type}), expected: {_expectedType.FullName}", 2);
        });
        private static readonly global::Lua.LuaFunction _LuaShaderUtil_RestoreAsyncCompilation = new global::Lua.LuaFunction("RestoreAsyncCompilation", (_context, _) =>
        {
            global::Lua.LuaValue _lastArg = default;
            global::System.Int32 _lastArgPos = default;
            global::System.Type _expectedType = default;
            var _argCount = _context.ArgumentCount;
            var _arg0 = _lastArg = _argCount > 0 ? _context.GetArgument(0) : global::Lua.LuaValue.Nil;
            _lastArgPos = 0; _expectedType = typeof(global::Luny.UnityEngine.Rendering.LuaCommandBuffer);
            if (_arg0.TryRead<global::Luny.UnityEngine.Rendering.LuaCommandBuffer>(out var _p0_UnityEngine_Rendering_CommandBuffer))
            {
                if (_argCount == 1)
                {
                    var cmd = _p0_UnityEngine_Rendering_CommandBuffer.Instance;
                    global::UnityEditor.ShaderUtil.RestoreAsyncCompilation(cmd);
                    var _retCount = _context.Return();
                    return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                }
            }
            throw new global::Lua.LuaRuntimeException(_context.Thread, $"{"RestoreAsyncCompilation"}: invalid argument #{_lastArgPos}: {_lastArg} ({_lastArg.Type}), expected: {_expectedType.FullName}", 2);
        });
        private static readonly global::Lua.LuaFunction _LuaShaderUtil_SetAsyncCompilation = new global::Lua.LuaFunction("SetAsyncCompilation", (_context, _) =>
        {
            global::Lua.LuaValue _lastArg = default;
            global::System.Int32 _lastArgPos = default;
            global::System.Type _expectedType = default;
            var _argCount = _context.ArgumentCount;
            var _arg0 = _lastArg = _argCount > 0 ? _context.GetArgument(0) : global::Lua.LuaValue.Nil;
            _lastArgPos = 0; _expectedType = typeof(global::Luny.UnityEngine.Rendering.LuaCommandBuffer);
            if (_arg0.TryRead<global::Luny.UnityEngine.Rendering.LuaCommandBuffer>(out var _p0_UnityEngine_Rendering_CommandBuffer))
            {
                var _arg1 = _lastArg = _argCount > 1 ? _context.GetArgument(1) : global::Lua.LuaValue.Nil;
                _lastArgPos = 1; _expectedType = typeof(global::System.Boolean);
                if (_arg1.TryRead<global::System.Boolean>(out var _p1_System_Boolean))
                {
                    if (_argCount == 2)
                    {
                        var cmd = _p0_UnityEngine_Rendering_CommandBuffer.Instance;
                        var allow = _p1_System_Boolean;
                        global::UnityEditor.ShaderUtil.SetAsyncCompilation(cmd, allow);
                        var _retCount = _context.Return();
                        return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                    }
                }
            }
            throw new global::Lua.LuaRuntimeException(_context.Thread, $"{"SetAsyncCompilation"}: invalid argument #{_lastArgPos}: {_lastArg} ({_lastArg.Type}), expected: {_expectedType.FullName}", 2);
        });
        private static readonly global::Lua.LuaFunction _LuaShaderUtil_ShaderHasError = new global::Lua.LuaFunction("ShaderHasError", (_context, _) =>
        {
            global::Lua.LuaValue _lastArg = default;
            global::System.Int32 _lastArgPos = default;
            global::System.Type _expectedType = default;
            var _argCount = _context.ArgumentCount;
            var _arg0 = _lastArg = _argCount > 0 ? _context.GetArgument(0) : global::Lua.LuaValue.Nil;
            _lastArgPos = 0; _expectedType = typeof(global::Luny.UnityEngine.LuaShader);
            if (_arg0.TryRead<global::Luny.UnityEngine.LuaShader>(out var _p0_UnityEngine_Shader))
            {
                if (_argCount == 1)
                {
                    var shader = _p0_UnityEngine_Shader.Instance;
                    var _ret0 = global::UnityEditor.ShaderUtil.ShaderHasError(shader);
                    var _lret0 = new global::Lua.LuaValue(_ret0);
                    var _retCount = _context.Return(_lret0);
                    return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                }
            }
            throw new global::Lua.LuaRuntimeException(_context.Thread, $"{"ShaderHasError"}: invalid argument #{_lastArgPos}: {_lastArg} ({_lastArg.Type}), expected: {_expectedType.FullName}", 2);
        });
        private static readonly global::Lua.LuaFunction _LuaShaderUtil_ShaderHasWarnings = new global::Lua.LuaFunction("ShaderHasWarnings", (_context, _) =>
        {
            global::Lua.LuaValue _lastArg = default;
            global::System.Int32 _lastArgPos = default;
            global::System.Type _expectedType = default;
            var _argCount = _context.ArgumentCount;
            var _arg0 = _lastArg = _argCount > 0 ? _context.GetArgument(0) : global::Lua.LuaValue.Nil;
            _lastArgPos = 0; _expectedType = typeof(global::Luny.UnityEngine.LuaShader);
            if (_arg0.TryRead<global::Luny.UnityEngine.LuaShader>(out var _p0_UnityEngine_Shader))
            {
                if (_argCount == 1)
                {
                    var shader = _p0_UnityEngine_Shader.Instance;
                    var _ret0 = global::UnityEditor.ShaderUtil.ShaderHasWarnings(shader);
                    var _lret0 = new global::Lua.LuaValue(_ret0);
                    var _retCount = _context.Return(_lret0);
                    return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                }
            }
            throw new global::Lua.LuaRuntimeException(_context.Thread, $"{"ShaderHasWarnings"}: invalid argument #{_lastArgPos}: {_lastArg} ({_lastArg.Type}), expected: {_expectedType.FullName}", 2);
        });
        private static readonly global::Lua.LuaFunction _LuaShaderUtil_UpdateShaderAsset = new global::Lua.LuaFunction("UpdateShaderAsset", (_context, _) =>
        {
            global::Lua.LuaValue _lastArg = default;
            global::System.Int32 _lastArgPos = default;
            global::System.Type _expectedType = default;
            var _argCount = _context.ArgumentCount;
            var _arg0 = _lastArg = _argCount > 0 ? _context.GetArgument(0) : global::Lua.LuaValue.Nil;
            _lastArgPos = 0; _expectedType = typeof(global::Luny.UnityEngine.LuaShader);
            if (_arg0.TryRead<global::Luny.UnityEngine.LuaShader>(out var _p0_UnityEngine_Shader))
            {
                var _arg1 = _lastArg = _argCount > 1 ? _context.GetArgument(1) : global::Lua.LuaValue.Nil;
                _lastArgPos = 1; _expectedType = typeof(global::System.String);
                if (_arg1.TryRead<global::System.String>(out var _p1_System_String))
                {
                    if (_argCount == 2)
                    {
                        var shader = _p0_UnityEngine_Shader.Instance;
                        var source = _p1_System_String;
                        global::UnityEditor.ShaderUtil.UpdateShaderAsset(shader, source);
                        var _retCount = _context.Return();
                        return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                    }
                    var _arg2 = _lastArg = _argCount > 2 ? _context.GetArgument(2) : global::Lua.LuaValue.Nil;
                    _lastArgPos = 2; _expectedType = typeof(global::System.Boolean);
                    if (_arg2.TryRead<global::System.Boolean>(out var _p2_System_Boolean))
                    {
                        if (_argCount == 3)
                        {
                            var shader = _p0_UnityEngine_Shader.Instance;
                            var source = _p1_System_String;
                            var compileInitialShaderVariants = _p2_System_Boolean;
                            global::UnityEditor.ShaderUtil.UpdateShaderAsset(shader, source, compileInitialShaderVariants);
                            var _retCount = _context.Return();
                            return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                        }
                    }
                }
            }
            _lastArgPos = 0; _expectedType = typeof(global::LunyEditor.UnityEditor.AssetImporters.LuaAssetImportContext);
            if (_arg0.TryRead<global::LunyEditor.UnityEditor.AssetImporters.LuaAssetImportContext>(out var _p0_UnityEditor_AssetImporters_AssetImportContext))
            {
                var _arg1 = _lastArg = _argCount > 1 ? _context.GetArgument(1) : global::Lua.LuaValue.Nil;
                _lastArgPos = 1; _expectedType = typeof(global::Luny.UnityEngine.LuaShader);
                if (_arg1.TryRead<global::Luny.UnityEngine.LuaShader>(out var _p1_UnityEngine_Shader))
                {
                    var _arg2 = _lastArg = _argCount > 2 ? _context.GetArgument(2) : global::Lua.LuaValue.Nil;
                    _lastArgPos = 2; _expectedType = typeof(global::System.String);
                    if (_arg2.TryRead<global::System.String>(out var _p2_System_String))
                    {
                        var _arg3 = _lastArg = _argCount > 3 ? _context.GetArgument(3) : global::Lua.LuaValue.Nil;
                        _lastArgPos = 3; _expectedType = typeof(global::System.Boolean);
                        if (_arg3.TryRead<global::System.Boolean>(out var _p3_System_Boolean))
                        {
                            if (_argCount == 4)
                            {
                                var context = _p0_UnityEditor_AssetImporters_AssetImportContext.Instance;
                                var shader = _p1_UnityEngine_Shader.Instance;
                                var source = _p2_System_String;
                                var compileInitialShaderVariants = _p3_System_Boolean;
                                global::UnityEditor.ShaderUtil.UpdateShaderAsset(context, shader, source, compileInitialShaderVariants);
                                var _retCount = _context.Return();
                                return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                            }
                        }
                    }
                }
            }
            throw new global::Lua.LuaRuntimeException(_context.Thread, $"{"UpdateShaderAsset"}: invalid argument #{_lastArgPos}: {_lastArg} ({_lastArg.Type}), expected: {_expectedType.FullName}", 2);
        });
        private static readonly global::Lua.LuaFunction __index = new(global::Lua.Runtime.Metamethods.Index, (_context, _) =>
        {
            var _this = _context.GetArgument<LuaShaderUtilType>(0);
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
            var _this = _context.GetArgument<LuaShaderUtilType>(0);
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
                case "ClearCachedData": _value = _LuaShaderUtil_ClearCachedData; return true;
                case "ClearShaderMessages": _value = _LuaShaderUtil_ClearShaderMessages; return true;
                case "CompilePass": _value = _LuaShaderUtil_CompilePass; return true;
                case "CreateComputeShaderAsset": _value = _LuaShaderUtil_CreateComputeShaderAsset; return true;
                case "CreateRayTracingShaderAsset": _value = _LuaShaderUtil_CreateRayTracingShaderAsset; return true;
                case "CreateShaderAsset": _value = _LuaShaderUtil_CreateShaderAsset; return true;
                case "GetAllShaderInfo": _value = _LuaShaderUtil_GetAllShaderInfo; return true;
                case "GetCallableShaderCount": _value = _LuaShaderUtil_GetCallableShaderCount; return true;
                case "GetCallableShaderName": _value = _LuaShaderUtil_GetCallableShaderName; return true;
                case "GetCallableShaderParamSize": _value = _LuaShaderUtil_GetCallableShaderParamSize; return true;
                case "GetComputeShaderMessageCount": _value = _LuaShaderUtil_GetComputeShaderMessageCount; return true;
                case "GetComputeShaderMessages": _value = _LuaShaderUtil_GetComputeShaderMessages; return true;
                case "GetCurrentCustomEditor": _value = _LuaShaderUtil_GetCurrentCustomEditor; return true;
                case "GetCustomEditorForRenderPipeline": _value = _LuaShaderUtil_GetCustomEditorForRenderPipeline; return true;
                case "GetMissShaderCount": _value = _LuaShaderUtil_GetMissShaderCount; return true;
                case "GetMissShaderName": _value = _LuaShaderUtil_GetMissShaderName; return true;
                case "GetMissShaderRayPayloadSize": _value = _LuaShaderUtil_GetMissShaderRayPayloadSize; return true;
                case "GetPropertyCount": _value = _LuaShaderUtil_GetPropertyCount; return true;
                case "GetPropertyDescription": _value = _LuaShaderUtil_GetPropertyDescription; return true;
                case "GetPropertyName": _value = _LuaShaderUtil_GetPropertyName; return true;
                case "GetPropertyType": _value = _LuaShaderUtil_GetPropertyType; return true;
                case "GetRangeLimits": _value = _LuaShaderUtil_GetRangeLimits; return true;
                case "GetRayGenerationShaderCount": _value = _LuaShaderUtil_GetRayGenerationShaderCount; return true;
                case "GetRayGenerationShaderName": _value = _LuaShaderUtil_GetRayGenerationShaderName; return true;
                case "GetRayTracingShaderMessageCount": _value = _LuaShaderUtil_GetRayTracingShaderMessageCount; return true;
                case "GetRayTracingShaderMessages": _value = _LuaShaderUtil_GetRayTracingShaderMessages; return true;
                case "GetShaderData": _value = _LuaShaderUtil_GetShaderData; return true;
                case "GetShaderInfo": _value = _LuaShaderUtil_GetShaderInfo; return true;
                case "GetShaderMessageCount": _value = _LuaShaderUtil_GetShaderMessageCount; return true;
                case "GetShaderMessages": _value = _LuaShaderUtil_GetShaderMessages; return true;
                case "GetShaderPlatformKeywordsForBuildTarget": _value = _LuaShaderUtil_GetShaderPlatformKeywordsForBuildTarget; return true;
                case "GetTexDim": _value = _LuaShaderUtil_GetTexDim; return true;
                case "HasProceduralInstancing": _value = _LuaShaderUtil_HasProceduralInstancing; return true;
                case "IsPassCompiled": _value = _LuaShaderUtil_IsPassCompiled; return true;
                case "IsShaderPropertyHidden": _value = _LuaShaderUtil_IsShaderPropertyHidden; return true;
                case "IsShaderPropertyNonModifiableTexureProperty": _value = _LuaShaderUtil_IsShaderPropertyNonModifiableTexureProperty; return true;
                case "RegisterShader": _value = _LuaShaderUtil_RegisterShader; return true;
                case "RestoreAsyncCompilation": _value = _LuaShaderUtil_RestoreAsyncCompilation; return true;
                case "SetAsyncCompilation": _value = _LuaShaderUtil_SetAsyncCompilation; return true;
                case "ShaderHasError": _value = _LuaShaderUtil_ShaderHasError; return true;
                case "ShaderHasWarnings": _value = _LuaShaderUtil_ShaderHasWarnings; return true;
                case "UpdateShaderAsset": _value = _LuaShaderUtil_UpdateShaderAsset; return true;
                case "allowAsyncCompilation": _value = new global::Lua.LuaValue(global::UnityEditor.ShaderUtil.allowAsyncCompilation); return true;
                case "anythingCompiling": _value = new global::Lua.LuaValue(global::UnityEditor.ShaderUtil.anythingCompiling); return true;
                case "disableShaderOptimization": _value = new global::Lua.LuaValue(global::UnityEditor.ShaderUtil.disableShaderOptimization); return true;
                case "hardwareSupportsRectRenderTexture": _value = new global::Lua.LuaValue(global::UnityEditor.ShaderUtil.hardwareSupportsRectRenderTexture); return true;
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
                case "allowAsyncCompilation": global::UnityEditor.ShaderUtil.allowAsyncCompilation = _value.Read<global::System.Boolean>();  return true;
                case "disableShaderOptimization": global::UnityEditor.ShaderUtil.disableShaderOptimization = _value.Read<global::System.Boolean>();  return true;
                default: return false;
            }
        }
    }
}
#pragma warning restore 0109, 0162, 0168, 0219
#endif
