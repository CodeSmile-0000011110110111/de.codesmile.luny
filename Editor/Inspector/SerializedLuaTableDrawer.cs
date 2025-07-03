// Copyright (C) 2021-2025 Steffen Itterheim
// Refer to included LICENSE file for terms and conditions.

using CodeSmile.Luny;
using System;
using System.Collections.Generic;
using UnityEditor;
using UnityEditor.UIElements;
using UnityEngine;
using UnityEngine.UIElements;

namespace CodeSmileEditor.Luny
{
	[CustomPropertyDrawer(typeof(SerializedLuaTable))]
	public sealed class SerializedLuaTableDrawer : PropertyDrawer
	{
		private const String PathRoot = "Packages/de.codesmile.luny/Editor/Inspector";
		private VisualTreeAsset m_LuaKeyValueTemplate;

		private SerializedProperty m_TableProperty;
		private ListView m_DictionaryList;

		private static VisualTreeAsset LoadLuaTableTemplate()
		{
			var path = $"{PathRoot}/{nameof(SerializedLuaTable)}.uxml";
			return AssetDatabase.LoadAssetAtPath<VisualTreeAsset>(path);
		}

		private static VisualTreeAsset LoadLuaKeyValueTemplate()
		{
			var path = $"{PathRoot}/{nameof(SerializedLuaKeyValue)}.uxml";
			return AssetDatabase.LoadAssetAtPath<VisualTreeAsset>(path);
		}

		public override VisualElement CreatePropertyGUI(SerializedProperty property)
		{
			m_TableProperty = property;

			var container = LoadLuaTableTemplate().CloneTree();
			m_LuaKeyValueTemplate = LoadLuaKeyValueTemplate();

			var group = container.Q<GroupBox>("group");
			group.text = property.displayName;

			m_DictionaryList = container.Q<ListView>("dictionaryList");
			m_DictionaryList.makeItem += MakeItem;

			return container;
		}

		private VisualElement MakeItem()
		{
			var container = m_LuaKeyValueTemplate.CloneTree();

			var keyField = container.Q<PropertyField>("keyField");
			keyField.label = "";
			keyField.RegisterValueChangeCallback(OnKeyValueChange);

			EditorApplication.delayCall += () =>
			{
				// remove the "value" label since we're using a key TextField instead
				var valueField = container.Q<PropertyField>("valueField");
				var valuePropertyField = valueField.Q<PropertyField>("propertyField");
				valuePropertyField.label = "";
			};

			return container;
		}

		private void OnKeyValueChange(SerializedPropertyChangeEvent evt)
		{
			var dictValuesProperty = m_TableProperty.FindPropertyRelative("m_DictionaryValues");

			// find any duplicate keys and highlight them
			var uniqueKeys = new HashSet<String>(dictValuesProperty.arraySize);
			var duplicateKeys = new HashSet<String>();
			foreach (SerializedProperty item in dictValuesProperty)
			{
				var value = item.boxedValue as SerializedLuaKeyValue;
				if (uniqueKeys.Add(value.Key) == false)
					duplicateKeys.Add(value.Key);
			}

			// highlight duplicates with an icon
			var pairs = m_DictionaryList.Query<VisualElement>("keyValuePair");
			pairs.ForEach(keyValuePair =>
			{
				var keyField = keyValuePair.Q<PropertyField>("keyField");
				var textElement = keyField.Q<TextElement>();
				var dupeKey = keyValuePair.Q<VisualElement>("duplicateKey");

				var isDuplicate = duplicateKeys.Contains(textElement.text);
				dupeKey.style.display = isDuplicate ? DisplayStyle.Flex : DisplayStyle.None;
			});
		}
	}
}
