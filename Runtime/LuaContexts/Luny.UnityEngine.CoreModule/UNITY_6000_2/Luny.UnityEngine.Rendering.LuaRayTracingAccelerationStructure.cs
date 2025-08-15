
// --------------------------------------------------------------
// GENERATED FILE ----> DO NOT EDIT <---- CHANGES WILL BE LOST !!
// --------------------------------------------------------------

#if UNITY_6000_2_OR_NEWER && !(UNITY_6000_3_OR_NEWER)
#pragma warning disable 0109, 0162, 0168, 0219
using Luny;

namespace Luny.UnityEngine.Rendering
{
    public sealed class LuaRayTracingAccelerationStructure : global::Luny.ILuaObject<global::UnityEngine.Rendering.RayTracingAccelerationStructure>
    {
        public new static global::Lua.LuaValue Bind(global::UnityEngine.Rendering.RayTracingAccelerationStructure instance) => new LuaRayTracingAccelerationStructure(instance);
        public new static global::Lua.LuaValue Bind(global::System.Object instance) => Bind((global::UnityEngine.Rendering.RayTracingAccelerationStructure)instance);
        public new static global::Lua.LuaValue Bind(global::System.Collections.Generic.IList<global::UnityEngine.Rendering.RayTracingAccelerationStructure> instances) =>
            new global::Luny.LuaList<global::UnityEngine.Rendering.RayTracingAccelerationStructure>(instances);
        public new static global::Lua.LuaValue Bind(global::System.Collections.Generic.IList<global::System.Object> instances) =>
            new global::Luny.LuaList<global::UnityEngine.Rendering.RayTracingAccelerationStructure>(instances);
        private LuaRayTracingAccelerationStructure(global::UnityEngine.Rendering.RayTracingAccelerationStructure instance) => m_Instance = instance;
        public static implicit operator global::Lua.LuaValue(LuaRayTracingAccelerationStructure value) => new(value);
        private global::UnityEngine.Rendering.RayTracingAccelerationStructure m_Instance;
        public global::UnityEngine.Rendering.RayTracingAccelerationStructure Instance => m_Instance;
        public new global::System.Type BindType => typeof(global::UnityEngine.Rendering.RayTracingAccelerationStructure);
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

        private static readonly global::Lua.LuaFunction _LuaRayTracingAccelerationStructure_AddInstance = new global::Lua.LuaFunction("AddInstance", (_context, _) =>
        {
            global::Lua.LuaValue _lastArg = default;
            global::System.Int32 _lastArgPos = default;
            global::System.Type _expectedType = default;
            var _argCount = _context.ArgumentCount;
            var _this = _context.GetArgument<LuaRayTracingAccelerationStructure>(0);
            var _arg0 = _lastArg = _argCount > 1 ? _context.GetArgument(1) : global::Lua.LuaValue.Nil;
            _lastArgPos = 0; _expectedType = typeof(global::Luny.UnityEngine.Rendering.LuaRayTracingAABBsInstanceConfig);
            if (_arg0.TryRead<global::Luny.UnityEngine.Rendering.LuaRayTracingAABBsInstanceConfig>(out var _p0_UnityEngine_Rendering_RayTracingAABBsInstanceConfig))
            {
                var _arg1 = _lastArg = _argCount > 2 ? _context.GetArgument(2) : global::Lua.LuaValue.Nil;
                _lastArgPos = 1; _expectedType = typeof(global::Luny.UnityEngine.LuaMatrix4x4);
                if (_arg1.TryRead<global::Luny.UnityEngine.LuaMatrix4x4>(out var _p1_UnityEngine_Matrix4x4))
                {
                    if (_argCount == 3)
                    {
                        var config = _p0_UnityEngine_Rendering_RayTracingAABBsInstanceConfig.Value;
                        var matrix = _p1_UnityEngine_Matrix4x4.Value;
                        var _ret0 = _this.Instance.AddInstance(config, matrix);
                        var _lret0 = new global::Lua.LuaValue(_ret0);
                        var _retCount = _context.Return(_lret0);
                        return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                    }
                    var _arg2 = _lastArg = _argCount > 3 ? _context.GetArgument(3) : global::Lua.LuaValue.Nil;
                    _lastArgPos = 2; _expectedType = typeof(global::System.UInt32);
                    var _p2_System_UInt32 = _arg2.ReadValue<global::System.UInt32>((global::System.UInt32)(4294967295));
                    {
                        if (_argCount == 4)
                        {
                            var config = _p0_UnityEngine_Rendering_RayTracingAABBsInstanceConfig.Value;
                            var matrix = _p1_UnityEngine_Matrix4x4.Value;
                            var id = _p2_System_UInt32;
                            var _ret0 = _this.Instance.AddInstance(config, matrix, id);
                            var _lret0 = new global::Lua.LuaValue(_ret0);
                            var _retCount = _context.Return(_lret0);
                            return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                        }
                    }
                }
            }
            _lastArgPos = 0; _expectedType = typeof(global::Luny.UnityEngine.LuaRenderer);
            if (_arg0.TryRead<global::Luny.UnityEngine.LuaRenderer>(out var _p0_UnityEngine_Renderer))
            {
                var _arg1 = _lastArg = _argCount > 2 ? _context.GetArgument(2) : global::Lua.LuaValue.Nil;
                _lastArgPos = 1; _expectedType = typeof(global::UnityEngine.Rendering.RayTracingSubMeshFlags[]);
                if (_arg1.TryReadArray<global::UnityEngine.Rendering.RayTracingSubMeshFlags>(out var _p1_UnityEngine_Rendering_RayTracingSubMeshFlagsArray))
                {
                    if (_argCount == 3)
                    {
                        var targetRenderer = _p0_UnityEngine_Renderer.Instance;
                        var subMeshFlags = _p1_UnityEngine_Rendering_RayTracingSubMeshFlagsArray;
                        var _ret0 = _this.Instance.AddInstance(targetRenderer, subMeshFlags);
                        var _lret0 = new global::Lua.LuaValue(_ret0);
                        var _retCount = _context.Return(_lret0);
                        return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                    }
                    var _arg2 = _lastArg = _argCount > 3 ? _context.GetArgument(3) : global::Lua.LuaValue.Nil;
                    _lastArgPos = 2; _expectedType = typeof(global::System.Boolean);
                    var _p2_System_Boolean = _arg2.ReadValue<global::System.Boolean>((global::System.Boolean)true);
                    {
                        if (_argCount == 4)
                        {
                            var targetRenderer = _p0_UnityEngine_Renderer.Instance;
                            var subMeshFlags = _p1_UnityEngine_Rendering_RayTracingSubMeshFlagsArray;
                            var enableTriangleCulling = _p2_System_Boolean;
                            var _ret0 = _this.Instance.AddInstance(targetRenderer, subMeshFlags, enableTriangleCulling);
                            var _lret0 = new global::Lua.LuaValue(_ret0);
                            var _retCount = _context.Return(_lret0);
                            return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                        }
                        var _arg3 = _lastArg = _argCount > 4 ? _context.GetArgument(4) : global::Lua.LuaValue.Nil;
                        _lastArgPos = 3; _expectedType = typeof(global::System.Boolean);
                        var _p3_System_Boolean = _arg3.ReadValue<global::System.Boolean>((global::System.Boolean)false);
                        {
                            if (_argCount == 5)
                            {
                                var targetRenderer = _p0_UnityEngine_Renderer.Instance;
                                var subMeshFlags = _p1_UnityEngine_Rendering_RayTracingSubMeshFlagsArray;
                                var enableTriangleCulling = _p2_System_Boolean;
                                var frontTriangleCounterClockwise = _p3_System_Boolean;
                                var _ret0 = _this.Instance.AddInstance(targetRenderer, subMeshFlags, enableTriangleCulling, frontTriangleCounterClockwise);
                                var _lret0 = new global::Lua.LuaValue(_ret0);
                                var _retCount = _context.Return(_lret0);
                                return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                            }
                            var _arg4 = _lastArg = _argCount > 5 ? _context.GetArgument(5) : global::Lua.LuaValue.Nil;
                            _lastArgPos = 4; _expectedType = typeof(global::System.UInt32);
                            var _p4_System_UInt32 = _arg4.ReadValue<global::System.UInt32>((global::System.UInt32)(255));
                            {
                                if (_argCount == 6)
                                {
                                    var targetRenderer = _p0_UnityEngine_Renderer.Instance;
                                    var subMeshFlags = _p1_UnityEngine_Rendering_RayTracingSubMeshFlagsArray;
                                    var enableTriangleCulling = _p2_System_Boolean;
                                    var frontTriangleCounterClockwise = _p3_System_Boolean;
                                    var mask = _p4_System_UInt32;
                                    var _ret0 = _this.Instance.AddInstance(targetRenderer, subMeshFlags, enableTriangleCulling, frontTriangleCounterClockwise, mask);
                                    var _lret0 = new global::Lua.LuaValue(_ret0);
                                    var _retCount = _context.Return(_lret0);
                                    return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                                }
                                var _arg5 = _lastArg = _argCount > 6 ? _context.GetArgument(6) : global::Lua.LuaValue.Nil;
                                _lastArgPos = 5; _expectedType = typeof(global::System.UInt32);
                                var _p5_System_UInt32 = _arg5.ReadValue<global::System.UInt32>((global::System.UInt32)(4294967295));
                                {
                                    if (_argCount == 7)
                                    {
                                        var targetRenderer = _p0_UnityEngine_Renderer.Instance;
                                        var subMeshFlags = _p1_UnityEngine_Rendering_RayTracingSubMeshFlagsArray;
                                        var enableTriangleCulling = _p2_System_Boolean;
                                        var frontTriangleCounterClockwise = _p3_System_Boolean;
                                        var mask = _p4_System_UInt32;
                                        var id = _p5_System_UInt32;
                                        var _ret0 = _this.Instance.AddInstance(targetRenderer, subMeshFlags, enableTriangleCulling, frontTriangleCounterClockwise, mask, id);
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
            throw new global::Lua.LuaRuntimeException(_context.Thread, $"{"AddInstance"}: invalid argument #{_lastArgPos}: {_lastArg} ({_lastArg.Type}), expected: {_expectedType.FullName}", 2);
        });
        private static readonly global::Lua.LuaFunction _LuaRayTracingAccelerationStructure_AddVFXInstances = new global::Lua.LuaFunction("AddVFXInstances", (_context, _) =>
        {
            global::Lua.LuaValue _lastArg = default;
            global::System.Int32 _lastArgPos = default;
            global::System.Type _expectedType = default;
            var _argCount = _context.ArgumentCount;
            var _this = _context.GetArgument<LuaRayTracingAccelerationStructure>(0);
            var _arg0 = _lastArg = _argCount > 1 ? _context.GetArgument(1) : global::Lua.LuaValue.Nil;
            _lastArgPos = 0; _expectedType = typeof(global::Luny.UnityEngine.LuaRenderer);
            if (_arg0.TryRead<global::Luny.UnityEngine.LuaRenderer>(out var _p0_UnityEngine_Renderer))
            {
                var _arg1 = _lastArg = _argCount > 2 ? _context.GetArgument(2) : global::Lua.LuaValue.Nil;
                _lastArgPos = 1; _expectedType = typeof(global::System.UInt32[]);
                if (_arg1.TryReadArray<global::System.UInt32>(out var _p1_System_UInt32Array))
                {
                    if (_argCount == 3)
                    {
                        var targetRenderer = _p0_UnityEngine_Renderer.Instance;
                        var vfxSystemMasks = _p1_System_UInt32Array;
                        _this.Instance.AddVFXInstances(targetRenderer, vfxSystemMasks);
                        var _retCount = _context.Return();
                        return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                    }
                }
            }
            throw new global::Lua.LuaRuntimeException(_context.Thread, $"{"AddVFXInstances"}: invalid argument #{_lastArgPos}: {_lastArg} ({_lastArg.Type}), expected: {_expectedType.FullName}", 2);
        });
        private static readonly global::Lua.LuaFunction _LuaRayTracingAccelerationStructure_Build = new global::Lua.LuaFunction("Build", (_context, _) =>
        {
            global::Lua.LuaValue _lastArg = default;
            global::System.Int32 _lastArgPos = default;
            global::System.Type _expectedType = default;
            var _argCount = _context.ArgumentCount;
            var _this = _context.GetArgument<LuaRayTracingAccelerationStructure>(0);
            if (_argCount == 1)
            {
                _this.Instance.Build();
                var _retCount = _context.Return();
                return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
            }
            var _arg0 = _lastArg = _argCount > 1 ? _context.GetArgument(1) : global::Lua.LuaValue.Nil;
            _lastArgPos = 0; _expectedType = typeof(global::Luny.UnityEngine.LuaVector3);
            if (_arg0.TryRead<global::Luny.UnityEngine.LuaVector3>(out var _p0_UnityEngine_Vector3))
            {
                if (_argCount == 2)
                {
                    var relativeOrigin = _p0_UnityEngine_Vector3.Value;
                    _this.Instance.Build(relativeOrigin);
                    var _retCount = _context.Return();
                    return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                }
            }
            _lastArgPos = 0; _expectedType = typeof(global::Luny.UnityEngine.Rendering.LuaRayTracingAccelerationStructureBuildSettings);
            if (_arg0.TryRead<global::Luny.UnityEngine.Rendering.LuaRayTracingAccelerationStructureBuildSettings>(out var _p0_UnityEngine_Rendering_RayTracingAccelerationStructure_BuildSettings))
            {
                if (_argCount == 2)
                {
                    var buildSettings = _p0_UnityEngine_Rendering_RayTracingAccelerationStructure_BuildSettings.Value;
                    _this.Instance.Build(buildSettings);
                    var _retCount = _context.Return();
                    return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                }
            }
            throw new global::Lua.LuaRuntimeException(_context.Thread, $"{"Build"}: invalid argument #{_lastArgPos}: {_lastArg} ({_lastArg.Type}), expected: {_expectedType.FullName}", 2);
        });
        private static readonly global::Lua.LuaFunction _LuaRayTracingAccelerationStructure_ClearInstances = new global::Lua.LuaFunction("ClearInstances", (_context, _) =>
        {
            global::Lua.LuaValue _lastArg = default;
            global::System.Int32 _lastArgPos = default;
            global::System.Type _expectedType = default;
            var _argCount = _context.ArgumentCount;
            var _this = _context.GetArgument<LuaRayTracingAccelerationStructure>(0);
            if (_argCount == 1)
            {
                _this.Instance.ClearInstances();
                var _retCount = _context.Return();
                return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
            }
            throw new global::Lua.LuaRuntimeException(_context.Thread, $"{"ClearInstances"}: invalid argument #{_lastArgPos}: {_lastArg} ({_lastArg.Type}), expected: {_expectedType.FullName}", 2);
        });
        private static readonly global::Lua.LuaFunction _LuaRayTracingAccelerationStructure_Dispose = new global::Lua.LuaFunction("Dispose", (_context, _) =>
        {
            global::Lua.LuaValue _lastArg = default;
            global::System.Int32 _lastArgPos = default;
            global::System.Type _expectedType = default;
            var _argCount = _context.ArgumentCount;
            var _this = _context.GetArgument<LuaRayTracingAccelerationStructure>(0);
            if (_argCount == 1)
            {
                _this.Instance.Dispose();
                var _retCount = _context.Return();
                return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
            }
            throw new global::Lua.LuaRuntimeException(_context.Thread, $"{"Dispose"}: invalid argument #{_lastArgPos}: {_lastArg} ({_lastArg.Type}), expected: {_expectedType.FullName}", 2);
        });
        private static readonly global::Lua.LuaFunction _LuaRayTracingAccelerationStructure_GetInstanceCount = new global::Lua.LuaFunction("GetInstanceCount", (_context, _) =>
        {
            global::Lua.LuaValue _lastArg = default;
            global::System.Int32 _lastArgPos = default;
            global::System.Type _expectedType = default;
            var _argCount = _context.ArgumentCount;
            var _this = _context.GetArgument<LuaRayTracingAccelerationStructure>(0);
            if (_argCount == 1)
            {
                var _ret0 = _this.Instance.GetInstanceCount();
                var _lret0 = new global::Lua.LuaValue(_ret0);
                var _retCount = _context.Return(_lret0);
                return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
            }
            throw new global::Lua.LuaRuntimeException(_context.Thread, $"{"GetInstanceCount"}: invalid argument #{_lastArgPos}: {_lastArg} ({_lastArg.Type}), expected: {_expectedType.FullName}", 2);
        });
        private static readonly global::Lua.LuaFunction _LuaRayTracingAccelerationStructure_GetSize = new global::Lua.LuaFunction("GetSize", (_context, _) =>
        {
            global::Lua.LuaValue _lastArg = default;
            global::System.Int32 _lastArgPos = default;
            global::System.Type _expectedType = default;
            var _argCount = _context.ArgumentCount;
            var _this = _context.GetArgument<LuaRayTracingAccelerationStructure>(0);
            if (_argCount == 1)
            {
                var _ret0 = _this.Instance.GetSize();
                var _lret0 = new global::Lua.LuaValue(_ret0);
                var _retCount = _context.Return(_lret0);
                return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
            }
            throw new global::Lua.LuaRuntimeException(_context.Thread, $"{"GetSize"}: invalid argument #{_lastArgPos}: {_lastArg} ({_lastArg.Type}), expected: {_expectedType.FullName}", 2);
        });
        private static readonly global::Lua.LuaFunction _LuaRayTracingAccelerationStructure_Release = new global::Lua.LuaFunction("Release", (_context, _) =>
        {
            global::Lua.LuaValue _lastArg = default;
            global::System.Int32 _lastArgPos = default;
            global::System.Type _expectedType = default;
            var _argCount = _context.ArgumentCount;
            var _this = _context.GetArgument<LuaRayTracingAccelerationStructure>(0);
            if (_argCount == 1)
            {
                _this.Instance.Release();
                var _retCount = _context.Return();
                return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
            }
            throw new global::Lua.LuaRuntimeException(_context.Thread, $"{"Release"}: invalid argument #{_lastArgPos}: {_lastArg} ({_lastArg.Type}), expected: {_expectedType.FullName}", 2);
        });
        private static readonly global::Lua.LuaFunction _LuaRayTracingAccelerationStructure_RemoveInstance = new global::Lua.LuaFunction("RemoveInstance", (_context, _) =>
        {
            global::Lua.LuaValue _lastArg = default;
            global::System.Int32 _lastArgPos = default;
            global::System.Type _expectedType = default;
            var _argCount = _context.ArgumentCount;
            var _this = _context.GetArgument<LuaRayTracingAccelerationStructure>(0);
            var _arg0 = _lastArg = _argCount > 1 ? _context.GetArgument(1) : global::Lua.LuaValue.Nil;
            _lastArgPos = 0; _expectedType = typeof(global::System.Int32);
            if (_arg0.TryRead<global::System.Int32>(out var _p0_System_Int32))
            {
                if (_argCount == 2)
                {
                    var handle = _p0_System_Int32;
                    _this.Instance.RemoveInstance(handle);
                    var _retCount = _context.Return();
                    return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                }
            }
            _lastArgPos = 0; _expectedType = typeof(global::Luny.UnityEngine.LuaRenderer);
            if (_arg0.TryRead<global::Luny.UnityEngine.LuaRenderer>(out var _p0_UnityEngine_Renderer))
            {
                if (_argCount == 2)
                {
                    var targetRenderer = _p0_UnityEngine_Renderer.Instance;
                    _this.Instance.RemoveInstance(targetRenderer);
                    var _retCount = _context.Return();
                    return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                }
            }
            throw new global::Lua.LuaRuntimeException(_context.Thread, $"{"RemoveInstance"}: invalid argument #{_lastArgPos}: {_lastArg} ({_lastArg.Type}), expected: {_expectedType.FullName}", 2);
        });
        private static readonly global::Lua.LuaFunction _LuaRayTracingAccelerationStructure_RemoveInstances = new global::Lua.LuaFunction("RemoveInstances", (_context, _) =>
        {
            global::Lua.LuaValue _lastArg = default;
            global::System.Int32 _lastArgPos = default;
            global::System.Type _expectedType = default;
            var _argCount = _context.ArgumentCount;
            var _this = _context.GetArgument<LuaRayTracingAccelerationStructure>(0);
            var _arg0 = _lastArg = _argCount > 1 ? _context.GetArgument(1) : global::Lua.LuaValue.Nil;
            _lastArgPos = 0; _expectedType = typeof(global::System.Int32);
            if (_arg0.TryRead<global::System.Int32>(out var _p0_System_Int32))
            {
                var _arg1 = _lastArg = _argCount > 2 ? _context.GetArgument(2) : global::Lua.LuaValue.Nil;
                _lastArgPos = 1; _expectedType = typeof(global::UnityEngine.Rendering.RayTracingAccelerationStructure.RayTracingModeMask);
                if (_arg1.TryRead<global::UnityEngine.Rendering.RayTracingAccelerationStructure.RayTracingModeMask>(out var _p1_UnityEngine_Rendering_RayTracingAccelerationStructure_RayTracingModeMask))
                {
                    if (_argCount == 3)
                    {
                        var layerMask = _p0_System_Int32;
                        var rayTracingModeMask = _p1_UnityEngine_Rendering_RayTracingAccelerationStructure_RayTracingModeMask;
                        _this.Instance.RemoveInstances(layerMask, rayTracingModeMask);
                        var _retCount = _context.Return();
                        return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                    }
                }
            }
            throw new global::Lua.LuaRuntimeException(_context.Thread, $"{"RemoveInstances"}: invalid argument #{_lastArgPos}: {_lastArg} ({_lastArg.Type}), expected: {_expectedType.FullName}", 2);
        });
        private static readonly global::Lua.LuaFunction _LuaRayTracingAccelerationStructure_RemoveVFXInstances = new global::Lua.LuaFunction("RemoveVFXInstances", (_context, _) =>
        {
            global::Lua.LuaValue _lastArg = default;
            global::System.Int32 _lastArgPos = default;
            global::System.Type _expectedType = default;
            var _argCount = _context.ArgumentCount;
            var _this = _context.GetArgument<LuaRayTracingAccelerationStructure>(0);
            var _arg0 = _lastArg = _argCount > 1 ? _context.GetArgument(1) : global::Lua.LuaValue.Nil;
            _lastArgPos = 0; _expectedType = typeof(global::Luny.UnityEngine.LuaRenderer);
            if (_arg0.TryRead<global::Luny.UnityEngine.LuaRenderer>(out var _p0_UnityEngine_Renderer))
            {
                if (_argCount == 2)
                {
                    var targetRenderer = _p0_UnityEngine_Renderer.Instance;
                    _this.Instance.RemoveVFXInstances(targetRenderer);
                    var _retCount = _context.Return();
                    return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                }
            }
            throw new global::Lua.LuaRuntimeException(_context.Thread, $"{"RemoveVFXInstances"}: invalid argument #{_lastArgPos}: {_lastArg} ({_lastArg.Type}), expected: {_expectedType.FullName}", 2);
        });
        private static readonly global::Lua.LuaFunction _LuaRayTracingAccelerationStructure_UpdateInstanceGeometry = new global::Lua.LuaFunction("UpdateInstanceGeometry", (_context, _) =>
        {
            global::Lua.LuaValue _lastArg = default;
            global::System.Int32 _lastArgPos = default;
            global::System.Type _expectedType = default;
            var _argCount = _context.ArgumentCount;
            var _this = _context.GetArgument<LuaRayTracingAccelerationStructure>(0);
            var _arg0 = _lastArg = _argCount > 1 ? _context.GetArgument(1) : global::Lua.LuaValue.Nil;
            _lastArgPos = 0; _expectedType = typeof(global::System.Int32);
            if (_arg0.TryRead<global::System.Int32>(out var _p0_System_Int32))
            {
                if (_argCount == 2)
                {
                    var handle = _p0_System_Int32;
                    _this.Instance.UpdateInstanceGeometry(handle);
                    var _retCount = _context.Return();
                    return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                }
            }
            _lastArgPos = 0; _expectedType = typeof(global::Luny.UnityEngine.LuaRenderer);
            if (_arg0.TryRead<global::Luny.UnityEngine.LuaRenderer>(out var _p0_UnityEngine_Renderer))
            {
                if (_argCount == 2)
                {
                    var renderer = _p0_UnityEngine_Renderer.Instance;
                    _this.Instance.UpdateInstanceGeometry(renderer);
                    var _retCount = _context.Return();
                    return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                }
            }
            throw new global::Lua.LuaRuntimeException(_context.Thread, $"{"UpdateInstanceGeometry"}: invalid argument #{_lastArgPos}: {_lastArg} ({_lastArg.Type}), expected: {_expectedType.FullName}", 2);
        });
        private static readonly global::Lua.LuaFunction _LuaRayTracingAccelerationStructure_UpdateInstanceID = new global::Lua.LuaFunction("UpdateInstanceID", (_context, _) =>
        {
            global::Lua.LuaValue _lastArg = default;
            global::System.Int32 _lastArgPos = default;
            global::System.Type _expectedType = default;
            var _argCount = _context.ArgumentCount;
            var _this = _context.GetArgument<LuaRayTracingAccelerationStructure>(0);
            var _arg0 = _lastArg = _argCount > 1 ? _context.GetArgument(1) : global::Lua.LuaValue.Nil;
            _lastArgPos = 0; _expectedType = typeof(global::System.Int32);
            if (_arg0.TryRead<global::System.Int32>(out var _p0_System_Int32))
            {
                var _arg1 = _lastArg = _argCount > 2 ? _context.GetArgument(2) : global::Lua.LuaValue.Nil;
                _lastArgPos = 1; _expectedType = typeof(global::System.UInt32);
                if (_arg1.TryRead<global::System.UInt32>(out var _p1_System_UInt32))
                {
                    if (_argCount == 3)
                    {
                        var handle = _p0_System_Int32;
                        var instanceID = _p1_System_UInt32;
                        _this.Instance.UpdateInstanceID(handle, instanceID);
                        var _retCount = _context.Return();
                        return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                    }
                }
            }
            _lastArgPos = 0; _expectedType = typeof(global::Luny.UnityEngine.LuaRenderer);
            if (_arg0.TryRead<global::Luny.UnityEngine.LuaRenderer>(out var _p0_UnityEngine_Renderer))
            {
                var _arg1 = _lastArg = _argCount > 2 ? _context.GetArgument(2) : global::Lua.LuaValue.Nil;
                _lastArgPos = 1; _expectedType = typeof(global::System.UInt32);
                if (_arg1.TryRead<global::System.UInt32>(out var _p1_System_UInt32))
                {
                    if (_argCount == 3)
                    {
                        var renderer = _p0_UnityEngine_Renderer.Instance;
                        var instanceID = _p1_System_UInt32;
                        _this.Instance.UpdateInstanceID(renderer, instanceID);
                        var _retCount = _context.Return();
                        return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                    }
                }
            }
            throw new global::Lua.LuaRuntimeException(_context.Thread, $"{"UpdateInstanceID"}: invalid argument #{_lastArgPos}: {_lastArg} ({_lastArg.Type}), expected: {_expectedType.FullName}", 2);
        });
        private static readonly global::Lua.LuaFunction _LuaRayTracingAccelerationStructure_UpdateInstanceMask = new global::Lua.LuaFunction("UpdateInstanceMask", (_context, _) =>
        {
            global::Lua.LuaValue _lastArg = default;
            global::System.Int32 _lastArgPos = default;
            global::System.Type _expectedType = default;
            var _argCount = _context.ArgumentCount;
            var _this = _context.GetArgument<LuaRayTracingAccelerationStructure>(0);
            var _arg0 = _lastArg = _argCount > 1 ? _context.GetArgument(1) : global::Lua.LuaValue.Nil;
            _lastArgPos = 0; _expectedType = typeof(global::System.Int32);
            if (_arg0.TryRead<global::System.Int32>(out var _p0_System_Int32))
            {
                var _arg1 = _lastArg = _argCount > 2 ? _context.GetArgument(2) : global::Lua.LuaValue.Nil;
                _lastArgPos = 1; _expectedType = typeof(global::System.UInt32);
                if (_arg1.TryRead<global::System.UInt32>(out var _p1_System_UInt32))
                {
                    if (_argCount == 3)
                    {
                        var handle = _p0_System_Int32;
                        var mask = _p1_System_UInt32;
                        _this.Instance.UpdateInstanceMask(handle, mask);
                        var _retCount = _context.Return();
                        return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                    }
                }
            }
            _lastArgPos = 0; _expectedType = typeof(global::Luny.UnityEngine.LuaRenderer);
            if (_arg0.TryRead<global::Luny.UnityEngine.LuaRenderer>(out var _p0_UnityEngine_Renderer))
            {
                var _arg1 = _lastArg = _argCount > 2 ? _context.GetArgument(2) : global::Lua.LuaValue.Nil;
                _lastArgPos = 1; _expectedType = typeof(global::System.UInt32);
                if (_arg1.TryRead<global::System.UInt32>(out var _p1_System_UInt32))
                {
                    if (_argCount == 3)
                    {
                        var renderer = _p0_UnityEngine_Renderer.Instance;
                        var mask = _p1_System_UInt32;
                        _this.Instance.UpdateInstanceMask(renderer, mask);
                        var _retCount = _context.Return();
                        return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                    }
                }
            }
            throw new global::Lua.LuaRuntimeException(_context.Thread, $"{"UpdateInstanceMask"}: invalid argument #{_lastArgPos}: {_lastArg} ({_lastArg.Type}), expected: {_expectedType.FullName}", 2);
        });
        private static readonly global::Lua.LuaFunction _LuaRayTracingAccelerationStructure_UpdateInstancePropertyBlock = new global::Lua.LuaFunction("UpdateInstancePropertyBlock", (_context, _) =>
        {
            global::Lua.LuaValue _lastArg = default;
            global::System.Int32 _lastArgPos = default;
            global::System.Type _expectedType = default;
            var _argCount = _context.ArgumentCount;
            var _this = _context.GetArgument<LuaRayTracingAccelerationStructure>(0);
            var _arg0 = _lastArg = _argCount > 1 ? _context.GetArgument(1) : global::Lua.LuaValue.Nil;
            _lastArgPos = 0; _expectedType = typeof(global::System.Int32);
            if (_arg0.TryRead<global::System.Int32>(out var _p0_System_Int32))
            {
                var _arg1 = _lastArg = _argCount > 2 ? _context.GetArgument(2) : global::Lua.LuaValue.Nil;
                _lastArgPos = 1; _expectedType = typeof(global::Luny.UnityEngine.LuaMaterialPropertyBlock);
                if (_arg1.TryRead<global::Luny.UnityEngine.LuaMaterialPropertyBlock>(out var _p1_UnityEngine_MaterialPropertyBlock))
                {
                    if (_argCount == 3)
                    {
                        var handle = _p0_System_Int32;
                        var properties = _p1_UnityEngine_MaterialPropertyBlock.Instance;
                        _this.Instance.UpdateInstancePropertyBlock(handle, properties);
                        var _retCount = _context.Return();
                        return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                    }
                }
            }
            throw new global::Lua.LuaRuntimeException(_context.Thread, $"{"UpdateInstancePropertyBlock"}: invalid argument #{_lastArgPos}: {_lastArg} ({_lastArg.Type}), expected: {_expectedType.FullName}", 2);
        });
        private static readonly global::Lua.LuaFunction _LuaRayTracingAccelerationStructure_UpdateInstanceTransform = new global::Lua.LuaFunction("UpdateInstanceTransform", (_context, _) =>
        {
            global::Lua.LuaValue _lastArg = default;
            global::System.Int32 _lastArgPos = default;
            global::System.Type _expectedType = default;
            var _argCount = _context.ArgumentCount;
            var _this = _context.GetArgument<LuaRayTracingAccelerationStructure>(0);
            var _arg0 = _lastArg = _argCount > 1 ? _context.GetArgument(1) : global::Lua.LuaValue.Nil;
            _lastArgPos = 0; _expectedType = typeof(global::Luny.UnityEngine.LuaRenderer);
            if (_arg0.TryRead<global::Luny.UnityEngine.LuaRenderer>(out var _p0_UnityEngine_Renderer))
            {
                if (_argCount == 2)
                {
                    var renderer = _p0_UnityEngine_Renderer.Instance;
                    _this.Instance.UpdateInstanceTransform(renderer);
                    var _retCount = _context.Return();
                    return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                }
            }
            _lastArgPos = 0; _expectedType = typeof(global::System.Int32);
            if (_arg0.TryRead<global::System.Int32>(out var _p0_System_Int32))
            {
                var _arg1 = _lastArg = _argCount > 2 ? _context.GetArgument(2) : global::Lua.LuaValue.Nil;
                _lastArgPos = 1; _expectedType = typeof(global::Luny.UnityEngine.LuaMatrix4x4);
                if (_arg1.TryRead<global::Luny.UnityEngine.LuaMatrix4x4>(out var _p1_UnityEngine_Matrix4x4))
                {
                    if (_argCount == 3)
                    {
                        var handle = _p0_System_Int32;
                        var matrix = _p1_UnityEngine_Matrix4x4.Value;
                        _this.Instance.UpdateInstanceTransform(handle, matrix);
                        var _retCount = _context.Return();
                        return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                    }
                }
            }
            throw new global::Lua.LuaRuntimeException(_context.Thread, $"{"UpdateInstanceTransform"}: invalid argument #{_lastArgPos}: {_lastArg} ({_lastArg.Type}), expected: {_expectedType.FullName}", 2);
        });
        private static readonly global::Lua.LuaFunction __index = new(global::Lua.Runtime.Metamethods.Index, (_context, _) =>
        {
            var _this = _context.GetArgument<LuaRayTracingAccelerationStructure>(0);
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
            var _this = _context.GetArgument<LuaRayTracingAccelerationStructure>(0);
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
                case "AddInstance": _value = _LuaRayTracingAccelerationStructure_AddInstance; return true;
                case "AddVFXInstances": _value = _LuaRayTracingAccelerationStructure_AddVFXInstances; return true;
                case "Build": _value = _LuaRayTracingAccelerationStructure_Build; return true;
                case "ClearInstances": _value = _LuaRayTracingAccelerationStructure_ClearInstances; return true;
                case "Dispose": _value = _LuaRayTracingAccelerationStructure_Dispose; return true;
                case "GetInstanceCount": _value = _LuaRayTracingAccelerationStructure_GetInstanceCount; return true;
                case "GetSize": _value = _LuaRayTracingAccelerationStructure_GetSize; return true;
                case "Release": _value = _LuaRayTracingAccelerationStructure_Release; return true;
                case "RemoveInstance": _value = _LuaRayTracingAccelerationStructure_RemoveInstance; return true;
                case "RemoveInstances": _value = _LuaRayTracingAccelerationStructure_RemoveInstances; return true;
                case "RemoveVFXInstances": _value = _LuaRayTracingAccelerationStructure_RemoveVFXInstances; return true;
                case "UpdateInstanceGeometry": _value = _LuaRayTracingAccelerationStructure_UpdateInstanceGeometry; return true;
                case "UpdateInstanceID": _value = _LuaRayTracingAccelerationStructure_UpdateInstanceID; return true;
                case "UpdateInstanceMask": _value = _LuaRayTracingAccelerationStructure_UpdateInstanceMask; return true;
                case "UpdateInstancePropertyBlock": _value = _LuaRayTracingAccelerationStructure_UpdateInstancePropertyBlock; return true;
                case "UpdateInstanceTransform": _value = _LuaRayTracingAccelerationStructure_UpdateInstanceTransform; return true;
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
    public sealed class LuaRayTracingAccelerationStructureType : global::Luny.ILuaStatic
    {
        public static global::Lua.LuaValue Bind() => new LuaRayTracingAccelerationStructureType();
        private LuaRayTracingAccelerationStructureType() {}
        public static implicit operator global::Lua.LuaValue(LuaRayTracingAccelerationStructureType value) => new(value);
        public global::System.Type BindType => typeof(global::UnityEngine.Rendering.RayTracingAccelerationStructure);
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
            metatable[global::Lua.Runtime.Metamethods.Call] = _LuaRayTracingAccelerationStructure_new;
            return metatable;
        }
        public override global::System.String ToString() => BindType.FullName;
#if UNITY_EDITOR
        [global::UnityEngine.RuntimeInitializeOnLoadMethod(global::UnityEngine.RuntimeInitializeLoadType.SubsystemRegistration)]
        private static void ResetStaticFields() => s_Metatable = null;
#endif

        private static readonly global::Lua.LuaFunction _LuaRayTracingAccelerationStructure_new = new global::Lua.LuaFunction(".ctor", (_context, _) =>
        {
            global::Lua.LuaValue _lastArg = default;
            global::System.Int32 _lastArgPos = default;
            global::System.Type _expectedType = default;
            var _argCount = _context.ArgumentCount;
            if (_argCount == 1)
            {
                var _ret0 = new global::UnityEngine.Rendering.RayTracingAccelerationStructure();
                var _factory = _context.GetObjectFactory();
                var _lret0 = _factory.Bind(_ret0);
                var _retCount = _context.Return(_lret0);
                return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
            }
            var _arg0 = _lastArg = _argCount > 1 ? _context.GetArgument(1) : global::Lua.LuaValue.Nil;
            _lastArgPos = 0; _expectedType = typeof(global::Luny.UnityEngine.Rendering.LuaRayTracingAccelerationStructureSettings);
            if (_arg0.TryRead<global::Luny.UnityEngine.Rendering.LuaRayTracingAccelerationStructureSettings>(out var _p0_UnityEngine_Rendering_RayTracingAccelerationStructure_Settings))
            {
                if (_argCount == 2)
                {
                    var settings = _p0_UnityEngine_Rendering_RayTracingAccelerationStructure_Settings.Value;
                    var _ret0 = new global::UnityEngine.Rendering.RayTracingAccelerationStructure(settings);
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
            var _this = _context.GetArgument<LuaRayTracingAccelerationStructureType>(0);
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
            var _this = _context.GetArgument<LuaRayTracingAccelerationStructureType>(0);
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
