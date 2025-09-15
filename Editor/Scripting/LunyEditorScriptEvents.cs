// Copyright (C) 2021-2025 Steffen Itterheim
// Refer to included LICENSE file for terms and conditions.

using UnityEditor;
using UnityEngine;

namespace LunyEditor.Scripting
{
	public enum EditorScriptLifecycleEvent
	{
		Awake,
		OnDestroy,
		OnDisable,
		OnEnable,
		OnValidate,
		Reset,
	}

	public enum EditorUpdateEvent
	{
		EditorUpdate,
	}


	/*
	public enum EditorEvent
	{
		CreateGUI,
		OnFocus,
		OnValidate,
		PlayModeStateChanged,
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
	*/
}
