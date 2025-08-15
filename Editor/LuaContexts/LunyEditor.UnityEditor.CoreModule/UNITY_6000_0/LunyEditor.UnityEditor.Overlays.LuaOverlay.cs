
// --------------------------------------------------------------
// GENERATED FILE ----> DO NOT EDIT <---- CHANGES WILL BE LOST !!
// --------------------------------------------------------------

#if UNITY_6000_0_OR_NEWER && !(UNITY_6000_1_OR_NEWER)
#pragma warning disable 0109, 0162, 0168, 0219
using Luny;

namespace LunyEditor.UnityEditor.Overlays
{
    public class LuaOverlay : global::Luny.ILuaObject<global::UnityEditor.Overlays.Overlay>
    {
        public new static global::Lua.LuaValue Bind(global::UnityEditor.Overlays.Overlay instance) => new LuaOverlay(instance);
        public new static global::Lua.LuaValue Bind(global::System.Object instance) => Bind((global::UnityEditor.Overlays.Overlay)instance);
        public new static global::Lua.LuaValue Bind(global::System.Collections.Generic.IList<global::UnityEditor.Overlays.Overlay> instances) =>
            new global::Luny.LuaList<global::UnityEditor.Overlays.Overlay>(instances);
        public new static global::Lua.LuaValue Bind(global::System.Collections.Generic.IList<global::System.Object> instances) =>
            new global::Luny.LuaList<global::UnityEditor.Overlays.Overlay>(instances);
        protected LuaOverlay(global::UnityEditor.Overlays.Overlay instance) => m_Instance = instance;
        public static implicit operator global::Lua.LuaValue(LuaOverlay value) => new(value);
        protected global::UnityEditor.Overlays.Overlay m_Instance;
        public global::UnityEditor.Overlays.Overlay Instance => m_Instance;
        public new global::System.Type BindType => typeof(global::UnityEditor.Overlays.Overlay);
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
        public override global::System.String ToString() => m_Instance != null ? Instance.ToString() : "{GetType().Name}(null)";
#if UNITY_EDITOR
        [global::UnityEngine.RuntimeInitializeOnLoadMethod(global::UnityEngine.RuntimeInitializeLoadType.SubsystemRegistration)]
        private static void ResetStaticFields() => s_Metatable = null;
#endif

        private static readonly global::Lua.LuaFunction _LuaOverlay_Close = new global::Lua.LuaFunction("Close", (_context, _) =>
        {
            global::Lua.LuaValue _lastArg = default;
            global::System.Int32 _lastArgPos = default;
            global::System.Type _expectedType = default;
            var _argCount = _context.ArgumentCount;
            var _this = _context.GetArgument<LuaOverlay>(0);
            if (_argCount == 1)
            {
                _this.Instance.Close();
                var _retCount = _context.Return();
                return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
            }
            throw new global::Lua.LuaRuntimeException(_context.Thread, $"{"Close"}: invalid argument #{_lastArgPos}: {_lastArg} ({_lastArg.Type}), expected: {_expectedType.FullName}", 2);
        });
        private static readonly global::Lua.LuaFunction _LuaOverlay_CreateContent = new global::Lua.LuaFunction("CreateContent", (_context, _) =>
        {
            global::Lua.LuaValue _lastArg = default;
            global::System.Int32 _lastArgPos = default;
            global::System.Type _expectedType = default;
            var _argCount = _context.ArgumentCount;
            var _this = _context.GetArgument<LuaOverlay>(0);
            var _arg0 = _lastArg = _argCount > 1 ? _context.GetArgument(1) : global::Lua.LuaValue.Nil;
            _lastArgPos = 0; _expectedType = typeof(global::UnityEditor.Overlays.Layout);
            if (_arg0.TryRead<global::UnityEditor.Overlays.Layout>(out var _p0_UnityEditor_Overlays_Layout))
            {
                if (_argCount == 2)
                {
                    var requestedLayout = _p0_UnityEditor_Overlays_Layout;
                    var _ret0 = _this.Instance.CreateContent(requestedLayout);
                    var _factory = _context.GetObjectFactory();
                    var _lret0 = _factory.Bind(_ret0);
                    var _retCount = _context.Return(_lret0);
                    return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                }
            }
            throw new global::Lua.LuaRuntimeException(_context.Thread, $"{"CreateContent"}: invalid argument #{_lastArgPos}: {_lastArg} ({_lastArg.Type}), expected: {_expectedType.FullName}", 2);
        });
        private static readonly global::Lua.LuaFunction _LuaOverlay_CreatePanelContent = new global::Lua.LuaFunction("CreatePanelContent", (_context, _) =>
        {
            global::Lua.LuaValue _lastArg = default;
            global::System.Int32 _lastArgPos = default;
            global::System.Type _expectedType = default;
            var _argCount = _context.ArgumentCount;
            var _this = _context.GetArgument<LuaOverlay>(0);
            if (_argCount == 1)
            {
                var _ret0 = _this.Instance.CreatePanelContent();
                var _factory = _context.GetObjectFactory();
                var _lret0 = _factory.Bind(_ret0);
                var _retCount = _context.Return(_lret0);
                return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
            }
            throw new global::Lua.LuaRuntimeException(_context.Thread, $"{"CreatePanelContent"}: invalid argument #{_lastArgPos}: {_lastArg} ({_lastArg.Type}), expected: {_expectedType.FullName}", 2);
        });
        private static readonly global::Lua.LuaFunction _LuaOverlay_OnCreated = new global::Lua.LuaFunction("OnCreated", (_context, _) =>
        {
            global::Lua.LuaValue _lastArg = default;
            global::System.Int32 _lastArgPos = default;
            global::System.Type _expectedType = default;
            var _argCount = _context.ArgumentCount;
            var _this = _context.GetArgument<LuaOverlay>(0);
            if (_argCount == 1)
            {
                _this.Instance.OnCreated();
                var _retCount = _context.Return();
                return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
            }
            throw new global::Lua.LuaRuntimeException(_context.Thread, $"{"OnCreated"}: invalid argument #{_lastArgPos}: {_lastArg} ({_lastArg.Type}), expected: {_expectedType.FullName}", 2);
        });
        private static readonly global::Lua.LuaFunction _LuaOverlay_OnWillBeDestroyed = new global::Lua.LuaFunction("OnWillBeDestroyed", (_context, _) =>
        {
            global::Lua.LuaValue _lastArg = default;
            global::System.Int32 _lastArgPos = default;
            global::System.Type _expectedType = default;
            var _argCount = _context.ArgumentCount;
            var _this = _context.GetArgument<LuaOverlay>(0);
            if (_argCount == 1)
            {
                _this.Instance.OnWillBeDestroyed();
                var _retCount = _context.Return();
                return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
            }
            throw new global::Lua.LuaRuntimeException(_context.Thread, $"{"OnWillBeDestroyed"}: invalid argument #{_lastArgPos}: {_lastArg} ({_lastArg.Type}), expected: {_expectedType.FullName}", 2);
        });
        private static readonly global::Lua.LuaFunction _LuaOverlay_RefreshPopup = new global::Lua.LuaFunction("RefreshPopup", (_context, _) =>
        {
            global::Lua.LuaValue _lastArg = default;
            global::System.Int32 _lastArgPos = default;
            global::System.Type _expectedType = default;
            var _argCount = _context.ArgumentCount;
            var _this = _context.GetArgument<LuaOverlay>(0);
            if (_argCount == 1)
            {
                _this.Instance.RefreshPopup();
                var _retCount = _context.Return();
                return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
            }
            throw new global::Lua.LuaRuntimeException(_context.Thread, $"{"RefreshPopup"}: invalid argument #{_lastArgPos}: {_lastArg} ({_lastArg.Type}), expected: {_expectedType.FullName}", 2);
        });
        private static readonly global::Lua.LuaFunction _LuaOverlay_Undock = new global::Lua.LuaFunction("Undock", (_context, _) =>
        {
            global::Lua.LuaValue _lastArg = default;
            global::System.Int32 _lastArgPos = default;
            global::System.Type _expectedType = default;
            var _argCount = _context.ArgumentCount;
            var _this = _context.GetArgument<LuaOverlay>(0);
            if (_argCount == 1)
            {
                _this.Instance.Undock();
                var _retCount = _context.Return();
                return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
            }
            throw new global::Lua.LuaRuntimeException(_context.Thread, $"{"Undock"}: invalid argument #{_lastArgPos}: {_lastArg} ({_lastArg.Type}), expected: {_expectedType.FullName}", 2);
        });
        private static readonly global::Lua.LuaFunction __index = new(global::Lua.Runtime.Metamethods.Index, (_context, _) =>
        {
            var _this = _context.GetArgument<LuaOverlay>(0);
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
            var _this = _context.GetArgument<LuaOverlay>(0);
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
                case "Close": _value = _LuaOverlay_Close; return true;
                case "CreateContent": _value = _LuaOverlay_CreateContent; return true;
                case "CreatePanelContent": _value = _LuaOverlay_CreatePanelContent; return true;
                case "OnCreated": _value = _LuaOverlay_OnCreated; return true;
                case "OnWillBeDestroyed": _value = _LuaOverlay_OnWillBeDestroyed; return true;
                case "RefreshPopup": _value = _LuaOverlay_RefreshPopup; return true;
                case "Undock": _value = _LuaOverlay_Undock; return true;
                case "collapsed": _value = new global::Lua.LuaValue(Instance.collapsed); return true;
                case "containerWindow": _value = _factory.Bind(Instance.containerWindow); return true;
                case "defaultSize": _value = global::Luny.UnityEngine.LuaVector2.Bind(Instance.defaultSize); return true;
                case "displayed": _value = new global::Lua.LuaValue(Instance.displayed); return true;
                case "displayName": _value = new global::Lua.LuaValue(Instance.displayName); return true;
                case "floating": _value = new global::Lua.LuaValue(Instance.floating); return true;
                case "floatingPosition": _value = global::Luny.UnityEngine.LuaVector2.Bind(Instance.floatingPosition); return true;
                case "id": _value = new global::Lua.LuaValue(Instance.id); return true;
                case "isInToolbar": _value = new global::Lua.LuaValue(Instance.isInToolbar); return true;
                case "layout": _value = new global::Lua.LuaValue((global::System.Int64)Instance.layout); return true;
                case "maxSize": _value = global::Luny.UnityEngine.LuaVector2.Bind(Instance.maxSize); return true;
                case "minSize": _value = global::Luny.UnityEngine.LuaVector2.Bind(Instance.minSize); return true;
                case "rootVisualElement": _value = _factory.Bind(Instance.rootVisualElement); return true;
                case "size": _value = global::Luny.UnityEngine.LuaVector2.Bind(Instance.size); return true;
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
                case "collapsed": Instance.collapsed = _value.Read<global::System.Boolean>();  return true;
                case "collapsedIcon": Instance.collapsedIcon = _value.Read<global::Luny.UnityEngine.LuaTexture2D>().Instance;  return true;
                case "defaultSize": Instance.defaultSize = _value.Read<global::Luny.UnityEngine.LuaVector2>().Value;  return true;
                case "displayed": Instance.displayed = _value.Read<global::System.Boolean>();  return true;
                case "displayName": Instance.displayName = _value.Read<global::System.String>();  return true;
                case "floatingPosition": Instance.floatingPosition = _value.Read<global::Luny.UnityEngine.LuaVector2>().Value;  return true;
                case "maxSize": Instance.maxSize = _value.Read<global::Luny.UnityEngine.LuaVector2>().Value;  return true;
                case "minSize": Instance.minSize = _value.Read<global::Luny.UnityEngine.LuaVector2>().Value;  return true;
                case "size": Instance.size = _value.Read<global::Luny.UnityEngine.LuaVector2>().Value;  return true;
                default: return false;
            }
        }
    }
    public sealed class LuaOverlayType : global::Luny.ILuaStatic
    {
        public static global::Lua.LuaValue Bind() => new LuaOverlayType();
        private LuaOverlayType() {}
        public static implicit operator global::Lua.LuaValue(LuaOverlayType value) => new(value);
        public global::System.Type BindType => typeof(global::UnityEditor.Overlays.Overlay);
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
            var _this = _context.GetArgument<LuaOverlayType>(0);
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
            var _this = _context.GetArgument<LuaOverlayType>(0);
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
                case "ussClassName": _value = new global::Lua.LuaValue(global::UnityEditor.Overlays.Overlay.ussClassName); return true;
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
