using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "ScriptableObjects/Test")]
public class DialogOptions : DialogNode
{
    [SerializeField]
    string[] options;
    [SerializeField]
    DialogNode[] nodes;

    public string[] Options
    {
        get
        {
            return options;
        }

        set
        {
            options = value;
        }
    }

    public DialogNode[] Nodes
    {
        get
        {
            return nodes;
        }

        set
        {
            nodes = value;
        }
    }
}
