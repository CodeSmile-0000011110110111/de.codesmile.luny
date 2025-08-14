
// --------------------------------------------------------------
// GENERATED FILE ----> DO NOT EDIT <---- CHANGES WILL BE LOST !!
// --------------------------------------------------------------

#if UNITY_6000_0_OR_NEWER && !(UNITY_6000_1_OR_NEWER)
#pragma warning disable 0109, 0162, 0168, 0219
using Luny;

namespace Luny.UnityEditor
{
    public sealed class LuaAudioCurveRendering : global::Luny.ILuaObject<global::UnityEditor.AudioCurveRendering>
    {
        public new static global::Lua.LuaValue Bind(global::UnityEditor.AudioCurveRendering instance) => new LuaAudioCurveRendering(instance);
        public new static global::Lua.LuaValue Bind(global::System.Object instance) => Bind((global::UnityEditor.AudioCurveRendering)instance);
        public new static global::Lua.LuaValue Bind(global::System.Collections.Generic.IList<global::UnityEditor.AudioCurveRendering> instances) =>
            new global::Luny.LuaList<global::UnityEditor.AudioCurveRendering>(instances);
        public new static global::Lua.LuaValue Bind(global::System.Collections.Generic.IList<global::System.Object> instances) =>
            new global::Luny.LuaList<global::UnityEditor.AudioCurveRendering>(instances);
        private LuaAudioCurveRendering(global::UnityEditor.AudioCurveRendering instance) => m_Instance = instance;
        public static implicit operator global::Lua.LuaValue(LuaAudioCurveRendering value) => new(value);
        private global::UnityEditor.AudioCurveRendering m_Instance;
        public global::UnityEditor.AudioCurveRendering Instance => m_Instance;
        public new global::System.Type BindType => typeof(global::UnityEditor.AudioCurveRendering);
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
            var _this = _context.GetArgument<LuaAudioCurveRendering>(0);
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
            var _this = _context.GetArgument<LuaAudioCurveRendering>(0);
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
    public sealed class LuaAudioCurveRenderingType : global::Luny.ILuaStatic
    {
        public static global::Lua.LuaValue Bind() => new LuaAudioCurveRenderingType();
        private LuaAudioCurveRenderingType() {}
        public static implicit operator global::Lua.LuaValue(LuaAudioCurveRenderingType value) => new(value);
        public global::System.Type BindType => typeof(global::UnityEditor.AudioCurveRendering);
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
            metatable[global::Lua.Runtime.Metamethods.Call] = _LuaAudioCurveRendering_new;
            return metatable;
        }
        public override global::System.String ToString() => BindType.FullName;
#if UNITY_EDITOR
        [global::UnityEngine.RuntimeInitializeOnLoadMethod(global::UnityEngine.RuntimeInitializeLoadType.SubsystemRegistration)]
        private static void ResetStaticFields() => s_Metatable = null;
#endif

        private static readonly global::Lua.LuaFunction _LuaAudioCurveRendering_new = new global::Lua.LuaFunction(".ctor", (_context, _) =>
        {
            global::Lua.LuaValue _lastArg = default;
            global::System.Int32 _lastArgPos = default;
            global::System.Type _expectedType = default;
            var _argCount = _context.ArgumentCount;
            if (_argCount == 1)
            {
                var _ret0 = new global::UnityEditor.AudioCurveRendering();
                var _factory = _context.GetObjectFactory();
                var _lret0 = _factory.Bind(_ret0);
                var _retCount = _context.Return(_lret0);
                return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
            }
            throw new global::Lua.LuaRuntimeException(_context.Thread, $"{".ctor"}: invalid argument #{_lastArgPos}: {_lastArg} ({_lastArg.Type}), expected: {_expectedType.FullName}", 2);
        });
        private static readonly global::Lua.LuaFunction _LuaAudioCurveRendering_BeginCurveFrame = new global::Lua.LuaFunction("BeginCurveFrame", (_context, _) =>
        {
            global::Lua.LuaValue _lastArg = default;
            global::System.Int32 _lastArgPos = default;
            global::System.Type _expectedType = default;
            var _argCount = _context.ArgumentCount;
            var _arg0 = _lastArg = _argCount > 0 ? _context.GetArgument(0) : global::Lua.LuaValue.Nil;
            _lastArgPos = 0; _expectedType = typeof(global::UnityEngine.Rect);
            if (_arg0.TryRead<global::UnityEngine.Rect>(out var _p0_UnityEngine_Rect))
            {
                if (_argCount == 1)
                {
                    var r = _p0_UnityEngine_Rect;
                    var _ret0 = global::UnityEditor.AudioCurveRendering.BeginCurveFrame(r);
                    var _factory = _context.GetObjectFactory();
                    var _lret0 = _factory.Bind(_ret0);
                    var _retCount = _context.Return(_lret0);
                    return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                }
            }
            throw new global::Lua.LuaRuntimeException(_context.Thread, $"{"BeginCurveFrame"}: invalid argument #{_lastArgPos}: {_lastArg} ({_lastArg.Type}), expected: {_expectedType.FullName}", 2);
        });
        private static readonly global::Lua.LuaFunction _LuaAudioCurveRendering_DrawCurve = new global::Lua.LuaFunction("DrawCurve", (_context, _) =>
        {
            global::Lua.LuaValue _lastArg = default;
            global::System.Int32 _lastArgPos = default;
            global::System.Type _expectedType = default;
            var _argCount = _context.ArgumentCount;
            var _arg0 = _lastArg = _argCount > 0 ? _context.GetArgument(0) : global::Lua.LuaValue.Nil;
            _lastArgPos = 0; _expectedType = typeof(global::UnityEngine.Rect);
            if (_arg0.TryRead<global::UnityEngine.Rect>(out var _p0_UnityEngine_Rect))
            {
                var _arg1 = _lastArg = _argCount > 1 ? _context.GetArgument(1) : global::Lua.LuaValue.Nil;
                _lastArgPos = 1; _expectedType = typeof(global::UnityEditor.AudioCurveRendering.AudioCurveEvaluator);
                if (_arg1.TryRead<global::UnityEditor.AudioCurveRendering.AudioCurveEvaluator>(out var _p1_UnityEditor_AudioCurveRendering_AudioCurveEvaluator))
                {
                    var _arg2 = _lastArg = _argCount > 2 ? _context.GetArgument(2) : global::Lua.LuaValue.Nil;
                    _lastArgPos = 2; _expectedType = typeof(global::UnityEngine.Color);
                    if (_arg2.TryRead<global::UnityEngine.Color>(out var _p2_UnityEngine_Color))
                    {
                        if (_argCount == 3)
                        {
                            var r = _p0_UnityEngine_Rect;
                            var eval = _p1_UnityEditor_AudioCurveRendering_AudioCurveEvaluator;
                            var curveColor = _p2_UnityEngine_Color;
                            global::UnityEditor.AudioCurveRendering.DrawCurve(r, eval, curveColor);
                            var _retCount = _context.Return();
                            return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                        }
                    }
                }
            }
            throw new global::Lua.LuaRuntimeException(_context.Thread, $"{"DrawCurve"}: invalid argument #{_lastArgPos}: {_lastArg} ({_lastArg.Type}), expected: {_expectedType.FullName}", 2);
        });
        private static readonly global::Lua.LuaFunction _LuaAudioCurveRendering_DrawCurveBackground = new global::Lua.LuaFunction("DrawCurveBackground", (_context, _) =>
        {
            global::Lua.LuaValue _lastArg = default;
            global::System.Int32 _lastArgPos = default;
            global::System.Type _expectedType = default;
            var _argCount = _context.ArgumentCount;
            var _arg0 = _lastArg = _argCount > 0 ? _context.GetArgument(0) : global::Lua.LuaValue.Nil;
            _lastArgPos = 0; _expectedType = typeof(global::UnityEngine.Rect);
            if (_arg0.TryRead<global::UnityEngine.Rect>(out var _p0_UnityEngine_Rect))
            {
                if (_argCount == 1)
                {
                    var r = _p0_UnityEngine_Rect;
                    global::UnityEditor.AudioCurveRendering.DrawCurveBackground(r);
                    var _retCount = _context.Return();
                    return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                }
            }
            throw new global::Lua.LuaRuntimeException(_context.Thread, $"{"DrawCurveBackground"}: invalid argument #{_lastArgPos}: {_lastArg} ({_lastArg.Type}), expected: {_expectedType.FullName}", 2);
        });
        private static readonly global::Lua.LuaFunction _LuaAudioCurveRendering_DrawCurveFrame = new global::Lua.LuaFunction("DrawCurveFrame", (_context, _) =>
        {
            global::Lua.LuaValue _lastArg = default;
            global::System.Int32 _lastArgPos = default;
            global::System.Type _expectedType = default;
            var _argCount = _context.ArgumentCount;
            var _arg0 = _lastArg = _argCount > 0 ? _context.GetArgument(0) : global::Lua.LuaValue.Nil;
            _lastArgPos = 0; _expectedType = typeof(global::UnityEngine.Rect);
            if (_arg0.TryRead<global::UnityEngine.Rect>(out var _p0_UnityEngine_Rect))
            {
                if (_argCount == 1)
                {
                    var r = _p0_UnityEngine_Rect;
                    var _ret0 = global::UnityEditor.AudioCurveRendering.DrawCurveFrame(r);
                    var _factory = _context.GetObjectFactory();
                    var _lret0 = _factory.Bind(_ret0);
                    var _retCount = _context.Return(_lret0);
                    return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                }
            }
            throw new global::Lua.LuaRuntimeException(_context.Thread, $"{"DrawCurveFrame"}: invalid argument #{_lastArgPos}: {_lastArg} ({_lastArg.Type}), expected: {_expectedType.FullName}", 2);
        });
        private static readonly global::Lua.LuaFunction _LuaAudioCurveRendering_DrawFilledCurve = new global::Lua.LuaFunction("DrawFilledCurve", (_context, _) =>
        {
            global::Lua.LuaValue _lastArg = default;
            global::System.Int32 _lastArgPos = default;
            global::System.Type _expectedType = default;
            var _argCount = _context.ArgumentCount;
            var _arg0 = _lastArg = _argCount > 0 ? _context.GetArgument(0) : global::Lua.LuaValue.Nil;
            _lastArgPos = 0; _expectedType = typeof(global::UnityEngine.Rect);
            if (_arg0.TryRead<global::UnityEngine.Rect>(out var _p0_UnityEngine_Rect))
            {
                var _arg1 = _lastArg = _argCount > 1 ? _context.GetArgument(1) : global::Lua.LuaValue.Nil;
                _lastArgPos = 1; _expectedType = typeof(global::UnityEditor.AudioCurveRendering.AudioCurveAndColorEvaluator);
                if (_arg1.TryRead<global::UnityEditor.AudioCurveRendering.AudioCurveAndColorEvaluator>(out var _p1_UnityEditor_AudioCurveRendering_AudioCurveAndColorEvaluator))
                {
                    if (_argCount == 2)
                    {
                        var r = _p0_UnityEngine_Rect;
                        var eval = _p1_UnityEditor_AudioCurveRendering_AudioCurveAndColorEvaluator;
                        global::UnityEditor.AudioCurveRendering.DrawFilledCurve(r, eval);
                        var _retCount = _context.Return();
                        return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                    }
                }
                _lastArgPos = 1; _expectedType = typeof(global::UnityEditor.AudioCurveRendering.AudioCurveEvaluator);
                if (_arg1.TryRead<global::UnityEditor.AudioCurveRendering.AudioCurveEvaluator>(out var _p1_UnityEditor_AudioCurveRendering_AudioCurveEvaluator))
                {
                    var _arg2 = _lastArg = _argCount > 2 ? _context.GetArgument(2) : global::Lua.LuaValue.Nil;
                    _lastArgPos = 2; _expectedType = typeof(global::UnityEngine.Color);
                    if (_arg2.TryRead<global::UnityEngine.Color>(out var _p2_UnityEngine_Color))
                    {
                        if (_argCount == 3)
                        {
                            var r = _p0_UnityEngine_Rect;
                            var eval = _p1_UnityEditor_AudioCurveRendering_AudioCurveEvaluator;
                            var curveColor = _p2_UnityEngine_Color;
                            global::UnityEditor.AudioCurveRendering.DrawFilledCurve(r, eval, curveColor);
                            var _retCount = _context.Return();
                            return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                        }
                    }
                }
            }
            throw new global::Lua.LuaRuntimeException(_context.Thread, $"{"DrawFilledCurve"}: invalid argument #{_lastArgPos}: {_lastArg} ({_lastArg.Type}), expected: {_expectedType.FullName}", 2);
        });
        private static readonly global::Lua.LuaFunction _LuaAudioCurveRendering_DrawGradientRect = new global::Lua.LuaFunction("DrawGradientRect", (_context, _) =>
        {
            global::Lua.LuaValue _lastArg = default;
            global::System.Int32 _lastArgPos = default;
            global::System.Type _expectedType = default;
            var _argCount = _context.ArgumentCount;
            var _arg0 = _lastArg = _argCount > 0 ? _context.GetArgument(0) : global::Lua.LuaValue.Nil;
            _lastArgPos = 0; _expectedType = typeof(global::UnityEngine.Rect);
            if (_arg0.TryRead<global::UnityEngine.Rect>(out var _p0_UnityEngine_Rect))
            {
                var _arg1 = _lastArg = _argCount > 1 ? _context.GetArgument(1) : global::Lua.LuaValue.Nil;
                _lastArgPos = 1; _expectedType = typeof(global::UnityEngine.Color);
                if (_arg1.TryRead<global::UnityEngine.Color>(out var _p1_UnityEngine_Color))
                {
                    var _arg2 = _lastArg = _argCount > 2 ? _context.GetArgument(2) : global::Lua.LuaValue.Nil;
                    _lastArgPos = 2; _expectedType = typeof(global::UnityEngine.Color);
                    if (_arg2.TryRead<global::UnityEngine.Color>(out var _p2_UnityEngine_Color))
                    {
                        var _arg3 = _lastArg = _argCount > 3 ? _context.GetArgument(3) : global::Lua.LuaValue.Nil;
                        _lastArgPos = 3; _expectedType = typeof(global::System.Single);
                        if (_arg3.TryRead<global::System.Single>(out var _p3_System_Single))
                        {
                            var _arg4 = _lastArg = _argCount > 4 ? _context.GetArgument(4) : global::Lua.LuaValue.Nil;
                            _lastArgPos = 4; _expectedType = typeof(global::System.Boolean);
                            if (_arg4.TryRead<global::System.Boolean>(out var _p4_System_Boolean))
                            {
                                if (_argCount == 5)
                                {
                                    var r = _p0_UnityEngine_Rect;
                                    var c1 = _p1_UnityEngine_Color;
                                    var c2 = _p2_UnityEngine_Color;
                                    var blend = _p3_System_Single;
                                    var horizontal = _p4_System_Boolean;
                                    global::UnityEditor.AudioCurveRendering.DrawGradientRect(r, c1, c2, blend, horizontal);
                                    var _retCount = _context.Return();
                                    return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                                }
                            }
                        }
                    }
                }
            }
            throw new global::Lua.LuaRuntimeException(_context.Thread, $"{"DrawGradientRect"}: invalid argument #{_lastArgPos}: {_lastArg} ({_lastArg.Type}), expected: {_expectedType.FullName}", 2);
        });
        private static readonly global::Lua.LuaFunction _LuaAudioCurveRendering_DrawMinMaxFilledCurve = new global::Lua.LuaFunction("DrawMinMaxFilledCurve", (_context, _) =>
        {
            global::Lua.LuaValue _lastArg = default;
            global::System.Int32 _lastArgPos = default;
            global::System.Type _expectedType = default;
            var _argCount = _context.ArgumentCount;
            var _arg0 = _lastArg = _argCount > 0 ? _context.GetArgument(0) : global::Lua.LuaValue.Nil;
            _lastArgPos = 0; _expectedType = typeof(global::UnityEngine.Rect);
            if (_arg0.TryRead<global::UnityEngine.Rect>(out var _p0_UnityEngine_Rect))
            {
                var _arg1 = _lastArg = _argCount > 1 ? _context.GetArgument(1) : global::Lua.LuaValue.Nil;
                _lastArgPos = 1; _expectedType = typeof(global::UnityEditor.AudioCurveRendering.AudioMinMaxCurveAndColorEvaluator);
                if (_arg1.TryRead<global::UnityEditor.AudioCurveRendering.AudioMinMaxCurveAndColorEvaluator>(out var _p1_UnityEditor_AudioCurveRendering_AudioMinMaxCurveAndColorEvaluator))
                {
                    if (_argCount == 2)
                    {
                        var r = _p0_UnityEngine_Rect;
                        var eval = _p1_UnityEditor_AudioCurveRendering_AudioMinMaxCurveAndColorEvaluator;
                        global::UnityEditor.AudioCurveRendering.DrawMinMaxFilledCurve(r, eval);
                        var _retCount = _context.Return();
                        return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                    }
                }
            }
            throw new global::Lua.LuaRuntimeException(_context.Thread, $"{"DrawMinMaxFilledCurve"}: invalid argument #{_lastArgPos}: {_lastArg} ({_lastArg.Type}), expected: {_expectedType.FullName}", 2);
        });
        private static readonly global::Lua.LuaFunction _LuaAudioCurveRendering_DrawSymmetricFilledCurve = new global::Lua.LuaFunction("DrawSymmetricFilledCurve", (_context, _) =>
        {
            global::Lua.LuaValue _lastArg = default;
            global::System.Int32 _lastArgPos = default;
            global::System.Type _expectedType = default;
            var _argCount = _context.ArgumentCount;
            var _arg0 = _lastArg = _argCount > 0 ? _context.GetArgument(0) : global::Lua.LuaValue.Nil;
            _lastArgPos = 0; _expectedType = typeof(global::UnityEngine.Rect);
            if (_arg0.TryRead<global::UnityEngine.Rect>(out var _p0_UnityEngine_Rect))
            {
                var _arg1 = _lastArg = _argCount > 1 ? _context.GetArgument(1) : global::Lua.LuaValue.Nil;
                _lastArgPos = 1; _expectedType = typeof(global::UnityEditor.AudioCurveRendering.AudioCurveAndColorEvaluator);
                if (_arg1.TryRead<global::UnityEditor.AudioCurveRendering.AudioCurveAndColorEvaluator>(out var _p1_UnityEditor_AudioCurveRendering_AudioCurveAndColorEvaluator))
                {
                    if (_argCount == 2)
                    {
                        var r = _p0_UnityEngine_Rect;
                        var eval = _p1_UnityEditor_AudioCurveRendering_AudioCurveAndColorEvaluator;
                        global::UnityEditor.AudioCurveRendering.DrawSymmetricFilledCurve(r, eval);
                        var _retCount = _context.Return();
                        return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                    }
                }
            }
            throw new global::Lua.LuaRuntimeException(_context.Thread, $"{"DrawSymmetricFilledCurve"}: invalid argument #{_lastArgPos}: {_lastArg} ({_lastArg.Type}), expected: {_expectedType.FullName}", 2);
        });
        private static readonly global::Lua.LuaFunction _LuaAudioCurveRendering_EndCurveFrame = new global::Lua.LuaFunction("EndCurveFrame", (_context, _) =>
        {
            global::Lua.LuaValue _lastArg = default;
            global::System.Int32 _lastArgPos = default;
            global::System.Type _expectedType = default;
            var _argCount = _context.ArgumentCount;
            if (_argCount == 0)
            {
                global::UnityEditor.AudioCurveRendering.EndCurveFrame();
                var _retCount = _context.Return();
                return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
            }
            throw new global::Lua.LuaRuntimeException(_context.Thread, $"{"EndCurveFrame"}: invalid argument #{_lastArgPos}: {_lastArg} ({_lastArg.Type}), expected: {_expectedType.FullName}", 2);
        });
        private static readonly global::Lua.LuaFunction __index = new(global::Lua.Runtime.Metamethods.Index, (_context, _) =>
        {
            var _this = _context.GetArgument<LuaAudioCurveRenderingType>(0);
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
            var _this = _context.GetArgument<LuaAudioCurveRenderingType>(0);
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
                case "BeginCurveFrame": _value = _LuaAudioCurveRendering_BeginCurveFrame; return true;
                case "DrawCurve": _value = _LuaAudioCurveRendering_DrawCurve; return true;
                case "DrawCurveBackground": _value = _LuaAudioCurveRendering_DrawCurveBackground; return true;
                case "DrawCurveFrame": _value = _LuaAudioCurveRendering_DrawCurveFrame; return true;
                case "DrawFilledCurve": _value = _LuaAudioCurveRendering_DrawFilledCurve; return true;
                case "DrawGradientRect": _value = _LuaAudioCurveRendering_DrawGradientRect; return true;
                case "DrawMinMaxFilledCurve": _value = _LuaAudioCurveRendering_DrawMinMaxFilledCurve; return true;
                case "DrawSymmetricFilledCurve": _value = _LuaAudioCurveRendering_DrawSymmetricFilledCurve; return true;
                case "EndCurveFrame": _value = _LuaAudioCurveRendering_EndCurveFrame; return true;
                case "kAudioOrange": _value = _factory.Bind(global::UnityEditor.AudioCurveRendering.kAudioOrange); return true;
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
