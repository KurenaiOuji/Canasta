using UnityEngine;

public class Movimiento : MonoBehaviour
{
    public float Speed;
    Rigidbody2D rb;
    bool FacingRight = true;
    Animator animator;
    public Joystick Joystick;
    float inputMove;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        animator = GetComponent<Animator>();
    }

    void Update()
    {
        Movement();
    }

    void Movement()
    {
        inputMove = Input.GetAxis("Horizontal");
        
        if(inputMove != 0f)
        {
            animator.SetBool("Walk", true);
        }

        else
        {
            animator.SetBool("Walk", false);
        }

        rb.velocity = new Vector2(inputMove * Speed, rb.velocity.y);
        
        Orientation(inputMove);
    }

    void Orientation(float inputMove)
    {
        if ((FacingRight == true && inputMove < 0) || (FacingRight == false && inputMove > 0))
        {
            FacingRight = !FacingRight;
            transform.localScale = new Vector2(-transform.localScale.x, transform.localScale.y);
        }
    }
}
