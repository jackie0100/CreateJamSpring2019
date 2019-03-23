using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

[CustomEditor(typeof(DialogNodeEvent))]
public class DialogEventNodeEditor : DialogNodeEditor
{
    public override void OnInspectorGUI()
    {
        base.OnInspectorGUI();
        EditorGUILayout.PropertyField(serializedObject.FindProperty("_onDialogEvent"));
    }
}
