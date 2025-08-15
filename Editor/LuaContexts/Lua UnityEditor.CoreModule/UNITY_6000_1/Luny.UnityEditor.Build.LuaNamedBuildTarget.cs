
// --------------------------------------------------------------
// GENERATED FILE ----> DO NOT EDIT <---- CHANGES WILL BE LOST !!
// --------------------------------------------------------------

#if UNITY_6000_1_OR_NEWER && !(UNITY_6000_2_OR_NEWER)
#pragma warning disable 0109, 0162, 0168, 0219
using Luny;

namespace Luny.UnityEditor.Build
{
    public sealed class LuaNamedBuildTarget : global::Luny.ILuaValueType<global::UnityEditor.Build.NamedBuildTarget>
    {
        public new static global::Lua.LuaValue Bind(in global::UnityEditor.Build.NamedBuildTarget instance) => new LuaNamedBuildTarget(instance);
        public new static global::Lua.LuaValue Bind(global::System.Object instance) => Bind((global::UnityEditor.Build.NamedBuildTarget)instance);
        public new static global::Lua.LuaValue Bind(global::System.Collections.Generic.IList<global::UnityEditor.Build.NamedBuildTarget> instances) =>
            new global::Luny.LuaList<global::UnityEditor.Build.NamedBuildTarget>(instances);
        public new static global::Lua.LuaValue Bind(global::System.Collections.Generic.IList<global::System.Object> instances) =>
            new global::Luny.LuaList<global::UnityEditor.Build.NamedBuildTarget>(instances);
        private LuaNamedBuildTarget(in global::UnityEditor.Build.NamedBuildTarget value) => m_Value = value;
        public static implicit operator global::Lua.LuaValue(LuaNamedBuildTarget value) => new(value);
        private global::UnityEditor.Build.NamedBuildTarget m_Value;
        public global::UnityEditor.Build.NamedBuildTarget Value { get => m_Value; set => m_Value = value; }
        public ref global::UnityEditor.Build.NamedBuildTarget ValueRef => ref m_Value;
        public global::System.Type BindType => typeof(global::UnityEditor.Build.NamedBuildTarget);
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
        public override global::System.String ToString() => m_Value.ToString();
#if UNITY_EDITOR
        [global::UnityEngine.RuntimeInitializeOnLoadMethod(global::UnityEngine.RuntimeInitializeLoadType.SubsystemRegistration)]
        private static void ResetStaticFields() => s_Metatable = null;
#endif

        private static readonly global::Lua.LuaFunction _LuaNamedBuildTarget_CompareTo = new global::Lua.LuaFunction("CompareTo", (_context, _) =>
        {
            global::Lua.LuaValue _lastArg = default;
            global::System.Int32 _lastArgPos = default;
            global::System.Type _expectedType = default;
            var _argCount = _context.ArgumentCount;
            var _this = _context.GetArgument<LuaNamedBuildTarget>(0);
            var _arg0 = _lastArg = _argCount > 1 ? _context.GetArgument(1) : global::Lua.LuaValue.Nil;
            _lastArgPos = 0; _expectedType = typeof(global::Luny.UnityEditor.Build.LuaNamedBuildTarget);
            if (_arg0.TryRead<global::Luny.UnityEditor.Build.LuaNamedBuildTarget>(out var _p0_UnityEditor_Build_NamedBuildTarget))
            {
                if (_argCount == 2)
                {
                    var other = _p0_UnityEditor_Build_NamedBuildTarget.Value;
                    var _ret0 = _this.m_Value.CompareTo(other);
                    var _lret0 = new global::Lua.LuaValue(_ret0);
                    var _retCount = _context.Return(_lret0);
                    return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                }
            }
            throw new global::Lua.LuaRuntimeException(_context.Thread, $"{"CompareTo"}: invalid argument #{_lastArgPos}: {_lastArg} ({_lastArg.Type}), expected: {_expectedType.FullName}", 2);
        });
        private static readonly global::Lua.LuaFunction _LuaNamedBuildTarget_Equals = new global::Lua.LuaFunction("Equals", (_context, _) =>
        {
            global::Lua.LuaValue _lastArg = default;
            global::System.Int32 _lastArgPos = default;
            global::System.Type _expectedType = default;
            var _argCount = _context.ArgumentCount;
            var _this = _context.GetArgument<LuaNamedBuildTarget>(0);
            var _arg0 = _lastArg = _argCount > 1 ? _context.GetArgument(1) : global::Lua.LuaValue.Nil;
            _lastArgPos = 0; _expectedType = typeof(global::Luny.UnityEditor.Build.LuaNamedBuildTarget);
            if (_arg0.TryRead<global::Luny.UnityEditor.Build.LuaNamedBuildTarget>(out var _p0_UnityEditor_Build_NamedBuildTarget))
            {
                if (_argCount == 2)
                {
                    var other = _p0_UnityEditor_Build_NamedBuildTarget.Value;
                    var _ret0 = _this.m_Value.Equals(other);
                    var _lret0 = new global::Lua.LuaValue(_ret0);
                    var _retCount = _context.Return(_lret0);
                    return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                }
            }
            _lastArgPos = 0; _expectedType = typeof(global::System.Object);
            if (_arg0.TryRead<global::System.Object>(out var _p0_System_Object))
            {
                if (_argCount == 2)
                {
                    var obj = _p0_System_Object;
                    var _ret0 = _this.m_Value.Equals(obj);
                    var _lret0 = new global::Lua.LuaValue(_ret0);
                    var _retCount = _context.Return(_lret0);
                    return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                }
            }
            throw new global::Lua.LuaRuntimeException(_context.Thread, $"{"Equals"}: invalid argument #{_lastArgPos}: {_lastArg} ({_lastArg.Type}), expected: {_expectedType.FullName}", 2);
        });
        private static readonly global::Lua.LuaFunction _LuaNamedBuildTarget_GetHashCode = new global::Lua.LuaFunction("GetHashCode", (_context, _) =>
        {
            global::Lua.LuaValue _lastArg = default;
            global::System.Int32 _lastArgPos = default;
            global::System.Type _expectedType = default;
            var _argCount = _context.ArgumentCount;
            var _this = _context.GetArgument<LuaNamedBuildTarget>(0);
            if (_argCount == 1)
            {
                var _ret0 = _this.m_Value.GetHashCode();
                var _lret0 = new global::Lua.LuaValue(_ret0);
                var _retCount = _context.Return(_lret0);
                return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
            }
            throw new global::Lua.LuaRuntimeException(_context.Thread, $"{"GetHashCode"}: invalid argument #{_lastArgPos}: {_lastArg} ({_lastArg.Type}), expected: {_expectedType.FullName}", 2);
        });
        private static readonly global::Lua.LuaFunction _LuaNamedBuildTarget_ToBuildTargetGroup = new global::Lua.LuaFunction("ToBuildTargetGroup", (_context, _) =>
        {
            global::Lua.LuaValue _lastArg = default;
            global::System.Int32 _lastArgPos = default;
            global::System.Type _expectedType = default;
            var _argCount = _context.ArgumentCount;
            var _this = _context.GetArgument<LuaNamedBuildTarget>(0);
            if (_argCount == 1)
            {
                var _ret0 = _this.m_Value.ToBuildTargetGroup();
                var _lret0 = new global::Lua.LuaValue((global::System.Int64)_ret0);
                var _retCount = _context.Return(_lret0);
                return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
            }
            throw new global::Lua.LuaRuntimeException(_context.Thread, $"{"ToBuildTargetGroup"}: invalid argument #{_lastArgPos}: {_lastArg} ({_lastArg.Type}), expected: {_expectedType.FullName}", 2);
        });
        private static readonly global::Lua.LuaFunction __index = new(global::Lua.Runtime.Metamethods.Index, (_context, _) =>
        {
            var _this = _context.GetArgument<LuaNamedBuildTarget>(0);
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
            var _this = _context.GetArgument<LuaNamedBuildTarget>(0);
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
                case "CompareTo": _value = _LuaNamedBuildTarget_CompareTo; return true;
                case "Equals": _value = _LuaNamedBuildTarget_Equals; return true;
                case "GetHashCode": _value = _LuaNamedBuildTarget_GetHashCode; return true;
                case "ToBuildTargetGroup": _value = _LuaNamedBuildTarget_ToBuildTargetGroup; return true;
                case "TargetName": _value = new global::Lua.LuaValue(m_Value.TargetName); return true;
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
    public sealed class LuaNamedBuildTargetType : global::Luny.ILuaStatic
    {
        public static global::Lua.LuaValue Bind() => new LuaNamedBuildTargetType();
        private LuaNamedBuildTargetType() {}
        public static implicit operator global::Lua.LuaValue(LuaNamedBuildTargetType value) => new(value);
        public global::System.Type BindType => typeof(global::UnityEditor.Build.NamedBuildTarget);
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

        private static readonly global::Lua.LuaFunction _LuaNamedBuildTarget_FromBuildTargetGroup = new global::Lua.LuaFunction("FromBuildTargetGroup", (_context, _) =>
        {
            global::Lua.LuaValue _lastArg = default;
            global::System.Int32 _lastArgPos = default;
            global::System.Type _expectedType = default;
            var _argCount = _context.ArgumentCount;
            var _arg0 = _lastArg = _argCount > 0 ? _context.GetArgument(0) : global::Lua.LuaValue.Nil;
            _lastArgPos = 0; _expectedType = typeof(global::UnityEditor.BuildTargetGroup);
            if (_arg0.TryRead<global::UnityEditor.BuildTargetGroup>(out var _p0_UnityEditor_BuildTargetGroup))
            {
                if (_argCount == 1)
                {
                    var buildTargetGroup = _p0_UnityEditor_BuildTargetGroup;
                    var _ret0 = global::UnityEditor.Build.NamedBuildTarget.FromBuildTargetGroup(buildTargetGroup);
                    var _lret0 = global::Luny.UnityEditor.Build.LuaNamedBuildTarget.Bind(_ret0);
                    var _retCount = _context.Return(_lret0);
                    return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                }
            }
            throw new global::Lua.LuaRuntimeException(_context.Thread, $"{"FromBuildTargetGroup"}: invalid argument #{_lastArgPos}: {_lastArg} ({_lastArg.Type}), expected: {_expectedType.FullName}", 2);
        });
        private static readonly global::Lua.LuaFunction __index = new(global::Lua.Runtime.Metamethods.Index, (_context, _) =>
        {
            var _this = _context.GetArgument<LuaNamedBuildTargetType>(0);
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
            var _this = _context.GetArgument<LuaNamedBuildTargetType>(0);
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
                case "FromBuildTargetGroup": _value = _LuaNamedBuildTarget_FromBuildTargetGroup; return true;
                case "Android": _value = global::Luny.UnityEditor.Build.LuaNamedBuildTarget.Bind(global::UnityEditor.Build.NamedBuildTarget.Android); return true;
                case "EmbeddedLinux": _value = global::Luny.UnityEditor.Build.LuaNamedBuildTarget.Bind(global::UnityEditor.Build.NamedBuildTarget.EmbeddedLinux); return true;
                case "iOS": _value = global::Luny.UnityEditor.Build.LuaNamedBuildTarget.Bind(global::UnityEditor.Build.NamedBuildTarget.iOS); return true;
                case "LinuxHeadlessSimulation": _value = global::Luny.UnityEditor.Build.LuaNamedBuildTarget.Bind(global::UnityEditor.Build.NamedBuildTarget.LinuxHeadlessSimulation); return true;
                case "NintendoSwitch": _value = global::Luny.UnityEditor.Build.LuaNamedBuildTarget.Bind(global::UnityEditor.Build.NamedBuildTarget.NintendoSwitch); return true;
                case "PS4": _value = global::Luny.UnityEditor.Build.LuaNamedBuildTarget.Bind(global::UnityEditor.Build.NamedBuildTarget.PS4); return true;
                case "PS5": _value = global::Luny.UnityEditor.Build.LuaNamedBuildTarget.Bind(global::UnityEditor.Build.NamedBuildTarget.PS5); return true;
                case "QNX": _value = global::Luny.UnityEditor.Build.LuaNamedBuildTarget.Bind(global::UnityEditor.Build.NamedBuildTarget.QNX); return true;
                case "Server": _value = global::Luny.UnityEditor.Build.LuaNamedBuildTarget.Bind(global::UnityEditor.Build.NamedBuildTarget.Server); return true;
                case "Standalone": _value = global::Luny.UnityEditor.Build.LuaNamedBuildTarget.Bind(global::UnityEditor.Build.NamedBuildTarget.Standalone); return true;
                case "tvOS": _value = global::Luny.UnityEditor.Build.LuaNamedBuildTarget.Bind(global::UnityEditor.Build.NamedBuildTarget.tvOS); return true;
                case "Unknown": _value = global::Luny.UnityEditor.Build.LuaNamedBuildTarget.Bind(global::UnityEditor.Build.NamedBuildTarget.Unknown); return true;
                case "VisionOS": _value = global::Luny.UnityEditor.Build.LuaNamedBuildTarget.Bind(global::UnityEditor.Build.NamedBuildTarget.VisionOS); return true;
                case "WebGL": _value = global::Luny.UnityEditor.Build.LuaNamedBuildTarget.Bind(global::UnityEditor.Build.NamedBuildTarget.WebGL); return true;
                case "WindowsStoreApps": _value = global::Luny.UnityEditor.Build.LuaNamedBuildTarget.Bind(global::UnityEditor.Build.NamedBuildTarget.WindowsStoreApps); return true;
                case "XboxOne": _value = global::Luny.UnityEditor.Build.LuaNamedBuildTarget.Bind(global::UnityEditor.Build.NamedBuildTarget.XboxOne); return true;
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
