
// --------------------------------------------------------------
// GENERATED FILE ----> DO NOT EDIT <---- CHANGES WILL BE LOST !!
// --------------------------------------------------------------

#if UNITY_6000_0_OR_NEWER && !(UNITY_6000_1_OR_NEWER)
#pragma warning disable 0109, 0162, 0168, 0219
using Luny;

namespace LunyEditor.UnityEditor
{
    public sealed class LuaEditorUserSettings : global::Luny.UnityEngine.LuaUnityObject, global::Luny.ILuaObject<global::UnityEditor.EditorUserSettings>
    {
        public new static global::Lua.LuaValue Bind(global::UnityEditor.EditorUserSettings instance) => new LuaEditorUserSettings(instance);
        public new static global::Lua.LuaValue Bind(global::System.Object instance) => Bind((global::UnityEditor.EditorUserSettings)instance);
        public new static global::Lua.LuaValue Bind(global::System.Collections.Generic.IList<global::UnityEditor.EditorUserSettings> instances) =>
            new global::Luny.LuaList<global::UnityEditor.EditorUserSettings>(instances);
        public new static global::Lua.LuaValue Bind(global::System.Collections.Generic.IList<global::System.Object> instances) =>
            new global::Luny.LuaList<global::UnityEditor.EditorUserSettings>(instances);
        private LuaEditorUserSettings(global::UnityEditor.EditorUserSettings instance) : base(instance) {}
        public static implicit operator global::Lua.LuaValue(LuaEditorUserSettings value) => new(value);
        public new global::UnityEditor.EditorUserSettings Instance => (global::UnityEditor.EditorUserSettings)m_Instance;
        public new global::System.Type BindType => typeof(global::UnityEditor.EditorUserSettings);
        public override global::System.String ToString() => m_Instance != null ? Instance.ToString() : "{GetType().Name}(null)";
#if UNITY_EDITOR
        [global::UnityEngine.RuntimeInitializeOnLoadMethod(global::UnityEngine.RuntimeInitializeLoadType.SubsystemRegistration)]
        private static void ResetStaticFields() => s_Metatable = null;
#endif

        private static readonly global::Lua.LuaFunction __index = new(global::Lua.Runtime.Metamethods.Index, (_context, _) =>
        {
            var _this = _context.GetArgument<LuaEditorUserSettings>(0);
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
            var _this = _context.GetArgument<LuaEditorUserSettings>(0);
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
    public sealed class LuaEditorUserSettingsType : global::Luny.ILuaStatic
    {
        public static global::Lua.LuaValue Bind() => new LuaEditorUserSettingsType();
        private LuaEditorUserSettingsType() {}
        public static implicit operator global::Lua.LuaValue(LuaEditorUserSettingsType value) => new(value);
        public global::System.Type BindType => typeof(global::UnityEditor.EditorUserSettings);
        public override global::System.String ToString() => BindType.FullName;
#if UNITY_EDITOR
        [global::UnityEngine.RuntimeInitializeOnLoadMethod(global::UnityEngine.RuntimeInitializeLoadType.SubsystemRegistration)]
        private static void ResetStaticFields() => s_Metatable = null;
#endif

        private static readonly global::Lua.LuaFunction _LuaEditorUserSettings_GetConfigValue = new global::Lua.LuaFunction("GetConfigValue", (_context, _) =>
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
                    var name = _p0_System_String;
                    var _ret0 = global::UnityEditor.EditorUserSettings.GetConfigValue(name);
                    var _lret0 = new global::Lua.LuaValue(_ret0);
                    var _retCount = _context.Return(_lret0);
                    return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                }
            }
            throw new global::Lua.LuaRuntimeException(_context.Thread, $"{"GetConfigValue"}: invalid argument #{_lastArgPos}: {_lastArg} ({_lastArg.Type}), expected: {_expectedType.FullName}", 2);
        });
        private static readonly global::Lua.LuaFunction _LuaEditorUserSettings_SetConfigValue = new global::Lua.LuaFunction("SetConfigValue", (_context, _) =>
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
                _lastArgPos = 1; _expectedType = typeof(global::System.String);
                if (_arg1.TryRead<global::System.String>(out var _p1_System_String))
                {
                    if (_argCount == 2)
                    {
                        var name = _p0_System_String;
                        var value = _p1_System_String;
                        global::UnityEditor.EditorUserSettings.SetConfigValue(name, value);
                        var _retCount = _context.Return();
                        return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                    }
                }
            }
            throw new global::Lua.LuaRuntimeException(_context.Thread, $"{"SetConfigValue"}: invalid argument #{_lastArgPos}: {_lastArg} ({_lastArg.Type}), expected: {_expectedType.FullName}", 2);
        });
        private static readonly global::Lua.LuaFunction __index = new(global::Lua.Runtime.Metamethods.Index, (_context, _) =>
        {
            var _this = _context.GetArgument<LuaEditorUserSettingsType>(0);
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
            var _this = _context.GetArgument<LuaEditorUserSettingsType>(0);
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
                case "GetConfigValue": _value = _LuaEditorUserSettings_GetConfigValue; return true;
                case "SetConfigValue": _value = _LuaEditorUserSettings_SetConfigValue; return true;
                case "allowAsyncStatusUpdate": _value = new global::Lua.LuaValue(global::UnityEditor.EditorUserSettings.allowAsyncStatusUpdate); return true;
                case "artifactGarbageCollection": _value = new global::Lua.LuaValue(global::UnityEditor.EditorUserSettings.artifactGarbageCollection); return true;
                case "AutomaticAdd": _value = new global::Lua.LuaValue(global::UnityEditor.EditorUserSettings.AutomaticAdd); return true;
                case "compressAssetsOnImport": _value = new global::Lua.LuaValue(global::UnityEditor.EditorUserSettings.compressAssetsOnImport); return true;
                case "desiredImportWorkerCount": _value = new global::Lua.LuaValue(global::UnityEditor.EditorUserSettings.desiredImportWorkerCount); return true;
                case "hierarchyOverlayIcons": _value = new global::Lua.LuaValue(global::UnityEditor.EditorUserSettings.hierarchyOverlayIcons); return true;
                case "idleImportWorkerShutdownDelayMilliseconds": _value = new global::Lua.LuaValue(global::UnityEditor.EditorUserSettings.idleImportWorkerShutdownDelayMilliseconds); return true;
                case "otherOverlayIcons": _value = new global::Lua.LuaValue(global::UnityEditor.EditorUserSettings.otherOverlayIcons); return true;
                case "overlayIcons": _value = new global::Lua.LuaValue(global::UnityEditor.EditorUserSettings.overlayIcons); return true;
                case "overwriteFailedCheckoutAssets": _value = new global::Lua.LuaValue(global::UnityEditor.EditorUserSettings.overwriteFailedCheckoutAssets); return true;
                case "scanLocalPackagesOnConnect": _value = new global::Lua.LuaValue(global::UnityEditor.EditorUserSettings.scanLocalPackagesOnConnect); return true;
                case "semanticMergeMode": _value = new global::Lua.LuaValue((global::System.Int64)global::UnityEditor.EditorUserSettings.semanticMergeMode); return true;
                case "showFailedCheckout": _value = new global::Lua.LuaValue(global::UnityEditor.EditorUserSettings.showFailedCheckout); return true;
                case "standbyImportWorkerCount": _value = new global::Lua.LuaValue(global::UnityEditor.EditorUserSettings.standbyImportWorkerCount); return true;
                case "WorkOffline": _value = new global::Lua.LuaValue(global::UnityEditor.EditorUserSettings.WorkOffline); return true;
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
                case "allowAsyncStatusUpdate": global::UnityEditor.EditorUserSettings.allowAsyncStatusUpdate = _value.Read<global::System.Boolean>();  return true;
                case "artifactGarbageCollection": global::UnityEditor.EditorUserSettings.artifactGarbageCollection = _value.Read<global::System.Boolean>();  return true;
                case "AutomaticAdd": global::UnityEditor.EditorUserSettings.AutomaticAdd = _value.Read<global::System.Boolean>();  return true;
                case "compressAssetsOnImport": global::UnityEditor.EditorUserSettings.compressAssetsOnImport = _value.Read<global::System.Boolean>();  return true;
                case "desiredImportWorkerCount": global::UnityEditor.EditorUserSettings.desiredImportWorkerCount = _value.Read<global::System.Int32>();  return true;
                case "hierarchyOverlayIcons": global::UnityEditor.EditorUserSettings.hierarchyOverlayIcons = _value.Read<global::System.Boolean>();  return true;
                case "idleImportWorkerShutdownDelayMilliseconds": global::UnityEditor.EditorUserSettings.idleImportWorkerShutdownDelayMilliseconds = _value.Read<global::System.Int32>();  return true;
                case "otherOverlayIcons": global::UnityEditor.EditorUserSettings.otherOverlayIcons = _value.Read<global::System.Boolean>();  return true;
                case "overlayIcons": global::UnityEditor.EditorUserSettings.overlayIcons = _value.Read<global::System.Boolean>();  return true;
                case "overwriteFailedCheckoutAssets": global::UnityEditor.EditorUserSettings.overwriteFailedCheckoutAssets = _value.Read<global::System.Boolean>();  return true;
                case "scanLocalPackagesOnConnect": global::UnityEditor.EditorUserSettings.scanLocalPackagesOnConnect = _value.Read<global::System.Boolean>();  return true;
                case "semanticMergeMode": global::UnityEditor.EditorUserSettings.semanticMergeMode = _value.Read<global::UnityEditor.SemanticMergeMode>();  return true;
                case "showFailedCheckout": global::UnityEditor.EditorUserSettings.showFailedCheckout = _value.Read<global::System.Boolean>();  return true;
                case "standbyImportWorkerCount": global::UnityEditor.EditorUserSettings.standbyImportWorkerCount = _value.Read<global::System.Int32>();  return true;
                case "WorkOffline": global::UnityEditor.EditorUserSettings.WorkOffline = _value.Read<global::System.Boolean>();  return true;
                default: return false;
            }
        }
    }
}
#pragma warning restore 0109, 0162, 0168, 0219
#endif
