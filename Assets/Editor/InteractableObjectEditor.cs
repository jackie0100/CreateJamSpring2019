using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

[CustomEditor(typeof(InteractableObject))]
public class InteractableObjectEditor : Editor
{
    public override void OnInspectorGUI()
    {
        DrawDefaultInspector();
        if (GUILayout.Button("Interact With This"))
        {
            ((InteractableObject)target).Interact();
        }
    }
}
