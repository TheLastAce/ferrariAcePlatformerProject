using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float Speed;
    float move;

    public float Jump;
    public bool IsJumping;
    Rigidbody2D rb;
    public Vector2 MovementVector;
    public float WallJumpOffset; 
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        move = Input.GetAxis("Horizontal");
       // MovementVector = new Vector2 ((Speed * move) + WallJumpOffset, rb.velocity.y);
        rb.velocity = new Vector2(Speed * move, rb.velocity.y);

        if (Input.GetButtonDown("Jump") && IsJumping == false)
            rb.AddForce(new Vector2(rb.velocity.x, Jump));
    }
    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.CompareTag("Ground"))
            IsJumping = false;
    }
    private void OnCollisionExit2D(Collision2D other)
    {
        if (other.gameObject.CompareTag("Ground"))
            IsJumping = true;
    }
}
