using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

[CustomEditor(typeof(DialogOptionsNode))]
public class DialogOptionsNodeEditor : DialogNodeEditor
{
    public override void OnInspectorGUI()
    {
        var item = (DialogOptionsNode)target;
        //DrawDefaultInspector();

        EditorGUILayout.PropertyField(serializedObject.FindProperty("_dialogText"));
        EditorGUILayout.PropertyField(serializedObject.FindProperty("_childNode"));

        EditorGUILayout.PropertyField(serializedObject.FindProperty("_dialogOptions"), includeChildren: true);

        serializedObject.ApplyModifiedProperties();
    }
}
