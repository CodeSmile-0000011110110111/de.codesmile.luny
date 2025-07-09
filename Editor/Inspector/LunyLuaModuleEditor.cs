// Copyright (C) 2021-2025 Steffen Itterheim
// Refer to included LICENSE file for terms and conditions.

using CodeSmile.Luny;
using CodeSmileEditor.Luny.Generator;
using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Reflection;
using UnityEditor;
using UnityEditor.UIElements;
using UnityEngine;
using UnityEngine.UIElements;

namespace CodeSmileEditor.Luny
{
	[CustomEditor(typeof(LunyLuaModule))]
	[CanEditMultipleObjects]
	internal sealed class LunyLuaModuleEditor : Editor
	{
		private Assembly[] m_BindableAssemblies;
		private SerializedProperty m_AssemblyNameProperty;
		private SerializedProperty m_NamespacesProperty;
		private String m_AssemblyName;

		private Button m_GenerateButton;

		private VisualElement m_DebugElements;

		private LuaBindingsGenerator m_Generator;

		private static Assembly[] GetBindableAssemblies() => AppDomain.CurrentDomain.GetAssemblies()
			.Where(assembly => !assembly.IsDynamic && assembly.IsFullyTrusted)
			.OrderBy(assembly => assembly.FullName)
			.ToArray();

		private static Assembly FindMatchingAssembly(IEnumerable<Assembly> assemblies, String assemblyName) => assemblies
			.Where(assembly => assembly.GetName().Name == assemblyName)
			.FirstOrDefault();

		private void OnEnable()
		{
			m_BindableAssemblies = GetBindableAssemblies();
			m_AssemblyNameProperty = serializedObject.FindProperty("m_AssemblyName");
			m_NamespacesProperty = serializedObject.FindProperty("m_NamespaceWhitelist");
			m_AssemblyName = m_AssemblyNameProperty.stringValue;

			EditorApplication.update += OnEditorUpdate;
		}

		private void OnDisable() => EditorApplication.update -= OnEditorUpdate;

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

			{
				m_DebugElements = new GroupBox("Log");
				m_DebugElements.style.flexDirection = FlexDirection.Row;
				m_DebugElements.style.alignContent = Align.Stretch;
				m_DebugElements.style.alignItems = Align.Stretch;
				inspector.Add(m_DebugElements);

				var logAssembliesButton = new Button(OnLogAssemblies);
				logAssembliesButton.text = "Assemblies";
				m_DebugElements.Add(logAssembliesButton);

				var logNamespacesButton = new Button(OnLogNamespaces);
				logNamespacesButton.text = "Namespaces";
				m_DebugElements.Add(logNamespacesButton);

				var logTypesButton = new Button(OnLogAssemblyTypes);
				logTypesButton.text = "Types";
				m_DebugElements.Add(logTypesButton);

				var logFilteredTypesButton = new Button(OnLogFilteredTypes);
				logFilteredTypesButton.text = "Whitelist Types";
				m_DebugElements.Add(logFilteredTypesButton);
			}

			m_GenerateButton = new Button(OnGenerate);
			m_GenerateButton.text = "Generate";
			inspector.Add(m_GenerateButton);

			UpdateUIState();

			return inspector;
		}

		private void UpdateUIState()
		{
			var selectedAssembly = FindMatchingAssembly(m_BindableAssemblies, m_AssemblyName);
			m_Generator = new LuaBindingsGenerator(selectedAssembly);

			m_GenerateButton.SetEnabled(m_Generator.Types.Length > 0 && m_Generator.Namespaces.Length > 0);

			UpdateSerializedNamespacesList();
		}

		private void UpdateSerializedNamespacesList()
		{
			if (m_Generator.Types.Length == 0)
				m_NamespacesProperty.arraySize = 0;

			if (m_NamespacesProperty.arraySize != 0)
				return;

			var namespaces = m_Generator.Namespaces;
			m_NamespacesProperty.arraySize = namespaces.Length;
			for (int i = 0; i < namespaces.Length; i++)
			{
				var element = m_NamespacesProperty.GetArrayElementAtIndex(i);
				element.stringValue = namespaces[i];
			}
			m_NamespacesProperty.serializedObject.ApplyModifiedProperties();
		}

		private void OnLogAssemblies()
		{
			Debug.Log($"{m_BindableAssemblies.Length} Assemblies:");
			foreach (var assembly in m_BindableAssemblies)
				Debug.Log($"\t{assembly.GetName().Name}");
		}

		private void OnLogNamespaces()
		{
			Debug.Log($"{m_Generator.Namespaces.Length} Namespaces in {m_Generator.Assembly?.GetName().Name}:");
			foreach (var ns in m_Generator.Namespaces)
				Debug.Log($"\t{ns}");
		}

		private void OnLogAssemblyTypes()
		{
			var types = m_Generator.Types;
			Debug.Log($"{types.Length} Types in Assembly {m_Generator.Assembly?.GetName().Name}:");

			var currentNamespace = "";
			foreach (var type in m_Generator.Types)
			{
				if (currentNamespace != type.Namespace)
				{
					currentNamespace = type.Namespace;
					Debug.Log($"\t{currentNamespace}:");
				}

				Debug.Log($"\t\t{type.Name}");
			}
		}
		private void OnLogFilteredTypes()
		{
			var types = m_Generator.Types;
			var namespaces = m_NamespacesProperty.ToArray<string>();
			var filteredTypes = types.Where(type => namespaces.Contains(type.Namespace)).ToArray();
			Debug.Log($"{filteredTypes.Length} whitelisted Types:");

			var currentNamespace = "";
			foreach (var type in filteredTypes)
			{
				if (currentNamespace != type.Namespace)
				{
					currentNamespace = type.Namespace;
					Debug.Log($"\t{currentNamespace}:");
				}

				Debug.Log($"\t\t{type.Name}");
			}
		}


		private void OnGenerate()
		{
			var namespaces = m_NamespacesProperty.ToArray<string>();
			m_Generator.Generate(namespaces);
		}

		/*
		public class ExampleObject
		{
			public String simpleLabel = "Hello World!";
			public String vector3Label = "v3";
			public Vector3 vector3Value = new(-1, -2, -3);
			public Single sumOfVector3Properties = 0f;
		}
		private void BindingTest(VisualElement inspector)
		{
			var dataSource = new ExampleObject();

			var root = inspector;
			root.name = "root";
			root.dataSource = dataSource;

			var vector3Field = new Vector3Field("Vec3 Field");

			vector3Field.SetBinding("label", new DataBinding
			{
				dataSourcePath = new PropertyPath(nameof(ExampleObject.vector3Label)),
				bindingMode = BindingMode.ToTarget,
			});

			vector3Field.SetBinding("value", new DataBinding
			{
				dataSourcePath = new PropertyPath(nameof(ExampleObject.vector3Value)),
			});

			root.Add(vector3Field);

			var floatField = new FloatField("Float Field") { value = 42.2f };

			floatField.SetBinding("value", new DataBinding
			{
				dataSourcePath = new PropertyPath(nameof(ExampleObject.sumOfVector3Properties)),
			});

			root.Add(floatField);
		}*/
	}
}
