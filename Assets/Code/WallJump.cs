using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WallJump : MonoBehaviour
{
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

    //GetCompnent<DashMOve>().enabled = true;
}
