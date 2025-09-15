
// --------------------------------------------------------------
// GENERATED FILE ----> DO NOT EDIT <---- CHANGES WILL BE LOST !!
// --------------------------------------------------------------

#if UNITY_6000_1_OR_NEWER && !(UNITY_6000_2_OR_NEWER)
#pragma warning disable 0109, 0162, 0168, 0219
using Luny;

namespace Luny.UnityEngine
{
    public sealed class LuaRenderTextureDescriptor : global::Luny.ILuaValueType<global::UnityEngine.RenderTextureDescriptor>
    {
        public new static global::Lua.LuaValue Bind(in global::UnityEngine.RenderTextureDescriptor instance) => new LuaRenderTextureDescriptor(instance);
        public new static global::Lua.LuaValue Bind(global::System.Object instance) => Bind((global::UnityEngine.RenderTextureDescriptor)instance);
        public new static global::Lua.LuaValue Bind(global::System.Collections.Generic.IList<global::UnityEngine.RenderTextureDescriptor> instances) =>
            new global::Luny.LuaList<global::UnityEngine.RenderTextureDescriptor>(instances);
        public new static global::Lua.LuaValue Bind(global::System.Collections.Generic.IList<global::System.Object> instances) =>
            new global::Luny.LuaList<global::UnityEngine.RenderTextureDescriptor>(instances);
        private LuaRenderTextureDescriptor(in global::UnityEngine.RenderTextureDescriptor value) => m_Value = value;
        public static implicit operator global::Lua.LuaValue(LuaRenderTextureDescriptor value) => new(value);
        private global::UnityEngine.RenderTextureDescriptor m_Value;
        public global::UnityEngine.RenderTextureDescriptor Value { get => m_Value; set => m_Value = value; }
        public ref global::UnityEngine.RenderTextureDescriptor ValueRef => ref m_Value;
        public global::System.Type BindType => typeof(global::UnityEngine.RenderTextureDescriptor);
        public override global::System.String ToString() => m_Value.ToString();
#if UNITY_EDITOR
        [global::UnityEngine.RuntimeInitializeOnLoadMethod(global::UnityEngine.RuntimeInitializeLoadType.SubsystemRegistration)]
        private static void ResetStaticFields() => s_Metatable = null;
#endif

        private static readonly global::Lua.LuaFunction __index = new(global::Lua.Runtime.Metamethods.Index, (_context, _) =>
        {
            var _this = _context.GetArgument<LuaRenderTextureDescriptor>(0);
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
            var _this = _context.GetArgument<LuaRenderTextureDescriptor>(0);
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
                case "autoGenerateMips": _value = new global::Lua.LuaValue(m_Value.autoGenerateMips); return true;
                case "bindMS": _value = new global::Lua.LuaValue(m_Value.bindMS); return true;
                case "colorFormat": _value = new global::Lua.LuaValue((global::System.Int64)m_Value.colorFormat); return true;
                case "depthBufferBits": _value = new global::Lua.LuaValue(m_Value.depthBufferBits); return true;
                case "depthStencilFormat": _value = new global::Lua.LuaValue((global::System.Int64)m_Value.depthStencilFormat); return true;
                case "dimension": _value = new global::Lua.LuaValue((global::System.Int64)m_Value.dimension); return true;
                case "enableRandomWrite": _value = new global::Lua.LuaValue(m_Value.enableRandomWrite); return true;
                case "enableShadingRate": _value = new global::Lua.LuaValue(m_Value.enableShadingRate); return true;
                case "flags": _value = new global::Lua.LuaValue((global::System.Int64)m_Value.flags); return true;
                case "graphicsFormat": _value = new global::Lua.LuaValue((global::System.Int64)m_Value.graphicsFormat); return true;
                case "height": _value = new global::Lua.LuaValue(m_Value.height); return true;
                case "memoryless": _value = new global::Lua.LuaValue((global::System.Int64)m_Value.memoryless); return true;
                case "mipCount": _value = new global::Lua.LuaValue(m_Value.mipCount); return true;
                case "msaaSamples": _value = new global::Lua.LuaValue(m_Value.msaaSamples); return true;
                case "shadowSamplingMode": _value = new global::Lua.LuaValue((global::System.Int64)m_Value.shadowSamplingMode); return true;
                case "sRGB": _value = new global::Lua.LuaValue(m_Value.sRGB); return true;
                case "stencilFormat": _value = new global::Lua.LuaValue((global::System.Int64)m_Value.stencilFormat); return true;
                case "useDynamicScale": _value = new global::Lua.LuaValue(m_Value.useDynamicScale); return true;
                case "useDynamicScaleExplicit": _value = new global::Lua.LuaValue(m_Value.useDynamicScaleExplicit); return true;
                case "useMipMap": _value = new global::Lua.LuaValue(m_Value.useMipMap); return true;
                case "volumeDepth": _value = new global::Lua.LuaValue(m_Value.volumeDepth); return true;
                case "vrUsage": _value = new global::Lua.LuaValue((global::System.Int64)m_Value.vrUsage); return true;
                case "width": _value = new global::Lua.LuaValue(m_Value.width); return true;
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
                case "autoGenerateMips": { var _temp = m_Value; _temp.autoGenerateMips = _value.Read<global::System.Boolean>(); m_Value = _temp; } return true;
                case "bindMS": { var _temp = m_Value; _temp.bindMS = _value.Read<global::System.Boolean>(); m_Value = _temp; } return true;
                case "colorFormat": { var _temp = m_Value; _temp.colorFormat = _value.Read<global::UnityEngine.RenderTextureFormat>(); m_Value = _temp; } return true;
                case "depthBufferBits": { var _temp = m_Value; _temp.depthBufferBits = _value.Read<global::System.Int32>(); m_Value = _temp; } return true;
                case "depthStencilFormat": { var _temp = m_Value; _temp.depthStencilFormat = _value.Read<global::UnityEngine.Experimental.Rendering.GraphicsFormat>(); m_Value = _temp; } return true;
                case "dimension": { var _temp = m_Value; _temp.dimension = _value.Read<global::UnityEngine.Rendering.TextureDimension>(); m_Value = _temp; } return true;
                case "enableRandomWrite": { var _temp = m_Value; _temp.enableRandomWrite = _value.Read<global::System.Boolean>(); m_Value = _temp; } return true;
                case "enableShadingRate": { var _temp = m_Value; _temp.enableShadingRate = _value.Read<global::System.Boolean>(); m_Value = _temp; } return true;
                case "graphicsFormat": { var _temp = m_Value; _temp.graphicsFormat = _value.Read<global::UnityEngine.Experimental.Rendering.GraphicsFormat>(); m_Value = _temp; } return true;
                case "height": { var _temp = m_Value; _temp.height = _value.Read<global::System.Int32>(); m_Value = _temp; } return true;
                case "memoryless": { var _temp = m_Value; _temp.memoryless = _value.Read<global::UnityEngine.RenderTextureMemoryless>(); m_Value = _temp; } return true;
                case "mipCount": { var _temp = m_Value; _temp.mipCount = _value.Read<global::System.Int32>(); m_Value = _temp; } return true;
                case "msaaSamples": { var _temp = m_Value; _temp.msaaSamples = _value.Read<global::System.Int32>(); m_Value = _temp; } return true;
                case "shadowSamplingMode": { var _temp = m_Value; _temp.shadowSamplingMode = _value.Read<global::UnityEngine.Rendering.ShadowSamplingMode>(); m_Value = _temp; } return true;
                case "sRGB": { var _temp = m_Value; _temp.sRGB = _value.Read<global::System.Boolean>(); m_Value = _temp; } return true;
                case "stencilFormat": { var _temp = m_Value; _temp.stencilFormat = _value.Read<global::UnityEngine.Experimental.Rendering.GraphicsFormat>(); m_Value = _temp; } return true;
                case "useDynamicScale": { var _temp = m_Value; _temp.useDynamicScale = _value.Read<global::System.Boolean>(); m_Value = _temp; } return true;
                case "useDynamicScaleExplicit": { var _temp = m_Value; _temp.useDynamicScaleExplicit = _value.Read<global::System.Boolean>(); m_Value = _temp; } return true;
                case "useMipMap": { var _temp = m_Value; _temp.useMipMap = _value.Read<global::System.Boolean>(); m_Value = _temp; } return true;
                case "volumeDepth": { var _temp = m_Value; _temp.volumeDepth = _value.Read<global::System.Int32>(); m_Value = _temp; } return true;
                case "vrUsage": { var _temp = m_Value; _temp.vrUsage = _value.Read<global::UnityEngine.VRTextureUsage>(); m_Value = _temp; } return true;
                case "width": { var _temp = m_Value; _temp.width = _value.Read<global::System.Int32>(); m_Value = _temp; } return true;
                default: return false;
            }
        }
    }
    public sealed class LuaRenderTextureDescriptorType : global::Luny.ILuaStatic
    {
        public static global::Lua.LuaValue Bind() => new LuaRenderTextureDescriptorType();
        private LuaRenderTextureDescriptorType() {}
        public static implicit operator global::Lua.LuaValue(LuaRenderTextureDescriptorType value) => new(value);
        public global::System.Type BindType => typeof(global::UnityEngine.RenderTextureDescriptor);
        public override global::System.String ToString() => BindType.FullName;
#if UNITY_EDITOR
        [global::UnityEngine.RuntimeInitializeOnLoadMethod(global::UnityEngine.RuntimeInitializeLoadType.SubsystemRegistration)]
        private static void ResetStaticFields() => s_Metatable = null;
#endif

        private static readonly global::Lua.LuaFunction _LuaRenderTextureDescriptor_new = new global::Lua.LuaFunction(".ctor", (_context, _) =>
        {
            global::Lua.LuaValue _lastArg = default;
            global::System.Int32 _lastArgPos = default;
            global::System.Type _expectedType = default;
            var _argCount = _context.ArgumentCount;
            // ctor parameterless case
            if (_argCount == 1)
            {
                var _ret0 = new global::UnityEngine.RenderTextureDescriptor();
                var _lret0 = global::Luny.UnityEngine.LuaRenderTextureDescriptor.Bind(_ret0);
                var _retCount = _context.Return(_lret0);
                return new global::System.Threading.Tasks.ValueTask<global::System.Int32>(_retCount);
            }
            var _arg0 = _lastArg = _argCount > 1 ? _context.GetArgument(1) : global::Lua.LuaValue.Nil;
            _lastArgPos = 0; _expectedType = typeof(global::System.Int32);
            if (_arg0.TryRead<global::System.Int32>(out var _p0_System_Int32))
            {
                var _arg1 = _lastArg = _argCount > 2 ? _context.GetArgument(2) : global::Lua.LuaValue.Nil;
                _lastArgPos = 1; _expectedType = typeof(global::System.Int32);
                if (_arg1.TryRead<global::System.Int32>(out var _p1_System_Int32))
                {
                    if (_argCount == 3)
                    {
                        var width = _p0_System_Int32;
                        var height = _p1_System_Int32;
                        var _ret0 = new global::UnityEngine.RenderTextureDescriptor(width, height);
                        var _lret0 = global::Luny.UnityEngine.LuaRenderTextureDescriptor.Bind(_ret0);
                        var _retCount = _context.Return(_lret0);
                        return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                    }
                    var _arg2 = _lastArg = _argCount > 3 ? _context.GetArgument(3) : global::Lua.LuaValue.Nil;
                    _lastArgPos = 2; _expectedType = typeof(global::UnityEngine.RenderTextureFormat);
                    if (_arg2.TryRead<global::UnityEngine.RenderTextureFormat>(out var _p2_UnityEngine_RenderTextureFormat))
                    {
                        if (_argCount == 4)
                        {
                            var width = _p0_System_Int32;
                            var height = _p1_System_Int32;
                            var colorFormat = _p2_UnityEngine_RenderTextureFormat;
                            var _ret0 = new global::UnityEngine.RenderTextureDescriptor(width, height, colorFormat);
                            var _lret0 = global::Luny.UnityEngine.LuaRenderTextureDescriptor.Bind(_ret0);
                            var _retCount = _context.Return(_lret0);
                            return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                        }
                        var _arg3 = _lastArg = _argCount > 4 ? _context.GetArgument(4) : global::Lua.LuaValue.Nil;
                        _lastArgPos = 3; _expectedType = typeof(global::System.Int32);
                        if (_arg3.TryRead<global::System.Int32>(out var _p3_System_Int32))
                        {
                            if (_argCount == 5)
                            {
                                var width = _p0_System_Int32;
                                var height = _p1_System_Int32;
                                var colorFormat = _p2_UnityEngine_RenderTextureFormat;
                                var depthBufferBits = _p3_System_Int32;
                                var _ret0 = new global::UnityEngine.RenderTextureDescriptor(width, height, colorFormat, depthBufferBits);
                                var _lret0 = global::Luny.UnityEngine.LuaRenderTextureDescriptor.Bind(_ret0);
                                var _retCount = _context.Return(_lret0);
                                return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                            }
                            var _arg4 = _lastArg = _argCount > 5 ? _context.GetArgument(5) : global::Lua.LuaValue.Nil;
                            _lastArgPos = 4; _expectedType = typeof(global::System.Int32);
                            if (_arg4.TryRead<global::System.Int32>(out var _p4_System_Int32))
                            {
                                if (_argCount == 6)
                                {
                                    var width = _p0_System_Int32;
                                    var height = _p1_System_Int32;
                                    var colorFormat = _p2_UnityEngine_RenderTextureFormat;
                                    var depthBufferBits = _p3_System_Int32;
                                    var mipCount = _p4_System_Int32;
                                    var _ret0 = new global::UnityEngine.RenderTextureDescriptor(width, height, colorFormat, depthBufferBits, mipCount);
                                    var _lret0 = global::Luny.UnityEngine.LuaRenderTextureDescriptor.Bind(_ret0);
                                    var _retCount = _context.Return(_lret0);
                                    return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                                }
                                var _arg5 = _lastArg = _argCount > 6 ? _context.GetArgument(6) : global::Lua.LuaValue.Nil;
                                _lastArgPos = 5; _expectedType = typeof(global::UnityEngine.RenderTextureReadWrite);
                                if (_arg5.TryRead<global::UnityEngine.RenderTextureReadWrite>(out var _p5_UnityEngine_RenderTextureReadWrite))
                                {
                                    if (_argCount == 7)
                                    {
                                        var width = _p0_System_Int32;
                                        var height = _p1_System_Int32;
                                        var colorFormat = _p2_UnityEngine_RenderTextureFormat;
                                        var depthBufferBits = _p3_System_Int32;
                                        var mipCount = _p4_System_Int32;
                                        var readWrite = _p5_UnityEngine_RenderTextureReadWrite;
                                        var _ret0 = new global::UnityEngine.RenderTextureDescriptor(width, height, colorFormat, depthBufferBits, mipCount, readWrite);
                                        var _lret0 = global::Luny.UnityEngine.LuaRenderTextureDescriptor.Bind(_ret0);
                                        var _retCount = _context.Return(_lret0);
                                        return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                                    }
                                }
                            }
                        }
                    }
                    _lastArgPos = 2; _expectedType = typeof(global::UnityEngine.Experimental.Rendering.GraphicsFormat);
                    if (_arg2.TryRead<global::UnityEngine.Experimental.Rendering.GraphicsFormat>(out var _p2_UnityEngine_Experimental_Rendering_GraphicsFormat))
                    {
                        var _arg3 = _lastArg = _argCount > 4 ? _context.GetArgument(4) : global::Lua.LuaValue.Nil;
                        _lastArgPos = 3; _expectedType = typeof(global::System.Int32);
                        if (_arg3.TryRead<global::System.Int32>(out var _p3_System_Int32))
                        {
                            if (_argCount == 5)
                            {
                                var width = _p0_System_Int32;
                                var height = _p1_System_Int32;
                                var colorFormat = _p2_UnityEngine_Experimental_Rendering_GraphicsFormat;
                                var depthBufferBits = _p3_System_Int32;
                                var _ret0 = new global::UnityEngine.RenderTextureDescriptor(width, height, colorFormat, depthBufferBits);
                                var _lret0 = global::Luny.UnityEngine.LuaRenderTextureDescriptor.Bind(_ret0);
                                var _retCount = _context.Return(_lret0);
                                return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                            }
                            var _arg4 = _lastArg = _argCount > 5 ? _context.GetArgument(5) : global::Lua.LuaValue.Nil;
                            _lastArgPos = 4; _expectedType = typeof(global::System.Int32);
                            if (_arg4.TryRead<global::System.Int32>(out var _p4_System_Int32))
                            {
                                if (_argCount == 6)
                                {
                                    var width = _p0_System_Int32;
                                    var height = _p1_System_Int32;
                                    var colorFormat = _p2_UnityEngine_Experimental_Rendering_GraphicsFormat;
                                    var depthBufferBits = _p3_System_Int32;
                                    var mipCount = _p4_System_Int32;
                                    var _ret0 = new global::UnityEngine.RenderTextureDescriptor(width, height, colorFormat, depthBufferBits, mipCount);
                                    var _lret0 = global::Luny.UnityEngine.LuaRenderTextureDescriptor.Bind(_ret0);
                                    var _retCount = _context.Return(_lret0);
                                    return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                                }
                            }
                        }
                        _lastArgPos = 3; _expectedType = typeof(global::UnityEngine.Experimental.Rendering.GraphicsFormat);
                        if (_arg3.TryRead<global::UnityEngine.Experimental.Rendering.GraphicsFormat>(out var _p3_UnityEngine_Experimental_Rendering_GraphicsFormat))
                        {
                            if (_argCount == 5)
                            {
                                var width = _p0_System_Int32;
                                var height = _p1_System_Int32;
                                var colorFormat = _p2_UnityEngine_Experimental_Rendering_GraphicsFormat;
                                var depthStencilFormat = _p3_UnityEngine_Experimental_Rendering_GraphicsFormat;
                                var _ret0 = new global::UnityEngine.RenderTextureDescriptor(width, height, colorFormat, depthStencilFormat);
                                var _lret0 = global::Luny.UnityEngine.LuaRenderTextureDescriptor.Bind(_ret0);
                                var _retCount = _context.Return(_lret0);
                                return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                            }
                            var _arg4 = _lastArg = _argCount > 5 ? _context.GetArgument(5) : global::Lua.LuaValue.Nil;
                            _lastArgPos = 4; _expectedType = typeof(global::System.Int32);
                            if (_arg4.TryRead<global::System.Int32>(out var _p4_System_Int32))
                            {
                                if (_argCount == 6)
                                {
                                    var width = _p0_System_Int32;
                                    var height = _p1_System_Int32;
                                    var colorFormat = _p2_UnityEngine_Experimental_Rendering_GraphicsFormat;
                                    var depthStencilFormat = _p3_UnityEngine_Experimental_Rendering_GraphicsFormat;
                                    var mipCount = _p4_System_Int32;
                                    var _ret0 = new global::UnityEngine.RenderTextureDescriptor(width, height, colorFormat, depthStencilFormat, mipCount);
                                    var _lret0 = global::Luny.UnityEngine.LuaRenderTextureDescriptor.Bind(_ret0);
                                    var _retCount = _context.Return(_lret0);
                                    return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
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
            var _this = _context.GetArgument<LuaRenderTextureDescriptorType>(0);
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
            var _this = _context.GetArgument<LuaRenderTextureDescriptorType>(0);
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
            metatable[global::Lua.Runtime.Metamethods.Call] = _LuaRenderTextureDescriptor_new;
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
