
// --------------------------------------------------------------
// GENERATED FILE ----> DO NOT EDIT <---- CHANGES WILL BE LOST !!
// --------------------------------------------------------------

#if UNITY_6000_0_OR_NEWER && !(UNITY_6000_1_OR_NEWER)
#pragma warning disable 0109, 0162, 0168, 0219
using Luny;

namespace Luny.UnityEditor.Profiling
{
    public sealed class LuaHierarchyFrameDataView : LuaFrameDataView, global::Luny.ILuaObject<global::UnityEditor.Profiling.HierarchyFrameDataView>
    {
        public new static global::Lua.LuaValue Bind(global::UnityEditor.Profiling.HierarchyFrameDataView instance) => new LuaHierarchyFrameDataView(instance);
        public new static global::Lua.LuaValue Bind(global::System.Object instance) => Bind((global::UnityEditor.Profiling.HierarchyFrameDataView)instance);
        public new static global::Lua.LuaValue Bind(global::System.Collections.Generic.IList<global::UnityEditor.Profiling.HierarchyFrameDataView> instances) =>
            new global::Luny.LuaList<global::UnityEditor.Profiling.HierarchyFrameDataView>(instances);
        public new static global::Lua.LuaValue Bind(global::System.Collections.Generic.IList<global::System.Object> instances) =>
            new global::Luny.LuaList<global::UnityEditor.Profiling.HierarchyFrameDataView>(instances);
        private LuaHierarchyFrameDataView(global::UnityEditor.Profiling.HierarchyFrameDataView instance) : base(instance) {}
        public static implicit operator global::Lua.LuaValue(LuaHierarchyFrameDataView value) => new(value);
        public new global::UnityEditor.Profiling.HierarchyFrameDataView Instance => (global::UnityEditor.Profiling.HierarchyFrameDataView)m_Instance;
        public new global::System.Type BindType => typeof(global::UnityEditor.Profiling.HierarchyFrameDataView);
        private static global::Lua.LuaTable s_Metatable;
        public new global::Lua.LuaTable Metatable
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
        public override global::System.String ToString() => m_Instance != null ? Instance.ToString() : "{GetType().Name}(null)";
#if UNITY_EDITOR
        [global::UnityEngine.RuntimeInitializeOnLoadMethod(global::UnityEngine.RuntimeInitializeLoadType.SubsystemRegistration)]
        private static void ResetStaticFields() => s_Metatable = null;
#endif

        private static readonly global::Lua.LuaFunction _LuaHierarchyFrameDataView_Equals = new global::Lua.LuaFunction("Equals", (_context, _) =>
        {
            global::Lua.LuaValue _lastArg = default;
            global::System.Int32 _lastArgPos = default;
            global::System.Type _expectedType = default;
            var _argCount = _context.ArgumentCount;
            var _this = _context.GetArgument<LuaHierarchyFrameDataView>(0);
            var _arg0 = _lastArg = _argCount > 1 ? _context.GetArgument(1) : global::Lua.LuaValue.Nil;
            _lastArgPos = 0; _expectedType = typeof(global::System.Object);
            if (_arg0.TryRead<global::System.Object>(out var _p0_System_Object))
            {
                if (_argCount == 2)
                {
                    var obj = _p0_System_Object;
                    var _ret0 = _this.Instance.Equals(obj);
                    var _lret0 = new global::Lua.LuaValue(_ret0);
                    var _retCount = _context.Return(_lret0);
                    return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                }
            }
            throw new global::Lua.LuaRuntimeException(_context.Thread, $"{"Equals"}: invalid argument #{_lastArgPos}: {_lastArg} ({_lastArg.Type}), expected: {_expectedType.FullName}", 2);
        });
        private static readonly global::Lua.LuaFunction _LuaHierarchyFrameDataView_GetHashCode = new global::Lua.LuaFunction("GetHashCode", (_context, _) =>
        {
            global::Lua.LuaValue _lastArg = default;
            global::System.Int32 _lastArgPos = default;
            global::System.Type _expectedType = default;
            var _argCount = _context.ArgumentCount;
            var _this = _context.GetArgument<LuaHierarchyFrameDataView>(0);
            if (_argCount == 1)
            {
                var _ret0 = _this.Instance.GetHashCode();
                var _lret0 = new global::Lua.LuaValue(_ret0);
                var _retCount = _context.Return(_lret0);
                return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
            }
            throw new global::Lua.LuaRuntimeException(_context.Thread, $"{"GetHashCode"}: invalid argument #{_lastArgPos}: {_lastArg} ({_lastArg.Type}), expected: {_expectedType.FullName}", 2);
        });
        private static readonly global::Lua.LuaFunction _LuaHierarchyFrameDataView_GetItemCategoryIndex = new global::Lua.LuaFunction("GetItemCategoryIndex", (_context, _) =>
        {
            global::Lua.LuaValue _lastArg = default;
            global::System.Int32 _lastArgPos = default;
            global::System.Type _expectedType = default;
            var _argCount = _context.ArgumentCount;
            var _this = _context.GetArgument<LuaHierarchyFrameDataView>(0);
            var _arg0 = _lastArg = _argCount > 1 ? _context.GetArgument(1) : global::Lua.LuaValue.Nil;
            _lastArgPos = 0; _expectedType = typeof(global::System.Int32);
            if (_arg0.TryRead<global::System.Int32>(out var _p0_System_Int32))
            {
                if (_argCount == 2)
                {
                    var id = _p0_System_Int32;
                    var _ret0 = _this.Instance.GetItemCategoryIndex(id);
                    var _lret0 = new global::Lua.LuaValue(_ret0);
                    var _retCount = _context.Return(_lret0);
                    return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                }
            }
            throw new global::Lua.LuaRuntimeException(_context.Thread, $"{"GetItemCategoryIndex"}: invalid argument #{_lastArgPos}: {_lastArg} ({_lastArg.Type}), expected: {_expectedType.FullName}", 2);
        });
        private static readonly global::Lua.LuaFunction _LuaHierarchyFrameDataView_GetItemColumnData = new global::Lua.LuaFunction("GetItemColumnData", (_context, _) =>
        {
            global::Lua.LuaValue _lastArg = default;
            global::System.Int32 _lastArgPos = default;
            global::System.Type _expectedType = default;
            var _argCount = _context.ArgumentCount;
            var _this = _context.GetArgument<LuaHierarchyFrameDataView>(0);
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
                        var id = _p0_System_Int32;
                        var column = _p1_System_Int32;
                        var _ret0 = _this.Instance.GetItemColumnData(id, column);
                        var _lret0 = new global::Lua.LuaValue(_ret0);
                        var _retCount = _context.Return(_lret0);
                        return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                    }
                }
            }
            throw new global::Lua.LuaRuntimeException(_context.Thread, $"{"GetItemColumnData"}: invalid argument #{_lastArgPos}: {_lastArg} ({_lastArg.Type}), expected: {_expectedType.FullName}", 2);
        });
        private static readonly global::Lua.LuaFunction _LuaHierarchyFrameDataView_GetItemColumnDataAsDouble = new global::Lua.LuaFunction("GetItemColumnDataAsDouble", (_context, _) =>
        {
            global::Lua.LuaValue _lastArg = default;
            global::System.Int32 _lastArgPos = default;
            global::System.Type _expectedType = default;
            var _argCount = _context.ArgumentCount;
            var _this = _context.GetArgument<LuaHierarchyFrameDataView>(0);
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
                        var id = _p0_System_Int32;
                        var column = _p1_System_Int32;
                        var _ret0 = _this.Instance.GetItemColumnDataAsDouble(id, column);
                        var _lret0 = new global::Lua.LuaValue(_ret0);
                        var _retCount = _context.Return(_lret0);
                        return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                    }
                }
            }
            throw new global::Lua.LuaRuntimeException(_context.Thread, $"{"GetItemColumnDataAsDouble"}: invalid argument #{_lastArgPos}: {_lastArg} ({_lastArg.Type}), expected: {_expectedType.FullName}", 2);
        });
        private static readonly global::Lua.LuaFunction _LuaHierarchyFrameDataView_GetItemColumnDataAsFloat = new global::Lua.LuaFunction("GetItemColumnDataAsFloat", (_context, _) =>
        {
            global::Lua.LuaValue _lastArg = default;
            global::System.Int32 _lastArgPos = default;
            global::System.Type _expectedType = default;
            var _argCount = _context.ArgumentCount;
            var _this = _context.GetArgument<LuaHierarchyFrameDataView>(0);
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
                        var id = _p0_System_Int32;
                        var column = _p1_System_Int32;
                        var _ret0 = _this.Instance.GetItemColumnDataAsFloat(id, column);
                        var _lret0 = new global::Lua.LuaValue(_ret0);
                        var _retCount = _context.Return(_lret0);
                        return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                    }
                }
            }
            throw new global::Lua.LuaRuntimeException(_context.Thread, $"{"GetItemColumnDataAsFloat"}: invalid argument #{_lastArgPos}: {_lastArg} ({_lastArg.Type}), expected: {_expectedType.FullName}", 2);
        });
        private static readonly global::Lua.LuaFunction _LuaHierarchyFrameDataView_GetItemColumnDataAsSingle = new global::Lua.LuaFunction("GetItemColumnDataAsSingle", (_context, _) =>
        {
            global::Lua.LuaValue _lastArg = default;
            global::System.Int32 _lastArgPos = default;
            global::System.Type _expectedType = default;
            var _argCount = _context.ArgumentCount;
            var _this = _context.GetArgument<LuaHierarchyFrameDataView>(0);
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
                        var id = _p0_System_Int32;
                        var column = _p1_System_Int32;
                        var _ret0 = _this.Instance.GetItemColumnDataAsSingle(id, column);
                        var _lret0 = new global::Lua.LuaValue(_ret0);
                        var _retCount = _context.Return(_lret0);
                        return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                    }
                }
            }
            throw new global::Lua.LuaRuntimeException(_context.Thread, $"{"GetItemColumnDataAsSingle"}: invalid argument #{_lastArgPos}: {_lastArg} ({_lastArg.Type}), expected: {_expectedType.FullName}", 2);
        });
        private static readonly global::Lua.LuaFunction _LuaHierarchyFrameDataView_GetItemDepth = new global::Lua.LuaFunction("GetItemDepth", (_context, _) =>
        {
            global::Lua.LuaValue _lastArg = default;
            global::System.Int32 _lastArgPos = default;
            global::System.Type _expectedType = default;
            var _argCount = _context.ArgumentCount;
            var _this = _context.GetArgument<LuaHierarchyFrameDataView>(0);
            var _arg0 = _lastArg = _argCount > 1 ? _context.GetArgument(1) : global::Lua.LuaValue.Nil;
            _lastArgPos = 0; _expectedType = typeof(global::System.Int32);
            if (_arg0.TryRead<global::System.Int32>(out var _p0_System_Int32))
            {
                if (_argCount == 2)
                {
                    var id = _p0_System_Int32;
                    var _ret0 = _this.Instance.GetItemDepth(id);
                    var _lret0 = new global::Lua.LuaValue(_ret0);
                    var _retCount = _context.Return(_lret0);
                    return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                }
            }
            throw new global::Lua.LuaRuntimeException(_context.Thread, $"{"GetItemDepth"}: invalid argument #{_lastArgPos}: {_lastArg} ({_lastArg.Type}), expected: {_expectedType.FullName}", 2);
        });
        private static readonly global::Lua.LuaFunction _LuaHierarchyFrameDataView_GetItemInstanceID = new global::Lua.LuaFunction("GetItemInstanceID", (_context, _) =>
        {
            global::Lua.LuaValue _lastArg = default;
            global::System.Int32 _lastArgPos = default;
            global::System.Type _expectedType = default;
            var _argCount = _context.ArgumentCount;
            var _this = _context.GetArgument<LuaHierarchyFrameDataView>(0);
            var _arg0 = _lastArg = _argCount > 1 ? _context.GetArgument(1) : global::Lua.LuaValue.Nil;
            _lastArgPos = 0; _expectedType = typeof(global::System.Int32);
            if (_arg0.TryRead<global::System.Int32>(out var _p0_System_Int32))
            {
                if (_argCount == 2)
                {
                    var id = _p0_System_Int32;
                    var _ret0 = _this.Instance.GetItemInstanceID(id);
                    var _lret0 = new global::Lua.LuaValue(_ret0);
                    var _retCount = _context.Return(_lret0);
                    return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                }
            }
            throw new global::Lua.LuaRuntimeException(_context.Thread, $"{"GetItemInstanceID"}: invalid argument #{_lastArgPos}: {_lastArg} ({_lastArg.Type}), expected: {_expectedType.FullName}", 2);
        });
        private static readonly global::Lua.LuaFunction _LuaHierarchyFrameDataView_GetItemMarkerFlags = new global::Lua.LuaFunction("GetItemMarkerFlags", (_context, _) =>
        {
            global::Lua.LuaValue _lastArg = default;
            global::System.Int32 _lastArgPos = default;
            global::System.Type _expectedType = default;
            var _argCount = _context.ArgumentCount;
            var _this = _context.GetArgument<LuaHierarchyFrameDataView>(0);
            var _arg0 = _lastArg = _argCount > 1 ? _context.GetArgument(1) : global::Lua.LuaValue.Nil;
            _lastArgPos = 0; _expectedType = typeof(global::System.Int32);
            if (_arg0.TryRead<global::System.Int32>(out var _p0_System_Int32))
            {
                if (_argCount == 2)
                {
                    var id = _p0_System_Int32;
                    var _ret0 = _this.Instance.GetItemMarkerFlags(id);
                    var _lret0 = new global::Lua.LuaValue((global::System.Int64)_ret0);
                    var _retCount = _context.Return(_lret0);
                    return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                }
            }
            throw new global::Lua.LuaRuntimeException(_context.Thread, $"{"GetItemMarkerFlags"}: invalid argument #{_lastArgPos}: {_lastArg} ({_lastArg.Type}), expected: {_expectedType.FullName}", 2);
        });
        private static readonly global::Lua.LuaFunction _LuaHierarchyFrameDataView_GetItemMarkerID = new global::Lua.LuaFunction("GetItemMarkerID", (_context, _) =>
        {
            global::Lua.LuaValue _lastArg = default;
            global::System.Int32 _lastArgPos = default;
            global::System.Type _expectedType = default;
            var _argCount = _context.ArgumentCount;
            var _this = _context.GetArgument<LuaHierarchyFrameDataView>(0);
            var _arg0 = _lastArg = _argCount > 1 ? _context.GetArgument(1) : global::Lua.LuaValue.Nil;
            _lastArgPos = 0; _expectedType = typeof(global::System.Int32);
            if (_arg0.TryRead<global::System.Int32>(out var _p0_System_Int32))
            {
                if (_argCount == 2)
                {
                    var id = _p0_System_Int32;
                    var _ret0 = _this.Instance.GetItemMarkerID(id);
                    var _lret0 = new global::Lua.LuaValue(_ret0);
                    var _retCount = _context.Return(_lret0);
                    return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                }
            }
            throw new global::Lua.LuaRuntimeException(_context.Thread, $"{"GetItemMarkerID"}: invalid argument #{_lastArgPos}: {_lastArg} ({_lastArg.Type}), expected: {_expectedType.FullName}", 2);
        });
        private static readonly global::Lua.LuaFunction _LuaHierarchyFrameDataView_GetItemMergedSamplesCount = new global::Lua.LuaFunction("GetItemMergedSamplesCount", (_context, _) =>
        {
            global::Lua.LuaValue _lastArg = default;
            global::System.Int32 _lastArgPos = default;
            global::System.Type _expectedType = default;
            var _argCount = _context.ArgumentCount;
            var _this = _context.GetArgument<LuaHierarchyFrameDataView>(0);
            var _arg0 = _lastArg = _argCount > 1 ? _context.GetArgument(1) : global::Lua.LuaValue.Nil;
            _lastArgPos = 0; _expectedType = typeof(global::System.Int32);
            if (_arg0.TryRead<global::System.Int32>(out var _p0_System_Int32))
            {
                if (_argCount == 2)
                {
                    var id = _p0_System_Int32;
                    var _ret0 = _this.Instance.GetItemMergedSamplesCount(id);
                    var _lret0 = new global::Lua.LuaValue(_ret0);
                    var _retCount = _context.Return(_lret0);
                    return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                }
            }
            throw new global::Lua.LuaRuntimeException(_context.Thread, $"{"GetItemMergedSamplesCount"}: invalid argument #{_lastArgPos}: {_lastArg} ({_lastArg.Type}), expected: {_expectedType.FullName}", 2);
        });
        private static readonly global::Lua.LuaFunction _LuaHierarchyFrameDataView_GetItemMergedSamplesMetadata = new global::Lua.LuaFunction("GetItemMergedSamplesMetadata", (_context, _) =>
        {
            global::Lua.LuaValue _lastArg = default;
            global::System.Int32 _lastArgPos = default;
            global::System.Type _expectedType = default;
            var _argCount = _context.ArgumentCount;
            var _this = _context.GetArgument<LuaHierarchyFrameDataView>(0);
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
                        if (_argCount == 4)
                        {
                            var id = _p0_System_Int32;
                            var sampleIndex = _p1_System_Int32;
                            var metadataIndex = _p2_System_Int32;
                            var _ret0 = _this.Instance.GetItemMergedSamplesMetadata(id, sampleIndex, metadataIndex);
                            var _lret0 = new global::Lua.LuaValue(_ret0);
                            var _retCount = _context.Return(_lret0);
                            return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                        }
                    }
                }
            }
            throw new global::Lua.LuaRuntimeException(_context.Thread, $"{"GetItemMergedSamplesMetadata"}: invalid argument #{_lastArgPos}: {_lastArg} ({_lastArg.Type}), expected: {_expectedType.FullName}", 2);
        });
        private static readonly global::Lua.LuaFunction _LuaHierarchyFrameDataView_GetItemMergedSamplesMetadataAsFloat = new global::Lua.LuaFunction("GetItemMergedSamplesMetadataAsFloat", (_context, _) =>
        {
            global::Lua.LuaValue _lastArg = default;
            global::System.Int32 _lastArgPos = default;
            global::System.Type _expectedType = default;
            var _argCount = _context.ArgumentCount;
            var _this = _context.GetArgument<LuaHierarchyFrameDataView>(0);
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
                        if (_argCount == 4)
                        {
                            var id = _p0_System_Int32;
                            var sampleIndex = _p1_System_Int32;
                            var metadataIndex = _p2_System_Int32;
                            var _ret0 = _this.Instance.GetItemMergedSamplesMetadataAsFloat(id, sampleIndex, metadataIndex);
                            var _lret0 = new global::Lua.LuaValue(_ret0);
                            var _retCount = _context.Return(_lret0);
                            return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                        }
                    }
                }
            }
            throw new global::Lua.LuaRuntimeException(_context.Thread, $"{"GetItemMergedSamplesMetadataAsFloat"}: invalid argument #{_lastArgPos}: {_lastArg} ({_lastArg.Type}), expected: {_expectedType.FullName}", 2);
        });
        private static readonly global::Lua.LuaFunction _LuaHierarchyFrameDataView_GetItemMergedSamplesMetadataAsLong = new global::Lua.LuaFunction("GetItemMergedSamplesMetadataAsLong", (_context, _) =>
        {
            global::Lua.LuaValue _lastArg = default;
            global::System.Int32 _lastArgPos = default;
            global::System.Type _expectedType = default;
            var _argCount = _context.ArgumentCount;
            var _this = _context.GetArgument<LuaHierarchyFrameDataView>(0);
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
                        if (_argCount == 4)
                        {
                            var id = _p0_System_Int32;
                            var sampleIndex = _p1_System_Int32;
                            var metadataIndex = _p2_System_Int32;
                            var _ret0 = _this.Instance.GetItemMergedSamplesMetadataAsLong(id, sampleIndex, metadataIndex);
                            var _lret0 = new global::Lua.LuaValue(_ret0);
                            var _retCount = _context.Return(_lret0);
                            return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                        }
                    }
                }
            }
            throw new global::Lua.LuaRuntimeException(_context.Thread, $"{"GetItemMergedSamplesMetadataAsLong"}: invalid argument #{_lastArgPos}: {_lastArg} ({_lastArg.Type}), expected: {_expectedType.FullName}", 2);
        });
        private static readonly global::Lua.LuaFunction _LuaHierarchyFrameDataView_GetItemMergedSamplesMetadataCount = new global::Lua.LuaFunction("GetItemMergedSamplesMetadataCount", (_context, _) =>
        {
            global::Lua.LuaValue _lastArg = default;
            global::System.Int32 _lastArgPos = default;
            global::System.Type _expectedType = default;
            var _argCount = _context.ArgumentCount;
            var _this = _context.GetArgument<LuaHierarchyFrameDataView>(0);
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
                        var id = _p0_System_Int32;
                        var sampleIndex = _p1_System_Int32;
                        var _ret0 = _this.Instance.GetItemMergedSamplesMetadataCount(id, sampleIndex);
                        var _lret0 = new global::Lua.LuaValue(_ret0);
                        var _retCount = _context.Return(_lret0);
                        return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                    }
                }
            }
            throw new global::Lua.LuaRuntimeException(_context.Thread, $"{"GetItemMergedSamplesMetadataCount"}: invalid argument #{_lastArgPos}: {_lastArg} ({_lastArg.Type}), expected: {_expectedType.FullName}", 2);
        });
        private static readonly global::Lua.LuaFunction _LuaHierarchyFrameDataView_GetItemMetadata = new global::Lua.LuaFunction("GetItemMetadata", (_context, _) =>
        {
            global::Lua.LuaValue _lastArg = default;
            global::System.Int32 _lastArgPos = default;
            global::System.Type _expectedType = default;
            var _argCount = _context.ArgumentCount;
            var _this = _context.GetArgument<LuaHierarchyFrameDataView>(0);
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
                        var id = _p0_System_Int32;
                        var index = _p1_System_Int32;
                        var _ret0 = _this.Instance.GetItemMetadata(id, index);
                        var _lret0 = new global::Lua.LuaValue(_ret0);
                        var _retCount = _context.Return(_lret0);
                        return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                    }
                }
            }
            throw new global::Lua.LuaRuntimeException(_context.Thread, $"{"GetItemMetadata"}: invalid argument #{_lastArgPos}: {_lastArg} ({_lastArg.Type}), expected: {_expectedType.FullName}", 2);
        });
        private static readonly global::Lua.LuaFunction _LuaHierarchyFrameDataView_GetItemMetadataAsFloat = new global::Lua.LuaFunction("GetItemMetadataAsFloat", (_context, _) =>
        {
            global::Lua.LuaValue _lastArg = default;
            global::System.Int32 _lastArgPos = default;
            global::System.Type _expectedType = default;
            var _argCount = _context.ArgumentCount;
            var _this = _context.GetArgument<LuaHierarchyFrameDataView>(0);
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
                        var id = _p0_System_Int32;
                        var index = _p1_System_Int32;
                        var _ret0 = _this.Instance.GetItemMetadataAsFloat(id, index);
                        var _lret0 = new global::Lua.LuaValue(_ret0);
                        var _retCount = _context.Return(_lret0);
                        return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                    }
                }
            }
            throw new global::Lua.LuaRuntimeException(_context.Thread, $"{"GetItemMetadataAsFloat"}: invalid argument #{_lastArgPos}: {_lastArg} ({_lastArg.Type}), expected: {_expectedType.FullName}", 2);
        });
        private static readonly global::Lua.LuaFunction _LuaHierarchyFrameDataView_GetItemMetadataAsLong = new global::Lua.LuaFunction("GetItemMetadataAsLong", (_context, _) =>
        {
            global::Lua.LuaValue _lastArg = default;
            global::System.Int32 _lastArgPos = default;
            global::System.Type _expectedType = default;
            var _argCount = _context.ArgumentCount;
            var _this = _context.GetArgument<LuaHierarchyFrameDataView>(0);
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
                        var id = _p0_System_Int32;
                        var index = _p1_System_Int32;
                        var _ret0 = _this.Instance.GetItemMetadataAsLong(id, index);
                        var _lret0 = new global::Lua.LuaValue(_ret0);
                        var _retCount = _context.Return(_lret0);
                        return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                    }
                }
            }
            throw new global::Lua.LuaRuntimeException(_context.Thread, $"{"GetItemMetadataAsLong"}: invalid argument #{_lastArgPos}: {_lastArg} ({_lastArg.Type}), expected: {_expectedType.FullName}", 2);
        });
        private static readonly global::Lua.LuaFunction _LuaHierarchyFrameDataView_GetItemMetadataCount = new global::Lua.LuaFunction("GetItemMetadataCount", (_context, _) =>
        {
            global::Lua.LuaValue _lastArg = default;
            global::System.Int32 _lastArgPos = default;
            global::System.Type _expectedType = default;
            var _argCount = _context.ArgumentCount;
            var _this = _context.GetArgument<LuaHierarchyFrameDataView>(0);
            var _arg0 = _lastArg = _argCount > 1 ? _context.GetArgument(1) : global::Lua.LuaValue.Nil;
            _lastArgPos = 0; _expectedType = typeof(global::System.Int32);
            if (_arg0.TryRead<global::System.Int32>(out var _p0_System_Int32))
            {
                if (_argCount == 2)
                {
                    var id = _p0_System_Int32;
                    var _ret0 = _this.Instance.GetItemMetadataCount(id);
                    var _lret0 = new global::Lua.LuaValue(_ret0);
                    var _retCount = _context.Return(_lret0);
                    return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                }
            }
            throw new global::Lua.LuaRuntimeException(_context.Thread, $"{"GetItemMetadataCount"}: invalid argument #{_lastArgPos}: {_lastArg} ({_lastArg.Type}), expected: {_expectedType.FullName}", 2);
        });
        private static readonly global::Lua.LuaFunction _LuaHierarchyFrameDataView_GetItemName = new global::Lua.LuaFunction("GetItemName", (_context, _) =>
        {
            global::Lua.LuaValue _lastArg = default;
            global::System.Int32 _lastArgPos = default;
            global::System.Type _expectedType = default;
            var _argCount = _context.ArgumentCount;
            var _this = _context.GetArgument<LuaHierarchyFrameDataView>(0);
            var _arg0 = _lastArg = _argCount > 1 ? _context.GetArgument(1) : global::Lua.LuaValue.Nil;
            _lastArgPos = 0; _expectedType = typeof(global::System.Int32);
            if (_arg0.TryRead<global::System.Int32>(out var _p0_System_Int32))
            {
                if (_argCount == 2)
                {
                    var id = _p0_System_Int32;
                    var _ret0 = _this.Instance.GetItemName(id);
                    var _lret0 = new global::Lua.LuaValue(_ret0);
                    var _retCount = _context.Return(_lret0);
                    return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                }
            }
            throw new global::Lua.LuaRuntimeException(_context.Thread, $"{"GetItemName"}: invalid argument #{_lastArgPos}: {_lastArg} ({_lastArg.Type}), expected: {_expectedType.FullName}", 2);
        });
        private static readonly global::Lua.LuaFunction _LuaHierarchyFrameDataView_GetItemPath = new global::Lua.LuaFunction("GetItemPath", (_context, _) =>
        {
            global::Lua.LuaValue _lastArg = default;
            global::System.Int32 _lastArgPos = default;
            global::System.Type _expectedType = default;
            var _argCount = _context.ArgumentCount;
            var _this = _context.GetArgument<LuaHierarchyFrameDataView>(0);
            var _arg0 = _lastArg = _argCount > 1 ? _context.GetArgument(1) : global::Lua.LuaValue.Nil;
            _lastArgPos = 0; _expectedType = typeof(global::System.Int32);
            if (_arg0.TryRead<global::System.Int32>(out var _p0_System_Int32))
            {
                if (_argCount == 2)
                {
                    var id = _p0_System_Int32;
                    var _ret0 = _this.Instance.GetItemPath(id);
                    var _lret0 = new global::Lua.LuaValue(_ret0);
                    var _retCount = _context.Return(_lret0);
                    return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                }
            }
            throw new global::Lua.LuaRuntimeException(_context.Thread, $"{"GetItemPath"}: invalid argument #{_lastArgPos}: {_lastArg} ({_lastArg.Type}), expected: {_expectedType.FullName}", 2);
        });
        private static readonly global::Lua.LuaFunction _LuaHierarchyFrameDataView_GetRootItemID = new global::Lua.LuaFunction("GetRootItemID", (_context, _) =>
        {
            global::Lua.LuaValue _lastArg = default;
            global::System.Int32 _lastArgPos = default;
            global::System.Type _expectedType = default;
            var _argCount = _context.ArgumentCount;
            var _this = _context.GetArgument<LuaHierarchyFrameDataView>(0);
            if (_argCount == 1)
            {
                var _ret0 = _this.Instance.GetRootItemID();
                var _lret0 = new global::Lua.LuaValue(_ret0);
                var _retCount = _context.Return(_lret0);
                return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
            }
            throw new global::Lua.LuaRuntimeException(_context.Thread, $"{"GetRootItemID"}: invalid argument #{_lastArgPos}: {_lastArg} ({_lastArg.Type}), expected: {_expectedType.FullName}", 2);
        });
        private static readonly global::Lua.LuaFunction _LuaHierarchyFrameDataView_HasItemChildren = new global::Lua.LuaFunction("HasItemChildren", (_context, _) =>
        {
            global::Lua.LuaValue _lastArg = default;
            global::System.Int32 _lastArgPos = default;
            global::System.Type _expectedType = default;
            var _argCount = _context.ArgumentCount;
            var _this = _context.GetArgument<LuaHierarchyFrameDataView>(0);
            var _arg0 = _lastArg = _argCount > 1 ? _context.GetArgument(1) : global::Lua.LuaValue.Nil;
            _lastArgPos = 0; _expectedType = typeof(global::System.Int32);
            if (_arg0.TryRead<global::System.Int32>(out var _p0_System_Int32))
            {
                if (_argCount == 2)
                {
                    var id = _p0_System_Int32;
                    var _ret0 = _this.Instance.HasItemChildren(id);
                    var _lret0 = new global::Lua.LuaValue(_ret0);
                    var _retCount = _context.Return(_lret0);
                    return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                }
            }
            throw new global::Lua.LuaRuntimeException(_context.Thread, $"{"HasItemChildren"}: invalid argument #{_lastArgPos}: {_lastArg} ({_lastArg.Type}), expected: {_expectedType.FullName}", 2);
        });
        private static readonly global::Lua.LuaFunction _LuaHierarchyFrameDataView_ItemContainsRawFrameDataViewIndex = new global::Lua.LuaFunction("ItemContainsRawFrameDataViewIndex", (_context, _) =>
        {
            global::Lua.LuaValue _lastArg = default;
            global::System.Int32 _lastArgPos = default;
            global::System.Type _expectedType = default;
            var _argCount = _context.ArgumentCount;
            var _this = _context.GetArgument<LuaHierarchyFrameDataView>(0);
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
                        var id = _p0_System_Int32;
                        var sampleIndex = _p1_System_Int32;
                        var _ret0 = _this.Instance.ItemContainsRawFrameDataViewIndex(id, sampleIndex);
                        var _lret0 = new global::Lua.LuaValue(_ret0);
                        var _retCount = _context.Return(_lret0);
                        return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                    }
                }
            }
            throw new global::Lua.LuaRuntimeException(_context.Thread, $"{"ItemContainsRawFrameDataViewIndex"}: invalid argument #{_lastArgPos}: {_lastArg} ({_lastArg.Type}), expected: {_expectedType.FullName}", 2);
        });
        private static readonly global::Lua.LuaFunction _LuaHierarchyFrameDataView_ResolveItemCallstack = new global::Lua.LuaFunction("ResolveItemCallstack", (_context, _) =>
        {
            global::Lua.LuaValue _lastArg = default;
            global::System.Int32 _lastArgPos = default;
            global::System.Type _expectedType = default;
            var _argCount = _context.ArgumentCount;
            var _this = _context.GetArgument<LuaHierarchyFrameDataView>(0);
            var _arg0 = _lastArg = _argCount > 1 ? _context.GetArgument(1) : global::Lua.LuaValue.Nil;
            _lastArgPos = 0; _expectedType = typeof(global::System.Int32);
            if (_arg0.TryRead<global::System.Int32>(out var _p0_System_Int32))
            {
                if (_argCount == 2)
                {
                    var id = _p0_System_Int32;
                    var _ret0 = _this.Instance.ResolveItemCallstack(id);
                    var _lret0 = new global::Lua.LuaValue(_ret0);
                    var _retCount = _context.Return(_lret0);
                    return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                }
            }
            throw new global::Lua.LuaRuntimeException(_context.Thread, $"{"ResolveItemCallstack"}: invalid argument #{_lastArgPos}: {_lastArg} ({_lastArg.Type}), expected: {_expectedType.FullName}", 2);
        });
        private static readonly global::Lua.LuaFunction _LuaHierarchyFrameDataView_ResolveItemMergedSampleCallstack = new global::Lua.LuaFunction("ResolveItemMergedSampleCallstack", (_context, _) =>
        {
            global::Lua.LuaValue _lastArg = default;
            global::System.Int32 _lastArgPos = default;
            global::System.Type _expectedType = default;
            var _argCount = _context.ArgumentCount;
            var _this = _context.GetArgument<LuaHierarchyFrameDataView>(0);
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
                        var id = _p0_System_Int32;
                        var sampleIndex = _p1_System_Int32;
                        var _ret0 = _this.Instance.ResolveItemMergedSampleCallstack(id, sampleIndex);
                        var _lret0 = new global::Lua.LuaValue(_ret0);
                        var _retCount = _context.Return(_lret0);
                        return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                    }
                }
            }
            throw new global::Lua.LuaRuntimeException(_context.Thread, $"{"ResolveItemMergedSampleCallstack"}: invalid argument #{_lastArgPos}: {_lastArg} ({_lastArg.Type}), expected: {_expectedType.FullName}", 2);
        });
        private static readonly global::Lua.LuaFunction _LuaHierarchyFrameDataView_Sort = new global::Lua.LuaFunction("Sort", (_context, _) =>
        {
            global::Lua.LuaValue _lastArg = default;
            global::System.Int32 _lastArgPos = default;
            global::System.Type _expectedType = default;
            var _argCount = _context.ArgumentCount;
            var _this = _context.GetArgument<LuaHierarchyFrameDataView>(0);
            var _arg0 = _lastArg = _argCount > 1 ? _context.GetArgument(1) : global::Lua.LuaValue.Nil;
            _lastArgPos = 0; _expectedType = typeof(global::System.Int32);
            if (_arg0.TryRead<global::System.Int32>(out var _p0_System_Int32))
            {
                var _arg1 = _lastArg = _argCount > 2 ? _context.GetArgument(2) : global::Lua.LuaValue.Nil;
                _lastArgPos = 1; _expectedType = typeof(global::System.Boolean);
                if (_arg1.TryRead<global::System.Boolean>(out var _p1_System_Boolean))
                {
                    if (_argCount == 3)
                    {
                        var sortColumn = _p0_System_Int32;
                        var sortAscending = _p1_System_Boolean;
                        _this.Instance.Sort(sortColumn, sortAscending);
                        var _retCount = _context.Return();
                        return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                    }
                }
            }
            throw new global::Lua.LuaRuntimeException(_context.Thread, $"{"Sort"}: invalid argument #{_lastArgPos}: {_lastArg} ({_lastArg.Type}), expected: {_expectedType.FullName}", 2);
        });
        private static readonly global::Lua.LuaFunction __index = new(global::Lua.Runtime.Metamethods.Index, (_context, _) =>
        {
            var _this = _context.GetArgument<LuaHierarchyFrameDataView>(0);
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
            var _this = _context.GetArgument<LuaHierarchyFrameDataView>(0);
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
                case "Equals": _value = _LuaHierarchyFrameDataView_Equals; return true;
                case "GetHashCode": _value = _LuaHierarchyFrameDataView_GetHashCode; return true;
                case "GetItemCategoryIndex": _value = _LuaHierarchyFrameDataView_GetItemCategoryIndex; return true;
                case "GetItemColumnData": _value = _LuaHierarchyFrameDataView_GetItemColumnData; return true;
                case "GetItemColumnDataAsDouble": _value = _LuaHierarchyFrameDataView_GetItemColumnDataAsDouble; return true;
                case "GetItemColumnDataAsFloat": _value = _LuaHierarchyFrameDataView_GetItemColumnDataAsFloat; return true;
                case "GetItemColumnDataAsSingle": _value = _LuaHierarchyFrameDataView_GetItemColumnDataAsSingle; return true;
                case "GetItemDepth": _value = _LuaHierarchyFrameDataView_GetItemDepth; return true;
                case "GetItemInstanceID": _value = _LuaHierarchyFrameDataView_GetItemInstanceID; return true;
                case "GetItemMarkerFlags": _value = _LuaHierarchyFrameDataView_GetItemMarkerFlags; return true;
                case "GetItemMarkerID": _value = _LuaHierarchyFrameDataView_GetItemMarkerID; return true;
                case "GetItemMergedSamplesCount": _value = _LuaHierarchyFrameDataView_GetItemMergedSamplesCount; return true;
                case "GetItemMergedSamplesMetadata": _value = _LuaHierarchyFrameDataView_GetItemMergedSamplesMetadata; return true;
                case "GetItemMergedSamplesMetadataAsFloat": _value = _LuaHierarchyFrameDataView_GetItemMergedSamplesMetadataAsFloat; return true;
                case "GetItemMergedSamplesMetadataAsLong": _value = _LuaHierarchyFrameDataView_GetItemMergedSamplesMetadataAsLong; return true;
                case "GetItemMergedSamplesMetadataCount": _value = _LuaHierarchyFrameDataView_GetItemMergedSamplesMetadataCount; return true;
                case "GetItemMetadata": _value = _LuaHierarchyFrameDataView_GetItemMetadata; return true;
                case "GetItemMetadataAsFloat": _value = _LuaHierarchyFrameDataView_GetItemMetadataAsFloat; return true;
                case "GetItemMetadataAsLong": _value = _LuaHierarchyFrameDataView_GetItemMetadataAsLong; return true;
                case "GetItemMetadataCount": _value = _LuaHierarchyFrameDataView_GetItemMetadataCount; return true;
                case "GetItemName": _value = _LuaHierarchyFrameDataView_GetItemName; return true;
                case "GetItemPath": _value = _LuaHierarchyFrameDataView_GetItemPath; return true;
                case "GetRootItemID": _value = _LuaHierarchyFrameDataView_GetRootItemID; return true;
                case "HasItemChildren": _value = _LuaHierarchyFrameDataView_HasItemChildren; return true;
                case "ItemContainsRawFrameDataViewIndex": _value = _LuaHierarchyFrameDataView_ItemContainsRawFrameDataViewIndex; return true;
                case "ResolveItemCallstack": _value = _LuaHierarchyFrameDataView_ResolveItemCallstack; return true;
                case "ResolveItemMergedSampleCallstack": _value = _LuaHierarchyFrameDataView_ResolveItemMergedSampleCallstack; return true;
                case "Sort": _value = _LuaHierarchyFrameDataView_Sort; return true;
                case "sortColumn": _value = new global::Lua.LuaValue(Instance.sortColumn); return true;
                case "sortColumnAscending": _value = new global::Lua.LuaValue(Instance.sortColumnAscending); return true;
                case "viewMode": _value = new global::Lua.LuaValue((global::System.Int64)Instance.viewMode); return true;
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
                default: return base.TrySetLuaValue(_key, _value);
            }
        }
    }
    public sealed class LuaHierarchyFrameDataViewType : global::Luny.ILuaStatic
    {
        public static global::Lua.LuaValue Bind() => new LuaHierarchyFrameDataViewType();
        private LuaHierarchyFrameDataViewType() {}
        public static implicit operator global::Lua.LuaValue(LuaHierarchyFrameDataViewType value) => new(value);
        public global::System.Type BindType => typeof(global::UnityEditor.Profiling.HierarchyFrameDataView);
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
            var _this = _context.GetArgument<LuaHierarchyFrameDataViewType>(0);
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
            var _this = _context.GetArgument<LuaHierarchyFrameDataViewType>(0);
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
                case "columnCalls": _value = new global::Lua.LuaValue(global::UnityEditor.Profiling.HierarchyFrameDataView.columnCalls); return true;
                case "columnDontSort": _value = new global::Lua.LuaValue(global::UnityEditor.Profiling.HierarchyFrameDataView.columnDontSort); return true;
                case "columnGcMemory": _value = new global::Lua.LuaValue(global::UnityEditor.Profiling.HierarchyFrameDataView.columnGcMemory); return true;
                case "columnName": _value = new global::Lua.LuaValue(global::UnityEditor.Profiling.HierarchyFrameDataView.columnName); return true;
                case "columnObjectName": _value = new global::Lua.LuaValue(global::UnityEditor.Profiling.HierarchyFrameDataView.columnObjectName); return true;
                case "columnSelfPercent": _value = new global::Lua.LuaValue(global::UnityEditor.Profiling.HierarchyFrameDataView.columnSelfPercent); return true;
                case "columnSelfTime": _value = new global::Lua.LuaValue(global::UnityEditor.Profiling.HierarchyFrameDataView.columnSelfTime); return true;
                case "columnStartTime": _value = new global::Lua.LuaValue(global::UnityEditor.Profiling.HierarchyFrameDataView.columnStartTime); return true;
                case "columnTotalPercent": _value = new global::Lua.LuaValue(global::UnityEditor.Profiling.HierarchyFrameDataView.columnTotalPercent); return true;
                case "columnTotalTime": _value = new global::Lua.LuaValue(global::UnityEditor.Profiling.HierarchyFrameDataView.columnTotalTime); return true;
                case "columnWarningCount": _value = new global::Lua.LuaValue(global::UnityEditor.Profiling.HierarchyFrameDataView.columnWarningCount); return true;
                case "invalidSampleId": _value = new global::Lua.LuaValue(global::UnityEditor.Profiling.HierarchyFrameDataView.invalidSampleId); return true;
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
