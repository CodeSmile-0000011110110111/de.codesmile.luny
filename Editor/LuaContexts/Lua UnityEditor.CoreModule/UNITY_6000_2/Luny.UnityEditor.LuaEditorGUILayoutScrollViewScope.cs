
// --------------------------------------------------------------
// GENERATED FILE ----> DO NOT EDIT <---- CHANGES WILL BE LOST !!
// --------------------------------------------------------------

#if UNITY_6000_2_OR_NEWER && !(UNITY_6000_3_OR_NEWER)
#pragma warning disable 0109, 0162, 0168, 0219
using Luny;

namespace Luny.UnityEditor
{
    public sealed class LuaEditorGUILayoutScrollViewScope : global::Luny.ILuaObject<global::UnityEditor.EditorGUILayout.ScrollViewScope>
    {
        public new static global::Lua.LuaValue Bind(global::UnityEditor.EditorGUILayout.ScrollViewScope instance) => new LuaEditorGUILayoutScrollViewScope(instance);
        public new static global::Lua.LuaValue Bind(global::System.Object instance) => Bind((global::UnityEditor.EditorGUILayout.ScrollViewScope)instance);
        public new static global::Lua.LuaValue Bind(global::System.Collections.Generic.IList<global::UnityEditor.EditorGUILayout.ScrollViewScope> instances) =>
            new global::Luny.LuaList<global::UnityEditor.EditorGUILayout.ScrollViewScope>(instances);
        public new static global::Lua.LuaValue Bind(global::System.Collections.Generic.IList<global::System.Object> instances) =>
            new global::Luny.LuaList<global::UnityEditor.EditorGUILayout.ScrollViewScope>(instances);
        private LuaEditorGUILayoutScrollViewScope(global::UnityEditor.EditorGUILayout.ScrollViewScope instance) => m_Instance = instance;
        public static implicit operator global::Lua.LuaValue(LuaEditorGUILayoutScrollViewScope value) => new(value);
        private global::UnityEditor.EditorGUILayout.ScrollViewScope m_Instance;
        public global::UnityEditor.EditorGUILayout.ScrollViewScope Instance => m_Instance;
        public new global::System.Type BindType => typeof(global::UnityEditor.EditorGUILayout.ScrollViewScope);
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
            var _this = _context.GetArgument<LuaEditorGUILayoutScrollViewScope>(0);
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
            var _this = _context.GetArgument<LuaEditorGUILayoutScrollViewScope>(0);
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
                case "handleScrollWheel": _value = new global::Lua.LuaValue(Instance.handleScrollWheel); return true;
                case "scrollPosition": _value = _factory.Bind(Instance.scrollPosition); return true;
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
                case "handleScrollWheel": Instance.handleScrollWheel = _value.Read<global::System.Boolean>();  return true;
                default: return false;
            }
        }
    }
    public sealed class LuaEditorGUILayoutScrollViewScopeType : global::Luny.ILuaStatic
    {
        public static global::Lua.LuaValue Bind() => new LuaEditorGUILayoutScrollViewScopeType();
        private LuaEditorGUILayoutScrollViewScopeType() {}
        public static implicit operator global::Lua.LuaValue(LuaEditorGUILayoutScrollViewScopeType value) => new(value);
        public global::System.Type BindType => typeof(global::UnityEditor.EditorGUILayout.ScrollViewScope);
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

        private static readonly global::Lua.LuaFunction _LuaEditorGUILayoutScrollViewScope_new = new global::Lua.LuaFunction(".ctor", (_context, _) =>
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
                        var _ret0 = new global::UnityEditor.EditorGUILayout.ScrollViewScope(scrollPosition, options);
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
                            var _ret0 = new global::UnityEditor.EditorGUILayout.ScrollViewScope(scrollPosition, style, options);
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
                                var _ret0 = new global::UnityEditor.EditorGUILayout.ScrollViewScope(scrollPosition, horizontalScrollbar, verticalScrollbar, options);
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
                                var _ret0 = new global::UnityEditor.EditorGUILayout.ScrollViewScope(scrollPosition, alwaysShowHorizontal, alwaysShowVertical, options);
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
                                            var _ret0 = new global::UnityEditor.EditorGUILayout.ScrollViewScope(scrollPosition, alwaysShowHorizontal, alwaysShowVertical, horizontalScrollbar, verticalScrollbar, background, options);
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
            var _this = _context.GetArgument<LuaEditorGUILayoutScrollViewScopeType>(0);
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
            var _this = _context.GetArgument<LuaEditorGUILayoutScrollViewScopeType>(0);
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
                case "new": _value = _LuaEditorGUILayoutScrollViewScope_new; return true;
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
