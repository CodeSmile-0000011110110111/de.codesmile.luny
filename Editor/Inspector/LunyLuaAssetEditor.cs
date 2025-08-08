using Luny;
using LunyEditor.Settings;
using System;
using UnityEditor;
using UnityEngine;

namespace LunyEditor.Inspector
{
	[CustomEditor(typeof(LunyLuaAsset), true)]
	public sealed class LunyLuaAssetEditor : Editor
	{
		private SerializedProperty m_PathProperty;
		private SerializedProperty m_TextProperty;

		private void OnEnable()
		{
			// remove the NotEditable flag to allow user interactable controls
			if ((target.hideFlags & HideFlags.NotEditable) != 0)
				target.hideFlags &= ~HideFlags.NotEditable;
		}

		public override void OnInspectorGUI()
		{
			if (m_PathProperty == null)
				m_PathProperty = serializedObject.FindProperty("m_Path");
			if (m_TextProperty == null)
				m_TextProperty = serializedObject.FindProperty("m_Text");

			using (new EditorGUI.IndentLevelScope(-1))
			{
				var isAutoRun = GetIsAutoRun();
				var shouldAutoRun = EditorGUILayout.Toggle("Auto-Run", isAutoRun);
				if (isAutoRun != shouldAutoRun)
					ChangeAutoRunStatus(shouldAutoRun);

				EditorGUI.BeginDisabledGroup(true);
				EditorGUILayout.LabelField("Context", GetLuaAssetContextString());
				EditorGUILayout.LabelField("Path", m_PathProperty.stringValue);
				//EditorGUILayout.PropertyField(m_PathProperty);
				//EditorGUILayout.PrefixLabel(m_TextProperty.displayName);
				EditorGUILayout.TextArea(m_TextProperty.stringValue);
				EditorGUI.EndDisabledGroup();
			}
		}

		private void ChangeAutoRunStatus(Boolean shouldAutoRun)
		{
			switch (target)
			{
				case LunyEditorLuaAsset editorLua:
				{
					var autoruns = LunyProjectSettings.Singleton.EditorAutoRunLuaAssets;
					if (shouldAutoRun)
						autoruns.Add(editorLua);
					else
						autoruns.Remove(editorLua);
					break;
				}
				case LunyModdingLuaAsset moddingLua:
				{
					var autoruns = LunyProjectSettings.Singleton.ModdingAutoRunLuaAssets;
					if (shouldAutoRun)
						autoruns.Add(moddingLua);
					else
						autoruns.Remove(moddingLua);
					break;
				}
				case LunyRuntimeLuaAsset runtimeLua:
				{
					var autoruns = LunyProjectSettings.Singleton.RuntimeAutoRunLuaAssets;
					if (shouldAutoRun)
						autoruns.Add(runtimeLua);
					else
						autoruns.Remove(runtimeLua);
					break;
				}
				case var _:
					throw new ArgumentOutOfRangeException(target.GetType().Name);
			}
		}

		private Boolean GetIsAutoRun() => target switch
		{
			LunyEditorLuaAsset editorLua => LunyProjectSettings.Singleton.EditorAutoRunLuaAssets.Contains(editorLua),
			LunyModdingLuaAsset moddingLua => LunyProjectSettings.Singleton.ModdingAutoRunLuaAssets.Contains(moddingLua),
			LunyRuntimeLuaAsset runtimeLua => LunyProjectSettings.Singleton.RuntimeAutoRunLuaAssets.Contains(runtimeLua),
			var _ => throw new ArgumentOutOfRangeException(target.GetType().Name),
		};

		private String GetLuaAssetContextString() => target.GetType().Name switch
		{
			nameof(LunyEditorLuaAsset) => "Editor",
			nameof(LunyModdingLuaAsset) => "Modding",
			nameof(LunyRuntimeLuaAsset) => "Runtime",
			var _ => throw new ArgumentOutOfRangeException(target.GetType().Name),
		};
	}
}
