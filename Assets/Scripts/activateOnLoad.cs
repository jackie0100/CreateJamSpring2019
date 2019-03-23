using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class activateOnLoad : MonoBehaviour
{
    [SerializeField]
    GameEvent _event;

    // Start is called before the first frame update
    void Start()
    {
        if (_event != null)
        {
            _event.Invoke();
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
