
// --------------------------------------------------------------
// GENERATED FILE ----> DO NOT EDIT <---- CHANGES WILL BE LOST !!
// --------------------------------------------------------------

#if UNITY_6000_1_OR_NEWER && !(UNITY_6000_2_OR_NEWER)
#pragma warning disable 0109, 0162, 0168, 0219
using Luny;

namespace LunyEditor.UnityEditor.U2D
{
    public sealed class LuaSpriteAtlasExtensionsType : global::Luny.ILuaStatic
    {
        public static global::Lua.LuaValue Bind() => new LuaSpriteAtlasExtensionsType();
        private LuaSpriteAtlasExtensionsType() {}
        public static implicit operator global::Lua.LuaValue(LuaSpriteAtlasExtensionsType value) => new(value);
        public global::System.Type BindType => typeof(global::UnityEditor.U2D.SpriteAtlasExtensions);
        public override global::System.String ToString() => BindType.FullName;
#if UNITY_EDITOR
        [global::UnityEngine.RuntimeInitializeOnLoadMethod(global::UnityEngine.RuntimeInitializeLoadType.SubsystemRegistration)]
        private static void ResetStaticFields() => s_Metatable = null;
#endif

        private static readonly global::Lua.LuaFunction _LuaSpriteAtlasExtensions_Add = new global::Lua.LuaFunction("Add", (_context, _) =>
        {
            global::Lua.LuaValue _lastArg = default;
            global::System.Int32 _lastArgPos = default;
            global::System.Type _expectedType = default;
            var _argCount = _context.ArgumentCount;
            var _arg0 = _lastArg = _argCount > 0 ? _context.GetArgument(0) : global::Lua.LuaValue.Nil;
            _lastArgPos = 0; _expectedType = typeof(global::Luny.UnityEngine.U2D.LuaSpriteAtlas);
            if (_arg0.TryRead<global::Luny.UnityEngine.U2D.LuaSpriteAtlas>(out var _p0_UnityEngine_U2D_SpriteAtlas))
            {
                var _arg1 = _lastArg = _argCount > 1 ? _context.GetArgument(1) : global::Lua.LuaValue.Nil;
                _lastArgPos = 1; _expectedType = typeof(global::UnityEngine.Object[]);
                if (_arg1.TryReadArray<global::UnityEngine.Object>(out var _p1_UnityEngine_ObjectArray))
                {
                    if (_argCount == 2)
                    {
                        var spriteAtlas = _p0_UnityEngine_U2D_SpriteAtlas.Instance;
                        var objects = _p1_UnityEngine_ObjectArray;
                        global::UnityEditor.U2D.SpriteAtlasExtensions.Add(spriteAtlas, objects);
                        var _retCount = _context.Return();
                        return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                    }
                }
            }
            throw new global::Lua.LuaRuntimeException(_context.Thread, $"{"Add"}: invalid argument #{_lastArgPos}: {_lastArg} ({_lastArg.Type}), expected: {_expectedType.FullName}", 2);
        });
        private static readonly global::Lua.LuaFunction _LuaSpriteAtlasExtensions_GetMasterAtlas = new global::Lua.LuaFunction("GetMasterAtlas", (_context, _) =>
        {
            global::Lua.LuaValue _lastArg = default;
            global::System.Int32 _lastArgPos = default;
            global::System.Type _expectedType = default;
            var _argCount = _context.ArgumentCount;
            var _arg0 = _lastArg = _argCount > 0 ? _context.GetArgument(0) : global::Lua.LuaValue.Nil;
            _lastArgPos = 0; _expectedType = typeof(global::Luny.UnityEngine.U2D.LuaSpriteAtlas);
            if (_arg0.TryRead<global::Luny.UnityEngine.U2D.LuaSpriteAtlas>(out var _p0_UnityEngine_U2D_SpriteAtlas))
            {
                if (_argCount == 1)
                {
                    var spriteAtlas = _p0_UnityEngine_U2D_SpriteAtlas.Instance;
                    var _ret0 = global::UnityEditor.U2D.SpriteAtlasExtensions.GetMasterAtlas(spriteAtlas);
                    var _factory = _context.GetObjectFactory();
                    var _lret0 = _factory.Bind(_ret0);
                    var _retCount = _context.Return(_lret0);
                    return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                }
            }
            throw new global::Lua.LuaRuntimeException(_context.Thread, $"{"GetMasterAtlas"}: invalid argument #{_lastArgPos}: {_lastArg} ({_lastArg.Type}), expected: {_expectedType.FullName}", 2);
        });
        private static readonly global::Lua.LuaFunction _LuaSpriteAtlasExtensions_GetPackables = new global::Lua.LuaFunction("GetPackables", (_context, _) =>
        {
            global::Lua.LuaValue _lastArg = default;
            global::System.Int32 _lastArgPos = default;
            global::System.Type _expectedType = default;
            var _argCount = _context.ArgumentCount;
            var _arg0 = _lastArg = _argCount > 0 ? _context.GetArgument(0) : global::Lua.LuaValue.Nil;
            _lastArgPos = 0; _expectedType = typeof(global::Luny.UnityEngine.U2D.LuaSpriteAtlas);
            if (_arg0.TryRead<global::Luny.UnityEngine.U2D.LuaSpriteAtlas>(out var _p0_UnityEngine_U2D_SpriteAtlas))
            {
                if (_argCount == 1)
                {
                    var spriteAtlas = _p0_UnityEngine_U2D_SpriteAtlas.Instance;
                    var _ret0 = global::UnityEditor.U2D.SpriteAtlasExtensions.GetPackables(spriteAtlas);
                    var _factory = _context.GetObjectFactory();
                    var _lret0 = _factory.Bind(_ret0);
                    var _retCount = _context.Return(_lret0);
                    return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                }
            }
            throw new global::Lua.LuaRuntimeException(_context.Thread, $"{"GetPackables"}: invalid argument #{_lastArgPos}: {_lastArg} ({_lastArg.Type}), expected: {_expectedType.FullName}", 2);
        });
        private static readonly global::Lua.LuaFunction _LuaSpriteAtlasExtensions_GetPackingSettings = new global::Lua.LuaFunction("GetPackingSettings", (_context, _) =>
        {
            global::Lua.LuaValue _lastArg = default;
            global::System.Int32 _lastArgPos = default;
            global::System.Type _expectedType = default;
            var _argCount = _context.ArgumentCount;
            var _arg0 = _lastArg = _argCount > 0 ? _context.GetArgument(0) : global::Lua.LuaValue.Nil;
            _lastArgPos = 0; _expectedType = typeof(global::Luny.UnityEngine.U2D.LuaSpriteAtlas);
            if (_arg0.TryRead<global::Luny.UnityEngine.U2D.LuaSpriteAtlas>(out var _p0_UnityEngine_U2D_SpriteAtlas))
            {
                if (_argCount == 1)
                {
                    var spriteAtlas = _p0_UnityEngine_U2D_SpriteAtlas.Instance;
                    var _ret0 = global::UnityEditor.U2D.SpriteAtlasExtensions.GetPackingSettings(spriteAtlas);
                    var _lret0 = global::LunyEditor.UnityEditor.U2D.LuaSpriteAtlasPackingSettings.Bind(_ret0);
                    var _retCount = _context.Return(_lret0);
                    return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                }
            }
            throw new global::Lua.LuaRuntimeException(_context.Thread, $"{"GetPackingSettings"}: invalid argument #{_lastArgPos}: {_lastArg} ({_lastArg.Type}), expected: {_expectedType.FullName}", 2);
        });
        private static readonly global::Lua.LuaFunction _LuaSpriteAtlasExtensions_GetPlatformSettings = new global::Lua.LuaFunction("GetPlatformSettings", (_context, _) =>
        {
            global::Lua.LuaValue _lastArg = default;
            global::System.Int32 _lastArgPos = default;
            global::System.Type _expectedType = default;
            var _argCount = _context.ArgumentCount;
            var _arg0 = _lastArg = _argCount > 0 ? _context.GetArgument(0) : global::Lua.LuaValue.Nil;
            _lastArgPos = 0; _expectedType = typeof(global::Luny.UnityEngine.U2D.LuaSpriteAtlas);
            if (_arg0.TryRead<global::Luny.UnityEngine.U2D.LuaSpriteAtlas>(out var _p0_UnityEngine_U2D_SpriteAtlas))
            {
                var _arg1 = _lastArg = _argCount > 1 ? _context.GetArgument(1) : global::Lua.LuaValue.Nil;
                _lastArgPos = 1; _expectedType = typeof(global::System.String);
                if (_arg1.TryRead<global::System.String>(out var _p1_System_String))
                {
                    if (_argCount == 2)
                    {
                        var spriteAtlas = _p0_UnityEngine_U2D_SpriteAtlas.Instance;
                        var buildTarget = _p1_System_String;
                        var _ret0 = global::UnityEditor.U2D.SpriteAtlasExtensions.GetPlatformSettings(spriteAtlas, buildTarget);
                        var _factory = _context.GetObjectFactory();
                        var _lret0 = _factory.Bind(_ret0);
                        var _retCount = _context.Return(_lret0);
                        return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                    }
                }
            }
            throw new global::Lua.LuaRuntimeException(_context.Thread, $"{"GetPlatformSettings"}: invalid argument #{_lastArgPos}: {_lastArg} ({_lastArg.Type}), expected: {_expectedType.FullName}", 2);
        });
        private static readonly global::Lua.LuaFunction _LuaSpriteAtlasExtensions_GetTextureSettings = new global::Lua.LuaFunction("GetTextureSettings", (_context, _) =>
        {
            global::Lua.LuaValue _lastArg = default;
            global::System.Int32 _lastArgPos = default;
            global::System.Type _expectedType = default;
            var _argCount = _context.ArgumentCount;
            var _arg0 = _lastArg = _argCount > 0 ? _context.GetArgument(0) : global::Lua.LuaValue.Nil;
            _lastArgPos = 0; _expectedType = typeof(global::Luny.UnityEngine.U2D.LuaSpriteAtlas);
            if (_arg0.TryRead<global::Luny.UnityEngine.U2D.LuaSpriteAtlas>(out var _p0_UnityEngine_U2D_SpriteAtlas))
            {
                if (_argCount == 1)
                {
                    var spriteAtlas = _p0_UnityEngine_U2D_SpriteAtlas.Instance;
                    var _ret0 = global::UnityEditor.U2D.SpriteAtlasExtensions.GetTextureSettings(spriteAtlas);
                    var _lret0 = global::LunyEditor.UnityEditor.U2D.LuaSpriteAtlasTextureSettings.Bind(_ret0);
                    var _retCount = _context.Return(_lret0);
                    return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                }
            }
            throw new global::Lua.LuaRuntimeException(_context.Thread, $"{"GetTextureSettings"}: invalid argument #{_lastArgPos}: {_lastArg} ({_lastArg.Type}), expected: {_expectedType.FullName}", 2);
        });
        private static readonly global::Lua.LuaFunction _LuaSpriteAtlasExtensions_IsIncludeInBuild = new global::Lua.LuaFunction("IsIncludeInBuild", (_context, _) =>
        {
            global::Lua.LuaValue _lastArg = default;
            global::System.Int32 _lastArgPos = default;
            global::System.Type _expectedType = default;
            var _argCount = _context.ArgumentCount;
            var _arg0 = _lastArg = _argCount > 0 ? _context.GetArgument(0) : global::Lua.LuaValue.Nil;
            _lastArgPos = 0; _expectedType = typeof(global::Luny.UnityEngine.U2D.LuaSpriteAtlas);
            if (_arg0.TryRead<global::Luny.UnityEngine.U2D.LuaSpriteAtlas>(out var _p0_UnityEngine_U2D_SpriteAtlas))
            {
                if (_argCount == 1)
                {
                    var spriteAtlas = _p0_UnityEngine_U2D_SpriteAtlas.Instance;
                    var _ret0 = global::UnityEditor.U2D.SpriteAtlasExtensions.IsIncludeInBuild(spriteAtlas);
                    var _lret0 = new global::Lua.LuaValue(_ret0);
                    var _retCount = _context.Return(_lret0);
                    return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                }
            }
            throw new global::Lua.LuaRuntimeException(_context.Thread, $"{"IsIncludeInBuild"}: invalid argument #{_lastArgPos}: {_lastArg} ({_lastArg.Type}), expected: {_expectedType.FullName}", 2);
        });
        private static readonly global::Lua.LuaFunction _LuaSpriteAtlasExtensions_Remove = new global::Lua.LuaFunction("Remove", (_context, _) =>
        {
            global::Lua.LuaValue _lastArg = default;
            global::System.Int32 _lastArgPos = default;
            global::System.Type _expectedType = default;
            var _argCount = _context.ArgumentCount;
            var _arg0 = _lastArg = _argCount > 0 ? _context.GetArgument(0) : global::Lua.LuaValue.Nil;
            _lastArgPos = 0; _expectedType = typeof(global::Luny.UnityEngine.U2D.LuaSpriteAtlas);
            if (_arg0.TryRead<global::Luny.UnityEngine.U2D.LuaSpriteAtlas>(out var _p0_UnityEngine_U2D_SpriteAtlas))
            {
                var _arg1 = _lastArg = _argCount > 1 ? _context.GetArgument(1) : global::Lua.LuaValue.Nil;
                _lastArgPos = 1; _expectedType = typeof(global::UnityEngine.Object[]);
                if (_arg1.TryReadArray<global::UnityEngine.Object>(out var _p1_UnityEngine_ObjectArray))
                {
                    if (_argCount == 2)
                    {
                        var spriteAtlas = _p0_UnityEngine_U2D_SpriteAtlas.Instance;
                        var objects = _p1_UnityEngine_ObjectArray;
                        global::UnityEditor.U2D.SpriteAtlasExtensions.Remove(spriteAtlas, objects);
                        var _retCount = _context.Return();
                        return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                    }
                }
            }
            throw new global::Lua.LuaRuntimeException(_context.Thread, $"{"Remove"}: invalid argument #{_lastArgPos}: {_lastArg} ({_lastArg.Type}), expected: {_expectedType.FullName}", 2);
        });
        private static readonly global::Lua.LuaFunction _LuaSpriteAtlasExtensions_SetIncludeInBuild = new global::Lua.LuaFunction("SetIncludeInBuild", (_context, _) =>
        {
            global::Lua.LuaValue _lastArg = default;
            global::System.Int32 _lastArgPos = default;
            global::System.Type _expectedType = default;
            var _argCount = _context.ArgumentCount;
            var _arg0 = _lastArg = _argCount > 0 ? _context.GetArgument(0) : global::Lua.LuaValue.Nil;
            _lastArgPos = 0; _expectedType = typeof(global::Luny.UnityEngine.U2D.LuaSpriteAtlas);
            if (_arg0.TryRead<global::Luny.UnityEngine.U2D.LuaSpriteAtlas>(out var _p0_UnityEngine_U2D_SpriteAtlas))
            {
                var _arg1 = _lastArg = _argCount > 1 ? _context.GetArgument(1) : global::Lua.LuaValue.Nil;
                _lastArgPos = 1; _expectedType = typeof(global::System.Boolean);
                if (_arg1.TryRead<global::System.Boolean>(out var _p1_System_Boolean))
                {
                    if (_argCount == 2)
                    {
                        var spriteAtlas = _p0_UnityEngine_U2D_SpriteAtlas.Instance;
                        var value = _p1_System_Boolean;
                        global::UnityEditor.U2D.SpriteAtlasExtensions.SetIncludeInBuild(spriteAtlas, value);
                        var _retCount = _context.Return();
                        return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                    }
                }
            }
            throw new global::Lua.LuaRuntimeException(_context.Thread, $"{"SetIncludeInBuild"}: invalid argument #{_lastArgPos}: {_lastArg} ({_lastArg.Type}), expected: {_expectedType.FullName}", 2);
        });
        private static readonly global::Lua.LuaFunction _LuaSpriteAtlasExtensions_SetIsVariant = new global::Lua.LuaFunction("SetIsVariant", (_context, _) =>
        {
            global::Lua.LuaValue _lastArg = default;
            global::System.Int32 _lastArgPos = default;
            global::System.Type _expectedType = default;
            var _argCount = _context.ArgumentCount;
            var _arg0 = _lastArg = _argCount > 0 ? _context.GetArgument(0) : global::Lua.LuaValue.Nil;
            _lastArgPos = 0; _expectedType = typeof(global::Luny.UnityEngine.U2D.LuaSpriteAtlas);
            if (_arg0.TryRead<global::Luny.UnityEngine.U2D.LuaSpriteAtlas>(out var _p0_UnityEngine_U2D_SpriteAtlas))
            {
                var _arg1 = _lastArg = _argCount > 1 ? _context.GetArgument(1) : global::Lua.LuaValue.Nil;
                _lastArgPos = 1; _expectedType = typeof(global::System.Boolean);
                if (_arg1.TryRead<global::System.Boolean>(out var _p1_System_Boolean))
                {
                    if (_argCount == 2)
                    {
                        var spriteAtlas = _p0_UnityEngine_U2D_SpriteAtlas.Instance;
                        var value = _p1_System_Boolean;
                        global::UnityEditor.U2D.SpriteAtlasExtensions.SetIsVariant(spriteAtlas, value);
                        var _retCount = _context.Return();
                        return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                    }
                }
            }
            throw new global::Lua.LuaRuntimeException(_context.Thread, $"{"SetIsVariant"}: invalid argument #{_lastArgPos}: {_lastArg} ({_lastArg.Type}), expected: {_expectedType.FullName}", 2);
        });
        private static readonly global::Lua.LuaFunction _LuaSpriteAtlasExtensions_SetMasterAtlas = new global::Lua.LuaFunction("SetMasterAtlas", (_context, _) =>
        {
            global::Lua.LuaValue _lastArg = default;
            global::System.Int32 _lastArgPos = default;
            global::System.Type _expectedType = default;
            var _argCount = _context.ArgumentCount;
            var _arg0 = _lastArg = _argCount > 0 ? _context.GetArgument(0) : global::Lua.LuaValue.Nil;
            _lastArgPos = 0; _expectedType = typeof(global::Luny.UnityEngine.U2D.LuaSpriteAtlas);
            if (_arg0.TryRead<global::Luny.UnityEngine.U2D.LuaSpriteAtlas>(out var _p0_UnityEngine_U2D_SpriteAtlas))
            {
                var _arg1 = _lastArg = _argCount > 1 ? _context.GetArgument(1) : global::Lua.LuaValue.Nil;
                _lastArgPos = 1; _expectedType = typeof(global::Luny.UnityEngine.U2D.LuaSpriteAtlas);
                if (_arg1.TryRead<global::Luny.UnityEngine.U2D.LuaSpriteAtlas>(out var _p1_UnityEngine_U2D_SpriteAtlas))
                {
                    if (_argCount == 2)
                    {
                        var spriteAtlas = _p0_UnityEngine_U2D_SpriteAtlas.Instance;
                        var value = _p1_UnityEngine_U2D_SpriteAtlas.Instance;
                        global::UnityEditor.U2D.SpriteAtlasExtensions.SetMasterAtlas(spriteAtlas, value);
                        var _retCount = _context.Return();
                        return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                    }
                }
            }
            throw new global::Lua.LuaRuntimeException(_context.Thread, $"{"SetMasterAtlas"}: invalid argument #{_lastArgPos}: {_lastArg} ({_lastArg.Type}), expected: {_expectedType.FullName}", 2);
        });
        private static readonly global::Lua.LuaFunction _LuaSpriteAtlasExtensions_SetPackingSettings = new global::Lua.LuaFunction("SetPackingSettings", (_context, _) =>
        {
            global::Lua.LuaValue _lastArg = default;
            global::System.Int32 _lastArgPos = default;
            global::System.Type _expectedType = default;
            var _argCount = _context.ArgumentCount;
            var _arg0 = _lastArg = _argCount > 0 ? _context.GetArgument(0) : global::Lua.LuaValue.Nil;
            _lastArgPos = 0; _expectedType = typeof(global::Luny.UnityEngine.U2D.LuaSpriteAtlas);
            if (_arg0.TryRead<global::Luny.UnityEngine.U2D.LuaSpriteAtlas>(out var _p0_UnityEngine_U2D_SpriteAtlas))
            {
                var _arg1 = _lastArg = _argCount > 1 ? _context.GetArgument(1) : global::Lua.LuaValue.Nil;
                _lastArgPos = 1; _expectedType = typeof(global::LunyEditor.UnityEditor.U2D.LuaSpriteAtlasPackingSettings);
                if (_arg1.TryRead<global::LunyEditor.UnityEditor.U2D.LuaSpriteAtlasPackingSettings>(out var _p1_UnityEditor_U2D_SpriteAtlasPackingSettings))
                {
                    if (_argCount == 2)
                    {
                        var spriteAtlas = _p0_UnityEngine_U2D_SpriteAtlas.Instance;
                        var src = _p1_UnityEditor_U2D_SpriteAtlasPackingSettings.Value;
                        global::UnityEditor.U2D.SpriteAtlasExtensions.SetPackingSettings(spriteAtlas, src);
                        var _retCount = _context.Return();
                        return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                    }
                }
            }
            throw new global::Lua.LuaRuntimeException(_context.Thread, $"{"SetPackingSettings"}: invalid argument #{_lastArgPos}: {_lastArg} ({_lastArg.Type}), expected: {_expectedType.FullName}", 2);
        });
        private static readonly global::Lua.LuaFunction _LuaSpriteAtlasExtensions_SetPlatformSettings = new global::Lua.LuaFunction("SetPlatformSettings", (_context, _) =>
        {
            global::Lua.LuaValue _lastArg = default;
            global::System.Int32 _lastArgPos = default;
            global::System.Type _expectedType = default;
            var _argCount = _context.ArgumentCount;
            var _arg0 = _lastArg = _argCount > 0 ? _context.GetArgument(0) : global::Lua.LuaValue.Nil;
            _lastArgPos = 0; _expectedType = typeof(global::Luny.UnityEngine.U2D.LuaSpriteAtlas);
            if (_arg0.TryRead<global::Luny.UnityEngine.U2D.LuaSpriteAtlas>(out var _p0_UnityEngine_U2D_SpriteAtlas))
            {
                var _arg1 = _lastArg = _argCount > 1 ? _context.GetArgument(1) : global::Lua.LuaValue.Nil;
                _lastArgPos = 1; _expectedType = typeof(global::LunyEditor.UnityEditor.LuaTextureImporterPlatformSettings);
                if (_arg1.TryRead<global::LunyEditor.UnityEditor.LuaTextureImporterPlatformSettings>(out var _p1_UnityEditor_TextureImporterPlatformSettings))
                {
                    if (_argCount == 2)
                    {
                        var spriteAtlas = _p0_UnityEngine_U2D_SpriteAtlas.Instance;
                        var src = _p1_UnityEditor_TextureImporterPlatformSettings.Instance;
                        global::UnityEditor.U2D.SpriteAtlasExtensions.SetPlatformSettings(spriteAtlas, src);
                        var _retCount = _context.Return();
                        return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                    }
                }
            }
            throw new global::Lua.LuaRuntimeException(_context.Thread, $"{"SetPlatformSettings"}: invalid argument #{_lastArgPos}: {_lastArg} ({_lastArg.Type}), expected: {_expectedType.FullName}", 2);
        });
        private static readonly global::Lua.LuaFunction _LuaSpriteAtlasExtensions_SetTextureSettings = new global::Lua.LuaFunction("SetTextureSettings", (_context, _) =>
        {
            global::Lua.LuaValue _lastArg = default;
            global::System.Int32 _lastArgPos = default;
            global::System.Type _expectedType = default;
            var _argCount = _context.ArgumentCount;
            var _arg0 = _lastArg = _argCount > 0 ? _context.GetArgument(0) : global::Lua.LuaValue.Nil;
            _lastArgPos = 0; _expectedType = typeof(global::Luny.UnityEngine.U2D.LuaSpriteAtlas);
            if (_arg0.TryRead<global::Luny.UnityEngine.U2D.LuaSpriteAtlas>(out var _p0_UnityEngine_U2D_SpriteAtlas))
            {
                var _arg1 = _lastArg = _argCount > 1 ? _context.GetArgument(1) : global::Lua.LuaValue.Nil;
                _lastArgPos = 1; _expectedType = typeof(global::LunyEditor.UnityEditor.U2D.LuaSpriteAtlasTextureSettings);
                if (_arg1.TryRead<global::LunyEditor.UnityEditor.U2D.LuaSpriteAtlasTextureSettings>(out var _p1_UnityEditor_U2D_SpriteAtlasTextureSettings))
                {
                    if (_argCount == 2)
                    {
                        var spriteAtlas = _p0_UnityEngine_U2D_SpriteAtlas.Instance;
                        var src = _p1_UnityEditor_U2D_SpriteAtlasTextureSettings.Value;
                        global::UnityEditor.U2D.SpriteAtlasExtensions.SetTextureSettings(spriteAtlas, src);
                        var _retCount = _context.Return();
                        return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                    }
                }
            }
            throw new global::Lua.LuaRuntimeException(_context.Thread, $"{"SetTextureSettings"}: invalid argument #{_lastArgPos}: {_lastArg} ({_lastArg.Type}), expected: {_expectedType.FullName}", 2);
        });
        private static readonly global::Lua.LuaFunction _LuaSpriteAtlasExtensions_SetVariantScale = new global::Lua.LuaFunction("SetVariantScale", (_context, _) =>
        {
            global::Lua.LuaValue _lastArg = default;
            global::System.Int32 _lastArgPos = default;
            global::System.Type _expectedType = default;
            var _argCount = _context.ArgumentCount;
            var _arg0 = _lastArg = _argCount > 0 ? _context.GetArgument(0) : global::Lua.LuaValue.Nil;
            _lastArgPos = 0; _expectedType = typeof(global::Luny.UnityEngine.U2D.LuaSpriteAtlas);
            if (_arg0.TryRead<global::Luny.UnityEngine.U2D.LuaSpriteAtlas>(out var _p0_UnityEngine_U2D_SpriteAtlas))
            {
                var _arg1 = _lastArg = _argCount > 1 ? _context.GetArgument(1) : global::Lua.LuaValue.Nil;
                _lastArgPos = 1; _expectedType = typeof(global::System.Single);
                if (_arg1.TryRead<global::System.Single>(out var _p1_System_Single))
                {
                    if (_argCount == 2)
                    {
                        var spriteAtlas = _p0_UnityEngine_U2D_SpriteAtlas.Instance;
                        var value = _p1_System_Single;
                        global::UnityEditor.U2D.SpriteAtlasExtensions.SetVariantScale(spriteAtlas, value);
                        var _retCount = _context.Return();
                        return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                    }
                }
            }
            throw new global::Lua.LuaRuntimeException(_context.Thread, $"{"SetVariantScale"}: invalid argument #{_lastArgPos}: {_lastArg} ({_lastArg.Type}), expected: {_expectedType.FullName}", 2);
        });
        private static readonly global::Lua.LuaFunction __index = new(global::Lua.Runtime.Metamethods.Index, (_context, _) =>
        {
            var _this = _context.GetArgument<LuaSpriteAtlasExtensionsType>(0);
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
            var _this = _context.GetArgument<LuaSpriteAtlasExtensionsType>(0);
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
                case "Add": _value = _LuaSpriteAtlasExtensions_Add; return true;
                case "GetMasterAtlas": _value = _LuaSpriteAtlasExtensions_GetMasterAtlas; return true;
                case "GetPackables": _value = _LuaSpriteAtlasExtensions_GetPackables; return true;
                case "GetPackingSettings": _value = _LuaSpriteAtlasExtensions_GetPackingSettings; return true;
                case "GetPlatformSettings": _value = _LuaSpriteAtlasExtensions_GetPlatformSettings; return true;
                case "GetTextureSettings": _value = _LuaSpriteAtlasExtensions_GetTextureSettings; return true;
                case "IsIncludeInBuild": _value = _LuaSpriteAtlasExtensions_IsIncludeInBuild; return true;
                case "Remove": _value = _LuaSpriteAtlasExtensions_Remove; return true;
                case "SetIncludeInBuild": _value = _LuaSpriteAtlasExtensions_SetIncludeInBuild; return true;
                case "SetIsVariant": _value = _LuaSpriteAtlasExtensions_SetIsVariant; return true;
                case "SetMasterAtlas": _value = _LuaSpriteAtlasExtensions_SetMasterAtlas; return true;
                case "SetPackingSettings": _value = _LuaSpriteAtlasExtensions_SetPackingSettings; return true;
                case "SetPlatformSettings": _value = _LuaSpriteAtlasExtensions_SetPlatformSettings; return true;
                case "SetTextureSettings": _value = _LuaSpriteAtlasExtensions_SetTextureSettings; return true;
                case "SetVariantScale": _value = _LuaSpriteAtlasExtensions_SetVariantScale; return true;
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
