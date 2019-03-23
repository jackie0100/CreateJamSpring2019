using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "ScriptableObjects/Vector3Ref")]
public class Vector3Ref : ScriptableObject
{
    [SerializeField]
    protected Vector3 value;

    public virtual Vector3 Value
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
