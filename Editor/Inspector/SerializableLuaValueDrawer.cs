// Copyright (C) 2021-2025 Steffen Itterheim
// Refer to included LICENSE file for terms and conditions.

using Lua;
using Luny;
using System;
using UnityEditor;
using UnityEditor.UIElements;
using UnityEngine;
using UnityEngine.UIElements;

namespace LunyEditor.Inspector
{
	[CustomPropertyDrawer(typeof(SerializableLuaValue))]
	public sealed class SerializableLuaValueDrawer : PropertyDrawer
	{
		private const String ValueTypePropertyName = "m_ValueType";
		private const String BooleanValuePropertyName = "m_BooleanValue";
		private const String NumberValuePropertyName = "m_NumberValue";
		private const String StringValuePropertyName = "m_StringValue";
		private static readonly String[] s_LuaValueTypeNames = Enum.GetNames(typeof(LuaValueType));

		private static SerializedProperty GetSerializedProperty(IEventHandler eventHandler, String propertyName) =>
			GetSerializedProperty(UserData.From(eventHandler).property, propertyName);

		private static SerializedProperty GetSerializedProperty(SerializedProperty property, String propertyName) =>
			property?.FindPropertyRelative(propertyName);

		public override VisualElement CreatePropertyGUI(SerializedProperty property)
		{
			var valueType = GetSerializedProperty(property, ValueTypePropertyName);

			var uxml = AssetDatabase.LoadAssetAtPath<VisualTreeAsset>(
				$"Packages/de.codesmile.luny/Editor/Inspector/{nameof(SerializableLuaValue)}.uxml");
			var container = uxml.CloneTree();

			var propertyField = container.Q<PropertyField>("propertyField");
			propertyField.label = property.displayName;
			BindSelectedProperty(property, propertyField, (LuaValueType)valueType.intValue);

			var typeField = container.Q<DropdownField>("typeField");
			typeField.index = GetValueTypeDropdownIndex(typeField, valueType.intValue);
			typeField.RegisterCallback<ChangeEvent<String>>(OnValueTypeChanged);
			typeField.userData = new UserData { property = property, propertyField = propertyField };

			return container;
		}

		private void BindSelectedProperty(SerializedProperty property, PropertyField field, LuaValueType valueType)
		{
			switch (valueType)
			{
				case LuaValueType.Boolean:
					field.BindProperty(GetSerializedProperty(property, BooleanValuePropertyName));
					break;
				case LuaValueType.Number:
					field.BindProperty(GetSerializedProperty(property, NumberValuePropertyName));
					break;
				default:
				case LuaValueType.String:
					field.BindProperty(GetSerializedProperty(property, StringValuePropertyName));
					break;
			}
		}

		private Int32 GetValueTypeDropdownIndex(DropdownField typeField, Int32 enumValue)
		{
			if (enumValue == (Int32)LuaValueType.Nil)
				enumValue = (Int32)LuaValueType.Number;

			return enumValue >= 0 && enumValue < s_LuaValueTypeNames.Length
				? typeField.choices.IndexOf(s_LuaValueTypeNames[enumValue])
				: -1;
		}

		private void OnValueTypeChanged(ChangeEvent<String> evt)
		{
			var index = Array.IndexOf(s_LuaValueTypeNames, evt.newValue);
			if (index < 0)
				return;

			var valueType = GetSerializedProperty(evt.currentTarget, ValueTypePropertyName);
			valueType.intValue = index;
			valueType.serializedObject.ApplyModifiedProperties();

			var data = UserData.From(evt.currentTarget);
			BindSelectedProperty(data.property, data.propertyField, (LuaValueType)index);
		}

		private sealed class UserData
		{
			public SerializedProperty property;
			public PropertyField propertyField;
			public static UserData From(IEventHandler eventHandler) => (UserData)((VisualElement)eventHandler).userData;
		}
	}
}
