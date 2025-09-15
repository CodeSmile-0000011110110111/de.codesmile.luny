
// --------------------------------------------------------------
// GENERATED FILE ----> DO NOT EDIT <---- CHANGES WILL BE LOST !!
// --------------------------------------------------------------

#if UNITY_6000_1_OR_NEWER && !(UNITY_6000_2_OR_NEWER)
#pragma warning disable 0109, 0162, 0168, 0219
using Luny;

namespace LunyEditor.UnityEditor.Compilation
{
    public class LuaScriptCompilerOptions : global::Luny.ILuaObject<global::UnityEditor.Compilation.ScriptCompilerOptions>
    {
        public new static global::Lua.LuaValue Bind(global::UnityEditor.Compilation.ScriptCompilerOptions instance) => new LuaScriptCompilerOptions(instance);
        public new static global::Lua.LuaValue Bind(global::System.Object instance) => Bind((global::UnityEditor.Compilation.ScriptCompilerOptions)instance);
        public new static global::Lua.LuaValue Bind(global::System.Collections.Generic.IList<global::UnityEditor.Compilation.ScriptCompilerOptions> instances) =>
            new global::Luny.LuaList<global::UnityEditor.Compilation.ScriptCompilerOptions>(instances);
        public new static global::Lua.LuaValue Bind(global::System.Collections.Generic.IList<global::System.Object> instances) =>
            new global::Luny.LuaList<global::UnityEditor.Compilation.ScriptCompilerOptions>(instances);
        protected LuaScriptCompilerOptions(global::UnityEditor.Compilation.ScriptCompilerOptions instance) => m_Instance = instance;
        public static implicit operator global::Lua.LuaValue(LuaScriptCompilerOptions value) => new(value);
        protected global::UnityEditor.Compilation.ScriptCompilerOptions m_Instance;
        public global::UnityEditor.Compilation.ScriptCompilerOptions Instance => m_Instance;
        public new global::System.Type BindType => typeof(global::UnityEditor.Compilation.ScriptCompilerOptions);
        public override global::System.String ToString() => m_Instance != null ? Instance.ToString() : "{GetType().Name}(null)";
#if UNITY_EDITOR
        [global::UnityEngine.RuntimeInitializeOnLoadMethod(global::UnityEngine.RuntimeInitializeLoadType.SubsystemRegistration)]
        private static void ResetStaticFields() => s_Metatable = null;
#endif

        private static readonly global::Lua.LuaFunction __index = new(global::Lua.Runtime.Metamethods.Index, (_context, _) =>
        {
            var _this = _context.GetArgument<LuaScriptCompilerOptions>(0);
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
            var _this = _context.GetArgument<LuaScriptCompilerOptions>(0);
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
                case "AdditionalCompilerArguments": _value = _factory.Bind(Instance.AdditionalCompilerArguments); return true;
                case "AllowUnsafeCode": _value = new global::Lua.LuaValue(Instance.AllowUnsafeCode); return true;
                case "AnalyzerConfigPath": _value = new global::Lua.LuaValue(Instance.AnalyzerConfigPath); return true;
                case "ApiCompatibilityLevel": _value = new global::Lua.LuaValue((global::System.Int64)Instance.ApiCompatibilityLevel); return true;
                case "CodeOptimization": _value = new global::Lua.LuaValue((global::System.Int64)Instance.CodeOptimization); return true;
                case "EditorAssembliesCompatibilityLevel": _value = new global::Lua.LuaValue((global::System.Int64)Instance.EditorAssembliesCompatibilityLevel); return true;
                case "LanguageVersion": _value = new global::Lua.LuaValue(Instance.LanguageVersion); return true;
                case "ResponseFiles": _value = _factory.Bind(Instance.ResponseFiles); return true;
                case "RoslynAdditionalFilePaths": _value = _factory.Bind(Instance.RoslynAdditionalFilePaths); return true;
                case "RoslynAnalyzerDllPaths": _value = _factory.Bind(Instance.RoslynAnalyzerDllPaths); return true;
                case "RoslynAnalyzerRulesetPath": _value = new global::Lua.LuaValue(Instance.RoslynAnalyzerRulesetPath); return true;
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
                case "AdditionalCompilerArguments": Instance.AdditionalCompilerArguments = _value.Read<global::System.String[]>();  return true;
                case "AllowUnsafeCode": Instance.AllowUnsafeCode = _value.Read<global::System.Boolean>();  return true;
                case "AnalyzerConfigPath": Instance.AnalyzerConfigPath = _value.Read<global::System.String>();  return true;
                case "ApiCompatibilityLevel": Instance.ApiCompatibilityLevel = _value.Read<global::UnityEditor.ApiCompatibilityLevel>();  return true;
                case "CodeOptimization": Instance.CodeOptimization = _value.Read<global::UnityEditor.Compilation.CodeOptimization>();  return true;
                case "EditorAssembliesCompatibilityLevel": Instance.EditorAssembliesCompatibilityLevel = _value.Read<global::UnityEditor.EditorAssembliesCompatibilityLevel>();  return true;
                case "ResponseFiles": Instance.ResponseFiles = _value.Read<global::System.String[]>();  return true;
                case "RoslynAdditionalFilePaths": Instance.RoslynAdditionalFilePaths = _value.Read<global::System.String[]>();  return true;
                case "RoslynAnalyzerDllPaths": Instance.RoslynAnalyzerDllPaths = _value.Read<global::System.String[]>();  return true;
                case "RoslynAnalyzerRulesetPath": Instance.RoslynAnalyzerRulesetPath = _value.Read<global::System.String>();  return true;
                default: return false;
            }
        }
    }
    public sealed class LuaScriptCompilerOptionsType : global::Luny.ILuaStatic
    {
        public static global::Lua.LuaValue Bind() => new LuaScriptCompilerOptionsType();
        private LuaScriptCompilerOptionsType() {}
        public static implicit operator global::Lua.LuaValue(LuaScriptCompilerOptionsType value) => new(value);
        public global::System.Type BindType => typeof(global::UnityEditor.Compilation.ScriptCompilerOptions);
        public override global::System.String ToString() => BindType.FullName;
#if UNITY_EDITOR
        [global::UnityEngine.RuntimeInitializeOnLoadMethod(global::UnityEngine.RuntimeInitializeLoadType.SubsystemRegistration)]
        private static void ResetStaticFields() => s_Metatable = null;
#endif

        private static readonly global::Lua.LuaFunction _LuaScriptCompilerOptions_new = new global::Lua.LuaFunction(".ctor", (_context, _) =>
        {
            global::Lua.LuaValue _lastArg = default;
            global::System.Int32 _lastArgPos = default;
            global::System.Type _expectedType = default;
            var _argCount = _context.ArgumentCount;
            if (_argCount == 1)
            {
                var _ret0 = new global::UnityEditor.Compilation.ScriptCompilerOptions();
                var _factory = _context.GetObjectFactory();
                var _lret0 = _factory.Bind(_ret0);
                var _retCount = _context.Return(_lret0);
                return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
            }
            throw new global::Lua.LuaRuntimeException(_context.Thread, $"{".ctor"}: invalid argument #{_lastArgPos}: {_lastArg} ({_lastArg.Type}), expected: {_expectedType.FullName}", 2);
        });
        private static readonly global::Lua.LuaFunction __index = new(global::Lua.Runtime.Metamethods.Index, (_context, _) =>
        {
            var _this = _context.GetArgument<LuaScriptCompilerOptionsType>(0);
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
            var _this = _context.GetArgument<LuaScriptCompilerOptionsType>(0);
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
            metatable[global::Lua.Runtime.Metamethods.Call] = _LuaScriptCompilerOptions_new;
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
}
#pragma warning restore 0109, 0162, 0168, 0219
#endif
