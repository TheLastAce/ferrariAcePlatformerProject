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
    public float JumpDirection;
    public bool DoJump;
    public bool DoWallJump;
    public bool IsOnWall;
    public float WallJumpTimer;
    public float WallJumpTimerMax;
    public Vector2 wallJumpForce;
    public bool CanMove; 
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        CanMove = true;
    }

    // Update is called once per frame
    void Update()
    {
        move = Input.GetAxis("Horizontal");
        if (Input.GetButtonDown("Jump") && IsJumping == false)
        {
            DoJump = true; 
        }
        if (Input.GetButtonDown("Jump") && IsOnWall == true && IsJumping)
        {
            DoWallJump = true;
        }
    }
    private void FixedUpdate()
    {
        
        if(DoWallJump)
        {
                rb.AddForce(new Vector2(JumpDirection * wallJumpForce.x, wallJumpForce.y), ForceMode2D.Impulse);
            DoWallJump = false;
        }
        else
        {
            if (CanMove)
            {
                var xMove = (Speed * move);
                rb.velocity = new Vector2(xMove, rb.velocity.y);
            }
            if (DoJump == true && IsJumping == false && IsOnWall == false)
            {
                rb.AddForce(new Vector2(rb.velocity.x, Jump));
                DoJump = false;
                Debug.Log("Did jump");
            }
        }
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
