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
		public override VisualElement CreatePropertyGUI(SerializedProperty property)
		{
			var uxml = AssetDatabase.LoadAssetAtPath<VisualTreeAsset>(
				$"Packages/de.codesmile.luny/Editor/Inspector/{nameof(SerializedLuaKeyValue)}.uxml");
			var container = uxml.CloneTree();

			var keyField = container.Q<PropertyField>("keyField");
			keyField.label = "";

			EditorApplication.delayCall += () =>
			{
				var valueField = container.Q<PropertyField>("valueField");
				var valuePropertyField = valueField.contentContainer.Q<PropertyField>("propertyField");
				valuePropertyField.label = "";
			};

			return container;
		}
	}
}
