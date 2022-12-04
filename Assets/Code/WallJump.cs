using System.Collections;
using UnityEngine;

public class WallJump : MonoBehaviour
{
    public float Speed;
    // float move;
    private float jumpDirection;

    PlayerMovement playerMove;
    public float WJumpx;
    public float WJumpy;
    public bool IsWallJumping;
    public bool IsOnWall;
    Rigidbody2D rb;
    bool doWallJump;

    public AudioClip JumpBounce;
    public AudioSource Player;
    // Start is called before the first frame update
    private void OnEnable()
    {
        //Debug.Log("work pls");
    }
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        playerMove = GetComponent<PlayerMovement>();
    }

    // Update is called once per frame
    void Update()
    {
        //move = Input.GetAxis("Horizontal");
        //rb.velocity = new Vector2(Speed * move, rb.velocity.y);

        if (Input.GetButtonDown("Jump") && IsOnWall == true)
        {
            playerMove.enabled = false;

            StartCoroutine(TheJump(jumpDirection));
        }
    }
    IEnumerator TheJump(float direction)
    {
        rb.AddForce(new Vector2(direction * WJumpx, WJumpy), ForceMode2D.Impulse);
        Player.PlayOneShot(JumpBounce);
        yield return new WaitForSeconds(.25f);
        playerMove.enabled = true;

    }

    private void OnCollisionEnter2D(Collision2D other)
    {
     
            if (other.gameObject.CompareTag("WallL"))
            {
                //  IsWallJumping = false;
                IsOnWall = true;
                jumpDirection = 1;
            }
            else if (other.gameObject.CompareTag("WallR"))
            {
                //  IsWallJumping = false;
                IsOnWall = true;
                jumpDirection = -1;
            } 
    }
    private void OnCollisionExit2D(Collision2D other)
    {
        if (other.gameObject.CompareTag("WallL") || other.gameObject.CompareTag("WallR"))
        {
            // IsWallJumping = true;
            IsOnWall = false;
        }
    }
    //attempt 3
    /* public float WallJumpCoolDown;

    public void FixedUpdate()
    {
        if (WallJumpCoolDown > 0.2f)
        {
            if (IsOnWall)
            {
                rb.gravityScale = 0;
                rb.velocity = Vector2.zero;
                if(Input.GetKeyDown(KeyCode.Space))
                {
                    WallJumpCoolDown = 0;
                    rb.velocity = new Vector2(-Mathf.Sign(transform.localScale.x) * WJump, WJump);
                }
            }
            else
                rb.gravityScale = 1;
        }
        else
            WallJumpCoolDown += Time.deltaTime;
    }
    */





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
// awwwww whyyyyyyyyyy?
