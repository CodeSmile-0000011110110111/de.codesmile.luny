
// --------------------------------------------------------------
// GENERATED FILE ----> DO NOT EDIT <---- CHANGES WILL BE LOST !!
// --------------------------------------------------------------

#if UNITY_6000_1_OR_NEWER && !(UNITY_6000_2_OR_NEWER)
#pragma warning disable 0109, 0162, 0168, 0219
using Luny;

namespace Luny.UnityEngine
{
    public sealed class LuaRenderTargetSetup : global::Luny.ILuaValueType<global::UnityEngine.RenderTargetSetup>
    {
        public new static global::Lua.LuaValue Bind(in global::UnityEngine.RenderTargetSetup instance) => new LuaRenderTargetSetup(instance);
        public new static global::Lua.LuaValue Bind(global::System.Object instance) => Bind((global::UnityEngine.RenderTargetSetup)instance);
        public new static global::Lua.LuaValue Bind(global::System.Collections.Generic.IList<global::UnityEngine.RenderTargetSetup> instances) =>
            new global::Luny.LuaList<global::UnityEngine.RenderTargetSetup>(instances);
        public new static global::Lua.LuaValue Bind(global::System.Collections.Generic.IList<global::System.Object> instances) =>
            new global::Luny.LuaList<global::UnityEngine.RenderTargetSetup>(instances);
        private LuaRenderTargetSetup(in global::UnityEngine.RenderTargetSetup value) => m_Value = value;
        public static implicit operator global::Lua.LuaValue(LuaRenderTargetSetup value) => new(value);
        private global::UnityEngine.RenderTargetSetup m_Value;
        public global::UnityEngine.RenderTargetSetup Value { get => m_Value; set => m_Value = value; }
        public ref global::UnityEngine.RenderTargetSetup ValueRef => ref m_Value;
        public global::System.Type BindType => typeof(global::UnityEngine.RenderTargetSetup);
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
        public override global::System.String ToString() => m_Value.ToString();
#if UNITY_EDITOR
        [global::UnityEngine.RuntimeInitializeOnLoadMethod(global::UnityEngine.RuntimeInitializeLoadType.SubsystemRegistration)]
        private static void ResetStaticFields() => s_Metatable = null;
#endif

        private static readonly global::Lua.LuaFunction __index = new(global::Lua.Runtime.Metamethods.Index, (_context, _) =>
        {
            var _this = _context.GetArgument<LuaRenderTargetSetup>(0);
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
            var _this = _context.GetArgument<LuaRenderTargetSetup>(0);
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
                case "color": _value = _factory.Bind(m_Value.color); return true;
                case "colorLoad": _value = _factory.Bind(m_Value.colorLoad); return true;
                case "colorStore": _value = _factory.Bind(m_Value.colorStore); return true;
                case "cubemapFace": _value = new global::Lua.LuaValue((global::System.Int64)m_Value.cubemapFace); return true;
                case "depth": _value = global::Luny.UnityEngine.LuaRenderBuffer.Bind(m_Value.depth); return true;
                case "depthLoad": _value = new global::Lua.LuaValue((global::System.Int64)m_Value.depthLoad); return true;
                case "depthSlice": _value = new global::Lua.LuaValue(m_Value.depthSlice); return true;
                case "depthStore": _value = new global::Lua.LuaValue((global::System.Int64)m_Value.depthStore); return true;
                case "mipLevel": _value = new global::Lua.LuaValue(m_Value.mipLevel); return true;
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
                case "color": { var _temp = m_Value; _temp.color = _value.Read<global::UnityEngine.RenderBuffer[]>(); m_Value = _temp; } return true;
                case "colorLoad": { var _temp = m_Value; _temp.colorLoad = _value.Read<global::UnityEngine.Rendering.RenderBufferLoadAction[]>(); m_Value = _temp; } return true;
                case "colorStore": { var _temp = m_Value; _temp.colorStore = _value.Read<global::UnityEngine.Rendering.RenderBufferStoreAction[]>(); m_Value = _temp; } return true;
                case "cubemapFace": { var _temp = m_Value; _temp.cubemapFace = _value.Read<global::UnityEngine.CubemapFace>(); m_Value = _temp; } return true;
                case "depth": { var _temp = m_Value; _temp.depth = _value.Read<global::Luny.UnityEngine.LuaRenderBuffer>().Value; m_Value = _temp; } return true;
                case "depthLoad": { var _temp = m_Value; _temp.depthLoad = _value.Read<global::UnityEngine.Rendering.RenderBufferLoadAction>(); m_Value = _temp; } return true;
                case "depthSlice": { var _temp = m_Value; _temp.depthSlice = _value.Read<global::System.Int32>(); m_Value = _temp; } return true;
                case "depthStore": { var _temp = m_Value; _temp.depthStore = _value.Read<global::UnityEngine.Rendering.RenderBufferStoreAction>(); m_Value = _temp; } return true;
                case "mipLevel": { var _temp = m_Value; _temp.mipLevel = _value.Read<global::System.Int32>(); m_Value = _temp; } return true;
                default: return false;
            }
        }
    }
    public sealed class LuaRenderTargetSetupType : global::Luny.ILuaStatic
    {
        public static global::Lua.LuaValue Bind() => new LuaRenderTargetSetupType();
        private LuaRenderTargetSetupType() {}
        public static implicit operator global::Lua.LuaValue(LuaRenderTargetSetupType value) => new(value);
        public global::System.Type BindType => typeof(global::UnityEngine.RenderTargetSetup);
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
            metatable[global::Lua.Runtime.Metamethods.Call] = _LuaRenderTargetSetup_new;
            return metatable;
        }
        public override global::System.String ToString() => BindType.FullName;
#if UNITY_EDITOR
        [global::UnityEngine.RuntimeInitializeOnLoadMethod(global::UnityEngine.RuntimeInitializeLoadType.SubsystemRegistration)]
        private static void ResetStaticFields() => s_Metatable = null;
#endif

        private static readonly global::Lua.LuaFunction _LuaRenderTargetSetup_new = new global::Lua.LuaFunction(".ctor", (_context, _) =>
        {
            global::Lua.LuaValue _lastArg = default;
            global::System.Int32 _lastArgPos = default;
            global::System.Type _expectedType = default;
            var _argCount = _context.ArgumentCount;
            // ctor parameterless case
            if (_argCount == 1)
            {
                var _ret0 = new global::UnityEngine.RenderTargetSetup();
                var _lret0 = global::Luny.UnityEngine.LuaRenderTargetSetup.Bind(_ret0);
                var _retCount = _context.Return(_lret0);
                return new global::System.Threading.Tasks.ValueTask<global::System.Int32>(_retCount);
            }
            var _arg0 = _lastArg = _argCount > 1 ? _context.GetArgument(1) : global::Lua.LuaValue.Nil;
            _lastArgPos = 0; _expectedType = typeof(global::Luny.UnityEngine.LuaRenderBuffer);
            if (_arg0.TryRead<global::Luny.UnityEngine.LuaRenderBuffer>(out var _p0_UnityEngine_RenderBuffer))
            {
                var _arg1 = _lastArg = _argCount > 2 ? _context.GetArgument(2) : global::Lua.LuaValue.Nil;
                _lastArgPos = 1; _expectedType = typeof(global::Luny.UnityEngine.LuaRenderBuffer);
                if (_arg1.TryRead<global::Luny.UnityEngine.LuaRenderBuffer>(out var _p1_UnityEngine_RenderBuffer))
                {
                    if (_argCount == 3)
                    {
                        var color = _p0_UnityEngine_RenderBuffer.Value;
                        var depth = _p1_UnityEngine_RenderBuffer.Value;
                        var _ret0 = new global::UnityEngine.RenderTargetSetup(color, depth);
                        var _lret0 = global::Luny.UnityEngine.LuaRenderTargetSetup.Bind(_ret0);
                        var _retCount = _context.Return(_lret0);
                        return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                    }
                    var _arg2 = _lastArg = _argCount > 3 ? _context.GetArgument(3) : global::Lua.LuaValue.Nil;
                    _lastArgPos = 2; _expectedType = typeof(global::System.Int32);
                    if (_arg2.TryRead<global::System.Int32>(out var _p2_System_Int32))
                    {
                        if (_argCount == 4)
                        {
                            var color = _p0_UnityEngine_RenderBuffer.Value;
                            var depth = _p1_UnityEngine_RenderBuffer.Value;
                            var mipLevel = _p2_System_Int32;
                            var _ret0 = new global::UnityEngine.RenderTargetSetup(color, depth, mipLevel);
                            var _lret0 = global::Luny.UnityEngine.LuaRenderTargetSetup.Bind(_ret0);
                            var _retCount = _context.Return(_lret0);
                            return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                        }
                        var _arg3 = _lastArg = _argCount > 4 ? _context.GetArgument(4) : global::Lua.LuaValue.Nil;
                        _lastArgPos = 3; _expectedType = typeof(global::UnityEngine.CubemapFace);
                        if (_arg3.TryRead<global::UnityEngine.CubemapFace>(out var _p3_UnityEngine_CubemapFace))
                        {
                            if (_argCount == 5)
                            {
                                var color = _p0_UnityEngine_RenderBuffer.Value;
                                var depth = _p1_UnityEngine_RenderBuffer.Value;
                                var mipLevel = _p2_System_Int32;
                                var face = _p3_UnityEngine_CubemapFace;
                                var _ret0 = new global::UnityEngine.RenderTargetSetup(color, depth, mipLevel, face);
                                var _lret0 = global::Luny.UnityEngine.LuaRenderTargetSetup.Bind(_ret0);
                                var _retCount = _context.Return(_lret0);
                                return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                            }
                            var _arg4 = _lastArg = _argCount > 5 ? _context.GetArgument(5) : global::Lua.LuaValue.Nil;
                            _lastArgPos = 4; _expectedType = typeof(global::System.Int32);
                            if (_arg4.TryRead<global::System.Int32>(out var _p4_System_Int32))
                            {
                                if (_argCount == 6)
                                {
                                    var color = _p0_UnityEngine_RenderBuffer.Value;
                                    var depth = _p1_UnityEngine_RenderBuffer.Value;
                                    var mipLevel = _p2_System_Int32;
                                    var face = _p3_UnityEngine_CubemapFace;
                                    var depthSlice = _p4_System_Int32;
                                    var _ret0 = new global::UnityEngine.RenderTargetSetup(color, depth, mipLevel, face, depthSlice);
                                    var _lret0 = global::Luny.UnityEngine.LuaRenderTargetSetup.Bind(_ret0);
                                    var _retCount = _context.Return(_lret0);
                                    return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                                }
                            }
                        }
                    }
                }
            }
            _lastArgPos = 0; _expectedType = typeof(global::UnityEngine.RenderBuffer[]);
            if (_arg0.TryReadArray<global::UnityEngine.RenderBuffer>(out var _p0_UnityEngine_RenderBufferArray))
            {
                var _arg1 = _lastArg = _argCount > 2 ? _context.GetArgument(2) : global::Lua.LuaValue.Nil;
                _lastArgPos = 1; _expectedType = typeof(global::Luny.UnityEngine.LuaRenderBuffer);
                if (_arg1.TryRead<global::Luny.UnityEngine.LuaRenderBuffer>(out var _p1_UnityEngine_RenderBuffer))
                {
                    if (_argCount == 3)
                    {
                        var color = _p0_UnityEngine_RenderBufferArray;
                        var depth = _p1_UnityEngine_RenderBuffer.Value;
                        var _ret0 = new global::UnityEngine.RenderTargetSetup(color, depth);
                        var _lret0 = global::Luny.UnityEngine.LuaRenderTargetSetup.Bind(_ret0);
                        var _retCount = _context.Return(_lret0);
                        return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                    }
                    var _arg2 = _lastArg = _argCount > 3 ? _context.GetArgument(3) : global::Lua.LuaValue.Nil;
                    _lastArgPos = 2; _expectedType = typeof(global::System.Int32);
                    if (_arg2.TryRead<global::System.Int32>(out var _p2_System_Int32))
                    {
                        if (_argCount == 4)
                        {
                            var color = _p0_UnityEngine_RenderBufferArray;
                            var depth = _p1_UnityEngine_RenderBuffer.Value;
                            var mipLevel = _p2_System_Int32;
                            var _ret0 = new global::UnityEngine.RenderTargetSetup(color, depth, mipLevel);
                            var _lret0 = global::Luny.UnityEngine.LuaRenderTargetSetup.Bind(_ret0);
                            var _retCount = _context.Return(_lret0);
                            return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                        }
                        var _arg3 = _lastArg = _argCount > 4 ? _context.GetArgument(4) : global::Lua.LuaValue.Nil;
                        _lastArgPos = 3; _expectedType = typeof(global::UnityEngine.CubemapFace);
                        if (_arg3.TryRead<global::UnityEngine.CubemapFace>(out var _p3_UnityEngine_CubemapFace))
                        {
                            if (_argCount == 5)
                            {
                                var color = _p0_UnityEngine_RenderBufferArray;
                                var depth = _p1_UnityEngine_RenderBuffer.Value;
                                var mip = _p2_System_Int32;
                                var face = _p3_UnityEngine_CubemapFace;
                                var _ret0 = new global::UnityEngine.RenderTargetSetup(color, depth, mip, face);
                                var _lret0 = global::Luny.UnityEngine.LuaRenderTargetSetup.Bind(_ret0);
                                var _retCount = _context.Return(_lret0);
                                return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                            }
                            var _arg4 = _lastArg = _argCount > 5 ? _context.GetArgument(5) : global::Lua.LuaValue.Nil;
                            _lastArgPos = 4; _expectedType = typeof(global::UnityEngine.Rendering.RenderBufferLoadAction[]);
                            if (_arg4.TryReadArray<global::UnityEngine.Rendering.RenderBufferLoadAction>(out var _p4_UnityEngine_Rendering_RenderBufferLoadActionArray))
                            {
                                var _arg5 = _lastArg = _argCount > 6 ? _context.GetArgument(6) : global::Lua.LuaValue.Nil;
                                _lastArgPos = 5; _expectedType = typeof(global::UnityEngine.Rendering.RenderBufferStoreAction[]);
                                if (_arg5.TryReadArray<global::UnityEngine.Rendering.RenderBufferStoreAction>(out var _p5_UnityEngine_Rendering_RenderBufferStoreActionArray))
                                {
                                    var _arg6 = _lastArg = _argCount > 7 ? _context.GetArgument(7) : global::Lua.LuaValue.Nil;
                                    _lastArgPos = 6; _expectedType = typeof(global::UnityEngine.Rendering.RenderBufferLoadAction);
                                    if (_arg6.TryRead<global::UnityEngine.Rendering.RenderBufferLoadAction>(out var _p6_UnityEngine_Rendering_RenderBufferLoadAction))
                                    {
                                        var _arg7 = _lastArg = _argCount > 8 ? _context.GetArgument(8) : global::Lua.LuaValue.Nil;
                                        _lastArgPos = 7; _expectedType = typeof(global::UnityEngine.Rendering.RenderBufferStoreAction);
                                        if (_arg7.TryRead<global::UnityEngine.Rendering.RenderBufferStoreAction>(out var _p7_UnityEngine_Rendering_RenderBufferStoreAction))
                                        {
                                            if (_argCount == 9)
                                            {
                                                var color = _p0_UnityEngine_RenderBufferArray;
                                                var depth = _p1_UnityEngine_RenderBuffer.Value;
                                                var mip = _p2_System_Int32;
                                                var face = _p3_UnityEngine_CubemapFace;
                                                var colorLoad = _p4_UnityEngine_Rendering_RenderBufferLoadActionArray;
                                                var colorStore = _p5_UnityEngine_Rendering_RenderBufferStoreActionArray;
                                                var depthLoad = _p6_UnityEngine_Rendering_RenderBufferLoadAction;
                                                var depthStore = _p7_UnityEngine_Rendering_RenderBufferStoreAction;
                                                var _ret0 = new global::UnityEngine.RenderTargetSetup(color, depth, mip, face, colorLoad, colorStore, depthLoad, depthStore);
                                                var _lret0 = global::Luny.UnityEngine.LuaRenderTargetSetup.Bind(_ret0);
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
            throw new global::Lua.LuaRuntimeException(_context.Thread, $"{".ctor"}: invalid argument #{_lastArgPos}: {_lastArg} ({_lastArg.Type}), expected: {_expectedType.FullName}", 2);
        });
        private static readonly global::Lua.LuaFunction __index = new(global::Lua.Runtime.Metamethods.Index, (_context, _) =>
        {
            var _this = _context.GetArgument<LuaRenderTargetSetupType>(0);
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
            var _this = _context.GetArgument<LuaRenderTargetSetupType>(0);
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
