
// --------------------------------------------------------------
// GENERATED FILE ----> DO NOT EDIT <---- CHANGES WILL BE LOST !!
// --------------------------------------------------------------

#if UNITY_6000_1_OR_NEWER && !(UNITY_6000_2_OR_NEWER)
#pragma warning disable 0109, 0162, 0168, 0219
using Luny;

namespace Luny.UnityEngine
{
    public sealed class LuaTexture2DArray : LuaTexture, global::Luny.ILuaObject<global::UnityEngine.Texture2DArray>
    {
        public new static global::Lua.LuaValue Bind(global::UnityEngine.Texture2DArray instance) => new LuaTexture2DArray(instance);
        public new static global::Lua.LuaValue Bind(global::System.Object instance) => Bind((global::UnityEngine.Texture2DArray)instance);
        public new static global::Lua.LuaValue Bind(global::System.Collections.Generic.IList<global::UnityEngine.Texture2DArray> instances) =>
            new global::Luny.LuaList<global::UnityEngine.Texture2DArray>(instances);
        public new static global::Lua.LuaValue Bind(global::System.Collections.Generic.IList<global::System.Object> instances) =>
            new global::Luny.LuaList<global::UnityEngine.Texture2DArray>(instances);
        private LuaTexture2DArray(global::UnityEngine.Texture2DArray instance) : base(instance) {}
        public static implicit operator global::Lua.LuaValue(LuaTexture2DArray value) => new(value);
        public new global::UnityEngine.Texture2DArray Instance => (global::UnityEngine.Texture2DArray)m_Instance;
        public new global::System.Type BindType => typeof(global::UnityEngine.Texture2DArray);
        private static global::Lua.LuaTable s_Metatable;
        public new global::Lua.LuaTable Metatable
        {
            get => s_Metatable ??= global::Luny.LuaMetatable.Create(__index, __newindex);
            set => throw new global::System.NotSupportedException("LuaObject metatables cannot be modified");
        }
        global::System.Span<global::Lua.LuaValue> global::Lua.ILuaUserData.UserValues => default;
        public override global::System.String ToString() => m_Instance != null ? Instance.ToString() : "{GetType().Name}(null)";
#if UNITY_EDITOR
        [global::UnityEngine.RuntimeInitializeOnLoadMethod(global::UnityEngine.RuntimeInitializeLoadType.SubsystemRegistration)]
        private static void ResetStaticFields() => s_Metatable = null;
#endif

        private static readonly global::Lua.LuaFunction _LuaTexture2DArray_Apply = new global::Lua.LuaFunction("Apply", (_context, _) =>
        {
            global::Lua.LuaValue _lastArg = default;
            global::System.Int32 _lastArgPos = default;
            global::System.Type _expectedType = default;
            var _argCount = _context.ArgumentCount;
            var _this = _context.GetArgument<LuaTexture2DArray>(0);
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
        private static readonly global::Lua.LuaFunction _LuaTexture2DArray_CopyPixels = new global::Lua.LuaFunction("CopyPixels", (_context, _) =>
        {
            global::Lua.LuaValue _lastArg = default;
            global::System.Int32 _lastArgPos = default;
            global::System.Type _expectedType = default;
            var _argCount = _context.ArgumentCount;
            var _this = _context.GetArgument<LuaTexture2DArray>(0);
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
                            var _arg4 = _lastArg = _argCount > 5 ? _context.GetArgument(5) : global::Lua.LuaValue.Nil;
                            _lastArgPos = 4; _expectedType = typeof(global::System.Int32);
                            if (_arg4.TryRead<global::System.Int32>(out var _p4_System_Int32))
                            {
                                if (_argCount == 6)
                                {
                                    var src = _p0_UnityEngine_Texture.Instance;
                                    var srcElement = _p1_System_Int32;
                                    var srcMip = _p2_System_Int32;
                                    var dstElement = _p3_System_Int32;
                                    var dstMip = _p4_System_Int32;
                                    _this.Instance.CopyPixels(src, srcElement, srcMip, dstElement, dstMip);
                                    var _retCount = _context.Return();
                                    return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                                }
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
                                                    var _arg10 = _lastArg = _argCount > 11 ? _context.GetArgument(11) : global::Lua.LuaValue.Nil;
                                                    _lastArgPos = 10; _expectedType = typeof(global::System.Int32);
                                                    if (_arg10.TryRead<global::System.Int32>(out var _p10_System_Int32))
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
                                                            var dstElement = _p7_System_Int32;
                                                            var dstMip = _p8_System_Int32;
                                                            var dstX = _p9_System_Int32;
                                                            var dstY = _p10_System_Int32;
                                                            _this.Instance.CopyPixels(src, srcElement, srcMip, srcX, srcY, srcWidth, srcHeight, dstElement, dstMip, dstX, dstY);
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
            throw new global::Lua.LuaRuntimeException(_context.Thread, $"{"CopyPixels"}: invalid argument #{_lastArgPos}: {_lastArg} ({_lastArg.Type}), expected: {_expectedType.FullName}", 2);
        });
        private static readonly global::Lua.LuaFunction _LuaTexture2DArray_GetPixels = new global::Lua.LuaFunction("GetPixels", (_context, _) =>
        {
            global::Lua.LuaValue _lastArg = default;
            global::System.Int32 _lastArgPos = default;
            global::System.Type _expectedType = default;
            var _argCount = _context.ArgumentCount;
            var _this = _context.GetArgument<LuaTexture2DArray>(0);
            var _arg0 = _lastArg = _argCount > 1 ? _context.GetArgument(1) : global::Lua.LuaValue.Nil;
            _lastArgPos = 0; _expectedType = typeof(global::System.Int32);
            if (_arg0.TryRead<global::System.Int32>(out var _p0_System_Int32))
            {
                if (_argCount == 2)
                {
                    var arrayElement = _p0_System_Int32;
                    var _ret0 = _this.Instance.GetPixels(arrayElement);
                    var _factory = _context.GetObjectFactory();
                    var _lret0 = _factory.Bind(_ret0);
                    var _retCount = _context.Return(_lret0);
                    return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                }
                var _arg1 = _lastArg = _argCount > 2 ? _context.GetArgument(2) : global::Lua.LuaValue.Nil;
                _lastArgPos = 1; _expectedType = typeof(global::System.Int32);
                if (_arg1.TryRead<global::System.Int32>(out var _p1_System_Int32))
                {
                    if (_argCount == 3)
                    {
                        var arrayElement = _p0_System_Int32;
                        var miplevel = _p1_System_Int32;
                        var _ret0 = _this.Instance.GetPixels(arrayElement, miplevel);
                        var _factory = _context.GetObjectFactory();
                        var _lret0 = _factory.Bind(_ret0);
                        var _retCount = _context.Return(_lret0);
                        return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                    }
                }
            }
            throw new global::Lua.LuaRuntimeException(_context.Thread, $"{"GetPixels"}: invalid argument #{_lastArgPos}: {_lastArg} ({_lastArg.Type}), expected: {_expectedType.FullName}", 2);
        });
        private static readonly global::Lua.LuaFunction _LuaTexture2DArray_GetPixels32 = new global::Lua.LuaFunction("GetPixels32", (_context, _) =>
        {
            global::Lua.LuaValue _lastArg = default;
            global::System.Int32 _lastArgPos = default;
            global::System.Type _expectedType = default;
            var _argCount = _context.ArgumentCount;
            var _this = _context.GetArgument<LuaTexture2DArray>(0);
            var _arg0 = _lastArg = _argCount > 1 ? _context.GetArgument(1) : global::Lua.LuaValue.Nil;
            _lastArgPos = 0; _expectedType = typeof(global::System.Int32);
            if (_arg0.TryRead<global::System.Int32>(out var _p0_System_Int32))
            {
                if (_argCount == 2)
                {
                    var arrayElement = _p0_System_Int32;
                    var _ret0 = _this.Instance.GetPixels32(arrayElement);
                    var _factory = _context.GetObjectFactory();
                    var _lret0 = _factory.Bind(_ret0);
                    var _retCount = _context.Return(_lret0);
                    return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                }
                var _arg1 = _lastArg = _argCount > 2 ? _context.GetArgument(2) : global::Lua.LuaValue.Nil;
                _lastArgPos = 1; _expectedType = typeof(global::System.Int32);
                if (_arg1.TryRead<global::System.Int32>(out var _p1_System_Int32))
                {
                    if (_argCount == 3)
                    {
                        var arrayElement = _p0_System_Int32;
                        var miplevel = _p1_System_Int32;
                        var _ret0 = _this.Instance.GetPixels32(arrayElement, miplevel);
                        var _factory = _context.GetObjectFactory();
                        var _lret0 = _factory.Bind(_ret0);
                        var _retCount = _context.Return(_lret0);
                        return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                    }
                }
            }
            throw new global::Lua.LuaRuntimeException(_context.Thread, $"{"GetPixels32"}: invalid argument #{_lastArgPos}: {_lastArg} ({_lastArg.Type}), expected: {_expectedType.FullName}", 2);
        });
        private static readonly global::Lua.LuaFunction _LuaTexture2DArray_SetPixels = new global::Lua.LuaFunction("SetPixels", (_context, _) =>
        {
            global::Lua.LuaValue _lastArg = default;
            global::System.Int32 _lastArgPos = default;
            global::System.Type _expectedType = default;
            var _argCount = _context.ArgumentCount;
            var _this = _context.GetArgument<LuaTexture2DArray>(0);
            var _arg0 = _lastArg = _argCount > 1 ? _context.GetArgument(1) : global::Lua.LuaValue.Nil;
            _lastArgPos = 0; _expectedType = typeof(global::UnityEngine.Color[]);
            if (_arg0.TryReadArray<global::UnityEngine.Color>(out var _p0_UnityEngine_ColorArray))
            {
                var _arg1 = _lastArg = _argCount > 2 ? _context.GetArgument(2) : global::Lua.LuaValue.Nil;
                _lastArgPos = 1; _expectedType = typeof(global::System.Int32);
                if (_arg1.TryRead<global::System.Int32>(out var _p1_System_Int32))
                {
                    if (_argCount == 3)
                    {
                        var colors = _p0_UnityEngine_ColorArray;
                        var arrayElement = _p1_System_Int32;
                        _this.Instance.SetPixels(colors, arrayElement);
                        var _retCount = _context.Return();
                        return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                    }
                    var _arg2 = _lastArg = _argCount > 3 ? _context.GetArgument(3) : global::Lua.LuaValue.Nil;
                    _lastArgPos = 2; _expectedType = typeof(global::System.Int32);
                    if (_arg2.TryRead<global::System.Int32>(out var _p2_System_Int32))
                    {
                        if (_argCount == 4)
                        {
                            var colors = _p0_UnityEngine_ColorArray;
                            var arrayElement = _p1_System_Int32;
                            var miplevel = _p2_System_Int32;
                            _this.Instance.SetPixels(colors, arrayElement, miplevel);
                            var _retCount = _context.Return();
                            return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                        }
                    }
                }
            }
            throw new global::Lua.LuaRuntimeException(_context.Thread, $"{"SetPixels"}: invalid argument #{_lastArgPos}: {_lastArg} ({_lastArg.Type}), expected: {_expectedType.FullName}", 2);
        });
        private static readonly global::Lua.LuaFunction _LuaTexture2DArray_SetPixels32 = new global::Lua.LuaFunction("SetPixels32", (_context, _) =>
        {
            global::Lua.LuaValue _lastArg = default;
            global::System.Int32 _lastArgPos = default;
            global::System.Type _expectedType = default;
            var _argCount = _context.ArgumentCount;
            var _this = _context.GetArgument<LuaTexture2DArray>(0);
            var _arg0 = _lastArg = _argCount > 1 ? _context.GetArgument(1) : global::Lua.LuaValue.Nil;
            _lastArgPos = 0; _expectedType = typeof(global::UnityEngine.Color32[]);
            if (_arg0.TryReadArray<global::UnityEngine.Color32>(out var _p0_UnityEngine_Color32Array))
            {
                var _arg1 = _lastArg = _argCount > 2 ? _context.GetArgument(2) : global::Lua.LuaValue.Nil;
                _lastArgPos = 1; _expectedType = typeof(global::System.Int32);
                if (_arg1.TryRead<global::System.Int32>(out var _p1_System_Int32))
                {
                    if (_argCount == 3)
                    {
                        var colors = _p0_UnityEngine_Color32Array;
                        var arrayElement = _p1_System_Int32;
                        _this.Instance.SetPixels32(colors, arrayElement);
                        var _retCount = _context.Return();
                        return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                    }
                    var _arg2 = _lastArg = _argCount > 3 ? _context.GetArgument(3) : global::Lua.LuaValue.Nil;
                    _lastArgPos = 2; _expectedType = typeof(global::System.Int32);
                    if (_arg2.TryRead<global::System.Int32>(out var _p2_System_Int32))
                    {
                        if (_argCount == 4)
                        {
                            var colors = _p0_UnityEngine_Color32Array;
                            var arrayElement = _p1_System_Int32;
                            var miplevel = _p2_System_Int32;
                            _this.Instance.SetPixels32(colors, arrayElement, miplevel);
                            var _retCount = _context.Return();
                            return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                        }
                    }
                }
            }
            throw new global::Lua.LuaRuntimeException(_context.Thread, $"{"SetPixels32"}: invalid argument #{_lastArgPos}: {_lastArg} ({_lastArg.Type}), expected: {_expectedType.FullName}", 2);
        });
        private static readonly global::Lua.LuaFunction __index = new(global::Lua.Runtime.Metamethods.Index, (_context, _) =>
        {
            var _this = _context.GetArgument<LuaTexture2DArray>(0);
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
            var _this = _context.GetArgument<LuaTexture2DArray>(0);
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
                case "Apply": _value = _LuaTexture2DArray_Apply; return true;
                case "CopyPixels": _value = _LuaTexture2DArray_CopyPixels; return true;
                case "GetPixels": _value = _LuaTexture2DArray_GetPixels; return true;
                case "GetPixels32": _value = _LuaTexture2DArray_GetPixels32; return true;
                case "SetPixels": _value = _LuaTexture2DArray_SetPixels; return true;
                case "SetPixels32": _value = _LuaTexture2DArray_SetPixels32; return true;
                case "activeMipmapLimit": _value = new global::Lua.LuaValue(Instance.activeMipmapLimit); return true;
                case "depth": _value = new global::Lua.LuaValue(Instance.depth); return true;
                case "format": _value = new global::Lua.LuaValue((global::System.Int64)Instance.format); return true;
                case "ignoreMipmapLimit": _value = new global::Lua.LuaValue(Instance.ignoreMipmapLimit); return true;
                case "isReadable": _value = new global::Lua.LuaValue(Instance.isReadable); return true;
                case "mipmapLimitGroup": _value = new global::Lua.LuaValue(Instance.mipmapLimitGroup); return true;
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
                default: return base.TrySetLuaValue(_key, _value);
            }
        }
    }
    public sealed class LuaTexture2DArrayType : global::Luny.ILuaStatic
    {
        public static global::Lua.LuaValue Bind() => new LuaTexture2DArrayType();
        private LuaTexture2DArrayType() {}
        public static implicit operator global::Lua.LuaValue(LuaTexture2DArrayType value) => new(value);
        public global::System.Type BindType => typeof(global::UnityEngine.Texture2DArray);
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

        private static readonly global::Lua.LuaFunction _LuaTexture2DArray_new = new global::Lua.LuaFunction(".ctor", (_context, _) =>
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
                _lastArgPos = 1; _expectedType = typeof(global::System.Int32);
                if (_arg1.TryRead<global::System.Int32>(out var _p1_System_Int32))
                {
                    var _arg2 = _lastArg = _argCount > 2 ? _context.GetArgument(2) : global::Lua.LuaValue.Nil;
                    _lastArgPos = 2; _expectedType = typeof(global::System.Int32);
                    if (_arg2.TryRead<global::System.Int32>(out var _p2_System_Int32))
                    {
                        var _arg3 = _lastArg = _argCount > 3 ? _context.GetArgument(3) : global::Lua.LuaValue.Nil;
                        _lastArgPos = 3; _expectedType = typeof(global::UnityEngine.Experimental.Rendering.GraphicsFormat);
                        if (_arg3.TryRead<global::UnityEngine.Experimental.Rendering.GraphicsFormat>(out var _p3_UnityEngine_Experimental_Rendering_GraphicsFormat))
                        {
                            var _arg4 = _lastArg = _argCount > 4 ? _context.GetArgument(4) : global::Lua.LuaValue.Nil;
                            _lastArgPos = 4; _expectedType = typeof(global::UnityEngine.Experimental.Rendering.TextureCreationFlags);
                            if (_arg4.TryRead<global::UnityEngine.Experimental.Rendering.TextureCreationFlags>(out var _p4_UnityEngine_Experimental_Rendering_TextureCreationFlags))
                            {
                                if (_argCount == 5)
                                {
                                    var width = _p0_System_Int32;
                                    var height = _p1_System_Int32;
                                    var depth = _p2_System_Int32;
                                    var format = _p3_UnityEngine_Experimental_Rendering_GraphicsFormat;
                                    var flags = _p4_UnityEngine_Experimental_Rendering_TextureCreationFlags;
                                    var _ret0 = new global::UnityEngine.Texture2DArray(width, height, depth, format, flags);
                                    var _factory = _context.GetObjectFactory();
                                    var _lret0 = _factory.Bind(_ret0);
                                    var _retCount = _context.Return(_lret0);
                                    return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                                }
                                var _arg5 = _lastArg = _argCount > 5 ? _context.GetArgument(5) : global::Lua.LuaValue.Nil;
                                _lastArgPos = 5; _expectedType = typeof(global::System.Int32);
                                if (_arg5.TryRead<global::System.Int32>(out var _p5_System_Int32))
                                {
                                    if (_argCount == 6)
                                    {
                                        var width = _p0_System_Int32;
                                        var height = _p1_System_Int32;
                                        var depth = _p2_System_Int32;
                                        var format = _p3_UnityEngine_Experimental_Rendering_GraphicsFormat;
                                        var flags = _p4_UnityEngine_Experimental_Rendering_TextureCreationFlags;
                                        var mipCount = _p5_System_Int32;
                                        var _ret0 = new global::UnityEngine.Texture2DArray(width, height, depth, format, flags, mipCount);
                                        var _factory = _context.GetObjectFactory();
                                        var _lret0 = _factory.Bind(_ret0);
                                        var _retCount = _context.Return(_lret0);
                                        return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                                    }
                                    var _arg6 = _lastArg = _argCount > 6 ? _context.GetArgument(6) : global::Lua.LuaValue.Nil;
                                    _lastArgPos = 6; _expectedType = typeof(global::Luny.UnityEngine.LuaMipmapLimitDescriptor);
                                    if (_arg6.TryRead<global::Luny.UnityEngine.LuaMipmapLimitDescriptor>(out var _p6_UnityEngine_MipmapLimitDescriptor))
                                    {
                                        if (_argCount == 7)
                                        {
                                            var width = _p0_System_Int32;
                                            var height = _p1_System_Int32;
                                            var depth = _p2_System_Int32;
                                            var format = _p3_UnityEngine_Experimental_Rendering_GraphicsFormat;
                                            var flags = _p4_UnityEngine_Experimental_Rendering_TextureCreationFlags;
                                            var mipCount = _p5_System_Int32;
                                            var mipmapLimitDescriptor = _p6_UnityEngine_MipmapLimitDescriptor.Value;
                                            var _ret0 = new global::UnityEngine.Texture2DArray(width, height, depth, format, flags, mipCount, mipmapLimitDescriptor);
                                            var _factory = _context.GetObjectFactory();
                                            var _lret0 = _factory.Bind(_ret0);
                                            var _retCount = _context.Return(_lret0);
                                            return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                                        }
                                    }
                                }
                            }
                        }
                        _lastArgPos = 3; _expectedType = typeof(global::UnityEngine.TextureFormat);
                        if (_arg3.TryRead<global::UnityEngine.TextureFormat>(out var _p3_UnityEngine_TextureFormat))
                        {
                            var _arg4 = _lastArg = _argCount > 4 ? _context.GetArgument(4) : global::Lua.LuaValue.Nil;
                            _lastArgPos = 4; _expectedType = typeof(global::System.Boolean);
                            if (_arg4.TryRead<global::System.Boolean>(out var _p4_System_Boolean))
                            {
                                if (_argCount == 5)
                                {
                                    var width = _p0_System_Int32;
                                    var height = _p1_System_Int32;
                                    var depth = _p2_System_Int32;
                                    var textureFormat = _p3_UnityEngine_TextureFormat;
                                    var mipChain = _p4_System_Boolean;
                                    var _ret0 = new global::UnityEngine.Texture2DArray(width, height, depth, textureFormat, mipChain);
                                    var _factory = _context.GetObjectFactory();
                                    var _lret0 = _factory.Bind(_ret0);
                                    var _retCount = _context.Return(_lret0);
                                    return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                                }
                                var _arg5 = _lastArg = _argCount > 5 ? _context.GetArgument(5) : global::Lua.LuaValue.Nil;
                                _lastArgPos = 5; _expectedType = typeof(global::System.Boolean);
                                if (_arg5.TryRead<global::System.Boolean>(out var _p5_System_Boolean))
                                {
                                    if (_argCount == 6)
                                    {
                                        var width = _p0_System_Int32;
                                        var height = _p1_System_Int32;
                                        var depth = _p2_System_Int32;
                                        var textureFormat = _p3_UnityEngine_TextureFormat;
                                        var mipChain = _p4_System_Boolean;
                                        var linear = _p5_System_Boolean;
                                        var _ret0 = new global::UnityEngine.Texture2DArray(width, height, depth, textureFormat, mipChain, linear);
                                        var _factory = _context.GetObjectFactory();
                                        var _lret0 = _factory.Bind(_ret0);
                                        var _retCount = _context.Return(_lret0);
                                        return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                                    }
                                    var _arg6 = _lastArg = _argCount > 6 ? _context.GetArgument(6) : global::Lua.LuaValue.Nil;
                                    _lastArgPos = 6; _expectedType = typeof(global::System.Boolean);
                                    if (_arg6.TryRead<global::System.Boolean>(out var _p6_System_Boolean))
                                    {
                                        if (_argCount == 7)
                                        {
                                            var width = _p0_System_Int32;
                                            var height = _p1_System_Int32;
                                            var depth = _p2_System_Int32;
                                            var textureFormat = _p3_UnityEngine_TextureFormat;
                                            var mipChain = _p4_System_Boolean;
                                            var linear = _p5_System_Boolean;
                                            var createUninitialized = _p6_System_Boolean;
                                            var _ret0 = new global::UnityEngine.Texture2DArray(width, height, depth, textureFormat, mipChain, linear, createUninitialized);
                                            var _factory = _context.GetObjectFactory();
                                            var _lret0 = _factory.Bind(_ret0);
                                            var _retCount = _context.Return(_lret0);
                                            return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                                        }
                                    }
                                }
                            }
                            _lastArgPos = 4; _expectedType = typeof(global::System.Int32);
                            if (_arg4.TryRead<global::System.Int32>(out var _p4_System_Int32))
                            {
                                var _arg5 = _lastArg = _argCount > 5 ? _context.GetArgument(5) : global::Lua.LuaValue.Nil;
                                _lastArgPos = 5; _expectedType = typeof(global::System.Boolean);
                                if (_arg5.TryRead<global::System.Boolean>(out var _p5_System_Boolean))
                                {
                                    if (_argCount == 6)
                                    {
                                        var width = _p0_System_Int32;
                                        var height = _p1_System_Int32;
                                        var depth = _p2_System_Int32;
                                        var textureFormat = _p3_UnityEngine_TextureFormat;
                                        var mipCount = _p4_System_Int32;
                                        var linear = _p5_System_Boolean;
                                        var _ret0 = new global::UnityEngine.Texture2DArray(width, height, depth, textureFormat, mipCount, linear);
                                        var _factory = _context.GetObjectFactory();
                                        var _lret0 = _factory.Bind(_ret0);
                                        var _retCount = _context.Return(_lret0);
                                        return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                                    }
                                    var _arg6 = _lastArg = _argCount > 6 ? _context.GetArgument(6) : global::Lua.LuaValue.Nil;
                                    _lastArgPos = 6; _expectedType = typeof(global::System.Boolean);
                                    if (_arg6.TryRead<global::System.Boolean>(out var _p6_System_Boolean))
                                    {
                                        if (_argCount == 7)
                                        {
                                            var width = _p0_System_Int32;
                                            var height = _p1_System_Int32;
                                            var depth = _p2_System_Int32;
                                            var textureFormat = _p3_UnityEngine_TextureFormat;
                                            var mipCount = _p4_System_Int32;
                                            var linear = _p5_System_Boolean;
                                            var createUninitialized = _p6_System_Boolean;
                                            var _ret0 = new global::UnityEngine.Texture2DArray(width, height, depth, textureFormat, mipCount, linear, createUninitialized);
                                            var _factory = _context.GetObjectFactory();
                                            var _lret0 = _factory.Bind(_ret0);
                                            var _retCount = _context.Return(_lret0);
                                            return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                                        }
                                        var _arg7 = _lastArg = _argCount > 7 ? _context.GetArgument(7) : global::Lua.LuaValue.Nil;
                                        _lastArgPos = 7; _expectedType = typeof(global::Luny.UnityEngine.LuaMipmapLimitDescriptor);
                                        if (_arg7.TryRead<global::Luny.UnityEngine.LuaMipmapLimitDescriptor>(out var _p7_UnityEngine_MipmapLimitDescriptor))
                                        {
                                            if (_argCount == 8)
                                            {
                                                var width = _p0_System_Int32;
                                                var height = _p1_System_Int32;
                                                var depth = _p2_System_Int32;
                                                var textureFormat = _p3_UnityEngine_TextureFormat;
                                                var mipCount = _p4_System_Int32;
                                                var linear = _p5_System_Boolean;
                                                var createUninitialized = _p6_System_Boolean;
                                                var mipmapLimitDescriptor = _p7_UnityEngine_MipmapLimitDescriptor.Value;
                                                var _ret0 = new global::UnityEngine.Texture2DArray(width, height, depth, textureFormat, mipCount, linear, createUninitialized, mipmapLimitDescriptor);
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
                        _lastArgPos = 3; _expectedType = typeof(global::UnityEngine.Experimental.Rendering.DefaultFormat);
                        if (_arg3.TryRead<global::UnityEngine.Experimental.Rendering.DefaultFormat>(out var _p3_UnityEngine_Experimental_Rendering_DefaultFormat))
                        {
                            var _arg4 = _lastArg = _argCount > 4 ? _context.GetArgument(4) : global::Lua.LuaValue.Nil;
                            _lastArgPos = 4; _expectedType = typeof(global::UnityEngine.Experimental.Rendering.TextureCreationFlags);
                            if (_arg4.TryRead<global::UnityEngine.Experimental.Rendering.TextureCreationFlags>(out var _p4_UnityEngine_Experimental_Rendering_TextureCreationFlags))
                            {
                                if (_argCount == 5)
                                {
                                    var width = _p0_System_Int32;
                                    var height = _p1_System_Int32;
                                    var depth = _p2_System_Int32;
                                    var format = _p3_UnityEngine_Experimental_Rendering_DefaultFormat;
                                    var flags = _p4_UnityEngine_Experimental_Rendering_TextureCreationFlags;
                                    var _ret0 = new global::UnityEngine.Texture2DArray(width, height, depth, format, flags);
                                    var _factory = _context.GetObjectFactory();
                                    var _lret0 = _factory.Bind(_ret0);
                                    var _retCount = _context.Return(_lret0);
                                    return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                                }
                                var _arg5 = _lastArg = _argCount > 5 ? _context.GetArgument(5) : global::Lua.LuaValue.Nil;
                                _lastArgPos = 5; _expectedType = typeof(global::System.Int32);
                                if (_arg5.TryRead<global::System.Int32>(out var _p5_System_Int32))
                                {
                                    if (_argCount == 6)
                                    {
                                        var width = _p0_System_Int32;
                                        var height = _p1_System_Int32;
                                        var depth = _p2_System_Int32;
                                        var format = _p3_UnityEngine_Experimental_Rendering_DefaultFormat;
                                        var flags = _p4_UnityEngine_Experimental_Rendering_TextureCreationFlags;
                                        var mipCount = _p5_System_Int32;
                                        var _ret0 = new global::UnityEngine.Texture2DArray(width, height, depth, format, flags, mipCount);
                                        var _factory = _context.GetObjectFactory();
                                        var _lret0 = _factory.Bind(_ret0);
                                        var _retCount = _context.Return(_lret0);
                                        return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                                    }
                                    var _arg6 = _lastArg = _argCount > 6 ? _context.GetArgument(6) : global::Lua.LuaValue.Nil;
                                    _lastArgPos = 6; _expectedType = typeof(global::Luny.UnityEngine.LuaMipmapLimitDescriptor);
                                    if (_arg6.TryRead<global::Luny.UnityEngine.LuaMipmapLimitDescriptor>(out var _p6_UnityEngine_MipmapLimitDescriptor))
                                    {
                                        if (_argCount == 7)
                                        {
                                            var width = _p0_System_Int32;
                                            var height = _p1_System_Int32;
                                            var depth = _p2_System_Int32;
                                            var format = _p3_UnityEngine_Experimental_Rendering_DefaultFormat;
                                            var flags = _p4_UnityEngine_Experimental_Rendering_TextureCreationFlags;
                                            var mipCount = _p5_System_Int32;
                                            var mipmapLimitDescriptor = _p6_UnityEngine_MipmapLimitDescriptor.Value;
                                            var _ret0 = new global::UnityEngine.Texture2DArray(width, height, depth, format, flags, mipCount, mipmapLimitDescriptor);
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
            throw new global::Lua.LuaRuntimeException(_context.Thread, $"{".ctor"}: invalid argument #{_lastArgPos}: {_lastArg} ({_lastArg.Type}), expected: {_expectedType.FullName}", 2);
        });
        private static readonly global::Lua.LuaFunction __index = new(global::Lua.Runtime.Metamethods.Index, (_context, _) =>
        {
            var _this = _context.GetArgument<LuaTexture2DArrayType>(0);
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
            var _this = _context.GetArgument<LuaTexture2DArrayType>(0);
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
                case "new": _value = _LuaTexture2DArray_new; return true;
                case "allSlices": _value = new global::Lua.LuaValue(global::UnityEngine.Texture2DArray.allSlices); return true;
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
