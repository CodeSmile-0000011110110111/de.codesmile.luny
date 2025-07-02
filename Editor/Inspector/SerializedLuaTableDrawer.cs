// Copyright (C) 2021-2025 Steffen Itterheim
// Refer to included LICENSE file for terms and conditions.

using CodeSmile.Luny;
using System;
using System.Collections.Generic;
using System.Linq;
using UnityEditor;
using UnityEditor.UIElements;
using UnityEngine;
using UnityEngine.UIElements;

namespace CodeSmileEditor.Luny
{
	[CustomPropertyDrawer(typeof(SerializedLuaTable))]
	public sealed class SerializedLuaTableDrawer : PropertyDrawer
	{
		TemplateContainer m_Container;
		private SerializedProperty m_TableProperty;
		private ListView m_DictionaryList;

		public override VisualElement CreatePropertyGUI(SerializedProperty property)
		{
			m_TableProperty = property;

			var uxml = AssetDatabase.LoadAssetAtPath<VisualTreeAsset>(
				$"Packages/de.codesmile.luny/Editor/Inspector/{nameof(SerializedLuaTable)}.uxml");
			var container = uxml.CloneTree();
			m_Container = container;

			var group = container.Q<GroupBox>("group");
			group.text = property.displayName;

			// Try find duplicate keys and mark them
			m_DictionaryList = container.Q<ListView>("dictionaryList");
			m_DictionaryList.RegisterCallback<InputEvent>(OnInput);
			// m_DictionaryList.itemsAdded += DictionaryListOnitemsAdded;

			// EditorApplication.playModeStateChanged -= OnPlayModeStateChanged;
			// EditorApplication.playModeStateChanged += OnPlayModeStateChanged;

			return container;
		}

		private void DictionaryListOnitemsAdded(IEnumerable<Int32> itemIndexes)
		{
			Debug.Log($"added: {itemIndexes.Count()} {itemIndexes.First()}");
			EditorApplication.delayCall += () =>
			{
				foreach (var index in itemIndexes)
				{
					var item = m_DictionaryList[index];
					var keyField = item.Q<PropertyField>("keyField");
					keyField.RegisterValueChangeCallback(OnKeyFieldValueChange);
				}

			};
		}

		private void OnKeyFieldValueChange(SerializedPropertyChangeEvent evt)
		{
			Debug.Log($"changed: {evt.changedProperty.stringValue}");
		}

		// private void OnPlayModeStateChanged(PlayModeStateChange state)
		// {
		// 	if (state == PlayModeStateChange.ExitingEditMode)
		// 	{
		// 		m_DictionaryList = m_TemplateContainer.Q<ListView>("dictionaryList");
		// 		m_DictionaryList.UnregisterCallback<InputEvent>(OnInput);
		// 		Debug.LogWarning("OFF");
		// 	}
		// 	else if (state == PlayModeStateChange.EnteredEditMode)
		// 	{
		// 		Debug.LogWarning("ON");
		// 		m_DictionaryList = m_TemplateContainer.Q<ListView>("dictionaryList");
		// 		m_DictionaryList.RegisterCallback<InputEvent>(OnInput);
		// 	}
		// }

		private void OnInput(InputEvent evt)
		{
			//EditorApplication.delayCall += () =>
			{
				if (EditorApplication.isPlayingOrWillChangePlaymode || m_TableProperty == null || m_TableProperty.serializedObject == null)
					return;

				// FIXME: handle this differently because of NullRefs in playmode!

				var dictValuesProperty = m_TableProperty.FindPropertyRelative("m_DictionaryValues");

				Debug.Assert(m_DictionaryList != null);
				Debug.Assert(dictValuesProperty != null);

				var uniqueKeys = new HashSet<String>(dictValuesProperty.arraySize);
				var duplicateKeys = new HashSet<String>();
				foreach (SerializedProperty item in dictValuesProperty)
				{
					var value = item.boxedValue as SerializedLuaKeyValue;
					if (uniqueKeys.Add(value.Key) == false)
					{
						duplicateKeys.Add(value.Key);
						value.IsDuplicateKey = true;
						// Debug.Log($"{value.Key} is duplicate: {value.IsDuplicateKey}");
					}
					else
					{
						value.IsDuplicateKey = false;
					}
				}

				var pairs = m_DictionaryList.Query<VisualElement>("keyValuePair");
				Debug.Assert(pairs != null);

				pairs.ForEach(keyValuePair =>
				{
					var keyField = keyValuePair.Q<PropertyField>("keyField");
					var textElement = keyField.Q<TextElement>();
					var dupeKey = keyValuePair.Q<VisualElement>("duplicateKey");
					Debug.Assert(dupeKey != null);

					var isDuplicate = duplicateKeys.Contains(textElement.text);
					dupeKey.style.display = isDuplicate ? DisplayStyle.Flex : DisplayStyle.None;
					dupeKey.style.backgroundColor = new StyleColor(isDuplicate ? new Color(.6f, 0f, 0f) : Color.white);
				});
			};
		}
	}
}
