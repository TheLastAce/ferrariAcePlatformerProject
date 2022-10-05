using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WallJump : MonoBehaviour
{
    public float Speed;
    float move;

    public float WJump;
    public bool IsWallJumping;
    public bool IsOnWall;
    Rigidbody2D rb;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        move = Input.GetAxis("Horizontal");
        rb.velocity = new Vector2(Speed * move, rb.velocity.y);

        if (Input.GetButtonDown("Jump") && IsOnWall == true)
            rb.AddForce(new Vector2(rb.velocity.x + WJump, WJump));
    }
    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.CompareTag("Wall"))
        { 
            IsWallJumping = false;
            IsOnWall = true;
        }
    }
    private void OnCollisionExit2D(Collision2D other)
    {
        if (other.gameObject.CompareTag("Wall"))
        {
            IsWallJumping = true;
            IsOnWall = false;
        }
    }


    /*attempt 2
    public float WallJumpTime = .2f;
    public float WallSlideSpeed = .1f;
    public float WallDistance = .5f;
    bool isWallSliding = false;
    RaycastHit2D wallCheckTime; // I can do this better later
    float jumpTime;
    */

    /*attempt 1
    bool onWall;
    bool isWallJumping;
    public float xWallForce;
    public float yWallForce;
    public float wallJumpTime;

    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.CompareTag("wall"))
            onWall = true;
    }
    private void Update()
    {

        if (Input.GetKeyDown(KeyCode.Space) && onWall == true)
        {
            isWallJumping = true;
            //Invoke("SetWallJumpingFalse" )
        }
    }

    void SetWallJumpingFalse()
    {
        isWallJumping = false;
    }

    //GetCompnent<DashMOve>().enabled = true;*/
}
