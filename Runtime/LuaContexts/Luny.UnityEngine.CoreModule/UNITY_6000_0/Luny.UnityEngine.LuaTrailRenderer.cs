
// --------------------------------------------------------------
// GENERATED FILE ----> DO NOT EDIT <---- CHANGES WILL BE LOST !!
// --------------------------------------------------------------

#if UNITY_6000_0_OR_NEWER && !(UNITY_6000_1_OR_NEWER)
#pragma warning disable 0109, 0162, 0168, 0219
using Luny;

namespace Luny.UnityEngine
{
    public sealed class LuaTrailRenderer : global::Luny.UnityEngine.LuaRenderer, global::Luny.ILuaObject<global::UnityEngine.TrailRenderer>
    {
        public new static global::Lua.LuaValue Bind(global::UnityEngine.TrailRenderer instance) => new LuaTrailRenderer(instance);
        public new static global::Lua.LuaValue Bind(global::System.Object instance) => Bind((global::UnityEngine.TrailRenderer)instance);
        public new static global::Lua.LuaValue Bind(global::System.Collections.Generic.IList<global::UnityEngine.TrailRenderer> instances) =>
            new global::Luny.LuaList<global::UnityEngine.TrailRenderer>(instances);
        public new static global::Lua.LuaValue Bind(global::System.Collections.Generic.IList<global::System.Object> instances) =>
            new global::Luny.LuaList<global::UnityEngine.TrailRenderer>(instances);
        private LuaTrailRenderer(global::UnityEngine.TrailRenderer instance) : base(instance) {}
        public static implicit operator global::Lua.LuaValue(LuaTrailRenderer value) => new(value);
        public new global::UnityEngine.TrailRenderer Instance => (global::UnityEngine.TrailRenderer)m_Instance;
        public new global::System.Type BindType => typeof(global::UnityEngine.TrailRenderer);
        public override global::System.String ToString() => m_Instance != null ? Instance.ToString() : "{GetType().Name}(null)";
#if UNITY_EDITOR
        [global::UnityEngine.RuntimeInitializeOnLoadMethod(global::UnityEngine.RuntimeInitializeLoadType.SubsystemRegistration)]
        private static void ResetStaticFields() => s_Metatable = null;
#endif

        private static readonly global::Lua.LuaFunction _LuaTrailRenderer_AddPosition = new global::Lua.LuaFunction("AddPosition", (_context, _) =>
        {
            global::Lua.LuaValue _lastArg = default;
            global::System.Int32 _lastArgPos = default;
            global::System.Type _expectedType = default;
            var _argCount = _context.ArgumentCount;
            var _this = _context.GetArgument<LuaTrailRenderer>(0);
            var _arg0 = _lastArg = _argCount > 1 ? _context.GetArgument(1) : global::Lua.LuaValue.Nil;
            _lastArgPos = 0; _expectedType = typeof(global::Luny.UnityEngine.LuaVector3);
            if (_arg0.TryRead<global::Luny.UnityEngine.LuaVector3>(out var _p0_UnityEngine_Vector3))
            {
                if (_argCount == 2)
                {
                    var position = _p0_UnityEngine_Vector3.Value;
                    _this.Instance.AddPosition(position);
                    var _retCount = _context.Return();
                    return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                }
            }
            throw new global::Lua.LuaRuntimeException(_context.Thread, $"{"AddPosition"}: invalid argument #{_lastArgPos}: {_lastArg} ({_lastArg.Type}), expected: {_expectedType.FullName}", 2);
        });
        private static readonly global::Lua.LuaFunction _LuaTrailRenderer_AddPositions = new global::Lua.LuaFunction("AddPositions", (_context, _) =>
        {
            global::Lua.LuaValue _lastArg = default;
            global::System.Int32 _lastArgPos = default;
            global::System.Type _expectedType = default;
            var _argCount = _context.ArgumentCount;
            var _this = _context.GetArgument<LuaTrailRenderer>(0);
            var _arg0 = _lastArg = _argCount > 1 ? _context.GetArgument(1) : global::Lua.LuaValue.Nil;
            _lastArgPos = 0; _expectedType = typeof(global::UnityEngine.Vector3[]);
            if (_arg0.TryReadArray<global::UnityEngine.Vector3>(out var _p0_UnityEngine_Vector3Array))
            {
                if (_argCount == 2)
                {
                    var positions = _p0_UnityEngine_Vector3Array;
                    _this.Instance.AddPositions(positions);
                    var _retCount = _context.Return();
                    return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                }
            }
            throw new global::Lua.LuaRuntimeException(_context.Thread, $"{"AddPositions"}: invalid argument #{_lastArgPos}: {_lastArg} ({_lastArg.Type}), expected: {_expectedType.FullName}", 2);
        });
        private static readonly global::Lua.LuaFunction _LuaTrailRenderer_BakeMesh = new global::Lua.LuaFunction("BakeMesh", (_context, _) =>
        {
            global::Lua.LuaValue _lastArg = default;
            global::System.Int32 _lastArgPos = default;
            global::System.Type _expectedType = default;
            var _argCount = _context.ArgumentCount;
            var _this = _context.GetArgument<LuaTrailRenderer>(0);
            var _arg0 = _lastArg = _argCount > 1 ? _context.GetArgument(1) : global::Lua.LuaValue.Nil;
            _lastArgPos = 0; _expectedType = typeof(global::Luny.UnityEngine.LuaMesh);
            if (_arg0.TryRead<global::Luny.UnityEngine.LuaMesh>(out var _p0_UnityEngine_Mesh))
            {
                if (_argCount == 2)
                {
                    var mesh = _p0_UnityEngine_Mesh.Instance;
                    _this.Instance.BakeMesh(mesh);
                    var _retCount = _context.Return();
                    return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                }
                var _arg1 = _lastArg = _argCount > 2 ? _context.GetArgument(2) : global::Lua.LuaValue.Nil;
                _lastArgPos = 1; _expectedType = typeof(global::System.Boolean);
                var _p1_System_Boolean = _arg1.ReadValue<global::System.Boolean>((global::System.Boolean)false);
                {
                    if (_argCount == 3)
                    {
                        var mesh = _p0_UnityEngine_Mesh.Instance;
                        var useTransform = _p1_System_Boolean;
                        _this.Instance.BakeMesh(mesh, useTransform);
                        var _retCount = _context.Return();
                        return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                    }
                }
                _lastArgPos = 1; _expectedType = typeof(global::Luny.UnityEngine.LuaCamera);
                if (_arg1.TryRead<global::Luny.UnityEngine.LuaCamera>(out var _p1_UnityEngine_Camera))
                {
                    if (_argCount == 3)
                    {
                        var mesh = _p0_UnityEngine_Mesh.Instance;
                        var camera = _p1_UnityEngine_Camera.Instance;
                        _this.Instance.BakeMesh(mesh, camera);
                        var _retCount = _context.Return();
                        return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                    }
                    var _arg2 = _lastArg = _argCount > 3 ? _context.GetArgument(3) : global::Lua.LuaValue.Nil;
                    _lastArgPos = 2; _expectedType = typeof(global::System.Boolean);
                    var _p2_System_Boolean = _arg2.ReadValue<global::System.Boolean>((global::System.Boolean)false);
                    {
                        if (_argCount == 4)
                        {
                            var mesh = _p0_UnityEngine_Mesh.Instance;
                            var camera = _p1_UnityEngine_Camera.Instance;
                            var useTransform = _p2_System_Boolean;
                            _this.Instance.BakeMesh(mesh, camera, useTransform);
                            var _retCount = _context.Return();
                            return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                        }
                    }
                }
            }
            throw new global::Lua.LuaRuntimeException(_context.Thread, $"{"BakeMesh"}: invalid argument #{_lastArgPos}: {_lastArg} ({_lastArg.Type}), expected: {_expectedType.FullName}", 2);
        });
        private static readonly global::Lua.LuaFunction _LuaTrailRenderer_Clear = new global::Lua.LuaFunction("Clear", (_context, _) =>
        {
            global::Lua.LuaValue _lastArg = default;
            global::System.Int32 _lastArgPos = default;
            global::System.Type _expectedType = default;
            var _argCount = _context.ArgumentCount;
            var _this = _context.GetArgument<LuaTrailRenderer>(0);
            if (_argCount == 1)
            {
                _this.Instance.Clear();
                var _retCount = _context.Return();
                return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
            }
            throw new global::Lua.LuaRuntimeException(_context.Thread, $"{"Clear"}: invalid argument #{_lastArgPos}: {_lastArg} ({_lastArg.Type}), expected: {_expectedType.FullName}", 2);
        });
        private static readonly global::Lua.LuaFunction _LuaTrailRenderer_GetPosition = new global::Lua.LuaFunction("GetPosition", (_context, _) =>
        {
            global::Lua.LuaValue _lastArg = default;
            global::System.Int32 _lastArgPos = default;
            global::System.Type _expectedType = default;
            var _argCount = _context.ArgumentCount;
            var _this = _context.GetArgument<LuaTrailRenderer>(0);
            var _arg0 = _lastArg = _argCount > 1 ? _context.GetArgument(1) : global::Lua.LuaValue.Nil;
            _lastArgPos = 0; _expectedType = typeof(global::System.Int32);
            if (_arg0.TryRead<global::System.Int32>(out var _p0_System_Int32))
            {
                if (_argCount == 2)
                {
                    var index = _p0_System_Int32;
                    var _ret0 = _this.Instance.GetPosition(index);
                    var _lret0 = global::Luny.UnityEngine.LuaVector3.Bind(_ret0);
                    var _retCount = _context.Return(_lret0);
                    return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                }
            }
            throw new global::Lua.LuaRuntimeException(_context.Thread, $"{"GetPosition"}: invalid argument #{_lastArgPos}: {_lastArg} ({_lastArg.Type}), expected: {_expectedType.FullName}", 2);
        });
        private static readonly global::Lua.LuaFunction _LuaTrailRenderer_GetPositions = new global::Lua.LuaFunction("GetPositions", (_context, _) =>
        {
            global::Lua.LuaValue _lastArg = default;
            global::System.Int32 _lastArgPos = default;
            global::System.Type _expectedType = default;
            var _argCount = _context.ArgumentCount;
            var _this = _context.GetArgument<LuaTrailRenderer>(0);
            var _arg0 = _lastArg = _argCount > 1 ? _context.GetArgument(1) : global::Lua.LuaValue.Nil;
            _lastArgPos = 0; _expectedType = typeof(global::UnityEngine.Vector3[]);
            if (_arg0.TryReadArray<global::UnityEngine.Vector3>(out var _p0_UnityEngine_Vector3Array))
            {
                if (_argCount == 2)
                {
                    var positions = _p0_UnityEngine_Vector3Array;
                    var _ret0 = _this.Instance.GetPositions(positions);
                    var _lret0 = new global::Lua.LuaValue(_ret0);
                    var _retCount = _context.Return(_lret0);
                    return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                }
            }
            throw new global::Lua.LuaRuntimeException(_context.Thread, $"{"GetPositions"}: invalid argument #{_lastArgPos}: {_lastArg} ({_lastArg.Type}), expected: {_expectedType.FullName}", 2);
        });
        private static readonly global::Lua.LuaFunction _LuaTrailRenderer_GetVisiblePositions = new global::Lua.LuaFunction("GetVisiblePositions", (_context, _) =>
        {
            global::Lua.LuaValue _lastArg = default;
            global::System.Int32 _lastArgPos = default;
            global::System.Type _expectedType = default;
            var _argCount = _context.ArgumentCount;
            var _this = _context.GetArgument<LuaTrailRenderer>(0);
            var _arg0 = _lastArg = _argCount > 1 ? _context.GetArgument(1) : global::Lua.LuaValue.Nil;
            _lastArgPos = 0; _expectedType = typeof(global::UnityEngine.Vector3[]);
            if (_arg0.TryReadArray<global::UnityEngine.Vector3>(out var _p0_UnityEngine_Vector3Array))
            {
                if (_argCount == 2)
                {
                    var positions = _p0_UnityEngine_Vector3Array;
                    var _ret0 = _this.Instance.GetVisiblePositions(positions);
                    var _lret0 = new global::Lua.LuaValue(_ret0);
                    var _retCount = _context.Return(_lret0);
                    return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                }
            }
            throw new global::Lua.LuaRuntimeException(_context.Thread, $"{"GetVisiblePositions"}: invalid argument #{_lastArgPos}: {_lastArg} ({_lastArg.Type}), expected: {_expectedType.FullName}", 2);
        });
        private static readonly global::Lua.LuaFunction _LuaTrailRenderer_SetPosition = new global::Lua.LuaFunction("SetPosition", (_context, _) =>
        {
            global::Lua.LuaValue _lastArg = default;
            global::System.Int32 _lastArgPos = default;
            global::System.Type _expectedType = default;
            var _argCount = _context.ArgumentCount;
            var _this = _context.GetArgument<LuaTrailRenderer>(0);
            var _arg0 = _lastArg = _argCount > 1 ? _context.GetArgument(1) : global::Lua.LuaValue.Nil;
            _lastArgPos = 0; _expectedType = typeof(global::System.Int32);
            if (_arg0.TryRead<global::System.Int32>(out var _p0_System_Int32))
            {
                var _arg1 = _lastArg = _argCount > 2 ? _context.GetArgument(2) : global::Lua.LuaValue.Nil;
                _lastArgPos = 1; _expectedType = typeof(global::Luny.UnityEngine.LuaVector3);
                if (_arg1.TryRead<global::Luny.UnityEngine.LuaVector3>(out var _p1_UnityEngine_Vector3))
                {
                    if (_argCount == 3)
                    {
                        var index = _p0_System_Int32;
                        var position = _p1_UnityEngine_Vector3.Value;
                        _this.Instance.SetPosition(index, position);
                        var _retCount = _context.Return();
                        return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                    }
                }
            }
            throw new global::Lua.LuaRuntimeException(_context.Thread, $"{"SetPosition"}: invalid argument #{_lastArgPos}: {_lastArg} ({_lastArg.Type}), expected: {_expectedType.FullName}", 2);
        });
        private static readonly global::Lua.LuaFunction _LuaTrailRenderer_SetPositions = new global::Lua.LuaFunction("SetPositions", (_context, _) =>
        {
            global::Lua.LuaValue _lastArg = default;
            global::System.Int32 _lastArgPos = default;
            global::System.Type _expectedType = default;
            var _argCount = _context.ArgumentCount;
            var _this = _context.GetArgument<LuaTrailRenderer>(0);
            var _arg0 = _lastArg = _argCount > 1 ? _context.GetArgument(1) : global::Lua.LuaValue.Nil;
            _lastArgPos = 0; _expectedType = typeof(global::UnityEngine.Vector3[]);
            if (_arg0.TryReadArray<global::UnityEngine.Vector3>(out var _p0_UnityEngine_Vector3Array))
            {
                if (_argCount == 2)
                {
                    var positions = _p0_UnityEngine_Vector3Array;
                    _this.Instance.SetPositions(positions);
                    var _retCount = _context.Return();
                    return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                }
            }
            throw new global::Lua.LuaRuntimeException(_context.Thread, $"{"SetPositions"}: invalid argument #{_lastArgPos}: {_lastArg} ({_lastArg.Type}), expected: {_expectedType.FullName}", 2);
        });
        private static readonly global::Lua.LuaFunction __index = new(global::Lua.Runtime.Metamethods.Index, (_context, _) =>
        {
            var _this = _context.GetArgument<LuaTrailRenderer>(0);
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
            var _this = _context.GetArgument<LuaTrailRenderer>(0);
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
            var metatable = new global::Lua.LuaTable(0, 5);
            metatable[global::Lua.Runtime.Metamethods.Index] = __index;
            metatable[global::Lua.Runtime.Metamethods.NewIndex] = __newindex;
            metatable[global::Lua.Runtime.Metamethods.Concat] = global::Luny.LuaMetatable.ConcatMetamethod;
            metatable[global::Lua.Runtime.Metamethods.ToString] = global::Luny.LuaMetatable.ToStringMetamethod;
            return metatable;
        }
        private static global::Lua.LuaTable s_Metatable;
        public new global::Lua.LuaTable Metatable
        {
            get => s_Metatable ??= CreateMetatable();
            set => throw new global::System.NotSupportedException("LuaObject metatables cannot be modified");
        }
        global::System.Span<global::Lua.LuaValue> global::Lua.ILuaUserData.UserValues => default;

        public override global::System.Boolean TryGetLuaValue(global::System.Int32 _key, out global::Lua.LuaValue _value, global::Luny.ILuaObjectFactory _factory)
        {
            return base.TryGetLuaValue(_key, out _value, _factory);
        }
        public override global::System.Boolean TryGetLuaValue(global::System.String _key, out global::Lua.LuaValue _value, global::Luny.ILuaObjectFactory _factory)
        {
            switch (_key)
            {
                case "AddPosition": _value = _LuaTrailRenderer_AddPosition; return true;
                case "AddPositions": _value = _LuaTrailRenderer_AddPositions; return true;
                case "BakeMesh": _value = _LuaTrailRenderer_BakeMesh; return true;
                case "Clear": _value = _LuaTrailRenderer_Clear; return true;
                case "GetPosition": _value = _LuaTrailRenderer_GetPosition; return true;
                case "GetPositions": _value = _LuaTrailRenderer_GetPositions; return true;
                case "GetVisiblePositions": _value = _LuaTrailRenderer_GetVisiblePositions; return true;
                case "SetPosition": _value = _LuaTrailRenderer_SetPosition; return true;
                case "SetPositions": _value = _LuaTrailRenderer_SetPositions; return true;
                case "alignment": _value = new global::Lua.LuaValue((global::System.Int64)Instance.alignment); return true;
                case "autodestruct": _value = new global::Lua.LuaValue(Instance.autodestruct); return true;
                case "colorGradient": _value = _factory.Bind(Instance.colorGradient); return true;
                case "emitting": _value = new global::Lua.LuaValue(Instance.emitting); return true;
                case "endColor": _value = global::Luny.UnityEngine.LuaColor.Bind(Instance.endColor); return true;
                case "endWidth": _value = new global::Lua.LuaValue(Instance.endWidth); return true;
                case "generateLightingData": _value = new global::Lua.LuaValue(Instance.generateLightingData); return true;
                case "maskInteraction": _value = new global::Lua.LuaValue((global::System.Int64)Instance.maskInteraction); return true;
                case "minVertexDistance": _value = new global::Lua.LuaValue(Instance.minVertexDistance); return true;
                case "numCapVertices": _value = new global::Lua.LuaValue(Instance.numCapVertices); return true;
                case "numCornerVertices": _value = new global::Lua.LuaValue(Instance.numCornerVertices); return true;
                case "positionCount": _value = new global::Lua.LuaValue(Instance.positionCount); return true;
                case "shadowBias": _value = new global::Lua.LuaValue(Instance.shadowBias); return true;
                case "startColor": _value = global::Luny.UnityEngine.LuaColor.Bind(Instance.startColor); return true;
                case "startWidth": _value = new global::Lua.LuaValue(Instance.startWidth); return true;
                case "textureMode": _value = new global::Lua.LuaValue((global::System.Int64)Instance.textureMode); return true;
                case "textureScale": _value = global::Luny.UnityEngine.LuaVector2.Bind(Instance.textureScale); return true;
                case "time": _value = new global::Lua.LuaValue(Instance.time); return true;
                case "widthCurve": _value = _factory.Bind(Instance.widthCurve); return true;
                case "widthMultiplier": _value = new global::Lua.LuaValue(Instance.widthMultiplier); return true;
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
                case "alignment": Instance.alignment = _value.Read<global::UnityEngine.LineAlignment>();  return true;
                case "autodestruct": Instance.autodestruct = _value.Read<global::System.Boolean>();  return true;
                case "colorGradient": Instance.colorGradient = _value.Read<global::Luny.UnityEngine.LuaGradient>().Instance;  return true;
                case "emitting": Instance.emitting = _value.Read<global::System.Boolean>();  return true;
                case "endColor": Instance.endColor = _value.Read<global::Luny.UnityEngine.LuaColor>().Value;  return true;
                case "endWidth": Instance.endWidth = _value.Read<global::System.Single>();  return true;
                case "generateLightingData": Instance.generateLightingData = _value.Read<global::System.Boolean>();  return true;
                case "maskInteraction": Instance.maskInteraction = _value.Read<global::UnityEngine.SpriteMaskInteraction>();  return true;
                case "minVertexDistance": Instance.minVertexDistance = _value.Read<global::System.Single>();  return true;
                case "numCapVertices": Instance.numCapVertices = _value.Read<global::System.Int32>();  return true;
                case "numCornerVertices": Instance.numCornerVertices = _value.Read<global::System.Int32>();  return true;
                case "shadowBias": Instance.shadowBias = _value.Read<global::System.Single>();  return true;
                case "startColor": Instance.startColor = _value.Read<global::Luny.UnityEngine.LuaColor>().Value;  return true;
                case "startWidth": Instance.startWidth = _value.Read<global::System.Single>();  return true;
                case "textureMode": Instance.textureMode = _value.Read<global::UnityEngine.LineTextureMode>();  return true;
                case "textureScale": Instance.textureScale = _value.Read<global::Luny.UnityEngine.LuaVector2>().Value;  return true;
                case "time": Instance.time = _value.Read<global::System.Single>();  return true;
                case "widthCurve": Instance.widthCurve = _value.Read<global::Luny.UnityEngine.LuaAnimationCurve>().Instance;  return true;
                case "widthMultiplier": Instance.widthMultiplier = _value.Read<global::System.Single>();  return true;
                default: return base.TrySetLuaValue(_key, _value);
            }
        }
    }
    public sealed class LuaTrailRendererType : global::Luny.ILuaStatic
    {
        public static global::Lua.LuaValue Bind() => new LuaTrailRendererType();
        private LuaTrailRendererType() {}
        public static implicit operator global::Lua.LuaValue(LuaTrailRendererType value) => new(value);
        public global::System.Type BindType => typeof(global::UnityEngine.TrailRenderer);
        public override global::System.String ToString() => BindType.FullName;
#if UNITY_EDITOR
        [global::UnityEngine.RuntimeInitializeOnLoadMethod(global::UnityEngine.RuntimeInitializeLoadType.SubsystemRegistration)]
        private static void ResetStaticFields() => s_Metatable = null;
#endif

        private static readonly global::Lua.LuaFunction _LuaTrailRenderer_new = new global::Lua.LuaFunction(".ctor", (_context, _) =>
        {
            global::Lua.LuaValue _lastArg = default;
            global::System.Int32 _lastArgPos = default;
            global::System.Type _expectedType = default;
            var _argCount = _context.ArgumentCount;
            if (_argCount == 1)
            {
                var _ret0 = new global::UnityEngine.TrailRenderer();
                var _factory = _context.GetObjectFactory();
                var _lret0 = _factory.Bind(_ret0);
                var _retCount = _context.Return(_lret0);
                return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
            }
            throw new global::Lua.LuaRuntimeException(_context.Thread, $"{".ctor"}: invalid argument #{_lastArgPos}: {_lastArg} ({_lastArg.Type}), expected: {_expectedType.FullName}", 2);
        });
        private static readonly global::Lua.LuaFunction __index = new(global::Lua.Runtime.Metamethods.Index, (_context, _) =>
        {
            var _this = _context.GetArgument<LuaTrailRendererType>(0);
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
            var _this = _context.GetArgument<LuaTrailRendererType>(0);
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
            var metatable = new global::Lua.LuaTable(0, 5);
            metatable[global::Lua.Runtime.Metamethods.Index] = __index;
            metatable[global::Lua.Runtime.Metamethods.NewIndex] = __newindex;
            metatable[global::Lua.Runtime.Metamethods.Concat] = global::Luny.LuaMetatable.ConcatMetamethod;
            metatable[global::Lua.Runtime.Metamethods.ToString] = global::Luny.LuaMetatable.ToStringMetamethod;
            metatable[global::Lua.Runtime.Metamethods.Call] = _LuaTrailRenderer_new;
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
