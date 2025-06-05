// Copyright (C) 2021-2025 Steffen Itterheim
// Refer to included LICENSE file for terms and conditions.

using CodeSmile.Luny;
using System;
using UnityEditor;
using UnityEngine;
using UnityEngine.UIElements;

namespace CodeSmileEditor.Luny
{
	[CustomEditor(typeof(LuaContext))]
	[CanEditMultipleObjects]
	internal sealed class LuaContextEditor : Editor
	{
		private void Awake()
		{
			Debug.Log($"LuaContextEditor.Awake {target} : {target?.GetInstanceID()}");
		}
		private void OnEnable()
		{
			Debug.Log($"LuaContextEditor.OnEnable {target} : {target?.GetInstanceID()}");
		}
		private void OnDisable()
		{
			Debug.Log($"LuaContextEditor.OnDisable {target} : {target?.GetInstanceID()}");
		}
		private void OnDestroy()
		{
			Debug.Log($"LuaContextEditor.OnDestroy {target} : {target?.GetInstanceID()}");
		}

		// public override VisualElement CreateInspectorGUI()
		// {
		//
		// 	return base.CreateInspectorGUI();
		// }
	}
}
/*
// Copyright (C) 2021-2025 Steffen Itterheim
// Refer to included LICENSE file for terms and conditions.

#if UNITY_EDITOR
using CodeSmileEditor.Core;
using System;
using System.Threading.Tasks;
using UnityEditor;
using UnityEngine;

namespace CodeSmile.Luny
{
	public partial class LuaContext : IPlayModeStateChangeReceiver, IInitializeOnLoadReceiver
	{
		[Header("Helper")]
		[SerializeField] private Boolean m_AutoGenerateBindingsOnFocus;
		[SerializeField] private Boolean m_ClickToDeleteBindings;
		[SerializeField] private Boolean m_ClickToGenerateBindings;

		public void OnLoad()
		{
			EditorApplication.focusChanged -= OnFocusChanged;
			EditorApplication.focusChanged += OnFocusChanged;
		}

		public void OnPlayModeStateChanged(PlayModeStateChange state)
		{
			if (state == PlayModeStateChange.ExitingEditMode || state == PlayModeStateChange.EnteredEditMode)
				m_Lua = null;
		}

		private void Awake() => EditorEventDispatcher.AddReceiver(this);

		private void OnValidate()
		{
			if (m_ClickToDeleteBindings)
			{
				m_ClickToDeleteBindings = false;
				EditorApplication.delayCall += () => DeleteModuleBindings();
			}
			if (m_ClickToGenerateBindings)
			{
				m_ClickToGenerateBindings = false;
				EditorApplication.delayCall += async () => await GenerateModuleBindings();
			}
		}

		private async void OnFocusChanged(Boolean isFocused)
		{
			if (m_AutoGenerateBindingsOnFocus && isFocused)
				await GenerateModuleBindings();
		}

		private async Task GenerateModuleBindings()
		{
			foreach (var module in m_Modules)
			{
				if (module == null)
					continue;

				AssetDatabase.Refresh(); // pick up any recent script changes (I have auto-refresh disabled)

				var lua = CreateLuaInstance(false);
				await module.GenerateBindings(lua);
			}
		}
		private void DeleteModuleBindings()
		{
			foreach (var module in m_Modules)
			{
				module?.DeleteBindingsFolder();
			}
		}
	}
}
#endif
*/
