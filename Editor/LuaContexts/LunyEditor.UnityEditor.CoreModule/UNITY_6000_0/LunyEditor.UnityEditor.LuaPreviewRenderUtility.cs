
// --------------------------------------------------------------
// GENERATED FILE ----> DO NOT EDIT <---- CHANGES WILL BE LOST !!
// --------------------------------------------------------------

#if UNITY_6000_0_OR_NEWER && !(UNITY_6000_1_OR_NEWER)
#pragma warning disable 0109, 0162, 0168, 0219
using Luny;

namespace LunyEditor.UnityEditor
{
    public class LuaPreviewRenderUtility : global::Luny.ILuaObject<global::UnityEditor.PreviewRenderUtility>
    {
        public new static global::Lua.LuaValue Bind(global::UnityEditor.PreviewRenderUtility instance) => new LuaPreviewRenderUtility(instance);
        public new static global::Lua.LuaValue Bind(global::System.Object instance) => Bind((global::UnityEditor.PreviewRenderUtility)instance);
        public new static global::Lua.LuaValue Bind(global::System.Collections.Generic.IList<global::UnityEditor.PreviewRenderUtility> instances) =>
            new global::Luny.LuaList<global::UnityEditor.PreviewRenderUtility>(instances);
        public new static global::Lua.LuaValue Bind(global::System.Collections.Generic.IList<global::System.Object> instances) =>
            new global::Luny.LuaList<global::UnityEditor.PreviewRenderUtility>(instances);
        protected LuaPreviewRenderUtility(global::UnityEditor.PreviewRenderUtility instance) => m_Instance = instance;
        public static implicit operator global::Lua.LuaValue(LuaPreviewRenderUtility value) => new(value);
        protected global::UnityEditor.PreviewRenderUtility m_Instance;
        public global::UnityEditor.PreviewRenderUtility Instance => m_Instance;
        public new global::System.Type BindType => typeof(global::UnityEditor.PreviewRenderUtility);
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

        private static readonly global::Lua.LuaFunction _LuaPreviewRenderUtility_AddSingleGO = new global::Lua.LuaFunction("AddSingleGO", (_context, _) =>
        {
            global::Lua.LuaValue _lastArg = default;
            global::System.Int32 _lastArgPos = default;
            global::System.Type _expectedType = default;
            var _argCount = _context.ArgumentCount;
            var _this = _context.GetArgument<LuaPreviewRenderUtility>(0);
            var _arg0 = _lastArg = _argCount > 1 ? _context.GetArgument(1) : global::Lua.LuaValue.Nil;
            _lastArgPos = 0; _expectedType = typeof(global::Luny.UnityEngine.LuaGameObject);
            if (_arg0.TryRead<global::Luny.UnityEngine.LuaGameObject>(out var _p0_UnityEngine_GameObject))
            {
                if (_argCount == 2)
                {
                    var go = _p0_UnityEngine_GameObject.Instance;
                    _this.Instance.AddSingleGO(go);
                    var _retCount = _context.Return();
                    return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                }
            }
            throw new global::Lua.LuaRuntimeException(_context.Thread, $"{"AddSingleGO"}: invalid argument #{_lastArgPos}: {_lastArg} ({_lastArg.Type}), expected: {_expectedType.FullName}", 2);
        });
        private static readonly global::Lua.LuaFunction _LuaPreviewRenderUtility_BeginPreview = new global::Lua.LuaFunction("BeginPreview", (_context, _) =>
        {
            global::Lua.LuaValue _lastArg = default;
            global::System.Int32 _lastArgPos = default;
            global::System.Type _expectedType = default;
            var _argCount = _context.ArgumentCount;
            var _this = _context.GetArgument<LuaPreviewRenderUtility>(0);
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
                        var previewBackground = _p1_UnityEngine_GUIStyle;
                        _this.Instance.BeginPreview(r, previewBackground);
                        var _retCount = _context.Return();
                        return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                    }
                }
            }
            throw new global::Lua.LuaRuntimeException(_context.Thread, $"{"BeginPreview"}: invalid argument #{_lastArgPos}: {_lastArg} ({_lastArg.Type}), expected: {_expectedType.FullName}", 2);
        });
        private static readonly global::Lua.LuaFunction _LuaPreviewRenderUtility_BeginStaticPreview = new global::Lua.LuaFunction("BeginStaticPreview", (_context, _) =>
        {
            global::Lua.LuaValue _lastArg = default;
            global::System.Int32 _lastArgPos = default;
            global::System.Type _expectedType = default;
            var _argCount = _context.ArgumentCount;
            var _this = _context.GetArgument<LuaPreviewRenderUtility>(0);
            var _arg0 = _lastArg = _argCount > 1 ? _context.GetArgument(1) : global::Lua.LuaValue.Nil;
            _lastArgPos = 0; _expectedType = typeof(global::Luny.UnityEngine.LuaRect);
            if (_arg0.TryRead<global::Luny.UnityEngine.LuaRect>(out var _p0_UnityEngine_Rect))
            {
                if (_argCount == 2)
                {
                    var r = _p0_UnityEngine_Rect.Value;
                    _this.Instance.BeginStaticPreview(r);
                    var _retCount = _context.Return();
                    return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                }
            }
            throw new global::Lua.LuaRuntimeException(_context.Thread, $"{"BeginStaticPreview"}: invalid argument #{_lastArgPos}: {_lastArg} ({_lastArg.Type}), expected: {_expectedType.FullName}", 2);
        });
        private static readonly global::Lua.LuaFunction _LuaPreviewRenderUtility_Cleanup = new global::Lua.LuaFunction("Cleanup", (_context, _) =>
        {
            global::Lua.LuaValue _lastArg = default;
            global::System.Int32 _lastArgPos = default;
            global::System.Type _expectedType = default;
            var _argCount = _context.ArgumentCount;
            var _this = _context.GetArgument<LuaPreviewRenderUtility>(0);
            if (_argCount == 1)
            {
                _this.Instance.Cleanup();
                var _retCount = _context.Return();
                return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
            }
            throw new global::Lua.LuaRuntimeException(_context.Thread, $"{"Cleanup"}: invalid argument #{_lastArgPos}: {_lastArg} ({_lastArg.Type}), expected: {_expectedType.FullName}", 2);
        });
        private static readonly global::Lua.LuaFunction _LuaPreviewRenderUtility_DrawMesh = new global::Lua.LuaFunction("DrawMesh", (_context, _) =>
        {
            global::Lua.LuaValue _lastArg = default;
            global::System.Int32 _lastArgPos = default;
            global::System.Type _expectedType = default;
            var _argCount = _context.ArgumentCount;
            var _this = _context.GetArgument<LuaPreviewRenderUtility>(0);
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
                        var _arg3 = _lastArg = _argCount > 4 ? _context.GetArgument(4) : global::Lua.LuaValue.Nil;
                        _lastArgPos = 3; _expectedType = typeof(global::System.Int32);
                        if (_arg3.TryRead<global::System.Int32>(out var _p3_System_Int32))
                        {
                            if (_argCount == 5)
                            {
                                var mesh = _p0_UnityEngine_Mesh.Instance;
                                var matrix = _p1_UnityEngine_Matrix4x4.Value;
                                var mat = _p2_UnityEngine_Material.Instance;
                                var subMeshIndex = _p3_System_Int32;
                                _this.Instance.DrawMesh(mesh, matrix, mat, subMeshIndex);
                                var _retCount = _context.Return();
                                return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                            }
                            var _arg4 = _lastArg = _argCount > 5 ? _context.GetArgument(5) : global::Lua.LuaValue.Nil;
                            _lastArgPos = 4; _expectedType = typeof(global::Luny.UnityEngine.LuaMaterialPropertyBlock);
                            if (_arg4.TryRead<global::Luny.UnityEngine.LuaMaterialPropertyBlock>(out var _p4_UnityEngine_MaterialPropertyBlock))
                            {
                                if (_argCount == 6)
                                {
                                    var mesh = _p0_UnityEngine_Mesh.Instance;
                                    var matrix = _p1_UnityEngine_Matrix4x4.Value;
                                    var mat = _p2_UnityEngine_Material.Instance;
                                    var subMeshIndex = _p3_System_Int32;
                                    var customProperties = _p4_UnityEngine_MaterialPropertyBlock.Instance;
                                    _this.Instance.DrawMesh(mesh, matrix, mat, subMeshIndex, customProperties);
                                    var _retCount = _context.Return();
                                    return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                                }
                                var _arg5 = _lastArg = _argCount > 6 ? _context.GetArgument(6) : global::Lua.LuaValue.Nil;
                                _lastArgPos = 5; _expectedType = typeof(global::Luny.UnityEngine.LuaTransform);
                                if (_arg5.TryRead<global::Luny.UnityEngine.LuaTransform>(out var _p5_UnityEngine_Transform))
                                {
                                    var _arg6 = _lastArg = _argCount > 7 ? _context.GetArgument(7) : global::Lua.LuaValue.Nil;
                                    _lastArgPos = 6; _expectedType = typeof(global::System.Boolean);
                                    if (_arg6.TryRead<global::System.Boolean>(out var _p6_System_Boolean))
                                    {
                                        if (_argCount == 8)
                                        {
                                            var mesh = _p0_UnityEngine_Mesh.Instance;
                                            var m = _p1_UnityEngine_Matrix4x4.Value;
                                            var mat = _p2_UnityEngine_Material.Instance;
                                            var subMeshIndex = _p3_System_Int32;
                                            var customProperties = _p4_UnityEngine_MaterialPropertyBlock.Instance;
                                            var probeAnchor = _p5_UnityEngine_Transform.Instance;
                                            var useLightProbe = _p6_System_Boolean;
                                            _this.Instance.DrawMesh(mesh, m, mat, subMeshIndex, customProperties, probeAnchor, useLightProbe);
                                            var _retCount = _context.Return();
                                            return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
                _lastArgPos = 1; _expectedType = typeof(global::Luny.UnityEngine.LuaVector3);
                if (_arg1.TryRead<global::Luny.UnityEngine.LuaVector3>(out var _p1_UnityEngine_Vector3))
                {
                    var _arg2 = _lastArg = _argCount > 3 ? _context.GetArgument(3) : global::Lua.LuaValue.Nil;
                    _lastArgPos = 2; _expectedType = typeof(global::Luny.UnityEngine.LuaQuaternion);
                    if (_arg2.TryRead<global::Luny.UnityEngine.LuaQuaternion>(out var _p2_UnityEngine_Quaternion))
                    {
                        var _arg3 = _lastArg = _argCount > 4 ? _context.GetArgument(4) : global::Lua.LuaValue.Nil;
                        _lastArgPos = 3; _expectedType = typeof(global::Luny.UnityEngine.LuaMaterial);
                        if (_arg3.TryRead<global::Luny.UnityEngine.LuaMaterial>(out var _p3_UnityEngine_Material))
                        {
                            var _arg4 = _lastArg = _argCount > 5 ? _context.GetArgument(5) : global::Lua.LuaValue.Nil;
                            _lastArgPos = 4; _expectedType = typeof(global::System.Int32);
                            if (_arg4.TryRead<global::System.Int32>(out var _p4_System_Int32))
                            {
                                if (_argCount == 6)
                                {
                                    var mesh = _p0_UnityEngine_Mesh.Instance;
                                    var pos = _p1_UnityEngine_Vector3.Value;
                                    var rot = _p2_UnityEngine_Quaternion.Value;
                                    var mat = _p3_UnityEngine_Material.Instance;
                                    var subMeshIndex = _p4_System_Int32;
                                    _this.Instance.DrawMesh(mesh, pos, rot, mat, subMeshIndex);
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
                                        var pos = _p1_UnityEngine_Vector3.Value;
                                        var rot = _p2_UnityEngine_Quaternion.Value;
                                        var mat = _p3_UnityEngine_Material.Instance;
                                        var subMeshIndex = _p4_System_Int32;
                                        var customProperties = _p5_UnityEngine_MaterialPropertyBlock.Instance;
                                        _this.Instance.DrawMesh(mesh, pos, rot, mat, subMeshIndex, customProperties);
                                        var _retCount = _context.Return();
                                        return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                                    }
                                    var _arg6 = _lastArg = _argCount > 7 ? _context.GetArgument(7) : global::Lua.LuaValue.Nil;
                                    _lastArgPos = 6; _expectedType = typeof(global::Luny.UnityEngine.LuaTransform);
                                    if (_arg6.TryRead<global::Luny.UnityEngine.LuaTransform>(out var _p6_UnityEngine_Transform))
                                    {
                                        if (_argCount == 8)
                                        {
                                            var mesh = _p0_UnityEngine_Mesh.Instance;
                                            var pos = _p1_UnityEngine_Vector3.Value;
                                            var rot = _p2_UnityEngine_Quaternion.Value;
                                            var mat = _p3_UnityEngine_Material.Instance;
                                            var subMeshIndex = _p4_System_Int32;
                                            var customProperties = _p5_UnityEngine_MaterialPropertyBlock.Instance;
                                            var probeAnchor = _p6_UnityEngine_Transform.Instance;
                                            _this.Instance.DrawMesh(mesh, pos, rot, mat, subMeshIndex, customProperties, probeAnchor);
                                            var _retCount = _context.Return();
                                            return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                                        }
                                        var _arg7 = _lastArg = _argCount > 8 ? _context.GetArgument(8) : global::Lua.LuaValue.Nil;
                                        _lastArgPos = 7; _expectedType = typeof(global::System.Boolean);
                                        if (_arg7.TryRead<global::System.Boolean>(out var _p7_System_Boolean))
                                        {
                                            if (_argCount == 9)
                                            {
                                                var mesh = _p0_UnityEngine_Mesh.Instance;
                                                var pos = _p1_UnityEngine_Vector3.Value;
                                                var rot = _p2_UnityEngine_Quaternion.Value;
                                                var mat = _p3_UnityEngine_Material.Instance;
                                                var subMeshIndex = _p4_System_Int32;
                                                var customProperties = _p5_UnityEngine_MaterialPropertyBlock.Instance;
                                                var probeAnchor = _p6_UnityEngine_Transform.Instance;
                                                var useLightProbe = _p7_System_Boolean;
                                                _this.Instance.DrawMesh(mesh, pos, rot, mat, subMeshIndex, customProperties, probeAnchor, useLightProbe);
                                                var _retCount = _context.Return();
                                                return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }
                    _lastArgPos = 2; _expectedType = typeof(global::Luny.UnityEngine.LuaVector3);
                    if (_arg2.TryRead<global::Luny.UnityEngine.LuaVector3>(out var _p2_UnityEngine_Vector3))
                    {
                        var _arg3 = _lastArg = _argCount > 4 ? _context.GetArgument(4) : global::Lua.LuaValue.Nil;
                        _lastArgPos = 3; _expectedType = typeof(global::Luny.UnityEngine.LuaQuaternion);
                        if (_arg3.TryRead<global::Luny.UnityEngine.LuaQuaternion>(out var _p3_UnityEngine_Quaternion))
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
                                        var _arg7 = _lastArg = _argCount > 8 ? _context.GetArgument(8) : global::Lua.LuaValue.Nil;
                                        _lastArgPos = 7; _expectedType = typeof(global::Luny.UnityEngine.LuaTransform);
                                        if (_arg7.TryRead<global::Luny.UnityEngine.LuaTransform>(out var _p7_UnityEngine_Transform))
                                        {
                                            var _arg8 = _lastArg = _argCount > 9 ? _context.GetArgument(9) : global::Lua.LuaValue.Nil;
                                            _lastArgPos = 8; _expectedType = typeof(global::System.Boolean);
                                            if (_arg8.TryRead<global::System.Boolean>(out var _p8_System_Boolean))
                                            {
                                                if (_argCount == 10)
                                                {
                                                    var mesh = _p0_UnityEngine_Mesh.Instance;
                                                    var pos = _p1_UnityEngine_Vector3.Value;
                                                    var scale = _p2_UnityEngine_Vector3.Value;
                                                    var rot = _p3_UnityEngine_Quaternion.Value;
                                                    var mat = _p4_UnityEngine_Material.Instance;
                                                    var subMeshIndex = _p5_System_Int32;
                                                    var customProperties = _p6_UnityEngine_MaterialPropertyBlock.Instance;
                                                    var probeAnchor = _p7_UnityEngine_Transform.Instance;
                                                    var useLightProbe = _p8_System_Boolean;
                                                    _this.Instance.DrawMesh(mesh, pos, scale, rot, mat, subMeshIndex, customProperties, probeAnchor, useLightProbe);
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
            throw new global::Lua.LuaRuntimeException(_context.Thread, $"{"DrawMesh"}: invalid argument #{_lastArgPos}: {_lastArg} ({_lastArg.Type}), expected: {_expectedType.FullName}", 2);
        });
        private static readonly global::Lua.LuaFunction _LuaPreviewRenderUtility_EndAndDrawPreview = new global::Lua.LuaFunction("EndAndDrawPreview", (_context, _) =>
        {
            global::Lua.LuaValue _lastArg = default;
            global::System.Int32 _lastArgPos = default;
            global::System.Type _expectedType = default;
            var _argCount = _context.ArgumentCount;
            var _this = _context.GetArgument<LuaPreviewRenderUtility>(0);
            var _arg0 = _lastArg = _argCount > 1 ? _context.GetArgument(1) : global::Lua.LuaValue.Nil;
            _lastArgPos = 0; _expectedType = typeof(global::Luny.UnityEngine.LuaRect);
            if (_arg0.TryRead<global::Luny.UnityEngine.LuaRect>(out var _p0_UnityEngine_Rect))
            {
                if (_argCount == 2)
                {
                    var r = _p0_UnityEngine_Rect.Value;
                    _this.Instance.EndAndDrawPreview(r);
                    var _retCount = _context.Return();
                    return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                }
            }
            throw new global::Lua.LuaRuntimeException(_context.Thread, $"{"EndAndDrawPreview"}: invalid argument #{_lastArgPos}: {_lastArg} ({_lastArg.Type}), expected: {_expectedType.FullName}", 2);
        });
        private static readonly global::Lua.LuaFunction _LuaPreviewRenderUtility_EndPreview = new global::Lua.LuaFunction("EndPreview", (_context, _) =>
        {
            global::Lua.LuaValue _lastArg = default;
            global::System.Int32 _lastArgPos = default;
            global::System.Type _expectedType = default;
            var _argCount = _context.ArgumentCount;
            var _this = _context.GetArgument<LuaPreviewRenderUtility>(0);
            if (_argCount == 1)
            {
                var _ret0 = _this.Instance.EndPreview();
                var _factory = _context.GetObjectFactory();
                var _lret0 = _factory.Bind(_ret0);
                var _retCount = _context.Return(_lret0);
                return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
            }
            throw new global::Lua.LuaRuntimeException(_context.Thread, $"{"EndPreview"}: invalid argument #{_lastArgPos}: {_lastArg} ({_lastArg.Type}), expected: {_expectedType.FullName}", 2);
        });
        private static readonly global::Lua.LuaFunction _LuaPreviewRenderUtility_EndStaticPreview = new global::Lua.LuaFunction("EndStaticPreview", (_context, _) =>
        {
            global::Lua.LuaValue _lastArg = default;
            global::System.Int32 _lastArgPos = default;
            global::System.Type _expectedType = default;
            var _argCount = _context.ArgumentCount;
            var _this = _context.GetArgument<LuaPreviewRenderUtility>(0);
            if (_argCount == 1)
            {
                var _ret0 = _this.Instance.EndStaticPreview();
                var _factory = _context.GetObjectFactory();
                var _lret0 = _factory.Bind(_ret0);
                var _retCount = _context.Return(_lret0);
                return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
            }
            throw new global::Lua.LuaRuntimeException(_context.Thread, $"{"EndStaticPreview"}: invalid argument #{_lastArgPos}: {_lastArg} ({_lastArg.Type}), expected: {_expectedType.FullName}", 2);
        });
        private static readonly global::Lua.LuaFunction _LuaPreviewRenderUtility_GetScaleFactor = new global::Lua.LuaFunction("GetScaleFactor", (_context, _) =>
        {
            global::Lua.LuaValue _lastArg = default;
            global::System.Int32 _lastArgPos = default;
            global::System.Type _expectedType = default;
            var _argCount = _context.ArgumentCount;
            var _this = _context.GetArgument<LuaPreviewRenderUtility>(0);
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
                        var width = _p0_System_Single;
                        var height = _p1_System_Single;
                        var _ret0 = _this.Instance.GetScaleFactor(width, height);
                        var _lret0 = new global::Lua.LuaValue(_ret0);
                        var _retCount = _context.Return(_lret0);
                        return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                    }
                }
            }
            throw new global::Lua.LuaRuntimeException(_context.Thread, $"{"GetScaleFactor"}: invalid argument #{_lastArgPos}: {_lastArg} ({_lastArg.Type}), expected: {_expectedType.FullName}", 2);
        });
        private static readonly global::Lua.LuaFunction _LuaPreviewRenderUtility_InstantiatePrefabInScene = new global::Lua.LuaFunction("InstantiatePrefabInScene", (_context, _) =>
        {
            global::Lua.LuaValue _lastArg = default;
            global::System.Int32 _lastArgPos = default;
            global::System.Type _expectedType = default;
            var _argCount = _context.ArgumentCount;
            var _this = _context.GetArgument<LuaPreviewRenderUtility>(0);
            var _arg0 = _lastArg = _argCount > 1 ? _context.GetArgument(1) : global::Lua.LuaValue.Nil;
            _lastArgPos = 0; _expectedType = typeof(global::Luny.UnityEngine.LuaGameObject);
            if (_arg0.TryRead<global::Luny.UnityEngine.LuaGameObject>(out var _p0_UnityEngine_GameObject))
            {
                if (_argCount == 2)
                {
                    var prefab = _p0_UnityEngine_GameObject.Instance;
                    var _ret0 = _this.Instance.InstantiatePrefabInScene(prefab);
                    var _factory = _context.GetObjectFactory();
                    var _lret0 = _factory.Bind(_ret0);
                    var _retCount = _context.Return(_lret0);
                    return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                }
            }
            throw new global::Lua.LuaRuntimeException(_context.Thread, $"{"InstantiatePrefabInScene"}: invalid argument #{_lastArgPos}: {_lastArg} ({_lastArg.Type}), expected: {_expectedType.FullName}", 2);
        });
        private static readonly global::Lua.LuaFunction _LuaPreviewRenderUtility_Render = new global::Lua.LuaFunction("Render", (_context, _) =>
        {
            global::Lua.LuaValue _lastArg = default;
            global::System.Int32 _lastArgPos = default;
            global::System.Type _expectedType = default;
            var _argCount = _context.ArgumentCount;
            var _this = _context.GetArgument<LuaPreviewRenderUtility>(0);
            if (_argCount == 1)
            {
                _this.Instance.Render();
                var _retCount = _context.Return();
                return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
            }
            var _arg0 = _lastArg = _argCount > 1 ? _context.GetArgument(1) : global::Lua.LuaValue.Nil;
            _lastArgPos = 0; _expectedType = typeof(global::System.Boolean);
            var _p0_System_Boolean = _arg0.ReadValue<global::System.Boolean>((global::System.Boolean)false);
            {
                if (_argCount == 2)
                {
                    var allowScriptableRenderPipeline = _p0_System_Boolean;
                    _this.Instance.Render(allowScriptableRenderPipeline);
                    var _retCount = _context.Return();
                    return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                }
                var _arg1 = _lastArg = _argCount > 2 ? _context.GetArgument(2) : global::Lua.LuaValue.Nil;
                _lastArgPos = 1; _expectedType = typeof(global::System.Boolean);
                var _p1_System_Boolean = _arg1.ReadValue<global::System.Boolean>((global::System.Boolean)true);
                {
                    if (_argCount == 3)
                    {
                        var allowScriptableRenderPipeline = _p0_System_Boolean;
                        var updatefov = _p1_System_Boolean;
                        _this.Instance.Render(allowScriptableRenderPipeline, updatefov);
                        var _retCount = _context.Return();
                        return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                    }
                }
            }
            throw new global::Lua.LuaRuntimeException(_context.Thread, $"{"Render"}: invalid argument #{_lastArgPos}: {_lastArg} ({_lastArg.Type}), expected: {_expectedType.FullName}", 2);
        });
        private static readonly global::Lua.LuaFunction __index = new(global::Lua.Runtime.Metamethods.Index, (_context, _) =>
        {
            var _this = _context.GetArgument<LuaPreviewRenderUtility>(0);
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
            var _this = _context.GetArgument<LuaPreviewRenderUtility>(0);
            var _key = _context.GetArgument(1);
            var _value = _context.GetArgument(2);
            if (_key.Type == global::Lua.LuaValueType.Number && _key.TryRead<global::System.Int32>(out var _index) && _this.TrySetLuaValue(_index, _value))
                return new global::System.Threading.Tasks.ValueTask<global::System.Int32>(_context.Return(_value));
            if (_key.Type == global::Lua.LuaValueType.String && _this.TrySetLuaValue(_key.Read<global::System.String>(), _value))
                return new global::System.Threading.Tasks.ValueTask<global::System.Int32>(_context.Return(_value));
            throw new global::Lua.LuaRuntimeException(_context.Thread, $"attempt to assign to unknown '{_key}' on '{_this}'", 2);
        });

        public virtual global::System.Boolean TryGetLuaValue(global::System.Int32 _key, out global::Lua.LuaValue _value, global::Luny.ILuaObjectFactory _factory)
        {
            _value = global::Lua.LuaValue.Nil; return false;
        }
        public virtual global::System.Boolean TryGetLuaValue(global::System.String _key, out global::Lua.LuaValue _value, global::Luny.ILuaObjectFactory _factory)
        {
            switch (_key)
            {
                case "AddSingleGO": _value = _LuaPreviewRenderUtility_AddSingleGO; return true;
                case "BeginPreview": _value = _LuaPreviewRenderUtility_BeginPreview; return true;
                case "BeginStaticPreview": _value = _LuaPreviewRenderUtility_BeginStaticPreview; return true;
                case "Cleanup": _value = _LuaPreviewRenderUtility_Cleanup; return true;
                case "DrawMesh": _value = _LuaPreviewRenderUtility_DrawMesh; return true;
                case "EndAndDrawPreview": _value = _LuaPreviewRenderUtility_EndAndDrawPreview; return true;
                case "EndPreview": _value = _LuaPreviewRenderUtility_EndPreview; return true;
                case "EndStaticPreview": _value = _LuaPreviewRenderUtility_EndStaticPreview; return true;
                case "GetScaleFactor": _value = _LuaPreviewRenderUtility_GetScaleFactor; return true;
                case "InstantiatePrefabInScene": _value = _LuaPreviewRenderUtility_InstantiatePrefabInScene; return true;
                case "Render": _value = _LuaPreviewRenderUtility_Render; return true;
                case "ambientColor": _value = global::Luny.UnityEngine.LuaColor.Bind(Instance.ambientColor); return true;
                case "camera": _value = _factory.Bind(Instance.camera); return true;
                case "cameraFieldOfView": _value = new global::Lua.LuaValue(Instance.cameraFieldOfView); return true;
                case "lights": _value = _factory.Bind(Instance.lights); return true;
                default: _value = global::Lua.LuaValue.Nil; return false;
            }
        }
        public virtual global::System.Boolean TrySetLuaValue(global::System.Int32 _key, global::Lua.LuaValue _value)
        {
            return false;
        }
        public virtual global::System.Boolean TrySetLuaValue(global::System.String _key, global::Lua.LuaValue _value)
        {
            switch (_key)
            {
                case "ambientColor": Instance.ambientColor = _value.Read<global::Luny.UnityEngine.LuaColor>().Value;  return true;
                case "cameraFieldOfView": Instance.cameraFieldOfView = _value.Read<global::System.Single>();  return true;
                default: return false;
            }
        }
    }
    public sealed class LuaPreviewRenderUtilityType : global::Luny.ILuaStatic
    {
        public static global::Lua.LuaValue Bind() => new LuaPreviewRenderUtilityType();
        private LuaPreviewRenderUtilityType() {}
        public static implicit operator global::Lua.LuaValue(LuaPreviewRenderUtilityType value) => new(value);
        public global::System.Type BindType => typeof(global::UnityEditor.PreviewRenderUtility);
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
            metatable[global::Lua.Runtime.Metamethods.Call] = _LuaPreviewRenderUtility_new;
            return metatable;
        }
        public override global::System.String ToString() => BindType.FullName;
#if UNITY_EDITOR
        [global::UnityEngine.RuntimeInitializeOnLoadMethod(global::UnityEngine.RuntimeInitializeLoadType.SubsystemRegistration)]
        private static void ResetStaticFields() => s_Metatable = null;
#endif

        private static readonly global::Lua.LuaFunction _LuaPreviewRenderUtility_new = new global::Lua.LuaFunction(".ctor", (_context, _) =>
        {
            global::Lua.LuaValue _lastArg = default;
            global::System.Int32 _lastArgPos = default;
            global::System.Type _expectedType = default;
            var _argCount = _context.ArgumentCount;
            if (_argCount == 1)
            {
                var _ret0 = new global::UnityEditor.PreviewRenderUtility();
                var _factory = _context.GetObjectFactory();
                var _lret0 = _factory.Bind(_ret0);
                var _retCount = _context.Return(_lret0);
                return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
            }
            var _arg0 = _lastArg = _argCount > 1 ? _context.GetArgument(1) : global::Lua.LuaValue.Nil;
            _lastArgPos = 0; _expectedType = typeof(global::System.Boolean);
            if (_arg0.TryRead<global::System.Boolean>(out var _p0_System_Boolean))
            {
                if (_argCount == 2)
                {
                    var renderFullScene = _p0_System_Boolean;
                    var _ret0 = new global::UnityEditor.PreviewRenderUtility(renderFullScene);
                    var _factory = _context.GetObjectFactory();
                    var _lret0 = _factory.Bind(_ret0);
                    var _retCount = _context.Return(_lret0);
                    return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                }
                var _arg1 = _lastArg = _argCount > 2 ? _context.GetArgument(2) : global::Lua.LuaValue.Nil;
                _lastArgPos = 1; _expectedType = typeof(global::System.Boolean);
                if (_arg1.TryRead<global::System.Boolean>(out var _p1_System_Boolean))
                {
                    if (_argCount == 3)
                    {
                        var renderFullScene = _p0_System_Boolean;
                        var pixelPerfect = _p1_System_Boolean;
                        var _ret0 = new global::UnityEditor.PreviewRenderUtility(renderFullScene, pixelPerfect);
                        var _factory = _context.GetObjectFactory();
                        var _lret0 = _factory.Bind(_ret0);
                        var _retCount = _context.Return(_lret0);
                        return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                    }
                }
            }
            throw new global::Lua.LuaRuntimeException(_context.Thread, $"{".ctor"}: invalid argument #{_lastArgPos}: {_lastArg} ({_lastArg.Type}), expected: {_expectedType.FullName}", 2);
        });
        private static readonly global::Lua.LuaFunction __index = new(global::Lua.Runtime.Metamethods.Index, (_context, _) =>
        {
            var _this = _context.GetArgument<LuaPreviewRenderUtilityType>(0);
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
            var _this = _context.GetArgument<LuaPreviewRenderUtilityType>(0);
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
