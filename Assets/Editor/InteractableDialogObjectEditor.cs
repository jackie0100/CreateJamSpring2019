using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

[CustomEditor(typeof(InteractableDialogObject))]
public class InteractableDialogObjectEditor : InteractableObjectEditor
{
    public override void OnInspectorGUI()
    {
        DrawDefaultInspector();
        if (GUILayout.Button("Interact With This"))
        {
            ((InteractableDialogObject)target).Interact();
        }
    }
}
