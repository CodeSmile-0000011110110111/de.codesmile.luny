
// --------------------------------------------------------------
// GENERATED FILE ----> DO NOT EDIT <---- CHANGES WILL BE LOST !!
// --------------------------------------------------------------

#if UNITY_6000_0_OR_NEWER && !(UNITY_6000_1_OR_NEWER)
#pragma warning disable 0109, 0162, 0168, 0219
using Luny;

namespace Luny.UnityEditor
{
    public class LuaMaterialEditor : global::Luny.UnityEditor.LuaEditor, global::Luny.ILuaObject<global::UnityEditor.MaterialEditor>
    {
        public new static global::Lua.LuaValue Bind(global::UnityEditor.MaterialEditor instance) => new LuaMaterialEditor(instance);
        public new static global::Lua.LuaValue Bind(global::System.Object instance) => Bind((global::UnityEditor.MaterialEditor)instance);
        public new static global::Lua.LuaValue Bind(global::System.Collections.Generic.IList<global::UnityEditor.MaterialEditor> instances) =>
            new global::Luny.LuaList<global::UnityEditor.MaterialEditor>(instances);
        public new static global::Lua.LuaValue Bind(global::System.Collections.Generic.IList<global::System.Object> instances) =>
            new global::Luny.LuaList<global::UnityEditor.MaterialEditor>(instances);
        protected LuaMaterialEditor(global::UnityEditor.MaterialEditor instance) : base(instance) {}
        public static implicit operator global::Lua.LuaValue(LuaMaterialEditor value) => new(value);
        public new global::UnityEditor.MaterialEditor Instance => (global::UnityEditor.MaterialEditor)m_Instance;
        public new global::System.Type BindType => typeof(global::UnityEditor.MaterialEditor);
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

        private static readonly global::Lua.LuaFunction _LuaMaterialEditor_Awake = new global::Lua.LuaFunction("Awake", (_context, _) =>
        {
            global::Lua.LuaValue _lastArg = default;
            global::System.Int32 _lastArgPos = default;
            global::System.Type _expectedType = default;
            var _argCount = _context.ArgumentCount;
            var _this = _context.GetArgument<LuaMaterialEditor>(0);
            if (_argCount == 1)
            {
                _this.Instance.Awake();
                var _retCount = _context.Return();
                return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
            }
            throw new global::Lua.LuaRuntimeException(_context.Thread, $"{"Awake"}: invalid argument #{_lastArgPos}: {_lastArg} ({_lastArg.Type}), expected: {_expectedType.FullName}", 2);
        });
        private static readonly global::Lua.LuaFunction _LuaMaterialEditor_BeginAnimatedCheck = new global::Lua.LuaFunction("BeginAnimatedCheck", (_context, _) =>
        {
            global::Lua.LuaValue _lastArg = default;
            global::System.Int32 _lastArgPos = default;
            global::System.Type _expectedType = default;
            var _argCount = _context.ArgumentCount;
            var _this = _context.GetArgument<LuaMaterialEditor>(0);
            var _arg0 = _lastArg = _argCount > 1 ? _context.GetArgument(1) : global::Lua.LuaValue.Nil;
            _lastArgPos = 0; _expectedType = typeof(global::Luny.UnityEditor.LuaMaterialProperty);
            if (_arg0.TryRead<global::Luny.UnityEditor.LuaMaterialProperty>(out var _p0_UnityEditor_MaterialProperty))
            {
                if (_argCount == 2)
                {
                    var prop = _p0_UnityEditor_MaterialProperty.Instance;
                    _this.Instance.BeginAnimatedCheck(prop);
                    var _retCount = _context.Return();
                    return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                }
            }
            _lastArgPos = 0; _expectedType = typeof(global::Luny.UnityEngine.LuaRect);
            if (_arg0.TryRead<global::Luny.UnityEngine.LuaRect>(out var _p0_UnityEngine_Rect))
            {
                var _arg1 = _lastArg = _argCount > 2 ? _context.GetArgument(2) : global::Lua.LuaValue.Nil;
                _lastArgPos = 1; _expectedType = typeof(global::Luny.UnityEditor.LuaMaterialProperty);
                if (_arg1.TryRead<global::Luny.UnityEditor.LuaMaterialProperty>(out var _p1_UnityEditor_MaterialProperty))
                {
                    if (_argCount == 3)
                    {
                        var totalPosition = _p0_UnityEngine_Rect.Value;
                        var prop = _p1_UnityEditor_MaterialProperty.Instance;
                        _this.Instance.BeginAnimatedCheck(totalPosition, prop);
                        var _retCount = _context.Return();
                        return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                    }
                }
            }
            throw new global::Lua.LuaRuntimeException(_context.Thread, $"{"BeginAnimatedCheck"}: invalid argument #{_lastArgPos}: {_lastArg} ({_lastArg.Type}), expected: {_expectedType.FullName}", 2);
        });
        private static readonly global::Lua.LuaFunction _LuaMaterialEditor_ColorProperty = new global::Lua.LuaFunction("ColorProperty", (_context, _) =>
        {
            global::Lua.LuaValue _lastArg = default;
            global::System.Int32 _lastArgPos = default;
            global::System.Type _expectedType = default;
            var _argCount = _context.ArgumentCount;
            var _this = _context.GetArgument<LuaMaterialEditor>(0);
            var _arg0 = _lastArg = _argCount > 1 ? _context.GetArgument(1) : global::Lua.LuaValue.Nil;
            _lastArgPos = 0; _expectedType = typeof(global::Luny.UnityEditor.LuaMaterialProperty);
            if (_arg0.TryRead<global::Luny.UnityEditor.LuaMaterialProperty>(out var _p0_UnityEditor_MaterialProperty))
            {
                var _arg1 = _lastArg = _argCount > 2 ? _context.GetArgument(2) : global::Lua.LuaValue.Nil;
                _lastArgPos = 1; _expectedType = typeof(global::System.String);
                if (_arg1.TryRead<global::System.String>(out var _p1_System_String))
                {
                    if (_argCount == 3)
                    {
                        var prop = _p0_UnityEditor_MaterialProperty.Instance;
                        var label = _p1_System_String;
                        var _ret0 = _this.Instance.ColorProperty(prop, label);
                        var _lret0 = global::Luny.UnityEngine.LuaColor.Bind(_ret0);
                        var _retCount = _context.Return(_lret0);
                        return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                    }
                }
            }
            _lastArgPos = 0; _expectedType = typeof(global::Luny.UnityEngine.LuaRect);
            if (_arg0.TryRead<global::Luny.UnityEngine.LuaRect>(out var _p0_UnityEngine_Rect))
            {
                var _arg1 = _lastArg = _argCount > 2 ? _context.GetArgument(2) : global::Lua.LuaValue.Nil;
                _lastArgPos = 1; _expectedType = typeof(global::Luny.UnityEditor.LuaMaterialProperty);
                if (_arg1.TryRead<global::Luny.UnityEditor.LuaMaterialProperty>(out var _p1_UnityEditor_MaterialProperty))
                {
                    var _arg2 = _lastArg = _argCount > 3 ? _context.GetArgument(3) : global::Lua.LuaValue.Nil;
                    _lastArgPos = 2; _expectedType = typeof(global::System.String);
                    if (_arg2.TryRead<global::System.String>(out var _p2_System_String))
                    {
                        if (_argCount == 4)
                        {
                            var position = _p0_UnityEngine_Rect.Value;
                            var prop = _p1_UnityEditor_MaterialProperty.Instance;
                            var label = _p2_System_String;
                            var _ret0 = _this.Instance.ColorProperty(position, prop, label);
                            var _lret0 = global::Luny.UnityEngine.LuaColor.Bind(_ret0);
                            var _retCount = _context.Return(_lret0);
                            return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                        }
                    }
                }
            }
            throw new global::Lua.LuaRuntimeException(_context.Thread, $"{"ColorProperty"}: invalid argument #{_lastArgPos}: {_lastArg} ({_lastArg.Type}), expected: {_expectedType.FullName}", 2);
        });
        private static readonly global::Lua.LuaFunction _LuaMaterialEditor_CreatePreview = new global::Lua.LuaFunction("CreatePreview", (_context, _) =>
        {
            global::Lua.LuaValue _lastArg = default;
            global::System.Int32 _lastArgPos = default;
            global::System.Type _expectedType = default;
            var _argCount = _context.ArgumentCount;
            var _this = _context.GetArgument<LuaMaterialEditor>(0);
            var _arg0 = _lastArg = _argCount > 1 ? _context.GetArgument(1) : global::Lua.LuaValue.Nil;
            _lastArgPos = 0; _expectedType = typeof(global::UnityEngine.UIElements.VisualElement);
            if (_arg0.TryRead<global::UnityEngine.UIElements.VisualElement>(out var _p0_UnityEngine_UIElements_VisualElement))
            {
                if (_argCount == 2)
                {
                    var inspectorPreviewWindow = _p0_UnityEngine_UIElements_VisualElement;
                    var _ret0 = _this.Instance.CreatePreview(inspectorPreviewWindow);
                    var _factory = _context.GetObjectFactory();
                    var _lret0 = _factory.Bind(_ret0);
                    var _retCount = _context.Return(_lret0);
                    return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                }
            }
            throw new global::Lua.LuaRuntimeException(_context.Thread, $"{"CreatePreview"}: invalid argument #{_lastArgPos}: {_lastArg} ({_lastArg.Type}), expected: {_expectedType.FullName}", 2);
        });
        private static readonly global::Lua.LuaFunction _LuaMaterialEditor_DefaultPreviewGUI = new global::Lua.LuaFunction("DefaultPreviewGUI", (_context, _) =>
        {
            global::Lua.LuaValue _lastArg = default;
            global::System.Int32 _lastArgPos = default;
            global::System.Type _expectedType = default;
            var _argCount = _context.ArgumentCount;
            var _this = _context.GetArgument<LuaMaterialEditor>(0);
            var _arg0 = _lastArg = _argCount > 1 ? _context.GetArgument(1) : global::Lua.LuaValue.Nil;
            _lastArgPos = 0; _expectedType = typeof(global::Luny.UnityEngine.LuaRect);
            if (_arg0.TryRead<global::Luny.UnityEngine.LuaRect>(out var _p0_UnityEngine_Rect))
            {
                var _arg1 = _lastArg = _argCount > 2 ? _context.GetArgument(2) : global::Lua.LuaValue.Nil;
                _lastArgPos = 1; _expectedType = typeof(global::UnityEngine.GUIStyle);
                if (_arg1.TryRead<global::UnityEngine.GUIStyle>(out var _p1_UnityEngine_GUIStyle))
                {
                    if (_argCount == 3)
                    {
                        var r = _p0_UnityEngine_Rect.Value;
                        var background = _p1_UnityEngine_GUIStyle;
                        _this.Instance.DefaultPreviewGUI(r, background);
                        var _retCount = _context.Return();
                        return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                    }
                }
            }
            throw new global::Lua.LuaRuntimeException(_context.Thread, $"{"DefaultPreviewGUI"}: invalid argument #{_lastArgPos}: {_lastArg} ({_lastArg.Type}), expected: {_expectedType.FullName}", 2);
        });
        private static readonly global::Lua.LuaFunction _LuaMaterialEditor_DefaultPreviewSettingsGUI = new global::Lua.LuaFunction("DefaultPreviewSettingsGUI", (_context, _) =>
        {
            global::Lua.LuaValue _lastArg = default;
            global::System.Int32 _lastArgPos = default;
            global::System.Type _expectedType = default;
            var _argCount = _context.ArgumentCount;
            var _this = _context.GetArgument<LuaMaterialEditor>(0);
            if (_argCount == 1)
            {
                _this.Instance.DefaultPreviewSettingsGUI();
                var _retCount = _context.Return();
                return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
            }
            throw new global::Lua.LuaRuntimeException(_context.Thread, $"{"DefaultPreviewSettingsGUI"}: invalid argument #{_lastArgPos}: {_lastArg} ({_lastArg.Type}), expected: {_expectedType.FullName}", 2);
        });
        private static readonly global::Lua.LuaFunction _LuaMaterialEditor_DefaultShaderProperty = new global::Lua.LuaFunction("DefaultShaderProperty", (_context, _) =>
        {
            global::Lua.LuaValue _lastArg = default;
            global::System.Int32 _lastArgPos = default;
            global::System.Type _expectedType = default;
            var _argCount = _context.ArgumentCount;
            var _this = _context.GetArgument<LuaMaterialEditor>(0);
            var _arg0 = _lastArg = _argCount > 1 ? _context.GetArgument(1) : global::Lua.LuaValue.Nil;
            _lastArgPos = 0; _expectedType = typeof(global::Luny.UnityEditor.LuaMaterialProperty);
            if (_arg0.TryRead<global::Luny.UnityEditor.LuaMaterialProperty>(out var _p0_UnityEditor_MaterialProperty))
            {
                var _arg1 = _lastArg = _argCount > 2 ? _context.GetArgument(2) : global::Lua.LuaValue.Nil;
                _lastArgPos = 1; _expectedType = typeof(global::System.String);
                if (_arg1.TryRead<global::System.String>(out var _p1_System_String))
                {
                    if (_argCount == 3)
                    {
                        var prop = _p0_UnityEditor_MaterialProperty.Instance;
                        var label = _p1_System_String;
                        _this.Instance.DefaultShaderProperty(prop, label);
                        var _retCount = _context.Return();
                        return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                    }
                }
            }
            _lastArgPos = 0; _expectedType = typeof(global::Luny.UnityEngine.LuaRect);
            if (_arg0.TryRead<global::Luny.UnityEngine.LuaRect>(out var _p0_UnityEngine_Rect))
            {
                var _arg1 = _lastArg = _argCount > 2 ? _context.GetArgument(2) : global::Lua.LuaValue.Nil;
                _lastArgPos = 1; _expectedType = typeof(global::Luny.UnityEditor.LuaMaterialProperty);
                if (_arg1.TryRead<global::Luny.UnityEditor.LuaMaterialProperty>(out var _p1_UnityEditor_MaterialProperty))
                {
                    var _arg2 = _lastArg = _argCount > 3 ? _context.GetArgument(3) : global::Lua.LuaValue.Nil;
                    _lastArgPos = 2; _expectedType = typeof(global::System.String);
                    if (_arg2.TryRead<global::System.String>(out var _p2_System_String))
                    {
                        if (_argCount == 4)
                        {
                            var position = _p0_UnityEngine_Rect.Value;
                            var prop = _p1_UnityEditor_MaterialProperty.Instance;
                            var label = _p2_System_String;
                            _this.Instance.DefaultShaderProperty(position, prop, label);
                            var _retCount = _context.Return();
                            return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                        }
                    }
                }
            }
            throw new global::Lua.LuaRuntimeException(_context.Thread, $"{"DefaultShaderProperty"}: invalid argument #{_lastArgPos}: {_lastArg} ({_lastArg.Type}), expected: {_expectedType.FullName}", 2);
        });
        private static readonly global::Lua.LuaFunction _LuaMaterialEditor_DoubleSidedGIField = new global::Lua.LuaFunction("DoubleSidedGIField", (_context, _) =>
        {
            global::Lua.LuaValue _lastArg = default;
            global::System.Int32 _lastArgPos = default;
            global::System.Type _expectedType = default;
            var _argCount = _context.ArgumentCount;
            var _this = _context.GetArgument<LuaMaterialEditor>(0);
            if (_argCount == 1)
            {
                var _ret0 = _this.Instance.DoubleSidedGIField();
                var _lret0 = new global::Lua.LuaValue(_ret0);
                var _retCount = _context.Return(_lret0);
                return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
            }
            throw new global::Lua.LuaRuntimeException(_context.Thread, $"{"DoubleSidedGIField"}: invalid argument #{_lastArgPos}: {_lastArg} ({_lastArg.Type}), expected: {_expectedType.FullName}", 2);
        });
        private static readonly global::Lua.LuaFunction _LuaMaterialEditor_EmissionEnabledProperty = new global::Lua.LuaFunction("EmissionEnabledProperty", (_context, _) =>
        {
            global::Lua.LuaValue _lastArg = default;
            global::System.Int32 _lastArgPos = default;
            global::System.Type _expectedType = default;
            var _argCount = _context.ArgumentCount;
            var _this = _context.GetArgument<LuaMaterialEditor>(0);
            if (_argCount == 1)
            {
                var _ret0 = _this.Instance.EmissionEnabledProperty();
                var _lret0 = new global::Lua.LuaValue(_ret0);
                var _retCount = _context.Return(_lret0);
                return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
            }
            throw new global::Lua.LuaRuntimeException(_context.Thread, $"{"EmissionEnabledProperty"}: invalid argument #{_lastArgPos}: {_lastArg} ({_lastArg.Type}), expected: {_expectedType.FullName}", 2);
        });
        private static readonly global::Lua.LuaFunction _LuaMaterialEditor_EnableInstancingField = new global::Lua.LuaFunction("EnableInstancingField", (_context, _) =>
        {
            global::Lua.LuaValue _lastArg = default;
            global::System.Int32 _lastArgPos = default;
            global::System.Type _expectedType = default;
            var _argCount = _context.ArgumentCount;
            var _this = _context.GetArgument<LuaMaterialEditor>(0);
            if (_argCount == 1)
            {
                var _ret0 = _this.Instance.EnableInstancingField();
                var _lret0 = new global::Lua.LuaValue(_ret0);
                var _retCount = _context.Return(_lret0);
                return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
            }
            var _arg0 = _lastArg = _argCount > 1 ? _context.GetArgument(1) : global::Lua.LuaValue.Nil;
            _lastArgPos = 0; _expectedType = typeof(global::Luny.UnityEngine.LuaRect);
            if (_arg0.TryRead<global::Luny.UnityEngine.LuaRect>(out var _p0_UnityEngine_Rect))
            {
                if (_argCount == 2)
                {
                    var r = _p0_UnityEngine_Rect.Value;
                    _this.Instance.EnableInstancingField(r);
                    var _retCount = _context.Return();
                    return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                }
            }
            throw new global::Lua.LuaRuntimeException(_context.Thread, $"{"EnableInstancingField"}: invalid argument #{_lastArgPos}: {_lastArg} ({_lastArg.Type}), expected: {_expectedType.FullName}", 2);
        });
        private static readonly global::Lua.LuaFunction _LuaMaterialEditor_EndAnimatedCheck = new global::Lua.LuaFunction("EndAnimatedCheck", (_context, _) =>
        {
            global::Lua.LuaValue _lastArg = default;
            global::System.Int32 _lastArgPos = default;
            global::System.Type _expectedType = default;
            var _argCount = _context.ArgumentCount;
            var _this = _context.GetArgument<LuaMaterialEditor>(0);
            if (_argCount == 1)
            {
                _this.Instance.EndAnimatedCheck();
                var _retCount = _context.Return();
                return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
            }
            throw new global::Lua.LuaRuntimeException(_context.Thread, $"{"EndAnimatedCheck"}: invalid argument #{_lastArgPos}: {_lastArg} ({_lastArg.Type}), expected: {_expectedType.FullName}", 2);
        });
        private static readonly global::Lua.LuaFunction _LuaMaterialEditor_FloatProperty = new global::Lua.LuaFunction("FloatProperty", (_context, _) =>
        {
            global::Lua.LuaValue _lastArg = default;
            global::System.Int32 _lastArgPos = default;
            global::System.Type _expectedType = default;
            var _argCount = _context.ArgumentCount;
            var _this = _context.GetArgument<LuaMaterialEditor>(0);
            var _arg0 = _lastArg = _argCount > 1 ? _context.GetArgument(1) : global::Lua.LuaValue.Nil;
            _lastArgPos = 0; _expectedType = typeof(global::Luny.UnityEditor.LuaMaterialProperty);
            if (_arg0.TryRead<global::Luny.UnityEditor.LuaMaterialProperty>(out var _p0_UnityEditor_MaterialProperty))
            {
                var _arg1 = _lastArg = _argCount > 2 ? _context.GetArgument(2) : global::Lua.LuaValue.Nil;
                _lastArgPos = 1; _expectedType = typeof(global::System.String);
                if (_arg1.TryRead<global::System.String>(out var _p1_System_String))
                {
                    if (_argCount == 3)
                    {
                        var prop = _p0_UnityEditor_MaterialProperty.Instance;
                        var label = _p1_System_String;
                        var _ret0 = _this.Instance.FloatProperty(prop, label);
                        var _lret0 = new global::Lua.LuaValue(_ret0);
                        var _retCount = _context.Return(_lret0);
                        return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                    }
                }
            }
            _lastArgPos = 0; _expectedType = typeof(global::Luny.UnityEngine.LuaRect);
            if (_arg0.TryRead<global::Luny.UnityEngine.LuaRect>(out var _p0_UnityEngine_Rect))
            {
                var _arg1 = _lastArg = _argCount > 2 ? _context.GetArgument(2) : global::Lua.LuaValue.Nil;
                _lastArgPos = 1; _expectedType = typeof(global::Luny.UnityEditor.LuaMaterialProperty);
                if (_arg1.TryRead<global::Luny.UnityEditor.LuaMaterialProperty>(out var _p1_UnityEditor_MaterialProperty))
                {
                    var _arg2 = _lastArg = _argCount > 3 ? _context.GetArgument(3) : global::Lua.LuaValue.Nil;
                    _lastArgPos = 2; _expectedType = typeof(global::System.String);
                    if (_arg2.TryRead<global::System.String>(out var _p2_System_String))
                    {
                        if (_argCount == 4)
                        {
                            var position = _p0_UnityEngine_Rect.Value;
                            var prop = _p1_UnityEditor_MaterialProperty.Instance;
                            var label = _p2_System_String;
                            var _ret0 = _this.Instance.FloatProperty(position, prop, label);
                            var _lret0 = new global::Lua.LuaValue(_ret0);
                            var _retCount = _context.Return(_lret0);
                            return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                        }
                    }
                }
            }
            throw new global::Lua.LuaRuntimeException(_context.Thread, $"{"FloatProperty"}: invalid argument #{_lastArgPos}: {_lastArg} ({_lastArg.Type}), expected: {_expectedType.FullName}", 2);
        });
        private static readonly global::Lua.LuaFunction _LuaMaterialEditor_GetPropertyHeight = new global::Lua.LuaFunction("GetPropertyHeight", (_context, _) =>
        {
            global::Lua.LuaValue _lastArg = default;
            global::System.Int32 _lastArgPos = default;
            global::System.Type _expectedType = default;
            var _argCount = _context.ArgumentCount;
            var _this = _context.GetArgument<LuaMaterialEditor>(0);
            var _arg0 = _lastArg = _argCount > 1 ? _context.GetArgument(1) : global::Lua.LuaValue.Nil;
            _lastArgPos = 0; _expectedType = typeof(global::Luny.UnityEditor.LuaMaterialProperty);
            if (_arg0.TryRead<global::Luny.UnityEditor.LuaMaterialProperty>(out var _p0_UnityEditor_MaterialProperty))
            {
                if (_argCount == 2)
                {
                    var prop = _p0_UnityEditor_MaterialProperty.Instance;
                    var _ret0 = _this.Instance.GetPropertyHeight(prop);
                    var _lret0 = new global::Lua.LuaValue(_ret0);
                    var _retCount = _context.Return(_lret0);
                    return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                }
                var _arg1 = _lastArg = _argCount > 2 ? _context.GetArgument(2) : global::Lua.LuaValue.Nil;
                _lastArgPos = 1; _expectedType = typeof(global::System.String);
                if (_arg1.TryRead<global::System.String>(out var _p1_System_String))
                {
                    if (_argCount == 3)
                    {
                        var prop = _p0_UnityEditor_MaterialProperty.Instance;
                        var label = _p1_System_String;
                        var _ret0 = _this.Instance.GetPropertyHeight(prop, label);
                        var _lret0 = new global::Lua.LuaValue(_ret0);
                        var _retCount = _context.Return(_lret0);
                        return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                    }
                }
            }
            throw new global::Lua.LuaRuntimeException(_context.Thread, $"{"GetPropertyHeight"}: invalid argument #{_lastArgPos}: {_lastArg} ({_lastArg.Type}), expected: {_expectedType.FullName}", 2);
        });
        private static readonly global::Lua.LuaFunction _LuaMaterialEditor_GetTexturePropertyCustomArea = new global::Lua.LuaFunction("GetTexturePropertyCustomArea", (_context, _) =>
        {
            global::Lua.LuaValue _lastArg = default;
            global::System.Int32 _lastArgPos = default;
            global::System.Type _expectedType = default;
            var _argCount = _context.ArgumentCount;
            var _this = _context.GetArgument<LuaMaterialEditor>(0);
            var _arg0 = _lastArg = _argCount > 1 ? _context.GetArgument(1) : global::Lua.LuaValue.Nil;
            _lastArgPos = 0; _expectedType = typeof(global::Luny.UnityEngine.LuaRect);
            if (_arg0.TryRead<global::Luny.UnityEngine.LuaRect>(out var _p0_UnityEngine_Rect))
            {
                if (_argCount == 2)
                {
                    var position = _p0_UnityEngine_Rect.Value;
                    var _ret0 = _this.Instance.GetTexturePropertyCustomArea(position);
                    var _lret0 = global::Luny.UnityEngine.LuaRect.Bind(_ret0);
                    var _retCount = _context.Return(_lret0);
                    return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                }
            }
            throw new global::Lua.LuaRuntimeException(_context.Thread, $"{"GetTexturePropertyCustomArea"}: invalid argument #{_lastArgPos}: {_lastArg} ({_lastArg.Type}), expected: {_expectedType.FullName}", 2);
        });
        private static readonly global::Lua.LuaFunction _LuaMaterialEditor_HasPreviewGUI = new global::Lua.LuaFunction("HasPreviewGUI", (_context, _) =>
        {
            global::Lua.LuaValue _lastArg = default;
            global::System.Int32 _lastArgPos = default;
            global::System.Type _expectedType = default;
            var _argCount = _context.ArgumentCount;
            var _this = _context.GetArgument<LuaMaterialEditor>(0);
            if (_argCount == 1)
            {
                var _ret0 = _this.Instance.HasPreviewGUI();
                var _lret0 = new global::Lua.LuaValue(_ret0);
                var _retCount = _context.Return(_lret0);
                return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
            }
            throw new global::Lua.LuaRuntimeException(_context.Thread, $"{"HasPreviewGUI"}: invalid argument #{_lastArgPos}: {_lastArg} ({_lastArg.Type}), expected: {_expectedType.FullName}", 2);
        });
        private static readonly global::Lua.LuaFunction _LuaMaterialEditor_HelpBoxWithButton = new global::Lua.LuaFunction("HelpBoxWithButton", (_context, _) =>
        {
            global::Lua.LuaValue _lastArg = default;
            global::System.Int32 _lastArgPos = default;
            global::System.Type _expectedType = default;
            var _argCount = _context.ArgumentCount;
            var _this = _context.GetArgument<LuaMaterialEditor>(0);
            var _arg0 = _lastArg = _argCount > 1 ? _context.GetArgument(1) : global::Lua.LuaValue.Nil;
            _lastArgPos = 0; _expectedType = typeof(global::UnityEngine.GUIContent);
            if (_arg0.TryRead<global::UnityEngine.GUIContent>(out var _p0_UnityEngine_GUIContent))
            {
                var _arg1 = _lastArg = _argCount > 2 ? _context.GetArgument(2) : global::Lua.LuaValue.Nil;
                _lastArgPos = 1; _expectedType = typeof(global::UnityEngine.GUIContent);
                if (_arg1.TryRead<global::UnityEngine.GUIContent>(out var _p1_UnityEngine_GUIContent))
                {
                    if (_argCount == 3)
                    {
                        var messageContent = _p0_UnityEngine_GUIContent;
                        var buttonContent = _p1_UnityEngine_GUIContent;
                        var _ret0 = _this.Instance.HelpBoxWithButton(messageContent, buttonContent);
                        var _lret0 = new global::Lua.LuaValue(_ret0);
                        var _retCount = _context.Return(_lret0);
                        return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                    }
                }
            }
            throw new global::Lua.LuaRuntimeException(_context.Thread, $"{"HelpBoxWithButton"}: invalid argument #{_lastArgPos}: {_lastArg} ({_lastArg.Type}), expected: {_expectedType.FullName}", 2);
        });
        private static readonly global::Lua.LuaFunction _LuaMaterialEditor_IntegerProperty = new global::Lua.LuaFunction("IntegerProperty", (_context, _) =>
        {
            global::Lua.LuaValue _lastArg = default;
            global::System.Int32 _lastArgPos = default;
            global::System.Type _expectedType = default;
            var _argCount = _context.ArgumentCount;
            var _this = _context.GetArgument<LuaMaterialEditor>(0);
            var _arg0 = _lastArg = _argCount > 1 ? _context.GetArgument(1) : global::Lua.LuaValue.Nil;
            _lastArgPos = 0; _expectedType = typeof(global::Luny.UnityEditor.LuaMaterialProperty);
            if (_arg0.TryRead<global::Luny.UnityEditor.LuaMaterialProperty>(out var _p0_UnityEditor_MaterialProperty))
            {
                var _arg1 = _lastArg = _argCount > 2 ? _context.GetArgument(2) : global::Lua.LuaValue.Nil;
                _lastArgPos = 1; _expectedType = typeof(global::System.String);
                if (_arg1.TryRead<global::System.String>(out var _p1_System_String))
                {
                    if (_argCount == 3)
                    {
                        var prop = _p0_UnityEditor_MaterialProperty.Instance;
                        var label = _p1_System_String;
                        var _ret0 = _this.Instance.IntegerProperty(prop, label);
                        var _lret0 = new global::Lua.LuaValue(_ret0);
                        var _retCount = _context.Return(_lret0);
                        return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                    }
                }
            }
            _lastArgPos = 0; _expectedType = typeof(global::Luny.UnityEngine.LuaRect);
            if (_arg0.TryRead<global::Luny.UnityEngine.LuaRect>(out var _p0_UnityEngine_Rect))
            {
                var _arg1 = _lastArg = _argCount > 2 ? _context.GetArgument(2) : global::Lua.LuaValue.Nil;
                _lastArgPos = 1; _expectedType = typeof(global::Luny.UnityEditor.LuaMaterialProperty);
                if (_arg1.TryRead<global::Luny.UnityEditor.LuaMaterialProperty>(out var _p1_UnityEditor_MaterialProperty))
                {
                    var _arg2 = _lastArg = _argCount > 3 ? _context.GetArgument(3) : global::Lua.LuaValue.Nil;
                    _lastArgPos = 2; _expectedType = typeof(global::System.String);
                    if (_arg2.TryRead<global::System.String>(out var _p2_System_String))
                    {
                        if (_argCount == 4)
                        {
                            var position = _p0_UnityEngine_Rect.Value;
                            var prop = _p1_UnityEditor_MaterialProperty.Instance;
                            var label = _p2_System_String;
                            var _ret0 = _this.Instance.IntegerProperty(position, prop, label);
                            var _lret0 = new global::Lua.LuaValue(_ret0);
                            var _retCount = _context.Return(_lret0);
                            return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                        }
                    }
                }
            }
            throw new global::Lua.LuaRuntimeException(_context.Thread, $"{"IntegerProperty"}: invalid argument #{_lastArgPos}: {_lastArg} ({_lastArg.Type}), expected: {_expectedType.FullName}", 2);
        });
        private static readonly global::Lua.LuaFunction _LuaMaterialEditor_IsInstancingEnabled = new global::Lua.LuaFunction("IsInstancingEnabled", (_context, _) =>
        {
            global::Lua.LuaValue _lastArg = default;
            global::System.Int32 _lastArgPos = default;
            global::System.Type _expectedType = default;
            var _argCount = _context.ArgumentCount;
            var _this = _context.GetArgument<LuaMaterialEditor>(0);
            if (_argCount == 1)
            {
                var _ret0 = _this.Instance.IsInstancingEnabled();
                var _lret0 = new global::Lua.LuaValue(_ret0);
                var _retCount = _context.Return(_lret0);
                return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
            }
            throw new global::Lua.LuaRuntimeException(_context.Thread, $"{"IsInstancingEnabled"}: invalid argument #{_lastArgPos}: {_lastArg} ({_lastArg.Type}), expected: {_expectedType.FullName}", 2);
        });
        private static readonly global::Lua.LuaFunction _LuaMaterialEditor_LightmapEmissionFlagsProperty = new global::Lua.LuaFunction("LightmapEmissionFlagsProperty", (_context, _) =>
        {
            global::Lua.LuaValue _lastArg = default;
            global::System.Int32 _lastArgPos = default;
            global::System.Type _expectedType = default;
            var _argCount = _context.ArgumentCount;
            var _this = _context.GetArgument<LuaMaterialEditor>(0);
            var _arg0 = _lastArg = _argCount > 1 ? _context.GetArgument(1) : global::Lua.LuaValue.Nil;
            _lastArgPos = 0; _expectedType = typeof(global::System.Int32);
            if (_arg0.TryRead<global::System.Int32>(out var _p0_System_Int32))
            {
                var _arg1 = _lastArg = _argCount > 2 ? _context.GetArgument(2) : global::Lua.LuaValue.Nil;
                _lastArgPos = 1; _expectedType = typeof(global::System.Boolean);
                if (_arg1.TryRead<global::System.Boolean>(out var _p1_System_Boolean))
                {
                    if (_argCount == 3)
                    {
                        var indent = _p0_System_Int32;
                        var enabled = _p1_System_Boolean;
                        _this.Instance.LightmapEmissionFlagsProperty(indent, enabled);
                        var _retCount = _context.Return();
                        return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                    }
                    var _arg2 = _lastArg = _argCount > 3 ? _context.GetArgument(3) : global::Lua.LuaValue.Nil;
                    _lastArgPos = 2; _expectedType = typeof(global::System.Boolean);
                    if (_arg2.TryRead<global::System.Boolean>(out var _p2_System_Boolean))
                    {
                        if (_argCount == 4)
                        {
                            var indent = _p0_System_Int32;
                            var enabled = _p1_System_Boolean;
                            var ignoreEmissionColor = _p2_System_Boolean;
                            _this.Instance.LightmapEmissionFlagsProperty(indent, enabled, ignoreEmissionColor);
                            var _retCount = _context.Return();
                            return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                        }
                    }
                }
            }
            throw new global::Lua.LuaRuntimeException(_context.Thread, $"{"LightmapEmissionFlagsProperty"}: invalid argument #{_lastArgPos}: {_lastArg} ({_lastArg.Type}), expected: {_expectedType.FullName}", 2);
        });
        private static readonly global::Lua.LuaFunction _LuaMaterialEditor_LightmapEmissionProperty = new global::Lua.LuaFunction("LightmapEmissionProperty", (_context, _) =>
        {
            global::Lua.LuaValue _lastArg = default;
            global::System.Int32 _lastArgPos = default;
            global::System.Type _expectedType = default;
            var _argCount = _context.ArgumentCount;
            var _this = _context.GetArgument<LuaMaterialEditor>(0);
            if (_argCount == 1)
            {
                _this.Instance.LightmapEmissionProperty();
                var _retCount = _context.Return();
                return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
            }
            var _arg0 = _lastArg = _argCount > 1 ? _context.GetArgument(1) : global::Lua.LuaValue.Nil;
            _lastArgPos = 0; _expectedType = typeof(global::System.Int32);
            if (_arg0.TryRead<global::System.Int32>(out var _p0_System_Int32))
            {
                if (_argCount == 2)
                {
                    var labelIndent = _p0_System_Int32;
                    _this.Instance.LightmapEmissionProperty(labelIndent);
                    var _retCount = _context.Return();
                    return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                }
            }
            _lastArgPos = 0; _expectedType = typeof(global::Luny.UnityEngine.LuaRect);
            if (_arg0.TryRead<global::Luny.UnityEngine.LuaRect>(out var _p0_UnityEngine_Rect))
            {
                var _arg1 = _lastArg = _argCount > 2 ? _context.GetArgument(2) : global::Lua.LuaValue.Nil;
                _lastArgPos = 1; _expectedType = typeof(global::System.Int32);
                if (_arg1.TryRead<global::System.Int32>(out var _p1_System_Int32))
                {
                    if (_argCount == 3)
                    {
                        var position = _p0_UnityEngine_Rect.Value;
                        var labelIndent = _p1_System_Int32;
                        _this.Instance.LightmapEmissionProperty(position, labelIndent);
                        var _retCount = _context.Return();
                        return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                    }
                }
            }
            throw new global::Lua.LuaRuntimeException(_context.Thread, $"{"LightmapEmissionProperty"}: invalid argument #{_lastArgPos}: {_lastArg} ({_lastArg.Type}), expected: {_expectedType.FullName}", 2);
        });
        private static readonly global::Lua.LuaFunction _LuaMaterialEditor_OnDisable = new global::Lua.LuaFunction("OnDisable", (_context, _) =>
        {
            global::Lua.LuaValue _lastArg = default;
            global::System.Int32 _lastArgPos = default;
            global::System.Type _expectedType = default;
            var _argCount = _context.ArgumentCount;
            var _this = _context.GetArgument<LuaMaterialEditor>(0);
            if (_argCount == 1)
            {
                _this.Instance.OnDisable();
                var _retCount = _context.Return();
                return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
            }
            throw new global::Lua.LuaRuntimeException(_context.Thread, $"{"OnDisable"}: invalid argument #{_lastArgPos}: {_lastArg} ({_lastArg.Type}), expected: {_expectedType.FullName}", 2);
        });
        private static readonly global::Lua.LuaFunction _LuaMaterialEditor_OnEnable = new global::Lua.LuaFunction("OnEnable", (_context, _) =>
        {
            global::Lua.LuaValue _lastArg = default;
            global::System.Int32 _lastArgPos = default;
            global::System.Type _expectedType = default;
            var _argCount = _context.ArgumentCount;
            var _this = _context.GetArgument<LuaMaterialEditor>(0);
            if (_argCount == 1)
            {
                _this.Instance.OnEnable();
                var _retCount = _context.Return();
                return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
            }
            throw new global::Lua.LuaRuntimeException(_context.Thread, $"{"OnEnable"}: invalid argument #{_lastArgPos}: {_lastArg} ({_lastArg.Type}), expected: {_expectedType.FullName}", 2);
        });
        private static readonly global::Lua.LuaFunction _LuaMaterialEditor_OnInspectorGUI = new global::Lua.LuaFunction("OnInspectorGUI", (_context, _) =>
        {
            global::Lua.LuaValue _lastArg = default;
            global::System.Int32 _lastArgPos = default;
            global::System.Type _expectedType = default;
            var _argCount = _context.ArgumentCount;
            var _this = _context.GetArgument<LuaMaterialEditor>(0);
            if (_argCount == 1)
            {
                _this.Instance.OnInspectorGUI();
                var _retCount = _context.Return();
                return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
            }
            throw new global::Lua.LuaRuntimeException(_context.Thread, $"{"OnInspectorGUI"}: invalid argument #{_lastArgPos}: {_lastArg} ({_lastArg.Type}), expected: {_expectedType.FullName}", 2);
        });
        private static readonly global::Lua.LuaFunction _LuaMaterialEditor_OnInteractivePreviewGUI = new global::Lua.LuaFunction("OnInteractivePreviewGUI", (_context, _) =>
        {
            global::Lua.LuaValue _lastArg = default;
            global::System.Int32 _lastArgPos = default;
            global::System.Type _expectedType = default;
            var _argCount = _context.ArgumentCount;
            var _this = _context.GetArgument<LuaMaterialEditor>(0);
            var _arg0 = _lastArg = _argCount > 1 ? _context.GetArgument(1) : global::Lua.LuaValue.Nil;
            _lastArgPos = 0; _expectedType = typeof(global::Luny.UnityEngine.LuaRect);
            if (_arg0.TryRead<global::Luny.UnityEngine.LuaRect>(out var _p0_UnityEngine_Rect))
            {
                var _arg1 = _lastArg = _argCount > 2 ? _context.GetArgument(2) : global::Lua.LuaValue.Nil;
                _lastArgPos = 1; _expectedType = typeof(global::UnityEngine.GUIStyle);
                if (_arg1.TryRead<global::UnityEngine.GUIStyle>(out var _p1_UnityEngine_GUIStyle))
                {
                    if (_argCount == 3)
                    {
                        var r = _p0_UnityEngine_Rect.Value;
                        var background = _p1_UnityEngine_GUIStyle;
                        _this.Instance.OnInteractivePreviewGUI(r, background);
                        var _retCount = _context.Return();
                        return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                    }
                }
            }
            throw new global::Lua.LuaRuntimeException(_context.Thread, $"{"OnInteractivePreviewGUI"}: invalid argument #{_lastArgPos}: {_lastArg} ({_lastArg.Type}), expected: {_expectedType.FullName}", 2);
        });
        private static readonly global::Lua.LuaFunction _LuaMaterialEditor_OnPreviewGUI = new global::Lua.LuaFunction("OnPreviewGUI", (_context, _) =>
        {
            global::Lua.LuaValue _lastArg = default;
            global::System.Int32 _lastArgPos = default;
            global::System.Type _expectedType = default;
            var _argCount = _context.ArgumentCount;
            var _this = _context.GetArgument<LuaMaterialEditor>(0);
            var _arg0 = _lastArg = _argCount > 1 ? _context.GetArgument(1) : global::Lua.LuaValue.Nil;
            _lastArgPos = 0; _expectedType = typeof(global::Luny.UnityEngine.LuaRect);
            if (_arg0.TryRead<global::Luny.UnityEngine.LuaRect>(out var _p0_UnityEngine_Rect))
            {
                var _arg1 = _lastArg = _argCount > 2 ? _context.GetArgument(2) : global::Lua.LuaValue.Nil;
                _lastArgPos = 1; _expectedType = typeof(global::UnityEngine.GUIStyle);
                if (_arg1.TryRead<global::UnityEngine.GUIStyle>(out var _p1_UnityEngine_GUIStyle))
                {
                    if (_argCount == 3)
                    {
                        var r = _p0_UnityEngine_Rect.Value;
                        var background = _p1_UnityEngine_GUIStyle;
                        _this.Instance.OnPreviewGUI(r, background);
                        var _retCount = _context.Return();
                        return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                    }
                }
            }
            throw new global::Lua.LuaRuntimeException(_context.Thread, $"{"OnPreviewGUI"}: invalid argument #{_lastArgPos}: {_lastArg} ({_lastArg.Type}), expected: {_expectedType.FullName}", 2);
        });
        private static readonly global::Lua.LuaFunction _LuaMaterialEditor_OnPreviewSettings = new global::Lua.LuaFunction("OnPreviewSettings", (_context, _) =>
        {
            global::Lua.LuaValue _lastArg = default;
            global::System.Int32 _lastArgPos = default;
            global::System.Type _expectedType = default;
            var _argCount = _context.ArgumentCount;
            var _this = _context.GetArgument<LuaMaterialEditor>(0);
            if (_argCount == 1)
            {
                _this.Instance.OnPreviewSettings();
                var _retCount = _context.Return();
                return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
            }
            throw new global::Lua.LuaRuntimeException(_context.Thread, $"{"OnPreviewSettings"}: invalid argument #{_lastArgPos}: {_lastArg} ({_lastArg.Type}), expected: {_expectedType.FullName}", 2);
        });
        private static readonly global::Lua.LuaFunction _LuaMaterialEditor_PropertiesChanged = new global::Lua.LuaFunction("PropertiesChanged", (_context, _) =>
        {
            global::Lua.LuaValue _lastArg = default;
            global::System.Int32 _lastArgPos = default;
            global::System.Type _expectedType = default;
            var _argCount = _context.ArgumentCount;
            var _this = _context.GetArgument<LuaMaterialEditor>(0);
            if (_argCount == 1)
            {
                _this.Instance.PropertiesChanged();
                var _retCount = _context.Return();
                return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
            }
            throw new global::Lua.LuaRuntimeException(_context.Thread, $"{"PropertiesChanged"}: invalid argument #{_lastArgPos}: {_lastArg} ({_lastArg.Type}), expected: {_expectedType.FullName}", 2);
        });
        private static readonly global::Lua.LuaFunction _LuaMaterialEditor_PropertiesDefaultGUI = new global::Lua.LuaFunction("PropertiesDefaultGUI", (_context, _) =>
        {
            global::Lua.LuaValue _lastArg = default;
            global::System.Int32 _lastArgPos = default;
            global::System.Type _expectedType = default;
            var _argCount = _context.ArgumentCount;
            var _this = _context.GetArgument<LuaMaterialEditor>(0);
            var _arg0 = _lastArg = _argCount > 1 ? _context.GetArgument(1) : global::Lua.LuaValue.Nil;
            _lastArgPos = 0; _expectedType = typeof(global::UnityEditor.MaterialProperty[]);
            if (_arg0.TryReadArray<global::UnityEditor.MaterialProperty>(out var _p0_UnityEditor_MaterialPropertyArray))
            {
                if (_argCount == 2)
                {
                    var props = _p0_UnityEditor_MaterialPropertyArray;
                    _this.Instance.PropertiesDefaultGUI(props);
                    var _retCount = _context.Return();
                    return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                }
            }
            throw new global::Lua.LuaRuntimeException(_context.Thread, $"{"PropertiesDefaultGUI"}: invalid argument #{_lastArgPos}: {_lastArg} ({_lastArg.Type}), expected: {_expectedType.FullName}", 2);
        });
        private static readonly global::Lua.LuaFunction _LuaMaterialEditor_PropertiesGUI = new global::Lua.LuaFunction("PropertiesGUI", (_context, _) =>
        {
            global::Lua.LuaValue _lastArg = default;
            global::System.Int32 _lastArgPos = default;
            global::System.Type _expectedType = default;
            var _argCount = _context.ArgumentCount;
            var _this = _context.GetArgument<LuaMaterialEditor>(0);
            if (_argCount == 1)
            {
                var _ret0 = _this.Instance.PropertiesGUI();
                var _lret0 = new global::Lua.LuaValue(_ret0);
                var _retCount = _context.Return(_lret0);
                return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
            }
            throw new global::Lua.LuaRuntimeException(_context.Thread, $"{"PropertiesGUI"}: invalid argument #{_lastArgPos}: {_lastArg} ({_lastArg.Type}), expected: {_expectedType.FullName}", 2);
        });
        private static readonly global::Lua.LuaFunction _LuaMaterialEditor_RangeProperty = new global::Lua.LuaFunction("RangeProperty", (_context, _) =>
        {
            global::Lua.LuaValue _lastArg = default;
            global::System.Int32 _lastArgPos = default;
            global::System.Type _expectedType = default;
            var _argCount = _context.ArgumentCount;
            var _this = _context.GetArgument<LuaMaterialEditor>(0);
            var _arg0 = _lastArg = _argCount > 1 ? _context.GetArgument(1) : global::Lua.LuaValue.Nil;
            _lastArgPos = 0; _expectedType = typeof(global::Luny.UnityEditor.LuaMaterialProperty);
            if (_arg0.TryRead<global::Luny.UnityEditor.LuaMaterialProperty>(out var _p0_UnityEditor_MaterialProperty))
            {
                var _arg1 = _lastArg = _argCount > 2 ? _context.GetArgument(2) : global::Lua.LuaValue.Nil;
                _lastArgPos = 1; _expectedType = typeof(global::System.String);
                if (_arg1.TryRead<global::System.String>(out var _p1_System_String))
                {
                    if (_argCount == 3)
                    {
                        var prop = _p0_UnityEditor_MaterialProperty.Instance;
                        var label = _p1_System_String;
                        var _ret0 = _this.Instance.RangeProperty(prop, label);
                        var _lret0 = new global::Lua.LuaValue(_ret0);
                        var _retCount = _context.Return(_lret0);
                        return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                    }
                }
            }
            _lastArgPos = 0; _expectedType = typeof(global::Luny.UnityEngine.LuaRect);
            if (_arg0.TryRead<global::Luny.UnityEngine.LuaRect>(out var _p0_UnityEngine_Rect))
            {
                var _arg1 = _lastArg = _argCount > 2 ? _context.GetArgument(2) : global::Lua.LuaValue.Nil;
                _lastArgPos = 1; _expectedType = typeof(global::Luny.UnityEditor.LuaMaterialProperty);
                if (_arg1.TryRead<global::Luny.UnityEditor.LuaMaterialProperty>(out var _p1_UnityEditor_MaterialProperty))
                {
                    var _arg2 = _lastArg = _argCount > 3 ? _context.GetArgument(3) : global::Lua.LuaValue.Nil;
                    _lastArgPos = 2; _expectedType = typeof(global::System.String);
                    if (_arg2.TryRead<global::System.String>(out var _p2_System_String))
                    {
                        if (_argCount == 4)
                        {
                            var position = _p0_UnityEngine_Rect.Value;
                            var prop = _p1_UnityEditor_MaterialProperty.Instance;
                            var label = _p2_System_String;
                            var _ret0 = _this.Instance.RangeProperty(position, prop, label);
                            var _lret0 = new global::Lua.LuaValue(_ret0);
                            var _retCount = _context.Return(_lret0);
                            return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                        }
                    }
                }
            }
            throw new global::Lua.LuaRuntimeException(_context.Thread, $"{"RangeProperty"}: invalid argument #{_lastArgPos}: {_lastArg} ({_lastArg.Type}), expected: {_expectedType.FullName}", 2);
        });
        private static readonly global::Lua.LuaFunction _LuaMaterialEditor_RegisterPropertyChangeUndo = new global::Lua.LuaFunction("RegisterPropertyChangeUndo", (_context, _) =>
        {
            global::Lua.LuaValue _lastArg = default;
            global::System.Int32 _lastArgPos = default;
            global::System.Type _expectedType = default;
            var _argCount = _context.ArgumentCount;
            var _this = _context.GetArgument<LuaMaterialEditor>(0);
            var _arg0 = _lastArg = _argCount > 1 ? _context.GetArgument(1) : global::Lua.LuaValue.Nil;
            _lastArgPos = 0; _expectedType = typeof(global::System.String);
            if (_arg0.TryRead<global::System.String>(out var _p0_System_String))
            {
                if (_argCount == 2)
                {
                    var label = _p0_System_String;
                    _this.Instance.RegisterPropertyChangeUndo(label);
                    var _retCount = _context.Return();
                    return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                }
            }
            throw new global::Lua.LuaRuntimeException(_context.Thread, $"{"RegisterPropertyChangeUndo"}: invalid argument #{_lastArgPos}: {_lastArg} ({_lastArg.Type}), expected: {_expectedType.FullName}", 2);
        });
        private static readonly global::Lua.LuaFunction _LuaMaterialEditor_RenderQueueField = new global::Lua.LuaFunction("RenderQueueField", (_context, _) =>
        {
            global::Lua.LuaValue _lastArg = default;
            global::System.Int32 _lastArgPos = default;
            global::System.Type _expectedType = default;
            var _argCount = _context.ArgumentCount;
            var _this = _context.GetArgument<LuaMaterialEditor>(0);
            if (_argCount == 1)
            {
                _this.Instance.RenderQueueField();
                var _retCount = _context.Return();
                return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
            }
            var _arg0 = _lastArg = _argCount > 1 ? _context.GetArgument(1) : global::Lua.LuaValue.Nil;
            _lastArgPos = 0; _expectedType = typeof(global::Luny.UnityEngine.LuaRect);
            if (_arg0.TryRead<global::Luny.UnityEngine.LuaRect>(out var _p0_UnityEngine_Rect))
            {
                if (_argCount == 2)
                {
                    var r = _p0_UnityEngine_Rect.Value;
                    _this.Instance.RenderQueueField(r);
                    var _retCount = _context.Return();
                    return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                }
            }
            throw new global::Lua.LuaRuntimeException(_context.Thread, $"{"RenderQueueField"}: invalid argument #{_lastArgPos}: {_lastArg} ({_lastArg.Type}), expected: {_expectedType.FullName}", 2);
        });
        private static readonly global::Lua.LuaFunction _LuaMaterialEditor_RenderStaticPreview = new global::Lua.LuaFunction("RenderStaticPreview", (_context, _) =>
        {
            global::Lua.LuaValue _lastArg = default;
            global::System.Int32 _lastArgPos = default;
            global::System.Type _expectedType = default;
            var _argCount = _context.ArgumentCount;
            var _this = _context.GetArgument<LuaMaterialEditor>(0);
            var _arg0 = _lastArg = _argCount > 1 ? _context.GetArgument(1) : global::Lua.LuaValue.Nil;
            _lastArgPos = 0; _expectedType = typeof(global::System.String);
            if (_arg0.TryRead<global::System.String>(out var _p0_System_String))
            {
                var _arg1 = _lastArg = _argCount > 2 ? _context.GetArgument(2) : global::Lua.LuaValue.Nil;
                _lastArgPos = 1; _expectedType = typeof(global::UnityEngine.Object[]);
                if (_arg1.TryReadArray<global::UnityEngine.Object>(out var _p1_UnityEngine_ObjectArray))
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
                                var assetPath = _p0_System_String;
                                var subAssets = _p1_UnityEngine_ObjectArray;
                                var width = _p2_System_Int32;
                                var height = _p3_System_Int32;
                                var _ret0 = _this.Instance.RenderStaticPreview(assetPath, subAssets, width, height);
                                var _factory = _context.GetObjectFactory();
                                var _lret0 = _factory.Bind(_ret0);
                                var _retCount = _context.Return(_lret0);
                                return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                            }
                        }
                    }
                }
            }
            throw new global::Lua.LuaRuntimeException(_context.Thread, $"{"RenderStaticPreview"}: invalid argument #{_lastArgPos}: {_lastArg} ({_lastArg.Type}), expected: {_expectedType.FullName}", 2);
        });
        private static readonly global::Lua.LuaFunction _LuaMaterialEditor_RequiresConstantRepaint = new global::Lua.LuaFunction("RequiresConstantRepaint", (_context, _) =>
        {
            global::Lua.LuaValue _lastArg = default;
            global::System.Int32 _lastArgPos = default;
            global::System.Type _expectedType = default;
            var _argCount = _context.ArgumentCount;
            var _this = _context.GetArgument<LuaMaterialEditor>(0);
            if (_argCount == 1)
            {
                var _ret0 = _this.Instance.RequiresConstantRepaint();
                var _lret0 = new global::Lua.LuaValue(_ret0);
                var _retCount = _context.Return(_lret0);
                return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
            }
            throw new global::Lua.LuaRuntimeException(_context.Thread, $"{"RequiresConstantRepaint"}: invalid argument #{_lastArgPos}: {_lastArg} ({_lastArg.Type}), expected: {_expectedType.FullName}", 2);
        });
        private static readonly global::Lua.LuaFunction _LuaMaterialEditor_SetDefaultGUIWidths = new global::Lua.LuaFunction("SetDefaultGUIWidths", (_context, _) =>
        {
            global::Lua.LuaValue _lastArg = default;
            global::System.Int32 _lastArgPos = default;
            global::System.Type _expectedType = default;
            var _argCount = _context.ArgumentCount;
            var _this = _context.GetArgument<LuaMaterialEditor>(0);
            if (_argCount == 1)
            {
                _this.Instance.SetDefaultGUIWidths();
                var _retCount = _context.Return();
                return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
            }
            throw new global::Lua.LuaRuntimeException(_context.Thread, $"{"SetDefaultGUIWidths"}: invalid argument #{_lastArgPos}: {_lastArg} ({_lastArg.Type}), expected: {_expectedType.FullName}", 2);
        });
        private static readonly global::Lua.LuaFunction _LuaMaterialEditor_SetShader = new global::Lua.LuaFunction("SetShader", (_context, _) =>
        {
            global::Lua.LuaValue _lastArg = default;
            global::System.Int32 _lastArgPos = default;
            global::System.Type _expectedType = default;
            var _argCount = _context.ArgumentCount;
            var _this = _context.GetArgument<LuaMaterialEditor>(0);
            var _arg0 = _lastArg = _argCount > 1 ? _context.GetArgument(1) : global::Lua.LuaValue.Nil;
            _lastArgPos = 0; _expectedType = typeof(global::Luny.UnityEngine.LuaShader);
            if (_arg0.TryRead<global::Luny.UnityEngine.LuaShader>(out var _p0_UnityEngine_Shader))
            {
                if (_argCount == 2)
                {
                    var shader = _p0_UnityEngine_Shader.Instance;
                    _this.Instance.SetShader(shader);
                    var _retCount = _context.Return();
                    return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                }
                var _arg1 = _lastArg = _argCount > 2 ? _context.GetArgument(2) : global::Lua.LuaValue.Nil;
                _lastArgPos = 1; _expectedType = typeof(global::System.Boolean);
                if (_arg1.TryRead<global::System.Boolean>(out var _p1_System_Boolean))
                {
                    if (_argCount == 3)
                    {
                        var newShader = _p0_UnityEngine_Shader.Instance;
                        var registerUndo = _p1_System_Boolean;
                        _this.Instance.SetShader(newShader, registerUndo);
                        var _retCount = _context.Return();
                        return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                    }
                }
            }
            throw new global::Lua.LuaRuntimeException(_context.Thread, $"{"SetShader"}: invalid argument #{_lastArgPos}: {_lastArg} ({_lastArg.Type}), expected: {_expectedType.FullName}", 2);
        });
        private static readonly global::Lua.LuaFunction _LuaMaterialEditor_ShaderProperty = new global::Lua.LuaFunction("ShaderProperty", (_context, _) =>
        {
            global::Lua.LuaValue _lastArg = default;
            global::System.Int32 _lastArgPos = default;
            global::System.Type _expectedType = default;
            var _argCount = _context.ArgumentCount;
            var _this = _context.GetArgument<LuaMaterialEditor>(0);
            var _arg0 = _lastArg = _argCount > 1 ? _context.GetArgument(1) : global::Lua.LuaValue.Nil;
            _lastArgPos = 0; _expectedType = typeof(global::Luny.UnityEditor.LuaMaterialProperty);
            if (_arg0.TryRead<global::Luny.UnityEditor.LuaMaterialProperty>(out var _p0_UnityEditor_MaterialProperty))
            {
                var _arg1 = _lastArg = _argCount > 2 ? _context.GetArgument(2) : global::Lua.LuaValue.Nil;
                _lastArgPos = 1; _expectedType = typeof(global::System.String);
                if (_arg1.TryRead<global::System.String>(out var _p1_System_String))
                {
                    if (_argCount == 3)
                    {
                        var prop = _p0_UnityEditor_MaterialProperty.Instance;
                        var label = _p1_System_String;
                        _this.Instance.ShaderProperty(prop, label);
                        var _retCount = _context.Return();
                        return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                    }
                    var _arg2 = _lastArg = _argCount > 3 ? _context.GetArgument(3) : global::Lua.LuaValue.Nil;
                    _lastArgPos = 2; _expectedType = typeof(global::System.Int32);
                    if (_arg2.TryRead<global::System.Int32>(out var _p2_System_Int32))
                    {
                        if (_argCount == 4)
                        {
                            var prop = _p0_UnityEditor_MaterialProperty.Instance;
                            var label = _p1_System_String;
                            var labelIndent = _p2_System_Int32;
                            _this.Instance.ShaderProperty(prop, label, labelIndent);
                            var _retCount = _context.Return();
                            return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                        }
                    }
                }
                _lastArgPos = 1; _expectedType = typeof(global::UnityEngine.GUIContent);
                if (_arg1.TryRead<global::UnityEngine.GUIContent>(out var _p1_UnityEngine_GUIContent))
                {
                    if (_argCount == 3)
                    {
                        var prop = _p0_UnityEditor_MaterialProperty.Instance;
                        var label = _p1_UnityEngine_GUIContent;
                        _this.Instance.ShaderProperty(prop, label);
                        var _retCount = _context.Return();
                        return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                    }
                    var _arg2 = _lastArg = _argCount > 3 ? _context.GetArgument(3) : global::Lua.LuaValue.Nil;
                    _lastArgPos = 2; _expectedType = typeof(global::System.Int32);
                    if (_arg2.TryRead<global::System.Int32>(out var _p2_System_Int32))
                    {
                        if (_argCount == 4)
                        {
                            var prop = _p0_UnityEditor_MaterialProperty.Instance;
                            var label = _p1_UnityEngine_GUIContent;
                            var labelIndent = _p2_System_Int32;
                            _this.Instance.ShaderProperty(prop, label, labelIndent);
                            var _retCount = _context.Return();
                            return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                        }
                    }
                }
            }
            _lastArgPos = 0; _expectedType = typeof(global::Luny.UnityEngine.LuaRect);
            if (_arg0.TryRead<global::Luny.UnityEngine.LuaRect>(out var _p0_UnityEngine_Rect))
            {
                var _arg1 = _lastArg = _argCount > 2 ? _context.GetArgument(2) : global::Lua.LuaValue.Nil;
                _lastArgPos = 1; _expectedType = typeof(global::Luny.UnityEditor.LuaMaterialProperty);
                if (_arg1.TryRead<global::Luny.UnityEditor.LuaMaterialProperty>(out var _p1_UnityEditor_MaterialProperty))
                {
                    var _arg2 = _lastArg = _argCount > 3 ? _context.GetArgument(3) : global::Lua.LuaValue.Nil;
                    _lastArgPos = 2; _expectedType = typeof(global::System.String);
                    if (_arg2.TryRead<global::System.String>(out var _p2_System_String))
                    {
                        if (_argCount == 4)
                        {
                            var position = _p0_UnityEngine_Rect.Value;
                            var prop = _p1_UnityEditor_MaterialProperty.Instance;
                            var label = _p2_System_String;
                            _this.Instance.ShaderProperty(position, prop, label);
                            var _retCount = _context.Return();
                            return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                        }
                        var _arg3 = _lastArg = _argCount > 4 ? _context.GetArgument(4) : global::Lua.LuaValue.Nil;
                        _lastArgPos = 3; _expectedType = typeof(global::System.Int32);
                        if (_arg3.TryRead<global::System.Int32>(out var _p3_System_Int32))
                        {
                            if (_argCount == 5)
                            {
                                var position = _p0_UnityEngine_Rect.Value;
                                var prop = _p1_UnityEditor_MaterialProperty.Instance;
                                var label = _p2_System_String;
                                var labelIndent = _p3_System_Int32;
                                _this.Instance.ShaderProperty(position, prop, label, labelIndent);
                                var _retCount = _context.Return();
                                return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                            }
                        }
                    }
                    _lastArgPos = 2; _expectedType = typeof(global::UnityEngine.GUIContent);
                    if (_arg2.TryRead<global::UnityEngine.GUIContent>(out var _p2_UnityEngine_GUIContent))
                    {
                        if (_argCount == 4)
                        {
                            var position = _p0_UnityEngine_Rect.Value;
                            var prop = _p1_UnityEditor_MaterialProperty.Instance;
                            var label = _p2_UnityEngine_GUIContent;
                            _this.Instance.ShaderProperty(position, prop, label);
                            var _retCount = _context.Return();
                            return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                        }
                        var _arg3 = _lastArg = _argCount > 4 ? _context.GetArgument(4) : global::Lua.LuaValue.Nil;
                        _lastArgPos = 3; _expectedType = typeof(global::System.Int32);
                        if (_arg3.TryRead<global::System.Int32>(out var _p3_System_Int32))
                        {
                            if (_argCount == 5)
                            {
                                var position = _p0_UnityEngine_Rect.Value;
                                var prop = _p1_UnityEditor_MaterialProperty.Instance;
                                var label = _p2_UnityEngine_GUIContent;
                                var labelIndent = _p3_System_Int32;
                                _this.Instance.ShaderProperty(position, prop, label, labelIndent);
                                var _retCount = _context.Return();
                                return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                            }
                        }
                    }
                }
            }
            throw new global::Lua.LuaRuntimeException(_context.Thread, $"{"ShaderProperty"}: invalid argument #{_lastArgPos}: {_lastArg} ({_lastArg.Type}), expected: {_expectedType.FullName}", 2);
        });
        private static readonly global::Lua.LuaFunction _LuaMaterialEditor_TextureCompatibilityWarning = new global::Lua.LuaFunction("TextureCompatibilityWarning", (_context, _) =>
        {
            global::Lua.LuaValue _lastArg = default;
            global::System.Int32 _lastArgPos = default;
            global::System.Type _expectedType = default;
            var _argCount = _context.ArgumentCount;
            var _this = _context.GetArgument<LuaMaterialEditor>(0);
            var _arg0 = _lastArg = _argCount > 1 ? _context.GetArgument(1) : global::Lua.LuaValue.Nil;
            _lastArgPos = 0; _expectedType = typeof(global::Luny.UnityEditor.LuaMaterialProperty);
            if (_arg0.TryRead<global::Luny.UnityEditor.LuaMaterialProperty>(out var _p0_UnityEditor_MaterialProperty))
            {
                if (_argCount == 2)
                {
                    var prop = _p0_UnityEditor_MaterialProperty.Instance;
                    _this.Instance.TextureCompatibilityWarning(prop);
                    var _retCount = _context.Return();
                    return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                }
            }
            throw new global::Lua.LuaRuntimeException(_context.Thread, $"{"TextureCompatibilityWarning"}: invalid argument #{_lastArgPos}: {_lastArg} ({_lastArg.Type}), expected: {_expectedType.FullName}", 2);
        });
        private static readonly global::Lua.LuaFunction _LuaMaterialEditor_TextureProperty = new global::Lua.LuaFunction("TextureProperty", (_context, _) =>
        {
            global::Lua.LuaValue _lastArg = default;
            global::System.Int32 _lastArgPos = default;
            global::System.Type _expectedType = default;
            var _argCount = _context.ArgumentCount;
            var _this = _context.GetArgument<LuaMaterialEditor>(0);
            var _arg0 = _lastArg = _argCount > 1 ? _context.GetArgument(1) : global::Lua.LuaValue.Nil;
            _lastArgPos = 0; _expectedType = typeof(global::Luny.UnityEditor.LuaMaterialProperty);
            if (_arg0.TryRead<global::Luny.UnityEditor.LuaMaterialProperty>(out var _p0_UnityEditor_MaterialProperty))
            {
                var _arg1 = _lastArg = _argCount > 2 ? _context.GetArgument(2) : global::Lua.LuaValue.Nil;
                _lastArgPos = 1; _expectedType = typeof(global::System.String);
                if (_arg1.TryRead<global::System.String>(out var _p1_System_String))
                {
                    if (_argCount == 3)
                    {
                        var prop = _p0_UnityEditor_MaterialProperty.Instance;
                        var label = _p1_System_String;
                        var _ret0 = _this.Instance.TextureProperty(prop, label);
                        var _factory = _context.GetObjectFactory();
                        var _lret0 = _factory.Bind(_ret0);
                        var _retCount = _context.Return(_lret0);
                        return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                    }
                    var _arg2 = _lastArg = _argCount > 3 ? _context.GetArgument(3) : global::Lua.LuaValue.Nil;
                    _lastArgPos = 2; _expectedType = typeof(global::System.Boolean);
                    if (_arg2.TryRead<global::System.Boolean>(out var _p2_System_Boolean))
                    {
                        if (_argCount == 4)
                        {
                            var prop = _p0_UnityEditor_MaterialProperty.Instance;
                            var label = _p1_System_String;
                            var scaleOffset = _p2_System_Boolean;
                            var _ret0 = _this.Instance.TextureProperty(prop, label, scaleOffset);
                            var _factory = _context.GetObjectFactory();
                            var _lret0 = _factory.Bind(_ret0);
                            var _retCount = _context.Return(_lret0);
                            return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                        }
                    }
                }
            }
            _lastArgPos = 0; _expectedType = typeof(global::Luny.UnityEngine.LuaRect);
            if (_arg0.TryRead<global::Luny.UnityEngine.LuaRect>(out var _p0_UnityEngine_Rect))
            {
                var _arg1 = _lastArg = _argCount > 2 ? _context.GetArgument(2) : global::Lua.LuaValue.Nil;
                _lastArgPos = 1; _expectedType = typeof(global::Luny.UnityEditor.LuaMaterialProperty);
                if (_arg1.TryRead<global::Luny.UnityEditor.LuaMaterialProperty>(out var _p1_UnityEditor_MaterialProperty))
                {
                    var _arg2 = _lastArg = _argCount > 3 ? _context.GetArgument(3) : global::Lua.LuaValue.Nil;
                    _lastArgPos = 2; _expectedType = typeof(global::System.String);
                    if (_arg2.TryRead<global::System.String>(out var _p2_System_String))
                    {
                        if (_argCount == 4)
                        {
                            var position = _p0_UnityEngine_Rect.Value;
                            var prop = _p1_UnityEditor_MaterialProperty.Instance;
                            var label = _p2_System_String;
                            var _ret0 = _this.Instance.TextureProperty(position, prop, label);
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
                                var position = _p0_UnityEngine_Rect.Value;
                                var prop = _p1_UnityEditor_MaterialProperty.Instance;
                                var label = _p2_System_String;
                                var scaleOffset = _p3_System_Boolean;
                                var _ret0 = _this.Instance.TextureProperty(position, prop, label, scaleOffset);
                                var _factory = _context.GetObjectFactory();
                                var _lret0 = _factory.Bind(_ret0);
                                var _retCount = _context.Return(_lret0);
                                return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                            }
                        }
                        _lastArgPos = 3; _expectedType = typeof(global::System.String);
                        if (_arg3.TryRead<global::System.String>(out var _p3_System_String))
                        {
                            var _arg4 = _lastArg = _argCount > 5 ? _context.GetArgument(5) : global::Lua.LuaValue.Nil;
                            _lastArgPos = 4; _expectedType = typeof(global::System.Boolean);
                            if (_arg4.TryRead<global::System.Boolean>(out var _p4_System_Boolean))
                            {
                                if (_argCount == 6)
                                {
                                    var position = _p0_UnityEngine_Rect.Value;
                                    var prop = _p1_UnityEditor_MaterialProperty.Instance;
                                    var label = _p2_System_String;
                                    var tooltip = _p3_System_String;
                                    var scaleOffset = _p4_System_Boolean;
                                    var _ret0 = _this.Instance.TextureProperty(position, prop, label, tooltip, scaleOffset);
                                    var _factory = _context.GetObjectFactory();
                                    var _lret0 = _factory.Bind(_ret0);
                                    var _retCount = _context.Return(_lret0);
                                    return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                                }
                            }
                        }
                    }
                    _lastArgPos = 2; _expectedType = typeof(global::UnityEngine.GUIContent);
                    if (_arg2.TryRead<global::UnityEngine.GUIContent>(out var _p2_UnityEngine_GUIContent))
                    {
                        if (_argCount == 4)
                        {
                            var position = _p0_UnityEngine_Rect.Value;
                            var prop = _p1_UnityEditor_MaterialProperty.Instance;
                            var label = _p2_UnityEngine_GUIContent;
                            var _ret0 = _this.Instance.TextureProperty(position, prop, label);
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
                                var position = _p0_UnityEngine_Rect.Value;
                                var prop = _p1_UnityEditor_MaterialProperty.Instance;
                                var label = _p2_UnityEngine_GUIContent;
                                var scaleOffset = _p3_System_Boolean;
                                var _ret0 = _this.Instance.TextureProperty(position, prop, label, scaleOffset);
                                var _factory = _context.GetObjectFactory();
                                var _lret0 = _factory.Bind(_ret0);
                                var _retCount = _context.Return(_lret0);
                                return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                            }
                        }
                    }
                }
            }
            throw new global::Lua.LuaRuntimeException(_context.Thread, $"{"TextureProperty"}: invalid argument #{_lastArgPos}: {_lastArg} ({_lastArg.Type}), expected: {_expectedType.FullName}", 2);
        });
        private static readonly global::Lua.LuaFunction _LuaMaterialEditor_TexturePropertyMiniThumbnail = new global::Lua.LuaFunction("TexturePropertyMiniThumbnail", (_context, _) =>
        {
            global::Lua.LuaValue _lastArg = default;
            global::System.Int32 _lastArgPos = default;
            global::System.Type _expectedType = default;
            var _argCount = _context.ArgumentCount;
            var _this = _context.GetArgument<LuaMaterialEditor>(0);
            var _arg0 = _lastArg = _argCount > 1 ? _context.GetArgument(1) : global::Lua.LuaValue.Nil;
            _lastArgPos = 0; _expectedType = typeof(global::Luny.UnityEngine.LuaRect);
            if (_arg0.TryRead<global::Luny.UnityEngine.LuaRect>(out var _p0_UnityEngine_Rect))
            {
                var _arg1 = _lastArg = _argCount > 2 ? _context.GetArgument(2) : global::Lua.LuaValue.Nil;
                _lastArgPos = 1; _expectedType = typeof(global::Luny.UnityEditor.LuaMaterialProperty);
                if (_arg1.TryRead<global::Luny.UnityEditor.LuaMaterialProperty>(out var _p1_UnityEditor_MaterialProperty))
                {
                    var _arg2 = _lastArg = _argCount > 3 ? _context.GetArgument(3) : global::Lua.LuaValue.Nil;
                    _lastArgPos = 2; _expectedType = typeof(global::System.String);
                    if (_arg2.TryRead<global::System.String>(out var _p2_System_String))
                    {
                        var _arg3 = _lastArg = _argCount > 4 ? _context.GetArgument(4) : global::Lua.LuaValue.Nil;
                        _lastArgPos = 3; _expectedType = typeof(global::System.String);
                        if (_arg3.TryRead<global::System.String>(out var _p3_System_String))
                        {
                            if (_argCount == 5)
                            {
                                var position = _p0_UnityEngine_Rect.Value;
                                var prop = _p1_UnityEditor_MaterialProperty.Instance;
                                var label = _p2_System_String;
                                var tooltip = _p3_System_String;
                                var _ret0 = _this.Instance.TexturePropertyMiniThumbnail(position, prop, label, tooltip);
                                var _factory = _context.GetObjectFactory();
                                var _lret0 = _factory.Bind(_ret0);
                                var _retCount = _context.Return(_lret0);
                                return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                            }
                        }
                    }
                }
            }
            throw new global::Lua.LuaRuntimeException(_context.Thread, $"{"TexturePropertyMiniThumbnail"}: invalid argument #{_lastArgPos}: {_lastArg} ({_lastArg.Type}), expected: {_expectedType.FullName}", 2);
        });
        private static readonly global::Lua.LuaFunction _LuaMaterialEditor_TexturePropertySingleLine = new global::Lua.LuaFunction("TexturePropertySingleLine", (_context, _) =>
        {
            global::Lua.LuaValue _lastArg = default;
            global::System.Int32 _lastArgPos = default;
            global::System.Type _expectedType = default;
            var _argCount = _context.ArgumentCount;
            var _this = _context.GetArgument<LuaMaterialEditor>(0);
            var _arg0 = _lastArg = _argCount > 1 ? _context.GetArgument(1) : global::Lua.LuaValue.Nil;
            _lastArgPos = 0; _expectedType = typeof(global::UnityEngine.GUIContent);
            if (_arg0.TryRead<global::UnityEngine.GUIContent>(out var _p0_UnityEngine_GUIContent))
            {
                var _arg1 = _lastArg = _argCount > 2 ? _context.GetArgument(2) : global::Lua.LuaValue.Nil;
                _lastArgPos = 1; _expectedType = typeof(global::Luny.UnityEditor.LuaMaterialProperty);
                if (_arg1.TryRead<global::Luny.UnityEditor.LuaMaterialProperty>(out var _p1_UnityEditor_MaterialProperty))
                {
                    if (_argCount == 3)
                    {
                        var label = _p0_UnityEngine_GUIContent;
                        var textureProp = _p1_UnityEditor_MaterialProperty.Instance;
                        var _ret0 = _this.Instance.TexturePropertySingleLine(label, textureProp);
                        var _lret0 = global::Luny.UnityEngine.LuaRect.Bind(_ret0);
                        var _retCount = _context.Return(_lret0);
                        return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                    }
                    var _arg2 = _lastArg = _argCount > 3 ? _context.GetArgument(3) : global::Lua.LuaValue.Nil;
                    _lastArgPos = 2; _expectedType = typeof(global::Luny.UnityEditor.LuaMaterialProperty);
                    if (_arg2.TryRead<global::Luny.UnityEditor.LuaMaterialProperty>(out var _p2_UnityEditor_MaterialProperty))
                    {
                        if (_argCount == 4)
                        {
                            var label = _p0_UnityEngine_GUIContent;
                            var textureProp = _p1_UnityEditor_MaterialProperty.Instance;
                            var extraProperty1 = _p2_UnityEditor_MaterialProperty.Instance;
                            var _ret0 = _this.Instance.TexturePropertySingleLine(label, textureProp, extraProperty1);
                            var _lret0 = global::Luny.UnityEngine.LuaRect.Bind(_ret0);
                            var _retCount = _context.Return(_lret0);
                            return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                        }
                        var _arg3 = _lastArg = _argCount > 4 ? _context.GetArgument(4) : global::Lua.LuaValue.Nil;
                        _lastArgPos = 3; _expectedType = typeof(global::Luny.UnityEditor.LuaMaterialProperty);
                        if (_arg3.TryRead<global::Luny.UnityEditor.LuaMaterialProperty>(out var _p3_UnityEditor_MaterialProperty))
                        {
                            if (_argCount == 5)
                            {
                                var label = _p0_UnityEngine_GUIContent;
                                var textureProp = _p1_UnityEditor_MaterialProperty.Instance;
                                var extraProperty1 = _p2_UnityEditor_MaterialProperty.Instance;
                                var extraProperty2 = _p3_UnityEditor_MaterialProperty.Instance;
                                var _ret0 = _this.Instance.TexturePropertySingleLine(label, textureProp, extraProperty1, extraProperty2);
                                var _lret0 = global::Luny.UnityEngine.LuaRect.Bind(_ret0);
                                var _retCount = _context.Return(_lret0);
                                return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                            }
                        }
                    }
                }
            }
            throw new global::Lua.LuaRuntimeException(_context.Thread, $"{"TexturePropertySingleLine"}: invalid argument #{_lastArgPos}: {_lastArg} ({_lastArg.Type}), expected: {_expectedType.FullName}", 2);
        });
        private static readonly global::Lua.LuaFunction _LuaMaterialEditor_TexturePropertyTwoLines = new global::Lua.LuaFunction("TexturePropertyTwoLines", (_context, _) =>
        {
            global::Lua.LuaValue _lastArg = default;
            global::System.Int32 _lastArgPos = default;
            global::System.Type _expectedType = default;
            var _argCount = _context.ArgumentCount;
            var _this = _context.GetArgument<LuaMaterialEditor>(0);
            var _arg0 = _lastArg = _argCount > 1 ? _context.GetArgument(1) : global::Lua.LuaValue.Nil;
            _lastArgPos = 0; _expectedType = typeof(global::UnityEngine.GUIContent);
            if (_arg0.TryRead<global::UnityEngine.GUIContent>(out var _p0_UnityEngine_GUIContent))
            {
                var _arg1 = _lastArg = _argCount > 2 ? _context.GetArgument(2) : global::Lua.LuaValue.Nil;
                _lastArgPos = 1; _expectedType = typeof(global::Luny.UnityEditor.LuaMaterialProperty);
                if (_arg1.TryRead<global::Luny.UnityEditor.LuaMaterialProperty>(out var _p1_UnityEditor_MaterialProperty))
                {
                    var _arg2 = _lastArg = _argCount > 3 ? _context.GetArgument(3) : global::Lua.LuaValue.Nil;
                    _lastArgPos = 2; _expectedType = typeof(global::Luny.UnityEditor.LuaMaterialProperty);
                    if (_arg2.TryRead<global::Luny.UnityEditor.LuaMaterialProperty>(out var _p2_UnityEditor_MaterialProperty))
                    {
                        var _arg3 = _lastArg = _argCount > 4 ? _context.GetArgument(4) : global::Lua.LuaValue.Nil;
                        _lastArgPos = 3; _expectedType = typeof(global::UnityEngine.GUIContent);
                        if (_arg3.TryRead<global::UnityEngine.GUIContent>(out var _p3_UnityEngine_GUIContent))
                        {
                            var _arg4 = _lastArg = _argCount > 5 ? _context.GetArgument(5) : global::Lua.LuaValue.Nil;
                            _lastArgPos = 4; _expectedType = typeof(global::Luny.UnityEditor.LuaMaterialProperty);
                            if (_arg4.TryRead<global::Luny.UnityEditor.LuaMaterialProperty>(out var _p4_UnityEditor_MaterialProperty))
                            {
                                if (_argCount == 6)
                                {
                                    var label = _p0_UnityEngine_GUIContent;
                                    var textureProp = _p1_UnityEditor_MaterialProperty.Instance;
                                    var extraProperty1 = _p2_UnityEditor_MaterialProperty.Instance;
                                    var label2 = _p3_UnityEngine_GUIContent;
                                    var extraProperty2 = _p4_UnityEditor_MaterialProperty.Instance;
                                    var _ret0 = _this.Instance.TexturePropertyTwoLines(label, textureProp, extraProperty1, label2, extraProperty2);
                                    var _lret0 = global::Luny.UnityEngine.LuaRect.Bind(_ret0);
                                    var _retCount = _context.Return(_lret0);
                                    return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                                }
                            }
                        }
                    }
                }
            }
            throw new global::Lua.LuaRuntimeException(_context.Thread, $"{"TexturePropertyTwoLines"}: invalid argument #{_lastArgPos}: {_lastArg} ({_lastArg.Type}), expected: {_expectedType.FullName}", 2);
        });
        private static readonly global::Lua.LuaFunction _LuaMaterialEditor_TexturePropertyWithHDRColor = new global::Lua.LuaFunction("TexturePropertyWithHDRColor", (_context, _) =>
        {
            global::Lua.LuaValue _lastArg = default;
            global::System.Int32 _lastArgPos = default;
            global::System.Type _expectedType = default;
            var _argCount = _context.ArgumentCount;
            var _this = _context.GetArgument<LuaMaterialEditor>(0);
            var _arg0 = _lastArg = _argCount > 1 ? _context.GetArgument(1) : global::Lua.LuaValue.Nil;
            _lastArgPos = 0; _expectedType = typeof(global::UnityEngine.GUIContent);
            if (_arg0.TryRead<global::UnityEngine.GUIContent>(out var _p0_UnityEngine_GUIContent))
            {
                var _arg1 = _lastArg = _argCount > 2 ? _context.GetArgument(2) : global::Lua.LuaValue.Nil;
                _lastArgPos = 1; _expectedType = typeof(global::Luny.UnityEditor.LuaMaterialProperty);
                if (_arg1.TryRead<global::Luny.UnityEditor.LuaMaterialProperty>(out var _p1_UnityEditor_MaterialProperty))
                {
                    var _arg2 = _lastArg = _argCount > 3 ? _context.GetArgument(3) : global::Lua.LuaValue.Nil;
                    _lastArgPos = 2; _expectedType = typeof(global::Luny.UnityEditor.LuaMaterialProperty);
                    if (_arg2.TryRead<global::Luny.UnityEditor.LuaMaterialProperty>(out var _p2_UnityEditor_MaterialProperty))
                    {
                        var _arg3 = _lastArg = _argCount > 4 ? _context.GetArgument(4) : global::Lua.LuaValue.Nil;
                        _lastArgPos = 3; _expectedType = typeof(global::System.Boolean);
                        if (_arg3.TryRead<global::System.Boolean>(out var _p3_System_Boolean))
                        {
                            if (_argCount == 5)
                            {
                                var label = _p0_UnityEngine_GUIContent;
                                var textureProp = _p1_UnityEditor_MaterialProperty.Instance;
                                var colorProperty = _p2_UnityEditor_MaterialProperty.Instance;
                                var showAlpha = _p3_System_Boolean;
                                var _ret0 = _this.Instance.TexturePropertyWithHDRColor(label, textureProp, colorProperty, showAlpha);
                                var _lret0 = global::Luny.UnityEngine.LuaRect.Bind(_ret0);
                                var _retCount = _context.Return(_lret0);
                                return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                            }
                        }
                    }
                }
            }
            throw new global::Lua.LuaRuntimeException(_context.Thread, $"{"TexturePropertyWithHDRColor"}: invalid argument #{_lastArgPos}: {_lastArg} ({_lastArg.Type}), expected: {_expectedType.FullName}", 2);
        });
        private static readonly global::Lua.LuaFunction _LuaMaterialEditor_TextureScaleOffsetProperty = new global::Lua.LuaFunction("TextureScaleOffsetProperty", (_context, _) =>
        {
            global::Lua.LuaValue _lastArg = default;
            global::System.Int32 _lastArgPos = default;
            global::System.Type _expectedType = default;
            var _argCount = _context.ArgumentCount;
            var _this = _context.GetArgument<LuaMaterialEditor>(0);
            var _arg0 = _lastArg = _argCount > 1 ? _context.GetArgument(1) : global::Lua.LuaValue.Nil;
            _lastArgPos = 0; _expectedType = typeof(global::Luny.UnityEditor.LuaMaterialProperty);
            if (_arg0.TryRead<global::Luny.UnityEditor.LuaMaterialProperty>(out var _p0_UnityEditor_MaterialProperty))
            {
                if (_argCount == 2)
                {
                    var property = _p0_UnityEditor_MaterialProperty.Instance;
                    _this.Instance.TextureScaleOffsetProperty(property);
                    var _retCount = _context.Return();
                    return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                }
            }
            _lastArgPos = 0; _expectedType = typeof(global::Luny.UnityEngine.LuaRect);
            if (_arg0.TryRead<global::Luny.UnityEngine.LuaRect>(out var _p0_UnityEngine_Rect))
            {
                var _arg1 = _lastArg = _argCount > 2 ? _context.GetArgument(2) : global::Lua.LuaValue.Nil;
                _lastArgPos = 1; _expectedType = typeof(global::Luny.UnityEditor.LuaMaterialProperty);
                if (_arg1.TryRead<global::Luny.UnityEditor.LuaMaterialProperty>(out var _p1_UnityEditor_MaterialProperty))
                {
                    if (_argCount == 3)
                    {
                        var position = _p0_UnityEngine_Rect.Value;
                        var property = _p1_UnityEditor_MaterialProperty.Instance;
                        var _ret0 = _this.Instance.TextureScaleOffsetProperty(position, property);
                        var _lret0 = new global::Lua.LuaValue(_ret0);
                        var _retCount = _context.Return(_lret0);
                        return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                    }
                    var _arg2 = _lastArg = _argCount > 3 ? _context.GetArgument(3) : global::Lua.LuaValue.Nil;
                    _lastArgPos = 2; _expectedType = typeof(global::System.Boolean);
                    if (_arg2.TryRead<global::System.Boolean>(out var _p2_System_Boolean))
                    {
                        if (_argCount == 4)
                        {
                            var position = _p0_UnityEngine_Rect.Value;
                            var property = _p1_UnityEditor_MaterialProperty.Instance;
                            var partOfTexturePropertyControl = _p2_System_Boolean;
                            var _ret0 = _this.Instance.TextureScaleOffsetProperty(position, property, partOfTexturePropertyControl);
                            var _lret0 = new global::Lua.LuaValue(_ret0);
                            var _retCount = _context.Return(_lret0);
                            return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                        }
                    }
                }
            }
            throw new global::Lua.LuaRuntimeException(_context.Thread, $"{"TextureScaleOffsetProperty"}: invalid argument #{_lastArgPos}: {_lastArg} ({_lastArg.Type}), expected: {_expectedType.FullName}", 2);
        });
        private static readonly global::Lua.LuaFunction _LuaMaterialEditor_VectorProperty = new global::Lua.LuaFunction("VectorProperty", (_context, _) =>
        {
            global::Lua.LuaValue _lastArg = default;
            global::System.Int32 _lastArgPos = default;
            global::System.Type _expectedType = default;
            var _argCount = _context.ArgumentCount;
            var _this = _context.GetArgument<LuaMaterialEditor>(0);
            var _arg0 = _lastArg = _argCount > 1 ? _context.GetArgument(1) : global::Lua.LuaValue.Nil;
            _lastArgPos = 0; _expectedType = typeof(global::Luny.UnityEditor.LuaMaterialProperty);
            if (_arg0.TryRead<global::Luny.UnityEditor.LuaMaterialProperty>(out var _p0_UnityEditor_MaterialProperty))
            {
                var _arg1 = _lastArg = _argCount > 2 ? _context.GetArgument(2) : global::Lua.LuaValue.Nil;
                _lastArgPos = 1; _expectedType = typeof(global::System.String);
                if (_arg1.TryRead<global::System.String>(out var _p1_System_String))
                {
                    if (_argCount == 3)
                    {
                        var prop = _p0_UnityEditor_MaterialProperty.Instance;
                        var label = _p1_System_String;
                        var _ret0 = _this.Instance.VectorProperty(prop, label);
                        var _lret0 = global::Luny.UnityEngine.LuaVector4.Bind(_ret0);
                        var _retCount = _context.Return(_lret0);
                        return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                    }
                }
                _lastArgPos = 1; _expectedType = typeof(global::UnityEngine.GUIContent);
                if (_arg1.TryRead<global::UnityEngine.GUIContent>(out var _p1_UnityEngine_GUIContent))
                {
                    if (_argCount == 3)
                    {
                        var prop = _p0_UnityEditor_MaterialProperty.Instance;
                        var label = _p1_UnityEngine_GUIContent;
                        var _ret0 = _this.Instance.VectorProperty(prop, label);
                        var _lret0 = global::Luny.UnityEngine.LuaVector4.Bind(_ret0);
                        var _retCount = _context.Return(_lret0);
                        return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                    }
                }
            }
            _lastArgPos = 0; _expectedType = typeof(global::Luny.UnityEngine.LuaRect);
            if (_arg0.TryRead<global::Luny.UnityEngine.LuaRect>(out var _p0_UnityEngine_Rect))
            {
                var _arg1 = _lastArg = _argCount > 2 ? _context.GetArgument(2) : global::Lua.LuaValue.Nil;
                _lastArgPos = 1; _expectedType = typeof(global::Luny.UnityEditor.LuaMaterialProperty);
                if (_arg1.TryRead<global::Luny.UnityEditor.LuaMaterialProperty>(out var _p1_UnityEditor_MaterialProperty))
                {
                    var _arg2 = _lastArg = _argCount > 3 ? _context.GetArgument(3) : global::Lua.LuaValue.Nil;
                    _lastArgPos = 2; _expectedType = typeof(global::System.String);
                    if (_arg2.TryRead<global::System.String>(out var _p2_System_String))
                    {
                        if (_argCount == 4)
                        {
                            var position = _p0_UnityEngine_Rect.Value;
                            var prop = _p1_UnityEditor_MaterialProperty.Instance;
                            var label = _p2_System_String;
                            var _ret0 = _this.Instance.VectorProperty(position, prop, label);
                            var _lret0 = global::Luny.UnityEngine.LuaVector4.Bind(_ret0);
                            var _retCount = _context.Return(_lret0);
                            return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                        }
                    }
                    _lastArgPos = 2; _expectedType = typeof(global::UnityEngine.GUIContent);
                    if (_arg2.TryRead<global::UnityEngine.GUIContent>(out var _p2_UnityEngine_GUIContent))
                    {
                        if (_argCount == 4)
                        {
                            var position = _p0_UnityEngine_Rect.Value;
                            var prop = _p1_UnityEditor_MaterialProperty.Instance;
                            var label = _p2_UnityEngine_GUIContent;
                            var _ret0 = _this.Instance.VectorProperty(position, prop, label);
                            var _lret0 = global::Luny.UnityEngine.LuaVector4.Bind(_ret0);
                            var _retCount = _context.Return(_lret0);
                            return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                        }
                    }
                }
            }
            throw new global::Lua.LuaRuntimeException(_context.Thread, $"{"VectorProperty"}: invalid argument #{_lastArgPos}: {_lastArg} ({_lastArg.Type}), expected: {_expectedType.FullName}", 2);
        });
        private static readonly global::Lua.LuaFunction __index = new(global::Lua.Runtime.Metamethods.Index, (_context, _) =>
        {
            var _this = _context.GetArgument<LuaMaterialEditor>(0);
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
            var _this = _context.GetArgument<LuaMaterialEditor>(0);
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
                case "Awake": _value = _LuaMaterialEditor_Awake; return true;
                case "BeginAnimatedCheck": _value = _LuaMaterialEditor_BeginAnimatedCheck; return true;
                case "ColorProperty": _value = _LuaMaterialEditor_ColorProperty; return true;
                case "CreatePreview": _value = _LuaMaterialEditor_CreatePreview; return true;
                case "DefaultPreviewGUI": _value = _LuaMaterialEditor_DefaultPreviewGUI; return true;
                case "DefaultPreviewSettingsGUI": _value = _LuaMaterialEditor_DefaultPreviewSettingsGUI; return true;
                case "DefaultShaderProperty": _value = _LuaMaterialEditor_DefaultShaderProperty; return true;
                case "DoubleSidedGIField": _value = _LuaMaterialEditor_DoubleSidedGIField; return true;
                case "EmissionEnabledProperty": _value = _LuaMaterialEditor_EmissionEnabledProperty; return true;
                case "EnableInstancingField": _value = _LuaMaterialEditor_EnableInstancingField; return true;
                case "EndAnimatedCheck": _value = _LuaMaterialEditor_EndAnimatedCheck; return true;
                case "FloatProperty": _value = _LuaMaterialEditor_FloatProperty; return true;
                case "GetPropertyHeight": _value = _LuaMaterialEditor_GetPropertyHeight; return true;
                case "GetTexturePropertyCustomArea": _value = _LuaMaterialEditor_GetTexturePropertyCustomArea; return true;
                case "HasPreviewGUI": _value = _LuaMaterialEditor_HasPreviewGUI; return true;
                case "HelpBoxWithButton": _value = _LuaMaterialEditor_HelpBoxWithButton; return true;
                case "IntegerProperty": _value = _LuaMaterialEditor_IntegerProperty; return true;
                case "IsInstancingEnabled": _value = _LuaMaterialEditor_IsInstancingEnabled; return true;
                case "LightmapEmissionFlagsProperty": _value = _LuaMaterialEditor_LightmapEmissionFlagsProperty; return true;
                case "LightmapEmissionProperty": _value = _LuaMaterialEditor_LightmapEmissionProperty; return true;
                case "OnDisable": _value = _LuaMaterialEditor_OnDisable; return true;
                case "OnEnable": _value = _LuaMaterialEditor_OnEnable; return true;
                case "OnInspectorGUI": _value = _LuaMaterialEditor_OnInspectorGUI; return true;
                case "OnInteractivePreviewGUI": _value = _LuaMaterialEditor_OnInteractivePreviewGUI; return true;
                case "OnPreviewGUI": _value = _LuaMaterialEditor_OnPreviewGUI; return true;
                case "OnPreviewSettings": _value = _LuaMaterialEditor_OnPreviewSettings; return true;
                case "PropertiesChanged": _value = _LuaMaterialEditor_PropertiesChanged; return true;
                case "PropertiesDefaultGUI": _value = _LuaMaterialEditor_PropertiesDefaultGUI; return true;
                case "PropertiesGUI": _value = _LuaMaterialEditor_PropertiesGUI; return true;
                case "RangeProperty": _value = _LuaMaterialEditor_RangeProperty; return true;
                case "RegisterPropertyChangeUndo": _value = _LuaMaterialEditor_RegisterPropertyChangeUndo; return true;
                case "RenderQueueField": _value = _LuaMaterialEditor_RenderQueueField; return true;
                case "RenderStaticPreview": _value = _LuaMaterialEditor_RenderStaticPreview; return true;
                case "RequiresConstantRepaint": _value = _LuaMaterialEditor_RequiresConstantRepaint; return true;
                case "SetDefaultGUIWidths": _value = _LuaMaterialEditor_SetDefaultGUIWidths; return true;
                case "SetShader": _value = _LuaMaterialEditor_SetShader; return true;
                case "ShaderProperty": _value = _LuaMaterialEditor_ShaderProperty; return true;
                case "TextureCompatibilityWarning": _value = _LuaMaterialEditor_TextureCompatibilityWarning; return true;
                case "TextureProperty": _value = _LuaMaterialEditor_TextureProperty; return true;
                case "TexturePropertyMiniThumbnail": _value = _LuaMaterialEditor_TexturePropertyMiniThumbnail; return true;
                case "TexturePropertySingleLine": _value = _LuaMaterialEditor_TexturePropertySingleLine; return true;
                case "TexturePropertyTwoLines": _value = _LuaMaterialEditor_TexturePropertyTwoLines; return true;
                case "TexturePropertyWithHDRColor": _value = _LuaMaterialEditor_TexturePropertyWithHDRColor; return true;
                case "TextureScaleOffsetProperty": _value = _LuaMaterialEditor_TextureScaleOffsetProperty; return true;
                case "VectorProperty": _value = _LuaMaterialEditor_VectorProperty; return true;
                case "customShaderGUI": _value = _factory.Bind(Instance.customShaderGUI); return true;
                case "isVisible": _value = new global::Lua.LuaValue(Instance.isVisible); return true;
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
                default: return base.TrySetLuaValue(_key, _value);
            }
        }
    }
    public sealed class LuaMaterialEditorType : global::Luny.ILuaStatic
    {
        public static global::Lua.LuaValue Bind() => new LuaMaterialEditorType();
        private LuaMaterialEditorType() {}
        public static implicit operator global::Lua.LuaValue(LuaMaterialEditorType value) => new(value);
        public global::System.Type BindType => typeof(global::UnityEditor.MaterialEditor);
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
            metatable[global::Lua.Runtime.Metamethods.Call] = _LuaMaterialEditor_new;
            return metatable;
        }
        public override global::System.String ToString() => BindType.FullName;
#if UNITY_EDITOR
        [global::UnityEngine.RuntimeInitializeOnLoadMethod(global::UnityEngine.RuntimeInitializeLoadType.SubsystemRegistration)]
        private static void ResetStaticFields() => s_Metatable = null;
#endif

        private static readonly global::Lua.LuaFunction _LuaMaterialEditor_new = new global::Lua.LuaFunction(".ctor", (_context, _) =>
        {
            global::Lua.LuaValue _lastArg = default;
            global::System.Int32 _lastArgPos = default;
            global::System.Type _expectedType = default;
            var _argCount = _context.ArgumentCount;
            if (_argCount == 1)
            {
                var _ret0 = new global::UnityEditor.MaterialEditor();
                var _factory = _context.GetObjectFactory();
                var _lret0 = _factory.Bind(_ret0);
                var _retCount = _context.Return(_lret0);
                return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
            }
            throw new global::Lua.LuaRuntimeException(_context.Thread, $"{".ctor"}: invalid argument #{_lastArgPos}: {_lastArg} ({_lastArg.Type}), expected: {_expectedType.FullName}", 2);
        });
        private static readonly global::Lua.LuaFunction _LuaMaterialEditor_ApplyMaterialPropertyDrawers = new global::Lua.LuaFunction("ApplyMaterialPropertyDrawers", (_context, _) =>
        {
            global::Lua.LuaValue _lastArg = default;
            global::System.Int32 _lastArgPos = default;
            global::System.Type _expectedType = default;
            var _argCount = _context.ArgumentCount;
            var _arg0 = _lastArg = _argCount > 0 ? _context.GetArgument(0) : global::Lua.LuaValue.Nil;
            _lastArgPos = 0; _expectedType = typeof(global::Luny.UnityEngine.LuaMaterial);
            if (_arg0.TryRead<global::Luny.UnityEngine.LuaMaterial>(out var _p0_UnityEngine_Material))
            {
                if (_argCount == 1)
                {
                    var material = _p0_UnityEngine_Material.Instance;
                    global::UnityEditor.MaterialEditor.ApplyMaterialPropertyDrawers(material);
                    var _retCount = _context.Return();
                    return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                }
            }
            _lastArgPos = 0; _expectedType = typeof(global::UnityEngine.Object[]);
            if (_arg0.TryReadArray<global::UnityEngine.Object>(out var _p0_UnityEngine_ObjectArray))
            {
                if (_argCount == 1)
                {
                    var targets = _p0_UnityEngine_ObjectArray;
                    global::UnityEditor.MaterialEditor.ApplyMaterialPropertyDrawers(targets);
                    var _retCount = _context.Return();
                    return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                }
            }
            throw new global::Lua.LuaRuntimeException(_context.Thread, $"{"ApplyMaterialPropertyDrawers"}: invalid argument #{_lastArgPos}: {_lastArg} ({_lastArg.Type}), expected: {_expectedType.FullName}", 2);
        });
        private static readonly global::Lua.LuaFunction _LuaMaterialEditor_BeginProperty = new global::Lua.LuaFunction("BeginProperty", (_context, _) =>
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
                    global::UnityEditor.MaterialEditor.BeginProperty(property);
                    var _retCount = _context.Return();
                    return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                }
            }
            _lastArgPos = 0; _expectedType = typeof(global::Luny.UnityEditor.LuaMaterialProperty);
            if (_arg0.TryRead<global::Luny.UnityEditor.LuaMaterialProperty>(out var _p0_UnityEditor_MaterialProperty))
            {
                if (_argCount == 1)
                {
                    var property = _p0_UnityEditor_MaterialProperty.Instance;
                    global::UnityEditor.MaterialEditor.BeginProperty(property);
                    var _retCount = _context.Return();
                    return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                }
            }
            _lastArgPos = 0; _expectedType = typeof(global::Luny.UnityEngine.LuaRect);
            if (_arg0.TryRead<global::Luny.UnityEngine.LuaRect>(out var _p0_UnityEngine_Rect))
            {
                var _arg1 = _lastArg = _argCount > 1 ? _context.GetArgument(1) : global::Lua.LuaValue.Nil;
                _lastArgPos = 1; _expectedType = typeof(global::Luny.UnityEditor.LuaSerializedProperty);
                if (_arg1.TryRead<global::Luny.UnityEditor.LuaSerializedProperty>(out var _p1_UnityEditor_SerializedProperty))
                {
                    if (_argCount == 2)
                    {
                        var rect = _p0_UnityEngine_Rect.Value;
                        var property = _p1_UnityEditor_SerializedProperty.Instance;
                        global::UnityEditor.MaterialEditor.BeginProperty(rect, property);
                        var _retCount = _context.Return();
                        return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                    }
                }
                _lastArgPos = 1; _expectedType = typeof(global::Luny.UnityEditor.LuaMaterialProperty);
                if (_arg1.TryRead<global::Luny.UnityEditor.LuaMaterialProperty>(out var _p1_UnityEditor_MaterialProperty))
                {
                    if (_argCount == 2)
                    {
                        var rect = _p0_UnityEngine_Rect.Value;
                        var property = _p1_UnityEditor_MaterialProperty.Instance;
                        global::UnityEditor.MaterialEditor.BeginProperty(rect, property);
                        var _retCount = _context.Return();
                        return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                    }
                }
            }
            throw new global::Lua.LuaRuntimeException(_context.Thread, $"{"BeginProperty"}: invalid argument #{_lastArgPos}: {_lastArg} ({_lastArg.Type}), expected: {_expectedType.FullName}", 2);
        });
        private static readonly global::Lua.LuaFunction _LuaMaterialEditor_EndProperty = new global::Lua.LuaFunction("EndProperty", (_context, _) =>
        {
            global::Lua.LuaValue _lastArg = default;
            global::System.Int32 _lastArgPos = default;
            global::System.Type _expectedType = default;
            var _argCount = _context.ArgumentCount;
            if (_argCount == 0)
            {
                global::UnityEditor.MaterialEditor.EndProperty();
                var _retCount = _context.Return();
                return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
            }
            throw new global::Lua.LuaRuntimeException(_context.Thread, $"{"EndProperty"}: invalid argument #{_lastArgPos}: {_lastArg} ({_lastArg.Type}), expected: {_expectedType.FullName}", 2);
        });
        private static readonly global::Lua.LuaFunction _LuaMaterialEditor_FixupEmissiveFlag = new global::Lua.LuaFunction("FixupEmissiveFlag", (_context, _) =>
        {
            global::Lua.LuaValue _lastArg = default;
            global::System.Int32 _lastArgPos = default;
            global::System.Type _expectedType = default;
            var _argCount = _context.ArgumentCount;
            var _arg0 = _lastArg = _argCount > 0 ? _context.GetArgument(0) : global::Lua.LuaValue.Nil;
            _lastArgPos = 0; _expectedType = typeof(global::Luny.UnityEngine.LuaMaterial);
            if (_arg0.TryRead<global::Luny.UnityEngine.LuaMaterial>(out var _p0_UnityEngine_Material))
            {
                if (_argCount == 1)
                {
                    var mat = _p0_UnityEngine_Material.Instance;
                    global::UnityEditor.MaterialEditor.FixupEmissiveFlag(mat);
                    var _retCount = _context.Return();
                    return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                }
            }
            _lastArgPos = 0; _expectedType = typeof(global::Luny.UnityEngine.LuaColor);
            if (_arg0.TryRead<global::Luny.UnityEngine.LuaColor>(out var _p0_UnityEngine_Color))
            {
                var _arg1 = _lastArg = _argCount > 1 ? _context.GetArgument(1) : global::Lua.LuaValue.Nil;
                _lastArgPos = 1; _expectedType = typeof(global::UnityEngine.MaterialGlobalIlluminationFlags);
                if (_arg1.TryRead<global::UnityEngine.MaterialGlobalIlluminationFlags>(out var _p1_UnityEngine_MaterialGlobalIlluminationFlags))
                {
                    if (_argCount == 2)
                    {
                        var col = _p0_UnityEngine_Color.Value;
                        var flags = _p1_UnityEngine_MaterialGlobalIlluminationFlags;
                        var _ret0 = global::UnityEditor.MaterialEditor.FixupEmissiveFlag(col, flags);
                        var _lret0 = new global::Lua.LuaValue((global::System.Int64)_ret0);
                        var _retCount = _context.Return(_lret0);
                        return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                    }
                }
            }
            throw new global::Lua.LuaRuntimeException(_context.Thread, $"{"FixupEmissiveFlag"}: invalid argument #{_lastArgPos}: {_lastArg} ({_lastArg.Type}), expected: {_expectedType.FullName}", 2);
        });
        private static readonly global::Lua.LuaFunction _LuaMaterialEditor_GetDefaultPropertyHeight = new global::Lua.LuaFunction("GetDefaultPropertyHeight", (_context, _) =>
        {
            global::Lua.LuaValue _lastArg = default;
            global::System.Int32 _lastArgPos = default;
            global::System.Type _expectedType = default;
            var _argCount = _context.ArgumentCount;
            var _arg0 = _lastArg = _argCount > 0 ? _context.GetArgument(0) : global::Lua.LuaValue.Nil;
            _lastArgPos = 0; _expectedType = typeof(global::Luny.UnityEditor.LuaMaterialProperty);
            if (_arg0.TryRead<global::Luny.UnityEditor.LuaMaterialProperty>(out var _p0_UnityEditor_MaterialProperty))
            {
                if (_argCount == 1)
                {
                    var prop = _p0_UnityEditor_MaterialProperty.Instance;
                    var _ret0 = global::UnityEditor.MaterialEditor.GetDefaultPropertyHeight(prop);
                    var _lret0 = new global::Lua.LuaValue(_ret0);
                    var _retCount = _context.Return(_lret0);
                    return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                }
            }
            throw new global::Lua.LuaRuntimeException(_context.Thread, $"{"GetDefaultPropertyHeight"}: invalid argument #{_lastArgPos}: {_lastArg} ({_lastArg.Type}), expected: {_expectedType.FullName}", 2);
        });
        private static readonly global::Lua.LuaFunction _LuaMaterialEditor_GetFlexibleRectBetweenFieldAndRightEdge = new global::Lua.LuaFunction("GetFlexibleRectBetweenFieldAndRightEdge", (_context, _) =>
        {
            global::Lua.LuaValue _lastArg = default;
            global::System.Int32 _lastArgPos = default;
            global::System.Type _expectedType = default;
            var _argCount = _context.ArgumentCount;
            var _arg0 = _lastArg = _argCount > 0 ? _context.GetArgument(0) : global::Lua.LuaValue.Nil;
            _lastArgPos = 0; _expectedType = typeof(global::Luny.UnityEngine.LuaRect);
            if (_arg0.TryRead<global::Luny.UnityEngine.LuaRect>(out var _p0_UnityEngine_Rect))
            {
                if (_argCount == 1)
                {
                    var r = _p0_UnityEngine_Rect.Value;
                    var _ret0 = global::UnityEditor.MaterialEditor.GetFlexibleRectBetweenFieldAndRightEdge(r);
                    var _lret0 = global::Luny.UnityEngine.LuaRect.Bind(_ret0);
                    var _retCount = _context.Return(_lret0);
                    return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                }
            }
            throw new global::Lua.LuaRuntimeException(_context.Thread, $"{"GetFlexibleRectBetweenFieldAndRightEdge"}: invalid argument #{_lastArgPos}: {_lastArg} ({_lastArg.Type}), expected: {_expectedType.FullName}", 2);
        });
        private static readonly global::Lua.LuaFunction _LuaMaterialEditor_GetFlexibleRectBetweenLabelAndField = new global::Lua.LuaFunction("GetFlexibleRectBetweenLabelAndField", (_context, _) =>
        {
            global::Lua.LuaValue _lastArg = default;
            global::System.Int32 _lastArgPos = default;
            global::System.Type _expectedType = default;
            var _argCount = _context.ArgumentCount;
            var _arg0 = _lastArg = _argCount > 0 ? _context.GetArgument(0) : global::Lua.LuaValue.Nil;
            _lastArgPos = 0; _expectedType = typeof(global::Luny.UnityEngine.LuaRect);
            if (_arg0.TryRead<global::Luny.UnityEngine.LuaRect>(out var _p0_UnityEngine_Rect))
            {
                if (_argCount == 1)
                {
                    var r = _p0_UnityEngine_Rect.Value;
                    var _ret0 = global::UnityEditor.MaterialEditor.GetFlexibleRectBetweenLabelAndField(r);
                    var _lret0 = global::Luny.UnityEngine.LuaRect.Bind(_ret0);
                    var _retCount = _context.Return(_lret0);
                    return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                }
            }
            throw new global::Lua.LuaRuntimeException(_context.Thread, $"{"GetFlexibleRectBetweenLabelAndField"}: invalid argument #{_lastArgPos}: {_lastArg} ({_lastArg.Type}), expected: {_expectedType.FullName}", 2);
        });
        private static readonly global::Lua.LuaFunction _LuaMaterialEditor_GetLeftAlignedFieldRect = new global::Lua.LuaFunction("GetLeftAlignedFieldRect", (_context, _) =>
        {
            global::Lua.LuaValue _lastArg = default;
            global::System.Int32 _lastArgPos = default;
            global::System.Type _expectedType = default;
            var _argCount = _context.ArgumentCount;
            var _arg0 = _lastArg = _argCount > 0 ? _context.GetArgument(0) : global::Lua.LuaValue.Nil;
            _lastArgPos = 0; _expectedType = typeof(global::Luny.UnityEngine.LuaRect);
            if (_arg0.TryRead<global::Luny.UnityEngine.LuaRect>(out var _p0_UnityEngine_Rect))
            {
                if (_argCount == 1)
                {
                    var r = _p0_UnityEngine_Rect.Value;
                    var _ret0 = global::UnityEditor.MaterialEditor.GetLeftAlignedFieldRect(r);
                    var _lret0 = global::Luny.UnityEngine.LuaRect.Bind(_ret0);
                    var _retCount = _context.Return(_lret0);
                    return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                }
            }
            throw new global::Lua.LuaRuntimeException(_context.Thread, $"{"GetLeftAlignedFieldRect"}: invalid argument #{_lastArgPos}: {_lastArg} ({_lastArg.Type}), expected: {_expectedType.FullName}", 2);
        });
        private static readonly global::Lua.LuaFunction _LuaMaterialEditor_GetMaterialProperties = new global::Lua.LuaFunction("GetMaterialProperties", (_context, _) =>
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
                    var mats = _p0_UnityEngine_ObjectArray;
                    var _ret0 = global::UnityEditor.MaterialEditor.GetMaterialProperties(mats);
                    var _factory = _context.GetObjectFactory();
                    var _lret0 = _factory.Bind(_ret0);
                    var _retCount = _context.Return(_lret0);
                    return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                }
            }
            throw new global::Lua.LuaRuntimeException(_context.Thread, $"{"GetMaterialProperties"}: invalid argument #{_lastArgPos}: {_lastArg} ({_lastArg.Type}), expected: {_expectedType.FullName}", 2);
        });
        private static readonly global::Lua.LuaFunction _LuaMaterialEditor_GetMaterialProperty = new global::Lua.LuaFunction("GetMaterialProperty", (_context, _) =>
        {
            global::Lua.LuaValue _lastArg = default;
            global::System.Int32 _lastArgPos = default;
            global::System.Type _expectedType = default;
            var _argCount = _context.ArgumentCount;
            var _arg0 = _lastArg = _argCount > 0 ? _context.GetArgument(0) : global::Lua.LuaValue.Nil;
            _lastArgPos = 0; _expectedType = typeof(global::UnityEngine.Object[]);
            if (_arg0.TryReadArray<global::UnityEngine.Object>(out var _p0_UnityEngine_ObjectArray))
            {
                var _arg1 = _lastArg = _argCount > 1 ? _context.GetArgument(1) : global::Lua.LuaValue.Nil;
                _lastArgPos = 1; _expectedType = typeof(global::System.Int32);
                if (_arg1.TryRead<global::System.Int32>(out var _p1_System_Int32))
                {
                    if (_argCount == 2)
                    {
                        var mats = _p0_UnityEngine_ObjectArray;
                        var propertyIndex = _p1_System_Int32;
                        var _ret0 = global::UnityEditor.MaterialEditor.GetMaterialProperty(mats, propertyIndex);
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
                        var mats = _p0_UnityEngine_ObjectArray;
                        var name = _p1_System_String;
                        var _ret0 = global::UnityEditor.MaterialEditor.GetMaterialProperty(mats, name);
                        var _factory = _context.GetObjectFactory();
                        var _lret0 = _factory.Bind(_ret0);
                        var _retCount = _context.Return(_lret0);
                        return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                    }
                }
            }
            throw new global::Lua.LuaRuntimeException(_context.Thread, $"{"GetMaterialProperty"}: invalid argument #{_lastArgPos}: {_lastArg} ({_lastArg.Type}), expected: {_expectedType.FullName}", 2);
        });
        private static readonly global::Lua.LuaFunction _LuaMaterialEditor_GetMaterialPropertyNames = new global::Lua.LuaFunction("GetMaterialPropertyNames", (_context, _) =>
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
                    var mats = _p0_UnityEngine_ObjectArray;
                    var _ret0 = global::UnityEditor.MaterialEditor.GetMaterialPropertyNames(mats);
                    var _factory = _context.GetObjectFactory();
                    var _lret0 = _factory.Bind(_ret0);
                    var _retCount = _context.Return(_lret0);
                    return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                }
            }
            throw new global::Lua.LuaRuntimeException(_context.Thread, $"{"GetMaterialPropertyNames"}: invalid argument #{_lastArgPos}: {_lastArg} ({_lastArg.Type}), expected: {_expectedType.FullName}", 2);
        });
        private static readonly global::Lua.LuaFunction _LuaMaterialEditor_GetRectAfterLabelWidth = new global::Lua.LuaFunction("GetRectAfterLabelWidth", (_context, _) =>
        {
            global::Lua.LuaValue _lastArg = default;
            global::System.Int32 _lastArgPos = default;
            global::System.Type _expectedType = default;
            var _argCount = _context.ArgumentCount;
            var _arg0 = _lastArg = _argCount > 0 ? _context.GetArgument(0) : global::Lua.LuaValue.Nil;
            _lastArgPos = 0; _expectedType = typeof(global::Luny.UnityEngine.LuaRect);
            if (_arg0.TryRead<global::Luny.UnityEngine.LuaRect>(out var _p0_UnityEngine_Rect))
            {
                if (_argCount == 1)
                {
                    var r = _p0_UnityEngine_Rect.Value;
                    var _ret0 = global::UnityEditor.MaterialEditor.GetRectAfterLabelWidth(r);
                    var _lret0 = global::Luny.UnityEngine.LuaRect.Bind(_ret0);
                    var _retCount = _context.Return(_lret0);
                    return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                }
            }
            throw new global::Lua.LuaRuntimeException(_context.Thread, $"{"GetRectAfterLabelWidth"}: invalid argument #{_lastArgPos}: {_lastArg} ({_lastArg.Type}), expected: {_expectedType.FullName}", 2);
        });
        private static readonly global::Lua.LuaFunction _LuaMaterialEditor_GetRightAlignedFieldRect = new global::Lua.LuaFunction("GetRightAlignedFieldRect", (_context, _) =>
        {
            global::Lua.LuaValue _lastArg = default;
            global::System.Int32 _lastArgPos = default;
            global::System.Type _expectedType = default;
            var _argCount = _context.ArgumentCount;
            var _arg0 = _lastArg = _argCount > 0 ? _context.GetArgument(0) : global::Lua.LuaValue.Nil;
            _lastArgPos = 0; _expectedType = typeof(global::Luny.UnityEngine.LuaRect);
            if (_arg0.TryRead<global::Luny.UnityEngine.LuaRect>(out var _p0_UnityEngine_Rect))
            {
                if (_argCount == 1)
                {
                    var r = _p0_UnityEngine_Rect.Value;
                    var _ret0 = global::UnityEditor.MaterialEditor.GetRightAlignedFieldRect(r);
                    var _lret0 = global::Luny.UnityEngine.LuaRect.Bind(_ret0);
                    var _retCount = _context.Return(_lret0);
                    return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                }
            }
            throw new global::Lua.LuaRuntimeException(_context.Thread, $"{"GetRightAlignedFieldRect"}: invalid argument #{_lastArgPos}: {_lastArg} ({_lastArg.Type}), expected: {_expectedType.FullName}", 2);
        });
        private static readonly global::Lua.LuaFunction _LuaMaterialEditor_PrepareMaterialPropertiesForAnimationMode = new global::Lua.LuaFunction("PrepareMaterialPropertiesForAnimationMode", (_context, _) =>
        {
            global::Lua.LuaValue _lastArg = default;
            global::System.Int32 _lastArgPos = default;
            global::System.Type _expectedType = default;
            var _argCount = _context.ArgumentCount;
            var _arg0 = _lastArg = _argCount > 0 ? _context.GetArgument(0) : global::Lua.LuaValue.Nil;
            _lastArgPos = 0; _expectedType = typeof(global::UnityEditor.MaterialProperty[]);
            if (_arg0.TryReadArray<global::UnityEditor.MaterialProperty>(out var _p0_UnityEditor_MaterialPropertyArray))
            {
                var _arg1 = _lastArg = _argCount > 1 ? _context.GetArgument(1) : global::Lua.LuaValue.Nil;
                _lastArgPos = 1; _expectedType = typeof(global::System.Boolean);
                if (_arg1.TryRead<global::System.Boolean>(out var _p1_System_Boolean))
                {
                    if (_argCount == 2)
                    {
                        var properties = _p0_UnityEditor_MaterialPropertyArray;
                        var isMaterialEditable = _p1_System_Boolean;
                        var _ret0 = global::UnityEditor.MaterialEditor.PrepareMaterialPropertiesForAnimationMode(properties, isMaterialEditable);
                        var _factory = _context.GetObjectFactory();
                        var _lret0 = _factory.Bind(_ret0);
                        var _retCount = _context.Return(_lret0);
                        return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                    }
                }
            }
            throw new global::Lua.LuaRuntimeException(_context.Thread, $"{"PrepareMaterialPropertiesForAnimationMode"}: invalid argument #{_lastArgPos}: {_lastArg} ({_lastArg.Type}), expected: {_expectedType.FullName}", 2);
        });
        private static readonly global::Lua.LuaFunction _LuaMaterialEditor_TextureScaleOffsetProperty = new global::Lua.LuaFunction("TextureScaleOffsetProperty", (_context, _) =>
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
                _lastArgPos = 1; _expectedType = typeof(global::Luny.UnityEngine.LuaVector4);
                if (_arg1.TryRead<global::Luny.UnityEngine.LuaVector4>(out var _p1_UnityEngine_Vector4))
                {
                    if (_argCount == 2)
                    {
                        var position = _p0_UnityEngine_Rect.Value;
                        var scaleOffset = _p1_UnityEngine_Vector4.Value;
                        var _ret0 = global::UnityEditor.MaterialEditor.TextureScaleOffsetProperty(position, scaleOffset);
                        var _lret0 = global::Luny.UnityEngine.LuaVector4.Bind(_ret0);
                        var _retCount = _context.Return(_lret0);
                        return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                    }
                    var _arg2 = _lastArg = _argCount > 2 ? _context.GetArgument(2) : global::Lua.LuaValue.Nil;
                    _lastArgPos = 2; _expectedType = typeof(global::System.Boolean);
                    if (_arg2.TryRead<global::System.Boolean>(out var _p2_System_Boolean))
                    {
                        if (_argCount == 3)
                        {
                            var position = _p0_UnityEngine_Rect.Value;
                            var scaleOffset = _p1_UnityEngine_Vector4.Value;
                            var partOfTexturePropertyControl = _p2_System_Boolean;
                            var _ret0 = global::UnityEditor.MaterialEditor.TextureScaleOffsetProperty(position, scaleOffset, partOfTexturePropertyControl);
                            var _lret0 = global::Luny.UnityEngine.LuaVector4.Bind(_ret0);
                            var _retCount = _context.Return(_lret0);
                            return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                        }
                    }
                }
            }
            throw new global::Lua.LuaRuntimeException(_context.Thread, $"{"TextureScaleOffsetProperty"}: invalid argument #{_lastArgPos}: {_lastArg} ({_lastArg.Type}), expected: {_expectedType.FullName}", 2);
        });
        private static readonly global::Lua.LuaFunction __index = new(global::Lua.Runtime.Metamethods.Index, (_context, _) =>
        {
            var _this = _context.GetArgument<LuaMaterialEditorType>(0);
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
            var _this = _context.GetArgument<LuaMaterialEditorType>(0);
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
                case "ApplyMaterialPropertyDrawers": _value = _LuaMaterialEditor_ApplyMaterialPropertyDrawers; return true;
                case "BeginProperty": _value = _LuaMaterialEditor_BeginProperty; return true;
                case "EndProperty": _value = _LuaMaterialEditor_EndProperty; return true;
                case "FixupEmissiveFlag": _value = _LuaMaterialEditor_FixupEmissiveFlag; return true;
                case "GetDefaultPropertyHeight": _value = _LuaMaterialEditor_GetDefaultPropertyHeight; return true;
                case "GetFlexibleRectBetweenFieldAndRightEdge": _value = _LuaMaterialEditor_GetFlexibleRectBetweenFieldAndRightEdge; return true;
                case "GetFlexibleRectBetweenLabelAndField": _value = _LuaMaterialEditor_GetFlexibleRectBetweenLabelAndField; return true;
                case "GetLeftAlignedFieldRect": _value = _LuaMaterialEditor_GetLeftAlignedFieldRect; return true;
                case "GetMaterialProperties": _value = _LuaMaterialEditor_GetMaterialProperties; return true;
                case "GetMaterialProperty": _value = _LuaMaterialEditor_GetMaterialProperty; return true;
                case "GetMaterialPropertyNames": _value = _LuaMaterialEditor_GetMaterialPropertyNames; return true;
                case "GetRectAfterLabelWidth": _value = _LuaMaterialEditor_GetRectAfterLabelWidth; return true;
                case "GetRightAlignedFieldRect": _value = _LuaMaterialEditor_GetRightAlignedFieldRect; return true;
                case "PrepareMaterialPropertiesForAnimationMode": _value = _LuaMaterialEditor_PrepareMaterialPropertiesForAnimationMode; return true;
                case "TextureScaleOffsetProperty": _value = _LuaMaterialEditor_TextureScaleOffsetProperty; return true;
                case "kMiniTextureFieldLabelIndentLevel": _value = new global::Lua.LuaValue(global::UnityEditor.MaterialEditor.kMiniTextureFieldLabelIndentLevel); return true;
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
