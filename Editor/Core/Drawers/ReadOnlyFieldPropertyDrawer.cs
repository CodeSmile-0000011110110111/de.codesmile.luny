// Copyright (C) 2021-2025 Steffen Itterheim
// Refer to included LICENSE file for terms and conditions.

using CodeSmile;
using System;
using UnityEditor;
using UnityEngine;

namespace CodeSmileEditor
{
	[CustomPropertyDrawer(typeof(ReadOnlyFieldAttribute))]
	public sealed class ReadOnlyFieldPropertyDrawer : PropertyDrawer
	{
		public override Single GetPropertyHeight(SerializedProperty property, GUIContent label) =>
			EditorGUI.GetPropertyHeight(property, label, true);

		public override void OnGUI(Rect position, SerializedProperty property, GUIContent label)
		{
			GUI.enabled = false;
			EditorGUI.PropertyField(position, property, label, true);
			GUI.enabled = true;
		}
	}
}
