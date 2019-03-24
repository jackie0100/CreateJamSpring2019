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
        if (Dialogbox.instance.IsDisplaying)
        {
            rb2d.velocity = new Vector2(Mathf.Lerp(0, 0 * speedMultiplier, 0.8f),
                            Mathf.Lerp(0, 0* speedMultiplier, 0.8f));
            animator.SetFloat("Right", 0);
            animator.SetFloat("Left", 0);

            animator.SetFloat("Up", 0);
            animator.SetFloat("Down", 0);

            return;
        }

        animator.SetFloat("Right", Input.GetAxis("Horizontal"));
        animator.SetFloat("Left", -Input.GetAxis("Horizontal"));

        animator.SetFloat("Up", Input.GetAxis("Vertical"));
        animator.SetFloat("Down", -Input.GetAxis("Vertical"));

        rb2d.velocity = new Vector2(Mathf.Lerp(0, Input.GetAxis("Horizontal") * speedMultiplier, 0.8f),
                                    Mathf.Lerp(0, Input.GetAxis("Vertical") * speedMultiplier, 0.8f));
    }
}
