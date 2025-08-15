
// --------------------------------------------------------------
// GENERATED FILE ----> DO NOT EDIT <---- CHANGES WILL BE LOST !!
// --------------------------------------------------------------

#if UNITY_6000_2_OR_NEWER && !(UNITY_6000_3_OR_NEWER)
#pragma warning disable 0109, 0162, 0168, 0219
using Luny;

namespace Luny.UnityEngine
{
    public sealed class LuaMeshMeshData : global::Luny.ILuaValueType<global::UnityEngine.Mesh.MeshData>
    {
        public new static global::Lua.LuaValue Bind(in global::UnityEngine.Mesh.MeshData instance) => new LuaMeshMeshData(instance);
        public new static global::Lua.LuaValue Bind(global::System.Object instance) => Bind((global::UnityEngine.Mesh.MeshData)instance);
        public new static global::Lua.LuaValue Bind(global::System.Collections.Generic.IList<global::UnityEngine.Mesh.MeshData> instances) =>
            new global::Luny.LuaList<global::UnityEngine.Mesh.MeshData>(instances);
        public new static global::Lua.LuaValue Bind(global::System.Collections.Generic.IList<global::System.Object> instances) =>
            new global::Luny.LuaList<global::UnityEngine.Mesh.MeshData>(instances);
        private LuaMeshMeshData(in global::UnityEngine.Mesh.MeshData value) => m_Value = value;
        public static implicit operator global::Lua.LuaValue(LuaMeshMeshData value) => new(value);
        private global::UnityEngine.Mesh.MeshData m_Value;
        public global::UnityEngine.Mesh.MeshData Value { get => m_Value; set => m_Value = value; }
        public ref global::UnityEngine.Mesh.MeshData ValueRef => ref m_Value;
        public global::System.Type BindType => typeof(global::UnityEngine.Mesh.MeshData);
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

        private static readonly global::Lua.LuaFunction _LuaMeshMeshData_GetLod = new global::Lua.LuaFunction("GetLod", (_context, _) =>
        {
            global::Lua.LuaValue _lastArg = default;
            global::System.Int32 _lastArgPos = default;
            global::System.Type _expectedType = default;
            var _argCount = _context.ArgumentCount;
            var _this = _context.GetArgument<LuaMeshMeshData>(0);
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
                        var submesh = _p0_System_Int32;
                        var level = _p1_System_Int32;
                        var _ret0 = _this.m_Value.GetLod(submesh, level);
                        var _lret0 = global::Luny.UnityEngine.LuaMeshLodRange.Bind(_ret0);
                        var _retCount = _context.Return(_lret0);
                        return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                    }
                }
            }
            throw new global::Lua.LuaRuntimeException(_context.Thread, $"{"GetLod"}: invalid argument #{_lastArgPos}: {_lastArg} ({_lastArg.Type}), expected: {_expectedType.FullName}", 2);
        });
        private static readonly global::Lua.LuaFunction _LuaMeshMeshData_GetSubMesh = new global::Lua.LuaFunction("GetSubMesh", (_context, _) =>
        {
            global::Lua.LuaValue _lastArg = default;
            global::System.Int32 _lastArgPos = default;
            global::System.Type _expectedType = default;
            var _argCount = _context.ArgumentCount;
            var _this = _context.GetArgument<LuaMeshMeshData>(0);
            var _arg0 = _lastArg = _argCount > 1 ? _context.GetArgument(1) : global::Lua.LuaValue.Nil;
            _lastArgPos = 0; _expectedType = typeof(global::System.Int32);
            if (_arg0.TryRead<global::System.Int32>(out var _p0_System_Int32))
            {
                if (_argCount == 2)
                {
                    var index = _p0_System_Int32;
                    var _ret0 = _this.m_Value.GetSubMesh(index);
                    var _lret0 = global::Luny.UnityEngine.Rendering.LuaSubMeshDescriptor.Bind(_ret0);
                    var _retCount = _context.Return(_lret0);
                    return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                }
            }
            throw new global::Lua.LuaRuntimeException(_context.Thread, $"{"GetSubMesh"}: invalid argument #{_lastArgPos}: {_lastArg} ({_lastArg.Type}), expected: {_expectedType.FullName}", 2);
        });
        private static readonly global::Lua.LuaFunction _LuaMeshMeshData_GetVertexAttributeDimension = new global::Lua.LuaFunction("GetVertexAttributeDimension", (_context, _) =>
        {
            global::Lua.LuaValue _lastArg = default;
            global::System.Int32 _lastArgPos = default;
            global::System.Type _expectedType = default;
            var _argCount = _context.ArgumentCount;
            var _this = _context.GetArgument<LuaMeshMeshData>(0);
            var _arg0 = _lastArg = _argCount > 1 ? _context.GetArgument(1) : global::Lua.LuaValue.Nil;
            _lastArgPos = 0; _expectedType = typeof(global::UnityEngine.Rendering.VertexAttribute);
            if (_arg0.TryRead<global::UnityEngine.Rendering.VertexAttribute>(out var _p0_UnityEngine_Rendering_VertexAttribute))
            {
                if (_argCount == 2)
                {
                    var attr = _p0_UnityEngine_Rendering_VertexAttribute;
                    var _ret0 = _this.m_Value.GetVertexAttributeDimension(attr);
                    var _lret0 = new global::Lua.LuaValue(_ret0);
                    var _retCount = _context.Return(_lret0);
                    return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                }
            }
            throw new global::Lua.LuaRuntimeException(_context.Thread, $"{"GetVertexAttributeDimension"}: invalid argument #{_lastArgPos}: {_lastArg} ({_lastArg.Type}), expected: {_expectedType.FullName}", 2);
        });
        private static readonly global::Lua.LuaFunction _LuaMeshMeshData_GetVertexAttributeFormat = new global::Lua.LuaFunction("GetVertexAttributeFormat", (_context, _) =>
        {
            global::Lua.LuaValue _lastArg = default;
            global::System.Int32 _lastArgPos = default;
            global::System.Type _expectedType = default;
            var _argCount = _context.ArgumentCount;
            var _this = _context.GetArgument<LuaMeshMeshData>(0);
            var _arg0 = _lastArg = _argCount > 1 ? _context.GetArgument(1) : global::Lua.LuaValue.Nil;
            _lastArgPos = 0; _expectedType = typeof(global::UnityEngine.Rendering.VertexAttribute);
            if (_arg0.TryRead<global::UnityEngine.Rendering.VertexAttribute>(out var _p0_UnityEngine_Rendering_VertexAttribute))
            {
                if (_argCount == 2)
                {
                    var attr = _p0_UnityEngine_Rendering_VertexAttribute;
                    var _ret0 = _this.m_Value.GetVertexAttributeFormat(attr);
                    var _lret0 = new global::Lua.LuaValue((global::System.Int64)_ret0);
                    var _retCount = _context.Return(_lret0);
                    return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                }
            }
            throw new global::Lua.LuaRuntimeException(_context.Thread, $"{"GetVertexAttributeFormat"}: invalid argument #{_lastArgPos}: {_lastArg} ({_lastArg.Type}), expected: {_expectedType.FullName}", 2);
        });
        private static readonly global::Lua.LuaFunction _LuaMeshMeshData_GetVertexAttributeOffset = new global::Lua.LuaFunction("GetVertexAttributeOffset", (_context, _) =>
        {
            global::Lua.LuaValue _lastArg = default;
            global::System.Int32 _lastArgPos = default;
            global::System.Type _expectedType = default;
            var _argCount = _context.ArgumentCount;
            var _this = _context.GetArgument<LuaMeshMeshData>(0);
            var _arg0 = _lastArg = _argCount > 1 ? _context.GetArgument(1) : global::Lua.LuaValue.Nil;
            _lastArgPos = 0; _expectedType = typeof(global::UnityEngine.Rendering.VertexAttribute);
            if (_arg0.TryRead<global::UnityEngine.Rendering.VertexAttribute>(out var _p0_UnityEngine_Rendering_VertexAttribute))
            {
                if (_argCount == 2)
                {
                    var attr = _p0_UnityEngine_Rendering_VertexAttribute;
                    var _ret0 = _this.m_Value.GetVertexAttributeOffset(attr);
                    var _lret0 = new global::Lua.LuaValue(_ret0);
                    var _retCount = _context.Return(_lret0);
                    return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                }
            }
            throw new global::Lua.LuaRuntimeException(_context.Thread, $"{"GetVertexAttributeOffset"}: invalid argument #{_lastArgPos}: {_lastArg} ({_lastArg.Type}), expected: {_expectedType.FullName}", 2);
        });
        private static readonly global::Lua.LuaFunction _LuaMeshMeshData_GetVertexAttributeStream = new global::Lua.LuaFunction("GetVertexAttributeStream", (_context, _) =>
        {
            global::Lua.LuaValue _lastArg = default;
            global::System.Int32 _lastArgPos = default;
            global::System.Type _expectedType = default;
            var _argCount = _context.ArgumentCount;
            var _this = _context.GetArgument<LuaMeshMeshData>(0);
            var _arg0 = _lastArg = _argCount > 1 ? _context.GetArgument(1) : global::Lua.LuaValue.Nil;
            _lastArgPos = 0; _expectedType = typeof(global::UnityEngine.Rendering.VertexAttribute);
            if (_arg0.TryRead<global::UnityEngine.Rendering.VertexAttribute>(out var _p0_UnityEngine_Rendering_VertexAttribute))
            {
                if (_argCount == 2)
                {
                    var attr = _p0_UnityEngine_Rendering_VertexAttribute;
                    var _ret0 = _this.m_Value.GetVertexAttributeStream(attr);
                    var _lret0 = new global::Lua.LuaValue(_ret0);
                    var _retCount = _context.Return(_lret0);
                    return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                }
            }
            throw new global::Lua.LuaRuntimeException(_context.Thread, $"{"GetVertexAttributeStream"}: invalid argument #{_lastArgPos}: {_lastArg} ({_lastArg.Type}), expected: {_expectedType.FullName}", 2);
        });
        private static readonly global::Lua.LuaFunction _LuaMeshMeshData_GetVertexBufferStride = new global::Lua.LuaFunction("GetVertexBufferStride", (_context, _) =>
        {
            global::Lua.LuaValue _lastArg = default;
            global::System.Int32 _lastArgPos = default;
            global::System.Type _expectedType = default;
            var _argCount = _context.ArgumentCount;
            var _this = _context.GetArgument<LuaMeshMeshData>(0);
            var _arg0 = _lastArg = _argCount > 1 ? _context.GetArgument(1) : global::Lua.LuaValue.Nil;
            _lastArgPos = 0; _expectedType = typeof(global::System.Int32);
            if (_arg0.TryRead<global::System.Int32>(out var _p0_System_Int32))
            {
                if (_argCount == 2)
                {
                    var stream = _p0_System_Int32;
                    var _ret0 = _this.m_Value.GetVertexBufferStride(stream);
                    var _lret0 = new global::Lua.LuaValue(_ret0);
                    var _retCount = _context.Return(_lret0);
                    return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                }
            }
            throw new global::Lua.LuaRuntimeException(_context.Thread, $"{"GetVertexBufferStride"}: invalid argument #{_lastArgPos}: {_lastArg} ({_lastArg.Type}), expected: {_expectedType.FullName}", 2);
        });
        private static readonly global::Lua.LuaFunction _LuaMeshMeshData_HasVertexAttribute = new global::Lua.LuaFunction("HasVertexAttribute", (_context, _) =>
        {
            global::Lua.LuaValue _lastArg = default;
            global::System.Int32 _lastArgPos = default;
            global::System.Type _expectedType = default;
            var _argCount = _context.ArgumentCount;
            var _this = _context.GetArgument<LuaMeshMeshData>(0);
            var _arg0 = _lastArg = _argCount > 1 ? _context.GetArgument(1) : global::Lua.LuaValue.Nil;
            _lastArgPos = 0; _expectedType = typeof(global::UnityEngine.Rendering.VertexAttribute);
            if (_arg0.TryRead<global::UnityEngine.Rendering.VertexAttribute>(out var _p0_UnityEngine_Rendering_VertexAttribute))
            {
                if (_argCount == 2)
                {
                    var attr = _p0_UnityEngine_Rendering_VertexAttribute;
                    var _ret0 = _this.m_Value.HasVertexAttribute(attr);
                    var _lret0 = new global::Lua.LuaValue(_ret0);
                    var _retCount = _context.Return(_lret0);
                    return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                }
            }
            throw new global::Lua.LuaRuntimeException(_context.Thread, $"{"HasVertexAttribute"}: invalid argument #{_lastArgPos}: {_lastArg} ({_lastArg.Type}), expected: {_expectedType.FullName}", 2);
        });
        private static readonly global::Lua.LuaFunction _LuaMeshMeshData_SetIndexBufferParams = new global::Lua.LuaFunction("SetIndexBufferParams", (_context, _) =>
        {
            global::Lua.LuaValue _lastArg = default;
            global::System.Int32 _lastArgPos = default;
            global::System.Type _expectedType = default;
            var _argCount = _context.ArgumentCount;
            var _this = _context.GetArgument<LuaMeshMeshData>(0);
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
                        _this.m_Value.SetIndexBufferParams(indexCount, format);
                        var _retCount = _context.Return();
                        return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                    }
                }
            }
            throw new global::Lua.LuaRuntimeException(_context.Thread, $"{"SetIndexBufferParams"}: invalid argument #{_lastArgPos}: {_lastArg} ({_lastArg.Type}), expected: {_expectedType.FullName}", 2);
        });
        private static readonly global::Lua.LuaFunction _LuaMeshMeshData_SetLod = new global::Lua.LuaFunction("SetLod", (_context, _) =>
        {
            global::Lua.LuaValue _lastArg = default;
            global::System.Int32 _lastArgPos = default;
            global::System.Type _expectedType = default;
            var _argCount = _context.ArgumentCount;
            var _this = _context.GetArgument<LuaMeshMeshData>(0);
            var _arg0 = _lastArg = _argCount > 1 ? _context.GetArgument(1) : global::Lua.LuaValue.Nil;
            _lastArgPos = 0; _expectedType = typeof(global::System.Int32);
            if (_arg0.TryRead<global::System.Int32>(out var _p0_System_Int32))
            {
                var _arg1 = _lastArg = _argCount > 2 ? _context.GetArgument(2) : global::Lua.LuaValue.Nil;
                _lastArgPos = 1; _expectedType = typeof(global::System.Int32);
                if (_arg1.TryRead<global::System.Int32>(out var _p1_System_Int32))
                {
                    var _arg2 = _lastArg = _argCount > 3 ? _context.GetArgument(3) : global::Lua.LuaValue.Nil;
                    _lastArgPos = 2; _expectedType = typeof(global::Luny.UnityEngine.LuaMeshLodRange);
                    if (_arg2.TryRead<global::Luny.UnityEngine.LuaMeshLodRange>(out var _p2_UnityEngine_MeshLodRange))
                    {
                        if (_argCount == 4)
                        {
                            var submesh = _p0_System_Int32;
                            var level = _p1_System_Int32;
                            var levelRange = _p2_UnityEngine_MeshLodRange.Value;
                            _this.m_Value.SetLod(submesh, level, levelRange);
                            var _retCount = _context.Return();
                            return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                        }
                        var _arg3 = _lastArg = _argCount > 4 ? _context.GetArgument(4) : global::Lua.LuaValue.Nil;
                        _lastArgPos = 3; _expectedType = typeof(global::UnityEngine.Rendering.MeshUpdateFlags);
                        var _p3_UnityEngine_Rendering_MeshUpdateFlags = _arg3.ReadValue<global::UnityEngine.Rendering.MeshUpdateFlags>(global::UnityEngine.Rendering.MeshUpdateFlags.@Default);
                        {
                            if (_argCount == 5)
                            {
                                var submesh = _p0_System_Int32;
                                var level = _p1_System_Int32;
                                var levelRange = _p2_UnityEngine_MeshLodRange.Value;
                                var flags = _p3_UnityEngine_Rendering_MeshUpdateFlags;
                                _this.m_Value.SetLod(submesh, level, levelRange, flags);
                                var _retCount = _context.Return();
                                return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                            }
                        }
                    }
                }
            }
            throw new global::Lua.LuaRuntimeException(_context.Thread, $"{"SetLod"}: invalid argument #{_lastArgPos}: {_lastArg} ({_lastArg.Type}), expected: {_expectedType.FullName}", 2);
        });
        private static readonly global::Lua.LuaFunction _LuaMeshMeshData_SetSubMesh = new global::Lua.LuaFunction("SetSubMesh", (_context, _) =>
        {
            global::Lua.LuaValue _lastArg = default;
            global::System.Int32 _lastArgPos = default;
            global::System.Type _expectedType = default;
            var _argCount = _context.ArgumentCount;
            var _this = _context.GetArgument<LuaMeshMeshData>(0);
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
                        _this.m_Value.SetSubMesh(index, desc);
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
                            _this.m_Value.SetSubMesh(index, desc, flags);
                            var _retCount = _context.Return();
                            return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                        }
                    }
                }
            }
            throw new global::Lua.LuaRuntimeException(_context.Thread, $"{"SetSubMesh"}: invalid argument #{_lastArgPos}: {_lastArg} ({_lastArg.Type}), expected: {_expectedType.FullName}", 2);
        });
        private static readonly global::Lua.LuaFunction _LuaMeshMeshData_SetVertexBufferParams = new global::Lua.LuaFunction("SetVertexBufferParams", (_context, _) =>
        {
            global::Lua.LuaValue _lastArg = default;
            global::System.Int32 _lastArgPos = default;
            global::System.Type _expectedType = default;
            var _argCount = _context.ArgumentCount;
            var _this = _context.GetArgument<LuaMeshMeshData>(0);
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
                        _this.m_Value.SetVertexBufferParams(vertexCount, attributes);
                        var _retCount = _context.Return();
                        return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                    }
                }
            }
            throw new global::Lua.LuaRuntimeException(_context.Thread, $"{"SetVertexBufferParams"}: invalid argument #{_lastArgPos}: {_lastArg} ({_lastArg.Type}), expected: {_expectedType.FullName}", 2);
        });
        private static readonly global::Lua.LuaFunction __index = new(global::Lua.Runtime.Metamethods.Index, (_context, _) =>
        {
            var _this = _context.GetArgument<LuaMeshMeshData>(0);
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
            var _this = _context.GetArgument<LuaMeshMeshData>(0);
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
                case "GetLod": _value = _LuaMeshMeshData_GetLod; return true;
                case "GetSubMesh": _value = _LuaMeshMeshData_GetSubMesh; return true;
                case "GetVertexAttributeDimension": _value = _LuaMeshMeshData_GetVertexAttributeDimension; return true;
                case "GetVertexAttributeFormat": _value = _LuaMeshMeshData_GetVertexAttributeFormat; return true;
                case "GetVertexAttributeOffset": _value = _LuaMeshMeshData_GetVertexAttributeOffset; return true;
                case "GetVertexAttributeStream": _value = _LuaMeshMeshData_GetVertexAttributeStream; return true;
                case "GetVertexBufferStride": _value = _LuaMeshMeshData_GetVertexBufferStride; return true;
                case "HasVertexAttribute": _value = _LuaMeshMeshData_HasVertexAttribute; return true;
                case "SetIndexBufferParams": _value = _LuaMeshMeshData_SetIndexBufferParams; return true;
                case "SetLod": _value = _LuaMeshMeshData_SetLod; return true;
                case "SetSubMesh": _value = _LuaMeshMeshData_SetSubMesh; return true;
                case "SetVertexBufferParams": _value = _LuaMeshMeshData_SetVertexBufferParams; return true;
                case "indexFormat": _value = new global::Lua.LuaValue((global::System.Int64)m_Value.indexFormat); return true;
                case "lodCount": _value = new global::Lua.LuaValue(m_Value.lodCount); return true;
                case "lodSelectionCurve": _value = global::Luny.UnityEngine.LuaMeshLodSelectionCurve.Bind(m_Value.lodSelectionCurve); return true;
                case "subMeshCount": _value = new global::Lua.LuaValue(m_Value.subMeshCount); return true;
                case "vertexBufferCount": _value = new global::Lua.LuaValue(m_Value.vertexBufferCount); return true;
                case "vertexCount": _value = new global::Lua.LuaValue(m_Value.vertexCount); return true;
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
                case "lodCount": { var _temp = m_Value; _temp.lodCount = _value.Read<global::System.Int32>(); m_Value = _temp; } return true;
                case "lodSelectionCurve": { var _temp = m_Value; _temp.lodSelectionCurve = _value.Read<global::Luny.UnityEngine.LuaMeshLodSelectionCurve>().Value; m_Value = _temp; } return true;
                case "subMeshCount": { var _temp = m_Value; _temp.subMeshCount = _value.Read<global::System.Int32>(); m_Value = _temp; } return true;
                default: return false;
            }
        }
    }
    public sealed class LuaMeshMeshDataType : global::Luny.ILuaStatic
    {
        public static global::Lua.LuaValue Bind() => new LuaMeshMeshDataType();
        private LuaMeshMeshDataType() {}
        public static implicit operator global::Lua.LuaValue(LuaMeshMeshDataType value) => new(value);
        public global::System.Type BindType => typeof(global::UnityEngine.Mesh.MeshData);
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

        private static readonly global::Lua.LuaFunction __index = new(global::Lua.Runtime.Metamethods.Index, (_context, _) =>
        {
            var _this = _context.GetArgument<LuaMeshMeshDataType>(0);
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
            var _this = _context.GetArgument<LuaMeshMeshDataType>(0);
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
