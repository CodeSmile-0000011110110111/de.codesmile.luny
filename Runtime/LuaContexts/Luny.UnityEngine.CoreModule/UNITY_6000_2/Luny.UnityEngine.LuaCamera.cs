
// --------------------------------------------------------------
// GENERATED FILE ----> DO NOT EDIT <---- CHANGES WILL BE LOST !!
// --------------------------------------------------------------

#if UNITY_6000_2_OR_NEWER && !(UNITY_6000_3_OR_NEWER)
#pragma warning disable 0109, 0162, 0168, 0219
using Luny;

namespace Luny.UnityEngine
{
    public sealed class LuaCamera : LuaBehaviour, global::Luny.ILuaObject<global::UnityEngine.Camera>
    {
        public new static global::Lua.LuaValue Bind(global::UnityEngine.Camera instance) => new LuaCamera(instance);
        public new static global::Lua.LuaValue Bind(global::System.Object instance) => Bind((global::UnityEngine.Camera)instance);
        public new static global::Lua.LuaValue Bind(global::System.Collections.Generic.IList<global::UnityEngine.Camera> instances) =>
            new global::Luny.LuaList<global::UnityEngine.Camera>(instances);
        public new static global::Lua.LuaValue Bind(global::System.Collections.Generic.IList<global::System.Object> instances) =>
            new global::Luny.LuaList<global::UnityEngine.Camera>(instances);
        private LuaCamera(global::UnityEngine.Camera instance) : base(instance) {}
        public static implicit operator global::Lua.LuaValue(LuaCamera value) => new(value);
        public new global::UnityEngine.Camera Instance => (global::UnityEngine.Camera)m_Instance;
        public new global::System.Type BindType => typeof(global::UnityEngine.Camera);
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

        private static readonly global::Lua.LuaFunction _LuaCamera_AddCommandBuffer = new global::Lua.LuaFunction("AddCommandBuffer", (_context, _) =>
        {
            global::Lua.LuaValue _lastArg = default;
            global::System.Int32 _lastArgPos = default;
            global::System.Type _expectedType = default;
            var _argCount = _context.ArgumentCount;
            var _this = _context.GetArgument<LuaCamera>(0);
            var _arg0 = _lastArg = _argCount > 1 ? _context.GetArgument(1) : global::Lua.LuaValue.Nil;
            _lastArgPos = 0; _expectedType = typeof(global::UnityEngine.Rendering.CameraEvent);
            if (_arg0.TryRead<global::UnityEngine.Rendering.CameraEvent>(out var _p0_UnityEngine_Rendering_CameraEvent))
            {
                var _arg1 = _lastArg = _argCount > 2 ? _context.GetArgument(2) : global::Lua.LuaValue.Nil;
                _lastArgPos = 1; _expectedType = typeof(global::Luny.UnityEngine.Rendering.LuaCommandBuffer);
                if (_arg1.TryRead<global::Luny.UnityEngine.Rendering.LuaCommandBuffer>(out var _p1_UnityEngine_Rendering_CommandBuffer))
                {
                    if (_argCount == 3)
                    {
                        var evt = _p0_UnityEngine_Rendering_CameraEvent;
                        var buffer = _p1_UnityEngine_Rendering_CommandBuffer.Instance;
                        _this.Instance.AddCommandBuffer(evt, buffer);
                        var _retCount = _context.Return();
                        return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                    }
                }
            }
            throw new global::Lua.LuaRuntimeException(_context.Thread, $"{"AddCommandBuffer"}: invalid argument #{_lastArgPos}: {_lastArg} ({_lastArg.Type}), expected: {_expectedType.FullName}", 2);
        });
        private static readonly global::Lua.LuaFunction _LuaCamera_AddCommandBufferAsync = new global::Lua.LuaFunction("AddCommandBufferAsync", (_context, _) =>
        {
            global::Lua.LuaValue _lastArg = default;
            global::System.Int32 _lastArgPos = default;
            global::System.Type _expectedType = default;
            var _argCount = _context.ArgumentCount;
            var _this = _context.GetArgument<LuaCamera>(0);
            var _arg0 = _lastArg = _argCount > 1 ? _context.GetArgument(1) : global::Lua.LuaValue.Nil;
            _lastArgPos = 0; _expectedType = typeof(global::UnityEngine.Rendering.CameraEvent);
            if (_arg0.TryRead<global::UnityEngine.Rendering.CameraEvent>(out var _p0_UnityEngine_Rendering_CameraEvent))
            {
                var _arg1 = _lastArg = _argCount > 2 ? _context.GetArgument(2) : global::Lua.LuaValue.Nil;
                _lastArgPos = 1; _expectedType = typeof(global::Luny.UnityEngine.Rendering.LuaCommandBuffer);
                if (_arg1.TryRead<global::Luny.UnityEngine.Rendering.LuaCommandBuffer>(out var _p1_UnityEngine_Rendering_CommandBuffer))
                {
                    var _arg2 = _lastArg = _argCount > 3 ? _context.GetArgument(3) : global::Lua.LuaValue.Nil;
                    _lastArgPos = 2; _expectedType = typeof(global::UnityEngine.Rendering.ComputeQueueType);
                    if (_arg2.TryRead<global::UnityEngine.Rendering.ComputeQueueType>(out var _p2_UnityEngine_Rendering_ComputeQueueType))
                    {
                        if (_argCount == 4)
                        {
                            var evt = _p0_UnityEngine_Rendering_CameraEvent;
                            var buffer = _p1_UnityEngine_Rendering_CommandBuffer.Instance;
                            var queueType = _p2_UnityEngine_Rendering_ComputeQueueType;
                            _this.Instance.AddCommandBufferAsync(evt, buffer, queueType);
                            var _retCount = _context.Return();
                            return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                        }
                    }
                }
            }
            throw new global::Lua.LuaRuntimeException(_context.Thread, $"{"AddCommandBufferAsync"}: invalid argument #{_lastArgPos}: {_lastArg} ({_lastArg.Type}), expected: {_expectedType.FullName}", 2);
        });
        private static readonly global::Lua.LuaFunction _LuaCamera_CalculateFrustumCorners = new global::Lua.LuaFunction("CalculateFrustumCorners", (_context, _) =>
        {
            global::Lua.LuaValue _lastArg = default;
            global::System.Int32 _lastArgPos = default;
            global::System.Type _expectedType = default;
            var _argCount = _context.ArgumentCount;
            var _this = _context.GetArgument<LuaCamera>(0);
            var _arg0 = _lastArg = _argCount > 1 ? _context.GetArgument(1) : global::Lua.LuaValue.Nil;
            _lastArgPos = 0; _expectedType = typeof(global::Luny.UnityEngine.LuaRect);
            if (_arg0.TryRead<global::Luny.UnityEngine.LuaRect>(out var _p0_UnityEngine_Rect))
            {
                var _arg1 = _lastArg = _argCount > 2 ? _context.GetArgument(2) : global::Lua.LuaValue.Nil;
                _lastArgPos = 1; _expectedType = typeof(global::System.Single);
                if (_arg1.TryRead<global::System.Single>(out var _p1_System_Single))
                {
                    var _arg2 = _lastArg = _argCount > 3 ? _context.GetArgument(3) : global::Lua.LuaValue.Nil;
                    _lastArgPos = 2; _expectedType = typeof(global::UnityEngine.Camera.MonoOrStereoscopicEye);
                    if (_arg2.TryRead<global::UnityEngine.Camera.MonoOrStereoscopicEye>(out var _p2_UnityEngine_Camera_MonoOrStereoscopicEye))
                    {
                        var _arg3 = _lastArg = _argCount > 4 ? _context.GetArgument(4) : global::Lua.LuaValue.Nil;
                        _lastArgPos = 3; _expectedType = typeof(global::UnityEngine.Vector3[]);
                        if (_arg3.TryReadArray<global::UnityEngine.Vector3>(out var _p3_UnityEngine_Vector3Array))
                        {
                            if (_argCount == 5)
                            {
                                var viewport = _p0_UnityEngine_Rect.Value;
                                var z = _p1_System_Single;
                                var eye = _p2_UnityEngine_Camera_MonoOrStereoscopicEye;
                                var outCorners = _p3_UnityEngine_Vector3Array;
                                _this.Instance.CalculateFrustumCorners(viewport, z, eye, outCorners);
                                var _retCount = _context.Return();
                                return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                            }
                        }
                    }
                }
            }
            throw new global::Lua.LuaRuntimeException(_context.Thread, $"{"CalculateFrustumCorners"}: invalid argument #{_lastArgPos}: {_lastArg} ({_lastArg.Type}), expected: {_expectedType.FullName}", 2);
        });
        private static readonly global::Lua.LuaFunction _LuaCamera_CalculateObliqueMatrix = new global::Lua.LuaFunction("CalculateObliqueMatrix", (_context, _) =>
        {
            global::Lua.LuaValue _lastArg = default;
            global::System.Int32 _lastArgPos = default;
            global::System.Type _expectedType = default;
            var _argCount = _context.ArgumentCount;
            var _this = _context.GetArgument<LuaCamera>(0);
            var _arg0 = _lastArg = _argCount > 1 ? _context.GetArgument(1) : global::Lua.LuaValue.Nil;
            _lastArgPos = 0; _expectedType = typeof(global::Luny.UnityEngine.LuaVector4);
            if (_arg0.TryRead<global::Luny.UnityEngine.LuaVector4>(out var _p0_UnityEngine_Vector4))
            {
                if (_argCount == 2)
                {
                    var clipPlane = _p0_UnityEngine_Vector4.Value;
                    var _ret0 = _this.Instance.CalculateObliqueMatrix(clipPlane);
                    var _lret0 = global::Luny.UnityEngine.LuaMatrix4x4.Bind(_ret0);
                    var _retCount = _context.Return(_lret0);
                    return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                }
            }
            throw new global::Lua.LuaRuntimeException(_context.Thread, $"{"CalculateObliqueMatrix"}: invalid argument #{_lastArgPos}: {_lastArg} ({_lastArg.Type}), expected: {_expectedType.FullName}", 2);
        });
        private static readonly global::Lua.LuaFunction _LuaCamera_CopyFrom = new global::Lua.LuaFunction("CopyFrom", (_context, _) =>
        {
            global::Lua.LuaValue _lastArg = default;
            global::System.Int32 _lastArgPos = default;
            global::System.Type _expectedType = default;
            var _argCount = _context.ArgumentCount;
            var _this = _context.GetArgument<LuaCamera>(0);
            var _arg0 = _lastArg = _argCount > 1 ? _context.GetArgument(1) : global::Lua.LuaValue.Nil;
            _lastArgPos = 0; _expectedType = typeof(global::Luny.UnityEngine.LuaCamera);
            if (_arg0.TryRead<global::Luny.UnityEngine.LuaCamera>(out var _p0_UnityEngine_Camera))
            {
                if (_argCount == 2)
                {
                    var other = _p0_UnityEngine_Camera.Instance;
                    _this.Instance.CopyFrom(other);
                    var _retCount = _context.Return();
                    return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                }
            }
            throw new global::Lua.LuaRuntimeException(_context.Thread, $"{"CopyFrom"}: invalid argument #{_lastArgPos}: {_lastArg} ({_lastArg.Type}), expected: {_expectedType.FullName}", 2);
        });
        private static readonly global::Lua.LuaFunction _LuaCamera_CopyStereoDeviceProjectionMatrixToNonJittered = new global::Lua.LuaFunction("CopyStereoDeviceProjectionMatrixToNonJittered", (_context, _) =>
        {
            global::Lua.LuaValue _lastArg = default;
            global::System.Int32 _lastArgPos = default;
            global::System.Type _expectedType = default;
            var _argCount = _context.ArgumentCount;
            var _this = _context.GetArgument<LuaCamera>(0);
            var _arg0 = _lastArg = _argCount > 1 ? _context.GetArgument(1) : global::Lua.LuaValue.Nil;
            _lastArgPos = 0; _expectedType = typeof(global::UnityEngine.Camera.StereoscopicEye);
            if (_arg0.TryRead<global::UnityEngine.Camera.StereoscopicEye>(out var _p0_UnityEngine_Camera_StereoscopicEye))
            {
                if (_argCount == 2)
                {
                    var eye = _p0_UnityEngine_Camera_StereoscopicEye;
                    _this.Instance.CopyStereoDeviceProjectionMatrixToNonJittered(eye);
                    var _retCount = _context.Return();
                    return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                }
            }
            throw new global::Lua.LuaRuntimeException(_context.Thread, $"{"CopyStereoDeviceProjectionMatrixToNonJittered"}: invalid argument #{_lastArgPos}: {_lastArg} ({_lastArg.Type}), expected: {_expectedType.FullName}", 2);
        });
        private static readonly global::Lua.LuaFunction _LuaCamera_GetCommandBuffers = new global::Lua.LuaFunction("GetCommandBuffers", (_context, _) =>
        {
            global::Lua.LuaValue _lastArg = default;
            global::System.Int32 _lastArgPos = default;
            global::System.Type _expectedType = default;
            var _argCount = _context.ArgumentCount;
            var _this = _context.GetArgument<LuaCamera>(0);
            var _arg0 = _lastArg = _argCount > 1 ? _context.GetArgument(1) : global::Lua.LuaValue.Nil;
            _lastArgPos = 0; _expectedType = typeof(global::UnityEngine.Rendering.CameraEvent);
            if (_arg0.TryRead<global::UnityEngine.Rendering.CameraEvent>(out var _p0_UnityEngine_Rendering_CameraEvent))
            {
                if (_argCount == 2)
                {
                    var evt = _p0_UnityEngine_Rendering_CameraEvent;
                    var _ret0 = _this.Instance.GetCommandBuffers(evt);
                    var _factory = _context.GetObjectFactory();
                    var _lret0 = _factory.Bind(_ret0);
                    var _retCount = _context.Return(_lret0);
                    return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                }
            }
            throw new global::Lua.LuaRuntimeException(_context.Thread, $"{"GetCommandBuffers"}: invalid argument #{_lastArgPos}: {_lastArg} ({_lastArg.Type}), expected: {_expectedType.FullName}", 2);
        });
        private static readonly global::Lua.LuaFunction _LuaCamera_GetGateFittedFieldOfView = new global::Lua.LuaFunction("GetGateFittedFieldOfView", (_context, _) =>
        {
            global::Lua.LuaValue _lastArg = default;
            global::System.Int32 _lastArgPos = default;
            global::System.Type _expectedType = default;
            var _argCount = _context.ArgumentCount;
            var _this = _context.GetArgument<LuaCamera>(0);
            if (_argCount == 1)
            {
                var _ret0 = _this.Instance.GetGateFittedFieldOfView();
                var _lret0 = new global::Lua.LuaValue(_ret0);
                var _retCount = _context.Return(_lret0);
                return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
            }
            throw new global::Lua.LuaRuntimeException(_context.Thread, $"{"GetGateFittedFieldOfView"}: invalid argument #{_lastArgPos}: {_lastArg} ({_lastArg.Type}), expected: {_expectedType.FullName}", 2);
        });
        private static readonly global::Lua.LuaFunction _LuaCamera_GetGateFittedLensShift = new global::Lua.LuaFunction("GetGateFittedLensShift", (_context, _) =>
        {
            global::Lua.LuaValue _lastArg = default;
            global::System.Int32 _lastArgPos = default;
            global::System.Type _expectedType = default;
            var _argCount = _context.ArgumentCount;
            var _this = _context.GetArgument<LuaCamera>(0);
            if (_argCount == 1)
            {
                var _ret0 = _this.Instance.GetGateFittedLensShift();
                var _lret0 = global::Luny.UnityEngine.LuaVector2.Bind(_ret0);
                var _retCount = _context.Return(_lret0);
                return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
            }
            throw new global::Lua.LuaRuntimeException(_context.Thread, $"{"GetGateFittedLensShift"}: invalid argument #{_lastArgPos}: {_lastArg} ({_lastArg.Type}), expected: {_expectedType.FullName}", 2);
        });
        private static readonly global::Lua.LuaFunction _LuaCamera_GetStereoNonJitteredProjectionMatrix = new global::Lua.LuaFunction("GetStereoNonJitteredProjectionMatrix", (_context, _) =>
        {
            global::Lua.LuaValue _lastArg = default;
            global::System.Int32 _lastArgPos = default;
            global::System.Type _expectedType = default;
            var _argCount = _context.ArgumentCount;
            var _this = _context.GetArgument<LuaCamera>(0);
            var _arg0 = _lastArg = _argCount > 1 ? _context.GetArgument(1) : global::Lua.LuaValue.Nil;
            _lastArgPos = 0; _expectedType = typeof(global::UnityEngine.Camera.StereoscopicEye);
            if (_arg0.TryRead<global::UnityEngine.Camera.StereoscopicEye>(out var _p0_UnityEngine_Camera_StereoscopicEye))
            {
                if (_argCount == 2)
                {
                    var eye = _p0_UnityEngine_Camera_StereoscopicEye;
                    var _ret0 = _this.Instance.GetStereoNonJitteredProjectionMatrix(eye);
                    var _lret0 = global::Luny.UnityEngine.LuaMatrix4x4.Bind(_ret0);
                    var _retCount = _context.Return(_lret0);
                    return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                }
            }
            throw new global::Lua.LuaRuntimeException(_context.Thread, $"{"GetStereoNonJitteredProjectionMatrix"}: invalid argument #{_lastArgPos}: {_lastArg} ({_lastArg.Type}), expected: {_expectedType.FullName}", 2);
        });
        private static readonly global::Lua.LuaFunction _LuaCamera_GetStereoProjectionMatrix = new global::Lua.LuaFunction("GetStereoProjectionMatrix", (_context, _) =>
        {
            global::Lua.LuaValue _lastArg = default;
            global::System.Int32 _lastArgPos = default;
            global::System.Type _expectedType = default;
            var _argCount = _context.ArgumentCount;
            var _this = _context.GetArgument<LuaCamera>(0);
            var _arg0 = _lastArg = _argCount > 1 ? _context.GetArgument(1) : global::Lua.LuaValue.Nil;
            _lastArgPos = 0; _expectedType = typeof(global::UnityEngine.Camera.StereoscopicEye);
            if (_arg0.TryRead<global::UnityEngine.Camera.StereoscopicEye>(out var _p0_UnityEngine_Camera_StereoscopicEye))
            {
                if (_argCount == 2)
                {
                    var eye = _p0_UnityEngine_Camera_StereoscopicEye;
                    var _ret0 = _this.Instance.GetStereoProjectionMatrix(eye);
                    var _lret0 = global::Luny.UnityEngine.LuaMatrix4x4.Bind(_ret0);
                    var _retCount = _context.Return(_lret0);
                    return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                }
            }
            throw new global::Lua.LuaRuntimeException(_context.Thread, $"{"GetStereoProjectionMatrix"}: invalid argument #{_lastArgPos}: {_lastArg} ({_lastArg.Type}), expected: {_expectedType.FullName}", 2);
        });
        private static readonly global::Lua.LuaFunction _LuaCamera_GetStereoViewMatrix = new global::Lua.LuaFunction("GetStereoViewMatrix", (_context, _) =>
        {
            global::Lua.LuaValue _lastArg = default;
            global::System.Int32 _lastArgPos = default;
            global::System.Type _expectedType = default;
            var _argCount = _context.ArgumentCount;
            var _this = _context.GetArgument<LuaCamera>(0);
            var _arg0 = _lastArg = _argCount > 1 ? _context.GetArgument(1) : global::Lua.LuaValue.Nil;
            _lastArgPos = 0; _expectedType = typeof(global::UnityEngine.Camera.StereoscopicEye);
            if (_arg0.TryRead<global::UnityEngine.Camera.StereoscopicEye>(out var _p0_UnityEngine_Camera_StereoscopicEye))
            {
                if (_argCount == 2)
                {
                    var eye = _p0_UnityEngine_Camera_StereoscopicEye;
                    var _ret0 = _this.Instance.GetStereoViewMatrix(eye);
                    var _lret0 = global::Luny.UnityEngine.LuaMatrix4x4.Bind(_ret0);
                    var _retCount = _context.Return(_lret0);
                    return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                }
            }
            throw new global::Lua.LuaRuntimeException(_context.Thread, $"{"GetStereoViewMatrix"}: invalid argument #{_lastArgPos}: {_lastArg} ({_lastArg.Type}), expected: {_expectedType.FullName}", 2);
        });
        private static readonly global::Lua.LuaFunction _LuaCamera_RemoveAllCommandBuffers = new global::Lua.LuaFunction("RemoveAllCommandBuffers", (_context, _) =>
        {
            global::Lua.LuaValue _lastArg = default;
            global::System.Int32 _lastArgPos = default;
            global::System.Type _expectedType = default;
            var _argCount = _context.ArgumentCount;
            var _this = _context.GetArgument<LuaCamera>(0);
            if (_argCount == 1)
            {
                _this.Instance.RemoveAllCommandBuffers();
                var _retCount = _context.Return();
                return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
            }
            throw new global::Lua.LuaRuntimeException(_context.Thread, $"{"RemoveAllCommandBuffers"}: invalid argument #{_lastArgPos}: {_lastArg} ({_lastArg.Type}), expected: {_expectedType.FullName}", 2);
        });
        private static readonly global::Lua.LuaFunction _LuaCamera_RemoveCommandBuffer = new global::Lua.LuaFunction("RemoveCommandBuffer", (_context, _) =>
        {
            global::Lua.LuaValue _lastArg = default;
            global::System.Int32 _lastArgPos = default;
            global::System.Type _expectedType = default;
            var _argCount = _context.ArgumentCount;
            var _this = _context.GetArgument<LuaCamera>(0);
            var _arg0 = _lastArg = _argCount > 1 ? _context.GetArgument(1) : global::Lua.LuaValue.Nil;
            _lastArgPos = 0; _expectedType = typeof(global::UnityEngine.Rendering.CameraEvent);
            if (_arg0.TryRead<global::UnityEngine.Rendering.CameraEvent>(out var _p0_UnityEngine_Rendering_CameraEvent))
            {
                var _arg1 = _lastArg = _argCount > 2 ? _context.GetArgument(2) : global::Lua.LuaValue.Nil;
                _lastArgPos = 1; _expectedType = typeof(global::Luny.UnityEngine.Rendering.LuaCommandBuffer);
                if (_arg1.TryRead<global::Luny.UnityEngine.Rendering.LuaCommandBuffer>(out var _p1_UnityEngine_Rendering_CommandBuffer))
                {
                    if (_argCount == 3)
                    {
                        var evt = _p0_UnityEngine_Rendering_CameraEvent;
                        var buffer = _p1_UnityEngine_Rendering_CommandBuffer.Instance;
                        _this.Instance.RemoveCommandBuffer(evt, buffer);
                        var _retCount = _context.Return();
                        return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                    }
                }
            }
            throw new global::Lua.LuaRuntimeException(_context.Thread, $"{"RemoveCommandBuffer"}: invalid argument #{_lastArgPos}: {_lastArg} ({_lastArg.Type}), expected: {_expectedType.FullName}", 2);
        });
        private static readonly global::Lua.LuaFunction _LuaCamera_RemoveCommandBuffers = new global::Lua.LuaFunction("RemoveCommandBuffers", (_context, _) =>
        {
            global::Lua.LuaValue _lastArg = default;
            global::System.Int32 _lastArgPos = default;
            global::System.Type _expectedType = default;
            var _argCount = _context.ArgumentCount;
            var _this = _context.GetArgument<LuaCamera>(0);
            var _arg0 = _lastArg = _argCount > 1 ? _context.GetArgument(1) : global::Lua.LuaValue.Nil;
            _lastArgPos = 0; _expectedType = typeof(global::UnityEngine.Rendering.CameraEvent);
            if (_arg0.TryRead<global::UnityEngine.Rendering.CameraEvent>(out var _p0_UnityEngine_Rendering_CameraEvent))
            {
                if (_argCount == 2)
                {
                    var evt = _p0_UnityEngine_Rendering_CameraEvent;
                    _this.Instance.RemoveCommandBuffers(evt);
                    var _retCount = _context.Return();
                    return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                }
            }
            throw new global::Lua.LuaRuntimeException(_context.Thread, $"{"RemoveCommandBuffers"}: invalid argument #{_lastArgPos}: {_lastArg} ({_lastArg.Type}), expected: {_expectedType.FullName}", 2);
        });
        private static readonly global::Lua.LuaFunction _LuaCamera_Render = new global::Lua.LuaFunction("Render", (_context, _) =>
        {
            global::Lua.LuaValue _lastArg = default;
            global::System.Int32 _lastArgPos = default;
            global::System.Type _expectedType = default;
            var _argCount = _context.ArgumentCount;
            var _this = _context.GetArgument<LuaCamera>(0);
            if (_argCount == 1)
            {
                _this.Instance.Render();
                var _retCount = _context.Return();
                return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
            }
            throw new global::Lua.LuaRuntimeException(_context.Thread, $"{"Render"}: invalid argument #{_lastArgPos}: {_lastArg} ({_lastArg.Type}), expected: {_expectedType.FullName}", 2);
        });
        private static readonly global::Lua.LuaFunction _LuaCamera_RenderDontRestore = new global::Lua.LuaFunction("RenderDontRestore", (_context, _) =>
        {
            global::Lua.LuaValue _lastArg = default;
            global::System.Int32 _lastArgPos = default;
            global::System.Type _expectedType = default;
            var _argCount = _context.ArgumentCount;
            var _this = _context.GetArgument<LuaCamera>(0);
            if (_argCount == 1)
            {
                _this.Instance.RenderDontRestore();
                var _retCount = _context.Return();
                return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
            }
            throw new global::Lua.LuaRuntimeException(_context.Thread, $"{"RenderDontRestore"}: invalid argument #{_lastArgPos}: {_lastArg} ({_lastArg.Type}), expected: {_expectedType.FullName}", 2);
        });
        private static readonly global::Lua.LuaFunction _LuaCamera_RenderToCubemap = new global::Lua.LuaFunction("RenderToCubemap", (_context, _) =>
        {
            global::Lua.LuaValue _lastArg = default;
            global::System.Int32 _lastArgPos = default;
            global::System.Type _expectedType = default;
            var _argCount = _context.ArgumentCount;
            var _this = _context.GetArgument<LuaCamera>(0);
            var _arg0 = _lastArg = _argCount > 1 ? _context.GetArgument(1) : global::Lua.LuaValue.Nil;
            _lastArgPos = 0; _expectedType = typeof(global::Luny.UnityEngine.LuaRenderTexture);
            if (_arg0.TryRead<global::Luny.UnityEngine.LuaRenderTexture>(out var _p0_UnityEngine_RenderTexture))
            {
                if (_argCount == 2)
                {
                    var cubemap = _p0_UnityEngine_RenderTexture.Instance;
                    var _ret0 = _this.Instance.RenderToCubemap(cubemap);
                    var _lret0 = new global::Lua.LuaValue(_ret0);
                    var _retCount = _context.Return(_lret0);
                    return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                }
                var _arg1 = _lastArg = _argCount > 2 ? _context.GetArgument(2) : global::Lua.LuaValue.Nil;
                _lastArgPos = 1; _expectedType = typeof(global::System.Int32);
                if (_arg1.TryRead<global::System.Int32>(out var _p1_System_Int32))
                {
                    if (_argCount == 3)
                    {
                        var cubemap = _p0_UnityEngine_RenderTexture.Instance;
                        var faceMask = _p1_System_Int32;
                        var _ret0 = _this.Instance.RenderToCubemap(cubemap, faceMask);
                        var _lret0 = new global::Lua.LuaValue(_ret0);
                        var _retCount = _context.Return(_lret0);
                        return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                    }
                    var _arg2 = _lastArg = _argCount > 3 ? _context.GetArgument(3) : global::Lua.LuaValue.Nil;
                    _lastArgPos = 2; _expectedType = typeof(global::UnityEngine.Camera.MonoOrStereoscopicEye);
                    if (_arg2.TryRead<global::UnityEngine.Camera.MonoOrStereoscopicEye>(out var _p2_UnityEngine_Camera_MonoOrStereoscopicEye))
                    {
                        if (_argCount == 4)
                        {
                            var cubemap = _p0_UnityEngine_RenderTexture.Instance;
                            var faceMask = _p1_System_Int32;
                            var stereoEye = _p2_UnityEngine_Camera_MonoOrStereoscopicEye;
                            var _ret0 = _this.Instance.RenderToCubemap(cubemap, faceMask, stereoEye);
                            var _lret0 = new global::Lua.LuaValue(_ret0);
                            var _retCount = _context.Return(_lret0);
                            return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                        }
                    }
                }
            }
            _lastArgPos = 0; _expectedType = typeof(global::Luny.UnityEngine.LuaCubemap);
            if (_arg0.TryRead<global::Luny.UnityEngine.LuaCubemap>(out var _p0_UnityEngine_Cubemap))
            {
                if (_argCount == 2)
                {
                    var cubemap = _p0_UnityEngine_Cubemap.Instance;
                    var _ret0 = _this.Instance.RenderToCubemap(cubemap);
                    var _lret0 = new global::Lua.LuaValue(_ret0);
                    var _retCount = _context.Return(_lret0);
                    return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                }
                var _arg1 = _lastArg = _argCount > 2 ? _context.GetArgument(2) : global::Lua.LuaValue.Nil;
                _lastArgPos = 1; _expectedType = typeof(global::System.Int32);
                if (_arg1.TryRead<global::System.Int32>(out var _p1_System_Int32))
                {
                    if (_argCount == 3)
                    {
                        var cubemap = _p0_UnityEngine_Cubemap.Instance;
                        var faceMask = _p1_System_Int32;
                        var _ret0 = _this.Instance.RenderToCubemap(cubemap, faceMask);
                        var _lret0 = new global::Lua.LuaValue(_ret0);
                        var _retCount = _context.Return(_lret0);
                        return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                    }
                }
            }
            throw new global::Lua.LuaRuntimeException(_context.Thread, $"{"RenderToCubemap"}: invalid argument #{_lastArgPos}: {_lastArg} ({_lastArg.Type}), expected: {_expectedType.FullName}", 2);
        });
        private static readonly global::Lua.LuaFunction _LuaCamera_RenderWithShader = new global::Lua.LuaFunction("RenderWithShader", (_context, _) =>
        {
            global::Lua.LuaValue _lastArg = default;
            global::System.Int32 _lastArgPos = default;
            global::System.Type _expectedType = default;
            var _argCount = _context.ArgumentCount;
            var _this = _context.GetArgument<LuaCamera>(0);
            var _arg0 = _lastArg = _argCount > 1 ? _context.GetArgument(1) : global::Lua.LuaValue.Nil;
            _lastArgPos = 0; _expectedType = typeof(global::Luny.UnityEngine.LuaShader);
            if (_arg0.TryRead<global::Luny.UnityEngine.LuaShader>(out var _p0_UnityEngine_Shader))
            {
                var _arg1 = _lastArg = _argCount > 2 ? _context.GetArgument(2) : global::Lua.LuaValue.Nil;
                _lastArgPos = 1; _expectedType = typeof(global::System.String);
                if (_arg1.TryRead<global::System.String>(out var _p1_System_String))
                {
                    if (_argCount == 3)
                    {
                        var shader = _p0_UnityEngine_Shader.Instance;
                        var replacementTag = _p1_System_String;
                        _this.Instance.RenderWithShader(shader, replacementTag);
                        var _retCount = _context.Return();
                        return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                    }
                }
            }
            throw new global::Lua.LuaRuntimeException(_context.Thread, $"{"RenderWithShader"}: invalid argument #{_lastArgPos}: {_lastArg} ({_lastArg.Type}), expected: {_expectedType.FullName}", 2);
        });
        private static readonly global::Lua.LuaFunction _LuaCamera_Reset = new global::Lua.LuaFunction("Reset", (_context, _) =>
        {
            global::Lua.LuaValue _lastArg = default;
            global::System.Int32 _lastArgPos = default;
            global::System.Type _expectedType = default;
            var _argCount = _context.ArgumentCount;
            var _this = _context.GetArgument<LuaCamera>(0);
            if (_argCount == 1)
            {
                _this.Instance.Reset();
                var _retCount = _context.Return();
                return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
            }
            throw new global::Lua.LuaRuntimeException(_context.Thread, $"{"Reset"}: invalid argument #{_lastArgPos}: {_lastArg} ({_lastArg.Type}), expected: {_expectedType.FullName}", 2);
        });
        private static readonly global::Lua.LuaFunction _LuaCamera_ResetAspect = new global::Lua.LuaFunction("ResetAspect", (_context, _) =>
        {
            global::Lua.LuaValue _lastArg = default;
            global::System.Int32 _lastArgPos = default;
            global::System.Type _expectedType = default;
            var _argCount = _context.ArgumentCount;
            var _this = _context.GetArgument<LuaCamera>(0);
            if (_argCount == 1)
            {
                _this.Instance.ResetAspect();
                var _retCount = _context.Return();
                return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
            }
            throw new global::Lua.LuaRuntimeException(_context.Thread, $"{"ResetAspect"}: invalid argument #{_lastArgPos}: {_lastArg} ({_lastArg.Type}), expected: {_expectedType.FullName}", 2);
        });
        private static readonly global::Lua.LuaFunction _LuaCamera_ResetCullingMatrix = new global::Lua.LuaFunction("ResetCullingMatrix", (_context, _) =>
        {
            global::Lua.LuaValue _lastArg = default;
            global::System.Int32 _lastArgPos = default;
            global::System.Type _expectedType = default;
            var _argCount = _context.ArgumentCount;
            var _this = _context.GetArgument<LuaCamera>(0);
            if (_argCount == 1)
            {
                _this.Instance.ResetCullingMatrix();
                var _retCount = _context.Return();
                return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
            }
            throw new global::Lua.LuaRuntimeException(_context.Thread, $"{"ResetCullingMatrix"}: invalid argument #{_lastArgPos}: {_lastArg} ({_lastArg.Type}), expected: {_expectedType.FullName}", 2);
        });
        private static readonly global::Lua.LuaFunction _LuaCamera_ResetProjectionMatrix = new global::Lua.LuaFunction("ResetProjectionMatrix", (_context, _) =>
        {
            global::Lua.LuaValue _lastArg = default;
            global::System.Int32 _lastArgPos = default;
            global::System.Type _expectedType = default;
            var _argCount = _context.ArgumentCount;
            var _this = _context.GetArgument<LuaCamera>(0);
            if (_argCount == 1)
            {
                _this.Instance.ResetProjectionMatrix();
                var _retCount = _context.Return();
                return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
            }
            throw new global::Lua.LuaRuntimeException(_context.Thread, $"{"ResetProjectionMatrix"}: invalid argument #{_lastArgPos}: {_lastArg} ({_lastArg.Type}), expected: {_expectedType.FullName}", 2);
        });
        private static readonly global::Lua.LuaFunction _LuaCamera_ResetReplacementShader = new global::Lua.LuaFunction("ResetReplacementShader", (_context, _) =>
        {
            global::Lua.LuaValue _lastArg = default;
            global::System.Int32 _lastArgPos = default;
            global::System.Type _expectedType = default;
            var _argCount = _context.ArgumentCount;
            var _this = _context.GetArgument<LuaCamera>(0);
            if (_argCount == 1)
            {
                _this.Instance.ResetReplacementShader();
                var _retCount = _context.Return();
                return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
            }
            throw new global::Lua.LuaRuntimeException(_context.Thread, $"{"ResetReplacementShader"}: invalid argument #{_lastArgPos}: {_lastArg} ({_lastArg.Type}), expected: {_expectedType.FullName}", 2);
        });
        private static readonly global::Lua.LuaFunction _LuaCamera_ResetStereoProjectionMatrices = new global::Lua.LuaFunction("ResetStereoProjectionMatrices", (_context, _) =>
        {
            global::Lua.LuaValue _lastArg = default;
            global::System.Int32 _lastArgPos = default;
            global::System.Type _expectedType = default;
            var _argCount = _context.ArgumentCount;
            var _this = _context.GetArgument<LuaCamera>(0);
            if (_argCount == 1)
            {
                _this.Instance.ResetStereoProjectionMatrices();
                var _retCount = _context.Return();
                return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
            }
            throw new global::Lua.LuaRuntimeException(_context.Thread, $"{"ResetStereoProjectionMatrices"}: invalid argument #{_lastArgPos}: {_lastArg} ({_lastArg.Type}), expected: {_expectedType.FullName}", 2);
        });
        private static readonly global::Lua.LuaFunction _LuaCamera_ResetStereoViewMatrices = new global::Lua.LuaFunction("ResetStereoViewMatrices", (_context, _) =>
        {
            global::Lua.LuaValue _lastArg = default;
            global::System.Int32 _lastArgPos = default;
            global::System.Type _expectedType = default;
            var _argCount = _context.ArgumentCount;
            var _this = _context.GetArgument<LuaCamera>(0);
            if (_argCount == 1)
            {
                _this.Instance.ResetStereoViewMatrices();
                var _retCount = _context.Return();
                return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
            }
            throw new global::Lua.LuaRuntimeException(_context.Thread, $"{"ResetStereoViewMatrices"}: invalid argument #{_lastArgPos}: {_lastArg} ({_lastArg.Type}), expected: {_expectedType.FullName}", 2);
        });
        private static readonly global::Lua.LuaFunction _LuaCamera_ResetTransparencySortSettings = new global::Lua.LuaFunction("ResetTransparencySortSettings", (_context, _) =>
        {
            global::Lua.LuaValue _lastArg = default;
            global::System.Int32 _lastArgPos = default;
            global::System.Type _expectedType = default;
            var _argCount = _context.ArgumentCount;
            var _this = _context.GetArgument<LuaCamera>(0);
            if (_argCount == 1)
            {
                _this.Instance.ResetTransparencySortSettings();
                var _retCount = _context.Return();
                return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
            }
            throw new global::Lua.LuaRuntimeException(_context.Thread, $"{"ResetTransparencySortSettings"}: invalid argument #{_lastArgPos}: {_lastArg} ({_lastArg.Type}), expected: {_expectedType.FullName}", 2);
        });
        private static readonly global::Lua.LuaFunction _LuaCamera_ResetWorldToCameraMatrix = new global::Lua.LuaFunction("ResetWorldToCameraMatrix", (_context, _) =>
        {
            global::Lua.LuaValue _lastArg = default;
            global::System.Int32 _lastArgPos = default;
            global::System.Type _expectedType = default;
            var _argCount = _context.ArgumentCount;
            var _this = _context.GetArgument<LuaCamera>(0);
            if (_argCount == 1)
            {
                _this.Instance.ResetWorldToCameraMatrix();
                var _retCount = _context.Return();
                return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
            }
            throw new global::Lua.LuaRuntimeException(_context.Thread, $"{"ResetWorldToCameraMatrix"}: invalid argument #{_lastArgPos}: {_lastArg} ({_lastArg.Type}), expected: {_expectedType.FullName}", 2);
        });
        private static readonly global::Lua.LuaFunction _LuaCamera_ScreenPointToRay = new global::Lua.LuaFunction("ScreenPointToRay", (_context, _) =>
        {
            global::Lua.LuaValue _lastArg = default;
            global::System.Int32 _lastArgPos = default;
            global::System.Type _expectedType = default;
            var _argCount = _context.ArgumentCount;
            var _this = _context.GetArgument<LuaCamera>(0);
            var _arg0 = _lastArg = _argCount > 1 ? _context.GetArgument(1) : global::Lua.LuaValue.Nil;
            _lastArgPos = 0; _expectedType = typeof(global::Luny.UnityEngine.LuaVector3);
            if (_arg0.TryRead<global::Luny.UnityEngine.LuaVector3>(out var _p0_UnityEngine_Vector3))
            {
                if (_argCount == 2)
                {
                    var pos = _p0_UnityEngine_Vector3.Value;
                    var _ret0 = _this.Instance.ScreenPointToRay(pos);
                    var _lret0 = global::Luny.UnityEngine.LuaRay.Bind(_ret0);
                    var _retCount = _context.Return(_lret0);
                    return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                }
                var _arg1 = _lastArg = _argCount > 2 ? _context.GetArgument(2) : global::Lua.LuaValue.Nil;
                _lastArgPos = 1; _expectedType = typeof(global::UnityEngine.Camera.MonoOrStereoscopicEye);
                if (_arg1.TryRead<global::UnityEngine.Camera.MonoOrStereoscopicEye>(out var _p1_UnityEngine_Camera_MonoOrStereoscopicEye))
                {
                    if (_argCount == 3)
                    {
                        var pos = _p0_UnityEngine_Vector3.Value;
                        var eye = _p1_UnityEngine_Camera_MonoOrStereoscopicEye;
                        var _ret0 = _this.Instance.ScreenPointToRay(pos, eye);
                        var _lret0 = global::Luny.UnityEngine.LuaRay.Bind(_ret0);
                        var _retCount = _context.Return(_lret0);
                        return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                    }
                }
            }
            throw new global::Lua.LuaRuntimeException(_context.Thread, $"{"ScreenPointToRay"}: invalid argument #{_lastArgPos}: {_lastArg} ({_lastArg.Type}), expected: {_expectedType.FullName}", 2);
        });
        private static readonly global::Lua.LuaFunction _LuaCamera_ScreenToViewportPoint = new global::Lua.LuaFunction("ScreenToViewportPoint", (_context, _) =>
        {
            global::Lua.LuaValue _lastArg = default;
            global::System.Int32 _lastArgPos = default;
            global::System.Type _expectedType = default;
            var _argCount = _context.ArgumentCount;
            var _this = _context.GetArgument<LuaCamera>(0);
            var _arg0 = _lastArg = _argCount > 1 ? _context.GetArgument(1) : global::Lua.LuaValue.Nil;
            _lastArgPos = 0; _expectedType = typeof(global::Luny.UnityEngine.LuaVector3);
            if (_arg0.TryRead<global::Luny.UnityEngine.LuaVector3>(out var _p0_UnityEngine_Vector3))
            {
                if (_argCount == 2)
                {
                    var position = _p0_UnityEngine_Vector3.Value;
                    var _ret0 = _this.Instance.ScreenToViewportPoint(position);
                    var _lret0 = global::Luny.UnityEngine.LuaVector3.Bind(_ret0);
                    var _retCount = _context.Return(_lret0);
                    return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                }
            }
            throw new global::Lua.LuaRuntimeException(_context.Thread, $"{"ScreenToViewportPoint"}: invalid argument #{_lastArgPos}: {_lastArg} ({_lastArg.Type}), expected: {_expectedType.FullName}", 2);
        });
        private static readonly global::Lua.LuaFunction _LuaCamera_ScreenToWorldPoint = new global::Lua.LuaFunction("ScreenToWorldPoint", (_context, _) =>
        {
            global::Lua.LuaValue _lastArg = default;
            global::System.Int32 _lastArgPos = default;
            global::System.Type _expectedType = default;
            var _argCount = _context.ArgumentCount;
            var _this = _context.GetArgument<LuaCamera>(0);
            var _arg0 = _lastArg = _argCount > 1 ? _context.GetArgument(1) : global::Lua.LuaValue.Nil;
            _lastArgPos = 0; _expectedType = typeof(global::Luny.UnityEngine.LuaVector3);
            if (_arg0.TryRead<global::Luny.UnityEngine.LuaVector3>(out var _p0_UnityEngine_Vector3))
            {
                if (_argCount == 2)
                {
                    var position = _p0_UnityEngine_Vector3.Value;
                    var _ret0 = _this.Instance.ScreenToWorldPoint(position);
                    var _lret0 = global::Luny.UnityEngine.LuaVector3.Bind(_ret0);
                    var _retCount = _context.Return(_lret0);
                    return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                }
                var _arg1 = _lastArg = _argCount > 2 ? _context.GetArgument(2) : global::Lua.LuaValue.Nil;
                _lastArgPos = 1; _expectedType = typeof(global::UnityEngine.Camera.MonoOrStereoscopicEye);
                if (_arg1.TryRead<global::UnityEngine.Camera.MonoOrStereoscopicEye>(out var _p1_UnityEngine_Camera_MonoOrStereoscopicEye))
                {
                    if (_argCount == 3)
                    {
                        var position = _p0_UnityEngine_Vector3.Value;
                        var eye = _p1_UnityEngine_Camera_MonoOrStereoscopicEye;
                        var _ret0 = _this.Instance.ScreenToWorldPoint(position, eye);
                        var _lret0 = global::Luny.UnityEngine.LuaVector3.Bind(_ret0);
                        var _retCount = _context.Return(_lret0);
                        return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                    }
                }
            }
            throw new global::Lua.LuaRuntimeException(_context.Thread, $"{"ScreenToWorldPoint"}: invalid argument #{_lastArgPos}: {_lastArg} ({_lastArg.Type}), expected: {_expectedType.FullName}", 2);
        });
        private static readonly global::Lua.LuaFunction _LuaCamera_SetReplacementShader = new global::Lua.LuaFunction("SetReplacementShader", (_context, _) =>
        {
            global::Lua.LuaValue _lastArg = default;
            global::System.Int32 _lastArgPos = default;
            global::System.Type _expectedType = default;
            var _argCount = _context.ArgumentCount;
            var _this = _context.GetArgument<LuaCamera>(0);
            var _arg0 = _lastArg = _argCount > 1 ? _context.GetArgument(1) : global::Lua.LuaValue.Nil;
            _lastArgPos = 0; _expectedType = typeof(global::Luny.UnityEngine.LuaShader);
            if (_arg0.TryRead<global::Luny.UnityEngine.LuaShader>(out var _p0_UnityEngine_Shader))
            {
                var _arg1 = _lastArg = _argCount > 2 ? _context.GetArgument(2) : global::Lua.LuaValue.Nil;
                _lastArgPos = 1; _expectedType = typeof(global::System.String);
                if (_arg1.TryRead<global::System.String>(out var _p1_System_String))
                {
                    if (_argCount == 3)
                    {
                        var shader = _p0_UnityEngine_Shader.Instance;
                        var replacementTag = _p1_System_String;
                        _this.Instance.SetReplacementShader(shader, replacementTag);
                        var _retCount = _context.Return();
                        return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                    }
                }
            }
            throw new global::Lua.LuaRuntimeException(_context.Thread, $"{"SetReplacementShader"}: invalid argument #{_lastArgPos}: {_lastArg} ({_lastArg.Type}), expected: {_expectedType.FullName}", 2);
        });
        private static readonly global::Lua.LuaFunction _LuaCamera_SetStereoProjectionMatrix = new global::Lua.LuaFunction("SetStereoProjectionMatrix", (_context, _) =>
        {
            global::Lua.LuaValue _lastArg = default;
            global::System.Int32 _lastArgPos = default;
            global::System.Type _expectedType = default;
            var _argCount = _context.ArgumentCount;
            var _this = _context.GetArgument<LuaCamera>(0);
            var _arg0 = _lastArg = _argCount > 1 ? _context.GetArgument(1) : global::Lua.LuaValue.Nil;
            _lastArgPos = 0; _expectedType = typeof(global::UnityEngine.Camera.StereoscopicEye);
            if (_arg0.TryRead<global::UnityEngine.Camera.StereoscopicEye>(out var _p0_UnityEngine_Camera_StereoscopicEye))
            {
                var _arg1 = _lastArg = _argCount > 2 ? _context.GetArgument(2) : global::Lua.LuaValue.Nil;
                _lastArgPos = 1; _expectedType = typeof(global::Luny.UnityEngine.LuaMatrix4x4);
                if (_arg1.TryRead<global::Luny.UnityEngine.LuaMatrix4x4>(out var _p1_UnityEngine_Matrix4x4))
                {
                    if (_argCount == 3)
                    {
                        var eye = _p0_UnityEngine_Camera_StereoscopicEye;
                        var matrix = _p1_UnityEngine_Matrix4x4.Value;
                        _this.Instance.SetStereoProjectionMatrix(eye, matrix);
                        var _retCount = _context.Return();
                        return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                    }
                }
            }
            throw new global::Lua.LuaRuntimeException(_context.Thread, $"{"SetStereoProjectionMatrix"}: invalid argument #{_lastArgPos}: {_lastArg} ({_lastArg.Type}), expected: {_expectedType.FullName}", 2);
        });
        private static readonly global::Lua.LuaFunction _LuaCamera_SetStereoViewMatrix = new global::Lua.LuaFunction("SetStereoViewMatrix", (_context, _) =>
        {
            global::Lua.LuaValue _lastArg = default;
            global::System.Int32 _lastArgPos = default;
            global::System.Type _expectedType = default;
            var _argCount = _context.ArgumentCount;
            var _this = _context.GetArgument<LuaCamera>(0);
            var _arg0 = _lastArg = _argCount > 1 ? _context.GetArgument(1) : global::Lua.LuaValue.Nil;
            _lastArgPos = 0; _expectedType = typeof(global::UnityEngine.Camera.StereoscopicEye);
            if (_arg0.TryRead<global::UnityEngine.Camera.StereoscopicEye>(out var _p0_UnityEngine_Camera_StereoscopicEye))
            {
                var _arg1 = _lastArg = _argCount > 2 ? _context.GetArgument(2) : global::Lua.LuaValue.Nil;
                _lastArgPos = 1; _expectedType = typeof(global::Luny.UnityEngine.LuaMatrix4x4);
                if (_arg1.TryRead<global::Luny.UnityEngine.LuaMatrix4x4>(out var _p1_UnityEngine_Matrix4x4))
                {
                    if (_argCount == 3)
                    {
                        var eye = _p0_UnityEngine_Camera_StereoscopicEye;
                        var matrix = _p1_UnityEngine_Matrix4x4.Value;
                        _this.Instance.SetStereoViewMatrix(eye, matrix);
                        var _retCount = _context.Return();
                        return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                    }
                }
            }
            throw new global::Lua.LuaRuntimeException(_context.Thread, $"{"SetStereoViewMatrix"}: invalid argument #{_lastArgPos}: {_lastArg} ({_lastArg.Type}), expected: {_expectedType.FullName}", 2);
        });
        private static readonly global::Lua.LuaFunction _LuaCamera_SetTargetBuffers = new global::Lua.LuaFunction("SetTargetBuffers", (_context, _) =>
        {
            global::Lua.LuaValue _lastArg = default;
            global::System.Int32 _lastArgPos = default;
            global::System.Type _expectedType = default;
            var _argCount = _context.ArgumentCount;
            var _this = _context.GetArgument<LuaCamera>(0);
            var _arg0 = _lastArg = _argCount > 1 ? _context.GetArgument(1) : global::Lua.LuaValue.Nil;
            _lastArgPos = 0; _expectedType = typeof(global::Luny.UnityEngine.LuaRenderBuffer);
            if (_arg0.TryRead<global::Luny.UnityEngine.LuaRenderBuffer>(out var _p0_UnityEngine_RenderBuffer))
            {
                var _arg1 = _lastArg = _argCount > 2 ? _context.GetArgument(2) : global::Lua.LuaValue.Nil;
                _lastArgPos = 1; _expectedType = typeof(global::Luny.UnityEngine.LuaRenderBuffer);
                if (_arg1.TryRead<global::Luny.UnityEngine.LuaRenderBuffer>(out var _p1_UnityEngine_RenderBuffer))
                {
                    if (_argCount == 3)
                    {
                        var colorBuffer = _p0_UnityEngine_RenderBuffer.Value;
                        var depthBuffer = _p1_UnityEngine_RenderBuffer.Value;
                        _this.Instance.SetTargetBuffers(colorBuffer, depthBuffer);
                        var _retCount = _context.Return();
                        return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                    }
                }
            }
            _lastArgPos = 0; _expectedType = typeof(global::UnityEngine.RenderBuffer[]);
            if (_arg0.TryReadArray<global::UnityEngine.RenderBuffer>(out var _p0_UnityEngine_RenderBufferArray))
            {
                var _arg1 = _lastArg = _argCount > 2 ? _context.GetArgument(2) : global::Lua.LuaValue.Nil;
                _lastArgPos = 1; _expectedType = typeof(global::Luny.UnityEngine.LuaRenderBuffer);
                if (_arg1.TryRead<global::Luny.UnityEngine.LuaRenderBuffer>(out var _p1_UnityEngine_RenderBuffer))
                {
                    if (_argCount == 3)
                    {
                        var colorBuffer = _p0_UnityEngine_RenderBufferArray;
                        var depthBuffer = _p1_UnityEngine_RenderBuffer.Value;
                        _this.Instance.SetTargetBuffers(colorBuffer, depthBuffer);
                        var _retCount = _context.Return();
                        return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                    }
                }
            }
            throw new global::Lua.LuaRuntimeException(_context.Thread, $"{"SetTargetBuffers"}: invalid argument #{_lastArgPos}: {_lastArg} ({_lastArg.Type}), expected: {_expectedType.FullName}", 2);
        });
        private static readonly global::Lua.LuaFunction _LuaCamera_ViewportPointToRay = new global::Lua.LuaFunction("ViewportPointToRay", (_context, _) =>
        {
            global::Lua.LuaValue _lastArg = default;
            global::System.Int32 _lastArgPos = default;
            global::System.Type _expectedType = default;
            var _argCount = _context.ArgumentCount;
            var _this = _context.GetArgument<LuaCamera>(0);
            var _arg0 = _lastArg = _argCount > 1 ? _context.GetArgument(1) : global::Lua.LuaValue.Nil;
            _lastArgPos = 0; _expectedType = typeof(global::Luny.UnityEngine.LuaVector3);
            if (_arg0.TryRead<global::Luny.UnityEngine.LuaVector3>(out var _p0_UnityEngine_Vector3))
            {
                if (_argCount == 2)
                {
                    var pos = _p0_UnityEngine_Vector3.Value;
                    var _ret0 = _this.Instance.ViewportPointToRay(pos);
                    var _lret0 = global::Luny.UnityEngine.LuaRay.Bind(_ret0);
                    var _retCount = _context.Return(_lret0);
                    return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                }
                var _arg1 = _lastArg = _argCount > 2 ? _context.GetArgument(2) : global::Lua.LuaValue.Nil;
                _lastArgPos = 1; _expectedType = typeof(global::UnityEngine.Camera.MonoOrStereoscopicEye);
                if (_arg1.TryRead<global::UnityEngine.Camera.MonoOrStereoscopicEye>(out var _p1_UnityEngine_Camera_MonoOrStereoscopicEye))
                {
                    if (_argCount == 3)
                    {
                        var pos = _p0_UnityEngine_Vector3.Value;
                        var eye = _p1_UnityEngine_Camera_MonoOrStereoscopicEye;
                        var _ret0 = _this.Instance.ViewportPointToRay(pos, eye);
                        var _lret0 = global::Luny.UnityEngine.LuaRay.Bind(_ret0);
                        var _retCount = _context.Return(_lret0);
                        return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                    }
                }
            }
            throw new global::Lua.LuaRuntimeException(_context.Thread, $"{"ViewportPointToRay"}: invalid argument #{_lastArgPos}: {_lastArg} ({_lastArg.Type}), expected: {_expectedType.FullName}", 2);
        });
        private static readonly global::Lua.LuaFunction _LuaCamera_ViewportToScreenPoint = new global::Lua.LuaFunction("ViewportToScreenPoint", (_context, _) =>
        {
            global::Lua.LuaValue _lastArg = default;
            global::System.Int32 _lastArgPos = default;
            global::System.Type _expectedType = default;
            var _argCount = _context.ArgumentCount;
            var _this = _context.GetArgument<LuaCamera>(0);
            var _arg0 = _lastArg = _argCount > 1 ? _context.GetArgument(1) : global::Lua.LuaValue.Nil;
            _lastArgPos = 0; _expectedType = typeof(global::Luny.UnityEngine.LuaVector3);
            if (_arg0.TryRead<global::Luny.UnityEngine.LuaVector3>(out var _p0_UnityEngine_Vector3))
            {
                if (_argCount == 2)
                {
                    var position = _p0_UnityEngine_Vector3.Value;
                    var _ret0 = _this.Instance.ViewportToScreenPoint(position);
                    var _lret0 = global::Luny.UnityEngine.LuaVector3.Bind(_ret0);
                    var _retCount = _context.Return(_lret0);
                    return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                }
            }
            throw new global::Lua.LuaRuntimeException(_context.Thread, $"{"ViewportToScreenPoint"}: invalid argument #{_lastArgPos}: {_lastArg} ({_lastArg.Type}), expected: {_expectedType.FullName}", 2);
        });
        private static readonly global::Lua.LuaFunction _LuaCamera_ViewportToWorldPoint = new global::Lua.LuaFunction("ViewportToWorldPoint", (_context, _) =>
        {
            global::Lua.LuaValue _lastArg = default;
            global::System.Int32 _lastArgPos = default;
            global::System.Type _expectedType = default;
            var _argCount = _context.ArgumentCount;
            var _this = _context.GetArgument<LuaCamera>(0);
            var _arg0 = _lastArg = _argCount > 1 ? _context.GetArgument(1) : global::Lua.LuaValue.Nil;
            _lastArgPos = 0; _expectedType = typeof(global::Luny.UnityEngine.LuaVector3);
            if (_arg0.TryRead<global::Luny.UnityEngine.LuaVector3>(out var _p0_UnityEngine_Vector3))
            {
                if (_argCount == 2)
                {
                    var position = _p0_UnityEngine_Vector3.Value;
                    var _ret0 = _this.Instance.ViewportToWorldPoint(position);
                    var _lret0 = global::Luny.UnityEngine.LuaVector3.Bind(_ret0);
                    var _retCount = _context.Return(_lret0);
                    return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                }
                var _arg1 = _lastArg = _argCount > 2 ? _context.GetArgument(2) : global::Lua.LuaValue.Nil;
                _lastArgPos = 1; _expectedType = typeof(global::UnityEngine.Camera.MonoOrStereoscopicEye);
                if (_arg1.TryRead<global::UnityEngine.Camera.MonoOrStereoscopicEye>(out var _p1_UnityEngine_Camera_MonoOrStereoscopicEye))
                {
                    if (_argCount == 3)
                    {
                        var position = _p0_UnityEngine_Vector3.Value;
                        var eye = _p1_UnityEngine_Camera_MonoOrStereoscopicEye;
                        var _ret0 = _this.Instance.ViewportToWorldPoint(position, eye);
                        var _lret0 = global::Luny.UnityEngine.LuaVector3.Bind(_ret0);
                        var _retCount = _context.Return(_lret0);
                        return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                    }
                }
            }
            throw new global::Lua.LuaRuntimeException(_context.Thread, $"{"ViewportToWorldPoint"}: invalid argument #{_lastArgPos}: {_lastArg} ({_lastArg.Type}), expected: {_expectedType.FullName}", 2);
        });
        private static readonly global::Lua.LuaFunction _LuaCamera_WorldToScreenPoint = new global::Lua.LuaFunction("WorldToScreenPoint", (_context, _) =>
        {
            global::Lua.LuaValue _lastArg = default;
            global::System.Int32 _lastArgPos = default;
            global::System.Type _expectedType = default;
            var _argCount = _context.ArgumentCount;
            var _this = _context.GetArgument<LuaCamera>(0);
            var _arg0 = _lastArg = _argCount > 1 ? _context.GetArgument(1) : global::Lua.LuaValue.Nil;
            _lastArgPos = 0; _expectedType = typeof(global::Luny.UnityEngine.LuaVector3);
            if (_arg0.TryRead<global::Luny.UnityEngine.LuaVector3>(out var _p0_UnityEngine_Vector3))
            {
                if (_argCount == 2)
                {
                    var position = _p0_UnityEngine_Vector3.Value;
                    var _ret0 = _this.Instance.WorldToScreenPoint(position);
                    var _lret0 = global::Luny.UnityEngine.LuaVector3.Bind(_ret0);
                    var _retCount = _context.Return(_lret0);
                    return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                }
                var _arg1 = _lastArg = _argCount > 2 ? _context.GetArgument(2) : global::Lua.LuaValue.Nil;
                _lastArgPos = 1; _expectedType = typeof(global::UnityEngine.Camera.MonoOrStereoscopicEye);
                if (_arg1.TryRead<global::UnityEngine.Camera.MonoOrStereoscopicEye>(out var _p1_UnityEngine_Camera_MonoOrStereoscopicEye))
                {
                    if (_argCount == 3)
                    {
                        var position = _p0_UnityEngine_Vector3.Value;
                        var eye = _p1_UnityEngine_Camera_MonoOrStereoscopicEye;
                        var _ret0 = _this.Instance.WorldToScreenPoint(position, eye);
                        var _lret0 = global::Luny.UnityEngine.LuaVector3.Bind(_ret0);
                        var _retCount = _context.Return(_lret0);
                        return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                    }
                }
            }
            throw new global::Lua.LuaRuntimeException(_context.Thread, $"{"WorldToScreenPoint"}: invalid argument #{_lastArgPos}: {_lastArg} ({_lastArg.Type}), expected: {_expectedType.FullName}", 2);
        });
        private static readonly global::Lua.LuaFunction _LuaCamera_WorldToViewportPoint = new global::Lua.LuaFunction("WorldToViewportPoint", (_context, _) =>
        {
            global::Lua.LuaValue _lastArg = default;
            global::System.Int32 _lastArgPos = default;
            global::System.Type _expectedType = default;
            var _argCount = _context.ArgumentCount;
            var _this = _context.GetArgument<LuaCamera>(0);
            var _arg0 = _lastArg = _argCount > 1 ? _context.GetArgument(1) : global::Lua.LuaValue.Nil;
            _lastArgPos = 0; _expectedType = typeof(global::Luny.UnityEngine.LuaVector3);
            if (_arg0.TryRead<global::Luny.UnityEngine.LuaVector3>(out var _p0_UnityEngine_Vector3))
            {
                if (_argCount == 2)
                {
                    var position = _p0_UnityEngine_Vector3.Value;
                    var _ret0 = _this.Instance.WorldToViewportPoint(position);
                    var _lret0 = global::Luny.UnityEngine.LuaVector3.Bind(_ret0);
                    var _retCount = _context.Return(_lret0);
                    return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                }
                var _arg1 = _lastArg = _argCount > 2 ? _context.GetArgument(2) : global::Lua.LuaValue.Nil;
                _lastArgPos = 1; _expectedType = typeof(global::UnityEngine.Camera.MonoOrStereoscopicEye);
                if (_arg1.TryRead<global::UnityEngine.Camera.MonoOrStereoscopicEye>(out var _p1_UnityEngine_Camera_MonoOrStereoscopicEye))
                {
                    if (_argCount == 3)
                    {
                        var position = _p0_UnityEngine_Vector3.Value;
                        var eye = _p1_UnityEngine_Camera_MonoOrStereoscopicEye;
                        var _ret0 = _this.Instance.WorldToViewportPoint(position, eye);
                        var _lret0 = global::Luny.UnityEngine.LuaVector3.Bind(_ret0);
                        var _retCount = _context.Return(_lret0);
                        return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                    }
                }
            }
            throw new global::Lua.LuaRuntimeException(_context.Thread, $"{"WorldToViewportPoint"}: invalid argument #{_lastArgPos}: {_lastArg} ({_lastArg.Type}), expected: {_expectedType.FullName}", 2);
        });
        private static readonly global::Lua.LuaFunction __index = new(global::Lua.Runtime.Metamethods.Index, (_context, _) =>
        {
            var _this = _context.GetArgument<LuaCamera>(0);
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
            var _this = _context.GetArgument<LuaCamera>(0);
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
                case "AddCommandBuffer": _value = _LuaCamera_AddCommandBuffer; return true;
                case "AddCommandBufferAsync": _value = _LuaCamera_AddCommandBufferAsync; return true;
                case "CalculateFrustumCorners": _value = _LuaCamera_CalculateFrustumCorners; return true;
                case "CalculateObliqueMatrix": _value = _LuaCamera_CalculateObliqueMatrix; return true;
                case "CopyFrom": _value = _LuaCamera_CopyFrom; return true;
                case "CopyStereoDeviceProjectionMatrixToNonJittered": _value = _LuaCamera_CopyStereoDeviceProjectionMatrixToNonJittered; return true;
                case "GetCommandBuffers": _value = _LuaCamera_GetCommandBuffers; return true;
                case "GetGateFittedFieldOfView": _value = _LuaCamera_GetGateFittedFieldOfView; return true;
                case "GetGateFittedLensShift": _value = _LuaCamera_GetGateFittedLensShift; return true;
                case "GetStereoNonJitteredProjectionMatrix": _value = _LuaCamera_GetStereoNonJitteredProjectionMatrix; return true;
                case "GetStereoProjectionMatrix": _value = _LuaCamera_GetStereoProjectionMatrix; return true;
                case "GetStereoViewMatrix": _value = _LuaCamera_GetStereoViewMatrix; return true;
                case "RemoveAllCommandBuffers": _value = _LuaCamera_RemoveAllCommandBuffers; return true;
                case "RemoveCommandBuffer": _value = _LuaCamera_RemoveCommandBuffer; return true;
                case "RemoveCommandBuffers": _value = _LuaCamera_RemoveCommandBuffers; return true;
                case "Render": _value = _LuaCamera_Render; return true;
                case "RenderDontRestore": _value = _LuaCamera_RenderDontRestore; return true;
                case "RenderToCubemap": _value = _LuaCamera_RenderToCubemap; return true;
                case "RenderWithShader": _value = _LuaCamera_RenderWithShader; return true;
                case "Reset": _value = _LuaCamera_Reset; return true;
                case "ResetAspect": _value = _LuaCamera_ResetAspect; return true;
                case "ResetCullingMatrix": _value = _LuaCamera_ResetCullingMatrix; return true;
                case "ResetProjectionMatrix": _value = _LuaCamera_ResetProjectionMatrix; return true;
                case "ResetReplacementShader": _value = _LuaCamera_ResetReplacementShader; return true;
                case "ResetStereoProjectionMatrices": _value = _LuaCamera_ResetStereoProjectionMatrices; return true;
                case "ResetStereoViewMatrices": _value = _LuaCamera_ResetStereoViewMatrices; return true;
                case "ResetTransparencySortSettings": _value = _LuaCamera_ResetTransparencySortSettings; return true;
                case "ResetWorldToCameraMatrix": _value = _LuaCamera_ResetWorldToCameraMatrix; return true;
                case "ScreenPointToRay": _value = _LuaCamera_ScreenPointToRay; return true;
                case "ScreenToViewportPoint": _value = _LuaCamera_ScreenToViewportPoint; return true;
                case "ScreenToWorldPoint": _value = _LuaCamera_ScreenToWorldPoint; return true;
                case "SetReplacementShader": _value = _LuaCamera_SetReplacementShader; return true;
                case "SetStereoProjectionMatrix": _value = _LuaCamera_SetStereoProjectionMatrix; return true;
                case "SetStereoViewMatrix": _value = _LuaCamera_SetStereoViewMatrix; return true;
                case "SetTargetBuffers": _value = _LuaCamera_SetTargetBuffers; return true;
                case "ViewportPointToRay": _value = _LuaCamera_ViewportPointToRay; return true;
                case "ViewportToScreenPoint": _value = _LuaCamera_ViewportToScreenPoint; return true;
                case "ViewportToWorldPoint": _value = _LuaCamera_ViewportToWorldPoint; return true;
                case "WorldToScreenPoint": _value = _LuaCamera_WorldToScreenPoint; return true;
                case "WorldToViewportPoint": _value = _LuaCamera_WorldToViewportPoint; return true;
                case "activeTexture": _value = _factory.Bind(Instance.activeTexture); return true;
                case "actualRenderingPath": _value = new global::Lua.LuaValue((global::System.Int64)Instance.actualRenderingPath); return true;
                case "allowDynamicResolution": _value = new global::Lua.LuaValue(Instance.allowDynamicResolution); return true;
                case "allowHDR": _value = new global::Lua.LuaValue(Instance.allowHDR); return true;
                case "allowMSAA": _value = new global::Lua.LuaValue(Instance.allowMSAA); return true;
                case "anamorphism": _value = new global::Lua.LuaValue(Instance.anamorphism); return true;
                case "aperture": _value = new global::Lua.LuaValue(Instance.aperture); return true;
                case "areVRStereoViewMatricesWithinSingleCullTolerance": _value = new global::Lua.LuaValue(Instance.areVRStereoViewMatricesWithinSingleCullTolerance); return true;
                case "aspect": _value = new global::Lua.LuaValue(Instance.aspect); return true;
                case "backgroundColor": _value = global::Luny.UnityEngine.LuaColor.Bind(Instance.backgroundColor); return true;
                case "barrelClipping": _value = new global::Lua.LuaValue(Instance.barrelClipping); return true;
                case "bladeCount": _value = new global::Lua.LuaValue(Instance.bladeCount); return true;
                case "cameraToWorldMatrix": _value = global::Luny.UnityEngine.LuaMatrix4x4.Bind(Instance.cameraToWorldMatrix); return true;
                case "cameraType": _value = new global::Lua.LuaValue((global::System.Int64)Instance.cameraType); return true;
                case "clearFlags": _value = new global::Lua.LuaValue((global::System.Int64)Instance.clearFlags); return true;
                case "clearStencilAfterLightingPass": _value = new global::Lua.LuaValue(Instance.clearStencilAfterLightingPass); return true;
                case "commandBufferCount": _value = new global::Lua.LuaValue(Instance.commandBufferCount); return true;
                case "cullingMask": _value = new global::Lua.LuaValue(Instance.cullingMask); return true;
                case "cullingMatrix": _value = global::Luny.UnityEngine.LuaMatrix4x4.Bind(Instance.cullingMatrix); return true;
                case "curvature": _value = global::Luny.UnityEngine.LuaVector2.Bind(Instance.curvature); return true;
                case "depth": _value = new global::Lua.LuaValue(Instance.depth); return true;
                case "depthTextureMode": _value = new global::Lua.LuaValue((global::System.Int64)Instance.depthTextureMode); return true;
                case "eventMask": _value = new global::Lua.LuaValue(Instance.eventMask); return true;
                case "farClipPlane": _value = new global::Lua.LuaValue(Instance.farClipPlane); return true;
                case "fieldOfView": _value = new global::Lua.LuaValue(Instance.fieldOfView); return true;
                case "focalLength": _value = new global::Lua.LuaValue(Instance.focalLength); return true;
                case "focusDistance": _value = new global::Lua.LuaValue(Instance.focusDistance); return true;
                case "forceIntoRenderTexture": _value = new global::Lua.LuaValue(Instance.forceIntoRenderTexture); return true;
                case "gateFit": _value = new global::Lua.LuaValue((global::System.Int64)Instance.gateFit); return true;
                case "iso": _value = new global::Lua.LuaValue(Instance.iso); return true;
                case "layerCullDistances": _value = _factory.Bind(Instance.layerCullDistances); return true;
                case "layerCullSpherical": _value = new global::Lua.LuaValue(Instance.layerCullSpherical); return true;
                case "lensShift": _value = global::Luny.UnityEngine.LuaVector2.Bind(Instance.lensShift); return true;
                case "nearClipPlane": _value = new global::Lua.LuaValue(Instance.nearClipPlane); return true;
                case "nonJitteredProjectionMatrix": _value = global::Luny.UnityEngine.LuaMatrix4x4.Bind(Instance.nonJitteredProjectionMatrix); return true;
                case "opaqueSortMode": _value = new global::Lua.LuaValue((global::System.Int64)Instance.opaqueSortMode); return true;
                case "orthographic": _value = new global::Lua.LuaValue(Instance.orthographic); return true;
                case "orthographicSize": _value = new global::Lua.LuaValue(Instance.orthographicSize); return true;
                case "overrideSceneCullingMask": _value = new global::Lua.LuaValue(Instance.overrideSceneCullingMask); return true;
                case "pixelHeight": _value = new global::Lua.LuaValue(Instance.pixelHeight); return true;
                case "pixelRect": _value = global::Luny.UnityEngine.LuaRect.Bind(Instance.pixelRect); return true;
                case "pixelWidth": _value = new global::Lua.LuaValue(Instance.pixelWidth); return true;
                case "previousViewProjectionMatrix": _value = global::Luny.UnityEngine.LuaMatrix4x4.Bind(Instance.previousViewProjectionMatrix); return true;
                case "projectionMatrix": _value = global::Luny.UnityEngine.LuaMatrix4x4.Bind(Instance.projectionMatrix); return true;
                case "rect": _value = global::Luny.UnityEngine.LuaRect.Bind(Instance.rect); return true;
                case "renderCloudsInSceneView": _value = new global::Lua.LuaValue(Instance.renderCloudsInSceneView); return true;
                case "renderingPath": _value = new global::Lua.LuaValue((global::System.Int64)Instance.renderingPath); return true;
                case "scaledPixelHeight": _value = new global::Lua.LuaValue(Instance.scaledPixelHeight); return true;
                case "scaledPixelWidth": _value = new global::Lua.LuaValue(Instance.scaledPixelWidth); return true;
                case "scene": _value = global::Luny.UnityEngine.SceneManagement.LuaScene.Bind(Instance.scene); return true;
                case "sceneViewFilterMode": _value = new global::Lua.LuaValue((global::System.Int64)Instance.sceneViewFilterMode); return true;
                case "sensorSize": _value = global::Luny.UnityEngine.LuaVector2.Bind(Instance.sensorSize); return true;
                case "shutterSpeed": _value = new global::Lua.LuaValue(Instance.shutterSpeed); return true;
                case "stereoActiveEye": _value = new global::Lua.LuaValue((global::System.Int64)Instance.stereoActiveEye); return true;
                case "stereoConvergence": _value = new global::Lua.LuaValue(Instance.stereoConvergence); return true;
                case "stereoEnabled": _value = new global::Lua.LuaValue(Instance.stereoEnabled); return true;
                case "stereoSeparation": _value = new global::Lua.LuaValue(Instance.stereoSeparation); return true;
                case "stereoTargetEye": _value = new global::Lua.LuaValue((global::System.Int64)Instance.stereoTargetEye); return true;
                case "targetDisplay": _value = new global::Lua.LuaValue(Instance.targetDisplay); return true;
                case "targetTexture": _value = _factory.Bind(Instance.targetTexture); return true;
                case "transparencySortAxis": _value = global::Luny.UnityEngine.LuaVector3.Bind(Instance.transparencySortAxis); return true;
                case "transparencySortMode": _value = new global::Lua.LuaValue((global::System.Int64)Instance.transparencySortMode); return true;
                case "useJitteredProjectionMatrixForTransparentRendering": _value = new global::Lua.LuaValue(Instance.useJitteredProjectionMatrixForTransparentRendering); return true;
                case "useOcclusionCulling": _value = new global::Lua.LuaValue(Instance.useOcclusionCulling); return true;
                case "usePhysicalProperties": _value = new global::Lua.LuaValue(Instance.usePhysicalProperties); return true;
                case "velocity": _value = global::Luny.UnityEngine.LuaVector3.Bind(Instance.velocity); return true;
                case "worldToCameraMatrix": _value = global::Luny.UnityEngine.LuaMatrix4x4.Bind(Instance.worldToCameraMatrix); return true;
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
                case "allowDynamicResolution": Instance.allowDynamicResolution = _value.Read<global::System.Boolean>();  return true;
                case "allowHDR": Instance.allowHDR = _value.Read<global::System.Boolean>();  return true;
                case "allowMSAA": Instance.allowMSAA = _value.Read<global::System.Boolean>();  return true;
                case "anamorphism": Instance.anamorphism = _value.Read<global::System.Single>();  return true;
                case "aperture": Instance.aperture = _value.Read<global::System.Single>();  return true;
                case "aspect": Instance.aspect = _value.Read<global::System.Single>();  return true;
                case "backgroundColor": Instance.backgroundColor = _value.Read<global::Luny.UnityEngine.LuaColor>().Value;  return true;
                case "barrelClipping": Instance.barrelClipping = _value.Read<global::System.Single>();  return true;
                case "bladeCount": Instance.bladeCount = _value.Read<global::System.Int32>();  return true;
                case "cameraType": Instance.cameraType = _value.Read<global::UnityEngine.CameraType>();  return true;
                case "clearFlags": Instance.clearFlags = _value.Read<global::UnityEngine.CameraClearFlags>();  return true;
                case "clearStencilAfterLightingPass": Instance.clearStencilAfterLightingPass = _value.Read<global::System.Boolean>();  return true;
                case "cullingMask": Instance.cullingMask = _value.Read<global::System.Int32>();  return true;
                case "cullingMatrix": Instance.cullingMatrix = _value.Read<global::Luny.UnityEngine.LuaMatrix4x4>().Value;  return true;
                case "curvature": Instance.curvature = _value.Read<global::Luny.UnityEngine.LuaVector2>().Value;  return true;
                case "depth": Instance.depth = _value.Read<global::System.Single>();  return true;
                case "depthTextureMode": Instance.depthTextureMode = _value.Read<global::UnityEngine.DepthTextureMode>();  return true;
                case "eventMask": Instance.eventMask = _value.Read<global::System.Int32>();  return true;
                case "farClipPlane": Instance.farClipPlane = _value.Read<global::System.Single>();  return true;
                case "fieldOfView": Instance.fieldOfView = _value.Read<global::System.Single>();  return true;
                case "focalLength": Instance.focalLength = _value.Read<global::System.Single>();  return true;
                case "focusDistance": Instance.focusDistance = _value.Read<global::System.Single>();  return true;
                case "forceIntoRenderTexture": Instance.forceIntoRenderTexture = _value.Read<global::System.Boolean>();  return true;
                case "gateFit": Instance.gateFit = _value.Read<global::UnityEngine.Camera.GateFitMode>();  return true;
                case "iso": Instance.iso = _value.Read<global::System.Int32>();  return true;
                case "layerCullDistances": Instance.layerCullDistances = _value.Read<global::System.Single[]>();  return true;
                case "layerCullSpherical": Instance.layerCullSpherical = _value.Read<global::System.Boolean>();  return true;
                case "lensShift": Instance.lensShift = _value.Read<global::Luny.UnityEngine.LuaVector2>().Value;  return true;
                case "nearClipPlane": Instance.nearClipPlane = _value.Read<global::System.Single>();  return true;
                case "nonJitteredProjectionMatrix": Instance.nonJitteredProjectionMatrix = _value.Read<global::Luny.UnityEngine.LuaMatrix4x4>().Value;  return true;
                case "opaqueSortMode": Instance.opaqueSortMode = _value.Read<global::UnityEngine.Rendering.OpaqueSortMode>();  return true;
                case "orthographic": Instance.orthographic = _value.Read<global::System.Boolean>();  return true;
                case "orthographicSize": Instance.orthographicSize = _value.Read<global::System.Single>();  return true;
                case "overrideSceneCullingMask": Instance.overrideSceneCullingMask = _value.Read<global::System.UInt64>();  return true;
                case "pixelRect": Instance.pixelRect = _value.Read<global::Luny.UnityEngine.LuaRect>().Value;  return true;
                case "projectionMatrix": Instance.projectionMatrix = _value.Read<global::Luny.UnityEngine.LuaMatrix4x4>().Value;  return true;
                case "rect": Instance.rect = _value.Read<global::Luny.UnityEngine.LuaRect>().Value;  return true;
                case "renderCloudsInSceneView": Instance.renderCloudsInSceneView = _value.Read<global::System.Boolean>();  return true;
                case "renderingPath": Instance.renderingPath = _value.Read<global::UnityEngine.RenderingPath>();  return true;
                case "scene": Instance.scene = _value.Read<global::Luny.UnityEngine.SceneManagement.LuaScene>().Value;  return true;
                case "sensorSize": Instance.sensorSize = _value.Read<global::Luny.UnityEngine.LuaVector2>().Value;  return true;
                case "shutterSpeed": Instance.shutterSpeed = _value.Read<global::System.Single>();  return true;
                case "stereoConvergence": Instance.stereoConvergence = _value.Read<global::System.Single>();  return true;
                case "stereoSeparation": Instance.stereoSeparation = _value.Read<global::System.Single>();  return true;
                case "stereoTargetEye": Instance.stereoTargetEye = _value.Read<global::UnityEngine.StereoTargetEyeMask>();  return true;
                case "targetDisplay": Instance.targetDisplay = _value.Read<global::System.Int32>();  return true;
                case "targetTexture": Instance.targetTexture = _value.Read<global::Luny.UnityEngine.LuaRenderTexture>().Instance;  return true;
                case "transparencySortAxis": Instance.transparencySortAxis = _value.Read<global::Luny.UnityEngine.LuaVector3>().Value;  return true;
                case "transparencySortMode": Instance.transparencySortMode = _value.Read<global::UnityEngine.TransparencySortMode>();  return true;
                case "useJitteredProjectionMatrixForTransparentRendering": Instance.useJitteredProjectionMatrixForTransparentRendering = _value.Read<global::System.Boolean>();  return true;
                case "useOcclusionCulling": Instance.useOcclusionCulling = _value.Read<global::System.Boolean>();  return true;
                case "usePhysicalProperties": Instance.usePhysicalProperties = _value.Read<global::System.Boolean>();  return true;
                case "worldToCameraMatrix": Instance.worldToCameraMatrix = _value.Read<global::Luny.UnityEngine.LuaMatrix4x4>().Value;  return true;
                default: return base.TrySetLuaValue(_key, _value);
            }
        }
    }
    public sealed class LuaCameraType : global::Luny.ILuaStatic
    {
        public static global::Lua.LuaValue Bind() => new LuaCameraType();
        private LuaCameraType() {}
        public static implicit operator global::Lua.LuaValue(LuaCameraType value) => new(value);
        public global::System.Type BindType => typeof(global::UnityEngine.Camera);
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

        private static readonly global::Lua.LuaFunction _LuaCamera_new = new global::Lua.LuaFunction(".ctor", (_context, _) =>
        {
            global::Lua.LuaValue _lastArg = default;
            global::System.Int32 _lastArgPos = default;
            global::System.Type _expectedType = default;
            var _argCount = _context.ArgumentCount;
            if (_argCount == 0)
            {
                var _ret0 = new global::UnityEngine.Camera();
                var _factory = _context.GetObjectFactory();
                var _lret0 = _factory.Bind(_ret0);
                var _retCount = _context.Return(_lret0);
                return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
            }
            throw new global::Lua.LuaRuntimeException(_context.Thread, $"{".ctor"}: invalid argument #{_lastArgPos}: {_lastArg} ({_lastArg.Type}), expected: {_expectedType.FullName}", 2);
        });
        private static readonly global::Lua.LuaFunction _LuaCamera_FieldOfViewToFocalLength = new global::Lua.LuaFunction("FieldOfViewToFocalLength", (_context, _) =>
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
                    if (_argCount == 2)
                    {
                        var fieldOfView = _p0_System_Single;
                        var sensorSize = _p1_System_Single;
                        var _ret0 = global::UnityEngine.Camera.FieldOfViewToFocalLength(fieldOfView, sensorSize);
                        var _lret0 = new global::Lua.LuaValue(_ret0);
                        var _retCount = _context.Return(_lret0);
                        return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                    }
                }
            }
            throw new global::Lua.LuaRuntimeException(_context.Thread, $"{"FieldOfViewToFocalLength"}: invalid argument #{_lastArgPos}: {_lastArg} ({_lastArg.Type}), expected: {_expectedType.FullName}", 2);
        });
        private static readonly global::Lua.LuaFunction _LuaCamera_FocalLengthToFieldOfView = new global::Lua.LuaFunction("FocalLengthToFieldOfView", (_context, _) =>
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
                    if (_argCount == 2)
                    {
                        var focalLength = _p0_System_Single;
                        var sensorSize = _p1_System_Single;
                        var _ret0 = global::UnityEngine.Camera.FocalLengthToFieldOfView(focalLength, sensorSize);
                        var _lret0 = new global::Lua.LuaValue(_ret0);
                        var _retCount = _context.Return(_lret0);
                        return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                    }
                }
            }
            throw new global::Lua.LuaRuntimeException(_context.Thread, $"{"FocalLengthToFieldOfView"}: invalid argument #{_lastArgPos}: {_lastArg} ({_lastArg.Type}), expected: {_expectedType.FullName}", 2);
        });
        private static readonly global::Lua.LuaFunction _LuaCamera_GetAllCameras = new global::Lua.LuaFunction("GetAllCameras", (_context, _) =>
        {
            global::Lua.LuaValue _lastArg = default;
            global::System.Int32 _lastArgPos = default;
            global::System.Type _expectedType = default;
            var _argCount = _context.ArgumentCount;
            var _arg0 = _lastArg = _argCount > 0 ? _context.GetArgument(0) : global::Lua.LuaValue.Nil;
            _lastArgPos = 0; _expectedType = typeof(global::UnityEngine.Camera[]);
            if (_arg0.TryReadArray<global::UnityEngine.Camera>(out var _p0_UnityEngine_CameraArray))
            {
                if (_argCount == 1)
                {
                    var cameras = _p0_UnityEngine_CameraArray;
                    var _ret0 = global::UnityEngine.Camera.GetAllCameras(cameras);
                    var _lret0 = new global::Lua.LuaValue(_ret0);
                    var _retCount = _context.Return(_lret0);
                    return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                }
            }
            throw new global::Lua.LuaRuntimeException(_context.Thread, $"{"GetAllCameras"}: invalid argument #{_lastArgPos}: {_lastArg} ({_lastArg.Type}), expected: {_expectedType.FullName}", 2);
        });
        private static readonly global::Lua.LuaFunction _LuaCamera_HorizontalToVerticalFieldOfView = new global::Lua.LuaFunction("HorizontalToVerticalFieldOfView", (_context, _) =>
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
                    if (_argCount == 2)
                    {
                        var horizontalFieldOfView = _p0_System_Single;
                        var aspectRatio = _p1_System_Single;
                        var _ret0 = global::UnityEngine.Camera.HorizontalToVerticalFieldOfView(horizontalFieldOfView, aspectRatio);
                        var _lret0 = new global::Lua.LuaValue(_ret0);
                        var _retCount = _context.Return(_lret0);
                        return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                    }
                }
            }
            throw new global::Lua.LuaRuntimeException(_context.Thread, $"{"HorizontalToVerticalFieldOfView"}: invalid argument #{_lastArgPos}: {_lastArg} ({_lastArg.Type}), expected: {_expectedType.FullName}", 2);
        });
        private static readonly global::Lua.LuaFunction _LuaCamera_SetupCurrent = new global::Lua.LuaFunction("SetupCurrent", (_context, _) =>
        {
            global::Lua.LuaValue _lastArg = default;
            global::System.Int32 _lastArgPos = default;
            global::System.Type _expectedType = default;
            var _argCount = _context.ArgumentCount;
            var _arg0 = _lastArg = _argCount > 0 ? _context.GetArgument(0) : global::Lua.LuaValue.Nil;
            _lastArgPos = 0; _expectedType = typeof(global::Luny.UnityEngine.LuaCamera);
            if (_arg0.TryRead<global::Luny.UnityEngine.LuaCamera>(out var _p0_UnityEngine_Camera))
            {
                if (_argCount == 1)
                {
                    var cur = _p0_UnityEngine_Camera.Instance;
                    global::UnityEngine.Camera.SetupCurrent(cur);
                    var _retCount = _context.Return();
                    return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                }
            }
            throw new global::Lua.LuaRuntimeException(_context.Thread, $"{"SetupCurrent"}: invalid argument #{_lastArgPos}: {_lastArg} ({_lastArg.Type}), expected: {_expectedType.FullName}", 2);
        });
        private static readonly global::Lua.LuaFunction _LuaCamera_VerticalToHorizontalFieldOfView = new global::Lua.LuaFunction("VerticalToHorizontalFieldOfView", (_context, _) =>
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
                    if (_argCount == 2)
                    {
                        var verticalFieldOfView = _p0_System_Single;
                        var aspectRatio = _p1_System_Single;
                        var _ret0 = global::UnityEngine.Camera.VerticalToHorizontalFieldOfView(verticalFieldOfView, aspectRatio);
                        var _lret0 = new global::Lua.LuaValue(_ret0);
                        var _retCount = _context.Return(_lret0);
                        return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                    }
                }
            }
            throw new global::Lua.LuaRuntimeException(_context.Thread, $"{"VerticalToHorizontalFieldOfView"}: invalid argument #{_lastArgPos}: {_lastArg} ({_lastArg.Type}), expected: {_expectedType.FullName}", 2);
        });
        private static readonly global::Lua.LuaFunction __index = new(global::Lua.Runtime.Metamethods.Index, (_context, _) =>
        {
            var _this = _context.GetArgument<LuaCameraType>(0);
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
            var _this = _context.GetArgument<LuaCameraType>(0);
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
                case "new": _value = _LuaCamera_new; return true;
                case "FieldOfViewToFocalLength": _value = _LuaCamera_FieldOfViewToFocalLength; return true;
                case "FocalLengthToFieldOfView": _value = _LuaCamera_FocalLengthToFieldOfView; return true;
                case "GetAllCameras": _value = _LuaCamera_GetAllCameras; return true;
                case "HorizontalToVerticalFieldOfView": _value = _LuaCamera_HorizontalToVerticalFieldOfView; return true;
                case "SetupCurrent": _value = _LuaCamera_SetupCurrent; return true;
                case "VerticalToHorizontalFieldOfView": _value = _LuaCamera_VerticalToHorizontalFieldOfView; return true;
                case "allCameras": _value = _factory.Bind(global::UnityEngine.Camera.allCameras); return true;
                case "allCamerasCount": _value = new global::Lua.LuaValue(global::UnityEngine.Camera.allCamerasCount); return true;
                case "current": _value = _factory.Bind(global::UnityEngine.Camera.current); return true;
                case "main": _value = _factory.Bind(global::UnityEngine.Camera.main); return true;
                case "kMaxAperture": _value = new global::Lua.LuaValue(global::UnityEngine.Camera.kMaxAperture); return true;
                case "kMaxBladeCount": _value = new global::Lua.LuaValue(global::UnityEngine.Camera.kMaxBladeCount); return true;
                case "kMinAperture": _value = new global::Lua.LuaValue(global::UnityEngine.Camera.kMinAperture); return true;
                case "kMinBladeCount": _value = new global::Lua.LuaValue(global::UnityEngine.Camera.kMinBladeCount); return true;
                case "onPostRender": _value = _factory.Bind(global::UnityEngine.Camera.onPostRender); return true;
                case "onPreCull": _value = _factory.Bind(global::UnityEngine.Camera.onPreCull); return true;
                case "onPreRender": _value = _factory.Bind(global::UnityEngine.Camera.onPreRender); return true;
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
                case "onPostRender": global::UnityEngine.Camera.onPostRender = _value.Read<global::UnityEngine.Camera.CameraCallback>();  return true;
                case "onPreCull": global::UnityEngine.Camera.onPreCull = _value.Read<global::UnityEngine.Camera.CameraCallback>();  return true;
                case "onPreRender": global::UnityEngine.Camera.onPreRender = _value.Read<global::UnityEngine.Camera.CameraCallback>();  return true;
                default: return false;
            }
        }
    }
}
#pragma warning restore 0109, 0162, 0168, 0219
#endif
