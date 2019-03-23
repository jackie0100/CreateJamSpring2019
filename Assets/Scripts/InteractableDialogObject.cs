using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InteractableDialogObject : InteractableObject
{
    [SerializeField]
    DialogNode _targetNode;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public override void Interact()
    {
        Dialogbox.instance.StartDialogTree(_targetNode);
    }
}
