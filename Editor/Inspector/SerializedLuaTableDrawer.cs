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

		private VisualTreeAsset m_LuaValueTemplate;
		private VisualTreeAsset m_LuaKeyValueTemplate;

		private SerializedProperty m_Property;
		private SerializedProperty m_DictionaryValues;
		private ListView m_ArrayList;
		private ListView m_DictionaryList;

		private static VisualTreeAsset LoadLuaTableTemplate()
		{
			var path = $"{PathRoot}/{nameof(SerializedLuaTable)}.uxml";
			return AssetDatabase.LoadAssetAtPath<VisualTreeAsset>(path);
		}

		private static VisualTreeAsset LoadLuaValueTemplate()
		{
			var path = $"{PathRoot}/{nameof(SerializedLuaValue)}.uxml";
			return AssetDatabase.LoadAssetAtPath<VisualTreeAsset>(path);
		}

		private static VisualTreeAsset LoadLuaKeyValueTemplate()
		{
			var path = $"{PathRoot}/{nameof(SerializedLuaKeyValue)}.uxml";
			return AssetDatabase.LoadAssetAtPath<VisualTreeAsset>(path);
		}

		public override VisualElement CreatePropertyGUI(SerializedProperty property)
		{
			m_Property = property;
			m_DictionaryValues = property.FindPropertyRelative("m_DictionaryValues");

			var container = LoadLuaTableTemplate().CloneTree();
			m_LuaValueTemplate = LoadLuaValueTemplate();
			m_LuaKeyValueTemplate = LoadLuaKeyValueTemplate();

			var group = container.Q<GroupBox>("group");
			group.text = property.displayName;

			// m_ArrayList = container.Q<ListView>("arrayList");
			// m_ArrayList.makeItem += MakeArrayItem;
			m_DictionaryList = container.Q<ListView>("dictionaryList");
			m_DictionaryList.makeItem += MakeDictionaryItem;

			return container;
		}

		private VisualElement MakeArrayItem()
		{
			var luaValueElement = m_LuaValueTemplate.CloneTree();
			var propertyField = luaValueElement.Q<PropertyField>("propertyField");
			propertyField.label = "?";
			return luaValueElement;
		}

		private VisualElement MakeDictionaryItem()
		{
			var luaKeyValueElement = m_LuaKeyValueTemplate.CloneTree();

			var keyField = luaKeyValueElement.Q<PropertyField>("keyField");
			keyField.label = "";
			keyField.RegisterValueChangeCallback(OnKeyValueChange);

			// FIXME: delayed because query for "propertyField" would fail otherwise (not yet bound?), causes re-layout issue
			// EditorApplication.delayCall += () =>
			// {
			// 	// remove the "value" label since we're using a key TextField instead
			// 	var valueField = container.Q<PropertyField>("valueField");
			// 	var valuePropertyField = valueField.Q<PropertyField>("propertyField");
			// 	valuePropertyField.label = "";
			// };

			return luaKeyValueElement;
		}

		private void OnKeyValueChange(SerializedPropertyChangeEvent evt)
		{
			// find any duplicate keys and highlight them
			var uniqueKeys = new HashSet<String>(m_DictionaryValues.arraySize);
			var duplicateKeys = new HashSet<String>();
			foreach (SerializedProperty item in m_DictionaryValues)
			{
				var value = (SerializedLuaKeyValue)item.boxedValue;
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
