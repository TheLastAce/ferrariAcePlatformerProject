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
    public bool DoJump;
    public bool DoWallJump;
    public float Distance;
    public LayerMask GroundMask;
    
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        move = Input.GetAxis("Horizontal");

        RaycastHit2D hit = Physics2D.Raycast(transform.position, -Vector2.up, Distance, GroundMask);
        if(hit.transform != null)
        {
            IsJumping = false;
        }
        else
        {
            IsJumping = true;
        }
       // MovementVector = new Vector2 ((Speed * move) + WallJumpOffset, rb.velocity.y);
        

        if (Input.GetButtonDown("Jump") && IsJumping == false)
            DoJump = true;
    }

    public void FixedUpdate()
    {
        if (DoJump)
        {
            rb.AddForce(new Vector2(rb.velocity.x, Jump));
            DoJump = false;
        }
        rb.velocity = new Vector2(Speed * move, rb.velocity.y);
    }
    private void OnCollisionEnter2D(Collision2D other)
    {
       // if (other.gameObject.CompareTag("Ground"))
           // IsJumping = false;
    }
    private void OnCollisionExit2D(Collision2D other)
    {
       // if (other.gameObject.CompareTag("Ground"))
            //IsJumping = true;
    }
}
/*
 * gAME manager
 * public static gamemanager instance;
 * 
 * if(instance == null
 *  instance = this;
 * else
 *  destroy(gameObject);
 * DontDestoryOnLoad(gameObject);
 * 
 * 
 * 
 * 
 * gameManager.instance.var = x;
 * 
 * everytime you load a new scene everything is destroyed
 * dontdestroyonload allows it to stay in the scene
 * */
