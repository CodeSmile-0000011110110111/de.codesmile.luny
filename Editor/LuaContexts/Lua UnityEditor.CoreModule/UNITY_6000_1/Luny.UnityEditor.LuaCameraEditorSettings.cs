
// --------------------------------------------------------------
// GENERATED FILE ----> DO NOT EDIT <---- CHANGES WILL BE LOST !!
// --------------------------------------------------------------

#if UNITY_6000_1_OR_NEWER && !(UNITY_6000_2_OR_NEWER)
#pragma warning disable 0109, 0162, 0168, 0219
using Luny;

namespace Luny.UnityEditor
{
    public sealed class LuaCameraEditorSettings : global::Luny.ILuaObject<global::UnityEditor.CameraEditor.Settings>
    {
        public new static global::Lua.LuaValue Bind(global::UnityEditor.CameraEditor.Settings instance) => new LuaCameraEditorSettings(instance);
        public new static global::Lua.LuaValue Bind(global::System.Object instance) => Bind((global::UnityEditor.CameraEditor.Settings)instance);
        public new static global::Lua.LuaValue Bind(global::System.Collections.Generic.IList<global::UnityEditor.CameraEditor.Settings> instances) =>
            new global::Luny.LuaList<global::UnityEditor.CameraEditor.Settings>(instances);
        public new static global::Lua.LuaValue Bind(global::System.Collections.Generic.IList<global::System.Object> instances) =>
            new global::Luny.LuaList<global::UnityEditor.CameraEditor.Settings>(instances);
        private LuaCameraEditorSettings(global::UnityEditor.CameraEditor.Settings instance) => m_Instance = instance;
        public static implicit operator global::Lua.LuaValue(LuaCameraEditorSettings value) => new(value);
        private global::UnityEditor.CameraEditor.Settings m_Instance;
        public global::UnityEditor.CameraEditor.Settings Instance => m_Instance;
        public new global::System.Type BindType => typeof(global::UnityEditor.CameraEditor.Settings);
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

        private static readonly global::Lua.LuaFunction _LuaCameraEditorSettings_ApplyModifiedProperties = new global::Lua.LuaFunction("ApplyModifiedProperties", (_context, _) =>
        {
            global::Lua.LuaValue _lastArg = default;
            global::System.Int32 _lastArgPos = default;
            global::System.Type _expectedType = default;
            var _argCount = _context.ArgumentCount;
            var _this = _context.GetArgument<LuaCameraEditorSettings>(0);
            if (_argCount == 1)
            {
                _this.Instance.ApplyModifiedProperties();
                var _retCount = _context.Return();
                return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
            }
            throw new global::Lua.LuaRuntimeException(_context.Thread, $"{"ApplyModifiedProperties"}: invalid argument #{_lastArgPos}: {_lastArg} ({_lastArg.Type}), expected: {_expectedType.FullName}", 2);
        });
        private static readonly global::Lua.LuaFunction _LuaCameraEditorSettings_DrawBackgroundColor = new global::Lua.LuaFunction("DrawBackgroundColor", (_context, _) =>
        {
            global::Lua.LuaValue _lastArg = default;
            global::System.Int32 _lastArgPos = default;
            global::System.Type _expectedType = default;
            var _argCount = _context.ArgumentCount;
            var _this = _context.GetArgument<LuaCameraEditorSettings>(0);
            if (_argCount == 1)
            {
                _this.Instance.DrawBackgroundColor();
                var _retCount = _context.Return();
                return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
            }
            throw new global::Lua.LuaRuntimeException(_context.Thread, $"{"DrawBackgroundColor"}: invalid argument #{_lastArgPos}: {_lastArg} ({_lastArg.Type}), expected: {_expectedType.FullName}", 2);
        });
        private static readonly global::Lua.LuaFunction _LuaCameraEditorSettings_DrawClearFlags = new global::Lua.LuaFunction("DrawClearFlags", (_context, _) =>
        {
            global::Lua.LuaValue _lastArg = default;
            global::System.Int32 _lastArgPos = default;
            global::System.Type _expectedType = default;
            var _argCount = _context.ArgumentCount;
            var _this = _context.GetArgument<LuaCameraEditorSettings>(0);
            if (_argCount == 1)
            {
                _this.Instance.DrawClearFlags();
                var _retCount = _context.Return();
                return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
            }
            throw new global::Lua.LuaRuntimeException(_context.Thread, $"{"DrawClearFlags"}: invalid argument #{_lastArgPos}: {_lastArg} ({_lastArg.Type}), expected: {_expectedType.FullName}", 2);
        });
        private static readonly global::Lua.LuaFunction _LuaCameraEditorSettings_DrawClippingPlanes = new global::Lua.LuaFunction("DrawClippingPlanes", (_context, _) =>
        {
            global::Lua.LuaValue _lastArg = default;
            global::System.Int32 _lastArgPos = default;
            global::System.Type _expectedType = default;
            var _argCount = _context.ArgumentCount;
            var _this = _context.GetArgument<LuaCameraEditorSettings>(0);
            if (_argCount == 1)
            {
                _this.Instance.DrawClippingPlanes();
                var _retCount = _context.Return();
                return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
            }
            throw new global::Lua.LuaRuntimeException(_context.Thread, $"{"DrawClippingPlanes"}: invalid argument #{_lastArgPos}: {_lastArg} ({_lastArg.Type}), expected: {_expectedType.FullName}", 2);
        });
        private static readonly global::Lua.LuaFunction _LuaCameraEditorSettings_DrawCullingMask = new global::Lua.LuaFunction("DrawCullingMask", (_context, _) =>
        {
            global::Lua.LuaValue _lastArg = default;
            global::System.Int32 _lastArgPos = default;
            global::System.Type _expectedType = default;
            var _argCount = _context.ArgumentCount;
            var _this = _context.GetArgument<LuaCameraEditorSettings>(0);
            if (_argCount == 1)
            {
                _this.Instance.DrawCullingMask();
                var _retCount = _context.Return();
                return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
            }
            throw new global::Lua.LuaRuntimeException(_context.Thread, $"{"DrawCullingMask"}: invalid argument #{_lastArgPos}: {_lastArg} ({_lastArg.Type}), expected: {_expectedType.FullName}", 2);
        });
        private static readonly global::Lua.LuaFunction _LuaCameraEditorSettings_DrawDepth = new global::Lua.LuaFunction("DrawDepth", (_context, _) =>
        {
            global::Lua.LuaValue _lastArg = default;
            global::System.Int32 _lastArgPos = default;
            global::System.Type _expectedType = default;
            var _argCount = _context.ArgumentCount;
            var _this = _context.GetArgument<LuaCameraEditorSettings>(0);
            if (_argCount == 1)
            {
                _this.Instance.DrawDepth();
                var _retCount = _context.Return();
                return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
            }
            throw new global::Lua.LuaRuntimeException(_context.Thread, $"{"DrawDepth"}: invalid argument #{_lastArgPos}: {_lastArg} ({_lastArg.Type}), expected: {_expectedType.FullName}", 2);
        });
        private static readonly global::Lua.LuaFunction _LuaCameraEditorSettings_DrawDynamicResolution = new global::Lua.LuaFunction("DrawDynamicResolution", (_context, _) =>
        {
            global::Lua.LuaValue _lastArg = default;
            global::System.Int32 _lastArgPos = default;
            global::System.Type _expectedType = default;
            var _argCount = _context.ArgumentCount;
            var _this = _context.GetArgument<LuaCameraEditorSettings>(0);
            if (_argCount == 1)
            {
                _this.Instance.DrawDynamicResolution();
                var _retCount = _context.Return();
                return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
            }
            throw new global::Lua.LuaRuntimeException(_context.Thread, $"{"DrawDynamicResolution"}: invalid argument #{_lastArgPos}: {_lastArg} ({_lastArg.Type}), expected: {_expectedType.FullName}", 2);
        });
        private static readonly global::Lua.LuaFunction _LuaCameraEditorSettings_DrawHDR = new global::Lua.LuaFunction("DrawHDR", (_context, _) =>
        {
            global::Lua.LuaValue _lastArg = default;
            global::System.Int32 _lastArgPos = default;
            global::System.Type _expectedType = default;
            var _argCount = _context.ArgumentCount;
            var _this = _context.GetArgument<LuaCameraEditorSettings>(0);
            if (_argCount == 1)
            {
                _this.Instance.DrawHDR();
                var _retCount = _context.Return();
                return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
            }
            throw new global::Lua.LuaRuntimeException(_context.Thread, $"{"DrawHDR"}: invalid argument #{_lastArgPos}: {_lastArg} ({_lastArg.Type}), expected: {_expectedType.FullName}", 2);
        });
        private static readonly global::Lua.LuaFunction _LuaCameraEditorSettings_DrawMSAA = new global::Lua.LuaFunction("DrawMSAA", (_context, _) =>
        {
            global::Lua.LuaValue _lastArg = default;
            global::System.Int32 _lastArgPos = default;
            global::System.Type _expectedType = default;
            var _argCount = _context.ArgumentCount;
            var _this = _context.GetArgument<LuaCameraEditorSettings>(0);
            if (_argCount == 1)
            {
                _this.Instance.DrawMSAA();
                var _retCount = _context.Return();
                return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
            }
            throw new global::Lua.LuaRuntimeException(_context.Thread, $"{"DrawMSAA"}: invalid argument #{_lastArgPos}: {_lastArg} ({_lastArg.Type}), expected: {_expectedType.FullName}", 2);
        });
        private static readonly global::Lua.LuaFunction _LuaCameraEditorSettings_DrawMultiDisplay = new global::Lua.LuaFunction("DrawMultiDisplay", (_context, _) =>
        {
            global::Lua.LuaValue _lastArg = default;
            global::System.Int32 _lastArgPos = default;
            global::System.Type _expectedType = default;
            var _argCount = _context.ArgumentCount;
            var _this = _context.GetArgument<LuaCameraEditorSettings>(0);
            if (_argCount == 1)
            {
                _this.Instance.DrawMultiDisplay();
                var _retCount = _context.Return();
                return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
            }
            throw new global::Lua.LuaRuntimeException(_context.Thread, $"{"DrawMultiDisplay"}: invalid argument #{_lastArgPos}: {_lastArg} ({_lastArg.Type}), expected: {_expectedType.FullName}", 2);
        });
        private static readonly global::Lua.LuaFunction _LuaCameraEditorSettings_DrawNormalizedViewPort = new global::Lua.LuaFunction("DrawNormalizedViewPort", (_context, _) =>
        {
            global::Lua.LuaValue _lastArg = default;
            global::System.Int32 _lastArgPos = default;
            global::System.Type _expectedType = default;
            var _argCount = _context.ArgumentCount;
            var _this = _context.GetArgument<LuaCameraEditorSettings>(0);
            if (_argCount == 1)
            {
                _this.Instance.DrawNormalizedViewPort();
                var _retCount = _context.Return();
                return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
            }
            throw new global::Lua.LuaRuntimeException(_context.Thread, $"{"DrawNormalizedViewPort"}: invalid argument #{_lastArgPos}: {_lastArg} ({_lastArg.Type}), expected: {_expectedType.FullName}", 2);
        });
        private static readonly global::Lua.LuaFunction _LuaCameraEditorSettings_DrawOcclusionCulling = new global::Lua.LuaFunction("DrawOcclusionCulling", (_context, _) =>
        {
            global::Lua.LuaValue _lastArg = default;
            global::System.Int32 _lastArgPos = default;
            global::System.Type _expectedType = default;
            var _argCount = _context.ArgumentCount;
            var _this = _context.GetArgument<LuaCameraEditorSettings>(0);
            if (_argCount == 1)
            {
                _this.Instance.DrawOcclusionCulling();
                var _retCount = _context.Return();
                return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
            }
            throw new global::Lua.LuaRuntimeException(_context.Thread, $"{"DrawOcclusionCulling"}: invalid argument #{_lastArgPos}: {_lastArg} ({_lastArg.Type}), expected: {_expectedType.FullName}", 2);
        });
        private static readonly global::Lua.LuaFunction _LuaCameraEditorSettings_DrawProjection = new global::Lua.LuaFunction("DrawProjection", (_context, _) =>
        {
            global::Lua.LuaValue _lastArg = default;
            global::System.Int32 _lastArgPos = default;
            global::System.Type _expectedType = default;
            var _argCount = _context.ArgumentCount;
            var _this = _context.GetArgument<LuaCameraEditorSettings>(0);
            if (_argCount == 1)
            {
                _this.Instance.DrawProjection();
                var _retCount = _context.Return();
                return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
            }
            throw new global::Lua.LuaRuntimeException(_context.Thread, $"{"DrawProjection"}: invalid argument #{_lastArgPos}: {_lastArg} ({_lastArg.Type}), expected: {_expectedType.FullName}", 2);
        });
        private static readonly global::Lua.LuaFunction _LuaCameraEditorSettings_DrawRenderingPath = new global::Lua.LuaFunction("DrawRenderingPath", (_context, _) =>
        {
            global::Lua.LuaValue _lastArg = default;
            global::System.Int32 _lastArgPos = default;
            global::System.Type _expectedType = default;
            var _argCount = _context.ArgumentCount;
            var _this = _context.GetArgument<LuaCameraEditorSettings>(0);
            if (_argCount == 1)
            {
                _this.Instance.DrawRenderingPath();
                var _retCount = _context.Return();
                return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
            }
            throw new global::Lua.LuaRuntimeException(_context.Thread, $"{"DrawRenderingPath"}: invalid argument #{_lastArgPos}: {_lastArg} ({_lastArg.Type}), expected: {_expectedType.FullName}", 2);
        });
        private static readonly global::Lua.LuaFunction _LuaCameraEditorSettings_DrawTargetEye = new global::Lua.LuaFunction("DrawTargetEye", (_context, _) =>
        {
            global::Lua.LuaValue _lastArg = default;
            global::System.Int32 _lastArgPos = default;
            global::System.Type _expectedType = default;
            var _argCount = _context.ArgumentCount;
            var _this = _context.GetArgument<LuaCameraEditorSettings>(0);
            if (_argCount == 1)
            {
                _this.Instance.DrawTargetEye();
                var _retCount = _context.Return();
                return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
            }
            throw new global::Lua.LuaRuntimeException(_context.Thread, $"{"DrawTargetEye"}: invalid argument #{_lastArgPos}: {_lastArg} ({_lastArg.Type}), expected: {_expectedType.FullName}", 2);
        });
        private static readonly global::Lua.LuaFunction _LuaCameraEditorSettings_DrawTargetTexture = new global::Lua.LuaFunction("DrawTargetTexture", (_context, _) =>
        {
            global::Lua.LuaValue _lastArg = default;
            global::System.Int32 _lastArgPos = default;
            global::System.Type _expectedType = default;
            var _argCount = _context.ArgumentCount;
            var _this = _context.GetArgument<LuaCameraEditorSettings>(0);
            var _arg0 = _lastArg = _argCount > 1 ? _context.GetArgument(1) : global::Lua.LuaValue.Nil;
            _lastArgPos = 0; _expectedType = typeof(global::System.Boolean);
            if (_arg0.TryRead<global::System.Boolean>(out var _p0_System_Boolean))
            {
                if (_argCount == 2)
                {
                    var deferred = _p0_System_Boolean;
                    _this.Instance.DrawTargetTexture(deferred);
                    var _retCount = _context.Return();
                    return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                }
            }
            throw new global::Lua.LuaRuntimeException(_context.Thread, $"{"DrawTargetTexture"}: invalid argument #{_lastArgPos}: {_lastArg} ({_lastArg.Type}), expected: {_expectedType.FullName}", 2);
        });
        private static readonly global::Lua.LuaFunction _LuaCameraEditorSettings_OnEnable = new global::Lua.LuaFunction("OnEnable", (_context, _) =>
        {
            global::Lua.LuaValue _lastArg = default;
            global::System.Int32 _lastArgPos = default;
            global::System.Type _expectedType = default;
            var _argCount = _context.ArgumentCount;
            var _this = _context.GetArgument<LuaCameraEditorSettings>(0);
            if (_argCount == 1)
            {
                _this.Instance.OnEnable();
                var _retCount = _context.Return();
                return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
            }
            throw new global::Lua.LuaRuntimeException(_context.Thread, $"{"OnEnable"}: invalid argument #{_lastArgPos}: {_lastArg} ({_lastArg.Type}), expected: {_expectedType.FullName}", 2);
        });
        private static readonly global::Lua.LuaFunction _LuaCameraEditorSettings_Update = new global::Lua.LuaFunction("Update", (_context, _) =>
        {
            global::Lua.LuaValue _lastArg = default;
            global::System.Int32 _lastArgPos = default;
            global::System.Type _expectedType = default;
            var _argCount = _context.ArgumentCount;
            var _this = _context.GetArgument<LuaCameraEditorSettings>(0);
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
            var _this = _context.GetArgument<LuaCameraEditorSettings>(0);
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
            var _this = _context.GetArgument<LuaCameraEditorSettings>(0);
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
                case "ApplyModifiedProperties": _value = _LuaCameraEditorSettings_ApplyModifiedProperties; return true;
                case "DrawBackgroundColor": _value = _LuaCameraEditorSettings_DrawBackgroundColor; return true;
                case "DrawClearFlags": _value = _LuaCameraEditorSettings_DrawClearFlags; return true;
                case "DrawClippingPlanes": _value = _LuaCameraEditorSettings_DrawClippingPlanes; return true;
                case "DrawCullingMask": _value = _LuaCameraEditorSettings_DrawCullingMask; return true;
                case "DrawDepth": _value = _LuaCameraEditorSettings_DrawDepth; return true;
                case "DrawDynamicResolution": _value = _LuaCameraEditorSettings_DrawDynamicResolution; return true;
                case "DrawHDR": _value = _LuaCameraEditorSettings_DrawHDR; return true;
                case "DrawMSAA": _value = _LuaCameraEditorSettings_DrawMSAA; return true;
                case "DrawMultiDisplay": _value = _LuaCameraEditorSettings_DrawMultiDisplay; return true;
                case "DrawNormalizedViewPort": _value = _LuaCameraEditorSettings_DrawNormalizedViewPort; return true;
                case "DrawOcclusionCulling": _value = _LuaCameraEditorSettings_DrawOcclusionCulling; return true;
                case "DrawProjection": _value = _LuaCameraEditorSettings_DrawProjection; return true;
                case "DrawRenderingPath": _value = _LuaCameraEditorSettings_DrawRenderingPath; return true;
                case "DrawTargetEye": _value = _LuaCameraEditorSettings_DrawTargetEye; return true;
                case "DrawTargetTexture": _value = _LuaCameraEditorSettings_DrawTargetTexture; return true;
                case "OnEnable": _value = _LuaCameraEditorSettings_OnEnable; return true;
                case "Update": _value = _LuaCameraEditorSettings_Update; return true;
                case "allowDynamicResolution": _value = _factory.Bind(Instance.allowDynamicResolution); return true;
                case "allowMSAA": _value = _factory.Bind(Instance.allowMSAA); return true;
                case "anamorphism": _value = _factory.Bind(Instance.anamorphism); return true;
                case "aperture": _value = _factory.Bind(Instance.aperture); return true;
                case "backgroundColor": _value = _factory.Bind(Instance.backgroundColor); return true;
                case "barrelClipping": _value = _factory.Bind(Instance.barrelClipping); return true;
                case "bladeCount": _value = _factory.Bind(Instance.bladeCount); return true;
                case "clearFlags": _value = _factory.Bind(Instance.clearFlags); return true;
                case "cullingMask": _value = _factory.Bind(Instance.cullingMask); return true;
                case "curvature": _value = _factory.Bind(Instance.curvature); return true;
                case "depth": _value = _factory.Bind(Instance.depth); return true;
                case "farClippingPlane": _value = _factory.Bind(Instance.farClippingPlane); return true;
                case "focalLength": _value = _factory.Bind(Instance.focalLength); return true;
                case "focusDistance": _value = _factory.Bind(Instance.focusDistance); return true;
                case "fovAxisMode": _value = _factory.Bind(Instance.fovAxisMode); return true;
                case "gateFit": _value = _factory.Bind(Instance.gateFit); return true;
                case "HDR": _value = _factory.Bind(Instance.HDR); return true;
                case "iso": _value = _factory.Bind(Instance.iso); return true;
                case "lensShift": _value = _factory.Bind(Instance.lensShift); return true;
                case "nearClippingPlane": _value = _factory.Bind(Instance.nearClippingPlane); return true;
                case "normalizedViewPortRect": _value = _factory.Bind(Instance.normalizedViewPortRect); return true;
                case "occlusionCulling": _value = _factory.Bind(Instance.occlusionCulling); return true;
                case "orthographic": _value = _factory.Bind(Instance.orthographic); return true;
                case "orthographicSize": _value = _factory.Bind(Instance.orthographicSize); return true;
                case "renderingPath": _value = _factory.Bind(Instance.renderingPath); return true;
                case "sensorSize": _value = _factory.Bind(Instance.sensorSize); return true;
                case "shutterSpeed": _value = _factory.Bind(Instance.shutterSpeed); return true;
                case "stereoConvergence": _value = _factory.Bind(Instance.stereoConvergence); return true;
                case "stereoSeparation": _value = _factory.Bind(Instance.stereoSeparation); return true;
                case "targetDisplay": _value = _factory.Bind(Instance.targetDisplay); return true;
                case "targetEye": _value = _factory.Bind(Instance.targetEye); return true;
                case "targetTexture": _value = _factory.Bind(Instance.targetTexture); return true;
                case "verticalFOV": _value = _factory.Bind(Instance.verticalFOV); return true;
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
    public sealed class LuaCameraEditorSettingsType : global::Luny.ILuaStatic
    {
        public static global::Lua.LuaValue Bind() => new LuaCameraEditorSettingsType();
        private LuaCameraEditorSettingsType() {}
        public static implicit operator global::Lua.LuaValue(LuaCameraEditorSettingsType value) => new(value);
        public global::System.Type BindType => typeof(global::UnityEditor.CameraEditor.Settings);
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
            metatable[global::Lua.Runtime.Metamethods.Call] = _LuaCameraEditorSettings_new;
            return metatable;
        }
        public override global::System.String ToString() => BindType.FullName;
#if UNITY_EDITOR
        [global::UnityEngine.RuntimeInitializeOnLoadMethod(global::UnityEngine.RuntimeInitializeLoadType.SubsystemRegistration)]
        private static void ResetStaticFields() => s_Metatable = null;
#endif

        private static readonly global::Lua.LuaFunction _LuaCameraEditorSettings_new = new global::Lua.LuaFunction(".ctor", (_context, _) =>
        {
            global::Lua.LuaValue _lastArg = default;
            global::System.Int32 _lastArgPos = default;
            global::System.Type _expectedType = default;
            var _argCount = _context.ArgumentCount;
            var _arg0 = _lastArg = _argCount > 1 ? _context.GetArgument(1) : global::Lua.LuaValue.Nil;
            _lastArgPos = 0; _expectedType = typeof(global::Luny.UnityEditor.LuaSerializedObject);
            if (_arg0.TryRead<global::Luny.UnityEditor.LuaSerializedObject>(out var _p0_UnityEditor_SerializedObject))
            {
                if (_argCount == 2)
                {
                    var so = _p0_UnityEditor_SerializedObject.Instance;
                    var _ret0 = new global::UnityEditor.CameraEditor.Settings(so);
                    var _factory = _context.GetObjectFactory();
                    var _lret0 = _factory.Bind(_ret0);
                    var _retCount = _context.Return(_lret0);
                    return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                }
            }
            throw new global::Lua.LuaRuntimeException(_context.Thread, $"{".ctor"}: invalid argument #{_lastArgPos}: {_lastArg} ({_lastArg.Type}), expected: {_expectedType.FullName}", 2);
        });
        private static readonly global::Lua.LuaFunction _LuaCameraEditorSettings_DrawCameraWarnings = new global::Lua.LuaFunction("DrawCameraWarnings", (_context, _) =>
        {
            global::Lua.LuaValue _lastArg = default;
            global::System.Int32 _lastArgPos = default;
            global::System.Type _expectedType = default;
            var _argCount = _context.ArgumentCount;
            var _arg0 = _lastArg = _argCount > 0 ? _context.GetArgument(0) : global::Lua.LuaValue.Nil;
            _lastArgPos = 0; _expectedType = typeof(global::UnityEngine.Camera);
            if (_arg0.TryRead<global::UnityEngine.Camera>(out var _p0_UnityEngine_Camera))
            {
                if (_argCount == 1)
                {
                    var camera = _p0_UnityEngine_Camera;
                    global::UnityEditor.CameraEditor.Settings.DrawCameraWarnings(camera);
                    var _retCount = _context.Return();
                    return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                }
            }
            throw new global::Lua.LuaRuntimeException(_context.Thread, $"{"DrawCameraWarnings"}: invalid argument #{_lastArgPos}: {_lastArg} ({_lastArg.Type}), expected: {_expectedType.FullName}", 2);
        });
        private static readonly global::Lua.LuaFunction __index = new(global::Lua.Runtime.Metamethods.Index, (_context, _) =>
        {
            var _this = _context.GetArgument<LuaCameraEditorSettingsType>(0);
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
            var _this = _context.GetArgument<LuaCameraEditorSettingsType>(0);
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
                case "DrawCameraWarnings": _value = _LuaCameraEditorSettings_DrawCameraWarnings; return true;
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
