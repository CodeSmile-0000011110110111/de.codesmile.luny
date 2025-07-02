// Copyright (C) 2021-2025 Steffen Itterheim
// Refer to included LICENSE file for terms and conditions.

using CodeSmile.Luny;
using UnityEditor;
using UnityEditor.UIElements;
using UnityEngine;
using UnityEngine.UIElements;

namespace CodeSmileEditor.Luny
{
	[CustomPropertyDrawer(typeof(SerializedLuaKeyValue))]
	public sealed class SerializedLuaKeyValueDrawer : PropertyDrawer
	{
		private SerializedProperty m_Property;
		private TemplateContainer m_Container;
		public override VisualElement CreatePropertyGUI(SerializedProperty property)
		{
			m_Property = property;

			var uxml = AssetDatabase.LoadAssetAtPath<VisualTreeAsset>(
				$"Packages/de.codesmile.luny/Editor/Inspector/{nameof(SerializedLuaKeyValue)}.uxml");
			var container = uxml.CloneTree();
			m_Container = container;

			var keyField = container.Q<PropertyField>("keyField");
			keyField.label = "";
			// keyField.RegisterValueChangeCallback(OnKeyFieldChange);

			EditorApplication.delayCall += () =>
			{
				var valueField = container.Q<PropertyField>("valueField");
				var valuePropertyField = valueField.contentContainer.Q<PropertyField>("propertyField");
				valuePropertyField.label = "";
			};

			return container;
		}

		// private void OnKeyFieldChange(SerializedPropertyChangeEvent evt)
		// {
		// 	//EditorApplication.delayCall += () =>
		// 	{
		// 		var duplicateKeyProperty = m_Property.FindPropertyRelative("m_IsDuplicateKey");
		// 		var isDuplicate = duplicateKeyProperty.boolValue;
		//
		// 		Debug.Log($"key changed: {evt.changedProperty.stringValue}, duplicate: {isDuplicate}");
		//
		// 		var dupeKey = m_Container.Q<VisualElement>("duplicateKey");
		// 		dupeKey.style.display = isDuplicate ? DisplayStyle.Flex : DisplayStyle.None;
		// 		dupeKey.style.backgroundColor = new StyleColor(isDuplicate ? new Color(.6f, 0f, 0f) : Color.white);
		//
		// 	};
		// }
	}
}
