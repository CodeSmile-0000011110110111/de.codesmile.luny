
// --------------------------------------------------------------
// GENERATED FILE ----> DO NOT EDIT <---- CHANGES WILL BE LOST !!
// --------------------------------------------------------------

#if UNITY_6000_0_OR_NEWER && !(UNITY_6000_1_OR_NEWER)
#pragma warning disable 0109, 0162, 0168, 0219
using Luny;

namespace Luny.UnityEngine
{
    public sealed class LuaSprite : global::Luny.UnityEngine.LuaUnityObject, global::Luny.ILuaObject<global::UnityEngine.Sprite>
    {
        public new static global::Lua.LuaValue Bind(global::UnityEngine.Sprite instance) => new LuaSprite(instance);
        public new static global::Lua.LuaValue Bind(global::System.Object instance) => Bind((global::UnityEngine.Sprite)instance);
        public new static global::Lua.LuaValue Bind(global::System.Collections.Generic.IList<global::UnityEngine.Sprite> instances) =>
            new global::Luny.LuaList<global::UnityEngine.Sprite>(instances);
        public new static global::Lua.LuaValue Bind(global::System.Collections.Generic.IList<global::System.Object> instances) =>
            new global::Luny.LuaList<global::UnityEngine.Sprite>(instances);
        private LuaSprite(global::UnityEngine.Sprite instance) : base(instance) {}
        public static implicit operator global::Lua.LuaValue(LuaSprite value) => new(value);
        public new global::UnityEngine.Sprite Instance => (global::UnityEngine.Sprite)m_Instance;
        public new global::System.Type BindType => typeof(global::UnityEngine.Sprite);
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

        private static readonly global::Lua.LuaFunction _LuaSprite_AddScriptableObject = new global::Lua.LuaFunction("AddScriptableObject", (_context, _) =>
        {
            global::Lua.LuaValue _lastArg = default;
            global::System.Int32 _lastArgPos = default;
            global::System.Type _expectedType = default;
            var _argCount = _context.ArgumentCount;
            var _this = _context.GetArgument<LuaSprite>(0);
            var _arg0 = _lastArg = _argCount > 1 ? _context.GetArgument(1) : global::Lua.LuaValue.Nil;
            _lastArgPos = 0; _expectedType = typeof(global::Luny.UnityEngine.LuaScriptableObject);
            if (_arg0.TryRead<global::Luny.UnityEngine.LuaScriptableObject>(out var _p0_UnityEngine_ScriptableObject))
            {
                if (_argCount == 2)
                {
                    var obj = _p0_UnityEngine_ScriptableObject.Instance;
                    var _ret0 = _this.Instance.AddScriptableObject(obj);
                    var _lret0 = new global::Lua.LuaValue(_ret0);
                    var _retCount = _context.Return(_lret0);
                    return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                }
            }
            throw new global::Lua.LuaRuntimeException(_context.Thread, $"{"AddScriptableObject"}: invalid argument #{_lastArgPos}: {_lastArg} ({_lastArg.Type}), expected: {_expectedType.FullName}", 2);
        });
        private static readonly global::Lua.LuaFunction _LuaSprite_GetPhysicsShapeCount = new global::Lua.LuaFunction("GetPhysicsShapeCount", (_context, _) =>
        {
            global::Lua.LuaValue _lastArg = default;
            global::System.Int32 _lastArgPos = default;
            global::System.Type _expectedType = default;
            var _argCount = _context.ArgumentCount;
            var _this = _context.GetArgument<LuaSprite>(0);
            if (_argCount == 1)
            {
                var _ret0 = _this.Instance.GetPhysicsShapeCount();
                var _lret0 = new global::Lua.LuaValue(_ret0);
                var _retCount = _context.Return(_lret0);
                return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
            }
            throw new global::Lua.LuaRuntimeException(_context.Thread, $"{"GetPhysicsShapeCount"}: invalid argument #{_lastArgPos}: {_lastArg} ({_lastArg.Type}), expected: {_expectedType.FullName}", 2);
        });
        private static readonly global::Lua.LuaFunction _LuaSprite_GetPhysicsShapePointCount = new global::Lua.LuaFunction("GetPhysicsShapePointCount", (_context, _) =>
        {
            global::Lua.LuaValue _lastArg = default;
            global::System.Int32 _lastArgPos = default;
            global::System.Type _expectedType = default;
            var _argCount = _context.ArgumentCount;
            var _this = _context.GetArgument<LuaSprite>(0);
            var _arg0 = _lastArg = _argCount > 1 ? _context.GetArgument(1) : global::Lua.LuaValue.Nil;
            _lastArgPos = 0; _expectedType = typeof(global::System.Int32);
            if (_arg0.TryRead<global::System.Int32>(out var _p0_System_Int32))
            {
                if (_argCount == 2)
                {
                    var shapeIdx = _p0_System_Int32;
                    var _ret0 = _this.Instance.GetPhysicsShapePointCount(shapeIdx);
                    var _lret0 = new global::Lua.LuaValue(_ret0);
                    var _retCount = _context.Return(_lret0);
                    return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                }
            }
            throw new global::Lua.LuaRuntimeException(_context.Thread, $"{"GetPhysicsShapePointCount"}: invalid argument #{_lastArgPos}: {_lastArg} ({_lastArg.Type}), expected: {_expectedType.FullName}", 2);
        });
        private static readonly global::Lua.LuaFunction _LuaSprite_GetScriptableObjects = new global::Lua.LuaFunction("GetScriptableObjects", (_context, _) =>
        {
            global::Lua.LuaValue _lastArg = default;
            global::System.Int32 _lastArgPos = default;
            global::System.Type _expectedType = default;
            var _argCount = _context.ArgumentCount;
            var _this = _context.GetArgument<LuaSprite>(0);
            var _arg0 = _lastArg = _argCount > 1 ? _context.GetArgument(1) : global::Lua.LuaValue.Nil;
            _lastArgPos = 0; _expectedType = typeof(global::UnityEngine.ScriptableObject[]);
            if (_arg0.TryReadArray<global::UnityEngine.ScriptableObject>(out var _p0_UnityEngine_ScriptableObjectArray))
            {
                if (_argCount == 2)
                {
                    var scriptableObjects = _p0_UnityEngine_ScriptableObjectArray;
                    var _ret0 = _this.Instance.GetScriptableObjects(scriptableObjects);
                    var _lret0 = new global::Lua.LuaValue(_ret0);
                    var _retCount = _context.Return(_lret0);
                    return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                }
            }
            throw new global::Lua.LuaRuntimeException(_context.Thread, $"{"GetScriptableObjects"}: invalid argument #{_lastArgPos}: {_lastArg} ({_lastArg.Type}), expected: {_expectedType.FullName}", 2);
        });
        private static readonly global::Lua.LuaFunction _LuaSprite_GetScriptableObjectsCount = new global::Lua.LuaFunction("GetScriptableObjectsCount", (_context, _) =>
        {
            global::Lua.LuaValue _lastArg = default;
            global::System.Int32 _lastArgPos = default;
            global::System.Type _expectedType = default;
            var _argCount = _context.ArgumentCount;
            var _this = _context.GetArgument<LuaSprite>(0);
            if (_argCount == 1)
            {
                var _ret0 = _this.Instance.GetScriptableObjectsCount();
                var _lret0 = new global::Lua.LuaValue(_ret0);
                var _retCount = _context.Return(_lret0);
                return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
            }
            throw new global::Lua.LuaRuntimeException(_context.Thread, $"{"GetScriptableObjectsCount"}: invalid argument #{_lastArgPos}: {_lastArg} ({_lastArg.Type}), expected: {_expectedType.FullName}", 2);
        });
        private static readonly global::Lua.LuaFunction _LuaSprite_GetSecondaryTextureCount = new global::Lua.LuaFunction("GetSecondaryTextureCount", (_context, _) =>
        {
            global::Lua.LuaValue _lastArg = default;
            global::System.Int32 _lastArgPos = default;
            global::System.Type _expectedType = default;
            var _argCount = _context.ArgumentCount;
            var _this = _context.GetArgument<LuaSprite>(0);
            if (_argCount == 1)
            {
                var _ret0 = _this.Instance.GetSecondaryTextureCount();
                var _lret0 = new global::Lua.LuaValue(_ret0);
                var _retCount = _context.Return(_lret0);
                return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
            }
            throw new global::Lua.LuaRuntimeException(_context.Thread, $"{"GetSecondaryTextureCount"}: invalid argument #{_lastArgPos}: {_lastArg} ({_lastArg.Type}), expected: {_expectedType.FullName}", 2);
        });
        private static readonly global::Lua.LuaFunction _LuaSprite_GetSecondaryTextures = new global::Lua.LuaFunction("GetSecondaryTextures", (_context, _) =>
        {
            global::Lua.LuaValue _lastArg = default;
            global::System.Int32 _lastArgPos = default;
            global::System.Type _expectedType = default;
            var _argCount = _context.ArgumentCount;
            var _this = _context.GetArgument<LuaSprite>(0);
            var _arg0 = _lastArg = _argCount > 1 ? _context.GetArgument(1) : global::Lua.LuaValue.Nil;
            _lastArgPos = 0; _expectedType = typeof(global::UnityEngine.SecondarySpriteTexture[]);
            if (_arg0.TryReadArray<global::UnityEngine.SecondarySpriteTexture>(out var _p0_UnityEngine_SecondarySpriteTextureArray))
            {
                if (_argCount == 2)
                {
                    var secondaryTexture = _p0_UnityEngine_SecondarySpriteTextureArray;
                    var _ret0 = _this.Instance.GetSecondaryTextures(secondaryTexture);
                    var _lret0 = new global::Lua.LuaValue(_ret0);
                    var _retCount = _context.Return(_lret0);
                    return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                }
            }
            throw new global::Lua.LuaRuntimeException(_context.Thread, $"{"GetSecondaryTextures"}: invalid argument #{_lastArgPos}: {_lastArg} ({_lastArg.Type}), expected: {_expectedType.FullName}", 2);
        });
        private static readonly global::Lua.LuaFunction _LuaSprite_OverrideGeometry = new global::Lua.LuaFunction("OverrideGeometry", (_context, _) =>
        {
            global::Lua.LuaValue _lastArg = default;
            global::System.Int32 _lastArgPos = default;
            global::System.Type _expectedType = default;
            var _argCount = _context.ArgumentCount;
            var _this = _context.GetArgument<LuaSprite>(0);
            var _arg0 = _lastArg = _argCount > 1 ? _context.GetArgument(1) : global::Lua.LuaValue.Nil;
            _lastArgPos = 0; _expectedType = typeof(global::UnityEngine.Vector2[]);
            if (_arg0.TryReadArray<global::UnityEngine.Vector2>(out var _p0_UnityEngine_Vector2Array))
            {
                var _arg1 = _lastArg = _argCount > 2 ? _context.GetArgument(2) : global::Lua.LuaValue.Nil;
                _lastArgPos = 1; _expectedType = typeof(global::System.UInt16[]);
                if (_arg1.TryReadArray<global::System.UInt16>(out var _p1_System_UInt16Array))
                {
                    if (_argCount == 3)
                    {
                        var vertices = _p0_UnityEngine_Vector2Array;
                        var triangles = _p1_System_UInt16Array;
                        _this.Instance.OverrideGeometry(vertices, triangles);
                        var _retCount = _context.Return();
                        return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                    }
                }
            }
            throw new global::Lua.LuaRuntimeException(_context.Thread, $"{"OverrideGeometry"}: invalid argument #{_lastArgPos}: {_lastArg} ({_lastArg.Type}), expected: {_expectedType.FullName}", 2);
        });
        private static readonly global::Lua.LuaFunction _LuaSprite_RemoveScriptableObjectAt = new global::Lua.LuaFunction("RemoveScriptableObjectAt", (_context, _) =>
        {
            global::Lua.LuaValue _lastArg = default;
            global::System.Int32 _lastArgPos = default;
            global::System.Type _expectedType = default;
            var _argCount = _context.ArgumentCount;
            var _this = _context.GetArgument<LuaSprite>(0);
            var _arg0 = _lastArg = _argCount > 1 ? _context.GetArgument(1) : global::Lua.LuaValue.Nil;
            _lastArgPos = 0; _expectedType = typeof(global::System.UInt32);
            if (_arg0.TryRead<global::System.UInt32>(out var _p0_System_UInt32))
            {
                if (_argCount == 2)
                {
                    var i = _p0_System_UInt32;
                    var _ret0 = _this.Instance.RemoveScriptableObjectAt(i);
                    var _lret0 = new global::Lua.LuaValue(_ret0);
                    var _retCount = _context.Return(_lret0);
                    return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                }
            }
            throw new global::Lua.LuaRuntimeException(_context.Thread, $"{"RemoveScriptableObjectAt"}: invalid argument #{_lastArgPos}: {_lastArg} ({_lastArg.Type}), expected: {_expectedType.FullName}", 2);
        });
        private static readonly global::Lua.LuaFunction _LuaSprite_SetScriptableObjectAt = new global::Lua.LuaFunction("SetScriptableObjectAt", (_context, _) =>
        {
            global::Lua.LuaValue _lastArg = default;
            global::System.Int32 _lastArgPos = default;
            global::System.Type _expectedType = default;
            var _argCount = _context.ArgumentCount;
            var _this = _context.GetArgument<LuaSprite>(0);
            var _arg0 = _lastArg = _argCount > 1 ? _context.GetArgument(1) : global::Lua.LuaValue.Nil;
            _lastArgPos = 0; _expectedType = typeof(global::Luny.UnityEngine.LuaScriptableObject);
            if (_arg0.TryRead<global::Luny.UnityEngine.LuaScriptableObject>(out var _p0_UnityEngine_ScriptableObject))
            {
                var _arg1 = _lastArg = _argCount > 2 ? _context.GetArgument(2) : global::Lua.LuaValue.Nil;
                _lastArgPos = 1; _expectedType = typeof(global::System.UInt32);
                if (_arg1.TryRead<global::System.UInt32>(out var _p1_System_UInt32))
                {
                    if (_argCount == 3)
                    {
                        var obj = _p0_UnityEngine_ScriptableObject.Instance;
                        var i = _p1_System_UInt32;
                        var _ret0 = _this.Instance.SetScriptableObjectAt(obj, i);
                        var _lret0 = new global::Lua.LuaValue(_ret0);
                        var _retCount = _context.Return(_lret0);
                        return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                    }
                }
            }
            throw new global::Lua.LuaRuntimeException(_context.Thread, $"{"SetScriptableObjectAt"}: invalid argument #{_lastArgPos}: {_lastArg} ({_lastArg.Type}), expected: {_expectedType.FullName}", 2);
        });
        private static readonly global::Lua.LuaFunction __index = new(global::Lua.Runtime.Metamethods.Index, (_context, _) =>
        {
            var _this = _context.GetArgument<LuaSprite>(0);
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
            var _this = _context.GetArgument<LuaSprite>(0);
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
                case "AddScriptableObject": _value = _LuaSprite_AddScriptableObject; return true;
                case "GetPhysicsShapeCount": _value = _LuaSprite_GetPhysicsShapeCount; return true;
                case "GetPhysicsShapePointCount": _value = _LuaSprite_GetPhysicsShapePointCount; return true;
                case "GetScriptableObjects": _value = _LuaSprite_GetScriptableObjects; return true;
                case "GetScriptableObjectsCount": _value = _LuaSprite_GetScriptableObjectsCount; return true;
                case "GetSecondaryTextureCount": _value = _LuaSprite_GetSecondaryTextureCount; return true;
                case "GetSecondaryTextures": _value = _LuaSprite_GetSecondaryTextures; return true;
                case "OverrideGeometry": _value = _LuaSprite_OverrideGeometry; return true;
                case "RemoveScriptableObjectAt": _value = _LuaSprite_RemoveScriptableObjectAt; return true;
                case "SetScriptableObjectAt": _value = _LuaSprite_SetScriptableObjectAt; return true;
                case "associatedAlphaSplitTexture": _value = _factory.Bind(Instance.associatedAlphaSplitTexture); return true;
                case "border": _value = global::Luny.UnityEngine.LuaVector4.Bind(Instance.border); return true;
                case "bounds": _value = global::Luny.UnityEngine.LuaBounds.Bind(Instance.bounds); return true;
                case "packed": _value = new global::Lua.LuaValue(Instance.packed); return true;
                case "packingMode": _value = new global::Lua.LuaValue((global::System.Int64)Instance.packingMode); return true;
                case "packingRotation": _value = new global::Lua.LuaValue((global::System.Int64)Instance.packingRotation); return true;
                case "pivot": _value = global::Luny.UnityEngine.LuaVector2.Bind(Instance.pivot); return true;
                case "pixelsPerUnit": _value = new global::Lua.LuaValue(Instance.pixelsPerUnit); return true;
                case "rect": _value = global::Luny.UnityEngine.LuaRect.Bind(Instance.rect); return true;
                case "spriteAtlasTextureScale": _value = new global::Lua.LuaValue(Instance.spriteAtlasTextureScale); return true;
                case "texture": _value = _factory.Bind(Instance.texture); return true;
                case "textureRect": _value = global::Luny.UnityEngine.LuaRect.Bind(Instance.textureRect); return true;
                case "textureRectOffset": _value = global::Luny.UnityEngine.LuaVector2.Bind(Instance.textureRectOffset); return true;
                case "triangles": _value = _factory.Bind(Instance.triangles); return true;
                case "uv": _value = _factory.Bind(Instance.uv); return true;
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
                default: return base.TrySetLuaValue(_key, _value);
            }
        }
    }
    public sealed class LuaSpriteType : global::Luny.ILuaStatic
    {
        public static global::Lua.LuaValue Bind() => new LuaSpriteType();
        private LuaSpriteType() {}
        public static implicit operator global::Lua.LuaValue(LuaSpriteType value) => new(value);
        public global::System.Type BindType => typeof(global::UnityEngine.Sprite);
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

        private static readonly global::Lua.LuaFunction _LuaSprite_Create = new global::Lua.LuaFunction("Create", (_context, _) =>
        {
            global::Lua.LuaValue _lastArg = default;
            global::System.Int32 _lastArgPos = default;
            global::System.Type _expectedType = default;
            var _argCount = _context.ArgumentCount;
            var _arg0 = _lastArg = _argCount > 0 ? _context.GetArgument(0) : global::Lua.LuaValue.Nil;
            _lastArgPos = 0; _expectedType = typeof(global::Luny.UnityEngine.LuaTexture2D);
            if (_arg0.TryRead<global::Luny.UnityEngine.LuaTexture2D>(out var _p0_UnityEngine_Texture2D))
            {
                var _arg1 = _lastArg = _argCount > 1 ? _context.GetArgument(1) : global::Lua.LuaValue.Nil;
                _lastArgPos = 1; _expectedType = typeof(global::Luny.UnityEngine.LuaRect);
                if (_arg1.TryRead<global::Luny.UnityEngine.LuaRect>(out var _p1_UnityEngine_Rect))
                {
                    var _arg2 = _lastArg = _argCount > 2 ? _context.GetArgument(2) : global::Lua.LuaValue.Nil;
                    _lastArgPos = 2; _expectedType = typeof(global::Luny.UnityEngine.LuaVector2);
                    if (_arg2.TryRead<global::Luny.UnityEngine.LuaVector2>(out var _p2_UnityEngine_Vector2))
                    {
                        if (_argCount == 3)
                        {
                            var texture = _p0_UnityEngine_Texture2D.Instance;
                            var rect = _p1_UnityEngine_Rect.Value;
                            var pivot = _p2_UnityEngine_Vector2.Value;
                            var _ret0 = global::UnityEngine.Sprite.Create(texture, rect, pivot);
                            var _factory = _context.GetObjectFactory();
                            var _lret0 = _factory.Bind(_ret0);
                            var _retCount = _context.Return(_lret0);
                            return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                        }
                        var _arg3 = _lastArg = _argCount > 3 ? _context.GetArgument(3) : global::Lua.LuaValue.Nil;
                        _lastArgPos = 3; _expectedType = typeof(global::System.Single);
                        if (_arg3.TryRead<global::System.Single>(out var _p3_System_Single))
                        {
                            if (_argCount == 4)
                            {
                                var texture = _p0_UnityEngine_Texture2D.Instance;
                                var rect = _p1_UnityEngine_Rect.Value;
                                var pivot = _p2_UnityEngine_Vector2.Value;
                                var pixelsPerUnit = _p3_System_Single;
                                var _ret0 = global::UnityEngine.Sprite.Create(texture, rect, pivot, pixelsPerUnit);
                                var _factory = _context.GetObjectFactory();
                                var _lret0 = _factory.Bind(_ret0);
                                var _retCount = _context.Return(_lret0);
                                return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                            }
                            var _arg4 = _lastArg = _argCount > 4 ? _context.GetArgument(4) : global::Lua.LuaValue.Nil;
                            _lastArgPos = 4; _expectedType = typeof(global::System.UInt32);
                            if (_arg4.TryRead<global::System.UInt32>(out var _p4_System_UInt32))
                            {
                                if (_argCount == 5)
                                {
                                    var texture = _p0_UnityEngine_Texture2D.Instance;
                                    var rect = _p1_UnityEngine_Rect.Value;
                                    var pivot = _p2_UnityEngine_Vector2.Value;
                                    var pixelsPerUnit = _p3_System_Single;
                                    var extrude = _p4_System_UInt32;
                                    var _ret0 = global::UnityEngine.Sprite.Create(texture, rect, pivot, pixelsPerUnit, extrude);
                                    var _factory = _context.GetObjectFactory();
                                    var _lret0 = _factory.Bind(_ret0);
                                    var _retCount = _context.Return(_lret0);
                                    return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                                }
                                var _arg5 = _lastArg = _argCount > 5 ? _context.GetArgument(5) : global::Lua.LuaValue.Nil;
                                _lastArgPos = 5; _expectedType = typeof(global::UnityEngine.SpriteMeshType);
                                if (_arg5.TryRead<global::UnityEngine.SpriteMeshType>(out var _p5_UnityEngine_SpriteMeshType))
                                {
                                    if (_argCount == 6)
                                    {
                                        var texture = _p0_UnityEngine_Texture2D.Instance;
                                        var rect = _p1_UnityEngine_Rect.Value;
                                        var pivot = _p2_UnityEngine_Vector2.Value;
                                        var pixelsPerUnit = _p3_System_Single;
                                        var extrude = _p4_System_UInt32;
                                        var meshType = _p5_UnityEngine_SpriteMeshType;
                                        var _ret0 = global::UnityEngine.Sprite.Create(texture, rect, pivot, pixelsPerUnit, extrude, meshType);
                                        var _factory = _context.GetObjectFactory();
                                        var _lret0 = _factory.Bind(_ret0);
                                        var _retCount = _context.Return(_lret0);
                                        return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                                    }
                                    var _arg6 = _lastArg = _argCount > 6 ? _context.GetArgument(6) : global::Lua.LuaValue.Nil;
                                    _lastArgPos = 6; _expectedType = typeof(global::Luny.UnityEngine.LuaVector4);
                                    if (_arg6.TryRead<global::Luny.UnityEngine.LuaVector4>(out var _p6_UnityEngine_Vector4))
                                    {
                                        if (_argCount == 7)
                                        {
                                            var texture = _p0_UnityEngine_Texture2D.Instance;
                                            var rect = _p1_UnityEngine_Rect.Value;
                                            var pivot = _p2_UnityEngine_Vector2.Value;
                                            var pixelsPerUnit = _p3_System_Single;
                                            var extrude = _p4_System_UInt32;
                                            var meshType = _p5_UnityEngine_SpriteMeshType;
                                            var border = _p6_UnityEngine_Vector4.Value;
                                            var _ret0 = global::UnityEngine.Sprite.Create(texture, rect, pivot, pixelsPerUnit, extrude, meshType, border);
                                            var _factory = _context.GetObjectFactory();
                                            var _lret0 = _factory.Bind(_ret0);
                                            var _retCount = _context.Return(_lret0);
                                            return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                                        }
                                        var _arg7 = _lastArg = _argCount > 7 ? _context.GetArgument(7) : global::Lua.LuaValue.Nil;
                                        _lastArgPos = 7; _expectedType = typeof(global::System.Boolean);
                                        if (_arg7.TryRead<global::System.Boolean>(out var _p7_System_Boolean))
                                        {
                                            if (_argCount == 8)
                                            {
                                                var texture = _p0_UnityEngine_Texture2D.Instance;
                                                var rect = _p1_UnityEngine_Rect.Value;
                                                var pivot = _p2_UnityEngine_Vector2.Value;
                                                var pixelsPerUnit = _p3_System_Single;
                                                var extrude = _p4_System_UInt32;
                                                var meshType = _p5_UnityEngine_SpriteMeshType;
                                                var border = _p6_UnityEngine_Vector4.Value;
                                                var generateFallbackPhysicsShape = _p7_System_Boolean;
                                                var _ret0 = global::UnityEngine.Sprite.Create(texture, rect, pivot, pixelsPerUnit, extrude, meshType, border, generateFallbackPhysicsShape);
                                                var _factory = _context.GetObjectFactory();
                                                var _lret0 = _factory.Bind(_ret0);
                                                var _retCount = _context.Return(_lret0);
                                                return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                                            }
                                            var _arg8 = _lastArg = _argCount > 8 ? _context.GetArgument(8) : global::Lua.LuaValue.Nil;
                                            _lastArgPos = 8; _expectedType = typeof(global::UnityEngine.SecondarySpriteTexture[]);
                                            if (_arg8.TryReadArray<global::UnityEngine.SecondarySpriteTexture>(out var _p8_UnityEngine_SecondarySpriteTextureArray))
                                            {
                                                if (_argCount == 9)
                                                {
                                                    var texture = _p0_UnityEngine_Texture2D.Instance;
                                                    var rect = _p1_UnityEngine_Rect.Value;
                                                    var pivot = _p2_UnityEngine_Vector2.Value;
                                                    var pixelsPerUnit = _p3_System_Single;
                                                    var extrude = _p4_System_UInt32;
                                                    var meshType = _p5_UnityEngine_SpriteMeshType;
                                                    var border = _p6_UnityEngine_Vector4.Value;
                                                    var generateFallbackPhysicsShape = _p7_System_Boolean;
                                                    var secondaryTextures = _p8_UnityEngine_SecondarySpriteTextureArray;
                                                    var _ret0 = global::UnityEngine.Sprite.Create(texture, rect, pivot, pixelsPerUnit, extrude, meshType, border, generateFallbackPhysicsShape, secondaryTextures);
                                                    var _factory = _context.GetObjectFactory();
                                                    var _lret0 = _factory.Bind(_ret0);
                                                    var _retCount = _context.Return(_lret0);
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
            throw new global::Lua.LuaRuntimeException(_context.Thread, $"{"Create"}: invalid argument #{_lastArgPos}: {_lastArg} ({_lastArg.Type}), expected: {_expectedType.FullName}", 2);
        });
        private static readonly global::Lua.LuaFunction __index = new(global::Lua.Runtime.Metamethods.Index, (_context, _) =>
        {
            var _this = _context.GetArgument<LuaSpriteType>(0);
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
            var _this = _context.GetArgument<LuaSpriteType>(0);
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
                case "Create": _value = _LuaSprite_Create; return true;
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
