
// --------------------------------------------------------------
// GENERATED FILE ----> DO NOT EDIT <---- CHANGES WILL BE LOST !!
// --------------------------------------------------------------

#if UNITY_6000_2_OR_NEWER && !(UNITY_6000_3_OR_NEWER)
#pragma warning disable 0109, 0162, 0168, 0219
using Luny;

namespace Luny.UnityEngine.Rendering
{
    public sealed class LuaScriptableCullingParameters : global::Luny.ILuaValueType<global::UnityEngine.Rendering.ScriptableCullingParameters>
    {
        public new static global::Lua.LuaValue Bind(in global::UnityEngine.Rendering.ScriptableCullingParameters instance) => new LuaScriptableCullingParameters(instance);
        public new static global::Lua.LuaValue Bind(global::System.Object instance) => Bind((global::UnityEngine.Rendering.ScriptableCullingParameters)instance);
        public new static global::Lua.LuaValue Bind(global::System.Collections.Generic.IList<global::UnityEngine.Rendering.ScriptableCullingParameters> instances) =>
            new global::Luny.LuaList<global::UnityEngine.Rendering.ScriptableCullingParameters>(instances);
        public new static global::Lua.LuaValue Bind(global::System.Collections.Generic.IList<global::System.Object> instances) =>
            new global::Luny.LuaList<global::UnityEngine.Rendering.ScriptableCullingParameters>(instances);
        private LuaScriptableCullingParameters(in global::UnityEngine.Rendering.ScriptableCullingParameters value) => m_Value = value;
        public static implicit operator global::Lua.LuaValue(LuaScriptableCullingParameters value) => new(value);
        private global::UnityEngine.Rendering.ScriptableCullingParameters m_Value;
        public global::UnityEngine.Rendering.ScriptableCullingParameters Value { get => m_Value; set => m_Value = value; }
        public ref global::UnityEngine.Rendering.ScriptableCullingParameters ValueRef => ref m_Value;
        public global::System.Type BindType => typeof(global::UnityEngine.Rendering.ScriptableCullingParameters);
        public override global::System.String ToString() => m_Value.ToString();
#if UNITY_EDITOR
        [global::UnityEngine.RuntimeInitializeOnLoadMethod(global::UnityEngine.RuntimeInitializeLoadType.SubsystemRegistration)]
        private static void ResetStaticFields() => s_Metatable = null;
#endif

        private static readonly global::Lua.LuaFunction _LuaScriptableCullingParameters_Equals = new global::Lua.LuaFunction("Equals", (_context, _) =>
        {
            global::Lua.LuaValue _lastArg = default;
            global::System.Int32 _lastArgPos = default;
            global::System.Type _expectedType = default;
            var _argCount = _context.ArgumentCount;
            var _this = _context.GetArgument<LuaScriptableCullingParameters>(0);
            var _arg0 = _lastArg = _argCount > 1 ? _context.GetArgument(1) : global::Lua.LuaValue.Nil;
            _lastArgPos = 0; _expectedType = typeof(global::Luny.UnityEngine.Rendering.LuaScriptableCullingParameters);
            if (_arg0.TryRead<global::Luny.UnityEngine.Rendering.LuaScriptableCullingParameters>(out var _p0_UnityEngine_Rendering_ScriptableCullingParameters))
            {
                if (_argCount == 2)
                {
                    var other = _p0_UnityEngine_Rendering_ScriptableCullingParameters.Value;
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
        private static readonly global::Lua.LuaFunction _LuaScriptableCullingParameters_GetCullingPlane = new global::Lua.LuaFunction("GetCullingPlane", (_context, _) =>
        {
            global::Lua.LuaValue _lastArg = default;
            global::System.Int32 _lastArgPos = default;
            global::System.Type _expectedType = default;
            var _argCount = _context.ArgumentCount;
            var _this = _context.GetArgument<LuaScriptableCullingParameters>(0);
            var _arg0 = _lastArg = _argCount > 1 ? _context.GetArgument(1) : global::Lua.LuaValue.Nil;
            _lastArgPos = 0; _expectedType = typeof(global::System.Int32);
            if (_arg0.TryRead<global::System.Int32>(out var _p0_System_Int32))
            {
                if (_argCount == 2)
                {
                    var index = _p0_System_Int32;
                    var _ret0 = _this.m_Value.GetCullingPlane(index);
                    var _lret0 = global::Luny.UnityEngine.LuaPlane.Bind(_ret0);
                    var _retCount = _context.Return(_lret0);
                    return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                }
            }
            throw new global::Lua.LuaRuntimeException(_context.Thread, $"{"GetCullingPlane"}: invalid argument #{_lastArgPos}: {_lastArg} ({_lastArg.Type}), expected: {_expectedType.FullName}", 2);
        });
        private static readonly global::Lua.LuaFunction _LuaScriptableCullingParameters_GetHashCode = new global::Lua.LuaFunction("GetHashCode", (_context, _) =>
        {
            global::Lua.LuaValue _lastArg = default;
            global::System.Int32 _lastArgPos = default;
            global::System.Type _expectedType = default;
            var _argCount = _context.ArgumentCount;
            var _this = _context.GetArgument<LuaScriptableCullingParameters>(0);
            if (_argCount == 1)
            {
                var _ret0 = _this.m_Value.GetHashCode();
                var _lret0 = new global::Lua.LuaValue(_ret0);
                var _retCount = _context.Return(_lret0);
                return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
            }
            throw new global::Lua.LuaRuntimeException(_context.Thread, $"{"GetHashCode"}: invalid argument #{_lastArgPos}: {_lastArg} ({_lastArg.Type}), expected: {_expectedType.FullName}", 2);
        });
        private static readonly global::Lua.LuaFunction _LuaScriptableCullingParameters_GetLayerCullingDistance = new global::Lua.LuaFunction("GetLayerCullingDistance", (_context, _) =>
        {
            global::Lua.LuaValue _lastArg = default;
            global::System.Int32 _lastArgPos = default;
            global::System.Type _expectedType = default;
            var _argCount = _context.ArgumentCount;
            var _this = _context.GetArgument<LuaScriptableCullingParameters>(0);
            var _arg0 = _lastArg = _argCount > 1 ? _context.GetArgument(1) : global::Lua.LuaValue.Nil;
            _lastArgPos = 0; _expectedType = typeof(global::System.Int32);
            if (_arg0.TryRead<global::System.Int32>(out var _p0_System_Int32))
            {
                if (_argCount == 2)
                {
                    var layerIndex = _p0_System_Int32;
                    var _ret0 = _this.m_Value.GetLayerCullingDistance(layerIndex);
                    var _lret0 = new global::Lua.LuaValue(_ret0);
                    var _retCount = _context.Return(_lret0);
                    return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                }
            }
            throw new global::Lua.LuaRuntimeException(_context.Thread, $"{"GetLayerCullingDistance"}: invalid argument #{_lastArgPos}: {_lastArg} ({_lastArg.Type}), expected: {_expectedType.FullName}", 2);
        });
        private static readonly global::Lua.LuaFunction _LuaScriptableCullingParameters_SetCullingPlane = new global::Lua.LuaFunction("SetCullingPlane", (_context, _) =>
        {
            global::Lua.LuaValue _lastArg = default;
            global::System.Int32 _lastArgPos = default;
            global::System.Type _expectedType = default;
            var _argCount = _context.ArgumentCount;
            var _this = _context.GetArgument<LuaScriptableCullingParameters>(0);
            var _arg0 = _lastArg = _argCount > 1 ? _context.GetArgument(1) : global::Lua.LuaValue.Nil;
            _lastArgPos = 0; _expectedType = typeof(global::System.Int32);
            if (_arg0.TryRead<global::System.Int32>(out var _p0_System_Int32))
            {
                var _arg1 = _lastArg = _argCount > 2 ? _context.GetArgument(2) : global::Lua.LuaValue.Nil;
                _lastArgPos = 1; _expectedType = typeof(global::Luny.UnityEngine.LuaPlane);
                if (_arg1.TryRead<global::Luny.UnityEngine.LuaPlane>(out var _p1_UnityEngine_Plane))
                {
                    if (_argCount == 3)
                    {
                        var index = _p0_System_Int32;
                        var plane = _p1_UnityEngine_Plane.Value;
                        _this.m_Value.SetCullingPlane(index, plane);
                        var _retCount = _context.Return();
                        return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                    }
                }
            }
            throw new global::Lua.LuaRuntimeException(_context.Thread, $"{"SetCullingPlane"}: invalid argument #{_lastArgPos}: {_lastArg} ({_lastArg.Type}), expected: {_expectedType.FullName}", 2);
        });
        private static readonly global::Lua.LuaFunction _LuaScriptableCullingParameters_SetLayerCullingDistance = new global::Lua.LuaFunction("SetLayerCullingDistance", (_context, _) =>
        {
            global::Lua.LuaValue _lastArg = default;
            global::System.Int32 _lastArgPos = default;
            global::System.Type _expectedType = default;
            var _argCount = _context.ArgumentCount;
            var _this = _context.GetArgument<LuaScriptableCullingParameters>(0);
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
                        var layerIndex = _p0_System_Int32;
                        var distance = _p1_System_Single;
                        _this.m_Value.SetLayerCullingDistance(layerIndex, distance);
                        var _retCount = _context.Return();
                        return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                    }
                }
            }
            throw new global::Lua.LuaRuntimeException(_context.Thread, $"{"SetLayerCullingDistance"}: invalid argument #{_lastArgPos}: {_lastArg} ({_lastArg.Type}), expected: {_expectedType.FullName}", 2);
        });
        private static readonly global::Lua.LuaFunction __index = new(global::Lua.Runtime.Metamethods.Index, (_context, _) =>
        {
            var _this = _context.GetArgument<LuaScriptableCullingParameters>(0);
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
            var _this = _context.GetArgument<LuaScriptableCullingParameters>(0);
            var _key = _context.GetArgument(1);
            var _value = _context.GetArgument(2);
            if (_key.Type == global::Lua.LuaValueType.Number && _key.TryRead<global::System.Int32>(out var _index) && _this.TrySetLuaValue(_index, _value))
                return new global::System.Threading.Tasks.ValueTask<global::System.Int32>(_context.Return(_value));
            if (_key.Type == global::Lua.LuaValueType.String && _this.TrySetLuaValue(_key.Read<global::System.String>(), _value))
                return new global::System.Threading.Tasks.ValueTask<global::System.Int32>(_context.Return(_value));
            throw new global::Lua.LuaRuntimeException(_context.Thread, $"attempt to assign to unknown '{_key}' on '{_this}'", 2);
        });
        private static global::Lua.LuaTable CreateMetatable()
        {
            var metatable = new global::Lua.LuaTable(0, 4);
            metatable[global::Lua.Runtime.Metamethods.Index] = __index;
            metatable[global::Lua.Runtime.Metamethods.NewIndex] = __newindex;
            metatable[global::Lua.Runtime.Metamethods.Concat] = global::Luny.LuaMetatable.ConcatMetamethod;
            metatable[global::Lua.Runtime.Metamethods.ToString] = global::Luny.LuaMetatable.ToStringMetamethod;
            return metatable;
        }
        private static global::Lua.LuaTable s_Metatable;
        public global::Lua.LuaTable Metatable
        {
            get => s_Metatable ??= CreateMetatable();
            set => throw new global::System.NotSupportedException("LuaObject metatables cannot be modified");
        }
        global::System.Span<global::Lua.LuaValue> global::Lua.ILuaUserData.UserValues => default;

        public global::System.Boolean TryGetLuaValue(global::System.Int32 _key, out global::Lua.LuaValue _value, global::Luny.ILuaObjectFactory _factory)
        {
            _value = global::Lua.LuaValue.Nil; return false;
        }
        public global::System.Boolean TryGetLuaValue(global::System.String _key, out global::Lua.LuaValue _value, global::Luny.ILuaObjectFactory _factory)
        {
            switch (_key)
            {
                case "Equals": _value = _LuaScriptableCullingParameters_Equals; return true;
                case "GetCullingPlane": _value = _LuaScriptableCullingParameters_GetCullingPlane; return true;
                case "GetHashCode": _value = _LuaScriptableCullingParameters_GetHashCode; return true;
                case "GetLayerCullingDistance": _value = _LuaScriptableCullingParameters_GetLayerCullingDistance; return true;
                case "SetCullingPlane": _value = _LuaScriptableCullingParameters_SetCullingPlane; return true;
                case "SetLayerCullingDistance": _value = _LuaScriptableCullingParameters_SetLayerCullingDistance; return true;
                case "accurateOcclusionThreshold": _value = new global::Lua.LuaValue(m_Value.accurateOcclusionThreshold); return true;
                case "cameraProperties": _value = global::Luny.UnityEngine.Rendering.LuaCameraProperties.Bind(m_Value.cameraProperties); return true;
                case "conservativeEnclosingSphere": _value = new global::Lua.LuaValue(m_Value.conservativeEnclosingSphere); return true;
                case "cullingMask": _value = new global::Lua.LuaValue(m_Value.cullingMask); return true;
                case "cullingMatrix": _value = global::Luny.UnityEngine.LuaMatrix4x4.Bind(m_Value.cullingMatrix); return true;
                case "cullingOptions": _value = new global::Lua.LuaValue((global::System.Int64)m_Value.cullingOptions); return true;
                case "cullingPlaneCount": _value = new global::Lua.LuaValue(m_Value.cullingPlaneCount); return true;
                case "isOrthographic": _value = new global::Lua.LuaValue(m_Value.isOrthographic); return true;
                case "lodParameters": _value = global::Luny.UnityEngine.Rendering.LuaLODParameters.Bind(m_Value.lodParameters); return true;
                case "maximumPortalCullingJobs": _value = new global::Lua.LuaValue(m_Value.maximumPortalCullingJobs); return true;
                case "maximumVisibleLights": _value = new global::Lua.LuaValue(m_Value.maximumVisibleLights); return true;
                case "numIterationsEnclosingSphere": _value = new global::Lua.LuaValue(m_Value.numIterationsEnclosingSphere); return true;
                case "origin": _value = global::Luny.UnityEngine.LuaVector3.Bind(m_Value.origin); return true;
                case "reflectionProbeSortingCriteria": _value = new global::Lua.LuaValue((global::System.Int64)m_Value.reflectionProbeSortingCriteria); return true;
                case "shadowDistance": _value = new global::Lua.LuaValue(m_Value.shadowDistance); return true;
                case "shadowNearPlaneOffset": _value = new global::Lua.LuaValue(m_Value.shadowNearPlaneOffset); return true;
                case "stereoProjectionMatrix": _value = global::Luny.UnityEngine.LuaMatrix4x4.Bind(m_Value.stereoProjectionMatrix); return true;
                case "stereoSeparationDistance": _value = new global::Lua.LuaValue(m_Value.stereoSeparationDistance); return true;
                case "stereoViewMatrix": _value = global::Luny.UnityEngine.LuaMatrix4x4.Bind(m_Value.stereoViewMatrix); return true;
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
                case "accurateOcclusionThreshold": { var _temp = m_Value; _temp.accurateOcclusionThreshold = _value.Read<global::System.Single>(); m_Value = _temp; } return true;
                case "cameraProperties": { var _temp = m_Value; _temp.cameraProperties = _value.Read<global::Luny.UnityEngine.Rendering.LuaCameraProperties>().Value; m_Value = _temp; } return true;
                case "conservativeEnclosingSphere": { var _temp = m_Value; _temp.conservativeEnclosingSphere = _value.Read<global::System.Boolean>(); m_Value = _temp; } return true;
                case "cullingMask": { var _temp = m_Value; _temp.cullingMask = _value.Read<global::System.UInt32>(); m_Value = _temp; } return true;
                case "cullingMatrix": { var _temp = m_Value; _temp.cullingMatrix = _value.Read<global::Luny.UnityEngine.LuaMatrix4x4>().Value; m_Value = _temp; } return true;
                case "cullingOptions": { var _temp = m_Value; _temp.cullingOptions = _value.Read<global::UnityEngine.Rendering.CullingOptions>(); m_Value = _temp; } return true;
                case "cullingPlaneCount": { var _temp = m_Value; _temp.cullingPlaneCount = _value.Read<global::System.Int32>(); m_Value = _temp; } return true;
                case "isOrthographic": { var _temp = m_Value; _temp.isOrthographic = _value.Read<global::System.Boolean>(); m_Value = _temp; } return true;
                case "lodParameters": { var _temp = m_Value; _temp.lodParameters = _value.Read<global::Luny.UnityEngine.Rendering.LuaLODParameters>().Value; m_Value = _temp; } return true;
                case "maximumPortalCullingJobs": { var _temp = m_Value; _temp.maximumPortalCullingJobs = _value.Read<global::System.Int32>(); m_Value = _temp; } return true;
                case "maximumVisibleLights": { var _temp = m_Value; _temp.maximumVisibleLights = _value.Read<global::System.Int32>(); m_Value = _temp; } return true;
                case "numIterationsEnclosingSphere": { var _temp = m_Value; _temp.numIterationsEnclosingSphere = _value.Read<global::System.Int32>(); m_Value = _temp; } return true;
                case "origin": { var _temp = m_Value; _temp.origin = _value.Read<global::Luny.UnityEngine.LuaVector3>().Value; m_Value = _temp; } return true;
                case "reflectionProbeSortingCriteria": { var _temp = m_Value; _temp.reflectionProbeSortingCriteria = _value.Read<global::UnityEngine.Rendering.ReflectionProbeSortingCriteria>(); m_Value = _temp; } return true;
                case "shadowDistance": { var _temp = m_Value; _temp.shadowDistance = _value.Read<global::System.Single>(); m_Value = _temp; } return true;
                case "shadowNearPlaneOffset": { var _temp = m_Value; _temp.shadowNearPlaneOffset = _value.Read<global::System.Single>(); m_Value = _temp; } return true;
                case "stereoProjectionMatrix": { var _temp = m_Value; _temp.stereoProjectionMatrix = _value.Read<global::Luny.UnityEngine.LuaMatrix4x4>().Value; m_Value = _temp; } return true;
                case "stereoSeparationDistance": { var _temp = m_Value; _temp.stereoSeparationDistance = _value.Read<global::System.Single>(); m_Value = _temp; } return true;
                case "stereoViewMatrix": { var _temp = m_Value; _temp.stereoViewMatrix = _value.Read<global::Luny.UnityEngine.LuaMatrix4x4>().Value; m_Value = _temp; } return true;
                default: return false;
            }
        }
    }
    public sealed class LuaScriptableCullingParametersType : global::Luny.ILuaStatic
    {
        public static global::Lua.LuaValue Bind() => new LuaScriptableCullingParametersType();
        private LuaScriptableCullingParametersType() {}
        public static implicit operator global::Lua.LuaValue(LuaScriptableCullingParametersType value) => new(value);
        public global::System.Type BindType => typeof(global::UnityEngine.Rendering.ScriptableCullingParameters);
        public override global::System.String ToString() => BindType.FullName;
#if UNITY_EDITOR
        [global::UnityEngine.RuntimeInitializeOnLoadMethod(global::UnityEngine.RuntimeInitializeLoadType.SubsystemRegistration)]
        private static void ResetStaticFields() => s_Metatable = null;
#endif

        private static readonly global::Lua.LuaFunction __index = new(global::Lua.Runtime.Metamethods.Index, (_context, _) =>
        {
            var _this = _context.GetArgument<LuaScriptableCullingParametersType>(0);
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
            var _this = _context.GetArgument<LuaScriptableCullingParametersType>(0);
            var _key = _context.GetArgument(1);
            var _value = _context.GetArgument(2);
            if (_key.Type == global::Lua.LuaValueType.Number && _key.TryRead<global::System.Int32>(out var _index) && _this.TrySetLuaValue(_index, _value))
                return new global::System.Threading.Tasks.ValueTask<global::System.Int32>(_context.Return(_value));
            if (_key.Type == global::Lua.LuaValueType.String && _this.TrySetLuaValue(_key.Read<global::System.String>(), _value))
                return new global::System.Threading.Tasks.ValueTask<global::System.Int32>(_context.Return(_value));
            throw new global::Lua.LuaRuntimeException(_context.Thread, $"attempt to assign to unknown '{_key}' on '{_this}'", 2);
        });
        private static global::Lua.LuaTable CreateMetatable()
        {
            var metatable = new global::Lua.LuaTable(0, 4);
            metatable[global::Lua.Runtime.Metamethods.Index] = __index;
            metatable[global::Lua.Runtime.Metamethods.NewIndex] = __newindex;
            metatable[global::Lua.Runtime.Metamethods.Concat] = global::Luny.LuaMetatable.ConcatMetamethod;
            metatable[global::Lua.Runtime.Metamethods.ToString] = global::Luny.LuaMetatable.ToStringMetamethod;
            return metatable;
        }
        private static global::Lua.LuaTable s_Metatable;
        public global::Lua.LuaTable Metatable
        {
            get => s_Metatable ??= CreateMetatable();
            set => throw new global::System.NotSupportedException("LuaObject metatables cannot be modified");
        }
        global::System.Span<global::Lua.LuaValue> global::Lua.ILuaUserData.UserValues => default;

        public global::System.Boolean TryGetLuaValue(global::System.Int32 _key, out global::Lua.LuaValue _value, global::Luny.ILuaObjectFactory _factory)
        {
            _value = global::Lua.LuaValue.Nil; return false;
        }
        public global::System.Boolean TryGetLuaValue(global::System.String _key, out global::Lua.LuaValue _value, global::Luny.ILuaObjectFactory _factory)
        {
            switch (_key)
            {
                case "cullingJobsLowerLimit": _value = new global::Lua.LuaValue(global::UnityEngine.Rendering.ScriptableCullingParameters.cullingJobsLowerLimit); return true;
                case "cullingJobsUpperLimit": _value = new global::Lua.LuaValue(global::UnityEngine.Rendering.ScriptableCullingParameters.cullingJobsUpperLimit); return true;
                case "layerCount": _value = new global::Lua.LuaValue(global::UnityEngine.Rendering.ScriptableCullingParameters.layerCount); return true;
                case "maximumCullingPlaneCount": _value = new global::Lua.LuaValue(global::UnityEngine.Rendering.ScriptableCullingParameters.maximumCullingPlaneCount); return true;
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
