// Copyright (C) 2021-2025 Steffen Itterheim
// Refer to included LICENSE file for terms and conditions.

using CodeSmile.Luny;
using Lua;
using System;
using UnityEditor;
using UnityEngine;
using UnityEngine.UIElements;

namespace CodeSmileEditor.Luny
{
	[CustomPropertyDrawer(typeof(SerializableLuaValue))]
	public class SerializableLuaValueDrawer : PropertyDrawer
	{
		private static readonly String[] s_LuaValueTypeNames = Enum.GetNames(typeof(LuaValueType));

		private SerializedProperty m_ValueType;
		private SerializedProperty m_ValueString;
		private TextField m_ValueStringTextField;

		public override VisualElement CreatePropertyGUI(SerializedProperty property)
		{
			m_ValueType = property.FindPropertyRelative("m_SerializedLuaValueType");
			m_ValueString = property.FindPropertyRelative("m_SerializedLuaValueString");

			var uxml = AssetDatabase.LoadAssetAtPath<VisualTreeAsset>(
				"Packages/de.codesmile.luny/Editor/Inspector/SerializableLuaValue.uxml");
			var container = uxml.Instantiate();
			m_ValueStringTextField = container.Q<TextField>("valueField");
			var typeField = container.Q<DropdownField>("typeField");

			m_ValueStringTextField.label = property.displayName;
			m_ValueStringTextField.value = m_ValueString.stringValue;
			m_ValueStringTextField.RegisterCallback<ChangeEvent<String>>(OnValueStringChanged);

			typeField.index = GetValueTypeDropdownIndex(typeField, m_ValueType.intValue);
			typeField.RegisterCallback<ChangeEvent<String>>(OnValueTypeChanged);

			return container;
		}

		private Int32 GetValueTypeDropdownIndex(DropdownField typeField, Int32 enumValue) =>
			enumValue >= 0 && enumValue < s_LuaValueTypeNames.Length
				? typeField.choices.IndexOf(s_LuaValueTypeNames[enumValue])
				: -1;

		private void OnValueTypeChanged(ChangeEvent<String> evt)
		{
			var index = Array.IndexOf(s_LuaValueTypeNames, evt.newValue);
			if (index < 0)
				return;

			m_ValueType.intValue = index;
			m_ValueType.serializedObject.ApplyModifiedProperties();
			EditorApplication.delayCall += () => m_ValueStringTextField.value = m_ValueString.stringValue;
		}

		private void OnValueStringChanged(ChangeEvent<String> evt)
		{
			var str = evt.newValue;
			switch (m_ValueType.intValue)
			{
				case (Int32)LuaValueType.Number:
					// make numbers accept both dot and current culture's decimal separator, but save with dot separator
					str = str.Replace(',', '.');
					break;
			}

			m_ValueString.stringValue = str;
			m_ValueType.serializedObject.ApplyModifiedProperties();
			m_ValueStringTextField.SetValueWithoutNotify(str);
		}
	}
}
