
// --------------------------------------------------------------
// GENERATED FILE ----> DO NOT EDIT <---- CHANGES WILL BE LOST !!
// --------------------------------------------------------------

#if UNITY_6000_2_OR_NEWER && !(UNITY_6000_3_OR_NEWER)
#pragma warning disable 0109, 0162, 0168, 0219
using Luny;

namespace Luny.UnityEngine
{
    public sealed class LuaGizmos : global::Luny.ILuaObject<global::UnityEngine.Gizmos>
    {
        public new static global::Lua.LuaValue Bind(global::UnityEngine.Gizmos instance) => new LuaGizmos(instance);
        public new static global::Lua.LuaValue Bind(global::System.Object instance) => Bind((global::UnityEngine.Gizmos)instance);
        public new static global::Lua.LuaValue Bind(global::System.Collections.Generic.IList<global::UnityEngine.Gizmos> instances) =>
            new global::Luny.LuaList<global::UnityEngine.Gizmos>(instances);
        public new static global::Lua.LuaValue Bind(global::System.Collections.Generic.IList<global::System.Object> instances) =>
            new global::Luny.LuaList<global::UnityEngine.Gizmos>(instances);
        private LuaGizmos(global::UnityEngine.Gizmos instance) => m_Instance = instance;
        public static implicit operator global::Lua.LuaValue(LuaGizmos value) => new(value);
        private global::UnityEngine.Gizmos m_Instance;
        public global::UnityEngine.Gizmos Instance => m_Instance;
        public new global::System.Type BindType => typeof(global::UnityEngine.Gizmos);
        private static global::Lua.LuaTable s_Metatable;
        public global::Lua.LuaTable Metatable
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

        private static readonly global::Lua.LuaFunction __index = new(global::Lua.Runtime.Metamethods.Index, (_context, _) =>
        {
            var _this = _context.GetArgument<LuaGizmos>(0);
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
            var _this = _context.GetArgument<LuaGizmos>(0);
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
    public sealed class LuaGizmosType : global::Luny.ILuaStatic
    {
        public static global::Lua.LuaValue Bind() => new LuaGizmosType();
        private LuaGizmosType() {}
        public static implicit operator global::Lua.LuaValue(LuaGizmosType value) => new(value);
        public global::System.Type BindType => typeof(global::UnityEngine.Gizmos);
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

        private static readonly global::Lua.LuaFunction _LuaGizmos_new = new global::Lua.LuaFunction(".ctor", (_context, _) =>
        {
            global::Lua.LuaValue _lastArg = default;
            global::System.Int32 _lastArgPos = default;
            global::System.Type _expectedType = default;
            var _argCount = _context.ArgumentCount;
            if (_argCount == 0)
            {
                var _ret0 = new global::UnityEngine.Gizmos();
                var _factory = _context.GetObjectFactory();
                var _lret0 = _factory.Bind(_ret0);
                var _retCount = _context.Return(_lret0);
                return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
            }
            throw new global::Lua.LuaRuntimeException(_context.Thread, $"{".ctor"}: invalid argument #{_lastArgPos}: {_lastArg} ({_lastArg.Type}), expected: {_expectedType.FullName}", 2);
        });
        private static readonly global::Lua.LuaFunction _LuaGizmos_CalculateLOD = new global::Lua.LuaFunction("CalculateLOD", (_context, _) =>
        {
            global::Lua.LuaValue _lastArg = default;
            global::System.Int32 _lastArgPos = default;
            global::System.Type _expectedType = default;
            var _argCount = _context.ArgumentCount;
            var _arg0 = _lastArg = _argCount > 0 ? _context.GetArgument(0) : global::Lua.LuaValue.Nil;
            _lastArgPos = 0; _expectedType = typeof(global::Luny.UnityEngine.LuaVector3);
            if (_arg0.TryRead<global::Luny.UnityEngine.LuaVector3>(out var _p0_UnityEngine_Vector3))
            {
                var _arg1 = _lastArg = _argCount > 1 ? _context.GetArgument(1) : global::Lua.LuaValue.Nil;
                _lastArgPos = 1; _expectedType = typeof(global::System.Single);
                if (_arg1.TryRead<global::System.Single>(out var _p1_System_Single))
                {
                    if (_argCount == 2)
                    {
                        var position = _p0_UnityEngine_Vector3.Value;
                        var radius = _p1_System_Single;
                        var _ret0 = global::UnityEngine.Gizmos.CalculateLOD(position, radius);
                        var _lret0 = new global::Lua.LuaValue(_ret0);
                        var _retCount = _context.Return(_lret0);
                        return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                    }
                }
            }
            throw new global::Lua.LuaRuntimeException(_context.Thread, $"{"CalculateLOD"}: invalid argument #{_lastArgPos}: {_lastArg} ({_lastArg.Type}), expected: {_expectedType.FullName}", 2);
        });
        private static readonly global::Lua.LuaFunction _LuaGizmos_DrawCube = new global::Lua.LuaFunction("DrawCube", (_context, _) =>
        {
            global::Lua.LuaValue _lastArg = default;
            global::System.Int32 _lastArgPos = default;
            global::System.Type _expectedType = default;
            var _argCount = _context.ArgumentCount;
            var _arg0 = _lastArg = _argCount > 0 ? _context.GetArgument(0) : global::Lua.LuaValue.Nil;
            _lastArgPos = 0; _expectedType = typeof(global::Luny.UnityEngine.LuaVector3);
            if (_arg0.TryRead<global::Luny.UnityEngine.LuaVector3>(out var _p0_UnityEngine_Vector3))
            {
                var _arg1 = _lastArg = _argCount > 1 ? _context.GetArgument(1) : global::Lua.LuaValue.Nil;
                _lastArgPos = 1; _expectedType = typeof(global::Luny.UnityEngine.LuaVector3);
                if (_arg1.TryRead<global::Luny.UnityEngine.LuaVector3>(out var _p1_UnityEngine_Vector3))
                {
                    if (_argCount == 2)
                    {
                        var center = _p0_UnityEngine_Vector3.Value;
                        var size = _p1_UnityEngine_Vector3.Value;
                        global::UnityEngine.Gizmos.DrawCube(center, size);
                        var _retCount = _context.Return();
                        return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                    }
                }
            }
            throw new global::Lua.LuaRuntimeException(_context.Thread, $"{"DrawCube"}: invalid argument #{_lastArgPos}: {_lastArg} ({_lastArg.Type}), expected: {_expectedType.FullName}", 2);
        });
        private static readonly global::Lua.LuaFunction _LuaGizmos_DrawFrustum = new global::Lua.LuaFunction("DrawFrustum", (_context, _) =>
        {
            global::Lua.LuaValue _lastArg = default;
            global::System.Int32 _lastArgPos = default;
            global::System.Type _expectedType = default;
            var _argCount = _context.ArgumentCount;
            var _arg0 = _lastArg = _argCount > 0 ? _context.GetArgument(0) : global::Lua.LuaValue.Nil;
            _lastArgPos = 0; _expectedType = typeof(global::Luny.UnityEngine.LuaVector3);
            if (_arg0.TryRead<global::Luny.UnityEngine.LuaVector3>(out var _p0_UnityEngine_Vector3))
            {
                var _arg1 = _lastArg = _argCount > 1 ? _context.GetArgument(1) : global::Lua.LuaValue.Nil;
                _lastArgPos = 1; _expectedType = typeof(global::System.Single);
                if (_arg1.TryRead<global::System.Single>(out var _p1_System_Single))
                {
                    var _arg2 = _lastArg = _argCount > 2 ? _context.GetArgument(2) : global::Lua.LuaValue.Nil;
                    _lastArgPos = 2; _expectedType = typeof(global::System.Single);
                    if (_arg2.TryRead<global::System.Single>(out var _p2_System_Single))
                    {
                        var _arg3 = _lastArg = _argCount > 3 ? _context.GetArgument(3) : global::Lua.LuaValue.Nil;
                        _lastArgPos = 3; _expectedType = typeof(global::System.Single);
                        if (_arg3.TryRead<global::System.Single>(out var _p3_System_Single))
                        {
                            var _arg4 = _lastArg = _argCount > 4 ? _context.GetArgument(4) : global::Lua.LuaValue.Nil;
                            _lastArgPos = 4; _expectedType = typeof(global::System.Single);
                            if (_arg4.TryRead<global::System.Single>(out var _p4_System_Single))
                            {
                                if (_argCount == 5)
                                {
                                    var center = _p0_UnityEngine_Vector3.Value;
                                    var fov = _p1_System_Single;
                                    var maxRange = _p2_System_Single;
                                    var minRange = _p3_System_Single;
                                    var aspect = _p4_System_Single;
                                    global::UnityEngine.Gizmos.DrawFrustum(center, fov, maxRange, minRange, aspect);
                                    var _retCount = _context.Return();
                                    return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                                }
                            }
                        }
                    }
                }
            }
            throw new global::Lua.LuaRuntimeException(_context.Thread, $"{"DrawFrustum"}: invalid argument #{_lastArgPos}: {_lastArg} ({_lastArg.Type}), expected: {_expectedType.FullName}", 2);
        });
        private static readonly global::Lua.LuaFunction _LuaGizmos_DrawGUITexture = new global::Lua.LuaFunction("DrawGUITexture", (_context, _) =>
        {
            global::Lua.LuaValue _lastArg = default;
            global::System.Int32 _lastArgPos = default;
            global::System.Type _expectedType = default;
            var _argCount = _context.ArgumentCount;
            var _arg0 = _lastArg = _argCount > 0 ? _context.GetArgument(0) : global::Lua.LuaValue.Nil;
            _lastArgPos = 0; _expectedType = typeof(global::Luny.UnityEngine.LuaRect);
            if (_arg0.TryRead<global::Luny.UnityEngine.LuaRect>(out var _p0_UnityEngine_Rect))
            {
                var _arg1 = _lastArg = _argCount > 1 ? _context.GetArgument(1) : global::Lua.LuaValue.Nil;
                _lastArgPos = 1; _expectedType = typeof(global::Luny.UnityEngine.LuaTexture);
                if (_arg1.TryRead<global::Luny.UnityEngine.LuaTexture>(out var _p1_UnityEngine_Texture))
                {
                    if (_argCount == 2)
                    {
                        var screenRect = _p0_UnityEngine_Rect.Value;
                        var texture = _p1_UnityEngine_Texture.Instance;
                        global::UnityEngine.Gizmos.DrawGUITexture(screenRect, texture);
                        var _retCount = _context.Return();
                        return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                    }
                    var _arg2 = _lastArg = _argCount > 2 ? _context.GetArgument(2) : global::Lua.LuaValue.Nil;
                    _lastArgPos = 2; _expectedType = typeof(global::Luny.UnityEngine.LuaMaterial);
                    if (_arg2.TryRead<global::Luny.UnityEngine.LuaMaterial>(out var _p2_UnityEngine_Material))
                    {
                        if (_argCount == 3)
                        {
                            var screenRect = _p0_UnityEngine_Rect.Value;
                            var texture = _p1_UnityEngine_Texture.Instance;
                            var mat = _p2_UnityEngine_Material.Instance;
                            global::UnityEngine.Gizmos.DrawGUITexture(screenRect, texture, mat);
                            var _retCount = _context.Return();
                            return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                        }
                    }
                    _lastArgPos = 2; _expectedType = typeof(global::System.Int32);
                    if (_arg2.TryRead<global::System.Int32>(out var _p2_System_Int32))
                    {
                        var _arg3 = _lastArg = _argCount > 3 ? _context.GetArgument(3) : global::Lua.LuaValue.Nil;
                        _lastArgPos = 3; _expectedType = typeof(global::System.Int32);
                        if (_arg3.TryRead<global::System.Int32>(out var _p3_System_Int32))
                        {
                            var _arg4 = _lastArg = _argCount > 4 ? _context.GetArgument(4) : global::Lua.LuaValue.Nil;
                            _lastArgPos = 4; _expectedType = typeof(global::System.Int32);
                            if (_arg4.TryRead<global::System.Int32>(out var _p4_System_Int32))
                            {
                                var _arg5 = _lastArg = _argCount > 5 ? _context.GetArgument(5) : global::Lua.LuaValue.Nil;
                                _lastArgPos = 5; _expectedType = typeof(global::System.Int32);
                                if (_arg5.TryRead<global::System.Int32>(out var _p5_System_Int32))
                                {
                                    if (_argCount == 6)
                                    {
                                        var screenRect = _p0_UnityEngine_Rect.Value;
                                        var texture = _p1_UnityEngine_Texture.Instance;
                                        var leftBorder = _p2_System_Int32;
                                        var rightBorder = _p3_System_Int32;
                                        var topBorder = _p4_System_Int32;
                                        var bottomBorder = _p5_System_Int32;
                                        global::UnityEngine.Gizmos.DrawGUITexture(screenRect, texture, leftBorder, rightBorder, topBorder, bottomBorder);
                                        var _retCount = _context.Return();
                                        return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                                    }
                                    var _arg6 = _lastArg = _argCount > 6 ? _context.GetArgument(6) : global::Lua.LuaValue.Nil;
                                    _lastArgPos = 6; _expectedType = typeof(global::Luny.UnityEngine.LuaMaterial);
                                    if (_arg6.TryRead<global::Luny.UnityEngine.LuaMaterial>(out var _p6_UnityEngine_Material))
                                    {
                                        if (_argCount == 7)
                                        {
                                            var screenRect = _p0_UnityEngine_Rect.Value;
                                            var texture = _p1_UnityEngine_Texture.Instance;
                                            var leftBorder = _p2_System_Int32;
                                            var rightBorder = _p3_System_Int32;
                                            var topBorder = _p4_System_Int32;
                                            var bottomBorder = _p5_System_Int32;
                                            var mat = _p6_UnityEngine_Material.Instance;
                                            global::UnityEngine.Gizmos.DrawGUITexture(screenRect, texture, leftBorder, rightBorder, topBorder, bottomBorder, mat);
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
            throw new global::Lua.LuaRuntimeException(_context.Thread, $"{"DrawGUITexture"}: invalid argument #{_lastArgPos}: {_lastArg} ({_lastArg.Type}), expected: {_expectedType.FullName}", 2);
        });
        private static readonly global::Lua.LuaFunction _LuaGizmos_DrawIcon = new global::Lua.LuaFunction("DrawIcon", (_context, _) =>
        {
            global::Lua.LuaValue _lastArg = default;
            global::System.Int32 _lastArgPos = default;
            global::System.Type _expectedType = default;
            var _argCount = _context.ArgumentCount;
            var _arg0 = _lastArg = _argCount > 0 ? _context.GetArgument(0) : global::Lua.LuaValue.Nil;
            _lastArgPos = 0; _expectedType = typeof(global::Luny.UnityEngine.LuaVector3);
            if (_arg0.TryRead<global::Luny.UnityEngine.LuaVector3>(out var _p0_UnityEngine_Vector3))
            {
                var _arg1 = _lastArg = _argCount > 1 ? _context.GetArgument(1) : global::Lua.LuaValue.Nil;
                _lastArgPos = 1; _expectedType = typeof(global::System.String);
                if (_arg1.TryRead<global::System.String>(out var _p1_System_String))
                {
                    if (_argCount == 2)
                    {
                        var center = _p0_UnityEngine_Vector3.Value;
                        var name = _p1_System_String;
                        global::UnityEngine.Gizmos.DrawIcon(center, name);
                        var _retCount = _context.Return();
                        return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                    }
                    var _arg2 = _lastArg = _argCount > 2 ? _context.GetArgument(2) : global::Lua.LuaValue.Nil;
                    _lastArgPos = 2; _expectedType = typeof(global::System.Boolean);
                    if (_arg2.TryRead<global::System.Boolean>(out var _p2_System_Boolean))
                    {
                        if (_argCount == 3)
                        {
                            var center = _p0_UnityEngine_Vector3.Value;
                            var name = _p1_System_String;
                            var allowScaling = _p2_System_Boolean;
                            global::UnityEngine.Gizmos.DrawIcon(center, name, allowScaling);
                            var _retCount = _context.Return();
                            return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                        }
                        var _arg3 = _lastArg = _argCount > 3 ? _context.GetArgument(3) : global::Lua.LuaValue.Nil;
                        _lastArgPos = 3; _expectedType = typeof(global::Luny.UnityEngine.LuaColor);
                        if (_arg3.TryRead<global::Luny.UnityEngine.LuaColor>(out var _p3_UnityEngine_Color))
                        {
                            if (_argCount == 4)
                            {
                                var center = _p0_UnityEngine_Vector3.Value;
                                var name = _p1_System_String;
                                var allowScaling = _p2_System_Boolean;
                                var tint = _p3_UnityEngine_Color.Value;
                                global::UnityEngine.Gizmos.DrawIcon(center, name, allowScaling, tint);
                                var _retCount = _context.Return();
                                return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                            }
                        }
                    }
                }
            }
            throw new global::Lua.LuaRuntimeException(_context.Thread, $"{"DrawIcon"}: invalid argument #{_lastArgPos}: {_lastArg} ({_lastArg.Type}), expected: {_expectedType.FullName}", 2);
        });
        private static readonly global::Lua.LuaFunction _LuaGizmos_DrawLine = new global::Lua.LuaFunction("DrawLine", (_context, _) =>
        {
            global::Lua.LuaValue _lastArg = default;
            global::System.Int32 _lastArgPos = default;
            global::System.Type _expectedType = default;
            var _argCount = _context.ArgumentCount;
            var _arg0 = _lastArg = _argCount > 0 ? _context.GetArgument(0) : global::Lua.LuaValue.Nil;
            _lastArgPos = 0; _expectedType = typeof(global::Luny.UnityEngine.LuaVector3);
            if (_arg0.TryRead<global::Luny.UnityEngine.LuaVector3>(out var _p0_UnityEngine_Vector3))
            {
                var _arg1 = _lastArg = _argCount > 1 ? _context.GetArgument(1) : global::Lua.LuaValue.Nil;
                _lastArgPos = 1; _expectedType = typeof(global::Luny.UnityEngine.LuaVector3);
                if (_arg1.TryRead<global::Luny.UnityEngine.LuaVector3>(out var _p1_UnityEngine_Vector3))
                {
                    if (_argCount == 2)
                    {
                        var from = _p0_UnityEngine_Vector3.Value;
                        var to = _p1_UnityEngine_Vector3.Value;
                        global::UnityEngine.Gizmos.DrawLine(from, to);
                        var _retCount = _context.Return();
                        return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                    }
                }
            }
            throw new global::Lua.LuaRuntimeException(_context.Thread, $"{"DrawLine"}: invalid argument #{_lastArgPos}: {_lastArg} ({_lastArg.Type}), expected: {_expectedType.FullName}", 2);
        });
        private static readonly global::Lua.LuaFunction _LuaGizmos_DrawMesh = new global::Lua.LuaFunction("DrawMesh", (_context, _) =>
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
                    global::UnityEngine.Gizmos.DrawMesh(mesh);
                    var _retCount = _context.Return();
                    return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                }
                var _arg1 = _lastArg = _argCount > 1 ? _context.GetArgument(1) : global::Lua.LuaValue.Nil;
                _lastArgPos = 1; _expectedType = typeof(global::System.Int32);
                if (_arg1.TryRead<global::System.Int32>(out var _p1_System_Int32))
                {
                    if (_argCount == 2)
                    {
                        var mesh = _p0_UnityEngine_Mesh.Instance;
                        var submeshIndex = _p1_System_Int32;
                        global::UnityEngine.Gizmos.DrawMesh(mesh, submeshIndex);
                        var _retCount = _context.Return();
                        return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                    }
                    var _arg2 = _lastArg = _argCount > 2 ? _context.GetArgument(2) : global::Lua.LuaValue.Nil;
                    _lastArgPos = 2; _expectedType = typeof(global::Luny.UnityEngine.LuaVector3);
                    if (_arg2.TryRead<global::Luny.UnityEngine.LuaVector3>(out var _p2_UnityEngine_Vector3))
                    {
                        if (_argCount == 3)
                        {
                            var mesh = _p0_UnityEngine_Mesh.Instance;
                            var submeshIndex = _p1_System_Int32;
                            var position = _p2_UnityEngine_Vector3.Value;
                            global::UnityEngine.Gizmos.DrawMesh(mesh, submeshIndex, position);
                            var _retCount = _context.Return();
                            return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                        }
                        var _arg3 = _lastArg = _argCount > 3 ? _context.GetArgument(3) : global::Lua.LuaValue.Nil;
                        _lastArgPos = 3; _expectedType = typeof(global::Luny.UnityEngine.LuaQuaternion);
                        if (_arg3.TryRead<global::Luny.UnityEngine.LuaQuaternion>(out var _p3_UnityEngine_Quaternion))
                        {
                            if (_argCount == 4)
                            {
                                var mesh = _p0_UnityEngine_Mesh.Instance;
                                var submeshIndex = _p1_System_Int32;
                                var position = _p2_UnityEngine_Vector3.Value;
                                var rotation = _p3_UnityEngine_Quaternion.Value;
                                global::UnityEngine.Gizmos.DrawMesh(mesh, submeshIndex, position, rotation);
                                var _retCount = _context.Return();
                                return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                            }
                            var _arg4 = _lastArg = _argCount > 4 ? _context.GetArgument(4) : global::Lua.LuaValue.Nil;
                            _lastArgPos = 4; _expectedType = typeof(global::Luny.UnityEngine.LuaVector3);
                            if (_arg4.TryRead<global::Luny.UnityEngine.LuaVector3>(out var _p4_UnityEngine_Vector3))
                            {
                                if (_argCount == 5)
                                {
                                    var mesh = _p0_UnityEngine_Mesh.Instance;
                                    var submeshIndex = _p1_System_Int32;
                                    var position = _p2_UnityEngine_Vector3.Value;
                                    var rotation = _p3_UnityEngine_Quaternion.Value;
                                    var scale = _p4_UnityEngine_Vector3.Value;
                                    global::UnityEngine.Gizmos.DrawMesh(mesh, submeshIndex, position, rotation, scale);
                                    var _retCount = _context.Return();
                                    return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                                }
                            }
                        }
                    }
                }
                _lastArgPos = 1; _expectedType = typeof(global::Luny.UnityEngine.LuaVector3);
                if (_arg1.TryRead<global::Luny.UnityEngine.LuaVector3>(out var _p1_UnityEngine_Vector3))
                {
                    if (_argCount == 2)
                    {
                        var mesh = _p0_UnityEngine_Mesh.Instance;
                        var position = _p1_UnityEngine_Vector3.Value;
                        global::UnityEngine.Gizmos.DrawMesh(mesh, position);
                        var _retCount = _context.Return();
                        return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                    }
                    var _arg2 = _lastArg = _argCount > 2 ? _context.GetArgument(2) : global::Lua.LuaValue.Nil;
                    _lastArgPos = 2; _expectedType = typeof(global::Luny.UnityEngine.LuaQuaternion);
                    if (_arg2.TryRead<global::Luny.UnityEngine.LuaQuaternion>(out var _p2_UnityEngine_Quaternion))
                    {
                        if (_argCount == 3)
                        {
                            var mesh = _p0_UnityEngine_Mesh.Instance;
                            var position = _p1_UnityEngine_Vector3.Value;
                            var rotation = _p2_UnityEngine_Quaternion.Value;
                            global::UnityEngine.Gizmos.DrawMesh(mesh, position, rotation);
                            var _retCount = _context.Return();
                            return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                        }
                        var _arg3 = _lastArg = _argCount > 3 ? _context.GetArgument(3) : global::Lua.LuaValue.Nil;
                        _lastArgPos = 3; _expectedType = typeof(global::Luny.UnityEngine.LuaVector3);
                        if (_arg3.TryRead<global::Luny.UnityEngine.LuaVector3>(out var _p3_UnityEngine_Vector3))
                        {
                            if (_argCount == 4)
                            {
                                var mesh = _p0_UnityEngine_Mesh.Instance;
                                var position = _p1_UnityEngine_Vector3.Value;
                                var rotation = _p2_UnityEngine_Quaternion.Value;
                                var scale = _p3_UnityEngine_Vector3.Value;
                                global::UnityEngine.Gizmos.DrawMesh(mesh, position, rotation, scale);
                                var _retCount = _context.Return();
                                return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                            }
                        }
                    }
                }
            }
            throw new global::Lua.LuaRuntimeException(_context.Thread, $"{"DrawMesh"}: invalid argument #{_lastArgPos}: {_lastArg} ({_lastArg.Type}), expected: {_expectedType.FullName}", 2);
        });
        private static readonly global::Lua.LuaFunction _LuaGizmos_DrawRay = new global::Lua.LuaFunction("DrawRay", (_context, _) =>
        {
            global::Lua.LuaValue _lastArg = default;
            global::System.Int32 _lastArgPos = default;
            global::System.Type _expectedType = default;
            var _argCount = _context.ArgumentCount;
            var _arg0 = _lastArg = _argCount > 0 ? _context.GetArgument(0) : global::Lua.LuaValue.Nil;
            _lastArgPos = 0; _expectedType = typeof(global::Luny.UnityEngine.LuaRay);
            if (_arg0.TryRead<global::Luny.UnityEngine.LuaRay>(out var _p0_UnityEngine_Ray))
            {
                if (_argCount == 1)
                {
                    var r = _p0_UnityEngine_Ray.Value;
                    global::UnityEngine.Gizmos.DrawRay(r);
                    var _retCount = _context.Return();
                    return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                }
            }
            _lastArgPos = 0; _expectedType = typeof(global::Luny.UnityEngine.LuaVector3);
            if (_arg0.TryRead<global::Luny.UnityEngine.LuaVector3>(out var _p0_UnityEngine_Vector3))
            {
                var _arg1 = _lastArg = _argCount > 1 ? _context.GetArgument(1) : global::Lua.LuaValue.Nil;
                _lastArgPos = 1; _expectedType = typeof(global::Luny.UnityEngine.LuaVector3);
                if (_arg1.TryRead<global::Luny.UnityEngine.LuaVector3>(out var _p1_UnityEngine_Vector3))
                {
                    if (_argCount == 2)
                    {
                        var from = _p0_UnityEngine_Vector3.Value;
                        var direction = _p1_UnityEngine_Vector3.Value;
                        global::UnityEngine.Gizmos.DrawRay(from, direction);
                        var _retCount = _context.Return();
                        return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                    }
                }
            }
            throw new global::Lua.LuaRuntimeException(_context.Thread, $"{"DrawRay"}: invalid argument #{_lastArgPos}: {_lastArg} ({_lastArg.Type}), expected: {_expectedType.FullName}", 2);
        });
        private static readonly global::Lua.LuaFunction _LuaGizmos_DrawSphere = new global::Lua.LuaFunction("DrawSphere", (_context, _) =>
        {
            global::Lua.LuaValue _lastArg = default;
            global::System.Int32 _lastArgPos = default;
            global::System.Type _expectedType = default;
            var _argCount = _context.ArgumentCount;
            var _arg0 = _lastArg = _argCount > 0 ? _context.GetArgument(0) : global::Lua.LuaValue.Nil;
            _lastArgPos = 0; _expectedType = typeof(global::Luny.UnityEngine.LuaVector3);
            if (_arg0.TryRead<global::Luny.UnityEngine.LuaVector3>(out var _p0_UnityEngine_Vector3))
            {
                var _arg1 = _lastArg = _argCount > 1 ? _context.GetArgument(1) : global::Lua.LuaValue.Nil;
                _lastArgPos = 1; _expectedType = typeof(global::System.Single);
                if (_arg1.TryRead<global::System.Single>(out var _p1_System_Single))
                {
                    if (_argCount == 2)
                    {
                        var center = _p0_UnityEngine_Vector3.Value;
                        var radius = _p1_System_Single;
                        global::UnityEngine.Gizmos.DrawSphere(center, radius);
                        var _retCount = _context.Return();
                        return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                    }
                }
            }
            throw new global::Lua.LuaRuntimeException(_context.Thread, $"{"DrawSphere"}: invalid argument #{_lastArgPos}: {_lastArg} ({_lastArg.Type}), expected: {_expectedType.FullName}", 2);
        });
        private static readonly global::Lua.LuaFunction _LuaGizmos_DrawWireCube = new global::Lua.LuaFunction("DrawWireCube", (_context, _) =>
        {
            global::Lua.LuaValue _lastArg = default;
            global::System.Int32 _lastArgPos = default;
            global::System.Type _expectedType = default;
            var _argCount = _context.ArgumentCount;
            var _arg0 = _lastArg = _argCount > 0 ? _context.GetArgument(0) : global::Lua.LuaValue.Nil;
            _lastArgPos = 0; _expectedType = typeof(global::Luny.UnityEngine.LuaVector3);
            if (_arg0.TryRead<global::Luny.UnityEngine.LuaVector3>(out var _p0_UnityEngine_Vector3))
            {
                var _arg1 = _lastArg = _argCount > 1 ? _context.GetArgument(1) : global::Lua.LuaValue.Nil;
                _lastArgPos = 1; _expectedType = typeof(global::Luny.UnityEngine.LuaVector3);
                if (_arg1.TryRead<global::Luny.UnityEngine.LuaVector3>(out var _p1_UnityEngine_Vector3))
                {
                    if (_argCount == 2)
                    {
                        var center = _p0_UnityEngine_Vector3.Value;
                        var size = _p1_UnityEngine_Vector3.Value;
                        global::UnityEngine.Gizmos.DrawWireCube(center, size);
                        var _retCount = _context.Return();
                        return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                    }
                }
            }
            throw new global::Lua.LuaRuntimeException(_context.Thread, $"{"DrawWireCube"}: invalid argument #{_lastArgPos}: {_lastArg} ({_lastArg.Type}), expected: {_expectedType.FullName}", 2);
        });
        private static readonly global::Lua.LuaFunction _LuaGizmos_DrawWireMesh = new global::Lua.LuaFunction("DrawWireMesh", (_context, _) =>
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
                    global::UnityEngine.Gizmos.DrawWireMesh(mesh);
                    var _retCount = _context.Return();
                    return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                }
                var _arg1 = _lastArg = _argCount > 1 ? _context.GetArgument(1) : global::Lua.LuaValue.Nil;
                _lastArgPos = 1; _expectedType = typeof(global::System.Int32);
                if (_arg1.TryRead<global::System.Int32>(out var _p1_System_Int32))
                {
                    if (_argCount == 2)
                    {
                        var mesh = _p0_UnityEngine_Mesh.Instance;
                        var submeshIndex = _p1_System_Int32;
                        global::UnityEngine.Gizmos.DrawWireMesh(mesh, submeshIndex);
                        var _retCount = _context.Return();
                        return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                    }
                    var _arg2 = _lastArg = _argCount > 2 ? _context.GetArgument(2) : global::Lua.LuaValue.Nil;
                    _lastArgPos = 2; _expectedType = typeof(global::Luny.UnityEngine.LuaVector3);
                    if (_arg2.TryRead<global::Luny.UnityEngine.LuaVector3>(out var _p2_UnityEngine_Vector3))
                    {
                        if (_argCount == 3)
                        {
                            var mesh = _p0_UnityEngine_Mesh.Instance;
                            var submeshIndex = _p1_System_Int32;
                            var position = _p2_UnityEngine_Vector3.Value;
                            global::UnityEngine.Gizmos.DrawWireMesh(mesh, submeshIndex, position);
                            var _retCount = _context.Return();
                            return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                        }
                        var _arg3 = _lastArg = _argCount > 3 ? _context.GetArgument(3) : global::Lua.LuaValue.Nil;
                        _lastArgPos = 3; _expectedType = typeof(global::Luny.UnityEngine.LuaQuaternion);
                        if (_arg3.TryRead<global::Luny.UnityEngine.LuaQuaternion>(out var _p3_UnityEngine_Quaternion))
                        {
                            if (_argCount == 4)
                            {
                                var mesh = _p0_UnityEngine_Mesh.Instance;
                                var submeshIndex = _p1_System_Int32;
                                var position = _p2_UnityEngine_Vector3.Value;
                                var rotation = _p3_UnityEngine_Quaternion.Value;
                                global::UnityEngine.Gizmos.DrawWireMesh(mesh, submeshIndex, position, rotation);
                                var _retCount = _context.Return();
                                return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                            }
                            var _arg4 = _lastArg = _argCount > 4 ? _context.GetArgument(4) : global::Lua.LuaValue.Nil;
                            _lastArgPos = 4; _expectedType = typeof(global::Luny.UnityEngine.LuaVector3);
                            if (_arg4.TryRead<global::Luny.UnityEngine.LuaVector3>(out var _p4_UnityEngine_Vector3))
                            {
                                if (_argCount == 5)
                                {
                                    var mesh = _p0_UnityEngine_Mesh.Instance;
                                    var submeshIndex = _p1_System_Int32;
                                    var position = _p2_UnityEngine_Vector3.Value;
                                    var rotation = _p3_UnityEngine_Quaternion.Value;
                                    var scale = _p4_UnityEngine_Vector3.Value;
                                    global::UnityEngine.Gizmos.DrawWireMesh(mesh, submeshIndex, position, rotation, scale);
                                    var _retCount = _context.Return();
                                    return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                                }
                            }
                        }
                    }
                }
                _lastArgPos = 1; _expectedType = typeof(global::Luny.UnityEngine.LuaVector3);
                if (_arg1.TryRead<global::Luny.UnityEngine.LuaVector3>(out var _p1_UnityEngine_Vector3))
                {
                    if (_argCount == 2)
                    {
                        var mesh = _p0_UnityEngine_Mesh.Instance;
                        var position = _p1_UnityEngine_Vector3.Value;
                        global::UnityEngine.Gizmos.DrawWireMesh(mesh, position);
                        var _retCount = _context.Return();
                        return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                    }
                    var _arg2 = _lastArg = _argCount > 2 ? _context.GetArgument(2) : global::Lua.LuaValue.Nil;
                    _lastArgPos = 2; _expectedType = typeof(global::Luny.UnityEngine.LuaQuaternion);
                    if (_arg2.TryRead<global::Luny.UnityEngine.LuaQuaternion>(out var _p2_UnityEngine_Quaternion))
                    {
                        if (_argCount == 3)
                        {
                            var mesh = _p0_UnityEngine_Mesh.Instance;
                            var position = _p1_UnityEngine_Vector3.Value;
                            var rotation = _p2_UnityEngine_Quaternion.Value;
                            global::UnityEngine.Gizmos.DrawWireMesh(mesh, position, rotation);
                            var _retCount = _context.Return();
                            return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                        }
                        var _arg3 = _lastArg = _argCount > 3 ? _context.GetArgument(3) : global::Lua.LuaValue.Nil;
                        _lastArgPos = 3; _expectedType = typeof(global::Luny.UnityEngine.LuaVector3);
                        if (_arg3.TryRead<global::Luny.UnityEngine.LuaVector3>(out var _p3_UnityEngine_Vector3))
                        {
                            if (_argCount == 4)
                            {
                                var mesh = _p0_UnityEngine_Mesh.Instance;
                                var position = _p1_UnityEngine_Vector3.Value;
                                var rotation = _p2_UnityEngine_Quaternion.Value;
                                var scale = _p3_UnityEngine_Vector3.Value;
                                global::UnityEngine.Gizmos.DrawWireMesh(mesh, position, rotation, scale);
                                var _retCount = _context.Return();
                                return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                            }
                        }
                    }
                }
            }
            throw new global::Lua.LuaRuntimeException(_context.Thread, $"{"DrawWireMesh"}: invalid argument #{_lastArgPos}: {_lastArg} ({_lastArg.Type}), expected: {_expectedType.FullName}", 2);
        });
        private static readonly global::Lua.LuaFunction _LuaGizmos_DrawWireSphere = new global::Lua.LuaFunction("DrawWireSphere", (_context, _) =>
        {
            global::Lua.LuaValue _lastArg = default;
            global::System.Int32 _lastArgPos = default;
            global::System.Type _expectedType = default;
            var _argCount = _context.ArgumentCount;
            var _arg0 = _lastArg = _argCount > 0 ? _context.GetArgument(0) : global::Lua.LuaValue.Nil;
            _lastArgPos = 0; _expectedType = typeof(global::Luny.UnityEngine.LuaVector3);
            if (_arg0.TryRead<global::Luny.UnityEngine.LuaVector3>(out var _p0_UnityEngine_Vector3))
            {
                var _arg1 = _lastArg = _argCount > 1 ? _context.GetArgument(1) : global::Lua.LuaValue.Nil;
                _lastArgPos = 1; _expectedType = typeof(global::System.Single);
                if (_arg1.TryRead<global::System.Single>(out var _p1_System_Single))
                {
                    if (_argCount == 2)
                    {
                        var center = _p0_UnityEngine_Vector3.Value;
                        var radius = _p1_System_Single;
                        global::UnityEngine.Gizmos.DrawWireSphere(center, radius);
                        var _retCount = _context.Return();
                        return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                    }
                }
            }
            throw new global::Lua.LuaRuntimeException(_context.Thread, $"{"DrawWireSphere"}: invalid argument #{_lastArgPos}: {_lastArg} ({_lastArg.Type}), expected: {_expectedType.FullName}", 2);
        });
        private static readonly global::Lua.LuaFunction __index = new(global::Lua.Runtime.Metamethods.Index, (_context, _) =>
        {
            var _this = _context.GetArgument<LuaGizmosType>(0);
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
            var _this = _context.GetArgument<LuaGizmosType>(0);
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
                case "new": _value = _LuaGizmos_new; return true;
                case "CalculateLOD": _value = _LuaGizmos_CalculateLOD; return true;
                case "DrawCube": _value = _LuaGizmos_DrawCube; return true;
                case "DrawFrustum": _value = _LuaGizmos_DrawFrustum; return true;
                case "DrawGUITexture": _value = _LuaGizmos_DrawGUITexture; return true;
                case "DrawIcon": _value = _LuaGizmos_DrawIcon; return true;
                case "DrawLine": _value = _LuaGizmos_DrawLine; return true;
                case "DrawMesh": _value = _LuaGizmos_DrawMesh; return true;
                case "DrawRay": _value = _LuaGizmos_DrawRay; return true;
                case "DrawSphere": _value = _LuaGizmos_DrawSphere; return true;
                case "DrawWireCube": _value = _LuaGizmos_DrawWireCube; return true;
                case "DrawWireMesh": _value = _LuaGizmos_DrawWireMesh; return true;
                case "DrawWireSphere": _value = _LuaGizmos_DrawWireSphere; return true;
                case "color": _value = global::Luny.UnityEngine.LuaColor.Bind(global::UnityEngine.Gizmos.color); return true;
                case "exposure": _value = _factory.Bind(global::UnityEngine.Gizmos.exposure); return true;
                case "matrix": _value = global::Luny.UnityEngine.LuaMatrix4x4.Bind(global::UnityEngine.Gizmos.matrix); return true;
                case "probeSize": _value = new global::Lua.LuaValue(global::UnityEngine.Gizmos.probeSize); return true;
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
                case "color": global::UnityEngine.Gizmos.color = _value.Read<global::Luny.UnityEngine.LuaColor>().Value;  return true;
                case "exposure": global::UnityEngine.Gizmos.exposure = _value.Read<global::Luny.UnityEngine.LuaTexture>().Instance;  return true;
                case "matrix": global::UnityEngine.Gizmos.matrix = _value.Read<global::Luny.UnityEngine.LuaMatrix4x4>().Value;  return true;
                default: return false;
            }
        }
    }
}
#pragma warning restore 0109, 0162, 0168, 0219
#endif
