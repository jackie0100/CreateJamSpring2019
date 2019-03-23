using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

[CustomEditor(typeof(GameEvent))]
public class GameEventEditor : Editor
{
    public override void OnInspectorGUI()
    {
        if (GUILayout.Button("Execute Events"))
        {
            ((GameEvent)target).Invoke();
        }
    }
}
