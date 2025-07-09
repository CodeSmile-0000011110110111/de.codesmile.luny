// Copyright (C) 2021-2025 Steffen Itterheim
// Refer to included LICENSE file for terms and conditions.

using CodeSmile.Luny;
using CodeSmileEditor.Luny.Generator;
using System;
using System.Collections.Generic;
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
		private SerializedProperty m_NamespaceWhitelistProperty;
		private SerializedProperty m_TypeWhitelistProperty;

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

		private static String GetKindOfType(Type type) => type.IsEnum ? "enum" :
			type.IsValueType ? "struct" :
			type.IsClass ? "class" : "?";

		private void OnEnable()
		{
			m_BindableAssemblies = GetBindableAssemblies();
			m_AssemblyNameProperty = serializedObject.FindProperty(nameof(LunyLuaModule.m_AssemblyName));
			m_NamespaceWhitelistProperty = serializedObject.FindProperty(nameof(LunyLuaModule.m_NamespaceWhitelist));
			m_TypeWhitelistProperty = serializedObject.FindProperty(nameof(LunyLuaModule.m_TypeWhitelist));
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

				var logFilteredTypesButton = new Button(OnLogNamespaceWhitelistedTypes);
				logFilteredTypesButton.text = "Namespace Types";
				m_DebugElements.Add(logFilteredTypesButton);

				var logTypeMethodsButton = new Button(OnLogTypeMethods);
				logTypeMethodsButton.text = "Type Methods";
				m_DebugElements.Add(logTypeMethodsButton);
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

			UpdateSerializedNamespaceWhitelist();
			UpdateSerializedTypeWhitelist();
			serializedObject.ApplyModifiedProperties();
		}

		private void UpdateSerializedNamespaceWhitelist()
		{
			if (m_Generator.Types.Length == 0)
				m_NamespaceWhitelistProperty.arraySize = 0;

			if (m_NamespaceWhitelistProperty.arraySize != 0)
				return;

			var namespaces = m_Generator.Namespaces;
			m_NamespaceWhitelistProperty.arraySize = namespaces.Length;
			for (var i = 0; i < namespaces.Length; i++)
			{
				var element = m_NamespaceWhitelistProperty.GetArrayElementAtIndex(i);
				element.stringValue = namespaces[i];
			}
		}

		private void UpdateSerializedTypeWhitelist()
		{
			if (m_Generator.Types.Length == 0)
				m_TypeWhitelistProperty.arraySize = 0;

			if (m_TypeWhitelistProperty.arraySize != 0)
				return;

			var namespaces = m_NamespaceWhitelistProperty.ToArray<String>();
			var filteredTypes = m_Generator.GetNamespaceFilteredTypes(namespaces);
			m_TypeWhitelistProperty.arraySize = filteredTypes.Length;
			for (var i = 0; i < filteredTypes.Length; i++)
			{
				var element = m_TypeWhitelistProperty.GetArrayElementAtIndex(i);
				element.stringValue = filteredTypes[i].FullName;
			}
		}

		private void OnLogAssemblies()
		{
			Debug.Log($"{m_BindableAssemblies.Length} Assemblies:");
			foreach (var assembly in m_BindableAssemblies)
				Debug.Log($"\t{assembly.GetName().Name}");
		}

		private void OnLogNamespaces()
		{
			Debug.Log($"{m_Generator.Namespaces.Length} Namespaces in {m_Generator.AssemblyName}:");
			foreach (var ns in m_Generator.Namespaces)
				Debug.Log($"\t{ns}");
		}

		private void OnLogAssemblyTypes()
		{
			var types = m_Generator.Types;
			Debug.Log($"{types.Length} Types in Assembly {m_Generator.AssemblyName}:");

			var currentNamespace = "";
			foreach (var type in m_Generator.Types)
			{
				if (currentNamespace != type.Namespace)
				{
					currentNamespace = type.Namespace;
					Debug.Log($"\t{currentNamespace}:");
				}

				Debug.Log($"\t\t{GetKindOfType(type)} {type.Name}");
			}
		}

		private void OnLogNamespaceWhitelistedTypes()
		{
			var namespaces = m_NamespaceWhitelistProperty.ToArray<String>();
			var filteredTypes = m_Generator.GetNamespaceFilteredTypes(namespaces);
			Debug.Log($"{filteredTypes.Length} namespace whitelisted Types:");

			var currentNamespace = "";
			foreach (var type in filteredTypes)
			{
				if (currentNamespace != type.Namespace)
				{
					currentNamespace = type.Namespace;
					Debug.Log($"{currentNamespace} namespace in Assembly {m_Generator.AssemblyName}:");
				}

				Debug.Log($"\t{GetKindOfType(type)} {type.Name}");
			}
		}

		private void OnLogTypeMethods()
		{
			var namespaces = m_NamespaceWhitelistProperty.ToArray<String>();
			var filteredTypes = m_Generator.GetNamespaceFilteredTypes(namespaces);
			var whitelistedTypes = m_Generator.GetWhitelistedTypes(filteredTypes, m_TypeWhitelistProperty.ToArray<String>());
			Debug.Log($"{whitelistedTypes.Length} whitelisted Types:");

			foreach (var type in whitelistedTypes)
			{
				if (type.IsEnum)
				{
					Debug.Log($"\tenum {type.Name} has {type.GetEnumValues().Length} values");
				}
				else
				{
					var methods = m_Generator.GetBindableMethods(type);
					Debug.Log($"\t{type.Name} has {methods.Length} declared methods:");
					foreach (var method in methods)
					{
						var overloads = "";
						if (method.Overloads.Count > 1)
							overloads = $" + {method.Overloads.Count - 1} overload(s)";
						Debug.Log($"\t\t{method.Name}{overloads}");
					}
				}
			}
		}

		private void OnGenerate()
		{
			var namespaces = m_NamespaceWhitelistProperty.ToArray<String>();
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
