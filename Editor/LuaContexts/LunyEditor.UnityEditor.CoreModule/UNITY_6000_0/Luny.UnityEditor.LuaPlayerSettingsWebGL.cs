
// --------------------------------------------------------------
// GENERATED FILE ----> DO NOT EDIT <---- CHANGES WILL BE LOST !!
// --------------------------------------------------------------

#if UNITY_6000_0_OR_NEWER && !(UNITY_6000_1_OR_NEWER)
#pragma warning disable 0109, 0162, 0168, 0219
using Luny;

namespace Luny.UnityEditor
{
    public sealed class LuaPlayerSettingsWebGL : global::Luny.ILuaObject<global::UnityEditor.PlayerSettings.WebGL>
    {
        public new static global::Lua.LuaValue Bind(global::UnityEditor.PlayerSettings.WebGL instance) => new LuaPlayerSettingsWebGL(instance);
        public new static global::Lua.LuaValue Bind(global::System.Object instance) => Bind((global::UnityEditor.PlayerSettings.WebGL)instance);
        public new static global::Lua.LuaValue Bind(global::System.Collections.Generic.IList<global::UnityEditor.PlayerSettings.WebGL> instances) =>
            new global::Luny.LuaList<global::UnityEditor.PlayerSettings.WebGL>(instances);
        public new static global::Lua.LuaValue Bind(global::System.Collections.Generic.IList<global::System.Object> instances) =>
            new global::Luny.LuaList<global::UnityEditor.PlayerSettings.WebGL>(instances);
        private LuaPlayerSettingsWebGL(global::UnityEditor.PlayerSettings.WebGL instance) => m_Instance = instance;
        public static implicit operator global::Lua.LuaValue(LuaPlayerSettingsWebGL value) => new(value);
        private global::UnityEditor.PlayerSettings.WebGL m_Instance;
        public global::UnityEditor.PlayerSettings.WebGL Instance => m_Instance;
        public new global::System.Type BindType => typeof(global::UnityEditor.PlayerSettings.WebGL);
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
            var _this = _context.GetArgument<LuaPlayerSettingsWebGL>(0);
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
            var _this = _context.GetArgument<LuaPlayerSettingsWebGL>(0);
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
    public sealed class LuaPlayerSettingsWebGLType : global::Luny.ILuaStatic
    {
        public static global::Lua.LuaValue Bind() => new LuaPlayerSettingsWebGLType();
        private LuaPlayerSettingsWebGLType() {}
        public static implicit operator global::Lua.LuaValue(LuaPlayerSettingsWebGLType value) => new(value);
        public global::System.Type BindType => typeof(global::UnityEditor.PlayerSettings.WebGL);
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
            metatable[global::Lua.Runtime.Metamethods.Call] = _LuaPlayerSettingsWebGL_new;
            return metatable;
        }
        public override global::System.String ToString() => BindType.FullName;
#if UNITY_EDITOR
        [global::UnityEngine.RuntimeInitializeOnLoadMethod(global::UnityEngine.RuntimeInitializeLoadType.SubsystemRegistration)]
        private static void ResetStaticFields() => s_Metatable = null;
#endif

        private static readonly global::Lua.LuaFunction _LuaPlayerSettingsWebGL_new = new global::Lua.LuaFunction(".ctor", (_context, _) =>
        {
            global::Lua.LuaValue _lastArg = default;
            global::System.Int32 _lastArgPos = default;
            global::System.Type _expectedType = default;
            var _argCount = _context.ArgumentCount;
            if (_argCount == 1)
            {
                var _ret0 = new global::UnityEditor.PlayerSettings.WebGL();
                var _factory = _context.GetObjectFactory();
                var _lret0 = _factory.Bind(_ret0);
                var _retCount = _context.Return(_lret0);
                return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
            }
            throw new global::Lua.LuaRuntimeException(_context.Thread, $"{".ctor"}: invalid argument #{_lastArgPos}: {_lastArg} ({_lastArg.Type}), expected: {_expectedType.FullName}", 2);
        });
        private static readonly global::Lua.LuaFunction __index = new(global::Lua.Runtime.Metamethods.Index, (_context, _) =>
        {
            var _this = _context.GetArgument<LuaPlayerSettingsWebGLType>(0);
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
            var _this = _context.GetArgument<LuaPlayerSettingsWebGLType>(0);
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
                case "analyzeBuildSize": _value = new global::Lua.LuaValue(global::UnityEditor.PlayerSettings.WebGL.analyzeBuildSize); return true;
                case "closeOnQuit": _value = new global::Lua.LuaValue(global::UnityEditor.PlayerSettings.WebGL.closeOnQuit); return true;
                case "compressionFormat": _value = new global::Lua.LuaValue((global::System.Int64)global::UnityEditor.PlayerSettings.WebGL.compressionFormat); return true;
                case "dataCaching": _value = new global::Lua.LuaValue(global::UnityEditor.PlayerSettings.WebGL.dataCaching); return true;
                case "debugSymbolMode": _value = new global::Lua.LuaValue((global::System.Int64)global::UnityEditor.PlayerSettings.WebGL.debugSymbolMode); return true;
                case "decompressionFallback": _value = new global::Lua.LuaValue(global::UnityEditor.PlayerSettings.WebGL.decompressionFallback); return true;
                case "emscriptenArgs": _value = new global::Lua.LuaValue(global::UnityEditor.PlayerSettings.WebGL.emscriptenArgs); return true;
                case "enableWebGPU": _value = new global::Lua.LuaValue(global::UnityEditor.PlayerSettings.WebGL.enableWebGPU); return true;
                case "exceptionSupport": _value = new global::Lua.LuaValue((global::System.Int64)global::UnityEditor.PlayerSettings.WebGL.exceptionSupport); return true;
                case "geometricMemoryGrowthStep": _value = new global::Lua.LuaValue(global::UnityEditor.PlayerSettings.WebGL.geometricMemoryGrowthStep); return true;
                case "initialMemorySize": _value = new global::Lua.LuaValue(global::UnityEditor.PlayerSettings.WebGL.initialMemorySize); return true;
                case "linearMemoryGrowthStep": _value = new global::Lua.LuaValue(global::UnityEditor.PlayerSettings.WebGL.linearMemoryGrowthStep); return true;
                case "linkerTarget": _value = new global::Lua.LuaValue((global::System.Int64)global::UnityEditor.PlayerSettings.WebGL.linkerTarget); return true;
                case "maximumMemorySize": _value = new global::Lua.LuaValue(global::UnityEditor.PlayerSettings.WebGL.maximumMemorySize); return true;
                case "memoryGeometricGrowthCap": _value = new global::Lua.LuaValue(global::UnityEditor.PlayerSettings.WebGL.memoryGeometricGrowthCap); return true;
                case "memoryGrowthMode": _value = new global::Lua.LuaValue((global::System.Int64)global::UnityEditor.PlayerSettings.WebGL.memoryGrowthMode); return true;
                case "memorySize": _value = new global::Lua.LuaValue(global::UnityEditor.PlayerSettings.WebGL.memorySize); return true;
                case "modulesDirectory": _value = new global::Lua.LuaValue(global::UnityEditor.PlayerSettings.WebGL.modulesDirectory); return true;
                case "nameFilesAsHashes": _value = new global::Lua.LuaValue(global::UnityEditor.PlayerSettings.WebGL.nameFilesAsHashes); return true;
                case "powerPreference": _value = new global::Lua.LuaValue((global::System.Int64)global::UnityEditor.PlayerSettings.WebGL.powerPreference); return true;
                case "showDiagnostics": _value = new global::Lua.LuaValue(global::UnityEditor.PlayerSettings.WebGL.showDiagnostics); return true;
                case "template": _value = new global::Lua.LuaValue(global::UnityEditor.PlayerSettings.WebGL.template); return true;
                case "threadsSupport": _value = new global::Lua.LuaValue(global::UnityEditor.PlayerSettings.WebGL.threadsSupport); return true;
                case "useEmbeddedResources": _value = new global::Lua.LuaValue(global::UnityEditor.PlayerSettings.WebGL.useEmbeddedResources); return true;
                case "wasm2023": _value = new global::Lua.LuaValue(global::UnityEditor.PlayerSettings.WebGL.wasm2023); return true;
                case "wasmArithmeticExceptions": _value = new global::Lua.LuaValue((global::System.Int64)global::UnityEditor.PlayerSettings.WebGL.wasmArithmeticExceptions); return true;
                case "webAssemblyBigInt": _value = new global::Lua.LuaValue(global::UnityEditor.PlayerSettings.WebGL.webAssemblyBigInt); return true;
                case "webAssemblyTable": _value = new global::Lua.LuaValue(global::UnityEditor.PlayerSettings.WebGL.webAssemblyTable); return true;
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
                case "analyzeBuildSize": global::UnityEditor.PlayerSettings.WebGL.analyzeBuildSize = _value.Read<global::System.Boolean>();  return true;
                case "closeOnQuit": global::UnityEditor.PlayerSettings.WebGL.closeOnQuit = _value.Read<global::System.Boolean>();  return true;
                case "compressionFormat": global::UnityEditor.PlayerSettings.WebGL.compressionFormat = _value.Read<global::UnityEditor.WebGLCompressionFormat>();  return true;
                case "dataCaching": global::UnityEditor.PlayerSettings.WebGL.dataCaching = _value.Read<global::System.Boolean>();  return true;
                case "debugSymbolMode": global::UnityEditor.PlayerSettings.WebGL.debugSymbolMode = _value.Read<global::UnityEditor.WebGLDebugSymbolMode>();  return true;
                case "decompressionFallback": global::UnityEditor.PlayerSettings.WebGL.decompressionFallback = _value.Read<global::System.Boolean>();  return true;
                case "emscriptenArgs": global::UnityEditor.PlayerSettings.WebGL.emscriptenArgs = _value.Read<global::System.String>();  return true;
                case "enableWebGPU": global::UnityEditor.PlayerSettings.WebGL.enableWebGPU = _value.Read<global::System.Boolean>();  return true;
                case "exceptionSupport": global::UnityEditor.PlayerSettings.WebGL.exceptionSupport = _value.Read<global::UnityEditor.WebGLExceptionSupport>();  return true;
                case "geometricMemoryGrowthStep": global::UnityEditor.PlayerSettings.WebGL.geometricMemoryGrowthStep = _value.Read<global::System.Single>();  return true;
                case "initialMemorySize": global::UnityEditor.PlayerSettings.WebGL.initialMemorySize = _value.Read<global::System.Int32>();  return true;
                case "linearMemoryGrowthStep": global::UnityEditor.PlayerSettings.WebGL.linearMemoryGrowthStep = _value.Read<global::System.Int32>();  return true;
                case "linkerTarget": global::UnityEditor.PlayerSettings.WebGL.linkerTarget = _value.Read<global::UnityEditor.WebGLLinkerTarget>();  return true;
                case "maximumMemorySize": global::UnityEditor.PlayerSettings.WebGL.maximumMemorySize = _value.Read<global::System.Int32>();  return true;
                case "memoryGeometricGrowthCap": global::UnityEditor.PlayerSettings.WebGL.memoryGeometricGrowthCap = _value.Read<global::System.Int32>();  return true;
                case "memoryGrowthMode": global::UnityEditor.PlayerSettings.WebGL.memoryGrowthMode = _value.Read<global::UnityEditor.WebGLMemoryGrowthMode>();  return true;
                case "memorySize": global::UnityEditor.PlayerSettings.WebGL.memorySize = _value.Read<global::System.Int32>();  return true;
                case "modulesDirectory": global::UnityEditor.PlayerSettings.WebGL.modulesDirectory = _value.Read<global::System.String>();  return true;
                case "nameFilesAsHashes": global::UnityEditor.PlayerSettings.WebGL.nameFilesAsHashes = _value.Read<global::System.Boolean>();  return true;
                case "powerPreference": global::UnityEditor.PlayerSettings.WebGL.powerPreference = _value.Read<global::UnityEditor.WebGLPowerPreference>();  return true;
                case "showDiagnostics": global::UnityEditor.PlayerSettings.WebGL.showDiagnostics = _value.Read<global::System.Boolean>();  return true;
                case "template": global::UnityEditor.PlayerSettings.WebGL.template = _value.Read<global::System.String>();  return true;
                case "threadsSupport": global::UnityEditor.PlayerSettings.WebGL.threadsSupport = _value.Read<global::System.Boolean>();  return true;
                case "useEmbeddedResources": global::UnityEditor.PlayerSettings.WebGL.useEmbeddedResources = _value.Read<global::System.Boolean>();  return true;
                case "wasm2023": global::UnityEditor.PlayerSettings.WebGL.wasm2023 = _value.Read<global::System.Boolean>();  return true;
                case "wasmArithmeticExceptions": global::UnityEditor.PlayerSettings.WebGL.wasmArithmeticExceptions = _value.Read<global::UnityEditor.WebGLWasmArithmeticExceptions>();  return true;
                case "webAssemblyBigInt": global::UnityEditor.PlayerSettings.WebGL.webAssemblyBigInt = _value.Read<global::System.Boolean>();  return true;
                case "webAssemblyTable": global::UnityEditor.PlayerSettings.WebGL.webAssemblyTable = _value.Read<global::System.Boolean>();  return true;
                default: return false;
            }
        }
    }
}
#pragma warning restore 0109, 0162, 0168, 0219
#endif
