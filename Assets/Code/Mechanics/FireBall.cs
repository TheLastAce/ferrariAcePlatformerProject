using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireBall : MonoBehaviour
{
    float moveSpeed = 2f;
    public GameObject CheckPoint;
    public GameObject Dragon;
    Rigidbody2D rb;
    public GameObject Target;
    Vector2 moveDirection;
    // Start is called before the first frame update
    void Start()
    {
        //Target = chosenPlayer;
        rb = GetComponent<Rigidbody2D>();
        Target = FindObjectOfType<PlayerMovement>().gameObject;
        Dragon = FindObjectOfType<DRAGON>().gameObject;
        CheckPoint = GameObject.FindGameObjectWithTag("CheckPoint");
        moveDirection = (Target.transform.position - transform.position).normalized * moveSpeed;
        rb.velocity = new Vector2(moveDirection.x, moveDirection.y);
        //Destroy(gameObject, 3f);
    }
   // public void HandlePlayerSpawnedEvent(GameObject chosenPlayer)
    
       
    

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag == "Player")
        {
            Destroy(this);
            Target.transform.position = CheckPoint.transform.position;
            Dragon.transform.position = new Vector3(0, 18.25f, 0);
        }
        else if (collision.tag == "WallL" || collision.tag == "WallR") // remember to change so only when colliding with borders!
        {
            Destroy(this);
        }
    }
}