// Copyright (C) 2021-2025 Steffen Itterheim
// Refer to included LICENSE file for terms and conditions.

using CodeSmile.Luny;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using Unity.Properties;
using UnityEditor;
using UnityEditor.UIElements;
using UnityEngine;
using UnityEngine.UIElements;

namespace CodeSmileEditor.Luny
{
	public sealed class TestData
	{
		public String m_Text = "Hey ho!";
		[CreateProperty]
		public String Text
		{
			get => m_Text;
			set => m_Text = value;
		}
	}

	[CustomEditor(typeof(LunyLuaModule))]
	[CanEditMultipleObjects]
	internal sealed class LunyLuaModuleEditor : Editor
	{
		[SerializeField] private LunyLuaModuleEditorData m_ModuleData;
		public List<AssemblyItem> m_AssemblyNames = new();
		private IEnumerable<Assembly> m_BindableAssemblies;
		private Assembly m_SelectedAssembly;
		private IEnumerable<Type> m_BindableTypes;

		private SerializedProperty m_AssemblyNameProperty;
		private String m_AssemblyName;

		private Button m_GenerateButton;
		private IntegerField m_TypeCountField;
		private ListView m_AssembliesListView;

		private void OnEnable()
		{
			m_ModuleData = CreateInstance<LunyLuaModuleEditorData>();
			m_ModuleData.AssemblyNames.Add("test");
			m_ModuleData.AssemblyNames.Add("test123");

			m_AssemblyNameProperty = serializedObject.FindProperty("m_AssemblyName");
			m_AssemblyName = m_AssemblyNameProperty.stringValue;

			EditorApplication.update += OnEditorUpdate;
		}

		private void OnDisable()
		{
			EditorApplication.update -= OnEditorUpdate;

			DestroyImmediate(m_ModuleData);
			m_ModuleData = null;
		}

		private void OnEditorUpdate()
		{
			if (m_AssemblyName != m_AssemblyNameProperty.stringValue)
			{
				m_AssemblyName = m_AssemblyNameProperty.stringValue;
				UpdateUIState();
			}
		}

		public override VisualElement CreateInspectorGUI()
		{
			var inspector = new VisualElement();
			InspectorElement.FillDefaultInspector(inspector, serializedObject, this);

			m_TypeCountField = new IntegerField("Number of Types");
			m_TypeCountField.style.display = DisplayStyle.None;
			inspector.Add(m_TypeCountField);

			m_AssembliesListView = new ListView();
			m_AssembliesListView.name = "AssembliesListView";
			inspector.Add(m_AssembliesListView);

			m_GenerateButton = new Button(OnGenerate);
			m_GenerateButton.text = "Generate";
			inspector.Add(m_GenerateButton);

			//m_AssembliesListView.dataSource = m_ModuleData;
			//m_AssembliesListView.dataSourcePath = PropertyPath.FromName(nameof(LunyLuaModuleEditorData.AssemblyNames));
			//m_AssembliesListView.bindingPath = nameof(m_AssemblyNames);
			//var uxml = AssetDatabase.LoadAssetAtPath<VisualTreeAsset>("Packages/de.codesmile.luny/Editor/Inspector/Test/AssemblyName.uxml");
			//m_AssembliesListView.makeItem = uxml.CloneTree;

			UpdateUIState();

			// var testData = new TestData();
			// var list = new Label { dataSource = testData };
			// list.SetBinding(nameof(TestData.Text),
			// 	new DataBinding { dataSourcePath = PropertyPath.FromName(nameof(TestData.Text)) });
			// inspector.Add(list);

			// var objectTypes = TypeCache.GetTypesDerivedFrom<Object>();
			// Debug.Log($"object types: {objectTypes.Count}");
			// var list = objectTypes.ToList();
			// list.Sort((x, y) => x.FullName.CompareTo(y.FullName));
			// foreach (var type in list)
			// {
			// 	Debug.Log($"\t{type.FullName}");
			// }

			var goType = typeof(LunyScript);
			var baseType = goType;
			var count = 100;
			while (baseType != null && count > 0)
			{
				count--;

				var flags = BindingFlags.Instance | BindingFlags.Public | BindingFlags.DeclaredOnly;
				var methods = baseType.GetMethods(flags);
				var uniqueMethods = new HashSet<String>(methods.Select(m => m.Name));

				Debug.LogWarning($"{baseType.AssemblyQualifiedName}, methods: {methods.Length}, {uniqueMethods.Count}");
				foreach (var method in uniqueMethods)
				{
					//Debug.Log($"\t{method}");
				}
				baseType = baseType.BaseType;
			}

			return inspector;
		}

		private void UpdateUIState()
		{
			m_BindableAssemblies = GetBindableAssemblies();
			m_SelectedAssembly = FindMatchingAssembly(m_AssemblyName);
			m_BindableTypes = GetBindableTypes();

			m_AssemblyNames = m_BindableAssemblies.Select(a => new AssemblyItem(a.GetName().Name)).ToList();
			m_ModuleData.AssemblyNames = m_AssemblyNames.Select(item => item.Name).ToList();
			Debug.Log($"Assemblies: {m_AssemblyNames.Count}");

			// if (m_BindableTypes != null)
			// {
			// 	foreach (var type in m_BindableTypes)
			// 		Debug.Log(type.Name);
			// }

			m_GenerateButton.SetEnabled(m_SelectedAssembly != null);
			m_TypeCountField.style.display = m_SelectedAssembly != null ? DisplayStyle.Flex : DisplayStyle.None;
			if (m_SelectedAssembly != null)
				m_TypeCountField.value = m_BindableTypes.Count();
		}

		private void OnGenerate()
		{
			var assembly = FindMatchingAssembly(m_AssemblyName);
			Debug.Log($"found: {assembly} {assembly.GetName().Name}");
		}

		private IEnumerable<Assembly> GetBindableAssemblies() => AppDomain.CurrentDomain.GetAssemblies()
			.Where(assembly => !assembly.IsDynamic && assembly.IsFullyTrusted);

		private IEnumerable<Type> GetBindableTypes() => m_SelectedAssembly != null
			? m_SelectedAssembly.ExportedTypes.Where(type =>
				(type.IsClass || type.IsValueType || type.IsEnum) &&
				!(type.IsAbstract || type.IsInterface || type.IsPrimitive || type.IsGenericType ||
				  type.Name.EndsWith("Attribute") || type.Name.EndsWith("Exception")))
			: null;

		private Assembly FindMatchingAssembly(String assemblyName) => m_BindableAssemblies
			.Where(assembly => assembly.GetName().Name == assemblyName)
			.FirstOrDefault();

		[Serializable] public struct AssemblyItem
		{
			[SerializeField] private String m_Name;
			public String Name
			{
				get => m_Name;
				set => m_Name = value;
			}

			public AssemblyItem(String name) => m_Name = name;
		}
	}
}
