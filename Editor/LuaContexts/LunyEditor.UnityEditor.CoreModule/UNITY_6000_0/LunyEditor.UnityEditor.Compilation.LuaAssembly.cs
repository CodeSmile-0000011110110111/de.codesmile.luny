
// --------------------------------------------------------------
// GENERATED FILE ----> DO NOT EDIT <---- CHANGES WILL BE LOST !!
// --------------------------------------------------------------

#if UNITY_6000_0_OR_NEWER && !(UNITY_6000_1_OR_NEWER)
#pragma warning disable 0109, 0162, 0168, 0219
using Luny;

namespace LunyEditor.UnityEditor.Compilation
{
    public class LuaAssembly : global::Luny.ILuaObject<global::UnityEditor.Compilation.Assembly>
    {
        public new static global::Lua.LuaValue Bind(global::UnityEditor.Compilation.Assembly instance) => new LuaAssembly(instance);
        public new static global::Lua.LuaValue Bind(global::System.Object instance) => Bind((global::UnityEditor.Compilation.Assembly)instance);
        public new static global::Lua.LuaValue Bind(global::System.Collections.Generic.IList<global::UnityEditor.Compilation.Assembly> instances) =>
            new global::Luny.LuaList<global::UnityEditor.Compilation.Assembly>(instances);
        public new static global::Lua.LuaValue Bind(global::System.Collections.Generic.IList<global::System.Object> instances) =>
            new global::Luny.LuaList<global::UnityEditor.Compilation.Assembly>(instances);
        protected LuaAssembly(global::UnityEditor.Compilation.Assembly instance) => m_Instance = instance;
        public static implicit operator global::Lua.LuaValue(LuaAssembly value) => new(value);
        protected global::UnityEditor.Compilation.Assembly m_Instance;
        public global::UnityEditor.Compilation.Assembly Instance => m_Instance;
        public new global::System.Type BindType => typeof(global::UnityEditor.Compilation.Assembly);
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
            var _this = _context.GetArgument<LuaAssembly>(0);
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
            var _this = _context.GetArgument<LuaAssembly>(0);
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
                case "allReferences": _value = _factory.Bind(Instance.allReferences); return true;
                case "assemblyReferences": _value = _factory.Bind(Instance.assemblyReferences); return true;
                case "compiledAssemblyReferences": _value = _factory.Bind(Instance.compiledAssemblyReferences); return true;
                case "compilerOptions": _value = _factory.Bind(Instance.compilerOptions); return true;
                case "defines": _value = _factory.Bind(Instance.defines); return true;
                case "flags": _value = new global::Lua.LuaValue((global::System.Int64)Instance.flags); return true;
                case "name": _value = new global::Lua.LuaValue(Instance.name); return true;
                case "outputPath": _value = new global::Lua.LuaValue(Instance.outputPath); return true;
                case "rootNamespace": _value = new global::Lua.LuaValue(Instance.rootNamespace); return true;
                case "sourceFiles": _value = _factory.Bind(Instance.sourceFiles); return true;
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
    public sealed class LuaAssemblyType : global::Luny.ILuaStatic
    {
        public static global::Lua.LuaValue Bind() => new LuaAssemblyType();
        private LuaAssemblyType() {}
        public static implicit operator global::Lua.LuaValue(LuaAssemblyType value) => new(value);
        public global::System.Type BindType => typeof(global::UnityEditor.Compilation.Assembly);
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
            metatable[global::Lua.Runtime.Metamethods.Call] = _LuaAssembly_new;
            return metatable;
        }
        public override global::System.String ToString() => BindType.FullName;
#if UNITY_EDITOR
        [global::UnityEngine.RuntimeInitializeOnLoadMethod(global::UnityEngine.RuntimeInitializeLoadType.SubsystemRegistration)]
        private static void ResetStaticFields() => s_Metatable = null;
#endif

        private static readonly global::Lua.LuaFunction _LuaAssembly_new = new global::Lua.LuaFunction(".ctor", (_context, _) =>
        {
            global::Lua.LuaValue _lastArg = default;
            global::System.Int32 _lastArgPos = default;
            global::System.Type _expectedType = default;
            var _argCount = _context.ArgumentCount;
            var _arg0 = _lastArg = _argCount > 1 ? _context.GetArgument(1) : global::Lua.LuaValue.Nil;
            _lastArgPos = 0; _expectedType = typeof(global::System.String);
            if (_arg0.TryRead<global::System.String>(out var _p0_System_String))
            {
                var _arg1 = _lastArg = _argCount > 2 ? _context.GetArgument(2) : global::Lua.LuaValue.Nil;
                _lastArgPos = 1; _expectedType = typeof(global::System.String);
                if (_arg1.TryRead<global::System.String>(out var _p1_System_String))
                {
                    var _arg2 = _lastArg = _argCount > 3 ? _context.GetArgument(3) : global::Lua.LuaValue.Nil;
                    _lastArgPos = 2; _expectedType = typeof(global::System.String[]);
                    if (_arg2.TryReadArray<global::System.String>(out var _p2_System_StringArray))
                    {
                        var _arg3 = _lastArg = _argCount > 4 ? _context.GetArgument(4) : global::Lua.LuaValue.Nil;
                        _lastArgPos = 3; _expectedType = typeof(global::System.String[]);
                        if (_arg3.TryReadArray<global::System.String>(out var _p3_System_StringArray))
                        {
                            var _arg4 = _lastArg = _argCount > 5 ? _context.GetArgument(5) : global::Lua.LuaValue.Nil;
                            _lastArgPos = 4; _expectedType = typeof(global::UnityEditor.Compilation.Assembly[]);
                            if (_arg4.TryReadArray<global::UnityEditor.Compilation.Assembly>(out var _p4_UnityEditor_Compilation_AssemblyArray))
                            {
                                var _arg5 = _lastArg = _argCount > 6 ? _context.GetArgument(6) : global::Lua.LuaValue.Nil;
                                _lastArgPos = 5; _expectedType = typeof(global::System.String[]);
                                if (_arg5.TryReadArray<global::System.String>(out var _p5_System_StringArray))
                                {
                                    var _arg6 = _lastArg = _argCount > 7 ? _context.GetArgument(7) : global::Lua.LuaValue.Nil;
                                    _lastArgPos = 6; _expectedType = typeof(global::UnityEditor.Compilation.AssemblyFlags);
                                    if (_arg6.TryRead<global::UnityEditor.Compilation.AssemblyFlags>(out var _p6_UnityEditor_Compilation_AssemblyFlags))
                                    {
                                        if (_argCount == 8)
                                        {
                                            var name = _p0_System_String;
                                            var outputPath = _p1_System_String;
                                            var sourceFiles = _p2_System_StringArray;
                                            var defines = _p3_System_StringArray;
                                            var assemblyReferences = _p4_UnityEditor_Compilation_AssemblyArray;
                                            var compiledAssemblyReferences = _p5_System_StringArray;
                                            var flags = _p6_UnityEditor_Compilation_AssemblyFlags;
                                            var _ret0 = new global::UnityEditor.Compilation.Assembly(name, outputPath, sourceFiles, defines, assemblyReferences, compiledAssemblyReferences, flags);
                                            var _factory = _context.GetObjectFactory();
                                            var _lret0 = _factory.Bind(_ret0);
                                            var _retCount = _context.Return(_lret0);
                                            return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                                        }
                                        var _arg7 = _lastArg = _argCount > 8 ? _context.GetArgument(8) : global::Lua.LuaValue.Nil;
                                        _lastArgPos = 7; _expectedType = typeof(global::LunyEditor.UnityEditor.Compilation.LuaScriptCompilerOptions);
                                        if (_arg7.TryRead<global::LunyEditor.UnityEditor.Compilation.LuaScriptCompilerOptions>(out var _p7_UnityEditor_Compilation_ScriptCompilerOptions))
                                        {
                                            if (_argCount == 9)
                                            {
                                                var name = _p0_System_String;
                                                var outputPath = _p1_System_String;
                                                var sourceFiles = _p2_System_StringArray;
                                                var defines = _p3_System_StringArray;
                                                var assemblyReferences = _p4_UnityEditor_Compilation_AssemblyArray;
                                                var compiledAssemblyReferences = _p5_System_StringArray;
                                                var flags = _p6_UnityEditor_Compilation_AssemblyFlags;
                                                var compilerOptions = _p7_UnityEditor_Compilation_ScriptCompilerOptions.Instance;
                                                var _ret0 = new global::UnityEditor.Compilation.Assembly(name, outputPath, sourceFiles, defines, assemblyReferences, compiledAssemblyReferences, flags, compilerOptions);
                                                var _factory = _context.GetObjectFactory();
                                                var _lret0 = _factory.Bind(_ret0);
                                                var _retCount = _context.Return(_lret0);
                                                return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                                            }
                                            var _arg8 = _lastArg = _argCount > 9 ? _context.GetArgument(9) : global::Lua.LuaValue.Nil;
                                            _lastArgPos = 8; _expectedType = typeof(global::System.String);
                                            if (_arg8.TryRead<global::System.String>(out var _p8_System_String))
                                            {
                                                if (_argCount == 10)
                                                {
                                                    var name = _p0_System_String;
                                                    var outputPath = _p1_System_String;
                                                    var sourceFiles = _p2_System_StringArray;
                                                    var defines = _p3_System_StringArray;
                                                    var assemblyReferences = _p4_UnityEditor_Compilation_AssemblyArray;
                                                    var compiledAssemblyReferences = _p5_System_StringArray;
                                                    var flags = _p6_UnityEditor_Compilation_AssemblyFlags;
                                                    var compilerOptions = _p7_UnityEditor_Compilation_ScriptCompilerOptions.Instance;
                                                    var rootNamespace = _p8_System_String;
                                                    var _ret0 = new global::UnityEditor.Compilation.Assembly(name, outputPath, sourceFiles, defines, assemblyReferences, compiledAssemblyReferences, flags, compilerOptions, rootNamespace);
                                                    var _factory = _context.GetObjectFactory();
                                                    var _lret0 = _factory.Bind(_ret0);
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
                }
            }
            throw new global::Lua.LuaRuntimeException(_context.Thread, $"{".ctor"}: invalid argument #{_lastArgPos}: {_lastArg} ({_lastArg.Type}), expected: {_expectedType.FullName}", 2);
        });
        private static readonly global::Lua.LuaFunction __index = new(global::Lua.Runtime.Metamethods.Index, (_context, _) =>
        {
            var _this = _context.GetArgument<LuaAssemblyType>(0);
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
            var _this = _context.GetArgument<LuaAssemblyType>(0);
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
