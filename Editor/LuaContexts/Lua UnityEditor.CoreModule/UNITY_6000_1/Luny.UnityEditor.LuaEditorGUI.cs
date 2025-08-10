
// --------------------------------------------------------------
// GENERATED FILE ----> DO NOT EDIT <---- CHANGES WILL BE LOST !!
// --------------------------------------------------------------

#if UNITY_6000_1_OR_NEWER && !(UNITY_6000_2_OR_NEWER)
#pragma warning disable 0109, 0162, 0168, 0219
using Luny;

namespace Luny.UnityEditor
{
    public sealed class LuaEditorGUI : global::Luny.ILuaObject<global::UnityEditor.EditorGUI>
    {
        public new static global::Lua.LuaValue Bind(global::UnityEditor.EditorGUI instance) => new LuaEditorGUI(instance);
        public new static global::Lua.LuaValue Bind(global::System.Object instance) => Bind((global::UnityEditor.EditorGUI)instance);
        public new static global::Lua.LuaValue Bind(global::System.Collections.Generic.IList<global::UnityEditor.EditorGUI> instances) =>
            new global::Luny.LuaList<global::UnityEditor.EditorGUI>(instances);
        public new static global::Lua.LuaValue Bind(global::System.Collections.Generic.IList<global::System.Object> instances) =>
            new global::Luny.LuaList<global::UnityEditor.EditorGUI>(instances);
        private LuaEditorGUI(global::UnityEditor.EditorGUI instance) => m_Instance = instance;
        public static implicit operator global::Lua.LuaValue(LuaEditorGUI value) => new(value);
        private global::UnityEditor.EditorGUI m_Instance;
        public global::UnityEditor.EditorGUI Instance => m_Instance;
        public new global::System.Type BindType => typeof(global::UnityEditor.EditorGUI);
        private static global::Lua.LuaTable s_Metatable;
        public global::Lua.LuaTable Metatable
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

        private static readonly global::Lua.LuaFunction __index = new(global::Lua.Runtime.Metamethods.Index, (_context, _) =>
        {
            var _this = _context.GetArgument<LuaEditorGUI>(0);
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
            var _this = _context.GetArgument<LuaEditorGUI>(0);
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
    public sealed class LuaEditorGUIType : global::Luny.ILuaStatic
    {
        public static global::Lua.LuaValue Bind() => new LuaEditorGUIType();
        private LuaEditorGUIType() {}
        public static implicit operator global::Lua.LuaValue(LuaEditorGUIType value) => new(value);
        public global::System.Type BindType => typeof(global::UnityEditor.EditorGUI);
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

        private static readonly global::Lua.LuaFunction _LuaEditorGUI_new = new global::Lua.LuaFunction(".ctor", (_context, _) =>
        {
            global::Lua.LuaValue _lastArg = default;
            global::System.Int32 _lastArgPos = default;
            global::System.Type _expectedType = default;
            var _argCount = _context.ArgumentCount;
            if (_argCount == 0)
            {
                var _ret0 = new global::UnityEditor.EditorGUI();
                var _factory = _context.GetObjectFactory();
                var _lret0 = _factory.Bind(_ret0);
                var _retCount = _context.Return(_lret0);
                return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
            }
            throw new global::Lua.LuaRuntimeException(_context.Thread, $"{".ctor"}: invalid argument #{_lastArgPos}: {_lastArg} ({_lastArg.Type}), expected: {_expectedType.FullName}", 2);
        });
        private static readonly global::Lua.LuaFunction _LuaEditorGUI_BeginChangeCheck = new global::Lua.LuaFunction("BeginChangeCheck", (_context, _) =>
        {
            global::Lua.LuaValue _lastArg = default;
            global::System.Int32 _lastArgPos = default;
            global::System.Type _expectedType = default;
            var _argCount = _context.ArgumentCount;
            if (_argCount == 0)
            {
                global::UnityEditor.EditorGUI.BeginChangeCheck();
                var _retCount = _context.Return();
                return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
            }
            throw new global::Lua.LuaRuntimeException(_context.Thread, $"{"BeginChangeCheck"}: invalid argument #{_lastArgPos}: {_lastArg} ({_lastArg.Type}), expected: {_expectedType.FullName}", 2);
        });
        private static readonly global::Lua.LuaFunction _LuaEditorGUI_BeginDisabledGroup = new global::Lua.LuaFunction("BeginDisabledGroup", (_context, _) =>
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
                    var disabled = _p0_System_Boolean;
                    global::UnityEditor.EditorGUI.BeginDisabledGroup(disabled);
                    var _retCount = _context.Return();
                    return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                }
            }
            throw new global::Lua.LuaRuntimeException(_context.Thread, $"{"BeginDisabledGroup"}: invalid argument #{_lastArgPos}: {_lastArg} ({_lastArg.Type}), expected: {_expectedType.FullName}", 2);
        });
        private static readonly global::Lua.LuaFunction _LuaEditorGUI_BeginProperty = new global::Lua.LuaFunction("BeginProperty", (_context, _) =>
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
                _lastArgPos = 1; _expectedType = typeof(global::UnityEngine.GUIContent);
                if (_arg1.TryRead<global::UnityEngine.GUIContent>(out var _p1_UnityEngine_GUIContent))
                {
                    var _arg2 = _lastArg = _argCount > 2 ? _context.GetArgument(2) : global::Lua.LuaValue.Nil;
                    _lastArgPos = 2; _expectedType = typeof(global::Luny.UnityEditor.LuaSerializedProperty);
                    if (_arg2.TryRead<global::Luny.UnityEditor.LuaSerializedProperty>(out var _p2_UnityEditor_SerializedProperty))
                    {
                        if (_argCount == 3)
                        {
                            var totalPosition = _p0_UnityEngine_Rect;
                            var label = _p1_UnityEngine_GUIContent;
                            var property = _p2_UnityEditor_SerializedProperty.Instance;
                            var _ret0 = global::UnityEditor.EditorGUI.BeginProperty(totalPosition, label, property);
                            var _factory = _context.GetObjectFactory();
                            var _lret0 = _factory.Bind(_ret0);
                            var _retCount = _context.Return(_lret0);
                            return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                        }
                    }
                }
            }
            throw new global::Lua.LuaRuntimeException(_context.Thread, $"{"BeginProperty"}: invalid argument #{_lastArgPos}: {_lastArg} ({_lastArg.Type}), expected: {_expectedType.FullName}", 2);
        });
        private static readonly global::Lua.LuaFunction _LuaEditorGUI_BoundsField = new global::Lua.LuaFunction("BoundsField", (_context, _) =>
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
                _lastArgPos = 1; _expectedType = typeof(global::UnityEngine.Bounds);
                if (_arg1.TryRead<global::UnityEngine.Bounds>(out var _p1_UnityEngine_Bounds))
                {
                    if (_argCount == 2)
                    {
                        var position = _p0_UnityEngine_Rect;
                        var value = _p1_UnityEngine_Bounds;
                        var _ret0 = global::UnityEditor.EditorGUI.BoundsField(position, value);
                        var _factory = _context.GetObjectFactory();
                        var _lret0 = _factory.Bind(_ret0);
                        var _retCount = _context.Return(_lret0);
                        return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                    }
                }
                _lastArgPos = 1; _expectedType = typeof(global::System.String);
                if (_arg1.TryRead<global::System.String>(out var _p1_System_String))
                {
                    var _arg2 = _lastArg = _argCount > 2 ? _context.GetArgument(2) : global::Lua.LuaValue.Nil;
                    _lastArgPos = 2; _expectedType = typeof(global::UnityEngine.Bounds);
                    if (_arg2.TryRead<global::UnityEngine.Bounds>(out var _p2_UnityEngine_Bounds))
                    {
                        if (_argCount == 3)
                        {
                            var position = _p0_UnityEngine_Rect;
                            var label = _p1_System_String;
                            var value = _p2_UnityEngine_Bounds;
                            var _ret0 = global::UnityEditor.EditorGUI.BoundsField(position, label, value);
                            var _factory = _context.GetObjectFactory();
                            var _lret0 = _factory.Bind(_ret0);
                            var _retCount = _context.Return(_lret0);
                            return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                        }
                    }
                }
                _lastArgPos = 1; _expectedType = typeof(global::UnityEngine.GUIContent);
                if (_arg1.TryRead<global::UnityEngine.GUIContent>(out var _p1_UnityEngine_GUIContent))
                {
                    var _arg2 = _lastArg = _argCount > 2 ? _context.GetArgument(2) : global::Lua.LuaValue.Nil;
                    _lastArgPos = 2; _expectedType = typeof(global::UnityEngine.Bounds);
                    if (_arg2.TryRead<global::UnityEngine.Bounds>(out var _p2_UnityEngine_Bounds))
                    {
                        if (_argCount == 3)
                        {
                            var position = _p0_UnityEngine_Rect;
                            var label = _p1_UnityEngine_GUIContent;
                            var value = _p2_UnityEngine_Bounds;
                            var _ret0 = global::UnityEditor.EditorGUI.BoundsField(position, label, value);
                            var _factory = _context.GetObjectFactory();
                            var _lret0 = _factory.Bind(_ret0);
                            var _retCount = _context.Return(_lret0);
                            return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                        }
                    }
                }
            }
            throw new global::Lua.LuaRuntimeException(_context.Thread, $"{"BoundsField"}: invalid argument #{_lastArgPos}: {_lastArg} ({_lastArg.Type}), expected: {_expectedType.FullName}", 2);
        });
        private static readonly global::Lua.LuaFunction _LuaEditorGUI_BoundsIntField = new global::Lua.LuaFunction("BoundsIntField", (_context, _) =>
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
                _lastArgPos = 1; _expectedType = typeof(global::UnityEngine.BoundsInt);
                if (_arg1.TryRead<global::UnityEngine.BoundsInt>(out var _p1_UnityEngine_BoundsInt))
                {
                    if (_argCount == 2)
                    {
                        var position = _p0_UnityEngine_Rect;
                        var value = _p1_UnityEngine_BoundsInt;
                        var _ret0 = global::UnityEditor.EditorGUI.BoundsIntField(position, value);
                        var _factory = _context.GetObjectFactory();
                        var _lret0 = _factory.Bind(_ret0);
                        var _retCount = _context.Return(_lret0);
                        return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                    }
                }
                _lastArgPos = 1; _expectedType = typeof(global::System.String);
                if (_arg1.TryRead<global::System.String>(out var _p1_System_String))
                {
                    var _arg2 = _lastArg = _argCount > 2 ? _context.GetArgument(2) : global::Lua.LuaValue.Nil;
                    _lastArgPos = 2; _expectedType = typeof(global::UnityEngine.BoundsInt);
                    if (_arg2.TryRead<global::UnityEngine.BoundsInt>(out var _p2_UnityEngine_BoundsInt))
                    {
                        if (_argCount == 3)
                        {
                            var position = _p0_UnityEngine_Rect;
                            var label = _p1_System_String;
                            var value = _p2_UnityEngine_BoundsInt;
                            var _ret0 = global::UnityEditor.EditorGUI.BoundsIntField(position, label, value);
                            var _factory = _context.GetObjectFactory();
                            var _lret0 = _factory.Bind(_ret0);
                            var _retCount = _context.Return(_lret0);
                            return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                        }
                    }
                }
                _lastArgPos = 1; _expectedType = typeof(global::UnityEngine.GUIContent);
                if (_arg1.TryRead<global::UnityEngine.GUIContent>(out var _p1_UnityEngine_GUIContent))
                {
                    var _arg2 = _lastArg = _argCount > 2 ? _context.GetArgument(2) : global::Lua.LuaValue.Nil;
                    _lastArgPos = 2; _expectedType = typeof(global::UnityEngine.BoundsInt);
                    if (_arg2.TryRead<global::UnityEngine.BoundsInt>(out var _p2_UnityEngine_BoundsInt))
                    {
                        if (_argCount == 3)
                        {
                            var position = _p0_UnityEngine_Rect;
                            var label = _p1_UnityEngine_GUIContent;
                            var value = _p2_UnityEngine_BoundsInt;
                            var _ret0 = global::UnityEditor.EditorGUI.BoundsIntField(position, label, value);
                            var _factory = _context.GetObjectFactory();
                            var _lret0 = _factory.Bind(_ret0);
                            var _retCount = _context.Return(_lret0);
                            return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                        }
                    }
                }
            }
            throw new global::Lua.LuaRuntimeException(_context.Thread, $"{"BoundsIntField"}: invalid argument #{_lastArgPos}: {_lastArg} ({_lastArg.Type}), expected: {_expectedType.FullName}", 2);
        });
        private static readonly global::Lua.LuaFunction _LuaEditorGUI_ColorField = new global::Lua.LuaFunction("ColorField", (_context, _) =>
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
                        var value = _p1_UnityEngine_Color;
                        var _ret0 = global::UnityEditor.EditorGUI.ColorField(position, value);
                        var _factory = _context.GetObjectFactory();
                        var _lret0 = _factory.Bind(_ret0);
                        var _retCount = _context.Return(_lret0);
                        return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                    }
                }
                _lastArgPos = 1; _expectedType = typeof(global::System.String);
                if (_arg1.TryRead<global::System.String>(out var _p1_System_String))
                {
                    var _arg2 = _lastArg = _argCount > 2 ? _context.GetArgument(2) : global::Lua.LuaValue.Nil;
                    _lastArgPos = 2; _expectedType = typeof(global::UnityEngine.Color);
                    if (_arg2.TryRead<global::UnityEngine.Color>(out var _p2_UnityEngine_Color))
                    {
                        if (_argCount == 3)
                        {
                            var position = _p0_UnityEngine_Rect;
                            var label = _p1_System_String;
                            var value = _p2_UnityEngine_Color;
                            var _ret0 = global::UnityEditor.EditorGUI.ColorField(position, label, value);
                            var _factory = _context.GetObjectFactory();
                            var _lret0 = _factory.Bind(_ret0);
                            var _retCount = _context.Return(_lret0);
                            return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                        }
                    }
                }
                _lastArgPos = 1; _expectedType = typeof(global::UnityEngine.GUIContent);
                if (_arg1.TryRead<global::UnityEngine.GUIContent>(out var _p1_UnityEngine_GUIContent))
                {
                    var _arg2 = _lastArg = _argCount > 2 ? _context.GetArgument(2) : global::Lua.LuaValue.Nil;
                    _lastArgPos = 2; _expectedType = typeof(global::UnityEngine.Color);
                    if (_arg2.TryRead<global::UnityEngine.Color>(out var _p2_UnityEngine_Color))
                    {
                        if (_argCount == 3)
                        {
                            var position = _p0_UnityEngine_Rect;
                            var label = _p1_UnityEngine_GUIContent;
                            var value = _p2_UnityEngine_Color;
                            var _ret0 = global::UnityEditor.EditorGUI.ColorField(position, label, value);
                            var _factory = _context.GetObjectFactory();
                            var _lret0 = _factory.Bind(_ret0);
                            var _retCount = _context.Return(_lret0);
                            return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                        }
                        var _arg3 = _lastArg = _argCount > 3 ? _context.GetArgument(3) : global::Lua.LuaValue.Nil;
                        _lastArgPos = 3; _expectedType = typeof(global::System.Boolean);
                        if (_arg3.TryRead<global::System.Boolean>(out var _p3_System_Boolean))
                        {
                            var _arg4 = _lastArg = _argCount > 4 ? _context.GetArgument(4) : global::Lua.LuaValue.Nil;
                            _lastArgPos = 4; _expectedType = typeof(global::System.Boolean);
                            if (_arg4.TryRead<global::System.Boolean>(out var _p4_System_Boolean))
                            {
                                var _arg5 = _lastArg = _argCount > 5 ? _context.GetArgument(5) : global::Lua.LuaValue.Nil;
                                _lastArgPos = 5; _expectedType = typeof(global::System.Boolean);
                                if (_arg5.TryRead<global::System.Boolean>(out var _p5_System_Boolean))
                                {
                                    if (_argCount == 6)
                                    {
                                        var position = _p0_UnityEngine_Rect;
                                        var label = _p1_UnityEngine_GUIContent;
                                        var value = _p2_UnityEngine_Color;
                                        var showEyedropper = _p3_System_Boolean;
                                        var showAlpha = _p4_System_Boolean;
                                        var hdr = _p5_System_Boolean;
                                        var _ret0 = global::UnityEditor.EditorGUI.ColorField(position, label, value, showEyedropper, showAlpha, hdr);
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
            throw new global::Lua.LuaRuntimeException(_context.Thread, $"{"ColorField"}: invalid argument #{_lastArgPos}: {_lastArg} ({_lastArg.Type}), expected: {_expectedType.FullName}", 2);
        });
        private static readonly global::Lua.LuaFunction _LuaEditorGUI_CurveField = new global::Lua.LuaFunction("CurveField", (_context, _) =>
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
                    if (_argCount == 2)
                    {
                        var position = _p0_UnityEngine_Rect;
                        var value = _p1_UnityEngine_AnimationCurve;
                        var _ret0 = global::UnityEditor.EditorGUI.CurveField(position, value);
                        var _factory = _context.GetObjectFactory();
                        var _lret0 = _factory.Bind(_ret0);
                        var _retCount = _context.Return(_lret0);
                        return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                    }
                    var _arg2 = _lastArg = _argCount > 2 ? _context.GetArgument(2) : global::Lua.LuaValue.Nil;
                    _lastArgPos = 2; _expectedType = typeof(global::UnityEngine.Color);
                    if (_arg2.TryRead<global::UnityEngine.Color>(out var _p2_UnityEngine_Color))
                    {
                        var _arg3 = _lastArg = _argCount > 3 ? _context.GetArgument(3) : global::Lua.LuaValue.Nil;
                        _lastArgPos = 3; _expectedType = typeof(global::UnityEngine.Rect);
                        if (_arg3.TryRead<global::UnityEngine.Rect>(out var _p3_UnityEngine_Rect))
                        {
                            if (_argCount == 4)
                            {
                                var position = _p0_UnityEngine_Rect;
                                var value = _p1_UnityEngine_AnimationCurve;
                                var color = _p2_UnityEngine_Color;
                                var ranges = _p3_UnityEngine_Rect;
                                var _ret0 = global::UnityEditor.EditorGUI.CurveField(position, value, color, ranges);
                                var _factory = _context.GetObjectFactory();
                                var _lret0 = _factory.Bind(_ret0);
                                var _retCount = _context.Return(_lret0);
                                return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                            }
                        }
                    }
                }
                _lastArgPos = 1; _expectedType = typeof(global::System.String);
                if (_arg1.TryRead<global::System.String>(out var _p1_System_String))
                {
                    var _arg2 = _lastArg = _argCount > 2 ? _context.GetArgument(2) : global::Lua.LuaValue.Nil;
                    _lastArgPos = 2; _expectedType = typeof(global::UnityEngine.AnimationCurve);
                    if (_arg2.TryRead<global::UnityEngine.AnimationCurve>(out var _p2_UnityEngine_AnimationCurve))
                    {
                        if (_argCount == 3)
                        {
                            var position = _p0_UnityEngine_Rect;
                            var label = _p1_System_String;
                            var value = _p2_UnityEngine_AnimationCurve;
                            var _ret0 = global::UnityEditor.EditorGUI.CurveField(position, label, value);
                            var _factory = _context.GetObjectFactory();
                            var _lret0 = _factory.Bind(_ret0);
                            var _retCount = _context.Return(_lret0);
                            return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                        }
                        var _arg3 = _lastArg = _argCount > 3 ? _context.GetArgument(3) : global::Lua.LuaValue.Nil;
                        _lastArgPos = 3; _expectedType = typeof(global::UnityEngine.Color);
                        if (_arg3.TryRead<global::UnityEngine.Color>(out var _p3_UnityEngine_Color))
                        {
                            var _arg4 = _lastArg = _argCount > 4 ? _context.GetArgument(4) : global::Lua.LuaValue.Nil;
                            _lastArgPos = 4; _expectedType = typeof(global::UnityEngine.Rect);
                            if (_arg4.TryRead<global::UnityEngine.Rect>(out var _p4_UnityEngine_Rect))
                            {
                                if (_argCount == 5)
                                {
                                    var position = _p0_UnityEngine_Rect;
                                    var label = _p1_System_String;
                                    var value = _p2_UnityEngine_AnimationCurve;
                                    var color = _p3_UnityEngine_Color;
                                    var ranges = _p4_UnityEngine_Rect;
                                    var _ret0 = global::UnityEditor.EditorGUI.CurveField(position, label, value, color, ranges);
                                    var _factory = _context.GetObjectFactory();
                                    var _lret0 = _factory.Bind(_ret0);
                                    var _retCount = _context.Return(_lret0);
                                    return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                                }
                            }
                        }
                    }
                }
                _lastArgPos = 1; _expectedType = typeof(global::UnityEngine.GUIContent);
                if (_arg1.TryRead<global::UnityEngine.GUIContent>(out var _p1_UnityEngine_GUIContent))
                {
                    var _arg2 = _lastArg = _argCount > 2 ? _context.GetArgument(2) : global::Lua.LuaValue.Nil;
                    _lastArgPos = 2; _expectedType = typeof(global::UnityEngine.AnimationCurve);
                    if (_arg2.TryRead<global::UnityEngine.AnimationCurve>(out var _p2_UnityEngine_AnimationCurve))
                    {
                        if (_argCount == 3)
                        {
                            var position = _p0_UnityEngine_Rect;
                            var label = _p1_UnityEngine_GUIContent;
                            var value = _p2_UnityEngine_AnimationCurve;
                            var _ret0 = global::UnityEditor.EditorGUI.CurveField(position, label, value);
                            var _factory = _context.GetObjectFactory();
                            var _lret0 = _factory.Bind(_ret0);
                            var _retCount = _context.Return(_lret0);
                            return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                        }
                        var _arg3 = _lastArg = _argCount > 3 ? _context.GetArgument(3) : global::Lua.LuaValue.Nil;
                        _lastArgPos = 3; _expectedType = typeof(global::UnityEngine.Color);
                        if (_arg3.TryRead<global::UnityEngine.Color>(out var _p3_UnityEngine_Color))
                        {
                            var _arg4 = _lastArg = _argCount > 4 ? _context.GetArgument(4) : global::Lua.LuaValue.Nil;
                            _lastArgPos = 4; _expectedType = typeof(global::UnityEngine.Rect);
                            if (_arg4.TryRead<global::UnityEngine.Rect>(out var _p4_UnityEngine_Rect))
                            {
                                if (_argCount == 5)
                                {
                                    var position = _p0_UnityEngine_Rect;
                                    var label = _p1_UnityEngine_GUIContent;
                                    var value = _p2_UnityEngine_AnimationCurve;
                                    var color = _p3_UnityEngine_Color;
                                    var ranges = _p4_UnityEngine_Rect;
                                    var _ret0 = global::UnityEditor.EditorGUI.CurveField(position, label, value, color, ranges);
                                    var _factory = _context.GetObjectFactory();
                                    var _lret0 = _factory.Bind(_ret0);
                                    var _retCount = _context.Return(_lret0);
                                    return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                                }
                            }
                        }
                    }
                }
                _lastArgPos = 1; _expectedType = typeof(global::Luny.UnityEditor.LuaSerializedProperty);
                if (_arg1.TryRead<global::Luny.UnityEditor.LuaSerializedProperty>(out var _p1_UnityEditor_SerializedProperty))
                {
                    var _arg2 = _lastArg = _argCount > 2 ? _context.GetArgument(2) : global::Lua.LuaValue.Nil;
                    _lastArgPos = 2; _expectedType = typeof(global::UnityEngine.Color);
                    if (_arg2.TryRead<global::UnityEngine.Color>(out var _p2_UnityEngine_Color))
                    {
                        var _arg3 = _lastArg = _argCount > 3 ? _context.GetArgument(3) : global::Lua.LuaValue.Nil;
                        _lastArgPos = 3; _expectedType = typeof(global::UnityEngine.Rect);
                        if (_arg3.TryRead<global::UnityEngine.Rect>(out var _p3_UnityEngine_Rect))
                        {
                            if (_argCount == 4)
                            {
                                var position = _p0_UnityEngine_Rect;
                                var property = _p1_UnityEditor_SerializedProperty.Instance;
                                var color = _p2_UnityEngine_Color;
                                var ranges = _p3_UnityEngine_Rect;
                                global::UnityEditor.EditorGUI.CurveField(position, property, color, ranges);
                                var _retCount = _context.Return();
                                return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                            }
                            var _arg4 = _lastArg = _argCount > 4 ? _context.GetArgument(4) : global::Lua.LuaValue.Nil;
                            _lastArgPos = 4; _expectedType = typeof(global::UnityEngine.GUIContent);
                            if (_arg4.TryRead<global::UnityEngine.GUIContent>(out var _p4_UnityEngine_GUIContent))
                            {
                                if (_argCount == 5)
                                {
                                    var position = _p0_UnityEngine_Rect;
                                    var property = _p1_UnityEditor_SerializedProperty.Instance;
                                    var color = _p2_UnityEngine_Color;
                                    var ranges = _p3_UnityEngine_Rect;
                                    var label = _p4_UnityEngine_GUIContent;
                                    global::UnityEditor.EditorGUI.CurveField(position, property, color, ranges, label);
                                    var _retCount = _context.Return();
                                    return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                                }
                            }
                        }
                    }
                }
            }
            throw new global::Lua.LuaRuntimeException(_context.Thread, $"{"CurveField"}: invalid argument #{_lastArgPos}: {_lastArg} ({_lastArg.Type}), expected: {_expectedType.FullName}", 2);
        });
        private static readonly global::Lua.LuaFunction _LuaEditorGUI_DelayedDoubleField = new global::Lua.LuaFunction("DelayedDoubleField", (_context, _) =>
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
                _lastArgPos = 1; _expectedType = typeof(global::System.Double);
                if (_arg1.TryRead<global::System.Double>(out var _p1_System_Double))
                {
                    if (_argCount == 2)
                    {
                        var position = _p0_UnityEngine_Rect;
                        var value = _p1_System_Double;
                        var _ret0 = global::UnityEditor.EditorGUI.DelayedDoubleField(position, value);
                        var _lret0 = new global::Lua.LuaValue(_ret0);
                        var _retCount = _context.Return(_lret0);
                        return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                    }
                    var _arg2 = _lastArg = _argCount > 2 ? _context.GetArgument(2) : global::Lua.LuaValue.Nil;
                    _lastArgPos = 2; _expectedType = typeof(global::UnityEngine.GUIStyle);
                    if (_arg2.TryRead<global::UnityEngine.GUIStyle>(out var _p2_UnityEngine_GUIStyle))
                    {
                        if (_argCount == 3)
                        {
                            var position = _p0_UnityEngine_Rect;
                            var value = _p1_System_Double;
                            var style = _p2_UnityEngine_GUIStyle;
                            var _ret0 = global::UnityEditor.EditorGUI.DelayedDoubleField(position, value, style);
                            var _lret0 = new global::Lua.LuaValue(_ret0);
                            var _retCount = _context.Return(_lret0);
                            return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                        }
                    }
                }
                _lastArgPos = 1; _expectedType = typeof(global::System.String);
                if (_arg1.TryRead<global::System.String>(out var _p1_System_String))
                {
                    var _arg2 = _lastArg = _argCount > 2 ? _context.GetArgument(2) : global::Lua.LuaValue.Nil;
                    _lastArgPos = 2; _expectedType = typeof(global::System.Double);
                    if (_arg2.TryRead<global::System.Double>(out var _p2_System_Double))
                    {
                        if (_argCount == 3)
                        {
                            var position = _p0_UnityEngine_Rect;
                            var label = _p1_System_String;
                            var value = _p2_System_Double;
                            var _ret0 = global::UnityEditor.EditorGUI.DelayedDoubleField(position, label, value);
                            var _lret0 = new global::Lua.LuaValue(_ret0);
                            var _retCount = _context.Return(_lret0);
                            return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                        }
                        var _arg3 = _lastArg = _argCount > 3 ? _context.GetArgument(3) : global::Lua.LuaValue.Nil;
                        _lastArgPos = 3; _expectedType = typeof(global::UnityEngine.GUIStyle);
                        if (_arg3.TryRead<global::UnityEngine.GUIStyle>(out var _p3_UnityEngine_GUIStyle))
                        {
                            if (_argCount == 4)
                            {
                                var position = _p0_UnityEngine_Rect;
                                var label = _p1_System_String;
                                var value = _p2_System_Double;
                                var style = _p3_UnityEngine_GUIStyle;
                                var _ret0 = global::UnityEditor.EditorGUI.DelayedDoubleField(position, label, value, style);
                                var _lret0 = new global::Lua.LuaValue(_ret0);
                                var _retCount = _context.Return(_lret0);
                                return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                            }
                        }
                    }
                }
                _lastArgPos = 1; _expectedType = typeof(global::UnityEngine.GUIContent);
                if (_arg1.TryRead<global::UnityEngine.GUIContent>(out var _p1_UnityEngine_GUIContent))
                {
                    var _arg2 = _lastArg = _argCount > 2 ? _context.GetArgument(2) : global::Lua.LuaValue.Nil;
                    _lastArgPos = 2; _expectedType = typeof(global::System.Double);
                    if (_arg2.TryRead<global::System.Double>(out var _p2_System_Double))
                    {
                        if (_argCount == 3)
                        {
                            var position = _p0_UnityEngine_Rect;
                            var label = _p1_UnityEngine_GUIContent;
                            var value = _p2_System_Double;
                            var _ret0 = global::UnityEditor.EditorGUI.DelayedDoubleField(position, label, value);
                            var _lret0 = new global::Lua.LuaValue(_ret0);
                            var _retCount = _context.Return(_lret0);
                            return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                        }
                        var _arg3 = _lastArg = _argCount > 3 ? _context.GetArgument(3) : global::Lua.LuaValue.Nil;
                        _lastArgPos = 3; _expectedType = typeof(global::UnityEngine.GUIStyle);
                        if (_arg3.TryRead<global::UnityEngine.GUIStyle>(out var _p3_UnityEngine_GUIStyle))
                        {
                            if (_argCount == 4)
                            {
                                var position = _p0_UnityEngine_Rect;
                                var label = _p1_UnityEngine_GUIContent;
                                var value = _p2_System_Double;
                                var style = _p3_UnityEngine_GUIStyle;
                                var _ret0 = global::UnityEditor.EditorGUI.DelayedDoubleField(position, label, value, style);
                                var _lret0 = new global::Lua.LuaValue(_ret0);
                                var _retCount = _context.Return(_lret0);
                                return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                            }
                        }
                    }
                }
            }
            throw new global::Lua.LuaRuntimeException(_context.Thread, $"{"DelayedDoubleField"}: invalid argument #{_lastArgPos}: {_lastArg} ({_lastArg.Type}), expected: {_expectedType.FullName}", 2);
        });
        private static readonly global::Lua.LuaFunction _LuaEditorGUI_DelayedFloatField = new global::Lua.LuaFunction("DelayedFloatField", (_context, _) =>
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
                _lastArgPos = 1; _expectedType = typeof(global::System.Single);
                if (_arg1.TryRead<global::System.Single>(out var _p1_System_Single))
                {
                    if (_argCount == 2)
                    {
                        var position = _p0_UnityEngine_Rect;
                        var value = _p1_System_Single;
                        var _ret0 = global::UnityEditor.EditorGUI.DelayedFloatField(position, value);
                        var _lret0 = new global::Lua.LuaValue(_ret0);
                        var _retCount = _context.Return(_lret0);
                        return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                    }
                    var _arg2 = _lastArg = _argCount > 2 ? _context.GetArgument(2) : global::Lua.LuaValue.Nil;
                    _lastArgPos = 2; _expectedType = typeof(global::UnityEngine.GUIStyle);
                    if (_arg2.TryRead<global::UnityEngine.GUIStyle>(out var _p2_UnityEngine_GUIStyle))
                    {
                        if (_argCount == 3)
                        {
                            var position = _p0_UnityEngine_Rect;
                            var value = _p1_System_Single;
                            var style = _p2_UnityEngine_GUIStyle;
                            var _ret0 = global::UnityEditor.EditorGUI.DelayedFloatField(position, value, style);
                            var _lret0 = new global::Lua.LuaValue(_ret0);
                            var _retCount = _context.Return(_lret0);
                            return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                        }
                    }
                }
                _lastArgPos = 1; _expectedType = typeof(global::Luny.UnityEditor.LuaSerializedProperty);
                if (_arg1.TryRead<global::Luny.UnityEditor.LuaSerializedProperty>(out var _p1_UnityEditor_SerializedProperty))
                {
                    if (_argCount == 2)
                    {
                        var position = _p0_UnityEngine_Rect;
                        var property = _p1_UnityEditor_SerializedProperty.Instance;
                        global::UnityEditor.EditorGUI.DelayedFloatField(position, property);
                        var _retCount = _context.Return();
                        return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                    }
                    var _arg2 = _lastArg = _argCount > 2 ? _context.GetArgument(2) : global::Lua.LuaValue.Nil;
                    _lastArgPos = 2; _expectedType = typeof(global::UnityEngine.GUIContent);
                    if (_arg2.TryRead<global::UnityEngine.GUIContent>(out var _p2_UnityEngine_GUIContent))
                    {
                        if (_argCount == 3)
                        {
                            var position = _p0_UnityEngine_Rect;
                            var property = _p1_UnityEditor_SerializedProperty.Instance;
                            var label = _p2_UnityEngine_GUIContent;
                            global::UnityEditor.EditorGUI.DelayedFloatField(position, property, label);
                            var _retCount = _context.Return();
                            return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                        }
                    }
                }
                _lastArgPos = 1; _expectedType = typeof(global::System.String);
                if (_arg1.TryRead<global::System.String>(out var _p1_System_String))
                {
                    var _arg2 = _lastArg = _argCount > 2 ? _context.GetArgument(2) : global::Lua.LuaValue.Nil;
                    _lastArgPos = 2; _expectedType = typeof(global::System.Single);
                    if (_arg2.TryRead<global::System.Single>(out var _p2_System_Single))
                    {
                        if (_argCount == 3)
                        {
                            var position = _p0_UnityEngine_Rect;
                            var label = _p1_System_String;
                            var value = _p2_System_Single;
                            var _ret0 = global::UnityEditor.EditorGUI.DelayedFloatField(position, label, value);
                            var _lret0 = new global::Lua.LuaValue(_ret0);
                            var _retCount = _context.Return(_lret0);
                            return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                        }
                        var _arg3 = _lastArg = _argCount > 3 ? _context.GetArgument(3) : global::Lua.LuaValue.Nil;
                        _lastArgPos = 3; _expectedType = typeof(global::UnityEngine.GUIStyle);
                        if (_arg3.TryRead<global::UnityEngine.GUIStyle>(out var _p3_UnityEngine_GUIStyle))
                        {
                            if (_argCount == 4)
                            {
                                var position = _p0_UnityEngine_Rect;
                                var label = _p1_System_String;
                                var value = _p2_System_Single;
                                var style = _p3_UnityEngine_GUIStyle;
                                var _ret0 = global::UnityEditor.EditorGUI.DelayedFloatField(position, label, value, style);
                                var _lret0 = new global::Lua.LuaValue(_ret0);
                                var _retCount = _context.Return(_lret0);
                                return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                            }
                        }
                    }
                }
                _lastArgPos = 1; _expectedType = typeof(global::UnityEngine.GUIContent);
                if (_arg1.TryRead<global::UnityEngine.GUIContent>(out var _p1_UnityEngine_GUIContent))
                {
                    var _arg2 = _lastArg = _argCount > 2 ? _context.GetArgument(2) : global::Lua.LuaValue.Nil;
                    _lastArgPos = 2; _expectedType = typeof(global::System.Single);
                    if (_arg2.TryRead<global::System.Single>(out var _p2_System_Single))
                    {
                        if (_argCount == 3)
                        {
                            var position = _p0_UnityEngine_Rect;
                            var label = _p1_UnityEngine_GUIContent;
                            var value = _p2_System_Single;
                            var _ret0 = global::UnityEditor.EditorGUI.DelayedFloatField(position, label, value);
                            var _lret0 = new global::Lua.LuaValue(_ret0);
                            var _retCount = _context.Return(_lret0);
                            return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                        }
                        var _arg3 = _lastArg = _argCount > 3 ? _context.GetArgument(3) : global::Lua.LuaValue.Nil;
                        _lastArgPos = 3; _expectedType = typeof(global::UnityEngine.GUIStyle);
                        if (_arg3.TryRead<global::UnityEngine.GUIStyle>(out var _p3_UnityEngine_GUIStyle))
                        {
                            if (_argCount == 4)
                            {
                                var position = _p0_UnityEngine_Rect;
                                var label = _p1_UnityEngine_GUIContent;
                                var value = _p2_System_Single;
                                var style = _p3_UnityEngine_GUIStyle;
                                var _ret0 = global::UnityEditor.EditorGUI.DelayedFloatField(position, label, value, style);
                                var _lret0 = new global::Lua.LuaValue(_ret0);
                                var _retCount = _context.Return(_lret0);
                                return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                            }
                        }
                    }
                }
            }
            throw new global::Lua.LuaRuntimeException(_context.Thread, $"{"DelayedFloatField"}: invalid argument #{_lastArgPos}: {_lastArg} ({_lastArg.Type}), expected: {_expectedType.FullName}", 2);
        });
        private static readonly global::Lua.LuaFunction _LuaEditorGUI_DelayedIntField = new global::Lua.LuaFunction("DelayedIntField", (_context, _) =>
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
                _lastArgPos = 1; _expectedType = typeof(global::System.Int32);
                if (_arg1.TryRead<global::System.Int32>(out var _p1_System_Int32))
                {
                    if (_argCount == 2)
                    {
                        var position = _p0_UnityEngine_Rect;
                        var value = _p1_System_Int32;
                        var _ret0 = global::UnityEditor.EditorGUI.DelayedIntField(position, value);
                        var _lret0 = new global::Lua.LuaValue(_ret0);
                        var _retCount = _context.Return(_lret0);
                        return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                    }
                    var _arg2 = _lastArg = _argCount > 2 ? _context.GetArgument(2) : global::Lua.LuaValue.Nil;
                    _lastArgPos = 2; _expectedType = typeof(global::UnityEngine.GUIStyle);
                    if (_arg2.TryRead<global::UnityEngine.GUIStyle>(out var _p2_UnityEngine_GUIStyle))
                    {
                        if (_argCount == 3)
                        {
                            var position = _p0_UnityEngine_Rect;
                            var value = _p1_System_Int32;
                            var style = _p2_UnityEngine_GUIStyle;
                            var _ret0 = global::UnityEditor.EditorGUI.DelayedIntField(position, value, style);
                            var _lret0 = new global::Lua.LuaValue(_ret0);
                            var _retCount = _context.Return(_lret0);
                            return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                        }
                    }
                }
                _lastArgPos = 1; _expectedType = typeof(global::Luny.UnityEditor.LuaSerializedProperty);
                if (_arg1.TryRead<global::Luny.UnityEditor.LuaSerializedProperty>(out var _p1_UnityEditor_SerializedProperty))
                {
                    if (_argCount == 2)
                    {
                        var position = _p0_UnityEngine_Rect;
                        var property = _p1_UnityEditor_SerializedProperty.Instance;
                        global::UnityEditor.EditorGUI.DelayedIntField(position, property);
                        var _retCount = _context.Return();
                        return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                    }
                    var _arg2 = _lastArg = _argCount > 2 ? _context.GetArgument(2) : global::Lua.LuaValue.Nil;
                    _lastArgPos = 2; _expectedType = typeof(global::UnityEngine.GUIContent);
                    if (_arg2.TryRead<global::UnityEngine.GUIContent>(out var _p2_UnityEngine_GUIContent))
                    {
                        if (_argCount == 3)
                        {
                            var position = _p0_UnityEngine_Rect;
                            var property = _p1_UnityEditor_SerializedProperty.Instance;
                            var label = _p2_UnityEngine_GUIContent;
                            global::UnityEditor.EditorGUI.DelayedIntField(position, property, label);
                            var _retCount = _context.Return();
                            return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                        }
                    }
                }
                _lastArgPos = 1; _expectedType = typeof(global::System.String);
                if (_arg1.TryRead<global::System.String>(out var _p1_System_String))
                {
                    var _arg2 = _lastArg = _argCount > 2 ? _context.GetArgument(2) : global::Lua.LuaValue.Nil;
                    _lastArgPos = 2; _expectedType = typeof(global::System.Int32);
                    if (_arg2.TryRead<global::System.Int32>(out var _p2_System_Int32))
                    {
                        if (_argCount == 3)
                        {
                            var position = _p0_UnityEngine_Rect;
                            var label = _p1_System_String;
                            var value = _p2_System_Int32;
                            var _ret0 = global::UnityEditor.EditorGUI.DelayedIntField(position, label, value);
                            var _lret0 = new global::Lua.LuaValue(_ret0);
                            var _retCount = _context.Return(_lret0);
                            return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                        }
                        var _arg3 = _lastArg = _argCount > 3 ? _context.GetArgument(3) : global::Lua.LuaValue.Nil;
                        _lastArgPos = 3; _expectedType = typeof(global::UnityEngine.GUIStyle);
                        if (_arg3.TryRead<global::UnityEngine.GUIStyle>(out var _p3_UnityEngine_GUIStyle))
                        {
                            if (_argCount == 4)
                            {
                                var position = _p0_UnityEngine_Rect;
                                var label = _p1_System_String;
                                var value = _p2_System_Int32;
                                var style = _p3_UnityEngine_GUIStyle;
                                var _ret0 = global::UnityEditor.EditorGUI.DelayedIntField(position, label, value, style);
                                var _lret0 = new global::Lua.LuaValue(_ret0);
                                var _retCount = _context.Return(_lret0);
                                return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                            }
                        }
                    }
                }
                _lastArgPos = 1; _expectedType = typeof(global::UnityEngine.GUIContent);
                if (_arg1.TryRead<global::UnityEngine.GUIContent>(out var _p1_UnityEngine_GUIContent))
                {
                    var _arg2 = _lastArg = _argCount > 2 ? _context.GetArgument(2) : global::Lua.LuaValue.Nil;
                    _lastArgPos = 2; _expectedType = typeof(global::System.Int32);
                    if (_arg2.TryRead<global::System.Int32>(out var _p2_System_Int32))
                    {
                        if (_argCount == 3)
                        {
                            var position = _p0_UnityEngine_Rect;
                            var label = _p1_UnityEngine_GUIContent;
                            var value = _p2_System_Int32;
                            var _ret0 = global::UnityEditor.EditorGUI.DelayedIntField(position, label, value);
                            var _lret0 = new global::Lua.LuaValue(_ret0);
                            var _retCount = _context.Return(_lret0);
                            return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                        }
                        var _arg3 = _lastArg = _argCount > 3 ? _context.GetArgument(3) : global::Lua.LuaValue.Nil;
                        _lastArgPos = 3; _expectedType = typeof(global::UnityEngine.GUIStyle);
                        if (_arg3.TryRead<global::UnityEngine.GUIStyle>(out var _p3_UnityEngine_GUIStyle))
                        {
                            if (_argCount == 4)
                            {
                                var position = _p0_UnityEngine_Rect;
                                var label = _p1_UnityEngine_GUIContent;
                                var value = _p2_System_Int32;
                                var style = _p3_UnityEngine_GUIStyle;
                                var _ret0 = global::UnityEditor.EditorGUI.DelayedIntField(position, label, value, style);
                                var _lret0 = new global::Lua.LuaValue(_ret0);
                                var _retCount = _context.Return(_lret0);
                                return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                            }
                        }
                    }
                }
            }
            throw new global::Lua.LuaRuntimeException(_context.Thread, $"{"DelayedIntField"}: invalid argument #{_lastArgPos}: {_lastArg} ({_lastArg.Type}), expected: {_expectedType.FullName}", 2);
        });
        private static readonly global::Lua.LuaFunction _LuaEditorGUI_DelayedTextField = new global::Lua.LuaFunction("DelayedTextField", (_context, _) =>
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
                _lastArgPos = 1; _expectedType = typeof(global::System.String);
                if (_arg1.TryRead<global::System.String>(out var _p1_System_String))
                {
                    if (_argCount == 2)
                    {
                        var position = _p0_UnityEngine_Rect;
                        var text = _p1_System_String;
                        var _ret0 = global::UnityEditor.EditorGUI.DelayedTextField(position, text);
                        var _lret0 = new global::Lua.LuaValue(_ret0);
                        var _retCount = _context.Return(_lret0);
                        return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                    }
                    var _arg2 = _lastArg = _argCount > 2 ? _context.GetArgument(2) : global::Lua.LuaValue.Nil;
                    _lastArgPos = 2; _expectedType = typeof(global::System.String);
                    if (_arg2.TryRead<global::System.String>(out var _p2_System_String))
                    {
                        if (_argCount == 3)
                        {
                            var position = _p0_UnityEngine_Rect;
                            var label = _p1_System_String;
                            var text = _p2_System_String;
                            var _ret0 = global::UnityEditor.EditorGUI.DelayedTextField(position, label, text);
                            var _lret0 = new global::Lua.LuaValue(_ret0);
                            var _retCount = _context.Return(_lret0);
                            return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                        }
                        var _arg3 = _lastArg = _argCount > 3 ? _context.GetArgument(3) : global::Lua.LuaValue.Nil;
                        _lastArgPos = 3; _expectedType = typeof(global::UnityEngine.GUIStyle);
                        if (_arg3.TryRead<global::UnityEngine.GUIStyle>(out var _p3_UnityEngine_GUIStyle))
                        {
                            if (_argCount == 4)
                            {
                                var position = _p0_UnityEngine_Rect;
                                var label = _p1_System_String;
                                var text = _p2_System_String;
                                var style = _p3_UnityEngine_GUIStyle;
                                var _ret0 = global::UnityEditor.EditorGUI.DelayedTextField(position, label, text, style);
                                var _lret0 = new global::Lua.LuaValue(_ret0);
                                var _retCount = _context.Return(_lret0);
                                return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                            }
                        }
                    }
                    _lastArgPos = 2; _expectedType = typeof(global::UnityEngine.GUIStyle);
                    if (_arg2.TryRead<global::UnityEngine.GUIStyle>(out var _p2_UnityEngine_GUIStyle))
                    {
                        if (_argCount == 3)
                        {
                            var position = _p0_UnityEngine_Rect;
                            var text = _p1_System_String;
                            var style = _p2_UnityEngine_GUIStyle;
                            var _ret0 = global::UnityEditor.EditorGUI.DelayedTextField(position, text, style);
                            var _lret0 = new global::Lua.LuaValue(_ret0);
                            var _retCount = _context.Return(_lret0);
                            return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                        }
                    }
                }
                _lastArgPos = 1; _expectedType = typeof(global::Luny.UnityEditor.LuaSerializedProperty);
                if (_arg1.TryRead<global::Luny.UnityEditor.LuaSerializedProperty>(out var _p1_UnityEditor_SerializedProperty))
                {
                    if (_argCount == 2)
                    {
                        var position = _p0_UnityEngine_Rect;
                        var property = _p1_UnityEditor_SerializedProperty.Instance;
                        global::UnityEditor.EditorGUI.DelayedTextField(position, property);
                        var _retCount = _context.Return();
                        return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                    }
                    var _arg2 = _lastArg = _argCount > 2 ? _context.GetArgument(2) : global::Lua.LuaValue.Nil;
                    _lastArgPos = 2; _expectedType = typeof(global::UnityEngine.GUIContent);
                    if (_arg2.TryRead<global::UnityEngine.GUIContent>(out var _p2_UnityEngine_GUIContent))
                    {
                        if (_argCount == 3)
                        {
                            var position = _p0_UnityEngine_Rect;
                            var property = _p1_UnityEditor_SerializedProperty.Instance;
                            var label = _p2_UnityEngine_GUIContent;
                            global::UnityEditor.EditorGUI.DelayedTextField(position, property, label);
                            var _retCount = _context.Return();
                            return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                        }
                    }
                }
                _lastArgPos = 1; _expectedType = typeof(global::UnityEngine.GUIContent);
                if (_arg1.TryRead<global::UnityEngine.GUIContent>(out var _p1_UnityEngine_GUIContent))
                {
                    var _arg2 = _lastArg = _argCount > 2 ? _context.GetArgument(2) : global::Lua.LuaValue.Nil;
                    _lastArgPos = 2; _expectedType = typeof(global::System.String);
                    if (_arg2.TryRead<global::System.String>(out var _p2_System_String))
                    {
                        if (_argCount == 3)
                        {
                            var position = _p0_UnityEngine_Rect;
                            var label = _p1_UnityEngine_GUIContent;
                            var text = _p2_System_String;
                            var _ret0 = global::UnityEditor.EditorGUI.DelayedTextField(position, label, text);
                            var _lret0 = new global::Lua.LuaValue(_ret0);
                            var _retCount = _context.Return(_lret0);
                            return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                        }
                        var _arg3 = _lastArg = _argCount > 3 ? _context.GetArgument(3) : global::Lua.LuaValue.Nil;
                        _lastArgPos = 3; _expectedType = typeof(global::UnityEngine.GUIStyle);
                        if (_arg3.TryRead<global::UnityEngine.GUIStyle>(out var _p3_UnityEngine_GUIStyle))
                        {
                            if (_argCount == 4)
                            {
                                var position = _p0_UnityEngine_Rect;
                                var label = _p1_UnityEngine_GUIContent;
                                var text = _p2_System_String;
                                var style = _p3_UnityEngine_GUIStyle;
                                var _ret0 = global::UnityEditor.EditorGUI.DelayedTextField(position, label, text, style);
                                var _lret0 = new global::Lua.LuaValue(_ret0);
                                var _retCount = _context.Return(_lret0);
                                return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                            }
                        }
                    }
                    _lastArgPos = 2; _expectedType = typeof(global::System.Int32);
                    if (_arg2.TryRead<global::System.Int32>(out var _p2_System_Int32))
                    {
                        var _arg3 = _lastArg = _argCount > 3 ? _context.GetArgument(3) : global::Lua.LuaValue.Nil;
                        _lastArgPos = 3; _expectedType = typeof(global::System.String);
                        if (_arg3.TryRead<global::System.String>(out var _p3_System_String))
                        {
                            if (_argCount == 4)
                            {
                                var position = _p0_UnityEngine_Rect;
                                var label = _p1_UnityEngine_GUIContent;
                                var controlId = _p2_System_Int32;
                                var text = _p3_System_String;
                                var _ret0 = global::UnityEditor.EditorGUI.DelayedTextField(position, label, controlId, text);
                                var _lret0 = new global::Lua.LuaValue(_ret0);
                                var _retCount = _context.Return(_lret0);
                                return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                            }
                            var _arg4 = _lastArg = _argCount > 4 ? _context.GetArgument(4) : global::Lua.LuaValue.Nil;
                            _lastArgPos = 4; _expectedType = typeof(global::UnityEngine.GUIStyle);
                            if (_arg4.TryRead<global::UnityEngine.GUIStyle>(out var _p4_UnityEngine_GUIStyle))
                            {
                                if (_argCount == 5)
                                {
                                    var position = _p0_UnityEngine_Rect;
                                    var label = _p1_UnityEngine_GUIContent;
                                    var controlId = _p2_System_Int32;
                                    var text = _p3_System_String;
                                    var style = _p4_UnityEngine_GUIStyle;
                                    var _ret0 = global::UnityEditor.EditorGUI.DelayedTextField(position, label, controlId, text, style);
                                    var _lret0 = new global::Lua.LuaValue(_ret0);
                                    var _retCount = _context.Return(_lret0);
                                    return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                                }
                            }
                        }
                    }
                }
            }
            throw new global::Lua.LuaRuntimeException(_context.Thread, $"{"DelayedTextField"}: invalid argument #{_lastArgPos}: {_lastArg} ({_lastArg.Type}), expected: {_expectedType.FullName}", 2);
        });
        private static readonly global::Lua.LuaFunction _LuaEditorGUI_DoubleField = new global::Lua.LuaFunction("DoubleField", (_context, _) =>
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
                _lastArgPos = 1; _expectedType = typeof(global::System.Double);
                if (_arg1.TryRead<global::System.Double>(out var _p1_System_Double))
                {
                    if (_argCount == 2)
                    {
                        var position = _p0_UnityEngine_Rect;
                        var value = _p1_System_Double;
                        var _ret0 = global::UnityEditor.EditorGUI.DoubleField(position, value);
                        var _lret0 = new global::Lua.LuaValue(_ret0);
                        var _retCount = _context.Return(_lret0);
                        return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                    }
                    var _arg2 = _lastArg = _argCount > 2 ? _context.GetArgument(2) : global::Lua.LuaValue.Nil;
                    _lastArgPos = 2; _expectedType = typeof(global::UnityEngine.GUIStyle);
                    if (_arg2.TryRead<global::UnityEngine.GUIStyle>(out var _p2_UnityEngine_GUIStyle))
                    {
                        if (_argCount == 3)
                        {
                            var position = _p0_UnityEngine_Rect;
                            var value = _p1_System_Double;
                            var style = _p2_UnityEngine_GUIStyle;
                            var _ret0 = global::UnityEditor.EditorGUI.DoubleField(position, value, style);
                            var _lret0 = new global::Lua.LuaValue(_ret0);
                            var _retCount = _context.Return(_lret0);
                            return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                        }
                    }
                }
                _lastArgPos = 1; _expectedType = typeof(global::System.String);
                if (_arg1.TryRead<global::System.String>(out var _p1_System_String))
                {
                    var _arg2 = _lastArg = _argCount > 2 ? _context.GetArgument(2) : global::Lua.LuaValue.Nil;
                    _lastArgPos = 2; _expectedType = typeof(global::System.Double);
                    if (_arg2.TryRead<global::System.Double>(out var _p2_System_Double))
                    {
                        if (_argCount == 3)
                        {
                            var position = _p0_UnityEngine_Rect;
                            var label = _p1_System_String;
                            var value = _p2_System_Double;
                            var _ret0 = global::UnityEditor.EditorGUI.DoubleField(position, label, value);
                            var _lret0 = new global::Lua.LuaValue(_ret0);
                            var _retCount = _context.Return(_lret0);
                            return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                        }
                        var _arg3 = _lastArg = _argCount > 3 ? _context.GetArgument(3) : global::Lua.LuaValue.Nil;
                        _lastArgPos = 3; _expectedType = typeof(global::UnityEngine.GUIStyle);
                        if (_arg3.TryRead<global::UnityEngine.GUIStyle>(out var _p3_UnityEngine_GUIStyle))
                        {
                            if (_argCount == 4)
                            {
                                var position = _p0_UnityEngine_Rect;
                                var label = _p1_System_String;
                                var value = _p2_System_Double;
                                var style = _p3_UnityEngine_GUIStyle;
                                var _ret0 = global::UnityEditor.EditorGUI.DoubleField(position, label, value, style);
                                var _lret0 = new global::Lua.LuaValue(_ret0);
                                var _retCount = _context.Return(_lret0);
                                return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                            }
                        }
                    }
                }
                _lastArgPos = 1; _expectedType = typeof(global::UnityEngine.GUIContent);
                if (_arg1.TryRead<global::UnityEngine.GUIContent>(out var _p1_UnityEngine_GUIContent))
                {
                    var _arg2 = _lastArg = _argCount > 2 ? _context.GetArgument(2) : global::Lua.LuaValue.Nil;
                    _lastArgPos = 2; _expectedType = typeof(global::System.Double);
                    if (_arg2.TryRead<global::System.Double>(out var _p2_System_Double))
                    {
                        if (_argCount == 3)
                        {
                            var position = _p0_UnityEngine_Rect;
                            var label = _p1_UnityEngine_GUIContent;
                            var value = _p2_System_Double;
                            var _ret0 = global::UnityEditor.EditorGUI.DoubleField(position, label, value);
                            var _lret0 = new global::Lua.LuaValue(_ret0);
                            var _retCount = _context.Return(_lret0);
                            return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                        }
                        var _arg3 = _lastArg = _argCount > 3 ? _context.GetArgument(3) : global::Lua.LuaValue.Nil;
                        _lastArgPos = 3; _expectedType = typeof(global::UnityEngine.GUIStyle);
                        if (_arg3.TryRead<global::UnityEngine.GUIStyle>(out var _p3_UnityEngine_GUIStyle))
                        {
                            if (_argCount == 4)
                            {
                                var position = _p0_UnityEngine_Rect;
                                var label = _p1_UnityEngine_GUIContent;
                                var value = _p2_System_Double;
                                var style = _p3_UnityEngine_GUIStyle;
                                var _ret0 = global::UnityEditor.EditorGUI.DoubleField(position, label, value, style);
                                var _lret0 = new global::Lua.LuaValue(_ret0);
                                var _retCount = _context.Return(_lret0);
                                return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                            }
                        }
                    }
                }
            }
            throw new global::Lua.LuaRuntimeException(_context.Thread, $"{"DoubleField"}: invalid argument #{_lastArgPos}: {_lastArg} ({_lastArg.Type}), expected: {_expectedType.FullName}", 2);
        });
        private static readonly global::Lua.LuaFunction _LuaEditorGUI_DrawPreviewTexture = new global::Lua.LuaFunction("DrawPreviewTexture", (_context, _) =>
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
                _lastArgPos = 1; _expectedType = typeof(global::UnityEngine.Texture);
                if (_arg1.TryRead<global::UnityEngine.Texture>(out var _p1_UnityEngine_Texture))
                {
                    if (_argCount == 2)
                    {
                        var position = _p0_UnityEngine_Rect;
                        var image = _p1_UnityEngine_Texture;
                        global::UnityEditor.EditorGUI.DrawPreviewTexture(position, image);
                        var _retCount = _context.Return();
                        return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                    }
                    var _arg2 = _lastArg = _argCount > 2 ? _context.GetArgument(2) : global::Lua.LuaValue.Nil;
                    _lastArgPos = 2; _expectedType = typeof(global::UnityEngine.Material);
                    if (_arg2.TryRead<global::UnityEngine.Material>(out var _p2_UnityEngine_Material))
                    {
                        if (_argCount == 3)
                        {
                            var position = _p0_UnityEngine_Rect;
                            var image = _p1_UnityEngine_Texture;
                            var mat = _p2_UnityEngine_Material;
                            global::UnityEditor.EditorGUI.DrawPreviewTexture(position, image, mat);
                            var _retCount = _context.Return();
                            return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                        }
                        var _arg3 = _lastArg = _argCount > 3 ? _context.GetArgument(3) : global::Lua.LuaValue.Nil;
                        _lastArgPos = 3; _expectedType = typeof(global::UnityEngine.ScaleMode);
                        if (_arg3.TryRead<global::UnityEngine.ScaleMode>(out var _p3_UnityEngine_ScaleMode))
                        {
                            if (_argCount == 4)
                            {
                                var position = _p0_UnityEngine_Rect;
                                var image = _p1_UnityEngine_Texture;
                                var mat = _p2_UnityEngine_Material;
                                var scaleMode = _p3_UnityEngine_ScaleMode;
                                global::UnityEditor.EditorGUI.DrawPreviewTexture(position, image, mat, scaleMode);
                                var _retCount = _context.Return();
                                return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                            }
                            var _arg4 = _lastArg = _argCount > 4 ? _context.GetArgument(4) : global::Lua.LuaValue.Nil;
                            _lastArgPos = 4; _expectedType = typeof(global::System.Single);
                            if (_arg4.TryRead<global::System.Single>(out var _p4_System_Single))
                            {
                                if (_argCount == 5)
                                {
                                    var position = _p0_UnityEngine_Rect;
                                    var image = _p1_UnityEngine_Texture;
                                    var mat = _p2_UnityEngine_Material;
                                    var scaleMode = _p3_UnityEngine_ScaleMode;
                                    var imageAspect = _p4_System_Single;
                                    global::UnityEditor.EditorGUI.DrawPreviewTexture(position, image, mat, scaleMode, imageAspect);
                                    var _retCount = _context.Return();
                                    return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                                }
                                var _arg5 = _lastArg = _argCount > 5 ? _context.GetArgument(5) : global::Lua.LuaValue.Nil;
                                _lastArgPos = 5; _expectedType = typeof(global::System.Single);
                                if (_arg5.TryRead<global::System.Single>(out var _p5_System_Single))
                                {
                                    if (_argCount == 6)
                                    {
                                        var position = _p0_UnityEngine_Rect;
                                        var image = _p1_UnityEngine_Texture;
                                        var mat = _p2_UnityEngine_Material;
                                        var scaleMode = _p3_UnityEngine_ScaleMode;
                                        var imageAspect = _p4_System_Single;
                                        var mipLevel = _p5_System_Single;
                                        global::UnityEditor.EditorGUI.DrawPreviewTexture(position, image, mat, scaleMode, imageAspect, mipLevel);
                                        var _retCount = _context.Return();
                                        return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                                    }
                                    var _arg6 = _lastArg = _argCount > 6 ? _context.GetArgument(6) : global::Lua.LuaValue.Nil;
                                    _lastArgPos = 6; _expectedType = typeof(global::UnityEngine.Rendering.ColorWriteMask);
                                    if (_arg6.TryRead<global::UnityEngine.Rendering.ColorWriteMask>(out var _p6_UnityEngine_Rendering_ColorWriteMask))
                                    {
                                        if (_argCount == 7)
                                        {
                                            var position = _p0_UnityEngine_Rect;
                                            var image = _p1_UnityEngine_Texture;
                                            var mat = _p2_UnityEngine_Material;
                                            var scaleMode = _p3_UnityEngine_ScaleMode;
                                            var imageAspect = _p4_System_Single;
                                            var mipLevel = _p5_System_Single;
                                            var colorWriteMask = _p6_UnityEngine_Rendering_ColorWriteMask;
                                            global::UnityEditor.EditorGUI.DrawPreviewTexture(position, image, mat, scaleMode, imageAspect, mipLevel, colorWriteMask);
                                            var _retCount = _context.Return();
                                            return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                                        }
                                        var _arg7 = _lastArg = _argCount > 7 ? _context.GetArgument(7) : global::Lua.LuaValue.Nil;
                                        _lastArgPos = 7; _expectedType = typeof(global::System.Single);
                                        if (_arg7.TryRead<global::System.Single>(out var _p7_System_Single))
                                        {
                                            if (_argCount == 8)
                                            {
                                                var position = _p0_UnityEngine_Rect;
                                                var image = _p1_UnityEngine_Texture;
                                                var mat = _p2_UnityEngine_Material;
                                                var scaleMode = _p3_UnityEngine_ScaleMode;
                                                var imageAspect = _p4_System_Single;
                                                var mipLevel = _p5_System_Single;
                                                var colorWriteMask = _p6_UnityEngine_Rendering_ColorWriteMask;
                                                var exposure = _p7_System_Single;
                                                global::UnityEditor.EditorGUI.DrawPreviewTexture(position, image, mat, scaleMode, imageAspect, mipLevel, colorWriteMask, exposure);
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
            throw new global::Lua.LuaRuntimeException(_context.Thread, $"{"DrawPreviewTexture"}: invalid argument #{_lastArgPos}: {_lastArg} ({_lastArg.Type}), expected: {_expectedType.FullName}", 2);
        });
        private static readonly global::Lua.LuaFunction _LuaEditorGUI_DrawRect = new global::Lua.LuaFunction("DrawRect", (_context, _) =>
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
                        var rect = _p0_UnityEngine_Rect;
                        var color = _p1_UnityEngine_Color;
                        global::UnityEditor.EditorGUI.DrawRect(rect, color);
                        var _retCount = _context.Return();
                        return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                    }
                }
            }
            throw new global::Lua.LuaRuntimeException(_context.Thread, $"{"DrawRect"}: invalid argument #{_lastArgPos}: {_lastArg} ({_lastArg.Type}), expected: {_expectedType.FullName}", 2);
        });
        private static readonly global::Lua.LuaFunction _LuaEditorGUI_DrawTextureAlpha = new global::Lua.LuaFunction("DrawTextureAlpha", (_context, _) =>
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
                _lastArgPos = 1; _expectedType = typeof(global::UnityEngine.Texture);
                if (_arg1.TryRead<global::UnityEngine.Texture>(out var _p1_UnityEngine_Texture))
                {
                    if (_argCount == 2)
                    {
                        var position = _p0_UnityEngine_Rect;
                        var image = _p1_UnityEngine_Texture;
                        global::UnityEditor.EditorGUI.DrawTextureAlpha(position, image);
                        var _retCount = _context.Return();
                        return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                    }
                    var _arg2 = _lastArg = _argCount > 2 ? _context.GetArgument(2) : global::Lua.LuaValue.Nil;
                    _lastArgPos = 2; _expectedType = typeof(global::UnityEngine.ScaleMode);
                    if (_arg2.TryRead<global::UnityEngine.ScaleMode>(out var _p2_UnityEngine_ScaleMode))
                    {
                        if (_argCount == 3)
                        {
                            var position = _p0_UnityEngine_Rect;
                            var image = _p1_UnityEngine_Texture;
                            var scaleMode = _p2_UnityEngine_ScaleMode;
                            global::UnityEditor.EditorGUI.DrawTextureAlpha(position, image, scaleMode);
                            var _retCount = _context.Return();
                            return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                        }
                        var _arg3 = _lastArg = _argCount > 3 ? _context.GetArgument(3) : global::Lua.LuaValue.Nil;
                        _lastArgPos = 3; _expectedType = typeof(global::System.Single);
                        if (_arg3.TryRead<global::System.Single>(out var _p3_System_Single))
                        {
                            if (_argCount == 4)
                            {
                                var position = _p0_UnityEngine_Rect;
                                var image = _p1_UnityEngine_Texture;
                                var scaleMode = _p2_UnityEngine_ScaleMode;
                                var imageAspect = _p3_System_Single;
                                global::UnityEditor.EditorGUI.DrawTextureAlpha(position, image, scaleMode, imageAspect);
                                var _retCount = _context.Return();
                                return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                            }
                            var _arg4 = _lastArg = _argCount > 4 ? _context.GetArgument(4) : global::Lua.LuaValue.Nil;
                            _lastArgPos = 4; _expectedType = typeof(global::System.Single);
                            if (_arg4.TryRead<global::System.Single>(out var _p4_System_Single))
                            {
                                if (_argCount == 5)
                                {
                                    var position = _p0_UnityEngine_Rect;
                                    var image = _p1_UnityEngine_Texture;
                                    var scaleMode = _p2_UnityEngine_ScaleMode;
                                    var imageAspect = _p3_System_Single;
                                    var mipLevel = _p4_System_Single;
                                    global::UnityEditor.EditorGUI.DrawTextureAlpha(position, image, scaleMode, imageAspect, mipLevel);
                                    var _retCount = _context.Return();
                                    return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                                }
                            }
                        }
                    }
                }
            }
            throw new global::Lua.LuaRuntimeException(_context.Thread, $"{"DrawTextureAlpha"}: invalid argument #{_lastArgPos}: {_lastArg} ({_lastArg.Type}), expected: {_expectedType.FullName}", 2);
        });
        private static readonly global::Lua.LuaFunction _LuaEditorGUI_DrawTextureTransparent = new global::Lua.LuaFunction("DrawTextureTransparent", (_context, _) =>
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
                _lastArgPos = 1; _expectedType = typeof(global::UnityEngine.Texture);
                if (_arg1.TryRead<global::UnityEngine.Texture>(out var _p1_UnityEngine_Texture))
                {
                    if (_argCount == 2)
                    {
                        var position = _p0_UnityEngine_Rect;
                        var image = _p1_UnityEngine_Texture;
                        global::UnityEditor.EditorGUI.DrawTextureTransparent(position, image);
                        var _retCount = _context.Return();
                        return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                    }
                    var _arg2 = _lastArg = _argCount > 2 ? _context.GetArgument(2) : global::Lua.LuaValue.Nil;
                    _lastArgPos = 2; _expectedType = typeof(global::UnityEngine.ScaleMode);
                    if (_arg2.TryRead<global::UnityEngine.ScaleMode>(out var _p2_UnityEngine_ScaleMode))
                    {
                        if (_argCount == 3)
                        {
                            var position = _p0_UnityEngine_Rect;
                            var image = _p1_UnityEngine_Texture;
                            var scaleMode = _p2_UnityEngine_ScaleMode;
                            global::UnityEditor.EditorGUI.DrawTextureTransparent(position, image, scaleMode);
                            var _retCount = _context.Return();
                            return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                        }
                        var _arg3 = _lastArg = _argCount > 3 ? _context.GetArgument(3) : global::Lua.LuaValue.Nil;
                        _lastArgPos = 3; _expectedType = typeof(global::System.Single);
                        if (_arg3.TryRead<global::System.Single>(out var _p3_System_Single))
                        {
                            if (_argCount == 4)
                            {
                                var position = _p0_UnityEngine_Rect;
                                var image = _p1_UnityEngine_Texture;
                                var scaleMode = _p2_UnityEngine_ScaleMode;
                                var imageAspect = _p3_System_Single;
                                global::UnityEditor.EditorGUI.DrawTextureTransparent(position, image, scaleMode, imageAspect);
                                var _retCount = _context.Return();
                                return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                            }
                            var _arg4 = _lastArg = _argCount > 4 ? _context.GetArgument(4) : global::Lua.LuaValue.Nil;
                            _lastArgPos = 4; _expectedType = typeof(global::System.Single);
                            if (_arg4.TryRead<global::System.Single>(out var _p4_System_Single))
                            {
                                if (_argCount == 5)
                                {
                                    var position = _p0_UnityEngine_Rect;
                                    var image = _p1_UnityEngine_Texture;
                                    var scaleMode = _p2_UnityEngine_ScaleMode;
                                    var imageAspect = _p3_System_Single;
                                    var mipLevel = _p4_System_Single;
                                    global::UnityEditor.EditorGUI.DrawTextureTransparent(position, image, scaleMode, imageAspect, mipLevel);
                                    var _retCount = _context.Return();
                                    return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                                }
                                var _arg5 = _lastArg = _argCount > 5 ? _context.GetArgument(5) : global::Lua.LuaValue.Nil;
                                _lastArgPos = 5; _expectedType = typeof(global::UnityEngine.Rendering.ColorWriteMask);
                                if (_arg5.TryRead<global::UnityEngine.Rendering.ColorWriteMask>(out var _p5_UnityEngine_Rendering_ColorWriteMask))
                                {
                                    if (_argCount == 6)
                                    {
                                        var position = _p0_UnityEngine_Rect;
                                        var image = _p1_UnityEngine_Texture;
                                        var scaleMode = _p2_UnityEngine_ScaleMode;
                                        var imageAspect = _p3_System_Single;
                                        var mipLevel = _p4_System_Single;
                                        var colorWriteMask = _p5_UnityEngine_Rendering_ColorWriteMask;
                                        global::UnityEditor.EditorGUI.DrawTextureTransparent(position, image, scaleMode, imageAspect, mipLevel, colorWriteMask);
                                        var _retCount = _context.Return();
                                        return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                                    }
                                    var _arg6 = _lastArg = _argCount > 6 ? _context.GetArgument(6) : global::Lua.LuaValue.Nil;
                                    _lastArgPos = 6; _expectedType = typeof(global::System.Single);
                                    if (_arg6.TryRead<global::System.Single>(out var _p6_System_Single))
                                    {
                                        if (_argCount == 7)
                                        {
                                            var position = _p0_UnityEngine_Rect;
                                            var image = _p1_UnityEngine_Texture;
                                            var scaleMode = _p2_UnityEngine_ScaleMode;
                                            var imageAspect = _p3_System_Single;
                                            var mipLevel = _p4_System_Single;
                                            var colorWriteMask = _p5_UnityEngine_Rendering_ColorWriteMask;
                                            var exposure = _p6_System_Single;
                                            global::UnityEditor.EditorGUI.DrawTextureTransparent(position, image, scaleMode, imageAspect, mipLevel, colorWriteMask, exposure);
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
            throw new global::Lua.LuaRuntimeException(_context.Thread, $"{"DrawTextureTransparent"}: invalid argument #{_lastArgPos}: {_lastArg} ({_lastArg.Type}), expected: {_expectedType.FullName}", 2);
        });
        private static readonly global::Lua.LuaFunction _LuaEditorGUI_DropdownButton = new global::Lua.LuaFunction("DropdownButton", (_context, _) =>
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
                _lastArgPos = 1; _expectedType = typeof(global::UnityEngine.GUIContent);
                if (_arg1.TryRead<global::UnityEngine.GUIContent>(out var _p1_UnityEngine_GUIContent))
                {
                    var _arg2 = _lastArg = _argCount > 2 ? _context.GetArgument(2) : global::Lua.LuaValue.Nil;
                    _lastArgPos = 2; _expectedType = typeof(global::UnityEngine.FocusType);
                    if (_arg2.TryRead<global::UnityEngine.FocusType>(out var _p2_UnityEngine_FocusType))
                    {
                        if (_argCount == 3)
                        {
                            var position = _p0_UnityEngine_Rect;
                            var content = _p1_UnityEngine_GUIContent;
                            var focusType = _p2_UnityEngine_FocusType;
                            var _ret0 = global::UnityEditor.EditorGUI.DropdownButton(position, content, focusType);
                            var _lret0 = new global::Lua.LuaValue(_ret0);
                            var _retCount = _context.Return(_lret0);
                            return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                        }
                        var _arg3 = _lastArg = _argCount > 3 ? _context.GetArgument(3) : global::Lua.LuaValue.Nil;
                        _lastArgPos = 3; _expectedType = typeof(global::UnityEngine.GUIStyle);
                        if (_arg3.TryRead<global::UnityEngine.GUIStyle>(out var _p3_UnityEngine_GUIStyle))
                        {
                            if (_argCount == 4)
                            {
                                var position = _p0_UnityEngine_Rect;
                                var content = _p1_UnityEngine_GUIContent;
                                var focusType = _p2_UnityEngine_FocusType;
                                var style = _p3_UnityEngine_GUIStyle;
                                var _ret0 = global::UnityEditor.EditorGUI.DropdownButton(position, content, focusType, style);
                                var _lret0 = new global::Lua.LuaValue(_ret0);
                                var _retCount = _context.Return(_lret0);
                                return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                            }
                        }
                    }
                }
            }
            throw new global::Lua.LuaRuntimeException(_context.Thread, $"{"DropdownButton"}: invalid argument #{_lastArgPos}: {_lastArg} ({_lastArg.Type}), expected: {_expectedType.FullName}", 2);
        });
        private static readonly global::Lua.LuaFunction _LuaEditorGUI_DropShadowLabel = new global::Lua.LuaFunction("DropShadowLabel", (_context, _) =>
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
                _lastArgPos = 1; _expectedType = typeof(global::System.String);
                if (_arg1.TryRead<global::System.String>(out var _p1_System_String))
                {
                    if (_argCount == 2)
                    {
                        var position = _p0_UnityEngine_Rect;
                        var text = _p1_System_String;
                        global::UnityEditor.EditorGUI.DropShadowLabel(position, text);
                        var _retCount = _context.Return();
                        return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                    }
                    var _arg2 = _lastArg = _argCount > 2 ? _context.GetArgument(2) : global::Lua.LuaValue.Nil;
                    _lastArgPos = 2; _expectedType = typeof(global::UnityEngine.GUIStyle);
                    if (_arg2.TryRead<global::UnityEngine.GUIStyle>(out var _p2_UnityEngine_GUIStyle))
                    {
                        if (_argCount == 3)
                        {
                            var position = _p0_UnityEngine_Rect;
                            var text = _p1_System_String;
                            var style = _p2_UnityEngine_GUIStyle;
                            global::UnityEditor.EditorGUI.DropShadowLabel(position, text, style);
                            var _retCount = _context.Return();
                            return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                        }
                    }
                }
                _lastArgPos = 1; _expectedType = typeof(global::UnityEngine.GUIContent);
                if (_arg1.TryRead<global::UnityEngine.GUIContent>(out var _p1_UnityEngine_GUIContent))
                {
                    if (_argCount == 2)
                    {
                        var position = _p0_UnityEngine_Rect;
                        var content = _p1_UnityEngine_GUIContent;
                        global::UnityEditor.EditorGUI.DropShadowLabel(position, content);
                        var _retCount = _context.Return();
                        return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                    }
                    var _arg2 = _lastArg = _argCount > 2 ? _context.GetArgument(2) : global::Lua.LuaValue.Nil;
                    _lastArgPos = 2; _expectedType = typeof(global::UnityEngine.GUIStyle);
                    if (_arg2.TryRead<global::UnityEngine.GUIStyle>(out var _p2_UnityEngine_GUIStyle))
                    {
                        if (_argCount == 3)
                        {
                            var position = _p0_UnityEngine_Rect;
                            var content = _p1_UnityEngine_GUIContent;
                            var style = _p2_UnityEngine_GUIStyle;
                            global::UnityEditor.EditorGUI.DropShadowLabel(position, content, style);
                            var _retCount = _context.Return();
                            return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                        }
                    }
                }
            }
            throw new global::Lua.LuaRuntimeException(_context.Thread, $"{"DropShadowLabel"}: invalid argument #{_lastArgPos}: {_lastArg} ({_lastArg.Type}), expected: {_expectedType.FullName}", 2);
        });
        private static readonly global::Lua.LuaFunction _LuaEditorGUI_EndChangeCheck = new global::Lua.LuaFunction("EndChangeCheck", (_context, _) =>
        {
            global::Lua.LuaValue _lastArg = default;
            global::System.Int32 _lastArgPos = default;
            global::System.Type _expectedType = default;
            var _argCount = _context.ArgumentCount;
            if (_argCount == 0)
            {
                var _ret0 = global::UnityEditor.EditorGUI.EndChangeCheck();
                var _lret0 = new global::Lua.LuaValue(_ret0);
                var _retCount = _context.Return(_lret0);
                return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
            }
            throw new global::Lua.LuaRuntimeException(_context.Thread, $"{"EndChangeCheck"}: invalid argument #{_lastArgPos}: {_lastArg} ({_lastArg.Type}), expected: {_expectedType.FullName}", 2);
        });
        private static readonly global::Lua.LuaFunction _LuaEditorGUI_EndDisabledGroup = new global::Lua.LuaFunction("EndDisabledGroup", (_context, _) =>
        {
            global::Lua.LuaValue _lastArg = default;
            global::System.Int32 _lastArgPos = default;
            global::System.Type _expectedType = default;
            var _argCount = _context.ArgumentCount;
            if (_argCount == 0)
            {
                global::UnityEditor.EditorGUI.EndDisabledGroup();
                var _retCount = _context.Return();
                return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
            }
            throw new global::Lua.LuaRuntimeException(_context.Thread, $"{"EndDisabledGroup"}: invalid argument #{_lastArgPos}: {_lastArg} ({_lastArg.Type}), expected: {_expectedType.FullName}", 2);
        });
        private static readonly global::Lua.LuaFunction _LuaEditorGUI_EndFoldoutHeaderGroup = new global::Lua.LuaFunction("EndFoldoutHeaderGroup", (_context, _) =>
        {
            global::Lua.LuaValue _lastArg = default;
            global::System.Int32 _lastArgPos = default;
            global::System.Type _expectedType = default;
            var _argCount = _context.ArgumentCount;
            if (_argCount == 0)
            {
                global::UnityEditor.EditorGUI.EndFoldoutHeaderGroup();
                var _retCount = _context.Return();
                return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
            }
            throw new global::Lua.LuaRuntimeException(_context.Thread, $"{"EndFoldoutHeaderGroup"}: invalid argument #{_lastArgPos}: {_lastArg} ({_lastArg.Type}), expected: {_expectedType.FullName}", 2);
        });
        private static readonly global::Lua.LuaFunction _LuaEditorGUI_EndProperty = new global::Lua.LuaFunction("EndProperty", (_context, _) =>
        {
            global::Lua.LuaValue _lastArg = default;
            global::System.Int32 _lastArgPos = default;
            global::System.Type _expectedType = default;
            var _argCount = _context.ArgumentCount;
            if (_argCount == 0)
            {
                global::UnityEditor.EditorGUI.EndProperty();
                var _retCount = _context.Return();
                return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
            }
            throw new global::Lua.LuaRuntimeException(_context.Thread, $"{"EndProperty"}: invalid argument #{_lastArgPos}: {_lastArg} ({_lastArg.Type}), expected: {_expectedType.FullName}", 2);
        });
        private static readonly global::Lua.LuaFunction _LuaEditorGUI_EnumFlagsField = new global::Lua.LuaFunction("EnumFlagsField", (_context, _) =>
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
                _lastArgPos = 1; _expectedType = typeof(global::System.Enum);
                if (_arg1.TryRead<global::System.Enum>(out var _p1_System_Enum))
                {
                    if (_argCount == 2)
                    {
                        var position = _p0_UnityEngine_Rect;
                        var enumValue = _p1_System_Enum;
                        var _ret0 = global::UnityEditor.EditorGUI.EnumFlagsField(position, enumValue);
                        var _factory = _context.GetObjectFactory();
                        var _lret0 = _factory.Bind(_ret0);
                        var _retCount = _context.Return(_lret0);
                        return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                    }
                    var _arg2 = _lastArg = _argCount > 2 ? _context.GetArgument(2) : global::Lua.LuaValue.Nil;
                    _lastArgPos = 2; _expectedType = typeof(global::UnityEngine.GUIStyle);
                    if (_arg2.TryRead<global::UnityEngine.GUIStyle>(out var _p2_UnityEngine_GUIStyle))
                    {
                        if (_argCount == 3)
                        {
                            var position = _p0_UnityEngine_Rect;
                            var enumValue = _p1_System_Enum;
                            var style = _p2_UnityEngine_GUIStyle;
                            var _ret0 = global::UnityEditor.EditorGUI.EnumFlagsField(position, enumValue, style);
                            var _factory = _context.GetObjectFactory();
                            var _lret0 = _factory.Bind(_ret0);
                            var _retCount = _context.Return(_lret0);
                            return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                        }
                    }
                }
                _lastArgPos = 1; _expectedType = typeof(global::System.String);
                if (_arg1.TryRead<global::System.String>(out var _p1_System_String))
                {
                    var _arg2 = _lastArg = _argCount > 2 ? _context.GetArgument(2) : global::Lua.LuaValue.Nil;
                    _lastArgPos = 2; _expectedType = typeof(global::System.Enum);
                    if (_arg2.TryRead<global::System.Enum>(out var _p2_System_Enum))
                    {
                        if (_argCount == 3)
                        {
                            var position = _p0_UnityEngine_Rect;
                            var label = _p1_System_String;
                            var enumValue = _p2_System_Enum;
                            var _ret0 = global::UnityEditor.EditorGUI.EnumFlagsField(position, label, enumValue);
                            var _factory = _context.GetObjectFactory();
                            var _lret0 = _factory.Bind(_ret0);
                            var _retCount = _context.Return(_lret0);
                            return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                        }
                        var _arg3 = _lastArg = _argCount > 3 ? _context.GetArgument(3) : global::Lua.LuaValue.Nil;
                        _lastArgPos = 3; _expectedType = typeof(global::UnityEngine.GUIStyle);
                        if (_arg3.TryRead<global::UnityEngine.GUIStyle>(out var _p3_UnityEngine_GUIStyle))
                        {
                            if (_argCount == 4)
                            {
                                var position = _p0_UnityEngine_Rect;
                                var label = _p1_System_String;
                                var enumValue = _p2_System_Enum;
                                var style = _p3_UnityEngine_GUIStyle;
                                var _ret0 = global::UnityEditor.EditorGUI.EnumFlagsField(position, label, enumValue, style);
                                var _factory = _context.GetObjectFactory();
                                var _lret0 = _factory.Bind(_ret0);
                                var _retCount = _context.Return(_lret0);
                                return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                            }
                        }
                    }
                }
                _lastArgPos = 1; _expectedType = typeof(global::UnityEngine.GUIContent);
                if (_arg1.TryRead<global::UnityEngine.GUIContent>(out var _p1_UnityEngine_GUIContent))
                {
                    var _arg2 = _lastArg = _argCount > 2 ? _context.GetArgument(2) : global::Lua.LuaValue.Nil;
                    _lastArgPos = 2; _expectedType = typeof(global::System.Enum);
                    if (_arg2.TryRead<global::System.Enum>(out var _p2_System_Enum))
                    {
                        if (_argCount == 3)
                        {
                            var position = _p0_UnityEngine_Rect;
                            var label = _p1_UnityEngine_GUIContent;
                            var enumValue = _p2_System_Enum;
                            var _ret0 = global::UnityEditor.EditorGUI.EnumFlagsField(position, label, enumValue);
                            var _factory = _context.GetObjectFactory();
                            var _lret0 = _factory.Bind(_ret0);
                            var _retCount = _context.Return(_lret0);
                            return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                        }
                        var _arg3 = _lastArg = _argCount > 3 ? _context.GetArgument(3) : global::Lua.LuaValue.Nil;
                        _lastArgPos = 3; _expectedType = typeof(global::UnityEngine.GUIStyle);
                        if (_arg3.TryRead<global::UnityEngine.GUIStyle>(out var _p3_UnityEngine_GUIStyle))
                        {
                            if (_argCount == 4)
                            {
                                var position = _p0_UnityEngine_Rect;
                                var label = _p1_UnityEngine_GUIContent;
                                var enumValue = _p2_System_Enum;
                                var style = _p3_UnityEngine_GUIStyle;
                                var _ret0 = global::UnityEditor.EditorGUI.EnumFlagsField(position, label, enumValue, style);
                                var _factory = _context.GetObjectFactory();
                                var _lret0 = _factory.Bind(_ret0);
                                var _retCount = _context.Return(_lret0);
                                return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                            }
                        }
                        _lastArgPos = 3; _expectedType = typeof(global::System.Boolean);
                        if (_arg3.TryRead<global::System.Boolean>(out var _p3_System_Boolean))
                        {
                            if (_argCount == 4)
                            {
                                var position = _p0_UnityEngine_Rect;
                                var label = _p1_UnityEngine_GUIContent;
                                var enumValue = _p2_System_Enum;
                                var includeObsolete = _p3_System_Boolean;
                                var _ret0 = global::UnityEditor.EditorGUI.EnumFlagsField(position, label, enumValue, includeObsolete);
                                var _factory = _context.GetObjectFactory();
                                var _lret0 = _factory.Bind(_ret0);
                                var _retCount = _context.Return(_lret0);
                                return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                            }
                            var _arg4 = _lastArg = _argCount > 4 ? _context.GetArgument(4) : global::Lua.LuaValue.Nil;
                            _lastArgPos = 4; _expectedType = typeof(global::UnityEngine.GUIStyle);
                            var _p4_UnityEngine_GUIStyle = _arg4.ReadValue<global::UnityEngine.GUIStyle>(default);
                            {
                                if (_argCount == 5)
                                {
                                    var position = _p0_UnityEngine_Rect;
                                    var label = _p1_UnityEngine_GUIContent;
                                    var enumValue = _p2_System_Enum;
                                    var includeObsolete = _p3_System_Boolean;
                                    var style = _p4_UnityEngine_GUIStyle;
                                    var _ret0 = global::UnityEditor.EditorGUI.EnumFlagsField(position, label, enumValue, includeObsolete, style);
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
            throw new global::Lua.LuaRuntimeException(_context.Thread, $"{"EnumFlagsField"}: invalid argument #{_lastArgPos}: {_lastArg} ({_lastArg.Type}), expected: {_expectedType.FullName}", 2);
        });
        private static readonly global::Lua.LuaFunction _LuaEditorGUI_EnumPopup = new global::Lua.LuaFunction("EnumPopup", (_context, _) =>
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
                _lastArgPos = 1; _expectedType = typeof(global::System.Enum);
                if (_arg1.TryRead<global::System.Enum>(out var _p1_System_Enum))
                {
                    if (_argCount == 2)
                    {
                        var position = _p0_UnityEngine_Rect;
                        var selected = _p1_System_Enum;
                        var _ret0 = global::UnityEditor.EditorGUI.EnumPopup(position, selected);
                        var _factory = _context.GetObjectFactory();
                        var _lret0 = _factory.Bind(_ret0);
                        var _retCount = _context.Return(_lret0);
                        return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                    }
                    var _arg2 = _lastArg = _argCount > 2 ? _context.GetArgument(2) : global::Lua.LuaValue.Nil;
                    _lastArgPos = 2; _expectedType = typeof(global::UnityEngine.GUIStyle);
                    if (_arg2.TryRead<global::UnityEngine.GUIStyle>(out var _p2_UnityEngine_GUIStyle))
                    {
                        if (_argCount == 3)
                        {
                            var position = _p0_UnityEngine_Rect;
                            var selected = _p1_System_Enum;
                            var style = _p2_UnityEngine_GUIStyle;
                            var _ret0 = global::UnityEditor.EditorGUI.EnumPopup(position, selected, style);
                            var _factory = _context.GetObjectFactory();
                            var _lret0 = _factory.Bind(_ret0);
                            var _retCount = _context.Return(_lret0);
                            return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                        }
                    }
                }
                _lastArgPos = 1; _expectedType = typeof(global::System.String);
                if (_arg1.TryRead<global::System.String>(out var _p1_System_String))
                {
                    var _arg2 = _lastArg = _argCount > 2 ? _context.GetArgument(2) : global::Lua.LuaValue.Nil;
                    _lastArgPos = 2; _expectedType = typeof(global::System.Enum);
                    if (_arg2.TryRead<global::System.Enum>(out var _p2_System_Enum))
                    {
                        if (_argCount == 3)
                        {
                            var position = _p0_UnityEngine_Rect;
                            var label = _p1_System_String;
                            var selected = _p2_System_Enum;
                            var _ret0 = global::UnityEditor.EditorGUI.EnumPopup(position, label, selected);
                            var _factory = _context.GetObjectFactory();
                            var _lret0 = _factory.Bind(_ret0);
                            var _retCount = _context.Return(_lret0);
                            return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                        }
                        var _arg3 = _lastArg = _argCount > 3 ? _context.GetArgument(3) : global::Lua.LuaValue.Nil;
                        _lastArgPos = 3; _expectedType = typeof(global::UnityEngine.GUIStyle);
                        if (_arg3.TryRead<global::UnityEngine.GUIStyle>(out var _p3_UnityEngine_GUIStyle))
                        {
                            if (_argCount == 4)
                            {
                                var position = _p0_UnityEngine_Rect;
                                var label = _p1_System_String;
                                var selected = _p2_System_Enum;
                                var style = _p3_UnityEngine_GUIStyle;
                                var _ret0 = global::UnityEditor.EditorGUI.EnumPopup(position, label, selected, style);
                                var _factory = _context.GetObjectFactory();
                                var _lret0 = _factory.Bind(_ret0);
                                var _retCount = _context.Return(_lret0);
                                return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                            }
                        }
                    }
                }
                _lastArgPos = 1; _expectedType = typeof(global::UnityEngine.GUIContent);
                if (_arg1.TryRead<global::UnityEngine.GUIContent>(out var _p1_UnityEngine_GUIContent))
                {
                    var _arg2 = _lastArg = _argCount > 2 ? _context.GetArgument(2) : global::Lua.LuaValue.Nil;
                    _lastArgPos = 2; _expectedType = typeof(global::System.Enum);
                    if (_arg2.TryRead<global::System.Enum>(out var _p2_System_Enum))
                    {
                        if (_argCount == 3)
                        {
                            var position = _p0_UnityEngine_Rect;
                            var label = _p1_UnityEngine_GUIContent;
                            var selected = _p2_System_Enum;
                            var _ret0 = global::UnityEditor.EditorGUI.EnumPopup(position, label, selected);
                            var _factory = _context.GetObjectFactory();
                            var _lret0 = _factory.Bind(_ret0);
                            var _retCount = _context.Return(_lret0);
                            return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                        }
                        var _arg3 = _lastArg = _argCount > 3 ? _context.GetArgument(3) : global::Lua.LuaValue.Nil;
                        _lastArgPos = 3; _expectedType = typeof(global::UnityEngine.GUIStyle);
                        if (_arg3.TryRead<global::UnityEngine.GUIStyle>(out var _p3_UnityEngine_GUIStyle))
                        {
                            if (_argCount == 4)
                            {
                                var position = _p0_UnityEngine_Rect;
                                var label = _p1_UnityEngine_GUIContent;
                                var selected = _p2_System_Enum;
                                var style = _p3_UnityEngine_GUIStyle;
                                var _ret0 = global::UnityEditor.EditorGUI.EnumPopup(position, label, selected, style);
                                var _factory = _context.GetObjectFactory();
                                var _lret0 = _factory.Bind(_ret0);
                                var _retCount = _context.Return(_lret0);
                                return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                            }
                        }
                    }
                }
            }
            throw new global::Lua.LuaRuntimeException(_context.Thread, $"{"EnumPopup"}: invalid argument #{_lastArgPos}: {_lastArg} ({_lastArg.Type}), expected: {_expectedType.FullName}", 2);
        });
        private static readonly global::Lua.LuaFunction _LuaEditorGUI_FloatField = new global::Lua.LuaFunction("FloatField", (_context, _) =>
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
                _lastArgPos = 1; _expectedType = typeof(global::System.Single);
                if (_arg1.TryRead<global::System.Single>(out var _p1_System_Single))
                {
                    if (_argCount == 2)
                    {
                        var position = _p0_UnityEngine_Rect;
                        var value = _p1_System_Single;
                        var _ret0 = global::UnityEditor.EditorGUI.FloatField(position, value);
                        var _lret0 = new global::Lua.LuaValue(_ret0);
                        var _retCount = _context.Return(_lret0);
                        return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                    }
                    var _arg2 = _lastArg = _argCount > 2 ? _context.GetArgument(2) : global::Lua.LuaValue.Nil;
                    _lastArgPos = 2; _expectedType = typeof(global::UnityEngine.GUIStyle);
                    if (_arg2.TryRead<global::UnityEngine.GUIStyle>(out var _p2_UnityEngine_GUIStyle))
                    {
                        if (_argCount == 3)
                        {
                            var position = _p0_UnityEngine_Rect;
                            var value = _p1_System_Single;
                            var style = _p2_UnityEngine_GUIStyle;
                            var _ret0 = global::UnityEditor.EditorGUI.FloatField(position, value, style);
                            var _lret0 = new global::Lua.LuaValue(_ret0);
                            var _retCount = _context.Return(_lret0);
                            return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                        }
                    }
                }
                _lastArgPos = 1; _expectedType = typeof(global::System.String);
                if (_arg1.TryRead<global::System.String>(out var _p1_System_String))
                {
                    var _arg2 = _lastArg = _argCount > 2 ? _context.GetArgument(2) : global::Lua.LuaValue.Nil;
                    _lastArgPos = 2; _expectedType = typeof(global::System.Single);
                    if (_arg2.TryRead<global::System.Single>(out var _p2_System_Single))
                    {
                        if (_argCount == 3)
                        {
                            var position = _p0_UnityEngine_Rect;
                            var label = _p1_System_String;
                            var value = _p2_System_Single;
                            var _ret0 = global::UnityEditor.EditorGUI.FloatField(position, label, value);
                            var _lret0 = new global::Lua.LuaValue(_ret0);
                            var _retCount = _context.Return(_lret0);
                            return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                        }
                        var _arg3 = _lastArg = _argCount > 3 ? _context.GetArgument(3) : global::Lua.LuaValue.Nil;
                        _lastArgPos = 3; _expectedType = typeof(global::UnityEngine.GUIStyle);
                        if (_arg3.TryRead<global::UnityEngine.GUIStyle>(out var _p3_UnityEngine_GUIStyle))
                        {
                            if (_argCount == 4)
                            {
                                var position = _p0_UnityEngine_Rect;
                                var label = _p1_System_String;
                                var value = _p2_System_Single;
                                var style = _p3_UnityEngine_GUIStyle;
                                var _ret0 = global::UnityEditor.EditorGUI.FloatField(position, label, value, style);
                                var _lret0 = new global::Lua.LuaValue(_ret0);
                                var _retCount = _context.Return(_lret0);
                                return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                            }
                        }
                    }
                }
                _lastArgPos = 1; _expectedType = typeof(global::UnityEngine.GUIContent);
                if (_arg1.TryRead<global::UnityEngine.GUIContent>(out var _p1_UnityEngine_GUIContent))
                {
                    var _arg2 = _lastArg = _argCount > 2 ? _context.GetArgument(2) : global::Lua.LuaValue.Nil;
                    _lastArgPos = 2; _expectedType = typeof(global::System.Single);
                    if (_arg2.TryRead<global::System.Single>(out var _p2_System_Single))
                    {
                        if (_argCount == 3)
                        {
                            var position = _p0_UnityEngine_Rect;
                            var label = _p1_UnityEngine_GUIContent;
                            var value = _p2_System_Single;
                            var _ret0 = global::UnityEditor.EditorGUI.FloatField(position, label, value);
                            var _lret0 = new global::Lua.LuaValue(_ret0);
                            var _retCount = _context.Return(_lret0);
                            return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                        }
                        var _arg3 = _lastArg = _argCount > 3 ? _context.GetArgument(3) : global::Lua.LuaValue.Nil;
                        _lastArgPos = 3; _expectedType = typeof(global::UnityEngine.GUIStyle);
                        if (_arg3.TryRead<global::UnityEngine.GUIStyle>(out var _p3_UnityEngine_GUIStyle))
                        {
                            if (_argCount == 4)
                            {
                                var position = _p0_UnityEngine_Rect;
                                var label = _p1_UnityEngine_GUIContent;
                                var value = _p2_System_Single;
                                var style = _p3_UnityEngine_GUIStyle;
                                var _ret0 = global::UnityEditor.EditorGUI.FloatField(position, label, value, style);
                                var _lret0 = new global::Lua.LuaValue(_ret0);
                                var _retCount = _context.Return(_lret0);
                                return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                            }
                        }
                    }
                }
            }
            throw new global::Lua.LuaRuntimeException(_context.Thread, $"{"FloatField"}: invalid argument #{_lastArgPos}: {_lastArg} ({_lastArg.Type}), expected: {_expectedType.FullName}", 2);
        });
        private static readonly global::Lua.LuaFunction _LuaEditorGUI_FocusTextInControl = new global::Lua.LuaFunction("FocusTextInControl", (_context, _) =>
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
                    global::UnityEditor.EditorGUI.FocusTextInControl(name);
                    var _retCount = _context.Return();
                    return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                }
            }
            throw new global::Lua.LuaRuntimeException(_context.Thread, $"{"FocusTextInControl"}: invalid argument #{_lastArgPos}: {_lastArg} ({_lastArg.Type}), expected: {_expectedType.FullName}", 2);
        });
        private static readonly global::Lua.LuaFunction _LuaEditorGUI_Foldout = new global::Lua.LuaFunction("Foldout", (_context, _) =>
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
                _lastArgPos = 1; _expectedType = typeof(global::System.Boolean);
                if (_arg1.TryRead<global::System.Boolean>(out var _p1_System_Boolean))
                {
                    var _arg2 = _lastArg = _argCount > 2 ? _context.GetArgument(2) : global::Lua.LuaValue.Nil;
                    _lastArgPos = 2; _expectedType = typeof(global::System.String);
                    if (_arg2.TryRead<global::System.String>(out var _p2_System_String))
                    {
                        if (_argCount == 3)
                        {
                            var position = _p0_UnityEngine_Rect;
                            var foldout = _p1_System_Boolean;
                            var content = _p2_System_String;
                            var _ret0 = global::UnityEditor.EditorGUI.Foldout(position, foldout, content);
                            var _lret0 = new global::Lua.LuaValue(_ret0);
                            var _retCount = _context.Return(_lret0);
                            return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                        }
                        var _arg3 = _lastArg = _argCount > 3 ? _context.GetArgument(3) : global::Lua.LuaValue.Nil;
                        _lastArgPos = 3; _expectedType = typeof(global::System.Boolean);
                        if (_arg3.TryRead<global::System.Boolean>(out var _p3_System_Boolean))
                        {
                            if (_argCount == 4)
                            {
                                var position = _p0_UnityEngine_Rect;
                                var foldout = _p1_System_Boolean;
                                var content = _p2_System_String;
                                var toggleOnLabelClick = _p3_System_Boolean;
                                var _ret0 = global::UnityEditor.EditorGUI.Foldout(position, foldout, content, toggleOnLabelClick);
                                var _lret0 = new global::Lua.LuaValue(_ret0);
                                var _retCount = _context.Return(_lret0);
                                return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                            }
                            var _arg4 = _lastArg = _argCount > 4 ? _context.GetArgument(4) : global::Lua.LuaValue.Nil;
                            _lastArgPos = 4; _expectedType = typeof(global::UnityEngine.GUIStyle);
                            if (_arg4.TryRead<global::UnityEngine.GUIStyle>(out var _p4_UnityEngine_GUIStyle))
                            {
                                if (_argCount == 5)
                                {
                                    var position = _p0_UnityEngine_Rect;
                                    var foldout = _p1_System_Boolean;
                                    var content = _p2_System_String;
                                    var toggleOnLabelClick = _p3_System_Boolean;
                                    var style = _p4_UnityEngine_GUIStyle;
                                    var _ret0 = global::UnityEditor.EditorGUI.Foldout(position, foldout, content, toggleOnLabelClick, style);
                                    var _lret0 = new global::Lua.LuaValue(_ret0);
                                    var _retCount = _context.Return(_lret0);
                                    return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                                }
                            }
                        }
                        _lastArgPos = 3; _expectedType = typeof(global::UnityEngine.GUIStyle);
                        if (_arg3.TryRead<global::UnityEngine.GUIStyle>(out var _p3_UnityEngine_GUIStyle))
                        {
                            if (_argCount == 4)
                            {
                                var position = _p0_UnityEngine_Rect;
                                var foldout = _p1_System_Boolean;
                                var content = _p2_System_String;
                                var style = _p3_UnityEngine_GUIStyle;
                                var _ret0 = global::UnityEditor.EditorGUI.Foldout(position, foldout, content, style);
                                var _lret0 = new global::Lua.LuaValue(_ret0);
                                var _retCount = _context.Return(_lret0);
                                return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                            }
                        }
                    }
                    _lastArgPos = 2; _expectedType = typeof(global::UnityEngine.GUIContent);
                    if (_arg2.TryRead<global::UnityEngine.GUIContent>(out var _p2_UnityEngine_GUIContent))
                    {
                        if (_argCount == 3)
                        {
                            var position = _p0_UnityEngine_Rect;
                            var foldout = _p1_System_Boolean;
                            var content = _p2_UnityEngine_GUIContent;
                            var _ret0 = global::UnityEditor.EditorGUI.Foldout(position, foldout, content);
                            var _lret0 = new global::Lua.LuaValue(_ret0);
                            var _retCount = _context.Return(_lret0);
                            return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                        }
                        var _arg3 = _lastArg = _argCount > 3 ? _context.GetArgument(3) : global::Lua.LuaValue.Nil;
                        _lastArgPos = 3; _expectedType = typeof(global::System.Boolean);
                        if (_arg3.TryRead<global::System.Boolean>(out var _p3_System_Boolean))
                        {
                            if (_argCount == 4)
                            {
                                var position = _p0_UnityEngine_Rect;
                                var foldout = _p1_System_Boolean;
                                var content = _p2_UnityEngine_GUIContent;
                                var toggleOnLabelClick = _p3_System_Boolean;
                                var _ret0 = global::UnityEditor.EditorGUI.Foldout(position, foldout, content, toggleOnLabelClick);
                                var _lret0 = new global::Lua.LuaValue(_ret0);
                                var _retCount = _context.Return(_lret0);
                                return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                            }
                            var _arg4 = _lastArg = _argCount > 4 ? _context.GetArgument(4) : global::Lua.LuaValue.Nil;
                            _lastArgPos = 4; _expectedType = typeof(global::UnityEngine.GUIStyle);
                            if (_arg4.TryRead<global::UnityEngine.GUIStyle>(out var _p4_UnityEngine_GUIStyle))
                            {
                                if (_argCount == 5)
                                {
                                    var position = _p0_UnityEngine_Rect;
                                    var foldout = _p1_System_Boolean;
                                    var content = _p2_UnityEngine_GUIContent;
                                    var toggleOnLabelClick = _p3_System_Boolean;
                                    var style = _p4_UnityEngine_GUIStyle;
                                    var _ret0 = global::UnityEditor.EditorGUI.Foldout(position, foldout, content, toggleOnLabelClick, style);
                                    var _lret0 = new global::Lua.LuaValue(_ret0);
                                    var _retCount = _context.Return(_lret0);
                                    return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                                }
                            }
                        }
                        _lastArgPos = 3; _expectedType = typeof(global::UnityEngine.GUIStyle);
                        if (_arg3.TryRead<global::UnityEngine.GUIStyle>(out var _p3_UnityEngine_GUIStyle))
                        {
                            if (_argCount == 4)
                            {
                                var position = _p0_UnityEngine_Rect;
                                var foldout = _p1_System_Boolean;
                                var content = _p2_UnityEngine_GUIContent;
                                var style = _p3_UnityEngine_GUIStyle;
                                var _ret0 = global::UnityEditor.EditorGUI.Foldout(position, foldout, content, style);
                                var _lret0 = new global::Lua.LuaValue(_ret0);
                                var _retCount = _context.Return(_lret0);
                                return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                            }
                        }
                    }
                }
            }
            throw new global::Lua.LuaRuntimeException(_context.Thread, $"{"Foldout"}: invalid argument #{_lastArgPos}: {_lastArg} ({_lastArg.Type}), expected: {_expectedType.FullName}", 2);
        });
        private static readonly global::Lua.LuaFunction _LuaEditorGUI_GetPropertyHeight = new global::Lua.LuaFunction("GetPropertyHeight", (_context, _) =>
        {
            global::Lua.LuaValue _lastArg = default;
            global::System.Int32 _lastArgPos = default;
            global::System.Type _expectedType = default;
            var _argCount = _context.ArgumentCount;
            var _arg0 = _lastArg = _argCount > 0 ? _context.GetArgument(0) : global::Lua.LuaValue.Nil;
            _lastArgPos = 0; _expectedType = typeof(global::Luny.UnityEditor.LuaSerializedProperty);
            if (_arg0.TryRead<global::Luny.UnityEditor.LuaSerializedProperty>(out var _p0_UnityEditor_SerializedProperty))
            {
                if (_argCount == 1)
                {
                    var property = _p0_UnityEditor_SerializedProperty.Instance;
                    var _ret0 = global::UnityEditor.EditorGUI.GetPropertyHeight(property);
                    var _lret0 = new global::Lua.LuaValue(_ret0);
                    var _retCount = _context.Return(_lret0);
                    return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                }
                var _arg1 = _lastArg = _argCount > 1 ? _context.GetArgument(1) : global::Lua.LuaValue.Nil;
                _lastArgPos = 1; _expectedType = typeof(global::UnityEngine.GUIContent);
                if (_arg1.TryRead<global::UnityEngine.GUIContent>(out var _p1_UnityEngine_GUIContent))
                {
                    if (_argCount == 2)
                    {
                        var property = _p0_UnityEditor_SerializedProperty.Instance;
                        var label = _p1_UnityEngine_GUIContent;
                        var _ret0 = global::UnityEditor.EditorGUI.GetPropertyHeight(property, label);
                        var _lret0 = new global::Lua.LuaValue(_ret0);
                        var _retCount = _context.Return(_lret0);
                        return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                    }
                    var _arg2 = _lastArg = _argCount > 2 ? _context.GetArgument(2) : global::Lua.LuaValue.Nil;
                    _lastArgPos = 2; _expectedType = typeof(global::System.Boolean);
                    if (_arg2.TryRead<global::System.Boolean>(out var _p2_System_Boolean))
                    {
                        if (_argCount == 3)
                        {
                            var property = _p0_UnityEditor_SerializedProperty.Instance;
                            var label = _p1_UnityEngine_GUIContent;
                            var includeChildren = _p2_System_Boolean;
                            var _ret0 = global::UnityEditor.EditorGUI.GetPropertyHeight(property, label, includeChildren);
                            var _lret0 = new global::Lua.LuaValue(_ret0);
                            var _retCount = _context.Return(_lret0);
                            return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                        }
                    }
                }
                _lastArgPos = 1; _expectedType = typeof(global::System.Boolean);
                if (_arg1.TryRead<global::System.Boolean>(out var _p1_System_Boolean))
                {
                    if (_argCount == 2)
                    {
                        var property = _p0_UnityEditor_SerializedProperty.Instance;
                        var includeChildren = _p1_System_Boolean;
                        var _ret0 = global::UnityEditor.EditorGUI.GetPropertyHeight(property, includeChildren);
                        var _lret0 = new global::Lua.LuaValue(_ret0);
                        var _retCount = _context.Return(_lret0);
                        return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                    }
                }
            }
            _lastArgPos = 0; _expectedType = typeof(global::UnityEditor.SerializedPropertyType);
            if (_arg0.TryRead<global::UnityEditor.SerializedPropertyType>(out var _p0_UnityEditor_SerializedPropertyType))
            {
                var _arg1 = _lastArg = _argCount > 1 ? _context.GetArgument(1) : global::Lua.LuaValue.Nil;
                _lastArgPos = 1; _expectedType = typeof(global::UnityEngine.GUIContent);
                if (_arg1.TryRead<global::UnityEngine.GUIContent>(out var _p1_UnityEngine_GUIContent))
                {
                    if (_argCount == 2)
                    {
                        var type = _p0_UnityEditor_SerializedPropertyType;
                        var label = _p1_UnityEngine_GUIContent;
                        var _ret0 = global::UnityEditor.EditorGUI.GetPropertyHeight(type, label);
                        var _lret0 = new global::Lua.LuaValue(_ret0);
                        var _retCount = _context.Return(_lret0);
                        return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                    }
                }
            }
            throw new global::Lua.LuaRuntimeException(_context.Thread, $"{"GetPropertyHeight"}: invalid argument #{_lastArgPos}: {_lastArg} ({_lastArg.Type}), expected: {_expectedType.FullName}", 2);
        });
        private static readonly global::Lua.LuaFunction _LuaEditorGUI_GradientField = new global::Lua.LuaFunction("GradientField", (_context, _) =>
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
                _lastArgPos = 1; _expectedType = typeof(global::UnityEngine.Gradient);
                if (_arg1.TryRead<global::UnityEngine.Gradient>(out var _p1_UnityEngine_Gradient))
                {
                    if (_argCount == 2)
                    {
                        var position = _p0_UnityEngine_Rect;
                        var gradient = _p1_UnityEngine_Gradient;
                        var _ret0 = global::UnityEditor.EditorGUI.GradientField(position, gradient);
                        var _factory = _context.GetObjectFactory();
                        var _lret0 = _factory.Bind(_ret0);
                        var _retCount = _context.Return(_lret0);
                        return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                    }
                }
                _lastArgPos = 1; _expectedType = typeof(global::System.String);
                if (_arg1.TryRead<global::System.String>(out var _p1_System_String))
                {
                    var _arg2 = _lastArg = _argCount > 2 ? _context.GetArgument(2) : global::Lua.LuaValue.Nil;
                    _lastArgPos = 2; _expectedType = typeof(global::UnityEngine.Gradient);
                    if (_arg2.TryRead<global::UnityEngine.Gradient>(out var _p2_UnityEngine_Gradient))
                    {
                        if (_argCount == 3)
                        {
                            var position = _p0_UnityEngine_Rect;
                            var label = _p1_System_String;
                            var gradient = _p2_UnityEngine_Gradient;
                            var _ret0 = global::UnityEditor.EditorGUI.GradientField(position, label, gradient);
                            var _factory = _context.GetObjectFactory();
                            var _lret0 = _factory.Bind(_ret0);
                            var _retCount = _context.Return(_lret0);
                            return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                        }
                    }
                }
                _lastArgPos = 1; _expectedType = typeof(global::UnityEngine.GUIContent);
                if (_arg1.TryRead<global::UnityEngine.GUIContent>(out var _p1_UnityEngine_GUIContent))
                {
                    var _arg2 = _lastArg = _argCount > 2 ? _context.GetArgument(2) : global::Lua.LuaValue.Nil;
                    _lastArgPos = 2; _expectedType = typeof(global::UnityEngine.Gradient);
                    if (_arg2.TryRead<global::UnityEngine.Gradient>(out var _p2_UnityEngine_Gradient))
                    {
                        if (_argCount == 3)
                        {
                            var position = _p0_UnityEngine_Rect;
                            var label = _p1_UnityEngine_GUIContent;
                            var gradient = _p2_UnityEngine_Gradient;
                            var _ret0 = global::UnityEditor.EditorGUI.GradientField(position, label, gradient);
                            var _factory = _context.GetObjectFactory();
                            var _lret0 = _factory.Bind(_ret0);
                            var _retCount = _context.Return(_lret0);
                            return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                        }
                        var _arg3 = _lastArg = _argCount > 3 ? _context.GetArgument(3) : global::Lua.LuaValue.Nil;
                        _lastArgPos = 3; _expectedType = typeof(global::System.Boolean);
                        if (_arg3.TryRead<global::System.Boolean>(out var _p3_System_Boolean))
                        {
                            if (_argCount == 4)
                            {
                                var position = _p0_UnityEngine_Rect;
                                var label = _p1_UnityEngine_GUIContent;
                                var gradient = _p2_UnityEngine_Gradient;
                                var hdr = _p3_System_Boolean;
                                var _ret0 = global::UnityEditor.EditorGUI.GradientField(position, label, gradient, hdr);
                                var _factory = _context.GetObjectFactory();
                                var _lret0 = _factory.Bind(_ret0);
                                var _retCount = _context.Return(_lret0);
                                return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                            }
                            var _arg4 = _lastArg = _argCount > 4 ? _context.GetArgument(4) : global::Lua.LuaValue.Nil;
                            _lastArgPos = 4; _expectedType = typeof(global::UnityEngine.ColorSpace);
                            if (_arg4.TryRead<global::UnityEngine.ColorSpace>(out var _p4_UnityEngine_ColorSpace))
                            {
                                if (_argCount == 5)
                                {
                                    var position = _p0_UnityEngine_Rect;
                                    var label = _p1_UnityEngine_GUIContent;
                                    var gradient = _p2_UnityEngine_Gradient;
                                    var hdr = _p3_System_Boolean;
                                    var colorSpace = _p4_UnityEngine_ColorSpace;
                                    var _ret0 = global::UnityEditor.EditorGUI.GradientField(position, label, gradient, hdr, colorSpace);
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
            throw new global::Lua.LuaRuntimeException(_context.Thread, $"{"GradientField"}: invalid argument #{_lastArgPos}: {_lastArg} ({_lastArg.Type}), expected: {_expectedType.FullName}", 2);
        });
        private static readonly global::Lua.LuaFunction _LuaEditorGUI_HandlePrefixLabel = new global::Lua.LuaFunction("HandlePrefixLabel", (_context, _) =>
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
                _lastArgPos = 1; _expectedType = typeof(global::UnityEngine.Rect);
                if (_arg1.TryRead<global::UnityEngine.Rect>(out var _p1_UnityEngine_Rect))
                {
                    var _arg2 = _lastArg = _argCount > 2 ? _context.GetArgument(2) : global::Lua.LuaValue.Nil;
                    _lastArgPos = 2; _expectedType = typeof(global::UnityEngine.GUIContent);
                    if (_arg2.TryRead<global::UnityEngine.GUIContent>(out var _p2_UnityEngine_GUIContent))
                    {
                        if (_argCount == 3)
                        {
                            var totalPosition = _p0_UnityEngine_Rect;
                            var labelPosition = _p1_UnityEngine_Rect;
                            var label = _p2_UnityEngine_GUIContent;
                            global::UnityEditor.EditorGUI.HandlePrefixLabel(totalPosition, labelPosition, label);
                            var _retCount = _context.Return();
                            return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                        }
                        var _arg3 = _lastArg = _argCount > 3 ? _context.GetArgument(3) : global::Lua.LuaValue.Nil;
                        _lastArgPos = 3; _expectedType = typeof(global::System.Int32);
                        if (_arg3.TryRead<global::System.Int32>(out var _p3_System_Int32))
                        {
                            if (_argCount == 4)
                            {
                                var totalPosition = _p0_UnityEngine_Rect;
                                var labelPosition = _p1_UnityEngine_Rect;
                                var label = _p2_UnityEngine_GUIContent;
                                var id = _p3_System_Int32;
                                global::UnityEditor.EditorGUI.HandlePrefixLabel(totalPosition, labelPosition, label, id);
                                var _retCount = _context.Return();
                                return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                            }
                            var _arg4 = _lastArg = _argCount > 4 ? _context.GetArgument(4) : global::Lua.LuaValue.Nil;
                            _lastArgPos = 4; _expectedType = typeof(global::UnityEngine.GUIStyle);
                            if (_arg4.TryRead<global::UnityEngine.GUIStyle>(out var _p4_UnityEngine_GUIStyle))
                            {
                                if (_argCount == 5)
                                {
                                    var totalPosition = _p0_UnityEngine_Rect;
                                    var labelPosition = _p1_UnityEngine_Rect;
                                    var label = _p2_UnityEngine_GUIContent;
                                    var id = _p3_System_Int32;
                                    var style = _p4_UnityEngine_GUIStyle;
                                    global::UnityEditor.EditorGUI.HandlePrefixLabel(totalPosition, labelPosition, label, id, style);
                                    var _retCount = _context.Return();
                                    return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                                }
                            }
                        }
                    }
                }
            }
            throw new global::Lua.LuaRuntimeException(_context.Thread, $"{"HandlePrefixLabel"}: invalid argument #{_lastArgPos}: {_lastArg} ({_lastArg.Type}), expected: {_expectedType.FullName}", 2);
        });
        private static readonly global::Lua.LuaFunction _LuaEditorGUI_HelpBox = new global::Lua.LuaFunction("HelpBox", (_context, _) =>
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
                _lastArgPos = 1; _expectedType = typeof(global::UnityEngine.GUIContent);
                if (_arg1.TryRead<global::UnityEngine.GUIContent>(out var _p1_UnityEngine_GUIContent))
                {
                    if (_argCount == 2)
                    {
                        var position = _p0_UnityEngine_Rect;
                        var content = _p1_UnityEngine_GUIContent;
                        global::UnityEditor.EditorGUI.HelpBox(position, content);
                        var _retCount = _context.Return();
                        return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                    }
                }
                _lastArgPos = 1; _expectedType = typeof(global::System.String);
                if (_arg1.TryRead<global::System.String>(out var _p1_System_String))
                {
                    var _arg2 = _lastArg = _argCount > 2 ? _context.GetArgument(2) : global::Lua.LuaValue.Nil;
                    _lastArgPos = 2; _expectedType = typeof(global::UnityEditor.MessageType);
                    if (_arg2.TryRead<global::UnityEditor.MessageType>(out var _p2_UnityEditor_MessageType))
                    {
                        if (_argCount == 3)
                        {
                            var position = _p0_UnityEngine_Rect;
                            var message = _p1_System_String;
                            var type = _p2_UnityEditor_MessageType;
                            global::UnityEditor.EditorGUI.HelpBox(position, message, type);
                            var _retCount = _context.Return();
                            return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                        }
                    }
                }
            }
            throw new global::Lua.LuaRuntimeException(_context.Thread, $"{"HelpBox"}: invalid argument #{_lastArgPos}: {_lastArg} ({_lastArg.Type}), expected: {_expectedType.FullName}", 2);
        });
        private static readonly global::Lua.LuaFunction _LuaEditorGUI_IndentedRect = new global::Lua.LuaFunction("IndentedRect", (_context, _) =>
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
                    var source = _p0_UnityEngine_Rect;
                    var _ret0 = global::UnityEditor.EditorGUI.IndentedRect(source);
                    var _factory = _context.GetObjectFactory();
                    var _lret0 = _factory.Bind(_ret0);
                    var _retCount = _context.Return(_lret0);
                    return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                }
            }
            throw new global::Lua.LuaRuntimeException(_context.Thread, $"{"IndentedRect"}: invalid argument #{_lastArgPos}: {_lastArg} ({_lastArg.Type}), expected: {_expectedType.FullName}", 2);
        });
        private static readonly global::Lua.LuaFunction _LuaEditorGUI_InspectorTitlebar = new global::Lua.LuaFunction("InspectorTitlebar", (_context, _) =>
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
                _lastArgPos = 1; _expectedType = typeof(global::UnityEngine.Object[]);
                if (_arg1.TryReadArray<global::UnityEngine.Object>(out var _p1_UnityEngine_ObjectArray))
                {
                    if (_argCount == 2)
                    {
                        var position = _p0_UnityEngine_Rect;
                        var targetObjs = _p1_UnityEngine_ObjectArray;
                        global::UnityEditor.EditorGUI.InspectorTitlebar(position, targetObjs);
                        var _retCount = _context.Return();
                        return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                    }
                }
                _lastArgPos = 1; _expectedType = typeof(global::System.Boolean);
                if (_arg1.TryRead<global::System.Boolean>(out var _p1_System_Boolean))
                {
                    var _arg2 = _lastArg = _argCount > 2 ? _context.GetArgument(2) : global::Lua.LuaValue.Nil;
                    _lastArgPos = 2; _expectedType = typeof(global::Luny.UnityEditor.LuaEditor);
                    if (_arg2.TryRead<global::Luny.UnityEditor.LuaEditor>(out var _p2_UnityEditor_Editor))
                    {
                        if (_argCount == 3)
                        {
                            var position = _p0_UnityEngine_Rect;
                            var foldout = _p1_System_Boolean;
                            var editor = _p2_UnityEditor_Editor.Instance;
                            var _ret0 = global::UnityEditor.EditorGUI.InspectorTitlebar(position, foldout, editor);
                            var _lret0 = new global::Lua.LuaValue(_ret0);
                            var _retCount = _context.Return(_lret0);
                            return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                        }
                    }
                    _lastArgPos = 2; _expectedType = typeof(global::UnityEngine.Object);
                    if (_arg2.TryRead<global::UnityEngine.Object>(out var _p2_UnityEngine_Object))
                    {
                        var _arg3 = _lastArg = _argCount > 3 ? _context.GetArgument(3) : global::Lua.LuaValue.Nil;
                        _lastArgPos = 3; _expectedType = typeof(global::System.Boolean);
                        if (_arg3.TryRead<global::System.Boolean>(out var _p3_System_Boolean))
                        {
                            if (_argCount == 4)
                            {
                                var position = _p0_UnityEngine_Rect;
                                var foldout = _p1_System_Boolean;
                                var targetObj = _p2_UnityEngine_Object;
                                var expandable = _p3_System_Boolean;
                                var _ret0 = global::UnityEditor.EditorGUI.InspectorTitlebar(position, foldout, targetObj, expandable);
                                var _lret0 = new global::Lua.LuaValue(_ret0);
                                var _retCount = _context.Return(_lret0);
                                return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                            }
                        }
                    }
                    _lastArgPos = 2; _expectedType = typeof(global::UnityEngine.Object[]);
                    if (_arg2.TryReadArray<global::UnityEngine.Object>(out var _p2_UnityEngine_ObjectArray))
                    {
                        var _arg3 = _lastArg = _argCount > 3 ? _context.GetArgument(3) : global::Lua.LuaValue.Nil;
                        _lastArgPos = 3; _expectedType = typeof(global::System.Boolean);
                        if (_arg3.TryRead<global::System.Boolean>(out var _p3_System_Boolean))
                        {
                            if (_argCount == 4)
                            {
                                var position = _p0_UnityEngine_Rect;
                                var foldout = _p1_System_Boolean;
                                var targetObjs = _p2_UnityEngine_ObjectArray;
                                var expandable = _p3_System_Boolean;
                                var _ret0 = global::UnityEditor.EditorGUI.InspectorTitlebar(position, foldout, targetObjs, expandable);
                                var _lret0 = new global::Lua.LuaValue(_ret0);
                                var _retCount = _context.Return(_lret0);
                                return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                            }
                        }
                    }
                }
            }
            throw new global::Lua.LuaRuntimeException(_context.Thread, $"{"InspectorTitlebar"}: invalid argument #{_lastArgPos}: {_lastArg} ({_lastArg.Type}), expected: {_expectedType.FullName}", 2);
        });
        private static readonly global::Lua.LuaFunction _LuaEditorGUI_IntField = new global::Lua.LuaFunction("IntField", (_context, _) =>
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
                _lastArgPos = 1; _expectedType = typeof(global::System.Int32);
                if (_arg1.TryRead<global::System.Int32>(out var _p1_System_Int32))
                {
                    if (_argCount == 2)
                    {
                        var position = _p0_UnityEngine_Rect;
                        var value = _p1_System_Int32;
                        var _ret0 = global::UnityEditor.EditorGUI.IntField(position, value);
                        var _lret0 = new global::Lua.LuaValue(_ret0);
                        var _retCount = _context.Return(_lret0);
                        return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                    }
                    var _arg2 = _lastArg = _argCount > 2 ? _context.GetArgument(2) : global::Lua.LuaValue.Nil;
                    _lastArgPos = 2; _expectedType = typeof(global::UnityEngine.GUIStyle);
                    if (_arg2.TryRead<global::UnityEngine.GUIStyle>(out var _p2_UnityEngine_GUIStyle))
                    {
                        if (_argCount == 3)
                        {
                            var position = _p0_UnityEngine_Rect;
                            var value = _p1_System_Int32;
                            var style = _p2_UnityEngine_GUIStyle;
                            var _ret0 = global::UnityEditor.EditorGUI.IntField(position, value, style);
                            var _lret0 = new global::Lua.LuaValue(_ret0);
                            var _retCount = _context.Return(_lret0);
                            return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                        }
                    }
                }
                _lastArgPos = 1; _expectedType = typeof(global::System.String);
                if (_arg1.TryRead<global::System.String>(out var _p1_System_String))
                {
                    var _arg2 = _lastArg = _argCount > 2 ? _context.GetArgument(2) : global::Lua.LuaValue.Nil;
                    _lastArgPos = 2; _expectedType = typeof(global::System.Int32);
                    if (_arg2.TryRead<global::System.Int32>(out var _p2_System_Int32))
                    {
                        if (_argCount == 3)
                        {
                            var position = _p0_UnityEngine_Rect;
                            var label = _p1_System_String;
                            var value = _p2_System_Int32;
                            var _ret0 = global::UnityEditor.EditorGUI.IntField(position, label, value);
                            var _lret0 = new global::Lua.LuaValue(_ret0);
                            var _retCount = _context.Return(_lret0);
                            return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                        }
                        var _arg3 = _lastArg = _argCount > 3 ? _context.GetArgument(3) : global::Lua.LuaValue.Nil;
                        _lastArgPos = 3; _expectedType = typeof(global::UnityEngine.GUIStyle);
                        if (_arg3.TryRead<global::UnityEngine.GUIStyle>(out var _p3_UnityEngine_GUIStyle))
                        {
                            if (_argCount == 4)
                            {
                                var position = _p0_UnityEngine_Rect;
                                var label = _p1_System_String;
                                var value = _p2_System_Int32;
                                var style = _p3_UnityEngine_GUIStyle;
                                var _ret0 = global::UnityEditor.EditorGUI.IntField(position, label, value, style);
                                var _lret0 = new global::Lua.LuaValue(_ret0);
                                var _retCount = _context.Return(_lret0);
                                return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                            }
                        }
                    }
                }
                _lastArgPos = 1; _expectedType = typeof(global::UnityEngine.GUIContent);
                if (_arg1.TryRead<global::UnityEngine.GUIContent>(out var _p1_UnityEngine_GUIContent))
                {
                    var _arg2 = _lastArg = _argCount > 2 ? _context.GetArgument(2) : global::Lua.LuaValue.Nil;
                    _lastArgPos = 2; _expectedType = typeof(global::System.Int32);
                    if (_arg2.TryRead<global::System.Int32>(out var _p2_System_Int32))
                    {
                        if (_argCount == 3)
                        {
                            var position = _p0_UnityEngine_Rect;
                            var label = _p1_UnityEngine_GUIContent;
                            var value = _p2_System_Int32;
                            var _ret0 = global::UnityEditor.EditorGUI.IntField(position, label, value);
                            var _lret0 = new global::Lua.LuaValue(_ret0);
                            var _retCount = _context.Return(_lret0);
                            return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                        }
                        var _arg3 = _lastArg = _argCount > 3 ? _context.GetArgument(3) : global::Lua.LuaValue.Nil;
                        _lastArgPos = 3; _expectedType = typeof(global::UnityEngine.GUIStyle);
                        if (_arg3.TryRead<global::UnityEngine.GUIStyle>(out var _p3_UnityEngine_GUIStyle))
                        {
                            if (_argCount == 4)
                            {
                                var position = _p0_UnityEngine_Rect;
                                var label = _p1_UnityEngine_GUIContent;
                                var value = _p2_System_Int32;
                                var style = _p3_UnityEngine_GUIStyle;
                                var _ret0 = global::UnityEditor.EditorGUI.IntField(position, label, value, style);
                                var _lret0 = new global::Lua.LuaValue(_ret0);
                                var _retCount = _context.Return(_lret0);
                                return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                            }
                        }
                    }
                }
            }
            throw new global::Lua.LuaRuntimeException(_context.Thread, $"{"IntField"}: invalid argument #{_lastArgPos}: {_lastArg} ({_lastArg.Type}), expected: {_expectedType.FullName}", 2);
        });
        private static readonly global::Lua.LuaFunction _LuaEditorGUI_IntPopup = new global::Lua.LuaFunction("IntPopup", (_context, _) =>
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
                _lastArgPos = 1; _expectedType = typeof(global::System.Int32);
                if (_arg1.TryRead<global::System.Int32>(out var _p1_System_Int32))
                {
                    var _arg2 = _lastArg = _argCount > 2 ? _context.GetArgument(2) : global::Lua.LuaValue.Nil;
                    _lastArgPos = 2; _expectedType = typeof(global::System.String[]);
                    if (_arg2.TryReadArray<global::System.String>(out var _p2_System_StringArray))
                    {
                        var _arg3 = _lastArg = _argCount > 3 ? _context.GetArgument(3) : global::Lua.LuaValue.Nil;
                        _lastArgPos = 3; _expectedType = typeof(global::System.Int32[]);
                        if (_arg3.TryReadArray<global::System.Int32>(out var _p3_System_Int32Array))
                        {
                            if (_argCount == 4)
                            {
                                var position = _p0_UnityEngine_Rect;
                                var selectedValue = _p1_System_Int32;
                                var displayedOptions = _p2_System_StringArray;
                                var optionValues = _p3_System_Int32Array;
                                var _ret0 = global::UnityEditor.EditorGUI.IntPopup(position, selectedValue, displayedOptions, optionValues);
                                var _lret0 = new global::Lua.LuaValue(_ret0);
                                var _retCount = _context.Return(_lret0);
                                return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                            }
                            var _arg4 = _lastArg = _argCount > 4 ? _context.GetArgument(4) : global::Lua.LuaValue.Nil;
                            _lastArgPos = 4; _expectedType = typeof(global::UnityEngine.GUIStyle);
                            if (_arg4.TryRead<global::UnityEngine.GUIStyle>(out var _p4_UnityEngine_GUIStyle))
                            {
                                if (_argCount == 5)
                                {
                                    var position = _p0_UnityEngine_Rect;
                                    var selectedValue = _p1_System_Int32;
                                    var displayedOptions = _p2_System_StringArray;
                                    var optionValues = _p3_System_Int32Array;
                                    var style = _p4_UnityEngine_GUIStyle;
                                    var _ret0 = global::UnityEditor.EditorGUI.IntPopup(position, selectedValue, displayedOptions, optionValues, style);
                                    var _lret0 = new global::Lua.LuaValue(_ret0);
                                    var _retCount = _context.Return(_lret0);
                                    return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                                }
                            }
                        }
                    }
                    _lastArgPos = 2; _expectedType = typeof(global::UnityEngine.GUIContent[]);
                    if (_arg2.TryReadArray<global::UnityEngine.GUIContent>(out var _p2_UnityEngine_GUIContentArray))
                    {
                        var _arg3 = _lastArg = _argCount > 3 ? _context.GetArgument(3) : global::Lua.LuaValue.Nil;
                        _lastArgPos = 3; _expectedType = typeof(global::System.Int32[]);
                        if (_arg3.TryReadArray<global::System.Int32>(out var _p3_System_Int32Array))
                        {
                            if (_argCount == 4)
                            {
                                var position = _p0_UnityEngine_Rect;
                                var selectedValue = _p1_System_Int32;
                                var displayedOptions = _p2_UnityEngine_GUIContentArray;
                                var optionValues = _p3_System_Int32Array;
                                var _ret0 = global::UnityEditor.EditorGUI.IntPopup(position, selectedValue, displayedOptions, optionValues);
                                var _lret0 = new global::Lua.LuaValue(_ret0);
                                var _retCount = _context.Return(_lret0);
                                return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                            }
                            var _arg4 = _lastArg = _argCount > 4 ? _context.GetArgument(4) : global::Lua.LuaValue.Nil;
                            _lastArgPos = 4; _expectedType = typeof(global::UnityEngine.GUIStyle);
                            if (_arg4.TryRead<global::UnityEngine.GUIStyle>(out var _p4_UnityEngine_GUIStyle))
                            {
                                if (_argCount == 5)
                                {
                                    var position = _p0_UnityEngine_Rect;
                                    var selectedValue = _p1_System_Int32;
                                    var displayedOptions = _p2_UnityEngine_GUIContentArray;
                                    var optionValues = _p3_System_Int32Array;
                                    var style = _p4_UnityEngine_GUIStyle;
                                    var _ret0 = global::UnityEditor.EditorGUI.IntPopup(position, selectedValue, displayedOptions, optionValues, style);
                                    var _lret0 = new global::Lua.LuaValue(_ret0);
                                    var _retCount = _context.Return(_lret0);
                                    return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                                }
                            }
                        }
                    }
                }
                _lastArgPos = 1; _expectedType = typeof(global::Luny.UnityEditor.LuaSerializedProperty);
                if (_arg1.TryRead<global::Luny.UnityEditor.LuaSerializedProperty>(out var _p1_UnityEditor_SerializedProperty))
                {
                    var _arg2 = _lastArg = _argCount > 2 ? _context.GetArgument(2) : global::Lua.LuaValue.Nil;
                    _lastArgPos = 2; _expectedType = typeof(global::UnityEngine.GUIContent[]);
                    if (_arg2.TryReadArray<global::UnityEngine.GUIContent>(out var _p2_UnityEngine_GUIContentArray))
                    {
                        var _arg3 = _lastArg = _argCount > 3 ? _context.GetArgument(3) : global::Lua.LuaValue.Nil;
                        _lastArgPos = 3; _expectedType = typeof(global::System.Int32[]);
                        if (_arg3.TryReadArray<global::System.Int32>(out var _p3_System_Int32Array))
                        {
                            if (_argCount == 4)
                            {
                                var position = _p0_UnityEngine_Rect;
                                var property = _p1_UnityEditor_SerializedProperty.Instance;
                                var displayedOptions = _p2_UnityEngine_GUIContentArray;
                                var optionValues = _p3_System_Int32Array;
                                global::UnityEditor.EditorGUI.IntPopup(position, property, displayedOptions, optionValues);
                                var _retCount = _context.Return();
                                return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                            }
                            var _arg4 = _lastArg = _argCount > 4 ? _context.GetArgument(4) : global::Lua.LuaValue.Nil;
                            _lastArgPos = 4; _expectedType = typeof(global::UnityEngine.GUIContent);
                            if (_arg4.TryRead<global::UnityEngine.GUIContent>(out var _p4_UnityEngine_GUIContent))
                            {
                                if (_argCount == 5)
                                {
                                    var position = _p0_UnityEngine_Rect;
                                    var property = _p1_UnityEditor_SerializedProperty.Instance;
                                    var displayedOptions = _p2_UnityEngine_GUIContentArray;
                                    var optionValues = _p3_System_Int32Array;
                                    var label = _p4_UnityEngine_GUIContent;
                                    global::UnityEditor.EditorGUI.IntPopup(position, property, displayedOptions, optionValues, label);
                                    var _retCount = _context.Return();
                                    return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                                }
                            }
                        }
                    }
                }
                _lastArgPos = 1; _expectedType = typeof(global::System.String);
                if (_arg1.TryRead<global::System.String>(out var _p1_System_String))
                {
                    var _arg2 = _lastArg = _argCount > 2 ? _context.GetArgument(2) : global::Lua.LuaValue.Nil;
                    _lastArgPos = 2; _expectedType = typeof(global::System.Int32);
                    if (_arg2.TryRead<global::System.Int32>(out var _p2_System_Int32))
                    {
                        var _arg3 = _lastArg = _argCount > 3 ? _context.GetArgument(3) : global::Lua.LuaValue.Nil;
                        _lastArgPos = 3; _expectedType = typeof(global::System.String[]);
                        if (_arg3.TryReadArray<global::System.String>(out var _p3_System_StringArray))
                        {
                            var _arg4 = _lastArg = _argCount > 4 ? _context.GetArgument(4) : global::Lua.LuaValue.Nil;
                            _lastArgPos = 4; _expectedType = typeof(global::System.Int32[]);
                            if (_arg4.TryReadArray<global::System.Int32>(out var _p4_System_Int32Array))
                            {
                                if (_argCount == 5)
                                {
                                    var position = _p0_UnityEngine_Rect;
                                    var label = _p1_System_String;
                                    var selectedValue = _p2_System_Int32;
                                    var displayedOptions = _p3_System_StringArray;
                                    var optionValues = _p4_System_Int32Array;
                                    var _ret0 = global::UnityEditor.EditorGUI.IntPopup(position, label, selectedValue, displayedOptions, optionValues);
                                    var _lret0 = new global::Lua.LuaValue(_ret0);
                                    var _retCount = _context.Return(_lret0);
                                    return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                                }
                                var _arg5 = _lastArg = _argCount > 5 ? _context.GetArgument(5) : global::Lua.LuaValue.Nil;
                                _lastArgPos = 5; _expectedType = typeof(global::UnityEngine.GUIStyle);
                                if (_arg5.TryRead<global::UnityEngine.GUIStyle>(out var _p5_UnityEngine_GUIStyle))
                                {
                                    if (_argCount == 6)
                                    {
                                        var position = _p0_UnityEngine_Rect;
                                        var label = _p1_System_String;
                                        var selectedValue = _p2_System_Int32;
                                        var displayedOptions = _p3_System_StringArray;
                                        var optionValues = _p4_System_Int32Array;
                                        var style = _p5_UnityEngine_GUIStyle;
                                        var _ret0 = global::UnityEditor.EditorGUI.IntPopup(position, label, selectedValue, displayedOptions, optionValues, style);
                                        var _lret0 = new global::Lua.LuaValue(_ret0);
                                        var _retCount = _context.Return(_lret0);
                                        return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                                    }
                                }
                            }
                        }
                    }
                }
                _lastArgPos = 1; _expectedType = typeof(global::UnityEngine.GUIContent);
                if (_arg1.TryRead<global::UnityEngine.GUIContent>(out var _p1_UnityEngine_GUIContent))
                {
                    var _arg2 = _lastArg = _argCount > 2 ? _context.GetArgument(2) : global::Lua.LuaValue.Nil;
                    _lastArgPos = 2; _expectedType = typeof(global::System.Int32);
                    if (_arg2.TryRead<global::System.Int32>(out var _p2_System_Int32))
                    {
                        var _arg3 = _lastArg = _argCount > 3 ? _context.GetArgument(3) : global::Lua.LuaValue.Nil;
                        _lastArgPos = 3; _expectedType = typeof(global::UnityEngine.GUIContent[]);
                        if (_arg3.TryReadArray<global::UnityEngine.GUIContent>(out var _p3_UnityEngine_GUIContentArray))
                        {
                            var _arg4 = _lastArg = _argCount > 4 ? _context.GetArgument(4) : global::Lua.LuaValue.Nil;
                            _lastArgPos = 4; _expectedType = typeof(global::System.Int32[]);
                            if (_arg4.TryReadArray<global::System.Int32>(out var _p4_System_Int32Array))
                            {
                                if (_argCount == 5)
                                {
                                    var position = _p0_UnityEngine_Rect;
                                    var label = _p1_UnityEngine_GUIContent;
                                    var selectedValue = _p2_System_Int32;
                                    var displayedOptions = _p3_UnityEngine_GUIContentArray;
                                    var optionValues = _p4_System_Int32Array;
                                    var _ret0 = global::UnityEditor.EditorGUI.IntPopup(position, label, selectedValue, displayedOptions, optionValues);
                                    var _lret0 = new global::Lua.LuaValue(_ret0);
                                    var _retCount = _context.Return(_lret0);
                                    return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                                }
                                var _arg5 = _lastArg = _argCount > 5 ? _context.GetArgument(5) : global::Lua.LuaValue.Nil;
                                _lastArgPos = 5; _expectedType = typeof(global::UnityEngine.GUIStyle);
                                if (_arg5.TryRead<global::UnityEngine.GUIStyle>(out var _p5_UnityEngine_GUIStyle))
                                {
                                    if (_argCount == 6)
                                    {
                                        var position = _p0_UnityEngine_Rect;
                                        var label = _p1_UnityEngine_GUIContent;
                                        var selectedValue = _p2_System_Int32;
                                        var displayedOptions = _p3_UnityEngine_GUIContentArray;
                                        var optionValues = _p4_System_Int32Array;
                                        var style = _p5_UnityEngine_GUIStyle;
                                        var _ret0 = global::UnityEditor.EditorGUI.IntPopup(position, label, selectedValue, displayedOptions, optionValues, style);
                                        var _lret0 = new global::Lua.LuaValue(_ret0);
                                        var _retCount = _context.Return(_lret0);
                                        return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                                    }
                                }
                            }
                        }
                    }
                }
            }
            throw new global::Lua.LuaRuntimeException(_context.Thread, $"{"IntPopup"}: invalid argument #{_lastArgPos}: {_lastArg} ({_lastArg.Type}), expected: {_expectedType.FullName}", 2);
        });
        private static readonly global::Lua.LuaFunction _LuaEditorGUI_IntSlider = new global::Lua.LuaFunction("IntSlider", (_context, _) =>
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
                _lastArgPos = 1; _expectedType = typeof(global::System.Int32);
                if (_arg1.TryRead<global::System.Int32>(out var _p1_System_Int32))
                {
                    var _arg2 = _lastArg = _argCount > 2 ? _context.GetArgument(2) : global::Lua.LuaValue.Nil;
                    _lastArgPos = 2; _expectedType = typeof(global::System.Int32);
                    if (_arg2.TryRead<global::System.Int32>(out var _p2_System_Int32))
                    {
                        var _arg3 = _lastArg = _argCount > 3 ? _context.GetArgument(3) : global::Lua.LuaValue.Nil;
                        _lastArgPos = 3; _expectedType = typeof(global::System.Int32);
                        if (_arg3.TryRead<global::System.Int32>(out var _p3_System_Int32))
                        {
                            if (_argCount == 4)
                            {
                                var position = _p0_UnityEngine_Rect;
                                var value = _p1_System_Int32;
                                var leftValue = _p2_System_Int32;
                                var rightValue = _p3_System_Int32;
                                var _ret0 = global::UnityEditor.EditorGUI.IntSlider(position, value, leftValue, rightValue);
                                var _lret0 = new global::Lua.LuaValue(_ret0);
                                var _retCount = _context.Return(_lret0);
                                return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                            }
                        }
                    }
                }
                _lastArgPos = 1; _expectedType = typeof(global::Luny.UnityEditor.LuaSerializedProperty);
                if (_arg1.TryRead<global::Luny.UnityEditor.LuaSerializedProperty>(out var _p1_UnityEditor_SerializedProperty))
                {
                    var _arg2 = _lastArg = _argCount > 2 ? _context.GetArgument(2) : global::Lua.LuaValue.Nil;
                    _lastArgPos = 2; _expectedType = typeof(global::System.Int32);
                    if (_arg2.TryRead<global::System.Int32>(out var _p2_System_Int32))
                    {
                        var _arg3 = _lastArg = _argCount > 3 ? _context.GetArgument(3) : global::Lua.LuaValue.Nil;
                        _lastArgPos = 3; _expectedType = typeof(global::System.Int32);
                        if (_arg3.TryRead<global::System.Int32>(out var _p3_System_Int32))
                        {
                            if (_argCount == 4)
                            {
                                var position = _p0_UnityEngine_Rect;
                                var property = _p1_UnityEditor_SerializedProperty.Instance;
                                var leftValue = _p2_System_Int32;
                                var rightValue = _p3_System_Int32;
                                global::UnityEditor.EditorGUI.IntSlider(position, property, leftValue, rightValue);
                                var _retCount = _context.Return();
                                return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                            }
                            var _arg4 = _lastArg = _argCount > 4 ? _context.GetArgument(4) : global::Lua.LuaValue.Nil;
                            _lastArgPos = 4; _expectedType = typeof(global::System.String);
                            if (_arg4.TryRead<global::System.String>(out var _p4_System_String))
                            {
                                if (_argCount == 5)
                                {
                                    var position = _p0_UnityEngine_Rect;
                                    var property = _p1_UnityEditor_SerializedProperty.Instance;
                                    var leftValue = _p2_System_Int32;
                                    var rightValue = _p3_System_Int32;
                                    var label = _p4_System_String;
                                    global::UnityEditor.EditorGUI.IntSlider(position, property, leftValue, rightValue, label);
                                    var _retCount = _context.Return();
                                    return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                                }
                            }
                            _lastArgPos = 4; _expectedType = typeof(global::UnityEngine.GUIContent);
                            if (_arg4.TryRead<global::UnityEngine.GUIContent>(out var _p4_UnityEngine_GUIContent))
                            {
                                if (_argCount == 5)
                                {
                                    var position = _p0_UnityEngine_Rect;
                                    var property = _p1_UnityEditor_SerializedProperty.Instance;
                                    var leftValue = _p2_System_Int32;
                                    var rightValue = _p3_System_Int32;
                                    var label = _p4_UnityEngine_GUIContent;
                                    global::UnityEditor.EditorGUI.IntSlider(position, property, leftValue, rightValue, label);
                                    var _retCount = _context.Return();
                                    return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                                }
                            }
                        }
                    }
                }
                _lastArgPos = 1; _expectedType = typeof(global::System.String);
                if (_arg1.TryRead<global::System.String>(out var _p1_System_String))
                {
                    var _arg2 = _lastArg = _argCount > 2 ? _context.GetArgument(2) : global::Lua.LuaValue.Nil;
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
                                if (_argCount == 5)
                                {
                                    var position = _p0_UnityEngine_Rect;
                                    var label = _p1_System_String;
                                    var value = _p2_System_Int32;
                                    var leftValue = _p3_System_Int32;
                                    var rightValue = _p4_System_Int32;
                                    var _ret0 = global::UnityEditor.EditorGUI.IntSlider(position, label, value, leftValue, rightValue);
                                    var _lret0 = new global::Lua.LuaValue(_ret0);
                                    var _retCount = _context.Return(_lret0);
                                    return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                                }
                            }
                        }
                    }
                }
                _lastArgPos = 1; _expectedType = typeof(global::UnityEngine.GUIContent);
                if (_arg1.TryRead<global::UnityEngine.GUIContent>(out var _p1_UnityEngine_GUIContent))
                {
                    var _arg2 = _lastArg = _argCount > 2 ? _context.GetArgument(2) : global::Lua.LuaValue.Nil;
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
                                if (_argCount == 5)
                                {
                                    var position = _p0_UnityEngine_Rect;
                                    var label = _p1_UnityEngine_GUIContent;
                                    var value = _p2_System_Int32;
                                    var leftValue = _p3_System_Int32;
                                    var rightValue = _p4_System_Int32;
                                    var _ret0 = global::UnityEditor.EditorGUI.IntSlider(position, label, value, leftValue, rightValue);
                                    var _lret0 = new global::Lua.LuaValue(_ret0);
                                    var _retCount = _context.Return(_lret0);
                                    return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                                }
                            }
                        }
                    }
                }
            }
            throw new global::Lua.LuaRuntimeException(_context.Thread, $"{"IntSlider"}: invalid argument #{_lastArgPos}: {_lastArg} ({_lastArg.Type}), expected: {_expectedType.FullName}", 2);
        });
        private static readonly global::Lua.LuaFunction _LuaEditorGUI_LabelField = new global::Lua.LuaFunction("LabelField", (_context, _) =>
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
                _lastArgPos = 1; _expectedType = typeof(global::System.String);
                if (_arg1.TryRead<global::System.String>(out var _p1_System_String))
                {
                    if (_argCount == 2)
                    {
                        var position = _p0_UnityEngine_Rect;
                        var label = _p1_System_String;
                        global::UnityEditor.EditorGUI.LabelField(position, label);
                        var _retCount = _context.Return();
                        return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                    }
                    var _arg2 = _lastArg = _argCount > 2 ? _context.GetArgument(2) : global::Lua.LuaValue.Nil;
                    _lastArgPos = 2; _expectedType = typeof(global::System.String);
                    if (_arg2.TryRead<global::System.String>(out var _p2_System_String))
                    {
                        if (_argCount == 3)
                        {
                            var position = _p0_UnityEngine_Rect;
                            var label = _p1_System_String;
                            var label2 = _p2_System_String;
                            global::UnityEditor.EditorGUI.LabelField(position, label, label2);
                            var _retCount = _context.Return();
                            return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                        }
                        var _arg3 = _lastArg = _argCount > 3 ? _context.GetArgument(3) : global::Lua.LuaValue.Nil;
                        _lastArgPos = 3; _expectedType = typeof(global::UnityEngine.GUIStyle);
                        if (_arg3.TryRead<global::UnityEngine.GUIStyle>(out var _p3_UnityEngine_GUIStyle))
                        {
                            if (_argCount == 4)
                            {
                                var position = _p0_UnityEngine_Rect;
                                var label = _p1_System_String;
                                var label2 = _p2_System_String;
                                var style = _p3_UnityEngine_GUIStyle;
                                global::UnityEditor.EditorGUI.LabelField(position, label, label2, style);
                                var _retCount = _context.Return();
                                return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                            }
                        }
                    }
                    _lastArgPos = 2; _expectedType = typeof(global::UnityEngine.GUIStyle);
                    if (_arg2.TryRead<global::UnityEngine.GUIStyle>(out var _p2_UnityEngine_GUIStyle))
                    {
                        if (_argCount == 3)
                        {
                            var position = _p0_UnityEngine_Rect;
                            var label = _p1_System_String;
                            var style = _p2_UnityEngine_GUIStyle;
                            global::UnityEditor.EditorGUI.LabelField(position, label, style);
                            var _retCount = _context.Return();
                            return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                        }
                    }
                }
                _lastArgPos = 1; _expectedType = typeof(global::UnityEngine.GUIContent);
                if (_arg1.TryRead<global::UnityEngine.GUIContent>(out var _p1_UnityEngine_GUIContent))
                {
                    if (_argCount == 2)
                    {
                        var position = _p0_UnityEngine_Rect;
                        var label = _p1_UnityEngine_GUIContent;
                        global::UnityEditor.EditorGUI.LabelField(position, label);
                        var _retCount = _context.Return();
                        return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                    }
                    var _arg2 = _lastArg = _argCount > 2 ? _context.GetArgument(2) : global::Lua.LuaValue.Nil;
                    _lastArgPos = 2; _expectedType = typeof(global::UnityEngine.GUIStyle);
                    if (_arg2.TryRead<global::UnityEngine.GUIStyle>(out var _p2_UnityEngine_GUIStyle))
                    {
                        if (_argCount == 3)
                        {
                            var position = _p0_UnityEngine_Rect;
                            var label = _p1_UnityEngine_GUIContent;
                            var style = _p2_UnityEngine_GUIStyle;
                            global::UnityEditor.EditorGUI.LabelField(position, label, style);
                            var _retCount = _context.Return();
                            return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                        }
                    }
                    _lastArgPos = 2; _expectedType = typeof(global::UnityEngine.GUIContent);
                    if (_arg2.TryRead<global::UnityEngine.GUIContent>(out var _p2_UnityEngine_GUIContent))
                    {
                        if (_argCount == 3)
                        {
                            var position = _p0_UnityEngine_Rect;
                            var label = _p1_UnityEngine_GUIContent;
                            var label2 = _p2_UnityEngine_GUIContent;
                            global::UnityEditor.EditorGUI.LabelField(position, label, label2);
                            var _retCount = _context.Return();
                            return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                        }
                        var _arg3 = _lastArg = _argCount > 3 ? _context.GetArgument(3) : global::Lua.LuaValue.Nil;
                        _lastArgPos = 3; _expectedType = typeof(global::UnityEngine.GUIStyle);
                        if (_arg3.TryRead<global::UnityEngine.GUIStyle>(out var _p3_UnityEngine_GUIStyle))
                        {
                            if (_argCount == 4)
                            {
                                var position = _p0_UnityEngine_Rect;
                                var label = _p1_UnityEngine_GUIContent;
                                var label2 = _p2_UnityEngine_GUIContent;
                                var style = _p3_UnityEngine_GUIStyle;
                                global::UnityEditor.EditorGUI.LabelField(position, label, label2, style);
                                var _retCount = _context.Return();
                                return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                            }
                        }
                    }
                }
            }
            throw new global::Lua.LuaRuntimeException(_context.Thread, $"{"LabelField"}: invalid argument #{_lastArgPos}: {_lastArg} ({_lastArg.Type}), expected: {_expectedType.FullName}", 2);
        });
        private static readonly global::Lua.LuaFunction _LuaEditorGUI_LargeSplitButtonWithDropdownList = new global::Lua.LuaFunction("LargeSplitButtonWithDropdownList", (_context, _) =>
        {
            global::Lua.LuaValue _lastArg = default;
            global::System.Int32 _lastArgPos = default;
            global::System.Type _expectedType = default;
            var _argCount = _context.ArgumentCount;
            var _arg0 = _lastArg = _argCount > 0 ? _context.GetArgument(0) : global::Lua.LuaValue.Nil;
            _lastArgPos = 0; _expectedType = typeof(global::UnityEngine.GUIContent);
            if (_arg0.TryRead<global::UnityEngine.GUIContent>(out var _p0_UnityEngine_GUIContent))
            {
                var _arg1 = _lastArg = _argCount > 1 ? _context.GetArgument(1) : global::Lua.LuaValue.Nil;
                _lastArgPos = 1; _expectedType = typeof(global::System.String[]);
                if (_arg1.TryReadArray<global::System.String>(out var _p1_System_StringArray))
                {
                    var _arg2 = _lastArg = _argCount > 2 ? _context.GetArgument(2) : global::Lua.LuaValue.Nil;
                    _lastArgPos = 2; _expectedType = typeof(global::UnityEditor.GenericMenu.MenuFunction2);
                    if (_arg2.TryRead<global::UnityEditor.GenericMenu.MenuFunction2>(out var _p2_UnityEditor_GenericMenu_MenuFunction2))
                    {
                        if (_argCount == 3)
                        {
                            var content = _p0_UnityEngine_GUIContent;
                            var buttonNames = _p1_System_StringArray;
                            var callback = _p2_UnityEditor_GenericMenu_MenuFunction2;
                            var _ret0 = global::UnityEditor.EditorGUI.LargeSplitButtonWithDropdownList(content, buttonNames, callback);
                            var _lret0 = new global::Lua.LuaValue(_ret0);
                            var _retCount = _context.Return(_lret0);
                            return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                        }
                        var _arg3 = _lastArg = _argCount > 3 ? _context.GetArgument(3) : global::Lua.LuaValue.Nil;
                        _lastArgPos = 3; _expectedType = typeof(global::System.Boolean);
                        if (_arg3.TryRead<global::System.Boolean>(out var _p3_System_Boolean))
                        {
                            if (_argCount == 4)
                            {
                                var content = _p0_UnityEngine_GUIContent;
                                var buttonNames = _p1_System_StringArray;
                                var callback = _p2_UnityEditor_GenericMenu_MenuFunction2;
                                var disableMainButton = _p3_System_Boolean;
                                var _ret0 = global::UnityEditor.EditorGUI.LargeSplitButtonWithDropdownList(content, buttonNames, callback, disableMainButton);
                                var _lret0 = new global::Lua.LuaValue(_ret0);
                                var _retCount = _context.Return(_lret0);
                                return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                            }
                        }
                    }
                }
            }
            throw new global::Lua.LuaRuntimeException(_context.Thread, $"{"LargeSplitButtonWithDropdownList"}: invalid argument #{_lastArgPos}: {_lastArg} ({_lastArg.Type}), expected: {_expectedType.FullName}", 2);
        });
        private static readonly global::Lua.LuaFunction _LuaEditorGUI_LayerField = new global::Lua.LuaFunction("LayerField", (_context, _) =>
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
                _lastArgPos = 1; _expectedType = typeof(global::System.Int32);
                if (_arg1.TryRead<global::System.Int32>(out var _p1_System_Int32))
                {
                    if (_argCount == 2)
                    {
                        var position = _p0_UnityEngine_Rect;
                        var layer = _p1_System_Int32;
                        var _ret0 = global::UnityEditor.EditorGUI.LayerField(position, layer);
                        var _lret0 = new global::Lua.LuaValue(_ret0);
                        var _retCount = _context.Return(_lret0);
                        return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                    }
                    var _arg2 = _lastArg = _argCount > 2 ? _context.GetArgument(2) : global::Lua.LuaValue.Nil;
                    _lastArgPos = 2; _expectedType = typeof(global::UnityEngine.GUIStyle);
                    if (_arg2.TryRead<global::UnityEngine.GUIStyle>(out var _p2_UnityEngine_GUIStyle))
                    {
                        if (_argCount == 3)
                        {
                            var position = _p0_UnityEngine_Rect;
                            var layer = _p1_System_Int32;
                            var style = _p2_UnityEngine_GUIStyle;
                            var _ret0 = global::UnityEditor.EditorGUI.LayerField(position, layer, style);
                            var _lret0 = new global::Lua.LuaValue(_ret0);
                            var _retCount = _context.Return(_lret0);
                            return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                        }
                    }
                }
                _lastArgPos = 1; _expectedType = typeof(global::System.String);
                if (_arg1.TryRead<global::System.String>(out var _p1_System_String))
                {
                    var _arg2 = _lastArg = _argCount > 2 ? _context.GetArgument(2) : global::Lua.LuaValue.Nil;
                    _lastArgPos = 2; _expectedType = typeof(global::System.Int32);
                    if (_arg2.TryRead<global::System.Int32>(out var _p2_System_Int32))
                    {
                        if (_argCount == 3)
                        {
                            var position = _p0_UnityEngine_Rect;
                            var label = _p1_System_String;
                            var layer = _p2_System_Int32;
                            var _ret0 = global::UnityEditor.EditorGUI.LayerField(position, label, layer);
                            var _lret0 = new global::Lua.LuaValue(_ret0);
                            var _retCount = _context.Return(_lret0);
                            return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                        }
                        var _arg3 = _lastArg = _argCount > 3 ? _context.GetArgument(3) : global::Lua.LuaValue.Nil;
                        _lastArgPos = 3; _expectedType = typeof(global::UnityEngine.GUIStyle);
                        if (_arg3.TryRead<global::UnityEngine.GUIStyle>(out var _p3_UnityEngine_GUIStyle))
                        {
                            if (_argCount == 4)
                            {
                                var position = _p0_UnityEngine_Rect;
                                var label = _p1_System_String;
                                var layer = _p2_System_Int32;
                                var style = _p3_UnityEngine_GUIStyle;
                                var _ret0 = global::UnityEditor.EditorGUI.LayerField(position, label, layer, style);
                                var _lret0 = new global::Lua.LuaValue(_ret0);
                                var _retCount = _context.Return(_lret0);
                                return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                            }
                        }
                    }
                }
                _lastArgPos = 1; _expectedType = typeof(global::UnityEngine.GUIContent);
                if (_arg1.TryRead<global::UnityEngine.GUIContent>(out var _p1_UnityEngine_GUIContent))
                {
                    var _arg2 = _lastArg = _argCount > 2 ? _context.GetArgument(2) : global::Lua.LuaValue.Nil;
                    _lastArgPos = 2; _expectedType = typeof(global::System.Int32);
                    if (_arg2.TryRead<global::System.Int32>(out var _p2_System_Int32))
                    {
                        if (_argCount == 3)
                        {
                            var position = _p0_UnityEngine_Rect;
                            var label = _p1_UnityEngine_GUIContent;
                            var layer = _p2_System_Int32;
                            var _ret0 = global::UnityEditor.EditorGUI.LayerField(position, label, layer);
                            var _lret0 = new global::Lua.LuaValue(_ret0);
                            var _retCount = _context.Return(_lret0);
                            return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                        }
                        var _arg3 = _lastArg = _argCount > 3 ? _context.GetArgument(3) : global::Lua.LuaValue.Nil;
                        _lastArgPos = 3; _expectedType = typeof(global::UnityEngine.GUIStyle);
                        if (_arg3.TryRead<global::UnityEngine.GUIStyle>(out var _p3_UnityEngine_GUIStyle))
                        {
                            if (_argCount == 4)
                            {
                                var position = _p0_UnityEngine_Rect;
                                var label = _p1_UnityEngine_GUIContent;
                                var layer = _p2_System_Int32;
                                var style = _p3_UnityEngine_GUIStyle;
                                var _ret0 = global::UnityEditor.EditorGUI.LayerField(position, label, layer, style);
                                var _lret0 = new global::Lua.LuaValue(_ret0);
                                var _retCount = _context.Return(_lret0);
                                return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                            }
                        }
                    }
                }
            }
            throw new global::Lua.LuaRuntimeException(_context.Thread, $"{"LayerField"}: invalid argument #{_lastArgPos}: {_lastArg} ({_lastArg.Type}), expected: {_expectedType.FullName}", 2);
        });
        private static readonly global::Lua.LuaFunction _LuaEditorGUI_LinkButton = new global::Lua.LuaFunction("LinkButton", (_context, _) =>
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
                _lastArgPos = 1; _expectedType = typeof(global::System.String);
                if (_arg1.TryRead<global::System.String>(out var _p1_System_String))
                {
                    if (_argCount == 2)
                    {
                        var position = _p0_UnityEngine_Rect;
                        var label = _p1_System_String;
                        var _ret0 = global::UnityEditor.EditorGUI.LinkButton(position, label);
                        var _lret0 = new global::Lua.LuaValue(_ret0);
                        var _retCount = _context.Return(_lret0);
                        return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                    }
                }
                _lastArgPos = 1; _expectedType = typeof(global::UnityEngine.GUIContent);
                if (_arg1.TryRead<global::UnityEngine.GUIContent>(out var _p1_UnityEngine_GUIContent))
                {
                    if (_argCount == 2)
                    {
                        var position = _p0_UnityEngine_Rect;
                        var label = _p1_UnityEngine_GUIContent;
                        var _ret0 = global::UnityEditor.EditorGUI.LinkButton(position, label);
                        var _lret0 = new global::Lua.LuaValue(_ret0);
                        var _retCount = _context.Return(_lret0);
                        return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                    }
                }
            }
            throw new global::Lua.LuaRuntimeException(_context.Thread, $"{"LinkButton"}: invalid argument #{_lastArgPos}: {_lastArg} ({_lastArg.Type}), expected: {_expectedType.FullName}", 2);
        });
        private static readonly global::Lua.LuaFunction _LuaEditorGUI_LogarithmicIntSlider = new global::Lua.LuaFunction("LogarithmicIntSlider", (_context, _) =>
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
                _lastArgPos = 1; _expectedType = typeof(global::System.String);
                if (_arg1.TryRead<global::System.String>(out var _p1_System_String))
                {
                    var _arg2 = _lastArg = _argCount > 2 ? _context.GetArgument(2) : global::Lua.LuaValue.Nil;
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
                                        _lastArgPos = 7; _expectedType = typeof(global::System.Int32);
                                        if (_arg7.TryRead<global::System.Int32>(out var _p7_System_Int32))
                                        {
                                            if (_argCount == 8)
                                            {
                                                var position = _p0_UnityEngine_Rect;
                                                var label = _p1_System_String;
                                                var sliderValue = _p2_System_Int32;
                                                var leftValue = _p3_System_Int32;
                                                var rightValue = _p4_System_Int32;
                                                var logbase = _p5_System_Int32;
                                                var textFieldMin = _p6_System_Int32;
                                                var textFieldMax = _p7_System_Int32;
                                                var _ret0 = global::UnityEditor.EditorGUI.LogarithmicIntSlider(position, label, sliderValue, leftValue, rightValue, logbase, textFieldMin, textFieldMax);
                                                var _lret0 = new global::Lua.LuaValue(_ret0);
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
                _lastArgPos = 1; _expectedType = typeof(global::UnityEngine.GUIContent);
                if (_arg1.TryRead<global::UnityEngine.GUIContent>(out var _p1_UnityEngine_GUIContent))
                {
                    var _arg2 = _lastArg = _argCount > 2 ? _context.GetArgument(2) : global::Lua.LuaValue.Nil;
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
                                        _lastArgPos = 7; _expectedType = typeof(global::System.Int32);
                                        if (_arg7.TryRead<global::System.Int32>(out var _p7_System_Int32))
                                        {
                                            if (_argCount == 8)
                                            {
                                                var position = _p0_UnityEngine_Rect;
                                                var label = _p1_UnityEngine_GUIContent;
                                                var sliderValue = _p2_System_Int32;
                                                var leftValue = _p3_System_Int32;
                                                var rightValue = _p4_System_Int32;
                                                var logbase = _p5_System_Int32;
                                                var textFieldMin = _p6_System_Int32;
                                                var textFieldMax = _p7_System_Int32;
                                                var _ret0 = global::UnityEditor.EditorGUI.LogarithmicIntSlider(position, label, sliderValue, leftValue, rightValue, logbase, textFieldMin, textFieldMax);
                                                var _lret0 = new global::Lua.LuaValue(_ret0);
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
            throw new global::Lua.LuaRuntimeException(_context.Thread, $"{"LogarithmicIntSlider"}: invalid argument #{_lastArgPos}: {_lastArg} ({_lastArg.Type}), expected: {_expectedType.FullName}", 2);
        });
        private static readonly global::Lua.LuaFunction _LuaEditorGUI_LongField = new global::Lua.LuaFunction("LongField", (_context, _) =>
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
                _lastArgPos = 1; _expectedType = typeof(global::System.Int64);
                if (_arg1.TryRead<global::System.Int64>(out var _p1_System_Int64))
                {
                    if (_argCount == 2)
                    {
                        var position = _p0_UnityEngine_Rect;
                        var value = _p1_System_Int64;
                        var _ret0 = global::UnityEditor.EditorGUI.LongField(position, value);
                        var _lret0 = new global::Lua.LuaValue(_ret0);
                        var _retCount = _context.Return(_lret0);
                        return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                    }
                    var _arg2 = _lastArg = _argCount > 2 ? _context.GetArgument(2) : global::Lua.LuaValue.Nil;
                    _lastArgPos = 2; _expectedType = typeof(global::UnityEngine.GUIStyle);
                    if (_arg2.TryRead<global::UnityEngine.GUIStyle>(out var _p2_UnityEngine_GUIStyle))
                    {
                        if (_argCount == 3)
                        {
                            var position = _p0_UnityEngine_Rect;
                            var value = _p1_System_Int64;
                            var style = _p2_UnityEngine_GUIStyle;
                            var _ret0 = global::UnityEditor.EditorGUI.LongField(position, value, style);
                            var _lret0 = new global::Lua.LuaValue(_ret0);
                            var _retCount = _context.Return(_lret0);
                            return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                        }
                    }
                }
                _lastArgPos = 1; _expectedType = typeof(global::System.String);
                if (_arg1.TryRead<global::System.String>(out var _p1_System_String))
                {
                    var _arg2 = _lastArg = _argCount > 2 ? _context.GetArgument(2) : global::Lua.LuaValue.Nil;
                    _lastArgPos = 2; _expectedType = typeof(global::System.Int64);
                    if (_arg2.TryRead<global::System.Int64>(out var _p2_System_Int64))
                    {
                        if (_argCount == 3)
                        {
                            var position = _p0_UnityEngine_Rect;
                            var label = _p1_System_String;
                            var value = _p2_System_Int64;
                            var _ret0 = global::UnityEditor.EditorGUI.LongField(position, label, value);
                            var _lret0 = new global::Lua.LuaValue(_ret0);
                            var _retCount = _context.Return(_lret0);
                            return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                        }
                        var _arg3 = _lastArg = _argCount > 3 ? _context.GetArgument(3) : global::Lua.LuaValue.Nil;
                        _lastArgPos = 3; _expectedType = typeof(global::UnityEngine.GUIStyle);
                        if (_arg3.TryRead<global::UnityEngine.GUIStyle>(out var _p3_UnityEngine_GUIStyle))
                        {
                            if (_argCount == 4)
                            {
                                var position = _p0_UnityEngine_Rect;
                                var label = _p1_System_String;
                                var value = _p2_System_Int64;
                                var style = _p3_UnityEngine_GUIStyle;
                                var _ret0 = global::UnityEditor.EditorGUI.LongField(position, label, value, style);
                                var _lret0 = new global::Lua.LuaValue(_ret0);
                                var _retCount = _context.Return(_lret0);
                                return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                            }
                        }
                    }
                }
                _lastArgPos = 1; _expectedType = typeof(global::UnityEngine.GUIContent);
                if (_arg1.TryRead<global::UnityEngine.GUIContent>(out var _p1_UnityEngine_GUIContent))
                {
                    var _arg2 = _lastArg = _argCount > 2 ? _context.GetArgument(2) : global::Lua.LuaValue.Nil;
                    _lastArgPos = 2; _expectedType = typeof(global::System.Int64);
                    if (_arg2.TryRead<global::System.Int64>(out var _p2_System_Int64))
                    {
                        if (_argCount == 3)
                        {
                            var position = _p0_UnityEngine_Rect;
                            var label = _p1_UnityEngine_GUIContent;
                            var value = _p2_System_Int64;
                            var _ret0 = global::UnityEditor.EditorGUI.LongField(position, label, value);
                            var _lret0 = new global::Lua.LuaValue(_ret0);
                            var _retCount = _context.Return(_lret0);
                            return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                        }
                        var _arg3 = _lastArg = _argCount > 3 ? _context.GetArgument(3) : global::Lua.LuaValue.Nil;
                        _lastArgPos = 3; _expectedType = typeof(global::UnityEngine.GUIStyle);
                        if (_arg3.TryRead<global::UnityEngine.GUIStyle>(out var _p3_UnityEngine_GUIStyle))
                        {
                            if (_argCount == 4)
                            {
                                var position = _p0_UnityEngine_Rect;
                                var label = _p1_UnityEngine_GUIContent;
                                var value = _p2_System_Int64;
                                var style = _p3_UnityEngine_GUIStyle;
                                var _ret0 = global::UnityEditor.EditorGUI.LongField(position, label, value, style);
                                var _lret0 = new global::Lua.LuaValue(_ret0);
                                var _retCount = _context.Return(_lret0);
                                return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                            }
                        }
                    }
                }
            }
            throw new global::Lua.LuaRuntimeException(_context.Thread, $"{"LongField"}: invalid argument #{_lastArgPos}: {_lastArg} ({_lastArg.Type}), expected: {_expectedType.FullName}", 2);
        });
        private static readonly global::Lua.LuaFunction _LuaEditorGUI_MaskField = new global::Lua.LuaFunction("MaskField", (_context, _) =>
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
                _lastArgPos = 1; _expectedType = typeof(global::System.Int32);
                if (_arg1.TryRead<global::System.Int32>(out var _p1_System_Int32))
                {
                    var _arg2 = _lastArg = _argCount > 2 ? _context.GetArgument(2) : global::Lua.LuaValue.Nil;
                    _lastArgPos = 2; _expectedType = typeof(global::System.String[]);
                    if (_arg2.TryReadArray<global::System.String>(out var _p2_System_StringArray))
                    {
                        if (_argCount == 3)
                        {
                            var position = _p0_UnityEngine_Rect;
                            var mask = _p1_System_Int32;
                            var displayedOptions = _p2_System_StringArray;
                            var _ret0 = global::UnityEditor.EditorGUI.MaskField(position, mask, displayedOptions);
                            var _lret0 = new global::Lua.LuaValue(_ret0);
                            var _retCount = _context.Return(_lret0);
                            return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                        }
                        var _arg3 = _lastArg = _argCount > 3 ? _context.GetArgument(3) : global::Lua.LuaValue.Nil;
                        _lastArgPos = 3; _expectedType = typeof(global::UnityEngine.GUIStyle);
                        if (_arg3.TryRead<global::UnityEngine.GUIStyle>(out var _p3_UnityEngine_GUIStyle))
                        {
                            if (_argCount == 4)
                            {
                                var position = _p0_UnityEngine_Rect;
                                var mask = _p1_System_Int32;
                                var displayedOptions = _p2_System_StringArray;
                                var style = _p3_UnityEngine_GUIStyle;
                                var _ret0 = global::UnityEditor.EditorGUI.MaskField(position, mask, displayedOptions, style);
                                var _lret0 = new global::Lua.LuaValue(_ret0);
                                var _retCount = _context.Return(_lret0);
                                return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                            }
                        }
                    }
                }
                _lastArgPos = 1; _expectedType = typeof(global::System.String);
                if (_arg1.TryRead<global::System.String>(out var _p1_System_String))
                {
                    var _arg2 = _lastArg = _argCount > 2 ? _context.GetArgument(2) : global::Lua.LuaValue.Nil;
                    _lastArgPos = 2; _expectedType = typeof(global::System.Int32);
                    if (_arg2.TryRead<global::System.Int32>(out var _p2_System_Int32))
                    {
                        var _arg3 = _lastArg = _argCount > 3 ? _context.GetArgument(3) : global::Lua.LuaValue.Nil;
                        _lastArgPos = 3; _expectedType = typeof(global::System.String[]);
                        if (_arg3.TryReadArray<global::System.String>(out var _p3_System_StringArray))
                        {
                            if (_argCount == 4)
                            {
                                var position = _p0_UnityEngine_Rect;
                                var label = _p1_System_String;
                                var mask = _p2_System_Int32;
                                var displayedOptions = _p3_System_StringArray;
                                var _ret0 = global::UnityEditor.EditorGUI.MaskField(position, label, mask, displayedOptions);
                                var _lret0 = new global::Lua.LuaValue(_ret0);
                                var _retCount = _context.Return(_lret0);
                                return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                            }
                            var _arg4 = _lastArg = _argCount > 4 ? _context.GetArgument(4) : global::Lua.LuaValue.Nil;
                            _lastArgPos = 4; _expectedType = typeof(global::UnityEngine.GUIStyle);
                            if (_arg4.TryRead<global::UnityEngine.GUIStyle>(out var _p4_UnityEngine_GUIStyle))
                            {
                                if (_argCount == 5)
                                {
                                    var position = _p0_UnityEngine_Rect;
                                    var label = _p1_System_String;
                                    var mask = _p2_System_Int32;
                                    var displayedOptions = _p3_System_StringArray;
                                    var style = _p4_UnityEngine_GUIStyle;
                                    var _ret0 = global::UnityEditor.EditorGUI.MaskField(position, label, mask, displayedOptions, style);
                                    var _lret0 = new global::Lua.LuaValue(_ret0);
                                    var _retCount = _context.Return(_lret0);
                                    return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                                }
                            }
                        }
                    }
                }
                _lastArgPos = 1; _expectedType = typeof(global::UnityEngine.GUIContent);
                if (_arg1.TryRead<global::UnityEngine.GUIContent>(out var _p1_UnityEngine_GUIContent))
                {
                    var _arg2 = _lastArg = _argCount > 2 ? _context.GetArgument(2) : global::Lua.LuaValue.Nil;
                    _lastArgPos = 2; _expectedType = typeof(global::System.Int32);
                    if (_arg2.TryRead<global::System.Int32>(out var _p2_System_Int32))
                    {
                        var _arg3 = _lastArg = _argCount > 3 ? _context.GetArgument(3) : global::Lua.LuaValue.Nil;
                        _lastArgPos = 3; _expectedType = typeof(global::System.String[]);
                        if (_arg3.TryReadArray<global::System.String>(out var _p3_System_StringArray))
                        {
                            if (_argCount == 4)
                            {
                                var position = _p0_UnityEngine_Rect;
                                var label = _p1_UnityEngine_GUIContent;
                                var mask = _p2_System_Int32;
                                var displayedOptions = _p3_System_StringArray;
                                var _ret0 = global::UnityEditor.EditorGUI.MaskField(position, label, mask, displayedOptions);
                                var _lret0 = new global::Lua.LuaValue(_ret0);
                                var _retCount = _context.Return(_lret0);
                                return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                            }
                            var _arg4 = _lastArg = _argCount > 4 ? _context.GetArgument(4) : global::Lua.LuaValue.Nil;
                            _lastArgPos = 4; _expectedType = typeof(global::UnityEngine.GUIStyle);
                            if (_arg4.TryRead<global::UnityEngine.GUIStyle>(out var _p4_UnityEngine_GUIStyle))
                            {
                                if (_argCount == 5)
                                {
                                    var position = _p0_UnityEngine_Rect;
                                    var label = _p1_UnityEngine_GUIContent;
                                    var mask = _p2_System_Int32;
                                    var displayedOptions = _p3_System_StringArray;
                                    var style = _p4_UnityEngine_GUIStyle;
                                    var _ret0 = global::UnityEditor.EditorGUI.MaskField(position, label, mask, displayedOptions, style);
                                    var _lret0 = new global::Lua.LuaValue(_ret0);
                                    var _retCount = _context.Return(_lret0);
                                    return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                                }
                            }
                        }
                    }
                }
            }
            throw new global::Lua.LuaRuntimeException(_context.Thread, $"{"MaskField"}: invalid argument #{_lastArgPos}: {_lastArg} ({_lastArg.Type}), expected: {_expectedType.FullName}", 2);
        });
        private static readonly global::Lua.LuaFunction _LuaEditorGUI_MultiFloatField = new global::Lua.LuaFunction("MultiFloatField", (_context, _) =>
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
                _lastArgPos = 1; _expectedType = typeof(global::UnityEngine.GUIContent[]);
                if (_arg1.TryReadArray<global::UnityEngine.GUIContent>(out var _p1_UnityEngine_GUIContentArray))
                {
                    var _arg2 = _lastArg = _argCount > 2 ? _context.GetArgument(2) : global::Lua.LuaValue.Nil;
                    _lastArgPos = 2; _expectedType = typeof(global::System.Single[]);
                    if (_arg2.TryReadArray<global::System.Single>(out var _p2_System_SingleArray))
                    {
                        if (_argCount == 3)
                        {
                            var position = _p0_UnityEngine_Rect;
                            var subLabels = _p1_UnityEngine_GUIContentArray;
                            var values = _p2_System_SingleArray;
                            global::UnityEditor.EditorGUI.MultiFloatField(position, subLabels, values);
                            var _retCount = _context.Return();
                            return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                        }
                    }
                }
                _lastArgPos = 1; _expectedType = typeof(global::UnityEngine.GUIContent);
                if (_arg1.TryRead<global::UnityEngine.GUIContent>(out var _p1_UnityEngine_GUIContent))
                {
                    var _arg2 = _lastArg = _argCount > 2 ? _context.GetArgument(2) : global::Lua.LuaValue.Nil;
                    _lastArgPos = 2; _expectedType = typeof(global::UnityEngine.GUIContent[]);
                    if (_arg2.TryReadArray<global::UnityEngine.GUIContent>(out var _p2_UnityEngine_GUIContentArray))
                    {
                        var _arg3 = _lastArg = _argCount > 3 ? _context.GetArgument(3) : global::Lua.LuaValue.Nil;
                        _lastArgPos = 3; _expectedType = typeof(global::System.Single[]);
                        if (_arg3.TryReadArray<global::System.Single>(out var _p3_System_SingleArray))
                        {
                            if (_argCount == 4)
                            {
                                var position = _p0_UnityEngine_Rect;
                                var label = _p1_UnityEngine_GUIContent;
                                var subLabels = _p2_UnityEngine_GUIContentArray;
                                var values = _p3_System_SingleArray;
                                global::UnityEditor.EditorGUI.MultiFloatField(position, label, subLabels, values);
                                var _retCount = _context.Return();
                                return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                            }
                        }
                    }
                }
            }
            throw new global::Lua.LuaRuntimeException(_context.Thread, $"{"MultiFloatField"}: invalid argument #{_lastArgPos}: {_lastArg} ({_lastArg.Type}), expected: {_expectedType.FullName}", 2);
        });
        private static readonly global::Lua.LuaFunction _LuaEditorGUI_MultiIntField = new global::Lua.LuaFunction("MultiIntField", (_context, _) =>
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
                _lastArgPos = 1; _expectedType = typeof(global::UnityEngine.GUIContent[]);
                if (_arg1.TryReadArray<global::UnityEngine.GUIContent>(out var _p1_UnityEngine_GUIContentArray))
                {
                    var _arg2 = _lastArg = _argCount > 2 ? _context.GetArgument(2) : global::Lua.LuaValue.Nil;
                    _lastArgPos = 2; _expectedType = typeof(global::System.Int32[]);
                    if (_arg2.TryReadArray<global::System.Int32>(out var _p2_System_Int32Array))
                    {
                        if (_argCount == 3)
                        {
                            var position = _p0_UnityEngine_Rect;
                            var subLabels = _p1_UnityEngine_GUIContentArray;
                            var values = _p2_System_Int32Array;
                            global::UnityEditor.EditorGUI.MultiIntField(position, subLabels, values);
                            var _retCount = _context.Return();
                            return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                        }
                    }
                }
            }
            throw new global::Lua.LuaRuntimeException(_context.Thread, $"{"MultiIntField"}: invalid argument #{_lastArgPos}: {_lastArg} ({_lastArg.Type}), expected: {_expectedType.FullName}", 2);
        });
        private static readonly global::Lua.LuaFunction _LuaEditorGUI_MultiPropertyField = new global::Lua.LuaFunction("MultiPropertyField", (_context, _) =>
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
                _lastArgPos = 1; _expectedType = typeof(global::UnityEngine.GUIContent[]);
                if (_arg1.TryReadArray<global::UnityEngine.GUIContent>(out var _p1_UnityEngine_GUIContentArray))
                {
                    var _arg2 = _lastArg = _argCount > 2 ? _context.GetArgument(2) : global::Lua.LuaValue.Nil;
                    _lastArgPos = 2; _expectedType = typeof(global::Luny.UnityEditor.LuaSerializedProperty);
                    if (_arg2.TryRead<global::Luny.UnityEditor.LuaSerializedProperty>(out var _p2_UnityEditor_SerializedProperty))
                    {
                        if (_argCount == 3)
                        {
                            var position = _p0_UnityEngine_Rect;
                            var subLabels = _p1_UnityEngine_GUIContentArray;
                            var valuesIterator = _p2_UnityEditor_SerializedProperty.Instance;
                            global::UnityEditor.EditorGUI.MultiPropertyField(position, subLabels, valuesIterator);
                            var _retCount = _context.Return();
                            return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                        }
                        var _arg3 = _lastArg = _argCount > 3 ? _context.GetArgument(3) : global::Lua.LuaValue.Nil;
                        _lastArgPos = 3; _expectedType = typeof(global::UnityEditor.EditorGUI.PropertyVisibility);
                        if (_arg3.TryRead<global::UnityEditor.EditorGUI.PropertyVisibility>(out var _p3_UnityEditor_EditorGUI_PropertyVisibility))
                        {
                            if (_argCount == 4)
                            {
                                var position = _p0_UnityEngine_Rect;
                                var subLabels = _p1_UnityEngine_GUIContentArray;
                                var valuesIterator = _p2_UnityEditor_SerializedProperty.Instance;
                                var visibility = _p3_UnityEditor_EditorGUI_PropertyVisibility;
                                global::UnityEditor.EditorGUI.MultiPropertyField(position, subLabels, valuesIterator, visibility);
                                var _retCount = _context.Return();
                                return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                            }
                        }
                        _lastArgPos = 3; _expectedType = typeof(global::UnityEngine.GUIContent);
                        if (_arg3.TryRead<global::UnityEngine.GUIContent>(out var _p3_UnityEngine_GUIContent))
                        {
                            if (_argCount == 4)
                            {
                                var position = _p0_UnityEngine_Rect;
                                var subLabels = _p1_UnityEngine_GUIContentArray;
                                var valuesIterator = _p2_UnityEditor_SerializedProperty.Instance;
                                var label = _p3_UnityEngine_GUIContent;
                                global::UnityEditor.EditorGUI.MultiPropertyField(position, subLabels, valuesIterator, label);
                                var _retCount = _context.Return();
                                return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                            }
                            var _arg4 = _lastArg = _argCount > 4 ? _context.GetArgument(4) : global::Lua.LuaValue.Nil;
                            _lastArgPos = 4; _expectedType = typeof(global::UnityEditor.EditorGUI.PropertyVisibility);
                            if (_arg4.TryRead<global::UnityEditor.EditorGUI.PropertyVisibility>(out var _p4_UnityEditor_EditorGUI_PropertyVisibility))
                            {
                                if (_argCount == 5)
                                {
                                    var position = _p0_UnityEngine_Rect;
                                    var subLabels = _p1_UnityEngine_GUIContentArray;
                                    var valuesIterator = _p2_UnityEditor_SerializedProperty.Instance;
                                    var label = _p3_UnityEngine_GUIContent;
                                    var visibility = _p4_UnityEditor_EditorGUI_PropertyVisibility;
                                    global::UnityEditor.EditorGUI.MultiPropertyField(position, subLabels, valuesIterator, label, visibility);
                                    var _retCount = _context.Return();
                                    return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                                }
                            }
                        }
                    }
                }
            }
            throw new global::Lua.LuaRuntimeException(_context.Thread, $"{"MultiPropertyField"}: invalid argument #{_lastArgPos}: {_lastArg} ({_lastArg.Type}), expected: {_expectedType.FullName}", 2);
        });
        private static readonly global::Lua.LuaFunction _LuaEditorGUI_ObjectField = new global::Lua.LuaFunction("ObjectField", (_context, _) =>
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
                    if (_argCount == 2)
                    {
                        var position = _p0_UnityEngine_Rect;
                        var property = _p1_UnityEditor_SerializedProperty.Instance;
                        global::UnityEditor.EditorGUI.ObjectField(position, property);
                        var _retCount = _context.Return();
                        return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                    }
                    var _arg2 = _lastArg = _argCount > 2 ? _context.GetArgument(2) : global::Lua.LuaValue.Nil;
                    _lastArgPos = 2; _expectedType = typeof(global::UnityEngine.GUIContent);
                    if (_arg2.TryRead<global::UnityEngine.GUIContent>(out var _p2_UnityEngine_GUIContent))
                    {
                        if (_argCount == 3)
                        {
                            var position = _p0_UnityEngine_Rect;
                            var property = _p1_UnityEditor_SerializedProperty.Instance;
                            var label = _p2_UnityEngine_GUIContent;
                            global::UnityEditor.EditorGUI.ObjectField(position, property, label);
                            var _retCount = _context.Return();
                            return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                        }
                    }
                    _lastArgPos = 2; _expectedType = typeof(global::Luny.ILuaBindType);
                    if (_arg2.TryRead<global::Luny.ILuaBindType>(out var _p2_System_Type))
                    {
                        if (_argCount == 3)
                        {
                            var position = _p0_UnityEngine_Rect;
                            var property = _p1_UnityEditor_SerializedProperty.Instance;
                            var objType = _p2_System_Type.BindType;
                            global::UnityEditor.EditorGUI.ObjectField(position, property, objType);
                            var _retCount = _context.Return();
                            return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                        }
                        var _arg3 = _lastArg = _argCount > 3 ? _context.GetArgument(3) : global::Lua.LuaValue.Nil;
                        _lastArgPos = 3; _expectedType = typeof(global::UnityEngine.GUIContent);
                        if (_arg3.TryRead<global::UnityEngine.GUIContent>(out var _p3_UnityEngine_GUIContent))
                        {
                            if (_argCount == 4)
                            {
                                var position = _p0_UnityEngine_Rect;
                                var property = _p1_UnityEditor_SerializedProperty.Instance;
                                var objType = _p2_System_Type.BindType;
                                var label = _p3_UnityEngine_GUIContent;
                                global::UnityEditor.EditorGUI.ObjectField(position, property, objType, label);
                                var _retCount = _context.Return();
                                return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                            }
                        }
                    }
                }
                _lastArgPos = 1; _expectedType = typeof(global::UnityEngine.Object);
                if (_arg1.TryRead<global::UnityEngine.Object>(out var _p1_UnityEngine_Object))
                {
                    var _arg2 = _lastArg = _argCount > 2 ? _context.GetArgument(2) : global::Lua.LuaValue.Nil;
                    _lastArgPos = 2; _expectedType = typeof(global::Luny.ILuaBindType);
                    if (_arg2.TryRead<global::Luny.ILuaBindType>(out var _p2_System_Type))
                    {
                        var _arg3 = _lastArg = _argCount > 3 ? _context.GetArgument(3) : global::Lua.LuaValue.Nil;
                        _lastArgPos = 3; _expectedType = typeof(global::System.Boolean);
                        if (_arg3.TryRead<global::System.Boolean>(out var _p3_System_Boolean))
                        {
                            if (_argCount == 4)
                            {
                                var position = _p0_UnityEngine_Rect;
                                var obj = _p1_UnityEngine_Object;
                                var objType = _p2_System_Type.BindType;
                                var allowSceneObjects = _p3_System_Boolean;
                                var _ret0 = global::UnityEditor.EditorGUI.ObjectField(position, obj, objType, allowSceneObjects);
                                var _factory = _context.GetObjectFactory();
                                var _lret0 = _factory.Bind(_ret0);
                                var _retCount = _context.Return(_lret0);
                                return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                            }
                        }
                        _lastArgPos = 3; _expectedType = typeof(global::UnityEngine.Object);
                        if (_arg3.TryRead<global::UnityEngine.Object>(out var _p3_UnityEngine_Object))
                        {
                            if (_argCount == 4)
                            {
                                var position = _p0_UnityEngine_Rect;
                                var obj = _p1_UnityEngine_Object;
                                var objType = _p2_System_Type.BindType;
                                var targetBeingEdited = _p3_UnityEngine_Object;
                                var _ret0 = global::UnityEditor.EditorGUI.ObjectField(position, obj, objType, targetBeingEdited);
                                var _factory = _context.GetObjectFactory();
                                var _lret0 = _factory.Bind(_ret0);
                                var _retCount = _context.Return(_lret0);
                                return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                            }
                        }
                    }
                }
                _lastArgPos = 1; _expectedType = typeof(global::System.String);
                if (_arg1.TryRead<global::System.String>(out var _p1_System_String))
                {
                    var _arg2 = _lastArg = _argCount > 2 ? _context.GetArgument(2) : global::Lua.LuaValue.Nil;
                    _lastArgPos = 2; _expectedType = typeof(global::UnityEngine.Object);
                    if (_arg2.TryRead<global::UnityEngine.Object>(out var _p2_UnityEngine_Object))
                    {
                        var _arg3 = _lastArg = _argCount > 3 ? _context.GetArgument(3) : global::Lua.LuaValue.Nil;
                        _lastArgPos = 3; _expectedType = typeof(global::Luny.ILuaBindType);
                        if (_arg3.TryRead<global::Luny.ILuaBindType>(out var _p3_System_Type))
                        {
                            var _arg4 = _lastArg = _argCount > 4 ? _context.GetArgument(4) : global::Lua.LuaValue.Nil;
                            _lastArgPos = 4; _expectedType = typeof(global::System.Boolean);
                            if (_arg4.TryRead<global::System.Boolean>(out var _p4_System_Boolean))
                            {
                                if (_argCount == 5)
                                {
                                    var position = _p0_UnityEngine_Rect;
                                    var label = _p1_System_String;
                                    var obj = _p2_UnityEngine_Object;
                                    var objType = _p3_System_Type.BindType;
                                    var allowSceneObjects = _p4_System_Boolean;
                                    var _ret0 = global::UnityEditor.EditorGUI.ObjectField(position, label, obj, objType, allowSceneObjects);
                                    var _factory = _context.GetObjectFactory();
                                    var _lret0 = _factory.Bind(_ret0);
                                    var _retCount = _context.Return(_lret0);
                                    return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                                }
                            }
                            _lastArgPos = 4; _expectedType = typeof(global::UnityEngine.Object);
                            if (_arg4.TryRead<global::UnityEngine.Object>(out var _p4_UnityEngine_Object))
                            {
                                if (_argCount == 5)
                                {
                                    var position = _p0_UnityEngine_Rect;
                                    var label = _p1_System_String;
                                    var obj = _p2_UnityEngine_Object;
                                    var objType = _p3_System_Type.BindType;
                                    var targetBeingEdited = _p4_UnityEngine_Object;
                                    var _ret0 = global::UnityEditor.EditorGUI.ObjectField(position, label, obj, objType, targetBeingEdited);
                                    var _factory = _context.GetObjectFactory();
                                    var _lret0 = _factory.Bind(_ret0);
                                    var _retCount = _context.Return(_lret0);
                                    return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                                }
                            }
                        }
                    }
                }
                _lastArgPos = 1; _expectedType = typeof(global::UnityEngine.GUIContent);
                if (_arg1.TryRead<global::UnityEngine.GUIContent>(out var _p1_UnityEngine_GUIContent))
                {
                    var _arg2 = _lastArg = _argCount > 2 ? _context.GetArgument(2) : global::Lua.LuaValue.Nil;
                    _lastArgPos = 2; _expectedType = typeof(global::UnityEngine.Object);
                    if (_arg2.TryRead<global::UnityEngine.Object>(out var _p2_UnityEngine_Object))
                    {
                        var _arg3 = _lastArg = _argCount > 3 ? _context.GetArgument(3) : global::Lua.LuaValue.Nil;
                        _lastArgPos = 3; _expectedType = typeof(global::Luny.ILuaBindType);
                        if (_arg3.TryRead<global::Luny.ILuaBindType>(out var _p3_System_Type))
                        {
                            var _arg4 = _lastArg = _argCount > 4 ? _context.GetArgument(4) : global::Lua.LuaValue.Nil;
                            _lastArgPos = 4; _expectedType = typeof(global::System.Boolean);
                            if (_arg4.TryRead<global::System.Boolean>(out var _p4_System_Boolean))
                            {
                                if (_argCount == 5)
                                {
                                    var position = _p0_UnityEngine_Rect;
                                    var label = _p1_UnityEngine_GUIContent;
                                    var obj = _p2_UnityEngine_Object;
                                    var objType = _p3_System_Type.BindType;
                                    var allowSceneObjects = _p4_System_Boolean;
                                    var _ret0 = global::UnityEditor.EditorGUI.ObjectField(position, label, obj, objType, allowSceneObjects);
                                    var _factory = _context.GetObjectFactory();
                                    var _lret0 = _factory.Bind(_ret0);
                                    var _retCount = _context.Return(_lret0);
                                    return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                                }
                            }
                            _lastArgPos = 4; _expectedType = typeof(global::UnityEngine.Object);
                            if (_arg4.TryRead<global::UnityEngine.Object>(out var _p4_UnityEngine_Object))
                            {
                                if (_argCount == 5)
                                {
                                    var position = _p0_UnityEngine_Rect;
                                    var label = _p1_UnityEngine_GUIContent;
                                    var obj = _p2_UnityEngine_Object;
                                    var objType = _p3_System_Type.BindType;
                                    var targetBeingEdited = _p4_UnityEngine_Object;
                                    var _ret0 = global::UnityEditor.EditorGUI.ObjectField(position, label, obj, objType, targetBeingEdited);
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
            throw new global::Lua.LuaRuntimeException(_context.Thread, $"{"ObjectField"}: invalid argument #{_lastArgPos}: {_lastArg} ({_lastArg.Type}), expected: {_expectedType.FullName}", 2);
        });
        private static readonly global::Lua.LuaFunction _LuaEditorGUI_PasswordField = new global::Lua.LuaFunction("PasswordField", (_context, _) =>
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
                _lastArgPos = 1; _expectedType = typeof(global::System.String);
                if (_arg1.TryRead<global::System.String>(out var _p1_System_String))
                {
                    if (_argCount == 2)
                    {
                        var position = _p0_UnityEngine_Rect;
                        var password = _p1_System_String;
                        var _ret0 = global::UnityEditor.EditorGUI.PasswordField(position, password);
                        var _lret0 = new global::Lua.LuaValue(_ret0);
                        var _retCount = _context.Return(_lret0);
                        return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                    }
                    var _arg2 = _lastArg = _argCount > 2 ? _context.GetArgument(2) : global::Lua.LuaValue.Nil;
                    _lastArgPos = 2; _expectedType = typeof(global::System.String);
                    if (_arg2.TryRead<global::System.String>(out var _p2_System_String))
                    {
                        if (_argCount == 3)
                        {
                            var position = _p0_UnityEngine_Rect;
                            var label = _p1_System_String;
                            var password = _p2_System_String;
                            var _ret0 = global::UnityEditor.EditorGUI.PasswordField(position, label, password);
                            var _lret0 = new global::Lua.LuaValue(_ret0);
                            var _retCount = _context.Return(_lret0);
                            return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                        }
                        var _arg3 = _lastArg = _argCount > 3 ? _context.GetArgument(3) : global::Lua.LuaValue.Nil;
                        _lastArgPos = 3; _expectedType = typeof(global::UnityEngine.GUIStyle);
                        if (_arg3.TryRead<global::UnityEngine.GUIStyle>(out var _p3_UnityEngine_GUIStyle))
                        {
                            if (_argCount == 4)
                            {
                                var position = _p0_UnityEngine_Rect;
                                var label = _p1_System_String;
                                var password = _p2_System_String;
                                var style = _p3_UnityEngine_GUIStyle;
                                var _ret0 = global::UnityEditor.EditorGUI.PasswordField(position, label, password, style);
                                var _lret0 = new global::Lua.LuaValue(_ret0);
                                var _retCount = _context.Return(_lret0);
                                return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                            }
                        }
                    }
                    _lastArgPos = 2; _expectedType = typeof(global::UnityEngine.GUIStyle);
                    if (_arg2.TryRead<global::UnityEngine.GUIStyle>(out var _p2_UnityEngine_GUIStyle))
                    {
                        if (_argCount == 3)
                        {
                            var position = _p0_UnityEngine_Rect;
                            var password = _p1_System_String;
                            var style = _p2_UnityEngine_GUIStyle;
                            var _ret0 = global::UnityEditor.EditorGUI.PasswordField(position, password, style);
                            var _lret0 = new global::Lua.LuaValue(_ret0);
                            var _retCount = _context.Return(_lret0);
                            return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                        }
                    }
                }
                _lastArgPos = 1; _expectedType = typeof(global::UnityEngine.GUIContent);
                if (_arg1.TryRead<global::UnityEngine.GUIContent>(out var _p1_UnityEngine_GUIContent))
                {
                    var _arg2 = _lastArg = _argCount > 2 ? _context.GetArgument(2) : global::Lua.LuaValue.Nil;
                    _lastArgPos = 2; _expectedType = typeof(global::System.String);
                    if (_arg2.TryRead<global::System.String>(out var _p2_System_String))
                    {
                        if (_argCount == 3)
                        {
                            var position = _p0_UnityEngine_Rect;
                            var label = _p1_UnityEngine_GUIContent;
                            var password = _p2_System_String;
                            var _ret0 = global::UnityEditor.EditorGUI.PasswordField(position, label, password);
                            var _lret0 = new global::Lua.LuaValue(_ret0);
                            var _retCount = _context.Return(_lret0);
                            return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                        }
                        var _arg3 = _lastArg = _argCount > 3 ? _context.GetArgument(3) : global::Lua.LuaValue.Nil;
                        _lastArgPos = 3; _expectedType = typeof(global::UnityEngine.GUIStyle);
                        if (_arg3.TryRead<global::UnityEngine.GUIStyle>(out var _p3_UnityEngine_GUIStyle))
                        {
                            if (_argCount == 4)
                            {
                                var position = _p0_UnityEngine_Rect;
                                var label = _p1_UnityEngine_GUIContent;
                                var password = _p2_System_String;
                                var style = _p3_UnityEngine_GUIStyle;
                                var _ret0 = global::UnityEditor.EditorGUI.PasswordField(position, label, password, style);
                                var _lret0 = new global::Lua.LuaValue(_ret0);
                                var _retCount = _context.Return(_lret0);
                                return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                            }
                        }
                    }
                }
            }
            throw new global::Lua.LuaRuntimeException(_context.Thread, $"{"PasswordField"}: invalid argument #{_lastArgPos}: {_lastArg} ({_lastArg.Type}), expected: {_expectedType.FullName}", 2);
        });
        private static readonly global::Lua.LuaFunction _LuaEditorGUI_Popup = new global::Lua.LuaFunction("Popup", (_context, _) =>
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
                _lastArgPos = 1; _expectedType = typeof(global::System.Int32);
                if (_arg1.TryRead<global::System.Int32>(out var _p1_System_Int32))
                {
                    var _arg2 = _lastArg = _argCount > 2 ? _context.GetArgument(2) : global::Lua.LuaValue.Nil;
                    _lastArgPos = 2; _expectedType = typeof(global::System.String[]);
                    if (_arg2.TryReadArray<global::System.String>(out var _p2_System_StringArray))
                    {
                        if (_argCount == 3)
                        {
                            var position = _p0_UnityEngine_Rect;
                            var selectedIndex = _p1_System_Int32;
                            var displayedOptions = _p2_System_StringArray;
                            var _ret0 = global::UnityEditor.EditorGUI.Popup(position, selectedIndex, displayedOptions);
                            var _lret0 = new global::Lua.LuaValue(_ret0);
                            var _retCount = _context.Return(_lret0);
                            return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                        }
                        var _arg3 = _lastArg = _argCount > 3 ? _context.GetArgument(3) : global::Lua.LuaValue.Nil;
                        _lastArgPos = 3; _expectedType = typeof(global::UnityEngine.GUIStyle);
                        if (_arg3.TryRead<global::UnityEngine.GUIStyle>(out var _p3_UnityEngine_GUIStyle))
                        {
                            if (_argCount == 4)
                            {
                                var position = _p0_UnityEngine_Rect;
                                var selectedIndex = _p1_System_Int32;
                                var displayedOptions = _p2_System_StringArray;
                                var style = _p3_UnityEngine_GUIStyle;
                                var _ret0 = global::UnityEditor.EditorGUI.Popup(position, selectedIndex, displayedOptions, style);
                                var _lret0 = new global::Lua.LuaValue(_ret0);
                                var _retCount = _context.Return(_lret0);
                                return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                            }
                        }
                    }
                    _lastArgPos = 2; _expectedType = typeof(global::UnityEngine.GUIContent[]);
                    if (_arg2.TryReadArray<global::UnityEngine.GUIContent>(out var _p2_UnityEngine_GUIContentArray))
                    {
                        if (_argCount == 3)
                        {
                            var position = _p0_UnityEngine_Rect;
                            var selectedIndex = _p1_System_Int32;
                            var displayedOptions = _p2_UnityEngine_GUIContentArray;
                            var _ret0 = global::UnityEditor.EditorGUI.Popup(position, selectedIndex, displayedOptions);
                            var _lret0 = new global::Lua.LuaValue(_ret0);
                            var _retCount = _context.Return(_lret0);
                            return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                        }
                        var _arg3 = _lastArg = _argCount > 3 ? _context.GetArgument(3) : global::Lua.LuaValue.Nil;
                        _lastArgPos = 3; _expectedType = typeof(global::UnityEngine.GUIStyle);
                        if (_arg3.TryRead<global::UnityEngine.GUIStyle>(out var _p3_UnityEngine_GUIStyle))
                        {
                            if (_argCount == 4)
                            {
                                var position = _p0_UnityEngine_Rect;
                                var selectedIndex = _p1_System_Int32;
                                var displayedOptions = _p2_UnityEngine_GUIContentArray;
                                var style = _p3_UnityEngine_GUIStyle;
                                var _ret0 = global::UnityEditor.EditorGUI.Popup(position, selectedIndex, displayedOptions, style);
                                var _lret0 = new global::Lua.LuaValue(_ret0);
                                var _retCount = _context.Return(_lret0);
                                return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                            }
                        }
                    }
                }
                _lastArgPos = 1; _expectedType = typeof(global::System.String);
                if (_arg1.TryRead<global::System.String>(out var _p1_System_String))
                {
                    var _arg2 = _lastArg = _argCount > 2 ? _context.GetArgument(2) : global::Lua.LuaValue.Nil;
                    _lastArgPos = 2; _expectedType = typeof(global::System.Int32);
                    if (_arg2.TryRead<global::System.Int32>(out var _p2_System_Int32))
                    {
                        var _arg3 = _lastArg = _argCount > 3 ? _context.GetArgument(3) : global::Lua.LuaValue.Nil;
                        _lastArgPos = 3; _expectedType = typeof(global::System.String[]);
                        if (_arg3.TryReadArray<global::System.String>(out var _p3_System_StringArray))
                        {
                            if (_argCount == 4)
                            {
                                var position = _p0_UnityEngine_Rect;
                                var label = _p1_System_String;
                                var selectedIndex = _p2_System_Int32;
                                var displayedOptions = _p3_System_StringArray;
                                var _ret0 = global::UnityEditor.EditorGUI.Popup(position, label, selectedIndex, displayedOptions);
                                var _lret0 = new global::Lua.LuaValue(_ret0);
                                var _retCount = _context.Return(_lret0);
                                return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                            }
                            var _arg4 = _lastArg = _argCount > 4 ? _context.GetArgument(4) : global::Lua.LuaValue.Nil;
                            _lastArgPos = 4; _expectedType = typeof(global::UnityEngine.GUIStyle);
                            if (_arg4.TryRead<global::UnityEngine.GUIStyle>(out var _p4_UnityEngine_GUIStyle))
                            {
                                if (_argCount == 5)
                                {
                                    var position = _p0_UnityEngine_Rect;
                                    var label = _p1_System_String;
                                    var selectedIndex = _p2_System_Int32;
                                    var displayedOptions = _p3_System_StringArray;
                                    var style = _p4_UnityEngine_GUIStyle;
                                    var _ret0 = global::UnityEditor.EditorGUI.Popup(position, label, selectedIndex, displayedOptions, style);
                                    var _lret0 = new global::Lua.LuaValue(_ret0);
                                    var _retCount = _context.Return(_lret0);
                                    return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                                }
                            }
                        }
                    }
                }
                _lastArgPos = 1; _expectedType = typeof(global::UnityEngine.GUIContent);
                if (_arg1.TryRead<global::UnityEngine.GUIContent>(out var _p1_UnityEngine_GUIContent))
                {
                    var _arg2 = _lastArg = _argCount > 2 ? _context.GetArgument(2) : global::Lua.LuaValue.Nil;
                    _lastArgPos = 2; _expectedType = typeof(global::System.Int32);
                    if (_arg2.TryRead<global::System.Int32>(out var _p2_System_Int32))
                    {
                        var _arg3 = _lastArg = _argCount > 3 ? _context.GetArgument(3) : global::Lua.LuaValue.Nil;
                        _lastArgPos = 3; _expectedType = typeof(global::UnityEngine.GUIContent[]);
                        if (_arg3.TryReadArray<global::UnityEngine.GUIContent>(out var _p3_UnityEngine_GUIContentArray))
                        {
                            if (_argCount == 4)
                            {
                                var position = _p0_UnityEngine_Rect;
                                var label = _p1_UnityEngine_GUIContent;
                                var selectedIndex = _p2_System_Int32;
                                var displayedOptions = _p3_UnityEngine_GUIContentArray;
                                var _ret0 = global::UnityEditor.EditorGUI.Popup(position, label, selectedIndex, displayedOptions);
                                var _lret0 = new global::Lua.LuaValue(_ret0);
                                var _retCount = _context.Return(_lret0);
                                return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                            }
                            var _arg4 = _lastArg = _argCount > 4 ? _context.GetArgument(4) : global::Lua.LuaValue.Nil;
                            _lastArgPos = 4; _expectedType = typeof(global::UnityEngine.GUIStyle);
                            if (_arg4.TryRead<global::UnityEngine.GUIStyle>(out var _p4_UnityEngine_GUIStyle))
                            {
                                if (_argCount == 5)
                                {
                                    var position = _p0_UnityEngine_Rect;
                                    var label = _p1_UnityEngine_GUIContent;
                                    var selectedIndex = _p2_System_Int32;
                                    var displayedOptions = _p3_UnityEngine_GUIContentArray;
                                    var style = _p4_UnityEngine_GUIStyle;
                                    var _ret0 = global::UnityEditor.EditorGUI.Popup(position, label, selectedIndex, displayedOptions, style);
                                    var _lret0 = new global::Lua.LuaValue(_ret0);
                                    var _retCount = _context.Return(_lret0);
                                    return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                                }
                            }
                        }
                    }
                }
            }
            throw new global::Lua.LuaRuntimeException(_context.Thread, $"{"Popup"}: invalid argument #{_lastArgPos}: {_lastArg} ({_lastArg.Type}), expected: {_expectedType.FullName}", 2);
        });
        private static readonly global::Lua.LuaFunction _LuaEditorGUI_PrefixLabel = new global::Lua.LuaFunction("PrefixLabel", (_context, _) =>
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
                _lastArgPos = 1; _expectedType = typeof(global::UnityEngine.GUIContent);
                if (_arg1.TryRead<global::UnityEngine.GUIContent>(out var _p1_UnityEngine_GUIContent))
                {
                    if (_argCount == 2)
                    {
                        var totalPosition = _p0_UnityEngine_Rect;
                        var label = _p1_UnityEngine_GUIContent;
                        var _ret0 = global::UnityEditor.EditorGUI.PrefixLabel(totalPosition, label);
                        var _factory = _context.GetObjectFactory();
                        var _lret0 = _factory.Bind(_ret0);
                        var _retCount = _context.Return(_lret0);
                        return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                    }
                    var _arg2 = _lastArg = _argCount > 2 ? _context.GetArgument(2) : global::Lua.LuaValue.Nil;
                    _lastArgPos = 2; _expectedType = typeof(global::UnityEngine.GUIStyle);
                    if (_arg2.TryRead<global::UnityEngine.GUIStyle>(out var _p2_UnityEngine_GUIStyle))
                    {
                        if (_argCount == 3)
                        {
                            var totalPosition = _p0_UnityEngine_Rect;
                            var label = _p1_UnityEngine_GUIContent;
                            var style = _p2_UnityEngine_GUIStyle;
                            var _ret0 = global::UnityEditor.EditorGUI.PrefixLabel(totalPosition, label, style);
                            var _factory = _context.GetObjectFactory();
                            var _lret0 = _factory.Bind(_ret0);
                            var _retCount = _context.Return(_lret0);
                            return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                        }
                    }
                }
                _lastArgPos = 1; _expectedType = typeof(global::System.Int32);
                if (_arg1.TryRead<global::System.Int32>(out var _p1_System_Int32))
                {
                    var _arg2 = _lastArg = _argCount > 2 ? _context.GetArgument(2) : global::Lua.LuaValue.Nil;
                    _lastArgPos = 2; _expectedType = typeof(global::UnityEngine.GUIContent);
                    if (_arg2.TryRead<global::UnityEngine.GUIContent>(out var _p2_UnityEngine_GUIContent))
                    {
                        if (_argCount == 3)
                        {
                            var totalPosition = _p0_UnityEngine_Rect;
                            var id = _p1_System_Int32;
                            var label = _p2_UnityEngine_GUIContent;
                            var _ret0 = global::UnityEditor.EditorGUI.PrefixLabel(totalPosition, id, label);
                            var _factory = _context.GetObjectFactory();
                            var _lret0 = _factory.Bind(_ret0);
                            var _retCount = _context.Return(_lret0);
                            return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                        }
                        var _arg3 = _lastArg = _argCount > 3 ? _context.GetArgument(3) : global::Lua.LuaValue.Nil;
                        _lastArgPos = 3; _expectedType = typeof(global::UnityEngine.GUIStyle);
                        if (_arg3.TryRead<global::UnityEngine.GUIStyle>(out var _p3_UnityEngine_GUIStyle))
                        {
                            if (_argCount == 4)
                            {
                                var totalPosition = _p0_UnityEngine_Rect;
                                var id = _p1_System_Int32;
                                var label = _p2_UnityEngine_GUIContent;
                                var style = _p3_UnityEngine_GUIStyle;
                                var _ret0 = global::UnityEditor.EditorGUI.PrefixLabel(totalPosition, id, label, style);
                                var _factory = _context.GetObjectFactory();
                                var _lret0 = _factory.Bind(_ret0);
                                var _retCount = _context.Return(_lret0);
                                return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                            }
                        }
                    }
                }
            }
            throw new global::Lua.LuaRuntimeException(_context.Thread, $"{"PrefixLabel"}: invalid argument #{_lastArgPos}: {_lastArg} ({_lastArg.Type}), expected: {_expectedType.FullName}", 2);
        });
        private static readonly global::Lua.LuaFunction _LuaEditorGUI_ProgressBar = new global::Lua.LuaFunction("ProgressBar", (_context, _) =>
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
                _lastArgPos = 1; _expectedType = typeof(global::System.Single);
                if (_arg1.TryRead<global::System.Single>(out var _p1_System_Single))
                {
                    var _arg2 = _lastArg = _argCount > 2 ? _context.GetArgument(2) : global::Lua.LuaValue.Nil;
                    _lastArgPos = 2; _expectedType = typeof(global::System.String);
                    if (_arg2.TryRead<global::System.String>(out var _p2_System_String))
                    {
                        if (_argCount == 3)
                        {
                            var position = _p0_UnityEngine_Rect;
                            var value = _p1_System_Single;
                            var text = _p2_System_String;
                            global::UnityEditor.EditorGUI.ProgressBar(position, value, text);
                            var _retCount = _context.Return();
                            return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                        }
                    }
                }
            }
            throw new global::Lua.LuaRuntimeException(_context.Thread, $"{"ProgressBar"}: invalid argument #{_lastArgPos}: {_lastArg} ({_lastArg.Type}), expected: {_expectedType.FullName}", 2);
        });
        private static readonly global::Lua.LuaFunction _LuaEditorGUI_PropertyField = new global::Lua.LuaFunction("PropertyField", (_context, _) =>
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
                    if (_argCount == 2)
                    {
                        var position = _p0_UnityEngine_Rect;
                        var property = _p1_UnityEditor_SerializedProperty.Instance;
                        var _ret0 = global::UnityEditor.EditorGUI.PropertyField(position, property);
                        var _lret0 = new global::Lua.LuaValue(_ret0);
                        var _retCount = _context.Return(_lret0);
                        return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                    }
                    var _arg2 = _lastArg = _argCount > 2 ? _context.GetArgument(2) : global::Lua.LuaValue.Nil;
                    _lastArgPos = 2; _expectedType = typeof(global::System.Boolean);
                    if (_arg2.TryRead<global::System.Boolean>(out var _p2_System_Boolean))
                    {
                        if (_argCount == 3)
                        {
                            var position = _p0_UnityEngine_Rect;
                            var property = _p1_UnityEditor_SerializedProperty.Instance;
                            var includeChildren = _p2_System_Boolean;
                            var _ret0 = global::UnityEditor.EditorGUI.PropertyField(position, property, includeChildren);
                            var _lret0 = new global::Lua.LuaValue(_ret0);
                            var _retCount = _context.Return(_lret0);
                            return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                        }
                    }
                    _lastArgPos = 2; _expectedType = typeof(global::UnityEngine.GUIContent);
                    if (_arg2.TryRead<global::UnityEngine.GUIContent>(out var _p2_UnityEngine_GUIContent))
                    {
                        if (_argCount == 3)
                        {
                            var position = _p0_UnityEngine_Rect;
                            var property = _p1_UnityEditor_SerializedProperty.Instance;
                            var label = _p2_UnityEngine_GUIContent;
                            var _ret0 = global::UnityEditor.EditorGUI.PropertyField(position, property, label);
                            var _lret0 = new global::Lua.LuaValue(_ret0);
                            var _retCount = _context.Return(_lret0);
                            return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                        }
                        var _arg3 = _lastArg = _argCount > 3 ? _context.GetArgument(3) : global::Lua.LuaValue.Nil;
                        _lastArgPos = 3; _expectedType = typeof(global::System.Boolean);
                        if (_arg3.TryRead<global::System.Boolean>(out var _p3_System_Boolean))
                        {
                            if (_argCount == 4)
                            {
                                var position = _p0_UnityEngine_Rect;
                                var property = _p1_UnityEditor_SerializedProperty.Instance;
                                var label = _p2_UnityEngine_GUIContent;
                                var includeChildren = _p3_System_Boolean;
                                var _ret0 = global::UnityEditor.EditorGUI.PropertyField(position, property, label, includeChildren);
                                var _lret0 = new global::Lua.LuaValue(_ret0);
                                var _retCount = _context.Return(_lret0);
                                return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                            }
                        }
                    }
                }
            }
            throw new global::Lua.LuaRuntimeException(_context.Thread, $"{"PropertyField"}: invalid argument #{_lastArgPos}: {_lastArg} ({_lastArg.Type}), expected: {_expectedType.FullName}", 2);
        });
        private static readonly global::Lua.LuaFunction _LuaEditorGUI_RectField = new global::Lua.LuaFunction("RectField", (_context, _) =>
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
                _lastArgPos = 1; _expectedType = typeof(global::UnityEngine.Rect);
                if (_arg1.TryRead<global::UnityEngine.Rect>(out var _p1_UnityEngine_Rect))
                {
                    if (_argCount == 2)
                    {
                        var position = _p0_UnityEngine_Rect;
                        var value = _p1_UnityEngine_Rect;
                        var _ret0 = global::UnityEditor.EditorGUI.RectField(position, value);
                        var _factory = _context.GetObjectFactory();
                        var _lret0 = _factory.Bind(_ret0);
                        var _retCount = _context.Return(_lret0);
                        return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                    }
                }
                _lastArgPos = 1; _expectedType = typeof(global::System.String);
                if (_arg1.TryRead<global::System.String>(out var _p1_System_String))
                {
                    var _arg2 = _lastArg = _argCount > 2 ? _context.GetArgument(2) : global::Lua.LuaValue.Nil;
                    _lastArgPos = 2; _expectedType = typeof(global::UnityEngine.Rect);
                    if (_arg2.TryRead<global::UnityEngine.Rect>(out var _p2_UnityEngine_Rect))
                    {
                        if (_argCount == 3)
                        {
                            var position = _p0_UnityEngine_Rect;
                            var label = _p1_System_String;
                            var value = _p2_UnityEngine_Rect;
                            var _ret0 = global::UnityEditor.EditorGUI.RectField(position, label, value);
                            var _factory = _context.GetObjectFactory();
                            var _lret0 = _factory.Bind(_ret0);
                            var _retCount = _context.Return(_lret0);
                            return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                        }
                    }
                }
                _lastArgPos = 1; _expectedType = typeof(global::UnityEngine.GUIContent);
                if (_arg1.TryRead<global::UnityEngine.GUIContent>(out var _p1_UnityEngine_GUIContent))
                {
                    var _arg2 = _lastArg = _argCount > 2 ? _context.GetArgument(2) : global::Lua.LuaValue.Nil;
                    _lastArgPos = 2; _expectedType = typeof(global::UnityEngine.Rect);
                    if (_arg2.TryRead<global::UnityEngine.Rect>(out var _p2_UnityEngine_Rect))
                    {
                        if (_argCount == 3)
                        {
                            var position = _p0_UnityEngine_Rect;
                            var label = _p1_UnityEngine_GUIContent;
                            var value = _p2_UnityEngine_Rect;
                            var _ret0 = global::UnityEditor.EditorGUI.RectField(position, label, value);
                            var _factory = _context.GetObjectFactory();
                            var _lret0 = _factory.Bind(_ret0);
                            var _retCount = _context.Return(_lret0);
                            return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                        }
                    }
                }
            }
            throw new global::Lua.LuaRuntimeException(_context.Thread, $"{"RectField"}: invalid argument #{_lastArgPos}: {_lastArg} ({_lastArg.Type}), expected: {_expectedType.FullName}", 2);
        });
        private static readonly global::Lua.LuaFunction _LuaEditorGUI_RectIntField = new global::Lua.LuaFunction("RectIntField", (_context, _) =>
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
                _lastArgPos = 1; _expectedType = typeof(global::UnityEngine.RectInt);
                if (_arg1.TryRead<global::UnityEngine.RectInt>(out var _p1_UnityEngine_RectInt))
                {
                    if (_argCount == 2)
                    {
                        var position = _p0_UnityEngine_Rect;
                        var value = _p1_UnityEngine_RectInt;
                        var _ret0 = global::UnityEditor.EditorGUI.RectIntField(position, value);
                        var _factory = _context.GetObjectFactory();
                        var _lret0 = _factory.Bind(_ret0);
                        var _retCount = _context.Return(_lret0);
                        return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                    }
                }
                _lastArgPos = 1; _expectedType = typeof(global::System.String);
                if (_arg1.TryRead<global::System.String>(out var _p1_System_String))
                {
                    var _arg2 = _lastArg = _argCount > 2 ? _context.GetArgument(2) : global::Lua.LuaValue.Nil;
                    _lastArgPos = 2; _expectedType = typeof(global::UnityEngine.RectInt);
                    if (_arg2.TryRead<global::UnityEngine.RectInt>(out var _p2_UnityEngine_RectInt))
                    {
                        if (_argCount == 3)
                        {
                            var position = _p0_UnityEngine_Rect;
                            var label = _p1_System_String;
                            var value = _p2_UnityEngine_RectInt;
                            var _ret0 = global::UnityEditor.EditorGUI.RectIntField(position, label, value);
                            var _factory = _context.GetObjectFactory();
                            var _lret0 = _factory.Bind(_ret0);
                            var _retCount = _context.Return(_lret0);
                            return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                        }
                    }
                }
                _lastArgPos = 1; _expectedType = typeof(global::UnityEngine.GUIContent);
                if (_arg1.TryRead<global::UnityEngine.GUIContent>(out var _p1_UnityEngine_GUIContent))
                {
                    var _arg2 = _lastArg = _argCount > 2 ? _context.GetArgument(2) : global::Lua.LuaValue.Nil;
                    _lastArgPos = 2; _expectedType = typeof(global::UnityEngine.RectInt);
                    if (_arg2.TryRead<global::UnityEngine.RectInt>(out var _p2_UnityEngine_RectInt))
                    {
                        if (_argCount == 3)
                        {
                            var position = _p0_UnityEngine_Rect;
                            var label = _p1_UnityEngine_GUIContent;
                            var value = _p2_UnityEngine_RectInt;
                            var _ret0 = global::UnityEditor.EditorGUI.RectIntField(position, label, value);
                            var _factory = _context.GetObjectFactory();
                            var _lret0 = _factory.Bind(_ret0);
                            var _retCount = _context.Return(_lret0);
                            return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                        }
                    }
                }
            }
            throw new global::Lua.LuaRuntimeException(_context.Thread, $"{"RectIntField"}: invalid argument #{_lastArgPos}: {_lastArg} ({_lastArg.Type}), expected: {_expectedType.FullName}", 2);
        });
        private static readonly global::Lua.LuaFunction _LuaEditorGUI_RenderingLayerMaskField = new global::Lua.LuaFunction("RenderingLayerMaskField", (_context, _) =>
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
                _lastArgPos = 1; _expectedType = typeof(global::System.String);
                if (_arg1.TryRead<global::System.String>(out var _p1_System_String))
                {
                    var _arg2 = _lastArg = _argCount > 2 ? _context.GetArgument(2) : global::Lua.LuaValue.Nil;
                    _lastArgPos = 2; _expectedType = typeof(global::UnityEngine.RenderingLayerMask);
                    if (_arg2.TryRead<global::UnityEngine.RenderingLayerMask>(out var _p2_UnityEngine_RenderingLayerMask))
                    {
                        if (_argCount == 3)
                        {
                            var position = _p0_UnityEngine_Rect;
                            var label = _p1_System_String;
                            var layers = _p2_UnityEngine_RenderingLayerMask;
                            var _ret0 = global::UnityEditor.EditorGUI.RenderingLayerMaskField(position, label, layers);
                            var _factory = _context.GetObjectFactory();
                            var _lret0 = _factory.Bind(_ret0);
                            var _retCount = _context.Return(_lret0);
                            return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                        }
                        var _arg3 = _lastArg = _argCount > 3 ? _context.GetArgument(3) : global::Lua.LuaValue.Nil;
                        _lastArgPos = 3; _expectedType = typeof(global::UnityEngine.GUIStyle);
                        if (_arg3.TryRead<global::UnityEngine.GUIStyle>(out var _p3_UnityEngine_GUIStyle))
                        {
                            if (_argCount == 4)
                            {
                                var position = _p0_UnityEngine_Rect;
                                var label = _p1_System_String;
                                var layers = _p2_UnityEngine_RenderingLayerMask;
                                var style = _p3_UnityEngine_GUIStyle;
                                var _ret0 = global::UnityEditor.EditorGUI.RenderingLayerMaskField(position, label, layers, style);
                                var _factory = _context.GetObjectFactory();
                                var _lret0 = _factory.Bind(_ret0);
                                var _retCount = _context.Return(_lret0);
                                return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                            }
                        }
                    }
                    _lastArgPos = 2; _expectedType = typeof(global::Luny.UnityEditor.LuaSerializedProperty);
                    if (_arg2.TryRead<global::Luny.UnityEditor.LuaSerializedProperty>(out var _p2_UnityEditor_SerializedProperty))
                    {
                        if (_argCount == 3)
                        {
                            var position = _p0_UnityEngine_Rect;
                            var label = _p1_System_String;
                            var property = _p2_UnityEditor_SerializedProperty.Instance;
                            global::UnityEditor.EditorGUI.RenderingLayerMaskField(position, label, property);
                            var _retCount = _context.Return();
                            return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                        }
                    }
                }
                _lastArgPos = 1; _expectedType = typeof(global::UnityEngine.GUIContent);
                if (_arg1.TryRead<global::UnityEngine.GUIContent>(out var _p1_UnityEngine_GUIContent))
                {
                    var _arg2 = _lastArg = _argCount > 2 ? _context.GetArgument(2) : global::Lua.LuaValue.Nil;
                    _lastArgPos = 2; _expectedType = typeof(global::UnityEngine.RenderingLayerMask);
                    if (_arg2.TryRead<global::UnityEngine.RenderingLayerMask>(out var _p2_UnityEngine_RenderingLayerMask))
                    {
                        if (_argCount == 3)
                        {
                            var position = _p0_UnityEngine_Rect;
                            var label = _p1_UnityEngine_GUIContent;
                            var layers = _p2_UnityEngine_RenderingLayerMask;
                            var _ret0 = global::UnityEditor.EditorGUI.RenderingLayerMaskField(position, label, layers);
                            var _factory = _context.GetObjectFactory();
                            var _lret0 = _factory.Bind(_ret0);
                            var _retCount = _context.Return(_lret0);
                            return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                        }
                        var _arg3 = _lastArg = _argCount > 3 ? _context.GetArgument(3) : global::Lua.LuaValue.Nil;
                        _lastArgPos = 3; _expectedType = typeof(global::UnityEngine.GUIStyle);
                        if (_arg3.TryRead<global::UnityEngine.GUIStyle>(out var _p3_UnityEngine_GUIStyle))
                        {
                            if (_argCount == 4)
                            {
                                var position = _p0_UnityEngine_Rect;
                                var label = _p1_UnityEngine_GUIContent;
                                var layers = _p2_UnityEngine_RenderingLayerMask;
                                var style = _p3_UnityEngine_GUIStyle;
                                var _ret0 = global::UnityEditor.EditorGUI.RenderingLayerMaskField(position, label, layers, style);
                                var _factory = _context.GetObjectFactory();
                                var _lret0 = _factory.Bind(_ret0);
                                var _retCount = _context.Return(_lret0);
                                return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                            }
                        }
                    }
                    _lastArgPos = 2; _expectedType = typeof(global::Luny.UnityEditor.LuaSerializedProperty);
                    if (_arg2.TryRead<global::Luny.UnityEditor.LuaSerializedProperty>(out var _p2_UnityEditor_SerializedProperty))
                    {
                        if (_argCount == 3)
                        {
                            var position = _p0_UnityEngine_Rect;
                            var label = _p1_UnityEngine_GUIContent;
                            var property = _p2_UnityEditor_SerializedProperty.Instance;
                            global::UnityEditor.EditorGUI.RenderingLayerMaskField(position, label, property);
                            var _retCount = _context.Return();
                            return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                        }
                    }
                }
            }
            throw new global::Lua.LuaRuntimeException(_context.Thread, $"{"RenderingLayerMaskField"}: invalid argument #{_lastArgPos}: {_lastArg} ({_lastArg.Type}), expected: {_expectedType.FullName}", 2);
        });
        private static readonly global::Lua.LuaFunction _LuaEditorGUI_SelectableLabel = new global::Lua.LuaFunction("SelectableLabel", (_context, _) =>
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
                _lastArgPos = 1; _expectedType = typeof(global::System.String);
                if (_arg1.TryRead<global::System.String>(out var _p1_System_String))
                {
                    if (_argCount == 2)
                    {
                        var position = _p0_UnityEngine_Rect;
                        var text = _p1_System_String;
                        global::UnityEditor.EditorGUI.SelectableLabel(position, text);
                        var _retCount = _context.Return();
                        return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                    }
                    var _arg2 = _lastArg = _argCount > 2 ? _context.GetArgument(2) : global::Lua.LuaValue.Nil;
                    _lastArgPos = 2; _expectedType = typeof(global::UnityEngine.GUIStyle);
                    if (_arg2.TryRead<global::UnityEngine.GUIStyle>(out var _p2_UnityEngine_GUIStyle))
                    {
                        if (_argCount == 3)
                        {
                            var position = _p0_UnityEngine_Rect;
                            var text = _p1_System_String;
                            var style = _p2_UnityEngine_GUIStyle;
                            global::UnityEditor.EditorGUI.SelectableLabel(position, text, style);
                            var _retCount = _context.Return();
                            return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                        }
                    }
                }
            }
            throw new global::Lua.LuaRuntimeException(_context.Thread, $"{"SelectableLabel"}: invalid argument #{_lastArgPos}: {_lastArg} ({_lastArg.Type}), expected: {_expectedType.FullName}", 2);
        });
        private static readonly global::Lua.LuaFunction _LuaEditorGUI_Slider = new global::Lua.LuaFunction("Slider", (_context, _) =>
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
                _lastArgPos = 1; _expectedType = typeof(global::System.Single);
                if (_arg1.TryRead<global::System.Single>(out var _p1_System_Single))
                {
                    var _arg2 = _lastArg = _argCount > 2 ? _context.GetArgument(2) : global::Lua.LuaValue.Nil;
                    _lastArgPos = 2; _expectedType = typeof(global::System.Single);
                    if (_arg2.TryRead<global::System.Single>(out var _p2_System_Single))
                    {
                        var _arg3 = _lastArg = _argCount > 3 ? _context.GetArgument(3) : global::Lua.LuaValue.Nil;
                        _lastArgPos = 3; _expectedType = typeof(global::System.Single);
                        if (_arg3.TryRead<global::System.Single>(out var _p3_System_Single))
                        {
                            if (_argCount == 4)
                            {
                                var position = _p0_UnityEngine_Rect;
                                var value = _p1_System_Single;
                                var leftValue = _p2_System_Single;
                                var rightValue = _p3_System_Single;
                                var _ret0 = global::UnityEditor.EditorGUI.Slider(position, value, leftValue, rightValue);
                                var _lret0 = new global::Lua.LuaValue(_ret0);
                                var _retCount = _context.Return(_lret0);
                                return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                            }
                        }
                    }
                }
                _lastArgPos = 1; _expectedType = typeof(global::Luny.UnityEditor.LuaSerializedProperty);
                if (_arg1.TryRead<global::Luny.UnityEditor.LuaSerializedProperty>(out var _p1_UnityEditor_SerializedProperty))
                {
                    var _arg2 = _lastArg = _argCount > 2 ? _context.GetArgument(2) : global::Lua.LuaValue.Nil;
                    _lastArgPos = 2; _expectedType = typeof(global::System.Single);
                    if (_arg2.TryRead<global::System.Single>(out var _p2_System_Single))
                    {
                        var _arg3 = _lastArg = _argCount > 3 ? _context.GetArgument(3) : global::Lua.LuaValue.Nil;
                        _lastArgPos = 3; _expectedType = typeof(global::System.Single);
                        if (_arg3.TryRead<global::System.Single>(out var _p3_System_Single))
                        {
                            if (_argCount == 4)
                            {
                                var position = _p0_UnityEngine_Rect;
                                var property = _p1_UnityEditor_SerializedProperty.Instance;
                                var leftValue = _p2_System_Single;
                                var rightValue = _p3_System_Single;
                                global::UnityEditor.EditorGUI.Slider(position, property, leftValue, rightValue);
                                var _retCount = _context.Return();
                                return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                            }
                            var _arg4 = _lastArg = _argCount > 4 ? _context.GetArgument(4) : global::Lua.LuaValue.Nil;
                            _lastArgPos = 4; _expectedType = typeof(global::System.String);
                            if (_arg4.TryRead<global::System.String>(out var _p4_System_String))
                            {
                                if (_argCount == 5)
                                {
                                    var position = _p0_UnityEngine_Rect;
                                    var property = _p1_UnityEditor_SerializedProperty.Instance;
                                    var leftValue = _p2_System_Single;
                                    var rightValue = _p3_System_Single;
                                    var label = _p4_System_String;
                                    global::UnityEditor.EditorGUI.Slider(position, property, leftValue, rightValue, label);
                                    var _retCount = _context.Return();
                                    return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                                }
                            }
                            _lastArgPos = 4; _expectedType = typeof(global::UnityEngine.GUIContent);
                            if (_arg4.TryRead<global::UnityEngine.GUIContent>(out var _p4_UnityEngine_GUIContent))
                            {
                                if (_argCount == 5)
                                {
                                    var position = _p0_UnityEngine_Rect;
                                    var property = _p1_UnityEditor_SerializedProperty.Instance;
                                    var leftValue = _p2_System_Single;
                                    var rightValue = _p3_System_Single;
                                    var label = _p4_UnityEngine_GUIContent;
                                    global::UnityEditor.EditorGUI.Slider(position, property, leftValue, rightValue, label);
                                    var _retCount = _context.Return();
                                    return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                                }
                            }
                        }
                    }
                }
                _lastArgPos = 1; _expectedType = typeof(global::System.String);
                if (_arg1.TryRead<global::System.String>(out var _p1_System_String))
                {
                    var _arg2 = _lastArg = _argCount > 2 ? _context.GetArgument(2) : global::Lua.LuaValue.Nil;
                    _lastArgPos = 2; _expectedType = typeof(global::System.Single);
                    if (_arg2.TryRead<global::System.Single>(out var _p2_System_Single))
                    {
                        var _arg3 = _lastArg = _argCount > 3 ? _context.GetArgument(3) : global::Lua.LuaValue.Nil;
                        _lastArgPos = 3; _expectedType = typeof(global::System.Single);
                        if (_arg3.TryRead<global::System.Single>(out var _p3_System_Single))
                        {
                            var _arg4 = _lastArg = _argCount > 4 ? _context.GetArgument(4) : global::Lua.LuaValue.Nil;
                            _lastArgPos = 4; _expectedType = typeof(global::System.Single);
                            if (_arg4.TryRead<global::System.Single>(out var _p4_System_Single))
                            {
                                if (_argCount == 5)
                                {
                                    var position = _p0_UnityEngine_Rect;
                                    var label = _p1_System_String;
                                    var value = _p2_System_Single;
                                    var leftValue = _p3_System_Single;
                                    var rightValue = _p4_System_Single;
                                    var _ret0 = global::UnityEditor.EditorGUI.Slider(position, label, value, leftValue, rightValue);
                                    var _lret0 = new global::Lua.LuaValue(_ret0);
                                    var _retCount = _context.Return(_lret0);
                                    return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                                }
                            }
                        }
                    }
                }
                _lastArgPos = 1; _expectedType = typeof(global::UnityEngine.GUIContent);
                if (_arg1.TryRead<global::UnityEngine.GUIContent>(out var _p1_UnityEngine_GUIContent))
                {
                    var _arg2 = _lastArg = _argCount > 2 ? _context.GetArgument(2) : global::Lua.LuaValue.Nil;
                    _lastArgPos = 2; _expectedType = typeof(global::System.Single);
                    if (_arg2.TryRead<global::System.Single>(out var _p2_System_Single))
                    {
                        var _arg3 = _lastArg = _argCount > 3 ? _context.GetArgument(3) : global::Lua.LuaValue.Nil;
                        _lastArgPos = 3; _expectedType = typeof(global::System.Single);
                        if (_arg3.TryRead<global::System.Single>(out var _p3_System_Single))
                        {
                            var _arg4 = _lastArg = _argCount > 4 ? _context.GetArgument(4) : global::Lua.LuaValue.Nil;
                            _lastArgPos = 4; _expectedType = typeof(global::System.Single);
                            if (_arg4.TryRead<global::System.Single>(out var _p4_System_Single))
                            {
                                if (_argCount == 5)
                                {
                                    var position = _p0_UnityEngine_Rect;
                                    var label = _p1_UnityEngine_GUIContent;
                                    var value = _p2_System_Single;
                                    var leftValue = _p3_System_Single;
                                    var rightValue = _p4_System_Single;
                                    var _ret0 = global::UnityEditor.EditorGUI.Slider(position, label, value, leftValue, rightValue);
                                    var _lret0 = new global::Lua.LuaValue(_ret0);
                                    var _retCount = _context.Return(_lret0);
                                    return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                                }
                            }
                        }
                    }
                }
            }
            throw new global::Lua.LuaRuntimeException(_context.Thread, $"{"Slider"}: invalid argument #{_lastArgPos}: {_lastArg} ({_lastArg.Type}), expected: {_expectedType.FullName}", 2);
        });
        private static readonly global::Lua.LuaFunction _LuaEditorGUI_TagField = new global::Lua.LuaFunction("TagField", (_context, _) =>
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
                _lastArgPos = 1; _expectedType = typeof(global::System.String);
                if (_arg1.TryRead<global::System.String>(out var _p1_System_String))
                {
                    if (_argCount == 2)
                    {
                        var position = _p0_UnityEngine_Rect;
                        var tag = _p1_System_String;
                        var _ret0 = global::UnityEditor.EditorGUI.TagField(position, tag);
                        var _lret0 = new global::Lua.LuaValue(_ret0);
                        var _retCount = _context.Return(_lret0);
                        return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                    }
                    var _arg2 = _lastArg = _argCount > 2 ? _context.GetArgument(2) : global::Lua.LuaValue.Nil;
                    _lastArgPos = 2; _expectedType = typeof(global::System.String);
                    if (_arg2.TryRead<global::System.String>(out var _p2_System_String))
                    {
                        if (_argCount == 3)
                        {
                            var position = _p0_UnityEngine_Rect;
                            var label = _p1_System_String;
                            var tag = _p2_System_String;
                            var _ret0 = global::UnityEditor.EditorGUI.TagField(position, label, tag);
                            var _lret0 = new global::Lua.LuaValue(_ret0);
                            var _retCount = _context.Return(_lret0);
                            return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                        }
                        var _arg3 = _lastArg = _argCount > 3 ? _context.GetArgument(3) : global::Lua.LuaValue.Nil;
                        _lastArgPos = 3; _expectedType = typeof(global::UnityEngine.GUIStyle);
                        if (_arg3.TryRead<global::UnityEngine.GUIStyle>(out var _p3_UnityEngine_GUIStyle))
                        {
                            if (_argCount == 4)
                            {
                                var position = _p0_UnityEngine_Rect;
                                var label = _p1_System_String;
                                var tag = _p2_System_String;
                                var style = _p3_UnityEngine_GUIStyle;
                                var _ret0 = global::UnityEditor.EditorGUI.TagField(position, label, tag, style);
                                var _lret0 = new global::Lua.LuaValue(_ret0);
                                var _retCount = _context.Return(_lret0);
                                return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                            }
                        }
                    }
                    _lastArgPos = 2; _expectedType = typeof(global::UnityEngine.GUIStyle);
                    if (_arg2.TryRead<global::UnityEngine.GUIStyle>(out var _p2_UnityEngine_GUIStyle))
                    {
                        if (_argCount == 3)
                        {
                            var position = _p0_UnityEngine_Rect;
                            var tag = _p1_System_String;
                            var style = _p2_UnityEngine_GUIStyle;
                            var _ret0 = global::UnityEditor.EditorGUI.TagField(position, tag, style);
                            var _lret0 = new global::Lua.LuaValue(_ret0);
                            var _retCount = _context.Return(_lret0);
                            return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                        }
                    }
                }
                _lastArgPos = 1; _expectedType = typeof(global::UnityEngine.GUIContent);
                if (_arg1.TryRead<global::UnityEngine.GUIContent>(out var _p1_UnityEngine_GUIContent))
                {
                    var _arg2 = _lastArg = _argCount > 2 ? _context.GetArgument(2) : global::Lua.LuaValue.Nil;
                    _lastArgPos = 2; _expectedType = typeof(global::System.String);
                    if (_arg2.TryRead<global::System.String>(out var _p2_System_String))
                    {
                        if (_argCount == 3)
                        {
                            var position = _p0_UnityEngine_Rect;
                            var label = _p1_UnityEngine_GUIContent;
                            var tag = _p2_System_String;
                            var _ret0 = global::UnityEditor.EditorGUI.TagField(position, label, tag);
                            var _lret0 = new global::Lua.LuaValue(_ret0);
                            var _retCount = _context.Return(_lret0);
                            return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                        }
                        var _arg3 = _lastArg = _argCount > 3 ? _context.GetArgument(3) : global::Lua.LuaValue.Nil;
                        _lastArgPos = 3; _expectedType = typeof(global::UnityEngine.GUIStyle);
                        if (_arg3.TryRead<global::UnityEngine.GUIStyle>(out var _p3_UnityEngine_GUIStyle))
                        {
                            if (_argCount == 4)
                            {
                                var position = _p0_UnityEngine_Rect;
                                var label = _p1_UnityEngine_GUIContent;
                                var tag = _p2_System_String;
                                var style = _p3_UnityEngine_GUIStyle;
                                var _ret0 = global::UnityEditor.EditorGUI.TagField(position, label, tag, style);
                                var _lret0 = new global::Lua.LuaValue(_ret0);
                                var _retCount = _context.Return(_lret0);
                                return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                            }
                        }
                    }
                }
            }
            throw new global::Lua.LuaRuntimeException(_context.Thread, $"{"TagField"}: invalid argument #{_lastArgPos}: {_lastArg} ({_lastArg.Type}), expected: {_expectedType.FullName}", 2);
        });
        private static readonly global::Lua.LuaFunction _LuaEditorGUI_TextArea = new global::Lua.LuaFunction("TextArea", (_context, _) =>
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
                _lastArgPos = 1; _expectedType = typeof(global::System.String);
                if (_arg1.TryRead<global::System.String>(out var _p1_System_String))
                {
                    if (_argCount == 2)
                    {
                        var position = _p0_UnityEngine_Rect;
                        var text = _p1_System_String;
                        var _ret0 = global::UnityEditor.EditorGUI.TextArea(position, text);
                        var _lret0 = new global::Lua.LuaValue(_ret0);
                        var _retCount = _context.Return(_lret0);
                        return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                    }
                    var _arg2 = _lastArg = _argCount > 2 ? _context.GetArgument(2) : global::Lua.LuaValue.Nil;
                    _lastArgPos = 2; _expectedType = typeof(global::UnityEngine.GUIStyle);
                    if (_arg2.TryRead<global::UnityEngine.GUIStyle>(out var _p2_UnityEngine_GUIStyle))
                    {
                        if (_argCount == 3)
                        {
                            var position = _p0_UnityEngine_Rect;
                            var text = _p1_System_String;
                            var style = _p2_UnityEngine_GUIStyle;
                            var _ret0 = global::UnityEditor.EditorGUI.TextArea(position, text, style);
                            var _lret0 = new global::Lua.LuaValue(_ret0);
                            var _retCount = _context.Return(_lret0);
                            return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                        }
                    }
                }
            }
            throw new global::Lua.LuaRuntimeException(_context.Thread, $"{"TextArea"}: invalid argument #{_lastArgPos}: {_lastArg} ({_lastArg.Type}), expected: {_expectedType.FullName}", 2);
        });
        private static readonly global::Lua.LuaFunction _LuaEditorGUI_TextField = new global::Lua.LuaFunction("TextField", (_context, _) =>
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
                _lastArgPos = 1; _expectedType = typeof(global::System.String);
                if (_arg1.TryRead<global::System.String>(out var _p1_System_String))
                {
                    if (_argCount == 2)
                    {
                        var position = _p0_UnityEngine_Rect;
                        var text = _p1_System_String;
                        var _ret0 = global::UnityEditor.EditorGUI.TextField(position, text);
                        var _lret0 = new global::Lua.LuaValue(_ret0);
                        var _retCount = _context.Return(_lret0);
                        return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                    }
                    var _arg2 = _lastArg = _argCount > 2 ? _context.GetArgument(2) : global::Lua.LuaValue.Nil;
                    _lastArgPos = 2; _expectedType = typeof(global::System.String);
                    if (_arg2.TryRead<global::System.String>(out var _p2_System_String))
                    {
                        if (_argCount == 3)
                        {
                            var position = _p0_UnityEngine_Rect;
                            var label = _p1_System_String;
                            var text = _p2_System_String;
                            var _ret0 = global::UnityEditor.EditorGUI.TextField(position, label, text);
                            var _lret0 = new global::Lua.LuaValue(_ret0);
                            var _retCount = _context.Return(_lret0);
                            return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                        }
                        var _arg3 = _lastArg = _argCount > 3 ? _context.GetArgument(3) : global::Lua.LuaValue.Nil;
                        _lastArgPos = 3; _expectedType = typeof(global::UnityEngine.GUIStyle);
                        if (_arg3.TryRead<global::UnityEngine.GUIStyle>(out var _p3_UnityEngine_GUIStyle))
                        {
                            if (_argCount == 4)
                            {
                                var position = _p0_UnityEngine_Rect;
                                var label = _p1_System_String;
                                var text = _p2_System_String;
                                var style = _p3_UnityEngine_GUIStyle;
                                var _ret0 = global::UnityEditor.EditorGUI.TextField(position, label, text, style);
                                var _lret0 = new global::Lua.LuaValue(_ret0);
                                var _retCount = _context.Return(_lret0);
                                return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                            }
                        }
                    }
                    _lastArgPos = 2; _expectedType = typeof(global::UnityEngine.GUIStyle);
                    if (_arg2.TryRead<global::UnityEngine.GUIStyle>(out var _p2_UnityEngine_GUIStyle))
                    {
                        if (_argCount == 3)
                        {
                            var position = _p0_UnityEngine_Rect;
                            var text = _p1_System_String;
                            var style = _p2_UnityEngine_GUIStyle;
                            var _ret0 = global::UnityEditor.EditorGUI.TextField(position, text, style);
                            var _lret0 = new global::Lua.LuaValue(_ret0);
                            var _retCount = _context.Return(_lret0);
                            return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                        }
                    }
                }
                _lastArgPos = 1; _expectedType = typeof(global::UnityEngine.GUIContent);
                if (_arg1.TryRead<global::UnityEngine.GUIContent>(out var _p1_UnityEngine_GUIContent))
                {
                    var _arg2 = _lastArg = _argCount > 2 ? _context.GetArgument(2) : global::Lua.LuaValue.Nil;
                    _lastArgPos = 2; _expectedType = typeof(global::System.String);
                    if (_arg2.TryRead<global::System.String>(out var _p2_System_String))
                    {
                        if (_argCount == 3)
                        {
                            var position = _p0_UnityEngine_Rect;
                            var label = _p1_UnityEngine_GUIContent;
                            var text = _p2_System_String;
                            var _ret0 = global::UnityEditor.EditorGUI.TextField(position, label, text);
                            var _lret0 = new global::Lua.LuaValue(_ret0);
                            var _retCount = _context.Return(_lret0);
                            return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                        }
                        var _arg3 = _lastArg = _argCount > 3 ? _context.GetArgument(3) : global::Lua.LuaValue.Nil;
                        _lastArgPos = 3; _expectedType = typeof(global::UnityEngine.GUIStyle);
                        if (_arg3.TryRead<global::UnityEngine.GUIStyle>(out var _p3_UnityEngine_GUIStyle))
                        {
                            if (_argCount == 4)
                            {
                                var position = _p0_UnityEngine_Rect;
                                var label = _p1_UnityEngine_GUIContent;
                                var text = _p2_System_String;
                                var style = _p3_UnityEngine_GUIStyle;
                                var _ret0 = global::UnityEditor.EditorGUI.TextField(position, label, text, style);
                                var _lret0 = new global::Lua.LuaValue(_ret0);
                                var _retCount = _context.Return(_lret0);
                                return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                            }
                        }
                    }
                }
            }
            throw new global::Lua.LuaRuntimeException(_context.Thread, $"{"TextField"}: invalid argument #{_lastArgPos}: {_lastArg} ({_lastArg.Type}), expected: {_expectedType.FullName}", 2);
        });
        private static readonly global::Lua.LuaFunction _LuaEditorGUI_Toggle = new global::Lua.LuaFunction("Toggle", (_context, _) =>
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
                _lastArgPos = 1; _expectedType = typeof(global::System.Boolean);
                if (_arg1.TryRead<global::System.Boolean>(out var _p1_System_Boolean))
                {
                    if (_argCount == 2)
                    {
                        var position = _p0_UnityEngine_Rect;
                        var value = _p1_System_Boolean;
                        var _ret0 = global::UnityEditor.EditorGUI.Toggle(position, value);
                        var _lret0 = new global::Lua.LuaValue(_ret0);
                        var _retCount = _context.Return(_lret0);
                        return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                    }
                    var _arg2 = _lastArg = _argCount > 2 ? _context.GetArgument(2) : global::Lua.LuaValue.Nil;
                    _lastArgPos = 2; _expectedType = typeof(global::UnityEngine.GUIStyle);
                    if (_arg2.TryRead<global::UnityEngine.GUIStyle>(out var _p2_UnityEngine_GUIStyle))
                    {
                        if (_argCount == 3)
                        {
                            var position = _p0_UnityEngine_Rect;
                            var value = _p1_System_Boolean;
                            var style = _p2_UnityEngine_GUIStyle;
                            var _ret0 = global::UnityEditor.EditorGUI.Toggle(position, value, style);
                            var _lret0 = new global::Lua.LuaValue(_ret0);
                            var _retCount = _context.Return(_lret0);
                            return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                        }
                    }
                }
                _lastArgPos = 1; _expectedType = typeof(global::System.String);
                if (_arg1.TryRead<global::System.String>(out var _p1_System_String))
                {
                    var _arg2 = _lastArg = _argCount > 2 ? _context.GetArgument(2) : global::Lua.LuaValue.Nil;
                    _lastArgPos = 2; _expectedType = typeof(global::System.Boolean);
                    if (_arg2.TryRead<global::System.Boolean>(out var _p2_System_Boolean))
                    {
                        if (_argCount == 3)
                        {
                            var position = _p0_UnityEngine_Rect;
                            var label = _p1_System_String;
                            var value = _p2_System_Boolean;
                            var _ret0 = global::UnityEditor.EditorGUI.Toggle(position, label, value);
                            var _lret0 = new global::Lua.LuaValue(_ret0);
                            var _retCount = _context.Return(_lret0);
                            return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                        }
                        var _arg3 = _lastArg = _argCount > 3 ? _context.GetArgument(3) : global::Lua.LuaValue.Nil;
                        _lastArgPos = 3; _expectedType = typeof(global::UnityEngine.GUIStyle);
                        if (_arg3.TryRead<global::UnityEngine.GUIStyle>(out var _p3_UnityEngine_GUIStyle))
                        {
                            if (_argCount == 4)
                            {
                                var position = _p0_UnityEngine_Rect;
                                var label = _p1_System_String;
                                var value = _p2_System_Boolean;
                                var style = _p3_UnityEngine_GUIStyle;
                                var _ret0 = global::UnityEditor.EditorGUI.Toggle(position, label, value, style);
                                var _lret0 = new global::Lua.LuaValue(_ret0);
                                var _retCount = _context.Return(_lret0);
                                return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                            }
                        }
                    }
                }
                _lastArgPos = 1; _expectedType = typeof(global::UnityEngine.GUIContent);
                if (_arg1.TryRead<global::UnityEngine.GUIContent>(out var _p1_UnityEngine_GUIContent))
                {
                    var _arg2 = _lastArg = _argCount > 2 ? _context.GetArgument(2) : global::Lua.LuaValue.Nil;
                    _lastArgPos = 2; _expectedType = typeof(global::System.Boolean);
                    if (_arg2.TryRead<global::System.Boolean>(out var _p2_System_Boolean))
                    {
                        if (_argCount == 3)
                        {
                            var position = _p0_UnityEngine_Rect;
                            var label = _p1_UnityEngine_GUIContent;
                            var value = _p2_System_Boolean;
                            var _ret0 = global::UnityEditor.EditorGUI.Toggle(position, label, value);
                            var _lret0 = new global::Lua.LuaValue(_ret0);
                            var _retCount = _context.Return(_lret0);
                            return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                        }
                        var _arg3 = _lastArg = _argCount > 3 ? _context.GetArgument(3) : global::Lua.LuaValue.Nil;
                        _lastArgPos = 3; _expectedType = typeof(global::UnityEngine.GUIStyle);
                        if (_arg3.TryRead<global::UnityEngine.GUIStyle>(out var _p3_UnityEngine_GUIStyle))
                        {
                            if (_argCount == 4)
                            {
                                var position = _p0_UnityEngine_Rect;
                                var label = _p1_UnityEngine_GUIContent;
                                var value = _p2_System_Boolean;
                                var style = _p3_UnityEngine_GUIStyle;
                                var _ret0 = global::UnityEditor.EditorGUI.Toggle(position, label, value, style);
                                var _lret0 = new global::Lua.LuaValue(_ret0);
                                var _retCount = _context.Return(_lret0);
                                return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                            }
                        }
                    }
                }
            }
            throw new global::Lua.LuaRuntimeException(_context.Thread, $"{"Toggle"}: invalid argument #{_lastArgPos}: {_lastArg} ({_lastArg.Type}), expected: {_expectedType.FullName}", 2);
        });
        private static readonly global::Lua.LuaFunction _LuaEditorGUI_ToggleLeft = new global::Lua.LuaFunction("ToggleLeft", (_context, _) =>
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
                _lastArgPos = 1; _expectedType = typeof(global::System.String);
                if (_arg1.TryRead<global::System.String>(out var _p1_System_String))
                {
                    var _arg2 = _lastArg = _argCount > 2 ? _context.GetArgument(2) : global::Lua.LuaValue.Nil;
                    _lastArgPos = 2; _expectedType = typeof(global::System.Boolean);
                    if (_arg2.TryRead<global::System.Boolean>(out var _p2_System_Boolean))
                    {
                        if (_argCount == 3)
                        {
                            var position = _p0_UnityEngine_Rect;
                            var label = _p1_System_String;
                            var value = _p2_System_Boolean;
                            var _ret0 = global::UnityEditor.EditorGUI.ToggleLeft(position, label, value);
                            var _lret0 = new global::Lua.LuaValue(_ret0);
                            var _retCount = _context.Return(_lret0);
                            return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                        }
                        var _arg3 = _lastArg = _argCount > 3 ? _context.GetArgument(3) : global::Lua.LuaValue.Nil;
                        _lastArgPos = 3; _expectedType = typeof(global::UnityEngine.GUIStyle);
                        if (_arg3.TryRead<global::UnityEngine.GUIStyle>(out var _p3_UnityEngine_GUIStyle))
                        {
                            if (_argCount == 4)
                            {
                                var position = _p0_UnityEngine_Rect;
                                var label = _p1_System_String;
                                var value = _p2_System_Boolean;
                                var labelStyle = _p3_UnityEngine_GUIStyle;
                                var _ret0 = global::UnityEditor.EditorGUI.ToggleLeft(position, label, value, labelStyle);
                                var _lret0 = new global::Lua.LuaValue(_ret0);
                                var _retCount = _context.Return(_lret0);
                                return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                            }
                        }
                    }
                }
                _lastArgPos = 1; _expectedType = typeof(global::UnityEngine.GUIContent);
                if (_arg1.TryRead<global::UnityEngine.GUIContent>(out var _p1_UnityEngine_GUIContent))
                {
                    var _arg2 = _lastArg = _argCount > 2 ? _context.GetArgument(2) : global::Lua.LuaValue.Nil;
                    _lastArgPos = 2; _expectedType = typeof(global::System.Boolean);
                    if (_arg2.TryRead<global::System.Boolean>(out var _p2_System_Boolean))
                    {
                        if (_argCount == 3)
                        {
                            var position = _p0_UnityEngine_Rect;
                            var label = _p1_UnityEngine_GUIContent;
                            var value = _p2_System_Boolean;
                            var _ret0 = global::UnityEditor.EditorGUI.ToggleLeft(position, label, value);
                            var _lret0 = new global::Lua.LuaValue(_ret0);
                            var _retCount = _context.Return(_lret0);
                            return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                        }
                        var _arg3 = _lastArg = _argCount > 3 ? _context.GetArgument(3) : global::Lua.LuaValue.Nil;
                        _lastArgPos = 3; _expectedType = typeof(global::UnityEngine.GUIStyle);
                        if (_arg3.TryRead<global::UnityEngine.GUIStyle>(out var _p3_UnityEngine_GUIStyle))
                        {
                            if (_argCount == 4)
                            {
                                var position = _p0_UnityEngine_Rect;
                                var label = _p1_UnityEngine_GUIContent;
                                var value = _p2_System_Boolean;
                                var labelStyle = _p3_UnityEngine_GUIStyle;
                                var _ret0 = global::UnityEditor.EditorGUI.ToggleLeft(position, label, value, labelStyle);
                                var _lret0 = new global::Lua.LuaValue(_ret0);
                                var _retCount = _context.Return(_lret0);
                                return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                            }
                        }
                    }
                }
            }
            throw new global::Lua.LuaRuntimeException(_context.Thread, $"{"ToggleLeft"}: invalid argument #{_lastArgPos}: {_lastArg} ({_lastArg.Type}), expected: {_expectedType.FullName}", 2);
        });
        private static readonly global::Lua.LuaFunction _LuaEditorGUI_Vector2Field = new global::Lua.LuaFunction("Vector2Field", (_context, _) =>
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
                _lastArgPos = 1; _expectedType = typeof(global::System.String);
                if (_arg1.TryRead<global::System.String>(out var _p1_System_String))
                {
                    var _arg2 = _lastArg = _argCount > 2 ? _context.GetArgument(2) : global::Lua.LuaValue.Nil;
                    _lastArgPos = 2; _expectedType = typeof(global::UnityEngine.Vector2);
                    if (_arg2.TryRead<global::UnityEngine.Vector2>(out var _p2_UnityEngine_Vector2))
                    {
                        if (_argCount == 3)
                        {
                            var position = _p0_UnityEngine_Rect;
                            var label = _p1_System_String;
                            var value = _p2_UnityEngine_Vector2;
                            var _ret0 = global::UnityEditor.EditorGUI.Vector2Field(position, label, value);
                            var _factory = _context.GetObjectFactory();
                            var _lret0 = _factory.Bind(_ret0);
                            var _retCount = _context.Return(_lret0);
                            return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                        }
                    }
                }
                _lastArgPos = 1; _expectedType = typeof(global::UnityEngine.GUIContent);
                if (_arg1.TryRead<global::UnityEngine.GUIContent>(out var _p1_UnityEngine_GUIContent))
                {
                    var _arg2 = _lastArg = _argCount > 2 ? _context.GetArgument(2) : global::Lua.LuaValue.Nil;
                    _lastArgPos = 2; _expectedType = typeof(global::UnityEngine.Vector2);
                    if (_arg2.TryRead<global::UnityEngine.Vector2>(out var _p2_UnityEngine_Vector2))
                    {
                        if (_argCount == 3)
                        {
                            var position = _p0_UnityEngine_Rect;
                            var label = _p1_UnityEngine_GUIContent;
                            var value = _p2_UnityEngine_Vector2;
                            var _ret0 = global::UnityEditor.EditorGUI.Vector2Field(position, label, value);
                            var _factory = _context.GetObjectFactory();
                            var _lret0 = _factory.Bind(_ret0);
                            var _retCount = _context.Return(_lret0);
                            return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                        }
                    }
                }
            }
            throw new global::Lua.LuaRuntimeException(_context.Thread, $"{"Vector2Field"}: invalid argument #{_lastArgPos}: {_lastArg} ({_lastArg.Type}), expected: {_expectedType.FullName}", 2);
        });
        private static readonly global::Lua.LuaFunction _LuaEditorGUI_Vector2IntField = new global::Lua.LuaFunction("Vector2IntField", (_context, _) =>
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
                _lastArgPos = 1; _expectedType = typeof(global::System.String);
                if (_arg1.TryRead<global::System.String>(out var _p1_System_String))
                {
                    var _arg2 = _lastArg = _argCount > 2 ? _context.GetArgument(2) : global::Lua.LuaValue.Nil;
                    _lastArgPos = 2; _expectedType = typeof(global::UnityEngine.Vector2Int);
                    if (_arg2.TryRead<global::UnityEngine.Vector2Int>(out var _p2_UnityEngine_Vector2Int))
                    {
                        if (_argCount == 3)
                        {
                            var position = _p0_UnityEngine_Rect;
                            var label = _p1_System_String;
                            var value = _p2_UnityEngine_Vector2Int;
                            var _ret0 = global::UnityEditor.EditorGUI.Vector2IntField(position, label, value);
                            var _factory = _context.GetObjectFactory();
                            var _lret0 = _factory.Bind(_ret0);
                            var _retCount = _context.Return(_lret0);
                            return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                        }
                    }
                }
                _lastArgPos = 1; _expectedType = typeof(global::UnityEngine.GUIContent);
                if (_arg1.TryRead<global::UnityEngine.GUIContent>(out var _p1_UnityEngine_GUIContent))
                {
                    var _arg2 = _lastArg = _argCount > 2 ? _context.GetArgument(2) : global::Lua.LuaValue.Nil;
                    _lastArgPos = 2; _expectedType = typeof(global::UnityEngine.Vector2Int);
                    if (_arg2.TryRead<global::UnityEngine.Vector2Int>(out var _p2_UnityEngine_Vector2Int))
                    {
                        if (_argCount == 3)
                        {
                            var position = _p0_UnityEngine_Rect;
                            var label = _p1_UnityEngine_GUIContent;
                            var value = _p2_UnityEngine_Vector2Int;
                            var _ret0 = global::UnityEditor.EditorGUI.Vector2IntField(position, label, value);
                            var _factory = _context.GetObjectFactory();
                            var _lret0 = _factory.Bind(_ret0);
                            var _retCount = _context.Return(_lret0);
                            return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                        }
                    }
                }
            }
            throw new global::Lua.LuaRuntimeException(_context.Thread, $"{"Vector2IntField"}: invalid argument #{_lastArgPos}: {_lastArg} ({_lastArg.Type}), expected: {_expectedType.FullName}", 2);
        });
        private static readonly global::Lua.LuaFunction _LuaEditorGUI_Vector3Field = new global::Lua.LuaFunction("Vector3Field", (_context, _) =>
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
                _lastArgPos = 1; _expectedType = typeof(global::System.String);
                if (_arg1.TryRead<global::System.String>(out var _p1_System_String))
                {
                    var _arg2 = _lastArg = _argCount > 2 ? _context.GetArgument(2) : global::Lua.LuaValue.Nil;
                    _lastArgPos = 2; _expectedType = typeof(global::UnityEngine.Vector3);
                    if (_arg2.TryRead<global::UnityEngine.Vector3>(out var _p2_UnityEngine_Vector3))
                    {
                        if (_argCount == 3)
                        {
                            var position = _p0_UnityEngine_Rect;
                            var label = _p1_System_String;
                            var value = _p2_UnityEngine_Vector3;
                            var _ret0 = global::UnityEditor.EditorGUI.Vector3Field(position, label, value);
                            var _factory = _context.GetObjectFactory();
                            var _lret0 = _factory.Bind(_ret0);
                            var _retCount = _context.Return(_lret0);
                            return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                        }
                    }
                }
                _lastArgPos = 1; _expectedType = typeof(global::UnityEngine.GUIContent);
                if (_arg1.TryRead<global::UnityEngine.GUIContent>(out var _p1_UnityEngine_GUIContent))
                {
                    var _arg2 = _lastArg = _argCount > 2 ? _context.GetArgument(2) : global::Lua.LuaValue.Nil;
                    _lastArgPos = 2; _expectedType = typeof(global::UnityEngine.Vector3);
                    if (_arg2.TryRead<global::UnityEngine.Vector3>(out var _p2_UnityEngine_Vector3))
                    {
                        if (_argCount == 3)
                        {
                            var position = _p0_UnityEngine_Rect;
                            var label = _p1_UnityEngine_GUIContent;
                            var value = _p2_UnityEngine_Vector3;
                            var _ret0 = global::UnityEditor.EditorGUI.Vector3Field(position, label, value);
                            var _factory = _context.GetObjectFactory();
                            var _lret0 = _factory.Bind(_ret0);
                            var _retCount = _context.Return(_lret0);
                            return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                        }
                    }
                }
            }
            throw new global::Lua.LuaRuntimeException(_context.Thread, $"{"Vector3Field"}: invalid argument #{_lastArgPos}: {_lastArg} ({_lastArg.Type}), expected: {_expectedType.FullName}", 2);
        });
        private static readonly global::Lua.LuaFunction _LuaEditorGUI_Vector3IntField = new global::Lua.LuaFunction("Vector3IntField", (_context, _) =>
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
                _lastArgPos = 1; _expectedType = typeof(global::System.String);
                if (_arg1.TryRead<global::System.String>(out var _p1_System_String))
                {
                    var _arg2 = _lastArg = _argCount > 2 ? _context.GetArgument(2) : global::Lua.LuaValue.Nil;
                    _lastArgPos = 2; _expectedType = typeof(global::UnityEngine.Vector3Int);
                    if (_arg2.TryRead<global::UnityEngine.Vector3Int>(out var _p2_UnityEngine_Vector3Int))
                    {
                        if (_argCount == 3)
                        {
                            var position = _p0_UnityEngine_Rect;
                            var label = _p1_System_String;
                            var value = _p2_UnityEngine_Vector3Int;
                            var _ret0 = global::UnityEditor.EditorGUI.Vector3IntField(position, label, value);
                            var _factory = _context.GetObjectFactory();
                            var _lret0 = _factory.Bind(_ret0);
                            var _retCount = _context.Return(_lret0);
                            return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                        }
                    }
                }
                _lastArgPos = 1; _expectedType = typeof(global::UnityEngine.GUIContent);
                if (_arg1.TryRead<global::UnityEngine.GUIContent>(out var _p1_UnityEngine_GUIContent))
                {
                    var _arg2 = _lastArg = _argCount > 2 ? _context.GetArgument(2) : global::Lua.LuaValue.Nil;
                    _lastArgPos = 2; _expectedType = typeof(global::UnityEngine.Vector3Int);
                    if (_arg2.TryRead<global::UnityEngine.Vector3Int>(out var _p2_UnityEngine_Vector3Int))
                    {
                        if (_argCount == 3)
                        {
                            var position = _p0_UnityEngine_Rect;
                            var label = _p1_UnityEngine_GUIContent;
                            var value = _p2_UnityEngine_Vector3Int;
                            var _ret0 = global::UnityEditor.EditorGUI.Vector3IntField(position, label, value);
                            var _factory = _context.GetObjectFactory();
                            var _lret0 = _factory.Bind(_ret0);
                            var _retCount = _context.Return(_lret0);
                            return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                        }
                    }
                }
            }
            throw new global::Lua.LuaRuntimeException(_context.Thread, $"{"Vector3IntField"}: invalid argument #{_lastArgPos}: {_lastArg} ({_lastArg.Type}), expected: {_expectedType.FullName}", 2);
        });
        private static readonly global::Lua.LuaFunction _LuaEditorGUI_Vector4Field = new global::Lua.LuaFunction("Vector4Field", (_context, _) =>
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
                _lastArgPos = 1; _expectedType = typeof(global::System.String);
                if (_arg1.TryRead<global::System.String>(out var _p1_System_String))
                {
                    var _arg2 = _lastArg = _argCount > 2 ? _context.GetArgument(2) : global::Lua.LuaValue.Nil;
                    _lastArgPos = 2; _expectedType = typeof(global::UnityEngine.Vector4);
                    if (_arg2.TryRead<global::UnityEngine.Vector4>(out var _p2_UnityEngine_Vector4))
                    {
                        if (_argCount == 3)
                        {
                            var position = _p0_UnityEngine_Rect;
                            var label = _p1_System_String;
                            var value = _p2_UnityEngine_Vector4;
                            var _ret0 = global::UnityEditor.EditorGUI.Vector4Field(position, label, value);
                            var _factory = _context.GetObjectFactory();
                            var _lret0 = _factory.Bind(_ret0);
                            var _retCount = _context.Return(_lret0);
                            return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                        }
                    }
                }
                _lastArgPos = 1; _expectedType = typeof(global::UnityEngine.GUIContent);
                if (_arg1.TryRead<global::UnityEngine.GUIContent>(out var _p1_UnityEngine_GUIContent))
                {
                    var _arg2 = _lastArg = _argCount > 2 ? _context.GetArgument(2) : global::Lua.LuaValue.Nil;
                    _lastArgPos = 2; _expectedType = typeof(global::UnityEngine.Vector4);
                    if (_arg2.TryRead<global::UnityEngine.Vector4>(out var _p2_UnityEngine_Vector4))
                    {
                        if (_argCount == 3)
                        {
                            var position = _p0_UnityEngine_Rect;
                            var label = _p1_UnityEngine_GUIContent;
                            var value = _p2_UnityEngine_Vector4;
                            var _ret0 = global::UnityEditor.EditorGUI.Vector4Field(position, label, value);
                            var _factory = _context.GetObjectFactory();
                            var _lret0 = _factory.Bind(_ret0);
                            var _retCount = _context.Return(_lret0);
                            return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                        }
                    }
                }
            }
            throw new global::Lua.LuaRuntimeException(_context.Thread, $"{"Vector4Field"}: invalid argument #{_lastArgPos}: {_lastArg} ({_lastArg.Type}), expected: {_expectedType.FullName}", 2);
        });
        private static readonly global::Lua.LuaFunction __index = new(global::Lua.Runtime.Metamethods.Index, (_context, _) =>
        {
            var _this = _context.GetArgument<LuaEditorGUIType>(0);
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
            var _this = _context.GetArgument<LuaEditorGUIType>(0);
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
                case "new": _value = _LuaEditorGUI_new; return true;
                case "BeginChangeCheck": _value = _LuaEditorGUI_BeginChangeCheck; return true;
                case "BeginDisabledGroup": _value = _LuaEditorGUI_BeginDisabledGroup; return true;
                case "BeginProperty": _value = _LuaEditorGUI_BeginProperty; return true;
                case "BoundsField": _value = _LuaEditorGUI_BoundsField; return true;
                case "BoundsIntField": _value = _LuaEditorGUI_BoundsIntField; return true;
                case "ColorField": _value = _LuaEditorGUI_ColorField; return true;
                case "CurveField": _value = _LuaEditorGUI_CurveField; return true;
                case "DelayedDoubleField": _value = _LuaEditorGUI_DelayedDoubleField; return true;
                case "DelayedFloatField": _value = _LuaEditorGUI_DelayedFloatField; return true;
                case "DelayedIntField": _value = _LuaEditorGUI_DelayedIntField; return true;
                case "DelayedTextField": _value = _LuaEditorGUI_DelayedTextField; return true;
                case "DoubleField": _value = _LuaEditorGUI_DoubleField; return true;
                case "DrawPreviewTexture": _value = _LuaEditorGUI_DrawPreviewTexture; return true;
                case "DrawRect": _value = _LuaEditorGUI_DrawRect; return true;
                case "DrawTextureAlpha": _value = _LuaEditorGUI_DrawTextureAlpha; return true;
                case "DrawTextureTransparent": _value = _LuaEditorGUI_DrawTextureTransparent; return true;
                case "DropdownButton": _value = _LuaEditorGUI_DropdownButton; return true;
                case "DropShadowLabel": _value = _LuaEditorGUI_DropShadowLabel; return true;
                case "EndChangeCheck": _value = _LuaEditorGUI_EndChangeCheck; return true;
                case "EndDisabledGroup": _value = _LuaEditorGUI_EndDisabledGroup; return true;
                case "EndFoldoutHeaderGroup": _value = _LuaEditorGUI_EndFoldoutHeaderGroup; return true;
                case "EndProperty": _value = _LuaEditorGUI_EndProperty; return true;
                case "EnumFlagsField": _value = _LuaEditorGUI_EnumFlagsField; return true;
                case "EnumPopup": _value = _LuaEditorGUI_EnumPopup; return true;
                case "FloatField": _value = _LuaEditorGUI_FloatField; return true;
                case "FocusTextInControl": _value = _LuaEditorGUI_FocusTextInControl; return true;
                case "Foldout": _value = _LuaEditorGUI_Foldout; return true;
                case "GetPropertyHeight": _value = _LuaEditorGUI_GetPropertyHeight; return true;
                case "GradientField": _value = _LuaEditorGUI_GradientField; return true;
                case "HandlePrefixLabel": _value = _LuaEditorGUI_HandlePrefixLabel; return true;
                case "HelpBox": _value = _LuaEditorGUI_HelpBox; return true;
                case "IndentedRect": _value = _LuaEditorGUI_IndentedRect; return true;
                case "InspectorTitlebar": _value = _LuaEditorGUI_InspectorTitlebar; return true;
                case "IntField": _value = _LuaEditorGUI_IntField; return true;
                case "IntPopup": _value = _LuaEditorGUI_IntPopup; return true;
                case "IntSlider": _value = _LuaEditorGUI_IntSlider; return true;
                case "LabelField": _value = _LuaEditorGUI_LabelField; return true;
                case "LargeSplitButtonWithDropdownList": _value = _LuaEditorGUI_LargeSplitButtonWithDropdownList; return true;
                case "LayerField": _value = _LuaEditorGUI_LayerField; return true;
                case "LinkButton": _value = _LuaEditorGUI_LinkButton; return true;
                case "LogarithmicIntSlider": _value = _LuaEditorGUI_LogarithmicIntSlider; return true;
                case "LongField": _value = _LuaEditorGUI_LongField; return true;
                case "MaskField": _value = _LuaEditorGUI_MaskField; return true;
                case "MultiFloatField": _value = _LuaEditorGUI_MultiFloatField; return true;
                case "MultiIntField": _value = _LuaEditorGUI_MultiIntField; return true;
                case "MultiPropertyField": _value = _LuaEditorGUI_MultiPropertyField; return true;
                case "ObjectField": _value = _LuaEditorGUI_ObjectField; return true;
                case "PasswordField": _value = _LuaEditorGUI_PasswordField; return true;
                case "Popup": _value = _LuaEditorGUI_Popup; return true;
                case "PrefixLabel": _value = _LuaEditorGUI_PrefixLabel; return true;
                case "ProgressBar": _value = _LuaEditorGUI_ProgressBar; return true;
                case "PropertyField": _value = _LuaEditorGUI_PropertyField; return true;
                case "RectField": _value = _LuaEditorGUI_RectField; return true;
                case "RectIntField": _value = _LuaEditorGUI_RectIntField; return true;
                case "RenderingLayerMaskField": _value = _LuaEditorGUI_RenderingLayerMaskField; return true;
                case "SelectableLabel": _value = _LuaEditorGUI_SelectableLabel; return true;
                case "Slider": _value = _LuaEditorGUI_Slider; return true;
                case "TagField": _value = _LuaEditorGUI_TagField; return true;
                case "TextArea": _value = _LuaEditorGUI_TextArea; return true;
                case "TextField": _value = _LuaEditorGUI_TextField; return true;
                case "Toggle": _value = _LuaEditorGUI_Toggle; return true;
                case "ToggleLeft": _value = _LuaEditorGUI_ToggleLeft; return true;
                case "Vector2Field": _value = _LuaEditorGUI_Vector2Field; return true;
                case "Vector2IntField": _value = _LuaEditorGUI_Vector2IntField; return true;
                case "Vector3Field": _value = _LuaEditorGUI_Vector3Field; return true;
                case "Vector3IntField": _value = _LuaEditorGUI_Vector3IntField; return true;
                case "Vector4Field": _value = _LuaEditorGUI_Vector4Field; return true;
                case "actionKey": _value = new global::Lua.LuaValue(global::UnityEditor.EditorGUI.actionKey); return true;
                case "indentLevel": _value = new global::Lua.LuaValue(global::UnityEditor.EditorGUI.indentLevel); return true;
                case "showMixedValue": _value = new global::Lua.LuaValue(global::UnityEditor.EditorGUI.showMixedValue); return true;
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
                case "indentLevel": global::UnityEditor.EditorGUI.indentLevel = _value.Read<global::System.Int32>();  return true;
                case "showMixedValue": global::UnityEditor.EditorGUI.showMixedValue = _value.Read<global::System.Boolean>();  return true;
                default: return false;
            }
        }
    }
}
#pragma warning restore 0109, 0162, 0168, 0219
#endif
