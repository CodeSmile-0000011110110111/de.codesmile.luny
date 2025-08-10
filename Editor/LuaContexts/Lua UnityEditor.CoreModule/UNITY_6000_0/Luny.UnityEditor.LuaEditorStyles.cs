
// --------------------------------------------------------------
// GENERATED FILE ----> DO NOT EDIT <---- CHANGES WILL BE LOST !!
// --------------------------------------------------------------

#if UNITY_6000_0_OR_NEWER && !(UNITY_6000_1_OR_NEWER)
#pragma warning disable 0109, 0162, 0168, 0219
using Luny;

namespace Luny.UnityEditor
{
    public sealed class LuaEditorStyles : global::Luny.ILuaObject<global::UnityEditor.EditorStyles>
    {
        public new static global::Lua.LuaValue Bind(global::UnityEditor.EditorStyles instance) => new LuaEditorStyles(instance);
        public new static global::Lua.LuaValue Bind(global::System.Object instance) => Bind((global::UnityEditor.EditorStyles)instance);
        public new static global::Lua.LuaValue Bind(global::System.Collections.Generic.IList<global::UnityEditor.EditorStyles> instances) =>
            new global::Luny.LuaList<global::UnityEditor.EditorStyles>(instances);
        public new static global::Lua.LuaValue Bind(global::System.Collections.Generic.IList<global::System.Object> instances) =>
            new global::Luny.LuaList<global::UnityEditor.EditorStyles>(instances);
        private LuaEditorStyles(global::UnityEditor.EditorStyles instance) => m_Instance = instance;
        public static implicit operator global::Lua.LuaValue(LuaEditorStyles value) => new(value);
        private global::UnityEditor.EditorStyles m_Instance;
        public global::UnityEditor.EditorStyles Instance => m_Instance;
        public new global::System.Type BindType => typeof(global::UnityEditor.EditorStyles);
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
            var _this = _context.GetArgument<LuaEditorStyles>(0);
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
            var _this = _context.GetArgument<LuaEditorStyles>(0);
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
    public sealed class LuaEditorStylesType : global::Luny.ILuaStatic
    {
        public static global::Lua.LuaValue Bind() => new LuaEditorStylesType();
        private LuaEditorStylesType() {}
        public static implicit operator global::Lua.LuaValue(LuaEditorStylesType value) => new(value);
        public global::System.Type BindType => typeof(global::UnityEditor.EditorStyles);
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

        private static readonly global::Lua.LuaFunction _LuaEditorStyles_new = new global::Lua.LuaFunction(".ctor", (_context, _) =>
        {
            global::Lua.LuaValue _lastArg = default;
            global::System.Int32 _lastArgPos = default;
            global::System.Type _expectedType = default;
            var _argCount = _context.ArgumentCount;
            if (_argCount == 0)
            {
                var _ret0 = new global::UnityEditor.EditorStyles();
                var _factory = _context.GetObjectFactory();
                var _lret0 = _factory.Bind(_ret0);
                var _retCount = _context.Return(_lret0);
                return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
            }
            throw new global::Lua.LuaRuntimeException(_context.Thread, $"{".ctor"}: invalid argument #{_lastArgPos}: {_lastArg} ({_lastArg.Type}), expected: {_expectedType.FullName}", 2);
        });
        private static readonly global::Lua.LuaFunction _LuaEditorStyles_ApplyUSS = new global::Lua.LuaFunction("ApplyUSS", (_context, _) =>
        {
            global::Lua.LuaValue _lastArg = default;
            global::System.Int32 _lastArgPos = default;
            global::System.Type _expectedType = default;
            var _argCount = _context.ArgumentCount;
            var _arg0 = _lastArg = _argCount > 0 ? _context.GetArgument(0) : global::Lua.LuaValue.Nil;
            _lastArgPos = 0; _expectedType = typeof(global::UnityEngine.GUIStyle);
            if (_arg0.TryRead<global::UnityEngine.GUIStyle>(out var _p0_UnityEngine_GUIStyle))
            {
                var _arg1 = _lastArg = _argCount > 1 ? _context.GetArgument(1) : global::Lua.LuaValue.Nil;
                _lastArgPos = 1; _expectedType = typeof(global::System.String);
                if (_arg1.TryRead<global::System.String>(out var _p1_System_String))
                {
                    if (_argCount == 2)
                    {
                        var style = _p0_UnityEngine_GUIStyle;
                        var ussStyleRuleName = _p1_System_String;
                        var _ret0 = global::UnityEditor.EditorStyles.ApplyUSS(style, ussStyleRuleName);
                        var _factory = _context.GetObjectFactory();
                        var _lret0 = _factory.Bind(_ret0);
                        var _retCount = _context.Return(_lret0);
                        return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                    }
                    var _arg2 = _lastArg = _argCount > 2 ? _context.GetArgument(2) : global::Lua.LuaValue.Nil;
                    _lastArgPos = 2; _expectedType = typeof(global::System.String);
                    var _p2_System_String = _arg2.ReadValue<global::System.String>(default);
                    {
                        if (_argCount == 3)
                        {
                            var style = _p0_UnityEngine_GUIStyle;
                            var ussStyleRuleName = _p1_System_String;
                            var ussInPlaceStyleOverride = _p2_System_String;
                            var _ret0 = global::UnityEditor.EditorStyles.ApplyUSS(style, ussStyleRuleName, ussInPlaceStyleOverride);
                            var _factory = _context.GetObjectFactory();
                            var _lret0 = _factory.Bind(_ret0);
                            var _retCount = _context.Return(_lret0);
                            return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                        }
                    }
                }
            }
            throw new global::Lua.LuaRuntimeException(_context.Thread, $"{"ApplyUSS"}: invalid argument #{_lastArgPos}: {_lastArg} ({_lastArg.Type}), expected: {_expectedType.FullName}", 2);
        });
        private static readonly global::Lua.LuaFunction _LuaEditorStyles_FromUSS = new global::Lua.LuaFunction("FromUSS", (_context, _) =>
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
                    var ussStyleRuleName = _p0_System_String;
                    var _ret0 = global::UnityEditor.EditorStyles.FromUSS(ussStyleRuleName);
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
                        var ussStyleRuleName = _p0_System_String;
                        var ussInPlaceStyleOverride = _p1_System_String;
                        var _ret0 = global::UnityEditor.EditorStyles.FromUSS(ussStyleRuleName, ussInPlaceStyleOverride);
                        var _factory = _context.GetObjectFactory();
                        var _lret0 = _factory.Bind(_ret0);
                        var _retCount = _context.Return(_lret0);
                        return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                    }
                }
            }
            _lastArgPos = 0; _expectedType = typeof(global::UnityEngine.GUIStyle);
            if (_arg0.TryRead<global::UnityEngine.GUIStyle>(out var _p0_UnityEngine_GUIStyle))
            {
                var _arg1 = _lastArg = _argCount > 1 ? _context.GetArgument(1) : global::Lua.LuaValue.Nil;
                _lastArgPos = 1; _expectedType = typeof(global::System.String);
                if (_arg1.TryRead<global::System.String>(out var _p1_System_String))
                {
                    if (_argCount == 2)
                    {
                        var baseStyle = _p0_UnityEngine_GUIStyle;
                        var ussStyleRuleName = _p1_System_String;
                        var _ret0 = global::UnityEditor.EditorStyles.FromUSS(baseStyle, ussStyleRuleName);
                        var _factory = _context.GetObjectFactory();
                        var _lret0 = _factory.Bind(_ret0);
                        var _retCount = _context.Return(_lret0);
                        return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                    }
                    var _arg2 = _lastArg = _argCount > 2 ? _context.GetArgument(2) : global::Lua.LuaValue.Nil;
                    _lastArgPos = 2; _expectedType = typeof(global::System.String);
                    var _p2_System_String = _arg2.ReadValue<global::System.String>(default);
                    {
                        if (_argCount == 3)
                        {
                            var baseStyle = _p0_UnityEngine_GUIStyle;
                            var ussStyleRuleName = _p1_System_String;
                            var ussInPlaceStyleOverride = _p2_System_String;
                            var _ret0 = global::UnityEditor.EditorStyles.FromUSS(baseStyle, ussStyleRuleName, ussInPlaceStyleOverride);
                            var _factory = _context.GetObjectFactory();
                            var _lret0 = _factory.Bind(_ret0);
                            var _retCount = _context.Return(_lret0);
                            return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                        }
                    }
                }
            }
            throw new global::Lua.LuaRuntimeException(_context.Thread, $"{"FromUSS"}: invalid argument #{_lastArgPos}: {_lastArg} ({_lastArg.Type}), expected: {_expectedType.FullName}", 2);
        });
        private static readonly global::Lua.LuaFunction __index = new(global::Lua.Runtime.Metamethods.Index, (_context, _) =>
        {
            var _this = _context.GetArgument<LuaEditorStylesType>(0);
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
            var _this = _context.GetArgument<LuaEditorStylesType>(0);
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
                case "new": _value = _LuaEditorStyles_new; return true;
                case "ApplyUSS": _value = _LuaEditorStyles_ApplyUSS; return true;
                case "FromUSS": _value = _LuaEditorStyles_FromUSS; return true;
                case "boldFont": _value = _factory.Bind(global::UnityEditor.EditorStyles.boldFont); return true;
                case "boldLabel": _value = _factory.Bind(global::UnityEditor.EditorStyles.boldLabel); return true;
                case "centeredGreyMiniLabel": _value = _factory.Bind(global::UnityEditor.EditorStyles.centeredGreyMiniLabel); return true;
                case "colorField": _value = _factory.Bind(global::UnityEditor.EditorStyles.colorField); return true;
                case "foldout": _value = _factory.Bind(global::UnityEditor.EditorStyles.foldout); return true;
                case "foldoutHeader": _value = _factory.Bind(global::UnityEditor.EditorStyles.foldoutHeader); return true;
                case "foldoutHeaderIcon": _value = _factory.Bind(global::UnityEditor.EditorStyles.foldoutHeaderIcon); return true;
                case "foldoutPreDrop": _value = _factory.Bind(global::UnityEditor.EditorStyles.foldoutPreDrop); return true;
                case "helpBox": _value = _factory.Bind(global::UnityEditor.EditorStyles.helpBox); return true;
                case "iconButton": _value = _factory.Bind(global::UnityEditor.EditorStyles.iconButton); return true;
                case "inspectorDefaultMargins": _value = _factory.Bind(global::UnityEditor.EditorStyles.inspectorDefaultMargins); return true;
                case "inspectorFullWidthMargins": _value = _factory.Bind(global::UnityEditor.EditorStyles.inspectorFullWidthMargins); return true;
                case "label": _value = _factory.Bind(global::UnityEditor.EditorStyles.label); return true;
                case "largeLabel": _value = _factory.Bind(global::UnityEditor.EditorStyles.largeLabel); return true;
                case "layerMaskField": _value = _factory.Bind(global::UnityEditor.EditorStyles.layerMaskField); return true;
                case "linkLabel": _value = _factory.Bind(global::UnityEditor.EditorStyles.linkLabel); return true;
                case "miniBoldFont": _value = _factory.Bind(global::UnityEditor.EditorStyles.miniBoldFont); return true;
                case "miniBoldLabel": _value = _factory.Bind(global::UnityEditor.EditorStyles.miniBoldLabel); return true;
                case "miniButton": _value = _factory.Bind(global::UnityEditor.EditorStyles.miniButton); return true;
                case "miniButtonLeft": _value = _factory.Bind(global::UnityEditor.EditorStyles.miniButtonLeft); return true;
                case "miniButtonMid": _value = _factory.Bind(global::UnityEditor.EditorStyles.miniButtonMid); return true;
                case "miniButtonRight": _value = _factory.Bind(global::UnityEditor.EditorStyles.miniButtonRight); return true;
                case "miniFont": _value = _factory.Bind(global::UnityEditor.EditorStyles.miniFont); return true;
                case "miniLabel": _value = _factory.Bind(global::UnityEditor.EditorStyles.miniLabel); return true;
                case "miniPullDown": _value = _factory.Bind(global::UnityEditor.EditorStyles.miniPullDown); return true;
                case "miniTextField": _value = _factory.Bind(global::UnityEditor.EditorStyles.miniTextField); return true;
                case "numberField": _value = _factory.Bind(global::UnityEditor.EditorStyles.numberField); return true;
                case "objectField": _value = _factory.Bind(global::UnityEditor.EditorStyles.objectField); return true;
                case "objectFieldMiniThumb": _value = _factory.Bind(global::UnityEditor.EditorStyles.objectFieldMiniThumb); return true;
                case "objectFieldThumb": _value = _factory.Bind(global::UnityEditor.EditorStyles.objectFieldThumb); return true;
                case "popup": _value = _factory.Bind(global::UnityEditor.EditorStyles.popup); return true;
                case "radioButton": _value = _factory.Bind(global::UnityEditor.EditorStyles.radioButton); return true;
                case "selectionRect": _value = _factory.Bind(global::UnityEditor.EditorStyles.selectionRect); return true;
                case "standardFont": _value = _factory.Bind(global::UnityEditor.EditorStyles.standardFont); return true;
                case "textArea": _value = _factory.Bind(global::UnityEditor.EditorStyles.textArea); return true;
                case "textField": _value = _factory.Bind(global::UnityEditor.EditorStyles.textField); return true;
                case "toggle": _value = _factory.Bind(global::UnityEditor.EditorStyles.toggle); return true;
                case "toggleGroup": _value = _factory.Bind(global::UnityEditor.EditorStyles.toggleGroup); return true;
                case "toolbar": _value = _factory.Bind(global::UnityEditor.EditorStyles.toolbar); return true;
                case "toolbarButton": _value = _factory.Bind(global::UnityEditor.EditorStyles.toolbarButton); return true;
                case "toolbarDropDown": _value = _factory.Bind(global::UnityEditor.EditorStyles.toolbarDropDown); return true;
                case "toolbarPopup": _value = _factory.Bind(global::UnityEditor.EditorStyles.toolbarPopup); return true;
                case "toolbarSearchField": _value = _factory.Bind(global::UnityEditor.EditorStyles.toolbarSearchField); return true;
                case "toolbarTextField": _value = _factory.Bind(global::UnityEditor.EditorStyles.toolbarTextField); return true;
                case "whiteBoldLabel": _value = _factory.Bind(global::UnityEditor.EditorStyles.whiteBoldLabel); return true;
                case "whiteLabel": _value = _factory.Bind(global::UnityEditor.EditorStyles.whiteLabel); return true;
                case "whiteLargeLabel": _value = _factory.Bind(global::UnityEditor.EditorStyles.whiteLargeLabel); return true;
                case "whiteMiniLabel": _value = _factory.Bind(global::UnityEditor.EditorStyles.whiteMiniLabel); return true;
                case "wordWrappedLabel": _value = _factory.Bind(global::UnityEditor.EditorStyles.wordWrappedLabel); return true;
                case "wordWrappedMiniLabel": _value = _factory.Bind(global::UnityEditor.EditorStyles.wordWrappedMiniLabel); return true;
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
