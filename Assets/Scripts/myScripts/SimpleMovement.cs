using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]

public class SimpleMovement : MonoBehaviour
{
    public int HorizontalSpeed = 5;
    public int VerticalSpeed = 10;
    private Rigidbody2D rb2d;

    // Start is called before the first frame update
    void Awake()
    {
        rb2d = GetComponent<Rigidbody2D>();
    }

    private void FixedUpdate()
    {
        //rb2d.velocity = new Vector2(transform.localScale.x * moveSpeed, rb2d.velocity.y);

        rb2d.velocity = new Vector2(transform.localScale.x * HorizontalSpeed, Input.GetAxis("Vertical") * VerticalSpeed);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
