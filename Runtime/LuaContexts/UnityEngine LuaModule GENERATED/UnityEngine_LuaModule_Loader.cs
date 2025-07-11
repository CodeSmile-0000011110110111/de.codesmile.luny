
// --------------------------------------------------------------
// GENERATED FILE ----> DO NOT EDIT <---- CHANGES WILL BE LOST !!
// --------------------------------------------------------------

using CodeSmile.Luny;
using System;
using UnityEngine;
using UnityEngine.Analytics;
using UnityEngine.Diagnostics;
using UnityEngine.Events;
using UnityEngine.Profiling;
using UnityEngine.SceneManagement;
using UnityEngine.Scripting;
using UnityEngine.Search;
using UnityEngine.Serialization;
using UnityEngine.Sprites;
using UnityEngine.U2D;

namespace Lua.UnityEngine.CoreModule
{
    [Serializable]
    public sealed class UnityEngine_LuaModule_Loader : LunyLuaModuleLoader
    {
        public override void Load(LuaTable env)
        {
            base.Load(env);
            var SystemTable = GetOrCreateNamespaceTable(env, new[] { "System" });
            var UnityEngineTable = GetOrCreateNamespaceTable(env, new[] { "UnityEngine" });
            var UnityEngineAnalyticsTable = GetOrCreateNamespaceTable(env, new[] { "UnityEngine", "Analytics" });
            var UnityEngineDiagnosticsTable = GetOrCreateNamespaceTable(env, new[] { "UnityEngine", "Diagnostics" });
            var UnityEngineEventsTable = GetOrCreateNamespaceTable(env, new[] { "UnityEngine", "Events" });
            var UnityEngineProfilingTable = GetOrCreateNamespaceTable(env, new[] { "UnityEngine", "Profiling" });
            var UnityEngineSceneManagementTable = GetOrCreateNamespaceTable(env, new[] { "UnityEngine", "SceneManagement" });
            var UnityEngineScriptingTable = GetOrCreateNamespaceTable(env, new[] { "UnityEngine", "Scripting" });
            var UnityEngineSearchTable = GetOrCreateNamespaceTable(env, new[] { "UnityEngine", "Search" });
            var UnityEngineSerializationTable = GetOrCreateNamespaceTable(env, new[] { "UnityEngine", "Serialization" });
            var UnityEngineSpritesTable = GetOrCreateNamespaceTable(env, new[] { "UnityEngine", "Sprites" });
            var UnityEngineU2DTable = GetOrCreateNamespaceTable(env, new[] { "UnityEngine", "U2D" });
//            UnityEngineAnalyticsTable = new Lua_UnityEngine_Analytics_AnalyticsEventBase_API();
            LuaUtil.CreateEnumTable(typeof(SendEventOptions));
            LuaUtil.CreateEnumTable(typeof(AndroidActivityIndicatorStyle));
            LuaUtil.CreateEnumTable(typeof(AnisotropicFiltering));
            LuaUtil.CreateEnumTable(typeof(ApplicationInstallMode));
            LuaUtil.CreateEnumTable(typeof(ApplicationMemoryUsage));
            LuaUtil.CreateEnumTable(typeof(ApplicationSandboxType));
            LuaUtil.CreateEnumTable(typeof(AudioType));
            LuaUtil.CreateEnumTable(typeof(BatteryStatus));
            LuaUtil.CreateEnumTable(typeof(Camera.FieldOfViewAxis));
            LuaUtil.CreateEnumTable(typeof(Camera.GateFitMode));
            LuaUtil.CreateEnumTable(typeof(Camera.MonoOrStereoscopicEye));
            LuaUtil.CreateEnumTable(typeof(Camera.SceneViewFilterMode));
            LuaUtil.CreateEnumTable(typeof(Camera.StereoscopicEye));
            LuaUtil.CreateEnumTable(typeof(CameraClearFlags));
            LuaUtil.CreateEnumTable(typeof(CameraType));
            LuaUtil.CreateEnumTable(typeof(ColorGamut));
            LuaUtil.CreateEnumTable(typeof(ColorPrimaries));
            LuaUtil.CreateEnumTable(typeof(ColorSpace));
            LuaUtil.CreateEnumTable(typeof(CompressionLevel));
            LuaUtil.CreateEnumTable(typeof(CompressionType));
            LuaUtil.CreateEnumTable(typeof(ComputeBufferMode));
            LuaUtil.CreateEnumTable(typeof(ComputeBufferType));
            LuaUtil.CreateEnumTable(typeof(CubemapFace));
            LuaUtil.CreateEnumTable(typeof(CursorLockMode));
            LuaUtil.CreateEnumTable(typeof(CursorMode));
            LuaUtil.CreateEnumTable(typeof(CustomRenderTextureInitializationSource));
            LuaUtil.CreateEnumTable(typeof(CustomRenderTextureUpdateMode));
            LuaUtil.CreateEnumTable(typeof(CustomRenderTextureUpdateZoneSpace));
            LuaUtil.CreateEnumTable(typeof(DepthTextureMode));
            LuaUtil.CreateEnumTable(typeof(DeviceType));
            LuaUtil.CreateEnumTable(typeof(ForcedCrashCategory));
            LuaUtil.CreateEnumTable(typeof(DrivenTransformProperties));
            LuaUtil.CreateEnumTable(typeof(PersistentListenerMode));
            LuaUtil.CreateEnumTable(typeof(UnityEventCallState));
            LuaUtil.CreateEnumTable(typeof(FilterMode));
            LuaUtil.CreateEnumTable(typeof(FindObjectsInactive));
            LuaUtil.CreateEnumTable(typeof(FindObjectsSortMode));
            LuaUtil.CreateEnumTable(typeof(FogMode));
            LuaUtil.CreateEnumTable(typeof(FullScreenMode));
            LuaUtil.CreateEnumTable(typeof(FullScreenMovieControlMode));
            LuaUtil.CreateEnumTable(typeof(FullScreenMovieScalingMode));
            LuaUtil.CreateEnumTable(typeof(GradientMode));
            LuaUtil.CreateEnumTable(typeof(GraphicsBuffer.Target));
            LuaUtil.CreateEnumTable(typeof(GraphicsBuffer.UsageFlags));
            LuaUtil.CreateEnumTable(typeof(HDRDisplayBitDepth));
            LuaUtil.CreateEnumTable(typeof(HDRDisplaySupportFlags));
            LuaUtil.CreateEnumTable(typeof(HideFlags));
            LuaUtil.CreateEnumTable(typeof(InspectorSort));
            LuaUtil.CreateEnumTable(typeof(InspectorSortDirection));
            LuaUtil.CreateEnumTable(typeof(IntegrityCheckLevel));
            LuaUtil.CreateEnumTable(typeof(KeyCode));
            LuaUtil.CreateEnumTable(typeof(LightingSettings.DenoiserType));
            LuaUtil.CreateEnumTable(typeof(LightingSettings.FilterMode));
            LuaUtil.CreateEnumTable(typeof(LightingSettings.FilterType));
            LuaUtil.CreateEnumTable(typeof(LightingSettings.Lightmapper));
            LuaUtil.CreateEnumTable(typeof(LightingSettings.Sampling));
            LuaUtil.CreateEnumTable(typeof(LightmapBakeType));
            LuaUtil.CreateEnumTable(typeof(LightmapCompression));
            LuaUtil.CreateEnumTable(typeof(LightmapsMode));
            LuaUtil.CreateEnumTable(typeof(LightmapsModeLegacy));
            LuaUtil.CreateEnumTable(typeof(LightProbeProxyVolume.BoundingBoxMode));
            LuaUtil.CreateEnumTable(typeof(LightProbeProxyVolume.DataFormat));
            LuaUtil.CreateEnumTable(typeof(LightProbeProxyVolume.ProbePositionMode));
            LuaUtil.CreateEnumTable(typeof(LightProbeProxyVolume.QualityMode));
            LuaUtil.CreateEnumTable(typeof(LightProbeProxyVolume.RefreshMode));
            LuaUtil.CreateEnumTable(typeof(LightProbeProxyVolume.ResolutionMode));
            LuaUtil.CreateEnumTable(typeof(LightRenderMode));
            LuaUtil.CreateEnumTable(typeof(LightShadowCasterMode));
            LuaUtil.CreateEnumTable(typeof(LightShadows));
            LuaUtil.CreateEnumTable(typeof(LightType));
            LuaUtil.CreateEnumTable(typeof(LineAlignment));
            LuaUtil.CreateEnumTable(typeof(LineTextureMode));
            LuaUtil.CreateEnumTable(typeof(LODFadeMode));
            LuaUtil.CreateEnumTable(typeof(LogOption));
            LuaUtil.CreateEnumTable(typeof(LogType));
            LuaUtil.CreateEnumTable(typeof(MaterialGlobalIlluminationFlags));
            LuaUtil.CreateEnumTable(typeof(MaterialPropertyType));
            LuaUtil.CreateEnumTable(typeof(MeshTopology));
            LuaUtil.CreateEnumTable(typeof(MixedLightingMode));
            LuaUtil.CreateEnumTable(typeof(MotionVectorGenerationMode));
            LuaUtil.CreateEnumTable(typeof(NetworkReachability));
            LuaUtil.CreateEnumTable(typeof(NPOTSupport));
            LuaUtil.CreateEnumTable(typeof(OperatingSystemFamily));
            LuaUtil.CreateEnumTable(typeof(PrimitiveType));
            LuaUtil.CreateEnumTable(typeof(ProfilerArea));
            LuaUtil.CreateEnumTable(typeof(ReceiveGI));
            LuaUtil.CreateEnumTable(typeof(RectTransform.Axis));
            LuaUtil.CreateEnumTable(typeof(RectTransform.Edge));
            LuaUtil.CreateEnumTable(typeof(ReflectionProbe.ReflectionProbeEvent));
            LuaUtil.CreateEnumTable(typeof(RenderingPath));
            LuaUtil.CreateEnumTable(typeof(RenderTextureCreationFlags));
            LuaUtil.CreateEnumTable(typeof(RenderTextureFormat));
            LuaUtil.CreateEnumTable(typeof(RenderTextureMemoryless));
            LuaUtil.CreateEnumTable(typeof(RenderTextureReadWrite));
            LuaUtil.CreateEnumTable(typeof(RuntimeInitializeLoadType));
            LuaUtil.CreateEnumTable(typeof(RuntimePlatform));
            LuaUtil.CreateEnumTable(typeof(LoadSceneMode));
            LuaUtil.CreateEnumTable(typeof(LocalPhysicsMode));
            LuaUtil.CreateEnumTable(typeof(UnloadSceneOptions));
            LuaUtil.CreateEnumTable(typeof(ScreenOrientation));
            LuaUtil.CreateEnumTable(typeof(GarbageCollector.Mode));
            LuaUtil.CreateEnumTable(typeof(SearchViewFlags));
            LuaUtil.CreateEnumTable(typeof(SendMessageOptions));
            LuaUtil.CreateEnumTable(typeof(ShadowmaskMode));
            LuaUtil.CreateEnumTable(typeof(ShadowObjectsFilter));
            LuaUtil.CreateEnumTable(typeof(ShadowProjection));
            LuaUtil.CreateEnumTable(typeof(ShadowQuality));
            LuaUtil.CreateEnumTable(typeof(ShadowResolution));
            LuaUtil.CreateEnumTable(typeof(SkinQuality));
            LuaUtil.CreateEnumTable(typeof(SkinWeights));
            LuaUtil.CreateEnumTable(typeof(SnapAxis));
            LuaUtil.CreateEnumTable(typeof(Space));
            LuaUtil.CreateEnumTable(typeof(SpriteAlignment));
            LuaUtil.CreateEnumTable(typeof(SpriteDrawMode));
            LuaUtil.CreateEnumTable(typeof(SpriteMaskInteraction));
            LuaUtil.CreateEnumTable(typeof(SpriteMeshType));
            LuaUtil.CreateEnumTable(typeof(SpritePackingMode));
            LuaUtil.CreateEnumTable(typeof(SpritePackingRotation));
            LuaUtil.CreateEnumTable(typeof(SpriteSortPoint));
            LuaUtil.CreateEnumTable(typeof(SpriteTileMode));
            LuaUtil.CreateEnumTable(typeof(StackTraceLogType));
            LuaUtil.CreateEnumTable(typeof(StereoTargetEyeMask));
            LuaUtil.CreateEnumTable(typeof(SystemLanguage));
            LuaUtil.CreateEnumTable(typeof(TerrainQualityOverrides));
            LuaUtil.CreateEnumTable(typeof(TexGenMode));
            LuaUtil.CreateEnumTable(typeof(Texture2D.EXRFlags));
            LuaUtil.CreateEnumTable(typeof(TextureFormat));
            LuaUtil.CreateEnumTable(typeof(TextureMipmapLimitBiasMode));
            LuaUtil.CreateEnumTable(typeof(TextureWrapMode));
            LuaUtil.CreateEnumTable(typeof(ThreadPriority));
            LuaUtil.CreateEnumTable(typeof(TouchScreenKeyboard.InputFieldAppearance));
            LuaUtil.CreateEnumTable(typeof(TouchScreenKeyboard.Status));
            LuaUtil.CreateEnumTable(typeof(TouchScreenKeyboardType));
            LuaUtil.CreateEnumTable(typeof(TransferFunction));
            LuaUtil.CreateEnumTable(typeof(TransparencySortMode));
            LuaUtil.CreateEnumTable(typeof(UserAuthorization));
            LuaUtil.CreateEnumTable(typeof(ValidationLevel));
            LuaUtil.CreateEnumTable(typeof(VRTextureUsage));
            LuaUtil.CreateEnumTable(typeof(WaitTimeoutMode));
            LuaUtil.CreateEnumTable(typeof(WeightedMode));
            LuaUtil.CreateEnumTable(typeof(WhitePoint));
            LuaUtil.CreateEnumTable(typeof(WrapMode));
//            UnityEngineTable = new Lua_UnityEngine_ApplicationMemoryUsageChange_API();
//            UnityEngineTable = new Lua_UnityEngine_Awaitable+AwaitableAsyncMethodBuilder_API();
//            UnityEngineTable = new Lua_UnityEngine_Awaitable+Awaiter_API();
//            UnityEngineTable = new Lua_UnityEngine_BackgroundThreadAwaitable_API();
//            UnityEngineTable = new Lua_UnityEngine_BlendShapeBufferRange_API();
//            UnityEngineTable = new Lua_UnityEngine_BoneWeight_API();
//            UnityEngineTable = new Lua_UnityEngine_BoneWeight1_API();
//            UnityEngineTable = new Lua_UnityEngine_BoundingSphere_API();
//            UnityEngineTable = new Lua_UnityEngine_Bounds_API();
//            UnityEngineTable = new Lua_UnityEngine_BoundsInt_API();
//            UnityEngineTable = new Lua_UnityEngine_BoundsInt+PositionEnumerator_API();
//            UnityEngineTable = new Lua_UnityEngine_BuildCompression_API();
//            UnityEngineTable = new Lua_UnityEngine_Cache_API();
//            UnityEngineTable = new Lua_UnityEngine_CachedAssetBundle_API();
//            UnityEngineTable = new Lua_UnityEngine_Camera+GateFitParameters_API();
//            UnityEngineTable = new Lua_UnityEngine_Color_API();
//            UnityEngineTable = new Lua_UnityEngine_Color32_API();
//            UnityEngineTable = new Lua_UnityEngine_CombineInstance_API();
//            UnityEngineTable = new Lua_UnityEngine_CullingGroupEvent_API();
//            UnityEngineTable = new Lua_UnityEngine_CustomRenderTextureUpdateZone_API();
//            UnityEngineTable = new Lua_UnityEngine_Debug+StartupLog_API();
//            UnityEngineTable = new Lua_UnityEngine_DisplayInfo_API();
//            UnityEngineTable = new Lua_UnityEngine_DrivenRectTransformTracker_API();
//            UnityEngineTable = new Lua_UnityEngine_ExposedPropertyResolver_API();
//            UnityEngineTable = new Lua_UnityEngine_FrameTiming_API();
//            UnityEngineTable = new Lua_UnityEngine_FrustumPlanes_API();
//            UnityEngineTable = new Lua_UnityEngine_GradientAlphaKey_API();
//            UnityEngineTable = new Lua_UnityEngine_GradientColorKey_API();
//            UnityEngineTable = new Lua_UnityEngine_GraphicsBuffer+IndirectDrawArgs_API();
//            UnityEngineTable = new Lua_UnityEngine_GraphicsBuffer+IndirectDrawIndexedArgs_API();
//            UnityEngineTable = new Lua_UnityEngine_GraphicsBufferHandle_API();
//            UnityEngineTable = new Lua_UnityEngine_Hash128_API();
//            UnityEngineTable = new Lua_UnityEngine_InstantiateParameters_API();
//            UnityEngineTable = new Lua_UnityEngine_Keyframe_API();
//            UnityEngineTable = new Lua_UnityEngine_LayerMask_API();
//            UnityEngineTable = new Lua_UnityEngine_LightBakingOutput_API();
//            UnityEngineTable = new Lua_UnityEngine_LightProbesQuery_API();
//            UnityEngineTable = new Lua_UnityEngine_LOD_API();
//            UnityEngineTable = new Lua_UnityEngine_MainThreadAwaitable_API();
//            UnityEngineTable = new Lua_UnityEngine_Mathf_API();
//            UnityEngineTable = new Lua_UnityEngine_Matrix4x4_API();
//            UnityEngineTable = new Lua_UnityEngine_Mesh+MeshData_API();
//            UnityEngineTable = new Lua_UnityEngine_Mesh+MeshDataArray_API();
//            UnityEngineTable = new Lua_UnityEngine_MipmapLimitDescriptor_API();
//            UnityEngineTable = new Lua_UnityEngine_Plane_API();
//            UnityEngineTable = new Lua_UnityEngine_Pose_API();
//            UnityEngineTable = new Lua_UnityEngine_PropertyName_API();
//            UnityEngineTable = new Lua_UnityEngine_Quaternion_API();
//            UnityEngineTable = new Lua_UnityEngine_Random+State_API();
//            UnityEngineTable = new Lua_UnityEngine_RangeInt_API();
//            UnityEngineTable = new Lua_UnityEngine_Ray_API();
//            UnityEngineTable = new Lua_UnityEngine_Ray2D_API();
//            UnityEngineTable = new Lua_UnityEngine_Rect_API();
//            UnityEngineTable = new Lua_UnityEngine_RectInt_API();
//            UnityEngineTable = new Lua_UnityEngine_RectInt+PositionEnumerator_API();
//            UnityEngineTable = new Lua_UnityEngine_RefreshRate_API();
//            UnityEngineTable = new Lua_UnityEngine_RenderBuffer_API();
//            UnityEngineTable = new Lua_UnityEngine_RenderingLayerMask_API();
//            UnityEngineTable = new Lua_UnityEngine_RenderParams_API();
//            UnityEngineTable = new Lua_UnityEngine_RenderTargetSetup_API();
//            UnityEngineTable = new Lua_UnityEngine_RenderTextureDescriptor_API();
//            UnityEngineTable = new Lua_UnityEngine_Resolution_API();
//            UnityEngineSceneManagementTable = new Lua_UnityEngine_SceneManagement_CreateSceneParameters_API();
//            UnityEngineSceneManagementTable = new Lua_UnityEngine_SceneManagement_LoadSceneParameters_API();
//            UnityEngineSceneManagementTable = new Lua_UnityEngine_SceneManagement_Scene_API();
//            UnityEngineTable = new Lua_UnityEngine_SecondarySpriteTexture_API();
//            UnityEngineTable = new Lua_UnityEngine_ShaderVariantCollection+ShaderVariant_API();
//            UnityEngineTable = new Lua_UnityEngine_SortingLayer_API();
//            UnityEngineTable = new Lua_UnityEngine_TagHandle_API();
//            UnityEngineTable = new Lua_UnityEngine_TextureMipmapLimitSettings_API();
//            UnityEngineU2DTable = new Lua_UnityEngine_U2D_SpriteBone_API();
//            UnityEngineTable = new Lua_UnityEngine_Vector2_API();
//            UnityEngineTable = new Lua_UnityEngine_Vector2Int_API();
//            UnityEngineTable = new Lua_UnityEngine_Vector3_API();
//            UnityEngineTable = new Lua_UnityEngine_Vector3Int_API();
//            UnityEngineTable = new Lua_UnityEngine_Vector4_API();
//            UnityEngineTable = new Lua_UnityEngine_AnimationCurve_API();
//            UnityEngineTable = new Lua_UnityEngine_Application_API();
//            UnityEngineTable = new Lua_UnityEngine_YieldInstruction_API();
//            UnityEngineTable = new Lua_UnityEngine_AsyncOperation_API();
//            UnityEngineTable = new Lua_UnityEngine_AsyncInstantiateOperation_API();
//            UnityEngineTable = new Lua_UnityEngine_ResourceRequest_API();
//            UnityEngineTable = new Lua_UnityEngine_Coroutine_API();
//            UnityEngineTable = new Lua_UnityEngine_WaitForEndOfFrame_API();
//            UnityEngineTable = new Lua_UnityEngine_WaitForFixedUpdate_API();
//            UnityEngineTable = new Lua_UnityEngine_WaitForSeconds_API();
//            UnityEngineTable = new Lua_UnityEngine_Awaitable_API();
//            UnityEngineTable = new Lua_UnityEngine_AwaitableCompletionSource_API();
//            UnityEngineTable = new Lua_UnityEngine_Object_API();
//            UnityEngineTable = new Lua_UnityEngine_Component_API();
//            UnityEngineTable = new Lua_UnityEngine_Behaviour_API();
//            UnityEngineTable = new Lua_UnityEngine_Camera_API();
//            UnityEngineTable = new Lua_UnityEngine_FlareLayer_API();
//            UnityEngineTable = new Lua_UnityEngine_LensFlare_API();
//            UnityEngineTable = new Lua_UnityEngine_Light_API();
//            UnityEngineTable = new Lua_UnityEngine_LightProbeGroup_API();
//            UnityEngineTable = new Lua_UnityEngine_LightProbeProxyVolume_API();
//            UnityEngineTable = new Lua_UnityEngine_MonoBehaviour_API();
//            UnityEngineTable = new Lua_UnityEngine_Projector_API();
//            UnityEngineTable = new Lua_UnityEngine_ReflectionProbe_API();
//            UnityEngineTable = new Lua_UnityEngine_Skybox_API();
//            UnityEngineTable = new Lua_UnityEngine_Renderer_API();
//            UnityEngineTable = new Lua_UnityEngine_BillboardRenderer_API();
//            UnityEngineTable = new Lua_UnityEngine_LineRenderer_API();
//            UnityEngineTable = new Lua_UnityEngine_MeshRenderer_API();
//            UnityEngineTable = new Lua_UnityEngine_SkinnedMeshRenderer_API();
//            UnityEngineTable = new Lua_UnityEngine_SpriteRenderer_API();
//            UnityEngineTable = new Lua_UnityEngine_TrailRenderer_API();
//            UnityEngineTable = new Lua_UnityEngine_LODGroup_API();
//            UnityEngineTable = new Lua_UnityEngine_MeshFilter_API();
//            UnityEngineTable = new Lua_UnityEngine_OcclusionArea_API();
//            UnityEngineTable = new Lua_UnityEngine_OcclusionPortal_API();
//            UnityEngineTable = new Lua_UnityEngine_Transform_API();
//            UnityEngineTable = new Lua_UnityEngine_RectTransform_API();
//            UnityEngineTable = new Lua_UnityEngine_BillboardAsset_API();
//            UnityEngineTable = new Lua_UnityEngine_ComputeShader_API();
//            UnityEngineTable = new Lua_UnityEngine_Texture_API();
//            UnityEngineTable = new Lua_UnityEngine_Cubemap_API();
//            UnityEngineTable = new Lua_UnityEngine_CubemapArray_API();
//            UnityEngineTable = new Lua_UnityEngine_RenderTexture_API();
//            UnityEngineTable = new Lua_UnityEngine_CustomRenderTexture_API();
//            UnityEngineTable = new Lua_UnityEngine_SparseTexture_API();
//            UnityEngineTable = new Lua_UnityEngine_Texture2D_API();
//            UnityEngineTable = new Lua_UnityEngine_Texture2DArray_API();
//            UnityEngineTable = new Lua_UnityEngine_Texture3D_API();
//            UnityEngineTable = new Lua_UnityEngine_Flare_API();
//            UnityEngineTable = new Lua_UnityEngine_GameObject_API();
//            UnityEngineTable = new Lua_UnityEngine_LightingSettings_API();
//            UnityEngineTable = new Lua_UnityEngine_LightmapSettings_API();
//            UnityEngineTable = new Lua_UnityEngine_LightProbes_API();
//            UnityEngineTable = new Lua_UnityEngine_Material_API();
//            UnityEngineTable = new Lua_UnityEngine_Mesh_API();
//            UnityEngineTable = new Lua_UnityEngine_QualitySettings_API();
//            UnityEngineTable = new Lua_UnityEngine_RenderSettings_API();
//            UnityEngineTable = new Lua_UnityEngine_ScriptableObject_API();
//            UnityEngineTable = new Lua_UnityEngine_Shader_API();
//            UnityEngineTable = new Lua_UnityEngine_ShaderVariantCollection_API();
//            UnityEngineTable = new Lua_UnityEngine_Sprite_API();
//            UnityEngineTable = new Lua_UnityEngine_TextAsset_API();
//            UnityEngineU2DTable = new Lua_UnityEngine_U2D_SpriteAtlas_API();
//            UnityEngineTable = new Lua_UnityEngine_Caching_API();
//            UnityEngineTable = new Lua_UnityEngine_ColorGamutUtility_API();
//            UnityEngineTable = new Lua_UnityEngine_ColorUtility_API();
//            UnityEngineTable = new Lua_UnityEngine_ComputeBuffer_API();
//            UnityEngineTable = new Lua_UnityEngine_CrashReport_API();
//            UnityEngineTable = new Lua_UnityEngine_CullingGroup_API();
//            UnityEngineTable = new Lua_UnityEngine_Cursor_API();
//            UnityEngineTable = new Lua_UnityEngine_Debug_API();
//            UnityEngineTable = new Lua_UnityEngine_Display_API();
//            UnityEngineTable = new Lua_UnityEngine_DynamicGI_API();
//            UnityEngineTable = new Lua_UnityEngine_EventProvider_API();
//            UnityEngineEventsTable = new Lua_UnityEngine_Events_UnityEvent_API();
//            UnityEngineTable = new Lua_UnityEngine_ExpressionEvaluator_API();
//            UnityEngineTable = new Lua_UnityEngine_GeometryUtility_API();
//            UnityEngineTable = new Lua_UnityEngine_Gizmos_API();
//            UnityEngineTable = new Lua_UnityEngine_GL_API();
//            UnityEngineTable = new Lua_UnityEngine_Gradient_API();
//            UnityEngineTable = new Lua_UnityEngine_Graphics_API();
//            UnityEngineTable = new Lua_UnityEngine_GraphicsBuffer_API();
//            UnityEngineTable = new Lua_UnityEngine_Handheld_API();
//            UnityEngineTable = new Lua_UnityEngine_HDROutputSettings_API();
//            UnityEngineTable = new Lua_UnityEngine_HmiPlatform_API();
//            UnityEngineTable = new Lua_UnityEngine_iPhoneSettings_API();
//            UnityEngineTable = new Lua_UnityEngine_iPhoneUtils_API();
//            UnityEngineTable = new Lua_UnityEngine_LightmapData_API();
//            UnityEngineTable = new Lua_UnityEngine_LineUtility_API();
//            UnityEngineTable = new Lua_UnityEngine_Logger_API();
//            UnityEngineTable = new Lua_UnityEngine_MaterialPropertyBlock_API();
//            UnityEngineTable = new Lua_UnityEngine_Ping_API();
//            UnityEngineTable = new Lua_UnityEngine_PlayerPrefs_API();
//            UnityEngineProfilingTable = new Lua_UnityEngine_Profiling_Sampler_API();
//            UnityEngineProfilingTable = new Lua_UnityEngine_Profiling_CustomSampler_API();
//            UnityEngineProfilingTable = new Lua_UnityEngine_Profiling_Profiler_API();
//            UnityEngineProfilingTable = new Lua_UnityEngine_Profiling_Recorder_API();
//            UnityEngineTable = new Lua_UnityEngine_RectOffset_API();
//            UnityEngineTable = new Lua_UnityEngine_Resources_API();
//            UnityEngineTable = new Lua_UnityEngine_ResourcesAPI_API();
//            UnityEngineSceneManagementTable = new Lua_UnityEngine_SceneManagement_SceneManager_API();
//            UnityEngineSceneManagementTable = new Lua_UnityEngine_SceneManagement_SceneManagerAPI_API();
//            UnityEngineTable = new Lua_UnityEngine_Screen_API();
//            UnityEngineTable = new Lua_UnityEngine_Security_API();
//            UnityEngineSerializationTable = new Lua_UnityEngine_Serialization_ManagedReferenceUtility_API();
//            UnityEngineSerializationTable = new Lua_UnityEngine_Serialization_UnitySurrogateSelector_API();
//            UnityEngineTable = new Lua_UnityEngine_SleepTimeout_API();
//            UnityEngineSpritesTable = new Lua_UnityEngine_Sprites_DataUtility_API();
//            UnityEngineTable = new Lua_UnityEngine_StaticBatchingUtility_API();
//            UnityEngineTable = new Lua_UnityEngine_SystemInfo_API();
//            UnityEngineTable = new Lua_UnityEngine_Time_API();
//            UnityEngineTable = new Lua_UnityEngine_TouchScreenKeyboard_API();
//            UnityEngineTable = new Lua_UnityEngine_TouchScreenKeyboard+Android_API();
//            UnityEngineTable = new Lua_UnityEngine_TrackedReference_API();
//            UnityEngineU2DTable = new Lua_UnityEngine_U2D_SpriteAtlasManager_API();
//            UnityEngineTable = new Lua_UnityEngine_UnityEventQueueSystem_API();
//            UnityEngineTable = new Lua_UnityEngine_WaitForSecondsRealtime_API();
//            UnityEngineTable = new Lua_UnityEngine_WaitUntil_API();
//            UnityEngineTable = new Lua_UnityEngine_WaitWhile_API();
        }
    }
}
