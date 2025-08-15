
// --------------------------------------------------------------
// GENERATED FILE ----> DO NOT EDIT <---- CHANGES WILL BE LOST !!
// --------------------------------------------------------------

#if UNITY_6000_1_OR_NEWER && !(UNITY_6000_2_OR_NEWER)
#pragma warning disable 0109, 0162, 0168, 0219
using Luny;

namespace Luny.UnityEngine.Rendering
{
    public sealed class LuaCommandBuffer : global::Luny.ILuaObject<global::UnityEngine.Rendering.CommandBuffer>
    {
        public new static global::Lua.LuaValue Bind(global::UnityEngine.Rendering.CommandBuffer instance) => new LuaCommandBuffer(instance);
        public new static global::Lua.LuaValue Bind(global::System.Object instance) => Bind((global::UnityEngine.Rendering.CommandBuffer)instance);
        public new static global::Lua.LuaValue Bind(global::System.Collections.Generic.IList<global::UnityEngine.Rendering.CommandBuffer> instances) =>
            new global::Luny.LuaList<global::UnityEngine.Rendering.CommandBuffer>(instances);
        public new static global::Lua.LuaValue Bind(global::System.Collections.Generic.IList<global::System.Object> instances) =>
            new global::Luny.LuaList<global::UnityEngine.Rendering.CommandBuffer>(instances);
        private LuaCommandBuffer(global::UnityEngine.Rendering.CommandBuffer instance) => m_Instance = instance;
        public static implicit operator global::Lua.LuaValue(LuaCommandBuffer value) => new(value);
        private global::UnityEngine.Rendering.CommandBuffer m_Instance;
        public global::UnityEngine.Rendering.CommandBuffer Instance => m_Instance;
        public new global::System.Type BindType => typeof(global::UnityEngine.Rendering.CommandBuffer);
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

        private static readonly global::Lua.LuaFunction _LuaCommandBuffer_BeginSample = new global::Lua.LuaFunction("BeginSample", (_context, _) =>
        {
            global::Lua.LuaValue _lastArg = default;
            global::System.Int32 _lastArgPos = default;
            global::System.Type _expectedType = default;
            var _argCount = _context.ArgumentCount;
            var _this = _context.GetArgument<LuaCommandBuffer>(0);
            var _arg0 = _lastArg = _argCount > 1 ? _context.GetArgument(1) : global::Lua.LuaValue.Nil;
            _lastArgPos = 0; _expectedType = typeof(global::Unity.Profiling.ProfilerMarker);
            if (_arg0.TryRead<global::Unity.Profiling.ProfilerMarker>(out var _p0_Unity_Profiling_ProfilerMarker))
            {
                if (_argCount == 2)
                {
                    var marker = _p0_Unity_Profiling_ProfilerMarker;
                    _this.Instance.BeginSample(marker);
                    var _retCount = _context.Return();
                    return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                }
            }
            _lastArgPos = 0; _expectedType = typeof(global::System.String);
            if (_arg0.TryRead<global::System.String>(out var _p0_System_String))
            {
                if (_argCount == 2)
                {
                    var name = _p0_System_String;
                    _this.Instance.BeginSample(name);
                    var _retCount = _context.Return();
                    return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                }
            }
            _lastArgPos = 0; _expectedType = typeof(global::Luny.UnityEngine.Profiling.LuaCustomSampler);
            if (_arg0.TryRead<global::Luny.UnityEngine.Profiling.LuaCustomSampler>(out var _p0_UnityEngine_Profiling_CustomSampler))
            {
                if (_argCount == 2)
                {
                    var sampler = _p0_UnityEngine_Profiling_CustomSampler.Instance;
                    _this.Instance.BeginSample(sampler);
                    var _retCount = _context.Return();
                    return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                }
            }
            throw new global::Lua.LuaRuntimeException(_context.Thread, $"{"BeginSample"}: invalid argument #{_lastArgPos}: {_lastArg} ({_lastArg.Type}), expected: {_expectedType.FullName}", 2);
        });
        private static readonly global::Lua.LuaFunction _LuaCommandBuffer_Blit = new global::Lua.LuaFunction("Blit", (_context, _) =>
        {
            global::Lua.LuaValue _lastArg = default;
            global::System.Int32 _lastArgPos = default;
            global::System.Type _expectedType = default;
            var _argCount = _context.ArgumentCount;
            var _this = _context.GetArgument<LuaCommandBuffer>(0);
            var _arg0 = _lastArg = _argCount > 1 ? _context.GetArgument(1) : global::Lua.LuaValue.Nil;
            _lastArgPos = 0; _expectedType = typeof(global::Luny.UnityEngine.Rendering.LuaRenderTargetIdentifier);
            if (_arg0.TryRead<global::Luny.UnityEngine.Rendering.LuaRenderTargetIdentifier>(out var _p0_UnityEngine_Rendering_RenderTargetIdentifier))
            {
                var _arg1 = _lastArg = _argCount > 2 ? _context.GetArgument(2) : global::Lua.LuaValue.Nil;
                _lastArgPos = 1; _expectedType = typeof(global::Luny.UnityEngine.Rendering.LuaRenderTargetIdentifier);
                if (_arg1.TryRead<global::Luny.UnityEngine.Rendering.LuaRenderTargetIdentifier>(out var _p1_UnityEngine_Rendering_RenderTargetIdentifier))
                {
                    if (_argCount == 3)
                    {
                        var source = _p0_UnityEngine_Rendering_RenderTargetIdentifier.Value;
                        var dest = _p1_UnityEngine_Rendering_RenderTargetIdentifier.Value;
                        _this.Instance.Blit(source, dest);
                        var _retCount = _context.Return();
                        return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                    }
                    var _arg2 = _lastArg = _argCount > 3 ? _context.GetArgument(3) : global::Lua.LuaValue.Nil;
                    _lastArgPos = 2; _expectedType = typeof(global::Luny.UnityEngine.LuaMaterial);
                    if (_arg2.TryRead<global::Luny.UnityEngine.LuaMaterial>(out var _p2_UnityEngine_Material))
                    {
                        if (_argCount == 4)
                        {
                            var source = _p0_UnityEngine_Rendering_RenderTargetIdentifier.Value;
                            var dest = _p1_UnityEngine_Rendering_RenderTargetIdentifier.Value;
                            var mat = _p2_UnityEngine_Material.Instance;
                            _this.Instance.Blit(source, dest, mat);
                            var _retCount = _context.Return();
                            return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                        }
                        var _arg3 = _lastArg = _argCount > 4 ? _context.GetArgument(4) : global::Lua.LuaValue.Nil;
                        _lastArgPos = 3; _expectedType = typeof(global::System.Int32);
                        if (_arg3.TryRead<global::System.Int32>(out var _p3_System_Int32))
                        {
                            if (_argCount == 5)
                            {
                                var source = _p0_UnityEngine_Rendering_RenderTargetIdentifier.Value;
                                var dest = _p1_UnityEngine_Rendering_RenderTargetIdentifier.Value;
                                var mat = _p2_UnityEngine_Material.Instance;
                                var pass = _p3_System_Int32;
                                _this.Instance.Blit(source, dest, mat, pass);
                                var _retCount = _context.Return();
                                return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                            }
                            var _arg4 = _lastArg = _argCount > 5 ? _context.GetArgument(5) : global::Lua.LuaValue.Nil;
                            _lastArgPos = 4; _expectedType = typeof(global::System.Int32);
                            if (_arg4.TryRead<global::System.Int32>(out var _p4_System_Int32))
                            {
                                if (_argCount == 6)
                                {
                                    var source = _p0_UnityEngine_Rendering_RenderTargetIdentifier.Value;
                                    var dest = _p1_UnityEngine_Rendering_RenderTargetIdentifier.Value;
                                    var mat = _p2_UnityEngine_Material.Instance;
                                    var pass = _p3_System_Int32;
                                    var destDepthSlice = _p4_System_Int32;
                                    _this.Instance.Blit(source, dest, mat, pass, destDepthSlice);
                                    var _retCount = _context.Return();
                                    return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                                }
                            }
                        }
                    }
                    _lastArgPos = 2; _expectedType = typeof(global::System.Int32);
                    if (_arg2.TryRead<global::System.Int32>(out var _p2_System_Int32))
                    {
                        var _arg3 = _lastArg = _argCount > 4 ? _context.GetArgument(4) : global::Lua.LuaValue.Nil;
                        _lastArgPos = 3; _expectedType = typeof(global::System.Int32);
                        if (_arg3.TryRead<global::System.Int32>(out var _p3_System_Int32))
                        {
                            if (_argCount == 5)
                            {
                                var source = _p0_UnityEngine_Rendering_RenderTargetIdentifier.Value;
                                var dest = _p1_UnityEngine_Rendering_RenderTargetIdentifier.Value;
                                var sourceDepthSlice = _p2_System_Int32;
                                var destDepthSlice = _p3_System_Int32;
                                _this.Instance.Blit(source, dest, sourceDepthSlice, destDepthSlice);
                                var _retCount = _context.Return();
                                return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                            }
                        }
                    }
                    _lastArgPos = 2; _expectedType = typeof(global::Luny.UnityEngine.LuaVector2);
                    if (_arg2.TryRead<global::Luny.UnityEngine.LuaVector2>(out var _p2_UnityEngine_Vector2))
                    {
                        var _arg3 = _lastArg = _argCount > 4 ? _context.GetArgument(4) : global::Lua.LuaValue.Nil;
                        _lastArgPos = 3; _expectedType = typeof(global::Luny.UnityEngine.LuaVector2);
                        if (_arg3.TryRead<global::Luny.UnityEngine.LuaVector2>(out var _p3_UnityEngine_Vector2))
                        {
                            if (_argCount == 5)
                            {
                                var source = _p0_UnityEngine_Rendering_RenderTargetIdentifier.Value;
                                var dest = _p1_UnityEngine_Rendering_RenderTargetIdentifier.Value;
                                var scale = _p2_UnityEngine_Vector2.Value;
                                var offset = _p3_UnityEngine_Vector2.Value;
                                _this.Instance.Blit(source, dest, scale, offset);
                                var _retCount = _context.Return();
                                return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                            }
                            var _arg4 = _lastArg = _argCount > 5 ? _context.GetArgument(5) : global::Lua.LuaValue.Nil;
                            _lastArgPos = 4; _expectedType = typeof(global::System.Int32);
                            if (_arg4.TryRead<global::System.Int32>(out var _p4_System_Int32))
                            {
                                var _arg5 = _lastArg = _argCount > 6 ? _context.GetArgument(6) : global::Lua.LuaValue.Nil;
                                _lastArgPos = 5; _expectedType = typeof(global::System.Int32);
                                if (_arg5.TryRead<global::System.Int32>(out var _p5_System_Int32))
                                {
                                    if (_argCount == 7)
                                    {
                                        var source = _p0_UnityEngine_Rendering_RenderTargetIdentifier.Value;
                                        var dest = _p1_UnityEngine_Rendering_RenderTargetIdentifier.Value;
                                        var scale = _p2_UnityEngine_Vector2.Value;
                                        var offset = _p3_UnityEngine_Vector2.Value;
                                        var sourceDepthSlice = _p4_System_Int32;
                                        var destDepthSlice = _p5_System_Int32;
                                        _this.Instance.Blit(source, dest, scale, offset, sourceDepthSlice, destDepthSlice);
                                        var _retCount = _context.Return();
                                        return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                                    }
                                }
                            }
                        }
                    }
                }
            }
            _lastArgPos = 0; _expectedType = typeof(global::Luny.UnityEngine.LuaTexture);
            if (_arg0.TryRead<global::Luny.UnityEngine.LuaTexture>(out var _p0_UnityEngine_Texture))
            {
                var _arg1 = _lastArg = _argCount > 2 ? _context.GetArgument(2) : global::Lua.LuaValue.Nil;
                _lastArgPos = 1; _expectedType = typeof(global::Luny.UnityEngine.Rendering.LuaRenderTargetIdentifier);
                if (_arg1.TryRead<global::Luny.UnityEngine.Rendering.LuaRenderTargetIdentifier>(out var _p1_UnityEngine_Rendering_RenderTargetIdentifier))
                {
                    if (_argCount == 3)
                    {
                        var source = _p0_UnityEngine_Texture.Instance;
                        var dest = _p1_UnityEngine_Rendering_RenderTargetIdentifier.Value;
                        _this.Instance.Blit(source, dest);
                        var _retCount = _context.Return();
                        return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                    }
                    var _arg2 = _lastArg = _argCount > 3 ? _context.GetArgument(3) : global::Lua.LuaValue.Nil;
                    _lastArgPos = 2; _expectedType = typeof(global::Luny.UnityEngine.LuaMaterial);
                    if (_arg2.TryRead<global::Luny.UnityEngine.LuaMaterial>(out var _p2_UnityEngine_Material))
                    {
                        if (_argCount == 4)
                        {
                            var source = _p0_UnityEngine_Texture.Instance;
                            var dest = _p1_UnityEngine_Rendering_RenderTargetIdentifier.Value;
                            var mat = _p2_UnityEngine_Material.Instance;
                            _this.Instance.Blit(source, dest, mat);
                            var _retCount = _context.Return();
                            return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                        }
                        var _arg3 = _lastArg = _argCount > 4 ? _context.GetArgument(4) : global::Lua.LuaValue.Nil;
                        _lastArgPos = 3; _expectedType = typeof(global::System.Int32);
                        if (_arg3.TryRead<global::System.Int32>(out var _p3_System_Int32))
                        {
                            if (_argCount == 5)
                            {
                                var source = _p0_UnityEngine_Texture.Instance;
                                var dest = _p1_UnityEngine_Rendering_RenderTargetIdentifier.Value;
                                var mat = _p2_UnityEngine_Material.Instance;
                                var pass = _p3_System_Int32;
                                _this.Instance.Blit(source, dest, mat, pass);
                                var _retCount = _context.Return();
                                return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                            }
                        }
                    }
                    _lastArgPos = 2; _expectedType = typeof(global::Luny.UnityEngine.LuaVector2);
                    if (_arg2.TryRead<global::Luny.UnityEngine.LuaVector2>(out var _p2_UnityEngine_Vector2))
                    {
                        var _arg3 = _lastArg = _argCount > 4 ? _context.GetArgument(4) : global::Lua.LuaValue.Nil;
                        _lastArgPos = 3; _expectedType = typeof(global::Luny.UnityEngine.LuaVector2);
                        if (_arg3.TryRead<global::Luny.UnityEngine.LuaVector2>(out var _p3_UnityEngine_Vector2))
                        {
                            if (_argCount == 5)
                            {
                                var source = _p0_UnityEngine_Texture.Instance;
                                var dest = _p1_UnityEngine_Rendering_RenderTargetIdentifier.Value;
                                var scale = _p2_UnityEngine_Vector2.Value;
                                var offset = _p3_UnityEngine_Vector2.Value;
                                _this.Instance.Blit(source, dest, scale, offset);
                                var _retCount = _context.Return();
                                return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                            }
                        }
                    }
                }
            }
            throw new global::Lua.LuaRuntimeException(_context.Thread, $"{"Blit"}: invalid argument #{_lastArgPos}: {_lastArg} ({_lastArg.Type}), expected: {_expectedType.FullName}", 2);
        });
        private static readonly global::Lua.LuaFunction _LuaCommandBuffer_BuildRayTracingAccelerationStructure = new global::Lua.LuaFunction("BuildRayTracingAccelerationStructure", (_context, _) =>
        {
            global::Lua.LuaValue _lastArg = default;
            global::System.Int32 _lastArgPos = default;
            global::System.Type _expectedType = default;
            var _argCount = _context.ArgumentCount;
            var _this = _context.GetArgument<LuaCommandBuffer>(0);
            var _arg0 = _lastArg = _argCount > 1 ? _context.GetArgument(1) : global::Lua.LuaValue.Nil;
            _lastArgPos = 0; _expectedType = typeof(global::Luny.UnityEngine.Rendering.LuaRayTracingAccelerationStructure);
            if (_arg0.TryRead<global::Luny.UnityEngine.Rendering.LuaRayTracingAccelerationStructure>(out var _p0_UnityEngine_Rendering_RayTracingAccelerationStructure))
            {
                if (_argCount == 2)
                {
                    var accelerationStructure = _p0_UnityEngine_Rendering_RayTracingAccelerationStructure.Instance;
                    _this.Instance.BuildRayTracingAccelerationStructure(accelerationStructure);
                    var _retCount = _context.Return();
                    return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                }
                var _arg1 = _lastArg = _argCount > 2 ? _context.GetArgument(2) : global::Lua.LuaValue.Nil;
                _lastArgPos = 1; _expectedType = typeof(global::Luny.UnityEngine.LuaVector3);
                if (_arg1.TryRead<global::Luny.UnityEngine.LuaVector3>(out var _p1_UnityEngine_Vector3))
                {
                    if (_argCount == 3)
                    {
                        var accelerationStructure = _p0_UnityEngine_Rendering_RayTracingAccelerationStructure.Instance;
                        var relativeOrigin = _p1_UnityEngine_Vector3.Value;
                        _this.Instance.BuildRayTracingAccelerationStructure(accelerationStructure, relativeOrigin);
                        var _retCount = _context.Return();
                        return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                    }
                }
                _lastArgPos = 1; _expectedType = typeof(global::Luny.UnityEngine.Rendering.LuaRayTracingAccelerationStructureBuildSettings);
                if (_arg1.TryRead<global::Luny.UnityEngine.Rendering.LuaRayTracingAccelerationStructureBuildSettings>(out var _p1_UnityEngine_Rendering_RayTracingAccelerationStructure_BuildSettings))
                {
                    if (_argCount == 3)
                    {
                        var accelerationStructure = _p0_UnityEngine_Rendering_RayTracingAccelerationStructure.Instance;
                        var buildSettings = _p1_UnityEngine_Rendering_RayTracingAccelerationStructure_BuildSettings.Value;
                        _this.Instance.BuildRayTracingAccelerationStructure(accelerationStructure, buildSettings);
                        var _retCount = _context.Return();
                        return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                    }
                }
            }
            throw new global::Lua.LuaRuntimeException(_context.Thread, $"{"BuildRayTracingAccelerationStructure"}: invalid argument #{_lastArgPos}: {_lastArg} ({_lastArg.Type}), expected: {_expectedType.FullName}", 2);
        });
        private static readonly global::Lua.LuaFunction _LuaCommandBuffer_Clear = new global::Lua.LuaFunction("Clear", (_context, _) =>
        {
            global::Lua.LuaValue _lastArg = default;
            global::System.Int32 _lastArgPos = default;
            global::System.Type _expectedType = default;
            var _argCount = _context.ArgumentCount;
            var _this = _context.GetArgument<LuaCommandBuffer>(0);
            if (_argCount == 1)
            {
                _this.Instance.Clear();
                var _retCount = _context.Return();
                return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
            }
            throw new global::Lua.LuaRuntimeException(_context.Thread, $"{"Clear"}: invalid argument #{_lastArgPos}: {_lastArg} ({_lastArg.Type}), expected: {_expectedType.FullName}", 2);
        });
        private static readonly global::Lua.LuaFunction _LuaCommandBuffer_ClearRandomWriteTargets = new global::Lua.LuaFunction("ClearRandomWriteTargets", (_context, _) =>
        {
            global::Lua.LuaValue _lastArg = default;
            global::System.Int32 _lastArgPos = default;
            global::System.Type _expectedType = default;
            var _argCount = _context.ArgumentCount;
            var _this = _context.GetArgument<LuaCommandBuffer>(0);
            if (_argCount == 1)
            {
                _this.Instance.ClearRandomWriteTargets();
                var _retCount = _context.Return();
                return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
            }
            throw new global::Lua.LuaRuntimeException(_context.Thread, $"{"ClearRandomWriteTargets"}: invalid argument #{_lastArgPos}: {_lastArg} ({_lastArg.Type}), expected: {_expectedType.FullName}", 2);
        });
        private static readonly global::Lua.LuaFunction _LuaCommandBuffer_ClearRenderTarget = new global::Lua.LuaFunction("ClearRenderTarget", (_context, _) =>
        {
            global::Lua.LuaValue _lastArg = default;
            global::System.Int32 _lastArgPos = default;
            global::System.Type _expectedType = default;
            var _argCount = _context.ArgumentCount;
            var _this = _context.GetArgument<LuaCommandBuffer>(0);
            var _arg0 = _lastArg = _argCount > 1 ? _context.GetArgument(1) : global::Lua.LuaValue.Nil;
            _lastArgPos = 0; _expectedType = typeof(global::System.Boolean);
            if (_arg0.TryRead<global::System.Boolean>(out var _p0_System_Boolean))
            {
                var _arg1 = _lastArg = _argCount > 2 ? _context.GetArgument(2) : global::Lua.LuaValue.Nil;
                _lastArgPos = 1; _expectedType = typeof(global::System.Boolean);
                if (_arg1.TryRead<global::System.Boolean>(out var _p1_System_Boolean))
                {
                    var _arg2 = _lastArg = _argCount > 3 ? _context.GetArgument(3) : global::Lua.LuaValue.Nil;
                    _lastArgPos = 2; _expectedType = typeof(global::Luny.UnityEngine.LuaColor);
                    if (_arg2.TryRead<global::Luny.UnityEngine.LuaColor>(out var _p2_UnityEngine_Color))
                    {
                        if (_argCount == 4)
                        {
                            var clearDepth = _p0_System_Boolean;
                            var clearColor = _p1_System_Boolean;
                            var backgroundColor = _p2_UnityEngine_Color.Value;
                            _this.Instance.ClearRenderTarget(clearDepth, clearColor, backgroundColor);
                            var _retCount = _context.Return();
                            return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                        }
                        var _arg3 = _lastArg = _argCount > 4 ? _context.GetArgument(4) : global::Lua.LuaValue.Nil;
                        _lastArgPos = 3; _expectedType = typeof(global::System.Single);
                        if (_arg3.TryRead<global::System.Single>(out var _p3_System_Single))
                        {
                            if (_argCount == 5)
                            {
                                var clearDepth = _p0_System_Boolean;
                                var clearColor = _p1_System_Boolean;
                                var backgroundColor = _p2_UnityEngine_Color.Value;
                                var depth = _p3_System_Single;
                                _this.Instance.ClearRenderTarget(clearDepth, clearColor, backgroundColor, depth);
                                var _retCount = _context.Return();
                                return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                            }
                            var _arg4 = _lastArg = _argCount > 5 ? _context.GetArgument(5) : global::Lua.LuaValue.Nil;
                            _lastArgPos = 4; _expectedType = typeof(global::System.UInt32);
                            var _p4_System_UInt32 = _arg4.ReadValue<global::System.UInt32>((global::System.UInt32)(0));
                            {
                                if (_argCount == 6)
                                {
                                    var clearDepth = _p0_System_Boolean;
                                    var clearColor = _p1_System_Boolean;
                                    var backgroundColor = _p2_UnityEngine_Color.Value;
                                    var depth = _p3_System_Single;
                                    var stencil = _p4_System_UInt32;
                                    _this.Instance.ClearRenderTarget(clearDepth, clearColor, backgroundColor, depth, stencil);
                                    var _retCount = _context.Return();
                                    return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                                }
                            }
                        }
                    }
                }
            }
            _lastArgPos = 0; _expectedType = typeof(global::UnityEngine.Rendering.RTClearFlags);
            if (_arg0.TryRead<global::UnityEngine.Rendering.RTClearFlags>(out var _p0_UnityEngine_Rendering_RTClearFlags))
            {
                var _arg1 = _lastArg = _argCount > 2 ? _context.GetArgument(2) : global::Lua.LuaValue.Nil;
                _lastArgPos = 1; _expectedType = typeof(global::Luny.UnityEngine.LuaColor);
                if (_arg1.TryRead<global::Luny.UnityEngine.LuaColor>(out var _p1_UnityEngine_Color))
                {
                    if (_argCount == 3)
                    {
                        var clearFlags = _p0_UnityEngine_Rendering_RTClearFlags;
                        var backgroundColor = _p1_UnityEngine_Color.Value;
                        _this.Instance.ClearRenderTarget(clearFlags, backgroundColor);
                        var _retCount = _context.Return();
                        return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                    }
                    var _arg2 = _lastArg = _argCount > 3 ? _context.GetArgument(3) : global::Lua.LuaValue.Nil;
                    _lastArgPos = 2; _expectedType = typeof(global::System.Single);
                    var _p2_System_Single = _arg2.ReadValue<global::System.Single>((global::System.Single)(1));
                    {
                        if (_argCount == 4)
                        {
                            var clearFlags = _p0_UnityEngine_Rendering_RTClearFlags;
                            var backgroundColor = _p1_UnityEngine_Color.Value;
                            var depth = _p2_System_Single;
                            _this.Instance.ClearRenderTarget(clearFlags, backgroundColor, depth);
                            var _retCount = _context.Return();
                            return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                        }
                        var _arg3 = _lastArg = _argCount > 4 ? _context.GetArgument(4) : global::Lua.LuaValue.Nil;
                        _lastArgPos = 3; _expectedType = typeof(global::System.UInt32);
                        var _p3_System_UInt32 = _arg3.ReadValue<global::System.UInt32>((global::System.UInt32)(0));
                        {
                            if (_argCount == 5)
                            {
                                var clearFlags = _p0_UnityEngine_Rendering_RTClearFlags;
                                var backgroundColor = _p1_UnityEngine_Color.Value;
                                var depth = _p2_System_Single;
                                var stencil = _p3_System_UInt32;
                                _this.Instance.ClearRenderTarget(clearFlags, backgroundColor, depth, stencil);
                                var _retCount = _context.Return();
                                return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                            }
                        }
                    }
                }
                _lastArgPos = 1; _expectedType = typeof(global::UnityEngine.Color[]);
                if (_arg1.TryReadArray<global::UnityEngine.Color>(out var _p1_UnityEngine_ColorArray))
                {
                    if (_argCount == 3)
                    {
                        var clearFlags = _p0_UnityEngine_Rendering_RTClearFlags;
                        var backgroundColors = _p1_UnityEngine_ColorArray;
                        _this.Instance.ClearRenderTarget(clearFlags, backgroundColors);
                        var _retCount = _context.Return();
                        return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                    }
                    var _arg2 = _lastArg = _argCount > 3 ? _context.GetArgument(3) : global::Lua.LuaValue.Nil;
                    _lastArgPos = 2; _expectedType = typeof(global::System.Single);
                    var _p2_System_Single = _arg2.ReadValue<global::System.Single>((global::System.Single)(1));
                    {
                        if (_argCount == 4)
                        {
                            var clearFlags = _p0_UnityEngine_Rendering_RTClearFlags;
                            var backgroundColors = _p1_UnityEngine_ColorArray;
                            var depth = _p2_System_Single;
                            _this.Instance.ClearRenderTarget(clearFlags, backgroundColors, depth);
                            var _retCount = _context.Return();
                            return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                        }
                        var _arg3 = _lastArg = _argCount > 4 ? _context.GetArgument(4) : global::Lua.LuaValue.Nil;
                        _lastArgPos = 3; _expectedType = typeof(global::System.UInt32);
                        var _p3_System_UInt32 = _arg3.ReadValue<global::System.UInt32>((global::System.UInt32)(0));
                        {
                            if (_argCount == 5)
                            {
                                var clearFlags = _p0_UnityEngine_Rendering_RTClearFlags;
                                var backgroundColors = _p1_UnityEngine_ColorArray;
                                var depth = _p2_System_Single;
                                var stencil = _p3_System_UInt32;
                                _this.Instance.ClearRenderTarget(clearFlags, backgroundColors, depth, stencil);
                                var _retCount = _context.Return();
                                return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                            }
                        }
                    }
                }
            }
            throw new global::Lua.LuaRuntimeException(_context.Thread, $"{"ClearRenderTarget"}: invalid argument #{_lastArgPos}: {_lastArg} ({_lastArg.Type}), expected: {_expectedType.FullName}", 2);
        });
        private static readonly global::Lua.LuaFunction _LuaCommandBuffer_ConvertTexture = new global::Lua.LuaFunction("ConvertTexture", (_context, _) =>
        {
            global::Lua.LuaValue _lastArg = default;
            global::System.Int32 _lastArgPos = default;
            global::System.Type _expectedType = default;
            var _argCount = _context.ArgumentCount;
            var _this = _context.GetArgument<LuaCommandBuffer>(0);
            var _arg0 = _lastArg = _argCount > 1 ? _context.GetArgument(1) : global::Lua.LuaValue.Nil;
            _lastArgPos = 0; _expectedType = typeof(global::Luny.UnityEngine.Rendering.LuaRenderTargetIdentifier);
            if (_arg0.TryRead<global::Luny.UnityEngine.Rendering.LuaRenderTargetIdentifier>(out var _p0_UnityEngine_Rendering_RenderTargetIdentifier))
            {
                var _arg1 = _lastArg = _argCount > 2 ? _context.GetArgument(2) : global::Lua.LuaValue.Nil;
                _lastArgPos = 1; _expectedType = typeof(global::Luny.UnityEngine.Rendering.LuaRenderTargetIdentifier);
                if (_arg1.TryRead<global::Luny.UnityEngine.Rendering.LuaRenderTargetIdentifier>(out var _p1_UnityEngine_Rendering_RenderTargetIdentifier))
                {
                    if (_argCount == 3)
                    {
                        var src = _p0_UnityEngine_Rendering_RenderTargetIdentifier.Value;
                        var dst = _p1_UnityEngine_Rendering_RenderTargetIdentifier.Value;
                        _this.Instance.ConvertTexture(src, dst);
                        var _retCount = _context.Return();
                        return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                    }
                }
                _lastArgPos = 1; _expectedType = typeof(global::System.Int32);
                if (_arg1.TryRead<global::System.Int32>(out var _p1_System_Int32))
                {
                    var _arg2 = _lastArg = _argCount > 3 ? _context.GetArgument(3) : global::Lua.LuaValue.Nil;
                    _lastArgPos = 2; _expectedType = typeof(global::Luny.UnityEngine.Rendering.LuaRenderTargetIdentifier);
                    if (_arg2.TryRead<global::Luny.UnityEngine.Rendering.LuaRenderTargetIdentifier>(out var _p2_UnityEngine_Rendering_RenderTargetIdentifier))
                    {
                        var _arg3 = _lastArg = _argCount > 4 ? _context.GetArgument(4) : global::Lua.LuaValue.Nil;
                        _lastArgPos = 3; _expectedType = typeof(global::System.Int32);
                        if (_arg3.TryRead<global::System.Int32>(out var _p3_System_Int32))
                        {
                            if (_argCount == 5)
                            {
                                var src = _p0_UnityEngine_Rendering_RenderTargetIdentifier.Value;
                                var srcElement = _p1_System_Int32;
                                var dst = _p2_UnityEngine_Rendering_RenderTargetIdentifier.Value;
                                var dstElement = _p3_System_Int32;
                                _this.Instance.ConvertTexture(src, srcElement, dst, dstElement);
                                var _retCount = _context.Return();
                                return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                            }
                        }
                    }
                }
            }
            throw new global::Lua.LuaRuntimeException(_context.Thread, $"{"ConvertTexture"}: invalid argument #{_lastArgPos}: {_lastArg} ({_lastArg.Type}), expected: {_expectedType.FullName}", 2);
        });
        private static readonly global::Lua.LuaFunction _LuaCommandBuffer_CopyBuffer = new global::Lua.LuaFunction("CopyBuffer", (_context, _) =>
        {
            global::Lua.LuaValue _lastArg = default;
            global::System.Int32 _lastArgPos = default;
            global::System.Type _expectedType = default;
            var _argCount = _context.ArgumentCount;
            var _this = _context.GetArgument<LuaCommandBuffer>(0);
            var _arg0 = _lastArg = _argCount > 1 ? _context.GetArgument(1) : global::Lua.LuaValue.Nil;
            _lastArgPos = 0; _expectedType = typeof(global::Luny.UnityEngine.LuaGraphicsBuffer);
            if (_arg0.TryRead<global::Luny.UnityEngine.LuaGraphicsBuffer>(out var _p0_UnityEngine_GraphicsBuffer))
            {
                var _arg1 = _lastArg = _argCount > 2 ? _context.GetArgument(2) : global::Lua.LuaValue.Nil;
                _lastArgPos = 1; _expectedType = typeof(global::Luny.UnityEngine.LuaGraphicsBuffer);
                if (_arg1.TryRead<global::Luny.UnityEngine.LuaGraphicsBuffer>(out var _p1_UnityEngine_GraphicsBuffer))
                {
                    if (_argCount == 3)
                    {
                        var source = _p0_UnityEngine_GraphicsBuffer.Instance;
                        var dest = _p1_UnityEngine_GraphicsBuffer.Instance;
                        _this.Instance.CopyBuffer(source, dest);
                        var _retCount = _context.Return();
                        return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                    }
                }
            }
            throw new global::Lua.LuaRuntimeException(_context.Thread, $"{"CopyBuffer"}: invalid argument #{_lastArgPos}: {_lastArg} ({_lastArg.Type}), expected: {_expectedType.FullName}", 2);
        });
        private static readonly global::Lua.LuaFunction _LuaCommandBuffer_CopyCounterValue = new global::Lua.LuaFunction("CopyCounterValue", (_context, _) =>
        {
            global::Lua.LuaValue _lastArg = default;
            global::System.Int32 _lastArgPos = default;
            global::System.Type _expectedType = default;
            var _argCount = _context.ArgumentCount;
            var _this = _context.GetArgument<LuaCommandBuffer>(0);
            var _arg0 = _lastArg = _argCount > 1 ? _context.GetArgument(1) : global::Lua.LuaValue.Nil;
            _lastArgPos = 0; _expectedType = typeof(global::Luny.UnityEngine.LuaComputeBuffer);
            if (_arg0.TryRead<global::Luny.UnityEngine.LuaComputeBuffer>(out var _p0_UnityEngine_ComputeBuffer))
            {
                var _arg1 = _lastArg = _argCount > 2 ? _context.GetArgument(2) : global::Lua.LuaValue.Nil;
                _lastArgPos = 1; _expectedType = typeof(global::Luny.UnityEngine.LuaComputeBuffer);
                if (_arg1.TryRead<global::Luny.UnityEngine.LuaComputeBuffer>(out var _p1_UnityEngine_ComputeBuffer))
                {
                    var _arg2 = _lastArg = _argCount > 3 ? _context.GetArgument(3) : global::Lua.LuaValue.Nil;
                    _lastArgPos = 2; _expectedType = typeof(global::System.UInt32);
                    if (_arg2.TryRead<global::System.UInt32>(out var _p2_System_UInt32))
                    {
                        if (_argCount == 4)
                        {
                            var src = _p0_UnityEngine_ComputeBuffer.Instance;
                            var dst = _p1_UnityEngine_ComputeBuffer.Instance;
                            var dstOffsetBytes = _p2_System_UInt32;
                            _this.Instance.CopyCounterValue(src, dst, dstOffsetBytes);
                            var _retCount = _context.Return();
                            return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                        }
                    }
                }
                _lastArgPos = 1; _expectedType = typeof(global::Luny.UnityEngine.LuaGraphicsBuffer);
                if (_arg1.TryRead<global::Luny.UnityEngine.LuaGraphicsBuffer>(out var _p1_UnityEngine_GraphicsBuffer))
                {
                    var _arg2 = _lastArg = _argCount > 3 ? _context.GetArgument(3) : global::Lua.LuaValue.Nil;
                    _lastArgPos = 2; _expectedType = typeof(global::System.UInt32);
                    if (_arg2.TryRead<global::System.UInt32>(out var _p2_System_UInt32))
                    {
                        if (_argCount == 4)
                        {
                            var src = _p0_UnityEngine_ComputeBuffer.Instance;
                            var dst = _p1_UnityEngine_GraphicsBuffer.Instance;
                            var dstOffsetBytes = _p2_System_UInt32;
                            _this.Instance.CopyCounterValue(src, dst, dstOffsetBytes);
                            var _retCount = _context.Return();
                            return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                        }
                    }
                }
            }
            _lastArgPos = 0; _expectedType = typeof(global::Luny.UnityEngine.LuaGraphicsBuffer);
            if (_arg0.TryRead<global::Luny.UnityEngine.LuaGraphicsBuffer>(out var _p0_UnityEngine_GraphicsBuffer))
            {
                var _arg1 = _lastArg = _argCount > 2 ? _context.GetArgument(2) : global::Lua.LuaValue.Nil;
                _lastArgPos = 1; _expectedType = typeof(global::Luny.UnityEngine.LuaComputeBuffer);
                if (_arg1.TryRead<global::Luny.UnityEngine.LuaComputeBuffer>(out var _p1_UnityEngine_ComputeBuffer))
                {
                    var _arg2 = _lastArg = _argCount > 3 ? _context.GetArgument(3) : global::Lua.LuaValue.Nil;
                    _lastArgPos = 2; _expectedType = typeof(global::System.UInt32);
                    if (_arg2.TryRead<global::System.UInt32>(out var _p2_System_UInt32))
                    {
                        if (_argCount == 4)
                        {
                            var src = _p0_UnityEngine_GraphicsBuffer.Instance;
                            var dst = _p1_UnityEngine_ComputeBuffer.Instance;
                            var dstOffsetBytes = _p2_System_UInt32;
                            _this.Instance.CopyCounterValue(src, dst, dstOffsetBytes);
                            var _retCount = _context.Return();
                            return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                        }
                    }
                }
                _lastArgPos = 1; _expectedType = typeof(global::Luny.UnityEngine.LuaGraphicsBuffer);
                if (_arg1.TryRead<global::Luny.UnityEngine.LuaGraphicsBuffer>(out var _p1_UnityEngine_GraphicsBuffer))
                {
                    var _arg2 = _lastArg = _argCount > 3 ? _context.GetArgument(3) : global::Lua.LuaValue.Nil;
                    _lastArgPos = 2; _expectedType = typeof(global::System.UInt32);
                    if (_arg2.TryRead<global::System.UInt32>(out var _p2_System_UInt32))
                    {
                        if (_argCount == 4)
                        {
                            var src = _p0_UnityEngine_GraphicsBuffer.Instance;
                            var dst = _p1_UnityEngine_GraphicsBuffer.Instance;
                            var dstOffsetBytes = _p2_System_UInt32;
                            _this.Instance.CopyCounterValue(src, dst, dstOffsetBytes);
                            var _retCount = _context.Return();
                            return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                        }
                    }
                }
            }
            throw new global::Lua.LuaRuntimeException(_context.Thread, $"{"CopyCounterValue"}: invalid argument #{_lastArgPos}: {_lastArg} ({_lastArg.Type}), expected: {_expectedType.FullName}", 2);
        });
        private static readonly global::Lua.LuaFunction _LuaCommandBuffer_CopyTexture = new global::Lua.LuaFunction("CopyTexture", (_context, _) =>
        {
            global::Lua.LuaValue _lastArg = default;
            global::System.Int32 _lastArgPos = default;
            global::System.Type _expectedType = default;
            var _argCount = _context.ArgumentCount;
            var _this = _context.GetArgument<LuaCommandBuffer>(0);
            var _arg0 = _lastArg = _argCount > 1 ? _context.GetArgument(1) : global::Lua.LuaValue.Nil;
            _lastArgPos = 0; _expectedType = typeof(global::Luny.UnityEngine.Rendering.LuaRenderTargetIdentifier);
            if (_arg0.TryRead<global::Luny.UnityEngine.Rendering.LuaRenderTargetIdentifier>(out var _p0_UnityEngine_Rendering_RenderTargetIdentifier))
            {
                var _arg1 = _lastArg = _argCount > 2 ? _context.GetArgument(2) : global::Lua.LuaValue.Nil;
                _lastArgPos = 1; _expectedType = typeof(global::Luny.UnityEngine.Rendering.LuaRenderTargetIdentifier);
                if (_arg1.TryRead<global::Luny.UnityEngine.Rendering.LuaRenderTargetIdentifier>(out var _p1_UnityEngine_Rendering_RenderTargetIdentifier))
                {
                    if (_argCount == 3)
                    {
                        var src = _p0_UnityEngine_Rendering_RenderTargetIdentifier.Value;
                        var dst = _p1_UnityEngine_Rendering_RenderTargetIdentifier.Value;
                        _this.Instance.CopyTexture(src, dst);
                        var _retCount = _context.Return();
                        return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                    }
                }
                _lastArgPos = 1; _expectedType = typeof(global::System.Int32);
                if (_arg1.TryRead<global::System.Int32>(out var _p1_System_Int32))
                {
                    var _arg2 = _lastArg = _argCount > 3 ? _context.GetArgument(3) : global::Lua.LuaValue.Nil;
                    _lastArgPos = 2; _expectedType = typeof(global::Luny.UnityEngine.Rendering.LuaRenderTargetIdentifier);
                    if (_arg2.TryRead<global::Luny.UnityEngine.Rendering.LuaRenderTargetIdentifier>(out var _p2_UnityEngine_Rendering_RenderTargetIdentifier))
                    {
                        var _arg3 = _lastArg = _argCount > 4 ? _context.GetArgument(4) : global::Lua.LuaValue.Nil;
                        _lastArgPos = 3; _expectedType = typeof(global::System.Int32);
                        if (_arg3.TryRead<global::System.Int32>(out var _p3_System_Int32))
                        {
                            if (_argCount == 5)
                            {
                                var src = _p0_UnityEngine_Rendering_RenderTargetIdentifier.Value;
                                var srcElement = _p1_System_Int32;
                                var dst = _p2_UnityEngine_Rendering_RenderTargetIdentifier.Value;
                                var dstElement = _p3_System_Int32;
                                _this.Instance.CopyTexture(src, srcElement, dst, dstElement);
                                var _retCount = _context.Return();
                                return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                            }
                        }
                    }
                    _lastArgPos = 2; _expectedType = typeof(global::System.Int32);
                    if (_arg2.TryRead<global::System.Int32>(out var _p2_System_Int32))
                    {
                        var _arg3 = _lastArg = _argCount > 4 ? _context.GetArgument(4) : global::Lua.LuaValue.Nil;
                        _lastArgPos = 3; _expectedType = typeof(global::System.Int32);
                        if (_arg3.TryRead<global::System.Int32>(out var _p3_System_Int32))
                        {
                            var _arg4 = _lastArg = _argCount > 5 ? _context.GetArgument(5) : global::Lua.LuaValue.Nil;
                            _lastArgPos = 4; _expectedType = typeof(global::System.Int32);
                            if (_arg4.TryRead<global::System.Int32>(out var _p4_System_Int32))
                            {
                                var _arg5 = _lastArg = _argCount > 6 ? _context.GetArgument(6) : global::Lua.LuaValue.Nil;
                                _lastArgPos = 5; _expectedType = typeof(global::System.Int32);
                                if (_arg5.TryRead<global::System.Int32>(out var _p5_System_Int32))
                                {
                                    var _arg6 = _lastArg = _argCount > 7 ? _context.GetArgument(7) : global::Lua.LuaValue.Nil;
                                    _lastArgPos = 6; _expectedType = typeof(global::System.Int32);
                                    if (_arg6.TryRead<global::System.Int32>(out var _p6_System_Int32))
                                    {
                                        var _arg7 = _lastArg = _argCount > 8 ? _context.GetArgument(8) : global::Lua.LuaValue.Nil;
                                        _lastArgPos = 7; _expectedType = typeof(global::Luny.UnityEngine.Rendering.LuaRenderTargetIdentifier);
                                        if (_arg7.TryRead<global::Luny.UnityEngine.Rendering.LuaRenderTargetIdentifier>(out var _p7_UnityEngine_Rendering_RenderTargetIdentifier))
                                        {
                                            var _arg8 = _lastArg = _argCount > 9 ? _context.GetArgument(9) : global::Lua.LuaValue.Nil;
                                            _lastArgPos = 8; _expectedType = typeof(global::System.Int32);
                                            if (_arg8.TryRead<global::System.Int32>(out var _p8_System_Int32))
                                            {
                                                var _arg9 = _lastArg = _argCount > 10 ? _context.GetArgument(10) : global::Lua.LuaValue.Nil;
                                                _lastArgPos = 9; _expectedType = typeof(global::System.Int32);
                                                if (_arg9.TryRead<global::System.Int32>(out var _p9_System_Int32))
                                                {
                                                    var _arg10 = _lastArg = _argCount > 11 ? _context.GetArgument(11) : global::Lua.LuaValue.Nil;
                                                    _lastArgPos = 10; _expectedType = typeof(global::System.Int32);
                                                    if (_arg10.TryRead<global::System.Int32>(out var _p10_System_Int32))
                                                    {
                                                        var _arg11 = _lastArg = _argCount > 12 ? _context.GetArgument(12) : global::Lua.LuaValue.Nil;
                                                        _lastArgPos = 11; _expectedType = typeof(global::System.Int32);
                                                        if (_arg11.TryRead<global::System.Int32>(out var _p11_System_Int32))
                                                        {
                                                            if (_argCount == 13)
                                                            {
                                                                var src = _p0_UnityEngine_Rendering_RenderTargetIdentifier.Value;
                                                                var srcElement = _p1_System_Int32;
                                                                var srcMip = _p2_System_Int32;
                                                                var srcX = _p3_System_Int32;
                                                                var srcY = _p4_System_Int32;
                                                                var srcWidth = _p5_System_Int32;
                                                                var srcHeight = _p6_System_Int32;
                                                                var dst = _p7_UnityEngine_Rendering_RenderTargetIdentifier.Value;
                                                                var dstElement = _p8_System_Int32;
                                                                var dstMip = _p9_System_Int32;
                                                                var dstX = _p10_System_Int32;
                                                                var dstY = _p11_System_Int32;
                                                                _this.Instance.CopyTexture(src, srcElement, srcMip, srcX, srcY, srcWidth, srcHeight, dst, dstElement, dstMip, dstX, dstY);
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
                        }
                        _lastArgPos = 3; _expectedType = typeof(global::Luny.UnityEngine.Rendering.LuaRenderTargetIdentifier);
                        if (_arg3.TryRead<global::Luny.UnityEngine.Rendering.LuaRenderTargetIdentifier>(out var _p3_UnityEngine_Rendering_RenderTargetIdentifier))
                        {
                            var _arg4 = _lastArg = _argCount > 5 ? _context.GetArgument(5) : global::Lua.LuaValue.Nil;
                            _lastArgPos = 4; _expectedType = typeof(global::System.Int32);
                            if (_arg4.TryRead<global::System.Int32>(out var _p4_System_Int32))
                            {
                                var _arg5 = _lastArg = _argCount > 6 ? _context.GetArgument(6) : global::Lua.LuaValue.Nil;
                                _lastArgPos = 5; _expectedType = typeof(global::System.Int32);
                                if (_arg5.TryRead<global::System.Int32>(out var _p5_System_Int32))
                                {
                                    if (_argCount == 7)
                                    {
                                        var src = _p0_UnityEngine_Rendering_RenderTargetIdentifier.Value;
                                        var srcElement = _p1_System_Int32;
                                        var srcMip = _p2_System_Int32;
                                        var dst = _p3_UnityEngine_Rendering_RenderTargetIdentifier.Value;
                                        var dstElement = _p4_System_Int32;
                                        var dstMip = _p5_System_Int32;
                                        _this.Instance.CopyTexture(src, srcElement, srcMip, dst, dstElement, dstMip);
                                        var _retCount = _context.Return();
                                        return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                                    }
                                }
                            }
                        }
                    }
                }
            }
            throw new global::Lua.LuaRuntimeException(_context.Thread, $"{"CopyTexture"}: invalid argument #{_lastArgPos}: {_lastArg} ({_lastArg.Type}), expected: {_expectedType.FullName}", 2);
        });
        private static readonly global::Lua.LuaFunction _LuaCommandBuffer_CreateAsyncGraphicsFence = new global::Lua.LuaFunction("CreateAsyncGraphicsFence", (_context, _) =>
        {
            global::Lua.LuaValue _lastArg = default;
            global::System.Int32 _lastArgPos = default;
            global::System.Type _expectedType = default;
            var _argCount = _context.ArgumentCount;
            var _this = _context.GetArgument<LuaCommandBuffer>(0);
            if (_argCount == 1)
            {
                var _ret0 = _this.Instance.CreateAsyncGraphicsFence();
                var _lret0 = global::Luny.UnityEngine.Rendering.LuaGraphicsFence.Bind(_ret0);
                var _retCount = _context.Return(_lret0);
                return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
            }
            var _arg0 = _lastArg = _argCount > 1 ? _context.GetArgument(1) : global::Lua.LuaValue.Nil;
            _lastArgPos = 0; _expectedType = typeof(global::UnityEngine.Rendering.SynchronisationStage);
            if (_arg0.TryRead<global::UnityEngine.Rendering.SynchronisationStage>(out var _p0_UnityEngine_Rendering_SynchronisationStage))
            {
                if (_argCount == 2)
                {
                    var stage = _p0_UnityEngine_Rendering_SynchronisationStage;
                    var _ret0 = _this.Instance.CreateAsyncGraphicsFence(stage);
                    var _lret0 = global::Luny.UnityEngine.Rendering.LuaGraphicsFence.Bind(_ret0);
                    var _retCount = _context.Return(_lret0);
                    return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                }
            }
            throw new global::Lua.LuaRuntimeException(_context.Thread, $"{"CreateAsyncGraphicsFence"}: invalid argument #{_lastArgPos}: {_lastArg} ({_lastArg.Type}), expected: {_expectedType.FullName}", 2);
        });
        private static readonly global::Lua.LuaFunction _LuaCommandBuffer_CreateGraphicsFence = new global::Lua.LuaFunction("CreateGraphicsFence", (_context, _) =>
        {
            global::Lua.LuaValue _lastArg = default;
            global::System.Int32 _lastArgPos = default;
            global::System.Type _expectedType = default;
            var _argCount = _context.ArgumentCount;
            var _this = _context.GetArgument<LuaCommandBuffer>(0);
            var _arg0 = _lastArg = _argCount > 1 ? _context.GetArgument(1) : global::Lua.LuaValue.Nil;
            _lastArgPos = 0; _expectedType = typeof(global::UnityEngine.Rendering.GraphicsFenceType);
            if (_arg0.TryRead<global::UnityEngine.Rendering.GraphicsFenceType>(out var _p0_UnityEngine_Rendering_GraphicsFenceType))
            {
                var _arg1 = _lastArg = _argCount > 2 ? _context.GetArgument(2) : global::Lua.LuaValue.Nil;
                _lastArgPos = 1; _expectedType = typeof(global::UnityEngine.Rendering.SynchronisationStageFlags);
                if (_arg1.TryRead<global::UnityEngine.Rendering.SynchronisationStageFlags>(out var _p1_UnityEngine_Rendering_SynchronisationStageFlags))
                {
                    if (_argCount == 3)
                    {
                        var fenceType = _p0_UnityEngine_Rendering_GraphicsFenceType;
                        var stage = _p1_UnityEngine_Rendering_SynchronisationStageFlags;
                        var _ret0 = _this.Instance.CreateGraphicsFence(fenceType, stage);
                        var _lret0 = global::Luny.UnityEngine.Rendering.LuaGraphicsFence.Bind(_ret0);
                        var _retCount = _context.Return(_lret0);
                        return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                    }
                }
            }
            throw new global::Lua.LuaRuntimeException(_context.Thread, $"{"CreateGraphicsFence"}: invalid argument #{_lastArgPos}: {_lastArg} ({_lastArg.Type}), expected: {_expectedType.FullName}", 2);
        });
        private static readonly global::Lua.LuaFunction _LuaCommandBuffer_DisableScissorRect = new global::Lua.LuaFunction("DisableScissorRect", (_context, _) =>
        {
            global::Lua.LuaValue _lastArg = default;
            global::System.Int32 _lastArgPos = default;
            global::System.Type _expectedType = default;
            var _argCount = _context.ArgumentCount;
            var _this = _context.GetArgument<LuaCommandBuffer>(0);
            if (_argCount == 1)
            {
                _this.Instance.DisableScissorRect();
                var _retCount = _context.Return();
                return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
            }
            throw new global::Lua.LuaRuntimeException(_context.Thread, $"{"DisableScissorRect"}: invalid argument #{_lastArgPos}: {_lastArg} ({_lastArg.Type}), expected: {_expectedType.FullName}", 2);
        });
        private static readonly global::Lua.LuaFunction _LuaCommandBuffer_DisableShaderKeyword = new global::Lua.LuaFunction("DisableShaderKeyword", (_context, _) =>
        {
            global::Lua.LuaValue _lastArg = default;
            global::System.Int32 _lastArgPos = default;
            global::System.Type _expectedType = default;
            var _argCount = _context.ArgumentCount;
            var _this = _context.GetArgument<LuaCommandBuffer>(0);
            var _arg0 = _lastArg = _argCount > 1 ? _context.GetArgument(1) : global::Lua.LuaValue.Nil;
            _lastArgPos = 0; _expectedType = typeof(global::System.String);
            if (_arg0.TryRead<global::System.String>(out var _p0_System_String))
            {
                if (_argCount == 2)
                {
                    var keyword = _p0_System_String;
                    _this.Instance.DisableShaderKeyword(keyword);
                    var _retCount = _context.Return();
                    return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                }
            }
            throw new global::Lua.LuaRuntimeException(_context.Thread, $"{"DisableShaderKeyword"}: invalid argument #{_lastArgPos}: {_lastArg} ({_lastArg.Type}), expected: {_expectedType.FullName}", 2);
        });
        private static readonly global::Lua.LuaFunction _LuaCommandBuffer_DispatchCompute = new global::Lua.LuaFunction("DispatchCompute", (_context, _) =>
        {
            global::Lua.LuaValue _lastArg = default;
            global::System.Int32 _lastArgPos = default;
            global::System.Type _expectedType = default;
            var _argCount = _context.ArgumentCount;
            var _this = _context.GetArgument<LuaCommandBuffer>(0);
            var _arg0 = _lastArg = _argCount > 1 ? _context.GetArgument(1) : global::Lua.LuaValue.Nil;
            _lastArgPos = 0; _expectedType = typeof(global::Luny.UnityEngine.LuaComputeShader);
            if (_arg0.TryRead<global::Luny.UnityEngine.LuaComputeShader>(out var _p0_UnityEngine_ComputeShader))
            {
                var _arg1 = _lastArg = _argCount > 2 ? _context.GetArgument(2) : global::Lua.LuaValue.Nil;
                _lastArgPos = 1; _expectedType = typeof(global::System.Int32);
                if (_arg1.TryRead<global::System.Int32>(out var _p1_System_Int32))
                {
                    var _arg2 = _lastArg = _argCount > 3 ? _context.GetArgument(3) : global::Lua.LuaValue.Nil;
                    _lastArgPos = 2; _expectedType = typeof(global::Luny.UnityEngine.LuaComputeBuffer);
                    if (_arg2.TryRead<global::Luny.UnityEngine.LuaComputeBuffer>(out var _p2_UnityEngine_ComputeBuffer))
                    {
                        var _arg3 = _lastArg = _argCount > 4 ? _context.GetArgument(4) : global::Lua.LuaValue.Nil;
                        _lastArgPos = 3; _expectedType = typeof(global::System.UInt32);
                        if (_arg3.TryRead<global::System.UInt32>(out var _p3_System_UInt32))
                        {
                            if (_argCount == 5)
                            {
                                var computeShader = _p0_UnityEngine_ComputeShader.Instance;
                                var kernelIndex = _p1_System_Int32;
                                var indirectBuffer = _p2_UnityEngine_ComputeBuffer.Instance;
                                var argsOffset = _p3_System_UInt32;
                                _this.Instance.DispatchCompute(computeShader, kernelIndex, indirectBuffer, argsOffset);
                                var _retCount = _context.Return();
                                return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                            }
                        }
                    }
                    _lastArgPos = 2; _expectedType = typeof(global::Luny.UnityEngine.LuaGraphicsBuffer);
                    if (_arg2.TryRead<global::Luny.UnityEngine.LuaGraphicsBuffer>(out var _p2_UnityEngine_GraphicsBuffer))
                    {
                        var _arg3 = _lastArg = _argCount > 4 ? _context.GetArgument(4) : global::Lua.LuaValue.Nil;
                        _lastArgPos = 3; _expectedType = typeof(global::System.UInt32);
                        if (_arg3.TryRead<global::System.UInt32>(out var _p3_System_UInt32))
                        {
                            if (_argCount == 5)
                            {
                                var computeShader = _p0_UnityEngine_ComputeShader.Instance;
                                var kernelIndex = _p1_System_Int32;
                                var indirectBuffer = _p2_UnityEngine_GraphicsBuffer.Instance;
                                var argsOffset = _p3_System_UInt32;
                                _this.Instance.DispatchCompute(computeShader, kernelIndex, indirectBuffer, argsOffset);
                                var _retCount = _context.Return();
                                return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                            }
                        }
                    }
                    _lastArgPos = 2; _expectedType = typeof(global::System.Int32);
                    if (_arg2.TryRead<global::System.Int32>(out var _p2_System_Int32))
                    {
                        var _arg3 = _lastArg = _argCount > 4 ? _context.GetArgument(4) : global::Lua.LuaValue.Nil;
                        _lastArgPos = 3; _expectedType = typeof(global::System.Int32);
                        if (_arg3.TryRead<global::System.Int32>(out var _p3_System_Int32))
                        {
                            var _arg4 = _lastArg = _argCount > 5 ? _context.GetArgument(5) : global::Lua.LuaValue.Nil;
                            _lastArgPos = 4; _expectedType = typeof(global::System.Int32);
                            if (_arg4.TryRead<global::System.Int32>(out var _p4_System_Int32))
                            {
                                if (_argCount == 6)
                                {
                                    var computeShader = _p0_UnityEngine_ComputeShader.Instance;
                                    var kernelIndex = _p1_System_Int32;
                                    var threadGroupsX = _p2_System_Int32;
                                    var threadGroupsY = _p3_System_Int32;
                                    var threadGroupsZ = _p4_System_Int32;
                                    _this.Instance.DispatchCompute(computeShader, kernelIndex, threadGroupsX, threadGroupsY, threadGroupsZ);
                                    var _retCount = _context.Return();
                                    return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                                }
                            }
                        }
                    }
                }
            }
            throw new global::Lua.LuaRuntimeException(_context.Thread, $"{"DispatchCompute"}: invalid argument #{_lastArgPos}: {_lastArg} ({_lastArg.Type}), expected: {_expectedType.FullName}", 2);
        });
        private static readonly global::Lua.LuaFunction _LuaCommandBuffer_DispatchRays = new global::Lua.LuaFunction("DispatchRays", (_context, _) =>
        {
            global::Lua.LuaValue _lastArg = default;
            global::System.Int32 _lastArgPos = default;
            global::System.Type _expectedType = default;
            var _argCount = _context.ArgumentCount;
            var _this = _context.GetArgument<LuaCommandBuffer>(0);
            var _arg0 = _lastArg = _argCount > 1 ? _context.GetArgument(1) : global::Lua.LuaValue.Nil;
            _lastArgPos = 0; _expectedType = typeof(global::Luny.UnityEngine.Rendering.LuaRayTracingShader);
            if (_arg0.TryRead<global::Luny.UnityEngine.Rendering.LuaRayTracingShader>(out var _p0_UnityEngine_Rendering_RayTracingShader))
            {
                var _arg1 = _lastArg = _argCount > 2 ? _context.GetArgument(2) : global::Lua.LuaValue.Nil;
                _lastArgPos = 1; _expectedType = typeof(global::System.String);
                if (_arg1.TryRead<global::System.String>(out var _p1_System_String))
                {
                    var _arg2 = _lastArg = _argCount > 3 ? _context.GetArgument(3) : global::Lua.LuaValue.Nil;
                    _lastArgPos = 2; _expectedType = typeof(global::Luny.UnityEngine.LuaGraphicsBuffer);
                    if (_arg2.TryRead<global::Luny.UnityEngine.LuaGraphicsBuffer>(out var _p2_UnityEngine_GraphicsBuffer))
                    {
                        var _arg3 = _lastArg = _argCount > 4 ? _context.GetArgument(4) : global::Lua.LuaValue.Nil;
                        _lastArgPos = 3; _expectedType = typeof(global::System.UInt32);
                        if (_arg3.TryRead<global::System.UInt32>(out var _p3_System_UInt32))
                        {
                            if (_argCount == 5)
                            {
                                var rayTracingShader = _p0_UnityEngine_Rendering_RayTracingShader.Instance;
                                var rayGenName = _p1_System_String;
                                var argsBuffer = _p2_UnityEngine_GraphicsBuffer.Instance;
                                var argsOffset = _p3_System_UInt32;
                                _this.Instance.DispatchRays(rayTracingShader, rayGenName, argsBuffer, argsOffset);
                                var _retCount = _context.Return();
                                return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                            }
                            var _arg4 = _lastArg = _argCount > 5 ? _context.GetArgument(5) : global::Lua.LuaValue.Nil;
                            _lastArgPos = 4; _expectedType = typeof(global::Luny.UnityEngine.LuaCamera);
                            var _p4_UnityEngine_Camera = _arg4.ReadValue<global::Luny.UnityEngine.LuaCamera>(default);
                            {
                                if (_argCount == 6)
                                {
                                    var rayTracingShader = _p0_UnityEngine_Rendering_RayTracingShader.Instance;
                                    var rayGenName = _p1_System_String;
                                    var argsBuffer = _p2_UnityEngine_GraphicsBuffer.Instance;
                                    var argsOffset = _p3_System_UInt32;
                                    var camera = _p4_UnityEngine_Camera.Instance;
                                    _this.Instance.DispatchRays(rayTracingShader, rayGenName, argsBuffer, argsOffset, camera);
                                    var _retCount = _context.Return();
                                    return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                                }
                            }
                        }
                    }
                    _lastArgPos = 2; _expectedType = typeof(global::System.UInt32);
                    if (_arg2.TryRead<global::System.UInt32>(out var _p2_System_UInt32))
                    {
                        var _arg3 = _lastArg = _argCount > 4 ? _context.GetArgument(4) : global::Lua.LuaValue.Nil;
                        _lastArgPos = 3; _expectedType = typeof(global::System.UInt32);
                        if (_arg3.TryRead<global::System.UInt32>(out var _p3_System_UInt32))
                        {
                            var _arg4 = _lastArg = _argCount > 5 ? _context.GetArgument(5) : global::Lua.LuaValue.Nil;
                            _lastArgPos = 4; _expectedType = typeof(global::System.UInt32);
                            if (_arg4.TryRead<global::System.UInt32>(out var _p4_System_UInt32))
                            {
                                if (_argCount == 6)
                                {
                                    var rayTracingShader = _p0_UnityEngine_Rendering_RayTracingShader.Instance;
                                    var rayGenName = _p1_System_String;
                                    var width = _p2_System_UInt32;
                                    var height = _p3_System_UInt32;
                                    var depth = _p4_System_UInt32;
                                    _this.Instance.DispatchRays(rayTracingShader, rayGenName, width, height, depth);
                                    var _retCount = _context.Return();
                                    return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                                }
                                var _arg5 = _lastArg = _argCount > 6 ? _context.GetArgument(6) : global::Lua.LuaValue.Nil;
                                _lastArgPos = 5; _expectedType = typeof(global::Luny.UnityEngine.LuaCamera);
                                var _p5_UnityEngine_Camera = _arg5.ReadValue<global::Luny.UnityEngine.LuaCamera>(default);
                                {
                                    if (_argCount == 7)
                                    {
                                        var rayTracingShader = _p0_UnityEngine_Rendering_RayTracingShader.Instance;
                                        var rayGenName = _p1_System_String;
                                        var width = _p2_System_UInt32;
                                        var height = _p3_System_UInt32;
                                        var depth = _p4_System_UInt32;
                                        var camera = _p5_UnityEngine_Camera.Instance;
                                        _this.Instance.DispatchRays(rayTracingShader, rayGenName, width, height, depth, camera);
                                        var _retCount = _context.Return();
                                        return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                                    }
                                }
                            }
                        }
                    }
                }
            }
            throw new global::Lua.LuaRuntimeException(_context.Thread, $"{"DispatchRays"}: invalid argument #{_lastArgPos}: {_lastArg} ({_lastArg.Type}), expected: {_expectedType.FullName}", 2);
        });
        private static readonly global::Lua.LuaFunction _LuaCommandBuffer_Dispose = new global::Lua.LuaFunction("Dispose", (_context, _) =>
        {
            global::Lua.LuaValue _lastArg = default;
            global::System.Int32 _lastArgPos = default;
            global::System.Type _expectedType = default;
            var _argCount = _context.ArgumentCount;
            var _this = _context.GetArgument<LuaCommandBuffer>(0);
            if (_argCount == 1)
            {
                _this.Instance.Dispose();
                var _retCount = _context.Return();
                return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
            }
            throw new global::Lua.LuaRuntimeException(_context.Thread, $"{"Dispose"}: invalid argument #{_lastArgPos}: {_lastArg} ({_lastArg.Type}), expected: {_expectedType.FullName}", 2);
        });
        private static readonly global::Lua.LuaFunction _LuaCommandBuffer_DrawMesh = new global::Lua.LuaFunction("DrawMesh", (_context, _) =>
        {
            global::Lua.LuaValue _lastArg = default;
            global::System.Int32 _lastArgPos = default;
            global::System.Type _expectedType = default;
            var _argCount = _context.ArgumentCount;
            var _this = _context.GetArgument<LuaCommandBuffer>(0);
            var _arg0 = _lastArg = _argCount > 1 ? _context.GetArgument(1) : global::Lua.LuaValue.Nil;
            _lastArgPos = 0; _expectedType = typeof(global::Luny.UnityEngine.LuaMesh);
            if (_arg0.TryRead<global::Luny.UnityEngine.LuaMesh>(out var _p0_UnityEngine_Mesh))
            {
                var _arg1 = _lastArg = _argCount > 2 ? _context.GetArgument(2) : global::Lua.LuaValue.Nil;
                _lastArgPos = 1; _expectedType = typeof(global::Luny.UnityEngine.LuaMatrix4x4);
                if (_arg1.TryRead<global::Luny.UnityEngine.LuaMatrix4x4>(out var _p1_UnityEngine_Matrix4x4))
                {
                    var _arg2 = _lastArg = _argCount > 3 ? _context.GetArgument(3) : global::Lua.LuaValue.Nil;
                    _lastArgPos = 2; _expectedType = typeof(global::Luny.UnityEngine.LuaMaterial);
                    if (_arg2.TryRead<global::Luny.UnityEngine.LuaMaterial>(out var _p2_UnityEngine_Material))
                    {
                        if (_argCount == 4)
                        {
                            var mesh = _p0_UnityEngine_Mesh.Instance;
                            var matrix = _p1_UnityEngine_Matrix4x4.Value;
                            var material = _p2_UnityEngine_Material.Instance;
                            _this.Instance.DrawMesh(mesh, matrix, material);
                            var _retCount = _context.Return();
                            return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                        }
                        var _arg3 = _lastArg = _argCount > 4 ? _context.GetArgument(4) : global::Lua.LuaValue.Nil;
                        _lastArgPos = 3; _expectedType = typeof(global::System.Int32);
                        if (_arg3.TryRead<global::System.Int32>(out var _p3_System_Int32))
                        {
                            if (_argCount == 5)
                            {
                                var mesh = _p0_UnityEngine_Mesh.Instance;
                                var matrix = _p1_UnityEngine_Matrix4x4.Value;
                                var material = _p2_UnityEngine_Material.Instance;
                                var submeshIndex = _p3_System_Int32;
                                _this.Instance.DrawMesh(mesh, matrix, material, submeshIndex);
                                var _retCount = _context.Return();
                                return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                            }
                            var _arg4 = _lastArg = _argCount > 5 ? _context.GetArgument(5) : global::Lua.LuaValue.Nil;
                            _lastArgPos = 4; _expectedType = typeof(global::System.Int32);
                            if (_arg4.TryRead<global::System.Int32>(out var _p4_System_Int32))
                            {
                                if (_argCount == 6)
                                {
                                    var mesh = _p0_UnityEngine_Mesh.Instance;
                                    var matrix = _p1_UnityEngine_Matrix4x4.Value;
                                    var material = _p2_UnityEngine_Material.Instance;
                                    var submeshIndex = _p3_System_Int32;
                                    var shaderPass = _p4_System_Int32;
                                    _this.Instance.DrawMesh(mesh, matrix, material, submeshIndex, shaderPass);
                                    var _retCount = _context.Return();
                                    return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                                }
                                var _arg5 = _lastArg = _argCount > 6 ? _context.GetArgument(6) : global::Lua.LuaValue.Nil;
                                _lastArgPos = 5; _expectedType = typeof(global::Luny.UnityEngine.LuaMaterialPropertyBlock);
                                if (_arg5.TryRead<global::Luny.UnityEngine.LuaMaterialPropertyBlock>(out var _p5_UnityEngine_MaterialPropertyBlock))
                                {
                                    if (_argCount == 7)
                                    {
                                        var mesh = _p0_UnityEngine_Mesh.Instance;
                                        var matrix = _p1_UnityEngine_Matrix4x4.Value;
                                        var material = _p2_UnityEngine_Material.Instance;
                                        var submeshIndex = _p3_System_Int32;
                                        var shaderPass = _p4_System_Int32;
                                        var properties = _p5_UnityEngine_MaterialPropertyBlock.Instance;
                                        _this.Instance.DrawMesh(mesh, matrix, material, submeshIndex, shaderPass, properties);
                                        var _retCount = _context.Return();
                                        return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                                    }
                                }
                            }
                        }
                    }
                }
            }
            throw new global::Lua.LuaRuntimeException(_context.Thread, $"{"DrawMesh"}: invalid argument #{_lastArgPos}: {_lastArg} ({_lastArg.Type}), expected: {_expectedType.FullName}", 2);
        });
        private static readonly global::Lua.LuaFunction _LuaCommandBuffer_DrawMeshInstanced = new global::Lua.LuaFunction("DrawMeshInstanced", (_context, _) =>
        {
            global::Lua.LuaValue _lastArg = default;
            global::System.Int32 _lastArgPos = default;
            global::System.Type _expectedType = default;
            var _argCount = _context.ArgumentCount;
            var _this = _context.GetArgument<LuaCommandBuffer>(0);
            var _arg0 = _lastArg = _argCount > 1 ? _context.GetArgument(1) : global::Lua.LuaValue.Nil;
            _lastArgPos = 0; _expectedType = typeof(global::Luny.UnityEngine.LuaMesh);
            if (_arg0.TryRead<global::Luny.UnityEngine.LuaMesh>(out var _p0_UnityEngine_Mesh))
            {
                var _arg1 = _lastArg = _argCount > 2 ? _context.GetArgument(2) : global::Lua.LuaValue.Nil;
                _lastArgPos = 1; _expectedType = typeof(global::System.Int32);
                if (_arg1.TryRead<global::System.Int32>(out var _p1_System_Int32))
                {
                    var _arg2 = _lastArg = _argCount > 3 ? _context.GetArgument(3) : global::Lua.LuaValue.Nil;
                    _lastArgPos = 2; _expectedType = typeof(global::Luny.UnityEngine.LuaMaterial);
                    if (_arg2.TryRead<global::Luny.UnityEngine.LuaMaterial>(out var _p2_UnityEngine_Material))
                    {
                        var _arg3 = _lastArg = _argCount > 4 ? _context.GetArgument(4) : global::Lua.LuaValue.Nil;
                        _lastArgPos = 3; _expectedType = typeof(global::System.Int32);
                        if (_arg3.TryRead<global::System.Int32>(out var _p3_System_Int32))
                        {
                            var _arg4 = _lastArg = _argCount > 5 ? _context.GetArgument(5) : global::Lua.LuaValue.Nil;
                            _lastArgPos = 4; _expectedType = typeof(global::UnityEngine.Matrix4x4[]);
                            if (_arg4.TryReadArray<global::UnityEngine.Matrix4x4>(out var _p4_UnityEngine_Matrix4x4Array))
                            {
                                if (_argCount == 6)
                                {
                                    var mesh = _p0_UnityEngine_Mesh.Instance;
                                    var submeshIndex = _p1_System_Int32;
                                    var material = _p2_UnityEngine_Material.Instance;
                                    var shaderPass = _p3_System_Int32;
                                    var matrices = _p4_UnityEngine_Matrix4x4Array;
                                    _this.Instance.DrawMeshInstanced(mesh, submeshIndex, material, shaderPass, matrices);
                                    var _retCount = _context.Return();
                                    return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                                }
                                var _arg5 = _lastArg = _argCount > 6 ? _context.GetArgument(6) : global::Lua.LuaValue.Nil;
                                _lastArgPos = 5; _expectedType = typeof(global::System.Int32);
                                if (_arg5.TryRead<global::System.Int32>(out var _p5_System_Int32))
                                {
                                    if (_argCount == 7)
                                    {
                                        var mesh = _p0_UnityEngine_Mesh.Instance;
                                        var submeshIndex = _p1_System_Int32;
                                        var material = _p2_UnityEngine_Material.Instance;
                                        var shaderPass = _p3_System_Int32;
                                        var matrices = _p4_UnityEngine_Matrix4x4Array;
                                        var count = _p5_System_Int32;
                                        _this.Instance.DrawMeshInstanced(mesh, submeshIndex, material, shaderPass, matrices, count);
                                        var _retCount = _context.Return();
                                        return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                                    }
                                    var _arg6 = _lastArg = _argCount > 7 ? _context.GetArgument(7) : global::Lua.LuaValue.Nil;
                                    _lastArgPos = 6; _expectedType = typeof(global::Luny.UnityEngine.LuaMaterialPropertyBlock);
                                    if (_arg6.TryRead<global::Luny.UnityEngine.LuaMaterialPropertyBlock>(out var _p6_UnityEngine_MaterialPropertyBlock))
                                    {
                                        if (_argCount == 8)
                                        {
                                            var mesh = _p0_UnityEngine_Mesh.Instance;
                                            var submeshIndex = _p1_System_Int32;
                                            var material = _p2_UnityEngine_Material.Instance;
                                            var shaderPass = _p3_System_Int32;
                                            var matrices = _p4_UnityEngine_Matrix4x4Array;
                                            var count = _p5_System_Int32;
                                            var properties = _p6_UnityEngine_MaterialPropertyBlock.Instance;
                                            _this.Instance.DrawMeshInstanced(mesh, submeshIndex, material, shaderPass, matrices, count, properties);
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
            throw new global::Lua.LuaRuntimeException(_context.Thread, $"{"DrawMeshInstanced"}: invalid argument #{_lastArgPos}: {_lastArg} ({_lastArg.Type}), expected: {_expectedType.FullName}", 2);
        });
        private static readonly global::Lua.LuaFunction _LuaCommandBuffer_DrawMeshInstancedIndirect = new global::Lua.LuaFunction("DrawMeshInstancedIndirect", (_context, _) =>
        {
            global::Lua.LuaValue _lastArg = default;
            global::System.Int32 _lastArgPos = default;
            global::System.Type _expectedType = default;
            var _argCount = _context.ArgumentCount;
            var _this = _context.GetArgument<LuaCommandBuffer>(0);
            var _arg0 = _lastArg = _argCount > 1 ? _context.GetArgument(1) : global::Lua.LuaValue.Nil;
            _lastArgPos = 0; _expectedType = typeof(global::Luny.UnityEngine.LuaMesh);
            if (_arg0.TryRead<global::Luny.UnityEngine.LuaMesh>(out var _p0_UnityEngine_Mesh))
            {
                var _arg1 = _lastArg = _argCount > 2 ? _context.GetArgument(2) : global::Lua.LuaValue.Nil;
                _lastArgPos = 1; _expectedType = typeof(global::System.Int32);
                if (_arg1.TryRead<global::System.Int32>(out var _p1_System_Int32))
                {
                    var _arg2 = _lastArg = _argCount > 3 ? _context.GetArgument(3) : global::Lua.LuaValue.Nil;
                    _lastArgPos = 2; _expectedType = typeof(global::Luny.UnityEngine.LuaMaterial);
                    if (_arg2.TryRead<global::Luny.UnityEngine.LuaMaterial>(out var _p2_UnityEngine_Material))
                    {
                        var _arg3 = _lastArg = _argCount > 4 ? _context.GetArgument(4) : global::Lua.LuaValue.Nil;
                        _lastArgPos = 3; _expectedType = typeof(global::System.Int32);
                        if (_arg3.TryRead<global::System.Int32>(out var _p3_System_Int32))
                        {
                            var _arg4 = _lastArg = _argCount > 5 ? _context.GetArgument(5) : global::Lua.LuaValue.Nil;
                            _lastArgPos = 4; _expectedType = typeof(global::Luny.UnityEngine.LuaComputeBuffer);
                            if (_arg4.TryRead<global::Luny.UnityEngine.LuaComputeBuffer>(out var _p4_UnityEngine_ComputeBuffer))
                            {
                                if (_argCount == 6)
                                {
                                    var mesh = _p0_UnityEngine_Mesh.Instance;
                                    var submeshIndex = _p1_System_Int32;
                                    var material = _p2_UnityEngine_Material.Instance;
                                    var shaderPass = _p3_System_Int32;
                                    var bufferWithArgs = _p4_UnityEngine_ComputeBuffer.Instance;
                                    _this.Instance.DrawMeshInstancedIndirect(mesh, submeshIndex, material, shaderPass, bufferWithArgs);
                                    var _retCount = _context.Return();
                                    return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                                }
                                var _arg5 = _lastArg = _argCount > 6 ? _context.GetArgument(6) : global::Lua.LuaValue.Nil;
                                _lastArgPos = 5; _expectedType = typeof(global::System.Int32);
                                if (_arg5.TryRead<global::System.Int32>(out var _p5_System_Int32))
                                {
                                    if (_argCount == 7)
                                    {
                                        var mesh = _p0_UnityEngine_Mesh.Instance;
                                        var submeshIndex = _p1_System_Int32;
                                        var material = _p2_UnityEngine_Material.Instance;
                                        var shaderPass = _p3_System_Int32;
                                        var bufferWithArgs = _p4_UnityEngine_ComputeBuffer.Instance;
                                        var argsOffset = _p5_System_Int32;
                                        _this.Instance.DrawMeshInstancedIndirect(mesh, submeshIndex, material, shaderPass, bufferWithArgs, argsOffset);
                                        var _retCount = _context.Return();
                                        return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                                    }
                                    var _arg6 = _lastArg = _argCount > 7 ? _context.GetArgument(7) : global::Lua.LuaValue.Nil;
                                    _lastArgPos = 6; _expectedType = typeof(global::Luny.UnityEngine.LuaMaterialPropertyBlock);
                                    if (_arg6.TryRead<global::Luny.UnityEngine.LuaMaterialPropertyBlock>(out var _p6_UnityEngine_MaterialPropertyBlock))
                                    {
                                        if (_argCount == 8)
                                        {
                                            var mesh = _p0_UnityEngine_Mesh.Instance;
                                            var submeshIndex = _p1_System_Int32;
                                            var material = _p2_UnityEngine_Material.Instance;
                                            var shaderPass = _p3_System_Int32;
                                            var bufferWithArgs = _p4_UnityEngine_ComputeBuffer.Instance;
                                            var argsOffset = _p5_System_Int32;
                                            var properties = _p6_UnityEngine_MaterialPropertyBlock.Instance;
                                            _this.Instance.DrawMeshInstancedIndirect(mesh, submeshIndex, material, shaderPass, bufferWithArgs, argsOffset, properties);
                                            var _retCount = _context.Return();
                                            return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                                        }
                                    }
                                }
                            }
                            _lastArgPos = 4; _expectedType = typeof(global::Luny.UnityEngine.LuaGraphicsBuffer);
                            if (_arg4.TryRead<global::Luny.UnityEngine.LuaGraphicsBuffer>(out var _p4_UnityEngine_GraphicsBuffer))
                            {
                                if (_argCount == 6)
                                {
                                    var mesh = _p0_UnityEngine_Mesh.Instance;
                                    var submeshIndex = _p1_System_Int32;
                                    var material = _p2_UnityEngine_Material.Instance;
                                    var shaderPass = _p3_System_Int32;
                                    var bufferWithArgs = _p4_UnityEngine_GraphicsBuffer.Instance;
                                    _this.Instance.DrawMeshInstancedIndirect(mesh, submeshIndex, material, shaderPass, bufferWithArgs);
                                    var _retCount = _context.Return();
                                    return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                                }
                                var _arg5 = _lastArg = _argCount > 6 ? _context.GetArgument(6) : global::Lua.LuaValue.Nil;
                                _lastArgPos = 5; _expectedType = typeof(global::System.Int32);
                                if (_arg5.TryRead<global::System.Int32>(out var _p5_System_Int32))
                                {
                                    if (_argCount == 7)
                                    {
                                        var mesh = _p0_UnityEngine_Mesh.Instance;
                                        var submeshIndex = _p1_System_Int32;
                                        var material = _p2_UnityEngine_Material.Instance;
                                        var shaderPass = _p3_System_Int32;
                                        var bufferWithArgs = _p4_UnityEngine_GraphicsBuffer.Instance;
                                        var argsOffset = _p5_System_Int32;
                                        _this.Instance.DrawMeshInstancedIndirect(mesh, submeshIndex, material, shaderPass, bufferWithArgs, argsOffset);
                                        var _retCount = _context.Return();
                                        return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                                    }
                                    var _arg6 = _lastArg = _argCount > 7 ? _context.GetArgument(7) : global::Lua.LuaValue.Nil;
                                    _lastArgPos = 6; _expectedType = typeof(global::Luny.UnityEngine.LuaMaterialPropertyBlock);
                                    if (_arg6.TryRead<global::Luny.UnityEngine.LuaMaterialPropertyBlock>(out var _p6_UnityEngine_MaterialPropertyBlock))
                                    {
                                        if (_argCount == 8)
                                        {
                                            var mesh = _p0_UnityEngine_Mesh.Instance;
                                            var submeshIndex = _p1_System_Int32;
                                            var material = _p2_UnityEngine_Material.Instance;
                                            var shaderPass = _p3_System_Int32;
                                            var bufferWithArgs = _p4_UnityEngine_GraphicsBuffer.Instance;
                                            var argsOffset = _p5_System_Int32;
                                            var properties = _p6_UnityEngine_MaterialPropertyBlock.Instance;
                                            _this.Instance.DrawMeshInstancedIndirect(mesh, submeshIndex, material, shaderPass, bufferWithArgs, argsOffset, properties);
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
            throw new global::Lua.LuaRuntimeException(_context.Thread, $"{"DrawMeshInstancedIndirect"}: invalid argument #{_lastArgPos}: {_lastArg} ({_lastArg.Type}), expected: {_expectedType.FullName}", 2);
        });
        private static readonly global::Lua.LuaFunction _LuaCommandBuffer_DrawMeshInstancedProcedural = new global::Lua.LuaFunction("DrawMeshInstancedProcedural", (_context, _) =>
        {
            global::Lua.LuaValue _lastArg = default;
            global::System.Int32 _lastArgPos = default;
            global::System.Type _expectedType = default;
            var _argCount = _context.ArgumentCount;
            var _this = _context.GetArgument<LuaCommandBuffer>(0);
            var _arg0 = _lastArg = _argCount > 1 ? _context.GetArgument(1) : global::Lua.LuaValue.Nil;
            _lastArgPos = 0; _expectedType = typeof(global::Luny.UnityEngine.LuaMesh);
            if (_arg0.TryRead<global::Luny.UnityEngine.LuaMesh>(out var _p0_UnityEngine_Mesh))
            {
                var _arg1 = _lastArg = _argCount > 2 ? _context.GetArgument(2) : global::Lua.LuaValue.Nil;
                _lastArgPos = 1; _expectedType = typeof(global::System.Int32);
                if (_arg1.TryRead<global::System.Int32>(out var _p1_System_Int32))
                {
                    var _arg2 = _lastArg = _argCount > 3 ? _context.GetArgument(3) : global::Lua.LuaValue.Nil;
                    _lastArgPos = 2; _expectedType = typeof(global::Luny.UnityEngine.LuaMaterial);
                    if (_arg2.TryRead<global::Luny.UnityEngine.LuaMaterial>(out var _p2_UnityEngine_Material))
                    {
                        var _arg3 = _lastArg = _argCount > 4 ? _context.GetArgument(4) : global::Lua.LuaValue.Nil;
                        _lastArgPos = 3; _expectedType = typeof(global::System.Int32);
                        if (_arg3.TryRead<global::System.Int32>(out var _p3_System_Int32))
                        {
                            var _arg4 = _lastArg = _argCount > 5 ? _context.GetArgument(5) : global::Lua.LuaValue.Nil;
                            _lastArgPos = 4; _expectedType = typeof(global::System.Int32);
                            if (_arg4.TryRead<global::System.Int32>(out var _p4_System_Int32))
                            {
                                if (_argCount == 6)
                                {
                                    var mesh = _p0_UnityEngine_Mesh.Instance;
                                    var submeshIndex = _p1_System_Int32;
                                    var material = _p2_UnityEngine_Material.Instance;
                                    var shaderPass = _p3_System_Int32;
                                    var count = _p4_System_Int32;
                                    _this.Instance.DrawMeshInstancedProcedural(mesh, submeshIndex, material, shaderPass, count);
                                    var _retCount = _context.Return();
                                    return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                                }
                                var _arg5 = _lastArg = _argCount > 6 ? _context.GetArgument(6) : global::Lua.LuaValue.Nil;
                                _lastArgPos = 5; _expectedType = typeof(global::Luny.UnityEngine.LuaMaterialPropertyBlock);
                                var _p5_UnityEngine_MaterialPropertyBlock = _arg5.ReadValue<global::Luny.UnityEngine.LuaMaterialPropertyBlock>(default);
                                {
                                    if (_argCount == 7)
                                    {
                                        var mesh = _p0_UnityEngine_Mesh.Instance;
                                        var submeshIndex = _p1_System_Int32;
                                        var material = _p2_UnityEngine_Material.Instance;
                                        var shaderPass = _p3_System_Int32;
                                        var count = _p4_System_Int32;
                                        var properties = _p5_UnityEngine_MaterialPropertyBlock.Instance;
                                        _this.Instance.DrawMeshInstancedProcedural(mesh, submeshIndex, material, shaderPass, count, properties);
                                        var _retCount = _context.Return();
                                        return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                                    }
                                }
                            }
                        }
                    }
                }
            }
            throw new global::Lua.LuaRuntimeException(_context.Thread, $"{"DrawMeshInstancedProcedural"}: invalid argument #{_lastArgPos}: {_lastArg} ({_lastArg.Type}), expected: {_expectedType.FullName}", 2);
        });
        private static readonly global::Lua.LuaFunction _LuaCommandBuffer_DrawMultipleMeshes = new global::Lua.LuaFunction("DrawMultipleMeshes", (_context, _) =>
        {
            global::Lua.LuaValue _lastArg = default;
            global::System.Int32 _lastArgPos = default;
            global::System.Type _expectedType = default;
            var _argCount = _context.ArgumentCount;
            var _this = _context.GetArgument<LuaCommandBuffer>(0);
            var _arg0 = _lastArg = _argCount > 1 ? _context.GetArgument(1) : global::Lua.LuaValue.Nil;
            _lastArgPos = 0; _expectedType = typeof(global::UnityEngine.Matrix4x4[]);
            if (_arg0.TryReadArray<global::UnityEngine.Matrix4x4>(out var _p0_UnityEngine_Matrix4x4Array))
            {
                var _arg1 = _lastArg = _argCount > 2 ? _context.GetArgument(2) : global::Lua.LuaValue.Nil;
                _lastArgPos = 1; _expectedType = typeof(global::UnityEngine.Mesh[]);
                if (_arg1.TryReadArray<global::UnityEngine.Mesh>(out var _p1_UnityEngine_MeshArray))
                {
                    var _arg2 = _lastArg = _argCount > 3 ? _context.GetArgument(3) : global::Lua.LuaValue.Nil;
                    _lastArgPos = 2; _expectedType = typeof(global::System.Int32[]);
                    if (_arg2.TryReadArray<global::System.Int32>(out var _p2_System_Int32Array))
                    {
                        var _arg3 = _lastArg = _argCount > 4 ? _context.GetArgument(4) : global::Lua.LuaValue.Nil;
                        _lastArgPos = 3; _expectedType = typeof(global::System.Int32);
                        if (_arg3.TryRead<global::System.Int32>(out var _p3_System_Int32))
                        {
                            var _arg4 = _lastArg = _argCount > 5 ? _context.GetArgument(5) : global::Lua.LuaValue.Nil;
                            _lastArgPos = 4; _expectedType = typeof(global::Luny.UnityEngine.LuaMaterial);
                            if (_arg4.TryRead<global::Luny.UnityEngine.LuaMaterial>(out var _p4_UnityEngine_Material))
                            {
                                var _arg5 = _lastArg = _argCount > 6 ? _context.GetArgument(6) : global::Lua.LuaValue.Nil;
                                _lastArgPos = 5; _expectedType = typeof(global::System.Int32);
                                if (_arg5.TryRead<global::System.Int32>(out var _p5_System_Int32))
                                {
                                    var _arg6 = _lastArg = _argCount > 7 ? _context.GetArgument(7) : global::Lua.LuaValue.Nil;
                                    _lastArgPos = 6; _expectedType = typeof(global::Luny.UnityEngine.LuaMaterialPropertyBlock);
                                    if (_arg6.TryRead<global::Luny.UnityEngine.LuaMaterialPropertyBlock>(out var _p6_UnityEngine_MaterialPropertyBlock))
                                    {
                                        if (_argCount == 8)
                                        {
                                            var matrices = _p0_UnityEngine_Matrix4x4Array;
                                            var meshes = _p1_UnityEngine_MeshArray;
                                            var subsetIndices = _p2_System_Int32Array;
                                            var count = _p3_System_Int32;
                                            var material = _p4_UnityEngine_Material.Instance;
                                            var shaderPass = _p5_System_Int32;
                                            var properties = _p6_UnityEngine_MaterialPropertyBlock.Instance;
                                            _this.Instance.DrawMultipleMeshes(matrices, meshes, subsetIndices, count, material, shaderPass, properties);
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
            throw new global::Lua.LuaRuntimeException(_context.Thread, $"{"DrawMultipleMeshes"}: invalid argument #{_lastArgPos}: {_lastArg} ({_lastArg.Type}), expected: {_expectedType.FullName}", 2);
        });
        private static readonly global::Lua.LuaFunction _LuaCommandBuffer_DrawOcclusionMesh = new global::Lua.LuaFunction("DrawOcclusionMesh", (_context, _) =>
        {
            global::Lua.LuaValue _lastArg = default;
            global::System.Int32 _lastArgPos = default;
            global::System.Type _expectedType = default;
            var _argCount = _context.ArgumentCount;
            var _this = _context.GetArgument<LuaCommandBuffer>(0);
            var _arg0 = _lastArg = _argCount > 1 ? _context.GetArgument(1) : global::Lua.LuaValue.Nil;
            _lastArgPos = 0; _expectedType = typeof(global::Luny.UnityEngine.LuaRectInt);
            if (_arg0.TryRead<global::Luny.UnityEngine.LuaRectInt>(out var _p0_UnityEngine_RectInt))
            {
                if (_argCount == 2)
                {
                    var normalizedCamViewport = _p0_UnityEngine_RectInt.Value;
                    _this.Instance.DrawOcclusionMesh(normalizedCamViewport);
                    var _retCount = _context.Return();
                    return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                }
            }
            throw new global::Lua.LuaRuntimeException(_context.Thread, $"{"DrawOcclusionMesh"}: invalid argument #{_lastArgPos}: {_lastArg} ({_lastArg.Type}), expected: {_expectedType.FullName}", 2);
        });
        private static readonly global::Lua.LuaFunction _LuaCommandBuffer_DrawProcedural = new global::Lua.LuaFunction("DrawProcedural", (_context, _) =>
        {
            global::Lua.LuaValue _lastArg = default;
            global::System.Int32 _lastArgPos = default;
            global::System.Type _expectedType = default;
            var _argCount = _context.ArgumentCount;
            var _this = _context.GetArgument<LuaCommandBuffer>(0);
            var _arg0 = _lastArg = _argCount > 1 ? _context.GetArgument(1) : global::Lua.LuaValue.Nil;
            _lastArgPos = 0; _expectedType = typeof(global::Luny.UnityEngine.LuaMatrix4x4);
            if (_arg0.TryRead<global::Luny.UnityEngine.LuaMatrix4x4>(out var _p0_UnityEngine_Matrix4x4))
            {
                var _arg1 = _lastArg = _argCount > 2 ? _context.GetArgument(2) : global::Lua.LuaValue.Nil;
                _lastArgPos = 1; _expectedType = typeof(global::Luny.UnityEngine.LuaMaterial);
                if (_arg1.TryRead<global::Luny.UnityEngine.LuaMaterial>(out var _p1_UnityEngine_Material))
                {
                    var _arg2 = _lastArg = _argCount > 3 ? _context.GetArgument(3) : global::Lua.LuaValue.Nil;
                    _lastArgPos = 2; _expectedType = typeof(global::System.Int32);
                    if (_arg2.TryRead<global::System.Int32>(out var _p2_System_Int32))
                    {
                        var _arg3 = _lastArg = _argCount > 4 ? _context.GetArgument(4) : global::Lua.LuaValue.Nil;
                        _lastArgPos = 3; _expectedType = typeof(global::UnityEngine.MeshTopology);
                        if (_arg3.TryRead<global::UnityEngine.MeshTopology>(out var _p3_UnityEngine_MeshTopology))
                        {
                            var _arg4 = _lastArg = _argCount > 5 ? _context.GetArgument(5) : global::Lua.LuaValue.Nil;
                            _lastArgPos = 4; _expectedType = typeof(global::System.Int32);
                            if (_arg4.TryRead<global::System.Int32>(out var _p4_System_Int32))
                            {
                                if (_argCount == 6)
                                {
                                    var matrix = _p0_UnityEngine_Matrix4x4.Value;
                                    var material = _p1_UnityEngine_Material.Instance;
                                    var shaderPass = _p2_System_Int32;
                                    var topology = _p3_UnityEngine_MeshTopology;
                                    var vertexCount = _p4_System_Int32;
                                    _this.Instance.DrawProcedural(matrix, material, shaderPass, topology, vertexCount);
                                    var _retCount = _context.Return();
                                    return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                                }
                                var _arg5 = _lastArg = _argCount > 6 ? _context.GetArgument(6) : global::Lua.LuaValue.Nil;
                                _lastArgPos = 5; _expectedType = typeof(global::System.Int32);
                                if (_arg5.TryRead<global::System.Int32>(out var _p5_System_Int32))
                                {
                                    if (_argCount == 7)
                                    {
                                        var matrix = _p0_UnityEngine_Matrix4x4.Value;
                                        var material = _p1_UnityEngine_Material.Instance;
                                        var shaderPass = _p2_System_Int32;
                                        var topology = _p3_UnityEngine_MeshTopology;
                                        var vertexCount = _p4_System_Int32;
                                        var instanceCount = _p5_System_Int32;
                                        _this.Instance.DrawProcedural(matrix, material, shaderPass, topology, vertexCount, instanceCount);
                                        var _retCount = _context.Return();
                                        return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                                    }
                                    var _arg6 = _lastArg = _argCount > 7 ? _context.GetArgument(7) : global::Lua.LuaValue.Nil;
                                    _lastArgPos = 6; _expectedType = typeof(global::Luny.UnityEngine.LuaMaterialPropertyBlock);
                                    if (_arg6.TryRead<global::Luny.UnityEngine.LuaMaterialPropertyBlock>(out var _p6_UnityEngine_MaterialPropertyBlock))
                                    {
                                        if (_argCount == 8)
                                        {
                                            var matrix = _p0_UnityEngine_Matrix4x4.Value;
                                            var material = _p1_UnityEngine_Material.Instance;
                                            var shaderPass = _p2_System_Int32;
                                            var topology = _p3_UnityEngine_MeshTopology;
                                            var vertexCount = _p4_System_Int32;
                                            var instanceCount = _p5_System_Int32;
                                            var properties = _p6_UnityEngine_MaterialPropertyBlock.Instance;
                                            _this.Instance.DrawProcedural(matrix, material, shaderPass, topology, vertexCount, instanceCount, properties);
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
            _lastArgPos = 0; _expectedType = typeof(global::Luny.UnityEngine.LuaGraphicsBuffer);
            if (_arg0.TryRead<global::Luny.UnityEngine.LuaGraphicsBuffer>(out var _p0_UnityEngine_GraphicsBuffer))
            {
                var _arg1 = _lastArg = _argCount > 2 ? _context.GetArgument(2) : global::Lua.LuaValue.Nil;
                _lastArgPos = 1; _expectedType = typeof(global::Luny.UnityEngine.LuaMatrix4x4);
                if (_arg1.TryRead<global::Luny.UnityEngine.LuaMatrix4x4>(out var _p1_UnityEngine_Matrix4x4))
                {
                    var _arg2 = _lastArg = _argCount > 3 ? _context.GetArgument(3) : global::Lua.LuaValue.Nil;
                    _lastArgPos = 2; _expectedType = typeof(global::Luny.UnityEngine.LuaMaterial);
                    if (_arg2.TryRead<global::Luny.UnityEngine.LuaMaterial>(out var _p2_UnityEngine_Material))
                    {
                        var _arg3 = _lastArg = _argCount > 4 ? _context.GetArgument(4) : global::Lua.LuaValue.Nil;
                        _lastArgPos = 3; _expectedType = typeof(global::System.Int32);
                        if (_arg3.TryRead<global::System.Int32>(out var _p3_System_Int32))
                        {
                            var _arg4 = _lastArg = _argCount > 5 ? _context.GetArgument(5) : global::Lua.LuaValue.Nil;
                            _lastArgPos = 4; _expectedType = typeof(global::UnityEngine.MeshTopology);
                            if (_arg4.TryRead<global::UnityEngine.MeshTopology>(out var _p4_UnityEngine_MeshTopology))
                            {
                                var _arg5 = _lastArg = _argCount > 6 ? _context.GetArgument(6) : global::Lua.LuaValue.Nil;
                                _lastArgPos = 5; _expectedType = typeof(global::System.Int32);
                                if (_arg5.TryRead<global::System.Int32>(out var _p5_System_Int32))
                                {
                                    if (_argCount == 7)
                                    {
                                        var indexBuffer = _p0_UnityEngine_GraphicsBuffer.Instance;
                                        var matrix = _p1_UnityEngine_Matrix4x4.Value;
                                        var material = _p2_UnityEngine_Material.Instance;
                                        var shaderPass = _p3_System_Int32;
                                        var topology = _p4_UnityEngine_MeshTopology;
                                        var indexCount = _p5_System_Int32;
                                        _this.Instance.DrawProcedural(indexBuffer, matrix, material, shaderPass, topology, indexCount);
                                        var _retCount = _context.Return();
                                        return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                                    }
                                    var _arg6 = _lastArg = _argCount > 7 ? _context.GetArgument(7) : global::Lua.LuaValue.Nil;
                                    _lastArgPos = 6; _expectedType = typeof(global::System.Int32);
                                    if (_arg6.TryRead<global::System.Int32>(out var _p6_System_Int32))
                                    {
                                        if (_argCount == 8)
                                        {
                                            var indexBuffer = _p0_UnityEngine_GraphicsBuffer.Instance;
                                            var matrix = _p1_UnityEngine_Matrix4x4.Value;
                                            var material = _p2_UnityEngine_Material.Instance;
                                            var shaderPass = _p3_System_Int32;
                                            var topology = _p4_UnityEngine_MeshTopology;
                                            var indexCount = _p5_System_Int32;
                                            var instanceCount = _p6_System_Int32;
                                            _this.Instance.DrawProcedural(indexBuffer, matrix, material, shaderPass, topology, indexCount, instanceCount);
                                            var _retCount = _context.Return();
                                            return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                                        }
                                        var _arg7 = _lastArg = _argCount > 8 ? _context.GetArgument(8) : global::Lua.LuaValue.Nil;
                                        _lastArgPos = 7; _expectedType = typeof(global::Luny.UnityEngine.LuaMaterialPropertyBlock);
                                        if (_arg7.TryRead<global::Luny.UnityEngine.LuaMaterialPropertyBlock>(out var _p7_UnityEngine_MaterialPropertyBlock))
                                        {
                                            if (_argCount == 9)
                                            {
                                                var indexBuffer = _p0_UnityEngine_GraphicsBuffer.Instance;
                                                var matrix = _p1_UnityEngine_Matrix4x4.Value;
                                                var material = _p2_UnityEngine_Material.Instance;
                                                var shaderPass = _p3_System_Int32;
                                                var topology = _p4_UnityEngine_MeshTopology;
                                                var indexCount = _p5_System_Int32;
                                                var instanceCount = _p6_System_Int32;
                                                var properties = _p7_UnityEngine_MaterialPropertyBlock.Instance;
                                                _this.Instance.DrawProcedural(indexBuffer, matrix, material, shaderPass, topology, indexCount, instanceCount, properties);
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
            throw new global::Lua.LuaRuntimeException(_context.Thread, $"{"DrawProcedural"}: invalid argument #{_lastArgPos}: {_lastArg} ({_lastArg.Type}), expected: {_expectedType.FullName}", 2);
        });
        private static readonly global::Lua.LuaFunction _LuaCommandBuffer_DrawProceduralIndirect = new global::Lua.LuaFunction("DrawProceduralIndirect", (_context, _) =>
        {
            global::Lua.LuaValue _lastArg = default;
            global::System.Int32 _lastArgPos = default;
            global::System.Type _expectedType = default;
            var _argCount = _context.ArgumentCount;
            var _this = _context.GetArgument<LuaCommandBuffer>(0);
            var _arg0 = _lastArg = _argCount > 1 ? _context.GetArgument(1) : global::Lua.LuaValue.Nil;
            _lastArgPos = 0; _expectedType = typeof(global::Luny.UnityEngine.LuaMatrix4x4);
            if (_arg0.TryRead<global::Luny.UnityEngine.LuaMatrix4x4>(out var _p0_UnityEngine_Matrix4x4))
            {
                var _arg1 = _lastArg = _argCount > 2 ? _context.GetArgument(2) : global::Lua.LuaValue.Nil;
                _lastArgPos = 1; _expectedType = typeof(global::Luny.UnityEngine.LuaMaterial);
                if (_arg1.TryRead<global::Luny.UnityEngine.LuaMaterial>(out var _p1_UnityEngine_Material))
                {
                    var _arg2 = _lastArg = _argCount > 3 ? _context.GetArgument(3) : global::Lua.LuaValue.Nil;
                    _lastArgPos = 2; _expectedType = typeof(global::System.Int32);
                    if (_arg2.TryRead<global::System.Int32>(out var _p2_System_Int32))
                    {
                        var _arg3 = _lastArg = _argCount > 4 ? _context.GetArgument(4) : global::Lua.LuaValue.Nil;
                        _lastArgPos = 3; _expectedType = typeof(global::UnityEngine.MeshTopology);
                        if (_arg3.TryRead<global::UnityEngine.MeshTopology>(out var _p3_UnityEngine_MeshTopology))
                        {
                            var _arg4 = _lastArg = _argCount > 5 ? _context.GetArgument(5) : global::Lua.LuaValue.Nil;
                            _lastArgPos = 4; _expectedType = typeof(global::Luny.UnityEngine.LuaComputeBuffer);
                            if (_arg4.TryRead<global::Luny.UnityEngine.LuaComputeBuffer>(out var _p4_UnityEngine_ComputeBuffer))
                            {
                                if (_argCount == 6)
                                {
                                    var matrix = _p0_UnityEngine_Matrix4x4.Value;
                                    var material = _p1_UnityEngine_Material.Instance;
                                    var shaderPass = _p2_System_Int32;
                                    var topology = _p3_UnityEngine_MeshTopology;
                                    var bufferWithArgs = _p4_UnityEngine_ComputeBuffer.Instance;
                                    _this.Instance.DrawProceduralIndirect(matrix, material, shaderPass, topology, bufferWithArgs);
                                    var _retCount = _context.Return();
                                    return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                                }
                                var _arg5 = _lastArg = _argCount > 6 ? _context.GetArgument(6) : global::Lua.LuaValue.Nil;
                                _lastArgPos = 5; _expectedType = typeof(global::System.Int32);
                                if (_arg5.TryRead<global::System.Int32>(out var _p5_System_Int32))
                                {
                                    if (_argCount == 7)
                                    {
                                        var matrix = _p0_UnityEngine_Matrix4x4.Value;
                                        var material = _p1_UnityEngine_Material.Instance;
                                        var shaderPass = _p2_System_Int32;
                                        var topology = _p3_UnityEngine_MeshTopology;
                                        var bufferWithArgs = _p4_UnityEngine_ComputeBuffer.Instance;
                                        var argsOffset = _p5_System_Int32;
                                        _this.Instance.DrawProceduralIndirect(matrix, material, shaderPass, topology, bufferWithArgs, argsOffset);
                                        var _retCount = _context.Return();
                                        return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                                    }
                                    var _arg6 = _lastArg = _argCount > 7 ? _context.GetArgument(7) : global::Lua.LuaValue.Nil;
                                    _lastArgPos = 6; _expectedType = typeof(global::Luny.UnityEngine.LuaMaterialPropertyBlock);
                                    if (_arg6.TryRead<global::Luny.UnityEngine.LuaMaterialPropertyBlock>(out var _p6_UnityEngine_MaterialPropertyBlock))
                                    {
                                        if (_argCount == 8)
                                        {
                                            var matrix = _p0_UnityEngine_Matrix4x4.Value;
                                            var material = _p1_UnityEngine_Material.Instance;
                                            var shaderPass = _p2_System_Int32;
                                            var topology = _p3_UnityEngine_MeshTopology;
                                            var bufferWithArgs = _p4_UnityEngine_ComputeBuffer.Instance;
                                            var argsOffset = _p5_System_Int32;
                                            var properties = _p6_UnityEngine_MaterialPropertyBlock.Instance;
                                            _this.Instance.DrawProceduralIndirect(matrix, material, shaderPass, topology, bufferWithArgs, argsOffset, properties);
                                            var _retCount = _context.Return();
                                            return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                                        }
                                    }
                                }
                            }
                            _lastArgPos = 4; _expectedType = typeof(global::Luny.UnityEngine.LuaGraphicsBuffer);
                            if (_arg4.TryRead<global::Luny.UnityEngine.LuaGraphicsBuffer>(out var _p4_UnityEngine_GraphicsBuffer))
                            {
                                if (_argCount == 6)
                                {
                                    var matrix = _p0_UnityEngine_Matrix4x4.Value;
                                    var material = _p1_UnityEngine_Material.Instance;
                                    var shaderPass = _p2_System_Int32;
                                    var topology = _p3_UnityEngine_MeshTopology;
                                    var bufferWithArgs = _p4_UnityEngine_GraphicsBuffer.Instance;
                                    _this.Instance.DrawProceduralIndirect(matrix, material, shaderPass, topology, bufferWithArgs);
                                    var _retCount = _context.Return();
                                    return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                                }
                                var _arg5 = _lastArg = _argCount > 6 ? _context.GetArgument(6) : global::Lua.LuaValue.Nil;
                                _lastArgPos = 5; _expectedType = typeof(global::System.Int32);
                                if (_arg5.TryRead<global::System.Int32>(out var _p5_System_Int32))
                                {
                                    if (_argCount == 7)
                                    {
                                        var matrix = _p0_UnityEngine_Matrix4x4.Value;
                                        var material = _p1_UnityEngine_Material.Instance;
                                        var shaderPass = _p2_System_Int32;
                                        var topology = _p3_UnityEngine_MeshTopology;
                                        var bufferWithArgs = _p4_UnityEngine_GraphicsBuffer.Instance;
                                        var argsOffset = _p5_System_Int32;
                                        _this.Instance.DrawProceduralIndirect(matrix, material, shaderPass, topology, bufferWithArgs, argsOffset);
                                        var _retCount = _context.Return();
                                        return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                                    }
                                    var _arg6 = _lastArg = _argCount > 7 ? _context.GetArgument(7) : global::Lua.LuaValue.Nil;
                                    _lastArgPos = 6; _expectedType = typeof(global::Luny.UnityEngine.LuaMaterialPropertyBlock);
                                    if (_arg6.TryRead<global::Luny.UnityEngine.LuaMaterialPropertyBlock>(out var _p6_UnityEngine_MaterialPropertyBlock))
                                    {
                                        if (_argCount == 8)
                                        {
                                            var matrix = _p0_UnityEngine_Matrix4x4.Value;
                                            var material = _p1_UnityEngine_Material.Instance;
                                            var shaderPass = _p2_System_Int32;
                                            var topology = _p3_UnityEngine_MeshTopology;
                                            var bufferWithArgs = _p4_UnityEngine_GraphicsBuffer.Instance;
                                            var argsOffset = _p5_System_Int32;
                                            var properties = _p6_UnityEngine_MaterialPropertyBlock.Instance;
                                            _this.Instance.DrawProceduralIndirect(matrix, material, shaderPass, topology, bufferWithArgs, argsOffset, properties);
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
            _lastArgPos = 0; _expectedType = typeof(global::Luny.UnityEngine.LuaGraphicsBuffer);
            if (_arg0.TryRead<global::Luny.UnityEngine.LuaGraphicsBuffer>(out var _p0_UnityEngine_GraphicsBuffer))
            {
                var _arg1 = _lastArg = _argCount > 2 ? _context.GetArgument(2) : global::Lua.LuaValue.Nil;
                _lastArgPos = 1; _expectedType = typeof(global::Luny.UnityEngine.LuaMatrix4x4);
                if (_arg1.TryRead<global::Luny.UnityEngine.LuaMatrix4x4>(out var _p1_UnityEngine_Matrix4x4))
                {
                    var _arg2 = _lastArg = _argCount > 3 ? _context.GetArgument(3) : global::Lua.LuaValue.Nil;
                    _lastArgPos = 2; _expectedType = typeof(global::Luny.UnityEngine.LuaMaterial);
                    if (_arg2.TryRead<global::Luny.UnityEngine.LuaMaterial>(out var _p2_UnityEngine_Material))
                    {
                        var _arg3 = _lastArg = _argCount > 4 ? _context.GetArgument(4) : global::Lua.LuaValue.Nil;
                        _lastArgPos = 3; _expectedType = typeof(global::System.Int32);
                        if (_arg3.TryRead<global::System.Int32>(out var _p3_System_Int32))
                        {
                            var _arg4 = _lastArg = _argCount > 5 ? _context.GetArgument(5) : global::Lua.LuaValue.Nil;
                            _lastArgPos = 4; _expectedType = typeof(global::UnityEngine.MeshTopology);
                            if (_arg4.TryRead<global::UnityEngine.MeshTopology>(out var _p4_UnityEngine_MeshTopology))
                            {
                                var _arg5 = _lastArg = _argCount > 6 ? _context.GetArgument(6) : global::Lua.LuaValue.Nil;
                                _lastArgPos = 5; _expectedType = typeof(global::Luny.UnityEngine.LuaComputeBuffer);
                                if (_arg5.TryRead<global::Luny.UnityEngine.LuaComputeBuffer>(out var _p5_UnityEngine_ComputeBuffer))
                                {
                                    if (_argCount == 7)
                                    {
                                        var indexBuffer = _p0_UnityEngine_GraphicsBuffer.Instance;
                                        var matrix = _p1_UnityEngine_Matrix4x4.Value;
                                        var material = _p2_UnityEngine_Material.Instance;
                                        var shaderPass = _p3_System_Int32;
                                        var topology = _p4_UnityEngine_MeshTopology;
                                        var bufferWithArgs = _p5_UnityEngine_ComputeBuffer.Instance;
                                        _this.Instance.DrawProceduralIndirect(indexBuffer, matrix, material, shaderPass, topology, bufferWithArgs);
                                        var _retCount = _context.Return();
                                        return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                                    }
                                    var _arg6 = _lastArg = _argCount > 7 ? _context.GetArgument(7) : global::Lua.LuaValue.Nil;
                                    _lastArgPos = 6; _expectedType = typeof(global::System.Int32);
                                    if (_arg6.TryRead<global::System.Int32>(out var _p6_System_Int32))
                                    {
                                        if (_argCount == 8)
                                        {
                                            var indexBuffer = _p0_UnityEngine_GraphicsBuffer.Instance;
                                            var matrix = _p1_UnityEngine_Matrix4x4.Value;
                                            var material = _p2_UnityEngine_Material.Instance;
                                            var shaderPass = _p3_System_Int32;
                                            var topology = _p4_UnityEngine_MeshTopology;
                                            var bufferWithArgs = _p5_UnityEngine_ComputeBuffer.Instance;
                                            var argsOffset = _p6_System_Int32;
                                            _this.Instance.DrawProceduralIndirect(indexBuffer, matrix, material, shaderPass, topology, bufferWithArgs, argsOffset);
                                            var _retCount = _context.Return();
                                            return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                                        }
                                        var _arg7 = _lastArg = _argCount > 8 ? _context.GetArgument(8) : global::Lua.LuaValue.Nil;
                                        _lastArgPos = 7; _expectedType = typeof(global::Luny.UnityEngine.LuaMaterialPropertyBlock);
                                        if (_arg7.TryRead<global::Luny.UnityEngine.LuaMaterialPropertyBlock>(out var _p7_UnityEngine_MaterialPropertyBlock))
                                        {
                                            if (_argCount == 9)
                                            {
                                                var indexBuffer = _p0_UnityEngine_GraphicsBuffer.Instance;
                                                var matrix = _p1_UnityEngine_Matrix4x4.Value;
                                                var material = _p2_UnityEngine_Material.Instance;
                                                var shaderPass = _p3_System_Int32;
                                                var topology = _p4_UnityEngine_MeshTopology;
                                                var bufferWithArgs = _p5_UnityEngine_ComputeBuffer.Instance;
                                                var argsOffset = _p6_System_Int32;
                                                var properties = _p7_UnityEngine_MaterialPropertyBlock.Instance;
                                                _this.Instance.DrawProceduralIndirect(indexBuffer, matrix, material, shaderPass, topology, bufferWithArgs, argsOffset, properties);
                                                var _retCount = _context.Return();
                                                return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                                            }
                                        }
                                    }
                                }
                                _lastArgPos = 5; _expectedType = typeof(global::Luny.UnityEngine.LuaGraphicsBuffer);
                                if (_arg5.TryRead<global::Luny.UnityEngine.LuaGraphicsBuffer>(out var _p5_UnityEngine_GraphicsBuffer))
                                {
                                    if (_argCount == 7)
                                    {
                                        var indexBuffer = _p0_UnityEngine_GraphicsBuffer.Instance;
                                        var matrix = _p1_UnityEngine_Matrix4x4.Value;
                                        var material = _p2_UnityEngine_Material.Instance;
                                        var shaderPass = _p3_System_Int32;
                                        var topology = _p4_UnityEngine_MeshTopology;
                                        var bufferWithArgs = _p5_UnityEngine_GraphicsBuffer.Instance;
                                        _this.Instance.DrawProceduralIndirect(indexBuffer, matrix, material, shaderPass, topology, bufferWithArgs);
                                        var _retCount = _context.Return();
                                        return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                                    }
                                    var _arg6 = _lastArg = _argCount > 7 ? _context.GetArgument(7) : global::Lua.LuaValue.Nil;
                                    _lastArgPos = 6; _expectedType = typeof(global::System.Int32);
                                    if (_arg6.TryRead<global::System.Int32>(out var _p6_System_Int32))
                                    {
                                        if (_argCount == 8)
                                        {
                                            var indexBuffer = _p0_UnityEngine_GraphicsBuffer.Instance;
                                            var matrix = _p1_UnityEngine_Matrix4x4.Value;
                                            var material = _p2_UnityEngine_Material.Instance;
                                            var shaderPass = _p3_System_Int32;
                                            var topology = _p4_UnityEngine_MeshTopology;
                                            var bufferWithArgs = _p5_UnityEngine_GraphicsBuffer.Instance;
                                            var argsOffset = _p6_System_Int32;
                                            _this.Instance.DrawProceduralIndirect(indexBuffer, matrix, material, shaderPass, topology, bufferWithArgs, argsOffset);
                                            var _retCount = _context.Return();
                                            return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                                        }
                                        var _arg7 = _lastArg = _argCount > 8 ? _context.GetArgument(8) : global::Lua.LuaValue.Nil;
                                        _lastArgPos = 7; _expectedType = typeof(global::Luny.UnityEngine.LuaMaterialPropertyBlock);
                                        if (_arg7.TryRead<global::Luny.UnityEngine.LuaMaterialPropertyBlock>(out var _p7_UnityEngine_MaterialPropertyBlock))
                                        {
                                            if (_argCount == 9)
                                            {
                                                var indexBuffer = _p0_UnityEngine_GraphicsBuffer.Instance;
                                                var matrix = _p1_UnityEngine_Matrix4x4.Value;
                                                var material = _p2_UnityEngine_Material.Instance;
                                                var shaderPass = _p3_System_Int32;
                                                var topology = _p4_UnityEngine_MeshTopology;
                                                var bufferWithArgs = _p5_UnityEngine_GraphicsBuffer.Instance;
                                                var argsOffset = _p6_System_Int32;
                                                var properties = _p7_UnityEngine_MaterialPropertyBlock.Instance;
                                                _this.Instance.DrawProceduralIndirect(indexBuffer, matrix, material, shaderPass, topology, bufferWithArgs, argsOffset, properties);
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
            throw new global::Lua.LuaRuntimeException(_context.Thread, $"{"DrawProceduralIndirect"}: invalid argument #{_lastArgPos}: {_lastArg} ({_lastArg.Type}), expected: {_expectedType.FullName}", 2);
        });
        private static readonly global::Lua.LuaFunction _LuaCommandBuffer_DrawRenderer = new global::Lua.LuaFunction("DrawRenderer", (_context, _) =>
        {
            global::Lua.LuaValue _lastArg = default;
            global::System.Int32 _lastArgPos = default;
            global::System.Type _expectedType = default;
            var _argCount = _context.ArgumentCount;
            var _this = _context.GetArgument<LuaCommandBuffer>(0);
            var _arg0 = _lastArg = _argCount > 1 ? _context.GetArgument(1) : global::Lua.LuaValue.Nil;
            _lastArgPos = 0; _expectedType = typeof(global::Luny.UnityEngine.LuaRenderer);
            if (_arg0.TryRead<global::Luny.UnityEngine.LuaRenderer>(out var _p0_UnityEngine_Renderer))
            {
                var _arg1 = _lastArg = _argCount > 2 ? _context.GetArgument(2) : global::Lua.LuaValue.Nil;
                _lastArgPos = 1; _expectedType = typeof(global::Luny.UnityEngine.LuaMaterial);
                if (_arg1.TryRead<global::Luny.UnityEngine.LuaMaterial>(out var _p1_UnityEngine_Material))
                {
                    if (_argCount == 3)
                    {
                        var renderer = _p0_UnityEngine_Renderer.Instance;
                        var material = _p1_UnityEngine_Material.Instance;
                        _this.Instance.DrawRenderer(renderer, material);
                        var _retCount = _context.Return();
                        return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                    }
                    var _arg2 = _lastArg = _argCount > 3 ? _context.GetArgument(3) : global::Lua.LuaValue.Nil;
                    _lastArgPos = 2; _expectedType = typeof(global::System.Int32);
                    if (_arg2.TryRead<global::System.Int32>(out var _p2_System_Int32))
                    {
                        if (_argCount == 4)
                        {
                            var renderer = _p0_UnityEngine_Renderer.Instance;
                            var material = _p1_UnityEngine_Material.Instance;
                            var submeshIndex = _p2_System_Int32;
                            _this.Instance.DrawRenderer(renderer, material, submeshIndex);
                            var _retCount = _context.Return();
                            return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                        }
                        var _arg3 = _lastArg = _argCount > 4 ? _context.GetArgument(4) : global::Lua.LuaValue.Nil;
                        _lastArgPos = 3; _expectedType = typeof(global::System.Int32);
                        if (_arg3.TryRead<global::System.Int32>(out var _p3_System_Int32))
                        {
                            if (_argCount == 5)
                            {
                                var renderer = _p0_UnityEngine_Renderer.Instance;
                                var material = _p1_UnityEngine_Material.Instance;
                                var submeshIndex = _p2_System_Int32;
                                var shaderPass = _p3_System_Int32;
                                _this.Instance.DrawRenderer(renderer, material, submeshIndex, shaderPass);
                                var _retCount = _context.Return();
                                return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                            }
                        }
                    }
                }
            }
            throw new global::Lua.LuaRuntimeException(_context.Thread, $"{"DrawRenderer"}: invalid argument #{_lastArgPos}: {_lastArg} ({_lastArg.Type}), expected: {_expectedType.FullName}", 2);
        });
        private static readonly global::Lua.LuaFunction _LuaCommandBuffer_DrawRendererList = new global::Lua.LuaFunction("DrawRendererList", (_context, _) =>
        {
            global::Lua.LuaValue _lastArg = default;
            global::System.Int32 _lastArgPos = default;
            global::System.Type _expectedType = default;
            var _argCount = _context.ArgumentCount;
            var _this = _context.GetArgument<LuaCommandBuffer>(0);
            var _arg0 = _lastArg = _argCount > 1 ? _context.GetArgument(1) : global::Lua.LuaValue.Nil;
            _lastArgPos = 0; _expectedType = typeof(global::Luny.UnityEngine.Rendering.LuaRendererList);
            if (_arg0.TryRead<global::Luny.UnityEngine.Rendering.LuaRendererList>(out var _p0_UnityEngine_Rendering_RendererList))
            {
                if (_argCount == 2)
                {
                    var rendererList = _p0_UnityEngine_Rendering_RendererList.Value;
                    _this.Instance.DrawRendererList(rendererList);
                    var _retCount = _context.Return();
                    return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                }
            }
            throw new global::Lua.LuaRuntimeException(_context.Thread, $"{"DrawRendererList"}: invalid argument #{_lastArgPos}: {_lastArg} ({_lastArg.Type}), expected: {_expectedType.FullName}", 2);
        });
        private static readonly global::Lua.LuaFunction _LuaCommandBuffer_EnableScissorRect = new global::Lua.LuaFunction("EnableScissorRect", (_context, _) =>
        {
            global::Lua.LuaValue _lastArg = default;
            global::System.Int32 _lastArgPos = default;
            global::System.Type _expectedType = default;
            var _argCount = _context.ArgumentCount;
            var _this = _context.GetArgument<LuaCommandBuffer>(0);
            var _arg0 = _lastArg = _argCount > 1 ? _context.GetArgument(1) : global::Lua.LuaValue.Nil;
            _lastArgPos = 0; _expectedType = typeof(global::Luny.UnityEngine.LuaRect);
            if (_arg0.TryRead<global::Luny.UnityEngine.LuaRect>(out var _p0_UnityEngine_Rect))
            {
                if (_argCount == 2)
                {
                    var scissor = _p0_UnityEngine_Rect.Value;
                    _this.Instance.EnableScissorRect(scissor);
                    var _retCount = _context.Return();
                    return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                }
            }
            throw new global::Lua.LuaRuntimeException(_context.Thread, $"{"EnableScissorRect"}: invalid argument #{_lastArgPos}: {_lastArg} ({_lastArg.Type}), expected: {_expectedType.FullName}", 2);
        });
        private static readonly global::Lua.LuaFunction _LuaCommandBuffer_EnableShaderKeyword = new global::Lua.LuaFunction("EnableShaderKeyword", (_context, _) =>
        {
            global::Lua.LuaValue _lastArg = default;
            global::System.Int32 _lastArgPos = default;
            global::System.Type _expectedType = default;
            var _argCount = _context.ArgumentCount;
            var _this = _context.GetArgument<LuaCommandBuffer>(0);
            var _arg0 = _lastArg = _argCount > 1 ? _context.GetArgument(1) : global::Lua.LuaValue.Nil;
            _lastArgPos = 0; _expectedType = typeof(global::System.String);
            if (_arg0.TryRead<global::System.String>(out var _p0_System_String))
            {
                if (_argCount == 2)
                {
                    var keyword = _p0_System_String;
                    _this.Instance.EnableShaderKeyword(keyword);
                    var _retCount = _context.Return();
                    return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                }
            }
            throw new global::Lua.LuaRuntimeException(_context.Thread, $"{"EnableShaderKeyword"}: invalid argument #{_lastArgPos}: {_lastArg} ({_lastArg.Type}), expected: {_expectedType.FullName}", 2);
        });
        private static readonly global::Lua.LuaFunction _LuaCommandBuffer_EndRenderPass = new global::Lua.LuaFunction("EndRenderPass", (_context, _) =>
        {
            global::Lua.LuaValue _lastArg = default;
            global::System.Int32 _lastArgPos = default;
            global::System.Type _expectedType = default;
            var _argCount = _context.ArgumentCount;
            var _this = _context.GetArgument<LuaCommandBuffer>(0);
            if (_argCount == 1)
            {
                _this.Instance.EndRenderPass();
                var _retCount = _context.Return();
                return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
            }
            throw new global::Lua.LuaRuntimeException(_context.Thread, $"{"EndRenderPass"}: invalid argument #{_lastArgPos}: {_lastArg} ({_lastArg.Type}), expected: {_expectedType.FullName}", 2);
        });
        private static readonly global::Lua.LuaFunction _LuaCommandBuffer_EndSample = new global::Lua.LuaFunction("EndSample", (_context, _) =>
        {
            global::Lua.LuaValue _lastArg = default;
            global::System.Int32 _lastArgPos = default;
            global::System.Type _expectedType = default;
            var _argCount = _context.ArgumentCount;
            var _this = _context.GetArgument<LuaCommandBuffer>(0);
            var _arg0 = _lastArg = _argCount > 1 ? _context.GetArgument(1) : global::Lua.LuaValue.Nil;
            _lastArgPos = 0; _expectedType = typeof(global::Unity.Profiling.ProfilerMarker);
            if (_arg0.TryRead<global::Unity.Profiling.ProfilerMarker>(out var _p0_Unity_Profiling_ProfilerMarker))
            {
                if (_argCount == 2)
                {
                    var marker = _p0_Unity_Profiling_ProfilerMarker;
                    _this.Instance.EndSample(marker);
                    var _retCount = _context.Return();
                    return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                }
            }
            _lastArgPos = 0; _expectedType = typeof(global::System.String);
            if (_arg0.TryRead<global::System.String>(out var _p0_System_String))
            {
                if (_argCount == 2)
                {
                    var name = _p0_System_String;
                    _this.Instance.EndSample(name);
                    var _retCount = _context.Return();
                    return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                }
            }
            _lastArgPos = 0; _expectedType = typeof(global::Luny.UnityEngine.Profiling.LuaCustomSampler);
            if (_arg0.TryRead<global::Luny.UnityEngine.Profiling.LuaCustomSampler>(out var _p0_UnityEngine_Profiling_CustomSampler))
            {
                if (_argCount == 2)
                {
                    var sampler = _p0_UnityEngine_Profiling_CustomSampler.Instance;
                    _this.Instance.EndSample(sampler);
                    var _retCount = _context.Return();
                    return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                }
            }
            throw new global::Lua.LuaRuntimeException(_context.Thread, $"{"EndSample"}: invalid argument #{_lastArgPos}: {_lastArg} ({_lastArg.Type}), expected: {_expectedType.FullName}", 2);
        });
        private static readonly global::Lua.LuaFunction _LuaCommandBuffer_GenerateMips = new global::Lua.LuaFunction("GenerateMips", (_context, _) =>
        {
            global::Lua.LuaValue _lastArg = default;
            global::System.Int32 _lastArgPos = default;
            global::System.Type _expectedType = default;
            var _argCount = _context.ArgumentCount;
            var _this = _context.GetArgument<LuaCommandBuffer>(0);
            var _arg0 = _lastArg = _argCount > 1 ? _context.GetArgument(1) : global::Lua.LuaValue.Nil;
            _lastArgPos = 0; _expectedType = typeof(global::Luny.UnityEngine.Rendering.LuaRenderTargetIdentifier);
            if (_arg0.TryRead<global::Luny.UnityEngine.Rendering.LuaRenderTargetIdentifier>(out var _p0_UnityEngine_Rendering_RenderTargetIdentifier))
            {
                if (_argCount == 2)
                {
                    var rt = _p0_UnityEngine_Rendering_RenderTargetIdentifier.Value;
                    _this.Instance.GenerateMips(rt);
                    var _retCount = _context.Return();
                    return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                }
            }
            _lastArgPos = 0; _expectedType = typeof(global::Luny.UnityEngine.LuaRenderTexture);
            if (_arg0.TryRead<global::Luny.UnityEngine.LuaRenderTexture>(out var _p0_UnityEngine_RenderTexture))
            {
                if (_argCount == 2)
                {
                    var rt = _p0_UnityEngine_RenderTexture.Instance;
                    _this.Instance.GenerateMips(rt);
                    var _retCount = _context.Return();
                    return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                }
            }
            throw new global::Lua.LuaRuntimeException(_context.Thread, $"{"GenerateMips"}: invalid argument #{_lastArgPos}: {_lastArg} ({_lastArg.Type}), expected: {_expectedType.FullName}", 2);
        });
        private static readonly global::Lua.LuaFunction _LuaCommandBuffer_GetTemporaryRT = new global::Lua.LuaFunction("GetTemporaryRT", (_context, _) =>
        {
            global::Lua.LuaValue _lastArg = default;
            global::System.Int32 _lastArgPos = default;
            global::System.Type _expectedType = default;
            var _argCount = _context.ArgumentCount;
            var _this = _context.GetArgument<LuaCommandBuffer>(0);
            var _arg0 = _lastArg = _argCount > 1 ? _context.GetArgument(1) : global::Lua.LuaValue.Nil;
            _lastArgPos = 0; _expectedType = typeof(global::System.Int32);
            if (_arg0.TryRead<global::System.Int32>(out var _p0_System_Int32))
            {
                var _arg1 = _lastArg = _argCount > 2 ? _context.GetArgument(2) : global::Lua.LuaValue.Nil;
                _lastArgPos = 1; _expectedType = typeof(global::Luny.UnityEngine.LuaRenderTextureDescriptor);
                if (_arg1.TryRead<global::Luny.UnityEngine.LuaRenderTextureDescriptor>(out var _p1_UnityEngine_RenderTextureDescriptor))
                {
                    if (_argCount == 3)
                    {
                        var nameID = _p0_System_Int32;
                        var desc = _p1_UnityEngine_RenderTextureDescriptor.Value;
                        _this.Instance.GetTemporaryRT(nameID, desc);
                        var _retCount = _context.Return();
                        return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                    }
                    var _arg2 = _lastArg = _argCount > 3 ? _context.GetArgument(3) : global::Lua.LuaValue.Nil;
                    _lastArgPos = 2; _expectedType = typeof(global::UnityEngine.FilterMode);
                    if (_arg2.TryRead<global::UnityEngine.FilterMode>(out var _p2_UnityEngine_FilterMode))
                    {
                        if (_argCount == 4)
                        {
                            var nameID = _p0_System_Int32;
                            var desc = _p1_UnityEngine_RenderTextureDescriptor.Value;
                            var filter = _p2_UnityEngine_FilterMode;
                            _this.Instance.GetTemporaryRT(nameID, desc, filter);
                            var _retCount = _context.Return();
                            return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                        }
                    }
                }
                _lastArgPos = 1; _expectedType = typeof(global::System.Int32);
                if (_arg1.TryRead<global::System.Int32>(out var _p1_System_Int32))
                {
                    var _arg2 = _lastArg = _argCount > 3 ? _context.GetArgument(3) : global::Lua.LuaValue.Nil;
                    _lastArgPos = 2; _expectedType = typeof(global::System.Int32);
                    if (_arg2.TryRead<global::System.Int32>(out var _p2_System_Int32))
                    {
                        if (_argCount == 4)
                        {
                            var nameID = _p0_System_Int32;
                            var width = _p1_System_Int32;
                            var height = _p2_System_Int32;
                            _this.Instance.GetTemporaryRT(nameID, width, height);
                            var _retCount = _context.Return();
                            return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                        }
                        var _arg3 = _lastArg = _argCount > 4 ? _context.GetArgument(4) : global::Lua.LuaValue.Nil;
                        _lastArgPos = 3; _expectedType = typeof(global::System.Int32);
                        if (_arg3.TryRead<global::System.Int32>(out var _p3_System_Int32))
                        {
                            if (_argCount == 5)
                            {
                                var nameID = _p0_System_Int32;
                                var width = _p1_System_Int32;
                                var height = _p2_System_Int32;
                                var depthBuffer = _p3_System_Int32;
                                _this.Instance.GetTemporaryRT(nameID, width, height, depthBuffer);
                                var _retCount = _context.Return();
                                return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                            }
                            var _arg4 = _lastArg = _argCount > 5 ? _context.GetArgument(5) : global::Lua.LuaValue.Nil;
                            _lastArgPos = 4; _expectedType = typeof(global::UnityEngine.FilterMode);
                            if (_arg4.TryRead<global::UnityEngine.FilterMode>(out var _p4_UnityEngine_FilterMode))
                            {
                                if (_argCount == 6)
                                {
                                    var nameID = _p0_System_Int32;
                                    var width = _p1_System_Int32;
                                    var height = _p2_System_Int32;
                                    var depthBuffer = _p3_System_Int32;
                                    var filter = _p4_UnityEngine_FilterMode;
                                    _this.Instance.GetTemporaryRT(nameID, width, height, depthBuffer, filter);
                                    var _retCount = _context.Return();
                                    return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                                }
                                var _arg5 = _lastArg = _argCount > 6 ? _context.GetArgument(6) : global::Lua.LuaValue.Nil;
                                _lastArgPos = 5; _expectedType = typeof(global::UnityEngine.Experimental.Rendering.GraphicsFormat);
                                if (_arg5.TryRead<global::UnityEngine.Experimental.Rendering.GraphicsFormat>(out var _p5_UnityEngine_Experimental_Rendering_GraphicsFormat))
                                {
                                    if (_argCount == 7)
                                    {
                                        var nameID = _p0_System_Int32;
                                        var width = _p1_System_Int32;
                                        var height = _p2_System_Int32;
                                        var depthBuffer = _p3_System_Int32;
                                        var filter = _p4_UnityEngine_FilterMode;
                                        var format = _p5_UnityEngine_Experimental_Rendering_GraphicsFormat;
                                        _this.Instance.GetTemporaryRT(nameID, width, height, depthBuffer, filter, format);
                                        var _retCount = _context.Return();
                                        return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                                    }
                                    var _arg6 = _lastArg = _argCount > 7 ? _context.GetArgument(7) : global::Lua.LuaValue.Nil;
                                    _lastArgPos = 6; _expectedType = typeof(global::System.Int32);
                                    if (_arg6.TryRead<global::System.Int32>(out var _p6_System_Int32))
                                    {
                                        if (_argCount == 8)
                                        {
                                            var nameID = _p0_System_Int32;
                                            var width = _p1_System_Int32;
                                            var height = _p2_System_Int32;
                                            var depthBuffer = _p3_System_Int32;
                                            var filter = _p4_UnityEngine_FilterMode;
                                            var format = _p5_UnityEngine_Experimental_Rendering_GraphicsFormat;
                                            var antiAliasing = _p6_System_Int32;
                                            _this.Instance.GetTemporaryRT(nameID, width, height, depthBuffer, filter, format, antiAliasing);
                                            var _retCount = _context.Return();
                                            return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                                        }
                                        var _arg7 = _lastArg = _argCount > 8 ? _context.GetArgument(8) : global::Lua.LuaValue.Nil;
                                        _lastArgPos = 7; _expectedType = typeof(global::System.Boolean);
                                        if (_arg7.TryRead<global::System.Boolean>(out var _p7_System_Boolean))
                                        {
                                            if (_argCount == 9)
                                            {
                                                var nameID = _p0_System_Int32;
                                                var width = _p1_System_Int32;
                                                var height = _p2_System_Int32;
                                                var depthBuffer = _p3_System_Int32;
                                                var filter = _p4_UnityEngine_FilterMode;
                                                var format = _p5_UnityEngine_Experimental_Rendering_GraphicsFormat;
                                                var antiAliasing = _p6_System_Int32;
                                                var enableRandomWrite = _p7_System_Boolean;
                                                _this.Instance.GetTemporaryRT(nameID, width, height, depthBuffer, filter, format, antiAliasing, enableRandomWrite);
                                                var _retCount = _context.Return();
                                                return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                                            }
                                            var _arg8 = _lastArg = _argCount > 9 ? _context.GetArgument(9) : global::Lua.LuaValue.Nil;
                                            _lastArgPos = 8; _expectedType = typeof(global::UnityEngine.RenderTextureMemoryless);
                                            if (_arg8.TryRead<global::UnityEngine.RenderTextureMemoryless>(out var _p8_UnityEngine_RenderTextureMemoryless))
                                            {
                                                if (_argCount == 10)
                                                {
                                                    var nameID = _p0_System_Int32;
                                                    var width = _p1_System_Int32;
                                                    var height = _p2_System_Int32;
                                                    var depthBuffer = _p3_System_Int32;
                                                    var filter = _p4_UnityEngine_FilterMode;
                                                    var format = _p5_UnityEngine_Experimental_Rendering_GraphicsFormat;
                                                    var antiAliasing = _p6_System_Int32;
                                                    var enableRandomWrite = _p7_System_Boolean;
                                                    var memorylessMode = _p8_UnityEngine_RenderTextureMemoryless;
                                                    _this.Instance.GetTemporaryRT(nameID, width, height, depthBuffer, filter, format, antiAliasing, enableRandomWrite, memorylessMode);
                                                    var _retCount = _context.Return();
                                                    return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                                                }
                                                var _arg9 = _lastArg = _argCount > 10 ? _context.GetArgument(10) : global::Lua.LuaValue.Nil;
                                                _lastArgPos = 9; _expectedType = typeof(global::System.Boolean);
                                                if (_arg9.TryRead<global::System.Boolean>(out var _p9_System_Boolean))
                                                {
                                                    if (_argCount == 11)
                                                    {
                                                        var nameID = _p0_System_Int32;
                                                        var width = _p1_System_Int32;
                                                        var height = _p2_System_Int32;
                                                        var depthBuffer = _p3_System_Int32;
                                                        var filter = _p4_UnityEngine_FilterMode;
                                                        var format = _p5_UnityEngine_Experimental_Rendering_GraphicsFormat;
                                                        var antiAliasing = _p6_System_Int32;
                                                        var enableRandomWrite = _p7_System_Boolean;
                                                        var memorylessMode = _p8_UnityEngine_RenderTextureMemoryless;
                                                        var useDynamicScale = _p9_System_Boolean;
                                                        _this.Instance.GetTemporaryRT(nameID, width, height, depthBuffer, filter, format, antiAliasing, enableRandomWrite, memorylessMode, useDynamicScale);
                                                        var _retCount = _context.Return();
                                                        return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                                                    }
                                                }
                                            }
                                        }
                                    }
                                }
                                _lastArgPos = 5; _expectedType = typeof(global::UnityEngine.RenderTextureFormat);
                                if (_arg5.TryRead<global::UnityEngine.RenderTextureFormat>(out var _p5_UnityEngine_RenderTextureFormat))
                                {
                                    if (_argCount == 7)
                                    {
                                        var nameID = _p0_System_Int32;
                                        var width = _p1_System_Int32;
                                        var height = _p2_System_Int32;
                                        var depthBuffer = _p3_System_Int32;
                                        var filter = _p4_UnityEngine_FilterMode;
                                        var format = _p5_UnityEngine_RenderTextureFormat;
                                        _this.Instance.GetTemporaryRT(nameID, width, height, depthBuffer, filter, format);
                                        var _retCount = _context.Return();
                                        return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                                    }
                                    var _arg6 = _lastArg = _argCount > 7 ? _context.GetArgument(7) : global::Lua.LuaValue.Nil;
                                    _lastArgPos = 6; _expectedType = typeof(global::UnityEngine.RenderTextureReadWrite);
                                    if (_arg6.TryRead<global::UnityEngine.RenderTextureReadWrite>(out var _p6_UnityEngine_RenderTextureReadWrite))
                                    {
                                        if (_argCount == 8)
                                        {
                                            var nameID = _p0_System_Int32;
                                            var width = _p1_System_Int32;
                                            var height = _p2_System_Int32;
                                            var depthBuffer = _p3_System_Int32;
                                            var filter = _p4_UnityEngine_FilterMode;
                                            var format = _p5_UnityEngine_RenderTextureFormat;
                                            var readWrite = _p6_UnityEngine_RenderTextureReadWrite;
                                            _this.Instance.GetTemporaryRT(nameID, width, height, depthBuffer, filter, format, readWrite);
                                            var _retCount = _context.Return();
                                            return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                                        }
                                        var _arg7 = _lastArg = _argCount > 8 ? _context.GetArgument(8) : global::Lua.LuaValue.Nil;
                                        _lastArgPos = 7; _expectedType = typeof(global::System.Int32);
                                        if (_arg7.TryRead<global::System.Int32>(out var _p7_System_Int32))
                                        {
                                            if (_argCount == 9)
                                            {
                                                var nameID = _p0_System_Int32;
                                                var width = _p1_System_Int32;
                                                var height = _p2_System_Int32;
                                                var depthBuffer = _p3_System_Int32;
                                                var filter = _p4_UnityEngine_FilterMode;
                                                var format = _p5_UnityEngine_RenderTextureFormat;
                                                var readWrite = _p6_UnityEngine_RenderTextureReadWrite;
                                                var antiAliasing = _p7_System_Int32;
                                                _this.Instance.GetTemporaryRT(nameID, width, height, depthBuffer, filter, format, readWrite, antiAliasing);
                                                var _retCount = _context.Return();
                                                return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                                            }
                                            var _arg8 = _lastArg = _argCount > 9 ? _context.GetArgument(9) : global::Lua.LuaValue.Nil;
                                            _lastArgPos = 8; _expectedType = typeof(global::System.Boolean);
                                            if (_arg8.TryRead<global::System.Boolean>(out var _p8_System_Boolean))
                                            {
                                                if (_argCount == 10)
                                                {
                                                    var nameID = _p0_System_Int32;
                                                    var width = _p1_System_Int32;
                                                    var height = _p2_System_Int32;
                                                    var depthBuffer = _p3_System_Int32;
                                                    var filter = _p4_UnityEngine_FilterMode;
                                                    var format = _p5_UnityEngine_RenderTextureFormat;
                                                    var readWrite = _p6_UnityEngine_RenderTextureReadWrite;
                                                    var antiAliasing = _p7_System_Int32;
                                                    var enableRandomWrite = _p8_System_Boolean;
                                                    _this.Instance.GetTemporaryRT(nameID, width, height, depthBuffer, filter, format, readWrite, antiAliasing, enableRandomWrite);
                                                    var _retCount = _context.Return();
                                                    return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                                                }
                                                var _arg9 = _lastArg = _argCount > 10 ? _context.GetArgument(10) : global::Lua.LuaValue.Nil;
                                                _lastArgPos = 9; _expectedType = typeof(global::UnityEngine.RenderTextureMemoryless);
                                                if (_arg9.TryRead<global::UnityEngine.RenderTextureMemoryless>(out var _p9_UnityEngine_RenderTextureMemoryless))
                                                {
                                                    if (_argCount == 11)
                                                    {
                                                        var nameID = _p0_System_Int32;
                                                        var width = _p1_System_Int32;
                                                        var height = _p2_System_Int32;
                                                        var depthBuffer = _p3_System_Int32;
                                                        var filter = _p4_UnityEngine_FilterMode;
                                                        var format = _p5_UnityEngine_RenderTextureFormat;
                                                        var readWrite = _p6_UnityEngine_RenderTextureReadWrite;
                                                        var antiAliasing = _p7_System_Int32;
                                                        var enableRandomWrite = _p8_System_Boolean;
                                                        var memorylessMode = _p9_UnityEngine_RenderTextureMemoryless;
                                                        _this.Instance.GetTemporaryRT(nameID, width, height, depthBuffer, filter, format, readWrite, antiAliasing, enableRandomWrite, memorylessMode);
                                                        var _retCount = _context.Return();
                                                        return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                                                    }
                                                    var _arg10 = _lastArg = _argCount > 11 ? _context.GetArgument(11) : global::Lua.LuaValue.Nil;
                                                    _lastArgPos = 10; _expectedType = typeof(global::System.Boolean);
                                                    if (_arg10.TryRead<global::System.Boolean>(out var _p10_System_Boolean))
                                                    {
                                                        if (_argCount == 12)
                                                        {
                                                            var nameID = _p0_System_Int32;
                                                            var width = _p1_System_Int32;
                                                            var height = _p2_System_Int32;
                                                            var depthBuffer = _p3_System_Int32;
                                                            var filter = _p4_UnityEngine_FilterMode;
                                                            var format = _p5_UnityEngine_RenderTextureFormat;
                                                            var readWrite = _p6_UnityEngine_RenderTextureReadWrite;
                                                            var antiAliasing = _p7_System_Int32;
                                                            var enableRandomWrite = _p8_System_Boolean;
                                                            var memorylessMode = _p9_UnityEngine_RenderTextureMemoryless;
                                                            var useDynamicScale = _p10_System_Boolean;
                                                            _this.Instance.GetTemporaryRT(nameID, width, height, depthBuffer, filter, format, readWrite, antiAliasing, enableRandomWrite, memorylessMode, useDynamicScale);
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
                    }
                }
            }
            throw new global::Lua.LuaRuntimeException(_context.Thread, $"{"GetTemporaryRT"}: invalid argument #{_lastArgPos}: {_lastArg} ({_lastArg.Type}), expected: {_expectedType.FullName}", 2);
        });
        private static readonly global::Lua.LuaFunction _LuaCommandBuffer_GetTemporaryRTArray = new global::Lua.LuaFunction("GetTemporaryRTArray", (_context, _) =>
        {
            global::Lua.LuaValue _lastArg = default;
            global::System.Int32 _lastArgPos = default;
            global::System.Type _expectedType = default;
            var _argCount = _context.ArgumentCount;
            var _this = _context.GetArgument<LuaCommandBuffer>(0);
            var _arg0 = _lastArg = _argCount > 1 ? _context.GetArgument(1) : global::Lua.LuaValue.Nil;
            _lastArgPos = 0; _expectedType = typeof(global::System.Int32);
            if (_arg0.TryRead<global::System.Int32>(out var _p0_System_Int32))
            {
                var _arg1 = _lastArg = _argCount > 2 ? _context.GetArgument(2) : global::Lua.LuaValue.Nil;
                _lastArgPos = 1; _expectedType = typeof(global::System.Int32);
                if (_arg1.TryRead<global::System.Int32>(out var _p1_System_Int32))
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
                                var nameID = _p0_System_Int32;
                                var width = _p1_System_Int32;
                                var height = _p2_System_Int32;
                                var slices = _p3_System_Int32;
                                _this.Instance.GetTemporaryRTArray(nameID, width, height, slices);
                                var _retCount = _context.Return();
                                return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                            }
                            var _arg4 = _lastArg = _argCount > 5 ? _context.GetArgument(5) : global::Lua.LuaValue.Nil;
                            _lastArgPos = 4; _expectedType = typeof(global::System.Int32);
                            if (_arg4.TryRead<global::System.Int32>(out var _p4_System_Int32))
                            {
                                if (_argCount == 6)
                                {
                                    var nameID = _p0_System_Int32;
                                    var width = _p1_System_Int32;
                                    var height = _p2_System_Int32;
                                    var slices = _p3_System_Int32;
                                    var depthBuffer = _p4_System_Int32;
                                    _this.Instance.GetTemporaryRTArray(nameID, width, height, slices, depthBuffer);
                                    var _retCount = _context.Return();
                                    return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                                }
                                var _arg5 = _lastArg = _argCount > 6 ? _context.GetArgument(6) : global::Lua.LuaValue.Nil;
                                _lastArgPos = 5; _expectedType = typeof(global::UnityEngine.FilterMode);
                                if (_arg5.TryRead<global::UnityEngine.FilterMode>(out var _p5_UnityEngine_FilterMode))
                                {
                                    if (_argCount == 7)
                                    {
                                        var nameID = _p0_System_Int32;
                                        var width = _p1_System_Int32;
                                        var height = _p2_System_Int32;
                                        var slices = _p3_System_Int32;
                                        var depthBuffer = _p4_System_Int32;
                                        var filter = _p5_UnityEngine_FilterMode;
                                        _this.Instance.GetTemporaryRTArray(nameID, width, height, slices, depthBuffer, filter);
                                        var _retCount = _context.Return();
                                        return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                                    }
                                    var _arg6 = _lastArg = _argCount > 7 ? _context.GetArgument(7) : global::Lua.LuaValue.Nil;
                                    _lastArgPos = 6; _expectedType = typeof(global::UnityEngine.Experimental.Rendering.GraphicsFormat);
                                    if (_arg6.TryRead<global::UnityEngine.Experimental.Rendering.GraphicsFormat>(out var _p6_UnityEngine_Experimental_Rendering_GraphicsFormat))
                                    {
                                        if (_argCount == 8)
                                        {
                                            var nameID = _p0_System_Int32;
                                            var width = _p1_System_Int32;
                                            var height = _p2_System_Int32;
                                            var slices = _p3_System_Int32;
                                            var depthBuffer = _p4_System_Int32;
                                            var filter = _p5_UnityEngine_FilterMode;
                                            var format = _p6_UnityEngine_Experimental_Rendering_GraphicsFormat;
                                            _this.Instance.GetTemporaryRTArray(nameID, width, height, slices, depthBuffer, filter, format);
                                            var _retCount = _context.Return();
                                            return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                                        }
                                        var _arg7 = _lastArg = _argCount > 8 ? _context.GetArgument(8) : global::Lua.LuaValue.Nil;
                                        _lastArgPos = 7; _expectedType = typeof(global::System.Int32);
                                        if (_arg7.TryRead<global::System.Int32>(out var _p7_System_Int32))
                                        {
                                            if (_argCount == 9)
                                            {
                                                var nameID = _p0_System_Int32;
                                                var width = _p1_System_Int32;
                                                var height = _p2_System_Int32;
                                                var slices = _p3_System_Int32;
                                                var depthBuffer = _p4_System_Int32;
                                                var filter = _p5_UnityEngine_FilterMode;
                                                var format = _p6_UnityEngine_Experimental_Rendering_GraphicsFormat;
                                                var antiAliasing = _p7_System_Int32;
                                                _this.Instance.GetTemporaryRTArray(nameID, width, height, slices, depthBuffer, filter, format, antiAliasing);
                                                var _retCount = _context.Return();
                                                return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                                            }
                                            var _arg8 = _lastArg = _argCount > 9 ? _context.GetArgument(9) : global::Lua.LuaValue.Nil;
                                            _lastArgPos = 8; _expectedType = typeof(global::System.Boolean);
                                            if (_arg8.TryRead<global::System.Boolean>(out var _p8_System_Boolean))
                                            {
                                                if (_argCount == 10)
                                                {
                                                    var nameID = _p0_System_Int32;
                                                    var width = _p1_System_Int32;
                                                    var height = _p2_System_Int32;
                                                    var slices = _p3_System_Int32;
                                                    var depthBuffer = _p4_System_Int32;
                                                    var filter = _p5_UnityEngine_FilterMode;
                                                    var format = _p6_UnityEngine_Experimental_Rendering_GraphicsFormat;
                                                    var antiAliasing = _p7_System_Int32;
                                                    var enableRandomWrite = _p8_System_Boolean;
                                                    _this.Instance.GetTemporaryRTArray(nameID, width, height, slices, depthBuffer, filter, format, antiAliasing, enableRandomWrite);
                                                    var _retCount = _context.Return();
                                                    return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                                                }
                                                var _arg9 = _lastArg = _argCount > 10 ? _context.GetArgument(10) : global::Lua.LuaValue.Nil;
                                                _lastArgPos = 9; _expectedType = typeof(global::System.Boolean);
                                                if (_arg9.TryRead<global::System.Boolean>(out var _p9_System_Boolean))
                                                {
                                                    if (_argCount == 11)
                                                    {
                                                        var nameID = _p0_System_Int32;
                                                        var width = _p1_System_Int32;
                                                        var height = _p2_System_Int32;
                                                        var slices = _p3_System_Int32;
                                                        var depthBuffer = _p4_System_Int32;
                                                        var filter = _p5_UnityEngine_FilterMode;
                                                        var format = _p6_UnityEngine_Experimental_Rendering_GraphicsFormat;
                                                        var antiAliasing = _p7_System_Int32;
                                                        var enableRandomWrite = _p8_System_Boolean;
                                                        var useDynamicScale = _p9_System_Boolean;
                                                        _this.Instance.GetTemporaryRTArray(nameID, width, height, slices, depthBuffer, filter, format, antiAliasing, enableRandomWrite, useDynamicScale);
                                                        var _retCount = _context.Return();
                                                        return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                                                    }
                                                }
                                            }
                                        }
                                    }
                                    _lastArgPos = 6; _expectedType = typeof(global::UnityEngine.RenderTextureFormat);
                                    if (_arg6.TryRead<global::UnityEngine.RenderTextureFormat>(out var _p6_UnityEngine_RenderTextureFormat))
                                    {
                                        if (_argCount == 8)
                                        {
                                            var nameID = _p0_System_Int32;
                                            var width = _p1_System_Int32;
                                            var height = _p2_System_Int32;
                                            var slices = _p3_System_Int32;
                                            var depthBuffer = _p4_System_Int32;
                                            var filter = _p5_UnityEngine_FilterMode;
                                            var format = _p6_UnityEngine_RenderTextureFormat;
                                            _this.Instance.GetTemporaryRTArray(nameID, width, height, slices, depthBuffer, filter, format);
                                            var _retCount = _context.Return();
                                            return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                                        }
                                        var _arg7 = _lastArg = _argCount > 8 ? _context.GetArgument(8) : global::Lua.LuaValue.Nil;
                                        _lastArgPos = 7; _expectedType = typeof(global::UnityEngine.RenderTextureReadWrite);
                                        if (_arg7.TryRead<global::UnityEngine.RenderTextureReadWrite>(out var _p7_UnityEngine_RenderTextureReadWrite))
                                        {
                                            if (_argCount == 9)
                                            {
                                                var nameID = _p0_System_Int32;
                                                var width = _p1_System_Int32;
                                                var height = _p2_System_Int32;
                                                var slices = _p3_System_Int32;
                                                var depthBuffer = _p4_System_Int32;
                                                var filter = _p5_UnityEngine_FilterMode;
                                                var format = _p6_UnityEngine_RenderTextureFormat;
                                                var readWrite = _p7_UnityEngine_RenderTextureReadWrite;
                                                _this.Instance.GetTemporaryRTArray(nameID, width, height, slices, depthBuffer, filter, format, readWrite);
                                                var _retCount = _context.Return();
                                                return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                                            }
                                            var _arg8 = _lastArg = _argCount > 9 ? _context.GetArgument(9) : global::Lua.LuaValue.Nil;
                                            _lastArgPos = 8; _expectedType = typeof(global::System.Int32);
                                            if (_arg8.TryRead<global::System.Int32>(out var _p8_System_Int32))
                                            {
                                                if (_argCount == 10)
                                                {
                                                    var nameID = _p0_System_Int32;
                                                    var width = _p1_System_Int32;
                                                    var height = _p2_System_Int32;
                                                    var slices = _p3_System_Int32;
                                                    var depthBuffer = _p4_System_Int32;
                                                    var filter = _p5_UnityEngine_FilterMode;
                                                    var format = _p6_UnityEngine_RenderTextureFormat;
                                                    var readWrite = _p7_UnityEngine_RenderTextureReadWrite;
                                                    var antiAliasing = _p8_System_Int32;
                                                    _this.Instance.GetTemporaryRTArray(nameID, width, height, slices, depthBuffer, filter, format, readWrite, antiAliasing);
                                                    var _retCount = _context.Return();
                                                    return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                                                }
                                                var _arg9 = _lastArg = _argCount > 10 ? _context.GetArgument(10) : global::Lua.LuaValue.Nil;
                                                _lastArgPos = 9; _expectedType = typeof(global::System.Boolean);
                                                if (_arg9.TryRead<global::System.Boolean>(out var _p9_System_Boolean))
                                                {
                                                    if (_argCount == 11)
                                                    {
                                                        var nameID = _p0_System_Int32;
                                                        var width = _p1_System_Int32;
                                                        var height = _p2_System_Int32;
                                                        var slices = _p3_System_Int32;
                                                        var depthBuffer = _p4_System_Int32;
                                                        var filter = _p5_UnityEngine_FilterMode;
                                                        var format = _p6_UnityEngine_RenderTextureFormat;
                                                        var readWrite = _p7_UnityEngine_RenderTextureReadWrite;
                                                        var antiAliasing = _p8_System_Int32;
                                                        var enableRandomWrite = _p9_System_Boolean;
                                                        _this.Instance.GetTemporaryRTArray(nameID, width, height, slices, depthBuffer, filter, format, readWrite, antiAliasing, enableRandomWrite);
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
                }
            }
            throw new global::Lua.LuaRuntimeException(_context.Thread, $"{"GetTemporaryRTArray"}: invalid argument #{_lastArgPos}: {_lastArg} ({_lastArg.Type}), expected: {_expectedType.FullName}", 2);
        });
        private static readonly global::Lua.LuaFunction _LuaCommandBuffer_IncrementUpdateCount = new global::Lua.LuaFunction("IncrementUpdateCount", (_context, _) =>
        {
            global::Lua.LuaValue _lastArg = default;
            global::System.Int32 _lastArgPos = default;
            global::System.Type _expectedType = default;
            var _argCount = _context.ArgumentCount;
            var _this = _context.GetArgument<LuaCommandBuffer>(0);
            var _arg0 = _lastArg = _argCount > 1 ? _context.GetArgument(1) : global::Lua.LuaValue.Nil;
            _lastArgPos = 0; _expectedType = typeof(global::Luny.UnityEngine.Rendering.LuaRenderTargetIdentifier);
            if (_arg0.TryRead<global::Luny.UnityEngine.Rendering.LuaRenderTargetIdentifier>(out var _p0_UnityEngine_Rendering_RenderTargetIdentifier))
            {
                if (_argCount == 2)
                {
                    var dest = _p0_UnityEngine_Rendering_RenderTargetIdentifier.Value;
                    _this.Instance.IncrementUpdateCount(dest);
                    var _retCount = _context.Return();
                    return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                }
            }
            throw new global::Lua.LuaRuntimeException(_context.Thread, $"{"IncrementUpdateCount"}: invalid argument #{_lastArgPos}: {_lastArg} ({_lastArg.Type}), expected: {_expectedType.FullName}", 2);
        });
        private static readonly global::Lua.LuaFunction _LuaCommandBuffer_InvokeOnRenderObjectCallbacks = new global::Lua.LuaFunction("InvokeOnRenderObjectCallbacks", (_context, _) =>
        {
            global::Lua.LuaValue _lastArg = default;
            global::System.Int32 _lastArgPos = default;
            global::System.Type _expectedType = default;
            var _argCount = _context.ArgumentCount;
            var _this = _context.GetArgument<LuaCommandBuffer>(0);
            if (_argCount == 1)
            {
                _this.Instance.InvokeOnRenderObjectCallbacks();
                var _retCount = _context.Return();
                return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
            }
            throw new global::Lua.LuaRuntimeException(_context.Thread, $"{"InvokeOnRenderObjectCallbacks"}: invalid argument #{_lastArgPos}: {_lastArg} ({_lastArg.Type}), expected: {_expectedType.FullName}", 2);
        });
        private static readonly global::Lua.LuaFunction _LuaCommandBuffer_MarkLateLatchMatrixShaderPropertyID = new global::Lua.LuaFunction("MarkLateLatchMatrixShaderPropertyID", (_context, _) =>
        {
            global::Lua.LuaValue _lastArg = default;
            global::System.Int32 _lastArgPos = default;
            global::System.Type _expectedType = default;
            var _argCount = _context.ArgumentCount;
            var _this = _context.GetArgument<LuaCommandBuffer>(0);
            var _arg0 = _lastArg = _argCount > 1 ? _context.GetArgument(1) : global::Lua.LuaValue.Nil;
            _lastArgPos = 0; _expectedType = typeof(global::UnityEngine.Rendering.CameraLateLatchMatrixType);
            if (_arg0.TryRead<global::UnityEngine.Rendering.CameraLateLatchMatrixType>(out var _p0_UnityEngine_Rendering_CameraLateLatchMatrixType))
            {
                var _arg1 = _lastArg = _argCount > 2 ? _context.GetArgument(2) : global::Lua.LuaValue.Nil;
                _lastArgPos = 1; _expectedType = typeof(global::System.Int32);
                if (_arg1.TryRead<global::System.Int32>(out var _p1_System_Int32))
                {
                    if (_argCount == 3)
                    {
                        var matrixPropertyType = _p0_UnityEngine_Rendering_CameraLateLatchMatrixType;
                        var shaderPropertyID = _p1_System_Int32;
                        _this.Instance.MarkLateLatchMatrixShaderPropertyID(matrixPropertyType, shaderPropertyID);
                        var _retCount = _context.Return();
                        return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                    }
                }
            }
            throw new global::Lua.LuaRuntimeException(_context.Thread, $"{"MarkLateLatchMatrixShaderPropertyID"}: invalid argument #{_lastArgPos}: {_lastArg} ({_lastArg.Type}), expected: {_expectedType.FullName}", 2);
        });
        private static readonly global::Lua.LuaFunction _LuaCommandBuffer_NextSubPass = new global::Lua.LuaFunction("NextSubPass", (_context, _) =>
        {
            global::Lua.LuaValue _lastArg = default;
            global::System.Int32 _lastArgPos = default;
            global::System.Type _expectedType = default;
            var _argCount = _context.ArgumentCount;
            var _this = _context.GetArgument<LuaCommandBuffer>(0);
            if (_argCount == 1)
            {
                _this.Instance.NextSubPass();
                var _retCount = _context.Return();
                return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
            }
            throw new global::Lua.LuaRuntimeException(_context.Thread, $"{"NextSubPass"}: invalid argument #{_lastArgPos}: {_lastArg} ({_lastArg.Type}), expected: {_expectedType.FullName}", 2);
        });
        private static readonly global::Lua.LuaFunction _LuaCommandBuffer_Release = new global::Lua.LuaFunction("Release", (_context, _) =>
        {
            global::Lua.LuaValue _lastArg = default;
            global::System.Int32 _lastArgPos = default;
            global::System.Type _expectedType = default;
            var _argCount = _context.ArgumentCount;
            var _this = _context.GetArgument<LuaCommandBuffer>(0);
            if (_argCount == 1)
            {
                _this.Instance.Release();
                var _retCount = _context.Return();
                return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
            }
            throw new global::Lua.LuaRuntimeException(_context.Thread, $"{"Release"}: invalid argument #{_lastArgPos}: {_lastArg} ({_lastArg.Type}), expected: {_expectedType.FullName}", 2);
        });
        private static readonly global::Lua.LuaFunction _LuaCommandBuffer_ReleaseTemporaryRT = new global::Lua.LuaFunction("ReleaseTemporaryRT", (_context, _) =>
        {
            global::Lua.LuaValue _lastArg = default;
            global::System.Int32 _lastArgPos = default;
            global::System.Type _expectedType = default;
            var _argCount = _context.ArgumentCount;
            var _this = _context.GetArgument<LuaCommandBuffer>(0);
            var _arg0 = _lastArg = _argCount > 1 ? _context.GetArgument(1) : global::Lua.LuaValue.Nil;
            _lastArgPos = 0; _expectedType = typeof(global::System.Int32);
            if (_arg0.TryRead<global::System.Int32>(out var _p0_System_Int32))
            {
                if (_argCount == 2)
                {
                    var nameID = _p0_System_Int32;
                    _this.Instance.ReleaseTemporaryRT(nameID);
                    var _retCount = _context.Return();
                    return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                }
            }
            throw new global::Lua.LuaRuntimeException(_context.Thread, $"{"ReleaseTemporaryRT"}: invalid argument #{_lastArgPos}: {_lastArg} ({_lastArg.Type}), expected: {_expectedType.FullName}", 2);
        });
        private static readonly global::Lua.LuaFunction _LuaCommandBuffer_ResetShadingRate = new global::Lua.LuaFunction("ResetShadingRate", (_context, _) =>
        {
            global::Lua.LuaValue _lastArg = default;
            global::System.Int32 _lastArgPos = default;
            global::System.Type _expectedType = default;
            var _argCount = _context.ArgumentCount;
            var _this = _context.GetArgument<LuaCommandBuffer>(0);
            if (_argCount == 1)
            {
                _this.Instance.ResetShadingRate();
                var _retCount = _context.Return();
                return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
            }
            throw new global::Lua.LuaRuntimeException(_context.Thread, $"{"ResetShadingRate"}: invalid argument #{_lastArgPos}: {_lastArg} ({_lastArg.Type}), expected: {_expectedType.FullName}", 2);
        });
        private static readonly global::Lua.LuaFunction _LuaCommandBuffer_ResolveAntiAliasedSurface = new global::Lua.LuaFunction("ResolveAntiAliasedSurface", (_context, _) =>
        {
            global::Lua.LuaValue _lastArg = default;
            global::System.Int32 _lastArgPos = default;
            global::System.Type _expectedType = default;
            var _argCount = _context.ArgumentCount;
            var _this = _context.GetArgument<LuaCommandBuffer>(0);
            var _arg0 = _lastArg = _argCount > 1 ? _context.GetArgument(1) : global::Lua.LuaValue.Nil;
            _lastArgPos = 0; _expectedType = typeof(global::Luny.UnityEngine.LuaRenderTexture);
            if (_arg0.TryRead<global::Luny.UnityEngine.LuaRenderTexture>(out var _p0_UnityEngine_RenderTexture))
            {
                if (_argCount == 2)
                {
                    var rt = _p0_UnityEngine_RenderTexture.Instance;
                    _this.Instance.ResolveAntiAliasedSurface(rt);
                    var _retCount = _context.Return();
                    return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                }
                var _arg1 = _lastArg = _argCount > 2 ? _context.GetArgument(2) : global::Lua.LuaValue.Nil;
                _lastArgPos = 1; _expectedType = typeof(global::Luny.UnityEngine.LuaRenderTexture);
                var _p1_UnityEngine_RenderTexture = _arg1.ReadValue<global::Luny.UnityEngine.LuaRenderTexture>(default);
                {
                    if (_argCount == 3)
                    {
                        var rt = _p0_UnityEngine_RenderTexture.Instance;
                        var target = _p1_UnityEngine_RenderTexture.Instance;
                        _this.Instance.ResolveAntiAliasedSurface(rt, target);
                        var _retCount = _context.Return();
                        return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                    }
                }
            }
            throw new global::Lua.LuaRuntimeException(_context.Thread, $"{"ResolveAntiAliasedSurface"}: invalid argument #{_lastArgPos}: {_lastArg} ({_lastArg.Type}), expected: {_expectedType.FullName}", 2);
        });
        private static readonly global::Lua.LuaFunction _LuaCommandBuffer_SetBufferCounterValue = new global::Lua.LuaFunction("SetBufferCounterValue", (_context, _) =>
        {
            global::Lua.LuaValue _lastArg = default;
            global::System.Int32 _lastArgPos = default;
            global::System.Type _expectedType = default;
            var _argCount = _context.ArgumentCount;
            var _this = _context.GetArgument<LuaCommandBuffer>(0);
            var _arg0 = _lastArg = _argCount > 1 ? _context.GetArgument(1) : global::Lua.LuaValue.Nil;
            _lastArgPos = 0; _expectedType = typeof(global::Luny.UnityEngine.LuaComputeBuffer);
            if (_arg0.TryRead<global::Luny.UnityEngine.LuaComputeBuffer>(out var _p0_UnityEngine_ComputeBuffer))
            {
                var _arg1 = _lastArg = _argCount > 2 ? _context.GetArgument(2) : global::Lua.LuaValue.Nil;
                _lastArgPos = 1; _expectedType = typeof(global::System.UInt32);
                if (_arg1.TryRead<global::System.UInt32>(out var _p1_System_UInt32))
                {
                    if (_argCount == 3)
                    {
                        var buffer = _p0_UnityEngine_ComputeBuffer.Instance;
                        var counterValue = _p1_System_UInt32;
                        _this.Instance.SetBufferCounterValue(buffer, counterValue);
                        var _retCount = _context.Return();
                        return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                    }
                }
            }
            _lastArgPos = 0; _expectedType = typeof(global::Luny.UnityEngine.LuaGraphicsBuffer);
            if (_arg0.TryRead<global::Luny.UnityEngine.LuaGraphicsBuffer>(out var _p0_UnityEngine_GraphicsBuffer))
            {
                var _arg1 = _lastArg = _argCount > 2 ? _context.GetArgument(2) : global::Lua.LuaValue.Nil;
                _lastArgPos = 1; _expectedType = typeof(global::System.UInt32);
                if (_arg1.TryRead<global::System.UInt32>(out var _p1_System_UInt32))
                {
                    if (_argCount == 3)
                    {
                        var buffer = _p0_UnityEngine_GraphicsBuffer.Instance;
                        var counterValue = _p1_System_UInt32;
                        _this.Instance.SetBufferCounterValue(buffer, counterValue);
                        var _retCount = _context.Return();
                        return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                    }
                }
            }
            throw new global::Lua.LuaRuntimeException(_context.Thread, $"{"SetBufferCounterValue"}: invalid argument #{_lastArgPos}: {_lastArg} ({_lastArg.Type}), expected: {_expectedType.FullName}", 2);
        });
        private static readonly global::Lua.LuaFunction _LuaCommandBuffer_SetComputeBufferParam = new global::Lua.LuaFunction("SetComputeBufferParam", (_context, _) =>
        {
            global::Lua.LuaValue _lastArg = default;
            global::System.Int32 _lastArgPos = default;
            global::System.Type _expectedType = default;
            var _argCount = _context.ArgumentCount;
            var _this = _context.GetArgument<LuaCommandBuffer>(0);
            var _arg0 = _lastArg = _argCount > 1 ? _context.GetArgument(1) : global::Lua.LuaValue.Nil;
            _lastArgPos = 0; _expectedType = typeof(global::Luny.UnityEngine.LuaComputeShader);
            if (_arg0.TryRead<global::Luny.UnityEngine.LuaComputeShader>(out var _p0_UnityEngine_ComputeShader))
            {
                var _arg1 = _lastArg = _argCount > 2 ? _context.GetArgument(2) : global::Lua.LuaValue.Nil;
                _lastArgPos = 1; _expectedType = typeof(global::System.Int32);
                if (_arg1.TryRead<global::System.Int32>(out var _p1_System_Int32))
                {
                    var _arg2 = _lastArg = _argCount > 3 ? _context.GetArgument(3) : global::Lua.LuaValue.Nil;
                    _lastArgPos = 2; _expectedType = typeof(global::System.Int32);
                    if (_arg2.TryRead<global::System.Int32>(out var _p2_System_Int32))
                    {
                        var _arg3 = _lastArg = _argCount > 4 ? _context.GetArgument(4) : global::Lua.LuaValue.Nil;
                        _lastArgPos = 3; _expectedType = typeof(global::Luny.UnityEngine.LuaGraphicsBufferHandle);
                        if (_arg3.TryRead<global::Luny.UnityEngine.LuaGraphicsBufferHandle>(out var _p3_UnityEngine_GraphicsBufferHandle))
                        {
                            if (_argCount == 5)
                            {
                                var computeShader = _p0_UnityEngine_ComputeShader.Instance;
                                var kernelIndex = _p1_System_Int32;
                                var nameID = _p2_System_Int32;
                                var bufferHandle = _p3_UnityEngine_GraphicsBufferHandle.Value;
                                _this.Instance.SetComputeBufferParam(computeShader, kernelIndex, nameID, bufferHandle);
                                var _retCount = _context.Return();
                                return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                            }
                        }
                        _lastArgPos = 3; _expectedType = typeof(global::Luny.UnityEngine.LuaComputeBuffer);
                        if (_arg3.TryRead<global::Luny.UnityEngine.LuaComputeBuffer>(out var _p3_UnityEngine_ComputeBuffer))
                        {
                            if (_argCount == 5)
                            {
                                var computeShader = _p0_UnityEngine_ComputeShader.Instance;
                                var kernelIndex = _p1_System_Int32;
                                var nameID = _p2_System_Int32;
                                var buffer = _p3_UnityEngine_ComputeBuffer.Instance;
                                _this.Instance.SetComputeBufferParam(computeShader, kernelIndex, nameID, buffer);
                                var _retCount = _context.Return();
                                return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                            }
                        }
                        _lastArgPos = 3; _expectedType = typeof(global::Luny.UnityEngine.LuaGraphicsBuffer);
                        if (_arg3.TryRead<global::Luny.UnityEngine.LuaGraphicsBuffer>(out var _p3_UnityEngine_GraphicsBuffer))
                        {
                            if (_argCount == 5)
                            {
                                var computeShader = _p0_UnityEngine_ComputeShader.Instance;
                                var kernelIndex = _p1_System_Int32;
                                var nameID = _p2_System_Int32;
                                var buffer = _p3_UnityEngine_GraphicsBuffer.Instance;
                                _this.Instance.SetComputeBufferParam(computeShader, kernelIndex, nameID, buffer);
                                var _retCount = _context.Return();
                                return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                            }
                        }
                    }
                    _lastArgPos = 2; _expectedType = typeof(global::System.String);
                    if (_arg2.TryRead<global::System.String>(out var _p2_System_String))
                    {
                        var _arg3 = _lastArg = _argCount > 4 ? _context.GetArgument(4) : global::Lua.LuaValue.Nil;
                        _lastArgPos = 3; _expectedType = typeof(global::Luny.UnityEngine.LuaGraphicsBufferHandle);
                        if (_arg3.TryRead<global::Luny.UnityEngine.LuaGraphicsBufferHandle>(out var _p3_UnityEngine_GraphicsBufferHandle))
                        {
                            if (_argCount == 5)
                            {
                                var computeShader = _p0_UnityEngine_ComputeShader.Instance;
                                var kernelIndex = _p1_System_Int32;
                                var name = _p2_System_String;
                                var bufferHandle = _p3_UnityEngine_GraphicsBufferHandle.Value;
                                _this.Instance.SetComputeBufferParam(computeShader, kernelIndex, name, bufferHandle);
                                var _retCount = _context.Return();
                                return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                            }
                        }
                        _lastArgPos = 3; _expectedType = typeof(global::Luny.UnityEngine.LuaComputeBuffer);
                        if (_arg3.TryRead<global::Luny.UnityEngine.LuaComputeBuffer>(out var _p3_UnityEngine_ComputeBuffer))
                        {
                            if (_argCount == 5)
                            {
                                var computeShader = _p0_UnityEngine_ComputeShader.Instance;
                                var kernelIndex = _p1_System_Int32;
                                var name = _p2_System_String;
                                var buffer = _p3_UnityEngine_ComputeBuffer.Instance;
                                _this.Instance.SetComputeBufferParam(computeShader, kernelIndex, name, buffer);
                                var _retCount = _context.Return();
                                return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                            }
                        }
                        _lastArgPos = 3; _expectedType = typeof(global::Luny.UnityEngine.LuaGraphicsBuffer);
                        if (_arg3.TryRead<global::Luny.UnityEngine.LuaGraphicsBuffer>(out var _p3_UnityEngine_GraphicsBuffer))
                        {
                            if (_argCount == 5)
                            {
                                var computeShader = _p0_UnityEngine_ComputeShader.Instance;
                                var kernelIndex = _p1_System_Int32;
                                var name = _p2_System_String;
                                var buffer = _p3_UnityEngine_GraphicsBuffer.Instance;
                                _this.Instance.SetComputeBufferParam(computeShader, kernelIndex, name, buffer);
                                var _retCount = _context.Return();
                                return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                            }
                        }
                    }
                }
            }
            throw new global::Lua.LuaRuntimeException(_context.Thread, $"{"SetComputeBufferParam"}: invalid argument #{_lastArgPos}: {_lastArg} ({_lastArg.Type}), expected: {_expectedType.FullName}", 2);
        });
        private static readonly global::Lua.LuaFunction _LuaCommandBuffer_SetComputeConstantBufferParam = new global::Lua.LuaFunction("SetComputeConstantBufferParam", (_context, _) =>
        {
            global::Lua.LuaValue _lastArg = default;
            global::System.Int32 _lastArgPos = default;
            global::System.Type _expectedType = default;
            var _argCount = _context.ArgumentCount;
            var _this = _context.GetArgument<LuaCommandBuffer>(0);
            var _arg0 = _lastArg = _argCount > 1 ? _context.GetArgument(1) : global::Lua.LuaValue.Nil;
            _lastArgPos = 0; _expectedType = typeof(global::Luny.UnityEngine.LuaComputeShader);
            if (_arg0.TryRead<global::Luny.UnityEngine.LuaComputeShader>(out var _p0_UnityEngine_ComputeShader))
            {
                var _arg1 = _lastArg = _argCount > 2 ? _context.GetArgument(2) : global::Lua.LuaValue.Nil;
                _lastArgPos = 1; _expectedType = typeof(global::System.Int32);
                if (_arg1.TryRead<global::System.Int32>(out var _p1_System_Int32))
                {
                    var _arg2 = _lastArg = _argCount > 3 ? _context.GetArgument(3) : global::Lua.LuaValue.Nil;
                    _lastArgPos = 2; _expectedType = typeof(global::Luny.UnityEngine.LuaComputeBuffer);
                    if (_arg2.TryRead<global::Luny.UnityEngine.LuaComputeBuffer>(out var _p2_UnityEngine_ComputeBuffer))
                    {
                        var _arg3 = _lastArg = _argCount > 4 ? _context.GetArgument(4) : global::Lua.LuaValue.Nil;
                        _lastArgPos = 3; _expectedType = typeof(global::System.Int32);
                        if (_arg3.TryRead<global::System.Int32>(out var _p3_System_Int32))
                        {
                            var _arg4 = _lastArg = _argCount > 5 ? _context.GetArgument(5) : global::Lua.LuaValue.Nil;
                            _lastArgPos = 4; _expectedType = typeof(global::System.Int32);
                            if (_arg4.TryRead<global::System.Int32>(out var _p4_System_Int32))
                            {
                                if (_argCount == 6)
                                {
                                    var computeShader = _p0_UnityEngine_ComputeShader.Instance;
                                    var nameID = _p1_System_Int32;
                                    var buffer = _p2_UnityEngine_ComputeBuffer.Instance;
                                    var offset = _p3_System_Int32;
                                    var size = _p4_System_Int32;
                                    _this.Instance.SetComputeConstantBufferParam(computeShader, nameID, buffer, offset, size);
                                    var _retCount = _context.Return();
                                    return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                                }
                            }
                        }
                    }
                    _lastArgPos = 2; _expectedType = typeof(global::Luny.UnityEngine.LuaGraphicsBuffer);
                    if (_arg2.TryRead<global::Luny.UnityEngine.LuaGraphicsBuffer>(out var _p2_UnityEngine_GraphicsBuffer))
                    {
                        var _arg3 = _lastArg = _argCount > 4 ? _context.GetArgument(4) : global::Lua.LuaValue.Nil;
                        _lastArgPos = 3; _expectedType = typeof(global::System.Int32);
                        if (_arg3.TryRead<global::System.Int32>(out var _p3_System_Int32))
                        {
                            var _arg4 = _lastArg = _argCount > 5 ? _context.GetArgument(5) : global::Lua.LuaValue.Nil;
                            _lastArgPos = 4; _expectedType = typeof(global::System.Int32);
                            if (_arg4.TryRead<global::System.Int32>(out var _p4_System_Int32))
                            {
                                if (_argCount == 6)
                                {
                                    var computeShader = _p0_UnityEngine_ComputeShader.Instance;
                                    var nameID = _p1_System_Int32;
                                    var buffer = _p2_UnityEngine_GraphicsBuffer.Instance;
                                    var offset = _p3_System_Int32;
                                    var size = _p4_System_Int32;
                                    _this.Instance.SetComputeConstantBufferParam(computeShader, nameID, buffer, offset, size);
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
                    var _arg2 = _lastArg = _argCount > 3 ? _context.GetArgument(3) : global::Lua.LuaValue.Nil;
                    _lastArgPos = 2; _expectedType = typeof(global::Luny.UnityEngine.LuaComputeBuffer);
                    if (_arg2.TryRead<global::Luny.UnityEngine.LuaComputeBuffer>(out var _p2_UnityEngine_ComputeBuffer))
                    {
                        var _arg3 = _lastArg = _argCount > 4 ? _context.GetArgument(4) : global::Lua.LuaValue.Nil;
                        _lastArgPos = 3; _expectedType = typeof(global::System.Int32);
                        if (_arg3.TryRead<global::System.Int32>(out var _p3_System_Int32))
                        {
                            var _arg4 = _lastArg = _argCount > 5 ? _context.GetArgument(5) : global::Lua.LuaValue.Nil;
                            _lastArgPos = 4; _expectedType = typeof(global::System.Int32);
                            if (_arg4.TryRead<global::System.Int32>(out var _p4_System_Int32))
                            {
                                if (_argCount == 6)
                                {
                                    var computeShader = _p0_UnityEngine_ComputeShader.Instance;
                                    var name = _p1_System_String;
                                    var buffer = _p2_UnityEngine_ComputeBuffer.Instance;
                                    var offset = _p3_System_Int32;
                                    var size = _p4_System_Int32;
                                    _this.Instance.SetComputeConstantBufferParam(computeShader, name, buffer, offset, size);
                                    var _retCount = _context.Return();
                                    return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                                }
                            }
                        }
                    }
                    _lastArgPos = 2; _expectedType = typeof(global::Luny.UnityEngine.LuaGraphicsBuffer);
                    if (_arg2.TryRead<global::Luny.UnityEngine.LuaGraphicsBuffer>(out var _p2_UnityEngine_GraphicsBuffer))
                    {
                        var _arg3 = _lastArg = _argCount > 4 ? _context.GetArgument(4) : global::Lua.LuaValue.Nil;
                        _lastArgPos = 3; _expectedType = typeof(global::System.Int32);
                        if (_arg3.TryRead<global::System.Int32>(out var _p3_System_Int32))
                        {
                            var _arg4 = _lastArg = _argCount > 5 ? _context.GetArgument(5) : global::Lua.LuaValue.Nil;
                            _lastArgPos = 4; _expectedType = typeof(global::System.Int32);
                            if (_arg4.TryRead<global::System.Int32>(out var _p4_System_Int32))
                            {
                                if (_argCount == 6)
                                {
                                    var computeShader = _p0_UnityEngine_ComputeShader.Instance;
                                    var name = _p1_System_String;
                                    var buffer = _p2_UnityEngine_GraphicsBuffer.Instance;
                                    var offset = _p3_System_Int32;
                                    var size = _p4_System_Int32;
                                    _this.Instance.SetComputeConstantBufferParam(computeShader, name, buffer, offset, size);
                                    var _retCount = _context.Return();
                                    return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                                }
                            }
                        }
                    }
                }
            }
            throw new global::Lua.LuaRuntimeException(_context.Thread, $"{"SetComputeConstantBufferParam"}: invalid argument #{_lastArgPos}: {_lastArg} ({_lastArg.Type}), expected: {_expectedType.FullName}", 2);
        });
        private static readonly global::Lua.LuaFunction _LuaCommandBuffer_SetComputeFloatParam = new global::Lua.LuaFunction("SetComputeFloatParam", (_context, _) =>
        {
            global::Lua.LuaValue _lastArg = default;
            global::System.Int32 _lastArgPos = default;
            global::System.Type _expectedType = default;
            var _argCount = _context.ArgumentCount;
            var _this = _context.GetArgument<LuaCommandBuffer>(0);
            var _arg0 = _lastArg = _argCount > 1 ? _context.GetArgument(1) : global::Lua.LuaValue.Nil;
            _lastArgPos = 0; _expectedType = typeof(global::Luny.UnityEngine.LuaComputeShader);
            if (_arg0.TryRead<global::Luny.UnityEngine.LuaComputeShader>(out var _p0_UnityEngine_ComputeShader))
            {
                var _arg1 = _lastArg = _argCount > 2 ? _context.GetArgument(2) : global::Lua.LuaValue.Nil;
                _lastArgPos = 1; _expectedType = typeof(global::System.Int32);
                if (_arg1.TryRead<global::System.Int32>(out var _p1_System_Int32))
                {
                    var _arg2 = _lastArg = _argCount > 3 ? _context.GetArgument(3) : global::Lua.LuaValue.Nil;
                    _lastArgPos = 2; _expectedType = typeof(global::System.Single);
                    if (_arg2.TryRead<global::System.Single>(out var _p2_System_Single))
                    {
                        if (_argCount == 4)
                        {
                            var computeShader = _p0_UnityEngine_ComputeShader.Instance;
                            var nameID = _p1_System_Int32;
                            var val = _p2_System_Single;
                            _this.Instance.SetComputeFloatParam(computeShader, nameID, val);
                            var _retCount = _context.Return();
                            return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                        }
                    }
                }
                _lastArgPos = 1; _expectedType = typeof(global::System.String);
                if (_arg1.TryRead<global::System.String>(out var _p1_System_String))
                {
                    var _arg2 = _lastArg = _argCount > 3 ? _context.GetArgument(3) : global::Lua.LuaValue.Nil;
                    _lastArgPos = 2; _expectedType = typeof(global::System.Single);
                    if (_arg2.TryRead<global::System.Single>(out var _p2_System_Single))
                    {
                        if (_argCount == 4)
                        {
                            var computeShader = _p0_UnityEngine_ComputeShader.Instance;
                            var name = _p1_System_String;
                            var val = _p2_System_Single;
                            _this.Instance.SetComputeFloatParam(computeShader, name, val);
                            var _retCount = _context.Return();
                            return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                        }
                    }
                }
            }
            throw new global::Lua.LuaRuntimeException(_context.Thread, $"{"SetComputeFloatParam"}: invalid argument #{_lastArgPos}: {_lastArg} ({_lastArg.Type}), expected: {_expectedType.FullName}", 2);
        });
        private static readonly global::Lua.LuaFunction _LuaCommandBuffer_SetComputeFloatParams = new global::Lua.LuaFunction("SetComputeFloatParams", (_context, _) =>
        {
            global::Lua.LuaValue _lastArg = default;
            global::System.Int32 _lastArgPos = default;
            global::System.Type _expectedType = default;
            var _argCount = _context.ArgumentCount;
            var _this = _context.GetArgument<LuaCommandBuffer>(0);
            var _arg0 = _lastArg = _argCount > 1 ? _context.GetArgument(1) : global::Lua.LuaValue.Nil;
            _lastArgPos = 0; _expectedType = typeof(global::Luny.UnityEngine.LuaComputeShader);
            if (_arg0.TryRead<global::Luny.UnityEngine.LuaComputeShader>(out var _p0_UnityEngine_ComputeShader))
            {
                var _arg1 = _lastArg = _argCount > 2 ? _context.GetArgument(2) : global::Lua.LuaValue.Nil;
                _lastArgPos = 1; _expectedType = typeof(global::System.Int32);
                if (_arg1.TryRead<global::System.Int32>(out var _p1_System_Int32))
                {
                    var _arg2 = _lastArg = _argCount > 3 ? _context.GetArgument(3) : global::Lua.LuaValue.Nil;
                    _lastArgPos = 2; _expectedType = typeof(global::System.Single[]);
                    if (_arg2.TryReadArray<global::System.Single>(out var _p2_System_SingleArray))
                    {
                        if (_argCount == 4)
                        {
                            var computeShader = _p0_UnityEngine_ComputeShader.Instance;
                            var nameID = _p1_System_Int32;
                            var values = _p2_System_SingleArray;
                            _this.Instance.SetComputeFloatParams(computeShader, nameID, values);
                            var _retCount = _context.Return();
                            return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                        }
                    }
                }
                _lastArgPos = 1; _expectedType = typeof(global::System.String);
                if (_arg1.TryRead<global::System.String>(out var _p1_System_String))
                {
                    var _arg2 = _lastArg = _argCount > 3 ? _context.GetArgument(3) : global::Lua.LuaValue.Nil;
                    _lastArgPos = 2; _expectedType = typeof(global::System.Single[]);
                    if (_arg2.TryReadArray<global::System.Single>(out var _p2_System_SingleArray))
                    {
                        if (_argCount == 4)
                        {
                            var computeShader = _p0_UnityEngine_ComputeShader.Instance;
                            var name = _p1_System_String;
                            var values = _p2_System_SingleArray;
                            _this.Instance.SetComputeFloatParams(computeShader, name, values);
                            var _retCount = _context.Return();
                            return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                        }
                    }
                }
            }
            throw new global::Lua.LuaRuntimeException(_context.Thread, $"{"SetComputeFloatParams"}: invalid argument #{_lastArgPos}: {_lastArg} ({_lastArg.Type}), expected: {_expectedType.FullName}", 2);
        });
        private static readonly global::Lua.LuaFunction _LuaCommandBuffer_SetComputeIntParam = new global::Lua.LuaFunction("SetComputeIntParam", (_context, _) =>
        {
            global::Lua.LuaValue _lastArg = default;
            global::System.Int32 _lastArgPos = default;
            global::System.Type _expectedType = default;
            var _argCount = _context.ArgumentCount;
            var _this = _context.GetArgument<LuaCommandBuffer>(0);
            var _arg0 = _lastArg = _argCount > 1 ? _context.GetArgument(1) : global::Lua.LuaValue.Nil;
            _lastArgPos = 0; _expectedType = typeof(global::Luny.UnityEngine.LuaComputeShader);
            if (_arg0.TryRead<global::Luny.UnityEngine.LuaComputeShader>(out var _p0_UnityEngine_ComputeShader))
            {
                var _arg1 = _lastArg = _argCount > 2 ? _context.GetArgument(2) : global::Lua.LuaValue.Nil;
                _lastArgPos = 1; _expectedType = typeof(global::System.Int32);
                if (_arg1.TryRead<global::System.Int32>(out var _p1_System_Int32))
                {
                    var _arg2 = _lastArg = _argCount > 3 ? _context.GetArgument(3) : global::Lua.LuaValue.Nil;
                    _lastArgPos = 2; _expectedType = typeof(global::System.Int32);
                    if (_arg2.TryRead<global::System.Int32>(out var _p2_System_Int32))
                    {
                        if (_argCount == 4)
                        {
                            var computeShader = _p0_UnityEngine_ComputeShader.Instance;
                            var nameID = _p1_System_Int32;
                            var val = _p2_System_Int32;
                            _this.Instance.SetComputeIntParam(computeShader, nameID, val);
                            var _retCount = _context.Return();
                            return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                        }
                    }
                }
                _lastArgPos = 1; _expectedType = typeof(global::System.String);
                if (_arg1.TryRead<global::System.String>(out var _p1_System_String))
                {
                    var _arg2 = _lastArg = _argCount > 3 ? _context.GetArgument(3) : global::Lua.LuaValue.Nil;
                    _lastArgPos = 2; _expectedType = typeof(global::System.Int32);
                    if (_arg2.TryRead<global::System.Int32>(out var _p2_System_Int32))
                    {
                        if (_argCount == 4)
                        {
                            var computeShader = _p0_UnityEngine_ComputeShader.Instance;
                            var name = _p1_System_String;
                            var val = _p2_System_Int32;
                            _this.Instance.SetComputeIntParam(computeShader, name, val);
                            var _retCount = _context.Return();
                            return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                        }
                    }
                }
            }
            throw new global::Lua.LuaRuntimeException(_context.Thread, $"{"SetComputeIntParam"}: invalid argument #{_lastArgPos}: {_lastArg} ({_lastArg.Type}), expected: {_expectedType.FullName}", 2);
        });
        private static readonly global::Lua.LuaFunction _LuaCommandBuffer_SetComputeIntParams = new global::Lua.LuaFunction("SetComputeIntParams", (_context, _) =>
        {
            global::Lua.LuaValue _lastArg = default;
            global::System.Int32 _lastArgPos = default;
            global::System.Type _expectedType = default;
            var _argCount = _context.ArgumentCount;
            var _this = _context.GetArgument<LuaCommandBuffer>(0);
            var _arg0 = _lastArg = _argCount > 1 ? _context.GetArgument(1) : global::Lua.LuaValue.Nil;
            _lastArgPos = 0; _expectedType = typeof(global::Luny.UnityEngine.LuaComputeShader);
            if (_arg0.TryRead<global::Luny.UnityEngine.LuaComputeShader>(out var _p0_UnityEngine_ComputeShader))
            {
                var _arg1 = _lastArg = _argCount > 2 ? _context.GetArgument(2) : global::Lua.LuaValue.Nil;
                _lastArgPos = 1; _expectedType = typeof(global::System.Int32);
                if (_arg1.TryRead<global::System.Int32>(out var _p1_System_Int32))
                {
                    var _arg2 = _lastArg = _argCount > 3 ? _context.GetArgument(3) : global::Lua.LuaValue.Nil;
                    _lastArgPos = 2; _expectedType = typeof(global::System.Int32[]);
                    if (_arg2.TryReadArray<global::System.Int32>(out var _p2_System_Int32Array))
                    {
                        if (_argCount == 4)
                        {
                            var computeShader = _p0_UnityEngine_ComputeShader.Instance;
                            var nameID = _p1_System_Int32;
                            var values = _p2_System_Int32Array;
                            _this.Instance.SetComputeIntParams(computeShader, nameID, values);
                            var _retCount = _context.Return();
                            return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                        }
                    }
                }
                _lastArgPos = 1; _expectedType = typeof(global::System.String);
                if (_arg1.TryRead<global::System.String>(out var _p1_System_String))
                {
                    var _arg2 = _lastArg = _argCount > 3 ? _context.GetArgument(3) : global::Lua.LuaValue.Nil;
                    _lastArgPos = 2; _expectedType = typeof(global::System.Int32[]);
                    if (_arg2.TryReadArray<global::System.Int32>(out var _p2_System_Int32Array))
                    {
                        if (_argCount == 4)
                        {
                            var computeShader = _p0_UnityEngine_ComputeShader.Instance;
                            var name = _p1_System_String;
                            var values = _p2_System_Int32Array;
                            _this.Instance.SetComputeIntParams(computeShader, name, values);
                            var _retCount = _context.Return();
                            return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                        }
                    }
                }
            }
            throw new global::Lua.LuaRuntimeException(_context.Thread, $"{"SetComputeIntParams"}: invalid argument #{_lastArgPos}: {_lastArg} ({_lastArg.Type}), expected: {_expectedType.FullName}", 2);
        });
        private static readonly global::Lua.LuaFunction _LuaCommandBuffer_SetComputeMatrixArrayParam = new global::Lua.LuaFunction("SetComputeMatrixArrayParam", (_context, _) =>
        {
            global::Lua.LuaValue _lastArg = default;
            global::System.Int32 _lastArgPos = default;
            global::System.Type _expectedType = default;
            var _argCount = _context.ArgumentCount;
            var _this = _context.GetArgument<LuaCommandBuffer>(0);
            var _arg0 = _lastArg = _argCount > 1 ? _context.GetArgument(1) : global::Lua.LuaValue.Nil;
            _lastArgPos = 0; _expectedType = typeof(global::Luny.UnityEngine.LuaComputeShader);
            if (_arg0.TryRead<global::Luny.UnityEngine.LuaComputeShader>(out var _p0_UnityEngine_ComputeShader))
            {
                var _arg1 = _lastArg = _argCount > 2 ? _context.GetArgument(2) : global::Lua.LuaValue.Nil;
                _lastArgPos = 1; _expectedType = typeof(global::System.Int32);
                if (_arg1.TryRead<global::System.Int32>(out var _p1_System_Int32))
                {
                    var _arg2 = _lastArg = _argCount > 3 ? _context.GetArgument(3) : global::Lua.LuaValue.Nil;
                    _lastArgPos = 2; _expectedType = typeof(global::UnityEngine.Matrix4x4[]);
                    if (_arg2.TryReadArray<global::UnityEngine.Matrix4x4>(out var _p2_UnityEngine_Matrix4x4Array))
                    {
                        if (_argCount == 4)
                        {
                            var computeShader = _p0_UnityEngine_ComputeShader.Instance;
                            var nameID = _p1_System_Int32;
                            var values = _p2_UnityEngine_Matrix4x4Array;
                            _this.Instance.SetComputeMatrixArrayParam(computeShader, nameID, values);
                            var _retCount = _context.Return();
                            return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                        }
                    }
                }
                _lastArgPos = 1; _expectedType = typeof(global::System.String);
                if (_arg1.TryRead<global::System.String>(out var _p1_System_String))
                {
                    var _arg2 = _lastArg = _argCount > 3 ? _context.GetArgument(3) : global::Lua.LuaValue.Nil;
                    _lastArgPos = 2; _expectedType = typeof(global::UnityEngine.Matrix4x4[]);
                    if (_arg2.TryReadArray<global::UnityEngine.Matrix4x4>(out var _p2_UnityEngine_Matrix4x4Array))
                    {
                        if (_argCount == 4)
                        {
                            var computeShader = _p0_UnityEngine_ComputeShader.Instance;
                            var name = _p1_System_String;
                            var values = _p2_UnityEngine_Matrix4x4Array;
                            _this.Instance.SetComputeMatrixArrayParam(computeShader, name, values);
                            var _retCount = _context.Return();
                            return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                        }
                    }
                }
            }
            throw new global::Lua.LuaRuntimeException(_context.Thread, $"{"SetComputeMatrixArrayParam"}: invalid argument #{_lastArgPos}: {_lastArg} ({_lastArg.Type}), expected: {_expectedType.FullName}", 2);
        });
        private static readonly global::Lua.LuaFunction _LuaCommandBuffer_SetComputeMatrixParam = new global::Lua.LuaFunction("SetComputeMatrixParam", (_context, _) =>
        {
            global::Lua.LuaValue _lastArg = default;
            global::System.Int32 _lastArgPos = default;
            global::System.Type _expectedType = default;
            var _argCount = _context.ArgumentCount;
            var _this = _context.GetArgument<LuaCommandBuffer>(0);
            var _arg0 = _lastArg = _argCount > 1 ? _context.GetArgument(1) : global::Lua.LuaValue.Nil;
            _lastArgPos = 0; _expectedType = typeof(global::Luny.UnityEngine.LuaComputeShader);
            if (_arg0.TryRead<global::Luny.UnityEngine.LuaComputeShader>(out var _p0_UnityEngine_ComputeShader))
            {
                var _arg1 = _lastArg = _argCount > 2 ? _context.GetArgument(2) : global::Lua.LuaValue.Nil;
                _lastArgPos = 1; _expectedType = typeof(global::System.Int32);
                if (_arg1.TryRead<global::System.Int32>(out var _p1_System_Int32))
                {
                    var _arg2 = _lastArg = _argCount > 3 ? _context.GetArgument(3) : global::Lua.LuaValue.Nil;
                    _lastArgPos = 2; _expectedType = typeof(global::Luny.UnityEngine.LuaMatrix4x4);
                    if (_arg2.TryRead<global::Luny.UnityEngine.LuaMatrix4x4>(out var _p2_UnityEngine_Matrix4x4))
                    {
                        if (_argCount == 4)
                        {
                            var computeShader = _p0_UnityEngine_ComputeShader.Instance;
                            var nameID = _p1_System_Int32;
                            var val = _p2_UnityEngine_Matrix4x4.Value;
                            _this.Instance.SetComputeMatrixParam(computeShader, nameID, val);
                            var _retCount = _context.Return();
                            return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                        }
                    }
                }
                _lastArgPos = 1; _expectedType = typeof(global::System.String);
                if (_arg1.TryRead<global::System.String>(out var _p1_System_String))
                {
                    var _arg2 = _lastArg = _argCount > 3 ? _context.GetArgument(3) : global::Lua.LuaValue.Nil;
                    _lastArgPos = 2; _expectedType = typeof(global::Luny.UnityEngine.LuaMatrix4x4);
                    if (_arg2.TryRead<global::Luny.UnityEngine.LuaMatrix4x4>(out var _p2_UnityEngine_Matrix4x4))
                    {
                        if (_argCount == 4)
                        {
                            var computeShader = _p0_UnityEngine_ComputeShader.Instance;
                            var name = _p1_System_String;
                            var val = _p2_UnityEngine_Matrix4x4.Value;
                            _this.Instance.SetComputeMatrixParam(computeShader, name, val);
                            var _retCount = _context.Return();
                            return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                        }
                    }
                }
            }
            throw new global::Lua.LuaRuntimeException(_context.Thread, $"{"SetComputeMatrixParam"}: invalid argument #{_lastArgPos}: {_lastArg} ({_lastArg.Type}), expected: {_expectedType.FullName}", 2);
        });
        private static readonly global::Lua.LuaFunction _LuaCommandBuffer_SetComputeParamsFromMaterial = new global::Lua.LuaFunction("SetComputeParamsFromMaterial", (_context, _) =>
        {
            global::Lua.LuaValue _lastArg = default;
            global::System.Int32 _lastArgPos = default;
            global::System.Type _expectedType = default;
            var _argCount = _context.ArgumentCount;
            var _this = _context.GetArgument<LuaCommandBuffer>(0);
            var _arg0 = _lastArg = _argCount > 1 ? _context.GetArgument(1) : global::Lua.LuaValue.Nil;
            _lastArgPos = 0; _expectedType = typeof(global::Luny.UnityEngine.LuaComputeShader);
            if (_arg0.TryRead<global::Luny.UnityEngine.LuaComputeShader>(out var _p0_UnityEngine_ComputeShader))
            {
                var _arg1 = _lastArg = _argCount > 2 ? _context.GetArgument(2) : global::Lua.LuaValue.Nil;
                _lastArgPos = 1; _expectedType = typeof(global::System.Int32);
                if (_arg1.TryRead<global::System.Int32>(out var _p1_System_Int32))
                {
                    var _arg2 = _lastArg = _argCount > 3 ? _context.GetArgument(3) : global::Lua.LuaValue.Nil;
                    _lastArgPos = 2; _expectedType = typeof(global::Luny.UnityEngine.LuaMaterial);
                    if (_arg2.TryRead<global::Luny.UnityEngine.LuaMaterial>(out var _p2_UnityEngine_Material))
                    {
                        if (_argCount == 4)
                        {
                            var computeShader = _p0_UnityEngine_ComputeShader.Instance;
                            var kernelIndex = _p1_System_Int32;
                            var material = _p2_UnityEngine_Material.Instance;
                            _this.Instance.SetComputeParamsFromMaterial(computeShader, kernelIndex, material);
                            var _retCount = _context.Return();
                            return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                        }
                    }
                }
            }
            throw new global::Lua.LuaRuntimeException(_context.Thread, $"{"SetComputeParamsFromMaterial"}: invalid argument #{_lastArgPos}: {_lastArg} ({_lastArg.Type}), expected: {_expectedType.FullName}", 2);
        });
        private static readonly global::Lua.LuaFunction _LuaCommandBuffer_SetComputeTextureParam = new global::Lua.LuaFunction("SetComputeTextureParam", (_context, _) =>
        {
            global::Lua.LuaValue _lastArg = default;
            global::System.Int32 _lastArgPos = default;
            global::System.Type _expectedType = default;
            var _argCount = _context.ArgumentCount;
            var _this = _context.GetArgument<LuaCommandBuffer>(0);
            var _arg0 = _lastArg = _argCount > 1 ? _context.GetArgument(1) : global::Lua.LuaValue.Nil;
            _lastArgPos = 0; _expectedType = typeof(global::Luny.UnityEngine.LuaComputeShader);
            if (_arg0.TryRead<global::Luny.UnityEngine.LuaComputeShader>(out var _p0_UnityEngine_ComputeShader))
            {
                var _arg1 = _lastArg = _argCount > 2 ? _context.GetArgument(2) : global::Lua.LuaValue.Nil;
                _lastArgPos = 1; _expectedType = typeof(global::System.Int32);
                if (_arg1.TryRead<global::System.Int32>(out var _p1_System_Int32))
                {
                    var _arg2 = _lastArg = _argCount > 3 ? _context.GetArgument(3) : global::Lua.LuaValue.Nil;
                    _lastArgPos = 2; _expectedType = typeof(global::System.Int32);
                    if (_arg2.TryRead<global::System.Int32>(out var _p2_System_Int32))
                    {
                        var _arg3 = _lastArg = _argCount > 4 ? _context.GetArgument(4) : global::Lua.LuaValue.Nil;
                        _lastArgPos = 3; _expectedType = typeof(global::Luny.UnityEngine.Rendering.LuaRenderTargetIdentifier);
                        if (_arg3.TryRead<global::Luny.UnityEngine.Rendering.LuaRenderTargetIdentifier>(out var _p3_UnityEngine_Rendering_RenderTargetIdentifier))
                        {
                            if (_argCount == 5)
                            {
                                var computeShader = _p0_UnityEngine_ComputeShader.Instance;
                                var kernelIndex = _p1_System_Int32;
                                var nameID = _p2_System_Int32;
                                var rt = _p3_UnityEngine_Rendering_RenderTargetIdentifier.Value;
                                _this.Instance.SetComputeTextureParam(computeShader, kernelIndex, nameID, rt);
                                var _retCount = _context.Return();
                                return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                            }
                            var _arg4 = _lastArg = _argCount > 5 ? _context.GetArgument(5) : global::Lua.LuaValue.Nil;
                            _lastArgPos = 4; _expectedType = typeof(global::System.Int32);
                            if (_arg4.TryRead<global::System.Int32>(out var _p4_System_Int32))
                            {
                                if (_argCount == 6)
                                {
                                    var computeShader = _p0_UnityEngine_ComputeShader.Instance;
                                    var kernelIndex = _p1_System_Int32;
                                    var nameID = _p2_System_Int32;
                                    var rt = _p3_UnityEngine_Rendering_RenderTargetIdentifier.Value;
                                    var mipLevel = _p4_System_Int32;
                                    _this.Instance.SetComputeTextureParam(computeShader, kernelIndex, nameID, rt, mipLevel);
                                    var _retCount = _context.Return();
                                    return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                                }
                                var _arg5 = _lastArg = _argCount > 6 ? _context.GetArgument(6) : global::Lua.LuaValue.Nil;
                                _lastArgPos = 5; _expectedType = typeof(global::UnityEngine.Rendering.RenderTextureSubElement);
                                if (_arg5.TryRead<global::UnityEngine.Rendering.RenderTextureSubElement>(out var _p5_UnityEngine_Rendering_RenderTextureSubElement))
                                {
                                    if (_argCount == 7)
                                    {
                                        var computeShader = _p0_UnityEngine_ComputeShader.Instance;
                                        var kernelIndex = _p1_System_Int32;
                                        var nameID = _p2_System_Int32;
                                        var rt = _p3_UnityEngine_Rendering_RenderTargetIdentifier.Value;
                                        var mipLevel = _p4_System_Int32;
                                        var element = _p5_UnityEngine_Rendering_RenderTextureSubElement;
                                        _this.Instance.SetComputeTextureParam(computeShader, kernelIndex, nameID, rt, mipLevel, element);
                                        var _retCount = _context.Return();
                                        return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                                    }
                                }
                            }
                        }
                    }
                    _lastArgPos = 2; _expectedType = typeof(global::System.String);
                    if (_arg2.TryRead<global::System.String>(out var _p2_System_String))
                    {
                        var _arg3 = _lastArg = _argCount > 4 ? _context.GetArgument(4) : global::Lua.LuaValue.Nil;
                        _lastArgPos = 3; _expectedType = typeof(global::Luny.UnityEngine.Rendering.LuaRenderTargetIdentifier);
                        if (_arg3.TryRead<global::Luny.UnityEngine.Rendering.LuaRenderTargetIdentifier>(out var _p3_UnityEngine_Rendering_RenderTargetIdentifier))
                        {
                            if (_argCount == 5)
                            {
                                var computeShader = _p0_UnityEngine_ComputeShader.Instance;
                                var kernelIndex = _p1_System_Int32;
                                var name = _p2_System_String;
                                var rt = _p3_UnityEngine_Rendering_RenderTargetIdentifier.Value;
                                _this.Instance.SetComputeTextureParam(computeShader, kernelIndex, name, rt);
                                var _retCount = _context.Return();
                                return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                            }
                            var _arg4 = _lastArg = _argCount > 5 ? _context.GetArgument(5) : global::Lua.LuaValue.Nil;
                            _lastArgPos = 4; _expectedType = typeof(global::System.Int32);
                            if (_arg4.TryRead<global::System.Int32>(out var _p4_System_Int32))
                            {
                                if (_argCount == 6)
                                {
                                    var computeShader = _p0_UnityEngine_ComputeShader.Instance;
                                    var kernelIndex = _p1_System_Int32;
                                    var name = _p2_System_String;
                                    var rt = _p3_UnityEngine_Rendering_RenderTargetIdentifier.Value;
                                    var mipLevel = _p4_System_Int32;
                                    _this.Instance.SetComputeTextureParam(computeShader, kernelIndex, name, rt, mipLevel);
                                    var _retCount = _context.Return();
                                    return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                                }
                                var _arg5 = _lastArg = _argCount > 6 ? _context.GetArgument(6) : global::Lua.LuaValue.Nil;
                                _lastArgPos = 5; _expectedType = typeof(global::UnityEngine.Rendering.RenderTextureSubElement);
                                if (_arg5.TryRead<global::UnityEngine.Rendering.RenderTextureSubElement>(out var _p5_UnityEngine_Rendering_RenderTextureSubElement))
                                {
                                    if (_argCount == 7)
                                    {
                                        var computeShader = _p0_UnityEngine_ComputeShader.Instance;
                                        var kernelIndex = _p1_System_Int32;
                                        var name = _p2_System_String;
                                        var rt = _p3_UnityEngine_Rendering_RenderTargetIdentifier.Value;
                                        var mipLevel = _p4_System_Int32;
                                        var element = _p5_UnityEngine_Rendering_RenderTextureSubElement;
                                        _this.Instance.SetComputeTextureParam(computeShader, kernelIndex, name, rt, mipLevel, element);
                                        var _retCount = _context.Return();
                                        return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                                    }
                                }
                            }
                        }
                    }
                }
            }
            throw new global::Lua.LuaRuntimeException(_context.Thread, $"{"SetComputeTextureParam"}: invalid argument #{_lastArgPos}: {_lastArg} ({_lastArg.Type}), expected: {_expectedType.FullName}", 2);
        });
        private static readonly global::Lua.LuaFunction _LuaCommandBuffer_SetComputeVectorArrayParam = new global::Lua.LuaFunction("SetComputeVectorArrayParam", (_context, _) =>
        {
            global::Lua.LuaValue _lastArg = default;
            global::System.Int32 _lastArgPos = default;
            global::System.Type _expectedType = default;
            var _argCount = _context.ArgumentCount;
            var _this = _context.GetArgument<LuaCommandBuffer>(0);
            var _arg0 = _lastArg = _argCount > 1 ? _context.GetArgument(1) : global::Lua.LuaValue.Nil;
            _lastArgPos = 0; _expectedType = typeof(global::Luny.UnityEngine.LuaComputeShader);
            if (_arg0.TryRead<global::Luny.UnityEngine.LuaComputeShader>(out var _p0_UnityEngine_ComputeShader))
            {
                var _arg1 = _lastArg = _argCount > 2 ? _context.GetArgument(2) : global::Lua.LuaValue.Nil;
                _lastArgPos = 1; _expectedType = typeof(global::System.Int32);
                if (_arg1.TryRead<global::System.Int32>(out var _p1_System_Int32))
                {
                    var _arg2 = _lastArg = _argCount > 3 ? _context.GetArgument(3) : global::Lua.LuaValue.Nil;
                    _lastArgPos = 2; _expectedType = typeof(global::UnityEngine.Vector4[]);
                    if (_arg2.TryReadArray<global::UnityEngine.Vector4>(out var _p2_UnityEngine_Vector4Array))
                    {
                        if (_argCount == 4)
                        {
                            var computeShader = _p0_UnityEngine_ComputeShader.Instance;
                            var nameID = _p1_System_Int32;
                            var values = _p2_UnityEngine_Vector4Array;
                            _this.Instance.SetComputeVectorArrayParam(computeShader, nameID, values);
                            var _retCount = _context.Return();
                            return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                        }
                    }
                }
                _lastArgPos = 1; _expectedType = typeof(global::System.String);
                if (_arg1.TryRead<global::System.String>(out var _p1_System_String))
                {
                    var _arg2 = _lastArg = _argCount > 3 ? _context.GetArgument(3) : global::Lua.LuaValue.Nil;
                    _lastArgPos = 2; _expectedType = typeof(global::UnityEngine.Vector4[]);
                    if (_arg2.TryReadArray<global::UnityEngine.Vector4>(out var _p2_UnityEngine_Vector4Array))
                    {
                        if (_argCount == 4)
                        {
                            var computeShader = _p0_UnityEngine_ComputeShader.Instance;
                            var name = _p1_System_String;
                            var values = _p2_UnityEngine_Vector4Array;
                            _this.Instance.SetComputeVectorArrayParam(computeShader, name, values);
                            var _retCount = _context.Return();
                            return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                        }
                    }
                }
            }
            throw new global::Lua.LuaRuntimeException(_context.Thread, $"{"SetComputeVectorArrayParam"}: invalid argument #{_lastArgPos}: {_lastArg} ({_lastArg.Type}), expected: {_expectedType.FullName}", 2);
        });
        private static readonly global::Lua.LuaFunction _LuaCommandBuffer_SetComputeVectorParam = new global::Lua.LuaFunction("SetComputeVectorParam", (_context, _) =>
        {
            global::Lua.LuaValue _lastArg = default;
            global::System.Int32 _lastArgPos = default;
            global::System.Type _expectedType = default;
            var _argCount = _context.ArgumentCount;
            var _this = _context.GetArgument<LuaCommandBuffer>(0);
            var _arg0 = _lastArg = _argCount > 1 ? _context.GetArgument(1) : global::Lua.LuaValue.Nil;
            _lastArgPos = 0; _expectedType = typeof(global::Luny.UnityEngine.LuaComputeShader);
            if (_arg0.TryRead<global::Luny.UnityEngine.LuaComputeShader>(out var _p0_UnityEngine_ComputeShader))
            {
                var _arg1 = _lastArg = _argCount > 2 ? _context.GetArgument(2) : global::Lua.LuaValue.Nil;
                _lastArgPos = 1; _expectedType = typeof(global::System.Int32);
                if (_arg1.TryRead<global::System.Int32>(out var _p1_System_Int32))
                {
                    var _arg2 = _lastArg = _argCount > 3 ? _context.GetArgument(3) : global::Lua.LuaValue.Nil;
                    _lastArgPos = 2; _expectedType = typeof(global::Luny.UnityEngine.LuaVector4);
                    if (_arg2.TryRead<global::Luny.UnityEngine.LuaVector4>(out var _p2_UnityEngine_Vector4))
                    {
                        if (_argCount == 4)
                        {
                            var computeShader = _p0_UnityEngine_ComputeShader.Instance;
                            var nameID = _p1_System_Int32;
                            var val = _p2_UnityEngine_Vector4.Value;
                            _this.Instance.SetComputeVectorParam(computeShader, nameID, val);
                            var _retCount = _context.Return();
                            return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                        }
                    }
                }
                _lastArgPos = 1; _expectedType = typeof(global::System.String);
                if (_arg1.TryRead<global::System.String>(out var _p1_System_String))
                {
                    var _arg2 = _lastArg = _argCount > 3 ? _context.GetArgument(3) : global::Lua.LuaValue.Nil;
                    _lastArgPos = 2; _expectedType = typeof(global::Luny.UnityEngine.LuaVector4);
                    if (_arg2.TryRead<global::Luny.UnityEngine.LuaVector4>(out var _p2_UnityEngine_Vector4))
                    {
                        if (_argCount == 4)
                        {
                            var computeShader = _p0_UnityEngine_ComputeShader.Instance;
                            var name = _p1_System_String;
                            var val = _p2_UnityEngine_Vector4.Value;
                            _this.Instance.SetComputeVectorParam(computeShader, name, val);
                            var _retCount = _context.Return();
                            return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                        }
                    }
                }
            }
            throw new global::Lua.LuaRuntimeException(_context.Thread, $"{"SetComputeVectorParam"}: invalid argument #{_lastArgPos}: {_lastArg} ({_lastArg.Type}), expected: {_expectedType.FullName}", 2);
        });
        private static readonly global::Lua.LuaFunction _LuaCommandBuffer_SetExecutionFlags = new global::Lua.LuaFunction("SetExecutionFlags", (_context, _) =>
        {
            global::Lua.LuaValue _lastArg = default;
            global::System.Int32 _lastArgPos = default;
            global::System.Type _expectedType = default;
            var _argCount = _context.ArgumentCount;
            var _this = _context.GetArgument<LuaCommandBuffer>(0);
            var _arg0 = _lastArg = _argCount > 1 ? _context.GetArgument(1) : global::Lua.LuaValue.Nil;
            _lastArgPos = 0; _expectedType = typeof(global::UnityEngine.Rendering.CommandBufferExecutionFlags);
            if (_arg0.TryRead<global::UnityEngine.Rendering.CommandBufferExecutionFlags>(out var _p0_UnityEngine_Rendering_CommandBufferExecutionFlags))
            {
                if (_argCount == 2)
                {
                    var flags = _p0_UnityEngine_Rendering_CommandBufferExecutionFlags;
                    _this.Instance.SetExecutionFlags(flags);
                    var _retCount = _context.Return();
                    return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                }
            }
            throw new global::Lua.LuaRuntimeException(_context.Thread, $"{"SetExecutionFlags"}: invalid argument #{_lastArgPos}: {_lastArg} ({_lastArg.Type}), expected: {_expectedType.FullName}", 2);
        });
        private static readonly global::Lua.LuaFunction _LuaCommandBuffer_SetFoveatedRenderingMode = new global::Lua.LuaFunction("SetFoveatedRenderingMode", (_context, _) =>
        {
            global::Lua.LuaValue _lastArg = default;
            global::System.Int32 _lastArgPos = default;
            global::System.Type _expectedType = default;
            var _argCount = _context.ArgumentCount;
            var _this = _context.GetArgument<LuaCommandBuffer>(0);
            var _arg0 = _lastArg = _argCount > 1 ? _context.GetArgument(1) : global::Lua.LuaValue.Nil;
            _lastArgPos = 0; _expectedType = typeof(global::UnityEngine.Rendering.FoveatedRenderingMode);
            if (_arg0.TryRead<global::UnityEngine.Rendering.FoveatedRenderingMode>(out var _p0_UnityEngine_Rendering_FoveatedRenderingMode))
            {
                if (_argCount == 2)
                {
                    var foveatedRenderingMode = _p0_UnityEngine_Rendering_FoveatedRenderingMode;
                    _this.Instance.SetFoveatedRenderingMode(foveatedRenderingMode);
                    var _retCount = _context.Return();
                    return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                }
            }
            throw new global::Lua.LuaRuntimeException(_context.Thread, $"{"SetFoveatedRenderingMode"}: invalid argument #{_lastArgPos}: {_lastArg} ({_lastArg.Type}), expected: {_expectedType.FullName}", 2);
        });
        private static readonly global::Lua.LuaFunction _LuaCommandBuffer_SetGlobalBuffer = new global::Lua.LuaFunction("SetGlobalBuffer", (_context, _) =>
        {
            global::Lua.LuaValue _lastArg = default;
            global::System.Int32 _lastArgPos = default;
            global::System.Type _expectedType = default;
            var _argCount = _context.ArgumentCount;
            var _this = _context.GetArgument<LuaCommandBuffer>(0);
            var _arg0 = _lastArg = _argCount > 1 ? _context.GetArgument(1) : global::Lua.LuaValue.Nil;
            _lastArgPos = 0; _expectedType = typeof(global::System.Int32);
            if (_arg0.TryRead<global::System.Int32>(out var _p0_System_Int32))
            {
                var _arg1 = _lastArg = _argCount > 2 ? _context.GetArgument(2) : global::Lua.LuaValue.Nil;
                _lastArgPos = 1; _expectedType = typeof(global::Luny.UnityEngine.LuaComputeBuffer);
                if (_arg1.TryRead<global::Luny.UnityEngine.LuaComputeBuffer>(out var _p1_UnityEngine_ComputeBuffer))
                {
                    if (_argCount == 3)
                    {
                        var nameID = _p0_System_Int32;
                        var value = _p1_UnityEngine_ComputeBuffer.Instance;
                        _this.Instance.SetGlobalBuffer(nameID, value);
                        var _retCount = _context.Return();
                        return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                    }
                }
                _lastArgPos = 1; _expectedType = typeof(global::Luny.UnityEngine.LuaGraphicsBuffer);
                if (_arg1.TryRead<global::Luny.UnityEngine.LuaGraphicsBuffer>(out var _p1_UnityEngine_GraphicsBuffer))
                {
                    if (_argCount == 3)
                    {
                        var nameID = _p0_System_Int32;
                        var value = _p1_UnityEngine_GraphicsBuffer.Instance;
                        _this.Instance.SetGlobalBuffer(nameID, value);
                        var _retCount = _context.Return();
                        return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                    }
                }
            }
            _lastArgPos = 0; _expectedType = typeof(global::System.String);
            if (_arg0.TryRead<global::System.String>(out var _p0_System_String))
            {
                var _arg1 = _lastArg = _argCount > 2 ? _context.GetArgument(2) : global::Lua.LuaValue.Nil;
                _lastArgPos = 1; _expectedType = typeof(global::Luny.UnityEngine.LuaComputeBuffer);
                if (_arg1.TryRead<global::Luny.UnityEngine.LuaComputeBuffer>(out var _p1_UnityEngine_ComputeBuffer))
                {
                    if (_argCount == 3)
                    {
                        var name = _p0_System_String;
                        var value = _p1_UnityEngine_ComputeBuffer.Instance;
                        _this.Instance.SetGlobalBuffer(name, value);
                        var _retCount = _context.Return();
                        return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                    }
                }
                _lastArgPos = 1; _expectedType = typeof(global::Luny.UnityEngine.LuaGraphicsBuffer);
                if (_arg1.TryRead<global::Luny.UnityEngine.LuaGraphicsBuffer>(out var _p1_UnityEngine_GraphicsBuffer))
                {
                    if (_argCount == 3)
                    {
                        var name = _p0_System_String;
                        var value = _p1_UnityEngine_GraphicsBuffer.Instance;
                        _this.Instance.SetGlobalBuffer(name, value);
                        var _retCount = _context.Return();
                        return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                    }
                }
            }
            throw new global::Lua.LuaRuntimeException(_context.Thread, $"{"SetGlobalBuffer"}: invalid argument #{_lastArgPos}: {_lastArg} ({_lastArg.Type}), expected: {_expectedType.FullName}", 2);
        });
        private static readonly global::Lua.LuaFunction _LuaCommandBuffer_SetGlobalColor = new global::Lua.LuaFunction("SetGlobalColor", (_context, _) =>
        {
            global::Lua.LuaValue _lastArg = default;
            global::System.Int32 _lastArgPos = default;
            global::System.Type _expectedType = default;
            var _argCount = _context.ArgumentCount;
            var _this = _context.GetArgument<LuaCommandBuffer>(0);
            var _arg0 = _lastArg = _argCount > 1 ? _context.GetArgument(1) : global::Lua.LuaValue.Nil;
            _lastArgPos = 0; _expectedType = typeof(global::System.Int32);
            if (_arg0.TryRead<global::System.Int32>(out var _p0_System_Int32))
            {
                var _arg1 = _lastArg = _argCount > 2 ? _context.GetArgument(2) : global::Lua.LuaValue.Nil;
                _lastArgPos = 1; _expectedType = typeof(global::Luny.UnityEngine.LuaColor);
                if (_arg1.TryRead<global::Luny.UnityEngine.LuaColor>(out var _p1_UnityEngine_Color))
                {
                    if (_argCount == 3)
                    {
                        var nameID = _p0_System_Int32;
                        var value = _p1_UnityEngine_Color.Value;
                        _this.Instance.SetGlobalColor(nameID, value);
                        var _retCount = _context.Return();
                        return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                    }
                }
            }
            _lastArgPos = 0; _expectedType = typeof(global::System.String);
            if (_arg0.TryRead<global::System.String>(out var _p0_System_String))
            {
                var _arg1 = _lastArg = _argCount > 2 ? _context.GetArgument(2) : global::Lua.LuaValue.Nil;
                _lastArgPos = 1; _expectedType = typeof(global::Luny.UnityEngine.LuaColor);
                if (_arg1.TryRead<global::Luny.UnityEngine.LuaColor>(out var _p1_UnityEngine_Color))
                {
                    if (_argCount == 3)
                    {
                        var name = _p0_System_String;
                        var value = _p1_UnityEngine_Color.Value;
                        _this.Instance.SetGlobalColor(name, value);
                        var _retCount = _context.Return();
                        return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                    }
                }
            }
            throw new global::Lua.LuaRuntimeException(_context.Thread, $"{"SetGlobalColor"}: invalid argument #{_lastArgPos}: {_lastArg} ({_lastArg.Type}), expected: {_expectedType.FullName}", 2);
        });
        private static readonly global::Lua.LuaFunction _LuaCommandBuffer_SetGlobalConstantBuffer = new global::Lua.LuaFunction("SetGlobalConstantBuffer", (_context, _) =>
        {
            global::Lua.LuaValue _lastArg = default;
            global::System.Int32 _lastArgPos = default;
            global::System.Type _expectedType = default;
            var _argCount = _context.ArgumentCount;
            var _this = _context.GetArgument<LuaCommandBuffer>(0);
            var _arg0 = _lastArg = _argCount > 1 ? _context.GetArgument(1) : global::Lua.LuaValue.Nil;
            _lastArgPos = 0; _expectedType = typeof(global::Luny.UnityEngine.LuaComputeBuffer);
            if (_arg0.TryRead<global::Luny.UnityEngine.LuaComputeBuffer>(out var _p0_UnityEngine_ComputeBuffer))
            {
                var _arg1 = _lastArg = _argCount > 2 ? _context.GetArgument(2) : global::Lua.LuaValue.Nil;
                _lastArgPos = 1; _expectedType = typeof(global::System.Int32);
                if (_arg1.TryRead<global::System.Int32>(out var _p1_System_Int32))
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
                                var buffer = _p0_UnityEngine_ComputeBuffer.Instance;
                                var nameID = _p1_System_Int32;
                                var offset = _p2_System_Int32;
                                var size = _p3_System_Int32;
                                _this.Instance.SetGlobalConstantBuffer(buffer, nameID, offset, size);
                                var _retCount = _context.Return();
                                return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                            }
                        }
                    }
                }
                _lastArgPos = 1; _expectedType = typeof(global::System.String);
                if (_arg1.TryRead<global::System.String>(out var _p1_System_String))
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
                                var buffer = _p0_UnityEngine_ComputeBuffer.Instance;
                                var name = _p1_System_String;
                                var offset = _p2_System_Int32;
                                var size = _p3_System_Int32;
                                _this.Instance.SetGlobalConstantBuffer(buffer, name, offset, size);
                                var _retCount = _context.Return();
                                return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                            }
                        }
                    }
                }
            }
            _lastArgPos = 0; _expectedType = typeof(global::Luny.UnityEngine.LuaGraphicsBuffer);
            if (_arg0.TryRead<global::Luny.UnityEngine.LuaGraphicsBuffer>(out var _p0_UnityEngine_GraphicsBuffer))
            {
                var _arg1 = _lastArg = _argCount > 2 ? _context.GetArgument(2) : global::Lua.LuaValue.Nil;
                _lastArgPos = 1; _expectedType = typeof(global::System.Int32);
                if (_arg1.TryRead<global::System.Int32>(out var _p1_System_Int32))
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
                                var buffer = _p0_UnityEngine_GraphicsBuffer.Instance;
                                var nameID = _p1_System_Int32;
                                var offset = _p2_System_Int32;
                                var size = _p3_System_Int32;
                                _this.Instance.SetGlobalConstantBuffer(buffer, nameID, offset, size);
                                var _retCount = _context.Return();
                                return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                            }
                        }
                    }
                }
                _lastArgPos = 1; _expectedType = typeof(global::System.String);
                if (_arg1.TryRead<global::System.String>(out var _p1_System_String))
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
                                var buffer = _p0_UnityEngine_GraphicsBuffer.Instance;
                                var name = _p1_System_String;
                                var offset = _p2_System_Int32;
                                var size = _p3_System_Int32;
                                _this.Instance.SetGlobalConstantBuffer(buffer, name, offset, size);
                                var _retCount = _context.Return();
                                return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                            }
                        }
                    }
                }
            }
            throw new global::Lua.LuaRuntimeException(_context.Thread, $"{"SetGlobalConstantBuffer"}: invalid argument #{_lastArgPos}: {_lastArg} ({_lastArg.Type}), expected: {_expectedType.FullName}", 2);
        });
        private static readonly global::Lua.LuaFunction _LuaCommandBuffer_SetGlobalDepthBias = new global::Lua.LuaFunction("SetGlobalDepthBias", (_context, _) =>
        {
            global::Lua.LuaValue _lastArg = default;
            global::System.Int32 _lastArgPos = default;
            global::System.Type _expectedType = default;
            var _argCount = _context.ArgumentCount;
            var _this = _context.GetArgument<LuaCommandBuffer>(0);
            var _arg0 = _lastArg = _argCount > 1 ? _context.GetArgument(1) : global::Lua.LuaValue.Nil;
            _lastArgPos = 0; _expectedType = typeof(global::System.Single);
            if (_arg0.TryRead<global::System.Single>(out var _p0_System_Single))
            {
                var _arg1 = _lastArg = _argCount > 2 ? _context.GetArgument(2) : global::Lua.LuaValue.Nil;
                _lastArgPos = 1; _expectedType = typeof(global::System.Single);
                if (_arg1.TryRead<global::System.Single>(out var _p1_System_Single))
                {
                    if (_argCount == 3)
                    {
                        var bias = _p0_System_Single;
                        var slopeBias = _p1_System_Single;
                        _this.Instance.SetGlobalDepthBias(bias, slopeBias);
                        var _retCount = _context.Return();
                        return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                    }
                }
            }
            throw new global::Lua.LuaRuntimeException(_context.Thread, $"{"SetGlobalDepthBias"}: invalid argument #{_lastArgPos}: {_lastArg} ({_lastArg.Type}), expected: {_expectedType.FullName}", 2);
        });
        private static readonly global::Lua.LuaFunction _LuaCommandBuffer_SetGlobalFloat = new global::Lua.LuaFunction("SetGlobalFloat", (_context, _) =>
        {
            global::Lua.LuaValue _lastArg = default;
            global::System.Int32 _lastArgPos = default;
            global::System.Type _expectedType = default;
            var _argCount = _context.ArgumentCount;
            var _this = _context.GetArgument<LuaCommandBuffer>(0);
            var _arg0 = _lastArg = _argCount > 1 ? _context.GetArgument(1) : global::Lua.LuaValue.Nil;
            _lastArgPos = 0; _expectedType = typeof(global::System.Int32);
            if (_arg0.TryRead<global::System.Int32>(out var _p0_System_Int32))
            {
                var _arg1 = _lastArg = _argCount > 2 ? _context.GetArgument(2) : global::Lua.LuaValue.Nil;
                _lastArgPos = 1; _expectedType = typeof(global::System.Single);
                if (_arg1.TryRead<global::System.Single>(out var _p1_System_Single))
                {
                    if (_argCount == 3)
                    {
                        var nameID = _p0_System_Int32;
                        var value = _p1_System_Single;
                        _this.Instance.SetGlobalFloat(nameID, value);
                        var _retCount = _context.Return();
                        return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                    }
                }
            }
            _lastArgPos = 0; _expectedType = typeof(global::System.String);
            if (_arg0.TryRead<global::System.String>(out var _p0_System_String))
            {
                var _arg1 = _lastArg = _argCount > 2 ? _context.GetArgument(2) : global::Lua.LuaValue.Nil;
                _lastArgPos = 1; _expectedType = typeof(global::System.Single);
                if (_arg1.TryRead<global::System.Single>(out var _p1_System_Single))
                {
                    if (_argCount == 3)
                    {
                        var name = _p0_System_String;
                        var value = _p1_System_Single;
                        _this.Instance.SetGlobalFloat(name, value);
                        var _retCount = _context.Return();
                        return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                    }
                }
            }
            throw new global::Lua.LuaRuntimeException(_context.Thread, $"{"SetGlobalFloat"}: invalid argument #{_lastArgPos}: {_lastArg} ({_lastArg.Type}), expected: {_expectedType.FullName}", 2);
        });
        private static readonly global::Lua.LuaFunction _LuaCommandBuffer_SetGlobalFloatArray = new global::Lua.LuaFunction("SetGlobalFloatArray", (_context, _) =>
        {
            global::Lua.LuaValue _lastArg = default;
            global::System.Int32 _lastArgPos = default;
            global::System.Type _expectedType = default;
            var _argCount = _context.ArgumentCount;
            var _this = _context.GetArgument<LuaCommandBuffer>(0);
            var _arg0 = _lastArg = _argCount > 1 ? _context.GetArgument(1) : global::Lua.LuaValue.Nil;
            _lastArgPos = 0; _expectedType = typeof(global::System.Int32);
            if (_arg0.TryRead<global::System.Int32>(out var _p0_System_Int32))
            {
                var _arg1 = _lastArg = _argCount > 2 ? _context.GetArgument(2) : global::Lua.LuaValue.Nil;
                _lastArgPos = 1; _expectedType = typeof(global::System.Single[]);
                if (_arg1.TryReadArray<global::System.Single>(out var _p1_System_SingleArray))
                {
                    if (_argCount == 3)
                    {
                        var nameID = _p0_System_Int32;
                        var values = _p1_System_SingleArray;
                        _this.Instance.SetGlobalFloatArray(nameID, values);
                        var _retCount = _context.Return();
                        return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                    }
                }
            }
            _lastArgPos = 0; _expectedType = typeof(global::System.String);
            if (_arg0.TryRead<global::System.String>(out var _p0_System_String))
            {
                var _arg1 = _lastArg = _argCount > 2 ? _context.GetArgument(2) : global::Lua.LuaValue.Nil;
                _lastArgPos = 1; _expectedType = typeof(global::System.Single[]);
                if (_arg1.TryReadArray<global::System.Single>(out var _p1_System_SingleArray))
                {
                    if (_argCount == 3)
                    {
                        var propertyName = _p0_System_String;
                        var values = _p1_System_SingleArray;
                        _this.Instance.SetGlobalFloatArray(propertyName, values);
                        var _retCount = _context.Return();
                        return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                    }
                }
            }
            throw new global::Lua.LuaRuntimeException(_context.Thread, $"{"SetGlobalFloatArray"}: invalid argument #{_lastArgPos}: {_lastArg} ({_lastArg.Type}), expected: {_expectedType.FullName}", 2);
        });
        private static readonly global::Lua.LuaFunction _LuaCommandBuffer_SetGlobalInt = new global::Lua.LuaFunction("SetGlobalInt", (_context, _) =>
        {
            global::Lua.LuaValue _lastArg = default;
            global::System.Int32 _lastArgPos = default;
            global::System.Type _expectedType = default;
            var _argCount = _context.ArgumentCount;
            var _this = _context.GetArgument<LuaCommandBuffer>(0);
            var _arg0 = _lastArg = _argCount > 1 ? _context.GetArgument(1) : global::Lua.LuaValue.Nil;
            _lastArgPos = 0; _expectedType = typeof(global::System.Int32);
            if (_arg0.TryRead<global::System.Int32>(out var _p0_System_Int32))
            {
                var _arg1 = _lastArg = _argCount > 2 ? _context.GetArgument(2) : global::Lua.LuaValue.Nil;
                _lastArgPos = 1; _expectedType = typeof(global::System.Int32);
                if (_arg1.TryRead<global::System.Int32>(out var _p1_System_Int32))
                {
                    if (_argCount == 3)
                    {
                        var nameID = _p0_System_Int32;
                        var value = _p1_System_Int32;
                        _this.Instance.SetGlobalInt(nameID, value);
                        var _retCount = _context.Return();
                        return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                    }
                }
            }
            _lastArgPos = 0; _expectedType = typeof(global::System.String);
            if (_arg0.TryRead<global::System.String>(out var _p0_System_String))
            {
                var _arg1 = _lastArg = _argCount > 2 ? _context.GetArgument(2) : global::Lua.LuaValue.Nil;
                _lastArgPos = 1; _expectedType = typeof(global::System.Int32);
                if (_arg1.TryRead<global::System.Int32>(out var _p1_System_Int32))
                {
                    if (_argCount == 3)
                    {
                        var name = _p0_System_String;
                        var value = _p1_System_Int32;
                        _this.Instance.SetGlobalInt(name, value);
                        var _retCount = _context.Return();
                        return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                    }
                }
            }
            throw new global::Lua.LuaRuntimeException(_context.Thread, $"{"SetGlobalInt"}: invalid argument #{_lastArgPos}: {_lastArg} ({_lastArg.Type}), expected: {_expectedType.FullName}", 2);
        });
        private static readonly global::Lua.LuaFunction _LuaCommandBuffer_SetGlobalInteger = new global::Lua.LuaFunction("SetGlobalInteger", (_context, _) =>
        {
            global::Lua.LuaValue _lastArg = default;
            global::System.Int32 _lastArgPos = default;
            global::System.Type _expectedType = default;
            var _argCount = _context.ArgumentCount;
            var _this = _context.GetArgument<LuaCommandBuffer>(0);
            var _arg0 = _lastArg = _argCount > 1 ? _context.GetArgument(1) : global::Lua.LuaValue.Nil;
            _lastArgPos = 0; _expectedType = typeof(global::System.Int32);
            if (_arg0.TryRead<global::System.Int32>(out var _p0_System_Int32))
            {
                var _arg1 = _lastArg = _argCount > 2 ? _context.GetArgument(2) : global::Lua.LuaValue.Nil;
                _lastArgPos = 1; _expectedType = typeof(global::System.Int32);
                if (_arg1.TryRead<global::System.Int32>(out var _p1_System_Int32))
                {
                    if (_argCount == 3)
                    {
                        var nameID = _p0_System_Int32;
                        var value = _p1_System_Int32;
                        _this.Instance.SetGlobalInteger(nameID, value);
                        var _retCount = _context.Return();
                        return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                    }
                }
            }
            _lastArgPos = 0; _expectedType = typeof(global::System.String);
            if (_arg0.TryRead<global::System.String>(out var _p0_System_String))
            {
                var _arg1 = _lastArg = _argCount > 2 ? _context.GetArgument(2) : global::Lua.LuaValue.Nil;
                _lastArgPos = 1; _expectedType = typeof(global::System.Int32);
                if (_arg1.TryRead<global::System.Int32>(out var _p1_System_Int32))
                {
                    if (_argCount == 3)
                    {
                        var name = _p0_System_String;
                        var value = _p1_System_Int32;
                        _this.Instance.SetGlobalInteger(name, value);
                        var _retCount = _context.Return();
                        return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                    }
                }
            }
            throw new global::Lua.LuaRuntimeException(_context.Thread, $"{"SetGlobalInteger"}: invalid argument #{_lastArgPos}: {_lastArg} ({_lastArg.Type}), expected: {_expectedType.FullName}", 2);
        });
        private static readonly global::Lua.LuaFunction _LuaCommandBuffer_SetGlobalMatrix = new global::Lua.LuaFunction("SetGlobalMatrix", (_context, _) =>
        {
            global::Lua.LuaValue _lastArg = default;
            global::System.Int32 _lastArgPos = default;
            global::System.Type _expectedType = default;
            var _argCount = _context.ArgumentCount;
            var _this = _context.GetArgument<LuaCommandBuffer>(0);
            var _arg0 = _lastArg = _argCount > 1 ? _context.GetArgument(1) : global::Lua.LuaValue.Nil;
            _lastArgPos = 0; _expectedType = typeof(global::System.Int32);
            if (_arg0.TryRead<global::System.Int32>(out var _p0_System_Int32))
            {
                var _arg1 = _lastArg = _argCount > 2 ? _context.GetArgument(2) : global::Lua.LuaValue.Nil;
                _lastArgPos = 1; _expectedType = typeof(global::Luny.UnityEngine.LuaMatrix4x4);
                if (_arg1.TryRead<global::Luny.UnityEngine.LuaMatrix4x4>(out var _p1_UnityEngine_Matrix4x4))
                {
                    if (_argCount == 3)
                    {
                        var nameID = _p0_System_Int32;
                        var value = _p1_UnityEngine_Matrix4x4.Value;
                        _this.Instance.SetGlobalMatrix(nameID, value);
                        var _retCount = _context.Return();
                        return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                    }
                }
            }
            _lastArgPos = 0; _expectedType = typeof(global::System.String);
            if (_arg0.TryRead<global::System.String>(out var _p0_System_String))
            {
                var _arg1 = _lastArg = _argCount > 2 ? _context.GetArgument(2) : global::Lua.LuaValue.Nil;
                _lastArgPos = 1; _expectedType = typeof(global::Luny.UnityEngine.LuaMatrix4x4);
                if (_arg1.TryRead<global::Luny.UnityEngine.LuaMatrix4x4>(out var _p1_UnityEngine_Matrix4x4))
                {
                    if (_argCount == 3)
                    {
                        var name = _p0_System_String;
                        var value = _p1_UnityEngine_Matrix4x4.Value;
                        _this.Instance.SetGlobalMatrix(name, value);
                        var _retCount = _context.Return();
                        return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                    }
                }
            }
            throw new global::Lua.LuaRuntimeException(_context.Thread, $"{"SetGlobalMatrix"}: invalid argument #{_lastArgPos}: {_lastArg} ({_lastArg.Type}), expected: {_expectedType.FullName}", 2);
        });
        private static readonly global::Lua.LuaFunction _LuaCommandBuffer_SetGlobalMatrixArray = new global::Lua.LuaFunction("SetGlobalMatrixArray", (_context, _) =>
        {
            global::Lua.LuaValue _lastArg = default;
            global::System.Int32 _lastArgPos = default;
            global::System.Type _expectedType = default;
            var _argCount = _context.ArgumentCount;
            var _this = _context.GetArgument<LuaCommandBuffer>(0);
            var _arg0 = _lastArg = _argCount > 1 ? _context.GetArgument(1) : global::Lua.LuaValue.Nil;
            _lastArgPos = 0; _expectedType = typeof(global::System.Int32);
            if (_arg0.TryRead<global::System.Int32>(out var _p0_System_Int32))
            {
                var _arg1 = _lastArg = _argCount > 2 ? _context.GetArgument(2) : global::Lua.LuaValue.Nil;
                _lastArgPos = 1; _expectedType = typeof(global::UnityEngine.Matrix4x4[]);
                if (_arg1.TryReadArray<global::UnityEngine.Matrix4x4>(out var _p1_UnityEngine_Matrix4x4Array))
                {
                    if (_argCount == 3)
                    {
                        var nameID = _p0_System_Int32;
                        var values = _p1_UnityEngine_Matrix4x4Array;
                        _this.Instance.SetGlobalMatrixArray(nameID, values);
                        var _retCount = _context.Return();
                        return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                    }
                }
            }
            _lastArgPos = 0; _expectedType = typeof(global::System.String);
            if (_arg0.TryRead<global::System.String>(out var _p0_System_String))
            {
                var _arg1 = _lastArg = _argCount > 2 ? _context.GetArgument(2) : global::Lua.LuaValue.Nil;
                _lastArgPos = 1; _expectedType = typeof(global::UnityEngine.Matrix4x4[]);
                if (_arg1.TryReadArray<global::UnityEngine.Matrix4x4>(out var _p1_UnityEngine_Matrix4x4Array))
                {
                    if (_argCount == 3)
                    {
                        var propertyName = _p0_System_String;
                        var values = _p1_UnityEngine_Matrix4x4Array;
                        _this.Instance.SetGlobalMatrixArray(propertyName, values);
                        var _retCount = _context.Return();
                        return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                    }
                }
            }
            throw new global::Lua.LuaRuntimeException(_context.Thread, $"{"SetGlobalMatrixArray"}: invalid argument #{_lastArgPos}: {_lastArg} ({_lastArg.Type}), expected: {_expectedType.FullName}", 2);
        });
        private static readonly global::Lua.LuaFunction _LuaCommandBuffer_SetGlobalRayTracingAccelerationStructure = new global::Lua.LuaFunction("SetGlobalRayTracingAccelerationStructure", (_context, _) =>
        {
            global::Lua.LuaValue _lastArg = default;
            global::System.Int32 _lastArgPos = default;
            global::System.Type _expectedType = default;
            var _argCount = _context.ArgumentCount;
            var _this = _context.GetArgument<LuaCommandBuffer>(0);
            var _arg0 = _lastArg = _argCount > 1 ? _context.GetArgument(1) : global::Lua.LuaValue.Nil;
            _lastArgPos = 0; _expectedType = typeof(global::System.Int32);
            if (_arg0.TryRead<global::System.Int32>(out var _p0_System_Int32))
            {
                var _arg1 = _lastArg = _argCount > 2 ? _context.GetArgument(2) : global::Lua.LuaValue.Nil;
                _lastArgPos = 1; _expectedType = typeof(global::Luny.UnityEngine.Rendering.LuaRayTracingAccelerationStructure);
                if (_arg1.TryRead<global::Luny.UnityEngine.Rendering.LuaRayTracingAccelerationStructure>(out var _p1_UnityEngine_Rendering_RayTracingAccelerationStructure))
                {
                    if (_argCount == 3)
                    {
                        var nameID = _p0_System_Int32;
                        var accelerationStructure = _p1_UnityEngine_Rendering_RayTracingAccelerationStructure.Instance;
                        _this.Instance.SetGlobalRayTracingAccelerationStructure(nameID, accelerationStructure);
                        var _retCount = _context.Return();
                        return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                    }
                }
            }
            _lastArgPos = 0; _expectedType = typeof(global::System.String);
            if (_arg0.TryRead<global::System.String>(out var _p0_System_String))
            {
                var _arg1 = _lastArg = _argCount > 2 ? _context.GetArgument(2) : global::Lua.LuaValue.Nil;
                _lastArgPos = 1; _expectedType = typeof(global::Luny.UnityEngine.Rendering.LuaRayTracingAccelerationStructure);
                if (_arg1.TryRead<global::Luny.UnityEngine.Rendering.LuaRayTracingAccelerationStructure>(out var _p1_UnityEngine_Rendering_RayTracingAccelerationStructure))
                {
                    if (_argCount == 3)
                    {
                        var name = _p0_System_String;
                        var accelerationStructure = _p1_UnityEngine_Rendering_RayTracingAccelerationStructure.Instance;
                        _this.Instance.SetGlobalRayTracingAccelerationStructure(name, accelerationStructure);
                        var _retCount = _context.Return();
                        return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                    }
                }
            }
            throw new global::Lua.LuaRuntimeException(_context.Thread, $"{"SetGlobalRayTracingAccelerationStructure"}: invalid argument #{_lastArgPos}: {_lastArg} ({_lastArg.Type}), expected: {_expectedType.FullName}", 2);
        });
        private static readonly global::Lua.LuaFunction _LuaCommandBuffer_SetGlobalTexture = new global::Lua.LuaFunction("SetGlobalTexture", (_context, _) =>
        {
            global::Lua.LuaValue _lastArg = default;
            global::System.Int32 _lastArgPos = default;
            global::System.Type _expectedType = default;
            var _argCount = _context.ArgumentCount;
            var _this = _context.GetArgument<LuaCommandBuffer>(0);
            var _arg0 = _lastArg = _argCount > 1 ? _context.GetArgument(1) : global::Lua.LuaValue.Nil;
            _lastArgPos = 0; _expectedType = typeof(global::System.Int32);
            if (_arg0.TryRead<global::System.Int32>(out var _p0_System_Int32))
            {
                var _arg1 = _lastArg = _argCount > 2 ? _context.GetArgument(2) : global::Lua.LuaValue.Nil;
                _lastArgPos = 1; _expectedType = typeof(global::Luny.UnityEngine.Rendering.LuaRenderTargetIdentifier);
                if (_arg1.TryRead<global::Luny.UnityEngine.Rendering.LuaRenderTargetIdentifier>(out var _p1_UnityEngine_Rendering_RenderTargetIdentifier))
                {
                    if (_argCount == 3)
                    {
                        var nameID = _p0_System_Int32;
                        var value = _p1_UnityEngine_Rendering_RenderTargetIdentifier.Value;
                        _this.Instance.SetGlobalTexture(nameID, value);
                        var _retCount = _context.Return();
                        return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                    }
                    var _arg2 = _lastArg = _argCount > 3 ? _context.GetArgument(3) : global::Lua.LuaValue.Nil;
                    _lastArgPos = 2; _expectedType = typeof(global::UnityEngine.Rendering.RenderTextureSubElement);
                    if (_arg2.TryRead<global::UnityEngine.Rendering.RenderTextureSubElement>(out var _p2_UnityEngine_Rendering_RenderTextureSubElement))
                    {
                        if (_argCount == 4)
                        {
                            var nameID = _p0_System_Int32;
                            var value = _p1_UnityEngine_Rendering_RenderTargetIdentifier.Value;
                            var element = _p2_UnityEngine_Rendering_RenderTextureSubElement;
                            _this.Instance.SetGlobalTexture(nameID, value, element);
                            var _retCount = _context.Return();
                            return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                        }
                    }
                }
            }
            _lastArgPos = 0; _expectedType = typeof(global::System.String);
            if (_arg0.TryRead<global::System.String>(out var _p0_System_String))
            {
                var _arg1 = _lastArg = _argCount > 2 ? _context.GetArgument(2) : global::Lua.LuaValue.Nil;
                _lastArgPos = 1; _expectedType = typeof(global::Luny.UnityEngine.Rendering.LuaRenderTargetIdentifier);
                if (_arg1.TryRead<global::Luny.UnityEngine.Rendering.LuaRenderTargetIdentifier>(out var _p1_UnityEngine_Rendering_RenderTargetIdentifier))
                {
                    if (_argCount == 3)
                    {
                        var name = _p0_System_String;
                        var value = _p1_UnityEngine_Rendering_RenderTargetIdentifier.Value;
                        _this.Instance.SetGlobalTexture(name, value);
                        var _retCount = _context.Return();
                        return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                    }
                    var _arg2 = _lastArg = _argCount > 3 ? _context.GetArgument(3) : global::Lua.LuaValue.Nil;
                    _lastArgPos = 2; _expectedType = typeof(global::UnityEngine.Rendering.RenderTextureSubElement);
                    if (_arg2.TryRead<global::UnityEngine.Rendering.RenderTextureSubElement>(out var _p2_UnityEngine_Rendering_RenderTextureSubElement))
                    {
                        if (_argCount == 4)
                        {
                            var name = _p0_System_String;
                            var value = _p1_UnityEngine_Rendering_RenderTargetIdentifier.Value;
                            var element = _p2_UnityEngine_Rendering_RenderTextureSubElement;
                            _this.Instance.SetGlobalTexture(name, value, element);
                            var _retCount = _context.Return();
                            return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                        }
                    }
                }
            }
            throw new global::Lua.LuaRuntimeException(_context.Thread, $"{"SetGlobalTexture"}: invalid argument #{_lastArgPos}: {_lastArg} ({_lastArg.Type}), expected: {_expectedType.FullName}", 2);
        });
        private static readonly global::Lua.LuaFunction _LuaCommandBuffer_SetGlobalVector = new global::Lua.LuaFunction("SetGlobalVector", (_context, _) =>
        {
            global::Lua.LuaValue _lastArg = default;
            global::System.Int32 _lastArgPos = default;
            global::System.Type _expectedType = default;
            var _argCount = _context.ArgumentCount;
            var _this = _context.GetArgument<LuaCommandBuffer>(0);
            var _arg0 = _lastArg = _argCount > 1 ? _context.GetArgument(1) : global::Lua.LuaValue.Nil;
            _lastArgPos = 0; _expectedType = typeof(global::System.Int32);
            if (_arg0.TryRead<global::System.Int32>(out var _p0_System_Int32))
            {
                var _arg1 = _lastArg = _argCount > 2 ? _context.GetArgument(2) : global::Lua.LuaValue.Nil;
                _lastArgPos = 1; _expectedType = typeof(global::Luny.UnityEngine.LuaVector4);
                if (_arg1.TryRead<global::Luny.UnityEngine.LuaVector4>(out var _p1_UnityEngine_Vector4))
                {
                    if (_argCount == 3)
                    {
                        var nameID = _p0_System_Int32;
                        var value = _p1_UnityEngine_Vector4.Value;
                        _this.Instance.SetGlobalVector(nameID, value);
                        var _retCount = _context.Return();
                        return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                    }
                }
            }
            _lastArgPos = 0; _expectedType = typeof(global::System.String);
            if (_arg0.TryRead<global::System.String>(out var _p0_System_String))
            {
                var _arg1 = _lastArg = _argCount > 2 ? _context.GetArgument(2) : global::Lua.LuaValue.Nil;
                _lastArgPos = 1; _expectedType = typeof(global::Luny.UnityEngine.LuaVector4);
                if (_arg1.TryRead<global::Luny.UnityEngine.LuaVector4>(out var _p1_UnityEngine_Vector4))
                {
                    if (_argCount == 3)
                    {
                        var name = _p0_System_String;
                        var value = _p1_UnityEngine_Vector4.Value;
                        _this.Instance.SetGlobalVector(name, value);
                        var _retCount = _context.Return();
                        return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                    }
                }
            }
            throw new global::Lua.LuaRuntimeException(_context.Thread, $"{"SetGlobalVector"}: invalid argument #{_lastArgPos}: {_lastArg} ({_lastArg.Type}), expected: {_expectedType.FullName}", 2);
        });
        private static readonly global::Lua.LuaFunction _LuaCommandBuffer_SetGlobalVectorArray = new global::Lua.LuaFunction("SetGlobalVectorArray", (_context, _) =>
        {
            global::Lua.LuaValue _lastArg = default;
            global::System.Int32 _lastArgPos = default;
            global::System.Type _expectedType = default;
            var _argCount = _context.ArgumentCount;
            var _this = _context.GetArgument<LuaCommandBuffer>(0);
            var _arg0 = _lastArg = _argCount > 1 ? _context.GetArgument(1) : global::Lua.LuaValue.Nil;
            _lastArgPos = 0; _expectedType = typeof(global::System.Int32);
            if (_arg0.TryRead<global::System.Int32>(out var _p0_System_Int32))
            {
                var _arg1 = _lastArg = _argCount > 2 ? _context.GetArgument(2) : global::Lua.LuaValue.Nil;
                _lastArgPos = 1; _expectedType = typeof(global::UnityEngine.Vector4[]);
                if (_arg1.TryReadArray<global::UnityEngine.Vector4>(out var _p1_UnityEngine_Vector4Array))
                {
                    if (_argCount == 3)
                    {
                        var nameID = _p0_System_Int32;
                        var values = _p1_UnityEngine_Vector4Array;
                        _this.Instance.SetGlobalVectorArray(nameID, values);
                        var _retCount = _context.Return();
                        return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                    }
                }
            }
            _lastArgPos = 0; _expectedType = typeof(global::System.String);
            if (_arg0.TryRead<global::System.String>(out var _p0_System_String))
            {
                var _arg1 = _lastArg = _argCount > 2 ? _context.GetArgument(2) : global::Lua.LuaValue.Nil;
                _lastArgPos = 1; _expectedType = typeof(global::UnityEngine.Vector4[]);
                if (_arg1.TryReadArray<global::UnityEngine.Vector4>(out var _p1_UnityEngine_Vector4Array))
                {
                    if (_argCount == 3)
                    {
                        var propertyName = _p0_System_String;
                        var values = _p1_UnityEngine_Vector4Array;
                        _this.Instance.SetGlobalVectorArray(propertyName, values);
                        var _retCount = _context.Return();
                        return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                    }
                }
            }
            throw new global::Lua.LuaRuntimeException(_context.Thread, $"{"SetGlobalVectorArray"}: invalid argument #{_lastArgPos}: {_lastArg} ({_lastArg.Type}), expected: {_expectedType.FullName}", 2);
        });
        private static readonly global::Lua.LuaFunction _LuaCommandBuffer_SetInstanceMultiplier = new global::Lua.LuaFunction("SetInstanceMultiplier", (_context, _) =>
        {
            global::Lua.LuaValue _lastArg = default;
            global::System.Int32 _lastArgPos = default;
            global::System.Type _expectedType = default;
            var _argCount = _context.ArgumentCount;
            var _this = _context.GetArgument<LuaCommandBuffer>(0);
            var _arg0 = _lastArg = _argCount > 1 ? _context.GetArgument(1) : global::Lua.LuaValue.Nil;
            _lastArgPos = 0; _expectedType = typeof(global::System.UInt32);
            if (_arg0.TryRead<global::System.UInt32>(out var _p0_System_UInt32))
            {
                if (_argCount == 2)
                {
                    var multiplier = _p0_System_UInt32;
                    _this.Instance.SetInstanceMultiplier(multiplier);
                    var _retCount = _context.Return();
                    return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                }
            }
            throw new global::Lua.LuaRuntimeException(_context.Thread, $"{"SetInstanceMultiplier"}: invalid argument #{_lastArgPos}: {_lastArg} ({_lastArg.Type}), expected: {_expectedType.FullName}", 2);
        });
        private static readonly global::Lua.LuaFunction _LuaCommandBuffer_SetInvertCulling = new global::Lua.LuaFunction("SetInvertCulling", (_context, _) =>
        {
            global::Lua.LuaValue _lastArg = default;
            global::System.Int32 _lastArgPos = default;
            global::System.Type _expectedType = default;
            var _argCount = _context.ArgumentCount;
            var _this = _context.GetArgument<LuaCommandBuffer>(0);
            var _arg0 = _lastArg = _argCount > 1 ? _context.GetArgument(1) : global::Lua.LuaValue.Nil;
            _lastArgPos = 0; _expectedType = typeof(global::System.Boolean);
            if (_arg0.TryRead<global::System.Boolean>(out var _p0_System_Boolean))
            {
                if (_argCount == 2)
                {
                    var invertCulling = _p0_System_Boolean;
                    _this.Instance.SetInvertCulling(invertCulling);
                    var _retCount = _context.Return();
                    return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                }
            }
            throw new global::Lua.LuaRuntimeException(_context.Thread, $"{"SetInvertCulling"}: invalid argument #{_lastArgPos}: {_lastArg} ({_lastArg.Type}), expected: {_expectedType.FullName}", 2);
        });
        private static readonly global::Lua.LuaFunction _LuaCommandBuffer_SetLateLatchProjectionMatrices = new global::Lua.LuaFunction("SetLateLatchProjectionMatrices", (_context, _) =>
        {
            global::Lua.LuaValue _lastArg = default;
            global::System.Int32 _lastArgPos = default;
            global::System.Type _expectedType = default;
            var _argCount = _context.ArgumentCount;
            var _this = _context.GetArgument<LuaCommandBuffer>(0);
            var _arg0 = _lastArg = _argCount > 1 ? _context.GetArgument(1) : global::Lua.LuaValue.Nil;
            _lastArgPos = 0; _expectedType = typeof(global::UnityEngine.Matrix4x4[]);
            if (_arg0.TryReadArray<global::UnityEngine.Matrix4x4>(out var _p0_UnityEngine_Matrix4x4Array))
            {
                if (_argCount == 2)
                {
                    var projectionMat = _p0_UnityEngine_Matrix4x4Array;
                    _this.Instance.SetLateLatchProjectionMatrices(projectionMat);
                    var _retCount = _context.Return();
                    return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                }
            }
            throw new global::Lua.LuaRuntimeException(_context.Thread, $"{"SetLateLatchProjectionMatrices"}: invalid argument #{_lastArgPos}: {_lastArg} ({_lastArg.Type}), expected: {_expectedType.FullName}", 2);
        });
        private static readonly global::Lua.LuaFunction _LuaCommandBuffer_SetProjectionMatrix = new global::Lua.LuaFunction("SetProjectionMatrix", (_context, _) =>
        {
            global::Lua.LuaValue _lastArg = default;
            global::System.Int32 _lastArgPos = default;
            global::System.Type _expectedType = default;
            var _argCount = _context.ArgumentCount;
            var _this = _context.GetArgument<LuaCommandBuffer>(0);
            var _arg0 = _lastArg = _argCount > 1 ? _context.GetArgument(1) : global::Lua.LuaValue.Nil;
            _lastArgPos = 0; _expectedType = typeof(global::Luny.UnityEngine.LuaMatrix4x4);
            if (_arg0.TryRead<global::Luny.UnityEngine.LuaMatrix4x4>(out var _p0_UnityEngine_Matrix4x4))
            {
                if (_argCount == 2)
                {
                    var proj = _p0_UnityEngine_Matrix4x4.Value;
                    _this.Instance.SetProjectionMatrix(proj);
                    var _retCount = _context.Return();
                    return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                }
            }
            throw new global::Lua.LuaRuntimeException(_context.Thread, $"{"SetProjectionMatrix"}: invalid argument #{_lastArgPos}: {_lastArg} ({_lastArg.Type}), expected: {_expectedType.FullName}", 2);
        });
        private static readonly global::Lua.LuaFunction _LuaCommandBuffer_SetRandomWriteTarget = new global::Lua.LuaFunction("SetRandomWriteTarget", (_context, _) =>
        {
            global::Lua.LuaValue _lastArg = default;
            global::System.Int32 _lastArgPos = default;
            global::System.Type _expectedType = default;
            var _argCount = _context.ArgumentCount;
            var _this = _context.GetArgument<LuaCommandBuffer>(0);
            var _arg0 = _lastArg = _argCount > 1 ? _context.GetArgument(1) : global::Lua.LuaValue.Nil;
            _lastArgPos = 0; _expectedType = typeof(global::System.Int32);
            if (_arg0.TryRead<global::System.Int32>(out var _p0_System_Int32))
            {
                var _arg1 = _lastArg = _argCount > 2 ? _context.GetArgument(2) : global::Lua.LuaValue.Nil;
                _lastArgPos = 1; _expectedType = typeof(global::Luny.UnityEngine.Rendering.LuaRenderTargetIdentifier);
                if (_arg1.TryRead<global::Luny.UnityEngine.Rendering.LuaRenderTargetIdentifier>(out var _p1_UnityEngine_Rendering_RenderTargetIdentifier))
                {
                    if (_argCount == 3)
                    {
                        var index = _p0_System_Int32;
                        var rt = _p1_UnityEngine_Rendering_RenderTargetIdentifier.Value;
                        _this.Instance.SetRandomWriteTarget(index, rt);
                        var _retCount = _context.Return();
                        return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                    }
                }
                _lastArgPos = 1; _expectedType = typeof(global::Luny.UnityEngine.LuaComputeBuffer);
                if (_arg1.TryRead<global::Luny.UnityEngine.LuaComputeBuffer>(out var _p1_UnityEngine_ComputeBuffer))
                {
                    if (_argCount == 3)
                    {
                        var index = _p0_System_Int32;
                        var buffer = _p1_UnityEngine_ComputeBuffer.Instance;
                        _this.Instance.SetRandomWriteTarget(index, buffer);
                        var _retCount = _context.Return();
                        return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                    }
                    var _arg2 = _lastArg = _argCount > 3 ? _context.GetArgument(3) : global::Lua.LuaValue.Nil;
                    _lastArgPos = 2; _expectedType = typeof(global::System.Boolean);
                    if (_arg2.TryRead<global::System.Boolean>(out var _p2_System_Boolean))
                    {
                        if (_argCount == 4)
                        {
                            var index = _p0_System_Int32;
                            var buffer = _p1_UnityEngine_ComputeBuffer.Instance;
                            var preserveCounterValue = _p2_System_Boolean;
                            _this.Instance.SetRandomWriteTarget(index, buffer, preserveCounterValue);
                            var _retCount = _context.Return();
                            return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                        }
                    }
                }
                _lastArgPos = 1; _expectedType = typeof(global::Luny.UnityEngine.LuaGraphicsBuffer);
                if (_arg1.TryRead<global::Luny.UnityEngine.LuaGraphicsBuffer>(out var _p1_UnityEngine_GraphicsBuffer))
                {
                    if (_argCount == 3)
                    {
                        var index = _p0_System_Int32;
                        var buffer = _p1_UnityEngine_GraphicsBuffer.Instance;
                        _this.Instance.SetRandomWriteTarget(index, buffer);
                        var _retCount = _context.Return();
                        return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                    }
                    var _arg2 = _lastArg = _argCount > 3 ? _context.GetArgument(3) : global::Lua.LuaValue.Nil;
                    _lastArgPos = 2; _expectedType = typeof(global::System.Boolean);
                    if (_arg2.TryRead<global::System.Boolean>(out var _p2_System_Boolean))
                    {
                        if (_argCount == 4)
                        {
                            var index = _p0_System_Int32;
                            var buffer = _p1_UnityEngine_GraphicsBuffer.Instance;
                            var preserveCounterValue = _p2_System_Boolean;
                            _this.Instance.SetRandomWriteTarget(index, buffer, preserveCounterValue);
                            var _retCount = _context.Return();
                            return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                        }
                    }
                }
            }
            throw new global::Lua.LuaRuntimeException(_context.Thread, $"{"SetRandomWriteTarget"}: invalid argument #{_lastArgPos}: {_lastArg} ({_lastArg.Type}), expected: {_expectedType.FullName}", 2);
        });
        private static readonly global::Lua.LuaFunction _LuaCommandBuffer_SetRayTracingAccelerationStructure = new global::Lua.LuaFunction("SetRayTracingAccelerationStructure", (_context, _) =>
        {
            global::Lua.LuaValue _lastArg = default;
            global::System.Int32 _lastArgPos = default;
            global::System.Type _expectedType = default;
            var _argCount = _context.ArgumentCount;
            var _this = _context.GetArgument<LuaCommandBuffer>(0);
            var _arg0 = _lastArg = _argCount > 1 ? _context.GetArgument(1) : global::Lua.LuaValue.Nil;
            _lastArgPos = 0; _expectedType = typeof(global::Luny.UnityEngine.Rendering.LuaRayTracingShader);
            if (_arg0.TryRead<global::Luny.UnityEngine.Rendering.LuaRayTracingShader>(out var _p0_UnityEngine_Rendering_RayTracingShader))
            {
                var _arg1 = _lastArg = _argCount > 2 ? _context.GetArgument(2) : global::Lua.LuaValue.Nil;
                _lastArgPos = 1; _expectedType = typeof(global::System.Int32);
                if (_arg1.TryRead<global::System.Int32>(out var _p1_System_Int32))
                {
                    var _arg2 = _lastArg = _argCount > 3 ? _context.GetArgument(3) : global::Lua.LuaValue.Nil;
                    _lastArgPos = 2; _expectedType = typeof(global::Luny.UnityEngine.Rendering.LuaRayTracingAccelerationStructure);
                    if (_arg2.TryRead<global::Luny.UnityEngine.Rendering.LuaRayTracingAccelerationStructure>(out var _p2_UnityEngine_Rendering_RayTracingAccelerationStructure))
                    {
                        if (_argCount == 4)
                        {
                            var rayTracingShader = _p0_UnityEngine_Rendering_RayTracingShader.Instance;
                            var nameID = _p1_System_Int32;
                            var rayTracingAccelerationStructure = _p2_UnityEngine_Rendering_RayTracingAccelerationStructure.Instance;
                            _this.Instance.SetRayTracingAccelerationStructure(rayTracingShader, nameID, rayTracingAccelerationStructure);
                            var _retCount = _context.Return();
                            return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                        }
                    }
                }
                _lastArgPos = 1; _expectedType = typeof(global::System.String);
                if (_arg1.TryRead<global::System.String>(out var _p1_System_String))
                {
                    var _arg2 = _lastArg = _argCount > 3 ? _context.GetArgument(3) : global::Lua.LuaValue.Nil;
                    _lastArgPos = 2; _expectedType = typeof(global::Luny.UnityEngine.Rendering.LuaRayTracingAccelerationStructure);
                    if (_arg2.TryRead<global::Luny.UnityEngine.Rendering.LuaRayTracingAccelerationStructure>(out var _p2_UnityEngine_Rendering_RayTracingAccelerationStructure))
                    {
                        if (_argCount == 4)
                        {
                            var rayTracingShader = _p0_UnityEngine_Rendering_RayTracingShader.Instance;
                            var name = _p1_System_String;
                            var rayTracingAccelerationStructure = _p2_UnityEngine_Rendering_RayTracingAccelerationStructure.Instance;
                            _this.Instance.SetRayTracingAccelerationStructure(rayTracingShader, name, rayTracingAccelerationStructure);
                            var _retCount = _context.Return();
                            return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                        }
                    }
                }
            }
            _lastArgPos = 0; _expectedType = typeof(global::Luny.UnityEngine.LuaComputeShader);
            if (_arg0.TryRead<global::Luny.UnityEngine.LuaComputeShader>(out var _p0_UnityEngine_ComputeShader))
            {
                var _arg1 = _lastArg = _argCount > 2 ? _context.GetArgument(2) : global::Lua.LuaValue.Nil;
                _lastArgPos = 1; _expectedType = typeof(global::System.Int32);
                if (_arg1.TryRead<global::System.Int32>(out var _p1_System_Int32))
                {
                    var _arg2 = _lastArg = _argCount > 3 ? _context.GetArgument(3) : global::Lua.LuaValue.Nil;
                    _lastArgPos = 2; _expectedType = typeof(global::System.Int32);
                    if (_arg2.TryRead<global::System.Int32>(out var _p2_System_Int32))
                    {
                        var _arg3 = _lastArg = _argCount > 4 ? _context.GetArgument(4) : global::Lua.LuaValue.Nil;
                        _lastArgPos = 3; _expectedType = typeof(global::Luny.UnityEngine.Rendering.LuaRayTracingAccelerationStructure);
                        if (_arg3.TryRead<global::Luny.UnityEngine.Rendering.LuaRayTracingAccelerationStructure>(out var _p3_UnityEngine_Rendering_RayTracingAccelerationStructure))
                        {
                            if (_argCount == 5)
                            {
                                var computeShader = _p0_UnityEngine_ComputeShader.Instance;
                                var kernelIndex = _p1_System_Int32;
                                var nameID = _p2_System_Int32;
                                var rayTracingAccelerationStructure = _p3_UnityEngine_Rendering_RayTracingAccelerationStructure.Instance;
                                _this.Instance.SetRayTracingAccelerationStructure(computeShader, kernelIndex, nameID, rayTracingAccelerationStructure);
                                var _retCount = _context.Return();
                                return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                            }
                        }
                    }
                    _lastArgPos = 2; _expectedType = typeof(global::System.String);
                    if (_arg2.TryRead<global::System.String>(out var _p2_System_String))
                    {
                        var _arg3 = _lastArg = _argCount > 4 ? _context.GetArgument(4) : global::Lua.LuaValue.Nil;
                        _lastArgPos = 3; _expectedType = typeof(global::Luny.UnityEngine.Rendering.LuaRayTracingAccelerationStructure);
                        if (_arg3.TryRead<global::Luny.UnityEngine.Rendering.LuaRayTracingAccelerationStructure>(out var _p3_UnityEngine_Rendering_RayTracingAccelerationStructure))
                        {
                            if (_argCount == 5)
                            {
                                var computeShader = _p0_UnityEngine_ComputeShader.Instance;
                                var kernelIndex = _p1_System_Int32;
                                var name = _p2_System_String;
                                var rayTracingAccelerationStructure = _p3_UnityEngine_Rendering_RayTracingAccelerationStructure.Instance;
                                _this.Instance.SetRayTracingAccelerationStructure(computeShader, kernelIndex, name, rayTracingAccelerationStructure);
                                var _retCount = _context.Return();
                                return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                            }
                        }
                    }
                }
            }
            throw new global::Lua.LuaRuntimeException(_context.Thread, $"{"SetRayTracingAccelerationStructure"}: invalid argument #{_lastArgPos}: {_lastArg} ({_lastArg.Type}), expected: {_expectedType.FullName}", 2);
        });
        private static readonly global::Lua.LuaFunction _LuaCommandBuffer_SetRayTracingBufferParam = new global::Lua.LuaFunction("SetRayTracingBufferParam", (_context, _) =>
        {
            global::Lua.LuaValue _lastArg = default;
            global::System.Int32 _lastArgPos = default;
            global::System.Type _expectedType = default;
            var _argCount = _context.ArgumentCount;
            var _this = _context.GetArgument<LuaCommandBuffer>(0);
            var _arg0 = _lastArg = _argCount > 1 ? _context.GetArgument(1) : global::Lua.LuaValue.Nil;
            _lastArgPos = 0; _expectedType = typeof(global::Luny.UnityEngine.Rendering.LuaRayTracingShader);
            if (_arg0.TryRead<global::Luny.UnityEngine.Rendering.LuaRayTracingShader>(out var _p0_UnityEngine_Rendering_RayTracingShader))
            {
                var _arg1 = _lastArg = _argCount > 2 ? _context.GetArgument(2) : global::Lua.LuaValue.Nil;
                _lastArgPos = 1; _expectedType = typeof(global::System.Int32);
                if (_arg1.TryRead<global::System.Int32>(out var _p1_System_Int32))
                {
                    var _arg2 = _lastArg = _argCount > 3 ? _context.GetArgument(3) : global::Lua.LuaValue.Nil;
                    _lastArgPos = 2; _expectedType = typeof(global::Luny.UnityEngine.LuaGraphicsBufferHandle);
                    if (_arg2.TryRead<global::Luny.UnityEngine.LuaGraphicsBufferHandle>(out var _p2_UnityEngine_GraphicsBufferHandle))
                    {
                        if (_argCount == 4)
                        {
                            var rayTracingShader = _p0_UnityEngine_Rendering_RayTracingShader.Instance;
                            var nameID = _p1_System_Int32;
                            var bufferHandle = _p2_UnityEngine_GraphicsBufferHandle.Value;
                            _this.Instance.SetRayTracingBufferParam(rayTracingShader, nameID, bufferHandle);
                            var _retCount = _context.Return();
                            return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                        }
                    }
                    _lastArgPos = 2; _expectedType = typeof(global::Luny.UnityEngine.LuaComputeBuffer);
                    if (_arg2.TryRead<global::Luny.UnityEngine.LuaComputeBuffer>(out var _p2_UnityEngine_ComputeBuffer))
                    {
                        if (_argCount == 4)
                        {
                            var rayTracingShader = _p0_UnityEngine_Rendering_RayTracingShader.Instance;
                            var nameID = _p1_System_Int32;
                            var buffer = _p2_UnityEngine_ComputeBuffer.Instance;
                            _this.Instance.SetRayTracingBufferParam(rayTracingShader, nameID, buffer);
                            var _retCount = _context.Return();
                            return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                        }
                    }
                    _lastArgPos = 2; _expectedType = typeof(global::Luny.UnityEngine.LuaGraphicsBuffer);
                    if (_arg2.TryRead<global::Luny.UnityEngine.LuaGraphicsBuffer>(out var _p2_UnityEngine_GraphicsBuffer))
                    {
                        if (_argCount == 4)
                        {
                            var rayTracingShader = _p0_UnityEngine_Rendering_RayTracingShader.Instance;
                            var nameID = _p1_System_Int32;
                            var buffer = _p2_UnityEngine_GraphicsBuffer.Instance;
                            _this.Instance.SetRayTracingBufferParam(rayTracingShader, nameID, buffer);
                            var _retCount = _context.Return();
                            return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                        }
                    }
                }
                _lastArgPos = 1; _expectedType = typeof(global::System.String);
                if (_arg1.TryRead<global::System.String>(out var _p1_System_String))
                {
                    var _arg2 = _lastArg = _argCount > 3 ? _context.GetArgument(3) : global::Lua.LuaValue.Nil;
                    _lastArgPos = 2; _expectedType = typeof(global::Luny.UnityEngine.LuaGraphicsBufferHandle);
                    if (_arg2.TryRead<global::Luny.UnityEngine.LuaGraphicsBufferHandle>(out var _p2_UnityEngine_GraphicsBufferHandle))
                    {
                        if (_argCount == 4)
                        {
                            var rayTracingShader = _p0_UnityEngine_Rendering_RayTracingShader.Instance;
                            var name = _p1_System_String;
                            var bufferHandle = _p2_UnityEngine_GraphicsBufferHandle.Value;
                            _this.Instance.SetRayTracingBufferParam(rayTracingShader, name, bufferHandle);
                            var _retCount = _context.Return();
                            return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                        }
                    }
                    _lastArgPos = 2; _expectedType = typeof(global::Luny.UnityEngine.LuaComputeBuffer);
                    if (_arg2.TryRead<global::Luny.UnityEngine.LuaComputeBuffer>(out var _p2_UnityEngine_ComputeBuffer))
                    {
                        if (_argCount == 4)
                        {
                            var rayTracingShader = _p0_UnityEngine_Rendering_RayTracingShader.Instance;
                            var name = _p1_System_String;
                            var buffer = _p2_UnityEngine_ComputeBuffer.Instance;
                            _this.Instance.SetRayTracingBufferParam(rayTracingShader, name, buffer);
                            var _retCount = _context.Return();
                            return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                        }
                    }
                    _lastArgPos = 2; _expectedType = typeof(global::Luny.UnityEngine.LuaGraphicsBuffer);
                    if (_arg2.TryRead<global::Luny.UnityEngine.LuaGraphicsBuffer>(out var _p2_UnityEngine_GraphicsBuffer))
                    {
                        if (_argCount == 4)
                        {
                            var rayTracingShader = _p0_UnityEngine_Rendering_RayTracingShader.Instance;
                            var name = _p1_System_String;
                            var buffer = _p2_UnityEngine_GraphicsBuffer.Instance;
                            _this.Instance.SetRayTracingBufferParam(rayTracingShader, name, buffer);
                            var _retCount = _context.Return();
                            return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                        }
                    }
                }
            }
            throw new global::Lua.LuaRuntimeException(_context.Thread, $"{"SetRayTracingBufferParam"}: invalid argument #{_lastArgPos}: {_lastArg} ({_lastArg.Type}), expected: {_expectedType.FullName}", 2);
        });
        private static readonly global::Lua.LuaFunction _LuaCommandBuffer_SetRayTracingConstantBufferParam = new global::Lua.LuaFunction("SetRayTracingConstantBufferParam", (_context, _) =>
        {
            global::Lua.LuaValue _lastArg = default;
            global::System.Int32 _lastArgPos = default;
            global::System.Type _expectedType = default;
            var _argCount = _context.ArgumentCount;
            var _this = _context.GetArgument<LuaCommandBuffer>(0);
            var _arg0 = _lastArg = _argCount > 1 ? _context.GetArgument(1) : global::Lua.LuaValue.Nil;
            _lastArgPos = 0; _expectedType = typeof(global::Luny.UnityEngine.Rendering.LuaRayTracingShader);
            if (_arg0.TryRead<global::Luny.UnityEngine.Rendering.LuaRayTracingShader>(out var _p0_UnityEngine_Rendering_RayTracingShader))
            {
                var _arg1 = _lastArg = _argCount > 2 ? _context.GetArgument(2) : global::Lua.LuaValue.Nil;
                _lastArgPos = 1; _expectedType = typeof(global::System.Int32);
                if (_arg1.TryRead<global::System.Int32>(out var _p1_System_Int32))
                {
                    var _arg2 = _lastArg = _argCount > 3 ? _context.GetArgument(3) : global::Lua.LuaValue.Nil;
                    _lastArgPos = 2; _expectedType = typeof(global::Luny.UnityEngine.LuaComputeBuffer);
                    if (_arg2.TryRead<global::Luny.UnityEngine.LuaComputeBuffer>(out var _p2_UnityEngine_ComputeBuffer))
                    {
                        var _arg3 = _lastArg = _argCount > 4 ? _context.GetArgument(4) : global::Lua.LuaValue.Nil;
                        _lastArgPos = 3; _expectedType = typeof(global::System.Int32);
                        if (_arg3.TryRead<global::System.Int32>(out var _p3_System_Int32))
                        {
                            var _arg4 = _lastArg = _argCount > 5 ? _context.GetArgument(5) : global::Lua.LuaValue.Nil;
                            _lastArgPos = 4; _expectedType = typeof(global::System.Int32);
                            if (_arg4.TryRead<global::System.Int32>(out var _p4_System_Int32))
                            {
                                if (_argCount == 6)
                                {
                                    var rayTracingShader = _p0_UnityEngine_Rendering_RayTracingShader.Instance;
                                    var nameID = _p1_System_Int32;
                                    var buffer = _p2_UnityEngine_ComputeBuffer.Instance;
                                    var offset = _p3_System_Int32;
                                    var size = _p4_System_Int32;
                                    _this.Instance.SetRayTracingConstantBufferParam(rayTracingShader, nameID, buffer, offset, size);
                                    var _retCount = _context.Return();
                                    return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                                }
                            }
                        }
                    }
                    _lastArgPos = 2; _expectedType = typeof(global::Luny.UnityEngine.LuaGraphicsBuffer);
                    if (_arg2.TryRead<global::Luny.UnityEngine.LuaGraphicsBuffer>(out var _p2_UnityEngine_GraphicsBuffer))
                    {
                        var _arg3 = _lastArg = _argCount > 4 ? _context.GetArgument(4) : global::Lua.LuaValue.Nil;
                        _lastArgPos = 3; _expectedType = typeof(global::System.Int32);
                        if (_arg3.TryRead<global::System.Int32>(out var _p3_System_Int32))
                        {
                            var _arg4 = _lastArg = _argCount > 5 ? _context.GetArgument(5) : global::Lua.LuaValue.Nil;
                            _lastArgPos = 4; _expectedType = typeof(global::System.Int32);
                            if (_arg4.TryRead<global::System.Int32>(out var _p4_System_Int32))
                            {
                                if (_argCount == 6)
                                {
                                    var rayTracingShader = _p0_UnityEngine_Rendering_RayTracingShader.Instance;
                                    var nameID = _p1_System_Int32;
                                    var buffer = _p2_UnityEngine_GraphicsBuffer.Instance;
                                    var offset = _p3_System_Int32;
                                    var size = _p4_System_Int32;
                                    _this.Instance.SetRayTracingConstantBufferParam(rayTracingShader, nameID, buffer, offset, size);
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
                    var _arg2 = _lastArg = _argCount > 3 ? _context.GetArgument(3) : global::Lua.LuaValue.Nil;
                    _lastArgPos = 2; _expectedType = typeof(global::Luny.UnityEngine.LuaComputeBuffer);
                    if (_arg2.TryRead<global::Luny.UnityEngine.LuaComputeBuffer>(out var _p2_UnityEngine_ComputeBuffer))
                    {
                        var _arg3 = _lastArg = _argCount > 4 ? _context.GetArgument(4) : global::Lua.LuaValue.Nil;
                        _lastArgPos = 3; _expectedType = typeof(global::System.Int32);
                        if (_arg3.TryRead<global::System.Int32>(out var _p3_System_Int32))
                        {
                            var _arg4 = _lastArg = _argCount > 5 ? _context.GetArgument(5) : global::Lua.LuaValue.Nil;
                            _lastArgPos = 4; _expectedType = typeof(global::System.Int32);
                            if (_arg4.TryRead<global::System.Int32>(out var _p4_System_Int32))
                            {
                                if (_argCount == 6)
                                {
                                    var rayTracingShader = _p0_UnityEngine_Rendering_RayTracingShader.Instance;
                                    var name = _p1_System_String;
                                    var buffer = _p2_UnityEngine_ComputeBuffer.Instance;
                                    var offset = _p3_System_Int32;
                                    var size = _p4_System_Int32;
                                    _this.Instance.SetRayTracingConstantBufferParam(rayTracingShader, name, buffer, offset, size);
                                    var _retCount = _context.Return();
                                    return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                                }
                            }
                        }
                    }
                    _lastArgPos = 2; _expectedType = typeof(global::Luny.UnityEngine.LuaGraphicsBuffer);
                    if (_arg2.TryRead<global::Luny.UnityEngine.LuaGraphicsBuffer>(out var _p2_UnityEngine_GraphicsBuffer))
                    {
                        var _arg3 = _lastArg = _argCount > 4 ? _context.GetArgument(4) : global::Lua.LuaValue.Nil;
                        _lastArgPos = 3; _expectedType = typeof(global::System.Int32);
                        if (_arg3.TryRead<global::System.Int32>(out var _p3_System_Int32))
                        {
                            var _arg4 = _lastArg = _argCount > 5 ? _context.GetArgument(5) : global::Lua.LuaValue.Nil;
                            _lastArgPos = 4; _expectedType = typeof(global::System.Int32);
                            if (_arg4.TryRead<global::System.Int32>(out var _p4_System_Int32))
                            {
                                if (_argCount == 6)
                                {
                                    var rayTracingShader = _p0_UnityEngine_Rendering_RayTracingShader.Instance;
                                    var name = _p1_System_String;
                                    var buffer = _p2_UnityEngine_GraphicsBuffer.Instance;
                                    var offset = _p3_System_Int32;
                                    var size = _p4_System_Int32;
                                    _this.Instance.SetRayTracingConstantBufferParam(rayTracingShader, name, buffer, offset, size);
                                    var _retCount = _context.Return();
                                    return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                                }
                            }
                        }
                    }
                }
            }
            throw new global::Lua.LuaRuntimeException(_context.Thread, $"{"SetRayTracingConstantBufferParam"}: invalid argument #{_lastArgPos}: {_lastArg} ({_lastArg.Type}), expected: {_expectedType.FullName}", 2);
        });
        private static readonly global::Lua.LuaFunction _LuaCommandBuffer_SetRayTracingFloatParam = new global::Lua.LuaFunction("SetRayTracingFloatParam", (_context, _) =>
        {
            global::Lua.LuaValue _lastArg = default;
            global::System.Int32 _lastArgPos = default;
            global::System.Type _expectedType = default;
            var _argCount = _context.ArgumentCount;
            var _this = _context.GetArgument<LuaCommandBuffer>(0);
            var _arg0 = _lastArg = _argCount > 1 ? _context.GetArgument(1) : global::Lua.LuaValue.Nil;
            _lastArgPos = 0; _expectedType = typeof(global::Luny.UnityEngine.Rendering.LuaRayTracingShader);
            if (_arg0.TryRead<global::Luny.UnityEngine.Rendering.LuaRayTracingShader>(out var _p0_UnityEngine_Rendering_RayTracingShader))
            {
                var _arg1 = _lastArg = _argCount > 2 ? _context.GetArgument(2) : global::Lua.LuaValue.Nil;
                _lastArgPos = 1; _expectedType = typeof(global::System.Int32);
                if (_arg1.TryRead<global::System.Int32>(out var _p1_System_Int32))
                {
                    var _arg2 = _lastArg = _argCount > 3 ? _context.GetArgument(3) : global::Lua.LuaValue.Nil;
                    _lastArgPos = 2; _expectedType = typeof(global::System.Single);
                    if (_arg2.TryRead<global::System.Single>(out var _p2_System_Single))
                    {
                        if (_argCount == 4)
                        {
                            var rayTracingShader = _p0_UnityEngine_Rendering_RayTracingShader.Instance;
                            var nameID = _p1_System_Int32;
                            var val = _p2_System_Single;
                            _this.Instance.SetRayTracingFloatParam(rayTracingShader, nameID, val);
                            var _retCount = _context.Return();
                            return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                        }
                    }
                }
                _lastArgPos = 1; _expectedType = typeof(global::System.String);
                if (_arg1.TryRead<global::System.String>(out var _p1_System_String))
                {
                    var _arg2 = _lastArg = _argCount > 3 ? _context.GetArgument(3) : global::Lua.LuaValue.Nil;
                    _lastArgPos = 2; _expectedType = typeof(global::System.Single);
                    if (_arg2.TryRead<global::System.Single>(out var _p2_System_Single))
                    {
                        if (_argCount == 4)
                        {
                            var rayTracingShader = _p0_UnityEngine_Rendering_RayTracingShader.Instance;
                            var name = _p1_System_String;
                            var val = _p2_System_Single;
                            _this.Instance.SetRayTracingFloatParam(rayTracingShader, name, val);
                            var _retCount = _context.Return();
                            return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                        }
                    }
                }
            }
            throw new global::Lua.LuaRuntimeException(_context.Thread, $"{"SetRayTracingFloatParam"}: invalid argument #{_lastArgPos}: {_lastArg} ({_lastArg.Type}), expected: {_expectedType.FullName}", 2);
        });
        private static readonly global::Lua.LuaFunction _LuaCommandBuffer_SetRayTracingFloatParams = new global::Lua.LuaFunction("SetRayTracingFloatParams", (_context, _) =>
        {
            global::Lua.LuaValue _lastArg = default;
            global::System.Int32 _lastArgPos = default;
            global::System.Type _expectedType = default;
            var _argCount = _context.ArgumentCount;
            var _this = _context.GetArgument<LuaCommandBuffer>(0);
            var _arg0 = _lastArg = _argCount > 1 ? _context.GetArgument(1) : global::Lua.LuaValue.Nil;
            _lastArgPos = 0; _expectedType = typeof(global::Luny.UnityEngine.Rendering.LuaRayTracingShader);
            if (_arg0.TryRead<global::Luny.UnityEngine.Rendering.LuaRayTracingShader>(out var _p0_UnityEngine_Rendering_RayTracingShader))
            {
                var _arg1 = _lastArg = _argCount > 2 ? _context.GetArgument(2) : global::Lua.LuaValue.Nil;
                _lastArgPos = 1; _expectedType = typeof(global::System.Int32);
                if (_arg1.TryRead<global::System.Int32>(out var _p1_System_Int32))
                {
                    var _arg2 = _lastArg = _argCount > 3 ? _context.GetArgument(3) : global::Lua.LuaValue.Nil;
                    _lastArgPos = 2; _expectedType = typeof(global::System.Single[]);
                    if (_arg2.TryReadArray<global::System.Single>(out var _p2_System_SingleArray))
                    {
                        if (_argCount == 4)
                        {
                            var rayTracingShader = _p0_UnityEngine_Rendering_RayTracingShader.Instance;
                            var nameID = _p1_System_Int32;
                            var values = _p2_System_SingleArray;
                            _this.Instance.SetRayTracingFloatParams(rayTracingShader, nameID, values);
                            var _retCount = _context.Return();
                            return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                        }
                    }
                }
                _lastArgPos = 1; _expectedType = typeof(global::System.String);
                if (_arg1.TryRead<global::System.String>(out var _p1_System_String))
                {
                    var _arg2 = _lastArg = _argCount > 3 ? _context.GetArgument(3) : global::Lua.LuaValue.Nil;
                    _lastArgPos = 2; _expectedType = typeof(global::System.Single[]);
                    if (_arg2.TryReadArray<global::System.Single>(out var _p2_System_SingleArray))
                    {
                        if (_argCount == 4)
                        {
                            var rayTracingShader = _p0_UnityEngine_Rendering_RayTracingShader.Instance;
                            var name = _p1_System_String;
                            var values = _p2_System_SingleArray;
                            _this.Instance.SetRayTracingFloatParams(rayTracingShader, name, values);
                            var _retCount = _context.Return();
                            return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                        }
                    }
                }
            }
            throw new global::Lua.LuaRuntimeException(_context.Thread, $"{"SetRayTracingFloatParams"}: invalid argument #{_lastArgPos}: {_lastArg} ({_lastArg.Type}), expected: {_expectedType.FullName}", 2);
        });
        private static readonly global::Lua.LuaFunction _LuaCommandBuffer_SetRayTracingIntParam = new global::Lua.LuaFunction("SetRayTracingIntParam", (_context, _) =>
        {
            global::Lua.LuaValue _lastArg = default;
            global::System.Int32 _lastArgPos = default;
            global::System.Type _expectedType = default;
            var _argCount = _context.ArgumentCount;
            var _this = _context.GetArgument<LuaCommandBuffer>(0);
            var _arg0 = _lastArg = _argCount > 1 ? _context.GetArgument(1) : global::Lua.LuaValue.Nil;
            _lastArgPos = 0; _expectedType = typeof(global::Luny.UnityEngine.Rendering.LuaRayTracingShader);
            if (_arg0.TryRead<global::Luny.UnityEngine.Rendering.LuaRayTracingShader>(out var _p0_UnityEngine_Rendering_RayTracingShader))
            {
                var _arg1 = _lastArg = _argCount > 2 ? _context.GetArgument(2) : global::Lua.LuaValue.Nil;
                _lastArgPos = 1; _expectedType = typeof(global::System.Int32);
                if (_arg1.TryRead<global::System.Int32>(out var _p1_System_Int32))
                {
                    var _arg2 = _lastArg = _argCount > 3 ? _context.GetArgument(3) : global::Lua.LuaValue.Nil;
                    _lastArgPos = 2; _expectedType = typeof(global::System.Int32);
                    if (_arg2.TryRead<global::System.Int32>(out var _p2_System_Int32))
                    {
                        if (_argCount == 4)
                        {
                            var rayTracingShader = _p0_UnityEngine_Rendering_RayTracingShader.Instance;
                            var nameID = _p1_System_Int32;
                            var val = _p2_System_Int32;
                            _this.Instance.SetRayTracingIntParam(rayTracingShader, nameID, val);
                            var _retCount = _context.Return();
                            return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                        }
                    }
                }
                _lastArgPos = 1; _expectedType = typeof(global::System.String);
                if (_arg1.TryRead<global::System.String>(out var _p1_System_String))
                {
                    var _arg2 = _lastArg = _argCount > 3 ? _context.GetArgument(3) : global::Lua.LuaValue.Nil;
                    _lastArgPos = 2; _expectedType = typeof(global::System.Int32);
                    if (_arg2.TryRead<global::System.Int32>(out var _p2_System_Int32))
                    {
                        if (_argCount == 4)
                        {
                            var rayTracingShader = _p0_UnityEngine_Rendering_RayTracingShader.Instance;
                            var name = _p1_System_String;
                            var val = _p2_System_Int32;
                            _this.Instance.SetRayTracingIntParam(rayTracingShader, name, val);
                            var _retCount = _context.Return();
                            return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                        }
                    }
                }
            }
            throw new global::Lua.LuaRuntimeException(_context.Thread, $"{"SetRayTracingIntParam"}: invalid argument #{_lastArgPos}: {_lastArg} ({_lastArg.Type}), expected: {_expectedType.FullName}", 2);
        });
        private static readonly global::Lua.LuaFunction _LuaCommandBuffer_SetRayTracingIntParams = new global::Lua.LuaFunction("SetRayTracingIntParams", (_context, _) =>
        {
            global::Lua.LuaValue _lastArg = default;
            global::System.Int32 _lastArgPos = default;
            global::System.Type _expectedType = default;
            var _argCount = _context.ArgumentCount;
            var _this = _context.GetArgument<LuaCommandBuffer>(0);
            var _arg0 = _lastArg = _argCount > 1 ? _context.GetArgument(1) : global::Lua.LuaValue.Nil;
            _lastArgPos = 0; _expectedType = typeof(global::Luny.UnityEngine.Rendering.LuaRayTracingShader);
            if (_arg0.TryRead<global::Luny.UnityEngine.Rendering.LuaRayTracingShader>(out var _p0_UnityEngine_Rendering_RayTracingShader))
            {
                var _arg1 = _lastArg = _argCount > 2 ? _context.GetArgument(2) : global::Lua.LuaValue.Nil;
                _lastArgPos = 1; _expectedType = typeof(global::System.Int32);
                if (_arg1.TryRead<global::System.Int32>(out var _p1_System_Int32))
                {
                    var _arg2 = _lastArg = _argCount > 3 ? _context.GetArgument(3) : global::Lua.LuaValue.Nil;
                    _lastArgPos = 2; _expectedType = typeof(global::System.Int32[]);
                    if (_arg2.TryReadArray<global::System.Int32>(out var _p2_System_Int32Array))
                    {
                        if (_argCount == 4)
                        {
                            var rayTracingShader = _p0_UnityEngine_Rendering_RayTracingShader.Instance;
                            var nameID = _p1_System_Int32;
                            var values = _p2_System_Int32Array;
                            _this.Instance.SetRayTracingIntParams(rayTracingShader, nameID, values);
                            var _retCount = _context.Return();
                            return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                        }
                    }
                }
                _lastArgPos = 1; _expectedType = typeof(global::System.String);
                if (_arg1.TryRead<global::System.String>(out var _p1_System_String))
                {
                    var _arg2 = _lastArg = _argCount > 3 ? _context.GetArgument(3) : global::Lua.LuaValue.Nil;
                    _lastArgPos = 2; _expectedType = typeof(global::System.Int32[]);
                    if (_arg2.TryReadArray<global::System.Int32>(out var _p2_System_Int32Array))
                    {
                        if (_argCount == 4)
                        {
                            var rayTracingShader = _p0_UnityEngine_Rendering_RayTracingShader.Instance;
                            var name = _p1_System_String;
                            var values = _p2_System_Int32Array;
                            _this.Instance.SetRayTracingIntParams(rayTracingShader, name, values);
                            var _retCount = _context.Return();
                            return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                        }
                    }
                }
            }
            throw new global::Lua.LuaRuntimeException(_context.Thread, $"{"SetRayTracingIntParams"}: invalid argument #{_lastArgPos}: {_lastArg} ({_lastArg.Type}), expected: {_expectedType.FullName}", 2);
        });
        private static readonly global::Lua.LuaFunction _LuaCommandBuffer_SetRayTracingMatrixArrayParam = new global::Lua.LuaFunction("SetRayTracingMatrixArrayParam", (_context, _) =>
        {
            global::Lua.LuaValue _lastArg = default;
            global::System.Int32 _lastArgPos = default;
            global::System.Type _expectedType = default;
            var _argCount = _context.ArgumentCount;
            var _this = _context.GetArgument<LuaCommandBuffer>(0);
            var _arg0 = _lastArg = _argCount > 1 ? _context.GetArgument(1) : global::Lua.LuaValue.Nil;
            _lastArgPos = 0; _expectedType = typeof(global::Luny.UnityEngine.Rendering.LuaRayTracingShader);
            if (_arg0.TryRead<global::Luny.UnityEngine.Rendering.LuaRayTracingShader>(out var _p0_UnityEngine_Rendering_RayTracingShader))
            {
                var _arg1 = _lastArg = _argCount > 2 ? _context.GetArgument(2) : global::Lua.LuaValue.Nil;
                _lastArgPos = 1; _expectedType = typeof(global::System.Int32);
                if (_arg1.TryRead<global::System.Int32>(out var _p1_System_Int32))
                {
                    var _arg2 = _lastArg = _argCount > 3 ? _context.GetArgument(3) : global::Lua.LuaValue.Nil;
                    _lastArgPos = 2; _expectedType = typeof(global::UnityEngine.Matrix4x4[]);
                    if (_arg2.TryReadArray<global::UnityEngine.Matrix4x4>(out var _p2_UnityEngine_Matrix4x4Array))
                    {
                        if (_argCount == 4)
                        {
                            var rayTracingShader = _p0_UnityEngine_Rendering_RayTracingShader.Instance;
                            var nameID = _p1_System_Int32;
                            var values = _p2_UnityEngine_Matrix4x4Array;
                            _this.Instance.SetRayTracingMatrixArrayParam(rayTracingShader, nameID, values);
                            var _retCount = _context.Return();
                            return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                        }
                    }
                }
                _lastArgPos = 1; _expectedType = typeof(global::System.String);
                if (_arg1.TryRead<global::System.String>(out var _p1_System_String))
                {
                    var _arg2 = _lastArg = _argCount > 3 ? _context.GetArgument(3) : global::Lua.LuaValue.Nil;
                    _lastArgPos = 2; _expectedType = typeof(global::UnityEngine.Matrix4x4[]);
                    if (_arg2.TryReadArray<global::UnityEngine.Matrix4x4>(out var _p2_UnityEngine_Matrix4x4Array))
                    {
                        if (_argCount == 4)
                        {
                            var rayTracingShader = _p0_UnityEngine_Rendering_RayTracingShader.Instance;
                            var name = _p1_System_String;
                            var values = _p2_UnityEngine_Matrix4x4Array;
                            _this.Instance.SetRayTracingMatrixArrayParam(rayTracingShader, name, values);
                            var _retCount = _context.Return();
                            return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                        }
                    }
                }
            }
            throw new global::Lua.LuaRuntimeException(_context.Thread, $"{"SetRayTracingMatrixArrayParam"}: invalid argument #{_lastArgPos}: {_lastArg} ({_lastArg.Type}), expected: {_expectedType.FullName}", 2);
        });
        private static readonly global::Lua.LuaFunction _LuaCommandBuffer_SetRayTracingMatrixParam = new global::Lua.LuaFunction("SetRayTracingMatrixParam", (_context, _) =>
        {
            global::Lua.LuaValue _lastArg = default;
            global::System.Int32 _lastArgPos = default;
            global::System.Type _expectedType = default;
            var _argCount = _context.ArgumentCount;
            var _this = _context.GetArgument<LuaCommandBuffer>(0);
            var _arg0 = _lastArg = _argCount > 1 ? _context.GetArgument(1) : global::Lua.LuaValue.Nil;
            _lastArgPos = 0; _expectedType = typeof(global::Luny.UnityEngine.Rendering.LuaRayTracingShader);
            if (_arg0.TryRead<global::Luny.UnityEngine.Rendering.LuaRayTracingShader>(out var _p0_UnityEngine_Rendering_RayTracingShader))
            {
                var _arg1 = _lastArg = _argCount > 2 ? _context.GetArgument(2) : global::Lua.LuaValue.Nil;
                _lastArgPos = 1; _expectedType = typeof(global::System.Int32);
                if (_arg1.TryRead<global::System.Int32>(out var _p1_System_Int32))
                {
                    var _arg2 = _lastArg = _argCount > 3 ? _context.GetArgument(3) : global::Lua.LuaValue.Nil;
                    _lastArgPos = 2; _expectedType = typeof(global::Luny.UnityEngine.LuaMatrix4x4);
                    if (_arg2.TryRead<global::Luny.UnityEngine.LuaMatrix4x4>(out var _p2_UnityEngine_Matrix4x4))
                    {
                        if (_argCount == 4)
                        {
                            var rayTracingShader = _p0_UnityEngine_Rendering_RayTracingShader.Instance;
                            var nameID = _p1_System_Int32;
                            var val = _p2_UnityEngine_Matrix4x4.Value;
                            _this.Instance.SetRayTracingMatrixParam(rayTracingShader, nameID, val);
                            var _retCount = _context.Return();
                            return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                        }
                    }
                }
                _lastArgPos = 1; _expectedType = typeof(global::System.String);
                if (_arg1.TryRead<global::System.String>(out var _p1_System_String))
                {
                    var _arg2 = _lastArg = _argCount > 3 ? _context.GetArgument(3) : global::Lua.LuaValue.Nil;
                    _lastArgPos = 2; _expectedType = typeof(global::Luny.UnityEngine.LuaMatrix4x4);
                    if (_arg2.TryRead<global::Luny.UnityEngine.LuaMatrix4x4>(out var _p2_UnityEngine_Matrix4x4))
                    {
                        if (_argCount == 4)
                        {
                            var rayTracingShader = _p0_UnityEngine_Rendering_RayTracingShader.Instance;
                            var name = _p1_System_String;
                            var val = _p2_UnityEngine_Matrix4x4.Value;
                            _this.Instance.SetRayTracingMatrixParam(rayTracingShader, name, val);
                            var _retCount = _context.Return();
                            return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                        }
                    }
                }
            }
            throw new global::Lua.LuaRuntimeException(_context.Thread, $"{"SetRayTracingMatrixParam"}: invalid argument #{_lastArgPos}: {_lastArg} ({_lastArg.Type}), expected: {_expectedType.FullName}", 2);
        });
        private static readonly global::Lua.LuaFunction _LuaCommandBuffer_SetRayTracingShaderPass = new global::Lua.LuaFunction("SetRayTracingShaderPass", (_context, _) =>
        {
            global::Lua.LuaValue _lastArg = default;
            global::System.Int32 _lastArgPos = default;
            global::System.Type _expectedType = default;
            var _argCount = _context.ArgumentCount;
            var _this = _context.GetArgument<LuaCommandBuffer>(0);
            var _arg0 = _lastArg = _argCount > 1 ? _context.GetArgument(1) : global::Lua.LuaValue.Nil;
            _lastArgPos = 0; _expectedType = typeof(global::Luny.UnityEngine.Rendering.LuaRayTracingShader);
            if (_arg0.TryRead<global::Luny.UnityEngine.Rendering.LuaRayTracingShader>(out var _p0_UnityEngine_Rendering_RayTracingShader))
            {
                var _arg1 = _lastArg = _argCount > 2 ? _context.GetArgument(2) : global::Lua.LuaValue.Nil;
                _lastArgPos = 1; _expectedType = typeof(global::System.String);
                if (_arg1.TryRead<global::System.String>(out var _p1_System_String))
                {
                    if (_argCount == 3)
                    {
                        var rayTracingShader = _p0_UnityEngine_Rendering_RayTracingShader.Instance;
                        var passName = _p1_System_String;
                        _this.Instance.SetRayTracingShaderPass(rayTracingShader, passName);
                        var _retCount = _context.Return();
                        return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                    }
                }
            }
            throw new global::Lua.LuaRuntimeException(_context.Thread, $"{"SetRayTracingShaderPass"}: invalid argument #{_lastArgPos}: {_lastArg} ({_lastArg.Type}), expected: {_expectedType.FullName}", 2);
        });
        private static readonly global::Lua.LuaFunction _LuaCommandBuffer_SetRayTracingTextureParam = new global::Lua.LuaFunction("SetRayTracingTextureParam", (_context, _) =>
        {
            global::Lua.LuaValue _lastArg = default;
            global::System.Int32 _lastArgPos = default;
            global::System.Type _expectedType = default;
            var _argCount = _context.ArgumentCount;
            var _this = _context.GetArgument<LuaCommandBuffer>(0);
            var _arg0 = _lastArg = _argCount > 1 ? _context.GetArgument(1) : global::Lua.LuaValue.Nil;
            _lastArgPos = 0; _expectedType = typeof(global::Luny.UnityEngine.Rendering.LuaRayTracingShader);
            if (_arg0.TryRead<global::Luny.UnityEngine.Rendering.LuaRayTracingShader>(out var _p0_UnityEngine_Rendering_RayTracingShader))
            {
                var _arg1 = _lastArg = _argCount > 2 ? _context.GetArgument(2) : global::Lua.LuaValue.Nil;
                _lastArgPos = 1; _expectedType = typeof(global::System.Int32);
                if (_arg1.TryRead<global::System.Int32>(out var _p1_System_Int32))
                {
                    var _arg2 = _lastArg = _argCount > 3 ? _context.GetArgument(3) : global::Lua.LuaValue.Nil;
                    _lastArgPos = 2; _expectedType = typeof(global::Luny.UnityEngine.Rendering.LuaRenderTargetIdentifier);
                    if (_arg2.TryRead<global::Luny.UnityEngine.Rendering.LuaRenderTargetIdentifier>(out var _p2_UnityEngine_Rendering_RenderTargetIdentifier))
                    {
                        if (_argCount == 4)
                        {
                            var rayTracingShader = _p0_UnityEngine_Rendering_RayTracingShader.Instance;
                            var nameID = _p1_System_Int32;
                            var rt = _p2_UnityEngine_Rendering_RenderTargetIdentifier.Value;
                            _this.Instance.SetRayTracingTextureParam(rayTracingShader, nameID, rt);
                            var _retCount = _context.Return();
                            return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                        }
                    }
                }
                _lastArgPos = 1; _expectedType = typeof(global::System.String);
                if (_arg1.TryRead<global::System.String>(out var _p1_System_String))
                {
                    var _arg2 = _lastArg = _argCount > 3 ? _context.GetArgument(3) : global::Lua.LuaValue.Nil;
                    _lastArgPos = 2; _expectedType = typeof(global::Luny.UnityEngine.Rendering.LuaRenderTargetIdentifier);
                    if (_arg2.TryRead<global::Luny.UnityEngine.Rendering.LuaRenderTargetIdentifier>(out var _p2_UnityEngine_Rendering_RenderTargetIdentifier))
                    {
                        if (_argCount == 4)
                        {
                            var rayTracingShader = _p0_UnityEngine_Rendering_RayTracingShader.Instance;
                            var name = _p1_System_String;
                            var rt = _p2_UnityEngine_Rendering_RenderTargetIdentifier.Value;
                            _this.Instance.SetRayTracingTextureParam(rayTracingShader, name, rt);
                            var _retCount = _context.Return();
                            return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                        }
                    }
                }
            }
            throw new global::Lua.LuaRuntimeException(_context.Thread, $"{"SetRayTracingTextureParam"}: invalid argument #{_lastArgPos}: {_lastArg} ({_lastArg.Type}), expected: {_expectedType.FullName}", 2);
        });
        private static readonly global::Lua.LuaFunction _LuaCommandBuffer_SetRayTracingVectorArrayParam = new global::Lua.LuaFunction("SetRayTracingVectorArrayParam", (_context, _) =>
        {
            global::Lua.LuaValue _lastArg = default;
            global::System.Int32 _lastArgPos = default;
            global::System.Type _expectedType = default;
            var _argCount = _context.ArgumentCount;
            var _this = _context.GetArgument<LuaCommandBuffer>(0);
            var _arg0 = _lastArg = _argCount > 1 ? _context.GetArgument(1) : global::Lua.LuaValue.Nil;
            _lastArgPos = 0; _expectedType = typeof(global::Luny.UnityEngine.Rendering.LuaRayTracingShader);
            if (_arg0.TryRead<global::Luny.UnityEngine.Rendering.LuaRayTracingShader>(out var _p0_UnityEngine_Rendering_RayTracingShader))
            {
                var _arg1 = _lastArg = _argCount > 2 ? _context.GetArgument(2) : global::Lua.LuaValue.Nil;
                _lastArgPos = 1; _expectedType = typeof(global::System.Int32);
                if (_arg1.TryRead<global::System.Int32>(out var _p1_System_Int32))
                {
                    var _arg2 = _lastArg = _argCount > 3 ? _context.GetArgument(3) : global::Lua.LuaValue.Nil;
                    _lastArgPos = 2; _expectedType = typeof(global::UnityEngine.Vector4[]);
                    if (_arg2.TryReadArray<global::UnityEngine.Vector4>(out var _p2_UnityEngine_Vector4Array))
                    {
                        if (_argCount == 4)
                        {
                            var rayTracingShader = _p0_UnityEngine_Rendering_RayTracingShader.Instance;
                            var nameID = _p1_System_Int32;
                            var values = _p2_UnityEngine_Vector4Array;
                            _this.Instance.SetRayTracingVectorArrayParam(rayTracingShader, nameID, values);
                            var _retCount = _context.Return();
                            return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                        }
                    }
                }
                _lastArgPos = 1; _expectedType = typeof(global::System.String);
                if (_arg1.TryRead<global::System.String>(out var _p1_System_String))
                {
                    var _arg2 = _lastArg = _argCount > 3 ? _context.GetArgument(3) : global::Lua.LuaValue.Nil;
                    _lastArgPos = 2; _expectedType = typeof(global::UnityEngine.Vector4[]);
                    if (_arg2.TryReadArray<global::UnityEngine.Vector4>(out var _p2_UnityEngine_Vector4Array))
                    {
                        if (_argCount == 4)
                        {
                            var rayTracingShader = _p0_UnityEngine_Rendering_RayTracingShader.Instance;
                            var name = _p1_System_String;
                            var values = _p2_UnityEngine_Vector4Array;
                            _this.Instance.SetRayTracingVectorArrayParam(rayTracingShader, name, values);
                            var _retCount = _context.Return();
                            return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                        }
                    }
                }
            }
            throw new global::Lua.LuaRuntimeException(_context.Thread, $"{"SetRayTracingVectorArrayParam"}: invalid argument #{_lastArgPos}: {_lastArg} ({_lastArg.Type}), expected: {_expectedType.FullName}", 2);
        });
        private static readonly global::Lua.LuaFunction _LuaCommandBuffer_SetRayTracingVectorParam = new global::Lua.LuaFunction("SetRayTracingVectorParam", (_context, _) =>
        {
            global::Lua.LuaValue _lastArg = default;
            global::System.Int32 _lastArgPos = default;
            global::System.Type _expectedType = default;
            var _argCount = _context.ArgumentCount;
            var _this = _context.GetArgument<LuaCommandBuffer>(0);
            var _arg0 = _lastArg = _argCount > 1 ? _context.GetArgument(1) : global::Lua.LuaValue.Nil;
            _lastArgPos = 0; _expectedType = typeof(global::Luny.UnityEngine.Rendering.LuaRayTracingShader);
            if (_arg0.TryRead<global::Luny.UnityEngine.Rendering.LuaRayTracingShader>(out var _p0_UnityEngine_Rendering_RayTracingShader))
            {
                var _arg1 = _lastArg = _argCount > 2 ? _context.GetArgument(2) : global::Lua.LuaValue.Nil;
                _lastArgPos = 1; _expectedType = typeof(global::System.Int32);
                if (_arg1.TryRead<global::System.Int32>(out var _p1_System_Int32))
                {
                    var _arg2 = _lastArg = _argCount > 3 ? _context.GetArgument(3) : global::Lua.LuaValue.Nil;
                    _lastArgPos = 2; _expectedType = typeof(global::Luny.UnityEngine.LuaVector4);
                    if (_arg2.TryRead<global::Luny.UnityEngine.LuaVector4>(out var _p2_UnityEngine_Vector4))
                    {
                        if (_argCount == 4)
                        {
                            var rayTracingShader = _p0_UnityEngine_Rendering_RayTracingShader.Instance;
                            var nameID = _p1_System_Int32;
                            var val = _p2_UnityEngine_Vector4.Value;
                            _this.Instance.SetRayTracingVectorParam(rayTracingShader, nameID, val);
                            var _retCount = _context.Return();
                            return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                        }
                    }
                }
                _lastArgPos = 1; _expectedType = typeof(global::System.String);
                if (_arg1.TryRead<global::System.String>(out var _p1_System_String))
                {
                    var _arg2 = _lastArg = _argCount > 3 ? _context.GetArgument(3) : global::Lua.LuaValue.Nil;
                    _lastArgPos = 2; _expectedType = typeof(global::Luny.UnityEngine.LuaVector4);
                    if (_arg2.TryRead<global::Luny.UnityEngine.LuaVector4>(out var _p2_UnityEngine_Vector4))
                    {
                        if (_argCount == 4)
                        {
                            var rayTracingShader = _p0_UnityEngine_Rendering_RayTracingShader.Instance;
                            var name = _p1_System_String;
                            var val = _p2_UnityEngine_Vector4.Value;
                            _this.Instance.SetRayTracingVectorParam(rayTracingShader, name, val);
                            var _retCount = _context.Return();
                            return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                        }
                    }
                }
            }
            throw new global::Lua.LuaRuntimeException(_context.Thread, $"{"SetRayTracingVectorParam"}: invalid argument #{_lastArgPos}: {_lastArg} ({_lastArg.Type}), expected: {_expectedType.FullName}", 2);
        });
        private static readonly global::Lua.LuaFunction _LuaCommandBuffer_SetRenderTarget = new global::Lua.LuaFunction("SetRenderTarget", (_context, _) =>
        {
            global::Lua.LuaValue _lastArg = default;
            global::System.Int32 _lastArgPos = default;
            global::System.Type _expectedType = default;
            var _argCount = _context.ArgumentCount;
            var _this = _context.GetArgument<LuaCommandBuffer>(0);
            var _arg0 = _lastArg = _argCount > 1 ? _context.GetArgument(1) : global::Lua.LuaValue.Nil;
            _lastArgPos = 0; _expectedType = typeof(global::Luny.UnityEngine.Rendering.LuaRenderTargetIdentifier);
            if (_arg0.TryRead<global::Luny.UnityEngine.Rendering.LuaRenderTargetIdentifier>(out var _p0_UnityEngine_Rendering_RenderTargetIdentifier))
            {
                if (_argCount == 2)
                {
                    var rt = _p0_UnityEngine_Rendering_RenderTargetIdentifier.Value;
                    _this.Instance.SetRenderTarget(rt);
                    var _retCount = _context.Return();
                    return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                }
                var _arg1 = _lastArg = _argCount > 2 ? _context.GetArgument(2) : global::Lua.LuaValue.Nil;
                _lastArgPos = 1; _expectedType = typeof(global::System.Int32);
                if (_arg1.TryRead<global::System.Int32>(out var _p1_System_Int32))
                {
                    if (_argCount == 3)
                    {
                        var rt = _p0_UnityEngine_Rendering_RenderTargetIdentifier.Value;
                        var mipLevel = _p1_System_Int32;
                        _this.Instance.SetRenderTarget(rt, mipLevel);
                        var _retCount = _context.Return();
                        return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                    }
                    var _arg2 = _lastArg = _argCount > 3 ? _context.GetArgument(3) : global::Lua.LuaValue.Nil;
                    _lastArgPos = 2; _expectedType = typeof(global::UnityEngine.CubemapFace);
                    if (_arg2.TryRead<global::UnityEngine.CubemapFace>(out var _p2_UnityEngine_CubemapFace))
                    {
                        if (_argCount == 4)
                        {
                            var rt = _p0_UnityEngine_Rendering_RenderTargetIdentifier.Value;
                            var mipLevel = _p1_System_Int32;
                            var cubemapFace = _p2_UnityEngine_CubemapFace;
                            _this.Instance.SetRenderTarget(rt, mipLevel, cubemapFace);
                            var _retCount = _context.Return();
                            return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                        }
                        var _arg3 = _lastArg = _argCount > 4 ? _context.GetArgument(4) : global::Lua.LuaValue.Nil;
                        _lastArgPos = 3; _expectedType = typeof(global::System.Int32);
                        if (_arg3.TryRead<global::System.Int32>(out var _p3_System_Int32))
                        {
                            if (_argCount == 5)
                            {
                                var rt = _p0_UnityEngine_Rendering_RenderTargetIdentifier.Value;
                                var mipLevel = _p1_System_Int32;
                                var cubemapFace = _p2_UnityEngine_CubemapFace;
                                var depthSlice = _p3_System_Int32;
                                _this.Instance.SetRenderTarget(rt, mipLevel, cubemapFace, depthSlice);
                                var _retCount = _context.Return();
                                return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                            }
                        }
                    }
                }
                _lastArgPos = 1; _expectedType = typeof(global::Luny.UnityEngine.Rendering.LuaRenderTargetIdentifier);
                if (_arg1.TryRead<global::Luny.UnityEngine.Rendering.LuaRenderTargetIdentifier>(out var _p1_UnityEngine_Rendering_RenderTargetIdentifier))
                {
                    if (_argCount == 3)
                    {
                        var color = _p0_UnityEngine_Rendering_RenderTargetIdentifier.Value;
                        var depth = _p1_UnityEngine_Rendering_RenderTargetIdentifier.Value;
                        _this.Instance.SetRenderTarget(color, depth);
                        var _retCount = _context.Return();
                        return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                    }
                    var _arg2 = _lastArg = _argCount > 3 ? _context.GetArgument(3) : global::Lua.LuaValue.Nil;
                    _lastArgPos = 2; _expectedType = typeof(global::System.Int32);
                    if (_arg2.TryRead<global::System.Int32>(out var _p2_System_Int32))
                    {
                        if (_argCount == 4)
                        {
                            var color = _p0_UnityEngine_Rendering_RenderTargetIdentifier.Value;
                            var depth = _p1_UnityEngine_Rendering_RenderTargetIdentifier.Value;
                            var mipLevel = _p2_System_Int32;
                            _this.Instance.SetRenderTarget(color, depth, mipLevel);
                            var _retCount = _context.Return();
                            return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                        }
                        var _arg3 = _lastArg = _argCount > 4 ? _context.GetArgument(4) : global::Lua.LuaValue.Nil;
                        _lastArgPos = 3; _expectedType = typeof(global::UnityEngine.CubemapFace);
                        if (_arg3.TryRead<global::UnityEngine.CubemapFace>(out var _p3_UnityEngine_CubemapFace))
                        {
                            if (_argCount == 5)
                            {
                                var color = _p0_UnityEngine_Rendering_RenderTargetIdentifier.Value;
                                var depth = _p1_UnityEngine_Rendering_RenderTargetIdentifier.Value;
                                var mipLevel = _p2_System_Int32;
                                var cubemapFace = _p3_UnityEngine_CubemapFace;
                                _this.Instance.SetRenderTarget(color, depth, mipLevel, cubemapFace);
                                var _retCount = _context.Return();
                                return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                            }
                            var _arg4 = _lastArg = _argCount > 5 ? _context.GetArgument(5) : global::Lua.LuaValue.Nil;
                            _lastArgPos = 4; _expectedType = typeof(global::System.Int32);
                            if (_arg4.TryRead<global::System.Int32>(out var _p4_System_Int32))
                            {
                                if (_argCount == 6)
                                {
                                    var color = _p0_UnityEngine_Rendering_RenderTargetIdentifier.Value;
                                    var depth = _p1_UnityEngine_Rendering_RenderTargetIdentifier.Value;
                                    var mipLevel = _p2_System_Int32;
                                    var cubemapFace = _p3_UnityEngine_CubemapFace;
                                    var depthSlice = _p4_System_Int32;
                                    _this.Instance.SetRenderTarget(color, depth, mipLevel, cubemapFace, depthSlice);
                                    var _retCount = _context.Return();
                                    return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                                }
                            }
                        }
                    }
                }
                _lastArgPos = 1; _expectedType = typeof(global::UnityEngine.Rendering.RenderBufferLoadAction);
                if (_arg1.TryRead<global::UnityEngine.Rendering.RenderBufferLoadAction>(out var _p1_UnityEngine_Rendering_RenderBufferLoadAction))
                {
                    var _arg2 = _lastArg = _argCount > 3 ? _context.GetArgument(3) : global::Lua.LuaValue.Nil;
                    _lastArgPos = 2; _expectedType = typeof(global::UnityEngine.Rendering.RenderBufferStoreAction);
                    if (_arg2.TryRead<global::UnityEngine.Rendering.RenderBufferStoreAction>(out var _p2_UnityEngine_Rendering_RenderBufferStoreAction))
                    {
                        if (_argCount == 4)
                        {
                            var rt = _p0_UnityEngine_Rendering_RenderTargetIdentifier.Value;
                            var loadAction = _p1_UnityEngine_Rendering_RenderBufferLoadAction;
                            var storeAction = _p2_UnityEngine_Rendering_RenderBufferStoreAction;
                            _this.Instance.SetRenderTarget(rt, loadAction, storeAction);
                            var _retCount = _context.Return();
                            return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                        }
                        var _arg3 = _lastArg = _argCount > 4 ? _context.GetArgument(4) : global::Lua.LuaValue.Nil;
                        _lastArgPos = 3; _expectedType = typeof(global::UnityEngine.Rendering.RenderBufferLoadAction);
                        if (_arg3.TryRead<global::UnityEngine.Rendering.RenderBufferLoadAction>(out var _p3_UnityEngine_Rendering_RenderBufferLoadAction))
                        {
                            var _arg4 = _lastArg = _argCount > 5 ? _context.GetArgument(5) : global::Lua.LuaValue.Nil;
                            _lastArgPos = 4; _expectedType = typeof(global::UnityEngine.Rendering.RenderBufferStoreAction);
                            if (_arg4.TryRead<global::UnityEngine.Rendering.RenderBufferStoreAction>(out var _p4_UnityEngine_Rendering_RenderBufferStoreAction))
                            {
                                if (_argCount == 6)
                                {
                                    var rt = _p0_UnityEngine_Rendering_RenderTargetIdentifier.Value;
                                    var colorLoadAction = _p1_UnityEngine_Rendering_RenderBufferLoadAction;
                                    var colorStoreAction = _p2_UnityEngine_Rendering_RenderBufferStoreAction;
                                    var depthLoadAction = _p3_UnityEngine_Rendering_RenderBufferLoadAction;
                                    var depthStoreAction = _p4_UnityEngine_Rendering_RenderBufferStoreAction;
                                    _this.Instance.SetRenderTarget(rt, colorLoadAction, colorStoreAction, depthLoadAction, depthStoreAction);
                                    var _retCount = _context.Return();
                                    return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                                }
                            }
                        }
                        _lastArgPos = 3; _expectedType = typeof(global::Luny.UnityEngine.Rendering.LuaRenderTargetIdentifier);
                        if (_arg3.TryRead<global::Luny.UnityEngine.Rendering.LuaRenderTargetIdentifier>(out var _p3_UnityEngine_Rendering_RenderTargetIdentifier))
                        {
                            var _arg4 = _lastArg = _argCount > 5 ? _context.GetArgument(5) : global::Lua.LuaValue.Nil;
                            _lastArgPos = 4; _expectedType = typeof(global::UnityEngine.Rendering.RenderBufferLoadAction);
                            if (_arg4.TryRead<global::UnityEngine.Rendering.RenderBufferLoadAction>(out var _p4_UnityEngine_Rendering_RenderBufferLoadAction))
                            {
                                var _arg5 = _lastArg = _argCount > 6 ? _context.GetArgument(6) : global::Lua.LuaValue.Nil;
                                _lastArgPos = 5; _expectedType = typeof(global::UnityEngine.Rendering.RenderBufferStoreAction);
                                if (_arg5.TryRead<global::UnityEngine.Rendering.RenderBufferStoreAction>(out var _p5_UnityEngine_Rendering_RenderBufferStoreAction))
                                {
                                    if (_argCount == 7)
                                    {
                                        var color = _p0_UnityEngine_Rendering_RenderTargetIdentifier.Value;
                                        var colorLoadAction = _p1_UnityEngine_Rendering_RenderBufferLoadAction;
                                        var colorStoreAction = _p2_UnityEngine_Rendering_RenderBufferStoreAction;
                                        var depth = _p3_UnityEngine_Rendering_RenderTargetIdentifier.Value;
                                        var depthLoadAction = _p4_UnityEngine_Rendering_RenderBufferLoadAction;
                                        var depthStoreAction = _p5_UnityEngine_Rendering_RenderBufferStoreAction;
                                        _this.Instance.SetRenderTarget(color, colorLoadAction, colorStoreAction, depth, depthLoadAction, depthStoreAction);
                                        var _retCount = _context.Return();
                                        return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                                    }
                                }
                            }
                        }
                    }
                }
            }
            _lastArgPos = 0; _expectedType = typeof(global::Luny.UnityEngine.Rendering.LuaRenderTargetBinding);
            if (_arg0.TryRead<global::Luny.UnityEngine.Rendering.LuaRenderTargetBinding>(out var _p0_UnityEngine_Rendering_RenderTargetBinding))
            {
                if (_argCount == 2)
                {
                    var binding = _p0_UnityEngine_Rendering_RenderTargetBinding.Value;
                    _this.Instance.SetRenderTarget(binding);
                    var _retCount = _context.Return();
                    return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                }
                var _arg1 = _lastArg = _argCount > 2 ? _context.GetArgument(2) : global::Lua.LuaValue.Nil;
                _lastArgPos = 1; _expectedType = typeof(global::System.Int32);
                if (_arg1.TryRead<global::System.Int32>(out var _p1_System_Int32))
                {
                    var _arg2 = _lastArg = _argCount > 3 ? _context.GetArgument(3) : global::Lua.LuaValue.Nil;
                    _lastArgPos = 2; _expectedType = typeof(global::UnityEngine.CubemapFace);
                    if (_arg2.TryRead<global::UnityEngine.CubemapFace>(out var _p2_UnityEngine_CubemapFace))
                    {
                        var _arg3 = _lastArg = _argCount > 4 ? _context.GetArgument(4) : global::Lua.LuaValue.Nil;
                        _lastArgPos = 3; _expectedType = typeof(global::System.Int32);
                        if (_arg3.TryRead<global::System.Int32>(out var _p3_System_Int32))
                        {
                            if (_argCount == 5)
                            {
                                var binding = _p0_UnityEngine_Rendering_RenderTargetBinding.Value;
                                var mipLevel = _p1_System_Int32;
                                var cubemapFace = _p2_UnityEngine_CubemapFace;
                                var depthSlice = _p3_System_Int32;
                                _this.Instance.SetRenderTarget(binding, mipLevel, cubemapFace, depthSlice);
                                var _retCount = _context.Return();
                                return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                            }
                        }
                    }
                }
            }
            _lastArgPos = 0; _expectedType = typeof(global::UnityEngine.Rendering.RenderTargetIdentifier[]);
            if (_arg0.TryReadArray<global::UnityEngine.Rendering.RenderTargetIdentifier>(out var _p0_UnityEngine_Rendering_RenderTargetIdentifierArray))
            {
                var _arg1 = _lastArg = _argCount > 2 ? _context.GetArgument(2) : global::Lua.LuaValue.Nil;
                _lastArgPos = 1; _expectedType = typeof(global::Luny.UnityEngine.Rendering.LuaRenderTargetIdentifier);
                if (_arg1.TryRead<global::Luny.UnityEngine.Rendering.LuaRenderTargetIdentifier>(out var _p1_UnityEngine_Rendering_RenderTargetIdentifier))
                {
                    if (_argCount == 3)
                    {
                        var colors = _p0_UnityEngine_Rendering_RenderTargetIdentifierArray;
                        var depth = _p1_UnityEngine_Rendering_RenderTargetIdentifier.Value;
                        _this.Instance.SetRenderTarget(colors, depth);
                        var _retCount = _context.Return();
                        return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                    }
                    var _arg2 = _lastArg = _argCount > 3 ? _context.GetArgument(3) : global::Lua.LuaValue.Nil;
                    _lastArgPos = 2; _expectedType = typeof(global::System.Int32);
                    if (_arg2.TryRead<global::System.Int32>(out var _p2_System_Int32))
                    {
                        var _arg3 = _lastArg = _argCount > 4 ? _context.GetArgument(4) : global::Lua.LuaValue.Nil;
                        _lastArgPos = 3; _expectedType = typeof(global::UnityEngine.CubemapFace);
                        if (_arg3.TryRead<global::UnityEngine.CubemapFace>(out var _p3_UnityEngine_CubemapFace))
                        {
                            var _arg4 = _lastArg = _argCount > 5 ? _context.GetArgument(5) : global::Lua.LuaValue.Nil;
                            _lastArgPos = 4; _expectedType = typeof(global::System.Int32);
                            if (_arg4.TryRead<global::System.Int32>(out var _p4_System_Int32))
                            {
                                if (_argCount == 6)
                                {
                                    var colors = _p0_UnityEngine_Rendering_RenderTargetIdentifierArray;
                                    var depth = _p1_UnityEngine_Rendering_RenderTargetIdentifier.Value;
                                    var mipLevel = _p2_System_Int32;
                                    var cubemapFace = _p3_UnityEngine_CubemapFace;
                                    var depthSlice = _p4_System_Int32;
                                    _this.Instance.SetRenderTarget(colors, depth, mipLevel, cubemapFace, depthSlice);
                                    var _retCount = _context.Return();
                                    return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                                }
                            }
                        }
                    }
                }
            }
            throw new global::Lua.LuaRuntimeException(_context.Thread, $"{"SetRenderTarget"}: invalid argument #{_lastArgPos}: {_lastArg} ({_lastArg.Type}), expected: {_expectedType.FullName}", 2);
        });
        private static readonly global::Lua.LuaFunction _LuaCommandBuffer_SetShadingRateCombiner = new global::Lua.LuaFunction("SetShadingRateCombiner", (_context, _) =>
        {
            global::Lua.LuaValue _lastArg = default;
            global::System.Int32 _lastArgPos = default;
            global::System.Type _expectedType = default;
            var _argCount = _context.ArgumentCount;
            var _this = _context.GetArgument<LuaCommandBuffer>(0);
            var _arg0 = _lastArg = _argCount > 1 ? _context.GetArgument(1) : global::Lua.LuaValue.Nil;
            _lastArgPos = 0; _expectedType = typeof(global::UnityEngine.Rendering.ShadingRateCombinerStage);
            if (_arg0.TryRead<global::UnityEngine.Rendering.ShadingRateCombinerStage>(out var _p0_UnityEngine_Rendering_ShadingRateCombinerStage))
            {
                var _arg1 = _lastArg = _argCount > 2 ? _context.GetArgument(2) : global::Lua.LuaValue.Nil;
                _lastArgPos = 1; _expectedType = typeof(global::UnityEngine.Rendering.ShadingRateCombiner);
                if (_arg1.TryRead<global::UnityEngine.Rendering.ShadingRateCombiner>(out var _p1_UnityEngine_Rendering_ShadingRateCombiner))
                {
                    if (_argCount == 3)
                    {
                        var stage = _p0_UnityEngine_Rendering_ShadingRateCombinerStage;
                        var combiner = _p1_UnityEngine_Rendering_ShadingRateCombiner;
                        _this.Instance.SetShadingRateCombiner(stage, combiner);
                        var _retCount = _context.Return();
                        return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                    }
                }
            }
            throw new global::Lua.LuaRuntimeException(_context.Thread, $"{"SetShadingRateCombiner"}: invalid argument #{_lastArgPos}: {_lastArg} ({_lastArg.Type}), expected: {_expectedType.FullName}", 2);
        });
        private static readonly global::Lua.LuaFunction _LuaCommandBuffer_SetShadingRateFragmentSize = new global::Lua.LuaFunction("SetShadingRateFragmentSize", (_context, _) =>
        {
            global::Lua.LuaValue _lastArg = default;
            global::System.Int32 _lastArgPos = default;
            global::System.Type _expectedType = default;
            var _argCount = _context.ArgumentCount;
            var _this = _context.GetArgument<LuaCommandBuffer>(0);
            var _arg0 = _lastArg = _argCount > 1 ? _context.GetArgument(1) : global::Lua.LuaValue.Nil;
            _lastArgPos = 0; _expectedType = typeof(global::UnityEngine.Rendering.ShadingRateFragmentSize);
            if (_arg0.TryRead<global::UnityEngine.Rendering.ShadingRateFragmentSize>(out var _p0_UnityEngine_Rendering_ShadingRateFragmentSize))
            {
                if (_argCount == 2)
                {
                    var shadingRateFragmentSize = _p0_UnityEngine_Rendering_ShadingRateFragmentSize;
                    _this.Instance.SetShadingRateFragmentSize(shadingRateFragmentSize);
                    var _retCount = _context.Return();
                    return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                }
            }
            throw new global::Lua.LuaRuntimeException(_context.Thread, $"{"SetShadingRateFragmentSize"}: invalid argument #{_lastArgPos}: {_lastArg} ({_lastArg.Type}), expected: {_expectedType.FullName}", 2);
        });
        private static readonly global::Lua.LuaFunction _LuaCommandBuffer_SetShadowSamplingMode = new global::Lua.LuaFunction("SetShadowSamplingMode", (_context, _) =>
        {
            global::Lua.LuaValue _lastArg = default;
            global::System.Int32 _lastArgPos = default;
            global::System.Type _expectedType = default;
            var _argCount = _context.ArgumentCount;
            var _this = _context.GetArgument<LuaCommandBuffer>(0);
            var _arg0 = _lastArg = _argCount > 1 ? _context.GetArgument(1) : global::Lua.LuaValue.Nil;
            _lastArgPos = 0; _expectedType = typeof(global::Luny.UnityEngine.Rendering.LuaRenderTargetIdentifier);
            if (_arg0.TryRead<global::Luny.UnityEngine.Rendering.LuaRenderTargetIdentifier>(out var _p0_UnityEngine_Rendering_RenderTargetIdentifier))
            {
                var _arg1 = _lastArg = _argCount > 2 ? _context.GetArgument(2) : global::Lua.LuaValue.Nil;
                _lastArgPos = 1; _expectedType = typeof(global::UnityEngine.Rendering.ShadowSamplingMode);
                if (_arg1.TryRead<global::UnityEngine.Rendering.ShadowSamplingMode>(out var _p1_UnityEngine_Rendering_ShadowSamplingMode))
                {
                    if (_argCount == 3)
                    {
                        var shadowmap = _p0_UnityEngine_Rendering_RenderTargetIdentifier.Value;
                        var mode = _p1_UnityEngine_Rendering_ShadowSamplingMode;
                        _this.Instance.SetShadowSamplingMode(shadowmap, mode);
                        var _retCount = _context.Return();
                        return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                    }
                }
            }
            throw new global::Lua.LuaRuntimeException(_context.Thread, $"{"SetShadowSamplingMode"}: invalid argument #{_lastArgPos}: {_lastArg} ({_lastArg.Type}), expected: {_expectedType.FullName}", 2);
        });
        private static readonly global::Lua.LuaFunction _LuaCommandBuffer_SetSinglePassStereo = new global::Lua.LuaFunction("SetSinglePassStereo", (_context, _) =>
        {
            global::Lua.LuaValue _lastArg = default;
            global::System.Int32 _lastArgPos = default;
            global::System.Type _expectedType = default;
            var _argCount = _context.ArgumentCount;
            var _this = _context.GetArgument<LuaCommandBuffer>(0);
            var _arg0 = _lastArg = _argCount > 1 ? _context.GetArgument(1) : global::Lua.LuaValue.Nil;
            _lastArgPos = 0; _expectedType = typeof(global::UnityEngine.Rendering.SinglePassStereoMode);
            if (_arg0.TryRead<global::UnityEngine.Rendering.SinglePassStereoMode>(out var _p0_UnityEngine_Rendering_SinglePassStereoMode))
            {
                if (_argCount == 2)
                {
                    var mode = _p0_UnityEngine_Rendering_SinglePassStereoMode;
                    _this.Instance.SetSinglePassStereo(mode);
                    var _retCount = _context.Return();
                    return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                }
            }
            throw new global::Lua.LuaRuntimeException(_context.Thread, $"{"SetSinglePassStereo"}: invalid argument #{_lastArgPos}: {_lastArg} ({_lastArg.Type}), expected: {_expectedType.FullName}", 2);
        });
        private static readonly global::Lua.LuaFunction _LuaCommandBuffer_SetupCameraProperties = new global::Lua.LuaFunction("SetupCameraProperties", (_context, _) =>
        {
            global::Lua.LuaValue _lastArg = default;
            global::System.Int32 _lastArgPos = default;
            global::System.Type _expectedType = default;
            var _argCount = _context.ArgumentCount;
            var _this = _context.GetArgument<LuaCommandBuffer>(0);
            var _arg0 = _lastArg = _argCount > 1 ? _context.GetArgument(1) : global::Lua.LuaValue.Nil;
            _lastArgPos = 0; _expectedType = typeof(global::Luny.UnityEngine.LuaCamera);
            if (_arg0.TryRead<global::Luny.UnityEngine.LuaCamera>(out var _p0_UnityEngine_Camera))
            {
                if (_argCount == 2)
                {
                    var camera = _p0_UnityEngine_Camera.Instance;
                    _this.Instance.SetupCameraProperties(camera);
                    var _retCount = _context.Return();
                    return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                }
            }
            throw new global::Lua.LuaRuntimeException(_context.Thread, $"{"SetupCameraProperties"}: invalid argument #{_lastArgPos}: {_lastArg} ({_lastArg.Type}), expected: {_expectedType.FullName}", 2);
        });
        private static readonly global::Lua.LuaFunction _LuaCommandBuffer_SetViewMatrix = new global::Lua.LuaFunction("SetViewMatrix", (_context, _) =>
        {
            global::Lua.LuaValue _lastArg = default;
            global::System.Int32 _lastArgPos = default;
            global::System.Type _expectedType = default;
            var _argCount = _context.ArgumentCount;
            var _this = _context.GetArgument<LuaCommandBuffer>(0);
            var _arg0 = _lastArg = _argCount > 1 ? _context.GetArgument(1) : global::Lua.LuaValue.Nil;
            _lastArgPos = 0; _expectedType = typeof(global::Luny.UnityEngine.LuaMatrix4x4);
            if (_arg0.TryRead<global::Luny.UnityEngine.LuaMatrix4x4>(out var _p0_UnityEngine_Matrix4x4))
            {
                if (_argCount == 2)
                {
                    var view = _p0_UnityEngine_Matrix4x4.Value;
                    _this.Instance.SetViewMatrix(view);
                    var _retCount = _context.Return();
                    return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                }
            }
            throw new global::Lua.LuaRuntimeException(_context.Thread, $"{"SetViewMatrix"}: invalid argument #{_lastArgPos}: {_lastArg} ({_lastArg.Type}), expected: {_expectedType.FullName}", 2);
        });
        private static readonly global::Lua.LuaFunction _LuaCommandBuffer_SetViewport = new global::Lua.LuaFunction("SetViewport", (_context, _) =>
        {
            global::Lua.LuaValue _lastArg = default;
            global::System.Int32 _lastArgPos = default;
            global::System.Type _expectedType = default;
            var _argCount = _context.ArgumentCount;
            var _this = _context.GetArgument<LuaCommandBuffer>(0);
            var _arg0 = _lastArg = _argCount > 1 ? _context.GetArgument(1) : global::Lua.LuaValue.Nil;
            _lastArgPos = 0; _expectedType = typeof(global::Luny.UnityEngine.LuaRect);
            if (_arg0.TryRead<global::Luny.UnityEngine.LuaRect>(out var _p0_UnityEngine_Rect))
            {
                if (_argCount == 2)
                {
                    var pixelRect = _p0_UnityEngine_Rect.Value;
                    _this.Instance.SetViewport(pixelRect);
                    var _retCount = _context.Return();
                    return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                }
            }
            throw new global::Lua.LuaRuntimeException(_context.Thread, $"{"SetViewport"}: invalid argument #{_lastArgPos}: {_lastArg} ({_lastArg.Type}), expected: {_expectedType.FullName}", 2);
        });
        private static readonly global::Lua.LuaFunction _LuaCommandBuffer_SetViewProjectionMatrices = new global::Lua.LuaFunction("SetViewProjectionMatrices", (_context, _) =>
        {
            global::Lua.LuaValue _lastArg = default;
            global::System.Int32 _lastArgPos = default;
            global::System.Type _expectedType = default;
            var _argCount = _context.ArgumentCount;
            var _this = _context.GetArgument<LuaCommandBuffer>(0);
            var _arg0 = _lastArg = _argCount > 1 ? _context.GetArgument(1) : global::Lua.LuaValue.Nil;
            _lastArgPos = 0; _expectedType = typeof(global::Luny.UnityEngine.LuaMatrix4x4);
            if (_arg0.TryRead<global::Luny.UnityEngine.LuaMatrix4x4>(out var _p0_UnityEngine_Matrix4x4))
            {
                var _arg1 = _lastArg = _argCount > 2 ? _context.GetArgument(2) : global::Lua.LuaValue.Nil;
                _lastArgPos = 1; _expectedType = typeof(global::Luny.UnityEngine.LuaMatrix4x4);
                if (_arg1.TryRead<global::Luny.UnityEngine.LuaMatrix4x4>(out var _p1_UnityEngine_Matrix4x4))
                {
                    if (_argCount == 3)
                    {
                        var view = _p0_UnityEngine_Matrix4x4.Value;
                        var proj = _p1_UnityEngine_Matrix4x4.Value;
                        _this.Instance.SetViewProjectionMatrices(view, proj);
                        var _retCount = _context.Return();
                        return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                    }
                }
            }
            throw new global::Lua.LuaRuntimeException(_context.Thread, $"{"SetViewProjectionMatrices"}: invalid argument #{_lastArgPos}: {_lastArg} ({_lastArg.Type}), expected: {_expectedType.FullName}", 2);
        });
        private static readonly global::Lua.LuaFunction _LuaCommandBuffer_SetWireframe = new global::Lua.LuaFunction("SetWireframe", (_context, _) =>
        {
            global::Lua.LuaValue _lastArg = default;
            global::System.Int32 _lastArgPos = default;
            global::System.Type _expectedType = default;
            var _argCount = _context.ArgumentCount;
            var _this = _context.GetArgument<LuaCommandBuffer>(0);
            var _arg0 = _lastArg = _argCount > 1 ? _context.GetArgument(1) : global::Lua.LuaValue.Nil;
            _lastArgPos = 0; _expectedType = typeof(global::System.Boolean);
            if (_arg0.TryRead<global::System.Boolean>(out var _p0_System_Boolean))
            {
                if (_argCount == 2)
                {
                    var enable = _p0_System_Boolean;
                    _this.Instance.SetWireframe(enable);
                    var _retCount = _context.Return();
                    return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                }
            }
            throw new global::Lua.LuaRuntimeException(_context.Thread, $"{"SetWireframe"}: invalid argument #{_lastArgPos}: {_lastArg} ({_lastArg.Type}), expected: {_expectedType.FullName}", 2);
        });
        private static readonly global::Lua.LuaFunction _LuaCommandBuffer_UnmarkLateLatchMatrix = new global::Lua.LuaFunction("UnmarkLateLatchMatrix", (_context, _) =>
        {
            global::Lua.LuaValue _lastArg = default;
            global::System.Int32 _lastArgPos = default;
            global::System.Type _expectedType = default;
            var _argCount = _context.ArgumentCount;
            var _this = _context.GetArgument<LuaCommandBuffer>(0);
            var _arg0 = _lastArg = _argCount > 1 ? _context.GetArgument(1) : global::Lua.LuaValue.Nil;
            _lastArgPos = 0; _expectedType = typeof(global::UnityEngine.Rendering.CameraLateLatchMatrixType);
            if (_arg0.TryRead<global::UnityEngine.Rendering.CameraLateLatchMatrixType>(out var _p0_UnityEngine_Rendering_CameraLateLatchMatrixType))
            {
                if (_argCount == 2)
                {
                    var matrixPropertyType = _p0_UnityEngine_Rendering_CameraLateLatchMatrixType;
                    _this.Instance.UnmarkLateLatchMatrix(matrixPropertyType);
                    var _retCount = _context.Return();
                    return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                }
            }
            throw new global::Lua.LuaRuntimeException(_context.Thread, $"{"UnmarkLateLatchMatrix"}: invalid argument #{_lastArgPos}: {_lastArg} ({_lastArg.Type}), expected: {_expectedType.FullName}", 2);
        });
        private static readonly global::Lua.LuaFunction _LuaCommandBuffer_WaitAllAsyncReadbackRequests = new global::Lua.LuaFunction("WaitAllAsyncReadbackRequests", (_context, _) =>
        {
            global::Lua.LuaValue _lastArg = default;
            global::System.Int32 _lastArgPos = default;
            global::System.Type _expectedType = default;
            var _argCount = _context.ArgumentCount;
            var _this = _context.GetArgument<LuaCommandBuffer>(0);
            if (_argCount == 1)
            {
                _this.Instance.WaitAllAsyncReadbackRequests();
                var _retCount = _context.Return();
                return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
            }
            throw new global::Lua.LuaRuntimeException(_context.Thread, $"{"WaitAllAsyncReadbackRequests"}: invalid argument #{_lastArgPos}: {_lastArg} ({_lastArg.Type}), expected: {_expectedType.FullName}", 2);
        });
        private static readonly global::Lua.LuaFunction _LuaCommandBuffer_WaitOnAsyncGraphicsFence = new global::Lua.LuaFunction("WaitOnAsyncGraphicsFence", (_context, _) =>
        {
            global::Lua.LuaValue _lastArg = default;
            global::System.Int32 _lastArgPos = default;
            global::System.Type _expectedType = default;
            var _argCount = _context.ArgumentCount;
            var _this = _context.GetArgument<LuaCommandBuffer>(0);
            var _arg0 = _lastArg = _argCount > 1 ? _context.GetArgument(1) : global::Lua.LuaValue.Nil;
            _lastArgPos = 0; _expectedType = typeof(global::Luny.UnityEngine.Rendering.LuaGraphicsFence);
            if (_arg0.TryRead<global::Luny.UnityEngine.Rendering.LuaGraphicsFence>(out var _p0_UnityEngine_Rendering_GraphicsFence))
            {
                if (_argCount == 2)
                {
                    var fence = _p0_UnityEngine_Rendering_GraphicsFence.Value;
                    _this.Instance.WaitOnAsyncGraphicsFence(fence);
                    var _retCount = _context.Return();
                    return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                }
                var _arg1 = _lastArg = _argCount > 2 ? _context.GetArgument(2) : global::Lua.LuaValue.Nil;
                _lastArgPos = 1; _expectedType = typeof(global::UnityEngine.Rendering.SynchronisationStageFlags);
                if (_arg1.TryRead<global::UnityEngine.Rendering.SynchronisationStageFlags>(out var _p1_UnityEngine_Rendering_SynchronisationStageFlags))
                {
                    if (_argCount == 3)
                    {
                        var fence = _p0_UnityEngine_Rendering_GraphicsFence.Value;
                        var stage = _p1_UnityEngine_Rendering_SynchronisationStageFlags;
                        _this.Instance.WaitOnAsyncGraphicsFence(fence, stage);
                        var _retCount = _context.Return();
                        return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                    }
                }
                _lastArgPos = 1; _expectedType = typeof(global::UnityEngine.Rendering.SynchronisationStage);
                if (_arg1.TryRead<global::UnityEngine.Rendering.SynchronisationStage>(out var _p1_UnityEngine_Rendering_SynchronisationStage))
                {
                    if (_argCount == 3)
                    {
                        var fence = _p0_UnityEngine_Rendering_GraphicsFence.Value;
                        var stage = _p1_UnityEngine_Rendering_SynchronisationStage;
                        _this.Instance.WaitOnAsyncGraphicsFence(fence, stage);
                        var _retCount = _context.Return();
                        return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                    }
                }
            }
            throw new global::Lua.LuaRuntimeException(_context.Thread, $"{"WaitOnAsyncGraphicsFence"}: invalid argument #{_lastArgPos}: {_lastArg} ({_lastArg.Type}), expected: {_expectedType.FullName}", 2);
        });
        private static readonly global::Lua.LuaFunction __index = new(global::Lua.Runtime.Metamethods.Index, (_context, _) =>
        {
            var _this = _context.GetArgument<LuaCommandBuffer>(0);
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
            var _this = _context.GetArgument<LuaCommandBuffer>(0);
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
                case "BeginSample": _value = _LuaCommandBuffer_BeginSample; return true;
                case "Blit": _value = _LuaCommandBuffer_Blit; return true;
                case "BuildRayTracingAccelerationStructure": _value = _LuaCommandBuffer_BuildRayTracingAccelerationStructure; return true;
                case "Clear": _value = _LuaCommandBuffer_Clear; return true;
                case "ClearRandomWriteTargets": _value = _LuaCommandBuffer_ClearRandomWriteTargets; return true;
                case "ClearRenderTarget": _value = _LuaCommandBuffer_ClearRenderTarget; return true;
                case "ConvertTexture": _value = _LuaCommandBuffer_ConvertTexture; return true;
                case "CopyBuffer": _value = _LuaCommandBuffer_CopyBuffer; return true;
                case "CopyCounterValue": _value = _LuaCommandBuffer_CopyCounterValue; return true;
                case "CopyTexture": _value = _LuaCommandBuffer_CopyTexture; return true;
                case "CreateAsyncGraphicsFence": _value = _LuaCommandBuffer_CreateAsyncGraphicsFence; return true;
                case "CreateGraphicsFence": _value = _LuaCommandBuffer_CreateGraphicsFence; return true;
                case "DisableScissorRect": _value = _LuaCommandBuffer_DisableScissorRect; return true;
                case "DisableShaderKeyword": _value = _LuaCommandBuffer_DisableShaderKeyword; return true;
                case "DispatchCompute": _value = _LuaCommandBuffer_DispatchCompute; return true;
                case "DispatchRays": _value = _LuaCommandBuffer_DispatchRays; return true;
                case "Dispose": _value = _LuaCommandBuffer_Dispose; return true;
                case "DrawMesh": _value = _LuaCommandBuffer_DrawMesh; return true;
                case "DrawMeshInstanced": _value = _LuaCommandBuffer_DrawMeshInstanced; return true;
                case "DrawMeshInstancedIndirect": _value = _LuaCommandBuffer_DrawMeshInstancedIndirect; return true;
                case "DrawMeshInstancedProcedural": _value = _LuaCommandBuffer_DrawMeshInstancedProcedural; return true;
                case "DrawMultipleMeshes": _value = _LuaCommandBuffer_DrawMultipleMeshes; return true;
                case "DrawOcclusionMesh": _value = _LuaCommandBuffer_DrawOcclusionMesh; return true;
                case "DrawProcedural": _value = _LuaCommandBuffer_DrawProcedural; return true;
                case "DrawProceduralIndirect": _value = _LuaCommandBuffer_DrawProceduralIndirect; return true;
                case "DrawRenderer": _value = _LuaCommandBuffer_DrawRenderer; return true;
                case "DrawRendererList": _value = _LuaCommandBuffer_DrawRendererList; return true;
                case "EnableScissorRect": _value = _LuaCommandBuffer_EnableScissorRect; return true;
                case "EnableShaderKeyword": _value = _LuaCommandBuffer_EnableShaderKeyword; return true;
                case "EndRenderPass": _value = _LuaCommandBuffer_EndRenderPass; return true;
                case "EndSample": _value = _LuaCommandBuffer_EndSample; return true;
                case "GenerateMips": _value = _LuaCommandBuffer_GenerateMips; return true;
                case "GetTemporaryRT": _value = _LuaCommandBuffer_GetTemporaryRT; return true;
                case "GetTemporaryRTArray": _value = _LuaCommandBuffer_GetTemporaryRTArray; return true;
                case "IncrementUpdateCount": _value = _LuaCommandBuffer_IncrementUpdateCount; return true;
                case "InvokeOnRenderObjectCallbacks": _value = _LuaCommandBuffer_InvokeOnRenderObjectCallbacks; return true;
                case "MarkLateLatchMatrixShaderPropertyID": _value = _LuaCommandBuffer_MarkLateLatchMatrixShaderPropertyID; return true;
                case "NextSubPass": _value = _LuaCommandBuffer_NextSubPass; return true;
                case "Release": _value = _LuaCommandBuffer_Release; return true;
                case "ReleaseTemporaryRT": _value = _LuaCommandBuffer_ReleaseTemporaryRT; return true;
                case "ResetShadingRate": _value = _LuaCommandBuffer_ResetShadingRate; return true;
                case "ResolveAntiAliasedSurface": _value = _LuaCommandBuffer_ResolveAntiAliasedSurface; return true;
                case "SetBufferCounterValue": _value = _LuaCommandBuffer_SetBufferCounterValue; return true;
                case "SetComputeBufferParam": _value = _LuaCommandBuffer_SetComputeBufferParam; return true;
                case "SetComputeConstantBufferParam": _value = _LuaCommandBuffer_SetComputeConstantBufferParam; return true;
                case "SetComputeFloatParam": _value = _LuaCommandBuffer_SetComputeFloatParam; return true;
                case "SetComputeFloatParams": _value = _LuaCommandBuffer_SetComputeFloatParams; return true;
                case "SetComputeIntParam": _value = _LuaCommandBuffer_SetComputeIntParam; return true;
                case "SetComputeIntParams": _value = _LuaCommandBuffer_SetComputeIntParams; return true;
                case "SetComputeMatrixArrayParam": _value = _LuaCommandBuffer_SetComputeMatrixArrayParam; return true;
                case "SetComputeMatrixParam": _value = _LuaCommandBuffer_SetComputeMatrixParam; return true;
                case "SetComputeParamsFromMaterial": _value = _LuaCommandBuffer_SetComputeParamsFromMaterial; return true;
                case "SetComputeTextureParam": _value = _LuaCommandBuffer_SetComputeTextureParam; return true;
                case "SetComputeVectorArrayParam": _value = _LuaCommandBuffer_SetComputeVectorArrayParam; return true;
                case "SetComputeVectorParam": _value = _LuaCommandBuffer_SetComputeVectorParam; return true;
                case "SetExecutionFlags": _value = _LuaCommandBuffer_SetExecutionFlags; return true;
                case "SetFoveatedRenderingMode": _value = _LuaCommandBuffer_SetFoveatedRenderingMode; return true;
                case "SetGlobalBuffer": _value = _LuaCommandBuffer_SetGlobalBuffer; return true;
                case "SetGlobalColor": _value = _LuaCommandBuffer_SetGlobalColor; return true;
                case "SetGlobalConstantBuffer": _value = _LuaCommandBuffer_SetGlobalConstantBuffer; return true;
                case "SetGlobalDepthBias": _value = _LuaCommandBuffer_SetGlobalDepthBias; return true;
                case "SetGlobalFloat": _value = _LuaCommandBuffer_SetGlobalFloat; return true;
                case "SetGlobalFloatArray": _value = _LuaCommandBuffer_SetGlobalFloatArray; return true;
                case "SetGlobalInt": _value = _LuaCommandBuffer_SetGlobalInt; return true;
                case "SetGlobalInteger": _value = _LuaCommandBuffer_SetGlobalInteger; return true;
                case "SetGlobalMatrix": _value = _LuaCommandBuffer_SetGlobalMatrix; return true;
                case "SetGlobalMatrixArray": _value = _LuaCommandBuffer_SetGlobalMatrixArray; return true;
                case "SetGlobalRayTracingAccelerationStructure": _value = _LuaCommandBuffer_SetGlobalRayTracingAccelerationStructure; return true;
                case "SetGlobalTexture": _value = _LuaCommandBuffer_SetGlobalTexture; return true;
                case "SetGlobalVector": _value = _LuaCommandBuffer_SetGlobalVector; return true;
                case "SetGlobalVectorArray": _value = _LuaCommandBuffer_SetGlobalVectorArray; return true;
                case "SetInstanceMultiplier": _value = _LuaCommandBuffer_SetInstanceMultiplier; return true;
                case "SetInvertCulling": _value = _LuaCommandBuffer_SetInvertCulling; return true;
                case "SetLateLatchProjectionMatrices": _value = _LuaCommandBuffer_SetLateLatchProjectionMatrices; return true;
                case "SetProjectionMatrix": _value = _LuaCommandBuffer_SetProjectionMatrix; return true;
                case "SetRandomWriteTarget": _value = _LuaCommandBuffer_SetRandomWriteTarget; return true;
                case "SetRayTracingAccelerationStructure": _value = _LuaCommandBuffer_SetRayTracingAccelerationStructure; return true;
                case "SetRayTracingBufferParam": _value = _LuaCommandBuffer_SetRayTracingBufferParam; return true;
                case "SetRayTracingConstantBufferParam": _value = _LuaCommandBuffer_SetRayTracingConstantBufferParam; return true;
                case "SetRayTracingFloatParam": _value = _LuaCommandBuffer_SetRayTracingFloatParam; return true;
                case "SetRayTracingFloatParams": _value = _LuaCommandBuffer_SetRayTracingFloatParams; return true;
                case "SetRayTracingIntParam": _value = _LuaCommandBuffer_SetRayTracingIntParam; return true;
                case "SetRayTracingIntParams": _value = _LuaCommandBuffer_SetRayTracingIntParams; return true;
                case "SetRayTracingMatrixArrayParam": _value = _LuaCommandBuffer_SetRayTracingMatrixArrayParam; return true;
                case "SetRayTracingMatrixParam": _value = _LuaCommandBuffer_SetRayTracingMatrixParam; return true;
                case "SetRayTracingShaderPass": _value = _LuaCommandBuffer_SetRayTracingShaderPass; return true;
                case "SetRayTracingTextureParam": _value = _LuaCommandBuffer_SetRayTracingTextureParam; return true;
                case "SetRayTracingVectorArrayParam": _value = _LuaCommandBuffer_SetRayTracingVectorArrayParam; return true;
                case "SetRayTracingVectorParam": _value = _LuaCommandBuffer_SetRayTracingVectorParam; return true;
                case "SetRenderTarget": _value = _LuaCommandBuffer_SetRenderTarget; return true;
                case "SetShadingRateCombiner": _value = _LuaCommandBuffer_SetShadingRateCombiner; return true;
                case "SetShadingRateFragmentSize": _value = _LuaCommandBuffer_SetShadingRateFragmentSize; return true;
                case "SetShadowSamplingMode": _value = _LuaCommandBuffer_SetShadowSamplingMode; return true;
                case "SetSinglePassStereo": _value = _LuaCommandBuffer_SetSinglePassStereo; return true;
                case "SetupCameraProperties": _value = _LuaCommandBuffer_SetupCameraProperties; return true;
                case "SetViewMatrix": _value = _LuaCommandBuffer_SetViewMatrix; return true;
                case "SetViewport": _value = _LuaCommandBuffer_SetViewport; return true;
                case "SetViewProjectionMatrices": _value = _LuaCommandBuffer_SetViewProjectionMatrices; return true;
                case "SetWireframe": _value = _LuaCommandBuffer_SetWireframe; return true;
                case "UnmarkLateLatchMatrix": _value = _LuaCommandBuffer_UnmarkLateLatchMatrix; return true;
                case "WaitAllAsyncReadbackRequests": _value = _LuaCommandBuffer_WaitAllAsyncReadbackRequests; return true;
                case "WaitOnAsyncGraphicsFence": _value = _LuaCommandBuffer_WaitOnAsyncGraphicsFence; return true;
                case "name": _value = new global::Lua.LuaValue(Instance.name); return true;
                case "sizeInBytes": _value = new global::Lua.LuaValue(Instance.sizeInBytes); return true;
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
                case "name": Instance.name = _value.Read<global::System.String>();  return true;
                default: return false;
            }
        }
    }
    public sealed class LuaCommandBufferType : global::Luny.ILuaStatic
    {
        public static global::Lua.LuaValue Bind() => new LuaCommandBufferType();
        private LuaCommandBufferType() {}
        public static implicit operator global::Lua.LuaValue(LuaCommandBufferType value) => new(value);
        public global::System.Type BindType => typeof(global::UnityEngine.Rendering.CommandBuffer);
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
            metatable[global::Lua.Runtime.Metamethods.Call] = _LuaCommandBuffer_new;
            return metatable;
        }
        public override global::System.String ToString() => BindType.FullName;
#if UNITY_EDITOR
        [global::UnityEngine.RuntimeInitializeOnLoadMethod(global::UnityEngine.RuntimeInitializeLoadType.SubsystemRegistration)]
        private static void ResetStaticFields() => s_Metatable = null;
#endif

        private static readonly global::Lua.LuaFunction _LuaCommandBuffer_new = new global::Lua.LuaFunction(".ctor", (_context, _) =>
        {
            global::Lua.LuaValue _lastArg = default;
            global::System.Int32 _lastArgPos = default;
            global::System.Type _expectedType = default;
            var _argCount = _context.ArgumentCount;
            if (_argCount == 1)
            {
                var _ret0 = new global::UnityEngine.Rendering.CommandBuffer();
                var _factory = _context.GetObjectFactory();
                var _lret0 = _factory.Bind(_ret0);
                var _retCount = _context.Return(_lret0);
                return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
            }
            throw new global::Lua.LuaRuntimeException(_context.Thread, $"{".ctor"}: invalid argument #{_lastArgPos}: {_lastArg} ({_lastArg.Type}), expected: {_expectedType.FullName}", 2);
        });
        private static readonly global::Lua.LuaFunction __index = new(global::Lua.Runtime.Metamethods.Index, (_context, _) =>
        {
            var _this = _context.GetArgument<LuaCommandBufferType>(0);
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
            var _this = _context.GetArgument<LuaCommandBufferType>(0);
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
                case "ThrowOnSetRenderTarget": _value = new global::Lua.LuaValue(global::UnityEngine.Rendering.CommandBuffer.ThrowOnSetRenderTarget); return true;
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
                case "ThrowOnSetRenderTarget": global::UnityEngine.Rendering.CommandBuffer.ThrowOnSetRenderTarget = _value.Read<global::System.Boolean>();  return true;
                default: return false;
            }
        }
    }
}
#pragma warning restore 0109, 0162, 0168, 0219
#endif
