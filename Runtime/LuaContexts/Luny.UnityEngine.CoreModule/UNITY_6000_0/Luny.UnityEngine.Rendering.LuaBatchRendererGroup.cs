
// --------------------------------------------------------------
// GENERATED FILE ----> DO NOT EDIT <---- CHANGES WILL BE LOST !!
// --------------------------------------------------------------

#if UNITY_6000_0_OR_NEWER && !(UNITY_6000_1_OR_NEWER)
#pragma warning disable 0109, 0162, 0168, 0219
using Luny;

namespace Luny.UnityEngine.Rendering
{
    public sealed class LuaBatchRendererGroup : global::Luny.ILuaObject<global::UnityEngine.Rendering.BatchRendererGroup>
    {
        public new static global::Lua.LuaValue Bind(global::UnityEngine.Rendering.BatchRendererGroup instance) => new LuaBatchRendererGroup(instance);
        public new static global::Lua.LuaValue Bind(global::System.Object instance) => Bind((global::UnityEngine.Rendering.BatchRendererGroup)instance);
        public new static global::Lua.LuaValue Bind(global::System.Collections.Generic.IList<global::UnityEngine.Rendering.BatchRendererGroup> instances) =>
            new global::Luny.LuaList<global::UnityEngine.Rendering.BatchRendererGroup>(instances);
        public new static global::Lua.LuaValue Bind(global::System.Collections.Generic.IList<global::System.Object> instances) =>
            new global::Luny.LuaList<global::UnityEngine.Rendering.BatchRendererGroup>(instances);
        private LuaBatchRendererGroup(global::UnityEngine.Rendering.BatchRendererGroup instance) => m_Instance = instance;
        public static implicit operator global::Lua.LuaValue(LuaBatchRendererGroup value) => new(value);
        private global::UnityEngine.Rendering.BatchRendererGroup m_Instance;
        public global::UnityEngine.Rendering.BatchRendererGroup Instance => m_Instance;
        public new global::System.Type BindType => typeof(global::UnityEngine.Rendering.BatchRendererGroup);
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

        private static readonly global::Lua.LuaFunction _LuaBatchRendererGroup_Dispose = new global::Lua.LuaFunction("Dispose", (_context, _) =>
        {
            global::Lua.LuaValue _lastArg = default;
            global::System.Int32 _lastArgPos = default;
            global::System.Type _expectedType = default;
            var _argCount = _context.ArgumentCount;
            var _this = _context.GetArgument<LuaBatchRendererGroup>(0);
            if (_argCount == 1)
            {
                _this.Instance.Dispose();
                var _retCount = _context.Return();
                return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
            }
            throw new global::Lua.LuaRuntimeException(_context.Thread, $"{"Dispose"}: invalid argument #{_lastArgPos}: {_lastArg} ({_lastArg.Type}), expected: {_expectedType.FullName}", 2);
        });
        private static readonly global::Lua.LuaFunction _LuaBatchRendererGroup_GetRegisteredMaterial = new global::Lua.LuaFunction("GetRegisteredMaterial", (_context, _) =>
        {
            global::Lua.LuaValue _lastArg = default;
            global::System.Int32 _lastArgPos = default;
            global::System.Type _expectedType = default;
            var _argCount = _context.ArgumentCount;
            var _this = _context.GetArgument<LuaBatchRendererGroup>(0);
            var _arg0 = _lastArg = _argCount > 1 ? _context.GetArgument(1) : global::Lua.LuaValue.Nil;
            _lastArgPos = 0; _expectedType = typeof(global::Luny.UnityEngine.Rendering.LuaBatchMaterialID);
            if (_arg0.TryRead<global::Luny.UnityEngine.Rendering.LuaBatchMaterialID>(out var _p0_UnityEngine_Rendering_BatchMaterialID))
            {
                if (_argCount == 2)
                {
                    var material = _p0_UnityEngine_Rendering_BatchMaterialID.Value;
                    var _ret0 = _this.Instance.GetRegisteredMaterial(material);
                    var _factory = _context.GetObjectFactory();
                    var _lret0 = _factory.Bind(_ret0);
                    var _retCount = _context.Return(_lret0);
                    return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                }
            }
            throw new global::Lua.LuaRuntimeException(_context.Thread, $"{"GetRegisteredMaterial"}: invalid argument #{_lastArgPos}: {_lastArg} ({_lastArg.Type}), expected: {_expectedType.FullName}", 2);
        });
        private static readonly global::Lua.LuaFunction _LuaBatchRendererGroup_GetRegisteredMesh = new global::Lua.LuaFunction("GetRegisteredMesh", (_context, _) =>
        {
            global::Lua.LuaValue _lastArg = default;
            global::System.Int32 _lastArgPos = default;
            global::System.Type _expectedType = default;
            var _argCount = _context.ArgumentCount;
            var _this = _context.GetArgument<LuaBatchRendererGroup>(0);
            var _arg0 = _lastArg = _argCount > 1 ? _context.GetArgument(1) : global::Lua.LuaValue.Nil;
            _lastArgPos = 0; _expectedType = typeof(global::Luny.UnityEngine.Rendering.LuaBatchMeshID);
            if (_arg0.TryRead<global::Luny.UnityEngine.Rendering.LuaBatchMeshID>(out var _p0_UnityEngine_Rendering_BatchMeshID))
            {
                if (_argCount == 2)
                {
                    var mesh = _p0_UnityEngine_Rendering_BatchMeshID.Value;
                    var _ret0 = _this.Instance.GetRegisteredMesh(mesh);
                    var _factory = _context.GetObjectFactory();
                    var _lret0 = _factory.Bind(_ret0);
                    var _retCount = _context.Return(_lret0);
                    return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                }
            }
            throw new global::Lua.LuaRuntimeException(_context.Thread, $"{"GetRegisteredMesh"}: invalid argument #{_lastArgPos}: {_lastArg} ({_lastArg.Type}), expected: {_expectedType.FullName}", 2);
        });
        private static readonly global::Lua.LuaFunction _LuaBatchRendererGroup_GetThreadedBatchContext = new global::Lua.LuaFunction("GetThreadedBatchContext", (_context, _) =>
        {
            global::Lua.LuaValue _lastArg = default;
            global::System.Int32 _lastArgPos = default;
            global::System.Type _expectedType = default;
            var _argCount = _context.ArgumentCount;
            var _this = _context.GetArgument<LuaBatchRendererGroup>(0);
            if (_argCount == 1)
            {
                var _ret0 = _this.Instance.GetThreadedBatchContext();
                var _lret0 = global::Luny.UnityEngine.Rendering.LuaThreadedBatchContext.Bind(_ret0);
                var _retCount = _context.Return(_lret0);
                return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
            }
            throw new global::Lua.LuaRuntimeException(_context.Thread, $"{"GetThreadedBatchContext"}: invalid argument #{_lastArgPos}: {_lastArg} ({_lastArg.Type}), expected: {_expectedType.FullName}", 2);
        });
        private static readonly global::Lua.LuaFunction _LuaBatchRendererGroup_RegisterMaterial = new global::Lua.LuaFunction("RegisterMaterial", (_context, _) =>
        {
            global::Lua.LuaValue _lastArg = default;
            global::System.Int32 _lastArgPos = default;
            global::System.Type _expectedType = default;
            var _argCount = _context.ArgumentCount;
            var _this = _context.GetArgument<LuaBatchRendererGroup>(0);
            var _arg0 = _lastArg = _argCount > 1 ? _context.GetArgument(1) : global::Lua.LuaValue.Nil;
            _lastArgPos = 0; _expectedType = typeof(global::Luny.UnityEngine.LuaMaterial);
            if (_arg0.TryRead<global::Luny.UnityEngine.LuaMaterial>(out var _p0_UnityEngine_Material))
            {
                if (_argCount == 2)
                {
                    var material = _p0_UnityEngine_Material.Instance;
                    var _ret0 = _this.Instance.RegisterMaterial(material);
                    var _lret0 = global::Luny.UnityEngine.Rendering.LuaBatchMaterialID.Bind(_ret0);
                    var _retCount = _context.Return(_lret0);
                    return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                }
            }
            throw new global::Lua.LuaRuntimeException(_context.Thread, $"{"RegisterMaterial"}: invalid argument #{_lastArgPos}: {_lastArg} ({_lastArg.Type}), expected: {_expectedType.FullName}", 2);
        });
        private static readonly global::Lua.LuaFunction _LuaBatchRendererGroup_RegisterMesh = new global::Lua.LuaFunction("RegisterMesh", (_context, _) =>
        {
            global::Lua.LuaValue _lastArg = default;
            global::System.Int32 _lastArgPos = default;
            global::System.Type _expectedType = default;
            var _argCount = _context.ArgumentCount;
            var _this = _context.GetArgument<LuaBatchRendererGroup>(0);
            var _arg0 = _lastArg = _argCount > 1 ? _context.GetArgument(1) : global::Lua.LuaValue.Nil;
            _lastArgPos = 0; _expectedType = typeof(global::Luny.UnityEngine.LuaMesh);
            if (_arg0.TryRead<global::Luny.UnityEngine.LuaMesh>(out var _p0_UnityEngine_Mesh))
            {
                if (_argCount == 2)
                {
                    var mesh = _p0_UnityEngine_Mesh.Instance;
                    var _ret0 = _this.Instance.RegisterMesh(mesh);
                    var _lret0 = global::Luny.UnityEngine.Rendering.LuaBatchMeshID.Bind(_ret0);
                    var _retCount = _context.Return(_lret0);
                    return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                }
            }
            throw new global::Lua.LuaRuntimeException(_context.Thread, $"{"RegisterMesh"}: invalid argument #{_lastArgPos}: {_lastArg} ({_lastArg.Type}), expected: {_expectedType.FullName}", 2);
        });
        private static readonly global::Lua.LuaFunction _LuaBatchRendererGroup_RemoveBatch = new global::Lua.LuaFunction("RemoveBatch", (_context, _) =>
        {
            global::Lua.LuaValue _lastArg = default;
            global::System.Int32 _lastArgPos = default;
            global::System.Type _expectedType = default;
            var _argCount = _context.ArgumentCount;
            var _this = _context.GetArgument<LuaBatchRendererGroup>(0);
            var _arg0 = _lastArg = _argCount > 1 ? _context.GetArgument(1) : global::Lua.LuaValue.Nil;
            _lastArgPos = 0; _expectedType = typeof(global::Luny.UnityEngine.Rendering.LuaBatchID);
            if (_arg0.TryRead<global::Luny.UnityEngine.Rendering.LuaBatchID>(out var _p0_UnityEngine_Rendering_BatchID))
            {
                if (_argCount == 2)
                {
                    var batchID = _p0_UnityEngine_Rendering_BatchID.Value;
                    _this.Instance.RemoveBatch(batchID);
                    var _retCount = _context.Return();
                    return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                }
            }
            throw new global::Lua.LuaRuntimeException(_context.Thread, $"{"RemoveBatch"}: invalid argument #{_lastArgPos}: {_lastArg} ({_lastArg.Type}), expected: {_expectedType.FullName}", 2);
        });
        private static readonly global::Lua.LuaFunction _LuaBatchRendererGroup_SetBatchBuffer = new global::Lua.LuaFunction("SetBatchBuffer", (_context, _) =>
        {
            global::Lua.LuaValue _lastArg = default;
            global::System.Int32 _lastArgPos = default;
            global::System.Type _expectedType = default;
            var _argCount = _context.ArgumentCount;
            var _this = _context.GetArgument<LuaBatchRendererGroup>(0);
            var _arg0 = _lastArg = _argCount > 1 ? _context.GetArgument(1) : global::Lua.LuaValue.Nil;
            _lastArgPos = 0; _expectedType = typeof(global::Luny.UnityEngine.Rendering.LuaBatchID);
            if (_arg0.TryRead<global::Luny.UnityEngine.Rendering.LuaBatchID>(out var _p0_UnityEngine_Rendering_BatchID))
            {
                var _arg1 = _lastArg = _argCount > 2 ? _context.GetArgument(2) : global::Lua.LuaValue.Nil;
                _lastArgPos = 1; _expectedType = typeof(global::Luny.UnityEngine.LuaGraphicsBufferHandle);
                if (_arg1.TryRead<global::Luny.UnityEngine.LuaGraphicsBufferHandle>(out var _p1_UnityEngine_GraphicsBufferHandle))
                {
                    if (_argCount == 3)
                    {
                        var batchID = _p0_UnityEngine_Rendering_BatchID.Value;
                        var buffer = _p1_UnityEngine_GraphicsBufferHandle.Value;
                        _this.Instance.SetBatchBuffer(batchID, buffer);
                        var _retCount = _context.Return();
                        return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                    }
                }
            }
            throw new global::Lua.LuaRuntimeException(_context.Thread, $"{"SetBatchBuffer"}: invalid argument #{_lastArgPos}: {_lastArg} ({_lastArg.Type}), expected: {_expectedType.FullName}", 2);
        });
        private static readonly global::Lua.LuaFunction _LuaBatchRendererGroup_SetEnabledViewTypes = new global::Lua.LuaFunction("SetEnabledViewTypes", (_context, _) =>
        {
            global::Lua.LuaValue _lastArg = default;
            global::System.Int32 _lastArgPos = default;
            global::System.Type _expectedType = default;
            var _argCount = _context.ArgumentCount;
            var _this = _context.GetArgument<LuaBatchRendererGroup>(0);
            var _arg0 = _lastArg = _argCount > 1 ? _context.GetArgument(1) : global::Lua.LuaValue.Nil;
            _lastArgPos = 0; _expectedType = typeof(global::UnityEngine.Rendering.BatchCullingViewType[]);
            if (_arg0.TryReadArray<global::UnityEngine.Rendering.BatchCullingViewType>(out var _p0_UnityEngine_Rendering_BatchCullingViewTypeArray))
            {
                if (_argCount == 2)
                {
                    var viewTypes = _p0_UnityEngine_Rendering_BatchCullingViewTypeArray;
                    _this.Instance.SetEnabledViewTypes(viewTypes);
                    var _retCount = _context.Return();
                    return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                }
            }
            throw new global::Lua.LuaRuntimeException(_context.Thread, $"{"SetEnabledViewTypes"}: invalid argument #{_lastArgPos}: {_lastArg} ({_lastArg.Type}), expected: {_expectedType.FullName}", 2);
        });
        private static readonly global::Lua.LuaFunction _LuaBatchRendererGroup_SetErrorMaterial = new global::Lua.LuaFunction("SetErrorMaterial", (_context, _) =>
        {
            global::Lua.LuaValue _lastArg = default;
            global::System.Int32 _lastArgPos = default;
            global::System.Type _expectedType = default;
            var _argCount = _context.ArgumentCount;
            var _this = _context.GetArgument<LuaBatchRendererGroup>(0);
            var _arg0 = _lastArg = _argCount > 1 ? _context.GetArgument(1) : global::Lua.LuaValue.Nil;
            _lastArgPos = 0; _expectedType = typeof(global::Luny.UnityEngine.LuaMaterial);
            if (_arg0.TryRead<global::Luny.UnityEngine.LuaMaterial>(out var _p0_UnityEngine_Material))
            {
                if (_argCount == 2)
                {
                    var material = _p0_UnityEngine_Material.Instance;
                    _this.Instance.SetErrorMaterial(material);
                    var _retCount = _context.Return();
                    return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                }
            }
            throw new global::Lua.LuaRuntimeException(_context.Thread, $"{"SetErrorMaterial"}: invalid argument #{_lastArgPos}: {_lastArg} ({_lastArg.Type}), expected: {_expectedType.FullName}", 2);
        });
        private static readonly global::Lua.LuaFunction _LuaBatchRendererGroup_SetGlobalBounds = new global::Lua.LuaFunction("SetGlobalBounds", (_context, _) =>
        {
            global::Lua.LuaValue _lastArg = default;
            global::System.Int32 _lastArgPos = default;
            global::System.Type _expectedType = default;
            var _argCount = _context.ArgumentCount;
            var _this = _context.GetArgument<LuaBatchRendererGroup>(0);
            var _arg0 = _lastArg = _argCount > 1 ? _context.GetArgument(1) : global::Lua.LuaValue.Nil;
            _lastArgPos = 0; _expectedType = typeof(global::Luny.UnityEngine.LuaBounds);
            if (_arg0.TryRead<global::Luny.UnityEngine.LuaBounds>(out var _p0_UnityEngine_Bounds))
            {
                if (_argCount == 2)
                {
                    var bounds = _p0_UnityEngine_Bounds.Value;
                    _this.Instance.SetGlobalBounds(bounds);
                    var _retCount = _context.Return();
                    return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                }
            }
            throw new global::Lua.LuaRuntimeException(_context.Thread, $"{"SetGlobalBounds"}: invalid argument #{_lastArgPos}: {_lastArg} ({_lastArg.Type}), expected: {_expectedType.FullName}", 2);
        });
        private static readonly global::Lua.LuaFunction _LuaBatchRendererGroup_SetLoadingMaterial = new global::Lua.LuaFunction("SetLoadingMaterial", (_context, _) =>
        {
            global::Lua.LuaValue _lastArg = default;
            global::System.Int32 _lastArgPos = default;
            global::System.Type _expectedType = default;
            var _argCount = _context.ArgumentCount;
            var _this = _context.GetArgument<LuaBatchRendererGroup>(0);
            var _arg0 = _lastArg = _argCount > 1 ? _context.GetArgument(1) : global::Lua.LuaValue.Nil;
            _lastArgPos = 0; _expectedType = typeof(global::Luny.UnityEngine.LuaMaterial);
            if (_arg0.TryRead<global::Luny.UnityEngine.LuaMaterial>(out var _p0_UnityEngine_Material))
            {
                if (_argCount == 2)
                {
                    var material = _p0_UnityEngine_Material.Instance;
                    _this.Instance.SetLoadingMaterial(material);
                    var _retCount = _context.Return();
                    return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                }
            }
            throw new global::Lua.LuaRuntimeException(_context.Thread, $"{"SetLoadingMaterial"}: invalid argument #{_lastArgPos}: {_lastArg} ({_lastArg.Type}), expected: {_expectedType.FullName}", 2);
        });
        private static readonly global::Lua.LuaFunction _LuaBatchRendererGroup_SetPickingMaterial = new global::Lua.LuaFunction("SetPickingMaterial", (_context, _) =>
        {
            global::Lua.LuaValue _lastArg = default;
            global::System.Int32 _lastArgPos = default;
            global::System.Type _expectedType = default;
            var _argCount = _context.ArgumentCount;
            var _this = _context.GetArgument<LuaBatchRendererGroup>(0);
            var _arg0 = _lastArg = _argCount > 1 ? _context.GetArgument(1) : global::Lua.LuaValue.Nil;
            _lastArgPos = 0; _expectedType = typeof(global::Luny.UnityEngine.LuaMaterial);
            if (_arg0.TryRead<global::Luny.UnityEngine.LuaMaterial>(out var _p0_UnityEngine_Material))
            {
                if (_argCount == 2)
                {
                    var material = _p0_UnityEngine_Material.Instance;
                    _this.Instance.SetPickingMaterial(material);
                    var _retCount = _context.Return();
                    return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                }
            }
            throw new global::Lua.LuaRuntimeException(_context.Thread, $"{"SetPickingMaterial"}: invalid argument #{_lastArgPos}: {_lastArg} ({_lastArg.Type}), expected: {_expectedType.FullName}", 2);
        });
        private static readonly global::Lua.LuaFunction _LuaBatchRendererGroup_UnregisterMaterial = new global::Lua.LuaFunction("UnregisterMaterial", (_context, _) =>
        {
            global::Lua.LuaValue _lastArg = default;
            global::System.Int32 _lastArgPos = default;
            global::System.Type _expectedType = default;
            var _argCount = _context.ArgumentCount;
            var _this = _context.GetArgument<LuaBatchRendererGroup>(0);
            var _arg0 = _lastArg = _argCount > 1 ? _context.GetArgument(1) : global::Lua.LuaValue.Nil;
            _lastArgPos = 0; _expectedType = typeof(global::Luny.UnityEngine.Rendering.LuaBatchMaterialID);
            if (_arg0.TryRead<global::Luny.UnityEngine.Rendering.LuaBatchMaterialID>(out var _p0_UnityEngine_Rendering_BatchMaterialID))
            {
                if (_argCount == 2)
                {
                    var material = _p0_UnityEngine_Rendering_BatchMaterialID.Value;
                    _this.Instance.UnregisterMaterial(material);
                    var _retCount = _context.Return();
                    return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                }
            }
            throw new global::Lua.LuaRuntimeException(_context.Thread, $"{"UnregisterMaterial"}: invalid argument #{_lastArgPos}: {_lastArg} ({_lastArg.Type}), expected: {_expectedType.FullName}", 2);
        });
        private static readonly global::Lua.LuaFunction _LuaBatchRendererGroup_UnregisterMesh = new global::Lua.LuaFunction("UnregisterMesh", (_context, _) =>
        {
            global::Lua.LuaValue _lastArg = default;
            global::System.Int32 _lastArgPos = default;
            global::System.Type _expectedType = default;
            var _argCount = _context.ArgumentCount;
            var _this = _context.GetArgument<LuaBatchRendererGroup>(0);
            var _arg0 = _lastArg = _argCount > 1 ? _context.GetArgument(1) : global::Lua.LuaValue.Nil;
            _lastArgPos = 0; _expectedType = typeof(global::Luny.UnityEngine.Rendering.LuaBatchMeshID);
            if (_arg0.TryRead<global::Luny.UnityEngine.Rendering.LuaBatchMeshID>(out var _p0_UnityEngine_Rendering_BatchMeshID))
            {
                if (_argCount == 2)
                {
                    var mesh = _p0_UnityEngine_Rendering_BatchMeshID.Value;
                    _this.Instance.UnregisterMesh(mesh);
                    var _retCount = _context.Return();
                    return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                }
            }
            throw new global::Lua.LuaRuntimeException(_context.Thread, $"{"UnregisterMesh"}: invalid argument #{_lastArgPos}: {_lastArg} ({_lastArg.Type}), expected: {_expectedType.FullName}", 2);
        });
        private static readonly global::Lua.LuaFunction __index = new(global::Lua.Runtime.Metamethods.Index, (_context, _) =>
        {
            var _this = _context.GetArgument<LuaBatchRendererGroup>(0);
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
            var _this = _context.GetArgument<LuaBatchRendererGroup>(0);
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
                case "Dispose": _value = _LuaBatchRendererGroup_Dispose; return true;
                case "GetRegisteredMaterial": _value = _LuaBatchRendererGroup_GetRegisteredMaterial; return true;
                case "GetRegisteredMesh": _value = _LuaBatchRendererGroup_GetRegisteredMesh; return true;
                case "GetThreadedBatchContext": _value = _LuaBatchRendererGroup_GetThreadedBatchContext; return true;
                case "RegisterMaterial": _value = _LuaBatchRendererGroup_RegisterMaterial; return true;
                case "RegisterMesh": _value = _LuaBatchRendererGroup_RegisterMesh; return true;
                case "RemoveBatch": _value = _LuaBatchRendererGroup_RemoveBatch; return true;
                case "SetBatchBuffer": _value = _LuaBatchRendererGroup_SetBatchBuffer; return true;
                case "SetEnabledViewTypes": _value = _LuaBatchRendererGroup_SetEnabledViewTypes; return true;
                case "SetErrorMaterial": _value = _LuaBatchRendererGroup_SetErrorMaterial; return true;
                case "SetGlobalBounds": _value = _LuaBatchRendererGroup_SetGlobalBounds; return true;
                case "SetLoadingMaterial": _value = _LuaBatchRendererGroup_SetLoadingMaterial; return true;
                case "SetPickingMaterial": _value = _LuaBatchRendererGroup_SetPickingMaterial; return true;
                case "UnregisterMaterial": _value = _LuaBatchRendererGroup_UnregisterMaterial; return true;
                case "UnregisterMesh": _value = _LuaBatchRendererGroup_UnregisterMesh; return true;
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
    public sealed class LuaBatchRendererGroupType : global::Luny.ILuaStatic
    {
        public static global::Lua.LuaValue Bind() => new LuaBatchRendererGroupType();
        private LuaBatchRendererGroupType() {}
        public static implicit operator global::Lua.LuaValue(LuaBatchRendererGroupType value) => new(value);
        public global::System.Type BindType => typeof(global::UnityEngine.Rendering.BatchRendererGroup);
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
            metatable[global::Lua.Runtime.Metamethods.Call] = _LuaBatchRendererGroup_new;
            return metatable;
        }
        public override global::System.String ToString() => BindType.FullName;
#if UNITY_EDITOR
        [global::UnityEngine.RuntimeInitializeOnLoadMethod(global::UnityEngine.RuntimeInitializeLoadType.SubsystemRegistration)]
        private static void ResetStaticFields() => s_Metatable = null;
#endif

        private static readonly global::Lua.LuaFunction _LuaBatchRendererGroup_new = new global::Lua.LuaFunction(".ctor", (_context, _) =>
        {
            global::Lua.LuaValue _lastArg = default;
            global::System.Int32 _lastArgPos = default;
            global::System.Type _expectedType = default;
            var _argCount = _context.ArgumentCount;
            var _arg0 = _lastArg = _argCount > 1 ? _context.GetArgument(1) : global::Lua.LuaValue.Nil;
            _lastArgPos = 0; _expectedType = typeof(global::Luny.UnityEngine.Rendering.LuaBatchRendererGroupCreateInfo);
            if (_arg0.TryRead<global::Luny.UnityEngine.Rendering.LuaBatchRendererGroupCreateInfo>(out var _p0_UnityEngine_Rendering_BatchRendererGroupCreateInfo))
            {
                if (_argCount == 2)
                {
                    var info = _p0_UnityEngine_Rendering_BatchRendererGroupCreateInfo.Value;
                    var _ret0 = new global::UnityEngine.Rendering.BatchRendererGroup(info);
                    var _factory = _context.GetObjectFactory();
                    var _lret0 = _factory.Bind(_ret0);
                    var _retCount = _context.Return(_lret0);
                    return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                }
            }
            throw new global::Lua.LuaRuntimeException(_context.Thread, $"{".ctor"}: invalid argument #{_lastArgPos}: {_lastArg} ({_lastArg.Type}), expected: {_expectedType.FullName}", 2);
        });
        private static readonly global::Lua.LuaFunction _LuaBatchRendererGroup_GetConstantBufferMaxWindowSize = new global::Lua.LuaFunction("GetConstantBufferMaxWindowSize", (_context, _) =>
        {
            global::Lua.LuaValue _lastArg = default;
            global::System.Int32 _lastArgPos = default;
            global::System.Type _expectedType = default;
            var _argCount = _context.ArgumentCount;
            if (_argCount == 0)
            {
                var _ret0 = global::UnityEngine.Rendering.BatchRendererGroup.GetConstantBufferMaxWindowSize();
                var _lret0 = new global::Lua.LuaValue(_ret0);
                var _retCount = _context.Return(_lret0);
                return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
            }
            throw new global::Lua.LuaRuntimeException(_context.Thread, $"{"GetConstantBufferMaxWindowSize"}: invalid argument #{_lastArgPos}: {_lastArg} ({_lastArg.Type}), expected: {_expectedType.FullName}", 2);
        });
        private static readonly global::Lua.LuaFunction _LuaBatchRendererGroup_GetConstantBufferOffsetAlignment = new global::Lua.LuaFunction("GetConstantBufferOffsetAlignment", (_context, _) =>
        {
            global::Lua.LuaValue _lastArg = default;
            global::System.Int32 _lastArgPos = default;
            global::System.Type _expectedType = default;
            var _argCount = _context.ArgumentCount;
            if (_argCount == 0)
            {
                var _ret0 = global::UnityEngine.Rendering.BatchRendererGroup.GetConstantBufferOffsetAlignment();
                var _lret0 = new global::Lua.LuaValue(_ret0);
                var _retCount = _context.Return(_lret0);
                return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
            }
            throw new global::Lua.LuaRuntimeException(_context.Thread, $"{"GetConstantBufferOffsetAlignment"}: invalid argument #{_lastArgPos}: {_lastArg} ({_lastArg.Type}), expected: {_expectedType.FullName}", 2);
        });
        private static readonly global::Lua.LuaFunction __index = new(global::Lua.Runtime.Metamethods.Index, (_context, _) =>
        {
            var _this = _context.GetArgument<LuaBatchRendererGroupType>(0);
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
            var _this = _context.GetArgument<LuaBatchRendererGroupType>(0);
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
                case "GetConstantBufferMaxWindowSize": _value = _LuaBatchRendererGroup_GetConstantBufferMaxWindowSize; return true;
                case "GetConstantBufferOffsetAlignment": _value = _LuaBatchRendererGroup_GetConstantBufferOffsetAlignment; return true;
                case "BufferTarget": _value = new global::Lua.LuaValue((global::System.Int64)global::UnityEngine.Rendering.BatchRendererGroup.BufferTarget); return true;
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
