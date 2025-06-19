// Copyright (C) 2021-2025 Steffen Itterheim
// Refer to included LICENSE file for terms and conditions.

using UnityEditor;
using UnityEngine;

namespace DefaultNamespace
{
	public enum EditorEvent
	{
		CreateGUI,
		OnFocus,
		OnValidate,
		PlayModeStateChanged,
		Reset,
	}

	public enum EditorAssetModificationEvent
	{
		CanOpenForEdit,
		FileModeChanged,
		IsOpenForEdit,
		MakeEditable,
		OnWillCreateAsset,
		OnWillDeleteAsset,
		OnWillMoveAsset,
		OnWillSaveAssets,
	}

	public enum EditorAssetPostprocessorEvent
	{
		OnAssignMaterialModel,
		OnPostprocessAllAssets,
		OnPostprocessAnimation,
		OnPostprocessAssetbundleNameChanged,
		OnPostprocessAudio,
		OnPostprocessCubemap,
		OnPostprocessGameObjectWithAnimatedUserProperties,
		OnPostprocessGameObjectWithUserProperties,
		OnPostprocessMaterial,
		OnPostprocessMeshHierarchy,
		OnPostprocessModel,
		OnPostprocessPrefab,
		OnPostprocessSpeedTree,
		OnPostprocessSprites,
		OnPostprocessTexture,
		OnPostprocessTexture2DArray,
		OnPostprocessTexture3D,
		OnPreprocessAnimation,
		OnPreprocessAsset,
		OnPreprocessAudio,
		OnPreprocessCameraDescription,
		OnPreprocessLightDescription,
		OnPreprocessMaterialDescription,
		OnPreprocessModel,
		OnPreprocessSpeedTree,
		OnPreprocessTexture,
	}
}
