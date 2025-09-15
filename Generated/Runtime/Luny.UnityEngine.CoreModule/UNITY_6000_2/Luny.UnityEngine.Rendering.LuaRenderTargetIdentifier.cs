
// --------------------------------------------------------------
// GENERATED FILE ----> DO NOT EDIT <---- CHANGES WILL BE LOST !!
// --------------------------------------------------------------

#if UNITY_6000_2_OR_NEWER && !(UNITY_6000_3_OR_NEWER)
#pragma warning disable 0109, 0162, 0168, 0219
using Luny;

namespace Luny.UnityEngine.Rendering
{
    public sealed class LuaRenderTargetIdentifier : global::Luny.ILuaValueType<global::UnityEngine.Rendering.RenderTargetIdentifier>
    {
        public new static global::Lua.LuaValue Bind(in global::UnityEngine.Rendering.RenderTargetIdentifier instance) => new LuaRenderTargetIdentifier(instance);
        public new static global::Lua.LuaValue Bind(global::System.Object instance) => Bind((global::UnityEngine.Rendering.RenderTargetIdentifier)instance);
        public new static global::Lua.LuaValue Bind(global::System.Collections.Generic.IList<global::UnityEngine.Rendering.RenderTargetIdentifier> instances) =>
            new global::Luny.LuaList<global::UnityEngine.Rendering.RenderTargetIdentifier>(instances);
        public new static global::Lua.LuaValue Bind(global::System.Collections.Generic.IList<global::System.Object> instances) =>
            new global::Luny.LuaList<global::UnityEngine.Rendering.RenderTargetIdentifier>(instances);
        private LuaRenderTargetIdentifier(in global::UnityEngine.Rendering.RenderTargetIdentifier value) => m_Value = value;
        public static implicit operator global::Lua.LuaValue(LuaRenderTargetIdentifier value) => new(value);
        private global::UnityEngine.Rendering.RenderTargetIdentifier m_Value;
        public global::UnityEngine.Rendering.RenderTargetIdentifier Value { get => m_Value; set => m_Value = value; }
        public ref global::UnityEngine.Rendering.RenderTargetIdentifier ValueRef => ref m_Value;
        public global::System.Type BindType => typeof(global::UnityEngine.Rendering.RenderTargetIdentifier);
        public override global::System.String ToString() => m_Value.ToString();
#if UNITY_EDITOR
        [global::UnityEngine.RuntimeInitializeOnLoadMethod(global::UnityEngine.RuntimeInitializeLoadType.SubsystemRegistration)]
        private static void ResetStaticFields() => s_Metatable = null;
#endif

        private static readonly global::Lua.LuaFunction _LuaRenderTargetIdentifier_Equals = new global::Lua.LuaFunction("Equals", (_context, _) =>
        {
            global::Lua.LuaValue _lastArg = default;
            global::System.Int32 _lastArgPos = default;
            global::System.Type _expectedType = default;
            var _argCount = _context.ArgumentCount;
            var _this = _context.GetArgument<LuaRenderTargetIdentifier>(0);
            var _arg0 = _lastArg = _argCount > 1 ? _context.GetArgument(1) : global::Lua.LuaValue.Nil;
            _lastArgPos = 0; _expectedType = typeof(global::Luny.UnityEngine.Rendering.LuaRenderTargetIdentifier);
            if (_arg0.TryRead<global::Luny.UnityEngine.Rendering.LuaRenderTargetIdentifier>(out var _p0_UnityEngine_Rendering_RenderTargetIdentifier))
            {
                if (_argCount == 2)
                {
                    var rhs = _p0_UnityEngine_Rendering_RenderTargetIdentifier.Value;
                    var _ret0 = _this.m_Value.Equals(rhs);
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
        private static readonly global::Lua.LuaFunction _LuaRenderTargetIdentifier_GetHashCode = new global::Lua.LuaFunction("GetHashCode", (_context, _) =>
        {
            global::Lua.LuaValue _lastArg = default;
            global::System.Int32 _lastArgPos = default;
            global::System.Type _expectedType = default;
            var _argCount = _context.ArgumentCount;
            var _this = _context.GetArgument<LuaRenderTargetIdentifier>(0);
            if (_argCount == 1)
            {
                var _ret0 = _this.m_Value.GetHashCode();
                var _lret0 = new global::Lua.LuaValue(_ret0);
                var _retCount = _context.Return(_lret0);
                return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
            }
            throw new global::Lua.LuaRuntimeException(_context.Thread, $"{"GetHashCode"}: invalid argument #{_lastArgPos}: {_lastArg} ({_lastArg.Type}), expected: {_expectedType.FullName}", 2);
        });
        private static readonly global::Lua.LuaFunction _LuaRenderTargetIdentifier_ToString = new global::Lua.LuaFunction("ToString", (_context, _) =>
        {
            global::Lua.LuaValue _lastArg = default;
            global::System.Int32 _lastArgPos = default;
            global::System.Type _expectedType = default;
            var _argCount = _context.ArgumentCount;
            var _this = _context.GetArgument<LuaRenderTargetIdentifier>(0);
            if (_argCount == 1)
            {
                var _ret0 = _this.m_Value.ToString();
                var _lret0 = new global::Lua.LuaValue(_ret0);
                var _retCount = _context.Return(_lret0);
                return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
            }
            throw new global::Lua.LuaRuntimeException(_context.Thread, $"{"ToString"}: invalid argument #{_lastArgPos}: {_lastArg} ({_lastArg.Type}), expected: {_expectedType.FullName}", 2);
        });
        private static readonly global::Lua.LuaFunction __index = new(global::Lua.Runtime.Metamethods.Index, (_context, _) =>
        {
            var _this = _context.GetArgument<LuaRenderTargetIdentifier>(0);
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
            var _this = _context.GetArgument<LuaRenderTargetIdentifier>(0);
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

        public global::System.Boolean TryGetLuaValue(global::System.Int32 _key, out global::Lua.LuaValue _value, global::Luny.ILuaObjectFactory _factory)
        {
            _value = global::Lua.LuaValue.Nil; return false;
        }
        public global::System.Boolean TryGetLuaValue(global::System.String _key, out global::Lua.LuaValue _value, global::Luny.ILuaObjectFactory _factory)
        {
            switch (_key)
            {
                case "Equals": _value = _LuaRenderTargetIdentifier_Equals; return true;
                case "GetHashCode": _value = _LuaRenderTargetIdentifier_GetHashCode; return true;
                case "ToString": _value = _LuaRenderTargetIdentifier_ToString; return true;
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
    public sealed class LuaRenderTargetIdentifierType : global::Luny.ILuaStatic
    {
        public static global::Lua.LuaValue Bind() => new LuaRenderTargetIdentifierType();
        private LuaRenderTargetIdentifierType() {}
        public static implicit operator global::Lua.LuaValue(LuaRenderTargetIdentifierType value) => new(value);
        public global::System.Type BindType => typeof(global::UnityEngine.Rendering.RenderTargetIdentifier);
        public override global::System.String ToString() => BindType.FullName;
#if UNITY_EDITOR
        [global::UnityEngine.RuntimeInitializeOnLoadMethod(global::UnityEngine.RuntimeInitializeLoadType.SubsystemRegistration)]
        private static void ResetStaticFields() => s_Metatable = null;
#endif

        private static readonly global::Lua.LuaFunction _LuaRenderTargetIdentifier_new = new global::Lua.LuaFunction(".ctor", (_context, _) =>
        {
            global::Lua.LuaValue _lastArg = default;
            global::System.Int32 _lastArgPos = default;
            global::System.Type _expectedType = default;
            var _argCount = _context.ArgumentCount;
            // ctor parameterless case
            if (_argCount == 1)
            {
                var _ret0 = new global::UnityEngine.Rendering.RenderTargetIdentifier();
                var _lret0 = global::Luny.UnityEngine.Rendering.LuaRenderTargetIdentifier.Bind(_ret0);
                var _retCount = _context.Return(_lret0);
                return new global::System.Threading.Tasks.ValueTask<global::System.Int32>(_retCount);
            }
            var _arg0 = _lastArg = _argCount > 1 ? _context.GetArgument(1) : global::Lua.LuaValue.Nil;
            _lastArgPos = 0; _expectedType = typeof(global::System.Int32);
            if (_arg0.TryRead<global::System.Int32>(out var _p0_System_Int32))
            {
                if (_argCount == 2)
                {
                    var nameID = _p0_System_Int32;
                    var _ret0 = new global::UnityEngine.Rendering.RenderTargetIdentifier(nameID);
                    var _lret0 = global::Luny.UnityEngine.Rendering.LuaRenderTargetIdentifier.Bind(_ret0);
                    var _retCount = _context.Return(_lret0);
                    return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                }
                var _arg1 = _lastArg = _argCount > 2 ? _context.GetArgument(2) : global::Lua.LuaValue.Nil;
                _lastArgPos = 1; _expectedType = typeof(global::System.Int32);
                var _p1_System_Int32 = _arg1.ReadValue<global::System.Int32>((global::System.Int32)(0));
                {
                    if (_argCount == 3)
                    {
                        var nameID = _p0_System_Int32;
                        var mipLevel = _p1_System_Int32;
                        var _ret0 = new global::UnityEngine.Rendering.RenderTargetIdentifier(nameID, mipLevel);
                        var _lret0 = global::Luny.UnityEngine.Rendering.LuaRenderTargetIdentifier.Bind(_ret0);
                        var _retCount = _context.Return(_lret0);
                        return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                    }
                    var _arg2 = _lastArg = _argCount > 3 ? _context.GetArgument(3) : global::Lua.LuaValue.Nil;
                    _lastArgPos = 2; _expectedType = typeof(global::UnityEngine.CubemapFace);
                    var _p2_UnityEngine_CubemapFace = _arg2.ReadValue<global::UnityEngine.CubemapFace>(global::UnityEngine.CubemapFace.@Unknown);
                    {
                        if (_argCount == 4)
                        {
                            var nameID = _p0_System_Int32;
                            var mipLevel = _p1_System_Int32;
                            var cubeFace = _p2_UnityEngine_CubemapFace;
                            var _ret0 = new global::UnityEngine.Rendering.RenderTargetIdentifier(nameID, mipLevel, cubeFace);
                            var _lret0 = global::Luny.UnityEngine.Rendering.LuaRenderTargetIdentifier.Bind(_ret0);
                            var _retCount = _context.Return(_lret0);
                            return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                        }
                        var _arg3 = _lastArg = _argCount > 4 ? _context.GetArgument(4) : global::Lua.LuaValue.Nil;
                        _lastArgPos = 3; _expectedType = typeof(global::System.Int32);
                        var _p3_System_Int32 = _arg3.ReadValue<global::System.Int32>((global::System.Int32)(0));
                        {
                            if (_argCount == 5)
                            {
                                var nameID = _p0_System_Int32;
                                var mipLevel = _p1_System_Int32;
                                var cubeFace = _p2_UnityEngine_CubemapFace;
                                var depthSlice = _p3_System_Int32;
                                var _ret0 = new global::UnityEngine.Rendering.RenderTargetIdentifier(nameID, mipLevel, cubeFace, depthSlice);
                                var _lret0 = global::Luny.UnityEngine.Rendering.LuaRenderTargetIdentifier.Bind(_ret0);
                                var _retCount = _context.Return(_lret0);
                                return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                            }
                        }
                    }
                }
            }
            _lastArgPos = 0; _expectedType = typeof(global::UnityEngine.Rendering.BuiltinRenderTextureType);
            if (_arg0.TryRead<global::UnityEngine.Rendering.BuiltinRenderTextureType>(out var _p0_UnityEngine_Rendering_BuiltinRenderTextureType))
            {
                if (_argCount == 2)
                {
                    var type = _p0_UnityEngine_Rendering_BuiltinRenderTextureType;
                    var _ret0 = new global::UnityEngine.Rendering.RenderTargetIdentifier(type);
                    var _lret0 = global::Luny.UnityEngine.Rendering.LuaRenderTargetIdentifier.Bind(_ret0);
                    var _retCount = _context.Return(_lret0);
                    return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                }
                var _arg1 = _lastArg = _argCount > 2 ? _context.GetArgument(2) : global::Lua.LuaValue.Nil;
                _lastArgPos = 1; _expectedType = typeof(global::System.Int32);
                var _p1_System_Int32 = _arg1.ReadValue<global::System.Int32>((global::System.Int32)(0));
                {
                    if (_argCount == 3)
                    {
                        var type = _p0_UnityEngine_Rendering_BuiltinRenderTextureType;
                        var mipLevel = _p1_System_Int32;
                        var _ret0 = new global::UnityEngine.Rendering.RenderTargetIdentifier(type, mipLevel);
                        var _lret0 = global::Luny.UnityEngine.Rendering.LuaRenderTargetIdentifier.Bind(_ret0);
                        var _retCount = _context.Return(_lret0);
                        return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                    }
                    var _arg2 = _lastArg = _argCount > 3 ? _context.GetArgument(3) : global::Lua.LuaValue.Nil;
                    _lastArgPos = 2; _expectedType = typeof(global::UnityEngine.CubemapFace);
                    var _p2_UnityEngine_CubemapFace = _arg2.ReadValue<global::UnityEngine.CubemapFace>(global::UnityEngine.CubemapFace.@Unknown);
                    {
                        if (_argCount == 4)
                        {
                            var type = _p0_UnityEngine_Rendering_BuiltinRenderTextureType;
                            var mipLevel = _p1_System_Int32;
                            var cubeFace = _p2_UnityEngine_CubemapFace;
                            var _ret0 = new global::UnityEngine.Rendering.RenderTargetIdentifier(type, mipLevel, cubeFace);
                            var _lret0 = global::Luny.UnityEngine.Rendering.LuaRenderTargetIdentifier.Bind(_ret0);
                            var _retCount = _context.Return(_lret0);
                            return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                        }
                        var _arg3 = _lastArg = _argCount > 4 ? _context.GetArgument(4) : global::Lua.LuaValue.Nil;
                        _lastArgPos = 3; _expectedType = typeof(global::System.Int32);
                        var _p3_System_Int32 = _arg3.ReadValue<global::System.Int32>((global::System.Int32)(0));
                        {
                            if (_argCount == 5)
                            {
                                var type = _p0_UnityEngine_Rendering_BuiltinRenderTextureType;
                                var mipLevel = _p1_System_Int32;
                                var cubeFace = _p2_UnityEngine_CubemapFace;
                                var depthSlice = _p3_System_Int32;
                                var _ret0 = new global::UnityEngine.Rendering.RenderTargetIdentifier(type, mipLevel, cubeFace, depthSlice);
                                var _lret0 = global::Luny.UnityEngine.Rendering.LuaRenderTargetIdentifier.Bind(_ret0);
                                var _retCount = _context.Return(_lret0);
                                return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                            }
                        }
                    }
                }
            }
            _lastArgPos = 0; _expectedType = typeof(global::System.String);
            if (_arg0.TryRead<global::System.String>(out var _p0_System_String))
            {
                if (_argCount == 2)
                {
                    var name = _p0_System_String;
                    var _ret0 = new global::UnityEngine.Rendering.RenderTargetIdentifier(name);
                    var _lret0 = global::Luny.UnityEngine.Rendering.LuaRenderTargetIdentifier.Bind(_ret0);
                    var _retCount = _context.Return(_lret0);
                    return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                }
                var _arg1 = _lastArg = _argCount > 2 ? _context.GetArgument(2) : global::Lua.LuaValue.Nil;
                _lastArgPos = 1; _expectedType = typeof(global::System.Int32);
                var _p1_System_Int32 = _arg1.ReadValue<global::System.Int32>((global::System.Int32)(0));
                {
                    if (_argCount == 3)
                    {
                        var name = _p0_System_String;
                        var mipLevel = _p1_System_Int32;
                        var _ret0 = new global::UnityEngine.Rendering.RenderTargetIdentifier(name, mipLevel);
                        var _lret0 = global::Luny.UnityEngine.Rendering.LuaRenderTargetIdentifier.Bind(_ret0);
                        var _retCount = _context.Return(_lret0);
                        return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                    }
                    var _arg2 = _lastArg = _argCount > 3 ? _context.GetArgument(3) : global::Lua.LuaValue.Nil;
                    _lastArgPos = 2; _expectedType = typeof(global::UnityEngine.CubemapFace);
                    var _p2_UnityEngine_CubemapFace = _arg2.ReadValue<global::UnityEngine.CubemapFace>(global::UnityEngine.CubemapFace.@Unknown);
                    {
                        if (_argCount == 4)
                        {
                            var name = _p0_System_String;
                            var mipLevel = _p1_System_Int32;
                            var cubeFace = _p2_UnityEngine_CubemapFace;
                            var _ret0 = new global::UnityEngine.Rendering.RenderTargetIdentifier(name, mipLevel, cubeFace);
                            var _lret0 = global::Luny.UnityEngine.Rendering.LuaRenderTargetIdentifier.Bind(_ret0);
                            var _retCount = _context.Return(_lret0);
                            return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                        }
                        var _arg3 = _lastArg = _argCount > 4 ? _context.GetArgument(4) : global::Lua.LuaValue.Nil;
                        _lastArgPos = 3; _expectedType = typeof(global::System.Int32);
                        var _p3_System_Int32 = _arg3.ReadValue<global::System.Int32>((global::System.Int32)(0));
                        {
                            if (_argCount == 5)
                            {
                                var name = _p0_System_String;
                                var mipLevel = _p1_System_Int32;
                                var cubeFace = _p2_UnityEngine_CubemapFace;
                                var depthSlice = _p3_System_Int32;
                                var _ret0 = new global::UnityEngine.Rendering.RenderTargetIdentifier(name, mipLevel, cubeFace, depthSlice);
                                var _lret0 = global::Luny.UnityEngine.Rendering.LuaRenderTargetIdentifier.Bind(_ret0);
                                var _retCount = _context.Return(_lret0);
                                return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                            }
                        }
                    }
                }
            }
            _lastArgPos = 0; _expectedType = typeof(global::Luny.UnityEngine.LuaTexture);
            if (_arg0.TryRead<global::Luny.UnityEngine.LuaTexture>(out var _p0_UnityEngine_Texture))
            {
                if (_argCount == 2)
                {
                    var tex = _p0_UnityEngine_Texture.Instance;
                    var _ret0 = new global::UnityEngine.Rendering.RenderTargetIdentifier(tex);
                    var _lret0 = global::Luny.UnityEngine.Rendering.LuaRenderTargetIdentifier.Bind(_ret0);
                    var _retCount = _context.Return(_lret0);
                    return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                }
                var _arg1 = _lastArg = _argCount > 2 ? _context.GetArgument(2) : global::Lua.LuaValue.Nil;
                _lastArgPos = 1; _expectedType = typeof(global::System.Int32);
                var _p1_System_Int32 = _arg1.ReadValue<global::System.Int32>((global::System.Int32)(0));
                {
                    if (_argCount == 3)
                    {
                        var tex = _p0_UnityEngine_Texture.Instance;
                        var mipLevel = _p1_System_Int32;
                        var _ret0 = new global::UnityEngine.Rendering.RenderTargetIdentifier(tex, mipLevel);
                        var _lret0 = global::Luny.UnityEngine.Rendering.LuaRenderTargetIdentifier.Bind(_ret0);
                        var _retCount = _context.Return(_lret0);
                        return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                    }
                    var _arg2 = _lastArg = _argCount > 3 ? _context.GetArgument(3) : global::Lua.LuaValue.Nil;
                    _lastArgPos = 2; _expectedType = typeof(global::UnityEngine.CubemapFace);
                    var _p2_UnityEngine_CubemapFace = _arg2.ReadValue<global::UnityEngine.CubemapFace>(global::UnityEngine.CubemapFace.@Unknown);
                    {
                        if (_argCount == 4)
                        {
                            var tex = _p0_UnityEngine_Texture.Instance;
                            var mipLevel = _p1_System_Int32;
                            var cubeFace = _p2_UnityEngine_CubemapFace;
                            var _ret0 = new global::UnityEngine.Rendering.RenderTargetIdentifier(tex, mipLevel, cubeFace);
                            var _lret0 = global::Luny.UnityEngine.Rendering.LuaRenderTargetIdentifier.Bind(_ret0);
                            var _retCount = _context.Return(_lret0);
                            return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                        }
                        var _arg3 = _lastArg = _argCount > 4 ? _context.GetArgument(4) : global::Lua.LuaValue.Nil;
                        _lastArgPos = 3; _expectedType = typeof(global::System.Int32);
                        var _p3_System_Int32 = _arg3.ReadValue<global::System.Int32>((global::System.Int32)(0));
                        {
                            if (_argCount == 5)
                            {
                                var tex = _p0_UnityEngine_Texture.Instance;
                                var mipLevel = _p1_System_Int32;
                                var cubeFace = _p2_UnityEngine_CubemapFace;
                                var depthSlice = _p3_System_Int32;
                                var _ret0 = new global::UnityEngine.Rendering.RenderTargetIdentifier(tex, mipLevel, cubeFace, depthSlice);
                                var _lret0 = global::Luny.UnityEngine.Rendering.LuaRenderTargetIdentifier.Bind(_ret0);
                                var _retCount = _context.Return(_lret0);
                                return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                            }
                        }
                    }
                }
            }
            _lastArgPos = 0; _expectedType = typeof(global::Luny.UnityEngine.LuaRenderBuffer);
            if (_arg0.TryRead<global::Luny.UnityEngine.LuaRenderBuffer>(out var _p0_UnityEngine_RenderBuffer))
            {
                if (_argCount == 2)
                {
                    var buf = _p0_UnityEngine_RenderBuffer.Value;
                    var _ret0 = new global::UnityEngine.Rendering.RenderTargetIdentifier(buf);
                    var _lret0 = global::Luny.UnityEngine.Rendering.LuaRenderTargetIdentifier.Bind(_ret0);
                    var _retCount = _context.Return(_lret0);
                    return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                }
                var _arg1 = _lastArg = _argCount > 2 ? _context.GetArgument(2) : global::Lua.LuaValue.Nil;
                _lastArgPos = 1; _expectedType = typeof(global::System.Int32);
                var _p1_System_Int32 = _arg1.ReadValue<global::System.Int32>((global::System.Int32)(0));
                {
                    if (_argCount == 3)
                    {
                        var buf = _p0_UnityEngine_RenderBuffer.Value;
                        var mipLevel = _p1_System_Int32;
                        var _ret0 = new global::UnityEngine.Rendering.RenderTargetIdentifier(buf, mipLevel);
                        var _lret0 = global::Luny.UnityEngine.Rendering.LuaRenderTargetIdentifier.Bind(_ret0);
                        var _retCount = _context.Return(_lret0);
                        return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                    }
                    var _arg2 = _lastArg = _argCount > 3 ? _context.GetArgument(3) : global::Lua.LuaValue.Nil;
                    _lastArgPos = 2; _expectedType = typeof(global::UnityEngine.CubemapFace);
                    var _p2_UnityEngine_CubemapFace = _arg2.ReadValue<global::UnityEngine.CubemapFace>(global::UnityEngine.CubemapFace.@Unknown);
                    {
                        if (_argCount == 4)
                        {
                            var buf = _p0_UnityEngine_RenderBuffer.Value;
                            var mipLevel = _p1_System_Int32;
                            var cubeFace = _p2_UnityEngine_CubemapFace;
                            var _ret0 = new global::UnityEngine.Rendering.RenderTargetIdentifier(buf, mipLevel, cubeFace);
                            var _lret0 = global::Luny.UnityEngine.Rendering.LuaRenderTargetIdentifier.Bind(_ret0);
                            var _retCount = _context.Return(_lret0);
                            return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                        }
                        var _arg3 = _lastArg = _argCount > 4 ? _context.GetArgument(4) : global::Lua.LuaValue.Nil;
                        _lastArgPos = 3; _expectedType = typeof(global::System.Int32);
                        var _p3_System_Int32 = _arg3.ReadValue<global::System.Int32>((global::System.Int32)(0));
                        {
                            if (_argCount == 5)
                            {
                                var buf = _p0_UnityEngine_RenderBuffer.Value;
                                var mipLevel = _p1_System_Int32;
                                var cubeFace = _p2_UnityEngine_CubemapFace;
                                var depthSlice = _p3_System_Int32;
                                var _ret0 = new global::UnityEngine.Rendering.RenderTargetIdentifier(buf, mipLevel, cubeFace, depthSlice);
                                var _lret0 = global::Luny.UnityEngine.Rendering.LuaRenderTargetIdentifier.Bind(_ret0);
                                var _retCount = _context.Return(_lret0);
                                return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                            }
                        }
                    }
                }
            }
            _lastArgPos = 0; _expectedType = typeof(global::Luny.UnityEngine.Rendering.LuaRenderTargetIdentifier);
            if (_arg0.TryRead<global::Luny.UnityEngine.Rendering.LuaRenderTargetIdentifier>(out var _p0_UnityEngine_Rendering_RenderTargetIdentifier))
            {
                var _arg1 = _lastArg = _argCount > 2 ? _context.GetArgument(2) : global::Lua.LuaValue.Nil;
                _lastArgPos = 1; _expectedType = typeof(global::System.Int32);
                if (_arg1.TryRead<global::System.Int32>(out var _p1_System_Int32))
                {
                    if (_argCount == 3)
                    {
                        var renderTargetIdentifier = _p0_UnityEngine_Rendering_RenderTargetIdentifier.Value;
                        var mipLevel = _p1_System_Int32;
                        var _ret0 = new global::UnityEngine.Rendering.RenderTargetIdentifier(renderTargetIdentifier, mipLevel);
                        var _lret0 = global::Luny.UnityEngine.Rendering.LuaRenderTargetIdentifier.Bind(_ret0);
                        var _retCount = _context.Return(_lret0);
                        return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                    }
                    var _arg2 = _lastArg = _argCount > 3 ? _context.GetArgument(3) : global::Lua.LuaValue.Nil;
                    _lastArgPos = 2; _expectedType = typeof(global::UnityEngine.CubemapFace);
                    var _p2_UnityEngine_CubemapFace = _arg2.ReadValue<global::UnityEngine.CubemapFace>(global::UnityEngine.CubemapFace.@Unknown);
                    {
                        if (_argCount == 4)
                        {
                            var renderTargetIdentifier = _p0_UnityEngine_Rendering_RenderTargetIdentifier.Value;
                            var mipLevel = _p1_System_Int32;
                            var cubeFace = _p2_UnityEngine_CubemapFace;
                            var _ret0 = new global::UnityEngine.Rendering.RenderTargetIdentifier(renderTargetIdentifier, mipLevel, cubeFace);
                            var _lret0 = global::Luny.UnityEngine.Rendering.LuaRenderTargetIdentifier.Bind(_ret0);
                            var _retCount = _context.Return(_lret0);
                            return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                        }
                        var _arg3 = _lastArg = _argCount > 4 ? _context.GetArgument(4) : global::Lua.LuaValue.Nil;
                        _lastArgPos = 3; _expectedType = typeof(global::System.Int32);
                        var _p3_System_Int32 = _arg3.ReadValue<global::System.Int32>((global::System.Int32)(0));
                        {
                            if (_argCount == 5)
                            {
                                var renderTargetIdentifier = _p0_UnityEngine_Rendering_RenderTargetIdentifier.Value;
                                var mipLevel = _p1_System_Int32;
                                var cubeFace = _p2_UnityEngine_CubemapFace;
                                var depthSlice = _p3_System_Int32;
                                var _ret0 = new global::UnityEngine.Rendering.RenderTargetIdentifier(renderTargetIdentifier, mipLevel, cubeFace, depthSlice);
                                var _lret0 = global::Luny.UnityEngine.Rendering.LuaRenderTargetIdentifier.Bind(_ret0);
                                var _retCount = _context.Return(_lret0);
                                return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                            }
                        }
                    }
                }
            }
            throw new global::Lua.LuaRuntimeException(_context.Thread, $"{".ctor"}: invalid argument #{_lastArgPos}: {_lastArg} ({_lastArg.Type}), expected: {_expectedType.FullName}", 2);
        });
        private static readonly global::Lua.LuaFunction __index = new(global::Lua.Runtime.Metamethods.Index, (_context, _) =>
        {
            var _this = _context.GetArgument<LuaRenderTargetIdentifierType>(0);
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
            var _this = _context.GetArgument<LuaRenderTargetIdentifierType>(0);
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
            metatable[global::Lua.Runtime.Metamethods.Call] = _LuaRenderTargetIdentifier_new;
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
                case "AllDepthSlices": _value = new global::Lua.LuaValue(global::UnityEngine.Rendering.RenderTargetIdentifier.AllDepthSlices); return true;
                case "Invalid": _value = global::Luny.UnityEngine.Rendering.LuaRenderTargetIdentifier.Bind(global::UnityEngine.Rendering.RenderTargetIdentifier.Invalid); return true;
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
