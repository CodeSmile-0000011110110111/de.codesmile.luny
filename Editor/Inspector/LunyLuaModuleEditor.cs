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
		private SerializedProperty m_AssemblyNameProperty;
		private SerializedProperty m_NamespaceWhitelistProperty;
		private SerializedProperty m_TypeWhitelistProperty;

		private AssemblyDefinitionAssets m_AsmDefCollection;
		private IEnumerable<Assembly> m_BindableAssemblies;
		private IEnumerable<string> m_BindableTypeNames;
		private String m_AssemblyName;
		Assembly m_Assembly;
		private IEnumerable<String> m_Namespaces;
		private IEnumerable<String> m_NamespacesFiltered;
		private IEnumerable<Type> m_Types;
		private IEnumerable<Type> m_TypesFiltered;
		private string[] m_TypeNamesFiltered; // faster to use an array for this

		private Button m_GenerateButton;
		private Button m_DeleteButton;
		private VisualElement m_DebugElements;

		private LunyLuaModule Module => target as LunyLuaModule;

		private static String GetKindOfType(Type type) => type.IsEnum ? "enum" :
			type.IsValueType ? "struct" :
			type.IsClass ? "class" : "?";

		private void OnEnable()
		{
			m_AsmDefCollection = new AssemblyDefinitionAssets();
			m_BindableAssemblies = GenUtil.GetBindableAssemblies();

			m_AssemblyNameProperty = serializedObject.FindProperty(nameof(LunyLuaModule.m_AssemblyName));
			m_NamespaceWhitelistProperty = serializedObject.FindProperty(nameof(LunyLuaModule.m_NamespaceWhitelist));
			m_TypeWhitelistProperty = serializedObject.FindProperty(nameof(LunyLuaModule.m_TypeWhitelist));
			m_AssemblyName = m_AssemblyNameProperty.stringValue;

			EditorApplication.update += OnEditorUpdate;
		}

		private void OnDisable() => EditorApplication.update -= OnEditorUpdate;


		private void OnDeleteGeneratedContent()
		{
			GenUtil.TryDeleteContentFolderPath(Module);
			//OnGenerate();
		}
		private void OnGenerate()
		{
			LuaBindingsGenerator.Generate(Module, m_AsmDefCollection, m_TypesFiltered);

			// Refresh makes sense here as it will avoid compilation if there weren't any changes, unlike
			// ImportAsset on the content folder (recursively) which always recompiles for some reason
			AssetDatabase.Refresh();
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

			{
				m_DebugElements = new GroupBox("Log");
				m_DebugElements.style.flexDirection = FlexDirection.Row;
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

			var generateGroup = new VisualElement();
			generateGroup.style.flexDirection = FlexDirection.Row;
			inspector.Add(generateGroup);

			m_DeleteButton = new Button(OnDeleteGeneratedContent);
			m_DeleteButton.text = "Delete Generated";
			m_DeleteButton.style.flexGrow = new StyleFloat(1f);
			generateGroup.Add(m_DeleteButton);

			m_GenerateButton = new Button(OnGenerate);
			m_GenerateButton.text = "Generate";
			m_GenerateButton.style.flexGrow = new StyleFloat(1f);
			generateGroup.Add(m_GenerateButton);

			UpdateUIState();

			return inspector;
		}

		private void UpdateUIState()
		{
			m_Assembly = GenUtil.FindMatchingAssembly(m_BindableAssemblies, Module.AssemblyName);
			m_Types = GenUtil.GetBindableTypes(m_Assembly);
			m_BindableTypeNames = m_Types.Select(t => t.FullName);
			m_Namespaces = GenUtil.GetNamespacesFromTypes(m_Types);
			m_NamespacesFiltered = GenUtil.GetNamespacesExcept(m_Namespaces, Module.NamespaceBlacklist);
			m_TypesFiltered = GenUtil.GetTypesExcept(GenUtil.GetNamespaceFilteredTypes(m_Types, m_NamespacesFiltered), Module.TypeBlacklist);
			m_TypeNamesFiltered = m_TypesFiltered.Select(t => t.FullName).ToArray();

			m_GenerateButton.SetEnabled(m_TypeNamesFiltered.Length > 0);

			UpdateSerializedNamespaceWhitelist();
			UpdateSerializedTypeWhitelist();
			serializedObject.ApplyModifiedProperties();
		}

		private void UpdateSerializedNamespaceWhitelist()
		{
			var namespaces = m_NamespacesFiltered.ToArray();
			var namespaceCount = namespaces.Length;
			m_NamespaceWhitelistProperty.arraySize = namespaceCount;
			for (var i = 0; i < namespaceCount; i++)
			{
				var element = m_NamespaceWhitelistProperty.GetArrayElementAtIndex(i);
				element.stringValue = namespaces[i];
			}
		}

		private void UpdateSerializedTypeWhitelist()
		{
			var typeCount = m_TypeNamesFiltered.Length;
			m_TypeWhitelistProperty.arraySize = typeCount;
			for (var i = 0; i <typeCount; i++)
			{
				var element = m_TypeWhitelistProperty.GetArrayElementAtIndex(i);
				element.stringValue = m_TypeNamesFiltered[i];
			}
		}

		private void OnLogAssemblies()
		{
			Debug.Log($"{m_BindableAssemblies.Count()} Assemblies:");
			foreach (var assembly in m_BindableAssemblies)
				Debug.Log($"\t{assembly.GetName().Name}");
		}

		private void OnLogNamespaces()
		{
			Debug.Log($"{m_Namespaces.Count()} Namespaces in {m_Assembly.GetName().Name}:");
			foreach (var ns in m_Namespaces)
				Debug.Log($"\t{ns}");
		}

		private void OnLogAssemblyTypes()
		{
			Debug.Log($"{m_Types.Count()} Types in Assembly {m_Assembly.GetName().Name}:");

			var currentNamespace = "";
			foreach (var type in m_Types)
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
			var namespaces = Module.NamespaceWhitelist.Except(Module.NamespaceBlacklist);
			var filteredTypes = GenUtil.GetNamespaceFilteredTypes(m_Types, namespaces);
			Debug.Log($"{filteredTypes.Count()} namespace whitelisted Types:");

			var currentNamespace = "";
			foreach (var type in filteredTypes)
			{
				if (currentNamespace != type.Namespace)
				{
					currentNamespace = type.Namespace;
					Debug.Log($"{currentNamespace} namespace in Assembly {m_Assembly.GetName().Name}:");
				}

				Debug.Log($"\t{GetKindOfType(type)} {type.Name}");
			}
		}

		private void OnLogTypeMethods()
		{
			var namespaces = Module.NamespaceWhitelist.Except(Module.NamespaceBlacklist);
			var typeNames = Module.TypeWhitelist.Except(Module.TypeBlacklist);
			var filteredTypes = GenUtil.GetNamespaceFilteredTypes(m_Types, namespaces, typeNames);
			Debug.Log($"{filteredTypes.Count()} whitelisted Types:");

			foreach (var type in filteredTypes)
			{
				if (type.IsEnum)
					Debug.Log($"\tenum {type.Name} has {type.GetEnumValues().Length} values");
				else
				{
					var methods = GenUtil.GetBindableMethods(type);
					Debug.Log($"\t{type.Name} has {methods.Count()} declared methods:");
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
