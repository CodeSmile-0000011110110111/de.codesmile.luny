
// --------------------------------------------------------------
// GENERATED FILE ----> DO NOT EDIT <---- CHANGES WILL BE LOST !!
// --------------------------------------------------------------

#if UNITY_6000_0_OR_NEWER && !(UNITY_6000_1_OR_NEWER)
#pragma warning disable 0109, 0162, 0168, 0219
using Luny;

namespace Luny.UnityEngine
{
    public class LuaRenderTexture : global::Luny.UnityEngine.LuaTexture, global::Luny.ILuaObject<global::UnityEngine.RenderTexture>
    {
        public new static global::Lua.LuaValue Bind(global::UnityEngine.RenderTexture instance) => new LuaRenderTexture(instance);
        public new static global::Lua.LuaValue Bind(global::System.Object instance) => Bind((global::UnityEngine.RenderTexture)instance);
        public new static global::Lua.LuaValue Bind(global::System.Collections.Generic.IList<global::UnityEngine.RenderTexture> instances) =>
            new global::Luny.LuaList<global::UnityEngine.RenderTexture>(instances);
        public new static global::Lua.LuaValue Bind(global::System.Collections.Generic.IList<global::System.Object> instances) =>
            new global::Luny.LuaList<global::UnityEngine.RenderTexture>(instances);
        protected LuaRenderTexture(global::UnityEngine.RenderTexture instance) : base(instance) {}
        public static implicit operator global::Lua.LuaValue(LuaRenderTexture value) => new(value);
        public new global::UnityEngine.RenderTexture Instance => (global::UnityEngine.RenderTexture)m_Instance;
        public new global::System.Type BindType => typeof(global::UnityEngine.RenderTexture);
        private static global::Lua.LuaTable s_Metatable;
        public new global::Lua.LuaTable Metatable
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

        private static readonly global::Lua.LuaFunction _LuaRenderTexture_ApplyDynamicScale = new global::Lua.LuaFunction("ApplyDynamicScale", (_context, _) =>
        {
            global::Lua.LuaValue _lastArg = default;
            global::System.Int32 _lastArgPos = default;
            global::System.Type _expectedType = default;
            var _argCount = _context.ArgumentCount;
            var _this = _context.GetArgument<LuaRenderTexture>(0);
            if (_argCount == 1)
            {
                _this.Instance.ApplyDynamicScale();
                var _retCount = _context.Return();
                return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
            }
            throw new global::Lua.LuaRuntimeException(_context.Thread, $"{"ApplyDynamicScale"}: invalid argument #{_lastArgPos}: {_lastArg} ({_lastArg.Type}), expected: {_expectedType.FullName}", 2);
        });
        private static readonly global::Lua.LuaFunction _LuaRenderTexture_ConvertToEquirect = new global::Lua.LuaFunction("ConvertToEquirect", (_context, _) =>
        {
            global::Lua.LuaValue _lastArg = default;
            global::System.Int32 _lastArgPos = default;
            global::System.Type _expectedType = default;
            var _argCount = _context.ArgumentCount;
            var _this = _context.GetArgument<LuaRenderTexture>(0);
            var _arg0 = _lastArg = _argCount > 1 ? _context.GetArgument(1) : global::Lua.LuaValue.Nil;
            _lastArgPos = 0; _expectedType = typeof(global::Luny.UnityEngine.LuaRenderTexture);
            if (_arg0.TryRead<global::Luny.UnityEngine.LuaRenderTexture>(out var _p0_UnityEngine_RenderTexture))
            {
                if (_argCount == 2)
                {
                    var equirect = _p0_UnityEngine_RenderTexture.Instance;
                    _this.Instance.ConvertToEquirect(equirect);
                    var _retCount = _context.Return();
                    return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                }
                var _arg1 = _lastArg = _argCount > 2 ? _context.GetArgument(2) : global::Lua.LuaValue.Nil;
                _lastArgPos = 1; _expectedType = typeof(global::UnityEngine.Camera.MonoOrStereoscopicEye);
                var _p1_UnityEngine_Camera_MonoOrStereoscopicEye = _arg1.ReadValue<global::UnityEngine.Camera.MonoOrStereoscopicEye>(global::UnityEngine.Camera.MonoOrStereoscopicEye.@Mono);
                {
                    if (_argCount == 3)
                    {
                        var equirect = _p0_UnityEngine_RenderTexture.Instance;
                        var eye = _p1_UnityEngine_Camera_MonoOrStereoscopicEye;
                        _this.Instance.ConvertToEquirect(equirect, eye);
                        var _retCount = _context.Return();
                        return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                    }
                }
            }
            throw new global::Lua.LuaRuntimeException(_context.Thread, $"{"ConvertToEquirect"}: invalid argument #{_lastArgPos}: {_lastArg} ({_lastArg.Type}), expected: {_expectedType.FullName}", 2);
        });
        private static readonly global::Lua.LuaFunction _LuaRenderTexture_Create = new global::Lua.LuaFunction("Create", (_context, _) =>
        {
            global::Lua.LuaValue _lastArg = default;
            global::System.Int32 _lastArgPos = default;
            global::System.Type _expectedType = default;
            var _argCount = _context.ArgumentCount;
            var _this = _context.GetArgument<LuaRenderTexture>(0);
            if (_argCount == 1)
            {
                var _ret0 = _this.Instance.Create();
                var _lret0 = new global::Lua.LuaValue(_ret0);
                var _retCount = _context.Return(_lret0);
                return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
            }
            throw new global::Lua.LuaRuntimeException(_context.Thread, $"{"Create"}: invalid argument #{_lastArgPos}: {_lastArg} ({_lastArg.Type}), expected: {_expectedType.FullName}", 2);
        });
        private static readonly global::Lua.LuaFunction _LuaRenderTexture_DiscardContents = new global::Lua.LuaFunction("DiscardContents", (_context, _) =>
        {
            global::Lua.LuaValue _lastArg = default;
            global::System.Int32 _lastArgPos = default;
            global::System.Type _expectedType = default;
            var _argCount = _context.ArgumentCount;
            var _this = _context.GetArgument<LuaRenderTexture>(0);
            if (_argCount == 1)
            {
                _this.Instance.DiscardContents();
                var _retCount = _context.Return();
                return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
            }
            var _arg0 = _lastArg = _argCount > 1 ? _context.GetArgument(1) : global::Lua.LuaValue.Nil;
            _lastArgPos = 0; _expectedType = typeof(global::System.Boolean);
            if (_arg0.TryRead<global::System.Boolean>(out var _p0_System_Boolean))
            {
                var _arg1 = _lastArg = _argCount > 2 ? _context.GetArgument(2) : global::Lua.LuaValue.Nil;
                _lastArgPos = 1; _expectedType = typeof(global::System.Boolean);
                if (_arg1.TryRead<global::System.Boolean>(out var _p1_System_Boolean))
                {
                    if (_argCount == 3)
                    {
                        var discardColor = _p0_System_Boolean;
                        var discardDepth = _p1_System_Boolean;
                        _this.Instance.DiscardContents(discardColor, discardDepth);
                        var _retCount = _context.Return();
                        return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                    }
                }
            }
            throw new global::Lua.LuaRuntimeException(_context.Thread, $"{"DiscardContents"}: invalid argument #{_lastArgPos}: {_lastArg} ({_lastArg.Type}), expected: {_expectedType.FullName}", 2);
        });
        private static readonly global::Lua.LuaFunction _LuaRenderTexture_GenerateMips = new global::Lua.LuaFunction("GenerateMips", (_context, _) =>
        {
            global::Lua.LuaValue _lastArg = default;
            global::System.Int32 _lastArgPos = default;
            global::System.Type _expectedType = default;
            var _argCount = _context.ArgumentCount;
            var _this = _context.GetArgument<LuaRenderTexture>(0);
            if (_argCount == 1)
            {
                _this.Instance.GenerateMips();
                var _retCount = _context.Return();
                return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
            }
            throw new global::Lua.LuaRuntimeException(_context.Thread, $"{"GenerateMips"}: invalid argument #{_lastArgPos}: {_lastArg} ({_lastArg.Type}), expected: {_expectedType.FullName}", 2);
        });
        private static readonly global::Lua.LuaFunction _LuaRenderTexture_IsCreated = new global::Lua.LuaFunction("IsCreated", (_context, _) =>
        {
            global::Lua.LuaValue _lastArg = default;
            global::System.Int32 _lastArgPos = default;
            global::System.Type _expectedType = default;
            var _argCount = _context.ArgumentCount;
            var _this = _context.GetArgument<LuaRenderTexture>(0);
            if (_argCount == 1)
            {
                var _ret0 = _this.Instance.IsCreated();
                var _lret0 = new global::Lua.LuaValue(_ret0);
                var _retCount = _context.Return(_lret0);
                return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
            }
            throw new global::Lua.LuaRuntimeException(_context.Thread, $"{"IsCreated"}: invalid argument #{_lastArgPos}: {_lastArg} ({_lastArg.Type}), expected: {_expectedType.FullName}", 2);
        });
        private static readonly global::Lua.LuaFunction _LuaRenderTexture_Release = new global::Lua.LuaFunction("Release", (_context, _) =>
        {
            global::Lua.LuaValue _lastArg = default;
            global::System.Int32 _lastArgPos = default;
            global::System.Type _expectedType = default;
            var _argCount = _context.ArgumentCount;
            var _this = _context.GetArgument<LuaRenderTexture>(0);
            if (_argCount == 1)
            {
                _this.Instance.Release();
                var _retCount = _context.Return();
                return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
            }
            throw new global::Lua.LuaRuntimeException(_context.Thread, $"{"Release"}: invalid argument #{_lastArgPos}: {_lastArg} ({_lastArg.Type}), expected: {_expectedType.FullName}", 2);
        });
        private static readonly global::Lua.LuaFunction _LuaRenderTexture_ResolveAntiAliasedSurface = new global::Lua.LuaFunction("ResolveAntiAliasedSurface", (_context, _) =>
        {
            global::Lua.LuaValue _lastArg = default;
            global::System.Int32 _lastArgPos = default;
            global::System.Type _expectedType = default;
            var _argCount = _context.ArgumentCount;
            var _this = _context.GetArgument<LuaRenderTexture>(0);
            if (_argCount == 1)
            {
                _this.Instance.ResolveAntiAliasedSurface();
                var _retCount = _context.Return();
                return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
            }
            var _arg0 = _lastArg = _argCount > 1 ? _context.GetArgument(1) : global::Lua.LuaValue.Nil;
            _lastArgPos = 0; _expectedType = typeof(global::Luny.UnityEngine.LuaRenderTexture);
            if (_arg0.TryRead<global::Luny.UnityEngine.LuaRenderTexture>(out var _p0_UnityEngine_RenderTexture))
            {
                if (_argCount == 2)
                {
                    var target = _p0_UnityEngine_RenderTexture.Instance;
                    _this.Instance.ResolveAntiAliasedSurface(target);
                    var _retCount = _context.Return();
                    return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                }
            }
            throw new global::Lua.LuaRuntimeException(_context.Thread, $"{"ResolveAntiAliasedSurface"}: invalid argument #{_lastArgPos}: {_lastArg} ({_lastArg.Type}), expected: {_expectedType.FullName}", 2);
        });
        private static readonly global::Lua.LuaFunction _LuaRenderTexture_SetGlobalShaderProperty = new global::Lua.LuaFunction("SetGlobalShaderProperty", (_context, _) =>
        {
            global::Lua.LuaValue _lastArg = default;
            global::System.Int32 _lastArgPos = default;
            global::System.Type _expectedType = default;
            var _argCount = _context.ArgumentCount;
            var _this = _context.GetArgument<LuaRenderTexture>(0);
            var _arg0 = _lastArg = _argCount > 1 ? _context.GetArgument(1) : global::Lua.LuaValue.Nil;
            _lastArgPos = 0; _expectedType = typeof(global::System.String);
            if (_arg0.TryRead<global::System.String>(out var _p0_System_String))
            {
                if (_argCount == 2)
                {
                    var propertyName = _p0_System_String;
                    _this.Instance.SetGlobalShaderProperty(propertyName);
                    var _retCount = _context.Return();
                    return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                }
            }
            throw new global::Lua.LuaRuntimeException(_context.Thread, $"{"SetGlobalShaderProperty"}: invalid argument #{_lastArgPos}: {_lastArg} ({_lastArg.Type}), expected: {_expectedType.FullName}", 2);
        });
        private static readonly global::Lua.LuaFunction __index = new(global::Lua.Runtime.Metamethods.Index, (_context, _) =>
        {
            var _this = _context.GetArgument<LuaRenderTexture>(0);
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
            var _this = _context.GetArgument<LuaRenderTexture>(0);
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
                case "ApplyDynamicScale": _value = _LuaRenderTexture_ApplyDynamicScale; return true;
                case "ConvertToEquirect": _value = _LuaRenderTexture_ConvertToEquirect; return true;
                case "Create": _value = _LuaRenderTexture_Create; return true;
                case "DiscardContents": _value = _LuaRenderTexture_DiscardContents; return true;
                case "GenerateMips": _value = _LuaRenderTexture_GenerateMips; return true;
                case "IsCreated": _value = _LuaRenderTexture_IsCreated; return true;
                case "Release": _value = _LuaRenderTexture_Release; return true;
                case "ResolveAntiAliasedSurface": _value = _LuaRenderTexture_ResolveAntiAliasedSurface; return true;
                case "SetGlobalShaderProperty": _value = _LuaRenderTexture_SetGlobalShaderProperty; return true;
                case "antiAliasing": _value = new global::Lua.LuaValue(Instance.antiAliasing); return true;
                case "autoGenerateMips": _value = new global::Lua.LuaValue(Instance.autoGenerateMips); return true;
                case "bindTextureMS": _value = new global::Lua.LuaValue(Instance.bindTextureMS); return true;
                case "colorBuffer": _value = global::Luny.UnityEngine.LuaRenderBuffer.Bind(Instance.colorBuffer); return true;
                case "depth": _value = new global::Lua.LuaValue(Instance.depth); return true;
                case "depthBuffer": _value = global::Luny.UnityEngine.LuaRenderBuffer.Bind(Instance.depthBuffer); return true;
                case "depthStencilFormat": _value = new global::Lua.LuaValue((global::System.Int64)Instance.depthStencilFormat); return true;
                case "descriptor": _value = global::Luny.UnityEngine.LuaRenderTextureDescriptor.Bind(Instance.descriptor); return true;
                case "dimension": _value = new global::Lua.LuaValue((global::System.Int64)Instance.dimension); return true;
                case "enableRandomWrite": _value = new global::Lua.LuaValue(Instance.enableRandomWrite); return true;
                case "format": _value = new global::Lua.LuaValue((global::System.Int64)Instance.format); return true;
                case "graphicsFormat": _value = new global::Lua.LuaValue((global::System.Int64)Instance.graphicsFormat); return true;
                case "height": _value = new global::Lua.LuaValue(Instance.height); return true;
                case "isPowerOfTwo": _value = new global::Lua.LuaValue(Instance.isPowerOfTwo); return true;
                case "memorylessMode": _value = new global::Lua.LuaValue((global::System.Int64)Instance.memorylessMode); return true;
                case "sRGB": _value = new global::Lua.LuaValue(Instance.sRGB); return true;
                case "stencilFormat": _value = new global::Lua.LuaValue((global::System.Int64)Instance.stencilFormat); return true;
                case "useDynamicScale": _value = new global::Lua.LuaValue(Instance.useDynamicScale); return true;
                case "useDynamicScaleExplicit": _value = new global::Lua.LuaValue(Instance.useDynamicScaleExplicit); return true;
                case "useMipMap": _value = new global::Lua.LuaValue(Instance.useMipMap); return true;
                case "volumeDepth": _value = new global::Lua.LuaValue(Instance.volumeDepth); return true;
                case "vrUsage": _value = new global::Lua.LuaValue((global::System.Int64)Instance.vrUsage); return true;
                case "width": _value = new global::Lua.LuaValue(Instance.width); return true;
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
                case "antiAliasing": Instance.antiAliasing = _value.Read<global::System.Int32>();  return true;
                case "autoGenerateMips": Instance.autoGenerateMips = _value.Read<global::System.Boolean>();  return true;
                case "bindTextureMS": Instance.bindTextureMS = _value.Read<global::System.Boolean>();  return true;
                case "depth": Instance.depth = _value.Read<global::System.Int32>();  return true;
                case "depthStencilFormat": Instance.depthStencilFormat = _value.Read<global::UnityEngine.Experimental.Rendering.GraphicsFormat>();  return true;
                case "descriptor": Instance.descriptor = _value.Read<global::Luny.UnityEngine.LuaRenderTextureDescriptor>().Value;  return true;
                case "dimension": Instance.dimension = _value.Read<global::UnityEngine.Rendering.TextureDimension>();  return true;
                case "enableRandomWrite": Instance.enableRandomWrite = _value.Read<global::System.Boolean>();  return true;
                case "format": Instance.format = _value.Read<global::UnityEngine.RenderTextureFormat>();  return true;
                case "graphicsFormat": Instance.graphicsFormat = _value.Read<global::UnityEngine.Experimental.Rendering.GraphicsFormat>();  return true;
                case "height": Instance.height = _value.Read<global::System.Int32>();  return true;
                case "isPowerOfTwo": Instance.isPowerOfTwo = _value.Read<global::System.Boolean>();  return true;
                case "memorylessMode": Instance.memorylessMode = _value.Read<global::UnityEngine.RenderTextureMemoryless>();  return true;
                case "stencilFormat": Instance.stencilFormat = _value.Read<global::UnityEngine.Experimental.Rendering.GraphicsFormat>();  return true;
                case "useDynamicScale": Instance.useDynamicScale = _value.Read<global::System.Boolean>();  return true;
                case "useDynamicScaleExplicit": Instance.useDynamicScaleExplicit = _value.Read<global::System.Boolean>();  return true;
                case "useMipMap": Instance.useMipMap = _value.Read<global::System.Boolean>();  return true;
                case "volumeDepth": Instance.volumeDepth = _value.Read<global::System.Int32>();  return true;
                case "vrUsage": Instance.vrUsage = _value.Read<global::UnityEngine.VRTextureUsage>();  return true;
                case "width": Instance.width = _value.Read<global::System.Int32>();  return true;
                default: return base.TrySetLuaValue(_key, _value);
            }
        }
    }
    public sealed class LuaRenderTextureType : global::Luny.ILuaStatic
    {
        public static global::Lua.LuaValue Bind() => new LuaRenderTextureType();
        private LuaRenderTextureType() {}
        public static implicit operator global::Lua.LuaValue(LuaRenderTextureType value) => new(value);
        public global::System.Type BindType => typeof(global::UnityEngine.RenderTexture);
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
            metatable[global::Lua.Runtime.Metamethods.Call] = _LuaRenderTexture_new;
            return metatable;
        }
        public override global::System.String ToString() => BindType.FullName;
#if UNITY_EDITOR
        [global::UnityEngine.RuntimeInitializeOnLoadMethod(global::UnityEngine.RuntimeInitializeLoadType.SubsystemRegistration)]
        private static void ResetStaticFields() => s_Metatable = null;
#endif

        private static readonly global::Lua.LuaFunction _LuaRenderTexture_new = new global::Lua.LuaFunction(".ctor", (_context, _) =>
        {
            global::Lua.LuaValue _lastArg = default;
            global::System.Int32 _lastArgPos = default;
            global::System.Type _expectedType = default;
            var _argCount = _context.ArgumentCount;
            var _arg0 = _lastArg = _argCount > 1 ? _context.GetArgument(1) : global::Lua.LuaValue.Nil;
            _lastArgPos = 0; _expectedType = typeof(global::Luny.UnityEngine.LuaRenderTextureDescriptor);
            if (_arg0.TryRead<global::Luny.UnityEngine.LuaRenderTextureDescriptor>(out var _p0_UnityEngine_RenderTextureDescriptor))
            {
                if (_argCount == 2)
                {
                    var desc = _p0_UnityEngine_RenderTextureDescriptor.Value;
                    var _ret0 = new global::UnityEngine.RenderTexture(desc);
                    var _factory = _context.GetObjectFactory();
                    var _lret0 = _factory.Bind(_ret0);
                    var _retCount = _context.Return(_lret0);
                    return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                }
            }
            _lastArgPos = 0; _expectedType = typeof(global::Luny.UnityEngine.LuaRenderTexture);
            if (_arg0.TryRead<global::Luny.UnityEngine.LuaRenderTexture>(out var _p0_UnityEngine_RenderTexture))
            {
                if (_argCount == 2)
                {
                    var textureToCopy = _p0_UnityEngine_RenderTexture.Instance;
                    var _ret0 = new global::UnityEngine.RenderTexture(textureToCopy);
                    var _factory = _context.GetObjectFactory();
                    var _lret0 = _factory.Bind(_ret0);
                    var _retCount = _context.Return(_lret0);
                    return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                }
            }
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
                            var width = _p0_System_Int32;
                            var height = _p1_System_Int32;
                            var depth = _p2_System_Int32;
                            var _ret0 = new global::UnityEngine.RenderTexture(width, height, depth);
                            var _factory = _context.GetObjectFactory();
                            var _lret0 = _factory.Bind(_ret0);
                            var _retCount = _context.Return(_lret0);
                            return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                        }
                        var _arg3 = _lastArg = _argCount > 4 ? _context.GetArgument(4) : global::Lua.LuaValue.Nil;
                        _lastArgPos = 3; _expectedType = typeof(global::UnityEngine.Experimental.Rendering.GraphicsFormat);
                        if (_arg3.TryRead<global::UnityEngine.Experimental.Rendering.GraphicsFormat>(out var _p3_UnityEngine_Experimental_Rendering_GraphicsFormat))
                        {
                            if (_argCount == 5)
                            {
                                var width = _p0_System_Int32;
                                var height = _p1_System_Int32;
                                var depth = _p2_System_Int32;
                                var format = _p3_UnityEngine_Experimental_Rendering_GraphicsFormat;
                                var _ret0 = new global::UnityEngine.RenderTexture(width, height, depth, format);
                                var _factory = _context.GetObjectFactory();
                                var _lret0 = _factory.Bind(_ret0);
                                var _retCount = _context.Return(_lret0);
                                return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                            }
                            var _arg4 = _lastArg = _argCount > 5 ? _context.GetArgument(5) : global::Lua.LuaValue.Nil;
                            _lastArgPos = 4; _expectedType = typeof(global::System.Int32);
                            if (_arg4.TryRead<global::System.Int32>(out var _p4_System_Int32))
                            {
                                if (_argCount == 6)
                                {
                                    var width = _p0_System_Int32;
                                    var height = _p1_System_Int32;
                                    var depth = _p2_System_Int32;
                                    var format = _p3_UnityEngine_Experimental_Rendering_GraphicsFormat;
                                    var mipCount = _p4_System_Int32;
                                    var _ret0 = new global::UnityEngine.RenderTexture(width, height, depth, format, mipCount);
                                    var _factory = _context.GetObjectFactory();
                                    var _lret0 = _factory.Bind(_ret0);
                                    var _retCount = _context.Return(_lret0);
                                    return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                                }
                            }
                        }
                        _lastArgPos = 3; _expectedType = typeof(global::UnityEngine.RenderTextureFormat);
                        if (_arg3.TryRead<global::UnityEngine.RenderTextureFormat>(out var _p3_UnityEngine_RenderTextureFormat))
                        {
                            if (_argCount == 5)
                            {
                                var width = _p0_System_Int32;
                                var height = _p1_System_Int32;
                                var depth = _p2_System_Int32;
                                var format = _p3_UnityEngine_RenderTextureFormat;
                                var _ret0 = new global::UnityEngine.RenderTexture(width, height, depth, format);
                                var _factory = _context.GetObjectFactory();
                                var _lret0 = _factory.Bind(_ret0);
                                var _retCount = _context.Return(_lret0);
                                return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                            }
                            var _arg4 = _lastArg = _argCount > 5 ? _context.GetArgument(5) : global::Lua.LuaValue.Nil;
                            _lastArgPos = 4; _expectedType = typeof(global::System.Int32);
                            if (_arg4.TryRead<global::System.Int32>(out var _p4_System_Int32))
                            {
                                if (_argCount == 6)
                                {
                                    var width = _p0_System_Int32;
                                    var height = _p1_System_Int32;
                                    var depth = _p2_System_Int32;
                                    var format = _p3_UnityEngine_RenderTextureFormat;
                                    var mipCount = _p4_System_Int32;
                                    var _ret0 = new global::UnityEngine.RenderTexture(width, height, depth, format, mipCount);
                                    var _factory = _context.GetObjectFactory();
                                    var _lret0 = _factory.Bind(_ret0);
                                    var _retCount = _context.Return(_lret0);
                                    return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                                }
                            }
                            _lastArgPos = 4; _expectedType = typeof(global::UnityEngine.RenderTextureReadWrite);
                            if (_arg4.TryRead<global::UnityEngine.RenderTextureReadWrite>(out var _p4_UnityEngine_RenderTextureReadWrite))
                            {
                                if (_argCount == 6)
                                {
                                    var width = _p0_System_Int32;
                                    var height = _p1_System_Int32;
                                    var depth = _p2_System_Int32;
                                    var format = _p3_UnityEngine_RenderTextureFormat;
                                    var readWrite = _p4_UnityEngine_RenderTextureReadWrite;
                                    var _ret0 = new global::UnityEngine.RenderTexture(width, height, depth, format, readWrite);
                                    var _factory = _context.GetObjectFactory();
                                    var _lret0 = _factory.Bind(_ret0);
                                    var _retCount = _context.Return(_lret0);
                                    return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                                }
                            }
                        }
                        _lastArgPos = 3; _expectedType = typeof(global::UnityEngine.Experimental.Rendering.DefaultFormat);
                        if (_arg3.TryRead<global::UnityEngine.Experimental.Rendering.DefaultFormat>(out var _p3_UnityEngine_Experimental_Rendering_DefaultFormat))
                        {
                            if (_argCount == 5)
                            {
                                var width = _p0_System_Int32;
                                var height = _p1_System_Int32;
                                var depth = _p2_System_Int32;
                                var format = _p3_UnityEngine_Experimental_Rendering_DefaultFormat;
                                var _ret0 = new global::UnityEngine.RenderTexture(width, height, depth, format);
                                var _factory = _context.GetObjectFactory();
                                var _lret0 = _factory.Bind(_ret0);
                                var _retCount = _context.Return(_lret0);
                                return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                            }
                        }
                    }
                    _lastArgPos = 2; _expectedType = typeof(global::UnityEngine.Experimental.Rendering.GraphicsFormat);
                    if (_arg2.TryRead<global::UnityEngine.Experimental.Rendering.GraphicsFormat>(out var _p2_UnityEngine_Experimental_Rendering_GraphicsFormat))
                    {
                        var _arg3 = _lastArg = _argCount > 4 ? _context.GetArgument(4) : global::Lua.LuaValue.Nil;
                        _lastArgPos = 3; _expectedType = typeof(global::UnityEngine.Experimental.Rendering.GraphicsFormat);
                        if (_arg3.TryRead<global::UnityEngine.Experimental.Rendering.GraphicsFormat>(out var _p3_UnityEngine_Experimental_Rendering_GraphicsFormat))
                        {
                            if (_argCount == 5)
                            {
                                var width = _p0_System_Int32;
                                var height = _p1_System_Int32;
                                var colorFormat = _p2_UnityEngine_Experimental_Rendering_GraphicsFormat;
                                var depthStencilFormat = _p3_UnityEngine_Experimental_Rendering_GraphicsFormat;
                                var _ret0 = new global::UnityEngine.RenderTexture(width, height, colorFormat, depthStencilFormat);
                                var _factory = _context.GetObjectFactory();
                                var _lret0 = _factory.Bind(_ret0);
                                var _retCount = _context.Return(_lret0);
                                return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                            }
                            var _arg4 = _lastArg = _argCount > 5 ? _context.GetArgument(5) : global::Lua.LuaValue.Nil;
                            _lastArgPos = 4; _expectedType = typeof(global::System.Int32);
                            if (_arg4.TryRead<global::System.Int32>(out var _p4_System_Int32))
                            {
                                if (_argCount == 6)
                                {
                                    var width = _p0_System_Int32;
                                    var height = _p1_System_Int32;
                                    var colorFormat = _p2_UnityEngine_Experimental_Rendering_GraphicsFormat;
                                    var depthStencilFormat = _p3_UnityEngine_Experimental_Rendering_GraphicsFormat;
                                    var mipCount = _p4_System_Int32;
                                    var _ret0 = new global::UnityEngine.RenderTexture(width, height, colorFormat, depthStencilFormat, mipCount);
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
            throw new global::Lua.LuaRuntimeException(_context.Thread, $"{".ctor"}: invalid argument #{_lastArgPos}: {_lastArg} ({_lastArg.Type}), expected: {_expectedType.FullName}", 2);
        });
        private static readonly global::Lua.LuaFunction _LuaRenderTexture_GetTemporary = new global::Lua.LuaFunction("GetTemporary", (_context, _) =>
        {
            global::Lua.LuaValue _lastArg = default;
            global::System.Int32 _lastArgPos = default;
            global::System.Type _expectedType = default;
            var _argCount = _context.ArgumentCount;
            var _arg0 = _lastArg = _argCount > 0 ? _context.GetArgument(0) : global::Lua.LuaValue.Nil;
            _lastArgPos = 0; _expectedType = typeof(global::Luny.UnityEngine.LuaRenderTextureDescriptor);
            if (_arg0.TryRead<global::Luny.UnityEngine.LuaRenderTextureDescriptor>(out var _p0_UnityEngine_RenderTextureDescriptor))
            {
                if (_argCount == 1)
                {
                    var desc = _p0_UnityEngine_RenderTextureDescriptor.Value;
                    var _ret0 = global::UnityEngine.RenderTexture.GetTemporary(desc);
                    var _factory = _context.GetObjectFactory();
                    var _lret0 = _factory.Bind(_ret0);
                    var _retCount = _context.Return(_lret0);
                    return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                }
            }
            _lastArgPos = 0; _expectedType = typeof(global::System.Int32);
            if (_arg0.TryRead<global::System.Int32>(out var _p0_System_Int32))
            {
                var _arg1 = _lastArg = _argCount > 1 ? _context.GetArgument(1) : global::Lua.LuaValue.Nil;
                _lastArgPos = 1; _expectedType = typeof(global::System.Int32);
                if (_arg1.TryRead<global::System.Int32>(out var _p1_System_Int32))
                {
                    if (_argCount == 2)
                    {
                        var width = _p0_System_Int32;
                        var height = _p1_System_Int32;
                        var _ret0 = global::UnityEngine.RenderTexture.GetTemporary(width, height);
                        var _factory = _context.GetObjectFactory();
                        var _lret0 = _factory.Bind(_ret0);
                        var _retCount = _context.Return(_lret0);
                        return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                    }
                    var _arg2 = _lastArg = _argCount > 2 ? _context.GetArgument(2) : global::Lua.LuaValue.Nil;
                    _lastArgPos = 2; _expectedType = typeof(global::System.Int32);
                    if (_arg2.TryRead<global::System.Int32>(out var _p2_System_Int32))
                    {
                        if (_argCount == 3)
                        {
                            var width = _p0_System_Int32;
                            var height = _p1_System_Int32;
                            var depthBuffer = _p2_System_Int32;
                            var _ret0 = global::UnityEngine.RenderTexture.GetTemporary(width, height, depthBuffer);
                            var _factory = _context.GetObjectFactory();
                            var _lret0 = _factory.Bind(_ret0);
                            var _retCount = _context.Return(_lret0);
                            return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                        }
                        var _arg3 = _lastArg = _argCount > 3 ? _context.GetArgument(3) : global::Lua.LuaValue.Nil;
                        _lastArgPos = 3; _expectedType = typeof(global::UnityEngine.Experimental.Rendering.GraphicsFormat);
                        if (_arg3.TryRead<global::UnityEngine.Experimental.Rendering.GraphicsFormat>(out var _p3_UnityEngine_Experimental_Rendering_GraphicsFormat))
                        {
                            if (_argCount == 4)
                            {
                                var width = _p0_System_Int32;
                                var height = _p1_System_Int32;
                                var depthBuffer = _p2_System_Int32;
                                var format = _p3_UnityEngine_Experimental_Rendering_GraphicsFormat;
                                var _ret0 = global::UnityEngine.RenderTexture.GetTemporary(width, height, depthBuffer, format);
                                var _factory = _context.GetObjectFactory();
                                var _lret0 = _factory.Bind(_ret0);
                                var _retCount = _context.Return(_lret0);
                                return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                            }
                            var _arg4 = _lastArg = _argCount > 4 ? _context.GetArgument(4) : global::Lua.LuaValue.Nil;
                            _lastArgPos = 4; _expectedType = typeof(global::System.Int32);
                            if (_arg4.TryRead<global::System.Int32>(out var _p4_System_Int32))
                            {
                                if (_argCount == 5)
                                {
                                    var width = _p0_System_Int32;
                                    var height = _p1_System_Int32;
                                    var depthBuffer = _p2_System_Int32;
                                    var format = _p3_UnityEngine_Experimental_Rendering_GraphicsFormat;
                                    var antiAliasing = _p4_System_Int32;
                                    var _ret0 = global::UnityEngine.RenderTexture.GetTemporary(width, height, depthBuffer, format, antiAliasing);
                                    var _factory = _context.GetObjectFactory();
                                    var _lret0 = _factory.Bind(_ret0);
                                    var _retCount = _context.Return(_lret0);
                                    return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                                }
                                var _arg5 = _lastArg = _argCount > 5 ? _context.GetArgument(5) : global::Lua.LuaValue.Nil;
                                _lastArgPos = 5; _expectedType = typeof(global::UnityEngine.RenderTextureMemoryless);
                                if (_arg5.TryRead<global::UnityEngine.RenderTextureMemoryless>(out var _p5_UnityEngine_RenderTextureMemoryless))
                                {
                                    if (_argCount == 6)
                                    {
                                        var width = _p0_System_Int32;
                                        var height = _p1_System_Int32;
                                        var depthBuffer = _p2_System_Int32;
                                        var format = _p3_UnityEngine_Experimental_Rendering_GraphicsFormat;
                                        var antiAliasing = _p4_System_Int32;
                                        var memorylessMode = _p5_UnityEngine_RenderTextureMemoryless;
                                        var _ret0 = global::UnityEngine.RenderTexture.GetTemporary(width, height, depthBuffer, format, antiAliasing, memorylessMode);
                                        var _factory = _context.GetObjectFactory();
                                        var _lret0 = _factory.Bind(_ret0);
                                        var _retCount = _context.Return(_lret0);
                                        return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                                    }
                                    var _arg6 = _lastArg = _argCount > 6 ? _context.GetArgument(6) : global::Lua.LuaValue.Nil;
                                    _lastArgPos = 6; _expectedType = typeof(global::UnityEngine.VRTextureUsage);
                                    if (_arg6.TryRead<global::UnityEngine.VRTextureUsage>(out var _p6_UnityEngine_VRTextureUsage))
                                    {
                                        if (_argCount == 7)
                                        {
                                            var width = _p0_System_Int32;
                                            var height = _p1_System_Int32;
                                            var depthBuffer = _p2_System_Int32;
                                            var format = _p3_UnityEngine_Experimental_Rendering_GraphicsFormat;
                                            var antiAliasing = _p4_System_Int32;
                                            var memorylessMode = _p5_UnityEngine_RenderTextureMemoryless;
                                            var vrUsage = _p6_UnityEngine_VRTextureUsage;
                                            var _ret0 = global::UnityEngine.RenderTexture.GetTemporary(width, height, depthBuffer, format, antiAliasing, memorylessMode, vrUsage);
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
                                                var width = _p0_System_Int32;
                                                var height = _p1_System_Int32;
                                                var depthBuffer = _p2_System_Int32;
                                                var format = _p3_UnityEngine_Experimental_Rendering_GraphicsFormat;
                                                var antiAliasing = _p4_System_Int32;
                                                var memorylessMode = _p5_UnityEngine_RenderTextureMemoryless;
                                                var vrUsage = _p6_UnityEngine_VRTextureUsage;
                                                var useDynamicScale = _p7_System_Boolean;
                                                var _ret0 = global::UnityEngine.RenderTexture.GetTemporary(width, height, depthBuffer, format, antiAliasing, memorylessMode, vrUsage, useDynamicScale);
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
                        _lastArgPos = 3; _expectedType = typeof(global::UnityEngine.RenderTextureFormat);
                        if (_arg3.TryRead<global::UnityEngine.RenderTextureFormat>(out var _p3_UnityEngine_RenderTextureFormat))
                        {
                            if (_argCount == 4)
                            {
                                var width = _p0_System_Int32;
                                var height = _p1_System_Int32;
                                var depthBuffer = _p2_System_Int32;
                                var format = _p3_UnityEngine_RenderTextureFormat;
                                var _ret0 = global::UnityEngine.RenderTexture.GetTemporary(width, height, depthBuffer, format);
                                var _factory = _context.GetObjectFactory();
                                var _lret0 = _factory.Bind(_ret0);
                                var _retCount = _context.Return(_lret0);
                                return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                            }
                            var _arg4 = _lastArg = _argCount > 4 ? _context.GetArgument(4) : global::Lua.LuaValue.Nil;
                            _lastArgPos = 4; _expectedType = typeof(global::UnityEngine.RenderTextureReadWrite);
                            if (_arg4.TryRead<global::UnityEngine.RenderTextureReadWrite>(out var _p4_UnityEngine_RenderTextureReadWrite))
                            {
                                if (_argCount == 5)
                                {
                                    var width = _p0_System_Int32;
                                    var height = _p1_System_Int32;
                                    var depthBuffer = _p2_System_Int32;
                                    var format = _p3_UnityEngine_RenderTextureFormat;
                                    var readWrite = _p4_UnityEngine_RenderTextureReadWrite;
                                    var _ret0 = global::UnityEngine.RenderTexture.GetTemporary(width, height, depthBuffer, format, readWrite);
                                    var _factory = _context.GetObjectFactory();
                                    var _lret0 = _factory.Bind(_ret0);
                                    var _retCount = _context.Return(_lret0);
                                    return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                                }
                                var _arg5 = _lastArg = _argCount > 5 ? _context.GetArgument(5) : global::Lua.LuaValue.Nil;
                                _lastArgPos = 5; _expectedType = typeof(global::System.Int32);
                                if (_arg5.TryRead<global::System.Int32>(out var _p5_System_Int32))
                                {
                                    if (_argCount == 6)
                                    {
                                        var width = _p0_System_Int32;
                                        var height = _p1_System_Int32;
                                        var depthBuffer = _p2_System_Int32;
                                        var format = _p3_UnityEngine_RenderTextureFormat;
                                        var readWrite = _p4_UnityEngine_RenderTextureReadWrite;
                                        var antiAliasing = _p5_System_Int32;
                                        var _ret0 = global::UnityEngine.RenderTexture.GetTemporary(width, height, depthBuffer, format, readWrite, antiAliasing);
                                        var _factory = _context.GetObjectFactory();
                                        var _lret0 = _factory.Bind(_ret0);
                                        var _retCount = _context.Return(_lret0);
                                        return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                                    }
                                    var _arg6 = _lastArg = _argCount > 6 ? _context.GetArgument(6) : global::Lua.LuaValue.Nil;
                                    _lastArgPos = 6; _expectedType = typeof(global::UnityEngine.RenderTextureMemoryless);
                                    if (_arg6.TryRead<global::UnityEngine.RenderTextureMemoryless>(out var _p6_UnityEngine_RenderTextureMemoryless))
                                    {
                                        if (_argCount == 7)
                                        {
                                            var width = _p0_System_Int32;
                                            var height = _p1_System_Int32;
                                            var depthBuffer = _p2_System_Int32;
                                            var format = _p3_UnityEngine_RenderTextureFormat;
                                            var readWrite = _p4_UnityEngine_RenderTextureReadWrite;
                                            var antiAliasing = _p5_System_Int32;
                                            var memorylessMode = _p6_UnityEngine_RenderTextureMemoryless;
                                            var _ret0 = global::UnityEngine.RenderTexture.GetTemporary(width, height, depthBuffer, format, readWrite, antiAliasing, memorylessMode);
                                            var _factory = _context.GetObjectFactory();
                                            var _lret0 = _factory.Bind(_ret0);
                                            var _retCount = _context.Return(_lret0);
                                            return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                                        }
                                        var _arg7 = _lastArg = _argCount > 7 ? _context.GetArgument(7) : global::Lua.LuaValue.Nil;
                                        _lastArgPos = 7; _expectedType = typeof(global::UnityEngine.VRTextureUsage);
                                        if (_arg7.TryRead<global::UnityEngine.VRTextureUsage>(out var _p7_UnityEngine_VRTextureUsage))
                                        {
                                            if (_argCount == 8)
                                            {
                                                var width = _p0_System_Int32;
                                                var height = _p1_System_Int32;
                                                var depthBuffer = _p2_System_Int32;
                                                var format = _p3_UnityEngine_RenderTextureFormat;
                                                var readWrite = _p4_UnityEngine_RenderTextureReadWrite;
                                                var antiAliasing = _p5_System_Int32;
                                                var memorylessMode = _p6_UnityEngine_RenderTextureMemoryless;
                                                var vrUsage = _p7_UnityEngine_VRTextureUsage;
                                                var _ret0 = global::UnityEngine.RenderTexture.GetTemporary(width, height, depthBuffer, format, readWrite, antiAliasing, memorylessMode, vrUsage);
                                                var _factory = _context.GetObjectFactory();
                                                var _lret0 = _factory.Bind(_ret0);
                                                var _retCount = _context.Return(_lret0);
                                                return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                                            }
                                            var _arg8 = _lastArg = _argCount > 8 ? _context.GetArgument(8) : global::Lua.LuaValue.Nil;
                                            _lastArgPos = 8; _expectedType = typeof(global::System.Boolean);
                                            if (_arg8.TryRead<global::System.Boolean>(out var _p8_System_Boolean))
                                            {
                                                if (_argCount == 9)
                                                {
                                                    var width = _p0_System_Int32;
                                                    var height = _p1_System_Int32;
                                                    var depthBuffer = _p2_System_Int32;
                                                    var format = _p3_UnityEngine_RenderTextureFormat;
                                                    var readWrite = _p4_UnityEngine_RenderTextureReadWrite;
                                                    var antiAliasing = _p5_System_Int32;
                                                    var memorylessMode = _p6_UnityEngine_RenderTextureMemoryless;
                                                    var vrUsage = _p7_UnityEngine_VRTextureUsage;
                                                    var useDynamicScale = _p8_System_Boolean;
                                                    var _ret0 = global::UnityEngine.RenderTexture.GetTemporary(width, height, depthBuffer, format, readWrite, antiAliasing, memorylessMode, vrUsage, useDynamicScale);
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
            throw new global::Lua.LuaRuntimeException(_context.Thread, $"{"GetTemporary"}: invalid argument #{_lastArgPos}: {_lastArg} ({_lastArg.Type}), expected: {_expectedType.FullName}", 2);
        });
        private static readonly global::Lua.LuaFunction _LuaRenderTexture_ReleaseTemporary = new global::Lua.LuaFunction("ReleaseTemporary", (_context, _) =>
        {
            global::Lua.LuaValue _lastArg = default;
            global::System.Int32 _lastArgPos = default;
            global::System.Type _expectedType = default;
            var _argCount = _context.ArgumentCount;
            var _arg0 = _lastArg = _argCount > 0 ? _context.GetArgument(0) : global::Lua.LuaValue.Nil;
            _lastArgPos = 0; _expectedType = typeof(global::Luny.UnityEngine.LuaRenderTexture);
            if (_arg0.TryRead<global::Luny.UnityEngine.LuaRenderTexture>(out var _p0_UnityEngine_RenderTexture))
            {
                if (_argCount == 1)
                {
                    var temp = _p0_UnityEngine_RenderTexture.Instance;
                    global::UnityEngine.RenderTexture.ReleaseTemporary(temp);
                    var _retCount = _context.Return();
                    return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                }
            }
            throw new global::Lua.LuaRuntimeException(_context.Thread, $"{"ReleaseTemporary"}: invalid argument #{_lastArgPos}: {_lastArg} ({_lastArg.Type}), expected: {_expectedType.FullName}", 2);
        });
        private static readonly global::Lua.LuaFunction _LuaRenderTexture_SupportsStencil = new global::Lua.LuaFunction("SupportsStencil", (_context, _) =>
        {
            global::Lua.LuaValue _lastArg = default;
            global::System.Int32 _lastArgPos = default;
            global::System.Type _expectedType = default;
            var _argCount = _context.ArgumentCount;
            var _arg0 = _lastArg = _argCount > 0 ? _context.GetArgument(0) : global::Lua.LuaValue.Nil;
            _lastArgPos = 0; _expectedType = typeof(global::Luny.UnityEngine.LuaRenderTexture);
            if (_arg0.TryRead<global::Luny.UnityEngine.LuaRenderTexture>(out var _p0_UnityEngine_RenderTexture))
            {
                if (_argCount == 1)
                {
                    var rt = _p0_UnityEngine_RenderTexture.Instance;
                    var _ret0 = global::UnityEngine.RenderTexture.SupportsStencil(rt);
                    var _lret0 = new global::Lua.LuaValue(_ret0);
                    var _retCount = _context.Return(_lret0);
                    return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                }
            }
            throw new global::Lua.LuaRuntimeException(_context.Thread, $"{"SupportsStencil"}: invalid argument #{_lastArgPos}: {_lastArg} ({_lastArg.Type}), expected: {_expectedType.FullName}", 2);
        });
        private static readonly global::Lua.LuaFunction __index = new(global::Lua.Runtime.Metamethods.Index, (_context, _) =>
        {
            var _this = _context.GetArgument<LuaRenderTextureType>(0);
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
            var _this = _context.GetArgument<LuaRenderTextureType>(0);
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
                case "GetTemporary": _value = _LuaRenderTexture_GetTemporary; return true;
                case "ReleaseTemporary": _value = _LuaRenderTexture_ReleaseTemporary; return true;
                case "SupportsStencil": _value = _LuaRenderTexture_SupportsStencil; return true;
                case "active": _value = _factory.Bind(global::UnityEngine.RenderTexture.active); return true;
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
                case "active": global::UnityEngine.RenderTexture.active = _value.Read<global::Luny.UnityEngine.LuaRenderTexture>().Instance;  return true;
                default: return false;
            }
        }
    }
}
#pragma warning restore 0109, 0162, 0168, 0219
#endif
