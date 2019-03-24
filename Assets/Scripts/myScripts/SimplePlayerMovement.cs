using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]

public class SimplePlayerMovement : MonoBehaviour
{
    private Rigidbody2D rb2d;
    public Animator animator;

    public int speedMultiplier = 10;

    void Awake()
    {
        rb2d = GetComponent<Rigidbody2D>();
    }

    void FixedUpdate()
    {
        animator.SetFloat("Right", Input.GetAxis("Horizontal"));
        animator.SetFloat("Left", -Input.GetAxis("Horizontal"));

        animator.SetFloat("Up", Input.GetAxis("Vertical"));
        animator.SetFloat("Down", -Input.GetAxis("Vertical"));



        rb2d.velocity = new Vector2(Mathf.Lerp(0, Input.GetAxis("Horizontal") * speedMultiplier, 0.8f),
                                    Mathf.Lerp(0, Input.GetAxis("Vertical") * speedMultiplier, 0.8f));
    }
}
