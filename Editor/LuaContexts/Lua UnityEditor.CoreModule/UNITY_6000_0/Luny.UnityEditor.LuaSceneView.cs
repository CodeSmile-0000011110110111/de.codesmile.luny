
// --------------------------------------------------------------
// GENERATED FILE ----> DO NOT EDIT <---- CHANGES WILL BE LOST !!
// --------------------------------------------------------------

#if UNITY_6000_0_OR_NEWER && !(UNITY_6000_1_OR_NEWER)
#pragma warning disable 0109, 0162, 0168, 0219
using Luny;

namespace Luny.UnityEditor
{
    public sealed class LuaSceneView : LuaSearchableEditorWindow, global::Luny.ILuaObject<global::UnityEditor.SceneView>
    {
        public new static global::Lua.LuaValue Bind(global::UnityEditor.SceneView instance) => new LuaSceneView(instance);
        public new static global::Lua.LuaValue Bind(global::System.Object instance) => Bind((global::UnityEditor.SceneView)instance);
        public new static global::Lua.LuaValue Bind(global::System.Collections.Generic.IList<global::UnityEditor.SceneView> instances) =>
            new global::Luny.LuaList<global::UnityEditor.SceneView>(instances);
        public new static global::Lua.LuaValue Bind(global::System.Collections.Generic.IList<global::System.Object> instances) =>
            new global::Luny.LuaList<global::UnityEditor.SceneView>(instances);
        private LuaSceneView(global::UnityEditor.SceneView instance) : base(instance) {}
        public static implicit operator global::Lua.LuaValue(LuaSceneView value) => new(value);
        public new global::UnityEditor.SceneView Instance => (global::UnityEditor.SceneView)m_Instance;
        public new global::System.Type BindType => typeof(global::UnityEditor.SceneView);
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

        private static readonly global::Lua.LuaFunction _LuaSceneView_AddItemsToMenu = new global::Lua.LuaFunction("AddItemsToMenu", (_context, _) =>
        {
            global::Lua.LuaValue _lastArg = default;
            global::System.Int32 _lastArgPos = default;
            global::System.Type _expectedType = default;
            var _argCount = _context.ArgumentCount;
            var _this = _context.GetArgument<LuaSceneView>(0);
            var _arg0 = _lastArg = _argCount > 1 ? _context.GetArgument(1) : global::Lua.LuaValue.Nil;
            _lastArgPos = 0; _expectedType = typeof(global::Luny.UnityEditor.LuaGenericMenu);
            if (_arg0.TryRead<global::Luny.UnityEditor.LuaGenericMenu>(out var _p0_UnityEditor_GenericMenu))
            {
                if (_argCount == 2)
                {
                    var menu = _p0_UnityEditor_GenericMenu.Instance;
                    _this.Instance.AddItemsToMenu(menu);
                    var _retCount = _context.Return();
                    return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                }
            }
            throw new global::Lua.LuaRuntimeException(_context.Thread, $"{"AddItemsToMenu"}: invalid argument #{_lastArgPos}: {_lastArg} ({_lastArg.Type}), expected: {_expectedType.FullName}", 2);
        });
        private static readonly global::Lua.LuaFunction _LuaSceneView_AlignViewToObject = new global::Lua.LuaFunction("AlignViewToObject", (_context, _) =>
        {
            global::Lua.LuaValue _lastArg = default;
            global::System.Int32 _lastArgPos = default;
            global::System.Type _expectedType = default;
            var _argCount = _context.ArgumentCount;
            var _this = _context.GetArgument<LuaSceneView>(0);
            var _arg0 = _lastArg = _argCount > 1 ? _context.GetArgument(1) : global::Lua.LuaValue.Nil;
            _lastArgPos = 0; _expectedType = typeof(global::UnityEngine.Transform);
            if (_arg0.TryRead<global::UnityEngine.Transform>(out var _p0_UnityEngine_Transform))
            {
                if (_argCount == 2)
                {
                    var t = _p0_UnityEngine_Transform;
                    _this.Instance.AlignViewToObject(t);
                    var _retCount = _context.Return();
                    return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                }
            }
            throw new global::Lua.LuaRuntimeException(_context.Thread, $"{"AlignViewToObject"}: invalid argument #{_lastArgPos}: {_lastArg} ({_lastArg.Type}), expected: {_expectedType.FullName}", 2);
        });
        private static readonly global::Lua.LuaFunction _LuaSceneView_AlignWithView = new global::Lua.LuaFunction("AlignWithView", (_context, _) =>
        {
            global::Lua.LuaValue _lastArg = default;
            global::System.Int32 _lastArgPos = default;
            global::System.Type _expectedType = default;
            var _argCount = _context.ArgumentCount;
            var _this = _context.GetArgument<LuaSceneView>(0);
            if (_argCount == 1)
            {
                _this.Instance.AlignWithView();
                var _retCount = _context.Return();
                return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
            }
            throw new global::Lua.LuaRuntimeException(_context.Thread, $"{"AlignWithView"}: invalid argument #{_lastArgPos}: {_lastArg} ({_lastArg.Type}), expected: {_expectedType.FullName}", 2);
        });
        private static readonly global::Lua.LuaFunction _LuaSceneView_FixNegativeSize = new global::Lua.LuaFunction("FixNegativeSize", (_context, _) =>
        {
            global::Lua.LuaValue _lastArg = default;
            global::System.Int32 _lastArgPos = default;
            global::System.Type _expectedType = default;
            var _argCount = _context.ArgumentCount;
            var _this = _context.GetArgument<LuaSceneView>(0);
            if (_argCount == 1)
            {
                _this.Instance.FixNegativeSize();
                var _retCount = _context.Return();
                return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
            }
            throw new global::Lua.LuaRuntimeException(_context.Thread, $"{"FixNegativeSize"}: invalid argument #{_lastArgPos}: {_lastArg} ({_lastArg.Type}), expected: {_expectedType.FullName}", 2);
        });
        private static readonly global::Lua.LuaFunction _LuaSceneView_Frame = new global::Lua.LuaFunction("Frame", (_context, _) =>
        {
            global::Lua.LuaValue _lastArg = default;
            global::System.Int32 _lastArgPos = default;
            global::System.Type _expectedType = default;
            var _argCount = _context.ArgumentCount;
            var _this = _context.GetArgument<LuaSceneView>(0);
            var _arg0 = _lastArg = _argCount > 1 ? _context.GetArgument(1) : global::Lua.LuaValue.Nil;
            _lastArgPos = 0; _expectedType = typeof(global::UnityEngine.Bounds);
            if (_arg0.TryRead<global::UnityEngine.Bounds>(out var _p0_UnityEngine_Bounds))
            {
                if (_argCount == 2)
                {
                    var bounds = _p0_UnityEngine_Bounds;
                    var _ret0 = _this.Instance.Frame(bounds);
                    var _lret0 = new global::Lua.LuaValue(_ret0);
                    var _retCount = _context.Return(_lret0);
                    return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                }
                var _arg1 = _lastArg = _argCount > 2 ? _context.GetArgument(2) : global::Lua.LuaValue.Nil;
                _lastArgPos = 1; _expectedType = typeof(global::System.Boolean);
                var _p1_System_Boolean = _arg1.ReadValue<global::System.Boolean>((global::System.Boolean)true);
                {
                    if (_argCount == 3)
                    {
                        var bounds = _p0_UnityEngine_Bounds;
                        var instant = _p1_System_Boolean;
                        var _ret0 = _this.Instance.Frame(bounds, instant);
                        var _lret0 = new global::Lua.LuaValue(_ret0);
                        var _retCount = _context.Return(_lret0);
                        return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                    }
                }
            }
            throw new global::Lua.LuaRuntimeException(_context.Thread, $"{"Frame"}: invalid argument #{_lastArgPos}: {_lastArg} ({_lastArg.Type}), expected: {_expectedType.FullName}", 2);
        });
        private static readonly global::Lua.LuaFunction _LuaSceneView_FrameSelected = new global::Lua.LuaFunction("FrameSelected", (_context, _) =>
        {
            global::Lua.LuaValue _lastArg = default;
            global::System.Int32 _lastArgPos = default;
            global::System.Type _expectedType = default;
            var _argCount = _context.ArgumentCount;
            var _this = _context.GetArgument<LuaSceneView>(0);
            if (_argCount == 1)
            {
                var _ret0 = _this.Instance.FrameSelected();
                var _lret0 = new global::Lua.LuaValue(_ret0);
                var _retCount = _context.Return(_lret0);
                return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
            }
            var _arg0 = _lastArg = _argCount > 1 ? _context.GetArgument(1) : global::Lua.LuaValue.Nil;
            _lastArgPos = 0; _expectedType = typeof(global::System.Boolean);
            if (_arg0.TryRead<global::System.Boolean>(out var _p0_System_Boolean))
            {
                if (_argCount == 2)
                {
                    var lockView = _p0_System_Boolean;
                    var _ret0 = _this.Instance.FrameSelected(lockView);
                    var _lret0 = new global::Lua.LuaValue(_ret0);
                    var _retCount = _context.Return(_lret0);
                    return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                }
                var _arg1 = _lastArg = _argCount > 2 ? _context.GetArgument(2) : global::Lua.LuaValue.Nil;
                _lastArgPos = 1; _expectedType = typeof(global::System.Boolean);
                if (_arg1.TryRead<global::System.Boolean>(out var _p1_System_Boolean))
                {
                    if (_argCount == 3)
                    {
                        var lockView = _p0_System_Boolean;
                        var instant = _p1_System_Boolean;
                        var _ret0 = _this.Instance.FrameSelected(lockView, instant);
                        var _lret0 = new global::Lua.LuaValue(_ret0);
                        var _retCount = _context.Return(_lret0);
                        return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                    }
                }
            }
            throw new global::Lua.LuaRuntimeException(_context.Thread, $"{"FrameSelected"}: invalid argument #{_lastArgPos}: {_lastArg} ({_lastArg.Type}), expected: {_expectedType.FullName}", 2);
        });
        private static readonly global::Lua.LuaFunction _LuaSceneView_IsCameraDrawModeEnabled = new global::Lua.LuaFunction("IsCameraDrawModeEnabled", (_context, _) =>
        {
            global::Lua.LuaValue _lastArg = default;
            global::System.Int32 _lastArgPos = default;
            global::System.Type _expectedType = default;
            var _argCount = _context.ArgumentCount;
            var _this = _context.GetArgument<LuaSceneView>(0);
            var _arg0 = _lastArg = _argCount > 1 ? _context.GetArgument(1) : global::Lua.LuaValue.Nil;
            _lastArgPos = 0; _expectedType = typeof(global::Luny.UnityEditor.LuaSceneViewCameraMode);
            if (_arg0.TryRead<global::Luny.UnityEditor.LuaSceneViewCameraMode>(out var _p0_UnityEditor_SceneView_CameraMode))
            {
                if (_argCount == 2)
                {
                    var mode = _p0_UnityEditor_SceneView_CameraMode.Value;
                    var _ret0 = _this.Instance.IsCameraDrawModeEnabled(mode);
                    var _lret0 = new global::Lua.LuaValue(_ret0);
                    var _retCount = _context.Return(_lret0);
                    return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                }
            }
            throw new global::Lua.LuaRuntimeException(_context.Thread, $"{"IsCameraDrawModeEnabled"}: invalid argument #{_lastArgPos}: {_lastArg} ({_lastArg.Type}), expected: {_expectedType.FullName}", 2);
        });
        private static readonly global::Lua.LuaFunction _LuaSceneView_IsCameraDrawModeSupported = new global::Lua.LuaFunction("IsCameraDrawModeSupported", (_context, _) =>
        {
            global::Lua.LuaValue _lastArg = default;
            global::System.Int32 _lastArgPos = default;
            global::System.Type _expectedType = default;
            var _argCount = _context.ArgumentCount;
            var _this = _context.GetArgument<LuaSceneView>(0);
            var _arg0 = _lastArg = _argCount > 1 ? _context.GetArgument(1) : global::Lua.LuaValue.Nil;
            _lastArgPos = 0; _expectedType = typeof(global::Luny.UnityEditor.LuaSceneViewCameraMode);
            if (_arg0.TryRead<global::Luny.UnityEditor.LuaSceneViewCameraMode>(out var _p0_UnityEditor_SceneView_CameraMode))
            {
                if (_argCount == 2)
                {
                    var mode = _p0_UnityEditor_SceneView_CameraMode.Value;
                    var _ret0 = _this.Instance.IsCameraDrawModeSupported(mode);
                    var _lret0 = new global::Lua.LuaValue(_ret0);
                    var _retCount = _context.Return(_lret0);
                    return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                }
            }
            throw new global::Lua.LuaRuntimeException(_context.Thread, $"{"IsCameraDrawModeSupported"}: invalid argument #{_lastArgPos}: {_lastArg} ({_lastArg.Type}), expected: {_expectedType.FullName}", 2);
        });
        private static readonly global::Lua.LuaFunction _LuaSceneView_LookAt = new global::Lua.LuaFunction("LookAt", (_context, _) =>
        {
            global::Lua.LuaValue _lastArg = default;
            global::System.Int32 _lastArgPos = default;
            global::System.Type _expectedType = default;
            var _argCount = _context.ArgumentCount;
            var _this = _context.GetArgument<LuaSceneView>(0);
            var _arg0 = _lastArg = _argCount > 1 ? _context.GetArgument(1) : global::Lua.LuaValue.Nil;
            _lastArgPos = 0; _expectedType = typeof(global::UnityEngine.Vector3);
            if (_arg0.TryRead<global::UnityEngine.Vector3>(out var _p0_UnityEngine_Vector3))
            {
                if (_argCount == 2)
                {
                    var point = _p0_UnityEngine_Vector3;
                    _this.Instance.LookAt(point);
                    var _retCount = _context.Return();
                    return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                }
                var _arg1 = _lastArg = _argCount > 2 ? _context.GetArgument(2) : global::Lua.LuaValue.Nil;
                _lastArgPos = 1; _expectedType = typeof(global::UnityEngine.Quaternion);
                if (_arg1.TryRead<global::UnityEngine.Quaternion>(out var _p1_UnityEngine_Quaternion))
                {
                    if (_argCount == 3)
                    {
                        var point = _p0_UnityEngine_Vector3;
                        var direction = _p1_UnityEngine_Quaternion;
                        _this.Instance.LookAt(point, direction);
                        var _retCount = _context.Return();
                        return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                    }
                    var _arg2 = _lastArg = _argCount > 3 ? _context.GetArgument(3) : global::Lua.LuaValue.Nil;
                    _lastArgPos = 2; _expectedType = typeof(global::System.Single);
                    if (_arg2.TryRead<global::System.Single>(out var _p2_System_Single))
                    {
                        if (_argCount == 4)
                        {
                            var point = _p0_UnityEngine_Vector3;
                            var direction = _p1_UnityEngine_Quaternion;
                            var newSize = _p2_System_Single;
                            _this.Instance.LookAt(point, direction, newSize);
                            var _retCount = _context.Return();
                            return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                        }
                        var _arg3 = _lastArg = _argCount > 4 ? _context.GetArgument(4) : global::Lua.LuaValue.Nil;
                        _lastArgPos = 3; _expectedType = typeof(global::System.Boolean);
                        if (_arg3.TryRead<global::System.Boolean>(out var _p3_System_Boolean))
                        {
                            if (_argCount == 5)
                            {
                                var point = _p0_UnityEngine_Vector3;
                                var direction = _p1_UnityEngine_Quaternion;
                                var newSize = _p2_System_Single;
                                var ortho = _p3_System_Boolean;
                                _this.Instance.LookAt(point, direction, newSize, ortho);
                                var _retCount = _context.Return();
                                return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                            }
                            var _arg4 = _lastArg = _argCount > 5 ? _context.GetArgument(5) : global::Lua.LuaValue.Nil;
                            _lastArgPos = 4; _expectedType = typeof(global::System.Boolean);
                            if (_arg4.TryRead<global::System.Boolean>(out var _p4_System_Boolean))
                            {
                                if (_argCount == 6)
                                {
                                    var point = _p0_UnityEngine_Vector3;
                                    var direction = _p1_UnityEngine_Quaternion;
                                    var newSize = _p2_System_Single;
                                    var ortho = _p3_System_Boolean;
                                    var instant = _p4_System_Boolean;
                                    _this.Instance.LookAt(point, direction, newSize, ortho, instant);
                                    var _retCount = _context.Return();
                                    return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                                }
                            }
                        }
                    }
                }
            }
            throw new global::Lua.LuaRuntimeException(_context.Thread, $"{"LookAt"}: invalid argument #{_lastArgPos}: {_lastArg} ({_lastArg.Type}), expected: {_expectedType.FullName}", 2);
        });
        private static readonly global::Lua.LuaFunction _LuaSceneView_LookAtDirect = new global::Lua.LuaFunction("LookAtDirect", (_context, _) =>
        {
            global::Lua.LuaValue _lastArg = default;
            global::System.Int32 _lastArgPos = default;
            global::System.Type _expectedType = default;
            var _argCount = _context.ArgumentCount;
            var _this = _context.GetArgument<LuaSceneView>(0);
            var _arg0 = _lastArg = _argCount > 1 ? _context.GetArgument(1) : global::Lua.LuaValue.Nil;
            _lastArgPos = 0; _expectedType = typeof(global::UnityEngine.Vector3);
            if (_arg0.TryRead<global::UnityEngine.Vector3>(out var _p0_UnityEngine_Vector3))
            {
                var _arg1 = _lastArg = _argCount > 2 ? _context.GetArgument(2) : global::Lua.LuaValue.Nil;
                _lastArgPos = 1; _expectedType = typeof(global::UnityEngine.Quaternion);
                if (_arg1.TryRead<global::UnityEngine.Quaternion>(out var _p1_UnityEngine_Quaternion))
                {
                    if (_argCount == 3)
                    {
                        var point = _p0_UnityEngine_Vector3;
                        var direction = _p1_UnityEngine_Quaternion;
                        _this.Instance.LookAtDirect(point, direction);
                        var _retCount = _context.Return();
                        return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                    }
                    var _arg2 = _lastArg = _argCount > 3 ? _context.GetArgument(3) : global::Lua.LuaValue.Nil;
                    _lastArgPos = 2; _expectedType = typeof(global::System.Single);
                    if (_arg2.TryRead<global::System.Single>(out var _p2_System_Single))
                    {
                        if (_argCount == 4)
                        {
                            var point = _p0_UnityEngine_Vector3;
                            var direction = _p1_UnityEngine_Quaternion;
                            var newSize = _p2_System_Single;
                            _this.Instance.LookAtDirect(point, direction, newSize);
                            var _retCount = _context.Return();
                            return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                        }
                    }
                }
            }
            throw new global::Lua.LuaRuntimeException(_context.Thread, $"{"LookAtDirect"}: invalid argument #{_lastArgPos}: {_lastArg} ({_lastArg.Type}), expected: {_expectedType.FullName}", 2);
        });
        private static readonly global::Lua.LuaFunction _LuaSceneView_MoveToView = new global::Lua.LuaFunction("MoveToView", (_context, _) =>
        {
            global::Lua.LuaValue _lastArg = default;
            global::System.Int32 _lastArgPos = default;
            global::System.Type _expectedType = default;
            var _argCount = _context.ArgumentCount;
            var _this = _context.GetArgument<LuaSceneView>(0);
            if (_argCount == 1)
            {
                _this.Instance.MoveToView();
                var _retCount = _context.Return();
                return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
            }
            var _arg0 = _lastArg = _argCount > 1 ? _context.GetArgument(1) : global::Lua.LuaValue.Nil;
            _lastArgPos = 0; _expectedType = typeof(global::UnityEngine.Transform);
            if (_arg0.TryRead<global::UnityEngine.Transform>(out var _p0_UnityEngine_Transform))
            {
                if (_argCount == 2)
                {
                    var target = _p0_UnityEngine_Transform;
                    _this.Instance.MoveToView(target);
                    var _retCount = _context.Return();
                    return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                }
            }
            throw new global::Lua.LuaRuntimeException(_context.Thread, $"{"MoveToView"}: invalid argument #{_lastArgPos}: {_lastArg} ({_lastArg.Type}), expected: {_expectedType.FullName}", 2);
        });
        private static readonly global::Lua.LuaFunction _LuaSceneView_OnDestroy = new global::Lua.LuaFunction("OnDestroy", (_context, _) =>
        {
            global::Lua.LuaValue _lastArg = default;
            global::System.Int32 _lastArgPos = default;
            global::System.Type _expectedType = default;
            var _argCount = _context.ArgumentCount;
            var _this = _context.GetArgument<LuaSceneView>(0);
            if (_argCount == 1)
            {
                _this.Instance.OnDestroy();
                var _retCount = _context.Return();
                return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
            }
            throw new global::Lua.LuaRuntimeException(_context.Thread, $"{"OnDestroy"}: invalid argument #{_lastArgPos}: {_lastArg} ({_lastArg.Type}), expected: {_expectedType.FullName}", 2);
        });
        private static readonly global::Lua.LuaFunction _LuaSceneView_OnDisable = new global::Lua.LuaFunction("OnDisable", (_context, _) =>
        {
            global::Lua.LuaValue _lastArg = default;
            global::System.Int32 _lastArgPos = default;
            global::System.Type _expectedType = default;
            var _argCount = _context.ArgumentCount;
            var _this = _context.GetArgument<LuaSceneView>(0);
            if (_argCount == 1)
            {
                _this.Instance.OnDisable();
                var _retCount = _context.Return();
                return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
            }
            throw new global::Lua.LuaRuntimeException(_context.Thread, $"{"OnDisable"}: invalid argument #{_lastArgPos}: {_lastArg} ({_lastArg.Type}), expected: {_expectedType.FullName}", 2);
        });
        private static readonly global::Lua.LuaFunction _LuaSceneView_OnEnable = new global::Lua.LuaFunction("OnEnable", (_context, _) =>
        {
            global::Lua.LuaValue _lastArg = default;
            global::System.Int32 _lastArgPos = default;
            global::System.Type _expectedType = default;
            var _argCount = _context.ArgumentCount;
            var _this = _context.GetArgument<LuaSceneView>(0);
            if (_argCount == 1)
            {
                _this.Instance.OnEnable();
                var _retCount = _context.Return();
                return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
            }
            throw new global::Lua.LuaRuntimeException(_context.Thread, $"{"OnEnable"}: invalid argument #{_lastArgPos}: {_lastArg} ({_lastArg.Type}), expected: {_expectedType.FullName}", 2);
        });
        private static readonly global::Lua.LuaFunction _LuaSceneView_ResetCameraSettings = new global::Lua.LuaFunction("ResetCameraSettings", (_context, _) =>
        {
            global::Lua.LuaValue _lastArg = default;
            global::System.Int32 _lastArgPos = default;
            global::System.Type _expectedType = default;
            var _argCount = _context.ArgumentCount;
            var _this = _context.GetArgument<LuaSceneView>(0);
            if (_argCount == 1)
            {
                _this.Instance.ResetCameraSettings();
                var _retCount = _context.Return();
                return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
            }
            throw new global::Lua.LuaRuntimeException(_context.Thread, $"{"ResetCameraSettings"}: invalid argument #{_lastArgPos}: {_lastArg} ({_lastArg.Type}), expected: {_expectedType.FullName}", 2);
        });
        private static readonly global::Lua.LuaFunction _LuaSceneView_SetSceneViewShaderReplace = new global::Lua.LuaFunction("SetSceneViewShaderReplace", (_context, _) =>
        {
            global::Lua.LuaValue _lastArg = default;
            global::System.Int32 _lastArgPos = default;
            global::System.Type _expectedType = default;
            var _argCount = _context.ArgumentCount;
            var _this = _context.GetArgument<LuaSceneView>(0);
            var _arg0 = _lastArg = _argCount > 1 ? _context.GetArgument(1) : global::Lua.LuaValue.Nil;
            _lastArgPos = 0; _expectedType = typeof(global::UnityEngine.Shader);
            if (_arg0.TryRead<global::UnityEngine.Shader>(out var _p0_UnityEngine_Shader))
            {
                var _arg1 = _lastArg = _argCount > 2 ? _context.GetArgument(2) : global::Lua.LuaValue.Nil;
                _lastArgPos = 1; _expectedType = typeof(global::System.String);
                if (_arg1.TryRead<global::System.String>(out var _p1_System_String))
                {
                    if (_argCount == 3)
                    {
                        var shader = _p0_UnityEngine_Shader;
                        var replaceString = _p1_System_String;
                        _this.Instance.SetSceneViewShaderReplace(shader, replaceString);
                        var _retCount = _context.Return();
                        return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                    }
                }
            }
            throw new global::Lua.LuaRuntimeException(_context.Thread, $"{"SetSceneViewShaderReplace"}: invalid argument #{_lastArgPos}: {_lastArg} ({_lastArg.Type}), expected: {_expectedType.FullName}", 2);
        });
        private static readonly global::Lua.LuaFunction __index = new(global::Lua.Runtime.Metamethods.Index, (_context, _) =>
        {
            var _this = _context.GetArgument<LuaSceneView>(0);
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
            var _this = _context.GetArgument<LuaSceneView>(0);
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
                case "AddItemsToMenu": _value = _LuaSceneView_AddItemsToMenu; return true;
                case "AlignViewToObject": _value = _LuaSceneView_AlignViewToObject; return true;
                case "AlignWithView": _value = _LuaSceneView_AlignWithView; return true;
                case "FixNegativeSize": _value = _LuaSceneView_FixNegativeSize; return true;
                case "Frame": _value = _LuaSceneView_Frame; return true;
                case "FrameSelected": _value = _LuaSceneView_FrameSelected; return true;
                case "IsCameraDrawModeEnabled": _value = _LuaSceneView_IsCameraDrawModeEnabled; return true;
                case "IsCameraDrawModeSupported": _value = _LuaSceneView_IsCameraDrawModeSupported; return true;
                case "LookAt": _value = _LuaSceneView_LookAt; return true;
                case "LookAtDirect": _value = _LuaSceneView_LookAtDirect; return true;
                case "MoveToView": _value = _LuaSceneView_MoveToView; return true;
                case "OnDestroy": _value = _LuaSceneView_OnDestroy; return true;
                case "OnDisable": _value = _LuaSceneView_OnDisable; return true;
                case "OnEnable": _value = _LuaSceneView_OnEnable; return true;
                case "ResetCameraSettings": _value = _LuaSceneView_ResetCameraSettings; return true;
                case "SetSceneViewShaderReplace": _value = _LuaSceneView_SetSceneViewShaderReplace; return true;
                case "audioPlay": _value = new global::Lua.LuaValue(Instance.audioPlay); return true;
                case "camera": _value = _factory.Bind(Instance.camera); return true;
                case "cameraDistance": _value = new global::Lua.LuaValue(Instance.cameraDistance); return true;
                case "cameraMode": _value = global::Luny.UnityEditor.LuaSceneViewCameraMode.Bind(Instance.cameraMode); return true;
                case "cameraSettings": _value = _factory.Bind(Instance.cameraSettings); return true;
                case "cameraViewport": _value = _factory.Bind(Instance.cameraViewport); return true;
                case "drawGizmos": _value = new global::Lua.LuaValue(Instance.drawGizmos); return true;
                case "in2DMode": _value = new global::Lua.LuaValue(Instance.in2DMode); return true;
                case "isRotationLocked": _value = new global::Lua.LuaValue(Instance.isRotationLocked); return true;
                case "isUsingSceneFiltering": _value = new global::Lua.LuaValue(Instance.isUsingSceneFiltering); return true;
                case "lastSceneViewRotation": _value = _factory.Bind(Instance.lastSceneViewRotation); return true;
                case "orthographic": _value = new global::Lua.LuaValue(Instance.orthographic); return true;
                case "pivot": _value = _factory.Bind(Instance.pivot); return true;
                case "rotation": _value = _factory.Bind(Instance.rotation); return true;
                case "sceneLighting": _value = new global::Lua.LuaValue(Instance.sceneLighting); return true;
                case "sceneViewState": _value = _factory.Bind(Instance.sceneViewState); return true;
                case "showGrid": _value = new global::Lua.LuaValue(Instance.showGrid); return true;
                case "size": _value = new global::Lua.LuaValue(Instance.size); return true;
                case "validateTrueMetals": _value = new global::Lua.LuaValue(Instance.validateTrueMetals); return true;
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
                case "audioPlay": Instance.audioPlay = _value.Read<global::System.Boolean>();  return true;
                case "cameraMode": Instance.cameraMode = _value.Read<global::Luny.UnityEditor.LuaSceneViewCameraMode>().Value;  return true;
                case "cameraSettings": Instance.cameraSettings = _value.Read<global::Luny.UnityEditor.LuaSceneViewCameraSettings>().Instance;  return true;
                case "drawGizmos": Instance.drawGizmos = _value.Read<global::System.Boolean>();  return true;
                case "in2DMode": Instance.in2DMode = _value.Read<global::System.Boolean>();  return true;
                case "isRotationLocked": Instance.isRotationLocked = _value.Read<global::System.Boolean>();  return true;
                case "lastSceneViewRotation": Instance.lastSceneViewRotation = _value.Read<global::UnityEngine.Quaternion>();  return true;
                case "orthographic": Instance.orthographic = _value.Read<global::System.Boolean>();  return true;
                case "pivot": Instance.pivot = _value.Read<global::UnityEngine.Vector3>();  return true;
                case "rotation": Instance.rotation = _value.Read<global::UnityEngine.Quaternion>();  return true;
                case "sceneLighting": Instance.sceneLighting = _value.Read<global::System.Boolean>();  return true;
                case "sceneViewState": Instance.sceneViewState = _value.Read<global::Luny.UnityEditor.LuaSceneViewSceneViewState>().Instance;  return true;
                case "showGrid": Instance.showGrid = _value.Read<global::System.Boolean>();  return true;
                case "size": Instance.size = _value.Read<global::System.Single>();  return true;
                case "validateTrueMetals": Instance.validateTrueMetals = _value.Read<global::System.Boolean>();  return true;
                default: return base.TrySetLuaValue(_key, _value);
            }
        }
    }
    public sealed class LuaSceneViewType : global::Luny.ILuaStatic
    {
        public static global::Lua.LuaValue Bind() => new LuaSceneViewType();
        private LuaSceneViewType() {}
        public static implicit operator global::Lua.LuaValue(LuaSceneViewType value) => new(value);
        public global::System.Type BindType => typeof(global::UnityEditor.SceneView);
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

        private static readonly global::Lua.LuaFunction _LuaSceneView_new = new global::Lua.LuaFunction(".ctor", (_context, _) =>
        {
            global::Lua.LuaValue _lastArg = default;
            global::System.Int32 _lastArgPos = default;
            global::System.Type _expectedType = default;
            var _argCount = _context.ArgumentCount;
            if (_argCount == 0)
            {
                var _ret0 = new global::UnityEditor.SceneView();
                var _factory = _context.GetObjectFactory();
                var _lret0 = _factory.Bind(_ret0);
                var _retCount = _context.Return(_lret0);
                return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
            }
            throw new global::Lua.LuaRuntimeException(_context.Thread, $"{".ctor"}: invalid argument #{_lastArgPos}: {_lastArg} ({_lastArg.Type}), expected: {_expectedType.FullName}", 2);
        });
        private static readonly global::Lua.LuaFunction _LuaSceneView_AddCameraMode = new global::Lua.LuaFunction("AddCameraMode", (_context, _) =>
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
                _lastArgPos = 1; _expectedType = typeof(global::System.String);
                if (_arg1.TryRead<global::System.String>(out var _p1_System_String))
                {
                    if (_argCount == 2)
                    {
                        var name = _p0_System_String;
                        var section = _p1_System_String;
                        var _ret0 = global::UnityEditor.SceneView.AddCameraMode(name, section);
                        var _lret0 = global::Luny.UnityEditor.LuaSceneViewCameraMode.Bind(_ret0);
                        var _retCount = _context.Return(_lret0);
                        return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                    }
                }
            }
            throw new global::Lua.LuaRuntimeException(_context.Thread, $"{"AddCameraMode"}: invalid argument #{_lastArgPos}: {_lastArg} ({_lastArg.Type}), expected: {_expectedType.FullName}", 2);
        });
        private static readonly global::Lua.LuaFunction _LuaSceneView_ClearUserDefinedCameraModes = new global::Lua.LuaFunction("ClearUserDefinedCameraModes", (_context, _) =>
        {
            global::Lua.LuaValue _lastArg = default;
            global::System.Int32 _lastArgPos = default;
            global::System.Type _expectedType = default;
            var _argCount = _context.ArgumentCount;
            if (_argCount == 0)
            {
                global::UnityEditor.SceneView.ClearUserDefinedCameraModes();
                var _retCount = _context.Return();
                return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
            }
            throw new global::Lua.LuaRuntimeException(_context.Thread, $"{"ClearUserDefinedCameraModes"}: invalid argument #{_lastArgPos}: {_lastArg} ({_lastArg.Type}), expected: {_expectedType.FullName}", 2);
        });
        private static readonly global::Lua.LuaFunction _LuaSceneView_FrameLastActiveSceneView = new global::Lua.LuaFunction("FrameLastActiveSceneView", (_context, _) =>
        {
            global::Lua.LuaValue _lastArg = default;
            global::System.Int32 _lastArgPos = default;
            global::System.Type _expectedType = default;
            var _argCount = _context.ArgumentCount;
            if (_argCount == 0)
            {
                var _ret0 = global::UnityEditor.SceneView.FrameLastActiveSceneView();
                var _lret0 = new global::Lua.LuaValue(_ret0);
                var _retCount = _context.Return(_lret0);
                return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
            }
            throw new global::Lua.LuaRuntimeException(_context.Thread, $"{"FrameLastActiveSceneView"}: invalid argument #{_lastArgPos}: {_lastArg} ({_lastArg.Type}), expected: {_expectedType.FullName}", 2);
        });
        private static readonly global::Lua.LuaFunction _LuaSceneView_FrameLastActiveSceneViewWithLock = new global::Lua.LuaFunction("FrameLastActiveSceneViewWithLock", (_context, _) =>
        {
            global::Lua.LuaValue _lastArg = default;
            global::System.Int32 _lastArgPos = default;
            global::System.Type _expectedType = default;
            var _argCount = _context.ArgumentCount;
            if (_argCount == 0)
            {
                var _ret0 = global::UnityEditor.SceneView.FrameLastActiveSceneViewWithLock();
                var _lret0 = new global::Lua.LuaValue(_ret0);
                var _retCount = _context.Return(_lret0);
                return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
            }
            throw new global::Lua.LuaRuntimeException(_context.Thread, $"{"FrameLastActiveSceneViewWithLock"}: invalid argument #{_lastArgPos}: {_lastArg} ({_lastArg.Type}), expected: {_expectedType.FullName}", 2);
        });
        private static readonly global::Lua.LuaFunction _LuaSceneView_GetAllSceneCameras = new global::Lua.LuaFunction("GetAllSceneCameras", (_context, _) =>
        {
            global::Lua.LuaValue _lastArg = default;
            global::System.Int32 _lastArgPos = default;
            global::System.Type _expectedType = default;
            var _argCount = _context.ArgumentCount;
            if (_argCount == 0)
            {
                var _ret0 = global::UnityEditor.SceneView.GetAllSceneCameras();
                var _factory = _context.GetObjectFactory();
                var _lret0 = _factory.Bind(_ret0);
                var _retCount = _context.Return(_lret0);
                return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
            }
            throw new global::Lua.LuaRuntimeException(_context.Thread, $"{"GetAllSceneCameras"}: invalid argument #{_lastArgPos}: {_lastArg} ({_lastArg.Type}), expected: {_expectedType.FullName}", 2);
        });
        private static readonly global::Lua.LuaFunction _LuaSceneView_GetBuiltinCameraMode = new global::Lua.LuaFunction("GetBuiltinCameraMode", (_context, _) =>
        {
            global::Lua.LuaValue _lastArg = default;
            global::System.Int32 _lastArgPos = default;
            global::System.Type _expectedType = default;
            var _argCount = _context.ArgumentCount;
            var _arg0 = _lastArg = _argCount > 0 ? _context.GetArgument(0) : global::Lua.LuaValue.Nil;
            _lastArgPos = 0; _expectedType = typeof(global::UnityEditor.DrawCameraMode);
            if (_arg0.TryRead<global::UnityEditor.DrawCameraMode>(out var _p0_UnityEditor_DrawCameraMode))
            {
                if (_argCount == 1)
                {
                    var mode = _p0_UnityEditor_DrawCameraMode;
                    var _ret0 = global::UnityEditor.SceneView.GetBuiltinCameraMode(mode);
                    var _lret0 = global::Luny.UnityEditor.LuaSceneViewCameraMode.Bind(_ret0);
                    var _retCount = _context.Return(_lret0);
                    return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                }
            }
            throw new global::Lua.LuaRuntimeException(_context.Thread, $"{"GetBuiltinCameraMode"}: invalid argument #{_lastArgPos}: {_lastArg} ({_lastArg.Type}), expected: {_expectedType.FullName}", 2);
        });
        private static readonly global::Lua.LuaFunction _LuaSceneView_RepaintAll = new global::Lua.LuaFunction("RepaintAll", (_context, _) =>
        {
            global::Lua.LuaValue _lastArg = default;
            global::System.Int32 _lastArgPos = default;
            global::System.Type _expectedType = default;
            var _argCount = _context.ArgumentCount;
            if (_argCount == 0)
            {
                global::UnityEditor.SceneView.RepaintAll();
                var _retCount = _context.Return();
                return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
            }
            throw new global::Lua.LuaRuntimeException(_context.Thread, $"{"RepaintAll"}: invalid argument #{_lastArgPos}: {_lastArg} ({_lastArg.Type}), expected: {_expectedType.FullName}", 2);
        });
        private static readonly global::Lua.LuaFunction __index = new(global::Lua.Runtime.Metamethods.Index, (_context, _) =>
        {
            var _this = _context.GetArgument<LuaSceneViewType>(0);
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
            var _this = _context.GetArgument<LuaSceneViewType>(0);
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
                case "new": _value = _LuaSceneView_new; return true;
                case "AddCameraMode": _value = _LuaSceneView_AddCameraMode; return true;
                case "ClearUserDefinedCameraModes": _value = _LuaSceneView_ClearUserDefinedCameraModes; return true;
                case "FrameLastActiveSceneView": _value = _LuaSceneView_FrameLastActiveSceneView; return true;
                case "FrameLastActiveSceneViewWithLock": _value = _LuaSceneView_FrameLastActiveSceneViewWithLock; return true;
                case "GetAllSceneCameras": _value = _LuaSceneView_GetAllSceneCameras; return true;
                case "GetBuiltinCameraMode": _value = _LuaSceneView_GetBuiltinCameraMode; return true;
                case "RepaintAll": _value = _LuaSceneView_RepaintAll; return true;
                case "currentDrawingSceneView": _value = _factory.Bind(global::UnityEditor.SceneView.currentDrawingSceneView); return true;
                case "lastActiveSceneView": _value = _factory.Bind(global::UnityEditor.SceneView.lastActiveSceneView); return true;
                case "sceneViews": _value = _factory.Bind(global::UnityEditor.SceneView.sceneViews); return true;
                case "selectedOutlineColor": _value = _factory.Bind(global::UnityEditor.SceneView.selectedOutlineColor); return true;
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
