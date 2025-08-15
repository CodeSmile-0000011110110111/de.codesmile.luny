
// --------------------------------------------------------------
// GENERATED FILE ----> DO NOT EDIT <---- CHANGES WILL BE LOST !!
// --------------------------------------------------------------

#if UNITY_6000_2_OR_NEWER && !(UNITY_6000_3_OR_NEWER)
#pragma warning disable 0109, 0162, 0168, 0219
using Luny;

namespace Luny.UnityEditor.Build.Reporting
{
    public sealed class LuaCommonRolesType : global::Luny.ILuaStatic
    {
        public static global::Lua.LuaValue Bind() => new LuaCommonRolesType();
        private LuaCommonRolesType() {}
        public static implicit operator global::Lua.LuaValue(LuaCommonRolesType value) => new(value);
        public global::System.Type BindType => typeof(global::UnityEditor.Build.Reporting.CommonRoles);
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
            var _this = _context.GetArgument<LuaCommonRolesType>(0);
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
            var _this = _context.GetArgument<LuaCommonRolesType>(0);
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
                case "appInfo": _value = new global::Lua.LuaValue(global::UnityEditor.Build.Reporting.CommonRoles.appInfo); return true;
                case "assetBundle": _value = new global::Lua.LuaValue(global::UnityEditor.Build.Reporting.CommonRoles.assetBundle); return true;
                case "assetBundleTextManifest": _value = new global::Lua.LuaValue(global::UnityEditor.Build.Reporting.CommonRoles.assetBundleTextManifest); return true;
                case "bootConfig": _value = new global::Lua.LuaValue(global::UnityEditor.Build.Reporting.CommonRoles.bootConfig); return true;
                case "builtInResources": _value = new global::Lua.LuaValue(global::UnityEditor.Build.Reporting.CommonRoles.builtInResources); return true;
                case "builtInShaders": _value = new global::Lua.LuaValue(global::UnityEditor.Build.Reporting.CommonRoles.builtInShaders); return true;
                case "crashHandler": _value = new global::Lua.LuaValue(global::UnityEditor.Build.Reporting.CommonRoles.crashHandler); return true;
                case "debugInfo": _value = new global::Lua.LuaValue(global::UnityEditor.Build.Reporting.CommonRoles.debugInfo); return true;
                case "dependentManagedLibrary": _value = new global::Lua.LuaValue(global::UnityEditor.Build.Reporting.CommonRoles.dependentManagedLibrary); return true;
                case "engineLibrary": _value = new global::Lua.LuaValue(global::UnityEditor.Build.Reporting.CommonRoles.engineLibrary); return true;
                case "executable": _value = new global::Lua.LuaValue(global::UnityEditor.Build.Reporting.CommonRoles.executable); return true;
                case "globalGameManagers": _value = new global::Lua.LuaValue(global::UnityEditor.Build.Reporting.CommonRoles.globalGameManagers); return true;
                case "managedEngineApi": _value = new global::Lua.LuaValue(global::UnityEditor.Build.Reporting.CommonRoles.managedEngineApi); return true;
                case "managedLibrary": _value = new global::Lua.LuaValue(global::UnityEditor.Build.Reporting.CommonRoles.managedLibrary); return true;
                case "manifestAssetBundle": _value = new global::Lua.LuaValue(global::UnityEditor.Build.Reporting.CommonRoles.manifestAssetBundle); return true;
                case "monoConfig": _value = new global::Lua.LuaValue(global::UnityEditor.Build.Reporting.CommonRoles.monoConfig); return true;
                case "monoRuntime": _value = new global::Lua.LuaValue(global::UnityEditor.Build.Reporting.CommonRoles.monoRuntime); return true;
                case "resourcesFile": _value = new global::Lua.LuaValue(global::UnityEditor.Build.Reporting.CommonRoles.resourcesFile); return true;
                case "scene": _value = new global::Lua.LuaValue(global::UnityEditor.Build.Reporting.CommonRoles.scene); return true;
                case "sharedAssets": _value = new global::Lua.LuaValue(global::UnityEditor.Build.Reporting.CommonRoles.sharedAssets); return true;
                case "streamingAsset": _value = new global::Lua.LuaValue(global::UnityEditor.Build.Reporting.CommonRoles.streamingAsset); return true;
                case "streamingResourceFile": _value = new global::Lua.LuaValue(global::UnityEditor.Build.Reporting.CommonRoles.streamingResourceFile); return true;
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
