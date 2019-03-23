using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;



[CreateAssetMenu(menuName = "ScriptableObjects/Dialog Event")]
public class DialogNodeEvent : DialogNode
{
    [SerializeField]
    GameEvent _onDialogEvent;

    public GameEvent OnDialogEvent
    {
        get
        {
            return _onDialogEvent;
        }

        set
        {
            _onDialogEvent = value;
        }
    }

    public override string GetDisplayText(NodeEndedEvent callback)
    {
        OnNodeEndedEvent += callback;
        return _dialogText;
    }

    public override void AdvanceDialogTree()
    {

        base.AdvanceDialogTree();
    }
}
