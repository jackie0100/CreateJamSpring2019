using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "ScriptableObjects/FloatRefEvent")]
public class FloatRefEvent : FloatRef
{
    [SerializeField]
    GameEvent _onValueChangedEvent;
    public override float Value
    {
        get
        {
            return base.Value;
        }
        set
        {
            base.Value = value;
            _onValueChangedEvent.Invoke();
        }
    }
}
