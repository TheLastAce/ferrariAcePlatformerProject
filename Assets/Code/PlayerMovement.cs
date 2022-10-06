using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float speed;
    float Move;

    public float jump;
    public bool isJumping;
    Rigidbody2D Rb;
    // Start is called before the first frame update
    void Start()
    {
        Rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        Move = Input.GetAxis("Horizontal");
        Rb.velocity = new Vector2(speed * Move, Rb.velocity.y);

        if (Input.GetButtonDown("Jump") && isJumping == false)
            Rb.AddForce(new Vector2(Rb.velocity.x, jump));
    }
    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.CompareTag("Ground"))
<<<<<<< Updated upstream
            isJumping = false;
=======
            IsJumping = false;
        print("You are touching the ground!");
>>>>>>> Stashed changes
    }
    private void OnCollisionExit2D(Collision2D other)
    {
        if (other.gameObject.CompareTag("Ground"))
<<<<<<< Updated upstream
            isJumping = true;
=======
            IsJumping = true;
        print("You are no longer on the ground :o");
>>>>>>> Stashed changes
    }
}
