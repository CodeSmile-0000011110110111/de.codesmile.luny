
// --------------------------------------------------------------
// GENERATED FILE ----> DO NOT EDIT <---- CHANGES WILL BE LOST !!
// --------------------------------------------------------------

#if UNITY_6000_2_OR_NEWER && !(UNITY_6000_3_OR_NEWER)
#pragma warning disable 0109, 0162, 0168, 0219
using Luny;

namespace Luny.UnityEditor
{
    public sealed class LuaPrefabUtility : global::Luny.ILuaObject<global::UnityEditor.PrefabUtility>
    {
        public new static global::Lua.LuaValue Bind(global::UnityEditor.PrefabUtility instance) => new LuaPrefabUtility(instance);
        public new static global::Lua.LuaValue Bind(global::System.Object instance) => Bind((global::UnityEditor.PrefabUtility)instance);
        public new static global::Lua.LuaValue Bind(global::System.Collections.Generic.IList<global::UnityEditor.PrefabUtility> instances) =>
            new global::Luny.LuaList<global::UnityEditor.PrefabUtility>(instances);
        public new static global::Lua.LuaValue Bind(global::System.Collections.Generic.IList<global::System.Object> instances) =>
            new global::Luny.LuaList<global::UnityEditor.PrefabUtility>(instances);
        private LuaPrefabUtility(global::UnityEditor.PrefabUtility instance) => m_Instance = instance;
        public static implicit operator global::Lua.LuaValue(LuaPrefabUtility value) => new(value);
        private global::UnityEditor.PrefabUtility m_Instance;
        public global::UnityEditor.PrefabUtility Instance => m_Instance;
        public new global::System.Type BindType => typeof(global::UnityEditor.PrefabUtility);
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

        private static readonly global::Lua.LuaFunction __index = new(global::Lua.Runtime.Metamethods.Index, (_context, _) =>
        {
            var _this = _context.GetArgument<LuaPrefabUtility>(0);
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
            var _this = _context.GetArgument<LuaPrefabUtility>(0);
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
    public sealed class LuaPrefabUtilityType : global::Luny.ILuaStatic
    {
        public static global::Lua.LuaValue Bind() => new LuaPrefabUtilityType();
        private LuaPrefabUtilityType() {}
        public static implicit operator global::Lua.LuaValue(LuaPrefabUtilityType value) => new(value);
        public global::System.Type BindType => typeof(global::UnityEditor.PrefabUtility);
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
            metatable[global::Lua.Runtime.Metamethods.Call] = _LuaPrefabUtility_new;
            return metatable;
        }
        public override global::System.String ToString() => BindType.FullName;
#if UNITY_EDITOR
        [global::UnityEngine.RuntimeInitializeOnLoadMethod(global::UnityEngine.RuntimeInitializeLoadType.SubsystemRegistration)]
        private static void ResetStaticFields() => s_Metatable = null;
#endif

        private static readonly global::Lua.LuaFunction _LuaPrefabUtility_new = new global::Lua.LuaFunction(".ctor", (_context, _) =>
        {
            global::Lua.LuaValue _lastArg = default;
            global::System.Int32 _lastArgPos = default;
            global::System.Type _expectedType = default;
            var _argCount = _context.ArgumentCount;
            if (_argCount == 1)
            {
                var _ret0 = new global::UnityEditor.PrefabUtility();
                var _factory = _context.GetObjectFactory();
                var _lret0 = _factory.Bind(_ret0);
                var _retCount = _context.Return(_lret0);
                return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
            }
            throw new global::Lua.LuaRuntimeException(_context.Thread, $"{".ctor"}: invalid argument #{_lastArgPos}: {_lastArg} ({_lastArg.Type}), expected: {_expectedType.FullName}", 2);
        });
        private static readonly global::Lua.LuaFunction _LuaPrefabUtility_ApplyAddedComponent = new global::Lua.LuaFunction("ApplyAddedComponent", (_context, _) =>
        {
            global::Lua.LuaValue _lastArg = default;
            global::System.Int32 _lastArgPos = default;
            global::System.Type _expectedType = default;
            var _argCount = _context.ArgumentCount;
            var _arg0 = _lastArg = _argCount > 0 ? _context.GetArgument(0) : global::Lua.LuaValue.Nil;
            _lastArgPos = 0; _expectedType = typeof(global::UnityEngine.Component);
            if (_arg0.TryRead<global::UnityEngine.Component>(out var _p0_UnityEngine_Component))
            {
                var _arg1 = _lastArg = _argCount > 1 ? _context.GetArgument(1) : global::Lua.LuaValue.Nil;
                _lastArgPos = 1; _expectedType = typeof(global::System.String);
                if (_arg1.TryRead<global::System.String>(out var _p1_System_String))
                {
                    var _arg2 = _lastArg = _argCount > 2 ? _context.GetArgument(2) : global::Lua.LuaValue.Nil;
                    _lastArgPos = 2; _expectedType = typeof(global::UnityEditor.InteractionMode);
                    if (_arg2.TryRead<global::UnityEditor.InteractionMode>(out var _p2_UnityEditor_InteractionMode))
                    {
                        if (_argCount == 3)
                        {
                            var component = _p0_UnityEngine_Component;
                            var assetPath = _p1_System_String;
                            var action = _p2_UnityEditor_InteractionMode;
                            global::UnityEditor.PrefabUtility.ApplyAddedComponent(component, assetPath, action);
                            var _retCount = _context.Return();
                            return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                        }
                    }
                }
            }
            throw new global::Lua.LuaRuntimeException(_context.Thread, $"{"ApplyAddedComponent"}: invalid argument #{_lastArgPos}: {_lastArg} ({_lastArg.Type}), expected: {_expectedType.FullName}", 2);
        });
        private static readonly global::Lua.LuaFunction _LuaPrefabUtility_ApplyAddedGameObject = new global::Lua.LuaFunction("ApplyAddedGameObject", (_context, _) =>
        {
            global::Lua.LuaValue _lastArg = default;
            global::System.Int32 _lastArgPos = default;
            global::System.Type _expectedType = default;
            var _argCount = _context.ArgumentCount;
            var _arg0 = _lastArg = _argCount > 0 ? _context.GetArgument(0) : global::Lua.LuaValue.Nil;
            _lastArgPos = 0; _expectedType = typeof(global::UnityEngine.GameObject);
            if (_arg0.TryRead<global::UnityEngine.GameObject>(out var _p0_UnityEngine_GameObject))
            {
                var _arg1 = _lastArg = _argCount > 1 ? _context.GetArgument(1) : global::Lua.LuaValue.Nil;
                _lastArgPos = 1; _expectedType = typeof(global::System.String);
                if (_arg1.TryRead<global::System.String>(out var _p1_System_String))
                {
                    var _arg2 = _lastArg = _argCount > 2 ? _context.GetArgument(2) : global::Lua.LuaValue.Nil;
                    _lastArgPos = 2; _expectedType = typeof(global::UnityEditor.InteractionMode);
                    if (_arg2.TryRead<global::UnityEditor.InteractionMode>(out var _p2_UnityEditor_InteractionMode))
                    {
                        if (_argCount == 3)
                        {
                            var gameObject = _p0_UnityEngine_GameObject;
                            var assetPath = _p1_System_String;
                            var action = _p2_UnityEditor_InteractionMode;
                            global::UnityEditor.PrefabUtility.ApplyAddedGameObject(gameObject, assetPath, action);
                            var _retCount = _context.Return();
                            return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                        }
                    }
                }
            }
            throw new global::Lua.LuaRuntimeException(_context.Thread, $"{"ApplyAddedGameObject"}: invalid argument #{_lastArgPos}: {_lastArg} ({_lastArg.Type}), expected: {_expectedType.FullName}", 2);
        });
        private static readonly global::Lua.LuaFunction _LuaPrefabUtility_ApplyAddedGameObjects = new global::Lua.LuaFunction("ApplyAddedGameObjects", (_context, _) =>
        {
            global::Lua.LuaValue _lastArg = default;
            global::System.Int32 _lastArgPos = default;
            global::System.Type _expectedType = default;
            var _argCount = _context.ArgumentCount;
            var _arg0 = _lastArg = _argCount > 0 ? _context.GetArgument(0) : global::Lua.LuaValue.Nil;
            _lastArgPos = 0; _expectedType = typeof(global::UnityEngine.GameObject[]);
            if (_arg0.TryReadArray<global::UnityEngine.GameObject>(out var _p0_UnityEngine_GameObjectArray))
            {
                var _arg1 = _lastArg = _argCount > 1 ? _context.GetArgument(1) : global::Lua.LuaValue.Nil;
                _lastArgPos = 1; _expectedType = typeof(global::System.String);
                if (_arg1.TryRead<global::System.String>(out var _p1_System_String))
                {
                    var _arg2 = _lastArg = _argCount > 2 ? _context.GetArgument(2) : global::Lua.LuaValue.Nil;
                    _lastArgPos = 2; _expectedType = typeof(global::UnityEditor.InteractionMode);
                    if (_arg2.TryRead<global::UnityEditor.InteractionMode>(out var _p2_UnityEditor_InteractionMode))
                    {
                        if (_argCount == 3)
                        {
                            var gameObjects = _p0_UnityEngine_GameObjectArray;
                            var assetPath = _p1_System_String;
                            var action = _p2_UnityEditor_InteractionMode;
                            global::UnityEditor.PrefabUtility.ApplyAddedGameObjects(gameObjects, assetPath, action);
                            var _retCount = _context.Return();
                            return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                        }
                    }
                }
            }
            throw new global::Lua.LuaRuntimeException(_context.Thread, $"{"ApplyAddedGameObjects"}: invalid argument #{_lastArgPos}: {_lastArg} ({_lastArg.Type}), expected: {_expectedType.FullName}", 2);
        });
        private static readonly global::Lua.LuaFunction _LuaPrefabUtility_ApplyObjectOverride = new global::Lua.LuaFunction("ApplyObjectOverride", (_context, _) =>
        {
            global::Lua.LuaValue _lastArg = default;
            global::System.Int32 _lastArgPos = default;
            global::System.Type _expectedType = default;
            var _argCount = _context.ArgumentCount;
            var _arg0 = _lastArg = _argCount > 0 ? _context.GetArgument(0) : global::Lua.LuaValue.Nil;
            _lastArgPos = 0; _expectedType = typeof(global::UnityEngine.Object);
            if (_arg0.TryRead<global::UnityEngine.Object>(out var _p0_UnityEngine_Object))
            {
                var _arg1 = _lastArg = _argCount > 1 ? _context.GetArgument(1) : global::Lua.LuaValue.Nil;
                _lastArgPos = 1; _expectedType = typeof(global::System.String);
                if (_arg1.TryRead<global::System.String>(out var _p1_System_String))
                {
                    var _arg2 = _lastArg = _argCount > 2 ? _context.GetArgument(2) : global::Lua.LuaValue.Nil;
                    _lastArgPos = 2; _expectedType = typeof(global::UnityEditor.InteractionMode);
                    if (_arg2.TryRead<global::UnityEditor.InteractionMode>(out var _p2_UnityEditor_InteractionMode))
                    {
                        if (_argCount == 3)
                        {
                            var instanceComponentOrGameObject = _p0_UnityEngine_Object;
                            var assetPath = _p1_System_String;
                            var action = _p2_UnityEditor_InteractionMode;
                            global::UnityEditor.PrefabUtility.ApplyObjectOverride(instanceComponentOrGameObject, assetPath, action);
                            var _retCount = _context.Return();
                            return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                        }
                    }
                }
            }
            throw new global::Lua.LuaRuntimeException(_context.Thread, $"{"ApplyObjectOverride"}: invalid argument #{_lastArgPos}: {_lastArg} ({_lastArg.Type}), expected: {_expectedType.FullName}", 2);
        });
        private static readonly global::Lua.LuaFunction _LuaPrefabUtility_ApplyPrefabInstance = new global::Lua.LuaFunction("ApplyPrefabInstance", (_context, _) =>
        {
            global::Lua.LuaValue _lastArg = default;
            global::System.Int32 _lastArgPos = default;
            global::System.Type _expectedType = default;
            var _argCount = _context.ArgumentCount;
            var _arg0 = _lastArg = _argCount > 0 ? _context.GetArgument(0) : global::Lua.LuaValue.Nil;
            _lastArgPos = 0; _expectedType = typeof(global::UnityEngine.GameObject);
            if (_arg0.TryRead<global::UnityEngine.GameObject>(out var _p0_UnityEngine_GameObject))
            {
                var _arg1 = _lastArg = _argCount > 1 ? _context.GetArgument(1) : global::Lua.LuaValue.Nil;
                _lastArgPos = 1; _expectedType = typeof(global::UnityEditor.InteractionMode);
                if (_arg1.TryRead<global::UnityEditor.InteractionMode>(out var _p1_UnityEditor_InteractionMode))
                {
                    if (_argCount == 2)
                    {
                        var instanceRoot = _p0_UnityEngine_GameObject;
                        var action = _p1_UnityEditor_InteractionMode;
                        global::UnityEditor.PrefabUtility.ApplyPrefabInstance(instanceRoot, action);
                        var _retCount = _context.Return();
                        return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                    }
                }
            }
            throw new global::Lua.LuaRuntimeException(_context.Thread, $"{"ApplyPrefabInstance"}: invalid argument #{_lastArgPos}: {_lastArg} ({_lastArg.Type}), expected: {_expectedType.FullName}", 2);
        });
        private static readonly global::Lua.LuaFunction _LuaPrefabUtility_ApplyPrefabInstances = new global::Lua.LuaFunction("ApplyPrefabInstances", (_context, _) =>
        {
            global::Lua.LuaValue _lastArg = default;
            global::System.Int32 _lastArgPos = default;
            global::System.Type _expectedType = default;
            var _argCount = _context.ArgumentCount;
            var _arg0 = _lastArg = _argCount > 0 ? _context.GetArgument(0) : global::Lua.LuaValue.Nil;
            _lastArgPos = 0; _expectedType = typeof(global::UnityEngine.GameObject[]);
            if (_arg0.TryReadArray<global::UnityEngine.GameObject>(out var _p0_UnityEngine_GameObjectArray))
            {
                var _arg1 = _lastArg = _argCount > 1 ? _context.GetArgument(1) : global::Lua.LuaValue.Nil;
                _lastArgPos = 1; _expectedType = typeof(global::UnityEditor.InteractionMode);
                if (_arg1.TryRead<global::UnityEditor.InteractionMode>(out var _p1_UnityEditor_InteractionMode))
                {
                    if (_argCount == 2)
                    {
                        var instanceRoots = _p0_UnityEngine_GameObjectArray;
                        var action = _p1_UnityEditor_InteractionMode;
                        global::UnityEditor.PrefabUtility.ApplyPrefabInstances(instanceRoots, action);
                        var _retCount = _context.Return();
                        return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                    }
                }
            }
            throw new global::Lua.LuaRuntimeException(_context.Thread, $"{"ApplyPrefabInstances"}: invalid argument #{_lastArgPos}: {_lastArg} ({_lastArg.Type}), expected: {_expectedType.FullName}", 2);
        });
        private static readonly global::Lua.LuaFunction _LuaPrefabUtility_ApplyPropertyOverride = new global::Lua.LuaFunction("ApplyPropertyOverride", (_context, _) =>
        {
            global::Lua.LuaValue _lastArg = default;
            global::System.Int32 _lastArgPos = default;
            global::System.Type _expectedType = default;
            var _argCount = _context.ArgumentCount;
            var _arg0 = _lastArg = _argCount > 0 ? _context.GetArgument(0) : global::Lua.LuaValue.Nil;
            _lastArgPos = 0; _expectedType = typeof(global::Luny.UnityEditor.LuaSerializedProperty);
            if (_arg0.TryRead<global::Luny.UnityEditor.LuaSerializedProperty>(out var _p0_UnityEditor_SerializedProperty))
            {
                var _arg1 = _lastArg = _argCount > 1 ? _context.GetArgument(1) : global::Lua.LuaValue.Nil;
                _lastArgPos = 1; _expectedType = typeof(global::System.String);
                if (_arg1.TryRead<global::System.String>(out var _p1_System_String))
                {
                    var _arg2 = _lastArg = _argCount > 2 ? _context.GetArgument(2) : global::Lua.LuaValue.Nil;
                    _lastArgPos = 2; _expectedType = typeof(global::UnityEditor.InteractionMode);
                    if (_arg2.TryRead<global::UnityEditor.InteractionMode>(out var _p2_UnityEditor_InteractionMode))
                    {
                        if (_argCount == 3)
                        {
                            var instanceProperty = _p0_UnityEditor_SerializedProperty.Instance;
                            var assetPath = _p1_System_String;
                            var action = _p2_UnityEditor_InteractionMode;
                            global::UnityEditor.PrefabUtility.ApplyPropertyOverride(instanceProperty, assetPath, action);
                            var _retCount = _context.Return();
                            return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                        }
                    }
                }
            }
            throw new global::Lua.LuaRuntimeException(_context.Thread, $"{"ApplyPropertyOverride"}: invalid argument #{_lastArgPos}: {_lastArg} ({_lastArg.Type}), expected: {_expectedType.FullName}", 2);
        });
        private static readonly global::Lua.LuaFunction _LuaPrefabUtility_ApplyRemovedComponent = new global::Lua.LuaFunction("ApplyRemovedComponent", (_context, _) =>
        {
            global::Lua.LuaValue _lastArg = default;
            global::System.Int32 _lastArgPos = default;
            global::System.Type _expectedType = default;
            var _argCount = _context.ArgumentCount;
            var _arg0 = _lastArg = _argCount > 0 ? _context.GetArgument(0) : global::Lua.LuaValue.Nil;
            _lastArgPos = 0; _expectedType = typeof(global::UnityEngine.GameObject);
            if (_arg0.TryRead<global::UnityEngine.GameObject>(out var _p0_UnityEngine_GameObject))
            {
                var _arg1 = _lastArg = _argCount > 1 ? _context.GetArgument(1) : global::Lua.LuaValue.Nil;
                _lastArgPos = 1; _expectedType = typeof(global::UnityEngine.Component);
                if (_arg1.TryRead<global::UnityEngine.Component>(out var _p1_UnityEngine_Component))
                {
                    var _arg2 = _lastArg = _argCount > 2 ? _context.GetArgument(2) : global::Lua.LuaValue.Nil;
                    _lastArgPos = 2; _expectedType = typeof(global::UnityEditor.InteractionMode);
                    if (_arg2.TryRead<global::UnityEditor.InteractionMode>(out var _p2_UnityEditor_InteractionMode))
                    {
                        if (_argCount == 3)
                        {
                            var instanceGameObject = _p0_UnityEngine_GameObject;
                            var assetComponent = _p1_UnityEngine_Component;
                            var action = _p2_UnityEditor_InteractionMode;
                            global::UnityEditor.PrefabUtility.ApplyRemovedComponent(instanceGameObject, assetComponent, action);
                            var _retCount = _context.Return();
                            return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                        }
                    }
                }
            }
            throw new global::Lua.LuaRuntimeException(_context.Thread, $"{"ApplyRemovedComponent"}: invalid argument #{_lastArgPos}: {_lastArg} ({_lastArg.Type}), expected: {_expectedType.FullName}", 2);
        });
        private static readonly global::Lua.LuaFunction _LuaPrefabUtility_ApplyRemovedGameObject = new global::Lua.LuaFunction("ApplyRemovedGameObject", (_context, _) =>
        {
            global::Lua.LuaValue _lastArg = default;
            global::System.Int32 _lastArgPos = default;
            global::System.Type _expectedType = default;
            var _argCount = _context.ArgumentCount;
            var _arg0 = _lastArg = _argCount > 0 ? _context.GetArgument(0) : global::Lua.LuaValue.Nil;
            _lastArgPos = 0; _expectedType = typeof(global::UnityEngine.GameObject);
            if (_arg0.TryRead<global::UnityEngine.GameObject>(out var _p0_UnityEngine_GameObject))
            {
                var _arg1 = _lastArg = _argCount > 1 ? _context.GetArgument(1) : global::Lua.LuaValue.Nil;
                _lastArgPos = 1; _expectedType = typeof(global::UnityEngine.GameObject);
                if (_arg1.TryRead<global::UnityEngine.GameObject>(out var _p1_UnityEngine_GameObject))
                {
                    var _arg2 = _lastArg = _argCount > 2 ? _context.GetArgument(2) : global::Lua.LuaValue.Nil;
                    _lastArgPos = 2; _expectedType = typeof(global::UnityEditor.InteractionMode);
                    if (_arg2.TryRead<global::UnityEditor.InteractionMode>(out var _p2_UnityEditor_InteractionMode))
                    {
                        if (_argCount == 3)
                        {
                            var gameObjectInInstance = _p0_UnityEngine_GameObject;
                            var assetGameObject = _p1_UnityEngine_GameObject;
                            var action = _p2_UnityEditor_InteractionMode;
                            global::UnityEditor.PrefabUtility.ApplyRemovedGameObject(gameObjectInInstance, assetGameObject, action);
                            var _retCount = _context.Return();
                            return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                        }
                    }
                }
            }
            throw new global::Lua.LuaRuntimeException(_context.Thread, $"{"ApplyRemovedGameObject"}: invalid argument #{_lastArgPos}: {_lastArg} ({_lastArg.Type}), expected: {_expectedType.FullName}", 2);
        });
        private static readonly global::Lua.LuaFunction _LuaPrefabUtility_ConvertToPrefabInstance = new global::Lua.LuaFunction("ConvertToPrefabInstance", (_context, _) =>
        {
            global::Lua.LuaValue _lastArg = default;
            global::System.Int32 _lastArgPos = default;
            global::System.Type _expectedType = default;
            var _argCount = _context.ArgumentCount;
            var _arg0 = _lastArg = _argCount > 0 ? _context.GetArgument(0) : global::Lua.LuaValue.Nil;
            _lastArgPos = 0; _expectedType = typeof(global::UnityEngine.GameObject);
            if (_arg0.TryRead<global::UnityEngine.GameObject>(out var _p0_UnityEngine_GameObject))
            {
                var _arg1 = _lastArg = _argCount > 1 ? _context.GetArgument(1) : global::Lua.LuaValue.Nil;
                _lastArgPos = 1; _expectedType = typeof(global::UnityEngine.GameObject);
                if (_arg1.TryRead<global::UnityEngine.GameObject>(out var _p1_UnityEngine_GameObject))
                {
                    var _arg2 = _lastArg = _argCount > 2 ? _context.GetArgument(2) : global::Lua.LuaValue.Nil;
                    _lastArgPos = 2; _expectedType = typeof(global::Luny.UnityEditor.LuaConvertToPrefabInstanceSettings);
                    if (_arg2.TryRead<global::Luny.UnityEditor.LuaConvertToPrefabInstanceSettings>(out var _p2_UnityEditor_ConvertToPrefabInstanceSettings))
                    {
                        var _arg3 = _lastArg = _argCount > 3 ? _context.GetArgument(3) : global::Lua.LuaValue.Nil;
                        _lastArgPos = 3; _expectedType = typeof(global::UnityEditor.InteractionMode);
                        if (_arg3.TryRead<global::UnityEditor.InteractionMode>(out var _p3_UnityEditor_InteractionMode))
                        {
                            if (_argCount == 4)
                            {
                                var plainGameObject = _p0_UnityEngine_GameObject;
                                var prefabAssetRoot = _p1_UnityEngine_GameObject;
                                var settings = _p2_UnityEditor_ConvertToPrefabInstanceSettings.Instance;
                                var mode = _p3_UnityEditor_InteractionMode;
                                global::UnityEditor.PrefabUtility.ConvertToPrefabInstance(plainGameObject, prefabAssetRoot, settings, mode);
                                var _retCount = _context.Return();
                                return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                            }
                        }
                    }
                }
            }
            throw new global::Lua.LuaRuntimeException(_context.Thread, $"{"ConvertToPrefabInstance"}: invalid argument #{_lastArgPos}: {_lastArg} ({_lastArg.Type}), expected: {_expectedType.FullName}", 2);
        });
        private static readonly global::Lua.LuaFunction _LuaPrefabUtility_ConvertToPrefabInstances = new global::Lua.LuaFunction("ConvertToPrefabInstances", (_context, _) =>
        {
            global::Lua.LuaValue _lastArg = default;
            global::System.Int32 _lastArgPos = default;
            global::System.Type _expectedType = default;
            var _argCount = _context.ArgumentCount;
            var _arg0 = _lastArg = _argCount > 0 ? _context.GetArgument(0) : global::Lua.LuaValue.Nil;
            _lastArgPos = 0; _expectedType = typeof(global::UnityEngine.GameObject[]);
            if (_arg0.TryReadArray<global::UnityEngine.GameObject>(out var _p0_UnityEngine_GameObjectArray))
            {
                var _arg1 = _lastArg = _argCount > 1 ? _context.GetArgument(1) : global::Lua.LuaValue.Nil;
                _lastArgPos = 1; _expectedType = typeof(global::UnityEngine.GameObject);
                if (_arg1.TryRead<global::UnityEngine.GameObject>(out var _p1_UnityEngine_GameObject))
                {
                    var _arg2 = _lastArg = _argCount > 2 ? _context.GetArgument(2) : global::Lua.LuaValue.Nil;
                    _lastArgPos = 2; _expectedType = typeof(global::Luny.UnityEditor.LuaConvertToPrefabInstanceSettings);
                    if (_arg2.TryRead<global::Luny.UnityEditor.LuaConvertToPrefabInstanceSettings>(out var _p2_UnityEditor_ConvertToPrefabInstanceSettings))
                    {
                        var _arg3 = _lastArg = _argCount > 3 ? _context.GetArgument(3) : global::Lua.LuaValue.Nil;
                        _lastArgPos = 3; _expectedType = typeof(global::UnityEditor.InteractionMode);
                        if (_arg3.TryRead<global::UnityEditor.InteractionMode>(out var _p3_UnityEditor_InteractionMode))
                        {
                            if (_argCount == 4)
                            {
                                var plainGameObjects = _p0_UnityEngine_GameObjectArray;
                                var prefabAssetRoot = _p1_UnityEngine_GameObject;
                                var settings = _p2_UnityEditor_ConvertToPrefabInstanceSettings.Instance;
                                var mode = _p3_UnityEditor_InteractionMode;
                                global::UnityEditor.PrefabUtility.ConvertToPrefabInstances(plainGameObjects, prefabAssetRoot, settings, mode);
                                var _retCount = _context.Return();
                                return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                            }
                        }
                    }
                }
            }
            throw new global::Lua.LuaRuntimeException(_context.Thread, $"{"ConvertToPrefabInstances"}: invalid argument #{_lastArgPos}: {_lastArg} ({_lastArg.Type}), expected: {_expectedType.FullName}", 2);
        });
        private static readonly global::Lua.LuaFunction _LuaPrefabUtility_FindAllInstancesOfPrefab = new global::Lua.LuaFunction("FindAllInstancesOfPrefab", (_context, _) =>
        {
            global::Lua.LuaValue _lastArg = default;
            global::System.Int32 _lastArgPos = default;
            global::System.Type _expectedType = default;
            var _argCount = _context.ArgumentCount;
            var _arg0 = _lastArg = _argCount > 0 ? _context.GetArgument(0) : global::Lua.LuaValue.Nil;
            _lastArgPos = 0; _expectedType = typeof(global::UnityEngine.GameObject);
            if (_arg0.TryRead<global::UnityEngine.GameObject>(out var _p0_UnityEngine_GameObject))
            {
                if (_argCount == 1)
                {
                    var prefabRoot = _p0_UnityEngine_GameObject;
                    var _ret0 = global::UnityEditor.PrefabUtility.FindAllInstancesOfPrefab(prefabRoot);
                    var _factory = _context.GetObjectFactory();
                    var _lret0 = _factory.Bind(_ret0);
                    var _retCount = _context.Return(_lret0);
                    return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                }
                var _arg1 = _lastArg = _argCount > 1 ? _context.GetArgument(1) : global::Lua.LuaValue.Nil;
                _lastArgPos = 1; _expectedType = typeof(global::UnityEngine.SceneManagement.Scene);
                if (_arg1.TryRead<global::UnityEngine.SceneManagement.Scene>(out var _p1_UnityEngine_SceneManagement_Scene))
                {
                    if (_argCount == 2)
                    {
                        var prefabRoot = _p0_UnityEngine_GameObject;
                        var scene = _p1_UnityEngine_SceneManagement_Scene;
                        var _ret0 = global::UnityEditor.PrefabUtility.FindAllInstancesOfPrefab(prefabRoot, scene);
                        var _factory = _context.GetObjectFactory();
                        var _lret0 = _factory.Bind(_ret0);
                        var _retCount = _context.Return(_lret0);
                        return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                    }
                }
            }
            throw new global::Lua.LuaRuntimeException(_context.Thread, $"{"FindAllInstancesOfPrefab"}: invalid argument #{_lastArgPos}: {_lastArg} ({_lastArg.Type}), expected: {_expectedType.FullName}", 2);
        });
        private static readonly global::Lua.LuaFunction _LuaPrefabUtility_GetIconForGameObject = new global::Lua.LuaFunction("GetIconForGameObject", (_context, _) =>
        {
            global::Lua.LuaValue _lastArg = default;
            global::System.Int32 _lastArgPos = default;
            global::System.Type _expectedType = default;
            var _argCount = _context.ArgumentCount;
            var _arg0 = _lastArg = _argCount > 0 ? _context.GetArgument(0) : global::Lua.LuaValue.Nil;
            _lastArgPos = 0; _expectedType = typeof(global::UnityEngine.GameObject);
            if (_arg0.TryRead<global::UnityEngine.GameObject>(out var _p0_UnityEngine_GameObject))
            {
                if (_argCount == 1)
                {
                    var gameObject = _p0_UnityEngine_GameObject;
                    var _ret0 = global::UnityEditor.PrefabUtility.GetIconForGameObject(gameObject);
                    var _factory = _context.GetObjectFactory();
                    var _lret0 = _factory.Bind(_ret0);
                    var _retCount = _context.Return(_lret0);
                    return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                }
            }
            throw new global::Lua.LuaRuntimeException(_context.Thread, $"{"GetIconForGameObject"}: invalid argument #{_lastArgPos}: {_lastArg} ({_lastArg.Type}), expected: {_expectedType.FullName}", 2);
        });
        private static readonly global::Lua.LuaFunction _LuaPrefabUtility_GetNearestPrefabInstanceRoot = new global::Lua.LuaFunction("GetNearestPrefabInstanceRoot", (_context, _) =>
        {
            global::Lua.LuaValue _lastArg = default;
            global::System.Int32 _lastArgPos = default;
            global::System.Type _expectedType = default;
            var _argCount = _context.ArgumentCount;
            var _arg0 = _lastArg = _argCount > 0 ? _context.GetArgument(0) : global::Lua.LuaValue.Nil;
            _lastArgPos = 0; _expectedType = typeof(global::UnityEngine.Object);
            if (_arg0.TryRead<global::UnityEngine.Object>(out var _p0_UnityEngine_Object))
            {
                if (_argCount == 1)
                {
                    var componentOrGameObject = _p0_UnityEngine_Object;
                    var _ret0 = global::UnityEditor.PrefabUtility.GetNearestPrefabInstanceRoot(componentOrGameObject);
                    var _factory = _context.GetObjectFactory();
                    var _lret0 = _factory.Bind(_ret0);
                    var _retCount = _context.Return(_lret0);
                    return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                }
            }
            throw new global::Lua.LuaRuntimeException(_context.Thread, $"{"GetNearestPrefabInstanceRoot"}: invalid argument #{_lastArgPos}: {_lastArg} ({_lastArg.Type}), expected: {_expectedType.FullName}", 2);
        });
        private static readonly global::Lua.LuaFunction _LuaPrefabUtility_GetOriginalSourceRootWhereGameObjectIsAdded = new global::Lua.LuaFunction("GetOriginalSourceRootWhereGameObjectIsAdded", (_context, _) =>
        {
            global::Lua.LuaValue _lastArg = default;
            global::System.Int32 _lastArgPos = default;
            global::System.Type _expectedType = default;
            var _argCount = _context.ArgumentCount;
            var _arg0 = _lastArg = _argCount > 0 ? _context.GetArgument(0) : global::Lua.LuaValue.Nil;
            _lastArgPos = 0; _expectedType = typeof(global::UnityEngine.GameObject);
            if (_arg0.TryRead<global::UnityEngine.GameObject>(out var _p0_UnityEngine_GameObject))
            {
                if (_argCount == 1)
                {
                    var gameObject = _p0_UnityEngine_GameObject;
                    var _ret0 = global::UnityEditor.PrefabUtility.GetOriginalSourceRootWhereGameObjectIsAdded(gameObject);
                    var _factory = _context.GetObjectFactory();
                    var _lret0 = _factory.Bind(_ret0);
                    var _retCount = _context.Return(_lret0);
                    return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                }
            }
            throw new global::Lua.LuaRuntimeException(_context.Thread, $"{"GetOriginalSourceRootWhereGameObjectIsAdded"}: invalid argument #{_lastArgPos}: {_lastArg} ({_lastArg.Type}), expected: {_expectedType.FullName}", 2);
        });
        private static readonly global::Lua.LuaFunction _LuaPrefabUtility_GetOutermostPrefabInstanceRoot = new global::Lua.LuaFunction("GetOutermostPrefabInstanceRoot", (_context, _) =>
        {
            global::Lua.LuaValue _lastArg = default;
            global::System.Int32 _lastArgPos = default;
            global::System.Type _expectedType = default;
            var _argCount = _context.ArgumentCount;
            var _arg0 = _lastArg = _argCount > 0 ? _context.GetArgument(0) : global::Lua.LuaValue.Nil;
            _lastArgPos = 0; _expectedType = typeof(global::UnityEngine.Object);
            if (_arg0.TryRead<global::UnityEngine.Object>(out var _p0_UnityEngine_Object))
            {
                if (_argCount == 1)
                {
                    var componentOrGameObject = _p0_UnityEngine_Object;
                    var _ret0 = global::UnityEditor.PrefabUtility.GetOutermostPrefabInstanceRoot(componentOrGameObject);
                    var _factory = _context.GetObjectFactory();
                    var _lret0 = _factory.Bind(_ret0);
                    var _retCount = _context.Return(_lret0);
                    return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                }
            }
            throw new global::Lua.LuaRuntimeException(_context.Thread, $"{"GetOutermostPrefabInstanceRoot"}: invalid argument #{_lastArgPos}: {_lastArg} ({_lastArg.Type}), expected: {_expectedType.FullName}", 2);
        });
        private static readonly global::Lua.LuaFunction _LuaPrefabUtility_GetPrefabAssetPathOfNearestInstanceRoot = new global::Lua.LuaFunction("GetPrefabAssetPathOfNearestInstanceRoot", (_context, _) =>
        {
            global::Lua.LuaValue _lastArg = default;
            global::System.Int32 _lastArgPos = default;
            global::System.Type _expectedType = default;
            var _argCount = _context.ArgumentCount;
            var _arg0 = _lastArg = _argCount > 0 ? _context.GetArgument(0) : global::Lua.LuaValue.Nil;
            _lastArgPos = 0; _expectedType = typeof(global::UnityEngine.Object);
            if (_arg0.TryRead<global::UnityEngine.Object>(out var _p0_UnityEngine_Object))
            {
                if (_argCount == 1)
                {
                    var instanceComponentOrGameObject = _p0_UnityEngine_Object;
                    var _ret0 = global::UnityEditor.PrefabUtility.GetPrefabAssetPathOfNearestInstanceRoot(instanceComponentOrGameObject);
                    var _lret0 = new global::Lua.LuaValue(_ret0);
                    var _retCount = _context.Return(_lret0);
                    return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                }
            }
            throw new global::Lua.LuaRuntimeException(_context.Thread, $"{"GetPrefabAssetPathOfNearestInstanceRoot"}: invalid argument #{_lastArgPos}: {_lastArg} ({_lastArg.Type}), expected: {_expectedType.FullName}", 2);
        });
        private static readonly global::Lua.LuaFunction _LuaPrefabUtility_GetPrefabAssetType = new global::Lua.LuaFunction("GetPrefabAssetType", (_context, _) =>
        {
            global::Lua.LuaValue _lastArg = default;
            global::System.Int32 _lastArgPos = default;
            global::System.Type _expectedType = default;
            var _argCount = _context.ArgumentCount;
            var _arg0 = _lastArg = _argCount > 0 ? _context.GetArgument(0) : global::Lua.LuaValue.Nil;
            _lastArgPos = 0; _expectedType = typeof(global::UnityEngine.Object);
            if (_arg0.TryRead<global::UnityEngine.Object>(out var _p0_UnityEngine_Object))
            {
                if (_argCount == 1)
                {
                    var componentOrGameObject = _p0_UnityEngine_Object;
                    var _ret0 = global::UnityEditor.PrefabUtility.GetPrefabAssetType(componentOrGameObject);
                    var _lret0 = new global::Lua.LuaValue((global::System.Int64)_ret0);
                    var _retCount = _context.Return(_lret0);
                    return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                }
            }
            throw new global::Lua.LuaRuntimeException(_context.Thread, $"{"GetPrefabAssetType"}: invalid argument #{_lastArgPos}: {_lastArg} ({_lastArg.Type}), expected: {_expectedType.FullName}", 2);
        });
        private static readonly global::Lua.LuaFunction _LuaPrefabUtility_GetPrefabInstanceHandle = new global::Lua.LuaFunction("GetPrefabInstanceHandle", (_context, _) =>
        {
            global::Lua.LuaValue _lastArg = default;
            global::System.Int32 _lastArgPos = default;
            global::System.Type _expectedType = default;
            var _argCount = _context.ArgumentCount;
            var _arg0 = _lastArg = _argCount > 0 ? _context.GetArgument(0) : global::Lua.LuaValue.Nil;
            _lastArgPos = 0; _expectedType = typeof(global::UnityEngine.Object);
            if (_arg0.TryRead<global::UnityEngine.Object>(out var _p0_UnityEngine_Object))
            {
                if (_argCount == 1)
                {
                    var instanceComponentOrGameObject = _p0_UnityEngine_Object;
                    var _ret0 = global::UnityEditor.PrefabUtility.GetPrefabInstanceHandle(instanceComponentOrGameObject);
                    var _factory = _context.GetObjectFactory();
                    var _lret0 = _factory.Bind(_ret0);
                    var _retCount = _context.Return(_lret0);
                    return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                }
            }
            throw new global::Lua.LuaRuntimeException(_context.Thread, $"{"GetPrefabInstanceHandle"}: invalid argument #{_lastArgPos}: {_lastArg} ({_lastArg.Type}), expected: {_expectedType.FullName}", 2);
        });
        private static readonly global::Lua.LuaFunction _LuaPrefabUtility_GetPrefabInstanceStatus = new global::Lua.LuaFunction("GetPrefabInstanceStatus", (_context, _) =>
        {
            global::Lua.LuaValue _lastArg = default;
            global::System.Int32 _lastArgPos = default;
            global::System.Type _expectedType = default;
            var _argCount = _context.ArgumentCount;
            var _arg0 = _lastArg = _argCount > 0 ? _context.GetArgument(0) : global::Lua.LuaValue.Nil;
            _lastArgPos = 0; _expectedType = typeof(global::UnityEngine.Object);
            if (_arg0.TryRead<global::UnityEngine.Object>(out var _p0_UnityEngine_Object))
            {
                if (_argCount == 1)
                {
                    var componentOrGameObject = _p0_UnityEngine_Object;
                    var _ret0 = global::UnityEditor.PrefabUtility.GetPrefabInstanceStatus(componentOrGameObject);
                    var _lret0 = new global::Lua.LuaValue((global::System.Int64)_ret0);
                    var _retCount = _context.Return(_lret0);
                    return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                }
            }
            throw new global::Lua.LuaRuntimeException(_context.Thread, $"{"GetPrefabInstanceStatus"}: invalid argument #{_lastArgPos}: {_lastArg} ({_lastArg.Type}), expected: {_expectedType.FullName}", 2);
        });
        private static readonly global::Lua.LuaFunction _LuaPrefabUtility_GetPropertyModifications = new global::Lua.LuaFunction("GetPropertyModifications", (_context, _) =>
        {
            global::Lua.LuaValue _lastArg = default;
            global::System.Int32 _lastArgPos = default;
            global::System.Type _expectedType = default;
            var _argCount = _context.ArgumentCount;
            var _arg0 = _lastArg = _argCount > 0 ? _context.GetArgument(0) : global::Lua.LuaValue.Nil;
            _lastArgPos = 0; _expectedType = typeof(global::UnityEngine.Object);
            if (_arg0.TryRead<global::UnityEngine.Object>(out var _p0_UnityEngine_Object))
            {
                if (_argCount == 1)
                {
                    var targetPrefab = _p0_UnityEngine_Object;
                    var _ret0 = global::UnityEditor.PrefabUtility.GetPropertyModifications(targetPrefab);
                    var _factory = _context.GetObjectFactory();
                    var _lret0 = _factory.Bind(_ret0);
                    var _retCount = _context.Return(_lret0);
                    return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                }
            }
            throw new global::Lua.LuaRuntimeException(_context.Thread, $"{"GetPropertyModifications"}: invalid argument #{_lastArgPos}: {_lastArg} ({_lastArg.Type}), expected: {_expectedType.FullName}", 2);
        });
        private static readonly global::Lua.LuaFunction _LuaPrefabUtility_HasManagedReferencesWithMissingTypes = new global::Lua.LuaFunction("HasManagedReferencesWithMissingTypes", (_context, _) =>
        {
            global::Lua.LuaValue _lastArg = default;
            global::System.Int32 _lastArgPos = default;
            global::System.Type _expectedType = default;
            var _argCount = _context.ArgumentCount;
            var _arg0 = _lastArg = _argCount > 0 ? _context.GetArgument(0) : global::Lua.LuaValue.Nil;
            _lastArgPos = 0; _expectedType = typeof(global::UnityEngine.Object);
            if (_arg0.TryRead<global::UnityEngine.Object>(out var _p0_UnityEngine_Object))
            {
                if (_argCount == 1)
                {
                    var assetComponentOrGameObject = _p0_UnityEngine_Object;
                    var _ret0 = global::UnityEditor.PrefabUtility.HasManagedReferencesWithMissingTypes(assetComponentOrGameObject);
                    var _lret0 = new global::Lua.LuaValue(_ret0);
                    var _retCount = _context.Return(_lret0);
                    return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                }
            }
            throw new global::Lua.LuaRuntimeException(_context.Thread, $"{"HasManagedReferencesWithMissingTypes"}: invalid argument #{_lastArgPos}: {_lastArg} ({_lastArg.Type}), expected: {_expectedType.FullName}", 2);
        });
        private static readonly global::Lua.LuaFunction _LuaPrefabUtility_HasPrefabInstanceAnyOverrides = new global::Lua.LuaFunction("HasPrefabInstanceAnyOverrides", (_context, _) =>
        {
            global::Lua.LuaValue _lastArg = default;
            global::System.Int32 _lastArgPos = default;
            global::System.Type _expectedType = default;
            var _argCount = _context.ArgumentCount;
            var _arg0 = _lastArg = _argCount > 0 ? _context.GetArgument(0) : global::Lua.LuaValue.Nil;
            _lastArgPos = 0; _expectedType = typeof(global::UnityEngine.GameObject);
            if (_arg0.TryRead<global::UnityEngine.GameObject>(out var _p0_UnityEngine_GameObject))
            {
                var _arg1 = _lastArg = _argCount > 1 ? _context.GetArgument(1) : global::Lua.LuaValue.Nil;
                _lastArgPos = 1; _expectedType = typeof(global::System.Boolean);
                if (_arg1.TryRead<global::System.Boolean>(out var _p1_System_Boolean))
                {
                    if (_argCount == 2)
                    {
                        var instanceRoot = _p0_UnityEngine_GameObject;
                        var includeDefaultOverrides = _p1_System_Boolean;
                        var _ret0 = global::UnityEditor.PrefabUtility.HasPrefabInstanceAnyOverrides(instanceRoot, includeDefaultOverrides);
                        var _lret0 = new global::Lua.LuaValue(_ret0);
                        var _retCount = _context.Return(_lret0);
                        return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                    }
                }
            }
            throw new global::Lua.LuaRuntimeException(_context.Thread, $"{"HasPrefabInstanceAnyOverrides"}: invalid argument #{_lastArgPos}: {_lastArg} ({_lastArg.Type}), expected: {_expectedType.FullName}", 2);
        });
        private static readonly global::Lua.LuaFunction _LuaPrefabUtility_InstantiatePrefab = new global::Lua.LuaFunction("InstantiatePrefab", (_context, _) =>
        {
            global::Lua.LuaValue _lastArg = default;
            global::System.Int32 _lastArgPos = default;
            global::System.Type _expectedType = default;
            var _argCount = _context.ArgumentCount;
            var _arg0 = _lastArg = _argCount > 0 ? _context.GetArgument(0) : global::Lua.LuaValue.Nil;
            _lastArgPos = 0; _expectedType = typeof(global::UnityEngine.Object);
            if (_arg0.TryRead<global::UnityEngine.Object>(out var _p0_UnityEngine_Object))
            {
                if (_argCount == 1)
                {
                    var assetComponentOrGameObject = _p0_UnityEngine_Object;
                    var _ret0 = global::UnityEditor.PrefabUtility.InstantiatePrefab(assetComponentOrGameObject);
                    var _factory = _context.GetObjectFactory();
                    var _lret0 = _factory.Bind(_ret0);
                    var _retCount = _context.Return(_lret0);
                    return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                }
                var _arg1 = _lastArg = _argCount > 1 ? _context.GetArgument(1) : global::Lua.LuaValue.Nil;
                _lastArgPos = 1; _expectedType = typeof(global::UnityEngine.SceneManagement.Scene);
                if (_arg1.TryRead<global::UnityEngine.SceneManagement.Scene>(out var _p1_UnityEngine_SceneManagement_Scene))
                {
                    if (_argCount == 2)
                    {
                        var assetComponentOrGameObject = _p0_UnityEngine_Object;
                        var destinationScene = _p1_UnityEngine_SceneManagement_Scene;
                        var _ret0 = global::UnityEditor.PrefabUtility.InstantiatePrefab(assetComponentOrGameObject, destinationScene);
                        var _factory = _context.GetObjectFactory();
                        var _lret0 = _factory.Bind(_ret0);
                        var _retCount = _context.Return(_lret0);
                        return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                    }
                }
                _lastArgPos = 1; _expectedType = typeof(global::UnityEngine.Transform);
                if (_arg1.TryRead<global::UnityEngine.Transform>(out var _p1_UnityEngine_Transform))
                {
                    if (_argCount == 2)
                    {
                        var assetComponentOrGameObject = _p0_UnityEngine_Object;
                        var parent = _p1_UnityEngine_Transform;
                        var _ret0 = global::UnityEditor.PrefabUtility.InstantiatePrefab(assetComponentOrGameObject, parent);
                        var _factory = _context.GetObjectFactory();
                        var _lret0 = _factory.Bind(_ret0);
                        var _retCount = _context.Return(_lret0);
                        return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                    }
                }
            }
            throw new global::Lua.LuaRuntimeException(_context.Thread, $"{"InstantiatePrefab"}: invalid argument #{_lastArgPos}: {_lastArg} ({_lastArg.Type}), expected: {_expectedType.FullName}", 2);
        });
        private static readonly global::Lua.LuaFunction _LuaPrefabUtility_IsAddedComponentOverride = new global::Lua.LuaFunction("IsAddedComponentOverride", (_context, _) =>
        {
            global::Lua.LuaValue _lastArg = default;
            global::System.Int32 _lastArgPos = default;
            global::System.Type _expectedType = default;
            var _argCount = _context.ArgumentCount;
            var _arg0 = _lastArg = _argCount > 0 ? _context.GetArgument(0) : global::Lua.LuaValue.Nil;
            _lastArgPos = 0; _expectedType = typeof(global::UnityEngine.Object);
            if (_arg0.TryRead<global::UnityEngine.Object>(out var _p0_UnityEngine_Object))
            {
                if (_argCount == 1)
                {
                    var component = _p0_UnityEngine_Object;
                    var _ret0 = global::UnityEditor.PrefabUtility.IsAddedComponentOverride(component);
                    var _lret0 = new global::Lua.LuaValue(_ret0);
                    var _retCount = _context.Return(_lret0);
                    return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                }
            }
            throw new global::Lua.LuaRuntimeException(_context.Thread, $"{"IsAddedComponentOverride"}: invalid argument #{_lastArgPos}: {_lastArg} ({_lastArg.Type}), expected: {_expectedType.FullName}", 2);
        });
        private static readonly global::Lua.LuaFunction _LuaPrefabUtility_IsAddedGameObjectOverride = new global::Lua.LuaFunction("IsAddedGameObjectOverride", (_context, _) =>
        {
            global::Lua.LuaValue _lastArg = default;
            global::System.Int32 _lastArgPos = default;
            global::System.Type _expectedType = default;
            var _argCount = _context.ArgumentCount;
            var _arg0 = _lastArg = _argCount > 0 ? _context.GetArgument(0) : global::Lua.LuaValue.Nil;
            _lastArgPos = 0; _expectedType = typeof(global::UnityEngine.GameObject);
            if (_arg0.TryRead<global::UnityEngine.GameObject>(out var _p0_UnityEngine_GameObject))
            {
                if (_argCount == 1)
                {
                    var gameObject = _p0_UnityEngine_GameObject;
                    var _ret0 = global::UnityEditor.PrefabUtility.IsAddedGameObjectOverride(gameObject);
                    var _lret0 = new global::Lua.LuaValue(_ret0);
                    var _retCount = _context.Return(_lret0);
                    return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                }
            }
            throw new global::Lua.LuaRuntimeException(_context.Thread, $"{"IsAddedGameObjectOverride"}: invalid argument #{_lastArgPos}: {_lastArg} ({_lastArg.Type}), expected: {_expectedType.FullName}", 2);
        });
        private static readonly global::Lua.LuaFunction _LuaPrefabUtility_IsAnyPrefabInstanceRoot = new global::Lua.LuaFunction("IsAnyPrefabInstanceRoot", (_context, _) =>
        {
            global::Lua.LuaValue _lastArg = default;
            global::System.Int32 _lastArgPos = default;
            global::System.Type _expectedType = default;
            var _argCount = _context.ArgumentCount;
            var _arg0 = _lastArg = _argCount > 0 ? _context.GetArgument(0) : global::Lua.LuaValue.Nil;
            _lastArgPos = 0; _expectedType = typeof(global::UnityEngine.GameObject);
            if (_arg0.TryRead<global::UnityEngine.GameObject>(out var _p0_UnityEngine_GameObject))
            {
                if (_argCount == 1)
                {
                    var gameObject = _p0_UnityEngine_GameObject;
                    var _ret0 = global::UnityEditor.PrefabUtility.IsAnyPrefabInstanceRoot(gameObject);
                    var _lret0 = new global::Lua.LuaValue(_ret0);
                    var _retCount = _context.Return(_lret0);
                    return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                }
            }
            throw new global::Lua.LuaRuntimeException(_context.Thread, $"{"IsAnyPrefabInstanceRoot"}: invalid argument #{_lastArgPos}: {_lastArg} ({_lastArg.Type}), expected: {_expectedType.FullName}", 2);
        });
        private static readonly global::Lua.LuaFunction _LuaPrefabUtility_IsDefaultOverride = new global::Lua.LuaFunction("IsDefaultOverride", (_context, _) =>
        {
            global::Lua.LuaValue _lastArg = default;
            global::System.Int32 _lastArgPos = default;
            global::System.Type _expectedType = default;
            var _argCount = _context.ArgumentCount;
            var _arg0 = _lastArg = _argCount > 0 ? _context.GetArgument(0) : global::Lua.LuaValue.Nil;
            _lastArgPos = 0; _expectedType = typeof(global::Luny.UnityEditor.LuaPropertyModification);
            if (_arg0.TryRead<global::Luny.UnityEditor.LuaPropertyModification>(out var _p0_UnityEditor_PropertyModification))
            {
                if (_argCount == 1)
                {
                    var modification = _p0_UnityEditor_PropertyModification.Instance;
                    var _ret0 = global::UnityEditor.PrefabUtility.IsDefaultOverride(modification);
                    var _lret0 = new global::Lua.LuaValue(_ret0);
                    var _retCount = _context.Return(_lret0);
                    return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                }
            }
            throw new global::Lua.LuaRuntimeException(_context.Thread, $"{"IsDefaultOverride"}: invalid argument #{_lastArgPos}: {_lastArg} ({_lastArg.Type}), expected: {_expectedType.FullName}", 2);
        });
        private static readonly global::Lua.LuaFunction _LuaPrefabUtility_IsOutermostPrefabInstanceRoot = new global::Lua.LuaFunction("IsOutermostPrefabInstanceRoot", (_context, _) =>
        {
            global::Lua.LuaValue _lastArg = default;
            global::System.Int32 _lastArgPos = default;
            global::System.Type _expectedType = default;
            var _argCount = _context.ArgumentCount;
            var _arg0 = _lastArg = _argCount > 0 ? _context.GetArgument(0) : global::Lua.LuaValue.Nil;
            _lastArgPos = 0; _expectedType = typeof(global::UnityEngine.GameObject);
            if (_arg0.TryRead<global::UnityEngine.GameObject>(out var _p0_UnityEngine_GameObject))
            {
                if (_argCount == 1)
                {
                    var gameObject = _p0_UnityEngine_GameObject;
                    var _ret0 = global::UnityEditor.PrefabUtility.IsOutermostPrefabInstanceRoot(gameObject);
                    var _lret0 = new global::Lua.LuaValue(_ret0);
                    var _retCount = _context.Return(_lret0);
                    return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                }
            }
            throw new global::Lua.LuaRuntimeException(_context.Thread, $"{"IsOutermostPrefabInstanceRoot"}: invalid argument #{_lastArgPos}: {_lastArg} ({_lastArg.Type}), expected: {_expectedType.FullName}", 2);
        });
        private static readonly global::Lua.LuaFunction _LuaPrefabUtility_IsPartOfAnyPrefab = new global::Lua.LuaFunction("IsPartOfAnyPrefab", (_context, _) =>
        {
            global::Lua.LuaValue _lastArg = default;
            global::System.Int32 _lastArgPos = default;
            global::System.Type _expectedType = default;
            var _argCount = _context.ArgumentCount;
            var _arg0 = _lastArg = _argCount > 0 ? _context.GetArgument(0) : global::Lua.LuaValue.Nil;
            _lastArgPos = 0; _expectedType = typeof(global::UnityEngine.Object);
            if (_arg0.TryRead<global::UnityEngine.Object>(out var _p0_UnityEngine_Object))
            {
                if (_argCount == 1)
                {
                    var componentOrGameObject = _p0_UnityEngine_Object;
                    var _ret0 = global::UnityEditor.PrefabUtility.IsPartOfAnyPrefab(componentOrGameObject);
                    var _lret0 = new global::Lua.LuaValue(_ret0);
                    var _retCount = _context.Return(_lret0);
                    return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                }
            }
            throw new global::Lua.LuaRuntimeException(_context.Thread, $"{"IsPartOfAnyPrefab"}: invalid argument #{_lastArgPos}: {_lastArg} ({_lastArg.Type}), expected: {_expectedType.FullName}", 2);
        });
        private static readonly global::Lua.LuaFunction _LuaPrefabUtility_IsPartOfImmutablePrefab = new global::Lua.LuaFunction("IsPartOfImmutablePrefab", (_context, _) =>
        {
            global::Lua.LuaValue _lastArg = default;
            global::System.Int32 _lastArgPos = default;
            global::System.Type _expectedType = default;
            var _argCount = _context.ArgumentCount;
            var _arg0 = _lastArg = _argCount > 0 ? _context.GetArgument(0) : global::Lua.LuaValue.Nil;
            _lastArgPos = 0; _expectedType = typeof(global::UnityEngine.Object);
            if (_arg0.TryRead<global::UnityEngine.Object>(out var _p0_UnityEngine_Object))
            {
                if (_argCount == 1)
                {
                    var componentOrGameObject = _p0_UnityEngine_Object;
                    var _ret0 = global::UnityEditor.PrefabUtility.IsPartOfImmutablePrefab(componentOrGameObject);
                    var _lret0 = new global::Lua.LuaValue(_ret0);
                    var _retCount = _context.Return(_lret0);
                    return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                }
            }
            throw new global::Lua.LuaRuntimeException(_context.Thread, $"{"IsPartOfImmutablePrefab"}: invalid argument #{_lastArgPos}: {_lastArg} ({_lastArg.Type}), expected: {_expectedType.FullName}", 2);
        });
        private static readonly global::Lua.LuaFunction _LuaPrefabUtility_IsPartOfModelPrefab = new global::Lua.LuaFunction("IsPartOfModelPrefab", (_context, _) =>
        {
            global::Lua.LuaValue _lastArg = default;
            global::System.Int32 _lastArgPos = default;
            global::System.Type _expectedType = default;
            var _argCount = _context.ArgumentCount;
            var _arg0 = _lastArg = _argCount > 0 ? _context.GetArgument(0) : global::Lua.LuaValue.Nil;
            _lastArgPos = 0; _expectedType = typeof(global::UnityEngine.Object);
            if (_arg0.TryRead<global::UnityEngine.Object>(out var _p0_UnityEngine_Object))
            {
                if (_argCount == 1)
                {
                    var componentOrGameObject = _p0_UnityEngine_Object;
                    var _ret0 = global::UnityEditor.PrefabUtility.IsPartOfModelPrefab(componentOrGameObject);
                    var _lret0 = new global::Lua.LuaValue(_ret0);
                    var _retCount = _context.Return(_lret0);
                    return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                }
            }
            throw new global::Lua.LuaRuntimeException(_context.Thread, $"{"IsPartOfModelPrefab"}: invalid argument #{_lastArgPos}: {_lastArg} ({_lastArg.Type}), expected: {_expectedType.FullName}", 2);
        });
        private static readonly global::Lua.LuaFunction _LuaPrefabUtility_IsPartOfNonAssetPrefabInstance = new global::Lua.LuaFunction("IsPartOfNonAssetPrefabInstance", (_context, _) =>
        {
            global::Lua.LuaValue _lastArg = default;
            global::System.Int32 _lastArgPos = default;
            global::System.Type _expectedType = default;
            var _argCount = _context.ArgumentCount;
            var _arg0 = _lastArg = _argCount > 0 ? _context.GetArgument(0) : global::Lua.LuaValue.Nil;
            _lastArgPos = 0; _expectedType = typeof(global::UnityEngine.Object);
            if (_arg0.TryRead<global::UnityEngine.Object>(out var _p0_UnityEngine_Object))
            {
                if (_argCount == 1)
                {
                    var componentOrGameObject = _p0_UnityEngine_Object;
                    var _ret0 = global::UnityEditor.PrefabUtility.IsPartOfNonAssetPrefabInstance(componentOrGameObject);
                    var _lret0 = new global::Lua.LuaValue(_ret0);
                    var _retCount = _context.Return(_lret0);
                    return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                }
            }
            throw new global::Lua.LuaRuntimeException(_context.Thread, $"{"IsPartOfNonAssetPrefabInstance"}: invalid argument #{_lastArgPos}: {_lastArg} ({_lastArg.Type}), expected: {_expectedType.FullName}", 2);
        });
        private static readonly global::Lua.LuaFunction _LuaPrefabUtility_IsPartOfPrefabAsset = new global::Lua.LuaFunction("IsPartOfPrefabAsset", (_context, _) =>
        {
            global::Lua.LuaValue _lastArg = default;
            global::System.Int32 _lastArgPos = default;
            global::System.Type _expectedType = default;
            var _argCount = _context.ArgumentCount;
            var _arg0 = _lastArg = _argCount > 0 ? _context.GetArgument(0) : global::Lua.LuaValue.Nil;
            _lastArgPos = 0; _expectedType = typeof(global::UnityEngine.Object);
            if (_arg0.TryRead<global::UnityEngine.Object>(out var _p0_UnityEngine_Object))
            {
                if (_argCount == 1)
                {
                    var componentOrGameObject = _p0_UnityEngine_Object;
                    var _ret0 = global::UnityEditor.PrefabUtility.IsPartOfPrefabAsset(componentOrGameObject);
                    var _lret0 = new global::Lua.LuaValue(_ret0);
                    var _retCount = _context.Return(_lret0);
                    return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                }
            }
            throw new global::Lua.LuaRuntimeException(_context.Thread, $"{"IsPartOfPrefabAsset"}: invalid argument #{_lastArgPos}: {_lastArg} ({_lastArg.Type}), expected: {_expectedType.FullName}", 2);
        });
        private static readonly global::Lua.LuaFunction _LuaPrefabUtility_IsPartOfPrefabInstance = new global::Lua.LuaFunction("IsPartOfPrefabInstance", (_context, _) =>
        {
            global::Lua.LuaValue _lastArg = default;
            global::System.Int32 _lastArgPos = default;
            global::System.Type _expectedType = default;
            var _argCount = _context.ArgumentCount;
            var _arg0 = _lastArg = _argCount > 0 ? _context.GetArgument(0) : global::Lua.LuaValue.Nil;
            _lastArgPos = 0; _expectedType = typeof(global::UnityEngine.Object);
            if (_arg0.TryRead<global::UnityEngine.Object>(out var _p0_UnityEngine_Object))
            {
                if (_argCount == 1)
                {
                    var componentOrGameObject = _p0_UnityEngine_Object;
                    var _ret0 = global::UnityEditor.PrefabUtility.IsPartOfPrefabInstance(componentOrGameObject);
                    var _lret0 = new global::Lua.LuaValue(_ret0);
                    var _retCount = _context.Return(_lret0);
                    return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                }
            }
            throw new global::Lua.LuaRuntimeException(_context.Thread, $"{"IsPartOfPrefabInstance"}: invalid argument #{_lastArgPos}: {_lastArg} ({_lastArg.Type}), expected: {_expectedType.FullName}", 2);
        });
        private static readonly global::Lua.LuaFunction _LuaPrefabUtility_IsPartOfPrefabThatCanBeAppliedTo = new global::Lua.LuaFunction("IsPartOfPrefabThatCanBeAppliedTo", (_context, _) =>
        {
            global::Lua.LuaValue _lastArg = default;
            global::System.Int32 _lastArgPos = default;
            global::System.Type _expectedType = default;
            var _argCount = _context.ArgumentCount;
            var _arg0 = _lastArg = _argCount > 0 ? _context.GetArgument(0) : global::Lua.LuaValue.Nil;
            _lastArgPos = 0; _expectedType = typeof(global::UnityEngine.Object);
            if (_arg0.TryRead<global::UnityEngine.Object>(out var _p0_UnityEngine_Object))
            {
                if (_argCount == 1)
                {
                    var componentOrGameObject = _p0_UnityEngine_Object;
                    var _ret0 = global::UnityEditor.PrefabUtility.IsPartOfPrefabThatCanBeAppliedTo(componentOrGameObject);
                    var _lret0 = new global::Lua.LuaValue(_ret0);
                    var _retCount = _context.Return(_lret0);
                    return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                }
            }
            throw new global::Lua.LuaRuntimeException(_context.Thread, $"{"IsPartOfPrefabThatCanBeAppliedTo"}: invalid argument #{_lastArgPos}: {_lastArg} ({_lastArg.Type}), expected: {_expectedType.FullName}", 2);
        });
        private static readonly global::Lua.LuaFunction _LuaPrefabUtility_IsPartOfRegularPrefab = new global::Lua.LuaFunction("IsPartOfRegularPrefab", (_context, _) =>
        {
            global::Lua.LuaValue _lastArg = default;
            global::System.Int32 _lastArgPos = default;
            global::System.Type _expectedType = default;
            var _argCount = _context.ArgumentCount;
            var _arg0 = _lastArg = _argCount > 0 ? _context.GetArgument(0) : global::Lua.LuaValue.Nil;
            _lastArgPos = 0; _expectedType = typeof(global::UnityEngine.Object);
            if (_arg0.TryRead<global::UnityEngine.Object>(out var _p0_UnityEngine_Object))
            {
                if (_argCount == 1)
                {
                    var componentOrGameObject = _p0_UnityEngine_Object;
                    var _ret0 = global::UnityEditor.PrefabUtility.IsPartOfRegularPrefab(componentOrGameObject);
                    var _lret0 = new global::Lua.LuaValue(_ret0);
                    var _retCount = _context.Return(_lret0);
                    return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                }
            }
            throw new global::Lua.LuaRuntimeException(_context.Thread, $"{"IsPartOfRegularPrefab"}: invalid argument #{_lastArgPos}: {_lastArg} ({_lastArg.Type}), expected: {_expectedType.FullName}", 2);
        });
        private static readonly global::Lua.LuaFunction _LuaPrefabUtility_IsPartOfVariantPrefab = new global::Lua.LuaFunction("IsPartOfVariantPrefab", (_context, _) =>
        {
            global::Lua.LuaValue _lastArg = default;
            global::System.Int32 _lastArgPos = default;
            global::System.Type _expectedType = default;
            var _argCount = _context.ArgumentCount;
            var _arg0 = _lastArg = _argCount > 0 ? _context.GetArgument(0) : global::Lua.LuaValue.Nil;
            _lastArgPos = 0; _expectedType = typeof(global::UnityEngine.Object);
            if (_arg0.TryRead<global::UnityEngine.Object>(out var _p0_UnityEngine_Object))
            {
                if (_argCount == 1)
                {
                    var componentOrGameObject = _p0_UnityEngine_Object;
                    var _ret0 = global::UnityEditor.PrefabUtility.IsPartOfVariantPrefab(componentOrGameObject);
                    var _lret0 = new global::Lua.LuaValue(_ret0);
                    var _retCount = _context.Return(_lret0);
                    return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                }
            }
            throw new global::Lua.LuaRuntimeException(_context.Thread, $"{"IsPartOfVariantPrefab"}: invalid argument #{_lastArgPos}: {_lastArg} ({_lastArg.Type}), expected: {_expectedType.FullName}", 2);
        });
        private static readonly global::Lua.LuaFunction _LuaPrefabUtility_IsPrefabAssetMissing = new global::Lua.LuaFunction("IsPrefabAssetMissing", (_context, _) =>
        {
            global::Lua.LuaValue _lastArg = default;
            global::System.Int32 _lastArgPos = default;
            global::System.Type _expectedType = default;
            var _argCount = _context.ArgumentCount;
            var _arg0 = _lastArg = _argCount > 0 ? _context.GetArgument(0) : global::Lua.LuaValue.Nil;
            _lastArgPos = 0; _expectedType = typeof(global::UnityEngine.Object);
            if (_arg0.TryRead<global::UnityEngine.Object>(out var _p0_UnityEngine_Object))
            {
                if (_argCount == 1)
                {
                    var instanceComponentOrGameObject = _p0_UnityEngine_Object;
                    var _ret0 = global::UnityEditor.PrefabUtility.IsPrefabAssetMissing(instanceComponentOrGameObject);
                    var _lret0 = new global::Lua.LuaValue(_ret0);
                    var _retCount = _context.Return(_lret0);
                    return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                }
            }
            throw new global::Lua.LuaRuntimeException(_context.Thread, $"{"IsPrefabAssetMissing"}: invalid argument #{_lastArgPos}: {_lastArg} ({_lastArg.Type}), expected: {_expectedType.FullName}", 2);
        });
        private static readonly global::Lua.LuaFunction _LuaPrefabUtility_LoadPrefabContents = new global::Lua.LuaFunction("LoadPrefabContents", (_context, _) =>
        {
            global::Lua.LuaValue _lastArg = default;
            global::System.Int32 _lastArgPos = default;
            global::System.Type _expectedType = default;
            var _argCount = _context.ArgumentCount;
            var _arg0 = _lastArg = _argCount > 0 ? _context.GetArgument(0) : global::Lua.LuaValue.Nil;
            _lastArgPos = 0; _expectedType = typeof(global::System.String);
            if (_arg0.TryRead<global::System.String>(out var _p0_System_String))
            {
                if (_argCount == 1)
                {
                    var assetPath = _p0_System_String;
                    var _ret0 = global::UnityEditor.PrefabUtility.LoadPrefabContents(assetPath);
                    var _factory = _context.GetObjectFactory();
                    var _lret0 = _factory.Bind(_ret0);
                    var _retCount = _context.Return(_lret0);
                    return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                }
            }
            throw new global::Lua.LuaRuntimeException(_context.Thread, $"{"LoadPrefabContents"}: invalid argument #{_lastArgPos}: {_lastArg} ({_lastArg.Type}), expected: {_expectedType.FullName}", 2);
        });
        private static readonly global::Lua.LuaFunction _LuaPrefabUtility_LoadPrefabContentsIntoPreviewScene = new global::Lua.LuaFunction("LoadPrefabContentsIntoPreviewScene", (_context, _) =>
        {
            global::Lua.LuaValue _lastArg = default;
            global::System.Int32 _lastArgPos = default;
            global::System.Type _expectedType = default;
            var _argCount = _context.ArgumentCount;
            var _arg0 = _lastArg = _argCount > 0 ? _context.GetArgument(0) : global::Lua.LuaValue.Nil;
            _lastArgPos = 0; _expectedType = typeof(global::System.String);
            if (_arg0.TryRead<global::System.String>(out var _p0_System_String))
            {
                var _arg1 = _lastArg = _argCount > 1 ? _context.GetArgument(1) : global::Lua.LuaValue.Nil;
                _lastArgPos = 1; _expectedType = typeof(global::UnityEngine.SceneManagement.Scene);
                if (_arg1.TryRead<global::UnityEngine.SceneManagement.Scene>(out var _p1_UnityEngine_SceneManagement_Scene))
                {
                    if (_argCount == 2)
                    {
                        var prefabPath = _p0_System_String;
                        var scene = _p1_UnityEngine_SceneManagement_Scene;
                        global::UnityEditor.PrefabUtility.LoadPrefabContentsIntoPreviewScene(prefabPath, scene);
                        var _retCount = _context.Return();
                        return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                    }
                }
            }
            throw new global::Lua.LuaRuntimeException(_context.Thread, $"{"LoadPrefabContentsIntoPreviewScene"}: invalid argument #{_lastArgPos}: {_lastArg} ({_lastArg.Type}), expected: {_expectedType.FullName}", 2);
        });
        private static readonly global::Lua.LuaFunction _LuaPrefabUtility_MergePrefabInstance = new global::Lua.LuaFunction("MergePrefabInstance", (_context, _) =>
        {
            global::Lua.LuaValue _lastArg = default;
            global::System.Int32 _lastArgPos = default;
            global::System.Type _expectedType = default;
            var _argCount = _context.ArgumentCount;
            var _arg0 = _lastArg = _argCount > 0 ? _context.GetArgument(0) : global::Lua.LuaValue.Nil;
            _lastArgPos = 0; _expectedType = typeof(global::UnityEngine.GameObject);
            if (_arg0.TryRead<global::UnityEngine.GameObject>(out var _p0_UnityEngine_GameObject))
            {
                if (_argCount == 1)
                {
                    var instanceRoot = _p0_UnityEngine_GameObject;
                    global::UnityEditor.PrefabUtility.MergePrefabInstance(instanceRoot);
                    var _retCount = _context.Return();
                    return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                }
            }
            throw new global::Lua.LuaRuntimeException(_context.Thread, $"{"MergePrefabInstance"}: invalid argument #{_lastArgPos}: {_lastArg} ({_lastArg.Type}), expected: {_expectedType.FullName}", 2);
        });
        private static readonly global::Lua.LuaFunction _LuaPrefabUtility_RecordPrefabInstancePropertyModifications = new global::Lua.LuaFunction("RecordPrefabInstancePropertyModifications", (_context, _) =>
        {
            global::Lua.LuaValue _lastArg = default;
            global::System.Int32 _lastArgPos = default;
            global::System.Type _expectedType = default;
            var _argCount = _context.ArgumentCount;
            var _arg0 = _lastArg = _argCount > 0 ? _context.GetArgument(0) : global::Lua.LuaValue.Nil;
            _lastArgPos = 0; _expectedType = typeof(global::UnityEngine.Object);
            if (_arg0.TryRead<global::UnityEngine.Object>(out var _p0_UnityEngine_Object))
            {
                if (_argCount == 1)
                {
                    var targetObject = _p0_UnityEngine_Object;
                    global::UnityEditor.PrefabUtility.RecordPrefabInstancePropertyModifications(targetObject);
                    var _retCount = _context.Return();
                    return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                }
            }
            throw new global::Lua.LuaRuntimeException(_context.Thread, $"{"RecordPrefabInstancePropertyModifications"}: invalid argument #{_lastArgPos}: {_lastArg} ({_lastArg.Type}), expected: {_expectedType.FullName}", 2);
        });
        private static readonly global::Lua.LuaFunction _LuaPrefabUtility_RemoveUnusedOverrides = new global::Lua.LuaFunction("RemoveUnusedOverrides", (_context, _) =>
        {
            global::Lua.LuaValue _lastArg = default;
            global::System.Int32 _lastArgPos = default;
            global::System.Type _expectedType = default;
            var _argCount = _context.ArgumentCount;
            var _arg0 = _lastArg = _argCount > 0 ? _context.GetArgument(0) : global::Lua.LuaValue.Nil;
            _lastArgPos = 0; _expectedType = typeof(global::UnityEngine.GameObject[]);
            if (_arg0.TryReadArray<global::UnityEngine.GameObject>(out var _p0_UnityEngine_GameObjectArray))
            {
                var _arg1 = _lastArg = _argCount > 1 ? _context.GetArgument(1) : global::Lua.LuaValue.Nil;
                _lastArgPos = 1; _expectedType = typeof(global::UnityEditor.InteractionMode);
                if (_arg1.TryRead<global::UnityEditor.InteractionMode>(out var _p1_UnityEditor_InteractionMode))
                {
                    if (_argCount == 2)
                    {
                        var prefabInstances = _p0_UnityEngine_GameObjectArray;
                        var action = _p1_UnityEditor_InteractionMode;
                        global::UnityEditor.PrefabUtility.RemoveUnusedOverrides(prefabInstances, action);
                        var _retCount = _context.Return();
                        return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                    }
                }
            }
            throw new global::Lua.LuaRuntimeException(_context.Thread, $"{"RemoveUnusedOverrides"}: invalid argument #{_lastArgPos}: {_lastArg} ({_lastArg.Type}), expected: {_expectedType.FullName}", 2);
        });
        private static readonly global::Lua.LuaFunction _LuaPrefabUtility_ReplacePrefabAssetOfPrefabInstance = new global::Lua.LuaFunction("ReplacePrefabAssetOfPrefabInstance", (_context, _) =>
        {
            global::Lua.LuaValue _lastArg = default;
            global::System.Int32 _lastArgPos = default;
            global::System.Type _expectedType = default;
            var _argCount = _context.ArgumentCount;
            var _arg0 = _lastArg = _argCount > 0 ? _context.GetArgument(0) : global::Lua.LuaValue.Nil;
            _lastArgPos = 0; _expectedType = typeof(global::UnityEngine.GameObject);
            if (_arg0.TryRead<global::UnityEngine.GameObject>(out var _p0_UnityEngine_GameObject))
            {
                var _arg1 = _lastArg = _argCount > 1 ? _context.GetArgument(1) : global::Lua.LuaValue.Nil;
                _lastArgPos = 1; _expectedType = typeof(global::UnityEngine.GameObject);
                if (_arg1.TryRead<global::UnityEngine.GameObject>(out var _p1_UnityEngine_GameObject))
                {
                    var _arg2 = _lastArg = _argCount > 2 ? _context.GetArgument(2) : global::Lua.LuaValue.Nil;
                    _lastArgPos = 2; _expectedType = typeof(global::UnityEditor.InteractionMode);
                    if (_arg2.TryRead<global::UnityEditor.InteractionMode>(out var _p2_UnityEditor_InteractionMode))
                    {
                        if (_argCount == 3)
                        {
                            var prefabInstanceRoot = _p0_UnityEngine_GameObject;
                            var prefabAssetRoot = _p1_UnityEngine_GameObject;
                            var mode = _p2_UnityEditor_InteractionMode;
                            global::UnityEditor.PrefabUtility.ReplacePrefabAssetOfPrefabInstance(prefabInstanceRoot, prefabAssetRoot, mode);
                            var _retCount = _context.Return();
                            return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                        }
                    }
                    _lastArgPos = 2; _expectedType = typeof(global::Luny.UnityEditor.LuaPrefabReplacingSettings);
                    if (_arg2.TryRead<global::Luny.UnityEditor.LuaPrefabReplacingSettings>(out var _p2_UnityEditor_PrefabReplacingSettings))
                    {
                        var _arg3 = _lastArg = _argCount > 3 ? _context.GetArgument(3) : global::Lua.LuaValue.Nil;
                        _lastArgPos = 3; _expectedType = typeof(global::UnityEditor.InteractionMode);
                        if (_arg3.TryRead<global::UnityEditor.InteractionMode>(out var _p3_UnityEditor_InteractionMode))
                        {
                            if (_argCount == 4)
                            {
                                var prefabInstanceRoot = _p0_UnityEngine_GameObject;
                                var prefabAssetRoot = _p1_UnityEngine_GameObject;
                                var settings = _p2_UnityEditor_PrefabReplacingSettings.Instance;
                                var mode = _p3_UnityEditor_InteractionMode;
                                global::UnityEditor.PrefabUtility.ReplacePrefabAssetOfPrefabInstance(prefabInstanceRoot, prefabAssetRoot, settings, mode);
                                var _retCount = _context.Return();
                                return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                            }
                        }
                    }
                }
            }
            throw new global::Lua.LuaRuntimeException(_context.Thread, $"{"ReplacePrefabAssetOfPrefabInstance"}: invalid argument #{_lastArgPos}: {_lastArg} ({_lastArg.Type}), expected: {_expectedType.FullName}", 2);
        });
        private static readonly global::Lua.LuaFunction _LuaPrefabUtility_ReplacePrefabAssetOfPrefabInstances = new global::Lua.LuaFunction("ReplacePrefabAssetOfPrefabInstances", (_context, _) =>
        {
            global::Lua.LuaValue _lastArg = default;
            global::System.Int32 _lastArgPos = default;
            global::System.Type _expectedType = default;
            var _argCount = _context.ArgumentCount;
            var _arg0 = _lastArg = _argCount > 0 ? _context.GetArgument(0) : global::Lua.LuaValue.Nil;
            _lastArgPos = 0; _expectedType = typeof(global::UnityEngine.GameObject[]);
            if (_arg0.TryReadArray<global::UnityEngine.GameObject>(out var _p0_UnityEngine_GameObjectArray))
            {
                var _arg1 = _lastArg = _argCount > 1 ? _context.GetArgument(1) : global::Lua.LuaValue.Nil;
                _lastArgPos = 1; _expectedType = typeof(global::UnityEngine.GameObject);
                if (_arg1.TryRead<global::UnityEngine.GameObject>(out var _p1_UnityEngine_GameObject))
                {
                    var _arg2 = _lastArg = _argCount > 2 ? _context.GetArgument(2) : global::Lua.LuaValue.Nil;
                    _lastArgPos = 2; _expectedType = typeof(global::UnityEditor.InteractionMode);
                    if (_arg2.TryRead<global::UnityEditor.InteractionMode>(out var _p2_UnityEditor_InteractionMode))
                    {
                        if (_argCount == 3)
                        {
                            var prefabInstanceRoots = _p0_UnityEngine_GameObjectArray;
                            var prefabAssetRoot = _p1_UnityEngine_GameObject;
                            var mode = _p2_UnityEditor_InteractionMode;
                            global::UnityEditor.PrefabUtility.ReplacePrefabAssetOfPrefabInstances(prefabInstanceRoots, prefabAssetRoot, mode);
                            var _retCount = _context.Return();
                            return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                        }
                    }
                    _lastArgPos = 2; _expectedType = typeof(global::Luny.UnityEditor.LuaPrefabReplacingSettings);
                    if (_arg2.TryRead<global::Luny.UnityEditor.LuaPrefabReplacingSettings>(out var _p2_UnityEditor_PrefabReplacingSettings))
                    {
                        var _arg3 = _lastArg = _argCount > 3 ? _context.GetArgument(3) : global::Lua.LuaValue.Nil;
                        _lastArgPos = 3; _expectedType = typeof(global::UnityEditor.InteractionMode);
                        if (_arg3.TryRead<global::UnityEditor.InteractionMode>(out var _p3_UnityEditor_InteractionMode))
                        {
                            if (_argCount == 4)
                            {
                                var prefabInstanceRoots = _p0_UnityEngine_GameObjectArray;
                                var prefabAssetRoot = _p1_UnityEngine_GameObject;
                                var settings = _p2_UnityEditor_PrefabReplacingSettings.Instance;
                                var mode = _p3_UnityEditor_InteractionMode;
                                global::UnityEditor.PrefabUtility.ReplacePrefabAssetOfPrefabInstances(prefabInstanceRoots, prefabAssetRoot, settings, mode);
                                var _retCount = _context.Return();
                                return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                            }
                        }
                    }
                }
            }
            throw new global::Lua.LuaRuntimeException(_context.Thread, $"{"ReplacePrefabAssetOfPrefabInstances"}: invalid argument #{_lastArgPos}: {_lastArg} ({_lastArg.Type}), expected: {_expectedType.FullName}", 2);
        });
        private static readonly global::Lua.LuaFunction _LuaPrefabUtility_RevertAddedComponent = new global::Lua.LuaFunction("RevertAddedComponent", (_context, _) =>
        {
            global::Lua.LuaValue _lastArg = default;
            global::System.Int32 _lastArgPos = default;
            global::System.Type _expectedType = default;
            var _argCount = _context.ArgumentCount;
            var _arg0 = _lastArg = _argCount > 0 ? _context.GetArgument(0) : global::Lua.LuaValue.Nil;
            _lastArgPos = 0; _expectedType = typeof(global::UnityEngine.Component);
            if (_arg0.TryRead<global::UnityEngine.Component>(out var _p0_UnityEngine_Component))
            {
                var _arg1 = _lastArg = _argCount > 1 ? _context.GetArgument(1) : global::Lua.LuaValue.Nil;
                _lastArgPos = 1; _expectedType = typeof(global::UnityEditor.InteractionMode);
                if (_arg1.TryRead<global::UnityEditor.InteractionMode>(out var _p1_UnityEditor_InteractionMode))
                {
                    if (_argCount == 2)
                    {
                        var component = _p0_UnityEngine_Component;
                        var action = _p1_UnityEditor_InteractionMode;
                        global::UnityEditor.PrefabUtility.RevertAddedComponent(component, action);
                        var _retCount = _context.Return();
                        return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                    }
                }
            }
            throw new global::Lua.LuaRuntimeException(_context.Thread, $"{"RevertAddedComponent"}: invalid argument #{_lastArgPos}: {_lastArg} ({_lastArg.Type}), expected: {_expectedType.FullName}", 2);
        });
        private static readonly global::Lua.LuaFunction _LuaPrefabUtility_RevertAddedGameObject = new global::Lua.LuaFunction("RevertAddedGameObject", (_context, _) =>
        {
            global::Lua.LuaValue _lastArg = default;
            global::System.Int32 _lastArgPos = default;
            global::System.Type _expectedType = default;
            var _argCount = _context.ArgumentCount;
            var _arg0 = _lastArg = _argCount > 0 ? _context.GetArgument(0) : global::Lua.LuaValue.Nil;
            _lastArgPos = 0; _expectedType = typeof(global::UnityEngine.GameObject);
            if (_arg0.TryRead<global::UnityEngine.GameObject>(out var _p0_UnityEngine_GameObject))
            {
                var _arg1 = _lastArg = _argCount > 1 ? _context.GetArgument(1) : global::Lua.LuaValue.Nil;
                _lastArgPos = 1; _expectedType = typeof(global::UnityEditor.InteractionMode);
                if (_arg1.TryRead<global::UnityEditor.InteractionMode>(out var _p1_UnityEditor_InteractionMode))
                {
                    if (_argCount == 2)
                    {
                        var gameObject = _p0_UnityEngine_GameObject;
                        var action = _p1_UnityEditor_InteractionMode;
                        global::UnityEditor.PrefabUtility.RevertAddedGameObject(gameObject, action);
                        var _retCount = _context.Return();
                        return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                    }
                }
            }
            throw new global::Lua.LuaRuntimeException(_context.Thread, $"{"RevertAddedGameObject"}: invalid argument #{_lastArgPos}: {_lastArg} ({_lastArg.Type}), expected: {_expectedType.FullName}", 2);
        });
        private static readonly global::Lua.LuaFunction _LuaPrefabUtility_RevertObjectOverride = new global::Lua.LuaFunction("RevertObjectOverride", (_context, _) =>
        {
            global::Lua.LuaValue _lastArg = default;
            global::System.Int32 _lastArgPos = default;
            global::System.Type _expectedType = default;
            var _argCount = _context.ArgumentCount;
            var _arg0 = _lastArg = _argCount > 0 ? _context.GetArgument(0) : global::Lua.LuaValue.Nil;
            _lastArgPos = 0; _expectedType = typeof(global::UnityEngine.Object);
            if (_arg0.TryRead<global::UnityEngine.Object>(out var _p0_UnityEngine_Object))
            {
                var _arg1 = _lastArg = _argCount > 1 ? _context.GetArgument(1) : global::Lua.LuaValue.Nil;
                _lastArgPos = 1; _expectedType = typeof(global::UnityEditor.InteractionMode);
                if (_arg1.TryRead<global::UnityEditor.InteractionMode>(out var _p1_UnityEditor_InteractionMode))
                {
                    if (_argCount == 2)
                    {
                        var instanceComponentOrGameObject = _p0_UnityEngine_Object;
                        var action = _p1_UnityEditor_InteractionMode;
                        global::UnityEditor.PrefabUtility.RevertObjectOverride(instanceComponentOrGameObject, action);
                        var _retCount = _context.Return();
                        return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                    }
                }
            }
            throw new global::Lua.LuaRuntimeException(_context.Thread, $"{"RevertObjectOverride"}: invalid argument #{_lastArgPos}: {_lastArg} ({_lastArg.Type}), expected: {_expectedType.FullName}", 2);
        });
        private static readonly global::Lua.LuaFunction _LuaPrefabUtility_RevertPrefabInstance = new global::Lua.LuaFunction("RevertPrefabInstance", (_context, _) =>
        {
            global::Lua.LuaValue _lastArg = default;
            global::System.Int32 _lastArgPos = default;
            global::System.Type _expectedType = default;
            var _argCount = _context.ArgumentCount;
            var _arg0 = _lastArg = _argCount > 0 ? _context.GetArgument(0) : global::Lua.LuaValue.Nil;
            _lastArgPos = 0; _expectedType = typeof(global::UnityEngine.GameObject);
            if (_arg0.TryRead<global::UnityEngine.GameObject>(out var _p0_UnityEngine_GameObject))
            {
                var _arg1 = _lastArg = _argCount > 1 ? _context.GetArgument(1) : global::Lua.LuaValue.Nil;
                _lastArgPos = 1; _expectedType = typeof(global::UnityEditor.InteractionMode);
                if (_arg1.TryRead<global::UnityEditor.InteractionMode>(out var _p1_UnityEditor_InteractionMode))
                {
                    if (_argCount == 2)
                    {
                        var instanceRoot = _p0_UnityEngine_GameObject;
                        var action = _p1_UnityEditor_InteractionMode;
                        global::UnityEditor.PrefabUtility.RevertPrefabInstance(instanceRoot, action);
                        var _retCount = _context.Return();
                        return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                    }
                }
            }
            throw new global::Lua.LuaRuntimeException(_context.Thread, $"{"RevertPrefabInstance"}: invalid argument #{_lastArgPos}: {_lastArg} ({_lastArg.Type}), expected: {_expectedType.FullName}", 2);
        });
        private static readonly global::Lua.LuaFunction _LuaPrefabUtility_RevertPropertyOverride = new global::Lua.LuaFunction("RevertPropertyOverride", (_context, _) =>
        {
            global::Lua.LuaValue _lastArg = default;
            global::System.Int32 _lastArgPos = default;
            global::System.Type _expectedType = default;
            var _argCount = _context.ArgumentCount;
            var _arg0 = _lastArg = _argCount > 0 ? _context.GetArgument(0) : global::Lua.LuaValue.Nil;
            _lastArgPos = 0; _expectedType = typeof(global::Luny.UnityEditor.LuaSerializedProperty);
            if (_arg0.TryRead<global::Luny.UnityEditor.LuaSerializedProperty>(out var _p0_UnityEditor_SerializedProperty))
            {
                var _arg1 = _lastArg = _argCount > 1 ? _context.GetArgument(1) : global::Lua.LuaValue.Nil;
                _lastArgPos = 1; _expectedType = typeof(global::UnityEditor.InteractionMode);
                if (_arg1.TryRead<global::UnityEditor.InteractionMode>(out var _p1_UnityEditor_InteractionMode))
                {
                    if (_argCount == 2)
                    {
                        var instanceProperty = _p0_UnityEditor_SerializedProperty.Instance;
                        var action = _p1_UnityEditor_InteractionMode;
                        global::UnityEditor.PrefabUtility.RevertPropertyOverride(instanceProperty, action);
                        var _retCount = _context.Return();
                        return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                    }
                }
            }
            throw new global::Lua.LuaRuntimeException(_context.Thread, $"{"RevertPropertyOverride"}: invalid argument #{_lastArgPos}: {_lastArg} ({_lastArg.Type}), expected: {_expectedType.FullName}", 2);
        });
        private static readonly global::Lua.LuaFunction _LuaPrefabUtility_RevertRemovedComponent = new global::Lua.LuaFunction("RevertRemovedComponent", (_context, _) =>
        {
            global::Lua.LuaValue _lastArg = default;
            global::System.Int32 _lastArgPos = default;
            global::System.Type _expectedType = default;
            var _argCount = _context.ArgumentCount;
            var _arg0 = _lastArg = _argCount > 0 ? _context.GetArgument(0) : global::Lua.LuaValue.Nil;
            _lastArgPos = 0; _expectedType = typeof(global::UnityEngine.GameObject);
            if (_arg0.TryRead<global::UnityEngine.GameObject>(out var _p0_UnityEngine_GameObject))
            {
                var _arg1 = _lastArg = _argCount > 1 ? _context.GetArgument(1) : global::Lua.LuaValue.Nil;
                _lastArgPos = 1; _expectedType = typeof(global::UnityEngine.Component);
                if (_arg1.TryRead<global::UnityEngine.Component>(out var _p1_UnityEngine_Component))
                {
                    var _arg2 = _lastArg = _argCount > 2 ? _context.GetArgument(2) : global::Lua.LuaValue.Nil;
                    _lastArgPos = 2; _expectedType = typeof(global::UnityEditor.InteractionMode);
                    if (_arg2.TryRead<global::UnityEditor.InteractionMode>(out var _p2_UnityEditor_InteractionMode))
                    {
                        if (_argCount == 3)
                        {
                            var instanceGameObject = _p0_UnityEngine_GameObject;
                            var assetComponent = _p1_UnityEngine_Component;
                            var action = _p2_UnityEditor_InteractionMode;
                            global::UnityEditor.PrefabUtility.RevertRemovedComponent(instanceGameObject, assetComponent, action);
                            var _retCount = _context.Return();
                            return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                        }
                    }
                }
            }
            throw new global::Lua.LuaRuntimeException(_context.Thread, $"{"RevertRemovedComponent"}: invalid argument #{_lastArgPos}: {_lastArg} ({_lastArg.Type}), expected: {_expectedType.FullName}", 2);
        });
        private static readonly global::Lua.LuaFunction _LuaPrefabUtility_RevertRemovedGameObject = new global::Lua.LuaFunction("RevertRemovedGameObject", (_context, _) =>
        {
            global::Lua.LuaValue _lastArg = default;
            global::System.Int32 _lastArgPos = default;
            global::System.Type _expectedType = default;
            var _argCount = _context.ArgumentCount;
            var _arg0 = _lastArg = _argCount > 0 ? _context.GetArgument(0) : global::Lua.LuaValue.Nil;
            _lastArgPos = 0; _expectedType = typeof(global::UnityEngine.GameObject);
            if (_arg0.TryRead<global::UnityEngine.GameObject>(out var _p0_UnityEngine_GameObject))
            {
                var _arg1 = _lastArg = _argCount > 1 ? _context.GetArgument(1) : global::Lua.LuaValue.Nil;
                _lastArgPos = 1; _expectedType = typeof(global::UnityEngine.GameObject);
                if (_arg1.TryRead<global::UnityEngine.GameObject>(out var _p1_UnityEngine_GameObject))
                {
                    var _arg2 = _lastArg = _argCount > 2 ? _context.GetArgument(2) : global::Lua.LuaValue.Nil;
                    _lastArgPos = 2; _expectedType = typeof(global::UnityEditor.InteractionMode);
                    if (_arg2.TryRead<global::UnityEditor.InteractionMode>(out var _p2_UnityEditor_InteractionMode))
                    {
                        if (_argCount == 3)
                        {
                            var gameObjectInInstance = _p0_UnityEngine_GameObject;
                            var assetGameObject = _p1_UnityEngine_GameObject;
                            var action = _p2_UnityEditor_InteractionMode;
                            global::UnityEditor.PrefabUtility.RevertRemovedGameObject(gameObjectInInstance, assetGameObject, action);
                            var _retCount = _context.Return();
                            return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                        }
                    }
                }
            }
            throw new global::Lua.LuaRuntimeException(_context.Thread, $"{"RevertRemovedGameObject"}: invalid argument #{_lastArgPos}: {_lastArg} ({_lastArg.Type}), expected: {_expectedType.FullName}", 2);
        });
        private static readonly global::Lua.LuaFunction _LuaPrefabUtility_SaveAsPrefabAsset = new global::Lua.LuaFunction("SaveAsPrefabAsset", (_context, _) =>
        {
            global::Lua.LuaValue _lastArg = default;
            global::System.Int32 _lastArgPos = default;
            global::System.Type _expectedType = default;
            var _argCount = _context.ArgumentCount;
            var _arg0 = _lastArg = _argCount > 0 ? _context.GetArgument(0) : global::Lua.LuaValue.Nil;
            _lastArgPos = 0; _expectedType = typeof(global::UnityEngine.GameObject);
            if (_arg0.TryRead<global::UnityEngine.GameObject>(out var _p0_UnityEngine_GameObject))
            {
                var _arg1 = _lastArg = _argCount > 1 ? _context.GetArgument(1) : global::Lua.LuaValue.Nil;
                _lastArgPos = 1; _expectedType = typeof(global::System.String);
                if (_arg1.TryRead<global::System.String>(out var _p1_System_String))
                {
                    if (_argCount == 2)
                    {
                        var instanceRoot = _p0_UnityEngine_GameObject;
                        var assetPath = _p1_System_String;
                        var _ret0 = global::UnityEditor.PrefabUtility.SaveAsPrefabAsset(instanceRoot, assetPath);
                        var _factory = _context.GetObjectFactory();
                        var _lret0 = _factory.Bind(_ret0);
                        var _retCount = _context.Return(_lret0);
                        return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                    }
                }
            }
            throw new global::Lua.LuaRuntimeException(_context.Thread, $"{"SaveAsPrefabAsset"}: invalid argument #{_lastArgPos}: {_lastArg} ({_lastArg.Type}), expected: {_expectedType.FullName}", 2);
        });
        private static readonly global::Lua.LuaFunction _LuaPrefabUtility_SaveAsPrefabAssetAndConnect = new global::Lua.LuaFunction("SaveAsPrefabAssetAndConnect", (_context, _) =>
        {
            global::Lua.LuaValue _lastArg = default;
            global::System.Int32 _lastArgPos = default;
            global::System.Type _expectedType = default;
            var _argCount = _context.ArgumentCount;
            var _arg0 = _lastArg = _argCount > 0 ? _context.GetArgument(0) : global::Lua.LuaValue.Nil;
            _lastArgPos = 0; _expectedType = typeof(global::UnityEngine.GameObject);
            if (_arg0.TryRead<global::UnityEngine.GameObject>(out var _p0_UnityEngine_GameObject))
            {
                var _arg1 = _lastArg = _argCount > 1 ? _context.GetArgument(1) : global::Lua.LuaValue.Nil;
                _lastArgPos = 1; _expectedType = typeof(global::System.String);
                if (_arg1.TryRead<global::System.String>(out var _p1_System_String))
                {
                    var _arg2 = _lastArg = _argCount > 2 ? _context.GetArgument(2) : global::Lua.LuaValue.Nil;
                    _lastArgPos = 2; _expectedType = typeof(global::UnityEditor.InteractionMode);
                    if (_arg2.TryRead<global::UnityEditor.InteractionMode>(out var _p2_UnityEditor_InteractionMode))
                    {
                        if (_argCount == 3)
                        {
                            var instanceRoot = _p0_UnityEngine_GameObject;
                            var assetPath = _p1_System_String;
                            var action = _p2_UnityEditor_InteractionMode;
                            var _ret0 = global::UnityEditor.PrefabUtility.SaveAsPrefabAssetAndConnect(instanceRoot, assetPath, action);
                            var _factory = _context.GetObjectFactory();
                            var _lret0 = _factory.Bind(_ret0);
                            var _retCount = _context.Return(_lret0);
                            return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                        }
                    }
                }
            }
            throw new global::Lua.LuaRuntimeException(_context.Thread, $"{"SaveAsPrefabAssetAndConnect"}: invalid argument #{_lastArgPos}: {_lastArg} ({_lastArg.Type}), expected: {_expectedType.FullName}", 2);
        });
        private static readonly global::Lua.LuaFunction _LuaPrefabUtility_SavePrefabAsset = new global::Lua.LuaFunction("SavePrefabAsset", (_context, _) =>
        {
            global::Lua.LuaValue _lastArg = default;
            global::System.Int32 _lastArgPos = default;
            global::System.Type _expectedType = default;
            var _argCount = _context.ArgumentCount;
            var _arg0 = _lastArg = _argCount > 0 ? _context.GetArgument(0) : global::Lua.LuaValue.Nil;
            _lastArgPos = 0; _expectedType = typeof(global::UnityEngine.GameObject);
            if (_arg0.TryRead<global::UnityEngine.GameObject>(out var _p0_UnityEngine_GameObject))
            {
                if (_argCount == 1)
                {
                    var asset = _p0_UnityEngine_GameObject;
                    var _ret0 = global::UnityEditor.PrefabUtility.SavePrefabAsset(asset);
                    var _factory = _context.GetObjectFactory();
                    var _lret0 = _factory.Bind(_ret0);
                    var _retCount = _context.Return(_lret0);
                    return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                }
            }
            throw new global::Lua.LuaRuntimeException(_context.Thread, $"{"SavePrefabAsset"}: invalid argument #{_lastArgPos}: {_lastArg} ({_lastArg.Type}), expected: {_expectedType.FullName}", 2);
        });
        private static readonly global::Lua.LuaFunction _LuaPrefabUtility_SetPropertyModifications = new global::Lua.LuaFunction("SetPropertyModifications", (_context, _) =>
        {
            global::Lua.LuaValue _lastArg = default;
            global::System.Int32 _lastArgPos = default;
            global::System.Type _expectedType = default;
            var _argCount = _context.ArgumentCount;
            var _arg0 = _lastArg = _argCount > 0 ? _context.GetArgument(0) : global::Lua.LuaValue.Nil;
            _lastArgPos = 0; _expectedType = typeof(global::UnityEngine.Object);
            if (_arg0.TryRead<global::UnityEngine.Object>(out var _p0_UnityEngine_Object))
            {
                var _arg1 = _lastArg = _argCount > 1 ? _context.GetArgument(1) : global::Lua.LuaValue.Nil;
                _lastArgPos = 1; _expectedType = typeof(global::UnityEditor.PropertyModification[]);
                if (_arg1.TryReadArray<global::UnityEditor.PropertyModification>(out var _p1_UnityEditor_PropertyModificationArray))
                {
                    if (_argCount == 2)
                    {
                        var targetPrefab = _p0_UnityEngine_Object;
                        var modifications = _p1_UnityEditor_PropertyModificationArray;
                        global::UnityEditor.PrefabUtility.SetPropertyModifications(targetPrefab, modifications);
                        var _retCount = _context.Return();
                        return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                    }
                }
            }
            throw new global::Lua.LuaRuntimeException(_context.Thread, $"{"SetPropertyModifications"}: invalid argument #{_lastArgPos}: {_lastArg} ({_lastArg.Type}), expected: {_expectedType.FullName}", 2);
        });
        private static readonly global::Lua.LuaFunction _LuaPrefabUtility_UnloadPrefabContents = new global::Lua.LuaFunction("UnloadPrefabContents", (_context, _) =>
        {
            global::Lua.LuaValue _lastArg = default;
            global::System.Int32 _lastArgPos = default;
            global::System.Type _expectedType = default;
            var _argCount = _context.ArgumentCount;
            var _arg0 = _lastArg = _argCount > 0 ? _context.GetArgument(0) : global::Lua.LuaValue.Nil;
            _lastArgPos = 0; _expectedType = typeof(global::UnityEngine.GameObject);
            if (_arg0.TryRead<global::UnityEngine.GameObject>(out var _p0_UnityEngine_GameObject))
            {
                if (_argCount == 1)
                {
                    var contentsRoot = _p0_UnityEngine_GameObject;
                    global::UnityEditor.PrefabUtility.UnloadPrefabContents(contentsRoot);
                    var _retCount = _context.Return();
                    return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                }
            }
            throw new global::Lua.LuaRuntimeException(_context.Thread, $"{"UnloadPrefabContents"}: invalid argument #{_lastArgPos}: {_lastArg} ({_lastArg.Type}), expected: {_expectedType.FullName}", 2);
        });
        private static readonly global::Lua.LuaFunction _LuaPrefabUtility_UnpackAllInstancesOfPrefab = new global::Lua.LuaFunction("UnpackAllInstancesOfPrefab", (_context, _) =>
        {
            global::Lua.LuaValue _lastArg = default;
            global::System.Int32 _lastArgPos = default;
            global::System.Type _expectedType = default;
            var _argCount = _context.ArgumentCount;
            var _arg0 = _lastArg = _argCount > 0 ? _context.GetArgument(0) : global::Lua.LuaValue.Nil;
            _lastArgPos = 0; _expectedType = typeof(global::UnityEngine.GameObject);
            if (_arg0.TryRead<global::UnityEngine.GameObject>(out var _p0_UnityEngine_GameObject))
            {
                var _arg1 = _lastArg = _argCount > 1 ? _context.GetArgument(1) : global::Lua.LuaValue.Nil;
                _lastArgPos = 1; _expectedType = typeof(global::UnityEditor.PrefabUnpackMode);
                if (_arg1.TryRead<global::UnityEditor.PrefabUnpackMode>(out var _p1_UnityEditor_PrefabUnpackMode))
                {
                    var _arg2 = _lastArg = _argCount > 2 ? _context.GetArgument(2) : global::Lua.LuaValue.Nil;
                    _lastArgPos = 2; _expectedType = typeof(global::UnityEditor.InteractionMode);
                    if (_arg2.TryRead<global::UnityEditor.InteractionMode>(out var _p2_UnityEditor_InteractionMode))
                    {
                        if (_argCount == 3)
                        {
                            var prefabRoot = _p0_UnityEngine_GameObject;
                            var unpackMode = _p1_UnityEditor_PrefabUnpackMode;
                            var action = _p2_UnityEditor_InteractionMode;
                            global::UnityEditor.PrefabUtility.UnpackAllInstancesOfPrefab(prefabRoot, unpackMode, action);
                            var _retCount = _context.Return();
                            return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                        }
                    }
                }
            }
            throw new global::Lua.LuaRuntimeException(_context.Thread, $"{"UnpackAllInstancesOfPrefab"}: invalid argument #{_lastArgPos}: {_lastArg} ({_lastArg.Type}), expected: {_expectedType.FullName}", 2);
        });
        private static readonly global::Lua.LuaFunction _LuaPrefabUtility_UnpackPrefabInstance = new global::Lua.LuaFunction("UnpackPrefabInstance", (_context, _) =>
        {
            global::Lua.LuaValue _lastArg = default;
            global::System.Int32 _lastArgPos = default;
            global::System.Type _expectedType = default;
            var _argCount = _context.ArgumentCount;
            var _arg0 = _lastArg = _argCount > 0 ? _context.GetArgument(0) : global::Lua.LuaValue.Nil;
            _lastArgPos = 0; _expectedType = typeof(global::UnityEngine.GameObject);
            if (_arg0.TryRead<global::UnityEngine.GameObject>(out var _p0_UnityEngine_GameObject))
            {
                var _arg1 = _lastArg = _argCount > 1 ? _context.GetArgument(1) : global::Lua.LuaValue.Nil;
                _lastArgPos = 1; _expectedType = typeof(global::UnityEditor.PrefabUnpackMode);
                if (_arg1.TryRead<global::UnityEditor.PrefabUnpackMode>(out var _p1_UnityEditor_PrefabUnpackMode))
                {
                    var _arg2 = _lastArg = _argCount > 2 ? _context.GetArgument(2) : global::Lua.LuaValue.Nil;
                    _lastArgPos = 2; _expectedType = typeof(global::UnityEditor.InteractionMode);
                    if (_arg2.TryRead<global::UnityEditor.InteractionMode>(out var _p2_UnityEditor_InteractionMode))
                    {
                        if (_argCount == 3)
                        {
                            var instanceRoot = _p0_UnityEngine_GameObject;
                            var unpackMode = _p1_UnityEditor_PrefabUnpackMode;
                            var action = _p2_UnityEditor_InteractionMode;
                            global::UnityEditor.PrefabUtility.UnpackPrefabInstance(instanceRoot, unpackMode, action);
                            var _retCount = _context.Return();
                            return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                        }
                    }
                }
            }
            throw new global::Lua.LuaRuntimeException(_context.Thread, $"{"UnpackPrefabInstance"}: invalid argument #{_lastArgPos}: {_lastArg} ({_lastArg.Type}), expected: {_expectedType.FullName}", 2);
        });
        private static readonly global::Lua.LuaFunction _LuaPrefabUtility_UnpackPrefabInstanceAndReturnNewOutermostRoots = new global::Lua.LuaFunction("UnpackPrefabInstanceAndReturnNewOutermostRoots", (_context, _) =>
        {
            global::Lua.LuaValue _lastArg = default;
            global::System.Int32 _lastArgPos = default;
            global::System.Type _expectedType = default;
            var _argCount = _context.ArgumentCount;
            var _arg0 = _lastArg = _argCount > 0 ? _context.GetArgument(0) : global::Lua.LuaValue.Nil;
            _lastArgPos = 0; _expectedType = typeof(global::UnityEngine.GameObject);
            if (_arg0.TryRead<global::UnityEngine.GameObject>(out var _p0_UnityEngine_GameObject))
            {
                var _arg1 = _lastArg = _argCount > 1 ? _context.GetArgument(1) : global::Lua.LuaValue.Nil;
                _lastArgPos = 1; _expectedType = typeof(global::UnityEditor.PrefabUnpackMode);
                if (_arg1.TryRead<global::UnityEditor.PrefabUnpackMode>(out var _p1_UnityEditor_PrefabUnpackMode))
                {
                    if (_argCount == 2)
                    {
                        var instanceRoot = _p0_UnityEngine_GameObject;
                        var unpackMode = _p1_UnityEditor_PrefabUnpackMode;
                        var _ret0 = global::UnityEditor.PrefabUtility.UnpackPrefabInstanceAndReturnNewOutermostRoots(instanceRoot, unpackMode);
                        var _factory = _context.GetObjectFactory();
                        var _lret0 = _factory.Bind(_ret0);
                        var _retCount = _context.Return(_lret0);
                        return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                    }
                }
            }
            throw new global::Lua.LuaRuntimeException(_context.Thread, $"{"UnpackPrefabInstanceAndReturnNewOutermostRoots"}: invalid argument #{_lastArgPos}: {_lastArg} ({_lastArg.Type}), expected: {_expectedType.FullName}", 2);
        });
        private static readonly global::Lua.LuaFunction __index = new(global::Lua.Runtime.Metamethods.Index, (_context, _) =>
        {
            var _this = _context.GetArgument<LuaPrefabUtilityType>(0);
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
            var _this = _context.GetArgument<LuaPrefabUtilityType>(0);
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
                case "ApplyAddedComponent": _value = _LuaPrefabUtility_ApplyAddedComponent; return true;
                case "ApplyAddedGameObject": _value = _LuaPrefabUtility_ApplyAddedGameObject; return true;
                case "ApplyAddedGameObjects": _value = _LuaPrefabUtility_ApplyAddedGameObjects; return true;
                case "ApplyObjectOverride": _value = _LuaPrefabUtility_ApplyObjectOverride; return true;
                case "ApplyPrefabInstance": _value = _LuaPrefabUtility_ApplyPrefabInstance; return true;
                case "ApplyPrefabInstances": _value = _LuaPrefabUtility_ApplyPrefabInstances; return true;
                case "ApplyPropertyOverride": _value = _LuaPrefabUtility_ApplyPropertyOverride; return true;
                case "ApplyRemovedComponent": _value = _LuaPrefabUtility_ApplyRemovedComponent; return true;
                case "ApplyRemovedGameObject": _value = _LuaPrefabUtility_ApplyRemovedGameObject; return true;
                case "ConvertToPrefabInstance": _value = _LuaPrefabUtility_ConvertToPrefabInstance; return true;
                case "ConvertToPrefabInstances": _value = _LuaPrefabUtility_ConvertToPrefabInstances; return true;
                case "FindAllInstancesOfPrefab": _value = _LuaPrefabUtility_FindAllInstancesOfPrefab; return true;
                case "GetIconForGameObject": _value = _LuaPrefabUtility_GetIconForGameObject; return true;
                case "GetNearestPrefabInstanceRoot": _value = _LuaPrefabUtility_GetNearestPrefabInstanceRoot; return true;
                case "GetOriginalSourceRootWhereGameObjectIsAdded": _value = _LuaPrefabUtility_GetOriginalSourceRootWhereGameObjectIsAdded; return true;
                case "GetOutermostPrefabInstanceRoot": _value = _LuaPrefabUtility_GetOutermostPrefabInstanceRoot; return true;
                case "GetPrefabAssetPathOfNearestInstanceRoot": _value = _LuaPrefabUtility_GetPrefabAssetPathOfNearestInstanceRoot; return true;
                case "GetPrefabAssetType": _value = _LuaPrefabUtility_GetPrefabAssetType; return true;
                case "GetPrefabInstanceHandle": _value = _LuaPrefabUtility_GetPrefabInstanceHandle; return true;
                case "GetPrefabInstanceStatus": _value = _LuaPrefabUtility_GetPrefabInstanceStatus; return true;
                case "GetPropertyModifications": _value = _LuaPrefabUtility_GetPropertyModifications; return true;
                case "HasManagedReferencesWithMissingTypes": _value = _LuaPrefabUtility_HasManagedReferencesWithMissingTypes; return true;
                case "HasPrefabInstanceAnyOverrides": _value = _LuaPrefabUtility_HasPrefabInstanceAnyOverrides; return true;
                case "InstantiatePrefab": _value = _LuaPrefabUtility_InstantiatePrefab; return true;
                case "IsAddedComponentOverride": _value = _LuaPrefabUtility_IsAddedComponentOverride; return true;
                case "IsAddedGameObjectOverride": _value = _LuaPrefabUtility_IsAddedGameObjectOverride; return true;
                case "IsAnyPrefabInstanceRoot": _value = _LuaPrefabUtility_IsAnyPrefabInstanceRoot; return true;
                case "IsDefaultOverride": _value = _LuaPrefabUtility_IsDefaultOverride; return true;
                case "IsOutermostPrefabInstanceRoot": _value = _LuaPrefabUtility_IsOutermostPrefabInstanceRoot; return true;
                case "IsPartOfAnyPrefab": _value = _LuaPrefabUtility_IsPartOfAnyPrefab; return true;
                case "IsPartOfImmutablePrefab": _value = _LuaPrefabUtility_IsPartOfImmutablePrefab; return true;
                case "IsPartOfModelPrefab": _value = _LuaPrefabUtility_IsPartOfModelPrefab; return true;
                case "IsPartOfNonAssetPrefabInstance": _value = _LuaPrefabUtility_IsPartOfNonAssetPrefabInstance; return true;
                case "IsPartOfPrefabAsset": _value = _LuaPrefabUtility_IsPartOfPrefabAsset; return true;
                case "IsPartOfPrefabInstance": _value = _LuaPrefabUtility_IsPartOfPrefabInstance; return true;
                case "IsPartOfPrefabThatCanBeAppliedTo": _value = _LuaPrefabUtility_IsPartOfPrefabThatCanBeAppliedTo; return true;
                case "IsPartOfRegularPrefab": _value = _LuaPrefabUtility_IsPartOfRegularPrefab; return true;
                case "IsPartOfVariantPrefab": _value = _LuaPrefabUtility_IsPartOfVariantPrefab; return true;
                case "IsPrefabAssetMissing": _value = _LuaPrefabUtility_IsPrefabAssetMissing; return true;
                case "LoadPrefabContents": _value = _LuaPrefabUtility_LoadPrefabContents; return true;
                case "LoadPrefabContentsIntoPreviewScene": _value = _LuaPrefabUtility_LoadPrefabContentsIntoPreviewScene; return true;
                case "MergePrefabInstance": _value = _LuaPrefabUtility_MergePrefabInstance; return true;
                case "RecordPrefabInstancePropertyModifications": _value = _LuaPrefabUtility_RecordPrefabInstancePropertyModifications; return true;
                case "RemoveUnusedOverrides": _value = _LuaPrefabUtility_RemoveUnusedOverrides; return true;
                case "ReplacePrefabAssetOfPrefabInstance": _value = _LuaPrefabUtility_ReplacePrefabAssetOfPrefabInstance; return true;
                case "ReplacePrefabAssetOfPrefabInstances": _value = _LuaPrefabUtility_ReplacePrefabAssetOfPrefabInstances; return true;
                case "RevertAddedComponent": _value = _LuaPrefabUtility_RevertAddedComponent; return true;
                case "RevertAddedGameObject": _value = _LuaPrefabUtility_RevertAddedGameObject; return true;
                case "RevertObjectOverride": _value = _LuaPrefabUtility_RevertObjectOverride; return true;
                case "RevertPrefabInstance": _value = _LuaPrefabUtility_RevertPrefabInstance; return true;
                case "RevertPropertyOverride": _value = _LuaPrefabUtility_RevertPropertyOverride; return true;
                case "RevertRemovedComponent": _value = _LuaPrefabUtility_RevertRemovedComponent; return true;
                case "RevertRemovedGameObject": _value = _LuaPrefabUtility_RevertRemovedGameObject; return true;
                case "SaveAsPrefabAsset": _value = _LuaPrefabUtility_SaveAsPrefabAsset; return true;
                case "SaveAsPrefabAssetAndConnect": _value = _LuaPrefabUtility_SaveAsPrefabAssetAndConnect; return true;
                case "SavePrefabAsset": _value = _LuaPrefabUtility_SavePrefabAsset; return true;
                case "SetPropertyModifications": _value = _LuaPrefabUtility_SetPropertyModifications; return true;
                case "UnloadPrefabContents": _value = _LuaPrefabUtility_UnloadPrefabContents; return true;
                case "UnpackAllInstancesOfPrefab": _value = _LuaPrefabUtility_UnpackAllInstancesOfPrefab; return true;
                case "UnpackPrefabInstance": _value = _LuaPrefabUtility_UnpackPrefabInstance; return true;
                case "UnpackPrefabInstanceAndReturnNewOutermostRoots": _value = _LuaPrefabUtility_UnpackPrefabInstanceAndReturnNewOutermostRoots; return true;
                case "prefabInstanceUpdated": _value = _factory.Bind(global::UnityEditor.PrefabUtility.prefabInstanceUpdated); return true;
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
                case "prefabInstanceUpdated": global::UnityEditor.PrefabUtility.prefabInstanceUpdated = _value.Read<global::UnityEditor.PrefabUtility.PrefabInstanceUpdated>();  return true;
                default: return false;
            }
        }
    }
}
#pragma warning restore 0109, 0162, 0168, 0219
#endif
