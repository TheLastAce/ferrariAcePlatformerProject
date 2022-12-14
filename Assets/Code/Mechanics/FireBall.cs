using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireBall : MonoBehaviour
{
    float moveSpeed = 1f;
    public GameObject CheckPoint;
    public GameObject Dragon;
    Rigidbody2D rb;
    public PlayerMovement Target;
    Vector2 moveDirection;
    // Start is called before the first frame update
    void Start()
    {
        //Target = chosenPlayer;
        rb = GetComponent<Rigidbody2D>();
        Target = FindObjectOfType<PlayerMovement>();
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
            Target.transform.position = CheckPoint.transform.position;
            Target.PlaySound(Target.DeathSound);
            Dragon.transform.position = new Vector3(.57f, 3.75f, 0);
            var FireBalls = FindObjectsOfType<FireBall>();
            //for loop fireballs[i] != this
            for (int i = 0; i >= FireBalls.Length; i++)
            {
                if (FireBalls[i] != this)
                {
                    Destroy(FireBalls[i].gameObject);
                }
            }
            Destroy(this.gameObject);
        }
        else if (collision.tag == "WallL" || collision.tag == "WallR") // remember to change so only when colliding with borders!
        {
            Destroy(gameObject);
        }
    }
}
