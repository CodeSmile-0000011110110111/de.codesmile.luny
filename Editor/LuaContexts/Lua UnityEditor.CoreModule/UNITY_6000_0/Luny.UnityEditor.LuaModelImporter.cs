
// --------------------------------------------------------------
// GENERATED FILE ----> DO NOT EDIT <---- CHANGES WILL BE LOST !!
// --------------------------------------------------------------

#if UNITY_6000_0_OR_NEWER && !(UNITY_6000_1_OR_NEWER)
#pragma warning disable 0109, 0162, 0168, 0219
using Luny;

namespace Luny.UnityEditor
{
    public sealed class LuaModelImporter : LuaAssetImporter, global::Luny.ILuaObject<global::UnityEditor.ModelImporter>
    {
        public new static global::Lua.LuaValue Bind(global::UnityEditor.ModelImporter instance) => new LuaModelImporter(instance);
        public new static global::Lua.LuaValue Bind(global::System.Object instance) => Bind((global::UnityEditor.ModelImporter)instance);
        public new static global::Lua.LuaValue Bind(global::System.Collections.Generic.IList<global::UnityEditor.ModelImporter> instances) =>
            new global::Luny.LuaList<global::UnityEditor.ModelImporter>(instances);
        public new static global::Lua.LuaValue Bind(global::System.Collections.Generic.IList<global::System.Object> instances) =>
            new global::Luny.LuaList<global::UnityEditor.ModelImporter>(instances);
        private LuaModelImporter(global::UnityEditor.ModelImporter instance) : base(instance) {}
        public static implicit operator global::Lua.LuaValue(LuaModelImporter value) => new(value);
        public new global::UnityEditor.ModelImporter Instance => (global::UnityEditor.ModelImporter)m_Instance;
        public new global::System.Type BindType => typeof(global::UnityEditor.ModelImporter);
        private static global::Lua.LuaTable s_Metatable;
        public new global::Lua.LuaTable Metatable
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

        private static readonly global::Lua.LuaFunction _LuaModelImporter_CreateDefaultMaskForClip = new global::Lua.LuaFunction("CreateDefaultMaskForClip", (_context, _) =>
        {
            global::Lua.LuaValue _lastArg = default;
            global::System.Int32 _lastArgPos = default;
            global::System.Type _expectedType = default;
            var _argCount = _context.ArgumentCount;
            var _this = _context.GetArgument<LuaModelImporter>(0);
            var _arg0 = _lastArg = _argCount > 1 ? _context.GetArgument(1) : global::Lua.LuaValue.Nil;
            _lastArgPos = 0; _expectedType = typeof(global::Luny.UnityEditor.LuaModelImporterClipAnimation);
            if (_arg0.TryRead<global::Luny.UnityEditor.LuaModelImporterClipAnimation>(out var _p0_UnityEditor_ModelImporterClipAnimation))
            {
                if (_argCount == 2)
                {
                    var clip = _p0_UnityEditor_ModelImporterClipAnimation.Instance;
                    _this.Instance.CreateDefaultMaskForClip(clip);
                    var _retCount = _context.Return();
                    return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                }
            }
            throw new global::Lua.LuaRuntimeException(_context.Thread, $"{"CreateDefaultMaskForClip"}: invalid argument #{_lastArgPos}: {_lastArg} ({_lastArg.Type}), expected: {_expectedType.FullName}", 2);
        });
        private static readonly global::Lua.LuaFunction _LuaModelImporter_ExtractTextures = new global::Lua.LuaFunction("ExtractTextures", (_context, _) =>
        {
            global::Lua.LuaValue _lastArg = default;
            global::System.Int32 _lastArgPos = default;
            global::System.Type _expectedType = default;
            var _argCount = _context.ArgumentCount;
            var _this = _context.GetArgument<LuaModelImporter>(0);
            var _arg0 = _lastArg = _argCount > 1 ? _context.GetArgument(1) : global::Lua.LuaValue.Nil;
            _lastArgPos = 0; _expectedType = typeof(global::System.String);
            if (_arg0.TryRead<global::System.String>(out var _p0_System_String))
            {
                if (_argCount == 2)
                {
                    var folderPath = _p0_System_String;
                    var _ret0 = _this.Instance.ExtractTextures(folderPath);
                    var _lret0 = new global::Lua.LuaValue(_ret0);
                    var _retCount = _context.Return(_lret0);
                    return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                }
            }
            throw new global::Lua.LuaRuntimeException(_context.Thread, $"{"ExtractTextures"}: invalid argument #{_lastArgPos}: {_lastArg} ({_lastArg.Type}), expected: {_expectedType.FullName}", 2);
        });
        private static readonly global::Lua.LuaFunction _LuaModelImporter_SearchAndRemapMaterials = new global::Lua.LuaFunction("SearchAndRemapMaterials", (_context, _) =>
        {
            global::Lua.LuaValue _lastArg = default;
            global::System.Int32 _lastArgPos = default;
            global::System.Type _expectedType = default;
            var _argCount = _context.ArgumentCount;
            var _this = _context.GetArgument<LuaModelImporter>(0);
            var _arg0 = _lastArg = _argCount > 1 ? _context.GetArgument(1) : global::Lua.LuaValue.Nil;
            _lastArgPos = 0; _expectedType = typeof(global::UnityEditor.ModelImporterMaterialName);
            if (_arg0.TryRead<global::UnityEditor.ModelImporterMaterialName>(out var _p0_UnityEditor_ModelImporterMaterialName))
            {
                var _arg1 = _lastArg = _argCount > 2 ? _context.GetArgument(2) : global::Lua.LuaValue.Nil;
                _lastArgPos = 1; _expectedType = typeof(global::UnityEditor.ModelImporterMaterialSearch);
                if (_arg1.TryRead<global::UnityEditor.ModelImporterMaterialSearch>(out var _p1_UnityEditor_ModelImporterMaterialSearch))
                {
                    if (_argCount == 3)
                    {
                        var nameOption = _p0_UnityEditor_ModelImporterMaterialName;
                        var searchOption = _p1_UnityEditor_ModelImporterMaterialSearch;
                        var _ret0 = _this.Instance.SearchAndRemapMaterials(nameOption, searchOption);
                        var _lret0 = new global::Lua.LuaValue(_ret0);
                        var _retCount = _context.Return(_lret0);
                        return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                    }
                }
            }
            throw new global::Lua.LuaRuntimeException(_context.Thread, $"{"SearchAndRemapMaterials"}: invalid argument #{_lastArgPos}: {_lastArg} ({_lastArg.Type}), expected: {_expectedType.FullName}", 2);
        });
        private static readonly global::Lua.LuaFunction __index = new(global::Lua.Runtime.Metamethods.Index, (_context, _) =>
        {
            var _this = _context.GetArgument<LuaModelImporter>(0);
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
            var _this = _context.GetArgument<LuaModelImporter>(0);
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
                case "CreateDefaultMaskForClip": _value = _LuaModelImporter_CreateDefaultMaskForClip; return true;
                case "ExtractTextures": _value = _LuaModelImporter_ExtractTextures; return true;
                case "SearchAndRemapMaterials": _value = _LuaModelImporter_SearchAndRemapMaterials; return true;
                case "addCollider": _value = new global::Lua.LuaValue(Instance.addCollider); return true;
                case "animationCompression": _value = new global::Lua.LuaValue((global::System.Int64)Instance.animationCompression); return true;
                case "animationPositionError": _value = new global::Lua.LuaValue(Instance.animationPositionError); return true;
                case "animationRotationError": _value = new global::Lua.LuaValue(Instance.animationRotationError); return true;
                case "animationScaleError": _value = new global::Lua.LuaValue(Instance.animationScaleError); return true;
                case "animationType": _value = new global::Lua.LuaValue((global::System.Int64)Instance.animationType); return true;
                case "animationWrapMode": _value = new global::Lua.LuaValue((global::System.Int64)Instance.animationWrapMode); return true;
                case "autoGenerateAvatarMappingIfUnspecified": _value = new global::Lua.LuaValue(Instance.autoGenerateAvatarMappingIfUnspecified); return true;
                case "avatarSetup": _value = new global::Lua.LuaValue((global::System.Int64)Instance.avatarSetup); return true;
                case "bakeAxisConversion": _value = new global::Lua.LuaValue(Instance.bakeAxisConversion); return true;
                case "bakeIK": _value = new global::Lua.LuaValue(Instance.bakeIK); return true;
                case "clipAnimations": _value = _factory.Bind(Instance.clipAnimations); return true;
                case "defaultClipAnimations": _value = _factory.Bind(Instance.defaultClipAnimations); return true;
                case "extraExposedTransformPaths": _value = _factory.Bind(Instance.extraExposedTransformPaths); return true;
                case "extraUserProperties": _value = _factory.Bind(Instance.extraUserProperties); return true;
                case "fileScale": _value = new global::Lua.LuaValue(Instance.fileScale); return true;
                case "generateAnimations": _value = new global::Lua.LuaValue((global::System.Int64)Instance.generateAnimations); return true;
                case "generateSecondaryUV": _value = new global::Lua.LuaValue(Instance.generateSecondaryUV); return true;
                case "globalScale": _value = new global::Lua.LuaValue(Instance.globalScale); return true;
                case "humanDescription": _value = _factory.Bind(Instance.humanDescription); return true;
                case "humanoidOversampling": _value = new global::Lua.LuaValue((global::System.Int64)Instance.humanoidOversampling); return true;
                case "importAnimatedCustomProperties": _value = new global::Lua.LuaValue(Instance.importAnimatedCustomProperties); return true;
                case "importAnimation": _value = new global::Lua.LuaValue(Instance.importAnimation); return true;
                case "importBlendShapeDeformPercent": _value = new global::Lua.LuaValue(Instance.importBlendShapeDeformPercent); return true;
                case "importBlendShapeNormals": _value = new global::Lua.LuaValue((global::System.Int64)Instance.importBlendShapeNormals); return true;
                case "importBlendShapes": _value = new global::Lua.LuaValue(Instance.importBlendShapes); return true;
                case "importCameras": _value = new global::Lua.LuaValue(Instance.importCameras); return true;
                case "importConstraints": _value = new global::Lua.LuaValue(Instance.importConstraints); return true;
                case "importedTakeInfos": _value = _factory.Bind(Instance.importedTakeInfos); return true;
                case "importLights": _value = new global::Lua.LuaValue(Instance.importLights); return true;
                case "importNormals": _value = new global::Lua.LuaValue((global::System.Int64)Instance.importNormals); return true;
                case "importTangents": _value = new global::Lua.LuaValue((global::System.Int64)Instance.importTangents); return true;
                case "importVisibility": _value = new global::Lua.LuaValue(Instance.importVisibility); return true;
                case "indexFormat": _value = new global::Lua.LuaValue((global::System.Int64)Instance.indexFormat); return true;
                case "isBakeIKSupported": _value = new global::Lua.LuaValue(Instance.isBakeIKSupported); return true;
                case "isReadable": _value = new global::Lua.LuaValue(Instance.isReadable); return true;
                case "isTangentImportSupported": _value = new global::Lua.LuaValue(Instance.isTangentImportSupported); return true;
                case "isUseFileUnitsSupported": _value = new global::Lua.LuaValue(Instance.isUseFileUnitsSupported); return true;
                case "keepQuads": _value = new global::Lua.LuaValue(Instance.keepQuads); return true;
                case "materialImportMode": _value = new global::Lua.LuaValue((global::System.Int64)Instance.materialImportMode); return true;
                case "materialLocation": _value = new global::Lua.LuaValue((global::System.Int64)Instance.materialLocation); return true;
                case "materialName": _value = new global::Lua.LuaValue((global::System.Int64)Instance.materialName); return true;
                case "materialSearch": _value = new global::Lua.LuaValue((global::System.Int64)Instance.materialSearch); return true;
                case "maxBonesPerVertex": _value = new global::Lua.LuaValue(Instance.maxBonesPerVertex); return true;
                case "meshCompression": _value = new global::Lua.LuaValue((global::System.Int64)Instance.meshCompression); return true;
                case "meshOptimizationFlags": _value = new global::Lua.LuaValue((global::System.Int64)Instance.meshOptimizationFlags); return true;
                case "minBoneWeight": _value = new global::Lua.LuaValue(Instance.minBoneWeight); return true;
                case "motionNodeName": _value = new global::Lua.LuaValue(Instance.motionNodeName); return true;
                case "normalCalculationMode": _value = new global::Lua.LuaValue((global::System.Int64)Instance.normalCalculationMode); return true;
                case "normalSmoothingAngle": _value = new global::Lua.LuaValue(Instance.normalSmoothingAngle); return true;
                case "normalSmoothingSource": _value = new global::Lua.LuaValue((global::System.Int64)Instance.normalSmoothingSource); return true;
                case "optimizeBones": _value = new global::Lua.LuaValue(Instance.optimizeBones); return true;
                case "optimizeGameObjects": _value = new global::Lua.LuaValue(Instance.optimizeGameObjects); return true;
                case "optimizeMeshPolygons": _value = new global::Lua.LuaValue(Instance.optimizeMeshPolygons); return true;
                case "optimizeMeshVertices": _value = new global::Lua.LuaValue(Instance.optimizeMeshVertices); return true;
                case "preserveHierarchy": _value = new global::Lua.LuaValue(Instance.preserveHierarchy); return true;
                case "referencedClips": _value = _factory.Bind(Instance.referencedClips); return true;
                case "removeConstantScaleCurves": _value = new global::Lua.LuaValue(Instance.removeConstantScaleCurves); return true;
                case "resampleCurves": _value = new global::Lua.LuaValue(Instance.resampleCurves); return true;
                case "secondaryUVAngleDistortion": _value = new global::Lua.LuaValue(Instance.secondaryUVAngleDistortion); return true;
                case "secondaryUVAreaDistortion": _value = new global::Lua.LuaValue(Instance.secondaryUVAreaDistortion); return true;
                case "secondaryUVHardAngle": _value = new global::Lua.LuaValue(Instance.secondaryUVHardAngle); return true;
                case "secondaryUVMarginMethod": _value = new global::Lua.LuaValue((global::System.Int64)Instance.secondaryUVMarginMethod); return true;
                case "secondaryUVMinLightmapResolution": _value = new global::Lua.LuaValue(Instance.secondaryUVMinLightmapResolution); return true;
                case "secondaryUVMinObjectScale": _value = new global::Lua.LuaValue(Instance.secondaryUVMinObjectScale); return true;
                case "secondaryUVPackMargin": _value = new global::Lua.LuaValue(Instance.secondaryUVPackMargin); return true;
                case "skinWeights": _value = new global::Lua.LuaValue((global::System.Int64)Instance.skinWeights); return true;
                case "sortHierarchyByName": _value = new global::Lua.LuaValue(Instance.sortHierarchyByName); return true;
                case "sourceAvatar": _value = _factory.Bind(Instance.sourceAvatar); return true;
                case "strictVertexDataChecks": _value = new global::Lua.LuaValue(Instance.strictVertexDataChecks); return true;
                case "swapUVChannels": _value = new global::Lua.LuaValue(Instance.swapUVChannels); return true;
                case "transformPaths": _value = _factory.Bind(Instance.transformPaths); return true;
                case "useFileScale": _value = new global::Lua.LuaValue(Instance.useFileScale); return true;
                case "useFileUnits": _value = new global::Lua.LuaValue(Instance.useFileUnits); return true;
                case "useSRGBMaterialColor": _value = new global::Lua.LuaValue(Instance.useSRGBMaterialColor); return true;
                case "weldVertices": _value = new global::Lua.LuaValue(Instance.weldVertices); return true;
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
                case "addCollider": Instance.addCollider = _value.Read<global::System.Boolean>();  return true;
                case "animationCompression": Instance.animationCompression = _value.Read<global::UnityEditor.ModelImporterAnimationCompression>();  return true;
                case "animationPositionError": Instance.animationPositionError = _value.Read<global::System.Single>();  return true;
                case "animationRotationError": Instance.animationRotationError = _value.Read<global::System.Single>();  return true;
                case "animationScaleError": Instance.animationScaleError = _value.Read<global::System.Single>();  return true;
                case "animationType": Instance.animationType = _value.Read<global::UnityEditor.ModelImporterAnimationType>();  return true;
                case "animationWrapMode": Instance.animationWrapMode = _value.Read<global::UnityEngine.WrapMode>();  return true;
                case "autoGenerateAvatarMappingIfUnspecified": Instance.autoGenerateAvatarMappingIfUnspecified = _value.Read<global::System.Boolean>();  return true;
                case "avatarSetup": Instance.avatarSetup = _value.Read<global::UnityEditor.ModelImporterAvatarSetup>();  return true;
                case "bakeAxisConversion": Instance.bakeAxisConversion = _value.Read<global::System.Boolean>();  return true;
                case "bakeIK": Instance.bakeIK = _value.Read<global::System.Boolean>();  return true;
                case "clipAnimations": Instance.clipAnimations = _value.Read<global::UnityEditor.ModelImporterClipAnimation[]>();  return true;
                case "extraExposedTransformPaths": Instance.extraExposedTransformPaths = _value.Read<global::System.String[]>();  return true;
                case "extraUserProperties": Instance.extraUserProperties = _value.Read<global::System.String[]>();  return true;
                case "generateAnimations": Instance.generateAnimations = _value.Read<global::UnityEditor.ModelImporterGenerateAnimations>();  return true;
                case "generateSecondaryUV": Instance.generateSecondaryUV = _value.Read<global::System.Boolean>();  return true;
                case "globalScale": Instance.globalScale = _value.Read<global::System.Single>();  return true;
                case "humanDescription": Instance.humanDescription = _value.Read<global::UnityEngine.HumanDescription>();  return true;
                case "humanoidOversampling": Instance.humanoidOversampling = _value.Read<global::UnityEditor.ModelImporterHumanoidOversampling>();  return true;
                case "importAnimatedCustomProperties": Instance.importAnimatedCustomProperties = _value.Read<global::System.Boolean>();  return true;
                case "importAnimation": Instance.importAnimation = _value.Read<global::System.Boolean>();  return true;
                case "importBlendShapeDeformPercent": Instance.importBlendShapeDeformPercent = _value.Read<global::System.Boolean>();  return true;
                case "importBlendShapeNormals": Instance.importBlendShapeNormals = _value.Read<global::UnityEditor.ModelImporterNormals>();  return true;
                case "importBlendShapes": Instance.importBlendShapes = _value.Read<global::System.Boolean>();  return true;
                case "importCameras": Instance.importCameras = _value.Read<global::System.Boolean>();  return true;
                case "importConstraints": Instance.importConstraints = _value.Read<global::System.Boolean>();  return true;
                case "importLights": Instance.importLights = _value.Read<global::System.Boolean>();  return true;
                case "importNormals": Instance.importNormals = _value.Read<global::UnityEditor.ModelImporterNormals>();  return true;
                case "importTangents": Instance.importTangents = _value.Read<global::UnityEditor.ModelImporterTangents>();  return true;
                case "importVisibility": Instance.importVisibility = _value.Read<global::System.Boolean>();  return true;
                case "indexFormat": Instance.indexFormat = _value.Read<global::UnityEditor.ModelImporterIndexFormat>();  return true;
                case "isReadable": Instance.isReadable = _value.Read<global::System.Boolean>();  return true;
                case "keepQuads": Instance.keepQuads = _value.Read<global::System.Boolean>();  return true;
                case "materialImportMode": Instance.materialImportMode = _value.Read<global::UnityEditor.ModelImporterMaterialImportMode>();  return true;
                case "materialLocation": Instance.materialLocation = _value.Read<global::UnityEditor.ModelImporterMaterialLocation>();  return true;
                case "materialName": Instance.materialName = _value.Read<global::UnityEditor.ModelImporterMaterialName>();  return true;
                case "materialSearch": Instance.materialSearch = _value.Read<global::UnityEditor.ModelImporterMaterialSearch>();  return true;
                case "maxBonesPerVertex": Instance.maxBonesPerVertex = _value.Read<global::System.Int32>();  return true;
                case "meshCompression": Instance.meshCompression = _value.Read<global::UnityEditor.ModelImporterMeshCompression>();  return true;
                case "meshOptimizationFlags": Instance.meshOptimizationFlags = _value.Read<global::UnityEditor.MeshOptimizationFlags>();  return true;
                case "minBoneWeight": Instance.minBoneWeight = _value.Read<global::System.Single>();  return true;
                case "motionNodeName": Instance.motionNodeName = _value.Read<global::System.String>();  return true;
                case "normalCalculationMode": Instance.normalCalculationMode = _value.Read<global::UnityEditor.ModelImporterNormalCalculationMode>();  return true;
                case "normalSmoothingAngle": Instance.normalSmoothingAngle = _value.Read<global::System.Single>();  return true;
                case "normalSmoothingSource": Instance.normalSmoothingSource = _value.Read<global::UnityEditor.ModelImporterNormalSmoothingSource>();  return true;
                case "optimizeBones": Instance.optimizeBones = _value.Read<global::System.Boolean>();  return true;
                case "optimizeGameObjects": Instance.optimizeGameObjects = _value.Read<global::System.Boolean>();  return true;
                case "optimizeMeshPolygons": Instance.optimizeMeshPolygons = _value.Read<global::System.Boolean>();  return true;
                case "optimizeMeshVertices": Instance.optimizeMeshVertices = _value.Read<global::System.Boolean>();  return true;
                case "preserveHierarchy": Instance.preserveHierarchy = _value.Read<global::System.Boolean>();  return true;
                case "removeConstantScaleCurves": Instance.removeConstantScaleCurves = _value.Read<global::System.Boolean>();  return true;
                case "resampleCurves": Instance.resampleCurves = _value.Read<global::System.Boolean>();  return true;
                case "secondaryUVAngleDistortion": Instance.secondaryUVAngleDistortion = _value.Read<global::System.Single>();  return true;
                case "secondaryUVAreaDistortion": Instance.secondaryUVAreaDistortion = _value.Read<global::System.Single>();  return true;
                case "secondaryUVHardAngle": Instance.secondaryUVHardAngle = _value.Read<global::System.Single>();  return true;
                case "secondaryUVMarginMethod": Instance.secondaryUVMarginMethod = _value.Read<global::UnityEditor.ModelImporterSecondaryUVMarginMethod>();  return true;
                case "secondaryUVMinLightmapResolution": Instance.secondaryUVMinLightmapResolution = _value.Read<global::System.Single>();  return true;
                case "secondaryUVMinObjectScale": Instance.secondaryUVMinObjectScale = _value.Read<global::System.Single>();  return true;
                case "secondaryUVPackMargin": Instance.secondaryUVPackMargin = _value.Read<global::System.Single>();  return true;
                case "skinWeights": Instance.skinWeights = _value.Read<global::UnityEditor.ModelImporterSkinWeights>();  return true;
                case "sortHierarchyByName": Instance.sortHierarchyByName = _value.Read<global::System.Boolean>();  return true;
                case "sourceAvatar": Instance.sourceAvatar = _value.Read<global::UnityEngine.Avatar>();  return true;
                case "strictVertexDataChecks": Instance.strictVertexDataChecks = _value.Read<global::System.Boolean>();  return true;
                case "swapUVChannels": Instance.swapUVChannels = _value.Read<global::System.Boolean>();  return true;
                case "useFileScale": Instance.useFileScale = _value.Read<global::System.Boolean>();  return true;
                case "useFileUnits": Instance.useFileUnits = _value.Read<global::System.Boolean>();  return true;
                case "useSRGBMaterialColor": Instance.useSRGBMaterialColor = _value.Read<global::System.Boolean>();  return true;
                case "weldVertices": Instance.weldVertices = _value.Read<global::System.Boolean>();  return true;
                default: return base.TrySetLuaValue(_key, _value);
            }
        }
    }
    public sealed class LuaModelImporterType : global::Luny.ILuaStatic
    {
        public static global::Lua.LuaValue Bind() => new LuaModelImporterType();
        private LuaModelImporterType() {}
        public static implicit operator global::Lua.LuaValue(LuaModelImporterType value) => new(value);
        public global::System.Type BindType => typeof(global::UnityEditor.ModelImporter);
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

        private static readonly global::Lua.LuaFunction _LuaModelImporter_new = new global::Lua.LuaFunction(".ctor", (_context, _) =>
        {
            global::Lua.LuaValue _lastArg = default;
            global::System.Int32 _lastArgPos = default;
            global::System.Type _expectedType = default;
            var _argCount = _context.ArgumentCount;
            if (_argCount == 0)
            {
                var _ret0 = new global::UnityEditor.ModelImporter();
                var _factory = _context.GetObjectFactory();
                var _lret0 = _factory.Bind(_ret0);
                var _retCount = _context.Return(_lret0);
                return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
            }
            throw new global::Lua.LuaRuntimeException(_context.Thread, $"{".ctor"}: invalid argument #{_lastArgPos}: {_lastArg} ({_lastArg.Type}), expected: {_expectedType.FullName}", 2);
        });
        private static readonly global::Lua.LuaFunction _LuaModelImporter_GetReferencedClipsForModelPath = new global::Lua.LuaFunction("GetReferencedClipsForModelPath", (_context, _) =>
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
                    var modelPath = _p0_System_String;
                    var _ret0 = global::UnityEditor.ModelImporter.GetReferencedClipsForModelPath(modelPath);
                    var _factory = _context.GetObjectFactory();
                    var _lret0 = _factory.Bind(_ret0);
                    var _retCount = _context.Return(_lret0);
                    return new global::System.Threading.Tasks.ValueTask<System.Int32>(_retCount);
                }
            }
            throw new global::Lua.LuaRuntimeException(_context.Thread, $"{"GetReferencedClipsForModelPath"}: invalid argument #{_lastArgPos}: {_lastArg} ({_lastArg.Type}), expected: {_expectedType.FullName}", 2);
        });
        private static readonly global::Lua.LuaFunction __index = new(global::Lua.Runtime.Metamethods.Index, (_context, _) =>
        {
            var _this = _context.GetArgument<LuaModelImporterType>(0);
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
            var _this = _context.GetArgument<LuaModelImporterType>(0);
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
                case "new": _value = _LuaModelImporter_new; return true;
                case "GetReferencedClipsForModelPath": _value = _LuaModelImporter_GetReferencedClipsForModelPath; return true;
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
