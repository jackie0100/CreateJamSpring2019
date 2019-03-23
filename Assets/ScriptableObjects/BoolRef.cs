using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "ScriptableObjects/BoolRef")]
public class BoolRef : ScriptableObject
{
    [SerializeField]
    protected bool value;

    public virtual bool Value
    {
        get
        {
            return value;
        }

        set
        {
            this.value = value;
        }
    }
}
