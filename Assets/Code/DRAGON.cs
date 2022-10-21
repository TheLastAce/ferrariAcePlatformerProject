using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DRAGON : MonoBehaviour
{
    public Rigidbody2D rb;
    public float speed  = 1f;
    // Start is called before the first frame update
    void Start()
    {
        rb.velocity = new Vector2(rb.velocity.x, speed * 1);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
