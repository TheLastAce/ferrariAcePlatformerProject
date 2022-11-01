using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour
{
    public static GameController Gc;
    DialougeSystem dialougeSystem;
    Test testInstance;

    

    public Vector3 CheckPointPos;
    // Start is called before the first frame update
    void Start()
    {
        //dialougeSystem.enabled = false;
        // testInstance.enabled = false;
        if (Gc == null)
        {
            Gc = this;
        }
        else
        {
            Destroy(Gc);
        }
        DontDestroyOnLoad(Gc);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
   /* private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            CheckPointPos
            //SceneManager.LoadScene("level3");
        }
    }*/
}
