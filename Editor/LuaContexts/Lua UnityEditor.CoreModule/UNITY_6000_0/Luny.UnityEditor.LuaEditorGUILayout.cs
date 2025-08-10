
// --------------------------------------------------------------
// GENERATED FILE ----> DO NOT EDIT <---- CHANGES WILL BE LOST !!
// --------------------------------------------------------------

#if UNITY_6000_0_OR_NEWER && !(UNITY_6000_1_OR_NEWER)
#pragma warning disable 0109, 0162, 0168, 0219
using Luny;

namespace Luny.UnityEditor
{
    public sealed class LuaEditorGUILayout : global::Luny.ILuaObject<global::UnityEditor.EditorGUILayout>
    {
        public new static global::Lua.LuaValue Bind(global::UnityEditor.EditorGUILayout instance) => new LuaEditorGUILayout(instance);
        public new static global::Lua.LuaValue Bind(global::System.Object instance) => Bind((global::UnityEditor.EditorGUILayout)instance);
        public new static global::Lua.LuaValue Bind(global::System.Collections.Generic.IList<global::UnityEditor.EditorGUILayout> instances) =>
            new global::Luny.LuaList<global::UnityEditor.EditorGUILayout>(instances);
        public new static global::Lua.LuaValue Bind(global::System.Collections.Generic.IList<global::System.Object> instances) =>
            new global::Luny.LuaList<global::UnityEditor.EditorGUILayout>(instances);
        private LuaEditorGUILayout(global::UnityEditor.EditorGUILayout instance) => m_Instance = instance;
        public static implicit operator global::Lua.LuaValue(LuaEditorGUILayout value) => new(value);
        private global::UnityEditor.EditorGUILayout m_Instance;
        public global::UnityEditor.EditorGUILayout Instance => m_Instance;
        public new global::System.Type BindType => typeof(global::UnityEditor.EditorGUILayout);
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
            var _this = _context.GetArgument<LuaEditorGUILayout>(0);
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
            var _this = _context.GetArgument<LuaEditorGUILayout>(0);
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
    public sealed class LuaEditorGUILayoutType : global::Luny.ILuaStatic
    {
        public static global::Lua.LuaValue Bind() => new LuaEditorGUILayoutType();
        private LuaEditorGUILayoutType() {}
        public static implicit operator global::Lua.LuaValue(LuaEditorGUILayoutType value) => new(value);
        public global::System.Type BindType => typeof(global::UnityEditor.EditorGUILayout);
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

        private static readonly global::Lua.LuaFunction _LuaEditorGUILayout_new = new global::Lua.LuaFunction(".ctor", (_context, _) =>
        {
            global::Lua.LuaValue _lastArg = default;
            global::System.Int32 _lastArgPos = default;
            global::System.Type _expectedType = default;
            var _argCount = _context.ArgumentCount;
            if (_argCount == 0)
            {
                var _ret0 = new global::UnityEditor.EditorGUILayout();
                var _factory = _context.GetObjectFactory();
                var _lret0 = _factory.Bind(_ret0);
                var _retCount = _context.Return(_lret0);
                return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
            }
            throw new global::Lua.LuaRuntimeException(_context.Thread, $"{".ctor"}: invalid argument #{_lastArgPos}: {_lastArg} ({_lastArg.Type}), expected: {_expectedType.FullName}", 2);
        });
        private static readonly global::Lua.LuaFunction _LuaEditorGUILayout_BeginBuildTargetSelectionGrouping = new global::Lua.LuaFunction("BeginBuildTargetSelectionGrouping", (_context, _) =>
        {
            global::Lua.LuaValue _lastArg = default;
            global::System.Int32 _lastArgPos = default;
            global::System.Type _expectedType = default;
            var _argCount = _context.ArgumentCount;
            if (_argCount == 0)
            {
                var _ret0 = global::UnityEditor.EditorGUILayout.BeginBuildTargetSelectionGrouping();
                var _lret0 = new global::Lua.LuaValue((global::System.Int64)_ret0);
                var _retCount = _context.Return(_lret0);
                return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
            }
            throw new global::Lua.LuaRuntimeException(_context.Thread, $"{"BeginBuildTargetSelectionGrouping"}: invalid argument #{_lastArgPos}: {_lastArg} ({_lastArg.Type}), expected: {_expectedType.FullName}", 2);
        });
        private static readonly global::Lua.LuaFunction _LuaEditorGUILayout_BeginFadeGroup = new global::Lua.LuaFunction("BeginFadeGroup", (_context, _) =>
        {
            global::Lua.LuaValue _lastArg = default;
            global::System.Int32 _lastArgPos = default;
            global::System.Type _expectedType = default;
            var _argCount = _context.ArgumentCount;
            var _arg0 = _lastArg = _argCount > 0 ? _context.GetArgument(0) : global::Lua.LuaValue.Nil;
            _lastArgPos = 0; _expectedType = typeof(global::System.Single);
            if (_arg0.TryRead<global::System.Single>(out var _p0_System_Single))
            {
                if (_argCount == 1)
                {
                    var value = _p0_System_Single;
                    var _ret0 = global::UnityEditor.EditorGUILayout.BeginFadeGroup(value);
                    var _lret0 = new global::Lua.LuaValue(_ret0);
                    var _retCount = _context.Return(_lret0);
                    return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                }
            }
            throw new global::Lua.LuaRuntimeException(_context.Thread, $"{"BeginFadeGroup"}: invalid argument #{_lastArgPos}: {_lastArg} ({_lastArg.Type}), expected: {_expectedType.FullName}", 2);
        });
        private static readonly global::Lua.LuaFunction _LuaEditorGUILayout_BeginHorizontal = new global::Lua.LuaFunction("BeginHorizontal", (_context, _) =>
        {
            global::Lua.LuaValue _lastArg = default;
            global::System.Int32 _lastArgPos = default;
            global::System.Type _expectedType = default;
            var _argCount = _context.ArgumentCount;
            var _arg0 = _lastArg = _argCount > 0 ? _context.GetArgument(0) : global::Lua.LuaValue.Nil;
            _lastArgPos = 0; _expectedType = typeof(global::UnityEngine.GUILayoutOption[]);
            if (_arg0.TryReadArray<global::UnityEngine.GUILayoutOption>(out var _p0_UnityEngine_GUILayoutOptionArray))
            {
                if (_argCount == 1)
                {
                    var options = _p0_UnityEngine_GUILayoutOptionArray;
                    var _ret0 = global::UnityEditor.EditorGUILayout.BeginHorizontal(options);
                    var _factory = _context.GetObjectFactory();
                    var _lret0 = _factory.Bind(_ret0);
                    var _retCount = _context.Return(_lret0);
                    return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                }
            }
            _lastArgPos = 0; _expectedType = typeof(global::UnityEngine.GUIStyle);
            if (_arg0.TryRead<global::UnityEngine.GUIStyle>(out var _p0_UnityEngine_GUIStyle))
            {
                var _arg1 = _lastArg = _argCount > 1 ? _context.GetArgument(1) : global::Lua.LuaValue.Nil;
                _lastArgPos = 1; _expectedType = typeof(global::UnityEngine.GUILayoutOption[]);
                if (_arg1.TryReadArray<global::UnityEngine.GUILayoutOption>(out var _p1_UnityEngine_GUILayoutOptionArray))
                {
                    if (_argCount == 2)
                    {
                        var style = _p0_UnityEngine_GUIStyle;
                        var options = _p1_UnityEngine_GUILayoutOptionArray;
                        var _ret0 = global::UnityEditor.EditorGUILayout.BeginHorizontal(style, options);
                        var _factory = _context.GetObjectFactory();
                        var _lret0 = _factory.Bind(_ret0);
                        var _retCount = _context.Return(_lret0);
                        return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                    }
                }
            }
            throw new global::Lua.LuaRuntimeException(_context.Thread, $"{"BeginHorizontal"}: invalid argument #{_lastArgPos}: {_lastArg} ({_lastArg.Type}), expected: {_expectedType.FullName}", 2);
        });
        private static readonly global::Lua.LuaFunction _LuaEditorGUILayout_BeginScrollView = new global::Lua.LuaFunction("BeginScrollView", (_context, _) =>
        {
            global::Lua.LuaValue _lastArg = default;
            global::System.Int32 _lastArgPos = default;
            global::System.Type _expectedType = default;
            var _argCount = _context.ArgumentCount;
            var _arg0 = _lastArg = _argCount > 0 ? _context.GetArgument(0) : global::Lua.LuaValue.Nil;
            _lastArgPos = 0; _expectedType = typeof(global::UnityEngine.Vector2);
            if (_arg0.TryRead<global::UnityEngine.Vector2>(out var _p0_UnityEngine_Vector2))
            {
                var _arg1 = _lastArg = _argCount > 1 ? _context.GetArgument(1) : global::Lua.LuaValue.Nil;
                _lastArgPos = 1; _expectedType = typeof(global::UnityEngine.GUILayoutOption[]);
                if (_arg1.TryReadArray<global::UnityEngine.GUILayoutOption>(out var _p1_UnityEngine_GUILayoutOptionArray))
                {
                    if (_argCount == 2)
                    {
                        var scrollPosition = _p0_UnityEngine_Vector2;
                        var options = _p1_UnityEngine_GUILayoutOptionArray;
                        var _ret0 = global::UnityEditor.EditorGUILayout.BeginScrollView(scrollPosition, options);
                        var _factory = _context.GetObjectFactory();
                        var _lret0 = _factory.Bind(_ret0);
                        var _retCount = _context.Return(_lret0);
                        return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                    }
                }
                _lastArgPos = 1; _expectedType = typeof(global::UnityEngine.GUIStyle);
                if (_arg1.TryRead<global::UnityEngine.GUIStyle>(out var _p1_UnityEngine_GUIStyle))
                {
                    var _arg2 = _lastArg = _argCount > 2 ? _context.GetArgument(2) : global::Lua.LuaValue.Nil;
                    _lastArgPos = 2; _expectedType = typeof(global::UnityEngine.GUILayoutOption[]);
                    if (_arg2.TryReadArray<global::UnityEngine.GUILayoutOption>(out var _p2_UnityEngine_GUILayoutOptionArray))
                    {
                        if (_argCount == 3)
                        {
                            var scrollPosition = _p0_UnityEngine_Vector2;
                            var style = _p1_UnityEngine_GUIStyle;
                            var options = _p2_UnityEngine_GUILayoutOptionArray;
                            var _ret0 = global::UnityEditor.EditorGUILayout.BeginScrollView(scrollPosition, style, options);
                            var _factory = _context.GetObjectFactory();
                            var _lret0 = _factory.Bind(_ret0);
                            var _retCount = _context.Return(_lret0);
                            return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                        }
                    }
                    _lastArgPos = 2; _expectedType = typeof(global::UnityEngine.GUIStyle);
                    if (_arg2.TryRead<global::UnityEngine.GUIStyle>(out var _p2_UnityEngine_GUIStyle))
                    {
                        var _arg3 = _lastArg = _argCount > 3 ? _context.GetArgument(3) : global::Lua.LuaValue.Nil;
                        _lastArgPos = 3; _expectedType = typeof(global::UnityEngine.GUILayoutOption[]);
                        if (_arg3.TryReadArray<global::UnityEngine.GUILayoutOption>(out var _p3_UnityEngine_GUILayoutOptionArray))
                        {
                            if (_argCount == 4)
                            {
                                var scrollPosition = _p0_UnityEngine_Vector2;
                                var horizontalScrollbar = _p1_UnityEngine_GUIStyle;
                                var verticalScrollbar = _p2_UnityEngine_GUIStyle;
                                var options = _p3_UnityEngine_GUILayoutOptionArray;
                                var _ret0 = global::UnityEditor.EditorGUILayout.BeginScrollView(scrollPosition, horizontalScrollbar, verticalScrollbar, options);
                                var _factory = _context.GetObjectFactory();
                                var _lret0 = _factory.Bind(_ret0);
                                var _retCount = _context.Return(_lret0);
                                return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                            }
                        }
                    }
                }
                _lastArgPos = 1; _expectedType = typeof(global::System.Boolean);
                if (_arg1.TryRead<global::System.Boolean>(out var _p1_System_Boolean))
                {
                    var _arg2 = _lastArg = _argCount > 2 ? _context.GetArgument(2) : global::Lua.LuaValue.Nil;
                    _lastArgPos = 2; _expectedType = typeof(global::System.Boolean);
                    if (_arg2.TryRead<global::System.Boolean>(out var _p2_System_Boolean))
                    {
                        var _arg3 = _lastArg = _argCount > 3 ? _context.GetArgument(3) : global::Lua.LuaValue.Nil;
                        _lastArgPos = 3; _expectedType = typeof(global::UnityEngine.GUILayoutOption[]);
                        if (_arg3.TryReadArray<global::UnityEngine.GUILayoutOption>(out var _p3_UnityEngine_GUILayoutOptionArray))
                        {
                            if (_argCount == 4)
                            {
                                var scrollPosition = _p0_UnityEngine_Vector2;
                                var alwaysShowHorizontal = _p1_System_Boolean;
                                var alwaysShowVertical = _p2_System_Boolean;
                                var options = _p3_UnityEngine_GUILayoutOptionArray;
                                var _ret0 = global::UnityEditor.EditorGUILayout.BeginScrollView(scrollPosition, alwaysShowHorizontal, alwaysShowVertical, options);
                                var _factory = _context.GetObjectFactory();
                                var _lret0 = _factory.Bind(_ret0);
                                var _retCount = _context.Return(_lret0);
                                return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                            }
                        }
                        _lastArgPos = 3; _expectedType = typeof(global::UnityEngine.GUIStyle);
                        if (_arg3.TryRead<global::UnityEngine.GUIStyle>(out var _p3_UnityEngine_GUIStyle))
                        {
                            var _arg4 = _lastArg = _argCount > 4 ? _context.GetArgument(4) : global::Lua.LuaValue.Nil;
                            _lastArgPos = 4; _expectedType = typeof(global::UnityEngine.GUIStyle);
                            if (_arg4.TryRead<global::UnityEngine.GUIStyle>(out var _p4_UnityEngine_GUIStyle))
                            {
                                var _arg5 = _lastArg = _argCount > 5 ? _context.GetArgument(5) : global::Lua.LuaValue.Nil;
                                _lastArgPos = 5; _expectedType = typeof(global::UnityEngine.GUIStyle);
                                if (_arg5.TryRead<global::UnityEngine.GUIStyle>(out var _p5_UnityEngine_GUIStyle))
                                {
                                    var _arg6 = _lastArg = _argCount > 6 ? _context.GetArgument(6) : global::Lua.LuaValue.Nil;
                                    _lastArgPos = 6; _expectedType = typeof(global::UnityEngine.GUILayoutOption[]);
                                    if (_arg6.TryReadArray<global::UnityEngine.GUILayoutOption>(out var _p6_UnityEngine_GUILayoutOptionArray))
                                    {
                                        if (_argCount == 7)
                                        {
                                            var scrollPosition = _p0_UnityEngine_Vector2;
                                            var alwaysShowHorizontal = _p1_System_Boolean;
                                            var alwaysShowVertical = _p2_System_Boolean;
                                            var horizontalScrollbar = _p3_UnityEngine_GUIStyle;
                                            var verticalScrollbar = _p4_UnityEngine_GUIStyle;
                                            var background = _p5_UnityEngine_GUIStyle;
                                            var options = _p6_UnityEngine_GUILayoutOptionArray;
                                            var _ret0 = global::UnityEditor.EditorGUILayout.BeginScrollView(scrollPosition, alwaysShowHorizontal, alwaysShowVertical, horizontalScrollbar, verticalScrollbar, background, options);
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
            throw new global::Lua.LuaRuntimeException(_context.Thread, $"{"BeginScrollView"}: invalid argument #{_lastArgPos}: {_lastArg} ({_lastArg.Type}), expected: {_expectedType.FullName}", 2);
        });
        private static readonly global::Lua.LuaFunction _LuaEditorGUILayout_BeginToggleGroup = new global::Lua.LuaFunction("BeginToggleGroup", (_context, _) =>
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
                _lastArgPos = 1; _expectedType = typeof(global::System.Boolean);
                if (_arg1.TryRead<global::System.Boolean>(out var _p1_System_Boolean))
                {
                    if (_argCount == 2)
                    {
                        var label = _p0_System_String;
                        var toggle = _p1_System_Boolean;
                        var _ret0 = global::UnityEditor.EditorGUILayout.BeginToggleGroup(label, toggle);
                        var _lret0 = new global::Lua.LuaValue(_ret0);
                        var _retCount = _context.Return(_lret0);
                        return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                    }
                }
            }
            _lastArgPos = 0; _expectedType = typeof(global::UnityEngine.GUIContent);
            if (_arg0.TryRead<global::UnityEngine.GUIContent>(out var _p0_UnityEngine_GUIContent))
            {
                var _arg1 = _lastArg = _argCount > 1 ? _context.GetArgument(1) : global::Lua.LuaValue.Nil;
                _lastArgPos = 1; _expectedType = typeof(global::System.Boolean);
                if (_arg1.TryRead<global::System.Boolean>(out var _p1_System_Boolean))
                {
                    if (_argCount == 2)
                    {
                        var label = _p0_UnityEngine_GUIContent;
                        var toggle = _p1_System_Boolean;
                        var _ret0 = global::UnityEditor.EditorGUILayout.BeginToggleGroup(label, toggle);
                        var _lret0 = new global::Lua.LuaValue(_ret0);
                        var _retCount = _context.Return(_lret0);
                        return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                    }
                }
            }
            throw new global::Lua.LuaRuntimeException(_context.Thread, $"{"BeginToggleGroup"}: invalid argument #{_lastArgPos}: {_lastArg} ({_lastArg.Type}), expected: {_expectedType.FullName}", 2);
        });
        private static readonly global::Lua.LuaFunction _LuaEditorGUILayout_BeginVertical = new global::Lua.LuaFunction("BeginVertical", (_context, _) =>
        {
            global::Lua.LuaValue _lastArg = default;
            global::System.Int32 _lastArgPos = default;
            global::System.Type _expectedType = default;
            var _argCount = _context.ArgumentCount;
            var _arg0 = _lastArg = _argCount > 0 ? _context.GetArgument(0) : global::Lua.LuaValue.Nil;
            _lastArgPos = 0; _expectedType = typeof(global::UnityEngine.GUILayoutOption[]);
            if (_arg0.TryReadArray<global::UnityEngine.GUILayoutOption>(out var _p0_UnityEngine_GUILayoutOptionArray))
            {
                if (_argCount == 1)
                {
                    var options = _p0_UnityEngine_GUILayoutOptionArray;
                    var _ret0 = global::UnityEditor.EditorGUILayout.BeginVertical(options);
                    var _factory = _context.GetObjectFactory();
                    var _lret0 = _factory.Bind(_ret0);
                    var _retCount = _context.Return(_lret0);
                    return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                }
            }
            _lastArgPos = 0; _expectedType = typeof(global::UnityEngine.GUIStyle);
            if (_arg0.TryRead<global::UnityEngine.GUIStyle>(out var _p0_UnityEngine_GUIStyle))
            {
                var _arg1 = _lastArg = _argCount > 1 ? _context.GetArgument(1) : global::Lua.LuaValue.Nil;
                _lastArgPos = 1; _expectedType = typeof(global::UnityEngine.GUILayoutOption[]);
                if (_arg1.TryReadArray<global::UnityEngine.GUILayoutOption>(out var _p1_UnityEngine_GUILayoutOptionArray))
                {
                    if (_argCount == 2)
                    {
                        var style = _p0_UnityEngine_GUIStyle;
                        var options = _p1_UnityEngine_GUILayoutOptionArray;
                        var _ret0 = global::UnityEditor.EditorGUILayout.BeginVertical(style, options);
                        var _factory = _context.GetObjectFactory();
                        var _lret0 = _factory.Bind(_ret0);
                        var _retCount = _context.Return(_lret0);
                        return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                    }
                }
            }
            throw new global::Lua.LuaRuntimeException(_context.Thread, $"{"BeginVertical"}: invalid argument #{_lastArgPos}: {_lastArg} ({_lastArg.Type}), expected: {_expectedType.FullName}", 2);
        });
        private static readonly global::Lua.LuaFunction _LuaEditorGUILayout_BoundsField = new global::Lua.LuaFunction("BoundsField", (_context, _) =>
        {
            global::Lua.LuaValue _lastArg = default;
            global::System.Int32 _lastArgPos = default;
            global::System.Type _expectedType = default;
            var _argCount = _context.ArgumentCount;
            var _arg0 = _lastArg = _argCount > 0 ? _context.GetArgument(0) : global::Lua.LuaValue.Nil;
            _lastArgPos = 0; _expectedType = typeof(global::UnityEngine.Bounds);
            if (_arg0.TryRead<global::UnityEngine.Bounds>(out var _p0_UnityEngine_Bounds))
            {
                var _arg1 = _lastArg = _argCount > 1 ? _context.GetArgument(1) : global::Lua.LuaValue.Nil;
                _lastArgPos = 1; _expectedType = typeof(global::UnityEngine.GUILayoutOption[]);
                if (_arg1.TryReadArray<global::UnityEngine.GUILayoutOption>(out var _p1_UnityEngine_GUILayoutOptionArray))
                {
                    if (_argCount == 2)
                    {
                        var value = _p0_UnityEngine_Bounds;
                        var options = _p1_UnityEngine_GUILayoutOptionArray;
                        var _ret0 = global::UnityEditor.EditorGUILayout.BoundsField(value, options);
                        var _factory = _context.GetObjectFactory();
                        var _lret0 = _factory.Bind(_ret0);
                        var _retCount = _context.Return(_lret0);
                        return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                    }
                }
            }
            _lastArgPos = 0; _expectedType = typeof(global::System.String);
            if (_arg0.TryRead<global::System.String>(out var _p0_System_String))
            {
                var _arg1 = _lastArg = _argCount > 1 ? _context.GetArgument(1) : global::Lua.LuaValue.Nil;
                _lastArgPos = 1; _expectedType = typeof(global::UnityEngine.Bounds);
                if (_arg1.TryRead<global::UnityEngine.Bounds>(out var _p1_UnityEngine_Bounds))
                {
                    var _arg2 = _lastArg = _argCount > 2 ? _context.GetArgument(2) : global::Lua.LuaValue.Nil;
                    _lastArgPos = 2; _expectedType = typeof(global::UnityEngine.GUILayoutOption[]);
                    if (_arg2.TryReadArray<global::UnityEngine.GUILayoutOption>(out var _p2_UnityEngine_GUILayoutOptionArray))
                    {
                        if (_argCount == 3)
                        {
                            var label = _p0_System_String;
                            var value = _p1_UnityEngine_Bounds;
                            var options = _p2_UnityEngine_GUILayoutOptionArray;
                            var _ret0 = global::UnityEditor.EditorGUILayout.BoundsField(label, value, options);
                            var _factory = _context.GetObjectFactory();
                            var _lret0 = _factory.Bind(_ret0);
                            var _retCount = _context.Return(_lret0);
                            return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                        }
                    }
                }
            }
            _lastArgPos = 0; _expectedType = typeof(global::UnityEngine.GUIContent);
            if (_arg0.TryRead<global::UnityEngine.GUIContent>(out var _p0_UnityEngine_GUIContent))
            {
                var _arg1 = _lastArg = _argCount > 1 ? _context.GetArgument(1) : global::Lua.LuaValue.Nil;
                _lastArgPos = 1; _expectedType = typeof(global::UnityEngine.Bounds);
                if (_arg1.TryRead<global::UnityEngine.Bounds>(out var _p1_UnityEngine_Bounds))
                {
                    var _arg2 = _lastArg = _argCount > 2 ? _context.GetArgument(2) : global::Lua.LuaValue.Nil;
                    _lastArgPos = 2; _expectedType = typeof(global::UnityEngine.GUILayoutOption[]);
                    if (_arg2.TryReadArray<global::UnityEngine.GUILayoutOption>(out var _p2_UnityEngine_GUILayoutOptionArray))
                    {
                        if (_argCount == 3)
                        {
                            var label = _p0_UnityEngine_GUIContent;
                            var value = _p1_UnityEngine_Bounds;
                            var options = _p2_UnityEngine_GUILayoutOptionArray;
                            var _ret0 = global::UnityEditor.EditorGUILayout.BoundsField(label, value, options);
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
        private static readonly global::Lua.LuaFunction _LuaEditorGUILayout_BoundsIntField = new global::Lua.LuaFunction("BoundsIntField", (_context, _) =>
        {
            global::Lua.LuaValue _lastArg = default;
            global::System.Int32 _lastArgPos = default;
            global::System.Type _expectedType = default;
            var _argCount = _context.ArgumentCount;
            var _arg0 = _lastArg = _argCount > 0 ? _context.GetArgument(0) : global::Lua.LuaValue.Nil;
            _lastArgPos = 0; _expectedType = typeof(global::UnityEngine.BoundsInt);
            if (_arg0.TryRead<global::UnityEngine.BoundsInt>(out var _p0_UnityEngine_BoundsInt))
            {
                var _arg1 = _lastArg = _argCount > 1 ? _context.GetArgument(1) : global::Lua.LuaValue.Nil;
                _lastArgPos = 1; _expectedType = typeof(global::UnityEngine.GUILayoutOption[]);
                if (_arg1.TryReadArray<global::UnityEngine.GUILayoutOption>(out var _p1_UnityEngine_GUILayoutOptionArray))
                {
                    if (_argCount == 2)
                    {
                        var value = _p0_UnityEngine_BoundsInt;
                        var options = _p1_UnityEngine_GUILayoutOptionArray;
                        var _ret0 = global::UnityEditor.EditorGUILayout.BoundsIntField(value, options);
                        var _factory = _context.GetObjectFactory();
                        var _lret0 = _factory.Bind(_ret0);
                        var _retCount = _context.Return(_lret0);
                        return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                    }
                }
            }
            _lastArgPos = 0; _expectedType = typeof(global::System.String);
            if (_arg0.TryRead<global::System.String>(out var _p0_System_String))
            {
                var _arg1 = _lastArg = _argCount > 1 ? _context.GetArgument(1) : global::Lua.LuaValue.Nil;
                _lastArgPos = 1; _expectedType = typeof(global::UnityEngine.BoundsInt);
                if (_arg1.TryRead<global::UnityEngine.BoundsInt>(out var _p1_UnityEngine_BoundsInt))
                {
                    var _arg2 = _lastArg = _argCount > 2 ? _context.GetArgument(2) : global::Lua.LuaValue.Nil;
                    _lastArgPos = 2; _expectedType = typeof(global::UnityEngine.GUILayoutOption[]);
                    if (_arg2.TryReadArray<global::UnityEngine.GUILayoutOption>(out var _p2_UnityEngine_GUILayoutOptionArray))
                    {
                        if (_argCount == 3)
                        {
                            var label = _p0_System_String;
                            var value = _p1_UnityEngine_BoundsInt;
                            var options = _p2_UnityEngine_GUILayoutOptionArray;
                            var _ret0 = global::UnityEditor.EditorGUILayout.BoundsIntField(label, value, options);
                            var _factory = _context.GetObjectFactory();
                            var _lret0 = _factory.Bind(_ret0);
                            var _retCount = _context.Return(_lret0);
                            return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                        }
                    }
                }
            }
            _lastArgPos = 0; _expectedType = typeof(global::UnityEngine.GUIContent);
            if (_arg0.TryRead<global::UnityEngine.GUIContent>(out var _p0_UnityEngine_GUIContent))
            {
                var _arg1 = _lastArg = _argCount > 1 ? _context.GetArgument(1) : global::Lua.LuaValue.Nil;
                _lastArgPos = 1; _expectedType = typeof(global::UnityEngine.BoundsInt);
                if (_arg1.TryRead<global::UnityEngine.BoundsInt>(out var _p1_UnityEngine_BoundsInt))
                {
                    var _arg2 = _lastArg = _argCount > 2 ? _context.GetArgument(2) : global::Lua.LuaValue.Nil;
                    _lastArgPos = 2; _expectedType = typeof(global::UnityEngine.GUILayoutOption[]);
                    if (_arg2.TryReadArray<global::UnityEngine.GUILayoutOption>(out var _p2_UnityEngine_GUILayoutOptionArray))
                    {
                        if (_argCount == 3)
                        {
                            var label = _p0_UnityEngine_GUIContent;
                            var value = _p1_UnityEngine_BoundsInt;
                            var options = _p2_UnityEngine_GUILayoutOptionArray;
                            var _ret0 = global::UnityEditor.EditorGUILayout.BoundsIntField(label, value, options);
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
        private static readonly global::Lua.LuaFunction _LuaEditorGUILayout_ColorField = new global::Lua.LuaFunction("ColorField", (_context, _) =>
        {
            global::Lua.LuaValue _lastArg = default;
            global::System.Int32 _lastArgPos = default;
            global::System.Type _expectedType = default;
            var _argCount = _context.ArgumentCount;
            var _arg0 = _lastArg = _argCount > 0 ? _context.GetArgument(0) : global::Lua.LuaValue.Nil;
            _lastArgPos = 0; _expectedType = typeof(global::UnityEngine.Color);
            if (_arg0.TryRead<global::UnityEngine.Color>(out var _p0_UnityEngine_Color))
            {
                var _arg1 = _lastArg = _argCount > 1 ? _context.GetArgument(1) : global::Lua.LuaValue.Nil;
                _lastArgPos = 1; _expectedType = typeof(global::UnityEngine.GUILayoutOption[]);
                if (_arg1.TryReadArray<global::UnityEngine.GUILayoutOption>(out var _p1_UnityEngine_GUILayoutOptionArray))
                {
                    if (_argCount == 2)
                    {
                        var value = _p0_UnityEngine_Color;
                        var options = _p1_UnityEngine_GUILayoutOptionArray;
                        var _ret0 = global::UnityEditor.EditorGUILayout.ColorField(value, options);
                        var _factory = _context.GetObjectFactory();
                        var _lret0 = _factory.Bind(_ret0);
                        var _retCount = _context.Return(_lret0);
                        return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                    }
                }
            }
            _lastArgPos = 0; _expectedType = typeof(global::System.String);
            if (_arg0.TryRead<global::System.String>(out var _p0_System_String))
            {
                var _arg1 = _lastArg = _argCount > 1 ? _context.GetArgument(1) : global::Lua.LuaValue.Nil;
                _lastArgPos = 1; _expectedType = typeof(global::UnityEngine.Color);
                if (_arg1.TryRead<global::UnityEngine.Color>(out var _p1_UnityEngine_Color))
                {
                    var _arg2 = _lastArg = _argCount > 2 ? _context.GetArgument(2) : global::Lua.LuaValue.Nil;
                    _lastArgPos = 2; _expectedType = typeof(global::UnityEngine.GUILayoutOption[]);
                    if (_arg2.TryReadArray<global::UnityEngine.GUILayoutOption>(out var _p2_UnityEngine_GUILayoutOptionArray))
                    {
                        if (_argCount == 3)
                        {
                            var label = _p0_System_String;
                            var value = _p1_UnityEngine_Color;
                            var options = _p2_UnityEngine_GUILayoutOptionArray;
                            var _ret0 = global::UnityEditor.EditorGUILayout.ColorField(label, value, options);
                            var _factory = _context.GetObjectFactory();
                            var _lret0 = _factory.Bind(_ret0);
                            var _retCount = _context.Return(_lret0);
                            return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                        }
                    }
                }
            }
            _lastArgPos = 0; _expectedType = typeof(global::UnityEngine.GUIContent);
            if (_arg0.TryRead<global::UnityEngine.GUIContent>(out var _p0_UnityEngine_GUIContent))
            {
                var _arg1 = _lastArg = _argCount > 1 ? _context.GetArgument(1) : global::Lua.LuaValue.Nil;
                _lastArgPos = 1; _expectedType = typeof(global::UnityEngine.Color);
                if (_arg1.TryRead<global::UnityEngine.Color>(out var _p1_UnityEngine_Color))
                {
                    var _arg2 = _lastArg = _argCount > 2 ? _context.GetArgument(2) : global::Lua.LuaValue.Nil;
                    _lastArgPos = 2; _expectedType = typeof(global::UnityEngine.GUILayoutOption[]);
                    if (_arg2.TryReadArray<global::UnityEngine.GUILayoutOption>(out var _p2_UnityEngine_GUILayoutOptionArray))
                    {
                        if (_argCount == 3)
                        {
                            var label = _p0_UnityEngine_GUIContent;
                            var value = _p1_UnityEngine_Color;
                            var options = _p2_UnityEngine_GUILayoutOptionArray;
                            var _ret0 = global::UnityEditor.EditorGUILayout.ColorField(label, value, options);
                            var _factory = _context.GetObjectFactory();
                            var _lret0 = _factory.Bind(_ret0);
                            var _retCount = _context.Return(_lret0);
                            return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                        }
                    }
                    _lastArgPos = 2; _expectedType = typeof(global::System.Boolean);
                    if (_arg2.TryRead<global::System.Boolean>(out var _p2_System_Boolean))
                    {
                        var _arg3 = _lastArg = _argCount > 3 ? _context.GetArgument(3) : global::Lua.LuaValue.Nil;
                        _lastArgPos = 3; _expectedType = typeof(global::System.Boolean);
                        if (_arg3.TryRead<global::System.Boolean>(out var _p3_System_Boolean))
                        {
                            var _arg4 = _lastArg = _argCount > 4 ? _context.GetArgument(4) : global::Lua.LuaValue.Nil;
                            _lastArgPos = 4; _expectedType = typeof(global::System.Boolean);
                            if (_arg4.TryRead<global::System.Boolean>(out var _p4_System_Boolean))
                            {
                                var _arg5 = _lastArg = _argCount > 5 ? _context.GetArgument(5) : global::Lua.LuaValue.Nil;
                                _lastArgPos = 5; _expectedType = typeof(global::UnityEngine.GUILayoutOption[]);
                                if (_arg5.TryReadArray<global::UnityEngine.GUILayoutOption>(out var _p5_UnityEngine_GUILayoutOptionArray))
                                {
                                    if (_argCount == 6)
                                    {
                                        var label = _p0_UnityEngine_GUIContent;
                                        var value = _p1_UnityEngine_Color;
                                        var showEyedropper = _p2_System_Boolean;
                                        var showAlpha = _p3_System_Boolean;
                                        var hdr = _p4_System_Boolean;
                                        var options = _p5_UnityEngine_GUILayoutOptionArray;
                                        var _ret0 = global::UnityEditor.EditorGUILayout.ColorField(label, value, showEyedropper, showAlpha, hdr, options);
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
        private static readonly global::Lua.LuaFunction _LuaEditorGUILayout_CurveField = new global::Lua.LuaFunction("CurveField", (_context, _) =>
        {
            global::Lua.LuaValue _lastArg = default;
            global::System.Int32 _lastArgPos = default;
            global::System.Type _expectedType = default;
            var _argCount = _context.ArgumentCount;
            var _arg0 = _lastArg = _argCount > 0 ? _context.GetArgument(0) : global::Lua.LuaValue.Nil;
            _lastArgPos = 0; _expectedType = typeof(global::UnityEngine.AnimationCurve);
            if (_arg0.TryRead<global::UnityEngine.AnimationCurve>(out var _p0_UnityEngine_AnimationCurve))
            {
                var _arg1 = _lastArg = _argCount > 1 ? _context.GetArgument(1) : global::Lua.LuaValue.Nil;
                _lastArgPos = 1; _expectedType = typeof(global::UnityEngine.GUILayoutOption[]);
                if (_arg1.TryReadArray<global::UnityEngine.GUILayoutOption>(out var _p1_UnityEngine_GUILayoutOptionArray))
                {
                    if (_argCount == 2)
                    {
                        var value = _p0_UnityEngine_AnimationCurve;
                        var options = _p1_UnityEngine_GUILayoutOptionArray;
                        var _ret0 = global::UnityEditor.EditorGUILayout.CurveField(value, options);
                        var _factory = _context.GetObjectFactory();
                        var _lret0 = _factory.Bind(_ret0);
                        var _retCount = _context.Return(_lret0);
                        return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                    }
                }
                _lastArgPos = 1; _expectedType = typeof(global::UnityEngine.Color);
                if (_arg1.TryRead<global::UnityEngine.Color>(out var _p1_UnityEngine_Color))
                {
                    var _arg2 = _lastArg = _argCount > 2 ? _context.GetArgument(2) : global::Lua.LuaValue.Nil;
                    _lastArgPos = 2; _expectedType = typeof(global::UnityEngine.Rect);
                    if (_arg2.TryRead<global::UnityEngine.Rect>(out var _p2_UnityEngine_Rect))
                    {
                        var _arg3 = _lastArg = _argCount > 3 ? _context.GetArgument(3) : global::Lua.LuaValue.Nil;
                        _lastArgPos = 3; _expectedType = typeof(global::UnityEngine.GUILayoutOption[]);
                        if (_arg3.TryReadArray<global::UnityEngine.GUILayoutOption>(out var _p3_UnityEngine_GUILayoutOptionArray))
                        {
                            if (_argCount == 4)
                            {
                                var value = _p0_UnityEngine_AnimationCurve;
                                var color = _p1_UnityEngine_Color;
                                var ranges = _p2_UnityEngine_Rect;
                                var options = _p3_UnityEngine_GUILayoutOptionArray;
                                var _ret0 = global::UnityEditor.EditorGUILayout.CurveField(value, color, ranges, options);
                                var _factory = _context.GetObjectFactory();
                                var _lret0 = _factory.Bind(_ret0);
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
                var _arg1 = _lastArg = _argCount > 1 ? _context.GetArgument(1) : global::Lua.LuaValue.Nil;
                _lastArgPos = 1; _expectedType = typeof(global::UnityEngine.AnimationCurve);
                if (_arg1.TryRead<global::UnityEngine.AnimationCurve>(out var _p1_UnityEngine_AnimationCurve))
                {
                    var _arg2 = _lastArg = _argCount > 2 ? _context.GetArgument(2) : global::Lua.LuaValue.Nil;
                    _lastArgPos = 2; _expectedType = typeof(global::UnityEngine.GUILayoutOption[]);
                    if (_arg2.TryReadArray<global::UnityEngine.GUILayoutOption>(out var _p2_UnityEngine_GUILayoutOptionArray))
                    {
                        if (_argCount == 3)
                        {
                            var label = _p0_System_String;
                            var value = _p1_UnityEngine_AnimationCurve;
                            var options = _p2_UnityEngine_GUILayoutOptionArray;
                            var _ret0 = global::UnityEditor.EditorGUILayout.CurveField(label, value, options);
                            var _factory = _context.GetObjectFactory();
                            var _lret0 = _factory.Bind(_ret0);
                            var _retCount = _context.Return(_lret0);
                            return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                        }
                    }
                    _lastArgPos = 2; _expectedType = typeof(global::UnityEngine.Color);
                    if (_arg2.TryRead<global::UnityEngine.Color>(out var _p2_UnityEngine_Color))
                    {
                        var _arg3 = _lastArg = _argCount > 3 ? _context.GetArgument(3) : global::Lua.LuaValue.Nil;
                        _lastArgPos = 3; _expectedType = typeof(global::UnityEngine.Rect);
                        if (_arg3.TryRead<global::UnityEngine.Rect>(out var _p3_UnityEngine_Rect))
                        {
                            var _arg4 = _lastArg = _argCount > 4 ? _context.GetArgument(4) : global::Lua.LuaValue.Nil;
                            _lastArgPos = 4; _expectedType = typeof(global::UnityEngine.GUILayoutOption[]);
                            if (_arg4.TryReadArray<global::UnityEngine.GUILayoutOption>(out var _p4_UnityEngine_GUILayoutOptionArray))
                            {
                                if (_argCount == 5)
                                {
                                    var label = _p0_System_String;
                                    var value = _p1_UnityEngine_AnimationCurve;
                                    var color = _p2_UnityEngine_Color;
                                    var ranges = _p3_UnityEngine_Rect;
                                    var options = _p4_UnityEngine_GUILayoutOptionArray;
                                    var _ret0 = global::UnityEditor.EditorGUILayout.CurveField(label, value, color, ranges, options);
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
            _lastArgPos = 0; _expectedType = typeof(global::UnityEngine.GUIContent);
            if (_arg0.TryRead<global::UnityEngine.GUIContent>(out var _p0_UnityEngine_GUIContent))
            {
                var _arg1 = _lastArg = _argCount > 1 ? _context.GetArgument(1) : global::Lua.LuaValue.Nil;
                _lastArgPos = 1; _expectedType = typeof(global::UnityEngine.AnimationCurve);
                if (_arg1.TryRead<global::UnityEngine.AnimationCurve>(out var _p1_UnityEngine_AnimationCurve))
                {
                    var _arg2 = _lastArg = _argCount > 2 ? _context.GetArgument(2) : global::Lua.LuaValue.Nil;
                    _lastArgPos = 2; _expectedType = typeof(global::UnityEngine.GUILayoutOption[]);
                    if (_arg2.TryReadArray<global::UnityEngine.GUILayoutOption>(out var _p2_UnityEngine_GUILayoutOptionArray))
                    {
                        if (_argCount == 3)
                        {
                            var label = _p0_UnityEngine_GUIContent;
                            var value = _p1_UnityEngine_AnimationCurve;
                            var options = _p2_UnityEngine_GUILayoutOptionArray;
                            var _ret0 = global::UnityEditor.EditorGUILayout.CurveField(label, value, options);
                            var _factory = _context.GetObjectFactory();
                            var _lret0 = _factory.Bind(_ret0);
                            var _retCount = _context.Return(_lret0);
                            return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                        }
                    }
                    _lastArgPos = 2; _expectedType = typeof(global::UnityEngine.Color);
                    if (_arg2.TryRead<global::UnityEngine.Color>(out var _p2_UnityEngine_Color))
                    {
                        var _arg3 = _lastArg = _argCount > 3 ? _context.GetArgument(3) : global::Lua.LuaValue.Nil;
                        _lastArgPos = 3; _expectedType = typeof(global::UnityEngine.Rect);
                        if (_arg3.TryRead<global::UnityEngine.Rect>(out var _p3_UnityEngine_Rect))
                        {
                            var _arg4 = _lastArg = _argCount > 4 ? _context.GetArgument(4) : global::Lua.LuaValue.Nil;
                            _lastArgPos = 4; _expectedType = typeof(global::UnityEngine.GUILayoutOption[]);
                            if (_arg4.TryReadArray<global::UnityEngine.GUILayoutOption>(out var _p4_UnityEngine_GUILayoutOptionArray))
                            {
                                if (_argCount == 5)
                                {
                                    var label = _p0_UnityEngine_GUIContent;
                                    var value = _p1_UnityEngine_AnimationCurve;
                                    var color = _p2_UnityEngine_Color;
                                    var ranges = _p3_UnityEngine_Rect;
                                    var options = _p4_UnityEngine_GUILayoutOptionArray;
                                    var _ret0 = global::UnityEditor.EditorGUILayout.CurveField(label, value, color, ranges, options);
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
            _lastArgPos = 0; _expectedType = typeof(global::Luny.UnityEditor.LuaSerializedProperty);
            if (_arg0.TryRead<global::Luny.UnityEditor.LuaSerializedProperty>(out var _p0_UnityEditor_SerializedProperty))
            {
                var _arg1 = _lastArg = _argCount > 1 ? _context.GetArgument(1) : global::Lua.LuaValue.Nil;
                _lastArgPos = 1; _expectedType = typeof(global::UnityEngine.Color);
                if (_arg1.TryRead<global::UnityEngine.Color>(out var _p1_UnityEngine_Color))
                {
                    var _arg2 = _lastArg = _argCount > 2 ? _context.GetArgument(2) : global::Lua.LuaValue.Nil;
                    _lastArgPos = 2; _expectedType = typeof(global::UnityEngine.Rect);
                    if (_arg2.TryRead<global::UnityEngine.Rect>(out var _p2_UnityEngine_Rect))
                    {
                        var _arg3 = _lastArg = _argCount > 3 ? _context.GetArgument(3) : global::Lua.LuaValue.Nil;
                        _lastArgPos = 3; _expectedType = typeof(global::UnityEngine.GUILayoutOption[]);
                        if (_arg3.TryReadArray<global::UnityEngine.GUILayoutOption>(out var _p3_UnityEngine_GUILayoutOptionArray))
                        {
                            if (_argCount == 4)
                            {
                                var property = _p0_UnityEditor_SerializedProperty.Instance;
                                var color = _p1_UnityEngine_Color;
                                var ranges = _p2_UnityEngine_Rect;
                                var options = _p3_UnityEngine_GUILayoutOptionArray;
                                global::UnityEditor.EditorGUILayout.CurveField(property, color, ranges, options);
                                var _retCount = _context.Return();
                                return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                            }
                        }
                        _lastArgPos = 3; _expectedType = typeof(global::UnityEngine.GUIContent);
                        if (_arg3.TryRead<global::UnityEngine.GUIContent>(out var _p3_UnityEngine_GUIContent))
                        {
                            var _arg4 = _lastArg = _argCount > 4 ? _context.GetArgument(4) : global::Lua.LuaValue.Nil;
                            _lastArgPos = 4; _expectedType = typeof(global::UnityEngine.GUILayoutOption[]);
                            if (_arg4.TryReadArray<global::UnityEngine.GUILayoutOption>(out var _p4_UnityEngine_GUILayoutOptionArray))
                            {
                                if (_argCount == 5)
                                {
                                    var property = _p0_UnityEditor_SerializedProperty.Instance;
                                    var color = _p1_UnityEngine_Color;
                                    var ranges = _p2_UnityEngine_Rect;
                                    var label = _p3_UnityEngine_GUIContent;
                                    var options = _p4_UnityEngine_GUILayoutOptionArray;
                                    global::UnityEditor.EditorGUILayout.CurveField(property, color, ranges, label, options);
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
        private static readonly global::Lua.LuaFunction _LuaEditorGUILayout_DelayedDoubleField = new global::Lua.LuaFunction("DelayedDoubleField", (_context, _) =>
        {
            global::Lua.LuaValue _lastArg = default;
            global::System.Int32 _lastArgPos = default;
            global::System.Type _expectedType = default;
            var _argCount = _context.ArgumentCount;
            var _arg0 = _lastArg = _argCount > 0 ? _context.GetArgument(0) : global::Lua.LuaValue.Nil;
            _lastArgPos = 0; _expectedType = typeof(global::System.Double);
            if (_arg0.TryRead<global::System.Double>(out var _p0_System_Double))
            {
                var _arg1 = _lastArg = _argCount > 1 ? _context.GetArgument(1) : global::Lua.LuaValue.Nil;
                _lastArgPos = 1; _expectedType = typeof(global::UnityEngine.GUILayoutOption[]);
                if (_arg1.TryReadArray<global::UnityEngine.GUILayoutOption>(out var _p1_UnityEngine_GUILayoutOptionArray))
                {
                    if (_argCount == 2)
                    {
                        var value = _p0_System_Double;
                        var options = _p1_UnityEngine_GUILayoutOptionArray;
                        var _ret0 = global::UnityEditor.EditorGUILayout.DelayedDoubleField(value, options);
                        var _lret0 = new global::Lua.LuaValue(_ret0);
                        var _retCount = _context.Return(_lret0);
                        return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                    }
                }
                _lastArgPos = 1; _expectedType = typeof(global::UnityEngine.GUIStyle);
                if (_arg1.TryRead<global::UnityEngine.GUIStyle>(out var _p1_UnityEngine_GUIStyle))
                {
                    var _arg2 = _lastArg = _argCount > 2 ? _context.GetArgument(2) : global::Lua.LuaValue.Nil;
                    _lastArgPos = 2; _expectedType = typeof(global::UnityEngine.GUILayoutOption[]);
                    if (_arg2.TryReadArray<global::UnityEngine.GUILayoutOption>(out var _p2_UnityEngine_GUILayoutOptionArray))
                    {
                        if (_argCount == 3)
                        {
                            var value = _p0_System_Double;
                            var style = _p1_UnityEngine_GUIStyle;
                            var options = _p2_UnityEngine_GUILayoutOptionArray;
                            var _ret0 = global::UnityEditor.EditorGUILayout.DelayedDoubleField(value, style, options);
                            var _lret0 = new global::Lua.LuaValue(_ret0);
                            var _retCount = _context.Return(_lret0);
                            return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                        }
                    }
                }
            }
            _lastArgPos = 0; _expectedType = typeof(global::System.String);
            if (_arg0.TryRead<global::System.String>(out var _p0_System_String))
            {
                var _arg1 = _lastArg = _argCount > 1 ? _context.GetArgument(1) : global::Lua.LuaValue.Nil;
                _lastArgPos = 1; _expectedType = typeof(global::System.Double);
                if (_arg1.TryRead<global::System.Double>(out var _p1_System_Double))
                {
                    var _arg2 = _lastArg = _argCount > 2 ? _context.GetArgument(2) : global::Lua.LuaValue.Nil;
                    _lastArgPos = 2; _expectedType = typeof(global::UnityEngine.GUILayoutOption[]);
                    if (_arg2.TryReadArray<global::UnityEngine.GUILayoutOption>(out var _p2_UnityEngine_GUILayoutOptionArray))
                    {
                        if (_argCount == 3)
                        {
                            var label = _p0_System_String;
                            var value = _p1_System_Double;
                            var options = _p2_UnityEngine_GUILayoutOptionArray;
                            var _ret0 = global::UnityEditor.EditorGUILayout.DelayedDoubleField(label, value, options);
                            var _lret0 = new global::Lua.LuaValue(_ret0);
                            var _retCount = _context.Return(_lret0);
                            return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                        }
                    }
                    _lastArgPos = 2; _expectedType = typeof(global::UnityEngine.GUIStyle);
                    if (_arg2.TryRead<global::UnityEngine.GUIStyle>(out var _p2_UnityEngine_GUIStyle))
                    {
                        var _arg3 = _lastArg = _argCount > 3 ? _context.GetArgument(3) : global::Lua.LuaValue.Nil;
                        _lastArgPos = 3; _expectedType = typeof(global::UnityEngine.GUILayoutOption[]);
                        if (_arg3.TryReadArray<global::UnityEngine.GUILayoutOption>(out var _p3_UnityEngine_GUILayoutOptionArray))
                        {
                            if (_argCount == 4)
                            {
                                var label = _p0_System_String;
                                var value = _p1_System_Double;
                                var style = _p2_UnityEngine_GUIStyle;
                                var options = _p3_UnityEngine_GUILayoutOptionArray;
                                var _ret0 = global::UnityEditor.EditorGUILayout.DelayedDoubleField(label, value, style, options);
                                var _lret0 = new global::Lua.LuaValue(_ret0);
                                var _retCount = _context.Return(_lret0);
                                return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                            }
                        }
                    }
                }
            }
            _lastArgPos = 0; _expectedType = typeof(global::UnityEngine.GUIContent);
            if (_arg0.TryRead<global::UnityEngine.GUIContent>(out var _p0_UnityEngine_GUIContent))
            {
                var _arg1 = _lastArg = _argCount > 1 ? _context.GetArgument(1) : global::Lua.LuaValue.Nil;
                _lastArgPos = 1; _expectedType = typeof(global::System.Double);
                if (_arg1.TryRead<global::System.Double>(out var _p1_System_Double))
                {
                    var _arg2 = _lastArg = _argCount > 2 ? _context.GetArgument(2) : global::Lua.LuaValue.Nil;
                    _lastArgPos = 2; _expectedType = typeof(global::UnityEngine.GUILayoutOption[]);
                    if (_arg2.TryReadArray<global::UnityEngine.GUILayoutOption>(out var _p2_UnityEngine_GUILayoutOptionArray))
                    {
                        if (_argCount == 3)
                        {
                            var label = _p0_UnityEngine_GUIContent;
                            var value = _p1_System_Double;
                            var options = _p2_UnityEngine_GUILayoutOptionArray;
                            var _ret0 = global::UnityEditor.EditorGUILayout.DelayedDoubleField(label, value, options);
                            var _lret0 = new global::Lua.LuaValue(_ret0);
                            var _retCount = _context.Return(_lret0);
                            return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                        }
                    }
                    _lastArgPos = 2; _expectedType = typeof(global::UnityEngine.GUIStyle);
                    if (_arg2.TryRead<global::UnityEngine.GUIStyle>(out var _p2_UnityEngine_GUIStyle))
                    {
                        var _arg3 = _lastArg = _argCount > 3 ? _context.GetArgument(3) : global::Lua.LuaValue.Nil;
                        _lastArgPos = 3; _expectedType = typeof(global::UnityEngine.GUILayoutOption[]);
                        if (_arg3.TryReadArray<global::UnityEngine.GUILayoutOption>(out var _p3_UnityEngine_GUILayoutOptionArray))
                        {
                            if (_argCount == 4)
                            {
                                var label = _p0_UnityEngine_GUIContent;
                                var value = _p1_System_Double;
                                var style = _p2_UnityEngine_GUIStyle;
                                var options = _p3_UnityEngine_GUILayoutOptionArray;
                                var _ret0 = global::UnityEditor.EditorGUILayout.DelayedDoubleField(label, value, style, options);
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
        private static readonly global::Lua.LuaFunction _LuaEditorGUILayout_DelayedFloatField = new global::Lua.LuaFunction("DelayedFloatField", (_context, _) =>
        {
            global::Lua.LuaValue _lastArg = default;
            global::System.Int32 _lastArgPos = default;
            global::System.Type _expectedType = default;
            var _argCount = _context.ArgumentCount;
            var _arg0 = _lastArg = _argCount > 0 ? _context.GetArgument(0) : global::Lua.LuaValue.Nil;
            _lastArgPos = 0; _expectedType = typeof(global::System.Single);
            if (_arg0.TryRead<global::System.Single>(out var _p0_System_Single))
            {
                var _arg1 = _lastArg = _argCount > 1 ? _context.GetArgument(1) : global::Lua.LuaValue.Nil;
                _lastArgPos = 1; _expectedType = typeof(global::UnityEngine.GUILayoutOption[]);
                if (_arg1.TryReadArray<global::UnityEngine.GUILayoutOption>(out var _p1_UnityEngine_GUILayoutOptionArray))
                {
                    if (_argCount == 2)
                    {
                        var value = _p0_System_Single;
                        var options = _p1_UnityEngine_GUILayoutOptionArray;
                        var _ret0 = global::UnityEditor.EditorGUILayout.DelayedFloatField(value, options);
                        var _lret0 = new global::Lua.LuaValue(_ret0);
                        var _retCount = _context.Return(_lret0);
                        return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                    }
                }
                _lastArgPos = 1; _expectedType = typeof(global::UnityEngine.GUIStyle);
                if (_arg1.TryRead<global::UnityEngine.GUIStyle>(out var _p1_UnityEngine_GUIStyle))
                {
                    var _arg2 = _lastArg = _argCount > 2 ? _context.GetArgument(2) : global::Lua.LuaValue.Nil;
                    _lastArgPos = 2; _expectedType = typeof(global::UnityEngine.GUILayoutOption[]);
                    if (_arg2.TryReadArray<global::UnityEngine.GUILayoutOption>(out var _p2_UnityEngine_GUILayoutOptionArray))
                    {
                        if (_argCount == 3)
                        {
                            var value = _p0_System_Single;
                            var style = _p1_UnityEngine_GUIStyle;
                            var options = _p2_UnityEngine_GUILayoutOptionArray;
                            var _ret0 = global::UnityEditor.EditorGUILayout.DelayedFloatField(value, style, options);
                            var _lret0 = new global::Lua.LuaValue(_ret0);
                            var _retCount = _context.Return(_lret0);
                            return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                        }
                    }
                }
            }
            _lastArgPos = 0; _expectedType = typeof(global::Luny.UnityEditor.LuaSerializedProperty);
            if (_arg0.TryRead<global::Luny.UnityEditor.LuaSerializedProperty>(out var _p0_UnityEditor_SerializedProperty))
            {
                var _arg1 = _lastArg = _argCount > 1 ? _context.GetArgument(1) : global::Lua.LuaValue.Nil;
                _lastArgPos = 1; _expectedType = typeof(global::UnityEngine.GUILayoutOption[]);
                if (_arg1.TryReadArray<global::UnityEngine.GUILayoutOption>(out var _p1_UnityEngine_GUILayoutOptionArray))
                {
                    if (_argCount == 2)
                    {
                        var property = _p0_UnityEditor_SerializedProperty.Instance;
                        var options = _p1_UnityEngine_GUILayoutOptionArray;
                        global::UnityEditor.EditorGUILayout.DelayedFloatField(property, options);
                        var _retCount = _context.Return();
                        return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                    }
                }
                _lastArgPos = 1; _expectedType = typeof(global::UnityEngine.GUIContent);
                if (_arg1.TryRead<global::UnityEngine.GUIContent>(out var _p1_UnityEngine_GUIContent))
                {
                    var _arg2 = _lastArg = _argCount > 2 ? _context.GetArgument(2) : global::Lua.LuaValue.Nil;
                    _lastArgPos = 2; _expectedType = typeof(global::UnityEngine.GUILayoutOption[]);
                    if (_arg2.TryReadArray<global::UnityEngine.GUILayoutOption>(out var _p2_UnityEngine_GUILayoutOptionArray))
                    {
                        if (_argCount == 3)
                        {
                            var property = _p0_UnityEditor_SerializedProperty.Instance;
                            var label = _p1_UnityEngine_GUIContent;
                            var options = _p2_UnityEngine_GUILayoutOptionArray;
                            global::UnityEditor.EditorGUILayout.DelayedFloatField(property, label, options);
                            var _retCount = _context.Return();
                            return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                        }
                    }
                }
            }
            _lastArgPos = 0; _expectedType = typeof(global::System.String);
            if (_arg0.TryRead<global::System.String>(out var _p0_System_String))
            {
                var _arg1 = _lastArg = _argCount > 1 ? _context.GetArgument(1) : global::Lua.LuaValue.Nil;
                _lastArgPos = 1; _expectedType = typeof(global::System.Single);
                if (_arg1.TryRead<global::System.Single>(out var _p1_System_Single))
                {
                    var _arg2 = _lastArg = _argCount > 2 ? _context.GetArgument(2) : global::Lua.LuaValue.Nil;
                    _lastArgPos = 2; _expectedType = typeof(global::UnityEngine.GUILayoutOption[]);
                    if (_arg2.TryReadArray<global::UnityEngine.GUILayoutOption>(out var _p2_UnityEngine_GUILayoutOptionArray))
                    {
                        if (_argCount == 3)
                        {
                            var label = _p0_System_String;
                            var value = _p1_System_Single;
                            var options = _p2_UnityEngine_GUILayoutOptionArray;
                            var _ret0 = global::UnityEditor.EditorGUILayout.DelayedFloatField(label, value, options);
                            var _lret0 = new global::Lua.LuaValue(_ret0);
                            var _retCount = _context.Return(_lret0);
                            return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                        }
                    }
                    _lastArgPos = 2; _expectedType = typeof(global::UnityEngine.GUIStyle);
                    if (_arg2.TryRead<global::UnityEngine.GUIStyle>(out var _p2_UnityEngine_GUIStyle))
                    {
                        var _arg3 = _lastArg = _argCount > 3 ? _context.GetArgument(3) : global::Lua.LuaValue.Nil;
                        _lastArgPos = 3; _expectedType = typeof(global::UnityEngine.GUILayoutOption[]);
                        if (_arg3.TryReadArray<global::UnityEngine.GUILayoutOption>(out var _p3_UnityEngine_GUILayoutOptionArray))
                        {
                            if (_argCount == 4)
                            {
                                var label = _p0_System_String;
                                var value = _p1_System_Single;
                                var style = _p2_UnityEngine_GUIStyle;
                                var options = _p3_UnityEngine_GUILayoutOptionArray;
                                var _ret0 = global::UnityEditor.EditorGUILayout.DelayedFloatField(label, value, style, options);
                                var _lret0 = new global::Lua.LuaValue(_ret0);
                                var _retCount = _context.Return(_lret0);
                                return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                            }
                        }
                    }
                }
            }
            _lastArgPos = 0; _expectedType = typeof(global::UnityEngine.GUIContent);
            if (_arg0.TryRead<global::UnityEngine.GUIContent>(out var _p0_UnityEngine_GUIContent))
            {
                var _arg1 = _lastArg = _argCount > 1 ? _context.GetArgument(1) : global::Lua.LuaValue.Nil;
                _lastArgPos = 1; _expectedType = typeof(global::System.Single);
                if (_arg1.TryRead<global::System.Single>(out var _p1_System_Single))
                {
                    var _arg2 = _lastArg = _argCount > 2 ? _context.GetArgument(2) : global::Lua.LuaValue.Nil;
                    _lastArgPos = 2; _expectedType = typeof(global::UnityEngine.GUILayoutOption[]);
                    if (_arg2.TryReadArray<global::UnityEngine.GUILayoutOption>(out var _p2_UnityEngine_GUILayoutOptionArray))
                    {
                        if (_argCount == 3)
                        {
                            var label = _p0_UnityEngine_GUIContent;
                            var value = _p1_System_Single;
                            var options = _p2_UnityEngine_GUILayoutOptionArray;
                            var _ret0 = global::UnityEditor.EditorGUILayout.DelayedFloatField(label, value, options);
                            var _lret0 = new global::Lua.LuaValue(_ret0);
                            var _retCount = _context.Return(_lret0);
                            return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                        }
                    }
                    _lastArgPos = 2; _expectedType = typeof(global::UnityEngine.GUIStyle);
                    if (_arg2.TryRead<global::UnityEngine.GUIStyle>(out var _p2_UnityEngine_GUIStyle))
                    {
                        var _arg3 = _lastArg = _argCount > 3 ? _context.GetArgument(3) : global::Lua.LuaValue.Nil;
                        _lastArgPos = 3; _expectedType = typeof(global::UnityEngine.GUILayoutOption[]);
                        if (_arg3.TryReadArray<global::UnityEngine.GUILayoutOption>(out var _p3_UnityEngine_GUILayoutOptionArray))
                        {
                            if (_argCount == 4)
                            {
                                var label = _p0_UnityEngine_GUIContent;
                                var value = _p1_System_Single;
                                var style = _p2_UnityEngine_GUIStyle;
                                var options = _p3_UnityEngine_GUILayoutOptionArray;
                                var _ret0 = global::UnityEditor.EditorGUILayout.DelayedFloatField(label, value, style, options);
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
        private static readonly global::Lua.LuaFunction _LuaEditorGUILayout_DelayedIntField = new global::Lua.LuaFunction("DelayedIntField", (_context, _) =>
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
                _lastArgPos = 1; _expectedType = typeof(global::UnityEngine.GUILayoutOption[]);
                if (_arg1.TryReadArray<global::UnityEngine.GUILayoutOption>(out var _p1_UnityEngine_GUILayoutOptionArray))
                {
                    if (_argCount == 2)
                    {
                        var value = _p0_System_Int32;
                        var options = _p1_UnityEngine_GUILayoutOptionArray;
                        var _ret0 = global::UnityEditor.EditorGUILayout.DelayedIntField(value, options);
                        var _lret0 = new global::Lua.LuaValue(_ret0);
                        var _retCount = _context.Return(_lret0);
                        return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                    }
                }
                _lastArgPos = 1; _expectedType = typeof(global::UnityEngine.GUIStyle);
                if (_arg1.TryRead<global::UnityEngine.GUIStyle>(out var _p1_UnityEngine_GUIStyle))
                {
                    var _arg2 = _lastArg = _argCount > 2 ? _context.GetArgument(2) : global::Lua.LuaValue.Nil;
                    _lastArgPos = 2; _expectedType = typeof(global::UnityEngine.GUILayoutOption[]);
                    if (_arg2.TryReadArray<global::UnityEngine.GUILayoutOption>(out var _p2_UnityEngine_GUILayoutOptionArray))
                    {
                        if (_argCount == 3)
                        {
                            var value = _p0_System_Int32;
                            var style = _p1_UnityEngine_GUIStyle;
                            var options = _p2_UnityEngine_GUILayoutOptionArray;
                            var _ret0 = global::UnityEditor.EditorGUILayout.DelayedIntField(value, style, options);
                            var _lret0 = new global::Lua.LuaValue(_ret0);
                            var _retCount = _context.Return(_lret0);
                            return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                        }
                    }
                }
            }
            _lastArgPos = 0; _expectedType = typeof(global::Luny.UnityEditor.LuaSerializedProperty);
            if (_arg0.TryRead<global::Luny.UnityEditor.LuaSerializedProperty>(out var _p0_UnityEditor_SerializedProperty))
            {
                var _arg1 = _lastArg = _argCount > 1 ? _context.GetArgument(1) : global::Lua.LuaValue.Nil;
                _lastArgPos = 1; _expectedType = typeof(global::UnityEngine.GUILayoutOption[]);
                if (_arg1.TryReadArray<global::UnityEngine.GUILayoutOption>(out var _p1_UnityEngine_GUILayoutOptionArray))
                {
                    if (_argCount == 2)
                    {
                        var property = _p0_UnityEditor_SerializedProperty.Instance;
                        var options = _p1_UnityEngine_GUILayoutOptionArray;
                        global::UnityEditor.EditorGUILayout.DelayedIntField(property, options);
                        var _retCount = _context.Return();
                        return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                    }
                }
                _lastArgPos = 1; _expectedType = typeof(global::UnityEngine.GUIContent);
                if (_arg1.TryRead<global::UnityEngine.GUIContent>(out var _p1_UnityEngine_GUIContent))
                {
                    var _arg2 = _lastArg = _argCount > 2 ? _context.GetArgument(2) : global::Lua.LuaValue.Nil;
                    _lastArgPos = 2; _expectedType = typeof(global::UnityEngine.GUILayoutOption[]);
                    if (_arg2.TryReadArray<global::UnityEngine.GUILayoutOption>(out var _p2_UnityEngine_GUILayoutOptionArray))
                    {
                        if (_argCount == 3)
                        {
                            var property = _p0_UnityEditor_SerializedProperty.Instance;
                            var label = _p1_UnityEngine_GUIContent;
                            var options = _p2_UnityEngine_GUILayoutOptionArray;
                            global::UnityEditor.EditorGUILayout.DelayedIntField(property, label, options);
                            var _retCount = _context.Return();
                            return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                        }
                    }
                }
            }
            _lastArgPos = 0; _expectedType = typeof(global::System.String);
            if (_arg0.TryRead<global::System.String>(out var _p0_System_String))
            {
                var _arg1 = _lastArg = _argCount > 1 ? _context.GetArgument(1) : global::Lua.LuaValue.Nil;
                _lastArgPos = 1; _expectedType = typeof(global::System.Int32);
                if (_arg1.TryRead<global::System.Int32>(out var _p1_System_Int32))
                {
                    var _arg2 = _lastArg = _argCount > 2 ? _context.GetArgument(2) : global::Lua.LuaValue.Nil;
                    _lastArgPos = 2; _expectedType = typeof(global::UnityEngine.GUILayoutOption[]);
                    if (_arg2.TryReadArray<global::UnityEngine.GUILayoutOption>(out var _p2_UnityEngine_GUILayoutOptionArray))
                    {
                        if (_argCount == 3)
                        {
                            var label = _p0_System_String;
                            var value = _p1_System_Int32;
                            var options = _p2_UnityEngine_GUILayoutOptionArray;
                            var _ret0 = global::UnityEditor.EditorGUILayout.DelayedIntField(label, value, options);
                            var _lret0 = new global::Lua.LuaValue(_ret0);
                            var _retCount = _context.Return(_lret0);
                            return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                        }
                    }
                    _lastArgPos = 2; _expectedType = typeof(global::UnityEngine.GUIStyle);
                    if (_arg2.TryRead<global::UnityEngine.GUIStyle>(out var _p2_UnityEngine_GUIStyle))
                    {
                        var _arg3 = _lastArg = _argCount > 3 ? _context.GetArgument(3) : global::Lua.LuaValue.Nil;
                        _lastArgPos = 3; _expectedType = typeof(global::UnityEngine.GUILayoutOption[]);
                        if (_arg3.TryReadArray<global::UnityEngine.GUILayoutOption>(out var _p3_UnityEngine_GUILayoutOptionArray))
                        {
                            if (_argCount == 4)
                            {
                                var label = _p0_System_String;
                                var value = _p1_System_Int32;
                                var style = _p2_UnityEngine_GUIStyle;
                                var options = _p3_UnityEngine_GUILayoutOptionArray;
                                var _ret0 = global::UnityEditor.EditorGUILayout.DelayedIntField(label, value, style, options);
                                var _lret0 = new global::Lua.LuaValue(_ret0);
                                var _retCount = _context.Return(_lret0);
                                return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                            }
                        }
                    }
                }
            }
            _lastArgPos = 0; _expectedType = typeof(global::UnityEngine.GUIContent);
            if (_arg0.TryRead<global::UnityEngine.GUIContent>(out var _p0_UnityEngine_GUIContent))
            {
                var _arg1 = _lastArg = _argCount > 1 ? _context.GetArgument(1) : global::Lua.LuaValue.Nil;
                _lastArgPos = 1; _expectedType = typeof(global::System.Int32);
                if (_arg1.TryRead<global::System.Int32>(out var _p1_System_Int32))
                {
                    var _arg2 = _lastArg = _argCount > 2 ? _context.GetArgument(2) : global::Lua.LuaValue.Nil;
                    _lastArgPos = 2; _expectedType = typeof(global::UnityEngine.GUILayoutOption[]);
                    if (_arg2.TryReadArray<global::UnityEngine.GUILayoutOption>(out var _p2_UnityEngine_GUILayoutOptionArray))
                    {
                        if (_argCount == 3)
                        {
                            var label = _p0_UnityEngine_GUIContent;
                            var value = _p1_System_Int32;
                            var options = _p2_UnityEngine_GUILayoutOptionArray;
                            var _ret0 = global::UnityEditor.EditorGUILayout.DelayedIntField(label, value, options);
                            var _lret0 = new global::Lua.LuaValue(_ret0);
                            var _retCount = _context.Return(_lret0);
                            return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                        }
                    }
                    _lastArgPos = 2; _expectedType = typeof(global::UnityEngine.GUIStyle);
                    if (_arg2.TryRead<global::UnityEngine.GUIStyle>(out var _p2_UnityEngine_GUIStyle))
                    {
                        var _arg3 = _lastArg = _argCount > 3 ? _context.GetArgument(3) : global::Lua.LuaValue.Nil;
                        _lastArgPos = 3; _expectedType = typeof(global::UnityEngine.GUILayoutOption[]);
                        if (_arg3.TryReadArray<global::UnityEngine.GUILayoutOption>(out var _p3_UnityEngine_GUILayoutOptionArray))
                        {
                            if (_argCount == 4)
                            {
                                var label = _p0_UnityEngine_GUIContent;
                                var value = _p1_System_Int32;
                                var style = _p2_UnityEngine_GUIStyle;
                                var options = _p3_UnityEngine_GUILayoutOptionArray;
                                var _ret0 = global::UnityEditor.EditorGUILayout.DelayedIntField(label, value, style, options);
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
        private static readonly global::Lua.LuaFunction _LuaEditorGUILayout_DelayedTextField = new global::Lua.LuaFunction("DelayedTextField", (_context, _) =>
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
                _lastArgPos = 1; _expectedType = typeof(global::UnityEngine.GUILayoutOption[]);
                if (_arg1.TryReadArray<global::UnityEngine.GUILayoutOption>(out var _p1_UnityEngine_GUILayoutOptionArray))
                {
                    if (_argCount == 2)
                    {
                        var text = _p0_System_String;
                        var options = _p1_UnityEngine_GUILayoutOptionArray;
                        var _ret0 = global::UnityEditor.EditorGUILayout.DelayedTextField(text, options);
                        var _lret0 = new global::Lua.LuaValue(_ret0);
                        var _retCount = _context.Return(_lret0);
                        return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                    }
                }
                _lastArgPos = 1; _expectedType = typeof(global::System.String);
                if (_arg1.TryRead<global::System.String>(out var _p1_System_String))
                {
                    var _arg2 = _lastArg = _argCount > 2 ? _context.GetArgument(2) : global::Lua.LuaValue.Nil;
                    _lastArgPos = 2; _expectedType = typeof(global::UnityEngine.GUILayoutOption[]);
                    if (_arg2.TryReadArray<global::UnityEngine.GUILayoutOption>(out var _p2_UnityEngine_GUILayoutOptionArray))
                    {
                        if (_argCount == 3)
                        {
                            var label = _p0_System_String;
                            var text = _p1_System_String;
                            var options = _p2_UnityEngine_GUILayoutOptionArray;
                            var _ret0 = global::UnityEditor.EditorGUILayout.DelayedTextField(label, text, options);
                            var _lret0 = new global::Lua.LuaValue(_ret0);
                            var _retCount = _context.Return(_lret0);
                            return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                        }
                    }
                    _lastArgPos = 2; _expectedType = typeof(global::UnityEngine.GUIStyle);
                    if (_arg2.TryRead<global::UnityEngine.GUIStyle>(out var _p2_UnityEngine_GUIStyle))
                    {
                        var _arg3 = _lastArg = _argCount > 3 ? _context.GetArgument(3) : global::Lua.LuaValue.Nil;
                        _lastArgPos = 3; _expectedType = typeof(global::UnityEngine.GUILayoutOption[]);
                        if (_arg3.TryReadArray<global::UnityEngine.GUILayoutOption>(out var _p3_UnityEngine_GUILayoutOptionArray))
                        {
                            if (_argCount == 4)
                            {
                                var label = _p0_System_String;
                                var text = _p1_System_String;
                                var style = _p2_UnityEngine_GUIStyle;
                                var options = _p3_UnityEngine_GUILayoutOptionArray;
                                var _ret0 = global::UnityEditor.EditorGUILayout.DelayedTextField(label, text, style, options);
                                var _lret0 = new global::Lua.LuaValue(_ret0);
                                var _retCount = _context.Return(_lret0);
                                return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                            }
                        }
                    }
                }
                _lastArgPos = 1; _expectedType = typeof(global::UnityEngine.GUIStyle);
                if (_arg1.TryRead<global::UnityEngine.GUIStyle>(out var _p1_UnityEngine_GUIStyle))
                {
                    var _arg2 = _lastArg = _argCount > 2 ? _context.GetArgument(2) : global::Lua.LuaValue.Nil;
                    _lastArgPos = 2; _expectedType = typeof(global::UnityEngine.GUILayoutOption[]);
                    if (_arg2.TryReadArray<global::UnityEngine.GUILayoutOption>(out var _p2_UnityEngine_GUILayoutOptionArray))
                    {
                        if (_argCount == 3)
                        {
                            var text = _p0_System_String;
                            var style = _p1_UnityEngine_GUIStyle;
                            var options = _p2_UnityEngine_GUILayoutOptionArray;
                            var _ret0 = global::UnityEditor.EditorGUILayout.DelayedTextField(text, style, options);
                            var _lret0 = new global::Lua.LuaValue(_ret0);
                            var _retCount = _context.Return(_lret0);
                            return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                        }
                    }
                }
            }
            _lastArgPos = 0; _expectedType = typeof(global::Luny.UnityEditor.LuaSerializedProperty);
            if (_arg0.TryRead<global::Luny.UnityEditor.LuaSerializedProperty>(out var _p0_UnityEditor_SerializedProperty))
            {
                var _arg1 = _lastArg = _argCount > 1 ? _context.GetArgument(1) : global::Lua.LuaValue.Nil;
                _lastArgPos = 1; _expectedType = typeof(global::UnityEngine.GUILayoutOption[]);
                if (_arg1.TryReadArray<global::UnityEngine.GUILayoutOption>(out var _p1_UnityEngine_GUILayoutOptionArray))
                {
                    if (_argCount == 2)
                    {
                        var property = _p0_UnityEditor_SerializedProperty.Instance;
                        var options = _p1_UnityEngine_GUILayoutOptionArray;
                        global::UnityEditor.EditorGUILayout.DelayedTextField(property, options);
                        var _retCount = _context.Return();
                        return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                    }
                }
                _lastArgPos = 1; _expectedType = typeof(global::UnityEngine.GUIContent);
                if (_arg1.TryRead<global::UnityEngine.GUIContent>(out var _p1_UnityEngine_GUIContent))
                {
                    var _arg2 = _lastArg = _argCount > 2 ? _context.GetArgument(2) : global::Lua.LuaValue.Nil;
                    _lastArgPos = 2; _expectedType = typeof(global::UnityEngine.GUILayoutOption[]);
                    if (_arg2.TryReadArray<global::UnityEngine.GUILayoutOption>(out var _p2_UnityEngine_GUILayoutOptionArray))
                    {
                        if (_argCount == 3)
                        {
                            var property = _p0_UnityEditor_SerializedProperty.Instance;
                            var label = _p1_UnityEngine_GUIContent;
                            var options = _p2_UnityEngine_GUILayoutOptionArray;
                            global::UnityEditor.EditorGUILayout.DelayedTextField(property, label, options);
                            var _retCount = _context.Return();
                            return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                        }
                    }
                }
            }
            _lastArgPos = 0; _expectedType = typeof(global::UnityEngine.GUIContent);
            if (_arg0.TryRead<global::UnityEngine.GUIContent>(out var _p0_UnityEngine_GUIContent))
            {
                var _arg1 = _lastArg = _argCount > 1 ? _context.GetArgument(1) : global::Lua.LuaValue.Nil;
                _lastArgPos = 1; _expectedType = typeof(global::System.String);
                if (_arg1.TryRead<global::System.String>(out var _p1_System_String))
                {
                    var _arg2 = _lastArg = _argCount > 2 ? _context.GetArgument(2) : global::Lua.LuaValue.Nil;
                    _lastArgPos = 2; _expectedType = typeof(global::UnityEngine.GUILayoutOption[]);
                    if (_arg2.TryReadArray<global::UnityEngine.GUILayoutOption>(out var _p2_UnityEngine_GUILayoutOptionArray))
                    {
                        if (_argCount == 3)
                        {
                            var label = _p0_UnityEngine_GUIContent;
                            var text = _p1_System_String;
                            var options = _p2_UnityEngine_GUILayoutOptionArray;
                            var _ret0 = global::UnityEditor.EditorGUILayout.DelayedTextField(label, text, options);
                            var _lret0 = new global::Lua.LuaValue(_ret0);
                            var _retCount = _context.Return(_lret0);
                            return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                        }
                    }
                    _lastArgPos = 2; _expectedType = typeof(global::UnityEngine.GUIStyle);
                    if (_arg2.TryRead<global::UnityEngine.GUIStyle>(out var _p2_UnityEngine_GUIStyle))
                    {
                        var _arg3 = _lastArg = _argCount > 3 ? _context.GetArgument(3) : global::Lua.LuaValue.Nil;
                        _lastArgPos = 3; _expectedType = typeof(global::UnityEngine.GUILayoutOption[]);
                        if (_arg3.TryReadArray<global::UnityEngine.GUILayoutOption>(out var _p3_UnityEngine_GUILayoutOptionArray))
                        {
                            if (_argCount == 4)
                            {
                                var label = _p0_UnityEngine_GUIContent;
                                var text = _p1_System_String;
                                var style = _p2_UnityEngine_GUIStyle;
                                var options = _p3_UnityEngine_GUILayoutOptionArray;
                                var _ret0 = global::UnityEditor.EditorGUILayout.DelayedTextField(label, text, style, options);
                                var _lret0 = new global::Lua.LuaValue(_ret0);
                                var _retCount = _context.Return(_lret0);
                                return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                            }
                        }
                    }
                }
            }
            throw new global::Lua.LuaRuntimeException(_context.Thread, $"{"DelayedTextField"}: invalid argument #{_lastArgPos}: {_lastArg} ({_lastArg.Type}), expected: {_expectedType.FullName}", 2);
        });
        private static readonly global::Lua.LuaFunction _LuaEditorGUILayout_DoubleField = new global::Lua.LuaFunction("DoubleField", (_context, _) =>
        {
            global::Lua.LuaValue _lastArg = default;
            global::System.Int32 _lastArgPos = default;
            global::System.Type _expectedType = default;
            var _argCount = _context.ArgumentCount;
            var _arg0 = _lastArg = _argCount > 0 ? _context.GetArgument(0) : global::Lua.LuaValue.Nil;
            _lastArgPos = 0; _expectedType = typeof(global::System.Double);
            if (_arg0.TryRead<global::System.Double>(out var _p0_System_Double))
            {
                var _arg1 = _lastArg = _argCount > 1 ? _context.GetArgument(1) : global::Lua.LuaValue.Nil;
                _lastArgPos = 1; _expectedType = typeof(global::UnityEngine.GUILayoutOption[]);
                if (_arg1.TryReadArray<global::UnityEngine.GUILayoutOption>(out var _p1_UnityEngine_GUILayoutOptionArray))
                {
                    if (_argCount == 2)
                    {
                        var value = _p0_System_Double;
                        var options = _p1_UnityEngine_GUILayoutOptionArray;
                        var _ret0 = global::UnityEditor.EditorGUILayout.DoubleField(value, options);
                        var _lret0 = new global::Lua.LuaValue(_ret0);
                        var _retCount = _context.Return(_lret0);
                        return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                    }
                }
                _lastArgPos = 1; _expectedType = typeof(global::UnityEngine.GUIStyle);
                if (_arg1.TryRead<global::UnityEngine.GUIStyle>(out var _p1_UnityEngine_GUIStyle))
                {
                    var _arg2 = _lastArg = _argCount > 2 ? _context.GetArgument(2) : global::Lua.LuaValue.Nil;
                    _lastArgPos = 2; _expectedType = typeof(global::UnityEngine.GUILayoutOption[]);
                    if (_arg2.TryReadArray<global::UnityEngine.GUILayoutOption>(out var _p2_UnityEngine_GUILayoutOptionArray))
                    {
                        if (_argCount == 3)
                        {
                            var value = _p0_System_Double;
                            var style = _p1_UnityEngine_GUIStyle;
                            var options = _p2_UnityEngine_GUILayoutOptionArray;
                            var _ret0 = global::UnityEditor.EditorGUILayout.DoubleField(value, style, options);
                            var _lret0 = new global::Lua.LuaValue(_ret0);
                            var _retCount = _context.Return(_lret0);
                            return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                        }
                    }
                }
            }
            _lastArgPos = 0; _expectedType = typeof(global::System.String);
            if (_arg0.TryRead<global::System.String>(out var _p0_System_String))
            {
                var _arg1 = _lastArg = _argCount > 1 ? _context.GetArgument(1) : global::Lua.LuaValue.Nil;
                _lastArgPos = 1; _expectedType = typeof(global::System.Double);
                if (_arg1.TryRead<global::System.Double>(out var _p1_System_Double))
                {
                    var _arg2 = _lastArg = _argCount > 2 ? _context.GetArgument(2) : global::Lua.LuaValue.Nil;
                    _lastArgPos = 2; _expectedType = typeof(global::UnityEngine.GUILayoutOption[]);
                    if (_arg2.TryReadArray<global::UnityEngine.GUILayoutOption>(out var _p2_UnityEngine_GUILayoutOptionArray))
                    {
                        if (_argCount == 3)
                        {
                            var label = _p0_System_String;
                            var value = _p1_System_Double;
                            var options = _p2_UnityEngine_GUILayoutOptionArray;
                            var _ret0 = global::UnityEditor.EditorGUILayout.DoubleField(label, value, options);
                            var _lret0 = new global::Lua.LuaValue(_ret0);
                            var _retCount = _context.Return(_lret0);
                            return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                        }
                    }
                    _lastArgPos = 2; _expectedType = typeof(global::UnityEngine.GUIStyle);
                    if (_arg2.TryRead<global::UnityEngine.GUIStyle>(out var _p2_UnityEngine_GUIStyle))
                    {
                        var _arg3 = _lastArg = _argCount > 3 ? _context.GetArgument(3) : global::Lua.LuaValue.Nil;
                        _lastArgPos = 3; _expectedType = typeof(global::UnityEngine.GUILayoutOption[]);
                        if (_arg3.TryReadArray<global::UnityEngine.GUILayoutOption>(out var _p3_UnityEngine_GUILayoutOptionArray))
                        {
                            if (_argCount == 4)
                            {
                                var label = _p0_System_String;
                                var value = _p1_System_Double;
                                var style = _p2_UnityEngine_GUIStyle;
                                var options = _p3_UnityEngine_GUILayoutOptionArray;
                                var _ret0 = global::UnityEditor.EditorGUILayout.DoubleField(label, value, style, options);
                                var _lret0 = new global::Lua.LuaValue(_ret0);
                                var _retCount = _context.Return(_lret0);
                                return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                            }
                        }
                    }
                }
            }
            _lastArgPos = 0; _expectedType = typeof(global::UnityEngine.GUIContent);
            if (_arg0.TryRead<global::UnityEngine.GUIContent>(out var _p0_UnityEngine_GUIContent))
            {
                var _arg1 = _lastArg = _argCount > 1 ? _context.GetArgument(1) : global::Lua.LuaValue.Nil;
                _lastArgPos = 1; _expectedType = typeof(global::System.Double);
                if (_arg1.TryRead<global::System.Double>(out var _p1_System_Double))
                {
                    var _arg2 = _lastArg = _argCount > 2 ? _context.GetArgument(2) : global::Lua.LuaValue.Nil;
                    _lastArgPos = 2; _expectedType = typeof(global::UnityEngine.GUILayoutOption[]);
                    if (_arg2.TryReadArray<global::UnityEngine.GUILayoutOption>(out var _p2_UnityEngine_GUILayoutOptionArray))
                    {
                        if (_argCount == 3)
                        {
                            var label = _p0_UnityEngine_GUIContent;
                            var value = _p1_System_Double;
                            var options = _p2_UnityEngine_GUILayoutOptionArray;
                            var _ret0 = global::UnityEditor.EditorGUILayout.DoubleField(label, value, options);
                            var _lret0 = new global::Lua.LuaValue(_ret0);
                            var _retCount = _context.Return(_lret0);
                            return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                        }
                    }
                    _lastArgPos = 2; _expectedType = typeof(global::UnityEngine.GUIStyle);
                    if (_arg2.TryRead<global::UnityEngine.GUIStyle>(out var _p2_UnityEngine_GUIStyle))
                    {
                        var _arg3 = _lastArg = _argCount > 3 ? _context.GetArgument(3) : global::Lua.LuaValue.Nil;
                        _lastArgPos = 3; _expectedType = typeof(global::UnityEngine.GUILayoutOption[]);
                        if (_arg3.TryReadArray<global::UnityEngine.GUILayoutOption>(out var _p3_UnityEngine_GUILayoutOptionArray))
                        {
                            if (_argCount == 4)
                            {
                                var label = _p0_UnityEngine_GUIContent;
                                var value = _p1_System_Double;
                                var style = _p2_UnityEngine_GUIStyle;
                                var options = _p3_UnityEngine_GUILayoutOptionArray;
                                var _ret0 = global::UnityEditor.EditorGUILayout.DoubleField(label, value, style, options);
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
        private static readonly global::Lua.LuaFunction _LuaEditorGUILayout_DropdownButton = new global::Lua.LuaFunction("DropdownButton", (_context, _) =>
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
                _lastArgPos = 1; _expectedType = typeof(global::UnityEngine.FocusType);
                if (_arg1.TryRead<global::UnityEngine.FocusType>(out var _p1_UnityEngine_FocusType))
                {
                    var _arg2 = _lastArg = _argCount > 2 ? _context.GetArgument(2) : global::Lua.LuaValue.Nil;
                    _lastArgPos = 2; _expectedType = typeof(global::UnityEngine.GUILayoutOption[]);
                    if (_arg2.TryReadArray<global::UnityEngine.GUILayoutOption>(out var _p2_UnityEngine_GUILayoutOptionArray))
                    {
                        if (_argCount == 3)
                        {
                            var content = _p0_UnityEngine_GUIContent;
                            var focusType = _p1_UnityEngine_FocusType;
                            var options = _p2_UnityEngine_GUILayoutOptionArray;
                            var _ret0 = global::UnityEditor.EditorGUILayout.DropdownButton(content, focusType, options);
                            var _lret0 = new global::Lua.LuaValue(_ret0);
                            var _retCount = _context.Return(_lret0);
                            return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                        }
                    }
                    _lastArgPos = 2; _expectedType = typeof(global::UnityEngine.GUIStyle);
                    if (_arg2.TryRead<global::UnityEngine.GUIStyle>(out var _p2_UnityEngine_GUIStyle))
                    {
                        var _arg3 = _lastArg = _argCount > 3 ? _context.GetArgument(3) : global::Lua.LuaValue.Nil;
                        _lastArgPos = 3; _expectedType = typeof(global::UnityEngine.GUILayoutOption[]);
                        if (_arg3.TryReadArray<global::UnityEngine.GUILayoutOption>(out var _p3_UnityEngine_GUILayoutOptionArray))
                        {
                            if (_argCount == 4)
                            {
                                var content = _p0_UnityEngine_GUIContent;
                                var focusType = _p1_UnityEngine_FocusType;
                                var style = _p2_UnityEngine_GUIStyle;
                                var options = _p3_UnityEngine_GUILayoutOptionArray;
                                var _ret0 = global::UnityEditor.EditorGUILayout.DropdownButton(content, focusType, style, options);
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
        private static readonly global::Lua.LuaFunction _LuaEditorGUILayout_EditorToolbar = new global::Lua.LuaFunction("EditorToolbar", (_context, _) =>
        {
            global::Lua.LuaValue _lastArg = default;
            global::System.Int32 _lastArgPos = default;
            global::System.Type _expectedType = default;
            var _argCount = _context.ArgumentCount;
            var _arg0 = _lastArg = _argCount > 0 ? _context.GetArgument(0) : global::Lua.LuaValue.Nil;
            _lastArgPos = 0; _expectedType = typeof(global::UnityEditor.EditorTools.EditorTool[]);
            if (_arg0.TryReadArray<global::UnityEditor.EditorTools.EditorTool>(out var _p0_UnityEditor_EditorTools_EditorToolArray))
            {
                if (_argCount == 1)
                {
                    var tools = _p0_UnityEditor_EditorTools_EditorToolArray;
                    global::UnityEditor.EditorGUILayout.EditorToolbar(tools);
                    var _retCount = _context.Return();
                    return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                }
            }
            throw new global::Lua.LuaRuntimeException(_context.Thread, $"{"EditorToolbar"}: invalid argument #{_lastArgPos}: {_lastArg} ({_lastArg.Type}), expected: {_expectedType.FullName}", 2);
        });
        private static readonly global::Lua.LuaFunction _LuaEditorGUILayout_EditorToolbarForTarget = new global::Lua.LuaFunction("EditorToolbarForTarget", (_context, _) =>
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
                    var target = _p0_UnityEngine_Object;
                    global::UnityEditor.EditorGUILayout.EditorToolbarForTarget(target);
                    var _retCount = _context.Return();
                    return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                }
            }
            _lastArgPos = 0; _expectedType = typeof(global::UnityEngine.GUIContent);
            if (_arg0.TryRead<global::UnityEngine.GUIContent>(out var _p0_UnityEngine_GUIContent))
            {
                var _arg1 = _lastArg = _argCount > 1 ? _context.GetArgument(1) : global::Lua.LuaValue.Nil;
                _lastArgPos = 1; _expectedType = typeof(global::UnityEngine.Object);
                if (_arg1.TryRead<global::UnityEngine.Object>(out var _p1_UnityEngine_Object))
                {
                    if (_argCount == 2)
                    {
                        var content = _p0_UnityEngine_GUIContent;
                        var target = _p1_UnityEngine_Object;
                        global::UnityEditor.EditorGUILayout.EditorToolbarForTarget(content, target);
                        var _retCount = _context.Return();
                        return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                    }
                }
            }
            throw new global::Lua.LuaRuntimeException(_context.Thread, $"{"EditorToolbarForTarget"}: invalid argument #{_lastArgPos}: {_lastArg} ({_lastArg.Type}), expected: {_expectedType.FullName}", 2);
        });
        private static readonly global::Lua.LuaFunction _LuaEditorGUILayout_EndBuildTargetSelectionGrouping = new global::Lua.LuaFunction("EndBuildTargetSelectionGrouping", (_context, _) =>
        {
            global::Lua.LuaValue _lastArg = default;
            global::System.Int32 _lastArgPos = default;
            global::System.Type _expectedType = default;
            var _argCount = _context.ArgumentCount;
            if (_argCount == 0)
            {
                global::UnityEditor.EditorGUILayout.EndBuildTargetSelectionGrouping();
                var _retCount = _context.Return();
                return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
            }
            throw new global::Lua.LuaRuntimeException(_context.Thread, $"{"EndBuildTargetSelectionGrouping"}: invalid argument #{_lastArgPos}: {_lastArg} ({_lastArg.Type}), expected: {_expectedType.FullName}", 2);
        });
        private static readonly global::Lua.LuaFunction _LuaEditorGUILayout_EndFadeGroup = new global::Lua.LuaFunction("EndFadeGroup", (_context, _) =>
        {
            global::Lua.LuaValue _lastArg = default;
            global::System.Int32 _lastArgPos = default;
            global::System.Type _expectedType = default;
            var _argCount = _context.ArgumentCount;
            if (_argCount == 0)
            {
                global::UnityEditor.EditorGUILayout.EndFadeGroup();
                var _retCount = _context.Return();
                return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
            }
            throw new global::Lua.LuaRuntimeException(_context.Thread, $"{"EndFadeGroup"}: invalid argument #{_lastArgPos}: {_lastArg} ({_lastArg.Type}), expected: {_expectedType.FullName}", 2);
        });
        private static readonly global::Lua.LuaFunction _LuaEditorGUILayout_EndFoldoutHeaderGroup = new global::Lua.LuaFunction("EndFoldoutHeaderGroup", (_context, _) =>
        {
            global::Lua.LuaValue _lastArg = default;
            global::System.Int32 _lastArgPos = default;
            global::System.Type _expectedType = default;
            var _argCount = _context.ArgumentCount;
            if (_argCount == 0)
            {
                global::UnityEditor.EditorGUILayout.EndFoldoutHeaderGroup();
                var _retCount = _context.Return();
                return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
            }
            throw new global::Lua.LuaRuntimeException(_context.Thread, $"{"EndFoldoutHeaderGroup"}: invalid argument #{_lastArgPos}: {_lastArg} ({_lastArg.Type}), expected: {_expectedType.FullName}", 2);
        });
        private static readonly global::Lua.LuaFunction _LuaEditorGUILayout_EndHorizontal = new global::Lua.LuaFunction("EndHorizontal", (_context, _) =>
        {
            global::Lua.LuaValue _lastArg = default;
            global::System.Int32 _lastArgPos = default;
            global::System.Type _expectedType = default;
            var _argCount = _context.ArgumentCount;
            if (_argCount == 0)
            {
                global::UnityEditor.EditorGUILayout.EndHorizontal();
                var _retCount = _context.Return();
                return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
            }
            throw new global::Lua.LuaRuntimeException(_context.Thread, $"{"EndHorizontal"}: invalid argument #{_lastArgPos}: {_lastArg} ({_lastArg.Type}), expected: {_expectedType.FullName}", 2);
        });
        private static readonly global::Lua.LuaFunction _LuaEditorGUILayout_EndScrollView = new global::Lua.LuaFunction("EndScrollView", (_context, _) =>
        {
            global::Lua.LuaValue _lastArg = default;
            global::System.Int32 _lastArgPos = default;
            global::System.Type _expectedType = default;
            var _argCount = _context.ArgumentCount;
            if (_argCount == 0)
            {
                global::UnityEditor.EditorGUILayout.EndScrollView();
                var _retCount = _context.Return();
                return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
            }
            throw new global::Lua.LuaRuntimeException(_context.Thread, $"{"EndScrollView"}: invalid argument #{_lastArgPos}: {_lastArg} ({_lastArg.Type}), expected: {_expectedType.FullName}", 2);
        });
        private static readonly global::Lua.LuaFunction _LuaEditorGUILayout_EndToggleGroup = new global::Lua.LuaFunction("EndToggleGroup", (_context, _) =>
        {
            global::Lua.LuaValue _lastArg = default;
            global::System.Int32 _lastArgPos = default;
            global::System.Type _expectedType = default;
            var _argCount = _context.ArgumentCount;
            if (_argCount == 0)
            {
                global::UnityEditor.EditorGUILayout.EndToggleGroup();
                var _retCount = _context.Return();
                return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
            }
            throw new global::Lua.LuaRuntimeException(_context.Thread, $"{"EndToggleGroup"}: invalid argument #{_lastArgPos}: {_lastArg} ({_lastArg.Type}), expected: {_expectedType.FullName}", 2);
        });
        private static readonly global::Lua.LuaFunction _LuaEditorGUILayout_EndVertical = new global::Lua.LuaFunction("EndVertical", (_context, _) =>
        {
            global::Lua.LuaValue _lastArg = default;
            global::System.Int32 _lastArgPos = default;
            global::System.Type _expectedType = default;
            var _argCount = _context.ArgumentCount;
            if (_argCount == 0)
            {
                global::UnityEditor.EditorGUILayout.EndVertical();
                var _retCount = _context.Return();
                return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
            }
            throw new global::Lua.LuaRuntimeException(_context.Thread, $"{"EndVertical"}: invalid argument #{_lastArgPos}: {_lastArg} ({_lastArg.Type}), expected: {_expectedType.FullName}", 2);
        });
        private static readonly global::Lua.LuaFunction _LuaEditorGUILayout_EnumFlagsField = new global::Lua.LuaFunction("EnumFlagsField", (_context, _) =>
        {
            global::Lua.LuaValue _lastArg = default;
            global::System.Int32 _lastArgPos = default;
            global::System.Type _expectedType = default;
            var _argCount = _context.ArgumentCount;
            var _arg0 = _lastArg = _argCount > 0 ? _context.GetArgument(0) : global::Lua.LuaValue.Nil;
            _lastArgPos = 0; _expectedType = typeof(global::System.Enum);
            if (_arg0.TryRead<global::System.Enum>(out var _p0_System_Enum))
            {
                var _arg1 = _lastArg = _argCount > 1 ? _context.GetArgument(1) : global::Lua.LuaValue.Nil;
                _lastArgPos = 1; _expectedType = typeof(global::UnityEngine.GUILayoutOption[]);
                if (_arg1.TryReadArray<global::UnityEngine.GUILayoutOption>(out var _p1_UnityEngine_GUILayoutOptionArray))
                {
                    if (_argCount == 2)
                    {
                        var enumValue = _p0_System_Enum;
                        var options = _p1_UnityEngine_GUILayoutOptionArray;
                        var _ret0 = global::UnityEditor.EditorGUILayout.EnumFlagsField(enumValue, options);
                        var _factory = _context.GetObjectFactory();
                        var _lret0 = _factory.Bind(_ret0);
                        var _retCount = _context.Return(_lret0);
                        return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                    }
                }
                _lastArgPos = 1; _expectedType = typeof(global::UnityEngine.GUIStyle);
                if (_arg1.TryRead<global::UnityEngine.GUIStyle>(out var _p1_UnityEngine_GUIStyle))
                {
                    var _arg2 = _lastArg = _argCount > 2 ? _context.GetArgument(2) : global::Lua.LuaValue.Nil;
                    _lastArgPos = 2; _expectedType = typeof(global::UnityEngine.GUILayoutOption[]);
                    if (_arg2.TryReadArray<global::UnityEngine.GUILayoutOption>(out var _p2_UnityEngine_GUILayoutOptionArray))
                    {
                        if (_argCount == 3)
                        {
                            var enumValue = _p0_System_Enum;
                            var style = _p1_UnityEngine_GUIStyle;
                            var options = _p2_UnityEngine_GUILayoutOptionArray;
                            var _ret0 = global::UnityEditor.EditorGUILayout.EnumFlagsField(enumValue, style, options);
                            var _factory = _context.GetObjectFactory();
                            var _lret0 = _factory.Bind(_ret0);
                            var _retCount = _context.Return(_lret0);
                            return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                        }
                    }
                }
            }
            _lastArgPos = 0; _expectedType = typeof(global::System.String);
            if (_arg0.TryRead<global::System.String>(out var _p0_System_String))
            {
                var _arg1 = _lastArg = _argCount > 1 ? _context.GetArgument(1) : global::Lua.LuaValue.Nil;
                _lastArgPos = 1; _expectedType = typeof(global::System.Enum);
                if (_arg1.TryRead<global::System.Enum>(out var _p1_System_Enum))
                {
                    var _arg2 = _lastArg = _argCount > 2 ? _context.GetArgument(2) : global::Lua.LuaValue.Nil;
                    _lastArgPos = 2; _expectedType = typeof(global::UnityEngine.GUILayoutOption[]);
                    if (_arg2.TryReadArray<global::UnityEngine.GUILayoutOption>(out var _p2_UnityEngine_GUILayoutOptionArray))
                    {
                        if (_argCount == 3)
                        {
                            var label = _p0_System_String;
                            var enumValue = _p1_System_Enum;
                            var options = _p2_UnityEngine_GUILayoutOptionArray;
                            var _ret0 = global::UnityEditor.EditorGUILayout.EnumFlagsField(label, enumValue, options);
                            var _factory = _context.GetObjectFactory();
                            var _lret0 = _factory.Bind(_ret0);
                            var _retCount = _context.Return(_lret0);
                            return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                        }
                    }
                    _lastArgPos = 2; _expectedType = typeof(global::UnityEngine.GUIStyle);
                    if (_arg2.TryRead<global::UnityEngine.GUIStyle>(out var _p2_UnityEngine_GUIStyle))
                    {
                        var _arg3 = _lastArg = _argCount > 3 ? _context.GetArgument(3) : global::Lua.LuaValue.Nil;
                        _lastArgPos = 3; _expectedType = typeof(global::UnityEngine.GUILayoutOption[]);
                        if (_arg3.TryReadArray<global::UnityEngine.GUILayoutOption>(out var _p3_UnityEngine_GUILayoutOptionArray))
                        {
                            if (_argCount == 4)
                            {
                                var label = _p0_System_String;
                                var enumValue = _p1_System_Enum;
                                var style = _p2_UnityEngine_GUIStyle;
                                var options = _p3_UnityEngine_GUILayoutOptionArray;
                                var _ret0 = global::UnityEditor.EditorGUILayout.EnumFlagsField(label, enumValue, style, options);
                                var _factory = _context.GetObjectFactory();
                                var _lret0 = _factory.Bind(_ret0);
                                var _retCount = _context.Return(_lret0);
                                return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                            }
                        }
                    }
                }
            }
            _lastArgPos = 0; _expectedType = typeof(global::UnityEngine.GUIContent);
            if (_arg0.TryRead<global::UnityEngine.GUIContent>(out var _p0_UnityEngine_GUIContent))
            {
                var _arg1 = _lastArg = _argCount > 1 ? _context.GetArgument(1) : global::Lua.LuaValue.Nil;
                _lastArgPos = 1; _expectedType = typeof(global::System.Enum);
                if (_arg1.TryRead<global::System.Enum>(out var _p1_System_Enum))
                {
                    var _arg2 = _lastArg = _argCount > 2 ? _context.GetArgument(2) : global::Lua.LuaValue.Nil;
                    _lastArgPos = 2; _expectedType = typeof(global::UnityEngine.GUILayoutOption[]);
                    if (_arg2.TryReadArray<global::UnityEngine.GUILayoutOption>(out var _p2_UnityEngine_GUILayoutOptionArray))
                    {
                        if (_argCount == 3)
                        {
                            var label = _p0_UnityEngine_GUIContent;
                            var enumValue = _p1_System_Enum;
                            var options = _p2_UnityEngine_GUILayoutOptionArray;
                            var _ret0 = global::UnityEditor.EditorGUILayout.EnumFlagsField(label, enumValue, options);
                            var _factory = _context.GetObjectFactory();
                            var _lret0 = _factory.Bind(_ret0);
                            var _retCount = _context.Return(_lret0);
                            return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                        }
                    }
                    _lastArgPos = 2; _expectedType = typeof(global::UnityEngine.GUIStyle);
                    if (_arg2.TryRead<global::UnityEngine.GUIStyle>(out var _p2_UnityEngine_GUIStyle))
                    {
                        var _arg3 = _lastArg = _argCount > 3 ? _context.GetArgument(3) : global::Lua.LuaValue.Nil;
                        _lastArgPos = 3; _expectedType = typeof(global::UnityEngine.GUILayoutOption[]);
                        if (_arg3.TryReadArray<global::UnityEngine.GUILayoutOption>(out var _p3_UnityEngine_GUILayoutOptionArray))
                        {
                            if (_argCount == 4)
                            {
                                var label = _p0_UnityEngine_GUIContent;
                                var enumValue = _p1_System_Enum;
                                var style = _p2_UnityEngine_GUIStyle;
                                var options = _p3_UnityEngine_GUILayoutOptionArray;
                                var _ret0 = global::UnityEditor.EditorGUILayout.EnumFlagsField(label, enumValue, style, options);
                                var _factory = _context.GetObjectFactory();
                                var _lret0 = _factory.Bind(_ret0);
                                var _retCount = _context.Return(_lret0);
                                return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                            }
                        }
                    }
                    _lastArgPos = 2; _expectedType = typeof(global::System.Boolean);
                    if (_arg2.TryRead<global::System.Boolean>(out var _p2_System_Boolean))
                    {
                        var _arg3 = _lastArg = _argCount > 3 ? _context.GetArgument(3) : global::Lua.LuaValue.Nil;
                        _lastArgPos = 3; _expectedType = typeof(global::UnityEngine.GUILayoutOption[]);
                        if (_arg3.TryReadArray<global::UnityEngine.GUILayoutOption>(out var _p3_UnityEngine_GUILayoutOptionArray))
                        {
                            if (_argCount == 4)
                            {
                                var label = _p0_UnityEngine_GUIContent;
                                var enumValue = _p1_System_Enum;
                                var includeObsolete = _p2_System_Boolean;
                                var options = _p3_UnityEngine_GUILayoutOptionArray;
                                var _ret0 = global::UnityEditor.EditorGUILayout.EnumFlagsField(label, enumValue, includeObsolete, options);
                                var _factory = _context.GetObjectFactory();
                                var _lret0 = _factory.Bind(_ret0);
                                var _retCount = _context.Return(_lret0);
                                return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                            }
                        }
                        _lastArgPos = 3; _expectedType = typeof(global::UnityEngine.GUIStyle);
                        if (_arg3.TryRead<global::UnityEngine.GUIStyle>(out var _p3_UnityEngine_GUIStyle))
                        {
                            var _arg4 = _lastArg = _argCount > 4 ? _context.GetArgument(4) : global::Lua.LuaValue.Nil;
                            _lastArgPos = 4; _expectedType = typeof(global::UnityEngine.GUILayoutOption[]);
                            if (_arg4.TryReadArray<global::UnityEngine.GUILayoutOption>(out var _p4_UnityEngine_GUILayoutOptionArray))
                            {
                                if (_argCount == 5)
                                {
                                    var label = _p0_UnityEngine_GUIContent;
                                    var enumValue = _p1_System_Enum;
                                    var includeObsolete = _p2_System_Boolean;
                                    var style = _p3_UnityEngine_GUIStyle;
                                    var options = _p4_UnityEngine_GUILayoutOptionArray;
                                    var _ret0 = global::UnityEditor.EditorGUILayout.EnumFlagsField(label, enumValue, includeObsolete, style, options);
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
        private static readonly global::Lua.LuaFunction _LuaEditorGUILayout_EnumPopup = new global::Lua.LuaFunction("EnumPopup", (_context, _) =>
        {
            global::Lua.LuaValue _lastArg = default;
            global::System.Int32 _lastArgPos = default;
            global::System.Type _expectedType = default;
            var _argCount = _context.ArgumentCount;
            var _arg0 = _lastArg = _argCount > 0 ? _context.GetArgument(0) : global::Lua.LuaValue.Nil;
            _lastArgPos = 0; _expectedType = typeof(global::System.Enum);
            if (_arg0.TryRead<global::System.Enum>(out var _p0_System_Enum))
            {
                var _arg1 = _lastArg = _argCount > 1 ? _context.GetArgument(1) : global::Lua.LuaValue.Nil;
                _lastArgPos = 1; _expectedType = typeof(global::UnityEngine.GUILayoutOption[]);
                if (_arg1.TryReadArray<global::UnityEngine.GUILayoutOption>(out var _p1_UnityEngine_GUILayoutOptionArray))
                {
                    if (_argCount == 2)
                    {
                        var selected = _p0_System_Enum;
                        var options = _p1_UnityEngine_GUILayoutOptionArray;
                        var _ret0 = global::UnityEditor.EditorGUILayout.EnumPopup(selected, options);
                        var _factory = _context.GetObjectFactory();
                        var _lret0 = _factory.Bind(_ret0);
                        var _retCount = _context.Return(_lret0);
                        return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                    }
                }
                _lastArgPos = 1; _expectedType = typeof(global::UnityEngine.GUIStyle);
                if (_arg1.TryRead<global::UnityEngine.GUIStyle>(out var _p1_UnityEngine_GUIStyle))
                {
                    var _arg2 = _lastArg = _argCount > 2 ? _context.GetArgument(2) : global::Lua.LuaValue.Nil;
                    _lastArgPos = 2; _expectedType = typeof(global::UnityEngine.GUILayoutOption[]);
                    if (_arg2.TryReadArray<global::UnityEngine.GUILayoutOption>(out var _p2_UnityEngine_GUILayoutOptionArray))
                    {
                        if (_argCount == 3)
                        {
                            var selected = _p0_System_Enum;
                            var style = _p1_UnityEngine_GUIStyle;
                            var options = _p2_UnityEngine_GUILayoutOptionArray;
                            var _ret0 = global::UnityEditor.EditorGUILayout.EnumPopup(selected, style, options);
                            var _factory = _context.GetObjectFactory();
                            var _lret0 = _factory.Bind(_ret0);
                            var _retCount = _context.Return(_lret0);
                            return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                        }
                    }
                }
            }
            _lastArgPos = 0; _expectedType = typeof(global::System.String);
            if (_arg0.TryRead<global::System.String>(out var _p0_System_String))
            {
                var _arg1 = _lastArg = _argCount > 1 ? _context.GetArgument(1) : global::Lua.LuaValue.Nil;
                _lastArgPos = 1; _expectedType = typeof(global::System.Enum);
                if (_arg1.TryRead<global::System.Enum>(out var _p1_System_Enum))
                {
                    var _arg2 = _lastArg = _argCount > 2 ? _context.GetArgument(2) : global::Lua.LuaValue.Nil;
                    _lastArgPos = 2; _expectedType = typeof(global::UnityEngine.GUILayoutOption[]);
                    if (_arg2.TryReadArray<global::UnityEngine.GUILayoutOption>(out var _p2_UnityEngine_GUILayoutOptionArray))
                    {
                        if (_argCount == 3)
                        {
                            var label = _p0_System_String;
                            var selected = _p1_System_Enum;
                            var options = _p2_UnityEngine_GUILayoutOptionArray;
                            var _ret0 = global::UnityEditor.EditorGUILayout.EnumPopup(label, selected, options);
                            var _factory = _context.GetObjectFactory();
                            var _lret0 = _factory.Bind(_ret0);
                            var _retCount = _context.Return(_lret0);
                            return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                        }
                    }
                    _lastArgPos = 2; _expectedType = typeof(global::UnityEngine.GUIStyle);
                    if (_arg2.TryRead<global::UnityEngine.GUIStyle>(out var _p2_UnityEngine_GUIStyle))
                    {
                        var _arg3 = _lastArg = _argCount > 3 ? _context.GetArgument(3) : global::Lua.LuaValue.Nil;
                        _lastArgPos = 3; _expectedType = typeof(global::UnityEngine.GUILayoutOption[]);
                        if (_arg3.TryReadArray<global::UnityEngine.GUILayoutOption>(out var _p3_UnityEngine_GUILayoutOptionArray))
                        {
                            if (_argCount == 4)
                            {
                                var label = _p0_System_String;
                                var selected = _p1_System_Enum;
                                var style = _p2_UnityEngine_GUIStyle;
                                var options = _p3_UnityEngine_GUILayoutOptionArray;
                                var _ret0 = global::UnityEditor.EditorGUILayout.EnumPopup(label, selected, style, options);
                                var _factory = _context.GetObjectFactory();
                                var _lret0 = _factory.Bind(_ret0);
                                var _retCount = _context.Return(_lret0);
                                return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                            }
                        }
                    }
                }
            }
            _lastArgPos = 0; _expectedType = typeof(global::UnityEngine.GUIContent);
            if (_arg0.TryRead<global::UnityEngine.GUIContent>(out var _p0_UnityEngine_GUIContent))
            {
                var _arg1 = _lastArg = _argCount > 1 ? _context.GetArgument(1) : global::Lua.LuaValue.Nil;
                _lastArgPos = 1; _expectedType = typeof(global::System.Enum);
                if (_arg1.TryRead<global::System.Enum>(out var _p1_System_Enum))
                {
                    var _arg2 = _lastArg = _argCount > 2 ? _context.GetArgument(2) : global::Lua.LuaValue.Nil;
                    _lastArgPos = 2; _expectedType = typeof(global::UnityEngine.GUILayoutOption[]);
                    if (_arg2.TryReadArray<global::UnityEngine.GUILayoutOption>(out var _p2_UnityEngine_GUILayoutOptionArray))
                    {
                        if (_argCount == 3)
                        {
                            var label = _p0_UnityEngine_GUIContent;
                            var selected = _p1_System_Enum;
                            var options = _p2_UnityEngine_GUILayoutOptionArray;
                            var _ret0 = global::UnityEditor.EditorGUILayout.EnumPopup(label, selected, options);
                            var _factory = _context.GetObjectFactory();
                            var _lret0 = _factory.Bind(_ret0);
                            var _retCount = _context.Return(_lret0);
                            return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                        }
                    }
                    _lastArgPos = 2; _expectedType = typeof(global::UnityEngine.GUIStyle);
                    if (_arg2.TryRead<global::UnityEngine.GUIStyle>(out var _p2_UnityEngine_GUIStyle))
                    {
                        var _arg3 = _lastArg = _argCount > 3 ? _context.GetArgument(3) : global::Lua.LuaValue.Nil;
                        _lastArgPos = 3; _expectedType = typeof(global::UnityEngine.GUILayoutOption[]);
                        if (_arg3.TryReadArray<global::UnityEngine.GUILayoutOption>(out var _p3_UnityEngine_GUILayoutOptionArray))
                        {
                            if (_argCount == 4)
                            {
                                var label = _p0_UnityEngine_GUIContent;
                                var selected = _p1_System_Enum;
                                var style = _p2_UnityEngine_GUIStyle;
                                var options = _p3_UnityEngine_GUILayoutOptionArray;
                                var _ret0 = global::UnityEditor.EditorGUILayout.EnumPopup(label, selected, style, options);
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
        private static readonly global::Lua.LuaFunction _LuaEditorGUILayout_FloatField = new global::Lua.LuaFunction("FloatField", (_context, _) =>
        {
            global::Lua.LuaValue _lastArg = default;
            global::System.Int32 _lastArgPos = default;
            global::System.Type _expectedType = default;
            var _argCount = _context.ArgumentCount;
            var _arg0 = _lastArg = _argCount > 0 ? _context.GetArgument(0) : global::Lua.LuaValue.Nil;
            _lastArgPos = 0; _expectedType = typeof(global::System.Single);
            if (_arg0.TryRead<global::System.Single>(out var _p0_System_Single))
            {
                var _arg1 = _lastArg = _argCount > 1 ? _context.GetArgument(1) : global::Lua.LuaValue.Nil;
                _lastArgPos = 1; _expectedType = typeof(global::UnityEngine.GUILayoutOption[]);
                if (_arg1.TryReadArray<global::UnityEngine.GUILayoutOption>(out var _p1_UnityEngine_GUILayoutOptionArray))
                {
                    if (_argCount == 2)
                    {
                        var value = _p0_System_Single;
                        var options = _p1_UnityEngine_GUILayoutOptionArray;
                        var _ret0 = global::UnityEditor.EditorGUILayout.FloatField(value, options);
                        var _lret0 = new global::Lua.LuaValue(_ret0);
                        var _retCount = _context.Return(_lret0);
                        return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                    }
                }
                _lastArgPos = 1; _expectedType = typeof(global::UnityEngine.GUIStyle);
                if (_arg1.TryRead<global::UnityEngine.GUIStyle>(out var _p1_UnityEngine_GUIStyle))
                {
                    var _arg2 = _lastArg = _argCount > 2 ? _context.GetArgument(2) : global::Lua.LuaValue.Nil;
                    _lastArgPos = 2; _expectedType = typeof(global::UnityEngine.GUILayoutOption[]);
                    if (_arg2.TryReadArray<global::UnityEngine.GUILayoutOption>(out var _p2_UnityEngine_GUILayoutOptionArray))
                    {
                        if (_argCount == 3)
                        {
                            var value = _p0_System_Single;
                            var style = _p1_UnityEngine_GUIStyle;
                            var options = _p2_UnityEngine_GUILayoutOptionArray;
                            var _ret0 = global::UnityEditor.EditorGUILayout.FloatField(value, style, options);
                            var _lret0 = new global::Lua.LuaValue(_ret0);
                            var _retCount = _context.Return(_lret0);
                            return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                        }
                    }
                }
            }
            _lastArgPos = 0; _expectedType = typeof(global::System.String);
            if (_arg0.TryRead<global::System.String>(out var _p0_System_String))
            {
                var _arg1 = _lastArg = _argCount > 1 ? _context.GetArgument(1) : global::Lua.LuaValue.Nil;
                _lastArgPos = 1; _expectedType = typeof(global::System.Single);
                if (_arg1.TryRead<global::System.Single>(out var _p1_System_Single))
                {
                    var _arg2 = _lastArg = _argCount > 2 ? _context.GetArgument(2) : global::Lua.LuaValue.Nil;
                    _lastArgPos = 2; _expectedType = typeof(global::UnityEngine.GUILayoutOption[]);
                    if (_arg2.TryReadArray<global::UnityEngine.GUILayoutOption>(out var _p2_UnityEngine_GUILayoutOptionArray))
                    {
                        if (_argCount == 3)
                        {
                            var label = _p0_System_String;
                            var value = _p1_System_Single;
                            var options = _p2_UnityEngine_GUILayoutOptionArray;
                            var _ret0 = global::UnityEditor.EditorGUILayout.FloatField(label, value, options);
                            var _lret0 = new global::Lua.LuaValue(_ret0);
                            var _retCount = _context.Return(_lret0);
                            return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                        }
                    }
                    _lastArgPos = 2; _expectedType = typeof(global::UnityEngine.GUIStyle);
                    if (_arg2.TryRead<global::UnityEngine.GUIStyle>(out var _p2_UnityEngine_GUIStyle))
                    {
                        var _arg3 = _lastArg = _argCount > 3 ? _context.GetArgument(3) : global::Lua.LuaValue.Nil;
                        _lastArgPos = 3; _expectedType = typeof(global::UnityEngine.GUILayoutOption[]);
                        if (_arg3.TryReadArray<global::UnityEngine.GUILayoutOption>(out var _p3_UnityEngine_GUILayoutOptionArray))
                        {
                            if (_argCount == 4)
                            {
                                var label = _p0_System_String;
                                var value = _p1_System_Single;
                                var style = _p2_UnityEngine_GUIStyle;
                                var options = _p3_UnityEngine_GUILayoutOptionArray;
                                var _ret0 = global::UnityEditor.EditorGUILayout.FloatField(label, value, style, options);
                                var _lret0 = new global::Lua.LuaValue(_ret0);
                                var _retCount = _context.Return(_lret0);
                                return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                            }
                        }
                    }
                }
            }
            _lastArgPos = 0; _expectedType = typeof(global::UnityEngine.GUIContent);
            if (_arg0.TryRead<global::UnityEngine.GUIContent>(out var _p0_UnityEngine_GUIContent))
            {
                var _arg1 = _lastArg = _argCount > 1 ? _context.GetArgument(1) : global::Lua.LuaValue.Nil;
                _lastArgPos = 1; _expectedType = typeof(global::System.Single);
                if (_arg1.TryRead<global::System.Single>(out var _p1_System_Single))
                {
                    var _arg2 = _lastArg = _argCount > 2 ? _context.GetArgument(2) : global::Lua.LuaValue.Nil;
                    _lastArgPos = 2; _expectedType = typeof(global::UnityEngine.GUILayoutOption[]);
                    if (_arg2.TryReadArray<global::UnityEngine.GUILayoutOption>(out var _p2_UnityEngine_GUILayoutOptionArray))
                    {
                        if (_argCount == 3)
                        {
                            var label = _p0_UnityEngine_GUIContent;
                            var value = _p1_System_Single;
                            var options = _p2_UnityEngine_GUILayoutOptionArray;
                            var _ret0 = global::UnityEditor.EditorGUILayout.FloatField(label, value, options);
                            var _lret0 = new global::Lua.LuaValue(_ret0);
                            var _retCount = _context.Return(_lret0);
                            return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                        }
                    }
                    _lastArgPos = 2; _expectedType = typeof(global::UnityEngine.GUIStyle);
                    if (_arg2.TryRead<global::UnityEngine.GUIStyle>(out var _p2_UnityEngine_GUIStyle))
                    {
                        var _arg3 = _lastArg = _argCount > 3 ? _context.GetArgument(3) : global::Lua.LuaValue.Nil;
                        _lastArgPos = 3; _expectedType = typeof(global::UnityEngine.GUILayoutOption[]);
                        if (_arg3.TryReadArray<global::UnityEngine.GUILayoutOption>(out var _p3_UnityEngine_GUILayoutOptionArray))
                        {
                            if (_argCount == 4)
                            {
                                var label = _p0_UnityEngine_GUIContent;
                                var value = _p1_System_Single;
                                var style = _p2_UnityEngine_GUIStyle;
                                var options = _p3_UnityEngine_GUILayoutOptionArray;
                                var _ret0 = global::UnityEditor.EditorGUILayout.FloatField(label, value, style, options);
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
        private static readonly global::Lua.LuaFunction _LuaEditorGUILayout_Foldout = new global::Lua.LuaFunction("Foldout", (_context, _) =>
        {
            global::Lua.LuaValue _lastArg = default;
            global::System.Int32 _lastArgPos = default;
            global::System.Type _expectedType = default;
            var _argCount = _context.ArgumentCount;
            var _arg0 = _lastArg = _argCount > 0 ? _context.GetArgument(0) : global::Lua.LuaValue.Nil;
            _lastArgPos = 0; _expectedType = typeof(global::System.Boolean);
            if (_arg0.TryRead<global::System.Boolean>(out var _p0_System_Boolean))
            {
                var _arg1 = _lastArg = _argCount > 1 ? _context.GetArgument(1) : global::Lua.LuaValue.Nil;
                _lastArgPos = 1; _expectedType = typeof(global::System.String);
                if (_arg1.TryRead<global::System.String>(out var _p1_System_String))
                {
                    if (_argCount == 2)
                    {
                        var foldout = _p0_System_Boolean;
                        var content = _p1_System_String;
                        var _ret0 = global::UnityEditor.EditorGUILayout.Foldout(foldout, content);
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
                            var foldout = _p0_System_Boolean;
                            var content = _p1_System_String;
                            var toggleOnLabelClick = _p2_System_Boolean;
                            var _ret0 = global::UnityEditor.EditorGUILayout.Foldout(foldout, content, toggleOnLabelClick);
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
                                var foldout = _p0_System_Boolean;
                                var content = _p1_System_String;
                                var toggleOnLabelClick = _p2_System_Boolean;
                                var style = _p3_UnityEngine_GUIStyle;
                                var _ret0 = global::UnityEditor.EditorGUILayout.Foldout(foldout, content, toggleOnLabelClick, style);
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
                            var foldout = _p0_System_Boolean;
                            var content = _p1_System_String;
                            var style = _p2_UnityEngine_GUIStyle;
                            var _ret0 = global::UnityEditor.EditorGUILayout.Foldout(foldout, content, style);
                            var _lret0 = new global::Lua.LuaValue(_ret0);
                            var _retCount = _context.Return(_lret0);
                            return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                        }
                    }
                }
                _lastArgPos = 1; _expectedType = typeof(global::UnityEngine.GUIContent);
                if (_arg1.TryRead<global::UnityEngine.GUIContent>(out var _p1_UnityEngine_GUIContent))
                {
                    if (_argCount == 2)
                    {
                        var foldout = _p0_System_Boolean;
                        var content = _p1_UnityEngine_GUIContent;
                        var _ret0 = global::UnityEditor.EditorGUILayout.Foldout(foldout, content);
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
                            var foldout = _p0_System_Boolean;
                            var content = _p1_UnityEngine_GUIContent;
                            var toggleOnLabelClick = _p2_System_Boolean;
                            var _ret0 = global::UnityEditor.EditorGUILayout.Foldout(foldout, content, toggleOnLabelClick);
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
                                var foldout = _p0_System_Boolean;
                                var content = _p1_UnityEngine_GUIContent;
                                var toggleOnLabelClick = _p2_System_Boolean;
                                var style = _p3_UnityEngine_GUIStyle;
                                var _ret0 = global::UnityEditor.EditorGUILayout.Foldout(foldout, content, toggleOnLabelClick, style);
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
                            var foldout = _p0_System_Boolean;
                            var content = _p1_UnityEngine_GUIContent;
                            var style = _p2_UnityEngine_GUIStyle;
                            var _ret0 = global::UnityEditor.EditorGUILayout.Foldout(foldout, content, style);
                            var _lret0 = new global::Lua.LuaValue(_ret0);
                            var _retCount = _context.Return(_lret0);
                            return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                        }
                    }
                }
            }
            throw new global::Lua.LuaRuntimeException(_context.Thread, $"{"Foldout"}: invalid argument #{_lastArgPos}: {_lastArg} ({_lastArg.Type}), expected: {_expectedType.FullName}", 2);
        });
        private static readonly global::Lua.LuaFunction _LuaEditorGUILayout_GetControlRect = new global::Lua.LuaFunction("GetControlRect", (_context, _) =>
        {
            global::Lua.LuaValue _lastArg = default;
            global::System.Int32 _lastArgPos = default;
            global::System.Type _expectedType = default;
            var _argCount = _context.ArgumentCount;
            var _arg0 = _lastArg = _argCount > 0 ? _context.GetArgument(0) : global::Lua.LuaValue.Nil;
            _lastArgPos = 0; _expectedType = typeof(global::UnityEngine.GUILayoutOption[]);
            if (_arg0.TryReadArray<global::UnityEngine.GUILayoutOption>(out var _p0_UnityEngine_GUILayoutOptionArray))
            {
                if (_argCount == 1)
                {
                    var options = _p0_UnityEngine_GUILayoutOptionArray;
                    var _ret0 = global::UnityEditor.EditorGUILayout.GetControlRect(options);
                    var _factory = _context.GetObjectFactory();
                    var _lret0 = _factory.Bind(_ret0);
                    var _retCount = _context.Return(_lret0);
                    return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                }
            }
            _lastArgPos = 0; _expectedType = typeof(global::System.Boolean);
            if (_arg0.TryRead<global::System.Boolean>(out var _p0_System_Boolean))
            {
                var _arg1 = _lastArg = _argCount > 1 ? _context.GetArgument(1) : global::Lua.LuaValue.Nil;
                _lastArgPos = 1; _expectedType = typeof(global::UnityEngine.GUILayoutOption[]);
                if (_arg1.TryReadArray<global::UnityEngine.GUILayoutOption>(out var _p1_UnityEngine_GUILayoutOptionArray))
                {
                    if (_argCount == 2)
                    {
                        var hasLabel = _p0_System_Boolean;
                        var options = _p1_UnityEngine_GUILayoutOptionArray;
                        var _ret0 = global::UnityEditor.EditorGUILayout.GetControlRect(hasLabel, options);
                        var _factory = _context.GetObjectFactory();
                        var _lret0 = _factory.Bind(_ret0);
                        var _retCount = _context.Return(_lret0);
                        return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                    }
                }
                _lastArgPos = 1; _expectedType = typeof(global::System.Single);
                if (_arg1.TryRead<global::System.Single>(out var _p1_System_Single))
                {
                    var _arg2 = _lastArg = _argCount > 2 ? _context.GetArgument(2) : global::Lua.LuaValue.Nil;
                    _lastArgPos = 2; _expectedType = typeof(global::UnityEngine.GUILayoutOption[]);
                    if (_arg2.TryReadArray<global::UnityEngine.GUILayoutOption>(out var _p2_UnityEngine_GUILayoutOptionArray))
                    {
                        if (_argCount == 3)
                        {
                            var hasLabel = _p0_System_Boolean;
                            var height = _p1_System_Single;
                            var options = _p2_UnityEngine_GUILayoutOptionArray;
                            var _ret0 = global::UnityEditor.EditorGUILayout.GetControlRect(hasLabel, height, options);
                            var _factory = _context.GetObjectFactory();
                            var _lret0 = _factory.Bind(_ret0);
                            var _retCount = _context.Return(_lret0);
                            return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                        }
                    }
                    _lastArgPos = 2; _expectedType = typeof(global::UnityEngine.GUIStyle);
                    if (_arg2.TryRead<global::UnityEngine.GUIStyle>(out var _p2_UnityEngine_GUIStyle))
                    {
                        var _arg3 = _lastArg = _argCount > 3 ? _context.GetArgument(3) : global::Lua.LuaValue.Nil;
                        _lastArgPos = 3; _expectedType = typeof(global::UnityEngine.GUILayoutOption[]);
                        if (_arg3.TryReadArray<global::UnityEngine.GUILayoutOption>(out var _p3_UnityEngine_GUILayoutOptionArray))
                        {
                            if (_argCount == 4)
                            {
                                var hasLabel = _p0_System_Boolean;
                                var height = _p1_System_Single;
                                var style = _p2_UnityEngine_GUIStyle;
                                var options = _p3_UnityEngine_GUILayoutOptionArray;
                                var _ret0 = global::UnityEditor.EditorGUILayout.GetControlRect(hasLabel, height, style, options);
                                var _factory = _context.GetObjectFactory();
                                var _lret0 = _factory.Bind(_ret0);
                                var _retCount = _context.Return(_lret0);
                                return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                            }
                        }
                    }
                }
            }
            throw new global::Lua.LuaRuntimeException(_context.Thread, $"{"GetControlRect"}: invalid argument #{_lastArgPos}: {_lastArg} ({_lastArg.Type}), expected: {_expectedType.FullName}", 2);
        });
        private static readonly global::Lua.LuaFunction _LuaEditorGUILayout_GradientField = new global::Lua.LuaFunction("GradientField", (_context, _) =>
        {
            global::Lua.LuaValue _lastArg = default;
            global::System.Int32 _lastArgPos = default;
            global::System.Type _expectedType = default;
            var _argCount = _context.ArgumentCount;
            var _arg0 = _lastArg = _argCount > 0 ? _context.GetArgument(0) : global::Lua.LuaValue.Nil;
            _lastArgPos = 0; _expectedType = typeof(global::UnityEngine.Gradient);
            if (_arg0.TryRead<global::UnityEngine.Gradient>(out var _p0_UnityEngine_Gradient))
            {
                var _arg1 = _lastArg = _argCount > 1 ? _context.GetArgument(1) : global::Lua.LuaValue.Nil;
                _lastArgPos = 1; _expectedType = typeof(global::UnityEngine.GUILayoutOption[]);
                if (_arg1.TryReadArray<global::UnityEngine.GUILayoutOption>(out var _p1_UnityEngine_GUILayoutOptionArray))
                {
                    if (_argCount == 2)
                    {
                        var value = _p0_UnityEngine_Gradient;
                        var options = _p1_UnityEngine_GUILayoutOptionArray;
                        var _ret0 = global::UnityEditor.EditorGUILayout.GradientField(value, options);
                        var _factory = _context.GetObjectFactory();
                        var _lret0 = _factory.Bind(_ret0);
                        var _retCount = _context.Return(_lret0);
                        return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                    }
                }
            }
            _lastArgPos = 0; _expectedType = typeof(global::System.String);
            if (_arg0.TryRead<global::System.String>(out var _p0_System_String))
            {
                var _arg1 = _lastArg = _argCount > 1 ? _context.GetArgument(1) : global::Lua.LuaValue.Nil;
                _lastArgPos = 1; _expectedType = typeof(global::UnityEngine.Gradient);
                if (_arg1.TryRead<global::UnityEngine.Gradient>(out var _p1_UnityEngine_Gradient))
                {
                    var _arg2 = _lastArg = _argCount > 2 ? _context.GetArgument(2) : global::Lua.LuaValue.Nil;
                    _lastArgPos = 2; _expectedType = typeof(global::UnityEngine.GUILayoutOption[]);
                    if (_arg2.TryReadArray<global::UnityEngine.GUILayoutOption>(out var _p2_UnityEngine_GUILayoutOptionArray))
                    {
                        if (_argCount == 3)
                        {
                            var label = _p0_System_String;
                            var value = _p1_UnityEngine_Gradient;
                            var options = _p2_UnityEngine_GUILayoutOptionArray;
                            var _ret0 = global::UnityEditor.EditorGUILayout.GradientField(label, value, options);
                            var _factory = _context.GetObjectFactory();
                            var _lret0 = _factory.Bind(_ret0);
                            var _retCount = _context.Return(_lret0);
                            return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                        }
                    }
                }
            }
            _lastArgPos = 0; _expectedType = typeof(global::UnityEngine.GUIContent);
            if (_arg0.TryRead<global::UnityEngine.GUIContent>(out var _p0_UnityEngine_GUIContent))
            {
                var _arg1 = _lastArg = _argCount > 1 ? _context.GetArgument(1) : global::Lua.LuaValue.Nil;
                _lastArgPos = 1; _expectedType = typeof(global::UnityEngine.Gradient);
                if (_arg1.TryRead<global::UnityEngine.Gradient>(out var _p1_UnityEngine_Gradient))
                {
                    var _arg2 = _lastArg = _argCount > 2 ? _context.GetArgument(2) : global::Lua.LuaValue.Nil;
                    _lastArgPos = 2; _expectedType = typeof(global::UnityEngine.GUILayoutOption[]);
                    if (_arg2.TryReadArray<global::UnityEngine.GUILayoutOption>(out var _p2_UnityEngine_GUILayoutOptionArray))
                    {
                        if (_argCount == 3)
                        {
                            var label = _p0_UnityEngine_GUIContent;
                            var value = _p1_UnityEngine_Gradient;
                            var options = _p2_UnityEngine_GUILayoutOptionArray;
                            var _ret0 = global::UnityEditor.EditorGUILayout.GradientField(label, value, options);
                            var _factory = _context.GetObjectFactory();
                            var _lret0 = _factory.Bind(_ret0);
                            var _retCount = _context.Return(_lret0);
                            return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                        }
                    }
                    _lastArgPos = 2; _expectedType = typeof(global::System.Boolean);
                    if (_arg2.TryRead<global::System.Boolean>(out var _p2_System_Boolean))
                    {
                        var _arg3 = _lastArg = _argCount > 3 ? _context.GetArgument(3) : global::Lua.LuaValue.Nil;
                        _lastArgPos = 3; _expectedType = typeof(global::UnityEngine.GUILayoutOption[]);
                        if (_arg3.TryReadArray<global::UnityEngine.GUILayoutOption>(out var _p3_UnityEngine_GUILayoutOptionArray))
                        {
                            if (_argCount == 4)
                            {
                                var label = _p0_UnityEngine_GUIContent;
                                var value = _p1_UnityEngine_Gradient;
                                var hdr = _p2_System_Boolean;
                                var options = _p3_UnityEngine_GUILayoutOptionArray;
                                var _ret0 = global::UnityEditor.EditorGUILayout.GradientField(label, value, hdr, options);
                                var _factory = _context.GetObjectFactory();
                                var _lret0 = _factory.Bind(_ret0);
                                var _retCount = _context.Return(_lret0);
                                return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                            }
                        }
                    }
                }
            }
            throw new global::Lua.LuaRuntimeException(_context.Thread, $"{"GradientField"}: invalid argument #{_lastArgPos}: {_lastArg} ({_lastArg.Type}), expected: {_expectedType.FullName}", 2);
        });
        private static readonly global::Lua.LuaFunction _LuaEditorGUILayout_HelpBox = new global::Lua.LuaFunction("HelpBox", (_context, _) =>
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
                        var message = _p0_System_String;
                        var type = _p1_UnityEditor_MessageType;
                        global::UnityEditor.EditorGUILayout.HelpBox(message, type);
                        var _retCount = _context.Return();
                        return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                    }
                    var _arg2 = _lastArg = _argCount > 2 ? _context.GetArgument(2) : global::Lua.LuaValue.Nil;
                    _lastArgPos = 2; _expectedType = typeof(global::System.Boolean);
                    if (_arg2.TryRead<global::System.Boolean>(out var _p2_System_Boolean))
                    {
                        if (_argCount == 3)
                        {
                            var message = _p0_System_String;
                            var type = _p1_UnityEditor_MessageType;
                            var wide = _p2_System_Boolean;
                            global::UnityEditor.EditorGUILayout.HelpBox(message, type, wide);
                            var _retCount = _context.Return();
                            return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                        }
                    }
                }
            }
            _lastArgPos = 0; _expectedType = typeof(global::UnityEngine.GUIContent);
            if (_arg0.TryRead<global::UnityEngine.GUIContent>(out var _p0_UnityEngine_GUIContent))
            {
                if (_argCount == 1)
                {
                    var content = _p0_UnityEngine_GUIContent;
                    global::UnityEditor.EditorGUILayout.HelpBox(content);
                    var _retCount = _context.Return();
                    return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                }
                var _arg1 = _lastArg = _argCount > 1 ? _context.GetArgument(1) : global::Lua.LuaValue.Nil;
                _lastArgPos = 1; _expectedType = typeof(global::System.Boolean);
                var _p1_System_Boolean = _arg1.ReadValue<global::System.Boolean>((global::System.Boolean)true);
                {
                    if (_argCount == 2)
                    {
                        var content = _p0_UnityEngine_GUIContent;
                        var wide = _p1_System_Boolean;
                        global::UnityEditor.EditorGUILayout.HelpBox(content, wide);
                        var _retCount = _context.Return();
                        return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                    }
                }
            }
            throw new global::Lua.LuaRuntimeException(_context.Thread, $"{"HelpBox"}: invalid argument #{_lastArgPos}: {_lastArg} ({_lastArg.Type}), expected: {_expectedType.FullName}", 2);
        });
        private static readonly global::Lua.LuaFunction _LuaEditorGUILayout_InspectorTitlebar = new global::Lua.LuaFunction("InspectorTitlebar", (_context, _) =>
        {
            global::Lua.LuaValue _lastArg = default;
            global::System.Int32 _lastArgPos = default;
            global::System.Type _expectedType = default;
            var _argCount = _context.ArgumentCount;
            var _arg0 = _lastArg = _argCount > 0 ? _context.GetArgument(0) : global::Lua.LuaValue.Nil;
            _lastArgPos = 0; _expectedType = typeof(global::UnityEngine.Object[]);
            if (_arg0.TryReadArray<global::UnityEngine.Object>(out var _p0_UnityEngine_ObjectArray))
            {
                if (_argCount == 1)
                {
                    var targetObjs = _p0_UnityEngine_ObjectArray;
                    global::UnityEditor.EditorGUILayout.InspectorTitlebar(targetObjs);
                    var _retCount = _context.Return();
                    return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                }
            }
            _lastArgPos = 0; _expectedType = typeof(global::System.Boolean);
            if (_arg0.TryRead<global::System.Boolean>(out var _p0_System_Boolean))
            {
                var _arg1 = _lastArg = _argCount > 1 ? _context.GetArgument(1) : global::Lua.LuaValue.Nil;
                _lastArgPos = 1; _expectedType = typeof(global::Luny.UnityEditor.LuaEditor);
                if (_arg1.TryRead<global::Luny.UnityEditor.LuaEditor>(out var _p1_UnityEditor_Editor))
                {
                    if (_argCount == 2)
                    {
                        var foldout = _p0_System_Boolean;
                        var editor = _p1_UnityEditor_Editor.Instance;
                        var _ret0 = global::UnityEditor.EditorGUILayout.InspectorTitlebar(foldout, editor);
                        var _lret0 = new global::Lua.LuaValue(_ret0);
                        var _retCount = _context.Return(_lret0);
                        return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                    }
                }
                _lastArgPos = 1; _expectedType = typeof(global::UnityEngine.Object);
                if (_arg1.TryRead<global::UnityEngine.Object>(out var _p1_UnityEngine_Object))
                {
                    if (_argCount == 2)
                    {
                        var foldout = _p0_System_Boolean;
                        var targetObj = _p1_UnityEngine_Object;
                        var _ret0 = global::UnityEditor.EditorGUILayout.InspectorTitlebar(foldout, targetObj);
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
                            var foldout = _p0_System_Boolean;
                            var targetObj = _p1_UnityEngine_Object;
                            var expandable = _p2_System_Boolean;
                            var _ret0 = global::UnityEditor.EditorGUILayout.InspectorTitlebar(foldout, targetObj, expandable);
                            var _lret0 = new global::Lua.LuaValue(_ret0);
                            var _retCount = _context.Return(_lret0);
                            return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                        }
                    }
                }
                _lastArgPos = 1; _expectedType = typeof(global::UnityEngine.Object[]);
                if (_arg1.TryReadArray<global::UnityEngine.Object>(out var _p1_UnityEngine_ObjectArray))
                {
                    if (_argCount == 2)
                    {
                        var foldout = _p0_System_Boolean;
                        var targetObjs = _p1_UnityEngine_ObjectArray;
                        var _ret0 = global::UnityEditor.EditorGUILayout.InspectorTitlebar(foldout, targetObjs);
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
                            var foldout = _p0_System_Boolean;
                            var targetObjs = _p1_UnityEngine_ObjectArray;
                            var expandable = _p2_System_Boolean;
                            var _ret0 = global::UnityEditor.EditorGUILayout.InspectorTitlebar(foldout, targetObjs, expandable);
                            var _lret0 = new global::Lua.LuaValue(_ret0);
                            var _retCount = _context.Return(_lret0);
                            return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                        }
                    }
                }
            }
            throw new global::Lua.LuaRuntimeException(_context.Thread, $"{"InspectorTitlebar"}: invalid argument #{_lastArgPos}: {_lastArg} ({_lastArg.Type}), expected: {_expectedType.FullName}", 2);
        });
        private static readonly global::Lua.LuaFunction _LuaEditorGUILayout_IntField = new global::Lua.LuaFunction("IntField", (_context, _) =>
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
                _lastArgPos = 1; _expectedType = typeof(global::UnityEngine.GUILayoutOption[]);
                if (_arg1.TryReadArray<global::UnityEngine.GUILayoutOption>(out var _p1_UnityEngine_GUILayoutOptionArray))
                {
                    if (_argCount == 2)
                    {
                        var value = _p0_System_Int32;
                        var options = _p1_UnityEngine_GUILayoutOptionArray;
                        var _ret0 = global::UnityEditor.EditorGUILayout.IntField(value, options);
                        var _lret0 = new global::Lua.LuaValue(_ret0);
                        var _retCount = _context.Return(_lret0);
                        return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                    }
                }
                _lastArgPos = 1; _expectedType = typeof(global::UnityEngine.GUIStyle);
                if (_arg1.TryRead<global::UnityEngine.GUIStyle>(out var _p1_UnityEngine_GUIStyle))
                {
                    var _arg2 = _lastArg = _argCount > 2 ? _context.GetArgument(2) : global::Lua.LuaValue.Nil;
                    _lastArgPos = 2; _expectedType = typeof(global::UnityEngine.GUILayoutOption[]);
                    if (_arg2.TryReadArray<global::UnityEngine.GUILayoutOption>(out var _p2_UnityEngine_GUILayoutOptionArray))
                    {
                        if (_argCount == 3)
                        {
                            var value = _p0_System_Int32;
                            var style = _p1_UnityEngine_GUIStyle;
                            var options = _p2_UnityEngine_GUILayoutOptionArray;
                            var _ret0 = global::UnityEditor.EditorGUILayout.IntField(value, style, options);
                            var _lret0 = new global::Lua.LuaValue(_ret0);
                            var _retCount = _context.Return(_lret0);
                            return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                        }
                    }
                }
            }
            _lastArgPos = 0; _expectedType = typeof(global::System.String);
            if (_arg0.TryRead<global::System.String>(out var _p0_System_String))
            {
                var _arg1 = _lastArg = _argCount > 1 ? _context.GetArgument(1) : global::Lua.LuaValue.Nil;
                _lastArgPos = 1; _expectedType = typeof(global::System.Int32);
                if (_arg1.TryRead<global::System.Int32>(out var _p1_System_Int32))
                {
                    var _arg2 = _lastArg = _argCount > 2 ? _context.GetArgument(2) : global::Lua.LuaValue.Nil;
                    _lastArgPos = 2; _expectedType = typeof(global::UnityEngine.GUILayoutOption[]);
                    if (_arg2.TryReadArray<global::UnityEngine.GUILayoutOption>(out var _p2_UnityEngine_GUILayoutOptionArray))
                    {
                        if (_argCount == 3)
                        {
                            var label = _p0_System_String;
                            var value = _p1_System_Int32;
                            var options = _p2_UnityEngine_GUILayoutOptionArray;
                            var _ret0 = global::UnityEditor.EditorGUILayout.IntField(label, value, options);
                            var _lret0 = new global::Lua.LuaValue(_ret0);
                            var _retCount = _context.Return(_lret0);
                            return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                        }
                    }
                    _lastArgPos = 2; _expectedType = typeof(global::UnityEngine.GUIStyle);
                    if (_arg2.TryRead<global::UnityEngine.GUIStyle>(out var _p2_UnityEngine_GUIStyle))
                    {
                        var _arg3 = _lastArg = _argCount > 3 ? _context.GetArgument(3) : global::Lua.LuaValue.Nil;
                        _lastArgPos = 3; _expectedType = typeof(global::UnityEngine.GUILayoutOption[]);
                        if (_arg3.TryReadArray<global::UnityEngine.GUILayoutOption>(out var _p3_UnityEngine_GUILayoutOptionArray))
                        {
                            if (_argCount == 4)
                            {
                                var label = _p0_System_String;
                                var value = _p1_System_Int32;
                                var style = _p2_UnityEngine_GUIStyle;
                                var options = _p3_UnityEngine_GUILayoutOptionArray;
                                var _ret0 = global::UnityEditor.EditorGUILayout.IntField(label, value, style, options);
                                var _lret0 = new global::Lua.LuaValue(_ret0);
                                var _retCount = _context.Return(_lret0);
                                return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                            }
                        }
                    }
                }
            }
            _lastArgPos = 0; _expectedType = typeof(global::UnityEngine.GUIContent);
            if (_arg0.TryRead<global::UnityEngine.GUIContent>(out var _p0_UnityEngine_GUIContent))
            {
                var _arg1 = _lastArg = _argCount > 1 ? _context.GetArgument(1) : global::Lua.LuaValue.Nil;
                _lastArgPos = 1; _expectedType = typeof(global::System.Int32);
                if (_arg1.TryRead<global::System.Int32>(out var _p1_System_Int32))
                {
                    var _arg2 = _lastArg = _argCount > 2 ? _context.GetArgument(2) : global::Lua.LuaValue.Nil;
                    _lastArgPos = 2; _expectedType = typeof(global::UnityEngine.GUILayoutOption[]);
                    if (_arg2.TryReadArray<global::UnityEngine.GUILayoutOption>(out var _p2_UnityEngine_GUILayoutOptionArray))
                    {
                        if (_argCount == 3)
                        {
                            var label = _p0_UnityEngine_GUIContent;
                            var value = _p1_System_Int32;
                            var options = _p2_UnityEngine_GUILayoutOptionArray;
                            var _ret0 = global::UnityEditor.EditorGUILayout.IntField(label, value, options);
                            var _lret0 = new global::Lua.LuaValue(_ret0);
                            var _retCount = _context.Return(_lret0);
                            return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                        }
                    }
                    _lastArgPos = 2; _expectedType = typeof(global::UnityEngine.GUIStyle);
                    if (_arg2.TryRead<global::UnityEngine.GUIStyle>(out var _p2_UnityEngine_GUIStyle))
                    {
                        var _arg3 = _lastArg = _argCount > 3 ? _context.GetArgument(3) : global::Lua.LuaValue.Nil;
                        _lastArgPos = 3; _expectedType = typeof(global::UnityEngine.GUILayoutOption[]);
                        if (_arg3.TryReadArray<global::UnityEngine.GUILayoutOption>(out var _p3_UnityEngine_GUILayoutOptionArray))
                        {
                            if (_argCount == 4)
                            {
                                var label = _p0_UnityEngine_GUIContent;
                                var value = _p1_System_Int32;
                                var style = _p2_UnityEngine_GUIStyle;
                                var options = _p3_UnityEngine_GUILayoutOptionArray;
                                var _ret0 = global::UnityEditor.EditorGUILayout.IntField(label, value, style, options);
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
        private static readonly global::Lua.LuaFunction _LuaEditorGUILayout_IntPopup = new global::Lua.LuaFunction("IntPopup", (_context, _) =>
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
                _lastArgPos = 1; _expectedType = typeof(global::System.String[]);
                if (_arg1.TryReadArray<global::System.String>(out var _p1_System_StringArray))
                {
                    var _arg2 = _lastArg = _argCount > 2 ? _context.GetArgument(2) : global::Lua.LuaValue.Nil;
                    _lastArgPos = 2; _expectedType = typeof(global::System.Int32[]);
                    if (_arg2.TryReadArray<global::System.Int32>(out var _p2_System_Int32Array))
                    {
                        var _arg3 = _lastArg = _argCount > 3 ? _context.GetArgument(3) : global::Lua.LuaValue.Nil;
                        _lastArgPos = 3; _expectedType = typeof(global::UnityEngine.GUILayoutOption[]);
                        if (_arg3.TryReadArray<global::UnityEngine.GUILayoutOption>(out var _p3_UnityEngine_GUILayoutOptionArray))
                        {
                            if (_argCount == 4)
                            {
                                var selectedValue = _p0_System_Int32;
                                var displayedOptions = _p1_System_StringArray;
                                var optionValues = _p2_System_Int32Array;
                                var options = _p3_UnityEngine_GUILayoutOptionArray;
                                var _ret0 = global::UnityEditor.EditorGUILayout.IntPopup(selectedValue, displayedOptions, optionValues, options);
                                var _lret0 = new global::Lua.LuaValue(_ret0);
                                var _retCount = _context.Return(_lret0);
                                return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                            }
                        }
                        _lastArgPos = 3; _expectedType = typeof(global::UnityEngine.GUIStyle);
                        if (_arg3.TryRead<global::UnityEngine.GUIStyle>(out var _p3_UnityEngine_GUIStyle))
                        {
                            var _arg4 = _lastArg = _argCount > 4 ? _context.GetArgument(4) : global::Lua.LuaValue.Nil;
                            _lastArgPos = 4; _expectedType = typeof(global::UnityEngine.GUILayoutOption[]);
                            if (_arg4.TryReadArray<global::UnityEngine.GUILayoutOption>(out var _p4_UnityEngine_GUILayoutOptionArray))
                            {
                                if (_argCount == 5)
                                {
                                    var selectedValue = _p0_System_Int32;
                                    var displayedOptions = _p1_System_StringArray;
                                    var optionValues = _p2_System_Int32Array;
                                    var style = _p3_UnityEngine_GUIStyle;
                                    var options = _p4_UnityEngine_GUILayoutOptionArray;
                                    var _ret0 = global::UnityEditor.EditorGUILayout.IntPopup(selectedValue, displayedOptions, optionValues, style, options);
                                    var _lret0 = new global::Lua.LuaValue(_ret0);
                                    var _retCount = _context.Return(_lret0);
                                    return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                                }
                            }
                        }
                    }
                }
                _lastArgPos = 1; _expectedType = typeof(global::UnityEngine.GUIContent[]);
                if (_arg1.TryReadArray<global::UnityEngine.GUIContent>(out var _p1_UnityEngine_GUIContentArray))
                {
                    var _arg2 = _lastArg = _argCount > 2 ? _context.GetArgument(2) : global::Lua.LuaValue.Nil;
                    _lastArgPos = 2; _expectedType = typeof(global::System.Int32[]);
                    if (_arg2.TryReadArray<global::System.Int32>(out var _p2_System_Int32Array))
                    {
                        var _arg3 = _lastArg = _argCount > 3 ? _context.GetArgument(3) : global::Lua.LuaValue.Nil;
                        _lastArgPos = 3; _expectedType = typeof(global::UnityEngine.GUILayoutOption[]);
                        if (_arg3.TryReadArray<global::UnityEngine.GUILayoutOption>(out var _p3_UnityEngine_GUILayoutOptionArray))
                        {
                            if (_argCount == 4)
                            {
                                var selectedValue = _p0_System_Int32;
                                var displayedOptions = _p1_UnityEngine_GUIContentArray;
                                var optionValues = _p2_System_Int32Array;
                                var options = _p3_UnityEngine_GUILayoutOptionArray;
                                var _ret0 = global::UnityEditor.EditorGUILayout.IntPopup(selectedValue, displayedOptions, optionValues, options);
                                var _lret0 = new global::Lua.LuaValue(_ret0);
                                var _retCount = _context.Return(_lret0);
                                return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                            }
                        }
                        _lastArgPos = 3; _expectedType = typeof(global::UnityEngine.GUIStyle);
                        if (_arg3.TryRead<global::UnityEngine.GUIStyle>(out var _p3_UnityEngine_GUIStyle))
                        {
                            var _arg4 = _lastArg = _argCount > 4 ? _context.GetArgument(4) : global::Lua.LuaValue.Nil;
                            _lastArgPos = 4; _expectedType = typeof(global::UnityEngine.GUILayoutOption[]);
                            if (_arg4.TryReadArray<global::UnityEngine.GUILayoutOption>(out var _p4_UnityEngine_GUILayoutOptionArray))
                            {
                                if (_argCount == 5)
                                {
                                    var selectedValue = _p0_System_Int32;
                                    var displayedOptions = _p1_UnityEngine_GUIContentArray;
                                    var optionValues = _p2_System_Int32Array;
                                    var style = _p3_UnityEngine_GUIStyle;
                                    var options = _p4_UnityEngine_GUILayoutOptionArray;
                                    var _ret0 = global::UnityEditor.EditorGUILayout.IntPopup(selectedValue, displayedOptions, optionValues, style, options);
                                    var _lret0 = new global::Lua.LuaValue(_ret0);
                                    var _retCount = _context.Return(_lret0);
                                    return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                                }
                            }
                        }
                    }
                }
            }
            _lastArgPos = 0; _expectedType = typeof(global::Luny.UnityEditor.LuaSerializedProperty);
            if (_arg0.TryRead<global::Luny.UnityEditor.LuaSerializedProperty>(out var _p0_UnityEditor_SerializedProperty))
            {
                var _arg1 = _lastArg = _argCount > 1 ? _context.GetArgument(1) : global::Lua.LuaValue.Nil;
                _lastArgPos = 1; _expectedType = typeof(global::UnityEngine.GUIContent[]);
                if (_arg1.TryReadArray<global::UnityEngine.GUIContent>(out var _p1_UnityEngine_GUIContentArray))
                {
                    var _arg2 = _lastArg = _argCount > 2 ? _context.GetArgument(2) : global::Lua.LuaValue.Nil;
                    _lastArgPos = 2; _expectedType = typeof(global::System.Int32[]);
                    if (_arg2.TryReadArray<global::System.Int32>(out var _p2_System_Int32Array))
                    {
                        var _arg3 = _lastArg = _argCount > 3 ? _context.GetArgument(3) : global::Lua.LuaValue.Nil;
                        _lastArgPos = 3; _expectedType = typeof(global::UnityEngine.GUILayoutOption[]);
                        if (_arg3.TryReadArray<global::UnityEngine.GUILayoutOption>(out var _p3_UnityEngine_GUILayoutOptionArray))
                        {
                            if (_argCount == 4)
                            {
                                var property = _p0_UnityEditor_SerializedProperty.Instance;
                                var displayedOptions = _p1_UnityEngine_GUIContentArray;
                                var optionValues = _p2_System_Int32Array;
                                var options = _p3_UnityEngine_GUILayoutOptionArray;
                                global::UnityEditor.EditorGUILayout.IntPopup(property, displayedOptions, optionValues, options);
                                var _retCount = _context.Return();
                                return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                            }
                        }
                        _lastArgPos = 3; _expectedType = typeof(global::UnityEngine.GUIContent);
                        if (_arg3.TryRead<global::UnityEngine.GUIContent>(out var _p3_UnityEngine_GUIContent))
                        {
                            var _arg4 = _lastArg = _argCount > 4 ? _context.GetArgument(4) : global::Lua.LuaValue.Nil;
                            _lastArgPos = 4; _expectedType = typeof(global::UnityEngine.GUILayoutOption[]);
                            if (_arg4.TryReadArray<global::UnityEngine.GUILayoutOption>(out var _p4_UnityEngine_GUILayoutOptionArray))
                            {
                                if (_argCount == 5)
                                {
                                    var property = _p0_UnityEditor_SerializedProperty.Instance;
                                    var displayedOptions = _p1_UnityEngine_GUIContentArray;
                                    var optionValues = _p2_System_Int32Array;
                                    var label = _p3_UnityEngine_GUIContent;
                                    var options = _p4_UnityEngine_GUILayoutOptionArray;
                                    global::UnityEditor.EditorGUILayout.IntPopup(property, displayedOptions, optionValues, label, options);
                                    var _retCount = _context.Return();
                                    return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                                }
                            }
                        }
                    }
                }
            }
            _lastArgPos = 0; _expectedType = typeof(global::System.String);
            if (_arg0.TryRead<global::System.String>(out var _p0_System_String))
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
                            var _arg4 = _lastArg = _argCount > 4 ? _context.GetArgument(4) : global::Lua.LuaValue.Nil;
                            _lastArgPos = 4; _expectedType = typeof(global::UnityEngine.GUILayoutOption[]);
                            if (_arg4.TryReadArray<global::UnityEngine.GUILayoutOption>(out var _p4_UnityEngine_GUILayoutOptionArray))
                            {
                                if (_argCount == 5)
                                {
                                    var label = _p0_System_String;
                                    var selectedValue = _p1_System_Int32;
                                    var displayedOptions = _p2_System_StringArray;
                                    var optionValues = _p3_System_Int32Array;
                                    var options = _p4_UnityEngine_GUILayoutOptionArray;
                                    var _ret0 = global::UnityEditor.EditorGUILayout.IntPopup(label, selectedValue, displayedOptions, optionValues, options);
                                    var _lret0 = new global::Lua.LuaValue(_ret0);
                                    var _retCount = _context.Return(_lret0);
                                    return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                                }
                            }
                            _lastArgPos = 4; _expectedType = typeof(global::UnityEngine.GUIStyle);
                            if (_arg4.TryRead<global::UnityEngine.GUIStyle>(out var _p4_UnityEngine_GUIStyle))
                            {
                                var _arg5 = _lastArg = _argCount > 5 ? _context.GetArgument(5) : global::Lua.LuaValue.Nil;
                                _lastArgPos = 5; _expectedType = typeof(global::UnityEngine.GUILayoutOption[]);
                                if (_arg5.TryReadArray<global::UnityEngine.GUILayoutOption>(out var _p5_UnityEngine_GUILayoutOptionArray))
                                {
                                    if (_argCount == 6)
                                    {
                                        var label = _p0_System_String;
                                        var selectedValue = _p1_System_Int32;
                                        var displayedOptions = _p2_System_StringArray;
                                        var optionValues = _p3_System_Int32Array;
                                        var style = _p4_UnityEngine_GUIStyle;
                                        var options = _p5_UnityEngine_GUILayoutOptionArray;
                                        var _ret0 = global::UnityEditor.EditorGUILayout.IntPopup(label, selectedValue, displayedOptions, optionValues, style, options);
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
            _lastArgPos = 0; _expectedType = typeof(global::UnityEngine.GUIContent);
            if (_arg0.TryRead<global::UnityEngine.GUIContent>(out var _p0_UnityEngine_GUIContent))
            {
                var _arg1 = _lastArg = _argCount > 1 ? _context.GetArgument(1) : global::Lua.LuaValue.Nil;
                _lastArgPos = 1; _expectedType = typeof(global::System.Int32);
                if (_arg1.TryRead<global::System.Int32>(out var _p1_System_Int32))
                {
                    var _arg2 = _lastArg = _argCount > 2 ? _context.GetArgument(2) : global::Lua.LuaValue.Nil;
                    _lastArgPos = 2; _expectedType = typeof(global::UnityEngine.GUIContent[]);
                    if (_arg2.TryReadArray<global::UnityEngine.GUIContent>(out var _p2_UnityEngine_GUIContentArray))
                    {
                        var _arg3 = _lastArg = _argCount > 3 ? _context.GetArgument(3) : global::Lua.LuaValue.Nil;
                        _lastArgPos = 3; _expectedType = typeof(global::System.Int32[]);
                        if (_arg3.TryReadArray<global::System.Int32>(out var _p3_System_Int32Array))
                        {
                            var _arg4 = _lastArg = _argCount > 4 ? _context.GetArgument(4) : global::Lua.LuaValue.Nil;
                            _lastArgPos = 4; _expectedType = typeof(global::UnityEngine.GUILayoutOption[]);
                            if (_arg4.TryReadArray<global::UnityEngine.GUILayoutOption>(out var _p4_UnityEngine_GUILayoutOptionArray))
                            {
                                if (_argCount == 5)
                                {
                                    var label = _p0_UnityEngine_GUIContent;
                                    var selectedValue = _p1_System_Int32;
                                    var displayedOptions = _p2_UnityEngine_GUIContentArray;
                                    var optionValues = _p3_System_Int32Array;
                                    var options = _p4_UnityEngine_GUILayoutOptionArray;
                                    var _ret0 = global::UnityEditor.EditorGUILayout.IntPopup(label, selectedValue, displayedOptions, optionValues, options);
                                    var _lret0 = new global::Lua.LuaValue(_ret0);
                                    var _retCount = _context.Return(_lret0);
                                    return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                                }
                            }
                            _lastArgPos = 4; _expectedType = typeof(global::UnityEngine.GUIStyle);
                            if (_arg4.TryRead<global::UnityEngine.GUIStyle>(out var _p4_UnityEngine_GUIStyle))
                            {
                                var _arg5 = _lastArg = _argCount > 5 ? _context.GetArgument(5) : global::Lua.LuaValue.Nil;
                                _lastArgPos = 5; _expectedType = typeof(global::UnityEngine.GUILayoutOption[]);
                                if (_arg5.TryReadArray<global::UnityEngine.GUILayoutOption>(out var _p5_UnityEngine_GUILayoutOptionArray))
                                {
                                    if (_argCount == 6)
                                    {
                                        var label = _p0_UnityEngine_GUIContent;
                                        var selectedValue = _p1_System_Int32;
                                        var displayedOptions = _p2_UnityEngine_GUIContentArray;
                                        var optionValues = _p3_System_Int32Array;
                                        var style = _p4_UnityEngine_GUIStyle;
                                        var options = _p5_UnityEngine_GUILayoutOptionArray;
                                        var _ret0 = global::UnityEditor.EditorGUILayout.IntPopup(label, selectedValue, displayedOptions, optionValues, style, options);
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
        private static readonly global::Lua.LuaFunction _LuaEditorGUILayout_IntSlider = new global::Lua.LuaFunction("IntSlider", (_context, _) =>
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
                        _lastArgPos = 3; _expectedType = typeof(global::UnityEngine.GUILayoutOption[]);
                        if (_arg3.TryReadArray<global::UnityEngine.GUILayoutOption>(out var _p3_UnityEngine_GUILayoutOptionArray))
                        {
                            if (_argCount == 4)
                            {
                                var value = _p0_System_Int32;
                                var leftValue = _p1_System_Int32;
                                var rightValue = _p2_System_Int32;
                                var options = _p3_UnityEngine_GUILayoutOptionArray;
                                var _ret0 = global::UnityEditor.EditorGUILayout.IntSlider(value, leftValue, rightValue, options);
                                var _lret0 = new global::Lua.LuaValue(_ret0);
                                var _retCount = _context.Return(_lret0);
                                return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                            }
                        }
                    }
                }
            }
            _lastArgPos = 0; _expectedType = typeof(global::Luny.UnityEditor.LuaSerializedProperty);
            if (_arg0.TryRead<global::Luny.UnityEditor.LuaSerializedProperty>(out var _p0_UnityEditor_SerializedProperty))
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
                        _lastArgPos = 3; _expectedType = typeof(global::UnityEngine.GUILayoutOption[]);
                        if (_arg3.TryReadArray<global::UnityEngine.GUILayoutOption>(out var _p3_UnityEngine_GUILayoutOptionArray))
                        {
                            if (_argCount == 4)
                            {
                                var property = _p0_UnityEditor_SerializedProperty.Instance;
                                var leftValue = _p1_System_Int32;
                                var rightValue = _p2_System_Int32;
                                var options = _p3_UnityEngine_GUILayoutOptionArray;
                                global::UnityEditor.EditorGUILayout.IntSlider(property, leftValue, rightValue, options);
                                var _retCount = _context.Return();
                                return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                            }
                        }
                        _lastArgPos = 3; _expectedType = typeof(global::System.String);
                        if (_arg3.TryRead<global::System.String>(out var _p3_System_String))
                        {
                            var _arg4 = _lastArg = _argCount > 4 ? _context.GetArgument(4) : global::Lua.LuaValue.Nil;
                            _lastArgPos = 4; _expectedType = typeof(global::UnityEngine.GUILayoutOption[]);
                            if (_arg4.TryReadArray<global::UnityEngine.GUILayoutOption>(out var _p4_UnityEngine_GUILayoutOptionArray))
                            {
                                if (_argCount == 5)
                                {
                                    var property = _p0_UnityEditor_SerializedProperty.Instance;
                                    var leftValue = _p1_System_Int32;
                                    var rightValue = _p2_System_Int32;
                                    var label = _p3_System_String;
                                    var options = _p4_UnityEngine_GUILayoutOptionArray;
                                    global::UnityEditor.EditorGUILayout.IntSlider(property, leftValue, rightValue, label, options);
                                    var _retCount = _context.Return();
                                    return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                                }
                            }
                        }
                        _lastArgPos = 3; _expectedType = typeof(global::UnityEngine.GUIContent);
                        if (_arg3.TryRead<global::UnityEngine.GUIContent>(out var _p3_UnityEngine_GUIContent))
                        {
                            var _arg4 = _lastArg = _argCount > 4 ? _context.GetArgument(4) : global::Lua.LuaValue.Nil;
                            _lastArgPos = 4; _expectedType = typeof(global::UnityEngine.GUILayoutOption[]);
                            if (_arg4.TryReadArray<global::UnityEngine.GUILayoutOption>(out var _p4_UnityEngine_GUILayoutOptionArray))
                            {
                                if (_argCount == 5)
                                {
                                    var property = _p0_UnityEditor_SerializedProperty.Instance;
                                    var leftValue = _p1_System_Int32;
                                    var rightValue = _p2_System_Int32;
                                    var label = _p3_UnityEngine_GUIContent;
                                    var options = _p4_UnityEngine_GUILayoutOptionArray;
                                    global::UnityEditor.EditorGUILayout.IntSlider(property, leftValue, rightValue, label, options);
                                    var _retCount = _context.Return();
                                    return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                                }
                            }
                        }
                    }
                }
            }
            _lastArgPos = 0; _expectedType = typeof(global::System.String);
            if (_arg0.TryRead<global::System.String>(out var _p0_System_String))
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
                            var _arg4 = _lastArg = _argCount > 4 ? _context.GetArgument(4) : global::Lua.LuaValue.Nil;
                            _lastArgPos = 4; _expectedType = typeof(global::UnityEngine.GUILayoutOption[]);
                            if (_arg4.TryReadArray<global::UnityEngine.GUILayoutOption>(out var _p4_UnityEngine_GUILayoutOptionArray))
                            {
                                if (_argCount == 5)
                                {
                                    var label = _p0_System_String;
                                    var value = _p1_System_Int32;
                                    var leftValue = _p2_System_Int32;
                                    var rightValue = _p3_System_Int32;
                                    var options = _p4_UnityEngine_GUILayoutOptionArray;
                                    var _ret0 = global::UnityEditor.EditorGUILayout.IntSlider(label, value, leftValue, rightValue, options);
                                    var _lret0 = new global::Lua.LuaValue(_ret0);
                                    var _retCount = _context.Return(_lret0);
                                    return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                                }
                            }
                        }
                    }
                }
            }
            _lastArgPos = 0; _expectedType = typeof(global::UnityEngine.GUIContent);
            if (_arg0.TryRead<global::UnityEngine.GUIContent>(out var _p0_UnityEngine_GUIContent))
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
                            var _arg4 = _lastArg = _argCount > 4 ? _context.GetArgument(4) : global::Lua.LuaValue.Nil;
                            _lastArgPos = 4; _expectedType = typeof(global::UnityEngine.GUILayoutOption[]);
                            if (_arg4.TryReadArray<global::UnityEngine.GUILayoutOption>(out var _p4_UnityEngine_GUILayoutOptionArray))
                            {
                                if (_argCount == 5)
                                {
                                    var label = _p0_UnityEngine_GUIContent;
                                    var value = _p1_System_Int32;
                                    var leftValue = _p2_System_Int32;
                                    var rightValue = _p3_System_Int32;
                                    var options = _p4_UnityEngine_GUILayoutOptionArray;
                                    var _ret0 = global::UnityEditor.EditorGUILayout.IntSlider(label, value, leftValue, rightValue, options);
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
        private static readonly global::Lua.LuaFunction _LuaEditorGUILayout_Knob = new global::Lua.LuaFunction("Knob", (_context, _) =>
        {
            global::Lua.LuaValue _lastArg = default;
            global::System.Int32 _lastArgPos = default;
            global::System.Type _expectedType = default;
            var _argCount = _context.ArgumentCount;
            var _arg0 = _lastArg = _argCount > 0 ? _context.GetArgument(0) : global::Lua.LuaValue.Nil;
            _lastArgPos = 0; _expectedType = typeof(global::UnityEngine.Vector2);
            if (_arg0.TryRead<global::UnityEngine.Vector2>(out var _p0_UnityEngine_Vector2))
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
                            var _arg4 = _lastArg = _argCount > 4 ? _context.GetArgument(4) : global::Lua.LuaValue.Nil;
                            _lastArgPos = 4; _expectedType = typeof(global::System.String);
                            if (_arg4.TryRead<global::System.String>(out var _p4_System_String))
                            {
                                var _arg5 = _lastArg = _argCount > 5 ? _context.GetArgument(5) : global::Lua.LuaValue.Nil;
                                _lastArgPos = 5; _expectedType = typeof(global::UnityEngine.Color);
                                if (_arg5.TryRead<global::UnityEngine.Color>(out var _p5_UnityEngine_Color))
                                {
                                    var _arg6 = _lastArg = _argCount > 6 ? _context.GetArgument(6) : global::Lua.LuaValue.Nil;
                                    _lastArgPos = 6; _expectedType = typeof(global::UnityEngine.Color);
                                    if (_arg6.TryRead<global::UnityEngine.Color>(out var _p6_UnityEngine_Color))
                                    {
                                        var _arg7 = _lastArg = _argCount > 7 ? _context.GetArgument(7) : global::Lua.LuaValue.Nil;
                                        _lastArgPos = 7; _expectedType = typeof(global::System.Boolean);
                                        if (_arg7.TryRead<global::System.Boolean>(out var _p7_System_Boolean))
                                        {
                                            var _arg8 = _lastArg = _argCount > 8 ? _context.GetArgument(8) : global::Lua.LuaValue.Nil;
                                            _lastArgPos = 8; _expectedType = typeof(global::UnityEngine.GUILayoutOption[]);
                                            if (_arg8.TryReadArray<global::UnityEngine.GUILayoutOption>(out var _p8_UnityEngine_GUILayoutOptionArray))
                                            {
                                                if (_argCount == 9)
                                                {
                                                    var knobSize = _p0_UnityEngine_Vector2;
                                                    var value = _p1_System_Single;
                                                    var minValue = _p2_System_Single;
                                                    var maxValue = _p3_System_Single;
                                                    var unit = _p4_System_String;
                                                    var backgroundColor = _p5_UnityEngine_Color;
                                                    var activeColor = _p6_UnityEngine_Color;
                                                    var showValue = _p7_System_Boolean;
                                                    var options = _p8_UnityEngine_GUILayoutOptionArray;
                                                    var _ret0 = global::UnityEditor.EditorGUILayout.Knob(knobSize, value, minValue, maxValue, unit, backgroundColor, activeColor, showValue, options);
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
            }
            throw new global::Lua.LuaRuntimeException(_context.Thread, $"{"Knob"}: invalid argument #{_lastArgPos}: {_lastArg} ({_lastArg.Type}), expected: {_expectedType.FullName}", 2);
        });
        private static readonly global::Lua.LuaFunction _LuaEditorGUILayout_LabelField = new global::Lua.LuaFunction("LabelField", (_context, _) =>
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
                _lastArgPos = 1; _expectedType = typeof(global::UnityEngine.GUILayoutOption[]);
                if (_arg1.TryReadArray<global::UnityEngine.GUILayoutOption>(out var _p1_UnityEngine_GUILayoutOptionArray))
                {
                    if (_argCount == 2)
                    {
                        var label = _p0_System_String;
                        var options = _p1_UnityEngine_GUILayoutOptionArray;
                        global::UnityEditor.EditorGUILayout.LabelField(label, options);
                        var _retCount = _context.Return();
                        return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                    }
                }
                _lastArgPos = 1; _expectedType = typeof(global::System.String);
                if (_arg1.TryRead<global::System.String>(out var _p1_System_String))
                {
                    var _arg2 = _lastArg = _argCount > 2 ? _context.GetArgument(2) : global::Lua.LuaValue.Nil;
                    _lastArgPos = 2; _expectedType = typeof(global::UnityEngine.GUILayoutOption[]);
                    if (_arg2.TryReadArray<global::UnityEngine.GUILayoutOption>(out var _p2_UnityEngine_GUILayoutOptionArray))
                    {
                        if (_argCount == 3)
                        {
                            var label = _p0_System_String;
                            var label2 = _p1_System_String;
                            var options = _p2_UnityEngine_GUILayoutOptionArray;
                            global::UnityEditor.EditorGUILayout.LabelField(label, label2, options);
                            var _retCount = _context.Return();
                            return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                        }
                    }
                    _lastArgPos = 2; _expectedType = typeof(global::UnityEngine.GUIStyle);
                    if (_arg2.TryRead<global::UnityEngine.GUIStyle>(out var _p2_UnityEngine_GUIStyle))
                    {
                        var _arg3 = _lastArg = _argCount > 3 ? _context.GetArgument(3) : global::Lua.LuaValue.Nil;
                        _lastArgPos = 3; _expectedType = typeof(global::UnityEngine.GUILayoutOption[]);
                        if (_arg3.TryReadArray<global::UnityEngine.GUILayoutOption>(out var _p3_UnityEngine_GUILayoutOptionArray))
                        {
                            if (_argCount == 4)
                            {
                                var label = _p0_System_String;
                                var label2 = _p1_System_String;
                                var style = _p2_UnityEngine_GUIStyle;
                                var options = _p3_UnityEngine_GUILayoutOptionArray;
                                global::UnityEditor.EditorGUILayout.LabelField(label, label2, style, options);
                                var _retCount = _context.Return();
                                return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                            }
                        }
                    }
                }
                _lastArgPos = 1; _expectedType = typeof(global::UnityEngine.GUIStyle);
                if (_arg1.TryRead<global::UnityEngine.GUIStyle>(out var _p1_UnityEngine_GUIStyle))
                {
                    var _arg2 = _lastArg = _argCount > 2 ? _context.GetArgument(2) : global::Lua.LuaValue.Nil;
                    _lastArgPos = 2; _expectedType = typeof(global::UnityEngine.GUILayoutOption[]);
                    if (_arg2.TryReadArray<global::UnityEngine.GUILayoutOption>(out var _p2_UnityEngine_GUILayoutOptionArray))
                    {
                        if (_argCount == 3)
                        {
                            var label = _p0_System_String;
                            var style = _p1_UnityEngine_GUIStyle;
                            var options = _p2_UnityEngine_GUILayoutOptionArray;
                            global::UnityEditor.EditorGUILayout.LabelField(label, style, options);
                            var _retCount = _context.Return();
                            return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                        }
                    }
                }
            }
            _lastArgPos = 0; _expectedType = typeof(global::UnityEngine.GUIContent);
            if (_arg0.TryRead<global::UnityEngine.GUIContent>(out var _p0_UnityEngine_GUIContent))
            {
                var _arg1 = _lastArg = _argCount > 1 ? _context.GetArgument(1) : global::Lua.LuaValue.Nil;
                _lastArgPos = 1; _expectedType = typeof(global::UnityEngine.GUILayoutOption[]);
                if (_arg1.TryReadArray<global::UnityEngine.GUILayoutOption>(out var _p1_UnityEngine_GUILayoutOptionArray))
                {
                    if (_argCount == 2)
                    {
                        var label = _p0_UnityEngine_GUIContent;
                        var options = _p1_UnityEngine_GUILayoutOptionArray;
                        global::UnityEditor.EditorGUILayout.LabelField(label, options);
                        var _retCount = _context.Return();
                        return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                    }
                }
                _lastArgPos = 1; _expectedType = typeof(global::UnityEngine.GUIStyle);
                if (_arg1.TryRead<global::UnityEngine.GUIStyle>(out var _p1_UnityEngine_GUIStyle))
                {
                    var _arg2 = _lastArg = _argCount > 2 ? _context.GetArgument(2) : global::Lua.LuaValue.Nil;
                    _lastArgPos = 2; _expectedType = typeof(global::UnityEngine.GUILayoutOption[]);
                    if (_arg2.TryReadArray<global::UnityEngine.GUILayoutOption>(out var _p2_UnityEngine_GUILayoutOptionArray))
                    {
                        if (_argCount == 3)
                        {
                            var label = _p0_UnityEngine_GUIContent;
                            var style = _p1_UnityEngine_GUIStyle;
                            var options = _p2_UnityEngine_GUILayoutOptionArray;
                            global::UnityEditor.EditorGUILayout.LabelField(label, style, options);
                            var _retCount = _context.Return();
                            return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                        }
                    }
                }
                _lastArgPos = 1; _expectedType = typeof(global::UnityEngine.GUIContent);
                if (_arg1.TryRead<global::UnityEngine.GUIContent>(out var _p1_UnityEngine_GUIContent))
                {
                    var _arg2 = _lastArg = _argCount > 2 ? _context.GetArgument(2) : global::Lua.LuaValue.Nil;
                    _lastArgPos = 2; _expectedType = typeof(global::UnityEngine.GUILayoutOption[]);
                    if (_arg2.TryReadArray<global::UnityEngine.GUILayoutOption>(out var _p2_UnityEngine_GUILayoutOptionArray))
                    {
                        if (_argCount == 3)
                        {
                            var label = _p0_UnityEngine_GUIContent;
                            var label2 = _p1_UnityEngine_GUIContent;
                            var options = _p2_UnityEngine_GUILayoutOptionArray;
                            global::UnityEditor.EditorGUILayout.LabelField(label, label2, options);
                            var _retCount = _context.Return();
                            return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                        }
                    }
                    _lastArgPos = 2; _expectedType = typeof(global::UnityEngine.GUIStyle);
                    if (_arg2.TryRead<global::UnityEngine.GUIStyle>(out var _p2_UnityEngine_GUIStyle))
                    {
                        var _arg3 = _lastArg = _argCount > 3 ? _context.GetArgument(3) : global::Lua.LuaValue.Nil;
                        _lastArgPos = 3; _expectedType = typeof(global::UnityEngine.GUILayoutOption[]);
                        if (_arg3.TryReadArray<global::UnityEngine.GUILayoutOption>(out var _p3_UnityEngine_GUILayoutOptionArray))
                        {
                            if (_argCount == 4)
                            {
                                var label = _p0_UnityEngine_GUIContent;
                                var label2 = _p1_UnityEngine_GUIContent;
                                var style = _p2_UnityEngine_GUIStyle;
                                var options = _p3_UnityEngine_GUILayoutOptionArray;
                                global::UnityEditor.EditorGUILayout.LabelField(label, label2, style, options);
                                var _retCount = _context.Return();
                                return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                            }
                        }
                    }
                }
            }
            throw new global::Lua.LuaRuntimeException(_context.Thread, $"{"LabelField"}: invalid argument #{_lastArgPos}: {_lastArg} ({_lastArg.Type}), expected: {_expectedType.FullName}", 2);
        });
        private static readonly global::Lua.LuaFunction _LuaEditorGUILayout_LayerField = new global::Lua.LuaFunction("LayerField", (_context, _) =>
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
                _lastArgPos = 1; _expectedType = typeof(global::UnityEngine.GUILayoutOption[]);
                if (_arg1.TryReadArray<global::UnityEngine.GUILayoutOption>(out var _p1_UnityEngine_GUILayoutOptionArray))
                {
                    if (_argCount == 2)
                    {
                        var layer = _p0_System_Int32;
                        var options = _p1_UnityEngine_GUILayoutOptionArray;
                        var _ret0 = global::UnityEditor.EditorGUILayout.LayerField(layer, options);
                        var _lret0 = new global::Lua.LuaValue(_ret0);
                        var _retCount = _context.Return(_lret0);
                        return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                    }
                }
                _lastArgPos = 1; _expectedType = typeof(global::UnityEngine.GUIStyle);
                if (_arg1.TryRead<global::UnityEngine.GUIStyle>(out var _p1_UnityEngine_GUIStyle))
                {
                    var _arg2 = _lastArg = _argCount > 2 ? _context.GetArgument(2) : global::Lua.LuaValue.Nil;
                    _lastArgPos = 2; _expectedType = typeof(global::UnityEngine.GUILayoutOption[]);
                    if (_arg2.TryReadArray<global::UnityEngine.GUILayoutOption>(out var _p2_UnityEngine_GUILayoutOptionArray))
                    {
                        if (_argCount == 3)
                        {
                            var layer = _p0_System_Int32;
                            var style = _p1_UnityEngine_GUIStyle;
                            var options = _p2_UnityEngine_GUILayoutOptionArray;
                            var _ret0 = global::UnityEditor.EditorGUILayout.LayerField(layer, style, options);
                            var _lret0 = new global::Lua.LuaValue(_ret0);
                            var _retCount = _context.Return(_lret0);
                            return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                        }
                    }
                }
            }
            _lastArgPos = 0; _expectedType = typeof(global::System.String);
            if (_arg0.TryRead<global::System.String>(out var _p0_System_String))
            {
                var _arg1 = _lastArg = _argCount > 1 ? _context.GetArgument(1) : global::Lua.LuaValue.Nil;
                _lastArgPos = 1; _expectedType = typeof(global::System.Int32);
                if (_arg1.TryRead<global::System.Int32>(out var _p1_System_Int32))
                {
                    var _arg2 = _lastArg = _argCount > 2 ? _context.GetArgument(2) : global::Lua.LuaValue.Nil;
                    _lastArgPos = 2; _expectedType = typeof(global::UnityEngine.GUILayoutOption[]);
                    if (_arg2.TryReadArray<global::UnityEngine.GUILayoutOption>(out var _p2_UnityEngine_GUILayoutOptionArray))
                    {
                        if (_argCount == 3)
                        {
                            var label = _p0_System_String;
                            var layer = _p1_System_Int32;
                            var options = _p2_UnityEngine_GUILayoutOptionArray;
                            var _ret0 = global::UnityEditor.EditorGUILayout.LayerField(label, layer, options);
                            var _lret0 = new global::Lua.LuaValue(_ret0);
                            var _retCount = _context.Return(_lret0);
                            return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                        }
                    }
                    _lastArgPos = 2; _expectedType = typeof(global::UnityEngine.GUIStyle);
                    if (_arg2.TryRead<global::UnityEngine.GUIStyle>(out var _p2_UnityEngine_GUIStyle))
                    {
                        var _arg3 = _lastArg = _argCount > 3 ? _context.GetArgument(3) : global::Lua.LuaValue.Nil;
                        _lastArgPos = 3; _expectedType = typeof(global::UnityEngine.GUILayoutOption[]);
                        if (_arg3.TryReadArray<global::UnityEngine.GUILayoutOption>(out var _p3_UnityEngine_GUILayoutOptionArray))
                        {
                            if (_argCount == 4)
                            {
                                var label = _p0_System_String;
                                var layer = _p1_System_Int32;
                                var style = _p2_UnityEngine_GUIStyle;
                                var options = _p3_UnityEngine_GUILayoutOptionArray;
                                var _ret0 = global::UnityEditor.EditorGUILayout.LayerField(label, layer, style, options);
                                var _lret0 = new global::Lua.LuaValue(_ret0);
                                var _retCount = _context.Return(_lret0);
                                return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                            }
                        }
                    }
                }
            }
            _lastArgPos = 0; _expectedType = typeof(global::UnityEngine.GUIContent);
            if (_arg0.TryRead<global::UnityEngine.GUIContent>(out var _p0_UnityEngine_GUIContent))
            {
                var _arg1 = _lastArg = _argCount > 1 ? _context.GetArgument(1) : global::Lua.LuaValue.Nil;
                _lastArgPos = 1; _expectedType = typeof(global::System.Int32);
                if (_arg1.TryRead<global::System.Int32>(out var _p1_System_Int32))
                {
                    var _arg2 = _lastArg = _argCount > 2 ? _context.GetArgument(2) : global::Lua.LuaValue.Nil;
                    _lastArgPos = 2; _expectedType = typeof(global::UnityEngine.GUILayoutOption[]);
                    if (_arg2.TryReadArray<global::UnityEngine.GUILayoutOption>(out var _p2_UnityEngine_GUILayoutOptionArray))
                    {
                        if (_argCount == 3)
                        {
                            var label = _p0_UnityEngine_GUIContent;
                            var layer = _p1_System_Int32;
                            var options = _p2_UnityEngine_GUILayoutOptionArray;
                            var _ret0 = global::UnityEditor.EditorGUILayout.LayerField(label, layer, options);
                            var _lret0 = new global::Lua.LuaValue(_ret0);
                            var _retCount = _context.Return(_lret0);
                            return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                        }
                    }
                    _lastArgPos = 2; _expectedType = typeof(global::UnityEngine.GUIStyle);
                    if (_arg2.TryRead<global::UnityEngine.GUIStyle>(out var _p2_UnityEngine_GUIStyle))
                    {
                        var _arg3 = _lastArg = _argCount > 3 ? _context.GetArgument(3) : global::Lua.LuaValue.Nil;
                        _lastArgPos = 3; _expectedType = typeof(global::UnityEngine.GUILayoutOption[]);
                        if (_arg3.TryReadArray<global::UnityEngine.GUILayoutOption>(out var _p3_UnityEngine_GUILayoutOptionArray))
                        {
                            if (_argCount == 4)
                            {
                                var label = _p0_UnityEngine_GUIContent;
                                var layer = _p1_System_Int32;
                                var style = _p2_UnityEngine_GUIStyle;
                                var options = _p3_UnityEngine_GUILayoutOptionArray;
                                var _ret0 = global::UnityEditor.EditorGUILayout.LayerField(label, layer, style, options);
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
        private static readonly global::Lua.LuaFunction _LuaEditorGUILayout_LinkButton = new global::Lua.LuaFunction("LinkButton", (_context, _) =>
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
                _lastArgPos = 1; _expectedType = typeof(global::UnityEngine.GUILayoutOption[]);
                if (_arg1.TryReadArray<global::UnityEngine.GUILayoutOption>(out var _p1_UnityEngine_GUILayoutOptionArray))
                {
                    if (_argCount == 2)
                    {
                        var label = _p0_System_String;
                        var options = _p1_UnityEngine_GUILayoutOptionArray;
                        var _ret0 = global::UnityEditor.EditorGUILayout.LinkButton(label, options);
                        var _lret0 = new global::Lua.LuaValue(_ret0);
                        var _retCount = _context.Return(_lret0);
                        return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                    }
                }
            }
            _lastArgPos = 0; _expectedType = typeof(global::UnityEngine.GUIContent);
            if (_arg0.TryRead<global::UnityEngine.GUIContent>(out var _p0_UnityEngine_GUIContent))
            {
                var _arg1 = _lastArg = _argCount > 1 ? _context.GetArgument(1) : global::Lua.LuaValue.Nil;
                _lastArgPos = 1; _expectedType = typeof(global::UnityEngine.GUILayoutOption[]);
                if (_arg1.TryReadArray<global::UnityEngine.GUILayoutOption>(out var _p1_UnityEngine_GUILayoutOptionArray))
                {
                    if (_argCount == 2)
                    {
                        var label = _p0_UnityEngine_GUIContent;
                        var options = _p1_UnityEngine_GUILayoutOptionArray;
                        var _ret0 = global::UnityEditor.EditorGUILayout.LinkButton(label, options);
                        var _lret0 = new global::Lua.LuaValue(_ret0);
                        var _retCount = _context.Return(_lret0);
                        return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                    }
                }
            }
            throw new global::Lua.LuaRuntimeException(_context.Thread, $"{"LinkButton"}: invalid argument #{_lastArgPos}: {_lastArg} ({_lastArg.Type}), expected: {_expectedType.FullName}", 2);
        });
        private static readonly global::Lua.LuaFunction _LuaEditorGUILayout_LongField = new global::Lua.LuaFunction("LongField", (_context, _) =>
        {
            global::Lua.LuaValue _lastArg = default;
            global::System.Int32 _lastArgPos = default;
            global::System.Type _expectedType = default;
            var _argCount = _context.ArgumentCount;
            var _arg0 = _lastArg = _argCount > 0 ? _context.GetArgument(0) : global::Lua.LuaValue.Nil;
            _lastArgPos = 0; _expectedType = typeof(global::System.Int64);
            if (_arg0.TryRead<global::System.Int64>(out var _p0_System_Int64))
            {
                var _arg1 = _lastArg = _argCount > 1 ? _context.GetArgument(1) : global::Lua.LuaValue.Nil;
                _lastArgPos = 1; _expectedType = typeof(global::UnityEngine.GUILayoutOption[]);
                if (_arg1.TryReadArray<global::UnityEngine.GUILayoutOption>(out var _p1_UnityEngine_GUILayoutOptionArray))
                {
                    if (_argCount == 2)
                    {
                        var value = _p0_System_Int64;
                        var options = _p1_UnityEngine_GUILayoutOptionArray;
                        var _ret0 = global::UnityEditor.EditorGUILayout.LongField(value, options);
                        var _lret0 = new global::Lua.LuaValue(_ret0);
                        var _retCount = _context.Return(_lret0);
                        return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                    }
                }
                _lastArgPos = 1; _expectedType = typeof(global::UnityEngine.GUIStyle);
                if (_arg1.TryRead<global::UnityEngine.GUIStyle>(out var _p1_UnityEngine_GUIStyle))
                {
                    var _arg2 = _lastArg = _argCount > 2 ? _context.GetArgument(2) : global::Lua.LuaValue.Nil;
                    _lastArgPos = 2; _expectedType = typeof(global::UnityEngine.GUILayoutOption[]);
                    if (_arg2.TryReadArray<global::UnityEngine.GUILayoutOption>(out var _p2_UnityEngine_GUILayoutOptionArray))
                    {
                        if (_argCount == 3)
                        {
                            var value = _p0_System_Int64;
                            var style = _p1_UnityEngine_GUIStyle;
                            var options = _p2_UnityEngine_GUILayoutOptionArray;
                            var _ret0 = global::UnityEditor.EditorGUILayout.LongField(value, style, options);
                            var _lret0 = new global::Lua.LuaValue(_ret0);
                            var _retCount = _context.Return(_lret0);
                            return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                        }
                    }
                }
            }
            _lastArgPos = 0; _expectedType = typeof(global::System.String);
            if (_arg0.TryRead<global::System.String>(out var _p0_System_String))
            {
                var _arg1 = _lastArg = _argCount > 1 ? _context.GetArgument(1) : global::Lua.LuaValue.Nil;
                _lastArgPos = 1; _expectedType = typeof(global::System.Int64);
                if (_arg1.TryRead<global::System.Int64>(out var _p1_System_Int64))
                {
                    var _arg2 = _lastArg = _argCount > 2 ? _context.GetArgument(2) : global::Lua.LuaValue.Nil;
                    _lastArgPos = 2; _expectedType = typeof(global::UnityEngine.GUILayoutOption[]);
                    if (_arg2.TryReadArray<global::UnityEngine.GUILayoutOption>(out var _p2_UnityEngine_GUILayoutOptionArray))
                    {
                        if (_argCount == 3)
                        {
                            var label = _p0_System_String;
                            var value = _p1_System_Int64;
                            var options = _p2_UnityEngine_GUILayoutOptionArray;
                            var _ret0 = global::UnityEditor.EditorGUILayout.LongField(label, value, options);
                            var _lret0 = new global::Lua.LuaValue(_ret0);
                            var _retCount = _context.Return(_lret0);
                            return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                        }
                    }
                    _lastArgPos = 2; _expectedType = typeof(global::UnityEngine.GUIStyle);
                    if (_arg2.TryRead<global::UnityEngine.GUIStyle>(out var _p2_UnityEngine_GUIStyle))
                    {
                        var _arg3 = _lastArg = _argCount > 3 ? _context.GetArgument(3) : global::Lua.LuaValue.Nil;
                        _lastArgPos = 3; _expectedType = typeof(global::UnityEngine.GUILayoutOption[]);
                        if (_arg3.TryReadArray<global::UnityEngine.GUILayoutOption>(out var _p3_UnityEngine_GUILayoutOptionArray))
                        {
                            if (_argCount == 4)
                            {
                                var label = _p0_System_String;
                                var value = _p1_System_Int64;
                                var style = _p2_UnityEngine_GUIStyle;
                                var options = _p3_UnityEngine_GUILayoutOptionArray;
                                var _ret0 = global::UnityEditor.EditorGUILayout.LongField(label, value, style, options);
                                var _lret0 = new global::Lua.LuaValue(_ret0);
                                var _retCount = _context.Return(_lret0);
                                return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                            }
                        }
                    }
                }
            }
            _lastArgPos = 0; _expectedType = typeof(global::UnityEngine.GUIContent);
            if (_arg0.TryRead<global::UnityEngine.GUIContent>(out var _p0_UnityEngine_GUIContent))
            {
                var _arg1 = _lastArg = _argCount > 1 ? _context.GetArgument(1) : global::Lua.LuaValue.Nil;
                _lastArgPos = 1; _expectedType = typeof(global::System.Int64);
                if (_arg1.TryRead<global::System.Int64>(out var _p1_System_Int64))
                {
                    var _arg2 = _lastArg = _argCount > 2 ? _context.GetArgument(2) : global::Lua.LuaValue.Nil;
                    _lastArgPos = 2; _expectedType = typeof(global::UnityEngine.GUILayoutOption[]);
                    if (_arg2.TryReadArray<global::UnityEngine.GUILayoutOption>(out var _p2_UnityEngine_GUILayoutOptionArray))
                    {
                        if (_argCount == 3)
                        {
                            var label = _p0_UnityEngine_GUIContent;
                            var value = _p1_System_Int64;
                            var options = _p2_UnityEngine_GUILayoutOptionArray;
                            var _ret0 = global::UnityEditor.EditorGUILayout.LongField(label, value, options);
                            var _lret0 = new global::Lua.LuaValue(_ret0);
                            var _retCount = _context.Return(_lret0);
                            return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                        }
                    }
                    _lastArgPos = 2; _expectedType = typeof(global::UnityEngine.GUIStyle);
                    if (_arg2.TryRead<global::UnityEngine.GUIStyle>(out var _p2_UnityEngine_GUIStyle))
                    {
                        var _arg3 = _lastArg = _argCount > 3 ? _context.GetArgument(3) : global::Lua.LuaValue.Nil;
                        _lastArgPos = 3; _expectedType = typeof(global::UnityEngine.GUILayoutOption[]);
                        if (_arg3.TryReadArray<global::UnityEngine.GUILayoutOption>(out var _p3_UnityEngine_GUILayoutOptionArray))
                        {
                            if (_argCount == 4)
                            {
                                var label = _p0_UnityEngine_GUIContent;
                                var value = _p1_System_Int64;
                                var style = _p2_UnityEngine_GUIStyle;
                                var options = _p3_UnityEngine_GUILayoutOptionArray;
                                var _ret0 = global::UnityEditor.EditorGUILayout.LongField(label, value, style, options);
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
        private static readonly global::Lua.LuaFunction _LuaEditorGUILayout_MaskField = new global::Lua.LuaFunction("MaskField", (_context, _) =>
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
                _lastArgPos = 1; _expectedType = typeof(global::System.String[]);
                if (_arg1.TryReadArray<global::System.String>(out var _p1_System_StringArray))
                {
                    var _arg2 = _lastArg = _argCount > 2 ? _context.GetArgument(2) : global::Lua.LuaValue.Nil;
                    _lastArgPos = 2; _expectedType = typeof(global::UnityEngine.GUILayoutOption[]);
                    if (_arg2.TryReadArray<global::UnityEngine.GUILayoutOption>(out var _p2_UnityEngine_GUILayoutOptionArray))
                    {
                        if (_argCount == 3)
                        {
                            var mask = _p0_System_Int32;
                            var displayedOptions = _p1_System_StringArray;
                            var options = _p2_UnityEngine_GUILayoutOptionArray;
                            var _ret0 = global::UnityEditor.EditorGUILayout.MaskField(mask, displayedOptions, options);
                            var _lret0 = new global::Lua.LuaValue(_ret0);
                            var _retCount = _context.Return(_lret0);
                            return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                        }
                    }
                    _lastArgPos = 2; _expectedType = typeof(global::UnityEngine.GUIStyle);
                    if (_arg2.TryRead<global::UnityEngine.GUIStyle>(out var _p2_UnityEngine_GUIStyle))
                    {
                        var _arg3 = _lastArg = _argCount > 3 ? _context.GetArgument(3) : global::Lua.LuaValue.Nil;
                        _lastArgPos = 3; _expectedType = typeof(global::UnityEngine.GUILayoutOption[]);
                        if (_arg3.TryReadArray<global::UnityEngine.GUILayoutOption>(out var _p3_UnityEngine_GUILayoutOptionArray))
                        {
                            if (_argCount == 4)
                            {
                                var mask = _p0_System_Int32;
                                var displayedOptions = _p1_System_StringArray;
                                var style = _p2_UnityEngine_GUIStyle;
                                var options = _p3_UnityEngine_GUILayoutOptionArray;
                                var _ret0 = global::UnityEditor.EditorGUILayout.MaskField(mask, displayedOptions, style, options);
                                var _lret0 = new global::Lua.LuaValue(_ret0);
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
                var _arg1 = _lastArg = _argCount > 1 ? _context.GetArgument(1) : global::Lua.LuaValue.Nil;
                _lastArgPos = 1; _expectedType = typeof(global::System.Int32);
                if (_arg1.TryRead<global::System.Int32>(out var _p1_System_Int32))
                {
                    var _arg2 = _lastArg = _argCount > 2 ? _context.GetArgument(2) : global::Lua.LuaValue.Nil;
                    _lastArgPos = 2; _expectedType = typeof(global::System.String[]);
                    if (_arg2.TryReadArray<global::System.String>(out var _p2_System_StringArray))
                    {
                        var _arg3 = _lastArg = _argCount > 3 ? _context.GetArgument(3) : global::Lua.LuaValue.Nil;
                        _lastArgPos = 3; _expectedType = typeof(global::UnityEngine.GUILayoutOption[]);
                        if (_arg3.TryReadArray<global::UnityEngine.GUILayoutOption>(out var _p3_UnityEngine_GUILayoutOptionArray))
                        {
                            if (_argCount == 4)
                            {
                                var label = _p0_System_String;
                                var mask = _p1_System_Int32;
                                var displayedOptions = _p2_System_StringArray;
                                var options = _p3_UnityEngine_GUILayoutOptionArray;
                                var _ret0 = global::UnityEditor.EditorGUILayout.MaskField(label, mask, displayedOptions, options);
                                var _lret0 = new global::Lua.LuaValue(_ret0);
                                var _retCount = _context.Return(_lret0);
                                return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                            }
                        }
                        _lastArgPos = 3; _expectedType = typeof(global::UnityEngine.GUIStyle);
                        if (_arg3.TryRead<global::UnityEngine.GUIStyle>(out var _p3_UnityEngine_GUIStyle))
                        {
                            var _arg4 = _lastArg = _argCount > 4 ? _context.GetArgument(4) : global::Lua.LuaValue.Nil;
                            _lastArgPos = 4; _expectedType = typeof(global::UnityEngine.GUILayoutOption[]);
                            if (_arg4.TryReadArray<global::UnityEngine.GUILayoutOption>(out var _p4_UnityEngine_GUILayoutOptionArray))
                            {
                                if (_argCount == 5)
                                {
                                    var label = _p0_System_String;
                                    var mask = _p1_System_Int32;
                                    var displayedOptions = _p2_System_StringArray;
                                    var style = _p3_UnityEngine_GUIStyle;
                                    var options = _p4_UnityEngine_GUILayoutOptionArray;
                                    var _ret0 = global::UnityEditor.EditorGUILayout.MaskField(label, mask, displayedOptions, style, options);
                                    var _lret0 = new global::Lua.LuaValue(_ret0);
                                    var _retCount = _context.Return(_lret0);
                                    return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                                }
                            }
                        }
                    }
                }
            }
            _lastArgPos = 0; _expectedType = typeof(global::UnityEngine.GUIContent);
            if (_arg0.TryRead<global::UnityEngine.GUIContent>(out var _p0_UnityEngine_GUIContent))
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
                        _lastArgPos = 3; _expectedType = typeof(global::UnityEngine.GUILayoutOption[]);
                        if (_arg3.TryReadArray<global::UnityEngine.GUILayoutOption>(out var _p3_UnityEngine_GUILayoutOptionArray))
                        {
                            if (_argCount == 4)
                            {
                                var label = _p0_UnityEngine_GUIContent;
                                var mask = _p1_System_Int32;
                                var displayedOptions = _p2_System_StringArray;
                                var options = _p3_UnityEngine_GUILayoutOptionArray;
                                var _ret0 = global::UnityEditor.EditorGUILayout.MaskField(label, mask, displayedOptions, options);
                                var _lret0 = new global::Lua.LuaValue(_ret0);
                                var _retCount = _context.Return(_lret0);
                                return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                            }
                        }
                        _lastArgPos = 3; _expectedType = typeof(global::UnityEngine.GUIStyle);
                        if (_arg3.TryRead<global::UnityEngine.GUIStyle>(out var _p3_UnityEngine_GUIStyle))
                        {
                            var _arg4 = _lastArg = _argCount > 4 ? _context.GetArgument(4) : global::Lua.LuaValue.Nil;
                            _lastArgPos = 4; _expectedType = typeof(global::UnityEngine.GUILayoutOption[]);
                            if (_arg4.TryReadArray<global::UnityEngine.GUILayoutOption>(out var _p4_UnityEngine_GUILayoutOptionArray))
                            {
                                if (_argCount == 5)
                                {
                                    var label = _p0_UnityEngine_GUIContent;
                                    var mask = _p1_System_Int32;
                                    var displayedOptions = _p2_System_StringArray;
                                    var style = _p3_UnityEngine_GUIStyle;
                                    var options = _p4_UnityEngine_GUILayoutOptionArray;
                                    var _ret0 = global::UnityEditor.EditorGUILayout.MaskField(label, mask, displayedOptions, style, options);
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
        private static readonly global::Lua.LuaFunction _LuaEditorGUILayout_ObjectField = new global::Lua.LuaFunction("ObjectField", (_context, _) =>
        {
            global::Lua.LuaValue _lastArg = default;
            global::System.Int32 _lastArgPos = default;
            global::System.Type _expectedType = default;
            var _argCount = _context.ArgumentCount;
            var _arg0 = _lastArg = _argCount > 0 ? _context.GetArgument(0) : global::Lua.LuaValue.Nil;
            _lastArgPos = 0; _expectedType = typeof(global::Luny.UnityEditor.LuaSerializedProperty);
            if (_arg0.TryRead<global::Luny.UnityEditor.LuaSerializedProperty>(out var _p0_UnityEditor_SerializedProperty))
            {
                var _arg1 = _lastArg = _argCount > 1 ? _context.GetArgument(1) : global::Lua.LuaValue.Nil;
                _lastArgPos = 1; _expectedType = typeof(global::UnityEngine.GUILayoutOption[]);
                if (_arg1.TryReadArray<global::UnityEngine.GUILayoutOption>(out var _p1_UnityEngine_GUILayoutOptionArray))
                {
                    if (_argCount == 2)
                    {
                        var property = _p0_UnityEditor_SerializedProperty.Instance;
                        var options = _p1_UnityEngine_GUILayoutOptionArray;
                        global::UnityEditor.EditorGUILayout.ObjectField(property, options);
                        var _retCount = _context.Return();
                        return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                    }
                }
                _lastArgPos = 1; _expectedType = typeof(global::UnityEngine.GUIContent);
                if (_arg1.TryRead<global::UnityEngine.GUIContent>(out var _p1_UnityEngine_GUIContent))
                {
                    var _arg2 = _lastArg = _argCount > 2 ? _context.GetArgument(2) : global::Lua.LuaValue.Nil;
                    _lastArgPos = 2; _expectedType = typeof(global::UnityEngine.GUILayoutOption[]);
                    if (_arg2.TryReadArray<global::UnityEngine.GUILayoutOption>(out var _p2_UnityEngine_GUILayoutOptionArray))
                    {
                        if (_argCount == 3)
                        {
                            var property = _p0_UnityEditor_SerializedProperty.Instance;
                            var label = _p1_UnityEngine_GUIContent;
                            var options = _p2_UnityEngine_GUILayoutOptionArray;
                            global::UnityEditor.EditorGUILayout.ObjectField(property, label, options);
                            var _retCount = _context.Return();
                            return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                        }
                    }
                }
                _lastArgPos = 1; _expectedType = typeof(global::Luny.ILuaBindType);
                if (_arg1.TryRead<global::Luny.ILuaBindType>(out var _p1_System_Type))
                {
                    var _arg2 = _lastArg = _argCount > 2 ? _context.GetArgument(2) : global::Lua.LuaValue.Nil;
                    _lastArgPos = 2; _expectedType = typeof(global::UnityEngine.GUILayoutOption[]);
                    if (_arg2.TryReadArray<global::UnityEngine.GUILayoutOption>(out var _p2_UnityEngine_GUILayoutOptionArray))
                    {
                        if (_argCount == 3)
                        {
                            var property = _p0_UnityEditor_SerializedProperty.Instance;
                            var objType = _p1_System_Type.BindType;
                            var options = _p2_UnityEngine_GUILayoutOptionArray;
                            global::UnityEditor.EditorGUILayout.ObjectField(property, objType, options);
                            var _retCount = _context.Return();
                            return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                        }
                    }
                    _lastArgPos = 2; _expectedType = typeof(global::UnityEngine.GUIContent);
                    if (_arg2.TryRead<global::UnityEngine.GUIContent>(out var _p2_UnityEngine_GUIContent))
                    {
                        var _arg3 = _lastArg = _argCount > 3 ? _context.GetArgument(3) : global::Lua.LuaValue.Nil;
                        _lastArgPos = 3; _expectedType = typeof(global::UnityEngine.GUILayoutOption[]);
                        if (_arg3.TryReadArray<global::UnityEngine.GUILayoutOption>(out var _p3_UnityEngine_GUILayoutOptionArray))
                        {
                            if (_argCount == 4)
                            {
                                var property = _p0_UnityEditor_SerializedProperty.Instance;
                                var objType = _p1_System_Type.BindType;
                                var label = _p2_UnityEngine_GUIContent;
                                var options = _p3_UnityEngine_GUILayoutOptionArray;
                                global::UnityEditor.EditorGUILayout.ObjectField(property, objType, label, options);
                                var _retCount = _context.Return();
                                return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                            }
                        }
                    }
                }
            }
            _lastArgPos = 0; _expectedType = typeof(global::UnityEngine.Object);
            if (_arg0.TryRead<global::UnityEngine.Object>(out var _p0_UnityEngine_Object))
            {
                var _arg1 = _lastArg = _argCount > 1 ? _context.GetArgument(1) : global::Lua.LuaValue.Nil;
                _lastArgPos = 1; _expectedType = typeof(global::Luny.ILuaBindType);
                if (_arg1.TryRead<global::Luny.ILuaBindType>(out var _p1_System_Type))
                {
                    var _arg2 = _lastArg = _argCount > 2 ? _context.GetArgument(2) : global::Lua.LuaValue.Nil;
                    _lastArgPos = 2; _expectedType = typeof(global::System.Boolean);
                    if (_arg2.TryRead<global::System.Boolean>(out var _p2_System_Boolean))
                    {
                        var _arg3 = _lastArg = _argCount > 3 ? _context.GetArgument(3) : global::Lua.LuaValue.Nil;
                        _lastArgPos = 3; _expectedType = typeof(global::UnityEngine.GUILayoutOption[]);
                        if (_arg3.TryReadArray<global::UnityEngine.GUILayoutOption>(out var _p3_UnityEngine_GUILayoutOptionArray))
                        {
                            if (_argCount == 4)
                            {
                                var obj = _p0_UnityEngine_Object;
                                var objType = _p1_System_Type.BindType;
                                var allowSceneObjects = _p2_System_Boolean;
                                var options = _p3_UnityEngine_GUILayoutOptionArray;
                                var _ret0 = global::UnityEditor.EditorGUILayout.ObjectField(obj, objType, allowSceneObjects, options);
                                var _factory = _context.GetObjectFactory();
                                var _lret0 = _factory.Bind(_ret0);
                                var _retCount = _context.Return(_lret0);
                                return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                            }
                        }
                    }
                    _lastArgPos = 2; _expectedType = typeof(global::UnityEngine.Object);
                    if (_arg2.TryRead<global::UnityEngine.Object>(out var _p2_UnityEngine_Object))
                    {
                        var _arg3 = _lastArg = _argCount > 3 ? _context.GetArgument(3) : global::Lua.LuaValue.Nil;
                        _lastArgPos = 3; _expectedType = typeof(global::UnityEngine.GUILayoutOption[]);
                        if (_arg3.TryReadArray<global::UnityEngine.GUILayoutOption>(out var _p3_UnityEngine_GUILayoutOptionArray))
                        {
                            if (_argCount == 4)
                            {
                                var obj = _p0_UnityEngine_Object;
                                var objType = _p1_System_Type.BindType;
                                var targetBeingEdited = _p2_UnityEngine_Object;
                                var options = _p3_UnityEngine_GUILayoutOptionArray;
                                var _ret0 = global::UnityEditor.EditorGUILayout.ObjectField(obj, objType, targetBeingEdited, options);
                                var _factory = _context.GetObjectFactory();
                                var _lret0 = _factory.Bind(_ret0);
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
                var _arg1 = _lastArg = _argCount > 1 ? _context.GetArgument(1) : global::Lua.LuaValue.Nil;
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
                            var _arg4 = _lastArg = _argCount > 4 ? _context.GetArgument(4) : global::Lua.LuaValue.Nil;
                            _lastArgPos = 4; _expectedType = typeof(global::UnityEngine.GUILayoutOption[]);
                            if (_arg4.TryReadArray<global::UnityEngine.GUILayoutOption>(out var _p4_UnityEngine_GUILayoutOptionArray))
                            {
                                if (_argCount == 5)
                                {
                                    var label = _p0_System_String;
                                    var obj = _p1_UnityEngine_Object;
                                    var objType = _p2_System_Type.BindType;
                                    var allowSceneObjects = _p3_System_Boolean;
                                    var options = _p4_UnityEngine_GUILayoutOptionArray;
                                    var _ret0 = global::UnityEditor.EditorGUILayout.ObjectField(label, obj, objType, allowSceneObjects, options);
                                    var _factory = _context.GetObjectFactory();
                                    var _lret0 = _factory.Bind(_ret0);
                                    var _retCount = _context.Return(_lret0);
                                    return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                                }
                            }
                        }
                        _lastArgPos = 3; _expectedType = typeof(global::UnityEngine.Object);
                        if (_arg3.TryRead<global::UnityEngine.Object>(out var _p3_UnityEngine_Object))
                        {
                            var _arg4 = _lastArg = _argCount > 4 ? _context.GetArgument(4) : global::Lua.LuaValue.Nil;
                            _lastArgPos = 4; _expectedType = typeof(global::UnityEngine.GUILayoutOption[]);
                            if (_arg4.TryReadArray<global::UnityEngine.GUILayoutOption>(out var _p4_UnityEngine_GUILayoutOptionArray))
                            {
                                if (_argCount == 5)
                                {
                                    var label = _p0_System_String;
                                    var obj = _p1_UnityEngine_Object;
                                    var objType = _p2_System_Type.BindType;
                                    var targetBeingEdited = _p3_UnityEngine_Object;
                                    var options = _p4_UnityEngine_GUILayoutOptionArray;
                                    var _ret0 = global::UnityEditor.EditorGUILayout.ObjectField(label, obj, objType, targetBeingEdited, options);
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
            _lastArgPos = 0; _expectedType = typeof(global::UnityEngine.GUIContent);
            if (_arg0.TryRead<global::UnityEngine.GUIContent>(out var _p0_UnityEngine_GUIContent))
            {
                var _arg1 = _lastArg = _argCount > 1 ? _context.GetArgument(1) : global::Lua.LuaValue.Nil;
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
                            var _arg4 = _lastArg = _argCount > 4 ? _context.GetArgument(4) : global::Lua.LuaValue.Nil;
                            _lastArgPos = 4; _expectedType = typeof(global::UnityEngine.GUILayoutOption[]);
                            if (_arg4.TryReadArray<global::UnityEngine.GUILayoutOption>(out var _p4_UnityEngine_GUILayoutOptionArray))
                            {
                                if (_argCount == 5)
                                {
                                    var label = _p0_UnityEngine_GUIContent;
                                    var obj = _p1_UnityEngine_Object;
                                    var objType = _p2_System_Type.BindType;
                                    var allowSceneObjects = _p3_System_Boolean;
                                    var options = _p4_UnityEngine_GUILayoutOptionArray;
                                    var _ret0 = global::UnityEditor.EditorGUILayout.ObjectField(label, obj, objType, allowSceneObjects, options);
                                    var _factory = _context.GetObjectFactory();
                                    var _lret0 = _factory.Bind(_ret0);
                                    var _retCount = _context.Return(_lret0);
                                    return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                                }
                            }
                        }
                        _lastArgPos = 3; _expectedType = typeof(global::UnityEngine.Object);
                        if (_arg3.TryRead<global::UnityEngine.Object>(out var _p3_UnityEngine_Object))
                        {
                            var _arg4 = _lastArg = _argCount > 4 ? _context.GetArgument(4) : global::Lua.LuaValue.Nil;
                            _lastArgPos = 4; _expectedType = typeof(global::UnityEngine.GUILayoutOption[]);
                            if (_arg4.TryReadArray<global::UnityEngine.GUILayoutOption>(out var _p4_UnityEngine_GUILayoutOptionArray))
                            {
                                if (_argCount == 5)
                                {
                                    var label = _p0_UnityEngine_GUIContent;
                                    var obj = _p1_UnityEngine_Object;
                                    var objType = _p2_System_Type.BindType;
                                    var targetBeingEdited = _p3_UnityEngine_Object;
                                    var options = _p4_UnityEngine_GUILayoutOptionArray;
                                    var _ret0 = global::UnityEditor.EditorGUILayout.ObjectField(label, obj, objType, targetBeingEdited, options);
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
        private static readonly global::Lua.LuaFunction _LuaEditorGUILayout_PasswordField = new global::Lua.LuaFunction("PasswordField", (_context, _) =>
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
                _lastArgPos = 1; _expectedType = typeof(global::UnityEngine.GUILayoutOption[]);
                if (_arg1.TryReadArray<global::UnityEngine.GUILayoutOption>(out var _p1_UnityEngine_GUILayoutOptionArray))
                {
                    if (_argCount == 2)
                    {
                        var password = _p0_System_String;
                        var options = _p1_UnityEngine_GUILayoutOptionArray;
                        var _ret0 = global::UnityEditor.EditorGUILayout.PasswordField(password, options);
                        var _lret0 = new global::Lua.LuaValue(_ret0);
                        var _retCount = _context.Return(_lret0);
                        return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                    }
                }
                _lastArgPos = 1; _expectedType = typeof(global::System.String);
                if (_arg1.TryRead<global::System.String>(out var _p1_System_String))
                {
                    var _arg2 = _lastArg = _argCount > 2 ? _context.GetArgument(2) : global::Lua.LuaValue.Nil;
                    _lastArgPos = 2; _expectedType = typeof(global::UnityEngine.GUILayoutOption[]);
                    if (_arg2.TryReadArray<global::UnityEngine.GUILayoutOption>(out var _p2_UnityEngine_GUILayoutOptionArray))
                    {
                        if (_argCount == 3)
                        {
                            var label = _p0_System_String;
                            var password = _p1_System_String;
                            var options = _p2_UnityEngine_GUILayoutOptionArray;
                            var _ret0 = global::UnityEditor.EditorGUILayout.PasswordField(label, password, options);
                            var _lret0 = new global::Lua.LuaValue(_ret0);
                            var _retCount = _context.Return(_lret0);
                            return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                        }
                    }
                    _lastArgPos = 2; _expectedType = typeof(global::UnityEngine.GUIStyle);
                    if (_arg2.TryRead<global::UnityEngine.GUIStyle>(out var _p2_UnityEngine_GUIStyle))
                    {
                        var _arg3 = _lastArg = _argCount > 3 ? _context.GetArgument(3) : global::Lua.LuaValue.Nil;
                        _lastArgPos = 3; _expectedType = typeof(global::UnityEngine.GUILayoutOption[]);
                        if (_arg3.TryReadArray<global::UnityEngine.GUILayoutOption>(out var _p3_UnityEngine_GUILayoutOptionArray))
                        {
                            if (_argCount == 4)
                            {
                                var label = _p0_System_String;
                                var password = _p1_System_String;
                                var style = _p2_UnityEngine_GUIStyle;
                                var options = _p3_UnityEngine_GUILayoutOptionArray;
                                var _ret0 = global::UnityEditor.EditorGUILayout.PasswordField(label, password, style, options);
                                var _lret0 = new global::Lua.LuaValue(_ret0);
                                var _retCount = _context.Return(_lret0);
                                return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                            }
                        }
                    }
                }
                _lastArgPos = 1; _expectedType = typeof(global::UnityEngine.GUIStyle);
                if (_arg1.TryRead<global::UnityEngine.GUIStyle>(out var _p1_UnityEngine_GUIStyle))
                {
                    var _arg2 = _lastArg = _argCount > 2 ? _context.GetArgument(2) : global::Lua.LuaValue.Nil;
                    _lastArgPos = 2; _expectedType = typeof(global::UnityEngine.GUILayoutOption[]);
                    if (_arg2.TryReadArray<global::UnityEngine.GUILayoutOption>(out var _p2_UnityEngine_GUILayoutOptionArray))
                    {
                        if (_argCount == 3)
                        {
                            var password = _p0_System_String;
                            var style = _p1_UnityEngine_GUIStyle;
                            var options = _p2_UnityEngine_GUILayoutOptionArray;
                            var _ret0 = global::UnityEditor.EditorGUILayout.PasswordField(password, style, options);
                            var _lret0 = new global::Lua.LuaValue(_ret0);
                            var _retCount = _context.Return(_lret0);
                            return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                        }
                    }
                }
            }
            _lastArgPos = 0; _expectedType = typeof(global::UnityEngine.GUIContent);
            if (_arg0.TryRead<global::UnityEngine.GUIContent>(out var _p0_UnityEngine_GUIContent))
            {
                var _arg1 = _lastArg = _argCount > 1 ? _context.GetArgument(1) : global::Lua.LuaValue.Nil;
                _lastArgPos = 1; _expectedType = typeof(global::System.String);
                if (_arg1.TryRead<global::System.String>(out var _p1_System_String))
                {
                    var _arg2 = _lastArg = _argCount > 2 ? _context.GetArgument(2) : global::Lua.LuaValue.Nil;
                    _lastArgPos = 2; _expectedType = typeof(global::UnityEngine.GUILayoutOption[]);
                    if (_arg2.TryReadArray<global::UnityEngine.GUILayoutOption>(out var _p2_UnityEngine_GUILayoutOptionArray))
                    {
                        if (_argCount == 3)
                        {
                            var label = _p0_UnityEngine_GUIContent;
                            var password = _p1_System_String;
                            var options = _p2_UnityEngine_GUILayoutOptionArray;
                            var _ret0 = global::UnityEditor.EditorGUILayout.PasswordField(label, password, options);
                            var _lret0 = new global::Lua.LuaValue(_ret0);
                            var _retCount = _context.Return(_lret0);
                            return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                        }
                    }
                    _lastArgPos = 2; _expectedType = typeof(global::UnityEngine.GUIStyle);
                    if (_arg2.TryRead<global::UnityEngine.GUIStyle>(out var _p2_UnityEngine_GUIStyle))
                    {
                        var _arg3 = _lastArg = _argCount > 3 ? _context.GetArgument(3) : global::Lua.LuaValue.Nil;
                        _lastArgPos = 3; _expectedType = typeof(global::UnityEngine.GUILayoutOption[]);
                        if (_arg3.TryReadArray<global::UnityEngine.GUILayoutOption>(out var _p3_UnityEngine_GUILayoutOptionArray))
                        {
                            if (_argCount == 4)
                            {
                                var label = _p0_UnityEngine_GUIContent;
                                var password = _p1_System_String;
                                var style = _p2_UnityEngine_GUIStyle;
                                var options = _p3_UnityEngine_GUILayoutOptionArray;
                                var _ret0 = global::UnityEditor.EditorGUILayout.PasswordField(label, password, style, options);
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
        private static readonly global::Lua.LuaFunction _LuaEditorGUILayout_Popup = new global::Lua.LuaFunction("Popup", (_context, _) =>
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
                _lastArgPos = 1; _expectedType = typeof(global::System.String[]);
                if (_arg1.TryReadArray<global::System.String>(out var _p1_System_StringArray))
                {
                    var _arg2 = _lastArg = _argCount > 2 ? _context.GetArgument(2) : global::Lua.LuaValue.Nil;
                    _lastArgPos = 2; _expectedType = typeof(global::UnityEngine.GUILayoutOption[]);
                    if (_arg2.TryReadArray<global::UnityEngine.GUILayoutOption>(out var _p2_UnityEngine_GUILayoutOptionArray))
                    {
                        if (_argCount == 3)
                        {
                            var selectedIndex = _p0_System_Int32;
                            var displayedOptions = _p1_System_StringArray;
                            var options = _p2_UnityEngine_GUILayoutOptionArray;
                            var _ret0 = global::UnityEditor.EditorGUILayout.Popup(selectedIndex, displayedOptions, options);
                            var _lret0 = new global::Lua.LuaValue(_ret0);
                            var _retCount = _context.Return(_lret0);
                            return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                        }
                    }
                    _lastArgPos = 2; _expectedType = typeof(global::UnityEngine.GUIStyle);
                    if (_arg2.TryRead<global::UnityEngine.GUIStyle>(out var _p2_UnityEngine_GUIStyle))
                    {
                        var _arg3 = _lastArg = _argCount > 3 ? _context.GetArgument(3) : global::Lua.LuaValue.Nil;
                        _lastArgPos = 3; _expectedType = typeof(global::UnityEngine.GUILayoutOption[]);
                        if (_arg3.TryReadArray<global::UnityEngine.GUILayoutOption>(out var _p3_UnityEngine_GUILayoutOptionArray))
                        {
                            if (_argCount == 4)
                            {
                                var selectedIndex = _p0_System_Int32;
                                var displayedOptions = _p1_System_StringArray;
                                var style = _p2_UnityEngine_GUIStyle;
                                var options = _p3_UnityEngine_GUILayoutOptionArray;
                                var _ret0 = global::UnityEditor.EditorGUILayout.Popup(selectedIndex, displayedOptions, style, options);
                                var _lret0 = new global::Lua.LuaValue(_ret0);
                                var _retCount = _context.Return(_lret0);
                                return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                            }
                        }
                    }
                }
                _lastArgPos = 1; _expectedType = typeof(global::UnityEngine.GUIContent[]);
                if (_arg1.TryReadArray<global::UnityEngine.GUIContent>(out var _p1_UnityEngine_GUIContentArray))
                {
                    var _arg2 = _lastArg = _argCount > 2 ? _context.GetArgument(2) : global::Lua.LuaValue.Nil;
                    _lastArgPos = 2; _expectedType = typeof(global::UnityEngine.GUILayoutOption[]);
                    if (_arg2.TryReadArray<global::UnityEngine.GUILayoutOption>(out var _p2_UnityEngine_GUILayoutOptionArray))
                    {
                        if (_argCount == 3)
                        {
                            var selectedIndex = _p0_System_Int32;
                            var displayedOptions = _p1_UnityEngine_GUIContentArray;
                            var options = _p2_UnityEngine_GUILayoutOptionArray;
                            var _ret0 = global::UnityEditor.EditorGUILayout.Popup(selectedIndex, displayedOptions, options);
                            var _lret0 = new global::Lua.LuaValue(_ret0);
                            var _retCount = _context.Return(_lret0);
                            return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                        }
                    }
                    _lastArgPos = 2; _expectedType = typeof(global::UnityEngine.GUIStyle);
                    if (_arg2.TryRead<global::UnityEngine.GUIStyle>(out var _p2_UnityEngine_GUIStyle))
                    {
                        var _arg3 = _lastArg = _argCount > 3 ? _context.GetArgument(3) : global::Lua.LuaValue.Nil;
                        _lastArgPos = 3; _expectedType = typeof(global::UnityEngine.GUILayoutOption[]);
                        if (_arg3.TryReadArray<global::UnityEngine.GUILayoutOption>(out var _p3_UnityEngine_GUILayoutOptionArray))
                        {
                            if (_argCount == 4)
                            {
                                var selectedIndex = _p0_System_Int32;
                                var displayedOptions = _p1_UnityEngine_GUIContentArray;
                                var style = _p2_UnityEngine_GUIStyle;
                                var options = _p3_UnityEngine_GUILayoutOptionArray;
                                var _ret0 = global::UnityEditor.EditorGUILayout.Popup(selectedIndex, displayedOptions, style, options);
                                var _lret0 = new global::Lua.LuaValue(_ret0);
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
                var _arg1 = _lastArg = _argCount > 1 ? _context.GetArgument(1) : global::Lua.LuaValue.Nil;
                _lastArgPos = 1; _expectedType = typeof(global::System.Int32);
                if (_arg1.TryRead<global::System.Int32>(out var _p1_System_Int32))
                {
                    var _arg2 = _lastArg = _argCount > 2 ? _context.GetArgument(2) : global::Lua.LuaValue.Nil;
                    _lastArgPos = 2; _expectedType = typeof(global::System.String[]);
                    if (_arg2.TryReadArray<global::System.String>(out var _p2_System_StringArray))
                    {
                        var _arg3 = _lastArg = _argCount > 3 ? _context.GetArgument(3) : global::Lua.LuaValue.Nil;
                        _lastArgPos = 3; _expectedType = typeof(global::UnityEngine.GUILayoutOption[]);
                        if (_arg3.TryReadArray<global::UnityEngine.GUILayoutOption>(out var _p3_UnityEngine_GUILayoutOptionArray))
                        {
                            if (_argCount == 4)
                            {
                                var label = _p0_System_String;
                                var selectedIndex = _p1_System_Int32;
                                var displayedOptions = _p2_System_StringArray;
                                var options = _p3_UnityEngine_GUILayoutOptionArray;
                                var _ret0 = global::UnityEditor.EditorGUILayout.Popup(label, selectedIndex, displayedOptions, options);
                                var _lret0 = new global::Lua.LuaValue(_ret0);
                                var _retCount = _context.Return(_lret0);
                                return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                            }
                        }
                        _lastArgPos = 3; _expectedType = typeof(global::UnityEngine.GUIStyle);
                        if (_arg3.TryRead<global::UnityEngine.GUIStyle>(out var _p3_UnityEngine_GUIStyle))
                        {
                            var _arg4 = _lastArg = _argCount > 4 ? _context.GetArgument(4) : global::Lua.LuaValue.Nil;
                            _lastArgPos = 4; _expectedType = typeof(global::UnityEngine.GUILayoutOption[]);
                            if (_arg4.TryReadArray<global::UnityEngine.GUILayoutOption>(out var _p4_UnityEngine_GUILayoutOptionArray))
                            {
                                if (_argCount == 5)
                                {
                                    var label = _p0_System_String;
                                    var selectedIndex = _p1_System_Int32;
                                    var displayedOptions = _p2_System_StringArray;
                                    var style = _p3_UnityEngine_GUIStyle;
                                    var options = _p4_UnityEngine_GUILayoutOptionArray;
                                    var _ret0 = global::UnityEditor.EditorGUILayout.Popup(label, selectedIndex, displayedOptions, style, options);
                                    var _lret0 = new global::Lua.LuaValue(_ret0);
                                    var _retCount = _context.Return(_lret0);
                                    return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                                }
                            }
                        }
                    }
                }
            }
            _lastArgPos = 0; _expectedType = typeof(global::UnityEngine.GUIContent);
            if (_arg0.TryRead<global::UnityEngine.GUIContent>(out var _p0_UnityEngine_GUIContent))
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
                        _lastArgPos = 3; _expectedType = typeof(global::UnityEngine.GUILayoutOption[]);
                        if (_arg3.TryReadArray<global::UnityEngine.GUILayoutOption>(out var _p3_UnityEngine_GUILayoutOptionArray))
                        {
                            if (_argCount == 4)
                            {
                                var label = _p0_UnityEngine_GUIContent;
                                var selectedIndex = _p1_System_Int32;
                                var displayedOptions = _p2_System_StringArray;
                                var options = _p3_UnityEngine_GUILayoutOptionArray;
                                var _ret0 = global::UnityEditor.EditorGUILayout.Popup(label, selectedIndex, displayedOptions, options);
                                var _lret0 = new global::Lua.LuaValue(_ret0);
                                var _retCount = _context.Return(_lret0);
                                return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                            }
                        }
                    }
                    _lastArgPos = 2; _expectedType = typeof(global::UnityEngine.GUIContent[]);
                    if (_arg2.TryReadArray<global::UnityEngine.GUIContent>(out var _p2_UnityEngine_GUIContentArray))
                    {
                        var _arg3 = _lastArg = _argCount > 3 ? _context.GetArgument(3) : global::Lua.LuaValue.Nil;
                        _lastArgPos = 3; _expectedType = typeof(global::UnityEngine.GUILayoutOption[]);
                        if (_arg3.TryReadArray<global::UnityEngine.GUILayoutOption>(out var _p3_UnityEngine_GUILayoutOptionArray))
                        {
                            if (_argCount == 4)
                            {
                                var label = _p0_UnityEngine_GUIContent;
                                var selectedIndex = _p1_System_Int32;
                                var displayedOptions = _p2_UnityEngine_GUIContentArray;
                                var options = _p3_UnityEngine_GUILayoutOptionArray;
                                var _ret0 = global::UnityEditor.EditorGUILayout.Popup(label, selectedIndex, displayedOptions, options);
                                var _lret0 = new global::Lua.LuaValue(_ret0);
                                var _retCount = _context.Return(_lret0);
                                return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                            }
                        }
                        _lastArgPos = 3; _expectedType = typeof(global::UnityEngine.GUIStyle);
                        if (_arg3.TryRead<global::UnityEngine.GUIStyle>(out var _p3_UnityEngine_GUIStyle))
                        {
                            var _arg4 = _lastArg = _argCount > 4 ? _context.GetArgument(4) : global::Lua.LuaValue.Nil;
                            _lastArgPos = 4; _expectedType = typeof(global::UnityEngine.GUILayoutOption[]);
                            if (_arg4.TryReadArray<global::UnityEngine.GUILayoutOption>(out var _p4_UnityEngine_GUILayoutOptionArray))
                            {
                                if (_argCount == 5)
                                {
                                    var label = _p0_UnityEngine_GUIContent;
                                    var selectedIndex = _p1_System_Int32;
                                    var displayedOptions = _p2_UnityEngine_GUIContentArray;
                                    var style = _p3_UnityEngine_GUIStyle;
                                    var options = _p4_UnityEngine_GUILayoutOptionArray;
                                    var _ret0 = global::UnityEditor.EditorGUILayout.Popup(label, selectedIndex, displayedOptions, style, options);
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
        private static readonly global::Lua.LuaFunction _LuaEditorGUILayout_PrefixLabel = new global::Lua.LuaFunction("PrefixLabel", (_context, _) =>
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
                    var label = _p0_System_String;
                    global::UnityEditor.EditorGUILayout.PrefixLabel(label);
                    var _retCount = _context.Return();
                    return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                }
                var _arg1 = _lastArg = _argCount > 1 ? _context.GetArgument(1) : global::Lua.LuaValue.Nil;
                _lastArgPos = 1; _expectedType = typeof(global::UnityEngine.GUIStyle);
                if (_arg1.TryRead<global::UnityEngine.GUIStyle>(out var _p1_UnityEngine_GUIStyle))
                {
                    if (_argCount == 2)
                    {
                        var label = _p0_System_String;
                        var followingStyle = _p1_UnityEngine_GUIStyle;
                        global::UnityEditor.EditorGUILayout.PrefixLabel(label, followingStyle);
                        var _retCount = _context.Return();
                        return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                    }
                    var _arg2 = _lastArg = _argCount > 2 ? _context.GetArgument(2) : global::Lua.LuaValue.Nil;
                    _lastArgPos = 2; _expectedType = typeof(global::UnityEngine.GUIStyle);
                    if (_arg2.TryRead<global::UnityEngine.GUIStyle>(out var _p2_UnityEngine_GUIStyle))
                    {
                        if (_argCount == 3)
                        {
                            var label = _p0_System_String;
                            var followingStyle = _p1_UnityEngine_GUIStyle;
                            var labelStyle = _p2_UnityEngine_GUIStyle;
                            global::UnityEditor.EditorGUILayout.PrefixLabel(label, followingStyle, labelStyle);
                            var _retCount = _context.Return();
                            return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                        }
                    }
                }
            }
            _lastArgPos = 0; _expectedType = typeof(global::UnityEngine.GUIContent);
            if (_arg0.TryRead<global::UnityEngine.GUIContent>(out var _p0_UnityEngine_GUIContent))
            {
                if (_argCount == 1)
                {
                    var label = _p0_UnityEngine_GUIContent;
                    global::UnityEditor.EditorGUILayout.PrefixLabel(label);
                    var _retCount = _context.Return();
                    return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                }
                var _arg1 = _lastArg = _argCount > 1 ? _context.GetArgument(1) : global::Lua.LuaValue.Nil;
                _lastArgPos = 1; _expectedType = typeof(global::UnityEngine.GUIStyle);
                if (_arg1.TryRead<global::UnityEngine.GUIStyle>(out var _p1_UnityEngine_GUIStyle))
                {
                    if (_argCount == 2)
                    {
                        var label = _p0_UnityEngine_GUIContent;
                        var followingStyle = _p1_UnityEngine_GUIStyle;
                        global::UnityEditor.EditorGUILayout.PrefixLabel(label, followingStyle);
                        var _retCount = _context.Return();
                        return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                    }
                    var _arg2 = _lastArg = _argCount > 2 ? _context.GetArgument(2) : global::Lua.LuaValue.Nil;
                    _lastArgPos = 2; _expectedType = typeof(global::UnityEngine.GUIStyle);
                    if (_arg2.TryRead<global::UnityEngine.GUIStyle>(out var _p2_UnityEngine_GUIStyle))
                    {
                        if (_argCount == 3)
                        {
                            var label = _p0_UnityEngine_GUIContent;
                            var followingStyle = _p1_UnityEngine_GUIStyle;
                            var labelStyle = _p2_UnityEngine_GUIStyle;
                            global::UnityEditor.EditorGUILayout.PrefixLabel(label, followingStyle, labelStyle);
                            var _retCount = _context.Return();
                            return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                        }
                    }
                }
            }
            throw new global::Lua.LuaRuntimeException(_context.Thread, $"{"PrefixLabel"}: invalid argument #{_lastArgPos}: {_lastArg} ({_lastArg.Type}), expected: {_expectedType.FullName}", 2);
        });
        private static readonly global::Lua.LuaFunction _LuaEditorGUILayout_PropertyField = new global::Lua.LuaFunction("PropertyField", (_context, _) =>
        {
            global::Lua.LuaValue _lastArg = default;
            global::System.Int32 _lastArgPos = default;
            global::System.Type _expectedType = default;
            var _argCount = _context.ArgumentCount;
            var _arg0 = _lastArg = _argCount > 0 ? _context.GetArgument(0) : global::Lua.LuaValue.Nil;
            _lastArgPos = 0; _expectedType = typeof(global::Luny.UnityEditor.LuaSerializedProperty);
            if (_arg0.TryRead<global::Luny.UnityEditor.LuaSerializedProperty>(out var _p0_UnityEditor_SerializedProperty))
            {
                var _arg1 = _lastArg = _argCount > 1 ? _context.GetArgument(1) : global::Lua.LuaValue.Nil;
                _lastArgPos = 1; _expectedType = typeof(global::UnityEngine.GUILayoutOption[]);
                if (_arg1.TryReadArray<global::UnityEngine.GUILayoutOption>(out var _p1_UnityEngine_GUILayoutOptionArray))
                {
                    if (_argCount == 2)
                    {
                        var property = _p0_UnityEditor_SerializedProperty.Instance;
                        var options = _p1_UnityEngine_GUILayoutOptionArray;
                        var _ret0 = global::UnityEditor.EditorGUILayout.PropertyField(property, options);
                        var _lret0 = new global::Lua.LuaValue(_ret0);
                        var _retCount = _context.Return(_lret0);
                        return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                    }
                }
                _lastArgPos = 1; _expectedType = typeof(global::System.Boolean);
                if (_arg1.TryRead<global::System.Boolean>(out var _p1_System_Boolean))
                {
                    var _arg2 = _lastArg = _argCount > 2 ? _context.GetArgument(2) : global::Lua.LuaValue.Nil;
                    _lastArgPos = 2; _expectedType = typeof(global::UnityEngine.GUILayoutOption[]);
                    if (_arg2.TryReadArray<global::UnityEngine.GUILayoutOption>(out var _p2_UnityEngine_GUILayoutOptionArray))
                    {
                        if (_argCount == 3)
                        {
                            var property = _p0_UnityEditor_SerializedProperty.Instance;
                            var includeChildren = _p1_System_Boolean;
                            var options = _p2_UnityEngine_GUILayoutOptionArray;
                            var _ret0 = global::UnityEditor.EditorGUILayout.PropertyField(property, includeChildren, options);
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
                    _lastArgPos = 2; _expectedType = typeof(global::UnityEngine.GUILayoutOption[]);
                    if (_arg2.TryReadArray<global::UnityEngine.GUILayoutOption>(out var _p2_UnityEngine_GUILayoutOptionArray))
                    {
                        if (_argCount == 3)
                        {
                            var property = _p0_UnityEditor_SerializedProperty.Instance;
                            var label = _p1_UnityEngine_GUIContent;
                            var options = _p2_UnityEngine_GUILayoutOptionArray;
                            var _ret0 = global::UnityEditor.EditorGUILayout.PropertyField(property, label, options);
                            var _lret0 = new global::Lua.LuaValue(_ret0);
                            var _retCount = _context.Return(_lret0);
                            return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                        }
                    }
                    _lastArgPos = 2; _expectedType = typeof(global::System.Boolean);
                    if (_arg2.TryRead<global::System.Boolean>(out var _p2_System_Boolean))
                    {
                        var _arg3 = _lastArg = _argCount > 3 ? _context.GetArgument(3) : global::Lua.LuaValue.Nil;
                        _lastArgPos = 3; _expectedType = typeof(global::UnityEngine.GUILayoutOption[]);
                        if (_arg3.TryReadArray<global::UnityEngine.GUILayoutOption>(out var _p3_UnityEngine_GUILayoutOptionArray))
                        {
                            if (_argCount == 4)
                            {
                                var property = _p0_UnityEditor_SerializedProperty.Instance;
                                var label = _p1_UnityEngine_GUIContent;
                                var includeChildren = _p2_System_Boolean;
                                var options = _p3_UnityEngine_GUILayoutOptionArray;
                                var _ret0 = global::UnityEditor.EditorGUILayout.PropertyField(property, label, includeChildren, options);
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
        private static readonly global::Lua.LuaFunction _LuaEditorGUILayout_RectField = new global::Lua.LuaFunction("RectField", (_context, _) =>
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
                _lastArgPos = 1; _expectedType = typeof(global::UnityEngine.GUILayoutOption[]);
                if (_arg1.TryReadArray<global::UnityEngine.GUILayoutOption>(out var _p1_UnityEngine_GUILayoutOptionArray))
                {
                    if (_argCount == 2)
                    {
                        var value = _p0_UnityEngine_Rect;
                        var options = _p1_UnityEngine_GUILayoutOptionArray;
                        var _ret0 = global::UnityEditor.EditorGUILayout.RectField(value, options);
                        var _factory = _context.GetObjectFactory();
                        var _lret0 = _factory.Bind(_ret0);
                        var _retCount = _context.Return(_lret0);
                        return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                    }
                }
            }
            _lastArgPos = 0; _expectedType = typeof(global::System.String);
            if (_arg0.TryRead<global::System.String>(out var _p0_System_String))
            {
                var _arg1 = _lastArg = _argCount > 1 ? _context.GetArgument(1) : global::Lua.LuaValue.Nil;
                _lastArgPos = 1; _expectedType = typeof(global::UnityEngine.Rect);
                if (_arg1.TryRead<global::UnityEngine.Rect>(out var _p1_UnityEngine_Rect))
                {
                    var _arg2 = _lastArg = _argCount > 2 ? _context.GetArgument(2) : global::Lua.LuaValue.Nil;
                    _lastArgPos = 2; _expectedType = typeof(global::UnityEngine.GUILayoutOption[]);
                    if (_arg2.TryReadArray<global::UnityEngine.GUILayoutOption>(out var _p2_UnityEngine_GUILayoutOptionArray))
                    {
                        if (_argCount == 3)
                        {
                            var label = _p0_System_String;
                            var value = _p1_UnityEngine_Rect;
                            var options = _p2_UnityEngine_GUILayoutOptionArray;
                            var _ret0 = global::UnityEditor.EditorGUILayout.RectField(label, value, options);
                            var _factory = _context.GetObjectFactory();
                            var _lret0 = _factory.Bind(_ret0);
                            var _retCount = _context.Return(_lret0);
                            return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                        }
                    }
                }
            }
            _lastArgPos = 0; _expectedType = typeof(global::UnityEngine.GUIContent);
            if (_arg0.TryRead<global::UnityEngine.GUIContent>(out var _p0_UnityEngine_GUIContent))
            {
                var _arg1 = _lastArg = _argCount > 1 ? _context.GetArgument(1) : global::Lua.LuaValue.Nil;
                _lastArgPos = 1; _expectedType = typeof(global::UnityEngine.Rect);
                if (_arg1.TryRead<global::UnityEngine.Rect>(out var _p1_UnityEngine_Rect))
                {
                    var _arg2 = _lastArg = _argCount > 2 ? _context.GetArgument(2) : global::Lua.LuaValue.Nil;
                    _lastArgPos = 2; _expectedType = typeof(global::UnityEngine.GUILayoutOption[]);
                    if (_arg2.TryReadArray<global::UnityEngine.GUILayoutOption>(out var _p2_UnityEngine_GUILayoutOptionArray))
                    {
                        if (_argCount == 3)
                        {
                            var label = _p0_UnityEngine_GUIContent;
                            var value = _p1_UnityEngine_Rect;
                            var options = _p2_UnityEngine_GUILayoutOptionArray;
                            var _ret0 = global::UnityEditor.EditorGUILayout.RectField(label, value, options);
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
        private static readonly global::Lua.LuaFunction _LuaEditorGUILayout_RectIntField = new global::Lua.LuaFunction("RectIntField", (_context, _) =>
        {
            global::Lua.LuaValue _lastArg = default;
            global::System.Int32 _lastArgPos = default;
            global::System.Type _expectedType = default;
            var _argCount = _context.ArgumentCount;
            var _arg0 = _lastArg = _argCount > 0 ? _context.GetArgument(0) : global::Lua.LuaValue.Nil;
            _lastArgPos = 0; _expectedType = typeof(global::UnityEngine.RectInt);
            if (_arg0.TryRead<global::UnityEngine.RectInt>(out var _p0_UnityEngine_RectInt))
            {
                var _arg1 = _lastArg = _argCount > 1 ? _context.GetArgument(1) : global::Lua.LuaValue.Nil;
                _lastArgPos = 1; _expectedType = typeof(global::UnityEngine.GUILayoutOption[]);
                if (_arg1.TryReadArray<global::UnityEngine.GUILayoutOption>(out var _p1_UnityEngine_GUILayoutOptionArray))
                {
                    if (_argCount == 2)
                    {
                        var value = _p0_UnityEngine_RectInt;
                        var options = _p1_UnityEngine_GUILayoutOptionArray;
                        var _ret0 = global::UnityEditor.EditorGUILayout.RectIntField(value, options);
                        var _factory = _context.GetObjectFactory();
                        var _lret0 = _factory.Bind(_ret0);
                        var _retCount = _context.Return(_lret0);
                        return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                    }
                }
            }
            _lastArgPos = 0; _expectedType = typeof(global::System.String);
            if (_arg0.TryRead<global::System.String>(out var _p0_System_String))
            {
                var _arg1 = _lastArg = _argCount > 1 ? _context.GetArgument(1) : global::Lua.LuaValue.Nil;
                _lastArgPos = 1; _expectedType = typeof(global::UnityEngine.RectInt);
                if (_arg1.TryRead<global::UnityEngine.RectInt>(out var _p1_UnityEngine_RectInt))
                {
                    var _arg2 = _lastArg = _argCount > 2 ? _context.GetArgument(2) : global::Lua.LuaValue.Nil;
                    _lastArgPos = 2; _expectedType = typeof(global::UnityEngine.GUILayoutOption[]);
                    if (_arg2.TryReadArray<global::UnityEngine.GUILayoutOption>(out var _p2_UnityEngine_GUILayoutOptionArray))
                    {
                        if (_argCount == 3)
                        {
                            var label = _p0_System_String;
                            var value = _p1_UnityEngine_RectInt;
                            var options = _p2_UnityEngine_GUILayoutOptionArray;
                            var _ret0 = global::UnityEditor.EditorGUILayout.RectIntField(label, value, options);
                            var _factory = _context.GetObjectFactory();
                            var _lret0 = _factory.Bind(_ret0);
                            var _retCount = _context.Return(_lret0);
                            return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                        }
                    }
                }
            }
            _lastArgPos = 0; _expectedType = typeof(global::UnityEngine.GUIContent);
            if (_arg0.TryRead<global::UnityEngine.GUIContent>(out var _p0_UnityEngine_GUIContent))
            {
                var _arg1 = _lastArg = _argCount > 1 ? _context.GetArgument(1) : global::Lua.LuaValue.Nil;
                _lastArgPos = 1; _expectedType = typeof(global::UnityEngine.RectInt);
                if (_arg1.TryRead<global::UnityEngine.RectInt>(out var _p1_UnityEngine_RectInt))
                {
                    var _arg2 = _lastArg = _argCount > 2 ? _context.GetArgument(2) : global::Lua.LuaValue.Nil;
                    _lastArgPos = 2; _expectedType = typeof(global::UnityEngine.GUILayoutOption[]);
                    if (_arg2.TryReadArray<global::UnityEngine.GUILayoutOption>(out var _p2_UnityEngine_GUILayoutOptionArray))
                    {
                        if (_argCount == 3)
                        {
                            var label = _p0_UnityEngine_GUIContent;
                            var value = _p1_UnityEngine_RectInt;
                            var options = _p2_UnityEngine_GUILayoutOptionArray;
                            var _ret0 = global::UnityEditor.EditorGUILayout.RectIntField(label, value, options);
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
        private static readonly global::Lua.LuaFunction _LuaEditorGUILayout_RenderingLayerMaskField = new global::Lua.LuaFunction("RenderingLayerMaskField", (_context, _) =>
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
                _lastArgPos = 1; _expectedType = typeof(global::System.UInt32);
                if (_arg1.TryRead<global::System.UInt32>(out var _p1_System_UInt32))
                {
                    var _arg2 = _lastArg = _argCount > 2 ? _context.GetArgument(2) : global::Lua.LuaValue.Nil;
                    _lastArgPos = 2; _expectedType = typeof(global::UnityEngine.GUILayoutOption[]);
                    if (_arg2.TryReadArray<global::UnityEngine.GUILayoutOption>(out var _p2_UnityEngine_GUILayoutOptionArray))
                    {
                        if (_argCount == 3)
                        {
                            var label = _p0_System_String;
                            var layers = _p1_System_UInt32;
                            var options = _p2_UnityEngine_GUILayoutOptionArray;
                            var _ret0 = global::UnityEditor.EditorGUILayout.RenderingLayerMaskField(label, layers, options);
                            var _lret0 = new global::Lua.LuaValue(_ret0);
                            var _retCount = _context.Return(_lret0);
                            return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                        }
                    }
                    _lastArgPos = 2; _expectedType = typeof(global::UnityEngine.GUIStyle);
                    if (_arg2.TryRead<global::UnityEngine.GUIStyle>(out var _p2_UnityEngine_GUIStyle))
                    {
                        var _arg3 = _lastArg = _argCount > 3 ? _context.GetArgument(3) : global::Lua.LuaValue.Nil;
                        _lastArgPos = 3; _expectedType = typeof(global::UnityEngine.GUILayoutOption[]);
                        if (_arg3.TryReadArray<global::UnityEngine.GUILayoutOption>(out var _p3_UnityEngine_GUILayoutOptionArray))
                        {
                            if (_argCount == 4)
                            {
                                var label = _p0_System_String;
                                var layers = _p1_System_UInt32;
                                var style = _p2_UnityEngine_GUIStyle;
                                var options = _p3_UnityEngine_GUILayoutOptionArray;
                                var _ret0 = global::UnityEditor.EditorGUILayout.RenderingLayerMaskField(label, layers, style, options);
                                var _lret0 = new global::Lua.LuaValue(_ret0);
                                var _retCount = _context.Return(_lret0);
                                return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                            }
                        }
                    }
                }
                _lastArgPos = 1; _expectedType = typeof(global::UnityEngine.RenderingLayerMask);
                if (_arg1.TryRead<global::UnityEngine.RenderingLayerMask>(out var _p1_UnityEngine_RenderingLayerMask))
                {
                    var _arg2 = _lastArg = _argCount > 2 ? _context.GetArgument(2) : global::Lua.LuaValue.Nil;
                    _lastArgPos = 2; _expectedType = typeof(global::UnityEngine.GUILayoutOption[]);
                    if (_arg2.TryReadArray<global::UnityEngine.GUILayoutOption>(out var _p2_UnityEngine_GUILayoutOptionArray))
                    {
                        if (_argCount == 3)
                        {
                            var label = _p0_System_String;
                            var layers = _p1_UnityEngine_RenderingLayerMask;
                            var options = _p2_UnityEngine_GUILayoutOptionArray;
                            var _ret0 = global::UnityEditor.EditorGUILayout.RenderingLayerMaskField(label, layers, options);
                            var _factory = _context.GetObjectFactory();
                            var _lret0 = _factory.Bind(_ret0);
                            var _retCount = _context.Return(_lret0);
                            return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                        }
                    }
                    _lastArgPos = 2; _expectedType = typeof(global::UnityEngine.GUIStyle);
                    if (_arg2.TryRead<global::UnityEngine.GUIStyle>(out var _p2_UnityEngine_GUIStyle))
                    {
                        var _arg3 = _lastArg = _argCount > 3 ? _context.GetArgument(3) : global::Lua.LuaValue.Nil;
                        _lastArgPos = 3; _expectedType = typeof(global::UnityEngine.GUILayoutOption[]);
                        if (_arg3.TryReadArray<global::UnityEngine.GUILayoutOption>(out var _p3_UnityEngine_GUILayoutOptionArray))
                        {
                            if (_argCount == 4)
                            {
                                var label = _p0_System_String;
                                var layers = _p1_UnityEngine_RenderingLayerMask;
                                var style = _p2_UnityEngine_GUIStyle;
                                var options = _p3_UnityEngine_GUILayoutOptionArray;
                                var _ret0 = global::UnityEditor.EditorGUILayout.RenderingLayerMaskField(label, layers, style, options);
                                var _factory = _context.GetObjectFactory();
                                var _lret0 = _factory.Bind(_ret0);
                                var _retCount = _context.Return(_lret0);
                                return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                            }
                        }
                    }
                }
            }
            _lastArgPos = 0; _expectedType = typeof(global::UnityEngine.GUIContent);
            if (_arg0.TryRead<global::UnityEngine.GUIContent>(out var _p0_UnityEngine_GUIContent))
            {
                var _arg1 = _lastArg = _argCount > 1 ? _context.GetArgument(1) : global::Lua.LuaValue.Nil;
                _lastArgPos = 1; _expectedType = typeof(global::System.UInt32);
                if (_arg1.TryRead<global::System.UInt32>(out var _p1_System_UInt32))
                {
                    var _arg2 = _lastArg = _argCount > 2 ? _context.GetArgument(2) : global::Lua.LuaValue.Nil;
                    _lastArgPos = 2; _expectedType = typeof(global::UnityEngine.GUILayoutOption[]);
                    if (_arg2.TryReadArray<global::UnityEngine.GUILayoutOption>(out var _p2_UnityEngine_GUILayoutOptionArray))
                    {
                        if (_argCount == 3)
                        {
                            var label = _p0_UnityEngine_GUIContent;
                            var layers = _p1_System_UInt32;
                            var options = _p2_UnityEngine_GUILayoutOptionArray;
                            var _ret0 = global::UnityEditor.EditorGUILayout.RenderingLayerMaskField(label, layers, options);
                            var _lret0 = new global::Lua.LuaValue(_ret0);
                            var _retCount = _context.Return(_lret0);
                            return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                        }
                    }
                    _lastArgPos = 2; _expectedType = typeof(global::UnityEngine.GUIStyle);
                    if (_arg2.TryRead<global::UnityEngine.GUIStyle>(out var _p2_UnityEngine_GUIStyle))
                    {
                        var _arg3 = _lastArg = _argCount > 3 ? _context.GetArgument(3) : global::Lua.LuaValue.Nil;
                        _lastArgPos = 3; _expectedType = typeof(global::UnityEngine.GUILayoutOption[]);
                        if (_arg3.TryReadArray<global::UnityEngine.GUILayoutOption>(out var _p3_UnityEngine_GUILayoutOptionArray))
                        {
                            if (_argCount == 4)
                            {
                                var label = _p0_UnityEngine_GUIContent;
                                var layers = _p1_System_UInt32;
                                var style = _p2_UnityEngine_GUIStyle;
                                var options = _p3_UnityEngine_GUILayoutOptionArray;
                                var _ret0 = global::UnityEditor.EditorGUILayout.RenderingLayerMaskField(label, layers, style, options);
                                var _lret0 = new global::Lua.LuaValue(_ret0);
                                var _retCount = _context.Return(_lret0);
                                return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                            }
                        }
                    }
                }
                _lastArgPos = 1; _expectedType = typeof(global::UnityEngine.RenderingLayerMask);
                if (_arg1.TryRead<global::UnityEngine.RenderingLayerMask>(out var _p1_UnityEngine_RenderingLayerMask))
                {
                    var _arg2 = _lastArg = _argCount > 2 ? _context.GetArgument(2) : global::Lua.LuaValue.Nil;
                    _lastArgPos = 2; _expectedType = typeof(global::UnityEngine.GUILayoutOption[]);
                    if (_arg2.TryReadArray<global::UnityEngine.GUILayoutOption>(out var _p2_UnityEngine_GUILayoutOptionArray))
                    {
                        if (_argCount == 3)
                        {
                            var label = _p0_UnityEngine_GUIContent;
                            var layers = _p1_UnityEngine_RenderingLayerMask;
                            var options = _p2_UnityEngine_GUILayoutOptionArray;
                            var _ret0 = global::UnityEditor.EditorGUILayout.RenderingLayerMaskField(label, layers, options);
                            var _factory = _context.GetObjectFactory();
                            var _lret0 = _factory.Bind(_ret0);
                            var _retCount = _context.Return(_lret0);
                            return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                        }
                    }
                    _lastArgPos = 2; _expectedType = typeof(global::UnityEngine.GUIStyle);
                    if (_arg2.TryRead<global::UnityEngine.GUIStyle>(out var _p2_UnityEngine_GUIStyle))
                    {
                        var _arg3 = _lastArg = _argCount > 3 ? _context.GetArgument(3) : global::Lua.LuaValue.Nil;
                        _lastArgPos = 3; _expectedType = typeof(global::UnityEngine.GUILayoutOption[]);
                        if (_arg3.TryReadArray<global::UnityEngine.GUILayoutOption>(out var _p3_UnityEngine_GUILayoutOptionArray))
                        {
                            if (_argCount == 4)
                            {
                                var label = _p0_UnityEngine_GUIContent;
                                var layers = _p1_UnityEngine_RenderingLayerMask;
                                var style = _p2_UnityEngine_GUIStyle;
                                var options = _p3_UnityEngine_GUILayoutOptionArray;
                                var _ret0 = global::UnityEditor.EditorGUILayout.RenderingLayerMaskField(label, layers, style, options);
                                var _factory = _context.GetObjectFactory();
                                var _lret0 = _factory.Bind(_ret0);
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
                    _lastArgPos = 2; _expectedType = typeof(global::UnityEngine.GUILayoutOption[]);
                    if (_arg2.TryReadArray<global::UnityEngine.GUILayoutOption>(out var _p2_UnityEngine_GUILayoutOptionArray))
                    {
                        if (_argCount == 3)
                        {
                            var label = _p0_UnityEngine_GUIContent;
                            var property = _p1_UnityEditor_SerializedProperty.Instance;
                            var options = _p2_UnityEngine_GUILayoutOptionArray;
                            global::UnityEditor.EditorGUILayout.RenderingLayerMaskField(label, property, options);
                            var _retCount = _context.Return();
                            return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                        }
                    }
                }
            }
            throw new global::Lua.LuaRuntimeException(_context.Thread, $"{"RenderingLayerMaskField"}: invalid argument #{_lastArgPos}: {_lastArg} ({_lastArg.Type}), expected: {_expectedType.FullName}", 2);
        });
        private static readonly global::Lua.LuaFunction _LuaEditorGUILayout_SelectableLabel = new global::Lua.LuaFunction("SelectableLabel", (_context, _) =>
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
                _lastArgPos = 1; _expectedType = typeof(global::UnityEngine.GUILayoutOption[]);
                if (_arg1.TryReadArray<global::UnityEngine.GUILayoutOption>(out var _p1_UnityEngine_GUILayoutOptionArray))
                {
                    if (_argCount == 2)
                    {
                        var text = _p0_System_String;
                        var options = _p1_UnityEngine_GUILayoutOptionArray;
                        global::UnityEditor.EditorGUILayout.SelectableLabel(text, options);
                        var _retCount = _context.Return();
                        return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                    }
                }
                _lastArgPos = 1; _expectedType = typeof(global::UnityEngine.GUIStyle);
                if (_arg1.TryRead<global::UnityEngine.GUIStyle>(out var _p1_UnityEngine_GUIStyle))
                {
                    var _arg2 = _lastArg = _argCount > 2 ? _context.GetArgument(2) : global::Lua.LuaValue.Nil;
                    _lastArgPos = 2; _expectedType = typeof(global::UnityEngine.GUILayoutOption[]);
                    if (_arg2.TryReadArray<global::UnityEngine.GUILayoutOption>(out var _p2_UnityEngine_GUILayoutOptionArray))
                    {
                        if (_argCount == 3)
                        {
                            var text = _p0_System_String;
                            var style = _p1_UnityEngine_GUIStyle;
                            var options = _p2_UnityEngine_GUILayoutOptionArray;
                            global::UnityEditor.EditorGUILayout.SelectableLabel(text, style, options);
                            var _retCount = _context.Return();
                            return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                        }
                    }
                }
            }
            throw new global::Lua.LuaRuntimeException(_context.Thread, $"{"SelectableLabel"}: invalid argument #{_lastArgPos}: {_lastArg} ({_lastArg.Type}), expected: {_expectedType.FullName}", 2);
        });
        private static readonly global::Lua.LuaFunction _LuaEditorGUILayout_Separator = new global::Lua.LuaFunction("Separator", (_context, _) =>
        {
            global::Lua.LuaValue _lastArg = default;
            global::System.Int32 _lastArgPos = default;
            global::System.Type _expectedType = default;
            var _argCount = _context.ArgumentCount;
            if (_argCount == 0)
            {
                global::UnityEditor.EditorGUILayout.Separator();
                var _retCount = _context.Return();
                return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
            }
            throw new global::Lua.LuaRuntimeException(_context.Thread, $"{"Separator"}: invalid argument #{_lastArgPos}: {_lastArg} ({_lastArg.Type}), expected: {_expectedType.FullName}", 2);
        });
        private static readonly global::Lua.LuaFunction _LuaEditorGUILayout_Slider = new global::Lua.LuaFunction("Slider", (_context, _) =>
        {
            global::Lua.LuaValue _lastArg = default;
            global::System.Int32 _lastArgPos = default;
            global::System.Type _expectedType = default;
            var _argCount = _context.ArgumentCount;
            var _arg0 = _lastArg = _argCount > 0 ? _context.GetArgument(0) : global::Lua.LuaValue.Nil;
            _lastArgPos = 0; _expectedType = typeof(global::System.Single);
            if (_arg0.TryRead<global::System.Single>(out var _p0_System_Single))
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
                        _lastArgPos = 3; _expectedType = typeof(global::UnityEngine.GUILayoutOption[]);
                        if (_arg3.TryReadArray<global::UnityEngine.GUILayoutOption>(out var _p3_UnityEngine_GUILayoutOptionArray))
                        {
                            if (_argCount == 4)
                            {
                                var value = _p0_System_Single;
                                var leftValue = _p1_System_Single;
                                var rightValue = _p2_System_Single;
                                var options = _p3_UnityEngine_GUILayoutOptionArray;
                                var _ret0 = global::UnityEditor.EditorGUILayout.Slider(value, leftValue, rightValue, options);
                                var _lret0 = new global::Lua.LuaValue(_ret0);
                                var _retCount = _context.Return(_lret0);
                                return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                            }
                        }
                    }
                }
            }
            _lastArgPos = 0; _expectedType = typeof(global::Luny.UnityEditor.LuaSerializedProperty);
            if (_arg0.TryRead<global::Luny.UnityEditor.LuaSerializedProperty>(out var _p0_UnityEditor_SerializedProperty))
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
                        _lastArgPos = 3; _expectedType = typeof(global::UnityEngine.GUILayoutOption[]);
                        if (_arg3.TryReadArray<global::UnityEngine.GUILayoutOption>(out var _p3_UnityEngine_GUILayoutOptionArray))
                        {
                            if (_argCount == 4)
                            {
                                var property = _p0_UnityEditor_SerializedProperty.Instance;
                                var leftValue = _p1_System_Single;
                                var rightValue = _p2_System_Single;
                                var options = _p3_UnityEngine_GUILayoutOptionArray;
                                global::UnityEditor.EditorGUILayout.Slider(property, leftValue, rightValue, options);
                                var _retCount = _context.Return();
                                return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                            }
                        }
                        _lastArgPos = 3; _expectedType = typeof(global::System.String);
                        if (_arg3.TryRead<global::System.String>(out var _p3_System_String))
                        {
                            var _arg4 = _lastArg = _argCount > 4 ? _context.GetArgument(4) : global::Lua.LuaValue.Nil;
                            _lastArgPos = 4; _expectedType = typeof(global::UnityEngine.GUILayoutOption[]);
                            if (_arg4.TryReadArray<global::UnityEngine.GUILayoutOption>(out var _p4_UnityEngine_GUILayoutOptionArray))
                            {
                                if (_argCount == 5)
                                {
                                    var property = _p0_UnityEditor_SerializedProperty.Instance;
                                    var leftValue = _p1_System_Single;
                                    var rightValue = _p2_System_Single;
                                    var label = _p3_System_String;
                                    var options = _p4_UnityEngine_GUILayoutOptionArray;
                                    global::UnityEditor.EditorGUILayout.Slider(property, leftValue, rightValue, label, options);
                                    var _retCount = _context.Return();
                                    return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                                }
                            }
                        }
                        _lastArgPos = 3; _expectedType = typeof(global::UnityEngine.GUIContent);
                        if (_arg3.TryRead<global::UnityEngine.GUIContent>(out var _p3_UnityEngine_GUIContent))
                        {
                            var _arg4 = _lastArg = _argCount > 4 ? _context.GetArgument(4) : global::Lua.LuaValue.Nil;
                            _lastArgPos = 4; _expectedType = typeof(global::UnityEngine.GUILayoutOption[]);
                            if (_arg4.TryReadArray<global::UnityEngine.GUILayoutOption>(out var _p4_UnityEngine_GUILayoutOptionArray))
                            {
                                if (_argCount == 5)
                                {
                                    var property = _p0_UnityEditor_SerializedProperty.Instance;
                                    var leftValue = _p1_System_Single;
                                    var rightValue = _p2_System_Single;
                                    var label = _p3_UnityEngine_GUIContent;
                                    var options = _p4_UnityEngine_GUILayoutOptionArray;
                                    global::UnityEditor.EditorGUILayout.Slider(property, leftValue, rightValue, label, options);
                                    var _retCount = _context.Return();
                                    return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                                }
                            }
                        }
                    }
                }
            }
            _lastArgPos = 0; _expectedType = typeof(global::System.String);
            if (_arg0.TryRead<global::System.String>(out var _p0_System_String))
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
                            var _arg4 = _lastArg = _argCount > 4 ? _context.GetArgument(4) : global::Lua.LuaValue.Nil;
                            _lastArgPos = 4; _expectedType = typeof(global::UnityEngine.GUILayoutOption[]);
                            if (_arg4.TryReadArray<global::UnityEngine.GUILayoutOption>(out var _p4_UnityEngine_GUILayoutOptionArray))
                            {
                                if (_argCount == 5)
                                {
                                    var label = _p0_System_String;
                                    var value = _p1_System_Single;
                                    var leftValue = _p2_System_Single;
                                    var rightValue = _p3_System_Single;
                                    var options = _p4_UnityEngine_GUILayoutOptionArray;
                                    var _ret0 = global::UnityEditor.EditorGUILayout.Slider(label, value, leftValue, rightValue, options);
                                    var _lret0 = new global::Lua.LuaValue(_ret0);
                                    var _retCount = _context.Return(_lret0);
                                    return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                                }
                            }
                        }
                    }
                }
            }
            _lastArgPos = 0; _expectedType = typeof(global::UnityEngine.GUIContent);
            if (_arg0.TryRead<global::UnityEngine.GUIContent>(out var _p0_UnityEngine_GUIContent))
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
                            var _arg4 = _lastArg = _argCount > 4 ? _context.GetArgument(4) : global::Lua.LuaValue.Nil;
                            _lastArgPos = 4; _expectedType = typeof(global::UnityEngine.GUILayoutOption[]);
                            if (_arg4.TryReadArray<global::UnityEngine.GUILayoutOption>(out var _p4_UnityEngine_GUILayoutOptionArray))
                            {
                                if (_argCount == 5)
                                {
                                    var label = _p0_UnityEngine_GUIContent;
                                    var value = _p1_System_Single;
                                    var leftValue = _p2_System_Single;
                                    var rightValue = _p3_System_Single;
                                    var options = _p4_UnityEngine_GUILayoutOptionArray;
                                    var _ret0 = global::UnityEditor.EditorGUILayout.Slider(label, value, leftValue, rightValue, options);
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
        private static readonly global::Lua.LuaFunction _LuaEditorGUILayout_Space = new global::Lua.LuaFunction("Space", (_context, _) =>
        {
            global::Lua.LuaValue _lastArg = default;
            global::System.Int32 _lastArgPos = default;
            global::System.Type _expectedType = default;
            var _argCount = _context.ArgumentCount;
            if (_argCount == 0)
            {
                global::UnityEditor.EditorGUILayout.Space();
                var _retCount = _context.Return();
                return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
            }
            var _arg0 = _lastArg = _argCount > 0 ? _context.GetArgument(0) : global::Lua.LuaValue.Nil;
            _lastArgPos = 0; _expectedType = typeof(global::System.Single);
            if (_arg0.TryRead<global::System.Single>(out var _p0_System_Single))
            {
                if (_argCount == 1)
                {
                    var width = _p0_System_Single;
                    global::UnityEditor.EditorGUILayout.Space(width);
                    var _retCount = _context.Return();
                    return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                }
                var _arg1 = _lastArg = _argCount > 1 ? _context.GetArgument(1) : global::Lua.LuaValue.Nil;
                _lastArgPos = 1; _expectedType = typeof(global::System.Boolean);
                if (_arg1.TryRead<global::System.Boolean>(out var _p1_System_Boolean))
                {
                    if (_argCount == 2)
                    {
                        var width = _p0_System_Single;
                        var expand = _p1_System_Boolean;
                        global::UnityEditor.EditorGUILayout.Space(width, expand);
                        var _retCount = _context.Return();
                        return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                    }
                }
            }
            throw new global::Lua.LuaRuntimeException(_context.Thread, $"{"Space"}: invalid argument #{_lastArgPos}: {_lastArg} ({_lastArg.Type}), expected: {_expectedType.FullName}", 2);
        });
        private static readonly global::Lua.LuaFunction _LuaEditorGUILayout_TagField = new global::Lua.LuaFunction("TagField", (_context, _) =>
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
                _lastArgPos = 1; _expectedType = typeof(global::UnityEngine.GUILayoutOption[]);
                if (_arg1.TryReadArray<global::UnityEngine.GUILayoutOption>(out var _p1_UnityEngine_GUILayoutOptionArray))
                {
                    if (_argCount == 2)
                    {
                        var tag = _p0_System_String;
                        var options = _p1_UnityEngine_GUILayoutOptionArray;
                        var _ret0 = global::UnityEditor.EditorGUILayout.TagField(tag, options);
                        var _lret0 = new global::Lua.LuaValue(_ret0);
                        var _retCount = _context.Return(_lret0);
                        return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                    }
                }
                _lastArgPos = 1; _expectedType = typeof(global::System.String);
                if (_arg1.TryRead<global::System.String>(out var _p1_System_String))
                {
                    var _arg2 = _lastArg = _argCount > 2 ? _context.GetArgument(2) : global::Lua.LuaValue.Nil;
                    _lastArgPos = 2; _expectedType = typeof(global::UnityEngine.GUILayoutOption[]);
                    if (_arg2.TryReadArray<global::UnityEngine.GUILayoutOption>(out var _p2_UnityEngine_GUILayoutOptionArray))
                    {
                        if (_argCount == 3)
                        {
                            var label = _p0_System_String;
                            var tag = _p1_System_String;
                            var options = _p2_UnityEngine_GUILayoutOptionArray;
                            var _ret0 = global::UnityEditor.EditorGUILayout.TagField(label, tag, options);
                            var _lret0 = new global::Lua.LuaValue(_ret0);
                            var _retCount = _context.Return(_lret0);
                            return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                        }
                    }
                    _lastArgPos = 2; _expectedType = typeof(global::UnityEngine.GUIStyle);
                    if (_arg2.TryRead<global::UnityEngine.GUIStyle>(out var _p2_UnityEngine_GUIStyle))
                    {
                        var _arg3 = _lastArg = _argCount > 3 ? _context.GetArgument(3) : global::Lua.LuaValue.Nil;
                        _lastArgPos = 3; _expectedType = typeof(global::UnityEngine.GUILayoutOption[]);
                        if (_arg3.TryReadArray<global::UnityEngine.GUILayoutOption>(out var _p3_UnityEngine_GUILayoutOptionArray))
                        {
                            if (_argCount == 4)
                            {
                                var label = _p0_System_String;
                                var tag = _p1_System_String;
                                var style = _p2_UnityEngine_GUIStyle;
                                var options = _p3_UnityEngine_GUILayoutOptionArray;
                                var _ret0 = global::UnityEditor.EditorGUILayout.TagField(label, tag, style, options);
                                var _lret0 = new global::Lua.LuaValue(_ret0);
                                var _retCount = _context.Return(_lret0);
                                return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                            }
                        }
                    }
                }
                _lastArgPos = 1; _expectedType = typeof(global::UnityEngine.GUIStyle);
                if (_arg1.TryRead<global::UnityEngine.GUIStyle>(out var _p1_UnityEngine_GUIStyle))
                {
                    var _arg2 = _lastArg = _argCount > 2 ? _context.GetArgument(2) : global::Lua.LuaValue.Nil;
                    _lastArgPos = 2; _expectedType = typeof(global::UnityEngine.GUILayoutOption[]);
                    if (_arg2.TryReadArray<global::UnityEngine.GUILayoutOption>(out var _p2_UnityEngine_GUILayoutOptionArray))
                    {
                        if (_argCount == 3)
                        {
                            var tag = _p0_System_String;
                            var style = _p1_UnityEngine_GUIStyle;
                            var options = _p2_UnityEngine_GUILayoutOptionArray;
                            var _ret0 = global::UnityEditor.EditorGUILayout.TagField(tag, style, options);
                            var _lret0 = new global::Lua.LuaValue(_ret0);
                            var _retCount = _context.Return(_lret0);
                            return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                        }
                    }
                }
            }
            _lastArgPos = 0; _expectedType = typeof(global::UnityEngine.GUIContent);
            if (_arg0.TryRead<global::UnityEngine.GUIContent>(out var _p0_UnityEngine_GUIContent))
            {
                var _arg1 = _lastArg = _argCount > 1 ? _context.GetArgument(1) : global::Lua.LuaValue.Nil;
                _lastArgPos = 1; _expectedType = typeof(global::System.String);
                if (_arg1.TryRead<global::System.String>(out var _p1_System_String))
                {
                    var _arg2 = _lastArg = _argCount > 2 ? _context.GetArgument(2) : global::Lua.LuaValue.Nil;
                    _lastArgPos = 2; _expectedType = typeof(global::UnityEngine.GUILayoutOption[]);
                    if (_arg2.TryReadArray<global::UnityEngine.GUILayoutOption>(out var _p2_UnityEngine_GUILayoutOptionArray))
                    {
                        if (_argCount == 3)
                        {
                            var label = _p0_UnityEngine_GUIContent;
                            var tag = _p1_System_String;
                            var options = _p2_UnityEngine_GUILayoutOptionArray;
                            var _ret0 = global::UnityEditor.EditorGUILayout.TagField(label, tag, options);
                            var _lret0 = new global::Lua.LuaValue(_ret0);
                            var _retCount = _context.Return(_lret0);
                            return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                        }
                    }
                    _lastArgPos = 2; _expectedType = typeof(global::UnityEngine.GUIStyle);
                    if (_arg2.TryRead<global::UnityEngine.GUIStyle>(out var _p2_UnityEngine_GUIStyle))
                    {
                        var _arg3 = _lastArg = _argCount > 3 ? _context.GetArgument(3) : global::Lua.LuaValue.Nil;
                        _lastArgPos = 3; _expectedType = typeof(global::UnityEngine.GUILayoutOption[]);
                        if (_arg3.TryReadArray<global::UnityEngine.GUILayoutOption>(out var _p3_UnityEngine_GUILayoutOptionArray))
                        {
                            if (_argCount == 4)
                            {
                                var label = _p0_UnityEngine_GUIContent;
                                var tag = _p1_System_String;
                                var style = _p2_UnityEngine_GUIStyle;
                                var options = _p3_UnityEngine_GUILayoutOptionArray;
                                var _ret0 = global::UnityEditor.EditorGUILayout.TagField(label, tag, style, options);
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
        private static readonly global::Lua.LuaFunction _LuaEditorGUILayout_TextArea = new global::Lua.LuaFunction("TextArea", (_context, _) =>
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
                _lastArgPos = 1; _expectedType = typeof(global::UnityEngine.GUILayoutOption[]);
                if (_arg1.TryReadArray<global::UnityEngine.GUILayoutOption>(out var _p1_UnityEngine_GUILayoutOptionArray))
                {
                    if (_argCount == 2)
                    {
                        var text = _p0_System_String;
                        var options = _p1_UnityEngine_GUILayoutOptionArray;
                        var _ret0 = global::UnityEditor.EditorGUILayout.TextArea(text, options);
                        var _lret0 = new global::Lua.LuaValue(_ret0);
                        var _retCount = _context.Return(_lret0);
                        return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                    }
                }
                _lastArgPos = 1; _expectedType = typeof(global::UnityEngine.GUIStyle);
                if (_arg1.TryRead<global::UnityEngine.GUIStyle>(out var _p1_UnityEngine_GUIStyle))
                {
                    var _arg2 = _lastArg = _argCount > 2 ? _context.GetArgument(2) : global::Lua.LuaValue.Nil;
                    _lastArgPos = 2; _expectedType = typeof(global::UnityEngine.GUILayoutOption[]);
                    if (_arg2.TryReadArray<global::UnityEngine.GUILayoutOption>(out var _p2_UnityEngine_GUILayoutOptionArray))
                    {
                        if (_argCount == 3)
                        {
                            var text = _p0_System_String;
                            var style = _p1_UnityEngine_GUIStyle;
                            var options = _p2_UnityEngine_GUILayoutOptionArray;
                            var _ret0 = global::UnityEditor.EditorGUILayout.TextArea(text, style, options);
                            var _lret0 = new global::Lua.LuaValue(_ret0);
                            var _retCount = _context.Return(_lret0);
                            return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                        }
                    }
                }
            }
            throw new global::Lua.LuaRuntimeException(_context.Thread, $"{"TextArea"}: invalid argument #{_lastArgPos}: {_lastArg} ({_lastArg.Type}), expected: {_expectedType.FullName}", 2);
        });
        private static readonly global::Lua.LuaFunction _LuaEditorGUILayout_TextField = new global::Lua.LuaFunction("TextField", (_context, _) =>
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
                _lastArgPos = 1; _expectedType = typeof(global::UnityEngine.GUILayoutOption[]);
                if (_arg1.TryReadArray<global::UnityEngine.GUILayoutOption>(out var _p1_UnityEngine_GUILayoutOptionArray))
                {
                    if (_argCount == 2)
                    {
                        var text = _p0_System_String;
                        var options = _p1_UnityEngine_GUILayoutOptionArray;
                        var _ret0 = global::UnityEditor.EditorGUILayout.TextField(text, options);
                        var _lret0 = new global::Lua.LuaValue(_ret0);
                        var _retCount = _context.Return(_lret0);
                        return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                    }
                }
                _lastArgPos = 1; _expectedType = typeof(global::System.String);
                if (_arg1.TryRead<global::System.String>(out var _p1_System_String))
                {
                    var _arg2 = _lastArg = _argCount > 2 ? _context.GetArgument(2) : global::Lua.LuaValue.Nil;
                    _lastArgPos = 2; _expectedType = typeof(global::UnityEngine.GUILayoutOption[]);
                    if (_arg2.TryReadArray<global::UnityEngine.GUILayoutOption>(out var _p2_UnityEngine_GUILayoutOptionArray))
                    {
                        if (_argCount == 3)
                        {
                            var label = _p0_System_String;
                            var text = _p1_System_String;
                            var options = _p2_UnityEngine_GUILayoutOptionArray;
                            var _ret0 = global::UnityEditor.EditorGUILayout.TextField(label, text, options);
                            var _lret0 = new global::Lua.LuaValue(_ret0);
                            var _retCount = _context.Return(_lret0);
                            return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                        }
                    }
                    _lastArgPos = 2; _expectedType = typeof(global::UnityEngine.GUIStyle);
                    if (_arg2.TryRead<global::UnityEngine.GUIStyle>(out var _p2_UnityEngine_GUIStyle))
                    {
                        var _arg3 = _lastArg = _argCount > 3 ? _context.GetArgument(3) : global::Lua.LuaValue.Nil;
                        _lastArgPos = 3; _expectedType = typeof(global::UnityEngine.GUILayoutOption[]);
                        if (_arg3.TryReadArray<global::UnityEngine.GUILayoutOption>(out var _p3_UnityEngine_GUILayoutOptionArray))
                        {
                            if (_argCount == 4)
                            {
                                var label = _p0_System_String;
                                var text = _p1_System_String;
                                var style = _p2_UnityEngine_GUIStyle;
                                var options = _p3_UnityEngine_GUILayoutOptionArray;
                                var _ret0 = global::UnityEditor.EditorGUILayout.TextField(label, text, style, options);
                                var _lret0 = new global::Lua.LuaValue(_ret0);
                                var _retCount = _context.Return(_lret0);
                                return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                            }
                        }
                    }
                }
                _lastArgPos = 1; _expectedType = typeof(global::UnityEngine.GUIStyle);
                if (_arg1.TryRead<global::UnityEngine.GUIStyle>(out var _p1_UnityEngine_GUIStyle))
                {
                    var _arg2 = _lastArg = _argCount > 2 ? _context.GetArgument(2) : global::Lua.LuaValue.Nil;
                    _lastArgPos = 2; _expectedType = typeof(global::UnityEngine.GUILayoutOption[]);
                    if (_arg2.TryReadArray<global::UnityEngine.GUILayoutOption>(out var _p2_UnityEngine_GUILayoutOptionArray))
                    {
                        if (_argCount == 3)
                        {
                            var text = _p0_System_String;
                            var style = _p1_UnityEngine_GUIStyle;
                            var options = _p2_UnityEngine_GUILayoutOptionArray;
                            var _ret0 = global::UnityEditor.EditorGUILayout.TextField(text, style, options);
                            var _lret0 = new global::Lua.LuaValue(_ret0);
                            var _retCount = _context.Return(_lret0);
                            return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                        }
                    }
                }
            }
            _lastArgPos = 0; _expectedType = typeof(global::UnityEngine.GUIContent);
            if (_arg0.TryRead<global::UnityEngine.GUIContent>(out var _p0_UnityEngine_GUIContent))
            {
                var _arg1 = _lastArg = _argCount > 1 ? _context.GetArgument(1) : global::Lua.LuaValue.Nil;
                _lastArgPos = 1; _expectedType = typeof(global::System.String);
                if (_arg1.TryRead<global::System.String>(out var _p1_System_String))
                {
                    var _arg2 = _lastArg = _argCount > 2 ? _context.GetArgument(2) : global::Lua.LuaValue.Nil;
                    _lastArgPos = 2; _expectedType = typeof(global::UnityEngine.GUILayoutOption[]);
                    if (_arg2.TryReadArray<global::UnityEngine.GUILayoutOption>(out var _p2_UnityEngine_GUILayoutOptionArray))
                    {
                        if (_argCount == 3)
                        {
                            var label = _p0_UnityEngine_GUIContent;
                            var text = _p1_System_String;
                            var options = _p2_UnityEngine_GUILayoutOptionArray;
                            var _ret0 = global::UnityEditor.EditorGUILayout.TextField(label, text, options);
                            var _lret0 = new global::Lua.LuaValue(_ret0);
                            var _retCount = _context.Return(_lret0);
                            return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                        }
                    }
                    _lastArgPos = 2; _expectedType = typeof(global::UnityEngine.GUIStyle);
                    if (_arg2.TryRead<global::UnityEngine.GUIStyle>(out var _p2_UnityEngine_GUIStyle))
                    {
                        var _arg3 = _lastArg = _argCount > 3 ? _context.GetArgument(3) : global::Lua.LuaValue.Nil;
                        _lastArgPos = 3; _expectedType = typeof(global::UnityEngine.GUILayoutOption[]);
                        if (_arg3.TryReadArray<global::UnityEngine.GUILayoutOption>(out var _p3_UnityEngine_GUILayoutOptionArray))
                        {
                            if (_argCount == 4)
                            {
                                var label = _p0_UnityEngine_GUIContent;
                                var text = _p1_System_String;
                                var style = _p2_UnityEngine_GUIStyle;
                                var options = _p3_UnityEngine_GUILayoutOptionArray;
                                var _ret0 = global::UnityEditor.EditorGUILayout.TextField(label, text, style, options);
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
        private static readonly global::Lua.LuaFunction _LuaEditorGUILayout_Toggle = new global::Lua.LuaFunction("Toggle", (_context, _) =>
        {
            global::Lua.LuaValue _lastArg = default;
            global::System.Int32 _lastArgPos = default;
            global::System.Type _expectedType = default;
            var _argCount = _context.ArgumentCount;
            var _arg0 = _lastArg = _argCount > 0 ? _context.GetArgument(0) : global::Lua.LuaValue.Nil;
            _lastArgPos = 0; _expectedType = typeof(global::System.Boolean);
            if (_arg0.TryRead<global::System.Boolean>(out var _p0_System_Boolean))
            {
                var _arg1 = _lastArg = _argCount > 1 ? _context.GetArgument(1) : global::Lua.LuaValue.Nil;
                _lastArgPos = 1; _expectedType = typeof(global::UnityEngine.GUILayoutOption[]);
                if (_arg1.TryReadArray<global::UnityEngine.GUILayoutOption>(out var _p1_UnityEngine_GUILayoutOptionArray))
                {
                    if (_argCount == 2)
                    {
                        var value = _p0_System_Boolean;
                        var options = _p1_UnityEngine_GUILayoutOptionArray;
                        var _ret0 = global::UnityEditor.EditorGUILayout.Toggle(value, options);
                        var _lret0 = new global::Lua.LuaValue(_ret0);
                        var _retCount = _context.Return(_lret0);
                        return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                    }
                }
                _lastArgPos = 1; _expectedType = typeof(global::UnityEngine.GUIStyle);
                if (_arg1.TryRead<global::UnityEngine.GUIStyle>(out var _p1_UnityEngine_GUIStyle))
                {
                    var _arg2 = _lastArg = _argCount > 2 ? _context.GetArgument(2) : global::Lua.LuaValue.Nil;
                    _lastArgPos = 2; _expectedType = typeof(global::UnityEngine.GUILayoutOption[]);
                    if (_arg2.TryReadArray<global::UnityEngine.GUILayoutOption>(out var _p2_UnityEngine_GUILayoutOptionArray))
                    {
                        if (_argCount == 3)
                        {
                            var value = _p0_System_Boolean;
                            var style = _p1_UnityEngine_GUIStyle;
                            var options = _p2_UnityEngine_GUILayoutOptionArray;
                            var _ret0 = global::UnityEditor.EditorGUILayout.Toggle(value, style, options);
                            var _lret0 = new global::Lua.LuaValue(_ret0);
                            var _retCount = _context.Return(_lret0);
                            return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                        }
                    }
                }
            }
            _lastArgPos = 0; _expectedType = typeof(global::System.String);
            if (_arg0.TryRead<global::System.String>(out var _p0_System_String))
            {
                var _arg1 = _lastArg = _argCount > 1 ? _context.GetArgument(1) : global::Lua.LuaValue.Nil;
                _lastArgPos = 1; _expectedType = typeof(global::System.Boolean);
                if (_arg1.TryRead<global::System.Boolean>(out var _p1_System_Boolean))
                {
                    var _arg2 = _lastArg = _argCount > 2 ? _context.GetArgument(2) : global::Lua.LuaValue.Nil;
                    _lastArgPos = 2; _expectedType = typeof(global::UnityEngine.GUILayoutOption[]);
                    if (_arg2.TryReadArray<global::UnityEngine.GUILayoutOption>(out var _p2_UnityEngine_GUILayoutOptionArray))
                    {
                        if (_argCount == 3)
                        {
                            var label = _p0_System_String;
                            var value = _p1_System_Boolean;
                            var options = _p2_UnityEngine_GUILayoutOptionArray;
                            var _ret0 = global::UnityEditor.EditorGUILayout.Toggle(label, value, options);
                            var _lret0 = new global::Lua.LuaValue(_ret0);
                            var _retCount = _context.Return(_lret0);
                            return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                        }
                    }
                    _lastArgPos = 2; _expectedType = typeof(global::UnityEngine.GUIStyle);
                    if (_arg2.TryRead<global::UnityEngine.GUIStyle>(out var _p2_UnityEngine_GUIStyle))
                    {
                        var _arg3 = _lastArg = _argCount > 3 ? _context.GetArgument(3) : global::Lua.LuaValue.Nil;
                        _lastArgPos = 3; _expectedType = typeof(global::UnityEngine.GUILayoutOption[]);
                        if (_arg3.TryReadArray<global::UnityEngine.GUILayoutOption>(out var _p3_UnityEngine_GUILayoutOptionArray))
                        {
                            if (_argCount == 4)
                            {
                                var label = _p0_System_String;
                                var value = _p1_System_Boolean;
                                var style = _p2_UnityEngine_GUIStyle;
                                var options = _p3_UnityEngine_GUILayoutOptionArray;
                                var _ret0 = global::UnityEditor.EditorGUILayout.Toggle(label, value, style, options);
                                var _lret0 = new global::Lua.LuaValue(_ret0);
                                var _retCount = _context.Return(_lret0);
                                return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                            }
                        }
                    }
                }
            }
            _lastArgPos = 0; _expectedType = typeof(global::UnityEngine.GUIContent);
            if (_arg0.TryRead<global::UnityEngine.GUIContent>(out var _p0_UnityEngine_GUIContent))
            {
                var _arg1 = _lastArg = _argCount > 1 ? _context.GetArgument(1) : global::Lua.LuaValue.Nil;
                _lastArgPos = 1; _expectedType = typeof(global::System.Boolean);
                if (_arg1.TryRead<global::System.Boolean>(out var _p1_System_Boolean))
                {
                    var _arg2 = _lastArg = _argCount > 2 ? _context.GetArgument(2) : global::Lua.LuaValue.Nil;
                    _lastArgPos = 2; _expectedType = typeof(global::UnityEngine.GUILayoutOption[]);
                    if (_arg2.TryReadArray<global::UnityEngine.GUILayoutOption>(out var _p2_UnityEngine_GUILayoutOptionArray))
                    {
                        if (_argCount == 3)
                        {
                            var label = _p0_UnityEngine_GUIContent;
                            var value = _p1_System_Boolean;
                            var options = _p2_UnityEngine_GUILayoutOptionArray;
                            var _ret0 = global::UnityEditor.EditorGUILayout.Toggle(label, value, options);
                            var _lret0 = new global::Lua.LuaValue(_ret0);
                            var _retCount = _context.Return(_lret0);
                            return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                        }
                    }
                    _lastArgPos = 2; _expectedType = typeof(global::UnityEngine.GUIStyle);
                    if (_arg2.TryRead<global::UnityEngine.GUIStyle>(out var _p2_UnityEngine_GUIStyle))
                    {
                        var _arg3 = _lastArg = _argCount > 3 ? _context.GetArgument(3) : global::Lua.LuaValue.Nil;
                        _lastArgPos = 3; _expectedType = typeof(global::UnityEngine.GUILayoutOption[]);
                        if (_arg3.TryReadArray<global::UnityEngine.GUILayoutOption>(out var _p3_UnityEngine_GUILayoutOptionArray))
                        {
                            if (_argCount == 4)
                            {
                                var label = _p0_UnityEngine_GUIContent;
                                var value = _p1_System_Boolean;
                                var style = _p2_UnityEngine_GUIStyle;
                                var options = _p3_UnityEngine_GUILayoutOptionArray;
                                var _ret0 = global::UnityEditor.EditorGUILayout.Toggle(label, value, style, options);
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
        private static readonly global::Lua.LuaFunction _LuaEditorGUILayout_ToggleLeft = new global::Lua.LuaFunction("ToggleLeft", (_context, _) =>
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
                _lastArgPos = 1; _expectedType = typeof(global::System.Boolean);
                if (_arg1.TryRead<global::System.Boolean>(out var _p1_System_Boolean))
                {
                    var _arg2 = _lastArg = _argCount > 2 ? _context.GetArgument(2) : global::Lua.LuaValue.Nil;
                    _lastArgPos = 2; _expectedType = typeof(global::UnityEngine.GUILayoutOption[]);
                    if (_arg2.TryReadArray<global::UnityEngine.GUILayoutOption>(out var _p2_UnityEngine_GUILayoutOptionArray))
                    {
                        if (_argCount == 3)
                        {
                            var label = _p0_System_String;
                            var value = _p1_System_Boolean;
                            var options = _p2_UnityEngine_GUILayoutOptionArray;
                            var _ret0 = global::UnityEditor.EditorGUILayout.ToggleLeft(label, value, options);
                            var _lret0 = new global::Lua.LuaValue(_ret0);
                            var _retCount = _context.Return(_lret0);
                            return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                        }
                    }
                    _lastArgPos = 2; _expectedType = typeof(global::UnityEngine.GUIStyle);
                    if (_arg2.TryRead<global::UnityEngine.GUIStyle>(out var _p2_UnityEngine_GUIStyle))
                    {
                        var _arg3 = _lastArg = _argCount > 3 ? _context.GetArgument(3) : global::Lua.LuaValue.Nil;
                        _lastArgPos = 3; _expectedType = typeof(global::UnityEngine.GUILayoutOption[]);
                        if (_arg3.TryReadArray<global::UnityEngine.GUILayoutOption>(out var _p3_UnityEngine_GUILayoutOptionArray))
                        {
                            if (_argCount == 4)
                            {
                                var label = _p0_System_String;
                                var value = _p1_System_Boolean;
                                var labelStyle = _p2_UnityEngine_GUIStyle;
                                var options = _p3_UnityEngine_GUILayoutOptionArray;
                                var _ret0 = global::UnityEditor.EditorGUILayout.ToggleLeft(label, value, labelStyle, options);
                                var _lret0 = new global::Lua.LuaValue(_ret0);
                                var _retCount = _context.Return(_lret0);
                                return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                            }
                        }
                    }
                }
            }
            _lastArgPos = 0; _expectedType = typeof(global::UnityEngine.GUIContent);
            if (_arg0.TryRead<global::UnityEngine.GUIContent>(out var _p0_UnityEngine_GUIContent))
            {
                var _arg1 = _lastArg = _argCount > 1 ? _context.GetArgument(1) : global::Lua.LuaValue.Nil;
                _lastArgPos = 1; _expectedType = typeof(global::System.Boolean);
                if (_arg1.TryRead<global::System.Boolean>(out var _p1_System_Boolean))
                {
                    var _arg2 = _lastArg = _argCount > 2 ? _context.GetArgument(2) : global::Lua.LuaValue.Nil;
                    _lastArgPos = 2; _expectedType = typeof(global::UnityEngine.GUILayoutOption[]);
                    if (_arg2.TryReadArray<global::UnityEngine.GUILayoutOption>(out var _p2_UnityEngine_GUILayoutOptionArray))
                    {
                        if (_argCount == 3)
                        {
                            var label = _p0_UnityEngine_GUIContent;
                            var value = _p1_System_Boolean;
                            var options = _p2_UnityEngine_GUILayoutOptionArray;
                            var _ret0 = global::UnityEditor.EditorGUILayout.ToggleLeft(label, value, options);
                            var _lret0 = new global::Lua.LuaValue(_ret0);
                            var _retCount = _context.Return(_lret0);
                            return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                        }
                    }
                    _lastArgPos = 2; _expectedType = typeof(global::UnityEngine.GUIStyle);
                    if (_arg2.TryRead<global::UnityEngine.GUIStyle>(out var _p2_UnityEngine_GUIStyle))
                    {
                        var _arg3 = _lastArg = _argCount > 3 ? _context.GetArgument(3) : global::Lua.LuaValue.Nil;
                        _lastArgPos = 3; _expectedType = typeof(global::UnityEngine.GUILayoutOption[]);
                        if (_arg3.TryReadArray<global::UnityEngine.GUILayoutOption>(out var _p3_UnityEngine_GUILayoutOptionArray))
                        {
                            if (_argCount == 4)
                            {
                                var label = _p0_UnityEngine_GUIContent;
                                var value = _p1_System_Boolean;
                                var labelStyle = _p2_UnityEngine_GUIStyle;
                                var options = _p3_UnityEngine_GUILayoutOptionArray;
                                var _ret0 = global::UnityEditor.EditorGUILayout.ToggleLeft(label, value, labelStyle, options);
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
        private static readonly global::Lua.LuaFunction _LuaEditorGUILayout_ToolContextToolbarForTarget = new global::Lua.LuaFunction("ToolContextToolbarForTarget", (_context, _) =>
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
                _lastArgPos = 1; _expectedType = typeof(global::UnityEngine.Object);
                if (_arg1.TryRead<global::UnityEngine.Object>(out var _p1_UnityEngine_Object))
                {
                    if (_argCount == 2)
                    {
                        var content = _p0_UnityEngine_GUIContent;
                        var target = _p1_UnityEngine_Object;
                        global::UnityEditor.EditorGUILayout.ToolContextToolbarForTarget(content, target);
                        var _retCount = _context.Return();
                        return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                    }
                }
            }
            throw new global::Lua.LuaRuntimeException(_context.Thread, $"{"ToolContextToolbarForTarget"}: invalid argument #{_lastArgPos}: {_lastArg} ({_lastArg.Type}), expected: {_expectedType.FullName}", 2);
        });
        private static readonly global::Lua.LuaFunction _LuaEditorGUILayout_Vector2Field = new global::Lua.LuaFunction("Vector2Field", (_context, _) =>
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
                _lastArgPos = 1; _expectedType = typeof(global::UnityEngine.Vector2);
                if (_arg1.TryRead<global::UnityEngine.Vector2>(out var _p1_UnityEngine_Vector2))
                {
                    var _arg2 = _lastArg = _argCount > 2 ? _context.GetArgument(2) : global::Lua.LuaValue.Nil;
                    _lastArgPos = 2; _expectedType = typeof(global::UnityEngine.GUILayoutOption[]);
                    if (_arg2.TryReadArray<global::UnityEngine.GUILayoutOption>(out var _p2_UnityEngine_GUILayoutOptionArray))
                    {
                        if (_argCount == 3)
                        {
                            var label = _p0_System_String;
                            var value = _p1_UnityEngine_Vector2;
                            var options = _p2_UnityEngine_GUILayoutOptionArray;
                            var _ret0 = global::UnityEditor.EditorGUILayout.Vector2Field(label, value, options);
                            var _factory = _context.GetObjectFactory();
                            var _lret0 = _factory.Bind(_ret0);
                            var _retCount = _context.Return(_lret0);
                            return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                        }
                    }
                }
            }
            _lastArgPos = 0; _expectedType = typeof(global::UnityEngine.GUIContent);
            if (_arg0.TryRead<global::UnityEngine.GUIContent>(out var _p0_UnityEngine_GUIContent))
            {
                var _arg1 = _lastArg = _argCount > 1 ? _context.GetArgument(1) : global::Lua.LuaValue.Nil;
                _lastArgPos = 1; _expectedType = typeof(global::UnityEngine.Vector2);
                if (_arg1.TryRead<global::UnityEngine.Vector2>(out var _p1_UnityEngine_Vector2))
                {
                    var _arg2 = _lastArg = _argCount > 2 ? _context.GetArgument(2) : global::Lua.LuaValue.Nil;
                    _lastArgPos = 2; _expectedType = typeof(global::UnityEngine.GUILayoutOption[]);
                    if (_arg2.TryReadArray<global::UnityEngine.GUILayoutOption>(out var _p2_UnityEngine_GUILayoutOptionArray))
                    {
                        if (_argCount == 3)
                        {
                            var label = _p0_UnityEngine_GUIContent;
                            var value = _p1_UnityEngine_Vector2;
                            var options = _p2_UnityEngine_GUILayoutOptionArray;
                            var _ret0 = global::UnityEditor.EditorGUILayout.Vector2Field(label, value, options);
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
        private static readonly global::Lua.LuaFunction _LuaEditorGUILayout_Vector2IntField = new global::Lua.LuaFunction("Vector2IntField", (_context, _) =>
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
                _lastArgPos = 1; _expectedType = typeof(global::UnityEngine.Vector2Int);
                if (_arg1.TryRead<global::UnityEngine.Vector2Int>(out var _p1_UnityEngine_Vector2Int))
                {
                    var _arg2 = _lastArg = _argCount > 2 ? _context.GetArgument(2) : global::Lua.LuaValue.Nil;
                    _lastArgPos = 2; _expectedType = typeof(global::UnityEngine.GUILayoutOption[]);
                    if (_arg2.TryReadArray<global::UnityEngine.GUILayoutOption>(out var _p2_UnityEngine_GUILayoutOptionArray))
                    {
                        if (_argCount == 3)
                        {
                            var label = _p0_System_String;
                            var value = _p1_UnityEngine_Vector2Int;
                            var options = _p2_UnityEngine_GUILayoutOptionArray;
                            var _ret0 = global::UnityEditor.EditorGUILayout.Vector2IntField(label, value, options);
                            var _factory = _context.GetObjectFactory();
                            var _lret0 = _factory.Bind(_ret0);
                            var _retCount = _context.Return(_lret0);
                            return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                        }
                    }
                }
            }
            _lastArgPos = 0; _expectedType = typeof(global::UnityEngine.GUIContent);
            if (_arg0.TryRead<global::UnityEngine.GUIContent>(out var _p0_UnityEngine_GUIContent))
            {
                var _arg1 = _lastArg = _argCount > 1 ? _context.GetArgument(1) : global::Lua.LuaValue.Nil;
                _lastArgPos = 1; _expectedType = typeof(global::UnityEngine.Vector2Int);
                if (_arg1.TryRead<global::UnityEngine.Vector2Int>(out var _p1_UnityEngine_Vector2Int))
                {
                    var _arg2 = _lastArg = _argCount > 2 ? _context.GetArgument(2) : global::Lua.LuaValue.Nil;
                    _lastArgPos = 2; _expectedType = typeof(global::UnityEngine.GUILayoutOption[]);
                    if (_arg2.TryReadArray<global::UnityEngine.GUILayoutOption>(out var _p2_UnityEngine_GUILayoutOptionArray))
                    {
                        if (_argCount == 3)
                        {
                            var label = _p0_UnityEngine_GUIContent;
                            var value = _p1_UnityEngine_Vector2Int;
                            var options = _p2_UnityEngine_GUILayoutOptionArray;
                            var _ret0 = global::UnityEditor.EditorGUILayout.Vector2IntField(label, value, options);
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
        private static readonly global::Lua.LuaFunction _LuaEditorGUILayout_Vector3Field = new global::Lua.LuaFunction("Vector3Field", (_context, _) =>
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
                _lastArgPos = 1; _expectedType = typeof(global::UnityEngine.Vector3);
                if (_arg1.TryRead<global::UnityEngine.Vector3>(out var _p1_UnityEngine_Vector3))
                {
                    var _arg2 = _lastArg = _argCount > 2 ? _context.GetArgument(2) : global::Lua.LuaValue.Nil;
                    _lastArgPos = 2; _expectedType = typeof(global::UnityEngine.GUILayoutOption[]);
                    if (_arg2.TryReadArray<global::UnityEngine.GUILayoutOption>(out var _p2_UnityEngine_GUILayoutOptionArray))
                    {
                        if (_argCount == 3)
                        {
                            var label = _p0_System_String;
                            var value = _p1_UnityEngine_Vector3;
                            var options = _p2_UnityEngine_GUILayoutOptionArray;
                            var _ret0 = global::UnityEditor.EditorGUILayout.Vector3Field(label, value, options);
                            var _factory = _context.GetObjectFactory();
                            var _lret0 = _factory.Bind(_ret0);
                            var _retCount = _context.Return(_lret0);
                            return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                        }
                    }
                }
            }
            _lastArgPos = 0; _expectedType = typeof(global::UnityEngine.GUIContent);
            if (_arg0.TryRead<global::UnityEngine.GUIContent>(out var _p0_UnityEngine_GUIContent))
            {
                var _arg1 = _lastArg = _argCount > 1 ? _context.GetArgument(1) : global::Lua.LuaValue.Nil;
                _lastArgPos = 1; _expectedType = typeof(global::UnityEngine.Vector3);
                if (_arg1.TryRead<global::UnityEngine.Vector3>(out var _p1_UnityEngine_Vector3))
                {
                    var _arg2 = _lastArg = _argCount > 2 ? _context.GetArgument(2) : global::Lua.LuaValue.Nil;
                    _lastArgPos = 2; _expectedType = typeof(global::UnityEngine.GUILayoutOption[]);
                    if (_arg2.TryReadArray<global::UnityEngine.GUILayoutOption>(out var _p2_UnityEngine_GUILayoutOptionArray))
                    {
                        if (_argCount == 3)
                        {
                            var label = _p0_UnityEngine_GUIContent;
                            var value = _p1_UnityEngine_Vector3;
                            var options = _p2_UnityEngine_GUILayoutOptionArray;
                            var _ret0 = global::UnityEditor.EditorGUILayout.Vector3Field(label, value, options);
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
        private static readonly global::Lua.LuaFunction _LuaEditorGUILayout_Vector3IntField = new global::Lua.LuaFunction("Vector3IntField", (_context, _) =>
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
                _lastArgPos = 1; _expectedType = typeof(global::UnityEngine.Vector3Int);
                if (_arg1.TryRead<global::UnityEngine.Vector3Int>(out var _p1_UnityEngine_Vector3Int))
                {
                    var _arg2 = _lastArg = _argCount > 2 ? _context.GetArgument(2) : global::Lua.LuaValue.Nil;
                    _lastArgPos = 2; _expectedType = typeof(global::UnityEngine.GUILayoutOption[]);
                    if (_arg2.TryReadArray<global::UnityEngine.GUILayoutOption>(out var _p2_UnityEngine_GUILayoutOptionArray))
                    {
                        if (_argCount == 3)
                        {
                            var label = _p0_System_String;
                            var value = _p1_UnityEngine_Vector3Int;
                            var options = _p2_UnityEngine_GUILayoutOptionArray;
                            var _ret0 = global::UnityEditor.EditorGUILayout.Vector3IntField(label, value, options);
                            var _factory = _context.GetObjectFactory();
                            var _lret0 = _factory.Bind(_ret0);
                            var _retCount = _context.Return(_lret0);
                            return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                        }
                    }
                }
            }
            _lastArgPos = 0; _expectedType = typeof(global::UnityEngine.GUIContent);
            if (_arg0.TryRead<global::UnityEngine.GUIContent>(out var _p0_UnityEngine_GUIContent))
            {
                var _arg1 = _lastArg = _argCount > 1 ? _context.GetArgument(1) : global::Lua.LuaValue.Nil;
                _lastArgPos = 1; _expectedType = typeof(global::UnityEngine.Vector3Int);
                if (_arg1.TryRead<global::UnityEngine.Vector3Int>(out var _p1_UnityEngine_Vector3Int))
                {
                    var _arg2 = _lastArg = _argCount > 2 ? _context.GetArgument(2) : global::Lua.LuaValue.Nil;
                    _lastArgPos = 2; _expectedType = typeof(global::UnityEngine.GUILayoutOption[]);
                    if (_arg2.TryReadArray<global::UnityEngine.GUILayoutOption>(out var _p2_UnityEngine_GUILayoutOptionArray))
                    {
                        if (_argCount == 3)
                        {
                            var label = _p0_UnityEngine_GUIContent;
                            var value = _p1_UnityEngine_Vector3Int;
                            var options = _p2_UnityEngine_GUILayoutOptionArray;
                            var _ret0 = global::UnityEditor.EditorGUILayout.Vector3IntField(label, value, options);
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
        private static readonly global::Lua.LuaFunction _LuaEditorGUILayout_Vector4Field = new global::Lua.LuaFunction("Vector4Field", (_context, _) =>
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
                _lastArgPos = 1; _expectedType = typeof(global::UnityEngine.Vector4);
                if (_arg1.TryRead<global::UnityEngine.Vector4>(out var _p1_UnityEngine_Vector4))
                {
                    var _arg2 = _lastArg = _argCount > 2 ? _context.GetArgument(2) : global::Lua.LuaValue.Nil;
                    _lastArgPos = 2; _expectedType = typeof(global::UnityEngine.GUILayoutOption[]);
                    if (_arg2.TryReadArray<global::UnityEngine.GUILayoutOption>(out var _p2_UnityEngine_GUILayoutOptionArray))
                    {
                        if (_argCount == 3)
                        {
                            var label = _p0_System_String;
                            var value = _p1_UnityEngine_Vector4;
                            var options = _p2_UnityEngine_GUILayoutOptionArray;
                            var _ret0 = global::UnityEditor.EditorGUILayout.Vector4Field(label, value, options);
                            var _factory = _context.GetObjectFactory();
                            var _lret0 = _factory.Bind(_ret0);
                            var _retCount = _context.Return(_lret0);
                            return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                        }
                    }
                }
            }
            _lastArgPos = 0; _expectedType = typeof(global::UnityEngine.GUIContent);
            if (_arg0.TryRead<global::UnityEngine.GUIContent>(out var _p0_UnityEngine_GUIContent))
            {
                var _arg1 = _lastArg = _argCount > 1 ? _context.GetArgument(1) : global::Lua.LuaValue.Nil;
                _lastArgPos = 1; _expectedType = typeof(global::UnityEngine.Vector4);
                if (_arg1.TryRead<global::UnityEngine.Vector4>(out var _p1_UnityEngine_Vector4))
                {
                    var _arg2 = _lastArg = _argCount > 2 ? _context.GetArgument(2) : global::Lua.LuaValue.Nil;
                    _lastArgPos = 2; _expectedType = typeof(global::UnityEngine.GUILayoutOption[]);
                    if (_arg2.TryReadArray<global::UnityEngine.GUILayoutOption>(out var _p2_UnityEngine_GUILayoutOptionArray))
                    {
                        if (_argCount == 3)
                        {
                            var label = _p0_UnityEngine_GUIContent;
                            var value = _p1_UnityEngine_Vector4;
                            var options = _p2_UnityEngine_GUILayoutOptionArray;
                            var _ret0 = global::UnityEditor.EditorGUILayout.Vector4Field(label, value, options);
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
            var _this = _context.GetArgument<LuaEditorGUILayoutType>(0);
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
            var _this = _context.GetArgument<LuaEditorGUILayoutType>(0);
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
                case "new": _value = _LuaEditorGUILayout_new; return true;
                case "BeginBuildTargetSelectionGrouping": _value = _LuaEditorGUILayout_BeginBuildTargetSelectionGrouping; return true;
                case "BeginFadeGroup": _value = _LuaEditorGUILayout_BeginFadeGroup; return true;
                case "BeginHorizontal": _value = _LuaEditorGUILayout_BeginHorizontal; return true;
                case "BeginScrollView": _value = _LuaEditorGUILayout_BeginScrollView; return true;
                case "BeginToggleGroup": _value = _LuaEditorGUILayout_BeginToggleGroup; return true;
                case "BeginVertical": _value = _LuaEditorGUILayout_BeginVertical; return true;
                case "BoundsField": _value = _LuaEditorGUILayout_BoundsField; return true;
                case "BoundsIntField": _value = _LuaEditorGUILayout_BoundsIntField; return true;
                case "ColorField": _value = _LuaEditorGUILayout_ColorField; return true;
                case "CurveField": _value = _LuaEditorGUILayout_CurveField; return true;
                case "DelayedDoubleField": _value = _LuaEditorGUILayout_DelayedDoubleField; return true;
                case "DelayedFloatField": _value = _LuaEditorGUILayout_DelayedFloatField; return true;
                case "DelayedIntField": _value = _LuaEditorGUILayout_DelayedIntField; return true;
                case "DelayedTextField": _value = _LuaEditorGUILayout_DelayedTextField; return true;
                case "DoubleField": _value = _LuaEditorGUILayout_DoubleField; return true;
                case "DropdownButton": _value = _LuaEditorGUILayout_DropdownButton; return true;
                case "EditorToolbar": _value = _LuaEditorGUILayout_EditorToolbar; return true;
                case "EditorToolbarForTarget": _value = _LuaEditorGUILayout_EditorToolbarForTarget; return true;
                case "EndBuildTargetSelectionGrouping": _value = _LuaEditorGUILayout_EndBuildTargetSelectionGrouping; return true;
                case "EndFadeGroup": _value = _LuaEditorGUILayout_EndFadeGroup; return true;
                case "EndFoldoutHeaderGroup": _value = _LuaEditorGUILayout_EndFoldoutHeaderGroup; return true;
                case "EndHorizontal": _value = _LuaEditorGUILayout_EndHorizontal; return true;
                case "EndScrollView": _value = _LuaEditorGUILayout_EndScrollView; return true;
                case "EndToggleGroup": _value = _LuaEditorGUILayout_EndToggleGroup; return true;
                case "EndVertical": _value = _LuaEditorGUILayout_EndVertical; return true;
                case "EnumFlagsField": _value = _LuaEditorGUILayout_EnumFlagsField; return true;
                case "EnumPopup": _value = _LuaEditorGUILayout_EnumPopup; return true;
                case "FloatField": _value = _LuaEditorGUILayout_FloatField; return true;
                case "Foldout": _value = _LuaEditorGUILayout_Foldout; return true;
                case "GetControlRect": _value = _LuaEditorGUILayout_GetControlRect; return true;
                case "GradientField": _value = _LuaEditorGUILayout_GradientField; return true;
                case "HelpBox": _value = _LuaEditorGUILayout_HelpBox; return true;
                case "InspectorTitlebar": _value = _LuaEditorGUILayout_InspectorTitlebar; return true;
                case "IntField": _value = _LuaEditorGUILayout_IntField; return true;
                case "IntPopup": _value = _LuaEditorGUILayout_IntPopup; return true;
                case "IntSlider": _value = _LuaEditorGUILayout_IntSlider; return true;
                case "Knob": _value = _LuaEditorGUILayout_Knob; return true;
                case "LabelField": _value = _LuaEditorGUILayout_LabelField; return true;
                case "LayerField": _value = _LuaEditorGUILayout_LayerField; return true;
                case "LinkButton": _value = _LuaEditorGUILayout_LinkButton; return true;
                case "LongField": _value = _LuaEditorGUILayout_LongField; return true;
                case "MaskField": _value = _LuaEditorGUILayout_MaskField; return true;
                case "ObjectField": _value = _LuaEditorGUILayout_ObjectField; return true;
                case "PasswordField": _value = _LuaEditorGUILayout_PasswordField; return true;
                case "Popup": _value = _LuaEditorGUILayout_Popup; return true;
                case "PrefixLabel": _value = _LuaEditorGUILayout_PrefixLabel; return true;
                case "PropertyField": _value = _LuaEditorGUILayout_PropertyField; return true;
                case "RectField": _value = _LuaEditorGUILayout_RectField; return true;
                case "RectIntField": _value = _LuaEditorGUILayout_RectIntField; return true;
                case "RenderingLayerMaskField": _value = _LuaEditorGUILayout_RenderingLayerMaskField; return true;
                case "SelectableLabel": _value = _LuaEditorGUILayout_SelectableLabel; return true;
                case "Separator": _value = _LuaEditorGUILayout_Separator; return true;
                case "Slider": _value = _LuaEditorGUILayout_Slider; return true;
                case "Space": _value = _LuaEditorGUILayout_Space; return true;
                case "TagField": _value = _LuaEditorGUILayout_TagField; return true;
                case "TextArea": _value = _LuaEditorGUILayout_TextArea; return true;
                case "TextField": _value = _LuaEditorGUILayout_TextField; return true;
                case "Toggle": _value = _LuaEditorGUILayout_Toggle; return true;
                case "ToggleLeft": _value = _LuaEditorGUILayout_ToggleLeft; return true;
                case "ToolContextToolbarForTarget": _value = _LuaEditorGUILayout_ToolContextToolbarForTarget; return true;
                case "Vector2Field": _value = _LuaEditorGUILayout_Vector2Field; return true;
                case "Vector2IntField": _value = _LuaEditorGUILayout_Vector2IntField; return true;
                case "Vector3Field": _value = _LuaEditorGUILayout_Vector3Field; return true;
                case "Vector3IntField": _value = _LuaEditorGUILayout_Vector3IntField; return true;
                case "Vector4Field": _value = _LuaEditorGUILayout_Vector4Field; return true;
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
