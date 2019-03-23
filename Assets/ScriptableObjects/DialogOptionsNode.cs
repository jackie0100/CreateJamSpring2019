using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "ScriptableObjects/Dialog Option")]
public class DialogOptionsNode : DialogNode
{
    [SerializeField]
    DialogOption[] _dialogOptions;

    int _selection = -1;

    public override DialogNode Childnode
    {
        get
        {
            return DialogOptions[_selection].Node;
        }

        set
        {
            base.Childnode = value;
        }
    }

    public DialogOption[] DialogOptions
    {
        get
        {
            return _dialogOptions;
        }

        set
        {
            _dialogOptions = value;
        }
    }

    public override void AdvanceDialogTree()
    {
        if (_selection < 0)
        {
            Dialogbox.instance.OptionSelect(this);
        }
        else
        {

        }
        base.AdvanceDialogTree();
    }
}

[System.Serializable]
public class DialogOption
{
    [SerializeField]
    string _option;
    [SerializeField]
    DialogNode _node;

    public string Option
    {
        get
        {
            return _option;
        }

        set
        {
            _option = value;
        }
    }

    public DialogNode Node
    {
        get
        {
            return _node;
        }

        set
        {
            _node = value;
        }
    }
}