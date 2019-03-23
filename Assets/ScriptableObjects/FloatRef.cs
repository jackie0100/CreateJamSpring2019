using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "ScriptableObjects/FloatRef")]
public class FloatRef : ScriptableObject
{
    [SerializeField]
    protected float value;

    public virtual float Value
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

    public virtual void Add(float val)
    {
        Value += val;
    }
}
