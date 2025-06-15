using CodeSmile.Luny;
using UnityEditor;
using UnityEngine;

namespace CodeSmileEditor.Luny
{
	[CustomEditor(typeof(LunyLuaAsset), true)]
	public sealed class LunyLuaAssetEditor : Editor
	{
		private SerializedProperty m_PathProperty;
		private SerializedProperty m_TextProperty;

		public override void OnInspectorGUI()
		{
			if (m_PathProperty==null)
				m_PathProperty = serializedObject.FindProperty("m_Path");
			if (m_TextProperty == null)
				m_TextProperty = serializedObject.FindProperty("m_Text");

			using (new EditorGUI.IndentLevelScope(-1))
			{
				EditorGUILayout.PropertyField(m_PathProperty);
				EditorGUILayout.PrefixLabel(m_TextProperty.displayName);
				EditorGUILayout.TextArea(m_TextProperty.stringValue);
			}
		}
	}
}
