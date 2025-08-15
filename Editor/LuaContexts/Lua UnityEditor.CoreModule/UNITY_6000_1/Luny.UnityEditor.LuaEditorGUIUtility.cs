
// --------------------------------------------------------------
// GENERATED FILE ----> DO NOT EDIT <---- CHANGES WILL BE LOST !!
// --------------------------------------------------------------

#if UNITY_6000_1_OR_NEWER && !(UNITY_6000_2_OR_NEWER)
#pragma warning disable 0109, 0162, 0168, 0219
using Luny;

namespace Luny.UnityEditor
{
    public sealed class LuaEditorGUIUtility : global::Luny.ILuaObject<global::UnityEditor.EditorGUIUtility>
    {
        public new static global::Lua.LuaValue Bind(global::UnityEditor.EditorGUIUtility instance) => new LuaEditorGUIUtility(instance);
        public new static global::Lua.LuaValue Bind(global::System.Object instance) => Bind((global::UnityEditor.EditorGUIUtility)instance);
        public new static global::Lua.LuaValue Bind(global::System.Collections.Generic.IList<global::UnityEditor.EditorGUIUtility> instances) =>
            new global::Luny.LuaList<global::UnityEditor.EditorGUIUtility>(instances);
        public new static global::Lua.LuaValue Bind(global::System.Collections.Generic.IList<global::System.Object> instances) =>
            new global::Luny.LuaList<global::UnityEditor.EditorGUIUtility>(instances);
        private LuaEditorGUIUtility(global::UnityEditor.EditorGUIUtility instance) => m_Instance = instance;
        public static implicit operator global::Lua.LuaValue(LuaEditorGUIUtility value) => new(value);
        private global::UnityEditor.EditorGUIUtility m_Instance;
        public global::UnityEditor.EditorGUIUtility Instance => m_Instance;
        public new global::System.Type BindType => typeof(global::UnityEditor.EditorGUIUtility);
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
            var _this = _context.GetArgument<LuaEditorGUIUtility>(0);
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
            var _this = _context.GetArgument<LuaEditorGUIUtility>(0);
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
    public sealed class LuaEditorGUIUtilityType : global::Luny.ILuaStatic
    {
        public static global::Lua.LuaValue Bind() => new LuaEditorGUIUtilityType();
        private LuaEditorGUIUtilityType() {}
        public static implicit operator global::Lua.LuaValue(LuaEditorGUIUtilityType value) => new(value);
        public global::System.Type BindType => typeof(global::UnityEditor.EditorGUIUtility);
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
            metatable[global::Lua.Runtime.Metamethods.Call] = _LuaEditorGUIUtility_new;
            return metatable;
        }
        public override global::System.String ToString() => BindType.FullName;
#if UNITY_EDITOR
        [global::UnityEngine.RuntimeInitializeOnLoadMethod(global::UnityEngine.RuntimeInitializeLoadType.SubsystemRegistration)]
        private static void ResetStaticFields() => s_Metatable = null;
#endif

        private static readonly global::Lua.LuaFunction _LuaEditorGUIUtility_new = new global::Lua.LuaFunction(".ctor", (_context, _) =>
        {
            global::Lua.LuaValue _lastArg = default;
            global::System.Int32 _lastArgPos = default;
            global::System.Type _expectedType = default;
            var _argCount = _context.ArgumentCount;
            if (_argCount == 1)
            {
                var _ret0 = new global::UnityEditor.EditorGUIUtility();
                var _factory = _context.GetObjectFactory();
                var _lret0 = _factory.Bind(_ret0);
                var _retCount = _context.Return(_lret0);
                return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
            }
            throw new global::Lua.LuaRuntimeException(_context.Thread, $"{".ctor"}: invalid argument #{_lastArgPos}: {_lastArg} ({_lastArg.Type}), expected: {_expectedType.FullName}", 2);
        });
        private static readonly global::Lua.LuaFunction _LuaEditorGUIUtility_AddCursorRect = new global::Lua.LuaFunction("AddCursorRect", (_context, _) =>
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
                _lastArgPos = 1; _expectedType = typeof(global::UnityEditor.MouseCursor);
                if (_arg1.TryRead<global::UnityEditor.MouseCursor>(out var _p1_UnityEditor_MouseCursor))
                {
                    if (_argCount == 2)
                    {
                        var position = _p0_UnityEngine_Rect;
                        var mouse = _p1_UnityEditor_MouseCursor;
                        global::UnityEditor.EditorGUIUtility.AddCursorRect(position, mouse);
                        var _retCount = _context.Return();
                        return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                    }
                    var _arg2 = _lastArg = _argCount > 2 ? _context.GetArgument(2) : global::Lua.LuaValue.Nil;
                    _lastArgPos = 2; _expectedType = typeof(global::System.Int32);
                    if (_arg2.TryRead<global::System.Int32>(out var _p2_System_Int32))
                    {
                        if (_argCount == 3)
                        {
                            var position = _p0_UnityEngine_Rect;
                            var mouse = _p1_UnityEditor_MouseCursor;
                            var controlID = _p2_System_Int32;
                            global::UnityEditor.EditorGUIUtility.AddCursorRect(position, mouse, controlID);
                            var _retCount = _context.Return();
                            return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                        }
                    }
                }
            }
            throw new global::Lua.LuaRuntimeException(_context.Thread, $"{"AddCursorRect"}: invalid argument #{_lastArgPos}: {_lastArg} ({_lastArg.Type}), expected: {_expectedType.FullName}", 2);
        });
        private static readonly global::Lua.LuaFunction _LuaEditorGUIUtility_CommandEvent = new global::Lua.LuaFunction("CommandEvent", (_context, _) =>
        {
            global::Lua.LuaValue _lastArg = default;
            global::System.Int32 _lastArgPos = default;
            global::System.Type _expectedType = default;
            var _argCount = _context.ArgumentCount;
            var _arg0 = _lastArg = _argCount > 0 ? _context.GetArgument(0) : global::Lua.LuaValue.Nil;
            _lastArgPos = 0; _expectedType = typeof(global::System.String);
            if (_arg0.TryRead<global::System.String>(out var _p0_System_String))
            {
                if (_argCount == 1)
                {
                    var commandName = _p0_System_String;
                    var _ret0 = global::UnityEditor.EditorGUIUtility.CommandEvent(commandName);
                    var _factory = _context.GetObjectFactory();
                    var _lret0 = _factory.Bind(_ret0);
                    var _retCount = _context.Return(_lret0);
                    return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                }
            }
            throw new global::Lua.LuaRuntimeException(_context.Thread, $"{"CommandEvent"}: invalid argument #{_lastArgPos}: {_lastArg} ({_lastArg.Type}), expected: {_expectedType.FullName}", 2);
        });
        private static readonly global::Lua.LuaFunction _LuaEditorGUIUtility_DrawColorSwatch = new global::Lua.LuaFunction("DrawColorSwatch", (_context, _) =>
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
                    if (_argCount == 2)
                    {
                        var position = _p0_UnityEngine_Rect;
                        var color = _p1_UnityEngine_Color;
                        global::UnityEditor.EditorGUIUtility.DrawColorSwatch(position, color);
                        var _retCount = _context.Return();
                        return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                    }
                }
            }
            throw new global::Lua.LuaRuntimeException(_context.Thread, $"{"DrawColorSwatch"}: invalid argument #{_lastArgPos}: {_lastArg} ({_lastArg.Type}), expected: {_expectedType.FullName}", 2);
        });
        private static readonly global::Lua.LuaFunction _LuaEditorGUIUtility_DrawCurveSwatch = new global::Lua.LuaFunction("DrawCurveSwatch", (_context, _) =>
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
                _lastArgPos = 1; _expectedType = typeof(global::UnityEngine.AnimationCurve);
                if (_arg1.TryRead<global::UnityEngine.AnimationCurve>(out var _p1_UnityEngine_AnimationCurve))
                {
                    var _arg2 = _lastArg = _argCount > 2 ? _context.GetArgument(2) : global::Lua.LuaValue.Nil;
                    _lastArgPos = 2; _expectedType = typeof(global::Luny.UnityEditor.LuaSerializedProperty);
                    if (_arg2.TryRead<global::Luny.UnityEditor.LuaSerializedProperty>(out var _p2_UnityEditor_SerializedProperty))
                    {
                        var _arg3 = _lastArg = _argCount > 3 ? _context.GetArgument(3) : global::Lua.LuaValue.Nil;
                        _lastArgPos = 3; _expectedType = typeof(global::UnityEngine.Color);
                        if (_arg3.TryRead<global::UnityEngine.Color>(out var _p3_UnityEngine_Color))
                        {
                            var _arg4 = _lastArg = _argCount > 4 ? _context.GetArgument(4) : global::Lua.LuaValue.Nil;
                            _lastArgPos = 4; _expectedType = typeof(global::UnityEngine.Color);
                            if (_arg4.TryRead<global::UnityEngine.Color>(out var _p4_UnityEngine_Color))
                            {
                                if (_argCount == 5)
                                {
                                    var position = _p0_UnityEngine_Rect;
                                    var curve = _p1_UnityEngine_AnimationCurve;
                                    var property = _p2_UnityEditor_SerializedProperty.Instance;
                                    var color = _p3_UnityEngine_Color;
                                    var bgColor = _p4_UnityEngine_Color;
                                    global::UnityEditor.EditorGUIUtility.DrawCurveSwatch(position, curve, property, color, bgColor);
                                    var _retCount = _context.Return();
                                    return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                                }
                                var _arg5 = _lastArg = _argCount > 5 ? _context.GetArgument(5) : global::Lua.LuaValue.Nil;
                                _lastArgPos = 5; _expectedType = typeof(global::UnityEngine.Rect);
                                if (_arg5.TryRead<global::UnityEngine.Rect>(out var _p5_UnityEngine_Rect))
                                {
                                    if (_argCount == 6)
                                    {
                                        var position = _p0_UnityEngine_Rect;
                                        var curve = _p1_UnityEngine_AnimationCurve;
                                        var property = _p2_UnityEditor_SerializedProperty.Instance;
                                        var color = _p3_UnityEngine_Color;
                                        var bgColor = _p4_UnityEngine_Color;
                                        var curveRanges = _p5_UnityEngine_Rect;
                                        global::UnityEditor.EditorGUIUtility.DrawCurveSwatch(position, curve, property, color, bgColor, curveRanges);
                                        var _retCount = _context.Return();
                                        return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                                    }
                                }
                                _lastArgPos = 5; _expectedType = typeof(global::UnityEngine.Color);
                                if (_arg5.TryRead<global::UnityEngine.Color>(out var _p5_UnityEngine_Color))
                                {
                                    var _arg6 = _lastArg = _argCount > 6 ? _context.GetArgument(6) : global::Lua.LuaValue.Nil;
                                    _lastArgPos = 6; _expectedType = typeof(global::UnityEngine.Color);
                                    if (_arg6.TryRead<global::UnityEngine.Color>(out var _p6_UnityEngine_Color))
                                    {
                                        if (_argCount == 7)
                                        {
                                            var position = _p0_UnityEngine_Rect;
                                            var curve = _p1_UnityEngine_AnimationCurve;
                                            var property = _p2_UnityEditor_SerializedProperty.Instance;
                                            var color = _p3_UnityEngine_Color;
                                            var bgColor = _p4_UnityEngine_Color;
                                            var topFillColor = _p5_UnityEngine_Color;
                                            var bottomFillColor = _p6_UnityEngine_Color;
                                            global::UnityEditor.EditorGUIUtility.DrawCurveSwatch(position, curve, property, color, bgColor, topFillColor, bottomFillColor);
                                            var _retCount = _context.Return();
                                            return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                                        }
                                        var _arg7 = _lastArg = _argCount > 7 ? _context.GetArgument(7) : global::Lua.LuaValue.Nil;
                                        _lastArgPos = 7; _expectedType = typeof(global::UnityEngine.Rect);
                                        if (_arg7.TryRead<global::UnityEngine.Rect>(out var _p7_UnityEngine_Rect))
                                        {
                                            if (_argCount == 8)
                                            {
                                                var position = _p0_UnityEngine_Rect;
                                                var curve = _p1_UnityEngine_AnimationCurve;
                                                var property = _p2_UnityEditor_SerializedProperty.Instance;
                                                var color = _p3_UnityEngine_Color;
                                                var bgColor = _p4_UnityEngine_Color;
                                                var topFillColor = _p5_UnityEngine_Color;
                                                var bottomFillColor = _p6_UnityEngine_Color;
                                                var curveRanges = _p7_UnityEngine_Rect;
                                                global::UnityEditor.EditorGUIUtility.DrawCurveSwatch(position, curve, property, color, bgColor, topFillColor, bottomFillColor, curveRanges);
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
            throw new global::Lua.LuaRuntimeException(_context.Thread, $"{"DrawCurveSwatch"}: invalid argument #{_lastArgPos}: {_lastArg} ({_lastArg.Type}), expected: {_expectedType.FullName}", 2);
        });
        private static readonly global::Lua.LuaFunction _LuaEditorGUIUtility_DrawRegionSwatch = new global::Lua.LuaFunction("DrawRegionSwatch", (_context, _) =>
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
                _lastArgPos = 1; _expectedType = typeof(global::Luny.UnityEditor.LuaSerializedProperty);
                if (_arg1.TryRead<global::Luny.UnityEditor.LuaSerializedProperty>(out var _p1_UnityEditor_SerializedProperty))
                {
                    var _arg2 = _lastArg = _argCount > 2 ? _context.GetArgument(2) : global::Lua.LuaValue.Nil;
                    _lastArgPos = 2; _expectedType = typeof(global::Luny.UnityEditor.LuaSerializedProperty);
                    if (_arg2.TryRead<global::Luny.UnityEditor.LuaSerializedProperty>(out var _p2_UnityEditor_SerializedProperty))
                    {
                        var _arg3 = _lastArg = _argCount > 3 ? _context.GetArgument(3) : global::Lua.LuaValue.Nil;
                        _lastArgPos = 3; _expectedType = typeof(global::UnityEngine.Color);
                        if (_arg3.TryRead<global::UnityEngine.Color>(out var _p3_UnityEngine_Color))
                        {
                            var _arg4 = _lastArg = _argCount > 4 ? _context.GetArgument(4) : global::Lua.LuaValue.Nil;
                            _lastArgPos = 4; _expectedType = typeof(global::UnityEngine.Color);
                            if (_arg4.TryRead<global::UnityEngine.Color>(out var _p4_UnityEngine_Color))
                            {
                                var _arg5 = _lastArg = _argCount > 5 ? _context.GetArgument(5) : global::Lua.LuaValue.Nil;
                                _lastArgPos = 5; _expectedType = typeof(global::UnityEngine.Rect);
                                if (_arg5.TryRead<global::UnityEngine.Rect>(out var _p5_UnityEngine_Rect))
                                {
                                    if (_argCount == 6)
                                    {
                                        var position = _p0_UnityEngine_Rect;
                                        var property = _p1_UnityEditor_SerializedProperty.Instance;
                                        var property2 = _p2_UnityEditor_SerializedProperty.Instance;
                                        var color = _p3_UnityEngine_Color;
                                        var bgColor = _p4_UnityEngine_Color;
                                        var curveRanges = _p5_UnityEngine_Rect;
                                        global::UnityEditor.EditorGUIUtility.DrawRegionSwatch(position, property, property2, color, bgColor, curveRanges);
                                        var _retCount = _context.Return();
                                        return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                                    }
                                }
                            }
                        }
                    }
                }
                _lastArgPos = 1; _expectedType = typeof(global::UnityEngine.AnimationCurve);
                if (_arg1.TryRead<global::UnityEngine.AnimationCurve>(out var _p1_UnityEngine_AnimationCurve))
                {
                    var _arg2 = _lastArg = _argCount > 2 ? _context.GetArgument(2) : global::Lua.LuaValue.Nil;
                    _lastArgPos = 2; _expectedType = typeof(global::UnityEngine.AnimationCurve);
                    if (_arg2.TryRead<global::UnityEngine.AnimationCurve>(out var _p2_UnityEngine_AnimationCurve))
                    {
                        var _arg3 = _lastArg = _argCount > 3 ? _context.GetArgument(3) : global::Lua.LuaValue.Nil;
                        _lastArgPos = 3; _expectedType = typeof(global::UnityEngine.Color);
                        if (_arg3.TryRead<global::UnityEngine.Color>(out var _p3_UnityEngine_Color))
                        {
                            var _arg4 = _lastArg = _argCount > 4 ? _context.GetArgument(4) : global::Lua.LuaValue.Nil;
                            _lastArgPos = 4; _expectedType = typeof(global::UnityEngine.Color);
                            if (_arg4.TryRead<global::UnityEngine.Color>(out var _p4_UnityEngine_Color))
                            {
                                var _arg5 = _lastArg = _argCount > 5 ? _context.GetArgument(5) : global::Lua.LuaValue.Nil;
                                _lastArgPos = 5; _expectedType = typeof(global::UnityEngine.Rect);
                                if (_arg5.TryRead<global::UnityEngine.Rect>(out var _p5_UnityEngine_Rect))
                                {
                                    if (_argCount == 6)
                                    {
                                        var position = _p0_UnityEngine_Rect;
                                        var curve = _p1_UnityEngine_AnimationCurve;
                                        var curve2 = _p2_UnityEngine_AnimationCurve;
                                        var color = _p3_UnityEngine_Color;
                                        var bgColor = _p4_UnityEngine_Color;
                                        var curveRanges = _p5_UnityEngine_Rect;
                                        global::UnityEditor.EditorGUIUtility.DrawRegionSwatch(position, curve, curve2, color, bgColor, curveRanges);
                                        var _retCount = _context.Return();
                                        return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                                    }
                                }
                            }
                        }
                    }
                }
            }
            throw new global::Lua.LuaRuntimeException(_context.Thread, $"{"DrawRegionSwatch"}: invalid argument #{_lastArgPos}: {_lastArg} ({_lastArg.Type}), expected: {_expectedType.FullName}", 2);
        });
        private static readonly global::Lua.LuaFunction _LuaEditorGUIUtility_FindTexture = new global::Lua.LuaFunction("FindTexture", (_context, _) =>
        {
            global::Lua.LuaValue _lastArg = default;
            global::System.Int32 _lastArgPos = default;
            global::System.Type _expectedType = default;
            var _argCount = _context.ArgumentCount;
            var _arg0 = _lastArg = _argCount > 0 ? _context.GetArgument(0) : global::Lua.LuaValue.Nil;
            _lastArgPos = 0; _expectedType = typeof(global::System.String);
            if (_arg0.TryRead<global::System.String>(out var _p0_System_String))
            {
                if (_argCount == 1)
                {
                    var name = _p0_System_String;
                    var _ret0 = global::UnityEditor.EditorGUIUtility.FindTexture(name);
                    var _factory = _context.GetObjectFactory();
                    var _lret0 = _factory.Bind(_ret0);
                    var _retCount = _context.Return(_lret0);
                    return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                }
            }
            throw new global::Lua.LuaRuntimeException(_context.Thread, $"{"FindTexture"}: invalid argument #{_lastArgPos}: {_lastArg} ({_lastArg.Type}), expected: {_expectedType.FullName}", 2);
        });
        private static readonly global::Lua.LuaFunction _LuaEditorGUIUtility_GetBuiltinSkin = new global::Lua.LuaFunction("GetBuiltinSkin", (_context, _) =>
        {
            global::Lua.LuaValue _lastArg = default;
            global::System.Int32 _lastArgPos = default;
            global::System.Type _expectedType = default;
            var _argCount = _context.ArgumentCount;
            var _arg0 = _lastArg = _argCount > 0 ? _context.GetArgument(0) : global::Lua.LuaValue.Nil;
            _lastArgPos = 0; _expectedType = typeof(global::UnityEditor.EditorSkin);
            if (_arg0.TryRead<global::UnityEditor.EditorSkin>(out var _p0_UnityEditor_EditorSkin))
            {
                if (_argCount == 1)
                {
                    var skin = _p0_UnityEditor_EditorSkin;
                    var _ret0 = global::UnityEditor.EditorGUIUtility.GetBuiltinSkin(skin);
                    var _factory = _context.GetObjectFactory();
                    var _lret0 = _factory.Bind(_ret0);
                    var _retCount = _context.Return(_lret0);
                    return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                }
            }
            throw new global::Lua.LuaRuntimeException(_context.Thread, $"{"GetBuiltinSkin"}: invalid argument #{_lastArgPos}: {_lastArg} ({_lastArg.Type}), expected: {_expectedType.FullName}", 2);
        });
        private static readonly global::Lua.LuaFunction _LuaEditorGUIUtility_GetIconForObject = new global::Lua.LuaFunction("GetIconForObject", (_context, _) =>
        {
            global::Lua.LuaValue _lastArg = default;
            global::System.Int32 _lastArgPos = default;
            global::System.Type _expectedType = default;
            var _argCount = _context.ArgumentCount;
            var _arg0 = _lastArg = _argCount > 0 ? _context.GetArgument(0) : global::Lua.LuaValue.Nil;
            _lastArgPos = 0; _expectedType = typeof(global::UnityEngine.Object);
            if (_arg0.TryRead<global::UnityEngine.Object>(out var _p0_UnityEngine_Object))
            {
                if (_argCount == 1)
                {
                    var obj = _p0_UnityEngine_Object;
                    var _ret0 = global::UnityEditor.EditorGUIUtility.GetIconForObject(obj);
                    var _factory = _context.GetObjectFactory();
                    var _lret0 = _factory.Bind(_ret0);
                    var _retCount = _context.Return(_lret0);
                    return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                }
            }
            throw new global::Lua.LuaRuntimeException(_context.Thread, $"{"GetIconForObject"}: invalid argument #{_lastArgPos}: {_lastArg} ({_lastArg.Type}), expected: {_expectedType.FullName}", 2);
        });
        private static readonly global::Lua.LuaFunction _LuaEditorGUIUtility_GetIconSize = new global::Lua.LuaFunction("GetIconSize", (_context, _) =>
        {
            global::Lua.LuaValue _lastArg = default;
            global::System.Int32 _lastArgPos = default;
            global::System.Type _expectedType = default;
            var _argCount = _context.ArgumentCount;
            if (_argCount == 0)
            {
                var _ret0 = global::UnityEditor.EditorGUIUtility.GetIconSize();
                var _factory = _context.GetObjectFactory();
                var _lret0 = _factory.Bind(_ret0);
                var _retCount = _context.Return(_lret0);
                return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
            }
            throw new global::Lua.LuaRuntimeException(_context.Thread, $"{"GetIconSize"}: invalid argument #{_lastArgPos}: {_lastArg} ({_lastArg.Type}), expected: {_expectedType.FullName}", 2);
        });
        private static readonly global::Lua.LuaFunction _LuaEditorGUIUtility_GetMainWindowPosition = new global::Lua.LuaFunction("GetMainWindowPosition", (_context, _) =>
        {
            global::Lua.LuaValue _lastArg = default;
            global::System.Int32 _lastArgPos = default;
            global::System.Type _expectedType = default;
            var _argCount = _context.ArgumentCount;
            if (_argCount == 0)
            {
                var _ret0 = global::UnityEditor.EditorGUIUtility.GetMainWindowPosition();
                var _factory = _context.GetObjectFactory();
                var _lret0 = _factory.Bind(_ret0);
                var _retCount = _context.Return(_lret0);
                return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
            }
            throw new global::Lua.LuaRuntimeException(_context.Thread, $"{"GetMainWindowPosition"}: invalid argument #{_lastArgPos}: {_lastArg} ({_lastArg.Type}), expected: {_expectedType.FullName}", 2);
        });
        private static readonly global::Lua.LuaFunction _LuaEditorGUIUtility_GetObjectPickerControlID = new global::Lua.LuaFunction("GetObjectPickerControlID", (_context, _) =>
        {
            global::Lua.LuaValue _lastArg = default;
            global::System.Int32 _lastArgPos = default;
            global::System.Type _expectedType = default;
            var _argCount = _context.ArgumentCount;
            if (_argCount == 0)
            {
                var _ret0 = global::UnityEditor.EditorGUIUtility.GetObjectPickerControlID();
                var _lret0 = new global::Lua.LuaValue(_ret0);
                var _retCount = _context.Return(_lret0);
                return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
            }
            throw new global::Lua.LuaRuntimeException(_context.Thread, $"{"GetObjectPickerControlID"}: invalid argument #{_lastArgPos}: {_lastArg} ({_lastArg.Type}), expected: {_expectedType.FullName}", 2);
        });
        private static readonly global::Lua.LuaFunction _LuaEditorGUIUtility_GetObjectPickerObject = new global::Lua.LuaFunction("GetObjectPickerObject", (_context, _) =>
        {
            global::Lua.LuaValue _lastArg = default;
            global::System.Int32 _lastArgPos = default;
            global::System.Type _expectedType = default;
            var _argCount = _context.ArgumentCount;
            if (_argCount == 0)
            {
                var _ret0 = global::UnityEditor.EditorGUIUtility.GetObjectPickerObject();
                var _factory = _context.GetObjectFactory();
                var _lret0 = _factory.Bind(_ret0);
                var _retCount = _context.Return(_lret0);
                return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
            }
            throw new global::Lua.LuaRuntimeException(_context.Thread, $"{"GetObjectPickerObject"}: invalid argument #{_lastArgPos}: {_lastArg} ({_lastArg.Type}), expected: {_expectedType.FullName}", 2);
        });
        private static readonly global::Lua.LuaFunction _LuaEditorGUIUtility_HasObjectThumbnail = new global::Lua.LuaFunction("HasObjectThumbnail", (_context, _) =>
        {
            global::Lua.LuaValue _lastArg = default;
            global::System.Int32 _lastArgPos = default;
            global::System.Type _expectedType = default;
            var _argCount = _context.ArgumentCount;
            var _arg0 = _lastArg = _argCount > 0 ? _context.GetArgument(0) : global::Lua.LuaValue.Nil;
            _lastArgPos = 0; _expectedType = typeof(global::Luny.ILuaBindType);
            if (_arg0.TryRead<global::Luny.ILuaBindType>(out var _p0_System_Type))
            {
                if (_argCount == 1)
                {
                    var objType = _p0_System_Type.BindType;
                    var _ret0 = global::UnityEditor.EditorGUIUtility.HasObjectThumbnail(objType);
                    var _lret0 = new global::Lua.LuaValue(_ret0);
                    var _retCount = _context.Return(_lret0);
                    return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                }
            }
            throw new global::Lua.LuaRuntimeException(_context.Thread, $"{"HasObjectThumbnail"}: invalid argument #{_lastArgPos}: {_lastArg} ({_lastArg.Type}), expected: {_expectedType.FullName}", 2);
        });
        private static readonly global::Lua.LuaFunction _LuaEditorGUIUtility_IconContent = new global::Lua.LuaFunction("IconContent", (_context, _) =>
        {
            global::Lua.LuaValue _lastArg = default;
            global::System.Int32 _lastArgPos = default;
            global::System.Type _expectedType = default;
            var _argCount = _context.ArgumentCount;
            var _arg0 = _lastArg = _argCount > 0 ? _context.GetArgument(0) : global::Lua.LuaValue.Nil;
            _lastArgPos = 0; _expectedType = typeof(global::System.String);
            if (_arg0.TryRead<global::System.String>(out var _p0_System_String))
            {
                if (_argCount == 1)
                {
                    var name = _p0_System_String;
                    var _ret0 = global::UnityEditor.EditorGUIUtility.IconContent(name);
                    var _factory = _context.GetObjectFactory();
                    var _lret0 = _factory.Bind(_ret0);
                    var _retCount = _context.Return(_lret0);
                    return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                }
                var _arg1 = _lastArg = _argCount > 1 ? _context.GetArgument(1) : global::Lua.LuaValue.Nil;
                _lastArgPos = 1; _expectedType = typeof(global::System.String);
                if (_arg1.TryRead<global::System.String>(out var _p1_System_String))
                {
                    if (_argCount == 2)
                    {
                        var name = _p0_System_String;
                        var text = _p1_System_String;
                        var _ret0 = global::UnityEditor.EditorGUIUtility.IconContent(name, text);
                        var _factory = _context.GetObjectFactory();
                        var _lret0 = _factory.Bind(_ret0);
                        var _retCount = _context.Return(_lret0);
                        return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                    }
                }
            }
            throw new global::Lua.LuaRuntimeException(_context.Thread, $"{"IconContent"}: invalid argument #{_lastArgPos}: {_lastArg} ({_lastArg.Type}), expected: {_expectedType.FullName}", 2);
        });
        private static readonly global::Lua.LuaFunction _LuaEditorGUIUtility_IsDisplayReferencedByCameras = new global::Lua.LuaFunction("IsDisplayReferencedByCameras", (_context, _) =>
        {
            global::Lua.LuaValue _lastArg = default;
            global::System.Int32 _lastArgPos = default;
            global::System.Type _expectedType = default;
            var _argCount = _context.ArgumentCount;
            var _arg0 = _lastArg = _argCount > 0 ? _context.GetArgument(0) : global::Lua.LuaValue.Nil;
            _lastArgPos = 0; _expectedType = typeof(global::System.Int32);
            if (_arg0.TryRead<global::System.Int32>(out var _p0_System_Int32))
            {
                if (_argCount == 1)
                {
                    var displayIndex = _p0_System_Int32;
                    var _ret0 = global::UnityEditor.EditorGUIUtility.IsDisplayReferencedByCameras(displayIndex);
                    var _lret0 = new global::Lua.LuaValue(_ret0);
                    var _retCount = _context.Return(_lret0);
                    return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                }
            }
            throw new global::Lua.LuaRuntimeException(_context.Thread, $"{"IsDisplayReferencedByCameras"}: invalid argument #{_lastArgPos}: {_lastArg} ({_lastArg.Type}), expected: {_expectedType.FullName}", 2);
        });
        private static readonly global::Lua.LuaFunction _LuaEditorGUIUtility_Load = new global::Lua.LuaFunction("Load", (_context, _) =>
        {
            global::Lua.LuaValue _lastArg = default;
            global::System.Int32 _lastArgPos = default;
            global::System.Type _expectedType = default;
            var _argCount = _context.ArgumentCount;
            var _arg0 = _lastArg = _argCount > 0 ? _context.GetArgument(0) : global::Lua.LuaValue.Nil;
            _lastArgPos = 0; _expectedType = typeof(global::System.String);
            if (_arg0.TryRead<global::System.String>(out var _p0_System_String))
            {
                if (_argCount == 1)
                {
                    var path = _p0_System_String;
                    var _ret0 = global::UnityEditor.EditorGUIUtility.Load(path);
                    var _factory = _context.GetObjectFactory();
                    var _lret0 = _factory.Bind(_ret0);
                    var _retCount = _context.Return(_lret0);
                    return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                }
            }
            throw new global::Lua.LuaRuntimeException(_context.Thread, $"{"Load"}: invalid argument #{_lastArgPos}: {_lastArg} ({_lastArg.Type}), expected: {_expectedType.FullName}", 2);
        });
        private static readonly global::Lua.LuaFunction _LuaEditorGUIUtility_LoadRequired = new global::Lua.LuaFunction("LoadRequired", (_context, _) =>
        {
            global::Lua.LuaValue _lastArg = default;
            global::System.Int32 _lastArgPos = default;
            global::System.Type _expectedType = default;
            var _argCount = _context.ArgumentCount;
            var _arg0 = _lastArg = _argCount > 0 ? _context.GetArgument(0) : global::Lua.LuaValue.Nil;
            _lastArgPos = 0; _expectedType = typeof(global::System.String);
            if (_arg0.TryRead<global::System.String>(out var _p0_System_String))
            {
                if (_argCount == 1)
                {
                    var path = _p0_System_String;
                    var _ret0 = global::UnityEditor.EditorGUIUtility.LoadRequired(path);
                    var _factory = _context.GetObjectFactory();
                    var _lret0 = _factory.Bind(_ret0);
                    var _retCount = _context.Return(_lret0);
                    return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                }
            }
            throw new global::Lua.LuaRuntimeException(_context.Thread, $"{"LoadRequired"}: invalid argument #{_lastArgPos}: {_lastArg} ({_lastArg.Type}), expected: {_expectedType.FullName}", 2);
        });
        private static readonly global::Lua.LuaFunction _LuaEditorGUIUtility_ObjectContent = new global::Lua.LuaFunction("ObjectContent", (_context, _) =>
        {
            global::Lua.LuaValue _lastArg = default;
            global::System.Int32 _lastArgPos = default;
            global::System.Type _expectedType = default;
            var _argCount = _context.ArgumentCount;
            var _arg0 = _lastArg = _argCount > 0 ? _context.GetArgument(0) : global::Lua.LuaValue.Nil;
            _lastArgPos = 0; _expectedType = typeof(global::UnityEngine.Object);
            if (_arg0.TryRead<global::UnityEngine.Object>(out var _p0_UnityEngine_Object))
            {
                var _arg1 = _lastArg = _argCount > 1 ? _context.GetArgument(1) : global::Lua.LuaValue.Nil;
                _lastArgPos = 1; _expectedType = typeof(global::Luny.ILuaBindType);
                if (_arg1.TryRead<global::Luny.ILuaBindType>(out var _p1_System_Type))
                {
                    if (_argCount == 2)
                    {
                        var obj = _p0_UnityEngine_Object;
                        var type = _p1_System_Type.BindType;
                        var _ret0 = global::UnityEditor.EditorGUIUtility.ObjectContent(obj, type);
                        var _factory = _context.GetObjectFactory();
                        var _lret0 = _factory.Bind(_ret0);
                        var _retCount = _context.Return(_lret0);
                        return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                    }
                }
            }
            throw new global::Lua.LuaRuntimeException(_context.Thread, $"{"ObjectContent"}: invalid argument #{_lastArgPos}: {_lastArg} ({_lastArg.Type}), expected: {_expectedType.FullName}", 2);
        });
        private static readonly global::Lua.LuaFunction _LuaEditorGUIUtility_PingObject = new global::Lua.LuaFunction("PingObject", (_context, _) =>
        {
            global::Lua.LuaValue _lastArg = default;
            global::System.Int32 _lastArgPos = default;
            global::System.Type _expectedType = default;
            var _argCount = _context.ArgumentCount;
            var _arg0 = _lastArg = _argCount > 0 ? _context.GetArgument(0) : global::Lua.LuaValue.Nil;
            _lastArgPos = 0; _expectedType = typeof(global::System.Int32);
            if (_arg0.TryRead<global::System.Int32>(out var _p0_System_Int32))
            {
                if (_argCount == 1)
                {
                    var targetInstanceID = _p0_System_Int32;
                    global::UnityEditor.EditorGUIUtility.PingObject(targetInstanceID);
                    var _retCount = _context.Return();
                    return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                }
            }
            _lastArgPos = 0; _expectedType = typeof(global::UnityEngine.Object);
            if (_arg0.TryRead<global::UnityEngine.Object>(out var _p0_UnityEngine_Object))
            {
                if (_argCount == 1)
                {
                    var obj = _p0_UnityEngine_Object;
                    global::UnityEditor.EditorGUIUtility.PingObject(obj);
                    var _retCount = _context.Return();
                    return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                }
            }
            throw new global::Lua.LuaRuntimeException(_context.Thread, $"{"PingObject"}: invalid argument #{_lastArgPos}: {_lastArg} ({_lastArg.Type}), expected: {_expectedType.FullName}", 2);
        });
        private static readonly global::Lua.LuaFunction _LuaEditorGUIUtility_PixelsToPoints = new global::Lua.LuaFunction("PixelsToPoints", (_context, _) =>
        {
            global::Lua.LuaValue _lastArg = default;
            global::System.Int32 _lastArgPos = default;
            global::System.Type _expectedType = default;
            var _argCount = _context.ArgumentCount;
            var _arg0 = _lastArg = _argCount > 0 ? _context.GetArgument(0) : global::Lua.LuaValue.Nil;
            _lastArgPos = 0; _expectedType = typeof(global::UnityEngine.Vector2);
            if (_arg0.TryRead<global::UnityEngine.Vector2>(out var _p0_UnityEngine_Vector2))
            {
                if (_argCount == 1)
                {
                    var position = _p0_UnityEngine_Vector2;
                    var _ret0 = global::UnityEditor.EditorGUIUtility.PixelsToPoints(position);
                    var _factory = _context.GetObjectFactory();
                    var _lret0 = _factory.Bind(_ret0);
                    var _retCount = _context.Return(_lret0);
                    return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                }
            }
            _lastArgPos = 0; _expectedType = typeof(global::UnityEngine.Rect);
            if (_arg0.TryRead<global::UnityEngine.Rect>(out var _p0_UnityEngine_Rect))
            {
                if (_argCount == 1)
                {
                    var rect = _p0_UnityEngine_Rect;
                    var _ret0 = global::UnityEditor.EditorGUIUtility.PixelsToPoints(rect);
                    var _factory = _context.GetObjectFactory();
                    var _lret0 = _factory.Bind(_ret0);
                    var _retCount = _context.Return(_lret0);
                    return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                }
            }
            throw new global::Lua.LuaRuntimeException(_context.Thread, $"{"PixelsToPoints"}: invalid argument #{_lastArgPos}: {_lastArg} ({_lastArg.Type}), expected: {_expectedType.FullName}", 2);
        });
        private static readonly global::Lua.LuaFunction _LuaEditorGUIUtility_PointsToPixels = new global::Lua.LuaFunction("PointsToPixels", (_context, _) =>
        {
            global::Lua.LuaValue _lastArg = default;
            global::System.Int32 _lastArgPos = default;
            global::System.Type _expectedType = default;
            var _argCount = _context.ArgumentCount;
            var _arg0 = _lastArg = _argCount > 0 ? _context.GetArgument(0) : global::Lua.LuaValue.Nil;
            _lastArgPos = 0; _expectedType = typeof(global::UnityEngine.Vector2);
            if (_arg0.TryRead<global::UnityEngine.Vector2>(out var _p0_UnityEngine_Vector2))
            {
                if (_argCount == 1)
                {
                    var position = _p0_UnityEngine_Vector2;
                    var _ret0 = global::UnityEditor.EditorGUIUtility.PointsToPixels(position);
                    var _factory = _context.GetObjectFactory();
                    var _lret0 = _factory.Bind(_ret0);
                    var _retCount = _context.Return(_lret0);
                    return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                }
            }
            _lastArgPos = 0; _expectedType = typeof(global::UnityEngine.Rect);
            if (_arg0.TryRead<global::UnityEngine.Rect>(out var _p0_UnityEngine_Rect))
            {
                if (_argCount == 1)
                {
                    var rect = _p0_UnityEngine_Rect;
                    var _ret0 = global::UnityEditor.EditorGUIUtility.PointsToPixels(rect);
                    var _factory = _context.GetObjectFactory();
                    var _lret0 = _factory.Bind(_ret0);
                    var _retCount = _context.Return(_lret0);
                    return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                }
            }
            throw new global::Lua.LuaRuntimeException(_context.Thread, $"{"PointsToPixels"}: invalid argument #{_lastArgPos}: {_lastArg} ({_lastArg.Type}), expected: {_expectedType.FullName}", 2);
        });
        private static readonly global::Lua.LuaFunction _LuaEditorGUIUtility_QueueGameViewInputEvent = new global::Lua.LuaFunction("QueueGameViewInputEvent", (_context, _) =>
        {
            global::Lua.LuaValue _lastArg = default;
            global::System.Int32 _lastArgPos = default;
            global::System.Type _expectedType = default;
            var _argCount = _context.ArgumentCount;
            var _arg0 = _lastArg = _argCount > 0 ? _context.GetArgument(0) : global::Lua.LuaValue.Nil;
            _lastArgPos = 0; _expectedType = typeof(global::UnityEngine.Event);
            if (_arg0.TryRead<global::UnityEngine.Event>(out var _p0_UnityEngine_Event))
            {
                if (_argCount == 1)
                {
                    var evt = _p0_UnityEngine_Event;
                    global::UnityEditor.EditorGUIUtility.QueueGameViewInputEvent(evt);
                    var _retCount = _context.Return();
                    return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                }
            }
            throw new global::Lua.LuaRuntimeException(_context.Thread, $"{"QueueGameViewInputEvent"}: invalid argument #{_lastArgPos}: {_lastArg} ({_lastArg.Type}), expected: {_expectedType.FullName}", 2);
        });
        private static readonly global::Lua.LuaFunction _LuaEditorGUIUtility_SerializeMainMenuToString = new global::Lua.LuaFunction("SerializeMainMenuToString", (_context, _) =>
        {
            global::Lua.LuaValue _lastArg = default;
            global::System.Int32 _lastArgPos = default;
            global::System.Type _expectedType = default;
            var _argCount = _context.ArgumentCount;
            if (_argCount == 0)
            {
                var _ret0 = global::UnityEditor.EditorGUIUtility.SerializeMainMenuToString();
                var _lret0 = new global::Lua.LuaValue(_ret0);
                var _retCount = _context.Return(_lret0);
                return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
            }
            throw new global::Lua.LuaRuntimeException(_context.Thread, $"{"SerializeMainMenuToString"}: invalid argument #{_lastArgPos}: {_lastArg} ({_lastArg.Type}), expected: {_expectedType.FullName}", 2);
        });
        private static readonly global::Lua.LuaFunction _LuaEditorGUIUtility_SetIconForObject = new global::Lua.LuaFunction("SetIconForObject", (_context, _) =>
        {
            global::Lua.LuaValue _lastArg = default;
            global::System.Int32 _lastArgPos = default;
            global::System.Type _expectedType = default;
            var _argCount = _context.ArgumentCount;
            var _arg0 = _lastArg = _argCount > 0 ? _context.GetArgument(0) : global::Lua.LuaValue.Nil;
            _lastArgPos = 0; _expectedType = typeof(global::UnityEngine.Object);
            if (_arg0.TryRead<global::UnityEngine.Object>(out var _p0_UnityEngine_Object))
            {
                var _arg1 = _lastArg = _argCount > 1 ? _context.GetArgument(1) : global::Lua.LuaValue.Nil;
                _lastArgPos = 1; _expectedType = typeof(global::UnityEngine.Texture2D);
                if (_arg1.TryRead<global::UnityEngine.Texture2D>(out var _p1_UnityEngine_Texture2D))
                {
                    if (_argCount == 2)
                    {
                        var obj = _p0_UnityEngine_Object;
                        var icon = _p1_UnityEngine_Texture2D;
                        global::UnityEditor.EditorGUIUtility.SetIconForObject(obj, icon);
                        var _retCount = _context.Return();
                        return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                    }
                }
            }
            throw new global::Lua.LuaRuntimeException(_context.Thread, $"{"SetIconForObject"}: invalid argument #{_lastArgPos}: {_lastArg} ({_lastArg.Type}), expected: {_expectedType.FullName}", 2);
        });
        private static readonly global::Lua.LuaFunction _LuaEditorGUIUtility_SetIconSize = new global::Lua.LuaFunction("SetIconSize", (_context, _) =>
        {
            global::Lua.LuaValue _lastArg = default;
            global::System.Int32 _lastArgPos = default;
            global::System.Type _expectedType = default;
            var _argCount = _context.ArgumentCount;
            var _arg0 = _lastArg = _argCount > 0 ? _context.GetArgument(0) : global::Lua.LuaValue.Nil;
            _lastArgPos = 0; _expectedType = typeof(global::UnityEngine.Vector2);
            if (_arg0.TryRead<global::UnityEngine.Vector2>(out var _p0_UnityEngine_Vector2))
            {
                if (_argCount == 1)
                {
                    var size = _p0_UnityEngine_Vector2;
                    global::UnityEditor.EditorGUIUtility.SetIconSize(size);
                    var _retCount = _context.Return();
                    return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                }
            }
            throw new global::Lua.LuaRuntimeException(_context.Thread, $"{"SetIconSize"}: invalid argument #{_lastArgPos}: {_lastArg} ({_lastArg.Type}), expected: {_expectedType.FullName}", 2);
        });
        private static readonly global::Lua.LuaFunction _LuaEditorGUIUtility_SetMainWindowPosition = new global::Lua.LuaFunction("SetMainWindowPosition", (_context, _) =>
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
                    var position = _p0_UnityEngine_Rect;
                    global::UnityEditor.EditorGUIUtility.SetMainWindowPosition(position);
                    var _retCount = _context.Return();
                    return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                }
            }
            throw new global::Lua.LuaRuntimeException(_context.Thread, $"{"SetMainWindowPosition"}: invalid argument #{_lastArgPos}: {_lastArg} ({_lastArg.Type}), expected: {_expectedType.FullName}", 2);
        });
        private static readonly global::Lua.LuaFunction _LuaEditorGUIUtility_SetMenuLocalizationTestMode = new global::Lua.LuaFunction("SetMenuLocalizationTestMode", (_context, _) =>
        {
            global::Lua.LuaValue _lastArg = default;
            global::System.Int32 _lastArgPos = default;
            global::System.Type _expectedType = default;
            var _argCount = _context.ArgumentCount;
            var _arg0 = _lastArg = _argCount > 0 ? _context.GetArgument(0) : global::Lua.LuaValue.Nil;
            _lastArgPos = 0; _expectedType = typeof(global::System.Boolean);
            if (_arg0.TryRead<global::System.Boolean>(out var _p0_System_Boolean))
            {
                if (_argCount == 1)
                {
                    var onoff = _p0_System_Boolean;
                    global::UnityEditor.EditorGUIUtility.SetMenuLocalizationTestMode(onoff);
                    var _retCount = _context.Return();
                    return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                }
            }
            throw new global::Lua.LuaRuntimeException(_context.Thread, $"{"SetMenuLocalizationTestMode"}: invalid argument #{_lastArgPos}: {_lastArg} ({_lastArg.Type}), expected: {_expectedType.FullName}", 2);
        });
        private static readonly global::Lua.LuaFunction _LuaEditorGUIUtility_SetWantsMouseJumping = new global::Lua.LuaFunction("SetWantsMouseJumping", (_context, _) =>
        {
            global::Lua.LuaValue _lastArg = default;
            global::System.Int32 _lastArgPos = default;
            global::System.Type _expectedType = default;
            var _argCount = _context.ArgumentCount;
            var _arg0 = _lastArg = _argCount > 0 ? _context.GetArgument(0) : global::Lua.LuaValue.Nil;
            _lastArgPos = 0; _expectedType = typeof(global::System.Int32);
            if (_arg0.TryRead<global::System.Int32>(out var _p0_System_Int32))
            {
                if (_argCount == 1)
                {
                    var wantz = _p0_System_Int32;
                    global::UnityEditor.EditorGUIUtility.SetWantsMouseJumping(wantz);
                    var _retCount = _context.Return();
                    return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                }
            }
            throw new global::Lua.LuaRuntimeException(_context.Thread, $"{"SetWantsMouseJumping"}: invalid argument #{_lastArgPos}: {_lastArg} ({_lastArg.Type}), expected: {_expectedType.FullName}", 2);
        });
        private static readonly global::Lua.LuaFunction _LuaEditorGUIUtility_TrIconContent = new global::Lua.LuaFunction("TrIconContent", (_context, _) =>
        {
            global::Lua.LuaValue _lastArg = default;
            global::System.Int32 _lastArgPos = default;
            global::System.Type _expectedType = default;
            var _argCount = _context.ArgumentCount;
            var _arg0 = _lastArg = _argCount > 0 ? _context.GetArgument(0) : global::Lua.LuaValue.Nil;
            _lastArgPos = 0; _expectedType = typeof(global::System.String);
            if (_arg0.TryRead<global::System.String>(out var _p0_System_String))
            {
                if (_argCount == 1)
                {
                    var iconName = _p0_System_String;
                    var _ret0 = global::UnityEditor.EditorGUIUtility.TrIconContent(iconName);
                    var _factory = _context.GetObjectFactory();
                    var _lret0 = _factory.Bind(_ret0);
                    var _retCount = _context.Return(_lret0);
                    return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                }
                var _arg1 = _lastArg = _argCount > 1 ? _context.GetArgument(1) : global::Lua.LuaValue.Nil;
                _lastArgPos = 1; _expectedType = typeof(global::System.String);
                var _p1_System_String = _arg1.ReadValue<global::System.String>(default);
                {
                    if (_argCount == 2)
                    {
                        var iconName = _p0_System_String;
                        var tooltip = _p1_System_String;
                        var _ret0 = global::UnityEditor.EditorGUIUtility.TrIconContent(iconName, tooltip);
                        var _factory = _context.GetObjectFactory();
                        var _lret0 = _factory.Bind(_ret0);
                        var _retCount = _context.Return(_lret0);
                        return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                    }
                }
            }
            _lastArgPos = 0; _expectedType = typeof(global::UnityEngine.Texture);
            if (_arg0.TryRead<global::UnityEngine.Texture>(out var _p0_UnityEngine_Texture))
            {
                if (_argCount == 1)
                {
                    var icon = _p0_UnityEngine_Texture;
                    var _ret0 = global::UnityEditor.EditorGUIUtility.TrIconContent(icon);
                    var _factory = _context.GetObjectFactory();
                    var _lret0 = _factory.Bind(_ret0);
                    var _retCount = _context.Return(_lret0);
                    return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                }
                var _arg1 = _lastArg = _argCount > 1 ? _context.GetArgument(1) : global::Lua.LuaValue.Nil;
                _lastArgPos = 1; _expectedType = typeof(global::System.String);
                var _p1_System_String = _arg1.ReadValue<global::System.String>(default);
                {
                    if (_argCount == 2)
                    {
                        var icon = _p0_UnityEngine_Texture;
                        var tooltip = _p1_System_String;
                        var _ret0 = global::UnityEditor.EditorGUIUtility.TrIconContent(icon, tooltip);
                        var _factory = _context.GetObjectFactory();
                        var _lret0 = _factory.Bind(_ret0);
                        var _retCount = _context.Return(_lret0);
                        return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                    }
                }
            }
            throw new global::Lua.LuaRuntimeException(_context.Thread, $"{"TrIconContent"}: invalid argument #{_lastArgPos}: {_lastArg} ({_lastArg.Type}), expected: {_expectedType.FullName}", 2);
        });
        private static readonly global::Lua.LuaFunction _LuaEditorGUIUtility_TrTempContent = new global::Lua.LuaFunction("TrTempContent", (_context, _) =>
        {
            global::Lua.LuaValue _lastArg = default;
            global::System.Int32 _lastArgPos = default;
            global::System.Type _expectedType = default;
            var _argCount = _context.ArgumentCount;
            var _arg0 = _lastArg = _argCount > 0 ? _context.GetArgument(0) : global::Lua.LuaValue.Nil;
            _lastArgPos = 0; _expectedType = typeof(global::System.String);
            if (_arg0.TryRead<global::System.String>(out var _p0_System_String))
            {
                if (_argCount == 1)
                {
                    var t = _p0_System_String;
                    var _ret0 = global::UnityEditor.EditorGUIUtility.TrTempContent(t);
                    var _factory = _context.GetObjectFactory();
                    var _lret0 = _factory.Bind(_ret0);
                    var _retCount = _context.Return(_lret0);
                    return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                }
            }
            _lastArgPos = 0; _expectedType = typeof(global::System.String[]);
            if (_arg0.TryReadArray<global::System.String>(out var _p0_System_StringArray))
            {
                if (_argCount == 1)
                {
                    var texts = _p0_System_StringArray;
                    var _ret0 = global::UnityEditor.EditorGUIUtility.TrTempContent(texts);
                    var _factory = _context.GetObjectFactory();
                    var _lret0 = _factory.Bind(_ret0);
                    var _retCount = _context.Return(_lret0);
                    return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                }
                var _arg1 = _lastArg = _argCount > 1 ? _context.GetArgument(1) : global::Lua.LuaValue.Nil;
                _lastArgPos = 1; _expectedType = typeof(global::System.String[]);
                if (_arg1.TryReadArray<global::System.String>(out var _p1_System_StringArray))
                {
                    if (_argCount == 2)
                    {
                        var texts = _p0_System_StringArray;
                        var tooltips = _p1_System_StringArray;
                        var _ret0 = global::UnityEditor.EditorGUIUtility.TrTempContent(texts, tooltips);
                        var _factory = _context.GetObjectFactory();
                        var _lret0 = _factory.Bind(_ret0);
                        var _retCount = _context.Return(_lret0);
                        return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                    }
                }
            }
            throw new global::Lua.LuaRuntimeException(_context.Thread, $"{"TrTempContent"}: invalid argument #{_lastArgPos}: {_lastArg} ({_lastArg.Type}), expected: {_expectedType.FullName}", 2);
        });
        private static readonly global::Lua.LuaFunction _LuaEditorGUIUtility_TrTextContent = new global::Lua.LuaFunction("TrTextContent", (_context, _) =>
        {
            global::Lua.LuaValue _lastArg = default;
            global::System.Int32 _lastArgPos = default;
            global::System.Type _expectedType = default;
            var _argCount = _context.ArgumentCount;
            var _arg0 = _lastArg = _argCount > 0 ? _context.GetArgument(0) : global::Lua.LuaValue.Nil;
            _lastArgPos = 0; _expectedType = typeof(global::System.String);
            if (_arg0.TryRead<global::System.String>(out var _p0_System_String))
            {
                if (_argCount == 1)
                {
                    var text = _p0_System_String;
                    var _ret0 = global::UnityEditor.EditorGUIUtility.TrTextContent(text);
                    var _factory = _context.GetObjectFactory();
                    var _lret0 = _factory.Bind(_ret0);
                    var _retCount = _context.Return(_lret0);
                    return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                }
                var _arg1 = _lastArg = _argCount > 1 ? _context.GetArgument(1) : global::Lua.LuaValue.Nil;
                _lastArgPos = 1; _expectedType = typeof(global::UnityEngine.Texture);
                if (_arg1.TryRead<global::UnityEngine.Texture>(out var _p1_UnityEngine_Texture))
                {
                    if (_argCount == 2)
                    {
                        var text = _p0_System_String;
                        var icon = _p1_UnityEngine_Texture;
                        var _ret0 = global::UnityEditor.EditorGUIUtility.TrTextContent(text, icon);
                        var _factory = _context.GetObjectFactory();
                        var _lret0 = _factory.Bind(_ret0);
                        var _retCount = _context.Return(_lret0);
                        return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                    }
                }
                _lastArgPos = 1; _expectedType = typeof(global::System.String);
                var _p1_System_String = _arg1.ReadValue<global::System.String>(default);
                {
                    if (_argCount == 2)
                    {
                        var text = _p0_System_String;
                        var tooltip = _p1_System_String;
                        var _ret0 = global::UnityEditor.EditorGUIUtility.TrTextContent(text, tooltip);
                        var _factory = _context.GetObjectFactory();
                        var _lret0 = _factory.Bind(_ret0);
                        var _retCount = _context.Return(_lret0);
                        return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                    }
                    var _arg2 = _lastArg = _argCount > 2 ? _context.GetArgument(2) : global::Lua.LuaValue.Nil;
                    _lastArgPos = 2; _expectedType = typeof(global::System.String);
                    if (_arg2.TryRead<global::System.String>(out var _p2_System_String))
                    {
                        if (_argCount == 3)
                        {
                            var text = _p0_System_String;
                            var tooltip = _p1_System_String;
                            var iconName = _p2_System_String;
                            var _ret0 = global::UnityEditor.EditorGUIUtility.TrTextContent(text, tooltip, iconName);
                            var _factory = _context.GetObjectFactory();
                            var _lret0 = _factory.Bind(_ret0);
                            var _retCount = _context.Return(_lret0);
                            return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                        }
                        var _arg3 = _lastArg = _argCount > 3 ? _context.GetArgument(3) : global::Lua.LuaValue.Nil;
                        _lastArgPos = 3; _expectedType = typeof(global::UnityEngine.Texture);
                        if (_arg3.TryRead<global::UnityEngine.Texture>(out var _p3_UnityEngine_Texture))
                        {
                            if (_argCount == 4)
                            {
                                var key = _p0_System_String;
                                var text = _p1_System_String;
                                var tooltip = _p2_System_String;
                                var icon = _p3_UnityEngine_Texture;
                                var _ret0 = global::UnityEditor.EditorGUIUtility.TrTextContent(key, text, tooltip, icon);
                                var _factory = _context.GetObjectFactory();
                                var _lret0 = _factory.Bind(_ret0);
                                var _retCount = _context.Return(_lret0);
                                return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                            }
                        }
                    }
                    _lastArgPos = 2; _expectedType = typeof(global::UnityEngine.Texture);
                    var _p2_UnityEngine_Texture = _arg2.ReadValue<global::UnityEngine.Texture>(default);
                    {
                        if (_argCount == 3)
                        {
                            var text = _p0_System_String;
                            var tooltip = _p1_System_String;
                            var icon = _p2_UnityEngine_Texture;
                            var _ret0 = global::UnityEditor.EditorGUIUtility.TrTextContent(text, tooltip, icon);
                            var _factory = _context.GetObjectFactory();
                            var _lret0 = _factory.Bind(_ret0);
                            var _retCount = _context.Return(_lret0);
                            return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                        }
                    }
                }
            }
            throw new global::Lua.LuaRuntimeException(_context.Thread, $"{"TrTextContent"}: invalid argument #{_lastArgPos}: {_lastArg} ({_lastArg.Type}), expected: {_expectedType.FullName}", 2);
        });
        private static readonly global::Lua.LuaFunction _LuaEditorGUIUtility_TrTextContentWithIcon = new global::Lua.LuaFunction("TrTextContentWithIcon", (_context, _) =>
        {
            global::Lua.LuaValue _lastArg = default;
            global::System.Int32 _lastArgPos = default;
            global::System.Type _expectedType = default;
            var _argCount = _context.ArgumentCount;
            var _arg0 = _lastArg = _argCount > 0 ? _context.GetArgument(0) : global::Lua.LuaValue.Nil;
            _lastArgPos = 0; _expectedType = typeof(global::System.String);
            if (_arg0.TryRead<global::System.String>(out var _p0_System_String))
            {
                var _arg1 = _lastArg = _argCount > 1 ? _context.GetArgument(1) : global::Lua.LuaValue.Nil;
                _lastArgPos = 1; _expectedType = typeof(global::UnityEditor.MessageType);
                if (_arg1.TryRead<global::UnityEditor.MessageType>(out var _p1_UnityEditor_MessageType))
                {
                    if (_argCount == 2)
                    {
                        var text = _p0_System_String;
                        var messageType = _p1_UnityEditor_MessageType;
                        var _ret0 = global::UnityEditor.EditorGUIUtility.TrTextContentWithIcon(text, messageType);
                        var _factory = _context.GetObjectFactory();
                        var _lret0 = _factory.Bind(_ret0);
                        var _retCount = _context.Return(_lret0);
                        return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                    }
                }
                _lastArgPos = 1; _expectedType = typeof(global::System.String);
                if (_arg1.TryRead<global::System.String>(out var _p1_System_String))
                {
                    if (_argCount == 2)
                    {
                        var text = _p0_System_String;
                        var iconName = _p1_System_String;
                        var _ret0 = global::UnityEditor.EditorGUIUtility.TrTextContentWithIcon(text, iconName);
                        var _factory = _context.GetObjectFactory();
                        var _lret0 = _factory.Bind(_ret0);
                        var _retCount = _context.Return(_lret0);
                        return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                    }
                    var _arg2 = _lastArg = _argCount > 2 ? _context.GetArgument(2) : global::Lua.LuaValue.Nil;
                    _lastArgPos = 2; _expectedType = typeof(global::UnityEditor.MessageType);
                    if (_arg2.TryRead<global::UnityEditor.MessageType>(out var _p2_UnityEditor_MessageType))
                    {
                        if (_argCount == 3)
                        {
                            var text = _p0_System_String;
                            var tooltip = _p1_System_String;
                            var messageType = _p2_UnityEditor_MessageType;
                            var _ret0 = global::UnityEditor.EditorGUIUtility.TrTextContentWithIcon(text, tooltip, messageType);
                            var _factory = _context.GetObjectFactory();
                            var _lret0 = _factory.Bind(_ret0);
                            var _retCount = _context.Return(_lret0);
                            return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                        }
                    }
                    _lastArgPos = 2; _expectedType = typeof(global::System.String);
                    if (_arg2.TryRead<global::System.String>(out var _p2_System_String))
                    {
                        if (_argCount == 3)
                        {
                            var text = _p0_System_String;
                            var tooltip = _p1_System_String;
                            var iconName = _p2_System_String;
                            var _ret0 = global::UnityEditor.EditorGUIUtility.TrTextContentWithIcon(text, tooltip, iconName);
                            var _factory = _context.GetObjectFactory();
                            var _lret0 = _factory.Bind(_ret0);
                            var _retCount = _context.Return(_lret0);
                            return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                        }
                    }
                    _lastArgPos = 2; _expectedType = typeof(global::UnityEngine.Texture);
                    if (_arg2.TryRead<global::UnityEngine.Texture>(out var _p2_UnityEngine_Texture))
                    {
                        if (_argCount == 3)
                        {
                            var text = _p0_System_String;
                            var tooltip = _p1_System_String;
                            var icon = _p2_UnityEngine_Texture;
                            var _ret0 = global::UnityEditor.EditorGUIUtility.TrTextContentWithIcon(text, tooltip, icon);
                            var _factory = _context.GetObjectFactory();
                            var _lret0 = _factory.Bind(_ret0);
                            var _retCount = _context.Return(_lret0);
                            return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                        }
                    }
                }
                _lastArgPos = 1; _expectedType = typeof(global::UnityEngine.Texture);
                if (_arg1.TryRead<global::UnityEngine.Texture>(out var _p1_UnityEngine_Texture))
                {
                    if (_argCount == 2)
                    {
                        var text = _p0_System_String;
                        var icon = _p1_UnityEngine_Texture;
                        var _ret0 = global::UnityEditor.EditorGUIUtility.TrTextContentWithIcon(text, icon);
                        var _factory = _context.GetObjectFactory();
                        var _lret0 = _factory.Bind(_ret0);
                        var _retCount = _context.Return(_lret0);
                        return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                    }
                }
            }
            throw new global::Lua.LuaRuntimeException(_context.Thread, $"{"TrTextContentWithIcon"}: invalid argument #{_lastArgPos}: {_lastArg} ({_lastArg.Type}), expected: {_expectedType.FullName}", 2);
        });
        private static readonly global::Lua.LuaFunction __index = new(global::Lua.Runtime.Metamethods.Index, (_context, _) =>
        {
            var _this = _context.GetArgument<LuaEditorGUIUtilityType>(0);
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
            var _this = _context.GetArgument<LuaEditorGUIUtilityType>(0);
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
                case "AddCursorRect": _value = _LuaEditorGUIUtility_AddCursorRect; return true;
                case "CommandEvent": _value = _LuaEditorGUIUtility_CommandEvent; return true;
                case "DrawColorSwatch": _value = _LuaEditorGUIUtility_DrawColorSwatch; return true;
                case "DrawCurveSwatch": _value = _LuaEditorGUIUtility_DrawCurveSwatch; return true;
                case "DrawRegionSwatch": _value = _LuaEditorGUIUtility_DrawRegionSwatch; return true;
                case "FindTexture": _value = _LuaEditorGUIUtility_FindTexture; return true;
                case "GetBuiltinSkin": _value = _LuaEditorGUIUtility_GetBuiltinSkin; return true;
                case "GetIconForObject": _value = _LuaEditorGUIUtility_GetIconForObject; return true;
                case "GetIconSize": _value = _LuaEditorGUIUtility_GetIconSize; return true;
                case "GetMainWindowPosition": _value = _LuaEditorGUIUtility_GetMainWindowPosition; return true;
                case "GetObjectPickerControlID": _value = _LuaEditorGUIUtility_GetObjectPickerControlID; return true;
                case "GetObjectPickerObject": _value = _LuaEditorGUIUtility_GetObjectPickerObject; return true;
                case "HasObjectThumbnail": _value = _LuaEditorGUIUtility_HasObjectThumbnail; return true;
                case "IconContent": _value = _LuaEditorGUIUtility_IconContent; return true;
                case "IsDisplayReferencedByCameras": _value = _LuaEditorGUIUtility_IsDisplayReferencedByCameras; return true;
                case "Load": _value = _LuaEditorGUIUtility_Load; return true;
                case "LoadRequired": _value = _LuaEditorGUIUtility_LoadRequired; return true;
                case "ObjectContent": _value = _LuaEditorGUIUtility_ObjectContent; return true;
                case "PingObject": _value = _LuaEditorGUIUtility_PingObject; return true;
                case "PixelsToPoints": _value = _LuaEditorGUIUtility_PixelsToPoints; return true;
                case "PointsToPixels": _value = _LuaEditorGUIUtility_PointsToPixels; return true;
                case "QueueGameViewInputEvent": _value = _LuaEditorGUIUtility_QueueGameViewInputEvent; return true;
                case "SerializeMainMenuToString": _value = _LuaEditorGUIUtility_SerializeMainMenuToString; return true;
                case "SetIconForObject": _value = _LuaEditorGUIUtility_SetIconForObject; return true;
                case "SetIconSize": _value = _LuaEditorGUIUtility_SetIconSize; return true;
                case "SetMainWindowPosition": _value = _LuaEditorGUIUtility_SetMainWindowPosition; return true;
                case "SetMenuLocalizationTestMode": _value = _LuaEditorGUIUtility_SetMenuLocalizationTestMode; return true;
                case "SetWantsMouseJumping": _value = _LuaEditorGUIUtility_SetWantsMouseJumping; return true;
                case "TrIconContent": _value = _LuaEditorGUIUtility_TrIconContent; return true;
                case "TrTempContent": _value = _LuaEditorGUIUtility_TrTempContent; return true;
                case "TrTextContent": _value = _LuaEditorGUIUtility_TrTextContent; return true;
                case "TrTextContentWithIcon": _value = _LuaEditorGUIUtility_TrTextContentWithIcon; return true;
                case "currentViewWidth": _value = new global::Lua.LuaValue(global::UnityEditor.EditorGUIUtility.currentViewWidth); return true;
                case "editingTextField": _value = new global::Lua.LuaValue(global::UnityEditor.EditorGUIUtility.editingTextField); return true;
                case "fieldWidth": _value = new global::Lua.LuaValue(global::UnityEditor.EditorGUIUtility.fieldWidth); return true;
                case "hierarchyMode": _value = new global::Lua.LuaValue(global::UnityEditor.EditorGUIUtility.hierarchyMode); return true;
                case "isProSkin": _value = new global::Lua.LuaValue(global::UnityEditor.EditorGUIUtility.isProSkin); return true;
                case "labelWidth": _value = new global::Lua.LuaValue(global::UnityEditor.EditorGUIUtility.labelWidth); return true;
                case "pixelsPerPoint": _value = new global::Lua.LuaValue(global::UnityEditor.EditorGUIUtility.pixelsPerPoint); return true;
                case "singleLineHeight": _value = new global::Lua.LuaValue(global::UnityEditor.EditorGUIUtility.singleLineHeight); return true;
                case "standardVerticalSpacing": _value = new global::Lua.LuaValue(global::UnityEditor.EditorGUIUtility.standardVerticalSpacing); return true;
                case "systemCopyBuffer": _value = new global::Lua.LuaValue(global::UnityEditor.EditorGUIUtility.systemCopyBuffer); return true;
                case "textFieldHasSelection": _value = new global::Lua.LuaValue(global::UnityEditor.EditorGUIUtility.textFieldHasSelection); return true;
                case "whiteTexture": _value = _factory.Bind(global::UnityEditor.EditorGUIUtility.whiteTexture); return true;
                case "wideMode": _value = new global::Lua.LuaValue(global::UnityEditor.EditorGUIUtility.wideMode); return true;
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
                case "editingTextField": global::UnityEditor.EditorGUIUtility.editingTextField = _value.Read<global::System.Boolean>();  return true;
                case "fieldWidth": global::UnityEditor.EditorGUIUtility.fieldWidth = _value.Read<global::System.Single>();  return true;
                case "hierarchyMode": global::UnityEditor.EditorGUIUtility.hierarchyMode = _value.Read<global::System.Boolean>();  return true;
                case "labelWidth": global::UnityEditor.EditorGUIUtility.labelWidth = _value.Read<global::System.Single>();  return true;
                case "systemCopyBuffer": global::UnityEditor.EditorGUIUtility.systemCopyBuffer = _value.Read<global::System.String>();  return true;
                case "wideMode": global::UnityEditor.EditorGUIUtility.wideMode = _value.Read<global::System.Boolean>();  return true;
                default: return false;
            }
        }
    }
}
#pragma warning restore 0109, 0162, 0168, 0219
#endif
