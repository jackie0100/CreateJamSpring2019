using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInteract : MonoBehaviour
{
    [SerializeField]
    LayerMask _mask;

    Vector2 _lookDir = new Vector2(0, -1);
    float x, y = 0;
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.LeftArrow))
        {
            x = -1;
        }
        else if (Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.RightArrow))
        {
            x = 1;
        }
        else if (Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.UpArrow) || Input.GetKey(KeyCode.S) || Input.GetKey(KeyCode.DownArrow))
        {
            x = 0;
        }


        if (Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.UpArrow))
        {
            y = 1;
        }
        else if (Input.GetKey(KeyCode.S) || Input.GetKey(KeyCode.DownArrow))
        {
            y = -1;
        }
        else if (Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.LeftArrow) || Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.RightArrow))
        {
            y = 0;
        }

        if (!Dialogbox.instance.IsDisplaying && Input.GetKeyDown(KeyCode.Space))
        {
            _lookDir = new Vector2(x, y);

            RaycastHit2D hit = Physics2D.Raycast((Vector2)transform.position, _lookDir, 1, _mask);
            Debug.Log(hit.transform);
            if (hit.transform != null && hit.transform.GetComponent<IInteractable>() != null)
            {
                hit.transform.GetComponent<IInteractable>().Interact();
            }
        }
    }
}
