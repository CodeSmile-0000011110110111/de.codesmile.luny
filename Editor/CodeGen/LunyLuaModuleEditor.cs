// Copyright (C) 2021-2025 Steffen Itterheim
// Refer to included LICENSE file for terms and conditions.

using Luny;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using UnityEditor;
using UnityEditor.UIElements;
using UnityEngine;
using UnityEngine.UIElements;
using Assembly = System.Reflection.Assembly;

namespace CodeSmileEditor.Luny.CodeGen
{
	[CustomEditor(typeof(LunyLuaModule))]
	[CanEditMultipleObjects]
	internal sealed class LunyLuaModuleEditor : UnityEditor.Editor
	{
		private SerializedProperty m_AssemblyNameProperty;
		private SerializedProperty m_NamespaceWhitelistProperty;
		private SerializedProperty m_TypeWhitelistProperty;

		private AssemblyDefinitionAssets m_AsmDefCollection;
		private IEnumerable<Assembly> m_BindableAssemblies;
		private String m_AssemblyName;
		private Assembly m_Assembly;
		private IEnumerable<String> m_Namespaces;
		private IEnumerable<String> m_NamespacesFiltered;
		private IEnumerable<Type> m_Types;
		private IEnumerable<Type> m_TypesFiltered;
		private String[] m_TypeNamesFiltered; // faster to use an array for this

		private Button m_DeleteButton;
		private Button m_LogModuleButton;
		private Button m_GenerateButton;
		private VisualElement m_DebugElements;

		private LunyLuaModule Module => target as LunyLuaModule;

		private SerializedProperty AssemblyNameProperty => m_AssemblyNameProperty != null
			? m_AssemblyNameProperty
			: m_AssemblyNameProperty = serializedObject.FindProperty(nameof(LunyLuaModule.m_AssemblyName));
		public SerializedProperty NamespaceWhitelistProperty => m_NamespaceWhitelistProperty != null
			? m_NamespaceWhitelistProperty
			: m_NamespaceWhitelistProperty = serializedObject.FindProperty(nameof(LunyLuaModule.m_NamespaceWhitelist));
		public SerializedProperty TypeWhitelistProperty => m_TypeWhitelistProperty != null
			? m_TypeWhitelistProperty
			: m_TypeWhitelistProperty = serializedObject.FindProperty(nameof(LunyLuaModule.m_TypeWhitelist));

		private static String GetKindOfType(Type type) => type.IsEnum ? "enum" : type.IsValueType ? "struct" : type.IsClass ? "class" : "?";

		private void OnEnable()
		{
			m_AsmDefCollection = new AssemblyDefinitionAssets();
			m_BindableAssemblies = GenUtil.GetBindableAssemblies();

			EditorApplication.update += OnEditorUpdate;
		}

		private void OnDisable() => EditorApplication.update -= OnEditorUpdate;

		private void OnDeleteGeneratedContent()
		{
			Module.ClearGeneratedTypeReferences();
			Module.SaveAsset();
			CscResponseFile.RemoveScriptingDefineSymbol(Module.ScriptingDefineSymbol);
			GenUtil.TryDeleteContentFolderPath(Module);

			// doing a full refresh because there might be other (non-generated) code changes and we want to pick those up too
			AssetDatabase.Refresh();
		}

		private void OnGenerate()
		{
			UpdateUIState(); // pick up any recent changes

			// just to avoid losing most recent Inspector changes on generator errors
			Module.SaveAsset();

			try
			{
				CscResponseFile.AddScriptingDefineSymbol(Module.ScriptingDefineSymbol);

				var onlyThisTypeStr = serializedObject.FindProperty(nameof(LunyLuaModule.m_GenerateOnlyThisType)).stringValue;
				if (String.IsNullOrEmpty(onlyThisTypeStr) == false && IsCommentedOut(onlyThisTypeStr) == false)
				{
					var onlyThisType = m_Types.Where(type => type.FullName.Equals(onlyThisTypeStr));
					var onlyThisMethodName = serializedObject.FindProperty(nameof(LunyLuaModule.m_GenerateOnlyThisMethod)).stringValue;
					if (IsCommentedOut(onlyThisMethodName))
						onlyThisMethodName = null;
					ModuleGenerator.Generate(Module, m_AsmDefCollection, onlyThisType.ToArray(), onlyThisMethodName);
				}
				else
					ModuleGenerator.Generate(Module, m_AsmDefCollection, m_TypesFiltered?.ToArray());
			}
			catch (Exception e)
			{
				CscResponseFile.RemoveScriptingDefineSymbol(Module.ScriptingDefineSymbol);

				// delay showing the error to avoid it getting hidding by the compilation process
				EditorApplication.delayCall += () => Debug.LogException(e);
				throw;
			}
			finally
			{
				// Refresh makes sense here as it will avoid compilation if there weren't any changes, unlike
				// ImportAsset on the content folder (recursively) which always recompiles for some reason
				AssetDatabase.Refresh();
				UpdateUIState(); // pick up any changes made during generation
			}
		}

		private Boolean IsCommentedOut(String str) => str.StartsWith("//") || str.StartsWith("--");

		private void OnLogModuleTable() => throw new NotImplementedException();

		// if (Module.ModuleLoader != null)
		// {
		// 	var module = new LuaTable();
		// 	Module.ModuleLoader.Load(new LuaModuleLoader.Parameters { env = module });
		// 	Debug.Log(module.Dump($"{Module.BindingsNamespace} loaded by {Module.ModuleLoader.GetType().FullName}"));
		// }
		private void OnEditorUpdate()
		{
			if (m_AssemblyName != AssemblyNameProperty.stringValue)
			{
				m_AssemblyName = AssemblyNameProperty.stringValue;
				UpdateUIState();
			}
		}

		public override VisualElement CreateInspectorGUI()
		{
			var inspector = new VisualElement();

			InspectorElement.FillDefaultInspector(inspector, serializedObject, this);

			{
				m_DebugElements = new GroupBox("Log");
				inspector.Add(m_DebugElements);

				var row0 = new VisualElement();
				var row1 = new VisualElement();
				row0.style.flexDirection = row1.style.flexDirection = FlexDirection.Row;
				m_DebugElements.Add(row0);
				m_DebugElements.Add(row1);

				var logAssembliesButton = new Button(OnLogAssemblies);
				logAssembliesButton.text = "Assemblies";
				row0.Add(logAssembliesButton);
				var logNamespacesButton = new Button(OnLogNamespaces);
				logNamespacesButton.text = "Namespaces";
				row0.Add(logNamespacesButton);
				var logTypesButton = new Button(OnLogAssemblyTypes);
				logTypesButton.text = "Types";
				row0.Add(logTypesButton);
				var logFilteredTypesButton = new Button(OnLogNamespaceWhitelistedTypes);
				logFilteredTypesButton.text = "Whitelist Types";
				row0.Add(logFilteredTypesButton);
				var logTypeMembersButton = new Button(OnLogTypeMembers);
				logTypeMembersButton.text = "Members";
				row0.Add(logTypeMembersButton);
				var logCtorsButton = new Button(OnLogCtors);
				logCtorsButton.text = "Ctors";
				row1.Add(logCtorsButton);
				var logFieldsButton = new Button(OnLogFields);
				logFieldsButton.text = "Fields";
				row1.Add(logFieldsButton);
				var logPropertiesButton = new Button(OnLogProperties);
				logPropertiesButton.text = "Properties";
				row1.Add(logPropertiesButton);
				var logMethodsButton = new Button(OnLogMethods);
				logMethodsButton.text = "Methods";
				row1.Add(logMethodsButton);
				var logEventsButton = new Button(OnLogEvents);
				logEventsButton.text = "Events";
				row1.Add(logEventsButton);
			}

			var generateGroup = new VisualElement();
			generateGroup.style.flexDirection = FlexDirection.Row;
			inspector.Add(generateGroup);

			m_DeleteButton = new Button(OnDeleteGeneratedContent);
			m_DeleteButton.text = "Delete Generated";
			m_DeleteButton.style.flexGrow = new StyleFloat(1f);
			generateGroup.Add(m_DeleteButton);

			m_LogModuleButton = new Button(OnLogModuleTable);
			m_LogModuleButton.text = "Log Module";
			m_LogModuleButton.style.flexGrow = new StyleFloat(1f);
			generateGroup.Add(m_LogModuleButton);

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
			m_Namespaces = GenUtil.GetNamespacesFromTypes(m_Types);
			m_NamespacesFiltered = GenUtil.GetNamespacesExcept(m_Namespaces, Module.NamespaceBlacklist);
			var namespaceTypes = GenUtil.GetNamespaceFilteredTypes(m_Types, m_NamespacesFiltered);
			m_TypesFiltered = GenUtil.GetTypesExcept(namespaceTypes, Module.TypeBlacklist);
			m_TypeNamesFiltered = m_TypesFiltered.Select(t => t.FullName).ToArray();

			m_DeleteButton.SetEnabled(GenUtil.ContentFolderPathExists(Module));
			m_LogModuleButton.SetEnabled(Module.ModuleLoader != null);
			m_GenerateButton.SetEnabled(m_TypeNamesFiltered.Length > 0);

			UpdateSerializedNamespaceWhitelist();
			UpdateSerializedTypeWhitelist();
			serializedObject.ApplyModifiedProperties();
		}

		private void UpdateSerializedNamespaceWhitelist()
		{
			var namespaces = m_NamespacesFiltered.ToArray();
			var namespaceCount = namespaces.Length;
			NamespaceWhitelistProperty.arraySize = namespaceCount;
			for (var i = 0; i < namespaceCount; i++)
			{
				var element = NamespaceWhitelistProperty.GetArrayElementAtIndex(i);
				element.stringValue = namespaces[i];
			}
		}

		private void UpdateSerializedTypeWhitelist()
		{
			var typeCount = m_TypeNamesFiltered.Length;
			TypeWhitelistProperty.arraySize = typeCount;
			for (var i = 0; i < typeCount; i++)
			{
				var element = TypeWhitelistProperty.GetArrayElementAtIndex(i);
				element.stringValue = m_TypeNamesFiltered[i];
			}
		}

		private void OnLogAssemblies()
		{
			Debug.Log($"{m_BindableAssemblies.Count()} bindable Assemblies:");
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
			var typeNames = Module.TypeWhitelist.Except(Module.TypeBlacklist);
			var filteredTypes = GenUtil.GetNamespaceFilteredTypes(m_Types, namespaces, typeNames);
			Debug.Log($"{filteredTypes.Count()} whitelisted Types:");

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

		private void OnLogTypeMembers() => throw new NotImplementedException();

		/*var namespaces = Module.NamespaceWhitelist.Except(Module.NamespaceBlacklist);
			var typeNames = Module.TypeWhitelist.Except(Module.TypeBlacklist);
			var filteredTypes = GenUtil.GetNamespaceFilteredTypes(m_Types, namespaces, typeNames);
			Debug.Log($"{filteredTypes.Count()} whitelisted Types' members:");

			foreach (var type in filteredTypes)
			{
				if (type.IsEnum)
					Debug.Log($"\tenum {type.Name} has {type.GetEnumValues().Length} values");
				else
				{
					var members = GenUtil.GetBindableMembers(type);
					Debug.Log($"\t{type.Name} has {members.Count()} members:");
					foreach (var member in members)
					{
						var overloads = "";
						if (member.Overloads.Count > 1)
							overloads = $" + {member.Overloads.Count - 1} overload(s)";
						Debug.Log($"\t\t{member.Name}{overloads}");
					}
				}
			}*/
		private void OnLogCtors()
		{
			var typeHierarchy = new ModuleTypeHierarchy(m_TypesFiltered?.Where(type => !type.IsEnum));
			Debug.Log($"{typeHierarchy.Types.Count()} generatable Types (w/o Enums):");
			typeHierarchy.Visit((node, level) =>
			{
				var type = node.Value;
				var typeInfo = new GenTypeInfo(type);
				var staticCtors = typeInfo.StaticMembers?.Ctors;
				var ctors = typeInfo.InstanceMembers?.Ctors;
				var indent = new String('\t', level);
				Debug.Log($"{indent}{type.FullName} has {staticCtors?.Count()} static & {ctors?.Count()} instance public Ctors:");

				if (staticCtors != null)
				{
					foreach (var staticCtor in staticCtors)
						LogMember(staticCtor, level, true);
				}

				if (ctors != null)
				{
					foreach (var ctor in ctors)
						LogMember(ctor, level);
				}
			});
		}

		private void OnLogFields()
		{
			var typeHierarchy = new ModuleTypeHierarchy(m_TypesFiltered?.Where(type => !type.IsEnum));
			Debug.Log($"{typeHierarchy.Types.Count()} generatable Types (w/o Enums):");
			typeHierarchy.Visit((node, level) =>
			{
				if (node == null)
					return;

				var type = node.Value;
				var typeInfo = new GenTypeInfo(type);
				var staticFields = typeInfo.StaticMembers?.Fields;
				var fields = typeInfo.InstanceMembers?.Fields;
				var indent = new String('\t', level);
				Debug.Log($"{indent}{type.FullName} has {staticFields?.Count()} static & {fields?.Count()} instance public Fields:");

				if (staticFields != null)
				{
					foreach (var staticField in staticFields)
						LogMember(staticField, level, true);
				}
				if (fields != null)
				{
					foreach (var field in fields)
						LogMember(field, level);
				}
			});
		}

		private void OnLogProperties()
		{
			var typeHierarchy = new ModuleTypeHierarchy(m_TypesFiltered?.Where(type => !type.IsEnum));
			Debug.Log($"{typeHierarchy.Types?.Count()} generatable Types (w/o Enums):");
			typeHierarchy.Visit((node, level) =>
			{
				var type = node.Value;
				var typeInfo = new GenTypeInfo(type);
				var staticProps = typeInfo.StaticMembers?.Properties;
				var props = typeInfo.InstanceMembers?.Properties;
				var indent = new String('\t', level);
				Debug.Log($"{indent}{type.FullName} has {staticProps?.Count()} static & {props?.Count()} instance public Properties:");

				if (staticProps != null)
				{
					foreach (var staticProp in staticProps)
						LogMember(staticProp, level, true);
				}
				if (props != null)
				{
					foreach (var prop in props)
						LogMember(prop, level);
				}
			});
		}

		private void OnLogMethods()
		{
			var typeHierarchy = new ModuleTypeHierarchy(m_TypesFiltered?.Where(type => !type.IsEnum));
			Debug.Log($"{typeHierarchy.Types.Count()} generatable Types (w/o Enums):");
			typeHierarchy.Visit((node, level) =>
			{
				var type = node.Value;
				var typeInfo = new GenTypeInfo(type);
				var staticMethods = typeInfo.StaticMembers?.Methods;
				var methods = typeInfo.InstanceMembers?.Methods;
				var indent = new String('\t', level);
				Debug.Log($"{indent}{type.FullName} has {staticMethods?.Count()} static & {methods?.Count()} instance public Methods:");

				if (staticMethods != null)
				{
					foreach (var staticMethod in staticMethods)
						LogMember(staticMethod, level, true);
				}
				if (methods != null)
				{
					foreach (var method in methods)
						LogMember(method, level);
				}
			});
		}

		private void OnLogEvents()
		{
			var typeHierarchy = new ModuleTypeHierarchy(m_TypesFiltered?.Where(type => !type.IsEnum));
			Debug.Log($"{typeHierarchy.Types.Count()} generatable Types (w/o Enums):");
			typeHierarchy.Visit((node, level) =>
			{
				var type = node.Value;
				var typeInfo = new GenTypeInfo(type);
				var staticEvents = typeInfo.StaticMembers?.Events;
				var events = typeInfo.InstanceMembers?.Events;
				var indent = new String('\t', level);
				Debug.Log($"{indent}{type.FullName} has {staticEvents?.Count()} static & {events?.Count()} instance public Events:");

				if (staticEvents != null)
				{
					foreach (var staticEvent in staticEvents)
						LogMember(staticEvent, level, true);
				}
				if (events != null)
				{
					foreach (var evt in events)
						LogMember(evt, level);
				}
			});
		}

		private void LogMember(MemberInfo member, Int32 level, Boolean isStatic = false)
		{
			var first = true;
			var sb = new StringBuilder(new String('\t', level + 1));

			if (isStatic)
				sb.Append("static ");

			if (member is MethodBase methodInfo)
			{
				sb.Append(methodInfo.Name);
				sb.Append("(");
				foreach (var param in methodInfo.GetParameters())
				{
					if (!first)
						sb.Append(", ");
					if (param.ParameterType.IsGenericParameter)
						sb.Append("T");
					else
						sb.Append(param.ParameterType.Name);
					sb.Append(" ");
					sb.Append(param.Name);
					first = false;
				}
				sb.AppendLine(")");
			}
			else if (member is FieldInfo fieldInfo)
			{
				sb.Append(fieldInfo.FieldType.Name);
				sb.Append(" ");
				sb.Append(fieldInfo.Name);
			}
			else if (member is PropertyInfo propertyInfo)
			{
				sb.Append(propertyInfo.PropertyType.Name);
				sb.Append(" ");
				sb.Append(propertyInfo.Name);
				sb.Append(" { ");
				if (propertyInfo.CanRead)
					sb.Append("get; ");
				if (propertyInfo.CanWrite)
					sb.Append("set; ");
				sb.Append("}");
			}
			else if (member is EventInfo eventInfo)
			{
				sb.Append(eventInfo.EventHandlerType);
				sb.Append(" ");
				sb.Append(eventInfo.Name);
			}

			Debug.Log(sb.ToString());
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
