using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

[CustomEditor(typeof(DialogNode))]
public class DialogNodeEditor : Editor
{
    public override void OnInspectorGUI()
    {
        var item = (DialogNode)target;
        //DrawDefaultInspector();

        EditorGUILayout.PropertyField(serializedObject.FindProperty("_dialogText"));
        EditorGUILayout.PropertyField(serializedObject.FindProperty("_childNode"));

        if (item.Childnode != null)
        {
            item.Childnode.ParentNode = item;
        }

        if (GUILayout.Button("Select Parent"))
        {
            if (item.ParentNode != null)
            {
                Selection.activeObject = item.ParentNode;
            }
        }

        serializedObject.ApplyModifiedProperties();
    }
}
