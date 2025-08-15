
// --------------------------------------------------------------
// GENERATED FILE ----> DO NOT EDIT <---- CHANGES WILL BE LOST !!
// --------------------------------------------------------------

#if UNITY_6000_0_OR_NEWER && !(UNITY_6000_1_OR_NEWER)
#pragma warning disable 0109, 0162, 0168, 0219
using Luny;

namespace Luny.UnityEngine
{
    public sealed class LuaTexture2D : global::Luny.UnityEngine.LuaTexture, global::Luny.ILuaObject<global::UnityEngine.Texture2D>
    {
        public new static global::Lua.LuaValue Bind(global::UnityEngine.Texture2D instance) => new LuaTexture2D(instance);
        public new static global::Lua.LuaValue Bind(global::System.Object instance) => Bind((global::UnityEngine.Texture2D)instance);
        public new static global::Lua.LuaValue Bind(global::System.Collections.Generic.IList<global::UnityEngine.Texture2D> instances) =>
            new global::Luny.LuaList<global::UnityEngine.Texture2D>(instances);
        public new static global::Lua.LuaValue Bind(global::System.Collections.Generic.IList<global::System.Object> instances) =>
            new global::Luny.LuaList<global::UnityEngine.Texture2D>(instances);
        private LuaTexture2D(global::UnityEngine.Texture2D instance) : base(instance) {}
        public static implicit operator global::Lua.LuaValue(LuaTexture2D value) => new(value);
        public new global::UnityEngine.Texture2D Instance => (global::UnityEngine.Texture2D)m_Instance;
        public new global::System.Type BindType => typeof(global::UnityEngine.Texture2D);
        private static global::Lua.LuaTable s_Metatable;
        public new global::Lua.LuaTable Metatable
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

        private static readonly global::Lua.LuaFunction _LuaTexture2D_Apply = new global::Lua.LuaFunction("Apply", (_context, _) =>
        {
            global::Lua.LuaValue _lastArg = default;
            global::System.Int32 _lastArgPos = default;
            global::System.Type _expectedType = default;
            var _argCount = _context.ArgumentCount;
            var _this = _context.GetArgument<LuaTexture2D>(0);
            if (_argCount == 1)
            {
                _this.Instance.Apply();
                var _retCount = _context.Return();
                return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
            }
            var _arg0 = _lastArg = _argCount > 1 ? _context.GetArgument(1) : global::Lua.LuaValue.Nil;
            _lastArgPos = 0; _expectedType = typeof(global::System.Boolean);
            if (_arg0.TryRead<global::System.Boolean>(out var _p0_System_Boolean))
            {
                if (_argCount == 2)
                {
                    var updateMipmaps = _p0_System_Boolean;
                    _this.Instance.Apply(updateMipmaps);
                    var _retCount = _context.Return();
                    return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                }
                var _arg1 = _lastArg = _argCount > 2 ? _context.GetArgument(2) : global::Lua.LuaValue.Nil;
                _lastArgPos = 1; _expectedType = typeof(global::System.Boolean);
                if (_arg1.TryRead<global::System.Boolean>(out var _p1_System_Boolean))
                {
                    if (_argCount == 3)
                    {
                        var updateMipmaps = _p0_System_Boolean;
                        var makeNoLongerReadable = _p1_System_Boolean;
                        _this.Instance.Apply(updateMipmaps, makeNoLongerReadable);
                        var _retCount = _context.Return();
                        return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                    }
                }
            }
            throw new global::Lua.LuaRuntimeException(_context.Thread, $"{"Apply"}: invalid argument #{_lastArgPos}: {_lastArg} ({_lastArg.Type}), expected: {_expectedType.FullName}", 2);
        });
        private static readonly global::Lua.LuaFunction _LuaTexture2D_ClearMinimumMipmapLevel = new global::Lua.LuaFunction("ClearMinimumMipmapLevel", (_context, _) =>
        {
            global::Lua.LuaValue _lastArg = default;
            global::System.Int32 _lastArgPos = default;
            global::System.Type _expectedType = default;
            var _argCount = _context.ArgumentCount;
            var _this = _context.GetArgument<LuaTexture2D>(0);
            if (_argCount == 1)
            {
                _this.Instance.ClearMinimumMipmapLevel();
                var _retCount = _context.Return();
                return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
            }
            throw new global::Lua.LuaRuntimeException(_context.Thread, $"{"ClearMinimumMipmapLevel"}: invalid argument #{_lastArgPos}: {_lastArg} ({_lastArg.Type}), expected: {_expectedType.FullName}", 2);
        });
        private static readonly global::Lua.LuaFunction _LuaTexture2D_ClearRequestedMipmapLevel = new global::Lua.LuaFunction("ClearRequestedMipmapLevel", (_context, _) =>
        {
            global::Lua.LuaValue _lastArg = default;
            global::System.Int32 _lastArgPos = default;
            global::System.Type _expectedType = default;
            var _argCount = _context.ArgumentCount;
            var _this = _context.GetArgument<LuaTexture2D>(0);
            if (_argCount == 1)
            {
                _this.Instance.ClearRequestedMipmapLevel();
                var _retCount = _context.Return();
                return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
            }
            throw new global::Lua.LuaRuntimeException(_context.Thread, $"{"ClearRequestedMipmapLevel"}: invalid argument #{_lastArgPos}: {_lastArg} ({_lastArg.Type}), expected: {_expectedType.FullName}", 2);
        });
        private static readonly global::Lua.LuaFunction _LuaTexture2D_Compress = new global::Lua.LuaFunction("Compress", (_context, _) =>
        {
            global::Lua.LuaValue _lastArg = default;
            global::System.Int32 _lastArgPos = default;
            global::System.Type _expectedType = default;
            var _argCount = _context.ArgumentCount;
            var _this = _context.GetArgument<LuaTexture2D>(0);
            var _arg0 = _lastArg = _argCount > 1 ? _context.GetArgument(1) : global::Lua.LuaValue.Nil;
            _lastArgPos = 0; _expectedType = typeof(global::System.Boolean);
            if (_arg0.TryRead<global::System.Boolean>(out var _p0_System_Boolean))
            {
                if (_argCount == 2)
                {
                    var highQuality = _p0_System_Boolean;
                    _this.Instance.Compress(highQuality);
                    var _retCount = _context.Return();
                    return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                }
            }
            throw new global::Lua.LuaRuntimeException(_context.Thread, $"{"Compress"}: invalid argument #{_lastArgPos}: {_lastArg} ({_lastArg.Type}), expected: {_expectedType.FullName}", 2);
        });
        private static readonly global::Lua.LuaFunction _LuaTexture2D_CopyPixels = new global::Lua.LuaFunction("CopyPixels", (_context, _) =>
        {
            global::Lua.LuaValue _lastArg = default;
            global::System.Int32 _lastArgPos = default;
            global::System.Type _expectedType = default;
            var _argCount = _context.ArgumentCount;
            var _this = _context.GetArgument<LuaTexture2D>(0);
            var _arg0 = _lastArg = _argCount > 1 ? _context.GetArgument(1) : global::Lua.LuaValue.Nil;
            _lastArgPos = 0; _expectedType = typeof(global::Luny.UnityEngine.LuaTexture);
            if (_arg0.TryRead<global::Luny.UnityEngine.LuaTexture>(out var _p0_UnityEngine_Texture))
            {
                if (_argCount == 2)
                {
                    var src = _p0_UnityEngine_Texture.Instance;
                    _this.Instance.CopyPixels(src);
                    var _retCount = _context.Return();
                    return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                }
                var _arg1 = _lastArg = _argCount > 2 ? _context.GetArgument(2) : global::Lua.LuaValue.Nil;
                _lastArgPos = 1; _expectedType = typeof(global::System.Int32);
                if (_arg1.TryRead<global::System.Int32>(out var _p1_System_Int32))
                {
                    var _arg2 = _lastArg = _argCount > 3 ? _context.GetArgument(3) : global::Lua.LuaValue.Nil;
                    _lastArgPos = 2; _expectedType = typeof(global::System.Int32);
                    if (_arg2.TryRead<global::System.Int32>(out var _p2_System_Int32))
                    {
                        var _arg3 = _lastArg = _argCount > 4 ? _context.GetArgument(4) : global::Lua.LuaValue.Nil;
                        _lastArgPos = 3; _expectedType = typeof(global::System.Int32);
                        if (_arg3.TryRead<global::System.Int32>(out var _p3_System_Int32))
                        {
                            if (_argCount == 5)
                            {
                                var src = _p0_UnityEngine_Texture.Instance;
                                var srcElement = _p1_System_Int32;
                                var srcMip = _p2_System_Int32;
                                var dstMip = _p3_System_Int32;
                                _this.Instance.CopyPixels(src, srcElement, srcMip, dstMip);
                                var _retCount = _context.Return();
                                return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                            }
                            var _arg4 = _lastArg = _argCount > 5 ? _context.GetArgument(5) : global::Lua.LuaValue.Nil;
                            _lastArgPos = 4; _expectedType = typeof(global::System.Int32);
                            if (_arg4.TryRead<global::System.Int32>(out var _p4_System_Int32))
                            {
                                var _arg5 = _lastArg = _argCount > 6 ? _context.GetArgument(6) : global::Lua.LuaValue.Nil;
                                _lastArgPos = 5; _expectedType = typeof(global::System.Int32);
                                if (_arg5.TryRead<global::System.Int32>(out var _p5_System_Int32))
                                {
                                    var _arg6 = _lastArg = _argCount > 7 ? _context.GetArgument(7) : global::Lua.LuaValue.Nil;
                                    _lastArgPos = 6; _expectedType = typeof(global::System.Int32);
                                    if (_arg6.TryRead<global::System.Int32>(out var _p6_System_Int32))
                                    {
                                        var _arg7 = _lastArg = _argCount > 8 ? _context.GetArgument(8) : global::Lua.LuaValue.Nil;
                                        _lastArgPos = 7; _expectedType = typeof(global::System.Int32);
                                        if (_arg7.TryRead<global::System.Int32>(out var _p7_System_Int32))
                                        {
                                            var _arg8 = _lastArg = _argCount > 9 ? _context.GetArgument(9) : global::Lua.LuaValue.Nil;
                                            _lastArgPos = 8; _expectedType = typeof(global::System.Int32);
                                            if (_arg8.TryRead<global::System.Int32>(out var _p8_System_Int32))
                                            {
                                                var _arg9 = _lastArg = _argCount > 10 ? _context.GetArgument(10) : global::Lua.LuaValue.Nil;
                                                _lastArgPos = 9; _expectedType = typeof(global::System.Int32);
                                                if (_arg9.TryRead<global::System.Int32>(out var _p9_System_Int32))
                                                {
                                                    if (_argCount == 11)
                                                    {
                                                        var src = _p0_UnityEngine_Texture.Instance;
                                                        var srcElement = _p1_System_Int32;
                                                        var srcMip = _p2_System_Int32;
                                                        var srcX = _p3_System_Int32;
                                                        var srcY = _p4_System_Int32;
                                                        var srcWidth = _p5_System_Int32;
                                                        var srcHeight = _p6_System_Int32;
                                                        var dstMip = _p7_System_Int32;
                                                        var dstX = _p8_System_Int32;
                                                        var dstY = _p9_System_Int32;
                                                        _this.Instance.CopyPixels(src, srcElement, srcMip, srcX, srcY, srcWidth, srcHeight, dstMip, dstX, dstY);
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
            throw new global::Lua.LuaRuntimeException(_context.Thread, $"{"CopyPixels"}: invalid argument #{_lastArgPos}: {_lastArg} ({_lastArg.Type}), expected: {_expectedType.FullName}", 2);
        });
        private static readonly global::Lua.LuaFunction _LuaTexture2D_GetPixel = new global::Lua.LuaFunction("GetPixel", (_context, _) =>
        {
            global::Lua.LuaValue _lastArg = default;
            global::System.Int32 _lastArgPos = default;
            global::System.Type _expectedType = default;
            var _argCount = _context.ArgumentCount;
            var _this = _context.GetArgument<LuaTexture2D>(0);
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
                        var x = _p0_System_Int32;
                        var y = _p1_System_Int32;
                        var _ret0 = _this.Instance.GetPixel(x, y);
                        var _lret0 = global::Luny.UnityEngine.LuaColor.Bind(_ret0);
                        var _retCount = _context.Return(_lret0);
                        return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                    }
                    var _arg2 = _lastArg = _argCount > 3 ? _context.GetArgument(3) : global::Lua.LuaValue.Nil;
                    _lastArgPos = 2; _expectedType = typeof(global::System.Int32);
                    if (_arg2.TryRead<global::System.Int32>(out var _p2_System_Int32))
                    {
                        if (_argCount == 4)
                        {
                            var x = _p0_System_Int32;
                            var y = _p1_System_Int32;
                            var mipLevel = _p2_System_Int32;
                            var _ret0 = _this.Instance.GetPixel(x, y, mipLevel);
                            var _lret0 = global::Luny.UnityEngine.LuaColor.Bind(_ret0);
                            var _retCount = _context.Return(_lret0);
                            return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                        }
                    }
                }
            }
            throw new global::Lua.LuaRuntimeException(_context.Thread, $"{"GetPixel"}: invalid argument #{_lastArgPos}: {_lastArg} ({_lastArg.Type}), expected: {_expectedType.FullName}", 2);
        });
        private static readonly global::Lua.LuaFunction _LuaTexture2D_GetPixelBilinear = new global::Lua.LuaFunction("GetPixelBilinear", (_context, _) =>
        {
            global::Lua.LuaValue _lastArg = default;
            global::System.Int32 _lastArgPos = default;
            global::System.Type _expectedType = default;
            var _argCount = _context.ArgumentCount;
            var _this = _context.GetArgument<LuaTexture2D>(0);
            var _arg0 = _lastArg = _argCount > 1 ? _context.GetArgument(1) : global::Lua.LuaValue.Nil;
            _lastArgPos = 0; _expectedType = typeof(global::System.Single);
            if (_arg0.TryRead<global::System.Single>(out var _p0_System_Single))
            {
                var _arg1 = _lastArg = _argCount > 2 ? _context.GetArgument(2) : global::Lua.LuaValue.Nil;
                _lastArgPos = 1; _expectedType = typeof(global::System.Single);
                if (_arg1.TryRead<global::System.Single>(out var _p1_System_Single))
                {
                    if (_argCount == 3)
                    {
                        var u = _p0_System_Single;
                        var v = _p1_System_Single;
                        var _ret0 = _this.Instance.GetPixelBilinear(u, v);
                        var _lret0 = global::Luny.UnityEngine.LuaColor.Bind(_ret0);
                        var _retCount = _context.Return(_lret0);
                        return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                    }
                    var _arg2 = _lastArg = _argCount > 3 ? _context.GetArgument(3) : global::Lua.LuaValue.Nil;
                    _lastArgPos = 2; _expectedType = typeof(global::System.Int32);
                    if (_arg2.TryRead<global::System.Int32>(out var _p2_System_Int32))
                    {
                        if (_argCount == 4)
                        {
                            var u = _p0_System_Single;
                            var v = _p1_System_Single;
                            var mipLevel = _p2_System_Int32;
                            var _ret0 = _this.Instance.GetPixelBilinear(u, v, mipLevel);
                            var _lret0 = global::Luny.UnityEngine.LuaColor.Bind(_ret0);
                            var _retCount = _context.Return(_lret0);
                            return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                        }
                    }
                }
            }
            throw new global::Lua.LuaRuntimeException(_context.Thread, $"{"GetPixelBilinear"}: invalid argument #{_lastArgPos}: {_lastArg} ({_lastArg.Type}), expected: {_expectedType.FullName}", 2);
        });
        private static readonly global::Lua.LuaFunction _LuaTexture2D_GetPixels = new global::Lua.LuaFunction("GetPixels", (_context, _) =>
        {
            global::Lua.LuaValue _lastArg = default;
            global::System.Int32 _lastArgPos = default;
            global::System.Type _expectedType = default;
            var _argCount = _context.ArgumentCount;
            var _this = _context.GetArgument<LuaTexture2D>(0);
            if (_argCount == 1)
            {
                var _ret0 = _this.Instance.GetPixels();
                var _factory = _context.GetObjectFactory();
                var _lret0 = _factory.Bind(_ret0);
                var _retCount = _context.Return(_lret0);
                return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
            }
            var _arg0 = _lastArg = _argCount > 1 ? _context.GetArgument(1) : global::Lua.LuaValue.Nil;
            _lastArgPos = 0; _expectedType = typeof(global::System.Int32);
            if (_arg0.TryRead<global::System.Int32>(out var _p0_System_Int32))
            {
                if (_argCount == 2)
                {
                    var miplevel = _p0_System_Int32;
                    var _ret0 = _this.Instance.GetPixels(miplevel);
                    var _factory = _context.GetObjectFactory();
                    var _lret0 = _factory.Bind(_ret0);
                    var _retCount = _context.Return(_lret0);
                    return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                }
                var _arg1 = _lastArg = _argCount > 2 ? _context.GetArgument(2) : global::Lua.LuaValue.Nil;
                _lastArgPos = 1; _expectedType = typeof(global::System.Int32);
                if (_arg1.TryRead<global::System.Int32>(out var _p1_System_Int32))
                {
                    var _arg2 = _lastArg = _argCount > 3 ? _context.GetArgument(3) : global::Lua.LuaValue.Nil;
                    _lastArgPos = 2; _expectedType = typeof(global::System.Int32);
                    if (_arg2.TryRead<global::System.Int32>(out var _p2_System_Int32))
                    {
                        var _arg3 = _lastArg = _argCount > 4 ? _context.GetArgument(4) : global::Lua.LuaValue.Nil;
                        _lastArgPos = 3; _expectedType = typeof(global::System.Int32);
                        if (_arg3.TryRead<global::System.Int32>(out var _p3_System_Int32))
                        {
                            if (_argCount == 5)
                            {
                                var x = _p0_System_Int32;
                                var y = _p1_System_Int32;
                                var blockWidth = _p2_System_Int32;
                                var blockHeight = _p3_System_Int32;
                                var _ret0 = _this.Instance.GetPixels(x, y, blockWidth, blockHeight);
                                var _factory = _context.GetObjectFactory();
                                var _lret0 = _factory.Bind(_ret0);
                                var _retCount = _context.Return(_lret0);
                                return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                            }
                            var _arg4 = _lastArg = _argCount > 5 ? _context.GetArgument(5) : global::Lua.LuaValue.Nil;
                            _lastArgPos = 4; _expectedType = typeof(global::System.Int32);
                            if (_arg4.TryRead<global::System.Int32>(out var _p4_System_Int32))
                            {
                                if (_argCount == 6)
                                {
                                    var x = _p0_System_Int32;
                                    var y = _p1_System_Int32;
                                    var blockWidth = _p2_System_Int32;
                                    var blockHeight = _p3_System_Int32;
                                    var miplevel = _p4_System_Int32;
                                    var _ret0 = _this.Instance.GetPixels(x, y, blockWidth, blockHeight, miplevel);
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
            throw new global::Lua.LuaRuntimeException(_context.Thread, $"{"GetPixels"}: invalid argument #{_lastArgPos}: {_lastArg} ({_lastArg.Type}), expected: {_expectedType.FullName}", 2);
        });
        private static readonly global::Lua.LuaFunction _LuaTexture2D_GetPixels32 = new global::Lua.LuaFunction("GetPixels32", (_context, _) =>
        {
            global::Lua.LuaValue _lastArg = default;
            global::System.Int32 _lastArgPos = default;
            global::System.Type _expectedType = default;
            var _argCount = _context.ArgumentCount;
            var _this = _context.GetArgument<LuaTexture2D>(0);
            if (_argCount == 1)
            {
                var _ret0 = _this.Instance.GetPixels32();
                var _factory = _context.GetObjectFactory();
                var _lret0 = _factory.Bind(_ret0);
                var _retCount = _context.Return(_lret0);
                return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
            }
            var _arg0 = _lastArg = _argCount > 1 ? _context.GetArgument(1) : global::Lua.LuaValue.Nil;
            _lastArgPos = 0; _expectedType = typeof(global::System.Int32);
            if (_arg0.TryRead<global::System.Int32>(out var _p0_System_Int32))
            {
                if (_argCount == 2)
                {
                    var miplevel = _p0_System_Int32;
                    var _ret0 = _this.Instance.GetPixels32(miplevel);
                    var _factory = _context.GetObjectFactory();
                    var _lret0 = _factory.Bind(_ret0);
                    var _retCount = _context.Return(_lret0);
                    return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                }
            }
            throw new global::Lua.LuaRuntimeException(_context.Thread, $"{"GetPixels32"}: invalid argument #{_lastArgPos}: {_lastArg} ({_lastArg.Type}), expected: {_expectedType.FullName}", 2);
        });
        private static readonly global::Lua.LuaFunction _LuaTexture2D_GetRawTextureData = new global::Lua.LuaFunction("GetRawTextureData", (_context, _) =>
        {
            global::Lua.LuaValue _lastArg = default;
            global::System.Int32 _lastArgPos = default;
            global::System.Type _expectedType = default;
            var _argCount = _context.ArgumentCount;
            var _this = _context.GetArgument<LuaTexture2D>(0);
            if (_argCount == 1)
            {
                var _ret0 = _this.Instance.GetRawTextureData();
                var _factory = _context.GetObjectFactory();
                var _lret0 = _factory.Bind(_ret0);
                var _retCount = _context.Return(_lret0);
                return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
            }
            throw new global::Lua.LuaRuntimeException(_context.Thread, $"{"GetRawTextureData"}: invalid argument #{_lastArgPos}: {_lastArg} ({_lastArg.Type}), expected: {_expectedType.FullName}", 2);
        });
        private static readonly global::Lua.LuaFunction _LuaTexture2D_IsRequestedMipmapLevelLoaded = new global::Lua.LuaFunction("IsRequestedMipmapLevelLoaded", (_context, _) =>
        {
            global::Lua.LuaValue _lastArg = default;
            global::System.Int32 _lastArgPos = default;
            global::System.Type _expectedType = default;
            var _argCount = _context.ArgumentCount;
            var _this = _context.GetArgument<LuaTexture2D>(0);
            if (_argCount == 1)
            {
                var _ret0 = _this.Instance.IsRequestedMipmapLevelLoaded();
                var _lret0 = new global::Lua.LuaValue(_ret0);
                var _retCount = _context.Return(_lret0);
                return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
            }
            throw new global::Lua.LuaRuntimeException(_context.Thread, $"{"IsRequestedMipmapLevelLoaded"}: invalid argument #{_lastArgPos}: {_lastArg} ({_lastArg.Type}), expected: {_expectedType.FullName}", 2);
        });
        private static readonly global::Lua.LuaFunction _LuaTexture2D_LoadRawTextureData = new global::Lua.LuaFunction("LoadRawTextureData", (_context, _) =>
        {
            global::Lua.LuaValue _lastArg = default;
            global::System.Int32 _lastArgPos = default;
            global::System.Type _expectedType = default;
            var _argCount = _context.ArgumentCount;
            var _this = _context.GetArgument<LuaTexture2D>(0);
            var _arg0 = _lastArg = _argCount > 1 ? _context.GetArgument(1) : global::Lua.LuaValue.Nil;
            _lastArgPos = 0; _expectedType = typeof(global::System.Byte[]);
            if (_arg0.TryReadArray<global::System.Byte>(out var _p0_System_ByteArray))
            {
                if (_argCount == 2)
                {
                    var data = _p0_System_ByteArray;
                    _this.Instance.LoadRawTextureData(data);
                    var _retCount = _context.Return();
                    return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                }
            }
            throw new global::Lua.LuaRuntimeException(_context.Thread, $"{"LoadRawTextureData"}: invalid argument #{_lastArgPos}: {_lastArg} ({_lastArg.Type}), expected: {_expectedType.FullName}", 2);
        });
        private static readonly global::Lua.LuaFunction _LuaTexture2D_PackTextures = new global::Lua.LuaFunction("PackTextures", (_context, _) =>
        {
            global::Lua.LuaValue _lastArg = default;
            global::System.Int32 _lastArgPos = default;
            global::System.Type _expectedType = default;
            var _argCount = _context.ArgumentCount;
            var _this = _context.GetArgument<LuaTexture2D>(0);
            var _arg0 = _lastArg = _argCount > 1 ? _context.GetArgument(1) : global::Lua.LuaValue.Nil;
            _lastArgPos = 0; _expectedType = typeof(global::UnityEngine.Texture2D[]);
            if (_arg0.TryReadArray<global::UnityEngine.Texture2D>(out var _p0_UnityEngine_Texture2DArray))
            {
                var _arg1 = _lastArg = _argCount > 2 ? _context.GetArgument(2) : global::Lua.LuaValue.Nil;
                _lastArgPos = 1; _expectedType = typeof(global::System.Int32);
                if (_arg1.TryRead<global::System.Int32>(out var _p1_System_Int32))
                {
                    if (_argCount == 3)
                    {
                        var textures = _p0_UnityEngine_Texture2DArray;
                        var padding = _p1_System_Int32;
                        var _ret0 = _this.Instance.PackTextures(textures, padding);
                        var _factory = _context.GetObjectFactory();
                        var _lret0 = _factory.Bind(_ret0);
                        var _retCount = _context.Return(_lret0);
                        return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                    }
                    var _arg2 = _lastArg = _argCount > 3 ? _context.GetArgument(3) : global::Lua.LuaValue.Nil;
                    _lastArgPos = 2; _expectedType = typeof(global::System.Int32);
                    if (_arg2.TryRead<global::System.Int32>(out var _p2_System_Int32))
                    {
                        if (_argCount == 4)
                        {
                            var textures = _p0_UnityEngine_Texture2DArray;
                            var padding = _p1_System_Int32;
                            var maximumAtlasSize = _p2_System_Int32;
                            var _ret0 = _this.Instance.PackTextures(textures, padding, maximumAtlasSize);
                            var _factory = _context.GetObjectFactory();
                            var _lret0 = _factory.Bind(_ret0);
                            var _retCount = _context.Return(_lret0);
                            return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                        }
                        var _arg3 = _lastArg = _argCount > 4 ? _context.GetArgument(4) : global::Lua.LuaValue.Nil;
                        _lastArgPos = 3; _expectedType = typeof(global::System.Boolean);
                        if (_arg3.TryRead<global::System.Boolean>(out var _p3_System_Boolean))
                        {
                            if (_argCount == 5)
                            {
                                var textures = _p0_UnityEngine_Texture2DArray;
                                var padding = _p1_System_Int32;
                                var maximumAtlasSize = _p2_System_Int32;
                                var makeNoLongerReadable = _p3_System_Boolean;
                                var _ret0 = _this.Instance.PackTextures(textures, padding, maximumAtlasSize, makeNoLongerReadable);
                                var _factory = _context.GetObjectFactory();
                                var _lret0 = _factory.Bind(_ret0);
                                var _retCount = _context.Return(_lret0);
                                return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                            }
                        }
                    }
                }
            }
            throw new global::Lua.LuaRuntimeException(_context.Thread, $"{"PackTextures"}: invalid argument #{_lastArgPos}: {_lastArg} ({_lastArg.Type}), expected: {_expectedType.FullName}", 2);
        });
        private static readonly global::Lua.LuaFunction _LuaTexture2D_ReadPixels = new global::Lua.LuaFunction("ReadPixels", (_context, _) =>
        {
            global::Lua.LuaValue _lastArg = default;
            global::System.Int32 _lastArgPos = default;
            global::System.Type _expectedType = default;
            var _argCount = _context.ArgumentCount;
            var _this = _context.GetArgument<LuaTexture2D>(0);
            var _arg0 = _lastArg = _argCount > 1 ? _context.GetArgument(1) : global::Lua.LuaValue.Nil;
            _lastArgPos = 0; _expectedType = typeof(global::Luny.UnityEngine.LuaRect);
            if (_arg0.TryRead<global::Luny.UnityEngine.LuaRect>(out var _p0_UnityEngine_Rect))
            {
                var _arg1 = _lastArg = _argCount > 2 ? _context.GetArgument(2) : global::Lua.LuaValue.Nil;
                _lastArgPos = 1; _expectedType = typeof(global::System.Int32);
                if (_arg1.TryRead<global::System.Int32>(out var _p1_System_Int32))
                {
                    var _arg2 = _lastArg = _argCount > 3 ? _context.GetArgument(3) : global::Lua.LuaValue.Nil;
                    _lastArgPos = 2; _expectedType = typeof(global::System.Int32);
                    if (_arg2.TryRead<global::System.Int32>(out var _p2_System_Int32))
                    {
                        if (_argCount == 4)
                        {
                            var source = _p0_UnityEngine_Rect.Value;
                            var destX = _p1_System_Int32;
                            var destY = _p2_System_Int32;
                            _this.Instance.ReadPixels(source, destX, destY);
                            var _retCount = _context.Return();
                            return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                        }
                        var _arg3 = _lastArg = _argCount > 4 ? _context.GetArgument(4) : global::Lua.LuaValue.Nil;
                        _lastArgPos = 3; _expectedType = typeof(global::System.Boolean);
                        if (_arg3.TryRead<global::System.Boolean>(out var _p3_System_Boolean))
                        {
                            if (_argCount == 5)
                            {
                                var source = _p0_UnityEngine_Rect.Value;
                                var destX = _p1_System_Int32;
                                var destY = _p2_System_Int32;
                                var recalculateMipMaps = _p3_System_Boolean;
                                _this.Instance.ReadPixels(source, destX, destY, recalculateMipMaps);
                                var _retCount = _context.Return();
                                return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                            }
                        }
                    }
                }
            }
            throw new global::Lua.LuaRuntimeException(_context.Thread, $"{"ReadPixels"}: invalid argument #{_lastArgPos}: {_lastArg} ({_lastArg.Type}), expected: {_expectedType.FullName}", 2);
        });
        private static readonly global::Lua.LuaFunction _LuaTexture2D_Reinitialize = new global::Lua.LuaFunction("Reinitialize", (_context, _) =>
        {
            global::Lua.LuaValue _lastArg = default;
            global::System.Int32 _lastArgPos = default;
            global::System.Type _expectedType = default;
            var _argCount = _context.ArgumentCount;
            var _this = _context.GetArgument<LuaTexture2D>(0);
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
                        var _ret0 = _this.Instance.Reinitialize(width, height);
                        var _lret0 = new global::Lua.LuaValue(_ret0);
                        var _retCount = _context.Return(_lret0);
                        return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                    }
                    var _arg2 = _lastArg = _argCount > 3 ? _context.GetArgument(3) : global::Lua.LuaValue.Nil;
                    _lastArgPos = 2; _expectedType = typeof(global::UnityEngine.Experimental.Rendering.GraphicsFormat);
                    if (_arg2.TryRead<global::UnityEngine.Experimental.Rendering.GraphicsFormat>(out var _p2_UnityEngine_Experimental_Rendering_GraphicsFormat))
                    {
                        var _arg3 = _lastArg = _argCount > 4 ? _context.GetArgument(4) : global::Lua.LuaValue.Nil;
                        _lastArgPos = 3; _expectedType = typeof(global::System.Boolean);
                        if (_arg3.TryRead<global::System.Boolean>(out var _p3_System_Boolean))
                        {
                            if (_argCount == 5)
                            {
                                var width = _p0_System_Int32;
                                var height = _p1_System_Int32;
                                var format = _p2_UnityEngine_Experimental_Rendering_GraphicsFormat;
                                var hasMipMap = _p3_System_Boolean;
                                var _ret0 = _this.Instance.Reinitialize(width, height, format, hasMipMap);
                                var _lret0 = new global::Lua.LuaValue(_ret0);
                                var _retCount = _context.Return(_lret0);
                                return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                            }
                        }
                    }
                    _lastArgPos = 2; _expectedType = typeof(global::UnityEngine.TextureFormat);
                    if (_arg2.TryRead<global::UnityEngine.TextureFormat>(out var _p2_UnityEngine_TextureFormat))
                    {
                        var _arg3 = _lastArg = _argCount > 4 ? _context.GetArgument(4) : global::Lua.LuaValue.Nil;
                        _lastArgPos = 3; _expectedType = typeof(global::System.Boolean);
                        if (_arg3.TryRead<global::System.Boolean>(out var _p3_System_Boolean))
                        {
                            if (_argCount == 5)
                            {
                                var width = _p0_System_Int32;
                                var height = _p1_System_Int32;
                                var format = _p2_UnityEngine_TextureFormat;
                                var hasMipMap = _p3_System_Boolean;
                                var _ret0 = _this.Instance.Reinitialize(width, height, format, hasMipMap);
                                var _lret0 = new global::Lua.LuaValue(_ret0);
                                var _retCount = _context.Return(_lret0);
                                return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                            }
                        }
                    }
                }
            }
            throw new global::Lua.LuaRuntimeException(_context.Thread, $"{"Reinitialize"}: invalid argument #{_lastArgPos}: {_lastArg} ({_lastArg.Type}), expected: {_expectedType.FullName}", 2);
        });
        private static readonly global::Lua.LuaFunction _LuaTexture2D_SetPixel = new global::Lua.LuaFunction("SetPixel", (_context, _) =>
        {
            global::Lua.LuaValue _lastArg = default;
            global::System.Int32 _lastArgPos = default;
            global::System.Type _expectedType = default;
            var _argCount = _context.ArgumentCount;
            var _this = _context.GetArgument<LuaTexture2D>(0);
            var _arg0 = _lastArg = _argCount > 1 ? _context.GetArgument(1) : global::Lua.LuaValue.Nil;
            _lastArgPos = 0; _expectedType = typeof(global::System.Int32);
            if (_arg0.TryRead<global::System.Int32>(out var _p0_System_Int32))
            {
                var _arg1 = _lastArg = _argCount > 2 ? _context.GetArgument(2) : global::Lua.LuaValue.Nil;
                _lastArgPos = 1; _expectedType = typeof(global::System.Int32);
                if (_arg1.TryRead<global::System.Int32>(out var _p1_System_Int32))
                {
                    var _arg2 = _lastArg = _argCount > 3 ? _context.GetArgument(3) : global::Lua.LuaValue.Nil;
                    _lastArgPos = 2; _expectedType = typeof(global::Luny.UnityEngine.LuaColor);
                    if (_arg2.TryRead<global::Luny.UnityEngine.LuaColor>(out var _p2_UnityEngine_Color))
                    {
                        if (_argCount == 4)
                        {
                            var x = _p0_System_Int32;
                            var y = _p1_System_Int32;
                            var color = _p2_UnityEngine_Color.Value;
                            _this.Instance.SetPixel(x, y, color);
                            var _retCount = _context.Return();
                            return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                        }
                        var _arg3 = _lastArg = _argCount > 4 ? _context.GetArgument(4) : global::Lua.LuaValue.Nil;
                        _lastArgPos = 3; _expectedType = typeof(global::System.Int32);
                        if (_arg3.TryRead<global::System.Int32>(out var _p3_System_Int32))
                        {
                            if (_argCount == 5)
                            {
                                var x = _p0_System_Int32;
                                var y = _p1_System_Int32;
                                var color = _p2_UnityEngine_Color.Value;
                                var mipLevel = _p3_System_Int32;
                                _this.Instance.SetPixel(x, y, color, mipLevel);
                                var _retCount = _context.Return();
                                return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                            }
                        }
                    }
                }
            }
            throw new global::Lua.LuaRuntimeException(_context.Thread, $"{"SetPixel"}: invalid argument #{_lastArgPos}: {_lastArg} ({_lastArg.Type}), expected: {_expectedType.FullName}", 2);
        });
        private static readonly global::Lua.LuaFunction _LuaTexture2D_SetPixels = new global::Lua.LuaFunction("SetPixels", (_context, _) =>
        {
            global::Lua.LuaValue _lastArg = default;
            global::System.Int32 _lastArgPos = default;
            global::System.Type _expectedType = default;
            var _argCount = _context.ArgumentCount;
            var _this = _context.GetArgument<LuaTexture2D>(0);
            var _arg0 = _lastArg = _argCount > 1 ? _context.GetArgument(1) : global::Lua.LuaValue.Nil;
            _lastArgPos = 0; _expectedType = typeof(global::UnityEngine.Color[]);
            if (_arg0.TryReadArray<global::UnityEngine.Color>(out var _p0_UnityEngine_ColorArray))
            {
                if (_argCount == 2)
                {
                    var colors = _p0_UnityEngine_ColorArray;
                    _this.Instance.SetPixels(colors);
                    var _retCount = _context.Return();
                    return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                }
                var _arg1 = _lastArg = _argCount > 2 ? _context.GetArgument(2) : global::Lua.LuaValue.Nil;
                _lastArgPos = 1; _expectedType = typeof(global::System.Int32);
                if (_arg1.TryRead<global::System.Int32>(out var _p1_System_Int32))
                {
                    if (_argCount == 3)
                    {
                        var colors = _p0_UnityEngine_ColorArray;
                        var miplevel = _p1_System_Int32;
                        _this.Instance.SetPixels(colors, miplevel);
                        var _retCount = _context.Return();
                        return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                    }
                }
            }
            _lastArgPos = 0; _expectedType = typeof(global::System.Int32);
            if (_arg0.TryRead<global::System.Int32>(out var _p0_System_Int32))
            {
                var _arg1 = _lastArg = _argCount > 2 ? _context.GetArgument(2) : global::Lua.LuaValue.Nil;
                _lastArgPos = 1; _expectedType = typeof(global::System.Int32);
                if (_arg1.TryRead<global::System.Int32>(out var _p1_System_Int32))
                {
                    var _arg2 = _lastArg = _argCount > 3 ? _context.GetArgument(3) : global::Lua.LuaValue.Nil;
                    _lastArgPos = 2; _expectedType = typeof(global::System.Int32);
                    if (_arg2.TryRead<global::System.Int32>(out var _p2_System_Int32))
                    {
                        var _arg3 = _lastArg = _argCount > 4 ? _context.GetArgument(4) : global::Lua.LuaValue.Nil;
                        _lastArgPos = 3; _expectedType = typeof(global::System.Int32);
                        if (_arg3.TryRead<global::System.Int32>(out var _p3_System_Int32))
                        {
                            var _arg4 = _lastArg = _argCount > 5 ? _context.GetArgument(5) : global::Lua.LuaValue.Nil;
                            _lastArgPos = 4; _expectedType = typeof(global::UnityEngine.Color[]);
                            if (_arg4.TryReadArray<global::UnityEngine.Color>(out var _p4_UnityEngine_ColorArray))
                            {
                                if (_argCount == 6)
                                {
                                    var x = _p0_System_Int32;
                                    var y = _p1_System_Int32;
                                    var blockWidth = _p2_System_Int32;
                                    var blockHeight = _p3_System_Int32;
                                    var colors = _p4_UnityEngine_ColorArray;
                                    _this.Instance.SetPixels(x, y, blockWidth, blockHeight, colors);
                                    var _retCount = _context.Return();
                                    return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                                }
                                var _arg5 = _lastArg = _argCount > 6 ? _context.GetArgument(6) : global::Lua.LuaValue.Nil;
                                _lastArgPos = 5; _expectedType = typeof(global::System.Int32);
                                if (_arg5.TryRead<global::System.Int32>(out var _p5_System_Int32))
                                {
                                    if (_argCount == 7)
                                    {
                                        var x = _p0_System_Int32;
                                        var y = _p1_System_Int32;
                                        var blockWidth = _p2_System_Int32;
                                        var blockHeight = _p3_System_Int32;
                                        var colors = _p4_UnityEngine_ColorArray;
                                        var miplevel = _p5_System_Int32;
                                        _this.Instance.SetPixels(x, y, blockWidth, blockHeight, colors, miplevel);
                                        var _retCount = _context.Return();
                                        return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                                    }
                                }
                            }
                        }
                    }
                }
            }
            throw new global::Lua.LuaRuntimeException(_context.Thread, $"{"SetPixels"}: invalid argument #{_lastArgPos}: {_lastArg} ({_lastArg.Type}), expected: {_expectedType.FullName}", 2);
        });
        private static readonly global::Lua.LuaFunction _LuaTexture2D_SetPixels32 = new global::Lua.LuaFunction("SetPixels32", (_context, _) =>
        {
            global::Lua.LuaValue _lastArg = default;
            global::System.Int32 _lastArgPos = default;
            global::System.Type _expectedType = default;
            var _argCount = _context.ArgumentCount;
            var _this = _context.GetArgument<LuaTexture2D>(0);
            var _arg0 = _lastArg = _argCount > 1 ? _context.GetArgument(1) : global::Lua.LuaValue.Nil;
            _lastArgPos = 0; _expectedType = typeof(global::UnityEngine.Color32[]);
            if (_arg0.TryReadArray<global::UnityEngine.Color32>(out var _p0_UnityEngine_Color32Array))
            {
                if (_argCount == 2)
                {
                    var colors = _p0_UnityEngine_Color32Array;
                    _this.Instance.SetPixels32(colors);
                    var _retCount = _context.Return();
                    return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                }
                var _arg1 = _lastArg = _argCount > 2 ? _context.GetArgument(2) : global::Lua.LuaValue.Nil;
                _lastArgPos = 1; _expectedType = typeof(global::System.Int32);
                if (_arg1.TryRead<global::System.Int32>(out var _p1_System_Int32))
                {
                    if (_argCount == 3)
                    {
                        var colors = _p0_UnityEngine_Color32Array;
                        var miplevel = _p1_System_Int32;
                        _this.Instance.SetPixels32(colors, miplevel);
                        var _retCount = _context.Return();
                        return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                    }
                }
            }
            _lastArgPos = 0; _expectedType = typeof(global::System.Int32);
            if (_arg0.TryRead<global::System.Int32>(out var _p0_System_Int32))
            {
                var _arg1 = _lastArg = _argCount > 2 ? _context.GetArgument(2) : global::Lua.LuaValue.Nil;
                _lastArgPos = 1; _expectedType = typeof(global::System.Int32);
                if (_arg1.TryRead<global::System.Int32>(out var _p1_System_Int32))
                {
                    var _arg2 = _lastArg = _argCount > 3 ? _context.GetArgument(3) : global::Lua.LuaValue.Nil;
                    _lastArgPos = 2; _expectedType = typeof(global::System.Int32);
                    if (_arg2.TryRead<global::System.Int32>(out var _p2_System_Int32))
                    {
                        var _arg3 = _lastArg = _argCount > 4 ? _context.GetArgument(4) : global::Lua.LuaValue.Nil;
                        _lastArgPos = 3; _expectedType = typeof(global::System.Int32);
                        if (_arg3.TryRead<global::System.Int32>(out var _p3_System_Int32))
                        {
                            var _arg4 = _lastArg = _argCount > 5 ? _context.GetArgument(5) : global::Lua.LuaValue.Nil;
                            _lastArgPos = 4; _expectedType = typeof(global::UnityEngine.Color32[]);
                            if (_arg4.TryReadArray<global::UnityEngine.Color32>(out var _p4_UnityEngine_Color32Array))
                            {
                                if (_argCount == 6)
                                {
                                    var x = _p0_System_Int32;
                                    var y = _p1_System_Int32;
                                    var blockWidth = _p2_System_Int32;
                                    var blockHeight = _p3_System_Int32;
                                    var colors = _p4_UnityEngine_Color32Array;
                                    _this.Instance.SetPixels32(x, y, blockWidth, blockHeight, colors);
                                    var _retCount = _context.Return();
                                    return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                                }
                                var _arg5 = _lastArg = _argCount > 6 ? _context.GetArgument(6) : global::Lua.LuaValue.Nil;
                                _lastArgPos = 5; _expectedType = typeof(global::System.Int32);
                                if (_arg5.TryRead<global::System.Int32>(out var _p5_System_Int32))
                                {
                                    if (_argCount == 7)
                                    {
                                        var x = _p0_System_Int32;
                                        var y = _p1_System_Int32;
                                        var blockWidth = _p2_System_Int32;
                                        var blockHeight = _p3_System_Int32;
                                        var colors = _p4_UnityEngine_Color32Array;
                                        var miplevel = _p5_System_Int32;
                                        _this.Instance.SetPixels32(x, y, blockWidth, blockHeight, colors, miplevel);
                                        var _retCount = _context.Return();
                                        return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                                    }
                                }
                            }
                        }
                    }
                }
            }
            throw new global::Lua.LuaRuntimeException(_context.Thread, $"{"SetPixels32"}: invalid argument #{_lastArgPos}: {_lastArg} ({_lastArg.Type}), expected: {_expectedType.FullName}", 2);
        });
        private static readonly global::Lua.LuaFunction __index = new(global::Lua.Runtime.Metamethods.Index, (_context, _) =>
        {
            var _this = _context.GetArgument<LuaTexture2D>(0);
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
            var _this = _context.GetArgument<LuaTexture2D>(0);
            var _key = _context.GetArgument(1);
            var _value = _context.GetArgument(2);
            if (_key.Type == global::Lua.LuaValueType.Number && _key.TryRead<global::System.Int32>(out var _index) && _this.TrySetLuaValue(_index, _value))
                return new global::System.Threading.Tasks.ValueTask<global::System.Int32>(_context.Return(_value));
            if (_key.Type == global::Lua.LuaValueType.String && _this.TrySetLuaValue(_key.Read<global::System.String>(), _value))
                return new global::System.Threading.Tasks.ValueTask<global::System.Int32>(_context.Return(_value));
            throw new global::Lua.LuaRuntimeException(_context.Thread, $"attempt to assign to unknown '{_key}' on '{_this}'", 2);
        });

        public override global::System.Boolean TryGetLuaValue(global::System.Int32 _key, out global::Lua.LuaValue _value, global::Luny.ILuaObjectFactory _factory)
        {
            return base.TryGetLuaValue(_key, out _value, _factory);
        }
        public override global::System.Boolean TryGetLuaValue(global::System.String _key, out global::Lua.LuaValue _value, global::Luny.ILuaObjectFactory _factory)
        {
            switch (_key)
            {
                case "Apply": _value = _LuaTexture2D_Apply; return true;
                case "ClearMinimumMipmapLevel": _value = _LuaTexture2D_ClearMinimumMipmapLevel; return true;
                case "ClearRequestedMipmapLevel": _value = _LuaTexture2D_ClearRequestedMipmapLevel; return true;
                case "Compress": _value = _LuaTexture2D_Compress; return true;
                case "CopyPixels": _value = _LuaTexture2D_CopyPixels; return true;
                case "GetPixel": _value = _LuaTexture2D_GetPixel; return true;
                case "GetPixelBilinear": _value = _LuaTexture2D_GetPixelBilinear; return true;
                case "GetPixels": _value = _LuaTexture2D_GetPixels; return true;
                case "GetPixels32": _value = _LuaTexture2D_GetPixels32; return true;
                case "GetRawTextureData": _value = _LuaTexture2D_GetRawTextureData; return true;
                case "IsRequestedMipmapLevelLoaded": _value = _LuaTexture2D_IsRequestedMipmapLevelLoaded; return true;
                case "LoadRawTextureData": _value = _LuaTexture2D_LoadRawTextureData; return true;
                case "PackTextures": _value = _LuaTexture2D_PackTextures; return true;
                case "ReadPixels": _value = _LuaTexture2D_ReadPixels; return true;
                case "Reinitialize": _value = _LuaTexture2D_Reinitialize; return true;
                case "SetPixel": _value = _LuaTexture2D_SetPixel; return true;
                case "SetPixels": _value = _LuaTexture2D_SetPixels; return true;
                case "SetPixels32": _value = _LuaTexture2D_SetPixels32; return true;
                case "activeMipmapLimit": _value = new global::Lua.LuaValue(Instance.activeMipmapLimit); return true;
                case "calculatedMipmapLevel": _value = new global::Lua.LuaValue(Instance.calculatedMipmapLevel); return true;
                case "desiredMipmapLevel": _value = new global::Lua.LuaValue(Instance.desiredMipmapLevel); return true;
                case "format": _value = new global::Lua.LuaValue((global::System.Int64)Instance.format); return true;
                case "ignoreMipmapLimit": _value = new global::Lua.LuaValue(Instance.ignoreMipmapLimit); return true;
                case "isReadable": _value = new global::Lua.LuaValue(Instance.isReadable); return true;
                case "loadedMipmapLevel": _value = new global::Lua.LuaValue(Instance.loadedMipmapLevel); return true;
                case "loadingMipmapLevel": _value = new global::Lua.LuaValue(Instance.loadingMipmapLevel); return true;
                case "minimumMipmapLevel": _value = new global::Lua.LuaValue(Instance.minimumMipmapLevel); return true;
                case "mipmapLimitGroup": _value = new global::Lua.LuaValue(Instance.mipmapLimitGroup); return true;
                case "requestedMipmapLevel": _value = new global::Lua.LuaValue(Instance.requestedMipmapLevel); return true;
                case "streamingMipmaps": _value = new global::Lua.LuaValue(Instance.streamingMipmaps); return true;
                case "streamingMipmapsPriority": _value = new global::Lua.LuaValue(Instance.streamingMipmapsPriority); return true;
                case "vtOnly": _value = new global::Lua.LuaValue(Instance.vtOnly); return true;
                default: return base.TryGetLuaValue(_key, out _value, _factory);
            }
        }
        public override global::System.Boolean TrySetLuaValue(global::System.Int32 _key, global::Lua.LuaValue _value)
        {
            return base.TrySetLuaValue(_key, _value);
        }
        public override global::System.Boolean TrySetLuaValue(global::System.String _key, global::Lua.LuaValue _value)
        {
            switch (_key)
            {
                case "ignoreMipmapLimit": Instance.ignoreMipmapLimit = _value.Read<global::System.Boolean>();  return true;
                case "minimumMipmapLevel": Instance.minimumMipmapLevel = _value.Read<global::System.Int32>();  return true;
                case "requestedMipmapLevel": Instance.requestedMipmapLevel = _value.Read<global::System.Int32>();  return true;
                default: return base.TrySetLuaValue(_key, _value);
            }
        }
    }
    public sealed class LuaTexture2DType : global::Luny.ILuaStatic
    {
        public static global::Lua.LuaValue Bind() => new LuaTexture2DType();
        private LuaTexture2DType() {}
        public static implicit operator global::Lua.LuaValue(LuaTexture2DType value) => new(value);
        public global::System.Type BindType => typeof(global::UnityEngine.Texture2D);
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
            metatable[global::Lua.Runtime.Metamethods.Call] = _LuaTexture2D_new;
            return metatable;
        }
        public override global::System.String ToString() => BindType.FullName;
#if UNITY_EDITOR
        [global::UnityEngine.RuntimeInitializeOnLoadMethod(global::UnityEngine.RuntimeInitializeLoadType.SubsystemRegistration)]
        private static void ResetStaticFields() => s_Metatable = null;
#endif

        private static readonly global::Lua.LuaFunction _LuaTexture2D_new = new global::Lua.LuaFunction(".ctor", (_context, _) =>
        {
            global::Lua.LuaValue _lastArg = default;
            global::System.Int32 _lastArgPos = default;
            global::System.Type _expectedType = default;
            var _argCount = _context.ArgumentCount;
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
                        var _ret0 = new global::UnityEngine.Texture2D(width, height);
                        var _factory = _context.GetObjectFactory();
                        var _lret0 = _factory.Bind(_ret0);
                        var _retCount = _context.Return(_lret0);
                        return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                    }
                    var _arg2 = _lastArg = _argCount > 3 ? _context.GetArgument(3) : global::Lua.LuaValue.Nil;
                    _lastArgPos = 2; _expectedType = typeof(global::UnityEngine.Experimental.Rendering.GraphicsFormat);
                    if (_arg2.TryRead<global::UnityEngine.Experimental.Rendering.GraphicsFormat>(out var _p2_UnityEngine_Experimental_Rendering_GraphicsFormat))
                    {
                        var _arg3 = _lastArg = _argCount > 4 ? _context.GetArgument(4) : global::Lua.LuaValue.Nil;
                        _lastArgPos = 3; _expectedType = typeof(global::UnityEngine.Experimental.Rendering.TextureCreationFlags);
                        if (_arg3.TryRead<global::UnityEngine.Experimental.Rendering.TextureCreationFlags>(out var _p3_UnityEngine_Experimental_Rendering_TextureCreationFlags))
                        {
                            if (_argCount == 5)
                            {
                                var width = _p0_System_Int32;
                                var height = _p1_System_Int32;
                                var format = _p2_UnityEngine_Experimental_Rendering_GraphicsFormat;
                                var flags = _p3_UnityEngine_Experimental_Rendering_TextureCreationFlags;
                                var _ret0 = new global::UnityEngine.Texture2D(width, height, format, flags);
                                var _factory = _context.GetObjectFactory();
                                var _lret0 = _factory.Bind(_ret0);
                                var _retCount = _context.Return(_lret0);
                                return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                            }
                        }
                        _lastArgPos = 3; _expectedType = typeof(global::System.Int32);
                        if (_arg3.TryRead<global::System.Int32>(out var _p3_System_Int32))
                        {
                            var _arg4 = _lastArg = _argCount > 5 ? _context.GetArgument(5) : global::Lua.LuaValue.Nil;
                            _lastArgPos = 4; _expectedType = typeof(global::UnityEngine.Experimental.Rendering.TextureCreationFlags);
                            if (_arg4.TryRead<global::UnityEngine.Experimental.Rendering.TextureCreationFlags>(out var _p4_UnityEngine_Experimental_Rendering_TextureCreationFlags))
                            {
                                if (_argCount == 6)
                                {
                                    var width = _p0_System_Int32;
                                    var height = _p1_System_Int32;
                                    var format = _p2_UnityEngine_Experimental_Rendering_GraphicsFormat;
                                    var mipCount = _p3_System_Int32;
                                    var flags = _p4_UnityEngine_Experimental_Rendering_TextureCreationFlags;
                                    var _ret0 = new global::UnityEngine.Texture2D(width, height, format, mipCount, flags);
                                    var _factory = _context.GetObjectFactory();
                                    var _lret0 = _factory.Bind(_ret0);
                                    var _retCount = _context.Return(_lret0);
                                    return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                                }
                                var _arg5 = _lastArg = _argCount > 6 ? _context.GetArgument(6) : global::Lua.LuaValue.Nil;
                                _lastArgPos = 5; _expectedType = typeof(global::Luny.UnityEngine.LuaMipmapLimitDescriptor);
                                if (_arg5.TryRead<global::Luny.UnityEngine.LuaMipmapLimitDescriptor>(out var _p5_UnityEngine_MipmapLimitDescriptor))
                                {
                                    if (_argCount == 7)
                                    {
                                        var width = _p0_System_Int32;
                                        var height = _p1_System_Int32;
                                        var format = _p2_UnityEngine_Experimental_Rendering_GraphicsFormat;
                                        var mipCount = _p3_System_Int32;
                                        var flags = _p4_UnityEngine_Experimental_Rendering_TextureCreationFlags;
                                        var mipmapLimitDescriptor = _p5_UnityEngine_MipmapLimitDescriptor.Value;
                                        var _ret0 = new global::UnityEngine.Texture2D(width, height, format, mipCount, flags, mipmapLimitDescriptor);
                                        var _factory = _context.GetObjectFactory();
                                        var _lret0 = _factory.Bind(_ret0);
                                        var _retCount = _context.Return(_lret0);
                                        return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                                    }
                                }
                            }
                        }
                    }
                    _lastArgPos = 2; _expectedType = typeof(global::UnityEngine.TextureFormat);
                    if (_arg2.TryRead<global::UnityEngine.TextureFormat>(out var _p2_UnityEngine_TextureFormat))
                    {
                        var _arg3 = _lastArg = _argCount > 4 ? _context.GetArgument(4) : global::Lua.LuaValue.Nil;
                        _lastArgPos = 3; _expectedType = typeof(global::System.Boolean);
                        if (_arg3.TryRead<global::System.Boolean>(out var _p3_System_Boolean))
                        {
                            if (_argCount == 5)
                            {
                                var width = _p0_System_Int32;
                                var height = _p1_System_Int32;
                                var textureFormat = _p2_UnityEngine_TextureFormat;
                                var mipChain = _p3_System_Boolean;
                                var _ret0 = new global::UnityEngine.Texture2D(width, height, textureFormat, mipChain);
                                var _factory = _context.GetObjectFactory();
                                var _lret0 = _factory.Bind(_ret0);
                                var _retCount = _context.Return(_lret0);
                                return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                            }
                            var _arg4 = _lastArg = _argCount > 5 ? _context.GetArgument(5) : global::Lua.LuaValue.Nil;
                            _lastArgPos = 4; _expectedType = typeof(global::System.Boolean);
                            if (_arg4.TryRead<global::System.Boolean>(out var _p4_System_Boolean))
                            {
                                if (_argCount == 6)
                                {
                                    var width = _p0_System_Int32;
                                    var height = _p1_System_Int32;
                                    var textureFormat = _p2_UnityEngine_TextureFormat;
                                    var mipChain = _p3_System_Boolean;
                                    var linear = _p4_System_Boolean;
                                    var _ret0 = new global::UnityEngine.Texture2D(width, height, textureFormat, mipChain, linear);
                                    var _factory = _context.GetObjectFactory();
                                    var _lret0 = _factory.Bind(_ret0);
                                    var _retCount = _context.Return(_lret0);
                                    return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                                }
                                var _arg5 = _lastArg = _argCount > 6 ? _context.GetArgument(6) : global::Lua.LuaValue.Nil;
                                _lastArgPos = 5; _expectedType = typeof(global::System.Boolean);
                                if (_arg5.TryRead<global::System.Boolean>(out var _p5_System_Boolean))
                                {
                                    if (_argCount == 7)
                                    {
                                        var width = _p0_System_Int32;
                                        var height = _p1_System_Int32;
                                        var textureFormat = _p2_UnityEngine_TextureFormat;
                                        var mipChain = _p3_System_Boolean;
                                        var linear = _p4_System_Boolean;
                                        var createUninitialized = _p5_System_Boolean;
                                        var _ret0 = new global::UnityEngine.Texture2D(width, height, textureFormat, mipChain, linear, createUninitialized);
                                        var _factory = _context.GetObjectFactory();
                                        var _lret0 = _factory.Bind(_ret0);
                                        var _retCount = _context.Return(_lret0);
                                        return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                                    }
                                }
                            }
                        }
                        _lastArgPos = 3; _expectedType = typeof(global::System.Int32);
                        if (_arg3.TryRead<global::System.Int32>(out var _p3_System_Int32))
                        {
                            var _arg4 = _lastArg = _argCount > 5 ? _context.GetArgument(5) : global::Lua.LuaValue.Nil;
                            _lastArgPos = 4; _expectedType = typeof(global::System.Boolean);
                            if (_arg4.TryRead<global::System.Boolean>(out var _p4_System_Boolean))
                            {
                                if (_argCount == 6)
                                {
                                    var width = _p0_System_Int32;
                                    var height = _p1_System_Int32;
                                    var textureFormat = _p2_UnityEngine_TextureFormat;
                                    var mipCount = _p3_System_Int32;
                                    var linear = _p4_System_Boolean;
                                    var _ret0 = new global::UnityEngine.Texture2D(width, height, textureFormat, mipCount, linear);
                                    var _factory = _context.GetObjectFactory();
                                    var _lret0 = _factory.Bind(_ret0);
                                    var _retCount = _context.Return(_lret0);
                                    return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                                }
                                var _arg5 = _lastArg = _argCount > 6 ? _context.GetArgument(6) : global::Lua.LuaValue.Nil;
                                _lastArgPos = 5; _expectedType = typeof(global::System.Boolean);
                                if (_arg5.TryRead<global::System.Boolean>(out var _p5_System_Boolean))
                                {
                                    if (_argCount == 7)
                                    {
                                        var width = _p0_System_Int32;
                                        var height = _p1_System_Int32;
                                        var textureFormat = _p2_UnityEngine_TextureFormat;
                                        var mipCount = _p3_System_Int32;
                                        var linear = _p4_System_Boolean;
                                        var createUninitialized = _p5_System_Boolean;
                                        var _ret0 = new global::UnityEngine.Texture2D(width, height, textureFormat, mipCount, linear, createUninitialized);
                                        var _factory = _context.GetObjectFactory();
                                        var _lret0 = _factory.Bind(_ret0);
                                        var _retCount = _context.Return(_lret0);
                                        return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                                    }
                                    var _arg6 = _lastArg = _argCount > 7 ? _context.GetArgument(7) : global::Lua.LuaValue.Nil;
                                    _lastArgPos = 6; _expectedType = typeof(global::Luny.UnityEngine.LuaMipmapLimitDescriptor);
                                    if (_arg6.TryRead<global::Luny.UnityEngine.LuaMipmapLimitDescriptor>(out var _p6_UnityEngine_MipmapLimitDescriptor))
                                    {
                                        if (_argCount == 8)
                                        {
                                            var width = _p0_System_Int32;
                                            var height = _p1_System_Int32;
                                            var textureFormat = _p2_UnityEngine_TextureFormat;
                                            var mipCount = _p3_System_Int32;
                                            var linear = _p4_System_Boolean;
                                            var createUninitialized = _p5_System_Boolean;
                                            var mipmapLimitDescriptor = _p6_UnityEngine_MipmapLimitDescriptor.Value;
                                            var _ret0 = new global::UnityEngine.Texture2D(width, height, textureFormat, mipCount, linear, createUninitialized, mipmapLimitDescriptor);
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
                    _lastArgPos = 2; _expectedType = typeof(global::UnityEngine.Experimental.Rendering.DefaultFormat);
                    if (_arg2.TryRead<global::UnityEngine.Experimental.Rendering.DefaultFormat>(out var _p2_UnityEngine_Experimental_Rendering_DefaultFormat))
                    {
                        var _arg3 = _lastArg = _argCount > 4 ? _context.GetArgument(4) : global::Lua.LuaValue.Nil;
                        _lastArgPos = 3; _expectedType = typeof(global::UnityEngine.Experimental.Rendering.TextureCreationFlags);
                        if (_arg3.TryRead<global::UnityEngine.Experimental.Rendering.TextureCreationFlags>(out var _p3_UnityEngine_Experimental_Rendering_TextureCreationFlags))
                        {
                            if (_argCount == 5)
                            {
                                var width = _p0_System_Int32;
                                var height = _p1_System_Int32;
                                var format = _p2_UnityEngine_Experimental_Rendering_DefaultFormat;
                                var flags = _p3_UnityEngine_Experimental_Rendering_TextureCreationFlags;
                                var _ret0 = new global::UnityEngine.Texture2D(width, height, format, flags);
                                var _factory = _context.GetObjectFactory();
                                var _lret0 = _factory.Bind(_ret0);
                                var _retCount = _context.Return(_lret0);
                                return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                            }
                        }
                        _lastArgPos = 3; _expectedType = typeof(global::System.Int32);
                        if (_arg3.TryRead<global::System.Int32>(out var _p3_System_Int32))
                        {
                            var _arg4 = _lastArg = _argCount > 5 ? _context.GetArgument(5) : global::Lua.LuaValue.Nil;
                            _lastArgPos = 4; _expectedType = typeof(global::UnityEngine.Experimental.Rendering.TextureCreationFlags);
                            if (_arg4.TryRead<global::UnityEngine.Experimental.Rendering.TextureCreationFlags>(out var _p4_UnityEngine_Experimental_Rendering_TextureCreationFlags))
                            {
                                if (_argCount == 6)
                                {
                                    var width = _p0_System_Int32;
                                    var height = _p1_System_Int32;
                                    var format = _p2_UnityEngine_Experimental_Rendering_DefaultFormat;
                                    var mipCount = _p3_System_Int32;
                                    var flags = _p4_UnityEngine_Experimental_Rendering_TextureCreationFlags;
                                    var _ret0 = new global::UnityEngine.Texture2D(width, height, format, mipCount, flags);
                                    var _factory = _context.GetObjectFactory();
                                    var _lret0 = _factory.Bind(_ret0);
                                    var _retCount = _context.Return(_lret0);
                                    return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                                }
                                var _arg5 = _lastArg = _argCount > 6 ? _context.GetArgument(6) : global::Lua.LuaValue.Nil;
                                _lastArgPos = 5; _expectedType = typeof(global::Luny.UnityEngine.LuaMipmapLimitDescriptor);
                                if (_arg5.TryRead<global::Luny.UnityEngine.LuaMipmapLimitDescriptor>(out var _p5_UnityEngine_MipmapLimitDescriptor))
                                {
                                    if (_argCount == 7)
                                    {
                                        var width = _p0_System_Int32;
                                        var height = _p1_System_Int32;
                                        var format = _p2_UnityEngine_Experimental_Rendering_DefaultFormat;
                                        var mipCount = _p3_System_Int32;
                                        var flags = _p4_UnityEngine_Experimental_Rendering_TextureCreationFlags;
                                        var mipmapLimitDescriptor = _p5_UnityEngine_MipmapLimitDescriptor.Value;
                                        var _ret0 = new global::UnityEngine.Texture2D(width, height, format, mipCount, flags, mipmapLimitDescriptor);
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
            throw new global::Lua.LuaRuntimeException(_context.Thread, $"{".ctor"}: invalid argument #{_lastArgPos}: {_lastArg} ({_lastArg.Type}), expected: {_expectedType.FullName}", 2);
        });
        private static readonly global::Lua.LuaFunction __index = new(global::Lua.Runtime.Metamethods.Index, (_context, _) =>
        {
            var _this = _context.GetArgument<LuaTexture2DType>(0);
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
            var _this = _context.GetArgument<LuaTexture2DType>(0);
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
                case "blackTexture": _value = _factory.Bind(global::UnityEngine.Texture2D.blackTexture); return true;
                case "grayTexture": _value = _factory.Bind(global::UnityEngine.Texture2D.grayTexture); return true;
                case "linearGrayTexture": _value = _factory.Bind(global::UnityEngine.Texture2D.linearGrayTexture); return true;
                case "normalTexture": _value = _factory.Bind(global::UnityEngine.Texture2D.normalTexture); return true;
                case "redTexture": _value = _factory.Bind(global::UnityEngine.Texture2D.redTexture); return true;
                case "whiteTexture": _value = _factory.Bind(global::UnityEngine.Texture2D.whiteTexture); return true;
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
