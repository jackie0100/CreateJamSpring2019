using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;



[CreateAssetMenu(menuName = "ScriptableObjects/Dialog Event")]
public class DialogEvent : DialogNode
{
    [SerializeField]
    UnityEvent _onDialogEvent;

    public UnityEvent OnDialogEvent
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
}
