
// --------------------------------------------------------------
// GENERATED FILE ----> DO NOT EDIT <---- CHANGES WILL BE LOST !!
// --------------------------------------------------------------

#if UNITY_6000_1_OR_NEWER && !(UNITY_6000_2_OR_NEWER)
#pragma warning disable 0109, 0162, 0168, 0219
using Luny;

namespace Luny.UnityEngine.Rendering
{
    public sealed class LuaAttachmentDescriptor : global::Luny.ILuaValueType<global::UnityEngine.Rendering.AttachmentDescriptor>
    {
        public new static global::Lua.LuaValue Bind(in global::UnityEngine.Rendering.AttachmentDescriptor instance) => new LuaAttachmentDescriptor(instance);
        public new static global::Lua.LuaValue Bind(global::System.Object instance) => Bind((global::UnityEngine.Rendering.AttachmentDescriptor)instance);
        public new static global::Lua.LuaValue Bind(global::System.Collections.Generic.IList<global::UnityEngine.Rendering.AttachmentDescriptor> instances) =>
            new global::Luny.LuaList<global::UnityEngine.Rendering.AttachmentDescriptor>(instances);
        public new static global::Lua.LuaValue Bind(global::System.Collections.Generic.IList<global::System.Object> instances) =>
            new global::Luny.LuaList<global::UnityEngine.Rendering.AttachmentDescriptor>(instances);
        private LuaAttachmentDescriptor(in global::UnityEngine.Rendering.AttachmentDescriptor value) => m_Value = value;
        public static implicit operator global::Lua.LuaValue(LuaAttachmentDescriptor value) => new(value);
        private global::UnityEngine.Rendering.AttachmentDescriptor m_Value;
        public global::UnityEngine.Rendering.AttachmentDescriptor Value { get => m_Value; set => m_Value = value; }
        public ref global::UnityEngine.Rendering.AttachmentDescriptor ValueRef => ref m_Value;
        public global::System.Type BindType => typeof(global::UnityEngine.Rendering.AttachmentDescriptor);
        private static global::Lua.LuaTable s_Metatable;
        public global::Lua.LuaTable Metatable
        {
            get => s_Metatable ??= global::Luny.LuaMetatable.Create(__index, __newindex);
            set => throw new global::System.NotSupportedException("LuaObject metatables cannot be modified");
        }
        global::System.Span<global::Lua.LuaValue> global::Lua.ILuaUserData.UserValues => default;
        public override global::System.String ToString() => m_Value.ToString();
#if UNITY_EDITOR
        [global::UnityEngine.RuntimeInitializeOnLoadMethod(global::UnityEngine.RuntimeInitializeLoadType.SubsystemRegistration)]
        private static void ResetStaticFields() => s_Metatable = null;
#endif

        private static readonly global::Lua.LuaFunction _LuaAttachmentDescriptor_ConfigureClear = new global::Lua.LuaFunction("ConfigureClear", (_context, _) =>
        {
            global::Lua.LuaValue _lastArg = default;
            global::System.Int32 _lastArgPos = default;
            global::System.Type _expectedType = default;
            var _argCount = _context.ArgumentCount;
            var _this = _context.GetArgument<LuaAttachmentDescriptor>(0);
            var _arg0 = _lastArg = _argCount > 1 ? _context.GetArgument(1) : global::Lua.LuaValue.Nil;
            _lastArgPos = 0; _expectedType = typeof(global::Luny.UnityEngine.LuaColor);
            if (_arg0.TryRead<global::Luny.UnityEngine.LuaColor>(out var _p0_UnityEngine_Color))
            {
                if (_argCount == 2)
                {
                    var clearColor = _p0_UnityEngine_Color.Value;
                    _this.m_Value.ConfigureClear(clearColor);
                    var _retCount = _context.Return();
                    return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                }
                var _arg1 = _lastArg = _argCount > 2 ? _context.GetArgument(2) : global::Lua.LuaValue.Nil;
                _lastArgPos = 1; _expectedType = typeof(global::System.Single);
                var _p1_System_Single = _arg1.ReadValue<global::System.Single>((global::System.Single)(1));
                {
                    if (_argCount == 3)
                    {
                        var clearColor = _p0_UnityEngine_Color.Value;
                        var clearDepth = _p1_System_Single;
                        _this.m_Value.ConfigureClear(clearColor, clearDepth);
                        var _retCount = _context.Return();
                        return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                    }
                    var _arg2 = _lastArg = _argCount > 3 ? _context.GetArgument(3) : global::Lua.LuaValue.Nil;
                    _lastArgPos = 2; _expectedType = typeof(global::System.UInt32);
                    var _p2_System_UInt32 = _arg2.ReadValue<global::System.UInt32>((global::System.UInt32)(0));
                    {
                        if (_argCount == 4)
                        {
                            var clearColor = _p0_UnityEngine_Color.Value;
                            var clearDepth = _p1_System_Single;
                            var clearStencil = _p2_System_UInt32;
                            _this.m_Value.ConfigureClear(clearColor, clearDepth, clearStencil);
                            var _retCount = _context.Return();
                            return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                        }
                    }
                }
            }
            throw new global::Lua.LuaRuntimeException(_context.Thread, $"{"ConfigureClear"}: invalid argument #{_lastArgPos}: {_lastArg} ({_lastArg.Type}), expected: {_expectedType.FullName}", 2);
        });
        private static readonly global::Lua.LuaFunction _LuaAttachmentDescriptor_ConfigureResolveTarget = new global::Lua.LuaFunction("ConfigureResolveTarget", (_context, _) =>
        {
            global::Lua.LuaValue _lastArg = default;
            global::System.Int32 _lastArgPos = default;
            global::System.Type _expectedType = default;
            var _argCount = _context.ArgumentCount;
            var _this = _context.GetArgument<LuaAttachmentDescriptor>(0);
            var _arg0 = _lastArg = _argCount > 1 ? _context.GetArgument(1) : global::Lua.LuaValue.Nil;
            _lastArgPos = 0; _expectedType = typeof(global::Luny.UnityEngine.Rendering.LuaRenderTargetIdentifier);
            if (_arg0.TryRead<global::Luny.UnityEngine.Rendering.LuaRenderTargetIdentifier>(out var _p0_UnityEngine_Rendering_RenderTargetIdentifier))
            {
                if (_argCount == 2)
                {
                    var target = _p0_UnityEngine_Rendering_RenderTargetIdentifier.Value;
                    _this.m_Value.ConfigureResolveTarget(target);
                    var _retCount = _context.Return();
                    return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                }
            }
            throw new global::Lua.LuaRuntimeException(_context.Thread, $"{"ConfigureResolveTarget"}: invalid argument #{_lastArgPos}: {_lastArg} ({_lastArg.Type}), expected: {_expectedType.FullName}", 2);
        });
        private static readonly global::Lua.LuaFunction _LuaAttachmentDescriptor_ConfigureTarget = new global::Lua.LuaFunction("ConfigureTarget", (_context, _) =>
        {
            global::Lua.LuaValue _lastArg = default;
            global::System.Int32 _lastArgPos = default;
            global::System.Type _expectedType = default;
            var _argCount = _context.ArgumentCount;
            var _this = _context.GetArgument<LuaAttachmentDescriptor>(0);
            var _arg0 = _lastArg = _argCount > 1 ? _context.GetArgument(1) : global::Lua.LuaValue.Nil;
            _lastArgPos = 0; _expectedType = typeof(global::Luny.UnityEngine.Rendering.LuaRenderTargetIdentifier);
            if (_arg0.TryRead<global::Luny.UnityEngine.Rendering.LuaRenderTargetIdentifier>(out var _p0_UnityEngine_Rendering_RenderTargetIdentifier))
            {
                var _arg1 = _lastArg = _argCount > 2 ? _context.GetArgument(2) : global::Lua.LuaValue.Nil;
                _lastArgPos = 1; _expectedType = typeof(global::System.Boolean);
                if (_arg1.TryRead<global::System.Boolean>(out var _p1_System_Boolean))
                {
                    var _arg2 = _lastArg = _argCount > 3 ? _context.GetArgument(3) : global::Lua.LuaValue.Nil;
                    _lastArgPos = 2; _expectedType = typeof(global::System.Boolean);
                    if (_arg2.TryRead<global::System.Boolean>(out var _p2_System_Boolean))
                    {
                        if (_argCount == 4)
                        {
                            var target = _p0_UnityEngine_Rendering_RenderTargetIdentifier.Value;
                            var loadExistingContents = _p1_System_Boolean;
                            var storeResults = _p2_System_Boolean;
                            _this.m_Value.ConfigureTarget(target, loadExistingContents, storeResults);
                            var _retCount = _context.Return();
                            return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                        }
                    }
                }
            }
            throw new global::Lua.LuaRuntimeException(_context.Thread, $"{"ConfigureTarget"}: invalid argument #{_lastArgPos}: {_lastArg} ({_lastArg.Type}), expected: {_expectedType.FullName}", 2);
        });
        private static readonly global::Lua.LuaFunction _LuaAttachmentDescriptor_Equals = new global::Lua.LuaFunction("Equals", (_context, _) =>
        {
            global::Lua.LuaValue _lastArg = default;
            global::System.Int32 _lastArgPos = default;
            global::System.Type _expectedType = default;
            var _argCount = _context.ArgumentCount;
            var _this = _context.GetArgument<LuaAttachmentDescriptor>(0);
            var _arg0 = _lastArg = _argCount > 1 ? _context.GetArgument(1) : global::Lua.LuaValue.Nil;
            _lastArgPos = 0; _expectedType = typeof(global::Luny.UnityEngine.Rendering.LuaAttachmentDescriptor);
            if (_arg0.TryRead<global::Luny.UnityEngine.Rendering.LuaAttachmentDescriptor>(out var _p0_UnityEngine_Rendering_AttachmentDescriptor))
            {
                if (_argCount == 2)
                {
                    var other = _p0_UnityEngine_Rendering_AttachmentDescriptor.Value;
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
        private static readonly global::Lua.LuaFunction _LuaAttachmentDescriptor_GetHashCode = new global::Lua.LuaFunction("GetHashCode", (_context, _) =>
        {
            global::Lua.LuaValue _lastArg = default;
            global::System.Int32 _lastArgPos = default;
            global::System.Type _expectedType = default;
            var _argCount = _context.ArgumentCount;
            var _this = _context.GetArgument<LuaAttachmentDescriptor>(0);
            if (_argCount == 1)
            {
                var _ret0 = _this.m_Value.GetHashCode();
                var _lret0 = new global::Lua.LuaValue(_ret0);
                var _retCount = _context.Return(_lret0);
                return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
            }
            throw new global::Lua.LuaRuntimeException(_context.Thread, $"{"GetHashCode"}: invalid argument #{_lastArgPos}: {_lastArg} ({_lastArg.Type}), expected: {_expectedType.FullName}", 2);
        });
        private static readonly global::Lua.LuaFunction __index = new(global::Lua.Runtime.Metamethods.Index, (_context, _) =>
        {
            var _this = _context.GetArgument<LuaAttachmentDescriptor>(0);
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
            var _this = _context.GetArgument<LuaAttachmentDescriptor>(0);
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
                case "ConfigureClear": _value = _LuaAttachmentDescriptor_ConfigureClear; return true;
                case "ConfigureResolveTarget": _value = _LuaAttachmentDescriptor_ConfigureResolveTarget; return true;
                case "ConfigureTarget": _value = _LuaAttachmentDescriptor_ConfigureTarget; return true;
                case "Equals": _value = _LuaAttachmentDescriptor_Equals; return true;
                case "GetHashCode": _value = _LuaAttachmentDescriptor_GetHashCode; return true;
                case "clearColor": _value = global::Luny.UnityEngine.LuaColor.Bind(m_Value.clearColor); return true;
                case "clearDepth": _value = new global::Lua.LuaValue(m_Value.clearDepth); return true;
                case "clearStencil": _value = new global::Lua.LuaValue(m_Value.clearStencil); return true;
                case "format": _value = new global::Lua.LuaValue((global::System.Int64)m_Value.format); return true;
                case "graphicsFormat": _value = new global::Lua.LuaValue((global::System.Int64)m_Value.graphicsFormat); return true;
                case "loadAction": _value = new global::Lua.LuaValue((global::System.Int64)m_Value.loadAction); return true;
                case "loadStoreTarget": _value = global::Luny.UnityEngine.Rendering.LuaRenderTargetIdentifier.Bind(m_Value.loadStoreTarget); return true;
                case "resolveTarget": _value = global::Luny.UnityEngine.Rendering.LuaRenderTargetIdentifier.Bind(m_Value.resolveTarget); return true;
                case "storeAction": _value = new global::Lua.LuaValue((global::System.Int64)m_Value.storeAction); return true;
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
                case "clearColor": { var _temp = m_Value; _temp.clearColor = _value.Read<global::Luny.UnityEngine.LuaColor>().Value; m_Value = _temp; } return true;
                case "clearDepth": { var _temp = m_Value; _temp.clearDepth = _value.Read<global::System.Single>(); m_Value = _temp; } return true;
                case "clearStencil": { var _temp = m_Value; _temp.clearStencil = _value.Read<global::System.UInt32>(); m_Value = _temp; } return true;
                case "format": { var _temp = m_Value; _temp.format = _value.Read<global::UnityEngine.RenderTextureFormat>(); m_Value = _temp; } return true;
                case "graphicsFormat": { var _temp = m_Value; _temp.graphicsFormat = _value.Read<global::UnityEngine.Experimental.Rendering.GraphicsFormat>(); m_Value = _temp; } return true;
                case "loadAction": { var _temp = m_Value; _temp.loadAction = _value.Read<global::UnityEngine.Rendering.RenderBufferLoadAction>(); m_Value = _temp; } return true;
                case "loadStoreTarget": { var _temp = m_Value; _temp.loadStoreTarget = _value.Read<global::Luny.UnityEngine.Rendering.LuaRenderTargetIdentifier>().Value; m_Value = _temp; } return true;
                case "resolveTarget": { var _temp = m_Value; _temp.resolveTarget = _value.Read<global::Luny.UnityEngine.Rendering.LuaRenderTargetIdentifier>().Value; m_Value = _temp; } return true;
                case "storeAction": { var _temp = m_Value; _temp.storeAction = _value.Read<global::UnityEngine.Rendering.RenderBufferStoreAction>(); m_Value = _temp; } return true;
                default: return false;
            }
        }
    }
    public sealed class LuaAttachmentDescriptorType : global::Luny.ILuaStatic
    {
        public static global::Lua.LuaValue Bind() => new LuaAttachmentDescriptorType();
        private LuaAttachmentDescriptorType() {}
        public static implicit operator global::Lua.LuaValue(LuaAttachmentDescriptorType value) => new(value);
        public global::System.Type BindType => typeof(global::UnityEngine.Rendering.AttachmentDescriptor);
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

        private static readonly global::Lua.LuaFunction _LuaAttachmentDescriptor_new = new global::Lua.LuaFunction(".ctor", (_context, _) =>
        {
            global::Lua.LuaValue _lastArg = default;
            global::System.Int32 _lastArgPos = default;
            global::System.Type _expectedType = default;
            var _argCount = _context.ArgumentCount;
            if (_argCount == 0)
            {
                var _ret0 = new global::UnityEngine.Rendering.AttachmentDescriptor();
                var _lret0 = global::Luny.UnityEngine.Rendering.LuaAttachmentDescriptor.Bind(_ret0);
                var _retCount = _context.Return(_lret0);
                return new global::System.Threading.Tasks.ValueTask<global::System.Int32>(_retCount);
            }
            var _arg0 = _lastArg = _argCount > 0 ? _context.GetArgument(0) : global::Lua.LuaValue.Nil;
            _lastArgPos = 0; _expectedType = typeof(global::UnityEngine.Experimental.Rendering.GraphicsFormat);
            if (_arg0.TryRead<global::UnityEngine.Experimental.Rendering.GraphicsFormat>(out var _p0_UnityEngine_Experimental_Rendering_GraphicsFormat))
            {
                if (_argCount == 1)
                {
                    var format = _p0_UnityEngine_Experimental_Rendering_GraphicsFormat;
                    var _ret0 = new global::UnityEngine.Rendering.AttachmentDescriptor(format);
                    var _lret0 = global::Luny.UnityEngine.Rendering.LuaAttachmentDescriptor.Bind(_ret0);
                    var _retCount = _context.Return(_lret0);
                    return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                }
            }
            _lastArgPos = 0; _expectedType = typeof(global::UnityEngine.RenderTextureFormat);
            if (_arg0.TryRead<global::UnityEngine.RenderTextureFormat>(out var _p0_UnityEngine_RenderTextureFormat))
            {
                if (_argCount == 1)
                {
                    var format = _p0_UnityEngine_RenderTextureFormat;
                    var _ret0 = new global::UnityEngine.Rendering.AttachmentDescriptor(format);
                    var _lret0 = global::Luny.UnityEngine.Rendering.LuaAttachmentDescriptor.Bind(_ret0);
                    var _retCount = _context.Return(_lret0);
                    return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                }
                var _arg1 = _lastArg = _argCount > 1 ? _context.GetArgument(1) : global::Lua.LuaValue.Nil;
                _lastArgPos = 1; _expectedType = typeof(global::Luny.UnityEngine.Rendering.LuaRenderTargetIdentifier);
                if (_arg1.TryRead<global::Luny.UnityEngine.Rendering.LuaRenderTargetIdentifier>(out var _p1_UnityEngine_Rendering_RenderTargetIdentifier))
                {
                    if (_argCount == 2)
                    {
                        var format = _p0_UnityEngine_RenderTextureFormat;
                        var target = _p1_UnityEngine_Rendering_RenderTargetIdentifier.Value;
                        var _ret0 = new global::UnityEngine.Rendering.AttachmentDescriptor(format, target);
                        var _lret0 = global::Luny.UnityEngine.Rendering.LuaAttachmentDescriptor.Bind(_ret0);
                        var _retCount = _context.Return(_lret0);
                        return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                    }
                    var _arg2 = _lastArg = _argCount > 2 ? _context.GetArgument(2) : global::Lua.LuaValue.Nil;
                    _lastArgPos = 2; _expectedType = typeof(global::System.Boolean);
                    var _p2_System_Boolean = _arg2.ReadValue<global::System.Boolean>((global::System.Boolean)false);
                    {
                        if (_argCount == 3)
                        {
                            var format = _p0_UnityEngine_RenderTextureFormat;
                            var target = _p1_UnityEngine_Rendering_RenderTargetIdentifier.Value;
                            var loadExistingContents = _p2_System_Boolean;
                            var _ret0 = new global::UnityEngine.Rendering.AttachmentDescriptor(format, target, loadExistingContents);
                            var _lret0 = global::Luny.UnityEngine.Rendering.LuaAttachmentDescriptor.Bind(_ret0);
                            var _retCount = _context.Return(_lret0);
                            return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                        }
                        var _arg3 = _lastArg = _argCount > 3 ? _context.GetArgument(3) : global::Lua.LuaValue.Nil;
                        _lastArgPos = 3; _expectedType = typeof(global::System.Boolean);
                        var _p3_System_Boolean = _arg3.ReadValue<global::System.Boolean>((global::System.Boolean)false);
                        {
                            if (_argCount == 4)
                            {
                                var format = _p0_UnityEngine_RenderTextureFormat;
                                var target = _p1_UnityEngine_Rendering_RenderTargetIdentifier.Value;
                                var loadExistingContents = _p2_System_Boolean;
                                var storeResults = _p3_System_Boolean;
                                var _ret0 = new global::UnityEngine.Rendering.AttachmentDescriptor(format, target, loadExistingContents, storeResults);
                                var _lret0 = global::Luny.UnityEngine.Rendering.LuaAttachmentDescriptor.Bind(_ret0);
                                var _retCount = _context.Return(_lret0);
                                return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                            }
                            var _arg4 = _lastArg = _argCount > 4 ? _context.GetArgument(4) : global::Lua.LuaValue.Nil;
                            _lastArgPos = 4; _expectedType = typeof(global::System.Boolean);
                            var _p4_System_Boolean = _arg4.ReadValue<global::System.Boolean>((global::System.Boolean)false);
                            {
                                if (_argCount == 5)
                                {
                                    var format = _p0_UnityEngine_RenderTextureFormat;
                                    var target = _p1_UnityEngine_Rendering_RenderTargetIdentifier.Value;
                                    var loadExistingContents = _p2_System_Boolean;
                                    var storeResults = _p3_System_Boolean;
                                    var resolve = _p4_System_Boolean;
                                    var _ret0 = new global::UnityEngine.Rendering.AttachmentDescriptor(format, target, loadExistingContents, storeResults, resolve);
                                    var _lret0 = global::Luny.UnityEngine.Rendering.LuaAttachmentDescriptor.Bind(_ret0);
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
        private static readonly global::Lua.LuaFunction __index = new(global::Lua.Runtime.Metamethods.Index, (_context, _) =>
        {
            var _this = _context.GetArgument<LuaAttachmentDescriptorType>(0);
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
            var _this = _context.GetArgument<LuaAttachmentDescriptorType>(0);
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
                case "new": _value = _LuaAttachmentDescriptor_new; return true;
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
