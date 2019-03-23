using UnityEngine;
using UnityEditor;
using System.Linq;
using System;
using System.Reflection;

[CustomPropertyDrawer(typeof(DialogOption))]
public class DialogOptionsEditor : PropertyDrawer
{
    public override void OnGUI(Rect position, SerializedProperty property, GUIContent label)
    {
        var item = property.FindPropertyRelative("_node").objectReferenceValue as DialogNode;
        
        EditorGUI.PropertyField(position, property, label, true);
        if (GUILayout.Button("Select Parent"))
        {
            if (item != null)
            {
                Selection.activeObject = item;
            }
        }
        property.serializedObject.ApplyModifiedProperties();
        property.serializedObject.Update();
    }

    public override float GetPropertyHeight(SerializedProperty property, GUIContent label)
    {
        if (property.isExpanded)
            return EditorGUI.GetPropertyHeight(property) + 20f;
        return EditorGUI.GetPropertyHeight(property);
    }
}