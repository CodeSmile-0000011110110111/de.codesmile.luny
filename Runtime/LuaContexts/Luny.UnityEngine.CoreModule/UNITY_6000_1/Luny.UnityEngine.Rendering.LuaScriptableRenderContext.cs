
// --------------------------------------------------------------
// GENERATED FILE ----> DO NOT EDIT <---- CHANGES WILL BE LOST !!
// --------------------------------------------------------------

#if UNITY_6000_1_OR_NEWER && !(UNITY_6000_2_OR_NEWER)
#pragma warning disable 0109, 0162, 0168, 0219
using Luny;

namespace Luny.UnityEngine.Rendering
{
    public sealed class LuaScriptableRenderContext : global::Luny.ILuaValueType<global::UnityEngine.Rendering.ScriptableRenderContext>
    {
        public new static global::Lua.LuaValue Bind(in global::UnityEngine.Rendering.ScriptableRenderContext instance) => new LuaScriptableRenderContext(instance);
        public new static global::Lua.LuaValue Bind(global::System.Object instance) => Bind((global::UnityEngine.Rendering.ScriptableRenderContext)instance);
        public new static global::Lua.LuaValue Bind(global::System.Collections.Generic.IList<global::UnityEngine.Rendering.ScriptableRenderContext> instances) =>
            new global::Luny.LuaList<global::UnityEngine.Rendering.ScriptableRenderContext>(instances);
        public new static global::Lua.LuaValue Bind(global::System.Collections.Generic.IList<global::System.Object> instances) =>
            new global::Luny.LuaList<global::UnityEngine.Rendering.ScriptableRenderContext>(instances);
        private LuaScriptableRenderContext(in global::UnityEngine.Rendering.ScriptableRenderContext value) => m_Value = value;
        public static implicit operator global::Lua.LuaValue(LuaScriptableRenderContext value) => new(value);
        private global::UnityEngine.Rendering.ScriptableRenderContext m_Value;
        public global::UnityEngine.Rendering.ScriptableRenderContext Value { get => m_Value; set => m_Value = value; }
        public ref global::UnityEngine.Rendering.ScriptableRenderContext ValueRef => ref m_Value;
        public global::System.Type BindType => typeof(global::UnityEngine.Rendering.ScriptableRenderContext);
        private static global::Lua.LuaTable s_Metatable;
        public global::Lua.LuaTable Metatable
        {
            get => s_Metatable ??= CreateMetatable();
            set => throw new global::System.NotSupportedException("LuaObject metatables cannot be modified");
        }
        global::System.Span<global::Lua.LuaValue> global::Lua.ILuaUserData.UserValues => default;
        private static global::Lua.LuaTable CreateMetatable()
        {
            var metatable = new global::Lua.LuaTable(0, 4);
            metatable[global::Lua.Runtime.Metamethods.Index] = __index;
            metatable[global::Lua.Runtime.Metamethods.NewIndex] = __newindex;
            metatable[global::Lua.Runtime.Metamethods.Concat] = global::Luny.LuaMetatable.ConcatMetamethod;
            metatable[global::Lua.Runtime.Metamethods.ToString] = global::Luny.LuaMetatable.ToStringMetamethod;
            return metatable;
        }
        public override global::System.String ToString() => m_Value.ToString();
#if UNITY_EDITOR
        [global::UnityEngine.RuntimeInitializeOnLoadMethod(global::UnityEngine.RuntimeInitializeLoadType.SubsystemRegistration)]
        private static void ResetStaticFields() => s_Metatable = null;
#endif

        private static readonly global::Lua.LuaFunction _LuaScriptableRenderContext_CreateGizmoRendererList = new global::Lua.LuaFunction("CreateGizmoRendererList", (_context, _) =>
        {
            global::Lua.LuaValue _lastArg = default;
            global::System.Int32 _lastArgPos = default;
            global::System.Type _expectedType = default;
            var _argCount = _context.ArgumentCount;
            var _this = _context.GetArgument<LuaScriptableRenderContext>(0);
            var _arg0 = _lastArg = _argCount > 1 ? _context.GetArgument(1) : global::Lua.LuaValue.Nil;
            _lastArgPos = 0; _expectedType = typeof(global::Luny.UnityEngine.LuaCamera);
            if (_arg0.TryRead<global::Luny.UnityEngine.LuaCamera>(out var _p0_UnityEngine_Camera))
            {
                var _arg1 = _lastArg = _argCount > 2 ? _context.GetArgument(2) : global::Lua.LuaValue.Nil;
                _lastArgPos = 1; _expectedType = typeof(global::UnityEngine.Rendering.GizmoSubset);
                if (_arg1.TryRead<global::UnityEngine.Rendering.GizmoSubset>(out var _p1_UnityEngine_Rendering_GizmoSubset))
                {
                    if (_argCount == 3)
                    {
                        var camera = _p0_UnityEngine_Camera.Instance;
                        var gizmoSubset = _p1_UnityEngine_Rendering_GizmoSubset;
                        var _ret0 = _this.m_Value.CreateGizmoRendererList(camera, gizmoSubset);
                        var _lret0 = global::Luny.UnityEngine.Rendering.LuaRendererList.Bind(_ret0);
                        var _retCount = _context.Return(_lret0);
                        return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                    }
                }
            }
            throw new global::Lua.LuaRuntimeException(_context.Thread, $"{"CreateGizmoRendererList"}: invalid argument #{_lastArgPos}: {_lastArg} ({_lastArg.Type}), expected: {_expectedType.FullName}", 2);
        });
        private static readonly global::Lua.LuaFunction _LuaScriptableRenderContext_CreateRendererList = new global::Lua.LuaFunction("CreateRendererList", (_context, _) =>
        {
            global::Lua.LuaValue _lastArg = default;
            global::System.Int32 _lastArgPos = default;
            global::System.Type _expectedType = default;
            var _argCount = _context.ArgumentCount;
            var _this = _context.GetArgument<LuaScriptableRenderContext>(0);
            var _arg0 = _lastArg = _argCount > 1 ? _context.GetArgument(1) : global::Lua.LuaValue.Nil;
            _lastArgPos = 0; _expectedType = typeof(global::Luny.UnityEngine.Rendering.RendererUtils.LuaRendererListDesc);
            if (_arg0.TryRead<global::Luny.UnityEngine.Rendering.RendererUtils.LuaRendererListDesc>(out var _p0_UnityEngine_Rendering_RendererUtils_RendererListDesc))
            {
                if (_argCount == 2)
                {
                    var desc = _p0_UnityEngine_Rendering_RendererUtils_RendererListDesc.Value;
                    var _ret0 = _this.m_Value.CreateRendererList(desc);
                    var _lret0 = global::Luny.UnityEngine.Rendering.LuaRendererList.Bind(_ret0);
                    var _retCount = _context.Return(_lret0);
                    return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                }
            }
            throw new global::Lua.LuaRuntimeException(_context.Thread, $"{"CreateRendererList"}: invalid argument #{_lastArgPos}: {_lastArg} ({_lastArg.Type}), expected: {_expectedType.FullName}", 2);
        });
        private static readonly global::Lua.LuaFunction _LuaScriptableRenderContext_CreateSkyboxRendererList = new global::Lua.LuaFunction("CreateSkyboxRendererList", (_context, _) =>
        {
            global::Lua.LuaValue _lastArg = default;
            global::System.Int32 _lastArgPos = default;
            global::System.Type _expectedType = default;
            var _argCount = _context.ArgumentCount;
            var _this = _context.GetArgument<LuaScriptableRenderContext>(0);
            var _arg0 = _lastArg = _argCount > 1 ? _context.GetArgument(1) : global::Lua.LuaValue.Nil;
            _lastArgPos = 0; _expectedType = typeof(global::Luny.UnityEngine.LuaCamera);
            if (_arg0.TryRead<global::Luny.UnityEngine.LuaCamera>(out var _p0_UnityEngine_Camera))
            {
                if (_argCount == 2)
                {
                    var camera = _p0_UnityEngine_Camera.Instance;
                    var _ret0 = _this.m_Value.CreateSkyboxRendererList(camera);
                    var _lret0 = global::Luny.UnityEngine.Rendering.LuaRendererList.Bind(_ret0);
                    var _retCount = _context.Return(_lret0);
                    return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                }
                var _arg1 = _lastArg = _argCount > 2 ? _context.GetArgument(2) : global::Lua.LuaValue.Nil;
                _lastArgPos = 1; _expectedType = typeof(global::Luny.UnityEngine.LuaMatrix4x4);
                if (_arg1.TryRead<global::Luny.UnityEngine.LuaMatrix4x4>(out var _p1_UnityEngine_Matrix4x4))
                {
                    var _arg2 = _lastArg = _argCount > 3 ? _context.GetArgument(3) : global::Lua.LuaValue.Nil;
                    _lastArgPos = 2; _expectedType = typeof(global::Luny.UnityEngine.LuaMatrix4x4);
                    if (_arg2.TryRead<global::Luny.UnityEngine.LuaMatrix4x4>(out var _p2_UnityEngine_Matrix4x4))
                    {
                        if (_argCount == 4)
                        {
                            var camera = _p0_UnityEngine_Camera.Instance;
                            var projectionMatrix = _p1_UnityEngine_Matrix4x4.Value;
                            var viewMatrix = _p2_UnityEngine_Matrix4x4.Value;
                            var _ret0 = _this.m_Value.CreateSkyboxRendererList(camera, projectionMatrix, viewMatrix);
                            var _lret0 = global::Luny.UnityEngine.Rendering.LuaRendererList.Bind(_ret0);
                            var _retCount = _context.Return(_lret0);
                            return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                        }
                        var _arg3 = _lastArg = _argCount > 4 ? _context.GetArgument(4) : global::Lua.LuaValue.Nil;
                        _lastArgPos = 3; _expectedType = typeof(global::Luny.UnityEngine.LuaMatrix4x4);
                        if (_arg3.TryRead<global::Luny.UnityEngine.LuaMatrix4x4>(out var _p3_UnityEngine_Matrix4x4))
                        {
                            var _arg4 = _lastArg = _argCount > 5 ? _context.GetArgument(5) : global::Lua.LuaValue.Nil;
                            _lastArgPos = 4; _expectedType = typeof(global::Luny.UnityEngine.LuaMatrix4x4);
                            if (_arg4.TryRead<global::Luny.UnityEngine.LuaMatrix4x4>(out var _p4_UnityEngine_Matrix4x4))
                            {
                                if (_argCount == 6)
                                {
                                    var camera = _p0_UnityEngine_Camera.Instance;
                                    var projectionMatrixL = _p1_UnityEngine_Matrix4x4.Value;
                                    var viewMatrixL = _p2_UnityEngine_Matrix4x4.Value;
                                    var projectionMatrixR = _p3_UnityEngine_Matrix4x4.Value;
                                    var viewMatrixR = _p4_UnityEngine_Matrix4x4.Value;
                                    var _ret0 = _this.m_Value.CreateSkyboxRendererList(camera, projectionMatrixL, viewMatrixL, projectionMatrixR, viewMatrixR);
                                    var _lret0 = global::Luny.UnityEngine.Rendering.LuaRendererList.Bind(_ret0);
                                    var _retCount = _context.Return(_lret0);
                                    return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                                }
                            }
                        }
                    }
                }
            }
            throw new global::Lua.LuaRuntimeException(_context.Thread, $"{"CreateSkyboxRendererList"}: invalid argument #{_lastArgPos}: {_lastArg} ({_lastArg.Type}), expected: {_expectedType.FullName}", 2);
        });
        private static readonly global::Lua.LuaFunction _LuaScriptableRenderContext_CreateUIOverlayRendererList = new global::Lua.LuaFunction("CreateUIOverlayRendererList", (_context, _) =>
        {
            global::Lua.LuaValue _lastArg = default;
            global::System.Int32 _lastArgPos = default;
            global::System.Type _expectedType = default;
            var _argCount = _context.ArgumentCount;
            var _this = _context.GetArgument<LuaScriptableRenderContext>(0);
            var _arg0 = _lastArg = _argCount > 1 ? _context.GetArgument(1) : global::Lua.LuaValue.Nil;
            _lastArgPos = 0; _expectedType = typeof(global::Luny.UnityEngine.LuaCamera);
            if (_arg0.TryRead<global::Luny.UnityEngine.LuaCamera>(out var _p0_UnityEngine_Camera))
            {
                if (_argCount == 2)
                {
                    var camera = _p0_UnityEngine_Camera.Instance;
                    var _ret0 = _this.m_Value.CreateUIOverlayRendererList(camera);
                    var _lret0 = global::Luny.UnityEngine.Rendering.LuaRendererList.Bind(_ret0);
                    var _retCount = _context.Return(_lret0);
                    return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                }
                var _arg1 = _lastArg = _argCount > 2 ? _context.GetArgument(2) : global::Lua.LuaValue.Nil;
                _lastArgPos = 1; _expectedType = typeof(global::UnityEngine.Rendering.UISubset);
                if (_arg1.TryRead<global::UnityEngine.Rendering.UISubset>(out var _p1_UnityEngine_Rendering_UISubset))
                {
                    if (_argCount == 3)
                    {
                        var camera = _p0_UnityEngine_Camera.Instance;
                        var uiSubset = _p1_UnityEngine_Rendering_UISubset;
                        var _ret0 = _this.m_Value.CreateUIOverlayRendererList(camera, uiSubset);
                        var _lret0 = global::Luny.UnityEngine.Rendering.LuaRendererList.Bind(_ret0);
                        var _retCount = _context.Return(_lret0);
                        return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                    }
                }
            }
            throw new global::Lua.LuaRuntimeException(_context.Thread, $"{"CreateUIOverlayRendererList"}: invalid argument #{_lastArgPos}: {_lastArg} ({_lastArg.Type}), expected: {_expectedType.FullName}", 2);
        });
        private static readonly global::Lua.LuaFunction _LuaScriptableRenderContext_CreateWireOverlayRendererList = new global::Lua.LuaFunction("CreateWireOverlayRendererList", (_context, _) =>
        {
            global::Lua.LuaValue _lastArg = default;
            global::System.Int32 _lastArgPos = default;
            global::System.Type _expectedType = default;
            var _argCount = _context.ArgumentCount;
            var _this = _context.GetArgument<LuaScriptableRenderContext>(0);
            var _arg0 = _lastArg = _argCount > 1 ? _context.GetArgument(1) : global::Lua.LuaValue.Nil;
            _lastArgPos = 0; _expectedType = typeof(global::Luny.UnityEngine.LuaCamera);
            if (_arg0.TryRead<global::Luny.UnityEngine.LuaCamera>(out var _p0_UnityEngine_Camera))
            {
                if (_argCount == 2)
                {
                    var camera = _p0_UnityEngine_Camera.Instance;
                    var _ret0 = _this.m_Value.CreateWireOverlayRendererList(camera);
                    var _lret0 = global::Luny.UnityEngine.Rendering.LuaRendererList.Bind(_ret0);
                    var _retCount = _context.Return(_lret0);
                    return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                }
            }
            throw new global::Lua.LuaRuntimeException(_context.Thread, $"{"CreateWireOverlayRendererList"}: invalid argument #{_lastArgPos}: {_lastArg} ({_lastArg.Type}), expected: {_expectedType.FullName}", 2);
        });
        private static readonly global::Lua.LuaFunction _LuaScriptableRenderContext_CullShadowCasters = new global::Lua.LuaFunction("CullShadowCasters", (_context, _) =>
        {
            global::Lua.LuaValue _lastArg = default;
            global::System.Int32 _lastArgPos = default;
            global::System.Type _expectedType = default;
            var _argCount = _context.ArgumentCount;
            var _this = _context.GetArgument<LuaScriptableRenderContext>(0);
            var _arg0 = _lastArg = _argCount > 1 ? _context.GetArgument(1) : global::Lua.LuaValue.Nil;
            _lastArgPos = 0; _expectedType = typeof(global::Luny.UnityEngine.Rendering.LuaCullingResults);
            if (_arg0.TryRead<global::Luny.UnityEngine.Rendering.LuaCullingResults>(out var _p0_UnityEngine_Rendering_CullingResults))
            {
                var _arg1 = _lastArg = _argCount > 2 ? _context.GetArgument(2) : global::Lua.LuaValue.Nil;
                _lastArgPos = 1; _expectedType = typeof(global::Luny.UnityEngine.Rendering.LuaShadowCastersCullingInfos);
                if (_arg1.TryRead<global::Luny.UnityEngine.Rendering.LuaShadowCastersCullingInfos>(out var _p1_UnityEngine_Rendering_ShadowCastersCullingInfos))
                {
                    if (_argCount == 3)
                    {
                        var cullingResults = _p0_UnityEngine_Rendering_CullingResults.Value;
                        var infos = _p1_UnityEngine_Rendering_ShadowCastersCullingInfos.Value;
                        _this.m_Value.CullShadowCasters(cullingResults, infos);
                        var _retCount = _context.Return();
                        return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                    }
                }
            }
            throw new global::Lua.LuaRuntimeException(_context.Thread, $"{"CullShadowCasters"}: invalid argument #{_lastArgPos}: {_lastArg} ({_lastArg.Type}), expected: {_expectedType.FullName}", 2);
        });
        private static readonly global::Lua.LuaFunction _LuaScriptableRenderContext_DrawGizmos = new global::Lua.LuaFunction("DrawGizmos", (_context, _) =>
        {
            global::Lua.LuaValue _lastArg = default;
            global::System.Int32 _lastArgPos = default;
            global::System.Type _expectedType = default;
            var _argCount = _context.ArgumentCount;
            var _this = _context.GetArgument<LuaScriptableRenderContext>(0);
            var _arg0 = _lastArg = _argCount > 1 ? _context.GetArgument(1) : global::Lua.LuaValue.Nil;
            _lastArgPos = 0; _expectedType = typeof(global::Luny.UnityEngine.LuaCamera);
            if (_arg0.TryRead<global::Luny.UnityEngine.LuaCamera>(out var _p0_UnityEngine_Camera))
            {
                var _arg1 = _lastArg = _argCount > 2 ? _context.GetArgument(2) : global::Lua.LuaValue.Nil;
                _lastArgPos = 1; _expectedType = typeof(global::UnityEngine.Rendering.GizmoSubset);
                if (_arg1.TryRead<global::UnityEngine.Rendering.GizmoSubset>(out var _p1_UnityEngine_Rendering_GizmoSubset))
                {
                    if (_argCount == 3)
                    {
                        var camera = _p0_UnityEngine_Camera.Instance;
                        var gizmoSubset = _p1_UnityEngine_Rendering_GizmoSubset;
                        _this.m_Value.DrawGizmos(camera, gizmoSubset);
                        var _retCount = _context.Return();
                        return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                    }
                }
            }
            throw new global::Lua.LuaRuntimeException(_context.Thread, $"{"DrawGizmos"}: invalid argument #{_lastArgPos}: {_lastArg} ({_lastArg.Type}), expected: {_expectedType.FullName}", 2);
        });
        private static readonly global::Lua.LuaFunction _LuaScriptableRenderContext_DrawUIOverlay = new global::Lua.LuaFunction("DrawUIOverlay", (_context, _) =>
        {
            global::Lua.LuaValue _lastArg = default;
            global::System.Int32 _lastArgPos = default;
            global::System.Type _expectedType = default;
            var _argCount = _context.ArgumentCount;
            var _this = _context.GetArgument<LuaScriptableRenderContext>(0);
            var _arg0 = _lastArg = _argCount > 1 ? _context.GetArgument(1) : global::Lua.LuaValue.Nil;
            _lastArgPos = 0; _expectedType = typeof(global::Luny.UnityEngine.LuaCamera);
            if (_arg0.TryRead<global::Luny.UnityEngine.LuaCamera>(out var _p0_UnityEngine_Camera))
            {
                if (_argCount == 2)
                {
                    var camera = _p0_UnityEngine_Camera.Instance;
                    _this.m_Value.DrawUIOverlay(camera);
                    var _retCount = _context.Return();
                    return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                }
            }
            throw new global::Lua.LuaRuntimeException(_context.Thread, $"{"DrawUIOverlay"}: invalid argument #{_lastArgPos}: {_lastArg} ({_lastArg.Type}), expected: {_expectedType.FullName}", 2);
        });
        private static readonly global::Lua.LuaFunction _LuaScriptableRenderContext_DrawWireOverlay = new global::Lua.LuaFunction("DrawWireOverlay", (_context, _) =>
        {
            global::Lua.LuaValue _lastArg = default;
            global::System.Int32 _lastArgPos = default;
            global::System.Type _expectedType = default;
            var _argCount = _context.ArgumentCount;
            var _this = _context.GetArgument<LuaScriptableRenderContext>(0);
            var _arg0 = _lastArg = _argCount > 1 ? _context.GetArgument(1) : global::Lua.LuaValue.Nil;
            _lastArgPos = 0; _expectedType = typeof(global::Luny.UnityEngine.LuaCamera);
            if (_arg0.TryRead<global::Luny.UnityEngine.LuaCamera>(out var _p0_UnityEngine_Camera))
            {
                if (_argCount == 2)
                {
                    var camera = _p0_UnityEngine_Camera.Instance;
                    _this.m_Value.DrawWireOverlay(camera);
                    var _retCount = _context.Return();
                    return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                }
            }
            throw new global::Lua.LuaRuntimeException(_context.Thread, $"{"DrawWireOverlay"}: invalid argument #{_lastArgPos}: {_lastArg} ({_lastArg.Type}), expected: {_expectedType.FullName}", 2);
        });
        private static readonly global::Lua.LuaFunction _LuaScriptableRenderContext_EndRenderPass = new global::Lua.LuaFunction("EndRenderPass", (_context, _) =>
        {
            global::Lua.LuaValue _lastArg = default;
            global::System.Int32 _lastArgPos = default;
            global::System.Type _expectedType = default;
            var _argCount = _context.ArgumentCount;
            var _this = _context.GetArgument<LuaScriptableRenderContext>(0);
            if (_argCount == 1)
            {
                _this.m_Value.EndRenderPass();
                var _retCount = _context.Return();
                return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
            }
            throw new global::Lua.LuaRuntimeException(_context.Thread, $"{"EndRenderPass"}: invalid argument #{_lastArgPos}: {_lastArg} ({_lastArg.Type}), expected: {_expectedType.FullName}", 2);
        });
        private static readonly global::Lua.LuaFunction _LuaScriptableRenderContext_EndSubPass = new global::Lua.LuaFunction("EndSubPass", (_context, _) =>
        {
            global::Lua.LuaValue _lastArg = default;
            global::System.Int32 _lastArgPos = default;
            global::System.Type _expectedType = default;
            var _argCount = _context.ArgumentCount;
            var _this = _context.GetArgument<LuaScriptableRenderContext>(0);
            if (_argCount == 1)
            {
                _this.m_Value.EndSubPass();
                var _retCount = _context.Return();
                return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
            }
            throw new global::Lua.LuaRuntimeException(_context.Thread, $"{"EndSubPass"}: invalid argument #{_lastArgPos}: {_lastArg} ({_lastArg.Type}), expected: {_expectedType.FullName}", 2);
        });
        private static readonly global::Lua.LuaFunction _LuaScriptableRenderContext_Equals = new global::Lua.LuaFunction("Equals", (_context, _) =>
        {
            global::Lua.LuaValue _lastArg = default;
            global::System.Int32 _lastArgPos = default;
            global::System.Type _expectedType = default;
            var _argCount = _context.ArgumentCount;
            var _this = _context.GetArgument<LuaScriptableRenderContext>(0);
            var _arg0 = _lastArg = _argCount > 1 ? _context.GetArgument(1) : global::Lua.LuaValue.Nil;
            _lastArgPos = 0; _expectedType = typeof(global::Luny.UnityEngine.Rendering.LuaScriptableRenderContext);
            if (_arg0.TryRead<global::Luny.UnityEngine.Rendering.LuaScriptableRenderContext>(out var _p0_UnityEngine_Rendering_ScriptableRenderContext))
            {
                if (_argCount == 2)
                {
                    var other = _p0_UnityEngine_Rendering_ScriptableRenderContext.Value;
                    var _ret0 = _this.m_Value.Equals(other);
                    var _lret0 = new global::Lua.LuaValue(_ret0);
                    var _retCount = _context.Return(_lret0);
                    return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                }
            }
            _lastArgPos = 0; _expectedType = typeof(global::System.Object);
            if (_arg0.TryRead<global::System.Object>(out var _p0_System_Object))
            {
                if (_argCount == 2)
                {
                    var obj = _p0_System_Object;
                    var _ret0 = _this.m_Value.Equals(obj);
                    var _lret0 = new global::Lua.LuaValue(_ret0);
                    var _retCount = _context.Return(_lret0);
                    return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                }
            }
            throw new global::Lua.LuaRuntimeException(_context.Thread, $"{"Equals"}: invalid argument #{_lastArgPos}: {_lastArg} ({_lastArg.Type}), expected: {_expectedType.FullName}", 2);
        });
        private static readonly global::Lua.LuaFunction _LuaScriptableRenderContext_ExecuteCommandBuffer = new global::Lua.LuaFunction("ExecuteCommandBuffer", (_context, _) =>
        {
            global::Lua.LuaValue _lastArg = default;
            global::System.Int32 _lastArgPos = default;
            global::System.Type _expectedType = default;
            var _argCount = _context.ArgumentCount;
            var _this = _context.GetArgument<LuaScriptableRenderContext>(0);
            var _arg0 = _lastArg = _argCount > 1 ? _context.GetArgument(1) : global::Lua.LuaValue.Nil;
            _lastArgPos = 0; _expectedType = typeof(global::Luny.UnityEngine.Rendering.LuaCommandBuffer);
            if (_arg0.TryRead<global::Luny.UnityEngine.Rendering.LuaCommandBuffer>(out var _p0_UnityEngine_Rendering_CommandBuffer))
            {
                if (_argCount == 2)
                {
                    var commandBuffer = _p0_UnityEngine_Rendering_CommandBuffer.Instance;
                    _this.m_Value.ExecuteCommandBuffer(commandBuffer);
                    var _retCount = _context.Return();
                    return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                }
            }
            throw new global::Lua.LuaRuntimeException(_context.Thread, $"{"ExecuteCommandBuffer"}: invalid argument #{_lastArgPos}: {_lastArg} ({_lastArg.Type}), expected: {_expectedType.FullName}", 2);
        });
        private static readonly global::Lua.LuaFunction _LuaScriptableRenderContext_ExecuteCommandBufferAsync = new global::Lua.LuaFunction("ExecuteCommandBufferAsync", (_context, _) =>
        {
            global::Lua.LuaValue _lastArg = default;
            global::System.Int32 _lastArgPos = default;
            global::System.Type _expectedType = default;
            var _argCount = _context.ArgumentCount;
            var _this = _context.GetArgument<LuaScriptableRenderContext>(0);
            var _arg0 = _lastArg = _argCount > 1 ? _context.GetArgument(1) : global::Lua.LuaValue.Nil;
            _lastArgPos = 0; _expectedType = typeof(global::Luny.UnityEngine.Rendering.LuaCommandBuffer);
            if (_arg0.TryRead<global::Luny.UnityEngine.Rendering.LuaCommandBuffer>(out var _p0_UnityEngine_Rendering_CommandBuffer))
            {
                var _arg1 = _lastArg = _argCount > 2 ? _context.GetArgument(2) : global::Lua.LuaValue.Nil;
                _lastArgPos = 1; _expectedType = typeof(global::UnityEngine.Rendering.ComputeQueueType);
                if (_arg1.TryRead<global::UnityEngine.Rendering.ComputeQueueType>(out var _p1_UnityEngine_Rendering_ComputeQueueType))
                {
                    if (_argCount == 3)
                    {
                        var commandBuffer = _p0_UnityEngine_Rendering_CommandBuffer.Instance;
                        var queueType = _p1_UnityEngine_Rendering_ComputeQueueType;
                        _this.m_Value.ExecuteCommandBufferAsync(commandBuffer, queueType);
                        var _retCount = _context.Return();
                        return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                    }
                }
            }
            throw new global::Lua.LuaRuntimeException(_context.Thread, $"{"ExecuteCommandBufferAsync"}: invalid argument #{_lastArgPos}: {_lastArg} ({_lastArg.Type}), expected: {_expectedType.FullName}", 2);
        });
        private static readonly global::Lua.LuaFunction _LuaScriptableRenderContext_GetHashCode = new global::Lua.LuaFunction("GetHashCode", (_context, _) =>
        {
            global::Lua.LuaValue _lastArg = default;
            global::System.Int32 _lastArgPos = default;
            global::System.Type _expectedType = default;
            var _argCount = _context.ArgumentCount;
            var _this = _context.GetArgument<LuaScriptableRenderContext>(0);
            if (_argCount == 1)
            {
                var _ret0 = _this.m_Value.GetHashCode();
                var _lret0 = new global::Lua.LuaValue(_ret0);
                var _retCount = _context.Return(_lret0);
                return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
            }
            throw new global::Lua.LuaRuntimeException(_context.Thread, $"{"GetHashCode"}: invalid argument #{_lastArgPos}: {_lastArg} ({_lastArg.Type}), expected: {_expectedType.FullName}", 2);
        });
        private static readonly global::Lua.LuaFunction _LuaScriptableRenderContext_HasInvokeOnRenderObjectCallbacks = new global::Lua.LuaFunction("HasInvokeOnRenderObjectCallbacks", (_context, _) =>
        {
            global::Lua.LuaValue _lastArg = default;
            global::System.Int32 _lastArgPos = default;
            global::System.Type _expectedType = default;
            var _argCount = _context.ArgumentCount;
            var _this = _context.GetArgument<LuaScriptableRenderContext>(0);
            if (_argCount == 1)
            {
                var _ret0 = _this.m_Value.HasInvokeOnRenderObjectCallbacks();
                var _lret0 = new global::Lua.LuaValue(_ret0);
                var _retCount = _context.Return(_lret0);
                return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
            }
            throw new global::Lua.LuaRuntimeException(_context.Thread, $"{"HasInvokeOnRenderObjectCallbacks"}: invalid argument #{_lastArgPos}: {_lastArg} ({_lastArg.Type}), expected: {_expectedType.FullName}", 2);
        });
        private static readonly global::Lua.LuaFunction _LuaScriptableRenderContext_InvokeOnRenderObjectCallback = new global::Lua.LuaFunction("InvokeOnRenderObjectCallback", (_context, _) =>
        {
            global::Lua.LuaValue _lastArg = default;
            global::System.Int32 _lastArgPos = default;
            global::System.Type _expectedType = default;
            var _argCount = _context.ArgumentCount;
            var _this = _context.GetArgument<LuaScriptableRenderContext>(0);
            if (_argCount == 1)
            {
                _this.m_Value.InvokeOnRenderObjectCallback();
                var _retCount = _context.Return();
                return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
            }
            throw new global::Lua.LuaRuntimeException(_context.Thread, $"{"InvokeOnRenderObjectCallback"}: invalid argument #{_lastArgPos}: {_lastArg} ({_lastArg.Type}), expected: {_expectedType.FullName}", 2);
        });
        private static readonly global::Lua.LuaFunction _LuaScriptableRenderContext_QueryRendererListStatus = new global::Lua.LuaFunction("QueryRendererListStatus", (_context, _) =>
        {
            global::Lua.LuaValue _lastArg = default;
            global::System.Int32 _lastArgPos = default;
            global::System.Type _expectedType = default;
            var _argCount = _context.ArgumentCount;
            var _this = _context.GetArgument<LuaScriptableRenderContext>(0);
            var _arg0 = _lastArg = _argCount > 1 ? _context.GetArgument(1) : global::Lua.LuaValue.Nil;
            _lastArgPos = 0; _expectedType = typeof(global::Luny.UnityEngine.Rendering.LuaRendererList);
            if (_arg0.TryRead<global::Luny.UnityEngine.Rendering.LuaRendererList>(out var _p0_UnityEngine_Rendering_RendererList))
            {
                if (_argCount == 2)
                {
                    var rendererList = _p0_UnityEngine_Rendering_RendererList.Value;
                    var _ret0 = _this.m_Value.QueryRendererListStatus(rendererList);
                    var _lret0 = new global::Lua.LuaValue((global::System.Int64)_ret0);
                    var _retCount = _context.Return(_lret0);
                    return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                }
            }
            throw new global::Lua.LuaRuntimeException(_context.Thread, $"{"QueryRendererListStatus"}: invalid argument #{_lastArgPos}: {_lastArg} ({_lastArg.Type}), expected: {_expectedType.FullName}", 2);
        });
        private static readonly global::Lua.LuaFunction _LuaScriptableRenderContext_SetupCameraProperties = new global::Lua.LuaFunction("SetupCameraProperties", (_context, _) =>
        {
            global::Lua.LuaValue _lastArg = default;
            global::System.Int32 _lastArgPos = default;
            global::System.Type _expectedType = default;
            var _argCount = _context.ArgumentCount;
            var _this = _context.GetArgument<LuaScriptableRenderContext>(0);
            var _arg0 = _lastArg = _argCount > 1 ? _context.GetArgument(1) : global::Lua.LuaValue.Nil;
            _lastArgPos = 0; _expectedType = typeof(global::Luny.UnityEngine.LuaCamera);
            if (_arg0.TryRead<global::Luny.UnityEngine.LuaCamera>(out var _p0_UnityEngine_Camera))
            {
                if (_argCount == 2)
                {
                    var camera = _p0_UnityEngine_Camera.Instance;
                    _this.m_Value.SetupCameraProperties(camera);
                    var _retCount = _context.Return();
                    return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                }
                var _arg1 = _lastArg = _argCount > 2 ? _context.GetArgument(2) : global::Lua.LuaValue.Nil;
                _lastArgPos = 1; _expectedType = typeof(global::System.Boolean);
                var _p1_System_Boolean = _arg1.ReadValue<global::System.Boolean>((global::System.Boolean)false);
                {
                    if (_argCount == 3)
                    {
                        var camera = _p0_UnityEngine_Camera.Instance;
                        var stereoSetup = _p1_System_Boolean;
                        _this.m_Value.SetupCameraProperties(camera, stereoSetup);
                        var _retCount = _context.Return();
                        return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                    }
                    var _arg2 = _lastArg = _argCount > 3 ? _context.GetArgument(3) : global::Lua.LuaValue.Nil;
                    _lastArgPos = 2; _expectedType = typeof(global::System.Int32);
                    if (_arg2.TryRead<global::System.Int32>(out var _p2_System_Int32))
                    {
                        if (_argCount == 4)
                        {
                            var camera = _p0_UnityEngine_Camera.Instance;
                            var stereoSetup = _p1_System_Boolean;
                            var eye = _p2_System_Int32;
                            _this.m_Value.SetupCameraProperties(camera, stereoSetup, eye);
                            var _retCount = _context.Return();
                            return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                        }
                    }
                }
            }
            throw new global::Lua.LuaRuntimeException(_context.Thread, $"{"SetupCameraProperties"}: invalid argument #{_lastArgPos}: {_lastArg} ({_lastArg.Type}), expected: {_expectedType.FullName}", 2);
        });
        private static readonly global::Lua.LuaFunction _LuaScriptableRenderContext_StartMultiEye = new global::Lua.LuaFunction("StartMultiEye", (_context, _) =>
        {
            global::Lua.LuaValue _lastArg = default;
            global::System.Int32 _lastArgPos = default;
            global::System.Type _expectedType = default;
            var _argCount = _context.ArgumentCount;
            var _this = _context.GetArgument<LuaScriptableRenderContext>(0);
            var _arg0 = _lastArg = _argCount > 1 ? _context.GetArgument(1) : global::Lua.LuaValue.Nil;
            _lastArgPos = 0; _expectedType = typeof(global::Luny.UnityEngine.LuaCamera);
            if (_arg0.TryRead<global::Luny.UnityEngine.LuaCamera>(out var _p0_UnityEngine_Camera))
            {
                if (_argCount == 2)
                {
                    var camera = _p0_UnityEngine_Camera.Instance;
                    _this.m_Value.StartMultiEye(camera);
                    var _retCount = _context.Return();
                    return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                }
                var _arg1 = _lastArg = _argCount > 2 ? _context.GetArgument(2) : global::Lua.LuaValue.Nil;
                _lastArgPos = 1; _expectedType = typeof(global::System.Int32);
                if (_arg1.TryRead<global::System.Int32>(out var _p1_System_Int32))
                {
                    if (_argCount == 3)
                    {
                        var camera = _p0_UnityEngine_Camera.Instance;
                        var eye = _p1_System_Int32;
                        _this.m_Value.StartMultiEye(camera, eye);
                        var _retCount = _context.Return();
                        return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                    }
                }
            }
            throw new global::Lua.LuaRuntimeException(_context.Thread, $"{"StartMultiEye"}: invalid argument #{_lastArgPos}: {_lastArg} ({_lastArg.Type}), expected: {_expectedType.FullName}", 2);
        });
        private static readonly global::Lua.LuaFunction _LuaScriptableRenderContext_StereoEndRender = new global::Lua.LuaFunction("StereoEndRender", (_context, _) =>
        {
            global::Lua.LuaValue _lastArg = default;
            global::System.Int32 _lastArgPos = default;
            global::System.Type _expectedType = default;
            var _argCount = _context.ArgumentCount;
            var _this = _context.GetArgument<LuaScriptableRenderContext>(0);
            var _arg0 = _lastArg = _argCount > 1 ? _context.GetArgument(1) : global::Lua.LuaValue.Nil;
            _lastArgPos = 0; _expectedType = typeof(global::Luny.UnityEngine.LuaCamera);
            if (_arg0.TryRead<global::Luny.UnityEngine.LuaCamera>(out var _p0_UnityEngine_Camera))
            {
                if (_argCount == 2)
                {
                    var camera = _p0_UnityEngine_Camera.Instance;
                    _this.m_Value.StereoEndRender(camera);
                    var _retCount = _context.Return();
                    return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                }
                var _arg1 = _lastArg = _argCount > 2 ? _context.GetArgument(2) : global::Lua.LuaValue.Nil;
                _lastArgPos = 1; _expectedType = typeof(global::System.Int32);
                if (_arg1.TryRead<global::System.Int32>(out var _p1_System_Int32))
                {
                    if (_argCount == 3)
                    {
                        var camera = _p0_UnityEngine_Camera.Instance;
                        var eye = _p1_System_Int32;
                        _this.m_Value.StereoEndRender(camera, eye);
                        var _retCount = _context.Return();
                        return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                    }
                    var _arg2 = _lastArg = _argCount > 3 ? _context.GetArgument(3) : global::Lua.LuaValue.Nil;
                    _lastArgPos = 2; _expectedType = typeof(global::System.Boolean);
                    if (_arg2.TryRead<global::System.Boolean>(out var _p2_System_Boolean))
                    {
                        if (_argCount == 4)
                        {
                            var camera = _p0_UnityEngine_Camera.Instance;
                            var eye = _p1_System_Int32;
                            var isFinalPass = _p2_System_Boolean;
                            _this.m_Value.StereoEndRender(camera, eye, isFinalPass);
                            var _retCount = _context.Return();
                            return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                        }
                    }
                }
            }
            throw new global::Lua.LuaRuntimeException(_context.Thread, $"{"StereoEndRender"}: invalid argument #{_lastArgPos}: {_lastArg} ({_lastArg.Type}), expected: {_expectedType.FullName}", 2);
        });
        private static readonly global::Lua.LuaFunction _LuaScriptableRenderContext_StopMultiEye = new global::Lua.LuaFunction("StopMultiEye", (_context, _) =>
        {
            global::Lua.LuaValue _lastArg = default;
            global::System.Int32 _lastArgPos = default;
            global::System.Type _expectedType = default;
            var _argCount = _context.ArgumentCount;
            var _this = _context.GetArgument<LuaScriptableRenderContext>(0);
            var _arg0 = _lastArg = _argCount > 1 ? _context.GetArgument(1) : global::Lua.LuaValue.Nil;
            _lastArgPos = 0; _expectedType = typeof(global::Luny.UnityEngine.LuaCamera);
            if (_arg0.TryRead<global::Luny.UnityEngine.LuaCamera>(out var _p0_UnityEngine_Camera))
            {
                if (_argCount == 2)
                {
                    var camera = _p0_UnityEngine_Camera.Instance;
                    _this.m_Value.StopMultiEye(camera);
                    var _retCount = _context.Return();
                    return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                }
            }
            throw new global::Lua.LuaRuntimeException(_context.Thread, $"{"StopMultiEye"}: invalid argument #{_lastArgPos}: {_lastArg} ({_lastArg.Type}), expected: {_expectedType.FullName}", 2);
        });
        private static readonly global::Lua.LuaFunction _LuaScriptableRenderContext_Submit = new global::Lua.LuaFunction("Submit", (_context, _) =>
        {
            global::Lua.LuaValue _lastArg = default;
            global::System.Int32 _lastArgPos = default;
            global::System.Type _expectedType = default;
            var _argCount = _context.ArgumentCount;
            var _this = _context.GetArgument<LuaScriptableRenderContext>(0);
            if (_argCount == 1)
            {
                _this.m_Value.Submit();
                var _retCount = _context.Return();
                return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
            }
            throw new global::Lua.LuaRuntimeException(_context.Thread, $"{"Submit"}: invalid argument #{_lastArgPos}: {_lastArg} ({_lastArg.Type}), expected: {_expectedType.FullName}", 2);
        });
        private static readonly global::Lua.LuaFunction _LuaScriptableRenderContext_SubmitForRenderPassValidation = new global::Lua.LuaFunction("SubmitForRenderPassValidation", (_context, _) =>
        {
            global::Lua.LuaValue _lastArg = default;
            global::System.Int32 _lastArgPos = default;
            global::System.Type _expectedType = default;
            var _argCount = _context.ArgumentCount;
            var _this = _context.GetArgument<LuaScriptableRenderContext>(0);
            if (_argCount == 1)
            {
                var _ret0 = _this.m_Value.SubmitForRenderPassValidation();
                var _lret0 = new global::Lua.LuaValue(_ret0);
                var _retCount = _context.Return(_lret0);
                return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
            }
            throw new global::Lua.LuaRuntimeException(_context.Thread, $"{"SubmitForRenderPassValidation"}: invalid argument #{_lastArgPos}: {_lastArg} ({_lastArg.Type}), expected: {_expectedType.FullName}", 2);
        });
        private static readonly global::Lua.LuaFunction __index = new(global::Lua.Runtime.Metamethods.Index, (_context, _) =>
        {
            var _this = _context.GetArgument<LuaScriptableRenderContext>(0);
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
            var _this = _context.GetArgument<LuaScriptableRenderContext>(0);
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
                case "CreateGizmoRendererList": _value = _LuaScriptableRenderContext_CreateGizmoRendererList; return true;
                case "CreateRendererList": _value = _LuaScriptableRenderContext_CreateRendererList; return true;
                case "CreateSkyboxRendererList": _value = _LuaScriptableRenderContext_CreateSkyboxRendererList; return true;
                case "CreateUIOverlayRendererList": _value = _LuaScriptableRenderContext_CreateUIOverlayRendererList; return true;
                case "CreateWireOverlayRendererList": _value = _LuaScriptableRenderContext_CreateWireOverlayRendererList; return true;
                case "CullShadowCasters": _value = _LuaScriptableRenderContext_CullShadowCasters; return true;
                case "DrawGizmos": _value = _LuaScriptableRenderContext_DrawGizmos; return true;
                case "DrawUIOverlay": _value = _LuaScriptableRenderContext_DrawUIOverlay; return true;
                case "DrawWireOverlay": _value = _LuaScriptableRenderContext_DrawWireOverlay; return true;
                case "EndRenderPass": _value = _LuaScriptableRenderContext_EndRenderPass; return true;
                case "EndSubPass": _value = _LuaScriptableRenderContext_EndSubPass; return true;
                case "Equals": _value = _LuaScriptableRenderContext_Equals; return true;
                case "ExecuteCommandBuffer": _value = _LuaScriptableRenderContext_ExecuteCommandBuffer; return true;
                case "ExecuteCommandBufferAsync": _value = _LuaScriptableRenderContext_ExecuteCommandBufferAsync; return true;
                case "GetHashCode": _value = _LuaScriptableRenderContext_GetHashCode; return true;
                case "HasInvokeOnRenderObjectCallbacks": _value = _LuaScriptableRenderContext_HasInvokeOnRenderObjectCallbacks; return true;
                case "InvokeOnRenderObjectCallback": _value = _LuaScriptableRenderContext_InvokeOnRenderObjectCallback; return true;
                case "QueryRendererListStatus": _value = _LuaScriptableRenderContext_QueryRendererListStatus; return true;
                case "SetupCameraProperties": _value = _LuaScriptableRenderContext_SetupCameraProperties; return true;
                case "StartMultiEye": _value = _LuaScriptableRenderContext_StartMultiEye; return true;
                case "StereoEndRender": _value = _LuaScriptableRenderContext_StereoEndRender; return true;
                case "StopMultiEye": _value = _LuaScriptableRenderContext_StopMultiEye; return true;
                case "Submit": _value = _LuaScriptableRenderContext_Submit; return true;
                case "SubmitForRenderPassValidation": _value = _LuaScriptableRenderContext_SubmitForRenderPassValidation; return true;
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
    public sealed class LuaScriptableRenderContextType : global::Luny.ILuaStatic
    {
        public static global::Lua.LuaValue Bind() => new LuaScriptableRenderContextType();
        private LuaScriptableRenderContextType() {}
        public static implicit operator global::Lua.LuaValue(LuaScriptableRenderContextType value) => new(value);
        public global::System.Type BindType => typeof(global::UnityEngine.Rendering.ScriptableRenderContext);
        private static global::Lua.LuaTable s_Metatable;
        public global::Lua.LuaTable Metatable
        {
            get => s_Metatable ??= CreateMetatable();
            set => throw new global::System.NotSupportedException("LuaObject metatables cannot be modified");
        }
        global::System.Span<global::Lua.LuaValue> global::Lua.ILuaUserData.UserValues => default;
        private static global::Lua.LuaTable CreateMetatable()
        {
            var metatable = new global::Lua.LuaTable(0, 4);
            metatable[global::Lua.Runtime.Metamethods.Index] = __index;
            metatable[global::Lua.Runtime.Metamethods.NewIndex] = __newindex;
            metatable[global::Lua.Runtime.Metamethods.Concat] = global::Luny.LuaMetatable.ConcatMetamethod;
            metatable[global::Lua.Runtime.Metamethods.ToString] = global::Luny.LuaMetatable.ToStringMetamethod;
            return metatable;
        }
        public override global::System.String ToString() => BindType.FullName;
#if UNITY_EDITOR
        [global::UnityEngine.RuntimeInitializeOnLoadMethod(global::UnityEngine.RuntimeInitializeLoadType.SubsystemRegistration)]
        private static void ResetStaticFields() => s_Metatable = null;
#endif

        private static readonly global::Lua.LuaFunction _LuaScriptableRenderContext_EmitGeometryForCamera = new global::Lua.LuaFunction("EmitGeometryForCamera", (_context, _) =>
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
                    var camera = _p0_UnityEngine_Camera.Instance;
                    global::UnityEngine.Rendering.ScriptableRenderContext.EmitGeometryForCamera(camera);
                    var _retCount = _context.Return();
                    return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                }
            }
            throw new global::Lua.LuaRuntimeException(_context.Thread, $"{"EmitGeometryForCamera"}: invalid argument #{_lastArgPos}: {_lastArg} ({_lastArg.Type}), expected: {_expectedType.FullName}", 2);
        });
        private static readonly global::Lua.LuaFunction _LuaScriptableRenderContext_PopDisableApiRenderers = new global::Lua.LuaFunction("PopDisableApiRenderers", (_context, _) =>
        {
            global::Lua.LuaValue _lastArg = default;
            global::System.Int32 _lastArgPos = default;
            global::System.Type _expectedType = default;
            var _argCount = _context.ArgumentCount;
            if (_argCount == 0)
            {
                global::UnityEngine.Rendering.ScriptableRenderContext.PopDisableApiRenderers();
                var _retCount = _context.Return();
                return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
            }
            throw new global::Lua.LuaRuntimeException(_context.Thread, $"{"PopDisableApiRenderers"}: invalid argument #{_lastArgPos}: {_lastArg} ({_lastArg.Type}), expected: {_expectedType.FullName}", 2);
        });
        private static readonly global::Lua.LuaFunction _LuaScriptableRenderContext_PushDisableApiRenderers = new global::Lua.LuaFunction("PushDisableApiRenderers", (_context, _) =>
        {
            global::Lua.LuaValue _lastArg = default;
            global::System.Int32 _lastArgPos = default;
            global::System.Type _expectedType = default;
            var _argCount = _context.ArgumentCount;
            if (_argCount == 0)
            {
                global::UnityEngine.Rendering.ScriptableRenderContext.PushDisableApiRenderers();
                var _retCount = _context.Return();
                return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
            }
            throw new global::Lua.LuaRuntimeException(_context.Thread, $"{"PushDisableApiRenderers"}: invalid argument #{_lastArgPos}: {_lastArg} ({_lastArg.Type}), expected: {_expectedType.FullName}", 2);
        });
        private static readonly global::Lua.LuaFunction __index = new(global::Lua.Runtime.Metamethods.Index, (_context, _) =>
        {
            var _this = _context.GetArgument<LuaScriptableRenderContextType>(0);
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
            var _this = _context.GetArgument<LuaScriptableRenderContextType>(0);
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
                case "EmitGeometryForCamera": _value = _LuaScriptableRenderContext_EmitGeometryForCamera; return true;
                case "PopDisableApiRenderers": _value = _LuaScriptableRenderContext_PopDisableApiRenderers; return true;
                case "PushDisableApiRenderers": _value = _LuaScriptableRenderContext_PushDisableApiRenderers; return true;
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
