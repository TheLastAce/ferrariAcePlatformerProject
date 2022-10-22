using System.Collections;
using UnityEngine;

public class WallJump : MonoBehaviour
{
    public float Speed;
    // float move;
    private float jumpDirection;

    PlayerMovement playerMove;
    public float WJump;
    public bool IsWallJumping;
    public bool IsOnWall;
    Rigidbody2D rb;
    bool doWallJump;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        playerMove = GetComponent<PlayerMovement>();
    }


    private void FixedUpdate()
    {
        if (doWallJump)
        {
            rb.AddForce(new Vector2(jumpDirection * WJump, WJump), ForceMode2D.Impulse);
            doWallJump = false;

        }
    }
    private void OnCollisionEnter2D(Collision2D other)
    {
        if (IsOnWall == false)
        {
            if (other.gameObject.CompareTag("WallL"))
            {
                playerMove.IsOnWall = true;
                playerMove.JumpDirection = 1;
            }
            else if (other.gameObject.CompareTag("WallR"))
            {
                playerMove.IsOnWall = true;
                playerMove.JumpDirection = -1;
            }
        }
    }
    private void OnCollisionExit2D(Collision2D other)
    {
        if (other.gameObject.CompareTag("WallL") || other.gameObject.CompareTag("WallR"))
        {
            playerMove.IsOnWall = false;
        }
    }
}