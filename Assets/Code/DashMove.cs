using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DashMove : MonoBehaviour
{
    PlayerMovement playerMove;
    bool canDash = true;
    bool isDashing;
    float dashingPower = 24f;
    float dashingTime = 0.2f;
    float dashingCooldown = 1f;
    public Rigidbody2D Rb;
    public float DashDistance = 7f;
    float doubleTapTime;
    KeyCode lastKeyCode;

    public TrailRenderer tr;
    public AudioClip Woosh;
    public AudioSource Player;

    /* private IEnumerator DashTr()
     {
         canDash = false;
         isDashing = true; //you right, I am dashing---ly good looking! :D
         Rb.gravityScale = 0f;
         float originalGravity = Rb.gravityScale;

         Rb.velocity = new Vector2(transform.localScale.x * dashingPower, 0f);
         tr.emitting = true;
         yield return new WaitForSeconds(dashingTime);
         tr.emitting = false;
         Rb.gravityScale = originalGravity;
         isDashing = false;
         yield return new WaitForSeconds(dashingCooldown);
         canDash = true;
     }*/

    public void Start()
    {
        playerMove = GetComponent<PlayerMovement>();
    }
    IEnumerator Dash(float direction)
        {
        Player.PlayOneShot(Woosh);
        tr.emitting = true;
        canDash = false;
        playerMove.enabled = false;
        isDashing = true;
        Rb.velocity = new Vector2(Rb.velocity.x, 0f);
        Rb.AddForce(new Vector2(DashDistance * direction, 0f), ForceMode2D.Impulse);
        float gravity = Rb.gravityScale;
        Rb.gravityScale = 0f;
        yield return new WaitForSeconds(0.5f);
        Rb.gravityScale = gravity;
        playerMove.enabled = true;
        yield return new WaitForSeconds(0.5f);
        isDashing = false;
        tr.emitting = false;
        canDash = true;
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.A))
        {
            if(doubleTapTime > Time.time && lastKeyCode == KeyCode.A && canDash)
            {
               // print("Double A");
                StartCoroutine(Dash(-1f));
            }
            else
            {
                doubleTapTime = Time.time + 0.2f;
            }
            lastKeyCode = KeyCode.A;
        }
        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            if (doubleTapTime > Time.time && lastKeyCode == KeyCode.LeftArrow && canDash)
            {
                // print("Double A");
                StartCoroutine(Dash(-1f));
            }
            else
            {
                doubleTapTime = Time.time + 0.2f;
            }
            lastKeyCode = KeyCode.LeftArrow;
        }
        if (Input.GetKeyDown(KeyCode.D))
        {
            if (doubleTapTime > Time.time && lastKeyCode == KeyCode.D && canDash)
            {
                StartCoroutine(Dash(1f));
            }
            else
            {
                doubleTapTime = Time.time + 0.2f;
            }
            lastKeyCode = KeyCode.D;
        }
        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            if (doubleTapTime > Time.time && lastKeyCode == KeyCode.RightArrow && canDash)
            {
                // print("Double A");
                StartCoroutine(Dash(1f));
            }
            else
            {
                doubleTapTime = Time.time + 0.2f;
            }
            lastKeyCode = KeyCode.RightArrow;
        }
        /* if (isDashing)
             return;
         if (Input.GetKeyDown(KeyCode.Return) && canDash)
             StartCoroutine(DashTr());*/
    }
    private void FixedUpdate()
    {
        if (isDashing)
            return;
       // if (!isDashing)
         //   Rb.velocity = new Vector2(mx * speed, Rb.velocity.y);
    }
    /*
    Rigidbody2D Rb;
    public float dashSpeed;
    float DashTime;
    public float startDashTime;
    int Direction;
    public float defaultDashSpeed;

    private void Start()
    {
        Rb = GetComponent<Rigidbody2D>();
        DashTime = startDashTime;
        Direction = 0;
    }

    private void FixedUpdate()
    {

      
            if (Input.GetKey(KeyCode.A))
            {
                Direction = 1;
            }
            else if (Input.GetKey(KeyCode.D))
                {
                Direction = 2; 
            }
            else
            {
                dashSpeed = 0;
            }*/

    // Fuck this Im restarting
    /* if(dashSpeed != 0)
     {
         if (DashTime <= 0)
         {
             Direction = 0;
             DashTime = startDashTime;
             Rb.velocity = Vector2.zero;
         }
         else
         {
             DashTime -= Time.deltaTime;
         }
     }
     if (Input.GetKeyDown(KeyCode.Return) && Direction == 1)
     {
         Rb.velocity = Vector2.left * dashSpeed;
     }
     if (Input.GetKeyDown(KeyCode.Return) && Direction ==2)
     {
         Rb.velocity = Vector2.right * dashSpeed;
     }  
 } */

}

// getcomponent<DashMove>().enabled = true/false;