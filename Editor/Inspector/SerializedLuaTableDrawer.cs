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
		private SerializedProperty m_DictionaryValuesProperty;

		private ListView m_DictionaryList;

		public override VisualElement CreatePropertyGUI(SerializedProperty property)
		{
			m_DictionaryValuesProperty = property.FindPropertyRelative("m_DictionaryValues");

			var uxml = AssetDatabase.LoadAssetAtPath<VisualTreeAsset>(
				$"Packages/de.codesmile.luny/Editor/Inspector/{nameof(SerializedLuaTable)}.uxml");
			var container = uxml.CloneTree();

			var group = container.Q<GroupBox>("group");
			group.text = property.displayName;

			// Try find duplicate keys and mark them
			m_DictionaryList = container.Q<ListView>("dictionaryList");
			m_DictionaryList.RegisterCallback<InputEvent>(OnInput);
			//var duplicateKey = container.Q<VisualElement>("duplicateKey");

			return container;
		}

		private void OnInput(InputEvent evt) => EditorApplication.delayCall += () =>
		{
			Debug.Assert(m_DictionaryList != null);
			Debug.Assert(m_DictionaryValuesProperty != null);

			var uniqueKeys = new HashSet<String>(m_DictionaryValuesProperty.arraySize);
			var duplicateKeys = new HashSet<String>();
			foreach (SerializedProperty item in m_DictionaryValuesProperty)
			{
				var value = item.boxedValue as SerializedLuaKeyValue;
				if (uniqueKeys.Add(value.Key) == false)
					duplicateKeys.Add(value.Key);
			}

			var items = m_DictionaryList.Query<VisualElement>("keyValuePair");
			Debug.Assert(items != null);

			items.ForEach(keyValuePair =>
			{
				var keyField = keyValuePair.Q<PropertyField>("keyField");
				var textElement = keyField.Q<TextElement>();
				var dupeKey = keyValuePair.Q<VisualElement>("duplicateKey");
				Debug.Assert(dupeKey != null);

				var isDuplicate = duplicateKeys.Contains(textElement.text);
				dupeKey.style.display = isDuplicate ? DisplayStyle.Flex : DisplayStyle.None;
				dupeKey.style.color = new StyleColor(isDuplicate ? Color.yellow : Color.white);
				dupeKey.style.backgroundColor = new StyleColor(isDuplicate ? new Color(.65f, 0f, 0f) : Color.white);
			});
		};
	}
}
