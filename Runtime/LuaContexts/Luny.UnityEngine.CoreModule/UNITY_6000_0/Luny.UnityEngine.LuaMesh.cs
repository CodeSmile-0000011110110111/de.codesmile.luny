
// --------------------------------------------------------------
// GENERATED FILE ----> DO NOT EDIT <---- CHANGES WILL BE LOST !!
// --------------------------------------------------------------

#if UNITY_6000_0_OR_NEWER && !(UNITY_6000_1_OR_NEWER)
#pragma warning disable 0109, 0162, 0168, 0219
using Luny;

namespace Luny.UnityEngine
{
    public sealed class LuaMesh : LuaUnityObject, global::Luny.ILuaObject<global::UnityEngine.Mesh>
    {
        public new static global::Lua.LuaValue Bind(global::UnityEngine.Mesh instance) => new LuaMesh(instance);
        public new static global::Lua.LuaValue Bind(global::System.Object instance) => Bind((global::UnityEngine.Mesh)instance);
        public new static global::Lua.LuaValue Bind(global::System.Collections.Generic.IList<global::UnityEngine.Mesh> instances) =>
            new global::Luny.LuaList<global::UnityEngine.Mesh>(instances);
        public new static global::Lua.LuaValue Bind(global::System.Collections.Generic.IList<global::System.Object> instances) =>
            new global::Luny.LuaList<global::UnityEngine.Mesh>(instances);
        private LuaMesh(global::UnityEngine.Mesh instance) : base(instance) {}
        public static implicit operator global::Lua.LuaValue(LuaMesh value) => new(value);
        public new global::UnityEngine.Mesh Instance => (global::UnityEngine.Mesh)m_Instance;
        public new global::System.Type BindType => typeof(global::UnityEngine.Mesh);
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

        private static readonly global::Lua.LuaFunction _LuaMesh_AddBlendShapeFrame = new global::Lua.LuaFunction("AddBlendShapeFrame", (_context, _) =>
        {
            global::Lua.LuaValue _lastArg = default;
            global::System.Int32 _lastArgPos = default;
            global::System.Type _expectedType = default;
            var _argCount = _context.ArgumentCount;
            var _this = _context.GetArgument<LuaMesh>(0);
            var _arg0 = _lastArg = _argCount > 1 ? _context.GetArgument(1) : global::Lua.LuaValue.Nil;
            _lastArgPos = 0; _expectedType = typeof(global::System.String);
            if (_arg0.TryRead<global::System.String>(out var _p0_System_String))
            {
                var _arg1 = _lastArg = _argCount > 2 ? _context.GetArgument(2) : global::Lua.LuaValue.Nil;
                _lastArgPos = 1; _expectedType = typeof(global::System.Single);
                if (_arg1.TryRead<global::System.Single>(out var _p1_System_Single))
                {
                    var _arg2 = _lastArg = _argCount > 3 ? _context.GetArgument(3) : global::Lua.LuaValue.Nil;
                    _lastArgPos = 2; _expectedType = typeof(global::UnityEngine.Vector3[]);
                    if (_arg2.TryReadArray<global::UnityEngine.Vector3>(out var _p2_UnityEngine_Vector3Array))
                    {
                        var _arg3 = _lastArg = _argCount > 4 ? _context.GetArgument(4) : global::Lua.LuaValue.Nil;
                        _lastArgPos = 3; _expectedType = typeof(global::UnityEngine.Vector3[]);
                        if (_arg3.TryReadArray<global::UnityEngine.Vector3>(out var _p3_UnityEngine_Vector3Array))
                        {
                            var _arg4 = _lastArg = _argCount > 5 ? _context.GetArgument(5) : global::Lua.LuaValue.Nil;
                            _lastArgPos = 4; _expectedType = typeof(global::UnityEngine.Vector3[]);
                            if (_arg4.TryReadArray<global::UnityEngine.Vector3>(out var _p4_UnityEngine_Vector3Array))
                            {
                                if (_argCount == 6)
                                {
                                    var shapeName = _p0_System_String;
                                    var frameWeight = _p1_System_Single;
                                    var deltaVertices = _p2_UnityEngine_Vector3Array;
                                    var deltaNormals = _p3_UnityEngine_Vector3Array;
                                    var deltaTangents = _p4_UnityEngine_Vector3Array;
                                    _this.Instance.AddBlendShapeFrame(shapeName, frameWeight, deltaVertices, deltaNormals, deltaTangents);
                                    var _retCount = _context.Return();
                                    return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                                }
                            }
                        }
                    }
                }
            }
            throw new global::Lua.LuaRuntimeException(_context.Thread, $"{"AddBlendShapeFrame"}: invalid argument #{_lastArgPos}: {_lastArg} ({_lastArg.Type}), expected: {_expectedType.FullName}", 2);
        });
        private static readonly global::Lua.LuaFunction _LuaMesh_Clear = new global::Lua.LuaFunction("Clear", (_context, _) =>
        {
            global::Lua.LuaValue _lastArg = default;
            global::System.Int32 _lastArgPos = default;
            global::System.Type _expectedType = default;
            var _argCount = _context.ArgumentCount;
            var _this = _context.GetArgument<LuaMesh>(0);
            if (_argCount == 1)
            {
                _this.Instance.Clear();
                var _retCount = _context.Return();
                return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
            }
            var _arg0 = _lastArg = _argCount > 1 ? _context.GetArgument(1) : global::Lua.LuaValue.Nil;
            _lastArgPos = 0; _expectedType = typeof(global::System.Boolean);
            if (_arg0.TryRead<global::System.Boolean>(out var _p0_System_Boolean))
            {
                if (_argCount == 2)
                {
                    var keepVertexLayout = _p0_System_Boolean;
                    _this.Instance.Clear(keepVertexLayout);
                    var _retCount = _context.Return();
                    return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                }
            }
            throw new global::Lua.LuaRuntimeException(_context.Thread, $"{"Clear"}: invalid argument #{_lastArgPos}: {_lastArg} ({_lastArg.Type}), expected: {_expectedType.FullName}", 2);
        });
        private static readonly global::Lua.LuaFunction _LuaMesh_ClearBlendShapes = new global::Lua.LuaFunction("ClearBlendShapes", (_context, _) =>
        {
            global::Lua.LuaValue _lastArg = default;
            global::System.Int32 _lastArgPos = default;
            global::System.Type _expectedType = default;
            var _argCount = _context.ArgumentCount;
            var _this = _context.GetArgument<LuaMesh>(0);
            if (_argCount == 1)
            {
                _this.Instance.ClearBlendShapes();
                var _retCount = _context.Return();
                return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
            }
            throw new global::Lua.LuaRuntimeException(_context.Thread, $"{"ClearBlendShapes"}: invalid argument #{_lastArgPos}: {_lastArg} ({_lastArg.Type}), expected: {_expectedType.FullName}", 2);
        });
        private static readonly global::Lua.LuaFunction _LuaMesh_CombineMeshes = new global::Lua.LuaFunction("CombineMeshes", (_context, _) =>
        {
            global::Lua.LuaValue _lastArg = default;
            global::System.Int32 _lastArgPos = default;
            global::System.Type _expectedType = default;
            var _argCount = _context.ArgumentCount;
            var _this = _context.GetArgument<LuaMesh>(0);
            var _arg0 = _lastArg = _argCount > 1 ? _context.GetArgument(1) : global::Lua.LuaValue.Nil;
            _lastArgPos = 0; _expectedType = typeof(global::UnityEngine.CombineInstance[]);
            if (_arg0.TryReadArray<global::UnityEngine.CombineInstance>(out var _p0_UnityEngine_CombineInstanceArray))
            {
                if (_argCount == 2)
                {
                    var combine = _p0_UnityEngine_CombineInstanceArray;
                    _this.Instance.CombineMeshes(combine);
                    var _retCount = _context.Return();
                    return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                }
                var _arg1 = _lastArg = _argCount > 2 ? _context.GetArgument(2) : global::Lua.LuaValue.Nil;
                _lastArgPos = 1; _expectedType = typeof(global::System.Boolean);
                if (_arg1.TryRead<global::System.Boolean>(out var _p1_System_Boolean))
                {
                    if (_argCount == 3)
                    {
                        var combine = _p0_UnityEngine_CombineInstanceArray;
                        var mergeSubMeshes = _p1_System_Boolean;
                        _this.Instance.CombineMeshes(combine, mergeSubMeshes);
                        var _retCount = _context.Return();
                        return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                    }
                    var _arg2 = _lastArg = _argCount > 3 ? _context.GetArgument(3) : global::Lua.LuaValue.Nil;
                    _lastArgPos = 2; _expectedType = typeof(global::System.Boolean);
                    if (_arg2.TryRead<global::System.Boolean>(out var _p2_System_Boolean))
                    {
                        if (_argCount == 4)
                        {
                            var combine = _p0_UnityEngine_CombineInstanceArray;
                            var mergeSubMeshes = _p1_System_Boolean;
                            var useMatrices = _p2_System_Boolean;
                            _this.Instance.CombineMeshes(combine, mergeSubMeshes, useMatrices);
                            var _retCount = _context.Return();
                            return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                        }
                        var _arg3 = _lastArg = _argCount > 4 ? _context.GetArgument(4) : global::Lua.LuaValue.Nil;
                        _lastArgPos = 3; _expectedType = typeof(global::System.Boolean);
                        if (_arg3.TryRead<global::System.Boolean>(out var _p3_System_Boolean))
                        {
                            if (_argCount == 5)
                            {
                                var combine = _p0_UnityEngine_CombineInstanceArray;
                                var mergeSubMeshes = _p1_System_Boolean;
                                var useMatrices = _p2_System_Boolean;
                                var hasLightmapData = _p3_System_Boolean;
                                _this.Instance.CombineMeshes(combine, mergeSubMeshes, useMatrices, hasLightmapData);
                                var _retCount = _context.Return();
                                return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                            }
                        }
                    }
                }
            }
            throw new global::Lua.LuaRuntimeException(_context.Thread, $"{"CombineMeshes"}: invalid argument #{_lastArgPos}: {_lastArg} ({_lastArg.Type}), expected: {_expectedType.FullName}", 2);
        });
        private static readonly global::Lua.LuaFunction _LuaMesh_GetBaseVertex = new global::Lua.LuaFunction("GetBaseVertex", (_context, _) =>
        {
            global::Lua.LuaValue _lastArg = default;
            global::System.Int32 _lastArgPos = default;
            global::System.Type _expectedType = default;
            var _argCount = _context.ArgumentCount;
            var _this = _context.GetArgument<LuaMesh>(0);
            var _arg0 = _lastArg = _argCount > 1 ? _context.GetArgument(1) : global::Lua.LuaValue.Nil;
            _lastArgPos = 0; _expectedType = typeof(global::System.Int32);
            if (_arg0.TryRead<global::System.Int32>(out var _p0_System_Int32))
            {
                if (_argCount == 2)
                {
                    var submesh = _p0_System_Int32;
                    var _ret0 = _this.Instance.GetBaseVertex(submesh);
                    var _lret0 = new global::Lua.LuaValue(_ret0);
                    var _retCount = _context.Return(_lret0);
                    return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                }
            }
            throw new global::Lua.LuaRuntimeException(_context.Thread, $"{"GetBaseVertex"}: invalid argument #{_lastArgPos}: {_lastArg} ({_lastArg.Type}), expected: {_expectedType.FullName}", 2);
        });
        private static readonly global::Lua.LuaFunction _LuaMesh_GetBlendShapeBuffer = new global::Lua.LuaFunction("GetBlendShapeBuffer", (_context, _) =>
        {
            global::Lua.LuaValue _lastArg = default;
            global::System.Int32 _lastArgPos = default;
            global::System.Type _expectedType = default;
            var _argCount = _context.ArgumentCount;
            var _this = _context.GetArgument<LuaMesh>(0);
            if (_argCount == 1)
            {
                var _ret0 = _this.Instance.GetBlendShapeBuffer();
                var _factory = _context.GetObjectFactory();
                var _lret0 = _factory.Bind(_ret0);
                var _retCount = _context.Return(_lret0);
                return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
            }
            var _arg0 = _lastArg = _argCount > 1 ? _context.GetArgument(1) : global::Lua.LuaValue.Nil;
            _lastArgPos = 0; _expectedType = typeof(global::UnityEngine.Rendering.BlendShapeBufferLayout);
            if (_arg0.TryRead<global::UnityEngine.Rendering.BlendShapeBufferLayout>(out var _p0_UnityEngine_Rendering_BlendShapeBufferLayout))
            {
                if (_argCount == 2)
                {
                    var layout = _p0_UnityEngine_Rendering_BlendShapeBufferLayout;
                    var _ret0 = _this.Instance.GetBlendShapeBuffer(layout);
                    var _factory = _context.GetObjectFactory();
                    var _lret0 = _factory.Bind(_ret0);
                    var _retCount = _context.Return(_lret0);
                    return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                }
            }
            throw new global::Lua.LuaRuntimeException(_context.Thread, $"{"GetBlendShapeBuffer"}: invalid argument #{_lastArgPos}: {_lastArg} ({_lastArg.Type}), expected: {_expectedType.FullName}", 2);
        });
        private static readonly global::Lua.LuaFunction _LuaMesh_GetBlendShapeBufferRange = new global::Lua.LuaFunction("GetBlendShapeBufferRange", (_context, _) =>
        {
            global::Lua.LuaValue _lastArg = default;
            global::System.Int32 _lastArgPos = default;
            global::System.Type _expectedType = default;
            var _argCount = _context.ArgumentCount;
            var _this = _context.GetArgument<LuaMesh>(0);
            var _arg0 = _lastArg = _argCount > 1 ? _context.GetArgument(1) : global::Lua.LuaValue.Nil;
            _lastArgPos = 0; _expectedType = typeof(global::System.Int32);
            if (_arg0.TryRead<global::System.Int32>(out var _p0_System_Int32))
            {
                if (_argCount == 2)
                {
                    var blendShapeIndex = _p0_System_Int32;
                    var _ret0 = _this.Instance.GetBlendShapeBufferRange(blendShapeIndex);
                    var _lret0 = global::Luny.UnityEngine.LuaBlendShapeBufferRange.Bind(_ret0);
                    var _retCount = _context.Return(_lret0);
                    return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                }
            }
            throw new global::Lua.LuaRuntimeException(_context.Thread, $"{"GetBlendShapeBufferRange"}: invalid argument #{_lastArgPos}: {_lastArg} ({_lastArg.Type}), expected: {_expectedType.FullName}", 2);
        });
        private static readonly global::Lua.LuaFunction _LuaMesh_GetBlendShapeFrameCount = new global::Lua.LuaFunction("GetBlendShapeFrameCount", (_context, _) =>
        {
            global::Lua.LuaValue _lastArg = default;
            global::System.Int32 _lastArgPos = default;
            global::System.Type _expectedType = default;
            var _argCount = _context.ArgumentCount;
            var _this = _context.GetArgument<LuaMesh>(0);
            var _arg0 = _lastArg = _argCount > 1 ? _context.GetArgument(1) : global::Lua.LuaValue.Nil;
            _lastArgPos = 0; _expectedType = typeof(global::System.Int32);
            if (_arg0.TryRead<global::System.Int32>(out var _p0_System_Int32))
            {
                if (_argCount == 2)
                {
                    var shapeIndex = _p0_System_Int32;
                    var _ret0 = _this.Instance.GetBlendShapeFrameCount(shapeIndex);
                    var _lret0 = new global::Lua.LuaValue(_ret0);
                    var _retCount = _context.Return(_lret0);
                    return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                }
            }
            throw new global::Lua.LuaRuntimeException(_context.Thread, $"{"GetBlendShapeFrameCount"}: invalid argument #{_lastArgPos}: {_lastArg} ({_lastArg.Type}), expected: {_expectedType.FullName}", 2);
        });
        private static readonly global::Lua.LuaFunction _LuaMesh_GetBlendShapeFrameVertices = new global::Lua.LuaFunction("GetBlendShapeFrameVertices", (_context, _) =>
        {
            global::Lua.LuaValue _lastArg = default;
            global::System.Int32 _lastArgPos = default;
            global::System.Type _expectedType = default;
            var _argCount = _context.ArgumentCount;
            var _this = _context.GetArgument<LuaMesh>(0);
            var _arg0 = _lastArg = _argCount > 1 ? _context.GetArgument(1) : global::Lua.LuaValue.Nil;
            _lastArgPos = 0; _expectedType = typeof(global::System.Int32);
            if (_arg0.TryRead<global::System.Int32>(out var _p0_System_Int32))
            {
                var _arg1 = _lastArg = _argCount > 2 ? _context.GetArgument(2) : global::Lua.LuaValue.Nil;
                _lastArgPos = 1; _expectedType = typeof(global::System.Int32);
                if (_arg1.TryRead<global::System.Int32>(out var _p1_System_Int32))
                {
                    var _arg2 = _lastArg = _argCount > 3 ? _context.GetArgument(3) : global::Lua.LuaValue.Nil;
                    _lastArgPos = 2; _expectedType = typeof(global::UnityEngine.Vector3[]);
                    if (_arg2.TryReadArray<global::UnityEngine.Vector3>(out var _p2_UnityEngine_Vector3Array))
                    {
                        var _arg3 = _lastArg = _argCount > 4 ? _context.GetArgument(4) : global::Lua.LuaValue.Nil;
                        _lastArgPos = 3; _expectedType = typeof(global::UnityEngine.Vector3[]);
                        if (_arg3.TryReadArray<global::UnityEngine.Vector3>(out var _p3_UnityEngine_Vector3Array))
                        {
                            var _arg4 = _lastArg = _argCount > 5 ? _context.GetArgument(5) : global::Lua.LuaValue.Nil;
                            _lastArgPos = 4; _expectedType = typeof(global::UnityEngine.Vector3[]);
                            if (_arg4.TryReadArray<global::UnityEngine.Vector3>(out var _p4_UnityEngine_Vector3Array))
                            {
                                if (_argCount == 6)
                                {
                                    var shapeIndex = _p0_System_Int32;
                                    var frameIndex = _p1_System_Int32;
                                    var deltaVertices = _p2_UnityEngine_Vector3Array;
                                    var deltaNormals = _p3_UnityEngine_Vector3Array;
                                    var deltaTangents = _p4_UnityEngine_Vector3Array;
                                    _this.Instance.GetBlendShapeFrameVertices(shapeIndex, frameIndex, deltaVertices, deltaNormals, deltaTangents);
                                    var _retCount = _context.Return();
                                    return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                                }
                            }
                        }
                    }
                }
            }
            throw new global::Lua.LuaRuntimeException(_context.Thread, $"{"GetBlendShapeFrameVertices"}: invalid argument #{_lastArgPos}: {_lastArg} ({_lastArg.Type}), expected: {_expectedType.FullName}", 2);
        });
        private static readonly global::Lua.LuaFunction _LuaMesh_GetBlendShapeFrameWeight = new global::Lua.LuaFunction("GetBlendShapeFrameWeight", (_context, _) =>
        {
            global::Lua.LuaValue _lastArg = default;
            global::System.Int32 _lastArgPos = default;
            global::System.Type _expectedType = default;
            var _argCount = _context.ArgumentCount;
            var _this = _context.GetArgument<LuaMesh>(0);
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
                        var shapeIndex = _p0_System_Int32;
                        var frameIndex = _p1_System_Int32;
                        var _ret0 = _this.Instance.GetBlendShapeFrameWeight(shapeIndex, frameIndex);
                        var _lret0 = new global::Lua.LuaValue(_ret0);
                        var _retCount = _context.Return(_lret0);
                        return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                    }
                }
            }
            throw new global::Lua.LuaRuntimeException(_context.Thread, $"{"GetBlendShapeFrameWeight"}: invalid argument #{_lastArgPos}: {_lastArg} ({_lastArg.Type}), expected: {_expectedType.FullName}", 2);
        });
        private static readonly global::Lua.LuaFunction _LuaMesh_GetBlendShapeIndex = new global::Lua.LuaFunction("GetBlendShapeIndex", (_context, _) =>
        {
            global::Lua.LuaValue _lastArg = default;
            global::System.Int32 _lastArgPos = default;
            global::System.Type _expectedType = default;
            var _argCount = _context.ArgumentCount;
            var _this = _context.GetArgument<LuaMesh>(0);
            var _arg0 = _lastArg = _argCount > 1 ? _context.GetArgument(1) : global::Lua.LuaValue.Nil;
            _lastArgPos = 0; _expectedType = typeof(global::System.String);
            if (_arg0.TryRead<global::System.String>(out var _p0_System_String))
            {
                if (_argCount == 2)
                {
                    var blendShapeName = _p0_System_String;
                    var _ret0 = _this.Instance.GetBlendShapeIndex(blendShapeName);
                    var _lret0 = new global::Lua.LuaValue(_ret0);
                    var _retCount = _context.Return(_lret0);
                    return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                }
            }
            throw new global::Lua.LuaRuntimeException(_context.Thread, $"{"GetBlendShapeIndex"}: invalid argument #{_lastArgPos}: {_lastArg} ({_lastArg.Type}), expected: {_expectedType.FullName}", 2);
        });
        private static readonly global::Lua.LuaFunction _LuaMesh_GetBlendShapeName = new global::Lua.LuaFunction("GetBlendShapeName", (_context, _) =>
        {
            global::Lua.LuaValue _lastArg = default;
            global::System.Int32 _lastArgPos = default;
            global::System.Type _expectedType = default;
            var _argCount = _context.ArgumentCount;
            var _this = _context.GetArgument<LuaMesh>(0);
            var _arg0 = _lastArg = _argCount > 1 ? _context.GetArgument(1) : global::Lua.LuaValue.Nil;
            _lastArgPos = 0; _expectedType = typeof(global::System.Int32);
            if (_arg0.TryRead<global::System.Int32>(out var _p0_System_Int32))
            {
                if (_argCount == 2)
                {
                    var shapeIndex = _p0_System_Int32;
                    var _ret0 = _this.Instance.GetBlendShapeName(shapeIndex);
                    var _lret0 = new global::Lua.LuaValue(_ret0);
                    var _retCount = _context.Return(_lret0);
                    return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                }
            }
            throw new global::Lua.LuaRuntimeException(_context.Thread, $"{"GetBlendShapeName"}: invalid argument #{_lastArgPos}: {_lastArg} ({_lastArg.Type}), expected: {_expectedType.FullName}", 2);
        });
        private static readonly global::Lua.LuaFunction _LuaMesh_GetBoneWeightBuffer = new global::Lua.LuaFunction("GetBoneWeightBuffer", (_context, _) =>
        {
            global::Lua.LuaValue _lastArg = default;
            global::System.Int32 _lastArgPos = default;
            global::System.Type _expectedType = default;
            var _argCount = _context.ArgumentCount;
            var _this = _context.GetArgument<LuaMesh>(0);
            var _arg0 = _lastArg = _argCount > 1 ? _context.GetArgument(1) : global::Lua.LuaValue.Nil;
            _lastArgPos = 0; _expectedType = typeof(global::UnityEngine.SkinWeights);
            if (_arg0.TryRead<global::UnityEngine.SkinWeights>(out var _p0_UnityEngine_SkinWeights))
            {
                if (_argCount == 2)
                {
                    var layout = _p0_UnityEngine_SkinWeights;
                    var _ret0 = _this.Instance.GetBoneWeightBuffer(layout);
                    var _factory = _context.GetObjectFactory();
                    var _lret0 = _factory.Bind(_ret0);
                    var _retCount = _context.Return(_lret0);
                    return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                }
            }
            throw new global::Lua.LuaRuntimeException(_context.Thread, $"{"GetBoneWeightBuffer"}: invalid argument #{_lastArgPos}: {_lastArg} ({_lastArg.Type}), expected: {_expectedType.FullName}", 2);
        });
        private static readonly global::Lua.LuaFunction _LuaMesh_GetIndexBuffer = new global::Lua.LuaFunction("GetIndexBuffer", (_context, _) =>
        {
            global::Lua.LuaValue _lastArg = default;
            global::System.Int32 _lastArgPos = default;
            global::System.Type _expectedType = default;
            var _argCount = _context.ArgumentCount;
            var _this = _context.GetArgument<LuaMesh>(0);
            if (_argCount == 1)
            {
                var _ret0 = _this.Instance.GetIndexBuffer();
                var _factory = _context.GetObjectFactory();
                var _lret0 = _factory.Bind(_ret0);
                var _retCount = _context.Return(_lret0);
                return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
            }
            throw new global::Lua.LuaRuntimeException(_context.Thread, $"{"GetIndexBuffer"}: invalid argument #{_lastArgPos}: {_lastArg} ({_lastArg.Type}), expected: {_expectedType.FullName}", 2);
        });
        private static readonly global::Lua.LuaFunction _LuaMesh_GetIndexCount = new global::Lua.LuaFunction("GetIndexCount", (_context, _) =>
        {
            global::Lua.LuaValue _lastArg = default;
            global::System.Int32 _lastArgPos = default;
            global::System.Type _expectedType = default;
            var _argCount = _context.ArgumentCount;
            var _this = _context.GetArgument<LuaMesh>(0);
            var _arg0 = _lastArg = _argCount > 1 ? _context.GetArgument(1) : global::Lua.LuaValue.Nil;
            _lastArgPos = 0; _expectedType = typeof(global::System.Int32);
            if (_arg0.TryRead<global::System.Int32>(out var _p0_System_Int32))
            {
                if (_argCount == 2)
                {
                    var submesh = _p0_System_Int32;
                    var _ret0 = _this.Instance.GetIndexCount(submesh);
                    var _lret0 = new global::Lua.LuaValue(_ret0);
                    var _retCount = _context.Return(_lret0);
                    return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                }
            }
            throw new global::Lua.LuaRuntimeException(_context.Thread, $"{"GetIndexCount"}: invalid argument #{_lastArgPos}: {_lastArg} ({_lastArg.Type}), expected: {_expectedType.FullName}", 2);
        });
        private static readonly global::Lua.LuaFunction _LuaMesh_GetIndexStart = new global::Lua.LuaFunction("GetIndexStart", (_context, _) =>
        {
            global::Lua.LuaValue _lastArg = default;
            global::System.Int32 _lastArgPos = default;
            global::System.Type _expectedType = default;
            var _argCount = _context.ArgumentCount;
            var _this = _context.GetArgument<LuaMesh>(0);
            var _arg0 = _lastArg = _argCount > 1 ? _context.GetArgument(1) : global::Lua.LuaValue.Nil;
            _lastArgPos = 0; _expectedType = typeof(global::System.Int32);
            if (_arg0.TryRead<global::System.Int32>(out var _p0_System_Int32))
            {
                if (_argCount == 2)
                {
                    var submesh = _p0_System_Int32;
                    var _ret0 = _this.Instance.GetIndexStart(submesh);
                    var _lret0 = new global::Lua.LuaValue(_ret0);
                    var _retCount = _context.Return(_lret0);
                    return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                }
            }
            throw new global::Lua.LuaRuntimeException(_context.Thread, $"{"GetIndexStart"}: invalid argument #{_lastArgPos}: {_lastArg} ({_lastArg.Type}), expected: {_expectedType.FullName}", 2);
        });
        private static readonly global::Lua.LuaFunction _LuaMesh_GetIndices = new global::Lua.LuaFunction("GetIndices", (_context, _) =>
        {
            global::Lua.LuaValue _lastArg = default;
            global::System.Int32 _lastArgPos = default;
            global::System.Type _expectedType = default;
            var _argCount = _context.ArgumentCount;
            var _this = _context.GetArgument<LuaMesh>(0);
            var _arg0 = _lastArg = _argCount > 1 ? _context.GetArgument(1) : global::Lua.LuaValue.Nil;
            _lastArgPos = 0; _expectedType = typeof(global::System.Int32);
            if (_arg0.TryRead<global::System.Int32>(out var _p0_System_Int32))
            {
                if (_argCount == 2)
                {
                    var submesh = _p0_System_Int32;
                    var _ret0 = _this.Instance.GetIndices(submesh);
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
                        var submesh = _p0_System_Int32;
                        var applyBaseVertex = _p1_System_Boolean;
                        var _ret0 = _this.Instance.GetIndices(submesh, applyBaseVertex);
                        var _factory = _context.GetObjectFactory();
                        var _lret0 = _factory.Bind(_ret0);
                        var _retCount = _context.Return(_lret0);
                        return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                    }
                }
            }
            throw new global::Lua.LuaRuntimeException(_context.Thread, $"{"GetIndices"}: invalid argument #{_lastArgPos}: {_lastArg} ({_lastArg.Type}), expected: {_expectedType.FullName}", 2);
        });
        private static readonly global::Lua.LuaFunction _LuaMesh_GetSubMesh = new global::Lua.LuaFunction("GetSubMesh", (_context, _) =>
        {
            global::Lua.LuaValue _lastArg = default;
            global::System.Int32 _lastArgPos = default;
            global::System.Type _expectedType = default;
            var _argCount = _context.ArgumentCount;
            var _this = _context.GetArgument<LuaMesh>(0);
            var _arg0 = _lastArg = _argCount > 1 ? _context.GetArgument(1) : global::Lua.LuaValue.Nil;
            _lastArgPos = 0; _expectedType = typeof(global::System.Int32);
            if (_arg0.TryRead<global::System.Int32>(out var _p0_System_Int32))
            {
                if (_argCount == 2)
                {
                    var index = _p0_System_Int32;
                    var _ret0 = _this.Instance.GetSubMesh(index);
                    var _lret0 = global::Luny.UnityEngine.Rendering.LuaSubMeshDescriptor.Bind(_ret0);
                    var _retCount = _context.Return(_lret0);
                    return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                }
            }
            throw new global::Lua.LuaRuntimeException(_context.Thread, $"{"GetSubMesh"}: invalid argument #{_lastArgPos}: {_lastArg} ({_lastArg.Type}), expected: {_expectedType.FullName}", 2);
        });
        private static readonly global::Lua.LuaFunction _LuaMesh_GetTopology = new global::Lua.LuaFunction("GetTopology", (_context, _) =>
        {
            global::Lua.LuaValue _lastArg = default;
            global::System.Int32 _lastArgPos = default;
            global::System.Type _expectedType = default;
            var _argCount = _context.ArgumentCount;
            var _this = _context.GetArgument<LuaMesh>(0);
            var _arg0 = _lastArg = _argCount > 1 ? _context.GetArgument(1) : global::Lua.LuaValue.Nil;
            _lastArgPos = 0; _expectedType = typeof(global::System.Int32);
            if (_arg0.TryRead<global::System.Int32>(out var _p0_System_Int32))
            {
                if (_argCount == 2)
                {
                    var submesh = _p0_System_Int32;
                    var _ret0 = _this.Instance.GetTopology(submesh);
                    var _lret0 = new global::Lua.LuaValue((global::System.Int64)_ret0);
                    var _retCount = _context.Return(_lret0);
                    return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                }
            }
            throw new global::Lua.LuaRuntimeException(_context.Thread, $"{"GetTopology"}: invalid argument #{_lastArgPos}: {_lastArg} ({_lastArg.Type}), expected: {_expectedType.FullName}", 2);
        });
        private static readonly global::Lua.LuaFunction _LuaMesh_GetTriangles = new global::Lua.LuaFunction("GetTriangles", (_context, _) =>
        {
            global::Lua.LuaValue _lastArg = default;
            global::System.Int32 _lastArgPos = default;
            global::System.Type _expectedType = default;
            var _argCount = _context.ArgumentCount;
            var _this = _context.GetArgument<LuaMesh>(0);
            var _arg0 = _lastArg = _argCount > 1 ? _context.GetArgument(1) : global::Lua.LuaValue.Nil;
            _lastArgPos = 0; _expectedType = typeof(global::System.Int32);
            if (_arg0.TryRead<global::System.Int32>(out var _p0_System_Int32))
            {
                if (_argCount == 2)
                {
                    var submesh = _p0_System_Int32;
                    var _ret0 = _this.Instance.GetTriangles(submesh);
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
                        var submesh = _p0_System_Int32;
                        var applyBaseVertex = _p1_System_Boolean;
                        var _ret0 = _this.Instance.GetTriangles(submesh, applyBaseVertex);
                        var _factory = _context.GetObjectFactory();
                        var _lret0 = _factory.Bind(_ret0);
                        var _retCount = _context.Return(_lret0);
                        return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                    }
                }
            }
            throw new global::Lua.LuaRuntimeException(_context.Thread, $"{"GetTriangles"}: invalid argument #{_lastArgPos}: {_lastArg} ({_lastArg.Type}), expected: {_expectedType.FullName}", 2);
        });
        private static readonly global::Lua.LuaFunction _LuaMesh_GetUVDistributionMetric = new global::Lua.LuaFunction("GetUVDistributionMetric", (_context, _) =>
        {
            global::Lua.LuaValue _lastArg = default;
            global::System.Int32 _lastArgPos = default;
            global::System.Type _expectedType = default;
            var _argCount = _context.ArgumentCount;
            var _this = _context.GetArgument<LuaMesh>(0);
            var _arg0 = _lastArg = _argCount > 1 ? _context.GetArgument(1) : global::Lua.LuaValue.Nil;
            _lastArgPos = 0; _expectedType = typeof(global::System.Int32);
            if (_arg0.TryRead<global::System.Int32>(out var _p0_System_Int32))
            {
                if (_argCount == 2)
                {
                    var uvSetIndex = _p0_System_Int32;
                    var _ret0 = _this.Instance.GetUVDistributionMetric(uvSetIndex);
                    var _lret0 = new global::Lua.LuaValue(_ret0);
                    var _retCount = _context.Return(_lret0);
                    return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                }
            }
            throw new global::Lua.LuaRuntimeException(_context.Thread, $"{"GetUVDistributionMetric"}: invalid argument #{_lastArgPos}: {_lastArg} ({_lastArg.Type}), expected: {_expectedType.FullName}", 2);
        });
        private static readonly global::Lua.LuaFunction _LuaMesh_GetVertexAttribute = new global::Lua.LuaFunction("GetVertexAttribute", (_context, _) =>
        {
            global::Lua.LuaValue _lastArg = default;
            global::System.Int32 _lastArgPos = default;
            global::System.Type _expectedType = default;
            var _argCount = _context.ArgumentCount;
            var _this = _context.GetArgument<LuaMesh>(0);
            var _arg0 = _lastArg = _argCount > 1 ? _context.GetArgument(1) : global::Lua.LuaValue.Nil;
            _lastArgPos = 0; _expectedType = typeof(global::System.Int32);
            if (_arg0.TryRead<global::System.Int32>(out var _p0_System_Int32))
            {
                if (_argCount == 2)
                {
                    var index = _p0_System_Int32;
                    var _ret0 = _this.Instance.GetVertexAttribute(index);
                    var _lret0 = global::Luny.UnityEngine.Rendering.LuaVertexAttributeDescriptor.Bind(_ret0);
                    var _retCount = _context.Return(_lret0);
                    return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                }
            }
            throw new global::Lua.LuaRuntimeException(_context.Thread, $"{"GetVertexAttribute"}: invalid argument #{_lastArgPos}: {_lastArg} ({_lastArg.Type}), expected: {_expectedType.FullName}", 2);
        });
        private static readonly global::Lua.LuaFunction _LuaMesh_GetVertexAttributeDimension = new global::Lua.LuaFunction("GetVertexAttributeDimension", (_context, _) =>
        {
            global::Lua.LuaValue _lastArg = default;
            global::System.Int32 _lastArgPos = default;
            global::System.Type _expectedType = default;
            var _argCount = _context.ArgumentCount;
            var _this = _context.GetArgument<LuaMesh>(0);
            var _arg0 = _lastArg = _argCount > 1 ? _context.GetArgument(1) : global::Lua.LuaValue.Nil;
            _lastArgPos = 0; _expectedType = typeof(global::UnityEngine.Rendering.VertexAttribute);
            if (_arg0.TryRead<global::UnityEngine.Rendering.VertexAttribute>(out var _p0_UnityEngine_Rendering_VertexAttribute))
            {
                if (_argCount == 2)
                {
                    var attr = _p0_UnityEngine_Rendering_VertexAttribute;
                    var _ret0 = _this.Instance.GetVertexAttributeDimension(attr);
                    var _lret0 = new global::Lua.LuaValue(_ret0);
                    var _retCount = _context.Return(_lret0);
                    return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                }
            }
            throw new global::Lua.LuaRuntimeException(_context.Thread, $"{"GetVertexAttributeDimension"}: invalid argument #{_lastArgPos}: {_lastArg} ({_lastArg.Type}), expected: {_expectedType.FullName}", 2);
        });
        private static readonly global::Lua.LuaFunction _LuaMesh_GetVertexAttributeFormat = new global::Lua.LuaFunction("GetVertexAttributeFormat", (_context, _) =>
        {
            global::Lua.LuaValue _lastArg = default;
            global::System.Int32 _lastArgPos = default;
            global::System.Type _expectedType = default;
            var _argCount = _context.ArgumentCount;
            var _this = _context.GetArgument<LuaMesh>(0);
            var _arg0 = _lastArg = _argCount > 1 ? _context.GetArgument(1) : global::Lua.LuaValue.Nil;
            _lastArgPos = 0; _expectedType = typeof(global::UnityEngine.Rendering.VertexAttribute);
            if (_arg0.TryRead<global::UnityEngine.Rendering.VertexAttribute>(out var _p0_UnityEngine_Rendering_VertexAttribute))
            {
                if (_argCount == 2)
                {
                    var attr = _p0_UnityEngine_Rendering_VertexAttribute;
                    var _ret0 = _this.Instance.GetVertexAttributeFormat(attr);
                    var _lret0 = new global::Lua.LuaValue((global::System.Int64)_ret0);
                    var _retCount = _context.Return(_lret0);
                    return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                }
            }
            throw new global::Lua.LuaRuntimeException(_context.Thread, $"{"GetVertexAttributeFormat"}: invalid argument #{_lastArgPos}: {_lastArg} ({_lastArg.Type}), expected: {_expectedType.FullName}", 2);
        });
        private static readonly global::Lua.LuaFunction _LuaMesh_GetVertexAttributeOffset = new global::Lua.LuaFunction("GetVertexAttributeOffset", (_context, _) =>
        {
            global::Lua.LuaValue _lastArg = default;
            global::System.Int32 _lastArgPos = default;
            global::System.Type _expectedType = default;
            var _argCount = _context.ArgumentCount;
            var _this = _context.GetArgument<LuaMesh>(0);
            var _arg0 = _lastArg = _argCount > 1 ? _context.GetArgument(1) : global::Lua.LuaValue.Nil;
            _lastArgPos = 0; _expectedType = typeof(global::UnityEngine.Rendering.VertexAttribute);
            if (_arg0.TryRead<global::UnityEngine.Rendering.VertexAttribute>(out var _p0_UnityEngine_Rendering_VertexAttribute))
            {
                if (_argCount == 2)
                {
                    var attr = _p0_UnityEngine_Rendering_VertexAttribute;
                    var _ret0 = _this.Instance.GetVertexAttributeOffset(attr);
                    var _lret0 = new global::Lua.LuaValue(_ret0);
                    var _retCount = _context.Return(_lret0);
                    return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                }
            }
            throw new global::Lua.LuaRuntimeException(_context.Thread, $"{"GetVertexAttributeOffset"}: invalid argument #{_lastArgPos}: {_lastArg} ({_lastArg.Type}), expected: {_expectedType.FullName}", 2);
        });
        private static readonly global::Lua.LuaFunction _LuaMesh_GetVertexAttributes = new global::Lua.LuaFunction("GetVertexAttributes", (_context, _) =>
        {
            global::Lua.LuaValue _lastArg = default;
            global::System.Int32 _lastArgPos = default;
            global::System.Type _expectedType = default;
            var _argCount = _context.ArgumentCount;
            var _this = _context.GetArgument<LuaMesh>(0);
            if (_argCount == 1)
            {
                var _ret0 = _this.Instance.GetVertexAttributes();
                var _factory = _context.GetObjectFactory();
                var _lret0 = _factory.Bind(_ret0);
                var _retCount = _context.Return(_lret0);
                return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
            }
            var _arg0 = _lastArg = _argCount > 1 ? _context.GetArgument(1) : global::Lua.LuaValue.Nil;
            _lastArgPos = 0; _expectedType = typeof(global::UnityEngine.Rendering.VertexAttributeDescriptor[]);
            if (_arg0.TryReadArray<global::UnityEngine.Rendering.VertexAttributeDescriptor>(out var _p0_UnityEngine_Rendering_VertexAttributeDescriptorArray))
            {
                if (_argCount == 2)
                {
                    var attributes = _p0_UnityEngine_Rendering_VertexAttributeDescriptorArray;
                    var _ret0 = _this.Instance.GetVertexAttributes(attributes);
                    var _lret0 = new global::Lua.LuaValue(_ret0);
                    var _retCount = _context.Return(_lret0);
                    return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                }
            }
            throw new global::Lua.LuaRuntimeException(_context.Thread, $"{"GetVertexAttributes"}: invalid argument #{_lastArgPos}: {_lastArg} ({_lastArg.Type}), expected: {_expectedType.FullName}", 2);
        });
        private static readonly global::Lua.LuaFunction _LuaMesh_GetVertexAttributeStream = new global::Lua.LuaFunction("GetVertexAttributeStream", (_context, _) =>
        {
            global::Lua.LuaValue _lastArg = default;
            global::System.Int32 _lastArgPos = default;
            global::System.Type _expectedType = default;
            var _argCount = _context.ArgumentCount;
            var _this = _context.GetArgument<LuaMesh>(0);
            var _arg0 = _lastArg = _argCount > 1 ? _context.GetArgument(1) : global::Lua.LuaValue.Nil;
            _lastArgPos = 0; _expectedType = typeof(global::UnityEngine.Rendering.VertexAttribute);
            if (_arg0.TryRead<global::UnityEngine.Rendering.VertexAttribute>(out var _p0_UnityEngine_Rendering_VertexAttribute))
            {
                if (_argCount == 2)
                {
                    var attr = _p0_UnityEngine_Rendering_VertexAttribute;
                    var _ret0 = _this.Instance.GetVertexAttributeStream(attr);
                    var _lret0 = new global::Lua.LuaValue(_ret0);
                    var _retCount = _context.Return(_lret0);
                    return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                }
            }
            throw new global::Lua.LuaRuntimeException(_context.Thread, $"{"GetVertexAttributeStream"}: invalid argument #{_lastArgPos}: {_lastArg} ({_lastArg.Type}), expected: {_expectedType.FullName}", 2);
        });
        private static readonly global::Lua.LuaFunction _LuaMesh_GetVertexBuffer = new global::Lua.LuaFunction("GetVertexBuffer", (_context, _) =>
        {
            global::Lua.LuaValue _lastArg = default;
            global::System.Int32 _lastArgPos = default;
            global::System.Type _expectedType = default;
            var _argCount = _context.ArgumentCount;
            var _this = _context.GetArgument<LuaMesh>(0);
            var _arg0 = _lastArg = _argCount > 1 ? _context.GetArgument(1) : global::Lua.LuaValue.Nil;
            _lastArgPos = 0; _expectedType = typeof(global::System.Int32);
            if (_arg0.TryRead<global::System.Int32>(out var _p0_System_Int32))
            {
                if (_argCount == 2)
                {
                    var index = _p0_System_Int32;
                    var _ret0 = _this.Instance.GetVertexBuffer(index);
                    var _factory = _context.GetObjectFactory();
                    var _lret0 = _factory.Bind(_ret0);
                    var _retCount = _context.Return(_lret0);
                    return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                }
            }
            throw new global::Lua.LuaRuntimeException(_context.Thread, $"{"GetVertexBuffer"}: invalid argument #{_lastArgPos}: {_lastArg} ({_lastArg.Type}), expected: {_expectedType.FullName}", 2);
        });
        private static readonly global::Lua.LuaFunction _LuaMesh_GetVertexBufferStride = new global::Lua.LuaFunction("GetVertexBufferStride", (_context, _) =>
        {
            global::Lua.LuaValue _lastArg = default;
            global::System.Int32 _lastArgPos = default;
            global::System.Type _expectedType = default;
            var _argCount = _context.ArgumentCount;
            var _this = _context.GetArgument<LuaMesh>(0);
            var _arg0 = _lastArg = _argCount > 1 ? _context.GetArgument(1) : global::Lua.LuaValue.Nil;
            _lastArgPos = 0; _expectedType = typeof(global::System.Int32);
            if (_arg0.TryRead<global::System.Int32>(out var _p0_System_Int32))
            {
                if (_argCount == 2)
                {
                    var stream = _p0_System_Int32;
                    var _ret0 = _this.Instance.GetVertexBufferStride(stream);
                    var _lret0 = new global::Lua.LuaValue(_ret0);
                    var _retCount = _context.Return(_lret0);
                    return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                }
            }
            throw new global::Lua.LuaRuntimeException(_context.Thread, $"{"GetVertexBufferStride"}: invalid argument #{_lastArgPos}: {_lastArg} ({_lastArg.Type}), expected: {_expectedType.FullName}", 2);
        });
        private static readonly global::Lua.LuaFunction _LuaMesh_HasVertexAttribute = new global::Lua.LuaFunction("HasVertexAttribute", (_context, _) =>
        {
            global::Lua.LuaValue _lastArg = default;
            global::System.Int32 _lastArgPos = default;
            global::System.Type _expectedType = default;
            var _argCount = _context.ArgumentCount;
            var _this = _context.GetArgument<LuaMesh>(0);
            var _arg0 = _lastArg = _argCount > 1 ? _context.GetArgument(1) : global::Lua.LuaValue.Nil;
            _lastArgPos = 0; _expectedType = typeof(global::UnityEngine.Rendering.VertexAttribute);
            if (_arg0.TryRead<global::UnityEngine.Rendering.VertexAttribute>(out var _p0_UnityEngine_Rendering_VertexAttribute))
            {
                if (_argCount == 2)
                {
                    var attr = _p0_UnityEngine_Rendering_VertexAttribute;
                    var _ret0 = _this.Instance.HasVertexAttribute(attr);
                    var _lret0 = new global::Lua.LuaValue(_ret0);
                    var _retCount = _context.Return(_lret0);
                    return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                }
            }
            throw new global::Lua.LuaRuntimeException(_context.Thread, $"{"HasVertexAttribute"}: invalid argument #{_lastArgPos}: {_lastArg} ({_lastArg.Type}), expected: {_expectedType.FullName}", 2);
        });
        private static readonly global::Lua.LuaFunction _LuaMesh_MarkDynamic = new global::Lua.LuaFunction("MarkDynamic", (_context, _) =>
        {
            global::Lua.LuaValue _lastArg = default;
            global::System.Int32 _lastArgPos = default;
            global::System.Type _expectedType = default;
            var _argCount = _context.ArgumentCount;
            var _this = _context.GetArgument<LuaMesh>(0);
            if (_argCount == 1)
            {
                _this.Instance.MarkDynamic();
                var _retCount = _context.Return();
                return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
            }
            throw new global::Lua.LuaRuntimeException(_context.Thread, $"{"MarkDynamic"}: invalid argument #{_lastArgPos}: {_lastArg} ({_lastArg.Type}), expected: {_expectedType.FullName}", 2);
        });
        private static readonly global::Lua.LuaFunction _LuaMesh_MarkModified = new global::Lua.LuaFunction("MarkModified", (_context, _) =>
        {
            global::Lua.LuaValue _lastArg = default;
            global::System.Int32 _lastArgPos = default;
            global::System.Type _expectedType = default;
            var _argCount = _context.ArgumentCount;
            var _this = _context.GetArgument<LuaMesh>(0);
            if (_argCount == 1)
            {
                _this.Instance.MarkModified();
                var _retCount = _context.Return();
                return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
            }
            throw new global::Lua.LuaRuntimeException(_context.Thread, $"{"MarkModified"}: invalid argument #{_lastArgPos}: {_lastArg} ({_lastArg.Type}), expected: {_expectedType.FullName}", 2);
        });
        private static readonly global::Lua.LuaFunction _LuaMesh_Optimize = new global::Lua.LuaFunction("Optimize", (_context, _) =>
        {
            global::Lua.LuaValue _lastArg = default;
            global::System.Int32 _lastArgPos = default;
            global::System.Type _expectedType = default;
            var _argCount = _context.ArgumentCount;
            var _this = _context.GetArgument<LuaMesh>(0);
            if (_argCount == 1)
            {
                _this.Instance.Optimize();
                var _retCount = _context.Return();
                return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
            }
            throw new global::Lua.LuaRuntimeException(_context.Thread, $"{"Optimize"}: invalid argument #{_lastArgPos}: {_lastArg} ({_lastArg.Type}), expected: {_expectedType.FullName}", 2);
        });
        private static readonly global::Lua.LuaFunction _LuaMesh_OptimizeIndexBuffers = new global::Lua.LuaFunction("OptimizeIndexBuffers", (_context, _) =>
        {
            global::Lua.LuaValue _lastArg = default;
            global::System.Int32 _lastArgPos = default;
            global::System.Type _expectedType = default;
            var _argCount = _context.ArgumentCount;
            var _this = _context.GetArgument<LuaMesh>(0);
            if (_argCount == 1)
            {
                _this.Instance.OptimizeIndexBuffers();
                var _retCount = _context.Return();
                return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
            }
            throw new global::Lua.LuaRuntimeException(_context.Thread, $"{"OptimizeIndexBuffers"}: invalid argument #{_lastArgPos}: {_lastArg} ({_lastArg.Type}), expected: {_expectedType.FullName}", 2);
        });
        private static readonly global::Lua.LuaFunction _LuaMesh_OptimizeReorderVertexBuffer = new global::Lua.LuaFunction("OptimizeReorderVertexBuffer", (_context, _) =>
        {
            global::Lua.LuaValue _lastArg = default;
            global::System.Int32 _lastArgPos = default;
            global::System.Type _expectedType = default;
            var _argCount = _context.ArgumentCount;
            var _this = _context.GetArgument<LuaMesh>(0);
            if (_argCount == 1)
            {
                _this.Instance.OptimizeReorderVertexBuffer();
                var _retCount = _context.Return();
                return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
            }
            throw new global::Lua.LuaRuntimeException(_context.Thread, $"{"OptimizeReorderVertexBuffer"}: invalid argument #{_lastArgPos}: {_lastArg} ({_lastArg.Type}), expected: {_expectedType.FullName}", 2);
        });
        private static readonly global::Lua.LuaFunction _LuaMesh_RecalculateBounds = new global::Lua.LuaFunction("RecalculateBounds", (_context, _) =>
        {
            global::Lua.LuaValue _lastArg = default;
            global::System.Int32 _lastArgPos = default;
            global::System.Type _expectedType = default;
            var _argCount = _context.ArgumentCount;
            var _this = _context.GetArgument<LuaMesh>(0);
            if (_argCount == 1)
            {
                _this.Instance.RecalculateBounds();
                var _retCount = _context.Return();
                return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
            }
            var _arg0 = _lastArg = _argCount > 1 ? _context.GetArgument(1) : global::Lua.LuaValue.Nil;
            _lastArgPos = 0; _expectedType = typeof(global::UnityEngine.Rendering.MeshUpdateFlags);
            if (_arg0.TryRead<global::UnityEngine.Rendering.MeshUpdateFlags>(out var _p0_UnityEngine_Rendering_MeshUpdateFlags))
            {
                if (_argCount == 2)
                {
                    var flags = _p0_UnityEngine_Rendering_MeshUpdateFlags;
                    _this.Instance.RecalculateBounds(flags);
                    var _retCount = _context.Return();
                    return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                }
            }
            throw new global::Lua.LuaRuntimeException(_context.Thread, $"{"RecalculateBounds"}: invalid argument #{_lastArgPos}: {_lastArg} ({_lastArg.Type}), expected: {_expectedType.FullName}", 2);
        });
        private static readonly global::Lua.LuaFunction _LuaMesh_RecalculateNormals = new global::Lua.LuaFunction("RecalculateNormals", (_context, _) =>
        {
            global::Lua.LuaValue _lastArg = default;
            global::System.Int32 _lastArgPos = default;
            global::System.Type _expectedType = default;
            var _argCount = _context.ArgumentCount;
            var _this = _context.GetArgument<LuaMesh>(0);
            if (_argCount == 1)
            {
                _this.Instance.RecalculateNormals();
                var _retCount = _context.Return();
                return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
            }
            var _arg0 = _lastArg = _argCount > 1 ? _context.GetArgument(1) : global::Lua.LuaValue.Nil;
            _lastArgPos = 0; _expectedType = typeof(global::UnityEngine.Rendering.MeshUpdateFlags);
            if (_arg0.TryRead<global::UnityEngine.Rendering.MeshUpdateFlags>(out var _p0_UnityEngine_Rendering_MeshUpdateFlags))
            {
                if (_argCount == 2)
                {
                    var flags = _p0_UnityEngine_Rendering_MeshUpdateFlags;
                    _this.Instance.RecalculateNormals(flags);
                    var _retCount = _context.Return();
                    return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                }
            }
            throw new global::Lua.LuaRuntimeException(_context.Thread, $"{"RecalculateNormals"}: invalid argument #{_lastArgPos}: {_lastArg} ({_lastArg.Type}), expected: {_expectedType.FullName}", 2);
        });
        private static readonly global::Lua.LuaFunction _LuaMesh_RecalculateTangents = new global::Lua.LuaFunction("RecalculateTangents", (_context, _) =>
        {
            global::Lua.LuaValue _lastArg = default;
            global::System.Int32 _lastArgPos = default;
            global::System.Type _expectedType = default;
            var _argCount = _context.ArgumentCount;
            var _this = _context.GetArgument<LuaMesh>(0);
            if (_argCount == 1)
            {
                _this.Instance.RecalculateTangents();
                var _retCount = _context.Return();
                return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
            }
            var _arg0 = _lastArg = _argCount > 1 ? _context.GetArgument(1) : global::Lua.LuaValue.Nil;
            _lastArgPos = 0; _expectedType = typeof(global::UnityEngine.Rendering.MeshUpdateFlags);
            if (_arg0.TryRead<global::UnityEngine.Rendering.MeshUpdateFlags>(out var _p0_UnityEngine_Rendering_MeshUpdateFlags))
            {
                if (_argCount == 2)
                {
                    var flags = _p0_UnityEngine_Rendering_MeshUpdateFlags;
                    _this.Instance.RecalculateTangents(flags);
                    var _retCount = _context.Return();
                    return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                }
            }
            throw new global::Lua.LuaRuntimeException(_context.Thread, $"{"RecalculateTangents"}: invalid argument #{_lastArgPos}: {_lastArg} ({_lastArg.Type}), expected: {_expectedType.FullName}", 2);
        });
        private static readonly global::Lua.LuaFunction _LuaMesh_RecalculateUVDistributionMetric = new global::Lua.LuaFunction("RecalculateUVDistributionMetric", (_context, _) =>
        {
            global::Lua.LuaValue _lastArg = default;
            global::System.Int32 _lastArgPos = default;
            global::System.Type _expectedType = default;
            var _argCount = _context.ArgumentCount;
            var _this = _context.GetArgument<LuaMesh>(0);
            var _arg0 = _lastArg = _argCount > 1 ? _context.GetArgument(1) : global::Lua.LuaValue.Nil;
            _lastArgPos = 0; _expectedType = typeof(global::System.Int32);
            if (_arg0.TryRead<global::System.Int32>(out var _p0_System_Int32))
            {
                if (_argCount == 2)
                {
                    var uvSetIndex = _p0_System_Int32;
                    _this.Instance.RecalculateUVDistributionMetric(uvSetIndex);
                    var _retCount = _context.Return();
                    return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                }
                var _arg1 = _lastArg = _argCount > 2 ? _context.GetArgument(2) : global::Lua.LuaValue.Nil;
                _lastArgPos = 1; _expectedType = typeof(global::System.Single);
                var _p1_System_Single = _arg1.ReadValue<global::System.Single>((global::System.Single)(1E-09));
                {
                    if (_argCount == 3)
                    {
                        var uvSetIndex = _p0_System_Int32;
                        var uvAreaThreshold = _p1_System_Single;
                        _this.Instance.RecalculateUVDistributionMetric(uvSetIndex, uvAreaThreshold);
                        var _retCount = _context.Return();
                        return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                    }
                }
            }
            throw new global::Lua.LuaRuntimeException(_context.Thread, $"{"RecalculateUVDistributionMetric"}: invalid argument #{_lastArgPos}: {_lastArg} ({_lastArg.Type}), expected: {_expectedType.FullName}", 2);
        });
        private static readonly global::Lua.LuaFunction _LuaMesh_RecalculateUVDistributionMetrics = new global::Lua.LuaFunction("RecalculateUVDistributionMetrics", (_context, _) =>
        {
            global::Lua.LuaValue _lastArg = default;
            global::System.Int32 _lastArgPos = default;
            global::System.Type _expectedType = default;
            var _argCount = _context.ArgumentCount;
            var _this = _context.GetArgument<LuaMesh>(0);
            if (_argCount == 1)
            {
                _this.Instance.RecalculateUVDistributionMetrics();
                var _retCount = _context.Return();
                return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
            }
            var _arg0 = _lastArg = _argCount > 1 ? _context.GetArgument(1) : global::Lua.LuaValue.Nil;
            _lastArgPos = 0; _expectedType = typeof(global::System.Single);
            var _p0_System_Single = _arg0.ReadValue<global::System.Single>((global::System.Single)(1E-09));
            {
                if (_argCount == 2)
                {
                    var uvAreaThreshold = _p0_System_Single;
                    _this.Instance.RecalculateUVDistributionMetrics(uvAreaThreshold);
                    var _retCount = _context.Return();
                    return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                }
            }
            throw new global::Lua.LuaRuntimeException(_context.Thread, $"{"RecalculateUVDistributionMetrics"}: invalid argument #{_lastArgPos}: {_lastArg} ({_lastArg.Type}), expected: {_expectedType.FullName}", 2);
        });
        private static readonly global::Lua.LuaFunction _LuaMesh_SetColors = new global::Lua.LuaFunction("SetColors", (_context, _) =>
        {
            global::Lua.LuaValue _lastArg = default;
            global::System.Int32 _lastArgPos = default;
            global::System.Type _expectedType = default;
            var _argCount = _context.ArgumentCount;
            var _this = _context.GetArgument<LuaMesh>(0);
            var _arg0 = _lastArg = _argCount > 1 ? _context.GetArgument(1) : global::Lua.LuaValue.Nil;
            _lastArgPos = 0; _expectedType = typeof(global::UnityEngine.Color[]);
            if (_arg0.TryReadArray<global::UnityEngine.Color>(out var _p0_UnityEngine_ColorArray))
            {
                if (_argCount == 2)
                {
                    var inColors = _p0_UnityEngine_ColorArray;
                    _this.Instance.SetColors(inColors);
                    var _retCount = _context.Return();
                    return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                }
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
                            var inColors = _p0_UnityEngine_ColorArray;
                            var start = _p1_System_Int32;
                            var length = _p2_System_Int32;
                            _this.Instance.SetColors(inColors, start, length);
                            var _retCount = _context.Return();
                            return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                        }
                        var _arg3 = _lastArg = _argCount > 4 ? _context.GetArgument(4) : global::Lua.LuaValue.Nil;
                        _lastArgPos = 3; _expectedType = typeof(global::UnityEngine.Rendering.MeshUpdateFlags);
                        if (_arg3.TryRead<global::UnityEngine.Rendering.MeshUpdateFlags>(out var _p3_UnityEngine_Rendering_MeshUpdateFlags))
                        {
                            if (_argCount == 5)
                            {
                                var inColors = _p0_UnityEngine_ColorArray;
                                var start = _p1_System_Int32;
                                var length = _p2_System_Int32;
                                var flags = _p3_UnityEngine_Rendering_MeshUpdateFlags;
                                _this.Instance.SetColors(inColors, start, length, flags);
                                var _retCount = _context.Return();
                                return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                            }
                        }
                    }
                }
            }
            _lastArgPos = 0; _expectedType = typeof(global::UnityEngine.Color32[]);
            if (_arg0.TryReadArray<global::UnityEngine.Color32>(out var _p0_UnityEngine_Color32Array))
            {
                if (_argCount == 2)
                {
                    var inColors = _p0_UnityEngine_Color32Array;
                    _this.Instance.SetColors(inColors);
                    var _retCount = _context.Return();
                    return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                }
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
                            var inColors = _p0_UnityEngine_Color32Array;
                            var start = _p1_System_Int32;
                            var length = _p2_System_Int32;
                            _this.Instance.SetColors(inColors, start, length);
                            var _retCount = _context.Return();
                            return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                        }
                        var _arg3 = _lastArg = _argCount > 4 ? _context.GetArgument(4) : global::Lua.LuaValue.Nil;
                        _lastArgPos = 3; _expectedType = typeof(global::UnityEngine.Rendering.MeshUpdateFlags);
                        if (_arg3.TryRead<global::UnityEngine.Rendering.MeshUpdateFlags>(out var _p3_UnityEngine_Rendering_MeshUpdateFlags))
                        {
                            if (_argCount == 5)
                            {
                                var inColors = _p0_UnityEngine_Color32Array;
                                var start = _p1_System_Int32;
                                var length = _p2_System_Int32;
                                var flags = _p3_UnityEngine_Rendering_MeshUpdateFlags;
                                _this.Instance.SetColors(inColors, start, length, flags);
                                var _retCount = _context.Return();
                                return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                            }
                        }
                    }
                }
            }
            throw new global::Lua.LuaRuntimeException(_context.Thread, $"{"SetColors"}: invalid argument #{_lastArgPos}: {_lastArg} ({_lastArg.Type}), expected: {_expectedType.FullName}", 2);
        });
        private static readonly global::Lua.LuaFunction _LuaMesh_SetIndexBufferParams = new global::Lua.LuaFunction("SetIndexBufferParams", (_context, _) =>
        {
            global::Lua.LuaValue _lastArg = default;
            global::System.Int32 _lastArgPos = default;
            global::System.Type _expectedType = default;
            var _argCount = _context.ArgumentCount;
            var _this = _context.GetArgument<LuaMesh>(0);
            var _arg0 = _lastArg = _argCount > 1 ? _context.GetArgument(1) : global::Lua.LuaValue.Nil;
            _lastArgPos = 0; _expectedType = typeof(global::System.Int32);
            if (_arg0.TryRead<global::System.Int32>(out var _p0_System_Int32))
            {
                var _arg1 = _lastArg = _argCount > 2 ? _context.GetArgument(2) : global::Lua.LuaValue.Nil;
                _lastArgPos = 1; _expectedType = typeof(global::UnityEngine.Rendering.IndexFormat);
                if (_arg1.TryRead<global::UnityEngine.Rendering.IndexFormat>(out var _p1_UnityEngine_Rendering_IndexFormat))
                {
                    if (_argCount == 3)
                    {
                        var indexCount = _p0_System_Int32;
                        var format = _p1_UnityEngine_Rendering_IndexFormat;
                        _this.Instance.SetIndexBufferParams(indexCount, format);
                        var _retCount = _context.Return();
                        return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                    }
                }
            }
            throw new global::Lua.LuaRuntimeException(_context.Thread, $"{"SetIndexBufferParams"}: invalid argument #{_lastArgPos}: {_lastArg} ({_lastArg.Type}), expected: {_expectedType.FullName}", 2);
        });
        private static readonly global::Lua.LuaFunction _LuaMesh_SetIndices = new global::Lua.LuaFunction("SetIndices", (_context, _) =>
        {
            global::Lua.LuaValue _lastArg = default;
            global::System.Int32 _lastArgPos = default;
            global::System.Type _expectedType = default;
            var _argCount = _context.ArgumentCount;
            var _this = _context.GetArgument<LuaMesh>(0);
            var _arg0 = _lastArg = _argCount > 1 ? _context.GetArgument(1) : global::Lua.LuaValue.Nil;
            _lastArgPos = 0; _expectedType = typeof(global::System.Int32[]);
            if (_arg0.TryReadArray<global::System.Int32>(out var _p0_System_Int32Array))
            {
                var _arg1 = _lastArg = _argCount > 2 ? _context.GetArgument(2) : global::Lua.LuaValue.Nil;
                _lastArgPos = 1; _expectedType = typeof(global::UnityEngine.MeshTopology);
                if (_arg1.TryRead<global::UnityEngine.MeshTopology>(out var _p1_UnityEngine_MeshTopology))
                {
                    var _arg2 = _lastArg = _argCount > 3 ? _context.GetArgument(3) : global::Lua.LuaValue.Nil;
                    _lastArgPos = 2; _expectedType = typeof(global::System.Int32);
                    if (_arg2.TryRead<global::System.Int32>(out var _p2_System_Int32))
                    {
                        if (_argCount == 4)
                        {
                            var indices = _p0_System_Int32Array;
                            var topology = _p1_UnityEngine_MeshTopology;
                            var submesh = _p2_System_Int32;
                            _this.Instance.SetIndices(indices, topology, submesh);
                            var _retCount = _context.Return();
                            return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                        }
                        var _arg3 = _lastArg = _argCount > 4 ? _context.GetArgument(4) : global::Lua.LuaValue.Nil;
                        _lastArgPos = 3; _expectedType = typeof(global::System.Boolean);
                        if (_arg3.TryRead<global::System.Boolean>(out var _p3_System_Boolean))
                        {
                            if (_argCount == 5)
                            {
                                var indices = _p0_System_Int32Array;
                                var topology = _p1_UnityEngine_MeshTopology;
                                var submesh = _p2_System_Int32;
                                var calculateBounds = _p3_System_Boolean;
                                _this.Instance.SetIndices(indices, topology, submesh, calculateBounds);
                                var _retCount = _context.Return();
                                return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                            }
                            var _arg4 = _lastArg = _argCount > 5 ? _context.GetArgument(5) : global::Lua.LuaValue.Nil;
                            _lastArgPos = 4; _expectedType = typeof(global::System.Int32);
                            if (_arg4.TryRead<global::System.Int32>(out var _p4_System_Int32))
                            {
                                if (_argCount == 6)
                                {
                                    var indices = _p0_System_Int32Array;
                                    var topology = _p1_UnityEngine_MeshTopology;
                                    var submesh = _p2_System_Int32;
                                    var calculateBounds = _p3_System_Boolean;
                                    var baseVertex = _p4_System_Int32;
                                    _this.Instance.SetIndices(indices, topology, submesh, calculateBounds, baseVertex);
                                    var _retCount = _context.Return();
                                    return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                                }
                            }
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
                                    var indices = _p0_System_Int32Array;
                                    var indicesStart = _p1_System_Int32;
                                    var indicesLength = _p2_System_Int32;
                                    var topology = _p3_UnityEngine_MeshTopology;
                                    var submesh = _p4_System_Int32;
                                    _this.Instance.SetIndices(indices, indicesStart, indicesLength, topology, submesh);
                                    var _retCount = _context.Return();
                                    return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                                }
                                var _arg5 = _lastArg = _argCount > 6 ? _context.GetArgument(6) : global::Lua.LuaValue.Nil;
                                _lastArgPos = 5; _expectedType = typeof(global::System.Boolean);
                                var _p5_System_Boolean = _arg5.ReadValue<global::System.Boolean>((global::System.Boolean)true);
                                {
                                    if (_argCount == 7)
                                    {
                                        var indices = _p0_System_Int32Array;
                                        var indicesStart = _p1_System_Int32;
                                        var indicesLength = _p2_System_Int32;
                                        var topology = _p3_UnityEngine_MeshTopology;
                                        var submesh = _p4_System_Int32;
                                        var calculateBounds = _p5_System_Boolean;
                                        _this.Instance.SetIndices(indices, indicesStart, indicesLength, topology, submesh, calculateBounds);
                                        var _retCount = _context.Return();
                                        return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                                    }
                                    var _arg6 = _lastArg = _argCount > 7 ? _context.GetArgument(7) : global::Lua.LuaValue.Nil;
                                    _lastArgPos = 6; _expectedType = typeof(global::System.Int32);
                                    var _p6_System_Int32 = _arg6.ReadValue<global::System.Int32>((global::System.Int32)(0));
                                    {
                                        if (_argCount == 8)
                                        {
                                            var indices = _p0_System_Int32Array;
                                            var indicesStart = _p1_System_Int32;
                                            var indicesLength = _p2_System_Int32;
                                            var topology = _p3_UnityEngine_MeshTopology;
                                            var submesh = _p4_System_Int32;
                                            var calculateBounds = _p5_System_Boolean;
                                            var baseVertex = _p6_System_Int32;
                                            _this.Instance.SetIndices(indices, indicesStart, indicesLength, topology, submesh, calculateBounds, baseVertex);
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
            _lastArgPos = 0; _expectedType = typeof(global::System.UInt16[]);
            if (_arg0.TryReadArray<global::System.UInt16>(out var _p0_System_UInt16Array))
            {
                var _arg1 = _lastArg = _argCount > 2 ? _context.GetArgument(2) : global::Lua.LuaValue.Nil;
                _lastArgPos = 1; _expectedType = typeof(global::UnityEngine.MeshTopology);
                if (_arg1.TryRead<global::UnityEngine.MeshTopology>(out var _p1_UnityEngine_MeshTopology))
                {
                    var _arg2 = _lastArg = _argCount > 3 ? _context.GetArgument(3) : global::Lua.LuaValue.Nil;
                    _lastArgPos = 2; _expectedType = typeof(global::System.Int32);
                    if (_arg2.TryRead<global::System.Int32>(out var _p2_System_Int32))
                    {
                        if (_argCount == 4)
                        {
                            var indices = _p0_System_UInt16Array;
                            var topology = _p1_UnityEngine_MeshTopology;
                            var submesh = _p2_System_Int32;
                            _this.Instance.SetIndices(indices, topology, submesh);
                            var _retCount = _context.Return();
                            return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                        }
                        var _arg3 = _lastArg = _argCount > 4 ? _context.GetArgument(4) : global::Lua.LuaValue.Nil;
                        _lastArgPos = 3; _expectedType = typeof(global::System.Boolean);
                        var _p3_System_Boolean = _arg3.ReadValue<global::System.Boolean>((global::System.Boolean)true);
                        {
                            if (_argCount == 5)
                            {
                                var indices = _p0_System_UInt16Array;
                                var topology = _p1_UnityEngine_MeshTopology;
                                var submesh = _p2_System_Int32;
                                var calculateBounds = _p3_System_Boolean;
                                _this.Instance.SetIndices(indices, topology, submesh, calculateBounds);
                                var _retCount = _context.Return();
                                return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                            }
                            var _arg4 = _lastArg = _argCount > 5 ? _context.GetArgument(5) : global::Lua.LuaValue.Nil;
                            _lastArgPos = 4; _expectedType = typeof(global::System.Int32);
                            var _p4_System_Int32 = _arg4.ReadValue<global::System.Int32>((global::System.Int32)(0));
                            {
                                if (_argCount == 6)
                                {
                                    var indices = _p0_System_UInt16Array;
                                    var topology = _p1_UnityEngine_MeshTopology;
                                    var submesh = _p2_System_Int32;
                                    var calculateBounds = _p3_System_Boolean;
                                    var baseVertex = _p4_System_Int32;
                                    _this.Instance.SetIndices(indices, topology, submesh, calculateBounds, baseVertex);
                                    var _retCount = _context.Return();
                                    return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                                }
                            }
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
                                    var indices = _p0_System_UInt16Array;
                                    var indicesStart = _p1_System_Int32;
                                    var indicesLength = _p2_System_Int32;
                                    var topology = _p3_UnityEngine_MeshTopology;
                                    var submesh = _p4_System_Int32;
                                    _this.Instance.SetIndices(indices, indicesStart, indicesLength, topology, submesh);
                                    var _retCount = _context.Return();
                                    return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                                }
                                var _arg5 = _lastArg = _argCount > 6 ? _context.GetArgument(6) : global::Lua.LuaValue.Nil;
                                _lastArgPos = 5; _expectedType = typeof(global::System.Boolean);
                                var _p5_System_Boolean = _arg5.ReadValue<global::System.Boolean>((global::System.Boolean)true);
                                {
                                    if (_argCount == 7)
                                    {
                                        var indices = _p0_System_UInt16Array;
                                        var indicesStart = _p1_System_Int32;
                                        var indicesLength = _p2_System_Int32;
                                        var topology = _p3_UnityEngine_MeshTopology;
                                        var submesh = _p4_System_Int32;
                                        var calculateBounds = _p5_System_Boolean;
                                        _this.Instance.SetIndices(indices, indicesStart, indicesLength, topology, submesh, calculateBounds);
                                        var _retCount = _context.Return();
                                        return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                                    }
                                    var _arg6 = _lastArg = _argCount > 7 ? _context.GetArgument(7) : global::Lua.LuaValue.Nil;
                                    _lastArgPos = 6; _expectedType = typeof(global::System.Int32);
                                    var _p6_System_Int32 = _arg6.ReadValue<global::System.Int32>((global::System.Int32)(0));
                                    {
                                        if (_argCount == 8)
                                        {
                                            var indices = _p0_System_UInt16Array;
                                            var indicesStart = _p1_System_Int32;
                                            var indicesLength = _p2_System_Int32;
                                            var topology = _p3_UnityEngine_MeshTopology;
                                            var submesh = _p4_System_Int32;
                                            var calculateBounds = _p5_System_Boolean;
                                            var baseVertex = _p6_System_Int32;
                                            _this.Instance.SetIndices(indices, indicesStart, indicesLength, topology, submesh, calculateBounds, baseVertex);
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
            throw new global::Lua.LuaRuntimeException(_context.Thread, $"{"SetIndices"}: invalid argument #{_lastArgPos}: {_lastArg} ({_lastArg.Type}), expected: {_expectedType.FullName}", 2);
        });
        private static readonly global::Lua.LuaFunction _LuaMesh_SetNormals = new global::Lua.LuaFunction("SetNormals", (_context, _) =>
        {
            global::Lua.LuaValue _lastArg = default;
            global::System.Int32 _lastArgPos = default;
            global::System.Type _expectedType = default;
            var _argCount = _context.ArgumentCount;
            var _this = _context.GetArgument<LuaMesh>(0);
            var _arg0 = _lastArg = _argCount > 1 ? _context.GetArgument(1) : global::Lua.LuaValue.Nil;
            _lastArgPos = 0; _expectedType = typeof(global::UnityEngine.Vector3[]);
            if (_arg0.TryReadArray<global::UnityEngine.Vector3>(out var _p0_UnityEngine_Vector3Array))
            {
                if (_argCount == 2)
                {
                    var inNormals = _p0_UnityEngine_Vector3Array;
                    _this.Instance.SetNormals(inNormals);
                    var _retCount = _context.Return();
                    return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                }
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
                            var inNormals = _p0_UnityEngine_Vector3Array;
                            var start = _p1_System_Int32;
                            var length = _p2_System_Int32;
                            _this.Instance.SetNormals(inNormals, start, length);
                            var _retCount = _context.Return();
                            return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                        }
                        var _arg3 = _lastArg = _argCount > 4 ? _context.GetArgument(4) : global::Lua.LuaValue.Nil;
                        _lastArgPos = 3; _expectedType = typeof(global::UnityEngine.Rendering.MeshUpdateFlags);
                        if (_arg3.TryRead<global::UnityEngine.Rendering.MeshUpdateFlags>(out var _p3_UnityEngine_Rendering_MeshUpdateFlags))
                        {
                            if (_argCount == 5)
                            {
                                var inNormals = _p0_UnityEngine_Vector3Array;
                                var start = _p1_System_Int32;
                                var length = _p2_System_Int32;
                                var flags = _p3_UnityEngine_Rendering_MeshUpdateFlags;
                                _this.Instance.SetNormals(inNormals, start, length, flags);
                                var _retCount = _context.Return();
                                return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                            }
                        }
                    }
                }
            }
            throw new global::Lua.LuaRuntimeException(_context.Thread, $"{"SetNormals"}: invalid argument #{_lastArgPos}: {_lastArg} ({_lastArg.Type}), expected: {_expectedType.FullName}", 2);
        });
        private static readonly global::Lua.LuaFunction _LuaMesh_SetSubMesh = new global::Lua.LuaFunction("SetSubMesh", (_context, _) =>
        {
            global::Lua.LuaValue _lastArg = default;
            global::System.Int32 _lastArgPos = default;
            global::System.Type _expectedType = default;
            var _argCount = _context.ArgumentCount;
            var _this = _context.GetArgument<LuaMesh>(0);
            var _arg0 = _lastArg = _argCount > 1 ? _context.GetArgument(1) : global::Lua.LuaValue.Nil;
            _lastArgPos = 0; _expectedType = typeof(global::System.Int32);
            if (_arg0.TryRead<global::System.Int32>(out var _p0_System_Int32))
            {
                var _arg1 = _lastArg = _argCount > 2 ? _context.GetArgument(2) : global::Lua.LuaValue.Nil;
                _lastArgPos = 1; _expectedType = typeof(global::Luny.UnityEngine.Rendering.LuaSubMeshDescriptor);
                if (_arg1.TryRead<global::Luny.UnityEngine.Rendering.LuaSubMeshDescriptor>(out var _p1_UnityEngine_Rendering_SubMeshDescriptor))
                {
                    if (_argCount == 3)
                    {
                        var index = _p0_System_Int32;
                        var desc = _p1_UnityEngine_Rendering_SubMeshDescriptor.Value;
                        _this.Instance.SetSubMesh(index, desc);
                        var _retCount = _context.Return();
                        return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                    }
                    var _arg2 = _lastArg = _argCount > 3 ? _context.GetArgument(3) : global::Lua.LuaValue.Nil;
                    _lastArgPos = 2; _expectedType = typeof(global::UnityEngine.Rendering.MeshUpdateFlags);
                    var _p2_UnityEngine_Rendering_MeshUpdateFlags = _arg2.ReadValue<global::UnityEngine.Rendering.MeshUpdateFlags>(global::UnityEngine.Rendering.MeshUpdateFlags.@Default);
                    {
                        if (_argCount == 4)
                        {
                            var index = _p0_System_Int32;
                            var desc = _p1_UnityEngine_Rendering_SubMeshDescriptor.Value;
                            var flags = _p2_UnityEngine_Rendering_MeshUpdateFlags;
                            _this.Instance.SetSubMesh(index, desc, flags);
                            var _retCount = _context.Return();
                            return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                        }
                    }
                }
            }
            throw new global::Lua.LuaRuntimeException(_context.Thread, $"{"SetSubMesh"}: invalid argument #{_lastArgPos}: {_lastArg} ({_lastArg.Type}), expected: {_expectedType.FullName}", 2);
        });
        private static readonly global::Lua.LuaFunction _LuaMesh_SetSubMeshes = new global::Lua.LuaFunction("SetSubMeshes", (_context, _) =>
        {
            global::Lua.LuaValue _lastArg = default;
            global::System.Int32 _lastArgPos = default;
            global::System.Type _expectedType = default;
            var _argCount = _context.ArgumentCount;
            var _this = _context.GetArgument<LuaMesh>(0);
            var _arg0 = _lastArg = _argCount > 1 ? _context.GetArgument(1) : global::Lua.LuaValue.Nil;
            _lastArgPos = 0; _expectedType = typeof(global::UnityEngine.Rendering.SubMeshDescriptor[]);
            if (_arg0.TryReadArray<global::UnityEngine.Rendering.SubMeshDescriptor>(out var _p0_UnityEngine_Rendering_SubMeshDescriptorArray))
            {
                if (_argCount == 2)
                {
                    var desc = _p0_UnityEngine_Rendering_SubMeshDescriptorArray;
                    _this.Instance.SetSubMeshes(desc);
                    var _retCount = _context.Return();
                    return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                }
                var _arg1 = _lastArg = _argCount > 2 ? _context.GetArgument(2) : global::Lua.LuaValue.Nil;
                _lastArgPos = 1; _expectedType = typeof(global::UnityEngine.Rendering.MeshUpdateFlags);
                var _p1_UnityEngine_Rendering_MeshUpdateFlags = _arg1.ReadValue<global::UnityEngine.Rendering.MeshUpdateFlags>(global::UnityEngine.Rendering.MeshUpdateFlags.@Default);
                {
                    if (_argCount == 3)
                    {
                        var desc = _p0_UnityEngine_Rendering_SubMeshDescriptorArray;
                        var flags = _p1_UnityEngine_Rendering_MeshUpdateFlags;
                        _this.Instance.SetSubMeshes(desc, flags);
                        var _retCount = _context.Return();
                        return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
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
                            var desc = _p0_UnityEngine_Rendering_SubMeshDescriptorArray;
                            var start = _p1_System_Int32;
                            var count = _p2_System_Int32;
                            _this.Instance.SetSubMeshes(desc, start, count);
                            var _retCount = _context.Return();
                            return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                        }
                        var _arg3 = _lastArg = _argCount > 4 ? _context.GetArgument(4) : global::Lua.LuaValue.Nil;
                        _lastArgPos = 3; _expectedType = typeof(global::UnityEngine.Rendering.MeshUpdateFlags);
                        var _p3_UnityEngine_Rendering_MeshUpdateFlags = _arg3.ReadValue<global::UnityEngine.Rendering.MeshUpdateFlags>(global::UnityEngine.Rendering.MeshUpdateFlags.@Default);
                        {
                            if (_argCount == 5)
                            {
                                var desc = _p0_UnityEngine_Rendering_SubMeshDescriptorArray;
                                var start = _p1_System_Int32;
                                var count = _p2_System_Int32;
                                var flags = _p3_UnityEngine_Rendering_MeshUpdateFlags;
                                _this.Instance.SetSubMeshes(desc, start, count, flags);
                                var _retCount = _context.Return();
                                return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                            }
                        }
                    }
                }
            }
            throw new global::Lua.LuaRuntimeException(_context.Thread, $"{"SetSubMeshes"}: invalid argument #{_lastArgPos}: {_lastArg} ({_lastArg.Type}), expected: {_expectedType.FullName}", 2);
        });
        private static readonly global::Lua.LuaFunction _LuaMesh_SetTangents = new global::Lua.LuaFunction("SetTangents", (_context, _) =>
        {
            global::Lua.LuaValue _lastArg = default;
            global::System.Int32 _lastArgPos = default;
            global::System.Type _expectedType = default;
            var _argCount = _context.ArgumentCount;
            var _this = _context.GetArgument<LuaMesh>(0);
            var _arg0 = _lastArg = _argCount > 1 ? _context.GetArgument(1) : global::Lua.LuaValue.Nil;
            _lastArgPos = 0; _expectedType = typeof(global::UnityEngine.Vector4[]);
            if (_arg0.TryReadArray<global::UnityEngine.Vector4>(out var _p0_UnityEngine_Vector4Array))
            {
                if (_argCount == 2)
                {
                    var inTangents = _p0_UnityEngine_Vector4Array;
                    _this.Instance.SetTangents(inTangents);
                    var _retCount = _context.Return();
                    return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                }
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
                            var inTangents = _p0_UnityEngine_Vector4Array;
                            var start = _p1_System_Int32;
                            var length = _p2_System_Int32;
                            _this.Instance.SetTangents(inTangents, start, length);
                            var _retCount = _context.Return();
                            return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                        }
                        var _arg3 = _lastArg = _argCount > 4 ? _context.GetArgument(4) : global::Lua.LuaValue.Nil;
                        _lastArgPos = 3; _expectedType = typeof(global::UnityEngine.Rendering.MeshUpdateFlags);
                        if (_arg3.TryRead<global::UnityEngine.Rendering.MeshUpdateFlags>(out var _p3_UnityEngine_Rendering_MeshUpdateFlags))
                        {
                            if (_argCount == 5)
                            {
                                var inTangents = _p0_UnityEngine_Vector4Array;
                                var start = _p1_System_Int32;
                                var length = _p2_System_Int32;
                                var flags = _p3_UnityEngine_Rendering_MeshUpdateFlags;
                                _this.Instance.SetTangents(inTangents, start, length, flags);
                                var _retCount = _context.Return();
                                return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                            }
                        }
                    }
                }
            }
            throw new global::Lua.LuaRuntimeException(_context.Thread, $"{"SetTangents"}: invalid argument #{_lastArgPos}: {_lastArg} ({_lastArg.Type}), expected: {_expectedType.FullName}", 2);
        });
        private static readonly global::Lua.LuaFunction _LuaMesh_SetTriangles = new global::Lua.LuaFunction("SetTriangles", (_context, _) =>
        {
            global::Lua.LuaValue _lastArg = default;
            global::System.Int32 _lastArgPos = default;
            global::System.Type _expectedType = default;
            var _argCount = _context.ArgumentCount;
            var _this = _context.GetArgument<LuaMesh>(0);
            var _arg0 = _lastArg = _argCount > 1 ? _context.GetArgument(1) : global::Lua.LuaValue.Nil;
            _lastArgPos = 0; _expectedType = typeof(global::System.Int32[]);
            if (_arg0.TryReadArray<global::System.Int32>(out var _p0_System_Int32Array))
            {
                var _arg1 = _lastArg = _argCount > 2 ? _context.GetArgument(2) : global::Lua.LuaValue.Nil;
                _lastArgPos = 1; _expectedType = typeof(global::System.Int32);
                if (_arg1.TryRead<global::System.Int32>(out var _p1_System_Int32))
                {
                    if (_argCount == 3)
                    {
                        var triangles = _p0_System_Int32Array;
                        var submesh = _p1_System_Int32;
                        _this.Instance.SetTriangles(triangles, submesh);
                        var _retCount = _context.Return();
                        return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                    }
                    var _arg2 = _lastArg = _argCount > 3 ? _context.GetArgument(3) : global::Lua.LuaValue.Nil;
                    _lastArgPos = 2; _expectedType = typeof(global::System.Boolean);
                    if (_arg2.TryRead<global::System.Boolean>(out var _p2_System_Boolean))
                    {
                        if (_argCount == 4)
                        {
                            var triangles = _p0_System_Int32Array;
                            var submesh = _p1_System_Int32;
                            var calculateBounds = _p2_System_Boolean;
                            _this.Instance.SetTriangles(triangles, submesh, calculateBounds);
                            var _retCount = _context.Return();
                            return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                        }
                        var _arg3 = _lastArg = _argCount > 4 ? _context.GetArgument(4) : global::Lua.LuaValue.Nil;
                        _lastArgPos = 3; _expectedType = typeof(global::System.Int32);
                        if (_arg3.TryRead<global::System.Int32>(out var _p3_System_Int32))
                        {
                            if (_argCount == 5)
                            {
                                var triangles = _p0_System_Int32Array;
                                var submesh = _p1_System_Int32;
                                var calculateBounds = _p2_System_Boolean;
                                var baseVertex = _p3_System_Int32;
                                _this.Instance.SetTriangles(triangles, submesh, calculateBounds, baseVertex);
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
                            if (_argCount == 5)
                            {
                                var triangles = _p0_System_Int32Array;
                                var trianglesStart = _p1_System_Int32;
                                var trianglesLength = _p2_System_Int32;
                                var submesh = _p3_System_Int32;
                                _this.Instance.SetTriangles(triangles, trianglesStart, trianglesLength, submesh);
                                var _retCount = _context.Return();
                                return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                            }
                            var _arg4 = _lastArg = _argCount > 5 ? _context.GetArgument(5) : global::Lua.LuaValue.Nil;
                            _lastArgPos = 4; _expectedType = typeof(global::System.Boolean);
                            var _p4_System_Boolean = _arg4.ReadValue<global::System.Boolean>((global::System.Boolean)true);
                            {
                                if (_argCount == 6)
                                {
                                    var triangles = _p0_System_Int32Array;
                                    var trianglesStart = _p1_System_Int32;
                                    var trianglesLength = _p2_System_Int32;
                                    var submesh = _p3_System_Int32;
                                    var calculateBounds = _p4_System_Boolean;
                                    _this.Instance.SetTriangles(triangles, trianglesStart, trianglesLength, submesh, calculateBounds);
                                    var _retCount = _context.Return();
                                    return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                                }
                                var _arg5 = _lastArg = _argCount > 6 ? _context.GetArgument(6) : global::Lua.LuaValue.Nil;
                                _lastArgPos = 5; _expectedType = typeof(global::System.Int32);
                                var _p5_System_Int32 = _arg5.ReadValue<global::System.Int32>((global::System.Int32)(0));
                                {
                                    if (_argCount == 7)
                                    {
                                        var triangles = _p0_System_Int32Array;
                                        var trianglesStart = _p1_System_Int32;
                                        var trianglesLength = _p2_System_Int32;
                                        var submesh = _p3_System_Int32;
                                        var calculateBounds = _p4_System_Boolean;
                                        var baseVertex = _p5_System_Int32;
                                        _this.Instance.SetTriangles(triangles, trianglesStart, trianglesLength, submesh, calculateBounds, baseVertex);
                                        var _retCount = _context.Return();
                                        return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                                    }
                                }
                            }
                        }
                    }
                }
            }
            _lastArgPos = 0; _expectedType = typeof(global::System.UInt16[]);
            if (_arg0.TryReadArray<global::System.UInt16>(out var _p0_System_UInt16Array))
            {
                var _arg1 = _lastArg = _argCount > 2 ? _context.GetArgument(2) : global::Lua.LuaValue.Nil;
                _lastArgPos = 1; _expectedType = typeof(global::System.Int32);
                if (_arg1.TryRead<global::System.Int32>(out var _p1_System_Int32))
                {
                    if (_argCount == 3)
                    {
                        var triangles = _p0_System_UInt16Array;
                        var submesh = _p1_System_Int32;
                        _this.Instance.SetTriangles(triangles, submesh);
                        var _retCount = _context.Return();
                        return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                    }
                    var _arg2 = _lastArg = _argCount > 3 ? _context.GetArgument(3) : global::Lua.LuaValue.Nil;
                    _lastArgPos = 2; _expectedType = typeof(global::System.Boolean);
                    var _p2_System_Boolean = _arg2.ReadValue<global::System.Boolean>((global::System.Boolean)true);
                    {
                        if (_argCount == 4)
                        {
                            var triangles = _p0_System_UInt16Array;
                            var submesh = _p1_System_Int32;
                            var calculateBounds = _p2_System_Boolean;
                            _this.Instance.SetTriangles(triangles, submesh, calculateBounds);
                            var _retCount = _context.Return();
                            return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                        }
                        var _arg3 = _lastArg = _argCount > 4 ? _context.GetArgument(4) : global::Lua.LuaValue.Nil;
                        _lastArgPos = 3; _expectedType = typeof(global::System.Int32);
                        var _p3_System_Int32 = _arg3.ReadValue<global::System.Int32>((global::System.Int32)(0));
                        {
                            if (_argCount == 5)
                            {
                                var triangles = _p0_System_UInt16Array;
                                var submesh = _p1_System_Int32;
                                var calculateBounds = _p2_System_Boolean;
                                var baseVertex = _p3_System_Int32;
                                _this.Instance.SetTriangles(triangles, submesh, calculateBounds, baseVertex);
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
                            if (_argCount == 5)
                            {
                                var triangles = _p0_System_UInt16Array;
                                var trianglesStart = _p1_System_Int32;
                                var trianglesLength = _p2_System_Int32;
                                var submesh = _p3_System_Int32;
                                _this.Instance.SetTriangles(triangles, trianglesStart, trianglesLength, submesh);
                                var _retCount = _context.Return();
                                return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                            }
                            var _arg4 = _lastArg = _argCount > 5 ? _context.GetArgument(5) : global::Lua.LuaValue.Nil;
                            _lastArgPos = 4; _expectedType = typeof(global::System.Boolean);
                            var _p4_System_Boolean = _arg4.ReadValue<global::System.Boolean>((global::System.Boolean)true);
                            {
                                if (_argCount == 6)
                                {
                                    var triangles = _p0_System_UInt16Array;
                                    var trianglesStart = _p1_System_Int32;
                                    var trianglesLength = _p2_System_Int32;
                                    var submesh = _p3_System_Int32;
                                    var calculateBounds = _p4_System_Boolean;
                                    _this.Instance.SetTriangles(triangles, trianglesStart, trianglesLength, submesh, calculateBounds);
                                    var _retCount = _context.Return();
                                    return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                                }
                                var _arg5 = _lastArg = _argCount > 6 ? _context.GetArgument(6) : global::Lua.LuaValue.Nil;
                                _lastArgPos = 5; _expectedType = typeof(global::System.Int32);
                                var _p5_System_Int32 = _arg5.ReadValue<global::System.Int32>((global::System.Int32)(0));
                                {
                                    if (_argCount == 7)
                                    {
                                        var triangles = _p0_System_UInt16Array;
                                        var trianglesStart = _p1_System_Int32;
                                        var trianglesLength = _p2_System_Int32;
                                        var submesh = _p3_System_Int32;
                                        var calculateBounds = _p4_System_Boolean;
                                        var baseVertex = _p5_System_Int32;
                                        _this.Instance.SetTriangles(triangles, trianglesStart, trianglesLength, submesh, calculateBounds, baseVertex);
                                        var _retCount = _context.Return();
                                        return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                                    }
                                }
                            }
                        }
                    }
                }
            }
            throw new global::Lua.LuaRuntimeException(_context.Thread, $"{"SetTriangles"}: invalid argument #{_lastArgPos}: {_lastArg} ({_lastArg.Type}), expected: {_expectedType.FullName}", 2);
        });
        private static readonly global::Lua.LuaFunction _LuaMesh_SetUVs = new global::Lua.LuaFunction("SetUVs", (_context, _) =>
        {
            global::Lua.LuaValue _lastArg = default;
            global::System.Int32 _lastArgPos = default;
            global::System.Type _expectedType = default;
            var _argCount = _context.ArgumentCount;
            var _this = _context.GetArgument<LuaMesh>(0);
            var _arg0 = _lastArg = _argCount > 1 ? _context.GetArgument(1) : global::Lua.LuaValue.Nil;
            _lastArgPos = 0; _expectedType = typeof(global::System.Int32);
            if (_arg0.TryRead<global::System.Int32>(out var _p0_System_Int32))
            {
                var _arg1 = _lastArg = _argCount > 2 ? _context.GetArgument(2) : global::Lua.LuaValue.Nil;
                _lastArgPos = 1; _expectedType = typeof(global::UnityEngine.Vector2[]);
                if (_arg1.TryReadArray<global::UnityEngine.Vector2>(out var _p1_UnityEngine_Vector2Array))
                {
                    if (_argCount == 3)
                    {
                        var channel = _p0_System_Int32;
                        var uvs = _p1_UnityEngine_Vector2Array;
                        _this.Instance.SetUVs(channel, uvs);
                        var _retCount = _context.Return();
                        return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                    }
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
                                var channel = _p0_System_Int32;
                                var uvs = _p1_UnityEngine_Vector2Array;
                                var start = _p2_System_Int32;
                                var length = _p3_System_Int32;
                                _this.Instance.SetUVs(channel, uvs, start, length);
                                var _retCount = _context.Return();
                                return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                            }
                            var _arg4 = _lastArg = _argCount > 5 ? _context.GetArgument(5) : global::Lua.LuaValue.Nil;
                            _lastArgPos = 4; _expectedType = typeof(global::UnityEngine.Rendering.MeshUpdateFlags);
                            if (_arg4.TryRead<global::UnityEngine.Rendering.MeshUpdateFlags>(out var _p4_UnityEngine_Rendering_MeshUpdateFlags))
                            {
                                if (_argCount == 6)
                                {
                                    var channel = _p0_System_Int32;
                                    var uvs = _p1_UnityEngine_Vector2Array;
                                    var start = _p2_System_Int32;
                                    var length = _p3_System_Int32;
                                    var flags = _p4_UnityEngine_Rendering_MeshUpdateFlags;
                                    _this.Instance.SetUVs(channel, uvs, start, length, flags);
                                    var _retCount = _context.Return();
                                    return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                                }
                            }
                        }
                    }
                }
                _lastArgPos = 1; _expectedType = typeof(global::UnityEngine.Vector3[]);
                if (_arg1.TryReadArray<global::UnityEngine.Vector3>(out var _p1_UnityEngine_Vector3Array))
                {
                    if (_argCount == 3)
                    {
                        var channel = _p0_System_Int32;
                        var uvs = _p1_UnityEngine_Vector3Array;
                        _this.Instance.SetUVs(channel, uvs);
                        var _retCount = _context.Return();
                        return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                    }
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
                                var channel = _p0_System_Int32;
                                var uvs = _p1_UnityEngine_Vector3Array;
                                var start = _p2_System_Int32;
                                var length = _p3_System_Int32;
                                _this.Instance.SetUVs(channel, uvs, start, length);
                                var _retCount = _context.Return();
                                return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                            }
                            var _arg4 = _lastArg = _argCount > 5 ? _context.GetArgument(5) : global::Lua.LuaValue.Nil;
                            _lastArgPos = 4; _expectedType = typeof(global::UnityEngine.Rendering.MeshUpdateFlags);
                            if (_arg4.TryRead<global::UnityEngine.Rendering.MeshUpdateFlags>(out var _p4_UnityEngine_Rendering_MeshUpdateFlags))
                            {
                                if (_argCount == 6)
                                {
                                    var channel = _p0_System_Int32;
                                    var uvs = _p1_UnityEngine_Vector3Array;
                                    var start = _p2_System_Int32;
                                    var length = _p3_System_Int32;
                                    var flags = _p4_UnityEngine_Rendering_MeshUpdateFlags;
                                    _this.Instance.SetUVs(channel, uvs, start, length, flags);
                                    var _retCount = _context.Return();
                                    return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                                }
                            }
                        }
                    }
                }
                _lastArgPos = 1; _expectedType = typeof(global::UnityEngine.Vector4[]);
                if (_arg1.TryReadArray<global::UnityEngine.Vector4>(out var _p1_UnityEngine_Vector4Array))
                {
                    if (_argCount == 3)
                    {
                        var channel = _p0_System_Int32;
                        var uvs = _p1_UnityEngine_Vector4Array;
                        _this.Instance.SetUVs(channel, uvs);
                        var _retCount = _context.Return();
                        return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                    }
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
                                var channel = _p0_System_Int32;
                                var uvs = _p1_UnityEngine_Vector4Array;
                                var start = _p2_System_Int32;
                                var length = _p3_System_Int32;
                                _this.Instance.SetUVs(channel, uvs, start, length);
                                var _retCount = _context.Return();
                                return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                            }
                            var _arg4 = _lastArg = _argCount > 5 ? _context.GetArgument(5) : global::Lua.LuaValue.Nil;
                            _lastArgPos = 4; _expectedType = typeof(global::UnityEngine.Rendering.MeshUpdateFlags);
                            if (_arg4.TryRead<global::UnityEngine.Rendering.MeshUpdateFlags>(out var _p4_UnityEngine_Rendering_MeshUpdateFlags))
                            {
                                if (_argCount == 6)
                                {
                                    var channel = _p0_System_Int32;
                                    var uvs = _p1_UnityEngine_Vector4Array;
                                    var start = _p2_System_Int32;
                                    var length = _p3_System_Int32;
                                    var flags = _p4_UnityEngine_Rendering_MeshUpdateFlags;
                                    _this.Instance.SetUVs(channel, uvs, start, length, flags);
                                    var _retCount = _context.Return();
                                    return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                                }
                            }
                        }
                    }
                }
            }
            throw new global::Lua.LuaRuntimeException(_context.Thread, $"{"SetUVs"}: invalid argument #{_lastArgPos}: {_lastArg} ({_lastArg.Type}), expected: {_expectedType.FullName}", 2);
        });
        private static readonly global::Lua.LuaFunction _LuaMesh_SetVertexBufferParams = new global::Lua.LuaFunction("SetVertexBufferParams", (_context, _) =>
        {
            global::Lua.LuaValue _lastArg = default;
            global::System.Int32 _lastArgPos = default;
            global::System.Type _expectedType = default;
            var _argCount = _context.ArgumentCount;
            var _this = _context.GetArgument<LuaMesh>(0);
            var _arg0 = _lastArg = _argCount > 1 ? _context.GetArgument(1) : global::Lua.LuaValue.Nil;
            _lastArgPos = 0; _expectedType = typeof(global::System.Int32);
            if (_arg0.TryRead<global::System.Int32>(out var _p0_System_Int32))
            {
                var _arg1 = _lastArg = _argCount > 2 ? _context.GetArgument(2) : global::Lua.LuaValue.Nil;
                _lastArgPos = 1; _expectedType = typeof(global::UnityEngine.Rendering.VertexAttributeDescriptor[]);
                if (_arg1.TryReadArray<global::UnityEngine.Rendering.VertexAttributeDescriptor>(out var _p1_UnityEngine_Rendering_VertexAttributeDescriptorArray))
                {
                    if (_argCount == 3)
                    {
                        var vertexCount = _p0_System_Int32;
                        var attributes = _p1_UnityEngine_Rendering_VertexAttributeDescriptorArray;
                        _this.Instance.SetVertexBufferParams(vertexCount, attributes);
                        var _retCount = _context.Return();
                        return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                    }
                }
            }
            throw new global::Lua.LuaRuntimeException(_context.Thread, $"{"SetVertexBufferParams"}: invalid argument #{_lastArgPos}: {_lastArg} ({_lastArg.Type}), expected: {_expectedType.FullName}", 2);
        });
        private static readonly global::Lua.LuaFunction _LuaMesh_SetVertices = new global::Lua.LuaFunction("SetVertices", (_context, _) =>
        {
            global::Lua.LuaValue _lastArg = default;
            global::System.Int32 _lastArgPos = default;
            global::System.Type _expectedType = default;
            var _argCount = _context.ArgumentCount;
            var _this = _context.GetArgument<LuaMesh>(0);
            var _arg0 = _lastArg = _argCount > 1 ? _context.GetArgument(1) : global::Lua.LuaValue.Nil;
            _lastArgPos = 0; _expectedType = typeof(global::UnityEngine.Vector3[]);
            if (_arg0.TryReadArray<global::UnityEngine.Vector3>(out var _p0_UnityEngine_Vector3Array))
            {
                if (_argCount == 2)
                {
                    var inVertices = _p0_UnityEngine_Vector3Array;
                    _this.Instance.SetVertices(inVertices);
                    var _retCount = _context.Return();
                    return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                }
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
                            var inVertices = _p0_UnityEngine_Vector3Array;
                            var start = _p1_System_Int32;
                            var length = _p2_System_Int32;
                            _this.Instance.SetVertices(inVertices, start, length);
                            var _retCount = _context.Return();
                            return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                        }
                        var _arg3 = _lastArg = _argCount > 4 ? _context.GetArgument(4) : global::Lua.LuaValue.Nil;
                        _lastArgPos = 3; _expectedType = typeof(global::UnityEngine.Rendering.MeshUpdateFlags);
                        if (_arg3.TryRead<global::UnityEngine.Rendering.MeshUpdateFlags>(out var _p3_UnityEngine_Rendering_MeshUpdateFlags))
                        {
                            if (_argCount == 5)
                            {
                                var inVertices = _p0_UnityEngine_Vector3Array;
                                var start = _p1_System_Int32;
                                var length = _p2_System_Int32;
                                var flags = _p3_UnityEngine_Rendering_MeshUpdateFlags;
                                _this.Instance.SetVertices(inVertices, start, length, flags);
                                var _retCount = _context.Return();
                                return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                            }
                        }
                    }
                }
            }
            throw new global::Lua.LuaRuntimeException(_context.Thread, $"{"SetVertices"}: invalid argument #{_lastArgPos}: {_lastArg} ({_lastArg.Type}), expected: {_expectedType.FullName}", 2);
        });
        private static readonly global::Lua.LuaFunction _LuaMesh_UploadMeshData = new global::Lua.LuaFunction("UploadMeshData", (_context, _) =>
        {
            global::Lua.LuaValue _lastArg = default;
            global::System.Int32 _lastArgPos = default;
            global::System.Type _expectedType = default;
            var _argCount = _context.ArgumentCount;
            var _this = _context.GetArgument<LuaMesh>(0);
            var _arg0 = _lastArg = _argCount > 1 ? _context.GetArgument(1) : global::Lua.LuaValue.Nil;
            _lastArgPos = 0; _expectedType = typeof(global::System.Boolean);
            if (_arg0.TryRead<global::System.Boolean>(out var _p0_System_Boolean))
            {
                if (_argCount == 2)
                {
                    var markNoLongerReadable = _p0_System_Boolean;
                    _this.Instance.UploadMeshData(markNoLongerReadable);
                    var _retCount = _context.Return();
                    return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                }
            }
            throw new global::Lua.LuaRuntimeException(_context.Thread, $"{"UploadMeshData"}: invalid argument #{_lastArgPos}: {_lastArg} ({_lastArg.Type}), expected: {_expectedType.FullName}", 2);
        });
        private static readonly global::Lua.LuaFunction __index = new(global::Lua.Runtime.Metamethods.Index, (_context, _) =>
        {
            var _this = _context.GetArgument<LuaMesh>(0);
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
            var _this = _context.GetArgument<LuaMesh>(0);
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
                case "AddBlendShapeFrame": _value = _LuaMesh_AddBlendShapeFrame; return true;
                case "Clear": _value = _LuaMesh_Clear; return true;
                case "ClearBlendShapes": _value = _LuaMesh_ClearBlendShapes; return true;
                case "CombineMeshes": _value = _LuaMesh_CombineMeshes; return true;
                case "GetBaseVertex": _value = _LuaMesh_GetBaseVertex; return true;
                case "GetBlendShapeBuffer": _value = _LuaMesh_GetBlendShapeBuffer; return true;
                case "GetBlendShapeBufferRange": _value = _LuaMesh_GetBlendShapeBufferRange; return true;
                case "GetBlendShapeFrameCount": _value = _LuaMesh_GetBlendShapeFrameCount; return true;
                case "GetBlendShapeFrameVertices": _value = _LuaMesh_GetBlendShapeFrameVertices; return true;
                case "GetBlendShapeFrameWeight": _value = _LuaMesh_GetBlendShapeFrameWeight; return true;
                case "GetBlendShapeIndex": _value = _LuaMesh_GetBlendShapeIndex; return true;
                case "GetBlendShapeName": _value = _LuaMesh_GetBlendShapeName; return true;
                case "GetBoneWeightBuffer": _value = _LuaMesh_GetBoneWeightBuffer; return true;
                case "GetIndexBuffer": _value = _LuaMesh_GetIndexBuffer; return true;
                case "GetIndexCount": _value = _LuaMesh_GetIndexCount; return true;
                case "GetIndexStart": _value = _LuaMesh_GetIndexStart; return true;
                case "GetIndices": _value = _LuaMesh_GetIndices; return true;
                case "GetSubMesh": _value = _LuaMesh_GetSubMesh; return true;
                case "GetTopology": _value = _LuaMesh_GetTopology; return true;
                case "GetTriangles": _value = _LuaMesh_GetTriangles; return true;
                case "GetUVDistributionMetric": _value = _LuaMesh_GetUVDistributionMetric; return true;
                case "GetVertexAttribute": _value = _LuaMesh_GetVertexAttribute; return true;
                case "GetVertexAttributeDimension": _value = _LuaMesh_GetVertexAttributeDimension; return true;
                case "GetVertexAttributeFormat": _value = _LuaMesh_GetVertexAttributeFormat; return true;
                case "GetVertexAttributeOffset": _value = _LuaMesh_GetVertexAttributeOffset; return true;
                case "GetVertexAttributes": _value = _LuaMesh_GetVertexAttributes; return true;
                case "GetVertexAttributeStream": _value = _LuaMesh_GetVertexAttributeStream; return true;
                case "GetVertexBuffer": _value = _LuaMesh_GetVertexBuffer; return true;
                case "GetVertexBufferStride": _value = _LuaMesh_GetVertexBufferStride; return true;
                case "HasVertexAttribute": _value = _LuaMesh_HasVertexAttribute; return true;
                case "MarkDynamic": _value = _LuaMesh_MarkDynamic; return true;
                case "MarkModified": _value = _LuaMesh_MarkModified; return true;
                case "Optimize": _value = _LuaMesh_Optimize; return true;
                case "OptimizeIndexBuffers": _value = _LuaMesh_OptimizeIndexBuffers; return true;
                case "OptimizeReorderVertexBuffer": _value = _LuaMesh_OptimizeReorderVertexBuffer; return true;
                case "RecalculateBounds": _value = _LuaMesh_RecalculateBounds; return true;
                case "RecalculateNormals": _value = _LuaMesh_RecalculateNormals; return true;
                case "RecalculateTangents": _value = _LuaMesh_RecalculateTangents; return true;
                case "RecalculateUVDistributionMetric": _value = _LuaMesh_RecalculateUVDistributionMetric; return true;
                case "RecalculateUVDistributionMetrics": _value = _LuaMesh_RecalculateUVDistributionMetrics; return true;
                case "SetColors": _value = _LuaMesh_SetColors; return true;
                case "SetIndexBufferParams": _value = _LuaMesh_SetIndexBufferParams; return true;
                case "SetIndices": _value = _LuaMesh_SetIndices; return true;
                case "SetNormals": _value = _LuaMesh_SetNormals; return true;
                case "SetSubMesh": _value = _LuaMesh_SetSubMesh; return true;
                case "SetSubMeshes": _value = _LuaMesh_SetSubMeshes; return true;
                case "SetTangents": _value = _LuaMesh_SetTangents; return true;
                case "SetTriangles": _value = _LuaMesh_SetTriangles; return true;
                case "SetUVs": _value = _LuaMesh_SetUVs; return true;
                case "SetVertexBufferParams": _value = _LuaMesh_SetVertexBufferParams; return true;
                case "SetVertices": _value = _LuaMesh_SetVertices; return true;
                case "UploadMeshData": _value = _LuaMesh_UploadMeshData; return true;
                case "bindposeCount": _value = new global::Lua.LuaValue(Instance.bindposeCount); return true;
                case "bindposes": _value = _factory.Bind(Instance.bindposes); return true;
                case "blendShapeCount": _value = new global::Lua.LuaValue(Instance.blendShapeCount); return true;
                case "boneWeights": _value = _factory.Bind(Instance.boneWeights); return true;
                case "bounds": _value = global::Luny.UnityEngine.LuaBounds.Bind(Instance.bounds); return true;
                case "colors": _value = _factory.Bind(Instance.colors); return true;
                case "colors32": _value = _factory.Bind(Instance.colors32); return true;
                case "indexBufferTarget": _value = new global::Lua.LuaValue((global::System.Int64)Instance.indexBufferTarget); return true;
                case "indexFormat": _value = new global::Lua.LuaValue((global::System.Int64)Instance.indexFormat); return true;
                case "isReadable": _value = new global::Lua.LuaValue(Instance.isReadable); return true;
                case "normals": _value = _factory.Bind(Instance.normals); return true;
                case "skinWeightBufferLayout": _value = new global::Lua.LuaValue((global::System.Int64)Instance.skinWeightBufferLayout); return true;
                case "subMeshCount": _value = new global::Lua.LuaValue(Instance.subMeshCount); return true;
                case "tangents": _value = _factory.Bind(Instance.tangents); return true;
                case "triangles": _value = _factory.Bind(Instance.triangles); return true;
                case "uv": _value = _factory.Bind(Instance.uv); return true;
                case "uv2": _value = _factory.Bind(Instance.uv2); return true;
                case "uv3": _value = _factory.Bind(Instance.uv3); return true;
                case "uv4": _value = _factory.Bind(Instance.uv4); return true;
                case "uv5": _value = _factory.Bind(Instance.uv5); return true;
                case "uv6": _value = _factory.Bind(Instance.uv6); return true;
                case "uv7": _value = _factory.Bind(Instance.uv7); return true;
                case "uv8": _value = _factory.Bind(Instance.uv8); return true;
                case "vertexAttributeCount": _value = new global::Lua.LuaValue(Instance.vertexAttributeCount); return true;
                case "vertexBufferCount": _value = new global::Lua.LuaValue(Instance.vertexBufferCount); return true;
                case "vertexBufferTarget": _value = new global::Lua.LuaValue((global::System.Int64)Instance.vertexBufferTarget); return true;
                case "vertexCount": _value = new global::Lua.LuaValue(Instance.vertexCount); return true;
                case "vertices": _value = _factory.Bind(Instance.vertices); return true;
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
                case "bindposes": Instance.bindposes = _value.Read<global::UnityEngine.Matrix4x4[]>();  return true;
                case "boneWeights": Instance.boneWeights = _value.Read<global::UnityEngine.BoneWeight[]>();  return true;
                case "bounds": Instance.bounds = _value.Read<global::Luny.UnityEngine.LuaBounds>().Value;  return true;
                case "colors": Instance.colors = _value.Read<global::UnityEngine.Color[]>();  return true;
                case "colors32": Instance.colors32 = _value.Read<global::UnityEngine.Color32[]>();  return true;
                case "indexBufferTarget": Instance.indexBufferTarget = _value.Read<global::UnityEngine.GraphicsBuffer.Target>();  return true;
                case "indexFormat": Instance.indexFormat = _value.Read<global::UnityEngine.Rendering.IndexFormat>();  return true;
                case "normals": Instance.normals = _value.Read<global::UnityEngine.Vector3[]>();  return true;
                case "subMeshCount": Instance.subMeshCount = _value.Read<global::System.Int32>();  return true;
                case "tangents": Instance.tangents = _value.Read<global::UnityEngine.Vector4[]>();  return true;
                case "triangles": Instance.triangles = _value.Read<global::System.Int32[]>();  return true;
                case "uv": Instance.uv = _value.Read<global::UnityEngine.Vector2[]>();  return true;
                case "uv2": Instance.uv2 = _value.Read<global::UnityEngine.Vector2[]>();  return true;
                case "uv3": Instance.uv3 = _value.Read<global::UnityEngine.Vector2[]>();  return true;
                case "uv4": Instance.uv4 = _value.Read<global::UnityEngine.Vector2[]>();  return true;
                case "uv5": Instance.uv5 = _value.Read<global::UnityEngine.Vector2[]>();  return true;
                case "uv6": Instance.uv6 = _value.Read<global::UnityEngine.Vector2[]>();  return true;
                case "uv7": Instance.uv7 = _value.Read<global::UnityEngine.Vector2[]>();  return true;
                case "uv8": Instance.uv8 = _value.Read<global::UnityEngine.Vector2[]>();  return true;
                case "vertexBufferTarget": Instance.vertexBufferTarget = _value.Read<global::UnityEngine.GraphicsBuffer.Target>();  return true;
                case "vertices": Instance.vertices = _value.Read<global::UnityEngine.Vector3[]>();  return true;
                default: return base.TrySetLuaValue(_key, _value);
            }
        }
    }
    public sealed class LuaMeshType : global::Luny.ILuaStatic
    {
        public static global::Lua.LuaValue Bind() => new LuaMeshType();
        private LuaMeshType() {}
        public static implicit operator global::Lua.LuaValue(LuaMeshType value) => new(value);
        public global::System.Type BindType => typeof(global::UnityEngine.Mesh);
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

        private static readonly global::Lua.LuaFunction _LuaMesh_new = new global::Lua.LuaFunction(".ctor", (_context, _) =>
        {
            global::Lua.LuaValue _lastArg = default;
            global::System.Int32 _lastArgPos = default;
            global::System.Type _expectedType = default;
            var _argCount = _context.ArgumentCount;
            if (_argCount == 0)
            {
                var _ret0 = new global::UnityEngine.Mesh();
                var _factory = _context.GetObjectFactory();
                var _lret0 = _factory.Bind(_ret0);
                var _retCount = _context.Return(_lret0);
                return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
            }
            throw new global::Lua.LuaRuntimeException(_context.Thread, $"{".ctor"}: invalid argument #{_lastArgPos}: {_lastArg} ({_lastArg.Type}), expected: {_expectedType.FullName}", 2);
        });
        private static readonly global::Lua.LuaFunction _LuaMesh_AcquireReadOnlyMeshData = new global::Lua.LuaFunction("AcquireReadOnlyMeshData", (_context, _) =>
        {
            global::Lua.LuaValue _lastArg = default;
            global::System.Int32 _lastArgPos = default;
            global::System.Type _expectedType = default;
            var _argCount = _context.ArgumentCount;
            var _arg0 = _lastArg = _argCount > 0 ? _context.GetArgument(0) : global::Lua.LuaValue.Nil;
            _lastArgPos = 0; _expectedType = typeof(global::Luny.UnityEngine.LuaMesh);
            if (_arg0.TryRead<global::Luny.UnityEngine.LuaMesh>(out var _p0_UnityEngine_Mesh))
            {
                if (_argCount == 1)
                {
                    var mesh = _p0_UnityEngine_Mesh.Instance;
                    var _ret0 = global::UnityEngine.Mesh.AcquireReadOnlyMeshData(mesh);
                    var _lret0 = global::Luny.UnityEngine.LuaMeshMeshDataArray.Bind(_ret0);
                    var _retCount = _context.Return(_lret0);
                    return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                }
            }
            _lastArgPos = 0; _expectedType = typeof(global::UnityEngine.Mesh[]);
            if (_arg0.TryReadArray<global::UnityEngine.Mesh>(out var _p0_UnityEngine_MeshArray))
            {
                if (_argCount == 1)
                {
                    var meshes = _p0_UnityEngine_MeshArray;
                    var _ret0 = global::UnityEngine.Mesh.AcquireReadOnlyMeshData(meshes);
                    var _lret0 = global::Luny.UnityEngine.LuaMeshMeshDataArray.Bind(_ret0);
                    var _retCount = _context.Return(_lret0);
                    return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                }
            }
            throw new global::Lua.LuaRuntimeException(_context.Thread, $"{"AcquireReadOnlyMeshData"}: invalid argument #{_lastArgPos}: {_lastArg} ({_lastArg.Type}), expected: {_expectedType.FullName}", 2);
        });
        private static readonly global::Lua.LuaFunction _LuaMesh_AllocateWritableMeshData = new global::Lua.LuaFunction("AllocateWritableMeshData", (_context, _) =>
        {
            global::Lua.LuaValue _lastArg = default;
            global::System.Int32 _lastArgPos = default;
            global::System.Type _expectedType = default;
            var _argCount = _context.ArgumentCount;
            var _arg0 = _lastArg = _argCount > 0 ? _context.GetArgument(0) : global::Lua.LuaValue.Nil;
            _lastArgPos = 0; _expectedType = typeof(global::System.Int32);
            if (_arg0.TryRead<global::System.Int32>(out var _p0_System_Int32))
            {
                if (_argCount == 1)
                {
                    var meshCount = _p0_System_Int32;
                    var _ret0 = global::UnityEngine.Mesh.AllocateWritableMeshData(meshCount);
                    var _lret0 = global::Luny.UnityEngine.LuaMeshMeshDataArray.Bind(_ret0);
                    var _retCount = _context.Return(_lret0);
                    return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                }
            }
            _lastArgPos = 0; _expectedType = typeof(global::Luny.UnityEngine.LuaMesh);
            if (_arg0.TryRead<global::Luny.UnityEngine.LuaMesh>(out var _p0_UnityEngine_Mesh))
            {
                if (_argCount == 1)
                {
                    var mesh = _p0_UnityEngine_Mesh.Instance;
                    var _ret0 = global::UnityEngine.Mesh.AllocateWritableMeshData(mesh);
                    var _lret0 = global::Luny.UnityEngine.LuaMeshMeshDataArray.Bind(_ret0);
                    var _retCount = _context.Return(_lret0);
                    return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                }
            }
            _lastArgPos = 0; _expectedType = typeof(global::UnityEngine.Mesh[]);
            if (_arg0.TryReadArray<global::UnityEngine.Mesh>(out var _p0_UnityEngine_MeshArray))
            {
                if (_argCount == 1)
                {
                    var meshes = _p0_UnityEngine_MeshArray;
                    var _ret0 = global::UnityEngine.Mesh.AllocateWritableMeshData(meshes);
                    var _lret0 = global::Luny.UnityEngine.LuaMeshMeshDataArray.Bind(_ret0);
                    var _retCount = _context.Return(_lret0);
                    return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                }
            }
            throw new global::Lua.LuaRuntimeException(_context.Thread, $"{"AllocateWritableMeshData"}: invalid argument #{_lastArgPos}: {_lastArg} ({_lastArg.Type}), expected: {_expectedType.FullName}", 2);
        });
        private static readonly global::Lua.LuaFunction _LuaMesh_ApplyAndDisposeWritableMeshData = new global::Lua.LuaFunction("ApplyAndDisposeWritableMeshData", (_context, _) =>
        {
            global::Lua.LuaValue _lastArg = default;
            global::System.Int32 _lastArgPos = default;
            global::System.Type _expectedType = default;
            var _argCount = _context.ArgumentCount;
            var _arg0 = _lastArg = _argCount > 0 ? _context.GetArgument(0) : global::Lua.LuaValue.Nil;
            _lastArgPos = 0; _expectedType = typeof(global::Luny.UnityEngine.LuaMeshMeshDataArray);
            if (_arg0.TryRead<global::Luny.UnityEngine.LuaMeshMeshDataArray>(out var _p0_UnityEngine_Mesh_MeshDataArray))
            {
                var _arg1 = _lastArg = _argCount > 1 ? _context.GetArgument(1) : global::Lua.LuaValue.Nil;
                _lastArgPos = 1; _expectedType = typeof(global::Luny.UnityEngine.LuaMesh);
                if (_arg1.TryRead<global::Luny.UnityEngine.LuaMesh>(out var _p1_UnityEngine_Mesh))
                {
                    if (_argCount == 2)
                    {
                        var data = _p0_UnityEngine_Mesh_MeshDataArray.Value;
                        var mesh = _p1_UnityEngine_Mesh.Instance;
                        global::UnityEngine.Mesh.ApplyAndDisposeWritableMeshData(data, mesh);
                        var _retCount = _context.Return();
                        return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                    }
                    var _arg2 = _lastArg = _argCount > 2 ? _context.GetArgument(2) : global::Lua.LuaValue.Nil;
                    _lastArgPos = 2; _expectedType = typeof(global::UnityEngine.Rendering.MeshUpdateFlags);
                    var _p2_UnityEngine_Rendering_MeshUpdateFlags = _arg2.ReadValue<global::UnityEngine.Rendering.MeshUpdateFlags>(global::UnityEngine.Rendering.MeshUpdateFlags.@Default);
                    {
                        if (_argCount == 3)
                        {
                            var data = _p0_UnityEngine_Mesh_MeshDataArray.Value;
                            var mesh = _p1_UnityEngine_Mesh.Instance;
                            var flags = _p2_UnityEngine_Rendering_MeshUpdateFlags;
                            global::UnityEngine.Mesh.ApplyAndDisposeWritableMeshData(data, mesh, flags);
                            var _retCount = _context.Return();
                            return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                        }
                    }
                }
                _lastArgPos = 1; _expectedType = typeof(global::UnityEngine.Mesh[]);
                if (_arg1.TryReadArray<global::UnityEngine.Mesh>(out var _p1_UnityEngine_MeshArray))
                {
                    if (_argCount == 2)
                    {
                        var data = _p0_UnityEngine_Mesh_MeshDataArray.Value;
                        var meshes = _p1_UnityEngine_MeshArray;
                        global::UnityEngine.Mesh.ApplyAndDisposeWritableMeshData(data, meshes);
                        var _retCount = _context.Return();
                        return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                    }
                    var _arg2 = _lastArg = _argCount > 2 ? _context.GetArgument(2) : global::Lua.LuaValue.Nil;
                    _lastArgPos = 2; _expectedType = typeof(global::UnityEngine.Rendering.MeshUpdateFlags);
                    var _p2_UnityEngine_Rendering_MeshUpdateFlags = _arg2.ReadValue<global::UnityEngine.Rendering.MeshUpdateFlags>(global::UnityEngine.Rendering.MeshUpdateFlags.@Default);
                    {
                        if (_argCount == 3)
                        {
                            var data = _p0_UnityEngine_Mesh_MeshDataArray.Value;
                            var meshes = _p1_UnityEngine_MeshArray;
                            var flags = _p2_UnityEngine_Rendering_MeshUpdateFlags;
                            global::UnityEngine.Mesh.ApplyAndDisposeWritableMeshData(data, meshes, flags);
                            var _retCount = _context.Return();
                            return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                        }
                    }
                }
            }
            throw new global::Lua.LuaRuntimeException(_context.Thread, $"{"ApplyAndDisposeWritableMeshData"}: invalid argument #{_lastArgPos}: {_lastArg} ({_lastArg.Type}), expected: {_expectedType.FullName}", 2);
        });
        private static readonly global::Lua.LuaFunction __index = new(global::Lua.Runtime.Metamethods.Index, (_context, _) =>
        {
            var _this = _context.GetArgument<LuaMeshType>(0);
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
            var _this = _context.GetArgument<LuaMeshType>(0);
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
                case "new": _value = _LuaMesh_new; return true;
                case "AcquireReadOnlyMeshData": _value = _LuaMesh_AcquireReadOnlyMeshData; return true;
                case "AllocateWritableMeshData": _value = _LuaMesh_AllocateWritableMeshData; return true;
                case "ApplyAndDisposeWritableMeshData": _value = _LuaMesh_ApplyAndDisposeWritableMeshData; return true;
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
