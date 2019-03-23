using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public abstract class DialogNode : ScriptableObject
{
    [SerializeField]
    protected string _dialogText;
    [SerializeField]
    protected DialogNode _nextNode;

    public string DialogText
    {
        get
        {
            return _dialogText;
        }

        set
        {
            _dialogText = value;
        }
    }

    public virtual DialogNode NextNode
    {
        get
        {
            return _nextNode;
        }

        set
        {
            _nextNode = value;
        }
    }
}