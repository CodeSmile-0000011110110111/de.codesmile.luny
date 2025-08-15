
// --------------------------------------------------------------
// GENERATED FILE ----> DO NOT EDIT <---- CHANGES WILL BE LOST !!
// --------------------------------------------------------------

#if UNITY_6000_0_OR_NEWER && !(UNITY_6000_1_OR_NEWER)
#pragma warning disable 0109, 0162, 0168, 0219
using Luny;

namespace LunyEditor.UnityEditor
{
    public sealed class LuaLightEditorSettings : global::Luny.ILuaObject<global::UnityEditor.LightEditor.Settings>
    {
        public new static global::Lua.LuaValue Bind(global::UnityEditor.LightEditor.Settings instance) => new LuaLightEditorSettings(instance);
        public new static global::Lua.LuaValue Bind(global::System.Object instance) => Bind((global::UnityEditor.LightEditor.Settings)instance);
        public new static global::Lua.LuaValue Bind(global::System.Collections.Generic.IList<global::UnityEditor.LightEditor.Settings> instances) =>
            new global::Luny.LuaList<global::UnityEditor.LightEditor.Settings>(instances);
        public new static global::Lua.LuaValue Bind(global::System.Collections.Generic.IList<global::System.Object> instances) =>
            new global::Luny.LuaList<global::UnityEditor.LightEditor.Settings>(instances);
        private LuaLightEditorSettings(global::UnityEditor.LightEditor.Settings instance) => m_Instance = instance;
        public static implicit operator global::Lua.LuaValue(LuaLightEditorSettings value) => new(value);
        private global::UnityEditor.LightEditor.Settings m_Instance;
        public global::UnityEditor.LightEditor.Settings Instance => m_Instance;
        public new global::System.Type BindType => typeof(global::UnityEditor.LightEditor.Settings);
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

        private static readonly global::Lua.LuaFunction _LuaLightEditorSettings_ApplyModifiedProperties = new global::Lua.LuaFunction("ApplyModifiedProperties", (_context, _) =>
        {
            global::Lua.LuaValue _lastArg = default;
            global::System.Int32 _lastArgPos = default;
            global::System.Type _expectedType = default;
            var _argCount = _context.ArgumentCount;
            var _this = _context.GetArgument<LuaLightEditorSettings>(0);
            if (_argCount == 1)
            {
                _this.Instance.ApplyModifiedProperties();
                var _retCount = _context.Return();
                return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
            }
            throw new global::Lua.LuaRuntimeException(_context.Thread, $"{"ApplyModifiedProperties"}: invalid argument #{_lastArgPos}: {_lastArg} ({_lastArg.Type}), expected: {_expectedType.FullName}", 2);
        });
        private static readonly global::Lua.LuaFunction _LuaLightEditorSettings_DrawArea = new global::Lua.LuaFunction("DrawArea", (_context, _) =>
        {
            global::Lua.LuaValue _lastArg = default;
            global::System.Int32 _lastArgPos = default;
            global::System.Type _expectedType = default;
            var _argCount = _context.ArgumentCount;
            var _this = _context.GetArgument<LuaLightEditorSettings>(0);
            if (_argCount == 1)
            {
                _this.Instance.DrawArea();
                var _retCount = _context.Return();
                return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
            }
            throw new global::Lua.LuaRuntimeException(_context.Thread, $"{"DrawArea"}: invalid argument #{_lastArgPos}: {_lastArg} ({_lastArg.Type}), expected: {_expectedType.FullName}", 2);
        });
        private static readonly global::Lua.LuaFunction _LuaLightEditorSettings_DrawBakedShadowAngle = new global::Lua.LuaFunction("DrawBakedShadowAngle", (_context, _) =>
        {
            global::Lua.LuaValue _lastArg = default;
            global::System.Int32 _lastArgPos = default;
            global::System.Type _expectedType = default;
            var _argCount = _context.ArgumentCount;
            var _this = _context.GetArgument<LuaLightEditorSettings>(0);
            if (_argCount == 1)
            {
                _this.Instance.DrawBakedShadowAngle();
                var _retCount = _context.Return();
                return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
            }
            throw new global::Lua.LuaRuntimeException(_context.Thread, $"{"DrawBakedShadowAngle"}: invalid argument #{_lastArgPos}: {_lastArg} ({_lastArg.Type}), expected: {_expectedType.FullName}", 2);
        });
        private static readonly global::Lua.LuaFunction _LuaLightEditorSettings_DrawBakedShadowRadius = new global::Lua.LuaFunction("DrawBakedShadowRadius", (_context, _) =>
        {
            global::Lua.LuaValue _lastArg = default;
            global::System.Int32 _lastArgPos = default;
            global::System.Type _expectedType = default;
            var _argCount = _context.ArgumentCount;
            var _this = _context.GetArgument<LuaLightEditorSettings>(0);
            if (_argCount == 1)
            {
                _this.Instance.DrawBakedShadowRadius();
                var _retCount = _context.Return();
                return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
            }
            throw new global::Lua.LuaRuntimeException(_context.Thread, $"{"DrawBakedShadowRadius"}: invalid argument #{_lastArgPos}: {_lastArg} ({_lastArg.Type}), expected: {_expectedType.FullName}", 2);
        });
        private static readonly global::Lua.LuaFunction _LuaLightEditorSettings_DrawBounceIntensity = new global::Lua.LuaFunction("DrawBounceIntensity", (_context, _) =>
        {
            global::Lua.LuaValue _lastArg = default;
            global::System.Int32 _lastArgPos = default;
            global::System.Type _expectedType = default;
            var _argCount = _context.ArgumentCount;
            var _this = _context.GetArgument<LuaLightEditorSettings>(0);
            if (_argCount == 1)
            {
                _this.Instance.DrawBounceIntensity();
                var _retCount = _context.Return();
                return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
            }
            throw new global::Lua.LuaRuntimeException(_context.Thread, $"{"DrawBounceIntensity"}: invalid argument #{_lastArgPos}: {_lastArg} ({_lastArg.Type}), expected: {_expectedType.FullName}", 2);
        });
        private static readonly global::Lua.LuaFunction _LuaLightEditorSettings_DrawColor = new global::Lua.LuaFunction("DrawColor", (_context, _) =>
        {
            global::Lua.LuaValue _lastArg = default;
            global::System.Int32 _lastArgPos = default;
            global::System.Type _expectedType = default;
            var _argCount = _context.ArgumentCount;
            var _this = _context.GetArgument<LuaLightEditorSettings>(0);
            if (_argCount == 1)
            {
                _this.Instance.DrawColor();
                var _retCount = _context.Return();
                return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
            }
            throw new global::Lua.LuaRuntimeException(_context.Thread, $"{"DrawColor"}: invalid argument #{_lastArgPos}: {_lastArg} ({_lastArg.Type}), expected: {_expectedType.FullName}", 2);
        });
        private static readonly global::Lua.LuaFunction _LuaLightEditorSettings_DrawCookie = new global::Lua.LuaFunction("DrawCookie", (_context, _) =>
        {
            global::Lua.LuaValue _lastArg = default;
            global::System.Int32 _lastArgPos = default;
            global::System.Type _expectedType = default;
            var _argCount = _context.ArgumentCount;
            var _this = _context.GetArgument<LuaLightEditorSettings>(0);
            if (_argCount == 1)
            {
                _this.Instance.DrawCookie();
                var _retCount = _context.Return();
                return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
            }
            throw new global::Lua.LuaRuntimeException(_context.Thread, $"{"DrawCookie"}: invalid argument #{_lastArgPos}: {_lastArg} ({_lastArg.Type}), expected: {_expectedType.FullName}", 2);
        });
        private static readonly global::Lua.LuaFunction _LuaLightEditorSettings_DrawCookieProperty = new global::Lua.LuaFunction("DrawCookieProperty", (_context, _) =>
        {
            global::Lua.LuaValue _lastArg = default;
            global::System.Int32 _lastArgPos = default;
            global::System.Type _expectedType = default;
            var _argCount = _context.ArgumentCount;
            var _this = _context.GetArgument<LuaLightEditorSettings>(0);
            var _arg0 = _lastArg = _argCount > 1 ? _context.GetArgument(1) : global::Lua.LuaValue.Nil;
            _lastArgPos = 0; _expectedType = typeof(global::LunyEditor.UnityEditor.LuaSerializedProperty);
            if (_arg0.TryRead<global::LunyEditor.UnityEditor.LuaSerializedProperty>(out var _p0_UnityEditor_SerializedProperty))
            {
                var _arg1 = _lastArg = _argCount > 2 ? _context.GetArgument(2) : global::Lua.LuaValue.Nil;
                _lastArgPos = 1; _expectedType = typeof(global::UnityEngine.GUIContent);
                if (_arg1.TryRead<global::UnityEngine.GUIContent>(out var _p1_UnityEngine_GUIContent))
                {
                    var _arg2 = _lastArg = _argCount > 3 ? _context.GetArgument(3) : global::Lua.LuaValue.Nil;
                    _lastArgPos = 2; _expectedType = typeof(global::UnityEngine.LightType);
                    if (_arg2.TryRead<global::UnityEngine.LightType>(out var _p2_UnityEngine_LightType))
                    {
                        if (_argCount == 4)
                        {
                            var cookieProperty = _p0_UnityEditor_SerializedProperty.Instance;
                            var content = _p1_UnityEngine_GUIContent;
                            var cookieLightType = _p2_UnityEngine_LightType;
                            _this.Instance.DrawCookieProperty(cookieProperty, content, cookieLightType);
                            var _retCount = _context.Return();
                            return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                        }
                    }
                }
            }
            throw new global::Lua.LuaRuntimeException(_context.Thread, $"{"DrawCookieProperty"}: invalid argument #{_lastArgPos}: {_lastArg} ({_lastArg.Type}), expected: {_expectedType.FullName}", 2);
        });
        private static readonly global::Lua.LuaFunction _LuaLightEditorSettings_DrawCookieSize = new global::Lua.LuaFunction("DrawCookieSize", (_context, _) =>
        {
            global::Lua.LuaValue _lastArg = default;
            global::System.Int32 _lastArgPos = default;
            global::System.Type _expectedType = default;
            var _argCount = _context.ArgumentCount;
            var _this = _context.GetArgument<LuaLightEditorSettings>(0);
            if (_argCount == 1)
            {
                _this.Instance.DrawCookieSize();
                var _retCount = _context.Return();
                return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
            }
            throw new global::Lua.LuaRuntimeException(_context.Thread, $"{"DrawCookieSize"}: invalid argument #{_lastArgPos}: {_lastArg} ({_lastArg.Type}), expected: {_expectedType.FullName}", 2);
        });
        private static readonly global::Lua.LuaFunction _LuaLightEditorSettings_DrawCullingMask = new global::Lua.LuaFunction("DrawCullingMask", (_context, _) =>
        {
            global::Lua.LuaValue _lastArg = default;
            global::System.Int32 _lastArgPos = default;
            global::System.Type _expectedType = default;
            var _argCount = _context.ArgumentCount;
            var _this = _context.GetArgument<LuaLightEditorSettings>(0);
            if (_argCount == 1)
            {
                _this.Instance.DrawCullingMask();
                var _retCount = _context.Return();
                return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
            }
            throw new global::Lua.LuaRuntimeException(_context.Thread, $"{"DrawCullingMask"}: invalid argument #{_lastArgPos}: {_lastArg} ({_lastArg.Type}), expected: {_expectedType.FullName}", 2);
        });
        private static readonly global::Lua.LuaFunction _LuaLightEditorSettings_DrawFlare = new global::Lua.LuaFunction("DrawFlare", (_context, _) =>
        {
            global::Lua.LuaValue _lastArg = default;
            global::System.Int32 _lastArgPos = default;
            global::System.Type _expectedType = default;
            var _argCount = _context.ArgumentCount;
            var _this = _context.GetArgument<LuaLightEditorSettings>(0);
            if (_argCount == 1)
            {
                _this.Instance.DrawFlare();
                var _retCount = _context.Return();
                return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
            }
            throw new global::Lua.LuaRuntimeException(_context.Thread, $"{"DrawFlare"}: invalid argument #{_lastArgPos}: {_lastArg} ({_lastArg.Type}), expected: {_expectedType.FullName}", 2);
        });
        private static readonly global::Lua.LuaFunction _LuaLightEditorSettings_DrawHalo = new global::Lua.LuaFunction("DrawHalo", (_context, _) =>
        {
            global::Lua.LuaValue _lastArg = default;
            global::System.Int32 _lastArgPos = default;
            global::System.Type _expectedType = default;
            var _argCount = _context.ArgumentCount;
            var _this = _context.GetArgument<LuaLightEditorSettings>(0);
            if (_argCount == 1)
            {
                _this.Instance.DrawHalo();
                var _retCount = _context.Return();
                return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
            }
            throw new global::Lua.LuaRuntimeException(_context.Thread, $"{"DrawHalo"}: invalid argument #{_lastArgPos}: {_lastArg} ({_lastArg.Type}), expected: {_expectedType.FullName}", 2);
        });
        private static readonly global::Lua.LuaFunction _LuaLightEditorSettings_DrawInnerAndOuterSpotAngle = new global::Lua.LuaFunction("DrawInnerAndOuterSpotAngle", (_context, _) =>
        {
            global::Lua.LuaValue _lastArg = default;
            global::System.Int32 _lastArgPos = default;
            global::System.Type _expectedType = default;
            var _argCount = _context.ArgumentCount;
            var _this = _context.GetArgument<LuaLightEditorSettings>(0);
            if (_argCount == 1)
            {
                _this.Instance.DrawInnerAndOuterSpotAngle();
                var _retCount = _context.Return();
                return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
            }
            throw new global::Lua.LuaRuntimeException(_context.Thread, $"{"DrawInnerAndOuterSpotAngle"}: invalid argument #{_lastArgPos}: {_lastArg} ({_lastArg.Type}), expected: {_expectedType.FullName}", 2);
        });
        private static readonly global::Lua.LuaFunction _LuaLightEditorSettings_DrawIntensity = new global::Lua.LuaFunction("DrawIntensity", (_context, _) =>
        {
            global::Lua.LuaValue _lastArg = default;
            global::System.Int32 _lastArgPos = default;
            global::System.Type _expectedType = default;
            var _argCount = _context.ArgumentCount;
            var _this = _context.GetArgument<LuaLightEditorSettings>(0);
            if (_argCount == 1)
            {
                _this.Instance.DrawIntensity();
                var _retCount = _context.Return();
                return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
            }
            throw new global::Lua.LuaRuntimeException(_context.Thread, $"{"DrawIntensity"}: invalid argument #{_lastArgPos}: {_lastArg} ({_lastArg.Type}), expected: {_expectedType.FullName}", 2);
        });
        private static readonly global::Lua.LuaFunction _LuaLightEditorSettings_DrawLightmapping = new global::Lua.LuaFunction("DrawLightmapping", (_context, _) =>
        {
            global::Lua.LuaValue _lastArg = default;
            global::System.Int32 _lastArgPos = default;
            global::System.Type _expectedType = default;
            var _argCount = _context.ArgumentCount;
            var _this = _context.GetArgument<LuaLightEditorSettings>(0);
            if (_argCount == 1)
            {
                _this.Instance.DrawLightmapping();
                var _retCount = _context.Return();
                return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
            }
            throw new global::Lua.LuaRuntimeException(_context.Thread, $"{"DrawLightmapping"}: invalid argument #{_lastArgPos}: {_lastArg} ({_lastArg.Type}), expected: {_expectedType.FullName}", 2);
        });
        private static readonly global::Lua.LuaFunction _LuaLightEditorSettings_DrawLightType = new global::Lua.LuaFunction("DrawLightType", (_context, _) =>
        {
            global::Lua.LuaValue _lastArg = default;
            global::System.Int32 _lastArgPos = default;
            global::System.Type _expectedType = default;
            var _argCount = _context.ArgumentCount;
            var _this = _context.GetArgument<LuaLightEditorSettings>(0);
            if (_argCount == 1)
            {
                _this.Instance.DrawLightType();
                var _retCount = _context.Return();
                return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
            }
            throw new global::Lua.LuaRuntimeException(_context.Thread, $"{"DrawLightType"}: invalid argument #{_lastArgPos}: {_lastArg} ({_lastArg.Type}), expected: {_expectedType.FullName}", 2);
        });
        private static readonly global::Lua.LuaFunction _LuaLightEditorSettings_DrawRange = new global::Lua.LuaFunction("DrawRange", (_context, _) =>
        {
            global::Lua.LuaValue _lastArg = default;
            global::System.Int32 _lastArgPos = default;
            global::System.Type _expectedType = default;
            var _argCount = _context.ArgumentCount;
            var _this = _context.GetArgument<LuaLightEditorSettings>(0);
            if (_argCount == 1)
            {
                _this.Instance.DrawRange();
                var _retCount = _context.Return();
                return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
            }
            throw new global::Lua.LuaRuntimeException(_context.Thread, $"{"DrawRange"}: invalid argument #{_lastArgPos}: {_lastArg} ({_lastArg.Type}), expected: {_expectedType.FullName}", 2);
        });
        private static readonly global::Lua.LuaFunction _LuaLightEditorSettings_DrawRenderingLayerMask = new global::Lua.LuaFunction("DrawRenderingLayerMask", (_context, _) =>
        {
            global::Lua.LuaValue _lastArg = default;
            global::System.Int32 _lastArgPos = default;
            global::System.Type _expectedType = default;
            var _argCount = _context.ArgumentCount;
            var _this = _context.GetArgument<LuaLightEditorSettings>(0);
            if (_argCount == 1)
            {
                _this.Instance.DrawRenderingLayerMask();
                var _retCount = _context.Return();
                return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
            }
            throw new global::Lua.LuaRuntimeException(_context.Thread, $"{"DrawRenderingLayerMask"}: invalid argument #{_lastArgPos}: {_lastArg} ({_lastArg.Type}), expected: {_expectedType.FullName}", 2);
        });
        private static readonly global::Lua.LuaFunction _LuaLightEditorSettings_DrawRenderMode = new global::Lua.LuaFunction("DrawRenderMode", (_context, _) =>
        {
            global::Lua.LuaValue _lastArg = default;
            global::System.Int32 _lastArgPos = default;
            global::System.Type _expectedType = default;
            var _argCount = _context.ArgumentCount;
            var _this = _context.GetArgument<LuaLightEditorSettings>(0);
            if (_argCount == 1)
            {
                _this.Instance.DrawRenderMode();
                var _retCount = _context.Return();
                return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
            }
            throw new global::Lua.LuaRuntimeException(_context.Thread, $"{"DrawRenderMode"}: invalid argument #{_lastArgPos}: {_lastArg} ({_lastArg.Type}), expected: {_expectedType.FullName}", 2);
        });
        private static readonly global::Lua.LuaFunction _LuaLightEditorSettings_DrawRuntimeShadow = new global::Lua.LuaFunction("DrawRuntimeShadow", (_context, _) =>
        {
            global::Lua.LuaValue _lastArg = default;
            global::System.Int32 _lastArgPos = default;
            global::System.Type _expectedType = default;
            var _argCount = _context.ArgumentCount;
            var _this = _context.GetArgument<LuaLightEditorSettings>(0);
            if (_argCount == 1)
            {
                _this.Instance.DrawRuntimeShadow();
                var _retCount = _context.Return();
                return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
            }
            throw new global::Lua.LuaRuntimeException(_context.Thread, $"{"DrawRuntimeShadow"}: invalid argument #{_lastArgPos}: {_lastArg} ({_lastArg.Type}), expected: {_expectedType.FullName}", 2);
        });
        private static readonly global::Lua.LuaFunction _LuaLightEditorSettings_DrawShadowsType = new global::Lua.LuaFunction("DrawShadowsType", (_context, _) =>
        {
            global::Lua.LuaValue _lastArg = default;
            global::System.Int32 _lastArgPos = default;
            global::System.Type _expectedType = default;
            var _argCount = _context.ArgumentCount;
            var _this = _context.GetArgument<LuaLightEditorSettings>(0);
            if (_argCount == 1)
            {
                _this.Instance.DrawShadowsType();
                var _retCount = _context.Return();
                return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
            }
            throw new global::Lua.LuaRuntimeException(_context.Thread, $"{"DrawShadowsType"}: invalid argument #{_lastArgPos}: {_lastArg} ({_lastArg.Type}), expected: {_expectedType.FullName}", 2);
        });
        private static readonly global::Lua.LuaFunction _LuaLightEditorSettings_DrawSpotAngle = new global::Lua.LuaFunction("DrawSpotAngle", (_context, _) =>
        {
            global::Lua.LuaValue _lastArg = default;
            global::System.Int32 _lastArgPos = default;
            global::System.Type _expectedType = default;
            var _argCount = _context.ArgumentCount;
            var _this = _context.GetArgument<LuaLightEditorSettings>(0);
            if (_argCount == 1)
            {
                _this.Instance.DrawSpotAngle();
                var _retCount = _context.Return();
                return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
            }
            throw new global::Lua.LuaRuntimeException(_context.Thread, $"{"DrawSpotAngle"}: invalid argument #{_lastArgPos}: {_lastArg} ({_lastArg.Type}), expected: {_expectedType.FullName}", 2);
        });
        private static readonly global::Lua.LuaFunction _LuaLightEditorSettings_OnDestroy = new global::Lua.LuaFunction("OnDestroy", (_context, _) =>
        {
            global::Lua.LuaValue _lastArg = default;
            global::System.Int32 _lastArgPos = default;
            global::System.Type _expectedType = default;
            var _argCount = _context.ArgumentCount;
            var _this = _context.GetArgument<LuaLightEditorSettings>(0);
            if (_argCount == 1)
            {
                _this.Instance.OnDestroy();
                var _retCount = _context.Return();
                return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
            }
            throw new global::Lua.LuaRuntimeException(_context.Thread, $"{"OnDestroy"}: invalid argument #{_lastArgPos}: {_lastArg} ({_lastArg.Type}), expected: {_expectedType.FullName}", 2);
        });
        private static readonly global::Lua.LuaFunction _LuaLightEditorSettings_OnEnable = new global::Lua.LuaFunction("OnEnable", (_context, _) =>
        {
            global::Lua.LuaValue _lastArg = default;
            global::System.Int32 _lastArgPos = default;
            global::System.Type _expectedType = default;
            var _argCount = _context.ArgumentCount;
            var _this = _context.GetArgument<LuaLightEditorSettings>(0);
            if (_argCount == 1)
            {
                _this.Instance.OnEnable();
                var _retCount = _context.Return();
                return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
            }
            throw new global::Lua.LuaRuntimeException(_context.Thread, $"{"OnEnable"}: invalid argument #{_lastArgPos}: {_lastArg} ({_lastArg.Type}), expected: {_expectedType.FullName}", 2);
        });
        private static readonly global::Lua.LuaFunction _LuaLightEditorSettings_Update = new global::Lua.LuaFunction("Update", (_context, _) =>
        {
            global::Lua.LuaValue _lastArg = default;
            global::System.Int32 _lastArgPos = default;
            global::System.Type _expectedType = default;
            var _argCount = _context.ArgumentCount;
            var _this = _context.GetArgument<LuaLightEditorSettings>(0);
            if (_argCount == 1)
            {
                _this.Instance.Update();
                var _retCount = _context.Return();
                return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
            }
            throw new global::Lua.LuaRuntimeException(_context.Thread, $"{"Update"}: invalid argument #{_lastArgPos}: {_lastArg} ({_lastArg.Type}), expected: {_expectedType.FullName}", 2);
        });
        private static readonly global::Lua.LuaFunction __index = new(global::Lua.Runtime.Metamethods.Index, (_context, _) =>
        {
            var _this = _context.GetArgument<LuaLightEditorSettings>(0);
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
            var _this = _context.GetArgument<LuaLightEditorSettings>(0);
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
                case "ApplyModifiedProperties": _value = _LuaLightEditorSettings_ApplyModifiedProperties; return true;
                case "DrawArea": _value = _LuaLightEditorSettings_DrawArea; return true;
                case "DrawBakedShadowAngle": _value = _LuaLightEditorSettings_DrawBakedShadowAngle; return true;
                case "DrawBakedShadowRadius": _value = _LuaLightEditorSettings_DrawBakedShadowRadius; return true;
                case "DrawBounceIntensity": _value = _LuaLightEditorSettings_DrawBounceIntensity; return true;
                case "DrawColor": _value = _LuaLightEditorSettings_DrawColor; return true;
                case "DrawCookie": _value = _LuaLightEditorSettings_DrawCookie; return true;
                case "DrawCookieProperty": _value = _LuaLightEditorSettings_DrawCookieProperty; return true;
                case "DrawCookieSize": _value = _LuaLightEditorSettings_DrawCookieSize; return true;
                case "DrawCullingMask": _value = _LuaLightEditorSettings_DrawCullingMask; return true;
                case "DrawFlare": _value = _LuaLightEditorSettings_DrawFlare; return true;
                case "DrawHalo": _value = _LuaLightEditorSettings_DrawHalo; return true;
                case "DrawInnerAndOuterSpotAngle": _value = _LuaLightEditorSettings_DrawInnerAndOuterSpotAngle; return true;
                case "DrawIntensity": _value = _LuaLightEditorSettings_DrawIntensity; return true;
                case "DrawLightmapping": _value = _LuaLightEditorSettings_DrawLightmapping; return true;
                case "DrawLightType": _value = _LuaLightEditorSettings_DrawLightType; return true;
                case "DrawRange": _value = _LuaLightEditorSettings_DrawRange; return true;
                case "DrawRenderingLayerMask": _value = _LuaLightEditorSettings_DrawRenderingLayerMask; return true;
                case "DrawRenderMode": _value = _LuaLightEditorSettings_DrawRenderMode; return true;
                case "DrawRuntimeShadow": _value = _LuaLightEditorSettings_DrawRuntimeShadow; return true;
                case "DrawShadowsType": _value = _LuaLightEditorSettings_DrawShadowsType; return true;
                case "DrawSpotAngle": _value = _LuaLightEditorSettings_DrawSpotAngle; return true;
                case "OnDestroy": _value = _LuaLightEditorSettings_OnDestroy; return true;
                case "OnEnable": _value = _LuaLightEditorSettings_OnEnable; return true;
                case "Update": _value = _LuaLightEditorSettings_Update; return true;
                case "areaSizeX": _value = _factory.Bind(Instance.areaSizeX); return true;
                case "areaSizeY": _value = _factory.Bind(Instance.areaSizeY); return true;
                case "bakedShadowAngleProp": _value = _factory.Bind(Instance.bakedShadowAngleProp); return true;
                case "bakedShadowRadiusProp": _value = _factory.Bind(Instance.bakedShadowRadiusProp); return true;
                case "bounceIntensity": _value = _factory.Bind(Instance.bounceIntensity); return true;
                case "color": _value = _factory.Bind(Instance.color); return true;
                case "colorTemperature": _value = _factory.Bind(Instance.colorTemperature); return true;
                case "cookie": _value = _factory.Bind(Instance.cookie); return true;
                case "cookieProp": _value = _factory.Bind(Instance.cookieProp); return true;
                case "cookieSize": _value = _factory.Bind(Instance.cookieSize); return true;
                case "cullingMask": _value = _factory.Bind(Instance.cullingMask); return true;
                case "enableSpotReflector": _value = _factory.Bind(Instance.enableSpotReflector); return true;
                case "flare": _value = _factory.Bind(Instance.flare); return true;
                case "halo": _value = _factory.Bind(Instance.halo); return true;
                case "innerSpotAngle": _value = _factory.Bind(Instance.innerSpotAngle); return true;
                case "intensity": _value = _factory.Bind(Instance.intensity); return true;
                case "isAreaLightType": _value = new global::Lua.LuaValue(Instance.isAreaLightType); return true;
                case "isBakedOrMixed": _value = new global::Lua.LuaValue(Instance.isBakedOrMixed); return true;
                case "isCompletelyBaked": _value = new global::Lua.LuaValue(Instance.isCompletelyBaked); return true;
                case "isMixed": _value = new global::Lua.LuaValue(Instance.isMixed); return true;
                case "isRealtime": _value = new global::Lua.LuaValue(Instance.isRealtime); return true;
                case "light": _value = _factory.Bind(Instance.light); return true;
                case "lightmapping": _value = _factory.Bind(Instance.lightmapping); return true;
                case "lightType": _value = _factory.Bind(Instance.lightType); return true;
                case "lightUnit": _value = _factory.Bind(Instance.lightUnit); return true;
                case "luxAtDistance": _value = _factory.Bind(Instance.luxAtDistance); return true;
                case "range": _value = _factory.Bind(Instance.range); return true;
                case "renderingLayerMask": _value = _factory.Bind(Instance.renderingLayerMask); return true;
                case "renderMode": _value = _factory.Bind(Instance.renderMode); return true;
                case "shadowsBias": _value = _factory.Bind(Instance.shadowsBias); return true;
                case "shadowsNearPlane": _value = _factory.Bind(Instance.shadowsNearPlane); return true;
                case "shadowsNormalBias": _value = _factory.Bind(Instance.shadowsNormalBias); return true;
                case "shadowsResolution": _value = _factory.Bind(Instance.shadowsResolution); return true;
                case "shadowsStrength": _value = _factory.Bind(Instance.shadowsStrength); return true;
                case "shadowsType": _value = _factory.Bind(Instance.shadowsType); return true;
                case "spotAngle": _value = _factory.Bind(Instance.spotAngle); return true;
                case "useColorTemperature": _value = _factory.Bind(Instance.useColorTemperature); return true;
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
    public sealed class LuaLightEditorSettingsType : global::Luny.ILuaStatic
    {
        public static global::Lua.LuaValue Bind() => new LuaLightEditorSettingsType();
        private LuaLightEditorSettingsType() {}
        public static implicit operator global::Lua.LuaValue(LuaLightEditorSettingsType value) => new(value);
        public global::System.Type BindType => typeof(global::UnityEditor.LightEditor.Settings);
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
            metatable[global::Lua.Runtime.Metamethods.Call] = _LuaLightEditorSettings_new;
            return metatable;
        }
        public override global::System.String ToString() => BindType.FullName;
#if UNITY_EDITOR
        [global::UnityEngine.RuntimeInitializeOnLoadMethod(global::UnityEngine.RuntimeInitializeLoadType.SubsystemRegistration)]
        private static void ResetStaticFields() => s_Metatable = null;
#endif

        private static readonly global::Lua.LuaFunction _LuaLightEditorSettings_new = new global::Lua.LuaFunction(".ctor", (_context, _) =>
        {
            global::Lua.LuaValue _lastArg = default;
            global::System.Int32 _lastArgPos = default;
            global::System.Type _expectedType = default;
            var _argCount = _context.ArgumentCount;
            var _arg0 = _lastArg = _argCount > 1 ? _context.GetArgument(1) : global::Lua.LuaValue.Nil;
            _lastArgPos = 0; _expectedType = typeof(global::LunyEditor.UnityEditor.LuaSerializedObject);
            if (_arg0.TryRead<global::LunyEditor.UnityEditor.LuaSerializedObject>(out var _p0_UnityEditor_SerializedObject))
            {
                if (_argCount == 2)
                {
                    var so = _p0_UnityEditor_SerializedObject.Instance;
                    var _ret0 = new global::UnityEditor.LightEditor.Settings(so);
                    var _factory = _context.GetObjectFactory();
                    var _lret0 = _factory.Bind(_ret0);
                    var _retCount = _context.Return(_lret0);
                    return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                }
            }
            throw new global::Lua.LuaRuntimeException(_context.Thread, $"{".ctor"}: invalid argument #{_lastArgPos}: {_lastArg} ({_lastArg.Type}), expected: {_expectedType.FullName}", 2);
        });
        private static readonly global::Lua.LuaFunction __index = new(global::Lua.Runtime.Metamethods.Index, (_context, _) =>
        {
            var _this = _context.GetArgument<LuaLightEditorSettingsType>(0);
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
            var _this = _context.GetArgument<LuaLightEditorSettingsType>(0);
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
}
#pragma warning restore 0109, 0162, 0168, 0219
#endif
