using CodeSmile.Luny;
using UnityEditor;
using UnityEngine;

namespace CodeSmileEditor.Luny
{
	[CustomEditor(typeof(LunyLuaAsset))]
	public sealed class LunyLuaAssetEditor : UnityEditor.Editor
	{
		private SerializedProperty m_TextProperty;

		public override void OnInspectorGUI()
		{
			if (m_TextProperty == null)
				m_TextProperty = serializedObject.FindProperty("text");

			using (new EditorGUI.IndentLevelScope(-1))
				EditorGUILayout.TextArea(m_TextProperty.stringValue);
		}
	}
}
