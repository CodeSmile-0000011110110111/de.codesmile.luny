
// --------------------------------------------------------------
// GENERATED FILE ----> DO NOT EDIT <---- CHANGES WILL BE LOST !!
// --------------------------------------------------------------

#if UNITY_6000_1_OR_NEWER && !(UNITY_6000_2_OR_NEWER)
#pragma warning disable 0109, 0162, 0168, 0219
using Luny;

namespace Luny.UnityEngine.Rendering
{
    public sealed class LuaVisibleLight : global::Luny.ILuaValueType<global::UnityEngine.Rendering.VisibleLight>
    {
        public new static global::Lua.LuaValue Bind(in global::UnityEngine.Rendering.VisibleLight instance) => new LuaVisibleLight(instance);
        public new static global::Lua.LuaValue Bind(global::System.Object instance) => Bind((global::UnityEngine.Rendering.VisibleLight)instance);
        public new static global::Lua.LuaValue Bind(global::System.Collections.Generic.IList<global::UnityEngine.Rendering.VisibleLight> instances) =>
            new global::Luny.LuaList<global::UnityEngine.Rendering.VisibleLight>(instances);
        public new static global::Lua.LuaValue Bind(global::System.Collections.Generic.IList<global::System.Object> instances) =>
            new global::Luny.LuaList<global::UnityEngine.Rendering.VisibleLight>(instances);
        private LuaVisibleLight(in global::UnityEngine.Rendering.VisibleLight value) => m_Value = value;
        public static implicit operator global::Lua.LuaValue(LuaVisibleLight value) => new(value);
        private global::UnityEngine.Rendering.VisibleLight m_Value;
        public global::UnityEngine.Rendering.VisibleLight Value { get => m_Value; set => m_Value = value; }
        public ref global::UnityEngine.Rendering.VisibleLight ValueRef => ref m_Value;
        public global::System.Type BindType => typeof(global::UnityEngine.Rendering.VisibleLight);
        private static global::Lua.LuaTable s_Metatable;
        public global::Lua.LuaTable Metatable
        {
            get => s_Metatable ??= global::Luny.LuaMetatable.Create(__index, __newindex);
            set => throw new global::System.NotSupportedException("LuaObject metatables cannot be modified");
        }
        global::System.Span<global::Lua.LuaValue> global::Lua.ILuaUserData.UserValues => default;
        public override global::System.String ToString() => m_Value.ToString();
#if UNITY_EDITOR
        [global::UnityEngine.RuntimeInitializeOnLoadMethod(global::UnityEngine.RuntimeInitializeLoadType.SubsystemRegistration)]
        private static void ResetStaticFields() => s_Metatable = null;
#endif

        private static readonly global::Lua.LuaFunction _LuaVisibleLight_Equals = new global::Lua.LuaFunction("Equals", (_context, _) =>
        {
            global::Lua.LuaValue _lastArg = default;
            global::System.Int32 _lastArgPos = default;
            global::System.Type _expectedType = default;
            var _argCount = _context.ArgumentCount;
            var _this = _context.GetArgument<LuaVisibleLight>(0);
            var _arg0 = _lastArg = _argCount > 1 ? _context.GetArgument(1) : global::Lua.LuaValue.Nil;
            _lastArgPos = 0; _expectedType = typeof(global::Luny.UnityEngine.Rendering.LuaVisibleLight);
            if (_arg0.TryRead<global::Luny.UnityEngine.Rendering.LuaVisibleLight>(out var _p0_UnityEngine_Rendering_VisibleLight))
            {
                if (_argCount == 2)
                {
                    var other = _p0_UnityEngine_Rendering_VisibleLight.Value;
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
        private static readonly global::Lua.LuaFunction _LuaVisibleLight_GetHashCode = new global::Lua.LuaFunction("GetHashCode", (_context, _) =>
        {
            global::Lua.LuaValue _lastArg = default;
            global::System.Int32 _lastArgPos = default;
            global::System.Type _expectedType = default;
            var _argCount = _context.ArgumentCount;
            var _this = _context.GetArgument<LuaVisibleLight>(0);
            if (_argCount == 1)
            {
                var _ret0 = _this.m_Value.GetHashCode();
                var _lret0 = new global::Lua.LuaValue(_ret0);
                var _retCount = _context.Return(_lret0);
                return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
            }
            throw new global::Lua.LuaRuntimeException(_context.Thread, $"{"GetHashCode"}: invalid argument #{_lastArgPos}: {_lastArg} ({_lastArg.Type}), expected: {_expectedType.FullName}", 2);
        });
        private static readonly global::Lua.LuaFunction __index = new(global::Lua.Runtime.Metamethods.Index, (_context, _) =>
        {
            var _this = _context.GetArgument<LuaVisibleLight>(0);
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
            var _this = _context.GetArgument<LuaVisibleLight>(0);
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
                case "Equals": _value = _LuaVisibleLight_Equals; return true;
                case "GetHashCode": _value = _LuaVisibleLight_GetHashCode; return true;
                case "finalColor": _value = global::Luny.UnityEngine.LuaColor.Bind(m_Value.finalColor); return true;
                case "forcedVisible": _value = new global::Lua.LuaValue(m_Value.forcedVisible); return true;
                case "intersectsFarPlane": _value = new global::Lua.LuaValue(m_Value.intersectsFarPlane); return true;
                case "intersectsNearPlane": _value = new global::Lua.LuaValue(m_Value.intersectsNearPlane); return true;
                case "light": _value = _factory.Bind(m_Value.light); return true;
                case "lightType": _value = new global::Lua.LuaValue((global::System.Int64)m_Value.lightType); return true;
                case "localToWorldMatrix": _value = global::Luny.UnityEngine.LuaMatrix4x4.Bind(m_Value.localToWorldMatrix); return true;
                case "range": _value = new global::Lua.LuaValue(m_Value.range); return true;
                case "screenRect": _value = global::Luny.UnityEngine.LuaRect.Bind(m_Value.screenRect); return true;
                case "spotAngle": _value = new global::Lua.LuaValue(m_Value.spotAngle); return true;
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
                case "finalColor": { var _temp = m_Value; _temp.finalColor = _value.Read<global::Luny.UnityEngine.LuaColor>().Value; m_Value = _temp; } return true;
                case "intersectsFarPlane": { var _temp = m_Value; _temp.intersectsFarPlane = _value.Read<global::System.Boolean>(); m_Value = _temp; } return true;
                case "intersectsNearPlane": { var _temp = m_Value; _temp.intersectsNearPlane = _value.Read<global::System.Boolean>(); m_Value = _temp; } return true;
                case "lightType": { var _temp = m_Value; _temp.lightType = _value.Read<global::UnityEngine.LightType>(); m_Value = _temp; } return true;
                case "localToWorldMatrix": { var _temp = m_Value; _temp.localToWorldMatrix = _value.Read<global::Luny.UnityEngine.LuaMatrix4x4>().Value; m_Value = _temp; } return true;
                case "range": { var _temp = m_Value; _temp.range = _value.Read<global::System.Single>(); m_Value = _temp; } return true;
                case "screenRect": { var _temp = m_Value; _temp.screenRect = _value.Read<global::Luny.UnityEngine.LuaRect>().Value; m_Value = _temp; } return true;
                case "spotAngle": { var _temp = m_Value; _temp.spotAngle = _value.Read<global::System.Single>(); m_Value = _temp; } return true;
                default: return false;
            }
        }
    }
    public sealed class LuaVisibleLightType : global::Luny.ILuaStatic
    {
        public static global::Lua.LuaValue Bind() => new LuaVisibleLightType();
        private LuaVisibleLightType() {}
        public static implicit operator global::Lua.LuaValue(LuaVisibleLightType value) => new(value);
        public global::System.Type BindType => typeof(global::UnityEngine.Rendering.VisibleLight);
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
            var _this = _context.GetArgument<LuaVisibleLightType>(0);
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
            var _this = _context.GetArgument<LuaVisibleLightType>(0);
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
