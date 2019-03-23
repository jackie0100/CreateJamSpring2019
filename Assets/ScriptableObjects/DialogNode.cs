using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public abstract class DialogNode : ScriptableObject
{
    [Multiline]
    [SerializeField]
    protected string _dialogText;
    [SerializeField]
    protected DialogNode _childNode;
    [SerializeField]
    private DialogNode parentNode;
    [SerializeField]
    public event NodeEndedEvent OnNodeEndedEvent;

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

    public virtual DialogNode Childnode
    {
        get
        {
            return _childNode;
        }

        set
        {
            _childNode = value;
        }
    }

    public DialogNode ParentNode
    {
        get
        {
            return parentNode;
        }

        set
        {
            parentNode = value;
        }
    }

    public virtual void AdvanceDialogTree()
    {
        if (_childNode != null)
        {
            OnNodeEndedEvent.Invoke(_childNode);
        }
    }

    public virtual string GetDisplayText(NodeEndedEvent callback)
    {
        OnNodeEndedEvent += callback;
        return _dialogText;
    }

    public virtual bool ShouldAdvanceText()
    {
        bool keypressed = Input.GetKeyDown(KeyCode.E);
        if (keypressed)
        {
            _dialogTextTop.text = _dialogTextBot.text;
            _dialogTextBot.text = "";
        }
        return keypressed;
    }
}

public delegate void NodeEndedEvent(DialogNode node);