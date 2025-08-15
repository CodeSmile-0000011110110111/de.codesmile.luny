
// --------------------------------------------------------------
// GENERATED FILE ----> DO NOT EDIT <---- CHANGES WILL BE LOST !!
// --------------------------------------------------------------

#if UNITY_6000_1_OR_NEWER && !(UNITY_6000_2_OR_NEWER)
#pragma warning disable 0109, 0162, 0168, 0219
using Luny;

namespace Luny.UnityEngine
{
    public sealed class LuaGraphics : global::Luny.ILuaObject<global::UnityEngine.Graphics>
    {
        public new static global::Lua.LuaValue Bind(global::UnityEngine.Graphics instance) => new LuaGraphics(instance);
        public new static global::Lua.LuaValue Bind(global::System.Object instance) => Bind((global::UnityEngine.Graphics)instance);
        public new static global::Lua.LuaValue Bind(global::System.Collections.Generic.IList<global::UnityEngine.Graphics> instances) =>
            new global::Luny.LuaList<global::UnityEngine.Graphics>(instances);
        public new static global::Lua.LuaValue Bind(global::System.Collections.Generic.IList<global::System.Object> instances) =>
            new global::Luny.LuaList<global::UnityEngine.Graphics>(instances);
        private LuaGraphics(global::UnityEngine.Graphics instance) => m_Instance = instance;
        public static implicit operator global::Lua.LuaValue(LuaGraphics value) => new(value);
        private global::UnityEngine.Graphics m_Instance;
        public global::UnityEngine.Graphics Instance => m_Instance;
        public new global::System.Type BindType => typeof(global::UnityEngine.Graphics);
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
            var _this = _context.GetArgument<LuaGraphics>(0);
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
            var _this = _context.GetArgument<LuaGraphics>(0);
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
    public sealed class LuaGraphicsType : global::Luny.ILuaStatic
    {
        public static global::Lua.LuaValue Bind() => new LuaGraphicsType();
        private LuaGraphicsType() {}
        public static implicit operator global::Lua.LuaValue(LuaGraphicsType value) => new(value);
        public global::System.Type BindType => typeof(global::UnityEngine.Graphics);
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
            metatable[global::Lua.Runtime.Metamethods.Call] = _LuaGraphics_new;
            return metatable;
        }
        public override global::System.String ToString() => BindType.FullName;
#if UNITY_EDITOR
        [global::UnityEngine.RuntimeInitializeOnLoadMethod(global::UnityEngine.RuntimeInitializeLoadType.SubsystemRegistration)]
        private static void ResetStaticFields() => s_Metatable = null;
#endif

        private static readonly global::Lua.LuaFunction _LuaGraphics_new = new global::Lua.LuaFunction(".ctor", (_context, _) =>
        {
            global::Lua.LuaValue _lastArg = default;
            global::System.Int32 _lastArgPos = default;
            global::System.Type _expectedType = default;
            var _argCount = _context.ArgumentCount;
            if (_argCount == 1)
            {
                var _ret0 = new global::UnityEngine.Graphics();
                var _factory = _context.GetObjectFactory();
                var _lret0 = _factory.Bind(_ret0);
                var _retCount = _context.Return(_lret0);
                return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
            }
            throw new global::Lua.LuaRuntimeException(_context.Thread, $"{".ctor"}: invalid argument #{_lastArgPos}: {_lastArg} ({_lastArg.Type}), expected: {_expectedType.FullName}", 2);
        });
        private static readonly global::Lua.LuaFunction _LuaGraphics_Blit = new global::Lua.LuaFunction("Blit", (_context, _) =>
        {
            global::Lua.LuaValue _lastArg = default;
            global::System.Int32 _lastArgPos = default;
            global::System.Type _expectedType = default;
            var _argCount = _context.ArgumentCount;
            var _arg0 = _lastArg = _argCount > 0 ? _context.GetArgument(0) : global::Lua.LuaValue.Nil;
            _lastArgPos = 0; _expectedType = typeof(global::Luny.UnityEngine.LuaTexture);
            if (_arg0.TryRead<global::Luny.UnityEngine.LuaTexture>(out var _p0_UnityEngine_Texture))
            {
                var _arg1 = _lastArg = _argCount > 1 ? _context.GetArgument(1) : global::Lua.LuaValue.Nil;
                _lastArgPos = 1; _expectedType = typeof(global::Luny.UnityEngine.LuaRenderTexture);
                if (_arg1.TryRead<global::Luny.UnityEngine.LuaRenderTexture>(out var _p1_UnityEngine_RenderTexture))
                {
                    if (_argCount == 2)
                    {
                        var source = _p0_UnityEngine_Texture.Instance;
                        var dest = _p1_UnityEngine_RenderTexture.Instance;
                        global::UnityEngine.Graphics.Blit(source, dest);
                        var _retCount = _context.Return();
                        return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                    }
                    var _arg2 = _lastArg = _argCount > 2 ? _context.GetArgument(2) : global::Lua.LuaValue.Nil;
                    _lastArgPos = 2; _expectedType = typeof(global::Luny.UnityEngine.LuaMaterial);
                    if (_arg2.TryRead<global::Luny.UnityEngine.LuaMaterial>(out var _p2_UnityEngine_Material))
                    {
                        if (_argCount == 3)
                        {
                            var source = _p0_UnityEngine_Texture.Instance;
                            var dest = _p1_UnityEngine_RenderTexture.Instance;
                            var mat = _p2_UnityEngine_Material.Instance;
                            global::UnityEngine.Graphics.Blit(source, dest, mat);
                            var _retCount = _context.Return();
                            return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                        }
                        var _arg3 = _lastArg = _argCount > 3 ? _context.GetArgument(3) : global::Lua.LuaValue.Nil;
                        _lastArgPos = 3; _expectedType = typeof(global::System.Int32);
                        if (_arg3.TryRead<global::System.Int32>(out var _p3_System_Int32))
                        {
                            if (_argCount == 4)
                            {
                                var source = _p0_UnityEngine_Texture.Instance;
                                var dest = _p1_UnityEngine_RenderTexture.Instance;
                                var mat = _p2_UnityEngine_Material.Instance;
                                var pass = _p3_System_Int32;
                                global::UnityEngine.Graphics.Blit(source, dest, mat, pass);
                                var _retCount = _context.Return();
                                return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                            }
                            var _arg4 = _lastArg = _argCount > 4 ? _context.GetArgument(4) : global::Lua.LuaValue.Nil;
                            _lastArgPos = 4; _expectedType = typeof(global::System.Int32);
                            if (_arg4.TryRead<global::System.Int32>(out var _p4_System_Int32))
                            {
                                if (_argCount == 5)
                                {
                                    var source = _p0_UnityEngine_Texture.Instance;
                                    var dest = _p1_UnityEngine_RenderTexture.Instance;
                                    var mat = _p2_UnityEngine_Material.Instance;
                                    var pass = _p3_System_Int32;
                                    var destDepthSlice = _p4_System_Int32;
                                    global::UnityEngine.Graphics.Blit(source, dest, mat, pass, destDepthSlice);
                                    var _retCount = _context.Return();
                                    return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                                }
                            }
                        }
                    }
                    _lastArgPos = 2; _expectedType = typeof(global::System.Int32);
                    if (_arg2.TryRead<global::System.Int32>(out var _p2_System_Int32))
                    {
                        var _arg3 = _lastArg = _argCount > 3 ? _context.GetArgument(3) : global::Lua.LuaValue.Nil;
                        _lastArgPos = 3; _expectedType = typeof(global::System.Int32);
                        if (_arg3.TryRead<global::System.Int32>(out var _p3_System_Int32))
                        {
                            if (_argCount == 4)
                            {
                                var source = _p0_UnityEngine_Texture.Instance;
                                var dest = _p1_UnityEngine_RenderTexture.Instance;
                                var sourceDepthSlice = _p2_System_Int32;
                                var destDepthSlice = _p3_System_Int32;
                                global::UnityEngine.Graphics.Blit(source, dest, sourceDepthSlice, destDepthSlice);
                                var _retCount = _context.Return();
                                return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                            }
                        }
                    }
                    _lastArgPos = 2; _expectedType = typeof(global::Luny.UnityEngine.LuaVector2);
                    if (_arg2.TryRead<global::Luny.UnityEngine.LuaVector2>(out var _p2_UnityEngine_Vector2))
                    {
                        var _arg3 = _lastArg = _argCount > 3 ? _context.GetArgument(3) : global::Lua.LuaValue.Nil;
                        _lastArgPos = 3; _expectedType = typeof(global::Luny.UnityEngine.LuaVector2);
                        if (_arg3.TryRead<global::Luny.UnityEngine.LuaVector2>(out var _p3_UnityEngine_Vector2))
                        {
                            if (_argCount == 4)
                            {
                                var source = _p0_UnityEngine_Texture.Instance;
                                var dest = _p1_UnityEngine_RenderTexture.Instance;
                                var scale = _p2_UnityEngine_Vector2.Value;
                                var offset = _p3_UnityEngine_Vector2.Value;
                                global::UnityEngine.Graphics.Blit(source, dest, scale, offset);
                                var _retCount = _context.Return();
                                return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                            }
                            var _arg4 = _lastArg = _argCount > 4 ? _context.GetArgument(4) : global::Lua.LuaValue.Nil;
                            _lastArgPos = 4; _expectedType = typeof(global::System.Int32);
                            if (_arg4.TryRead<global::System.Int32>(out var _p4_System_Int32))
                            {
                                var _arg5 = _lastArg = _argCount > 5 ? _context.GetArgument(5) : global::Lua.LuaValue.Nil;
                                _lastArgPos = 5; _expectedType = typeof(global::System.Int32);
                                if (_arg5.TryRead<global::System.Int32>(out var _p5_System_Int32))
                                {
                                    if (_argCount == 6)
                                    {
                                        var source = _p0_UnityEngine_Texture.Instance;
                                        var dest = _p1_UnityEngine_RenderTexture.Instance;
                                        var scale = _p2_UnityEngine_Vector2.Value;
                                        var offset = _p3_UnityEngine_Vector2.Value;
                                        var sourceDepthSlice = _p4_System_Int32;
                                        var destDepthSlice = _p5_System_Int32;
                                        global::UnityEngine.Graphics.Blit(source, dest, scale, offset, sourceDepthSlice, destDepthSlice);
                                        var _retCount = _context.Return();
                                        return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                                    }
                                }
                            }
                        }
                    }
                }
                _lastArgPos = 1; _expectedType = typeof(global::Luny.UnityEngine.Rendering.LuaGraphicsTexture);
                if (_arg1.TryRead<global::Luny.UnityEngine.Rendering.LuaGraphicsTexture>(out var _p1_UnityEngine_Rendering_GraphicsTexture))
                {
                    if (_argCount == 2)
                    {
                        var source = _p0_UnityEngine_Texture.Instance;
                        var dest = _p1_UnityEngine_Rendering_GraphicsTexture.Instance;
                        global::UnityEngine.Graphics.Blit(source, dest);
                        var _retCount = _context.Return();
                        return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                    }
                    var _arg2 = _lastArg = _argCount > 2 ? _context.GetArgument(2) : global::Lua.LuaValue.Nil;
                    _lastArgPos = 2; _expectedType = typeof(global::Luny.UnityEngine.LuaMaterial);
                    if (_arg2.TryRead<global::Luny.UnityEngine.LuaMaterial>(out var _p2_UnityEngine_Material))
                    {
                        if (_argCount == 3)
                        {
                            var source = _p0_UnityEngine_Texture.Instance;
                            var dest = _p1_UnityEngine_Rendering_GraphicsTexture.Instance;
                            var mat = _p2_UnityEngine_Material.Instance;
                            global::UnityEngine.Graphics.Blit(source, dest, mat);
                            var _retCount = _context.Return();
                            return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                        }
                        var _arg3 = _lastArg = _argCount > 3 ? _context.GetArgument(3) : global::Lua.LuaValue.Nil;
                        _lastArgPos = 3; _expectedType = typeof(global::System.Int32);
                        if (_arg3.TryRead<global::System.Int32>(out var _p3_System_Int32))
                        {
                            if (_argCount == 4)
                            {
                                var source = _p0_UnityEngine_Texture.Instance;
                                var dest = _p1_UnityEngine_Rendering_GraphicsTexture.Instance;
                                var mat = _p2_UnityEngine_Material.Instance;
                                var pass = _p3_System_Int32;
                                global::UnityEngine.Graphics.Blit(source, dest, mat, pass);
                                var _retCount = _context.Return();
                                return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                            }
                            var _arg4 = _lastArg = _argCount > 4 ? _context.GetArgument(4) : global::Lua.LuaValue.Nil;
                            _lastArgPos = 4; _expectedType = typeof(global::System.Int32);
                            if (_arg4.TryRead<global::System.Int32>(out var _p4_System_Int32))
                            {
                                if (_argCount == 5)
                                {
                                    var source = _p0_UnityEngine_Texture.Instance;
                                    var dest = _p1_UnityEngine_Rendering_GraphicsTexture.Instance;
                                    var mat = _p2_UnityEngine_Material.Instance;
                                    var pass = _p3_System_Int32;
                                    var destDepthSlice = _p4_System_Int32;
                                    global::UnityEngine.Graphics.Blit(source, dest, mat, pass, destDepthSlice);
                                    var _retCount = _context.Return();
                                    return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                                }
                            }
                        }
                    }
                    _lastArgPos = 2; _expectedType = typeof(global::System.Int32);
                    if (_arg2.TryRead<global::System.Int32>(out var _p2_System_Int32))
                    {
                        var _arg3 = _lastArg = _argCount > 3 ? _context.GetArgument(3) : global::Lua.LuaValue.Nil;
                        _lastArgPos = 3; _expectedType = typeof(global::System.Int32);
                        if (_arg3.TryRead<global::System.Int32>(out var _p3_System_Int32))
                        {
                            if (_argCount == 4)
                            {
                                var source = _p0_UnityEngine_Texture.Instance;
                                var dest = _p1_UnityEngine_Rendering_GraphicsTexture.Instance;
                                var sourceDepthSlice = _p2_System_Int32;
                                var destDepthSlice = _p3_System_Int32;
                                global::UnityEngine.Graphics.Blit(source, dest, sourceDepthSlice, destDepthSlice);
                                var _retCount = _context.Return();
                                return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                            }
                        }
                    }
                    _lastArgPos = 2; _expectedType = typeof(global::Luny.UnityEngine.LuaVector2);
                    if (_arg2.TryRead<global::Luny.UnityEngine.LuaVector2>(out var _p2_UnityEngine_Vector2))
                    {
                        var _arg3 = _lastArg = _argCount > 3 ? _context.GetArgument(3) : global::Lua.LuaValue.Nil;
                        _lastArgPos = 3; _expectedType = typeof(global::Luny.UnityEngine.LuaVector2);
                        if (_arg3.TryRead<global::Luny.UnityEngine.LuaVector2>(out var _p3_UnityEngine_Vector2))
                        {
                            if (_argCount == 4)
                            {
                                var source = _p0_UnityEngine_Texture.Instance;
                                var dest = _p1_UnityEngine_Rendering_GraphicsTexture.Instance;
                                var scale = _p2_UnityEngine_Vector2.Value;
                                var offset = _p3_UnityEngine_Vector2.Value;
                                global::UnityEngine.Graphics.Blit(source, dest, scale, offset);
                                var _retCount = _context.Return();
                                return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                            }
                            var _arg4 = _lastArg = _argCount > 4 ? _context.GetArgument(4) : global::Lua.LuaValue.Nil;
                            _lastArgPos = 4; _expectedType = typeof(global::System.Int32);
                            if (_arg4.TryRead<global::System.Int32>(out var _p4_System_Int32))
                            {
                                var _arg5 = _lastArg = _argCount > 5 ? _context.GetArgument(5) : global::Lua.LuaValue.Nil;
                                _lastArgPos = 5; _expectedType = typeof(global::System.Int32);
                                if (_arg5.TryRead<global::System.Int32>(out var _p5_System_Int32))
                                {
                                    if (_argCount == 6)
                                    {
                                        var source = _p0_UnityEngine_Texture.Instance;
                                        var dest = _p1_UnityEngine_Rendering_GraphicsTexture.Instance;
                                        var scale = _p2_UnityEngine_Vector2.Value;
                                        var offset = _p3_UnityEngine_Vector2.Value;
                                        var sourceDepthSlice = _p4_System_Int32;
                                        var destDepthSlice = _p5_System_Int32;
                                        global::UnityEngine.Graphics.Blit(source, dest, scale, offset, sourceDepthSlice, destDepthSlice);
                                        var _retCount = _context.Return();
                                        return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                                    }
                                }
                            }
                        }
                    }
                }
                _lastArgPos = 1; _expectedType = typeof(global::Luny.UnityEngine.LuaMaterial);
                if (_arg1.TryRead<global::Luny.UnityEngine.LuaMaterial>(out var _p1_UnityEngine_Material))
                {
                    if (_argCount == 2)
                    {
                        var source = _p0_UnityEngine_Texture.Instance;
                        var mat = _p1_UnityEngine_Material.Instance;
                        global::UnityEngine.Graphics.Blit(source, mat);
                        var _retCount = _context.Return();
                        return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                    }
                    var _arg2 = _lastArg = _argCount > 2 ? _context.GetArgument(2) : global::Lua.LuaValue.Nil;
                    _lastArgPos = 2; _expectedType = typeof(global::System.Int32);
                    if (_arg2.TryRead<global::System.Int32>(out var _p2_System_Int32))
                    {
                        if (_argCount == 3)
                        {
                            var source = _p0_UnityEngine_Texture.Instance;
                            var mat = _p1_UnityEngine_Material.Instance;
                            var pass = _p2_System_Int32;
                            global::UnityEngine.Graphics.Blit(source, mat, pass);
                            var _retCount = _context.Return();
                            return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                        }
                        var _arg3 = _lastArg = _argCount > 3 ? _context.GetArgument(3) : global::Lua.LuaValue.Nil;
                        _lastArgPos = 3; _expectedType = typeof(global::System.Int32);
                        if (_arg3.TryRead<global::System.Int32>(out var _p3_System_Int32))
                        {
                            if (_argCount == 4)
                            {
                                var source = _p0_UnityEngine_Texture.Instance;
                                var mat = _p1_UnityEngine_Material.Instance;
                                var pass = _p2_System_Int32;
                                var destDepthSlice = _p3_System_Int32;
                                global::UnityEngine.Graphics.Blit(source, mat, pass, destDepthSlice);
                                var _retCount = _context.Return();
                                return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                            }
                        }
                    }
                }
            }
            throw new global::Lua.LuaRuntimeException(_context.Thread, $"{"Blit"}: invalid argument #{_lastArgPos}: {_lastArg} ({_lastArg.Type}), expected: {_expectedType.FullName}", 2);
        });
        private static readonly global::Lua.LuaFunction _LuaGraphics_BlitMultiTap = new global::Lua.LuaFunction("BlitMultiTap", (_context, _) =>
        {
            global::Lua.LuaValue _lastArg = default;
            global::System.Int32 _lastArgPos = default;
            global::System.Type _expectedType = default;
            var _argCount = _context.ArgumentCount;
            var _arg0 = _lastArg = _argCount > 0 ? _context.GetArgument(0) : global::Lua.LuaValue.Nil;
            _lastArgPos = 0; _expectedType = typeof(global::Luny.UnityEngine.LuaTexture);
            if (_arg0.TryRead<global::Luny.UnityEngine.LuaTexture>(out var _p0_UnityEngine_Texture))
            {
                var _arg1 = _lastArg = _argCount > 1 ? _context.GetArgument(1) : global::Lua.LuaValue.Nil;
                _lastArgPos = 1; _expectedType = typeof(global::Luny.UnityEngine.LuaRenderTexture);
                if (_arg1.TryRead<global::Luny.UnityEngine.LuaRenderTexture>(out var _p1_UnityEngine_RenderTexture))
                {
                    var _arg2 = _lastArg = _argCount > 2 ? _context.GetArgument(2) : global::Lua.LuaValue.Nil;
                    _lastArgPos = 2; _expectedType = typeof(global::Luny.UnityEngine.LuaMaterial);
                    if (_arg2.TryRead<global::Luny.UnityEngine.LuaMaterial>(out var _p2_UnityEngine_Material))
                    {
                        var _arg3 = _lastArg = _argCount > 3 ? _context.GetArgument(3) : global::Lua.LuaValue.Nil;
                        _lastArgPos = 3; _expectedType = typeof(global::UnityEngine.Vector2[]);
                        if (_arg3.TryReadArray<global::UnityEngine.Vector2>(out var _p3_UnityEngine_Vector2Array))
                        {
                            if (_argCount == 4)
                            {
                                var source = _p0_UnityEngine_Texture.Instance;
                                var dest = _p1_UnityEngine_RenderTexture.Instance;
                                var mat = _p2_UnityEngine_Material.Instance;
                                var offsets = _p3_UnityEngine_Vector2Array;
                                global::UnityEngine.Graphics.BlitMultiTap(source, dest, mat, offsets);
                                var _retCount = _context.Return();
                                return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                            }
                        }
                        _lastArgPos = 3; _expectedType = typeof(global::System.Int32);
                        if (_arg3.TryRead<global::System.Int32>(out var _p3_System_Int32))
                        {
                            var _arg4 = _lastArg = _argCount > 4 ? _context.GetArgument(4) : global::Lua.LuaValue.Nil;
                            _lastArgPos = 4; _expectedType = typeof(global::UnityEngine.Vector2[]);
                            if (_arg4.TryReadArray<global::UnityEngine.Vector2>(out var _p4_UnityEngine_Vector2Array))
                            {
                                if (_argCount == 5)
                                {
                                    var source = _p0_UnityEngine_Texture.Instance;
                                    var dest = _p1_UnityEngine_RenderTexture.Instance;
                                    var mat = _p2_UnityEngine_Material.Instance;
                                    var destDepthSlice = _p3_System_Int32;
                                    var offsets = _p4_UnityEngine_Vector2Array;
                                    global::UnityEngine.Graphics.BlitMultiTap(source, dest, mat, destDepthSlice, offsets);
                                    var _retCount = _context.Return();
                                    return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                                }
                            }
                        }
                    }
                }
                _lastArgPos = 1; _expectedType = typeof(global::Luny.UnityEngine.Rendering.LuaGraphicsTexture);
                if (_arg1.TryRead<global::Luny.UnityEngine.Rendering.LuaGraphicsTexture>(out var _p1_UnityEngine_Rendering_GraphicsTexture))
                {
                    var _arg2 = _lastArg = _argCount > 2 ? _context.GetArgument(2) : global::Lua.LuaValue.Nil;
                    _lastArgPos = 2; _expectedType = typeof(global::Luny.UnityEngine.LuaMaterial);
                    if (_arg2.TryRead<global::Luny.UnityEngine.LuaMaterial>(out var _p2_UnityEngine_Material))
                    {
                        var _arg3 = _lastArg = _argCount > 3 ? _context.GetArgument(3) : global::Lua.LuaValue.Nil;
                        _lastArgPos = 3; _expectedType = typeof(global::UnityEngine.Vector2[]);
                        if (_arg3.TryReadArray<global::UnityEngine.Vector2>(out var _p3_UnityEngine_Vector2Array))
                        {
                            if (_argCount == 4)
                            {
                                var source = _p0_UnityEngine_Texture.Instance;
                                var dest = _p1_UnityEngine_Rendering_GraphicsTexture.Instance;
                                var mat = _p2_UnityEngine_Material.Instance;
                                var offsets = _p3_UnityEngine_Vector2Array;
                                global::UnityEngine.Graphics.BlitMultiTap(source, dest, mat, offsets);
                                var _retCount = _context.Return();
                                return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                            }
                        }
                        _lastArgPos = 3; _expectedType = typeof(global::System.Int32);
                        if (_arg3.TryRead<global::System.Int32>(out var _p3_System_Int32))
                        {
                            var _arg4 = _lastArg = _argCount > 4 ? _context.GetArgument(4) : global::Lua.LuaValue.Nil;
                            _lastArgPos = 4; _expectedType = typeof(global::UnityEngine.Vector2[]);
                            if (_arg4.TryReadArray<global::UnityEngine.Vector2>(out var _p4_UnityEngine_Vector2Array))
                            {
                                if (_argCount == 5)
                                {
                                    var source = _p0_UnityEngine_Texture.Instance;
                                    var dest = _p1_UnityEngine_Rendering_GraphicsTexture.Instance;
                                    var mat = _p2_UnityEngine_Material.Instance;
                                    var destDepthSlice = _p3_System_Int32;
                                    var offsets = _p4_UnityEngine_Vector2Array;
                                    global::UnityEngine.Graphics.BlitMultiTap(source, dest, mat, destDepthSlice, offsets);
                                    var _retCount = _context.Return();
                                    return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                                }
                            }
                        }
                    }
                }
            }
            throw new global::Lua.LuaRuntimeException(_context.Thread, $"{"BlitMultiTap"}: invalid argument #{_lastArgPos}: {_lastArg} ({_lastArg.Type}), expected: {_expectedType.FullName}", 2);
        });
        private static readonly global::Lua.LuaFunction _LuaGraphics_ClearRandomWriteTargets = new global::Lua.LuaFunction("ClearRandomWriteTargets", (_context, _) =>
        {
            global::Lua.LuaValue _lastArg = default;
            global::System.Int32 _lastArgPos = default;
            global::System.Type _expectedType = default;
            var _argCount = _context.ArgumentCount;
            if (_argCount == 0)
            {
                global::UnityEngine.Graphics.ClearRandomWriteTargets();
                var _retCount = _context.Return();
                return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
            }
            throw new global::Lua.LuaRuntimeException(_context.Thread, $"{"ClearRandomWriteTargets"}: invalid argument #{_lastArgPos}: {_lastArg} ({_lastArg.Type}), expected: {_expectedType.FullName}", 2);
        });
        private static readonly global::Lua.LuaFunction _LuaGraphics_ConvertTexture = new global::Lua.LuaFunction("ConvertTexture", (_context, _) =>
        {
            global::Lua.LuaValue _lastArg = default;
            global::System.Int32 _lastArgPos = default;
            global::System.Type _expectedType = default;
            var _argCount = _context.ArgumentCount;
            var _arg0 = _lastArg = _argCount > 0 ? _context.GetArgument(0) : global::Lua.LuaValue.Nil;
            _lastArgPos = 0; _expectedType = typeof(global::Luny.UnityEngine.Rendering.LuaGraphicsTexture);
            if (_arg0.TryRead<global::Luny.UnityEngine.Rendering.LuaGraphicsTexture>(out var _p0_UnityEngine_Rendering_GraphicsTexture))
            {
                var _arg1 = _lastArg = _argCount > 1 ? _context.GetArgument(1) : global::Lua.LuaValue.Nil;
                _lastArgPos = 1; _expectedType = typeof(global::Luny.UnityEngine.Rendering.LuaGraphicsTexture);
                if (_arg1.TryRead<global::Luny.UnityEngine.Rendering.LuaGraphicsTexture>(out var _p1_UnityEngine_Rendering_GraphicsTexture))
                {
                    if (_argCount == 2)
                    {
                        var src = _p0_UnityEngine_Rendering_GraphicsTexture.Instance;
                        var dst = _p1_UnityEngine_Rendering_GraphicsTexture.Instance;
                        var _ret0 = global::UnityEngine.Graphics.ConvertTexture(src, dst);
                        var _lret0 = new global::Lua.LuaValue(_ret0);
                        var _retCount = _context.Return(_lret0);
                        return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                    }
                }
                _lastArgPos = 1; _expectedType = typeof(global::System.Int32);
                if (_arg1.TryRead<global::System.Int32>(out var _p1_System_Int32))
                {
                    var _arg2 = _lastArg = _argCount > 2 ? _context.GetArgument(2) : global::Lua.LuaValue.Nil;
                    _lastArgPos = 2; _expectedType = typeof(global::Luny.UnityEngine.Rendering.LuaGraphicsTexture);
                    if (_arg2.TryRead<global::Luny.UnityEngine.Rendering.LuaGraphicsTexture>(out var _p2_UnityEngine_Rendering_GraphicsTexture))
                    {
                        var _arg3 = _lastArg = _argCount > 3 ? _context.GetArgument(3) : global::Lua.LuaValue.Nil;
                        _lastArgPos = 3; _expectedType = typeof(global::System.Int32);
                        if (_arg3.TryRead<global::System.Int32>(out var _p3_System_Int32))
                        {
                            if (_argCount == 4)
                            {
                                var src = _p0_UnityEngine_Rendering_GraphicsTexture.Instance;
                                var srcElement = _p1_System_Int32;
                                var dst = _p2_UnityEngine_Rendering_GraphicsTexture.Instance;
                                var dstElement = _p3_System_Int32;
                                var _ret0 = global::UnityEngine.Graphics.ConvertTexture(src, srcElement, dst, dstElement);
                                var _lret0 = new global::Lua.LuaValue(_ret0);
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
                var _arg1 = _lastArg = _argCount > 1 ? _context.GetArgument(1) : global::Lua.LuaValue.Nil;
                _lastArgPos = 1; _expectedType = typeof(global::Luny.UnityEngine.LuaTexture);
                if (_arg1.TryRead<global::Luny.UnityEngine.LuaTexture>(out var _p1_UnityEngine_Texture))
                {
                    if (_argCount == 2)
                    {
                        var src = _p0_UnityEngine_Texture.Instance;
                        var dst = _p1_UnityEngine_Texture.Instance;
                        var _ret0 = global::UnityEngine.Graphics.ConvertTexture(src, dst);
                        var _lret0 = new global::Lua.LuaValue(_ret0);
                        var _retCount = _context.Return(_lret0);
                        return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                    }
                }
                _lastArgPos = 1; _expectedType = typeof(global::System.Int32);
                if (_arg1.TryRead<global::System.Int32>(out var _p1_System_Int32))
                {
                    var _arg2 = _lastArg = _argCount > 2 ? _context.GetArgument(2) : global::Lua.LuaValue.Nil;
                    _lastArgPos = 2; _expectedType = typeof(global::Luny.UnityEngine.LuaTexture);
                    if (_arg2.TryRead<global::Luny.UnityEngine.LuaTexture>(out var _p2_UnityEngine_Texture))
                    {
                        var _arg3 = _lastArg = _argCount > 3 ? _context.GetArgument(3) : global::Lua.LuaValue.Nil;
                        _lastArgPos = 3; _expectedType = typeof(global::System.Int32);
                        if (_arg3.TryRead<global::System.Int32>(out var _p3_System_Int32))
                        {
                            if (_argCount == 4)
                            {
                                var src = _p0_UnityEngine_Texture.Instance;
                                var srcElement = _p1_System_Int32;
                                var dst = _p2_UnityEngine_Texture.Instance;
                                var dstElement = _p3_System_Int32;
                                var _ret0 = global::UnityEngine.Graphics.ConvertTexture(src, srcElement, dst, dstElement);
                                var _lret0 = new global::Lua.LuaValue(_ret0);
                                var _retCount = _context.Return(_lret0);
                                return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                            }
                        }
                    }
                }
            }
            throw new global::Lua.LuaRuntimeException(_context.Thread, $"{"ConvertTexture"}: invalid argument #{_lastArgPos}: {_lastArg} ({_lastArg.Type}), expected: {_expectedType.FullName}", 2);
        });
        private static readonly global::Lua.LuaFunction _LuaGraphics_CopyBuffer = new global::Lua.LuaFunction("CopyBuffer", (_context, _) =>
        {
            global::Lua.LuaValue _lastArg = default;
            global::System.Int32 _lastArgPos = default;
            global::System.Type _expectedType = default;
            var _argCount = _context.ArgumentCount;
            var _arg0 = _lastArg = _argCount > 0 ? _context.GetArgument(0) : global::Lua.LuaValue.Nil;
            _lastArgPos = 0; _expectedType = typeof(global::Luny.UnityEngine.LuaGraphicsBuffer);
            if (_arg0.TryRead<global::Luny.UnityEngine.LuaGraphicsBuffer>(out var _p0_UnityEngine_GraphicsBuffer))
            {
                var _arg1 = _lastArg = _argCount > 1 ? _context.GetArgument(1) : global::Lua.LuaValue.Nil;
                _lastArgPos = 1; _expectedType = typeof(global::Luny.UnityEngine.LuaGraphicsBuffer);
                if (_arg1.TryRead<global::Luny.UnityEngine.LuaGraphicsBuffer>(out var _p1_UnityEngine_GraphicsBuffer))
                {
                    if (_argCount == 2)
                    {
                        var source = _p0_UnityEngine_GraphicsBuffer.Instance;
                        var dest = _p1_UnityEngine_GraphicsBuffer.Instance;
                        global::UnityEngine.Graphics.CopyBuffer(source, dest);
                        var _retCount = _context.Return();
                        return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                    }
                }
            }
            throw new global::Lua.LuaRuntimeException(_context.Thread, $"{"CopyBuffer"}: invalid argument #{_lastArgPos}: {_lastArg} ({_lastArg.Type}), expected: {_expectedType.FullName}", 2);
        });
        private static readonly global::Lua.LuaFunction _LuaGraphics_CopyTexture = new global::Lua.LuaFunction("CopyTexture", (_context, _) =>
        {
            global::Lua.LuaValue _lastArg = default;
            global::System.Int32 _lastArgPos = default;
            global::System.Type _expectedType = default;
            var _argCount = _context.ArgumentCount;
            var _arg0 = _lastArg = _argCount > 0 ? _context.GetArgument(0) : global::Lua.LuaValue.Nil;
            _lastArgPos = 0; _expectedType = typeof(global::Luny.UnityEngine.Rendering.LuaGraphicsTexture);
            if (_arg0.TryRead<global::Luny.UnityEngine.Rendering.LuaGraphicsTexture>(out var _p0_UnityEngine_Rendering_GraphicsTexture))
            {
                var _arg1 = _lastArg = _argCount > 1 ? _context.GetArgument(1) : global::Lua.LuaValue.Nil;
                _lastArgPos = 1; _expectedType = typeof(global::Luny.UnityEngine.Rendering.LuaGraphicsTexture);
                if (_arg1.TryRead<global::Luny.UnityEngine.Rendering.LuaGraphicsTexture>(out var _p1_UnityEngine_Rendering_GraphicsTexture))
                {
                    if (_argCount == 2)
                    {
                        var src = _p0_UnityEngine_Rendering_GraphicsTexture.Instance;
                        var dst = _p1_UnityEngine_Rendering_GraphicsTexture.Instance;
                        global::UnityEngine.Graphics.CopyTexture(src, dst);
                        var _retCount = _context.Return();
                        return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                    }
                }
                _lastArgPos = 1; _expectedType = typeof(global::System.Int32);
                if (_arg1.TryRead<global::System.Int32>(out var _p1_System_Int32))
                {
                    var _arg2 = _lastArg = _argCount > 2 ? _context.GetArgument(2) : global::Lua.LuaValue.Nil;
                    _lastArgPos = 2; _expectedType = typeof(global::Luny.UnityEngine.Rendering.LuaGraphicsTexture);
                    if (_arg2.TryRead<global::Luny.UnityEngine.Rendering.LuaGraphicsTexture>(out var _p2_UnityEngine_Rendering_GraphicsTexture))
                    {
                        var _arg3 = _lastArg = _argCount > 3 ? _context.GetArgument(3) : global::Lua.LuaValue.Nil;
                        _lastArgPos = 3; _expectedType = typeof(global::System.Int32);
                        if (_arg3.TryRead<global::System.Int32>(out var _p3_System_Int32))
                        {
                            if (_argCount == 4)
                            {
                                var src = _p0_UnityEngine_Rendering_GraphicsTexture.Instance;
                                var srcElement = _p1_System_Int32;
                                var dst = _p2_UnityEngine_Rendering_GraphicsTexture.Instance;
                                var dstElement = _p3_System_Int32;
                                global::UnityEngine.Graphics.CopyTexture(src, srcElement, dst, dstElement);
                                var _retCount = _context.Return();
                                return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                            }
                        }
                    }
                    _lastArgPos = 2; _expectedType = typeof(global::System.Int32);
                    if (_arg2.TryRead<global::System.Int32>(out var _p2_System_Int32))
                    {
                        var _arg3 = _lastArg = _argCount > 3 ? _context.GetArgument(3) : global::Lua.LuaValue.Nil;
                        _lastArgPos = 3; _expectedType = typeof(global::System.Int32);
                        if (_arg3.TryRead<global::System.Int32>(out var _p3_System_Int32))
                        {
                            var _arg4 = _lastArg = _argCount > 4 ? _context.GetArgument(4) : global::Lua.LuaValue.Nil;
                            _lastArgPos = 4; _expectedType = typeof(global::System.Int32);
                            if (_arg4.TryRead<global::System.Int32>(out var _p4_System_Int32))
                            {
                                var _arg5 = _lastArg = _argCount > 5 ? _context.GetArgument(5) : global::Lua.LuaValue.Nil;
                                _lastArgPos = 5; _expectedType = typeof(global::System.Int32);
                                if (_arg5.TryRead<global::System.Int32>(out var _p5_System_Int32))
                                {
                                    var _arg6 = _lastArg = _argCount > 6 ? _context.GetArgument(6) : global::Lua.LuaValue.Nil;
                                    _lastArgPos = 6; _expectedType = typeof(global::System.Int32);
                                    if (_arg6.TryRead<global::System.Int32>(out var _p6_System_Int32))
                                    {
                                        var _arg7 = _lastArg = _argCount > 7 ? _context.GetArgument(7) : global::Lua.LuaValue.Nil;
                                        _lastArgPos = 7; _expectedType = typeof(global::Luny.UnityEngine.Rendering.LuaGraphicsTexture);
                                        if (_arg7.TryRead<global::Luny.UnityEngine.Rendering.LuaGraphicsTexture>(out var _p7_UnityEngine_Rendering_GraphicsTexture))
                                        {
                                            var _arg8 = _lastArg = _argCount > 8 ? _context.GetArgument(8) : global::Lua.LuaValue.Nil;
                                            _lastArgPos = 8; _expectedType = typeof(global::System.Int32);
                                            if (_arg8.TryRead<global::System.Int32>(out var _p8_System_Int32))
                                            {
                                                var _arg9 = _lastArg = _argCount > 9 ? _context.GetArgument(9) : global::Lua.LuaValue.Nil;
                                                _lastArgPos = 9; _expectedType = typeof(global::System.Int32);
                                                if (_arg9.TryRead<global::System.Int32>(out var _p9_System_Int32))
                                                {
                                                    var _arg10 = _lastArg = _argCount > 10 ? _context.GetArgument(10) : global::Lua.LuaValue.Nil;
                                                    _lastArgPos = 10; _expectedType = typeof(global::System.Int32);
                                                    if (_arg10.TryRead<global::System.Int32>(out var _p10_System_Int32))
                                                    {
                                                        var _arg11 = _lastArg = _argCount > 11 ? _context.GetArgument(11) : global::Lua.LuaValue.Nil;
                                                        _lastArgPos = 11; _expectedType = typeof(global::System.Int32);
                                                        if (_arg11.TryRead<global::System.Int32>(out var _p11_System_Int32))
                                                        {
                                                            if (_argCount == 12)
                                                            {
                                                                var src = _p0_UnityEngine_Rendering_GraphicsTexture.Instance;
                                                                var srcElement = _p1_System_Int32;
                                                                var srcMip = _p2_System_Int32;
                                                                var srcX = _p3_System_Int32;
                                                                var srcY = _p4_System_Int32;
                                                                var srcWidth = _p5_System_Int32;
                                                                var srcHeight = _p6_System_Int32;
                                                                var dst = _p7_UnityEngine_Rendering_GraphicsTexture.Instance;
                                                                var dstElement = _p8_System_Int32;
                                                                var dstMip = _p9_System_Int32;
                                                                var dstX = _p10_System_Int32;
                                                                var dstY = _p11_System_Int32;
                                                                global::UnityEngine.Graphics.CopyTexture(src, srcElement, srcMip, srcX, srcY, srcWidth, srcHeight, dst, dstElement, dstMip, dstX, dstY);
                                                                var _retCount = _context.Return();
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
                        _lastArgPos = 3; _expectedType = typeof(global::Luny.UnityEngine.Rendering.LuaGraphicsTexture);
                        if (_arg3.TryRead<global::Luny.UnityEngine.Rendering.LuaGraphicsTexture>(out var _p3_UnityEngine_Rendering_GraphicsTexture))
                        {
                            var _arg4 = _lastArg = _argCount > 4 ? _context.GetArgument(4) : global::Lua.LuaValue.Nil;
                            _lastArgPos = 4; _expectedType = typeof(global::System.Int32);
                            if (_arg4.TryRead<global::System.Int32>(out var _p4_System_Int32))
                            {
                                var _arg5 = _lastArg = _argCount > 5 ? _context.GetArgument(5) : global::Lua.LuaValue.Nil;
                                _lastArgPos = 5; _expectedType = typeof(global::System.Int32);
                                if (_arg5.TryRead<global::System.Int32>(out var _p5_System_Int32))
                                {
                                    if (_argCount == 6)
                                    {
                                        var src = _p0_UnityEngine_Rendering_GraphicsTexture.Instance;
                                        var srcElement = _p1_System_Int32;
                                        var srcMip = _p2_System_Int32;
                                        var dst = _p3_UnityEngine_Rendering_GraphicsTexture.Instance;
                                        var dstElement = _p4_System_Int32;
                                        var dstMip = _p5_System_Int32;
                                        global::UnityEngine.Graphics.CopyTexture(src, srcElement, srcMip, dst, dstElement, dstMip);
                                        var _retCount = _context.Return();
                                        return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                                    }
                                }
                            }
                        }
                    }
                }
            }
            _lastArgPos = 0; _expectedType = typeof(global::Luny.UnityEngine.LuaTexture);
            if (_arg0.TryRead<global::Luny.UnityEngine.LuaTexture>(out var _p0_UnityEngine_Texture))
            {
                var _arg1 = _lastArg = _argCount > 1 ? _context.GetArgument(1) : global::Lua.LuaValue.Nil;
                _lastArgPos = 1; _expectedType = typeof(global::Luny.UnityEngine.LuaTexture);
                if (_arg1.TryRead<global::Luny.UnityEngine.LuaTexture>(out var _p1_UnityEngine_Texture))
                {
                    if (_argCount == 2)
                    {
                        var src = _p0_UnityEngine_Texture.Instance;
                        var dst = _p1_UnityEngine_Texture.Instance;
                        global::UnityEngine.Graphics.CopyTexture(src, dst);
                        var _retCount = _context.Return();
                        return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                    }
                }
                _lastArgPos = 1; _expectedType = typeof(global::System.Int32);
                if (_arg1.TryRead<global::System.Int32>(out var _p1_System_Int32))
                {
                    var _arg2 = _lastArg = _argCount > 2 ? _context.GetArgument(2) : global::Lua.LuaValue.Nil;
                    _lastArgPos = 2; _expectedType = typeof(global::Luny.UnityEngine.LuaTexture);
                    if (_arg2.TryRead<global::Luny.UnityEngine.LuaTexture>(out var _p2_UnityEngine_Texture))
                    {
                        var _arg3 = _lastArg = _argCount > 3 ? _context.GetArgument(3) : global::Lua.LuaValue.Nil;
                        _lastArgPos = 3; _expectedType = typeof(global::System.Int32);
                        if (_arg3.TryRead<global::System.Int32>(out var _p3_System_Int32))
                        {
                            if (_argCount == 4)
                            {
                                var src = _p0_UnityEngine_Texture.Instance;
                                var srcElement = _p1_System_Int32;
                                var dst = _p2_UnityEngine_Texture.Instance;
                                var dstElement = _p3_System_Int32;
                                global::UnityEngine.Graphics.CopyTexture(src, srcElement, dst, dstElement);
                                var _retCount = _context.Return();
                                return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                            }
                        }
                    }
                    _lastArgPos = 2; _expectedType = typeof(global::System.Int32);
                    if (_arg2.TryRead<global::System.Int32>(out var _p2_System_Int32))
                    {
                        var _arg3 = _lastArg = _argCount > 3 ? _context.GetArgument(3) : global::Lua.LuaValue.Nil;
                        _lastArgPos = 3; _expectedType = typeof(global::System.Int32);
                        if (_arg3.TryRead<global::System.Int32>(out var _p3_System_Int32))
                        {
                            var _arg4 = _lastArg = _argCount > 4 ? _context.GetArgument(4) : global::Lua.LuaValue.Nil;
                            _lastArgPos = 4; _expectedType = typeof(global::System.Int32);
                            if (_arg4.TryRead<global::System.Int32>(out var _p4_System_Int32))
                            {
                                var _arg5 = _lastArg = _argCount > 5 ? _context.GetArgument(5) : global::Lua.LuaValue.Nil;
                                _lastArgPos = 5; _expectedType = typeof(global::System.Int32);
                                if (_arg5.TryRead<global::System.Int32>(out var _p5_System_Int32))
                                {
                                    var _arg6 = _lastArg = _argCount > 6 ? _context.GetArgument(6) : global::Lua.LuaValue.Nil;
                                    _lastArgPos = 6; _expectedType = typeof(global::System.Int32);
                                    if (_arg6.TryRead<global::System.Int32>(out var _p6_System_Int32))
                                    {
                                        var _arg7 = _lastArg = _argCount > 7 ? _context.GetArgument(7) : global::Lua.LuaValue.Nil;
                                        _lastArgPos = 7; _expectedType = typeof(global::Luny.UnityEngine.LuaTexture);
                                        if (_arg7.TryRead<global::Luny.UnityEngine.LuaTexture>(out var _p7_UnityEngine_Texture))
                                        {
                                            var _arg8 = _lastArg = _argCount > 8 ? _context.GetArgument(8) : global::Lua.LuaValue.Nil;
                                            _lastArgPos = 8; _expectedType = typeof(global::System.Int32);
                                            if (_arg8.TryRead<global::System.Int32>(out var _p8_System_Int32))
                                            {
                                                var _arg9 = _lastArg = _argCount > 9 ? _context.GetArgument(9) : global::Lua.LuaValue.Nil;
                                                _lastArgPos = 9; _expectedType = typeof(global::System.Int32);
                                                if (_arg9.TryRead<global::System.Int32>(out var _p9_System_Int32))
                                                {
                                                    var _arg10 = _lastArg = _argCount > 10 ? _context.GetArgument(10) : global::Lua.LuaValue.Nil;
                                                    _lastArgPos = 10; _expectedType = typeof(global::System.Int32);
                                                    if (_arg10.TryRead<global::System.Int32>(out var _p10_System_Int32))
                                                    {
                                                        var _arg11 = _lastArg = _argCount > 11 ? _context.GetArgument(11) : global::Lua.LuaValue.Nil;
                                                        _lastArgPos = 11; _expectedType = typeof(global::System.Int32);
                                                        if (_arg11.TryRead<global::System.Int32>(out var _p11_System_Int32))
                                                        {
                                                            if (_argCount == 12)
                                                            {
                                                                var src = _p0_UnityEngine_Texture.Instance;
                                                                var srcElement = _p1_System_Int32;
                                                                var srcMip = _p2_System_Int32;
                                                                var srcX = _p3_System_Int32;
                                                                var srcY = _p4_System_Int32;
                                                                var srcWidth = _p5_System_Int32;
                                                                var srcHeight = _p6_System_Int32;
                                                                var dst = _p7_UnityEngine_Texture.Instance;
                                                                var dstElement = _p8_System_Int32;
                                                                var dstMip = _p9_System_Int32;
                                                                var dstX = _p10_System_Int32;
                                                                var dstY = _p11_System_Int32;
                                                                global::UnityEngine.Graphics.CopyTexture(src, srcElement, srcMip, srcX, srcY, srcWidth, srcHeight, dst, dstElement, dstMip, dstX, dstY);
                                                                var _retCount = _context.Return();
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
                        _lastArgPos = 3; _expectedType = typeof(global::Luny.UnityEngine.LuaTexture);
                        if (_arg3.TryRead<global::Luny.UnityEngine.LuaTexture>(out var _p3_UnityEngine_Texture))
                        {
                            var _arg4 = _lastArg = _argCount > 4 ? _context.GetArgument(4) : global::Lua.LuaValue.Nil;
                            _lastArgPos = 4; _expectedType = typeof(global::System.Int32);
                            if (_arg4.TryRead<global::System.Int32>(out var _p4_System_Int32))
                            {
                                var _arg5 = _lastArg = _argCount > 5 ? _context.GetArgument(5) : global::Lua.LuaValue.Nil;
                                _lastArgPos = 5; _expectedType = typeof(global::System.Int32);
                                if (_arg5.TryRead<global::System.Int32>(out var _p5_System_Int32))
                                {
                                    if (_argCount == 6)
                                    {
                                        var src = _p0_UnityEngine_Texture.Instance;
                                        var srcElement = _p1_System_Int32;
                                        var srcMip = _p2_System_Int32;
                                        var dst = _p3_UnityEngine_Texture.Instance;
                                        var dstElement = _p4_System_Int32;
                                        var dstMip = _p5_System_Int32;
                                        global::UnityEngine.Graphics.CopyTexture(src, srcElement, srcMip, dst, dstElement, dstMip);
                                        var _retCount = _context.Return();
                                        return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                                    }
                                }
                            }
                        }
                    }
                }
            }
            throw new global::Lua.LuaRuntimeException(_context.Thread, $"{"CopyTexture"}: invalid argument #{_lastArgPos}: {_lastArg} ({_lastArg.Type}), expected: {_expectedType.FullName}", 2);
        });
        private static readonly global::Lua.LuaFunction _LuaGraphics_CreateAsyncGraphicsFence = new global::Lua.LuaFunction("CreateAsyncGraphicsFence", (_context, _) =>
        {
            global::Lua.LuaValue _lastArg = default;
            global::System.Int32 _lastArgPos = default;
            global::System.Type _expectedType = default;
            var _argCount = _context.ArgumentCount;
            if (_argCount == 0)
            {
                var _ret0 = global::UnityEngine.Graphics.CreateAsyncGraphicsFence();
                var _lret0 = global::Luny.UnityEngine.Rendering.LuaGraphicsFence.Bind(_ret0);
                var _retCount = _context.Return(_lret0);
                return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
            }
            var _arg0 = _lastArg = _argCount > 0 ? _context.GetArgument(0) : global::Lua.LuaValue.Nil;
            _lastArgPos = 0; _expectedType = typeof(global::UnityEngine.Rendering.SynchronisationStage);
            if (_arg0.TryRead<global::UnityEngine.Rendering.SynchronisationStage>(out var _p0_UnityEngine_Rendering_SynchronisationStage))
            {
                if (_argCount == 1)
                {
                    var stage = _p0_UnityEngine_Rendering_SynchronisationStage;
                    var _ret0 = global::UnityEngine.Graphics.CreateAsyncGraphicsFence(stage);
                    var _lret0 = global::Luny.UnityEngine.Rendering.LuaGraphicsFence.Bind(_ret0);
                    var _retCount = _context.Return(_lret0);
                    return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                }
            }
            throw new global::Lua.LuaRuntimeException(_context.Thread, $"{"CreateAsyncGraphicsFence"}: invalid argument #{_lastArgPos}: {_lastArg} ({_lastArg.Type}), expected: {_expectedType.FullName}", 2);
        });
        private static readonly global::Lua.LuaFunction _LuaGraphics_CreateGraphicsFence = new global::Lua.LuaFunction("CreateGraphicsFence", (_context, _) =>
        {
            global::Lua.LuaValue _lastArg = default;
            global::System.Int32 _lastArgPos = default;
            global::System.Type _expectedType = default;
            var _argCount = _context.ArgumentCount;
            var _arg0 = _lastArg = _argCount > 0 ? _context.GetArgument(0) : global::Lua.LuaValue.Nil;
            _lastArgPos = 0; _expectedType = typeof(global::UnityEngine.Rendering.GraphicsFenceType);
            if (_arg0.TryRead<global::UnityEngine.Rendering.GraphicsFenceType>(out var _p0_UnityEngine_Rendering_GraphicsFenceType))
            {
                var _arg1 = _lastArg = _argCount > 1 ? _context.GetArgument(1) : global::Lua.LuaValue.Nil;
                _lastArgPos = 1; _expectedType = typeof(global::UnityEngine.Rendering.SynchronisationStageFlags);
                if (_arg1.TryRead<global::UnityEngine.Rendering.SynchronisationStageFlags>(out var _p1_UnityEngine_Rendering_SynchronisationStageFlags))
                {
                    if (_argCount == 2)
                    {
                        var fenceType = _p0_UnityEngine_Rendering_GraphicsFenceType;
                        var stage = _p1_UnityEngine_Rendering_SynchronisationStageFlags;
                        var _ret0 = global::UnityEngine.Graphics.CreateGraphicsFence(fenceType, stage);
                        var _lret0 = global::Luny.UnityEngine.Rendering.LuaGraphicsFence.Bind(_ret0);
                        var _retCount = _context.Return(_lret0);
                        return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                    }
                }
            }
            throw new global::Lua.LuaRuntimeException(_context.Thread, $"{"CreateGraphicsFence"}: invalid argument #{_lastArgPos}: {_lastArg} ({_lastArg.Type}), expected: {_expectedType.FullName}", 2);
        });
        private static readonly global::Lua.LuaFunction _LuaGraphics_DrawMesh = new global::Lua.LuaFunction("DrawMesh", (_context, _) =>
        {
            global::Lua.LuaValue _lastArg = default;
            global::System.Int32 _lastArgPos = default;
            global::System.Type _expectedType = default;
            var _argCount = _context.ArgumentCount;
            var _arg0 = _lastArg = _argCount > 0 ? _context.GetArgument(0) : global::Lua.LuaValue.Nil;
            _lastArgPos = 0; _expectedType = typeof(global::Luny.UnityEngine.LuaMesh);
            if (_arg0.TryRead<global::Luny.UnityEngine.LuaMesh>(out var _p0_UnityEngine_Mesh))
            {
                var _arg1 = _lastArg = _argCount > 1 ? _context.GetArgument(1) : global::Lua.LuaValue.Nil;
                _lastArgPos = 1; _expectedType = typeof(global::Luny.UnityEngine.LuaMatrix4x4);
                if (_arg1.TryRead<global::Luny.UnityEngine.LuaMatrix4x4>(out var _p1_UnityEngine_Matrix4x4))
                {
                    var _arg2 = _lastArg = _argCount > 2 ? _context.GetArgument(2) : global::Lua.LuaValue.Nil;
                    _lastArgPos = 2; _expectedType = typeof(global::Luny.UnityEngine.LuaMaterial);
                    if (_arg2.TryRead<global::Luny.UnityEngine.LuaMaterial>(out var _p2_UnityEngine_Material))
                    {
                        var _arg3 = _lastArg = _argCount > 3 ? _context.GetArgument(3) : global::Lua.LuaValue.Nil;
                        _lastArgPos = 3; _expectedType = typeof(global::System.Int32);
                        if (_arg3.TryRead<global::System.Int32>(out var _p3_System_Int32))
                        {
                            if (_argCount == 4)
                            {
                                var mesh = _p0_UnityEngine_Mesh.Instance;
                                var matrix = _p1_UnityEngine_Matrix4x4.Value;
                                var material = _p2_UnityEngine_Material.Instance;
                                var layer = _p3_System_Int32;
                                global::UnityEngine.Graphics.DrawMesh(mesh, matrix, material, layer);
                                var _retCount = _context.Return();
                                return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                            }
                            var _arg4 = _lastArg = _argCount > 4 ? _context.GetArgument(4) : global::Lua.LuaValue.Nil;
                            _lastArgPos = 4; _expectedType = typeof(global::Luny.UnityEngine.LuaCamera);
                            if (_arg4.TryRead<global::Luny.UnityEngine.LuaCamera>(out var _p4_UnityEngine_Camera))
                            {
                                if (_argCount == 5)
                                {
                                    var mesh = _p0_UnityEngine_Mesh.Instance;
                                    var matrix = _p1_UnityEngine_Matrix4x4.Value;
                                    var material = _p2_UnityEngine_Material.Instance;
                                    var layer = _p3_System_Int32;
                                    var camera = _p4_UnityEngine_Camera.Instance;
                                    global::UnityEngine.Graphics.DrawMesh(mesh, matrix, material, layer, camera);
                                    var _retCount = _context.Return();
                                    return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                                }
                                var _arg5 = _lastArg = _argCount > 5 ? _context.GetArgument(5) : global::Lua.LuaValue.Nil;
                                _lastArgPos = 5; _expectedType = typeof(global::System.Int32);
                                if (_arg5.TryRead<global::System.Int32>(out var _p5_System_Int32))
                                {
                                    if (_argCount == 6)
                                    {
                                        var mesh = _p0_UnityEngine_Mesh.Instance;
                                        var matrix = _p1_UnityEngine_Matrix4x4.Value;
                                        var material = _p2_UnityEngine_Material.Instance;
                                        var layer = _p3_System_Int32;
                                        var camera = _p4_UnityEngine_Camera.Instance;
                                        var submeshIndex = _p5_System_Int32;
                                        global::UnityEngine.Graphics.DrawMesh(mesh, matrix, material, layer, camera, submeshIndex);
                                        var _retCount = _context.Return();
                                        return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                                    }
                                    var _arg6 = _lastArg = _argCount > 6 ? _context.GetArgument(6) : global::Lua.LuaValue.Nil;
                                    _lastArgPos = 6; _expectedType = typeof(global::Luny.UnityEngine.LuaMaterialPropertyBlock);
                                    if (_arg6.TryRead<global::Luny.UnityEngine.LuaMaterialPropertyBlock>(out var _p6_UnityEngine_MaterialPropertyBlock))
                                    {
                                        if (_argCount == 7)
                                        {
                                            var mesh = _p0_UnityEngine_Mesh.Instance;
                                            var matrix = _p1_UnityEngine_Matrix4x4.Value;
                                            var material = _p2_UnityEngine_Material.Instance;
                                            var layer = _p3_System_Int32;
                                            var camera = _p4_UnityEngine_Camera.Instance;
                                            var submeshIndex = _p5_System_Int32;
                                            var properties = _p6_UnityEngine_MaterialPropertyBlock.Instance;
                                            global::UnityEngine.Graphics.DrawMesh(mesh, matrix, material, layer, camera, submeshIndex, properties);
                                            var _retCount = _context.Return();
                                            return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                                        }
                                        var _arg7 = _lastArg = _argCount > 7 ? _context.GetArgument(7) : global::Lua.LuaValue.Nil;
                                        _lastArgPos = 7; _expectedType = typeof(global::System.Boolean);
                                        if (_arg7.TryRead<global::System.Boolean>(out var _p7_System_Boolean))
                                        {
                                            if (_argCount == 8)
                                            {
                                                var mesh = _p0_UnityEngine_Mesh.Instance;
                                                var matrix = _p1_UnityEngine_Matrix4x4.Value;
                                                var material = _p2_UnityEngine_Material.Instance;
                                                var layer = _p3_System_Int32;
                                                var camera = _p4_UnityEngine_Camera.Instance;
                                                var submeshIndex = _p5_System_Int32;
                                                var properties = _p6_UnityEngine_MaterialPropertyBlock.Instance;
                                                var castShadows = _p7_System_Boolean;
                                                global::UnityEngine.Graphics.DrawMesh(mesh, matrix, material, layer, camera, submeshIndex, properties, castShadows);
                                                var _retCount = _context.Return();
                                                return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                                            }
                                            var _arg8 = _lastArg = _argCount > 8 ? _context.GetArgument(8) : global::Lua.LuaValue.Nil;
                                            _lastArgPos = 8; _expectedType = typeof(global::System.Boolean);
                                            if (_arg8.TryRead<global::System.Boolean>(out var _p8_System_Boolean))
                                            {
                                                if (_argCount == 9)
                                                {
                                                    var mesh = _p0_UnityEngine_Mesh.Instance;
                                                    var matrix = _p1_UnityEngine_Matrix4x4.Value;
                                                    var material = _p2_UnityEngine_Material.Instance;
                                                    var layer = _p3_System_Int32;
                                                    var camera = _p4_UnityEngine_Camera.Instance;
                                                    var submeshIndex = _p5_System_Int32;
                                                    var properties = _p6_UnityEngine_MaterialPropertyBlock.Instance;
                                                    var castShadows = _p7_System_Boolean;
                                                    var receiveShadows = _p8_System_Boolean;
                                                    global::UnityEngine.Graphics.DrawMesh(mesh, matrix, material, layer, camera, submeshIndex, properties, castShadows, receiveShadows);
                                                    var _retCount = _context.Return();
                                                    return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                                                }
                                                var _arg9 = _lastArg = _argCount > 9 ? _context.GetArgument(9) : global::Lua.LuaValue.Nil;
                                                _lastArgPos = 9; _expectedType = typeof(global::System.Boolean);
                                                if (_arg9.TryRead<global::System.Boolean>(out var _p9_System_Boolean))
                                                {
                                                    if (_argCount == 10)
                                                    {
                                                        var mesh = _p0_UnityEngine_Mesh.Instance;
                                                        var matrix = _p1_UnityEngine_Matrix4x4.Value;
                                                        var material = _p2_UnityEngine_Material.Instance;
                                                        var layer = _p3_System_Int32;
                                                        var camera = _p4_UnityEngine_Camera.Instance;
                                                        var submeshIndex = _p5_System_Int32;
                                                        var properties = _p6_UnityEngine_MaterialPropertyBlock.Instance;
                                                        var castShadows = _p7_System_Boolean;
                                                        var receiveShadows = _p8_System_Boolean;
                                                        var useLightProbes = _p9_System_Boolean;
                                                        global::UnityEngine.Graphics.DrawMesh(mesh, matrix, material, layer, camera, submeshIndex, properties, castShadows, receiveShadows, useLightProbes);
                                                        var _retCount = _context.Return();
                                                        return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                                                    }
                                                }
                                            }
                                        }
                                        _lastArgPos = 7; _expectedType = typeof(global::UnityEngine.Rendering.ShadowCastingMode);
                                        if (_arg7.TryRead<global::UnityEngine.Rendering.ShadowCastingMode>(out var _p7_UnityEngine_Rendering_ShadowCastingMode))
                                        {
                                            if (_argCount == 8)
                                            {
                                                var mesh = _p0_UnityEngine_Mesh.Instance;
                                                var matrix = _p1_UnityEngine_Matrix4x4.Value;
                                                var material = _p2_UnityEngine_Material.Instance;
                                                var layer = _p3_System_Int32;
                                                var camera = _p4_UnityEngine_Camera.Instance;
                                                var submeshIndex = _p5_System_Int32;
                                                var properties = _p6_UnityEngine_MaterialPropertyBlock.Instance;
                                                var castShadows = _p7_UnityEngine_Rendering_ShadowCastingMode;
                                                global::UnityEngine.Graphics.DrawMesh(mesh, matrix, material, layer, camera, submeshIndex, properties, castShadows);
                                                var _retCount = _context.Return();
                                                return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                                            }
                                            var _arg8 = _lastArg = _argCount > 8 ? _context.GetArgument(8) : global::Lua.LuaValue.Nil;
                                            _lastArgPos = 8; _expectedType = typeof(global::System.Boolean);
                                            if (_arg8.TryRead<global::System.Boolean>(out var _p8_System_Boolean))
                                            {
                                                if (_argCount == 9)
                                                {
                                                    var mesh = _p0_UnityEngine_Mesh.Instance;
                                                    var matrix = _p1_UnityEngine_Matrix4x4.Value;
                                                    var material = _p2_UnityEngine_Material.Instance;
                                                    var layer = _p3_System_Int32;
                                                    var camera = _p4_UnityEngine_Camera.Instance;
                                                    var submeshIndex = _p5_System_Int32;
                                                    var properties = _p6_UnityEngine_MaterialPropertyBlock.Instance;
                                                    var castShadows = _p7_UnityEngine_Rendering_ShadowCastingMode;
                                                    var receiveShadows = _p8_System_Boolean;
                                                    global::UnityEngine.Graphics.DrawMesh(mesh, matrix, material, layer, camera, submeshIndex, properties, castShadows, receiveShadows);
                                                    var _retCount = _context.Return();
                                                    return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                                                }
                                                var _arg9 = _lastArg = _argCount > 9 ? _context.GetArgument(9) : global::Lua.LuaValue.Nil;
                                                _lastArgPos = 9; _expectedType = typeof(global::Luny.UnityEngine.LuaTransform);
                                                if (_arg9.TryRead<global::Luny.UnityEngine.LuaTransform>(out var _p9_UnityEngine_Transform))
                                                {
                                                    if (_argCount == 10)
                                                    {
                                                        var mesh = _p0_UnityEngine_Mesh.Instance;
                                                        var matrix = _p1_UnityEngine_Matrix4x4.Value;
                                                        var material = _p2_UnityEngine_Material.Instance;
                                                        var layer = _p3_System_Int32;
                                                        var camera = _p4_UnityEngine_Camera.Instance;
                                                        var submeshIndex = _p5_System_Int32;
                                                        var properties = _p6_UnityEngine_MaterialPropertyBlock.Instance;
                                                        var castShadows = _p7_UnityEngine_Rendering_ShadowCastingMode;
                                                        var receiveShadows = _p8_System_Boolean;
                                                        var probeAnchor = _p9_UnityEngine_Transform.Instance;
                                                        global::UnityEngine.Graphics.DrawMesh(mesh, matrix, material, layer, camera, submeshIndex, properties, castShadows, receiveShadows, probeAnchor);
                                                        var _retCount = _context.Return();
                                                        return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                                                    }
                                                    var _arg10 = _lastArg = _argCount > 10 ? _context.GetArgument(10) : global::Lua.LuaValue.Nil;
                                                    _lastArgPos = 10; _expectedType = typeof(global::System.Boolean);
                                                    if (_arg10.TryRead<global::System.Boolean>(out var _p10_System_Boolean))
                                                    {
                                                        if (_argCount == 11)
                                                        {
                                                            var mesh = _p0_UnityEngine_Mesh.Instance;
                                                            var matrix = _p1_UnityEngine_Matrix4x4.Value;
                                                            var material = _p2_UnityEngine_Material.Instance;
                                                            var layer = _p3_System_Int32;
                                                            var camera = _p4_UnityEngine_Camera.Instance;
                                                            var submeshIndex = _p5_System_Int32;
                                                            var properties = _p6_UnityEngine_MaterialPropertyBlock.Instance;
                                                            var castShadows = _p7_UnityEngine_Rendering_ShadowCastingMode;
                                                            var receiveShadows = _p8_System_Boolean;
                                                            var probeAnchor = _p9_UnityEngine_Transform.Instance;
                                                            var useLightProbes = _p10_System_Boolean;
                                                            global::UnityEngine.Graphics.DrawMesh(mesh, matrix, material, layer, camera, submeshIndex, properties, castShadows, receiveShadows, probeAnchor, useLightProbes);
                                                            var _retCount = _context.Return();
                                                            return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                                                        }
                                                    }
                                                    _lastArgPos = 10; _expectedType = typeof(global::UnityEngine.Rendering.LightProbeUsage);
                                                    if (_arg10.TryRead<global::UnityEngine.Rendering.LightProbeUsage>(out var _p10_UnityEngine_Rendering_LightProbeUsage))
                                                    {
                                                        if (_argCount == 11)
                                                        {
                                                            var mesh = _p0_UnityEngine_Mesh.Instance;
                                                            var matrix = _p1_UnityEngine_Matrix4x4.Value;
                                                            var material = _p2_UnityEngine_Material.Instance;
                                                            var layer = _p3_System_Int32;
                                                            var camera = _p4_UnityEngine_Camera.Instance;
                                                            var submeshIndex = _p5_System_Int32;
                                                            var properties = _p6_UnityEngine_MaterialPropertyBlock.Instance;
                                                            var castShadows = _p7_UnityEngine_Rendering_ShadowCastingMode;
                                                            var receiveShadows = _p8_System_Boolean;
                                                            var probeAnchor = _p9_UnityEngine_Transform.Instance;
                                                            var lightProbeUsage = _p10_UnityEngine_Rendering_LightProbeUsage;
                                                            global::UnityEngine.Graphics.DrawMesh(mesh, matrix, material, layer, camera, submeshIndex, properties, castShadows, receiveShadows, probeAnchor, lightProbeUsage);
                                                            var _retCount = _context.Return();
                                                            return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                                                        }
                                                        var _arg11 = _lastArg = _argCount > 11 ? _context.GetArgument(11) : global::Lua.LuaValue.Nil;
                                                        _lastArgPos = 11; _expectedType = typeof(global::Luny.UnityEngine.LuaLightProbeProxyVolume);
                                                        if (_arg11.TryRead<global::Luny.UnityEngine.LuaLightProbeProxyVolume>(out var _p11_UnityEngine_LightProbeProxyVolume))
                                                        {
                                                            if (_argCount == 12)
                                                            {
                                                                var mesh = _p0_UnityEngine_Mesh.Instance;
                                                                var matrix = _p1_UnityEngine_Matrix4x4.Value;
                                                                var material = _p2_UnityEngine_Material.Instance;
                                                                var layer = _p3_System_Int32;
                                                                var camera = _p4_UnityEngine_Camera.Instance;
                                                                var submeshIndex = _p5_System_Int32;
                                                                var properties = _p6_UnityEngine_MaterialPropertyBlock.Instance;
                                                                var castShadows = _p7_UnityEngine_Rendering_ShadowCastingMode;
                                                                var receiveShadows = _p8_System_Boolean;
                                                                var probeAnchor = _p9_UnityEngine_Transform.Instance;
                                                                var lightProbeUsage = _p10_UnityEngine_Rendering_LightProbeUsage;
                                                                var lightProbeProxyVolume = _p11_UnityEngine_LightProbeProxyVolume.Instance;
                                                                global::UnityEngine.Graphics.DrawMesh(mesh, matrix, material, layer, camera, submeshIndex, properties, castShadows, receiveShadows, probeAnchor, lightProbeUsage, lightProbeProxyVolume);
                                                                var _retCount = _context.Return();
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
                    }
                }
                _lastArgPos = 1; _expectedType = typeof(global::Luny.UnityEngine.LuaVector3);
                if (_arg1.TryRead<global::Luny.UnityEngine.LuaVector3>(out var _p1_UnityEngine_Vector3))
                {
                    var _arg2 = _lastArg = _argCount > 2 ? _context.GetArgument(2) : global::Lua.LuaValue.Nil;
                    _lastArgPos = 2; _expectedType = typeof(global::Luny.UnityEngine.LuaQuaternion);
                    if (_arg2.TryRead<global::Luny.UnityEngine.LuaQuaternion>(out var _p2_UnityEngine_Quaternion))
                    {
                        var _arg3 = _lastArg = _argCount > 3 ? _context.GetArgument(3) : global::Lua.LuaValue.Nil;
                        _lastArgPos = 3; _expectedType = typeof(global::Luny.UnityEngine.LuaMaterial);
                        if (_arg3.TryRead<global::Luny.UnityEngine.LuaMaterial>(out var _p3_UnityEngine_Material))
                        {
                            var _arg4 = _lastArg = _argCount > 4 ? _context.GetArgument(4) : global::Lua.LuaValue.Nil;
                            _lastArgPos = 4; _expectedType = typeof(global::System.Int32);
                            if (_arg4.TryRead<global::System.Int32>(out var _p4_System_Int32))
                            {
                                if (_argCount == 5)
                                {
                                    var mesh = _p0_UnityEngine_Mesh.Instance;
                                    var position = _p1_UnityEngine_Vector3.Value;
                                    var rotation = _p2_UnityEngine_Quaternion.Value;
                                    var material = _p3_UnityEngine_Material.Instance;
                                    var layer = _p4_System_Int32;
                                    global::UnityEngine.Graphics.DrawMesh(mesh, position, rotation, material, layer);
                                    var _retCount = _context.Return();
                                    return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                                }
                                var _arg5 = _lastArg = _argCount > 5 ? _context.GetArgument(5) : global::Lua.LuaValue.Nil;
                                _lastArgPos = 5; _expectedType = typeof(global::Luny.UnityEngine.LuaCamera);
                                if (_arg5.TryRead<global::Luny.UnityEngine.LuaCamera>(out var _p5_UnityEngine_Camera))
                                {
                                    if (_argCount == 6)
                                    {
                                        var mesh = _p0_UnityEngine_Mesh.Instance;
                                        var position = _p1_UnityEngine_Vector3.Value;
                                        var rotation = _p2_UnityEngine_Quaternion.Value;
                                        var material = _p3_UnityEngine_Material.Instance;
                                        var layer = _p4_System_Int32;
                                        var camera = _p5_UnityEngine_Camera.Instance;
                                        global::UnityEngine.Graphics.DrawMesh(mesh, position, rotation, material, layer, camera);
                                        var _retCount = _context.Return();
                                        return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                                    }
                                    var _arg6 = _lastArg = _argCount > 6 ? _context.GetArgument(6) : global::Lua.LuaValue.Nil;
                                    _lastArgPos = 6; _expectedType = typeof(global::System.Int32);
                                    if (_arg6.TryRead<global::System.Int32>(out var _p6_System_Int32))
                                    {
                                        if (_argCount == 7)
                                        {
                                            var mesh = _p0_UnityEngine_Mesh.Instance;
                                            var position = _p1_UnityEngine_Vector3.Value;
                                            var rotation = _p2_UnityEngine_Quaternion.Value;
                                            var material = _p3_UnityEngine_Material.Instance;
                                            var layer = _p4_System_Int32;
                                            var camera = _p5_UnityEngine_Camera.Instance;
                                            var submeshIndex = _p6_System_Int32;
                                            global::UnityEngine.Graphics.DrawMesh(mesh, position, rotation, material, layer, camera, submeshIndex);
                                            var _retCount = _context.Return();
                                            return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                                        }
                                        var _arg7 = _lastArg = _argCount > 7 ? _context.GetArgument(7) : global::Lua.LuaValue.Nil;
                                        _lastArgPos = 7; _expectedType = typeof(global::Luny.UnityEngine.LuaMaterialPropertyBlock);
                                        if (_arg7.TryRead<global::Luny.UnityEngine.LuaMaterialPropertyBlock>(out var _p7_UnityEngine_MaterialPropertyBlock))
                                        {
                                            if (_argCount == 8)
                                            {
                                                var mesh = _p0_UnityEngine_Mesh.Instance;
                                                var position = _p1_UnityEngine_Vector3.Value;
                                                var rotation = _p2_UnityEngine_Quaternion.Value;
                                                var material = _p3_UnityEngine_Material.Instance;
                                                var layer = _p4_System_Int32;
                                                var camera = _p5_UnityEngine_Camera.Instance;
                                                var submeshIndex = _p6_System_Int32;
                                                var properties = _p7_UnityEngine_MaterialPropertyBlock.Instance;
                                                global::UnityEngine.Graphics.DrawMesh(mesh, position, rotation, material, layer, camera, submeshIndex, properties);
                                                var _retCount = _context.Return();
                                                return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                                            }
                                            var _arg8 = _lastArg = _argCount > 8 ? _context.GetArgument(8) : global::Lua.LuaValue.Nil;
                                            _lastArgPos = 8; _expectedType = typeof(global::System.Boolean);
                                            if (_arg8.TryRead<global::System.Boolean>(out var _p8_System_Boolean))
                                            {
                                                if (_argCount == 9)
                                                {
                                                    var mesh = _p0_UnityEngine_Mesh.Instance;
                                                    var position = _p1_UnityEngine_Vector3.Value;
                                                    var rotation = _p2_UnityEngine_Quaternion.Value;
                                                    var material = _p3_UnityEngine_Material.Instance;
                                                    var layer = _p4_System_Int32;
                                                    var camera = _p5_UnityEngine_Camera.Instance;
                                                    var submeshIndex = _p6_System_Int32;
                                                    var properties = _p7_UnityEngine_MaterialPropertyBlock.Instance;
                                                    var castShadows = _p8_System_Boolean;
                                                    global::UnityEngine.Graphics.DrawMesh(mesh, position, rotation, material, layer, camera, submeshIndex, properties, castShadows);
                                                    var _retCount = _context.Return();
                                                    return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                                                }
                                                var _arg9 = _lastArg = _argCount > 9 ? _context.GetArgument(9) : global::Lua.LuaValue.Nil;
                                                _lastArgPos = 9; _expectedType = typeof(global::System.Boolean);
                                                if (_arg9.TryRead<global::System.Boolean>(out var _p9_System_Boolean))
                                                {
                                                    if (_argCount == 10)
                                                    {
                                                        var mesh = _p0_UnityEngine_Mesh.Instance;
                                                        var position = _p1_UnityEngine_Vector3.Value;
                                                        var rotation = _p2_UnityEngine_Quaternion.Value;
                                                        var material = _p3_UnityEngine_Material.Instance;
                                                        var layer = _p4_System_Int32;
                                                        var camera = _p5_UnityEngine_Camera.Instance;
                                                        var submeshIndex = _p6_System_Int32;
                                                        var properties = _p7_UnityEngine_MaterialPropertyBlock.Instance;
                                                        var castShadows = _p8_System_Boolean;
                                                        var receiveShadows = _p9_System_Boolean;
                                                        global::UnityEngine.Graphics.DrawMesh(mesh, position, rotation, material, layer, camera, submeshIndex, properties, castShadows, receiveShadows);
                                                        var _retCount = _context.Return();
                                                        return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                                                    }
                                                    var _arg10 = _lastArg = _argCount > 10 ? _context.GetArgument(10) : global::Lua.LuaValue.Nil;
                                                    _lastArgPos = 10; _expectedType = typeof(global::System.Boolean);
                                                    if (_arg10.TryRead<global::System.Boolean>(out var _p10_System_Boolean))
                                                    {
                                                        if (_argCount == 11)
                                                        {
                                                            var mesh = _p0_UnityEngine_Mesh.Instance;
                                                            var position = _p1_UnityEngine_Vector3.Value;
                                                            var rotation = _p2_UnityEngine_Quaternion.Value;
                                                            var material = _p3_UnityEngine_Material.Instance;
                                                            var layer = _p4_System_Int32;
                                                            var camera = _p5_UnityEngine_Camera.Instance;
                                                            var submeshIndex = _p6_System_Int32;
                                                            var properties = _p7_UnityEngine_MaterialPropertyBlock.Instance;
                                                            var castShadows = _p8_System_Boolean;
                                                            var receiveShadows = _p9_System_Boolean;
                                                            var useLightProbes = _p10_System_Boolean;
                                                            global::UnityEngine.Graphics.DrawMesh(mesh, position, rotation, material, layer, camera, submeshIndex, properties, castShadows, receiveShadows, useLightProbes);
                                                            var _retCount = _context.Return();
                                                            return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                                                        }
                                                    }
                                                }
                                            }
                                            _lastArgPos = 8; _expectedType = typeof(global::UnityEngine.Rendering.ShadowCastingMode);
                                            if (_arg8.TryRead<global::UnityEngine.Rendering.ShadowCastingMode>(out var _p8_UnityEngine_Rendering_ShadowCastingMode))
                                            {
                                                if (_argCount == 9)
                                                {
                                                    var mesh = _p0_UnityEngine_Mesh.Instance;
                                                    var position = _p1_UnityEngine_Vector3.Value;
                                                    var rotation = _p2_UnityEngine_Quaternion.Value;
                                                    var material = _p3_UnityEngine_Material.Instance;
                                                    var layer = _p4_System_Int32;
                                                    var camera = _p5_UnityEngine_Camera.Instance;
                                                    var submeshIndex = _p6_System_Int32;
                                                    var properties = _p7_UnityEngine_MaterialPropertyBlock.Instance;
                                                    var castShadows = _p8_UnityEngine_Rendering_ShadowCastingMode;
                                                    global::UnityEngine.Graphics.DrawMesh(mesh, position, rotation, material, layer, camera, submeshIndex, properties, castShadows);
                                                    var _retCount = _context.Return();
                                                    return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                                                }
                                                var _arg9 = _lastArg = _argCount > 9 ? _context.GetArgument(9) : global::Lua.LuaValue.Nil;
                                                _lastArgPos = 9; _expectedType = typeof(global::System.Boolean);
                                                if (_arg9.TryRead<global::System.Boolean>(out var _p9_System_Boolean))
                                                {
                                                    if (_argCount == 10)
                                                    {
                                                        var mesh = _p0_UnityEngine_Mesh.Instance;
                                                        var position = _p1_UnityEngine_Vector3.Value;
                                                        var rotation = _p2_UnityEngine_Quaternion.Value;
                                                        var material = _p3_UnityEngine_Material.Instance;
                                                        var layer = _p4_System_Int32;
                                                        var camera = _p5_UnityEngine_Camera.Instance;
                                                        var submeshIndex = _p6_System_Int32;
                                                        var properties = _p7_UnityEngine_MaterialPropertyBlock.Instance;
                                                        var castShadows = _p8_UnityEngine_Rendering_ShadowCastingMode;
                                                        var receiveShadows = _p9_System_Boolean;
                                                        global::UnityEngine.Graphics.DrawMesh(mesh, position, rotation, material, layer, camera, submeshIndex, properties, castShadows, receiveShadows);
                                                        var _retCount = _context.Return();
                                                        return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                                                    }
                                                    var _arg10 = _lastArg = _argCount > 10 ? _context.GetArgument(10) : global::Lua.LuaValue.Nil;
                                                    _lastArgPos = 10; _expectedType = typeof(global::Luny.UnityEngine.LuaTransform);
                                                    if (_arg10.TryRead<global::Luny.UnityEngine.LuaTransform>(out var _p10_UnityEngine_Transform))
                                                    {
                                                        if (_argCount == 11)
                                                        {
                                                            var mesh = _p0_UnityEngine_Mesh.Instance;
                                                            var position = _p1_UnityEngine_Vector3.Value;
                                                            var rotation = _p2_UnityEngine_Quaternion.Value;
                                                            var material = _p3_UnityEngine_Material.Instance;
                                                            var layer = _p4_System_Int32;
                                                            var camera = _p5_UnityEngine_Camera.Instance;
                                                            var submeshIndex = _p6_System_Int32;
                                                            var properties = _p7_UnityEngine_MaterialPropertyBlock.Instance;
                                                            var castShadows = _p8_UnityEngine_Rendering_ShadowCastingMode;
                                                            var receiveShadows = _p9_System_Boolean;
                                                            var probeAnchor = _p10_UnityEngine_Transform.Instance;
                                                            global::UnityEngine.Graphics.DrawMesh(mesh, position, rotation, material, layer, camera, submeshIndex, properties, castShadows, receiveShadows, probeAnchor);
                                                            var _retCount = _context.Return();
                                                            return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                                                        }
                                                        var _arg11 = _lastArg = _argCount > 11 ? _context.GetArgument(11) : global::Lua.LuaValue.Nil;
                                                        _lastArgPos = 11; _expectedType = typeof(global::System.Boolean);
                                                        if (_arg11.TryRead<global::System.Boolean>(out var _p11_System_Boolean))
                                                        {
                                                            if (_argCount == 12)
                                                            {
                                                                var mesh = _p0_UnityEngine_Mesh.Instance;
                                                                var position = _p1_UnityEngine_Vector3.Value;
                                                                var rotation = _p2_UnityEngine_Quaternion.Value;
                                                                var material = _p3_UnityEngine_Material.Instance;
                                                                var layer = _p4_System_Int32;
                                                                var camera = _p5_UnityEngine_Camera.Instance;
                                                                var submeshIndex = _p6_System_Int32;
                                                                var properties = _p7_UnityEngine_MaterialPropertyBlock.Instance;
                                                                var castShadows = _p8_UnityEngine_Rendering_ShadowCastingMode;
                                                                var receiveShadows = _p9_System_Boolean;
                                                                var probeAnchor = _p10_UnityEngine_Transform.Instance;
                                                                var useLightProbes = _p11_System_Boolean;
                                                                global::UnityEngine.Graphics.DrawMesh(mesh, position, rotation, material, layer, camera, submeshIndex, properties, castShadows, receiveShadows, probeAnchor, useLightProbes);
                                                                var _retCount = _context.Return();
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
                    }
                }
            }
            throw new global::Lua.LuaRuntimeException(_context.Thread, $"{"DrawMesh"}: invalid argument #{_lastArgPos}: {_lastArg} ({_lastArg.Type}), expected: {_expectedType.FullName}", 2);
        });
        private static readonly global::Lua.LuaFunction _LuaGraphics_DrawMeshInstanced = new global::Lua.LuaFunction("DrawMeshInstanced", (_context, _) =>
        {
            global::Lua.LuaValue _lastArg = default;
            global::System.Int32 _lastArgPos = default;
            global::System.Type _expectedType = default;
            var _argCount = _context.ArgumentCount;
            var _arg0 = _lastArg = _argCount > 0 ? _context.GetArgument(0) : global::Lua.LuaValue.Nil;
            _lastArgPos = 0; _expectedType = typeof(global::Luny.UnityEngine.LuaMesh);
            if (_arg0.TryRead<global::Luny.UnityEngine.LuaMesh>(out var _p0_UnityEngine_Mesh))
            {
                var _arg1 = _lastArg = _argCount > 1 ? _context.GetArgument(1) : global::Lua.LuaValue.Nil;
                _lastArgPos = 1; _expectedType = typeof(global::System.Int32);
                if (_arg1.TryRead<global::System.Int32>(out var _p1_System_Int32))
                {
                    var _arg2 = _lastArg = _argCount > 2 ? _context.GetArgument(2) : global::Lua.LuaValue.Nil;
                    _lastArgPos = 2; _expectedType = typeof(global::Luny.UnityEngine.LuaMaterial);
                    if (_arg2.TryRead<global::Luny.UnityEngine.LuaMaterial>(out var _p2_UnityEngine_Material))
                    {
                        var _arg3 = _lastArg = _argCount > 3 ? _context.GetArgument(3) : global::Lua.LuaValue.Nil;
                        _lastArgPos = 3; _expectedType = typeof(global::UnityEngine.Matrix4x4[]);
                        if (_arg3.TryReadArray<global::UnityEngine.Matrix4x4>(out var _p3_UnityEngine_Matrix4x4Array))
                        {
                            if (_argCount == 4)
                            {
                                var mesh = _p0_UnityEngine_Mesh.Instance;
                                var submeshIndex = _p1_System_Int32;
                                var material = _p2_UnityEngine_Material.Instance;
                                var matrices = _p3_UnityEngine_Matrix4x4Array;
                                global::UnityEngine.Graphics.DrawMeshInstanced(mesh, submeshIndex, material, matrices);
                                var _retCount = _context.Return();
                                return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                            }
                            var _arg4 = _lastArg = _argCount > 4 ? _context.GetArgument(4) : global::Lua.LuaValue.Nil;
                            _lastArgPos = 4; _expectedType = typeof(global::System.Int32);
                            if (_arg4.TryRead<global::System.Int32>(out var _p4_System_Int32))
                            {
                                if (_argCount == 5)
                                {
                                    var mesh = _p0_UnityEngine_Mesh.Instance;
                                    var submeshIndex = _p1_System_Int32;
                                    var material = _p2_UnityEngine_Material.Instance;
                                    var matrices = _p3_UnityEngine_Matrix4x4Array;
                                    var count = _p4_System_Int32;
                                    global::UnityEngine.Graphics.DrawMeshInstanced(mesh, submeshIndex, material, matrices, count);
                                    var _retCount = _context.Return();
                                    return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                                }
                                var _arg5 = _lastArg = _argCount > 5 ? _context.GetArgument(5) : global::Lua.LuaValue.Nil;
                                _lastArgPos = 5; _expectedType = typeof(global::Luny.UnityEngine.LuaMaterialPropertyBlock);
                                if (_arg5.TryRead<global::Luny.UnityEngine.LuaMaterialPropertyBlock>(out var _p5_UnityEngine_MaterialPropertyBlock))
                                {
                                    if (_argCount == 6)
                                    {
                                        var mesh = _p0_UnityEngine_Mesh.Instance;
                                        var submeshIndex = _p1_System_Int32;
                                        var material = _p2_UnityEngine_Material.Instance;
                                        var matrices = _p3_UnityEngine_Matrix4x4Array;
                                        var count = _p4_System_Int32;
                                        var properties = _p5_UnityEngine_MaterialPropertyBlock.Instance;
                                        global::UnityEngine.Graphics.DrawMeshInstanced(mesh, submeshIndex, material, matrices, count, properties);
                                        var _retCount = _context.Return();
                                        return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                                    }
                                    var _arg6 = _lastArg = _argCount > 6 ? _context.GetArgument(6) : global::Lua.LuaValue.Nil;
                                    _lastArgPos = 6; _expectedType = typeof(global::UnityEngine.Rendering.ShadowCastingMode);
                                    if (_arg6.TryRead<global::UnityEngine.Rendering.ShadowCastingMode>(out var _p6_UnityEngine_Rendering_ShadowCastingMode))
                                    {
                                        if (_argCount == 7)
                                        {
                                            var mesh = _p0_UnityEngine_Mesh.Instance;
                                            var submeshIndex = _p1_System_Int32;
                                            var material = _p2_UnityEngine_Material.Instance;
                                            var matrices = _p3_UnityEngine_Matrix4x4Array;
                                            var count = _p4_System_Int32;
                                            var properties = _p5_UnityEngine_MaterialPropertyBlock.Instance;
                                            var castShadows = _p6_UnityEngine_Rendering_ShadowCastingMode;
                                            global::UnityEngine.Graphics.DrawMeshInstanced(mesh, submeshIndex, material, matrices, count, properties, castShadows);
                                            var _retCount = _context.Return();
                                            return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                                        }
                                        var _arg7 = _lastArg = _argCount > 7 ? _context.GetArgument(7) : global::Lua.LuaValue.Nil;
                                        _lastArgPos = 7; _expectedType = typeof(global::System.Boolean);
                                        if (_arg7.TryRead<global::System.Boolean>(out var _p7_System_Boolean))
                                        {
                                            if (_argCount == 8)
                                            {
                                                var mesh = _p0_UnityEngine_Mesh.Instance;
                                                var submeshIndex = _p1_System_Int32;
                                                var material = _p2_UnityEngine_Material.Instance;
                                                var matrices = _p3_UnityEngine_Matrix4x4Array;
                                                var count = _p4_System_Int32;
                                                var properties = _p5_UnityEngine_MaterialPropertyBlock.Instance;
                                                var castShadows = _p6_UnityEngine_Rendering_ShadowCastingMode;
                                                var receiveShadows = _p7_System_Boolean;
                                                global::UnityEngine.Graphics.DrawMeshInstanced(mesh, submeshIndex, material, matrices, count, properties, castShadows, receiveShadows);
                                                var _retCount = _context.Return();
                                                return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                                            }
                                            var _arg8 = _lastArg = _argCount > 8 ? _context.GetArgument(8) : global::Lua.LuaValue.Nil;
                                            _lastArgPos = 8; _expectedType = typeof(global::System.Int32);
                                            if (_arg8.TryRead<global::System.Int32>(out var _p8_System_Int32))
                                            {
                                                if (_argCount == 9)
                                                {
                                                    var mesh = _p0_UnityEngine_Mesh.Instance;
                                                    var submeshIndex = _p1_System_Int32;
                                                    var material = _p2_UnityEngine_Material.Instance;
                                                    var matrices = _p3_UnityEngine_Matrix4x4Array;
                                                    var count = _p4_System_Int32;
                                                    var properties = _p5_UnityEngine_MaterialPropertyBlock.Instance;
                                                    var castShadows = _p6_UnityEngine_Rendering_ShadowCastingMode;
                                                    var receiveShadows = _p7_System_Boolean;
                                                    var layer = _p8_System_Int32;
                                                    global::UnityEngine.Graphics.DrawMeshInstanced(mesh, submeshIndex, material, matrices, count, properties, castShadows, receiveShadows, layer);
                                                    var _retCount = _context.Return();
                                                    return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                                                }
                                                var _arg9 = _lastArg = _argCount > 9 ? _context.GetArgument(9) : global::Lua.LuaValue.Nil;
                                                _lastArgPos = 9; _expectedType = typeof(global::Luny.UnityEngine.LuaCamera);
                                                if (_arg9.TryRead<global::Luny.UnityEngine.LuaCamera>(out var _p9_UnityEngine_Camera))
                                                {
                                                    if (_argCount == 10)
                                                    {
                                                        var mesh = _p0_UnityEngine_Mesh.Instance;
                                                        var submeshIndex = _p1_System_Int32;
                                                        var material = _p2_UnityEngine_Material.Instance;
                                                        var matrices = _p3_UnityEngine_Matrix4x4Array;
                                                        var count = _p4_System_Int32;
                                                        var properties = _p5_UnityEngine_MaterialPropertyBlock.Instance;
                                                        var castShadows = _p6_UnityEngine_Rendering_ShadowCastingMode;
                                                        var receiveShadows = _p7_System_Boolean;
                                                        var layer = _p8_System_Int32;
                                                        var camera = _p9_UnityEngine_Camera.Instance;
                                                        global::UnityEngine.Graphics.DrawMeshInstanced(mesh, submeshIndex, material, matrices, count, properties, castShadows, receiveShadows, layer, camera);
                                                        var _retCount = _context.Return();
                                                        return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                                                    }
                                                    var _arg10 = _lastArg = _argCount > 10 ? _context.GetArgument(10) : global::Lua.LuaValue.Nil;
                                                    _lastArgPos = 10; _expectedType = typeof(global::UnityEngine.Rendering.LightProbeUsage);
                                                    if (_arg10.TryRead<global::UnityEngine.Rendering.LightProbeUsage>(out var _p10_UnityEngine_Rendering_LightProbeUsage))
                                                    {
                                                        if (_argCount == 11)
                                                        {
                                                            var mesh = _p0_UnityEngine_Mesh.Instance;
                                                            var submeshIndex = _p1_System_Int32;
                                                            var material = _p2_UnityEngine_Material.Instance;
                                                            var matrices = _p3_UnityEngine_Matrix4x4Array;
                                                            var count = _p4_System_Int32;
                                                            var properties = _p5_UnityEngine_MaterialPropertyBlock.Instance;
                                                            var castShadows = _p6_UnityEngine_Rendering_ShadowCastingMode;
                                                            var receiveShadows = _p7_System_Boolean;
                                                            var layer = _p8_System_Int32;
                                                            var camera = _p9_UnityEngine_Camera.Instance;
                                                            var lightProbeUsage = _p10_UnityEngine_Rendering_LightProbeUsage;
                                                            global::UnityEngine.Graphics.DrawMeshInstanced(mesh, submeshIndex, material, matrices, count, properties, castShadows, receiveShadows, layer, camera, lightProbeUsage);
                                                            var _retCount = _context.Return();
                                                            return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                                                        }
                                                        var _arg11 = _lastArg = _argCount > 11 ? _context.GetArgument(11) : global::Lua.LuaValue.Nil;
                                                        _lastArgPos = 11; _expectedType = typeof(global::Luny.UnityEngine.LuaLightProbeProxyVolume);
                                                        if (_arg11.TryRead<global::Luny.UnityEngine.LuaLightProbeProxyVolume>(out var _p11_UnityEngine_LightProbeProxyVolume))
                                                        {
                                                            if (_argCount == 12)
                                                            {
                                                                var mesh = _p0_UnityEngine_Mesh.Instance;
                                                                var submeshIndex = _p1_System_Int32;
                                                                var material = _p2_UnityEngine_Material.Instance;
                                                                var matrices = _p3_UnityEngine_Matrix4x4Array;
                                                                var count = _p4_System_Int32;
                                                                var properties = _p5_UnityEngine_MaterialPropertyBlock.Instance;
                                                                var castShadows = _p6_UnityEngine_Rendering_ShadowCastingMode;
                                                                var receiveShadows = _p7_System_Boolean;
                                                                var layer = _p8_System_Int32;
                                                                var camera = _p9_UnityEngine_Camera.Instance;
                                                                var lightProbeUsage = _p10_UnityEngine_Rendering_LightProbeUsage;
                                                                var lightProbeProxyVolume = _p11_UnityEngine_LightProbeProxyVolume.Instance;
                                                                global::UnityEngine.Graphics.DrawMeshInstanced(mesh, submeshIndex, material, matrices, count, properties, castShadows, receiveShadows, layer, camera, lightProbeUsage, lightProbeProxyVolume);
                                                                var _retCount = _context.Return();
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
                    }
                }
            }
            throw new global::Lua.LuaRuntimeException(_context.Thread, $"{"DrawMeshInstanced"}: invalid argument #{_lastArgPos}: {_lastArg} ({_lastArg.Type}), expected: {_expectedType.FullName}", 2);
        });
        private static readonly global::Lua.LuaFunction _LuaGraphics_DrawMeshInstancedIndirect = new global::Lua.LuaFunction("DrawMeshInstancedIndirect", (_context, _) =>
        {
            global::Lua.LuaValue _lastArg = default;
            global::System.Int32 _lastArgPos = default;
            global::System.Type _expectedType = default;
            var _argCount = _context.ArgumentCount;
            var _arg0 = _lastArg = _argCount > 0 ? _context.GetArgument(0) : global::Lua.LuaValue.Nil;
            _lastArgPos = 0; _expectedType = typeof(global::Luny.UnityEngine.LuaMesh);
            if (_arg0.TryRead<global::Luny.UnityEngine.LuaMesh>(out var _p0_UnityEngine_Mesh))
            {
                var _arg1 = _lastArg = _argCount > 1 ? _context.GetArgument(1) : global::Lua.LuaValue.Nil;
                _lastArgPos = 1; _expectedType = typeof(global::System.Int32);
                if (_arg1.TryRead<global::System.Int32>(out var _p1_System_Int32))
                {
                    var _arg2 = _lastArg = _argCount > 2 ? _context.GetArgument(2) : global::Lua.LuaValue.Nil;
                    _lastArgPos = 2; _expectedType = typeof(global::Luny.UnityEngine.LuaMaterial);
                    if (_arg2.TryRead<global::Luny.UnityEngine.LuaMaterial>(out var _p2_UnityEngine_Material))
                    {
                        var _arg3 = _lastArg = _argCount > 3 ? _context.GetArgument(3) : global::Lua.LuaValue.Nil;
                        _lastArgPos = 3; _expectedType = typeof(global::Luny.UnityEngine.LuaBounds);
                        if (_arg3.TryRead<global::Luny.UnityEngine.LuaBounds>(out var _p3_UnityEngine_Bounds))
                        {
                            var _arg4 = _lastArg = _argCount > 4 ? _context.GetArgument(4) : global::Lua.LuaValue.Nil;
                            _lastArgPos = 4; _expectedType = typeof(global::Luny.UnityEngine.LuaComputeBuffer);
                            if (_arg4.TryRead<global::Luny.UnityEngine.LuaComputeBuffer>(out var _p4_UnityEngine_ComputeBuffer))
                            {
                                if (_argCount == 5)
                                {
                                    var mesh = _p0_UnityEngine_Mesh.Instance;
                                    var submeshIndex = _p1_System_Int32;
                                    var material = _p2_UnityEngine_Material.Instance;
                                    var bounds = _p3_UnityEngine_Bounds.Value;
                                    var bufferWithArgs = _p4_UnityEngine_ComputeBuffer.Instance;
                                    global::UnityEngine.Graphics.DrawMeshInstancedIndirect(mesh, submeshIndex, material, bounds, bufferWithArgs);
                                    var _retCount = _context.Return();
                                    return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                                }
                                var _arg5 = _lastArg = _argCount > 5 ? _context.GetArgument(5) : global::Lua.LuaValue.Nil;
                                _lastArgPos = 5; _expectedType = typeof(global::System.Int32);
                                var _p5_System_Int32 = _arg5.ReadValue<global::System.Int32>((global::System.Int32)(0));
                                {
                                    if (_argCount == 6)
                                    {
                                        var mesh = _p0_UnityEngine_Mesh.Instance;
                                        var submeshIndex = _p1_System_Int32;
                                        var material = _p2_UnityEngine_Material.Instance;
                                        var bounds = _p3_UnityEngine_Bounds.Value;
                                        var bufferWithArgs = _p4_UnityEngine_ComputeBuffer.Instance;
                                        var argsOffset = _p5_System_Int32;
                                        global::UnityEngine.Graphics.DrawMeshInstancedIndirect(mesh, submeshIndex, material, bounds, bufferWithArgs, argsOffset);
                                        var _retCount = _context.Return();
                                        return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                                    }
                                    var _arg6 = _lastArg = _argCount > 6 ? _context.GetArgument(6) : global::Lua.LuaValue.Nil;
                                    _lastArgPos = 6; _expectedType = typeof(global::Luny.UnityEngine.LuaMaterialPropertyBlock);
                                    var _p6_UnityEngine_MaterialPropertyBlock = _arg6.ReadValue<global::Luny.UnityEngine.LuaMaterialPropertyBlock>(default);
                                    {
                                        if (_argCount == 7)
                                        {
                                            var mesh = _p0_UnityEngine_Mesh.Instance;
                                            var submeshIndex = _p1_System_Int32;
                                            var material = _p2_UnityEngine_Material.Instance;
                                            var bounds = _p3_UnityEngine_Bounds.Value;
                                            var bufferWithArgs = _p4_UnityEngine_ComputeBuffer.Instance;
                                            var argsOffset = _p5_System_Int32;
                                            var properties = _p6_UnityEngine_MaterialPropertyBlock.Instance;
                                            global::UnityEngine.Graphics.DrawMeshInstancedIndirect(mesh, submeshIndex, material, bounds, bufferWithArgs, argsOffset, properties);
                                            var _retCount = _context.Return();
                                            return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                                        }
                                        var _arg7 = _lastArg = _argCount > 7 ? _context.GetArgument(7) : global::Lua.LuaValue.Nil;
                                        _lastArgPos = 7; _expectedType = typeof(global::UnityEngine.Rendering.ShadowCastingMode);
                                        var _p7_UnityEngine_Rendering_ShadowCastingMode = _arg7.ReadValue<global::UnityEngine.Rendering.ShadowCastingMode>(global::UnityEngine.Rendering.ShadowCastingMode.@On);
                                        {
                                            if (_argCount == 8)
                                            {
                                                var mesh = _p0_UnityEngine_Mesh.Instance;
                                                var submeshIndex = _p1_System_Int32;
                                                var material = _p2_UnityEngine_Material.Instance;
                                                var bounds = _p3_UnityEngine_Bounds.Value;
                                                var bufferWithArgs = _p4_UnityEngine_ComputeBuffer.Instance;
                                                var argsOffset = _p5_System_Int32;
                                                var properties = _p6_UnityEngine_MaterialPropertyBlock.Instance;
                                                var castShadows = _p7_UnityEngine_Rendering_ShadowCastingMode;
                                                global::UnityEngine.Graphics.DrawMeshInstancedIndirect(mesh, submeshIndex, material, bounds, bufferWithArgs, argsOffset, properties, castShadows);
                                                var _retCount = _context.Return();
                                                return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                                            }
                                            var _arg8 = _lastArg = _argCount > 8 ? _context.GetArgument(8) : global::Lua.LuaValue.Nil;
                                            _lastArgPos = 8; _expectedType = typeof(global::System.Boolean);
                                            var _p8_System_Boolean = _arg8.ReadValue<global::System.Boolean>((global::System.Boolean)true);
                                            {
                                                if (_argCount == 9)
                                                {
                                                    var mesh = _p0_UnityEngine_Mesh.Instance;
                                                    var submeshIndex = _p1_System_Int32;
                                                    var material = _p2_UnityEngine_Material.Instance;
                                                    var bounds = _p3_UnityEngine_Bounds.Value;
                                                    var bufferWithArgs = _p4_UnityEngine_ComputeBuffer.Instance;
                                                    var argsOffset = _p5_System_Int32;
                                                    var properties = _p6_UnityEngine_MaterialPropertyBlock.Instance;
                                                    var castShadows = _p7_UnityEngine_Rendering_ShadowCastingMode;
                                                    var receiveShadows = _p8_System_Boolean;
                                                    global::UnityEngine.Graphics.DrawMeshInstancedIndirect(mesh, submeshIndex, material, bounds, bufferWithArgs, argsOffset, properties, castShadows, receiveShadows);
                                                    var _retCount = _context.Return();
                                                    return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                                                }
                                                var _arg9 = _lastArg = _argCount > 9 ? _context.GetArgument(9) : global::Lua.LuaValue.Nil;
                                                _lastArgPos = 9; _expectedType = typeof(global::System.Int32);
                                                var _p9_System_Int32 = _arg9.ReadValue<global::System.Int32>((global::System.Int32)(0));
                                                {
                                                    if (_argCount == 10)
                                                    {
                                                        var mesh = _p0_UnityEngine_Mesh.Instance;
                                                        var submeshIndex = _p1_System_Int32;
                                                        var material = _p2_UnityEngine_Material.Instance;
                                                        var bounds = _p3_UnityEngine_Bounds.Value;
                                                        var bufferWithArgs = _p4_UnityEngine_ComputeBuffer.Instance;
                                                        var argsOffset = _p5_System_Int32;
                                                        var properties = _p6_UnityEngine_MaterialPropertyBlock.Instance;
                                                        var castShadows = _p7_UnityEngine_Rendering_ShadowCastingMode;
                                                        var receiveShadows = _p8_System_Boolean;
                                                        var layer = _p9_System_Int32;
                                                        global::UnityEngine.Graphics.DrawMeshInstancedIndirect(mesh, submeshIndex, material, bounds, bufferWithArgs, argsOffset, properties, castShadows, receiveShadows, layer);
                                                        var _retCount = _context.Return();
                                                        return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                                                    }
                                                    var _arg10 = _lastArg = _argCount > 10 ? _context.GetArgument(10) : global::Lua.LuaValue.Nil;
                                                    _lastArgPos = 10; _expectedType = typeof(global::Luny.UnityEngine.LuaCamera);
                                                    var _p10_UnityEngine_Camera = _arg10.ReadValue<global::Luny.UnityEngine.LuaCamera>(default);
                                                    {
                                                        if (_argCount == 11)
                                                        {
                                                            var mesh = _p0_UnityEngine_Mesh.Instance;
                                                            var submeshIndex = _p1_System_Int32;
                                                            var material = _p2_UnityEngine_Material.Instance;
                                                            var bounds = _p3_UnityEngine_Bounds.Value;
                                                            var bufferWithArgs = _p4_UnityEngine_ComputeBuffer.Instance;
                                                            var argsOffset = _p5_System_Int32;
                                                            var properties = _p6_UnityEngine_MaterialPropertyBlock.Instance;
                                                            var castShadows = _p7_UnityEngine_Rendering_ShadowCastingMode;
                                                            var receiveShadows = _p8_System_Boolean;
                                                            var layer = _p9_System_Int32;
                                                            var camera = _p10_UnityEngine_Camera.Instance;
                                                            global::UnityEngine.Graphics.DrawMeshInstancedIndirect(mesh, submeshIndex, material, bounds, bufferWithArgs, argsOffset, properties, castShadows, receiveShadows, layer, camera);
                                                            var _retCount = _context.Return();
                                                            return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                                                        }
                                                        var _arg11 = _lastArg = _argCount > 11 ? _context.GetArgument(11) : global::Lua.LuaValue.Nil;
                                                        _lastArgPos = 11; _expectedType = typeof(global::UnityEngine.Rendering.LightProbeUsage);
                                                        var _p11_UnityEngine_Rendering_LightProbeUsage = _arg11.ReadValue<global::UnityEngine.Rendering.LightProbeUsage>(global::UnityEngine.Rendering.LightProbeUsage.@BlendProbes);
                                                        {
                                                            if (_argCount == 12)
                                                            {
                                                                var mesh = _p0_UnityEngine_Mesh.Instance;
                                                                var submeshIndex = _p1_System_Int32;
                                                                var material = _p2_UnityEngine_Material.Instance;
                                                                var bounds = _p3_UnityEngine_Bounds.Value;
                                                                var bufferWithArgs = _p4_UnityEngine_ComputeBuffer.Instance;
                                                                var argsOffset = _p5_System_Int32;
                                                                var properties = _p6_UnityEngine_MaterialPropertyBlock.Instance;
                                                                var castShadows = _p7_UnityEngine_Rendering_ShadowCastingMode;
                                                                var receiveShadows = _p8_System_Boolean;
                                                                var layer = _p9_System_Int32;
                                                                var camera = _p10_UnityEngine_Camera.Instance;
                                                                var lightProbeUsage = _p11_UnityEngine_Rendering_LightProbeUsage;
                                                                global::UnityEngine.Graphics.DrawMeshInstancedIndirect(mesh, submeshIndex, material, bounds, bufferWithArgs, argsOffset, properties, castShadows, receiveShadows, layer, camera, lightProbeUsage);
                                                                var _retCount = _context.Return();
                                                                return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                                                            }
                                                            var _arg12 = _lastArg = _argCount > 12 ? _context.GetArgument(12) : global::Lua.LuaValue.Nil;
                                                            _lastArgPos = 12; _expectedType = typeof(global::Luny.UnityEngine.LuaLightProbeProxyVolume);
                                                            if (_arg12.TryRead<global::Luny.UnityEngine.LuaLightProbeProxyVolume>(out var _p12_UnityEngine_LightProbeProxyVolume))
                                                            {
                                                                if (_argCount == 13)
                                                                {
                                                                    var mesh = _p0_UnityEngine_Mesh.Instance;
                                                                    var submeshIndex = _p1_System_Int32;
                                                                    var material = _p2_UnityEngine_Material.Instance;
                                                                    var bounds = _p3_UnityEngine_Bounds.Value;
                                                                    var bufferWithArgs = _p4_UnityEngine_ComputeBuffer.Instance;
                                                                    var argsOffset = _p5_System_Int32;
                                                                    var properties = _p6_UnityEngine_MaterialPropertyBlock.Instance;
                                                                    var castShadows = _p7_UnityEngine_Rendering_ShadowCastingMode;
                                                                    var receiveShadows = _p8_System_Boolean;
                                                                    var layer = _p9_System_Int32;
                                                                    var camera = _p10_UnityEngine_Camera.Instance;
                                                                    var lightProbeUsage = _p11_UnityEngine_Rendering_LightProbeUsage;
                                                                    var lightProbeProxyVolume = _p12_UnityEngine_LightProbeProxyVolume.Instance;
                                                                    global::UnityEngine.Graphics.DrawMeshInstancedIndirect(mesh, submeshIndex, material, bounds, bufferWithArgs, argsOffset, properties, castShadows, receiveShadows, layer, camera, lightProbeUsage, lightProbeProxyVolume);
                                                                    var _retCount = _context.Return();
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
                            _lastArgPos = 4; _expectedType = typeof(global::Luny.UnityEngine.LuaGraphicsBuffer);
                            if (_arg4.TryRead<global::Luny.UnityEngine.LuaGraphicsBuffer>(out var _p4_UnityEngine_GraphicsBuffer))
                            {
                                if (_argCount == 5)
                                {
                                    var mesh = _p0_UnityEngine_Mesh.Instance;
                                    var submeshIndex = _p1_System_Int32;
                                    var material = _p2_UnityEngine_Material.Instance;
                                    var bounds = _p3_UnityEngine_Bounds.Value;
                                    var bufferWithArgs = _p4_UnityEngine_GraphicsBuffer.Instance;
                                    global::UnityEngine.Graphics.DrawMeshInstancedIndirect(mesh, submeshIndex, material, bounds, bufferWithArgs);
                                    var _retCount = _context.Return();
                                    return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                                }
                                var _arg5 = _lastArg = _argCount > 5 ? _context.GetArgument(5) : global::Lua.LuaValue.Nil;
                                _lastArgPos = 5; _expectedType = typeof(global::System.Int32);
                                var _p5_System_Int32 = _arg5.ReadValue<global::System.Int32>((global::System.Int32)(0));
                                {
                                    if (_argCount == 6)
                                    {
                                        var mesh = _p0_UnityEngine_Mesh.Instance;
                                        var submeshIndex = _p1_System_Int32;
                                        var material = _p2_UnityEngine_Material.Instance;
                                        var bounds = _p3_UnityEngine_Bounds.Value;
                                        var bufferWithArgs = _p4_UnityEngine_GraphicsBuffer.Instance;
                                        var argsOffset = _p5_System_Int32;
                                        global::UnityEngine.Graphics.DrawMeshInstancedIndirect(mesh, submeshIndex, material, bounds, bufferWithArgs, argsOffset);
                                        var _retCount = _context.Return();
                                        return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                                    }
                                    var _arg6 = _lastArg = _argCount > 6 ? _context.GetArgument(6) : global::Lua.LuaValue.Nil;
                                    _lastArgPos = 6; _expectedType = typeof(global::Luny.UnityEngine.LuaMaterialPropertyBlock);
                                    var _p6_UnityEngine_MaterialPropertyBlock = _arg6.ReadValue<global::Luny.UnityEngine.LuaMaterialPropertyBlock>(default);
                                    {
                                        if (_argCount == 7)
                                        {
                                            var mesh = _p0_UnityEngine_Mesh.Instance;
                                            var submeshIndex = _p1_System_Int32;
                                            var material = _p2_UnityEngine_Material.Instance;
                                            var bounds = _p3_UnityEngine_Bounds.Value;
                                            var bufferWithArgs = _p4_UnityEngine_GraphicsBuffer.Instance;
                                            var argsOffset = _p5_System_Int32;
                                            var properties = _p6_UnityEngine_MaterialPropertyBlock.Instance;
                                            global::UnityEngine.Graphics.DrawMeshInstancedIndirect(mesh, submeshIndex, material, bounds, bufferWithArgs, argsOffset, properties);
                                            var _retCount = _context.Return();
                                            return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                                        }
                                        var _arg7 = _lastArg = _argCount > 7 ? _context.GetArgument(7) : global::Lua.LuaValue.Nil;
                                        _lastArgPos = 7; _expectedType = typeof(global::UnityEngine.Rendering.ShadowCastingMode);
                                        var _p7_UnityEngine_Rendering_ShadowCastingMode = _arg7.ReadValue<global::UnityEngine.Rendering.ShadowCastingMode>(global::UnityEngine.Rendering.ShadowCastingMode.@On);
                                        {
                                            if (_argCount == 8)
                                            {
                                                var mesh = _p0_UnityEngine_Mesh.Instance;
                                                var submeshIndex = _p1_System_Int32;
                                                var material = _p2_UnityEngine_Material.Instance;
                                                var bounds = _p3_UnityEngine_Bounds.Value;
                                                var bufferWithArgs = _p4_UnityEngine_GraphicsBuffer.Instance;
                                                var argsOffset = _p5_System_Int32;
                                                var properties = _p6_UnityEngine_MaterialPropertyBlock.Instance;
                                                var castShadows = _p7_UnityEngine_Rendering_ShadowCastingMode;
                                                global::UnityEngine.Graphics.DrawMeshInstancedIndirect(mesh, submeshIndex, material, bounds, bufferWithArgs, argsOffset, properties, castShadows);
                                                var _retCount = _context.Return();
                                                return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                                            }
                                            var _arg8 = _lastArg = _argCount > 8 ? _context.GetArgument(8) : global::Lua.LuaValue.Nil;
                                            _lastArgPos = 8; _expectedType = typeof(global::System.Boolean);
                                            var _p8_System_Boolean = _arg8.ReadValue<global::System.Boolean>((global::System.Boolean)true);
                                            {
                                                if (_argCount == 9)
                                                {
                                                    var mesh = _p0_UnityEngine_Mesh.Instance;
                                                    var submeshIndex = _p1_System_Int32;
                                                    var material = _p2_UnityEngine_Material.Instance;
                                                    var bounds = _p3_UnityEngine_Bounds.Value;
                                                    var bufferWithArgs = _p4_UnityEngine_GraphicsBuffer.Instance;
                                                    var argsOffset = _p5_System_Int32;
                                                    var properties = _p6_UnityEngine_MaterialPropertyBlock.Instance;
                                                    var castShadows = _p7_UnityEngine_Rendering_ShadowCastingMode;
                                                    var receiveShadows = _p8_System_Boolean;
                                                    global::UnityEngine.Graphics.DrawMeshInstancedIndirect(mesh, submeshIndex, material, bounds, bufferWithArgs, argsOffset, properties, castShadows, receiveShadows);
                                                    var _retCount = _context.Return();
                                                    return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                                                }
                                                var _arg9 = _lastArg = _argCount > 9 ? _context.GetArgument(9) : global::Lua.LuaValue.Nil;
                                                _lastArgPos = 9; _expectedType = typeof(global::System.Int32);
                                                var _p9_System_Int32 = _arg9.ReadValue<global::System.Int32>((global::System.Int32)(0));
                                                {
                                                    if (_argCount == 10)
                                                    {
                                                        var mesh = _p0_UnityEngine_Mesh.Instance;
                                                        var submeshIndex = _p1_System_Int32;
                                                        var material = _p2_UnityEngine_Material.Instance;
                                                        var bounds = _p3_UnityEngine_Bounds.Value;
                                                        var bufferWithArgs = _p4_UnityEngine_GraphicsBuffer.Instance;
                                                        var argsOffset = _p5_System_Int32;
                                                        var properties = _p6_UnityEngine_MaterialPropertyBlock.Instance;
                                                        var castShadows = _p7_UnityEngine_Rendering_ShadowCastingMode;
                                                        var receiveShadows = _p8_System_Boolean;
                                                        var layer = _p9_System_Int32;
                                                        global::UnityEngine.Graphics.DrawMeshInstancedIndirect(mesh, submeshIndex, material, bounds, bufferWithArgs, argsOffset, properties, castShadows, receiveShadows, layer);
                                                        var _retCount = _context.Return();
                                                        return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                                                    }
                                                    var _arg10 = _lastArg = _argCount > 10 ? _context.GetArgument(10) : global::Lua.LuaValue.Nil;
                                                    _lastArgPos = 10; _expectedType = typeof(global::Luny.UnityEngine.LuaCamera);
                                                    var _p10_UnityEngine_Camera = _arg10.ReadValue<global::Luny.UnityEngine.LuaCamera>(default);
                                                    {
                                                        if (_argCount == 11)
                                                        {
                                                            var mesh = _p0_UnityEngine_Mesh.Instance;
                                                            var submeshIndex = _p1_System_Int32;
                                                            var material = _p2_UnityEngine_Material.Instance;
                                                            var bounds = _p3_UnityEngine_Bounds.Value;
                                                            var bufferWithArgs = _p4_UnityEngine_GraphicsBuffer.Instance;
                                                            var argsOffset = _p5_System_Int32;
                                                            var properties = _p6_UnityEngine_MaterialPropertyBlock.Instance;
                                                            var castShadows = _p7_UnityEngine_Rendering_ShadowCastingMode;
                                                            var receiveShadows = _p8_System_Boolean;
                                                            var layer = _p9_System_Int32;
                                                            var camera = _p10_UnityEngine_Camera.Instance;
                                                            global::UnityEngine.Graphics.DrawMeshInstancedIndirect(mesh, submeshIndex, material, bounds, bufferWithArgs, argsOffset, properties, castShadows, receiveShadows, layer, camera);
                                                            var _retCount = _context.Return();
                                                            return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                                                        }
                                                        var _arg11 = _lastArg = _argCount > 11 ? _context.GetArgument(11) : global::Lua.LuaValue.Nil;
                                                        _lastArgPos = 11; _expectedType = typeof(global::UnityEngine.Rendering.LightProbeUsage);
                                                        var _p11_UnityEngine_Rendering_LightProbeUsage = _arg11.ReadValue<global::UnityEngine.Rendering.LightProbeUsage>(global::UnityEngine.Rendering.LightProbeUsage.@BlendProbes);
                                                        {
                                                            if (_argCount == 12)
                                                            {
                                                                var mesh = _p0_UnityEngine_Mesh.Instance;
                                                                var submeshIndex = _p1_System_Int32;
                                                                var material = _p2_UnityEngine_Material.Instance;
                                                                var bounds = _p3_UnityEngine_Bounds.Value;
                                                                var bufferWithArgs = _p4_UnityEngine_GraphicsBuffer.Instance;
                                                                var argsOffset = _p5_System_Int32;
                                                                var properties = _p6_UnityEngine_MaterialPropertyBlock.Instance;
                                                                var castShadows = _p7_UnityEngine_Rendering_ShadowCastingMode;
                                                                var receiveShadows = _p8_System_Boolean;
                                                                var layer = _p9_System_Int32;
                                                                var camera = _p10_UnityEngine_Camera.Instance;
                                                                var lightProbeUsage = _p11_UnityEngine_Rendering_LightProbeUsage;
                                                                global::UnityEngine.Graphics.DrawMeshInstancedIndirect(mesh, submeshIndex, material, bounds, bufferWithArgs, argsOffset, properties, castShadows, receiveShadows, layer, camera, lightProbeUsage);
                                                                var _retCount = _context.Return();
                                                                return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                                                            }
                                                            var _arg12 = _lastArg = _argCount > 12 ? _context.GetArgument(12) : global::Lua.LuaValue.Nil;
                                                            _lastArgPos = 12; _expectedType = typeof(global::Luny.UnityEngine.LuaLightProbeProxyVolume);
                                                            if (_arg12.TryRead<global::Luny.UnityEngine.LuaLightProbeProxyVolume>(out var _p12_UnityEngine_LightProbeProxyVolume))
                                                            {
                                                                if (_argCount == 13)
                                                                {
                                                                    var mesh = _p0_UnityEngine_Mesh.Instance;
                                                                    var submeshIndex = _p1_System_Int32;
                                                                    var material = _p2_UnityEngine_Material.Instance;
                                                                    var bounds = _p3_UnityEngine_Bounds.Value;
                                                                    var bufferWithArgs = _p4_UnityEngine_GraphicsBuffer.Instance;
                                                                    var argsOffset = _p5_System_Int32;
                                                                    var properties = _p6_UnityEngine_MaterialPropertyBlock.Instance;
                                                                    var castShadows = _p7_UnityEngine_Rendering_ShadowCastingMode;
                                                                    var receiveShadows = _p8_System_Boolean;
                                                                    var layer = _p9_System_Int32;
                                                                    var camera = _p10_UnityEngine_Camera.Instance;
                                                                    var lightProbeUsage = _p11_UnityEngine_Rendering_LightProbeUsage;
                                                                    var lightProbeProxyVolume = _p12_UnityEngine_LightProbeProxyVolume.Instance;
                                                                    global::UnityEngine.Graphics.DrawMeshInstancedIndirect(mesh, submeshIndex, material, bounds, bufferWithArgs, argsOffset, properties, castShadows, receiveShadows, layer, camera, lightProbeUsage, lightProbeProxyVolume);
                                                                    var _retCount = _context.Return();
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
                        }
                    }
                }
            }
            throw new global::Lua.LuaRuntimeException(_context.Thread, $"{"DrawMeshInstancedIndirect"}: invalid argument #{_lastArgPos}: {_lastArg} ({_lastArg.Type}), expected: {_expectedType.FullName}", 2);
        });
        private static readonly global::Lua.LuaFunction _LuaGraphics_DrawMeshInstancedProcedural = new global::Lua.LuaFunction("DrawMeshInstancedProcedural", (_context, _) =>
        {
            global::Lua.LuaValue _lastArg = default;
            global::System.Int32 _lastArgPos = default;
            global::System.Type _expectedType = default;
            var _argCount = _context.ArgumentCount;
            var _arg0 = _lastArg = _argCount > 0 ? _context.GetArgument(0) : global::Lua.LuaValue.Nil;
            _lastArgPos = 0; _expectedType = typeof(global::Luny.UnityEngine.LuaMesh);
            if (_arg0.TryRead<global::Luny.UnityEngine.LuaMesh>(out var _p0_UnityEngine_Mesh))
            {
                var _arg1 = _lastArg = _argCount > 1 ? _context.GetArgument(1) : global::Lua.LuaValue.Nil;
                _lastArgPos = 1; _expectedType = typeof(global::System.Int32);
                if (_arg1.TryRead<global::System.Int32>(out var _p1_System_Int32))
                {
                    var _arg2 = _lastArg = _argCount > 2 ? _context.GetArgument(2) : global::Lua.LuaValue.Nil;
                    _lastArgPos = 2; _expectedType = typeof(global::Luny.UnityEngine.LuaMaterial);
                    if (_arg2.TryRead<global::Luny.UnityEngine.LuaMaterial>(out var _p2_UnityEngine_Material))
                    {
                        var _arg3 = _lastArg = _argCount > 3 ? _context.GetArgument(3) : global::Lua.LuaValue.Nil;
                        _lastArgPos = 3; _expectedType = typeof(global::Luny.UnityEngine.LuaBounds);
                        if (_arg3.TryRead<global::Luny.UnityEngine.LuaBounds>(out var _p3_UnityEngine_Bounds))
                        {
                            var _arg4 = _lastArg = _argCount > 4 ? _context.GetArgument(4) : global::Lua.LuaValue.Nil;
                            _lastArgPos = 4; _expectedType = typeof(global::System.Int32);
                            if (_arg4.TryRead<global::System.Int32>(out var _p4_System_Int32))
                            {
                                if (_argCount == 5)
                                {
                                    var mesh = _p0_UnityEngine_Mesh.Instance;
                                    var submeshIndex = _p1_System_Int32;
                                    var material = _p2_UnityEngine_Material.Instance;
                                    var bounds = _p3_UnityEngine_Bounds.Value;
                                    var count = _p4_System_Int32;
                                    global::UnityEngine.Graphics.DrawMeshInstancedProcedural(mesh, submeshIndex, material, bounds, count);
                                    var _retCount = _context.Return();
                                    return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                                }
                                var _arg5 = _lastArg = _argCount > 5 ? _context.GetArgument(5) : global::Lua.LuaValue.Nil;
                                _lastArgPos = 5; _expectedType = typeof(global::Luny.UnityEngine.LuaMaterialPropertyBlock);
                                var _p5_UnityEngine_MaterialPropertyBlock = _arg5.ReadValue<global::Luny.UnityEngine.LuaMaterialPropertyBlock>(default);
                                {
                                    if (_argCount == 6)
                                    {
                                        var mesh = _p0_UnityEngine_Mesh.Instance;
                                        var submeshIndex = _p1_System_Int32;
                                        var material = _p2_UnityEngine_Material.Instance;
                                        var bounds = _p3_UnityEngine_Bounds.Value;
                                        var count = _p4_System_Int32;
                                        var properties = _p5_UnityEngine_MaterialPropertyBlock.Instance;
                                        global::UnityEngine.Graphics.DrawMeshInstancedProcedural(mesh, submeshIndex, material, bounds, count, properties);
                                        var _retCount = _context.Return();
                                        return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                                    }
                                    var _arg6 = _lastArg = _argCount > 6 ? _context.GetArgument(6) : global::Lua.LuaValue.Nil;
                                    _lastArgPos = 6; _expectedType = typeof(global::UnityEngine.Rendering.ShadowCastingMode);
                                    var _p6_UnityEngine_Rendering_ShadowCastingMode = _arg6.ReadValue<global::UnityEngine.Rendering.ShadowCastingMode>(global::UnityEngine.Rendering.ShadowCastingMode.@On);
                                    {
                                        if (_argCount == 7)
                                        {
                                            var mesh = _p0_UnityEngine_Mesh.Instance;
                                            var submeshIndex = _p1_System_Int32;
                                            var material = _p2_UnityEngine_Material.Instance;
                                            var bounds = _p3_UnityEngine_Bounds.Value;
                                            var count = _p4_System_Int32;
                                            var properties = _p5_UnityEngine_MaterialPropertyBlock.Instance;
                                            var castShadows = _p6_UnityEngine_Rendering_ShadowCastingMode;
                                            global::UnityEngine.Graphics.DrawMeshInstancedProcedural(mesh, submeshIndex, material, bounds, count, properties, castShadows);
                                            var _retCount = _context.Return();
                                            return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                                        }
                                        var _arg7 = _lastArg = _argCount > 7 ? _context.GetArgument(7) : global::Lua.LuaValue.Nil;
                                        _lastArgPos = 7; _expectedType = typeof(global::System.Boolean);
                                        var _p7_System_Boolean = _arg7.ReadValue<global::System.Boolean>((global::System.Boolean)true);
                                        {
                                            if (_argCount == 8)
                                            {
                                                var mesh = _p0_UnityEngine_Mesh.Instance;
                                                var submeshIndex = _p1_System_Int32;
                                                var material = _p2_UnityEngine_Material.Instance;
                                                var bounds = _p3_UnityEngine_Bounds.Value;
                                                var count = _p4_System_Int32;
                                                var properties = _p5_UnityEngine_MaterialPropertyBlock.Instance;
                                                var castShadows = _p6_UnityEngine_Rendering_ShadowCastingMode;
                                                var receiveShadows = _p7_System_Boolean;
                                                global::UnityEngine.Graphics.DrawMeshInstancedProcedural(mesh, submeshIndex, material, bounds, count, properties, castShadows, receiveShadows);
                                                var _retCount = _context.Return();
                                                return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                                            }
                                            var _arg8 = _lastArg = _argCount > 8 ? _context.GetArgument(8) : global::Lua.LuaValue.Nil;
                                            _lastArgPos = 8; _expectedType = typeof(global::System.Int32);
                                            var _p8_System_Int32 = _arg8.ReadValue<global::System.Int32>((global::System.Int32)(0));
                                            {
                                                if (_argCount == 9)
                                                {
                                                    var mesh = _p0_UnityEngine_Mesh.Instance;
                                                    var submeshIndex = _p1_System_Int32;
                                                    var material = _p2_UnityEngine_Material.Instance;
                                                    var bounds = _p3_UnityEngine_Bounds.Value;
                                                    var count = _p4_System_Int32;
                                                    var properties = _p5_UnityEngine_MaterialPropertyBlock.Instance;
                                                    var castShadows = _p6_UnityEngine_Rendering_ShadowCastingMode;
                                                    var receiveShadows = _p7_System_Boolean;
                                                    var layer = _p8_System_Int32;
                                                    global::UnityEngine.Graphics.DrawMeshInstancedProcedural(mesh, submeshIndex, material, bounds, count, properties, castShadows, receiveShadows, layer);
                                                    var _retCount = _context.Return();
                                                    return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                                                }
                                                var _arg9 = _lastArg = _argCount > 9 ? _context.GetArgument(9) : global::Lua.LuaValue.Nil;
                                                _lastArgPos = 9; _expectedType = typeof(global::Luny.UnityEngine.LuaCamera);
                                                var _p9_UnityEngine_Camera = _arg9.ReadValue<global::Luny.UnityEngine.LuaCamera>(default);
                                                {
                                                    if (_argCount == 10)
                                                    {
                                                        var mesh = _p0_UnityEngine_Mesh.Instance;
                                                        var submeshIndex = _p1_System_Int32;
                                                        var material = _p2_UnityEngine_Material.Instance;
                                                        var bounds = _p3_UnityEngine_Bounds.Value;
                                                        var count = _p4_System_Int32;
                                                        var properties = _p5_UnityEngine_MaterialPropertyBlock.Instance;
                                                        var castShadows = _p6_UnityEngine_Rendering_ShadowCastingMode;
                                                        var receiveShadows = _p7_System_Boolean;
                                                        var layer = _p8_System_Int32;
                                                        var camera = _p9_UnityEngine_Camera.Instance;
                                                        global::UnityEngine.Graphics.DrawMeshInstancedProcedural(mesh, submeshIndex, material, bounds, count, properties, castShadows, receiveShadows, layer, camera);
                                                        var _retCount = _context.Return();
                                                        return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                                                    }
                                                    var _arg10 = _lastArg = _argCount > 10 ? _context.GetArgument(10) : global::Lua.LuaValue.Nil;
                                                    _lastArgPos = 10; _expectedType = typeof(global::UnityEngine.Rendering.LightProbeUsage);
                                                    var _p10_UnityEngine_Rendering_LightProbeUsage = _arg10.ReadValue<global::UnityEngine.Rendering.LightProbeUsage>(global::UnityEngine.Rendering.LightProbeUsage.@BlendProbes);
                                                    {
                                                        if (_argCount == 11)
                                                        {
                                                            var mesh = _p0_UnityEngine_Mesh.Instance;
                                                            var submeshIndex = _p1_System_Int32;
                                                            var material = _p2_UnityEngine_Material.Instance;
                                                            var bounds = _p3_UnityEngine_Bounds.Value;
                                                            var count = _p4_System_Int32;
                                                            var properties = _p5_UnityEngine_MaterialPropertyBlock.Instance;
                                                            var castShadows = _p6_UnityEngine_Rendering_ShadowCastingMode;
                                                            var receiveShadows = _p7_System_Boolean;
                                                            var layer = _p8_System_Int32;
                                                            var camera = _p9_UnityEngine_Camera.Instance;
                                                            var lightProbeUsage = _p10_UnityEngine_Rendering_LightProbeUsage;
                                                            global::UnityEngine.Graphics.DrawMeshInstancedProcedural(mesh, submeshIndex, material, bounds, count, properties, castShadows, receiveShadows, layer, camera, lightProbeUsage);
                                                            var _retCount = _context.Return();
                                                            return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                                                        }
                                                        var _arg11 = _lastArg = _argCount > 11 ? _context.GetArgument(11) : global::Lua.LuaValue.Nil;
                                                        _lastArgPos = 11; _expectedType = typeof(global::Luny.UnityEngine.LuaLightProbeProxyVolume);
                                                        var _p11_UnityEngine_LightProbeProxyVolume = _arg11.ReadValue<global::Luny.UnityEngine.LuaLightProbeProxyVolume>(default);
                                                        {
                                                            if (_argCount == 12)
                                                            {
                                                                var mesh = _p0_UnityEngine_Mesh.Instance;
                                                                var submeshIndex = _p1_System_Int32;
                                                                var material = _p2_UnityEngine_Material.Instance;
                                                                var bounds = _p3_UnityEngine_Bounds.Value;
                                                                var count = _p4_System_Int32;
                                                                var properties = _p5_UnityEngine_MaterialPropertyBlock.Instance;
                                                                var castShadows = _p6_UnityEngine_Rendering_ShadowCastingMode;
                                                                var receiveShadows = _p7_System_Boolean;
                                                                var layer = _p8_System_Int32;
                                                                var camera = _p9_UnityEngine_Camera.Instance;
                                                                var lightProbeUsage = _p10_UnityEngine_Rendering_LightProbeUsage;
                                                                var lightProbeProxyVolume = _p11_UnityEngine_LightProbeProxyVolume.Instance;
                                                                global::UnityEngine.Graphics.DrawMeshInstancedProcedural(mesh, submeshIndex, material, bounds, count, properties, castShadows, receiveShadows, layer, camera, lightProbeUsage, lightProbeProxyVolume);
                                                                var _retCount = _context.Return();
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
                    }
                }
            }
            throw new global::Lua.LuaRuntimeException(_context.Thread, $"{"DrawMeshInstancedProcedural"}: invalid argument #{_lastArgPos}: {_lastArg} ({_lastArg.Type}), expected: {_expectedType.FullName}", 2);
        });
        private static readonly global::Lua.LuaFunction _LuaGraphics_DrawMeshNow = new global::Lua.LuaFunction("DrawMeshNow", (_context, _) =>
        {
            global::Lua.LuaValue _lastArg = default;
            global::System.Int32 _lastArgPos = default;
            global::System.Type _expectedType = default;
            var _argCount = _context.ArgumentCount;
            var _arg0 = _lastArg = _argCount > 0 ? _context.GetArgument(0) : global::Lua.LuaValue.Nil;
            _lastArgPos = 0; _expectedType = typeof(global::Luny.UnityEngine.LuaMesh);
            if (_arg0.TryRead<global::Luny.UnityEngine.LuaMesh>(out var _p0_UnityEngine_Mesh))
            {
                var _arg1 = _lastArg = _argCount > 1 ? _context.GetArgument(1) : global::Lua.LuaValue.Nil;
                _lastArgPos = 1; _expectedType = typeof(global::Luny.UnityEngine.LuaMatrix4x4);
                if (_arg1.TryRead<global::Luny.UnityEngine.LuaMatrix4x4>(out var _p1_UnityEngine_Matrix4x4))
                {
                    if (_argCount == 2)
                    {
                        var mesh = _p0_UnityEngine_Mesh.Instance;
                        var matrix = _p1_UnityEngine_Matrix4x4.Value;
                        global::UnityEngine.Graphics.DrawMeshNow(mesh, matrix);
                        var _retCount = _context.Return();
                        return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                    }
                    var _arg2 = _lastArg = _argCount > 2 ? _context.GetArgument(2) : global::Lua.LuaValue.Nil;
                    _lastArgPos = 2; _expectedType = typeof(global::System.Int32);
                    if (_arg2.TryRead<global::System.Int32>(out var _p2_System_Int32))
                    {
                        if (_argCount == 3)
                        {
                            var mesh = _p0_UnityEngine_Mesh.Instance;
                            var matrix = _p1_UnityEngine_Matrix4x4.Value;
                            var materialIndex = _p2_System_Int32;
                            global::UnityEngine.Graphics.DrawMeshNow(mesh, matrix, materialIndex);
                            var _retCount = _context.Return();
                            return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                        }
                    }
                }
                _lastArgPos = 1; _expectedType = typeof(global::Luny.UnityEngine.LuaVector3);
                if (_arg1.TryRead<global::Luny.UnityEngine.LuaVector3>(out var _p1_UnityEngine_Vector3))
                {
                    var _arg2 = _lastArg = _argCount > 2 ? _context.GetArgument(2) : global::Lua.LuaValue.Nil;
                    _lastArgPos = 2; _expectedType = typeof(global::Luny.UnityEngine.LuaQuaternion);
                    if (_arg2.TryRead<global::Luny.UnityEngine.LuaQuaternion>(out var _p2_UnityEngine_Quaternion))
                    {
                        if (_argCount == 3)
                        {
                            var mesh = _p0_UnityEngine_Mesh.Instance;
                            var position = _p1_UnityEngine_Vector3.Value;
                            var rotation = _p2_UnityEngine_Quaternion.Value;
                            global::UnityEngine.Graphics.DrawMeshNow(mesh, position, rotation);
                            var _retCount = _context.Return();
                            return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                        }
                        var _arg3 = _lastArg = _argCount > 3 ? _context.GetArgument(3) : global::Lua.LuaValue.Nil;
                        _lastArgPos = 3; _expectedType = typeof(global::System.Int32);
                        if (_arg3.TryRead<global::System.Int32>(out var _p3_System_Int32))
                        {
                            if (_argCount == 4)
                            {
                                var mesh = _p0_UnityEngine_Mesh.Instance;
                                var position = _p1_UnityEngine_Vector3.Value;
                                var rotation = _p2_UnityEngine_Quaternion.Value;
                                var materialIndex = _p3_System_Int32;
                                global::UnityEngine.Graphics.DrawMeshNow(mesh, position, rotation, materialIndex);
                                var _retCount = _context.Return();
                                return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                            }
                        }
                    }
                }
            }
            throw new global::Lua.LuaRuntimeException(_context.Thread, $"{"DrawMeshNow"}: invalid argument #{_lastArgPos}: {_lastArg} ({_lastArg.Type}), expected: {_expectedType.FullName}", 2);
        });
        private static readonly global::Lua.LuaFunction _LuaGraphics_DrawProcedural = new global::Lua.LuaFunction("DrawProcedural", (_context, _) =>
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
                _lastArgPos = 1; _expectedType = typeof(global::Luny.UnityEngine.LuaBounds);
                if (_arg1.TryRead<global::Luny.UnityEngine.LuaBounds>(out var _p1_UnityEngine_Bounds))
                {
                    var _arg2 = _lastArg = _argCount > 2 ? _context.GetArgument(2) : global::Lua.LuaValue.Nil;
                    _lastArgPos = 2; _expectedType = typeof(global::UnityEngine.MeshTopology);
                    if (_arg2.TryRead<global::UnityEngine.MeshTopology>(out var _p2_UnityEngine_MeshTopology))
                    {
                        var _arg3 = _lastArg = _argCount > 3 ? _context.GetArgument(3) : global::Lua.LuaValue.Nil;
                        _lastArgPos = 3; _expectedType = typeof(global::System.Int32);
                        if (_arg3.TryRead<global::System.Int32>(out var _p3_System_Int32))
                        {
                            if (_argCount == 4)
                            {
                                var material = _p0_UnityEngine_Material.Instance;
                                var bounds = _p1_UnityEngine_Bounds.Value;
                                var topology = _p2_UnityEngine_MeshTopology;
                                var vertexCount = _p3_System_Int32;
                                global::UnityEngine.Graphics.DrawProcedural(material, bounds, topology, vertexCount);
                                var _retCount = _context.Return();
                                return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                            }
                            var _arg4 = _lastArg = _argCount > 4 ? _context.GetArgument(4) : global::Lua.LuaValue.Nil;
                            _lastArgPos = 4; _expectedType = typeof(global::System.Int32);
                            var _p4_System_Int32 = _arg4.ReadValue<global::System.Int32>((global::System.Int32)(1));
                            {
                                if (_argCount == 5)
                                {
                                    var material = _p0_UnityEngine_Material.Instance;
                                    var bounds = _p1_UnityEngine_Bounds.Value;
                                    var topology = _p2_UnityEngine_MeshTopology;
                                    var vertexCount = _p3_System_Int32;
                                    var instanceCount = _p4_System_Int32;
                                    global::UnityEngine.Graphics.DrawProcedural(material, bounds, topology, vertexCount, instanceCount);
                                    var _retCount = _context.Return();
                                    return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                                }
                                var _arg5 = _lastArg = _argCount > 5 ? _context.GetArgument(5) : global::Lua.LuaValue.Nil;
                                _lastArgPos = 5; _expectedType = typeof(global::Luny.UnityEngine.LuaCamera);
                                var _p5_UnityEngine_Camera = _arg5.ReadValue<global::Luny.UnityEngine.LuaCamera>(default);
                                {
                                    if (_argCount == 6)
                                    {
                                        var material = _p0_UnityEngine_Material.Instance;
                                        var bounds = _p1_UnityEngine_Bounds.Value;
                                        var topology = _p2_UnityEngine_MeshTopology;
                                        var vertexCount = _p3_System_Int32;
                                        var instanceCount = _p4_System_Int32;
                                        var camera = _p5_UnityEngine_Camera.Instance;
                                        global::UnityEngine.Graphics.DrawProcedural(material, bounds, topology, vertexCount, instanceCount, camera);
                                        var _retCount = _context.Return();
                                        return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                                    }
                                    var _arg6 = _lastArg = _argCount > 6 ? _context.GetArgument(6) : global::Lua.LuaValue.Nil;
                                    _lastArgPos = 6; _expectedType = typeof(global::Luny.UnityEngine.LuaMaterialPropertyBlock);
                                    var _p6_UnityEngine_MaterialPropertyBlock = _arg6.ReadValue<global::Luny.UnityEngine.LuaMaterialPropertyBlock>(default);
                                    {
                                        if (_argCount == 7)
                                        {
                                            var material = _p0_UnityEngine_Material.Instance;
                                            var bounds = _p1_UnityEngine_Bounds.Value;
                                            var topology = _p2_UnityEngine_MeshTopology;
                                            var vertexCount = _p3_System_Int32;
                                            var instanceCount = _p4_System_Int32;
                                            var camera = _p5_UnityEngine_Camera.Instance;
                                            var properties = _p6_UnityEngine_MaterialPropertyBlock.Instance;
                                            global::UnityEngine.Graphics.DrawProcedural(material, bounds, topology, vertexCount, instanceCount, camera, properties);
                                            var _retCount = _context.Return();
                                            return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                                        }
                                        var _arg7 = _lastArg = _argCount > 7 ? _context.GetArgument(7) : global::Lua.LuaValue.Nil;
                                        _lastArgPos = 7; _expectedType = typeof(global::UnityEngine.Rendering.ShadowCastingMode);
                                        var _p7_UnityEngine_Rendering_ShadowCastingMode = _arg7.ReadValue<global::UnityEngine.Rendering.ShadowCastingMode>(global::UnityEngine.Rendering.ShadowCastingMode.@On);
                                        {
                                            if (_argCount == 8)
                                            {
                                                var material = _p0_UnityEngine_Material.Instance;
                                                var bounds = _p1_UnityEngine_Bounds.Value;
                                                var topology = _p2_UnityEngine_MeshTopology;
                                                var vertexCount = _p3_System_Int32;
                                                var instanceCount = _p4_System_Int32;
                                                var camera = _p5_UnityEngine_Camera.Instance;
                                                var properties = _p6_UnityEngine_MaterialPropertyBlock.Instance;
                                                var castShadows = _p7_UnityEngine_Rendering_ShadowCastingMode;
                                                global::UnityEngine.Graphics.DrawProcedural(material, bounds, topology, vertexCount, instanceCount, camera, properties, castShadows);
                                                var _retCount = _context.Return();
                                                return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                                            }
                                            var _arg8 = _lastArg = _argCount > 8 ? _context.GetArgument(8) : global::Lua.LuaValue.Nil;
                                            _lastArgPos = 8; _expectedType = typeof(global::System.Boolean);
                                            var _p8_System_Boolean = _arg8.ReadValue<global::System.Boolean>((global::System.Boolean)true);
                                            {
                                                if (_argCount == 9)
                                                {
                                                    var material = _p0_UnityEngine_Material.Instance;
                                                    var bounds = _p1_UnityEngine_Bounds.Value;
                                                    var topology = _p2_UnityEngine_MeshTopology;
                                                    var vertexCount = _p3_System_Int32;
                                                    var instanceCount = _p4_System_Int32;
                                                    var camera = _p5_UnityEngine_Camera.Instance;
                                                    var properties = _p6_UnityEngine_MaterialPropertyBlock.Instance;
                                                    var castShadows = _p7_UnityEngine_Rendering_ShadowCastingMode;
                                                    var receiveShadows = _p8_System_Boolean;
                                                    global::UnityEngine.Graphics.DrawProcedural(material, bounds, topology, vertexCount, instanceCount, camera, properties, castShadows, receiveShadows);
                                                    var _retCount = _context.Return();
                                                    return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                                                }
                                                var _arg9 = _lastArg = _argCount > 9 ? _context.GetArgument(9) : global::Lua.LuaValue.Nil;
                                                _lastArgPos = 9; _expectedType = typeof(global::System.Int32);
                                                var _p9_System_Int32 = _arg9.ReadValue<global::System.Int32>((global::System.Int32)(0));
                                                {
                                                    if (_argCount == 10)
                                                    {
                                                        var material = _p0_UnityEngine_Material.Instance;
                                                        var bounds = _p1_UnityEngine_Bounds.Value;
                                                        var topology = _p2_UnityEngine_MeshTopology;
                                                        var vertexCount = _p3_System_Int32;
                                                        var instanceCount = _p4_System_Int32;
                                                        var camera = _p5_UnityEngine_Camera.Instance;
                                                        var properties = _p6_UnityEngine_MaterialPropertyBlock.Instance;
                                                        var castShadows = _p7_UnityEngine_Rendering_ShadowCastingMode;
                                                        var receiveShadows = _p8_System_Boolean;
                                                        var layer = _p9_System_Int32;
                                                        global::UnityEngine.Graphics.DrawProcedural(material, bounds, topology, vertexCount, instanceCount, camera, properties, castShadows, receiveShadows, layer);
                                                        var _retCount = _context.Return();
                                                        return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                                                    }
                                                }
                                            }
                                        }
                                    }
                                }
                            }
                        }
                        _lastArgPos = 3; _expectedType = typeof(global::Luny.UnityEngine.LuaGraphicsBuffer);
                        if (_arg3.TryRead<global::Luny.UnityEngine.LuaGraphicsBuffer>(out var _p3_UnityEngine_GraphicsBuffer))
                        {
                            var _arg4 = _lastArg = _argCount > 4 ? _context.GetArgument(4) : global::Lua.LuaValue.Nil;
                            _lastArgPos = 4; _expectedType = typeof(global::System.Int32);
                            if (_arg4.TryRead<global::System.Int32>(out var _p4_System_Int32))
                            {
                                if (_argCount == 5)
                                {
                                    var material = _p0_UnityEngine_Material.Instance;
                                    var bounds = _p1_UnityEngine_Bounds.Value;
                                    var topology = _p2_UnityEngine_MeshTopology;
                                    var indexBuffer = _p3_UnityEngine_GraphicsBuffer.Instance;
                                    var indexCount = _p4_System_Int32;
                                    global::UnityEngine.Graphics.DrawProcedural(material, bounds, topology, indexBuffer, indexCount);
                                    var _retCount = _context.Return();
                                    return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                                }
                                var _arg5 = _lastArg = _argCount > 5 ? _context.GetArgument(5) : global::Lua.LuaValue.Nil;
                                _lastArgPos = 5; _expectedType = typeof(global::System.Int32);
                                var _p5_System_Int32 = _arg5.ReadValue<global::System.Int32>((global::System.Int32)(1));
                                {
                                    if (_argCount == 6)
                                    {
                                        var material = _p0_UnityEngine_Material.Instance;
                                        var bounds = _p1_UnityEngine_Bounds.Value;
                                        var topology = _p2_UnityEngine_MeshTopology;
                                        var indexBuffer = _p3_UnityEngine_GraphicsBuffer.Instance;
                                        var indexCount = _p4_System_Int32;
                                        var instanceCount = _p5_System_Int32;
                                        global::UnityEngine.Graphics.DrawProcedural(material, bounds, topology, indexBuffer, indexCount, instanceCount);
                                        var _retCount = _context.Return();
                                        return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                                    }
                                    var _arg6 = _lastArg = _argCount > 6 ? _context.GetArgument(6) : global::Lua.LuaValue.Nil;
                                    _lastArgPos = 6; _expectedType = typeof(global::Luny.UnityEngine.LuaCamera);
                                    var _p6_UnityEngine_Camera = _arg6.ReadValue<global::Luny.UnityEngine.LuaCamera>(default);
                                    {
                                        if (_argCount == 7)
                                        {
                                            var material = _p0_UnityEngine_Material.Instance;
                                            var bounds = _p1_UnityEngine_Bounds.Value;
                                            var topology = _p2_UnityEngine_MeshTopology;
                                            var indexBuffer = _p3_UnityEngine_GraphicsBuffer.Instance;
                                            var indexCount = _p4_System_Int32;
                                            var instanceCount = _p5_System_Int32;
                                            var camera = _p6_UnityEngine_Camera.Instance;
                                            global::UnityEngine.Graphics.DrawProcedural(material, bounds, topology, indexBuffer, indexCount, instanceCount, camera);
                                            var _retCount = _context.Return();
                                            return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                                        }
                                        var _arg7 = _lastArg = _argCount > 7 ? _context.GetArgument(7) : global::Lua.LuaValue.Nil;
                                        _lastArgPos = 7; _expectedType = typeof(global::Luny.UnityEngine.LuaMaterialPropertyBlock);
                                        var _p7_UnityEngine_MaterialPropertyBlock = _arg7.ReadValue<global::Luny.UnityEngine.LuaMaterialPropertyBlock>(default);
                                        {
                                            if (_argCount == 8)
                                            {
                                                var material = _p0_UnityEngine_Material.Instance;
                                                var bounds = _p1_UnityEngine_Bounds.Value;
                                                var topology = _p2_UnityEngine_MeshTopology;
                                                var indexBuffer = _p3_UnityEngine_GraphicsBuffer.Instance;
                                                var indexCount = _p4_System_Int32;
                                                var instanceCount = _p5_System_Int32;
                                                var camera = _p6_UnityEngine_Camera.Instance;
                                                var properties = _p7_UnityEngine_MaterialPropertyBlock.Instance;
                                                global::UnityEngine.Graphics.DrawProcedural(material, bounds, topology, indexBuffer, indexCount, instanceCount, camera, properties);
                                                var _retCount = _context.Return();
                                                return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                                            }
                                            var _arg8 = _lastArg = _argCount > 8 ? _context.GetArgument(8) : global::Lua.LuaValue.Nil;
                                            _lastArgPos = 8; _expectedType = typeof(global::UnityEngine.Rendering.ShadowCastingMode);
                                            var _p8_UnityEngine_Rendering_ShadowCastingMode = _arg8.ReadValue<global::UnityEngine.Rendering.ShadowCastingMode>(global::UnityEngine.Rendering.ShadowCastingMode.@On);
                                            {
                                                if (_argCount == 9)
                                                {
                                                    var material = _p0_UnityEngine_Material.Instance;
                                                    var bounds = _p1_UnityEngine_Bounds.Value;
                                                    var topology = _p2_UnityEngine_MeshTopology;
                                                    var indexBuffer = _p3_UnityEngine_GraphicsBuffer.Instance;
                                                    var indexCount = _p4_System_Int32;
                                                    var instanceCount = _p5_System_Int32;
                                                    var camera = _p6_UnityEngine_Camera.Instance;
                                                    var properties = _p7_UnityEngine_MaterialPropertyBlock.Instance;
                                                    var castShadows = _p8_UnityEngine_Rendering_ShadowCastingMode;
                                                    global::UnityEngine.Graphics.DrawProcedural(material, bounds, topology, indexBuffer, indexCount, instanceCount, camera, properties, castShadows);
                                                    var _retCount = _context.Return();
                                                    return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                                                }
                                                var _arg9 = _lastArg = _argCount > 9 ? _context.GetArgument(9) : global::Lua.LuaValue.Nil;
                                                _lastArgPos = 9; _expectedType = typeof(global::System.Boolean);
                                                var _p9_System_Boolean = _arg9.ReadValue<global::System.Boolean>((global::System.Boolean)true);
                                                {
                                                    if (_argCount == 10)
                                                    {
                                                        var material = _p0_UnityEngine_Material.Instance;
                                                        var bounds = _p1_UnityEngine_Bounds.Value;
                                                        var topology = _p2_UnityEngine_MeshTopology;
                                                        var indexBuffer = _p3_UnityEngine_GraphicsBuffer.Instance;
                                                        var indexCount = _p4_System_Int32;
                                                        var instanceCount = _p5_System_Int32;
                                                        var camera = _p6_UnityEngine_Camera.Instance;
                                                        var properties = _p7_UnityEngine_MaterialPropertyBlock.Instance;
                                                        var castShadows = _p8_UnityEngine_Rendering_ShadowCastingMode;
                                                        var receiveShadows = _p9_System_Boolean;
                                                        global::UnityEngine.Graphics.DrawProcedural(material, bounds, topology, indexBuffer, indexCount, instanceCount, camera, properties, castShadows, receiveShadows);
                                                        var _retCount = _context.Return();
                                                        return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                                                    }
                                                    var _arg10 = _lastArg = _argCount > 10 ? _context.GetArgument(10) : global::Lua.LuaValue.Nil;
                                                    _lastArgPos = 10; _expectedType = typeof(global::System.Int32);
                                                    var _p10_System_Int32 = _arg10.ReadValue<global::System.Int32>((global::System.Int32)(0));
                                                    {
                                                        if (_argCount == 11)
                                                        {
                                                            var material = _p0_UnityEngine_Material.Instance;
                                                            var bounds = _p1_UnityEngine_Bounds.Value;
                                                            var topology = _p2_UnityEngine_MeshTopology;
                                                            var indexBuffer = _p3_UnityEngine_GraphicsBuffer.Instance;
                                                            var indexCount = _p4_System_Int32;
                                                            var instanceCount = _p5_System_Int32;
                                                            var camera = _p6_UnityEngine_Camera.Instance;
                                                            var properties = _p7_UnityEngine_MaterialPropertyBlock.Instance;
                                                            var castShadows = _p8_UnityEngine_Rendering_ShadowCastingMode;
                                                            var receiveShadows = _p9_System_Boolean;
                                                            var layer = _p10_System_Int32;
                                                            global::UnityEngine.Graphics.DrawProcedural(material, bounds, topology, indexBuffer, indexCount, instanceCount, camera, properties, castShadows, receiveShadows, layer);
                                                            var _retCount = _context.Return();
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
                }
            }
            throw new global::Lua.LuaRuntimeException(_context.Thread, $"{"DrawProcedural"}: invalid argument #{_lastArgPos}: {_lastArg} ({_lastArg.Type}), expected: {_expectedType.FullName}", 2);
        });
        private static readonly global::Lua.LuaFunction _LuaGraphics_DrawProceduralIndirect = new global::Lua.LuaFunction("DrawProceduralIndirect", (_context, _) =>
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
                _lastArgPos = 1; _expectedType = typeof(global::Luny.UnityEngine.LuaBounds);
                if (_arg1.TryRead<global::Luny.UnityEngine.LuaBounds>(out var _p1_UnityEngine_Bounds))
                {
                    var _arg2 = _lastArg = _argCount > 2 ? _context.GetArgument(2) : global::Lua.LuaValue.Nil;
                    _lastArgPos = 2; _expectedType = typeof(global::UnityEngine.MeshTopology);
                    if (_arg2.TryRead<global::UnityEngine.MeshTopology>(out var _p2_UnityEngine_MeshTopology))
                    {
                        var _arg3 = _lastArg = _argCount > 3 ? _context.GetArgument(3) : global::Lua.LuaValue.Nil;
                        _lastArgPos = 3; _expectedType = typeof(global::Luny.UnityEngine.LuaComputeBuffer);
                        if (_arg3.TryRead<global::Luny.UnityEngine.LuaComputeBuffer>(out var _p3_UnityEngine_ComputeBuffer))
                        {
                            if (_argCount == 4)
                            {
                                var material = _p0_UnityEngine_Material.Instance;
                                var bounds = _p1_UnityEngine_Bounds.Value;
                                var topology = _p2_UnityEngine_MeshTopology;
                                var bufferWithArgs = _p3_UnityEngine_ComputeBuffer.Instance;
                                global::UnityEngine.Graphics.DrawProceduralIndirect(material, bounds, topology, bufferWithArgs);
                                var _retCount = _context.Return();
                                return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                            }
                            var _arg4 = _lastArg = _argCount > 4 ? _context.GetArgument(4) : global::Lua.LuaValue.Nil;
                            _lastArgPos = 4; _expectedType = typeof(global::System.Int32);
                            var _p4_System_Int32 = _arg4.ReadValue<global::System.Int32>((global::System.Int32)(0));
                            {
                                if (_argCount == 5)
                                {
                                    var material = _p0_UnityEngine_Material.Instance;
                                    var bounds = _p1_UnityEngine_Bounds.Value;
                                    var topology = _p2_UnityEngine_MeshTopology;
                                    var bufferWithArgs = _p3_UnityEngine_ComputeBuffer.Instance;
                                    var argsOffset = _p4_System_Int32;
                                    global::UnityEngine.Graphics.DrawProceduralIndirect(material, bounds, topology, bufferWithArgs, argsOffset);
                                    var _retCount = _context.Return();
                                    return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                                }
                                var _arg5 = _lastArg = _argCount > 5 ? _context.GetArgument(5) : global::Lua.LuaValue.Nil;
                                _lastArgPos = 5; _expectedType = typeof(global::Luny.UnityEngine.LuaCamera);
                                var _p5_UnityEngine_Camera = _arg5.ReadValue<global::Luny.UnityEngine.LuaCamera>(default);
                                {
                                    if (_argCount == 6)
                                    {
                                        var material = _p0_UnityEngine_Material.Instance;
                                        var bounds = _p1_UnityEngine_Bounds.Value;
                                        var topology = _p2_UnityEngine_MeshTopology;
                                        var bufferWithArgs = _p3_UnityEngine_ComputeBuffer.Instance;
                                        var argsOffset = _p4_System_Int32;
                                        var camera = _p5_UnityEngine_Camera.Instance;
                                        global::UnityEngine.Graphics.DrawProceduralIndirect(material, bounds, topology, bufferWithArgs, argsOffset, camera);
                                        var _retCount = _context.Return();
                                        return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                                    }
                                    var _arg6 = _lastArg = _argCount > 6 ? _context.GetArgument(6) : global::Lua.LuaValue.Nil;
                                    _lastArgPos = 6; _expectedType = typeof(global::Luny.UnityEngine.LuaMaterialPropertyBlock);
                                    var _p6_UnityEngine_MaterialPropertyBlock = _arg6.ReadValue<global::Luny.UnityEngine.LuaMaterialPropertyBlock>(default);
                                    {
                                        if (_argCount == 7)
                                        {
                                            var material = _p0_UnityEngine_Material.Instance;
                                            var bounds = _p1_UnityEngine_Bounds.Value;
                                            var topology = _p2_UnityEngine_MeshTopology;
                                            var bufferWithArgs = _p3_UnityEngine_ComputeBuffer.Instance;
                                            var argsOffset = _p4_System_Int32;
                                            var camera = _p5_UnityEngine_Camera.Instance;
                                            var properties = _p6_UnityEngine_MaterialPropertyBlock.Instance;
                                            global::UnityEngine.Graphics.DrawProceduralIndirect(material, bounds, topology, bufferWithArgs, argsOffset, camera, properties);
                                            var _retCount = _context.Return();
                                            return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                                        }
                                        var _arg7 = _lastArg = _argCount > 7 ? _context.GetArgument(7) : global::Lua.LuaValue.Nil;
                                        _lastArgPos = 7; _expectedType = typeof(global::UnityEngine.Rendering.ShadowCastingMode);
                                        var _p7_UnityEngine_Rendering_ShadowCastingMode = _arg7.ReadValue<global::UnityEngine.Rendering.ShadowCastingMode>(global::UnityEngine.Rendering.ShadowCastingMode.@On);
                                        {
                                            if (_argCount == 8)
                                            {
                                                var material = _p0_UnityEngine_Material.Instance;
                                                var bounds = _p1_UnityEngine_Bounds.Value;
                                                var topology = _p2_UnityEngine_MeshTopology;
                                                var bufferWithArgs = _p3_UnityEngine_ComputeBuffer.Instance;
                                                var argsOffset = _p4_System_Int32;
                                                var camera = _p5_UnityEngine_Camera.Instance;
                                                var properties = _p6_UnityEngine_MaterialPropertyBlock.Instance;
                                                var castShadows = _p7_UnityEngine_Rendering_ShadowCastingMode;
                                                global::UnityEngine.Graphics.DrawProceduralIndirect(material, bounds, topology, bufferWithArgs, argsOffset, camera, properties, castShadows);
                                                var _retCount = _context.Return();
                                                return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                                            }
                                            var _arg8 = _lastArg = _argCount > 8 ? _context.GetArgument(8) : global::Lua.LuaValue.Nil;
                                            _lastArgPos = 8; _expectedType = typeof(global::System.Boolean);
                                            var _p8_System_Boolean = _arg8.ReadValue<global::System.Boolean>((global::System.Boolean)true);
                                            {
                                                if (_argCount == 9)
                                                {
                                                    var material = _p0_UnityEngine_Material.Instance;
                                                    var bounds = _p1_UnityEngine_Bounds.Value;
                                                    var topology = _p2_UnityEngine_MeshTopology;
                                                    var bufferWithArgs = _p3_UnityEngine_ComputeBuffer.Instance;
                                                    var argsOffset = _p4_System_Int32;
                                                    var camera = _p5_UnityEngine_Camera.Instance;
                                                    var properties = _p6_UnityEngine_MaterialPropertyBlock.Instance;
                                                    var castShadows = _p7_UnityEngine_Rendering_ShadowCastingMode;
                                                    var receiveShadows = _p8_System_Boolean;
                                                    global::UnityEngine.Graphics.DrawProceduralIndirect(material, bounds, topology, bufferWithArgs, argsOffset, camera, properties, castShadows, receiveShadows);
                                                    var _retCount = _context.Return();
                                                    return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                                                }
                                                var _arg9 = _lastArg = _argCount > 9 ? _context.GetArgument(9) : global::Lua.LuaValue.Nil;
                                                _lastArgPos = 9; _expectedType = typeof(global::System.Int32);
                                                var _p9_System_Int32 = _arg9.ReadValue<global::System.Int32>((global::System.Int32)(0));
                                                {
                                                    if (_argCount == 10)
                                                    {
                                                        var material = _p0_UnityEngine_Material.Instance;
                                                        var bounds = _p1_UnityEngine_Bounds.Value;
                                                        var topology = _p2_UnityEngine_MeshTopology;
                                                        var bufferWithArgs = _p3_UnityEngine_ComputeBuffer.Instance;
                                                        var argsOffset = _p4_System_Int32;
                                                        var camera = _p5_UnityEngine_Camera.Instance;
                                                        var properties = _p6_UnityEngine_MaterialPropertyBlock.Instance;
                                                        var castShadows = _p7_UnityEngine_Rendering_ShadowCastingMode;
                                                        var receiveShadows = _p8_System_Boolean;
                                                        var layer = _p9_System_Int32;
                                                        global::UnityEngine.Graphics.DrawProceduralIndirect(material, bounds, topology, bufferWithArgs, argsOffset, camera, properties, castShadows, receiveShadows, layer);
                                                        var _retCount = _context.Return();
                                                        return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                                                    }
                                                }
                                            }
                                        }
                                    }
                                }
                            }
                        }
                        _lastArgPos = 3; _expectedType = typeof(global::Luny.UnityEngine.LuaGraphicsBuffer);
                        if (_arg3.TryRead<global::Luny.UnityEngine.LuaGraphicsBuffer>(out var _p3_UnityEngine_GraphicsBuffer))
                        {
                            if (_argCount == 4)
                            {
                                var material = _p0_UnityEngine_Material.Instance;
                                var bounds = _p1_UnityEngine_Bounds.Value;
                                var topology = _p2_UnityEngine_MeshTopology;
                                var bufferWithArgs = _p3_UnityEngine_GraphicsBuffer.Instance;
                                global::UnityEngine.Graphics.DrawProceduralIndirect(material, bounds, topology, bufferWithArgs);
                                var _retCount = _context.Return();
                                return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                            }
                            var _arg4 = _lastArg = _argCount > 4 ? _context.GetArgument(4) : global::Lua.LuaValue.Nil;
                            _lastArgPos = 4; _expectedType = typeof(global::System.Int32);
                            var _p4_System_Int32 = _arg4.ReadValue<global::System.Int32>((global::System.Int32)(0));
                            {
                                if (_argCount == 5)
                                {
                                    var material = _p0_UnityEngine_Material.Instance;
                                    var bounds = _p1_UnityEngine_Bounds.Value;
                                    var topology = _p2_UnityEngine_MeshTopology;
                                    var bufferWithArgs = _p3_UnityEngine_GraphicsBuffer.Instance;
                                    var argsOffset = _p4_System_Int32;
                                    global::UnityEngine.Graphics.DrawProceduralIndirect(material, bounds, topology, bufferWithArgs, argsOffset);
                                    var _retCount = _context.Return();
                                    return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                                }
                                var _arg5 = _lastArg = _argCount > 5 ? _context.GetArgument(5) : global::Lua.LuaValue.Nil;
                                _lastArgPos = 5; _expectedType = typeof(global::Luny.UnityEngine.LuaCamera);
                                var _p5_UnityEngine_Camera = _arg5.ReadValue<global::Luny.UnityEngine.LuaCamera>(default);
                                {
                                    if (_argCount == 6)
                                    {
                                        var material = _p0_UnityEngine_Material.Instance;
                                        var bounds = _p1_UnityEngine_Bounds.Value;
                                        var topology = _p2_UnityEngine_MeshTopology;
                                        var bufferWithArgs = _p3_UnityEngine_GraphicsBuffer.Instance;
                                        var argsOffset = _p4_System_Int32;
                                        var camera = _p5_UnityEngine_Camera.Instance;
                                        global::UnityEngine.Graphics.DrawProceduralIndirect(material, bounds, topology, bufferWithArgs, argsOffset, camera);
                                        var _retCount = _context.Return();
                                        return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                                    }
                                    var _arg6 = _lastArg = _argCount > 6 ? _context.GetArgument(6) : global::Lua.LuaValue.Nil;
                                    _lastArgPos = 6; _expectedType = typeof(global::Luny.UnityEngine.LuaMaterialPropertyBlock);
                                    var _p6_UnityEngine_MaterialPropertyBlock = _arg6.ReadValue<global::Luny.UnityEngine.LuaMaterialPropertyBlock>(default);
                                    {
                                        if (_argCount == 7)
                                        {
                                            var material = _p0_UnityEngine_Material.Instance;
                                            var bounds = _p1_UnityEngine_Bounds.Value;
                                            var topology = _p2_UnityEngine_MeshTopology;
                                            var bufferWithArgs = _p3_UnityEngine_GraphicsBuffer.Instance;
                                            var argsOffset = _p4_System_Int32;
                                            var camera = _p5_UnityEngine_Camera.Instance;
                                            var properties = _p6_UnityEngine_MaterialPropertyBlock.Instance;
                                            global::UnityEngine.Graphics.DrawProceduralIndirect(material, bounds, topology, bufferWithArgs, argsOffset, camera, properties);
                                            var _retCount = _context.Return();
                                            return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                                        }
                                        var _arg7 = _lastArg = _argCount > 7 ? _context.GetArgument(7) : global::Lua.LuaValue.Nil;
                                        _lastArgPos = 7; _expectedType = typeof(global::UnityEngine.Rendering.ShadowCastingMode);
                                        var _p7_UnityEngine_Rendering_ShadowCastingMode = _arg7.ReadValue<global::UnityEngine.Rendering.ShadowCastingMode>(global::UnityEngine.Rendering.ShadowCastingMode.@On);
                                        {
                                            if (_argCount == 8)
                                            {
                                                var material = _p0_UnityEngine_Material.Instance;
                                                var bounds = _p1_UnityEngine_Bounds.Value;
                                                var topology = _p2_UnityEngine_MeshTopology;
                                                var bufferWithArgs = _p3_UnityEngine_GraphicsBuffer.Instance;
                                                var argsOffset = _p4_System_Int32;
                                                var camera = _p5_UnityEngine_Camera.Instance;
                                                var properties = _p6_UnityEngine_MaterialPropertyBlock.Instance;
                                                var castShadows = _p7_UnityEngine_Rendering_ShadowCastingMode;
                                                global::UnityEngine.Graphics.DrawProceduralIndirect(material, bounds, topology, bufferWithArgs, argsOffset, camera, properties, castShadows);
                                                var _retCount = _context.Return();
                                                return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                                            }
                                            var _arg8 = _lastArg = _argCount > 8 ? _context.GetArgument(8) : global::Lua.LuaValue.Nil;
                                            _lastArgPos = 8; _expectedType = typeof(global::System.Boolean);
                                            var _p8_System_Boolean = _arg8.ReadValue<global::System.Boolean>((global::System.Boolean)true);
                                            {
                                                if (_argCount == 9)
                                                {
                                                    var material = _p0_UnityEngine_Material.Instance;
                                                    var bounds = _p1_UnityEngine_Bounds.Value;
                                                    var topology = _p2_UnityEngine_MeshTopology;
                                                    var bufferWithArgs = _p3_UnityEngine_GraphicsBuffer.Instance;
                                                    var argsOffset = _p4_System_Int32;
                                                    var camera = _p5_UnityEngine_Camera.Instance;
                                                    var properties = _p6_UnityEngine_MaterialPropertyBlock.Instance;
                                                    var castShadows = _p7_UnityEngine_Rendering_ShadowCastingMode;
                                                    var receiveShadows = _p8_System_Boolean;
                                                    global::UnityEngine.Graphics.DrawProceduralIndirect(material, bounds, topology, bufferWithArgs, argsOffset, camera, properties, castShadows, receiveShadows);
                                                    var _retCount = _context.Return();
                                                    return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                                                }
                                                var _arg9 = _lastArg = _argCount > 9 ? _context.GetArgument(9) : global::Lua.LuaValue.Nil;
                                                _lastArgPos = 9; _expectedType = typeof(global::System.Int32);
                                                var _p9_System_Int32 = _arg9.ReadValue<global::System.Int32>((global::System.Int32)(0));
                                                {
                                                    if (_argCount == 10)
                                                    {
                                                        var material = _p0_UnityEngine_Material.Instance;
                                                        var bounds = _p1_UnityEngine_Bounds.Value;
                                                        var topology = _p2_UnityEngine_MeshTopology;
                                                        var bufferWithArgs = _p3_UnityEngine_GraphicsBuffer.Instance;
                                                        var argsOffset = _p4_System_Int32;
                                                        var camera = _p5_UnityEngine_Camera.Instance;
                                                        var properties = _p6_UnityEngine_MaterialPropertyBlock.Instance;
                                                        var castShadows = _p7_UnityEngine_Rendering_ShadowCastingMode;
                                                        var receiveShadows = _p8_System_Boolean;
                                                        var layer = _p9_System_Int32;
                                                        global::UnityEngine.Graphics.DrawProceduralIndirect(material, bounds, topology, bufferWithArgs, argsOffset, camera, properties, castShadows, receiveShadows, layer);
                                                        var _retCount = _context.Return();
                                                        return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                                                    }
                                                }
                                            }
                                        }
                                    }
                                }
                            }
                            _lastArgPos = 4; _expectedType = typeof(global::Luny.UnityEngine.LuaComputeBuffer);
                            if (_arg4.TryRead<global::Luny.UnityEngine.LuaComputeBuffer>(out var _p4_UnityEngine_ComputeBuffer))
                            {
                                if (_argCount == 5)
                                {
                                    var material = _p0_UnityEngine_Material.Instance;
                                    var bounds = _p1_UnityEngine_Bounds.Value;
                                    var topology = _p2_UnityEngine_MeshTopology;
                                    var indexBuffer = _p3_UnityEngine_GraphicsBuffer.Instance;
                                    var bufferWithArgs = _p4_UnityEngine_ComputeBuffer.Instance;
                                    global::UnityEngine.Graphics.DrawProceduralIndirect(material, bounds, topology, indexBuffer, bufferWithArgs);
                                    var _retCount = _context.Return();
                                    return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                                }
                                var _arg5 = _lastArg = _argCount > 5 ? _context.GetArgument(5) : global::Lua.LuaValue.Nil;
                                _lastArgPos = 5; _expectedType = typeof(global::System.Int32);
                                var _p5_System_Int32 = _arg5.ReadValue<global::System.Int32>((global::System.Int32)(0));
                                {
                                    if (_argCount == 6)
                                    {
                                        var material = _p0_UnityEngine_Material.Instance;
                                        var bounds = _p1_UnityEngine_Bounds.Value;
                                        var topology = _p2_UnityEngine_MeshTopology;
                                        var indexBuffer = _p3_UnityEngine_GraphicsBuffer.Instance;
                                        var bufferWithArgs = _p4_UnityEngine_ComputeBuffer.Instance;
                                        var argsOffset = _p5_System_Int32;
                                        global::UnityEngine.Graphics.DrawProceduralIndirect(material, bounds, topology, indexBuffer, bufferWithArgs, argsOffset);
                                        var _retCount = _context.Return();
                                        return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                                    }
                                    var _arg6 = _lastArg = _argCount > 6 ? _context.GetArgument(6) : global::Lua.LuaValue.Nil;
                                    _lastArgPos = 6; _expectedType = typeof(global::Luny.UnityEngine.LuaCamera);
                                    var _p6_UnityEngine_Camera = _arg6.ReadValue<global::Luny.UnityEngine.LuaCamera>(default);
                                    {
                                        if (_argCount == 7)
                                        {
                                            var material = _p0_UnityEngine_Material.Instance;
                                            var bounds = _p1_UnityEngine_Bounds.Value;
                                            var topology = _p2_UnityEngine_MeshTopology;
                                            var indexBuffer = _p3_UnityEngine_GraphicsBuffer.Instance;
                                            var bufferWithArgs = _p4_UnityEngine_ComputeBuffer.Instance;
                                            var argsOffset = _p5_System_Int32;
                                            var camera = _p6_UnityEngine_Camera.Instance;
                                            global::UnityEngine.Graphics.DrawProceduralIndirect(material, bounds, topology, indexBuffer, bufferWithArgs, argsOffset, camera);
                                            var _retCount = _context.Return();
                                            return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                                        }
                                        var _arg7 = _lastArg = _argCount > 7 ? _context.GetArgument(7) : global::Lua.LuaValue.Nil;
                                        _lastArgPos = 7; _expectedType = typeof(global::Luny.UnityEngine.LuaMaterialPropertyBlock);
                                        var _p7_UnityEngine_MaterialPropertyBlock = _arg7.ReadValue<global::Luny.UnityEngine.LuaMaterialPropertyBlock>(default);
                                        {
                                            if (_argCount == 8)
                                            {
                                                var material = _p0_UnityEngine_Material.Instance;
                                                var bounds = _p1_UnityEngine_Bounds.Value;
                                                var topology = _p2_UnityEngine_MeshTopology;
                                                var indexBuffer = _p3_UnityEngine_GraphicsBuffer.Instance;
                                                var bufferWithArgs = _p4_UnityEngine_ComputeBuffer.Instance;
                                                var argsOffset = _p5_System_Int32;
                                                var camera = _p6_UnityEngine_Camera.Instance;
                                                var properties = _p7_UnityEngine_MaterialPropertyBlock.Instance;
                                                global::UnityEngine.Graphics.DrawProceduralIndirect(material, bounds, topology, indexBuffer, bufferWithArgs, argsOffset, camera, properties);
                                                var _retCount = _context.Return();
                                                return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                                            }
                                            var _arg8 = _lastArg = _argCount > 8 ? _context.GetArgument(8) : global::Lua.LuaValue.Nil;
                                            _lastArgPos = 8; _expectedType = typeof(global::UnityEngine.Rendering.ShadowCastingMode);
                                            var _p8_UnityEngine_Rendering_ShadowCastingMode = _arg8.ReadValue<global::UnityEngine.Rendering.ShadowCastingMode>(global::UnityEngine.Rendering.ShadowCastingMode.@On);
                                            {
                                                if (_argCount == 9)
                                                {
                                                    var material = _p0_UnityEngine_Material.Instance;
                                                    var bounds = _p1_UnityEngine_Bounds.Value;
                                                    var topology = _p2_UnityEngine_MeshTopology;
                                                    var indexBuffer = _p3_UnityEngine_GraphicsBuffer.Instance;
                                                    var bufferWithArgs = _p4_UnityEngine_ComputeBuffer.Instance;
                                                    var argsOffset = _p5_System_Int32;
                                                    var camera = _p6_UnityEngine_Camera.Instance;
                                                    var properties = _p7_UnityEngine_MaterialPropertyBlock.Instance;
                                                    var castShadows = _p8_UnityEngine_Rendering_ShadowCastingMode;
                                                    global::UnityEngine.Graphics.DrawProceduralIndirect(material, bounds, topology, indexBuffer, bufferWithArgs, argsOffset, camera, properties, castShadows);
                                                    var _retCount = _context.Return();
                                                    return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                                                }
                                                var _arg9 = _lastArg = _argCount > 9 ? _context.GetArgument(9) : global::Lua.LuaValue.Nil;
                                                _lastArgPos = 9; _expectedType = typeof(global::System.Boolean);
                                                var _p9_System_Boolean = _arg9.ReadValue<global::System.Boolean>((global::System.Boolean)true);
                                                {
                                                    if (_argCount == 10)
                                                    {
                                                        var material = _p0_UnityEngine_Material.Instance;
                                                        var bounds = _p1_UnityEngine_Bounds.Value;
                                                        var topology = _p2_UnityEngine_MeshTopology;
                                                        var indexBuffer = _p3_UnityEngine_GraphicsBuffer.Instance;
                                                        var bufferWithArgs = _p4_UnityEngine_ComputeBuffer.Instance;
                                                        var argsOffset = _p5_System_Int32;
                                                        var camera = _p6_UnityEngine_Camera.Instance;
                                                        var properties = _p7_UnityEngine_MaterialPropertyBlock.Instance;
                                                        var castShadows = _p8_UnityEngine_Rendering_ShadowCastingMode;
                                                        var receiveShadows = _p9_System_Boolean;
                                                        global::UnityEngine.Graphics.DrawProceduralIndirect(material, bounds, topology, indexBuffer, bufferWithArgs, argsOffset, camera, properties, castShadows, receiveShadows);
                                                        var _retCount = _context.Return();
                                                        return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                                                    }
                                                    var _arg10 = _lastArg = _argCount > 10 ? _context.GetArgument(10) : global::Lua.LuaValue.Nil;
                                                    _lastArgPos = 10; _expectedType = typeof(global::System.Int32);
                                                    var _p10_System_Int32 = _arg10.ReadValue<global::System.Int32>((global::System.Int32)(0));
                                                    {
                                                        if (_argCount == 11)
                                                        {
                                                            var material = _p0_UnityEngine_Material.Instance;
                                                            var bounds = _p1_UnityEngine_Bounds.Value;
                                                            var topology = _p2_UnityEngine_MeshTopology;
                                                            var indexBuffer = _p3_UnityEngine_GraphicsBuffer.Instance;
                                                            var bufferWithArgs = _p4_UnityEngine_ComputeBuffer.Instance;
                                                            var argsOffset = _p5_System_Int32;
                                                            var camera = _p6_UnityEngine_Camera.Instance;
                                                            var properties = _p7_UnityEngine_MaterialPropertyBlock.Instance;
                                                            var castShadows = _p8_UnityEngine_Rendering_ShadowCastingMode;
                                                            var receiveShadows = _p9_System_Boolean;
                                                            var layer = _p10_System_Int32;
                                                            global::UnityEngine.Graphics.DrawProceduralIndirect(material, bounds, topology, indexBuffer, bufferWithArgs, argsOffset, camera, properties, castShadows, receiveShadows, layer);
                                                            var _retCount = _context.Return();
                                                            return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                                                        }
                                                    }
                                                }
                                            }
                                        }
                                    }
                                }
                            }
                            _lastArgPos = 4; _expectedType = typeof(global::Luny.UnityEngine.LuaGraphicsBuffer);
                            if (_arg4.TryRead<global::Luny.UnityEngine.LuaGraphicsBuffer>(out var _p4_UnityEngine_GraphicsBuffer))
                            {
                                if (_argCount == 5)
                                {
                                    var material = _p0_UnityEngine_Material.Instance;
                                    var bounds = _p1_UnityEngine_Bounds.Value;
                                    var topology = _p2_UnityEngine_MeshTopology;
                                    var indexBuffer = _p3_UnityEngine_GraphicsBuffer.Instance;
                                    var bufferWithArgs = _p4_UnityEngine_GraphicsBuffer.Instance;
                                    global::UnityEngine.Graphics.DrawProceduralIndirect(material, bounds, topology, indexBuffer, bufferWithArgs);
                                    var _retCount = _context.Return();
                                    return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                                }
                                var _arg5 = _lastArg = _argCount > 5 ? _context.GetArgument(5) : global::Lua.LuaValue.Nil;
                                _lastArgPos = 5; _expectedType = typeof(global::System.Int32);
                                var _p5_System_Int32 = _arg5.ReadValue<global::System.Int32>((global::System.Int32)(0));
                                {
                                    if (_argCount == 6)
                                    {
                                        var material = _p0_UnityEngine_Material.Instance;
                                        var bounds = _p1_UnityEngine_Bounds.Value;
                                        var topology = _p2_UnityEngine_MeshTopology;
                                        var indexBuffer = _p3_UnityEngine_GraphicsBuffer.Instance;
                                        var bufferWithArgs = _p4_UnityEngine_GraphicsBuffer.Instance;
                                        var argsOffset = _p5_System_Int32;
                                        global::UnityEngine.Graphics.DrawProceduralIndirect(material, bounds, topology, indexBuffer, bufferWithArgs, argsOffset);
                                        var _retCount = _context.Return();
                                        return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                                    }
                                    var _arg6 = _lastArg = _argCount > 6 ? _context.GetArgument(6) : global::Lua.LuaValue.Nil;
                                    _lastArgPos = 6; _expectedType = typeof(global::Luny.UnityEngine.LuaCamera);
                                    var _p6_UnityEngine_Camera = _arg6.ReadValue<global::Luny.UnityEngine.LuaCamera>(default);
                                    {
                                        if (_argCount == 7)
                                        {
                                            var material = _p0_UnityEngine_Material.Instance;
                                            var bounds = _p1_UnityEngine_Bounds.Value;
                                            var topology = _p2_UnityEngine_MeshTopology;
                                            var indexBuffer = _p3_UnityEngine_GraphicsBuffer.Instance;
                                            var bufferWithArgs = _p4_UnityEngine_GraphicsBuffer.Instance;
                                            var argsOffset = _p5_System_Int32;
                                            var camera = _p6_UnityEngine_Camera.Instance;
                                            global::UnityEngine.Graphics.DrawProceduralIndirect(material, bounds, topology, indexBuffer, bufferWithArgs, argsOffset, camera);
                                            var _retCount = _context.Return();
                                            return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                                        }
                                        var _arg7 = _lastArg = _argCount > 7 ? _context.GetArgument(7) : global::Lua.LuaValue.Nil;
                                        _lastArgPos = 7; _expectedType = typeof(global::Luny.UnityEngine.LuaMaterialPropertyBlock);
                                        var _p7_UnityEngine_MaterialPropertyBlock = _arg7.ReadValue<global::Luny.UnityEngine.LuaMaterialPropertyBlock>(default);
                                        {
                                            if (_argCount == 8)
                                            {
                                                var material = _p0_UnityEngine_Material.Instance;
                                                var bounds = _p1_UnityEngine_Bounds.Value;
                                                var topology = _p2_UnityEngine_MeshTopology;
                                                var indexBuffer = _p3_UnityEngine_GraphicsBuffer.Instance;
                                                var bufferWithArgs = _p4_UnityEngine_GraphicsBuffer.Instance;
                                                var argsOffset = _p5_System_Int32;
                                                var camera = _p6_UnityEngine_Camera.Instance;
                                                var properties = _p7_UnityEngine_MaterialPropertyBlock.Instance;
                                                global::UnityEngine.Graphics.DrawProceduralIndirect(material, bounds, topology, indexBuffer, bufferWithArgs, argsOffset, camera, properties);
                                                var _retCount = _context.Return();
                                                return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                                            }
                                            var _arg8 = _lastArg = _argCount > 8 ? _context.GetArgument(8) : global::Lua.LuaValue.Nil;
                                            _lastArgPos = 8; _expectedType = typeof(global::UnityEngine.Rendering.ShadowCastingMode);
                                            var _p8_UnityEngine_Rendering_ShadowCastingMode = _arg8.ReadValue<global::UnityEngine.Rendering.ShadowCastingMode>(global::UnityEngine.Rendering.ShadowCastingMode.@On);
                                            {
                                                if (_argCount == 9)
                                                {
                                                    var material = _p0_UnityEngine_Material.Instance;
                                                    var bounds = _p1_UnityEngine_Bounds.Value;
                                                    var topology = _p2_UnityEngine_MeshTopology;
                                                    var indexBuffer = _p3_UnityEngine_GraphicsBuffer.Instance;
                                                    var bufferWithArgs = _p4_UnityEngine_GraphicsBuffer.Instance;
                                                    var argsOffset = _p5_System_Int32;
                                                    var camera = _p6_UnityEngine_Camera.Instance;
                                                    var properties = _p7_UnityEngine_MaterialPropertyBlock.Instance;
                                                    var castShadows = _p8_UnityEngine_Rendering_ShadowCastingMode;
                                                    global::UnityEngine.Graphics.DrawProceduralIndirect(material, bounds, topology, indexBuffer, bufferWithArgs, argsOffset, camera, properties, castShadows);
                                                    var _retCount = _context.Return();
                                                    return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                                                }
                                                var _arg9 = _lastArg = _argCount > 9 ? _context.GetArgument(9) : global::Lua.LuaValue.Nil;
                                                _lastArgPos = 9; _expectedType = typeof(global::System.Boolean);
                                                var _p9_System_Boolean = _arg9.ReadValue<global::System.Boolean>((global::System.Boolean)true);
                                                {
                                                    if (_argCount == 10)
                                                    {
                                                        var material = _p0_UnityEngine_Material.Instance;
                                                        var bounds = _p1_UnityEngine_Bounds.Value;
                                                        var topology = _p2_UnityEngine_MeshTopology;
                                                        var indexBuffer = _p3_UnityEngine_GraphicsBuffer.Instance;
                                                        var bufferWithArgs = _p4_UnityEngine_GraphicsBuffer.Instance;
                                                        var argsOffset = _p5_System_Int32;
                                                        var camera = _p6_UnityEngine_Camera.Instance;
                                                        var properties = _p7_UnityEngine_MaterialPropertyBlock.Instance;
                                                        var castShadows = _p8_UnityEngine_Rendering_ShadowCastingMode;
                                                        var receiveShadows = _p9_System_Boolean;
                                                        global::UnityEngine.Graphics.DrawProceduralIndirect(material, bounds, topology, indexBuffer, bufferWithArgs, argsOffset, camera, properties, castShadows, receiveShadows);
                                                        var _retCount = _context.Return();
                                                        return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                                                    }
                                                    var _arg10 = _lastArg = _argCount > 10 ? _context.GetArgument(10) : global::Lua.LuaValue.Nil;
                                                    _lastArgPos = 10; _expectedType = typeof(global::System.Int32);
                                                    var _p10_System_Int32 = _arg10.ReadValue<global::System.Int32>((global::System.Int32)(0));
                                                    {
                                                        if (_argCount == 11)
                                                        {
                                                            var material = _p0_UnityEngine_Material.Instance;
                                                            var bounds = _p1_UnityEngine_Bounds.Value;
                                                            var topology = _p2_UnityEngine_MeshTopology;
                                                            var indexBuffer = _p3_UnityEngine_GraphicsBuffer.Instance;
                                                            var bufferWithArgs = _p4_UnityEngine_GraphicsBuffer.Instance;
                                                            var argsOffset = _p5_System_Int32;
                                                            var camera = _p6_UnityEngine_Camera.Instance;
                                                            var properties = _p7_UnityEngine_MaterialPropertyBlock.Instance;
                                                            var castShadows = _p8_UnityEngine_Rendering_ShadowCastingMode;
                                                            var receiveShadows = _p9_System_Boolean;
                                                            var layer = _p10_System_Int32;
                                                            global::UnityEngine.Graphics.DrawProceduralIndirect(material, bounds, topology, indexBuffer, bufferWithArgs, argsOffset, camera, properties, castShadows, receiveShadows, layer);
                                                            var _retCount = _context.Return();
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
                }
            }
            throw new global::Lua.LuaRuntimeException(_context.Thread, $"{"DrawProceduralIndirect"}: invalid argument #{_lastArgPos}: {_lastArg} ({_lastArg.Type}), expected: {_expectedType.FullName}", 2);
        });
        private static readonly global::Lua.LuaFunction _LuaGraphics_DrawProceduralIndirectNow = new global::Lua.LuaFunction("DrawProceduralIndirectNow", (_context, _) =>
        {
            global::Lua.LuaValue _lastArg = default;
            global::System.Int32 _lastArgPos = default;
            global::System.Type _expectedType = default;
            var _argCount = _context.ArgumentCount;
            var _arg0 = _lastArg = _argCount > 0 ? _context.GetArgument(0) : global::Lua.LuaValue.Nil;
            _lastArgPos = 0; _expectedType = typeof(global::UnityEngine.MeshTopology);
            if (_arg0.TryRead<global::UnityEngine.MeshTopology>(out var _p0_UnityEngine_MeshTopology))
            {
                var _arg1 = _lastArg = _argCount > 1 ? _context.GetArgument(1) : global::Lua.LuaValue.Nil;
                _lastArgPos = 1; _expectedType = typeof(global::Luny.UnityEngine.LuaComputeBuffer);
                if (_arg1.TryRead<global::Luny.UnityEngine.LuaComputeBuffer>(out var _p1_UnityEngine_ComputeBuffer))
                {
                    if (_argCount == 2)
                    {
                        var topology = _p0_UnityEngine_MeshTopology;
                        var bufferWithArgs = _p1_UnityEngine_ComputeBuffer.Instance;
                        global::UnityEngine.Graphics.DrawProceduralIndirectNow(topology, bufferWithArgs);
                        var _retCount = _context.Return();
                        return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                    }
                    var _arg2 = _lastArg = _argCount > 2 ? _context.GetArgument(2) : global::Lua.LuaValue.Nil;
                    _lastArgPos = 2; _expectedType = typeof(global::System.Int32);
                    var _p2_System_Int32 = _arg2.ReadValue<global::System.Int32>((global::System.Int32)(0));
                    {
                        if (_argCount == 3)
                        {
                            var topology = _p0_UnityEngine_MeshTopology;
                            var bufferWithArgs = _p1_UnityEngine_ComputeBuffer.Instance;
                            var argsOffset = _p2_System_Int32;
                            global::UnityEngine.Graphics.DrawProceduralIndirectNow(topology, bufferWithArgs, argsOffset);
                            var _retCount = _context.Return();
                            return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                        }
                    }
                }
                _lastArgPos = 1; _expectedType = typeof(global::Luny.UnityEngine.LuaGraphicsBuffer);
                if (_arg1.TryRead<global::Luny.UnityEngine.LuaGraphicsBuffer>(out var _p1_UnityEngine_GraphicsBuffer))
                {
                    if (_argCount == 2)
                    {
                        var topology = _p0_UnityEngine_MeshTopology;
                        var bufferWithArgs = _p1_UnityEngine_GraphicsBuffer.Instance;
                        global::UnityEngine.Graphics.DrawProceduralIndirectNow(topology, bufferWithArgs);
                        var _retCount = _context.Return();
                        return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                    }
                    var _arg2 = _lastArg = _argCount > 2 ? _context.GetArgument(2) : global::Lua.LuaValue.Nil;
                    _lastArgPos = 2; _expectedType = typeof(global::System.Int32);
                    var _p2_System_Int32 = _arg2.ReadValue<global::System.Int32>((global::System.Int32)(0));
                    {
                        if (_argCount == 3)
                        {
                            var topology = _p0_UnityEngine_MeshTopology;
                            var bufferWithArgs = _p1_UnityEngine_GraphicsBuffer.Instance;
                            var argsOffset = _p2_System_Int32;
                            global::UnityEngine.Graphics.DrawProceduralIndirectNow(topology, bufferWithArgs, argsOffset);
                            var _retCount = _context.Return();
                            return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                        }
                    }
                    _lastArgPos = 2; _expectedType = typeof(global::Luny.UnityEngine.LuaComputeBuffer);
                    if (_arg2.TryRead<global::Luny.UnityEngine.LuaComputeBuffer>(out var _p2_UnityEngine_ComputeBuffer))
                    {
                        if (_argCount == 3)
                        {
                            var topology = _p0_UnityEngine_MeshTopology;
                            var indexBuffer = _p1_UnityEngine_GraphicsBuffer.Instance;
                            var bufferWithArgs = _p2_UnityEngine_ComputeBuffer.Instance;
                            global::UnityEngine.Graphics.DrawProceduralIndirectNow(topology, indexBuffer, bufferWithArgs);
                            var _retCount = _context.Return();
                            return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                        }
                        var _arg3 = _lastArg = _argCount > 3 ? _context.GetArgument(3) : global::Lua.LuaValue.Nil;
                        _lastArgPos = 3; _expectedType = typeof(global::System.Int32);
                        var _p3_System_Int32 = _arg3.ReadValue<global::System.Int32>((global::System.Int32)(0));
                        {
                            if (_argCount == 4)
                            {
                                var topology = _p0_UnityEngine_MeshTopology;
                                var indexBuffer = _p1_UnityEngine_GraphicsBuffer.Instance;
                                var bufferWithArgs = _p2_UnityEngine_ComputeBuffer.Instance;
                                var argsOffset = _p3_System_Int32;
                                global::UnityEngine.Graphics.DrawProceduralIndirectNow(topology, indexBuffer, bufferWithArgs, argsOffset);
                                var _retCount = _context.Return();
                                return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                            }
                        }
                    }
                    _lastArgPos = 2; _expectedType = typeof(global::Luny.UnityEngine.LuaGraphicsBuffer);
                    if (_arg2.TryRead<global::Luny.UnityEngine.LuaGraphicsBuffer>(out var _p2_UnityEngine_GraphicsBuffer))
                    {
                        if (_argCount == 3)
                        {
                            var topology = _p0_UnityEngine_MeshTopology;
                            var indexBuffer = _p1_UnityEngine_GraphicsBuffer.Instance;
                            var bufferWithArgs = _p2_UnityEngine_GraphicsBuffer.Instance;
                            global::UnityEngine.Graphics.DrawProceduralIndirectNow(topology, indexBuffer, bufferWithArgs);
                            var _retCount = _context.Return();
                            return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                        }
                        var _arg3 = _lastArg = _argCount > 3 ? _context.GetArgument(3) : global::Lua.LuaValue.Nil;
                        _lastArgPos = 3; _expectedType = typeof(global::System.Int32);
                        var _p3_System_Int32 = _arg3.ReadValue<global::System.Int32>((global::System.Int32)(0));
                        {
                            if (_argCount == 4)
                            {
                                var topology = _p0_UnityEngine_MeshTopology;
                                var indexBuffer = _p1_UnityEngine_GraphicsBuffer.Instance;
                                var bufferWithArgs = _p2_UnityEngine_GraphicsBuffer.Instance;
                                var argsOffset = _p3_System_Int32;
                                global::UnityEngine.Graphics.DrawProceduralIndirectNow(topology, indexBuffer, bufferWithArgs, argsOffset);
                                var _retCount = _context.Return();
                                return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                            }
                        }
                    }
                }
            }
            throw new global::Lua.LuaRuntimeException(_context.Thread, $"{"DrawProceduralIndirectNow"}: invalid argument #{_lastArgPos}: {_lastArg} ({_lastArg.Type}), expected: {_expectedType.FullName}", 2);
        });
        private static readonly global::Lua.LuaFunction _LuaGraphics_DrawProceduralNow = new global::Lua.LuaFunction("DrawProceduralNow", (_context, _) =>
        {
            global::Lua.LuaValue _lastArg = default;
            global::System.Int32 _lastArgPos = default;
            global::System.Type _expectedType = default;
            var _argCount = _context.ArgumentCount;
            var _arg0 = _lastArg = _argCount > 0 ? _context.GetArgument(0) : global::Lua.LuaValue.Nil;
            _lastArgPos = 0; _expectedType = typeof(global::UnityEngine.MeshTopology);
            if (_arg0.TryRead<global::UnityEngine.MeshTopology>(out var _p0_UnityEngine_MeshTopology))
            {
                var _arg1 = _lastArg = _argCount > 1 ? _context.GetArgument(1) : global::Lua.LuaValue.Nil;
                _lastArgPos = 1; _expectedType = typeof(global::System.Int32);
                if (_arg1.TryRead<global::System.Int32>(out var _p1_System_Int32))
                {
                    if (_argCount == 2)
                    {
                        var topology = _p0_UnityEngine_MeshTopology;
                        var vertexCount = _p1_System_Int32;
                        global::UnityEngine.Graphics.DrawProceduralNow(topology, vertexCount);
                        var _retCount = _context.Return();
                        return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                    }
                    var _arg2 = _lastArg = _argCount > 2 ? _context.GetArgument(2) : global::Lua.LuaValue.Nil;
                    _lastArgPos = 2; _expectedType = typeof(global::System.Int32);
                    var _p2_System_Int32 = _arg2.ReadValue<global::System.Int32>((global::System.Int32)(1));
                    {
                        if (_argCount == 3)
                        {
                            var topology = _p0_UnityEngine_MeshTopology;
                            var vertexCount = _p1_System_Int32;
                            var instanceCount = _p2_System_Int32;
                            global::UnityEngine.Graphics.DrawProceduralNow(topology, vertexCount, instanceCount);
                            var _retCount = _context.Return();
                            return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                        }
                    }
                }
                _lastArgPos = 1; _expectedType = typeof(global::Luny.UnityEngine.LuaGraphicsBuffer);
                if (_arg1.TryRead<global::Luny.UnityEngine.LuaGraphicsBuffer>(out var _p1_UnityEngine_GraphicsBuffer))
                {
                    var _arg2 = _lastArg = _argCount > 2 ? _context.GetArgument(2) : global::Lua.LuaValue.Nil;
                    _lastArgPos = 2; _expectedType = typeof(global::System.Int32);
                    if (_arg2.TryRead<global::System.Int32>(out var _p2_System_Int32))
                    {
                        if (_argCount == 3)
                        {
                            var topology = _p0_UnityEngine_MeshTopology;
                            var indexBuffer = _p1_UnityEngine_GraphicsBuffer.Instance;
                            var indexCount = _p2_System_Int32;
                            global::UnityEngine.Graphics.DrawProceduralNow(topology, indexBuffer, indexCount);
                            var _retCount = _context.Return();
                            return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                        }
                        var _arg3 = _lastArg = _argCount > 3 ? _context.GetArgument(3) : global::Lua.LuaValue.Nil;
                        _lastArgPos = 3; _expectedType = typeof(global::System.Int32);
                        var _p3_System_Int32 = _arg3.ReadValue<global::System.Int32>((global::System.Int32)(1));
                        {
                            if (_argCount == 4)
                            {
                                var topology = _p0_UnityEngine_MeshTopology;
                                var indexBuffer = _p1_UnityEngine_GraphicsBuffer.Instance;
                                var indexCount = _p2_System_Int32;
                                var instanceCount = _p3_System_Int32;
                                global::UnityEngine.Graphics.DrawProceduralNow(topology, indexBuffer, indexCount, instanceCount);
                                var _retCount = _context.Return();
                                return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                            }
                        }
                    }
                }
            }
            throw new global::Lua.LuaRuntimeException(_context.Thread, $"{"DrawProceduralNow"}: invalid argument #{_lastArgPos}: {_lastArg} ({_lastArg.Type}), expected: {_expectedType.FullName}", 2);
        });
        private static readonly global::Lua.LuaFunction _LuaGraphics_DrawTexture = new global::Lua.LuaFunction("DrawTexture", (_context, _) =>
        {
            global::Lua.LuaValue _lastArg = default;
            global::System.Int32 _lastArgPos = default;
            global::System.Type _expectedType = default;
            var _argCount = _context.ArgumentCount;
            var _arg0 = _lastArg = _argCount > 0 ? _context.GetArgument(0) : global::Lua.LuaValue.Nil;
            _lastArgPos = 0; _expectedType = typeof(global::Luny.UnityEngine.LuaRect);
            if (_arg0.TryRead<global::Luny.UnityEngine.LuaRect>(out var _p0_UnityEngine_Rect))
            {
                var _arg1 = _lastArg = _argCount > 1 ? _context.GetArgument(1) : global::Lua.LuaValue.Nil;
                _lastArgPos = 1; _expectedType = typeof(global::Luny.UnityEngine.LuaTexture);
                if (_arg1.TryRead<global::Luny.UnityEngine.LuaTexture>(out var _p1_UnityEngine_Texture))
                {
                    if (_argCount == 2)
                    {
                        var screenRect = _p0_UnityEngine_Rect.Value;
                        var texture = _p1_UnityEngine_Texture.Instance;
                        global::UnityEngine.Graphics.DrawTexture(screenRect, texture);
                        var _retCount = _context.Return();
                        return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                    }
                    var _arg2 = _lastArg = _argCount > 2 ? _context.GetArgument(2) : global::Lua.LuaValue.Nil;
                    _lastArgPos = 2; _expectedType = typeof(global::Luny.UnityEngine.LuaMaterial);
                    if (_arg2.TryRead<global::Luny.UnityEngine.LuaMaterial>(out var _p2_UnityEngine_Material))
                    {
                        if (_argCount == 3)
                        {
                            var screenRect = _p0_UnityEngine_Rect.Value;
                            var texture = _p1_UnityEngine_Texture.Instance;
                            var mat = _p2_UnityEngine_Material.Instance;
                            global::UnityEngine.Graphics.DrawTexture(screenRect, texture, mat);
                            var _retCount = _context.Return();
                            return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                        }
                        var _arg3 = _lastArg = _argCount > 3 ? _context.GetArgument(3) : global::Lua.LuaValue.Nil;
                        _lastArgPos = 3; _expectedType = typeof(global::System.Int32);
                        if (_arg3.TryRead<global::System.Int32>(out var _p3_System_Int32))
                        {
                            if (_argCount == 4)
                            {
                                var screenRect = _p0_UnityEngine_Rect.Value;
                                var texture = _p1_UnityEngine_Texture.Instance;
                                var mat = _p2_UnityEngine_Material.Instance;
                                var pass = _p3_System_Int32;
                                global::UnityEngine.Graphics.DrawTexture(screenRect, texture, mat, pass);
                                var _retCount = _context.Return();
                                return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                            }
                        }
                    }
                    _lastArgPos = 2; _expectedType = typeof(global::System.Int32);
                    if (_arg2.TryRead<global::System.Int32>(out var _p2_System_Int32))
                    {
                        var _arg3 = _lastArg = _argCount > 3 ? _context.GetArgument(3) : global::Lua.LuaValue.Nil;
                        _lastArgPos = 3; _expectedType = typeof(global::System.Int32);
                        if (_arg3.TryRead<global::System.Int32>(out var _p3_System_Int32))
                        {
                            var _arg4 = _lastArg = _argCount > 4 ? _context.GetArgument(4) : global::Lua.LuaValue.Nil;
                            _lastArgPos = 4; _expectedType = typeof(global::System.Int32);
                            if (_arg4.TryRead<global::System.Int32>(out var _p4_System_Int32))
                            {
                                var _arg5 = _lastArg = _argCount > 5 ? _context.GetArgument(5) : global::Lua.LuaValue.Nil;
                                _lastArgPos = 5; _expectedType = typeof(global::System.Int32);
                                if (_arg5.TryRead<global::System.Int32>(out var _p5_System_Int32))
                                {
                                    if (_argCount == 6)
                                    {
                                        var screenRect = _p0_UnityEngine_Rect.Value;
                                        var texture = _p1_UnityEngine_Texture.Instance;
                                        var leftBorder = _p2_System_Int32;
                                        var rightBorder = _p3_System_Int32;
                                        var topBorder = _p4_System_Int32;
                                        var bottomBorder = _p5_System_Int32;
                                        global::UnityEngine.Graphics.DrawTexture(screenRect, texture, leftBorder, rightBorder, topBorder, bottomBorder);
                                        var _retCount = _context.Return();
                                        return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                                    }
                                    var _arg6 = _lastArg = _argCount > 6 ? _context.GetArgument(6) : global::Lua.LuaValue.Nil;
                                    _lastArgPos = 6; _expectedType = typeof(global::Luny.UnityEngine.LuaMaterial);
                                    if (_arg6.TryRead<global::Luny.UnityEngine.LuaMaterial>(out var _p6_UnityEngine_Material))
                                    {
                                        if (_argCount == 7)
                                        {
                                            var screenRect = _p0_UnityEngine_Rect.Value;
                                            var texture = _p1_UnityEngine_Texture.Instance;
                                            var leftBorder = _p2_System_Int32;
                                            var rightBorder = _p3_System_Int32;
                                            var topBorder = _p4_System_Int32;
                                            var bottomBorder = _p5_System_Int32;
                                            var mat = _p6_UnityEngine_Material.Instance;
                                            global::UnityEngine.Graphics.DrawTexture(screenRect, texture, leftBorder, rightBorder, topBorder, bottomBorder, mat);
                                            var _retCount = _context.Return();
                                            return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                                        }
                                        var _arg7 = _lastArg = _argCount > 7 ? _context.GetArgument(7) : global::Lua.LuaValue.Nil;
                                        _lastArgPos = 7; _expectedType = typeof(global::System.Int32);
                                        if (_arg7.TryRead<global::System.Int32>(out var _p7_System_Int32))
                                        {
                                            if (_argCount == 8)
                                            {
                                                var screenRect = _p0_UnityEngine_Rect.Value;
                                                var texture = _p1_UnityEngine_Texture.Instance;
                                                var leftBorder = _p2_System_Int32;
                                                var rightBorder = _p3_System_Int32;
                                                var topBorder = _p4_System_Int32;
                                                var bottomBorder = _p5_System_Int32;
                                                var mat = _p6_UnityEngine_Material.Instance;
                                                var pass = _p7_System_Int32;
                                                global::UnityEngine.Graphics.DrawTexture(screenRect, texture, leftBorder, rightBorder, topBorder, bottomBorder, mat, pass);
                                                var _retCount = _context.Return();
                                                return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }
                    _lastArgPos = 2; _expectedType = typeof(global::Luny.UnityEngine.LuaRect);
                    if (_arg2.TryRead<global::Luny.UnityEngine.LuaRect>(out var _p2_UnityEngine_Rect))
                    {
                        var _arg3 = _lastArg = _argCount > 3 ? _context.GetArgument(3) : global::Lua.LuaValue.Nil;
                        _lastArgPos = 3; _expectedType = typeof(global::System.Int32);
                        if (_arg3.TryRead<global::System.Int32>(out var _p3_System_Int32))
                        {
                            var _arg4 = _lastArg = _argCount > 4 ? _context.GetArgument(4) : global::Lua.LuaValue.Nil;
                            _lastArgPos = 4; _expectedType = typeof(global::System.Int32);
                            if (_arg4.TryRead<global::System.Int32>(out var _p4_System_Int32))
                            {
                                var _arg5 = _lastArg = _argCount > 5 ? _context.GetArgument(5) : global::Lua.LuaValue.Nil;
                                _lastArgPos = 5; _expectedType = typeof(global::System.Int32);
                                if (_arg5.TryRead<global::System.Int32>(out var _p5_System_Int32))
                                {
                                    var _arg6 = _lastArg = _argCount > 6 ? _context.GetArgument(6) : global::Lua.LuaValue.Nil;
                                    _lastArgPos = 6; _expectedType = typeof(global::System.Int32);
                                    if (_arg6.TryRead<global::System.Int32>(out var _p6_System_Int32))
                                    {
                                        if (_argCount == 7)
                                        {
                                            var screenRect = _p0_UnityEngine_Rect.Value;
                                            var texture = _p1_UnityEngine_Texture.Instance;
                                            var sourceRect = _p2_UnityEngine_Rect.Value;
                                            var leftBorder = _p3_System_Int32;
                                            var rightBorder = _p4_System_Int32;
                                            var topBorder = _p5_System_Int32;
                                            var bottomBorder = _p6_System_Int32;
                                            global::UnityEngine.Graphics.DrawTexture(screenRect, texture, sourceRect, leftBorder, rightBorder, topBorder, bottomBorder);
                                            var _retCount = _context.Return();
                                            return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                                        }
                                        var _arg7 = _lastArg = _argCount > 7 ? _context.GetArgument(7) : global::Lua.LuaValue.Nil;
                                        _lastArgPos = 7; _expectedType = typeof(global::Luny.UnityEngine.LuaColor);
                                        if (_arg7.TryRead<global::Luny.UnityEngine.LuaColor>(out var _p7_UnityEngine_Color))
                                        {
                                            if (_argCount == 8)
                                            {
                                                var screenRect = _p0_UnityEngine_Rect.Value;
                                                var texture = _p1_UnityEngine_Texture.Instance;
                                                var sourceRect = _p2_UnityEngine_Rect.Value;
                                                var leftBorder = _p3_System_Int32;
                                                var rightBorder = _p4_System_Int32;
                                                var topBorder = _p5_System_Int32;
                                                var bottomBorder = _p6_System_Int32;
                                                var color = _p7_UnityEngine_Color.Value;
                                                global::UnityEngine.Graphics.DrawTexture(screenRect, texture, sourceRect, leftBorder, rightBorder, topBorder, bottomBorder, color);
                                                var _retCount = _context.Return();
                                                return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                                            }
                                            var _arg8 = _lastArg = _argCount > 8 ? _context.GetArgument(8) : global::Lua.LuaValue.Nil;
                                            _lastArgPos = 8; _expectedType = typeof(global::Luny.UnityEngine.LuaMaterial);
                                            if (_arg8.TryRead<global::Luny.UnityEngine.LuaMaterial>(out var _p8_UnityEngine_Material))
                                            {
                                                if (_argCount == 9)
                                                {
                                                    var screenRect = _p0_UnityEngine_Rect.Value;
                                                    var texture = _p1_UnityEngine_Texture.Instance;
                                                    var sourceRect = _p2_UnityEngine_Rect.Value;
                                                    var leftBorder = _p3_System_Int32;
                                                    var rightBorder = _p4_System_Int32;
                                                    var topBorder = _p5_System_Int32;
                                                    var bottomBorder = _p6_System_Int32;
                                                    var color = _p7_UnityEngine_Color.Value;
                                                    var mat = _p8_UnityEngine_Material.Instance;
                                                    global::UnityEngine.Graphics.DrawTexture(screenRect, texture, sourceRect, leftBorder, rightBorder, topBorder, bottomBorder, color, mat);
                                                    var _retCount = _context.Return();
                                                    return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                                                }
                                                var _arg9 = _lastArg = _argCount > 9 ? _context.GetArgument(9) : global::Lua.LuaValue.Nil;
                                                _lastArgPos = 9; _expectedType = typeof(global::System.Int32);
                                                if (_arg9.TryRead<global::System.Int32>(out var _p9_System_Int32))
                                                {
                                                    if (_argCount == 10)
                                                    {
                                                        var screenRect = _p0_UnityEngine_Rect.Value;
                                                        var texture = _p1_UnityEngine_Texture.Instance;
                                                        var sourceRect = _p2_UnityEngine_Rect.Value;
                                                        var leftBorder = _p3_System_Int32;
                                                        var rightBorder = _p4_System_Int32;
                                                        var topBorder = _p5_System_Int32;
                                                        var bottomBorder = _p6_System_Int32;
                                                        var color = _p7_UnityEngine_Color.Value;
                                                        var mat = _p8_UnityEngine_Material.Instance;
                                                        var pass = _p9_System_Int32;
                                                        global::UnityEngine.Graphics.DrawTexture(screenRect, texture, sourceRect, leftBorder, rightBorder, topBorder, bottomBorder, color, mat, pass);
                                                        var _retCount = _context.Return();
                                                        return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                                                    }
                                                }
                                            }
                                        }
                                        _lastArgPos = 7; _expectedType = typeof(global::Luny.UnityEngine.LuaMaterial);
                                        if (_arg7.TryRead<global::Luny.UnityEngine.LuaMaterial>(out var _p7_UnityEngine_Material))
                                        {
                                            if (_argCount == 8)
                                            {
                                                var screenRect = _p0_UnityEngine_Rect.Value;
                                                var texture = _p1_UnityEngine_Texture.Instance;
                                                var sourceRect = _p2_UnityEngine_Rect.Value;
                                                var leftBorder = _p3_System_Int32;
                                                var rightBorder = _p4_System_Int32;
                                                var topBorder = _p5_System_Int32;
                                                var bottomBorder = _p6_System_Int32;
                                                var mat = _p7_UnityEngine_Material.Instance;
                                                global::UnityEngine.Graphics.DrawTexture(screenRect, texture, sourceRect, leftBorder, rightBorder, topBorder, bottomBorder, mat);
                                                var _retCount = _context.Return();
                                                return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                                            }
                                            var _arg8 = _lastArg = _argCount > 8 ? _context.GetArgument(8) : global::Lua.LuaValue.Nil;
                                            _lastArgPos = 8; _expectedType = typeof(global::System.Int32);
                                            if (_arg8.TryRead<global::System.Int32>(out var _p8_System_Int32))
                                            {
                                                if (_argCount == 9)
                                                {
                                                    var screenRect = _p0_UnityEngine_Rect.Value;
                                                    var texture = _p1_UnityEngine_Texture.Instance;
                                                    var sourceRect = _p2_UnityEngine_Rect.Value;
                                                    var leftBorder = _p3_System_Int32;
                                                    var rightBorder = _p4_System_Int32;
                                                    var topBorder = _p5_System_Int32;
                                                    var bottomBorder = _p6_System_Int32;
                                                    var mat = _p7_UnityEngine_Material.Instance;
                                                    var pass = _p8_System_Int32;
                                                    global::UnityEngine.Graphics.DrawTexture(screenRect, texture, sourceRect, leftBorder, rightBorder, topBorder, bottomBorder, mat, pass);
                                                    var _retCount = _context.Return();
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
            throw new global::Lua.LuaRuntimeException(_context.Thread, $"{"DrawTexture"}: invalid argument #{_lastArgPos}: {_lastArg} ({_lastArg.Type}), expected: {_expectedType.FullName}", 2);
        });
        private static readonly global::Lua.LuaFunction _LuaGraphics_ExecuteCommandBuffer = new global::Lua.LuaFunction("ExecuteCommandBuffer", (_context, _) =>
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
                    var buffer = _p0_UnityEngine_Rendering_CommandBuffer.Instance;
                    global::UnityEngine.Graphics.ExecuteCommandBuffer(buffer);
                    var _retCount = _context.Return();
                    return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                }
            }
            throw new global::Lua.LuaRuntimeException(_context.Thread, $"{"ExecuteCommandBuffer"}: invalid argument #{_lastArgPos}: {_lastArg} ({_lastArg.Type}), expected: {_expectedType.FullName}", 2);
        });
        private static readonly global::Lua.LuaFunction _LuaGraphics_ExecuteCommandBufferAsync = new global::Lua.LuaFunction("ExecuteCommandBufferAsync", (_context, _) =>
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
                _lastArgPos = 1; _expectedType = typeof(global::UnityEngine.Rendering.ComputeQueueType);
                if (_arg1.TryRead<global::UnityEngine.Rendering.ComputeQueueType>(out var _p1_UnityEngine_Rendering_ComputeQueueType))
                {
                    if (_argCount == 2)
                    {
                        var buffer = _p0_UnityEngine_Rendering_CommandBuffer.Instance;
                        var queueType = _p1_UnityEngine_Rendering_ComputeQueueType;
                        global::UnityEngine.Graphics.ExecuteCommandBufferAsync(buffer, queueType);
                        var _retCount = _context.Return();
                        return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                    }
                }
            }
            throw new global::Lua.LuaRuntimeException(_context.Thread, $"{"ExecuteCommandBufferAsync"}: invalid argument #{_lastArgPos}: {_lastArg} ({_lastArg.Type}), expected: {_expectedType.FullName}", 2);
        });
        private static readonly global::Lua.LuaFunction _LuaGraphics_SetRandomWriteTarget = new global::Lua.LuaFunction("SetRandomWriteTarget", (_context, _) =>
        {
            global::Lua.LuaValue _lastArg = default;
            global::System.Int32 _lastArgPos = default;
            global::System.Type _expectedType = default;
            var _argCount = _context.ArgumentCount;
            var _arg0 = _lastArg = _argCount > 0 ? _context.GetArgument(0) : global::Lua.LuaValue.Nil;
            _lastArgPos = 0; _expectedType = typeof(global::System.Int32);
            if (_arg0.TryRead<global::System.Int32>(out var _p0_System_Int32))
            {
                var _arg1 = _lastArg = _argCount > 1 ? _context.GetArgument(1) : global::Lua.LuaValue.Nil;
                _lastArgPos = 1; _expectedType = typeof(global::Luny.UnityEngine.LuaRenderTexture);
                if (_arg1.TryRead<global::Luny.UnityEngine.LuaRenderTexture>(out var _p1_UnityEngine_RenderTexture))
                {
                    if (_argCount == 2)
                    {
                        var index = _p0_System_Int32;
                        var uav = _p1_UnityEngine_RenderTexture.Instance;
                        global::UnityEngine.Graphics.SetRandomWriteTarget(index, uav);
                        var _retCount = _context.Return();
                        return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                    }
                }
                _lastArgPos = 1; _expectedType = typeof(global::Luny.UnityEngine.LuaComputeBuffer);
                if (_arg1.TryRead<global::Luny.UnityEngine.LuaComputeBuffer>(out var _p1_UnityEngine_ComputeBuffer))
                {
                    if (_argCount == 2)
                    {
                        var index = _p0_System_Int32;
                        var uav = _p1_UnityEngine_ComputeBuffer.Instance;
                        global::UnityEngine.Graphics.SetRandomWriteTarget(index, uav);
                        var _retCount = _context.Return();
                        return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                    }
                    var _arg2 = _lastArg = _argCount > 2 ? _context.GetArgument(2) : global::Lua.LuaValue.Nil;
                    _lastArgPos = 2; _expectedType = typeof(global::System.Boolean);
                    if (_arg2.TryRead<global::System.Boolean>(out var _p2_System_Boolean))
                    {
                        if (_argCount == 3)
                        {
                            var index = _p0_System_Int32;
                            var uav = _p1_UnityEngine_ComputeBuffer.Instance;
                            var preserveCounterValue = _p2_System_Boolean;
                            global::UnityEngine.Graphics.SetRandomWriteTarget(index, uav, preserveCounterValue);
                            var _retCount = _context.Return();
                            return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                        }
                    }
                }
                _lastArgPos = 1; _expectedType = typeof(global::Luny.UnityEngine.LuaGraphicsBuffer);
                if (_arg1.TryRead<global::Luny.UnityEngine.LuaGraphicsBuffer>(out var _p1_UnityEngine_GraphicsBuffer))
                {
                    if (_argCount == 2)
                    {
                        var index = _p0_System_Int32;
                        var uav = _p1_UnityEngine_GraphicsBuffer.Instance;
                        global::UnityEngine.Graphics.SetRandomWriteTarget(index, uav);
                        var _retCount = _context.Return();
                        return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                    }
                    var _arg2 = _lastArg = _argCount > 2 ? _context.GetArgument(2) : global::Lua.LuaValue.Nil;
                    _lastArgPos = 2; _expectedType = typeof(global::System.Boolean);
                    if (_arg2.TryRead<global::System.Boolean>(out var _p2_System_Boolean))
                    {
                        if (_argCount == 3)
                        {
                            var index = _p0_System_Int32;
                            var uav = _p1_UnityEngine_GraphicsBuffer.Instance;
                            var preserveCounterValue = _p2_System_Boolean;
                            global::UnityEngine.Graphics.SetRandomWriteTarget(index, uav, preserveCounterValue);
                            var _retCount = _context.Return();
                            return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                        }
                    }
                }
            }
            throw new global::Lua.LuaRuntimeException(_context.Thread, $"{"SetRandomWriteTarget"}: invalid argument #{_lastArgPos}: {_lastArg} ({_lastArg.Type}), expected: {_expectedType.FullName}", 2);
        });
        private static readonly global::Lua.LuaFunction _LuaGraphics_SetRenderTarget = new global::Lua.LuaFunction("SetRenderTarget", (_context, _) =>
        {
            global::Lua.LuaValue _lastArg = default;
            global::System.Int32 _lastArgPos = default;
            global::System.Type _expectedType = default;
            var _argCount = _context.ArgumentCount;
            var _arg0 = _lastArg = _argCount > 0 ? _context.GetArgument(0) : global::Lua.LuaValue.Nil;
            _lastArgPos = 0; _expectedType = typeof(global::Luny.UnityEngine.LuaRenderTargetSetup);
            if (_arg0.TryRead<global::Luny.UnityEngine.LuaRenderTargetSetup>(out var _p0_UnityEngine_RenderTargetSetup))
            {
                if (_argCount == 1)
                {
                    var setup = _p0_UnityEngine_RenderTargetSetup.Value;
                    global::UnityEngine.Graphics.SetRenderTarget(setup);
                    var _retCount = _context.Return();
                    return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                }
            }
            _lastArgPos = 0; _expectedType = typeof(global::Luny.UnityEngine.LuaRenderTexture);
            if (_arg0.TryRead<global::Luny.UnityEngine.LuaRenderTexture>(out var _p0_UnityEngine_RenderTexture))
            {
                if (_argCount == 1)
                {
                    var rt = _p0_UnityEngine_RenderTexture.Instance;
                    global::UnityEngine.Graphics.SetRenderTarget(rt);
                    var _retCount = _context.Return();
                    return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                }
                var _arg1 = _lastArg = _argCount > 1 ? _context.GetArgument(1) : global::Lua.LuaValue.Nil;
                _lastArgPos = 1; _expectedType = typeof(global::System.Int32);
                if (_arg1.TryRead<global::System.Int32>(out var _p1_System_Int32))
                {
                    if (_argCount == 2)
                    {
                        var rt = _p0_UnityEngine_RenderTexture.Instance;
                        var mipLevel = _p1_System_Int32;
                        global::UnityEngine.Graphics.SetRenderTarget(rt, mipLevel);
                        var _retCount = _context.Return();
                        return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                    }
                    var _arg2 = _lastArg = _argCount > 2 ? _context.GetArgument(2) : global::Lua.LuaValue.Nil;
                    _lastArgPos = 2; _expectedType = typeof(global::UnityEngine.CubemapFace);
                    if (_arg2.TryRead<global::UnityEngine.CubemapFace>(out var _p2_UnityEngine_CubemapFace))
                    {
                        if (_argCount == 3)
                        {
                            var rt = _p0_UnityEngine_RenderTexture.Instance;
                            var mipLevel = _p1_System_Int32;
                            var face = _p2_UnityEngine_CubemapFace;
                            global::UnityEngine.Graphics.SetRenderTarget(rt, mipLevel, face);
                            var _retCount = _context.Return();
                            return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                        }
                        var _arg3 = _lastArg = _argCount > 3 ? _context.GetArgument(3) : global::Lua.LuaValue.Nil;
                        _lastArgPos = 3; _expectedType = typeof(global::System.Int32);
                        if (_arg3.TryRead<global::System.Int32>(out var _p3_System_Int32))
                        {
                            if (_argCount == 4)
                            {
                                var rt = _p0_UnityEngine_RenderTexture.Instance;
                                var mipLevel = _p1_System_Int32;
                                var face = _p2_UnityEngine_CubemapFace;
                                var depthSlice = _p3_System_Int32;
                                global::UnityEngine.Graphics.SetRenderTarget(rt, mipLevel, face, depthSlice);
                                var _retCount = _context.Return();
                                return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                            }
                        }
                    }
                }
            }
            _lastArgPos = 0; _expectedType = typeof(global::Luny.UnityEngine.LuaRenderBuffer);
            if (_arg0.TryRead<global::Luny.UnityEngine.LuaRenderBuffer>(out var _p0_UnityEngine_RenderBuffer))
            {
                var _arg1 = _lastArg = _argCount > 1 ? _context.GetArgument(1) : global::Lua.LuaValue.Nil;
                _lastArgPos = 1; _expectedType = typeof(global::Luny.UnityEngine.LuaRenderBuffer);
                if (_arg1.TryRead<global::Luny.UnityEngine.LuaRenderBuffer>(out var _p1_UnityEngine_RenderBuffer))
                {
                    if (_argCount == 2)
                    {
                        var colorBuffer = _p0_UnityEngine_RenderBuffer.Value;
                        var depthBuffer = _p1_UnityEngine_RenderBuffer.Value;
                        global::UnityEngine.Graphics.SetRenderTarget(colorBuffer, depthBuffer);
                        var _retCount = _context.Return();
                        return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                    }
                    var _arg2 = _lastArg = _argCount > 2 ? _context.GetArgument(2) : global::Lua.LuaValue.Nil;
                    _lastArgPos = 2; _expectedType = typeof(global::System.Int32);
                    if (_arg2.TryRead<global::System.Int32>(out var _p2_System_Int32))
                    {
                        if (_argCount == 3)
                        {
                            var colorBuffer = _p0_UnityEngine_RenderBuffer.Value;
                            var depthBuffer = _p1_UnityEngine_RenderBuffer.Value;
                            var mipLevel = _p2_System_Int32;
                            global::UnityEngine.Graphics.SetRenderTarget(colorBuffer, depthBuffer, mipLevel);
                            var _retCount = _context.Return();
                            return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                        }
                        var _arg3 = _lastArg = _argCount > 3 ? _context.GetArgument(3) : global::Lua.LuaValue.Nil;
                        _lastArgPos = 3; _expectedType = typeof(global::UnityEngine.CubemapFace);
                        if (_arg3.TryRead<global::UnityEngine.CubemapFace>(out var _p3_UnityEngine_CubemapFace))
                        {
                            if (_argCount == 4)
                            {
                                var colorBuffer = _p0_UnityEngine_RenderBuffer.Value;
                                var depthBuffer = _p1_UnityEngine_RenderBuffer.Value;
                                var mipLevel = _p2_System_Int32;
                                var face = _p3_UnityEngine_CubemapFace;
                                global::UnityEngine.Graphics.SetRenderTarget(colorBuffer, depthBuffer, mipLevel, face);
                                var _retCount = _context.Return();
                                return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                            }
                            var _arg4 = _lastArg = _argCount > 4 ? _context.GetArgument(4) : global::Lua.LuaValue.Nil;
                            _lastArgPos = 4; _expectedType = typeof(global::System.Int32);
                            if (_arg4.TryRead<global::System.Int32>(out var _p4_System_Int32))
                            {
                                if (_argCount == 5)
                                {
                                    var colorBuffer = _p0_UnityEngine_RenderBuffer.Value;
                                    var depthBuffer = _p1_UnityEngine_RenderBuffer.Value;
                                    var mipLevel = _p2_System_Int32;
                                    var face = _p3_UnityEngine_CubemapFace;
                                    var depthSlice = _p4_System_Int32;
                                    global::UnityEngine.Graphics.SetRenderTarget(colorBuffer, depthBuffer, mipLevel, face, depthSlice);
                                    var _retCount = _context.Return();
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
                var _arg1 = _lastArg = _argCount > 1 ? _context.GetArgument(1) : global::Lua.LuaValue.Nil;
                _lastArgPos = 1; _expectedType = typeof(global::Luny.UnityEngine.LuaRenderBuffer);
                if (_arg1.TryRead<global::Luny.UnityEngine.LuaRenderBuffer>(out var _p1_UnityEngine_RenderBuffer))
                {
                    if (_argCount == 2)
                    {
                        var colorBuffers = _p0_UnityEngine_RenderBufferArray;
                        var depthBuffer = _p1_UnityEngine_RenderBuffer.Value;
                        global::UnityEngine.Graphics.SetRenderTarget(colorBuffers, depthBuffer);
                        var _retCount = _context.Return();
                        return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                    }
                }
            }
            _lastArgPos = 0; _expectedType = typeof(global::Luny.UnityEngine.Rendering.LuaGraphicsTexture);
            if (_arg0.TryRead<global::Luny.UnityEngine.Rendering.LuaGraphicsTexture>(out var _p0_UnityEngine_Rendering_GraphicsTexture))
            {
                var _arg1 = _lastArg = _argCount > 1 ? _context.GetArgument(1) : global::Lua.LuaValue.Nil;
                _lastArgPos = 1; _expectedType = typeof(global::System.Int32);
                if (_arg1.TryRead<global::System.Int32>(out var _p1_System_Int32))
                {
                    var _arg2 = _lastArg = _argCount > 2 ? _context.GetArgument(2) : global::Lua.LuaValue.Nil;
                    _lastArgPos = 2; _expectedType = typeof(global::UnityEngine.CubemapFace);
                    if (_arg2.TryRead<global::UnityEngine.CubemapFace>(out var _p2_UnityEngine_CubemapFace))
                    {
                        var _arg3 = _lastArg = _argCount > 3 ? _context.GetArgument(3) : global::Lua.LuaValue.Nil;
                        _lastArgPos = 3; _expectedType = typeof(global::System.Int32);
                        if (_arg3.TryRead<global::System.Int32>(out var _p3_System_Int32))
                        {
                            if (_argCount == 4)
                            {
                                var rt = _p0_UnityEngine_Rendering_GraphicsTexture.Instance;
                                var mipLevel = _p1_System_Int32;
                                var face = _p2_UnityEngine_CubemapFace;
                                var depthSlice = _p3_System_Int32;
                                global::UnityEngine.Graphics.SetRenderTarget(rt, mipLevel, face, depthSlice);
                                var _retCount = _context.Return();
                                return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                            }
                        }
                    }
                }
            }
            throw new global::Lua.LuaRuntimeException(_context.Thread, $"{"SetRenderTarget"}: invalid argument #{_lastArgPos}: {_lastArg} ({_lastArg.Type}), expected: {_expectedType.FullName}", 2);
        });
        private static readonly global::Lua.LuaFunction _LuaGraphics_WaitOnAsyncGraphicsFence = new global::Lua.LuaFunction("WaitOnAsyncGraphicsFence", (_context, _) =>
        {
            global::Lua.LuaValue _lastArg = default;
            global::System.Int32 _lastArgPos = default;
            global::System.Type _expectedType = default;
            var _argCount = _context.ArgumentCount;
            var _arg0 = _lastArg = _argCount > 0 ? _context.GetArgument(0) : global::Lua.LuaValue.Nil;
            _lastArgPos = 0; _expectedType = typeof(global::Luny.UnityEngine.Rendering.LuaGraphicsFence);
            if (_arg0.TryRead<global::Luny.UnityEngine.Rendering.LuaGraphicsFence>(out var _p0_UnityEngine_Rendering_GraphicsFence))
            {
                if (_argCount == 1)
                {
                    var fence = _p0_UnityEngine_Rendering_GraphicsFence.Value;
                    global::UnityEngine.Graphics.WaitOnAsyncGraphicsFence(fence);
                    var _retCount = _context.Return();
                    return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                }
                var _arg1 = _lastArg = _argCount > 1 ? _context.GetArgument(1) : global::Lua.LuaValue.Nil;
                _lastArgPos = 1; _expectedType = typeof(global::UnityEngine.Rendering.SynchronisationStage);
                if (_arg1.TryRead<global::UnityEngine.Rendering.SynchronisationStage>(out var _p1_UnityEngine_Rendering_SynchronisationStage))
                {
                    if (_argCount == 2)
                    {
                        var fence = _p0_UnityEngine_Rendering_GraphicsFence.Value;
                        var stage = _p1_UnityEngine_Rendering_SynchronisationStage;
                        global::UnityEngine.Graphics.WaitOnAsyncGraphicsFence(fence, stage);
                        var _retCount = _context.Return();
                        return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                    }
                }
            }
            throw new global::Lua.LuaRuntimeException(_context.Thread, $"{"WaitOnAsyncGraphicsFence"}: invalid argument #{_lastArgPos}: {_lastArg} ({_lastArg.Type}), expected: {_expectedType.FullName}", 2);
        });
        private static readonly global::Lua.LuaFunction __index = new(global::Lua.Runtime.Metamethods.Index, (_context, _) =>
        {
            var _this = _context.GetArgument<LuaGraphicsType>(0);
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
            var _this = _context.GetArgument<LuaGraphicsType>(0);
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
                case "Blit": _value = _LuaGraphics_Blit; return true;
                case "BlitMultiTap": _value = _LuaGraphics_BlitMultiTap; return true;
                case "ClearRandomWriteTargets": _value = _LuaGraphics_ClearRandomWriteTargets; return true;
                case "ConvertTexture": _value = _LuaGraphics_ConvertTexture; return true;
                case "CopyBuffer": _value = _LuaGraphics_CopyBuffer; return true;
                case "CopyTexture": _value = _LuaGraphics_CopyTexture; return true;
                case "CreateAsyncGraphicsFence": _value = _LuaGraphics_CreateAsyncGraphicsFence; return true;
                case "CreateGraphicsFence": _value = _LuaGraphics_CreateGraphicsFence; return true;
                case "DrawMesh": _value = _LuaGraphics_DrawMesh; return true;
                case "DrawMeshInstanced": _value = _LuaGraphics_DrawMeshInstanced; return true;
                case "DrawMeshInstancedIndirect": _value = _LuaGraphics_DrawMeshInstancedIndirect; return true;
                case "DrawMeshInstancedProcedural": _value = _LuaGraphics_DrawMeshInstancedProcedural; return true;
                case "DrawMeshNow": _value = _LuaGraphics_DrawMeshNow; return true;
                case "DrawProcedural": _value = _LuaGraphics_DrawProcedural; return true;
                case "DrawProceduralIndirect": _value = _LuaGraphics_DrawProceduralIndirect; return true;
                case "DrawProceduralIndirectNow": _value = _LuaGraphics_DrawProceduralIndirectNow; return true;
                case "DrawProceduralNow": _value = _LuaGraphics_DrawProceduralNow; return true;
                case "DrawTexture": _value = _LuaGraphics_DrawTexture; return true;
                case "ExecuteCommandBuffer": _value = _LuaGraphics_ExecuteCommandBuffer; return true;
                case "ExecuteCommandBufferAsync": _value = _LuaGraphics_ExecuteCommandBufferAsync; return true;
                case "SetRandomWriteTarget": _value = _LuaGraphics_SetRandomWriteTarget; return true;
                case "SetRenderTarget": _value = _LuaGraphics_SetRenderTarget; return true;
                case "WaitOnAsyncGraphicsFence": _value = _LuaGraphics_WaitOnAsyncGraphicsFence; return true;
                case "activeColorBuffer": _value = global::Luny.UnityEngine.LuaRenderBuffer.Bind(global::UnityEngine.Graphics.activeColorBuffer); return true;
                case "activeColorGamut": _value = new global::Lua.LuaValue((global::System.Int64)global::UnityEngine.Graphics.activeColorGamut); return true;
                case "activeDepthBuffer": _value = global::Luny.UnityEngine.LuaRenderBuffer.Bind(global::UnityEngine.Graphics.activeDepthBuffer); return true;
                case "activeTier": _value = new global::Lua.LuaValue((global::System.Int64)global::UnityEngine.Graphics.activeTier); return true;
                case "minOpenGLESVersion": _value = new global::Lua.LuaValue((global::System.Int64)global::UnityEngine.Graphics.minOpenGLESVersion); return true;
                case "preserveFramebufferAlpha": _value = new global::Lua.LuaValue(global::UnityEngine.Graphics.preserveFramebufferAlpha); return true;
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
                case "activeTier": global::UnityEngine.Graphics.activeTier = _value.Read<global::UnityEngine.Rendering.GraphicsTier>();  return true;
                default: return false;
            }
        }
    }
}
#pragma warning restore 0109, 0162, 0168, 0219
#endif
