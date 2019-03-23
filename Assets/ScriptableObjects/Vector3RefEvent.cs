using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "ScriptableObjects/Vector3RefEvent")]
public class Vector3RefEvent : Vector3Ref
{
    [SerializeField]
    GameEvent _onValueChangedEvent;

    public override Vector3 Value
    {
        get
        {
            return base.value;
        }

        set
        {
            base.value = value;
            _onValueChangedEvent.Invoke();
        }
    }
}
